/*
 * testPExecution.cs
 * 
 * Auto-generated file
 */

using fuml;
using fuml.semantics.commonbehavior;
using fuml.semantics.values;
using fuml.semantics.simpleclassifiers;

/* Start of user code : User-defined includes and forward declarations
 * This section may be used for includes and forward declarations.
 * It will not be overwritten by future generation processes.
 */

/*
 * End of user code
 */

namespace SingleDelegation_P_P_Operation
{
	public class testPExecution : OpaqueBehaviorExecution
	{
		public testPExecution()
		{
			types.Add(SingleDelegation_P_P_OperationModel.Instance().SingleDelegation_P_P_Operation_main_testP);
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
			Console.WriteLine("Asserting a.b.p == 4");

	// Test parameter p
	int p = ((IntegerValue)inputParameters.ElementAt(0).values.ElementAt(0)).value;
	Debug.Println("[doBody] argument p = " + p);
	
	Console.WriteLine("a.b.p == " + p);
	Console.Write("Operation call delegated: ");

	if(p == 4)
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
			return new testPExecution();
		}	

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // testPExecution
}
