namespace fuml.syntax.actions
{
    public class LinkEndCreationData : LinkEndData
    {
        public bool isReplaceAll = false;
        public InputPin? insertAt = null;

        public void SetIsReplaceAll(bool isReplaceAll)
        {
            this.isReplaceAll = isReplaceAll;
        } // setIsReplaceAll

        public void SetInsertAt(InputPin insertAt)
        {
            this.insertAt = insertAt ?? throw new ArgumentNullException(nameof(insertAt));
        } // setInsertAt
    } // LinkEndCreationData
}
