namespace fuml.syntax.commonstructure
{
    public class Namespace : PackageableElement
    {
        public List<NamedElement> member = new();
        public List<NamedElement> ownedMember = new();
        public List<ElementImport> elementImport = new();
        public List<PackageImport> packageImport = new();
        public List<PackageableElement> importedMember = new();

        protected void addOwnedMember(
                NamedElement ownedMember)
        {
            if (ownedMember is null)
            {
                throw new ArgumentNullException(nameof(ownedMember));
            }

            addOwnedElement(ownedMember);

            this.ownedMember.Add(ownedMember);
            ownedMember.namespace_ = this;

            addMember(ownedMember);
        } // addOwnedMember

        protected void addMember(NamedElement member)
        {
            if (member is null)
            {
                throw new ArgumentNullException(nameof(member));
            }
            // Note: This operation should not be used for owned members. The
            // operation addOwnedMember should be used instead.

            this.member.Add(member);

        } // addMember

        public void addElementImport(
                ElementImport elementImport)
        {
            if (elementImport is null)
            {
                throw new ArgumentNullException(nameof(elementImport));
            }

            addOwnedElement(elementImport);

            this.elementImport.Add(elementImport);
            elementImport.importingNamespace = this;

            addImportedMember(elementImport.importedElement!);
        } // addElementImport

        public void addPackageImport(
                PackageImport packageImport)
        {
            if (packageImport is null)
            {
                throw new ArgumentNullException(nameof(packageImport));
            }

            addOwnedElement(packageImport);

            this.packageImport.Add(packageImport);
            packageImport.importingNamespace = this;

            List<PackageableElement> importedElements = packageImport.importedPackage!.VisibleMembers();
            foreach(PackageableElement importedElement in importedElements)
            {
                addImportedMember(importedElement);
            }
        } // addPackageImport

        private void addImportedMember(
                PackageableElement importedMember)
        {
            if (importedMember is null)
            {
                throw new ArgumentNullException(nameof(importedMember));
            }

            addMember(importedMember);
            this.importedMember.Add(importedMember);
        } // addImportedMember
    }
} // Namespace
