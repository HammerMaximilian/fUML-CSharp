using fuml.semantics.commonbehavior;
using pssm.semantics.statemachines;

namespace pssm.semantics.commonbehavior
{
    public class SM_ObjectActivation : ObjectActivation
    {
        // Events that have been dispatched but that are actually deferred are placed
        // in this particular event pool. When the state that constrained them to be
        // placed in this pool leaves the state-machine configuration then the deferred
        // events leave this pool and are placed in the regular event pool (to be
        // dispatched
        // again) that is handled by the object activation.
        public List<DeferredEventOccurrence> deferredEventPool = new();

        public CompletionEventOccurrence GetNextCompletionEvent()
        {
            throw new NotImplementedException();
        }

        public int getDeferredEventInsertionIndex()
        {
            throw new NotImplementedException();
        }

        public override EventOccurrence GetNextEvent()
        {
            throw new NotImplementedException();
        }

        public void Register(CompletionEventOccurrence completionEventOccurrence)
        {

        }

        public void Register(DeferredEventOccurrence deferredEventOccurrence)
        {
        }

        public void ReleaseDeferredEvents(StateActivation deferringState)
        {
        }

    } // SM_ObjectActivation
}
