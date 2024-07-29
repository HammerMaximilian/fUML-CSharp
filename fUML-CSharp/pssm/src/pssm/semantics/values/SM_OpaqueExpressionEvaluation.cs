using fuml.semantics.commonbehavior;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using pscs.semantics.values;
using uml.classification;

namespace pssm.semantics.values
{
    public class SM_OpaqueExpressionEvaluation : CS_OpaqueExpressionEvaluation
    {
        // The context is basically the execution context of the state-machine.
        // This provides the possibility for the behavior associated to the evaluated
        // opaque expression to access features available at the context.
        public Object_? context = null;

        // Input parameters for the execution of the behavior
        protected List<ParameterValue> parameterValues = new();

        public void Initialize(EventOccurrence eventOccurrence)
        {
        }
        public override List<Value> ExecuteExpressionBehavior()
        {
            throw new NotImplementedException();
        }

        public void SetParameterValue(ParameterValue parameterValue)
        {
        }
        public ParameterValue GetParameterValue(Parameter parameter)
        {
            throw new NotImplementedException();
        }

    } // SM_OpaqueExpressionEvaluation
}
