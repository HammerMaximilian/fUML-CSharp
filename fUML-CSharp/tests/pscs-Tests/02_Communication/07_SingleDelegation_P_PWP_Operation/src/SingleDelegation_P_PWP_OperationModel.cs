/*
 * SingleDelegation_P_PWP_OperationModel.cs
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

namespace SingleDelegation_P_PWP_Operation
{
	public class SingleDelegation_P_PWP_OperationModel : InMemoryModel
	{
		private static SingleDelegation_P_PWP_OperationModel? instance;

		/*
		 * Model SingleDelegation_P_PWP_Operation
		 */
		public Package SingleDelegation_P_PWP_Operation = new();
			public Association SingleDelegation_P_PWP_Operation_R = new();
				public Property SingleDelegation_P_PWP_Operation_R_y = new();
				public Property SingleDelegation_P_PWP_Operation_R_x = new();
			public Activity SingleDelegation_P_PWP_Operation_main = new();
				public ReadStructuralFeatureAction SingleDelegation_P_PWP_Operation_main_Read_c_a = new();
					public OutputPin SingleDelegation_P_PWP_Operation_main_Read_c_a_result = new();
						public LiteralUnlimitedNatural SingleDelegation_P_PWP_Operation_main_Read_c_a_result_LiteralUnlimitedNatural0 = new();
						public LiteralInteger SingleDelegation_P_PWP_Operation_main_Read_c_a_result_LiteralInteger1 = new();
					public InputPin SingleDelegation_P_PWP_Operation_main_Read_c_a_object = new();
						public LiteralUnlimitedNatural SingleDelegation_P_PWP_Operation_main_Read_c_a_object_LiteralUnlimitedNatural2 = new();
						public LiteralInteger SingleDelegation_P_PWP_Operation_main_Read_c_a_object_LiteralInteger3 = new();
				public ObjectFlow SingleDelegation_P_PWP_Operation_main_ObjectFlow4 = new();
					public LiteralBoolean SingleDelegation_P_PWP_Operation_main_ObjectFlow4_LiteralBoolean5 = new();
					public LiteralInteger SingleDelegation_P_PWP_Operation_main_ObjectFlow4_LiteralInteger6 = new();
				public ReadStructuralFeatureAction SingleDelegation_P_PWP_Operation_main_Read_b_p = new();
					public InputPin SingleDelegation_P_PWP_Operation_main_Read_b_p_object = new();
						public LiteralInteger SingleDelegation_P_PWP_Operation_main_Read_b_p_object_LiteralInteger7 = new();
						public LiteralUnlimitedNatural SingleDelegation_P_PWP_Operation_main_Read_b_p_object_LiteralUnlimitedNatural8 = new();
					public OutputPin SingleDelegation_P_PWP_Operation_main_Read_b_p_result = new();
						public LiteralUnlimitedNatural SingleDelegation_P_PWP_Operation_main_Read_b_p_result_LiteralUnlimitedNatural9 = new();
						public LiteralInteger SingleDelegation_P_PWP_Operation_main_Read_b_p_result_LiteralInteger10 = new();
				public CallBehaviorAction SingleDelegation_P_PWP_Operation_main_Call_testP = new();
					public InputPin SingleDelegation_P_PWP_Operation_main_Call_testP_p = new();
						public LiteralInteger SingleDelegation_P_PWP_Operation_main_Call_testP_p_LiteralInteger11 = new();
						public LiteralUnlimitedNatural SingleDelegation_P_PWP_Operation_main_Call_testP_p_LiteralUnlimitedNatural12 = new();
						public LiteralInteger SingleDelegation_P_PWP_Operation_main_Call_testP_p_LiteralInteger13 = new();
				public ObjectFlow SingleDelegation_P_PWP_Operation_main_ObjectFlow14 = new();
					public LiteralBoolean SingleDelegation_P_PWP_Operation_main_ObjectFlow14_LiteralBoolean15 = new();
					public LiteralInteger SingleDelegation_P_PWP_Operation_main_ObjectFlow14_LiteralInteger16 = new();
				public ControlFlow SingleDelegation_P_PWP_Operation_main_ControlFlow17 = new();
				public CreateObjectAction SingleDelegation_P_PWP_Operation_main_Create_C = new();
					public OutputPin SingleDelegation_P_PWP_Operation_main_Create_C_result = new();
						public LiteralInteger SingleDelegation_P_PWP_Operation_main_Create_C_result_LiteralInteger18 = new();
						public LiteralUnlimitedNatural SingleDelegation_P_PWP_Operation_main_Create_C_result_LiteralUnlimitedNatural19 = new();
				public ReadStructuralFeatureAction SingleDelegation_P_PWP_Operation_main_Read_c_p = new();
					public OutputPin SingleDelegation_P_PWP_Operation_main_Read_c_p_result = new();
						public LiteralInteger SingleDelegation_P_PWP_Operation_main_Read_c_p_result_LiteralInteger20 = new();
						public LiteralUnlimitedNatural SingleDelegation_P_PWP_Operation_main_Read_c_p_result_LiteralUnlimitedNatural21 = new();
					public InputPin SingleDelegation_P_PWP_Operation_main_Read_c_p_object = new();
						public LiteralInteger SingleDelegation_P_PWP_Operation_main_Read_c_p_object_LiteralInteger22 = new();
						public LiteralUnlimitedNatural SingleDelegation_P_PWP_Operation_main_Read_c_p_object_LiteralUnlimitedNatural23 = new();
				public OpaqueBehavior SingleDelegation_P_PWP_Operation_main_testP = new();
					public Parameter SingleDelegation_P_PWP_Operation_main_testP_p = new();
				public ObjectFlow SingleDelegation_P_PWP_Operation_main_ObjectFlow24 = new();
					public LiteralBoolean SingleDelegation_P_PWP_Operation_main_ObjectFlow24_LiteralBoolean25 = new();
					public LiteralInteger SingleDelegation_P_PWP_Operation_main_ObjectFlow24_LiteralInteger26 = new();
				public ObjectFlow SingleDelegation_P_PWP_Operation_main_ObjectFlow27 = new();
					public LiteralBoolean SingleDelegation_P_PWP_Operation_main_ObjectFlow27_LiteralBoolean28 = new();
					public LiteralInteger SingleDelegation_P_PWP_Operation_main_ObjectFlow27_LiteralInteger29 = new();
				public CallOperationAction SingleDelegation_P_PWP_Operation_main_C_ = new();
					public OutputPin SingleDelegation_P_PWP_Operation_main_C__result = new();
						public LiteralInteger SingleDelegation_P_PWP_Operation_main_C__result_LiteralInteger30 = new();
						public LiteralInteger SingleDelegation_P_PWP_Operation_main_C__result_LiteralInteger31 = new();
						public LiteralUnlimitedNatural SingleDelegation_P_PWP_Operation_main_C__result_LiteralUnlimitedNatural32 = new();
					public InputPin SingleDelegation_P_PWP_Operation_main_C__target = new();
						public LiteralInteger SingleDelegation_P_PWP_Operation_main_C__target_LiteralInteger33 = new();
						public LiteralUnlimitedNatural SingleDelegation_P_PWP_Operation_main_C__target_LiteralUnlimitedNatural34 = new();
				public ReadStructuralFeatureAction SingleDelegation_P_PWP_Operation_main_Read_a_b = new();
					public InputPin SingleDelegation_P_PWP_Operation_main_Read_a_b_object = new();
						public LiteralUnlimitedNatural SingleDelegation_P_PWP_Operation_main_Read_a_b_object_LiteralUnlimitedNatural35 = new();
						public LiteralInteger SingleDelegation_P_PWP_Operation_main_Read_a_b_object_LiteralInteger36 = new();
					public OutputPin SingleDelegation_P_PWP_Operation_main_Read_a_b_result = new();
						public LiteralUnlimitedNatural SingleDelegation_P_PWP_Operation_main_Read_a_b_result_LiteralUnlimitedNatural37 = new();
						public LiteralInteger SingleDelegation_P_PWP_Operation_main_Read_a_b_result_LiteralInteger38 = new();
				public ObjectFlow SingleDelegation_P_PWP_Operation_main_ObjectFlow39 = new();
					public LiteralInteger SingleDelegation_P_PWP_Operation_main_ObjectFlow39_LiteralInteger40 = new();
					public LiteralBoolean SingleDelegation_P_PWP_Operation_main_ObjectFlow39_LiteralBoolean41 = new();
				public ObjectFlow SingleDelegation_P_PWP_Operation_main_ObjectFlow42 = new();
					public LiteralInteger SingleDelegation_P_PWP_Operation_main_ObjectFlow42_LiteralInteger43 = new();
					public LiteralBoolean SingleDelegation_P_PWP_Operation_main_ObjectFlow42_LiteralBoolean44 = new();
				public ObjectFlow SingleDelegation_P_PWP_Operation_main_ObjectFlow45 = new();
					public LiteralInteger SingleDelegation_P_PWP_Operation_main_ObjectFlow45_LiteralInteger46 = new();
					public LiteralBoolean SingleDelegation_P_PWP_Operation_main_ObjectFlow45_LiteralBoolean47 = new();
				public ObjectFlow SingleDelegation_P_PWP_Operation_main_ObjectFlow48 = new();
					public LiteralInteger SingleDelegation_P_PWP_Operation_main_ObjectFlow48_LiteralInteger49 = new();
					public LiteralBoolean SingleDelegation_P_PWP_Operation_main_ObjectFlow48_LiteralBoolean50 = new();
				public ControlFlow SingleDelegation_P_PWP_Operation_main_ControlFlow51 = new();
				public ValueSpecificationAction SingleDelegation_P_PWP_Operation_main_Value_4 = new();
					public OutputPin SingleDelegation_P_PWP_Operation_main_Value_4_result = new();
						public LiteralUnlimitedNatural SingleDelegation_P_PWP_Operation_main_Value_4_result_LiteralUnlimitedNatural52 = new();
						public LiteralInteger SingleDelegation_P_PWP_Operation_main_Value_4_result_LiteralInteger53 = new();
					public LiteralInteger SingleDelegation_P_PWP_Operation_main_Value_4_LiteralInteger54 = new();
				public ControlFlow SingleDelegation_P_PWP_Operation_main_ControlFlow55 = new();
				public ValueSpecificationAction SingleDelegation_P_PWP_Operation_main_InitialMessage = new();
					public OutputPin SingleDelegation_P_PWP_Operation_main_InitialMessage_result = new();
						public LiteralUnlimitedNatural SingleDelegation_P_PWP_Operation_main_InitialMessage_result_LiteralUnlimitedNatural56 = new();
						public LiteralInteger SingleDelegation_P_PWP_Operation_main_InitialMessage_result_LiteralInteger57 = new();
					public LiteralString SingleDelegation_P_PWP_Operation_main_InitialMessage_LiteralString58 = new();
				public CallBehaviorAction SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage = new();
					public InputPin SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage_value = new();
						public LiteralInteger SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage_value_LiteralInteger59 = new();
						public LiteralInteger SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage_value_LiteralInteger60 = new();
						public LiteralUnlimitedNatural SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage_value_LiteralUnlimitedNatural61 = new();
					public OutputPin SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage_errorStatus = new();
						public LiteralInteger SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage_errorStatus_LiteralInteger62 = new();
						public LiteralInteger SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage_errorStatus_LiteralInteger63 = new();
						public LiteralUnlimitedNatural SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage_errorStatus_LiteralUnlimitedNatural64 = new();
				public ObjectFlow SingleDelegation_P_PWP_Operation_main_ObjectFlow65 = new();
					public LiteralInteger SingleDelegation_P_PWP_Operation_main_ObjectFlow65_LiteralInteger66 = new();
					public LiteralBoolean SingleDelegation_P_PWP_Operation_main_ObjectFlow65_LiteralBoolean67 = new();
				public ObjectFlow SingleDelegation_P_PWP_Operation_main_ObjectFlow68 = new();
					public LiteralInteger SingleDelegation_P_PWP_Operation_main_ObjectFlow68_LiteralInteger69 = new();
					public LiteralBoolean SingleDelegation_P_PWP_Operation_main_ObjectFlow68_LiteralBoolean70 = new();
				public ForkNode SingleDelegation_P_PWP_Operation_main_Fork_C = new();
				public CallBehaviorAction SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage = new();
					public InputPin SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage_value = new();
						public LiteralInteger SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage_value_LiteralInteger71 = new();
						public LiteralUnlimitedNatural SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage_value_LiteralUnlimitedNatural72 = new();
						public LiteralInteger SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage_value_LiteralInteger73 = new();
					public OutputPin SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage_errorStatus = new();
						public LiteralInteger SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage_errorStatus_LiteralInteger74 = new();
						public LiteralInteger SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage_errorStatus_LiteralInteger75 = new();
						public LiteralUnlimitedNatural SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage_errorStatus_LiteralUnlimitedNatural76 = new();
				public ObjectFlow SingleDelegation_P_PWP_Operation_main_ObjectFlow77 = new();
					public LiteralInteger SingleDelegation_P_PWP_Operation_main_ObjectFlow77_LiteralInteger78 = new();
					public LiteralBoolean SingleDelegation_P_PWP_Operation_main_ObjectFlow77_LiteralBoolean79 = new();
				public CallOperationAction SingleDelegation_P_PWP_Operation_main_Call_c_p_setP = new();
					public InputPin SingleDelegation_P_PWP_Operation_main_Call_c_p_setP_target = new();
						public LiteralInteger SingleDelegation_P_PWP_Operation_main_Call_c_p_setP_target_LiteralInteger80 = new();
						public LiteralUnlimitedNatural SingleDelegation_P_PWP_Operation_main_Call_c_p_setP_target_LiteralUnlimitedNatural81 = new();
					public InputPin SingleDelegation_P_PWP_Operation_main_Call_c_p_setP_v = new();
						public LiteralInteger SingleDelegation_P_PWP_Operation_main_Call_c_p_setP_v_LiteralInteger82 = new();
						public LiteralInteger SingleDelegation_P_PWP_Operation_main_Call_c_p_setP_v_LiteralInteger83 = new();
						public LiteralUnlimitedNatural SingleDelegation_P_PWP_Operation_main_Call_c_p_setP_v_LiteralUnlimitedNatural84 = new();
				public ValueSpecificationAction SingleDelegation_P_PWP_Operation_main_EndMessage = new();
					public LiteralString SingleDelegation_P_PWP_Operation_main_EndMessage_LiteralString85 = new();
					public OutputPin SingleDelegation_P_PWP_Operation_main_EndMessage_result = new();
						public LiteralUnlimitedNatural SingleDelegation_P_PWP_Operation_main_EndMessage_result_LiteralUnlimitedNatural86 = new();
						public LiteralInteger SingleDelegation_P_PWP_Operation_main_EndMessage_result_LiteralInteger87 = new();
			public Association SingleDelegation_P_PWP_Operation_U = new();
				public Property SingleDelegation_P_PWP_Operation_U_y = new();
				public Property SingleDelegation_P_PWP_Operation_U_x = new();
			public Class_ SingleDelegation_P_PWP_Operation_IImpl = new();
				public Operation SingleDelegation_P_PWP_Operation_IImpl_setP_Integer = new();
					public Parameter SingleDelegation_P_PWP_Operation_IImpl_setP_Integer_v = new();
				public InterfaceRealization SingleDelegation_P_PWP_Operation_IImpl_IRealization = new();
			public Class_ SingleDelegation_P_PWP_Operation_A = new();
				public Property SingleDelegation_P_PWP_Operation_A_b = new();
				public Operation SingleDelegation_P_PWP_Operation_A_A_A = new();
					public Parameter SingleDelegation_P_PWP_Operation_A_A_A_result = new();
				public Port SingleDelegation_P_PWP_Operation_A_q = new();
				public Connector SingleDelegation_P_PWP_Operation_A_r = new();
					public ConnectorEnd SingleDelegation_P_PWP_Operation_A_r_ConnectorEnd88 = new();
					public ConnectorEnd SingleDelegation_P_PWP_Operation_A_r_ConnectorEnd89 = new();
			public Interface SingleDelegation_P_PWP_Operation_I = new();
				public Operation SingleDelegation_P_PWP_Operation_I_setP_Integer = new();
					public Parameter SingleDelegation_P_PWP_Operation_I_setP_Integer_v = new();
			public Class_ SingleDelegation_P_PWP_Operation_C = new();
				public Property SingleDelegation_P_PWP_Operation_C_a = new();
				public Connector SingleDelegation_P_PWP_Operation_C_u = new();
					public ConnectorEnd SingleDelegation_P_PWP_Operation_C_u_ConnectorEnd90 = new();
					public ConnectorEnd SingleDelegation_P_PWP_Operation_C_u_ConnectorEnd91 = new();
				public Operation SingleDelegation_P_PWP_Operation_C_C_C = new();
					public Parameter SingleDelegation_P_PWP_Operation_C_C_C_result = new();
				public Port SingleDelegation_P_PWP_Operation_C_p = new();
			public Class_ SingleDelegation_P_PWP_Operation_B = new();
				public InterfaceRealization SingleDelegation_P_PWP_Operation_B_IRealization = new();
				public Activity SingleDelegation_P_PWP_Operation_B_setPActivity = new();
					public AddStructuralFeatureValueAction SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p = new();
						public InputPin SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p_value = new();
							public LiteralInteger SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p_value_LiteralInteger92 = new();
							public LiteralUnlimitedNatural SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p_value_LiteralUnlimitedNatural93 = new();
						public InputPin SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p_object = new();
							public LiteralUnlimitedNatural SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p_object_LiteralUnlimitedNatural94 = new();
							public LiteralInteger SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p_object_LiteralInteger95 = new();
						public OutputPin SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p_result = new();
							public LiteralUnlimitedNatural SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p_result_LiteralUnlimitedNatural96 = new();
							public LiteralInteger SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p_result_LiteralInteger97 = new();
					public ObjectFlow SingleDelegation_P_PWP_Operation_B_setPActivity_ObjectFlow98 = new();
						public LiteralInteger SingleDelegation_P_PWP_Operation_B_setPActivity_ObjectFlow98_LiteralInteger99 = new();
						public LiteralBoolean SingleDelegation_P_PWP_Operation_B_setPActivity_ObjectFlow98_LiteralBoolean100 = new();
					public ObjectFlow SingleDelegation_P_PWP_Operation_B_setPActivity_ObjectFlow101 = new();
						public LiteralBoolean SingleDelegation_P_PWP_Operation_B_setPActivity_ObjectFlow101_LiteralBoolean102 = new();
						public LiteralInteger SingleDelegation_P_PWP_Operation_B_setPActivity_ObjectFlow101_LiteralInteger103 = new();
					public ActivityParameterNode SingleDelegation_P_PWP_Operation_B_setPActivity_vParameterNode = new();
						public LiteralInteger SingleDelegation_P_PWP_Operation_B_setPActivity_vParameterNode_LiteralInteger104 = new();
					public Parameter SingleDelegation_P_PWP_Operation_B_setPActivity_v = new();
					public ReadSelfAction SingleDelegation_P_PWP_Operation_B_setPActivity_this = new();
						public OutputPin SingleDelegation_P_PWP_Operation_B_setPActivity_this_result = new();
							public LiteralUnlimitedNatural SingleDelegation_P_PWP_Operation_B_setPActivity_this_result_LiteralUnlimitedNatural105 = new();
							public LiteralInteger SingleDelegation_P_PWP_Operation_B_setPActivity_this_result_LiteralInteger106 = new();
				public Operation SingleDelegation_P_PWP_Operation_B_B_B = new();
					public Parameter SingleDelegation_P_PWP_Operation_B_B_B_result = new();
				public Property SingleDelegation_P_PWP_Operation_B_p = new();
				public Operation SingleDelegation_P_PWP_Operation_B_setP_Integer = new();
					public Parameter SingleDelegation_P_PWP_Operation_B_setP_Integer_v = new();

		public static SingleDelegation_P_PWP_OperationModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public SingleDelegation_P_PWP_OperationModel()
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
			 * Model SingleDelegation_P_PWP_Operation
			 */
			AddToElementRepository("SingleDelegation_P_PWP_Operation", SingleDelegation_P_PWP_Operation);
				AddToElementRepository("R", SingleDelegation_P_PWP_Operation_R);
					AddToElementRepository("y", SingleDelegation_P_PWP_Operation_R_y);
					AddToElementRepository("x", SingleDelegation_P_PWP_Operation_R_x);
				AddToElementRepository("main", SingleDelegation_P_PWP_Operation_main);
					AddToElementRepository("Read c.a", SingleDelegation_P_PWP_Operation_main_Read_c_a);
						AddToElementRepository("result", SingleDelegation_P_PWP_Operation_main_Read_c_a_result);
							AddToElementRepository("LiteralUnlimitedNatural0", SingleDelegation_P_PWP_Operation_main_Read_c_a_result_LiteralUnlimitedNatural0);
							AddToElementRepository("LiteralInteger1", SingleDelegation_P_PWP_Operation_main_Read_c_a_result_LiteralInteger1);
						AddToElementRepository("object", SingleDelegation_P_PWP_Operation_main_Read_c_a_object);
							AddToElementRepository("LiteralUnlimitedNatural2", SingleDelegation_P_PWP_Operation_main_Read_c_a_object_LiteralUnlimitedNatural2);
							AddToElementRepository("LiteralInteger3", SingleDelegation_P_PWP_Operation_main_Read_c_a_object_LiteralInteger3);
					AddToElementRepository("ObjectFlow4", SingleDelegation_P_PWP_Operation_main_ObjectFlow4);
						AddToElementRepository("LiteralBoolean5", SingleDelegation_P_PWP_Operation_main_ObjectFlow4_LiteralBoolean5);
						AddToElementRepository("LiteralInteger6", SingleDelegation_P_PWP_Operation_main_ObjectFlow4_LiteralInteger6);
					AddToElementRepository("Read b.p", SingleDelegation_P_PWP_Operation_main_Read_b_p);
						AddToElementRepository("object", SingleDelegation_P_PWP_Operation_main_Read_b_p_object);
							AddToElementRepository("LiteralInteger7", SingleDelegation_P_PWP_Operation_main_Read_b_p_object_LiteralInteger7);
							AddToElementRepository("LiteralUnlimitedNatural8", SingleDelegation_P_PWP_Operation_main_Read_b_p_object_LiteralUnlimitedNatural8);
						AddToElementRepository("result", SingleDelegation_P_PWP_Operation_main_Read_b_p_result);
							AddToElementRepository("LiteralUnlimitedNatural9", SingleDelegation_P_PWP_Operation_main_Read_b_p_result_LiteralUnlimitedNatural9);
							AddToElementRepository("LiteralInteger10", SingleDelegation_P_PWP_Operation_main_Read_b_p_result_LiteralInteger10);
					AddToElementRepository("Call testP", SingleDelegation_P_PWP_Operation_main_Call_testP);
						AddToElementRepository("p", SingleDelegation_P_PWP_Operation_main_Call_testP_p);
							AddToElementRepository("LiteralInteger11", SingleDelegation_P_PWP_Operation_main_Call_testP_p_LiteralInteger11);
							AddToElementRepository("LiteralUnlimitedNatural12", SingleDelegation_P_PWP_Operation_main_Call_testP_p_LiteralUnlimitedNatural12);
							AddToElementRepository("LiteralInteger13", SingleDelegation_P_PWP_Operation_main_Call_testP_p_LiteralInteger13);
					AddToElementRepository("ObjectFlow14", SingleDelegation_P_PWP_Operation_main_ObjectFlow14);
						AddToElementRepository("LiteralBoolean15", SingleDelegation_P_PWP_Operation_main_ObjectFlow14_LiteralBoolean15);
						AddToElementRepository("LiteralInteger16", SingleDelegation_P_PWP_Operation_main_ObjectFlow14_LiteralInteger16);
					AddToElementRepository("ControlFlow17", SingleDelegation_P_PWP_Operation_main_ControlFlow17);
					AddToElementRepository("Create C", SingleDelegation_P_PWP_Operation_main_Create_C);
						AddToElementRepository("result", SingleDelegation_P_PWP_Operation_main_Create_C_result);
							AddToElementRepository("LiteralInteger18", SingleDelegation_P_PWP_Operation_main_Create_C_result_LiteralInteger18);
							AddToElementRepository("LiteralUnlimitedNatural19", SingleDelegation_P_PWP_Operation_main_Create_C_result_LiteralUnlimitedNatural19);
					AddToElementRepository("Read c.p", SingleDelegation_P_PWP_Operation_main_Read_c_p);
						AddToElementRepository("result", SingleDelegation_P_PWP_Operation_main_Read_c_p_result);
							AddToElementRepository("LiteralInteger20", SingleDelegation_P_PWP_Operation_main_Read_c_p_result_LiteralInteger20);
							AddToElementRepository("LiteralUnlimitedNatural21", SingleDelegation_P_PWP_Operation_main_Read_c_p_result_LiteralUnlimitedNatural21);
						AddToElementRepository("object", SingleDelegation_P_PWP_Operation_main_Read_c_p_object);
							AddToElementRepository("LiteralInteger22", SingleDelegation_P_PWP_Operation_main_Read_c_p_object_LiteralInteger22);
							AddToElementRepository("LiteralUnlimitedNatural23", SingleDelegation_P_PWP_Operation_main_Read_c_p_object_LiteralUnlimitedNatural23);
					AddToElementRepository("testP", SingleDelegation_P_PWP_Operation_main_testP);
						AddToElementRepository("p", SingleDelegation_P_PWP_Operation_main_testP_p);
					AddToElementRepository("ObjectFlow24", SingleDelegation_P_PWP_Operation_main_ObjectFlow24);
						AddToElementRepository("LiteralBoolean25", SingleDelegation_P_PWP_Operation_main_ObjectFlow24_LiteralBoolean25);
						AddToElementRepository("LiteralInteger26", SingleDelegation_P_PWP_Operation_main_ObjectFlow24_LiteralInteger26);
					AddToElementRepository("ObjectFlow27", SingleDelegation_P_PWP_Operation_main_ObjectFlow27);
						AddToElementRepository("LiteralBoolean28", SingleDelegation_P_PWP_Operation_main_ObjectFlow27_LiteralBoolean28);
						AddToElementRepository("LiteralInteger29", SingleDelegation_P_PWP_Operation_main_ObjectFlow27_LiteralInteger29);
					AddToElementRepository("C()", SingleDelegation_P_PWP_Operation_main_C_);
						AddToElementRepository("result", SingleDelegation_P_PWP_Operation_main_C__result);
							AddToElementRepository("LiteralInteger30", SingleDelegation_P_PWP_Operation_main_C__result_LiteralInteger30);
							AddToElementRepository("LiteralInteger31", SingleDelegation_P_PWP_Operation_main_C__result_LiteralInteger31);
							AddToElementRepository("LiteralUnlimitedNatural32", SingleDelegation_P_PWP_Operation_main_C__result_LiteralUnlimitedNatural32);
						AddToElementRepository("target", SingleDelegation_P_PWP_Operation_main_C__target);
							AddToElementRepository("LiteralInteger33", SingleDelegation_P_PWP_Operation_main_C__target_LiteralInteger33);
							AddToElementRepository("LiteralUnlimitedNatural34", SingleDelegation_P_PWP_Operation_main_C__target_LiteralUnlimitedNatural34);
					AddToElementRepository("Read a.b", SingleDelegation_P_PWP_Operation_main_Read_a_b);
						AddToElementRepository("object", SingleDelegation_P_PWP_Operation_main_Read_a_b_object);
							AddToElementRepository("LiteralUnlimitedNatural35", SingleDelegation_P_PWP_Operation_main_Read_a_b_object_LiteralUnlimitedNatural35);
							AddToElementRepository("LiteralInteger36", SingleDelegation_P_PWP_Operation_main_Read_a_b_object_LiteralInteger36);
						AddToElementRepository("result", SingleDelegation_P_PWP_Operation_main_Read_a_b_result);
							AddToElementRepository("LiteralUnlimitedNatural37", SingleDelegation_P_PWP_Operation_main_Read_a_b_result_LiteralUnlimitedNatural37);
							AddToElementRepository("LiteralInteger38", SingleDelegation_P_PWP_Operation_main_Read_a_b_result_LiteralInteger38);
					AddToElementRepository("ObjectFlow39", SingleDelegation_P_PWP_Operation_main_ObjectFlow39);
						AddToElementRepository("LiteralInteger40", SingleDelegation_P_PWP_Operation_main_ObjectFlow39_LiteralInteger40);
						AddToElementRepository("LiteralBoolean41", SingleDelegation_P_PWP_Operation_main_ObjectFlow39_LiteralBoolean41);
					AddToElementRepository("ObjectFlow42", SingleDelegation_P_PWP_Operation_main_ObjectFlow42);
						AddToElementRepository("LiteralInteger43", SingleDelegation_P_PWP_Operation_main_ObjectFlow42_LiteralInteger43);
						AddToElementRepository("LiteralBoolean44", SingleDelegation_P_PWP_Operation_main_ObjectFlow42_LiteralBoolean44);
					AddToElementRepository("ObjectFlow45", SingleDelegation_P_PWP_Operation_main_ObjectFlow45);
						AddToElementRepository("LiteralInteger46", SingleDelegation_P_PWP_Operation_main_ObjectFlow45_LiteralInteger46);
						AddToElementRepository("LiteralBoolean47", SingleDelegation_P_PWP_Operation_main_ObjectFlow45_LiteralBoolean47);
					AddToElementRepository("ObjectFlow48", SingleDelegation_P_PWP_Operation_main_ObjectFlow48);
						AddToElementRepository("LiteralInteger49", SingleDelegation_P_PWP_Operation_main_ObjectFlow48_LiteralInteger49);
						AddToElementRepository("LiteralBoolean50", SingleDelegation_P_PWP_Operation_main_ObjectFlow48_LiteralBoolean50);
					AddToElementRepository("ControlFlow51", SingleDelegation_P_PWP_Operation_main_ControlFlow51);
					AddToElementRepository("Value(4)", SingleDelegation_P_PWP_Operation_main_Value_4);
						AddToElementRepository("result", SingleDelegation_P_PWP_Operation_main_Value_4_result);
							AddToElementRepository("LiteralUnlimitedNatural52", SingleDelegation_P_PWP_Operation_main_Value_4_result_LiteralUnlimitedNatural52);
							AddToElementRepository("LiteralInteger53", SingleDelegation_P_PWP_Operation_main_Value_4_result_LiteralInteger53);
						AddToElementRepository("LiteralInteger54", SingleDelegation_P_PWP_Operation_main_Value_4_LiteralInteger54);
					AddToElementRepository("ControlFlow55", SingleDelegation_P_PWP_Operation_main_ControlFlow55);
					AddToElementRepository("InitialMessage", SingleDelegation_P_PWP_Operation_main_InitialMessage);
						AddToElementRepository("result", SingleDelegation_P_PWP_Operation_main_InitialMessage_result);
							AddToElementRepository("LiteralUnlimitedNatural56", SingleDelegation_P_PWP_Operation_main_InitialMessage_result_LiteralUnlimitedNatural56);
							AddToElementRepository("LiteralInteger57", SingleDelegation_P_PWP_Operation_main_InitialMessage_result_LiteralInteger57);
						AddToElementRepository("LiteralString58", SingleDelegation_P_PWP_Operation_main_InitialMessage_LiteralString58);
					AddToElementRepository("WriteLine(EndMessage)", SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage);
						AddToElementRepository("value", SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage_value);
							AddToElementRepository("LiteralInteger59", SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage_value_LiteralInteger59);
							AddToElementRepository("LiteralInteger60", SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage_value_LiteralInteger60);
							AddToElementRepository("LiteralUnlimitedNatural61", SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage_value_LiteralUnlimitedNatural61);
						AddToElementRepository("errorStatus", SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage_errorStatus);
							AddToElementRepository("LiteralInteger62", SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage_errorStatus_LiteralInteger62);
							AddToElementRepository("LiteralInteger63", SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage_errorStatus_LiteralInteger63);
							AddToElementRepository("LiteralUnlimitedNatural64", SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage_errorStatus_LiteralUnlimitedNatural64);
					AddToElementRepository("ObjectFlow65", SingleDelegation_P_PWP_Operation_main_ObjectFlow65);
						AddToElementRepository("LiteralInteger66", SingleDelegation_P_PWP_Operation_main_ObjectFlow65_LiteralInteger66);
						AddToElementRepository("LiteralBoolean67", SingleDelegation_P_PWP_Operation_main_ObjectFlow65_LiteralBoolean67);
					AddToElementRepository("ObjectFlow68", SingleDelegation_P_PWP_Operation_main_ObjectFlow68);
						AddToElementRepository("LiteralInteger69", SingleDelegation_P_PWP_Operation_main_ObjectFlow68_LiteralInteger69);
						AddToElementRepository("LiteralBoolean70", SingleDelegation_P_PWP_Operation_main_ObjectFlow68_LiteralBoolean70);
					AddToElementRepository("Fork C", SingleDelegation_P_PWP_Operation_main_Fork_C);
					AddToElementRepository("WriteLine(InitialMessage)", SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage);
						AddToElementRepository("value", SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage_value);
							AddToElementRepository("LiteralInteger71", SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage_value_LiteralInteger71);
							AddToElementRepository("LiteralUnlimitedNatural72", SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage_value_LiteralUnlimitedNatural72);
							AddToElementRepository("LiteralInteger73", SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage_value_LiteralInteger73);
						AddToElementRepository("errorStatus", SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage_errorStatus);
							AddToElementRepository("LiteralInteger74", SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage_errorStatus_LiteralInteger74);
							AddToElementRepository("LiteralInteger75", SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage_errorStatus_LiteralInteger75);
							AddToElementRepository("LiteralUnlimitedNatural76", SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage_errorStatus_LiteralUnlimitedNatural76);
					AddToElementRepository("ObjectFlow77", SingleDelegation_P_PWP_Operation_main_ObjectFlow77);
						AddToElementRepository("LiteralInteger78", SingleDelegation_P_PWP_Operation_main_ObjectFlow77_LiteralInteger78);
						AddToElementRepository("LiteralBoolean79", SingleDelegation_P_PWP_Operation_main_ObjectFlow77_LiteralBoolean79);
					AddToElementRepository("Call c.p.setP", SingleDelegation_P_PWP_Operation_main_Call_c_p_setP);
						AddToElementRepository("target", SingleDelegation_P_PWP_Operation_main_Call_c_p_setP_target);
							AddToElementRepository("LiteralInteger80", SingleDelegation_P_PWP_Operation_main_Call_c_p_setP_target_LiteralInteger80);
							AddToElementRepository("LiteralUnlimitedNatural81", SingleDelegation_P_PWP_Operation_main_Call_c_p_setP_target_LiteralUnlimitedNatural81);
						AddToElementRepository("v", SingleDelegation_P_PWP_Operation_main_Call_c_p_setP_v);
							AddToElementRepository("LiteralInteger82", SingleDelegation_P_PWP_Operation_main_Call_c_p_setP_v_LiteralInteger82);
							AddToElementRepository("LiteralInteger83", SingleDelegation_P_PWP_Operation_main_Call_c_p_setP_v_LiteralInteger83);
							AddToElementRepository("LiteralUnlimitedNatural84", SingleDelegation_P_PWP_Operation_main_Call_c_p_setP_v_LiteralUnlimitedNatural84);
					AddToElementRepository("EndMessage", SingleDelegation_P_PWP_Operation_main_EndMessage);
						AddToElementRepository("LiteralString85", SingleDelegation_P_PWP_Operation_main_EndMessage_LiteralString85);
						AddToElementRepository("result", SingleDelegation_P_PWP_Operation_main_EndMessage_result);
							AddToElementRepository("LiteralUnlimitedNatural86", SingleDelegation_P_PWP_Operation_main_EndMessage_result_LiteralUnlimitedNatural86);
							AddToElementRepository("LiteralInteger87", SingleDelegation_P_PWP_Operation_main_EndMessage_result_LiteralInteger87);
				AddToElementRepository("U", SingleDelegation_P_PWP_Operation_U);
					AddToElementRepository("y", SingleDelegation_P_PWP_Operation_U_y);
					AddToElementRepository("x", SingleDelegation_P_PWP_Operation_U_x);
				AddToElementRepository("IImpl", SingleDelegation_P_PWP_Operation_IImpl);
					AddToElementRepository("setP_Integer", SingleDelegation_P_PWP_Operation_IImpl_setP_Integer);
						AddToElementRepository("v", SingleDelegation_P_PWP_Operation_IImpl_setP_Integer_v);
					AddToElementRepository("IRealization", SingleDelegation_P_PWP_Operation_IImpl_IRealization);
				AddToElementRepository("A", SingleDelegation_P_PWP_Operation_A);
					AddToElementRepository("b", SingleDelegation_P_PWP_Operation_A_b);
					AddToElementRepository("A_A", SingleDelegation_P_PWP_Operation_A_A_A);
						AddToElementRepository("result", SingleDelegation_P_PWP_Operation_A_A_A_result);
					AddToElementRepository("q", SingleDelegation_P_PWP_Operation_A_q);
					AddToElementRepository("r", SingleDelegation_P_PWP_Operation_A_r);
						AddToElementRepository("ConnectorEnd88", SingleDelegation_P_PWP_Operation_A_r_ConnectorEnd88);
						AddToElementRepository("ConnectorEnd89", SingleDelegation_P_PWP_Operation_A_r_ConnectorEnd89);
				AddToElementRepository("I", SingleDelegation_P_PWP_Operation_I);
					AddToElementRepository("setP_Integer", SingleDelegation_P_PWP_Operation_I_setP_Integer);
						AddToElementRepository("v", SingleDelegation_P_PWP_Operation_I_setP_Integer_v);
				AddToElementRepository("C", SingleDelegation_P_PWP_Operation_C);
					AddToElementRepository("a", SingleDelegation_P_PWP_Operation_C_a);
					AddToElementRepository("u", SingleDelegation_P_PWP_Operation_C_u);
						AddToElementRepository("ConnectorEnd90", SingleDelegation_P_PWP_Operation_C_u_ConnectorEnd90);
						AddToElementRepository("ConnectorEnd91", SingleDelegation_P_PWP_Operation_C_u_ConnectorEnd91);
					AddToElementRepository("C_C", SingleDelegation_P_PWP_Operation_C_C_C);
						AddToElementRepository("result", SingleDelegation_P_PWP_Operation_C_C_C_result);
					AddToElementRepository("p", SingleDelegation_P_PWP_Operation_C_p);
				AddToElementRepository("B", SingleDelegation_P_PWP_Operation_B);
					AddToElementRepository("IRealization", SingleDelegation_P_PWP_Operation_B_IRealization);
					AddToElementRepository("setPActivity", SingleDelegation_P_PWP_Operation_B_setPActivity);
						AddToElementRepository("Set this.p", SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p);
							AddToElementRepository("value", SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p_value);
								AddToElementRepository("LiteralInteger92", SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p_value_LiteralInteger92);
								AddToElementRepository("LiteralUnlimitedNatural93", SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p_value_LiteralUnlimitedNatural93);
							AddToElementRepository("object", SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p_object);
								AddToElementRepository("LiteralUnlimitedNatural94", SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p_object_LiteralUnlimitedNatural94);
								AddToElementRepository("LiteralInteger95", SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p_object_LiteralInteger95);
							AddToElementRepository("result", SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p_result);
								AddToElementRepository("LiteralUnlimitedNatural96", SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p_result_LiteralUnlimitedNatural96);
								AddToElementRepository("LiteralInteger97", SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p_result_LiteralInteger97);
						AddToElementRepository("ObjectFlow98", SingleDelegation_P_PWP_Operation_B_setPActivity_ObjectFlow98);
							AddToElementRepository("LiteralInteger99", SingleDelegation_P_PWP_Operation_B_setPActivity_ObjectFlow98_LiteralInteger99);
							AddToElementRepository("LiteralBoolean100", SingleDelegation_P_PWP_Operation_B_setPActivity_ObjectFlow98_LiteralBoolean100);
						AddToElementRepository("ObjectFlow101", SingleDelegation_P_PWP_Operation_B_setPActivity_ObjectFlow101);
							AddToElementRepository("LiteralBoolean102", SingleDelegation_P_PWP_Operation_B_setPActivity_ObjectFlow101_LiteralBoolean102);
							AddToElementRepository("LiteralInteger103", SingleDelegation_P_PWP_Operation_B_setPActivity_ObjectFlow101_LiteralInteger103);
						AddToElementRepository("vParameterNode", SingleDelegation_P_PWP_Operation_B_setPActivity_vParameterNode);
							AddToElementRepository("LiteralInteger104", SingleDelegation_P_PWP_Operation_B_setPActivity_vParameterNode_LiteralInteger104);
						AddToElementRepository("v", SingleDelegation_P_PWP_Operation_B_setPActivity_v);
						AddToElementRepository("this", SingleDelegation_P_PWP_Operation_B_setPActivity_this);
							AddToElementRepository("result", SingleDelegation_P_PWP_Operation_B_setPActivity_this_result);
								AddToElementRepository("LiteralUnlimitedNatural105", SingleDelegation_P_PWP_Operation_B_setPActivity_this_result_LiteralUnlimitedNatural105);
								AddToElementRepository("LiteralInteger106", SingleDelegation_P_PWP_Operation_B_setPActivity_this_result_LiteralInteger106);
					AddToElementRepository("B_B", SingleDelegation_P_PWP_Operation_B_B_B);
						AddToElementRepository("result", SingleDelegation_P_PWP_Operation_B_B_B_result);
					AddToElementRepository("p", SingleDelegation_P_PWP_Operation_B_p);
					AddToElementRepository("setP_Integer", SingleDelegation_P_PWP_Operation_B_setP_Integer);
						AddToElementRepository("v", SingleDelegation_P_PWP_Operation_B_setP_Integer_v);

			// Initialize public members
			/*
			 * Model SingleDelegation_P_PWP_Operation
			 */
			SingleDelegation_P_PWP_Operation.SetName("SingleDelegation_P_PWP_Operation");
			SingleDelegation_P_PWP_Operation.SetVisibility(VisibilityKind.public_);
				// Association R
				SingleDelegation_P_PWP_Operation_R.SetName("R");
				SingleDelegation_P_PWP_Operation_R.SetVisibility(VisibilityKind.public_);
				SingleDelegation_P_PWP_Operation_R.AddOwnedEnd(SingleDelegation_P_PWP_Operation_R_x);
				SingleDelegation_P_PWP_Operation_R.AddOwnedEnd(SingleDelegation_P_PWP_Operation_R_y);
			SingleDelegation_P_PWP_Operation.AddPackagedElement(SingleDelegation_P_PWP_Operation_R);
				// Activity main
				SingleDelegation_P_PWP_Operation_main.SetName("main");
				SingleDelegation_P_PWP_Operation_main.SetVisibility(VisibilityKind.public_);
				// FunctionBehavior testP
					SingleDelegation_P_PWP_Operation_main_testP.SetName("testP");
					SingleDelegation_P_PWP_Operation_main_testP.SetVisibility(VisibilityKind.public_);
					
						// Parameter p
						SingleDelegation_P_PWP_Operation_main_testP_p.SetName("p");
						SingleDelegation_P_PWP_Operation_main_testP_p.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_PWP_Operation_main_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					SingleDelegation_P_PWP_Operation_main_testP.AddOwnedParameter(SingleDelegation_P_PWP_Operation_main_testP_p);
					SingleDelegation_P_PWP_Operation_main_testP.AddLanguage("C#");
					SingleDelegation_P_PWP_Operation_main_testP.AddLanguage("Using");
					SingleDelegation_P_PWP_Operation_main_testP.AddBody("Console.WriteLine(\"Asserting c.a.b.p == 4\");  	// Test parameter p 	int p = ((IntegerValue)inputParameters.ElementAt(0).values.ElementAt(0)).value; 	Debug.Println(\"[doBody] argument p = \" + p); 	 	Console.WriteLine(\"c.a.b.p == \" + p); 	Console.Write(\"Operation call delegated: \");  	if(p == 4) 	{ 		Console.ForegroundColor = ConsoleColor.Green; 		Console.WriteLine(\"Assertion successful.\"); 	} 	else 	{ 		Console.ForegroundColor = ConsoleColor.Red; 		Console.WriteLine(\"Assertion failed!\"); 	}  	Console.ResetColor();");
					SingleDelegation_P_PWP_Operation_main_testP.AddBody("using fuml.semantics.simpleclassifiers; ");
				SingleDelegation_P_PWP_Operation_main.AddOwnedBehavior(SingleDelegation_P_PWP_Operation_main_testP);
					// CallOperationAction C()
					SingleDelegation_P_PWP_Operation_main_C_.SetName("C()");
					SingleDelegation_P_PWP_Operation_main_C_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						SingleDelegation_P_PWP_Operation_main_C__result.SetName("result");
						SingleDelegation_P_PWP_Operation_main_C__result.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_C__result.SetType(SingleDelegation_P_PWP_Operation_C);
					SingleDelegation_P_PWP_Operation_main_C_.AddResult(SingleDelegation_P_PWP_Operation_main_C__result);
					SingleDelegation_P_PWP_Operation_main_C_.SetOperation(SingleDelegation_P_PWP_Operation_C_C_C);
						// InputPin target
						SingleDelegation_P_PWP_Operation_main_C__target.SetName("target");
						SingleDelegation_P_PWP_Operation_main_C__target.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_C__target.SetType(SingleDelegation_P_PWP_Operation_C);
					SingleDelegation_P_PWP_Operation_main_C_.SetTarget(SingleDelegation_P_PWP_Operation_main_C__target);
				SingleDelegation_P_PWP_Operation_main.AddNode(SingleDelegation_P_PWP_Operation_main_C_);
					// ReadStructuralFeatureAction Read a.b
					SingleDelegation_P_PWP_Operation_main_Read_a_b.SetName("Read a.b");
					SingleDelegation_P_PWP_Operation_main_Read_a_b.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_PWP_Operation_main_Read_a_b.SetStructuralFeature(SingleDelegation_P_PWP_Operation_A_b);
						// InputPin object
						SingleDelegation_P_PWP_Operation_main_Read_a_b_object.SetName("object");
						SingleDelegation_P_PWP_Operation_main_Read_a_b_object.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_Read_a_b_object.SetType(SingleDelegation_P_PWP_Operation_A);
					SingleDelegation_P_PWP_Operation_main_Read_a_b.SetObject(SingleDelegation_P_PWP_Operation_main_Read_a_b_object);
						// OutputPin result
						SingleDelegation_P_PWP_Operation_main_Read_a_b_result.SetName("result");
						SingleDelegation_P_PWP_Operation_main_Read_a_b_result.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_Read_a_b_result.SetType(SingleDelegation_P_PWP_Operation_B);
					SingleDelegation_P_PWP_Operation_main_Read_a_b.SetResult(SingleDelegation_P_PWP_Operation_main_Read_a_b_result);
				SingleDelegation_P_PWP_Operation_main.AddNode(SingleDelegation_P_PWP_Operation_main_Read_a_b);
					// ReadStructuralFeatureAction Read c.a
					SingleDelegation_P_PWP_Operation_main_Read_c_a.SetName("Read c.a");
					SingleDelegation_P_PWP_Operation_main_Read_c_a.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_PWP_Operation_main_Read_c_a.SetStructuralFeature(SingleDelegation_P_PWP_Operation_C_a);
						// InputPin object
						SingleDelegation_P_PWP_Operation_main_Read_c_a_object.SetName("object");
						SingleDelegation_P_PWP_Operation_main_Read_c_a_object.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_Read_c_a_object.SetType(SingleDelegation_P_PWP_Operation_C);
					SingleDelegation_P_PWP_Operation_main_Read_c_a.SetObject(SingleDelegation_P_PWP_Operation_main_Read_c_a_object);
						// OutputPin result
						SingleDelegation_P_PWP_Operation_main_Read_c_a_result.SetName("result");
						SingleDelegation_P_PWP_Operation_main_Read_c_a_result.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_Read_c_a_result.SetType(SingleDelegation_P_PWP_Operation_A);
					SingleDelegation_P_PWP_Operation_main_Read_c_a.SetResult(SingleDelegation_P_PWP_Operation_main_Read_c_a_result);
				SingleDelegation_P_PWP_Operation_main.AddNode(SingleDelegation_P_PWP_Operation_main_Read_c_a);
					// ReadStructuralFeatureAction Read b.p
					SingleDelegation_P_PWP_Operation_main_Read_b_p.SetName("Read b.p");
					SingleDelegation_P_PWP_Operation_main_Read_b_p.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_PWP_Operation_main_Read_b_p.SetStructuralFeature(SingleDelegation_P_PWP_Operation_B_p);
						// InputPin object
						SingleDelegation_P_PWP_Operation_main_Read_b_p_object.SetName("object");
						SingleDelegation_P_PWP_Operation_main_Read_b_p_object.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_Read_b_p_object.SetType(SingleDelegation_P_PWP_Operation_B);
					SingleDelegation_P_PWP_Operation_main_Read_b_p.SetObject(SingleDelegation_P_PWP_Operation_main_Read_b_p_object);
						// OutputPin result
						SingleDelegation_P_PWP_Operation_main_Read_b_p_result.SetName("result");
						SingleDelegation_P_PWP_Operation_main_Read_b_p_result.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_Read_b_p_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					SingleDelegation_P_PWP_Operation_main_Read_b_p.SetResult(SingleDelegation_P_PWP_Operation_main_Read_b_p_result);
				SingleDelegation_P_PWP_Operation_main.AddNode(SingleDelegation_P_PWP_Operation_main_Read_b_p);
					// CallBehaviorAction Call testP
					SingleDelegation_P_PWP_Operation_main_Call_testP.SetName("Call testP");
					SingleDelegation_P_PWP_Operation_main_Call_testP.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_PWP_Operation_main_Call_testP.SetBehavior(SingleDelegation_P_PWP_Operation_main_testP);
						// InputPin p
						SingleDelegation_P_PWP_Operation_main_Call_testP_p.SetName("p");
						SingleDelegation_P_PWP_Operation_main_Call_testP_p.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_Call_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					SingleDelegation_P_PWP_Operation_main_Call_testP.AddArgument(SingleDelegation_P_PWP_Operation_main_Call_testP_p);
				SingleDelegation_P_PWP_Operation_main.AddNode(SingleDelegation_P_PWP_Operation_main_Call_testP);
					// ValueSpecificationAction Value(4)
					SingleDelegation_P_PWP_Operation_main_Value_4.SetName("Value(4)");
					SingleDelegation_P_PWP_Operation_main_Value_4.SetVisibility(VisibilityKind.public_);
						// LiteralInteger LiteralInteger54
						SingleDelegation_P_PWP_Operation_main_Value_4_LiteralInteger54.SetName("LiteralInteger54");
						SingleDelegation_P_PWP_Operation_main_Value_4_LiteralInteger54.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_Value_4_LiteralInteger54.SetValue(4);
					SingleDelegation_P_PWP_Operation_main_Value_4.SetValue(SingleDelegation_P_PWP_Operation_main_Value_4_LiteralInteger54);
						// OutputPin result
						SingleDelegation_P_PWP_Operation_main_Value_4_result.SetName("result");
						SingleDelegation_P_PWP_Operation_main_Value_4_result.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_Value_4_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					SingleDelegation_P_PWP_Operation_main_Value_4.SetResult(SingleDelegation_P_PWP_Operation_main_Value_4_result);
				SingleDelegation_P_PWP_Operation_main.AddNode(SingleDelegation_P_PWP_Operation_main_Value_4);
					// ValueSpecificationAction InitialMessage
					SingleDelegation_P_PWP_Operation_main_InitialMessage.SetName("InitialMessage");
					SingleDelegation_P_PWP_Operation_main_InitialMessage.SetVisibility(VisibilityKind.public_);
						// LiteralString LiteralString58
						SingleDelegation_P_PWP_Operation_main_InitialMessage_LiteralString58.SetName("LiteralString58");
						SingleDelegation_P_PWP_Operation_main_InitialMessage_LiteralString58.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_InitialMessage_LiteralString58.SetValue("-- Running test case: Single delegation connector - Operation delegated from port to part with port --");
					SingleDelegation_P_PWP_Operation_main_InitialMessage.SetValue(SingleDelegation_P_PWP_Operation_main_InitialMessage_LiteralString58);
						// OutputPin result
						SingleDelegation_P_PWP_Operation_main_InitialMessage_result.SetName("result");
						SingleDelegation_P_PWP_Operation_main_InitialMessage_result.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_InitialMessage_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					SingleDelegation_P_PWP_Operation_main_InitialMessage.SetResult(SingleDelegation_P_PWP_Operation_main_InitialMessage_result);
				SingleDelegation_P_PWP_Operation_main.AddNode(SingleDelegation_P_PWP_Operation_main_InitialMessage);
					// CallBehaviorAction WriteLine(EndMessage)
					SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage.SetName("WriteLine(EndMessage)");
					SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage.SetVisibility(VisibilityKind.public_);
					
						// OutputPin errorStatus
						SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage_errorStatus.SetName("errorStatus");
						SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage_errorStatus.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage_errorStatus.SetType(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_Common_Status);
						SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage_errorStatus.SetLower(0);
					SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage.AddResult(SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage_errorStatus);
					SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
						// InputPin value
						SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage_value.SetName("value");
						SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage_value.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage.AddArgument(SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage_value);
				SingleDelegation_P_PWP_Operation_main.AddNode(SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage);
					// CreateObjectAction Create C
					SingleDelegation_P_PWP_Operation_main_Create_C.SetName("Create C");
					SingleDelegation_P_PWP_Operation_main_Create_C.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_PWP_Operation_main_Create_C.SetClassifier(SingleDelegation_P_PWP_Operation_C);
						// OutputPin result
						SingleDelegation_P_PWP_Operation_main_Create_C_result.SetName("result");
						SingleDelegation_P_PWP_Operation_main_Create_C_result.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_Create_C_result.SetType(SingleDelegation_P_PWP_Operation_C);
					SingleDelegation_P_PWP_Operation_main_Create_C.SetResult(SingleDelegation_P_PWP_Operation_main_Create_C_result);
				SingleDelegation_P_PWP_Operation_main.AddNode(SingleDelegation_P_PWP_Operation_main_Create_C);
					// ReadStructuralFeatureAction Read c.p
					SingleDelegation_P_PWP_Operation_main_Read_c_p.SetName("Read c.p");
					SingleDelegation_P_PWP_Operation_main_Read_c_p.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_PWP_Operation_main_Read_c_p.SetStructuralFeature(SingleDelegation_P_PWP_Operation_C_p);
						// InputPin object
						SingleDelegation_P_PWP_Operation_main_Read_c_p_object.SetName("object");
						SingleDelegation_P_PWP_Operation_main_Read_c_p_object.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_Read_c_p_object.SetType(SingleDelegation_P_PWP_Operation_C);
					SingleDelegation_P_PWP_Operation_main_Read_c_p.SetObject(SingleDelegation_P_PWP_Operation_main_Read_c_p_object);
						// OutputPin result
						SingleDelegation_P_PWP_Operation_main_Read_c_p_result.SetName("result");
						SingleDelegation_P_PWP_Operation_main_Read_c_p_result.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_Read_c_p_result.SetType(SingleDelegation_P_PWP_Operation_IImpl);
					SingleDelegation_P_PWP_Operation_main_Read_c_p.SetResult(SingleDelegation_P_PWP_Operation_main_Read_c_p_result);
				SingleDelegation_P_PWP_Operation_main.AddNode(SingleDelegation_P_PWP_Operation_main_Read_c_p);
					// ForkNode Fork C
					SingleDelegation_P_PWP_Operation_main_Fork_C.SetName("Fork C");
					SingleDelegation_P_PWP_Operation_main_Fork_C.SetVisibility(VisibilityKind.public_);
				SingleDelegation_P_PWP_Operation_main.AddNode(SingleDelegation_P_PWP_Operation_main_Fork_C);
					// CallBehaviorAction WriteLine(InitialMessage)
					SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage.SetName("WriteLine(InitialMessage)");
					SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage.SetVisibility(VisibilityKind.public_);
					
						// OutputPin errorStatus
						SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage_errorStatus.SetName("errorStatus");
						SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage_errorStatus.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage_errorStatus.SetType(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_Common_Status);
						SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage_errorStatus.SetLower(0);
					SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage.AddResult(SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage_errorStatus);
					SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
						// InputPin value
						SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage_value.SetName("value");
						SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage_value.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage.AddArgument(SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage_value);
				SingleDelegation_P_PWP_Operation_main.AddNode(SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage);
					// CallOperationAction Call c.p.setP
					SingleDelegation_P_PWP_Operation_main_Call_c_p_setP.SetName("Call c.p.setP");
					SingleDelegation_P_PWP_Operation_main_Call_c_p_setP.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_PWP_Operation_main_Call_c_p_setP.SetOperation(SingleDelegation_P_PWP_Operation_I_setP_Integer);
						// InputPin target
						SingleDelegation_P_PWP_Operation_main_Call_c_p_setP_target.SetName("target");
						SingleDelegation_P_PWP_Operation_main_Call_c_p_setP_target.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_PWP_Operation_main_Call_c_p_setP.SetTarget(SingleDelegation_P_PWP_Operation_main_Call_c_p_setP_target);
						// InputPin v
						SingleDelegation_P_PWP_Operation_main_Call_c_p_setP_v.SetName("v");
						SingleDelegation_P_PWP_Operation_main_Call_c_p_setP_v.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_Call_c_p_setP_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					SingleDelegation_P_PWP_Operation_main_Call_c_p_setP.AddArgument(SingleDelegation_P_PWP_Operation_main_Call_c_p_setP_v);
				SingleDelegation_P_PWP_Operation_main.AddNode(SingleDelegation_P_PWP_Operation_main_Call_c_p_setP);
					// ValueSpecificationAction EndMessage
					SingleDelegation_P_PWP_Operation_main_EndMessage.SetName("EndMessage");
					SingleDelegation_P_PWP_Operation_main_EndMessage.SetVisibility(VisibilityKind.public_);
						// LiteralString LiteralString85
						SingleDelegation_P_PWP_Operation_main_EndMessage_LiteralString85.SetName("LiteralString85");
						SingleDelegation_P_PWP_Operation_main_EndMessage_LiteralString85.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_EndMessage_LiteralString85.SetValue("-- End of test case --");
					SingleDelegation_P_PWP_Operation_main_EndMessage.SetValue(SingleDelegation_P_PWP_Operation_main_EndMessage_LiteralString85);
						// OutputPin result
						SingleDelegation_P_PWP_Operation_main_EndMessage_result.SetName("result");
						SingleDelegation_P_PWP_Operation_main_EndMessage_result.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_EndMessage_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					SingleDelegation_P_PWP_Operation_main_EndMessage.SetResult(SingleDelegation_P_PWP_Operation_main_EndMessage_result);
				SingleDelegation_P_PWP_Operation_main.AddNode(SingleDelegation_P_PWP_Operation_main_EndMessage);
					// ObjectFlow ObjectFlow39 from result to target
					SingleDelegation_P_PWP_Operation_main_ObjectFlow39.SetName("ObjectFlow39");
					SingleDelegation_P_PWP_Operation_main_ObjectFlow39.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_PWP_Operation_main_ObjectFlow39.SetSource(SingleDelegation_P_PWP_Operation_main_Create_C_result);
					SingleDelegation_P_PWP_Operation_main_ObjectFlow39.SetTarget(SingleDelegation_P_PWP_Operation_main_C__target);
						// LiteralBoolean LiteralBoolean41
						SingleDelegation_P_PWP_Operation_main_ObjectFlow39_LiteralBoolean41.SetName("LiteralBoolean41");
						SingleDelegation_P_PWP_Operation_main_ObjectFlow39_LiteralBoolean41.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_ObjectFlow39_LiteralBoolean41.SetValue(true);
					SingleDelegation_P_PWP_Operation_main_ObjectFlow39.SetGuard(SingleDelegation_P_PWP_Operation_main_ObjectFlow39_LiteralBoolean41);
				SingleDelegation_P_PWP_Operation_main.AddEdge(SingleDelegation_P_PWP_Operation_main_ObjectFlow39);
					// ObjectFlow ObjectFlow42 from result to v
					SingleDelegation_P_PWP_Operation_main_ObjectFlow42.SetName("ObjectFlow42");
					SingleDelegation_P_PWP_Operation_main_ObjectFlow42.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_PWP_Operation_main_ObjectFlow42.SetSource(SingleDelegation_P_PWP_Operation_main_Value_4_result);
					SingleDelegation_P_PWP_Operation_main_ObjectFlow42.SetTarget(SingleDelegation_P_PWP_Operation_main_Call_c_p_setP_v);
						// LiteralBoolean LiteralBoolean44
						SingleDelegation_P_PWP_Operation_main_ObjectFlow42_LiteralBoolean44.SetName("LiteralBoolean44");
						SingleDelegation_P_PWP_Operation_main_ObjectFlow42_LiteralBoolean44.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_ObjectFlow42_LiteralBoolean44.SetValue(true);
					SingleDelegation_P_PWP_Operation_main_ObjectFlow42.SetGuard(SingleDelegation_P_PWP_Operation_main_ObjectFlow42_LiteralBoolean44);
				SingleDelegation_P_PWP_Operation_main.AddEdge(SingleDelegation_P_PWP_Operation_main_ObjectFlow42);
					// ObjectFlow ObjectFlow45 from result to object
					SingleDelegation_P_PWP_Operation_main_ObjectFlow45.SetName("ObjectFlow45");
					SingleDelegation_P_PWP_Operation_main_ObjectFlow45.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_PWP_Operation_main_ObjectFlow45.SetSource(SingleDelegation_P_PWP_Operation_main_Read_a_b_result);
					SingleDelegation_P_PWP_Operation_main_ObjectFlow45.SetTarget(SingleDelegation_P_PWP_Operation_main_Read_b_p_object);
						// LiteralBoolean LiteralBoolean47
						SingleDelegation_P_PWP_Operation_main_ObjectFlow45_LiteralBoolean47.SetName("LiteralBoolean47");
						SingleDelegation_P_PWP_Operation_main_ObjectFlow45_LiteralBoolean47.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_ObjectFlow45_LiteralBoolean47.SetValue(true);
					SingleDelegation_P_PWP_Operation_main_ObjectFlow45.SetGuard(SingleDelegation_P_PWP_Operation_main_ObjectFlow45_LiteralBoolean47);
				SingleDelegation_P_PWP_Operation_main.AddEdge(SingleDelegation_P_PWP_Operation_main_ObjectFlow45);
					// ObjectFlow ObjectFlow48 from Fork C to object
					SingleDelegation_P_PWP_Operation_main_ObjectFlow48.SetName("ObjectFlow48");
					SingleDelegation_P_PWP_Operation_main_ObjectFlow48.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_PWP_Operation_main_ObjectFlow48.SetSource(SingleDelegation_P_PWP_Operation_main_Fork_C);
					SingleDelegation_P_PWP_Operation_main_ObjectFlow48.SetTarget(SingleDelegation_P_PWP_Operation_main_Read_c_a_object);
						// LiteralBoolean LiteralBoolean50
						SingleDelegation_P_PWP_Operation_main_ObjectFlow48_LiteralBoolean50.SetName("LiteralBoolean50");
						SingleDelegation_P_PWP_Operation_main_ObjectFlow48_LiteralBoolean50.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_ObjectFlow48_LiteralBoolean50.SetValue(true);
					SingleDelegation_P_PWP_Operation_main_ObjectFlow48.SetGuard(SingleDelegation_P_PWP_Operation_main_ObjectFlow48_LiteralBoolean50);
				SingleDelegation_P_PWP_Operation_main.AddEdge(SingleDelegation_P_PWP_Operation_main_ObjectFlow48);
					// ObjectFlow ObjectFlow4 from result to object
					SingleDelegation_P_PWP_Operation_main_ObjectFlow4.SetName("ObjectFlow4");
					SingleDelegation_P_PWP_Operation_main_ObjectFlow4.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_PWP_Operation_main_ObjectFlow4.SetSource(SingleDelegation_P_PWP_Operation_main_Read_c_a_result);
					SingleDelegation_P_PWP_Operation_main_ObjectFlow4.SetTarget(SingleDelegation_P_PWP_Operation_main_Read_a_b_object);
						// LiteralBoolean LiteralBoolean5
						SingleDelegation_P_PWP_Operation_main_ObjectFlow4_LiteralBoolean5.SetName("LiteralBoolean5");
						SingleDelegation_P_PWP_Operation_main_ObjectFlow4_LiteralBoolean5.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_ObjectFlow4_LiteralBoolean5.SetValue(true);
					SingleDelegation_P_PWP_Operation_main_ObjectFlow4.SetGuard(SingleDelegation_P_PWP_Operation_main_ObjectFlow4_LiteralBoolean5);
				SingleDelegation_P_PWP_Operation_main.AddEdge(SingleDelegation_P_PWP_Operation_main_ObjectFlow4);
					// ControlFlow ControlFlow51 from Call c.p.setP to Read c.a
					SingleDelegation_P_PWP_Operation_main_ControlFlow51.SetName("ControlFlow51");
					SingleDelegation_P_PWP_Operation_main_ControlFlow51.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_PWP_Operation_main_ControlFlow51.SetSource(SingleDelegation_P_PWP_Operation_main_Call_c_p_setP);
					SingleDelegation_P_PWP_Operation_main_ControlFlow51.SetTarget(SingleDelegation_P_PWP_Operation_main_Read_c_a);
				SingleDelegation_P_PWP_Operation_main.AddEdge(SingleDelegation_P_PWP_Operation_main_ControlFlow51);
					// ControlFlow ControlFlow55 from WriteLine(InitialMessage) to Create C
					SingleDelegation_P_PWP_Operation_main_ControlFlow55.SetName("ControlFlow55");
					SingleDelegation_P_PWP_Operation_main_ControlFlow55.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_PWP_Operation_main_ControlFlow55.SetSource(SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage);
					SingleDelegation_P_PWP_Operation_main_ControlFlow55.SetTarget(SingleDelegation_P_PWP_Operation_main_Create_C);
				SingleDelegation_P_PWP_Operation_main.AddEdge(SingleDelegation_P_PWP_Operation_main_ControlFlow55);
					// ObjectFlow ObjectFlow14 from result to Fork C
					SingleDelegation_P_PWP_Operation_main_ObjectFlow14.SetName("ObjectFlow14");
					SingleDelegation_P_PWP_Operation_main_ObjectFlow14.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_PWP_Operation_main_ObjectFlow14.SetSource(SingleDelegation_P_PWP_Operation_main_C__result);
					SingleDelegation_P_PWP_Operation_main_ObjectFlow14.SetTarget(SingleDelegation_P_PWP_Operation_main_Fork_C);
						// LiteralBoolean LiteralBoolean15
						SingleDelegation_P_PWP_Operation_main_ObjectFlow14_LiteralBoolean15.SetName("LiteralBoolean15");
						SingleDelegation_P_PWP_Operation_main_ObjectFlow14_LiteralBoolean15.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_ObjectFlow14_LiteralBoolean15.SetValue(true);
					SingleDelegation_P_PWP_Operation_main_ObjectFlow14.SetGuard(SingleDelegation_P_PWP_Operation_main_ObjectFlow14_LiteralBoolean15);
				SingleDelegation_P_PWP_Operation_main.AddEdge(SingleDelegation_P_PWP_Operation_main_ObjectFlow14);
					// ObjectFlow ObjectFlow65 from result to p
					SingleDelegation_P_PWP_Operation_main_ObjectFlow65.SetName("ObjectFlow65");
					SingleDelegation_P_PWP_Operation_main_ObjectFlow65.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_PWP_Operation_main_ObjectFlow65.SetSource(SingleDelegation_P_PWP_Operation_main_Read_b_p_result);
					SingleDelegation_P_PWP_Operation_main_ObjectFlow65.SetTarget(SingleDelegation_P_PWP_Operation_main_Call_testP_p);
						// LiteralBoolean LiteralBoolean67
						SingleDelegation_P_PWP_Operation_main_ObjectFlow65_LiteralBoolean67.SetName("LiteralBoolean67");
						SingleDelegation_P_PWP_Operation_main_ObjectFlow65_LiteralBoolean67.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_ObjectFlow65_LiteralBoolean67.SetValue(true);
					SingleDelegation_P_PWP_Operation_main_ObjectFlow65.SetGuard(SingleDelegation_P_PWP_Operation_main_ObjectFlow65_LiteralBoolean67);
				SingleDelegation_P_PWP_Operation_main.AddEdge(SingleDelegation_P_PWP_Operation_main_ObjectFlow65);
					// ControlFlow ControlFlow17 from Call testP to WriteLine(EndMessage)
					SingleDelegation_P_PWP_Operation_main_ControlFlow17.SetName("ControlFlow17");
					SingleDelegation_P_PWP_Operation_main_ControlFlow17.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_PWP_Operation_main_ControlFlow17.SetSource(SingleDelegation_P_PWP_Operation_main_Call_testP);
					SingleDelegation_P_PWP_Operation_main_ControlFlow17.SetTarget(SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage);
				SingleDelegation_P_PWP_Operation_main.AddEdge(SingleDelegation_P_PWP_Operation_main_ControlFlow17);
					// ObjectFlow ObjectFlow68 from result to value
					SingleDelegation_P_PWP_Operation_main_ObjectFlow68.SetName("ObjectFlow68");
					SingleDelegation_P_PWP_Operation_main_ObjectFlow68.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_PWP_Operation_main_ObjectFlow68.SetSource(SingleDelegation_P_PWP_Operation_main_InitialMessage_result);
					SingleDelegation_P_PWP_Operation_main_ObjectFlow68.SetTarget(SingleDelegation_P_PWP_Operation_main_WriteLine_InitialMessage_value);
						// LiteralBoolean LiteralBoolean70
						SingleDelegation_P_PWP_Operation_main_ObjectFlow68_LiteralBoolean70.SetName("LiteralBoolean70");
						SingleDelegation_P_PWP_Operation_main_ObjectFlow68_LiteralBoolean70.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_ObjectFlow68_LiteralBoolean70.SetValue(true);
					SingleDelegation_P_PWP_Operation_main_ObjectFlow68.SetGuard(SingleDelegation_P_PWP_Operation_main_ObjectFlow68_LiteralBoolean70);
				SingleDelegation_P_PWP_Operation_main.AddEdge(SingleDelegation_P_PWP_Operation_main_ObjectFlow68);
					// ObjectFlow ObjectFlow24 from Fork C to object
					SingleDelegation_P_PWP_Operation_main_ObjectFlow24.SetName("ObjectFlow24");
					SingleDelegation_P_PWP_Operation_main_ObjectFlow24.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_PWP_Operation_main_ObjectFlow24.SetSource(SingleDelegation_P_PWP_Operation_main_Fork_C);
					SingleDelegation_P_PWP_Operation_main_ObjectFlow24.SetTarget(SingleDelegation_P_PWP_Operation_main_Read_c_p_object);
						// LiteralBoolean LiteralBoolean25
						SingleDelegation_P_PWP_Operation_main_ObjectFlow24_LiteralBoolean25.SetName("LiteralBoolean25");
						SingleDelegation_P_PWP_Operation_main_ObjectFlow24_LiteralBoolean25.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_ObjectFlow24_LiteralBoolean25.SetValue(true);
					SingleDelegation_P_PWP_Operation_main_ObjectFlow24.SetGuard(SingleDelegation_P_PWP_Operation_main_ObjectFlow24_LiteralBoolean25);
				SingleDelegation_P_PWP_Operation_main.AddEdge(SingleDelegation_P_PWP_Operation_main_ObjectFlow24);
					// ObjectFlow ObjectFlow27 from result to value
					SingleDelegation_P_PWP_Operation_main_ObjectFlow27.SetName("ObjectFlow27");
					SingleDelegation_P_PWP_Operation_main_ObjectFlow27.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_PWP_Operation_main_ObjectFlow27.SetSource(SingleDelegation_P_PWP_Operation_main_EndMessage_result);
					SingleDelegation_P_PWP_Operation_main_ObjectFlow27.SetTarget(SingleDelegation_P_PWP_Operation_main_WriteLine_EndMessage_value);
						// LiteralBoolean LiteralBoolean28
						SingleDelegation_P_PWP_Operation_main_ObjectFlow27_LiteralBoolean28.SetName("LiteralBoolean28");
						SingleDelegation_P_PWP_Operation_main_ObjectFlow27_LiteralBoolean28.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_ObjectFlow27_LiteralBoolean28.SetValue(true);
					SingleDelegation_P_PWP_Operation_main_ObjectFlow27.SetGuard(SingleDelegation_P_PWP_Operation_main_ObjectFlow27_LiteralBoolean28);
				SingleDelegation_P_PWP_Operation_main.AddEdge(SingleDelegation_P_PWP_Operation_main_ObjectFlow27);
					// ObjectFlow ObjectFlow77 from result to target
					SingleDelegation_P_PWP_Operation_main_ObjectFlow77.SetName("ObjectFlow77");
					SingleDelegation_P_PWP_Operation_main_ObjectFlow77.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_PWP_Operation_main_ObjectFlow77.SetSource(SingleDelegation_P_PWP_Operation_main_Read_c_p_result);
					SingleDelegation_P_PWP_Operation_main_ObjectFlow77.SetTarget(SingleDelegation_P_PWP_Operation_main_Call_c_p_setP_target);
						// LiteralBoolean LiteralBoolean79
						SingleDelegation_P_PWP_Operation_main_ObjectFlow77_LiteralBoolean79.SetName("LiteralBoolean79");
						SingleDelegation_P_PWP_Operation_main_ObjectFlow77_LiteralBoolean79.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_main_ObjectFlow77_LiteralBoolean79.SetValue(true);
					SingleDelegation_P_PWP_Operation_main_ObjectFlow77.SetGuard(SingleDelegation_P_PWP_Operation_main_ObjectFlow77_LiteralBoolean79);
				SingleDelegation_P_PWP_Operation_main.AddEdge(SingleDelegation_P_PWP_Operation_main_ObjectFlow77);
			SingleDelegation_P_PWP_Operation.AddPackagedElement(SingleDelegation_P_PWP_Operation_main);
				// Association U
				SingleDelegation_P_PWP_Operation_U.SetName("U");
				SingleDelegation_P_PWP_Operation_U.SetVisibility(VisibilityKind.public_);
				SingleDelegation_P_PWP_Operation_U.AddOwnedEnd(SingleDelegation_P_PWP_Operation_U_x);
				SingleDelegation_P_PWP_Operation_U.AddOwnedEnd(SingleDelegation_P_PWP_Operation_U_y);
			SingleDelegation_P_PWP_Operation.AddPackagedElement(SingleDelegation_P_PWP_Operation_U);
				// Class IImpl
				SingleDelegation_P_PWP_Operation_IImpl.SetName("IImpl");
				SingleDelegation_P_PWP_Operation_IImpl.SetVisibility(VisibilityKind.public_);
				SingleDelegation_P_PWP_Operation_IImpl_IRealization.SetName("IRealization");
					SingleDelegation_P_PWP_Operation_IImpl_IRealization.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_PWP_Operation_IImpl_IRealization.SetContract(SingleDelegation_P_PWP_Operation_I);
					
				SingleDelegation_P_PWP_Operation_IImpl.AddInterfaceRealization(SingleDelegation_P_PWP_Operation_IImpl_IRealization);
				
					// Operation setP_Integer
					SingleDelegation_P_PWP_Operation_IImpl_setP_Integer.SetName("setP_Integer");
					SingleDelegation_P_PWP_Operation_IImpl_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						SingleDelegation_P_PWP_Operation_IImpl_setP_Integer_v.SetName("v");
						SingleDelegation_P_PWP_Operation_IImpl_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_PWP_Operation_IImpl_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					SingleDelegation_P_PWP_Operation_IImpl_setP_Integer.AddOwnedParameter(SingleDelegation_P_PWP_Operation_IImpl_setP_Integer_v);
				SingleDelegation_P_PWP_Operation_IImpl.AddOwnedOperation(SingleDelegation_P_PWP_Operation_IImpl_setP_Integer);
			SingleDelegation_P_PWP_Operation.AddPackagedElement(SingleDelegation_P_PWP_Operation_IImpl);
				// Class A
				SingleDelegation_P_PWP_Operation_A.SetName("A");
				SingleDelegation_P_PWP_Operation_A.SetVisibility(VisibilityKind.public_);
				
					// Port q
					SingleDelegation_P_PWP_Operation_A_q.SetName("q");
					SingleDelegation_P_PWP_Operation_A_q.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_PWP_Operation_A_q.SetType(SingleDelegation_P_PWP_Operation_IImpl);
					SingleDelegation_P_PWP_Operation_A_q.SetAggregation(AggregationKind.composite);
					SingleDelegation_P_PWP_Operation_A_q.isService = true;
					SingleDelegation_P_PWP_Operation_A_q.AddProvided(SingleDelegation_P_PWP_Operation_I);
				SingleDelegation_P_PWP_Operation_A.AddOwnedAttribute(SingleDelegation_P_PWP_Operation_A_q);
					// Property b
					SingleDelegation_P_PWP_Operation_A_b.SetName("b");
					SingleDelegation_P_PWP_Operation_A_b.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_PWP_Operation_A_b.SetType(SingleDelegation_P_PWP_Operation_B);
					SingleDelegation_P_PWP_Operation_A_b.SetAggregation(AggregationKind.composite);
				SingleDelegation_P_PWP_Operation_A.AddOwnedAttribute(SingleDelegation_P_PWP_Operation_A_b);
				
				SingleDelegation_P_PWP_Operation_A_r.SetName("r");
					SingleDelegation_P_PWP_Operation_A_r.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_PWP_Operation_A_r_ConnectorEnd89.SetRole(SingleDelegation_P_PWP_Operation_A_q);
						
					SingleDelegation_P_PWP_Operation_A_r.AddEnd(SingleDelegation_P_PWP_Operation_A_r_ConnectorEnd89);
						
						SingleDelegation_P_PWP_Operation_A_r_ConnectorEnd88.SetRole(SingleDelegation_P_PWP_Operation_A_b);
						
					SingleDelegation_P_PWP_Operation_A_r.AddEnd(SingleDelegation_P_PWP_Operation_A_r_ConnectorEnd88);
					SingleDelegation_P_PWP_Operation_A_r.SetType(SingleDelegation_P_PWP_Operation_R);
				SingleDelegation_P_PWP_Operation_A.AddOwnedConnector(SingleDelegation_P_PWP_Operation_A_r);
					// Operation A_A
					SingleDelegation_P_PWP_Operation_A_A_A.SetName("A_A");
					SingleDelegation_P_PWP_Operation_A_A_A.SetVisibility(VisibilityKind.public_);
						// Parameter result
						SingleDelegation_P_PWP_Operation_A_A_A_result.SetName("result");
						SingleDelegation_P_PWP_Operation_A_A_A_result.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_PWP_Operation_A_A_A_result.SetType(SingleDelegation_P_PWP_Operation_A);
						SingleDelegation_P_PWP_Operation_A_A_A_result.SetDirection(ParameterDirectionKind.return_);
					SingleDelegation_P_PWP_Operation_A_A_A.AddOwnedParameter(SingleDelegation_P_PWP_Operation_A_A_A_result);
					SingleDelegation_P_PWP_Operation_A_A_A.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				SingleDelegation_P_PWP_Operation_A.AddOwnedOperation(SingleDelegation_P_PWP_Operation_A_A_A);
			SingleDelegation_P_PWP_Operation.AddPackagedElement(SingleDelegation_P_PWP_Operation_A);
				// Interface I
				SingleDelegation_P_PWP_Operation_I.SetName("I");
				SingleDelegation_P_PWP_Operation_I.SetVisibility(VisibilityKind.public_);
					// Operation setP_Integer
					SingleDelegation_P_PWP_Operation_I_setP_Integer.SetName("setP_Integer");
					SingleDelegation_P_PWP_Operation_I_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						SingleDelegation_P_PWP_Operation_I_setP_Integer_v.SetName("v");
						SingleDelegation_P_PWP_Operation_I_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_PWP_Operation_I_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					SingleDelegation_P_PWP_Operation_I_setP_Integer.AddOwnedParameter(SingleDelegation_P_PWP_Operation_I_setP_Integer_v);
				SingleDelegation_P_PWP_Operation_I.AddOwnedOperation(SingleDelegation_P_PWP_Operation_I_setP_Integer);
			SingleDelegation_P_PWP_Operation.AddPackagedElement(SingleDelegation_P_PWP_Operation_I);
				// Class C
				SingleDelegation_P_PWP_Operation_C.SetName("C");
				SingleDelegation_P_PWP_Operation_C.SetVisibility(VisibilityKind.public_);
				
					// Port p
					SingleDelegation_P_PWP_Operation_C_p.SetName("p");
					SingleDelegation_P_PWP_Operation_C_p.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_PWP_Operation_C_p.SetType(SingleDelegation_P_PWP_Operation_IImpl);
					SingleDelegation_P_PWP_Operation_C_p.SetAggregation(AggregationKind.composite);
					SingleDelegation_P_PWP_Operation_C_p.isService = true;
					SingleDelegation_P_PWP_Operation_C_p.AddProvided(SingleDelegation_P_PWP_Operation_I);
				SingleDelegation_P_PWP_Operation_C.AddOwnedAttribute(SingleDelegation_P_PWP_Operation_C_p);
					// Property a
					SingleDelegation_P_PWP_Operation_C_a.SetName("a");
					SingleDelegation_P_PWP_Operation_C_a.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_PWP_Operation_C_a.SetType(SingleDelegation_P_PWP_Operation_A);
					SingleDelegation_P_PWP_Operation_C_a.SetAggregation(AggregationKind.composite);
				SingleDelegation_P_PWP_Operation_C.AddOwnedAttribute(SingleDelegation_P_PWP_Operation_C_a);
				
				SingleDelegation_P_PWP_Operation_C_u.SetName("u");
					SingleDelegation_P_PWP_Operation_C_u.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_PWP_Operation_C_u_ConnectorEnd91.SetRole(SingleDelegation_P_PWP_Operation_C_p);
						
					SingleDelegation_P_PWP_Operation_C_u.AddEnd(SingleDelegation_P_PWP_Operation_C_u_ConnectorEnd91);
						
						SingleDelegation_P_PWP_Operation_C_u_ConnectorEnd90.SetRole(SingleDelegation_P_PWP_Operation_A_q);
						SingleDelegation_P_PWP_Operation_C_u_ConnectorEnd90.SetPartWithPort(SingleDelegation_P_PWP_Operation_C_a);
						
					SingleDelegation_P_PWP_Operation_C_u.AddEnd(SingleDelegation_P_PWP_Operation_C_u_ConnectorEnd90);
					SingleDelegation_P_PWP_Operation_C_u.SetType(SingleDelegation_P_PWP_Operation_U);
				SingleDelegation_P_PWP_Operation_C.AddOwnedConnector(SingleDelegation_P_PWP_Operation_C_u);
					// Operation C_C
					SingleDelegation_P_PWP_Operation_C_C_C.SetName("C_C");
					SingleDelegation_P_PWP_Operation_C_C_C.SetVisibility(VisibilityKind.public_);
						// Parameter result
						SingleDelegation_P_PWP_Operation_C_C_C_result.SetName("result");
						SingleDelegation_P_PWP_Operation_C_C_C_result.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_PWP_Operation_C_C_C_result.SetType(SingleDelegation_P_PWP_Operation_C);
						SingleDelegation_P_PWP_Operation_C_C_C_result.SetDirection(ParameterDirectionKind.return_);
					SingleDelegation_P_PWP_Operation_C_C_C.AddOwnedParameter(SingleDelegation_P_PWP_Operation_C_C_C_result);
					SingleDelegation_P_PWP_Operation_C_C_C.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				SingleDelegation_P_PWP_Operation_C.AddOwnedOperation(SingleDelegation_P_PWP_Operation_C_C_C);
			SingleDelegation_P_PWP_Operation.AddPackagedElement(SingleDelegation_P_PWP_Operation_C);
				// Class B
				SingleDelegation_P_PWP_Operation_B.SetName("B");
				SingleDelegation_P_PWP_Operation_B.SetVisibility(VisibilityKind.public_);
				
					// Property p
					SingleDelegation_P_PWP_Operation_B_p.SetName("p");
					SingleDelegation_P_PWP_Operation_B_p.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_PWP_Operation_B_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
				SingleDelegation_P_PWP_Operation_B.AddOwnedAttribute(SingleDelegation_P_PWP_Operation_B_p);
				// Activity setPActivity
					SingleDelegation_P_PWP_Operation_B_setPActivity.SetName("setPActivity");
					SingleDelegation_P_PWP_Operation_B_setPActivity.SetVisibility(VisibilityKind.public_);
					
						// Parameter v
						SingleDelegation_P_PWP_Operation_B_setPActivity_v.SetName("v");
						SingleDelegation_P_PWP_Operation_B_setPActivity_v.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_PWP_Operation_B_setPActivity_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					SingleDelegation_P_PWP_Operation_B_setPActivity.AddOwnedParameter(SingleDelegation_P_PWP_Operation_B_setPActivity_v);
						// AddStructuralFeatureValueAction Set this.p
						SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p.SetName("Set this.p");
						SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p.SetStructuralFeature(SingleDelegation_P_PWP_Operation_B_p);
							// InputPin object
							SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p_object.SetName("object");
							SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p_object.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p_object.SetType(SingleDelegation_P_PWP_Operation_B);
						SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p.SetObject(SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p_object);
							// InputPin value
							SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p_value.SetName("value");
							SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p_value.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p.SetValue(SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p_value);
							// OutputPin result
							SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p_result.SetName("result");
							SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p_result.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p_result.SetType(SingleDelegation_P_PWP_Operation_B);
						SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p.SetResult(SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p_result);
					SingleDelegation_P_PWP_Operation_B_setPActivity.AddNode(SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p);
						// ActivityParameterNode vParameterNode
						SingleDelegation_P_PWP_Operation_B_setPActivity_vParameterNode.SetName("vParameterNode");
						SingleDelegation_P_PWP_Operation_B_setPActivity_vParameterNode.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_PWP_Operation_B_setPActivity_vParameterNode.SetParameter(SingleDelegation_P_PWP_Operation_B_setPActivity_v);
					SingleDelegation_P_PWP_Operation_B_setPActivity.AddNode(SingleDelegation_P_PWP_Operation_B_setPActivity_vParameterNode);
						// ReadSelfAction this
						SingleDelegation_P_PWP_Operation_B_setPActivity_this.SetName("this");
						SingleDelegation_P_PWP_Operation_B_setPActivity_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							SingleDelegation_P_PWP_Operation_B_setPActivity_this_result.SetName("result");
							SingleDelegation_P_PWP_Operation_B_setPActivity_this_result.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_PWP_Operation_B_setPActivity_this_result.SetType(SingleDelegation_P_PWP_Operation_B);
						SingleDelegation_P_PWP_Operation_B_setPActivity_this.SetResult(SingleDelegation_P_PWP_Operation_B_setPActivity_this_result);
					SingleDelegation_P_PWP_Operation_B_setPActivity.AddNode(SingleDelegation_P_PWP_Operation_B_setPActivity_this);
						// ObjectFlow ObjectFlow98 from result to object
						SingleDelegation_P_PWP_Operation_B_setPActivity_ObjectFlow98.SetName("ObjectFlow98");
						SingleDelegation_P_PWP_Operation_B_setPActivity_ObjectFlow98.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_PWP_Operation_B_setPActivity_ObjectFlow98.SetSource(SingleDelegation_P_PWP_Operation_B_setPActivity_this_result);
						SingleDelegation_P_PWP_Operation_B_setPActivity_ObjectFlow98.SetTarget(SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p_object);
							// LiteralBoolean LiteralBoolean100
							SingleDelegation_P_PWP_Operation_B_setPActivity_ObjectFlow98_LiteralBoolean100.SetName("LiteralBoolean100");
							SingleDelegation_P_PWP_Operation_B_setPActivity_ObjectFlow98_LiteralBoolean100.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_PWP_Operation_B_setPActivity_ObjectFlow98_LiteralBoolean100.SetValue(true);
						SingleDelegation_P_PWP_Operation_B_setPActivity_ObjectFlow98.SetGuard(SingleDelegation_P_PWP_Operation_B_setPActivity_ObjectFlow98_LiteralBoolean100);
					SingleDelegation_P_PWP_Operation_B_setPActivity.AddEdge(SingleDelegation_P_PWP_Operation_B_setPActivity_ObjectFlow98);
						// ObjectFlow ObjectFlow101 from vParameterNode to value
						SingleDelegation_P_PWP_Operation_B_setPActivity_ObjectFlow101.SetName("ObjectFlow101");
						SingleDelegation_P_PWP_Operation_B_setPActivity_ObjectFlow101.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_PWP_Operation_B_setPActivity_ObjectFlow101.SetSource(SingleDelegation_P_PWP_Operation_B_setPActivity_vParameterNode);
						SingleDelegation_P_PWP_Operation_B_setPActivity_ObjectFlow101.SetTarget(SingleDelegation_P_PWP_Operation_B_setPActivity_Set_this_p_value);
							// LiteralBoolean LiteralBoolean102
							SingleDelegation_P_PWP_Operation_B_setPActivity_ObjectFlow101_LiteralBoolean102.SetName("LiteralBoolean102");
							SingleDelegation_P_PWP_Operation_B_setPActivity_ObjectFlow101_LiteralBoolean102.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_PWP_Operation_B_setPActivity_ObjectFlow101_LiteralBoolean102.SetValue(true);
						SingleDelegation_P_PWP_Operation_B_setPActivity_ObjectFlow101.SetGuard(SingleDelegation_P_PWP_Operation_B_setPActivity_ObjectFlow101_LiteralBoolean102);
					SingleDelegation_P_PWP_Operation_B_setPActivity.AddEdge(SingleDelegation_P_PWP_Operation_B_setPActivity_ObjectFlow101);
				SingleDelegation_P_PWP_Operation_B.AddOwnedBehavior(SingleDelegation_P_PWP_Operation_B_setPActivity);
					SingleDelegation_P_PWP_Operation_B_IRealization.SetName("IRealization");
					SingleDelegation_P_PWP_Operation_B_IRealization.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_PWP_Operation_B_IRealization.SetContract(SingleDelegation_P_PWP_Operation_I);
					
				SingleDelegation_P_PWP_Operation_B.AddInterfaceRealization(SingleDelegation_P_PWP_Operation_B_IRealization);
				
					// Operation B_B
					SingleDelegation_P_PWP_Operation_B_B_B.SetName("B_B");
					SingleDelegation_P_PWP_Operation_B_B_B.SetVisibility(VisibilityKind.public_);
						// Parameter result
						SingleDelegation_P_PWP_Operation_B_B_B_result.SetName("result");
						SingleDelegation_P_PWP_Operation_B_B_B_result.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_PWP_Operation_B_B_B_result.SetType(SingleDelegation_P_PWP_Operation_B);
						SingleDelegation_P_PWP_Operation_B_B_B_result.SetDirection(ParameterDirectionKind.return_);
					SingleDelegation_P_PWP_Operation_B_B_B.AddOwnedParameter(SingleDelegation_P_PWP_Operation_B_B_B_result);
					SingleDelegation_P_PWP_Operation_B_B_B.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				SingleDelegation_P_PWP_Operation_B.AddOwnedOperation(SingleDelegation_P_PWP_Operation_B_B_B);
					// Operation setP_Integer
					SingleDelegation_P_PWP_Operation_B_setP_Integer.SetName("setP_Integer");
					SingleDelegation_P_PWP_Operation_B_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						SingleDelegation_P_PWP_Operation_B_setP_Integer_v.SetName("v");
						SingleDelegation_P_PWP_Operation_B_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_PWP_Operation_B_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					SingleDelegation_P_PWP_Operation_B_setP_Integer.AddOwnedParameter(SingleDelegation_P_PWP_Operation_B_setP_Integer_v);
					SingleDelegation_P_PWP_Operation_B_setP_Integer.AddMethod(SingleDelegation_P_PWP_Operation_B_setPActivity);
				SingleDelegation_P_PWP_Operation_B.AddOwnedOperation(SingleDelegation_P_PWP_Operation_B_setP_Integer);
			SingleDelegation_P_PWP_Operation.AddPackagedElement(SingleDelegation_P_PWP_Operation_B);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // SingleDelegation_P_PWP_OperationModel
}
