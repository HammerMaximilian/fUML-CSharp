/*
 * assertExtentOfCExecution.cs
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
	public class assertExtentOfCExecution : OpaqueBehaviorExecution
	{
		public assertExtentOfCExecution()
		{
			types.Add(RecursiveDestructionModel.Instance().RecursiveDestruction_main_assertExtentOfC);
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
			Console.WriteLine("Asserting C.allInstances()->size() == 0");	

	int extentSize = inputParameters.ElementAt(0).values.Count;
	
	Console.WriteLine("C.allInstances()->size() == " + extentSize);
	Console.Write("All instances of C recursively destroyed: ");

	if(extentSize == 0)
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("Assertion successful.");
	}
	else
	{
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("Assertion failed!");
	}
	Console.ResetColor();
		}

		protected override Value New_()
		{
			return new assertExtentOfCExecution();
		}	

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // assertExtentOfCExecution
}
