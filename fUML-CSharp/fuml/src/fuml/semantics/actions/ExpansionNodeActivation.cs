using fuml.semantics.activities;
using fuml.syntax.actions;

namespace fuml.semantics.actions
{
    public class ExpansionNodeActivation : ObjectNodeActivation
    {
		public override void Fire(List<Token> incomingTokens)
		{
			// Take tokens from all incoming edges.

			Debug.println("[fire] Expansion node " + node?.name + "...");

			AddTokens(incomingTokens);

		} // fire

		public override void ReceiveOffer()
		{
			// Forward the offer on to the expansion region.

			GetExpansionRegionActivation().ReceiveOffer();
		} // receiveOffer

		public override bool IsReady()
		{
			// An expansion node is always fired by its expansion region.

			return false;
		} // isReady

		public ExpansionRegionActivation GetExpansionRegionActivation()
		{
			// Return the expansion region activation corresponding to this
			// expansion node, in the context of the activity node activation group
			// this expansion node activation is in.

			ExpansionNode node = (ExpansionNode)this.node!;

			ExpansionRegion region = node?.regionAsInput!;
			if (region is null)
			{
				region = node?.regionAsOutput!;
			}

			return (ExpansionRegionActivation)group?.GetNodeActivation(region)!;

		} // getExpansionRegionActivation
	} // ExpansionNodeActivation
}
