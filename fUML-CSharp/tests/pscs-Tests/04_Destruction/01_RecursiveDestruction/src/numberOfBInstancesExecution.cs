/*
 * numberOfBInstancesExecution.cs
 * 
 * Auto-generated file
 */

using fuml.semantics.commonbehavior;
using fuml;
using fuml.semantics.values;

/* Start of user code : User-defined includes and forward declarations
 * This section may be used for includes and forward declarations.
 * It will not be overwritten by future generation processes.
 */

/*
 * End of user code
 */

namespace RecursiveDestruction
{
	public class numberOfBInstancesExecution : OpaqueBehaviorExecution
	{
		public numberOfBInstancesExecution()
		{
			types.Add(RecursiveDestructionModel.Instance().RecursiveDestruction_main_numberOfBInstances);
			/* Start of user code : Additional opaque behavior execution initializations
		 	 * This section may be used to do any additional opaque behavior execution initialization,
			 * for example initializing user-defined members.
		 	 * It will not be overwritten by future generation processes.
		 	 */
		
			/*
		 	 * End of user code
		 	 */
		}

		public override void DoBody(List<ParameterValue> inputParameters, List<ParameterValue> outputParameters)
		{
			Console.WriteLine("# Instances of B: " + inputParameters.ElementAt(0).values.Count);
		}

		protected override Value New_()
		{
			return new numberOfBInstancesExecution();
		}	

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // numberOfBInstancesExecution
}
