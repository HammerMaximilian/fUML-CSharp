using fuml.semantics.commonbehavior;
using fuml.semantics.values;

namespace fuml.library.listfunctions
{
    public class ListConcatFunctionBehaviorExecution : OpaqueBehaviorExecution
    {
        public ListConcatFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListConcat);
        }

        public override void DoBody(
        List<ParameterValue> inputParameters,
        List<ParameterValue> outputParameters)
        {

            List<Value> list1 = inputParameters.ElementAt(0).values;
            List<Value> list2 = inputParameters.ElementAt(1).values;

            List<Value> result = new();
            result.AddRange(list1);
            result.AddRange(list2);

            Debug.Println("[doBody] List<> Concat, result=" + result);

            outputParameters.ElementAt(0).values = result;
        }

        public override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.
            return new ListConcatFunctionBehaviorExecution();
        }
    } // ListConcatFunctionBehaviorExecution
}
