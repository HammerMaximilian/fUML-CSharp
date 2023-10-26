using fuml.semantics.simpleclassifiers;
using fuml.syntax.values;

namespace fuml.semantics.values
{
    public class LiteralIntegerEvaluation : LiteralEvaluation
    {
        public override Value evaluate()
        {
            // Evaluate a literal integer, producing an integer value.

            LiteralInteger literal = (LiteralInteger)specification!;
            IntegerValue integerValue = new();
            integerValue.type = getType("Integer");
            integerValue.value = literal.value;

            return integerValue;

        } // evaluate
    } // LiteralIntegerEvaluation
}
