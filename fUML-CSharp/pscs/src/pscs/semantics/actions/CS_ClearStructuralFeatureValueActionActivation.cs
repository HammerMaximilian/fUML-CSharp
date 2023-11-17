using fuml.semantics.actions;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using pscs.semantics.structuredclassifiers;
using uml.actions;
using uml.classification;
using uml.structuredclassifiers;

namespace pscs.semantics.actions
{
    public class CS_ClearStructuralFeatureValueActionActivation : ClearStructuralFeatureActionActivation
    {
        public override void DoAction()
        {
            // Get the value of the object input pin.
            // If the given feature is an association end, then
            // destroy all links that have the object input on the opposite end.
            // Otherwise, if the object input is a structured value, then
            // set the appropriate feature of the input value to be empty.
            ClearStructuralFeatureAction action = (ClearStructuralFeatureAction)node! ?? throw new InvalidCastException();
            StructuralFeature feature = action.structuralFeature ?? throw new NullReferenceException();
            Association association = GetAssociation(feature);
            Value value = TakeTokens(action.object_ ?? throw new ArgumentNullException()).ElementAt(0);
            if (association is not null)
            {
                List<Link> links = GetMatchingLinks(association, feature, value);
                foreach (Link link in links)
                {
                    link.Destroy();
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
                else
                {
                    // extension to fUML
                    List<CS_Link> linksToDestroy = GetLinksToDestroy((StructuredValue)value, feature);
                    foreach (CS_Link cS_Link in linksToDestroy)
                    {
                        cS_Link.Destroy();
                    }
                    //
                }
                ((StructuredValue)value).SetFeatureValue(action.structuralFeature, new(), 0);
            }
            if (action.result is not null)
            {
                PutToken(action.result, value);
            }
        }

        public List<CS_Link> GetLinksToDestroy(StructuredValue value, StructuralFeature feature)
        {
            List<CS_Link> linksToDestroy = new();
            if (value is CS_Reference)
            {
                CS_Reference context = (CS_Reference)value;
                // Retrieves the feature values for the structural feature associated with this
                // action,
                // in the context of this reference
                FeatureValue featureValue = context.GetFeatureValue(feature);
                if (feature is Port)
                {
                    // all values are interaction points
                    // any link targeting this interaction point must be destroyed
                    for (int i = 0; i < featureValue.values.Count; i++)
                    {
                        CS_InteractionPoint interactionPoint = (CS_InteractionPoint)featureValue.values.ElementAt(i);
                        List<CS_Link> connectorInstances = context.compositeReferent?.GetLinks(interactionPoint) ?? new();
                        foreach (CS_Link link in connectorInstances)
                        {
                            linksToDestroy.Add(link);
                        }
                    }
                }
                else
                { // feature is an attribute
                  // Retrieve all potential link ends,
                  // separating potential link ends corresponding to the given feature,
                  // and potential link ends corresponding to other features.
                  // By "potential link ends", we refer to the values of a given feature,
                  // as well as interaction points associated with this value, if any.
                    List<Value> allValuesForFeature = new();
                    List<Value> allOtherValues = new();
                    for (int i = 0; i < context.referent?.GetFeatureValues().Count; i++)
                    {
                        StructuralFeature currentFeature = context.referent.GetFeatureValues().ElementAt(i).feature ?? throw new NullReferenceException();
                        List<Value> values = GetPotentialLinkEnds(context, currentFeature);
                        for (int j = 0; j < values.Count; j++)
                        {
                            Value v = values.ElementAt(j);
                            if (currentFeature != feature)
                            {
                                allOtherValues.Add(v);
                            }
                            else
                            {
                                allValuesForFeature.Add(v);
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
                    // Retrieves links representing connector instances in the context object
                    foreach (CS_Link link in allLinks)
                    {
                        bool linkHasToBeDestroyed = false;
                        for (int j = 0; j < allValuesForFeature.Count && !linkHasToBeDestroyed; j++)
                        {
                            Value v = allValuesForFeature.ElementAt(j);
                            StructuralFeature featureForV = link.GetFeature(v);
                            if (featureForV != null)
                            {
                                // Check if feature values of this link for other features
                                // contains elements identified in allOtherValue
                                for (int k = 0; k < link.GetFeatureValues().Count && !linkHasToBeDestroyed; k++)
                                {
                                    FeatureValue otherFeatureValue = link.GetFeatureValues().ElementAt(k);
                                    if (otherFeatureValue.feature != featureForV)
                                    {
                                        for (int l = 0; l < otherFeatureValue.values.Count
                                                && !linkHasToBeDestroyed; l++)
                                        {
                                            for (int m = 0; m < allOtherValues.Count && !linkHasToBeDestroyed; m++)
                                            {
                                                if (otherFeatureValue.values.ElementAt(l) == allOtherValues.ElementAt(m))
                                                {
                                                    linkHasToBeDestroyed = true;
                                                }
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
            foreach (Value v in featureValue.values)
            {
                potentialLinkEnds.Add(v);
                if (v is CS_Reference)
                {
                    // add all interaction points associated with v
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
    } // CS_ClearStructuralFeatureValueActionActivation
}
