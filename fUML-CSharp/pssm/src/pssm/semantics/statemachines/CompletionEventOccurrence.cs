using fuml.semantics.commonbehavior;
using fuml.semantics.structuredclassifiers;
using pssm.semantics.commonbehavior;
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
            // A completion event can only trigger transition with no
            // trigger. Hence if the list of trigger that is passed is
            // empty then the completion event occurrence matches. It does match
            // otherwise.
            bool match = false;
            if (triggers.Count == 0)
            {
                match = true;
            }
            return match;
        }

        public override bool Match(Trigger trigger)
        {
            // A completion event can only trigger transition with no
            // trigger. Hence it cannot match a trigger so false is returned
            // regardless the trigger provided as parameter.
            return false;
        }

        public List<ParameterValue> GetParameterValues()
        {
            // A completion will never have associated values. Hence a
            // empty list is returned.
            return new List<ParameterValue>();
        }

        public override List<ParameterValue> GetParameterValues(Event event_)
        {
            return GetParameterValues();
        }

        public override void SendTo(Reference target)
        {
            // Do nothing - the completion event is not sent to a target.
            // It is registered during the RTC step of the active object that
            // entered the state from which it was generated.
        }

        public override void DoSend()
        {
            // Do nothing - the completion event is not sent to a target.
            // It is registered during the RTC step of the active object that
            // entered the state from which it was generated.
        }

        public void Register(StateActivation stateActivation)
        {
            // Register this completion event occurrence in the event
            // pool of the context object.
            this.stateActivation = stateActivation;
            SM_ObjectActivation objectActivation = (SM_ObjectActivation)stateActivation
                    .GetExecutionContext()?.objectActivation!;
            objectActivation.Register(this);
        }
    } // CompletionEventOccurrence
}
