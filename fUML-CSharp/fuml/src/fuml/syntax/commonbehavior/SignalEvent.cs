using fuml.syntax.simpleclassifiers;

namespace fuml.syntax.commonbehavior
{
    public class SignalEvent : MessageEvent
    {
        public Signal? signal = null;

        public void setSignal(
                Signal signal)
        {
            this.signal = signal ?? throw new ArgumentNullException(nameof(signal));
        } // setSignal
    } // SignalEvent
}
