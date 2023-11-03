using fuml.semantics.commonbehavior;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using fuml.syntax.actions;
using fuml.syntax.classification;

namespace fuml.semantics.actions
{
    public class CallOperationActionActivation : CallActionActivation
    {
        public override bool IsReady()
        {
            // Check that this call operation action activation is ready to fire as a
            // call action activation and, in addition, that the input pin activation
            // for its target pin is ready to fire.

            bool ready = base.IsReady();
            if (ready)
            {
                CallOperationAction action = (node as CallOperationAction)!;
                ready = GetPinActivation(action?.target!).IsReady();
            }
            return ready;
        }

        public override Execution GetCallExecution()
        {
            // If the value on the target input pin is a reference, dispatch the
            // operation to it and return the resulting execution object.

            CallOperationAction action = (node as CallOperationAction)!;
            Value target = TakeTokens(action?.target!).ElementAt(0);

            Execution? execution;
            if (target is Reference)
            {
                execution = ((Reference)target).Dispatch(action?.operation!);
            }
            else
            {
                execution = null;
            }

            return execution!;

        } // getCallExecution

        public override List<Parameter> GetParameters()
        {
            // Get the owned parameters of the operation of the call operation
            // action for this call operation action activation.

            Operation operation = (node as CallOperationAction)?.operation!;

            return (operation is not null) ? operation.ownedParameter : new List<Parameter>();
        }
    } // CallOperationActionActivation
}
