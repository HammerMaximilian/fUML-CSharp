namespace uml.actions
{
    public class WriteVariableAction : VariableAction
    {
        public InputPin? value = null;

        public void SetValue(InputPin value)
        {
            AddInput(value);
            this.value = value;
        } // SetValue
    } // WriteVariableAction
}
