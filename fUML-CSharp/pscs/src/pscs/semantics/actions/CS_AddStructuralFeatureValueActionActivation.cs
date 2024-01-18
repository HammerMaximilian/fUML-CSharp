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
    public class CS_AddStructuralFeatureValueActionActivation : AddStructuralFeatureValueActionActivation
    {
        public override void DoAction()
        {
            // If the feature is a port and the input value to be added is a
            // Reference,
            // Replaces this Reference by an InteractionPoint, and then behaves
            // as usual.
            // If the feature is not a port, behaves as usual
            AddStructuralFeatureValueAction action = (AddStructuralFeatureValueAction)node! ?? throw new InvalidCastException();
            StructuralFeature feature = action.structuralFeature ?? throw new ArgumentNullException();
            if (!(feature is Port))
            {
                // Behaves as usual
                DoActionDefault();
            }
            else
            {
                List<Value> inputValues = TakeTokens(action.value ?? throw new ArgumentNullException());
                // NOTE: Multiplicity of the value input pin is required to be 1..1.
                Value inputValue = inputValues.ElementAt(0);
                if (inputValue is Reference)
                {
                    // First constructs an InteractionPoint from the inputValue
                    Reference reference = (Reference)inputValue;
                    CS_InteractionPoint interactionPoint = new CS_InteractionPoint();
                    interactionPoint.referent = reference.referent;
                    interactionPoint.definingPort = (Port)feature;
                    // The value on action.object is necessarily instanceof
                    // ReferenceToCompositeStructure (otherwise, the feature cannot
                    // be a port)
                    CS_Reference owner = (CS_Reference)TakeTokens(action.object_ ?? throw new ArgumentNullException()).ElementAt(0);
                    interactionPoint.owner = owner;
                    // Then replaces the Reference by an InteractionPoint
                    // in the inputValues
                    inputValues.RemoveAt(0);
                    inputValues.Insert(0, interactionPoint);
                    // Finally concludes with usual fUML behavior of
                    // AddStructuralFeatureValueAction (i.e., the usual behavior
                    // when
                    // the value on action.object pin is a StructuredValue)
                    int insertAt = 0;
                    if (action.insertAt is not null)
                    {
                        insertAt = ((UnlimitedNaturalValue)TakeTokens(action.insertAt).ElementAt(0)).value.naturalValue;
                    }
                    if (action.isReplaceAll)
                    {
                        owner.SetFeatureValue(feature, inputValues, 0);
                    }
                    else
                    {
                        FeatureValue featureValue = owner.GetFeatureValue(feature);
                        if (featureValue.values.Count > 0 & insertAt == 0)
                        {
                            // If there is no insertAt pin, then the structural
                            // feature must
                            // be unordered, and the insertion position is
                            // immaterial.
                            insertAt = ((ChoiceStrategy)GetExecutionLocus()?.factory?.GetStrategy("choice")! ?? throw new InvalidCastException()).Choose(featureValue.values.Count);
                        }
                        if (feature.multiplicityElement.isUnique)
                        {
                            // Remove any existing value that duplicates the input
                            // value
                            int j = Position(interactionPoint, featureValue.values, 1);
                            if (j > 0)
                            {
                                featureValue.values.RemoveAt(j - 1);
                                if (insertAt > 0 & j < insertAt)
                                {
                                    insertAt--;
                                }
                            }
                        }
                        if (insertAt <= 0)
                        {
                            // Note: insertAt = -1 indicates an unlimited value of
                            // "*"
                            featureValue.values.Add(interactionPoint);
                        }
                        else
                        {
                            featureValue.values.Insert(insertAt - 1, interactionPoint);
                        }
                    }
                    if (action.result is not null)
                    {
                        PutToken(action.result, owner);
                    }
                }
                else
                {
                    // behaves as usual
                    DoActionDefault();
                }
            }
        }

        public void DoActionDefault()
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
            // This operation captures same semantics as fUML
            // AddStructuralFeatureValueActionActivation.doAction(), except that
            // when the feature is an association end, a CS_Link will be created instead
            // of a Link
            AddStructuralFeatureValueAction action = (AddStructuralFeatureValueAction)node! ?? throw new InvalidCastException();
            StructuralFeature feature = action.structuralFeature ?? throw new NullReferenceException();
            Association association = GetAssociation(feature);
            Value value = TakeTokens(action.object_ ?? throw new ArgumentNullException()).ElementAt(0);
            List<Value> inputValues = TakeTokens(action.value ?? throw new ArgumentNullException());
            // NOTE: Multiplicity of the value input pin is required to be 1..1.
            Value inputValue = inputValues.ElementAt(0);
            int insertAt = 0;
            if (action.insertAt is not null)
            {
                insertAt = ((UnlimitedNaturalValue)TakeTokens(action.insertAt).ElementAt(0)).value.naturalValue;
            }
            if (association is not null)
            {
                List<Link> links = GetMatchingLinks(association, feature, value);
                Property oppositeEnd = GetOppositeEnd(association, feature);
                int position = 0;
                if (oppositeEnd.multiplicityElement.isOrdered)
                {
                    position = -1;
                }
                if (action.isReplaceAll)
                {
                    foreach (Link link in links)
                    {
                        link.Destroy();
                    }
                }
                else if (feature.multiplicityElement.isUnique)
                {
                    foreach (Link link in links)
                    {
                        FeatureValue featureValue = link.GetFeatureValue(feature);
                        if (featureValue.values.ElementAt(0).Equals(inputValue))
                        {
                            position = link.GetFeatureValue(oppositeEnd).position;
                            if (insertAt > 0 & featureValue.position < insertAt)
                            {
                                insertAt--;
                            }
                            link.Destroy();
                        }
                    }
                }
                CS_Link newLink = new CS_Link();
                newLink.type = association;
                // This is necessary when setting a feature value with an insertAt
                // position
                newLink.locus = GetExecutionLocus();
                newLink.SetFeatureValue(feature, inputValues, insertAt);
                List<Value> oppositeValues = new()
                {
                    value
                };
                newLink.SetFeatureValue(oppositeEnd, oppositeValues, position);
                newLink.locus.Add(newLink);
            }
            else if (value is StructuredValue) {
                StructuredValue structuredValue = (StructuredValue)value;
                if (action.isReplaceAll)
                {
                    structuredValue.SetFeatureValue(feature, inputValues, 0);
                }
                else
                {
                    FeatureValue featureValue = structuredValue.GetFeatureValue(feature);
                    if (featureValue.values.Count > 0 & insertAt == 0)
                    {
                        // *** If there is no insertAt pin, then the structural
                        // feature must be unordered, and the insertion position is
                        // immaterial. ***
                        insertAt = ((ChoiceStrategy)GetExecutionLocus()?.factory?.GetStrategy("choice")! ?? throw new InvalidCastException()).Choose(featureValue.values.Count);
                    }
                    if (feature.multiplicityElement.isUnique)
                    {
                        // Remove any existing value that duplicates the input value
                        int j = Position(inputValue, featureValue.values, 1);
                        if (j > 0)
                        {
                            featureValue.values.RemoveAt(j - 1);
                            if (insertAt > 0 & j < insertAt)
                            {
                                insertAt--;
                            }
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
            if (action.result is not null)
            {
                PutToken(action.result, value);
            }
        }
    } // CS_AddStructuralFeatureValueActionActivation
}
