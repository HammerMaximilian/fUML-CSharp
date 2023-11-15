using uml.classification;

namespace uml.commonbehavior
{
    public abstract class BehavioredClassifier : Classifier
    {
        public List<Behavior> ownedBehavior = new();
        public Behavior? classifierBehavior = null;

        public void AddOwnedBehavior(
                Behavior ownedBehavior)
        {
            if (ownedBehavior is null)
            {
                throw new ArgumentNullException(nameof(ownedBehavior));
            }

            AddOwnedMember(ownedBehavior);

            this.ownedBehavior.Add(ownedBehavior);

            if (this is Behavior && (this as Behavior)!.context is not null)
            {
                ownedBehavior._setContext((this as Behavior)!.context!);
            }
            else
            {
                ownedBehavior._setContext(this);
            }
        } // addOwnedBehavior

        public void SetClassifierBehavior(
                Behavior classifierBehavior)
        {
            // Note: The classifier behavior must also be added as an owned behavior
            // using addOwnedBehavior.

            this.classifierBehavior = classifierBehavior ?? throw new ArgumentNullException(nameof(classifierBehavior));
        } // setClassifierBehavior
    } // BehavioredClassifier
}
