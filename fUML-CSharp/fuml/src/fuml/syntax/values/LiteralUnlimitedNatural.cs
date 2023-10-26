using UMLPrimitiveTypes;

namespace fuml.syntax.values
{
    public class LiteralUnlimitedNatural : LiteralSpecification
    {
        public UnlimitedNatural value = new(0);

        public void setValue(UnlimitedNatural value)
        {
            this.value = value;
        } // setValue

        public void setValue(int value)
        {
            setValue(new UnlimitedNatural(value));
        } // setValue
    }
}
