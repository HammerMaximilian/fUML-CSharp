using fuml.semantics.actions;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.structuredclassifiers;
using pscs.semantics.structuredclassifiers;
using uml.actions;
using uml.structuredclassifiers;

namespace pscs.semantics.actions
{
    public class CS_CreateLinkActionActivation : CreateLinkActionActivation
    {
        public override void DoAction()
        {
            // Get the extent at the current execution locus of the association for
            // which a link is being created.
            // Destroy all links that have a value for any end for which
            // isReplaceAll is true.
            // Create a new link for the association, at the current locus, with the
            // given end data values,
            // inserted at the given insertAt position (for ordered ends).
            // fUML semantics is extended in the sense that a CS_Link is created instead of
            // a Link
            CreateLinkAction action = (CreateLinkAction)node! ?? throw new InvalidCastException();
            List<LinkEndCreationData> endDataList = new();
            foreach (LinkEndData data in action.endData)
            {
                endDataList.Add((LinkEndCreationData)data);
            }
            Association linkAssociation = GetAssociation();
            List<ExtensionalValue> extent = GetExecutionLocus().GetExtent(linkAssociation);
            bool unique = false;
            foreach (LinkEndCreationData endData in endDataList)
            {
                if (endData.end?.multiplicityElement.isUnique ?? false)
                {
                    unique = true;
                }
            }
            foreach (ExtensionalValue value in extent)
            {
                Link link = (Link)value;
                bool match = true;
                bool destroy = false;
                int j = 1;
                while (j <= endDataList.Count)
                {
                    LinkEndCreationData endData = endDataList.ElementAt(j - 1);
                    if (EndMatchesEndData(link, endData))
                    {
                        if (endData.isReplaceAll)
                        {
                            destroy = true;
                        }
                    }
                    else
                    {
                        match = false;
                    }
                    j++;
                }
                if (destroy || (unique && match))
                {
                    link.Destroy();
                }
            }
            CS_Link newLink = new()
            {
                type = linkAssociation
            };
            foreach (LinkEndCreationData endData in endDataList)
            {
                int insertAt = 0;
                if (endData.insertAt is not null)
                {
                    insertAt = ((UnlimitedNaturalValue)TakeTokens(endData.insertAt).ElementAt(0)).value.naturalValue;
                }
                newLink.SetFeatureValue(endData.end ?? throw new ArgumentNullException(), TakeTokens(endData.value ?? throw new ArgumentNullException()), insertAt);
            }
            newLink.AddTo(GetExecutionLocus());
        }
    } // CS_CreateLinkActionActivation
}
