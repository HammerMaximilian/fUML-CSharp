using fuml.semantics.commonbehavior;
using pscs.semantics.structuredclassifiers;
using System;
using uml.commonbehavior;
using uml.structuredclassifiers;

namespace pscs.semantics.commonbehavior
{
    public class CS_EventOccurrence : EventOccurrence
    {
        public EventOccurrence? wrappedEventOccurrence = null;
        public CS_InteractionPoint? interactionPoint = null;
        public bool propagationInward;
        public Port? onPort = null;

        public override bool Match(Trigger trigger)
        { throw new NotImplementedException(); }

        public override void DoSend()
        {  throw new NotImplementedException(); }

        public void SendInTo(CS_Reference target, Port port)
        { throw new NotImplementedException(); }

        public void SendOutTo(CS_Reference target, Port port)
        { throw new NotImplementedException(); }

        public override List<ParameterValue> GetParameterValues(Event event_)
        { throw new NotImplementedException(); }
    } // CS_EventOccurrence
}
