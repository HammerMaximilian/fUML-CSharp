using fuml.semantics.commonbehavior;
using fuml.semantics.values;
using uml.activities;
using uml.classification;

namespace fuml.semantics.activities
{
    public class ActivityParameterNodeActivation : ObjectNodeActivation
    {
		public override void Run()
		{
			// If this activation is for an input activity parameter node for a
			// stream parameter, then register a listener for this activation
			// with the streaming parameter value corresponding to the parameter.

			base.Run();

			Parameter? parameter = ((ActivityParameterNode)node!)?.parameter!;
			ParameterValue parameterValue = GetActivityExecution().GetParameterValue(parameter);
			if (node!.incoming.Count == 0 &
					parameterValue is StreamingParameterValue) {
				ActivityParameterNodeStreamingParameterListener listener = new();
				listener.nodeActivation = this;
				((StreamingParameterValue)parameterValue).Register(listener);
				Debug.Println("[run] Registering for streaming parameter " + parameter.name + ".");
			}
		}

		public override void Fire(List<Token> incomingTokens)
		{
			// If there are no incoming edges, this is an activation of an input
			// activity parameter node.
			// Get the values from the input parameter indicated by the activity
			// parameter node and offer those values as object tokens.
			// If there are one or more incoming edges, this is an activation of an
			// output activity parameter node.
			// If the output parameter is not streaming, take the tokens offered on 
			// incoming edges and add them to the set of tokens being offered.
			// If the output parameter is streaming, post the values from the
			// the tokens offered on incoming edges to the parameter value.
			// (Note that an output activity parameter node may fire multiple times,
			// accumulating tokens offered to it.)

			Parameter parameter = ((ActivityParameterNode)node!).parameter!;
			ParameterValue parameterValue = GetActivityExecution().GetParameterValue(parameter);

			if (node.incoming.Count == 0)
			{
				Debug.Println("[fire] Input activity parameter node " + node.name + "...");
				if (parameterValue is not null)
				{
					Debug.Println("[fire] Parameter has " + parameterValue.values.Count + " value(s).");
					List<Value> values = parameterValue.values;
					foreach (Value value in values)
					{
                        ObjectToken token = new()
                        {
                            value = value
                        };
                        AddToken(token);
					}
					SendUnofferedTokens();
				}
			}

			else
			{
				Debug.Println("[fire] Output activity parameter node " + node.name + "...");

				AddTokens(incomingTokens);

				if (parameterValue is StreamingParameterValue streamingParameterValue) {
					List<Value> values = new();
					foreach (Token token in incomingTokens)
					{
						Value value = token.GetValue();
						if (value is not null)
						{
							values.Add(value);
							Debug.Println("[event] Post activity=" + GetActivityExecution().GetBehavior().name
									+ " parameter=" + parameterValue?.parameter?.name
									+ " value=" + value);
						}
					}
					streamingParameterValue.Post(values);
					base.ClearTokens();
				}
			}

		} // fire

		public override void ClearTokens()
		{
			// Clear all held tokens only if this is an input parameter node.

			if (node!.incoming.Count == 0)
			{
				base.ClearTokens();
			}
		} // clearTokens
	} // ActivityParameterNodeActivation
}
