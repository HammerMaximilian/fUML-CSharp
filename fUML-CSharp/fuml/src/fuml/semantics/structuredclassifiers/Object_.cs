using fuml.semantics.commonbehavior;
using fuml.semantics.values;
using fuml.syntax.classification;
using fuml.syntax.structuredclassifiers;
using System;

namespace fuml.semantics.structuredclassifiers
{
    public class Object_ : ExtensionalValue
    {
        public List<Class_> types = new();
        public ObjectActivation? objectActivation = null;

        public void startBehavior(
                Class_ classifier,
                List<ParameterValue> inputs)
        {
            // Create an object activation for this object (if one does not already
            // exist) and start its behavior(s).

            if (objectActivation is null)
            {
                objectActivation = new();
                objectActivation.object_ = this;
            }

            objectActivation.startBehavior(classifier, inputs);
        } // startBehavior

        public Execution dispatch(
                Operation operation)
        {
            // Dispatch the given operation to a method execution, using a dispatch
            // strategy.

            DispatchStrategy dispatchStrategy = (DispatchStrategy)locus?.factory?.getStrategy("dispatch")!;

            return (dispatchStrategy is not null) ? dispatchStrategy.dispatch(this, operation) : throw new NullReferenceException();
        } // dispatch

        public void send(
                EventOccurrence eventOccurrence)
        {
            // If the object is active, add the given event occurrence to the event
            // pool and signal that a new event occurrence has arrived.

            if (objectActivation is not null)
            {
                objectActivation.send(eventOccurrence);
            }

        } // send

        public override void destroy()
        {
            // Stop the object activation (if any), clear all types and feature values,
            // and destroy the object as an extensional value.

            Debug.println("[destroy] object = " + identifier);

            if (objectActivation is not null)
            {
                objectActivation.stop();
                objectActivation = null;
            }

            types.Clear();
            featureValues.Clear();
            base.destroy();
        } // destroy

        public void register(
                EventAccepter accepter)
        {
            // Register the given accept event accepter to wait for a dispatched
            // signal event.

            if (objectActivation is not null)
            {
                objectActivation.register(accepter);
            }
        } // register

        public void unregister(
                EventAccepter accepter)
        {
            // Remove the given event accepter for the list of waiting event
            // accepters.

            if (objectActivation is not null)
            {
                objectActivation.unregister(accepter);
            }
        } // unregister

        public override Value copy()
        {
            // Create a new object that is a copy of this object at the same locus
            // as this object.
            // However, the new object will NOT have any object activation (i.e, its
            // classifier behaviors will not be started).

            Object_ newObject = (Object_)base.copy();

            List<Class_> types = this.types;
            foreach (Class_ type in types)
            {
                newObject.types.Add(type);
            }

            return newObject;

        } // copy

        public override bool equals(Value otherValue)
        {
            // Test if this object is equal to the otherValue.
            // To be equal, the otherValue must be the same object as this object.

            return this == otherValue;
        } // equals

        protected override Value new_()
        {
            // Create a new object with no type, feature values or locus.

            return new Object_();
        } // new_

        public override List<Classifier> getTypes()
        {
            // Return the types of this object.

            List<Classifier> types = new();
            List<Class_> myTypes = this.types;
            foreach (Class_ type in myTypes)
            {
                types.Add(type);
            }

            return types;
        } // getTypes
    } // Object_
}
