using fuml.semantics.commonbehavior;
using System;

namespace pssm.semantics.statemachines
{
    public class ExitPointPseudostateActivation : ConnectionPointActivation
    {
        public override bool IsEnterable(TransitionActivation enteringTransition, bool staticCheck)
        {
            throw new NotImplementedException();
        }

        public override bool CanPropagateExecution(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
            throw new NotImplementedException();
        }

        public void enter(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
        }
    } // ExitPointPseudostateActivation
}
