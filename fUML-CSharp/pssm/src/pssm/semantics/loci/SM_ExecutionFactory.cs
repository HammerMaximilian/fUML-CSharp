using fuml.semantics.loci;
using pscs.semantics.loci;
using pssm.semantics.actions;
using pssm.semantics.statemachines;
using pssm.semantics.values;
using uml.actions;
using uml.commonstructure;
using uml.statemachines;
using uml.values;

namespace pssm.semantics.loci
{
    public class SM_ExecutionFactory : CS_ExecutionFactory
    {
        public override SemanticVisitor InstantiateVisitor(Element element)
        {
            // Return the semantic visitor corresponding to the given model element.
            // If no visitor can be created for this model element then null is 
            // returned.
            SemanticVisitor visitor;
            if (element is StateMachine)
            {
                visitor = new StateMachineExecution();
            }
            else if (element is Pseudostate pseudostate)
            {
                visitor = pseudostate.kind switch
                {
                    PseudoStateKind.initial => new InitialPseudostateActivation(),
                    PseudoStateKind.entryPoint => new EntryPointPseudostateActivation(),
                    PseudoStateKind.exitPoint => new ExitPointPseudostateActivation(),
                    PseudoStateKind.choice => new ChoicePseudostateActivation(),
                    PseudoStateKind.fork => new ForkPseudostateActivation(),
                    PseudoStateKind.join => new JoinPseudostateActivation(),
                    PseudoStateKind.terminate => new TerminatePseudostateActivation(),
                    PseudoStateKind.deepHistory => new DeepHistoryPseudostateActivation(),
                    PseudoStateKind.shallowHistory => new ShallowHistoryPseudostateActivation(),
                    PseudoStateKind.junction => new JunctionPseudostateActivation(),
                    _ => null!,
                };
            }
            else if (element is State)
            {
                if (element is FinalState)
                {
                    visitor = new FinalStateActivation();
                }
                else
                {
                    visitor = new StateActivation();
                }
            }
            else if (element is Transition transition)
            {
                visitor = transition.kind switch
                {
                    TransitionKind.external => new ExternalTransitionActivation(),
                    TransitionKind.internal_ => new InternalTransitionActivation(),
                    TransitionKind.local => new LocalTransitionActivation(),
                    _ => null!,
                };
            }
            else if (element is Region)
            {
                visitor = new RegionActivation();
            }
            else if (element is OpaqueExpression)
            {
                visitor = new SM_OpaqueExpressionEvaluation();
            }
            else if (element is ReadSelfAction)
            {
                visitor = new SM_ReadSelfActionActivation();
            }
            else
            {
                visitor = base.InstantiateVisitor(element);
            }
            return visitor;
        }
    } // SM_ExecutionFactory
}
