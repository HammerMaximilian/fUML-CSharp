using fuml.semantics.commonbehavior;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using pssm.semantics.commonbehavior;
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
            StateMachine machine = null;
            if (!this.getTypes().isEmpty())
            {
                machine = (StateMachine)this.getTypes().get(0);
            }
            if (machine != null)
            {
                for (Region region: machine.getRegions())
                {
                    RegionActivation activation = (RegionActivation)this.locus.getFactory().instantiateVisitor(region);
                    activation.setParent(this);
                    activation.setNode(region);
                    this.regionActivation.add(activation);
                }
            }
        }

        /*
         * Search the corresponding visitor in the hierarchy owned by this
         * StateMachineExecution
         * @param vertex - the vertex for which an activation is searched
         * @return vertexActivation - the corresponding activation
         */
        public VertexActivation GetVertexActivation(Vertex vertex)
        {
            int i = 0;
            IVertexActivation vertexActivation = null;
            while (vertexActivation == null && i < this.regionActivation.size())
            {
                vertexActivation = this.regionActivation.get(i).getVertexActivation(vertex);
                i++;
            }
            return vertexActivation;
        }

        public override void Execute()
        {
            // The execution of state-machine is realized as described below
            // 1 - An event accepter is placed in the list of waiting event accepters for this state-machine
            // 2 - All visitors required to interpret the state-machine are instantiated and link together
            // 3 - All top level regions (i.e. those directly owned by the executed state-machine) are entered
            //     concurrently. Since they are top regions then there is no transition used to enter them
            // Note: a state-machine always has at runtime a single event accepter
            if (this.context != null && this.context.getObjectActivation() != null)
            {
                this.context.register(new StateMachineEventAccepter(this));
            }
            this.initRegions();
            for (IRegionActivation activation: this.regionActivation)
            {
                activation.activate();
            }
            for (IRegionActivation activation: this.regionActivation)
            {
                activation.activateTransitions();
            }
            for (IRegionActivation regionActivation: this.regionActivation)
            {
                regionActivation.enter(null, null);
            }
        }

        protected override Value New_()
        {
            if (this.context != null)
            {
                return new StateMachineExecution(this.context);
            }
            return new StateMachineExecution();
        }

        public override void StartBehavior(Class_ classifier, List<ParameterValue> inputs)
        {
            // The behavior captured here is almost identical to the one provide by Object_.
            // Instead of using a simple ObjectActivation we use a StateMachineObjectActivation.
            // This specialized kind of ObjectActivation allows the registering of completion events.
            if (this.objectActivation == null)
            {
                this.objectActivation = new SM_ObjectActivation();
                this.objectActivation.setObject(this);
            }
            this.objectActivation.startBehavior(classifier, inputs);
        }

        public override void Terminate()
        {
            // The termination of a state-machine consists in aborting all "ongoing" doActivity behaviors
            // started by states owned by this state-machine. States that are currently active (i.e., registered
            // in the state-machine configuration) are not exited (i.e., if they have have exit behaviors then
            // these behaviors are not executed.
            for (int i = 0; i < this.regionActivation.size(); i++)
            {
                this.regionActivation.get(i).terminate();
            }
            this.regionActivation.clear();
        }
    } // StateMachineExecution
}
