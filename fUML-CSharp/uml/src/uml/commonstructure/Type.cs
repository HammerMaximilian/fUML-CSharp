using uml.packages;

namespace uml.commonstructure
{
    public abstract class Type : Namespace
    {
        public Package? package;

        public void _setPackage(Package package)
        {
            this.package = package ?? throw new ArgumentNullException(nameof(package));
        }
    } // Type
}
