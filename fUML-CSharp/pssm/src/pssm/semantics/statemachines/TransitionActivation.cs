﻿using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;
using System;
using uml.commonbehavior;
using uml.commonstructure;
using uml.statemachines;
using uml.values;

namespace pssm.semantics.statemachines
{
    public abstract class TransitionActivation : StateMachineSemanticVisitor
    {
        // The source activation of this transition activation
        public VertexActivation? vertexSourceActivation = null;

        // The target activation of this transition activation
        public VertexActivation? vertexTargetActivation = null;

        // The runtime status (NONE, REACHED, TRAVERSED) of the transition
        protected TransitionMetadata status = TransitionMetadata.NONE;

        // Least common ancestor of the source and the target. This is materialized
        // by the region activation that is the common ancestor of the source and the
        // target.
        private RegionActivation? leastCommonAncestor = null;

        // The static status (NONE, REACHED, TRAVERSED) of the transition
        public TransitionMetadata analyticalStatus = TransitionMetadata.NONE;

        // The last event occurrence used during static analysis.
        private EventOccurrence? lastTriggeringEventOccurrence = null;

        // The last verdict when the execution was propagated over this transition.
        private bool lastPropagation = false;

        public bool IsReached(bool staticCheck)
        {
            /// Convenience operation which returns true if the status of this transition
            // is REACHED; false otherwise.
            boolean reached = true;
            if (staticCheck)
            {
                reached = this.analyticalStatus.equals(TransitionMetadata.REACHED);
            }
            else
            {
                reached = this.status.equals(TransitionMetadata.REACHED);
            }
            return reached;
        }

        public bool IsTraversed(bool staticCheck)
        {
            // Convenience operation which returns true if the status of this transition
            // is TRAVERSED; false otherwise.
            boolean traversed = true;
            if (staticCheck)
            {
                traversed = this.analyticalStatus.equals(TransitionMetadata.TRAVERSED);
            }
            else
            {
                traversed = this.status.equals(TransitionMetadata.TRAVERSED);
            }
            return traversed;
        }

        public override bool IsVisitorFor(NamedElement node)
        {
            // Determine if this visitor is a semantic visitor for the node
            // provided as a parameter.This case is verified if the node is
            // the same as the transition attached to the semantic visitor or
            // if the node matches a transition that is redefined (directly or
            // indirectly) by the transition attached to this semantic visitor.
            boolean isVisitor = super.isVisitorFor(node);
            if (!isVisitor)
            {
                Transition transition = ((Transition)this.node).getRedefinedTransition();
                while (!isVisitor && transition != null)
                {
                    if (transition == node)
                    {
                        isVisitor = true;
                    }
                    else
                    {
                        transition = transition.getRedefinedTransition();
                    }
                }
            }
            return isVisitor;
        }

        public bool IsTriggered()
        {
            // Check if the transition is triggered. A transition is triggered
            // if it declares triggers or if it redefines a transition that itself
            // declares triggers. This check applies recursively on the redefinition
            // hierarchy.
            Transition transition = (Transition)this.node;
            boolean isTriggered = false;
            if (!transition.getTriggers().isEmpty())
            {
                isTriggered = true;
            }
            while (!isTriggered && transition.getRedefinedTransition() != null)
            {
                transition = transition.getRedefinedTransition();
                if (!transition.getTriggers().isEmpty())
                {
                    isTriggered = true;
                }
            }
            return isTriggered;
        }

        public bool IsGuarded()
        {
            // Check if the transition is guarded. A transition is guarded if it declares
            // a guard or if a redefine transition that itself declares a guar. This check
            // applies recursively on the redefinition hierarchy
            Transition transition = (Transition)this.node;
            boolean isGuarded = false;
            if (transition.getGuard() != null)
            {
                isGuarded = true;
            }
            while (!isGuarded && transition.getRedefinedTransition() != null)
            {
                transition = transition.getRedefinedTransition();
                if (transition.getGuard() != null)
                {
                    isGuarded = true;
                }
            }
            return isGuarded;
        }

        public bool EvaluateGuard(EventOccurrence eventOccurrence)
        {
            // Evaluate the guard specification thanks to an evaluation.
            // The evaluation does not presume of the type of the guard specification.
            boolean result = true;
            Transition transition = (Transition)this.node;
            Constraint guard = transition.getGuard();
            while (guard == null && transition.getRedefinedTransition() != null)
            {
                transition = transition.getRedefinedTransition();
                guard = transition.getGuard();
            }
            if (guard != null)
            {
                ValueSpecification specification = guard.getSpecification();
                if (specification != null)
                {
                    IEvaluation evaluation = this.getExecutionLocus().getFactory().createEvaluation(specification);
                    if (specification instanceof OpaqueExpression) {
                        ((ISM_OpaqueExpressionEvaluation)evaluation).setContext(this.getExecutionContext());
                        ((ISM_OpaqueExpressionEvaluation)evaluation).initialize(eventOccurrence);
                    }
                    if (evaluation != null)
                    {
                        IBooleanValue evaluationResult = (IBooleanValue)evaluation.evaluate();
                        result = evaluationResult.getValue();
                    }
                }

            }
            return result;
        }

        public bool HasTrigger(EventOccurrence eventOccurrence)
        {
            // Return true if the event occurrence matches a trigger of this transition.
            // false otherwise. If the transition declares no trigger but redefines another
            // transition then if that transition has a trigger that matches the event
            // occurrence
            // the redefining transition is considered has being able to react to the event
            // occurrence.
            // The rule applies recursively.
            Transition transition = (Transition)this.node;
            boolean match = eventOccurrence.matchAny(transition.getTriggers());
            while (!match && transition.getRedefinedTransition() != null)
            {
                transition = transition.getRedefinedTransition();
                match = eventOccurrence.matchAny(transition.getTriggers());
            }
            return match;
        }

        public bool CanFireOn(EventOccurrence eventOccurrence)
        {
            // A transition is can fire when:
            // 1. It has a trigger that matches the dispatched event occurrence.
            // 2. Its guard evaluates to true.
            // 3. A valid path can found to the next state machine configuration.
            // Note: If the dispatched event is a completion event, the transition matches
            // this latter
            // if it has no trigger and the transition leaves the state from which the
            // completion event
            // was generated.
            boolean reactive = this.hasTrigger(eventOccurrence) && this.evaluateGuard(eventOccurrence)
                    && this.canPropagateExecution(eventOccurrence);
            if (reactive && eventOccurrence instanceof ICompletionEventOccurrence) {
                reactive = this.getSourceActivation() == ((ICompletionEventOccurrence)eventOccurrence).getScope();
            }
            return reactive;
        }

        public bool CanPropagateExecution(EventOccurrence eventOccurrence)
        {
            // Evaluate the possibility to propagate the static analysis through this
            // transition activation.
            // Two situations can occur:
            // 1. The transition has already been "traversed" with using the same event
            // occurrence. This means
            // we already know the execution can be propagated through the transiton
            // activation. Hence true
            // is returned and the propagation stops.
            // 2. The transition has not already been "traversed" using this event
            // occurrence. The consequence
            // is that the analysis is propagated through the target vertex activation.
            boolean propagate = true;
            if (this.lastTriggeringEventOccurrence != eventOccurrence)
            {
                propagate = this.vertexTargetActivation.canPropagateExecution(this, eventOccurrence,
                        this.getLeastCommonAncestor());
                this.lastTriggeringEventOccurrence = eventOccurrence;
                this.lastPropagation = propagate;
            }
            else
            {
                propagate = this.lastPropagation;
            }
            return propagate;
        }

        public void TryExecuteEffect(EventOccurrence eventOccurrence)
        {
            // Execute the effect owned by the transition (if any). If there
            // is no effect but the transition redefines another transition, then
            // the effect of this transition is executed instead. This rule
            // applies recursively.
            Transition transition = (Transition)this.getNode();
            Behavior effect = transition.getEffect();
            while (effect == null && transition.getRedefinedTransition() != null)
            {
                transition = transition.getRedefinedTransition();
                effect = transition.getEffect();
            }
            if (effect != null)
            {
                IExecution execution = this.getExecutionFor(transition.getEffect(), eventOccurrence);
                if (execution != null)
                {
                    execution.execute();
                }
            }
        }

        public void Fire(EventOccurrence eventOccurrence)
        {
            // The fire sequence is broken into the following set of actions
            // 1 - Exit the source (depends on the kind of transition that is currently
            // used)
            // 2 - Execute the effect (if one exists for that transition)
            // 3 - Enter the target (depends on the kind of transition that is currently
            // used)
            this.exitSource(eventOccurrence);
            this.tryExecuteEffect(eventOccurrence);
            this.setStatus(TransitionMetadata.TRAVERSED);

            this.enterTarget(eventOccurrence);
        }

        public RegionActivation GetLeastCommonAncestor()
        {
            // Return the common ancestor of the source and the target. This common ancestor
            // is
            // a region activation
            if (this.vertexSourceActivation.getParentVertexActivation() != this.vertexTargetActivation
                    .getParentVertexActivation())
            {
                if (this.leastCommonAncestor == null)
                {
                    this.leastCommonAncestor = this.vertexSourceActivation
                            .getLeastCommonAncestor(this.vertexTargetActivation, ((Transition)this.getNode()).getKind());
                }
            }
            return this.leastCommonAncestor;
        }

        public override string ToString()
        {
            String representation = "[" + this.getSourceActivation() + "] -> [" + this.getTargetActivation() + "] (";
            if (this.isReached(false))
            {
                representation += "REACHED";
            }
            else if (this.isTraversed(false))
            {
                representation += "TRAVERSED";
            }
            else
            {
                representation += "NONE";
            }
            return representation + ")";
        }
    } // TransitionActivation
}
