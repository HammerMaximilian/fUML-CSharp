using fuml.semantics.structuredclassifiers;
using uml.actions;
using uml.structuredclassifiers;

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

            Reference reference = new()
            {
                referent = GetExecutionLocus().Instantiate((Class_)(action?.classifier!))
            };

            PutToken(action?.result!, reference);

		} // doAction
	} // CreateObjectActionActivation
}
