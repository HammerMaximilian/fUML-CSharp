using fuml.semantics.values;

namespace fuml.semantics.commonbehavior
{
    public abstract class StreamingParameterListener
    {
        public abstract void post(List<Value> values);

        public abstract bool isTerminated();
    } // StreamingParameterListener
}
