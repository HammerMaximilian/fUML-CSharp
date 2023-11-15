using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;

namespace fuml.library.integerfunctions
{
    public class IntegerDivideFunctionBehaviorExecution : OpaqueBehaviorExecution
    {
        public IntegerDivideFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_IntegerFunctions_divide);
        }

        public override void DoBody(
		List<ParameterValue> inputParameters,
		List<ParameterValue> outputParameters)
		{
			// Extract integer arguments and perform an integer function on them.

			int arg1 = ((IntegerValue)inputParameters.ElementAt(0).values
					.ElementAt(0)).value;
			int arg2 = ((IntegerValue)inputParameters.ElementAt(1).values
					.ElementAt(0)).value;

			// Check for illegal divide by zero
			if (arg2 == 0)
			{
				Debug.Println("[doBody] Integer Divide, divide by zero not allowed");
			}

			// Perform Divide function
			float x = arg1 / ((float)arg2);
			Debug.Println("[doBody] Integer Divide result = " + x);

            RealValue result = new()
            {
                value = x,
                type = locus?.factory?.GetBuiltInType("Real")
            };
            outputParameters.ElementAt(0).values.Add(result);
		}

		protected override Value New_()
		{
			// Create a new instance of this kind of function behavior execution.

			return new IntegerDivideFunctionBehaviorExecution();
		}
	} // IntegerDivideFunctionBehaviorExecution
}
