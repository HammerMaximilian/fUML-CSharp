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

        public bool AddChild(VertexActivation activation)
        {
            // Add a vertex activation in the state machine configuration tree.
            return Add(activation, GetContext(activation));
        }

        public bool IsConfigurationFor(VertexActivation activation)
        {
            // Check if the given vertex activation belongs to the 
            // state machine configuration.
            return this.isConfigurationFor(activation, this.getContext(activation));
        }

        public bool IsConfigurationFor(VertexActivation activation, List<VertexActivation> context)
        {
            // A vertex activation belongs to the state machine configuration if it is referenced
            // in the state configuration tree. True is returned if a state configuration
            // in that tree references the vertex activation, false otherwise. In order to find the
            // state configuration referencing the activation, a directed search is performed  in the
            // state configuration tree. This directed search relies on the path (ascending hierarchy
            // of vertex activation) provided by the context.
            boolean isConfiguration = false;
            if (!context.isEmpty())
            {
                int i = 0;
                IStateConfiguration selectedStateConfiguration = null;
                IVertexActivation current = context.get(context.size() - 1);
                while (selectedStateConfiguration == null && i < this.children.size())
                {
                    if (this.children.get(i).getVertexActivation() == current)
                    {
                        selectedStateConfiguration = this.children.get(i);
                    }
                    i++;
                }
                if (selectedStateConfiguration != null)
                {
                    isConfiguration = selectedStateConfiguration.isConfigurationFor(activation, context.subList(0, context.size() - 1));
                }
            }
            else
            {
                int i = 0;
                while (!isConfiguration && i < this.children.size())
                {
                    if (this.children.get(i).getVertexActivation() == activation)
                    {
                        isConfiguration = true;
                    }
                    i++;
                }
            }
            return isConfiguration;
        }

        private List<VertexActivation> GetContext(VertexActivation activation)
        {
            // Provide the path from this state configuration to the target state configuration.
            // The path is presented as an ascending hierarchy (nested -> top) of vertex activations.
            // This path is used to perform a directed search through the representation of 
            // state configuration tree.
            List<IVertexActivation> context = new ArrayList<IVertexActivation>();
            List<IVertexActivation> hierarchy = activation.getAscendingHierarchy();
            int i = hierarchy.size();
            int j = 0;
            boolean found = false;
            while (!found && i >= 1)
            {
                while (!found && j < this.children.size())
                {
                    if (this.children.get(j).getVertexActivation() == hierarchy.get(i - 1))
                    {
                        found = true;
                        // The most nested element in the hierarchy is always discarded.
                        // This nested element is the activation
                        context = hierarchy.subList(1, i);
                    }
                    j++;
                }
                j = 0;
                i--;
            }
            return context;
        }

        public bool Remove(VertexActivation activation, List<VertexActivation> context)
        {
            // Follows the path provided by the context (ascending hierarchy of vertex activations)
            // until the state configuration being the parent of the one referencing the activation
            // is found. When found, the chil state configuration referencing the activation gets
            // removed from the state configuration tree.
            boolean removed = false;
            if (!context.isEmpty())
            {
                IVertexActivation current = context.get(context.size() - 1);
                IStateConfiguration selectedStateConfiguration = null;
                int i = 0;
                while (i < this.children.size() && selectedStateConfiguration == null)
                {
                    if (this.children.get(i).getVertexActivation() == current)
                    {
                        selectedStateConfiguration = this.children.get(i);
                    }
                    i++;
                }
                if (selectedStateConfiguration != null)
                {
                    removed = selectedStateConfiguration.remove(activation, context.subList(0, context.size() - 1));
                }
            }
            else
            {
                int i = 0;
                while (i < this.children.size() && !removed)
                {
                    if (this.children.get(i).getVertexActivation() == activation)
                    {
                        this.children.remove(i);
                        removed = true;
                    }
                    i++;
                }
            }
            return removed;
        }

        public bool Add(VertexActivation activation, List<VertexActivation> context)
        {
            // Follows the path provided by the context (ascending hierarchy of vertex activations)
            // until the state configuration referencing the parent vertex activation of the activation
            // is found. When found, a new state configuration is added as a children of the current
            // state configuration. This new state configuration references the activation.
            boolean added = false;
            if (!context.isEmpty())
            {
                IVertexActivation current = context.get(context.size() - 1);
                IStateConfiguration selectedStateConfiguration = null;
                int i = 0;
                while (i < this.children.size() && selectedStateConfiguration == null)
                {
                    if (this.children.get(i).getVertexActivation() == current)
                    {
                        selectedStateConfiguration = this.children.get(i);
                    }
                    i++;
                }
                if (selectedStateConfiguration != null)
                {
                    added = selectedStateConfiguration.add(activation, context.subList(0, context.size() - 1));
                }
            }
            else
            {
                int i = 0;
                boolean alreadyAdded = false;
                while (i < this.children.size() && !alreadyAdded)
                {
                    if (this.children.get(i).getVertexActivation() == activation)
                    {
                        alreadyAdded = true;
                    }
                    i++;
                }
                if (!alreadyAdded)
                {
                    StateConfiguration newConfiguration = new StateConfiguration(activation);
                    newConfiguration.level = this.level + 1;
                    newConfiguration.completeConfiguration = this.completeConfiguration;
                    added = this.children.add(newConfiguration);
                }
            }
            return added;
        }

        public override string ToString()
        {
            // Return a string representing configuration taking this node as a the root.
            // The string that is obtained is possibly a partial representation of the
            // state-machine configuration.
            String result = "";
            int i = 0;
            result = this.vertexActivation == null ? "ROOT" : this.vertexActivation.getNode().getName();
            result += "(L" + this.level + ")";
            if (!this.children.isEmpty())
            {
                result += "[";
                while (i < this.children.size())
                {
                    result += this.children.get(i).toString();
                    if (i < this.children.size() - 1)
                    {
                        result += ", ";
                    }
                    i++;
                }
                result += "]";
            }
            return result;
        }

    } // StateConfiguration
}
