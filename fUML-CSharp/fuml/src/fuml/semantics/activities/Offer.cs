namespace fuml.semantics.activities
{
    public class Offer : FumlObject
    {
		public List<Token> offeredTokens = new();

		public int countOfferedValues()
		{
			// Return the number of values being offered on object tokens.
			// Remove any tokens that have already been withdrawn and don't include
			// them in the count.

			removeWithdrawnTokens();

			int count = 0;
			foreach (Token offeredToken in offeredTokens)
			{
				if (offeredToken.getValue() is not null)
				{
					count++;
				}
			}

			return count;
		} // countOfferedValues

		public List<Token> getOfferedTokens()
		{
			// Get the offered tokens, removing any that have been withdrawn.

			removeWithdrawnTokens();

			List<Token> tokens = new();
			List<Token> offeredTokens = this.offeredTokens;
			foreach (Token offeredToken in offeredTokens)
			{
				tokens.Add(offeredToken);
			}

			return tokens;

		} // getOfferedTokens

		public void removeOfferedValues(int count)
		{
			// Remove the given number of non-null object tokens from those in this
			// offer.

			int n = count;
			int i = 1;
			while (n > 0)
			{
				if (offeredTokens.ElementAt(i - 1).getValue() is not null)
				{
					offeredTokens.RemoveAt(i - 1);
				}
				else
				{
					i++;
				}
				n--;
			}
		} // removeOfferedValues

		public void removeWithdrawnTokens()
		{
			// Remove any tokens that have already been consumed.

			List<Token> offeredTokens = this.offeredTokens;
			int i = 1;
			while (i <= offeredTokens.Count)
			{
				if (offeredTokens.ElementAt(i - 1).isWithdrawn())
				{
					offeredTokens.RemoveAt(i - 1);
					i--;
				}
				i++;
			}
		} // removeWithdrawnTokens

		public bool hasTokens()
		{
			// Check whether this offer has any tokens that have not been withdrawn.

			removeWithdrawnTokens();
			return offeredTokens.Count > 0;
		} // hasTokens
	} // Offer
}
