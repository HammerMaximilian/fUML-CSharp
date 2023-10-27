using fuml.semantics.values;

namespace fuml.semantics.commonbehavior
{
    public abstract class StreamingParameterListener
    {
        public abstract void Post(List<Value> values);

        public abstract bool IsTerminated();
    } // StreamingParameterListener
}
