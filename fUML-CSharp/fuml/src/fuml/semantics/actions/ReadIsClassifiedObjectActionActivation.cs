using fuml.semantics.values;
using uml.actions;

namespace fuml.semantics.actions
{
    public class ReadIsClassifiedObjectActionActivation : ActionActivation
    {
		public override void DoAction()
		{
			// Get the value on the object input pin and determine if it is
			// classified by the classifier specified in the action.
			// If the isDirect attribute of the action is false, then place true on
			// the result output pin if the input object has the specified
			// classifier or of one its (direct or indirect) descendants as a type.
			// If the isDirect attribute of the action is true, then place true on
			// the result output pin if the input object has the specified
			// classifier as a type.
			// Otherwise place false on the result output pin.

			ReadIsClassifiedObjectAction action = (node as ReadIsClassifiedObjectAction)!;
			if (action is null) throw new InvalidCastException();

			Value input = TakeTokens(action.object_!).ElementAt(0);

            bool result;
            if (action.isDirect)
			{
				result = input.HasType(action.classifier!);
			}
			else
			{
				result = input.IsInstanceOf(action.classifier!);
			}

			List<Value> values = new();
			values.Add(MakeBooleanValue(result));

			PutTokens(action.result!, values);
		} // doAction
	} // ReadIsClassifiedObjectActionActivation
}
