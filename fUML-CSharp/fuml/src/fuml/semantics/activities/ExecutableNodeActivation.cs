using fuml.semantics.loci;
using fuml.semantics.values;
using uml.activities;

namespace fuml.semantics.activities
{
    public abstract class ExecutableNodeActivation : ActivityNodeActivation
    {
		public void PropagateException(Value exception)
		{
			// If there is no matching exception handler for the given exception, then propagate
			// the exception to either the containing node activation or the activity execution, as
			// appropriate.
			// If there is a matching exception handler, then use it to catch the exception. 
			// (If there is more than one matching handler, then choose one non-deterministically.)

			List<ExceptionHandler> matchingExceptionHandlers =
					GetMatchingExceptionHandlers(exception);

			if (matchingExceptionHandlers.Count == 0)
			{
				Terminate();
				if (group?.containingNodeActivation is not null)
				{
					group.containingNodeActivation.PropagateException(exception);
				}
				else
				{
					group?.activityExecution?.PropagateException(exception);
				}
			}
			else
			{
				ChoiceStrategy strategy = (ChoiceStrategy)GetExecutionLocus()!.factory!.GetStrategy("choice");
				ExceptionHandler handler = matchingExceptionHandlers.ElementAt(strategy.Choose(matchingExceptionHandlers.Count) - 1);
				Handle(exception, handler);
			}
		}

		public List<ExceptionHandler> GetMatchingExceptionHandlers(Value exception)
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
					if (exception.IsInstanceOf(handler.exceptionType.ElementAt(j - 1)))
					{
						matchingHandlers.Add(handler);
						noMatch = false;
					}
					j++;
				}

			}

			return matchingHandlers;
		}

		public virtual void Handle(Value exception, ExceptionHandler handler)
		{
			// Offer the given exception to the body of the given exception handler
			// on its exception input node.

			Debug.Println("[handle] action = " + node?.name + ", exception = " + exception);

			ActivityNodeActivation? handlerBodyActivation = group?.GetNodeActivation(handler?.handlerBody!);
			ActivityNodeActivation? inputActivation = handlerBodyActivation?.group?.GetNodeActivation(handler?.exceptionInput!);

            ObjectToken token = new()
            {
                value = exception
            };
            inputActivation?.AddToken(token);

			handlerBodyActivation?.ReceiveOffer();
		}
	} // ExecutableNodeActivation
}
