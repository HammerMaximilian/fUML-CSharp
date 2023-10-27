namespace fuml.semantics.activities
{
    public abstract class ObjectNodeActivation : ActivityNodeActivation
    {
		public int offeredTokenCount = 0;

		public override void run()
		{
			// Initialize the offered token count to zero.

			base.run();
			offeredTokenCount = 0;
		} // run

		public override void sendOffers(
				List<Token> tokens)
		{
			// If the set of tokens to be sent is empty, then offer a null token
			// instead.
			// Otherwise, offer the given tokens as usual.

			if (tokens.Count == 0)
			{
                ObjectToken token = new()
                {
                    holder = this
                };
                tokens.Add(token);
			}

			base.sendOffers(tokens);
		} // sendOffers

		public override void terminate()
		{
			// Terminate and remove any offered tokens.

			base.terminate();
			clearTokens();
		} // terminate

		public override void addToken(
                Token token)
		{
			// Transfer the given token to be held by this node only if it is a
			// non-null object token.
			// If it is a control token or a null token, consume it without holding
			// it.

			if (token.getValue() is null)
			{
				token.withdraw();
			}
			else
			{
				base.addToken(token);
			}
		} // addToken

		public override int removeToken(
                Token token)
		{
			// Remove the given token, if it is held by this node activation.

			int i = base.removeToken(token);
			if (i > 0 & i <= offeredTokenCount)
			{
				offeredTokenCount--;
			}

			return i;
		} // removeToken

		public override void clearTokens()
		{
			// Remove all held tokens.

			base.clearTokens();
			offeredTokenCount = 0;
		} // clearTokens

		public int countOfferedValues()
		{
			// Count the total number of non-null object tokens being offered to
			// this node activation.

			int totalValueCount = 0;
			int i = 1;
			while (i <= incomingEdges.Count)
			{
				totalValueCount += incomingEdges.ElementAt(i - 1).countOfferedValues();
				i++;
			}

			return totalValueCount;
		} // countOfferedValues

		public void sendUnofferedTokens()
		{
			// Send offers over all outgoing edges, if there are any tokens to be
			// offered.

			List<Token> tokens = getUnofferedTokens();
			offeredTokenCount += tokens.Count;

			sendOffers(tokens);
		} // sendUnofferedTokens

		public int countUnofferedTokens()
		{
			// Return the number of unoffered tokens that are to be offered next.
			// (By default, this is all unoffered tokens.)

			if (heldTokens.Count == 0)
			{
				offeredTokenCount = 0;
			}

			return heldTokens.Count - offeredTokenCount;
		} // countUnofferedTokens

		public List<Token> getUnofferedTokens()
		{
			// Get the next set of unoffered tokens to be offered and return it.
			// [Note: This effectively treats all object flows as if they have
			// weight=*, rather than the weight=1 default in the current
			// basestructure semantics.]

			List<Token> tokens = new();

			int i = 1;
			while (i <= countUnofferedTokens())
			{
				tokens.Add(heldTokens.ElementAt(offeredTokenCount + i
						- 1));
				i++;
			}

			return tokens;
		} // getUnofferedTokens

		public List<Token> takeUnofferedTokens()
		{
			// Take the next set of unoffered tokens to be offered from this node
			// activation and return them.

			List<Token> tokens = getUnofferedTokens();
			foreach (Token token in tokens)
			{
				token.withdraw();
			}
			return tokens;
		} // takeUnofferedTokens
	} // ObjectNodeActivation
}
