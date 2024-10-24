using uml.commonbehavior;
using uml.commonstructure;

namespace uml.statemachines
{
    public class State : Vertex // PSSM-specific
    {
        public Namespace namespaceGeneral = new();

        public Behavior? entry = null;
        public Behavior? doActivity = null;
        public Behavior? exit = null;
        public State? redefinedState = null;

    } // State
}
