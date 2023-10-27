using fuml.semantics.loci;
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
                locus.Remove(this);
            }
        } // destroy

        public override Value Copy()
        {
            // Create a new extensional value with the same feature values at the
            // same locus as this one.

            ExtensionalValue newValue = (ExtensionalValue)base.Copy();

            if (locus is not null)
            {
                locus.Add(newValue);
            }
            else
            {
                identifier = "";
            }

            return newValue;
        } // copy

        public override string ToString()
        {
            return identifier + base.ToString();
        }
    } // ExtensionalValue
}
