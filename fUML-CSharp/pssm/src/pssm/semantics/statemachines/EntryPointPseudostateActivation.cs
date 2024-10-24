using fuml.semantics.commonbehavior;
using fuml.semantics.loci;
using System;

namespace pssm.semantics.statemachines
{
    public class EntryPointPseudostateActivation : ConnectionPointActivation
    {
        public override bool IsExitable(TransitionActivation exitingTransition, bool staticCheck)
        {
            // If the state on which is this pseudostate is placed is not orthogonal (i.e. at least
            // composed of two regions) then no constraints are placed on the triggering of it exit
            // sequence. Otherwise, the constraint is that the entry pseudostate can only be exited
            // when all of its outgoing transitions have been fired.
            int i = 0;
            bool isExitable = true;
            VertexActivation parentVertexActivation = GetParentVertexActivation();
            if (parentVertexActivation != null && ((StateActivation)parentVertexActivation).regionActivation.Count > 1)
            {
                while (isExitable && i < outgoingTransitionActivations.Count)
                {
                    TransitionActivation transitionActivation = outgoingTransitionActivations.ElementAt(i);
                    if (transitionActivation != exitingTransition)
                    {
                        isExitable = transitionActivation.IsTraversed(staticCheck);
                    }
                    i++;
                }
            }
            return isExitable;
        }

        public override bool CanPropagateExecution(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
            // Static analysis is propagated to the parents. If the propagation is accepted, then all outgoing transitions
            // guards are evaluated. For the propagation to be accepted through this pseudo-state activation:
            // 
            // 1. If the parent state is orthogonal, all transitions must be fireable and all of them
            // must accept the propagation.
            // 
            // 2. If the parent state is not orthogonal, at least one of the transition must be able
            // to accept the propagation.
            bool propagate = true;
            VertexActivation vertexActivation = GetParentVertexActivation();
            if (vertexActivation != null)
            {
                propagate = vertexActivation.CanPropagateExecution(enteringTransition, eventOccurrence, leastCommonAncestor);
                if (IsEnterable(enteringTransition, true) && outgoingTransitionActivations.Count > 0)
                {
                    EvaluateAllGuards(eventOccurrence);
                    if (((StateActivation)vertexActivation).regionActivation.Count > 1)
                    {
                        if (outgoingTransitionActivations.Count == fireableTransitions.Count)
                        {
                            int i = 0;
                            while (propagate && i < fireableTransitions.Count)
                            {
                                propagate = fireableTransitions.ElementAt(i).CanPropagateExecution(eventOccurrence);
                                i++;
                            }
                        }
                        else
                        {
                            propagate = false;
                        }
                    }
                    else
                    {
                        int i = 0;
                        propagate = false;
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

        protected void _Enter(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
            // When an exit point is entered its owning state is entered. That state maybe located
            // in a nested hierarchy which is not already active. Hence if the hierarchy is not
            // already active then it is entered.
            base.Enter(enteringTransition, eventOccurrence, null!);
            VertexActivation vertexActivation = GetParentVertexActivation();
            vertexActivation?.Enter(enteringTransition, eventOccurrence, leastCommonAncestor);
        }

        public override void Enter(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
            // Enter a state through an entry point. The state on which the entry point is
            // placed can be a deeply nested state. Therefore parent state of that state must
            // be entered before if it is not already the case. Next according to the orthogonality
            // of the parent StateActivation behave like a Fork or a Junction.
            _Enter(enteringTransition, eventOccurrence, leastCommonAncestor);
            VertexActivation parentVertexActivation = GetParentVertexActivation();
            if (parentVertexActivation != null)
            {
                if (((StateActivation)parentVertexActivation).regionActivation.Count > 1)
                {
                    // Behave like a Fork pseudostate - all outgoing transitions must fire concurrently 
                    foreach (TransitionActivation fireableTransition in fireableTransitions)
                    {
                        fireableTransition.Fire(eventOccurrence);
                    }
                }
                else
                {
                    // Behave like a Junction pseudostate - on of the outgoing transition is chosen to be fired
                    if (fireableTransitions.Count > 0)
                    {
                        TransitionActivation? selectedTransitionActivation;
                        if (fireableTransitions.Count == 1)
                        {
                            selectedTransitionActivation = fireableTransitions.ElementAt(0);
                        }
                        else
                        {
                            ChoiceStrategy choiceStrategy = (ChoiceStrategy)GetExecutionLocus()?.factory?.GetStrategy("choice")!;
                            int chosenIndex = choiceStrategy.Choose(fireableTransitions.Count);
                            selectedTransitionActivation = fireableTransitions.ElementAt(chosenIndex - 1);
                        }
                        selectedTransitionActivation.Fire(eventOccurrence);
                    }
                }
            }
        }

        public override void Exit(TransitionActivation exitingTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
            // When the entry point is exited it does not imply exiting parent state.
            // Only the entry point is exited and this has no effect on its parent state.
            base.Exit(exitingTransition, eventOccurrence, null!);
        }
    } // EntryPointPseudostateActivation
}
