using fuml.semantics.values;
using uml.values;

namespace fuml.semantics.simpleclassifiers
{
    public class RealValue : PrimitiveValue
    {
        public float value = 0.0f;

        public override ValueSpecification Specify()
        {
            // Return a literal real with the value of this real value.

            LiteralReal literal = new()
            {
                type = type,
                value = value
            };

            return literal;
        } // specify

        public override bool Equals(Value otherValue)
        {
            // Test if this real value is equal to the otherValue.
            // To be equal, the otherValue must have the same value as this real
            // value.

            bool isEqual = false;
            if (otherValue is RealValue realValue)
            {
                isEqual = realValue.value == value;
            }

            return isEqual;
        } // equals

        public override Value Copy()
        {
            // Create a new real value with the same value as this real value.

            RealValue newValue = (RealValue)base.Copy();

            newValue.value = value;
            return newValue;
        } // copy

        protected override Value New_()
        {
            return new RealValue();
        } // new_

        public override string ToString()
        {
            string stringValue;
            if (value == 0)
            {
                stringValue = "0";
            }
            else
            {
                float positiveValue = value;

                if (positiveValue < 0)
                {
                    positiveValue = -positiveValue;
                }

                int exponent = 0;

                if (positiveValue < .1)
                {
                    while (positiveValue < .1)
                    {
                        positiveValue *= 10;
                        exponent--;
                    }
                }
                else if (positiveValue >= 1)
                {
                    while (positiveValue >= 1)
                    {
                        positiveValue /= 10;
                        exponent++;
                    }
                }

                // This gives 9 significant digits in the mantissa.
                for (int i = 0; i < 9; i++)
                {
                    positiveValue *= 10;
                }

                IntegerValue integerValue = new()
                {
                    value = (int)positiveValue
                };
                stringValue = "0." + integerValue.ToString();
                integerValue.value = exponent;
                stringValue = stringValue + "E" + integerValue.ToString();

                if (value < 0)
                {
                    stringValue = "-" + stringValue;
                }
            }

            return stringValue;
        } // toString
    } // RealValue
}
