using fuml.semantics.commonbehavior;
using System;

namespace pssm.semantics.statemachines
{
    public abstract class PseudostateActivation : VertexActivation
    {
        // Transitions that were fireable at the time which the pseudo-state was
        // evaluated.
        protected List<TransitionActivation> fireableTransitions = new();

        public void EvaluateAllGuards(EventOccurrence eventOccurrence)
        {
        }

        public override bool CanPropagateExecution(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
            throw new NotImplementedException();
        }
} // PseudostateActivation
}
