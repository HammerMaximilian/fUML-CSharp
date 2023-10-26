using fuml.syntax.simpleclassifiers;

namespace fuml.semantics.values
{
    public abstract class LiteralEvaluation : Evaluation
    {
        public PrimitiveType getType(
        string builtInTypeName)
        {
            // Get the type of the specification. If that is null, then use the
            // built-in type of the given name.

            PrimitiveType type = (PrimitiveType)specification?.type!;

            if (type is null)
            {
                type = locus.factory.getBuiltInType(builtInTypeName);
            }

            return type;
        } // getType
    } // LiteralEvaluation
}
