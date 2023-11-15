using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;

namespace fuml.library.stringfunctions
{
    public class StringConcatFunctionBehaviorExecution : OpaqueBehaviorExecution
    {
        public StringConcatFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Concat);
        }

        public override void DoBody(
        List<ParameterValue> inputParameters,
        List<ParameterValue> outputParameters)
        {

            StringValue sv1 = (StringValue)inputParameters.ElementAt(0).values.ElementAt(0);
            string s1 = sv1.value;
            Debug.Println("[doBody] argument = " + s1);

            StringValue sv2 = (StringValue)inputParameters.ElementAt(1).values.ElementAt(0);
            string s2 = sv2.value;
            Debug.Println("[doBody] argument = " + s2);

            // Concatenate the two strings
            string resultString = s1 + s2;

            StringValue result = new()
            {
                value = resultString,
                type = locus?.factory?.GetBuiltInType("String")
            };

            Debug.Println("[doBody] String Concat result = " + result.value);

            // Add output to the outputParameters list
            outputParameters.ElementAt(0).values.Add(result);
        }

        public override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.
            return new StringConcatFunctionBehaviorExecution();
        }
    } // StringConcatFunctionBehaviorExecution
}
