using System;

namespace pssm.semantics.statemachines
{
    public class StateConfiguration
    {
        // The activation (i.e. the semantic visitor) for which the StateConfiguration
        // represents an element of the state-machine configuration.
        protected VertexActivation? vertexActivation = null;

        // The parent state configuration of this node
        protected StateConfiguration? parent = null;

        // The children state configuration of this state-machine configuration
        protected List<StateConfiguration> children = new();

        // The level at which the the state configuration is located in the hierarchy.
        private int level = 0;

        // A reference to the complete state-machine configuration
        private StateMachineConfiguration? completeConfiguration = null;

        public StateConfiguration(StateMachineConfiguration configuration)
        {
            completeConfiguration = configuration;
        }

        public StateConfiguration(VertexActivation activation)
        {
            vertexActivation = activation;
        }

        public bool RemoveChild(VertexActivation activation)
        {
            // Remove a vertex activation from the state machine configuration tree.
            return Remove(activation, GetContext(activation));
        }

        public bool addChild(VertexActivation activation)
        {
            // Add a vertex activation in the state machine configuration tree.
            return Add(activation, GetContext(activation));
        }

        public bool IsConfigurationFor(VertexActivation activation)
        {
            throw new NotImplementedException();
        }

        public bool IsConfigurationFor(VertexActivation activation, List<VertexActivation> context)
        {
            throw new NotImplementedException();
        }

        private List<VertexActivation> GetContext(VertexActivation activation)
        {
            throw new NotImplementedException();
        }

        public bool Remove(VertexActivation activation, List<VertexActivation> context)
        {
            throw new NotImplementedException();
        }

        public bool Add(VertexActivation activation, List<VertexActivation> context)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

    } // StateConfiguration
}
