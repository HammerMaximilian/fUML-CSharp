using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;
using System;

namespace fuml.library.realfunctions
{
    public abstract class RealRelationalFunctionBehaviorExecution : OpaqueBehaviorExecution
    {
        public override void DoBody(
        List<ParameterValue> inputParameters,
        List<ParameterValue> outputParameters)
        {
            // Extract real arguments and perform an integer function on them.

            List<float> integerArguments = new();

            foreach (ParameterValue inputParameter in inputParameters)
            {
                float value = ((RealValue)inputParameter.values.ElementAt(0)).value;
                Debug.Println("[doBody] argument = " + value);
                integerArguments.Add(value);
            }

            BooleanValue result = new()
            {
                value = DoRealFunction(integerArguments),
                type = locus?.factory?.GetBuiltInType("Boolean")
            };

            Debug.Println("[doBody] result = " + result.value);

            // Add output to the outputParameters list
            outputParameters.ElementAt(0).values.Add(result);
        }

        public abstract bool DoRealFunction(List<float> arguments);
    } // RealRelationalFunctionBehaviorExecution
}
