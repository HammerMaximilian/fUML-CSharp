namespace uml.structuredclassifiers
{
    public class EncapsulatedClassifier : StructuredClassifier
    {
        public List<Port> ownedPort = new();

        public void AddOnwedPort(Port ownedPort)
        {
            if (ownedPort is null)
            {
                throw new ArgumentNullException(nameof(ownedPort));
            }

            AddOwnedAttribute(ownedPort);
            this.ownedPort.Add(ownedPort);
        }
    } // EncapsulatedClassifier
}
