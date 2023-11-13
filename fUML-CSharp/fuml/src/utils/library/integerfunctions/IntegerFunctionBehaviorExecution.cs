using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;

namespace fuml.library.integerfunctions
{
    public abstract class IntegerFunctionBehaviorExecution : OpaqueBehaviorExecution
    {
        public override void DoBody(
        List<ParameterValue> inputParameters,
        List<ParameterValue> outputParameters)
        {
            // Extract integer arguments and perform an integer function on them.

            List<int> integerArguments = new();

            foreach (ParameterValue inputParameter in inputParameters)
            {
                int value = ((IntegerValue)inputParameter.values.ElementAt(0)).value;
                Debug.Println("[doBody] argument = " + value);
                integerArguments.Add(value);
            }

            // Call the method specific to the integer function
            int? resultValue = DoIntegerFunction(integerArguments);

            if (resultValue == null)
            {
                // if null, then there is an invalid input argument, so return
                // an empty list
                
                //Nothing to do here since outputParameters is empty by default
            }
            else
            {
                // Add output to the outputParameters list
                IntegerValue result = new()
                {
                    value = (int)resultValue,
                    type = locus?.factory?.GetBuiltInType("Integer")
                };
                outputParameters.ElementAt(0).values.Add(result);
            }
        }

        public abstract int? DoIntegerFunction(List<int> arguments);
    } // IntegerFunctionBehaviorExecution
}
