using fuml.semantics.activities;
using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;
using fuml.syntax.actions;
using fuml.syntax.activities;
using fuml.syntax.commonbehavior;

namespace fuml.semantics.actions
{
    public class AcceptEventActionActivation : ActionActivation
    {
        public AcceptEventActionEventAccepter? eventAccepter = null;
        public bool waiting = false;

        public override void Initialize(ActivityNode node, ActivityNodeActivationGroup group)
        {
            // Initialize this accept event action activation to be not waiting for an event.

            base.Initialize(node, group);
            waiting = false;
        }

        public override void Run()
        {
            // Create an event accepter and initialize waiting to false.

            base.Run();

            eventAccepter = new AcceptEventActionEventAccepter();
            eventAccepter.actionActivation = this;

            waiting = false;
        } // run

        public override void Fire(List<Token> incomingTokens)
        {
            // Register the event accepter for this accept event action activation
            // with the context object of the enclosing activity execution
            // and wait for an event to be accepted.

            Debug.println("[fire] Action " + node?.name + "...");

            GetExecutionContext().Register(eventAccepter!);
            waiting = true;
            firing = false;

            Suspend();
        } // fire

        public override bool IsReady()
        {
            // An accept event action activation is ready to fire only if it is not
            // already waiting for an event.

            bool ready;
            if (waiting)
            {
                ready = false;
            }
            else
            {
                ready = base.IsReady();
            }

            return ready;
        } // isReady

        public override void DoAction()
        {
            // Do nothing. [This will never be called.]

            return;
        } // doAction

        public virtual void Accept(EventOccurrence eventOccurrence)
        {
            // Accept the given event occurrence.
            // If the action does not unmarshall, then, if the event occurrence is
            // a signal event occurrence, place the signal instance of the signal
            // event occurrence on the result pin, if any.
            // If the action does unmarshall, then get the parameter values of the
            // event occurrence, and place the values for each parameter on the
            // corresponding output pin.
            // Concurrently fire all output pins while offering a single control
            // token.
            // If there are no incoming edges, then re-register this accept event
            // action execution with the context object.

            AcceptEventAction action = (node as AcceptEventAction)!;
            List<OutputPin> resultPins = action.result;

            Debug.println("[accept] action = " + action.name + ", eventOccurrence = " + eventOccurrence);

            if (running)
            {
                if (!action.isUnmarshall)
                {
                    if (eventOccurrence is SignalEventOccurrence)
                    {
                        SignalInstance signalInstance = (eventOccurrence as SignalEventOccurrence)?.signalInstance!;
                        Debug.println("[accept] isUnmarshall = false, signalInstance = " + signalInstance);
                        List<Value> result = new List<Value>();
                        result.Add(signalInstance);
                        if (resultPins.Count > 0)
                        {
                            PutTokens(resultPins.ElementAt(0), result);
                        }
                    }
                }
                else
                {
                    List<ParameterValue> parameterValues =
                            eventOccurrence.GetParameterValues(action?.trigger?.ElementAt(0)?.event_!);
                    for (int i = 0; i < parameterValues.Count; i++)
                    {
                        ParameterValue parameterValue = parameterValues.ElementAt(i);
                        OutputPin resultPin = resultPins.ElementAt(i);
                        PutTokens(resultPin, parameterValue.values);
                    }
                }

                SendOffers();

                waiting = false;

                Debug.println("[accept] Checking if " + node?.name + " should fire again...");
                ReceiveOffer();

                Resume();
            }

        } // accept

        public bool Match(EventOccurrence eventOccurrence)
        {
            // Return true if the given event occurrence matches a trigger of the
            // accept event action of this activation.

            AcceptEventAction action = (node as AcceptEventAction)!;
            List<Trigger> triggers = action.trigger;

            return eventOccurrence.MatchAny(triggers);
        } // match

        public override void Terminate()
        {
            // Terminate this action and unregister its event accepter.

            base.Terminate();

            if (waiting)
            {
                GetExecutionContext().Unregister(eventAccepter!);
                waiting = false;
            }
        } // terminate
    } // AcceptEventActionActivation
}
