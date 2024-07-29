using fuml.semantics.commonbehavior;
using fuml.semantics.structuredclassifiers;
using System;
using uml.commonbehavior;

namespace pssm.semantics.statemachines
{
    public class DeferredEventOccurrence : EventOccurrence
    {
        // The state activation that was constraint the event occurrence
        // to remain deferred.
        public StateActivation? constrainingStateActivation = null;

        // The event occurrence that is actually deferred
        public EventOccurrence? deferredEventOccurrence = null;

        public override bool Match(Trigger trigger)
        {
            throw new NotImplementedException();
        }

        public override List<ParameterValue> GetParameterValues(Event event_)
        {
            return GetParameterValues();
        }

        public List<ParameterValue> GetParameterValues()
        {
            throw new NotImplementedException();
        }

        public void Register(StateActivation stateActivation)
        {
        }

        public override void SendTo(Reference target)
        {
        }

        public override void DoSend()
        {
        }
    } // DeferredEventOccurrence
}
