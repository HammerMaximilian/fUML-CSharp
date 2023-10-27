namespace fuml.semantics.activities
{
    public class FlowFinalNodeActivation : ControlNodeActivation
    {
		public override void fire(List<Token> incomingTokens)
		{
			// Consume all incoming tokens.

			Debug.println("[fire] Flow final node " + node?.name + "...");

			foreach (Token token in incomingTokens)
			{
				token.withdraw();
			}
		} // fire
	} // FlowFinalNodeActivation
}
