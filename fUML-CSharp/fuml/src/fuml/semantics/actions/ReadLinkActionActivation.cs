using fuml.semantics.simpleclassifiers;
using fuml.semantics.structuredclassifiers;
using fuml.syntax.actions;

namespace fuml.semantics.actions
{
    public class ReadLinkActionActivation : LinkActionActivation
    {
		public override void DoAction()
		{
			// Get the extent, at the current execution locus, of the association to
			// which the action applies.
			// For all links that match the link end data, place the value of the
			// remaining "open" end on the result pin.

			ReadLinkAction? action = node as ReadLinkAction;
			List<LinkEndData> endDataList = (action is not null) ? action.endData : new List<LinkEndData>();
			LinkEndData? openEnd = null;

			int i = 1;
			while ((openEnd == null) & i <= endDataList.Count)
			{
				if (endDataList.ElementAt(i - 1).value is null)
				{
					openEnd = endDataList.ElementAt(i - 1);
				}
				i++;
			}

			List<ExtensionalValue> extent = GetExecutionLocus().GetExtent(
					GetAssociation());

			List<FeatureValue> featureValues = new();
			foreach (ExtensionalValue value in extent)
			{
				Link link = (Link)value;
				if (LinkMatchesEndData(link, endDataList))
				{
					FeatureValue featureValue = link.GetFeatureValue(openEnd?.end!);
					if (!openEnd!.end!.multiplicityElement.isOrdered
							|| (featureValues.Count == 0))
					{
						featureValues.Add(featureValue);
					}
					else
					{
						int n = featureValue.position;
						bool continueSearching = true;
						int k = 0;
						while (continueSearching & k < featureValues.Count)
						{
							k++;
							continueSearching = featureValues.ElementAt(k - 1).position < n;
						}
						if (continueSearching)
						{
							featureValues.Add(featureValue);
						}
						else
						{
							featureValues.Insert(k - 1, featureValue);
						}
					}
				}
			}

			foreach (FeatureValue featureValue in featureValues)
			{
				PutToken(action?.result!, featureValue.values.ElementAt(0));
			}

			// Now that matching is done, ensure that all tokens on end data input
			// pins
			// are consumed.
			foreach (LinkEndData endData in endDataList)
			{
				if (endData.value is not null)
				{
					TakeTokens(endData.value);
				}
			}

		} // doAction
	} // ReadLinkActionActivation
}
