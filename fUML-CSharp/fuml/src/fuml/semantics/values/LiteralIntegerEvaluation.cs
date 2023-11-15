using fuml.semantics.simpleclassifiers;
using uml.values;

namespace fuml.semantics.values
{
    public class LiteralIntegerEvaluation : LiteralEvaluation
    {
        public override Value Evaluate()
        {
            // Evaluate a literal integer, producing an integer value.

            LiteralInteger literal = (LiteralInteger)specification!;
            IntegerValue integerValue = new();
            integerValue.type = GetType("Integer");
            integerValue.value = literal.value;

            return integerValue;

        } // evaluate
    } // LiteralIntegerEvaluation
}
