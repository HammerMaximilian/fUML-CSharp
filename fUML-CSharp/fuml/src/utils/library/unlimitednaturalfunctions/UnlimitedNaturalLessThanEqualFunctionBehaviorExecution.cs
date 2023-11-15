using fuml.semantics.values;

namespace fuml.library.unlimitednaturalfunctions
{
    public class UnlimitedNaturalLessThanEqualFunctionBehaviorExecution : UnlimitedNaturalRelationalFunctionBehaviorExecution
    {
        public UnlimitedNaturalLessThanEqualFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_lessOrEqual);
        }

        public override bool DoUnlimitedNaturalFunction(List<int> arguments)
        {

            int i1 = arguments.ElementAt(0);
            int i2 = arguments.ElementAt(1);

            // This function returns true if i1 <= i2, where a value of -1 means 
            // "unbounded", which is the highest possible value.

            bool result = i1 == i2 || i2 < 0 || i1 >= 0 && i1 < i2;

            Debug.Println("[doBody] Unlimited Natural Less Than or Equal result = " + result);
            return result;
        }

        protected override Value New_()
        {
            return new UnlimitedNaturalLessThanEqualFunctionBehaviorExecution();
        }
    } // UnlimitedNaturalLessThanEqualFunctionBehaviorExecution
}
