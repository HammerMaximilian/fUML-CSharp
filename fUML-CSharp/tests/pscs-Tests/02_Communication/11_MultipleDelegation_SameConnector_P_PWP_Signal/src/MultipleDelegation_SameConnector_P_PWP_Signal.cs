namespace MultipleDelegation_SameConnector_P_PWP_Signal
{
	internal class MultipleDelegation_SameConnector_P_PWP_Signal
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
				MultipleDelegation_SameConnector_P_PWP_SignalEnvironment.Instance().Execute(arg);
			}
		
			return 0;
		}
	}
}
