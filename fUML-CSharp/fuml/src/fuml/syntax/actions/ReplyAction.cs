using fuml.syntax.commonbehavior;

namespace fuml.syntax.actions
{
    public class ReplyAction : Action
    {
        public Trigger? replyToCall = null;
        public List<InputPin> replyValue = new();
        public InputPin? returnInformation = null;

        public void setReplyToCall(Trigger replyToCall)
        {
            this.replyToCall = replyToCall ?? throw new ArgumentNullException(nameof(replyToCall));
        }

        public void addReplyValue(InputPin replyValue)
        {
            AddInput(replyValue);
            this.replyValue.Add(replyValue);
        }

        public void setReturnInformation(InputPin returnInformation)
        {
            AddInput(returnInformation);
            this.returnInformation = returnInformation;
        }
    } // ReplyAction
}
