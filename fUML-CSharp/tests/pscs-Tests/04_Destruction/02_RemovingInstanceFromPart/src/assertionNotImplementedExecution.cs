/*
 * assertionNotImplementedExecution.cs
 * 
 * Auto-generated file
 */

using fuml.semantics.commonbehavior;
using fuml;
using fuml.semantics.values;

/* Start of user code : User-defined includes and forward declarations
 * This section may be used for includes and forward declarations.
 * It will not be overwritten by future generation processes.
 */

/*
 * End of user code
 */

namespace RemovingInstanceFromPart
{
	public class assertionNotImplementedExecution : OpaqueBehaviorExecution
	{
		public assertionNotImplementedExecution()
		{
			types.Add(RemovingInstanceFromPartModel.Instance().RemovingInstanceFromPart_assertA_assertionNotImplemented);
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
			Console.WriteLine("Assertion currenlty not implemented! Model was validated by manual debugging.");
		}

		protected override Value New_()
		{
			return new assertionNotImplementedExecution();
		}	

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // assertionNotImplementedExecution
}
