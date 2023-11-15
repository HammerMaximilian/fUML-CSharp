using fuml.semantics.simpleclassifiers;
using uml.values;

namespace fuml.semantics.values
{
    public class LiteralStringEvaluation : LiteralEvaluation
    {
        public override Value Evaluate()
        {
            // Evaluate a literal string, producing a string value.

            LiteralString literal = (LiteralString)specification!;
            StringValue stringValue = new();
            stringValue.type = GetType("String");
            stringValue.value = literal.value;

            return stringValue;
        } // evaluate
    } // LiteralStringEvaluation
}
