using fuml.semantics.commonbehavior;

namespace pssm.semantics.statemachines
{
    public class DoActivityExecutionEventAccepter : EventAccepter
    {
        // The doActivity context object in which this accepter is registered
        public DoActivityContextObject? context = null;

        // The actual event accepter (i.e., the one registered by the doActivity
        // execution)
        public EventAccepter? encapsulatedAccepter = null;

        public override void Accept(EventOccurrence eventOccurrence)
        {
            // The event accepted through the state-machine event pool leads
            // to the triggering of a RTC step in the context of the doActivity.
            // As this needs to be realized the execution thread of the doActivity
            // the accepted event occurrence is registered at the event pool of the
            // DoActivityContextObjectActivation. This will trigger a new RTC step
            // that will effectively be realized in the DoActivityContextObject and
            // not in the State Machine context.
            context?.objectActivation!.eventPool.Add(eventOccurrence);
            context?.objectActivation!._send(new ArrivalSignal());
        }

        public override bool Match(EventOccurrence eventOccurrence)
        {
            // Simply delegates to the match operation of the encapsulated accepter.
            return encapsulatedAccepter!.Match(eventOccurrence);
        }
    } // DoActivityExecutionEventAccepter
}
