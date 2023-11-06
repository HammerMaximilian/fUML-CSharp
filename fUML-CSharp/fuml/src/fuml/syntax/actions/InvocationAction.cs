namespace fuml.syntax.actions
{
    public abstract class InvocationAction : Action
    {
        public List<InputPin> argument = new();

        public void AddArgument(InputPin argument)
        {
            AddInput(argument);
            this.argument.Add(argument);
        } // addArgument
    } // InvocationAction
}
