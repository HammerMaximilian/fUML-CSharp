using fuml.semantics.commonbehavior;
using System;

namespace pssm.semantics.statemachines
{
    public class StateMachineEventAccepter : EventAccepter
    {
        // The execution that actually made the event accepter registered
        // in the object activation. Note this is particularly useful to access the
        // the configured related to the state-machine that registered this event
        // accepter.
        public StateMachineExecution? registrationContext = null;

        public StateMachineEventAccepter(StateMachineExecution execution)
        {
            registrationContext = execution;
        }

        public override void Accept(EventOccurrence eventOccurrence)
        {
        }

        
        public override bool Match(EventOccurrence eventOccurrence)
        {
            throw new NotImplementedException();
        }

        public bool IsDeferred(EventOccurrence eventOccurrence)
        {
            throw new NotImplementedException();
        }

        protected bool _IsDeferred(EventOccurrence eventOccurrence, StateConfiguration stateConfiguration)
        {
            throw new NotImplementedException();
        }

        protected void Defer(EventOccurrence eventOccurrence)
        {
        }

        protected bool _Defer(EventOccurrence eventOccurrence, StateConfiguration stateConfiguration)
        {
            throw new NotImplementedException();
        }

        public bool IsTriggering(EventOccurrence eventOccurrence)
        {
            throw new NotImplementedException();
        }

        protected List<TransitionActivation> Select(EventOccurrence eventOccurrence)
        {
            // Find for the given configuration the set of transition that can fire.
            return _Select(eventOccurrence, registrationContext?.configuration?.rootConfiguration!);
        }

        protected List<TransitionActivation> _Select(EventOccurrence eventOccurrence, StateConfiguration stateConfiguration)
        {
            throw new NotImplementedException();
        }
    } // StateMachineEventAccepter
}
