using fuml.semantics.values;

namespace fuml.library.integerfunctions
{
    public class IntegerDivFunctionBehaviorExecution : IntegerFunctionBehaviorExecution
    {
        public IntegerDivFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_Div);
        }

        public override int? DoIntegerFunction(List<int> arguments)
        {
            // Compute the integer divide function.

            int arg1 = arguments.ElementAt(0);
            int arg2 = arguments.ElementAt(1);

            // Check for illegal divide by zero
            if (arg2 == 0)
            {
                Debug.Println("[doBody] Integer Div, divide by zero not allowed");
                return null;
            }

            // Perform Divide function
            int i = arg1 / arg2;
            Debug.Println("[doBody] Integer Div result = " + i);
            return i;
        }

        protected override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.

            return new IntegerDivFunctionBehaviorExecution();
        }
    } // IntegerDivFunctionBehaviorExecution
}
