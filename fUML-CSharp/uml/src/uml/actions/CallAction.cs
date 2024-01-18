namespace uml.actions
{
    public abstract class CallAction : InvocationAction
    {
		public bool isSynchronous = true;
		public List<OutputPin> result = new();

		public void AddResult(OutputPin result)
		{
			AddOutput(result);
			this.result.Add(result);
		} // addResult
	} // CallAction
}
