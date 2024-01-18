using uml.classification;

namespace uml.simpleclassifiers
{
    public class Reception : BehavioralFeature
    {
        public Signal? signal = null;
        public Interface? interface_ = null; // PSCS-specific

        public void SetSignal(
                Signal signal)
        {
            this.signal = signal ?? throw new ArgumentNullException(nameof(signal));
        } // setSignal

        public void _setInterface(Interface interface_) // PSCS-specific
        {
            this.interface_ = interface_ ?? throw new ArgumentNullException(nameof(interface_));
        }
    } // Reception
}
