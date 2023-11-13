using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;

namespace fuml.library.stringfunctions
{
    public class StringSizeFunctionBehaviorExecution : OpaqueBehaviorExecution
    {
        public override void DoBody(
        List<ParameterValue> inputParameters,
        List<ParameterValue> outputParameters)
        {

            StringValue sv1 = (StringValue)inputParameters.ElementAt(0).values.ElementAt(0);
            string s1 = sv1.value;
            Debug.Println("[doBody] argument = " + s1);

            // Determine the length of the String
            int size = s1.Length;

            IntegerValue result = new();
            result.value = size;
            result.type = locus?.factory?.GetBuiltInType("Integer");

            Debug.Println("[doBody] String Size result = " + result.value);

            // Add output to the outputParameters list
            outputParameters.ElementAt(0).values.Add(result);
        }

        public override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.
            return new StringSizeFunctionBehaviorExecution();
        }
    } // StringSizeFunctionBehaviorExecution
}
