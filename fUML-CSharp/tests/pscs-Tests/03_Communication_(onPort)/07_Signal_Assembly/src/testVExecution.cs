/*
 * testVExecution.cs
 * 
 * Auto-generated file
 */

using fuml.semantics.commonbehavior;
using fuml;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;

/* Start of user code : User-defined includes and forward declarations
 * This section may be used for includes and forward declarations.
 * It will not be overwritten by future generation processes.
 */

/*
 * End of user code
 */

namespace Signal_Assembly
{
	public class testVExecution : OpaqueBehaviorExecution
	{
		public testVExecution()
		{
			types.Add(Signal_AssemblyModel.Instance().Signal_Assembly_TestCaseAssembly_testActivity_testV);
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
			Console.WriteLine("Asserting a.v == 4");

	// Test parameter v
	int v = ((IntegerValue)inputParameters.ElementAt(0).values.ElementAt(0)).value;
	Debug.Println("[doBody] argument v = " + v);
	
	Console.WriteLine("a.v == " + v);
	Console.Write("Signal correctly sent and received: ");

	if(v == 4)
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
			return new testVExecution();
		}	

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // testVExecution
}
