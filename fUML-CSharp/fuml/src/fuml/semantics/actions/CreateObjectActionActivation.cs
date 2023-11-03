using fuml.semantics.structuredclassifiers;
using fuml.syntax.actions;
using fuml.syntax.structuredclassifiers;

namespace fuml.semantics.actions
{
    public class CreateObjectActionActivation : ActionActivation
    {
		public override void DoAction()
		{
			// Create an object with the given classifier (which must be a class) as
			// its type, at the same locus as the action activation.
			// Place a reference to the object on the result pin of the action.

			CreateObjectAction? action = node as CreateObjectAction;

			Reference reference = new Reference();
			reference.referent = GetExecutionLocus().Instantiate(
					(Class_)(action?.classifier!));

			PutToken(action?.result!, reference);

		} // doAction
	} // CreateObjectActionActivation
}
