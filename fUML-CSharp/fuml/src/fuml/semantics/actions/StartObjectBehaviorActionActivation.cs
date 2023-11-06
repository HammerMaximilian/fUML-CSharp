using fuml.semantics.commonbehavior;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using fuml.syntax.actions;
using fuml.syntax.classification;
using fuml.syntax.commonbehavior;
using fuml.syntax.structuredclassifiers;

namespace fuml.semantics.actions
{
    public class StartObjectBehaviorActionActivation : InvocationActionActivation
    {
		public override void DoAction()
		{
			// Get the value on the object input pin. If it is not a reference, then
			// do nothing.
			// Start the behavior of the referent object for the classifier given as
			// the type of the object input pin, with parameter values taken from
			// the argument input pins.
			// If the object input pin has no type, then start the classifier
			// behaviors of all types of the referent object.

			StartObjectBehaviorAction action = (node as StartObjectBehaviorAction)!;
			if (action is null) throw new InvalidCastException();

			Value object_ = TakeTokens(action.object_!).ElementAt(0);

			if (object_ is Reference reference) {
				Class_? type = action.object_?.typedElement.type! as Class_;
				List<InputPin> argumentPins = action.argument;

				List<ParameterValue> inputs = new();

				if (type is not null)
				{
					Behavior? behavior;

					if (type is Behavior typeAsBehavior) {
						behavior = typeAsBehavior;
					} else
					{
						behavior = type.classifierBehavior;
					}

					if (behavior is not null)
					{
						List<Parameter> parameters = behavior.ownedParameter;

						int pinNumber = 1;
						int i = 1;
						while (i <= parameters.Count)
						{
							Parameter parameter = parameters.ElementAt(i - 1);
							int j = pinNumber;
							if (parameter.direction == ParameterDirectionKind.in_
								| parameter.direction == ParameterDirectionKind.inout) {
                                ParameterValue parameterValue = new()
                                {
                                    parameter = parameter,
                                    values = TakeTokens(argumentPins.ElementAt(j - 1))
                                };
                                inputs.Add(parameterValue);
								j++;
							}
							pinNumber = j;
							i++;
						}
					}
				}

				reference.StartBehavior(type!, inputs);
			}
		} // doAction
	} // StartObjectBehaviorActionActivation
}
