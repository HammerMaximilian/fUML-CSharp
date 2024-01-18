using fuml.semantics.commonbehavior;

namespace fuml.extensions.commonbehavior
{
    public class LIFOGetNextEventStrategy : GetNextEventStrategy
    {
        public override EventOccurrence GetNextEvent(ObjectActivation objectActivation)
        {
            // Get the last event from the given event pool. The event is removed
            // from the pool.

            EventOccurrence eventOccurrence = objectActivation.eventPool.Last();
            objectActivation.eventPool.RemoveAt(objectActivation.eventPool.Count - 1);
            return eventOccurrence;
        } // getNextEvent
    } // LIFOGetNextEventStrategy
}
