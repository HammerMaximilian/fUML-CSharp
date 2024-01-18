using fuml.semantics.commonbehavior;
using fuml.semantics.structuredclassifiers;
using uml.actions;
using uml.classification;
using uml.commonbehavior;

namespace fuml.semantics.actions
{
    public class CallBehaviorActionActivation : CallActionActivation
    {
		public override Execution GetCallExecution()
		{
			// Create and execution for the given behavior at the current locus and
			// return the resulting execution object.
			// If the given behavior is in the context of a classifier, then pass
			// the current context object as the context for the call.
			// Otherwise, use a null context.
			// [Note that this requires the behavior context to be compatible with
			// the type of the current contect object.]

			Behavior behavior = (node as CallBehaviorAction)?.behavior!;

			Object_? context;
			if (behavior.context is null)
			{
				context = null;
			}
			else
			{
				context = GetExecutionContext();
			}

			return GetExecutionLocus()?.factory?.CreateExecution(behavior,
					context!)!;

		} // getCallExecution

		public override List<Parameter> GetParameters()
		{
			// Get the owned parameters of the behavior of the call behavior
			// action for this call behavior action activation.

			Behavior behavior = (node as CallBehaviorAction)?.behavior!;

			return (behavior is not null) ? behavior.ownedParameter : new List<Parameter>();
		}
	} // CallBehaviorActionActivation
}
