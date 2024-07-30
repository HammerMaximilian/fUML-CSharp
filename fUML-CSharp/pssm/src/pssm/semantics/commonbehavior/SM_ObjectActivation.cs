using fuml.semantics.commonbehavior;
using pssm.semantics.statemachines;
using System;

namespace pssm.semantics.commonbehavior
{
    public class SM_ObjectActivation : ObjectActivation
    {
        // Events that have been dispatched but that are actually deferred are placed
        // in this particular event pool. When the state that constrained them to be
        // placed in this pool leaves the state-machine configuration then the deferred
        // events leave this pool and are placed in the regular event pool (to be
        // dispatched
        // again) that is handled by the object activation.
        public List<DeferredEventOccurrence> deferredEventPool = new();

        public CompletionEventOccurrence GetNextCompletionEvent()
        {
            // Return the next completion event available at the pool.
            int i = 0;
            CompletionEventOccurrence? completionEvent = null;
            while (completionEvent == null && i < eventPool.Count)
            {
                if (eventPool.ElementAt(i) is CompletionEventOccurrence completionEventOccurrence)
                {
                    completionEvent = completionEventOccurrence;
                    eventPool.RemoveAt(i);
                }
                i++;
            }
            return completionEvent!;
        }

        public int GetDeferredEventInsertionIndex()
        {
            // Deferred events are always registered after completion events if any.
            // Return the insertion point for deferred events.
            int index = 0;
            int i = 0;
            while (i < eventPool.Count)
            {
                if (eventPool.ElementAt(i) is CompletionEventOccurrence)
                {
                    index++;
                }
                i++;
            }
            return index;
        }

        public override EventOccurrence GetNextEvent()
        {
            // Completion events are always dispatched first. They are dispatched according
            // to their order of arrival in the pool. While completion event are available
            // at
            // the pool no other event is dispatched. If not there is no more completion
            // event
            // to dispatch then regular events are dispatched according to the currently
            // used
            // dispatching policy. Note that if the currently dispatched event occurrence
            // was
            // previously deferred the it is unwrapped and it encapsulated
            // 'deferredEventOccurrence'
            // is actually dispatched.
            EventOccurrence nextEvent = GetNextCompletionEvent();
            if (nextEvent is null)
            {
                nextEvent = base.GetNextEvent();
                if (nextEvent is DeferredEventOccurrence deferredEventOccurrence)
                {
                    nextEvent = deferredEventOccurrence.deferredEventOccurrence!;
                }
            }
            return nextEvent;
        }

        public void Register(CompletionEventOccurrence completionEventOccurrence)
        {
            // A completion event is registered in the completion event pool.
            // Completion events are always registered at the head of the event pool.
            // Its final position in the pool depends on the existence of other completion
            // events already registered in the pool.
            int insertionIndex = 0;
            bool insertionPointFound = false;
            while (!insertionPointFound && insertionIndex < eventPool.Count)
            {
                insertionPointFound = eventPool.ElementAt(insertionIndex) is not CompletionEventOccurrence;
                if (!insertionPointFound)
                {
                    insertionIndex++;
                }
            }
            eventPool.Insert(insertionIndex, completionEventOccurrence);
            _send(new ArrivalSignal());
        }

        public void Register(DeferredEventOccurrence deferredEventOccurrence)
        {
            // Add the deferred event occurrence in deferred event occurrence
            deferredEventPool.Add(deferredEventOccurrence);
        }

        public void ReleaseDeferredEvents(StateActivation deferringState)
        {
            // The release of event occurrence(s) deferred by the deferring state includes
            // the following step:
            // 1. Deferred events are removed from the deferred event pool
            // 2. Deferred events return to the regular event pool. They are inserted in the
            // pool
            // after any existing completion event occurrence but before any other events
            // that
            // arrived later.
            List<DeferredEventOccurrence> releasedEvents = new();
            for (int i = 0; i < deferredEventPool.Count; i++)
            {
                DeferredEventOccurrence eventOccurrence = deferredEventPool.ElementAt(i);
                if (eventOccurrence.constrainingStateActivation == deferringState)
                {
                    releasedEvents.Add(eventOccurrence);
                }
            }
            int insertionPoint = GetDeferredEventInsertionIndex();
            int j = 0;
            while (j < releasedEvents.Count)
            {
                eventPool.Insert(insertionPoint, releasedEvents.ElementAt(j));
                _send(new ArrivalSignal());
                insertionPoint++;
                j++;
            }
            releasedEvents.Clear();
        }

    } // SM_ObjectActivation
}
