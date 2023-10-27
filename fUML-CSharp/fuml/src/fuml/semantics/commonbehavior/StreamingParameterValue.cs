using fuml.semantics.values;

namespace fuml.semantics.commonbehavior
{
    public class StreamingParameterValue : ParameterValue
    {
		public StreamingParameterListener? listener;

		public void post(List<Value> values)
		{
			// Post the given values to the listener, if there is at
			// least one value.

			this.values = values;

			if (listener is not null & values.Count() > 0)
			{
				listener!.post(values);
			}
		}

		public void register(StreamingParameterListener listener)
		{
			// Register a listener for this streaming parameter value.

			this.listener = listener;
		}

		public bool isTerminated()
		{
			// Check if this streaming parameter value either has no listener,
			// or it has a listener that has terminated. 

			bool isTerminated = true;
			if (listener is not null)
			{
				isTerminated = listener.isTerminated();
			}
			return isTerminated;
		}
	} // StreamingParameterValue
}
