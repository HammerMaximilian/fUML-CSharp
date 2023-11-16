using fuml.semantics.commonbehavior;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using uml.classification;
using uml.structuredclassifiers;

namespace pscs.semantics.structuredclassifiers
{
    public class CS_Reference : Reference
    {
        /*
	     * The composite object referenced by this ReferenceToCompositeStructure. This
	     * property subsets Reference::referent.
	     */
        public CS_Object? compositeReferent = null;

        public Execution DispatchIn(Operation operation, CS_InteractionPoint interactionPoint)
        {
            // Delegates dispatching to composite referent
            return compositeReferent?.DispatchIn(operation, interactionPoint)!;
        }

        public void SendIn(EventOccurrence eventOccurrence, CS_InteractionPoint interactionPoint)
        {
            // delegates sending to composite referent
            compositeReferent?.SendIn(eventOccurrence, interactionPoint);
        }

        public void SendOut(EventOccurrence eventOccurrence, Port onPort)
        {
            // delegates sending to composite referent
            compositeReferent?.SendOut(eventOccurrence, onPort);
        }

        public Execution DispatchOut(Operation operation, Port onPort)
        {
            // delegates dispatching to composite referent
            return compositeReferent?.DispatchOut(operation, onPort)!;
        }

        public Execution DispatchIn(Operation operation, Port onPort)
        {
            // delegates dispatching to composite referent
            return compositeReferent?.DispatchIn(operation, onPort)!;
        }

        public void SendIn(EventOccurrence eventOccurrence, Port onPort)
        {
            // delegates sending to composite referent
            compositeReferent?.SendIn(eventOccurrence, onPort);
        }

        public Execution DispatchOut(Operation operation, CS_InteractionPoint interactionPoint)
        {
            // Delegates dispatching (through the interaction point, to the environment)
            // to compositeReferent
            return compositeReferent?.DispatchOut(operation, interactionPoint)!;
        }

        public void SendOut(EventOccurrence eventOccurrence, CS_InteractionPoint interactionPoint)
        {
            // Delegates sending (through the interaction point, to the environment)
            // to compositeReferent
            compositeReferent?.SendOut(eventOccurrence, interactionPoint);
        }

        public override Value Copy()
        {
            // Create a new reference with the same referent and composite referent as this
            // reference.
            CS_Reference newValue = new();
            newValue.referent = referent;
            newValue.compositeReferent = compositeReferent;
            return newValue;
        }
    } // CS_Reference
}
