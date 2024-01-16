using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;
using uml.classification;

namespace fuml.semantics.structuredclassifiers
{
    public partial class Reference : StructuredValue
    {
        public virtual Execution Dispatch(
                Operation operation,
                bool isExplicitBaseClassCall = false)
        {
            // Extends Reference.Dispatch(Operation) by flag "isExplicitBaseClassCall"
            // Propagate "isExplicitBaseClassCall" to Object_.GetMethod

            return (referent is not null) ? referent.Dispatch(operation, isExplicitBaseClassCall) : null!;
        } // Dispatch
    } // Reference
}
