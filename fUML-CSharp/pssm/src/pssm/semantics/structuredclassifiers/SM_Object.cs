using fuml.semantics.commonbehavior;
using pscs.semantics.structuredclassifiers;
using pssm.semantics.commonbehavior;
using uml.structuredclassifiers;

namespace pssm.semantics.structuredclassifiers
{
    public class SM_Object : CS_Object
    {
        public override void StartBehavior(Class_ classifier, List<ParameterValue> inputs)
        {
            // The behavior captured here is almost identical to the one provide by Object_.
            // Instead of using a simple ObjectActivation we use a StateMachineObjectActivation.
            // This specialized kind of ObjectActivation allows the registering of completion events.
            objectActivation ??= new SM_ObjectActivation
            {
                object_ = this
            };
            objectActivation.StartBehavior(classifier, inputs);
        }
        public override void Destroy()
        {
            // In addition to realize the normal process of stopping the object activation
            // as well as removing the current object from the locus, this destruction phase
            // also implies removal of all events remaining in the pool. This prevents the
            // dispatch loop to actually get the next event (even if at this step there is no
            // chance to match an accepter) whereas the current object is not anymore registered.
            // in the Locus.
            objectActivation?.eventPool.Clear();
            base.Destroy();
        }
    } // SM_Object
}
