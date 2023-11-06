using fuml.semantics.simpleclassifiers;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using fuml.syntax.actions;
using fuml.syntax.classification;
using fuml.syntax.structuredclassifiers;

namespace fuml.semantics.actions
{
    public abstract class LinkActionActivation : ActionActivation
    {
		public bool LinkMatchesEndData(Link link,
		List<LinkEndData> endDataList)
		{
			// Test whether the given link matches the given end data.

			bool matches = true;
			int i = 1;
			while (matches & i <= endDataList.Count)
			{
				matches = EndMatchesEndData(link, endDataList.ElementAt(i - 1));
				i++;
			}

			return matches;
		} // linkMatchesEndData

		public bool EndMatchesEndData(Link link,
                LinkEndData endData)
		{
            // Test whether the appropriate end of the given link matches the given
            // end data.

            bool matches;
            if (endData.value == null)
			{
				matches = true;
			}
			else
			{
				Property? end = endData.end;
				FeatureValue linkFeatureValue = link.GetFeatureValue(end!);
				Value endValue = GetTokens(endData.value).ElementAt(0);
				if (endData is LinkEndDestructionData linkEndDestructionData) {
					if (!linkEndDestructionData.isDestroyDuplicates
							& !end!.multiplicityElement.isUnique
							& end.multiplicityElement.isOrdered)
					{
						int destroyAt = ((UnlimitedNaturalValue)(
								GetTokens((endData as LinkEndDestructionData)?.destroyAt!)?
								.ElementAt(0)!)).value.naturalValue;
						matches = linkFeatureValue.values.ElementAt(0).Equals(
								endValue)
								&& linkFeatureValue.position == destroyAt;
					}
					else
					{
						matches = linkFeatureValue.values.ElementAt(0).Equals(
								endValue);
					}
				} else
				{
					matches = linkFeatureValue.values.ElementAt(0).Equals(endValue);
				}
			}

			return matches;
		} // endMatchesEndData

		public Association GetAssociation()
		{
			// Get the association for the link action of this activation.

			return (node as LinkAction)?.endData?.ElementAt(0)?.end?.association!;
		} // getAssociation
	} // LinkActionActivation
}
