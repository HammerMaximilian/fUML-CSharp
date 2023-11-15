using uml.values;

namespace uml.classification
{
    public class InstanceValue : ValueSpecification
    {
        public InstanceSpecification? instance = null;

        public void SetInstance(
                InstanceSpecification instance)
        {
            this.instance = instance ?? throw new ArgumentNullException(nameof(instance));
        } // setInstance

    } // InstanceValue
}
