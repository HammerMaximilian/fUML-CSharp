namespace uml.actions
{
    public class RemoveVariableValueAction : WriteVariableAction
    {
        public bool isRemoveDuplicates = false;
        public InputPin? removeAt = null;

        public void SetIsRemoveDuplicates(bool isRemoveDuplicates)
        {
            this.isRemoveDuplicates = isRemoveDuplicates;
        } // SetIsRemoveDuplicates

        public void SetRemoveAt(InputPin removeAt)
        {
            AddInput(removeAt);
            this.removeAt = removeAt;
        } // SetInsertAt
    } // RemoveVariableValueAction
}
