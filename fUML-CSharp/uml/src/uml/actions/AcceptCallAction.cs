namespace uml.actions
{
    public class AcceptCallAction : AcceptEventAction
    {
		public OutputPin? returnInformation = null;

		public void SetReturnInformation(OutputPin returnInformation)
		{
			AddOutput(returnInformation);
			this.returnInformation = returnInformation;
		}
	} // AcceptCallAction
}
