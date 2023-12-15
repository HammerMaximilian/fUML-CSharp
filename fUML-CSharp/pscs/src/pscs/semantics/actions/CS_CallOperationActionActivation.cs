using fuml.semantics.actions;
using fuml.semantics.commonbehavior;
using fuml.semantics.loci;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using pscs.semantics.structuredclassifiers;
using uml.actions;
using uml.classification;
using uml.commonstructure;
using uml.packages;
using uml.simpleclassifiers;
using uml.structuredclassifiers;

namespace pscs.semantics.actions
{
    public class CS_CallOperationActionActivation : CallOperationActionActivation
    {
        public override void DoAction()
        {
            CallOperationAction action = (CallOperationAction)node! ?? throw new InvalidCastException();
            // First determines if this is a call to a constructor and if a default
            // construction strategy needs to be applied.
            // This is a call to a constructor if the called operation has
            // stereotype <<Create>> applied.
            // The default construction strategy is used if no method is associated with the
            // <<Create>> operation.
            // Otherwise, behaves as in fUML.
            if (action.onPort == null && IsCreate(action.operation ?? throw new ArgumentNullException())
                    && action.operation.method.Count == 0)
            {
                Locus locus = GetExecutionLocus();
                CS_ConstructStrategy strategy = ((CS_ConstructStrategy)locus?.factory?.GetStrategy("constructStrategy")!) ?? throw new InvalidCastException();
                Value target = TakeTokens(action.target ?? throw new ArgumentNullException()).ElementAt(0);
                if (target is CS_Reference)
                {
                    strategy.Construct(action.operation, ((CS_Reference)target).compositeReferent ?? throw new ArgumentNullException());
                    List<Parameter> parameters = action.operation.ownedParameter;
                    List<OutputPin> resultPins = action.result;
                    List<Value> values = new()
                    {
                        target
                    };
                    int i = 1;
                    while (i <= parameters.Count)
                    {
                        Parameter parameter = parameters.ElementAt(i - 1);
                        if (parameter.direction == ParameterDirectionKind.return_)
                        {
                            OutputPin resultPin = resultPins.ElementAt(0);
                            PutTokens(resultPin, values);
                        }
                        i++;
                    }
                }
            }
            else
            {
                base.DoAction();
            }
        }

        public override Execution GetCallExecution()
        {
            // If onPort is not specified, behaves like in fUML
            // If onPort is specified, and if the value on the target input pin is a
            // reference, dispatch the operation
            // to it and return the resulting execution object.
            // As compared to fUML, instead of dispatching directly to target reference
            // by calling operation dispatch:
            // - If the invoked BehavioralFeature is on a provided Interface but not on any
            // required Interface,
            // then, when the InvocationAction is executed, the invocation is made into the
            // object given on
            // the target InputPin through the given Port
            // - If the invoked BehavioralFeature is on a required Interface but not on any
            // provided Interface,
            // then, if the InvocationAction is being executed inside the object given on
            // the target InputPin,
            // the invocation is forwarded out of the target object through the given Port.
            // - If the invoked BehavioralFeature is on both a provided and a required
            // Interface,
            // then, if the InvocationAction is being executed inside the object given on
            // the target InputPin,
            // the invocation is made out of the target object through the given Port.
            // Otherwise the invocation is made into the target object through the given
            // Port.
            CallOperationAction action = (CallOperationAction)node! ?? throw new InvalidCastException();
            Execution? execution = null;
            if (action.onPort is null)
            {
                execution = base.GetCallExecution();
            }
            else
            {
                Value target = TakeTokens(action.target ?? throw new ArgumentNullException()).ElementAt(0);
                if (target is CS_Reference)
                {
                    // Tries to determine if the operation call has to be
                    // dispatched to the environment or to the internals of
                    // target, through onPort
                    CS_Reference targetReference = (CS_Reference)target;
                    Object_ executionContext = group?.GetActivityExecution().context!;
                    bool operationIsOnProvidedInterface = IsOperationProvided(action.onPort,
                            action.operation ?? throw new ArgumentNullException());
                    bool operationIsOnRequiredInterface = IsOperationRequired(action.onPort,
                            action.operation);
                    // Operation on a provided interface only
                    if (operationIsOnProvidedInterface && !operationIsOnRequiredInterface)
                    {
                        execution = targetReference.DispatchIn(action.operation, action.onPort);
                    }
                    // Operation is on a required interface only
                    else if (!operationIsOnProvidedInterface && operationIsOnRequiredInterface)
                    {
                        // If not executing in the context of the target,
                        // Semantics are undefined.
                        // Otherwise, dispatch outside.
                        if (executionContext == targetReference.referent
                                || (targetReference.compositeReferent?.Contains(executionContext) ?? throw new ArgumentNullException()))
                        {
                            execution = targetReference.DispatchOut(action.operation, action.onPort);
                        }
                    }
                    // Operation is both on a provided and a required interface
                    else if (operationIsOnProvidedInterface && operationIsOnRequiredInterface)
                    {
                        if (executionContext == targetReference.referent
                                || (targetReference.compositeReferent?.Contains(executionContext) ?? throw new ArgumentNullException()))
                        {
                            execution = targetReference.DispatchOut(action.operation, action.onPort);
                        }
                        else
                        {
                            execution = targetReference.DispatchIn(action.operation, action.onPort);
                        }
                    }
                }
            }
            return execution!;
        }

        public bool IsOperationProvided(Port port, Operation operation)
        {
            bool isProvided = false;
            if (operation.owner is Interface)
            {
                // We have to look in provided interfaces of the port if
                // they define directly or indirectly the Operation
                int interfaceIndex = 1;
                // Iterates on provided interfaces of the port
                List<Interface> providedInterfaces = port.provided;
                while (interfaceIndex <= providedInterfaces.Count && !isProvided)
                {
                    Interface interface_ = providedInterfaces.ElementAt(interfaceIndex - 1);
                    // Iterates on members of the current Interface
                    int memberIndex = 1;
                    while (memberIndex <= interface_.Member().Count && !isProvided)
                    {
                        NamedElement cddOperation = interface_.Member().ElementAt(memberIndex - 1);
                        if (cddOperation is Operation)
                        {
                            isProvided = operation == cddOperation;
                        }
                        memberIndex++;
                    }
                    interfaceIndex++;
                }
            }
            return isProvided;
        }

        public bool IsOperationRequired(Port port, Operation operation)
        {
            bool isRequired = false;
            int interfaceIndex = 1;
            // Iterates on provided interfaces of the port
            List<Interface> requiredInterfaces = port.required;
            while (interfaceIndex <= requiredInterfaces.Count && !isRequired)
            {
                Interface interface_ = requiredInterfaces.ElementAt(interfaceIndex - 1);
                // Iterates on members of the current Interface
                int memberIndex = 1;
                while (memberIndex <= interface_.Member().Count && !isRequired)
                {
                    NamedElement cddOperation = interface_.Member().ElementAt(memberIndex - 1);
                    if (cddOperation is Operation)
                    {
                        isRequired = operation == cddOperation;
                    }
                    memberIndex++;
                }
                interfaceIndex++;
            }
            return isRequired;
        }

        public bool IsCreate(Operation o)
        {
            // FIXME This code is Eclipse specific
            // How to handle this in the spec?
            List<Stereotype> appliedStereotypes = o.appliedStereotype;
            int i = 0;
            bool isCreate = false;
            while (i < appliedStereotypes.Count && !isCreate)
            {
                Stereotype s = appliedStereotypes.ElementAt(i);
                if (s.name.Equals("Create"))
                {
                    isCreate = true;
                }
            }
            return isCreate;
        }
    } // CS_CallOperationActionActivation
}
