using uml.commonbehavior;

namespace uml.actions
{
    public class ReduceAction : Action
    {
		public Behavior? reducer = null;
		public OutputPin? result = null;
		public InputPin? collection = null;
		public bool isOrdered = false;

		public void SetIsOrdered(bool isOrdered)
		{
			this.isOrdered = isOrdered;
		} // setIsOrdered

		public void SetReducer(
				Behavior reducer)
		{
			this.reducer = reducer ?? throw new ArgumentNullException(nameof(reducer));
		} // setReducer

		public void SetCollection(
				InputPin collection)
		{
			AddInput(collection);
			this.collection = collection;
		} // setCollection

		public void SetResult(OutputPin result)
		{
			AddOutput(result);
			this.result = result;
		} // setResult
	} // ReduceAction
}
