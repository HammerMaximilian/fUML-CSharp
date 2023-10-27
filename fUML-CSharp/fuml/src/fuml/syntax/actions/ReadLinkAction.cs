namespace fuml.syntax.actions
{
    public class ReadLinkAction : LinkAction
    {
        public OutputPin? result = null;

        public void setResult(OutputPin result)
        {
            AddOutput(result);
            this.result = result;
        } // setResult
    } // ReadLinkAction
}
