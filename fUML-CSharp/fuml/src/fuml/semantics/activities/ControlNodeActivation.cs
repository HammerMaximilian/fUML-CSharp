namespace fuml.semantics.activities
{
    public abstract class ControlNodeActivation : ActivityNodeActivation
    {
		public override void Fire(List<Token> incomingTokens)
		{
			// By default, offer all tokens on all outgoing edges.

			Debug.println(node != null, "[fire] Control node " + node?.name + "...");

			SendOffers(incomingTokens);
		} // fire
	} // ControlNodeActivation
}
