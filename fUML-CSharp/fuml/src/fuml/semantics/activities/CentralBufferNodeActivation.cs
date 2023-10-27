namespace fuml.semantics.activities
{
    public class CentralBufferNodeActivation : ObjectNodeActivation
    {
		public override void fire(List<Token> incomingTokens)
		{
			// Add all incoming tokens to the central buffer node.
			// Offer any tokens that have not yet been offered.

			Debug.println("[fire] " + node?.GetType().Name + " " + node?.name);

			addTokens(incomingTokens);
			sendUnofferedTokens();
		}
	} // CentralBufferNodeActivation
}
