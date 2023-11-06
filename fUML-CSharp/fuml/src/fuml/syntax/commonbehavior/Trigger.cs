﻿using fuml.syntax.commonstructure;

namespace fuml.syntax.commonbehavior
{
    public class Trigger : NamedElement
    {
        public Event? event_ = null;

        public void SetEvent(Event event_) 
        {
            this.event_ = event_;
        } // setEvent
    }
}
