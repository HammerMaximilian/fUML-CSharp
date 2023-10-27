using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using fuml.syntax.classification;
using System;

namespace fuml.semantics.simpleclassifiers
{
    public abstract class CompoundValue : StructuredValue
    {
        public List<FeatureValue> featureValues = new();

        public override bool Equals(Value otherValue)
        {
            // Test if this data value is equal to the otherValue.
            // To be equal, the otherValue must also be a compund value with the
            // same types and equal values for each feature.

            bool isEqual = otherValue is CompoundValue;

            if (isEqual)
            {
                CompoundValue otherCompoundValue = (CompoundValue)otherValue;

                isEqual = base.Equals(otherValue)
                        & otherCompoundValue.featureValues.Count == featureValues
                                .Count;

                int i = 1;
                while (isEqual & i <= featureValues.Count)
                {
                    FeatureValue thisFeatureValue = featureValues
                    .ElementAt(i - 1);

                    bool matched = false;
                    int j = 1;
                    while (!matched & j <= otherCompoundValue.featureValues.Count)
                    {
                        FeatureValue otherFeatureValue = otherCompoundValue.featureValues
                                .ElementAt(j - 1);
                        if (thisFeatureValue.feature == otherFeatureValue.feature)
                        {
                            matched = thisFeatureValue
                                    .hasEqualValues(otherFeatureValue);
                        }
                        j = j + 1;
                    }

                    isEqual = matched;
                    i = i + 1;
                }
            }

            return isEqual;
        } // equals

        public override Value Copy()
        {
            // Create a new data value with the same featureValues as this data
            // value.

            CompoundValue newValue = (CompoundValue)base.Copy();

            List<FeatureValue> featureValues = this.featureValues;
            foreach (FeatureValue featureValue in featureValues)
            {
                newValue.featureValues.Add(featureValue.copy());
            }

            return newValue;
        } // copy

        public override FeatureValue getFeatureValue(
                StructuralFeature feature)
        {
            // Get the value(s) of the member of featureValues for the given
            // feature.

            FeatureValue? featureValue = null;
            int i = 1;
            while (featureValue is null & i <= featureValues.Count)
            {
                if (featureValues.ElementAt(i - 1).feature == feature)
                {
                    featureValue = featureValues.ElementAt(i - 1);
                }
                i = i + 1;
            }

            return featureValue!;
        } // getFeatureValue

        public override void setFeatureValue(
                StructuralFeature feature,
                List<Value> values, int position)
        {
            // Set the value(s) of the member of featureValues for the given
            // feature.

            FeatureValue featureValue = getFeatureValue(feature);

            if (featureValue == null)
            {
                featureValue = new FeatureValue();
                featureValues.Add(featureValue);
            }

            featureValue.feature = feature;
            featureValue.values = values;
            featureValue.position = position;

        } // setFeatureValue

        public override List<FeatureValue> getFeatureValues()
        {
            // Return the feature values for this compound value.

            return featureValues;

        } // getFeatureValues

        public override string ToString()
        {
            string buffer = "(";

            List<Classifier> types = GetTypes();

            int i = 1;
            while (i <= types.Count)
            {
                if (i != 1)
                {
                    buffer = buffer + " ";
                }
                buffer = buffer + types.ElementAt(i - 1).name;
                i = i + 1;
            }

            int k = 1;
            while (k <= featureValues.Count)
            {
                FeatureValue featureValue = featureValues.ElementAt(k - 1);
                buffer = buffer + "\n\t\t" + featureValue?.feature?.name + "["
                        + featureValue?.position + "]  =";

                int j = 1;
                while (j <= featureValue?.values!.Count)
                {
                    Value value = featureValue.values.ElementAt(j - 1);
                    if (value is Reference) {
                        Object_ object_ = ((Reference)value)?.referent!;
                        buffer = buffer + " Reference to " + object_.identifier + "(";
                        types = object_.GetTypes();
                        int n = 1;
                        while (n <= types.Count)
                        {
                            if (n != 1)
                            {
                                buffer = buffer + " ";
                            }
                            buffer = buffer + types.ElementAt(n - 1).name;
                            n = n + 1;
                        }
                        buffer = buffer + ")";
                    } else
                    {
                        buffer = buffer + " " + value.ToString();
                    }
                    j = j + 1;
                }

                k = k + 1;
            }

            return buffer + ")";
        } // toString
    } // CompoundValue
}
