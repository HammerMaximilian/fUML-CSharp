using fuml.syntax.classification;

namespace fuml.syntax.actions
{
    public class CallOperationAction : CallAction
    {
		public Operation? operation = null;
		public InputPin? target = null;

		public void setTarget(InputPin target)
		{
			addInput(target);
			this.target = target;
		} // setTarget

		public void setOperation(Operation operation)
		{
			this.operation = operation ?? throw new ArgumentNullException(nameof(operation));
		} // setOperation
	} // CallOperationAction
}
