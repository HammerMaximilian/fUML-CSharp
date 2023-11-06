using fuml.syntax.commonbehavior;

namespace fuml.syntax.actions
{
    public class CallBehaviorAction : CallAction
    {
        public Behavior? behavior = null;

        public void SetBehavior(
                Behavior behavior)
        {
            this.behavior = behavior ?? throw new ArgumentNullException(nameof(behavior));
        } // setBehavior
    } // CallBehaviorAction
}
