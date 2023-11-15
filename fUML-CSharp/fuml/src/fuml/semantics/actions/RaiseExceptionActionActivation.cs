using fuml.semantics.values;
using uml.actions;

namespace fuml.semantics.actions
{
    public class RaiseExceptionActionActivation : ActionActivation
    {
		public override void DoAction()
		{
			// Get the value on the exception pin and propagate it as an exception.

			RaiseExceptionAction action = (node as RaiseExceptionAction)!;
			if (action is null) throw new InvalidCastException();
			Value exception = TakeTokens(action.exception!).ElementAt(0);

			Debug.Println("[doAction] action = " + action.name + ", exception = " + exception);

			PropagateException(exception);
		}
	} // RaiseExceptionActionActivation
}
