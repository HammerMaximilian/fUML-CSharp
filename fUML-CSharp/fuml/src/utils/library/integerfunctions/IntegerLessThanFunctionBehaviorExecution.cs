using fuml.semantics.values;

namespace fuml.library.integerfunctions
{
    public class IntegerLessThanFunctionBehaviorExecution : IntegerRelationalFunctionBehaviorExecution
    {
        public IntegerLessThanFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_lessThan);
        }

        public override bool DoIntegerFunction(List<int> arguments)
        {

            int i1 = arguments.ElementAt(0);
            int i2 = arguments.ElementAt(1);

            bool b = i1 < i2;

            Debug.Println("[doBody] Integer Less Than result = " + b);
            return b;
        }

        public override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.
            return new IntegerLessThanFunctionBehaviorExecution();
        }
    } // IntegerLessThanFunctionBehaviorExecution
}
