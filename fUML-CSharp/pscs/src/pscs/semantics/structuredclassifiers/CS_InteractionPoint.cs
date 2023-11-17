using fuml.semantics.commonbehavior;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using pscs.semantics.commonbehavior;
using uml.classification;
using uml.structuredclassifiers;

namespace pscs.semantics.structuredclassifiers
{
    public class CS_InteractionPoint : Reference
    {
        public CS_Reference? owner = null;
        public Port? definingPort = null;

        public override void StartBehavior(Class_ classifier, List<ParameterValue> inputs)
        {
            // Overridden to do nothing
        }

        public override Execution Dispatch(Operation operation)
        {
            // Delegates dispatching to the owning object
            return owner?.DispatchIn(operation, this)!;
        }

        public override void Send(EventOccurrence eventOccurrence)
        {
            // An event occurrence that passes through a CS_InteractionPoint is
            // (if necessary) wrapped in a CS_EventOccurrence. This event occurrence
            // is then sent to the owning object.
            CS_EventOccurrence wrappingEventOccurrence;
            if (eventOccurrence is CS_EventOccurrence cS_EventOccurrence)
            {
                wrappingEventOccurrence = cS_EventOccurrence;
            }
            else
            {
                wrappingEventOccurrence = new()
                {
                    wrappedEventOccurrence = eventOccurrence
                };
            }
            wrappingEventOccurrence.interactionPoint = this;
            owner?.SendIn(wrappingEventOccurrence, this);
        }

        public override Value Copy()
        {
            // Create a new interaction point with the same referent as this interaction
            // point.
            CS_InteractionPoint newValue = (CS_InteractionPoint)base.Copy();
            newValue.referent = referent;
            return newValue;
        }

        protected override Value New_()
        {
            return new CS_InteractionPoint();
        }

        public override bool CheckAllParents(Classifier type, Classifier classifier)
        {
            // Delegates the type checking to the reference
            return referent?.CheckAllParents(type, classifier) ?? false;
        }

    } // CS_InteractionPoint
}
