using fuml.semantics.commonbehavior;
using fuml.semantics.loci;

namespace pssm.semantics.statemachines
{
    public class JoinPseudostateActivation : PseudostateActivation
    {
        public override bool IsEnterable(TransitionActivation enteringTransition, bool staticCheck)
        {
            // Determine if all incoming transitions except this one already have been traversed
            // If this is the case then this node is ready to be entered
            int i = 0;
            bool isReady = true;
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
        private bool _CanPropagateExecution(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
            // Convenience method. Java does no allow a call to an explicit super class method. For documentation
            // developpers must have a look to: VertexActivation::canPropagateExecution(...)
            bool propagate = true;
            if (leastCommonAncestor != null)
            {
                RegionActivation parentRegionActivation = GetOwningRegionActivation();
                if (leastCommonAncestor != parentRegionActivation)
                {
                    VertexActivation vertexActivation = (VertexActivation)parentRegionActivation?.parent!;
                    if (vertexActivation != null)
                    {
                        propagate = vertexActivation.CanPropagateExecution(enteringTransition, eventOccurrence, leastCommonAncestor);
                    }
                }
            }
            return propagate;
        }

        public override bool CanPropagateExecution(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
            // If the join pseudo-state cannot be entered the propagation stops and returns true. Otherwise
            // to return true it is required that at least on outgoing transition of the pseudo-state 
            // accept the propagation. 
            enteringTransition.analyticalStatus = TransitionMetadata.TRAVERSED;
            bool propagate = _CanPropagateExecution(enteringTransition, eventOccurrence, leastCommonAncestor);
            if (propagate && IsEnterable(enteringTransition, true))
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
            // A join pseudo-state is only allowed to bentered  if all is incoming transitions (except the one
            // currently used to perform the entry) were traversed. When the join pseudo-state is finally entered
            // is traversal is straightforward : one of its fireable transition is traversed. The transition selected
            // to be fired is chosen using the choice strategy.
            base.Enter(enteringTransition, eventOccurrence, leastCommonAncestor);
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
                selectedTransitionActivation.Fire(eventOccurrence);
            }
        }
    } // JoinPseudostateActivation
}
