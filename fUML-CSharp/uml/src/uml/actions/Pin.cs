using uml.activities;
using uml.commonstructure;
using uml.values;
using System;

namespace uml.actions
{
    public abstract class Pin : ObjectNode
    {
        public MultiplicityElement multiplicityElement = new();

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
            multiplicityElement.SetUpperValue(upperValue);
        } // setUpperValue

        public void SetLowerValue(
                ValueSpecification lowerValue)
        {
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
    } // Pin
}
