using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;

namespace fuml.library.booleanfunctions
{
    public abstract class BooleanFunctionBehaviorExecution : OpaqueBehaviorExecution
    {
        public override void DoBody(List<ParameterValue> inputParameters, List<ParameterValue> outputParameters)
        {

            List<bool> arguments = new();

            foreach (ParameterValue inputParameter in inputParameters)
            {
                bool value_ = ((BooleanValue)inputParameter.values.ElementAt(0)).value;
                Debug.Println("[doBody] argument = " + value_);
                arguments.Add(value_);
            }

            bool value = DoBooleanFunction(arguments);

            BooleanValue result = new()
            {
                value = value,
                type = locus?.factory?.GetBuiltInType("Boolean")
            };

            outputParameters.ElementAt(0).values.Add(result);
        }

        public abstract bool DoBooleanFunction(List<bool> arguments);
    } // BooleanFunctionBehaviorExecution
}
