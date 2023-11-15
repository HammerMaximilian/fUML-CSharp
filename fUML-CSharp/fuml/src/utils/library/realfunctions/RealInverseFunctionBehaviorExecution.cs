using fuml.semantics.values;

namespace fuml.library.realfunctions
{
    public class RealInverseFunctionBehaviorExecution : RealFunctionBehaviorExecution
    {
        public RealInverseFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Inv);
        }

        public override float? DoRealFunction(List<float> arguments)
        {

            float x1 = arguments.ElementAt(0);

            float x = 1.0f / x1;

            Debug.Println("[doBody] Real Inverse result = " + x);
            return x;
        }

        protected override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.
            return new RealInverseFunctionBehaviorExecution();
        }
    } // RealInverseFunctionBehaviorExecution
}
