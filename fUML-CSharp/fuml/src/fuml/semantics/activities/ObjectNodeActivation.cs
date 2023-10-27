namespace fuml.semantics.activities
{
    public abstract class ObjectNodeActivation : ActivityNodeActivation
    {
		public int offeredTokenCount = 0;

		public override void Run()
		{
			// Initialize the offered token count to zero.

			base.Run();
			offeredTokenCount = 0;
		} // run

		public override void SendOffers(
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

			base.SendOffers(tokens);
		} // sendOffers

		public override void Terminate()
		{
			// Terminate and remove any offered tokens.

			base.Terminate();
			ClearTokens();
		} // terminate

		public override void AddToken(
                Token token)
		{
			// Transfer the given token to be held by this node only if it is a
			// non-null object token.
			// If it is a control token or a null token, consume it without holding
			// it.

			if (token.GetValue() is null)
			{
				token.Withdraw();
			}
			else
			{
				base.AddToken(token);
			}
		} // addToken

		public override int RemoveToken(
                Token token)
		{
			// Remove the given token, if it is held by this node activation.

			int i = base.RemoveToken(token);
			if (i > 0 & i <= offeredTokenCount)
			{
				offeredTokenCount--;
			}

			return i;
		} // removeToken

		public override void ClearTokens()
		{
			// Remove all held tokens.

			base.ClearTokens();
			offeredTokenCount = 0;
		} // clearTokens

		public int CountOfferedValues()
		{
			// Count the total number of non-null object tokens being offered to
			// this node activation.

			int totalValueCount = 0;
			int i = 1;
			while (i <= incomingEdges.Count)
			{
				totalValueCount += incomingEdges.ElementAt(i - 1).CountOfferedValues();
				i++;
			}

			return totalValueCount;
		} // countOfferedValues

		public void SendUnofferedTokens()
		{
			// Send offers over all outgoing edges, if there are any tokens to be
			// offered.

			List<Token> tokens = GetUnofferedTokens();
			offeredTokenCount += tokens.Count;

			SendOffers(tokens);
		} // sendUnofferedTokens

		public int CountUnofferedTokens()
		{
			// Return the number of unoffered tokens that are to be offered next.
			// (By default, this is all unoffered tokens.)

			if (heldTokens.Count == 0)
			{
				offeredTokenCount = 0;
			}

			return heldTokens.Count - offeredTokenCount;
		} // countUnofferedTokens

		public List<Token> GetUnofferedTokens()
		{
			// Get the next set of unoffered tokens to be offered and return it.
			// [Note: This effectively treats all object flows as if they have
			// weight=*, rather than the weight=1 default in the current
			// basestructure semantics.]

			List<Token> tokens = new();

			int i = 1;
			while (i <= CountUnofferedTokens())
			{
				tokens.Add(heldTokens.ElementAt(offeredTokenCount + i
						- 1));
				i++;
			}

			return tokens;
		} // getUnofferedTokens

		public List<Token> TakeUnofferedTokens()
		{
			// Take the next set of unoffered tokens to be offered from this node
			// activation and return them.

			List<Token> tokens = GetUnofferedTokens();
			foreach (Token token in tokens)
			{
				token.Withdraw();
			}
			return tokens;
		} // takeUnofferedTokens
	} // ObjectNodeActivation
}
