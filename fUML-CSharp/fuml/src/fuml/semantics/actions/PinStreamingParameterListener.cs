using fuml.semantics.activities;
using fuml.semantics.commonbehavior;
using fuml.semantics.values;

namespace fuml.semantics.actions
{
    public class PinStreamingParameterListener : StreamingParameterListener
    {
        public PinActivation? nodeActivation = null;

        public override void Post(List<Value> values)
        {
            // Fire the pin activation passing the posted values as incoming tokens,
            // then have the pin activation immediately offer these tokens (since
            // the pin activation would otherwise not offer them until its
            // associated action activation terminates).

            Debug.println("[post] Posting to node " + nodeActivation?.node?.name);

            List<Token> tokens = new();
            foreach (Value value in values)
            {
                ObjectToken token = new()
                {
                    value = value
                };
                tokens.Add(token);
            }

            nodeActivation?.Fire(tokens);
            nodeActivation?.SendUnofferedTokens();
        }

        public override bool IsTerminated()
        {
            // This listener is terminated if the node activation is not running.

            return nodeActivation is null || !nodeActivation.IsRunning();
        }
    }
}