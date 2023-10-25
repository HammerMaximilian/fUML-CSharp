namespace fuml.syntax.actions
{
    public abstract class CallAction : InvocationAction
    {
		public bool isSynchronous = true;
		public List<OutputPin> result = new();

		public void addResult(OutputPin result)
		{
			addOutput(result);
			this.result.Add(result);
		} // addResult
	} // CallAction
}
