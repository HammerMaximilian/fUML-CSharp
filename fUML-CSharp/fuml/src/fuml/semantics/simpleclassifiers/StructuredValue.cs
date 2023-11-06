using fuml.semantics.values;
using fuml.syntax.classification;
using fuml.syntax.commonstructure;
using fuml.syntax.values;

namespace fuml.semantics.simpleclassifiers
{
    public abstract class StructuredValue : Value
    {
        public override ValueSpecification Specify()
        {
            // Return an instance value that specifies this structured value.

            InstanceValue instanceValue = new();
            InstanceSpecification instance = new();

            instanceValue.type = null;
            instanceValue.instance = instance;

            instance.classifier = GetTypes();

            List<FeatureValue> featureValues = GetFeatureValues();

            foreach (FeatureValue featureValue in featureValues)
            {
                Slot slot = new();
                slot.definingFeature = featureValue.feature;

                List<Value> values = featureValue.values;
                foreach (Value value in values)
                {
                    slot.value.Add(value.Specify());
                }

                instance.slot.Add(slot);
            }

            return instanceValue;
        } // specify

        public abstract FeatureValue GetFeatureValue(
                StructuralFeature feature);

        public abstract void SetFeatureValue(
                StructuralFeature feature,
                List<Value> values, int position);

        public abstract List<FeatureValue> GetFeatureValues();

        public List<StructuralFeature> GetMemberFeatures(Classifier type)
        {
            // Return the features for this structured value that are members of the 
            // given type. (That is, they are owned or inherited by the given type, 
            // excluding private features of supertypes that are not inherited.)

            List<StructuralFeature> features = GetStructuralFeatures();
            List<StructuralFeature> memberFeatures = new();

            if (type is not null)
            {
                List<NamedElement> members = type.member;
                foreach (StructuralFeature feature in features)
                {
                    bool isMember = false;
                    int k = 1;
                    while (k <= members.Count & !isMember)
                    {
                        NamedElement member = members.ElementAt(k - 1);
                        isMember = feature == member;
                        k++;
                    }
                    if (isMember)
                    {
                        memberFeatures.Add(feature);
                    }
                }
            }

            return memberFeatures;
        }

        public List<StructuralFeature> GetStructuralFeatures()
        {
            // Get all structural features of the types of this structured 
            // value and all of their supertypes (including private features 
            // that are not inherited).

            List<StructuralFeature> features = new();
            List<Classifier> types = GetTypes();

            foreach (Classifier type in types)
            {
                List<StructuralFeature> typeFeatures = GetStructuralFeaturesForType(type);
                foreach (NamedElement supertypeFeature in typeFeatures)
                {
                    features.Add((StructuralFeature)supertypeFeature);
                }
            }

            return features;
        }

        public List<StructuralFeature> GetStructuralFeaturesForType(Classifier type)
        {
            // Get all structural features of the given type and all of its 
            // supertypes (including private features that are not inherited).

            List<StructuralFeature> features = new();

            // Get feature values for the owned structural features of the given type.
            List<NamedElement> ownedMembers = type.ownedMember;
            foreach (NamedElement ownedMember in ownedMembers)
            {
                if (ownedMember is StructuralFeature structuralFeature)
                {
                    features.Add(structuralFeature);
                }
            }

            // Add features for the structural features of the supertypes
            // of the given type. (Note that the features for supertypes
            // always come after the owned features.)
            List<Classifier> supertypes = type.general;
            foreach (Classifier supertype in supertypes)
            {
                List<StructuralFeature> supertypeFeatures = GetStructuralFeaturesForType(supertype);
                foreach (NamedElement supertypeFeature in supertypeFeatures)
                {
                    features.Add((StructuralFeature)supertypeFeature);
                }
            }

            return features;
        }

        public void CreateFeatureValues()
        {
            // Create empty feature values for all non-association-end structural 
            // features of the types of this structured value and all its supertypes 
            // (including private features that are not inherited).

            AddFeatureValues(new List<FeatureValue>());
        }

        public void AddFeatureValues(List<FeatureValue> oldFeatureValues)
        {
            // Add feature values for all non-association-end structural features 
            // of the types of this structured value and all its supertypes 
            // (including private features that are not inherited). If a feature 
            // has an old feature value in the given list, then use that to 
            // initialize the values of the corresponding new feature value. 
            // Otherwise leave the values of the new feature value empty.

            // Note: Any common features that appear twice in the list will simply
            // have their values set multiple times to the same thing.
            List<StructuralFeature> features = GetStructuralFeatures();
            foreach (StructuralFeature feature in features)
            {
                if (!CheckForAssociationEnd(feature))
                {
                    SetFeatureValue(feature,
                            GetValues(feature, oldFeatureValues), 0);
                }
            }
        }

        public bool CheckForAssociationEnd(StructuralFeature feature)
        {
            bool isAssociationEnd = false;
            if (feature is Property property) 
            {
                isAssociationEnd = property.association is not null;
            }
            return isAssociationEnd;
        }

        public List<Value> GetValues(NamedElement feature, List<FeatureValue> featureValues)
        {
            // Return the values from the feature value in the given list for the 
            // given feature. If there is no such feature value, return an empty
            // list.

            FeatureValue? foundFeatureValue = null;

            int i = 1;
            while (foundFeatureValue is null & i <= featureValues.Count)
            {
                FeatureValue featureValue = featureValues.ElementAt(i - 1);
                if (featureValue.feature == feature)
                {
                    foundFeatureValue = featureValue;
                }
                i++;
            }

            List<Value> values;
            if (foundFeatureValue is null)
            {
                values = new List<Value>();
            }
            else
            {
                values = foundFeatureValue.values;
            }

            return values;
        }
    } // StructuredValue
}
