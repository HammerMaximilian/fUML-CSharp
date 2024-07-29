using fuml.semantics.commonbehavior;

namespace pssm.semantics.statemachines
{
    public class LocalTransitionActivation : TransitionActivation
    {
        protected StateActivation GetContainingState()
        {
            throw new NotImplementedException();
        }
        
        public void ExitSource(EventOccurrence eventOccurrence)
        {
        }
        
        public void EnterTarget(EventOccurrence eventOccurrence)
        {
        }
    } // LocalTransitionActivation
}
