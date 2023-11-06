using fuml.syntax.activities;
using fuml.syntax.commonstructure;

namespace fuml.syntax.actions
{
    public class Clause : Element
    {
		public List<ExecutableNode> test = new();
		public List<ExecutableNode> body = new();
		public List<Clause> predecessorClause = new();
		public List<Clause> successorClause = new();
		public OutputPin? decider = null;
		public List<OutputPin> bodyOutput = new();

		public void AddPredecessorClause(
				Clause predecessorClause)
		{
            if (predecessorClause is null)
            {
                throw new ArgumentNullException(nameof(predecessorClause));
            }

            this.predecessorClause.Add(predecessorClause);
			predecessorClause.successorClause.Add(this);
		} // addPredecessorClause

		public void AddTest(
				ExecutableNode test)
		{
            if (test is null)
            {
                throw new ArgumentNullException(nameof(test));
            }

            this.test.Add(test);
		} // addTest

		public void AddBody(
				ExecutableNode body)
		{
            if (body is null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            this.body.Add(body);
		} // addBody

		public void SetDecider(OutputPin decider)
		{
			this.decider = decider ?? throw new ArgumentNullException(nameof(decider));
		} // setDecider

		public void AddBodyOutput(
				OutputPin bodyOutput)
		{
            if (bodyOutput is null)
            {
                throw new ArgumentNullException(nameof(bodyOutput));
            }

            this.bodyOutput.Add(bodyOutput);
		} // addBodyOutput
	} // Clause
}
