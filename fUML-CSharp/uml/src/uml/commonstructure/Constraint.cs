using uml.values;

namespace uml.commonstructure
{
    public class Constraint : PackageableElement // PSSM-specific
    {
        public Namespace? context = null;
        public List<Element> constrainedElement = new();
        public ValueSpecification? specification = null;
    } // Constraint
}
