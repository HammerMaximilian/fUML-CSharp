using fuml.syntax.commonstructure;

namespace fuml.syntax.packages
{
    public class Package : Namespace
    {
        public List<PackageableElement> packagedElement = new();
        public List<commonstructure.Type> ownedType = new();
        public List<Package> nestedPackage = new();
        public Package? nestingPackage = null;
        public string URI = "";

        public void addPackagedElement(
                PackageableElement packagedElement)
        {
            if (packagedElement is null)
            {
                throw new ArgumentNullException(nameof(packagedElement));
            }

            addOwnedMember(packagedElement);
            this.packagedElement.Add(packagedElement);

            if (packagedElement is commonstructure.Type) 
            {
                this.ownedType.Add((commonstructure.Type)packagedElement);
                ((commonstructure.Type)packagedElement)._setPackage(this);
            }

            if (packagedElement is Package) 
            {
                this.nestedPackage.Add((Package)packagedElement);
                ((Package)packagedElement).nestingPackage = this;
            }

        } // addPackagedElement

        public List<PackageableElement> visibleMembers()
        {
            List<PackageableElement> visibleMembers = new();

            foreach(PackageableElement member in packagedElement)
            {
                if (makesVisible(member))
                {
                    visibleMembers.Add(member);
                }
            }

            return visibleMembers;
        } // visibleMembers

        public bool makesVisible(NamedElement el)
        {
            foreach(NamedElement member in ownedMember)
            {
                if (member == el)
                {
                    return member.visibility == null
                            || member.visibility == VisibilityKind.public_;
                }
            }

            foreach(ElementImport elementImport in elementImport)
            {
                if (elementImport.importedElement == el)
                {
                    return true;
                }
            }

            foreach(PackageImport packageImport in packageImport)
            {
                if (packageImport.visibility == VisibilityKind.public_)
                {
                    // NOTE: This won't work unless the imported package members
                    // have already been loaded
                    List<NamedElement> packageMembers = packageImport.importedPackage!.member;
                    foreach(NamedElement member in packageMembers)
                    {
                        if (member == el)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        } // makesVisible

        public void setURI(string URI)
        {
            this.URI = URI;
        } // setURI
    }
} // Package
