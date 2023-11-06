using fuml.syntax.commonstructure;

namespace fuml.syntax.classification
{
    public class InstanceSpecification : NamedElement
    {
        public List<Classifier> classifier = new();
        public List<Slot> slot = new();

        public void AddClassifier(Classifier classifier)
        {
            if (classifier is null)
            {
                throw new ArgumentNullException(nameof(classifier));
            }

            this.classifier.Add(classifier);
        } // addClassifier

        public void AddSlot(Slot slot)
        {
            if (slot is null)
            {
                throw new ArgumentNullException(nameof(slot));
            }

            AddOwnedElement(slot);
            this.slot.Add(slot);
            slot._setOwningInstance(this);
        } // addSlot
    } // InstanceSpecification
}
