namespace fuml.syntax.values
{
    public class LiteralReal : LiteralSpecification
    {
        public float value = 0.0f;

        public void SetValue(float value)
        {
            this.value = value;
        } // setValue
    } // LiteralReal
}
