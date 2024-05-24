/*
 * RemovingInstanceFromPartModel.cs
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

namespace RemovingInstanceFromPart
{
	public class RemovingInstanceFromPartModel : InMemoryModel
	{
		private static RemovingInstanceFromPartModel? instance;

		/*
		 * Model RemovingInstanceFromPart
		 */
		public Package RemovingInstanceFromPart = new();
			public Class_ RemovingInstanceFromPart_B = new();
				public Operation RemovingInstanceFromPart_B_B_B = new();
					public Parameter RemovingInstanceFromPart_B_B_B_result = new();
				public Activity RemovingInstanceFromPart_B_setPActivity = new();
					public ActivityParameterNode RemovingInstanceFromPart_B_setPActivity_vParameterNode = new();
						public LiteralInteger RemovingInstanceFromPart_B_setPActivity_vParameterNode_LiteralInteger0 = new();
					public ReadSelfAction RemovingInstanceFromPart_B_setPActivity_this = new();
						public OutputPin RemovingInstanceFromPart_B_setPActivity_this_result = new();
							public LiteralUnlimitedNatural RemovingInstanceFromPart_B_setPActivity_this_result_LiteralUnlimitedNatural1 = new();
							public LiteralInteger RemovingInstanceFromPart_B_setPActivity_this_result_LiteralInteger2 = new();
					public Parameter RemovingInstanceFromPart_B_setPActivity_v = new();
					public ObjectFlow RemovingInstanceFromPart_B_setPActivity_ObjectFlow3 = new();
						public LiteralBoolean RemovingInstanceFromPart_B_setPActivity_ObjectFlow3_LiteralBoolean4 = new();
						public LiteralInteger RemovingInstanceFromPart_B_setPActivity_ObjectFlow3_LiteralInteger5 = new();
					public ObjectFlow RemovingInstanceFromPart_B_setPActivity_ObjectFlow6 = new();
						public LiteralBoolean RemovingInstanceFromPart_B_setPActivity_ObjectFlow6_LiteralBoolean7 = new();
						public LiteralInteger RemovingInstanceFromPart_B_setPActivity_ObjectFlow6_LiteralInteger8 = new();
					public AddStructuralFeatureValueAction RemovingInstanceFromPart_B_setPActivity_Set_this_p = new();
						public OutputPin RemovingInstanceFromPart_B_setPActivity_Set_this_p_result = new();
							public LiteralUnlimitedNatural RemovingInstanceFromPart_B_setPActivity_Set_this_p_result_LiteralUnlimitedNatural9 = new();
							public LiteralInteger RemovingInstanceFromPart_B_setPActivity_Set_this_p_result_LiteralInteger10 = new();
						public InputPin RemovingInstanceFromPart_B_setPActivity_Set_this_p_value = new();
							public LiteralUnlimitedNatural RemovingInstanceFromPart_B_setPActivity_Set_this_p_value_LiteralUnlimitedNatural11 = new();
							public LiteralInteger RemovingInstanceFromPart_B_setPActivity_Set_this_p_value_LiteralInteger12 = new();
						public InputPin RemovingInstanceFromPart_B_setPActivity_Set_this_p_object = new();
							public LiteralUnlimitedNatural RemovingInstanceFromPart_B_setPActivity_Set_this_p_object_LiteralUnlimitedNatural13 = new();
							public LiteralInteger RemovingInstanceFromPart_B_setPActivity_Set_this_p_object_LiteralInteger14 = new();
				public Operation RemovingInstanceFromPart_B_setP_Integer = new();
					public Parameter RemovingInstanceFromPart_B_setP_Integer_v = new();
				public Property RemovingInstanceFromPart_B_p = new();
				public InterfaceRealization RemovingInstanceFromPart_B_IRealization = new();
			public Activity RemovingInstanceFromPart_assertA = new();
				public ActivityParameterNode RemovingInstanceFromPart_assertA_aParameterNode = new();
					public LiteralInteger RemovingInstanceFromPart_assertA_aParameterNode_LiteralInteger15 = new();
				public OpaqueBehavior RemovingInstanceFromPart_assertA_assertionNotImplemented = new();
				public Parameter RemovingInstanceFromPart_assertA_a = new();
				public CallBehaviorAction RemovingInstanceFromPart_assertA_Call_assertionNotImplemented = new();
			public Interface RemovingInstanceFromPart_I = new();
				public Operation RemovingInstanceFromPart_I_setP_Integer = new();
					public Parameter RemovingInstanceFromPart_I_setP_Integer_v = new();
			public Activity RemovingInstanceFromPart_main = new();
				public ObjectFlow RemovingInstanceFromPart_main_ObjectFlow16 = new();
					public LiteralBoolean RemovingInstanceFromPart_main_ObjectFlow16_LiteralBoolean17 = new();
					public LiteralInteger RemovingInstanceFromPart_main_ObjectFlow16_LiteralInteger18 = new();
				public ClearStructuralFeatureAction RemovingInstanceFromPart_main_Clear_a_b = new();
					public OutputPin RemovingInstanceFromPart_main_Clear_a_b_result = new();
					public InputPin RemovingInstanceFromPart_main_Clear_a_b_object = new();
				public CreateObjectAction RemovingInstanceFromPart_main_Create_A = new();
					public OutputPin RemovingInstanceFromPart_main_Create_A_result = new();
						public LiteralInteger RemovingInstanceFromPart_main_Create_A_result_LiteralInteger19 = new();
						public LiteralUnlimitedNatural RemovingInstanceFromPart_main_Create_A_result_LiteralUnlimitedNatural20 = new();
				public ObjectFlow RemovingInstanceFromPart_main_ObjectFlow21 = new();
					public LiteralBoolean RemovingInstanceFromPart_main_ObjectFlow21_LiteralBoolean22 = new();
					public LiteralInteger RemovingInstanceFromPart_main_ObjectFlow21_LiteralInteger23 = new();
				public ObjectFlow RemovingInstanceFromPart_main_ObjectFlow24 = new();
					public LiteralInteger RemovingInstanceFromPart_main_ObjectFlow24_LiteralInteger25 = new();
					public LiteralBoolean RemovingInstanceFromPart_main_ObjectFlow24_LiteralBoolean26 = new();
				public CallBehaviorAction RemovingInstanceFromPart_main_Call_assertA = new();
					public InputPin RemovingInstanceFromPart_main_Call_assertA_a = new();
						public LiteralInteger RemovingInstanceFromPart_main_Call_assertA_a_LiteralInteger27 = new();
						public LiteralInteger RemovingInstanceFromPart_main_Call_assertA_a_LiteralInteger28 = new();
						public LiteralUnlimitedNatural RemovingInstanceFromPart_main_Call_assertA_a_LiteralUnlimitedNatural29 = new();
				public CallOperationAction RemovingInstanceFromPart_main_A_ = new();
					public InputPin RemovingInstanceFromPart_main_A__target = new();
						public LiteralUnlimitedNatural RemovingInstanceFromPart_main_A__target_LiteralUnlimitedNatural30 = new();
						public LiteralInteger RemovingInstanceFromPart_main_A__target_LiteralInteger31 = new();
					public OutputPin RemovingInstanceFromPart_main_A__result = new();
						public LiteralInteger RemovingInstanceFromPart_main_A__result_LiteralInteger32 = new();
						public LiteralInteger RemovingInstanceFromPart_main_A__result_LiteralInteger33 = new();
						public LiteralUnlimitedNatural RemovingInstanceFromPart_main_A__result_LiteralUnlimitedNatural34 = new();
			public Class_ RemovingInstanceFromPart_IImpl = new();
				public Operation RemovingInstanceFromPart_IImpl_setP_Integer = new();
					public Parameter RemovingInstanceFromPart_IImpl_setP_Integer_v = new();
				public InterfaceRealization RemovingInstanceFromPart_IImpl_IRealization = new();
			public Class_ RemovingInstanceFromPart_A = new();
				public Port RemovingInstanceFromPart_A_q = new();
				public Operation RemovingInstanceFromPart_A_A_A = new();
					public Parameter RemovingInstanceFromPart_A_A_A_result = new();
				public Connector RemovingInstanceFromPart_A_r = new();
					public ConnectorEnd RemovingInstanceFromPart_A_r_ConnectorEnd35 = new();
					public ConnectorEnd RemovingInstanceFromPart_A_r_ConnectorEnd36 = new();
				public Property RemovingInstanceFromPart_A_b = new();
			public Association RemovingInstanceFromPart_R = new();
				public Property RemovingInstanceFromPart_R_y = new();
				public Property RemovingInstanceFromPart_R_x = new();

		public static RemovingInstanceFromPartModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public RemovingInstanceFromPartModel()
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
			 * Model RemovingInstanceFromPart
			 */
			AddToElementRepository("RemovingInstanceFromPart", RemovingInstanceFromPart);
				AddToElementRepository("B", RemovingInstanceFromPart_B);
					AddToElementRepository("B_B", RemovingInstanceFromPart_B_B_B);
						AddToElementRepository("result", RemovingInstanceFromPart_B_B_B_result);
					AddToElementRepository("setPActivity", RemovingInstanceFromPart_B_setPActivity);
						AddToElementRepository("vParameterNode", RemovingInstanceFromPart_B_setPActivity_vParameterNode);
							AddToElementRepository("LiteralInteger0", RemovingInstanceFromPart_B_setPActivity_vParameterNode_LiteralInteger0);
						AddToElementRepository("this", RemovingInstanceFromPart_B_setPActivity_this);
							AddToElementRepository("result", RemovingInstanceFromPart_B_setPActivity_this_result);
								AddToElementRepository("LiteralUnlimitedNatural1", RemovingInstanceFromPart_B_setPActivity_this_result_LiteralUnlimitedNatural1);
								AddToElementRepository("LiteralInteger2", RemovingInstanceFromPart_B_setPActivity_this_result_LiteralInteger2);
						AddToElementRepository("v", RemovingInstanceFromPart_B_setPActivity_v);
						AddToElementRepository("ObjectFlow3", RemovingInstanceFromPart_B_setPActivity_ObjectFlow3);
							AddToElementRepository("LiteralBoolean4", RemovingInstanceFromPart_B_setPActivity_ObjectFlow3_LiteralBoolean4);
							AddToElementRepository("LiteralInteger5", RemovingInstanceFromPart_B_setPActivity_ObjectFlow3_LiteralInteger5);
						AddToElementRepository("ObjectFlow6", RemovingInstanceFromPart_B_setPActivity_ObjectFlow6);
							AddToElementRepository("LiteralBoolean7", RemovingInstanceFromPart_B_setPActivity_ObjectFlow6_LiteralBoolean7);
							AddToElementRepository("LiteralInteger8", RemovingInstanceFromPart_B_setPActivity_ObjectFlow6_LiteralInteger8);
						AddToElementRepository("Set this.p", RemovingInstanceFromPart_B_setPActivity_Set_this_p);
							AddToElementRepository("result", RemovingInstanceFromPart_B_setPActivity_Set_this_p_result);
								AddToElementRepository("LiteralUnlimitedNatural9", RemovingInstanceFromPart_B_setPActivity_Set_this_p_result_LiteralUnlimitedNatural9);
								AddToElementRepository("LiteralInteger10", RemovingInstanceFromPart_B_setPActivity_Set_this_p_result_LiteralInteger10);
							AddToElementRepository("value", RemovingInstanceFromPart_B_setPActivity_Set_this_p_value);
								AddToElementRepository("LiteralUnlimitedNatural11", RemovingInstanceFromPart_B_setPActivity_Set_this_p_value_LiteralUnlimitedNatural11);
								AddToElementRepository("LiteralInteger12", RemovingInstanceFromPart_B_setPActivity_Set_this_p_value_LiteralInteger12);
							AddToElementRepository("object", RemovingInstanceFromPart_B_setPActivity_Set_this_p_object);
								AddToElementRepository("LiteralUnlimitedNatural13", RemovingInstanceFromPart_B_setPActivity_Set_this_p_object_LiteralUnlimitedNatural13);
								AddToElementRepository("LiteralInteger14", RemovingInstanceFromPart_B_setPActivity_Set_this_p_object_LiteralInteger14);
					AddToElementRepository("setP_Integer", RemovingInstanceFromPart_B_setP_Integer);
						AddToElementRepository("v", RemovingInstanceFromPart_B_setP_Integer_v);
					AddToElementRepository("p", RemovingInstanceFromPart_B_p);
					AddToElementRepository("IRealization", RemovingInstanceFromPart_B_IRealization);
				AddToElementRepository("assertA", RemovingInstanceFromPart_assertA);
					AddToElementRepository("aParameterNode", RemovingInstanceFromPart_assertA_aParameterNode);
						AddToElementRepository("LiteralInteger15", RemovingInstanceFromPart_assertA_aParameterNode_LiteralInteger15);
					AddToElementRepository("assertionNotImplemented", RemovingInstanceFromPart_assertA_assertionNotImplemented);
					AddToElementRepository("a", RemovingInstanceFromPart_assertA_a);
					AddToElementRepository("Call assertionNotImplemented", RemovingInstanceFromPart_assertA_Call_assertionNotImplemented);
				AddToElementRepository("I", RemovingInstanceFromPart_I);
					AddToElementRepository("setP_Integer", RemovingInstanceFromPart_I_setP_Integer);
						AddToElementRepository("v", RemovingInstanceFromPart_I_setP_Integer_v);
				AddToElementRepository("main", RemovingInstanceFromPart_main);
					AddToElementRepository("ObjectFlow16", RemovingInstanceFromPart_main_ObjectFlow16);
						AddToElementRepository("LiteralBoolean17", RemovingInstanceFromPart_main_ObjectFlow16_LiteralBoolean17);
						AddToElementRepository("LiteralInteger18", RemovingInstanceFromPart_main_ObjectFlow16_LiteralInteger18);
					AddToElementRepository("Clear a.b", RemovingInstanceFromPart_main_Clear_a_b);
						AddToElementRepository("result", RemovingInstanceFromPart_main_Clear_a_b_result);
						AddToElementRepository("object", RemovingInstanceFromPart_main_Clear_a_b_object);
					AddToElementRepository("Create A", RemovingInstanceFromPart_main_Create_A);
						AddToElementRepository("result", RemovingInstanceFromPart_main_Create_A_result);
							AddToElementRepository("LiteralInteger19", RemovingInstanceFromPart_main_Create_A_result_LiteralInteger19);
							AddToElementRepository("LiteralUnlimitedNatural20", RemovingInstanceFromPart_main_Create_A_result_LiteralUnlimitedNatural20);
					AddToElementRepository("ObjectFlow21", RemovingInstanceFromPart_main_ObjectFlow21);
						AddToElementRepository("LiteralBoolean22", RemovingInstanceFromPart_main_ObjectFlow21_LiteralBoolean22);
						AddToElementRepository("LiteralInteger23", RemovingInstanceFromPart_main_ObjectFlow21_LiteralInteger23);
					AddToElementRepository("ObjectFlow24", RemovingInstanceFromPart_main_ObjectFlow24);
						AddToElementRepository("LiteralInteger25", RemovingInstanceFromPart_main_ObjectFlow24_LiteralInteger25);
						AddToElementRepository("LiteralBoolean26", RemovingInstanceFromPart_main_ObjectFlow24_LiteralBoolean26);
					AddToElementRepository("Call assertA", RemovingInstanceFromPart_main_Call_assertA);
						AddToElementRepository("a", RemovingInstanceFromPart_main_Call_assertA_a);
							AddToElementRepository("LiteralInteger27", RemovingInstanceFromPart_main_Call_assertA_a_LiteralInteger27);
							AddToElementRepository("LiteralInteger28", RemovingInstanceFromPart_main_Call_assertA_a_LiteralInteger28);
							AddToElementRepository("LiteralUnlimitedNatural29", RemovingInstanceFromPart_main_Call_assertA_a_LiteralUnlimitedNatural29);
					AddToElementRepository("A()", RemovingInstanceFromPart_main_A_);
						AddToElementRepository("target", RemovingInstanceFromPart_main_A__target);
							AddToElementRepository("LiteralUnlimitedNatural30", RemovingInstanceFromPart_main_A__target_LiteralUnlimitedNatural30);
							AddToElementRepository("LiteralInteger31", RemovingInstanceFromPart_main_A__target_LiteralInteger31);
						AddToElementRepository("result", RemovingInstanceFromPart_main_A__result);
							AddToElementRepository("LiteralInteger32", RemovingInstanceFromPart_main_A__result_LiteralInteger32);
							AddToElementRepository("LiteralInteger33", RemovingInstanceFromPart_main_A__result_LiteralInteger33);
							AddToElementRepository("LiteralUnlimitedNatural34", RemovingInstanceFromPart_main_A__result_LiteralUnlimitedNatural34);
				AddToElementRepository("IImpl", RemovingInstanceFromPart_IImpl);
					AddToElementRepository("setP_Integer", RemovingInstanceFromPart_IImpl_setP_Integer);
						AddToElementRepository("v", RemovingInstanceFromPart_IImpl_setP_Integer_v);
					AddToElementRepository("IRealization", RemovingInstanceFromPart_IImpl_IRealization);
				AddToElementRepository("A", RemovingInstanceFromPart_A);
					AddToElementRepository("q", RemovingInstanceFromPart_A_q);
					AddToElementRepository("A_A", RemovingInstanceFromPart_A_A_A);
						AddToElementRepository("result", RemovingInstanceFromPart_A_A_A_result);
					AddToElementRepository("r", RemovingInstanceFromPart_A_r);
						AddToElementRepository("ConnectorEnd35", RemovingInstanceFromPart_A_r_ConnectorEnd35);
						AddToElementRepository("ConnectorEnd36", RemovingInstanceFromPart_A_r_ConnectorEnd36);
					AddToElementRepository("b", RemovingInstanceFromPart_A_b);
				AddToElementRepository("R", RemovingInstanceFromPart_R);
					AddToElementRepository("y", RemovingInstanceFromPart_R_y);
					AddToElementRepository("x", RemovingInstanceFromPart_R_x);

			// Initialize public members
			/*
			 * Model RemovingInstanceFromPart
			 */
			RemovingInstanceFromPart.SetName("RemovingInstanceFromPart");
			RemovingInstanceFromPart.SetVisibility(VisibilityKind.public_);
				// Class B
				RemovingInstanceFromPart_B.SetName("B");
				RemovingInstanceFromPart_B.SetVisibility(VisibilityKind.public_);
				
					// Property p
					RemovingInstanceFromPart_B_p.SetName("p");
					RemovingInstanceFromPart_B_p.SetVisibility(VisibilityKind.public_);
					
					RemovingInstanceFromPart_B_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
				RemovingInstanceFromPart_B.AddOwnedAttribute(RemovingInstanceFromPart_B_p);
				// Activity setPActivity
					RemovingInstanceFromPart_B_setPActivity.SetName("setPActivity");
					RemovingInstanceFromPart_B_setPActivity.SetVisibility(VisibilityKind.public_);
					
						// Parameter v
						RemovingInstanceFromPart_B_setPActivity_v.SetName("v");
						RemovingInstanceFromPart_B_setPActivity_v.SetVisibility(VisibilityKind.public_);
						
						RemovingInstanceFromPart_B_setPActivity_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					RemovingInstanceFromPart_B_setPActivity.AddOwnedParameter(RemovingInstanceFromPart_B_setPActivity_v);
						// ActivityParameterNode vParameterNode
						RemovingInstanceFromPart_B_setPActivity_vParameterNode.SetName("vParameterNode");
						RemovingInstanceFromPart_B_setPActivity_vParameterNode.SetVisibility(VisibilityKind.public_);
						
						RemovingInstanceFromPart_B_setPActivity_vParameterNode.SetParameter(RemovingInstanceFromPart_B_setPActivity_v);
					RemovingInstanceFromPart_B_setPActivity.AddNode(RemovingInstanceFromPart_B_setPActivity_vParameterNode);
						// ReadSelfAction this
						RemovingInstanceFromPart_B_setPActivity_this.SetName("this");
						RemovingInstanceFromPart_B_setPActivity_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							RemovingInstanceFromPart_B_setPActivity_this_result.SetName("result");
							RemovingInstanceFromPart_B_setPActivity_this_result.SetVisibility(VisibilityKind.public_);
							RemovingInstanceFromPart_B_setPActivity_this_result.SetType(RemovingInstanceFromPart_B);
						RemovingInstanceFromPart_B_setPActivity_this.SetResult(RemovingInstanceFromPart_B_setPActivity_this_result);
					RemovingInstanceFromPart_B_setPActivity.AddNode(RemovingInstanceFromPart_B_setPActivity_this);
						// AddStructuralFeatureValueAction Set this.p
						RemovingInstanceFromPart_B_setPActivity_Set_this_p.SetName("Set this.p");
						RemovingInstanceFromPart_B_setPActivity_Set_this_p.SetVisibility(VisibilityKind.public_);
						RemovingInstanceFromPart_B_setPActivity_Set_this_p.SetStructuralFeature(RemovingInstanceFromPart_B_p);
							// InputPin object
							RemovingInstanceFromPart_B_setPActivity_Set_this_p_object.SetName("object");
							RemovingInstanceFromPart_B_setPActivity_Set_this_p_object.SetVisibility(VisibilityKind.public_);
							RemovingInstanceFromPart_B_setPActivity_Set_this_p_object.SetType(RemovingInstanceFromPart_B);
						RemovingInstanceFromPart_B_setPActivity_Set_this_p.SetObject(RemovingInstanceFromPart_B_setPActivity_Set_this_p_object);
							// InputPin value
							RemovingInstanceFromPart_B_setPActivity_Set_this_p_value.SetName("value");
							RemovingInstanceFromPart_B_setPActivity_Set_this_p_value.SetVisibility(VisibilityKind.public_);
							RemovingInstanceFromPart_B_setPActivity_Set_this_p_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						RemovingInstanceFromPart_B_setPActivity_Set_this_p.SetValue(RemovingInstanceFromPart_B_setPActivity_Set_this_p_value);
							// OutputPin result
							RemovingInstanceFromPart_B_setPActivity_Set_this_p_result.SetName("result");
							RemovingInstanceFromPart_B_setPActivity_Set_this_p_result.SetVisibility(VisibilityKind.public_);
							RemovingInstanceFromPart_B_setPActivity_Set_this_p_result.SetType(RemovingInstanceFromPart_B);
						RemovingInstanceFromPart_B_setPActivity_Set_this_p.SetResult(RemovingInstanceFromPart_B_setPActivity_Set_this_p_result);
					RemovingInstanceFromPart_B_setPActivity.AddNode(RemovingInstanceFromPart_B_setPActivity_Set_this_p);
						// ObjectFlow ObjectFlow3 from vParameterNode to value
						RemovingInstanceFromPart_B_setPActivity_ObjectFlow3.SetName("ObjectFlow3");
						RemovingInstanceFromPart_B_setPActivity_ObjectFlow3.SetVisibility(VisibilityKind.public_);
						
						RemovingInstanceFromPart_B_setPActivity_ObjectFlow3.SetSource(RemovingInstanceFromPart_B_setPActivity_vParameterNode);
						RemovingInstanceFromPart_B_setPActivity_ObjectFlow3.SetTarget(RemovingInstanceFromPart_B_setPActivity_Set_this_p_value);
							// LiteralBoolean LiteralBoolean4
							RemovingInstanceFromPart_B_setPActivity_ObjectFlow3_LiteralBoolean4.SetName("LiteralBoolean4");
							RemovingInstanceFromPart_B_setPActivity_ObjectFlow3_LiteralBoolean4.SetVisibility(VisibilityKind.public_);
							RemovingInstanceFromPart_B_setPActivity_ObjectFlow3_LiteralBoolean4.SetValue(true);
						RemovingInstanceFromPart_B_setPActivity_ObjectFlow3.SetGuard(RemovingInstanceFromPart_B_setPActivity_ObjectFlow3_LiteralBoolean4);
					RemovingInstanceFromPart_B_setPActivity.AddEdge(RemovingInstanceFromPart_B_setPActivity_ObjectFlow3);
						// ObjectFlow ObjectFlow6 from result to object
						RemovingInstanceFromPart_B_setPActivity_ObjectFlow6.SetName("ObjectFlow6");
						RemovingInstanceFromPart_B_setPActivity_ObjectFlow6.SetVisibility(VisibilityKind.public_);
						
						RemovingInstanceFromPart_B_setPActivity_ObjectFlow6.SetSource(RemovingInstanceFromPart_B_setPActivity_this_result);
						RemovingInstanceFromPart_B_setPActivity_ObjectFlow6.SetTarget(RemovingInstanceFromPart_B_setPActivity_Set_this_p_object);
							// LiteralBoolean LiteralBoolean7
							RemovingInstanceFromPart_B_setPActivity_ObjectFlow6_LiteralBoolean7.SetName("LiteralBoolean7");
							RemovingInstanceFromPart_B_setPActivity_ObjectFlow6_LiteralBoolean7.SetVisibility(VisibilityKind.public_);
							RemovingInstanceFromPart_B_setPActivity_ObjectFlow6_LiteralBoolean7.SetValue(true);
						RemovingInstanceFromPart_B_setPActivity_ObjectFlow6.SetGuard(RemovingInstanceFromPart_B_setPActivity_ObjectFlow6_LiteralBoolean7);
					RemovingInstanceFromPart_B_setPActivity.AddEdge(RemovingInstanceFromPart_B_setPActivity_ObjectFlow6);
				RemovingInstanceFromPart_B.AddOwnedBehavior(RemovingInstanceFromPart_B_setPActivity);
					RemovingInstanceFromPart_B_IRealization.SetName("IRealization");
					RemovingInstanceFromPart_B_IRealization.SetVisibility(VisibilityKind.public_);
					RemovingInstanceFromPart_B_IRealization.SetContract(RemovingInstanceFromPart_I);
					
				RemovingInstanceFromPart_B.AddInterfaceRealization(RemovingInstanceFromPart_B_IRealization);
				
					// Operation B_B
					RemovingInstanceFromPart_B_B_B.SetName("B_B");
					RemovingInstanceFromPart_B_B_B.SetVisibility(VisibilityKind.public_);
						// Parameter result
						RemovingInstanceFromPart_B_B_B_result.SetName("result");
						RemovingInstanceFromPart_B_B_B_result.SetVisibility(VisibilityKind.public_);
						
						RemovingInstanceFromPart_B_B_B_result.SetType(RemovingInstanceFromPart_B);
						RemovingInstanceFromPart_B_B_B_result.SetDirection(ParameterDirectionKind.return_);
					RemovingInstanceFromPart_B_B_B.AddOwnedParameter(RemovingInstanceFromPart_B_B_B_result);
					RemovingInstanceFromPart_B_B_B.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				RemovingInstanceFromPart_B.AddOwnedOperation(RemovingInstanceFromPart_B_B_B);
					// Operation setP_Integer
					RemovingInstanceFromPart_B_setP_Integer.SetName("setP_Integer");
					RemovingInstanceFromPart_B_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						RemovingInstanceFromPart_B_setP_Integer_v.SetName("v");
						RemovingInstanceFromPart_B_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						RemovingInstanceFromPart_B_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					RemovingInstanceFromPart_B_setP_Integer.AddOwnedParameter(RemovingInstanceFromPart_B_setP_Integer_v);
					RemovingInstanceFromPart_B_setP_Integer.AddMethod(RemovingInstanceFromPart_B_setPActivity);
				RemovingInstanceFromPart_B.AddOwnedOperation(RemovingInstanceFromPart_B_setP_Integer);
			RemovingInstanceFromPart.AddPackagedElement(RemovingInstanceFromPart_B);
				// Activity assertA
				RemovingInstanceFromPart_assertA.SetName("assertA");
				RemovingInstanceFromPart_assertA.SetVisibility(VisibilityKind.public_);
				// FunctionBehavior assertionNotImplemented
					RemovingInstanceFromPart_assertA_assertionNotImplemented.SetName("assertionNotImplemented");
					RemovingInstanceFromPart_assertA_assertionNotImplemented.SetVisibility(VisibilityKind.public_);
					RemovingInstanceFromPart_assertA_assertionNotImplemented.AddLanguage("C#");
					RemovingInstanceFromPart_assertA_assertionNotImplemented.AddBody("Console.WriteLine(\"Assertion currenlty not implemented! Model was validated by manual debugging.\");");
				RemovingInstanceFromPart_assertA.AddOwnedBehavior(RemovingInstanceFromPart_assertA_assertionNotImplemented);
					// Parameter a
					RemovingInstanceFromPart_assertA_a.SetName("a");
					RemovingInstanceFromPart_assertA_a.SetVisibility(VisibilityKind.public_);
					
					RemovingInstanceFromPart_assertA_a.SetType(RemovingInstanceFromPart_A);
				RemovingInstanceFromPart_assertA.AddOwnedParameter(RemovingInstanceFromPart_assertA_a);
					// ActivityParameterNode aParameterNode
					RemovingInstanceFromPart_assertA_aParameterNode.SetName("aParameterNode");
					RemovingInstanceFromPart_assertA_aParameterNode.SetVisibility(VisibilityKind.public_);
				RemovingInstanceFromPart_assertA.AddNode(RemovingInstanceFromPart_assertA_aParameterNode);
					// CallBehaviorAction Call assertionNotImplemented
					RemovingInstanceFromPart_assertA_Call_assertionNotImplemented.SetName("Call assertionNotImplemented");
					RemovingInstanceFromPart_assertA_Call_assertionNotImplemented.SetVisibility(VisibilityKind.public_);
					RemovingInstanceFromPart_assertA_Call_assertionNotImplemented.SetBehavior(RemovingInstanceFromPart_assertA_assertionNotImplemented);
				RemovingInstanceFromPart_assertA.AddNode(RemovingInstanceFromPart_assertA_Call_assertionNotImplemented);
			RemovingInstanceFromPart.AddPackagedElement(RemovingInstanceFromPart_assertA);
				// Interface I
				RemovingInstanceFromPart_I.SetName("I");
				RemovingInstanceFromPart_I.SetVisibility(VisibilityKind.public_);
					// Operation setP_Integer
					RemovingInstanceFromPart_I_setP_Integer.SetName("setP_Integer");
					RemovingInstanceFromPart_I_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						RemovingInstanceFromPart_I_setP_Integer_v.SetName("v");
						RemovingInstanceFromPart_I_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						RemovingInstanceFromPart_I_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					RemovingInstanceFromPart_I_setP_Integer.AddOwnedParameter(RemovingInstanceFromPart_I_setP_Integer_v);
				RemovingInstanceFromPart_I.AddOwnedOperation(RemovingInstanceFromPart_I_setP_Integer);
			RemovingInstanceFromPart.AddPackagedElement(RemovingInstanceFromPart_I);
				// Activity main
				RemovingInstanceFromPart_main.SetName("main");
				RemovingInstanceFromPart_main.SetVisibility(VisibilityKind.public_);
					// ClearStructuralFeatureAction Clear a.b
					RemovingInstanceFromPart_main_Clear_a_b.SetName("Clear a.b");
					RemovingInstanceFromPart_main_Clear_a_b.SetVisibility(VisibilityKind.public_);
					RemovingInstanceFromPart_main_Clear_a_b.SetStructuralFeature(RemovingInstanceFromPart_A_b);
						// InputPin object
						RemovingInstanceFromPart_main_Clear_a_b_object.SetName("object");
						RemovingInstanceFromPart_main_Clear_a_b_object.SetVisibility(VisibilityKind.public_);
						RemovingInstanceFromPart_main_Clear_a_b_object.SetType(RemovingInstanceFromPart_A);
					RemovingInstanceFromPart_main_Clear_a_b.SetObject(RemovingInstanceFromPart_main_Clear_a_b_object);
						// OutputPin result
						RemovingInstanceFromPart_main_Clear_a_b_result.SetName("result");
						RemovingInstanceFromPart_main_Clear_a_b_result.SetVisibility(VisibilityKind.public_);
						RemovingInstanceFromPart_main_Clear_a_b_result.SetType(RemovingInstanceFromPart_A);
					RemovingInstanceFromPart_main_Clear_a_b.SetResult(RemovingInstanceFromPart_main_Clear_a_b_result);
				RemovingInstanceFromPart_main.AddNode(RemovingInstanceFromPart_main_Clear_a_b);
					// CreateObjectAction Create A
					RemovingInstanceFromPart_main_Create_A.SetName("Create A");
					RemovingInstanceFromPart_main_Create_A.SetVisibility(VisibilityKind.public_);
					RemovingInstanceFromPart_main_Create_A.SetClassifier(RemovingInstanceFromPart_A);
						// OutputPin result
						RemovingInstanceFromPart_main_Create_A_result.SetName("result");
						RemovingInstanceFromPart_main_Create_A_result.SetVisibility(VisibilityKind.public_);
						RemovingInstanceFromPart_main_Create_A_result.SetType(RemovingInstanceFromPart_A);
					RemovingInstanceFromPart_main_Create_A.SetResult(RemovingInstanceFromPart_main_Create_A_result);
				RemovingInstanceFromPart_main.AddNode(RemovingInstanceFromPart_main_Create_A);
					// CallBehaviorAction Call assertA
					RemovingInstanceFromPart_main_Call_assertA.SetName("Call assertA");
					RemovingInstanceFromPart_main_Call_assertA.SetVisibility(VisibilityKind.public_);
					RemovingInstanceFromPart_main_Call_assertA.SetBehavior(RemovingInstanceFromPart_assertA);
						// InputPin a
						RemovingInstanceFromPart_main_Call_assertA_a.SetName("a");
						RemovingInstanceFromPart_main_Call_assertA_a.SetVisibility(VisibilityKind.public_);
						RemovingInstanceFromPart_main_Call_assertA_a.SetType(RemovingInstanceFromPart_A);
					RemovingInstanceFromPart_main_Call_assertA.AddArgument(RemovingInstanceFromPart_main_Call_assertA_a);
				RemovingInstanceFromPart_main.AddNode(RemovingInstanceFromPart_main_Call_assertA);
					// CallOperationAction A()
					RemovingInstanceFromPart_main_A_.SetName("A()");
					RemovingInstanceFromPart_main_A_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						RemovingInstanceFromPart_main_A__result.SetName("result");
						RemovingInstanceFromPart_main_A__result.SetVisibility(VisibilityKind.public_);
						RemovingInstanceFromPart_main_A__result.SetType(RemovingInstanceFromPart_A);
					RemovingInstanceFromPart_main_A_.AddResult(RemovingInstanceFromPart_main_A__result);
					RemovingInstanceFromPart_main_A_.SetOperation(RemovingInstanceFromPart_A_A_A);
						// InputPin target
						RemovingInstanceFromPart_main_A__target.SetName("target");
						RemovingInstanceFromPart_main_A__target.SetVisibility(VisibilityKind.public_);
						RemovingInstanceFromPart_main_A__target.SetType(RemovingInstanceFromPart_A);
					RemovingInstanceFromPart_main_A_.SetTarget(RemovingInstanceFromPart_main_A__target);
				RemovingInstanceFromPart_main.AddNode(RemovingInstanceFromPart_main_A_);
					// ObjectFlow ObjectFlow16 from result to a
					RemovingInstanceFromPart_main_ObjectFlow16.SetName("ObjectFlow16");
					RemovingInstanceFromPart_main_ObjectFlow16.SetVisibility(VisibilityKind.public_);
					
					RemovingInstanceFromPart_main_ObjectFlow16.SetSource(RemovingInstanceFromPart_main_Clear_a_b_result);
					RemovingInstanceFromPart_main_ObjectFlow16.SetTarget(RemovingInstanceFromPart_main_Call_assertA_a);
						// LiteralBoolean LiteralBoolean17
						RemovingInstanceFromPart_main_ObjectFlow16_LiteralBoolean17.SetName("LiteralBoolean17");
						RemovingInstanceFromPart_main_ObjectFlow16_LiteralBoolean17.SetVisibility(VisibilityKind.public_);
						RemovingInstanceFromPart_main_ObjectFlow16_LiteralBoolean17.SetValue(true);
					RemovingInstanceFromPart_main_ObjectFlow16.SetGuard(RemovingInstanceFromPart_main_ObjectFlow16_LiteralBoolean17);
				RemovingInstanceFromPart_main.AddEdge(RemovingInstanceFromPart_main_ObjectFlow16);
					// ObjectFlow ObjectFlow21 from result to object
					RemovingInstanceFromPart_main_ObjectFlow21.SetName("ObjectFlow21");
					RemovingInstanceFromPart_main_ObjectFlow21.SetVisibility(VisibilityKind.public_);
					
					RemovingInstanceFromPart_main_ObjectFlow21.SetSource(RemovingInstanceFromPart_main_A__result);
					RemovingInstanceFromPart_main_ObjectFlow21.SetTarget(RemovingInstanceFromPart_main_Clear_a_b_object);
						// LiteralBoolean LiteralBoolean22
						RemovingInstanceFromPart_main_ObjectFlow21_LiteralBoolean22.SetName("LiteralBoolean22");
						RemovingInstanceFromPart_main_ObjectFlow21_LiteralBoolean22.SetVisibility(VisibilityKind.public_);
						RemovingInstanceFromPart_main_ObjectFlow21_LiteralBoolean22.SetValue(true);
					RemovingInstanceFromPart_main_ObjectFlow21.SetGuard(RemovingInstanceFromPart_main_ObjectFlow21_LiteralBoolean22);
				RemovingInstanceFromPart_main.AddEdge(RemovingInstanceFromPart_main_ObjectFlow21);
					// ObjectFlow ObjectFlow24 from result to target
					RemovingInstanceFromPart_main_ObjectFlow24.SetName("ObjectFlow24");
					RemovingInstanceFromPart_main_ObjectFlow24.SetVisibility(VisibilityKind.public_);
					
					RemovingInstanceFromPart_main_ObjectFlow24.SetSource(RemovingInstanceFromPart_main_Create_A_result);
					RemovingInstanceFromPart_main_ObjectFlow24.SetTarget(RemovingInstanceFromPart_main_A__target);
						// LiteralBoolean LiteralBoolean26
						RemovingInstanceFromPart_main_ObjectFlow24_LiteralBoolean26.SetName("LiteralBoolean26");
						RemovingInstanceFromPart_main_ObjectFlow24_LiteralBoolean26.SetVisibility(VisibilityKind.public_);
						RemovingInstanceFromPart_main_ObjectFlow24_LiteralBoolean26.SetValue(true);
					RemovingInstanceFromPart_main_ObjectFlow24.SetGuard(RemovingInstanceFromPart_main_ObjectFlow24_LiteralBoolean26);
				RemovingInstanceFromPart_main.AddEdge(RemovingInstanceFromPart_main_ObjectFlow24);
			RemovingInstanceFromPart.AddPackagedElement(RemovingInstanceFromPart_main);
				// Class IImpl
				RemovingInstanceFromPart_IImpl.SetName("IImpl");
				RemovingInstanceFromPart_IImpl.SetVisibility(VisibilityKind.public_);
				RemovingInstanceFromPart_IImpl_IRealization.SetName("IRealization");
					RemovingInstanceFromPart_IImpl_IRealization.SetVisibility(VisibilityKind.public_);
					RemovingInstanceFromPart_IImpl_IRealization.SetContract(RemovingInstanceFromPart_I);
					
				RemovingInstanceFromPart_IImpl.AddInterfaceRealization(RemovingInstanceFromPart_IImpl_IRealization);
				
					// Operation setP_Integer
					RemovingInstanceFromPart_IImpl_setP_Integer.SetName("setP_Integer");
					RemovingInstanceFromPart_IImpl_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						RemovingInstanceFromPart_IImpl_setP_Integer_v.SetName("v");
						RemovingInstanceFromPart_IImpl_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						RemovingInstanceFromPart_IImpl_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					RemovingInstanceFromPart_IImpl_setP_Integer.AddOwnedParameter(RemovingInstanceFromPart_IImpl_setP_Integer_v);
				RemovingInstanceFromPart_IImpl.AddOwnedOperation(RemovingInstanceFromPart_IImpl_setP_Integer);
			RemovingInstanceFromPart.AddPackagedElement(RemovingInstanceFromPart_IImpl);
				// Class A
				RemovingInstanceFromPart_A.SetName("A");
				RemovingInstanceFromPart_A.SetVisibility(VisibilityKind.public_);
				
					// Port q
					RemovingInstanceFromPart_A_q.SetName("q");
					RemovingInstanceFromPart_A_q.SetVisibility(VisibilityKind.public_);
					
					RemovingInstanceFromPart_A_q.SetType(RemovingInstanceFromPart_IImpl);
					RemovingInstanceFromPart_A_q.SetAggregation(AggregationKind.composite);
					RemovingInstanceFromPart_A_q.isService = true;
					RemovingInstanceFromPart_A_q.AddProvided(RemovingInstanceFromPart_I);
				RemovingInstanceFromPart_A.AddOwnedAttribute(RemovingInstanceFromPart_A_q);
					// Property b
					RemovingInstanceFromPart_A_b.SetName("b");
					RemovingInstanceFromPart_A_b.SetVisibility(VisibilityKind.public_);
					
					RemovingInstanceFromPart_A_b.SetType(RemovingInstanceFromPart_B);
					RemovingInstanceFromPart_A_b.SetAggregation(AggregationKind.composite);
				RemovingInstanceFromPart_A.AddOwnedAttribute(RemovingInstanceFromPart_A_b);
				
				RemovingInstanceFromPart_A_r.SetName("r");
					RemovingInstanceFromPart_A_r.SetVisibility(VisibilityKind.public_);
						
						RemovingInstanceFromPart_A_r_ConnectorEnd35.SetRole(RemovingInstanceFromPart_A_q);
						
					RemovingInstanceFromPart_A_r.AddEnd(RemovingInstanceFromPart_A_r_ConnectorEnd35);
						
						RemovingInstanceFromPart_A_r_ConnectorEnd36.SetRole(RemovingInstanceFromPart_A_b);
						
					RemovingInstanceFromPart_A_r.AddEnd(RemovingInstanceFromPart_A_r_ConnectorEnd36);
					RemovingInstanceFromPart_A_r.SetType(RemovingInstanceFromPart_R);
				RemovingInstanceFromPart_A.AddOwnedConnector(RemovingInstanceFromPart_A_r);
					// Operation A_A
					RemovingInstanceFromPart_A_A_A.SetName("A_A");
					RemovingInstanceFromPart_A_A_A.SetVisibility(VisibilityKind.public_);
						// Parameter result
						RemovingInstanceFromPart_A_A_A_result.SetName("result");
						RemovingInstanceFromPart_A_A_A_result.SetVisibility(VisibilityKind.public_);
						
						RemovingInstanceFromPart_A_A_A_result.SetType(RemovingInstanceFromPart_A);
						RemovingInstanceFromPart_A_A_A_result.SetDirection(ParameterDirectionKind.return_);
					RemovingInstanceFromPart_A_A_A.AddOwnedParameter(RemovingInstanceFromPart_A_A_A_result);
					RemovingInstanceFromPart_A_A_A.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				RemovingInstanceFromPart_A.AddOwnedOperation(RemovingInstanceFromPart_A_A_A);
			RemovingInstanceFromPart.AddPackagedElement(RemovingInstanceFromPart_A);
				// Association R
				RemovingInstanceFromPart_R.SetName("R");
				RemovingInstanceFromPart_R.SetVisibility(VisibilityKind.public_);
				RemovingInstanceFromPart_R.AddOwnedEnd(RemovingInstanceFromPart_R_x);
				RemovingInstanceFromPart_R.AddOwnedEnd(RemovingInstanceFromPart_R_y);
			RemovingInstanceFromPart.AddPackagedElement(RemovingInstanceFromPart_R);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // RemovingInstanceFromPartModel
}
