using fuml.semantics.values;
using uml.actions;
using uml.classification;

namespace fuml.semantics.actions
{
    public class ReadStructuralFeatureActionActivation : StructuralFeatureActionActivation
    {
		public override void DoAction()
		{
			// Get the value of the object input pin.
			// If the given feature is an association end, then get all values of
			// that end for which the opposite end has the object input value and 
			// place them on the result pin.
			// Otherwise, if the object input value is a structured value, then get
			// the values of the appropriate feature of the input value and place 
			// them on the result output pin.

			ReadStructuralFeatureAction action = (node as ReadStructuralFeatureAction)!;
			if (action is null) throw new InvalidCastException();
			StructuralFeature? feature = action.structuralFeature;

			Value value = TakeTokens(action.object_!).ElementAt(0);
			PutTokens(action.result!, GetValues(value, feature!));
		} // doAction
	} // ReadStructuralFeatureActionActivation
}
