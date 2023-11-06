namespace fuml.syntax.actions
{
    public class DestroyObjectAction : Action
    {
		public bool isDestroyLinks = false;
		public bool isDestroyOwnedObjects = false;
		public InputPin? target = null;

		public void SetIsDestroyLinks(bool isDestroyLinks)
		{
			this.isDestroyLinks = isDestroyLinks;
		} // setIsDestroyLinks

		public void SetIsDestroyOwnedObjects(bool isDestroyOwnedObjects)
		{
			this.isDestroyOwnedObjects = isDestroyOwnedObjects;
		} // setIsDestroyOwnedObjects

		public void SetTarget(InputPin target)
		{
			AddInput(target);
			this.target = target;
		} // setTarget
	} // DestroyObjectAction
}
