namespace fuml.syntax.actions
{
    public class DestroyObjectAction : Action
    {
		public bool isDestroyLinks = false;
		public bool isDestroyOwnedObjects = false;
		public InputPin? target = null;

		public void setIsDestroyLinks(bool isDestroyLinks)
		{
			this.isDestroyLinks = isDestroyLinks;
		} // setIsDestroyLinks

		public void setIsDestroyOwnedObjects(bool isDestroyOwnedObjects)
		{
			this.isDestroyOwnedObjects = isDestroyOwnedObjects;
		} // setIsDestroyOwnedObjects

		public void setTarget(InputPin target)
		{
			AddInput(target);
			this.target = target;
		} // setTarget
	} // DestroyObjectAction
}
