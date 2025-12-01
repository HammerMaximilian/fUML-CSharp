using fuml.extensions.activities;
using fuml.semantics.activities;
using uml.actions;
using uml.activities;

namespace fuml.extensions.actions
{
    public class StructuredActivityNodeActivation : semantics.actions.StructuredActivityNodeActivation
    {
        public List<VariableValue> variableValues = new();

        public override void Initialize(ActivityNode node, ActivityNodeActivationGroup group)
        {
            base.Initialize(node, group);
            CreateVariableValues();
        }

        public void CreateVariableValues()
        {
            StructuredActivityNode node = (StructuredActivityNode)this.node!;
            List<Variable> variables = node.variable;

            foreach (Variable v in variables)
            {
                VariableValue variableValue = new VariableValue();
                variableValue.variable = v;
                variableValues.Add(variableValue);
            }
        }

        public List<VariableValue> GetVariableValues()
        {

            // Retrieve the VariableValues for all Variables that are accessible 
            // within the scope of this StructuredActivityNodeActivation.
            // That is, all VariableValues directly owned by this StructuredActivityNodeActivation,
            // as well as all VariableValues owned by direct or indirect containing StructuredActivityNodeActivations,
            // as well as all VariableValues owned by the containing ActivityExecution.

            List<VariableValue> allVariableValues = new();
            List<VariableValue> directlyAccessibleVariableValues = variableValues;
            List<VariableValue> indirectlyAccessibleVariableValues = new();

            foreach (VariableValue v in directlyAccessibleVariableValues)
            {
                allVariableValues.Add(v);
            }

            ActivityNodeActivationGroup group = this.group!;

            if (group.containingNodeActivation is not null)
            {
                // If this StructuredActivityNodeActivation is nested inside another StructuredActivityNodeActivation,
                // (recursively) collect all accessible VariableValues of the containing StructuredActivityNodeActivation.
                extensions.actions.StructuredActivityNodeActivation containingNodeActivation = (extensions.actions.StructuredActivityNodeActivation)group.containingNodeActivation;
                indirectlyAccessibleVariableValues = containingNodeActivation.GetVariableValues();
            }
            else
            {
                // This StructuredActivityNodeActivation is directly nested inside an ActivityExecution.
                // Collect all accessible VariableValues of that ActivityExecution.
                extensions.activities.ActivityExecution activityExecution = (extensions.activities.ActivityExecution)group.activityExecution!;
                indirectlyAccessibleVariableValues = activityExecution.GetVariableValues();
            }

            foreach (VariableValue v in indirectlyAccessibleVariableValues)
            {
                allVariableValues.Add(v);
            }

            return allVariableValues;
        }
    }
}
