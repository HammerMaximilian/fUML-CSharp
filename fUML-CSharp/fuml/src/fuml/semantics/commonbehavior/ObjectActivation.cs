using fuml.semantics.loci;
using fuml.semantics.structuredclassifiers;
using uml.commonbehavior;
using uml.structuredclassifiers;

namespace fuml.semantics.commonbehavior
{
    public class ObjectActivation
    {
        public List<ClassifierBehaviorInvocationEventAccepter> classifierBehaviorInvocations = new();
        public List<EventAccepter> waitingEventAccepters = new();
        public List<EventOccurrence> eventPool = new();
        public Object_? object_ = null;

        public ObjectActivation()
        {
            behavior = new ObjectActivation_EventDispatchLoopExecution(this);
        }

        public void Stop()
        {
            // Stop this object activation by terminating all classifier behavior
            // executions.

            List<ClassifierBehaviorInvocationEventAccepter> classifierBehaviorInvocations = this.classifierBehaviorInvocations;
            foreach (ClassifierBehaviorInvocationEventAccepter classifierBehaviorInvocation in classifierBehaviorInvocations)
            {
                classifierBehaviorInvocation.Terminate();
            }

        } // stop

        public void Register(EventAccepter accepter)
        {
            // Register the given event accepter to wait for a dispatched signal
            // event.

            Debug.Println("[register] object = " + object_);
            Debug.Println("[register] accepter = " + accepter);

            waitingEventAccepters.Add(accepter);
        } // register

        public void Unregister(
                EventAccepter accepter)
        {
            // Remove the given event accepter for the list of waiting event
            // accepters.

            Debug.Println("[unregister] object = " + object_);
            Debug.Println("[unregister] accepter = " + accepter);

            bool notFound = true;
            int i = 1;
            while (notFound & i <= waitingEventAccepters.Count)
            {
                if (waitingEventAccepters.ElementAt(i - 1) == accepter)
                {
                    waitingEventAccepters.RemoveAt(i - 1);
                    notFound = false;
                }
                i++;
            }

        } // unregister

        public virtual void DispatchNextEvent()
        {
            // Get the next event occurrence out of the event pool.
            // If there are one or more waiting event accepters with triggers that
            // match the event occurrence, then dispatch it to exactly one of those
            // waiting accepters.

            if (eventPool.Count > 0)
            {
                EventOccurrence eventOccurrence = GetNextEvent();

                Debug.Println("[dispatchNextEvent] eventOccurrence = " + eventOccurrence);

                List<int> matchingEventAccepterIndexes = new();
                List<EventAccepter> waitingEventAccepters = this.waitingEventAccepters;
                for (int i = 0; i < waitingEventAccepters.Count; i++)
                {
                    EventAccepter eventAccepter = waitingEventAccepters.ElementAt(i);
                    if (eventAccepter.Match(eventOccurrence))
                    {
                        matchingEventAccepterIndexes.Add(i);
                    }
                }

                if (matchingEventAccepterIndexes.Count > 0)
                {
                    // *** Choose one matching event accepter non-deterministically. ***
                    ChoiceStrategy? choiceStrategy = (ChoiceStrategy)object_?.locus?.factory?.GetStrategy("choice")!;
                    int j = (choiceStrategy is not null) ? choiceStrategy.Choose(matchingEventAccepterIndexes.Count) : throw new NullReferenceException();
                    int k = matchingEventAccepterIndexes.ElementAt(j - 1);
                    EventAccepter selectedEventAccepter = this.waitingEventAccepters
                            .ElementAt(k);
                    this.waitingEventAccepters.RemoveAt(k);
                    selectedEventAccepter.Accept(eventOccurrence);
                }
            }
        } // dispatchNextEvent

        public virtual EventOccurrence GetNextEvent()
        {
            // Get the next event from the event pool, using a get next event
            // strategy.

            GetNextEventStrategy? getNextEventStrategy = (GetNextEventStrategy)object_?.locus?.factory?.GetStrategy("getNextEvent")!;

            return (getNextEventStrategy is not null) ? getNextEventStrategy.GetNextEvent(this) : throw new NullReferenceException();
        } // getNextEvent

        public void Send(
                EventOccurrence eventOccurrence)
        {
            // Add an event occurrence to the event pool and signal that a
            // new event occurrence has arrived.

            eventPool.Add(eventOccurrence);
            _send(new ArrivalSignal());
        } // send

        public virtual void StartBehavior(
                Class_ classifier,
                List<ParameterValue> inputs)
        {
            // Start the event dispatch loop for this object activation (if it has
            // not already been started).
            // If a classifier is given that is a type of the object of this object
            // activation and there is not already a classifier behavior invocation
            // for it,
            // then create a classifier behavior invocation for it and add an invocation
            // event occurrence to the event pool.
            // Otherwise, create a classifier behavior invocation for each of the
            // types of the object of this object activation which has a classifier
            // behavior or which is a behavior itself
            // and for which there is not currently a classifier behavior invocation.

            // Start EventDispatchLoop
            _startObjectBehavior();

            if (classifier is null)
            {
                Debug.Println("[startBehavior] Starting behavior for all classifiers...");
                // *** Start all classifier behaviors concurrently. ***
                List<Class_> types = (object_ is not null) ? object_.types : new();
                foreach (Class_ type in types)
                {
                    if (type is Behavior | type.classifierBehavior is not null)
                    {
                        StartBehavior(type, new List<ParameterValue>());
                    }
                }
            }
            else
            {
                Debug.Println("[startBehavior] Starting behavior for " + classifier?.name + "...");

                _beginIsolation();
                bool notYetStarted = true;
                int i = 1;
                while (notYetStarted
                        & i <= classifierBehaviorInvocations.Count)
                {
                    notYetStarted = classifierBehaviorInvocations.ElementAt(i - 1).classifier != classifier;
                    i++;
                }

                if (notYetStarted)
                {
                    ClassifierBehaviorInvocationEventAccepter newInvocation = new()
                    {
                        objectActivation = this
                    };
                    classifierBehaviorInvocations.Add(newInvocation);
                    newInvocation.InvokeBehavior(classifier!, inputs);
                    InvocationEventOccurrence eventOccurrence = new()
                    {
                        execution = newInvocation.execution
                    };
                    eventPool.Add(eventOccurrence);
                    _send(new ArrivalSignal());
                }
                _endIsolation();
            }
        } // startBehavior

        private readonly ObjectActivation_EventDispatchLoopExecution behavior;

        public void _send(ArrivalSignal signal)
        {
            behavior._send(signal);
        }

        public void _startObjectBehavior()
        {
            behavior._startObjectBehavior();
        }

        public static void _endIsolation()
        {
            Debug.Println("[_endIsolation] End isolation.");
        }

        public static void _beginIsolation()
        {
            Debug.Println("[_beginIsolation] Begin isolation.");
        }
    } // ObjectActivation
}
