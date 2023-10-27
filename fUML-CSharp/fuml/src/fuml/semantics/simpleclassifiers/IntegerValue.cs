using fuml.semantics.values;
using fuml.syntax.values;
using System;

namespace fuml.semantics.simpleclassifiers
{
    public class IntegerValue : PrimitiveValue
    {
        public int value = 0;

        public override ValueSpecification Specify()
        {
            // Return a literal integer with the value of this integer value.

            LiteralInteger literal = new LiteralInteger();

            literal.type = type;
            literal.value = value;

            return literal;
        } // specify

        public override bool Equals(Value otherValue)
        {
            // Test if this integer value is equal to the otherValue.
            // To be equal, the otherValue must have the same value as this integer
            // value.

            bool isEqual = false;
            if (otherValue is IntegerValue) {
                isEqual = ((IntegerValue)otherValue).value == value;
            }

            return isEqual;
        } // equals

        public override Value Copy()
        {
            // Create a new integer value with the same value as this integer value.

            IntegerValue newValue = (IntegerValue)base.Copy();

            newValue.value = value;
            return newValue;
        } // copy

        protected override Value New_()
        {
            // Create a new integer value with no value.

            return new IntegerValue();
        } // new_

        public override string ToString()
        {
            string stringValue = "";

            if (value == 0)
            {
                stringValue = "0";
            }
            else
            {
                int positiveValue = value;

                if (positiveValue < 0)
                {
                    positiveValue = -positiveValue;
                }

                do
                {
                    int digit = positiveValue % 10;

                    if (digit == 0)
                    {
                        stringValue = "0" + stringValue;
                    }
                    else if (digit == 1)
                    {
                        stringValue = "1" + stringValue;
                    }
                    else if (digit == 2)
                    {
                        stringValue = "2" + stringValue;
                    }
                    else if (digit == 3)
                    {
                        stringValue = "3" + stringValue;
                    }
                    else if (digit == 4)
                    {
                        stringValue = "4" + stringValue;
                    }
                    else if (digit == 5)
                    {
                        stringValue = "5" + stringValue;
                    }
                    else if (digit == 6)
                    {
                        stringValue = "6" + stringValue;
                    }
                    else if (digit == 7)
                    {
                        stringValue = "7" + stringValue;
                    }
                    else if (digit == 8)
                    {
                        stringValue = "8" + stringValue;
                    }
                    else if (digit == 9)
                    {
                        stringValue = "9" + stringValue;
                    }

                    positiveValue = positiveValue / 10;
                } while (positiveValue > 0);

                if (value < 0)
                {
                    stringValue = "-" + stringValue;
                }
            }

            return stringValue;
        } // toString
    } // IntegerValue
}
