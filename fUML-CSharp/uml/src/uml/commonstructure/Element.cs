
namespace uml.commonstructure
{
    public abstract class Element
    {
        public List<Element> ownedElement = new();
        public Element? owner;
        public List<Comment> ownedComment = new();

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

    } // Element
}
