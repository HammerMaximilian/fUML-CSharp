namespace fuml.syntax.actions
{
    public class TestIdentityAction : Action
    {
        public InputPin? second = null;
        public OutputPin? result = null;
        public InputPin? first = null;

        public void SetFirst(InputPin first)
        {
            AddInput(first);
            this.first = first;
        } // setFirst

        public void SetSecond(InputPin second)
        {
            AddInput(second);
            this.second = second;
        } // setSecond

        public void SetResult(OutputPin result)
        {
            AddOutput(result);
            this.result = result;
        } // setResult
    } // TestIdentityAction
}
