using fuml.semantics.values;

namespace fuml.library.unlimitednaturalfunctions
{
    public class UnlimitedNaturalMinFunctionBehaviorExecution : UnlimitedNaturalFunctionBehaviorExecution
    {
        public UnlimitedNaturalMinFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_UnlimitedNaturalFunctions_Min);
        }

        public override int DoUnlimitedNaturalFunction(List<int> arguments)
        {

            int i1 = arguments.ElementAt(0);
            int i2 = arguments.ElementAt(1);

            // This returns true if min(i1,i2), where a value of -1 means 
            // "unbounded", which is the highest possible value.

            int result = i1 < 0 ? i2 : i2 < 0 ? i1 : i1 <= i2 ? i1 : i2;

            Debug.Println("[doBody] Unlimited Natural Max result = " + result);
            return result;
        }

        protected override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.
            return new UnlimitedNaturalMinFunctionBehaviorExecution();
        }
    } // UnlimitedNaturalMinFunctionBehaviorExecution
}
