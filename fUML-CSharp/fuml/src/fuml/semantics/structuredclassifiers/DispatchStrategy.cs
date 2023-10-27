using fuml.semantics.loci;
using fuml.syntax.classification;
using fuml.syntax.commonbehavior;

namespace fuml.semantics.structuredclassifiers
{
    public abstract class DispatchStrategy : SemanticStrategy
    {
		public override string getName()
		{
			// Dispatch strategies are always named "dispatch".

			return "dispatch";
		} // getName

		public Execution dispatch(
				Object_ object_,
				Operation operation)
		{
			// Get the behavior for the given operation as determined by the type(s)
			// of the given object_, compile the behavior at the locus of the object_,
			// and return the resulting execution object_.

			return object_.locus.factory.createExecution(getMethod(object_, operation), object_);
		} // dispatch

		public virtual Behavior getMethod(
				Object_ object_,
				Operation operation)
		{
			// Get the method that corresponds to the given operation for the given object_.
			// By default, the operation is treated as being called via a call event occurrence,
			// with a call even behavior as its effective method. Concrete dispatch strategy
			// subclasses may override this default to provide other dispatching behavior.

			CallEventBehavior method = new();
			method.setOperation(operation);
			return method;
		}
	} // DispatchStrategy
}
