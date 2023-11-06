using fuml.syntax.commonbehavior;

namespace fuml.syntax.actions
{
    public class AcceptEventAction : Action
    {
        public bool isUnmarshall = false;
        public List<OutputPin> result = new();
        public List<Trigger> trigger = new();

        public void SetIsUnmarshall(bool isUnmarshall)
        {
            this.isUnmarshall = isUnmarshall;
        } // setIsUnmarshall

        public void AddTrigger(
                Trigger trigger)
        {
            if (trigger is null)
            {
                throw new ArgumentNullException(nameof(trigger));
            }

            this.trigger.Add(trigger);
        } // addTrigger

        public void AddResult(OutputPin result)
        {
            AddOutput(result);
            this.result.Add(result);
        } // addResult
    } // AcceptEventAction
}
