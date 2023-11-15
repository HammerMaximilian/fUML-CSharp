using fuml.semantics.values;

namespace fuml.library.integerfunctions
{
    public class IntegerModFunctionBehaviorExecution : IntegerFunctionBehaviorExecution
    {
        public IntegerModFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Mod);
        }

        public override int? DoIntegerFunction(List<int> arguments)
        {

            int i1 = arguments.ElementAt(0);
            int i2 = arguments.ElementAt(1);

            // Modulus requires second argument to be non-zero
            if (i2 == 0)
            {
                Debug.Println("[doBody] Integer Modulo requires non-zero second argument");
                return null;
            }

            // Compute the modulo value function.
            int i = i1 % i2;

            Debug.Println("[doBody] Integer Modulo result = " + i);
            return i;
        }

        protected override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.
            return new IntegerModFunctionBehaviorExecution();
        }
    } // IntegerModFunctionBehaviorExecution
}
