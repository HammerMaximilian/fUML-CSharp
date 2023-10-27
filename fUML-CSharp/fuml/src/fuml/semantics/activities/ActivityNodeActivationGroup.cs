using fuml.semantics.actions;
using fuml.syntax.actions;
using fuml.syntax.activities;

namespace fuml.semantics.activities
{
    public class ActivityNodeActivationGroup : FumlObject
    {
        public List<ActivityEdgeInstance> edgeInstances = new();
        public List<ActivityNodeActivation> nodeActivations = new();
        public ActivityExecution? activityExecution = null;
        public StructuredActivityNodeActivation? containingNodeActivation = null;
        public List<ActivityNodeActivation> suspendedActivations = new();

        public void Run(List<ActivityNodeActivation> activations)
        {
            // Run the given node activations. 
            // Then concurrently send offers to all input activity parameter node activations (if any). 
            // Finally, concurrently send offers to all activations of other kinds of nodes that have 
            // no incoming edges with the given set (if any).

            foreach (ActivityNodeActivation activation in activations)
            {
                activation.Run();
            }

            Debug.println("[run] Checking for enabled nodes...");

            List<ActivityNodeActivation> enabledParameterNodeActivations = new();
            List<ActivityNodeActivation> enabledOtherActivations = new();

            foreach (ActivityNodeActivation activation in activations)
            {
                Debug.println("[run] Checking node " + activation?.node?.name + "...");

                if (!(activation is PinActivation |
                        activation is ExpansionNodeActivation))
                {

                    bool isEnabled = CheckIncomingEdges(activation!.incomingEdges, activations);

                    // For an action activation, also consider incoming edges to
                    // input pins
                    if (isEnabled & activation is ActionActivation)
                    {
                        List<InputPin> inputPins = ((syntax.actions.Action)activation?.node!).input;
                        int j = 1;
                        while (j <= inputPins.Count & isEnabled)
                        {
                            InputPin inputPin = inputPins.ElementAt(j - 1);
                            List<ActivityEdgeInstance> inputEdges = ((ActionActivation)activation)
                                    .GetPinActivation(inputPin).incomingEdges;
                            isEnabled = CheckIncomingEdges(inputEdges,
                                    activations);
                            j++;
                        }
                    }

                    if (isEnabled)
                    {
                        Debug.println("[run] Node " + activation?.node?.name + " is enabled.");
                        if (activation is ActivityParameterNodeActivation)
                        {
                            enabledParameterNodeActivations.Add(activation!);
                        }
                        else
                        {
                            enabledOtherActivations.Add(activation!);
                        }
                    }
                }
            }

            // *** Send offers to all enabled activity parameter nodes concurrently. ***
            foreach (ActivityNodeActivation activation in enabledParameterNodeActivations)
            {
                Debug.println("[run] Sending offer to activity parameter node " + activation?.node?.name + ".");
                activation?.ReceiveOffer();
            }

            // *** Send offers to all other enabled nodes concurrently. ***
            foreach (ActivityNodeActivation activation in enabledOtherActivations)
            {
                Debug.println("[run] Sending offer to node " + activation?.node?.name + ".");
                activation?.ReceiveOffer();
            }
        } // run

        public bool CheckIncomingEdges(
                List<ActivityEdgeInstance> incomingEdges,
                List<ActivityNodeActivation> activations)
        {
            // Check if any incoming edges have a source in a given set of
            // activations.

            int j = 1;
            bool notFound = true;

            while (j <= incomingEdges.Count & notFound)
            {
                int k = 1;
                while (k <= activations.Count & notFound)
                {
                    if (activations.ElementAt(k - 1).IsSourceFor(
                            incomingEdges.ElementAt(j - 1)))
                    {
                        notFound = false;
                    }
                    k++;
                }
                j++;
            }

            return notFound;
        } // checkIncomingEdges

        public void RunNodes(
                List<ActivityNode> nodes)
        {
            // Run the node activations associated with the given nodes in this
            // activation group.

            List<ActivityNodeActivation> nodeActivations = new();

            foreach (ActivityNode node in nodes)
            {
                ActivityNodeActivation nodeActivation = GetNodeActivation(node);
                if (nodeActivation is not null)
                {
                    nodeActivations.Add(nodeActivation);
                }
            }

            Run(nodeActivations);
        } // runNodes

        public void Activate(
                List<ActivityNode> nodes,
                List<ActivityEdge> edges)
        {
            // Activate and run the given set of nodes with the given set of edges,
            // within this activation group.

            CreateNodeActivations(nodes);
            CreateEdgeInstances(edges);
            Run(nodeActivations);

            // Debug.println("[activate] Exiting.");
        } // activate

        public void TerminateAll()
        {
            // Terminate all node activations in the group.

            Debug.println("[terminateAll] Terminating activation group for "
                    + (activityExecution is not null ? "activity "
                            + activityExecution.getTypes().ElementAt(0).name
                            : containingNodeActivation is not null ? "node "
                                    + containingNodeActivation?.node?.name
                                    : "expansion region") + ".");

            List<ActivityNodeActivation> nodeActivations = this.nodeActivations;
            foreach (ActivityNodeActivation nodeActivation in nodeActivations)
            {
                nodeActivation.Terminate();
            }

            suspendedActivations.Clear();
        } // terminateAll

        public void CreateNodeActivations(
                List<ActivityNode> nodes)
        {
            // Add activity node activations for the given set of nodes to this
            // group and create edge instances between them.

            foreach (ActivityNode node in nodes)
            {
                Debug.println("[createNodeActivations] Creating a node activation for "
                                + node.name + "...");
                CreateNodeActivation(node);
            }

        } // createNodeActivations

        public ActivityNodeActivation CreateNodeActivation(
                ActivityNode node)
        {
            // Create an activity node activation for a given activity node in this
            // activity node activation group.

            ActivityNodeActivation? activation = (ActivityNodeActivation)(GetActivityExecution()?.locus?.factory?.instantiateVisitor(node))!;
            activation.Initialize(node, this);

            nodeActivations.Add(activation);

            activation.CreateNodeActivations();

            return activation;
        } // createNodeActivation

        public ActivityNodeActivation GetNodeActivation(
                ActivityNode node)
        {
            // Return the node activation (if any) in this group,
            // or any nested group, corresponding to the given activity node.
            // If this is a group for a structured activity node activation,
            // also include the pin activations for that node activation.

            ActivityNodeActivation? activation = null;

            if (containingNodeActivation is not null && node is Pin pin) {
                activation = containingNodeActivation
                        .GetPinActivation(pin);
            }

            if (activation is null)
            {
                int i = 1;
                while (activation is null & i <= nodeActivations.Count)
                {
                    activation = nodeActivations.ElementAt(i - 1).GetNodeActivation(node);
                    i++;
                }
            }

            return activation!;
        } // getNodeActivation

        public void CreateEdgeInstances(
                List<ActivityEdge> edges)
        {
            // Create instance edges for the given activity edges, as well as for
            // edge instances within any nodes activated in this group.

            foreach (ActivityEdge edge in edges)
            {
                Debug.println("[createEdgeInstances] Creating an edge instance from "
                        + edge?.source?.name + " to " + edge?.target?.name + ".");

                ActivityEdgeInstance edgeInstance = new();
                edgeInstance.edge = edge;
                edgeInstance.group = this;

                edgeInstances.Add(edgeInstance);
                GetNodeActivation(edge?.source!).AddOutgoingEdge(edgeInstance);
                GetNodeActivation(edge?.target!).AddIncomingEdge(edgeInstance);
            }

            List<ActivityNodeActivation> nodeActivations = this.nodeActivations;
            foreach (ActivityNodeActivation nodeActivation in nodeActivations)
            {
                nodeActivation.CreateEdgeInstances();
            }
        } // createEdgeInstances

        public ActivityExecution GetActivityExecution()
        {
            // Return the activity execution to which this group belongs, directly
            // or indirectly.

            ActivityExecution activityExecution = this.activityExecution!;
            if (activityExecution is null)
            {
                activityExecution = containingNodeActivation?.group?.GetActivityExecution()!;
            }

            return activityExecution;
        } // getActivityExecution

        public List<ActivityParameterNodeActivation> GetOutputParameterNodeActivations()
        {
            // Return the set of all activations in this group of activity parameter
            // nodes for output (inout, out and return) parameters.

            List<ActivityParameterNodeActivation> parameterNodeActivations = new();
            List<ActivityNodeActivation> nodeActivations = this.nodeActivations;
            foreach (ActivityNodeActivation activation in nodeActivations)
            {
                if (activation is ActivityParameterNodeActivation activityParameterNodeActivation) {
                if (activation.incomingEdges.Count > 0)
                {
                    parameterNodeActivations.Add(activityParameterNodeActivation);
                }
            }
        }

		return parameterNodeActivations;
	} // getOutputParameterNodeActivations

    public bool HasSourceFor(
            ActivityEdgeInstance edgeInstance)
    {
        // Returns true if this activation group has a node activation
        // corresponding to the source of the given edge instance.

        bool hasSource = false;
        List<ActivityNodeActivation> activations = nodeActivations;
        int i = 1;
        while (!hasSource & i <= activations.Count)
        {
            hasSource = activations.ElementAt(i - 1).IsSourceFor(edgeInstance);
            i++;
        }
        return hasSource;
    } // hasSourceFor

    public bool IsSuspended()
    {
        // Check if this activation group has any suspended activations and
        // is, therefore, itself suspended.

        return suspendedActivations.Count > 0;
    } // isSuspended

    public void Suspend(
            ActivityNodeActivation activation)
    {
        // Suspend the given activation in this activation group. If this is
        // the only suspended activation, and the activation group has a
        // containing node activation, then suspend that containing activation.

        Debug.println("[suspend] node="
                + (activation.node is null ? "null" : activation.node.name));

        if (!IsSuspended())
        {
            StructuredActivityNodeActivation? containingNodeActivation = this.containingNodeActivation;
            if (containingNodeActivation is not null)
            {
                containingNodeActivation.Suspend();
            }
        }
        suspendedActivations.Add(activation);
    } // suspend

    public void Resume(
            ActivityNodeActivation activation)
    {
        // Resume the given activation by removing it from the suspended
        // activation list for this activation group. If this is the last
        // suspended activation, and the activation group has a containing
        // node activation, then resume that containing activation.

        Debug.println("[resume] node="
                + (activation.node is null ? "null" : activation.node.name));

        bool found = false;
        int i = 1;
        while (!found & i <= suspendedActivations.Count)
        {
            if (suspendedActivations.ElementAt(i - 1) == activation)
            {
                suspendedActivations.RemoveAt(i - 1);
                found = true;
            }
            i++;
        }
        if (!IsSuspended())
        {
            StructuredActivityNodeActivation? containingNodeActivation = this.containingNodeActivation;
            if (containingNodeActivation is not null)
            {
                containingNodeActivation.Resume();
            }
        }
    } // resume
} // ActivityNodeActivationGroup
}
