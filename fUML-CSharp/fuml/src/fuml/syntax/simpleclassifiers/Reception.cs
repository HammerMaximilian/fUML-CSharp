using fuml.syntax.classification;

namespace fuml.syntax.simpleclassifiers
{
    public class Reception : BehavioralFeature
    {
        public Signal? signal = null;

        public void SetSignal(
                Signal signal)
        {
            this.signal = signal ?? throw new ArgumentNullException(nameof(signal));
        } // setSignal
    } // Reception
}
