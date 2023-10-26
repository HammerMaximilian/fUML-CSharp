using fuml.semantics.simpleclassifiers;
using fuml.syntax.values;

namespace fuml.semantics.values
{
    public class LiteralStringEvaluation : LiteralEvaluation
    {
        public override Value evaluate()
        {
            // Evaluate a literal string, producing a string value.

            LiteralString literal = (LiteralString)specification!;
            StringValue stringValue = new();
            stringValue.type = getType("String");
            stringValue.value = literal.value;

            return stringValue;
        } // evaluate
    } // LiteralStringEvaluation
}
