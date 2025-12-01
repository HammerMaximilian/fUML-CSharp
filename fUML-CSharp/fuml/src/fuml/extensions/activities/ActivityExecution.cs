using uml.activities;

namespace fuml.extensions.activities
{
    public class ActivityExecution : semantics.activities.ActivityExecution
    {
        public List<VariableValue> variableValues = new();

        public override void Execute()
        {
            CreateVariableValues();
            base.Execute();
        }

        public void CreateVariableValues()
        {
            Activity activity = (Activity)GetTypes().ElementAt(0);
            List<Variable> variables = activity.variable;

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
            // within the scope of this ActivityExecution.
            // That is, all VariableValues directly owned by this ActivityExecution.

            List<VariableValue> allVariableValues = new();
            List<VariableValue> directlyAccessibleVariableValues = variableValues;

            foreach (VariableValue v in directlyAccessibleVariableValues)
            {
                allVariableValues.Add(v);
            }

            return allVariableValues;
        }
    }
}
