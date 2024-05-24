/*
 * testNonEmptyListExecution.cs
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

namespace Hierarchy
{
	public class testNonEmptyListExecution : OpaqueBehaviorExecution
	{
		public testNonEmptyListExecution()
		{
			types.Add(HierarchyModel.Instance().Hierarchy_assert_A_testNonEmptyList);
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
			string parameterName = inputParameters.ElementAt(0).parameter!.name;

	// Test parameter listSize
	int listSize = ((IntegerValue)inputParameters.ElementAt(0).values.ElementAt(0)).value;
	Debug.Println("[doBody] argument " + parameterName +  " = " + listSize);

	Console.Write("Part is not empty: ");

	if(listSize > 0)
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
			return new testNonEmptyListExecution();
		}	

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // testNonEmptyListExecution
}
