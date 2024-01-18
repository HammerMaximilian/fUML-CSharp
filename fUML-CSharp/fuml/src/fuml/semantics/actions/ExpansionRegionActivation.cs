using fuml.semantics.activities;
using uml.actions;

namespace fuml.semantics.actions
{
    public class ExpansionRegionActivation : ActionActivation
    {
		public List<ExpansionActivationGroup> activationGroups = new();
		public List<TokenSet> inputTokens = new();
		public List<TokenSet> inputExpansionTokens = new();
		public int next = 0;

		public override List<Token> TakeOfferedTokens()
		{
			// Take the tokens from the input pin and input expansion node
			// activations and save them.

			base.TakeOfferedTokens();

			ExpansionRegion region = (ExpansionRegion)node!;
			List<InputPin> inputPins = region.input;
			List<ExpansionNode> inputElements = region.inputElement;

			inputTokens.Clear();
			inputExpansionTokens.Clear();

			foreach (InputPin inputPin in inputPins)
			{
				TokenSet tokenSet = new();
				tokenSet.tokens = GetPinActivation(inputPin).TakeTokens();
				inputTokens.Add(tokenSet);
			}

			int n = NumberOfValues();

			foreach (ExpansionNode inputElement in inputElements)
			{ 
				ExpansionNodeActivation expansionNodeActivation = GetExpansionNodeActivation(inputElement);
				expansionNodeActivation.Fire(expansionNodeActivation.TakeOfferedTokens());
				List<Token> tokens = expansionNodeActivation.TakeTokens();
				TokenSet tokenSet = new();
				int j = 1;
				while (j <= n)
				{
					tokenSet.tokens.Add(tokens.ElementAt(j - 1));
					j++;
				}
				inputExpansionTokens.Add(tokenSet);
			}

			return new List<Token>();
		} // takeOfferedTokens

		public override void DoAction()
		{
			// If the expansion region has mustIsolate=true, then carry out its
			// behavior with isolation.
			// Otherwise just activate it normally.

			if (((StructuredActivityNode)node!).mustIsolate)
			{
				_beginIsolation();
				DoStructuredActivity();
				_endIsolation();
			}
			else
			{
				DoStructuredActivity();
			}

		} // doAction

		public void DoStructuredActivity()
		{
			// Create a number of expansion region activation groups equal to the
			// number of values expanded in the region,
			// setting the region inputs and group inputs for each group.
			// Run the body of the region in each group, either iteratively or in
			// parallel.
			// Add the outputs of each activation group to the corresonding output
			// expansion node activations.

			ExpansionRegion region = (ExpansionRegion)node!;
			List<InputPin> inputPins = region.input;
			List<ExpansionNode> inputElements = region.inputElement;
			List<ExpansionNode> outputElements = region.outputElement;

			activationGroups.Clear();
			int n = inputExpansionTokens.ElementAt(0).tokens.Count;
			int k = 1;
			while (k <= n)
			{
				ExpansionActivationGroup activationGroup = new();
				activationGroup.regionActivation = this;
				activationGroup.index = k;

				int j = 1;
				while (j <= inputPins.Count)
				{
					OutputPinActivation regionInput = new();
					regionInput.Run();
					activationGroup.regionInputs.Add(regionInput);
					j++;
				}

				j = 1;
				while (j <= inputElements.Count)
				{
					OutputPinActivation groupInput = new();
					groupInput.Run();
					activationGroup.groupInputs.Add(groupInput);
					j++;
				}

				j = 1;
				while (j <= outputElements.Count)
				{
					OutputPinActivation groupOutput = new();
					groupOutput.Run();
					activationGroup.groupOutputs.Add(groupOutput);
					j++;
				}

				activationGroup.CreateNodeActivations(region.node);
				activationGroup.CreateEdgeInstances(region.edge);
				activationGroups.Add(activationGroup);

				k++;
			}

			// List<ExpansionActivationGroup> activationGroups = this.activationGroups;

			if (region.mode == ExpansionKind.iterative)
			{
				Debug.Println("[doStructuredActivity] Expansion mode = iterative");
				next = 1;
				RunIterative();
			}
			else if (region.mode == ExpansionKind.parallel)
			{
				Debug.Println("[doStructuredActivity] Expansion mode = parallel");
				RunParallel();
			}

			DoOutput();

		} // doStructuredActivity

		public void RunIterative()
		{
			// Run the body of the region iteratively, either until all activation
			// groups have run or until the region is suspended.

			List<ExpansionActivationGroup> activationGroups = this.activationGroups;

			while (next <= activationGroups.Count & !IsSuspended())
			{
				ExpansionActivationGroup activationGroup = activationGroups.ElementAt(next - 1);
				RunGroup(activationGroup);
				next++;
			}
		} // runIterative

		public void RunParallel()
		{
			// Run the body of the region concurrently.

			List<ExpansionActivationGroup> activationGroups = this.activationGroups;

			// *** Activate all groups concurrently. ***
			foreach (ExpansionActivationGroup activationGroup in activationGroups)
			{
				RunGroup(activationGroup);
			}
		} // runParallel

		public void DoOutput()
		{
			// Place tokens on the output expansion nodes.

			ExpansionRegion region = (ExpansionRegion)node!;
			List<ExpansionNode> outputElements = region.outputElement;

			Debug.Println("[doOutput] Expansion region " + region.name + " is "
					+ (IsSuspended() ? "suspended." : "completed."));

			if (!IsSuspended())
			{
				for (int i = 0; i < activationGroups.Count; i++)
				{
					ExpansionActivationGroup activationGroup = activationGroups.ElementAt(i);
					List<OutputPinActivation> groupOutputs = activationGroup.groupOutputs;
					for (int j = 0; j < groupOutputs.Count; j++)
					{
						OutputPinActivation groupOutput = groupOutputs.ElementAt(j);
						ExpansionNode outputElement = outputElements.ElementAt(j);
						GetExpansionNodeActivation(outputElement).AddTokens(groupOutput.TakeTokens());
					}
				}
			}
		} // doOutput

		public override void Terminate()
		{
			// Terminate the execution of all contained node activations (which
			// completes the performance of the expansion region activation).

			List<ExpansionActivationGroup> activationGroups = this.activationGroups;
			foreach (ExpansionActivationGroup activationGroup in activationGroups)
			{
				List<OutputPinActivation> groupOutputs = activationGroup.groupOutputs;

				_beginIsolation();
				foreach (OutputPinActivation groupOutput in groupOutputs)
				{
					groupOutput.Fire(groupOutput.TakeOfferedTokens());
				}
				activationGroup.TerminateAll();
				_endIsolation();
			}

			base.Terminate();
		} // terminate

		public override void SendOffers()
		{
			// Fire all output expansion nodes and send offers on all outgoing
			// control flows.

			ExpansionRegion region = (ExpansionRegion)node!;

			// *** Send offers from all output expansion nodes concurrently. ***
			List<ExpansionNode> outputElements = (region is not null) ? region.outputElement : new();
			foreach (ExpansionNode outputElement in outputElements)
			{
				GetExpansionNodeActivation(outputElement).SendUnofferedTokens();
			}

			// Send offers on all outgoing control flows.
			base.SendOffers();

		} // sendOffers

		public void RunGroup(
				ExpansionActivationGroup activationGroup)
		{
			// Set up the inputs for the group with the given index, run the group
			// and then fire the group outputs.

			if (IsRunning())
			{
				Debug.Println("[runGroup] groupInput[0] = "
						+ this.inputExpansionTokens.ElementAt(0).tokens.ElementAt(activationGroup.index - 1).GetValue());

				List<TokenSet> inputTokens = this.inputTokens;
				for (int j = 0; j < inputTokens.Count; j++)
				{
					TokenSet tokenSet = inputTokens.ElementAt(j);
					OutputPinActivation regionInput = activationGroup.regionInputs.ElementAt(j);
					regionInput.ClearTokens();
					regionInput.AddTokens(tokenSet.tokens);
					regionInput.SendUnofferedTokens();
				}

				List<TokenSet> inputExpansionTokens = this.inputExpansionTokens;
				for (int j = 0; j < inputExpansionTokens.Count; j++)
				{
					TokenSet tokenSet = inputExpansionTokens.ElementAt(j);
					OutputPinActivation groupInput = activationGroup.groupInputs.ElementAt(j);
					groupInput.ClearTokens();
					if (tokenSet.tokens.Count >= activationGroup.index)
					{
						groupInput.AddToken(tokenSet.tokens.ElementAt(activationGroup.index - 1));
					}
					groupInput.SendUnofferedTokens();
				}

				activationGroup.Run(activationGroup.nodeActivations);

				TerminateGroup(activationGroup);
			}
		} // runGroup

		public void TerminateGroup(
				ExpansionActivationGroup activationGroup)
		{
			// Terminate the given activation group, after preserving any group
			// outputs.
			if (IsRunning() & !IsSuspended())
			{
				List<OutputPinActivation> groupOutputs = activationGroup.groupOutputs;
				for (int i = 0; i < groupOutputs.Count; i++)
				{
					OutputPinActivation groupOutput = groupOutputs.ElementAt(i);
					groupOutput.Fire(groupOutput.TakeOfferedTokens());
				}

				activationGroup.TerminateAll();
			}
		} // terminateGroup

		public ExpansionNodeActivation GetExpansionNodeActivation(
				ExpansionNode node)
		{
			// Return the expansion node activation corresponding to the given
			// expansion node, in the context of the activity node activation group
			// this expansion region activation is in.
			// [Note: Expansion regions do not own their expansion nodes. Instead,
			// they are own as object nodes by the enclosing activity or group.
			// Therefore, they will already be activated along with their expansion
			// region.]

			return (ExpansionNodeActivation)group!.GetNodeActivation(node);

		} // getExpansionNodeActivation

		public int NumberOfValues()
		{
			// Return the number of values to be acted on by the expansion region of
			// this activation, which is the minimum of the number of values offered
			// to each of the input expansion nodes of the activation.

			ExpansionRegion region = (ExpansionRegion)node!;
			List<ExpansionNode> inputElements = region.inputElement;

			int n = GetExpansionNodeActivation(inputElements.ElementAt(0)).CountOfferedValues();
			int i = 2;
			while (i <= inputElements.Count)
			{
				int count = GetExpansionNodeActivation(
						inputElements.ElementAt(i - 1)).CountOfferedValues();
				if (count < n)
				{
					n = count;
				}
				i++;
			}

			return n;
		} // numberOfValues

		public bool IsSuspended()
		{
			// Check if the activation group for this node is suspended.

			bool suspended = false;
			int i = 1;
			while (i <= activationGroups.Count & !suspended)
			{
				ActivityNodeActivationGroup group = activationGroups.ElementAt(i - 1);
				suspended = group.IsSuspended();
				i++;
			}

			return suspended;
		} // isSuspended

		public void Resume(
				ExpansionActivationGroup activationGroup)
		{
			// Resume an expansion region after the suspension of the given
			// activation group. If the region is iterative, then continue with the
			// iteration. If the region is parallel, and there are no more suspended
			// activation groups, then generate the expansion node output.

			ExpansionRegion region = (ExpansionRegion)node!;

			Resume();
			TerminateGroup(activationGroup);
			if (region.mode == ExpansionKind.iterative)
			{
				RunIterative();
			}

			DoOutput();
		} // resume
	} // ExpansionRegionActivation
}
