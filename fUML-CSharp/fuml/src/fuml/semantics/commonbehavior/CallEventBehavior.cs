using uml.classification;
using uml.commonbehavior;

namespace fuml.semantics.commonbehavior
{
    public class CallEventBehavior : Behavior
    {
        public Operation? operation = null;

        public void SetOperation(Operation operation)
        {
            // Set the operation for this call event behavior and construct
            // the behavior signature based on the operation signature.

            this.operation = operation ?? throw new ArgumentNullException(nameof(operation));
            foreach (Parameter operationParameter in operation.ownedParameter)
            {
                Parameter parameter = new();
                parameter.name = operationParameter.name;
                parameter.type = operationParameter.type;
                parameter.multiplicityElement.lowerValue =
                        operationParameter.multiplicityElement.lowerValue;
                parameter.multiplicityElement.lower =
                        operationParameter.multiplicityElement.lower;
                parameter.multiplicityElement.upperValue =
                        operationParameter.multiplicityElement.upperValue;
                parameter.multiplicityElement.upper =
                        operationParameter.multiplicityElement.upper;
                parameter.direction = operationParameter.direction;
                parameter.owner = this;
                parameter.namespace_ = this;

                ownedElement.Add(parameter);
                ownedMember.Add(parameter);
                member.Add(parameter);
                ownedParameter.Add(parameter);
            }

            isReentrant = true;
            name = "CallEventBehavior";
            if (operation.name is not null)
            {
                name = name + "(" + operation.name + ")";
            }
        }
    } // CallEventBehavior
}
