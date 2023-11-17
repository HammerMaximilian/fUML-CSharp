using fuml.semantics.commonbehavior;
using pscs.semantics.structuredclassifiers;
using uml.commonbehavior;
using uml.structuredclassifiers;

namespace pscs.semantics.commonbehavior
{
    public class CS_EventOccurrence : EventOccurrence
    {
        public EventOccurrence? wrappedEventOccurrence = null;
        public CS_InteractionPoint? interactionPoint = null;
        public bool propagationInward;
        public Port? onPort = null;

        public override bool Match(Trigger trigger)
        {
            // If the trigger references ports then to match this latter it is required that
            // 1] the interaction point is instance of port referenced by the trigger
            // 2] the referenced event occurrence match operation returns true.
            // If the trigger does not reference ports then the behavior is the same than for fUML.
            bool matches = false;
            if (trigger.port.Any())
            {
                int i = 1;
                while (!matches && i <= trigger.port.Count)
                {
                    if (interactionPoint?.definingPort == trigger.port.ElementAt(i - 1))
                    {
                        matches = true;
                    }
                    i++;
                }
                if (matches)
                {
                    matches = wrappedEventOccurrence?.Match(trigger) ?? false;
                }
            }
            else
            {
                matches = wrappedEventOccurrence?.Match(trigger) ?? false;
            }
            return matches;
        }

        public override void DoSend()
        {
            // If the specified target is a CS_Reference and the propagation must be done
            // to the environment, then the operation sendOut(EventOccurrence, Port) is called
            // and make the propagation to continue.
            // If the specified target is a CS_Reference but the propagation must be done to
            // the internals then the operation sendIn(EventOccurrence, Port) is called.
            // In the case were the target is not a CS_EventOccurrence then send(EventOccurence)
            // is called.
            if (target is CS_Reference reference)
            {
                if (propagationInward == true)
                {
                    reference.SendIn(this, onPort!);
                }
                else
                {
                    reference.SendOut(this, onPort!);
                }
            }
            else
            {
                base.DoSend();
            }
        }

        public void SendInTo(CS_Reference target, Port port)
        {
            // Propagate the sending of the event occurrence to the internals
            onPort = port;
            propagationInward = true;
            SendTo(target);
        }

        public void SendOutTo(CS_Reference target, Port port)
        {
            // Propagate the sending of the event occurrence to the environment
            onPort = port;
            propagationInward = false;
            SendTo(target);
        }

        public override List<ParameterValue> GetParameterValues(Event event_)
        {
            // Return the parametric data of the referenced event occurrence
            return wrappedEventOccurrence?.GetParameterValues(event_) ?? new();
        }
    } // CS_EventOccurrence
}
