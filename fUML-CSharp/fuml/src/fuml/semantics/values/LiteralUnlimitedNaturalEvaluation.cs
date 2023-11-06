using fuml.semantics.simpleclassifiers;
using fuml.syntax.values;

namespace fuml.semantics.values
{
    public class LiteralUnlimitedNaturalEvaluation : LiteralEvaluation
    {
        public override Value Evaluate()
        {
            // Evaluate a literal unlimited natural producing an unlimited natural
            // value.

            LiteralUnlimitedNatural literal = (LiteralUnlimitedNatural)specification!;
            UnlimitedNaturalValue unlimitedNaturalValue = new();
            unlimitedNaturalValue.type = GetType("UnlimitedNatural");
            unlimitedNaturalValue.value = literal.value;

            return unlimitedNaturalValue;

        } // evaluate
    } // LiteralUnlimitedNaturalEvaluation
}
