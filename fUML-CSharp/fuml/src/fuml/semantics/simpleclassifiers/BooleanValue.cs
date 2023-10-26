using fuml.semantics.values;
using fuml.src.fuml.syntax.values;
using fuml.syntax.values;

namespace fuml.semantics.simpleclassifiers
{
    public class BooleanValue : PrimitiveValue
    {
        public bool value = false;

        public override ValueSpecification specify()
        {
            // Return a literal bool with the value of this bool value.

            LiteralBoolean literal = new LiteralBoolean();

            literal.type = this.type;
            literal.value = this.value;

            return literal;
        } // specify

        public override bool equals(Value otherValue)
        {
            // Test if this bool value is equal to the otherValue.
            // To be equal, the otherValue must have the same value as this bool
            // value.

            bool isEqual = false;
            if (otherValue is BooleanValue)
            {
                isEqual = ((BooleanValue)otherValue).value == value;
            }

            return isEqual;
        } // equals

        public override Value copy()
        {
            // Create a new bool value with the same value as this bool value.

            BooleanValue newValue = (BooleanValue)base.copy();

            newValue.value = value;
            return newValue;
        } // copy

        protected override Value new_()
        {
            // Return a new bool value with no value.

            return new BooleanValue();
        } // new_

        public override string toString()
        {
            string stringValue = "false";

            if (this.value)
            {
                stringValue = "true";
            }

            return stringValue;
        } // toString
    } // BooleanValue
}
