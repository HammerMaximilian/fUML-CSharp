using uml.classification;

namespace uml.actions
{
    public class CallOperationAction : CallAction
    {
		public Operation? operation = null;
		public InputPin? target = null;

		public void SetTarget(InputPin target)
		{
			AddInput(target);
			this.target = target;
		} // setTarget

		public void SetOperation(Operation operation)
		{
			this.operation = operation ?? throw new ArgumentNullException(nameof(operation));
		} // setOperation
	} // CallOperationAction
}
