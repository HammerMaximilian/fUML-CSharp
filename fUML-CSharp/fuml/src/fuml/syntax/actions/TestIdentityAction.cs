namespace fuml.syntax.actions
{
    public class TestIdentityAction : Action
    {
        public InputPin? second = null;
        public OutputPin? result = null;
        public InputPin? first = null;

        public void setFirst(InputPin first)
        {
            AddInput(first);
            this.first = first;
        } // setFirst

        public void setSecond(InputPin second)
        {
            AddInput(second);
            this.second = second;
        } // setSecond

        public void setResult(OutputPin result)
        {
            AddOutput(result);
            this.result = result;
        } // setResult
    } // TestIdentityAction
}
