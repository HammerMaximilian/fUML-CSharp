using fuml.semantics.values;
using uml.classification;

namespace fuml.semantics.commonbehavior
{
    public class ParameterValue
    {
		public Parameter? parameter = null;
		public List<Value> values = new();

		public ParameterValue Copy()
		{
            // Create a new parameter value for the same parameter as this parameter
            // value, but with copies of the values of this parameter value.

            ParameterValue newValue = new()
            {
                parameter = parameter
            };

            List<Value> values = this.values;
			foreach (Value value in values)
			{
				newValue.values.Add(value.Copy());
			}

			return newValue;
		} // copy
	} // ParameterValue
}
