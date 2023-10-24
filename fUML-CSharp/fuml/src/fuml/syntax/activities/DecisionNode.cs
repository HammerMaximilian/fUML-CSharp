using fuml.syntax.commonbehavior;

namespace fuml.syntax.activities
{
    public class DecisionNode : ControlNode
    {
        public Behavior? decisionInput = null;
        public ObjectFlow? decisionInputFlow = null;

        public void setDecisionInput(
                Behavior decisionInput)
        {
            this.decisionInput = decisionInput ?? throw new ArgumentNullException(nameof(decisionInput));
        } // setDecisionInput

        public void setDecisionInputFlow(
                ObjectFlow decisionInputFlow)
        {
            this.decisionInputFlow = decisionInputFlow ?? throw new ArgumentNullException(nameof(decisionInputFlow));
        } // setDecisionInputFlow
    }
}
