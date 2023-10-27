namespace fuml.syntax.actions
{
    public class AcceptCallAction : AcceptEventAction
    {
		public OutputPin? returnInformation = null;

		public void setReturnInformation(OutputPin returnInformation)
		{
			AddOutput(returnInformation);
			this.returnInformation = returnInformation;
		}
	} // AcceptCallAction
}
