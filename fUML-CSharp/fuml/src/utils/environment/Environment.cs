using fuml.library.channel;
using fuml.semantics.commonbehavior;
using fuml.semantics.loci;
using fuml.semantics.structuredclassifiers;
using fuml.syntax.commonbehavior;
using fuml.syntax.simpleclassifiers;
using fuml.syntax.structuredclassifiers;

namespace fuml.environment
{
    public abstract class Environment
    {
        protected Locus locus;
        protected Object_? context = null;
        protected List<ParameterValue> inputs = new();
        protected List<ParameterValue> outputs = new();
        protected InMemoryModel? inMemoryModel;

        public virtual void Execute(string behaviorName)
        {
            FumlObject? object_ = (inMemoryModel?.FindElementByName(behaviorName)) ?? throw new ArgumentNullException("[ERROR] Element with specified name does not exist: " + behaviorName);
            Behavior behavior = (object_ as Behavior)! ?? throw new ArgumentNullException("[ERROR] Specified behavior name does not name a behavior: " + behaviorName);
            Class_ contextType = (behavior.context as Class_)!;
            if(contextType is not null)
            {
                context = locus?.Instantiate(contextType);
            }

            outputs = locus?.executor?.Execute(behavior, context!, inputs)!;
        }

        protected Environment()
        {
            locus = new();
            locus.SetExecutor(new());
            locus.SetFactory(new());

            locus.factory?.SetStrategy(new FirstChoiceStrategy());
            locus.factory?.SetStrategy(new RedefinitionBasedDispatchStrategy());
            locus.factory?.SetStrategy(new FIFOGetNextEventStrategy());

            AddBooleanFunctionsPrototypes();
            AddIntegerFunctionsPrototypes();
            AddListFunctionsPrototypes();
            AddRealFunctionsPrototypes();
            AddStringFunctionsPrototypes();
            AddUnlimitedNaturalFunctionsPrototypes();

            Add(new StandardInputChannelObject());
            Add(new StandardOutputChannelObject());
        }

        protected void Add(ExtensionalValue extensionalValue)
        {
            locus?.Add(extensionalValue);
        }

        protected void AddBuiltInType(string name)
        {
            PrimitiveType builtInType = new();
            builtInType.SetName(name);
            locus?.factory?.AddBuiltInType(builtInType);
        }

        protected void AddBuiltInType(PrimitiveType builtInType)
        {
            locus?.factory?.AddBuiltInType(builtInType);
        }

        protected void AddPrimitiveBehaviorPrototype(OpaqueBehaviorExecution prototype)
        {
            locus?.factory?.AddPrimitiveBehaviorPrototype(prototype);
        }

        private void AddBooleanFunctionsPrototypes()
        {
        }

        private void AddIntegerFunctionsPrototypes()
        {
        }

        private void AddListFunctionsPrototypes()
        {
        }

        private void AddRealFunctionsPrototypes()
        {
        }

        private void AddStringFunctionsPrototypes()
        {
        }

        private void AddUnlimitedNaturalFunctionsPrototypes()
        {
        }
    } // Environment
}
