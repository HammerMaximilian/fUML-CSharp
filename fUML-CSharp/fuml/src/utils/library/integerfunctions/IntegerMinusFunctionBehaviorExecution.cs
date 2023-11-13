using fuml.semantics.values;

namespace fuml.library.integerfunctions
{
    public class IntegerMinusFunctionBehaviorExecution : IntegerFunctionBehaviorExecution
    {
        public override int? DoIntegerFunction(List<int> arguments)
        {

            int i1 = arguments.ElementAt(0);
            int i2 = arguments.ElementAt(1);

            int i = i1 - i2;

            Debug.Println("[doBody] Integer Minus result = " + i);
            return i;
        }

        public override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.
            return new IntegerMinusFunctionBehaviorExecution();
        }
    } // IntegerMinusFunctionBehaviorExecution
}
