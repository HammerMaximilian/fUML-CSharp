using fuml.semantics.activities;
using fuml.semantics.commonbehavior;
using fuml.semantics.values;
using fuml.syntax.actions;

namespace fuml.semantics.actions
{
    public class InputPinActivation : PinActivation
    {
		public StreamingParameterValue? streamingParameterValue = null;

		public override void ReceiveOffer()
		{
			// If this pin activation is streaming, then accept offered tokens 
			// up to the multiplicity upper bound of the pin and fire on the 
			// accepted tokens.
			// If the pin activation is not streaming, then forward the offer 
			// to the action activation. (When all input pins are ready, the 
			// action will fire them.)

			if (IsStreaming())
			{
				base.ReceiveOffer();
			}
			else
			{
				actionActivation?.ReceiveOffer();
			}
		} // receiveOffer

		public override void Fire(List<Token> incomingTokens)
		{
			// Add all incoming tokens to the pin.
			// If the pin activation is streaming, and there are incoming tokens, 
			// then post the values from the tokens to the streaming parameter value. 
			// Then check if the streaming parameter value has terminated and, if so, 
			// terminate the action activation.

			base.Fire(incomingTokens);

			if (IsStreaming() & incomingTokens.Count > 0)
			{
				List<Value> values = new();
				foreach (Token token in incomingTokens)
				{
					Value value = token.GetValue();
					if (value is not null)
					{
						values.Add(value);
					}
				}
				streamingParameterValue?.Post(values);

				if (StreamingIsTerminated())
				{
					if (actionActivation is CallActionActivation callActionActivation)
					{
						callActionActivation.CompleteStreamingCall();
					}
				}
			}
		}

		public override bool IsReady()
		{
			// If this pin activation is not streaming, then return true if the total 
			// number of values already being offered by the pin plus those being 
			// offered by the sources of incoming edges is at least equal to the 
			// minimum multiplicity of the pin.
			// If this pin activation is streaming, then return true if the minimum 
			// multiplicity is zero or if there is at least one offered value.

			bool ready = base.IsReady();
			if (ready)
			{
				int minimum = ((Pin)node!).multiplicityElement.lower;
				if (IsStreaming())
				{
					if (minimum > 0)
					{
						minimum = 1;
					}
				}
				ready = GetTotalValueCount() >= minimum;
			}

			return ready;
		} // isReady

		public bool IsReadyForStreaming()
		{
			// Return true if this pin activation is ready assuming that it
			// corresponds to a streaming parameter. In this case, it is
			// ready if it has a lower multiplicity bound of zero, or if
			// there is at least one offered value.

			return base.IsReady() &
					(((Pin)node!).multiplicityElement.lower == 0 |
					 GetTotalValueCount() >= 1);
		}

		public bool IsStreaming()
		{
			// Return true if this pin activation is for a pin that corresponds
			// to a streaming input parameter.

			return streamingParameterValue != null;
		}

		public bool StreamingIsTerminated()
		{
            _beginIsolation();
            bool isTerminated = streamingParameterValue!.IsTerminated();
            Debug.println("[streamingIsTerminated] isTerminated = " + isTerminated);
			_endIsolation();

			return isTerminated;
		}

		public int GetTotalValueCount()
		{
			// Return the total number of values already being offered by the
			// pin plus those being offered by the sources of incoming edges.

			return CountUnofferedTokens() + CountOfferedValues();
		}
	} // InputPinActivation
}
