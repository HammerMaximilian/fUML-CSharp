using fuml.semantics.actions;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;
using pscs.semantics.structuredclassifiers;
using uml.classification;

namespace pscs.semantics.actions
{
    public class CS_ClearStructuralFeatureValueActionActivation : ClearStructuralFeatureActionActivation
    {
        public override void DoAction()
        { throw new NotImplementedException(); }

        public List<CS_Link> GetLinksToDestroy(StructuredValue value, StructuralFeature feature)
        { throw new NotImplementedException(); }

        public List<Value> GetPotentialLinkEnds(CS_Reference context, StructuralFeature feature)
        { throw new NotImplementedException(); }
    } // CS_ClearStructuralFeatureValueActionActivation
}
