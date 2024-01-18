using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using uml.actions;
using uml.classification;
using uml.simpleclassifiers;

namespace fuml.semantics.actions
{
    public class SendSignalActionActivation : InvocationActionActivation
    {
		public override void DoAction()
		{
			// Get the value from the target pin. If the value is not a reference,
			// then do nothing.
			// Otherwise, construct a signal using the values from the argument pins
			// and send it to the referent object.

			SendSignalAction action = (SendSignalAction)node!;
			Value target = TakeTokens(action?.target!).ElementAt(0);

			if (target is Reference reference) {
				Signal signal = action?.signal!;

				SignalInstance signalInstance = new();
				signalInstance.type = signal;

				List<Property> attributes = signal.ownedAttribute;
				List<InputPin> argumentPins = (action != null) ? action.argument : new List<InputPin>();
				for (int i = 0; i < attributes.Count; i++)
				{
					Property attribute = attributes.ElementAt(i);
					InputPin argumentPin = argumentPins.ElementAt(i);
					List<Value> values = TakeTokens(argumentPin);
					signalInstance.SetFeatureValue(attribute, values, 0);
				}

                SignalEventOccurrence signalEventOccurrence = new()
                {
                    signalInstance = (SignalInstance)signalInstance.Copy()
                };
                signalEventOccurrence.SendTo(reference);
			}
		} // doAction
	} // SendSignalActionActivation
}
