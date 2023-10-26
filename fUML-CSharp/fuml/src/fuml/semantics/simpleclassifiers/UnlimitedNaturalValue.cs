using fuml.semantics.values;
using fuml.syntax.values;
using UMLPrimitiveTypes;

namespace fuml.semantics.simpleclassifiers
{
    public class UnlimitedNaturalValue : PrimitiveValue
    {
        public UnlimitedNatural value = new(0);

        public override ValueSpecification specify()
        {
            // Return a literal unlimited natural with the value of this unlimited
            // natural value.

            LiteralUnlimitedNatural literal = new LiteralUnlimitedNatural();

            literal.type = type;
            literal.value = value;

            return literal;
        } // specify

        public override bool equals(Value otherValue)
        {
            // Test if this unlimited natural value is equal to the otherValue.
            // To be equal, the otherValue must have the same value as this
            // unlimited natural value.

            bool isEqual = false;
            if (otherValue is UnlimitedNaturalValue) {
                isEqual = ((UnlimitedNaturalValue)otherValue).value.naturalValue == value.naturalValue;
            }

            return isEqual;
        } // equals

        public override Value copy()
        {
            // Create a new unlimited natural value with the same value as this
            // value.

            UnlimitedNaturalValue newValue = (UnlimitedNaturalValue)base.copy();

            newValue.value = value;
            return newValue;
        } // copy

        protected override Value new_()
        {
            // Create a new unlimited natural value with no value.

            return new UnlimitedNaturalValue();
        } // new_

        public override string toString()
        {
            string stringValue = "*";

            if (value.naturalValue >= 0)
            {
                IntegerValue integerValue = new IntegerValue();
                integerValue.value = value.naturalValue;
                stringValue = integerValue.toString();
            }

            return stringValue;

        } // toString
    } // UnlimitedNaturalValue
}
