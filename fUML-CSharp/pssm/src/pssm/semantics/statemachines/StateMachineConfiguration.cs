using System;

namespace pssm.semantics.statemachines
{
    public class StateMachineConfiguration
    {
        // The state-machine that is executed and for which this object
        // represents the hierarchy of active states.
        protected StateMachineExecution? execution = null;

        // The root node of the state machine configuration. It represents
        // the top level active state.
        public StateConfiguration? rootConfiguration = null;

        public StateMachineConfiguration(StateMachineExecution execution)
        {
            rootConfiguration = new StateConfiguration(this);
            this.execution = execution;
        }

        public bool Register(StateActivation stateActivation)
        {
            // Register the given state activation in the state-machine configuration.
            // This occurs when the state activation is entered.
            bool added = rootConfiguration!.AddChild(stateActivation);
            //logger.info(this.toString());
            return added;
        }

        public bool Unregister(StateActivation stateActivation)
        {
            // Unregister the given state activation from the state-machine configuration
            // This occurs when the state activation is exited. When the removal process
            // is successful the last action is to release possibly deferred events related
            // to that state activation.
            bool removed = rootConfiguration!.RemoveChild(stateActivation);
            //logger.info(this.toString());
            if (removed)
            {
                stateActivation.ReleaseDeferredEvents();
            }
            return removed;
        }

        public bool IsActive(VertexActivation activation)
        {
            // A vertex that is currently active is part of the state-machine configuration
            return rootConfiguration!.IsConfigurationFor(activation);
        }

        public override string ToString()
        {
            // Return a string representing the current state-machine configuration.
            // This representation takes the following form:
            // [ROOT(L0)[S1(L1)[S1.X(L2), S.2.X(L2)]]]
            return "[" + rootConfiguration!.ToString() + "]";
        }

    } // StateMachineConfiguration
}
