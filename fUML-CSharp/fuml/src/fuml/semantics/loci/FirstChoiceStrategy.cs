namespace fuml.semantics.loci
{
    public class FirstChoiceStrategy : ChoiceStrategy
    {
        public override int Choose(int size)
        {
            // Always choose one.

            return 1;
        } // choose
    } // FirstChoiceStrategy
}
