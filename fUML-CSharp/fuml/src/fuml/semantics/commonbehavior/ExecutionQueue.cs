namespace fuml.semantics.commonbehavior
{
    public class ExecutionQueue
    {
		private readonly List<Execution> queue = new();

		private void Run()
		{
			while (RunNext()) ;
		}

		private bool RunNext()
		{
			if (queue.Count == 0)
			{
				return false;
			}
			else
			{
				Execution execution = queue.ElementAt(0);
				queue.RemoveAt(0);
				if (execution?.context?.GetTypes().Count > 0)
				{
					Debug.Println("[runNext] execution = " + execution);
					execution.Execute();
				}
				return true;
			}
		}

		private void Add(Execution execution)
		{
			queue.Add(execution);
		}

		private static ExecutionQueue? executionQueue;

		public static bool NotStarted()
		{
			return executionQueue is null;
		}

		public static void Start(Execution execution)
		{
			executionQueue = new();
			executionQueue.Add(execution);
			executionQueue.Run();
			executionQueue = null;
		}

		public static bool Step()
		{
			return (executionQueue is not null) && executionQueue.RunNext();
		}

		public static void Enqueue(Execution execution)
		{
			if (NotStarted())
			{
				Start(execution);
			}
			else
			{
				Debug.Println("[enqueue] execution = " + execution);
				executionQueue?.Add(execution);
			}
		}
	} // ExecutionQueue
}
