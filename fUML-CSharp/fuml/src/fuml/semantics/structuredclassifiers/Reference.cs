using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;
using fuml.syntax.classification;
using fuml.syntax.structuredclassifiers;
using System;

namespace fuml.semantics.structuredclassifiers
{
    public class Reference : StructuredValue
    {
        public Object_? referent = null;

        public void StartBehavior(
                Class_ classifier,
                List<ParameterValue> inputs)
        {
            // Asynchronously start the behavior of the given classifier for the
            // referent object.

            referent?.StartBehavior(classifier, inputs);
        } // startBehavior

        public Execution Dispatch(
                Operation operation)
        {
            // Dispatch the given operation to the referent object.

            return (referent is not null) ? referent.Dispatch(operation) : null!;
        } // dispatch

        public void Send(
                EventOccurrence eventOccurrence)
        {
            // Send the given event occurrence to the referent object.

            referent?.Send(eventOccurrence);
        } // send

        public void Destroy()
        {
            // Destroy the referent.

            referent?.Destroy();
        } // destroy

        public override bool Equals(Value otherValue)
        {
            // Test if this reference is equal to the otherValue.
            // To be equal, the otherValue must also be a reference, with the same
            // referent as this reference.

            bool isEqual = false;
            if (otherValue is Reference reference)
            {
                if (referent is null)
                {
                    isEqual = reference.referent is null;
                }
                else
                {
                    isEqual = referent.Equals(reference.referent!);
                }
            }

            return isEqual;

        } // equals

        public override Value Copy()
        {
            // Create a new reference with the same referent as this reference.

            Reference newValue = (Reference)base.Copy();

            newValue.referent = referent;

            return newValue;
        } // copy

        protected override Value New_()
        {
            // Create a new reference with no referent.

            return new Reference();
        } // new_

        public override List<Classifier> GetTypes()
        {
            // Get the types of the referent object.

            return referent?.GetTypes()!;
        } // getTypes

        public override FeatureValue GetFeatureValue(
                StructuralFeature feature)
        {
            // Get the feature value associated with the given feature in the
            // referent object.

            return referent?.GetFeatureValue(feature)!;
        } // getFeatureValue

        public override void SetFeatureValue(
                StructuralFeature feature,
                List<Value> values, int position)
        {
            // Set the values associated with the given feature in the referent
            // object.

            referent?.SetFeatureValue(feature, values, position);
        } // setFeatureValue

        public override List<FeatureValue> GetFeatureValues()
        {
            // Return the feature values of the referent.

            return referent?.GetFeatureValues()!;
        } // getFeatureValues

        public override string ToString()
        {
            return "Reference to " + referent?.ToString();
        } // toString
    } // Reference
}
