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

		public override void destroy()
		{
			// Remove the type of this link and destroy it.
			// Shift the positions of the feature values of any remaining links in
			// the extent of the same association, for ends that are ordered.

			Debug.println("[destroy] link = " + identifier);

            List<Property> ends = (type is not null) ? type.memberEnd : new();
			List<ExtensionalValue> extent = locus.getExtent(type);

			foreach (ExtensionalValue otherLink in extent)
			{
				foreach (Property end in ends)
				{
					if (end.multiplicityElement.isOrdered)
					{
						FeatureValue featureValue = otherLink.getFeatureValue(end);
						if (getFeatureValue(end).position < featureValue.position)
						{
							featureValue.position = featureValue.position - 1;
						}
					}
				}
			}

			type = null;
			base.destroy();
		} // destroy

		public override Value copy()
		{
			// Create a new link with the same type, locus and feature values as
			// this link.

			Link newValue = (Link)base.copy();

			newValue.type = type;

			return newValue;
		} // copy

		protected override Value new_()
		{
			// Create a new link with no type or properies.

			return new Link();
		} // new_

		public override List<Classifier> getTypes()
		{
			// Return the single type of this link (if any).

			List<Classifier> types = new();

			if (type is not null)
			{
				types.Add(type);
			}

			return types;

		} // getTypes

		public bool isMatchingLink(
				fuml.semantics.structuredclassifiers.ExtensionalValue link,
				fuml.syntax.classification.Property end)
		{
			// Test whether the given link matches the values of this link on all
			// ends other than the given end.

			List<Property> ends = type.memberEnd;

			bool matches = true;
			int i = 1;
			while (matches & i <= ends.Count())
			{
				Property otherEnd = ends.ElementAt(i - 1);
				if (otherEnd != end
						& !getFeatureValue(otherEnd).values.ElementAt(0)
								.equals(
										link.getFeatureValue(otherEnd).values
												.ElementAt(0)))
				{
					matches = false;
				}
				i = i + 1;
			}

			return matches;
		} // isMatchingLink

		public List<FeatureValue> getOtherFeatureValues(
				List<ExtensionalValue> extent,
				Property end)
		{
			// Return all feature values for the given end of links in the given
			// extent whose other ends match this link.

			List<FeatureValue> featureValues = new List<FeatureValue>();
			foreach (ExtensionalValue link in extent)
			{
				if (link != this)
				{
					if (isMatchingLink(link, end))
					{
						featureValues.Add(link.getFeatureValue(end));
					}
				}
			}
			return featureValues;
		} // getOtherFeatureValues

		public void addTo(Locus locus)
		{
			// Add this link to the extent of its association at the given locus.
			// Shift the positions of ends of other links, as appropriate, for ends
			// that are ordered.

			Debug.println("[addTo] link = " + identifier);

			List<Property> ends = (type is not null) ? type.memberEnd : new();
			List<ExtensionalValue> extent = locus.getExtent(type);

			foreach (Property end in ends)
			{
				if (end.multiplicityElement.isOrdered)
				{
					FeatureValue featureValue = getFeatureValue(end);
					List<FeatureValue> otherFeatureValues = this
							.getOtherFeatureValues(extent, end);
					int n = otherFeatureValues.Count();
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
								otherFeatureValue.position = otherFeatureValue.position + 1;
							}
						}
					}
				}
			}

			locus.add(this);
		} // addTo
	} // Link
}
