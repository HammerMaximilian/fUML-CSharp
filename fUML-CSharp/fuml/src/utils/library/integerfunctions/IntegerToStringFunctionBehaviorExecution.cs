using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;

namespace fuml.library.integerfunctions
{
    public class IntegerToStringFunctionBehaviorExecution : OpaqueBehaviorExecution
    {
        public IntegerToStringFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToString);
        }

        public override void DoBody(
        List<ParameterValue> inputParameters,
        List<ParameterValue> outputParameters)
        {

            IntegerValue iv = (IntegerValue)inputParameters.ElementAt(0).values.ElementAt(0);
            int i = iv.value;
            Debug.Println("[doBody] argument = " + i);

            // Convert int to String
            string resultString = i.ToString();
            StringValue result = new()
            {
                value = resultString,
                type = locus?.factory?.GetBuiltInType("String")
            };

            Debug.Println("[doBody] Integer ToString result = " + result.value);

            // Add output to the outputParameters list
            outputParameters.ElementAt(0).values.Add(result);
        }

        public override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.
            return new IntegerToStringFunctionBehaviorExecution();
        }
    } // IntegerToStringFunctionBehaviorExecution
}
