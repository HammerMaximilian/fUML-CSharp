using fuml.semantics.commonbehavior;
using fuml.semantics.loci;
using System;
using uml.commonstructure;
using uml.statemachines;

namespace pssm.semantics.statemachines
{
    public class RegionActivation : StateMachineSemanticVisitor
    {
        // Semantic visitors for vertices owned by that region
        public List<VertexActivation> vertexActivations = new();

        // Semantic visitors for transitions owned by that region
        public List<TransitionActivation> transitionActivations = new();

        // Last known configuration for the region (updated on region exiting)
        // Null if this region has never been entered before.
        public StateActivation? history = null;

        // Is that region completed (e.g., the regions is completed
        // when the final state)
        public bool isCompleted = false;

        public override bool IsVisitorFor(NamedElement node)
        {
            // Determine if this visitor is a semantic visitor for the node
            // provided as parameter. This case is verified if the node is the
            // region attached to this semantic visitor or if the node matches
            // a region that is extended (directly or indirectly) by the region
            // attached to this semantic visitor.
            bool isVisitor = base.IsVisitorFor(node);
            if (!isVisitor)
            {
                Region region = ((Region)this.node!).extendedRegion!;
                while (!isVisitor && region != null)
                {
                    if (region == node)
                    {
                        isVisitor = true;
                    }
                    else
                    {
                        region = region.extendedRegion!;
                    }
                }
            }
            return isVisitor;
        }

        private bool IsRedefined(List<Vertex> vertices, Vertex vertex)
        {
            // Ensure that the given vertex is not already redefined by
            // a vertex already present in the list.
            bool isRedefined = false;
            if (vertex is State){
                // Required check since UML does not allow Vertex to be RedefinableElement
                // FIXME: possible to fix after revision of UML 2.5
                int i = 0;
                while (!isRedefined && i < vertices.Count)
                {
                    Vertex currentVertex = vertices.ElementAt(i);
                    if (currentVertex is State){
                        State state = ((State)currentVertex).redefinedState!;
                        while (!isRedefined && state != null)
                        {
                            isRedefined = state == vertex;
                            state = state.redefinedState!;
                        }
                    }
                    i++;
                }
            }
            return isRedefined;
        }

        public override void Activate()
        {
            // In the case where the region extends another region, then the list of
            // state composing the region is computed. This computation is the result
            // of the merge between the region and the extended region. The merge consists
            // in the addition to the set of vertex of all vertices that are not already
            // redefined by another vertex.
            Locus locus = GetExecutionLocus();
            Region region = (Region)node!;
            VertexActivation? activation = null;
            List<Vertex> regionVertices = new(region.subvertices);
            if (region.extendedRegion != null)
            {
                while (region.extendedRegion != null)
                {
                    region = region.extendedRegion;
                    foreach (Vertex vertex in region.subvertices)
                    {
                        if (!IsRedefined(regionVertices, vertex))
                        {
                            regionVertices.Add(vertex);
                        }
                    }
                }
            }
            foreach (Vertex vertex in regionVertices)
            {
                activation = (VertexActivation)locus.factory!.InstantiateVisitor(vertex);
                activation.parent = this;
                activation.node = vertex;
                activation.Activate();
                vertexActivations.Add(activation);
            }
        }

        private bool IsRedefined(List<Transition> transitions, Transition transition)
        {
            // Ensure that the given transition is not redefined by another transition
            // already included in the transition list.
            bool isRedefined = false;
            int i = 0;
            while (!isRedefined && i < transitions.Count)
            {
                Transition currentTransition = transitions.ElementAt(i).redefinedTransition!;
                while (!isRedefined && currentTransition != null)
                {
                    isRedefined = currentTransition == transition;
                    currentTransition = currentTransition.redefinedTransition!;
                }
                i++;
            }
            return isRedefined;
        }

        public void activateTransitions()
        {
            // Create all semantic visitors for transitions. The source and target
            // vertex activations of each transition activation is then assigned.
            // Only visitors for none redefined transitions are instantiated.
            Region region = (Region)node!;
            VertexActivation? sourceActivation = null;
            VertexActivation? targetActivation = null;
            TransitionActivation? transitionActivation = null;
            StateMachineExecution context = (StateMachineExecution)GetStateMachineExecution();
            List<Transition> transitions = new(region.transition);
            if (region.extendedRegion is not null)
            {
                while (region.extendedRegion is not null)
                {
                    region = region.extendedRegion;
                    foreach (Transition transition in region.transition)
                    {
                        if (!IsRedefined(transitions, transition))
                        {
                            transitions.Add(transition);
                        }
                    }
                }
            }
            foreach (Transition transition in transitions)
            {
                sourceActivation = context.GetVertexActivation(transition.source!);
                targetActivation = context.GetVertexActivation(transition.target!);
                transitionActivation = (TransitionActivation)context.locus!.factory!.InstantiateVisitor(transition);
                transitionActivation.node = (transition);
                transitionActivation.parent = (this);
                transitionActivation.vertexSourceActivation = (sourceActivation);
                transitionActivation.vertexTargetActivation = (targetActivation);
                transitionActivations.Add(transitionActivation);
                sourceActivation.outgoingTransitionActivations.Add(transitionActivation);
                targetActivation.incomingTransitionActivations.Add(transitionActivation);
            }
            foreach (VertexActivation activation in vertexActivations)
            {
                activation.ActivateTransitions();
            }
        }

        public VertexActivation GetVertexActivation(Vertex vertex)
        {
            // Recursive search through the hierarchy of visitors materializing
            // the sub-set of the state-machine represented by this region.
            // The search is realized in two steps:
            // 	1 - Search a matching activation in set of vertex activations owned by the region activation
            //  2 - If no match, then the search is propagated to each vertex activation owned by the region activation
            // Matching rules (or):
            //  1 - A vertex matches a vertex activation if the node for which this activation is an
            //      an interpreter is the vertex.
            //  2 - A vertex matches a vertex activation if the node for which this activation is an
            //      interpreter redefines the vertex 
            int i = 0;
            VertexActivation? activation = null;
            while (activation == null && i < vertexActivations.Count)
            {
                if (vertexActivations.ElementAt(i).IsVisitorFor(vertex))
                {
                    activation = vertexActivations.ElementAt(i);
                }
                i++;
            }
            i = 0;
            while (activation == null && i < vertexActivations.Count)
            {
                if (vertexActivations.ElementAt(i).IsVisitorFor(vertex))
                {
                    activation = vertexActivations.ElementAt(i);
                }
                else
                {
                    activation = vertexActivations.ElementAt(i).GetVertexActivation(vertex);
                }
                i++;
            }
            return activation!;
        }

        public bool CanPropagateExecution(EventOccurrence eventOccurrence, TransitionActivation enteringTransition)
        {
            // If the region does not provide a initial pseudo-state activation
            // then the execution is considered as being allowed to propagate. The
            // rationale for this choice is that if no initial pseudo state activation
            // is discovered then the region is not considered by the execution.
            // Otherwise if the region has an initial pseudo state activation then
            // the propagation analysis continues through this activation.
            bool propagate = true;
            if (GetVertexActivation((Vertex)enteringTransition.vertexTargetActivation!.node!) == null)
            {
                PseudostateActivation initialNodeActivation = GetOrigin();
                if (initialNodeActivation != null)
                {
                    propagate = initialNodeActivation.CanPropagateExecution(enteringTransition, eventOccurrence, null);
                }
            }
            return propagate;
        }

        public PseudostateActivation GetOrigin()
        {
            // Return, if any, the initial pseudo-state activation directly
            // owned by this region.
            int i = 0;
            PseudostateActivation? initialNodeActivation = null;
            while (initialNodeActivation == null && i < vertexActivations.Count)
            {
                if (vertexActivations.ElementAt(i) is InitialPseudostateActivation){
                    initialNodeActivation = (PseudostateActivation)vertexActivations.ElementAt(i);
                }else
                {
                    i++;
                }
            }
            return initialNodeActivation!;
        }

        public void Enter(TransitionActivation enteringTransition, EventOccurrence eventOccurrence)
        {
            // An implicit entry of a region means the initial transition is searched.
            // If such transition exists then it is fired. An explicit entry as no impact on the region.
            // In case the region is entered implicitly a initial pseudo state shall be found to
            // start its execution. If no such pseudo-state is found and the state containing
            // the region has no other region(s) then the state is treated as a simple leaf state
            PseudostateActivation initialNodeActivation = GetOrigin();
            if (initialNodeActivation != null)
            {
                initialNodeActivation.Enter(enteringTransition, eventOccurrence, null);
            }
            else
            {
                SemanticVisitor parent = this.parent!;
                if (parent != null && parent is StateActivation parentState){
                    parentState.regionActivation.Remove(this);
                    if (parentState.HasCompleted())
                    {
                        parentState.Complete();
                    }
                }
            }
        }

        public void Exit(TransitionActivation exitingTransition, EventOccurrence eventOccurrence)
        {
            // Exiting a region implies exiting all of is active vertices.
            // Note: there is always a single active vertex for a given region.
            foreach (VertexActivation vertexActivation in vertexActivations)
            {
                if (vertexActivation.IsActive())
                {
                    vertexActivation.Exit(exitingTransition, eventOccurrence, null!);
                }
            }
            isCompleted = false;
        }

        public void Terminate()
        {
            // Capture the semantics related to the termination of a region. Regions typically
            // gets terminated when the state-machine which contains it is gets itself terminated.
            for (int i = 0; i < vertexActivations.Count; i++)
            {
                vertexActivations.ElementAt(i).Terminate();
            }
            vertexActivations.Clear();
            transitionActivations.Clear();
        }

    } // RegionActivation
}
