using fuml.semantics.commonbehavior;

namespace pssm.semantics.statemachines
{
    public class InternalTransitionActivation : TransitionActivation
    {
        public override void ExitSource(EventOccurrence eventOccurrence)
        {
            // An internal transition does not cause exit of the source state
            return;
        }

        public override void EnterTarget(EventOccurrence eventOccurrence)
        {
            // An internal transition does not cause entry of the target state
            return;
        }
    } // InternalTransitionActivation
}
