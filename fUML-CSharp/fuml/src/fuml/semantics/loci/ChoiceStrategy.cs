namespace fuml.semantics.loci
{
    public abstract class ChoiceStrategy : SemanticStrategy
    {
        public override string GetName()
        {
            // The name of a choice strategy is always "choice".

            return "choice";
        } // getName

        public abstract int Choose(int size);
    } // ChoiceStrategy
}
