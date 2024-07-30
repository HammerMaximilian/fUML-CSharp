using fuml.semantics.commonbehavior;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using pscs.semantics.commonbehavior;
using pscs.semantics.values;
using uml.classification;
using uml.commonbehavior;
using uml.values;

namespace pssm.semantics.values
{
    public class SM_OpaqueExpressionEvaluation : CS_OpaqueExpressionEvaluation
    {
        // The context is basically the execution context of the state-machine.
        // This provides the possibility for the behavior associated to the evaluated
        // opaque expression to access features available at the context.
        public Object_? context = null;

        // Input parameters for the execution of the behavior
        protected List<ParameterValue> parameterValues = new();

        public void Initialize(EventOccurrence eventOccurrence)
        {
            // The event occurrence that is about or is currently dispatched can
            // have data. In such situation if the behavior that is associated
            // to the OpaqueExpression input conforms with the proposed signal
            // event occurrence or the input parameters of the call event occurrence
            // then event occurrence data are passed to this behavior and used
            // to produce the guard verdict.
            parameterValues.Clear();
            OpaqueExpression expression = (OpaqueExpression)specification!;
            EventOccurrence currentEventOccurrence = eventOccurrence;
            if (currentEventOccurrence is CS_EventOccurrence cS_EventOccurrence)
            {
                currentEventOccurrence = cS_EventOccurrence.wrappedEventOccurrence!;
            }
            if (expression.behavior?.ownedParameter.Count > 0)
            {
                Behavior behavior = expression.behavior;
                if (currentEventOccurrence is SignalEventOccurrence signalEventOccurrence)
                {
                    List<Parameter> inputParameters = behavior.ownedParameter.Where(parameter => parameter.direction == ParameterDirectionKind.in_ || parameter.direction == ParameterDirectionKind.inout).ToList();
                    if (inputParameters.Count == 1)
                    {
                        Parameter parameter = inputParameters.ElementAt(0);
                        ParameterValue parameterValue = new()
                        {
                            parameter = parameter
                        };
                        List<Value> values = new()
                        {
                            signalEventOccurrence?.signalInstance!
                        };
                        parameterValue.values = values;
                        SetParameterValue(parameterValue);
                    }
                }
                else if (currentEventOccurrence is CallEventOccurrence callEventOccurrence)
                {
                    List<Parameter> behaviorInputParameters = behavior.ownedParameter.Where(parameter => parameter.direction == ParameterDirectionKind.in_ || parameter.direction == ParameterDirectionKind.inout).ToList();
                    List<ParameterValue> inputParameterValues = callEventOccurrence.execution!.GetInputParameterValues();
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
                            SetParameterValue(parameterValue);
                            i++;
                        }
                    }
                }
            }
        }

        public override List<Value> ExecuteExpressionBehavior()
        {
            // An opaque expression can have an associated behavior. If this is the case
            // this behavior is executed. Values produced by the execution of the behavior
            // are the result of the evaluation of the opaque expression
            List<Value> evaluation = new();
            OpaqueExpression expression = (OpaqueExpression)specification!;
            Behavior behavior = expression.behavior!;
            if (behavior is not null)
            {
                List<ParameterValue> results = locus?.executor?.Execute(behavior, context!, parameterValues)!;
                for (int i = 0; i < results.Count; i++)
                { // results.size should be 1
                    ParameterValue parameterValue = results.ElementAt(i);
                    List<Value> values = parameterValue.values;
                    for (int j = 0; j < values.Count; j++)
                    {
                        evaluation.Add(values.ElementAt(j));
                    }
                }
            }
            return evaluation;
        }

        public void SetParameterValue(ParameterValue parameterValue)
        {
            // If this parameter value does not exist then it is added
            // to the list parameter values
            if (GetParameterValue(parameterValue.parameter!) is null)
            {
                parameterValues.Add(parameterValue);
            }
        }
        public ParameterValue GetParameterValue(Parameter parameter)
        {
            // Return the parameter value corresponding to the given parameter.
            // Null is returned if no parameter value associated with the parameter
            // is found.
            int i = 0;
            ParameterValue? parameterValue = null;
            while (parameterValue is null && i < parameterValues.Count)
            {
                if (parameterValues.ElementAt(i).parameter == parameter)
                {
                    parameterValue = parameterValues.ElementAt(i);
                }
                i++;
            }
            return parameterValue!;
        }

    } // SM_OpaqueExpressionEvaluation
}
