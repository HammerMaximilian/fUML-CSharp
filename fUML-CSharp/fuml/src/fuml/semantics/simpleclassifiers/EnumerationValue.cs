using fuml.semantics.values;
using uml.classification;
using uml.simpleclassifiers;
using uml.values;

namespace fuml.semantics.simpleclassifiers
{
    public class EnumerationValue : Value
    {
        public EnumerationLiteral? literal = null;
        public Enumeration? type = null;

        public override ValueSpecification Specify()
        {
            // Return an instance value with literal as the instance.

            InstanceValue instanceValue = new()
            {
                type = type,
                instance = literal
            };

            return instanceValue;
        } // specify

        public override bool Equals(Value otherValue)
        {
            // Test if this enumeration value is equal to the otherValue.
            // To be equal, the otherValue must also be an enumeration value with
            // the same literal as this enumeration value.

            bool isEqual = false;
            if (otherValue is EnumerationValue enumerationValue)
            {
                isEqual = enumerationValue.literal == literal;
            }

            return isEqual;
        } // equals

        public override Value Copy()
        {
            // Create a new enumeration value with the same literal as this
            // enumeration value.

            EnumerationValue newValue = (EnumerationValue)base.Copy();

            newValue.type = type;
            newValue.literal = literal;

            return newValue;
        } // copy

        protected override Value New_()
        {
            // Create a new enumeration value with no literal.

            return new EnumerationValue();
        } // new_

        public override List<Classifier> GetTypes()
        {
            // Return the single type of this enumeration value.

            List<Classifier> types = new()
            {
                type!
            };

            return types;
        } // getTypes

        public override string ToString()
        {
            return (literal is not null) ? literal.name : "";
        } // toString
    } // EnumerationValue
}
