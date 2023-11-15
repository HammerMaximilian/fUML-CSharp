using fuml.semantics.values;
using uml.classification;
using uml.simpleclassifiers;

namespace fuml.semantics.simpleclassifiers
{
    public class SignalInstance : CompoundValue
    {
        public Signal? type = null;

        public override List<Classifier> GetTypes()
        {
            // Return the single type of this signal instance.

            List<Classifier> types = new();

            types.Add(type!);

            return types;
        } // getTypes

        protected override Value New_()
        {
            // Create a new signal instance with no type or feature values.

            return new SignalInstance();
        } // new_

        public override Value Copy()
        {
            // Create a new signal instance with the same type and feature values as
            // this signal instance.

            SignalInstance newValue = (SignalInstance)base.Copy();

            newValue.type = type;

            return newValue;
        } // copy
    } // SignalInstance
}
