/*
 * DelegationConnectors_P_PEnvironment.cs
 * 
 * Auto-generated file
 */

/* Start of user code : User-defined using directives
 * This section may be used for using directives.
 * It will not be overwritten by future generation processes.
 */

/*
 * End of user code
 */

namespace DelegationConnectors_P_P
{
	public class DelegationConnectors_P_PEnvironment : pscs.environment.Environment
	{
		private static DelegationConnectors_P_PEnvironment? instance;

		public static DelegationConnectors_P_PEnvironment Instance()
		{
			if(instance is null)
			{
				instance = new();
				instance.inMemoryModel = DelegationConnectors_P_PModel.Instance();
			}

			return instance;
		}

		public DelegationConnectors_P_PEnvironment()
		{
			/*
			 * Create custom opaque behavior execution instances and add them to the execution environment.
			 */
		
			/* Start of user code : Additional environment initializations
		 	 * This section may be used to do any additional environment initialization,
			 * for example initializing user-defined members.
		 	 * It will not be overwritten by future generation processes.
		 	 */
		
			/*
		 	 * End of user code
		 	 */
		}

		public override void Execute(string behaviorName)
		{
			/* Start of user code : Context and inputs initializations
		 	 * This section may be used to initialize the execution context 
			 * as well as input parameter values if required.
		 	 * It will not be overwritten by future generation processes.
		 	 */
		
			//context = ...;
			//inputs = ...;
		
			/*
		 	 * End of user code
		 	 */
		
			/*
			 * Start execution via base class call
			 */
			base.Execute(behaviorName);
		
			/* Start of user code : Outputs evaluation
		 	 * This section may be used to evaluate output parameter values if required.
		 	 * It will not be overwritten by future generation processes.
		 	 */
		
			//List<ParameterValue> theOutputs = outputs;
			//...
		
			/*
		 	 * End of user code
		 	 */
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // DelegationConnectors_P_PEnvironment
}
