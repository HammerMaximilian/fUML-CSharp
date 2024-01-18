using uml.classification;
using uml.simpleclassifiers;

namespace uml.commonbehavior
{
    public abstract class BehavioredClassifier : Classifier
    {
        public List<Behavior> ownedBehavior = new();
        public Behavior? classifierBehavior = null;
        public List<InterfaceRealization> interfaceRealization = new(); // PSCS-specific

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

        public void AddInterfaceRealization(InterfaceRealization interfaceRealization) // PSCS-specific
        {
            if (interfaceRealization is null)
            {
                throw new ArgumentNullException(nameof(interfaceRealization));
            }

            this.interfaceRealization.Add(interfaceRealization);
            interfaceRealization._setImplementingClassifier(this);

            AddClientDependency(interfaceRealization);
            AddOwnedElement(interfaceRealization);
        }

    } // BehavioredClassifier
}
