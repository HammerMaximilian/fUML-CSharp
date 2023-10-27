using fuml.syntax.values;
using UMLPrimitiveTypes;

namespace fuml.syntax.commonstructure
{
    public class MultiplicityElement : Element
    {
        public bool isOrdered = false;
        public bool isUnique = true;
        public UnlimitedNatural upper = new(1);
        public int lower = 1;
        public ValueSpecification? upperValue = null;
        public ValueSpecification? lowerValue = null;

        public MultiplicityElement()
        {
            // This constructor sets upperValue and lowerValue consistently with the
            // initializers for upper and lower.

            setUpper(1);
            setLower(1);
        } // MultiplicityElement

        public void setIsOrdered(bool isOrdered)
        {
            this.isOrdered = isOrdered;
        } // setIsOrdered

        public void setIsUnique(bool isUnique)
        {
            this.isUnique = isUnique;
        } // setIsUnique

        public void setUpperValue(
                ValueSpecification upperValue)
        {
            this.upperValue = upperValue ?? throw new ArgumentNullException(nameof(upperValue));

            if (upperValue is LiteralUnlimitedNatural)
            {
                upper = ((LiteralUnlimitedNatural)upperValue).value;
            }
        } // setUpperValue

        public void setLowerValue(
                ValueSpecification lowerValue)
        {
            this.lowerValue = lowerValue ?? throw new ArgumentNullException(nameof(lowerValue));

            if (lowerValue is LiteralInteger)
            {
                lower = ((LiteralInteger)lowerValue).value;
            }
        } // setLowerValue

        public void setUpper(int upper)
        {
            // Note: This is a convenience operation that may be used _instead_ of
            // setUpperValue, not in addition to it.

            this.upper = new UnlimitedNatural(upper);
            upperValue = new LiteralUnlimitedNatural();
            ((LiteralUnlimitedNatural)upperValue).setValue(this.upper);
        } // setUpper

        public void setLower(int lower)
        {
            // Note: This is a convenience operation that may be used _instead_ of
            // setLowerValue, not in addition to it.

            this.lower = lower;
            lowerValue = new LiteralInteger();
            ((LiteralInteger)lowerValue).setValue(lower);
        } // setLower
    }
} // MultiplicityElement
