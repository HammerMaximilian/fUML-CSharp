using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;

namespace fuml.library.realfunctions
{
    public class RealToIntegerFunctionBehaviorExecution : OpaqueBehaviorExecution
    {
        public RealToIntegerFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToInteger);
        }

        public override void DoBody(
        List<ParameterValue> inputParameters,
        List<ParameterValue> outputParameters)
        {

            RealValue rv = (RealValue)inputParameters.ElementAt(0).values.ElementAt(0);
            float x = rv.value;
            Debug.Println("[doBody] argument = " + x);

            int resultInt = (int)((x >= 0) ? Math.Floor(x) : -Math.Floor(-x));

            IntegerValue result = new()
            {
                value = resultInt,
                type = locus?.factory?.GetBuiltInType("Integer")
            };

            Debug.Println("[doBody] Real ToInteger result = " + result.value);

            outputParameters.ElementAt(0).values.Add(result);
        }

        protected override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.
            return new RealToIntegerFunctionBehaviorExecution();
        }
    } // RealToIntegerFunctionBehaviorExecution
}
