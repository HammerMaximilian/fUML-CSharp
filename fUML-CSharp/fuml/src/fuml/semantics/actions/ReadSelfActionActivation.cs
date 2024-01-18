using fuml.semantics.structuredclassifiers;
using uml.actions;

namespace fuml.semantics.actions
{
    public class ReadSelfActionActivation : ActionActivation
    {
		public override void DoAction()
		{
			// Get the context object of the activity execution containing this
			// action activation and place a reference to it on the result output
			// pin.

			// Debug.println("[ReadSelfActionActivation] Start...");

			Reference context = new();
			context.referent = GetExecutionContext();

			// Debug.println("[ReadSelfActionActivation] context object = " +
			// context.referent);

			OutputPin resultPin = (node as ReadSelfAction)?.result!;
			PutToken(resultPin, context);
		} // doAction
	} // ReadSelfActionActivation
}
