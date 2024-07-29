using fuml.semantics.commonbehavior;
using System;

namespace pssm.semantics.statemachines
{
    public class EntryPointPseudostateActivation : ConnectionPointActivation
    {
        public override bool IsExitable(TransitionActivation exitingTransition, bool staticCheck)
        {
            throw new NotImplementedException();
        }
        
        public override bool CanPropagateExecution(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
            throw new NotImplementedException();
        }

        protected void _Enter(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
        }

        public override void Enter(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
        }
        
        public override void Exit(TransitionActivation exitingTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
        }
    } // EntryPointPseudostateActivation
}
