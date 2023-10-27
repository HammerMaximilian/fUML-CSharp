

using fuml.syntax.classification;

namespace fuml.semantics.commonbehavior
{
    public abstract class OpaqueBehaviorExecution : Execution
    {
        public override void Execute()
        {
            // Execute the body of the opaque behavior.

            Debug.println("[execute] Opaque behavior " + GetBehavior().name + "...");

            List<Parameter> parameters = GetBehavior().ownedParameter;

            List<ParameterValue> inputs = new();
            List<ParameterValue> outputs = new();

            foreach (Parameter parameter in parameters)
            {
                if ((parameter.direction == ParameterDirectionKind.in_)
                    | (parameter.direction == ParameterDirectionKind.inout))
                {
                    inputs.Add(GetParameterValue(parameter));
                }

                if ((parameter.direction == ParameterDirectionKind.inout)
                        | (parameter.direction == ParameterDirectionKind.out_)
                        | (parameter.direction == ParameterDirectionKind.return_))
                {
                    ParameterValue parameterValue = new()
                    {
                        parameter = parameter
                    };
                    SetParameterValue(parameterValue);
                    outputs.Add(parameterValue);
                }
            }

            DoBody(inputs, outputs);
        } // execute

        public abstract void DoBody(
                List<ParameterValue> inputParameters,
                List<ParameterValue> outputParameters);
    } // OpaqueBehaviorExecution
}
