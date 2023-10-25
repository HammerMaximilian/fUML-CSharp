namespace fuml.syntax.actions
{
    public class LinkEndCreationData : LinkEndData
    {
        public bool isReplaceAll = false;
        public InputPin? insertAt = null;

        public void setIsReplaceAll(bool isReplaceAll)
        {
            this.isReplaceAll = isReplaceAll;
        } // setIsReplaceAll

        public void setInsertAt(InputPin insertAt)
        {
            this.insertAt = insertAt ?? throw new ArgumentNullException(nameof(insertAt));
        } // setInsertAt
    } // LinkEndCreationData
}
