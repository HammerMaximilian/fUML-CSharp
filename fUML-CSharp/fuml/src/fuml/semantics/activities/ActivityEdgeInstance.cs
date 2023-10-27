using fuml.syntax.activities;

namespace fuml.semantics.activities
{
    public class ActivityEdgeInstance : FumlObject
    {
		public ActivityEdge? edge = null;
		public ActivityNodeActivationGroup? group = null;
		public ActivityNodeActivation? source = null;
		public ActivityNodeActivation? target = null;
		public List<Offer> offers = new();

		public void sendOffer(
                List<Token> tokens)
		{
			// Send an offer from the source to the target.
			// Keep the offered tokens until taken by the target.
			// (Note that any one edge should only be handling either all object
			// tokens or all control tokens.)

			Offer offer = new();

			foreach (Token token in tokens)
			{
				offer.offeredTokens.Add(token);
			}

			offers.Add(offer);

			target?.receiveOffer();

		} // sendOffer

		public int countOfferedValues()
		{
			// Return the number of values being offered in object tokens.

			int count = 0;
			List<Offer> offers = this.offers;
			foreach (Offer offer in offers)
			{
				count += offer.countOfferedValues();
			}

			return count;
		} // countOfferedValues

		public List<Token> takeOfferedTokens()
		{
			// Take all the offered tokens and return them.

			List<Token> tokens = new();

			while (offers.Count > 0)
			{
				List<Token> offeredTokens = offers.ElementAt(0).getOfferedTokens();
				foreach (Token token in offeredTokens)
				{
					tokens.Add(token);
				}
				offers.RemoveAt(0);
			}

			return tokens;
		} // takeOfferedTokens

		public List<Token> takeOfferedTokens(int maxCount)
		{
			// Take all the offered tokens, up to the given maximum count of
			// non-null object tokens, and return them.

			List<Token> tokens = new();
			int remainingCount = maxCount;

			while (offers.Count > 0 & remainingCount > 0)
			{
				Offer offer = offers.ElementAt(0);
				List<Token> offeredTokens = offer.getOfferedTokens();
				int count = offer.countOfferedValues();
				if (count <= remainingCount)
				{
					foreach (Token offeredToken in offeredTokens)
					{
						tokens.Add(offeredToken);
					}
					remainingCount -= count;
					offers.RemoveAt(0);
				}
				else
				{
					for (int i = 0; i < remainingCount; i++)
					{
						Token token = offeredTokens.ElementAt(i);
						if (token.getValue() != null)
						{
							tokens.Add(token);
						}
					}
					offer.removeOfferedValues(remainingCount);
					remainingCount = 0;
				}
			}

			return tokens;
		} // takeOfferedTokens

		public List<Token> getOfferedTokens()
		{
			// Get the offered tokens (after which the tokens will still be
			// offered).

			List<Token> tokens = new();
			List<Offer> offers = this.offers;

			for (int i = 0; i < offers.Count; i++)
			{
				List<Token> offeredTokens = offers.ElementAt(i).getOfferedTokens();
				for (int j = 0; j < offeredTokens.Count; j++)
				{
					tokens.Add(offeredTokens.ElementAt(j));
				}
			}

			return tokens;
		} // getOfferedTokens

		public bool hasOffer()
		{
			// Return true if there are any pending offers.

			bool hasTokens = false;
			int i = 1;
			while (!hasTokens & i <= offers.Count)
			{
				hasTokens = offers.ElementAt(i - 1).hasTokens();
				i++;
			}

			return hasTokens;
		} // hasOffer
	} // ActivityEdgeInstance
}
