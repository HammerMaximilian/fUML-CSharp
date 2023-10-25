namespace fuml.syntax.actions
{
    public class CreateLinkAction : WriteLinkAction
    {
        public new List<LinkEndCreationData> endData = new();

        public void addEndData(
                LinkEndCreationData endData)
        {
            base.addEndData(endData);
            this.endData.Add(endData);
        } // addEndData
    } // CreateLinkAction
}
