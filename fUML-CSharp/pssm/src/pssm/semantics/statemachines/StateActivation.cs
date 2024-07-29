using fuml.semantics.commonbehavior;
using System;
using uml.commonbehavior;
using uml.commonstructure;
using uml.statemachines;

namespace pssm.semantics.statemachines
{
    public class StateActivation : VertexActivation
    {
        // The visitors for the regions owned by this state
        protected List<RegionActivation> regionActivation = new();

        // The visitors for the connection points (EntryPoint / ExitPoint) owned by this state 
        protected List<PseudostateActivation> connectionPointActivation = new();

        // Boolean flag to know if the entry behavior was completed
        public bool isEntryCompleted = false;

        // Boolean flag to know if the doActivity behavior was completed
        public bool isDoActivityCompleted = false;

        // Boolean flag to know if the exit behavior was completed
        public bool isExitCompleted;

        // The context object in which is executed the doActivity
        // owned by the visited state
        public DoActivityContextObject? doActivityContextObject = null;

        public bool HasCompleted()
        {
            throw new NotImplementedException();
        }

        public void Complete()
        {
        }

        public PseudostateActivation GetConnectionPointActivation(Vertex vertex)
        {
            throw new NotImplementedException();
        }

        public override bool IsVisitorFor(NamedElement node)
        {
            throw new NotImplementedException();
        }


        public override VertexActivation GetVertexActivation(Vertex vertex)
        {
            throw new NotImplementedException();
        }

        public override void Activate()
        {
        }

        public override void ActivateTransitions()
        {
        }

        public Behavior GetEntry()
        {
            throw new NotImplementedException();
        }

        public Behavior GetExit()
        {
            throw new NotImplementedException();
        }

        public Behavior GetDoActivity()
        {
            throw new NotImplementedException();
        }

        public void TryExecuteEntry(EventOccurrence eventOccurrence)
        {
        }

        public void TryInvokeDoActivity(EventOccurrence eventOccurrence)
        {
        }

        public void TryExecuteExit(EventOccurrence eventOccurrence)
        {
        }

        public void EnterRegions(TransitionActivation enteringTransition, EventOccurrence eventOccurrence)
        {
        }

        
        public override bool IsEnterable(TransitionActivation enteringTransition, bool staticCheck)
        {
            throw new NotImplementedException();
        }
        
        public override bool CanPropagateExecution(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
            throw new NotImplementedException();
        }

        public void Enter(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
        }

        
        public override bool IsExitable(TransitionActivation exitingTransition, bool staticCheck)
        {
            throw new NotImplementedException();
        }

        public void Exit(TransitionActivation exitingTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
        }

        public List<TransitionActivation> GetFireableTransitions(EventOccurrence eventOccurrence)
        {
            throw new NotImplementedException();
        }

        public bool CanDefer(EventOccurrence eventOccurrence)
        {
            throw new NotImplementedException();
        }

        public void Defer(EventOccurrence eventOccurrence)
        {
        }

        public void ReleaseDeferredEvents()
        {
        }

        public void Terminate()
        {
        }

    } // StateActivation
}
