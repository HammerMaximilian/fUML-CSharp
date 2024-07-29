using fuml.semantics.commonbehavior;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using uml.classification;
using uml.structuredclassifiers;

namespace pssm.semantics.statemachines
{
    public class DoActivityContextObject : Object_
    {
        // The state activation that initiated the execution of the
        // do activity behavior
        public StateActivation? owner = null;

        // The context of the state-machine that lead to the invocation of the
        // doActivity behavior.
        public Object_? context = null;

        public Object_ GetContext()
        {
            throw new NotImplementedException();
        }

        public void Initialize(Object_ context)
        {
        }

        public override void StartBehavior(Class_ classifier, List<ParameterValue> inputs)
        {
        }

        public override void Register(EventAccepter accepter)
        {
        }

        public override FeatureValue GetFeatureValue(StructuralFeature feature)
        {
            throw new NotImplementedException();
        }

        public override void SetFeatureValue(StructuralFeature feature, List<Value> values, int position)
        {
        }

        public override Execution Dispatch(Operation operation)
        {
            throw new NotImplementedException();
        }

        public override void Send(EventOccurrence eventOccurrence)
        {
        }

        public override void Destroy()
        {
        }

        protected void UnregisterFromContext(EventAccepter encapsulatedAccepter)
        {
        }
    } // DoActivityContextObject
}
