using fuml.semantics.values;
using fuml.syntax.classification;
using fuml.syntax.simpleclassifiers;

namespace fuml.semantics.simpleclassifiers
{
    public class SignalInstance : CompoundValue
    {
        public Signal? type = null;

        public override List<Classifier> getTypes()
        {
            // Return the single type of this signal instance.

            List<Classifier> types = new();

            types.Add(type);

            return types;
        } // getTypes

        protected override Value new_()
        {
            // Create a new signal instance with no type or feature values.

            return new SignalInstance();
        } // new_

        public override Value copy()
        {
            // Create a new signal instance with the same type and feature values as
            // this signal instance.

            SignalInstance newValue = (SignalInstance)base.copy();

            newValue.type = this.type;

            return newValue;
        } // copy
    } // SignalInstance
}
