using fuml.semantics.simpleclassifiers;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using fuml.syntax.actions;
using fuml.syntax.classification;

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

			this.DestroyObject(value, action!.isDestroyLinks,
					action.isDestroyOwnedObjects);

		} // doAction

		public void DestroyObject(Value value,
				bool isDestroyLinks, bool isDestroyOwnedObjects)
		{
			// If the given value is a reference, then destroy the referenced
			// object, per the given destroy action attribute values.

			if (value is Reference) {
				Reference reference = (Reference)value;
				Debug.println("[destroyObject] object = " + reference?.referent?.identifier);

				if (isDestroyLinks | isDestroyOwnedObjects)
				{
					List<ExtensionalValue> extensionalValues = this
							.GetExecutionLocus().extensionalValues;
					foreach (ExtensionalValue extensionalValue in extensionalValues)
					{
						if (extensionalValue is Link) {
						Link link = (Link)extensionalValue;
						if (this.ValueParticipatesInLink(reference!, link))
						{
							if (isDestroyOwnedObjects)
							{
								Value compositeValue =
										this.GetCompositeValue(reference!, link);
								if (compositeValue != null)
								{
									Debug.println("[destroyObject] Destroying (linked) owned object ...");
									this.DestroyObject(compositeValue, isDestroyLinks,
											isDestroyOwnedObjects);
								}
							}
							if (isDestroyLinks & link.GetTypes().Any())
							{
								link.destroy();
							}
						}
					}
				}
			}

			if (isDestroyOwnedObjects)
			{
				List<FeatureValue> objectFeatureValues = (reference is not null) ?
						reference.getFeatureValues() : new List<FeatureValue>();
				foreach (FeatureValue featureValue in objectFeatureValues)
				{
					if ((featureValue.feature as Property)?.aggregation == AggregationKind.composite)
					{
						Debug.println("[destroyObject] Destroying owned objects...");
						List<Value> values = featureValue.values;
						foreach (Value ownedValue in values)
						{
							this.DestroyObject(ownedValue, isDestroyLinks,
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

		List<FeatureValue> linkFeatureValues = link.getFeatureValues();

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
			i = i + 1;
		}

		return compositeValue!;

	} // objectIsComposite
} // DestroyObjectActionActivation
}
