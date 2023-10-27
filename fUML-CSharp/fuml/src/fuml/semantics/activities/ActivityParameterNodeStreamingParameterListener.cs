using fuml.semantics.commonbehavior;
using fuml.semantics.values;

namespace fuml.semantics.activities
{
    public class ActivityParameterNodeStreamingParameterListener : StreamingParameterListener
    {
		public ActivityParameterNodeActivation? nodeActivation = null;

		public override void post(List<Value> values)
		{
			// Fire the activity parameter node activation.
			// (Note that the values do not have to be passed to the node activation,
			// because an input activity parameter node activation retrieves values
			// directly from the relevant parameter value.)

			Debug.println("[post] Posting to node " + nodeActivation?.node?.name);

			nodeActivation?.fire(new List<Token>());
		}

		public override bool isTerminated()
		{
			// This listener is terminated if the node activation is not running.

			return nodeActivation is not null && !nodeActivation.isRunning();
		}
	} // List<ActivityParameterNodeStreamingParameter>ener
}
