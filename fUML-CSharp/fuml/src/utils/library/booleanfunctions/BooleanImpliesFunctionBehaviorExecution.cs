using fuml.semantics.values;

namespace fuml.library.booleanfunctions
{
    public class BooleanImpliesFunctionBehaviorExecution : BooleanFunctionBehaviorExecution
    {
        public BooleanImpliesFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Implies);
        }

        public override bool DoBooleanFunction(List<bool> arguments)
        {
            bool b1 = arguments.ElementAt(0);
            bool b2 = arguments.ElementAt(1);
            bool result = (!b1) || (b1 && b2);
            Debug.Println("[doBody] Boolean Implies result = " + result);
            return result;
        }

        protected override Value New_()
        {
            // Create a new instance of this kind of function behavior execution.
            return new BooleanImpliesFunctionBehaviorExecution();
        }
    } // BooleanImpliesFunctionBehaviorExecution
}
