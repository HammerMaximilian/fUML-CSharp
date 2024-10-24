using fuml.semantics.commonbehavior;
using uml.statemachines;
using uml.values;

namespace pssm.semantics.statemachines
{
    public abstract class ConditionalPseudostateActivation : PseudostateActivation
    {
        protected const string ELSE_OPERATOR = "else";

        public bool IsElseTransition(TransitionActivation transitionActivation)
        {
            // Determine if the given transition materialize the else branch of a conditional pseudo state.
            // A transition materializes an else branch since it has a guard which specification is
            // an Expression that has no operand(s) and whose symbol is "else"
            bool isElse = false;
            if (transitionActivation is not null)
            {
                Transition transition = (Transition)transitionActivation.node!;
                if (transition.guard is not null && transition.guard.specification is Expression expression)
                {
                    isElse = !expression.operand.Any() && expression.symbol is not null && expression.symbol!.Equals(ELSE_OPERATOR);
                }
            }
            return isElse;
        }

        public override void EvaluateAllGuards(EventOccurrence eventOccurrence)
        {
            // Evaluate all guards of transitions outgoing this conditional pseudo-state.
            // and populate the set of fireable transitions. Note that this set is cleared
            // before each evaluation.
            fireableTransitions.Clear();
            TransitionActivation? elseTransitionActivation = null;
            foreach (TransitionActivation transitionActivation in outgoingTransitionActivations)
            {
                if (IsElseTransition(transitionActivation))
                {
                    elseTransitionActivation = transitionActivation;
                }
                else
                {
                    if (transitionActivation.EvaluateGuard(eventOccurrence))
                    {
                        fireableTransitions.Add(transitionActivation);
                    }
                }
            }
            if (!fireableTransitions.Any() && elseTransitionActivation != null)
            {
                fireableTransitions.Add(elseTransitionActivation);
            }
        }
    } // ConditionalPseudostateActivation
}
