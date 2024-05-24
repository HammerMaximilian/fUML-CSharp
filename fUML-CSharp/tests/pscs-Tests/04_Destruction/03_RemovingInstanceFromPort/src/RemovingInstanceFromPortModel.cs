/*
 * RemovingInstanceFromPortModel.cs
 * 
 * Auto-generated file
 */

using uml.actions;
using uml.packages;
using uml.structuredclassifiers;
using fuml.primitivetypes;
using uml.classification;
using fuml.library;
using uml.simpleclassifiers;
using uml.commonbehavior;
using uml.commonstructure;
using uml.values;
using uml.activities;
using uml.environment;


/* Start of user code : User-defined includes and forward declarations
 * This section may be used for includes and forward declarations.
 * It will not be overwritten by future generation processes.
 */

/*
 * End of user code
 */

namespace RemovingInstanceFromPort
{
	public class RemovingInstanceFromPortModel : InMemoryModel
	{
		private static RemovingInstanceFromPortModel? instance;

		/*
		 * Model RemovingInstanceFromPort
		 */
		public Package RemovingInstanceFromPort = new();
			public Class_ RemovingInstanceFromPort_B = new();
				public Operation RemovingInstanceFromPort_B_B_B = new();
					public Parameter RemovingInstanceFromPort_B_B_B_result = new();
				public Activity RemovingInstanceFromPort_B_setPActivity = new();
					public ActivityParameterNode RemovingInstanceFromPort_B_setPActivity_vParameterNode = new();
						public LiteralInteger RemovingInstanceFromPort_B_setPActivity_vParameterNode_LiteralInteger0 = new();
					public ReadSelfAction RemovingInstanceFromPort_B_setPActivity_this = new();
						public OutputPin RemovingInstanceFromPort_B_setPActivity_this_result = new();
							public LiteralUnlimitedNatural RemovingInstanceFromPort_B_setPActivity_this_result_LiteralUnlimitedNatural1 = new();
							public LiteralInteger RemovingInstanceFromPort_B_setPActivity_this_result_LiteralInteger2 = new();
					public Parameter RemovingInstanceFromPort_B_setPActivity_v = new();
					public ObjectFlow RemovingInstanceFromPort_B_setPActivity_ObjectFlow3 = new();
						public LiteralBoolean RemovingInstanceFromPort_B_setPActivity_ObjectFlow3_LiteralBoolean4 = new();
						public LiteralInteger RemovingInstanceFromPort_B_setPActivity_ObjectFlow3_LiteralInteger5 = new();
					public ObjectFlow RemovingInstanceFromPort_B_setPActivity_ObjectFlow6 = new();
						public LiteralBoolean RemovingInstanceFromPort_B_setPActivity_ObjectFlow6_LiteralBoolean7 = new();
						public LiteralInteger RemovingInstanceFromPort_B_setPActivity_ObjectFlow6_LiteralInteger8 = new();
					public AddStructuralFeatureValueAction RemovingInstanceFromPort_B_setPActivity_Set_this_p = new();
						public OutputPin RemovingInstanceFromPort_B_setPActivity_Set_this_p_result = new();
							public LiteralUnlimitedNatural RemovingInstanceFromPort_B_setPActivity_Set_this_p_result_LiteralUnlimitedNatural9 = new();
							public LiteralInteger RemovingInstanceFromPort_B_setPActivity_Set_this_p_result_LiteralInteger10 = new();
						public InputPin RemovingInstanceFromPort_B_setPActivity_Set_this_p_value = new();
							public LiteralUnlimitedNatural RemovingInstanceFromPort_B_setPActivity_Set_this_p_value_LiteralUnlimitedNatural11 = new();
							public LiteralInteger RemovingInstanceFromPort_B_setPActivity_Set_this_p_value_LiteralInteger12 = new();
						public InputPin RemovingInstanceFromPort_B_setPActivity_Set_this_p_object = new();
							public LiteralUnlimitedNatural RemovingInstanceFromPort_B_setPActivity_Set_this_p_object_LiteralUnlimitedNatural13 = new();
							public LiteralInteger RemovingInstanceFromPort_B_setPActivity_Set_this_p_object_LiteralInteger14 = new();
				public Operation RemovingInstanceFromPort_B_setP_Integer = new();
					public Parameter RemovingInstanceFromPort_B_setP_Integer_v = new();
				public Property RemovingInstanceFromPort_B_p = new();
				public InterfaceRealization RemovingInstanceFromPort_B_IRealization = new();
			public Activity RemovingInstanceFromPort_assertA = new();
				public ActivityParameterNode RemovingInstanceFromPort_assertA_aParameterNode = new();
					public LiteralInteger RemovingInstanceFromPort_assertA_aParameterNode_LiteralInteger15 = new();
				public OpaqueBehavior RemovingInstanceFromPort_assertA_assertionNotImplemented = new();
				public Parameter RemovingInstanceFromPort_assertA_a = new();
				public CallBehaviorAction RemovingInstanceFromPort_assertA_Call_assertionNotImplemented = new();
			public Interface RemovingInstanceFromPort_I = new();
				public Operation RemovingInstanceFromPort_I_setP_Integer = new();
					public Parameter RemovingInstanceFromPort_I_setP_Integer_v = new();
			public Activity RemovingInstanceFromPort_main = new();
				public ObjectFlow RemovingInstanceFromPort_main_ObjectFlow16 = new();
					public LiteralBoolean RemovingInstanceFromPort_main_ObjectFlow16_LiteralBoolean17 = new();
					public LiteralInteger RemovingInstanceFromPort_main_ObjectFlow16_LiteralInteger18 = new();
				public ClearStructuralFeatureAction RemovingInstanceFromPort_main_Clear_a_q = new();
					public OutputPin RemovingInstanceFromPort_main_Clear_a_q_result = new();
					public InputPin RemovingInstanceFromPort_main_Clear_a_q_object = new();
				public CreateObjectAction RemovingInstanceFromPort_main_Create_A = new();
					public OutputPin RemovingInstanceFromPort_main_Create_A_result = new();
						public LiteralInteger RemovingInstanceFromPort_main_Create_A_result_LiteralInteger19 = new();
						public LiteralUnlimitedNatural RemovingInstanceFromPort_main_Create_A_result_LiteralUnlimitedNatural20 = new();
				public ObjectFlow RemovingInstanceFromPort_main_ObjectFlow21 = new();
					public LiteralBoolean RemovingInstanceFromPort_main_ObjectFlow21_LiteralBoolean22 = new();
					public LiteralInteger RemovingInstanceFromPort_main_ObjectFlow21_LiteralInteger23 = new();
				public ObjectFlow RemovingInstanceFromPort_main_ObjectFlow24 = new();
					public LiteralInteger RemovingInstanceFromPort_main_ObjectFlow24_LiteralInteger25 = new();
					public LiteralBoolean RemovingInstanceFromPort_main_ObjectFlow24_LiteralBoolean26 = new();
				public CallBehaviorAction RemovingInstanceFromPort_main_Call_assertA = new();
					public InputPin RemovingInstanceFromPort_main_Call_assertA_a = new();
						public LiteralInteger RemovingInstanceFromPort_main_Call_assertA_a_LiteralInteger27 = new();
						public LiteralInteger RemovingInstanceFromPort_main_Call_assertA_a_LiteralInteger28 = new();
						public LiteralUnlimitedNatural RemovingInstanceFromPort_main_Call_assertA_a_LiteralUnlimitedNatural29 = new();
				public CallOperationAction RemovingInstanceFromPort_main_A_ = new();
					public InputPin RemovingInstanceFromPort_main_A__target = new();
						public LiteralUnlimitedNatural RemovingInstanceFromPort_main_A__target_LiteralUnlimitedNatural30 = new();
						public LiteralInteger RemovingInstanceFromPort_main_A__target_LiteralInteger31 = new();
					public OutputPin RemovingInstanceFromPort_main_A__result = new();
						public LiteralInteger RemovingInstanceFromPort_main_A__result_LiteralInteger32 = new();
						public LiteralInteger RemovingInstanceFromPort_main_A__result_LiteralInteger33 = new();
						public LiteralUnlimitedNatural RemovingInstanceFromPort_main_A__result_LiteralUnlimitedNatural34 = new();
			public Class_ RemovingInstanceFromPort_IImpl = new();
				public Operation RemovingInstanceFromPort_IImpl_setP_Integer = new();
					public Parameter RemovingInstanceFromPort_IImpl_setP_Integer_v = new();
				public InterfaceRealization RemovingInstanceFromPort_IImpl_IRealization = new();
			public Class_ RemovingInstanceFromPort_A = new();
				public Port RemovingInstanceFromPort_A_q = new();
				public Operation RemovingInstanceFromPort_A_A_A = new();
					public Parameter RemovingInstanceFromPort_A_A_A_result = new();
				public Connector RemovingInstanceFromPort_A_r = new();
					public ConnectorEnd RemovingInstanceFromPort_A_r_ConnectorEnd35 = new();
					public ConnectorEnd RemovingInstanceFromPort_A_r_ConnectorEnd36 = new();
				public Property RemovingInstanceFromPort_A_b = new();
			public Association RemovingInstanceFromPort_R = new();
				public Property RemovingInstanceFromPort_R_y = new();
				public Property RemovingInstanceFromPort_R_x = new();

		public static RemovingInstanceFromPortModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public RemovingInstanceFromPortModel()
		{
			/* Start of user code : Additional model initializations
		 	 * This section may be used to do any additional model initialization,
			 * for example initializing user-defined members.
		 	 * It will not be overwritten by future generation processes.
		 	 */
		
			/*
		 	 * End of user code
		 	 */
		}

		private void InitializeInMemoryModel()
		{
			// Create public members
			/*
			 * Model RemovingInstanceFromPort
			 */
			AddToElementRepository("RemovingInstanceFromPort", RemovingInstanceFromPort);
				AddToElementRepository("B", RemovingInstanceFromPort_B);
					AddToElementRepository("B_B", RemovingInstanceFromPort_B_B_B);
						AddToElementRepository("result", RemovingInstanceFromPort_B_B_B_result);
					AddToElementRepository("setPActivity", RemovingInstanceFromPort_B_setPActivity);
						AddToElementRepository("vParameterNode", RemovingInstanceFromPort_B_setPActivity_vParameterNode);
							AddToElementRepository("LiteralInteger0", RemovingInstanceFromPort_B_setPActivity_vParameterNode_LiteralInteger0);
						AddToElementRepository("this", RemovingInstanceFromPort_B_setPActivity_this);
							AddToElementRepository("result", RemovingInstanceFromPort_B_setPActivity_this_result);
								AddToElementRepository("LiteralUnlimitedNatural1", RemovingInstanceFromPort_B_setPActivity_this_result_LiteralUnlimitedNatural1);
								AddToElementRepository("LiteralInteger2", RemovingInstanceFromPort_B_setPActivity_this_result_LiteralInteger2);
						AddToElementRepository("v", RemovingInstanceFromPort_B_setPActivity_v);
						AddToElementRepository("ObjectFlow3", RemovingInstanceFromPort_B_setPActivity_ObjectFlow3);
							AddToElementRepository("LiteralBoolean4", RemovingInstanceFromPort_B_setPActivity_ObjectFlow3_LiteralBoolean4);
							AddToElementRepository("LiteralInteger5", RemovingInstanceFromPort_B_setPActivity_ObjectFlow3_LiteralInteger5);
						AddToElementRepository("ObjectFlow6", RemovingInstanceFromPort_B_setPActivity_ObjectFlow6);
							AddToElementRepository("LiteralBoolean7", RemovingInstanceFromPort_B_setPActivity_ObjectFlow6_LiteralBoolean7);
							AddToElementRepository("LiteralInteger8", RemovingInstanceFromPort_B_setPActivity_ObjectFlow6_LiteralInteger8);
						AddToElementRepository("Set this.p", RemovingInstanceFromPort_B_setPActivity_Set_this_p);
							AddToElementRepository("result", RemovingInstanceFromPort_B_setPActivity_Set_this_p_result);
								AddToElementRepository("LiteralUnlimitedNatural9", RemovingInstanceFromPort_B_setPActivity_Set_this_p_result_LiteralUnlimitedNatural9);
								AddToElementRepository("LiteralInteger10", RemovingInstanceFromPort_B_setPActivity_Set_this_p_result_LiteralInteger10);
							AddToElementRepository("value", RemovingInstanceFromPort_B_setPActivity_Set_this_p_value);
								AddToElementRepository("LiteralUnlimitedNatural11", RemovingInstanceFromPort_B_setPActivity_Set_this_p_value_LiteralUnlimitedNatural11);
								AddToElementRepository("LiteralInteger12", RemovingInstanceFromPort_B_setPActivity_Set_this_p_value_LiteralInteger12);
							AddToElementRepository("object", RemovingInstanceFromPort_B_setPActivity_Set_this_p_object);
								AddToElementRepository("LiteralUnlimitedNatural13", RemovingInstanceFromPort_B_setPActivity_Set_this_p_object_LiteralUnlimitedNatural13);
								AddToElementRepository("LiteralInteger14", RemovingInstanceFromPort_B_setPActivity_Set_this_p_object_LiteralInteger14);
					AddToElementRepository("setP_Integer", RemovingInstanceFromPort_B_setP_Integer);
						AddToElementRepository("v", RemovingInstanceFromPort_B_setP_Integer_v);
					AddToElementRepository("p", RemovingInstanceFromPort_B_p);
					AddToElementRepository("IRealization", RemovingInstanceFromPort_B_IRealization);
				AddToElementRepository("assertA", RemovingInstanceFromPort_assertA);
					AddToElementRepository("aParameterNode", RemovingInstanceFromPort_assertA_aParameterNode);
						AddToElementRepository("LiteralInteger15", RemovingInstanceFromPort_assertA_aParameterNode_LiteralInteger15);
					AddToElementRepository("assertionNotImplemented", RemovingInstanceFromPort_assertA_assertionNotImplemented);
					AddToElementRepository("a", RemovingInstanceFromPort_assertA_a);
					AddToElementRepository("Call assertionNotImplemented", RemovingInstanceFromPort_assertA_Call_assertionNotImplemented);
				AddToElementRepository("I", RemovingInstanceFromPort_I);
					AddToElementRepository("setP_Integer", RemovingInstanceFromPort_I_setP_Integer);
						AddToElementRepository("v", RemovingInstanceFromPort_I_setP_Integer_v);
				AddToElementRepository("main", RemovingInstanceFromPort_main);
					AddToElementRepository("ObjectFlow16", RemovingInstanceFromPort_main_ObjectFlow16);
						AddToElementRepository("LiteralBoolean17", RemovingInstanceFromPort_main_ObjectFlow16_LiteralBoolean17);
						AddToElementRepository("LiteralInteger18", RemovingInstanceFromPort_main_ObjectFlow16_LiteralInteger18);
					AddToElementRepository("Clear a.q", RemovingInstanceFromPort_main_Clear_a_q);
						AddToElementRepository("result", RemovingInstanceFromPort_main_Clear_a_q_result);
						AddToElementRepository("object", RemovingInstanceFromPort_main_Clear_a_q_object);
					AddToElementRepository("Create A", RemovingInstanceFromPort_main_Create_A);
						AddToElementRepository("result", RemovingInstanceFromPort_main_Create_A_result);
							AddToElementRepository("LiteralInteger19", RemovingInstanceFromPort_main_Create_A_result_LiteralInteger19);
							AddToElementRepository("LiteralUnlimitedNatural20", RemovingInstanceFromPort_main_Create_A_result_LiteralUnlimitedNatural20);
					AddToElementRepository("ObjectFlow21", RemovingInstanceFromPort_main_ObjectFlow21);
						AddToElementRepository("LiteralBoolean22", RemovingInstanceFromPort_main_ObjectFlow21_LiteralBoolean22);
						AddToElementRepository("LiteralInteger23", RemovingInstanceFromPort_main_ObjectFlow21_LiteralInteger23);
					AddToElementRepository("ObjectFlow24", RemovingInstanceFromPort_main_ObjectFlow24);
						AddToElementRepository("LiteralInteger25", RemovingInstanceFromPort_main_ObjectFlow24_LiteralInteger25);
						AddToElementRepository("LiteralBoolean26", RemovingInstanceFromPort_main_ObjectFlow24_LiteralBoolean26);
					AddToElementRepository("Call assertA", RemovingInstanceFromPort_main_Call_assertA);
						AddToElementRepository("a", RemovingInstanceFromPort_main_Call_assertA_a);
							AddToElementRepository("LiteralInteger27", RemovingInstanceFromPort_main_Call_assertA_a_LiteralInteger27);
							AddToElementRepository("LiteralInteger28", RemovingInstanceFromPort_main_Call_assertA_a_LiteralInteger28);
							AddToElementRepository("LiteralUnlimitedNatural29", RemovingInstanceFromPort_main_Call_assertA_a_LiteralUnlimitedNatural29);
					AddToElementRepository("A()", RemovingInstanceFromPort_main_A_);
						AddToElementRepository("target", RemovingInstanceFromPort_main_A__target);
							AddToElementRepository("LiteralUnlimitedNatural30", RemovingInstanceFromPort_main_A__target_LiteralUnlimitedNatural30);
							AddToElementRepository("LiteralInteger31", RemovingInstanceFromPort_main_A__target_LiteralInteger31);
						AddToElementRepository("result", RemovingInstanceFromPort_main_A__result);
							AddToElementRepository("LiteralInteger32", RemovingInstanceFromPort_main_A__result_LiteralInteger32);
							AddToElementRepository("LiteralInteger33", RemovingInstanceFromPort_main_A__result_LiteralInteger33);
							AddToElementRepository("LiteralUnlimitedNatural34", RemovingInstanceFromPort_main_A__result_LiteralUnlimitedNatural34);
				AddToElementRepository("IImpl", RemovingInstanceFromPort_IImpl);
					AddToElementRepository("setP_Integer", RemovingInstanceFromPort_IImpl_setP_Integer);
						AddToElementRepository("v", RemovingInstanceFromPort_IImpl_setP_Integer_v);
					AddToElementRepository("IRealization", RemovingInstanceFromPort_IImpl_IRealization);
				AddToElementRepository("A", RemovingInstanceFromPort_A);
					AddToElementRepository("q", RemovingInstanceFromPort_A_q);
					AddToElementRepository("A_A", RemovingInstanceFromPort_A_A_A);
						AddToElementRepository("result", RemovingInstanceFromPort_A_A_A_result);
					AddToElementRepository("r", RemovingInstanceFromPort_A_r);
						AddToElementRepository("ConnectorEnd35", RemovingInstanceFromPort_A_r_ConnectorEnd35);
						AddToElementRepository("ConnectorEnd36", RemovingInstanceFromPort_A_r_ConnectorEnd36);
					AddToElementRepository("b", RemovingInstanceFromPort_A_b);
				AddToElementRepository("R", RemovingInstanceFromPort_R);
					AddToElementRepository("y", RemovingInstanceFromPort_R_y);
					AddToElementRepository("x", RemovingInstanceFromPort_R_x);

			// Initialize public members
			/*
			 * Model RemovingInstanceFromPort
			 */
			RemovingInstanceFromPort.SetName("RemovingInstanceFromPort");
			RemovingInstanceFromPort.SetVisibility(VisibilityKind.public_);
				// Class B
				RemovingInstanceFromPort_B.SetName("B");
				RemovingInstanceFromPort_B.SetVisibility(VisibilityKind.public_);
				
					// Property p
					RemovingInstanceFromPort_B_p.SetName("p");
					RemovingInstanceFromPort_B_p.SetVisibility(VisibilityKind.public_);
					
					RemovingInstanceFromPort_B_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
				RemovingInstanceFromPort_B.AddOwnedAttribute(RemovingInstanceFromPort_B_p);
				// Activity setPActivity
					RemovingInstanceFromPort_B_setPActivity.SetName("setPActivity");
					RemovingInstanceFromPort_B_setPActivity.SetVisibility(VisibilityKind.public_);
					
						// Parameter v
						RemovingInstanceFromPort_B_setPActivity_v.SetName("v");
						RemovingInstanceFromPort_B_setPActivity_v.SetVisibility(VisibilityKind.public_);
						
						RemovingInstanceFromPort_B_setPActivity_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					RemovingInstanceFromPort_B_setPActivity.AddOwnedParameter(RemovingInstanceFromPort_B_setPActivity_v);
						// ActivityParameterNode vParameterNode
						RemovingInstanceFromPort_B_setPActivity_vParameterNode.SetName("vParameterNode");
						RemovingInstanceFromPort_B_setPActivity_vParameterNode.SetVisibility(VisibilityKind.public_);
						
						RemovingInstanceFromPort_B_setPActivity_vParameterNode.SetParameter(RemovingInstanceFromPort_B_setPActivity_v);
					RemovingInstanceFromPort_B_setPActivity.AddNode(RemovingInstanceFromPort_B_setPActivity_vParameterNode);
						// ReadSelfAction this
						RemovingInstanceFromPort_B_setPActivity_this.SetName("this");
						RemovingInstanceFromPort_B_setPActivity_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							RemovingInstanceFromPort_B_setPActivity_this_result.SetName("result");
							RemovingInstanceFromPort_B_setPActivity_this_result.SetVisibility(VisibilityKind.public_);
							RemovingInstanceFromPort_B_setPActivity_this_result.SetType(RemovingInstanceFromPort_B);
						RemovingInstanceFromPort_B_setPActivity_this.SetResult(RemovingInstanceFromPort_B_setPActivity_this_result);
					RemovingInstanceFromPort_B_setPActivity.AddNode(RemovingInstanceFromPort_B_setPActivity_this);
						// AddStructuralFeatureValueAction Set this.p
						RemovingInstanceFromPort_B_setPActivity_Set_this_p.SetName("Set this.p");
						RemovingInstanceFromPort_B_setPActivity_Set_this_p.SetVisibility(VisibilityKind.public_);
						RemovingInstanceFromPort_B_setPActivity_Set_this_p.SetStructuralFeature(RemovingInstanceFromPort_B_p);
							// InputPin object
							RemovingInstanceFromPort_B_setPActivity_Set_this_p_object.SetName("object");
							RemovingInstanceFromPort_B_setPActivity_Set_this_p_object.SetVisibility(VisibilityKind.public_);
							RemovingInstanceFromPort_B_setPActivity_Set_this_p_object.SetType(RemovingInstanceFromPort_B);
						RemovingInstanceFromPort_B_setPActivity_Set_this_p.SetObject(RemovingInstanceFromPort_B_setPActivity_Set_this_p_object);
							// InputPin value
							RemovingInstanceFromPort_B_setPActivity_Set_this_p_value.SetName("value");
							RemovingInstanceFromPort_B_setPActivity_Set_this_p_value.SetVisibility(VisibilityKind.public_);
							RemovingInstanceFromPort_B_setPActivity_Set_this_p_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						RemovingInstanceFromPort_B_setPActivity_Set_this_p.SetValue(RemovingInstanceFromPort_B_setPActivity_Set_this_p_value);
							// OutputPin result
							RemovingInstanceFromPort_B_setPActivity_Set_this_p_result.SetName("result");
							RemovingInstanceFromPort_B_setPActivity_Set_this_p_result.SetVisibility(VisibilityKind.public_);
							RemovingInstanceFromPort_B_setPActivity_Set_this_p_result.SetType(RemovingInstanceFromPort_B);
						RemovingInstanceFromPort_B_setPActivity_Set_this_p.SetResult(RemovingInstanceFromPort_B_setPActivity_Set_this_p_result);
					RemovingInstanceFromPort_B_setPActivity.AddNode(RemovingInstanceFromPort_B_setPActivity_Set_this_p);
						// ObjectFlow ObjectFlow3 from vParameterNode to value
						RemovingInstanceFromPort_B_setPActivity_ObjectFlow3.SetName("ObjectFlow3");
						RemovingInstanceFromPort_B_setPActivity_ObjectFlow3.SetVisibility(VisibilityKind.public_);
						
						RemovingInstanceFromPort_B_setPActivity_ObjectFlow3.SetSource(RemovingInstanceFromPort_B_setPActivity_vParameterNode);
						RemovingInstanceFromPort_B_setPActivity_ObjectFlow3.SetTarget(RemovingInstanceFromPort_B_setPActivity_Set_this_p_value);
							// LiteralBoolean LiteralBoolean4
							RemovingInstanceFromPort_B_setPActivity_ObjectFlow3_LiteralBoolean4.SetName("LiteralBoolean4");
							RemovingInstanceFromPort_B_setPActivity_ObjectFlow3_LiteralBoolean4.SetVisibility(VisibilityKind.public_);
							RemovingInstanceFromPort_B_setPActivity_ObjectFlow3_LiteralBoolean4.SetValue(true);
						RemovingInstanceFromPort_B_setPActivity_ObjectFlow3.SetGuard(RemovingInstanceFromPort_B_setPActivity_ObjectFlow3_LiteralBoolean4);
					RemovingInstanceFromPort_B_setPActivity.AddEdge(RemovingInstanceFromPort_B_setPActivity_ObjectFlow3);
						// ObjectFlow ObjectFlow6 from result to object
						RemovingInstanceFromPort_B_setPActivity_ObjectFlow6.SetName("ObjectFlow6");
						RemovingInstanceFromPort_B_setPActivity_ObjectFlow6.SetVisibility(VisibilityKind.public_);
						
						RemovingInstanceFromPort_B_setPActivity_ObjectFlow6.SetSource(RemovingInstanceFromPort_B_setPActivity_this_result);
						RemovingInstanceFromPort_B_setPActivity_ObjectFlow6.SetTarget(RemovingInstanceFromPort_B_setPActivity_Set_this_p_object);
							// LiteralBoolean LiteralBoolean7
							RemovingInstanceFromPort_B_setPActivity_ObjectFlow6_LiteralBoolean7.SetName("LiteralBoolean7");
							RemovingInstanceFromPort_B_setPActivity_ObjectFlow6_LiteralBoolean7.SetVisibility(VisibilityKind.public_);
							RemovingInstanceFromPort_B_setPActivity_ObjectFlow6_LiteralBoolean7.SetValue(true);
						RemovingInstanceFromPort_B_setPActivity_ObjectFlow6.SetGuard(RemovingInstanceFromPort_B_setPActivity_ObjectFlow6_LiteralBoolean7);
					RemovingInstanceFromPort_B_setPActivity.AddEdge(RemovingInstanceFromPort_B_setPActivity_ObjectFlow6);
				RemovingInstanceFromPort_B.AddOwnedBehavior(RemovingInstanceFromPort_B_setPActivity);
					RemovingInstanceFromPort_B_IRealization.SetName("IRealization");
					RemovingInstanceFromPort_B_IRealization.SetVisibility(VisibilityKind.public_);
					RemovingInstanceFromPort_B_IRealization.SetContract(RemovingInstanceFromPort_I);
					
				RemovingInstanceFromPort_B.AddInterfaceRealization(RemovingInstanceFromPort_B_IRealization);
				
					// Operation B_B
					RemovingInstanceFromPort_B_B_B.SetName("B_B");
					RemovingInstanceFromPort_B_B_B.SetVisibility(VisibilityKind.public_);
						// Parameter result
						RemovingInstanceFromPort_B_B_B_result.SetName("result");
						RemovingInstanceFromPort_B_B_B_result.SetVisibility(VisibilityKind.public_);
						
						RemovingInstanceFromPort_B_B_B_result.SetType(RemovingInstanceFromPort_B);
						RemovingInstanceFromPort_B_B_B_result.SetDirection(ParameterDirectionKind.return_);
					RemovingInstanceFromPort_B_B_B.AddOwnedParameter(RemovingInstanceFromPort_B_B_B_result);
					RemovingInstanceFromPort_B_B_B.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				RemovingInstanceFromPort_B.AddOwnedOperation(RemovingInstanceFromPort_B_B_B);
					// Operation setP_Integer
					RemovingInstanceFromPort_B_setP_Integer.SetName("setP_Integer");
					RemovingInstanceFromPort_B_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						RemovingInstanceFromPort_B_setP_Integer_v.SetName("v");
						RemovingInstanceFromPort_B_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						RemovingInstanceFromPort_B_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					RemovingInstanceFromPort_B_setP_Integer.AddOwnedParameter(RemovingInstanceFromPort_B_setP_Integer_v);
					RemovingInstanceFromPort_B_setP_Integer.AddMethod(RemovingInstanceFromPort_B_setPActivity);
				RemovingInstanceFromPort_B.AddOwnedOperation(RemovingInstanceFromPort_B_setP_Integer);
			RemovingInstanceFromPort.AddPackagedElement(RemovingInstanceFromPort_B);
				// Activity assertA
				RemovingInstanceFromPort_assertA.SetName("assertA");
				RemovingInstanceFromPort_assertA.SetVisibility(VisibilityKind.public_);
				// FunctionBehavior assertionNotImplemented
					RemovingInstanceFromPort_assertA_assertionNotImplemented.SetName("assertionNotImplemented");
					RemovingInstanceFromPort_assertA_assertionNotImplemented.SetVisibility(VisibilityKind.public_);
					RemovingInstanceFromPort_assertA_assertionNotImplemented.AddLanguage("C#");
					RemovingInstanceFromPort_assertA_assertionNotImplemented.AddBody("Console.WriteLine(\"Assertion currenlty not implemented! Model was validated by manual debugging.\");");
				RemovingInstanceFromPort_assertA.AddOwnedBehavior(RemovingInstanceFromPort_assertA_assertionNotImplemented);
					// Parameter a
					RemovingInstanceFromPort_assertA_a.SetName("a");
					RemovingInstanceFromPort_assertA_a.SetVisibility(VisibilityKind.public_);
					
					RemovingInstanceFromPort_assertA_a.SetType(RemovingInstanceFromPort_A);
				RemovingInstanceFromPort_assertA.AddOwnedParameter(RemovingInstanceFromPort_assertA_a);
					// ActivityParameterNode aParameterNode
					RemovingInstanceFromPort_assertA_aParameterNode.SetName("aParameterNode");
					RemovingInstanceFromPort_assertA_aParameterNode.SetVisibility(VisibilityKind.public_);
				RemovingInstanceFromPort_assertA.AddNode(RemovingInstanceFromPort_assertA_aParameterNode);
					// CallBehaviorAction Call assertionNotImplemented
					RemovingInstanceFromPort_assertA_Call_assertionNotImplemented.SetName("Call assertionNotImplemented");
					RemovingInstanceFromPort_assertA_Call_assertionNotImplemented.SetVisibility(VisibilityKind.public_);
					RemovingInstanceFromPort_assertA_Call_assertionNotImplemented.SetBehavior(RemovingInstanceFromPort_assertA_assertionNotImplemented);
				RemovingInstanceFromPort_assertA.AddNode(RemovingInstanceFromPort_assertA_Call_assertionNotImplemented);
			RemovingInstanceFromPort.AddPackagedElement(RemovingInstanceFromPort_assertA);
				// Interface I
				RemovingInstanceFromPort_I.SetName("I");
				RemovingInstanceFromPort_I.SetVisibility(VisibilityKind.public_);
					// Operation setP_Integer
					RemovingInstanceFromPort_I_setP_Integer.SetName("setP_Integer");
					RemovingInstanceFromPort_I_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						RemovingInstanceFromPort_I_setP_Integer_v.SetName("v");
						RemovingInstanceFromPort_I_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						RemovingInstanceFromPort_I_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					RemovingInstanceFromPort_I_setP_Integer.AddOwnedParameter(RemovingInstanceFromPort_I_setP_Integer_v);
				RemovingInstanceFromPort_I.AddOwnedOperation(RemovingInstanceFromPort_I_setP_Integer);
			RemovingInstanceFromPort.AddPackagedElement(RemovingInstanceFromPort_I);
				// Activity main
				RemovingInstanceFromPort_main.SetName("main");
				RemovingInstanceFromPort_main.SetVisibility(VisibilityKind.public_);
					// ClearStructuralFeatureAction Clear a.q
					RemovingInstanceFromPort_main_Clear_a_q.SetName("Clear a.q");
					RemovingInstanceFromPort_main_Clear_a_q.SetVisibility(VisibilityKind.public_);
					RemovingInstanceFromPort_main_Clear_a_q.SetStructuralFeature(RemovingInstanceFromPort_A_q);
						// InputPin object
						RemovingInstanceFromPort_main_Clear_a_q_object.SetName("object");
						RemovingInstanceFromPort_main_Clear_a_q_object.SetVisibility(VisibilityKind.public_);
						RemovingInstanceFromPort_main_Clear_a_q_object.SetType(RemovingInstanceFromPort_A);
					RemovingInstanceFromPort_main_Clear_a_q.SetObject(RemovingInstanceFromPort_main_Clear_a_q_object);
						// OutputPin result
						RemovingInstanceFromPort_main_Clear_a_q_result.SetName("result");
						RemovingInstanceFromPort_main_Clear_a_q_result.SetVisibility(VisibilityKind.public_);
						RemovingInstanceFromPort_main_Clear_a_q_result.SetType(RemovingInstanceFromPort_A);
					RemovingInstanceFromPort_main_Clear_a_q.SetResult(RemovingInstanceFromPort_main_Clear_a_q_result);
				RemovingInstanceFromPort_main.AddNode(RemovingInstanceFromPort_main_Clear_a_q);
					// CreateObjectAction Create A
					RemovingInstanceFromPort_main_Create_A.SetName("Create A");
					RemovingInstanceFromPort_main_Create_A.SetVisibility(VisibilityKind.public_);
					RemovingInstanceFromPort_main_Create_A.SetClassifier(RemovingInstanceFromPort_A);
						// OutputPin result
						RemovingInstanceFromPort_main_Create_A_result.SetName("result");
						RemovingInstanceFromPort_main_Create_A_result.SetVisibility(VisibilityKind.public_);
						RemovingInstanceFromPort_main_Create_A_result.SetType(RemovingInstanceFromPort_A);
					RemovingInstanceFromPort_main_Create_A.SetResult(RemovingInstanceFromPort_main_Create_A_result);
				RemovingInstanceFromPort_main.AddNode(RemovingInstanceFromPort_main_Create_A);
					// CallBehaviorAction Call assertA
					RemovingInstanceFromPort_main_Call_assertA.SetName("Call assertA");
					RemovingInstanceFromPort_main_Call_assertA.SetVisibility(VisibilityKind.public_);
					RemovingInstanceFromPort_main_Call_assertA.SetBehavior(RemovingInstanceFromPort_assertA);
						// InputPin a
						RemovingInstanceFromPort_main_Call_assertA_a.SetName("a");
						RemovingInstanceFromPort_main_Call_assertA_a.SetVisibility(VisibilityKind.public_);
						RemovingInstanceFromPort_main_Call_assertA_a.SetType(RemovingInstanceFromPort_A);
					RemovingInstanceFromPort_main_Call_assertA.AddArgument(RemovingInstanceFromPort_main_Call_assertA_a);
				RemovingInstanceFromPort_main.AddNode(RemovingInstanceFromPort_main_Call_assertA);
					// CallOperationAction A()
					RemovingInstanceFromPort_main_A_.SetName("A()");
					RemovingInstanceFromPort_main_A_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						RemovingInstanceFromPort_main_A__result.SetName("result");
						RemovingInstanceFromPort_main_A__result.SetVisibility(VisibilityKind.public_);
						RemovingInstanceFromPort_main_A__result.SetType(RemovingInstanceFromPort_A);
					RemovingInstanceFromPort_main_A_.AddResult(RemovingInstanceFromPort_main_A__result);
					RemovingInstanceFromPort_main_A_.SetOperation(RemovingInstanceFromPort_A_A_A);
						// InputPin target
						RemovingInstanceFromPort_main_A__target.SetName("target");
						RemovingInstanceFromPort_main_A__target.SetVisibility(VisibilityKind.public_);
						RemovingInstanceFromPort_main_A__target.SetType(RemovingInstanceFromPort_A);
					RemovingInstanceFromPort_main_A_.SetTarget(RemovingInstanceFromPort_main_A__target);
				RemovingInstanceFromPort_main.AddNode(RemovingInstanceFromPort_main_A_);
					// ObjectFlow ObjectFlow16 from result to a
					RemovingInstanceFromPort_main_ObjectFlow16.SetName("ObjectFlow16");
					RemovingInstanceFromPort_main_ObjectFlow16.SetVisibility(VisibilityKind.public_);
					
					RemovingInstanceFromPort_main_ObjectFlow16.SetSource(RemovingInstanceFromPort_main_Clear_a_q_result);
					RemovingInstanceFromPort_main_ObjectFlow16.SetTarget(RemovingInstanceFromPort_main_Call_assertA_a);
						// LiteralBoolean LiteralBoolean17
						RemovingInstanceFromPort_main_ObjectFlow16_LiteralBoolean17.SetName("LiteralBoolean17");
						RemovingInstanceFromPort_main_ObjectFlow16_LiteralBoolean17.SetVisibility(VisibilityKind.public_);
						RemovingInstanceFromPort_main_ObjectFlow16_LiteralBoolean17.SetValue(true);
					RemovingInstanceFromPort_main_ObjectFlow16.SetGuard(RemovingInstanceFromPort_main_ObjectFlow16_LiteralBoolean17);
				RemovingInstanceFromPort_main.AddEdge(RemovingInstanceFromPort_main_ObjectFlow16);
					// ObjectFlow ObjectFlow21 from result to object
					RemovingInstanceFromPort_main_ObjectFlow21.SetName("ObjectFlow21");
					RemovingInstanceFromPort_main_ObjectFlow21.SetVisibility(VisibilityKind.public_);
					
					RemovingInstanceFromPort_main_ObjectFlow21.SetSource(RemovingInstanceFromPort_main_A__result);
					RemovingInstanceFromPort_main_ObjectFlow21.SetTarget(RemovingInstanceFromPort_main_Clear_a_q_object);
						// LiteralBoolean LiteralBoolean22
						RemovingInstanceFromPort_main_ObjectFlow21_LiteralBoolean22.SetName("LiteralBoolean22");
						RemovingInstanceFromPort_main_ObjectFlow21_LiteralBoolean22.SetVisibility(VisibilityKind.public_);
						RemovingInstanceFromPort_main_ObjectFlow21_LiteralBoolean22.SetValue(true);
					RemovingInstanceFromPort_main_ObjectFlow21.SetGuard(RemovingInstanceFromPort_main_ObjectFlow21_LiteralBoolean22);
				RemovingInstanceFromPort_main.AddEdge(RemovingInstanceFromPort_main_ObjectFlow21);
					// ObjectFlow ObjectFlow24 from result to target
					RemovingInstanceFromPort_main_ObjectFlow24.SetName("ObjectFlow24");
					RemovingInstanceFromPort_main_ObjectFlow24.SetVisibility(VisibilityKind.public_);
					
					RemovingInstanceFromPort_main_ObjectFlow24.SetSource(RemovingInstanceFromPort_main_Create_A_result);
					RemovingInstanceFromPort_main_ObjectFlow24.SetTarget(RemovingInstanceFromPort_main_A__target);
						// LiteralBoolean LiteralBoolean26
						RemovingInstanceFromPort_main_ObjectFlow24_LiteralBoolean26.SetName("LiteralBoolean26");
						RemovingInstanceFromPort_main_ObjectFlow24_LiteralBoolean26.SetVisibility(VisibilityKind.public_);
						RemovingInstanceFromPort_main_ObjectFlow24_LiteralBoolean26.SetValue(true);
					RemovingInstanceFromPort_main_ObjectFlow24.SetGuard(RemovingInstanceFromPort_main_ObjectFlow24_LiteralBoolean26);
				RemovingInstanceFromPort_main.AddEdge(RemovingInstanceFromPort_main_ObjectFlow24);
			RemovingInstanceFromPort.AddPackagedElement(RemovingInstanceFromPort_main);
				// Class IImpl
				RemovingInstanceFromPort_IImpl.SetName("IImpl");
				RemovingInstanceFromPort_IImpl.SetVisibility(VisibilityKind.public_);
				RemovingInstanceFromPort_IImpl_IRealization.SetName("IRealization");
					RemovingInstanceFromPort_IImpl_IRealization.SetVisibility(VisibilityKind.public_);
					RemovingInstanceFromPort_IImpl_IRealization.SetContract(RemovingInstanceFromPort_I);
					
				RemovingInstanceFromPort_IImpl.AddInterfaceRealization(RemovingInstanceFromPort_IImpl_IRealization);
				
					// Operation setP_Integer
					RemovingInstanceFromPort_IImpl_setP_Integer.SetName("setP_Integer");
					RemovingInstanceFromPort_IImpl_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						RemovingInstanceFromPort_IImpl_setP_Integer_v.SetName("v");
						RemovingInstanceFromPort_IImpl_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						RemovingInstanceFromPort_IImpl_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					RemovingInstanceFromPort_IImpl_setP_Integer.AddOwnedParameter(RemovingInstanceFromPort_IImpl_setP_Integer_v);
				RemovingInstanceFromPort_IImpl.AddOwnedOperation(RemovingInstanceFromPort_IImpl_setP_Integer);
			RemovingInstanceFromPort.AddPackagedElement(RemovingInstanceFromPort_IImpl);
				// Class A
				RemovingInstanceFromPort_A.SetName("A");
				RemovingInstanceFromPort_A.SetVisibility(VisibilityKind.public_);
				
					// Port q
					RemovingInstanceFromPort_A_q.SetName("q");
					RemovingInstanceFromPort_A_q.SetVisibility(VisibilityKind.public_);
					
					RemovingInstanceFromPort_A_q.SetType(RemovingInstanceFromPort_IImpl);
					RemovingInstanceFromPort_A_q.SetAggregation(AggregationKind.composite);
					RemovingInstanceFromPort_A_q.isService = true;
					RemovingInstanceFromPort_A_q.AddProvided(RemovingInstanceFromPort_I);
				RemovingInstanceFromPort_A.AddOwnedAttribute(RemovingInstanceFromPort_A_q);
					// Property b
					RemovingInstanceFromPort_A_b.SetName("b");
					RemovingInstanceFromPort_A_b.SetVisibility(VisibilityKind.public_);
					
					RemovingInstanceFromPort_A_b.SetType(RemovingInstanceFromPort_B);
					RemovingInstanceFromPort_A_b.SetAggregation(AggregationKind.composite);
				RemovingInstanceFromPort_A.AddOwnedAttribute(RemovingInstanceFromPort_A_b);
				
				RemovingInstanceFromPort_A_r.SetName("r");
					RemovingInstanceFromPort_A_r.SetVisibility(VisibilityKind.public_);
						
						RemovingInstanceFromPort_A_r_ConnectorEnd35.SetRole(RemovingInstanceFromPort_A_q);
						
					RemovingInstanceFromPort_A_r.AddEnd(RemovingInstanceFromPort_A_r_ConnectorEnd35);
						
						RemovingInstanceFromPort_A_r_ConnectorEnd36.SetRole(RemovingInstanceFromPort_A_b);
						
					RemovingInstanceFromPort_A_r.AddEnd(RemovingInstanceFromPort_A_r_ConnectorEnd36);
					RemovingInstanceFromPort_A_r.SetType(RemovingInstanceFromPort_R);
				RemovingInstanceFromPort_A.AddOwnedConnector(RemovingInstanceFromPort_A_r);
					// Operation A_A
					RemovingInstanceFromPort_A_A_A.SetName("A_A");
					RemovingInstanceFromPort_A_A_A.SetVisibility(VisibilityKind.public_);
						// Parameter result
						RemovingInstanceFromPort_A_A_A_result.SetName("result");
						RemovingInstanceFromPort_A_A_A_result.SetVisibility(VisibilityKind.public_);
						
						RemovingInstanceFromPort_A_A_A_result.SetType(RemovingInstanceFromPort_A);
						RemovingInstanceFromPort_A_A_A_result.SetDirection(ParameterDirectionKind.return_);
					RemovingInstanceFromPort_A_A_A.AddOwnedParameter(RemovingInstanceFromPort_A_A_A_result);
					RemovingInstanceFromPort_A_A_A.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				RemovingInstanceFromPort_A.AddOwnedOperation(RemovingInstanceFromPort_A_A_A);
			RemovingInstanceFromPort.AddPackagedElement(RemovingInstanceFromPort_A);
				// Association R
				RemovingInstanceFromPort_R.SetName("R");
				RemovingInstanceFromPort_R.SetVisibility(VisibilityKind.public_);
				RemovingInstanceFromPort_R.AddOwnedEnd(RemovingInstanceFromPort_R_x);
				RemovingInstanceFromPort_R.AddOwnedEnd(RemovingInstanceFromPort_R_y);
			RemovingInstanceFromPort.AddPackagedElement(RemovingInstanceFromPort_R);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // RemovingInstanceFromPortModel
}
