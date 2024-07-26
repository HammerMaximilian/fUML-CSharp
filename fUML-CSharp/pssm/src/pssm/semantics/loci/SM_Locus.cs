using fuml.semantics.structuredclassifiers;
using pscs.semantics.loci;
using pssm.semantics.structuredclassifiers;
using uml.commonbehavior;
using uml.structuredclassifiers;

namespace pssm.semantics.loci
{
    public class SM_Locus : CS_Locus
    {
        public override Object_ Instantiate(Class_ type)
        {
            // Behaves like in fUML except that type instance are not
            // Object_ but SM_Object.
            Object_? object_;
            if (type is Behavior)
            {
                object_ = base.Instantiate(type);
            }
            else
            {
                object_ = new SM_Object();
                object_.types.Add(type);
                object_.CreateFeatureValues();
                Add(object_);
            }
            return object_;
        }
    } // SM_Locus
}
