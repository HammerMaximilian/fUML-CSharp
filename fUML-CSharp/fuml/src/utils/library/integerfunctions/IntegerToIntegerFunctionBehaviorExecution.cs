using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;

namespace fuml.library.integerfunctions
{
    public class IntegerToIntegerFunctionBehaviorExecution : OpaqueBehaviorExecution
    {
        public override void DoBody(
        List<ParameterValue> inputParameters,
        List<ParameterValue> outputParameters)
        {
            // Extract integer arguments and perform an integer function on them.

            StringValue sv = (StringValue)inputParameters.ElementAt(0).values.ElementAt(0);
            string value = sv.value;
            Debug.Println("[doBody] argument = " + value);

            // Convert String to int
            if (!int.TryParse(value, out int resultInt))
            {
                // If the String does not specify an integer, simply return an empty values list
                Debug.Println("[doBody] string does not specify an integer: " + value);
                return;
            }

            IntegerValue result = new()
            {
                value = resultInt,
                type = locus?.factory?.GetBuiltInType("Integer")
            };

            Debug.Println("[doBody] Integer ToInteger result = " + result.value);

            // Add output to the outputParameters list
            outputParameters.ElementAt(0).values.Add(result);
        }

        public override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.
            return new IntegerToIntegerFunctionBehaviorExecution();
        }
    } // IntegerToIntegerFunctionBehaviorExecution
}
