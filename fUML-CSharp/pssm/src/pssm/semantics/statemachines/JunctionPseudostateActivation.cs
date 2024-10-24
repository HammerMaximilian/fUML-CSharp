using fuml.semantics.commonbehavior;
using fuml.semantics.loci;

namespace pssm.semantics.statemachines
{
    public class JunctionPseudostateActivation : ConditionalPseudostateActivation
    {
        public override void Enter(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
			// When entered the junction pseudo-state the set of fireable transition (calculated during static
			// analysis) is used to determine which transition will actually be fired. The transition selected
			// to be fired is determined using the choice semantic strategy.
			base.Enter(enteringTransition, eventOccurrence, leastCommonAncestor);
			TransitionActivation selectedTransition;
			if (fireableTransitions.Count == 1)
			{
				selectedTransition = fireableTransitions.ElementAt(0);
			}
			else
			{
				ChoiceStrategy choiceStrategy = (ChoiceStrategy)GetExecutionLocus()?.factory?.GetStrategy("choice")!;
				int index = choiceStrategy.Choose(fireableTransitions.Count) - 1;
				selectedTransition = fireableTransitions.ElementAt(index);
			}
			if (selectedTransition != null)
			{
				selectedTransition.Fire(eventOccurrence);
			}
		}
    } // JunctionPseudostateActivation
}
