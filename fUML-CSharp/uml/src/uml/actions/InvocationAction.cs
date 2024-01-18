using uml.structuredclassifiers;

namespace uml.actions
{
    public abstract class InvocationAction : Action
    {
        public List<InputPin> argument = new();
        public Port? onPort = null; // PSCS-specific

        public void AddArgument(InputPin argument)
        {
            AddInput(argument);
            this.argument.Add(argument);
        } // addArgument

        public void SetOnPort(Port onPort) // PSCS-specific
        { 
            this.onPort = onPort ?? throw new ArgumentNullException(nameof(onPort)); 
        }
    } // InvocationAction
}
