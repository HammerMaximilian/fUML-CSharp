using fuml.semantics.loci;
using fuml.semantics.structuredclassifiers;
using pscs.semantics.structuredclassifiers;
using uml.commonbehavior;
using uml.structuredclassifiers;

namespace pscs.semantics.loci
{
    public class CS_Locus : Locus
    {
        public override Object_ Instantiate(Class_ type)
        {
            // Extends fUML semantics by instantiating a CS_Object
            // in the case where type is not a Behavior.
            // Otherwise behaves like in fUML
            Object_ object_;
            if (type is Behavior) {
                object_ = base.Instantiate(type);
            } else
            {
                object_ = new CS_Object();
                object_.types.Add(type);
                object_.CreateFeatureValues();
                Add(object_);
            }
            return object_;
        }
    } // CS_Locus
}
