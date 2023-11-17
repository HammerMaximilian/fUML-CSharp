using fuml.semantics.actions;
using fuml.semantics.structuredclassifiers;
using pscs.semantics.structuredclassifiers;
using uml.actions;
using uml.structuredclassifiers;

namespace pscs.semantics.actions
{
    public class CS_CreateObjectActionActivation : CreateObjectActionActivation
    {
        public override void DoAction()
        {
            // Create an object with the given classifier (which must be a class) as
            // its type, at the same locus as the action activation.
            // Place a reference to the object on the result pin of the action.
            // Extends fUML semantics in the sense that the reference placed
            // on the result pin is a CS_Reference (in the case where the instantiated object
            // is a CS_Object) not a Reference
            // Note that Locus.instantiate(Class) is extended in this specification
            // to produce a CS_Object instead of an Object in the case where the class
            // to be instantiated is not a behavior
            CreateObjectAction action = (CreateObjectAction)node! ?? throw new InvalidCastException();
            Reference reference;
            Object_ referent = GetExecutionLocus()?.Instantiate((Class_)action.classifier!)!;
            if (referent is CS_Object cS_Object)
            {
                reference = new CS_Reference();
                ((CS_Reference)reference).compositeReferent = cS_Object;
            }
            else
            {
                reference = new Reference();
            }
            reference.referent = referent;
            PutToken(action.result!, reference);
        }
    } // CS_CreateObjectActionActivation
}
