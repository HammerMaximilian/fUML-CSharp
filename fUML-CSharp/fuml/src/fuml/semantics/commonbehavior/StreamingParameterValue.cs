using fuml.semantics.values;

namespace fuml.semantics.commonbehavior
{
    public class StreamingParameterValue : ParameterValue
    {
		public StreamingParameterListener? listener;

		public void Post(List<Value> values)
		{
			// Post the given values to the listener, if there is at
			// least one value.

			this.values = values;

			if (listener is not null & values.Count > 0)
			{
				listener!.Post(values);
			}
		}

		public void Register(StreamingParameterListener listener)
		{
			// Register a listener for this streaming parameter value.

			this.listener = listener;
		}

		public bool IsTerminated()
		{
			// Check if this streaming parameter value either has no listener,
			// or it has a listener that has terminated. 

			bool isTerminated = true;
			if (listener is not null)
			{
				isTerminated = listener.IsTerminated();
			}
			return isTerminated;
		}
	} // StreamingParameterValue
}
