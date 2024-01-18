using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;
using uml.actions;

namespace fuml.semantics.actions
{
    public class ClauseActivation
    {
        public ConditionalNodeActivation? conditionalNodeActivation = null;
        public Clause? clause = null;

        public void ReceiveControl()
        {
            // If all predecessors to the clause for this activation have run their
            // tests and failed, then run the test for this clause.
            // If the test succeeds, then terminate any other clauses that may be
            // running and run the body of this clause.
            // If the test fails, then pass control to successor clauses.

            Debug.Println("[receiveControl] clauseActivation = " + this);

            if (IsReady())
            {
                Debug.Println("[receiveControl] Running test...");
                RunTest();

                BooleanValue decision = GetDecision();

                // Note that the decision may be null if the test was terminated
                // before completion.
                if (decision is not null)
                {
                    if (decision.value == true)
                    {
                        Debug.Println("[receiveControl] Test succeeded.");
                        SelectBody();
                    }
                    else
                    {
                        Debug.Println("[receiveControl] Test failed.");

                        List<ClauseActivation> successors = GetSuccessors();

                        // *** Give control to all successors concurrently. ***
                        foreach (ClauseActivation successor in successors)
                        {
                            successor.ReceiveControl();
                        }
                    }
                }
            }
        } // receiveControl

        public bool IsReady()
        {
            // Test if all predecessors to this clause activation have failed.

            List<ClauseActivation> predecessors = GetPredecessors();

            bool ready = true;
            int i = 1;
            while (ready & i <= predecessors.Count)
            {
                ClauseActivation predecessor = predecessors.ElementAt(i - 1);
                BooleanValue decisionValue = predecessor.GetDecision();

                // Note that the decision will be null if the predecessor clause has
                // not run yet.
                if (decisionValue == null)
                {
                    ready = false;
                }
                else
                {
                    ready = !decisionValue.value;
                }

                i++;
            }

            return ready;

        } // isReady

        public void RunTest()
        {
            // Run the test of the clause for this clause activation.
            if (clause is null) throw new ArgumentNullException();
            conditionalNodeActivation?.RunTest(clause);
        } // runTest

        public void SelectBody()
        {
            // Select the body of the clause for this clause activation.
            if (clause is null) throw new ArgumentNullException();
            conditionalNodeActivation?.SelectBody(clause);
        } // selectBody

        public BooleanValue GetDecision()
        {
            // Get the value (if any) on the decider pin of the clause for this
            // clause activation.
            if (conditionalNodeActivation is null) throw new ArgumentNullException();
            if (clause is null) throw new ArgumentNullException();
            List<Value> deciderValues = conditionalNodeActivation.GetPinValues(clause.decider!);

            BooleanValue? deciderValue = null;
            if (deciderValues.Count > 0)
            {
                deciderValue = (BooleanValue)deciderValues.ElementAt(0);
            }

            return deciderValue!;
        } // getDecision

        public List<ClauseActivation> GetPredecessors()
        {
            // Return the clause activations for the predecessors of the clause for
            // this clause activation.

            List<ClauseActivation> predecessors = new();

            List<Clause> predecessorClauses = (clause is not null) ? clause.predecessorClause : new();
            foreach (Clause predecessorClause in predecessorClauses)
            {
                predecessors.Add(conditionalNodeActivation?.GetClauseActivation(predecessorClause)!);
            }

            return predecessors;
        } // getPredecessors

        public List<ClauseActivation> GetSuccessors()
        {
            // Return the clause activations for the successors of the clause for
            // this clause activation.

            List<ClauseActivation> successors = new();
            if (clause is null) throw new ArgumentNullException();
            List<Clause> successorClauses = clause.successorClause;
            foreach (Clause successorClause in successorClauses)
            {
                successors.Add(conditionalNodeActivation?.GetClauseActivation(successorClause)!);
            }

            return successors;

        } // getSuccessors
    } // ClauseActivation
}
