using fuml.semantics.commonbehavior;
using fuml.semantics.structuredclassifiers;
using System;
using uml.commonbehavior;

namespace pssm.semantics.statemachines
{
    public class CompletionEventOccurrence : EventOccurrence
    {
        /*
         * A completion event is a specific kind of event occurrence.
         * 
         * It is placed in the event pool of an active object under the following
         * circumstances:
         * 
         * 1 - The state is simple. As soon as its entry behavior as well as its
         * doActivity behavior finished a completion event is generated.
         * 
         * 2 - The state is composite. All internal activities (e.g., entry and
         * doActivity Behaviors) have completed execution, and all its orthogonal
         * Regions have reached a FinalState
         * 
         */

        // A reference to the state from which the completion event was generated
        public StateActivation? stateActivation = null;

        public override bool MatchAny(List<Trigger> triggers)
        {
            throw new NotImplementedException();
        }

        public override bool Match(Trigger trigger)
        {
            throw new NotImplementedException();
        }

        public List<ParameterValue> GetParameterValues()
        {
            throw new NotImplementedException();
        }

        public override List<ParameterValue> GetParameterValues(Event event_)
        {
            return GetParameterValues();
        }

        public override void SendTo(Reference target)
        { 
        }

        public override void DoSend()
        {
        }

        public void Register(StateActivation stateActivation)
        {
        }
    } // CompletionEventOccurrence
}
