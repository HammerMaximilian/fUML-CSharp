using fuml.semantics.commonbehavior;
using System;

namespace pssm.semantics.statemachines
{
    public abstract class HistoryPseudostateActivation : PseudostateActivation
    {
        public bool HasDefaultTransition()
        {
            throw new NotImplementedException();
        }

        public override void Enter(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
            throw new NotImplementedException();
        }

        public void Restore(StateActivation stateActivation, TransitionActivation enteringTransition, EventOccurrence eventOccurrence)
        {
        }

        public abstract void Restore(RegionActivation regionActivation, TransitionActivation enteringTransition, EventOccurrence eventOccurrence);
    } // HistoryPseudostateActivation
}
