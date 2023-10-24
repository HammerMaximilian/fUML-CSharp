using fuml.syntax.activities;
using fuml.syntax.commonstructure;
using fuml.syntax.values;
using System;

namespace fuml.syntax.actions
{
    public abstract class Pin : ObjectNode
    {
        public MultiplicityElement multiplicityElement = new();

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
            multiplicityElement.setUpperValue(upperValue);
        } // setUpperValue

        public void setLowerValue(
                ValueSpecification lowerValue)
        {
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
    } // Pin
}
