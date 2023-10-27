namespace fuml.semantics.loci
{
    public abstract class ChoiceStrategy : SemanticStrategy
    {
        public override string getName()
        {
            // The name of a choice strategy is always "choice".

            return "choice";
        } // getName

        public abstract int choose(int size);
    } // ChoiceStrategy
}
