using fuml.semantics.commonbehavior;
using uml.statemachines;

namespace pssm.semantics.statemachines
{
    public class ExternalTransitionActivation : TransitionActivation
    {
        public override void ExitSource(EventOccurrence eventOccurrence)
        {
            // The exiting phase of the source vertex activation is conditioned both by
            // the prerequisites that apply to leave the source and the prerequisites that
            // apply to enter the target. 
            // 1 - The source can be exited and its target can be entered
            //	 	-> The source is exited using the common ancestor
            // 2 - The source can be exited but is target is not ready to be entered
            //		-> The source is exited but the common ancestor is used. This implies
            //         the exiting phase is not propagated to parent state (if required)
            if (vertexSourceActivation!.IsExitable(this, false))
            {
                if (vertexTargetActivation!.IsEnterable(this, false))
                {
                    vertexSourceActivation.Exit(this, eventOccurrence, GetLeastCommonAncestor());
                }
                else
                {
                    vertexSourceActivation.Exit(this, eventOccurrence, null!);
                }
            }
        }

        public override void EnterTarget(EventOccurrence eventOccurrence)
        {
            // If the target vertex activation can be entered (i.e., its possible prerequisites
            // are satisfied) then the entering process begins. Note that this process may lead
            // to enter other states based on what is the common ancestor exiting between the
            // the source and the target. Besides the prerequisites imposed by the target vertex
            // activation there are no other constraints to enter the target state
            if (vertexTargetActivation!.IsEnterable(this, false))
            {
                vertexTargetActivation.Enter(this, eventOccurrence, GetLeastCommonAncestor());
            }
            else
            {
                if (vertexTargetActivation is StateActivation targetStateActivation)
                {
                    int i = 0;
                    RegionActivation? containingRegionActivation = null;
                    while (containingRegionActivation == null && i < targetStateActivation.regionActivation.Count)
                    {
                        RegionActivation currentActivation = targetStateActivation.regionActivation.ElementAt(i);
                        if (currentActivation.GetVertexActivation((Vertex)vertexSourceActivation?.node!) != null)
                        {
                            containingRegionActivation = currentActivation;
                        }
                        i++;
                    }
                    if (containingRegionActivation != null)
                    {
                        containingRegionActivation.isCompleted = true;
                        if (targetStateActivation.HasCompleted())
                        {
                            targetStateActivation.Complete();
                        }
                    }
                }
            }
        }
    } // ExternalTransitionActivation
}
