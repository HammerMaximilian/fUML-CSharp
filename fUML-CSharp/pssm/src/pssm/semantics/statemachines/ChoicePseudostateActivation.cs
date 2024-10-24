using fuml.semantics.commonbehavior;
using fuml.semantics.loci;
using System;

namespace pssm.semantics.statemachines
{
    public class ChoicePseudostateActivation : ConditionalPseudostateActivation
    {
        public override bool CanPropagateExecution(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
			// When a choice pseudo-state activation is reached, the static analysis is propagated to parent
			// vertex if required. If the propagation to the parent returns true then it is also the result
			// of the propagation on the choice pseudo-state. In other word the propagation stops after the
			// pseudo-state activation is reached.
			bool propagate = true;
			if (leastCommonAncestor is not null)
			{
				RegionActivation parentRegionActivation = GetOwningRegionActivation();
				if (leastCommonAncestor != parentRegionActivation)
				{
					VertexActivation vertexActivation = (VertexActivation)parentRegionActivation.parent!;
					if (vertexActivation is not null)
					{
						propagate = vertexActivation.CanPropagateExecution(enteringTransition, eventOccurrence, leastCommonAncestor);
					}
				}
			}
			return propagate;
		}

        public override void Enter(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
			// When an choice pseudo-state is reached then guards placed are evaluated [dynamically] (i.e. at the time were
			// the entry) is performed. If more than a guard evaluates to true then the selected transition is selected using
			// using the first choice semantic strategy
			base.Enter(enteringTransition, eventOccurrence, leastCommonAncestor);
			EvaluateAllGuards(eventOccurrence);
            if (fireableTransitions.Count > 0)
            {
                TransitionActivation? selectedTransition;
                if (fireableTransitions.Count == 1)
                {
                    selectedTransition = fireableTransitions.ElementAt(0);
                }
                else
                {
                    ChoiceStrategy strategy = (ChoiceStrategy)getExecutionContext()?.locus?.factory?.GetStrategy("choice")!;
                    selectedTransition = fireableTransitions.ElementAt(strategy.Choose(fireableTransitions.Count - 1));
                }
                // Note: Force a static analysis from the selected (maybe compound) transition.
                // The rationale is that it forces evaluation of downstream guards.
                selectedTransition.CanPropagateExecution(eventOccurrence);
                selectedTransition.Fire(eventOccurrence);
            }
        }
    } // ChoicePseudostateActivation
}
