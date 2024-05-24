/*
 * Operation_RequiredInterface_DelegationChainEnvironment.cs
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

namespace Operation_RequiredInterface_DelegationChain
{
	public class Operation_RequiredInterface_DelegationChainEnvironment : pscs.environment.Environment
	{
		private static Operation_RequiredInterface_DelegationChainEnvironment? instance;

		public static Operation_RequiredInterface_DelegationChainEnvironment Instance()
		{
			if(instance is null)
			{
				instance = new();
				instance.inMemoryModel = Operation_RequiredInterface_DelegationChainModel.Instance();
			}

			return instance;
		}

		public Operation_RequiredInterface_DelegationChainEnvironment()
		{
			/*
			 * Create custom opaque behavior execution instances and add them to the execution environment.
			 */
			AddPrimitiveBehaviorPrototype(new testPExecution());
		
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
	} // Operation_RequiredInterface_DelegationChainEnvironment
}
