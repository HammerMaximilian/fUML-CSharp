namespace uml.commonstructure
{
    public class Dependency : PackageableElement // PSCS-specific
    {
        public List<NamedElement> client = new();
        public List<NamedElement> supplier = new();

        public void AddClient(NamedElement client)
        {
            if (client is null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            this.client.Add(client);
            client.AddClientDependency(this);
        }

        public void AddSupplier(NamedElement supplier)
        {
            if (supplier is null)
            {
                throw new ArgumentNullException(nameof(supplier));
            }

            this.supplier.Add(supplier);
        }
    } // Dependency
}
