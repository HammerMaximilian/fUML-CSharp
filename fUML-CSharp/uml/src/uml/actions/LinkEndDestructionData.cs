namespace uml.actions
{
    public class LinkEndDestructionData : LinkEndData
    {
        public bool isDestroyDuplicates = false;
        public InputPin? destroyAt = null;

        public void SetIsDestroyDuplicates(bool isDestroyDuplicates)
        {
            this.isDestroyDuplicates = isDestroyDuplicates;
        } // setIsDestroyDuplicates

        public void SetDestroyAt(InputPin destroyAt)
        {
            this.destroyAt = destroyAt ?? throw new ArgumentNullException(nameof(destroyAt));
        } // setDestroyAt
    } // LinkEndDestructionData
}
