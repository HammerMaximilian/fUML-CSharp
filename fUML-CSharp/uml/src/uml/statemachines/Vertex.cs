using uml.classification;
using uml.commonstructure;

namespace uml.statemachines
{
    public abstract class Vertex : NamedElement // PSSM-specific
    {
        public RedefinableElement redefinableElement = new();

        public List<Transition> incoming = new();
        public List<Transition> outgoing = new();
    } // Vertex
}
