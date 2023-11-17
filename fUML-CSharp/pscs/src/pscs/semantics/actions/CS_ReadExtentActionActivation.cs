using fuml.semantics.actions;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using pscs.semantics.structuredclassifiers;
using uml.actions;

namespace pscs.semantics.actions
{
    public class CS_ReadExtentActionActivation : ReadExtentActionActivation
    {
        public override void DoAction()
        {
            // Get the extent, at the current execution locus, of the classifier
            // (which must be a class) identified in the action.
            // Place references to the resulting set of objects on the result pin.
            // Extends default fUML semantics in the sense that produced tokens contain
            // CS_References instead of References, in the case where the object is a
            // CS_Object
            ReadExtentAction action = (ReadExtentAction)node! ?? throw new InvalidCastException();
            List<ExtensionalValue> objects = GetExecutionLocus().GetExtent(action.classifier ?? throw new ArgumentNullException());

            List<Value> references = new();
            foreach (Value object_ in objects)
            {
                Reference reference;
                if (object_ is CS_Object cS_Object)
                {
                    reference = new CS_Reference();
                    ((CS_Reference)reference).compositeReferent = cS_Object;
                }
                else
                {
                    reference = new Reference();
                }
                reference.referent = (Object_)object_;
                references.Add(reference);
            }
            PutTokens(action.result ?? throw new ArgumentNullException(), references);
        }
    } // CS_ReadExtentActionActivation
}
