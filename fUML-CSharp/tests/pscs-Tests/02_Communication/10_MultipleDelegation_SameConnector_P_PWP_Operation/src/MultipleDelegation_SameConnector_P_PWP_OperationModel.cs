/*
 * MultipleDelegation_SameConnector_P_PWP_OperationModel.cs
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

namespace MultipleDelegation_SameConnector_P_PWP_Operation
{
	public class MultipleDelegation_SameConnector_P_PWP_OperationModel : InMemoryModel
	{
		private static MultipleDelegation_SameConnector_P_PWP_OperationModel? instance;

		/*
		 * Model MultipleDelegation_SameConnector_P_PWP_Operation
		 */
		public Package MultipleDelegation_SameConnector_P_PWP_Operation = new();
			public Class_ MultipleDelegation_SameConnector_P_PWP_Operation_B = new();
				public Property MultipleDelegation_SameConnector_P_PWP_Operation_B_p = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_B_p_LiteralInteger0 = new();
				public InterfaceRealization MultipleDelegation_SameConnector_P_PWP_Operation_B_IRealization = new();
				public Operation MultipleDelegation_SameConnector_P_PWP_Operation_B_setP_Integer = new();
					public Parameter MultipleDelegation_SameConnector_P_PWP_Operation_B_setP_Integer_v = new();
				public Activity MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity = new();
					public ActivityParameterNode MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_vParameterNode = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_vParameterNode_LiteralInteger1 = new();
					public ReadSelfAction MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_this = new();
						public OutputPin MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_this_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_this_result_LiteralUnlimitedNatural2 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_this_result_LiteralInteger3 = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_ObjectFlow4 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_ObjectFlow4_LiteralBoolean5 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_ObjectFlow4_LiteralInteger6 = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_ObjectFlow7 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_ObjectFlow7_LiteralBoolean8 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_ObjectFlow7_LiteralInteger9 = new();
					public Parameter MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_v = new();
					public AddStructuralFeatureValueAction MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p = new();
						public OutputPin MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p_result_LiteralUnlimitedNatural10 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p_result_LiteralInteger11 = new();
						public InputPin MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p_value = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p_value_LiteralUnlimitedNatural12 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p_value_LiteralInteger13 = new();
						public InputPin MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p_object = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p_object_LiteralUnlimitedNatural14 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p_object_LiteralInteger15 = new();
			public Class_ MultipleDelegation_SameConnector_P_PWP_Operation_IImpl = new();
				public InterfaceRealization MultipleDelegation_SameConnector_P_PWP_Operation_IImpl_IRealization = new();
				public Operation MultipleDelegation_SameConnector_P_PWP_Operation_IImpl_setP_Integer = new();
					public Parameter MultipleDelegation_SameConnector_P_PWP_Operation_IImpl_setP_Integer_v = new();
			public Interface MultipleDelegation_SameConnector_P_PWP_Operation_I = new();
				public Operation MultipleDelegation_SameConnector_P_PWP_Operation_I_setP_Integer = new();
					public Parameter MultipleDelegation_SameConnector_P_PWP_Operation_I_setP_Integer_v = new();
			public Class_ MultipleDelegation_SameConnector_P_PWP_Operation_A = new();
				public Property MultipleDelegation_SameConnector_P_PWP_Operation_A_b = new();
				public Port MultipleDelegation_SameConnector_P_PWP_Operation_A_q = new();
				public Connector MultipleDelegation_SameConnector_P_PWP_Operation_A_r = new();
					public ConnectorEnd MultipleDelegation_SameConnector_P_PWP_Operation_A_r_ConnectorEnd16 = new();
					public ConnectorEnd MultipleDelegation_SameConnector_P_PWP_Operation_A_r_ConnectorEnd17 = new();
			public Activity MultipleDelegation_SameConnector_P_PWP_Operation_main = new();
				public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow18 = new();
					public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow18_LiteralBoolean19 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow18_LiteralInteger20 = new();
				public CallOperationAction MultipleDelegation_SameConnector_P_PWP_Operation_main_C_ = new();
					public OutputPin MultipleDelegation_SameConnector_P_PWP_Operation_main_C__result = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Operation_main_C__result_LiteralUnlimitedNatural21 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_main_C__result_LiteralInteger22 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_main_C__result_LiteralInteger23 = new();
					public InputPin MultipleDelegation_SameConnector_P_PWP_Operation_main_C__target = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_main_C__target_LiteralInteger24 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Operation_main_C__target_LiteralUnlimitedNatural25 = new();
				public ReadStructuralFeatureAction MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_a_b = new();
					public InputPin MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_a_b_object = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_a_b_object_LiteralInteger26 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_a_b_object_LiteralUnlimitedNatural27 = new();
					public OutputPin MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_a_b_result = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_a_b_result_LiteralUnlimitedNatural28 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_a_b_result_LiteralInteger29 = new();
				public ReadStructuralFeatureAction MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_b_p = new();
					public OutputPin MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_b_p_result = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_b_p_result_LiteralUnlimitedNatural30 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_b_p_result_LiteralInteger31 = new();
					public InputPin MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_b_p_object = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_b_p_object_LiteralUnlimitedNatural32 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_b_p_object_LiteralInteger33 = new();
				public ControlFlow MultipleDelegation_SameConnector_P_PWP_Operation_main_ControlFlow34 = new();
				public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow35 = new();
					public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow35_LiteralBoolean36 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow35_LiteralInteger37 = new();
				public CreateObjectAction MultipleDelegation_SameConnector_P_PWP_Operation_main_Create_C = new();
					public OutputPin MultipleDelegation_SameConnector_P_PWP_Operation_main_Create_C_result = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Operation_main_Create_C_result_LiteralUnlimitedNatural38 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_main_Create_C_result_LiteralInteger39 = new();
				public OpaqueBehavior MultipleDelegation_SameConnector_P_PWP_Operation_main_testP = new();
					public Parameter MultipleDelegation_SameConnector_P_PWP_Operation_main_testP_p = new();
				public ForkNode MultipleDelegation_SameConnector_P_PWP_Operation_main_Fork_C = new();
				public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow40 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow40_LiteralInteger41 = new();
					public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow40_LiteralBoolean42 = new();
				public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow43 = new();
					public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow43_LiteralBoolean44 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow43_LiteralInteger45 = new();
				public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow46 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow46_LiteralInteger47 = new();
					public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow46_LiteralBoolean48 = new();
				public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow49 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow49_LiteralInteger50 = new();
					public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow49_LiteralBoolean51 = new();
				public CallOperationAction MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP_ = new();
					public InputPin MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP__v = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP__v_LiteralInteger52 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP__v_LiteralInteger53 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP__v_LiteralUnlimitedNatural54 = new();
					public InputPin MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP__target = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP__target_LiteralInteger55 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP__target_LiteralUnlimitedNatural56 = new();
				public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow57 = new();
					public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow57_LiteralBoolean58 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow57_LiteralInteger59 = new();
				public ReadStructuralFeatureAction MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_p = new();
					public OutputPin MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_p_result = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_p_result_LiteralUnlimitedNatural60 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_p_result_LiteralInteger61 = new();
					public InputPin MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_p_object = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_p_object_LiteralInteger62 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_p_object_LiteralUnlimitedNatural63 = new();
				public CallBehaviorAction MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_testP = new();
					public InputPin MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_testP_p = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_testP_p_LiteralUnlimitedNatural64 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_testP_p_LiteralInteger65 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_testP_p_LiteralInteger66 = new();
				public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow67 = new();
					public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow67_LiteralBoolean68 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow67_LiteralInteger69 = new();
				public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow70 = new();
					public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow70_LiteralBoolean71 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow70_LiteralInteger72 = new();
				public ValueSpecificationAction MultipleDelegation_SameConnector_P_PWP_Operation_main_Value_4 = new();
					public OutputPin MultipleDelegation_SameConnector_P_PWP_Operation_main_Value_4_result = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_main_Value_4_result_LiteralInteger73 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Operation_main_Value_4_result_LiteralUnlimitedNatural74 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_main_Value_4_LiteralInteger75 = new();
				public ReadStructuralFeatureAction MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a_ = new();
					public InputPin MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a__object = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a__object_LiteralInteger76 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a__object_LiteralUnlimitedNatural77 = new();
					public OutputPin MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a__result = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a__result_LiteralInteger78 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a__result_LiteralUnlimitedNatural79 = new();
			public Association MultipleDelegation_SameConnector_P_PWP_Operation_R = new();
				public Property MultipleDelegation_SameConnector_P_PWP_Operation_R_x = new();
				public Property MultipleDelegation_SameConnector_P_PWP_Operation_R_y = new();
			public Class_ MultipleDelegation_SameConnector_P_PWP_Operation_C = new();
				public Operation MultipleDelegation_SameConnector_P_PWP_Operation_C_C_C = new();
					public Parameter MultipleDelegation_SameConnector_P_PWP_Operation_C_C_C_result = new();
				public Property MultipleDelegation_SameConnector_P_PWP_Operation_C_a = new();
					public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Operation_C_a_LiteralUnlimitedNatural80 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_C_a_LiteralInteger81 = new();
				public Port MultipleDelegation_SameConnector_P_PWP_Operation_C_p = new();
				public Connector MultipleDelegation_SameConnector_P_PWP_Operation_C_u = new();
					public ConnectorEnd MultipleDelegation_SameConnector_P_PWP_Operation_C_u_ConnectorEnd82 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_C_u_ConnectorEnd82_LiteralInteger83 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Operation_C_u_ConnectorEnd82_LiteralUnlimitedNatural84 = new();
					public ConnectorEnd MultipleDelegation_SameConnector_P_PWP_Operation_C_u_ConnectorEnd85 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Operation_C_u_ConnectorEnd85_LiteralUnlimitedNatural86 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Operation_C_u_ConnectorEnd85_LiteralInteger87 = new();
			public Association MultipleDelegation_SameConnector_P_PWP_Operation_U = new();
				public Property MultipleDelegation_SameConnector_P_PWP_Operation_U_y = new();
				public Property MultipleDelegation_SameConnector_P_PWP_Operation_U_x = new();

		public static MultipleDelegation_SameConnector_P_PWP_OperationModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public MultipleDelegation_SameConnector_P_PWP_OperationModel()
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
			 * Model MultipleDelegation_SameConnector_P_PWP_Operation
			 */
			AddToElementRepository("MultipleDelegation_SameConnector_P_PWP_Operation", MultipleDelegation_SameConnector_P_PWP_Operation);
				AddToElementRepository("B", MultipleDelegation_SameConnector_P_PWP_Operation_B);
					AddToElementRepository("p", MultipleDelegation_SameConnector_P_PWP_Operation_B_p);
						AddToElementRepository("LiteralInteger0", MultipleDelegation_SameConnector_P_PWP_Operation_B_p_LiteralInteger0);
					AddToElementRepository("IRealization", MultipleDelegation_SameConnector_P_PWP_Operation_B_IRealization);
					AddToElementRepository("setP_Integer", MultipleDelegation_SameConnector_P_PWP_Operation_B_setP_Integer);
						AddToElementRepository("v", MultipleDelegation_SameConnector_P_PWP_Operation_B_setP_Integer_v);
					AddToElementRepository("setPActivity", MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity);
						AddToElementRepository("vParameterNode", MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_vParameterNode);
							AddToElementRepository("LiteralInteger1", MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_vParameterNode_LiteralInteger1);
						AddToElementRepository("this", MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_this);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_this_result);
								AddToElementRepository("LiteralUnlimitedNatural2", MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_this_result_LiteralUnlimitedNatural2);
								AddToElementRepository("LiteralInteger3", MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_this_result_LiteralInteger3);
						AddToElementRepository("ObjectFlow4", MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_ObjectFlow4);
							AddToElementRepository("LiteralBoolean5", MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_ObjectFlow4_LiteralBoolean5);
							AddToElementRepository("LiteralInteger6", MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_ObjectFlow4_LiteralInteger6);
						AddToElementRepository("ObjectFlow7", MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_ObjectFlow7);
							AddToElementRepository("LiteralBoolean8", MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_ObjectFlow7_LiteralBoolean8);
							AddToElementRepository("LiteralInteger9", MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_ObjectFlow7_LiteralInteger9);
						AddToElementRepository("v", MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_v);
						AddToElementRepository("Set this.p", MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p_result);
								AddToElementRepository("LiteralUnlimitedNatural10", MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p_result_LiteralUnlimitedNatural10);
								AddToElementRepository("LiteralInteger11", MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p_result_LiteralInteger11);
							AddToElementRepository("value", MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p_value);
								AddToElementRepository("LiteralUnlimitedNatural12", MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p_value_LiteralUnlimitedNatural12);
								AddToElementRepository("LiteralInteger13", MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p_value_LiteralInteger13);
							AddToElementRepository("object", MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p_object);
								AddToElementRepository("LiteralUnlimitedNatural14", MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p_object_LiteralUnlimitedNatural14);
								AddToElementRepository("LiteralInteger15", MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p_object_LiteralInteger15);
				AddToElementRepository("IImpl", MultipleDelegation_SameConnector_P_PWP_Operation_IImpl);
					AddToElementRepository("IRealization", MultipleDelegation_SameConnector_P_PWP_Operation_IImpl_IRealization);
					AddToElementRepository("setP_Integer", MultipleDelegation_SameConnector_P_PWP_Operation_IImpl_setP_Integer);
						AddToElementRepository("v", MultipleDelegation_SameConnector_P_PWP_Operation_IImpl_setP_Integer_v);
				AddToElementRepository("I", MultipleDelegation_SameConnector_P_PWP_Operation_I);
					AddToElementRepository("setP_Integer", MultipleDelegation_SameConnector_P_PWP_Operation_I_setP_Integer);
						AddToElementRepository("v", MultipleDelegation_SameConnector_P_PWP_Operation_I_setP_Integer_v);
				AddToElementRepository("A", MultipleDelegation_SameConnector_P_PWP_Operation_A);
					AddToElementRepository("b", MultipleDelegation_SameConnector_P_PWP_Operation_A_b);
					AddToElementRepository("q", MultipleDelegation_SameConnector_P_PWP_Operation_A_q);
					AddToElementRepository("r", MultipleDelegation_SameConnector_P_PWP_Operation_A_r);
						AddToElementRepository("ConnectorEnd16", MultipleDelegation_SameConnector_P_PWP_Operation_A_r_ConnectorEnd16);
						AddToElementRepository("ConnectorEnd17", MultipleDelegation_SameConnector_P_PWP_Operation_A_r_ConnectorEnd17);
				AddToElementRepository("main", MultipleDelegation_SameConnector_P_PWP_Operation_main);
					AddToElementRepository("ObjectFlow18", MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow18);
						AddToElementRepository("LiteralBoolean19", MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow18_LiteralBoolean19);
						AddToElementRepository("LiteralInteger20", MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow18_LiteralInteger20);
					AddToElementRepository("C()", MultipleDelegation_SameConnector_P_PWP_Operation_main_C_);
						AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Operation_main_C__result);
							AddToElementRepository("LiteralUnlimitedNatural21", MultipleDelegation_SameConnector_P_PWP_Operation_main_C__result_LiteralUnlimitedNatural21);
							AddToElementRepository("LiteralInteger22", MultipleDelegation_SameConnector_P_PWP_Operation_main_C__result_LiteralInteger22);
							AddToElementRepository("LiteralInteger23", MultipleDelegation_SameConnector_P_PWP_Operation_main_C__result_LiteralInteger23);
						AddToElementRepository("target", MultipleDelegation_SameConnector_P_PWP_Operation_main_C__target);
							AddToElementRepository("LiteralInteger24", MultipleDelegation_SameConnector_P_PWP_Operation_main_C__target_LiteralInteger24);
							AddToElementRepository("LiteralUnlimitedNatural25", MultipleDelegation_SameConnector_P_PWP_Operation_main_C__target_LiteralUnlimitedNatural25);
					AddToElementRepository("Read a.b", MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_a_b);
						AddToElementRepository("object", MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_a_b_object);
							AddToElementRepository("LiteralInteger26", MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_a_b_object_LiteralInteger26);
							AddToElementRepository("LiteralUnlimitedNatural27", MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_a_b_object_LiteralUnlimitedNatural27);
						AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_a_b_result);
							AddToElementRepository("LiteralUnlimitedNatural28", MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_a_b_result_LiteralUnlimitedNatural28);
							AddToElementRepository("LiteralInteger29", MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_a_b_result_LiteralInteger29);
					AddToElementRepository("Read b.p", MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_b_p);
						AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_b_p_result);
							AddToElementRepository("LiteralUnlimitedNatural30", MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_b_p_result_LiteralUnlimitedNatural30);
							AddToElementRepository("LiteralInteger31", MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_b_p_result_LiteralInteger31);
						AddToElementRepository("object", MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_b_p_object);
							AddToElementRepository("LiteralUnlimitedNatural32", MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_b_p_object_LiteralUnlimitedNatural32);
							AddToElementRepository("LiteralInteger33", MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_b_p_object_LiteralInteger33);
					AddToElementRepository("ControlFlow34", MultipleDelegation_SameConnector_P_PWP_Operation_main_ControlFlow34);
					AddToElementRepository("ObjectFlow35", MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow35);
						AddToElementRepository("LiteralBoolean36", MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow35_LiteralBoolean36);
						AddToElementRepository("LiteralInteger37", MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow35_LiteralInteger37);
					AddToElementRepository("Create C", MultipleDelegation_SameConnector_P_PWP_Operation_main_Create_C);
						AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Operation_main_Create_C_result);
							AddToElementRepository("LiteralUnlimitedNatural38", MultipleDelegation_SameConnector_P_PWP_Operation_main_Create_C_result_LiteralUnlimitedNatural38);
							AddToElementRepository("LiteralInteger39", MultipleDelegation_SameConnector_P_PWP_Operation_main_Create_C_result_LiteralInteger39);
					AddToElementRepository("testP", MultipleDelegation_SameConnector_P_PWP_Operation_main_testP);
						AddToElementRepository("p", MultipleDelegation_SameConnector_P_PWP_Operation_main_testP_p);
					AddToElementRepository("Fork C", MultipleDelegation_SameConnector_P_PWP_Operation_main_Fork_C);
					AddToElementRepository("ObjectFlow40", MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow40);
						AddToElementRepository("LiteralInteger41", MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow40_LiteralInteger41);
						AddToElementRepository("LiteralBoolean42", MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow40_LiteralBoolean42);
					AddToElementRepository("ObjectFlow43", MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow43);
						AddToElementRepository("LiteralBoolean44", MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow43_LiteralBoolean44);
						AddToElementRepository("LiteralInteger45", MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow43_LiteralInteger45);
					AddToElementRepository("ObjectFlow46", MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow46);
						AddToElementRepository("LiteralInteger47", MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow46_LiteralInteger47);
						AddToElementRepository("LiteralBoolean48", MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow46_LiteralBoolean48);
					AddToElementRepository("ObjectFlow49", MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow49);
						AddToElementRepository("LiteralInteger50", MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow49_LiteralInteger50);
						AddToElementRepository("LiteralBoolean51", MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow49_LiteralBoolean51);
					AddToElementRepository("Call p.setP()", MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP_);
						AddToElementRepository("v", MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP__v);
							AddToElementRepository("LiteralInteger52", MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP__v_LiteralInteger52);
							AddToElementRepository("LiteralInteger53", MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP__v_LiteralInteger53);
							AddToElementRepository("LiteralUnlimitedNatural54", MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP__v_LiteralUnlimitedNatural54);
						AddToElementRepository("target", MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP__target);
							AddToElementRepository("LiteralInteger55", MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP__target_LiteralInteger55);
							AddToElementRepository("LiteralUnlimitedNatural56", MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP__target_LiteralUnlimitedNatural56);
					AddToElementRepository("ObjectFlow57", MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow57);
						AddToElementRepository("LiteralBoolean58", MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow57_LiteralBoolean58);
						AddToElementRepository("LiteralInteger59", MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow57_LiteralInteger59);
					AddToElementRepository("Read c.p", MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_p);
						AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_p_result);
							AddToElementRepository("LiteralUnlimitedNatural60", MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_p_result_LiteralUnlimitedNatural60);
							AddToElementRepository("LiteralInteger61", MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_p_result_LiteralInteger61);
						AddToElementRepository("object", MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_p_object);
							AddToElementRepository("LiteralInteger62", MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_p_object_LiteralInteger62);
							AddToElementRepository("LiteralUnlimitedNatural63", MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_p_object_LiteralUnlimitedNatural63);
					AddToElementRepository("Call testP", MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_testP);
						AddToElementRepository("p", MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_testP_p);
							AddToElementRepository("LiteralUnlimitedNatural64", MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_testP_p_LiteralUnlimitedNatural64);
							AddToElementRepository("LiteralInteger65", MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_testP_p_LiteralInteger65);
							AddToElementRepository("LiteralInteger66", MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_testP_p_LiteralInteger66);
					AddToElementRepository("ObjectFlow67", MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow67);
						AddToElementRepository("LiteralBoolean68", MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow67_LiteralBoolean68);
						AddToElementRepository("LiteralInteger69", MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow67_LiteralInteger69);
					AddToElementRepository("ObjectFlow70", MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow70);
						AddToElementRepository("LiteralBoolean71", MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow70_LiteralBoolean71);
						AddToElementRepository("LiteralInteger72", MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow70_LiteralInteger72);
					AddToElementRepository("Value(4)", MultipleDelegation_SameConnector_P_PWP_Operation_main_Value_4);
						AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Operation_main_Value_4_result);
							AddToElementRepository("LiteralInteger73", MultipleDelegation_SameConnector_P_PWP_Operation_main_Value_4_result_LiteralInteger73);
							AddToElementRepository("LiteralUnlimitedNatural74", MultipleDelegation_SameConnector_P_PWP_Operation_main_Value_4_result_LiteralUnlimitedNatural74);
						AddToElementRepository("LiteralInteger75", MultipleDelegation_SameConnector_P_PWP_Operation_main_Value_4_LiteralInteger75);
					AddToElementRepository("Read c.a[]", MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a_);
						AddToElementRepository("object", MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a__object);
							AddToElementRepository("LiteralInteger76", MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a__object_LiteralInteger76);
							AddToElementRepository("LiteralUnlimitedNatural77", MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a__object_LiteralUnlimitedNatural77);
						AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a__result);
							AddToElementRepository("LiteralInteger78", MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a__result_LiteralInteger78);
							AddToElementRepository("LiteralUnlimitedNatural79", MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a__result_LiteralUnlimitedNatural79);
				AddToElementRepository("R", MultipleDelegation_SameConnector_P_PWP_Operation_R);
					AddToElementRepository("x", MultipleDelegation_SameConnector_P_PWP_Operation_R_x);
					AddToElementRepository("y", MultipleDelegation_SameConnector_P_PWP_Operation_R_y);
				AddToElementRepository("C", MultipleDelegation_SameConnector_P_PWP_Operation_C);
					AddToElementRepository("C_C", MultipleDelegation_SameConnector_P_PWP_Operation_C_C_C);
						AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Operation_C_C_C_result);
					AddToElementRepository("a", MultipleDelegation_SameConnector_P_PWP_Operation_C_a);
						AddToElementRepository("LiteralUnlimitedNatural80", MultipleDelegation_SameConnector_P_PWP_Operation_C_a_LiteralUnlimitedNatural80);
						AddToElementRepository("LiteralInteger81", MultipleDelegation_SameConnector_P_PWP_Operation_C_a_LiteralInteger81);
					AddToElementRepository("p", MultipleDelegation_SameConnector_P_PWP_Operation_C_p);
					AddToElementRepository("u", MultipleDelegation_SameConnector_P_PWP_Operation_C_u);
						AddToElementRepository("ConnectorEnd82", MultipleDelegation_SameConnector_P_PWP_Operation_C_u_ConnectorEnd82);
							AddToElementRepository("LiteralInteger83", MultipleDelegation_SameConnector_P_PWP_Operation_C_u_ConnectorEnd82_LiteralInteger83);
							AddToElementRepository("LiteralUnlimitedNatural84", MultipleDelegation_SameConnector_P_PWP_Operation_C_u_ConnectorEnd82_LiteralUnlimitedNatural84);
						AddToElementRepository("ConnectorEnd85", MultipleDelegation_SameConnector_P_PWP_Operation_C_u_ConnectorEnd85);
							AddToElementRepository("LiteralUnlimitedNatural86", MultipleDelegation_SameConnector_P_PWP_Operation_C_u_ConnectorEnd85_LiteralUnlimitedNatural86);
							AddToElementRepository("LiteralInteger87", MultipleDelegation_SameConnector_P_PWP_Operation_C_u_ConnectorEnd85_LiteralInteger87);
				AddToElementRepository("U", MultipleDelegation_SameConnector_P_PWP_Operation_U);
					AddToElementRepository("y", MultipleDelegation_SameConnector_P_PWP_Operation_U_y);
					AddToElementRepository("x", MultipleDelegation_SameConnector_P_PWP_Operation_U_x);

			// Initialize public members
			/*
			 * Model MultipleDelegation_SameConnector_P_PWP_Operation
			 */
			MultipleDelegation_SameConnector_P_PWP_Operation.SetName("MultipleDelegation_SameConnector_P_PWP_Operation");
			MultipleDelegation_SameConnector_P_PWP_Operation.SetVisibility(VisibilityKind.public_);
				// Class B
				MultipleDelegation_SameConnector_P_PWP_Operation_B.SetName("B");
				MultipleDelegation_SameConnector_P_PWP_Operation_B.SetVisibility(VisibilityKind.public_);
				
					// Property p
					MultipleDelegation_SameConnector_P_PWP_Operation_B_p.SetName("p");
					MultipleDelegation_SameConnector_P_PWP_Operation_B_p.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_PWP_Operation_B_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						// LiteralInteger LiteralInteger0
						MultipleDelegation_SameConnector_P_PWP_Operation_B_p_LiteralInteger0.SetName("LiteralInteger0");
						MultipleDelegation_SameConnector_P_PWP_Operation_B_p_LiteralInteger0.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Operation_B_p_LiteralInteger0.SetValue(0);
					MultipleDelegation_SameConnector_P_PWP_Operation_B_p.SetDefaultValue(MultipleDelegation_SameConnector_P_PWP_Operation_B_p_LiteralInteger0);
				MultipleDelegation_SameConnector_P_PWP_Operation_B.AddOwnedAttribute(MultipleDelegation_SameConnector_P_PWP_Operation_B_p);
				// Activity setPActivity
					MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity.SetName("setPActivity");
					MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity.SetVisibility(VisibilityKind.public_);
					
						// Parameter v
						MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_v.SetName("v");
						MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_v.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity.AddOwnedParameter(MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_v);
						// ActivityParameterNode vParameterNode
						MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_vParameterNode.SetName("vParameterNode");
						MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_vParameterNode.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_vParameterNode.SetParameter(MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_v);
					MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity.AddNode(MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_vParameterNode);
						// ReadSelfAction this
						MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_this.SetName("this");
						MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_this_result.SetName("result");
							MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_this_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_this_result.SetType(MultipleDelegation_SameConnector_P_PWP_Operation_B);
						MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_this.SetResult(MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_this_result);
					MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity.AddNode(MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_this);
						// AddStructuralFeatureValueAction Set this.p
						MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p.SetName("Set this.p");
						MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p.SetStructuralFeature(MultipleDelegation_SameConnector_P_PWP_Operation_B_p);
							// InputPin object
							MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p_object.SetName("object");
							MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p_object.SetType(MultipleDelegation_SameConnector_P_PWP_Operation_B);
						MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p.SetObject(MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p_object);
							// InputPin value
							MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p_value.SetName("value");
							MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p_value.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p.SetValue(MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p_value);
							// OutputPin result
							MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p_result.SetName("result");
							MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p_result.SetType(MultipleDelegation_SameConnector_P_PWP_Operation_B);
						MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p.SetResult(MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p_result);
					MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity.AddNode(MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p);
						// ObjectFlow ObjectFlow4 from vParameterNode to value
						MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_ObjectFlow4.SetName("ObjectFlow4");
						MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_ObjectFlow4.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_ObjectFlow4.SetSource(MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_vParameterNode);
						MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_ObjectFlow4.SetTarget(MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p_value);
							// LiteralBoolean LiteralBoolean5
							MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_ObjectFlow4_LiteralBoolean5.SetName("LiteralBoolean5");
							MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_ObjectFlow4_LiteralBoolean5.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_ObjectFlow4_LiteralBoolean5.SetValue(true);
						MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_ObjectFlow4.SetGuard(MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_ObjectFlow4_LiteralBoolean5);
					MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity.AddEdge(MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_ObjectFlow4);
						// ObjectFlow ObjectFlow7 from result to object
						MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_ObjectFlow7.SetName("ObjectFlow7");
						MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_ObjectFlow7.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_ObjectFlow7.SetSource(MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_this_result);
						MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_ObjectFlow7.SetTarget(MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_Set_this_p_object);
							// LiteralBoolean LiteralBoolean8
							MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_ObjectFlow7_LiteralBoolean8.SetName("LiteralBoolean8");
							MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_ObjectFlow7_LiteralBoolean8.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_ObjectFlow7_LiteralBoolean8.SetValue(true);
						MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_ObjectFlow7.SetGuard(MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_ObjectFlow7_LiteralBoolean8);
					MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity.AddEdge(MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity_ObjectFlow7);
				MultipleDelegation_SameConnector_P_PWP_Operation_B.AddOwnedBehavior(MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity);
					MultipleDelegation_SameConnector_P_PWP_Operation_B_IRealization.SetName("IRealization");
					MultipleDelegation_SameConnector_P_PWP_Operation_B_IRealization.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_PWP_Operation_B_IRealization.SetContract(MultipleDelegation_SameConnector_P_PWP_Operation_I);
					
				MultipleDelegation_SameConnector_P_PWP_Operation_B.AddInterfaceRealization(MultipleDelegation_SameConnector_P_PWP_Operation_B_IRealization);
				
					// Operation setP_Integer
					MultipleDelegation_SameConnector_P_PWP_Operation_B_setP_Integer.SetName("setP_Integer");
					MultipleDelegation_SameConnector_P_PWP_Operation_B_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						MultipleDelegation_SameConnector_P_PWP_Operation_B_setP_Integer_v.SetName("v");
						MultipleDelegation_SameConnector_P_PWP_Operation_B_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Operation_B_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_SameConnector_P_PWP_Operation_B_setP_Integer.AddOwnedParameter(MultipleDelegation_SameConnector_P_PWP_Operation_B_setP_Integer_v);
					MultipleDelegation_SameConnector_P_PWP_Operation_B_setP_Integer.AddMethod(MultipleDelegation_SameConnector_P_PWP_Operation_B_setPActivity);
				MultipleDelegation_SameConnector_P_PWP_Operation_B.AddOwnedOperation(MultipleDelegation_SameConnector_P_PWP_Operation_B_setP_Integer);
			MultipleDelegation_SameConnector_P_PWP_Operation.AddPackagedElement(MultipleDelegation_SameConnector_P_PWP_Operation_B);
				// Class IImpl
				MultipleDelegation_SameConnector_P_PWP_Operation_IImpl.SetName("IImpl");
				MultipleDelegation_SameConnector_P_PWP_Operation_IImpl.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_SameConnector_P_PWP_Operation_IImpl_IRealization.SetName("IRealization");
					MultipleDelegation_SameConnector_P_PWP_Operation_IImpl_IRealization.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_PWP_Operation_IImpl_IRealization.SetContract(MultipleDelegation_SameConnector_P_PWP_Operation_I);
					
				MultipleDelegation_SameConnector_P_PWP_Operation_IImpl.AddInterfaceRealization(MultipleDelegation_SameConnector_P_PWP_Operation_IImpl_IRealization);
				
					// Operation setP_Integer
					MultipleDelegation_SameConnector_P_PWP_Operation_IImpl_setP_Integer.SetName("setP_Integer");
					MultipleDelegation_SameConnector_P_PWP_Operation_IImpl_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						MultipleDelegation_SameConnector_P_PWP_Operation_IImpl_setP_Integer_v.SetName("v");
						MultipleDelegation_SameConnector_P_PWP_Operation_IImpl_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Operation_IImpl_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_SameConnector_P_PWP_Operation_IImpl_setP_Integer.AddOwnedParameter(MultipleDelegation_SameConnector_P_PWP_Operation_IImpl_setP_Integer_v);
				MultipleDelegation_SameConnector_P_PWP_Operation_IImpl.AddOwnedOperation(MultipleDelegation_SameConnector_P_PWP_Operation_IImpl_setP_Integer);
			MultipleDelegation_SameConnector_P_PWP_Operation.AddPackagedElement(MultipleDelegation_SameConnector_P_PWP_Operation_IImpl);
				// Interface I
				MultipleDelegation_SameConnector_P_PWP_Operation_I.SetName("I");
				MultipleDelegation_SameConnector_P_PWP_Operation_I.SetVisibility(VisibilityKind.public_);
					// Operation setP_Integer
					MultipleDelegation_SameConnector_P_PWP_Operation_I_setP_Integer.SetName("setP_Integer");
					MultipleDelegation_SameConnector_P_PWP_Operation_I_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						MultipleDelegation_SameConnector_P_PWP_Operation_I_setP_Integer_v.SetName("v");
						MultipleDelegation_SameConnector_P_PWP_Operation_I_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Operation_I_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_SameConnector_P_PWP_Operation_I_setP_Integer.AddOwnedParameter(MultipleDelegation_SameConnector_P_PWP_Operation_I_setP_Integer_v);
				MultipleDelegation_SameConnector_P_PWP_Operation_I.AddOwnedOperation(MultipleDelegation_SameConnector_P_PWP_Operation_I_setP_Integer);
			MultipleDelegation_SameConnector_P_PWP_Operation.AddPackagedElement(MultipleDelegation_SameConnector_P_PWP_Operation_I);
				// Class A
				MultipleDelegation_SameConnector_P_PWP_Operation_A.SetName("A");
				MultipleDelegation_SameConnector_P_PWP_Operation_A.SetVisibility(VisibilityKind.public_);
				
					// Port q
					MultipleDelegation_SameConnector_P_PWP_Operation_A_q.SetName("q");
					MultipleDelegation_SameConnector_P_PWP_Operation_A_q.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_PWP_Operation_A_q.SetType(MultipleDelegation_SameConnector_P_PWP_Operation_IImpl);
					MultipleDelegation_SameConnector_P_PWP_Operation_A_q.SetAggregation(AggregationKind.composite);
					MultipleDelegation_SameConnector_P_PWP_Operation_A_q.isService = true;
					MultipleDelegation_SameConnector_P_PWP_Operation_A_q.AddProvided(MultipleDelegation_SameConnector_P_PWP_Operation_I);
				MultipleDelegation_SameConnector_P_PWP_Operation_A.AddOwnedAttribute(MultipleDelegation_SameConnector_P_PWP_Operation_A_q);
					// Property b
					MultipleDelegation_SameConnector_P_PWP_Operation_A_b.SetName("b");
					MultipleDelegation_SameConnector_P_PWP_Operation_A_b.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_PWP_Operation_A_b.SetType(MultipleDelegation_SameConnector_P_PWP_Operation_B);
					MultipleDelegation_SameConnector_P_PWP_Operation_A_b.SetAggregation(AggregationKind.composite);
				MultipleDelegation_SameConnector_P_PWP_Operation_A.AddOwnedAttribute(MultipleDelegation_SameConnector_P_PWP_Operation_A_b);
				
				MultipleDelegation_SameConnector_P_PWP_Operation_A_r.SetName("r");
					MultipleDelegation_SameConnector_P_PWP_Operation_A_r.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Operation_A_r_ConnectorEnd16.SetRole(MultipleDelegation_SameConnector_P_PWP_Operation_A_q);
						
					MultipleDelegation_SameConnector_P_PWP_Operation_A_r.AddEnd(MultipleDelegation_SameConnector_P_PWP_Operation_A_r_ConnectorEnd16);
						
						MultipleDelegation_SameConnector_P_PWP_Operation_A_r_ConnectorEnd17.SetRole(MultipleDelegation_SameConnector_P_PWP_Operation_A_b);
						
					MultipleDelegation_SameConnector_P_PWP_Operation_A_r.AddEnd(MultipleDelegation_SameConnector_P_PWP_Operation_A_r_ConnectorEnd17);
					MultipleDelegation_SameConnector_P_PWP_Operation_A_r.SetType(MultipleDelegation_SameConnector_P_PWP_Operation_R);
				MultipleDelegation_SameConnector_P_PWP_Operation_A.AddOwnedConnector(MultipleDelegation_SameConnector_P_PWP_Operation_A_r);
			MultipleDelegation_SameConnector_P_PWP_Operation.AddPackagedElement(MultipleDelegation_SameConnector_P_PWP_Operation_A);
				// Activity main
				MultipleDelegation_SameConnector_P_PWP_Operation_main.SetName("main");
				MultipleDelegation_SameConnector_P_PWP_Operation_main.SetVisibility(VisibilityKind.public_);
				// FunctionBehavior testP
					MultipleDelegation_SameConnector_P_PWP_Operation_main_testP.SetName("testP");
					MultipleDelegation_SameConnector_P_PWP_Operation_main_testP.SetVisibility(VisibilityKind.public_);
					
						// Parameter p
						MultipleDelegation_SameConnector_P_PWP_Operation_main_testP_p.SetName("p");
						MultipleDelegation_SameConnector_P_PWP_Operation_main_testP_p.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Operation_main_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_testP.AddOwnedParameter(MultipleDelegation_SameConnector_P_PWP_Operation_main_testP_p);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_testP.AddLanguage("C#");
					MultipleDelegation_SameConnector_P_PWP_Operation_main_testP.AddLanguage("Using");
					MultipleDelegation_SameConnector_P_PWP_Operation_main_testP.AddBody("if(index == 1) 	{ 		Console.WriteLine(\"Asserting c.a[1].b.p == 4 || c.a[2].b.p == 4 || c.a[3].b.p == 4 || c.a[4].b.c == 4\"); 	}  	// For some reason, during the first execution of the expansion region, its body is actually executed twice. 	// Because of that, the body is actually executaed 5 times in total. This if-statement covers that up until solved. 	if (index <= MAX_INDEX) 	{ 		// Test parameter p                 int p = ((IntegerValue)inputParameters.ElementAt(0).values.ElementAt(0)).value; 		Debug.Println(\"[doBody] argument p = \" + p); 	 		Console.WriteLine( \"c.a[\" + index + \"].b.p == \" + p); 		success = success || (p == 4);  		if (index == MAX_INDEX) 		{  			Console.Write(\"Operation call delegated: \");  			if (success) 			{ 				Console.ForegroundColor = ConsoleColor.Green; 				Console.WriteLine(\"Assertion successful.\"); 			} 			else 			{ 				Console.ForegroundColor = ConsoleColor.Red; 				Console.WriteLine(\"Assertion failed!\"); 			}  			Console.ResetColor(); 		} 	}  	index++;");
					MultipleDelegation_SameConnector_P_PWP_Operation_main_testP.AddBody("using fuml.semantics.simpleclassifiers; ");
				MultipleDelegation_SameConnector_P_PWP_Operation_main.AddOwnedBehavior(MultipleDelegation_SameConnector_P_PWP_Operation_main_testP);
					// ForkNode Fork C
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Fork_C.SetName("Fork C");
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Fork_C.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_SameConnector_P_PWP_Operation_main.AddNode(MultipleDelegation_SameConnector_P_PWP_Operation_main_Fork_C);
					// CallOperationAction C()
					MultipleDelegation_SameConnector_P_PWP_Operation_main_C_.SetName("C()");
					MultipleDelegation_SameConnector_P_PWP_Operation_main_C_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						MultipleDelegation_SameConnector_P_PWP_Operation_main_C__result.SetName("result");
						MultipleDelegation_SameConnector_P_PWP_Operation_main_C__result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Operation_main_C__result.SetType(MultipleDelegation_SameConnector_P_PWP_Operation_C);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_C_.AddResult(MultipleDelegation_SameConnector_P_PWP_Operation_main_C__result);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_C_.SetOperation(MultipleDelegation_SameConnector_P_PWP_Operation_C_C_C);
						// InputPin target
						MultipleDelegation_SameConnector_P_PWP_Operation_main_C__target.SetName("target");
						MultipleDelegation_SameConnector_P_PWP_Operation_main_C__target.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Operation_main_C__target.SetType(MultipleDelegation_SameConnector_P_PWP_Operation_C);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_C_.SetTarget(MultipleDelegation_SameConnector_P_PWP_Operation_main_C__target);
				MultipleDelegation_SameConnector_P_PWP_Operation_main.AddNode(MultipleDelegation_SameConnector_P_PWP_Operation_main_C_);
					// CallOperationAction Call p.setP()
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP_.SetName("Call p.setP()");
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP_.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP_.SetOperation(MultipleDelegation_SameConnector_P_PWP_Operation_I_setP_Integer);
						// InputPin target
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP__target.SetName("target");
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP__target.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP__target.SetType(MultipleDelegation_SameConnector_P_PWP_Operation_I);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP_.SetTarget(MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP__target);
						// InputPin v
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP__v.SetName("v");
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP__v.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP__v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP_.AddArgument(MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP__v);
				MultipleDelegation_SameConnector_P_PWP_Operation_main.AddNode(MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP_);
					// ReadStructuralFeatureAction Read a.b
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_a_b.SetName("Read a.b");
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_a_b.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_a_b.SetStructuralFeature(MultipleDelegation_SameConnector_P_PWP_Operation_A_b);
						// InputPin object
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_a_b_object.SetName("object");
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_a_b_object.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_a_b_object.SetType(MultipleDelegation_SameConnector_P_PWP_Operation_A);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_a_b.SetObject(MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_a_b_object);
						// OutputPin result
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_a_b_result.SetName("result");
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_a_b_result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_a_b_result.SetType(MultipleDelegation_SameConnector_P_PWP_Operation_B);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_a_b.SetResult(MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_a_b_result);
				MultipleDelegation_SameConnector_P_PWP_Operation_main.AddNode(MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_a_b);
					// ReadStructuralFeatureAction Read c.p
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_p.SetName("Read c.p");
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_p.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_p.SetStructuralFeature(MultipleDelegation_SameConnector_P_PWP_Operation_C_p);
						// InputPin object
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_p_object.SetName("object");
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_p_object.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_p_object.SetType(MultipleDelegation_SameConnector_P_PWP_Operation_C);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_p.SetObject(MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_p_object);
						// OutputPin result
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_p_result.SetName("result");
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_p_result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_p_result.SetType(MultipleDelegation_SameConnector_P_PWP_Operation_IImpl);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_p.SetResult(MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_p_result);
				MultipleDelegation_SameConnector_P_PWP_Operation_main.AddNode(MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_p);
					// ReadStructuralFeatureAction Read b.p
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_b_p.SetName("Read b.p");
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_b_p.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_b_p.SetStructuralFeature(MultipleDelegation_SameConnector_P_PWP_Operation_B_p);
						// InputPin object
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_b_p_object.SetName("object");
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_b_p_object.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_b_p_object.SetType(MultipleDelegation_SameConnector_P_PWP_Operation_B);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_b_p.SetObject(MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_b_p_object);
						// OutputPin result
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_b_p_result.SetName("result");
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_b_p_result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_b_p_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_b_p.SetResult(MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_b_p_result);
				MultipleDelegation_SameConnector_P_PWP_Operation_main.AddNode(MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_b_p);
					// CallBehaviorAction Call testP
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_testP.SetName("Call testP");
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_testP.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_testP.SetBehavior(MultipleDelegation_SameConnector_P_PWP_Operation_main_testP);
						// InputPin p
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_testP_p.SetName("p");
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_testP_p.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_testP.AddArgument(MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_testP_p);
				MultipleDelegation_SameConnector_P_PWP_Operation_main.AddNode(MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_testP);
					// CreateObjectAction Create C
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Create_C.SetName("Create C");
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Create_C.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Create_C.SetClassifier(MultipleDelegation_SameConnector_P_PWP_Operation_C);
						// OutputPin result
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Create_C_result.SetName("result");
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Create_C_result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Create_C_result.SetType(MultipleDelegation_SameConnector_P_PWP_Operation_C);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Create_C.SetResult(MultipleDelegation_SameConnector_P_PWP_Operation_main_Create_C_result);
				MultipleDelegation_SameConnector_P_PWP_Operation_main.AddNode(MultipleDelegation_SameConnector_P_PWP_Operation_main_Create_C);
					// ValueSpecificationAction Value(4)
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Value_4.SetName("Value(4)");
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Value_4.SetVisibility(VisibilityKind.public_);
						// LiteralInteger LiteralInteger75
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Value_4_LiteralInteger75.SetName("LiteralInteger75");
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Value_4_LiteralInteger75.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Value_4_LiteralInteger75.SetValue(4);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Value_4.SetValue(MultipleDelegation_SameConnector_P_PWP_Operation_main_Value_4_LiteralInteger75);
						// OutputPin result
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Value_4_result.SetName("result");
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Value_4_result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Value_4_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Value_4.SetResult(MultipleDelegation_SameConnector_P_PWP_Operation_main_Value_4_result);
				MultipleDelegation_SameConnector_P_PWP_Operation_main.AddNode(MultipleDelegation_SameConnector_P_PWP_Operation_main_Value_4);
					// ReadStructuralFeatureAction Read c.a[]
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a_.SetName("Read c.a[]");
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a_.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a_.SetStructuralFeature(MultipleDelegation_SameConnector_P_PWP_Operation_C_a);
						// InputPin object
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a__object.SetName("object");
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a__object.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a__object.SetType(MultipleDelegation_SameConnector_P_PWP_Operation_C);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a_.SetObject(MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a__object);
						// OutputPin result
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a__result.SetName("result");
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a__result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a__result.SetType(MultipleDelegation_SameConnector_P_PWP_Operation_A);
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a__result.SetUpper(4);
						MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a__result.SetLower(4);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a_.SetResult(MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a__result);
				MultipleDelegation_SameConnector_P_PWP_Operation_main.AddNode(MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a_);
					// ObjectFlow ObjectFlow18 from Fork C to object
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow18.SetName("ObjectFlow18");
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow18.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow18.SetSource(MultipleDelegation_SameConnector_P_PWP_Operation_main_Fork_C);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow18.SetTarget(MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a__object);
						// LiteralBoolean LiteralBoolean19
						MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow18_LiteralBoolean19.SetName("LiteralBoolean19");
						MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow18_LiteralBoolean19.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow18_LiteralBoolean19.SetValue(true);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow18.SetGuard(MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow18_LiteralBoolean19);
				MultipleDelegation_SameConnector_P_PWP_Operation_main.AddEdge(MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow18);
					// ObjectFlow ObjectFlow40 from result to object
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow40.SetName("ObjectFlow40");
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow40.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow40.SetSource(MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_a_b_result);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow40.SetTarget(MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_b_p_object);
						// LiteralBoolean LiteralBoolean42
						MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow40_LiteralBoolean42.SetName("LiteralBoolean42");
						MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow40_LiteralBoolean42.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow40_LiteralBoolean42.SetValue(true);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow40.SetGuard(MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow40_LiteralBoolean42);
				MultipleDelegation_SameConnector_P_PWP_Operation_main.AddEdge(MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow40);
					// ObjectFlow ObjectFlow43 from result to object
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow43.SetName("ObjectFlow43");
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow43.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow43.SetSource(MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a__result);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow43.SetTarget(MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_a_b_object);
						// LiteralBoolean LiteralBoolean44
						MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow43_LiteralBoolean44.SetName("LiteralBoolean44");
						MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow43_LiteralBoolean44.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow43_LiteralBoolean44.SetValue(true);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow43.SetGuard(MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow43_LiteralBoolean44);
				MultipleDelegation_SameConnector_P_PWP_Operation_main.AddEdge(MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow43);
					// ObjectFlow ObjectFlow46 from result to target
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow46.SetName("ObjectFlow46");
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow46.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow46.SetSource(MultipleDelegation_SameConnector_P_PWP_Operation_main_Create_C_result);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow46.SetTarget(MultipleDelegation_SameConnector_P_PWP_Operation_main_C__target);
						// LiteralBoolean LiteralBoolean48
						MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow46_LiteralBoolean48.SetName("LiteralBoolean48");
						MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow46_LiteralBoolean48.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow46_LiteralBoolean48.SetValue(true);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow46.SetGuard(MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow46_LiteralBoolean48);
				MultipleDelegation_SameConnector_P_PWP_Operation_main.AddEdge(MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow46);
					// ObjectFlow ObjectFlow49 from Fork C to object
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow49.SetName("ObjectFlow49");
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow49.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow49.SetSource(MultipleDelegation_SameConnector_P_PWP_Operation_main_Fork_C);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow49.SetTarget(MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_p_object);
						// LiteralBoolean LiteralBoolean51
						MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow49_LiteralBoolean51.SetName("LiteralBoolean51");
						MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow49_LiteralBoolean51.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow49_LiteralBoolean51.SetValue(true);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow49.SetGuard(MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow49_LiteralBoolean51);
				MultipleDelegation_SameConnector_P_PWP_Operation_main.AddEdge(MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow49);
					// ObjectFlow ObjectFlow57 from result to target
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow57.SetName("ObjectFlow57");
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow57.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow57.SetSource(MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_p_result);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow57.SetTarget(MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP__target);
						// LiteralBoolean LiteralBoolean58
						MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow57_LiteralBoolean58.SetName("LiteralBoolean58");
						MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow57_LiteralBoolean58.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow57_LiteralBoolean58.SetValue(true);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow57.SetGuard(MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow57_LiteralBoolean58);
				MultipleDelegation_SameConnector_P_PWP_Operation_main.AddEdge(MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow57);
					// ControlFlow ControlFlow34 from Call p.setP() to Read c.a[]
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ControlFlow34.SetName("ControlFlow34");
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ControlFlow34.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ControlFlow34.SetSource(MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP_);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ControlFlow34.SetTarget(MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_c_a_);
				MultipleDelegation_SameConnector_P_PWP_Operation_main.AddEdge(MultipleDelegation_SameConnector_P_PWP_Operation_main_ControlFlow34);
					// ObjectFlow ObjectFlow67 from result to Fork C
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow67.SetName("ObjectFlow67");
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow67.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow67.SetSource(MultipleDelegation_SameConnector_P_PWP_Operation_main_C__result);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow67.SetTarget(MultipleDelegation_SameConnector_P_PWP_Operation_main_Fork_C);
						// LiteralBoolean LiteralBoolean68
						MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow67_LiteralBoolean68.SetName("LiteralBoolean68");
						MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow67_LiteralBoolean68.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow67_LiteralBoolean68.SetValue(true);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow67.SetGuard(MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow67_LiteralBoolean68);
				MultipleDelegation_SameConnector_P_PWP_Operation_main.AddEdge(MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow67);
					// ObjectFlow ObjectFlow35 from result to v
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow35.SetName("ObjectFlow35");
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow35.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow35.SetSource(MultipleDelegation_SameConnector_P_PWP_Operation_main_Value_4_result);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow35.SetTarget(MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_p_setP__v);
						// LiteralBoolean LiteralBoolean36
						MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow35_LiteralBoolean36.SetName("LiteralBoolean36");
						MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow35_LiteralBoolean36.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow35_LiteralBoolean36.SetValue(true);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow35.SetGuard(MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow35_LiteralBoolean36);
				MultipleDelegation_SameConnector_P_PWP_Operation_main.AddEdge(MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow35);
					// ObjectFlow ObjectFlow70 from result to p
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow70.SetName("ObjectFlow70");
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow70.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow70.SetSource(MultipleDelegation_SameConnector_P_PWP_Operation_main_Read_b_p_result);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow70.SetTarget(MultipleDelegation_SameConnector_P_PWP_Operation_main_Call_testP_p);
						// LiteralBoolean LiteralBoolean71
						MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow70_LiteralBoolean71.SetName("LiteralBoolean71");
						MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow70_LiteralBoolean71.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow70_LiteralBoolean71.SetValue(true);
					MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow70.SetGuard(MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow70_LiteralBoolean71);
				MultipleDelegation_SameConnector_P_PWP_Operation_main.AddEdge(MultipleDelegation_SameConnector_P_PWP_Operation_main_ObjectFlow70);
			MultipleDelegation_SameConnector_P_PWP_Operation.AddPackagedElement(MultipleDelegation_SameConnector_P_PWP_Operation_main);
				// Association R
				MultipleDelegation_SameConnector_P_PWP_Operation_R.SetName("R");
				MultipleDelegation_SameConnector_P_PWP_Operation_R.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_SameConnector_P_PWP_Operation_R.AddOwnedEnd(MultipleDelegation_SameConnector_P_PWP_Operation_R_x);
				MultipleDelegation_SameConnector_P_PWP_Operation_R.AddOwnedEnd(MultipleDelegation_SameConnector_P_PWP_Operation_R_y);
			MultipleDelegation_SameConnector_P_PWP_Operation.AddPackagedElement(MultipleDelegation_SameConnector_P_PWP_Operation_R);
				// Class C
				MultipleDelegation_SameConnector_P_PWP_Operation_C.SetName("C");
				MultipleDelegation_SameConnector_P_PWP_Operation_C.SetVisibility(VisibilityKind.public_);
				
					// Port p
					MultipleDelegation_SameConnector_P_PWP_Operation_C_p.SetName("p");
					MultipleDelegation_SameConnector_P_PWP_Operation_C_p.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_PWP_Operation_C_p.SetType(MultipleDelegation_SameConnector_P_PWP_Operation_IImpl);
					MultipleDelegation_SameConnector_P_PWP_Operation_C_p.SetAggregation(AggregationKind.composite);
					MultipleDelegation_SameConnector_P_PWP_Operation_C_p.isService = true;
					MultipleDelegation_SameConnector_P_PWP_Operation_C_p.AddProvided(MultipleDelegation_SameConnector_P_PWP_Operation_I);
				MultipleDelegation_SameConnector_P_PWP_Operation_C.AddOwnedAttribute(MultipleDelegation_SameConnector_P_PWP_Operation_C_p);
					// Property a
					MultipleDelegation_SameConnector_P_PWP_Operation_C_a.SetName("a");
					MultipleDelegation_SameConnector_P_PWP_Operation_C_a.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_PWP_Operation_C_a.SetUpper(4);
					MultipleDelegation_SameConnector_P_PWP_Operation_C_a.SetLower(4);
					MultipleDelegation_SameConnector_P_PWP_Operation_C_a.SetType(MultipleDelegation_SameConnector_P_PWP_Operation_A);
					MultipleDelegation_SameConnector_P_PWP_Operation_C_a.SetAggregation(AggregationKind.composite);
				MultipleDelegation_SameConnector_P_PWP_Operation_C.AddOwnedAttribute(MultipleDelegation_SameConnector_P_PWP_Operation_C_a);
				
				MultipleDelegation_SameConnector_P_PWP_Operation_C_u.SetName("u");
					MultipleDelegation_SameConnector_P_PWP_Operation_C_u.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Operation_C_u_ConnectorEnd82.SetUpper(-1);
						MultipleDelegation_SameConnector_P_PWP_Operation_C_u_ConnectorEnd82.SetRole(MultipleDelegation_SameConnector_P_PWP_Operation_C_p);
						
					MultipleDelegation_SameConnector_P_PWP_Operation_C_u.AddEnd(MultipleDelegation_SameConnector_P_PWP_Operation_C_u_ConnectorEnd82);
						MultipleDelegation_SameConnector_P_PWP_Operation_C_u_ConnectorEnd85.SetUpper(-1);
						MultipleDelegation_SameConnector_P_PWP_Operation_C_u_ConnectorEnd85.SetLower(4);
						MultipleDelegation_SameConnector_P_PWP_Operation_C_u_ConnectorEnd85.SetRole(MultipleDelegation_SameConnector_P_PWP_Operation_A_q);
						MultipleDelegation_SameConnector_P_PWP_Operation_C_u_ConnectorEnd85.SetPartWithPort(MultipleDelegation_SameConnector_P_PWP_Operation_C_a);
						
					MultipleDelegation_SameConnector_P_PWP_Operation_C_u.AddEnd(MultipleDelegation_SameConnector_P_PWP_Operation_C_u_ConnectorEnd85);
					MultipleDelegation_SameConnector_P_PWP_Operation_C_u.SetType(MultipleDelegation_SameConnector_P_PWP_Operation_U);
				MultipleDelegation_SameConnector_P_PWP_Operation_C.AddOwnedConnector(MultipleDelegation_SameConnector_P_PWP_Operation_C_u);
					// Operation C_C
					MultipleDelegation_SameConnector_P_PWP_Operation_C_C_C.SetName("C_C");
					MultipleDelegation_SameConnector_P_PWP_Operation_C_C_C.SetVisibility(VisibilityKind.public_);
						// Parameter result
						MultipleDelegation_SameConnector_P_PWP_Operation_C_C_C_result.SetName("result");
						MultipleDelegation_SameConnector_P_PWP_Operation_C_C_C_result.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Operation_C_C_C_result.SetType(MultipleDelegation_SameConnector_P_PWP_Operation_C);
						MultipleDelegation_SameConnector_P_PWP_Operation_C_C_C_result.SetDirection(ParameterDirectionKind.return_);
					MultipleDelegation_SameConnector_P_PWP_Operation_C_C_C.AddOwnedParameter(MultipleDelegation_SameConnector_P_PWP_Operation_C_C_C_result);
					MultipleDelegation_SameConnector_P_PWP_Operation_C_C_C.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				MultipleDelegation_SameConnector_P_PWP_Operation_C.AddOwnedOperation(MultipleDelegation_SameConnector_P_PWP_Operation_C_C_C);
			MultipleDelegation_SameConnector_P_PWP_Operation.AddPackagedElement(MultipleDelegation_SameConnector_P_PWP_Operation_C);
				// Association U
				MultipleDelegation_SameConnector_P_PWP_Operation_U.SetName("U");
				MultipleDelegation_SameConnector_P_PWP_Operation_U.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_SameConnector_P_PWP_Operation_U.AddOwnedEnd(MultipleDelegation_SameConnector_P_PWP_Operation_U_x);
				MultipleDelegation_SameConnector_P_PWP_Operation_U.AddOwnedEnd(MultipleDelegation_SameConnector_P_PWP_Operation_U_y);
			MultipleDelegation_SameConnector_P_PWP_Operation.AddPackagedElement(MultipleDelegation_SameConnector_P_PWP_Operation_U);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // MultipleDelegation_SameConnector_P_PWP_OperationModel
}
