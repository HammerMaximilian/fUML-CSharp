namespace examples.HelloWorldExample
{
    public class HelloWorldExampleEnvironment : fuml.environment.Environment
    {
        private static HelloWorldExampleEnvironment? instance;

        public static HelloWorldExampleEnvironment Instance()
        {
            if(instance is null)
            {
                instance = new();
                instance.inMemoryModel = HelloWorldExampleModel.Instance();
            }

            return instance;
        }

        public override void Execute(string behaviorName)
        {
            /*
             * Initialize context object and input parameter values here if desired.
             */
            //context = ...;
            //inputs = ...;

            /*
             * Create custom opaque behavior execution instances and add them to the execution environment here if desired.
             */

            /*
             * Start execution via base class call
             */
            base.Execute(behaviorName);

            /*
             * Evaluate output parameter values here if desired.
             */
            //List<ParameterValue> theOutputs = outputs;
            //...
        }
    } // HelloWorldExampleEnvironment
}
