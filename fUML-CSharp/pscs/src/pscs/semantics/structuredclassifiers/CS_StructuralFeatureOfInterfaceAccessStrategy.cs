using fuml.semantics.loci;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;
using uml.classification;

namespace pscs.semantics.structuredclassifiers
{
    public abstract class CS_StructuralFeatureOfInterfaceAccessStrategy : SemanticStrategy
    {
        public override string GetName()
        {
            // StructuralFeatureAccessStrategy are always named "structuralFeature"
            return "structuralFeature";
        }
        public abstract FeatureValue Read(CS_Object cs_Object, StructuralFeature feature);
        public abstract void Write(CS_Object cs_Object, StructuralFeature feature, List<Value> values, int position);
    } // CS_StructuralFeatureOfInterfaceAccessStrategy
}
