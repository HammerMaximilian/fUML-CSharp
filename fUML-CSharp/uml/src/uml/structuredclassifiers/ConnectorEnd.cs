using uml.classification;
using uml.commonstructure;

namespace uml.structuredclassifiers
{
    public class ConnectorEnd : MultiplicityElement // PSCS-specific
    {
        public ConnectableElement? role = null;
        public Property? partWithPort = null;

        public void _setRole(ConnectableElement role)
        {
            this.role = role ?? throw new ArgumentNullException(nameof(role));
            role.end.Add(this);
        }
    } // ConnectorEnd
}
