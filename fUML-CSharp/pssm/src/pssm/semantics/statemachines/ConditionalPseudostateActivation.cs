using fuml.semantics.commonbehavior;
using System;
using uml.simpleclassifiers;

namespace pssm.semantics.statemachines
{
    public abstract class ConditionalPseudostateActivation : PseudostateActivation
    {
        protected const string ELSE_OPERATOR = "else";

        public bool IsElseTransition(TransitionActivation transitionActivation)
        {
            throw new NotImplementedException();
        }

        public override void EvaluateAllGuards(EventOccurrence eventOccurrence)
        {
        }
    } // ConditionalPseudostateActivation
}
