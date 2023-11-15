using fuml.semantics.actions;
using fuml.semantics.activities;
using fuml.semantics.classification;
using fuml.semantics.commonbehavior;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using uml.actions;
using uml.activities;
using uml.classification;
using uml.commonbehavior;
using uml.commonstructure;
using uml.simpleclassifiers;
using uml.values;

namespace fuml.semantics.loci
{
    public class ExecutionFactory
    {
		public Locus? locus = null;
		public List<OpaqueBehaviorExecution> primitiveBehaviorPrototypes = new();
		public List<PrimitiveType> builtInTypes = new();
		public List<SemanticStrategy> strategies = new();

		public Execution CreateExecution(
				Behavior behavior,
				Object_ context)
		{
			// Create an execution object for a given behavior.
			// The execution will take place at the locus of the factory in the
			// given context.
			// If the context is empty, the execution is assumed to provide its own
			// context.

			Execution execution;

			if (behavior is OpaqueBehavior opaqueBehavior) {
				execution = 
						InstantiateOpaqueBehaviorExecution(opaqueBehavior);
			} else
			{
				execution = (Execution)InstantiateVisitor(behavior);
				execution.types.Add(behavior);
				execution.CreateFeatureValues();
			}

			locus?.Add(execution);

			if (context == null)
			{
				execution.context = execution;
			}
			else
			{
				execution.context = context;
			}

			return execution;
		} // createExecution

		public Evaluation CreateEvaluation(
				ValueSpecification specification)
		{
			// Create an evaluation object for a given value specification.
			// The evaluation will take place at the locus of the factory.

			Evaluation evaluation = (Evaluation)
					InstantiateVisitor(specification);

			evaluation.specification = specification;
			evaluation.locus = locus;

			return evaluation;

		} // createEvaluation

		public SemanticVisitor InstantiateVisitor(
				Element element)
		{
			// Instantiate a visitor object for the given element.

			SemanticVisitor? visitor = null;

			// Formerly Level L1

			if (element is LiteralBoolean) {
				visitor = new LiteralBooleanEvaluation();
			}


		else if (element is LiteralString) {
				visitor = new LiteralStringEvaluation();
			}


		else if (element is LiteralNull) {
				visitor = new LiteralNullEvaluation();
			}


		else if (element is InstanceValue) {
				visitor = new InstanceValueEvaluation();
			}


		else if (element is LiteralUnlimitedNatural) {
				visitor = new LiteralUnlimitedNaturalEvaluation();
			}


		else if (element is LiteralInteger) {
				visitor = new LiteralIntegerEvaluation();
			}


		else if (element is LiteralReal) {
				visitor = new LiteralRealEvaluation();
			}


		else if (element is CallEventBehavior) {
				visitor = new CallEventExecution();

				// Formerly Level L2

			} else if (element is Activity) {
				visitor = new ActivityExecution();
			}


		else if (element is ActivityParameterNode) {
				visitor = new ActivityParameterNodeActivation();
			}


		else if (element is CentralBufferNode &
				element is not DataStoreNode) {
				visitor = new CentralBufferNodeActivation();
			}


		else if (element is InitialNode) {
				visitor = new InitialNodeActivation();
			}


		else if (element is ActivityFinalNode) {
				visitor = new ActivityFinalNodeActivation();
			}


		else if (element is FlowFinalNode) {
				visitor = new FlowFinalNodeActivation();
			}


		else if (element is JoinNode) {
				visitor = new JoinNodeActivation();
			}


		else if (element is MergeNode) {
				visitor = new MergeNodeActivation();
			}


		else if (element is ForkNode) {
				visitor = new ForkNodeActivation();
			}


		else if (element is DecisionNode) {
				visitor = new DecisionNodeActivation();
			}


		else if (element is InputPin) {
				visitor = new InputPinActivation();
			}


		else if (element is OutputPin) {
				visitor = new OutputPinActivation();
			}


		else if (element is CallBehaviorAction) {
				visitor = new CallBehaviorActionActivation();
			}


		else if (element is CallOperationAction) {
				visitor = new CallOperationActionActivation();
			}


		else if (element is SendSignalAction) {
				visitor = new SendSignalActionActivation();
			}


		else if (element is ReadSelfAction) {
				visitor = new ReadSelfActionActivation();
			}


		else if (element is TestIdentityAction) {
				visitor = new TestIdentityActionActivation();
			}


		else if (element is ValueSpecificationAction) {
				visitor = new ValueSpecificationActionActivation();
			}


		else if (element is CreateObjectAction) {
				visitor = new CreateObjectActionActivation();
			}


		else if (element is DestroyObjectAction) {
				visitor = new DestroyObjectActionActivation();
			}


		else if (element is ReadStructuralFeatureAction) {
				visitor = new ReadStructuralFeatureActionActivation();
			}


		else if (element is ClearStructuralFeatureAction) {
				visitor = new ClearStructuralFeatureActionActivation();
			}


		else if (element is AddStructuralFeatureValueAction) {
				visitor = new AddStructuralFeatureValueActionActivation();
			}


		else if (element is RemoveStructuralFeatureValueAction) {
				visitor = new RemoveStructuralFeatureValueActionActivation();
			}


		else if (element is ReadLinkAction) {
				visitor = new ReadLinkActionActivation();
			}


		else if (element is ClearAssociationAction) {
				visitor = new ClearAssociationActionActivation();
			}


		else if (element is CreateLinkAction) {
				visitor = new CreateLinkActionActivation();
			}


		else if (element is DestroyLinkAction) {
				visitor = new DestroyLinkActionActivation();
			}

		// Formerly Level L3

			else if (element is DataStoreNode) {
				visitor = new DataStoreNodeActivation();
			}


		else if (element is ConditionalNode) {
				visitor = new ConditionalNodeActivation();
			}


		else if (element is LoopNode) {
				visitor = new LoopNodeActivation();
			}


		else if (element is ExpansionRegion) {
				visitor = new ExpansionRegionActivation();
			}

		// Note: Since ConditionalNode, LoopNode and ExpansionRegion are
		// subclasses of StructuredActivityNode, element must be tested 
		// against the three subclasses before the superclass.
			else if (element is StructuredActivityNode) {
				visitor = new StructuredActivityNodeActivation();
			}


		else if (element is ExpansionNode) {
				visitor = new ExpansionNodeActivation();
			}


		else if (element is ReadExtentAction) {
				visitor = new ReadExtentActionActivation();
			}


		else if (element is ReadIsClassifiedObjectAction) {
				visitor = new ReadIsClassifiedObjectActionActivation();
			}


		else if (element is ReclassifyObjectAction) {
				visitor = new ReclassifyObjectActionActivation();
			}


		else if (element is StartObjectBehaviorAction) {
				visitor = new StartObjectBehaviorActionActivation();
			}


		else if (element is StartClassifierBehaviorAction) {
				visitor = new StartClassifierBehaviorActionActivation();
			}

		// Note: Since AcceptCallAction is a subclass of AcceptEventAction,
		// element must be tested against AcceptCallAction before
		// AcceptEventAction.
			else if (element is AcceptCallAction) {
				visitor = new AcceptCallActionActivation();
			}


		else if (element is AcceptEventAction) {
				visitor = new AcceptEventActionActivation();
			}


		else if (element is ReplyAction) {
				visitor = new ReplyActionActivation();
			}


		else if (element is ReduceAction) {
				visitor = new ReduceActionActivation();
			}


		else if (element is RaiseExceptionAction) {
				visitor = new RaiseExceptionActionActivation();
			}


		else if (element is UnmarshallAction) {
				visitor = new UnmarshallActionActivation();
			}

			return visitor!;
		}

		public OpaqueBehaviorExecution InstantiateOpaqueBehaviorExecution(
				OpaqueBehavior behavior)
		{
			// Return a copy of the prototype for the primitive behavior execution
			// of the given opaque behavior.

			OpaqueBehaviorExecution? execution = null;
			int i = 1;
			while (execution is null & i <= primitiveBehaviorPrototypes.Count)
			{
				// Debug.println("[instantiateOpaqueExecution] Checking " +
				// this.primitiveBehaviorPrototypes.ElementAt(i).objectId() + "...");
				OpaqueBehaviorExecution prototype = primitiveBehaviorPrototypes
						.ElementAt(i - 1);
				if (prototype.GetBehavior() == behavior)
				{
					execution = (OpaqueBehaviorExecution)prototype.Copy();
				}
				i++;
			}

			Debug.Println(execution is null,
					"[instantiateOpaqueExecution] No prototype execution found for " + behavior.name + ".");

			return execution!;
		} // instantiateOpaqueBehaviorExecution

		public void AddPrimitiveBehaviorPrototype(
				OpaqueBehaviorExecution execution)
		{
			// Add an opaque behavior execution to use as a prototype for
			// instantiating the corresponding primitive opaque behavior.
			// Precondition: No primitive behavior prototype for the type of the
			// given execution should already exist.

			primitiveBehaviorPrototypes.Add(execution);
		} // addPrimitiveBehaviorPrototype

		public void AddBuiltInType(PrimitiveType type)
		{
			// Add the given primitive type as a built-in type.
			// Precondition: No built-in type with the same name should already
			// exist.

			builtInTypes.Add(type);
		} // addBuiltInType

		public PrimitiveType GetBuiltInType(string name)
		{
			// Return the built-in type with the given name.

			PrimitiveType? type = null;
			int i = 1;
			while (type == null & i <= builtInTypes.Count)
			{
				PrimitiveType primitiveType = builtInTypes.ElementAt(i - 1);
				if (primitiveType.name.Equals(name))
				{
					type = primitiveType;
				}
				i++;
			}

			return type!;
		} // getBuiltInType

		public void SetStrategy(SemanticStrategy strategy)
		{
			// Set the strategy for a semantic variation point. Any existing
			// strategy for the same SVP is replaced.

			int i = GetStrategyIndex(strategy.GetName());

			if (i <= strategies.Count)
			{
				strategies.RemoveAt(i - 1);
			}

			strategies.Add(strategy);
		} // setStrategy

		public SemanticStrategy GetStrategy(string name)
		{
			// Get the strategy with the given name.

			int i = GetStrategyIndex(name);

			SemanticStrategy? strategy = null;
			if (i <= strategies.Count)
			{
				strategy = strategies.ElementAt(i - 1);
			}

			return strategy!;
		} // getStrategy

		public int GetStrategyIndex(string name)
		{
			// Get the index of the strategy with the given name.
			// If there is no such strategy, return the Count of the strategies list.

			List<SemanticStrategy> strategies = this.strategies;

			int i = 1;
			bool unmatched = true;
			while (unmatched & (i <= strategies.Count))
			{
				if (strategies.ElementAt(i - 1).GetName().Equals(name))
				{
					unmatched = false;
				}
				else
				{
					i++;
				}
			}

			return i;

		} // getStrategyIndex
	} // ExecutionFactory
}
