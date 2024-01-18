using fuml.semantics.actions;
using fuml.semantics.commonbehavior;
using pscs.semantics.commonbehavior;

namespace pscs.semantics.actions
{
    public class CS_AcceptEventActionActivation : AcceptEventActionActivation
    {
        public override void Accept(EventOccurrence eventOccurrence)
        {
            // If the accepted event occurrence is a CS_EventOccurrence then the wrapped
            // event occurrence is extracted. The acceptance process is the one define
            // by AcceptEventActionActivation defined in fUML.
            if (eventOccurrence is CS_EventOccurrence cS_EventOccurrence)
            {
                base.Accept(cS_EventOccurrence.wrappedEventOccurrence!);
            }
            else
            {
                base.Accept(eventOccurrence);
            }
        }
    } // CS_AcceptEventActionActivation
}
