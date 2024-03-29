﻿using fuml.semantics.loci;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using uml.actions;
using uml.classification;
using uml.structuredclassifiers;

namespace fuml.semantics.actions
{
    public class AddStructuralFeatureValueActionActivation : WriteStructuralFeatureActionActivation
    {
        public override void DoAction()
        {
            // Get the values of the object and value input pins.
            // If the given feature is an association end, then create a link
            // between the object and value inputs.
            // Otherwise, if the object input is a structural value, then add a
            // value to the values for the feature.
            // If isReplaceAll is true, first remove all current matching links or
            // feature values.
            // If isReplaceAll is false and there is an insertAt pin, insert the
            // value at the appropriate position.

            AddStructuralFeatureValueAction action = (node as AddStructuralFeatureValueAction)!;
            StructuralFeature feature = action?.structuralFeature!;
            Association association = GetAssociation(feature);

            Value value = TakeTokens(action?.object_!)?.ElementAt(0)!;
            List<Value> inputValues = TakeTokens(action?.value!);

            // NOTE: Multiplicity of the value input pin is required to be 1..1.
            Value inputValue = inputValues.ElementAt(0);

            int insertAt = 0;
            if (action?.insertAt is not null)
            {
                insertAt = (TakeTokens(action.insertAt)?.ElementAt(0)! as UnlimitedNaturalValue)!.value.naturalValue;
            }

            if (association is not null)
            {
                List<Link> links = GetMatchingLinks(association, feature, value);

                Property oppositeEnd = GetOppositeEnd(association, feature);
                int position = 0;
                if (oppositeEnd.multiplicityElement.isOrdered)
                {
                    position = GetMatchingLinks(association, oppositeEnd,
                            inputValue).Count + 1;
                }

                if (action!.isReplaceAll)
                {
                    foreach (Link link in links)
                    {
                        link.Destroy();
                    }
                }
                else if (feature.multiplicityElement.isUnique)
                {
                    int i = 1;
                    bool destroyed = false;
                    while (!destroyed & i <= links.Count)
                    {
                        Link link = links.ElementAt(i - 1);
                        FeatureValue featureValue = link.GetFeatureValue(feature);
                        if (featureValue.values.ElementAt(0).Equals(inputValue))
                        {
                            position = link.GetFeatureValue(oppositeEnd).position;
                            link.Destroy();
                            destroyed = true;
                        }
                        i++;
                    }
                }

                Link newLink = new()
                {
                    type = association
                };

                newLink.SetFeatureValue(feature, inputValues, insertAt);

                List<Value> oppositeValues = new();
                oppositeValues.Add(value);
                newLink.SetFeatureValue(oppositeEnd, oppositeValues, position);

                newLink.AddTo(GetExecutionLocus());

            }
            else if (value is StructuredValue structuredValue)
            {
                // If the value is a data value, then it must be copied before
                // any change is made.
                if (value is not Reference)
                {
                    value = value.Copy();
                }

                if (action!.isReplaceAll)
                {
                    structuredValue.SetFeatureValue(feature, inputValues, 0);
                }
                else
                {
                    FeatureValue featureValue = structuredValue
                            .GetFeatureValue(feature);

                    if (featureValue.values.Count > 0 & insertAt == 0)
                    {
                        // *** If there is no insertAt pin, then the structural
                        // feature must be unordered, and the insertion position is
                        // immaterial. ***
                        insertAt = ((ChoiceStrategy)GetExecutionLocus()?.factory?
                                .GetStrategy("choice")!).Choose(featureValue.values
                                .Count);
                    }

                    if (feature.multiplicityElement.isUnique)
                    {
                        // Remove any existing value that duplicates the input value
                        int j = Position(inputValue, featureValue.values, 1);
                        if (j > 0)
                        {
                            featureValue.values.RemoveAt(j - 1);
                        }
                    }

                    if (insertAt <= 0)
                    { // Note: insertAt = -1 indicates an
                      // unlimited value of "*"
                        featureValue.values.Add(inputValue);
                    }
                    else
                    {
                        featureValue.values.Insert(insertAt - 1, inputValue);
                    }
                }
            }

            if (action?.result is not null)
            {
                PutToken(action.result, value);
            }

        } // doAction
    } // AddStructuralFeatureValueActionActivation
}
