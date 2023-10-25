using fuml.syntax.commonbehavior;

namespace fuml.syntax.actions
{
    public class ReduceAction : Action
    {
		public Behavior? reducer = null;
		public OutputPin? result = null;
		public InputPin? collection = null;
		public bool isOrdered = false;

		public void setIsOrdered(bool isOrdered)
		{
			this.isOrdered = isOrdered;
		} // setIsOrdered

		public void setReducer(
				Behavior reducer)
		{
			this.reducer = reducer ?? throw new ArgumentNullException(nameof(reducer));
		} // setReducer

		public void setCollection(
				InputPin collection)
		{
			addInput(collection);
			this.collection = collection;
		} // setCollection

		public void setResult(OutputPin result)
		{
			addOutput(result);
			this.result = result;
		} // setResult
	} // ReduceAction
}
