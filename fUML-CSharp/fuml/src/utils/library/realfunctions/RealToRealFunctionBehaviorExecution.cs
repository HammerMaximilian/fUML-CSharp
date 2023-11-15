using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;

namespace fuml.library.realfunctions
{
    public class RealToRealFunctionBehaviorExecution : OpaqueBehaviorExecution
    {
        public RealToRealFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_ToReal);
        }

        public override void DoBody(
        List<ParameterValue> inputParameters,
        List<ParameterValue> outputParameters)
        {

            StringValue sv = (StringValue)inputParameters.ElementAt(0).values.ElementAt(0);
            string value = sv.value;
            Debug.Println("[doBody] argument = " + value);

            if (!float.TryParse(value, out float resultFloat))
            {
                // If the String does not specify an float, simply return an empty values list
                Debug.Println("[doBody] string does not specify an real: " + value);
                return;
            }

            RealValue result = new()
            {
                value = resultFloat,
                type = locus?.factory?.GetBuiltInType("Real")
            };

            Debug.Println("[doBody] Real ToReal result = " + result.value);

            outputParameters.ElementAt(0).values.Add(result);
        }

        public override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.
            return new RealToRealFunctionBehaviorExecution();
        }
    } // RealToRealFunctionBehaviorExecution
}
