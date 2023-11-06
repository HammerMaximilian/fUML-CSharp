using fuml.semantics.activities;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using fuml.syntax.actions;
using fuml.syntax.activities;
using fuml.syntax.classification;
using fuml.syntax.structuredclassifiers;
using fuml.syntax.values;

namespace fuml.semantics.actions
{
    public abstract class ActionActivation : ExecutableNodeActivation
    {
        public bool firing = false;
        public List<PinActivation> pinActivations = new();

        public override void Initialize(ActivityNode node, ActivityNodeActivationGroup group)
        {
            // Initialize this action activation to be not firing.

            base.Initialize(node, group);
            firing = false;
        }

        public override void Run()
        {
            // Run this action activation and any outgoing fork node attached to it.

            base.Run();

            if (outgoingEdges.Count > 0)
            {
                outgoingEdges?.ElementAt(0)?.target?.Run();
            }

            firing = false;
        } // run

        public override List<Token> TakeOfferedTokens()
        {
            // If the action is not locally reentrant, then mark this activation as
            // firing.
            // Take any incoming offers of control tokens, then concurrently fire
            // all input pin activations.

            // Note: This is included here to happen in the same isolation scope as
            // the isReady test.
            firing = !((syntax.actions.Action)node!).isLocallyReentrant;

            List<Token> offeredTokens = new();

            List<ActivityEdgeInstance> incomingEdges = this.incomingEdges;
            foreach (ActivityEdgeInstance incomingEdge in incomingEdges)
            {
                List<Token> tokens = incomingEdge.TakeOfferedTokens();
                foreach (Token token in tokens)
                {
                    token.Withdraw();
                    offeredTokens.Add(token);
                }
            }

            syntax.actions.Action action = (syntax.actions.Action)node;

            // *** Fire all input pins concurrently. ***
            List<InputPin> inputPins = action.input;
            foreach (InputPin pin in inputPins)
            {
                PinActivation pinActivation = GetPinActivation(pin);
                List<Token> tokens = pinActivation.TakeOfferedTokens();
                pinActivation.Fire(tokens);
                foreach (Token token in tokens)
                {
                    offeredTokens.Add(token);
                }
            }

            return offeredTokens;
        } // takeOfferedTokens

        public override void Fire(List<Token> incomingTokens)
        {
            // Do the main action behavior then concurrently fire all output pin
            // activations
            // and offer a single control token. Then activate the action again,
            // if it is still ready to fire and has at least one token actually
            // being
            // offered to it.

            do
            {

                Debug.Println("[fire] Action " + node?.name + "...");
                Debug.Println("[event] Fire activity="
                        + GetActivityExecution().GetBehavior().name
                        + " action=" + node?.name);

                DoAction();
                incomingTokens = CompleteAction();

            } while (incomingTokens.Count > 0);
        } // fire

        public override void Terminate()
        {
            // Terminate this action activation and any outgoing fork node attached
            // to it.

            base.Terminate();

            if (outgoingEdges.Count > 0)
            {
                outgoingEdges?.ElementAt(0)?.target?.Terminate();
            }
        } // terminate

        public virtual List<Token> CompleteAction()
        {
            // Concurrently fire all output pin activations and offer a single
            // control token. Then check if the action should fire again
            // and, if so, return additional incoming tokens for this.

            SendOffers();

            Debug.Println("[fire] Checking if " + node?.name + " should fire again...");

            _beginIsolation();
            List<Token> incomingTokens = new();
            firing = false;
            if (IsReady())
            {
                incomingTokens = TakeOfferedTokens();
                firing = IsFiring() & incomingTokens.Count > 0;
            }
            _endIsolation();

            return incomingTokens;
        } // completeAction

        public override bool IsReady()
        {
            // Check that the action is ready to fire, including
            // that all input pin activations are ready.

            bool ready = IsControlReady();

            List<InputPin> inputPins = ((syntax.actions.Action)node!).input;
            int j = 1;
            while (ready & j <= inputPins.Count)
            {
                ready = GetPinActivation(inputPins.ElementAt(j - 1)).IsReady();
                j++;
            }

            return ready;
        } // isReady

        public bool IsControlReady()
        {
            // In addition to the default condition for being ready, check that, 
            // if the action has isLocallyReentrant=false, then the activation is 
            // not currently firing, and that the sources of all incoming edges
            // have offers. (This assumes that all edges directly incoming to the
            // action are control flows.)

            bool ready = base.IsReady()
                    & (((syntax.actions.Action)node!).isLocallyReentrant | !IsFiring());

            int i = 1;
            while (ready & i <= incomingEdges.Count)
            {
                ready = incomingEdges.ElementAt(i - 1).HasOffer();
                i++;
            }

            return ready;
        }

        public bool IsFiring()
        {
            // Indicate whether this action activation is currently firing or not.

            return firing;
        } // isFiring

        public abstract void DoAction();

        public virtual void SendOffers()
        {
            // Fire all output pins and send offers on all outgoing control flows.
            // *** Send offers from all output pins concurrently. ***
            List<OutputPin> outputPins = GetOfferingOutputPins();
            foreach (OutputPin outputPin in outputPins)
            {
                PinActivation pinActivation = GetPinActivation(outputPin);
                pinActivation.SendUnofferedTokens();
            }

            // Send offers on all outgoing control flows.
            if (outgoingEdges.Count > 0)
            {
                List<Token> tokens = new();
                tokens.Add(new ControlToken());
                AddTokens(tokens);
                outgoingEdges.ElementAt(0).SendOffer(tokens);
            }
        } // sendOffers

        public virtual List<OutputPin> GetOfferingOutputPins()
        {
            // Return the output pins of the action of this action activation from 
            // which offers are to be sent when the action activation finishes firing.
            // (This is normally all the output pins of the action, but it can be
            // overridden in subclasses to only return a subset of the output pins.)

            return ((syntax.actions.Action)node!).output;
        }

        public override void CreateNodeActivations()
        {
            // Create node activations for the input and output pins of the action
            // for this activation.
            // [Note: Pins are owned by their actions, not by the enclosing activity
            // (or group), so they must be activated through the action activation.]

            syntax.actions.Action action = (syntax.actions.Action)node!;

            List<ActivityNode> inputPinNodes = new();
            List<InputPin> inputPins = action.input;
            foreach (InputPin inputPin in inputPins)
            {
                inputPinNodes.Add(inputPin);
            }

            group?.CreateNodeActivations(inputPinNodes);

            foreach (ActivityNode node in inputPinNodes)
            {
                AddPinActivation((PinActivation)group?.GetNodeActivation(node)!);
            }

            List<ActivityNode> outputPinNodes = new();
            List<OutputPin> outputPins = action.output;
            foreach (OutputPin outputPin in outputPins)
            {
                outputPinNodes.Add(outputPin);
            }

            group?.CreateNodeActivations(outputPinNodes);

            for (int i = 0; i < outputPinNodes.Count; i++)
            {
                ActivityNode node = outputPinNodes.ElementAt(i);
                AddPinActivation((PinActivation)group?.GetNodeActivation(node)!);
            }
        } // createNodeActivations

        public override void AddOutgoingEdge(ActivityEdgeInstance edge)
        {
            // If there are no outgoing activity edge instances, create a single
            // activity edge instance with a fork node execution at the other end.
            // Add the give edge to the fork node execution that is the target of
            // the activity edge instance out of this action execution.
            // [This assumes that all edges directly outgoing from the action are
            // control flows, with an implicit fork for offers out of the action.]

            ActivityNodeActivation forkNodeActivation;

            if (outgoingEdges.Count == 0)
            {
                forkNodeActivation = new ForkNodeActivation
                {
                    running = false
                };
                ActivityEdgeInstance newEdge = new();
                base.AddOutgoingEdge(newEdge);
                forkNodeActivation.AddIncomingEdge(newEdge);
            }
            else
            {
                forkNodeActivation = outgoingEdges?.ElementAt(0)?.target!;
            }

            forkNodeActivation.AddOutgoingEdge(edge);
        } // addOutgoingEdge

        public void AddPinActivation(PinActivation pinActivation)
        {
            // Add a pin activation to this action activation.

            pinActivations.Add(pinActivation);
            pinActivation.actionActivation = this;
        } // addPinActivation

        public PinActivation GetPinActivation(Pin pin)
        {
            // Precondition: The given pin is owned by the action of the action
            // activation.
            // Return the pin activation corresponding to the given pin.

            PinActivation? pinActivation = null;
            int i = 1;
            while (pinActivation is null & i <= pinActivations.Count)
            {
                PinActivation thisPinActivation = pinActivations
                        .ElementAt(i - 1);
                if (thisPinActivation.node == pin)
                {
                    pinActivation = thisPinActivation;
                }
                i++;
            }

            return pinActivation!;

        } // getPinActivation

        public void PutToken(OutputPin pin, Value value)
        {
            // Precondition: The action execution has fired and the given pin is
            // owned by the action of the action execution.
            // Place a token for the given value on the pin activation corresponding
            // to the given output pin.

            Debug.Println("[putToken] node = " + node?.name);

            ObjectToken token = new();
            token.value = value;

            PinActivation pinActivation = GetPinActivation(pin);
            pinActivation.AddToken(token);
        } // putToken

        public void PutTokens(OutputPin pin, List<Value> values)
        {
            // Precondition: The action execution has fired and the given pin is
            // owned by the action of the action execution.
            // Place tokens for the given values on the pin activation corresponding
            // to the given output pin.

            foreach (Value value in values)
            {
                PutToken(pin, value);
            }

        } // putTokens

        public List<Value> GetTokens(InputPin pin)
        {
            // Precondition: The action execution has fired and the given pin is
            // owned by the action of the action execution.
            // Get any tokens held by the pin activation corresponding to the given
            // input pin and return them
            // (but leave the tokens on the pin).

            Debug.Println("[getTokens] node = " + node?.name + ", pin = " + pin.name);

            PinActivation pinActivation = GetPinActivation(pin);
            List<Token> tokens = pinActivation.GetUnofferedTokens();

            List<Value> values = new();
            foreach (Token token in tokens)
            {
                Value value = ((ObjectToken)token).value!;
                if (value is not null)
                {
                    values.Add(value);
                }
            }

            return values;
        } // getTokens

        public List<Value> TakeTokens(InputPin pin)
        {
            // Precondition: The action execution has fired and the given pin is
            // owned by the action of the action execution.
            // Take any tokens held by the pin activation corresponding to the given
            // input pin and return them.

            Debug.Println("[takeTokens] node = " + node?.name + ", pin = " + pin.name);

            PinActivation pinActivation = GetPinActivation(pin);
            List<Token> tokens = pinActivation.TakeUnofferedTokens();

            List<Value> values = new();
            foreach (Token token in tokens)
            {
                Value value = ((ObjectToken)token).value!;
                if (value is not null)
                {
                    values.Add(value);
                }
            }

            return values;
        } // takeTokens

        public override bool IsSourceFor(ActivityEdgeInstance edgeInstance)
        {
            // If this action has an outgoing fork node, check that the fork node is
            // the source of the given edge instance.

            bool isSource = false;
            if (outgoingEdges.Count > 0)
            {
                isSource = outgoingEdges.ElementAt(0).target!.IsSourceFor(edgeInstance);
            }

            return isSource;
        } // isSourceFor

        public bool ValueParticipatesInLink(Value value, Link link)
        {
            // Test if the given value participates in the given link.

            List<FeatureValue> linkFeatureValues = link.GetFeatureValues();

            bool participates = false;
            int i = 1;
            while (!participates & i <= linkFeatureValues.Count)
            {
                participates = linkFeatureValues.ElementAt(i - 1).values.ElementAt(0).Equals(value);
                i++;
            }

            return participates;
        } // valueParticipatesInLink

        public Association GetAssociation(
               StructuralFeature feature)
        {
            // If the given structural feature is an association end, then get 
            // the associated association.

            Association? association = null;
            if (feature is Property property)
            {
                association = property.association;
            }

            return association!;
        } // getAssociation

        public List<Value> GetValues(
                Value sourceValue,
                StructuralFeature feature)
        {
            // Get the values of the feature for the given source value.
            // If the feature is an association end, then get the values of
            // the feature end of the links with the source value as the
            // opposite end.
            // Otherwise, if the source value is a structured value, get 
            // the values of the feature value for feature in the structured value.

            List<Value> values = new();

            Association association = GetAssociation(feature);
            if (association is not null)
            {
                List<Link> links = GetMatchingLinks(association, feature, sourceValue);
                foreach (Link link in links)
                {
                    values.Add(link.GetFeatureValue(feature).values.ElementAt(0));
                }
            }
            else
            {
                values = ((StructuredValue)sourceValue).GetFeatureValue(feature).values;
            }

            return values;
        }

        public List<Link> GetMatchingLinks(
                Association association,
                StructuralFeature end,
                Value oppositeValue)
        {
            // Get the links of the given binary association whose end opposite
            // to the given end has the given value

            return GetMatchingLinksForEndValue(association, end, oppositeValue, null!);
        }


        public List<Link> GetMatchingLinksForEndValue(
                Association association,
                StructuralFeature end,
                Value oppositeValue,
                Value endValue)
        {
            // Get the links of the given binary association whose end opposite
            // to the given end has the given opposite value and, optionally, that
            // has a given end value for the given end.

            Property oppositeEnd = GetOppositeEnd(association, end);

            List<ExtensionalValue> extent = GetExecutionLocus().GetExtent(
                    association);

            List<Link> links = new();
            foreach (ExtensionalValue link in extent)
            {
                if (link.GetFeatureValue(oppositeEnd).values.ElementAt(0).Equals(oppositeValue))
                {
                    bool matches = true;
                    if (endValue != null)
                    {
                        matches = link.GetFeatureValue(end).values.ElementAt(0).Equals(endValue);
                    }
                    if (matches)
                    {
                        if (!end.multiplicityElement.isOrdered | links.Count == 0)
                        {
                            links.Add((Link)link);
                        }
                        else
                        {
                            int n = link.GetFeatureValue(end).position;
                            bool continueSearching = true;
                            int j = 0;
                            while (continueSearching & j < links.Count)
                            {
                                j++;
                                continueSearching = links.ElementAt(j - 1).GetFeatureValue(end).position < n;
                            }
                            if (continueSearching)
                            {
                                links.Add((Link)link);
                            }
                            else
                            {
                                links.Insert(j - 1, (Link)link);
                            }
                        }
                    }
                }
            }

            return links;
        } // getMatchingLinksForEndValue

        public Property GetOppositeEnd(
                Association association,
                StructuralFeature end)
        {
            // Get the end of a binary association opposite to the given end.

            Property oppositeEnd = association.memberEnd.ElementAt(0);
            if (oppositeEnd == end)
            {
                oppositeEnd = association.memberEnd.ElementAt(1);
            }

            return oppositeEnd;
        } // getOppositeEnd

        public BooleanValue MakeBooleanValue(bool value)
        {
            // Make a bool value using the built-in bool primitive type.
            // [This ensures that bool values created internally are the same as
            // the default used for evaluating bool literals.]

            LiteralBoolean booleanLiteral = new();
            booleanLiteral.value = value;
            return (BooleanValue)GetExecutionLocus()?.executor?.Evaluate(booleanLiteral)!;
        } // makeboolValue

        public override void Handle(Value exception, ExceptionHandler handler)
        {
            // Handle the given exception by firing the body of the given
            // exception handler. After the body fires, transfer its outputs
            // to the output pins of this action activation.

            base.Handle(exception, handler);
            TransferOutputs((syntax.actions.Action)handler?.handlerBody!);
        }

        public void TransferOutputs(syntax.actions.Action handlerBody)
        {
            // Transfer the output values from activation of the given exception
            // handler body to the output pins of this action activation.

            ActionActivation handlerBodyActivation =
                    (ActionActivation)group?.GetNodeActivation(handlerBody)!;
            List<OutputPin> sourceOutputs = handlerBody.output;
            List<OutputPin> targetOutputs = ((syntax.actions.Action)node!)?.output!;

            for (int i = 0; i < sourceOutputs.Count; i++)
            {
                OutputPin sourcePin = sourceOutputs.ElementAt(i);
                OutputPin targetPin = targetOutputs.ElementAt(i);

                PinActivation sourcePinActivation = handlerBodyActivation.GetPinActivation(sourcePin);
                List<Token> tokens = sourcePinActivation.TakeTokens();
                List<Value> values = new();
                foreach (Token token in tokens)
                {
                    values.Add(token.GetValue());
                }

                PutTokens(targetPin, values);
            }
        }
    } // ActionActivation
}
