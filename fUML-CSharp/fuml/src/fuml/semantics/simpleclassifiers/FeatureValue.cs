using fuml.semantics.values;
using fuml.syntax.classification;
using System;

namespace fuml.semantics.simpleclassifiers
{
    public class FeatureValue
    {
        public StructuralFeature? feature = null;
        public List<Value> values = new();
        public int position = 0;

        public bool hasEqualValues(
                FeatureValue other)
        {
            // Determine if this feature value has an equal set of values as another
            // feature value.
            // If the feature is ordered, then the values also have to be in the
            // same order.

            bool equal = true;

            if (values.Count != other.values.Count)
            {
                equal = false;

            }
            else
            {
                if ((feature is not null) ? feature!.multiplicityElement.isOrdered : false)
                {
                    int i = 1;
                    while (equal & i <= values.Count)
                    {
                        equal = values.ElementAt(i - 1).equals(
                                other.values.ElementAt(i - 1));
                        i = i + 1;
                    }

                }
                else
                {
                    // Note: otherFeatureValues is used here solely as a holder for
                    // a copy of the list of other values,
                    // since the Java to UML mapping conventions do not allow
                    // "remove" on a local list variable.
                    FeatureValue otherFeatureValues = new FeatureValue();
                    List<Value> values = other.values;
                    foreach (Value value in values)
                    {
                        otherFeatureValues.values.Add(value);
                    }

                    int i = 1;
                    while (equal & i <= this.values.Count)
                    {
                        bool matched = false;
                        int j = 1;
                        while (!matched & j <= otherFeatureValues.values.Count)
                        {
                            if (this.values.ElementAt(i - 1).equals(
                                    otherFeatureValues.values.ElementAt(j - 1)))
                            {
                                matched = true;
                                otherFeatureValues.values.RemoveAt(j - 1);
                            }
                            j = j + 1;
                        }

                        equal = matched;
                        i = i + 1;
                    }
                }
            }

            return equal;
        } // hasEqualValues

        public FeatureValue copy()
        {
            // Create a copy of this feature value.

            FeatureValue newValue = new FeatureValue();

            newValue.feature = feature;
            newValue.position = position;

            List<Value> values = this.values;
            foreach (Value value in values)
            {
                newValue.values.Add(value.copy());
            }

            return newValue;
        } // copy
    } // FeatureValue
}
