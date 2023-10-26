namespace fuml.syntax.values
{
    public class LiteralBoolean : LiteralSpecification
    {
        public bool value = false;

        public void setValue(bool value)
        {
            this.value = value;
        } // setValue
    } // LiteralBoolean
}
