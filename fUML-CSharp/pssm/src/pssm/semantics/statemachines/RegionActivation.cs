using fuml.semantics.commonbehavior;
using System;
using uml.commonstructure;
using uml.statemachines;

namespace pssm.semantics.statemachines
{
    public class RegionActivation : StateMachineSemanticVisitor
    {
        // Semantic visitors for vertices owned by that region
        protected List<VertexActivation> vertexActivations = new();

        // Semantic visitors for transitions owned by that region
        protected List<TransitionActivation> transitionActivations = new();

        // Last known configuration for the region (updated on region exiting)
        // Null if this region has never been entered before.
        protected StateActivation? history = null;

        // Is that region completed (e.g., the regions is completed
        // when the final state)
        public bool isCompleted = false;

        public override bool IsVisitorFor(NamedElement node)
        {
            throw new NotImplementedException();
        }

        private bool IsRedefined(List<Vertex> vertices, Vertex vertex)
        {
            throw new NotImplementedException();
        }

        public override void Activate()
        {
        }

        private bool IsRedefined(List<Transition> transitions, Transition transition)
        {
            throw new NotImplementedException();
        }

        public void activateTransitions()
        {
        }
        public VertexActivation GetVertexActivation(Vertex vertex)
        {
            throw new NotImplementedException();
        }

        public bool CanPropagateExecution(EventOccurrence eventOccurrence, TransitionActivation enteringTransition)
        {
            throw new NotImplementedException();
        }

        public PseudostateActivation GetOrigin()
        {
            throw new NotImplementedException();
        }

        public void Enter(TransitionActivation enteringTransition, EventOccurrence eventOccurrence)
        {
        }

        public void Exit(TransitionActivation exitingTransition, EventOccurrence eventOccurrence)
        {
        }

        public void Terminate()
        {
        }

    } // RegionActivation
}
