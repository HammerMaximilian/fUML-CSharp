using fuml.syntax.commonstructure;
using fuml.syntax.values;

namespace fuml.syntax.classification
{
    public abstract class StructuralFeature : Feature
    {
        public TypedElement typedElement = new();
        public MultiplicityElement multiplicityElement = new();
        public bool isReadOnly = false;

        public void SetIsReadOnly(bool isReadOnly)
        {
            this.isReadOnly = isReadOnly;
        } // setIsReadOnly

        public void SetIsOrdered(bool isOrdered)
        {
            multiplicityElement.SetIsOrdered(isOrdered);
        } // setIsOrdered

        public void SetIsUnique(bool isUnique)
        {
            multiplicityElement.SetIsUnique(isUnique);
        } // setIsUnique

        public void SetUpperValue(
                ValueSpecification upperValue)
        {
            if (upperValue is null)
            {
                throw new ArgumentNullException(nameof(upperValue));
            }

            multiplicityElement.SetUpperValue(upperValue);
        } // setUpperValue

        public void SetLowerValue(
                ValueSpecification lowerValue)
        {
            if (lowerValue is null)
            {
                throw new ArgumentNullException(nameof(lowerValue));
            }

            multiplicityElement.SetLowerValue(lowerValue);
        } // setLowerValue

        public void SetUpper(int upper)
        {
            // Note: This is a convenience operation that may be used _instead_ of
            // setUpperValue, not in addition to it.

            multiplicityElement.SetUpper(upper);
        } // setUpper

        public void SetLower(int lower)
        {
            // Note: This is a convenience operation that may be used _instead_ of
            // setLowerValue, not in addition to it.

            multiplicityElement.SetLower(lower);

        } // setLower

        public void SetType(commonstructure.Type type)
        {
            typedElement.SetType(type);
        } // setType

    } // StructuralFeature
}
