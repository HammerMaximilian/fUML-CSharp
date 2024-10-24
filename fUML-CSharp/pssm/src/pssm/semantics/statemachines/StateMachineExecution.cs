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

        protected void InitRegions()
        {
            StateMachine? machine = null;
            if (GetTypes().Any())
            {
                machine = (StateMachine)GetTypes().ElementAt(0);
            }
            if (machine != null)
            {
                foreach (Region region in machine.region)
                {
                    RegionActivation activation = (RegionActivation)locus!.factory!.InstantiateVisitor(region);
                    activation.parent = this;
                    activation.node = region;
                    regionActivation.Add(activation);
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
            VertexActivation? vertexActivation = null;
            while (vertexActivation == null && i < regionActivation.Count)
            {
                vertexActivation = regionActivation.ElementAt(i).GetVertexActivation(vertex);
                i++;
            }
            return vertexActivation!;
        }

        public override void Execute()
        {
            // The execution of state-machine is realized as described below
            // 1 - An event accepter is placed in the list of waiting event accepters for this state-machine
            // 2 - All visitors required to interpret the state-machine are instantiated and link together
            // 3 - All top level regions (i.e. those directly owned by the executed state-machine) are entered
            //     concurrently. Since they are top regions then there is no transition used to enter them
            // Note: a state-machine always has at runtime a single event accepter
            if (context != null && context.objectActivation != null)
            {
                context.Register(new StateMachineEventAccepter(this));
            }
            InitRegions();
            foreach (RegionActivation activation in regionActivation)
            {
                activation.Activate();
            }
            foreach (RegionActivation activation in regionActivation)
            {
                activation.ActivateTransitions();
            }
            foreach (RegionActivation regionActivation in regionActivation)
            {
                regionActivation.Enter(null!, null!);
            }
        }

        protected override Value New_()
        {
            if (context != null)
            {
                return new StateMachineExecution(context);
            }
            return new StateMachineExecution();
        }

        public override void StartBehavior(Class_ classifier, List<ParameterValue> inputs)
        {
            // The behavior captured here is almost identical to the one provide by Object_.
            // Instead of using a simple ObjectActivation we use a StateMachineObjectActivation.
            // This specialized kind of ObjectActivation allows the registering of completion events.
            objectActivation ??= new SM_ObjectActivation
            {
                object_ = this
            };
            objectActivation.StartBehavior(classifier, inputs);
        }

        public override void Terminate()
        {
            // The termination of a state-machine consists in aborting all "ongoing" doActivity behaviors
            // started by states owned by this state-machine. States that are currently active (i.e., registered
            // in the state-machine configuration) are not exited (i.e., if they have have exit behaviors then
            // these behaviors are not executed.
            foreach (RegionActivation activation in regionActivation)
            {
                activation.Terminate();
            }
            regionActivation.Clear();
        }
    } // StateMachineExecution
}
