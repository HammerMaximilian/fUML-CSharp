using fuml.semantics.values;

namespace fuml.library.booleanfunctions
{
    public class BooleanOrFunctionBehaviorExecution : BooleanFunctionBehaviorExecution
    {
        public BooleanOrFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Or);
        }

        public override bool DoBooleanFunction(List<bool> arguments)
        {
            bool result = arguments.ElementAt(0) || arguments.ElementAt(1);
            Debug.Println("[doBody] Boolean Or result = " + result);
            return result;
        }

        public override Value New_()
        {
            return new BooleanOrFunctionBehaviorExecution();
        }
    } // BooleanOrFunctionBehaviorExecution
}
