namespace fuml.syntax.commonstructure
{
    public abstract class PackageableElement : NamedElement
    {
        public PackageableElement()
        {
            setVisibility(VisibilityKind.public_);
        }
    } // PackageableElement
}
