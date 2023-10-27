using fuml.semantics.structuredclassifiers;
using fuml.syntax.commonbehavior;
using fuml.syntax.structuredclassifiers;

namespace fuml.semantics.commonbehavior
{
    public class ClassifierBehaviorInvocationEventAccepter : EventAccepter
    {
        public Execution? execution = null;
        public Class_? classifier = null;
        public ObjectActivation? objectActivation = null;

        public void invokeBehavior(
                Class_ classifier,
                List<ParameterValue> inputs)
        {
            // Set the classifier for this classifier behavior invocation event accepter 
            // to the given class.
            // If the given class is a behavior, set the execution to be the object
            // of the object activation of the classifier behavior execution.
            // Otherwise the class must be an active class, so get an execution
            // object for the classifier behavior for the class.
            // Set the input parameters for the execution to the given values.
            // Then register this event accepter with the object activation.

            this.classifier = classifier ?? throw new ArgumentNullException(nameof(classifier));
            Object_? object_ = objectActivation?.object_;

            if (classifier is Behavior)
            {
                execution = (Execution)object_!;
            }
            else
            {
                execution = object_?.locus?.factory?.createExecution(
                        classifier.classifierBehavior!, object_);
            }

            if (inputs is not null)
            {
                foreach (ParameterValue input in inputs)
                {
                    execution.setParameterValue(input);
                }
            }

            objectActivation?.register(this);

        }

        public override bool match(EventOccurrence eventOccurrence)
        {
            // Return true if the given event occurrence is an invocation event
            // occurrence for the execution of this classifier behavior invocation
            // event accepter.

            bool matches = false;
            if (eventOccurrence is InvocationEventOccurrence invocationEventOccurrence)
            {
                matches = invocationEventOccurrence.execution == execution;
            }
            return matches;
        }

        public override void accept(EventOccurrence eventOccurrence)
        {
            // Accept an invocation event occurrence. Execute the execution of this
            // classifier behavior invocation event accepter.

            if (eventOccurrence is InvocationEventOccurrence)
            {
                execution?.execute();
            }
        }

        public void terminate()
        {
            // Terminate the associated execution.
            // If the execution is not itself the object of the object activation,
            // then destroy it.

            execution?.terminate();

            if (execution != objectActivation?.object_)
            {
                execution?.destroy();
            }

        } // terminate
    } // ClassifierBehaviorInvocationEventAccepter
}
