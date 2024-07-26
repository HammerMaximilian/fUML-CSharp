using uml.classification;
using uml.commonstructure;

namespace uml.statemachines
{
    public class Transition : Namespace // PSSM-specific
    {
        public RedefinableElement redefinableElement = new();

        public TransitionKind kind = TransitionKind.external;
    } // Transition
}
