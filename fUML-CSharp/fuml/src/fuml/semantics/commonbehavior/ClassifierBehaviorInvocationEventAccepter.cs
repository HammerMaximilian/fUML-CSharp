﻿using fuml.semantics.structuredclassifiers;
using uml.commonbehavior;
using uml.structuredclassifiers;

namespace fuml.semantics.commonbehavior
{
    public class ClassifierBehaviorInvocationEventAccepter : EventAccepter
    {
        public Execution? execution = null;
        public Class_? classifier = null;
        public ObjectActivation? objectActivation = null;

        public void InvokeBehavior(
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
                execution = object_?.locus?.factory?.CreateExecution(
                        classifier.classifierBehavior!, object_);
            }

            if (inputs is not null)
            {
                foreach (ParameterValue input in inputs)
                {
                    execution?.SetParameterValue(input);
                }
            }

            objectActivation?.Register(this);

        }

        public override bool Match(EventOccurrence eventOccurrence)
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

        public override void Accept(EventOccurrence eventOccurrence)
        {
            // Accept an invocation event occurrence. Execute the execution of this
            // classifier behavior invocation event accepter.

            if (eventOccurrence is InvocationEventOccurrence)
            {
                execution?.Execute();
            }
        }

        public void Terminate()
        {
            // Terminate the associated execution.
            // If the execution is not itself the object of the object activation,
            // then destroy it.

            execution?.Terminate();

            if (execution != objectActivation?.object_)
            {
                execution?.Destroy();
            }

        } // terminate
    } // ClassifierBehaviorInvocationEventAccepter
}
