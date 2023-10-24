using fuml.syntax.commonstructure;

namespace fuml.syntax.classification
{
    public class InstanceSpecification : NamedElement
    {
        public List<Classifier> classifier = new();
        public List<Slot> slot = new();

        public void addClassifier(Classifier classifier)
        {
            if (classifier is null)
            {
                throw new ArgumentNullException(nameof(classifier));
            }

            this.classifier.Add(classifier);
        } // addClassifier

        public void addSlot(Slot slot)
        {
            if (slot is null)
            {
                throw new ArgumentNullException(nameof(slot));
            }

            this.addOwnedElement(slot);
            this.slot.Add(slot);
            slot._setOwningInstance(this);
        } // addSlot
    } // InstanceSpecification
}
