namespace fuml.syntax.actions
{
    public class ExpansionRegion : StructuredActivityNode
    {
        public ExpansionKind mode = ExpansionKind.iterative;
        public List<ExpansionNode> outputElement = new();
        public List<ExpansionNode> inputElement = new();

        public void setMode(
                ExpansionKind mode)
        {
            this.mode = mode;
        } // setMode

        public void addInputElement(
                ExpansionNode inputElement)
        {
            if (inputElement is null)
            {
                throw new ArgumentNullException(nameof(inputElement));
            }

            this.inputElement.Add(inputElement);
            inputElement._setRegionAsInput(this);
        } // addInputElement

        public void addOutputElement(
                ExpansionNode outputElement)
        {
            if (outputElement is null)
            {
                throw new ArgumentNullException(nameof(outputElement));
            }

            this.outputElement.Add(outputElement);
            outputElement._setRegionAsOutput(this);
        } // addOutputElement
    } // ExpansionRegion
}
