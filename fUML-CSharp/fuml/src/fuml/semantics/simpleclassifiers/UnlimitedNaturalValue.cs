using fuml.semantics.values;
using fuml.syntax.values;
using UMLPrimitiveTypes;

namespace fuml.semantics.simpleclassifiers
{
    public class UnlimitedNaturalValue : PrimitiveValue
    {
        public UnlimitedNatural value = new(0);

        public override ValueSpecification Specify()
        {
            // Return a literal unlimited natural with the value of this unlimited
            // natural value.

            LiteralUnlimitedNatural literal = new();

            literal.type = type;
            literal.value = value;

            return literal;
        } // specify

        public override bool Equals(Value otherValue)
        {
            // Test if this unlimited natural value is equal to the otherValue.
            // To be equal, the otherValue must have the same value as this
            // unlimited natural value.

            bool isEqual = false;
            if (otherValue is UnlimitedNaturalValue unlimitedNaturalValue) {
                isEqual = unlimitedNaturalValue.value.naturalValue == value.naturalValue;
            }

            return isEqual;
        } // equals

        public override Value Copy()
        {
            // Create a new unlimited natural value with the same value as this
            // value.

            UnlimitedNaturalValue newValue = (UnlimitedNaturalValue)base.Copy();

            newValue.value = value;
            return newValue;
        } // copy

        protected override Value New_()
        {
            // Create a new unlimited natural value with no value.

            return new UnlimitedNaturalValue();
        } // new_

        public override string ToString()
        {
            string stringValue = "*";

            if (value.naturalValue >= 0)
            {
                IntegerValue integerValue = new();
                integerValue.value = value.naturalValue;
                stringValue = integerValue.ToString();
            }

            return stringValue;

        } // toString
    } // UnlimitedNaturalValue
}
