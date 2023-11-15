using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;
using UMLPrimitiveTypes;

namespace fuml.library.unlimitednaturalfunctions
{
    public class UnlimitedNaturalToUnlimitedNaturalFunctionBehaviorExecution : OpaqueBehaviorExecution
    {
        public UnlimitedNaturalToUnlimitedNaturalFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToUnlimitedNatural);
        }

        public override void DoBody(
        List<ParameterValue> inputParameters,
        List<ParameterValue> outputParameters)
        {

            // Get first StringValue input argument
            StringValue sv1 = (StringValue)inputParameters.ElementAt(0).values.ElementAt(0);
            string s = sv1.value;
            Debug.Println("[doBody] argument = " + s);

            UnlimitedNatural un = new();
            UnlimitedNaturalValue resultObj = new()
            {
                value = un,
                type = locus?.factory?.GetBuiltInType("UnlimitedNatural")
            };

            // If the String is value "*", it specifies unbounded.
            if (s.Equals("*"))
            {
                un.naturalValue = -1;
                Debug.Println("[doBody] Unlimited Natural ToUnlimitedNatural result = -1");
                // Add output to the outputParameters list
                outputParameters.ElementAt(0).values.Add(resultObj);
                return;
            }

            // Convert String to integer.
            if (!int.TryParse(s, out int i))
            {
                // If the String does not specify an integer, simply return an empty values list
                Debug.Println("[doBody] string does not specify an integer: " + s);
                return;
            }

            // If the integer is less than -1, it cannot be converted to an UnlimitedNatural.
            // Return an empty values list
            if (i < 0)
            {
                Debug.Println("[doBody] Cannot be converted to an UnlimitedNatural: " + i);
            }
            else
            {
                Debug.Println("[doBody] Unlimited Natural ToUnlimitedNatural result = " + i);
                un.naturalValue = i;
                // Add output to the outputParameters list
                outputParameters.ElementAt(0).values.Add(resultObj);
            }

            return;
        }

        protected override Value New_()
        {
            return new UnlimitedNaturalToUnlimitedNaturalFunctionBehaviorExecution();
        }
    } // UnlimitedNaturalToUnlimitedNaturalFunctionBehaviorExecution
}
