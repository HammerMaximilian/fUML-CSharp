using fuml.semantics.activities;
using fuml.syntax.actions;

namespace fuml.semantics.actions
{
    public abstract class PinActivation : ObjectNodeActivation
    {
		public ActionActivation? actionActivation = null;

		public override void Fire(List<Token> incomingTokens)
		{
			// Add all incoming tokens to the pin.

			Debug.println("[fire] Pin " + (node is null ? "" : node.name + "..."));

			AddTokens(incomingTokens);

		} // fire

		public override List<Token> TakeOfferedTokens()
		{
			// Take only a number of tokens only up to the limit allowed by
			// the multiplicity upper bound of the pin for this activation.

			int count = CountUnofferedTokens();
			int upper = -1;

			// Note: A pin activation used in an expansion activation group
			// will have this.node == null.
			if (node is not null)
			{
				upper = ((Pin)node).multiplicityElement.upper.naturalValue;
			}

			List<Token> tokens = new();

			// Note: upper < 0 indicates an unbounded upper multiplicity.
			if (upper < 0 | count < upper)
			{
				List<ActivityEdgeInstance> incomingEdges = this.incomingEdges;
				foreach (ActivityEdgeInstance edge in incomingEdges)
				{
					int incomingCount = edge.CountOfferedValues();
					List<Token> incomingTokens = new();
					if (upper < 0 | incomingCount < upper - count)
					{
						incomingTokens = edge.TakeOfferedTokens();
						count += incomingCount;
					}
					else if (count < upper)
					{
						incomingTokens = edge.TakeOfferedTokens(upper - count);
						count = upper;
					}
					foreach (Token token in incomingTokens)
					{
						tokens.Add(token);
					}
				}
			}

			return tokens;
		} // takeOfferedTokens
	} // PinActivation
}
