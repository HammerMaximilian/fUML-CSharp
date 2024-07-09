using fuml.semantics.commonbehavior;
using fuml.semantics.loci;
using System.Reflection;
using uml.classification;
using uml.commonbehavior;

namespace fuml.semantics.structuredclassifiers
{
    public abstract partial class DispatchStrategy : SemanticStrategy
    {
		public override string GetName()
		{
			// Dispatch strategies are always named "dispatch".

			return "dispatch";
		} // getName

		public Execution Dispatch(
				Object_ object_,
				Operation operation)
		{
            // Get the behavior for the given operation as determined by the type(s)
            // of the given object_, compile the behavior at the locus of the object_,
            // and return the resulting execution object_.

            Behavior method = GetMethod(object_, operation, false);

            if (method is null)
            {
                string message = "[error] Local variable 'method' was null in " + MethodBase.GetCurrentMethod()!.ToString();
                Console.WriteLine(message);
                throw new ArgumentNullException(message);
            }

            return object_?.locus?.factory?.CreateExecution(method, object_)!;
		} // dispatch

		public virtual Behavior GetMethod(
				Object_ object_,
				Operation operation)
		{
			// Get the method that corresponds to the given operation for the given object_.
			// By default, the operation is treated as being called via a call event occurrence,
			// with a call even behavior as its effective method. Concrete dispatch strategy
			// subclasses may override this default to provide other dispatching behavior.

			CallEventBehavior method = new();
			method.SetOperation(operation);
			return method;
		}
	} // DispatchStrategy
}
