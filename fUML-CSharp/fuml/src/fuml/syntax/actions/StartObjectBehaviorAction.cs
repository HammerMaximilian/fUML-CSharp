namespace fuml.syntax.actions
{
    public class StartObjectBehaviorAction : CallAction
    {
        public InputPin? object_ = null;

	    public void setObject(InputPin object_)
        {
            AddInput(object_);
            this.object_ = object_;

        } // setObject
    } // StartObjectBehaviorAction
}
