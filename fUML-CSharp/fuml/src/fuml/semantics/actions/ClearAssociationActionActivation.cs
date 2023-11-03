using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using fuml.syntax.actions;

namespace fuml.semantics.actions
{
    public class ClearAssociationActionActivation : ActionActivation
    {
        public override void DoAction()
        {
            // Get the extent, at the current execution locus, of the given
            // association.
            // Read the object input pin. Destroy all links in which the object
            // participates.

            ClearAssociationAction? action = node as ClearAssociationAction;

            List<ExtensionalValue> extent = this.GetExecutionLocus().GetExtent(
                    action?.association!);
            Value objectValue = this.TakeTokens(action?.object_!)?.ElementAt(0)!;

            for (int i = 0; i < extent.Count; i++)
            {
                Link link = (Link)extent.ElementAt(i);
                if (ValueParticipatesInLink(objectValue, link))
                {
                    link.destroy();
                }
            }
        } // doAction
    } // ClearAssociationActionActivation
}
