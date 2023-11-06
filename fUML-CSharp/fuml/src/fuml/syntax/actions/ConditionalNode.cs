namespace fuml.syntax.actions
{
    public class ConditionalNode : StructuredActivityNode
    {
        public bool isDeterminate = false;
        public bool isAssured = false;
        public List<Clause> clause = new();
        public List<OutputPin> result = new();

        public void SetIsDeterminate(bool isDeterminate)
        {
            this.isDeterminate = isDeterminate;
        } // setIsDeterminate

        public void SetIsAssured(bool isAssured)
        {
            this.isAssured = isAssured;
        } // setIsAssured

        public void AddClause(
                Clause clause)
        {
            AddOwnedElement(clause);
            this.clause.Add(clause);
        } // addClause

        public void AddResult(OutputPin result)
        {
            AddStructuredNodeOutput(result);
            this.result.Add(result);
        } // addResult
    } // ConditionalNode
}
