using fuml.semantics.commonbehavior;
using fuml.semantics.loci;
using System;

namespace pssm.semantics.statemachines
{
    public class ExitPointPseudostateActivation : ConnectionPointActivation
    {
        public override bool IsEnterable(TransitionActivation enteringTransition, bool staticCheck)
        {
            // Determine if this exit point satisfied its requirement to be exited.
            // The requirement is: all incoming transitions must have been fired once
            // if they originate from sub-states located in orthogonal regions
            int i = 0;
            bool isReady = base.IsEnterable(enteringTransition, staticCheck);
            while (isReady && i < incomingTransitionActivations.Count)
            {
                TransitionActivation transitionActivation = incomingTransitionActivations.ElementAt(i);
                if (enteringTransition != transitionActivation)
                {
                    isReady = transitionActivation.IsTraversed(staticCheck);
                }
                i++;
            }
            return isReady;
        }

        public override bool CanPropagateExecution(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
            // If the exit point cannot be entered (see isEnterable(...) operation) then the propagation returns true.
            // If the exit poitn can be entered guards of its outgoing transitions are evaluated. Among the set of
            // fireable transitions, at least one of them must be able to accept the propagation.
            enteringTransition.analyticalStatus = TransitionMetadata.TRAVERSED;
            bool propagate = true;
            if (IsEnterable(enteringTransition, true))
            {
                EvaluateAllGuards(eventOccurrence);
                if (outgoingTransitionActivations.Count > 0)
                {
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
                TagIncomingTransitions(TransitionMetadata.NONE, true);
            }
            return propagate;
        }

        public override void Enter(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
            // When the ExitPoint is entered then the state on which it is placed is exited.
            // One outgoing transition is chosen non-deterministically in set of transition
            // that can be used to leave the ExitPoint. This transition is fired.
            if (fireableTransitions.Count > 0)
            {
                TransitionActivation selectedTransitionActivation;
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
                // When the exit point is entered that does not imply recursive entry of its parent
                base.Enter(enteringTransition, eventOccurrence, null!);
                VertexActivation vertexActivation = GetParentVertexActivation();
                // Only the state that owns the exit point is exited.
                vertexActivation?.Exit(enteringTransition, eventOccurrence, null!);
                selectedTransitionActivation.Fire(eventOccurrence);
            }
        }
    } // ExitPointPseudostateActivation
}
