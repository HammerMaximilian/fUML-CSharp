namespace fuml.syntax.actions
{
    public class RaiseExceptionAction : Action
    {
        /**
		 * An InputPin whose value becomes the exception object
		 */
        public InputPin? exception;

        public void setException(InputPin exception)
        {
            AddInput(exception);
            this.exception = exception;
        }
    } // RaiseExceptionAction
}
