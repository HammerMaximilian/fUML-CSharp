using fuml.semantics.values;

namespace fuml.library.booleanfunctions
{
    public class BooleanAndFunctionBehaviorExecution : BooleanFunctionBehaviorExecution
    {
        public BooleanAndFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_And);
        }

        public override bool DoBooleanFunction(List<bool> arguments)
        {
            bool result = arguments.ElementAt(0) && arguments.ElementAt(1);
            Debug.Println("[doBody] Boolean And result = " + result);
            return result;
        }

        public override Value New_()
        {
            return new BooleanAndFunctionBehaviorExecution();
        }
    } // BooleanAndFunctionBehaviorExecution
}
