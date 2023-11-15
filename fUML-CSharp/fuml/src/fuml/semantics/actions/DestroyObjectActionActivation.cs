using fuml.semantics.simpleclassifiers;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using uml.actions;
using uml.classification;

namespace fuml.semantics.actions
{
    public class DestroyObjectActionActivation : ActionActivation
    {
		public override void DoAction()
		{
			// Get the value on the target input pin.
			// If the value is not a reference, then the action has no effect.
			// Otherwise, do the following.
			// If isDestroyLinks is true, destroy all links in which the referent
			// participates.
			// If isDestroyOwnedObjects is true, destroy all objects owned by the
			// referent via either composite attributes or composition links.
			// Destroy the referent object.

			DestroyObjectAction? action = node as DestroyObjectAction;
			Value value = TakeTokens(action?.target!).ElementAt(0);

			DestroyObject(value, action!.isDestroyLinks,
					action.isDestroyOwnedObjects);

		} // doAction

		public void DestroyObject(Value value,
				bool isDestroyLinks, bool isDestroyOwnedObjects)
		{
            // If the given value is a reference, then destroy the referenced
            // object, per the given destroy action attribute values.

            if (value is Reference reference)
            {
                Debug.Println("[destroyObject] object = " + reference?.referent?.identifier);

                if (isDestroyLinks | isDestroyOwnedObjects)
                {
                    List<ExtensionalValue> extensionalValues =
                            GetExecutionLocus().extensionalValues;
                    foreach (ExtensionalValue extensionalValue in extensionalValues)
                    {
                        if (extensionalValue is Link link)
                        {
                            if (ValueParticipatesInLink(reference!, link))
                            {
                                if (isDestroyOwnedObjects)
                                {
                                    Value compositeValue =
                                            GetCompositeValue(reference!, link);
                                    if (compositeValue != null)
                                    {
                                        Debug.Println("[destroyObject] Destroying (linked) owned object ...");
                                        DestroyObject(compositeValue, isDestroyLinks,
                                                isDestroyOwnedObjects);
                                    }
                                }
                                if (isDestroyLinks & link.GetTypes().Any())
                                {
                                    link.Destroy();
                                }
                            }
                        }
                    }
                }

                if (isDestroyOwnedObjects)
                {
                    List<FeatureValue> objectFeatureValues = (reference is not null) ?
                            reference.GetFeatureValues() : new List<FeatureValue>();
                    foreach (FeatureValue featureValue in objectFeatureValues)
                    {
                        if ((featureValue.feature as Property)?.aggregation == AggregationKind.composite)
                        {
                            Debug.Println("[destroyObject] Destroying owned objects...");
                            List<Value> values = featureValue.values;
                            foreach (Value ownedValue in values)
                            {
                                DestroyObject(ownedValue, isDestroyLinks,
                                        isDestroyOwnedObjects);
                            }
                        }
                    }
                }

                reference?.Destroy();
            }
        } // destroyObject

	public Value GetCompositeValue(
            Reference reference,
            Link link)
	{
		// If the given reference participates in the given link as a composite,
		// then return the opposite value. Otherwise return null.

		List<FeatureValue> linkFeatureValues = link.GetFeatureValues();

		Value? compositeValue = null;
		int i = 1;
		while (compositeValue is null & i <= linkFeatureValues.Count)
		{
			FeatureValue featureValue = linkFeatureValues.ElementAt(i - 1);
			Value value = featureValue.values.ElementAt(0);
			if (!value.Equals(reference) &
				(featureValue.feature as Property)?.aggregation == AggregationKind.composite)
			{
				compositeValue = value;
			}
			i++;
		}

		return compositeValue!;

	} // objectIsComposite
} // DestroyObjectActionActivation
}
