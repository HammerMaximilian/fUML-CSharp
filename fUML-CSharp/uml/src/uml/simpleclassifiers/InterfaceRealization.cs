using uml.commonbehavior;
using uml.commonstructure;

namespace uml.simpleclassifiers
{
    public class InterfaceRealization : Realization // PSCS-specific
    {
        public Interface? contract = null;
        public BehavioredClassifier? implementingClassifier = null;

        public void SetContract(Interface contract)
        { 
            this.contract = contract ?? throw new ArgumentNullException(nameof(contract));
            AddSupplier(contract);
        }

        public void _setImplementingClassifier(BehavioredClassifier implementingClassifier)
        {
            this.implementingClassifier = implementingClassifier ?? throw new ArgumentNullException(nameof (implementingClassifier));
        }

        } // InterfaceRealization
}
