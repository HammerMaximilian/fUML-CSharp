namespace Operation_RequiredInterface_DelegationChain
{
	internal class Operation_RequiredInterface_DelegationChain
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
				Operation_RequiredInterface_DelegationChainEnvironment.Instance().Execute(arg);
			}
		
			return 0;
		}
	}
}
