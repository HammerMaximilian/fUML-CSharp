namespace uml.actions
{
    public class CreateLinkAction : WriteLinkAction
    {
        public new List<LinkEndCreationData> endData = new();

        public void AddEndData(
                LinkEndCreationData endData)
        {
            base.AddEndData(endData);
            this.endData.Add(endData);
        } // addEndData
    } // CreateLinkAction
}
