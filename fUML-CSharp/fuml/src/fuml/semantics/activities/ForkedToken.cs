using fuml.semantics.values;

namespace fuml.semantics.activities
{
    public class ForkedToken : Token
    {
		public Token? baseToken = null;
		public int remainingOffersCount = 0;
		public bool baseTokenIsWithdrawn = false;

		public override bool IsControl()
		{
			// Test if the base token is a control token.

			return baseToken is not null && baseToken.IsControl();
		} // isControl

		public override void Withdraw()
		{
			// If the base token is not withdrawn, then withdraw it.
			// Decrement the remaining offers count.
			// When the remaining number of offers is zero, then remove this token
			// from its holder.

			if (!baseTokenIsWithdrawn && baseToken is not null && !baseToken.IsWithdrawn())
			{
				baseToken.Withdraw();

				// NOTE: This keeps a base token that is a forked token from being
				// withdrawn more than once, since withdrawing a forked token may
				// not actually remove it from its fork node holder.
				baseTokenIsWithdrawn = true;
			}

			if (remainingOffersCount > 0)
			{
				remainingOffersCount--;
			}

			if (remainingOffersCount == 0)
			{
				base.Withdraw();
			}
		} // withdraw

		public override Token Copy()
		{
			// Return a copy of the base token.

			return baseToken?.Copy()!;
		} // copy

		public override bool Equals(Token otherToken)
		{
			// Test if this token is equal to another token.

			return this == otherToken;
		} // equals

		public override Value GetValue()
		{
			// Return the value of the base token.

			return baseToken?.GetValue()!;
		} // getValue
	} // ForkedToken
}
