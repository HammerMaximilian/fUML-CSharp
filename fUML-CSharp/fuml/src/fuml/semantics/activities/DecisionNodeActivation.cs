using fuml.semantics.commonbehavior;
using fuml.semantics.values;
using fuml.syntax.activities;
using fuml.syntax.classification;
using fuml.syntax.commonbehavior;
using fuml.syntax.values;

namespace fuml.semantics.activities
{
    public class DecisionNodeActivation : ControlNodeActivation
    {
		public Execution? decisionInputExecution = null;

		public override void Fire(
				List<Token> incomingTokens)
		{
			// Get the decision values and test them on each guard.
			// Forward the offer over the edges for which the test succeeds.

			Debug.println("[fire] Decision node " + node?.name + "...");

			// List<Token> incomingTokens = this.takeOfferedTokens();
			List<Token> removedControlTokens = this.RemoveJoinedControlTokens(incomingTokens);
			List<Value> decisionValues = GetDecisionValues(incomingTokens);

			List<ActivityEdgeInstance> outgoingEdges = this.outgoingEdges;
			foreach (ActivityEdgeInstance edgeInstance in outgoingEdges)
			{
				ValueSpecification guard = edgeInstance?.edge?.guard!;

				List<Token> offeredTokens = new();
				for (int j = 0; j < incomingTokens.Count; j++)
				{
					Token incomingToken = incomingTokens.ElementAt(j);
					Value decisionValue = decisionValues.ElementAt(j);
					if (this.Test(guard, decisionValue))
					{
						offeredTokens.Add(incomingToken);
					}
				}

				if (offeredTokens.Count > 0)
				{
					foreach (Token removedControlToken in removedControlTokens)
					{
						offeredTokens.Add(removedControlToken);
					}
					edgeInstance?.SendOffer(offeredTokens);
				}
			}
		} // fire

		public List<Value> GetDecisionValues(
				List<Token> incomingTokens)
		{
			// If there is neither a decision input flow nor a decision input
			// behavior, then return the set of values from the incoming tokens.
			// [In this case, the single incoming edge must be an object flow.]
			// If there is a decision input flow, but no decision input behavior,
			// then return a List<> of the decision input values equal in size to the
			// number of incoming tokens.
			// If there is both a decision input flow and a decision input behavior,
			// then execute the decision input behavior once for each incoming token
			// and return the set of resulting values.
			// If the primary incoming edge is an object flow, then the value on
			// each object token is passed to the decision input behavior, along
			// with the decision input flow value, if any.
			// If the primary incoming edge is a control flow, then the decision
			// input behavior only receives the decision input flow, if any.

			Value decisionInputValue = GetDecisionInputFlowValue();

			List<Value> decisionValues = new();
			for (int i = 0; i < incomingTokens.Count; i++)
			{
				Token incomingToken = incomingTokens.ElementAt(i);
				Value value = ExecuteDecisionInputBehavior(incomingToken
						.GetValue(), decisionInputValue);
				decisionValues.Add(value);
			}

			// Debug.println("[getDecisionValues] " + decisionValues.Count +
			// " decision value(s):");
			for (int i = 0; i < decisionValues.Count; i++)
			{
				Value decisionValue = decisionValues.ElementAt(i);
				Debug.println("[getDecisionValues] decisionValues[" + i + "] = " + decisionValue);
			}

			return decisionValues;
		} // getDecisionValues

		public Value ExecuteDecisionInputBehavior(
                Value inputValue,
                Value decisionInputValue)
		{
			// Create the decision input execution from the decision input behavior.
			// If the behavior has input parameter(s), set the input parameter(s) of
			// the execution to the given value(s).
			// Execute the decision input execution and then remove it.
			// Return the value of the output parameter of the execution.
			// If there is no decision input behavior, the decision input value is
			// returned, if one is given, otherwise the input value is used as the
			// decision value.

			Debug.println("[executeDecisionBehavior] inputValue = " + inputValue);

			Behavior decisionInputBehavior = ((DecisionNode)node!)?.decisionInput!;

            Value? decisionInputResult;

            if (decisionInputBehavior is null)
			{

				if (decisionInputValue is not null)
				{
					decisionInputResult = decisionInputValue;
				}
				else
				{
					decisionInputResult = inputValue;
				}

			}
			else
			{

				decisionInputExecution = GetExecutionLocus()?.factory?.createExecution(decisionInputBehavior, GetExecutionContext());

				int i = 1;
				int j = 0;
				while ((j == 0 | (j == 1 & decisionInputValue is not null))
						& i <= decisionInputBehavior.ownedParameter.Count)
				{
					Parameter parameter = decisionInputBehavior.ownedParameter.ElementAt(i - 1);
					if (parameter.direction.Equals(ParameterDirectionKind.in_)
							| parameter.direction
									.Equals(ParameterDirectionKind.inout))
					{
                        ParameterValue inputParameterValue = new()
                        {
                            parameter = parameter
                        };

                        j++;
						if (j == 1 && inputValue != null)
						{
							inputParameterValue.values.Add(inputValue);
						}
						else
						{
							inputParameterValue.values.Add(decisionInputValue!);
						}

						decisionInputExecution.SetParameterValue(inputParameterValue);
					}
					i++;
				}

				decisionInputExecution.Execute();

				List<ParameterValue> outputParameterValues = decisionInputExecution
						.GetOutputParameterValues();
				decisionInputExecution.destroy();

				decisionInputResult = outputParameterValues.ElementAt(0).values.ElementAt(0);
			}

			return decisionInputResult;
		} // executeDecisionInputBehavior

		public override void Terminate()
		{
			// Terminate the decision input execution, if any, and then terminate
			// this activation.

			if (decisionInputExecution is not null)
			{
				decisionInputExecution.Terminate();
			}

			base.Terminate();
		} // terminate

		public override bool IsReady()
		{
			// Check that all incoming edges have sources that are offering tokens.
			// [This should be at most two incoming edges, if there is a decision
			// input flow.]

			int i = 1;
			bool ready = true;
			while (ready & i <= incomingEdges.Count)
			{
				ready = incomingEdges.ElementAt(i - 1).HasOffer();
				i++;
			}

			return ready;
		} // isReady

		public override List<Token> TakeOfferedTokens()
		{
			// Get tokens from the incoming edge that is not the decision input
			// flow.

			ObjectFlow decisionInputFlow = ((DecisionNode)node!)?.decisionInputFlow!;

			List<Token> allTokens = new();
			List<ActivityEdgeInstance> incomingEdges = this.incomingEdges;
			foreach (ActivityEdgeInstance edgeInstance in incomingEdges)
			{
				if (edgeInstance.edge != decisionInputFlow)
				{
					List<Token> tokens = edgeInstance.TakeOfferedTokens();
					for (int j = 0; j < tokens.Count; j++)
					{
						allTokens.Add(tokens.ElementAt(j));
					}
				}
			}

			return allTokens;
		} // takeOfferedTokens

		public Value GetDecisionInputFlowValue()
		{
			// Take the next token available on the decision input flow, if any, and
			// return its value.

			ActivityEdgeInstance decisionInputFlowInstance = GetDecisionInputFlowInstance();

			Value? value = null;
			if (decisionInputFlowInstance is not null)
			{
				List<Token> tokens = decisionInputFlowInstance.TakeOfferedTokens();
				if (tokens.Count > 0)
				{
					value = tokens.ElementAt(0).GetValue();
				}
			}

			return value!;
		} // getDecisionInputFlowValue

		public ActivityEdgeInstance GetDecisionInputFlowInstance()
		{
			// Get the activity edge instance for the decision input flow, if any.

			ActivityEdge decisionInputFlow = ((DecisionNode)node!)?.decisionInputFlow!;

			ActivityEdgeInstance? edgeInstance = null;
			if (decisionInputFlow is not null)
			{
				int i = 1;
				while (edgeInstance == null & i <= incomingEdges.Count)
				{
					ActivityEdgeInstance incomingEdge = incomingEdges.ElementAt(i - 1);
					if (incomingEdge.edge == decisionInputFlow)
					{
						edgeInstance = incomingEdge;
					}
					i++;
				}
			}

			return edgeInstance!;
		} // getDecisionInputFlowInstance

		public bool Test(ValueSpecification guard, Value value)
		{
			// Test if the given value matches the guard. If there is no guard,
			// return true.

			bool guardResult = true;
			if (guard is not null)
			{
				Value guardValue = GetExecutionLocus()!.executor!.evaluate(guard);
				guardResult = guardValue.equals(value);
			}

			return guardResult;
		} // test

		public List<Token> RemoveJoinedControlTokens(
                List<Token> incomingTokens)
		{
			// If the primary incoming edge is an object flow, then remove any
			// control tokens from the incoming tokens and return them.
			// [Control tokens may effectively be offered on an object flow outgoing
			// from a join node that has both control and object flows incoming.]

			List<Token> removedControlTokens = new();

			if (HasObjectFlowInput())
			{
				int i = 1;
				while (i <= incomingTokens.Count)
				{
					Token token = incomingTokens.ElementAt(i - 1);
					if (token.IsControl())
					{
						removedControlTokens.Add(token);
						incomingTokens.RemoveAt(i - 1);
						i--;
					}
					i++;
				}
			}

			return removedControlTokens;
		} // removeJoinedControlTokens

		public bool HasObjectFlowInput()
		{
			// Check that the primary incoming edge is an object flow.

			ActivityEdge decisionInputFlow = ((DecisionNode)node!)?.decisionInputFlow!;

			bool isObjectFlow = false;
			int i = 1;
			while (!isObjectFlow & i <= incomingEdges.Count)
			{
				ActivityEdge edge = incomingEdges.ElementAt(i - 1)?.edge!;
				isObjectFlow = edge != decisionInputFlow && edge is ObjectFlow;
				i++;
			}

			return isObjectFlow;
		} // hasObjectFlowInput
	} // DecisionNodeActivation
}
