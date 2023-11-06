using fuml.semantics.simpleclassifiers;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using fuml.syntax.actions;
using fuml.syntax.classification;
using fuml.syntax.structuredclassifiers;

namespace fuml.semantics.actions
{
    public class ReclassifyObjectActionActivation : ActionActivation
    {
        public override void DoAction()
        {
            // Get the value of the object input pin. If it is not a reference, then
            // do nothing. Otherwise, do the following.
            // Remove all types from the referent object that are in the set of old
            // classifiers but not the set of new classifiers (or just all types
            // that are not new classifiers, if isReplaceAll is true).
            // Remove the feature values from the referent object for all
            // classifiers that are removed.
            // Add all new classifiers as types of the referent object that are not
            // already types.
            // Add feature values to the referent object for the structural
            // features of all added classifiers.
            // Any features that previously had values maintain those values,
            // while new features are initialized as being empty.

            ReclassifyObjectAction action = (node as ReclassifyObjectAction)!;
            if (action is null) throw new InvalidCastException();
            List<Classifier> newClassifiers = action.newClassifier;
            List<Classifier> oldClassifiers = action.oldClassifier;

            Value input = TakeTokens(action.object_!).ElementAt(0);

            if (input is Reference reference)
            {
                Object_ object_ = reference.referent!;
                List<StructuralFeature> oldFeatures = object_.GetStructuralFeatures();

                int i = 1;
                while (i <= object_.types.Count)
                {
                    Class_ type = object_.types.ElementAt(i - 1);

                    bool toBeRemoved = true;
                    int j = 1;
                    while (toBeRemoved & j <= newClassifiers.Count)
                    {
                        toBeRemoved = (type != newClassifiers.ElementAt(j - 1));
                        j++;
                    }

                    if (toBeRemoved & !action.isReplaceAll)
                    {
                        bool notInOld = true;
                        int k = 1;
                        while (notInOld & k <= oldClassifiers.Count)
                        {
                            notInOld = (type != oldClassifiers.ElementAt(k - 1));
                            k++;
                        }
                        toBeRemoved = !notInOld;
                    }

                    if (toBeRemoved)
                    {
                        object_.types.RemoveAt(i - 1);
                    }
                    else
                    {
                        i++;
                    }
                }

                foreach (Classifier classifier in newClassifiers)
                {
                    bool toBeAdded = true;
                    int j = 1;
                    while (toBeAdded & j <= object_.types.Count)
                    {
                        toBeAdded = (classifier != object_.types.ElementAt(j - 1));
                        j++;
                    }

                    if (toBeAdded)
                    {
                        object_.types.Add((Class_)classifier);
                    }
                }

                List<FeatureValue> oldFeatureValues = object_.GetFeatureValues();
                object_.featureValues = new List<FeatureValue>();
                object_.AddFeatureValues(oldFeatureValues);

                // Destroy links involving association ends that were previously features
                // but no longer have feature values after the reclassification.
                List<StructuralFeature> newFeatures = object_.GetStructuralFeatures();
                foreach (StructuralFeature feature in oldFeatures)
                {
                    Association association = GetAssociation(feature);
                    if (association is not null)
                    {
                        if (CheckForMissingFeature(newFeatures, feature))
                        {
                            List<Link> links = GetMatchingLinks(association, feature, input);
                            foreach (Link link in links)
                            {
                                link.Destroy();
                            }
                        }
                    }
                }
            }

        } // doAction

        public bool CheckForMissingFeature(List<StructuralFeature> features, StructuralFeature feature)
        {
            bool isMissing = true;

            int i = 1;
            while (isMissing & i <= features.Count)
            {
                StructuralFeature containedFeature = features.ElementAt(i - 1);
                isMissing = containedFeature != feature;
                i++;
            }

            return isMissing;
        }
    } // ReclassifyObjectActionActivation
}
