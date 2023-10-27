﻿namespace fuml.semantics.activities
{
    public class FlowFinalNodeActivation : ControlNodeActivation
    {
		public override void Fire(List<Token> incomingTokens)
		{
			// Consume all incoming tokens.

			Debug.println("[fire] Flow final node " + node?.name + "...");

			foreach (Token token in incomingTokens)
			{
				token.Withdraw();
			}
		} // fire
	} // FlowFinalNodeActivation
}