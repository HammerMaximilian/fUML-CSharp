using fuml.semantics.simpleclassifiers;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using uml.classification;

namespace pscs.semantics.structuredclassifiers
{
    public class CS_Link : Link
    {
        public bool HasValueForAFeature(Value value)
        {
            // Returns true if the given value object is used as a value for a FeatureValue
            // of this link
            return GetFeature(value) is not null;
        }

        public StructuralFeature GetFeature(Value value)
        {
            List<FeatureValue> allFeatureValues = GetFeatureValues();
            int i = 1;
            StructuralFeature? feature = null;
            while (i <= allFeatureValues.Count && feature == null)
            {
                FeatureValue featureValue = allFeatureValues.ElementAt(i - 1);
                if (featureValue.values.Any() && featureValue.values.ElementAt(0).Equals(value))
                {
                    feature = featureValue.feature!;
                }
                i++;
            }
            return feature!;
        }
    } // CS_Link
}
