using fuml.syntax.commonstructure;

namespace fuml.syntax.activities
{
    public abstract class ObjectNode : ActivityNode
    {
        public TypedElement typedElement = new();

        public void SetType(commonstructure.Type type)
        {
            if (type is null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            typedElement.type = type;
        } // setType
    } // ObjectNode
}
