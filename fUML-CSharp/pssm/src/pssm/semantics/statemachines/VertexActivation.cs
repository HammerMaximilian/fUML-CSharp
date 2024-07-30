using fuml.semantics.commonbehavior;
using fuml.semantics.loci;
using pssm.semantics.statemachines;
using System;
using uml.statemachines;

namespace pssm.semantics.statemachines
{
    public abstract class VertexActivation : StateMachineSemanticVisitor
    {
        // Status of the current vertex
        protected StateMetadata status = StateMetadata.IDLE;

        // Incoming transitions of that vertex
        protected List<TransitionActivation> incomingTransitionActivations = new();

        // Outgoing transitions of that vertex
        protected List<TransitionActivation> outgoingTransitionActivations = new();

        public virtual VertexActivation GetParentVertexActivation()
        {
            throw new NotImplementedException();
        }

        public virtual RegionActivation GetOwningRegionActivation()
        {
            throw new NotImplementedException();
        }

        public virtual VertexActivation GetVertexActivation(Vertex vertex)
        {
            // By default return nothing. Must be overridden by state activation;
            return null!;
        }

        public void TagOutgoingTransitions(TransitionMetadata status, bool staticCheck)
        {
            throw new NotImplementedException();
        }

        public void TagIncomingTransitions(TransitionMetadata status, bool staticCheck)
        {
            throw new NotImplementedException();
        }

        public List<VertexActivation> GetAscendingHierarchy()
        {
            throw new NotImplementedException();
        }

        public virtual void Enter(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
        }

        public virtual void Exit(TransitionActivation exitingTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        { 
        }
        public bool IsActive()
        {
            throw new NotImplementedException();
        }

        public RegionActivation GetLeastCommonAncestor(VertexActivation targetVertexActivation, TransitionKind transitionKind)
        {
            throw new NotImplementedException();
        }

	    private RegionActivation GetRegionActivation(SemanticVisitor semanticVisitor)
        {
            throw new NotImplementedException();
        }
        public virtual bool IsEnterable(TransitionActivation enteringTransition, bool staticCheck)
        {
            throw new NotImplementedException();
        }

        public virtual bool IsExitable(TransitionActivation exitingTransition, bool staticCheck)
        {
            throw new NotImplementedException();
        }

        public virtual void Terminate()
        {
            throw new NotImplementedException();
        }

        public virtual bool CanPropagateExecution(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
            throw new NotImplementedException();
        }
    } // VertexActivation
}
