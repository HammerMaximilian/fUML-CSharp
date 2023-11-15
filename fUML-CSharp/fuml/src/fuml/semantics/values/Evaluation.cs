using fuml.semantics.loci;
using uml.values;

namespace fuml.semantics.values
{
    public abstract class Evaluation : SemanticVisitor
    {
        public ValueSpecification? specification = null;
        public Locus? locus = null;

        public abstract Value Evaluate();
    } // Evaluation
}
