using uml.classification;
using uml.commonstructure;

namespace uml.statemachines
{
    public class Transition : Namespace // PSSM-specific
    {
        public RedefinableElement redefinableElement = new();

        public Constraint? guard = null;
        public TransitionKind kind = TransitionKind.external;
        public Transition? redefinedTransition = null;
        public Vertex? source = null;
        public Vertex? target = null;
    } // Transition
}
