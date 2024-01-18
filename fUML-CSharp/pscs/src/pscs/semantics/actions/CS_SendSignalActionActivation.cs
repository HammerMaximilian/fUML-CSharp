using fuml.semantics.actions;
using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using pscs.semantics.commonbehavior;
using pscs.semantics.structuredclassifiers;
using uml.actions;
using uml.classification;
using uml.simpleclassifiers;

namespace pscs.semantics.actions
{
    public class CS_SendSignalActionActivation : SendSignalActionActivation
    {
        public override void DoAction()
        {
            // If onPort is not specified, behaves like in fUML
            // If onPort is specified,
            // Get the value from the target pin. If the value is not a reference,
            // then do nothing.
            // Otherwise, construct a signal using the values from the argument pins
            // As compared to fUML, instead of sending directly to target reference
            // by calling operation send:
            // - if the target is to be the same as or a container of (directly or indirectly)
            // the object executing the Action, the Signal shall be related to a Reception belonging
            // to a required interface of onPort, and sendOut is called on the target reference
            // so that the signal will be sent to the environment
            // - if the target is NOT to be the same as or a container of (directly or indirectly)
            // the object executing the Action, the Signal shall be related to a Reception belonging
            // to a provided Interface of onPort, and operation sendIn is called so that the signal
            // will be sent to the internals of the target object
            SendSignalAction action = (SendSignalAction)node! ?? throw new InvalidCastException();
            if (action.onPort is null)
            {
                // Behaves like in fUML
                base.DoAction();
            }
            else
            {
                Value target = TakeTokens(action.target ?? throw new ArgumentNullException()).ElementAt(0);
                if (target is CS_Reference reference)
                {
                    // Constructs the signal instance
                    Signal signal = action.signal ?? throw new NullReferenceException();
                    SignalInstance signalInstance = new()
                    {
                        type = signal
                    };
                    List<Property> attributes = signal.attribute;
                    List<InputPin> argumentPins = action.argument;
                    int i = 0;
                    while (i < attributes.Count)
                    {
                        Property attribute = attributes.ElementAt(i);
                        InputPin argumentPin = argumentPins.ElementAt(i);
                        List<Value> values = TakeTokens(argumentPin);
                        signalInstance.SetFeatureValue(attribute, values, 0);
                        i++;
                    }
                    // Construct the signal event occurrence
                    SignalEventOccurrence signalEventOccurrence = new()
                    {
                        signalInstance = (SignalInstance)signalInstance.Copy()
                    };
                    CS_EventOccurrence wrappingEventOccurrence = new()
                    {
                        wrappedEventOccurrence = signalEventOccurrence
                    };
                    // Tries to determine if the signal has to be
                    // sent to the environment or to the internals of
                    // target, through onPort
                    CS_Reference targetReference = reference;
                    // Port onPort = action.onPort ;
                    Object_ executionContext = group?.GetActivityExecution().context!;
                    if (executionContext == targetReference.referent || (targetReference.compositeReferent?.Contains(executionContext) ?? false))
                    {
                        wrappingEventOccurrence.SendOutTo(targetReference, action.onPort);
                    }
                    else
                    {
                        wrappingEventOccurrence.SendInTo(targetReference, action.onPort);
                    }
                }
            }
        }
    } // CS_SendSignalActionActivation
}
