namespace RecursiveDestruction
{
	internal class RecursiveDestruction
	{
		static void PrintUsage()
		{
			Console.WriteLine(
                "=============================================================================================\n" +
                "USAGE: <program-name> <behavior-name> [<behavior-name> <behavior-name> <behavior-name> <...>]\n" +
                "=============================================================================================\n"
                );
		}

		static int Main(string[] args)
		{
			if(args.Length == 0)
			{
				Console.WriteLine("[ERROR] Must declare at least one behavior name.\n");
				PrintUsage();
				return -1;
			}
		
			foreach (string arg in args)
			{
				RecursiveDestructionEnvironment.Instance().Execute(arg);
			}
		
			return 0;
		}
	}
}
