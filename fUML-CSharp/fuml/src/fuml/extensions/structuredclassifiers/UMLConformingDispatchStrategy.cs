using uml.classification;
using uml.commonstructure;

namespace fuml.extensions.structuredclassifiers
{
    public class UMLConformingDispatchStrategy : SignatureBasedDispatchStrategy
    {
        public override bool OperationsMatch(
        Operation ownedOperation,
        Operation baseOperation)
        {
            // Check if the owned operation is equal to or overrides the base operation.
            // In this context, an owned operation overrides a base operation if:
            //  - they have the same number of owned parameters and for each parameter the following holds:
            //      - direction, ordering and uniqueness are the same
            //      - the corresponding types are covariant, contravariant or invariant
            //      - the multiplicities are compatible depending on the parameter direction

            bool matches;
            if (ownedOperation == baseOperation)
            {
                matches = true;
            }
            else
            {
                matches = IsConsistentWith(ownedOperation, baseOperation);
            }

            return matches;
        } // operationsMatch

        public bool IsConsistentWith(
        Operation ownedOperation,
        Operation baseOperation)
        {
            bool isConsistentWith;

            // NOTE: UML specification implies first checking if the context of baseOperation is valid
            // (i.e. is a direct or indirect base class of the owner of ownedOperation).
            // Here this is already implicitely done by only traversing base classes of ownedOperation's owner

            List<Parameter> ownedOperationParameters = ownedOperation.ownedParameter;
            List<Parameter> baseOperationParameters = baseOperation.ownedParameter;

            isConsistentWith = baseOperationParameters.Count == ownedOperationParameters.Count;

            for (int i = 0; isConsistentWith == true && i < ownedOperationParameters.Count; i++)
            {
                Parameter redefiningParameter = ownedOperationParameters.ElementAt(i);
                Parameter redefinedParameter = baseOperationParameters.ElementAt(i);

                isConsistentWith = isConsistentWith && (redefinedParameter.multiplicityElement.isUnique == redefiningParameter.multiplicityElement.isUnique);
                isConsistentWith = isConsistentWith && (redefinedParameter.multiplicityElement.isOrdered == redefiningParameter.multiplicityElement.isOrdered);
                isConsistentWith = isConsistentWith && (redefinedParameter.direction == redefiningParameter.direction);

                Classifier redefiningParameterType = (Classifier)redefiningParameter.type!;
                Classifier redefinedParameterType = (Classifier)redefinedParameter.type!;
                isConsistentWith = isConsistentWith && (ConformsTo(redefiningParameterType, redefinedParameterType) || ConformsTo(redefinedParameterType, redefiningParameterType));

                if(redefinedParameter.direction == ParameterDirectionKind.inout)
                {
                    isConsistentWith = isConsistentWith && 
                                        (
                                            CompatibleWith(redefiningParameter.multiplicityElement, redefinedParameter.multiplicityElement) &&
                                            CompatibleWith(redefinedParameter.multiplicityElement, redefiningParameter.multiplicityElement)
                                        );
                }
                else if (redefinedParameter.direction == ParameterDirectionKind.in_)
                {
                    isConsistentWith = isConsistentWith && CompatibleWith(redefiningParameter.multiplicityElement, redefinedParameter.multiplicityElement);
                }
                else // i.e. if((redefinedParameter.direction == ParameterDirectionKind.out_) || (redefinedParameter.direction == ParameterDirectionKind.return_))
                {
                    isConsistentWith = isConsistentWith && CompatibleWith(redefinedParameter.multiplicityElement, redefiningParameter.multiplicityElement);
                }
            }

            return isConsistentWith;
        }

        public bool ConformsTo(Classifier type, Classifier otherType)
        {
            bool conformsTo;

            if(type == otherType)
            {
                conformsTo = true;
            }
            else
            {
                conformsTo = IsSpecializationOf(type, otherType);
            }

            return conformsTo;
        }

        public bool CompatibleWith(MultiplicityElement self, MultiplicityElement other)
        {
            bool compatibleWith = (other.lower <= self.lower) && ((other.upper.naturalValue == -1) || (self.upper.naturalValue <= other.upper.naturalValue));

            return compatibleWith;
        }
    } // UMLConformingDispatchStrategy
}
