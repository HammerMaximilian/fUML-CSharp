using fuml.semantics.loci;

namespace pscs.semantics.actions
{
    public abstract class CS_ConstructStrategy : SemanticStrategy
    {
        public override string GetName()
        {
            // a CS_ConstructionStrategy is always named "constructStrategy"
            return "constructStrategy";
        }
    } // CS_ConstructStrategy
}
