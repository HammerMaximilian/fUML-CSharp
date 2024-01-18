namespace uml.actions
{
    public abstract class WriteStructuralFeatureAction : StructuralFeatureAction
    {
        public InputPin? value = null;
        public OutputPin? result = null;

        public virtual void SetResult(OutputPin result)
        {
            AddOutput(result);
            this.result = result;
        } // setResult

        public void SetValue(InputPin value)
        {
            AddInput(value);
            this.value = value;
        } // setValue
    } // WriteStructuralFeatureAction
}
