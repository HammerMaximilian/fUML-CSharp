using fuml.semantics.activities;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;
using fuml.syntax.actions;
using fuml.syntax.activities;

namespace fuml.semantics.actions
{
    public class LoopNodeActivation : StructuredActivityNodeActivation
    {
        public List<Values> bodyOutputLists = new();
        public bool isTerminateAll = false;

        public override void DoStructuredActivity()
        {
            // Set the initial values for the body outputs to the values of the loop
            // variable input pins.
            // If isTestedFirst is true, then repeatedly run the test part and the
            // body part of the loop, copying values from the body outputs to the
            // loop variables.
            // If isTestedFirst is false, then repeatedly run the body part and the
            // test part of the loop, copying values from the body outputs to the
            // loop variables.
            // When the test fails, copy the values of the body outputs to the loop
            // outputs.
            // [Note: The body outputs are used for the loop outputs, rather than
            // the loop variables, since values on the loop variables may be
            // consumed when running the test for the last time.]

            LoopNode loopNode = (node as LoopNode)!;
            if (loopNode is null) throw new InvalidCastException();
            List<InputPin> loopVariableInputs = loopNode.loopVariableInput;

            bodyOutputLists.Clear();
            foreach (InputPin loopVariableInput in loopVariableInputs)
            {
                Values bodyOutputList = new()
                {
                    values = TakeTokens(loopVariableInput)
                };
                bodyOutputLists.Add(bodyOutputList);
            }

            isTerminateAll = false;
            DoLoop(true);
        } // doStructuredActivity

        public void DoLoop(bool continuing)
        {
            // If isTestedFirst is true, then repeatedly run the test part and the
            // body part of the loop, copying values from the body outputs to the
            // loop variables.
            // If isTestedFirst is false, then repeatedly run the body part and the
            // test part of the loop, copying values from the body outputs to the
            // loop variables.

            LoopNode loopNode = (node as LoopNode)!;
            if (loopNode is null) throw new InvalidCastException();

            List<OutputPin> loopVariables = loopNode.loopVariable;
            List<OutputPin> resultPins = loopNode.result;

            while (continuing)
            {

                // Set loop variable values
                RunLoopVariables();
                for (int i = 0; i < loopVariables.Count; i++)
                {
                    OutputPin loopVariable = loopVariables.ElementAt(i);
                    Values bodyOutputList = bodyOutputLists.ElementAt(i);
                    List<Value> values = bodyOutputList.values;
                    PutPinValues(loopVariable, values);
                    ((OutputPinActivation)activationGroup?.GetNodeActivation(loopVariable)!)?.SendUnofferedTokens();
                }

                // Run all the non-executable, non-pin nodes in the conditional
                // node.
                List<ActivityNodeActivation> nodeActivations = activationGroup?.nodeActivations!;
                List<ActivityNodeActivation> nonExecutableNodeActivations = new();
                foreach (ActivityNodeActivation nodeActivation in nodeActivations)
                {
                    if (!(nodeActivation.node is ExecutableNode | nodeActivation.node is Pin))
                    {
                        nonExecutableNodeActivations.Add(nodeActivation);
                    }
                }
                activationGroup?.Run(nonExecutableNodeActivations);

                // Run the loop
                if (loopNode.isTestedFirst)
                {
                    continuing = RunTest();
                    if (continuing)
                    {
                        RunBody();
                    }
                }
                else
                {
                    RunBody();
                    if (IsRunning() & !IsSuspended())
                    {
                        continuing = RunTest();
                    }
                }

                if (!isTerminateAll & IsRunning() & !IsSuspended())
                {
                    activationGroup?.TerminateAll();
                }
                else
                {
                    continuing = false;
                }

                Debug.Println("[doStructuredActivity] "
                        + (continuing ? "Continuing." : IsSuspended() ? "Suspended" : "Done."));

            }

            if (!isTerminateAll & IsRunning() & !IsSuspended())
            {
                for (int i = 0; i < bodyOutputLists.Count; i++)
                {
                    Values bodyOutputList = bodyOutputLists.ElementAt(i);
                    OutputPin resultPin = resultPins.ElementAt(i);
                    PutTokens(resultPin, bodyOutputList.values);
                }
            }
        } // doLoop

        public bool RunTest()
        {
            // Run the test part of the loop node for this node activation.
            // Return the value on the decider pin.

            Debug.Println("[runTest] Running test...");

            LoopNode loopNode = (node as LoopNode)!;
            if (loopNode is null) throw new InvalidCastException();

            activationGroup?.RunNodes(MakeActivityNodeList(loopNode.test));

            List<Value> values = GetPinValues(loopNode.decider!);

            // If there is no decider value, treat it as false.
            bool decision = false;
            if (values.Count > 0)
            {
                decision = ((BooleanValue)values.ElementAt(0)).value;
            }

            Debug.Println("[runTest] " + (decision ? "Test succeeded." : "Test failed."));

            return decision;
        } // runTest

        public void RunBody()
        {
            // Run the body part of the loop node for this node activation and save
            // the body outputs.

            Debug.Println("[runBody] Running body...");

            LoopNode loopNode = (node as LoopNode)!;
            if (loopNode is null) throw new InvalidCastException();

            activationGroup?.RunNodes(MakeActivityNodeList(loopNode.bodyPart));

            if (!isTerminateAll & !IsSuspended())
            {
                SaveBodyOutputs();
            }
        } // runBody

        public void SaveBodyOutputs()
        {
            // Save the body outputs for use in the next iteration.

            LoopNode loopNode = (node as LoopNode)!;
            if (loopNode is null) throw new InvalidCastException();

            List<OutputPin> bodyOutputs = loopNode.bodyOutput;
            List<Values> bodyOutputLists = this.bodyOutputLists;
            for (int i = 0; i < bodyOutputs.Count; i++)
            {
                OutputPin bodyOutput = bodyOutputs.ElementAt(i);
                Values bodyOutputList = bodyOutputLists.ElementAt(i);
                bodyOutputList.values = GetPinValues(bodyOutput);
            }
        } // saveBodyOutputs

        public void RunLoopVariables()
        {
            // Run the loop variable pins of the loop node for this node activation.

            activationGroup?.RunNodes(MakeLoopVariableList());
        } // runLoopVariables

        public override void CreateNodeActivations()
        {
            // In addition to creating activations for contained nodes, create
            // activations for any loop variables.

            base.CreateNodeActivations();
            activationGroup?.CreateNodeActivations(MakeLoopVariableList());
        } // createNodeActivations

        public List<ActivityNode> MakeLoopVariableList()
        {
            // Return an activity node list containing the loop variable pins for
            // the loop node of this activation.

            LoopNode loopNode = (node as LoopNode)!;
            if (loopNode is null) throw new InvalidCastException();
            List<ActivityNode> nodes = new();

            List<OutputPin> loopVariables = loopNode.loopVariable;
            foreach (OutputPin loopVariable in loopVariables)
            {
                nodes.Add(loopVariable);
            }

            return nodes;

        } // List<makeLoopVariable>

        public override void TerminateAll()
        {
            // Copy the values of the body outputs to the loop outputs, and then
            // terminate all activations in the loop.

            isTerminateAll = true;

            LoopNode loopNode = (node as LoopNode)!;
            if (loopNode is null) throw new InvalidCastException();
            List<OutputPin> bodyOutputs = loopNode.bodyOutput;
            List<OutputPin> resultPins = loopNode.result;
            for (int i = 0; i < bodyOutputs.Count; i++)
            {
                OutputPin bodyOutput = bodyOutputs.ElementAt(i);
                OutputPin resultPin = resultPins.ElementAt(i);
                PutTokens(resultPin, GetPinValues(bodyOutput));
            }

            base.TerminateAll();
        } // terminateAll

        public override void Resume()
        {
            // When this loop node is resumed after being suspended, continue with
            // its next iteration (if any). Once the loop has completed execution
            // without being suspended again, complete the action.

            LoopNode loopNode = (node as LoopNode)!;
            if (loopNode is null) throw new InvalidCastException();

            SaveBodyOutputs();

            if (!isTerminateAll)
            {
                if (loopNode.mustIsolate)
                {
                    _beginIsolation();
                    ContinueLoop();
                    _endIsolation();
                }
                else
                {
                    ContinueLoop();
                }
            }

            if (IsSuspended())
            {
                // NOTE: If the subsequent iteration of the loop suspends it again,
                // then it is necessary to remove the previous suspension from the
                // containing activity node activation group.
                group?.Resume(this);
            }
            else
            {
                base.Resume();
            }
        } // resume

        public void ContinueLoop()
        {
            // Continue the loop node when it is resumed after being suspended. If
            // isTestedFirst is true, then continue executing the loop. If
            // isTestedFirst is false, then run the test to determine whether
            // the loop should be continued or completed.
            // [Note that this presumes that an accept event action is not allowed
            // in the test part of a loop node.]

            LoopNode loopNode = (node as LoopNode)!;
            if (loopNode is null) throw new InvalidCastException();

            bool continuing = true;
            if (!loopNode.isTestedFirst)
            {
                continuing = RunTest();
            }

            if (IsRunning())
            {
                activationGroup?.TerminateAll();
                DoLoop(continuing);
            }
        } // continueLoop
    } // LoopNodeActivation
}
