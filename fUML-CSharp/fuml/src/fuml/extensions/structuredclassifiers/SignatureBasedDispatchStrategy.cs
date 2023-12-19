using fuml.semantics.structuredclassifiers;
using uml.classification;
using uml.commonbehavior;
using uml.structuredclassifiers;

namespace fuml.extensions.structuredclassifiers
{
    public class SignatureBasedDispatchStrategy : DispatchStrategy
    {
        public override Behavior GetMethod(
        Object_ object_,
        Operation operation)
        {
            // Find the member operation of a type of the given object_ that
            // is the same as or overrides the given operation. Then
            // return the method of that operation, if it has one, otherwise
            // return a CallEventBehavior as the effective method for the
            // matching operation.
            // [If there is more than one type with a matching operation, then
            // the first one is arbitrarily chosen.]

            Behavior? method = null;
            int i = 1;
            while (method == null & i <= object_.types.Count)
            {
                Class_ type = object_.types.ElementAt(i - 1);
                method = GetMethod(type, operation);
                i++;
            }

            return method!;
        } // getMethod

        public Behavior GetMethod(Class_ type, Operation operation)
        {
            Behavior? method = null;
            List<Operation> ownedOperations = type.ownedOperation;

            // First, check if type owns or overrides the given operation.
            int i = 1;
            while (method is null & i <= ownedOperations.Count)
            {
                Operation ownedOperation = ownedOperations.ElementAt(i - 1);

                if(OperationsMatch(ownedOperation, operation))
                {
                    if (ownedOperation.method.Count == 0)
                    {
                        method = base.GetMethod(null!, ownedOperation);
                    }
                    else
                    {
                        method = ownedOperation.method.ElementAt(0);
                    }
                }
            }

            // If type does not own or override the given operation directly,
            // check all of it's base classes.
            if(method is null)
            {
                List<Classifier> general = type.general;

                i = 1;
                while(method is null & i <= general.Count)
                {
                    if(general.ElementAt(i-1) is Class_ baseClass)
                    {
                        method = GetMethod(baseClass, operation);
                    }
                }
            }

            return method!;
        }

        public virtual bool OperationsMatch(
        Operation ownedOperation,
        Operation baseOperation)
        {
            // Check if the owned operation is equal to or overrides the base operation.
            // In this context, an owned operation overrides a base operation
            // if it has the same name and signature.

            bool matches;
            if (ownedOperation == baseOperation)
            {
                matches = true;
            }
            else
            {
                matches = baseOperation.name.Equals(ownedOperation.name);
                matches = matches && (baseOperation.ownedParameter.Count == ownedOperation.ownedParameter.Count);
                List<Parameter> ownedOperationParameters = ownedOperation.ownedParameter;
                List<Parameter> baseOperationParameters = baseOperation.ownedParameter;
                for (int i = 0; matches == true && i < ownedOperationParameters.Count; i++)
                {
                    Parameter ownedParameter = ownedOperationParameters.ElementAt(i);
                    Parameter baseParameter = baseOperationParameters.ElementAt(i);

                    if(ownedParameter.direction == ParameterDirectionKind.return_)
                    {
                        // NOTE: In this implementation, return types may be covariant classifiers.
                        if (ownedParameter.type != baseParameter.type)
                        {

                            matches = ownedParameter.type is Classifier ownedOperationReturnType && 
                                    baseParameter.type is Classifier baseOperationReturnType &&
                                    IsCovariant(ownedOperationReturnType, baseOperationReturnType);
                        }
                        else
                        {
                            matches = true;
                        }
                    }
                    else
                    {
                        matches = ownedParameter.type == baseParameter.type;
                    }
                    matches = matches && (ownedParameter.multiplicityElement.lower == baseParameter.multiplicityElement.lower);
                    matches = matches && (ownedParameter.multiplicityElement.upper == baseParameter.multiplicityElement.upper);
                    matches = matches && (ownedParameter.direction == baseParameter.direction);
                }
            }

            return matches;
        } // operationsMatch

        public bool IsCovariant(Classifier ownedOperationReturnType, Classifier baseOperationReturnType)
        {
            bool isCovariant = false;

            int i = 1;
            while (isCovariant == false && i <= ownedOperationReturnType.general.Count)
            {
                Classifier baseType = ownedOperationReturnType.general.ElementAt(i - 1);
                isCovariant = baseOperationReturnType == baseType;

                if(!isCovariant)
                {
                    isCovariant = IsCovariant(baseType, baseOperationReturnType);
                }

                i++;
            }

            return isCovariant;
        } // IsCovariant
    } // SignatureBasedDispatchStrategy
}
