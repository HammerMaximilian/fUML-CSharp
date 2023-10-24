using fuml.syntax.values;

namespace fuml.syntax.classification
{
    public class InstanceValue : ValueSpecification
    {
        public InstanceSpecification? instance = null;

        public void setInstance(
                InstanceSpecification instance)
        {
            this.instance = instance ?? throw new ArgumentNullException(nameof(instance));
        } // setInstance

    } // InstanceValue
}
