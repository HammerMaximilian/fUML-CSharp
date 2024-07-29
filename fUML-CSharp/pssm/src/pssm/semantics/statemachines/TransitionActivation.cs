using fuml.semantics.commonbehavior;
using System;
using uml.commonstructure;

namespace pssm.semantics.statemachines
{
    public abstract class TransitionActivation : StateMachineSemanticVisitor
    {
        // The source activation of this transition activation
        protected VertexActivation? vertexSourceActivation = null;

        // The target activation of this transition activation
        protected VertexActivation? vertexTargetActivation = null;

        // The runtime status (NONE, REACHED, TRAVERSED) of the transition
        protected TransitionMetadata status = TransitionMetadata.NONE;

        // Least common ancestor of the source and the target. This is materialized
        // by the region activation that is the common ancestor of the source and the
        // target.
        private RegionActivation? leastCommonAncestor = null;

        // The static status (NONE, REACHED, TRAVERSED) of the transition
        protected TransitionMetadata analyticalStatus = TransitionMetadata.NONE;

        // The last event occurrence used during static analysis.
        private EventOccurrence? lastTriggeringEventOccurrence = null;

        // The last verdict when the execution was propagated over this transition.
        private bool lastPropagation = false;

        public bool IsReached(bool staticCheck)
        {
            throw new NotImplementedException();
        }

        public bool IsTraversed(bool staticCheck)
        {
            throw new NotImplementedException();
        }

        public override bool IsVisitorFor(NamedElement node)
        {
            throw new NotImplementedException();
        }

        public bool IsTriggered()
        {
            throw new NotImplementedException();
        }

        public bool IsGuarded()
        {
            throw new NotImplementedException();
        }

        public bool EvaluateGuard(EventOccurrence eventOccurrence)
        {
            throw new NotImplementedException();
        }

        public bool HasTrigger(EventOccurrence eventOccurrence)
        {
            throw new NotImplementedException();
        }

        public bool CanFireOn(EventOccurrence eventOccurrence)
        {
            throw new NotImplementedException();
        }

        public bool CanPropagateExecution(EventOccurrence eventOccurrence)
        {
            throw new NotImplementedException();
        }

        public void TryExecuteEffect(EventOccurrence eventOccurrence)
        {
        }

        public void Fire(EventOccurrence eventOccurrence)
        {
        }

        public RegionActivation GetLeastCommonAncestor()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    } // TransitionActivation
}
