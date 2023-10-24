using fuml.syntax.commonstructure;

namespace fuml.syntax.classification
{
    public abstract class RedefinableElement : NamedElement
    {
        public bool isLeaf = false;
        public List<RedefinableElement> redefinedElement = new();
        public List<Classifier> redefinitionContext = new();

        public void setIsLeaf(bool isLeaf)
        {
            this.isLeaf = isLeaf;
        } // setIsLeaf

        protected void addRedefinedElement(
                RedefinableElement redefinedElement)
        {
            if (redefinedElement is null)
            {
                throw new ArgumentNullException(nameof(redefinedElement));
            }

            this.redefinedElement.Add(redefinedElement);
        } // addRedefinedElement

        protected void addRedefinitionContext(
                Classifier redefinitionContext)
        {
            if (redefinitionContext is null)
            {
                throw new ArgumentNullException(nameof(redefinitionContext));
            }

            this.redefinitionContext.Add(redefinitionContext);
        } // addRedefinitionContext
    } // RedefinableElement
}
