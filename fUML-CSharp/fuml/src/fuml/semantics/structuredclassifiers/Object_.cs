using fuml.semantics.commonbehavior;
using fuml.semantics.values;
using uml.classification;
using uml.structuredclassifiers;

namespace fuml.semantics.structuredclassifiers
{
    public partial class Object_ : ExtensionalValue
    {
        public List<Class_> types = new();
        public ObjectActivation? objectActivation = null;

        public void StartBehavior(
                Class_ classifier,
                List<ParameterValue> inputs)
        {
            // Create an object activation for this object (if one does not already
            // exist) and start its behavior(s).

            objectActivation ??= new()
            {
                object_ = this
            };

            objectActivation.StartBehavior(classifier, inputs);
        } // startBehavior

        public virtual Execution Dispatch(
                Operation operation)
        {
            // Dispatch the given operation to a method execution, using a dispatch
            // strategy.

            DispatchStrategy dispatchStrategy = (DispatchStrategy)locus?.factory?.GetStrategy("dispatch")!;

            return (dispatchStrategy is not null) ? dispatchStrategy.Dispatch(this, operation) : throw new NullReferenceException();
        } // dispatch

        public void Send(
                EventOccurrence eventOccurrence)
        {
            // If the object is active, add the given event occurrence to the event
            // pool and signal that a new event occurrence has arrived.

            objectActivation?.Send(eventOccurrence);

        } // send

        public override void Destroy()
        {
            // Stop the object activation (if any), clear all types and feature values,
            // and destroy the object as an extensional value.

            Debug.Println("[destroy] object = " + identifier);

            if (objectActivation is not null)
            {
                objectActivation.Stop();
                objectActivation = null;
            }

            types.Clear();
            featureValues.Clear();
            base.Destroy();
        } // destroy

        public void Register(
                EventAccepter accepter)
        {
            // Register the given accept event accepter to wait for a dispatched
            // signal event.

            objectActivation?.Register(accepter);
        } // register

        public void Unregister(
                EventAccepter accepter)
        {
            // Remove the given event accepter for the list of waiting event
            // accepters.

            objectActivation?.Unregister(accepter);
        } // unregister

        public override Value Copy()
        {
            // Create a new object that is a copy of this object at the same locus
            // as this object.
            // However, the new object will NOT have any object activation (i.e, its
            // classifier behaviors will not be started).

            Object_ newObject = (Object_)base.Copy();

            List<Class_> types = this.types;
            foreach (Class_ type in types)
            {
                newObject.types.Add(type);
            }

            return newObject;

        } // copy

        public override bool Equals(Value otherValue)
        {
            // Test if this object is equal to the otherValue.
            // To be equal, the otherValue must be the same object as this object.

            return this == otherValue;
        } // equals

        protected override Value New_()
        {
            // Create a new object with no type, feature values or locus.

            return new Object_();
        } // new_

        public override List<Classifier> GetTypes()
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
