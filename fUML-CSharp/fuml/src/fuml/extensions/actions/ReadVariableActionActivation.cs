using fuml.extensions.activities;
using fuml.semantics.values;
using uml.actions;
using uml.activities;

namespace fuml.extensions.actions
{
    public class ReadVariableActionActivation : VariableActionActivation
    {
        public override void DoAction()
        {
            // Get the values of the appropriate variable and place them on the result output pin.

            ReadVariableAction action = (ReadVariableAction)node!;
            Variable variable = action.variable!;
            VariableValue variableValue = GetVariableValue(variable);
            List<Value> values = new();

            if (variableValue is not null)
            {
                values = variableValue.values;
            }

            PutTokens(action.result!, values);

        } // DoAction
    } // ReadVariableActionActivation
}
