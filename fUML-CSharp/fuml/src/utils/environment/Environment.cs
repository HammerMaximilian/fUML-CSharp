using fuml.library.booleanfunctions;
using fuml.library.channel;
using fuml.library.integerfunctions;
using fuml.library.listfunctions;
using fuml.library.realfunctions;
using fuml.library.stringfunctions;
using fuml.library.unlimitednaturalfunctions;
using fuml.semantics.commonbehavior;
using fuml.semantics.loci;
using fuml.semantics.structuredclassifiers;
using uml.commonbehavior;
using uml.simpleclassifiers;
using uml.structuredclassifiers;

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
            object? object_ = (inMemoryModel?.FindElementByName(behaviorName)) ?? throw new ArgumentNullException("[ERROR] Element with specified name does not exist: " + behaviorName);
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
            AddPrimitiveBehaviorPrototype(new BooleanAndFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new BooleanImpliesFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new BooleanNotFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new BooleanOrFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new BooleanToBooleanFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new BooleanToStringFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new BooleanXorFunctionBehaviorExecution());
        }

        private void AddIntegerFunctionsPrototypes()
        {
            AddPrimitiveBehaviorPrototype(new IntegerAbsFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new IntegerDivFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new IntegerDivideFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new IntegerGreaterThanEqualFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new IntegerGreaterThanFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new IntegerLessThanEqualFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new IntegerLessThanFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new IntegerMaxFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new IntegerMinFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new IntegerMinusFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new IntegerModFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new IntegerNegateFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new IntegerPlusFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new IntegerTimesFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new IntegerToIntegerFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new IntegerToStringFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new IntegerToUnlimitedNaturalFunctionBehaviorExecution());
        }

        private void AddListFunctionsPrototypes()
        {
            AddPrimitiveBehaviorPrototype(new ListConcatFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new ListGetFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new ListSizeFunctionBehaviorExecution());
        }

        private void AddRealFunctionsPrototypes()
        {
            AddPrimitiveBehaviorPrototype(new RealAbsFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new RealDivideFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new RealFloorFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new RealGreaterThanEqualFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new RealGreaterThanFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new RealInverseFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new RealLessThanEqualFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new RealLessThanFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new RealMaxFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new RealMinFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new RealMinusFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new RealNegateFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new RealPlusFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new RealRoundFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new RealTimesFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new RealToIntegerFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new RealToRealFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new RealToStringFunctionBehaviorExecution());
        }

        private void AddStringFunctionsPrototypes()
        {
            AddPrimitiveBehaviorPrototype(new StringConcatFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new StringSizeFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new StringSubstringFunctionBehaviorExecution());
        }

        private void AddUnlimitedNaturalFunctionsPrototypes()
        {
            AddPrimitiveBehaviorPrototype(new UnlimitedNaturalGreaterThanEqualFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new UnlimitedNaturalGreaterThanFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new UnlimitedNaturalLessThanEqualFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new UnlimitedNaturalLessThanFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new UnlimitedNaturalMaxFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new UnlimitedNaturalMinFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new UnlimitedNaturalToIntegerFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new UnlimitedNaturalToStringFunctionBehaviorExecution());
            AddPrimitiveBehaviorPrototype(new UnlimitedNaturalToUnlimitedNaturalFunctionBehaviorExecution());
        }
    } // Environment
}
