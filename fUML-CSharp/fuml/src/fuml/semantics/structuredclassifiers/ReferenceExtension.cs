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
            // If "isExplicitBaseClassCall" is true, delegate to Object_.Dispatch(Operation, bool).
            // Else, call standard method Dispatch(Operation) to maintain possible method overriding.

            if(isExplicitBaseClassCall)
            {
                return (referent is not null) ? referent.Dispatch(operation, isExplicitBaseClassCall) : null!;
            }
            else
            {
                return Dispatch(operation);
            }
            
        } // Dispatch
    } // Reference
}
