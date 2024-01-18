using fuml.semantics.commonbehavior;
using fuml.semantics.values;
using uml.classification;
using uml.values;

namespace fuml.semantics.actions
{
    public class ReturnInformation : Value
    {
		public CallEventOccurrence? callEventOccurrence = null;

		public Operation GetOperation()
		{
			// Return the operation associated with the call event occurrence of this
			// return information.

			return callEventOccurrence?.GetOperation()!;
		}

		public void Reply(List<ParameterValue> outputParameterValues)
		{
			// Reply to the call by setting the output parameters and
			// releasing the caller.

			callEventOccurrence?.SetOutputParameterValues(outputParameterValues);
			callEventOccurrence?.ReturnFromCall();
		}

		public override ValueSpecification Specify()
		{
			// Return information cannot be specified using a value specification.

			return null!;
		}


		public override List<Classifier> GetTypes()
		{
			// Return information is untyped.

			return new List<Classifier>();
		}

		public override bool Equals(Value otherValue)
		{
			// One return information value equals another if they are for the
			// same call event occurrence.

			bool isEqual = false;

			if (otherValue is ReturnInformation returnInformation) {
				isEqual = returnInformation.callEventOccurrence ==
						callEventOccurrence;
			}

			return isEqual;
		}

		protected override Value New_()
		{
			// Create a new return information value, with an empty call event occurrence.

			return new ReturnInformation();
		}

		public override Value Copy()
		{
			// Create a new return information value that is a copy of this value, with
			// the same call event occurrence.

			ReturnInformation copy = (ReturnInformation)base.Copy();
			copy.callEventOccurrence = callEventOccurrence;
			return copy;
		}

		public override string ToString()
		{
            // Return a string representation of the return information.

            string s = "ReturnInformation";
            string name = callEventOccurrence?.GetOperation()?.name!;
			if (name is not null)
			{
				s = s + "(" + name + ")";
			}
			return s;
		}
	} // ReturnInformation
}
