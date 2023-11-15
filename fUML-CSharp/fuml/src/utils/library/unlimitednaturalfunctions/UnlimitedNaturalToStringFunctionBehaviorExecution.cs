using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;

namespace fuml.library.unlimitednaturalfunctions
{
    public class UnlimitedNaturalToStringFunctionBehaviorExecution : OpaqueBehaviorExecution
    {
        public UnlimitedNaturalToStringFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToString);
        }

        public override void DoBody(
        List<ParameterValue> inputParameters,
        List<ParameterValue> outputParameters)
        {

            UnlimitedNaturalValue unv1 = (UnlimitedNaturalValue)inputParameters.ElementAt(0).values.ElementAt(0);
            Debug.Println("[doBody] argument = " + unv1.value.naturalValue);

            // Perform the toString operation.  If value is -1, return "*"
            StringValue resultObj = new()
            {
                value = unv1.ToString(),
                type = locus?.factory?.GetBuiltInType("String")
            };

            Debug.Println("[doBody] Unlimited Natural ToString result = " + resultObj.value);

            // Add output to the outputParameters list
            outputParameters.ElementAt(0).values.Add(resultObj);
        }

        public override Value New_()
        {
            return new UnlimitedNaturalToStringFunctionBehaviorExecution();
        }
    } // UnlimitedNaturalToStringFunctionBehaviorExecution
}
