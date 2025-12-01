namespace uml.actions
{
    public class ReadVariableAction : VariableAction
    {
        public OutputPin? result = null;

        public void SetResult(OutputPin result)
        {
            AddOutput(result);
            this.result = result;
        } // SetResult
    } // ReadVariableAction
}
