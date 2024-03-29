﻿namespace fuml.semantics.commonbehavior
{
    public abstract class EventAccepter
    { 
        public abstract void Accept(EventOccurrence eventOccurrence);

        public abstract bool Match(EventOccurrence eventOccurrence);
    } // EventAccepter
}
