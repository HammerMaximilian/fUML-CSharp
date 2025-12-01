using fuml.semantics.values;
using uml.activities;

namespace fuml.extensions.activities
{
    public class VariableValue
    {
        public Variable? variable = null;
        public List<Value> values = new();
        public int position = 0;

        public VariableValue Copy()
        {
            // Create a copy of this variable value.

            VariableValue newValue = new()
            {
                variable = this.variable,
                position = this.position
            };

            List<Value> values = this.values;
            foreach (Value v in values)
            {
                newValue.values.Add(v.Copy());
            }

            return newValue;
        }
    }
}
