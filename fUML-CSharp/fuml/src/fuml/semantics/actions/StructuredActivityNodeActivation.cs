using fuml.semantics.activities;
using fuml.semantics.values;
using fuml.syntax.actions;
using fuml.syntax.activities;

namespace fuml.semantics.actions
{
    public class StructuredActivityNodeActivation : ActionActivation
    {
        public ActivityNodeActivationGroup? activationGroup = null;

        public override void DoAction()
        {
            // If the structured activity node has mustIsolate=true, then carry out
            // its behavior with isolation.
            // Otherwise just activate it normally.

            if (((StructuredActivityNode)node!).mustIsolate)
            {
                _beginIsolation();
                DoStructuredActivity();
                _endIsolation();
            }
            else
            {
                DoStructuredActivity();
            }

        } // doAction

        public void DoStructuredActivity()
        {
            // Run all activations of contained nodes. When this is complete,
            // return.
            // (This is the default behavior for a structured activity node used
            // simply as a group. It is overridden for the execution of conditional
            // and loop nodes.)

            syntax.actions.Action action = (syntax.actions.Action)node!;

            // *** Concurrently send offers from all input pins. ***
            List<InputPin> inputPins = action.input;
            foreach (InputPin inputPin in inputPins)
            {
                PinActivation pinActivation = GetPinActivation(inputPin);
                pinActivation.SendUnofferedTokens();
            }

            activationGroup?.Run(activationGroup.nodeActivations);
        } // doStructuredActivity

        public override void Terminate()
        {
            // Terminate the execution of all contained node activations (which
            // completes the performance of the structured activity node
            // activation), and then terminate this node itself.

            TerminateAll();
            base.Terminate();
        } // terminate

        public override ActivityNodeActivation GetNodeActivation(
                ActivityNode node)
        {
            // If this structured activity node activation is not for the given
            // node, then check if there is an activation for the node in the
            // activation group.

            ActivityNodeActivation thisActivation = base.GetNodeActivation(node);

            ActivityNodeActivation? activation = null;
            if (thisActivation is not null)
            {
                activation = thisActivation;
            }
            else if (activationGroup is not null)
            {
                activation = activationGroup.GetNodeActivation(node);
            }

            return activation!;
        } // getNodeActivation

        public List<ActivityNode> MakeActivityNodeList(
                List<ExecutableNode> nodes)
        {
            // Return an activity node List<> containing the given List<> of executable
            // nodes
            // and any pins that they own.

            List<ActivityNode> activityNodes = new();

            foreach (ActivityNode node in nodes)
            {
                activityNodes.Add(node);

                if (node is syntax.actions.Action action)
                {
                    List<InputPin> inputPins = action.input;
                    foreach (InputPin inputPin in inputPins)
                    {
                        activityNodes.Add(inputPin);
                    }

                    List<OutputPin> outputPins = action.output;
                    foreach (OutputPin outputPin in outputPins)
                    {
                        activityNodes.Add(outputPin);
                    }
                }
            }

            return activityNodes;
        } // List<makeActivityNode>

        public List<Value> GetPinValues(
                OutputPin pin)
        {
            // Return the values of the tokens on the pin activation corresponding
            // to the given pin in the internal activation group for this node
            // activation.

            PinActivation pinActivation = (PinActivation)activationGroup?.GetNodeActivation(pin)!;
            List<Token> tokens = pinActivation.GetTokens();

            List<Value> values = new();
            foreach (Token token in tokens)
            {
                Value value = ((ObjectToken)token)?.value!;
                if (value is not null)
                {
                    values.Add(value);
                }
            }

            return values;
        } // getPinValues

        public void PutPinValues(OutputPin pin,
                List<Value> values)
        {
            // Place tokens for the given values on the pin activation corresponding
            // to the given output pin on the internal activation group for this
            // node activation.

            PinActivation pinActivation = (PinActivation)activationGroup?.GetNodeActivation(pin)!;

            foreach (Value value in values)
            {
                ObjectToken token = new();
                token.value = value;
                pinActivation.AddToken(token);
            }

        } // putPinValues

        public override void CreateNodeActivations()
        {
            // Create an activation group and create node activations for all the
            // nodes within the structured activity node.

            base.CreateNodeActivations();

            activationGroup = new ActivityNodeActivationGroup
            {
                containingNodeActivation = this
            };
            activationGroup.CreateNodeActivations(((StructuredActivityNode)node!)?.node!);

        } // createNodeActivations

        public override void CreateEdgeInstances()
        {
            // Create instances for all edges owned by this node.

            activationGroup?.CreateEdgeInstances(((StructuredActivityNode)node!)?.edge!);
        } // createEdgeInstances

        public override bool IsSourceFor(ActivityEdgeInstance edgeInstance)
        {
            // Returns true if this node is either the source for the given
            // edgeInstance itself or if it contains the source in its
            // activation group.

            bool isSource = base.IsSourceFor(edgeInstance);
            if (!isSource)
            {
                isSource = (activationGroup is not null) ? activationGroup.HasSourceFor(edgeInstance) : throw new NullReferenceException();
            }
            return isSource;
        } // isSourceFor

        public void TerminateAll()
        {
            // Terminate the execution of all contained node activations (which
            // completes the performance of the structured activity node
            // activation).

            activationGroup?.TerminateAll();
        } // terminateAll

        public bool IsSuspended()
        {
            // Check if the activation group for this node is suspended.

            return activationGroup is not null && activationGroup.IsSuspended();
        } // isSuspended

        public override List<Token> CompleteAction()
        {
            // Only actually complete this structured activity node if it is not
            // suspended.

            List<Token> incomingTokens = new();
            if (!IsSuspended())
            {
                incomingTokens = base.CompleteAction();
            }
            return incomingTokens;
        } // completeAction

        public override void Resume()
        {
            // When this structured activity node is resumed after being suspended,
            // then complete its prior firing and, if there are more incoming
            // tokens, fire it again. If, after that, the node is not suspended,
            // then finish its resumption.

            List<Token> incomingTokens = base.CompleteAction();
            if (incomingTokens.Count > 0)
            {
                Fire(incomingTokens);
            }
            if (!IsSuspended())
            {
                base.Resume();
            }
        } // resume
    } // StructuredActivityNodeActivation
}
