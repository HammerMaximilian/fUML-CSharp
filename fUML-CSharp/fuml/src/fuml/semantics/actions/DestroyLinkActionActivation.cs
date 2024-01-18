using fuml.semantics.loci;
using fuml.semantics.structuredclassifiers;
using uml.actions;
using uml.classification;

namespace fuml.semantics.actions
{
    public class DestroyLinkActionActivation : WriteLinkActionActivation
    {
		public override void DoAction()
		{
			// Get the extent, at the current execution locus, of the association
			// for which links are being destroyed.
			// Destroy all links that match the given link end destruction data.
			// For unique ends, or non-unique ends for which isDestroyDuplicates is
			// true, match links with a matching value for that end.
			// For non-unique, ordered ends for which isDestroyDuplicates is false,
			// match links with an end value at the given destroyAt position. [Must
			// a value be given, too, in this case?]
			// For non-unique, non-ordered ends for which isDestroyDuplicates is
			// false, pick one matching link (if any) non-deterministically. [The
			// semantics of this case is not clear from the current spec.]

			Debug.Println("[doAction] DestroyLinkAction...");

			DestroyLinkAction? action = node as DestroyLinkAction;
			List<LinkEndDestructionData> destructionDataList = action?.endData!;

			Debug.Println("[doAction] end data size = " + destructionDataList.Count);

			bool destroyOnlyOne = false;
			int j = 1;
			while (!destroyOnlyOne & j <= destructionDataList.Count)
			{
				LinkEndDestructionData endData = destructionDataList
						.ElementAt(j - 1);
				destroyOnlyOne = !endData.end!.multiplicityElement.isUnique
						& !endData.end.multiplicityElement.isOrdered
						& !endData.isDestroyDuplicates;
				j++;
			}

			List<LinkEndData> endDataList = new();
			foreach (LinkEndDestructionData endData in destructionDataList)
			{
				Debug.Println("[doAction] Matching end = " + endData.end?.name);
				endDataList.Add(endData);
			}

			List<ExtensionalValue> extent = GetExecutionLocus().GetExtent(
					GetAssociation());
			List<ExtensionalValue> matchingLinks = new();

			foreach (ExtensionalValue value in extent)
			{
				Link link = (Link)value;
				if (LinkMatchesEndData(link, endDataList))
				{
					matchingLinks.Add(link);
				}
			}

			// Now that matching is done, ensure that all tokens on end data input
			// pins
			// are consumed.
			foreach (LinkEndDestructionData endData in destructionDataList)
			{
				Property end = endData?.end!;
				if (!endData!.isDestroyDuplicates
						& !end.multiplicityElement.isUnique
						& end.multiplicityElement.isOrdered)
				{
					TakeTokens(endData?.destroyAt!);
				}
				Debug.Println("[doAction] Consuming tokens for end " + end.name);
				TakeTokens(endData?.value!);
			}

			if (destroyOnlyOne)
			{
				// *** If there is more than one matching link,
				// non-deterministically choose one. ***
				if (matchingLinks.Count > 0)
				{
					int i = ((ChoiceStrategy)GetExecutionLocus()?.factory?
							.GetStrategy("choice")!).Choose(matchingLinks.Count);
					matchingLinks.ElementAt(i - 1).Destroy();
				}
			}
			else
			{
				foreach (ExtensionalValue matchingLink in matchingLinks)
				{
					matchingLink.Destroy();
				}
			}
		} // doAction
	} // DestroyLinkActionActivation
}
