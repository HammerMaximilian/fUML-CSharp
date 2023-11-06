using fuml.semantics.commonbehavior;
using fuml.semantics.values;
using fuml.syntax.actions;
using fuml.syntax.classification;

namespace fuml.semantics.actions
{
    public class ReduceActionActivation : ActionActivation
    {
		public Execution? currentExecution = null;

		public override void DoAction()
		{
			// Get the values of the collection input pin.
			// If the input pin has no values, then do nothing. Otherwise, do the
			// following.
			// Repeatedly invoke the reducer behavior on successive pairs to reduce
			// the collection to a single value, and place that value on the result
			// pin.
			// To invoke the reducer behavior, compile it to create an execution,
			// make the execution the current execution, place the appropriate
			// values on its input parameters, and execute it.

			ReduceAction action = (node as ReduceAction)!;
			if (action is null) throw new InvalidCastException();

			List<Value> values = TakeTokens(action.collection!);

			if (values.Count > 0)
			{
				List<Parameter> parameters = action.reducer!.ownedParameter;
				Parameter? input1 = null;
				Parameter? input2 = null;
				Parameter? output = null;

				int i = 1;
				while (i <= parameters.Count)
				{
					Parameter parameter = parameters.ElementAt(i - 1);
					if (parameter.direction == ParameterDirectionKind.in_) {
						if (input1 is null)
						{
							input1 = parameter;
						}
						else
						{
							input2 = parameter;
						}
					} else if (parameter.direction == ParameterDirectionKind.out_
						| parameter.direction == ParameterDirectionKind.return_) {
						output = parameter;
					}
					i++;
				}

                ParameterValue parameterValue1 = new()
                {
                    parameter = input1,
                    values = new List<Value>()
                };
                parameterValue1.values.Add(values.ElementAt(0));

				int j = 2;
				while (j <= values.Count)
				{
					currentExecution = GetExecutionLocus()?.factory?.CreateExecution(action.reducer, GetExecutionContext());

					currentExecution?.SetParameterValue(parameterValue1);

                    ParameterValue parameterValue2 = new()
                    {
                        parameter = input2,
                        values = new List<Value>()
                    };
                    parameterValue2.values.Add(values.ElementAt(j - 1));
					currentExecution?.SetParameterValue(parameterValue2);

					currentExecution?.Execute();

					parameterValue1.values = currentExecution?.GetParameterValue(output!)?.values!;

					j++;

					if ((!parameterValue1.values.Any()) & j <= values.Count)
					{
						parameterValue1.values.Add(values.ElementAt(j - 1));
						j++;
					}

				}

				PutTokens(action.result!, parameterValue1.values);
			}
		} // doAction

		public override void Terminate()
		{
			// If there is a current execution, terminate it. Then terminate self.

			if (currentExecution is not null)
			{
				currentExecution.Terminate();
			}

			base.Terminate();
		} // terminate
	} // ReduceActionActivation
}
