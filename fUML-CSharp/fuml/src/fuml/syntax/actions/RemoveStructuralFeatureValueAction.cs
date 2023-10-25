namespace fuml.syntax.actions
{
    public class RemoveStructuralFeatureValueAction : WriteStructuralFeatureAction
    {
        public bool isRemoveDuplicates = false;
        public InputPin? removeAt = null;

        public void setIsRemoveDuplicates(bool isRemoveDuplicates)
        {
            this.isRemoveDuplicates = isRemoveDuplicates;
        } // setIsRemoveDuplicates

        public void setRemoveAt(InputPin removeAt)
        {
            if (removeAt != null)
            {
                addInput(removeAt);
            }

            this.removeAt = removeAt;
        } // setRemoveAt
    } // RemoveStructuralFeatureValueAction
}
