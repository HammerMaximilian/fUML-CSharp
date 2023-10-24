namespace fuml.syntax.commonstructure
{
    public class PackageImport : Element
    {
        public VisibilityKind? visibility = null;
        public Namespace? importingNamespace = null;
        public packages.Package? importedPackage = null;

        public void setVisibility(
                VisibilityKind visibility)
        {
            this.visibility = visibility;
        } // setVisibility

        public void setImportedPackage(
                packages.Package importedPackage)
        {
            this.importedPackage = importedPackage ?? throw new ArgumentNullException(nameof(importedPackage));
        } // setImportedPackage

        public void _setImportingNamespace(
                Namespace importingNamespace)
        {
            this.importingNamespace = importingNamespace ?? throw new ArgumentNullException(nameof(importingNamespace));
        } // _setImportingNamespace
    } // PackageImport
}
