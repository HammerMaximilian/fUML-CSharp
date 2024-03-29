﻿using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using uml.classification;
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
                                    .HasEqualValues(otherFeatureValue);
                        }
                        j++;
                    }

                    isEqual = matched;
                    i++;
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
                newValue.featureValues.Add(featureValue.Copy());
            }

            return newValue;
        } // copy

        public override FeatureValue GetFeatureValue(
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
                i++;
            }

            return featureValue!;
        } // getFeatureValue

        public override void SetFeatureValue(
                StructuralFeature feature,
                List<Value> values, int position)
        {
            // Set the value(s) of the member of featureValues for the given
            // feature.

            FeatureValue featureValue = GetFeatureValue(feature);

            if (featureValue == null)
            {
                featureValue = new FeatureValue();
                featureValues.Add(featureValue);
            }

            featureValue.feature = feature;
            featureValue.values = values;
            featureValue.position = position;

        } // setFeatureValue

        public override List<FeatureValue> GetFeatureValues()
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
                    buffer += " ";
                }
                buffer += types.ElementAt(i - 1).name;
                i++;
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
                    if (value is Reference reference) {
                        Object_ object_ = reference?.referent!;
                        buffer = buffer + " Reference to " + object_.identifier + "(";
                        types = object_.GetTypes();
                        int n = 1;
                        while (n <= types.Count)
                        {
                            if (n != 1)
                            {
                                buffer += " ";
                            }
                            buffer += types.ElementAt(n - 1).name;
                            n++;
                        }
                        buffer += ")";
                    } else
                    {
                        buffer = buffer + " " + value.ToString();
                    }
                    j++;
                }

                k++;
            }

            return buffer + ")";
        } // toString
    } // CompoundValue
}
