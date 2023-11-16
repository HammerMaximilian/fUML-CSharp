using fuml.semantics.loci;
using fuml.semantics.structuredclassifiers;

namespace pscs.semantics.structuredclassifiers
{
    public abstract class CS_RequestPropagationStrategy : SemanticStrategy
    {
        public override string GetName()
        {
            // a CS_RequestPropagationStrategy are always named "requestPropagation"
            return "requestPropagation";
        }

        public abstract List<Reference> select(List<Reference> potentialTargets, SemanticVisitor context);
    } // CS_RequestPropagationStrategy
}
