using fuml.semantics.values;

namespace fuml.library.booleanfunctions
{
    public class BooleanNotFunctionBehaviorExecution : BooleanFunctionBehaviorExecution
    {
        public BooleanNotFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Not);
        }

        public override bool DoBooleanFunction(List<bool> arguments)
        {
            bool result = !arguments.ElementAt(0);
            Debug.Println("[doBody] Boolean Not result = " + result);
            return result;
        }

        public override Value New_()
        {
            return new BooleanNotFunctionBehaviorExecution();
        }
    } // BooleanNotFunctionBehaviorExecution
}
