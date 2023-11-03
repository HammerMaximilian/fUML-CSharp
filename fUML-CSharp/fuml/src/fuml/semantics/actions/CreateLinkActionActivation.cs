using fuml.semantics.simpleclassifiers;
using fuml.semantics.structuredclassifiers;
using fuml.syntax.actions;
using fuml.syntax.structuredclassifiers;

namespace fuml.semantics.actions
{
    public class CreateLinkActionActivation : WriteLinkActionActivation
    {
		public override void DoAction()
		{
			// If the association has any unique ends, then destroy an existing link
			// that matches all ends of the link being created.
			// Get the extent at the current execution locus of the association for
			// which a link is being created.
			// Destroy all links that have a value for any end for which
			// isReplaceAll is true.
			// Create a new link for the association, at the current locus, with the
			// given end data values,
			// inserted at the given insertAt position (for ordered ends).

			CreateLinkAction? action = node as CreateLinkAction;
			List<LinkEndCreationData> endDataList = (action is not null) ? action.endData : new List<LinkEndCreationData>();

			Association linkAssociation = GetAssociation();
			List<ExtensionalValue> extent = GetExecutionLocus().GetExtent(
					linkAssociation);

			bool unique = false;
			for (int i = 0; i < endDataList.Count; i++)
			{
				if (endDataList.ElementAt(i).end!.multiplicityElement.isUnique)
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
					j = j + 1;
				}
				if (destroy | unique & match)
				{
					link.destroy();
				}
			}

			Link newLink = new();
			newLink.type = linkAssociation;

			foreach (LinkEndCreationData endData in endDataList)
			{
				int insertAt = 0;
				if (endData.insertAt is not null)
				{
					insertAt = ((UnlimitedNaturalValue)
							TakeTokens(endData.insertAt).ElementAt(0)).value.naturalValue;
				}

				newLink.setFeatureValue(endData?.end!,
						this.TakeTokens(endData?.value!), insertAt);
			}

			newLink.AddTo(GetExecutionLocus());
		} // doAction
	} // CreateLinkActionActivation
}
