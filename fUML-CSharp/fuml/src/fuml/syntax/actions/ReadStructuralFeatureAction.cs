namespace fuml.syntax.actions
{
    public class ReadStructuralFeatureAction : StructuralFeatureAction
    {
        public OutputPin? result = null;

        public void setResult(OutputPin result)
        {
            addOutput(result);
            this.result = result;
        } // setResult
    } // ReadStructuralFeatureAction
}
