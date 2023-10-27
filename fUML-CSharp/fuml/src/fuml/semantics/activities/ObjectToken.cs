using fuml.semantics.values;

namespace fuml.semantics.activities
{
    public class ObjectToken : Token
    {
		public Value? value = null;

		public override bool Equals(Token other)
		{
			// Test if this object token is the same as the other token.

			return this == other;
		} // equals

		public override Token Copy()
		{
            // Return a new object token with the same value as this token.
            // [Note: the holder of the copy is not set.]

            ObjectToken copy = new()
            {
                value = value
            };

            return copy;
		} // copy

		public override bool IsControl()
		{
			// Return false for an object token.

			return false;
		} // isControl

		public override Value GetValue()
		{
			// Return the value of this object token.

			return value!;
		} // getValue
	} // ObjectToken
}
