using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;

namespace fuml.library.stringfunctions
{
    public class StringSubstringFunctionBehaviorExecution : OpaqueBehaviorExecution
    {
        public StringSubstringFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Substring);
        }

        public override void DoBody(
        List<ParameterValue> inputParameters,
        List<ParameterValue> outputParameters)
        {

            StringValue sv1 = (StringValue)inputParameters.ElementAt(0).values.ElementAt(0);
            string s1 = sv1.value;
            Debug.Println("[doBody] argument, string = " + s1);
            IntegerValue lowerValue = (IntegerValue)inputParameters.ElementAt(1).values.ElementAt(0);
            int lower = lowerValue.value; // lower value
            Debug.Println("[doBody] argument, lower = " + lower);
            IntegerValue upperValue = (IntegerValue)inputParameters.ElementAt(2).values.ElementAt(0);
            int upper = upperValue.value;   // upper value
            Debug.Println("[doBody] argument, upper = " + upper);

            // Check for invalid values.  A lower value of less than 1 or greater than the
            // length of the string is invalid.
            if (lower < 1 || lower > s1.Length)
            {
                Debug.Println("[doBody] invalid lower value for String Substring: " + lower);
                // return empty list for invalid input
                return;
            }

            // Same checks for upper value
            if (upper < 1 || upper > s1.Length)
            {
                Debug.Println("[doBody] invalid upper value for String Substring: " + upper);
                // return empty list for invalid input
                return;
            }

            // Upper cannot be less than lower.  Note upper and lower can be equal.
            if (upper < lower)
            {
                Debug.Println("[doBody] upper is less than lower for String Substring");
                // return empty list for invalid input
                return;
            }

            // Extract the substring.  The fUML behavior differs from the Java method behavior.
            // The fUML substring's lower value is 1-based, while the Java substring method's
            // lower value is 0-based. Moreover, the fUML substring behavior is based
            // on an upper value, while C++ substring method is size-based.
            // Therefore, the length of the substring has to be calculated first.

            int size = upper - lower + 1;
            string resultString = s1.Substring(lower - 1, size);

            StringValue result = new()
            {
                value = resultString,
                type = locus?.factory?.GetBuiltInType("String")
            };

            Debug.Println("[doBody] String Substring result = " + result.value);

            // Add output to the outputParameters list
            outputParameters.ElementAt(0).values.Add(result);
        }

        public override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.
            return new StringSubstringFunctionBehaviorExecution();
        }
    } // StringSubstringFunctionBehaviorExecution
}
