using fuml.semantics.values;
using fuml.syntax.classification;
using fuml.syntax.simpleclassifiers;

namespace fuml.semantics.simpleclassifiers
{
    public class DataValue : CompoundValue
    {
        public DataType? type = null;

        public override List<Classifier> getTypes()
        {
            // Return the single type of this data value.

            List<Classifier> types = new List<Classifier>();
            types.Add(type);

            return types;
        } // getTypes

        public override Value copy()
        {
            // Create a new data value with the same type and feature values as this
            // data value.

            DataValue newValue = (DataValue)base.copy();

            newValue.type = type;

            return newValue;
        } // copy

        protected override Value new_()
        {
            // Create a new data value with no type or feature values.

            return new DataValue();
        } // new_
    } // DataValue
}
