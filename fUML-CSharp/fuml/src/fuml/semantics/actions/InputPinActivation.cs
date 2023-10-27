using fuml.semantics.activities;
using fuml.semantics.commonbehavior;
using fuml.semantics.values;
using fuml.syntax.actions;

namespace fuml.semantics.actions
{
    public class InputPinActivation : PinActivation
    {
		public StreamingParameterValue? streamingParameterValue = null;

		public override void receiveOffer()
		{
			// If this pin activation is streaming, then accept offered tokens 
			// up to the multiplicity upper bound of the pin and fire on the 
			// accepted tokens.
			// If the pin activation is not streaming, then forward the offer 
			// to the action activation. (When all input pins are ready, the 
			// action will fire them.)

			if (isStreaming())
			{
				base.receiveOffer();
			}
			else
			{
				actionActivation?.receiveOffer();
			}
		} // receiveOffer

		public override void fire(List<Token> incomingTokens)
		{
			// Add all incoming tokens to the pin.
			// If the pin activation is streaming, and there are incoming tokens, 
			// then post the values from the tokens to the streaming parameter value. 
			// Then check if the streaming parameter value has terminated and, if so, 
			// terminate the action activation.

			base.fire(incomingTokens);

			if (isStreaming() & incomingTokens.Count > 0)
			{
				List<Value> values = new();
				foreach (Token token in incomingTokens)
				{
					Value value = token.getValue();
					if (value is not null)
					{
						values.Add(value);
					}
				}
				streamingParameterValue?.post(values);

				if (streamingIsTerminated())
				{
					if (actionActivation is CallActionActivation callActionActivation)
					{
						callActionActivation.completeStreamingCall();
					}
				}
			}
		}

		public override bool isReady()
		{
			// If this pin activation is not streaming, then return true if the total 
			// number of values already being offered by the pin plus those being 
			// offered by the sources of incoming edges is at least equal to the 
			// minimum multiplicity of the pin.
			// If this pin activation is streaming, then return true if the minimum 
			// multiplicity is zero or if there is at least one offered value.

			bool ready = base.isReady();
			if (ready)
			{
				int minimum = ((Pin)node!).multiplicityElement.lower;
				if (isStreaming())
				{
					if (minimum > 0)
					{
						minimum = 1;
					}
				}
				ready = getTotalValueCount() >= minimum;
			}

			return ready;
		} // isReady

		public bool isReadyForStreaming()
		{
			// Return true if this pin activation is ready assuming that it
			// corresponds to a streaming parameter. In this case, it is
			// ready if it has a lower multiplicity bound of zero, or if
			// there is at least one offered value.

			return base.isReady() &
					(((Pin)node!).multiplicityElement.lower == 0 |
					 getTotalValueCount() >= 1);
		}

		public bool isStreaming()
		{
			// Return true if this pin activation is for a pin that corresponds
			// to a streaming input parameter.

			return streamingParameterValue != null;
		}

		public bool streamingIsTerminated()
		{
            _beginIsolation();
            bool isTerminated = streamingParameterValue!.isTerminated();
            Debug.println("[streamingIsTerminated] isTerminated = " + isTerminated);
			_endIsolation();

			return isTerminated;
		}

		public int getTotalValueCount()
		{
			// Return the total number of values already being offered by the
			// pin plus those being offered by the sources of incoming edges.

			return countUnofferedTokens() + countOfferedValues();
		}
	} // InputPinActivation
}
