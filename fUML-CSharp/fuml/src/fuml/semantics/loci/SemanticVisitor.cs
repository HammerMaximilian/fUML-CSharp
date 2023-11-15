namespace fuml.semantics.loci
{
    public abstract class SemanticVisitor
    {
        public static void _endIsolation()
        {
            Debug.Println("[_endIsolation] End isolation.");
        } // _endIsolation

        public static void _beginIsolation()
        {
            Debug.Println("[_beginIsolation] Begin isolation.");
        } // _beginIsolation
    } // SemanticVisitor
}
