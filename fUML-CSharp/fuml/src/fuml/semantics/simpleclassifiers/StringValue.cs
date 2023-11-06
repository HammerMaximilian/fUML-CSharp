using fuml.semantics.values;
using fuml.syntax.values;
using System;

namespace fuml.semantics.simpleclassifiers
{
    public class StringValue : PrimitiveValue
    {
        public string value = "";

        public override ValueSpecification Specify()
        {
            // Return a literal string with the value of this string value.

            LiteralString literal = new()
            {
                type = type,
                value = value
            };

            return literal;
        } // specify

        public override bool Equals(Value otherValue)
        {
            // Test if this string value is equal to the otherValue.
            // To be equal, the otherValue must have the same value as this string
            // value.

            bool isEqual = false;
            if (otherValue is StringValue stringValue) {
                isEqual = stringValue.value.Equals(value);
            }

            return isEqual;
        } // equals

        public override Value Copy()
        {
            // Create a new string value with the same value as this string value.

            StringValue newValue = (StringValue)base.Copy();

            newValue.value = value;
            return newValue;
        } // copy

        protected override Value New_()
        {
            // Create a new string value with no value.

            return new StringValue();
        } // new_

        public override string ToString()
        {
            return value;
        } // toString
    } // StringValue
}
