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
                switch (pseudostate.kind)
                {
                    case PseudoStateKind.initial: visitor = new InitialPseudostateActivation(); break;
                    case PseudoStateKind.entryPoint: visitor = new EntryPointPseudostateActivation(); break;
                    case PseudoStateKind.exitPoint: visitor = new ExitPointPseudostateActivation(); break;
                    case PseudoStateKind.choice: visitor = new ChoicePseudostateActivation(); break;
                    case PseudoStateKind.fork: visitor = new ForkPseudostateActivation(); break;
                    case PseudoStateKind.join: visitor = new JoinPseudostateActivation(); break;
                    case PseudoStateKind.terminate: visitor = new TerminatePseudostateActivation(); break;
                    case PseudoStateKind.deepHistory: visitor = new DeepHistoryPseudostateActivation(); break;
                    case PseudoStateKind.shallowHistory: visitor = new ShallowHistoryPseudostateActivation(); break;
                    case PseudoStateKind.junction: visitor = new JunctionPseudostateActivation(); break;
                    default: visitor = null!; break;
                }
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
                switch (transition.kind)
                {
                    case TransitionKind.external: visitor = new ExternalTransitionActivation(); break;
                    case TransitionKind.internal_: visitor = new InternalTransitionActivation(); break;
                    case TransitionKind.local: visitor = new LocalTransitionActivation(); break;
                    default: visitor = null!; break;
                }
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
