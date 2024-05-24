/*
 * testDefaultValuesExecution.cs
 * 
 * Auto-generated file
 */

using UMLPrimitiveTypes;
using fuml.semantics.commonbehavior;
using fuml;
using fuml.semantics.simpleclassifiers;
using uml.simpleclassifiers;
using fuml.semantics.values;
using uml.classification;

/* Start of user code : User-defined includes and forward declarations
 * This section may be used for includes and forward declarations.
 * It will not be overwritten by future generation processes.
 */

/*
 * End of user code
 */

namespace DefaultValue_BasicTypes
{
	public class testDefaultValuesExecution : OpaqueBehaviorExecution
	{
		public testDefaultValuesExecution()
		{
			types.Add(DefaultValue_BasicTypesModel.Instance().DefaultValue_BasicTypes_assert_A_testDefaultValues);
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
			Console.WriteLine("Asserting a.pInteger == 4");	
	// Test parameter pInteger
	int pInteger = ((IntegerValue)inputParameters.ElementAt(0).values.ElementAt(0)).value;
	Debug.Println("[doBody] argument pInteger = " + pInteger);
	Console.WriteLine("a.pInteger == " + pInteger);
	if(pInteger == 4)
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


	Console.WriteLine("Asserting a.pString == 'Hello'");
	// Test parameter pString
	string pString = ((StringValue)inputParameters.ElementAt(1).values.ElementAt(0)).value;
	Debug.Println("[doBody] argument " + inputParameters.ElementAt(1).parameter!.name +  " = " + pString);
	Console.WriteLine("a.pString == " + pString);
	if(pString == "Hello")
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

	Console.WriteLine("Asserting a.pBoolean == true");
	// Test parameter pBoolean
	bool pBoolean = ((BooleanValue)inputParameters.ElementAt(2).values.ElementAt(0)).value;
	Debug.Println("[doBody] argument " + inputParameters.ElementAt(2).parameter!.name +  " = " + pBoolean);
	Console.WriteLine("a.pBoolean == " + pBoolean);
	if(pBoolean)
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

	Console.WriteLine("Asserting a.pUnlimitedNatural == *");
	// Test parameter pUnlimitedNatural
	UnlimitedNatural pUnlimitedNatural = ((UnlimitedNaturalValue)inputParameters.ElementAt(3).values.ElementAt(0)).value;
	Debug.Println("[doBody] argument " + inputParameters.ElementAt(3).parameter!.name +  " = " + pUnlimitedNatural.ToString());
	Console.WriteLine("a.pUnlimitedNatural == " + pUnlimitedNatural.ToString());
	if(pUnlimitedNatural.naturalValue == -1)
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

	Console.WriteLine("Asserting a.pReal == 4.0");
	// Test parameter pReal
	float pReal = ((RealValue)inputParameters.ElementAt(4).values.ElementAt(0)).value;
	Debug.Println("[doBody] argument " + inputParameters.ElementAt(4).parameter!.name +  " = " + pReal);
	Console.WriteLine("a.pReal == " + pReal.ToString());
	if(pReal == 4.0)
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

	Console.WriteLine("Asserting a.pEnum == E::e2");
	// Test parameter pEnum
	EnumerationLiteral pEnum = ((EnumerationValue)inputParameters.ElementAt(5).values.ElementAt(0)).literal!;
	Debug.Println("[doBody] argument " + inputParameters.ElementAt(5).parameter!.name +  " = " + pEnum.qualifiedName);
	Console.WriteLine("a.pEnum == " + pEnum.qualifiedName);
	if(pEnum == DefaultValue_BasicTypesModel.Instance().DefaultValue_BasicTypes_E_e2)
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("Assertion successful.");
	}
	else
	{
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("Assertion failed!");
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
