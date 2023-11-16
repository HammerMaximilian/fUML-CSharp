using fuml.semantics.actions;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;
using uml.classification;

namespace pscs.semantics.structuredclassifiers
{
    public class CS_NameBased_StructuralFeatureOfInterfaceAccessStrategy : CS_StructuralFeatureOfInterfaceAccessStrategy
    {
        public override FeatureValue Read(CS_Object cs_Object, StructuralFeature feature)
        {
            // returns the a copy of the first feature value of cs_Object where the name of
            // the corresponding feature
            // matches the name of the feature given as a parameter
            // Otherwise, returns an empty feature value
            List<FeatureValue> featureValues = cs_Object.GetFeatureValues();
            FeatureValue? matchingFeatureValue = null;
            for (int i = 0; i < featureValues.Count && matchingFeatureValue is null; i++)
            {
                FeatureValue featureValue = featureValues.ElementAt(i);
                if (featureValue.feature!.name.Equals(feature.name))
                {
                    matchingFeatureValue = featureValue;
                }
            }
            if (matchingFeatureValue is not null)
            {
                matchingFeatureValue = matchingFeatureValue.Copy();
                matchingFeatureValue.feature = feature;
            }
            else
            {
                matchingFeatureValue = new();
                matchingFeatureValue.feature = feature; ;
                matchingFeatureValue.values = new();
                matchingFeatureValue.position = 0;
            }
            return matchingFeatureValue;
        }

        public override void Write(CS_Object cs_Object, StructuralFeature feature, List<Value> values, int position) 
        {
            // Retrieves the first feature value of cs_Object where the name of the
            // corresponding feature
            // matches the name of the feature given as a parameter
            // Then updates the values for this feature value
            List<FeatureValue> featureValues = cs_Object.GetFeatureValues();
            FeatureValue? matchingFeatureValue = null;
            for (int i = 0; i < featureValues.Count && matchingFeatureValue is null; i++)
            {
                FeatureValue featureValue = featureValues.ElementAt(i);
                if (featureValue.feature!.name.Equals(feature.name))
                {
                    matchingFeatureValue = featureValue;
                }
            }
            if (matchingFeatureValue is not null)
            {
                cs_Object.SetFeatureValue(matchingFeatureValue.feature!, values, position);
            }
        }
    } // CS_NameBased_StructuralFeatureOfInterfaceAccessStrategy
}
