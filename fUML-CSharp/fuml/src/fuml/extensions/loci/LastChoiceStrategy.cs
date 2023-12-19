using fuml.semantics.loci;

namespace fuml.extensions.loci
{
    public class LastChoiceStrategy : ChoiceStrategy
    {
        public override int Choose(int size)
        {
            // Always choose size.

            return size;
        } // choose
    } // LastChoiceStrategy
}
