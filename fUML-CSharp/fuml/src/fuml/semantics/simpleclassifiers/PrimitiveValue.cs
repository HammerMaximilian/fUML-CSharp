using fuml.semantics.values;
using uml.classification;
using uml.simpleclassifiers;

namespace fuml.semantics.simpleclassifiers
{
    public abstract class PrimitiveValue : Value
    {
        public PrimitiveType? type = null;

        public override Value Copy()
        {
            // Create a new value that is equal to this primitive value.

            PrimitiveValue newValue = (PrimitiveValue)base.Copy();

            newValue.type = type;
            return newValue;
        } // copy

        public override List<Classifier> GetTypes()
        {
            // Return the single primitive type of this value.

            List<Classifier> types = new()
            {
                type!
            };
            return types;
        } // getTypes
    } // PrimitiveValue
}
