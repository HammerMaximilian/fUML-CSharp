using fuml.semantics.structuredclassifiers;
using uml.classification;
using uml.simpleclassifiers;

namespace pscs.semantics.structuredclassifiers
{
    public class CS_DispatchOperationOfInterfaceStrategy : RedefinitionBasedDispatchStrategy
    {
        public override bool OperationsMatch(Operation ownedOperation, Operation baseOperation)
        {
            // Override operationsMatch, in the case where baseOperation belongs
            // to an Interface.
            // In this case, ownedOperation matches baseOperation if it has the same name and signature
            // Otherwise, behaves like fUML RedefinitionBasedDispatchStrategy
            bool matches;
            if (baseOperation.namespace_ is Interface)
            {
                matches = baseOperation.name.Equals(ownedOperation.name);
                matches = matches && (baseOperation.ownedParameter.Count == ownedOperation.ownedParameter.Count);
                List<Parameter> ownedOperationParameters = ownedOperation.ownedParameter;
                List<Parameter> baseOperationParameters = baseOperation.ownedParameter;
                for (int i = 0; matches == true && i < ownedOperationParameters.Count; i++)
                {
                    Parameter ownedParameter = ownedOperationParameters.ElementAt(i);
                    Parameter baseParameter = baseOperationParameters.ElementAt(i);
                    matches = ownedParameter.type == baseParameter.type;
                    matches = matches && (ownedParameter.multiplicityElement.lower == baseParameter.multiplicityElement.lower);
                    matches = matches && (ownedParameter.multiplicityElement.upper == baseParameter.multiplicityElement.upper);
                    matches = matches && (ownedParameter.direction == baseParameter.direction);
                }
            }
            else
            {
                matches = base.OperationsMatch(ownedOperation, baseOperation);
            }
            return matches;
        }
    } // CS_DispatchOperationOfInterfaceStrategy
}
