using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;

namespace fuml.library.stringfunctions
{
    public class StringSizeFunctionBehaviorExecution : OpaqueBehaviorExecution
    {
        public StringSizeFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_StringFunctions_Size);
        }

        public override void DoBody(
        List<ParameterValue> inputParameters,
        List<ParameterValue> outputParameters)
        {

            StringValue sv1 = (StringValue)inputParameters.ElementAt(0).values.ElementAt(0);
            string s1 = sv1.value;
            Debug.Println("[doBody] argument = " + s1);

            // Determine the length of the String
            int size = s1.Length;

            IntegerValue result = new()
            {
                value = size,
                type = locus?.factory?.GetBuiltInType("Integer")
            };

            Debug.Println("[doBody] String Size result = " + result.value);

            // Add output to the outputParameters list
            outputParameters.ElementAt(0).values.Add(result);
        }

        protected override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.
            return new StringSizeFunctionBehaviorExecution();
        }
    } // StringSizeFunctionBehaviorExecution
}
