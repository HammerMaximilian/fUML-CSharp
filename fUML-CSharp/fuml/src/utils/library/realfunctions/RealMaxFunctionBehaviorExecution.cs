using fuml.semantics.values;

namespace fuml.library.realfunctions
{
    public class RealMaxFunctionBehaviorExecution : RealFunctionBehaviorExecution
    {
        public RealMaxFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Max);
        }

        public override float? DoRealFunction(List<float> arguments)
        {

            float x1 = arguments.ElementAt(0);
            float x2 = arguments.ElementAt(1);

            float x = (x1 >= x2) ? x1 : x2;

            Debug.Println("[doBody] Real Max result = " + x);
            return x;
        }

        public override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.
            return new RealMaxFunctionBehaviorExecution();
        }
    } // RealMaxFunctionBehaviorExecution
}
