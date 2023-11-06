using fuml.syntax.activities;

namespace fuml.syntax.actions
{
    public class LoopNode : StructuredActivityNode
    {
        public bool isTestedFirst = false;
        public OutputPin? decider = null;
        public List<ExecutableNode> test = new();
        public List<OutputPin> bodyOutput = new();
        public List<InputPin> loopVariableInput = new();
        public List<ExecutableNode> bodyPart = new();
        public List<OutputPin> result = new();
        public List<OutputPin> loopVariable = new();
        public List<ExecutableNode> setupPart = new();

        public void SetIsTestedFirst(bool isTestedFirst)
        {
            this.isTestedFirst = isTestedFirst;
        } // setIsTestedFirst

        public void AddTest(
                ExecutableNode test)
        {
            if (test is null)
            {
                throw new ArgumentNullException(nameof(test));
            }

            this.test.Add(test);
        } // addTest

        public void AddBodyPart(
                ExecutableNode bodyPart)
        {
            if (bodyPart is null)
            {
                throw new ArgumentNullException(nameof(bodyPart));
            }

            this.bodyPart.Add(bodyPart);
        } // addBodyPart

        public void AddLoopVariableInput(
                InputPin loopVariableInput)
        {
            AddStructuredNodeInput(loopVariableInput);
            this.loopVariableInput.Add(loopVariableInput);
        } // addLoopVariableInput

        public void AddLoopVariable(
                OutputPin loopVariable)
        {
            if (loopVariable is null)
            {
                throw new ArgumentNullException(nameof(loopVariable));
            }

            this.loopVariable.Add(loopVariable);
        } // addLoopVariable

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

        public void AddResult(OutputPin result)
        {
            AddOutput(result);
            this.result.Add(result);
        } // addResult
    } // LoopNode
}
