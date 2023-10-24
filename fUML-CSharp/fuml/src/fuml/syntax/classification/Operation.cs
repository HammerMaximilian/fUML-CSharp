using fuml.syntax.commonbehavior;
using fuml.syntax.structuredclassifiers;
using UMLPrimitiveTypes;

namespace fuml.syntax.classification
{
    public class Operation : BehavioralFeature
    {
        public bool isQuery = false;
        public bool isOrdered = false;
        public bool isUnique = true;
        public int lower = 0;
        public UnlimitedNatural? upper = null;
        public Class_? class_ = null;
        public List<Operation> redefinedOperation = new();
        public commonstructure.Type? type = null;
        public new List<Parameter> ownedParameter = new();

        public void setIsQuery(bool isQuery)
        {
            this.isQuery = isQuery;
        } // setIsQuery

        public override void addOwnedParameter(
                Parameter ownedParameter)
        {
            if (ownedParameter is null)
            {
                throw new ArgumentNullException(nameof(ownedParameter));
            }

            base.addOwnedParameter(ownedParameter);
            this.ownedParameter.Add(ownedParameter);
            ownedParameter._setOperation(this);

            if (ownedParameter.direction == ParameterDirectionKind.return_)
            {
                isOrdered = ownedParameter.multiplicityElement.isOrdered;
                isUnique = ownedParameter.multiplicityElement.isUnique;
                lower = ownedParameter.multiplicityElement.lower;
                upper = ownedParameter.multiplicityElement.upper;
                type = ownedParameter.type;
            }
        } // addOwnedParameter

        public void addRedefinedOperation(
                Operation redefinedOperation)
        {
            if (redefinedOperation is null)
            {
                throw new ArgumentNullException(nameof(redefinedOperation));
            }

            addRedefinedElement(redefinedOperation);
            this.redefinedOperation.Add(redefinedOperation);
        } // addRedefinedOperation

        public override void addMethod(
                Behavior method)
        {
            if (method is null)
            {
                throw new ArgumentNullException(nameof(method));
            }
            // Note: To have a method, an operation must be owned by a class. The
            // method must be an owned behavior of the class.

            this.method.Add(method);
            method._setSpecification(this);

        } // addMethod

        public void _setClass(Class_ class_)
        {
            this.class_ = class_ ?? throw new ArgumentNullException(nameof(class_));
        } // _setClass
    }
}
