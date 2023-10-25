namespace fuml.syntax.actions
{
    public abstract class WriteStructuralFeatureAction : StructuralFeatureAction
    {
        public InputPin? value = null;
        public OutputPin? result = null;

        public virtual void setResult(OutputPin result)
        {
            addOutput(result);
            this.result = result;
        } // setResult

        public void setValue(InputPin value)
        {
            addInput(value);
            this.value = value;
        } // setValue
    } // WriteStructuralFeatureAction
}
