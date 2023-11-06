namespace fuml.semantics.values
{
    public class LiteralNullEvaluation : LiteralEvaluation
    {
        public override Value Evaluate()
        {
            // Evaluate a literal null, returning nothing (since a null represents
            // an "absence of any value").

            return null!;
        } // evaluate
    } // LiteralNullEvaluation
}
