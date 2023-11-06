using fuml.syntax.commonstructure;
using fuml.syntax.values;

namespace fuml.syntax.classification
{
    public class Slot : Element
    {
        public InstanceSpecification? owningInstance = null;
        public StructuralFeature? definingFeature = null;
        public List<ValueSpecification> value = new();

        public void SetDefiningFeature(
                StructuralFeature definingFeature)
        {
            this.definingFeature = definingFeature ?? throw new ArgumentNullException(nameof(definingFeature));
        } // setDefiningFeature

        public void AddValue(ValueSpecification value)
        {
            if (value is null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            AddOwnedElement(value);
            this.value.Add(value);
        } // addValue

        public void _setOwningInstance(
                InstanceSpecification owningInstance)
        {
            this.owningInstance = owningInstance ?? throw new ArgumentNullException(nameof(owningInstance));
        } // _setOwningInstance
    } // Slot
}
