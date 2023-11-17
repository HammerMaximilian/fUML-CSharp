using uml.classification;

namespace uml.structuredclassifiers
{
    public class Connector : Feature // PSCS-specific
    {
        public ConnectorKind kind;
        public List<ConnectorEnd> end = new();
        public Association? type = null;
        public List<Connector> redefinedConnector = new();

        public void AddEnd(ConnectorEnd end)
        {
            if (end is null)
            {
                throw new ArgumentNullException(nameof(end));
            }

            AddOwnedElement(end);
            this.end.Add(end);
        }

        public void SetType(Association type)
        {
            this.type = type ?? throw new ArgumentNullException(nameof(type));
        }

        public void AddRedefinedConnector(Connector redefinedConnector)
        {
            if (redefinedConnector is null)
            {
                throw new ArgumentNullException(nameof(redefinedConnector));
            }

            AddRedefinedElement(redefinedConnector);
            this.redefinedConnector.Add(redefinedConnector);
        }
    }
}
