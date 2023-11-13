using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;

namespace fuml.library.integerfunctions
{
    public abstract class IntegerRelationalFunctionBehaviorExecution : OpaqueBehaviorExecution
    {
        public override void DoBody(
        List<ParameterValue> inputParameters,
        List<ParameterValue> outputParameters)
        {
            // Extract integer arguments and perform an integer function on them.

            List<int> integerArguments = new();

            foreach (ParameterValue inputParameter in inputParameters)
            {
                int value = ((IntegerValue)inputParameter.values.ElementAt(0)).value;
                Debug.Println("[doBody] argument = " + value);
                integerArguments.Add(value);
            }

            BooleanValue result = new();
            result.value = DoIntegerFunction(integerArguments);
            result.type = locus?.factory?.GetBuiltInType("Boolean");

            Debug.Println("[doBody] result = " + result.value);

            // Add output to the outputParameters list
            outputParameters.ElementAt(0).values.Add(result);
        }

        public abstract bool DoIntegerFunction(List<int> arguments);
    } // IntegerRelationalFunctionBehaviorExecution
}
