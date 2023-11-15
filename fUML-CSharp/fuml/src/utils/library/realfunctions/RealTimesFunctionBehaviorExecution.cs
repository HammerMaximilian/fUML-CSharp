using fuml.semantics.values;

namespace fuml.library.realfunctions
{
    public class RealTimesFunctionBehaviorExecution : RealFunctionBehaviorExecution
    {
        public RealTimesFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_times);
        }

        public override float? DoRealFunction(List<float> arguments)
        {

            float x1 = arguments.ElementAt(0);
            float x2 = arguments.ElementAt(1);

            float x = x1 * x2;

            Debug.Println("[doBody] Real Multiply result = " + x);
            return x;
        }

        protected override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.
            return new RealTimesFunctionBehaviorExecution();
        }
    } // RealTimesFunctionBehaviorExecution
}
