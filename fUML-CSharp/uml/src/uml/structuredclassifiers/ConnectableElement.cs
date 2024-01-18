using uml.commonstructure;

namespace uml.structuredclassifiers
{
    public class ConnectableElement : TypedElement // PSCS-specific
    {
        public List<ConnectorEnd> end = new();
    }
}
