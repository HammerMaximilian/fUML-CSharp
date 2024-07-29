using fuml.semantics.commonbehavior;
using fuml.semantics.values;

namespace pssm.semantics.commonbehavior
{
    public class EventTriggeredExecution : Execution
    {
        // Original execution
        public Execution? wrappedExecution = null;

        // Event occurrence whose dispatching implied the
        // the execution of the behavior
        public EventOccurrence? triggeringEventOccurrence = null;

        public void Initialize()
        {
        }


        public override void Execute()
        {
        }

        public void Finalize_()
        {
        }


        protected override Value New_()
        {
            throw new NotImplementedException();
        }


        public override Value Copy()
        {
            throw new NotImplementedException();
        }
    } // EventTriggeredExecution
}
