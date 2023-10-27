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

        public void startBehavior(
                Class_ classifier,
                List<ParameterValue> inputs)
        {
            // Asynchronously start the behavior of the given classifier for the
            // referent object.

            referent?.startBehavior(classifier, inputs);
        } // startBehavior

        public Execution dispatch(
                Operation operation)
        {
            // Dispatch the given operation to the referent object.

            return (referent is not null) ? referent.dispatch(operation) : null!;
        } // dispatch

        public void send(
                EventOccurrence eventOccurrence)
        {
            // Send the given event occurrence to the referent object.

            referent?.send(eventOccurrence);
        } // send

        public void destroy()
        {
            // Destroy the referent.

            referent?.destroy();
        } // destroy

        public override bool equals(Value otherValue)
        {
            // Test if this reference is equal to the otherValue.
            // To be equal, the otherValue must also be a reference, with the same
            // referent as this reference.

            bool isEqual = false;
            if (otherValue is Reference) {
                if (referent is null)
                {
                    isEqual = ((Reference)otherValue).referent is null;
                }
                else
                {
                    isEqual = referent.equals(((Reference)otherValue).referent!);
                }
            }

            return isEqual;

        } // equals

        public override Value copy()
        {
            // Create a new reference with the same referent as this reference.

            Reference newValue = (Reference)base.copy();

            newValue.referent = referent;

            return newValue;
        } // copy

        protected override Value new_()
        {
            // Create a new reference with no referent.

            return new Reference();
        } // new_

        public override List<Classifier> getTypes()
        {
            // Get the types of the referent object.

            return referent?.getTypes()!;
        } // getTypes

        public override FeatureValue getFeatureValue(
                StructuralFeature feature)
        {
            // Get the feature value associated with the given feature in the
            // referent object.

            return referent?.getFeatureValue(feature)!;
        } // getFeatureValue

        public override void setFeatureValue(
                StructuralFeature feature,
                List<Value> values, int position)
        {
            // Set the values associated with the given feature in the referent
            // object.

            referent?.setFeatureValue(feature, values, position);
        } // setFeatureValue

        public override List<FeatureValue> getFeatureValues()
        {
            // Return the feature values of the referent.

            return referent?.getFeatureValues()!;
        } // getFeatureValues

        public override string toString()
        {
            return "Reference to " + referent?.toString();
        } // toString
    } // Reference
}
