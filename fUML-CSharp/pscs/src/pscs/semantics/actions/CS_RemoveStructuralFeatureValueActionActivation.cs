using fuml.semantics.actions;
using fuml.semantics.loci;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using pscs.semantics.structuredclassifiers;
using uml.actions;
using uml.classification;
using uml.structuredclassifiers;

namespace pscs.semantics.actions
{
    public class CS_RemoveStructuralFeatureValueActionActivation : RemoveStructuralFeatureValueActionActivation
    {
        public override void DoAction()
        {
            // Get the values of the object and value input pins. 
            // If the given feature is an association end, then Destroy any
            // matching links. Otherwise, if the object input is a structural
            // value, remove values from the given feature and Destroy all links
            // in which the removed values are involved.
            // If isRemoveDuplicates is true, then Destroy all current matching
            // links or remove all values equal to the input value.
            // If isRemoveDuplicates is false and there is no removeAt input pin,
            // remove any one feature value equal to the input value (if there are
            // any that are equal).
            // If isRemoveDuplicates is false, and there is a removeAt input pin
            // remove the feature value at that position.
            RemoveStructuralFeatureValueAction action = (RemoveStructuralFeatureValueAction)node! ?? throw new InvalidCastException();
            StructuralFeature feature = action.structuralFeature ?? throw new NullReferenceException();
            Association association = GetAssociation(feature);
            Value value = TakeTokens(action.object_ ?? throw new ArgumentNullException()).ElementAt(0);
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
            if (association != null)
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
                    // non-deterministically Choose one. ***
                    if (links.Count > 0)
                    {
                        int i = ((ChoiceStrategy)GetExecutionLocus()?.factory?.GetStrategy("choice")! ?? throw new InvalidCastException()).Choose(links.Count);
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
                    }
                }
            }
            else if (value is StructuredValue)
            {
                // If the value is a data value, then it must be copied before
                // any change is made.
                if (!(value is Reference))
                {
                    value = value.Copy();
                }
                FeatureValue featureValue = ((StructuredValue)value).GetFeatureValue(action.structuralFeature);
                List<Value> removedValues = new();
                if (action.isRemoveDuplicates)
                {
                    int j = Position(inputValue!, featureValue.values, 1);
                    while (j > 0)
                    {
                        removedValues.Add(featureValue.values.ElementAt(j - 1));
                        featureValue.values.RemoveAt(j - 1);
                        j = Position(inputValue!, featureValue.values, j);
                    }
                }
                else if (action.removeAt == null)
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
                        // *** Nondeterministically Choose which value to remove.
                        // ***
                        int k = ((ChoiceStrategy)GetExecutionLocus()?.factory?.GetStrategy("choice")! ?? throw new InvalidCastException()).Choose(positions.Count);
                        removedValues.Add(featureValue.values.ElementAt(positions.ElementAt(k - 1) - 1));
                        featureValue.values.RemoveAt(positions.ElementAt(k - 1) - 1);
                    }
                }
                else
                {
                    if (featureValue.values.Count >= removeAt)
                    {
                        removedValues.Add(featureValue.values.ElementAt(removeAt - 1));
                        featureValue.values.RemoveAt(removeAt - 1);
                    }
                }
                // When values are removed from the list of values associated to the feature 
                // (in the context of the target), these latter may be involved in links representing
                // instance of connectors. If this is the case, links in which the removed values are
                // involved are Destroyed.
                for (int i = 0; i < removedValues.Count; i++)
                {
                    List<CS_Link> linkToDestroy = GetLinksToDestroy((StructuredValue)value, feature, removedValues.ElementAt(i));
                    for (int j = 0; j < linkToDestroy.Count; j++)
                    {
                        linkToDestroy.ElementAt(j).Destroy();
                    }
                }
            }
            if (action.result is not null)
            {
                PutToken(action.result, value);
            }
        }

        public List<CS_Link> GetLinksToDestroy(StructuredValue value, StructuralFeature feature, Value removedValue)
        {
            // Get all links that are required to be Destroyed due to the removal of the removedValue
            List<CS_Link> linksToDestroy = new();
            if (value is CS_Reference)
            {
                CS_Reference context = (CS_Reference)value;
                // Retrieves the feature values for the structural feature associated with this action,
                // in the context of this reference
                if (feature is Port)
                {
                    // The removed value is an interaction point.
                    // All links in which this interaction is involved must be Destroyed.
                    CS_InteractionPoint interactionPoint = (CS_InteractionPoint)removedValue;
                    List<CS_Link> connectorInstances = context.compositeReferent?.GetLinks(interactionPoint) ?? new();
                    foreach (CS_Link link in connectorInstances)
                    {
                        linksToDestroy.Add(link);
                    }
                }
                else
                {
                    // Feature is not a Port. Search for all potential link
                    // ends existing in the context of this object.
                    List<Value> allValuesForFeature = new();
                    for (int i = 0; i < context.referent?.GetFeatureValues().Count; i++)
                    {
                        StructuralFeature currentFeature = context.referent.GetFeatureValues().ElementAt(i).feature ?? throw new NullReferenceException();
                        if (feature != currentFeature)
                        {
                            List<Value> values = GetPotentialLinkEnds(context, currentFeature);
                            for (int j = 0; j < values.Count; j++)
                            {
                                allValuesForFeature.Add(values.ElementAt(j));
                            }
                        }
                    }
                    // Retrieves all links available at the locus
                    List<ExtensionalValue> extensionalValues = GetExecutionLocus().extensionalValues;
                    List<CS_Link> allLinks = new();
                    foreach (ExtensionalValue extensionalValue in extensionalValues)
                    {
                        if (extensionalValue is CS_Link)
                        {
                            allLinks.Add((CS_Link)extensionalValue);
                        }
                    }
                    // In the set of links involving potential link ends. Search for all
                    // links that involve the removed value in other end. Any link in that
                    // fulfill this condition is registered in the set of link to be Destroyed.
                    for (int i = 0; i < allLinks.Count; i++)
                    {
                        CS_Link link = allLinks.ElementAt(i);
                        bool linkHasToBeDestroyed = false;
                        for (int j = 0; j < allValuesForFeature.Count && !linkHasToBeDestroyed; j++)
                        {
                            Value v = allValuesForFeature.ElementAt(j);
                            StructuralFeature featureForV = link.GetFeature(v);
                            if (featureForV != null)
                            {
                                for (int k = 0; k < link.GetFeatureValues().Count && !linkHasToBeDestroyed; k++)
                                {
                                    FeatureValue otherFeatureValue = link.GetFeatureValues().ElementAt(k);
                                    if (otherFeatureValue.feature != featureForV)
                                    {
                                        for (int l = 0; l < otherFeatureValue.values.Count && !linkHasToBeDestroyed; l++)
                                        {
                                            if (otherFeatureValue.values.ElementAt(l) == removedValue)
                                            {
                                                linkHasToBeDestroyed = true;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (linkHasToBeDestroyed)
                        {
                            linksToDestroy.Add(link);
                        }
                    }
                }
            }
            return linksToDestroy;
        }

        public List<Value> GetPotentialLinkEnds(CS_Reference context, StructuralFeature feature)
        {
            // Retrieves all feature values for the context object for the given feature,
            // as well as all interaction point for these values
            List<Value> potentialLinkEnds = new();
            FeatureValue featureValue = context.GetFeatureValue(feature);
            for (int i = 0; i < featureValue.values.Count; i++)
            {
                Value v = featureValue.values.ElementAt(i);
                potentialLinkEnds.Add(v);
                if (v is CS_Reference)
                {
                    // Add all interaction points associated with v
                    for (int j = 0; j < ((CS_Reference)v).referent?.GetFeatureValues().Count; j++)
                    {
                        if (((CS_Reference)v).referent?.GetFeatureValues().ElementAt(j).feature is Port)
                        {
                            List<Value> interactionPoints = ((CS_Reference)v).referent?.GetFeatureValues().ElementAt(j).values ?? new();
                            foreach (Value interactionPoint in interactionPoints)
                            {
                                potentialLinkEnds.Add(interactionPoint);
                            }
                        }
                    }
                }
            }
            return potentialLinkEnds;
        }
    } // CS_RemoveStructuralFeatureValueActionActivation
}
