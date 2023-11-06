namespace fuml.syntax.actions
{
    public class ReadStructuralFeatureAction : StructuralFeatureAction
    {
        public OutputPin? result = null;

        public void SetResult(OutputPin result)
        {
            AddOutput(result);
            this.result = result;
        } // setResult
    } // ReadStructuralFeatureAction
}
