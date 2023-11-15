using fuml.semantics.values;

namespace fuml.library.realfunctions
{
    public class RealNegateFunctionBehaviorExecution : RealFunctionBehaviorExecution
    {
        public RealNegateFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_RealFunctions_Neg);
        }

        public override float? DoRealFunction(List<float> arguments)
        {

            float x1 = arguments.ElementAt(0);

            float x = -x1;

            Debug.Println("[doBody] Real Negate result = " + x);
            return x;
        }

        protected override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.
            return new RealNegateFunctionBehaviorExecution();
        }
    } // RealNegateFunctionBehaviorExecution
}
