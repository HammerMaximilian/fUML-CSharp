using fuml.semantics.commonbehavior;
using System;

namespace pssm.semantics.statemachines
{
    public class DeepHistoryPseudostateActivation : HistoryPseudostateActivation
    {
        protected bool CanRestore(StateActivation stateActivation)
        {
            throw new NotImplementedException();
        }

        public override void Restore(RegionActivation regionActivation, TransitionActivation enteringTransition, EventOccurrence eventOccurrence)
        {
        }
    } // DeepHistoryPseudostateActivation
}
