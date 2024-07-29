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
        }

        public override bool Match(EventOccurrence eventOccurrence)
        {
            // Simply delegates to the match operation of the encapsulated accepter.
            return encapsulatedAccepter!.Match(eventOccurrence);
        }
    } // DoActivityExecutionEventAccepter
}
