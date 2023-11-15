using fuml.semantics.commonbehavior;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using uml.actions;
using uml.structuredclassifiers;

namespace fuml.semantics.actions
{
    public class StartClassifierBehaviorActionActivation : ActionActivation
    {
		public override void DoAction()
		{
			// Get the value on the object input pin. If it is not a reference, then
			// do nothing.
			// Start the classifier behavior of the referent object for the
			// classifier given as the type of the object input pin.
			// If the object input pin has no type, then start the classifier
			// behaviors of all types of the referent object. [The required behavior
			// in this case is not clear from the spec.]

			StartClassifierBehaviorAction action = (node as StartClassifierBehaviorAction)!;
			if (action is null) throw new InvalidCastException();

			Value object_ = TakeTokens(action.object_!).ElementAt(0);

			if (object_ is Reference reference) {
				reference.StartBehavior((action.object_?.typedElement.type as Class_)!, new List<ParameterValue>());
			}
		} // doAction
	} // StartClassifierBehaviorActionActivation
}
