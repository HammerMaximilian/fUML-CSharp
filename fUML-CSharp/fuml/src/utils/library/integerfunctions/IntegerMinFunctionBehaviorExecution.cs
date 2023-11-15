using fuml.semantics.values;

namespace fuml.library.integerfunctions
{
    public class IntegerMinFunctionBehaviorExecution : IntegerFunctionBehaviorExecution
    {
        public IntegerMinFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Min);
        }

        public override int? DoIntegerFunction(List<int> arguments)
        {

            int i1 = arguments.ElementAt(0);
            int i2 = arguments.ElementAt(1);

            int i = (i1 <= i2) ? i1 : i2;

            Debug.Println("[doBody] Integer Min result = " + i);
            return i;
        }

        public override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.
            return new IntegerMinFunctionBehaviorExecution();
        }
    } // IntegerMinFunctionBehaviorExecution
}
