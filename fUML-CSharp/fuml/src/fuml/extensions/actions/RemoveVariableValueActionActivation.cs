using fuml.extensions.activities;
using fuml.semantics.loci;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;
using uml.actions;
using uml.activities;

namespace fuml.extensions.actions
{
    public class RemoveVariableValueActionActivation : WriteVariableActionActivation
    {
        public override void DoAction()
        {
            // Get the values of the value input pin.
            // Remove values from the given variable.
            // If isRemoveDuplicates is true, then remove all values equal to the input value.
            // If isRemoveDuplicates is false and there is no removeAt input pin,
            // remove any one variable value equal to the input value (if there are any that are equal).
            // If isRemoveDuplicates is false, and there is a removeAt input pin
            // remove the variable value at that position.

            RemoveVariableValueAction action = (RemoveVariableValueAction)node!;
            Variable variable = action.variable!;

            Value? inputValue = null;
            if (action.value != null)
            {
                // NOTE: Multiplicity of the value input pin is required to be 1..1.
                inputValue = TakeTokens(action.value).ElementAt(0);
            }

            int removeAt = 0;
            if (action.removeAt != null)
            {
                removeAt = ((UnlimitedNaturalValue)TakeTokens(action.removeAt).ElementAt(0)).value.naturalValue;
            }

            VariableValue variableValue = GetVariableValue(variable);

            if (variableValue != null)
            {
                if (action.isRemoveDuplicates)
                {
                    int j = Position(inputValue!, variableValue.values, 1);
                    while (j > 0)
                    {
                        variableValue.values.RemoveAt(j - 1);
                        j = Position(inputValue!, variableValue.values, j);
                    }

                }
                else if (action.removeAt == null)
                {
                    List<int> positions = new();
                    int j = Position(inputValue!, variableValue.values, 1);
                    while (j > 0)
                    {
                        positions.Add(j);
                        j = Position(inputValue!, variableValue.values, j + 1);
                    }

                    if (positions.Count() > 0)
                    {
                        // *** Nondeterministically choose which value to remove.
                        // ***
                        int k = ((ChoiceStrategy)GetExecutionLocus().factory!.GetStrategy("choice")).Choose(positions.Count());
                        variableValue.values.RemoveAt(positions.ElementAt(k - 1) - 1);
                    }

                }
                else
                {
                    if (variableValue.values.Count() >= removeAt)
                    {
                        variableValue.values.RemoveAt(removeAt - 1);
                    }
                }
            }

        } // DoAction
    } // RemoveVariableValueActionActivation
}
