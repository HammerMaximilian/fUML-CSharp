namespace fuml.syntax.actions
{
    public class AddStructuralFeatureValueAction : WriteStructuralFeatureAction
    {
		public bool isReplaceAll = false;
		public InputPin? insertAt = null;

		public void SetIsReplaceAll(bool isReplaceAll)
		{
			this.isReplaceAll = isReplaceAll;
		} // setIsReplaceAll

		public void SetInsertAt(InputPin insertAt)
		{
			if (insertAt is not null)
			{
				AddInput(insertAt);
			}

			this.insertAt = insertAt;
		} // setInsertAt
	} // AddStructuralFeatureValueAction
}
