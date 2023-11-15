using fuml.semantics.values;
using uml.actions;

namespace fuml.semantics.actions
{
    public class ValueSpecificationActionActivation : ActionActivation
    {
		public override void DoAction()
		{
			// Evaluate the value specification for the action and place the result
			// on the result pin of the action.

			ValueSpecificationAction action = (node as ValueSpecificationAction)!;
			if (action is null) throw new InvalidCastException();

			Value value = GetExecutionLocus().executor?.Evaluate(action.value!)!;
			PutToken(action.result!, value);
		} // doAction
	} // ValueSpecificationActionActivation
}
