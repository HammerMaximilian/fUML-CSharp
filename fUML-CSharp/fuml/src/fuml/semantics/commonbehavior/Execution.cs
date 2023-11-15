using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using uml.classification;
using uml.commonbehavior;

namespace fuml.semantics.commonbehavior
{
    public abstract class Execution : Object_
    {
        public Object_? context = null;
        public List<ParameterValue> parameterValues = new();
        public Value? exception;

        public abstract void Execute();

        public virtual void Terminate()
        {
            // Terminate an ongoing execution. By default, do nothing.

            return;
        } // terminate

        public override Value Copy()
        {
            // Create a new execution that has the same behavior and parameterValues
            // as this execution.

            Execution newValue = (Execution)base.Copy();

            newValue.context = context;

            List<ParameterValue> parameterValues = this.parameterValues;
            foreach (ParameterValue parameterValue in parameterValues)
            {
                newValue.parameterValues.Add(parameterValue.Copy());
            }

            return newValue;
        } // copy

        // From Java reference implementation
        // In C# it is not allowed to change access modifiers of overridden methods
        // Thus, 'Value New_()' remains protected in derived classes from here
        //public abstract override Value New_();

        public void SetParameterValue(
                ParameterValue parameterValue)
        {
            // Set the given parameter value for this execution.
            // If a parameter value already existed for the parameter of the given
            // parameter value, then replace its value.

            ParameterValue existingParameterValue =
                    GetParameterValue(parameterValue?.parameter!);

            if (existingParameterValue is null)
            {
                parameterValues.Add(parameterValue!);
            }
            else
            {
                existingParameterValue.values = (parameterValue is not null) ? parameterValue.values : new();
            }

        } // setParameterValue

        public ParameterValue GetParameterValue(
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

        public List<ParameterValue> GetOutputParameterValues()
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

        public Behavior GetBehavior()
        {
            // Get the behavior that is the type of this execution.

            return (Behavior)GetTypes().ElementAt(0);
        } // getBehavior

        public override void Destroy()
        {
            // Terminate the execution before destroying it.

            Terminate();
            base.Destroy();
        }

        public void PropagateException(Value exception)
        {
            // Set the propagated exception for this execution to the given exception,
            // then terminate the execution.

            this.exception = exception;
            Terminate();
        }
    } // Execution
}
