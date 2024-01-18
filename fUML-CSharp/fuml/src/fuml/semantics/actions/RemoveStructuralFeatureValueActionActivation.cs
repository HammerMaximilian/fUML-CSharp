using fuml.semantics.loci;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using uml.actions;
using uml.classification;
using uml.structuredclassifiers;

namespace fuml.semantics.actions
{
    public class RemoveStructuralFeatureValueActionActivation : WriteStructuralFeatureActionActivation
    {
        public override void DoAction()
        {
            // Get the values of the object and value input pins.
            // If the given feature is an association end, then destroy any matching
            // links.
            // Otherwise, if the object input is a structural value, remove values
            // from the given feature.
            // If isRemoveDuplicates is true, then destroy all current matching
            // links or remove all values equal to the input value.
            // If isRemoveDuplicates is false and there is no removeAt input pin,
            // remove any one feature value equal to the input value (if there are
            // any that are equal).
            // If isRemoveDuplicates is false, and there is a removeAt input pin
            // remove the feature value at that position.

            RemoveStructuralFeatureValueAction action = (node as RemoveStructuralFeatureValueAction)!;
            if (action is null) throw new InvalidCastException();
            StructuralFeature feature = action.structuralFeature!;
            Association association = GetAssociation(feature);

            Value value = TakeTokens(action.object_!).ElementAt(0);

            Value? inputValue = null;
            if (action.value is not null)
            {
                // NOTE: Multiplicity of the value input pin is required to be 1..1.
                inputValue = TakeTokens(action.value).ElementAt(0);
            }

            int removeAt = 0;
            if (action.removeAt is not null)
            {
                removeAt = ((UnlimitedNaturalValue)TakeTokens(action.removeAt).ElementAt(0)).value.naturalValue;
            }

            if (association is not null)
            {
                List<Link> links = GetMatchingLinksForEndValue(association, feature, value, inputValue!);

                if (action.isRemoveDuplicates)
                {
                    foreach (Link link in links)
                    {
                        link.Destroy();
                    }

                }
                else if (action.removeAt is null)
                {
                    // *** If there is more than one matching link,
                    // non-deterministically choose one. ***
                    if (links.Count > 0)
                    {
                        int i = ((ChoiceStrategy)GetExecutionLocus()?.factory?.GetStrategy("choice")!).Choose(links.Count);
                        links.ElementAt(i - 1).Destroy();
                    }

                }
                else
                {
                    bool notFound = true;
                    int i = 1;
                    while (notFound & i <= links.Count)
                    {
                        Link link = links.ElementAt(i - 1);
                        if (link.GetFeatureValue(feature).position == removeAt)
                        {
                            notFound = false;
                            link.Destroy();
                        }
                        i++;
                    }
                }

            }
            else if (value is StructuredValue structuredValue) {
                // If the value is a data value, then it must be copied before
                // any change is made.
                if (value is not Reference) {
                    value = value.Copy();
                }

                FeatureValue featureValue = structuredValue.GetFeatureValue(action.structuralFeature!);

                if (action.isRemoveDuplicates)
                {
                    int j = Position(inputValue!, featureValue.values, 1);
                    while (j > 0)
                    {
                        featureValue.values.RemoveAt(j - 1);
                        j = Position(inputValue!, featureValue.values, j);
                    }

                }
                else if (action.removeAt is null)
                {
                    List<int> positions = new();
                    int j = Position(inputValue!, featureValue.values, 1);
                    while (j > 0)
                    {
                        positions.Add(j);
                        j = Position(inputValue!, featureValue.values, j + 1);
                    }

                    if (positions.Count > 0)
                    {
                        // *** Nondeterministically choose which value to remove.
                        // ***
                        int k = ((ChoiceStrategy)GetExecutionLocus()?.factory?.GetStrategy("choice")!).Choose(positions.Count);
                        featureValue.values.RemoveAt(positions.ElementAt(k - 1) - 1);
                    }

                }
                else
                {
                    if (featureValue.values.Count >= removeAt)
                    {
                        featureValue.values.RemoveAt(removeAt - 1);
                    }
                }
            }

            if (action.result is not null)
            {
                PutToken(action.result, value);
            }

        } // doAction
    } // RemoveStructuralFeatureValueActionActivation
}
