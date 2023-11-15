using uml.values;
using UMLPrimitiveTypes;

namespace uml.commonstructure
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

            SetUpper(1);
            SetLower(1);
        } // MultiplicityElement

        public void SetIsOrdered(bool isOrdered)
        {
            this.isOrdered = isOrdered;
        } // setIsOrdered

        public void SetIsUnique(bool isUnique)
        {
            this.isUnique = isUnique;
        } // setIsUnique

        public void SetUpperValue(
                ValueSpecification upperValue)
        {
            this.upperValue = upperValue ?? throw new ArgumentNullException(nameof(upperValue));

            if (upperValue is LiteralUnlimitedNatural literalUnlimitedNatural)
            {
                upper = literalUnlimitedNatural.value;
            }
        } // setUpperValue

        public void SetLowerValue(
                ValueSpecification lowerValue)
        {
            this.lowerValue = lowerValue ?? throw new ArgumentNullException(nameof(lowerValue));

            if (lowerValue is LiteralInteger literalInteger)
            {
                lower = literalInteger.value;
            }
        } // setLowerValue

        public void SetUpper(int upper)
        {
            // Note: This is a convenience operation that may be used _instead_ of
            // setUpperValue, not in addition to it.

            this.upper = new UnlimitedNatural(upper);
            upperValue = new LiteralUnlimitedNatural();
            ((LiteralUnlimitedNatural)upperValue).SetValue(this.upper);
        } // setUpper

        public void SetLower(int lower)
        {
            // Note: This is a convenience operation that may be used _instead_ of
            // setLowerValue, not in addition to it.

            this.lower = lower;
            lowerValue = new LiteralInteger();
            ((LiteralInteger)lowerValue).SetValue(lower);
        } // setLower
    }
} // MultiplicityElement
