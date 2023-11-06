using fuml.semantics.loci;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;
using fuml.syntax.classification;
using fuml.syntax.structuredclassifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuml.semantics.structuredclassifiers
{
    public class Link : ExtensionalValue
    {
		public Association? type = null;

		public override void Destroy()
		{
			// Remove the type of this link and destroy it.
			// Shift the positions of the feature values of any remaining links in
			// the extent of the same association, for ends that are ordered.

			Debug.Println("[destroy] link = " + identifier);

            List<Property> ends = (type is not null) ? type.memberEnd : new();
			List<ExtensionalValue> extent = locus!.GetExtent(type!);

			foreach (ExtensionalValue otherLink in extent)
			{
				foreach (Property end in ends)
				{
					if (end.multiplicityElement.isOrdered)
					{
						FeatureValue featureValue = otherLink.GetFeatureValue(end);
						if (GetFeatureValue(end).position < featureValue.position)
						{
							featureValue.position--;
						}
					}
				}
			}

			type = null;
			base.Destroy();
		} // destroy

		public override Value Copy()
		{
			// Create a new link with the same type, locus and feature values as
			// this link.

			Link newValue = (Link)base.Copy();

			newValue.type = type;

			return newValue;
		} // copy

		protected override Value New_()
		{
			// Create a new link with no type or properies.

			return new Link();
		} // new_

		public override List<Classifier> GetTypes()
		{
			// Return the single type of this link (if any).

			List<Classifier> types = new();

			if (type is not null)
			{
				types.Add(type);
			}

			return types;

		} // getTypes

		public bool IsMatchingLink(
				fuml.semantics.structuredclassifiers.ExtensionalValue link,
				fuml.syntax.classification.Property end)
		{
			// Test whether the given link matches the values of this link on all
			// ends other than the given end.

			List<Property> ends = type!.memberEnd;

			bool matches = true;
			int i = 1;
			while (matches & i <= ends.Count)
			{
				Property otherEnd = ends.ElementAt(i - 1);
				if (otherEnd != end
						& !GetFeatureValue(otherEnd).values.ElementAt(0)
								.Equals(
										link.GetFeatureValue(otherEnd).values
												.ElementAt(0)))
				{
					matches = false;
				}
				i++;
			}

			return matches;
		} // isMatchingLink

		public List<FeatureValue> GetOtherFeatureValues(
				List<ExtensionalValue> extent,
				Property end)
		{
			// Return all feature values for the given end of links in the given
			// extent whose other ends match this link.

			List<FeatureValue> featureValues = new();
			foreach (ExtensionalValue link in extent)
			{
				if (link != this)
				{
					if (IsMatchingLink(link, end))
					{
						featureValues.Add(link.GetFeatureValue(end));
					}
				}
			}
			return featureValues;
		} // getOtherFeatureValues

		public void AddTo(Locus locus)
		{
			// Add this link to the extent of its association at the given locus.
			// Shift the positions of ends of other links, as appropriate, for ends
			// that are ordered.

			Debug.Println("[addTo] link = " + identifier);

			List<Property> ends = (type is not null) ? type.memberEnd : new();
			List<ExtensionalValue> extent = locus.GetExtent(type!);

			foreach (Property end in ends)
			{
				if (end.multiplicityElement.isOrdered)
				{
					FeatureValue featureValue = GetFeatureValue(end);
					List<FeatureValue> otherFeatureValues = 
							GetOtherFeatureValues(extent, end);
					int n = otherFeatureValues.Count;
					if (featureValue.position < 0 | featureValue.position > n)
					{
						featureValue.position = n + 1;
					}
					else
					{
						if (featureValue.position == 0)
						{
							featureValue.position = 1;
						}
						foreach (FeatureValue otherFeatureValue in otherFeatureValues)
						{
							if (featureValue.position <= otherFeatureValue.position)
							{
								otherFeatureValue.position++;
							}
						}
					}
				}
			}

			locus.Add(this);
		} // addTo
	} // Link
}
