using fuml.syntax.commonbehavior;

namespace fuml.syntax.classification
{
    public abstract class BehavioralFeature : Feature
    {
        public List<Parameter> ownedParameter = new();
        public bool isAbstract = false;
        public List<Behavior> method = new();
        public CallConcurrencyKind concurrency = CallConcurrencyKind.sequential;
        public List<Type> raisedException = new();

        public void SetIsAbstract(bool isAbstract)
        {
            this.isAbstract = isAbstract;
        } // setIsAbstract

        virtual public void AddOwnedParameter(
                Parameter ownedParameter)
        {
            if (ownedParameter is null)
            {
                throw new ArgumentNullException(nameof(ownedParameter));
            }
            // this.addOwnedMember(ownedParameter); [Note: BehavioralFeature is not
            // a Namespace in fUML, to avoid multiple inheritance.]

            this.ownedParameter.Add(ownedParameter);
        } // addOwnedParameter

        virtual public void AddMethod(
                Behavior method)
        {
            if (method is null)
            {
                throw new ArgumentNullException(nameof(method));
            }

            method._setSpecification(this);
            this.method.Add(method);
        } // addMethod

        public void AddRaisedException(Type raisedException)
        {
            if (raisedException is null)
            {
                throw new ArgumentNullException(nameof(raisedException));
            }

            this.raisedException.Add(raisedException);
        } // addRaisedException
    } // BehavioralFeature
}
