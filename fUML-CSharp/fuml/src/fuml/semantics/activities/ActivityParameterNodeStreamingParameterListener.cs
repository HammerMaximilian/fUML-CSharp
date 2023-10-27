using fuml.semantics.commonbehavior;
using fuml.semantics.values;

namespace fuml.semantics.activities
{
    public class ActivityParameterNodeStreamingParameterListener : StreamingParameterListener
    {
		public ActivityParameterNodeActivation? nodeActivation = null;

		public override void Post(List<Value> values)
		{
			// Fire the activity parameter node activation.
			// (Note that the values do not have to be passed to the node activation,
			// because an input activity parameter node activation retrieves values
			// directly from the relevant parameter value.)

			Debug.println("[post] Posting to node " + nodeActivation?.node?.name);

			nodeActivation?.Fire(new List<Token>());
		}

		public override bool IsTerminated()
		{
			// This listener is terminated if the node activation is not running.

			return nodeActivation is not null && !nodeActivation.IsRunning();
		}
	} // List<ActivityParameterNodeStreamingParameter>ener
}
