using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;
using UMLPrimitiveTypes;

namespace fuml.library.unlimitednaturalfunctions
{
    public class UnlimitedNaturalToIntegerFunctionBehaviorExecution : OpaqueBehaviorExecution
    {
        public UnlimitedNaturalToIntegerFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_ToInteger);
        }

        public override void DoBody(
        List<ParameterValue> inputParameters,
        List<ParameterValue> outputParameters)
        {

            // Get first UnlimitedNatural input argument
            UnlimitedNaturalValue unv1 = (UnlimitedNaturalValue)inputParameters.ElementAt(0).values.ElementAt(0);
            UnlimitedNatural un1 = unv1.value;
            Debug.Println("[doBody] argument = " + un1.naturalValue);

            // If the unlimited natural is unbounded (equal to -1), it cannot be
            // converted to an integer.  Return an empty values list.
            if (un1.naturalValue == -1)
            {
                Debug.Println("[doBody] Unbounded input invalid for ToInteger function");
            }
            else
            {
                IntegerValue resultObj = new()
                {
                    value = un1.naturalValue,
                    type = locus?.factory?.GetBuiltInType("Integer")
                };
                Debug.Println("[doBody] Unlimited Natural ToInteger result = " + resultObj.value);
                // Add output to the outputParameters list
                outputParameters.ElementAt(0).values.Add(resultObj);
            }
        }

        protected override Value New_()
        {
            return new UnlimitedNaturalToIntegerFunctionBehaviorExecution();
        }
    } // UnlimitedNaturalToIntegerFunctionBehaviorExecution
}
