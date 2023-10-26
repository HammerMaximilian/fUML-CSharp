using fuml.semantics.values;
using fuml.syntax.classification;
using fuml.syntax.simpleclassifiers;

namespace fuml.semantics.simpleclassifiers
{
    public abstract class PrimitiveValue : Value
    {
        public PrimitiveType? type = null;

        public override Value copy()
        {
            // Create a new value that is equal to this primitive value.

            PrimitiveValue newValue = (PrimitiveValue)base.copy();

            newValue.type = type;
            return newValue;
        } // copy

        public override List<Classifier> getTypes()
        {
            // Return the single primitive type of this value.

            List<Classifier> types = new List<Classifier>();
            types.Add(type);
            return types;
        } // getTypes
    } // PrimitiveValue
}
