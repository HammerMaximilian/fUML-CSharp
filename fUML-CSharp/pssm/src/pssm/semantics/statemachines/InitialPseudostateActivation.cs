using fuml.semantics.commonbehavior;

namespace pssm.semantics.statemachines
{
    public class InitialPseudostateActivation : PseudostateActivation
    {
        public override void Enter(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
            // If there is an outgoing transition then this outgoing transition is fired.
            // If there is a guard or a trigger associated with this initial pseudo state then
            // they are not taken into account. If there is no outgoing transitions then the model
            // is considered as being ill-formed, similar interpretation occurs if there are more than
            // an single outgoing transition for the initial pseudo state.
            base.Enter(enteringTransition, eventOccurrence, null!);
            if (outgoingTransitionActivations.Count == 1)
            {
                outgoingTransitionActivations.ElementAt(0).Fire(eventOccurrence);
            }
        }

    } // InitialPseudostateActivation
}
