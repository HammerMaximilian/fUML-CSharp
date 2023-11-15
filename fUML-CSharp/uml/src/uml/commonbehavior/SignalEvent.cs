using uml.simpleclassifiers;

namespace uml.commonbehavior
{
    public class SignalEvent : MessageEvent
    {
        public Signal? signal = null;

        public void SetSignal(
                Signal signal)
        {
            this.signal = signal ?? throw new ArgumentNullException(nameof(signal));
        } // setSignal
    } // SignalEvent
}
