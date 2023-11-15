using fuml.semantics.commonbehavior;
using fuml.semantics.values;
using fuml.syntax.classification;
using fuml.syntax.commonbehavior;

namespace fuml.library.libraryclass
{
    public class OperationExecution : Execution
    {
        public void Set(ImplementationObject context, Operation operation)
        {
            this.context = context;

            OpaqueBehavior method = new()
            {
                specification = operation
            };

            foreach (Parameter operationParameter in operation.ownedParameter)
            {
                Parameter methodParameter = new()
                {
                    name = operationParameter.name,
                    direction = operationParameter.direction,
                    type = operationParameter.type,
                    multiplicityElement = operationParameter.multiplicityElement
                };
                method.ownedParameter.Add(methodParameter);
            }

            types.Add(method);
        }

        protected override Value New_()
        {
            return new OperationExecution();
        }

        public override void Execute()
        {

            // Note: The following ensures that this operation execution has
            // output parameter values for all output parameters in the correct
            // order. (Except inout parameters may still be out of order.)
            foreach (Parameter parameter in GetBehavior().ownedParameter)
            {
                if (parameter.direction == ParameterDirectionKind.out_ ||
                        parameter.direction == ParameterDirectionKind.return_)
                {
                    SetParameterValue(parameter, new List<Value>());
                }
            }

        (context as ImplementationObject)!.Execute(this);
        }

        public string GetOperationName()
        {
            return GetBehavior()?.specification?.name!;
        }

        public Parameter GetParameter(string parameterName)
        {
            Behavior method = GetBehavior();

            foreach (Parameter parameter in method.ownedParameter)
            {
                if (parameter.name.Equals(parameterName))
                {
                    return parameter;
                }
            }

            return null!;
        }

        public ParameterValue GetParameterValue(string parameterName)
        {
            return GetParameterValue(GetParameter(parameterName));
        }

        public void SetParameterValue(Parameter parameter, List<Value> values)
        {
            if (parameter is not null)
            {
                ParameterValue parameterValue = new()
                {
                    parameter = parameter,
                    values = values
                };

                SetParameterValue(parameterValue);
            }
        }

        public void SetParameterValue(string parameterName, List<Value> values)
        {
            SetParameterValue(GetParameter(parameterName), values);
        }

        public void SetParameterValue(string parameterName, Value value)
        {
            List<Value> valueList = new()
            {
                value
            };
            SetParameterValue(parameterName, valueList);
        }

        public void SetReturnParameterValue(List<Value> values)
        {
            Behavior method = GetBehavior();

            foreach (Parameter parameter in method.ownedParameter)
            {
                if (parameter.direction == ParameterDirectionKind.return_)
                {
                    SetParameterValue(parameter, values);
                    return;
                }
            }
        }

        public void SetReturnParameterValue(Value value)
        {
            List<Value> valueList = new()
            {
                value
            };
            SetReturnParameterValue(valueList);
        }
    } // OperationExecution
}
