using fuml.syntax.commonbehavior;

namespace fuml.semantics.commonbehavior
{
    public class InvocationEventOccurrence : EventOccurrence
    {
        public Execution? execution;

        public override bool match(Trigger trigger)
        {
            // An invocation event occurrence does not match any triggers.

            return false;
        }

        public override List<ParameterValue> getParameterValues(Event event_)
        {
            // An invocation event occurrence does not have any associated data.

            return new();
        }
    } // InvocationEventOccurrence
}
