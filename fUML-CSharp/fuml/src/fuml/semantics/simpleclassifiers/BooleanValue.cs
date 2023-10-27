using fuml.semantics.values;
using fuml.syntax.values;

namespace fuml.semantics.simpleclassifiers
{
    public class BooleanValue : PrimitiveValue
    {
        public bool value = false;

        public override ValueSpecification Specify()
        {
            // Return a literal bool with the value of this bool value.

            LiteralBoolean literal = new()
            {
                type = type,
                value = value
            };

            return literal;
        } // specify

        public override bool Equals(Value otherValue)
        {
            // Test if this bool value is equal to the otherValue.
            // To be equal, the otherValue must have the same value as this bool
            // value.

            bool isEqual = false;
            if (otherValue is BooleanValue booleanValue)
            {
                isEqual = booleanValue.value == value;
            }

            return isEqual;
        } // equals

        public override Value Copy()
        {
            // Create a new bool value with the same value as this bool value.

            BooleanValue newValue = (BooleanValue)base.Copy();

            newValue.value = value;
            return newValue;
        } // copy

        protected override Value New_()
        {
            // Return a new bool value with no value.

            return new BooleanValue();
        } // new_

        public override string ToString()
        {
            string stringValue = "false";

            if (value)
            {
                stringValue = "true";
            }

            return stringValue;
        } // toString
    } // BooleanValue
}
