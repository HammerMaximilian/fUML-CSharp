using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;
using uml.actions;
using uml.classification;

namespace fuml.semantics.actions
{
    public class UnmarshallActionActivation : ActionActivation
    {
		public override void DoAction()
		{
            // Get the value from the object input pin. If it is a structured value,
            // get the values for each of its attributes and place them on the
            // corresponding result pin. (Note that the number of result pins is
            // presumed to be the same as the number of attributes.)

            if (node is not UnmarshallAction action) throw new InvalidCastException();
            Classifier unmarshallType = action.unmarshallType!;
			List<OutputPin> resultPins = action.result;

			Value value = TakeTokens(action.object_!).ElementAt(0);

			if (value is StructuredValue structuredValue) {
				List<StructuralFeature> features = structuredValue.GetMemberFeatures(unmarshallType);
				for (int i = 0; i < features.Count; i++)
				{
					StructuralFeature feature = features.ElementAt(i);
					OutputPin resultPin = resultPins.ElementAt(i);
					PutTokens(resultPin, GetValues(value, feature));
				}
			}
		}
	} // UnmarshallActionActivation
}
