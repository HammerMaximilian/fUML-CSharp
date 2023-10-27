using fuml.semantics.values;

namespace fuml.semantics.activities
{
    public class ForkedToken : Token
    {
		public Token? baseToken = null;
		public int remainingOffersCount = 0;
		public bool baseTokenIsWithdrawn = false;

		public override bool isControl()
		{
			// Test if the base token is a control token.

			return baseToken is not null && baseToken.isControl();
		} // isControl

		public override void withdraw()
		{
			// If the base token is not withdrawn, then withdraw it.
			// Decrement the remaining offers count.
			// When the remaining number of offers is zero, then remove this token
			// from its holder.

			if (!baseTokenIsWithdrawn && baseToken is not null && !baseToken.isWithdrawn())
			{
				baseToken.withdraw();

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
				base.withdraw();
			}
		} // withdraw

		public override Token copy()
		{
			// Return a copy of the base token.

			return baseToken?.copy()!;
		} // copy

		public override bool equals(Token otherToken)
		{
			// Test if this token is equal to another token.

			return this == otherToken;
		} // equals

		public override Value getValue()
		{
			// Return the value of the base token.

			return baseToken?.getValue()!;
		} // getValue
	} // ForkedToken
}
