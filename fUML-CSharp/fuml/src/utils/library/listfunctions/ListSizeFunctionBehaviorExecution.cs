using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;

namespace fuml.library.listfunctions
{
    public class ListSizeFunctionBehaviorExecution : OpaqueBehaviorExecution
    {
        public ListSizeFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListSize);
        }

        public override void DoBody(
        List<ParameterValue> inputParameters,
        List<ParameterValue> outputParameters)
        {

            // Get the list for which to determine the size
            List<Value> vl = inputParameters.ElementAt(0).values;

            // Determine the length of the list
            int size = vl.Count;

            // Return the size in an IntegerValue object
            IntegerValue result = new()
            {
                value = size,
                type = locus?.factory?.GetBuiltInType("Integer")
            };

            Debug.Println("[doBody] List<> Size, result=" + result.value);

            // Add output to the outputParameters list
            outputParameters.ElementAt(0).values.Add(result);
        }

        public override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.
            return new ListSizeFunctionBehaviorExecution();
        }
    } // ListSizeFunctionBehaviorExecution
}
