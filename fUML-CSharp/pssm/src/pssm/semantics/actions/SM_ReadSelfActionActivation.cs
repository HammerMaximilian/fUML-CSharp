using fuml.semantics.structuredclassifiers;
using pscs.semantics.actions;
using pssm.semantics.statemachines;

namespace pssm.semantics.actions
{
    public class SM_ReadSelfActionActivation : CS_ReadSelfActionActivation
    {
        public override Object_ GetExecutionContext()
        {
            // The context object can be a DoActivityContextObject. A DoActivityContextObject
            // is the execution context of a doActivity behavior executed on its own thread of
            // execution. It references the context object from which the doActivity was invoked.
            // This context may contains features (e.g. operations, properties) that may be manipulated
            // by the doActivity. To enable this, in this situation the ReadSelfAction must resolve
            // to the context of the DoActivityContextObject.
            Object_ context = base.GetExecutionContext();
            if (context is DoActivityContextObject doActivityContextObject)
            {
                context = doActivityContextObject.context!;
            }
            return context;
        }
    } // SM_ReadSelfActionActivation
}
