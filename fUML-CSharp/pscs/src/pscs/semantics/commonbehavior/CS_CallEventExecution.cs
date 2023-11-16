using fuml.semantics.actions;
using fuml.semantics.commonbehavior;
using fuml.semantics.values;
using pscs.semantics.structuredclassifiers;

namespace pscs.semantics.commonbehavior
{
    public class CS_CallEventExecution : CallEventExecution
    {
        public CS_InteractionPoint? interactionPoint = null;

        public override EventOccurrence CreateEventOccurrence()
        { throw new NotImplementedException(); }

        protected override Value New_()
        {
            // Create a new call event execution.
            return new CS_CallEventExecution();
        }

        public override Value Copy()
        {
            // Create a new call event execution that is a copy of this execution, no
            // referenced interaction point.
            CS_CallEventExecution copy = (CS_CallEventExecution)base.Copy();
            copy.interactionPoint = null;
            return copy;
        }
    } // CS_CallEventExecution
}
