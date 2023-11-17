using uml.classification;
using uml.commonstructure;

namespace uml.structuredclassifiers
{
    public class ConnectorEnd : MultiplicityElement // PSCS-specific
    {
        public Property? role = null; // 'role' must be of type Property here since there is no multiple inheritance
        public Property? partWithPort = null;

        public void _setRole(Property role)
        {
            this.role = role ?? throw new ArgumentNullException(nameof(role));
            role.connectableElement.end.Add(this);
        }
    } // ConnectorEnd
}
