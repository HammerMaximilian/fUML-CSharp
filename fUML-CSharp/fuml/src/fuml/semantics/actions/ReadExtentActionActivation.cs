using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using uml.actions;

namespace fuml.semantics.actions
{
    public class ReadExtentActionActivation : ActionActivation
    {
		public override void DoAction()
		{
			// Get the extent, at the current execution locus, of the classifier
			// (which must be a class) identified in the action.
			// Place references to the resulting set of objects on the result pin.

			ReadExtentAction action = (node as ReadExtentAction)!;
			if (action is null) throw new InvalidCastException();
			List<ExtensionalValue> objects = GetExecutionLocus().GetExtent(action.classifier!);

            List<Value> references = new();
			foreach (Value object_ in objects)
			{
				Reference reference = new();
				reference.referent = object_ as Object_;
				references.Add(reference);
			}

			PutTokens(action.result!, references);
		} // doAction
	} // ReadExtentActionActivation
}
