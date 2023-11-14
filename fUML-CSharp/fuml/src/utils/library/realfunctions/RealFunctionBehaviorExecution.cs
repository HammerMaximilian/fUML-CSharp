using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;

namespace fuml.library.realfunctions
{
    public abstract class RealFunctionBehaviorExecution : OpaqueBehaviorExecution
    {
        public override void DoBody(
        List<ParameterValue> inputParameters,
        List<ParameterValue> outputParameters)
        {
            // Extract real arguments and perform a real function on them.

            List<float> realArguments = new();

            foreach (ParameterValue inputParameter in inputParameters)
            {
                float value = ((RealValue)inputParameter.values.ElementAt(0)).value;
                Debug.Println("[doBody] argument = " + value);
                realArguments.Add(value);
            }

            // Call the method specific to the real function
            float? resultValue = DoRealFunction(realArguments);

            if (resultValue == null)
            {
                // if null, then there is an invalid input argument, so return
                // an empty list

                //Nothing to do here since outputParameters is empty by default
            }
            else
            {
                // Add output to the outputParameters list
                RealValue result = new()
                {
                    value = (float)resultValue,
                    type = locus?.factory?.GetBuiltInType("Real")
                };
                outputParameters.ElementAt(0).values.Add(result);
            }
        }

        public abstract float? DoRealFunction(List<float> arguments);
    } // RealFunctionBehaviorExecution
}
