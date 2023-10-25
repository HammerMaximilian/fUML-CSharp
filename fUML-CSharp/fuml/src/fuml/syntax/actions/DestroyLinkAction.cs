namespace fuml.syntax.actions
{
    public class DestroyLinkAction : WriteLinkAction
    {
        public new List<LinkEndDestructionData> endData = new();

        public override void addEndData(
                LinkEndData endData)
        {
            base.addEndData(endData);
            this.endData.Add((LinkEndDestructionData)endData);
        } // addEndData
    } // DestroyLinkAction
}
