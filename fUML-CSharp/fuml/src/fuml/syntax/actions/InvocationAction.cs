namespace fuml.syntax.actions
{
    public abstract class InvocationAction : Action
    {
        public List<InputPin> argument = new();

        public void addArgument(InputPin argument)
        {
            addInput(argument);
            this.argument.Add(argument);
        } // addArgument
    } // InvocationAction
}
