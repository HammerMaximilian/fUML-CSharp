namespace fuml.syntax.actions
{
    public class DestroyLinkAction : WriteLinkAction
    {
        public new List<LinkEndDestructionData> endData = new();

        public override void AddEndData(
                LinkEndData endData)
        {
            base.AddEndData(endData);
            this.endData.Add((LinkEndDestructionData)endData);
        } // addEndData
    } // DestroyLinkAction
}
