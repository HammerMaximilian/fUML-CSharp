namespace fuml.semantics.activities
{
    public class ForkNodeActivation : ControlNodeActivation
    {
		public override void fire(List<Token> incomingTokens)
		{
			// Create forked tokens for all incoming tokens and offer them on all
			// outgoing edges.

			Debug.println(node == null ? "[fire] Anonymous fork node." :
					"[fire] Fork node " + node.name + "...");

			List<ActivityEdgeInstance> outgoingEdges = this.outgoingEdges;
			int outgoingEdgeCount = outgoingEdges.Count;

			List<Token> forkedTokens = new();
			foreach (Token token in incomingTokens)
			{
                ForkedToken forkedToken = new()
                {
                    baseToken = token,
                    remainingOffersCount = outgoingEdgeCount,
                    baseTokenIsWithdrawn = false
                };
                forkedTokens.Add(forkedToken);
			}

			addTokens(forkedTokens);

			sendOffers(forkedTokens);
		} // fire

		public override void terminate()
		{
			// Terminate and remove any offered tokens.

			base.terminate();
			clearTokens();
		} // terminate
	} // ForkNodeActivation
}
