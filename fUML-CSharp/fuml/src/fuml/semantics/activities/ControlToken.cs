﻿using fuml.semantics.values;

namespace fuml.semantics.activities
{
    public class ControlToken : Token
    {
		public override bool Equals(Token other)
		{
			// Return true if the other token is a control token, because control
			// tokens are interchangable.

			return other is ControlToken;

		} // equals

		public override Token Copy()
		{
			// Return a new control token.

			return new ControlToken();
		} // copy

		public override bool IsControl()
		{
			// Return true for a control token.

			return true;
		} // isControl

		public override Value GetValue()
		{
			// Control tokens do not have values.

			return null!;
		} // getValue
	} // ControlToken
}
