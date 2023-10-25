namespace fuml.syntax.actions
{
    public class AcceptCallAction : AcceptEventAction
    {
		public OutputPin? returnInformation = null;

		public void setReturnInformation(OutputPin returnInformation)
		{
			addOutput(returnInformation);
			this.returnInformation = returnInformation;
		}
	} // AcceptCallAction
}
