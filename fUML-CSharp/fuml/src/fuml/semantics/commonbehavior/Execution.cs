using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using fuml.syntax.classification;
using fuml.syntax.commonbehavior;

namespace fuml.semantics.commonbehavior
{
    public abstract class Execution : Object_
    {
        public Object_? context = null;
        public List<ParameterValue> parameterValues = new();
        public Value? exception;

        public abstract void execute();

        public void terminate()
        {
            // Terminate an ongoing execution. By default, do nothing.

            return;
        } // terminate

        public override Value copy()
        {
            // Create a new execution that has the same behavior and parameterValues
            // as this execution.

            Execution newValue = (Execution)base.copy();

            newValue.context = context;

            List<ParameterValue> parameterValues = this.parameterValues;
            foreach (ParameterValue parameterValue in parameterValues)
            {
                newValue.parameterValues.Add(parameterValue.copy());
            }

            return newValue;
        } // copy

        public abstract new Value new_();

        public void setParameterValue(
                ParameterValue parameterValue)
        {
            // Set the given parameter value for this execution.
            // If a parameter value already existed for the parameter of the given
            // parameter value, then replace its value.

            ParameterValue existingParameterValue =
                    getParameterValue(parameterValue?.parameter!);

            if (existingParameterValue is null)
            {
                parameterValues.Add(parameterValue!);
            }
            else
            {
                existingParameterValue.values = (parameterValue is not null) ? parameterValue.values : new();
            }

        } // setParameterValue

        public ParameterValue getParameterValue(
                Parameter parameter)
        {
            // Get the parameter value of this execution corresponding to the given
            // parameter (if any).

            ParameterValue? parameterValue = null;
            int i = 1;
            while (parameterValue is null & i <= parameterValues.Count)
            {
                if (parameterValues.ElementAt(i - 1).parameter == parameter)
                {
                    parameterValue = parameterValues.ElementAt(i - 1);
                }
                i++;
            }

            return parameterValue!;

        } // getParameterValue

        public List<ParameterValue> getOutputParameterValues()
        {
            // Return the parameter values for output (in-out, out and return)
            // parameters.

            List<ParameterValue> outputs = new();
            List<ParameterValue> parameterValues = this.parameterValues;
            foreach (ParameterValue parameterValue in parameterValues)
            {
                Parameter parameter = parameterValue?.parameter!;
                if ((parameter.direction == ParameterDirectionKind.inout)
                        | (parameter.direction == ParameterDirectionKind.out_)

                    | (parameter.direction == ParameterDirectionKind.return_))
                {
                    outputs.Add(parameterValue!);
                }
            }

            return outputs;
        } // getOutputParameterValues

        public Behavior getBehavior()
        {
            // Get the behavior that is the type of this execution.

            return (Behavior)getTypes().ElementAt(0);
        } // getBehavior

        public override void destroy()
        {
            // Terminate the execution before destroying it.

            terminate();
            base.destroy();
        }

        public void propagateException(Value exception)
        {
            // Set the propagated exception for this execution to the given exception,
            // then terminate the execution.

            this.exception = exception;
            terminate();
        }
    } // Execution
}
