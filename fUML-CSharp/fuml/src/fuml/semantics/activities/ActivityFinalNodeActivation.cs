using fuml.semantics.actions;

namespace fuml.semantics.activities
{
    public class ActivityFinalNodeActivation : ControlNodeActivation
    {
		public override void Fire(List<Token> incomingTokens)
		{
			// Terminate the activity execution or structured node activation
			// containing this activation.

			Debug.Println("[fire] Activity final node " + node?.name + "...");

			if (incomingTokens.Count > 0 | incomingEdges.Count == 0)
			{
				if (group?.activityExecution is not null)
				{
					group.activityExecution.Terminate();
				}
				else if (group?.containingNodeActivation is not null)
				{
					group.containingNodeActivation.TerminateAll();
				}
				else if (group is ExpansionActivationGroup expansionActivationGroup)
				{
					expansionActivationGroup.regionActivation?.Terminate();
				}
			}
		} // fire
	} // ActivityFinalNodeActivation
}
