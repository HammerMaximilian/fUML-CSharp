using fuml.semantics.values;
using fuml.syntax.actions;

namespace fuml.semantics.actions
{
    public class TestIdentityActionActivation : ActionActivation
    {
		public override void DoAction()
		{
			// Get the values from the first and second input pins and test if they
			// are equal. (Note the equality of references is defined to be that
			// they have identical referents.)
			// If they are equal, place true on the pin execution for the result
			// output pin, otherwise place false.

			TestIdentityAction action = (node as TestIdentityAction)!;
			if (action is null) throw new InvalidCastException();

			Value firstValue = TakeTokens(action.first!).ElementAt(0);
			Value secondValue = TakeTokens(action.second!).ElementAt(0);

			Value testResult = MakeBooleanValue(firstValue.Equals(secondValue));
			PutToken(action.result!, testResult);

		} // doAction
	} // TestIdentityActionActivation
}
