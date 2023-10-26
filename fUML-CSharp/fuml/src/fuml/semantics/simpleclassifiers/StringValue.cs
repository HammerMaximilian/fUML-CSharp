using fuml.semantics.values;
using fuml.syntax.values;
using System;

namespace fuml.semantics.simpleclassifiers
{
    public class StringValue : PrimitiveValue
    {
        public string value = "";

        public override ValueSpecification specify()
        {
            // Return a literal string with the value of this string value.

            LiteralString literal = new LiteralString();

            literal.type = type;
            literal.value = value;

            return literal;
        } // specify

        public override bool equals(Value otherValue)
        {
            // Test if this string value is equal to the otherValue.
            // To be equal, the otherValue must have the same value as this string
            // value.

            bool isEqual = false;
            if (otherValue is StringValue) {
                isEqual = ((StringValue)otherValue).value.Equals(value);
            }

            return isEqual;
        } // equals

        public override Value copy()
        {
            // Create a new string value with the same value as this string value.

            StringValue newValue = (StringValue)base.copy();

            newValue.value = value;
            return newValue;
        } // copy

        protected override Value new_()
        {
            // Create a new string value with no value.

            return new StringValue();
        } // new_

        public override string toString()
        {
            return value;
        } // toString
    } // StringValue
}
