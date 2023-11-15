using fuml.semantics.values;

namespace fuml.library.integerfunctions
{
    public class IntegerTimesFunctionBehaviorExecution : IntegerFunctionBehaviorExecution
    {
        public IntegerTimesFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_times);
        }

        public override int? DoIntegerFunction(List<int> arguments)
        {

            int i1 = arguments.ElementAt(0);
            int i2 = arguments.ElementAt(1);

            // Compute the integer times function.
            int i = i1 * i2;

            Debug.Println("[doBody] Integer Multiply result = " + i);
            return i;
        }

        public override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.
            return new IntegerTimesFunctionBehaviorExecution();
        }
    } // IntegerTimesFunctionBehaviorExecution
}
