using fuml.semantics.commonbehavior;
using fuml.semantics.values;
using fuml.syntax.activities;
using fuml.syntax.classification;

namespace fuml.semantics.activities
{
    public class ActivityExecution : Execution
    {
		public ActivityNodeActivationGroup? activationGroup = null;
		public bool isStreaming;

		public override void Execute()
		{
			// Execute the activity for this execution by creating an activity node
			// activation group and activating all the activity nodes in the
			// activity. If the activity has no streaming input parameters, then, when
			// the execution is complete, copy the values on the tokens offered by
			// output parameter nodes to the corresponding output parameters.

			Activity activity = (Activity)GetTypes().ElementAt(0);

			Debug.Println("[execute] Activity " + activity.name + "...");
			Debug.Println("[event] Execute activity=" + activity.name);

			isStreaming = false;
			int i = 1;
			List<Parameter> parameters = activity.ownedParameter;
			while (i <= parameters.Count & !isStreaming)
			{
				Parameter parameter = parameters.ElementAt(i - 1);
				isStreaming =
						(parameter.direction == ParameterDirectionKind.in_ |
						 parameter.direction == ParameterDirectionKind.inout) &
						parameter.isStream;
				i++;
			}

			Debug.Println("[execute] isStreaming = " + isStreaming);

            activationGroup = new ActivityNodeActivationGroup
            {
                activityExecution = this
            };
            activationGroup.Activate(activity.node, activity.edge);

			if (!isStreaming)
			{
				Complete();
			}
		} // execute

		public void Complete()
		{
			// Copy the values on the tokens offered by output parameter nodes for
			// non-stream parameters to the corresponding output parameter values.

			Activity activity = (Activity)GetTypes().ElementAt(0);

			List<ActivityParameterNodeActivation> outputActivations = (activationGroup is not null) ? activationGroup.GetOutputParameterNodeActivations() : new();

			foreach (ActivityParameterNodeActivation outputActivation in outputActivations)
			{
				Parameter parameter = ((ActivityParameterNode)outputActivation.node!).parameter!;

				if (!parameter.isStream)
				{
					ParameterValue parameterValue = new();
					parameterValue.parameter = parameter;

					List<Token> tokens = outputActivation.GetTokens();
					foreach (Token token in tokens)
					{
						Value value = ((ObjectToken)token)?.value!;
						if (value is not null)
						{
							parameterValue.values.Add(value);
							Debug.Println("[event] Output activity=" + activity.name
									+ " parameter=" + parameterValue.parameter.name
									+ " value=" + value);
						}
					}

					SetParameterValue(parameterValue);
				}
			}

			Debug.Println("[execute] Activity " + activity.name + " completed.");
		}

		public override Value Copy()
		{
			// Create a new activity execution that is a copy of this execution.
			// [Note: This currently just returns a non-executing execution for the
			// same activity as this execution.]

			return base.Copy();
		} // copy

		protected override Value New_()
		{
			// Create a new activity execution with empty properties.

			return new ActivityExecution();
		} // new_

		public override void Terminate()
		{
			// Terminate all node activations. If this execution is non-streaming,
			// then this is sufficient to result in the activity execution ultimately
			// completing. Otherwise, explicitly complete the execution.

			if (activationGroup is not null)
			{
				activationGroup.TerminateAll();
			}

			if (isStreaming)
			{
				Complete();
			}
		} // terminate
	} // ActivityExecution
}
