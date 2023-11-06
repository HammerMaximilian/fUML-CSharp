using fuml.semantics.simpleclassifiers;
using fuml.syntax.values;

namespace fuml.semantics.values
{
    public class LiteralBooleanEvaluation : LiteralEvaluation
    {
        public override Value Evaluate()
        {
            // Evaluate a literal boolean, producing a boolean value.

            LiteralBoolean literal = (LiteralBoolean)specification!;
            BooleanValue booleanValue = new();
            booleanValue.type = GetType("Boolean");
            booleanValue.value = literal.value;

            return booleanValue;

        } // evaluate
    } // LiteralBooleanEvaluation
}
