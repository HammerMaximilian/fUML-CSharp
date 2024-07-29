using fuml.semantics.commonbehavior;
using System;

namespace pssm.semantics.statemachines
{
    public class JoinPseudostateActivation : PseudostateActivation
    {
        public override bool IsEnterable(TransitionActivation enteringTransition, bool staticCheck)
        {
            throw new NotImplementedException();
        }
        private bool _CanPropagateExecution(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
            throw new NotImplementedException();
        }
        
        public override bool CanPropagateExecution(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
            throw new NotImplementedException();
        }
        
        public override void Enter(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
            throw new NotImplementedException();
        }
    } // JoinPseudostateActivation
}
