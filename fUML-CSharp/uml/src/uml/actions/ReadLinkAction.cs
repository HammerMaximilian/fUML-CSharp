namespace uml.actions
{
    public class ReadLinkAction : LinkAction
    {
        public OutputPin? result = null;

        public void SetResult(OutputPin result)
        {
            AddOutput(result);
            this.result = result;
        } // setResult
    } // ReadLinkAction
}
