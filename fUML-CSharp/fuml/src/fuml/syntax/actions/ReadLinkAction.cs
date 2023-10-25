namespace fuml.syntax.actions
{
    public class ReadLinkAction : LinkAction
    {
        public OutputPin? result = null;

        public void setResult(OutputPin result)
        {
            addOutput(result);
            this.result = result;
        } // setResult
    } // ReadLinkAction
}
