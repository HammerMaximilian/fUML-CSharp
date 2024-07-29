using fuml.semantics.commonbehavior;
using fuml.semantics.loci;
using fuml.semantics.structuredclassifiers;
using System;
using uml.commonbehavior;
using uml.commonstructure;

namespace pssm.semantics.statemachines
{
    public abstract class StateMachineSemanticVisitor : SemanticVisitor
    {
        // Each semantic visitor for a state-machine know its parent visitor
        protected SemanticVisitor? parent = null;

        // Each semantic visitor traverse a particular node of a state-machine
        protected NamedElement? node = null;

        public List<SemanticVisitor> GetContextChain()
        {
            throw new NotImplementedException();
        }

        public Execution GetStateMachineExecution()
        {
            throw new NotImplementedException();
        }

        public Locus getExecutionLocus()
        {
            return GetStateMachineExecution().locus!;
        }

        public Object_ getExecutionContext()
        {
            return GetStateMachineExecution().context!;
        }

        public virtual bool IsVisitorFor(NamedElement node)
        {
            throw new NotImplementedException();
        }

        public virtual void Activate()
        {
        }

        public virtual void ActivateTransitions()
        {
        }

        public Execution GetExecutionFor(Behavior behavior, EventOccurrence eventOccurrence)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return node!.name;
        }
    } // StateMachineSemanticVisitor
}
