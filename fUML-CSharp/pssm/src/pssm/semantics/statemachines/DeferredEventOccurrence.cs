using fuml.semantics.commonbehavior;
using fuml.semantics.structuredclassifiers;
using pssm.semantics.commonbehavior;
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
            // Delegate to the match operation of the encapsulated event
            // occurrence which is the one being deferred.
            bool match = false;
            if (deferredEventOccurrence != null)
            {
                match = deferredEventOccurrence.Match(trigger);
            }
            return match;
        }

        public override List<ParameterValue> GetParameterValues(Event event_)
        {
            return GetParameterValues();
        }

        public List<ParameterValue> GetParameterValues()
        {
            // Delegate to the getParameterValues operation of the encapsulated event
            // occurrence which is the one being deferred.
            List<ParameterValue> parameterValues = new();
            if (deferredEventOccurrence is not null)
            {
                parameterValues = deferredEventOccurrence.GetParameterValues(null!);
            }
            return parameterValues;
        }

        public void Register(StateActivation stateActivation)
        {
            // Register this deferred event occurrence in the deffered
            // event pool of the context object.
            constrainingStateActivation = stateActivation;
            SM_ObjectActivation objectActivation = (SM_ObjectActivation)stateActivation.GetExecutionContext()?.objectActivation!;
            objectActivation.Register(this);
        }

        public override void SendTo(Reference target)
        {
            // Do nothing - the deferred event is not sent to a target.
            // It is registered during the RTC step of the active object that
            // entered the state from which it was generated.
        }

        public override void DoSend()
        {
            // Do nothing - the deferred event is not sent to a target.
            // It is registered during the RTC step of the active object that
            // entered the state from which it was generated.
        }
    } // DeferredEventOccurrence
}
