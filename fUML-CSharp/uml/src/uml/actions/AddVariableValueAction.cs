namespace uml.actions
{
    public class AddVariableValueAction : WriteVariableAction
    {
        public bool isReplaceAll = false;
        public InputPin? insertAt = null;

        public void SetIsReplaceAll(bool isReplaceAll)
        {
            this.isReplaceAll = isReplaceAll;
        } // SetIsReplaceAll

        public void SetInsertAt(InputPin insertAt)
        {
            AddInput(insertAt);
            this.insertAt = insertAt;
        } // SetInsertAt
    } // AddVariableValueAction
}
