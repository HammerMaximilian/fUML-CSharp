using fuml.semantics.commonbehavior;

namespace pssm.semantics.statemachines
{
    public class ShallowHistoryPseudostateActivation : HistoryPseudostateActivation
    {
        public override void Restore(RegionActivation regionActivation, TransitionActivation enteringTransition, EventOccurrence eventOccurrence)
        {
            // Restore a region activation. The restoration process works as follows:
            // If the region is the one which contains the history then if it exists
            // an history (i.e. the last known configuration) for the region then it
            // its restored.If there is no history, then if it exist an outgoing transition
            // exists for the shallow history then this transition is fired. Otherwise any
            // region that is asked to be restored, is entered using the default entry rule. 
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
                regionActivation.Enter(enteringTransition, eventOccurrence);
            }
        }
    } // ShallowHistoryPseudostateActivation
}
