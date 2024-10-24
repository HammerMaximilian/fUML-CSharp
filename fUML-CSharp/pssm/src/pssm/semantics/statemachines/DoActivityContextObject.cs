using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using pssm.semantics.commonbehavior;
using uml.classification;
using uml.structuredclassifiers;

namespace pssm.semantics.statemachines
{
    public class DoActivityContextObject : Object_
    {
        // The state activation that initiated the execution of the
        // do activity behavior
        public StateActivation? owner = null;

        // The context of the state-machine that lead to the invocation of the
        // doActivity behavior.
        public Object_? context = null;

        public void Initialize(Object_ context)
        {
            // Context object of this DoActivityContextObject is the context
            // of the state machine which has invoked the doActivity.
            if (context != null)
            {
                this.context = context;
            }
        }

        public override void StartBehavior(Class_ classifier, List<ParameterValue> inputs)
        {
            // Starts the behavior of a DoActivityContextObject. It behaves the
            // same than in fUML except that for object is associated to a specific
            // type of object activation: DoActivityContextObjectActivation
            if (objectActivation == null)
            {
                objectActivation = new DoActivityContextObjectActivation();
                objectActivation.object_ = this;
            }
            objectActivation.StartBehavior(classifier, inputs);
        }

        public override void Register(EventAccepter accepter)
        {
            // When the executing doActivity registers an accepter it searches through the deferred event
            // pool of the object activation associated to the state-machine context.
            // 1. If the accepter being registered matches one of the deferred events then this event is
            //    transferred into the event pool of the doActivity object activation. This implies the
            //    event will be dispatched in a RTC step performed by the doActivity object activation. 
            // 2. If the accepter being registered does not match one of the deferred events then this latter
            //    is wrapped in another accepter which is registered by the state machine context object activation.
            //    This is realized in order to guarantee that the doActivity will have a chance to match an event
            //    received by the state-machine context object.
            base.Register(accepter);
            SM_ObjectActivation contextObjectActivation = (SM_ObjectActivation)context?.objectActivation!;
            int i = 1;
            DeferredEventOccurrence? matchedDeferredEvent = null;
            while (matchedDeferredEvent == null && i <= contextObjectActivation.deferredEventPool.Count)
            {
                DeferredEventOccurrence eventOccurrence = contextObjectActivation.deferredEventPool.ElementAt(i - 1);
                if (owner == eventOccurrence.constrainingStateActivation && accepter.Match(eventOccurrence.deferredEventOccurrence!))
                {
                    matchedDeferredEvent = eventOccurrence;
                }
                i++;
            }
            if (matchedDeferredEvent == null)
            {
                DoActivityExecutionEventAccepter encapsulatingAccepter = new DoActivityExecutionEventAccepter();
                encapsulatingAccepter.encapsulatedAccepter = accepter;
                encapsulatingAccepter.context = this;
                context!.Register(encapsulatingAccepter);
            }
            else
            {
                contextObjectActivation.deferredEventPool.Remove(matchedDeferredEvent);
                objectActivation!.eventPool.Add(matchedDeferredEvent.deferredEventOccurrence!);
                objectActivation._send(new ArrivalSignal());
            }
        }

        public override FeatureValue GetFeatureValue(StructuralFeature feature)
        {
            // Delegate read of a particular feature to the state-machine context
            FeatureValue? featureValue = null;
            if (context != null)
            {
                featureValue = context.GetFeatureValue(feature);
            }
            return featureValue!;
        }

        public override void SetFeatureValue(StructuralFeature feature, List<Value> values, int position)
        {
            // Delegate write of particular feature to the state-machine context
            if (context != null)
            {
                context.SetFeatureValue(feature, values, position);
            }
        }

        public override Execution Dispatch(Operation operation)
        {
            // Delegate operation call to the state-machine context
            Execution? execution = null;
            if (context != null)
            {
                execution = context.Dispatch(operation);
            }
            return execution!;
        }

        public override void Send(EventOccurrence eventOccurrence)
        {
            // Delegate the reception of a signal to the state-machine context
            if (context != null)
            {
                context.Send(eventOccurrence);
            }
        }

        public override void Destroy()
        {
            // When destroyed in addition to the usual behavior, the do activity context object
            // has to remove the encapsulating accepters it may have registered.
            foreach (EventAccepter waitingEventAccepter in objectActivation!.waitingEventAccepters)
            {
                UnregisterFromContext(waitingEventAccepter);
            }
            base.Destroy();
        }

        protected void UnregisterFromContext(EventAccepter encapsulatedAccepter)
        {
            // Unregister in the context of this do activity context the encapsulating
            // event accepter.
            ObjectActivation contextObjectActivation = context?.objectActivation!;
            if (contextObjectActivation != null)
            {
                DoActivityExecutionEventAccepter? encapsulatingAccepter = null;
                int i = 0;
                while (encapsulatingAccepter == null && i < contextObjectActivation.waitingEventAccepters.Count)
                {
                    EventAccepter currentAccepter = contextObjectActivation.waitingEventAccepters.ElementAt(i);
                    if (currentAccepter is DoActivityExecutionEventAccepter doActivityExecutionEventAccepter
                        && doActivityExecutionEventAccepter.encapsulatedAccepter == encapsulatedAccepter)
                    {
                        encapsulatingAccepter = (DoActivityExecutionEventAccepter)currentAccepter;
                    }
                    i++;
                }
                if (encapsulatingAccepter != null)
                {
                    contextObjectActivation.Unregister(encapsulatingAccepter);
                }
            }
        }
    } // DoActivityContextObject
}
