using fuml.syntax.classification;
using fuml.syntax.commonbehavior;

namespace fuml.semantics.commonbehavior
{
    public class CallEventOccurrence : EventOccurrence
    {
        public CallEventExecution? execution = null;

        public Operation GetOperation()
        {
            // Get the operation being called by this call event occurrence.

            return execution?.GetOperation()!;
        }

        public override bool Match(Trigger trigger)
        {
            // Match a trigger if it references a call event whose operation is the
            // operation of this call event occurrence.

            bool matches = false;
            if (trigger.event_ is CallEvent callEvent)
            {
                matches = callEvent.operation == GetOperation();
            }
            return matches;
	    }

        public override List<ParameterValue> GetParameterValues(Event event_)
        {
            // Return the input parameter values from the call event execution for
            // this call event occurrence, which correspond to the values of the
            // operation input parameters for the call.

            return (execution is not null) ? execution.GetInputParameterValues() : new();
        }

        public void SetOutputParameterValues(List<ParameterValue> parameterValues)
        {
            // Set the output parameter values of the call event execution for
            // this call event occurrence, which correspond to the values of the
            // operation output parameters for the call.

            execution?.SetOutputParameterValues(parameterValues);
        }

        public void ReturnFromCall()
        {
            // Release the caller on return from the call.

            execution?.ReleaseCaller();
        }
    } // CallEventOccurrence
}
