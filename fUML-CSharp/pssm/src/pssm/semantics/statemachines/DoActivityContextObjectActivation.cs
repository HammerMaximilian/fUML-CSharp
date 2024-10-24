using fuml.semantics.commonbehavior;
using uml.commonbehavior;
using uml.structuredclassifiers;

namespace pssm.semantics.statemachines
{
    public class DoActivityContextObjectActivation : ObjectActivation
    {
        public override void DispatchNextEvent()
        {
			// The dispatching behaves exactly the same at it was specified in fUML.
			// In addition to this behavior the dispatch sequence of an object activation
			// for a DoActivityContextObject has the capacity to notify the state having
			// triggered if the executed doActivity has completed. The completion of a
			// do activity is determined based on the absence of any registered event
			// accepter after the current step.
			base.DispatchNextEvent();
			if (waitingEventAccepters.Count == 0)
			{
				DoActivityContextObject doActivityObject = (DoActivityContextObject)object_!;
				if (doActivityObject.owner != null)
				{
					doActivityObject.owner.isDoActivityCompleted = true;
					if (doActivityObject.owner.HasCompleted())
					{
						doActivityObject.owner.Complete();
					}
				}
			}
		}

        public override void StartBehavior(Class_ classifier, List<ParameterValue> inputs)
        {
			// The expected classifier is the doActivity behavior. The doActivity
			// behavior is executed as if it was the classifier of a class typing
			// the doActivity context object. It only exists one doActivity executed
			// as a classifier behavior for a DoActivityContextObject.
			if (classifier != null && classifier is Behavior behavior && !classifierBehaviorInvocations.Any()){
				ClassifierBehaviorInvocationEventAccepter newInvocation = new();
				newInvocation.objectActivation = this;
				newInvocation.classifier = classifier;
				Execution doActivityExecution = object_!.locus?.factory?.CreateExecution(behavior, object_!)!;
				if (inputs != null)
				{
					foreach (ParameterValue input in inputs)
					{
						doActivityExecution.SetParameterValue(input);
					}
				}
				newInvocation.execution = doActivityExecution;
				classifierBehaviorInvocations.Add(newInvocation);
				Register(newInvocation);
				InvocationEventOccurrence invocationEventOccurrence = new();
				invocationEventOccurrence.execution = newInvocation.execution;
				eventPool.Add(invocationEventOccurrence);
				_send(new ArrivalSignal());
			}
		}
    } // DoActivityContextObjectActivation
}
