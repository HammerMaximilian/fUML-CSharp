namespace fuml.syntax.actions
{
    public class StartClassifierBehaviorAction : Action
    {
        public InputPin? object_ = null;

        public void SetObject(InputPin object_)
        {
            AddInput(object_);
            this.object_ = object_;

        } // setObject
    } // StartClassifierBehaviorAction
}
