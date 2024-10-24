using fuml.semantics.commonbehavior;
using fuml.semantics.loci;
using fuml.semantics.structuredclassifiers;
using pssm.semantics.commonbehavior;
using System;
using uml.commonbehavior;
using uml.commonstructure;

namespace pssm.semantics.statemachines
{
    public abstract class StateMachineSemanticVisitor : SemanticVisitor
    {
        // Each semantic visitor for a state-machine know its parent visitor
        public SemanticVisitor? parent = null;

        // Each semantic visitor traverse a particular node of a state-machine
        public NamedElement? node = null;

        public List<SemanticVisitor> GetContextChain()
        {
            // Return the hierarchy of visitors that need to be traversed to access
            // the visitor that called context chain. The caller is part of the returned
            // context chain.
            List<SemanticVisitor> contextChain = new();
            if (this is not ExitPointPseudostateActivation && this is not EntryPointPseudostateActivation)
            {
                contextChain.Add(this);
            }
            if (parent is not null)
            {
                if (parent is StateMachineExecution)
                {
                    contextChain.Add(parent);
                }
                else
                {
                    contextChain.AddRange(((StateMachineSemanticVisitor)parent).GetContextChain());
                }
            }
            return contextChain;
        }

        public Execution GetStateMachineExecution()
        {
            // Return the state-machine execution from which the caller of this operation
            // belongs
            if (parent is not null && parent is StateMachineExecution)
            {
                return (Execution)parent;
            }
            else
            {
                return ((StateMachineSemanticVisitor)parent!).GetStateMachineExecution();
            }
        }

        public Locus GetExecutionLocus()
        {
            return GetStateMachineExecution().locus!;
        }

        public Object_ GetExecutionContext()
        {
            return GetStateMachineExecution().context!;
        }

        public virtual bool IsVisitorFor(NamedElement node)
        {
            // A visitor is the interpreter for a model if the node given as parameter is
            // the
            // this model element.
            return this.node == node;
        }

        public virtual void Activate()
        {
            // This operation is intended to be overridden by sub-classes. For required
            // sub-classes
            // (e.g., RegionActivation, StateActivation) it will initiate the instantiation
            // phase of
            // child semantic visitors. By default activate does nothing.
            return;
        }

        public virtual void ActivateTransitions()
        {
            // ActivateTransition is intended to be overridden by sub-classes. It will
            // capture the instantiation
            // of transitions visitors as well as the linking between these visitors and the
            // required vertices
            // activation. By default activate does nothing.
            return;
        }

        public Execution GetExecutionFor(Behavior behavior, EventOccurrence eventOccurrence)
        {
            // Create an Execution for the specified behavior. In addition to the creation
            // of this
            // Execution, if the behavior execution is triggered by the dispatching of an
            // event (i.e.
            // a CallEvent or a SignalEvent) then an EventTriggeredExecution is provided.
            // This
            // execution wraps the original execution and ensures passing of event data to
            // the
            // wrapped execution.
            Execution? execution = null;
            if (behavior != null)
            {
                Execution originalExecution = GetExecutionLocus().factory!.CreateExecution(behavior, GetExecutionContext());
                if (eventOccurrence != null)
                {
                    EventTriggeredExecution containerExecution = new()
                    {
                        triggeringEventOccurrence = eventOccurrence,
                        wrappedExecution = originalExecution,
                        context = originalExecution.context
                    };
                    execution = containerExecution;
                }
                else
                {
                    execution = originalExecution;
                }
            }
            return execution!;
        }

        public override string ToString()
        {
            return node!.name;
        }
    } // StateMachineSemanticVisitor
}
