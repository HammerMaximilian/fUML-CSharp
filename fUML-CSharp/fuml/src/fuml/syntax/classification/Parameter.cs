using fuml.syntax.commonstructure;
using fuml.syntax.values;

namespace fuml.syntax.classification
{
    public class Parameter : TypedElement
    {
        public MultiplicityElement multiplicityElement = new();
        public ParameterDirectionKind direction = ParameterDirectionKind.in_;
        public Operation? operation = null;
        public bool isStream = false;

        public void setDirection(
                ParameterDirectionKind direction)
        {
            this.direction = direction;
        } // setDirection

        public void setIsOrdered(bool isOrdered)
        {
            multiplicityElement.setIsOrdered(isOrdered);
        } // setIsOrdered

        public void setIsUnique(bool isUnique)
        {
            multiplicityElement.setIsUnique(isUnique);
        } // setIsUnique

        public void setUpperValue(
                ValueSpecification upperValue)
        {
            if (upperValue is null)
            {
                throw new ArgumentNullException(nameof(upperValue));
            }

            multiplicityElement.setUpperValue(upperValue);
        } // setUpperValue

        public void setLowerValue(
                ValueSpecification lowerValue)
        {
            if (lowerValue is null)
            {
                throw new ArgumentNullException(nameof(lowerValue));
            }

            multiplicityElement.setLowerValue(lowerValue);
        } // setLowerValue

        public void setUpper(int upper)
        {
            // Note: This is a convenience operation that may be used _instead_ of
            // setUpperValue, not in addition to it.

            multiplicityElement.setUpper(upper);
        } // setUpper

        public void setLower(int lower)
        {
            // Note: This is a convenience operation that may be used _instead_ of
            // setLowerValue, not in addition to it.

            multiplicityElement.setLower(lower);

        } // setLower

        public void setIsStream(bool isStream)
        {
            this.isStream = isStream;
        }

        public void _setOperation(Operation operation)
        {
            this.operation = operation ?? throw new ArgumentNullException(nameof(operation));
        } // _setOperation
    } // Parameter
}
