using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;

namespace fuml.library.listfunctions
{
    public class ListGetFunctionBehaviorExecution : OpaqueBehaviorExecution
    {
        public ListGetFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListGet);
        }

        public override void DoBody(
        List<ParameterValue> inputParameters,
        List<ParameterValue> outputParameters)
        {

            // Get the list for which to find the element from the first argument
            List<Value> vl = inputParameters.ElementAt(0).values;

            // Get the position in the list from the second argument
            IntegerValue iv = (IntegerValue)inputParameters.ElementAt(1).values.ElementAt(0);
            int position = iv.value;
            Debug.Println("[doBody] List<> Get, position=" + position);

            // The position must be 1 or greater, since index is 1-based
            if (position < 1)
            {
                Debug.Println("[doBody] List<> Get, invalid value (return nothing).");
                // invalid value for 1-based index, return empty list
                return;
            }

            // Find the element based on position
            try
            {
                // Find the element in the list by its position.  Offset index by 1,
                // since the underlying list is 0-based, while this API is 1-based
                Value result = vl.ElementAt(position - 1);

                Debug.Println("[doBody] List<> Get, result=" + result);

                // Add output to the outputParameters list.  The output can be a
                // reference to the original object in the input list.
                outputParameters.ElementAt(0).values.Add(result);
            }
            catch (IndexOutOfRangeException)
            {
                Debug.Println("[doBody] List<> Get, index out of bounds error (return nothing).");
                // If element does not exist, return empty list
                return;
            }
        }

        protected override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.
            return new ListGetFunctionBehaviorExecution();
        }
    } // ListGetFunctionBehaviorExecution
}
