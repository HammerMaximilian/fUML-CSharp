using fuml.semantics.commonbehavior;
using fuml.semantics.structuredclassifiers;
using pssm.semantics.commonbehavior;
using System;
using System.Linq;
using uml.commonbehavior;
using uml.commonstructure;
using uml.statemachines;

namespace pssm.semantics.statemachines
{
    public class StateActivation : VertexActivation
    {
        // The visitors for the regions owned by this state
        public List<RegionActivation> regionActivation = new();

        // The visitors for the connection points (EntryPoint / ExitPoint) owned by this state 
        public List<PseudostateActivation> connectionPointActivation = new();

        // Boolean flag to know if the entry behavior was completed
        public bool isEntryCompleted = false;

        // Boolean flag to know if the doActivity behavior was completed
        public bool isDoActivityCompleted = false;

        // Boolean flag to know if the exit behavior was completed
        public bool isExitCompleted;

        // The context object in which is executed the doActivity
        // owned by the visited state
        public DoActivityContextObject? doActivityContextObject = null;

        public bool HasCompleted()
        {
            // A state can only be considered as being completed under the following circumstances
            // 1 - If the state is simple, both its entry and doActivity have finished their execution
            // 2 - If the state is composite, the same rules than used for the simple state, but additionally
            //     all the region of the state must have completed by reaching their final states
            // When the operation returns true then the generation of a completion event is allowed
            // for that particular state
            bool stateCompleted = isEntryCompleted & isDoActivityCompleted;
            int i = 0;
            while (stateCompleted && i < regionActivation.Count)
            {
                stateCompleted = stateCompleted && regionActivation.ElementAt(i).isCompleted;
                i++;
            }
            return stateCompleted;
        }

        public void Complete()
        {
            // StateActivation completion consists in sending in the execution
            // context of the state-machine a completion event occurrence. This event is
            // placed in the pool before any other event
            CompletionEventOccurrence completionEventOccurrence = new();
            completionEventOccurrence.Register(this);
        }

        public PseudostateActivation GetConnectionPointActivation(Vertex vertex)
        {
            // Return the activation for the exit point or the entry point.
            PseudostateActivation? activation = null;
            int i = 0;
            while (i < connectionPointActivation.Count && activation == null)
            {
                if (connectionPointActivation.ElementAt(i).node == vertex)
                {
                    activation = connectionPointActivation.ElementAt(i);
                }
                i++;
            }
            return activation!;
        }

        public override bool IsVisitorFor(NamedElement node)
        {
            // A state activation is the interpreter of a state if the specified node is
            // the state or if the state redefines the specified node (which is of course)
            // a state.
            // 
            // Note: as soon as vertex will be redefineable elements, this constraints will be
            // moved to the vertex activation class.
            bool isVisitor = base.IsVisitorFor(node);
            if (!isVisitor)
            {
                State state = ((State)this.node!).redefinedState!;
                while (!isVisitor && state != null)
                {
                    if (state == node)
                    {
                        isVisitor = true;
                    }
                    else
                    {
                        state = state.redefinedState!;
                    }
                }
            }
            return isVisitor;
        }


        public override VertexActivation GetVertexActivation(Vertex vertex)
        {
            // Return the activation corresponding to the vertex. Search
            // is propagated through the owned region activation of the
            // state activation if this latter is composite. If no activation
            // is found null is returned.
            VertexActivation? vertexActivation = null;
            State state = (State)node!;
            if (state.IsComposite())
            {
                vertexActivation = GetConnectionPointActivation(vertex);
                if (vertexActivation == null)
                {
                    int i = 0;
                    while (i < regionActivation.Count && vertexActivation == null)
                    {
                        vertexActivation = regionActivation.ElementAt(i).GetVertexActivation(vertex);
                        i++;
                    }
                }
            }
            return vertexActivation!;
        }

        public override void Activate()
        {
            // Instantiate visitors for all vertices owned by this region 
            State state = (State)node!;
            if (state.IsComposite())
            {
                Object_ context = GetExecutionContext();
                foreach (Pseudostate connectionPoint in state.connectionPoint)
                {
                    PseudostateActivation activation = (PseudostateActivation)context.locus!.factory!.InstantiateVisitor(connectionPoint);
                    activation.parent = this;
                    activation.node = connectionPoint;
                    connectionPointActivation.Add(activation);
                }
                foreach (Region region in state.region)
                {
                    RegionActivation activation = (RegionActivation)context.locus!.factory!.InstantiateVisitor(region);
                    activation.parent = this;
                    activation.node = region;
                    activation.Activate();
                    regionActivation.Add(activation);
                }
            }
        }

        public override void ActivateTransitions()
        {
            // Instantiate visitor for transitions owned by this region
            State state = (State)node!;
            if (state.IsComposite())
            {
                foreach (RegionActivation activation in regionActivation)
                {
                    activation.ActivateTransitions();
                }
            }
        }

        public Behavior GetEntry()
        {
            // Return the entry behavior of the state or one inherited
            // from a redefined state. If no entry can be found null is
            // returned.
            State state = (State)node!;
            Behavior entry = state.entry!;
            while (entry == null && state.redefinedState != null)
            {
                state = state.redefinedState;
                entry = state.entry!;
            }
            return entry!;
        }

        public Behavior GetExit()
        {
            // Return the exit behavior of the state or one inherited
            // from a redefined state. If no exit can be found null is
            // returned.
            State state = (State)node!;
            Behavior exit = state.exit!;
            while (exit == null && state.redefinedState != null)
            {
                state = state.redefinedState;
                exit = state.exit!;
            }
            return exit!;
        }

        public Behavior GetDoActivity()
        {
            // Return the doActivity behavior of the state or one inherited
            // from a redefined state. If no doActivity can be found null is
            // returned.
            State state = (State)node!;
            Behavior doActivity = state.doActivity!;
            while (doActivity == null && state.redefinedState != null)
            {
                state = state.redefinedState;
                doActivity = state.doActivity!;
            }
            return doActivity!;
        }

        public void TryExecuteEntry(EventOccurrence eventOccurrence)
        {
            // If an entry behavior is specified for that state then it is executed.
            // If no entry behavior is specified but the state redefines another state
            // and this latter provides an entry behavior then this behavior is executed
            // instead. The rule applies recursively.
            if (!isEntryCompleted)
            {
                Behavior entry = GetEntry();
                if (entry != null)
                {
                    Execution execution = GetExecutionFor(entry, eventOccurrence);
                    if (execution != null)
                    {
                        execution.Execute();
                        isEntryCompleted = true;
                    }
                    // If state has completed then generate a completion event
                    if (HasCompleted())
                    {
                        Complete();
                    }
                }
            }
        }

        public void TryInvokeDoActivity(EventOccurrence eventOccurrence)
        {
            // If an doActivity behavior is specified for that state then it is executed.
            // If no doActivity is specified but the state redefines another state which
            // provides a doActivity then this latter is executed instead. The rule applies
            // recursively.
            if (!isDoActivityCompleted)
            {
                Behavior doActivity = GetDoActivity();
                if (doActivity != null)
                {
                    // Create, initialize and register to the locus the doActivityContextObject. 
                    doActivityContextObject = new DoActivityContextObject();
                    GetExecutionLocus().Add(doActivityContextObject);
                    doActivityContextObject.Initialize(GetExecutionContext());
                    doActivityContextObject.owner = this;
                    // Extract data from triggering event occurrence if possible. Reuse event occurrence
                    // embedded data extraction logic provided by EventTriggeredExecution.
                    List<ParameterValue> inputs = null!;
                    Execution doActivityExecution = GetExecutionFor(doActivity, eventOccurrence);
                    if (doActivityExecution is EventTriggeredExecution eventTriggeredExecution)
                    {
                        eventTriggeredExecution.Initialize();
                        inputs = new List<ParameterValue>(eventTriggeredExecution.wrappedExecution!.parameterValues);
                    }
                    // Start doActivity execution on its own thread of execution (i.e., this
                    // a different thread of execution than the one used for the state machine).
                    doActivityContextObject.StartBehavior(doActivity, inputs);
                }
            }
        }

        public void TryExecuteExit(EventOccurrence eventOccurrence)
        {
            // Execute the exit behavior if any. If no exit behavior is
            // specified but the state redefines another state which provides an
            // exit behavior then this latter is executed instead. The rule applies
            // recursively.
            Behavior exit = GetExit();
            if (exit != null)
            {
                Execution execution = GetExecutionFor(exit, eventOccurrence);
                execution?.Execute();
            }
            base.Exit(null!, eventOccurrence, null!);
        }

        public void EnterRegions(TransitionActivation enteringTransition, EventOccurrence eventOccurrence)
        {
            // Regions can be entered either implicitly or explicitly. 
            // A region is typically entered implicitly when its activation is triggered
            // by a transition terminating on the edge of its containing state.
            // A region is typically entered explicitly when one of its contained
            // state is targeted by a transition coming from the outside.
            // *** Regions are entered concurrently ***
            List<Vertex> targetedVertices = new();
            VertexActivation sourceActivation = enteringTransition.vertexSourceActivation!;
            if (sourceActivation is ForkPseudostateActivation)
            {
                Pseudostate fork = (Pseudostate)sourceActivation.node!;
                for (int i = 0; i < fork.outgoing.Count; i++)
                {
                    targetedVertices.Add(fork.outgoing.ElementAt(i).target!);
                }
            }
            else
            {
                VertexActivation targetActivation = enteringTransition.vertexTargetActivation!;
                if (targetActivation is EntryPointPseudostateActivation)
                {
                    Pseudostate entryPoint = (Pseudostate)targetActivation.node!;
                    for (int i = 0; i < entryPoint.outgoing.Count; i++)
                    {
                        targetedVertices.Add(entryPoint.outgoing.ElementAt(i).target!);
                    }
                }
                else
                {
                    if (targetActivation is not HistoryPseudostateActivation)
                    {
                        targetedVertices.Add((Vertex)targetActivation.node!);
                    }
                }
            }
            for (int i = 0; i < regionActivation.Count; i++)
            {
                RegionActivation regionActivation = this.regionActivation.ElementAt(i);
                int j = 0;
                bool found = false;
                while (j < targetedVertices.Count && !found)
                {
                    found = regionActivation.GetVertexActivation(targetedVertices.ElementAt(j)) != null;
                    j++;
                }
                if (!found)
                {
                    regionActivation.Enter(enteringTransition, eventOccurrence);
                }
            }
        }


        public override bool IsEnterable(TransitionActivation enteringTransition, bool staticCheck)
        {
            // A state can only be entered if it is not part of the state-machine configuration
            // (i.e., the state is not currently active)
            return !((StateMachineExecution)GetStateMachineExecution()).configuration!.IsActive(this);
        }

        public override bool CanPropagateExecution(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
            // When a simple state is encountered then the propagation analysis is terminated. If
            // the visited state is composite then the analysis  is propagated to the region(s). All
            // regions for which the possibility to propagate the execution is asserted must return true.
            bool propagate = true;
            if (!regionActivation.Contains(leastCommonAncestor))
            {
                propagate = base.CanPropagateExecution(enteringTransition, eventOccurrence, leastCommonAncestor);
            }
            if (propagate && regionActivation.Count > 0)
            {
                int i = 0;
                while (propagate && i < regionActivation.Count)
                {
                    propagate = regionActivation.ElementAt(i).CanPropagateExecution(eventOccurrence, enteringTransition);
                    i++;
                }
            }
            return propagate;
        }

        public override void Enter(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
            if (status == StateMetadata.IDLE)
            {
                // The state is entered via an explicit transition
                // The impact on the execution is that the parent state
                // of the current state is not active then it must be entered
                // the rule applies recursively
                base.Enter(enteringTransition, eventOccurrence, leastCommonAncestor);
                // Initialization
                isEntryCompleted = GetEntry() == null;
                isDoActivityCompleted = GetDoActivity() == null;
                isExitCompleted = GetExit() == null;
                // When the state is entered it is registered in the current
                // state-machine configuration
                StateMachineExecution smExecution = (StateMachineExecution)GetStateMachineExecution();
                smExecution.configuration!.Register(this);
                // If state has completed then generate a completion event*/
                if (HasCompleted())
                {
                    Complete();
                }
                else
                {
                    // Execute the entry behavior if any
                    TryExecuteEntry(eventOccurrence);
                    // Invoke the doActivity if any
                    TryInvokeDoActivity(eventOccurrence);
                    // If the state is not completed, then try to start its owned regions.
                    // A region is entered implicitly since the is not the 
                    EnterRegions(enteringTransition, eventOccurrence);
                }
            }
        }


        public override bool IsExitable(TransitionActivation exitingTransition, bool staticCheck)
        {
            // A state can only be be exited if it is part of the state-machine configuration
            // (i.e., the state is currently active)
            return !IsEnterable(exitingTransition, staticCheck);
        }

        public override void Exit(TransitionActivation exitingTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
            // If we exit a composite state, this provokes the termination of all of its regions 
            if (regionActivation.Any())
            {
                foreach (RegionActivation regionActivation in regionActivation)
                {
                    regionActivation.Exit(exitingTransition, eventOccurrence);
                }
            }
            // If there is a doActivity currently executing then it is aborted
            if (!isDoActivityCompleted)
            {
                doActivityContextObject!.Destroy();
                doActivityContextObject = null;
            }
            // If there is an exit behavior specified for the state it is executed
            if (!isExitCompleted)
            {
                TryExecuteExit(eventOccurrence);
            }
            // Re-initialize the bool flags
            isEntryCompleted = false;
            isDoActivityCompleted = false;
            isExitCompleted = false;
            // Change containing region history
            RegionActivation containgRegionActivation = GetOwningRegionActivation();
            containgRegionActivation.history = this;
            // When the state is exited then it is removed from the state-machine configuration
            StateMachineExecution smExecution = (StateMachineExecution)GetStateMachineExecution();
            smExecution.configuration!.Unregister(this);
            // The state is exited by a transition that targets a state which is located within 
            // another region. This means parent state must also be exited.  
            base.Exit(exitingTransition, eventOccurrence, leastCommonAncestor);
        }

        public List<TransitionActivation> GetFireableTransitions(EventOccurrence eventOccurrence)
        {
            // Return the set of transitions that can fire using the the given event occurrence
            List<TransitionActivation> fireableTransitions = new();
            foreach (TransitionActivation outgoingTransitionActivation in outgoingTransitionActivations)
            {
                if (outgoingTransitionActivation.CanFireOn(eventOccurrence))
                {
                    fireableTransitions.Add(outgoingTransitionActivation);
                }
            }
            return fireableTransitions;
        }

        public bool CanDefer(EventOccurrence eventOccurrence)
        {
            // Return true if current state activation is capable of deferring the given
            // event occurrence; false otherwise. Note that false is returned in case where
            // the deferring constraint is overridden by an outgoing transition
            // 
            // Note: for the moment the evaluation is done with the assumption that the
            // received event occurrence is a signal event occurrence. This will change
            // as soon as other kind of event (e.g. call event) will be supported in fUML.
            State state = (State)node!;
            bool deferred = eventOccurrence.MatchAny(state.deferrableTrigger);
            while (!deferred && state.redefinedState != null)
            {
                state = state.redefinedState;
                deferred = eventOccurrence.MatchAny(state.deferrableTrigger);
            }
            if (deferred)
            {
                int i = 0;
                TransitionActivation? overridingTransitionActivation = null;
                while (overridingTransitionActivation == null && i < outgoingTransitionActivations.Count)
                {
                    TransitionActivation currentTransitionActivation = outgoingTransitionActivations.ElementAt(i);
                    if (currentTransitionActivation.CanFireOn(eventOccurrence))
                    {
                        overridingTransitionActivation = currentTransitionActivation;
                    }
                    i++;
                }
                deferred = overridingTransitionActivation == null;
            }
            return deferred;
        }

        public void Defer(EventOccurrence eventOccurrence)
        {
            // Postpone the time at which this event occurrence will be available at the event pool.
            // The given event occurrence is placed in the deferred event pool and will be released
            // only when the current state activation will leave the state-machine configuration.
            DeferredEventOccurrence deferringEventOccurrence = new()
            {
                deferredEventOccurrence = eventOccurrence
            };
            deferringEventOccurrence.Register(this);
        }

        public void ReleaseDeferredEvents()
        {
            // If events have been deferred by that state then these latter return to the
            // regular event pool.
            Object_ context = GetExecutionContext();
            if (context.objectActivation is SM_ObjectActivation sM_ObjectActivation)
            {
                sM_ObjectActivation.ReleaseDeferredEvents(this);
            }
        }

        public override void Terminate()
        {
            // A state gets terminated when the state-machine that contains it gets itself terminated.
            // If the state has an ongoing doActivity behavior then this latter is aborted. In addition,
            // the state is active then it is removed from the active state configuration.
            if (IsActive())
            {
                if (regionActivation.Any())
                {
                    for (int i = 0; i < regionActivation.Count; i++)
                    {
                        regionActivation.ElementAt(i).Terminate();
                    }
                    regionActivation.Clear();
                }
                if (!isDoActivityCompleted)
                {
                    doActivityContextObject!.Destroy();
                }
                connectionPointActivation.Clear();
            }
        }

    } // StateActivation
}
