namespace fuml.syntax.commonstructure
{
    public class Namespace : PackageableElement
    {
        public List<NamedElement> member = new();
        public List<NamedElement> ownedMember = new();
        public List<ElementImport> elementImport = new();
        public List<PackageImport> packageImport = new();
        public List<PackageableElement> importedMember = new();

        protected void AddOwnedMember(
                NamedElement ownedMember)
        {
            if (ownedMember is null)
            {
                throw new ArgumentNullException(nameof(ownedMember));
            }

            AddOwnedElement(ownedMember);

            this.ownedMember.Add(ownedMember);
            ownedMember.namespace_ = this;

            AddMember(ownedMember);
        } // addOwnedMember

        protected void AddMember(NamedElement member)
        {
            if (member is null)
            {
                throw new ArgumentNullException(nameof(member));
            }
            // Note: This operation should not be used for owned members. The
            // operation addOwnedMember should be used instead.

            this.member.Add(member);

        } // addMember

        public void AddElementImport(
                ElementImport elementImport)
        {
            if (elementImport is null)
            {
                throw new ArgumentNullException(nameof(elementImport));
            }

            AddOwnedElement(elementImport);

            this.elementImport.Add(elementImport);
            elementImport.importingNamespace = this;

            AddImportedMember(elementImport.importedElement!);
        } // addElementImport

        public void AddPackageImport(
                PackageImport packageImport)
        {
            if (packageImport is null)
            {
                throw new ArgumentNullException(nameof(packageImport));
            }

            AddOwnedElement(packageImport);

            this.packageImport.Add(packageImport);
            packageImport.importingNamespace = this;

            List<PackageableElement> importedElements = packageImport.importedPackage!.VisibleMembers();
            foreach(PackageableElement importedElement in importedElements)
            {
                AddImportedMember(importedElement);
            }
        } // addPackageImport

        private void AddImportedMember(
                PackageableElement importedMember)
        {
            if (importedMember is null)
            {
                throw new ArgumentNullException(nameof(importedMember));
            }

            AddMember(importedMember);
            this.importedMember.Add(importedMember);
        } // addImportedMember
    }
} // Namespace
