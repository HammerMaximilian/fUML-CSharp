namespace fuml.semantics.commonbehavior
{
    public abstract class EventAccepter : FumlObject
    { 
        public abstract void accept(EventOccurrence eventOccurrence);

        public abstract bool match(EventOccurrence eventOccurrence);
    } // EventAccepter
}
