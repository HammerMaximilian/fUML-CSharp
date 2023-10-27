using fuml.semantics.values;
using fuml.syntax.classification;

namespace fuml.semantics.commonbehavior
{
    public class ParameterValue : FumlObject
    {
		public Parameter? parameter = null;
		public List<Value> values = new();

		public ParameterValue copy()
		{
			// Create a new parameter value for the same parameter as this parameter
			// value, but with copies of the values of this parameter value.

			ParameterValue newValue = new();

			newValue.parameter = parameter;

			List<Value> values = this.values;
			foreach (Value value in values)
			{
				newValue.values.Add(value.copy());
			}

			return newValue;
		} // copy
	} // ParameterValue
}
