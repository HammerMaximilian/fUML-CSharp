using fuml;
using fuml.semantics.commonbehavior;
using fuml.semantics.loci;
using fuml.semantics.structuredclassifiers;
using pscs.semantics.structuredclassifiers;
using uml.structuredclassifiers;

namespace pscs.semantics.loci
{
    public class CS_Executor : Executor
    {
        public override Reference Start(Class_ type, List<ParameterValue> inputs)
        {
            // Instantiate the given class and start any behavior of the resulting
            // object.
            // (The behavior of an object includes any classifier behaviors for an
            // active object or the class of the object itself, if that is a
            // behavior.)
            // fUML semantics is extended in the sense that when the instantiated object
            // is a CS_Object, a CS_Reference is returned (instead of a Reference)
            Debug.Println("[start] Starting " + type.name + "...");
            Object_ object_ = locus?.Instantiate(type)!;
            Debug.Println("[start] Object = " + object_);
            object_.StartBehavior(type, inputs);
            Reference reference;
            if (object_ is CS_Object cS_Object)
            {
                reference = new();
                ((CS_Reference)reference).compositeReferent = cS_Object;
            }
            else
            {
                reference = new Reference();
            }
            reference.referent = object_;
            return reference;
        }
    } // CS_Executor
}
