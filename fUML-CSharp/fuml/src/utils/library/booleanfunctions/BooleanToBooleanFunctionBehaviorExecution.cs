using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;

namespace fuml.library.booleanfunctions
{
    public class BooleanToBooleanFunctionBehaviorExecution : OpaqueBehaviorExecution
    {
        public BooleanToBooleanFunctionBehaviorExecution()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_ToBoolean);
        }

        public override void DoBody(List<ParameterValue> inputParameters, List<ParameterValue> outputParameters)
        {
            // Extract single String input argument
            StringValue sv1 = (StringValue)inputParameters.ElementAt(0).values.ElementAt(0);
            string s1 = sv1.value;
            Debug.Println("[doBody] argument = " + s1);

            // Calculate bool value from String.  Don't use Boolean.parseBoolean()
            // since it doesn't differentiate between invalid string and false.
            bool result;
            if (s1.ToLower().Equals("true"))
            {
                result = true;
            }
            else if (s1.ToLower().Equals("false"))
            {
                result = false;
            }
            else
            {
                Debug.Println("[doBody] Invalid input, cannot convert to bool: " + s1);
                // Invalid input, return empty list
                return;
            }

            // Store result in BooleanValue object
            BooleanValue resultObj = new()
            {
                value = result,
                type = locus?.factory?.GetBuiltInType("Boolean")
            };
            Debug.Println("[doBody] Boolean ToBoolean result = " + resultObj.value);

            // Add output to the outputParameters list
            outputParameters.ElementAt(0).values.Add(resultObj);
        }

        public override Value New_()
        {
            return new BooleanToBooleanFunctionBehaviorExecution();
        }
    } // BooleanToBooleanFunctionBehaviorExecution
}
