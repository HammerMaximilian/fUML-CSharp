using uml.classification;
using uml.commonbehavior;
using uml.commonstructure;

namespace uml.statemachines
{
    public class Transition : Namespace // PSSM-specific
    {
        public RedefinableElement redefinableElement = new();

        public Behavior? effect = null;
        public Constraint? guard = null;
        public TransitionKind kind = TransitionKind.external;
        public Transition? redefinedTransition = null;
        public Vertex? source = null;
        public Vertex? target = null;
        public List<Trigger> trigger = new();
    } // Transition
}
