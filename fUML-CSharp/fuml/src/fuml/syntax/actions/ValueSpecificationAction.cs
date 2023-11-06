using fuml.syntax.values;

namespace fuml.syntax.actions
{
    public class ValueSpecificationAction : Action
    {
        public ValueSpecification? value = null;
        public OutputPin? result = null;

        public void SetValue(ValueSpecification value)
        {
            this.value = value ?? throw new ArgumentNullException(nameof(value));
        } // setValue

        public void SetResult(OutputPin result)
        {
            AddOutput(result);
            this.result = result;
        } // setResult
    } // ValueSpecificationAction
}
