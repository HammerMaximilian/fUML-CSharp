using fuml.semantics.commonbehavior;
using fuml.semantics.structuredclassifiers;
using fuml.syntax.classification;

namespace fuml.library.libraryclass
{
    public abstract class ImplementationObject : Object_
    {
        public abstract void Execute(OperationExecution execution);

        public override Execution Dispatch(Operation operation)
        {
            OperationExecution execution = new();
            locus?.Add(execution);
            execution.Set(this, operation);
            return execution;
        }
    } // ImplementationObject
}
