using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;
using UMLPrimitiveTypes;

namespace fuml.library.unlimitednaturalfunctions
{
    public abstract class UnlimitedNaturalFunctionBehaviorExecution : OpaqueBehaviorExecution
    {
        public override void DoBody(
        List<ParameterValue> inputParameters,
        List<ParameterValue> outputParameters)
        {

            // Extract unlimited natural arguments and perform an integer function on them.

            List<int> integerArguments = new();

            foreach (ParameterValue inputParameter in inputParameters)
            {
                int value = ((UnlimitedNaturalValue)inputParameter.values.ElementAt(0)).value.naturalValue;
                Debug.Println("[doBody] argument = " + value);
                integerArguments.Add(value);
            }

            // Call the method specific to the integer function
            int resultValue = DoUnlimitedNaturalFunction(integerArguments);

            // Add output to the outputParameters list
            UnlimitedNaturalValue result = new()
            {
                value = new UnlimitedNatural()
            };
            result.value.naturalValue = resultValue;
            result.type = locus?.factory?.GetBuiltInType("UnlimitedNatural");
            outputParameters.ElementAt(0).values.Add(result);
        }

        public abstract int DoUnlimitedNaturalFunction(List<int> arguments);
    } // UnlimitedNaturalFunctionBehaviorExecution
}
