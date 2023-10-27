namespace fuml.syntax.actions
{
    public class ReadSelfAction : Action
    {
        public OutputPin? result = null;

        public void setResult(OutputPin result)
        {
            AddOutput(result);
            this.result = result;
        } // setResult
    } // ReadSelfAction
}
