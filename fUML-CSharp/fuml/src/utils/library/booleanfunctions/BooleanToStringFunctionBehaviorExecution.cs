using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;

namespace fuml.library.booleanfunctions
{
    public class BooleanToStringFunctionBehaviorExecution : OpaqueBehaviorExecution
    {
        public BooleanToStringFunctionBehaviorExecution() 
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_ToString);
        }
        public override void DoBody(List<ParameterValue> inputParameters, List<ParameterValue> outputParameters)
        {
            BooleanValue bv1 = (BooleanValue)inputParameters.ElementAt(0).values.ElementAt(0);
            Debug.Println("[doBody] argument = " + bv1.value);

            StringValue resultObj = new()
            {
                value = bv1.ToString(),
                type = locus?.factory?.GetBuiltInType("String")
            };
            Debug.Println("[doBody] Boolean ToString result = " + resultObj.value);

            outputParameters.ElementAt(0).values.Add(resultObj);
        }

        protected override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.
            return new BooleanToStringFunctionBehaviorExecution();
        }
    } // BooleanToStringFunctionBehaviorExecution
}
