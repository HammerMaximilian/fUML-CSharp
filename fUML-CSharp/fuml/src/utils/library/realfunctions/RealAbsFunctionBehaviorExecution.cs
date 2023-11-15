using fuml.semantics.values;

namespace fuml.library.realfunctions
{
    public class RealAbsFunctionBehaviorExecution : RealFunctionBehaviorExecution
    {
        public RealAbsFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Abs);
        }

        public override float? DoRealFunction(List<float> arguments)
        {

            float arg1 = arguments.ElementAt(0);

            // Compute the absolute value function.
            float x = Math.Abs(arg1);
            Debug.Println("[doBody] Real Abs result = " + x);
            return x;
        }

        protected override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.
            return new RealAbsFunctionBehaviorExecution();
        }
    } // RealAbsFunctionBehaviorExecution
}
