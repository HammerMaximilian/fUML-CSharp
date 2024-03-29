﻿using fuml.semantics.commonbehavior;
using uml.actions;

namespace fuml.semantics.actions
{
    public class AcceptCallActionActivation : AcceptEventActionActivation
    {
		public override void Accept(EventOccurrence eventOccurrence)
		{
			// Accept the given event occurrence, which must be a call event occurrence.
			// Place return information for the call on the return information
			// output pin. Then complete the acceptance of the event occurrence
			// as usual.

			AcceptCallAction action = (node as AcceptCallAction)!;
			OutputPin returnInformationPin = action?.returnInformation!;

            ReturnInformation returnInformation = new()
            {
                callEventOccurrence = (CallEventOccurrence)eventOccurrence
            };

            PutToken(returnInformationPin, returnInformation);

			Debug.Println("[accept] action = " + action?.name +
					", returnInformation = " + returnInformation);

			base.Accept(eventOccurrence);
		}
	} // AcceptCallActionActivation
}
