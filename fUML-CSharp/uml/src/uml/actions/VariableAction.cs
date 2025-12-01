using uml.activities;

namespace uml.actions
{
    public class VariableAction : Action
    {
        public Variable? variable = null;

        public void SetVariable(Variable variable)
        {
            this.variable = variable;
        } // SetVariable
    } // VariableAction
}
