using fuml.semantics.commonbehavior;
using System;
using uml.statemachines;

namespace pssm.semantics.statemachines
{
    public abstract class HistoryPseudostateActivation : PseudostateActivation
    {
        public bool HasDefaultTransition()
        {
            // Determine if the history pseudo-state activation has default transition.
            // Returns true if it has one, false otherwise
            bool defaultTransition = false;
            if (outgoingTransitionActivations.Count == 1)
            {
                defaultTransition = true;
            }
            return defaultTransition;
        }

        public override void Enter(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
			// When entering an history pseudo-state two distinct situations can occur:
			// 1. The region has no history and the history pseudo-state has no default
			//    transition to force entry of a particular vertex. In such situation
			//    there is no other possibility than to perform a default entry for the
			//    state hierarchy in which the history pseudo-state is nested. Note that
			//    if the pseudo-state is placed directly in a region owned by the state
			//    machine then the region in which it is placed performs a default entry.
			// 2. The region already has an history or at least has a default transition
			//    to force entry to in a particular vertex. In such situation, the state
			//    hierarchy of the parent state of the history pseudo-state is entered.
			//    Next the containing state is restored (the result of the restoration
			//    process is dependent of the type of the history). Note that if the history
			//    is placed in a region directly owned by the state-machine then the
			//    restoration process starts from the region.
			VertexActivation parentVertexActivation = GetParentVertexActivation();
			if (parentVertexActivation != null)
			{
				RegionActivation owningRegionActivation = GetOwningRegionActivation();
				if (owningRegionActivation.history == null && !HasDefaultTransition())
				{
					base.Enter(enteringTransition, eventOccurrence, leastCommonAncestor);
				}
				else
				{
					parentVertexActivation = (StateActivation)parentVertexActivation;
					parentVertexActivation.status = StateMetadata.ACTIVE;
					base.Enter(enteringTransition, eventOccurrence, leastCommonAncestor);
					Restore((StateActivation)parentVertexActivation, enteringTransition, eventOccurrence);
				}
			}
			else
			{
				RegionActivation owningRegionActivation = GetOwningRegionActivation();
				if (owningRegionActivation.history == null && !HasDefaultTransition())
				{
					owningRegionActivation.Enter(enteringTransition, eventOccurrence);
				}
				else
				{
					Restore(owningRegionActivation, enteringTransition, eventOccurrence);
				}
			}
			if (IsActive())
			{
				Exit(null!, null!, null!);
			}
		}

        public void Restore(StateActivation stateActivation, TransitionActivation enteringTransition, EventOccurrence eventOccurrence)
        {
			// Restore the state. Restoring a state consists in :
			// 1. Registering the state to the state-machine configuration
			// 2. Complete the state if needs to be completed
			// 3. If the state cannot be completed then execute its entry and its doActivity. Finally,
			//    if it has regions then these regions are restored (in parallel).
			State state = (State)stateActivation?.node!;
			stateActivation!.status = StateMetadata.ACTIVE;
			StateMachineExecution smExecution = (StateMachineExecution)GetStateMachineExecution();
			smExecution?.configuration!.Register(stateActivation);
			stateActivation.isEntryCompleted = state!.entry == null;
			stateActivation.isDoActivityCompleted = state.doActivity == null;
			stateActivation.isExitCompleted = state.exit == null;
			if (stateActivation.HasCompleted())
			{
				stateActivation.Complete();
			}
			else
			{
				stateActivation.TryExecuteEntry(eventOccurrence);
				stateActivation.TryInvokeDoActivity(eventOccurrence);
				foreach (RegionActivation regionActivation in stateActivation.regionActivation)
				{
					Restore(regionActivation, enteringTransition, eventOccurrence);
				}
			}
		}

        public abstract void Restore(RegionActivation regionActivation, TransitionActivation enteringTransition, EventOccurrence eventOccurrence);
    } // HistoryPseudostateActivation
}
