using fuml.semantics.commonbehavior;
using System;

namespace pssm.semantics.statemachines
{
    public abstract class PseudostateActivation : VertexActivation
    {
        // Transitions that were fireable at the time which the pseudo-state was
        // evaluated.
        protected List<TransitionActivation> fireableTransitions = new();

        public virtual void EvaluateAllGuards(EventOccurrence eventOccurrence)
        {
            // Evaluate all guards of outgoing transitions of the pseudo-state.
            // Guard evaluation populate the set of fireable transitions with
            // transitions whith guard evaluating to true. Not that this evaluation
            // is not done at the time the where this pseudo-state is entered. Instead
            // it is done statically when the compound transition leading to this
            // pseudo-state is evaluated.
            fireableTransitions.Clear();
            for (int i = 0; i < outgoingTransitionActivations.Count; i++)
            {
                TransitionActivation transitionActivation = outgoingTransitionActivations.ElementAt(i);
                if (transitionActivation.EvaluateGuard(eventOccurrence))
                {
                    fireableTransitions.Add(transitionActivation);
                }
            }
        }

        public override bool CanPropagateExecution(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
            // Static analysis is propagated to the parent vertex. If the parent accepts the
            // propagation and the
            // pseudo-state can be entered then it must be possible to propagate the
            // execution through at least
            // one of the outgoing transitions of the pseudo-state. If it is not possible
            // false is returned. Not that
            // in case where the pseudo-state cannot be entered true is returned.
            bool propagate = base.CanPropagateExecution(enteringTransition, eventOccurrence, leastCommonAncestor);
            if (propagate && IsEnterable(enteringTransition, true))
            {
                if (outgoingTransitionActivations.Count > 0)
                {
                    EvaluateAllGuards(eventOccurrence);
                    propagate = false;
                    if (fireableTransitions.Count > 0)
                    {
                        int i = 0;
                        while (!propagate && i < fireableTransitions.Count)
                        {
                            propagate = fireableTransitions.ElementAt(i).CanPropagateExecution(eventOccurrence);
                            i++;
                        }
                    }
                }
            }
            return propagate;
        }
    } // PseudostateActivation
}
