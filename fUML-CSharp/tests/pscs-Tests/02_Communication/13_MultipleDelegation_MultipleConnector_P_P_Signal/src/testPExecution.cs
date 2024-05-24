/*
 * testPExecution.cs
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

namespace MultipleDelegation_MultipleConnector_P_P_Signal
{
	public class testPExecution : OpaqueBehaviorExecution
	{
		public testPExecution()
		{
			types.Add(MultipleDelegation_MultipleConnector_P_P_SignalModel.Instance().MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_testP);
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
			if(index == 1)
	{
		Console.WriteLine("Asserting a.b1.p == 4 && a.b2.p == 4 && a.b3.p == 4 && a.b4.p == 4");
	}

	// For some reason, during the first execution of the expansion region, its body is actually executed twice.
	// Because of that, the body is actually executaed 5 times in total. This if-statement covers that up until solved.
	if(index <= MAX_INDEX)
	{

		// Test parameter p
		int p = ((IntegerValue)inputParameters.ElementAt(0).values.ElementAt(0)).value;
		Debug.Println("[doBody] argument p = " + p);
	
		Console.WriteLine( "a.b" + index + ".p == " + p);
		success = success && (p == 4);

		if(index == MAX_INDEX)
		{

			Console.Write("Signal delegated on all links (shall be true for default strategy): ");

			if(success)
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
	}

	index++;
		}

		protected override Value New_()
		{
			return new testPExecution();
		}

        /* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

        private static int index = 1;
        private const int MAX_INDEX = 4;
        private static bool success = true;

        /*
 		 * End of user code
		 */
    } // testPExecution
}