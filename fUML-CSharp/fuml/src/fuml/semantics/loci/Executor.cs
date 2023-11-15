using fuml.semantics.commonbehavior;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using uml.commonbehavior;
using uml.structuredclassifiers;
using uml.values;

namespace fuml.semantics.loci
{
    public class Executor
    {
		public Locus? locus = null;

		public List<ParameterValue> Execute(
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

			Execution execution = locus?.factory?.CreateExecution(behavior,context)!;

			for (int i = 0; i < inputs.Count; i++)
			{
				execution?.SetParameterValue(inputs.ElementAt(i));
			}

			execution?.Execute();
			List<ParameterValue> outputValues = execution?.GetOutputParameterValues()!;
			execution?.Destroy();

			return outputValues;
		} // execute

		public Value Evaluate(
				ValueSpecification specification)
		{
			// Evaluate the given value specification, returning the specified
			// value.

			// Debug.println("[evaluate] Start...");
			return locus?.factory?.CreateEvaluation(specification)?.Evaluate()!;
		} // evaluate

		public Reference Start(
				Class_ type,
				List<ParameterValue> inputs)
		{
			// Instantiate the given class and start any behavior of the resulting
			// object_.
			// (The behavior of an object_ includes any classifier behaviors for an
			// active object_ or the class of the object_ itself, if that is a
			// behavior.)

			Debug.Println("[start] Starting " + type.name + "...");

			Object_? object_ = locus?.Instantiate(type);

			Debug.Println("[start] Object = " + object_);
			object_?.StartBehavior(type, inputs);

            Reference reference = new()
            {
                referent = object_
            };

            return reference;
		} // start
	} // Executor
}
