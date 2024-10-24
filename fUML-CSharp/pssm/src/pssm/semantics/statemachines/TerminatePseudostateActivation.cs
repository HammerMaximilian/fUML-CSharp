using fuml.semantics.commonbehavior;

namespace pssm.semantics.statemachines
{
    public class TerminatePseudostateActivation : PseudostateActivation
    {
        public override void Enter(TransitionActivation enteringTransition, EventOccurrence eventOccurrence, RegionActivation leastCommonAncestor)
        {
            // When a terminate pseudo state is entered the state-machine executing terminates its execution.
            // This termination occurs without exiting "exit" behaviors of state(s) that are currently
            // registered in the state-machine configuration.
            // 
            // Note: the termination of the current state-machine execution leads
            // to the destruction of its context object. This means the object
            // will be stopped and consequently no any other event will be dispatched
            // and the object will finally be removed from the locus.
            base.Enter(enteringTransition, eventOccurrence, leastCommonAncestor);
            Execution stateMachineExecution = GetStateMachineExecution();
            stateMachineExecution.Terminate();
            stateMachineExecution.context!.Destroy();
            base.Exit(null!, null!, null!);
        }
    } // TerminatePseudostateActivation
}
