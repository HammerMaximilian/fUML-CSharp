namespace fuml.syntax.actions
{
    public class ReadStructuralFeatureAction : StructuralFeatureAction
    {
        public OutputPin? result = null;

        public void setResult(OutputPin result)
        {
            AddOutput(result);
            this.result = result;
        } // setResult
    } // ReadStructuralFeatureAction
}
