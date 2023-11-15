using fuml.semantics.values;

namespace fuml.library.integerfunctions
{
    public class IntegerNegateFunctionBehaviorExecution : IntegerFunctionBehaviorExecution
    {
        public IntegerNegateFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Neg);
        }

        public override int? DoIntegerFunction(List<int> arguments)
        {

            int i1 = arguments.ElementAt(0);

            // Compute the negate  function.
            int i = -i1;

            Debug.Println("[doBody] Integer Negate result = " + i);
            return i;
        }

        public override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.
            return new IntegerNegateFunctionBehaviorExecution();
        }
    } // IntegerNegateFunctionBehaviorExecution
}
