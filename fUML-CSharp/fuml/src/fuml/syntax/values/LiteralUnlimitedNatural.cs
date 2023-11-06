using UMLPrimitiveTypes;

namespace fuml.syntax.values
{
    public class LiteralUnlimitedNatural : LiteralSpecification
    {
        public UnlimitedNatural value = new(0);

        public void SetValue(UnlimitedNatural value)
        {
            this.value = value;
        } // setValue

        public void SetValue(int value)
        {
            SetValue(new UnlimitedNatural(value));
        } // setValue
    }
}
