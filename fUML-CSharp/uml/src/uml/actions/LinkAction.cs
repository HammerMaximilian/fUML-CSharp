namespace uml.actions
{
    public class LinkAction : Action
    {
		public List<LinkEndData> endData = new();
		public List<InputPin> inputValue = new();

		public virtual void AddEndData(
				LinkEndData endData)
		{
            if (endData is null)
            {
                throw new ArgumentNullException(nameof(endData));
            }

            this.endData.Add(endData);
		} // addEndData

		public void AddInputValue(
				InputPin inputValue)
		{
			AddInput(inputValue);
			this.inputValue.Add(inputValue);
		} // addInputValue
	} // LinkAction
}
