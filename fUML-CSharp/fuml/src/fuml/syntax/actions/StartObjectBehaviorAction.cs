namespace fuml.syntax.actions
{
    public class StartObjectBehaviorAction : CallAction
    {
        public InputPin? object_ = null;

	    public void SetObject(InputPin object_)
        {
            AddInput(object_);
            this.object_ = object_;

        } // setObject
    } // StartObjectBehaviorAction
}
