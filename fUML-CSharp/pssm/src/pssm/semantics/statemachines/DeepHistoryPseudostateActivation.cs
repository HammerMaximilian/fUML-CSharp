using fuml.semantics.commonbehavior;
using uml.statemachines;

namespace pssm.semantics.statemachines
{
    public class DeepHistoryPseudostateActivation : HistoryPseudostateActivation
    {
        protected bool CanRestore(StateActivation stateActivation)
        {
            // A state activation can only be restored if it is directly or indirectly
            // by the region containing the history state.
            bool canRestore = false;
            if (stateActivation != null)
            {
                RegionActivation historyRegion = (RegionActivation)parent!;
                if (historyRegion.GetVertexActivation((Vertex)stateActivation.node!) is not null)
                {
                    canRestore = true;
                }
            }
            return canRestore;
        }

        public override void Restore(RegionActivation regionActivation, TransitionActivation enteringTransition, EventOccurrence eventOccurrence)
        {
            // Restore the execution of a Region. 
            // If the Region restored is the region which contained
            // the deep history then two executions are possible:
            // 1. If the restored region has already been entered then its last known configuration 
            //    (i.e. active state) is restored.
            // 2. If the restored region has never been entered then if the deep history has an outgoing
            //    transition then this transition is fired to force the entrance of the target state.
            // If the region restored is not the region which contains the deep history then
            // two execution are possible:
            // 1. If the region already has an history then this history is restored
            // 2. If the region has no history then it is entered using the implicit rule.
            regionActivation.isCompleted = false;
            if (regionActivation == parent)
            {
                if (regionActivation.history is not null)
                {
                    Restore(regionActivation.history, enteringTransition, eventOccurrence);
                }
                else
                {
                    if (HasDefaultTransition())
                    {
                        outgoingTransitionActivations.ElementAt(0).Fire(eventOccurrence);
                    }
                }
            }
            else
            {
                if (CanRestore(regionActivation.history!))
                {
                    Restore(regionActivation.history!, enteringTransition, eventOccurrence);
                }
                else
                {
                    regionActivation.Enter(enteringTransition, eventOccurrence);
                }
            }
        }
    } // DeepHistoryPseudostateActivation
}
