using fuml.semantics.loci;
using fuml.semantics.structuredclassifiers;
using fuml.syntax.actions;
using fuml.syntax.classification;

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

			Debug.println("[doAction] DestroyLinkAction...");

			DestroyLinkAction? action = node as DestroyLinkAction;
			List<LinkEndDestructionData> destructionDataList = action?.endData!;

			Debug.println("[doAction] end data size = " + destructionDataList.Count);

			bool destroyOnlyOne = false;
			int j = 1;
			while (!destroyOnlyOne & j <= destructionDataList.Count)
			{
				LinkEndDestructionData endData = destructionDataList
						.ElementAt(j - 1);
				destroyOnlyOne = !endData.end!.multiplicityElement.isUnique
						& !endData.end.multiplicityElement.isOrdered
						& !endData.isDestroyDuplicates;
				j = j + 1;
			}

			List<LinkEndData> endDataList = new List<LinkEndData>();
			foreach (LinkEndDestructionData endData in destructionDataList)
			{
				Debug.println("[doAction] Matching end = " + endData.end?.name);
				endDataList.Add(endData);
			}

			List<ExtensionalValue> extent = this.GetExecutionLocus().GetExtent(
					this.GetAssociation());
			List<ExtensionalValue> matchingLinks = new List<ExtensionalValue>();

			foreach (ExtensionalValue value in extent)
			{
				Link link = (Link)value;
				if (this.LinkMatchesEndData(link, endDataList))
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
					this.TakeTokens(endData?.destroyAt!);
				}
				Debug.println("[doAction] Consuming tokens for end " + end.name);
				this.TakeTokens(endData?.value!);
			}

			if (destroyOnlyOne)
			{
				// *** If there is more than one matching link,
				// non-deterministically choose one. ***
				if (matchingLinks.Count > 0)
				{
					int i = ((ChoiceStrategy)this.GetExecutionLocus()?.factory?
							.GetStrategy("choice")!).choose(matchingLinks.Count);
					matchingLinks.ElementAt(i - 1).destroy();
				}
			}
			else
			{
				foreach (ExtensionalValue matchingLink in matchingLinks)
				{
					matchingLink.destroy();
				}
			}
		} // doAction
	} // DestroyLinkActionActivation
}
