using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using fuml.syntax.commonbehavior;
using fuml.syntax.structuredclassifiers;
using fuml.syntax.values;

namespace fuml.semantics.loci
{
    public class Executor : FumlObject
    {
		public Locus? locus = null;

		public List<ParameterValue> execute(
				Behavior behavior,
				Object_ context,
				List<ParameterValue> inputs)
		{
			// Execute the given behavior with the given input values in the given
			// context, producing the given output values.
			// There must be one input parameter value for each input (in or in-out)
			// parameter of the behavior.
			// The returned values include one parameter value for each output
			// (in-out, out or return) parameter of the behavior.
			// The execution instance is destroyed at completion.

			Execution execution = locus?.factory?.createExecution(behavior,
					context);

			for (int i = 0; i < inputs.Count(); i++)
			{
				execution.setParameterValue(inputs.ElementAt(i));
			}

			execution.execute();
			List<ParameterValue> outputValues = execution.getOutputParameterValues();
			execution.destroy();

			return outputValues;
		} // execute

		public Value evaluate(
				ValueSpecification specification)
		{
			// Evaluate the given value specification, returning the specified
			// value.

			// Debug.println("[evaluate] Start...");
			return locus?.factory?.createEvaluation(specification)?.evaluate();
		} // evaluate

		public Reference start(
				Class_ type,
				List<ParameterValue> inputs)
		{
			// Instantiate the given class and start any behavior of the resulting
			// object_.
			// (The behavior of an object_ includes any classifier behaviors for an
			// active object_ or the class of the object_ itself, if that is a
			// behavior.)

			Debug.println("[start] Starting " + type.name + "...");

			Object_? object_ = locus?.instantiate(type);

			Debug.println("[start] Object = " + object_);
			object_?.startBehavior(type, inputs);

			Reference reference = new Reference();
			reference.referent = object_;

			return reference;
		} // start
	} // Executor
}
