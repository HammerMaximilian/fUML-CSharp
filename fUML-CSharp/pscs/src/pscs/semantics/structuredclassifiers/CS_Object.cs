using fuml.semantics.actions;
using fuml.semantics.commonbehavior;
using fuml.semantics.loci;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using pscs.semantics.commonbehavior;
using uml.classification;
using uml.commonstructure;
using uml.simpleclassifiers;
using uml.structuredclassifiers;

namespace pscs.semantics.structuredclassifiers
{
    public class CS_Object : Object_
    {
        public Execution DispatchIn(Operation operation, CS_InteractionPoint interactionPoint)
        {
            // If the interaction point refers to a behavior port, the operation call is
            // dispatched
            // to the object owning the behavior port. This may result in the method being
            // handled
            // by the method defined for the operation at the object or through a call event
            // handled
            // by the classifier behavior of the owning object. The latter case only occurs
            // if the
            // dispatched operation has no implementation
            // If it does not refer to a behavior port, select appropriate delegation links
            // from interactionPoint, and propagates the operation call through
            // these links
            Execution? execution = null;
            if ((interactionPoint.definingPort?.isBehavior) ?? false)
            {
                execution = Dispatch(operation);
                if (execution is CS_CallEventExecution cS_CallEventExecution)
                {
                    cS_CallEventExecution.interactionPoint = interactionPoint;
                }
            }
            else
            {
                bool operationIsProvided = true;
                List<Reference> potentialTargets = new();
                List<CS_Link> cddLinks = GetLinks(interactionPoint);
                int linkIndex = 1;
                while (linkIndex <= cddLinks.Count)
                {
                    List<Reference> validTargets = SelectTargetsForDispatching(cddLinks.ElementAt(linkIndex - 1),
                            interactionPoint, ConnectorKind.delegation, operation, operationIsProvided);
                    int targetIndex = 1;
                    while (targetIndex <= validTargets.Count)
                    {
                        potentialTargets.Add(validTargets.ElementAt(targetIndex - 1));
                        targetIndex++;
                    }
                    linkIndex++;
                }
                // If potentialTargets is empty, no delegation target have been found,
                // and the operation call will be lost
                if (!(potentialTargets.Count == 0))
                {
                    CS_RequestPropagationStrategy strategy = (CS_RequestPropagationStrategy)locus?.factory?.GetStrategy("requestPropagation")!;
                    // Choose one target non-deterministically
                    List<Reference> targets = strategy.select(potentialTargets, new CallOperationActionActivation());
                    Reference target = targets.ElementAt(0);
                    execution = target.Dispatch(operation);
                }
            }
            return execution!;
        }

        public void SendIn(EventOccurrence eventOccurrence, CS_InteractionPoint interactionPoint)
        {
            // 1] If the interaction is a behavior port then sends the event occurrence to
            // the target
            // object using operation send.
            // 2] If this is not a behavior port, select appropriate delegation targets from
            // interactionPoint,
            // and propagates the event occurrence to these targets
            if ((interactionPoint.definingPort?.isBehavior) ?? false)
            {
                Send(eventOccurrence);
            }
            else
            {
                bool toInternal = true;
                List<Reference> potentialTargets = new();
                List<CS_Link> cddLinks = GetLinks(interactionPoint);
                int linkIndex = 1;
                while (linkIndex <= cddLinks.Count)
                {
                    List<Reference> validTargets = SelectTargetsForSending(cddLinks.ElementAt(linkIndex - 1),
                            interactionPoint, ConnectorKind.delegation, toInternal);
                    int targetIndex = 1;
                    while (targetIndex <= validTargets.Count)
                    {
                        potentialTargets.Add(validTargets.ElementAt(targetIndex - 1));
                        targetIndex++;
                    }
                    linkIndex++;
                }
                // If potential targets is empty, no delegation target has been found,
                // and the signal is lost
                // Otherwise, do the following concurrently
                foreach (Reference target in potentialTargets)
                {
                    target.Send(eventOccurrence);
                }
            }
        }

        public List<Reference> SelectTargetsForSending(CS_Link link, CS_InteractionPoint interactionPoint,
            ConnectorKind connectorKind, bool toInternal)
        {
            // From the given link, signal and interaction point, retrieves potential
            // targets (i.e. end values of link)
            // through which request can be propagated
            // These targets are attached to interaction point through the given link, and
            // respect the following rules:
            // - if toInternal is true, connectorKind must be Delegation, the given link has
            // to target the internals of this CS_Object
            // - if toInternal is false, the given link has to target the environment of
            // this CS_Object.
            List<Reference> potentialTargets = new();
            if (toInternal && connectorKind == ConnectorKind.delegation)
            {
                if (GetLinkKind(link, interactionPoint) == CS_LinkKind.ToInternal)
                {
                    int i = 1;
                    while (i <= link.GetFeatureValues().Count)
                    {
                        List<Value> values = link.GetFeatureValues().ElementAt(i - 1).values;
                        if (values.Any())
                        {
                            int j = 1;
                            while (j <= values.Count)
                            {
                                Reference cddTarget = (Reference)values.ElementAt(j - 1);
                                if (!cddTarget.Equals(interactionPoint))
                                {
                                    potentialTargets.Add(cddTarget);
                                }
                                j++;
                            }
                        }
                        i++;
                    }
                }
            }
            else
            { // to Environment
                if (GetLinkKind(link, interactionPoint) == CS_LinkKind.ToEnvironment)
                {
                    int i = 1;
                    while (i <= link.GetFeatureValues().Count)
                    {
                        List<Value> values = link.GetFeatureValues().ElementAt(i - 1).values;
                        if (values.Any() && values.ElementAt(0) is Reference reference)
                        {
                            Reference cddTarget = reference;
                            if (connectorKind == ConnectorKind.assembly)
                            {
                                if (cddTarget is not CS_InteractionPoint)
                                { // This is an assembly link
                                    potentialTargets.Add(cddTarget);
                                }
                                else
                                {
                                    // This is an assembly if the interaction point is not a feature value
                                    // for a container of this CS_Object
                                    List<CS_Object> directContainers = GetDirectContainers();
                                    bool isAssembly = true;
                                    int j = 1;
                                    if (!HasValueForAFeature(cddTarget))
                                    {
                                        while (isAssembly && j <= directContainers.Count)
                                        {
                                            CS_Object container = directContainers.ElementAt(j - 1);
                                            if (container.HasValueForAFeature(cddTarget))
                                            {
                                                isAssembly = false;
                                            }
                                            j++;
                                        }
                                    }
                                    else
                                    {
                                        isAssembly = false;
                                    }
                                    if (isAssembly)
                                    {
                                        potentialTargets.Add(cddTarget);
                                    }
                                }
                            }
                            else
                            { // delegation
                              // This is a delegation if the target is an interaction point
                              // and if this interaction is a feature value for a container of this CS_Object
                                if (cddTarget is CS_InteractionPoint)
                                {
                                    List<CS_Object> directContainers = GetDirectContainers();
                                    bool isDelegation = false;
                                    int j = 1;
                                    while (!isDelegation && j <= directContainers.Count)
                                    {
                                        CS_Object container = directContainers.ElementAt(j - 1);
                                        if (container.HasValueForAFeature(cddTarget))
                                        {
                                            isDelegation = true;
                                        }
                                        j++;
                                    }
                                    if (isDelegation)
                                    {
                                        potentialTargets.Add(cddTarget);
                                    }
                                }
                            }
                        }
                        i++;
                    }
                }
            }
            return potentialTargets;
        }

        public List<Reference> SelectTargetsForDispatching(CS_Link link, CS_InteractionPoint interactionPoint,
            ConnectorKind connectorKind, Operation operation, bool toInternal)
        {
            // From the given link, operation and interaction point, retrieves potential
            // targets (i.e. end values of link)
            // through which request can be propagated
            // These targets are attached to interaction point through the given link, and
            // respect the following rules:
            // - if isProvided is true, connectorKind must be Delegation, the given link has
            // to target the internals of this CS_Object,
            // and a valid target must provide the Operation
            // - if isProvided is false, the given link has to target the environment of
            // this CS_Object.
            // - if connectorKind is assembly, a valid target has to provide the operation
            // - if connectorKind is delegation, a valid target has to require the operation
            List<Reference> potentialTargets = new();
            if (toInternal && connectorKind == ConnectorKind.delegation)
            {
                if (GetLinkKind(link, interactionPoint) == CS_LinkKind.ToInternal)
                {
                    int i = 1;
                    while (i <= link.GetFeatureValues().Count)
                    {
                        List<Value> values = link.GetFeatureValues().ElementAt(i - 1).values;
                        if (values.Any() && values.ElementAt(0) is Reference reference)
                        {
                            Reference cddTarget = reference;
                            if (cddTarget != interactionPoint && IsOperationProvided(cddTarget, operation))
                            {
                                potentialTargets.Add(cddTarget);
                            }
                        }
                        i++;
                    }
                }
            }
            else
            { // to environment
                if (GetLinkKind(link, interactionPoint) == CS_LinkKind.ToEnvironment)
                {
                    int i = 1;
                    while (i <= link.GetFeatureValues().Count)
                    {
                        List<Value> values = link.GetFeatureValues().ElementAt(i - 1).values;
                        if (values.Any() && values.ElementAt(0) is Reference reference)
                        {
                            Reference cddTarget = reference;
                            if (connectorKind == ConnectorKind.assembly)
                            {
                                if (cddTarget is not CS_InteractionPoint)
                                { // This is an assembly link
                                    if (IsOperationProvided(cddTarget, operation))
                                    {
                                        potentialTargets.Add(cddTarget);
                                    }
                                }
                                else
                                {
                                    // This is an assembly if the interaction point is not a feature value
                                    // for a container of this CS_Object
                                    List<CS_Object> directContainers = GetDirectContainers();
                                    bool isAssembly = true;
                                    int j = 1;
                                    if (!HasValueForAFeature(cddTarget))
                                    {
                                        while (isAssembly && j <= directContainers.Count)
                                        {
                                            CS_Object container = directContainers.ElementAt(j - 1);
                                            if (container.HasValueForAFeature(cddTarget))
                                            {
                                                isAssembly = false;
                                            }
                                            j++;
                                        }
                                    }
                                    else
                                    {
                                        isAssembly = false;
                                    }
                                    if (isAssembly)
                                    {
                                        if (IsOperationProvided(cddTarget, operation))
                                        {
                                            potentialTargets.Add(cddTarget);
                                        }
                                    }
                                }
                            }
                            else
                            { // delegation
                              // This is a delegation if the target is an interaction point
                              // and if this interaction is a feature value for a container of this CS_Object
                                if (cddTarget is CS_InteractionPoint)
                                {
                                    List<CS_Object> directContainers = GetDirectContainers();
                                    bool isDelegation = false;
                                    int j = 1;
                                    while (!isDelegation && j <= directContainers.Count)
                                    {
                                        CS_Object container = directContainers.ElementAt(j - 1);
                                        if (container.HasValueForAFeature(cddTarget))
                                        {
                                            isDelegation = true;
                                        }
                                        j++;
                                    }
                                    if (isDelegation)
                                    {
                                        if (IsOperationRequired(cddTarget, operation))
                                        {
                                            potentialTargets.Add(cddTarget);
                                        }
                                    }
                                }
                            }
                        }
                        i++;
                    }
                }
            }
            return potentialTargets;
        }

        public void SendOut(EventOccurrence eventOccurrence, CS_InteractionPoint interactionPoint)
        {
            // Select appropriate delegation links from interactionPoint,
            // and propagates the event occurrence through these links
            // Appropriate links are links which target elements
            // in the environment of this CS_Object.
            // These can be delegation links (i.e, the targeted elements must
            // require a reception for the signal) or assembly links (i.e., the target
            // elements
            // must provide a reception for the signal)
            bool notToInternal = false; // i.e. to environment
            List<Reference> allPotentialTargets = new();
            List<Reference> targetsForSendingIn = new();
            List<Reference> targetsForSendingOut = new();
            List<CS_Link> cddLinks = GetLinks(interactionPoint);
            int linkIndex = 1;
            while (linkIndex <= cddLinks.Count)
            {
                List<Reference> validAssemblyTargets = SelectTargetsForSending(cddLinks.ElementAt(linkIndex - 1),
                        interactionPoint, ConnectorKind.assembly, notToInternal);
                int targetIndex = 1;
                while (targetIndex <= validAssemblyTargets.Count)
                {
                    allPotentialTargets.Add(validAssemblyTargets.ElementAt(targetIndex - 1));
                    targetsForSendingIn.Add(validAssemblyTargets.ElementAt(targetIndex - 1));
                    targetIndex++;
                }
                List<Reference> validDelegationTargets = SelectTargetsForSending(cddLinks.ElementAt(linkIndex - 1),
                        interactionPoint, ConnectorKind.delegation, notToInternal);
                targetIndex = 1;
                while (targetIndex <= validDelegationTargets.Count)
                {
                    allPotentialTargets.Add(validDelegationTargets.ElementAt(targetIndex - 1));
                    targetsForSendingOut.Add(validDelegationTargets.ElementAt(targetIndex - 1));
                    targetIndex++;
                }
                linkIndex++;
            }
            CS_RequestPropagationStrategy strategy = (CS_RequestPropagationStrategy)locus?.factory?.GetStrategy("requestPropagation")!;
            List<Reference> selectedTargets = strategy.select(allPotentialTargets, new SendSignalActionActivation());
            for (int j = 0; j < selectedTargets.Count; j++)
            {
                Reference target = selectedTargets.ElementAt(j);
                for (int k = 0; k < targetsForSendingIn.Count; k++)
                {
                    Reference cddTarget = targetsForSendingIn.ElementAt(k);
                    if (cddTarget == target)
                    {
                        target.Send(eventOccurrence);
                    }
                }
                for (int k = 0; k < targetsForSendingOut.Count; k++)
                {
                    // The target must be an interaction point
                    // i.e. a delegation connector for a required reception can only target a port
                    CS_InteractionPoint cddTarget = (CS_InteractionPoint)targetsForSendingOut.ElementAt(k);
                    if (cddTarget == target)
                    {
                        CS_Reference? owner = cddTarget.owner;
                        owner?.SendOut(eventOccurrence, cddTarget);
                    }
                }
            }
        }

        public Execution DispatchOut(Operation operation, CS_InteractionPoint interactionPoint)
        {
            // Select appropriate delegation links from interactionPoint,
            // and propagates the operation call through these links
            // Appropriate links are links which target elements
            // in the environment of this CS_Object.
            // These can be delegation links (i.e, the targeted elements must
            // require the operation) or assembly links (i.e., the target elements
            // must provide the operation)
            Execution? execution = null;
            bool notToInternal = false; // i.e. to environment
            List<Reference> allPotentialTargets = new();
            List<Reference> targetsForDispatchingIn = new();
            List<Reference> targetsForDispatchingOut = new();
            List<CS_Link> cddLinks = GetLinks(interactionPoint);
            int linkIndex = 1;
            while (linkIndex <= cddLinks.Count)
            {
                List<Reference> validAssemblyTargets = SelectTargetsForDispatching(cddLinks.ElementAt(linkIndex - 1),
                        interactionPoint, ConnectorKind.assembly, operation, notToInternal);
                int targetIndex = 1;
                while (targetIndex <= validAssemblyTargets.Count)
                {
                    allPotentialTargets.Add(validAssemblyTargets.ElementAt(targetIndex - 1));
                    targetsForDispatchingIn.Add(validAssemblyTargets.ElementAt(targetIndex - 1));
                    targetIndex++;
                }
                List<Reference> validDelegationTargets = SelectTargetsForDispatching(cddLinks.ElementAt(linkIndex - 1),
                        interactionPoint, ConnectorKind.delegation, operation, notToInternal);
                targetIndex = 1;
                while (targetIndex <= validDelegationTargets.Count)
                {
                    allPotentialTargets.Add(validDelegationTargets.ElementAt(targetIndex - 1));
                    targetsForDispatchingOut.Add(validDelegationTargets.ElementAt(targetIndex - 1));
                    targetIndex++;
                }
                linkIndex++;
            }
            CS_RequestPropagationStrategy strategy = (CS_RequestPropagationStrategy)locus?.factory?.GetStrategy("requestPropagation")!;
            List<Reference> selectedTargets = strategy.select(allPotentialTargets, new SendSignalActionActivation());
            for (int j = 0; j < selectedTargets.Count; j++)
            {
                Reference target = selectedTargets.ElementAt(j);
                for (int k = 0; k < targetsForDispatchingIn.Count && execution == null; k++)
                {
                    Reference cddTarget = targetsForDispatchingIn.ElementAt(k);
                    if (cddTarget == target)
                    {
                        execution = target.Dispatch(operation);
                    }
                }
                for (int k = 0; k < targetsForDispatchingOut.Count && execution == null; k++)
                {
                    // The target must be an interaction point
                    // i.e. a delegation connector for a required operation can only target a port
                    CS_InteractionPoint cddTarget = (CS_InteractionPoint)targetsForDispatchingOut.ElementAt(k);
                    if (cddTarget == target)
                    {
                        CS_Reference? owner = cddTarget.owner;
                        execution = owner?.DispatchOut(operation, cddTarget);
                    }
                }
            }
            return execution!;
        }

        public override FeatureValue GetFeatureValue(StructuralFeature feature)
        {
            // In the case where the feature belongs to an Interface,
            // fUML semantics is extended in the sense that reading is
            // delegated to a CS_StructuralFeatureOfInterfaceAccessStrategy
            if (feature.namespace_ is Interface)
            {
                CS_StructuralFeatureOfInterfaceAccessStrategy readStrategy = (CS_StructuralFeatureOfInterfaceAccessStrategy)locus?.factory?.GetStrategy("structuralFeature")!;
                return readStrategy.Read(this, feature);
            }
            else
            {
                return base.GetFeatureValue(feature);
            }
        }

        public override void SetFeatureValue(StructuralFeature feature, List<Value> values, int position)
        {
            // In the case where the feature belongs to an Interface,
            // fUML semantics is extended in the sense that writing is
            // delegated to a CS_StructuralFeatureOfInterfaceAccessStrategy
            if (feature.namespace_ is Interface)
            {
                CS_StructuralFeatureOfInterfaceAccessStrategy writeStrategy = (CS_StructuralFeatureOfInterfaceAccessStrategy)locus?.factory?.GetStrategy("structuralFeature")!;
                writeStrategy.Write(this, feature, values, position);
            }
            else
            {
                base.SetFeatureValue(feature, values, position);
            }
        }

        public bool Contains(Object_ object_)
        {
            // Determines if the object given as a parameter is directly
            // or indirectly contained by this CS_Object
            bool objectIsContained = DirectlyContains(object_);
            // if object is not directly contained, restart the research
            // recursively on the objects owned by this CS_Object
            for (int i = 0; i < featureValues.Count && !objectIsContained; i++)
            {
                FeatureValue featureValue = featureValues.ElementAt(i);
                List<Value> values = featureValue.values;
                for (int j = 0; j < values.Count && !objectIsContained; j++)
                {
                    Value value = values.ElementAt(j);
                    if (value is CS_Object cS_Object_)
                    {
                        objectIsContained = cS_Object_.Contains(cS_Object_);
                    }
                    else if (value is CS_Reference reference)
                    {
                        CS_Object referent = reference.compositeReferent!;
                        objectIsContained = referent.Contains(object_);
                    }
                }
            }
            return objectIsContained;
        }

        public bool DirectlyContains(Object_ object_)
        {
            // Determines if the object given as a parameter is directly
            // contained by this CS_Object
            bool objectIsContained = false;
            for (int i = 0; i < featureValues.Count && !objectIsContained; i++)
            {
                FeatureValue featureValue = featureValues.ElementAt(i);
                List<Value> values = featureValue.values;
                for (int j = 0; j < values.Count && !objectIsContained; j++)
                {
                    Value value = values.ElementAt(j);
                    if (value == object_)
                    {
                        objectIsContained = true;
                    }
                    else if (value is CS_Reference reference)
                    {
                        objectIsContained = reference.referent == object_;
                    }
                }
            }
            return objectIsContained;
        }

        public List<CS_Object> GetDirectContainers()
        {
            // Retrieves all the extensional values at this locus which are direct
            // containers for this CS_Object
            // An extensional value is a direct container for an object if:
            // - it is a CS_Object
            // - it directly contains this object (i.e.
            // CS_Object.directlyContains(Object)==true)
            List<CS_Object> containers = new();
            List<ExtensionalValue> extensionalValues = locus?.extensionalValues ?? new();
            foreach (ExtensionalValue extensionalValue in extensionalValues)
            {
                if (extensionalValue != this && extensionalValue is CS_Object cS_object)
                {
                    CS_Object cddContainer = cS_object;
                    if (cddContainer.DirectlyContains(this))
                    {
                        containers.Add(cddContainer);
                    }
                }
            }
            return containers;
        }

        public bool IsOperationProvided(Reference reference, Operation operation)
        {
            // Determines if the given reference provides the operation
            // If the reference is an interaction point, it provides the operation if this
            // operation
            // is a member of one of its provided interfaces
            // If the reference is NOT an interactionPoint, it provides this operation if
            // this operation is
            // an operation of one of its type, or one of its type provides a realization
            // for this operation (in the case
            // where the namespace of this Operation is an interface)
            bool isProvided = false;
            if (reference is CS_InteractionPoint interactionPoint)
            {
                if (operation.owner is Interface)
                {
                    // We have to look in provided interfaces of the port if
                    // they define directly or indirectly the Operation
                    int interfaceIndex = 1;
                    // Iterates on provided interfaces of the port
                    List<Interface> providedInterfaces = interactionPoint.definingPort?.provided ?? new();
                    while (interfaceIndex <= providedInterfaces.Count && !isProvided)
                    {
                        Interface interface_ = providedInterfaces.ElementAt(interfaceIndex - 1);
                        // Iterates on members of the current Interface
                        int memberIndex = 1;
                        while (memberIndex <= interface_.AllMembers().Count && !isProvided)
                        {
                            NamedElement cddOperation = interface_.AllMembers().ElementAt(memberIndex - 1);
                            if (cddOperation is Operation)
                            {
                                isProvided = operation == cddOperation;
                            }
                            memberIndex++;
                        }
                        interfaceIndex++;
                    }
                }
            }
            else
            {
                // We have to look if one of the Classifiers typing this reference
                // directly or indirectly provides this operation
                List<Classifier> types = reference.GetTypes();
                int typeIndex = 1;
                while (typeIndex <= types.Count && !isProvided)
                {
                    if (types.ElementAt(typeIndex - 1) is Class_ class_)
                    {
                        int memberIndex = 1;
                        List<NamedElement> members = class_.AllMembers();
                        while (memberIndex <= members.Count && !isProvided)
                        {
                            NamedElement member = members.ElementAt(memberIndex - 1);
                            if (member is Operation cddOperation)
                            {
                                CS_DispatchOperationOfInterfaceStrategy strategy = new();
                                isProvided = strategy.OperationsMatch(cddOperation, operation);
                            }
                            memberIndex++;
                        }
                    }
                    typeIndex++;
                }
            }
            return isProvided;
        }

        public bool IsOperationRequired(Reference reference, Operation operation)
        {
            // Determines if the given reference requires the operation
            // If the reference is an interaction point, it requires the operation if this
            // operation
            // is a member of one of its required interfaces
            // If the reference is not a interaction point, it cannot require an operation
            bool matches = false;
            if (reference is CS_InteractionPoint interactionPoint)
            {
                int interfaceIndex = 1;
                // Iterates on provided interfaces of the port
                List<Interface> requiredInterfaces = interactionPoint.definingPort?.required ?? new();
                while (interfaceIndex <= requiredInterfaces.Count && !matches)
                {
                    Interface interface_ = requiredInterfaces.ElementAt(interfaceIndex - 1);
                    // Iterates on members of the current Interface
                    int memberIndex = 1;
                    while (memberIndex <= interface_.AllMembers().Count && !matches)
                    {
                        NamedElement cddOperation = interface_.AllMembers().ElementAt(memberIndex - 1);
                        if (cddOperation is Operation)
                        {
                            matches = operation == cddOperation;
                        }
                        memberIndex++;
                    }
                    interfaceIndex++;
                }
            }
            return matches;
        }

        public CS_LinkKind GetLinkKind(CS_Link link, CS_InteractionPoint interactionPoint)
        {
            // If the given interaction point belongs to this object, and if the given
            // interaction point is used as an end of the link,
            // then the links targets the environment of the object (enumeration literal
            // ToEnvironment) if all the feature values of the link
            // (but one for the interaction point) refer to values which are not themselves
            // values for features of this object.
            // If all the feature values of the link refer to values which are themselves
            // values for features of this object,
            // the link targets the internals of the object (enumeration literal
            // ToInternal). Otherwise, the link has no particular meaning
            // in the context defined by the object and the interaction point (enumeration
            // literal None).
            if (!link.HasValueForAFeature(interactionPoint))
            {
                return CS_LinkKind.None;
            }
            CS_LinkKind kind = CS_LinkKind.ToInternal;
            List<FeatureValue> featureValues = link.GetFeatureValues();
            int i = 1;
            while (i <= featureValues.Count && kind != CS_LinkKind.None)
            {
                FeatureValue value = featureValues.ElementAt(i - 1);
                if (!value.values.Any())
                {
                    kind = CS_LinkKind.None;
                }
                else
                {
                    Value v = value.values.ElementAt(0);
                    bool vIsAValueForAFeatureOfContext;
                    if (v.Equals(interactionPoint))
                    {
                        vIsAValueForAFeatureOfContext = true;
                    }
                    else if (v is CS_InteractionPoint vAsInteractionPoint)
                    {
                        v = vAsInteractionPoint.owner!;
                        vIsAValueForAFeatureOfContext = HasValueForAFeature(v);
                    }
                    else
                    {
                        vIsAValueForAFeatureOfContext = HasValueForAFeature(v);
                    }
                    if (!vIsAValueForAFeatureOfContext)
                    {
                        kind = CS_LinkKind.ToEnvironment;
                    }
                }
                i++;
            }
            return kind;
        }

        public List<CS_Link> GetLinks(CS_InteractionPoint interactionPoint)
        {
            // Get all links (available at the locus of this object) where the given
            // interaction point is used as a feature value
            // (i.e. the interaction is an end such links)
            List<ExtensionalValue> extensionalValues = locus?.extensionalValues ?? new();
            int i = 1;
            List<CS_Link> connectorInstances = new();
            while (i <= extensionalValues.Count)
            {
                ExtensionalValue value = extensionalValues.ElementAt(i - 1);
                if (value is CS_Link link)
                {
                    if (GetLinkKind(link, interactionPoint) != CS_LinkKind.None)
                    {
                        connectorInstances.Add(link);
                    }
                }
                i++;
            }
            return connectorInstances;
        }

        public bool HasValueForAFeature(Value value)
        {
            // Returns true if the given value object is used as a value for a feature value
            // of this object
            List<FeatureValue> allFeatureValues = GetFeatureValues();
            int i = 1;
            bool isAValue = false;
            while (i <= allFeatureValues.Count && !isAValue)
            {
                FeatureValue featureValue = allFeatureValues.ElementAt(i - 1);
                if (featureValue.values.Any())
                {
                    List<Value> valuesForCurrentFeature = featureValue.values;
                    int j = 1;
                    while (j <= valuesForCurrentFeature.Count && !isAValue)
                    {
                        isAValue = featureValue.values.ElementAt(j - 1).Equals(value);
                        j++;
                    }
                }
                i++;
            }
            return isAValue;
        }

        public void SendOut(EventOccurrence eventOccurrence, Port onPort)
        {
            // Select a CS_InteractionPoint value playing onPort,
            // and send the event occurrence to this interaction point
            FeatureValue featureValue = GetFeatureValue(onPort);
            List<Value> values = featureValue.values;
            List<Reference> potentialTargets = new();
            for (int i = 0; i < values.Count; i++)
            {
                potentialTargets.Add((Reference)values.ElementAt(i));
            }
            CS_RequestPropagationStrategy strategy = (CS_RequestPropagationStrategy)locus?.factory?.GetStrategy("requestPropagation")!;
            List<Reference> targets = strategy.select(potentialTargets, new SendSignalActionActivation());
            for (int i = 0; i < targets.Count; i++)
            {
                CS_InteractionPoint target = (CS_InteractionPoint)targets.ElementAt(i);
                SendOut(eventOccurrence, target);
            }
        }

        public Execution DispatchOut(Operation operation, Port onPort)
        {
            // Select a CS_InteractionPoint value playing onPort,
            // and dispatches the operation to this interaction point
            Execution? execution = null;
            FeatureValue featureValue = GetFeatureValue(onPort);
            List<Value> values = featureValue.values;
            List<Reference> potentialTargets = new();
            for (int i = 0; i < values.Count; i++)
            {
                potentialTargets.Add((Reference)values.ElementAt(i));
            }
            CS_RequestPropagationStrategy strategy = (CS_RequestPropagationStrategy)locus?.factory?.GetStrategy("requestPropagation")!;
            List<Reference> targets = strategy.select(potentialTargets, new CallOperationActionActivation());
            // if targets is empty, no dispatch target has been found,
            // and the operation call is lost
            if (targets.Count >= 1)
            {
                CS_InteractionPoint target = (CS_InteractionPoint)targets.ElementAt(0);
                execution = DispatchOut(operation, target);
            }
            return execution!;
        }

        public Execution DispatchIn(Operation operation, Port onPort)
        {
            // delegates dispatching to composite referent
            // Select a CS_InteractionPoint value playing onPort,
            // and dispatches the operation call to this interaction point
            FeatureValue featureValue = GetFeatureValue(onPort);
            List<Value> values = featureValue.values;
            int choice = ((ChoiceStrategy)locus?.factory?.GetStrategy("choice")!).Choose(featureValue.values.Count) - 1;
            CS_InteractionPoint interactionPoint = (CS_InteractionPoint)values.ElementAt(choice);
            return interactionPoint.Dispatch(operation);
        }

        public void SendIn(EventOccurrence eventOccurrence, Port onPort)
        {
            // Select a Reference value playing onPort,
            // and send the signal instance to this interaction point
            FeatureValue featureValue = GetFeatureValue(onPort);
            List<Value> values = featureValue.values;
            List<Reference> potentialTargets = new();
            for (int i = 0; i < values.Count; i++)
            {
                potentialTargets.Add((Reference)values.ElementAt(i));
            }
            CS_RequestPropagationStrategy strategy = (CS_RequestPropagationStrategy)locus?.factory?.GetStrategy("requestPropagation")!;
            List<Reference> targets = strategy.select(potentialTargets, new SendSignalActionActivation());
            for (int i = 0; i < targets.Count; i++)
            {
                Reference target = targets.ElementAt(i);
                target.Send(eventOccurrence);
            }
        }

        public override bool CheckAllParents(Classifier type, Classifier classifier)
        {
            // If the given classifier is not an Interface, behaves like in fUML.
            // Otherwise, check if the given type (or one of its direct or indirect
            // ancestors)
            // has an InterfaceRealization relationships with the given classifier.
            bool matched = false;
            if (classifier is not Interface)
            {
                matched = base.CheckAllParents(type, classifier);
            }
            else if (type is not Class_)
            {
                matched = false;
            }
            else if (RealizesInterface((Class_)type, (Interface)classifier))
            {
                matched = true;
            }
            else
            {
                List<Classifier> directParents = type.general;
                int i = 1;
                while (!matched & i <= directParents.Count)
                {
                    Classifier directParent = directParents.ElementAt(i - 1);
                    matched = CheckAllParents(directParent, classifier);
                    i++;
                }
            }
            return matched;
        }

        public bool RealizesInterface(Class_ type, Interface interface_)
        {
            // Checks if the given type has an InterfaceRealization relationship
            // with the given interface or a descendant of the interface.
            List<InterfaceRealization> realizations = type.interfaceRealization;
            bool realized = false;
            int i = 1;
            while (i <= realizations.Count && !realized)
            {
                InterfaceRealization realization = realizations.ElementAt(i - 1);
                Interface contract = realization.contract!;
                if (contract == interface_)
                {
                    realized = true;
                }
                else if (IsDescendant(contract, interface_))
                {
                    realized = true;
                }
                i++;
            }
            return realized;
        }

        public bool IsDescendant(Interface contract, Interface interface_)
        {
            // Checks if the given contract is a descendant of the given interface_
            bool matched = false;
            List<Classifier> descendants = contract.general;
            int i = 1;
            while (i <= descendants.Count && !matched)
            {
                if (descendants.ElementAt(i - 1) is Interface descendant)
                {
                    if (descendant == interface_)
                    {
                        matched = true;
                    }
                    else
                    {
                        matched = IsDescendant(descendant, interface_);
                    }
                }
                i++;
            }
            return matched;
        }
    } // CS_Object
}
