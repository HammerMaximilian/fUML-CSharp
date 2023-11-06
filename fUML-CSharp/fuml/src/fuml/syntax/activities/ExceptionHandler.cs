using fuml.syntax.classification;
using fuml.syntax.commonstructure;

namespace fuml.syntax.activities
{
    public class ExceptionHandler : Element
    {
        /**
         * An ObjectNode within the handlerBody. When the ExceptionHandler catches an
         * exception, the exception token is placed on this ObjectNode, causing the
         * handlerBody to execute.
         */
        public ObjectNode? exceptionInput;

        /**
         * The Classifiers whose instances the ExceptionHandler catches as exceptions.
         * If an exception occurs whose type is any exceptionType, the ExceptionHandler
         * catches the exception and executes the handlerBody.
         */
        public List<Classifier> exceptionType = new();

        /**
         * An ExecutableNode that is executed if the ExceptionHandler catches an
         * exception.
         */
        public ExecutableNode? handlerBody;

        /**
         * The ExecutableNode protected by the ExceptionHandler. If an exception
         * propagates out of the protectedNode and has a type matching one of the
         * exceptionTypes, then it is caught by this ExceptionHandler.
         */
        public ExecutableNode? protectedNode;

        public void SetExceptionInput(ObjectNode exceptionInput)
        {
            this.exceptionInput = exceptionInput ?? throw new ArgumentNullException(nameof(exceptionInput));
        }

        public void AddExceptionType(Classifier exceptionType)
        {
            if (exceptionType is null)
            {
                throw new ArgumentNullException(nameof(exceptionType));
            }

            this.exceptionType.Add(exceptionType);
        }

        public void SetHandlerBody(ExecutableNode handlerBody)
        {
            this.handlerBody = handlerBody ?? throw new ArgumentNullException(nameof(handlerBody));
        }
    }
}
