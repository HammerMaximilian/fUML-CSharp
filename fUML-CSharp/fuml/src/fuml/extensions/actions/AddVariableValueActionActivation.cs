using fuml.extensions.activities;
using fuml.semantics.loci;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;
using uml.actions;
using uml.activities;

namespace fuml.extensions.actions
{
    public class AddVariableValueActionActivation : WriteVariableActionActivation
    {
        public override void DoAction()
        {
            // Get the values of the value input pin.
            // Add a value to the values for the appropriate variable.
            // If isReplaceAll is true, first remove all current matching variable values.
            // If isReplaceAll is false and there is an insertAt pin, insert the
            // value at the appropriate position.

            AddVariableValueAction action = (AddVariableValueAction)node!;
            Variable variable = action.variable!;

            List<Value> inputValues = TakeTokens(action.value!);

            // NOTE: Multiplicity of the value input pin is required to be 1..1.
            Value inputValue = inputValues.ElementAt(0);

            int insertAt = 0;
            if (action.insertAt != null)
            {
                insertAt = ((UnlimitedNaturalValue)TakeTokens(action.insertAt).ElementAt(0)).value.naturalValue;
            }

            VariableValue variableValue = GetVariableValue(variable);

            if (variableValue != null)
            {
                if (action.isReplaceAll)
                {
                    variableValue.values = inputValues;
                    variableValue.position = 0;
                }
                else
                {
                    if (variableValue.values.Count() > 0 & insertAt == 0)
                    {
                        // *** If there is no insertAt pin, then the structural
                        // feature must be unordered, and the insertion position is
                        // immaterial. ***
                        insertAt = ((ChoiceStrategy)GetExecutionLocus().factory!.GetStrategy("choice")).Choose(variableValue.values.Count());
                    }

                    if (variable.multiplicityElement.isUnique)
                    {
                        // Remove any existing value that duplicates the input value
                        int j = Position(inputValue, variableValue.values, 1);
                        if (j > 0)
                        {
                            variableValue.values.RemoveAt(j - 1);
                        }
                    }

                    if (insertAt <= 0)
                    { // Note: insertAt = -1 indicates an
                      // unlimited value of "*"
                        variableValue.values.Add(inputValue);
                    }
                    else
                    {
                        variableValue.values.Insert(insertAt - 1, inputValue);
                    }
                }
            }
        } // DoAction
    } // AddVariableValueActionActivation
}
