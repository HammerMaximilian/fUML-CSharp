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

        public void setIsTestedFirst(bool isTestedFirst)
        {
            this.isTestedFirst = isTestedFirst;
        } // setIsTestedFirst

        public void addTest(
                ExecutableNode test)
        {
            if (test is null)
            {
                throw new ArgumentNullException(nameof(test));
            }

            this.test.Add(test);
        } // addTest

        public void addBodyPart(
                ExecutableNode bodyPart)
        {
            if (bodyPart is null)
            {
                throw new ArgumentNullException(nameof(bodyPart));
            }

            this.bodyPart.Add(bodyPart);
        } // addBodyPart

        public void addLoopVariableInput(
                InputPin loopVariableInput)
        {
            addStructuredNodeInput(loopVariableInput);
            this.loopVariableInput.Add(loopVariableInput);
        } // addLoopVariableInput

        public void addLoopVariable(
                OutputPin loopVariable)
        {
            if (loopVariable is null)
            {
                throw new ArgumentNullException(nameof(loopVariable));
            }

            this.loopVariable.Add(loopVariable);
        } // addLoopVariable

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

        public void addResult(OutputPin result)
        {
            AddOutput(result);
            this.result.Add(result);
        } // addResult
    } // LoopNode
}
