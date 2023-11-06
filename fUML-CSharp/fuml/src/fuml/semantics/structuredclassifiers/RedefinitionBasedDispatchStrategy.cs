using fuml.syntax.classification;
using fuml.syntax.commonbehavior;
using fuml.syntax.commonstructure;
using fuml.syntax.structuredclassifiers;

namespace fuml.semantics.structuredclassifiers
{
    public class RedefinitionBasedDispatchStrategy : DispatchStrategy
    {
		public override Behavior GetMethod(
		Object_ object_,
		Operation operation)
		{
			// Find the member operation of a type of the given object_ that
			// is the same as or a redefinition of the given operation. Then
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
				List<NamedElement> members = type.member;
				int j = 1;
				while (method == null & j <= members.Count)
				{
					NamedElement member = members.ElementAt(j - 1);
                    if (member is Operation memberOperation)
                    {
                        if (OperationsMatch(memberOperation, operation))
                        {
                            if (memberOperation.method.Count == 0)
                            {
                                method = base.GetMethod(object_, memberOperation);
                            }
                            else
                            {
                                method = memberOperation.method.ElementAt(0);
                            }
                        }
                    }
                    j++;
				}
				i++;
			}

			return method!;
		} // getMethod

		public bool OperationsMatch(
				fuml.syntax.classification.Operation ownedOperation,
				fuml.syntax.classification.Operation baseOperation)
		{
			// Check if the owned operation is equal to or a redefinition (directly
			// or indirectly) of the base operation.

			bool matches = false;
			if (ownedOperation == baseOperation)
			{
				matches = true;
			}
			else
			{
				int i = 1;
				while (!matches & i <= ownedOperation.redefinedOperation.Count)
				{
					matches = OperationsMatch(
							ownedOperation.redefinedOperation.ElementAt(i - 1),
							baseOperation);
					i++;
				}
			}

			return matches;
		} // operationsMatch
	} // RedefinitionBasedDispatchStrategy
}
