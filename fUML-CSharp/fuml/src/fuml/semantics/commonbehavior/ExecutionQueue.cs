namespace fuml.semantics.commonbehavior
{
    public class ExecutionQueue
    {
		private readonly List<Execution> queue = new();

		private void run()
		{
			while (runNext()) ;
		}

		private bool runNext()
		{
			if (queue.Count == 0)
			{
				return false;
			}
			else
			{
				Execution execution = queue.ElementAt(0);
				queue.RemoveAt(0);
				if (execution?.context?.getTypes().Count > 0)
				{
					Debug.println("[runNext] execution = " + execution);
					execution.execute();
				}
				return true;
			}
		}

		private void add(Execution execution)
		{
			queue.Add(execution);
		}

		private static ExecutionQueue? executionQueue;

		public static bool notStarted()
		{
			return executionQueue is null;
		}

		public static void start(Execution execution)
		{
			executionQueue = new();
			executionQueue.add(execution);
			executionQueue.run();
			executionQueue = null;
		}

		public static bool step()
		{
			return (executionQueue is not null) && executionQueue.runNext();
		}

		public static void enqueue(Execution execution)
		{
			if (notStarted())
			{
				start(execution);
			}
			else
			{
				Debug.println("[enqueue] execution = " + execution);
				executionQueue?.add(execution);
			}
		}
	} // ExecutionQueue
}
