using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using fuml.syntax.classification;

namespace fuml.semantics.commonbehavior
{
    public class CallEventExecution : Execution
    {
        public bool callerSuspended = false;

        public bool IsCallerSuspended()
        {
            // Check if the caller is still suspended.
            // This is done in isolation from possible concurrent updates to this flag.

            _beginIsolation();
            bool isSuspended = callerSuspended;
            Debug.Println("[isCallerSuspended] operation = " + GetOperation()?.name +
                    ", callerSuspended = " + isSuspended);
            _endIsolation();

            return isSuspended;
        }

        public void SetCallerSuspended(bool callerSuspended)
        {
            // Set the caller suspended flag to the given value.
            // This is done in isolation from possible concurrent queries to this flag.

            _beginIsolation();
            this.callerSuspended = callerSuspended;
            Debug.Println("[setCallerSuspended] operation = " + GetOperation()?.name +
                    ", callerSuspended = " + callerSuspended);
            _endIsolation();
        }

        public void SuspendCaller()
        {
            // Suspend the caller until the caller is released.

            while (IsCallerSuspended())
            {
                Wait_();
            }

        }

        public void ReleaseCaller()
        {
            // Release the caller, if suspended.

            SetCallerSuspended(false);
        }

        public override void Execute()
        {
            // Make the call on the tarElementAt object (which is the context of this execution) 
            // and suspend the caller until the call is completed. 

            // Note: The callerSuspended flag needs to be set before the call is made,
            // in case the call is immediately handled and returned, even before the
            // suspend loop is started.
            SetCallerSuspended(true);

            MakeCall();
            SuspendCaller();
        }

        public void MakeCall()
        {
            // Make the call on the tarElementAt object (which is the context of this execution)
            // by sending a call event occurrence. (Note that the call will never be 
            // completed if the tarElementAt is not an active object, since then the object 
            // would then have no event pool in which the event occurrence could be placed.)

            Reference reference = new();
            reference.referent = context;
            CreateEventOccurrence().SendTo(reference);
        }

        public EventOccurrence CreateEventOccurrence()
        {
            // Create a call event occurrence associated with this call event execution.
            // (This operation may be overridden in subclasses to alter how the event
            // occurrence is create, e.g., if it is necessary to wrap it.)

            CallEventOccurrence eventOccurrence = new();
            eventOccurrence.execution = this;
            return eventOccurrence;
        }

        public Operation GetOperation()
        {
            // Return the operation being called by this call event execution.

            return ((CallEventBehavior)GetBehavior())?.operation!;
        }

        public List<ParameterValue> GetInputParameterValues()
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

        public void SetOutputParameterValues(List<ParameterValue> parameterValues)
        {
            // Set the output parameter values for this execution.

            List<Parameter> parameters = GetBehavior().ownedParameter;
            int i = 1;
            int j = 1;
            while (i <= parameters.Count)
            {
                Parameter parameter = parameters.ElementAt(i - 1);
                if (parameter.direction == ParameterDirectionKind.inout |
                        parameter.direction == ParameterDirectionKind.out_ |
                        parameter.direction == ParameterDirectionKind.return_ ) {
                    ParameterValue parameterValue = parameterValues.ElementAt(j - 1);
                    parameterValue.parameter = parameter;
                    SetParameterValue(parameterValue);
                    j++;
                }
                i++;
            }
        }

        public override Value New_()
        {
            // Create a new call event execution.

            return new CallEventExecution();
        }

        public override Value Copy()
        {
            // Create a new call event execution that is a copy of this execution, with the
            // caller initially not suspended.

            CallEventExecution copy = (CallEventExecution)base.Copy();
            copy.callerSuspended = false;
            return copy;
        }

        public void Wait_()
        {
            // Wait for an indeterminate amount of time to allow other concurrent
            // executions to proceed.
            // [There is no further formal specification for this operation.]

            Debug.Println(!ExecutionQueue.Step(), "[wait] Stuck!");
        }
    } // CallEventExecution
}
