﻿using uml.classification;
using uml.commonstructure;

namespace uml.actions
{
    public class LinkEndData : Element
    {
        public InputPin? value = null;
        public Property? end = null;

        public void SetEnd(Property end)
        {
            this.end = end ?? throw new ArgumentNullException(nameof(end));
        } // setEnd

        public void SetValue(InputPin value)
        {
            this.value = value ?? throw new ArgumentNullException(nameof(value));
        } // setValue
    } // LinkEndData
}
