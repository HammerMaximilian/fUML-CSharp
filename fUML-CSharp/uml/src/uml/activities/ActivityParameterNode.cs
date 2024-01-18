using uml.classification;

namespace uml.activities
{
    public class ActivityParameterNode : ObjectNode
    {
        public Parameter? parameter = null;

        public void SetParameter(Parameter parameter)
        {
            this.parameter = parameter ?? throw new ArgumentNullException(nameof(parameter));
        } // setParameter
    } // ActivityParameterNode
}
