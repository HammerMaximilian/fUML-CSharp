using fuml.semantics.commonbehavior;
using fuml.semantics.loci;
using pssm.semantics.statemachines;
using System;
using System.Xml.Linq;
using uml.commonstructure;
using uml.statemachines;

namespace pssm.semantics.statemachines
{
    public abstract class VertexActivation : StateMachineSemanticVisitor
    {
        // Status of the current vertex
        public StateMetadata status = StateMetadata.IDLE;

        // Incoming transitions of that vertex
        public List<TransitionActivation> incomingTransitionActivations = new();

        // Outgoing transitions of that vertex
        public List<TransitionActivation> outgoingTransitionActivations = new();

        public virtual VertexActivation GetParentVertexActivation()
        {
            // The parent state of a vertex is either a StateMachineExecution or a
            // StateActivation
            IRegionActivation regionActivation = (IRegionActivation)this.getParent();
            if (regionActivation != null)
            {
                if (regionActivation.getParent() instanceof StateMachineExecution) {
                    return null;
                } else
                {
                    return (VertexActivation)regionActivation.getParent();
                }
            }
            return null;
        }

        public virtual RegionActivation GetOwningRegionActivation()
        {
            // In general for a vertex activation its owning region activation
            // is its direct parent. Not that is not true for the exit point
            // activation as well as the entry point activation. This operation
            // is therefore overridden in these two context
            return (RegionActivation)this.parent;
        }

        public virtual VertexActivation GetVertexActivation(Vertex vertex)
        {
            // By default return nothing. Must be overridden by state activation;
            return null!;
        }

        public void TagOutgoingTransitions(TransitionMetadata status, bool staticCheck)
        {
            // Assign the given status (runtime or analysis) to all outgoing transitions of
            // this vertex
            for (ITransitionActivation transitionActivation : this.outgoingTransitionActivations)
            {
                if (staticCheck)
                {
                    transitionActivation.setAnalyticalStatus(status);
                }
                else
                {
                    transitionActivation.setStatus(status);
                }
            }
        }

        public void TagIncomingTransitions(TransitionMetadata status, bool staticCheck)
        {
            // Assign the given status (runtime or analysis) to all incoming transitions of
            // this vertex
            for (ITransitionActivation transitionActivation : this.incomingTransitionActivations)
            {
                if (staticCheck)
                {
                    transitionActivation.setAnalyticalStatus(status);
                }
                else
                {
                    transitionActivation.setStatus(status);
                }
            }
        }

        public List<VertexActivation> GetAscendingHierarchy()
        {
            // Provides the hierarchy of state activations starting from the current
            // element. This list is ordered from the innermost element to the outermost
            // element
            List<IVertexActivation> hierarchy = new ArrayList<IVertexActivation>();
            List<ISemanticVisitor> contextChain = this.getContextChain();
            for (ISemanticVisitor element : contextChain)
            {
                if (element is StateActivation) 
                {
                    hierarchy.add((StateActivation)element);
                }
            }
		    return hierarchy;
        }

        public virtual void Enter(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
            // When a vertex is entered its parent may need to be entered as well. Such
            // situation
            // occurs when the parent is not active while there is an attempt to enter the
            // current
            // vertex activation. What is important here is that entry rule is applied
            // recursively
            // until the least common ancestor is reached.
            IRegionActivation owningRegionActivation = this.getOwningRegionActivation();
            if (leastCommonAncestor != null && owningRegionActivation != null
                    && leastCommonAncestor != owningRegionActivation)
            {
                IVertexActivation vertexActivation = (IVertexActivation)owningRegionActivation.getParent();
                if (vertexActivation != null)
                {
                    vertexActivation.enter(enteringTransition, eventOccurrence, leastCommonAncestor);
                }
            }

            this.setStatus(StateMetadata.ACTIVE);
            this.tagOutgoingTransitions(TransitionMetadata.REACHED, false);
        }

        public virtual void Exit(TransitionActivation exitingTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
            // When a vertex is exited its parent may need to be exited too. Such situation
            // typically
            // occurs when the current vertex is exited through a transition that cross
            // boundaries of
            // the parent state (and maybe also border its own parent). This implies that
            // from the current
            // vertex and until the least common ancestor is reached all states are exited
            // recursively.
            this.tagIncomingTransitions(TransitionMetadata.NONE, false);
            this.setStatus(StateMetadata.IDLE);

            IRegionActivation owningRegionActivation = this.getOwningRegionActivation();
            if (leastCommonAncestor != null && owningRegionActivation != null
                    && leastCommonAncestor != owningRegionActivation)
            {
                IVertexActivation vertexActivation = (VertexActivation)owningRegionActivation.getParent();
                if (vertexActivation != null)
                {
                    vertexActivation.exit(exitingTransition, eventOccurrence, leastCommonAncestor);
                }
            }
        }
        public bool IsActive()
        {
            // By default is is possible to assess if a vertex is active by checking
            // if its status is ACTIVE. Note this operation is overriden in the context
            // of state activations which require a presence within the state-machine
            // configuration.
            return this.status.equals(StateMetadata.ACTIVE);
        }

        public RegionActivation GetLeastCommonAncestor(VertexActivation targetVertexActivation, TransitionKind transitionKind)
        {
            // Determine the semantic visitor being the least common ancestor between
            // the current vertex activation and the target vertex activation (provided as
            // a parameter). The analysis is based on a comparative analysis vertices
            // (source and
            // target) hierarchies.
            IRegionActivation leastCommonAncestor = null;
            ISemanticVisitor sourceHierachyNode = null;
            ISemanticVisitor targetHierarchyNode = null;
            List<ISemanticVisitor> sourceHierarchy = this.getContextChain();
            List<ISemanticVisitor> targetHierarchy = targetVertexActivation.getContextChain();
            int sourceHierarchyIndex = sourceHierarchy.size();
            int targetHierarchyIndex = targetHierarchy.size();
            // Check if a difference can be found in between the two subsets
            // delimited by the common index. Iterate until the least common
            // ancestor is found or the two subsets have been reviewed
            while (leastCommonAncestor == null && sourceHierarchyIndex > 0 && targetHierarchyIndex > 0)
            {
                sourceHierachyNode = sourceHierarchy.get(sourceHierarchyIndex - 1);
                targetHierarchyNode = targetHierarchy.get(targetHierarchyIndex - 1);
                if (sourceHierachyNode != targetHierarchyNode)
                {
                    leastCommonAncestor = this.getRegionActivation(sourceHierachyNode);
                }
                else
                {
                    sourceHierarchyIndex = sourceHierarchyIndex - 1;
                    targetHierarchyIndex = targetHierarchyIndex - 1;
                }
            }
            // It may happen than no difference could found in the hierarchy subsets
            // previously reviewed. This indicate two possible situations:
            // 1. The source and the target are the same.
            // 2. There is containing / container relationship existing between
            // the source and the target.
            if (leastCommonAncestor == null)
            {
                if (sourceHierarchyIndex == 0 && targetHierarchyIndex == 0)
                {
                    leastCommonAncestor = this.getRegionActivation(sourceHierarchy.get(sourceHierarchyIndex + 1));
                }
                else
                {
                    if (this.getVertexActivation((Vertex)targetVertexActivation.getNode()) != null)
                    {
                        if (transitionKind == TransitionKind.EXTERNAL_LITERAL)
                        {
                            leastCommonAncestor = this.getRegionActivation(sourceHierarchy.get(sourceHierarchyIndex));
                        }
                        else
                        {
                            leastCommonAncestor = this.getRegionActivation(targetHierarchy.get(targetHierarchyIndex - 1));
                        }
                    }
                    else
                    {
                        leastCommonAncestor = this.getRegionActivation(sourceHierarchy.get(sourceHierarchyIndex - 1));
                    }
                }
            }
            return leastCommonAncestor;
        }

	    private RegionActivation GetRegionActivation(SemanticVisitor semanticVisitor)
        {
            // If the given semantic visitor is a region activation then this activation
            // is returned. Otherwise if the visitor is a vertex activation then its
            // parent region activation is returned.
            IRegionActivation regionActivation = null;
            if (semanticVisitor instanceof IRegionActivation) {
                regionActivation = (IRegionActivation)semanticVisitor;
            } else if (semanticVisitor instanceof VertexActivation) {
                regionActivation = (IRegionActivation)((IVertexActivation)semanticVisitor).getParent();
            }
            return regionActivation;
        }
        public virtual bool IsEnterable(TransitionActivation enteringTransition, bool staticCheck)
        {
            // By default a vertex has no prerequisites that need to be full-filled
            // to be entered. Nevertheless some vertex (e.g., join or exit) have such
            // prerequisites. Therefore this method is intended to be overridden in vertex
            // activation sub-classes.
            return true;
        }

        public virtual bool IsExitable(TransitionActivation exitingTransition, bool staticCheck)
        {
            // By default a vertex has no prerequisites that need to be full-filled to be
            // entered
            // Nevertheless some vertex (e.g., Fork) have such prerequisite. Therefore this
            // method
            // is intended to be overridden in vertex activation sub-classes.
            return true;
        }

        public virtual void Terminate()
        {
            // Terminate applied by a vertex activation does nothing by default. However it
            // is intended
            // to be overridden by sub-classe(s)
            return;
        }

        public virtual bool CanPropagateExecution(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
            // The common behavior of all kind of vertices is that when the propagation
            // analysis is done
            // if a the target is a vertex that is nested within a hierarchy then the
            // analysis
            // must be recursively propagated to the parent vertices.
            boolean propagate = true;
            if (leastCommonAncestor != null)
            {
                IRegionActivation parentRegionActivation = this.getOwningRegionActivation();
                if (leastCommonAncestor != parentRegionActivation)
                {
                    IVertexActivation vertexActivation = (IVertexActivation)parentRegionActivation.getParent();
                    if (vertexActivation != null)
                    {
                        propagate = vertexActivation.canPropagateExecution(enteringTransition, eventOccurrence,
                                leastCommonAncestor);
                    }
                }
            }
            return propagate;
        }
    } // VertexActivation
}
