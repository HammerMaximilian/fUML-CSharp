using fuml.semantics.values;

namespace fuml.library.realfunctions
{
    public class RealDivideFunctionBehaviorExecution : RealFunctionBehaviorExecution
    {
        public override float? DoRealFunction(List<float> arguments)
        {
            // Compute the integer divide function.

            float arg1 = arguments.ElementAt(0);
            float arg2 = arguments.ElementAt(1);

            // Check for illegal divide by zero
            if (arg2 == 0)
            {
                Debug.Println("[doBody] Real Divide, divide by zero not allowed");
                return null;
            }

            // Perform Divide function
            float x = arg1 / arg2;
            Debug.Println("[doBody] Integer Divide result = " + x);
            return x;
        }

        public override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.

            return new RealDivideFunctionBehaviorExecution();
        }
    } // RealDivideFunctionBehaviorExecution
}
