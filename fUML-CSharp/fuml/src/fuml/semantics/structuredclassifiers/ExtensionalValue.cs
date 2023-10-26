using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;

namespace fuml.semantics.structuredclassifiers
{
    public abstract class ExtensionalValue : CompoundValue
    {
        public string identifier = "";
        public Locus? locus = null;

        public virtual void destroy()
        {
            // Remove this value from its locus (if it has not already been
            // destroyed).

            if (locus is not null)
            {
                locus.remove(this);
            }
        } // destroy

        public override Value copy()
        {
            // Create a new extensional value with the same feature values at the
            // same locus as this one.

            ExtensionalValue newValue = (ExtensionalValue)base.copy();

            if (locus is not null)
            {
                locus.add(newValue);
            }
            else
            {
                identifier = "";
            }

            return newValue;
        } // copy

        public override string toString()
        {
            return identifier + base.toString();
        }
    } // ExtensionalValue
}
