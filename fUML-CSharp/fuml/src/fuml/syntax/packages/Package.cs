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

        public void AddPackagedElement(
                PackageableElement packagedElement)
        {
            if (packagedElement is null)
            {
                throw new ArgumentNullException(nameof(packagedElement));
            }

            AddOwnedMember(packagedElement);
            this.packagedElement.Add(packagedElement);

            if (packagedElement is commonstructure.Type type) 
            {
                ownedType.Add(type);
                type._setPackage(this);
            }

            if (packagedElement is Package package) 
            {
                nestedPackage.Add(package);
                package.nestingPackage = this;
            }

        } // addPackagedElement

        public List<PackageableElement> VisibleMembers()
        {
            List<PackageableElement> visibleMembers = new();

            foreach(PackageableElement member in packagedElement)
            {
                if (MakesVisible(member))
                {
                    visibleMembers.Add(member);
                }
            }

            return visibleMembers;
        } // visibleMembers

        public bool MakesVisible(NamedElement el)
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

        public void SetURI(string URI)
        {
            this.URI = URI;
        } // setURI
    }
} // Package
