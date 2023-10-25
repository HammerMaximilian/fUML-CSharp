namespace fuml.syntax.actions
{
    public class ConditionalNode : StructuredActivityNode
    {
        public bool isDeterminate = false;
        public bool isAssured = false;
        public List<Clause> clause = new();
        public List<OutputPin> result = new();

        public void setIsDeterminate(bool isDeterminate)
        {
            this.isDeterminate = isDeterminate;
        } // setIsDeterminate

        public void setIsAssured(bool isAssured)
        {
            this.isAssured = isAssured;
        } // setIsAssured

        public void addClause(
                Clause clause)
        {
            addOwnedElement(clause);
            this.clause.Add(clause);
        } // addClause

        public void addResult(OutputPin result)
        {
            addStructuredNodeOutput(result);
            this.result.Add(result);
        } // addResult
    } // ConditionalNode
}
