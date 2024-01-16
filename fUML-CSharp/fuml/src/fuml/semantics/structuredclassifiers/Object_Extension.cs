using fuml.semantics.commonbehavior;
using uml.classification;

namespace fuml.semantics.structuredclassifiers
{
    public partial class Object_ : ExtensionalValue
    {
        public virtual Execution Dispatch(
                Operation operation,
                bool isExplicitBaseClassCall = false)
        {
            // Extends Object_.Dispatch(Operation) by flag "isExplicitBaseClassCall"
            // Propagate "isExplicitBaseClassCall" to DispatchStrategy.Dispatch

            DispatchStrategy dispatchStrategy = (DispatchStrategy)locus?.factory?.GetStrategy("dispatch")!;

            return (dispatchStrategy is not null) ? dispatchStrategy.Dispatch(this, operation, isExplicitBaseClassCall) : throw new NullReferenceException();
        } // dispatch
    } // Object_
}
