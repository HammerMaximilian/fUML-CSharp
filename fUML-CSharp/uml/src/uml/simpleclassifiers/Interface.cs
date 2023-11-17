using uml.classification;

namespace uml.simpleclassifiers
{
    public class Interface : Classifier // PSCS-specific
    {
        public List<Classifier> nestedClassifier = new();
        public List<Property> ownedAttribute = new();
        public List<Operation> ownedOperation = new();
        public List<Reception> ownedReception = new();
        public List<Interface> redefinedInterface = new();

        public void AddNestedClassifier(
        Classifier nestedClassifier)
        {
            if (nestedClassifier is null)
            {
                throw new ArgumentNullException(nameof(nestedClassifier));
            }

            AddOwnedMember(nestedClassifier);
            this.nestedClassifier.Add(nestedClassifier);
        } // addNestedClassifier

        public void AddOwnedAttribute(
        Property ownedAttribute)
        {
            if (ownedAttribute is null)
            {
                throw new ArgumentNullException(nameof(ownedAttribute));
            }

            AddAttribute(ownedAttribute);
            AddOwnedMember(ownedAttribute);

            this.ownedAttribute.Add(ownedAttribute);
            ownedAttribute._setInterface(this);
        } // addOwnedAttribute

        public void AddOwnedOperation(
        Operation ownedOperation)
        {
            if (ownedOperation is null)
            {
                throw new ArgumentNullException(nameof(ownedOperation));
            }

            AddFeature(ownedOperation);
            AddOwnedMember(ownedOperation);

            this.ownedOperation.Add(ownedOperation);
            ownedOperation._setInterface(this);
        } // addOwnedOperation

        public void AddOwnedReception(
        Reception ownedReception)
        {
            if (ownedReception is null)
            {
                throw new ArgumentNullException(nameof(ownedReception));
            }

            AddFeature(ownedReception);
            AddOwnedMember(ownedReception);

            this.ownedReception.Add(ownedReception);
        } // addOwnedReception

        public void AddRedefinedInterface(
        Interface redefinedInterface)
        {
            if (redefinedInterface is null)
            {
                throw new ArgumentNullException(nameof(redefinedInterface));
            }
            this.redefinedInterface.Add(redefinedInterface);
        } // addNestedClassifier
    } // Interface
}
