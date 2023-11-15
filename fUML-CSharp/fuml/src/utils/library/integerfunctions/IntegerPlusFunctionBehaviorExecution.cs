using fuml.semantics.values;

namespace fuml.library.integerfunctions
{
    public class IntegerPlusFunctionBehaviorExecution : IntegerFunctionBehaviorExecution
    {
        public IntegerPlusFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_plus);
        }

        public override int? DoIntegerFunction(List<int> arguments)
        {

            int i1 = arguments.ElementAt(0);
            int i2 = arguments.ElementAt(1);

            // Compute the integer plus function.
            int i = i1 + i2;

            Debug.Println("[doBody] Integer Plus result = " + i);
            return i;
        }

        protected override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.
            return new IntegerPlusFunctionBehaviorExecution();
        }
    } // IntegerPlusFunctionBehaviorExecution
}
