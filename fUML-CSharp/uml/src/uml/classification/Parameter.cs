using uml.commonstructure;
using uml.values;

namespace uml.classification
{
    public class Parameter : TypedElement
    {
        public MultiplicityElement multiplicityElement = new();
        public ParameterDirectionKind direction = ParameterDirectionKind.in_;
        public Operation? operation = null;
        public bool isStream = false;

        public void SetDirection(
                ParameterDirectionKind direction)
        {
            this.direction = direction;
        } // setDirection

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

        public void SetIsStream(bool isStream)
        {
            this.isStream = isStream;
        }

        public void _setOperation(Operation operation)
        {
            this.operation = operation ?? throw new ArgumentNullException(nameof(operation));
        } // _setOperation
    } // Parameter
}
