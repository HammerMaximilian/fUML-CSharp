namespace fuml.syntax.actions
{
    public class LinkEndDestructionData : LinkEndData
    {
        public bool isDestroyDuplicates = false;
        public InputPin? destroyAt = null;

        public void setIsDestroyDuplicates(bool isDestroyDuplicates)
        {
            this.isDestroyDuplicates = isDestroyDuplicates;
        } // setIsDestroyDuplicates

        public void setDestroyAt(InputPin destroyAt)
        {
            this.destroyAt = destroyAt ?? throw new ArgumentNullException(nameof(destroyAt));
        } // setDestroyAt
    } // LinkEndDestructionData
}
