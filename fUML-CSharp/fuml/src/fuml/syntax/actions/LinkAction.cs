﻿namespace fuml.syntax.actions
{
    public class LinkAction : Action
    {
		public List<LinkEndData> endData = new();
		public List<InputPin> inputValue = new();

		public virtual void addEndData(
				LinkEndData endData)
		{
            if (endData is null)
            {
                throw new ArgumentNullException(nameof(endData));
            }

            this.endData.Add(endData);
		} // addEndData

		public void addInputValue(
				InputPin inputValue)
		{
			addInput(inputValue);
			this.inputValue.Add(inputValue);
		} // addInputValue
	} // LinkAction
}
