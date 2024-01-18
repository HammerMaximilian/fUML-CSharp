using fuml;
using fuml.semantics.classification;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using pscs.semantics.structuredclassifiers;
using uml.classification;
using uml.commonbehavior;
using uml.simpleclassifiers;
using uml.structuredclassifiers;
using uml.values;

namespace pscs.semantics.classification
{
    public class CS_InstanceValueEvaluation : InstanceValueEvaluation
    {
        public override Value Evaluate()
        {
            // If the instance specification is for an enumeration, then return the
            // identified enumeration literal.
            // If the instance specification is for a data type (but not a primitive
            // value or an enumeration), then create a data value of the given data
            // type.
            // If the instance specification is for an object, then create an object
            // at the current locus with the specified types.
            // Set each feature of the created value to the result of evaluating the
            // value specifications for the specified slot for the feature.
            // Extends fUML semantics in the sense that when the instance specification
            // is for an object which is not typed by a Behavior, A CS_Reference (to a
            // CS_Object) is produced instead of a Reference (to an Object)
            InstanceSpecification instance = ((InstanceValue)specification!).instance!;
            List<Classifier> types = instance.classifier;
            Classifier myType = types.ElementAt(0);
            Debug.Println("[evaluate] type = " + myType.name);
            Value value;
            if (instance is EnumerationLiteral literal)
            {
                EnumerationValue enumerationValue = new()
                {
                    type = (Enumeration)myType,
                    literal = literal
                };
                value = enumerationValue;
            }
            else
            {
                StructuredValue structuredValue;
                if (myType is DataType dataType)
                {
                    DataValue dataValue = new()
                    {
                        type = dataType
                    };
                    structuredValue = dataValue;
                }
                else
                {
                    Object_ object_;
                    if (myType is Behavior behavior)
                    {
                        object_ = locus?.factory?.CreateExecution(behavior, null!)!;
                    }
                    else
                    {
                        object_ = new CS_Object();
                        foreach (Classifier type in types)
                        {
                            object_.types.Add((Class_)type);
                        }
                    }
                    locus?.Add(object_!);
                    Reference reference;
                    if (object_ is CS_Object cS_Object)
                    {
                        reference = new CS_Reference();
                        ((CS_Reference)reference).compositeReferent = cS_Object;
                    }
                    else
                    {
                        reference = new Reference();
                    }
                    reference.referent = object_;
                    structuredValue = reference;
                }
                structuredValue.CreateFeatureValues();

                List<Slot> instanceSlots = instance.slot;
                foreach (Slot slot in instanceSlots)
                {
                    List<Value> values = new();
                    List<ValueSpecification> slotValues = slot.value;
                    foreach (ValueSpecification slotValue in slotValues)
                    {
                        values.Add(locus?.executor?.Evaluate(slotValue)!);
                    }
                    structuredValue.SetFeatureValue(slot.definingFeature!, values, 0);
                }
                value = structuredValue;
            }
            return value;
        }
    } // CS_InstanceValueEvaluation
}
