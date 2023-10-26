using fuml.semantics.values;
using fuml.syntax.classification;
using fuml.syntax.simpleclassifiers;
using fuml.syntax.values;
using System;

namespace fuml.semantics.simpleclassifiers
{
    public class EnumerationValue : Value
    {
        public EnumerationLiteral? literal = null;
        public Enumeration type = null;

        public override ValueSpecification specify()
        {
            // Return an instance value with literal as the instance.

            InstanceValue instanceValue = new InstanceValue();
            InstanceSpecification instance = new InstanceSpecification();

            instanceValue.type = type;
            instanceValue.instance = literal;

            return instanceValue;
        } // specify

        public override bool equals(Value otherValue)
        {
            // Test if this enumeration value is equal to the otherValue.
            // To be equal, the otherValue must also be an enumeration value with
            // the same literal as this enumeration value.

            bool isEqual = false;
            if (otherValue is EnumerationValue) {
                isEqual = ((EnumerationValue)otherValue).literal == literal;
            }

            return isEqual;
        } // equals

        public override Value copy()
        {
            // Create a new enumeration value with the same literal as this
            // enumeration value.

            EnumerationValue newValue = (EnumerationValue)base.copy();

            newValue.type = type;
            newValue.literal = literal;

            return newValue;
        } // copy

        protected override Value new_()
        {
            // Create a new enumeration value with no literal.

            return new EnumerationValue();
        } // new_

        public override List<Classifier> getTypes()
        {
            // Return the single type of this enumeration value.

            List<Classifier> types = new List<Classifier>();
            types.Add(type);

            return types;
        } // getTypes

        public override string toString()
        {
            return literal.name;
        } // toString
    } // EnumerationValue
}
