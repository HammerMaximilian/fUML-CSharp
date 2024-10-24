using uml.classification;
using uml.commonstructure;

namespace uml.statemachines
{
    public class Region : Namespace // PSSM-specific
    {
        public RedefinableElement redefinableElement = new();

        public Region? extendedRegion = null;
        public List<Transition> transition = new();
        public List<Vertex> subvertices = new();

    } // Region
}
