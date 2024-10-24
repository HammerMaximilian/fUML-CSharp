using fuml.semantics.commonbehavior;
using uml.statemachines;

namespace pssm.semantics.statemachines
{
    public class LocalTransitionActivation : TransitionActivation
    {
        protected StateActivation GetContainingState()
        {
            // The container of a local transition is determined in the following manner:
            // 1 - If the source vertex is an entry point then the containing state is the
            //     the state that has this entry point on its edge
            // 2 - Else in the case where the source contains the target then the containing
            //	   state is the source itself. Otherwise the source is the target
            StateActivation containingState;
            if (vertexSourceActivation is EntryPointPseudostateActivation)
			{
                containingState = (StateActivation)vertexSourceActivation.GetParentVertexActivation();
            }
			else
            {
                if (vertexSourceActivation?.GetVertexActivation((Vertex)vertexTargetActivation?.node!) != null)
                {
                    containingState = (StateActivation)vertexSourceActivation;
                }
                else
                {
                    containingState = (StateActivation)vertexTargetActivation!;
                }
            }
            return containingState;
        }
        
        public void ExitSource(EventOccurrence eventOccurrence)
        {
			// Exiting the source state of a local transition consists in the following set of actions:
			// 1 - Check if the source state can be exited (if it cannot then do nothing)
			// 2 - If the source can be exited and this latter is an entry point then the exit
			//     of the source is trivial (i.e., it only consists in exiting the entry point)
			//   - If the source can be exited and this latter is a composite state then the top
			//     vertex that is located in the top region which contains (maybe in deep nesting)
			//     the tar get is exited. At this point, if the source is not the containing state
			//     then it is also exited
			StateActivation containingState = GetContainingState();
			if (vertexSourceActivation!.IsExitable(this, false))
			{
				if (vertexSourceActivation is EntryPointPseudostateActivation){
					vertexSourceActivation.Exit(this, eventOccurrence, null!);
				}else
				{
					int i = 0;
					RegionActivation? containingRegion = null;
					while (containingRegion == null && i < containingState.regionActivation.Count)
					{
						RegionActivation regionActivation = containingState.regionActivation.ElementAt(i);
						if (regionActivation.GetVertexActivation((Vertex)vertexTargetActivation?.node!) != null)
						{
							containingRegion = regionActivation;
						}
						i++;
					}
					if (containingRegion != null)
					{
						i = 0;
						VertexActivation? vertexActivationToBeExited = null;
						Execution stateMachineExecution = GetStateMachineExecution();
						while (vertexActivationToBeExited == null && i < containingRegion.vertexActivations.Count)
						{
							VertexActivation currentActivation = containingRegion.vertexActivations.ElementAt(i);
							if (((StateMachineExecution)stateMachineExecution).configuration!.IsActive(currentActivation))
							{
								vertexActivationToBeExited = currentActivation;
							}
							i++;
						}
						if (vertexActivationToBeExited != null)
						{
							vertexActivationToBeExited.Exit(this, eventOccurrence, null!);
						}
					}
					if (vertexSourceActivation != containingState)
					{
						vertexSourceActivation.Exit(this, eventOccurrence, GetLeastCommonAncestor());
					}
				}
			}
		}
        
        public void EnterTarget(EventOccurrence eventOccurrence)
        {
			// Entering the target of local transition consists in checking if the target can be entered. If
			// this is the case then only when the target is not also the containing state it is entered 
			if (vertexTargetActivation!.IsEnterable(this, false))
			{
				if (vertexTargetActivation != GetContainingState())
				{
					vertexTargetActivation.Enter(this, eventOccurrence, GetLeastCommonAncestor());
				}
			}
		}
    } // LocalTransitionActivation
}
