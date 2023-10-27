using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using fuml.syntax.classification;

namespace fuml.semantics.commonbehavior
{
    public class CallEventExecution : Execution
    {
        public bool callerSuspended = false;

        public bool isCallerSuspended()
        {
            // Check if the caller is still suspended.
            // This is done in isolation from possible concurrent updates to this flag.

            _beginIsolation();
            bool isSuspended = callerSuspended;
            Debug.println("[isCallerSuspended] operation = " + getOperation()?.name +
                    ", callerSuspended = " + isSuspended);
            _endIsolation();

            return isSuspended;
        }

        public void setCallerSuspended(bool callerSuspended)
        {
            // Set the caller suspended flag to the given value.
            // This is done in isolation from possible concurrent queries to this flag.

            _beginIsolation();
            this.callerSuspended = callerSuspended;
            Debug.println("[setCallerSuspended] operation = " + getOperation()?.name +
                    ", callerSuspended = " + callerSuspended);
            _endIsolation();
        }

        public void suspendCaller()
        {
            // Suspend the caller until the caller is released.

            while (isCallerSuspended())
            {
                wait_();
            }

        }

        public void releaseCaller()
        {
            // Release the caller, if suspended.

            setCallerSuspended(false);
        }

        public override void execute()
        {
            // Make the call on the tarElementAt object (which is the context of this execution) 
            // and suspend the caller until the call is completed. 

            // Note: The callerSuspended flag needs to be set before the call is made,
            // in case the call is immediately handled and returned, even before the
            // suspend loop is started.
            setCallerSuspended(true);

            makeCall();
            suspendCaller();
        }

        public void makeCall()
        {
            // Make the call on the tarElementAt object (which is the context of this execution)
            // by sending a call event occurrence. (Note that the call will never be 
            // completed if the tarElementAt is not an active object, since then the object 
            // would then have no event pool in which the event occurrence could be placed.)

            Reference reference = new();
            reference.referent = context;
            createEventOccurrence().sendTo(reference);
        }

        public EventOccurrence createEventOccurrence()
        {
            // Create a call event occurrence associated with this call event execution.
            // (This operation may be overridden in subclasses to alter how the event
            // occurrence is create, e.g., if it is necessary to wrap it.)

            CallEventOccurrence eventOccurrence = new();
            eventOccurrence.execution = this;
            return eventOccurrence;
        }

        public Operation getOperation()
        {
            // Return the operation being called by this call event execution.

            return ((CallEventBehavior)getBehavior())?.operation!;
        }

        public List<ParameterValue> getInputParameterValues()
        {
            // Return input parameter values for this execution

            List<ParameterValue> parameterValues = new();
            foreach (ParameterValue parameterValue in this.parameterValues)
            {
                if (parameterValue?.parameter?.direction == ParameterDirectionKind.in_

                    | parameterValue?.parameter?.direction == ParameterDirectionKind.inout)
                {
                    parameterValues.Add(parameterValue!);
                }
            }
            return parameterValues;
        }

        public void setOutputParameterValues(List<ParameterValue> parameterValues)
        {
            // Set the output parameter values for this execution.

            List<Parameter> parameters = getBehavior().ownedParameter;
            int i = 1;
            int j = 1;
            while (i <= parameters.Count())
            {
                Parameter parameter = parameters.ElementAt(i - 1);
                if (parameter.direction == ParameterDirectionKind.inout |
                        parameter.direction == ParameterDirectionKind.out_ |
                        parameter.direction == ParameterDirectionKind.return_ ) {
                    ParameterValue parameterValue = parameterValues.ElementAt(j - 1);
                    parameterValue.parameter = parameter;
                    setParameterValue(parameterValue);
                    j = j + 1;
                }
                i = i + 1;
            }
        }

        public override Value new_()
        {
            // Create a new call event execution.

            return new CallEventExecution();
        }

        public override Value copy()
        {
            // Create a new call event execution that is a copy of this execution, with the
            // caller initially not suspended.

            CallEventExecution copy = (CallEventExecution)base.copy();
            copy.callerSuspended = false;
            return copy;
        }

        public void wait_()
        {
            // Wait for an indeterminate amount of time to allow other concurrent
            // executions to proceed.
            // [There is no further formal specification for this operation.]

            Debug.println(!ExecutionQueue.step(), "[wait] Stuck!");
        }
    } // CallEventExecution
}
