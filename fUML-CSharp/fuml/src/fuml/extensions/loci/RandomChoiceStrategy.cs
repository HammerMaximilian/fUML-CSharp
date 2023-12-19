using fuml.semantics.loci;

namespace fuml.extensions.loci
{
    public class RandomChoiceStrategy : ChoiceStrategy
    {
        private static readonly Random random = new();
        public override int Choose(int size)
        {
            // Randomely choose a value between 1 and size.

            return random.Next(1, size + 1);
        } // choose
    } // RandomChoiceStrategy
}
