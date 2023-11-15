using fuml.semantics.values;

namespace fuml.library.booleanfunctions
{
    public class BooleanXorFunctionBehaviorExecution : BooleanFunctionBehaviorExecution
    {
        public BooleanXorFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Xor);
        }

        public override bool DoBooleanFunction(List<bool> arguments)
        {
            bool result = arguments.ElementAt(0) ^ arguments.ElementAt(1);
            Debug.Println("[doBody] Boolean Xor result = " + result);
            return result;
        }

        protected override Value New_()
        {
            return new BooleanXorFunctionBehaviorExecution();
        }
    } // BooleanXorFunctionBehaviorExecution
}
