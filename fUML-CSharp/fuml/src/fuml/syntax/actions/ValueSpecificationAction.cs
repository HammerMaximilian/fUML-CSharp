using fuml.syntax.values;

namespace fuml.syntax.actions
{
    public class ValueSpecificationAction : Action
    {
        public ValueSpecification? value = null;
        public OutputPin? result = null;

        public void setValue(ValueSpecification value)
        {
            this.value = value ?? throw new ArgumentNullException(nameof(value));
        } // setValue

        public void setResult(OutputPin result)
        {
            addOutput(result);
            this.result = result;
        } // setResult
    } // ValueSpecificationAction
}
