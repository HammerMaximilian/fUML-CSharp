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

		public void addPredecessorClause(
				Clause predecessorClause)
		{
            if (predecessorClause is null)
            {
                throw new ArgumentNullException(nameof(predecessorClause));
            }

            this.predecessorClause.Add(predecessorClause);
			predecessorClause.successorClause.Add(this);
		} // addPredecessorClause

		public void addTest(
				ExecutableNode test)
		{
            if (test is null)
            {
                throw new ArgumentNullException(nameof(test));
            }

            this.test.Add(test);
		} // addTest

		public void addBody(
				ExecutableNode body)
		{
            if (body is null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            this.body.Add(body);
		} // addBody

		public void setDecider(OutputPin decider)
		{
			this.decider = decider ?? throw new ArgumentNullException(nameof(decider));
		} // setDecider

		public void addBodyOutput(
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
