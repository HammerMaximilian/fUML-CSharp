namespace fuml.syntax.actions
{
    public abstract class WriteStructuralFeatureAction : StructuralFeatureAction
    {
        public InputPin? value = null;
        public OutputPin? result = null;

        public virtual void setResult(OutputPin result)
        {
            AddOutput(result);
            this.result = result;
        } // setResult

        public void setValue(InputPin value)
        {
            AddInput(value);
            this.value = value;
        } // setValue
    } // WriteStructuralFeatureAction
}
