using fuml.syntax.classification;
using fuml.syntax.commonbehavior;
using fuml.syntax.commonstructure;
using fuml.syntax.simpleclassifiers;

namespace fuml.syntax.structuredclassifiers
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

        public void setIsActive(bool isActive)
        {
            this.isActive = isActive;
        } // setIsActive

        public override void addGeneralization(
                Generalization generalization)
        {
            if (generalization is null)
            {
                throw new ArgumentNullException(nameof(generalization));
            }

            base.addGeneralization(generalization);

            if (generalization.general is Class_)
            {
                superClass.Add((Class_)generalization.general);
            }
        } // addGeneralization

        public void addOwnedAttribute(
                Property ownedAttribute)
        {
            if (ownedAttribute is null)
            {
                throw new ArgumentNullException(nameof(ownedAttribute));
            }

            addAttribute(ownedAttribute);
            addOwnedMember(ownedAttribute);

            this.ownedAttribute.Add(ownedAttribute);
            ownedAttribute._setClass(this);
        } // addOwnedAttribute

        public void addOwnedOperation(
                Operation ownedOperation)
        {
            if (ownedOperation is null)
            {
                throw new ArgumentNullException(nameof(ownedOperation));
            }

            addFeature(ownedOperation);
            addOwnedMember(ownedOperation);

            this.ownedOperation.Add(ownedOperation);
            ownedOperation._setClass(this);
        } // addOwnedOperation

        public void addOwnedReception(
                Reception ownedReception)
        {
            addOwnedMember(ownedReception);
            addFeature(ownedReception);

            this.ownedReception.Add(ownedReception);
        } // addOwnedReception

        public override List<NamedElement> inherit(
                List<NamedElement> inhs)
        {
            // "The inherit operation is overridden to exclude redefined properties."

            List<RedefinableElement> redefinableMembers = new();

            for (int i = 0; i < ownedMember.Count(); i++)
            {
                if (ownedMember.ElementAt(i) is RedefinableElement)
                {
                    redefinableMembers
                            .Add((RedefinableElement)this.ownedMember
                                    .ElementAt(i));
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

        public void addNestedClassifier(
                Classifier nestedClassifier)
        {
            if (nestedClassifier is null)
            {
                throw new ArgumentNullException(nameof(nestedClassifier));
            }

            addOwnedMember(nestedClassifier);
            this.nestedClassifier.Add(nestedClassifier);
        } // addNestedClassifier
    }
}
