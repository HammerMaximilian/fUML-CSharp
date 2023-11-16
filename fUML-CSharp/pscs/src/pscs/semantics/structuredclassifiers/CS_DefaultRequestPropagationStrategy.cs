using fuml.semantics.actions;
using fuml.semantics.loci;
using fuml.semantics.structuredclassifiers;

namespace pscs.semantics.structuredclassifiers
{
    public class CS_DefaultRequestPropagationStrategy : CS_RequestPropagationStrategy
    {
        public override List<Reference> select(List<Reference> potentialTargets, SemanticVisitor context)
        {
            // returns all potential targets in the case where the context is a SendSignalActionActivation
            // returns the first potential target in the case where the context is anything else
            List<Reference> selectedTargets = new();
            if (context is SendSignalActionActivation)
            {
                foreach (Reference potentialTarget in potentialTargets)
                {
                    selectedTargets.Add(potentialTarget);
                }
            }
            else
            {
                if (potentialTargets.Count >= 1)
                {
                    selectedTargets.Add(potentialTargets.ElementAt(0));
                }
            }
            return selectedTargets;
        }
    } // CS_DefaultRequestPropagationStrategy
}
