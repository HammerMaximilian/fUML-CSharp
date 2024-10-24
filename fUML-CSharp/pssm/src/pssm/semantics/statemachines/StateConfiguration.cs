using System;

namespace pssm.semantics.statemachines
{
    public class StateConfiguration
    {
        // The activation (i.e. the semantic visitor) for which the StateConfiguration
        // represents an element of the state-machine configuration.
        public VertexActivation? vertexActivation = null;

        // The parent state configuration of this node
        public StateConfiguration? parent = null;

        // The children state configuration of this state-machine configuration
        public List<StateConfiguration> children = new();

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
            return IsConfigurationFor(activation, GetContext(activation));
        }

        public bool IsConfigurationFor(VertexActivation activation, List<VertexActivation> context)
        {
            // A vertex activation belongs to the state machine configuration if it is referenced
            // in the state configuration tree. True is returned if a state configuration
            // in that tree references the vertex activation, false otherwise. In order to find the
            // state configuration referencing the activation, a directed search is performed  in the
            // state configuration tree. This directed search relies on the path (ascending hierarchy
            // of vertex activation) provided by the context.
            bool isConfiguration = false;
            if (context.Any())
            {
                int i = 0;
                StateConfiguration? selectedStateConfiguration = null;
                VertexActivation? current = context.ElementAt(context.Count - 1);
                while (selectedStateConfiguration == null && i < children.Count)
                {
                    if (children.ElementAt(i).vertexActivation == current)
                    {
                        selectedStateConfiguration = children.ElementAt(i);
                    }
                    i++;
                }
                if (selectedStateConfiguration != null)
                {
                    isConfiguration = selectedStateConfiguration.IsConfigurationFor(activation, context.GetRange(0, (context.Count - 1) - 1));
                }
            }
            else
            {
                int i = 0;
                while (!isConfiguration && i < children.Count)
                {
                    if (children.ElementAt(i).vertexActivation == activation)
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
            List<VertexActivation> context = new();
            List<VertexActivation> hierarchy = activation.GetAscendingHierarchy();
            int i = hierarchy.Count;
            int j = 0;
            bool found = false;
            while (!found && i >= 1)
            {
                while (!found && j < children.Count)
                {
                    if (children.ElementAt(j).vertexActivation == hierarchy.ElementAt(i - 1))
                    {
                        found = true;
                        // The most nested element in the hierarchy is always discarded.
                        // This nested element is the activation
                        context = hierarchy.GetRange(1, i - 1);
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
            bool removed = false;
            if (context.Any())
            {
                VertexActivation current = context.ElementAt(context.Count - 1);
                StateConfiguration? selectedStateConfiguration = null;
                int i = 0;
                while (i < children.Count && selectedStateConfiguration == null)
                {
                    if (children.ElementAt(i).vertexActivation == current)
                    {
                        selectedStateConfiguration = children.ElementAt(i);
                    }
                    i++;
                }
                if (selectedStateConfiguration != null)
                {
                    removed = selectedStateConfiguration.Remove(activation, context.GetRange(0, (context.Count - 1) - 1));
                }
            }
            else
            {
                int i = 0;
                while (i < children.Count && !removed)
                {
                    if (children.ElementAt(i).vertexActivation == activation)
                    {
                        children.RemoveAt(i);
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
            bool added = false;
            if (context.Any())
            {
                VertexActivation current = context.ElementAt(context.Count - 1);
                StateConfiguration? selectedStateConfiguration = null;
                int i = 0;
                while (i < children.Count && selectedStateConfiguration == null)
                {
                    if (children.ElementAt(i).vertexActivation == current)
                    {
                        selectedStateConfiguration = children.ElementAt(i);
                    }
                    i++;
                }
                if (selectedStateConfiguration != null)
                {
                    added = selectedStateConfiguration.Add(activation, context.GetRange(0, (context.Count - 1) - 1));
                }
            }
            else
            {
                int i = 0;
                bool alreadyAdded = false;
                while (i < children.Count && !alreadyAdded)
                {
                    if (children.ElementAt(i).vertexActivation == activation)
                    {
                        alreadyAdded = true;
                    }
                    i++;
                }
                if (!alreadyAdded)
                {
                    StateConfiguration newConfiguration = new(activation)
                    {
                        level = level + 1,
                        completeConfiguration = completeConfiguration
                    };
                    children.Add(newConfiguration);
                    added = true;
                }
            }
            return added;
        }

        public override string ToString()
        {
            int i = 0;
            // Return a string representing configuration taking this node as a the root.
            // The string that is obtained is possibly a partial representation of the
            // state-machine configuration.
            string result = vertexActivation == null ? "ROOT" : vertexActivation.node!.name;
            result += "(L" + level + ")";
            if (children.Any())
            {
                result += "[";
                while (i < children.Count)
                {
                    result += children.ElementAt(i).ToString();
                    if (i < children.Count - 1)
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
