namespace uml.commonstructure
{
    public abstract class PackageableElement : NamedElement
    {
        public PackageableElement()
        {
            SetVisibility(VisibilityKind.public_);
        }
    } // PackageableElement
}
