using fuml.semantics.simpleclassifiers;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using fuml.syntax.actions;
using fuml.syntax.classification;
using fuml.syntax.structuredclassifiers;

namespace fuml.semantics.actions
{
    public class ClearStructuralFeatureActionActivation : StructuralFeatureActionActivation
    {
		public override void DoAction()
		{
			// Get the value of the object input pin.
			// If the given feature is an association end, then
			// destroy all links that have the object input on the opposite end.
			// Otherwise, if the object input is a structured value, then
			// set the appropriate feature of the input value to be empty.

			ClearStructuralFeatureAction? action = node as ClearStructuralFeatureAction;
			StructuralFeature feature = action?.structuralFeature!;
			Association association = GetAssociation(feature);

			Value value = TakeTokens(action?.object_!)?.ElementAt(0)!;

			if (association is not null)
			{
				List<Link> links = GetMatchingLinks(association, feature, value);
				foreach (Link link in links)
				{
					link.Destroy();
				}
			}
			else if (value is StructuredValue structuredValue) {
				// If the value is a data value, then it must be copied before
				// any change is made.
				if (value is not Reference) {
					value = value.Copy();
				}

			  structuredValue.SetFeatureValue(action?.structuralFeature!,
					  new List<Value>(), 0);
			}

			if (action?.result is not null)
			{
				PutToken(action.result, value);
			}
		} // doAction
	} // ClearStructuralFeatureActionActivation
}
