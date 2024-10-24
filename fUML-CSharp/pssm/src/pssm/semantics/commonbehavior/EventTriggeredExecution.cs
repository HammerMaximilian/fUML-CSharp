using fuml.semantics.actions;
using fuml.semantics.commonbehavior;
using fuml.semantics.values;
using pscs.semantics.commonbehavior;
using uml.classification;
using uml.commonbehavior;

namespace pssm.semantics.commonbehavior
{
    public class EventTriggeredExecution : Execution
    {
        // Original execution
        public Execution? wrappedExecution = null;

        // Event occurrence whose dispatching implied the
        // the execution of the behavior
        public EventOccurrence? triggeringEventOccurrence = null;

        public void Initialize()
        {
            // Transfer input parameter values of the call event execution
            // to the wrapped execution if possible. Two situations are considered
            // 1. If the triggering EventOccurrence is for a SignalEvent, then all
            // executed behavior will have either one parameter or no parameters.
            // If a behavior has a Parameter, the SignalInstance corresponding to
            // the SignalEventOccurrence is passed into the behavior Execution as
            // the value of its parameter.
            // 2. If the triggering EventOccurrence is for a CallEvent, then all executed
            // behaviors will have either no Parameters or signatures that conform or
            // input conform to the operation being called.
            // If a Behavior has Parameters, then the values of the input Parameters
            // of for the call are passed into the Behavior Execution as the values
            // of the corresponding input Parameters of the Behavior.
            _beginIsolation();
            if (wrappedExecution?.GetBehavior().ownedParameter.Count > 0)
            {
                Behavior behavior = wrappedExecution.GetBehavior();
                EventOccurrence currentEventOccurrence = triggeringEventOccurrence!;
                if (triggeringEventOccurrence is CS_EventOccurrence cS_EventOccurrence) {
                    currentEventOccurrence = cS_EventOccurrence.wrappedEventOccurrence!;
                }
                if (currentEventOccurrence is SignalEventOccurrence signalEventOccurrence) {
                    List<Parameter> inputParameters = behavior.ownedParameter.Where(
                        parameter =>
                            parameter.direction == ParameterDirectionKind.in_ ||
                            parameter.direction == ParameterDirectionKind.inout).ToList();
                    if (inputParameters.Count == 1)
                    {
                        Parameter parameter = inputParameters.ElementAt(0);
                        ParameterValue parameterValue = new()
                        {
                            parameter = parameter
                        };
                        List<Value> values = new()
                        {
                            signalEventOccurrence.signalInstance!
                        };
                        parameterValue.values = values;
                        wrappedExecution.SetParameterValue(parameterValue);
                    }
                } else if (currentEventOccurrence is CallEventOccurrence callEventOccurrence) {
                    List<Parameter> behaviorInputParameters = behavior.ownedParameter.Where(
                        parameter =>
                            parameter.direction == ParameterDirectionKind.in_ ||
                            parameter.direction == ParameterDirectionKind.inout).ToList();
                    List<ParameterValue> inputParameterValues = callEventOccurrence.execution?.GetInputParameterValues()!;
                    if (behaviorInputParameters.Count == inputParameterValues.Count)
                    {
                        int i = 1;
                        while (i <= behaviorInputParameters.Count)
                        {
                            ParameterValue parameterValue = new()
                            {
                                parameter = behaviorInputParameters.ElementAt(i - 1),
                                values = inputParameterValues.ElementAt(i - 1).values
                            };
                            wrappedExecution.SetParameterValue(parameterValue);
                            i++;
                        }
                    }
                }
            }
            _endIsolation();
        }

        public override void Execute()
        {
            // First the behavior handled by the wrapped execution is parameterized
            // with parameter input values provided by the triggering event occurrence.
            // The behavior handled by the wrapped Execution is executed and finally outputs
            // are passed out to the triggering event occurrence (only occurs in the case of
            // a call event occurrence).
            if (wrappedExecution != null && triggeringEventOccurrence != null)
            {
                Initialize();
                wrappedExecution.Execute();
                Finalize_();
            }
        }

        public void Finalize_()
        {
            // Transfer output parameter values (produced by the wrapped execution) back to
            // the execution associated t the call event.
            // If an effect, entry or exit Behavior is not just input-conforming, then the
            // values of its output Parameters are passed out of its Behavior Execution on
            // its completion as potential values for the output Parameters of the called
            // Operation.
            //
            // Notes:
            // If the CallEvent is for a synchronous call, then the call ends at the end
            // of the triggered run-to-completion (RTC) step. If the called Operation has
            // output Parameters, then the values returned for those parameters are those
            // produced by the last effect, entry or exit Behavior to complete its execution
            // during the RTC step. Since some or all of those Behaviors may execute
            // concurrently,
            // which one completes last may be only partially determined by the specified
            // semantics.
            // The values returned may legally be those produced any Behavior that produces
            // potential
            // output values and is the last to complete in any execution trace for the RTC
            // step consistent with the specified StateMachine semantics.
            EventOccurrence currentEventOccurrence = triggeringEventOccurrence!;
            if (triggeringEventOccurrence is CS_EventOccurrence cS_EventOccurrence) {
                currentEventOccurrence = cS_EventOccurrence.wrappedEventOccurrence!;
            }
            if (currentEventOccurrence is CallEventOccurrence callEventOccurrence) {
                Behavior behavior = wrappedExecution?.GetBehavior()!;
                List<ParameterValue> outputParameterValues = wrappedExecution?.GetOutputParameterValues()!;
                List<Parameter> outputParameters = behavior.ownedParameter.Where(
                    parameter => 
                        parameter.direction == ParameterDirectionKind.out_ ||
                        parameter.direction == ParameterDirectionKind.inout ||
                        parameter.direction == ParameterDirectionKind.return_).ToList();
                if (outputParameters.Count == outputParameterValues.Count)
                {
                    int i = 1;
                    List<Parameter> behaviorOutputParameters = callEventOccurrence.execution?.GetBehavior().ownedParameter.Where(
                    parameter =>
                        parameter.direction == ParameterDirectionKind.out_ ||
                        parameter.direction == ParameterDirectionKind.inout ||
                        parameter.direction == ParameterDirectionKind.return_).ToList()!;
                    while (i <= behaviorOutputParameters.Count)
                    {
                        ParameterValue parameterValue = new()
                        {
                            parameter = behaviorOutputParameters.ElementAt(i - 1),
                            values = outputParameterValues.ElementAt(i - 1).values
                        };
                        callEventOccurrence.execution?.SetParameterValue(parameterValue);
                        i++;
                    }
                }
            }
            _endIsolation();
        }


        protected override Value New_()
        {
            return new EventTriggeredExecution();
        }


        public override Value Copy()
        {
            EventTriggeredExecution copy = (EventTriggeredExecution)base.Copy();
            copy.triggeringEventOccurrence = triggeringEventOccurrence;
            copy.wrappedExecution = (Execution)wrappedExecution?.Copy()!;
            return copy;
        }
    } // EventTriggeredExecution
}
