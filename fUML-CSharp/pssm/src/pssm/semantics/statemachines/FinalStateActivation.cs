using fuml.semantics.commonbehavior;

namespace pssm.semantics.statemachines
{
    public class FinalStateActivation : StateActivation
    {
        public override void Enter(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
			// The final state completes the region in which it is located*/
			RegionActivation regionActivation = GetOwningRegionActivation();
			regionActivation.isCompleted = true;
			regionActivation.history = null;
			// If this region is the last of this state to complete through its final
			// state then it leads to the generation of a completion event
			if (regionActivation.parent is StateActivation stateActivation)
			{
				if (stateActivation.HasCompleted())
				{
					stateActivation.Complete();
				}
			}
		}
    } // FinalStateActivation
}
