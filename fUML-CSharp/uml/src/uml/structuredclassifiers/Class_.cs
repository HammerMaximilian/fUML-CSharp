using uml.classification;
using uml.commonbehavior;
using uml.commonstructure;
using uml.simpleclassifiers;

namespace uml.structuredclassifiers
{
    public class Class_ : BehavioredClassifier
    {
        public List<Operation> ownedOperation = new();
        public bool isActive = false;
        public List<Reception> ownedReception = new();
        public List<Property> ownedAttribute = new();
        public List<Classifier> nestedClassifier = new();
        public bool isID = false;
        public List<Class_> superClass = new();

        public void SetIsActive(bool isActive)
        {
            this.isActive = isActive;
        } // setIsActive

        public override void AddGeneralization(
                Generalization generalization)
        {
            if (generalization is null)
            {
                throw new ArgumentNullException(nameof(generalization));
            }

            base.AddGeneralization(generalization);

            if (generalization.general is Class_ class_)
            {
                superClass.Add(class_);
            }
        } // addGeneralization

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
            ownedAttribute._setClass(this);
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
            ownedOperation._setClass(this);
        } // addOwnedOperation

        public void AddOwnedReception(
                Reception ownedReception)
        {
            AddOwnedMember(ownedReception);
            AddFeature(ownedReception);

            this.ownedReception.Add(ownedReception);
        } // addOwnedReception

        public override List<NamedElement> Inherit(
                List<NamedElement> inhs)
        {
            // "The inherit operation is overridden to exclude redefined properties."

            List<RedefinableElement> redefinableMembers = new();

            for (int i = 0; i < ownedMember.Count; i++)
            {
                if (ownedMember.ElementAt(i) is RedefinableElement redefinableElement)
                {
                    redefinableMembers
                            .Add(redefinableElement);
                }
            }

            List<NamedElement> inherited = new();

            foreach (NamedElement inh in inhs)
            {
                bool exclude = false;
                foreach (RedefinableElement redefinableMember in redefinableMembers)
                {
                    List<RedefinableElement> redefinedElements = redefinableMember.redefinedElement;
                    foreach (RedefinableElement redefinedElement in redefinedElements)
                    {
                        if (redefinedElement == inh)
                        {
                            exclude = true;
                            break;
                        }
                    }
                    if (exclude)
                        break;
                }

                if (!exclude)
                {
                    inherited.Add(inh);
                }
            }

            return inherited;
        } // inherit

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
    }
}
