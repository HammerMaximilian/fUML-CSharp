using uml.simpleclassifiers;

namespace uml.actions
{
    public class SendSignalAction : InvocationAction
    {
        public InputPin? target = null;
        public Signal? signal = null;

        public void SetTarget(InputPin target)
        {
            AddInput(target);
            this.target = target;
        } // setTarget

        public void SetSignal(
                Signal signal)
        {
            this.signal = signal ?? throw new ArgumentNullException(nameof(signal));
        } // setSignal
    } // SendSignalAction
}
