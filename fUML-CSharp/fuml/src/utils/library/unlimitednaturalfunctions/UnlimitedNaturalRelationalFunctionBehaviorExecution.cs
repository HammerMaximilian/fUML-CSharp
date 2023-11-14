using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;

namespace fuml.library.unlimitednaturalfunctions
{
    public abstract class UnlimitedNaturalRelationalFunctionBehaviorExecution : OpaqueBehaviorExecution
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

            BooleanValue result = new()
            {
                value = DoUnlimitedNaturalFunction(integerArguments),
                type = locus?.factory?.GetBuiltInType("Boolean")
            };

            Debug.Println("[doBody] result = " + result.value);

            // Add output to the outputParameters list
            outputParameters.ElementAt(0).values.Add(result);
        }

        public abstract bool DoUnlimitedNaturalFunction(List<int> arguments);
    } // UnlimitedNaturalRelationalFunctionBehaviorExecution
}
