namespace fuml.semantics.activities
{
    public class CentralBufferNodeActivation : ObjectNodeActivation
    {
		public override void Fire(List<Token> incomingTokens)
		{
			// Add all incoming tokens to the central buffer node.
			// Offer any tokens that have not yet been offered.

			Debug.Println("[fire] " + node?.GetType().Name + " " + node?.name);

			AddTokens(incomingTokens);
			SendUnofferedTokens();
		}
	} // CentralBufferNodeActivation
}
