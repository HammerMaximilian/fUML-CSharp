using fuml.semantics.commonbehavior;
using System;

namespace pssm.semantics.statemachines
{
    public class ChoicePseudostateActivation : ConditionalPseudostateActivation
    {
        public override bool CanPropagateExecution(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
            throw new NotImplementedException();
        }

        public override void Enter(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
        }
    } // ChoicePseudostateActivation
}
