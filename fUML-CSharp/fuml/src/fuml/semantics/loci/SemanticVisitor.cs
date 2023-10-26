namespace fuml.semantics.loci
{
    public abstract class SemanticVisitor : FumlObject
    {
        public static void _endIsolation()
        {
            Debug.println("[_endIsolation] End isolation.");
        } // _endIsolation

        public static void _beginIsolation()
        {
            Debug.println("[_beginIsolation] Begin isolation.");
        } // _beginIsolation
    } // SemanticVisitor
}
