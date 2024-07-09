using fuml.semantics.commonbehavior;
using fuml.semantics.loci;
using System.Reflection;
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

			Behavior method = GetMethod(object_, operation, isExplicitBaseClassCall);

			if(method is null)
			{
                string message = "[error] Local variable 'method' was null in " + MethodBase.GetCurrentMethod()!.ToString();
                Console.WriteLine(message);
				throw new ArgumentNullException(message);
			}

            return object_?.locus?.factory?.CreateExecution(method, object_)!;
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
