namespace uml.values
{
    public class Expression : ValueSpecification // PSSM-specific
    {
        public string symbol = "";

        public List<ValueSpecification> operand = new();
    } // Expression
}
