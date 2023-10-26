namespace fuml.syntax.values
{
    public class LiteralString : LiteralSpecification
    {
        public string value = "";

        public void setValue(string value)
        {
            this.value = value;
        } // setValue
    } // LiteralString
}
