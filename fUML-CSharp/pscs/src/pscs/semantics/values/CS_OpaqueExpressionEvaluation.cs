using fuml.semantics.commonbehavior;
using fuml.semantics.values;
using uml.commonbehavior;
using uml.values;

namespace pscs.semantics.values
{
    public class CS_OpaqueExpressionEvaluation : Evaluation
    {
        public override Value Evaluate()
        {
            // Execute the behavior associated with the context OpaqueExpression, if any.
            // If multiple return values are computed, then return the first one.
            // If no value are computed, return null
            List<Value> evaluation = ExecuteExpressionBehavior();
            if (evaluation.Any())
            {
                return evaluation.ElementAt(0);
            }
            else
            {
                return null!;
            }
        }
        public List<Value> ExecuteExpressionBehavior()
        {
            // If a behavior is associated with the context OpaqueExpression,
            // then execute this behavior, and return computed values.
            // Otherwise, return an empty list of values.
            List<Value> evaluation = new();
            OpaqueExpression expression = (OpaqueExpression)specification!;
            Behavior behavior = expression.behavior!;
            if (behavior is not null)
            {
                List<ParameterValue> inputs = new();
                List<ParameterValue> results = locus?.executor?.Execute(behavior, null!, inputs)!;
                results ??= new();

                foreach (ParameterValue parameterValue in results)
                { // results.size should be 1
                    List<Value> values = parameterValue.values;
                    foreach (Value value in values)
                    {
                        evaluation.Add(value);
                    }
                }
            }
            return evaluation;
        }
    }
}
