using uml.commonbehavior;

namespace uml.actions
{
    public class ReplyAction : Action
    {
        public Trigger? replyToCall = null;
        public List<InputPin> replyValue = new();
        public InputPin? returnInformation = null;

        public void SetReplyToCall(Trigger replyToCall)
        {
            this.replyToCall = replyToCall ?? throw new ArgumentNullException(nameof(replyToCall));
        }

        public void AddReplyValue(InputPin replyValue)
        {
            AddInput(replyValue);
            this.replyValue.Add(replyValue);
        }

        public void SetReturnInformation(InputPin returnInformation)
        {
            AddInput(returnInformation);
            this.returnInformation = returnInformation;
        }
    } // ReplyAction
}
