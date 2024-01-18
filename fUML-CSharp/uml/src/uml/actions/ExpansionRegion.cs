namespace uml.actions
{
    public class ExpansionRegion : StructuredActivityNode
    {
        public ExpansionKind mode = ExpansionKind.iterative;
        public List<ExpansionNode> outputElement = new();
        public List<ExpansionNode> inputElement = new();

        public void SetMode(
                ExpansionKind mode)
        {
            this.mode = mode;
        } // setMode

        public void AddInputElement(
                ExpansionNode inputElement)
        {
            if (inputElement is null)
            {
                throw new ArgumentNullException(nameof(inputElement));
            }

            this.inputElement.Add(inputElement);
            inputElement._setRegionAsInput(this);
        } // addInputElement

        public void AddOutputElement(
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
