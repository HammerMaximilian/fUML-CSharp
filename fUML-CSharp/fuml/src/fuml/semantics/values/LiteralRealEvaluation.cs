using fuml.semantics.simpleclassifiers;
using fuml.syntax.values;

namespace fuml.semantics.values
{
    public class LiteralRealEvaluation : LiteralEvaluation
    {
        public override Value evaluate()
        {
            // Evaluate a real integer, producing a real value.

            LiteralReal literal = (LiteralReal)specification!;
            RealValue realValue = new();
            realValue.type = GetType("Real");
            realValue.value = literal.value;
            return realValue;
        } // evaluate
    } // LiteralRealEvaluation
}
