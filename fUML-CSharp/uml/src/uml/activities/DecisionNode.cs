using uml.commonbehavior;

namespace uml.activities
{
    public class DecisionNode : ControlNode
    {
        public Behavior? decisionInput = null;
        public ObjectFlow? decisionInputFlow = null;

        public void SetDecisionInput(
                Behavior decisionInput)
        {
            this.decisionInput = decisionInput ?? throw new ArgumentNullException(nameof(decisionInput));
        } // setDecisionInput

        public void SetDecisionInputFlow(
                ObjectFlow decisionInputFlow)
        {
            this.decisionInputFlow = decisionInputFlow ?? throw new ArgumentNullException(nameof(decisionInputFlow));
        } // setDecisionInputFlow
    }
}
