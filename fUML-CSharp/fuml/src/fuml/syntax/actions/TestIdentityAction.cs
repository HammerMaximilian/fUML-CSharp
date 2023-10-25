namespace fuml.syntax.actions
{
    public class TestIdentityAction : Action
    {
        public InputPin? second = null;
        public OutputPin? result = null;
        public InputPin? first = null;

        public void setFirst(InputPin first)
        {
            addInput(first);
            this.first = first;
        } // setFirst

        public void setSecond(InputPin second)
        {
            addInput(second);
            this.second = second;
        } // setSecond

        public void setResult(OutputPin result)
        {
            addOutput(result);
            this.result = result;
        } // setResult
    } // TestIdentityAction
}
