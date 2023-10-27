using fuml.semantics.loci;
using fuml.semantics.values;
using fuml.syntax.activities;

namespace fuml.semantics.activities
{
    public abstract class ExecutableNodeActivation : ActivityNodeActivation
    {
		public void propagateException(Value exception)
		{
			// If there is no matching exception handler for the given exception, then propagate
			// the exception to either the containing node activation or the activity execution, as
			// appropriate.
			// If there is a matching exception handler, then use it to catch the exception. 
			// (If there is more than one matching handler, then choose one non-deterministically.)

			List<ExceptionHandler> matchingExceptionHandlers =
					getMatchingExceptionHandlers(exception);

			if (matchingExceptionHandlers.Count == 0)
			{
				terminate();
				if (group?.containingNodeActivation is not null)
				{
					group.containingNodeActivation.propagateException(exception);
				}
				else
				{
					group?.activityExecution?.propagateException(exception);
				}
			}
			else
			{
				ChoiceStrategy strategy = (ChoiceStrategy)getExecutionLocus()!.factory!.getStrategy("choice");
				ExceptionHandler handler = matchingExceptionHandlers.ElementAt(strategy.choose(matchingExceptionHandlers.Count) - 1);
				handle(exception, handler);
			}
		}

		public List<ExceptionHandler> getMatchingExceptionHandlers(Value exception)
		{
			// Return the set of exception handlers that have an exception type
			// for which the given exception is an instance.

			List<ExceptionHandler> handlers = ((ExecutableNode)node!).handler;
			List<ExceptionHandler> matchingHandlers = new();

			foreach (ExceptionHandler handler in handlers)
			{
				bool noMatch = true;
				int j = 1;
				while (noMatch & j <= handler.exceptionType.Count)
				{
					if (exception.isInstanceOf(handler.exceptionType.ElementAt(j - 1)))
					{
						matchingHandlers.Add(handler);
						noMatch = false;
					}
					j++;
				}

			}

			return matchingHandlers;
		}

		public virtual void handle(Value exception, ExceptionHandler handler)
		{
			// Offer the given exception to the body of the given exception handler
			// on its exception input node.

			Debug.println("[handle] action = " + node?.name + ", exception = " + exception);

			ActivityNodeActivation? handlerBodyActivation = group?.getNodeActivation(handler?.handlerBody!);
			ActivityNodeActivation? inputActivation = handlerBodyActivation?.group?.getNodeActivation(handler?.exceptionInput!);

            ObjectToken token = new()
            {
                value = exception
            };
            inputActivation?.addToken(token);

			handlerBodyActivation?.receiveOffer();
		}
	} // ExecutableNodeActivation
}
