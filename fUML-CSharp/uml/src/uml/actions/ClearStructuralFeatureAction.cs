namespace uml.actions
{
    public class ClearStructuralFeatureAction : StructuralFeatureAction
    {
        public OutputPin? result = null;

        public void SetResult(OutputPin result)
        {
            AddOutput(result);
            this.result = result;
        } // setResult
    } // ClearStructuralFeatureAction
}
