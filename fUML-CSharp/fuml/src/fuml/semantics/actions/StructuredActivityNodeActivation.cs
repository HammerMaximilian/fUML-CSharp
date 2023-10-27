using fuml.semantics.activities;
using fuml.semantics.values;
using fuml.syntax.actions;
using fuml.syntax.activities;

namespace fuml.semantics.actions
{
    public class StructuredActivityNodeActivation : ActionActivation
    {
        public ActivityNodeActivationGroup? activationGroup = null;

        public override void doAction()
        {
            // If the structured activity node has mustIsolate=true, then carry out
            // its behavior with isolation.
            // Otherwise just activate it normally.

            if (((StructuredActivityNode)node!).mustIsolate)
            {
                _beginIsolation();
                doStructuredActivity();
                _endIsolation();
            }
            else
            {
                doStructuredActivity();
            }

        } // doAction

        public void doStructuredActivity()
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
                PinActivation pinActivation = getPinActivation(inputPin);
                pinActivation.sendUnofferedTokens();
            }

            activationGroup?.run(activationGroup.nodeActivations);
        } // doStructuredActivity

        public override void terminate()
        {
            // Terminate the execution of all contained node activations (which
            // completes the performance of the structured activity node
            // activation), and then terminate this node itself.

            terminateAll();
            base.terminate();
        } // terminate

        public override ActivityNodeActivation getNodeActivation(
                ActivityNode node)
        {
            // If this structured activity node activation is not for the given
            // node, then check if there is an activation for the node in the
            // activation group.

            ActivityNodeActivation thisActivation = base.getNodeActivation(node);

            ActivityNodeActivation? activation = null;
            if (thisActivation is not null)
            {
                activation = thisActivation;
            }
            else if (activationGroup is not null)
            {
                activation = activationGroup.getNodeActivation(node);
            }

            return activation!;
        } // getNodeActivation

        public List<ActivityNode> makeActivityNodeList(
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

        public List<Value> getPinValues(
                OutputPin pin)
        {
            // Return the values of the tokens on the pin activation corresponding
            // to the given pin in the internal activation group for this node
            // activation.

            PinActivation pinActivation = (PinActivation)activationGroup?.getNodeActivation(pin)!;
            List<Token> tokens = pinActivation.getTokens();

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

        public void putPinValues(OutputPin pin,
                List<Value> values)
        {
            // Place tokens for the given values on the pin activation corresponding
            // to the given output pin on the internal activation group for this
            // node activation.

            PinActivation pinActivation = (PinActivation)activationGroup?.getNodeActivation(pin)!;

            foreach (Value value in values)
            {
                ObjectToken token = new();
                token.value = value;
                pinActivation.addToken(token);
            }

        } // putPinValues

        public override void createNodeActivations()
        {
            // Create an activation group and create node activations for all the
            // nodes within the structured activity node.

            base.createNodeActivations();

            activationGroup = new ActivityNodeActivationGroup
            {
                containingNodeActivation = this
            };
            activationGroup.createNodeActivations(((StructuredActivityNode)node!)?.node!);

        } // createNodeActivations

        public override void createEdgeInstances()
        {
            // Create instances for all edges owned by this node.

            activationGroup?.createEdgeInstances(((StructuredActivityNode)node!)?.edge!);
        } // createEdgeInstances

        public override bool isSourceFor(ActivityEdgeInstance edgeInstance)
        {
            // Returns true if this node is either the source for the given
            // edgeInstance itself or if it contains the source in its
            // activation group.

            bool isSource = base.isSourceFor(edgeInstance);
            if (!isSource)
            {
                isSource = (activationGroup is not null) ? activationGroup.hasSourceFor(edgeInstance) : throw new NullReferenceException();
            }
            return isSource;
        } // isSourceFor

        public void terminateAll()
        {
            // Terminate the execution of all contained node activations (which
            // completes the performance of the structured activity node
            // activation).

            activationGroup?.terminateAll();
        } // terminateAll

        public bool isSuspended()
        {
            // Check if the activation group for this node is suspended.

            return activationGroup is not null && activationGroup.isSuspended();
        } // isSuspended

        public override List<Token> completeAction()
        {
            // Only actually complete this structured activity node if it is not
            // suspended.

            List<Token> incomingTokens = new();
            if (!isSuspended())
            {
                incomingTokens = base.completeAction();
            }
            return incomingTokens;
        } // completeAction

        public override void resume()
        {
            // When this structured activity node is resumed after being suspended,
            // then complete its prior firing and, if there are more incoming
            // tokens, fire it again. If, after that, the node is not suspended,
            // then finish its resumption.

            List<Token> incomingTokens = base.completeAction();
            if (incomingTokens.Count > 0)
            {
                fire(incomingTokens);
            }
            if (!isSuspended())
            {
                base.resume();
            }
        } // resume
    } // StructuredActivityNodeActivation
}
