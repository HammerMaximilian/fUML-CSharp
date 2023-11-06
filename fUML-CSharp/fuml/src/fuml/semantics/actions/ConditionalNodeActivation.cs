using fuml.semantics.activities;
using fuml.semantics.loci;
using fuml.syntax.actions;
using fuml.syntax.activities;

namespace fuml.semantics.actions
{
    public class ConditionalNodeActivation : StructuredActivityNodeActivation
    {
        public List<ClauseActivation> clauseActivations = new();
        public List<Clause> selectedClauses = new();
        public Clause? selectedClause = null;

        public override void DoStructuredActivity()
        {
            // Run all the non-executable, non-pin nodes in the conditional node.
            // Activate all clauses in the conditional node and pass control to
            // those that are ready (i.e., have no predecessors).
            // If one or more clauses have succeeded in being selected, choose one
            // non-deterministically and run its body, then copy the outputs of that
            // clause to the output pins of the node.

            ConditionalNode? node = this.node as ConditionalNode;

            List<ActivityNodeActivation> nodeActivations = (activationGroup is not null) ? activationGroup.nodeActivations : new();
            List<ActivityNodeActivation> nonExecutableNodeActivations = new();
            foreach (ActivityNodeActivation nodeActivation in nodeActivations)
            {
                if (!(nodeActivation.node is ExecutableNode | nodeActivation.node is Pin))
                {
                    nonExecutableNodeActivations.Add(nodeActivation);
                }
            }

            activationGroup?.Run(nonExecutableNodeActivations);

            clauseActivations.Clear();
            List<Clause> clauses = (node is not null) ? node.clause : new();
            foreach (Clause clause in clauses)
            {
                ClauseActivation clauseActivation = new();
                clauseActivation.clause = clause;
                clauseActivation.conditionalNodeActivation = this;
                clauseActivations.Add(clauseActivation);
            }

            selectedClauses.Clear();

            List<ClauseActivation> readyClauseActivations = new();
            int clauseActivationNumber = 0;
            foreach (ClauseActivation clauseActivation in clauseActivations)
            {
                Debug.Println("[doStructuredActivity] clauseActivations[" + clauseActivationNumber + "] = " + clauseActivation);
                if (clauseActivation.IsReady())
                {
                    Debug.Println("[doStructuredActivity] Clause activation is ready.");
                    readyClauseActivations.Add(clauseActivation);
                }
                clauseActivationNumber++;
            }

            // *** Give control to all ready clauses concurrently. ***
            foreach (ClauseActivation clauseActivation in readyClauseActivations)
            {
                Debug.Println("[doStructuredActivity] Giving control to " + clauseActivation + "...");
                clauseActivation.ReceiveControl();
            }

            selectedClause = null;
            if (selectedClauses.Count > 0 & IsRunning())
            {
                Debug.Println("[doStructuredActivity] " + selectedClauses.Count + " clause(s) selected.");

                // *** If multiple clauses are selected, choose one
                // non-deterministically. ***
                int i = ((ChoiceStrategy)GetExecutionLocus()?.factory?.GetStrategy("choice")!).Choose(selectedClauses.Count);
                selectedClause = selectedClauses.ElementAt(i - 1);

                Debug.Println("[doStructuredActivity] Running selectedClauses[" + i + "] = " + selectedClause);

                foreach (Clause clause in clauses)
                {
                    if (clause != selectedClause)
                    {
                        List<ExecutableNode> testNodes = clause.test;
                        foreach (ExecutableNode testNode in testNodes)
                        {
                            activationGroup?.GetNodeActivation(testNode).Terminate();
                        }
                    }
                }

                activationGroup?.RunNodes(MakeActivityNodeList(selectedClause.body));
            }
        } // doStructuredActivity

        public void CompleteBody()
        {
            // Complete the activation of the body of a conditional note by
            // copying the outputs of the selected clause (if any) to the output
            // pins of the node and terminating the activation of all nested nodes.

            if (selectedClause is not null)
            {
                ConditionalNode? node = this.node as ConditionalNode;
                if (node is null) throw new InvalidCastException();
                List<OutputPin> resultPins = node.result;
                List<OutputPin> bodyOutputPins = selectedClause.bodyOutput;
                for (int k = 0; k < resultPins.Count; k++)
                {
                    OutputPin resultPin = resultPins.ElementAt(k);
                    OutputPin bodyOutputPin = bodyOutputPins.ElementAt(k);
                    PutTokens(resultPin, GetPinValues(bodyOutputPin));
                }
            }
            activationGroup?.TerminateAll();
        } // completeBody

        public override List<Token> CompleteAction()
        {
            // Only complete the conditional node if it is not suspended.

            if (!IsSuspended())
            {
                CompleteBody();
            }
            return base.CompleteAction();
        } // completeAction

        public ClauseActivation GetClauseActivation(Clause clause)
        {
            // Get the clause activation corresponding to the given clause.

            ClauseActivation? selectedClauseActivation = null;
            int i = 1;
            while ((selectedClauseActivation is null)
                    & i <= clauseActivations.Count)
            {
                ClauseActivation clauseActivation = clauseActivations.ElementAt(i - 1);
                if (clauseActivation.clause == clause)
                {
                    selectedClauseActivation = clauseActivation;
                }
                i++;
            }

            return selectedClauseActivation!;
        } // getClauseActivation

        public void RunTest(Clause clause)
        {
            // Run the test for the given clause.

            if (IsRunning())
            {
                activationGroup?.RunNodes(MakeActivityNodeList(clause.test));
            }
        } // runTest

        public void SelectBody(Clause clause)
        {
            // Add the clause to the list of selected clauses.

            selectedClauses.Add(clause);

        } // selectBody

        public override void Resume()
        {
            // When this conditional node is resumed after being suspended, complete
            // its body and then resume it as a structured activity node.
            // [Note that this presumes that accept event actions are not allowed
            // in the test part of a clause of a conditional node.]

            CompleteBody();
            base.Resume();
        } // resume
    } // ConditionalNodeActivation
}
