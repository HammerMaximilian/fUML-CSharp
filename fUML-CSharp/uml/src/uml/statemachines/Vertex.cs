using uml.classification;
using uml.commonstructure;

namespace uml.statemachines
{
    public abstract class Vertex : NamedElement // PSSM-specific
    {
        public RedefinableElement redefinableElement = new();
    } // Vertex
}
