/*
 * testDefaultValuesExecution.cs
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

namespace DefaultValue_Structures
{
	public class testDefaultValuesExecution : OpaqueBehaviorExecution
	{
		public testDefaultValuesExecution()
		{
			types.Add(DefaultValue_StructuresModel.Instance().DefaultValue_Structures_assert_A_testDefaultValues);
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
			List<Value> values = inputParameters.ElementAt(0).values;
	int index = 1;

	foreach(Value value in values)
	{
		Console.WriteLine("Asserting a.b[" + index + "].p == " + index);	
	
		// Test parameter p[i]
		int p =((IntegerValue)value).value;
		Debug.Println("[doBody] argument p[" + index + "] = " + p);

		Console.WriteLine("a.b[" + index + "].p == " + p);
		Console.Write("Default value correctly evaluated: ");

		if(p == index)
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

		index++;
	}
		}

		protected override Value New_()
		{
			return new testDefaultValuesExecution();
		}	

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // testDefaultValuesExecution
}
