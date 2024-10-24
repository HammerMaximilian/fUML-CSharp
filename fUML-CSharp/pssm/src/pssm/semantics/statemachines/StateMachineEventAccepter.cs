using fuml.semantics.commonbehavior;
using fuml.semantics.loci;
using fuml.semantics.structuredclassifiers;
using pscs.semantics.commonbehavior;

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
            // When an event occurrence is accepted this marks the beginning of a new RTC
            // step for
            // the executed state-machine. The following set of actions takes place:
            // 1 - The event can be deferred if required
            // 2 - The event can trigger on to many transitions if it is not deferred
            //	2.1 - The list of transitions that can be fired using the given event
            //        occurrence is computed.
            //  2.2 - Transitions in the set of fireable transitions are fired **concurrently**
            //  2.3 - If the accepted event occurrence is a call event occurrence then there is a explicit
            //	      "return from call" which enables the caller to continue its execution. 
            // 3 - When the RTC step is about to complete a new event accepter for the state-machine
            //	   is registered at the waiting event accepter list handled by the object activation
            // Note that there always is a single event accepter for a state-machine. This differs from
            // fUML. Indeed, in the state machine context, the overall state machine configuration gets
            // analyzed.
            if (IsDeferred(eventOccurrence))
            {
                Defer(eventOccurrence);
            }
            else
            {
                List<TransitionActivation> fireableTransitionActivations = Select(eventOccurrence);
                if (fireableTransitionActivations.Any())
                {
                    foreach (TransitionActivation fireableTransition in fireableTransitionActivations)
                    {
                        fireableTransition.Fire(eventOccurrence);
                    }
                    CallEventOccurrence? callEventOccurrence = null;
                    if (eventOccurrence is CS_EventOccurrence cS_EventOccurrence)
                    {
                        EventOccurrence wrappedEventOccurrence = cS_EventOccurrence.wrappedEventOccurrence!;
                        if (wrappedEventOccurrence is CallEventOccurrence _callEventOccurrence)
                        {
                            callEventOccurrence = _callEventOccurrence;
                        }
                    }
                    else if (eventOccurrence is CallEventOccurrence _callEventOccurrence)
                    {
                        callEventOccurrence = _callEventOccurrence;
                    }
                    callEventOccurrence?.ReturnFromCall();
                }
            }
            Object_ context = registrationContext!.context!;
            if (context != null && context.objectActivation != null)
            {
                context.Register(new StateMachineEventAccepter(registrationContext));
            }
        }


        public override bool Match(EventOccurrence eventOccurrence)
        {
            // There are two cases in which the state machine event accepter can match
            // 1 - In the current state machine configuration the event can be deferred
            // 2 - In the current state machine configuration the current event can trigger
            // one or more transitions
            return IsDeferred(eventOccurrence) | IsTriggering(eventOccurrence);
        }

        public bool IsDeferred(EventOccurrence eventOccurrence)
        {
            // Determine if the dispatched event occurrence is deferred in the
            // current state machine configuration. An event occurrence can only be deferred
            // if the following conditions are fulfilled:
            // 1 - One active state in the hierarchy declares the event types as being
            // deferred.
            // 2 - No transitions (ready to fire) with a higher priority than the deferring
            // state
            // could be found.
            // 3 - It does not exist any running doActivity having already registered an
            // accepter
            // for the given event occurrence
            // Note: a completion event cannot be deferred.
            bool deferred = false;
            if (eventOccurrence is not CompletionEventOccurrence)
            {
                deferred = _IsDeferred(eventOccurrence, registrationContext!.configuration!.rootConfiguration!);
            }
            if (deferred)
            {
                Object_ context = registrationContext!.context!;
                if (context != null && context.objectActivation != null)
                {
                    int i = 1;
                    while (deferred && i <= context.objectActivation.waitingEventAccepters.Count)
                    {
                        EventAccepter currentEventAccepter = context.objectActivation.waitingEventAccepters
                                .ElementAt(i - 1);
                        if (currentEventAccepter != this && currentEventAccepter is DoActivityExecutionEventAccepter
                            && currentEventAccepter.Match(eventOccurrence))
                        {
                            deferred = false;
                        }
                        i++;
                    }
                }
            }
            return deferred;
        }

        protected bool _IsDeferred(EventOccurrence eventOccurrence, StateConfiguration stateConfiguration)
        {
            // Determine if the given state configuration is capable of deferring the given
            // event occurrence.
            int i = 0;
            bool deferred = false;
            while (!deferred && i < stateConfiguration.children.Count)
            {
                deferred = _IsDeferred(eventOccurrence, stateConfiguration.children.ElementAt(i));
                i++;
            }
            if (!deferred && stateConfiguration.vertexActivation != null
                    && ((StateActivation)stateConfiguration.vertexActivation).CanDefer(eventOccurrence))
            {
                if (!_Select(eventOccurrence, stateConfiguration).Any())
                {
                    deferred = true;
                }
            }
            return deferred;
        }

        protected void Defer(EventOccurrence eventOccurrence)
        {
            // Defers the given event occurrence. A deferred event occurrence is registered
            // in
            // the deferred event pool. This latter refers to the deferred event as well as
            // to the
            // the deferring state.
            _Defer(eventOccurrence, registrationContext!.configuration!.rootConfiguration!);
        }

        protected bool _Defer(EventOccurrence eventOccurrence, StateConfiguration stateConfiguration)
        {
            // Defers the given event occurrence in the context of the given state
            // configuration.
            int i = 0;
            bool deferred = false;
            while (!deferred && i < stateConfiguration.children.Count)
            {
                deferred = _Defer(eventOccurrence, stateConfiguration.children.ElementAt(i));
                i++;
            }
            if (!deferred && stateConfiguration.vertexActivation != null
                    && ((StateActivation)stateConfiguration.vertexActivation).CanDefer(eventOccurrence))
            {
                ((StateActivation)stateConfiguration.vertexActivation).Defer(eventOccurrence);
                deferred = true;
            }
            return deferred;
        }

        public bool IsTriggering(EventOccurrence eventOccurrence)
        {
            // Returns true when one or more transition are ready to be fired using this
            // event
            // occurrence; false otherwise.
            return Select(eventOccurrence).Any();
        }

        protected List<TransitionActivation> Select(EventOccurrence eventOccurrence)
        {
            // Find for the given configuration the set of transition that can fire.
            return _Select(eventOccurrence, registrationContext?.configuration?.rootConfiguration!);
        }

        protected List<TransitionActivation> _Select(EventOccurrence eventOccurrence, StateConfiguration stateConfiguration)
        {
            // Find for the given state configuration all transition that can actually fire.
            // The set of transition only contains transitions with the highest priority. In
            // addition
            // no conflicting transitions are added to that set.
            List<TransitionActivation> selectedTransitions = new();
            for (int i = 0; i < stateConfiguration.children.Count; i++)
            {
                selectedTransitions.AddRange(_Select(eventOccurrence, stateConfiguration.children.ElementAt(i)));
            }
            if (!selectedTransitions.Any() && stateConfiguration.vertexActivation != null)
            {
                for (int i = 0; i < stateConfiguration.vertexActivation.outgoingTransitionActivations.Count; i++)
                {
                    TransitionActivation transitionActivation = stateConfiguration.vertexActivation
                            .outgoingTransitionActivations.ElementAt(i);
                    if (transitionActivation.CanFireOn(eventOccurrence))
                    {
                        selectedTransitions.Add(transitionActivation);
                    }
                }
                if (selectedTransitions.Count > 1)
                {
                    ChoiceStrategy choiceStrategy = (ChoiceStrategy)registrationContext!.locus!.factory!
                            .GetStrategy("choice");
                    TransitionActivation electedTransition = selectedTransitions
                            .ElementAt(choiceStrategy.Choose(selectedTransitions.Count) - 1);
                    selectedTransitions.Clear();
                    selectedTransitions.Add(electedTransition);
                }
            }
            return selectedTransitions;
        }
    } // StateMachineEventAccepter
}
