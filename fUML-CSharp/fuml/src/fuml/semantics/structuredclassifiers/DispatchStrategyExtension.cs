using fuml.semantics.commonbehavior;
using fuml.semantics.loci;
using uml.classification;
using uml.commonbehavior;

namespace fuml.semantics.structuredclassifiers
{
    public abstract partial class DispatchStrategy : SemanticStrategy
    {
		public Execution Dispatch(
				Object_ object_,
				Operation operation,
				bool isExplicitBaseClassCall = false)
		{
			// Extends DispatchStrategy.Dispatch(Object_, Operation) by flag "isExplicitBaseClassCall"
			// Propagate "isExplicitBaseClassCall" to DispatchStrategy.GetMethod

			return object_?.locus?.factory?.CreateExecution(GetMethod(object_, operation, isExplicitBaseClassCall), object_)!;
		} // Dispatch

		public virtual Behavior GetMethod(
				Object_ object_,
				Operation operation,
				bool isExplicitBaseClassCall = false)
		{
			return GetMethod(object_, operation);
		} // GetMethod
	} // DispatchStrategy
}
