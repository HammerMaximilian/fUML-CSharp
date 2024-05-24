/*
 * testFalseExecution.cs
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

namespace BehaviorPort_Operation
{
	public class testFalseExecution : OpaqueBehaviorExecution
	{
		public testFalseExecution()
		{
			types.Add(BehaviorPort_OperationModel.Instance().BehaviorPort_Operation_assertP_testFalse);
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
			// Test parameter input
	bool input = ((BooleanValue)inputParameters.ElementAt(0).values.ElementAt(0)).value;
	Debug.Println("[doBody] argument input = " + input);

	if(input == false)
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
			return new testFalseExecution();
		}	

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // testFalseExecution
}
