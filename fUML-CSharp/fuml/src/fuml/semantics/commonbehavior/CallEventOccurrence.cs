using fuml.syntax.classification;
using fuml.syntax.commonbehavior;

namespace fuml.semantics.commonbehavior
{
    public class CallEventOccurrence : EventOccurrence
    {
        public CallEventExecution? execution = null;

        public Operation getOperation()
        {
            // Get the operation being called by this call event occurrence.

            return execution?.getOperation()!;
        }

        public override bool match(Trigger trigger)
        {
            // Match a trigger if it references a call event whose operation is the
            // operation of this call event occurrence.

            bool matches = false;
            if (trigger.event_ is CallEvent callEvent)
            {
                matches = callEvent.operation == getOperation();
            }
            return matches;
	    }

        public override List<ParameterValue> getParameterValues(Event event_)
        {
            // Return the input parameter values from the call event execution for
            // this call event occurrence, which correspond to the values of the
            // operation input parameters for the call.

            return (execution is not null) ? execution.getInputParameterValues() : new();
        }

        public void setOutputParameterValues(List<ParameterValue> parameterValues)
        {
            // Set the output parameter values of the call event execution for
            // this call event occurrence, which correspond to the values of the
            // operation output parameters for the call.

            execution?.setOutputParameterValues(parameterValues);
        }

        public void returnFromCall()
        {
            // Release the caller on return from the call.

            execution?.releaseCaller();
        }
    } // CallEventOccurrence
}
