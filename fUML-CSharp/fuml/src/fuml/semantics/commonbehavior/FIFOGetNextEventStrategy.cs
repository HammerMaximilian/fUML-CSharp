namespace fuml.semantics.commonbehavior
{
    public class FIFOGetNextEventStrategy : GetNextEventStrategy
    {
        public override EventOccurrence GetNextEvent(ObjectActivation objectActivation)
        {
            // Get the first event from the given event pool. The event is removed
            // from the pool.

            EventOccurrence eventOccurrence = objectActivation.eventPool.ElementAt(0);
            objectActivation.eventPool.RemoveAt(0);
            return eventOccurrence;
        } // getNextEvent
    } // FIFOGetNextEventStrategy
}
