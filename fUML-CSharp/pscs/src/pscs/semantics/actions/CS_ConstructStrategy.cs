using fuml.semantics.loci;
using fuml.semantics.structuredclassifiers;
using pscs.semantics.structuredclassifiers;
using uml.classification;

namespace pscs.semantics.actions
{
    public abstract class CS_ConstructStrategy : SemanticStrategy
    {
        public override string GetName()
        {
            // a CS_ConstructionStrategy is always named "constructStrategy"
            return "constructStrategy";
        }

        public abstract Object_ Construct(Operation constructor, CS_Object context);

    } // CS_ConstructStrategy
}
