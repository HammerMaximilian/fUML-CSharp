using fuml.semantics.activities;
using fuml.semantics.commonbehavior;
using fuml.syntax.actions;
using fuml.syntax.activities;
using fuml.syntax.classification;

namespace fuml.semantics.actions
{
    public abstract class CallActionActivation : InvocationActionActivation
    {
        public List<Execution> callExecutions = new();
        public bool isStreaming;

        public List<OutputPin> nonStreamingOutputPins = new();
        public List<Parameter> nonStreamingOutputParameters = new();

        public override void Initialize(ActivityNode node, ActivityNodeActivationGroup group)
        {
            // Initialize this call action activation to be not streaming.

            base.Initialize(node, group);
            isStreaming = false;
        }

        public override bool IsReady()
        {
            // Check that this call action activation is ready to fire, accounting for
            // the possibility of pins corresponding to streaming parameters. In order
            // to be ready, only argument pin activations for non-streaming parameters must
            // be ready, except if all the argument pin activations are for streaming
            // parameters with multiplicity lower bound greater than 0, in which case
            // at least one of those pins must have an offered value. 

            bool ready = IsControlReady();

            CallAction callAction = (CallAction)node!;
            List<InputPin> argumentPins = callAction.argument;

            if (ready & argumentPins.Count > 0)
            {
                List<Parameter> parameters = GetParameters();
                List<Parameter> inputParameters = new();
                foreach (Parameter parameter in parameters)
                {
                    if (parameter.direction == ParameterDirectionKind.in_
                        | parameter.direction == ParameterDirectionKind.inout)
                    {
                        inputParameters.Add(parameter);
                    }
                }

                bool streamingReady = false;
                int j = 1;
                while (ready & j <= argumentPins.Count)
                {
                    InputPin argumentPin = argumentPins.ElementAt(j - 1);
                    InputPinActivation pinActivation =
                            (InputPinActivation)GetPinActivation(argumentPin);
                    if (j > inputParameters.Count)
                    {
                        ready = pinActivation.IsReady();
                    }
                    bool isStream = false;
                    if (j <= inputParameters.Count)
                    {
                        isStream = inputParameters.ElementAt(j - 1).isStream;
                    }
                    if (!isStream)
                    {
                        // If there are any non-streaming argument pins, then streaming
                        // is considered to be ready.
                        streamingReady = true;

                        // All non-streaming argument pins must be ready.
                        ready = pinActivation.IsReady();
                    }
                    else if (pinActivation.IsReadyForStreaming())
                    {
                        // If there are only streaming argument pins, then streaming
                        // is ready if any of them are ready for streaming.
                        streamingReady = true;
                    }
                    j++;
                }

                ready &= streamingReady;
            }

            return ready;
        }

        public override void DoAction()
        {
            // Get the call execution object, set its input parameters from the
            // argument pins and execute it.
            // If there are no streaming input parameters, then, once execution completes, 
            // if the execution raised an exception, then propagate the exception.
            // Otherwise, copy the values of the output parameters of the call execution to 
            // the result pins of the call action execution. In either case, destroy the 
            // execution.
            // If there are streaming input parameters, then leave the call execution object
            // in place to process any additional inputs that may be posted to the streaming
            // input parameters.

            Execution callExecution = GetCallExecution();

            if (callExecution is not null)
            {
                callExecutions.Add(callExecution);

                CallAction callAction = (CallAction)node!;
                List<InputPin> argumentPins = callAction.argument;
                List<OutputPin> resultPins = callAction.result;

                // Must get parameters from call execution behavior, to ensure the correct
                // parameters are used for an operation method.
                List<Parameter> parameters = callExecution.GetBehavior().ownedParameter;

                int pinNumber = 1;
                int outputPinNumber = 1;
                int i = 1;
                InputPinActivation? streamingPinActivation = null;
                nonStreamingOutputPins.Clear();
                nonStreamingOutputParameters.Clear();
                while (i <= parameters.Count)
                {
                    Parameter parameter = parameters.ElementAt(i - 1);
                    if (parameter.direction == ParameterDirectionKind.in_

                        | parameter.direction == ParameterDirectionKind.inout) {
                        InputPin argumentPin = argumentPins.ElementAt(pinNumber - 1);
                        ParameterValue parameterValue;
                        if (parameter.isStream)
                        {
                            parameterValue = new StreamingParameterValue
                            {
                                values = GetTokens(argumentPin)
                            };
                            streamingPinActivation =
                                (InputPinActivation)GetPinActivation(argumentPin);
                            streamingPinActivation.streamingParameterValue =
                                (StreamingParameterValue)parameterValue;
                        }
                        else
                        {
                            parameterValue = new ParameterValue
                            {
                                values = TakeTokens(argumentPin)
                            };
                        }
                        parameterValue.parameter = parameter;
                        callExecution.SetParameterValue(parameterValue);
                        pinNumber++;
                    }
                    if (parameter.direction == ParameterDirectionKind.out_

                        | parameter.direction == ParameterDirectionKind.inout
                        | parameter.direction == ParameterDirectionKind.return_) {
                        OutputPin resultPin = resultPins.ElementAt(outputPinNumber - 1);
                        if (!parameter.isStream)
                        {
                            nonStreamingOutputPins.Add(resultPin);
                            nonStreamingOutputParameters.Add(parameter);
                        }
                        else
                        {
                            ParameterValue parameterValue = new StreamingParameterValue
                            {
                                parameter = parameter
                            };
                            PinStreamingParameterListener listener = new();
                            listener.nodeActivation = GetPinActivation(resultPin);
                            ((StreamingParameterValue)parameterValue).Register(listener);

                            // Note: Add a new parameter value, so that there will
                            // be two separate input and output parameter values for a
                            // streaming inout parameter.
                            callExecution.parameterValues.Add(parameterValue);
                        }
                        outputPinNumber++;
                    }
                    i++;
                }

                callExecution.Execute();

                if (streamingPinActivation is null)
                {
                    isStreaming = false;
                }
                else
                {
                    isStreaming = !streamingPinActivation.StreamingIsTerminated();
                }

                if (!isStreaming)
                {
                    CompleteCall(callExecution);
                }
            }
        } // doAction

        public override List<Token> CompleteAction()
        {
            // If this call action activation is not streaming, then complete the action
            // normally. Otherwise, complete the action without checking for firing again
            // (but keep the call execution running).

            List<Token> incomingTokens;
            if (isStreaming)
            {
                incomingTokens = new List<Token>();
            }
            else
            {
                incomingTokens = base.CompleteAction();
            }
            return incomingTokens;
        }

        public void CompleteCall(Execution callExecution)
        {
            // If the call execution raised an exception, then propagate it. Otherwise,
            // copy the values of the non-streaming output parameters of the call execution 
            // to the corresponding result pin activations of the call action activation. 
            // In either case, destroy the execution.

            if (callExecution.exception is not null)
            {
                PropagateException(callExecution.exception);
            }
            else
            {
                List<OutputPin> resultPins = nonStreamingOutputPins;
                List<Parameter> parameters = nonStreamingOutputParameters;

                List<ParameterValue> outputParameterValues = callExecution.GetOutputParameterValues();

                for (int i = 0; i < resultPins.Count; i++)
                {
                    OutputPin resultPin = resultPins.ElementAt(i);
                    Parameter parameter = parameters.ElementAt(i);
                    foreach (ParameterValue outputParameterValue in outputParameterValues)
                    {
                        if (outputParameterValue.parameter == parameter)
                        {
                            PutTokens(resultPin, outputParameterValue.values);
                        }
                    }
                }
            }

            callExecution.Destroy();
            RemoveCallExecution(callExecution);
        }

        public void CompleteStreamingCall()
        {
            // Complete a streaming call execution and then complete this call action activation.

            if (callExecutions.Count > 0)
            {
                // Note: If the call is streaming, then isLocallyReentrant = false and
                // there should be at most one call execution.
                CompleteCall(callExecutions.ElementAt(0));
                base.CompleteAction();
            }
        }

        public override List<OutputPin> GetOfferingOutputPins()
        {
            // Only send offers from output pins that correspond to non-streaming parameters.

            return nonStreamingOutputPins;
        }

        public abstract List<Parameter> GetParameters();

        public abstract Execution GetCallExecution();

        public override void Terminate()
        {
            // Terminate all call executions (if any). If this call action
            // activation is streaming, complete the call before terminating the call  
            // execution. Finally, terminate the call action activation itself.

            if (isStreaming)
            {
                CompleteStreamingCall();
            }
            else
            {
                foreach (Execution execution in callExecutions)
                {
                    execution.Terminate();
                }
            }

            base.Terminate();
        } // terminate

        public void RemoveCallExecution(Execution execution)
        {
            // Remove the given execution from the current list of call executions.

            bool notFound = true;
            int i = 1;
            while (notFound & i <= callExecutions.Count)
            {
                if (callExecutions.ElementAt(i - 1) == execution)
                {
                    callExecutions.RemoveAt(i - 1);
                    notFound = false;
                }
                i++;
            }
        } // removeCallExecution
    } // CallActionActivation
}
