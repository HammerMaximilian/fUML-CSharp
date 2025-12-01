using fuml.extensions.activities;
using fuml.semantics.actions;
using fuml.semantics.activities;
using uml.activities;

namespace fuml.extensions.actions
{
    public abstract class VariableActionActivation : ActionActivation
    {
        public List<VariableValue> GetAccessibleVariableValues()
        {
            // Get either the ActivityExecution or the StructuredActivityNodeActivation
            // owning the ActivityNodeActivationGroup which contains this Activation.
            // Get all VariableValues accessible within the context of this Activation's action's owner.

            List<VariableValue> accessibleVariableValues;

            ActivityNodeActivationGroup? group = this.group;

            if (group!.containingNodeActivation is not null)
            {
                extensions.actions.StructuredActivityNodeActivation containingNodeActivation = (extensions.actions.StructuredActivityNodeActivation)group.containingNodeActivation;
                accessibleVariableValues = containingNodeActivation.GetVariableValues();
            }
            else
            {
                extensions.activities.ActivityExecution? activityExecution = (extensions.activities.ActivityExecution)group.activityExecution!;
                accessibleVariableValues = activityExecution!.GetVariableValues();
            }

            return accessibleVariableValues;
        } // getAccessibleVariableValues

        public VariableValue GetVariableValue(Variable variable)
        {
            // Find the appropriate VariableValue matching the give Variable
            // from all VariableValues accessible within the context of this Activation's action's owner.

            List<VariableValue> accessibleVariableValues = GetAccessibleVariableValues();

            VariableValue? variableValue = null;
            int i = 0;
            while (variableValue == null && i < accessibleVariableValues.Count)
            {
                if (accessibleVariableValues.ElementAt(i).variable == variable)
                {
                    variableValue = accessibleVariableValues.ElementAt(i);
                }

                i++;
            }

            return variableValue!;
        } // getVariableValue
    } // VariableActionActivation
}
