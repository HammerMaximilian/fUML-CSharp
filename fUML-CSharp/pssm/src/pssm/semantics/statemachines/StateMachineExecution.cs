using fuml.semantics.commonbehavior;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using uml.statemachines;
using uml.structuredclassifiers;

namespace pssm.semantics.statemachines
{
    public class StateMachineExecution : Execution
    {
        /*
         * List of visitors associated to regions owned by the state-machine
         */
        protected List<RegionActivation> regionActivation = new();

        /*
         * The current "state" of state-machine 
         */
        public StateMachineConfiguration? configuration = null;

        public StateMachineExecution()
        {
            configuration = new StateMachineConfiguration(this);
        }

        public StateMachineExecution(Object_ context)
        {
            this.context = context;
            configuration = new StateMachineConfiguration(this);
        }

        protected void initRegions()
        {
        }

        /*
         * Search the corresponding visitor in the hierarchy owned by this
         * StateMachineExecution
         * @param vertex - the vertex for which an activation is searched
         * @return vertexActivation - the corresponding activation
         */
        public VertexActivation GetVertexActivation(Vertex vertex)
        {
            throw new NotImplementedException();
        }

        public override void Execute()
        {
        }

        protected override Value New_()
        {
            throw new NotImplementedException();
        }

        public override void StartBehavior(Class_ classifier, List<ParameterValue> inputs)
        {
        }

        public override void Terminate()
        {
        }
    } // StateMachineExecution
}
