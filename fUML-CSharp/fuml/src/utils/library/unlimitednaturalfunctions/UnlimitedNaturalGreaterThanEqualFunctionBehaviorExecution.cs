using fuml.semantics.values;

namespace fuml.library.unlimitednaturalfunctions
{
    public class UnlimitedNaturalGreaterThanEqualFunctionBehaviorExecution : UnlimitedNaturalRelationalFunctionBehaviorExecution
    {
        public UnlimitedNaturalGreaterThanEqualFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_greaterOrEqual);
        }

        public override bool DoUnlimitedNaturalFunction(List<int> arguments)
        {

            int i1 = arguments.ElementAt(0);
            int i2 = arguments.ElementAt(1);

            // This function returns true if i1 >= i2, where a value of -1 means 
            // "unbounded", which is the highest possible value.

            bool result = i1 == i2 || i1 < 0 || i2 >= 0 && i1 > i2;

            Debug.Println("[doBody] Unlimited Natural Greater Than or Equal result = " + result);
            return result;
        }

        public override Value New_()
        {
            return new UnlimitedNaturalGreaterThanEqualFunctionBehaviorExecution();
        }
    } // UnlimitedNaturalGreaterThanEqualFunctionBehaviorExecution
}
