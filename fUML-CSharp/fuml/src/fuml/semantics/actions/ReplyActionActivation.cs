using fuml.semantics.commonbehavior;
using fuml.semantics.values;
using uml.actions;
using uml.commonbehavior;

namespace fuml.semantics.actions
{
    public class ReplyActionActivation : ActionActivation
    {
        public override void DoAction()
        {
            // Reply to the call represented by the return information on
            // the return information pin using the reply values given
            // on the reply value pins.

            ReplyAction action = (node as ReplyAction)!;
            if (action is null) throw new InvalidCastException();

            Trigger replyToCall = action.replyToCall!;
            List<InputPin> replyValuePins = action.replyValue;
            InputPin returnInformationPin = action.returnInformation!;

            List<Value> values = TakeTokens(returnInformationPin);
            ReturnInformation returnInformation = (ReturnInformation)values.ElementAt(0);
            Debug.Println("[doAction] action = " + action.name + " returnInformation = " + returnInformation);

            if (replyToCall.event_ is CallEvent &

                ((CallEvent)replyToCall.event_!).operation ==
                returnInformation.GetOperation())
            {

                List<ParameterValue> parameterValues = new();
                int i = 1;
                while (i <= replyValuePins.Count)
                {
                    ParameterValue parameterValue = new()
                    {
                        values = TakeTokens(replyValuePins.ElementAt(i - 1))
                    };
                    parameterValues.Add(parameterValue);
                    i++;
                }

                returnInformation.Reply(parameterValues);
            }
        }
    } // ReplyActionActivation
}
