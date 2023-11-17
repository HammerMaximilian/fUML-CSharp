using uml.classification;

namespace uml.structuredclassifiers
{
    public abstract class StructuredClassifier : Classifier // PSCS-specific
    {
        public List<Property> ownedAttribute = new();
        public List<Connector> ownedConnector = new();
        public List<Property> part = new();

        public void AddOwnedAttribute(Property ownedAttribute)
        {
            if (ownedAttribute is null)
            {
                throw new ArgumentNullException(nameof(ownedAttribute));
            }

            AddAttribute(ownedAttribute);
            AddOwnedMember(ownedAttribute);
            this.ownedAttribute.Add(ownedAttribute);

            if(ownedAttribute.isComposite)
            {
                part.Add(ownedAttribute);
            }
        }

        public void AddOwnedConnector(Connector ownedConnector)
        {
            if (ownedConnector is null)
            {
                throw new ArgumentNullException(nameof(ownedConnector));
            }

            AddFeature(ownedConnector);
            AddOwnedMember(ownedConnector);
            this.ownedConnector.Add(ownedConnector);
        }
    }
}
