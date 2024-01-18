using fuml.semantics.actions;
using pscs.semantics.structuredclassifiers;
using uml.actions;

namespace pscs.semantics.actions
{
    public class CS_ReadSelfActionActivation : ReadSelfActionActivation
    {
        public override void DoAction()
        {
            // Get the context object of the activity execution containing this
            // action activation and place a reference to it on the result output
            // pin.
            // Extends fUML semantics in the sense that the reference placed on
            // the result pin is a CS_Reference, not a Reference
            // Debug.println("[ReadSelfActionActivation] Start...");
            CS_Reference context = new()
            {
                referent = GetExecutionContext()
            };
            if (context.referent is CS_Object cS_Object)
            {// i.e. alternatively, it can be an execution
                context.compositeReferent = cS_Object;
            }

            OutputPin resultPin = ((ReadSelfAction)node! ?? throw new InvalidCastException()).result!;
            PutToken(resultPin, context);
        }
    } // CS_ReadSelfActionActivation
}
