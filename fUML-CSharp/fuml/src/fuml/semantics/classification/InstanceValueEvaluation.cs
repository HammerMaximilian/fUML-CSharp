﻿using fuml.semantics.simpleclassifiers;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using uml.classification;
using uml.commonbehavior;
using uml.simpleclassifiers;
using uml.structuredclassifiers;
using uml.values;

namespace fuml.semantics.classification
{
    public class InstanceValueEvaluation : Evaluation
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

            InstanceSpecification? instance = ((InstanceValue)specification!)?.instance;
            List<Classifier> types = (instance is not null) ? instance.classifier : throw new NullReferenceException();
            Classifier myType = types.ElementAt(0);

            Debug.Println("[evaluate] type = " + myType.name);

            Value value;
            if (instance is EnumerationLiteral literal)
            {
                EnumerationValue enumerationValue = new();
                enumerationValue.type = (Enumeration)myType;
                enumerationValue.literal = literal;
                value = enumerationValue;
            }
            else
            {
                StructuredValue? structuredValue;

                if (myType is DataType datatype)
                {
                    DataValue dataValue = new();
                    dataValue.type = datatype;
                    structuredValue = dataValue;
                }
                else
                {
                    Object_? object_;
                    if (myType is Behavior behavior)
                    {
                        object_ = locus?.factory?.CreateExecution(
                                behavior, null!);
                    }
                    else
                    {
                        object_ = new Object_();
                        for (int i = 0; i < types.Count; i++)
                        {
                            Classifier type = types.ElementAt(i);
                            object_.types.Add((Class_)type);
                        }
                    }

                    locus?.Add(object_!);

                    Reference reference = new();
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
                    structuredValue
                            .SetFeatureValue(slot?.definingFeature!, values, 0);
                }

                value = structuredValue;
            }

            return value;
        } // evaluate
    } // InstanceValueEvaluation
}
