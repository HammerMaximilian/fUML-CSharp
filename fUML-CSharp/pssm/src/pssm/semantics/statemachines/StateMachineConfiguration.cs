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
            throw new NotImplementedException();
        }

        public bool Unregister(StateActivation stateActivation)
        {
            throw new NotImplementedException();
        }

        public bool IsActive(VertexActivation activation)
        {
            // A vertex that is currently active is part of the state-machine configuration
            return rootConfiguration!.IsConfigurationFor(activation);
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

    } // StateMachineConfiguration
}
