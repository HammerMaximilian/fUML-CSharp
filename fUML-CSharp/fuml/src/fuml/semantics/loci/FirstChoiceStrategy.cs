namespace fuml.semantics.loci
{
    public class FirstChoiceStrategy : ChoiceStrategy
    {
        public override int choose(int size)
        {
            // Always choose one.

            return 1;
        } // choose
    } // FirstChoiceStrategy
}
