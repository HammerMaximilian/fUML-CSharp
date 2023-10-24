using fuml.syntax.classification;

namespace fuml.syntax.simpleclassifiers
{
    public class Signal : Classifier
    {
        public List<Property> ownedAttribute = new();

        public void addOwnedAttribute(
                Property ownedAttribute)
        {
            if (ownedAttribute is null)
            {
                throw new ArgumentNullException(nameof(ownedAttribute));
            }

            addAttribute(ownedAttribute);
            addOwnedMember(ownedAttribute);

            this.ownedAttribute.Add(ownedAttribute);
        } // addOwnedAttribute
    } // Signal
}
