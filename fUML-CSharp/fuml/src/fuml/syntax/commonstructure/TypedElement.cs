namespace fuml.syntax.commonstructure
{
    public class TypedElement : NamedElement
    {
        public Type? type = null;

        public void setType(Type type)
        {
            if (type is null)
            {
                throw new ArgumentNullException(nameof(type));
            }
            this.type = type;
        } // setType
    }
}
