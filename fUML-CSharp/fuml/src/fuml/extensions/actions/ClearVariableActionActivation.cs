using fuml.extensions.activities;
using uml.actions;
using uml.activities;

namespace fuml.extensions.actions
{
    public class ClearVariableActionActivation : VariableActionActivation
    {
        public override void DoAction()
        {
            // Set the appropriate variable's value to be empty.

            ClearVariableAction action = (ClearVariableAction)node!;
            Variable variable = action.variable!;

            VariableValue variableValue = GetVariableValue(variable);

            if (variableValue is not null)
            {
                variableValue.values = new();
                variableValue.position = 0;
            }
        }
    } // ClearVariableActionActivation
}
