namespace fuml.syntax.activities
{
    public abstract class ExecutableNode : ActivityGroup
    {
        /**
         * A set of ExceptionHandlers that are examined if an exception propagates out of the ExceptionNode.
         */
        public List<ExceptionHandler> handler = new();

        public void addExceptionHandler(ExceptionHandler handler)
        {
            if (handler is null)
            {
                throw new ArgumentNullException(nameof(handler));
            }

            this.addOwnedElement(handler);
            this.handler.Add(handler);
            handler.protectedNode = this;
        }
    } // ExecutableNode
}
