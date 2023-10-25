using fuml.syntax.simpleclassifiers;

namespace fuml.syntax.actions
{
    public class SendSignalAction : InvocationAction
    {
        public InputPin? target = null;
        public Signal? signal = null;

        public void setTarget(InputPin target)
        {
            addInput(target);
            this.target = target;
        } // setTarget

        public void setSignal(
                Signal signal)
        {
            this.signal = signal ?? throw new ArgumentNullException(nameof(signal));
        } // setSignal
    } // SendSignalAction
}
