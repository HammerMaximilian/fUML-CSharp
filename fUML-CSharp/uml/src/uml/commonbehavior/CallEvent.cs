﻿using uml.classification;

namespace uml.commonbehavior
{
    public class CallEvent : Event
    {
        public Operation? operation = null;

        public void SetOperation(Operation operation)
        {
            this.operation = operation ?? throw new ArgumentNullException(nameof(operation));
        }
    } // CallEvent
}
