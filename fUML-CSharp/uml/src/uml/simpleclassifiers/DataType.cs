using uml.classification;

namespace uml.simpleclassifiers
{
    public class DataType : Classifier
    {
        public List<Property> ownedAttribute = new();

        public void AddOwnedAttribute(
                Property ownedAttribute)
        {
            if (ownedAttribute is null)
            {
                throw new ArgumentNullException(nameof(ownedAttribute));
            }

            AddAttribute(ownedAttribute);
            AddOwnedMember(ownedAttribute);

            this.ownedAttribute.Add(ownedAttribute);
            ownedAttribute._setDatatype(this);
        } // addOwnedAttribute
    } // DataType
}
