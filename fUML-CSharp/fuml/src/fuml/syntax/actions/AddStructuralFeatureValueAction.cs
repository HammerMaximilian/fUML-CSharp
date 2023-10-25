namespace fuml.syntax.actions
{
    public class AddStructuralFeatureValueAction : WriteStructuralFeatureAction
    {
		public bool isReplaceAll = false;
		public InputPin? insertAt = null;

		public void setIsReplaceAll(bool isReplaceAll)
		{
			this.isReplaceAll = isReplaceAll;
		} // setIsReplaceAll

		public void setInsertAt(InputPin insertAt)
		{
			if (insertAt != null)
			{
				addInput(insertAt);
			}

			this.insertAt = insertAt;
		} // setInsertAt
	} // AddStructuralFeatureValueAction
}
