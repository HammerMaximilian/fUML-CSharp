namespace fuml.semantics.activities
{
    public class InitialNodeActivation : ControlNodeActivation
    {
		public override void fire(List<Token> incomingTokens)
		{
			// Create a single token and send offers for it.

			List<Token> tokens = new();
			tokens.Add(new ControlToken());
			addTokens(tokens);

			sendOffers(tokens);
		} // fire
	} // InitialNodeActivation
}
