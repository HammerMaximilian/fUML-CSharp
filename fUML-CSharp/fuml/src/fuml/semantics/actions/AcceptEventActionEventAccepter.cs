using fuml.semantics.commonbehavior;

namespace fuml.semantics.actions
{
    public class AcceptEventActionEventAccepter : EventAccepter
    {
        public AcceptEventActionActivation? actionActivation = null;

        public override void Accept(
                EventOccurrence eventOccurrence)
        {
            // Accept an event occurrence and forward it to the action activation.

            actionActivation?.Accept(eventOccurrence);
        } // accept

        public override bool Match(
                EventOccurrence eventOccurrence)
        {
            // Return true if the given event occurrence matches a trigger of the accept event 
            // action of the action activation.

            return (actionActivation is not null) ? actionActivation.Match(eventOccurrence) : false;
        } // match
    } // AcceptEventActionEventAccepter
}
