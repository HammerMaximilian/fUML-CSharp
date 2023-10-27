namespace fuml.semantics.activities
{
    public class Offer : FumlObject
    {
		public List<Token> offeredTokens = new();

		public int CountOfferedValues()
		{
			// Return the number of values being offered on object tokens.
			// Remove any tokens that have already been withdrawn and don't include
			// them in the count.

			RemoveWithdrawnTokens();

			int count = 0;
			foreach (Token offeredToken in offeredTokens)
			{
				if (offeredToken.GetValue() is not null)
				{
					count++;
				}
			}

			return count;
		} // countOfferedValues

		public List<Token> GetOfferedTokens()
		{
			// Get the offered tokens, removing any that have been withdrawn.

			RemoveWithdrawnTokens();

			List<Token> tokens = new();
			List<Token> offeredTokens = this.offeredTokens;
			foreach (Token offeredToken in offeredTokens)
			{
				tokens.Add(offeredToken);
			}

			return tokens;

		} // getOfferedTokens

		public void RemoveOfferedValues(int count)
		{
			// Remove the given number of non-null object tokens from those in this
			// offer.

			int n = count;
			int i = 1;
			while (n > 0)
			{
				if (offeredTokens.ElementAt(i - 1).GetValue() is not null)
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

		public void RemoveWithdrawnTokens()
		{
			// Remove any tokens that have already been consumed.

			List<Token> offeredTokens = this.offeredTokens;
			int i = 1;
			while (i <= offeredTokens.Count)
			{
				if (offeredTokens.ElementAt(i - 1).IsWithdrawn())
				{
					offeredTokens.RemoveAt(i - 1);
					i--;
				}
				i++;
			}
		} // removeWithdrawnTokens

		public bool HasTokens()
		{
			// Check whether this offer has any tokens that have not been withdrawn.

			RemoveWithdrawnTokens();
			return offeredTokens.Count > 0;
		} // hasTokens
	} // Offer
}
