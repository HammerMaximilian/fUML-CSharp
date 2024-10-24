
using uml.packages;

namespace uml.commonstructure
{
    public abstract class Element : UMLObject
    {
        public List<Element> ownedElement = new();
        public Element? owner;
        public List<Comment> ownedComment = new();
        public List<Stereotype> appliedStereotype = new(); // PSCS-specific, Stereotypes are required in PSCS
        public List<Constraint> constraint = new();

        protected void AddOwnedElement(
        Element ownedElement)
        {
            if (ownedElement is null)
            {
                throw new ArgumentNullException(nameof(ownedElement));
            }

            this.ownedElement.Add(ownedElement);
            ownedElement.owner = this;
        } // addOwnedElement

        public void ApplyStereotype(Stereotype stereotype) // PSCS-specific, Stereotypes are required in PSCS
        {
            if (stereotype is null)
            {
                throw new ArgumentNullException(nameof(stereotype));
            }

            if(!appliedStereotype.Contains(stereotype))
            {
                appliedStereotype.Add(stereotype);
            }
        }

        public void UnapplyStereotype(Stereotype stereotype) // PSCS-specific, Stereotypes are required in PSCS
        {
            appliedStereotype.Remove(stereotype);
        }

    } // Element
}
