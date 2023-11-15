using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;
using UMLPrimitiveTypes;

namespace fuml.library.integerfunctions
{
    public class IntegerToUnlimitedNaturalFunctionBehaviorExecution : OpaqueBehaviorExecution
    {
        public IntegerToUnlimitedNaturalFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_ToUnlimitedNatural);
        }

        public override void DoBody(
        List<ParameterValue> inputParameters,
        List<ParameterValue> outputParameters)
        {
            // Extract integer arguments and perform an integer function on them.

            IntegerValue iv = (IntegerValue)inputParameters.ElementAt(0).values.ElementAt(0);
            int value = iv.value;
            Debug.Println("[doBody] argument = " + value);

            if (value < 0)
            {
                Debug.Println("[doBody] Value is <0 and cannot be converted to UnlimitedNatural: " + value);
                return;
            }

            // Convert int to UnlimitedNatural
            UnlimitedNatural unlimitedNatural = new()
            {
                naturalValue = value
            };
            UnlimitedNaturalValue result = new()
            {
                value = unlimitedNatural,
                type = locus?.factory?.GetBuiltInType("UnlimitedNatural")
            };

            Debug.Println("[doBody] Integer ToUnlimitedNatural result = " + result.value.naturalValue);

            // Add output to the outputParameters list
            outputParameters.ElementAt(0).values.Add(result);
        }

        public override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.
            return new IntegerToUnlimitedNaturalFunctionBehaviorExecution();
        }
    } // IntegerToUnlimitedNaturalFunctionBehaviorExecution
}
