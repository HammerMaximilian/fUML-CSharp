using fuml.semantics.actions;
using uml.actions;

namespace pscs.semantics.actions
{
    public partial class CS_CallOperationActionActivation : CallOperationActionActivation
    {
        public override List<OutputPin> GetOfferingOutputPins()
        {
            // Additional override of fuml::semantics::actions::CallActionActivation::GetOfferingOutputPins()
            // Bypass behavior of CallActionActivation because when CS_CallOperationActionActivation::DoAction()
            // is invoked instead of CallActionActivation's SoAction() method,
            // this.nonStreamingOutputPins is never set.

            // NOTE: Duplicate from ActionActivation::GetOfferingOutputPins()
            return ((uml.actions.Action)node!).output;
        }
    }
}
