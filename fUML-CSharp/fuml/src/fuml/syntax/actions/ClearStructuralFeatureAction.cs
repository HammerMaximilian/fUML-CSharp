namespace fuml.syntax.actions
{
    public class ClearStructuralFeatureAction : StructuralFeatureAction
    {
        public OutputPin? result = null;

        public void setResult(OutputPin result)
        {
            AddOutput(result);
            this.result = result;
        } // setResult
    } // ClearStructuralFeatureAction
}
