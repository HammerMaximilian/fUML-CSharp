namespace uml.actions
{
    public class RemoveStructuralFeatureValueAction : WriteStructuralFeatureAction
    {
        public bool isRemoveDuplicates = false;
        public InputPin? removeAt = null;

        public void SetIsRemoveDuplicates(bool isRemoveDuplicates)
        {
            this.isRemoveDuplicates = isRemoveDuplicates;
        } // setIsRemoveDuplicates

        public void SetRemoveAt(InputPin removeAt)
        {
            if (removeAt is not null)
            {
                AddInput(removeAt);
            }

            this.removeAt = removeAt;
        } // setRemoveAt
    } // RemoveStructuralFeatureValueAction
}
