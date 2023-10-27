using fuml.semantics.values;

namespace fuml.semantics.activities
{
    public class DataStoreNodeActivation : CentralBufferNodeActivation
    {
		public override void AddToken(Token token)
		{
			// Add the given token to the data store only if it is unique,
			// that is, if its value is not the same as the value of
			// another token already held in the data store.

			Value value = token.GetValue();

			bool isUnique = true;
			if (value != null)
			{
				List<Token> heldTokens = GetTokens();
				int i = 1;
				while (isUnique & i <= heldTokens.Count)
				{
					isUnique = !heldTokens.ElementAt(i - 1).GetValue().Equals(value);
					i++;
				}
			}

			if (isUnique)
			{
				base.AddToken(token);
			}

		}

		public override int RemoveToken(Token token)
		{
			// Remove the given token from the data store, but then immediately 
			// add a copy back into the data store and offer it (unless the
			// node activation has already been terminated).

			int i = base.RemoveToken(token);

			if (IsRunning())
			{
				base.AddToken(token.Copy());
				SendUnofferedTokens();
			}

			return i;
		}
	} // DataStoreNodeActivation
}
