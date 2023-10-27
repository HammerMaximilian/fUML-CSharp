

using fuml.syntax.classification;

namespace fuml.semantics.commonbehavior
{
    public abstract class OpaqueBehaviorExecution : Execution
    {
        public override void execute()
        {
            // Execute the body of the opaque behavior.

            Debug.println("[execute] Opaque behavior " + this.getBehavior().name + "...");

            List<Parameter> parameters = getBehavior().ownedParameter;

            List<ParameterValue> inputs = new List<ParameterValue>();
            List<ParameterValue> outputs = new List<ParameterValue>();

            foreach (Parameter parameter in parameters)
            {
                if ((parameter.direction == ParameterDirectionKind.in_)
                    | (parameter.direction == ParameterDirectionKind.inout))
                {
                    inputs.Add(getParameterValue(parameter));
                }

                if ((parameter.direction == ParameterDirectionKind.inout)
                        | (parameter.direction == ParameterDirectionKind.out_)
                        | (parameter.direction == ParameterDirectionKind.return_))
                {
                    ParameterValue parameterValue = new ParameterValue();
                    parameterValue.parameter = parameter;
                    this.setParameterValue(parameterValue);
                    outputs.Add(parameterValue);
                }
            }

            this.doBody(inputs, outputs);
        } // execute

        public abstract void doBody(
                List<ParameterValue> inputParameters,
                List<ParameterValue> outputParameters);
    } // OpaqueBehaviorExecution
}
