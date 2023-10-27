using fuml.semantics.activities;
using fuml.syntax.actions;
using fuml.syntax.activities;

namespace fuml.semantics.actions
{
    public class ExpansionActivationGroup : ActivityNodeActivationGroup
    {
        public List<OutputPinActivation> regionInputs = new();
        public List<OutputPinActivation> groupInputs = new();
        public ExpansionRegionActivation? regionActivation = null;
        public List<OutputPinActivation> groupOutputs = new();
        public int index = 0;

		public override ActivityNodeActivation GetNodeActivation(ActivityNode node)
		{
			// If the given node is an input pin of the expansion region, then
			// return the corresponding region-input output-pin activation.
			// If the given node is an input expansion node of the expansion region,
			// then return the corresponding group-input output-pin activation.
			// If the given node is an output expansion node of the expansion
			// region, then return the corresponding group-output output-pin
			// activation.
			// Otherwise return the node activation from the activation group, as
			// usual.

			ExpansionRegion region = (ExpansionRegion)regionActivation?.node!;

			ActivityNodeActivation? activation = null;

			int i = 1;
			while (activation is null & i <= region.input.Count)
			{
				if (node == region.input.ElementAt(i - 1))
				{
					activation = regionInputs.ElementAt(i - 1);
				}
				i++;
			}

			int j = 1;
			while (activation is null & j <= region.inputElement.Count)
			{
				if (node == region.inputElement.ElementAt(j - 1))
				{
					activation = groupInputs.ElementAt(j - 1);
				}
				j++;
			}

			int k = 1;
			while (activation is null & k <= region.outputElement.Count)
			{
				if (node == region.outputElement.ElementAt(k - 1))
				{
					activation = groupOutputs.ElementAt(k - 1);
				}
				k++;
			}

			if (activation is null)
			{
				activation = base.GetNodeActivation(node);
			}

			return activation;
		} // getNodeActivation

		public override ActivityExecution GetActivityExecution()
		{
			// Get the activity execution that contains the expansion region
			// activation for this activation group.

			return regionActivation?.GetActivityExecution()!;
		} // getActivityExecution

		public override void Suspend(ActivityNodeActivation activation)
		{
			// Suspend the given activation in this activation group. If this is
			// the only suspended activation, then suspend the associated region
			// activation.

			if (!IsSuspended())
			{
				regionActivation?.Suspend();
			}
			base.Suspend(activation);
		} // suspend

		public override void Resume(ActivityNodeActivation activation)
		{
			// Resume the given activation in this activation group. If this is the
			// last suspended activation, then resume the associated region
			// activation.

			base.Resume(activation);
			if (!IsSuspended())
			{
				regionActivation?.Resume(this);
			}
		} // resume
	} // ExpansionActivationGroup
}
