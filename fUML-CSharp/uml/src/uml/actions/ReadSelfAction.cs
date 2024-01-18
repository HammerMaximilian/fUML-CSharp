namespace uml.actions
{
    public class ReadSelfAction : Action
    {
        public OutputPin? result = null;

        public void SetResult(OutputPin result)
        {
            AddOutput(result);
            this.result = result;
        } // setResult
    } // ReadSelfAction
}
