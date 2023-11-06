namespace fuml.syntax.commonstructure
{
    public class ElementImport : Element
    {
        public VisibilityKind? visibility = null;
        public string alias = "";
        public PackageableElement? importedElement = null;
        public Namespace? importingNamespace = null;

        public void SetAlias(string alias)
        {
            this.alias = alias;
        } // setAlias

        public void SetVisibility(
                VisibilityKind visibility)
        {
            this.visibility = visibility;
        } // setVisibility

        public void SetImportedElement(
                PackageableElement importedElement)
        {
            this.importedElement = importedElement ?? throw new ArgumentNullException(nameof(importedElement));
        } // setImportedElement

        public void _setImportingNamespace(
                Namespace importingNamespace)
        {
            this.importingNamespace = importingNamespace ?? throw new ArgumentNullException(nameof(importingNamespace));
        } // _setImportingNamespace

    } // ElementImport
}
