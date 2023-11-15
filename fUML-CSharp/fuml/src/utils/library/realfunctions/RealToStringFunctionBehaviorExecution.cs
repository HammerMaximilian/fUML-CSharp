using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;

namespace fuml.library.realfunctions
{
    public class RealToStringFunctionBehaviorExecution : OpaqueBehaviorExecution
    {
        public RealToStringFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToString);
        }

        public override void DoBody(
        List<ParameterValue> inputParameters,
        List<ParameterValue> outputParameters)
        {

            RealValue rv = (RealValue)inputParameters.ElementAt(0).values.ElementAt(0);
            Debug.Println("[doBody] argument = " + rv.value);

            StringValue result = new()
            {
                value = rv.value.ToString(),
                type = locus?.factory?.GetBuiltInType("String")
            };

            Debug.Println("[doBody] Real ToString result = " + result.value);

            outputParameters.ElementAt(0).values.Add(result);
        }

        public override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.
            return new RealToStringFunctionBehaviorExecution();
        }
    } // RealToStringFunctionBehaviorExecution
}
