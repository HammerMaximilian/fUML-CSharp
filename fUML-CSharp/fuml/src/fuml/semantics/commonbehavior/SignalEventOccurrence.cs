using fuml.semantics.simpleclassifiers;
using fuml.syntax.classification;
using fuml.syntax.commonbehavior;

namespace fuml.semantics.commonbehavior
{
    public class SignalEventOccurrence : EventOccurrence
    {
        public SignalInstance? signalInstance;


        public override bool match(Trigger trigger)
        {
            // Match a trigger if it references a signal event whose signal is the type of the 
            // signal instance or one of its supertypes.

            bool matches = false;
            if (trigger.event_ is SignalEvent)
            {
                SignalEvent event_ = (SignalEvent)trigger.event_;
                matches = (signalInstance is not null) ? signalInstance.isInstanceOf(event_.signal!) : false;
            }
            return matches;
        }

        public override List<ParameterValue> getParameterValues(Event event_)

        {
            // Return parameter values for the features of the signal instance, in order,
            // corresponding to the attributes of the declared signal of the given event.
            // These are intended to be treated as if they are the values of effective
            // parameters of direction "in".
            // (Note that the given event must be a signal event, and the signal instance 
            // of this signal event occurrence must be a direct or indirect instance of 
            // the event signal.)

            List<ParameterValue> parameterValues = new();
            if (event_ is SignalEvent) {

                List<StructuralFeature> memberFeatures = (signalInstance is not null) ? signalInstance.getMemberFeatures(((SignalEvent)event_)!.signal!) : new();
                foreach (StructuralFeature feature in memberFeatures)
                {
                    ParameterValue parameterValue = new ParameterValue();
                    parameterValue.values = signalInstance!.getFeatureValue(feature).values;
                    parameterValues.Add(parameterValue);
                }
            }
            return parameterValues;
        }
    } // SignalEventOccurrence
}
