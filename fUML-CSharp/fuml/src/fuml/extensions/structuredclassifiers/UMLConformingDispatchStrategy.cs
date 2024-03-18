using fuml.semantics.structuredclassifiers;
using uml.classification;
using uml.commonstructure;

namespace fuml.extensions.structuredclassifiers
{
    public class UMLConformingDispatchStrategy : RedefinitionBasedDispatchStrategy
    {
        public override bool OperationsMatch(
        Operation ownedOperation,
        Operation baseOperation)
        {
            // Check if the owned operation is equal to or overrides the base operation.
            // In this context, an owned operation overrides a base operation if:
            //  - base operation is directly or indirectly redefined by owned operation
            //  - the class that owns base operation is equal to or a base class of the class that owns owned operation
            //  - they have the same number of owned parameters and for each parameter the following holds:
            //      - direction, ordering and uniqueness are the same
            //      - the corresponding types are covariant, contravariant or invariant
            //      - the multiplicities are compatible depending on the parameter direction

            bool matches = base.OperationsMatch(ownedOperation, baseOperation);
            if (matches)
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

            isConsistentWith = ConformsTo(ownedOperation.class_!, baseOperation.class_!);

            List<Parameter> ownedOperationParameters = ownedOperation.ownedParameter;
            List<Parameter> baseOperationParameters = baseOperation.ownedParameter;

            isConsistentWith = isConsistentWith && (baseOperationParameters.Count == ownedOperationParameters.Count);

            for (int i = 0; isConsistentWith == true && i < ownedOperationParameters.Count; i++)
            {
                Parameter redefiningParameter = ownedOperationParameters.ElementAt(i);
                Parameter redefinedParameter = baseOperationParameters.ElementAt(i);

                isConsistentWith = isConsistentWith && (redefiningParameter.multiplicityElement.isUnique == redefinedParameter.multiplicityElement.isUnique);
                isConsistentWith = isConsistentWith && (redefiningParameter.multiplicityElement.isOrdered == redefinedParameter.multiplicityElement.isOrdered);
                isConsistentWith = isConsistentWith && (redefiningParameter.direction == redefinedParameter.direction);

                Classifier redefiningParameterType = (Classifier)redefiningParameter.type!;
                Classifier redefinedParameterType = (Classifier)redefinedParameter.type!;
                isConsistentWith = isConsistentWith && (ConformsTo(redefiningParameterType, redefinedParameterType) || ConformsTo(redefinedParameterType, redefiningParameterType));

                if (redefinedParameter.direction == ParameterDirectionKind.inout)
                {
                    isConsistentWith = isConsistentWith &&
                                        (
                                            CompatibleWith(redefiningParameter.multiplicityElement, redefinedParameter.multiplicityElement) &&
                                            CompatibleWith(redefinedParameter.multiplicityElement, redefiningParameter.multiplicityElement)
                                        );
                }
                else if (redefinedParameter.direction == ParameterDirectionKind.in_)
                {
                    isConsistentWith = isConsistentWith && CompatibleWith(redefinedParameter.multiplicityElement, redefiningParameter.multiplicityElement);
                }
                else // i.e. if((redefinedParameter.direction == ParameterDirectionKind.out_) || (redefinedParameter.direction == ParameterDirectionKind.return_))
                {
                    isConsistentWith = isConsistentWith && CompatibleWith(redefiningParameter.multiplicityElement, redefinedParameter.multiplicityElement);
                }
            }

            return isConsistentWith;
        }

        public bool ConformsTo(Classifier type, Classifier otherType)
        {
            bool conformsTo = false;

            if (type == otherType)
            {
                conformsTo = true;
            }
            else
            {
                int i = 1;
                while (conformsTo is false && i <= type.general.Count)
                {
                    Classifier general = type.general.ElementAt(i);
                    conformsTo = ConformsTo(general, otherType);
                }
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
