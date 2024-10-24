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
        public List<Region> region = new();
        public List<Pseudostate> connectionPoint = new();
        public List<Trigger> deferrableTrigger = new();

        public bool IsComposite()
        {
            return region.Any();
        }

    } // State
}
