using uml.commonstructure;
using uml.structuredclassifiers;

namespace uml.commonbehavior
{
    public class Trigger : NamedElement
    {
        public Event? event_ = null;
        public List<Port> port = new(); // PSCS-specific

        public void SetEvent(Event event_) 
        {
            this.event_ = event_;
        } // setEvent

        public void AddPort(Port port) // PSCS-specific
        {
            if (port is null)
            {
                throw new ArgumentNullException(nameof(port));
            }

            this.port.Add(port);
        }
    }
}
