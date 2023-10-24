using fuml.syntax.classification;

namespace fuml.syntax.commonbehavior
{
    public abstract class BehavioredClassifier : Classifier
    {
        public List<Behavior> ownedBehavior = new();
        public Behavior? classifierBehavior = null;

        public void addOwnedBehavior(
                Behavior ownedBehavior)
        {
            if (ownedBehavior is null)
            {
                throw new ArgumentNullException(nameof(ownedBehavior));
            }

            addOwnedMember(ownedBehavior);

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

        public void setClassifierBehavior(
                Behavior classifierBehavior)
        {
            // Note: The classifier behavior must also be added as an owned behavior
            // using addOwnedBehavior.

            this.classifierBehavior = classifierBehavior ?? throw new ArgumentNullException(nameof(classifierBehavior));
        } // setClassifierBehavior
    } // BehavioredClassifier
}
