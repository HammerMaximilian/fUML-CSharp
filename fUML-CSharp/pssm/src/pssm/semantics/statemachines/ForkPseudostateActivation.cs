using fuml.semantics.commonbehavior;
using System;

namespace pssm.semantics.statemachines
{
    public class ForkPseudostateActivation : PseudostateActivation
    {
        public override bool IsExitable(TransitionActivation exitingTransition, bool staticCheck)
        {
            // The Fork node activation can only be exited when all of its outgoing transitions
            // (expect the current "exitingTransition")previously fired.
            int i = 0;
            bool isExitable = true;
            while (isExitable && i < outgoingTransitionActivations.Count)
            {
                TransitionActivation transitionActivation = outgoingTransitionActivations.ElementAt(i);
                if (transitionActivation != exitingTransition)
                {
                    isExitable = transitionActivation.IsTraversed(staticCheck);
                }
                i++;
            }
            return isExitable;
        }
        private bool _CanPropagateExecution(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
            // Convenience method. Java does no allow a call to an explicit super class method. For documentation
            // developers must have a look to: VertexActivation::canPropagateExecution(...)
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
            // Static analysis is propagated through the parent. If the propagation is accepted by the parent, then it is evaluated
            // for this pseudo-state. A fork pseudo-state can propagate the execution if all of its outgoing transitions can
            // propagate the execution. Note that there is no guard evaluation. This is normal since outgoing transitions of
            // a fork cannot have guards.
            bool propagate = _CanPropagateExecution(enteringTransition, eventOccurrence, leastCommonAncestor);
            if (propagate && IsEnterable(enteringTransition, true))
            {
                int i = 0;
                while (propagate && i < outgoingTransitionActivations.Count)
                {
                    propagate = outgoingTransitionActivations.ElementAt(i).CanPropagateExecution(eventOccurrence);
                    i++;
                }
            }
            return propagate;
        }

        public override void Enter(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
            // Fires all outgoing transitions of the for **concurrently**
            // Transitions outgoing from a fork are not guarded nor triggered
            // If required parent state is entered first (the rule applies recursively)
            base.Enter(enteringTransition, eventOccurrence, leastCommonAncestor);
            foreach (TransitionActivation fireableTransition in outgoingTransitionActivations)
            {
                fireableTransition.Fire(eventOccurrence);
            }
        }
    } // ForkPseudostateActivation
}
