/*
 * Operation_RequiredInterface_DelegationChainModel.cs
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

namespace Operation_RequiredInterface_DelegationChain
{
	public class Operation_RequiredInterface_DelegationChainModel : InMemoryModel
	{
		private static Operation_RequiredInterface_DelegationChainModel? instance;

		/*
		 * Model Operation_RequiredInterface_DelegationChain
		 */
		public Package Operation_RequiredInterface_DelegationChain = new();
			public Class_ Operation_RequiredInterface_DelegationChain_C = new();
				public Operation Operation_RequiredInterface_DelegationChain_C_setP_Integer = new();
					public Parameter Operation_RequiredInterface_DelegationChain_C_setP_Integer_v = new();
				public Port Operation_RequiredInterface_DelegationChain_C_q = new();
				public InterfaceRealization Operation_RequiredInterface_DelegationChain_C_IRealization = new();
				public Activity Operation_RequiredInterface_DelegationChain_C_setPActivity = new();
					public ObjectFlow Operation_RequiredInterface_DelegationChain_C_setPActivity_ObjectFlow0 = new();
						public LiteralBoolean Operation_RequiredInterface_DelegationChain_C_setPActivity_ObjectFlow0_LiteralBoolean1 = new();
						public LiteralInteger Operation_RequiredInterface_DelegationChain_C_setPActivity_ObjectFlow0_LiteralInteger2 = new();
					public ActivityParameterNode Operation_RequiredInterface_DelegationChain_C_setPActivity_vParameterNode = new();
						public LiteralInteger Operation_RequiredInterface_DelegationChain_C_setPActivity_vParameterNode_LiteralInteger3 = new();
					public ObjectFlow Operation_RequiredInterface_DelegationChain_C_setPActivity_ObjectFlow4 = new();
						public LiteralInteger Operation_RequiredInterface_DelegationChain_C_setPActivity_ObjectFlow4_LiteralInteger5 = new();
						public LiteralBoolean Operation_RequiredInterface_DelegationChain_C_setPActivity_ObjectFlow4_LiteralBoolean6 = new();
					public ReadSelfAction Operation_RequiredInterface_DelegationChain_C_setPActivity_this = new();
						public OutputPin Operation_RequiredInterface_DelegationChain_C_setPActivity_this_result = new();
							public LiteralInteger Operation_RequiredInterface_DelegationChain_C_setPActivity_this_result_LiteralInteger7 = new();
							public LiteralUnlimitedNatural Operation_RequiredInterface_DelegationChain_C_setPActivity_this_result_LiteralUnlimitedNatural8 = new();
					public Parameter Operation_RequiredInterface_DelegationChain_C_setPActivity_v = new();
					public CallOperationAction Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q = new();
						public InputPin Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q_target = new();
							public LiteralInteger Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q_target_LiteralInteger9 = new();
							public LiteralUnlimitedNatural Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q_target_LiteralUnlimitedNatural10 = new();
						public InputPin Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q_v = new();
							public LiteralInteger Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q_v_LiteralInteger11 = new();
							public LiteralInteger Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q_v_LiteralInteger12 = new();
							public LiteralUnlimitedNatural Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q_v_LiteralUnlimitedNatural13 = new();
			public Association Operation_RequiredInterface_DelegationChain_S = new();
				public Property Operation_RequiredInterface_DelegationChain_S_y = new();
				public Property Operation_RequiredInterface_DelegationChain_S_x = new();
			public Activity Operation_RequiredInterface_DelegationChain_main = new();
				public ControlFlow Operation_RequiredInterface_DelegationChain_main_ControlFlow14 = new();
				public ValueSpecificationAction Operation_RequiredInterface_DelegationChain_main_Value_4 = new();
					public OutputPin Operation_RequiredInterface_DelegationChain_main_Value_4_result = new();
						public LiteralUnlimitedNatural Operation_RequiredInterface_DelegationChain_main_Value_4_result_LiteralUnlimitedNatural15 = new();
						public LiteralInteger Operation_RequiredInterface_DelegationChain_main_Value_4_result_LiteralInteger16 = new();
					public LiteralInteger Operation_RequiredInterface_DelegationChain_main_Value_4_LiteralInteger17 = new();
				public ReadStructuralFeatureAction Operation_RequiredInterface_DelegationChain_main_Read_a_b = new();
					public InputPin Operation_RequiredInterface_DelegationChain_main_Read_a_b_object = new();
						public LiteralInteger Operation_RequiredInterface_DelegationChain_main_Read_a_b_object_LiteralInteger18 = new();
						public LiteralUnlimitedNatural Operation_RequiredInterface_DelegationChain_main_Read_a_b_object_LiteralUnlimitedNatural19 = new();
					public OutputPin Operation_RequiredInterface_DelegationChain_main_Read_a_b_result = new();
						public LiteralInteger Operation_RequiredInterface_DelegationChain_main_Read_a_b_result_LiteralInteger20 = new();
						public LiteralUnlimitedNatural Operation_RequiredInterface_DelegationChain_main_Read_a_b_result_LiteralUnlimitedNatural21 = new();
				public ObjectFlow Operation_RequiredInterface_DelegationChain_main_ObjectFlow22 = new();
					public LiteralInteger Operation_RequiredInterface_DelegationChain_main_ObjectFlow22_LiteralInteger23 = new();
					public LiteralBoolean Operation_RequiredInterface_DelegationChain_main_ObjectFlow22_LiteralBoolean24 = new();
				public CreateObjectAction Operation_RequiredInterface_DelegationChain_main_Create_D = new();
					public OutputPin Operation_RequiredInterface_DelegationChain_main_Create_D_result = new();
						public LiteralInteger Operation_RequiredInterface_DelegationChain_main_Create_D_result_LiteralInteger25 = new();
						public LiteralUnlimitedNatural Operation_RequiredInterface_DelegationChain_main_Create_D_result_LiteralUnlimitedNatural26 = new();
				public ForkNode Operation_RequiredInterface_DelegationChain_main_Fork_d = new();
				public ObjectFlow Operation_RequiredInterface_DelegationChain_main_ObjectFlow27 = new();
					public LiteralBoolean Operation_RequiredInterface_DelegationChain_main_ObjectFlow27_LiteralBoolean28 = new();
					public LiteralInteger Operation_RequiredInterface_DelegationChain_main_ObjectFlow27_LiteralInteger29 = new();
				public ObjectFlow Operation_RequiredInterface_DelegationChain_main_ObjectFlow30 = new();
					public LiteralInteger Operation_RequiredInterface_DelegationChain_main_ObjectFlow30_LiteralInteger31 = new();
					public LiteralBoolean Operation_RequiredInterface_DelegationChain_main_ObjectFlow30_LiteralBoolean32 = new();
				public ReadStructuralFeatureAction Operation_RequiredInterface_DelegationChain_main_Read_b_p = new();
					public OutputPin Operation_RequiredInterface_DelegationChain_main_Read_b_p_result = new();
						public LiteralInteger Operation_RequiredInterface_DelegationChain_main_Read_b_p_result_LiteralInteger33 = new();
						public LiteralUnlimitedNatural Operation_RequiredInterface_DelegationChain_main_Read_b_p_result_LiteralUnlimitedNatural34 = new();
					public InputPin Operation_RequiredInterface_DelegationChain_main_Read_b_p_object = new();
						public LiteralUnlimitedNatural Operation_RequiredInterface_DelegationChain_main_Read_b_p_object_LiteralUnlimitedNatural35 = new();
						public LiteralInteger Operation_RequiredInterface_DelegationChain_main_Read_b_p_object_LiteralInteger36 = new();
				public ReadStructuralFeatureAction Operation_RequiredInterface_DelegationChain_main_Read_d_a = new();
					public OutputPin Operation_RequiredInterface_DelegationChain_main_Read_d_a_result = new();
						public LiteralInteger Operation_RequiredInterface_DelegationChain_main_Read_d_a_result_LiteralInteger37 = new();
						public LiteralUnlimitedNatural Operation_RequiredInterface_DelegationChain_main_Read_d_a_result_LiteralUnlimitedNatural38 = new();
					public InputPin Operation_RequiredInterface_DelegationChain_main_Read_d_a_object = new();
						public LiteralInteger Operation_RequiredInterface_DelegationChain_main_Read_d_a_object_LiteralInteger39 = new();
						public LiteralUnlimitedNatural Operation_RequiredInterface_DelegationChain_main_Read_d_a_object_LiteralUnlimitedNatural40 = new();
				public ObjectFlow Operation_RequiredInterface_DelegationChain_main_ObjectFlow41 = new();
					public LiteralBoolean Operation_RequiredInterface_DelegationChain_main_ObjectFlow41_LiteralBoolean42 = new();
					public LiteralInteger Operation_RequiredInterface_DelegationChain_main_ObjectFlow41_LiteralInteger43 = new();
				public ReadStructuralFeatureAction Operation_RequiredInterface_DelegationChain_main_Read_e_c = new();
					public OutputPin Operation_RequiredInterface_DelegationChain_main_Read_e_c_result = new();
						public LiteralUnlimitedNatural Operation_RequiredInterface_DelegationChain_main_Read_e_c_result_LiteralUnlimitedNatural44 = new();
						public LiteralInteger Operation_RequiredInterface_DelegationChain_main_Read_e_c_result_LiteralInteger45 = new();
					public InputPin Operation_RequiredInterface_DelegationChain_main_Read_e_c_object = new();
						public LiteralUnlimitedNatural Operation_RequiredInterface_DelegationChain_main_Read_e_c_object_LiteralUnlimitedNatural46 = new();
						public LiteralInteger Operation_RequiredInterface_DelegationChain_main_Read_e_c_object_LiteralInteger47 = new();
				public ObjectFlow Operation_RequiredInterface_DelegationChain_main_ObjectFlow48 = new();
					public LiteralInteger Operation_RequiredInterface_DelegationChain_main_ObjectFlow48_LiteralInteger49 = new();
					public LiteralBoolean Operation_RequiredInterface_DelegationChain_main_ObjectFlow48_LiteralBoolean50 = new();
				public ObjectFlow Operation_RequiredInterface_DelegationChain_main_ObjectFlow51 = new();
					public LiteralInteger Operation_RequiredInterface_DelegationChain_main_ObjectFlow51_LiteralInteger52 = new();
					public LiteralBoolean Operation_RequiredInterface_DelegationChain_main_ObjectFlow51_LiteralBoolean53 = new();
				public ObjectFlow Operation_RequiredInterface_DelegationChain_main_ObjectFlow54 = new();
					public LiteralBoolean Operation_RequiredInterface_DelegationChain_main_ObjectFlow54_LiteralBoolean55 = new();
					public LiteralInteger Operation_RequiredInterface_DelegationChain_main_ObjectFlow54_LiteralInteger56 = new();
				public OpaqueBehavior Operation_RequiredInterface_DelegationChain_main_testP = new();
					public Parameter Operation_RequiredInterface_DelegationChain_main_testP_p = new();
				public CallOperationAction Operation_RequiredInterface_DelegationChain_main_Call_setP_ = new();
					public InputPin Operation_RequiredInterface_DelegationChain_main_Call_setP__v = new();
						public LiteralUnlimitedNatural Operation_RequiredInterface_DelegationChain_main_Call_setP__v_LiteralUnlimitedNatural57 = new();
						public LiteralInteger Operation_RequiredInterface_DelegationChain_main_Call_setP__v_LiteralInteger58 = new();
						public LiteralInteger Operation_RequiredInterface_DelegationChain_main_Call_setP__v_LiteralInteger59 = new();
					public InputPin Operation_RequiredInterface_DelegationChain_main_Call_setP__target = new();
						public LiteralInteger Operation_RequiredInterface_DelegationChain_main_Call_setP__target_LiteralInteger60 = new();
						public LiteralUnlimitedNatural Operation_RequiredInterface_DelegationChain_main_Call_setP__target_LiteralUnlimitedNatural61 = new();
				public CallBehaviorAction Operation_RequiredInterface_DelegationChain_main_Call_testP = new();
					public InputPin Operation_RequiredInterface_DelegationChain_main_Call_testP_p = new();
						public LiteralUnlimitedNatural Operation_RequiredInterface_DelegationChain_main_Call_testP_p_LiteralUnlimitedNatural62 = new();
						public LiteralInteger Operation_RequiredInterface_DelegationChain_main_Call_testP_p_LiteralInteger63 = new();
						public LiteralInteger Operation_RequiredInterface_DelegationChain_main_Call_testP_p_LiteralInteger64 = new();
				public ReadStructuralFeatureAction Operation_RequiredInterface_DelegationChain_main_Read_d_e = new();
					public OutputPin Operation_RequiredInterface_DelegationChain_main_Read_d_e_result = new();
						public LiteralUnlimitedNatural Operation_RequiredInterface_DelegationChain_main_Read_d_e_result_LiteralUnlimitedNatural65 = new();
						public LiteralInteger Operation_RequiredInterface_DelegationChain_main_Read_d_e_result_LiteralInteger66 = new();
					public InputPin Operation_RequiredInterface_DelegationChain_main_Read_d_e_object = new();
						public LiteralUnlimitedNatural Operation_RequiredInterface_DelegationChain_main_Read_d_e_object_LiteralUnlimitedNatural67 = new();
						public LiteralInteger Operation_RequiredInterface_DelegationChain_main_Read_d_e_object_LiteralInteger68 = new();
				public CallOperationAction Operation_RequiredInterface_DelegationChain_main_D_ = new();
					public OutputPin Operation_RequiredInterface_DelegationChain_main_D__result = new();
						public LiteralInteger Operation_RequiredInterface_DelegationChain_main_D__result_LiteralInteger69 = new();
						public LiteralUnlimitedNatural Operation_RequiredInterface_DelegationChain_main_D__result_LiteralUnlimitedNatural70 = new();
						public LiteralInteger Operation_RequiredInterface_DelegationChain_main_D__result_LiteralInteger71 = new();
					public InputPin Operation_RequiredInterface_DelegationChain_main_D__target = new();
						public LiteralInteger Operation_RequiredInterface_DelegationChain_main_D__target_LiteralInteger72 = new();
						public LiteralUnlimitedNatural Operation_RequiredInterface_DelegationChain_main_D__target_LiteralUnlimitedNatural73 = new();
				public ObjectFlow Operation_RequiredInterface_DelegationChain_main_ObjectFlow74 = new();
					public LiteralBoolean Operation_RequiredInterface_DelegationChain_main_ObjectFlow74_LiteralBoolean75 = new();
					public LiteralInteger Operation_RequiredInterface_DelegationChain_main_ObjectFlow74_LiteralInteger76 = new();
				public ObjectFlow Operation_RequiredInterface_DelegationChain_main_ObjectFlow77 = new();
					public LiteralBoolean Operation_RequiredInterface_DelegationChain_main_ObjectFlow77_LiteralBoolean78 = new();
					public LiteralInteger Operation_RequiredInterface_DelegationChain_main_ObjectFlow77_LiteralInteger79 = new();
				public ObjectFlow Operation_RequiredInterface_DelegationChain_main_ObjectFlow80 = new();
					public LiteralInteger Operation_RequiredInterface_DelegationChain_main_ObjectFlow80_LiteralInteger81 = new();
					public LiteralBoolean Operation_RequiredInterface_DelegationChain_main_ObjectFlow80_LiteralBoolean82 = new();
			public Interface Operation_RequiredInterface_DelegationChain_I = new();
				public Operation Operation_RequiredInterface_DelegationChain_I_setP_Integer = new();
					public Parameter Operation_RequiredInterface_DelegationChain_I_setP_Integer_v = new();
			public Class_ Operation_RequiredInterface_DelegationChain_D = new();
				public Operation Operation_RequiredInterface_DelegationChain_D_D_D = new();
					public Parameter Operation_RequiredInterface_DelegationChain_D_D_D_result = new();
				public Property Operation_RequiredInterface_DelegationChain_D_a = new();
				public Property Operation_RequiredInterface_DelegationChain_D_e = new();
				public Connector Operation_RequiredInterface_DelegationChain_D_s = new();
					public ConnectorEnd Operation_RequiredInterface_DelegationChain_D_s_ConnectorEnd83 = new();
					public ConnectorEnd Operation_RequiredInterface_DelegationChain_D_s_ConnectorEnd84 = new();
			public Association Operation_RequiredInterface_DelegationChain_R = new();
				public Property Operation_RequiredInterface_DelegationChain_R_x = new();
				public Property Operation_RequiredInterface_DelegationChain_R_y = new();
			public Class_ Operation_RequiredInterface_DelegationChain_A = new();
				public Property Operation_RequiredInterface_DelegationChain_A_b = new();
				public Port Operation_RequiredInterface_DelegationChain_A_q = new();
				public Operation Operation_RequiredInterface_DelegationChain_A_setP_Integer = new();
					public Parameter Operation_RequiredInterface_DelegationChain_A_setP_Integer_v = new();
				public Activity Operation_RequiredInterface_DelegationChain_A_setPActivity = new();
					public ActivityParameterNode Operation_RequiredInterface_DelegationChain_A_setPActivity_vParameterNode = new();
						public LiteralInteger Operation_RequiredInterface_DelegationChain_A_setPActivity_vParameterNode_LiteralInteger85 = new();
					public ReadSelfAction Operation_RequiredInterface_DelegationChain_A_setPActivity_this = new();
						public OutputPin Operation_RequiredInterface_DelegationChain_A_setPActivity_this_result = new();
							public LiteralUnlimitedNatural Operation_RequiredInterface_DelegationChain_A_setPActivity_this_result_LiteralUnlimitedNatural86 = new();
							public LiteralInteger Operation_RequiredInterface_DelegationChain_A_setPActivity_this_result_LiteralInteger87 = new();
					public ObjectFlow Operation_RequiredInterface_DelegationChain_A_setPActivity_ObjectFlow88 = new();
						public LiteralBoolean Operation_RequiredInterface_DelegationChain_A_setPActivity_ObjectFlow88_LiteralBoolean89 = new();
						public LiteralInteger Operation_RequiredInterface_DelegationChain_A_setPActivity_ObjectFlow88_LiteralInteger90 = new();
					public ObjectFlow Operation_RequiredInterface_DelegationChain_A_setPActivity_ObjectFlow91 = new();
						public LiteralInteger Operation_RequiredInterface_DelegationChain_A_setPActivity_ObjectFlow91_LiteralInteger92 = new();
						public LiteralBoolean Operation_RequiredInterface_DelegationChain_A_setPActivity_ObjectFlow91_LiteralBoolean93 = new();
					public Parameter Operation_RequiredInterface_DelegationChain_A_setPActivity_v = new();
					public CallOperationAction Operation_RequiredInterface_DelegationChain_A_setPActivity_Call_I_setP_on_q = new();
						public InputPin Operation_RequiredInterface_DelegationChain_A_setPActivity_Call_I_setP_on_q_v = new();
							public LiteralUnlimitedNatural Operation_RequiredInterface_DelegationChain_A_setPActivity_Call_I_setP_on_q_v_LiteralUnlimitedNatural94 = new();
							public LiteralInteger Operation_RequiredInterface_DelegationChain_A_setPActivity_Call_I_setP_on_q_v_LiteralInteger95 = new();
							public LiteralInteger Operation_RequiredInterface_DelegationChain_A_setPActivity_Call_I_setP_on_q_v_LiteralInteger96 = new();
						public InputPin Operation_RequiredInterface_DelegationChain_A_setPActivity_Call_I_setP_on_q_target = new();
							public LiteralInteger Operation_RequiredInterface_DelegationChain_A_setPActivity_Call_I_setP_on_q_target_LiteralInteger97 = new();
							public LiteralUnlimitedNatural Operation_RequiredInterface_DelegationChain_A_setPActivity_Call_I_setP_on_q_target_LiteralUnlimitedNatural98 = new();
				public Connector Operation_RequiredInterface_DelegationChain_A_r = new();
					public ConnectorEnd Operation_RequiredInterface_DelegationChain_A_r_ConnectorEnd99 = new();
					public ConnectorEnd Operation_RequiredInterface_DelegationChain_A_r_ConnectorEnd100 = new();
			public Class_ Operation_RequiredInterface_DelegationChain_E = new();
				public Property Operation_RequiredInterface_DelegationChain_E_c = new();
				public Connector Operation_RequiredInterface_DelegationChain_E_s = new();
					public ConnectorEnd Operation_RequiredInterface_DelegationChain_E_s_ConnectorEnd101 = new();
					public ConnectorEnd Operation_RequiredInterface_DelegationChain_E_s_ConnectorEnd102 = new();
				public Port Operation_RequiredInterface_DelegationChain_E_q = new();
			public Class_ Operation_RequiredInterface_DelegationChain_IImpl = new();
				public InterfaceRealization Operation_RequiredInterface_DelegationChain_IImpl_IRealization = new();
				public Operation Operation_RequiredInterface_DelegationChain_IImpl_setP_Integer = new();
					public Parameter Operation_RequiredInterface_DelegationChain_IImpl_setP_Integer_v = new();
			public Class_ Operation_RequiredInterface_DelegationChain_B = new();
				public Activity Operation_RequiredInterface_DelegationChain_B_setPActivity = new();
					public ObjectFlow Operation_RequiredInterface_DelegationChain_B_setPActivity_ObjectFlow103 = new();
						public LiteralInteger Operation_RequiredInterface_DelegationChain_B_setPActivity_ObjectFlow103_LiteralInteger104 = new();
						public LiteralBoolean Operation_RequiredInterface_DelegationChain_B_setPActivity_ObjectFlow103_LiteralBoolean105 = new();
					public ObjectFlow Operation_RequiredInterface_DelegationChain_B_setPActivity_ObjectFlow106 = new();
						public LiteralBoolean Operation_RequiredInterface_DelegationChain_B_setPActivity_ObjectFlow106_LiteralBoolean107 = new();
						public LiteralInteger Operation_RequiredInterface_DelegationChain_B_setPActivity_ObjectFlow106_LiteralInteger108 = new();
					public Parameter Operation_RequiredInterface_DelegationChain_B_setPActivity_v = new();
					public ActivityParameterNode Operation_RequiredInterface_DelegationChain_B_setPActivity_vParameterNode = new();
						public LiteralInteger Operation_RequiredInterface_DelegationChain_B_setPActivity_vParameterNode_LiteralInteger109 = new();
					public AddStructuralFeatureValueAction Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p = new();
						public InputPin Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p_value = new();
							public LiteralInteger Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p_value_LiteralInteger110 = new();
							public LiteralUnlimitedNatural Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p_value_LiteralUnlimitedNatural111 = new();
						public InputPin Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p_object = new();
							public LiteralInteger Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p_object_LiteralInteger112 = new();
							public LiteralUnlimitedNatural Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p_object_LiteralUnlimitedNatural113 = new();
						public OutputPin Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p_result = new();
							public LiteralInteger Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p_result_LiteralInteger114 = new();
							public LiteralUnlimitedNatural Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p_result_LiteralUnlimitedNatural115 = new();
					public ReadSelfAction Operation_RequiredInterface_DelegationChain_B_setPActivity_this = new();
						public OutputPin Operation_RequiredInterface_DelegationChain_B_setPActivity_this_result = new();
							public LiteralUnlimitedNatural Operation_RequiredInterface_DelegationChain_B_setPActivity_this_result_LiteralUnlimitedNatural116 = new();
							public LiteralInteger Operation_RequiredInterface_DelegationChain_B_setPActivity_this_result_LiteralInteger117 = new();
				public Property Operation_RequiredInterface_DelegationChain_B_p = new();
				public InterfaceRealization Operation_RequiredInterface_DelegationChain_B_IRealization = new();
				public Operation Operation_RequiredInterface_DelegationChain_B_setP_Integer = new();
					public Parameter Operation_RequiredInterface_DelegationChain_B_setP_Integer_v = new();

		public static Operation_RequiredInterface_DelegationChainModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public Operation_RequiredInterface_DelegationChainModel()
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
			 * Model Operation_RequiredInterface_DelegationChain
			 */
			AddToElementRepository("Operation_RequiredInterface_DelegationChain", Operation_RequiredInterface_DelegationChain);
				AddToElementRepository("C", Operation_RequiredInterface_DelegationChain_C);
					AddToElementRepository("setP_Integer", Operation_RequiredInterface_DelegationChain_C_setP_Integer);
						AddToElementRepository("v", Operation_RequiredInterface_DelegationChain_C_setP_Integer_v);
					AddToElementRepository("q", Operation_RequiredInterface_DelegationChain_C_q);
					AddToElementRepository("IRealization", Operation_RequiredInterface_DelegationChain_C_IRealization);
					AddToElementRepository("setPActivity", Operation_RequiredInterface_DelegationChain_C_setPActivity);
						AddToElementRepository("ObjectFlow0", Operation_RequiredInterface_DelegationChain_C_setPActivity_ObjectFlow0);
							AddToElementRepository("LiteralBoolean1", Operation_RequiredInterface_DelegationChain_C_setPActivity_ObjectFlow0_LiteralBoolean1);
							AddToElementRepository("LiteralInteger2", Operation_RequiredInterface_DelegationChain_C_setPActivity_ObjectFlow0_LiteralInteger2);
						AddToElementRepository("vParameterNode", Operation_RequiredInterface_DelegationChain_C_setPActivity_vParameterNode);
							AddToElementRepository("LiteralInteger3", Operation_RequiredInterface_DelegationChain_C_setPActivity_vParameterNode_LiteralInteger3);
						AddToElementRepository("ObjectFlow4", Operation_RequiredInterface_DelegationChain_C_setPActivity_ObjectFlow4);
							AddToElementRepository("LiteralInteger5", Operation_RequiredInterface_DelegationChain_C_setPActivity_ObjectFlow4_LiteralInteger5);
							AddToElementRepository("LiteralBoolean6", Operation_RequiredInterface_DelegationChain_C_setPActivity_ObjectFlow4_LiteralBoolean6);
						AddToElementRepository("this", Operation_RequiredInterface_DelegationChain_C_setPActivity_this);
							AddToElementRepository("result", Operation_RequiredInterface_DelegationChain_C_setPActivity_this_result);
								AddToElementRepository("LiteralInteger7", Operation_RequiredInterface_DelegationChain_C_setPActivity_this_result_LiteralInteger7);
								AddToElementRepository("LiteralUnlimitedNatural8", Operation_RequiredInterface_DelegationChain_C_setPActivity_this_result_LiteralUnlimitedNatural8);
						AddToElementRepository("v", Operation_RequiredInterface_DelegationChain_C_setPActivity_v);
						AddToElementRepository("Call I::setP on q", Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q);
							AddToElementRepository("target", Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q_target);
								AddToElementRepository("LiteralInteger9", Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q_target_LiteralInteger9);
								AddToElementRepository("LiteralUnlimitedNatural10", Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q_target_LiteralUnlimitedNatural10);
							AddToElementRepository("v", Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q_v);
								AddToElementRepository("LiteralInteger11", Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q_v_LiteralInteger11);
								AddToElementRepository("LiteralInteger12", Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q_v_LiteralInteger12);
								AddToElementRepository("LiteralUnlimitedNatural13", Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q_v_LiteralUnlimitedNatural13);
				AddToElementRepository("S", Operation_RequiredInterface_DelegationChain_S);
					AddToElementRepository("y", Operation_RequiredInterface_DelegationChain_S_y);
					AddToElementRepository("x", Operation_RequiredInterface_DelegationChain_S_x);
				AddToElementRepository("main", Operation_RequiredInterface_DelegationChain_main);
					AddToElementRepository("ControlFlow14", Operation_RequiredInterface_DelegationChain_main_ControlFlow14);
					AddToElementRepository("Value(4)", Operation_RequiredInterface_DelegationChain_main_Value_4);
						AddToElementRepository("result", Operation_RequiredInterface_DelegationChain_main_Value_4_result);
							AddToElementRepository("LiteralUnlimitedNatural15", Operation_RequiredInterface_DelegationChain_main_Value_4_result_LiteralUnlimitedNatural15);
							AddToElementRepository("LiteralInteger16", Operation_RequiredInterface_DelegationChain_main_Value_4_result_LiteralInteger16);
						AddToElementRepository("LiteralInteger17", Operation_RequiredInterface_DelegationChain_main_Value_4_LiteralInteger17);
					AddToElementRepository("Read a.b", Operation_RequiredInterface_DelegationChain_main_Read_a_b);
						AddToElementRepository("object", Operation_RequiredInterface_DelegationChain_main_Read_a_b_object);
							AddToElementRepository("LiteralInteger18", Operation_RequiredInterface_DelegationChain_main_Read_a_b_object_LiteralInteger18);
							AddToElementRepository("LiteralUnlimitedNatural19", Operation_RequiredInterface_DelegationChain_main_Read_a_b_object_LiteralUnlimitedNatural19);
						AddToElementRepository("result", Operation_RequiredInterface_DelegationChain_main_Read_a_b_result);
							AddToElementRepository("LiteralInteger20", Operation_RequiredInterface_DelegationChain_main_Read_a_b_result_LiteralInteger20);
							AddToElementRepository("LiteralUnlimitedNatural21", Operation_RequiredInterface_DelegationChain_main_Read_a_b_result_LiteralUnlimitedNatural21);
					AddToElementRepository("ObjectFlow22", Operation_RequiredInterface_DelegationChain_main_ObjectFlow22);
						AddToElementRepository("LiteralInteger23", Operation_RequiredInterface_DelegationChain_main_ObjectFlow22_LiteralInteger23);
						AddToElementRepository("LiteralBoolean24", Operation_RequiredInterface_DelegationChain_main_ObjectFlow22_LiteralBoolean24);
					AddToElementRepository("Create D", Operation_RequiredInterface_DelegationChain_main_Create_D);
						AddToElementRepository("result", Operation_RequiredInterface_DelegationChain_main_Create_D_result);
							AddToElementRepository("LiteralInteger25", Operation_RequiredInterface_DelegationChain_main_Create_D_result_LiteralInteger25);
							AddToElementRepository("LiteralUnlimitedNatural26", Operation_RequiredInterface_DelegationChain_main_Create_D_result_LiteralUnlimitedNatural26);
					AddToElementRepository("Fork d", Operation_RequiredInterface_DelegationChain_main_Fork_d);
					AddToElementRepository("ObjectFlow27", Operation_RequiredInterface_DelegationChain_main_ObjectFlow27);
						AddToElementRepository("LiteralBoolean28", Operation_RequiredInterface_DelegationChain_main_ObjectFlow27_LiteralBoolean28);
						AddToElementRepository("LiteralInteger29", Operation_RequiredInterface_DelegationChain_main_ObjectFlow27_LiteralInteger29);
					AddToElementRepository("ObjectFlow30", Operation_RequiredInterface_DelegationChain_main_ObjectFlow30);
						AddToElementRepository("LiteralInteger31", Operation_RequiredInterface_DelegationChain_main_ObjectFlow30_LiteralInteger31);
						AddToElementRepository("LiteralBoolean32", Operation_RequiredInterface_DelegationChain_main_ObjectFlow30_LiteralBoolean32);
					AddToElementRepository("Read b.p", Operation_RequiredInterface_DelegationChain_main_Read_b_p);
						AddToElementRepository("result", Operation_RequiredInterface_DelegationChain_main_Read_b_p_result);
							AddToElementRepository("LiteralInteger33", Operation_RequiredInterface_DelegationChain_main_Read_b_p_result_LiteralInteger33);
							AddToElementRepository("LiteralUnlimitedNatural34", Operation_RequiredInterface_DelegationChain_main_Read_b_p_result_LiteralUnlimitedNatural34);
						AddToElementRepository("object", Operation_RequiredInterface_DelegationChain_main_Read_b_p_object);
							AddToElementRepository("LiteralUnlimitedNatural35", Operation_RequiredInterface_DelegationChain_main_Read_b_p_object_LiteralUnlimitedNatural35);
							AddToElementRepository("LiteralInteger36", Operation_RequiredInterface_DelegationChain_main_Read_b_p_object_LiteralInteger36);
					AddToElementRepository("Read d.a", Operation_RequiredInterface_DelegationChain_main_Read_d_a);
						AddToElementRepository("result", Operation_RequiredInterface_DelegationChain_main_Read_d_a_result);
							AddToElementRepository("LiteralInteger37", Operation_RequiredInterface_DelegationChain_main_Read_d_a_result_LiteralInteger37);
							AddToElementRepository("LiteralUnlimitedNatural38", Operation_RequiredInterface_DelegationChain_main_Read_d_a_result_LiteralUnlimitedNatural38);
						AddToElementRepository("object", Operation_RequiredInterface_DelegationChain_main_Read_d_a_object);
							AddToElementRepository("LiteralInteger39", Operation_RequiredInterface_DelegationChain_main_Read_d_a_object_LiteralInteger39);
							AddToElementRepository("LiteralUnlimitedNatural40", Operation_RequiredInterface_DelegationChain_main_Read_d_a_object_LiteralUnlimitedNatural40);
					AddToElementRepository("ObjectFlow41", Operation_RequiredInterface_DelegationChain_main_ObjectFlow41);
						AddToElementRepository("LiteralBoolean42", Operation_RequiredInterface_DelegationChain_main_ObjectFlow41_LiteralBoolean42);
						AddToElementRepository("LiteralInteger43", Operation_RequiredInterface_DelegationChain_main_ObjectFlow41_LiteralInteger43);
					AddToElementRepository("Read e.c", Operation_RequiredInterface_DelegationChain_main_Read_e_c);
						AddToElementRepository("result", Operation_RequiredInterface_DelegationChain_main_Read_e_c_result);
							AddToElementRepository("LiteralUnlimitedNatural44", Operation_RequiredInterface_DelegationChain_main_Read_e_c_result_LiteralUnlimitedNatural44);
							AddToElementRepository("LiteralInteger45", Operation_RequiredInterface_DelegationChain_main_Read_e_c_result_LiteralInteger45);
						AddToElementRepository("object", Operation_RequiredInterface_DelegationChain_main_Read_e_c_object);
							AddToElementRepository("LiteralUnlimitedNatural46", Operation_RequiredInterface_DelegationChain_main_Read_e_c_object_LiteralUnlimitedNatural46);
							AddToElementRepository("LiteralInteger47", Operation_RequiredInterface_DelegationChain_main_Read_e_c_object_LiteralInteger47);
					AddToElementRepository("ObjectFlow48", Operation_RequiredInterface_DelegationChain_main_ObjectFlow48);
						AddToElementRepository("LiteralInteger49", Operation_RequiredInterface_DelegationChain_main_ObjectFlow48_LiteralInteger49);
						AddToElementRepository("LiteralBoolean50", Operation_RequiredInterface_DelegationChain_main_ObjectFlow48_LiteralBoolean50);
					AddToElementRepository("ObjectFlow51", Operation_RequiredInterface_DelegationChain_main_ObjectFlow51);
						AddToElementRepository("LiteralInteger52", Operation_RequiredInterface_DelegationChain_main_ObjectFlow51_LiteralInteger52);
						AddToElementRepository("LiteralBoolean53", Operation_RequiredInterface_DelegationChain_main_ObjectFlow51_LiteralBoolean53);
					AddToElementRepository("ObjectFlow54", Operation_RequiredInterface_DelegationChain_main_ObjectFlow54);
						AddToElementRepository("LiteralBoolean55", Operation_RequiredInterface_DelegationChain_main_ObjectFlow54_LiteralBoolean55);
						AddToElementRepository("LiteralInteger56", Operation_RequiredInterface_DelegationChain_main_ObjectFlow54_LiteralInteger56);
					AddToElementRepository("testP", Operation_RequiredInterface_DelegationChain_main_testP);
						AddToElementRepository("p", Operation_RequiredInterface_DelegationChain_main_testP_p);
					AddToElementRepository("Call setP()", Operation_RequiredInterface_DelegationChain_main_Call_setP_);
						AddToElementRepository("v", Operation_RequiredInterface_DelegationChain_main_Call_setP__v);
							AddToElementRepository("LiteralUnlimitedNatural57", Operation_RequiredInterface_DelegationChain_main_Call_setP__v_LiteralUnlimitedNatural57);
							AddToElementRepository("LiteralInteger58", Operation_RequiredInterface_DelegationChain_main_Call_setP__v_LiteralInteger58);
							AddToElementRepository("LiteralInteger59", Operation_RequiredInterface_DelegationChain_main_Call_setP__v_LiteralInteger59);
						AddToElementRepository("target", Operation_RequiredInterface_DelegationChain_main_Call_setP__target);
							AddToElementRepository("LiteralInteger60", Operation_RequiredInterface_DelegationChain_main_Call_setP__target_LiteralInteger60);
							AddToElementRepository("LiteralUnlimitedNatural61", Operation_RequiredInterface_DelegationChain_main_Call_setP__target_LiteralUnlimitedNatural61);
					AddToElementRepository("Call testP", Operation_RequiredInterface_DelegationChain_main_Call_testP);
						AddToElementRepository("p", Operation_RequiredInterface_DelegationChain_main_Call_testP_p);
							AddToElementRepository("LiteralUnlimitedNatural62", Operation_RequiredInterface_DelegationChain_main_Call_testP_p_LiteralUnlimitedNatural62);
							AddToElementRepository("LiteralInteger63", Operation_RequiredInterface_DelegationChain_main_Call_testP_p_LiteralInteger63);
							AddToElementRepository("LiteralInteger64", Operation_RequiredInterface_DelegationChain_main_Call_testP_p_LiteralInteger64);
					AddToElementRepository("Read d.e", Operation_RequiredInterface_DelegationChain_main_Read_d_e);
						AddToElementRepository("result", Operation_RequiredInterface_DelegationChain_main_Read_d_e_result);
							AddToElementRepository("LiteralUnlimitedNatural65", Operation_RequiredInterface_DelegationChain_main_Read_d_e_result_LiteralUnlimitedNatural65);
							AddToElementRepository("LiteralInteger66", Operation_RequiredInterface_DelegationChain_main_Read_d_e_result_LiteralInteger66);
						AddToElementRepository("object", Operation_RequiredInterface_DelegationChain_main_Read_d_e_object);
							AddToElementRepository("LiteralUnlimitedNatural67", Operation_RequiredInterface_DelegationChain_main_Read_d_e_object_LiteralUnlimitedNatural67);
							AddToElementRepository("LiteralInteger68", Operation_RequiredInterface_DelegationChain_main_Read_d_e_object_LiteralInteger68);
					AddToElementRepository("D()", Operation_RequiredInterface_DelegationChain_main_D_);
						AddToElementRepository("result", Operation_RequiredInterface_DelegationChain_main_D__result);
							AddToElementRepository("LiteralInteger69", Operation_RequiredInterface_DelegationChain_main_D__result_LiteralInteger69);
							AddToElementRepository("LiteralUnlimitedNatural70", Operation_RequiredInterface_DelegationChain_main_D__result_LiteralUnlimitedNatural70);
							AddToElementRepository("LiteralInteger71", Operation_RequiredInterface_DelegationChain_main_D__result_LiteralInteger71);
						AddToElementRepository("target", Operation_RequiredInterface_DelegationChain_main_D__target);
							AddToElementRepository("LiteralInteger72", Operation_RequiredInterface_DelegationChain_main_D__target_LiteralInteger72);
							AddToElementRepository("LiteralUnlimitedNatural73", Operation_RequiredInterface_DelegationChain_main_D__target_LiteralUnlimitedNatural73);
					AddToElementRepository("ObjectFlow74", Operation_RequiredInterface_DelegationChain_main_ObjectFlow74);
						AddToElementRepository("LiteralBoolean75", Operation_RequiredInterface_DelegationChain_main_ObjectFlow74_LiteralBoolean75);
						AddToElementRepository("LiteralInteger76", Operation_RequiredInterface_DelegationChain_main_ObjectFlow74_LiteralInteger76);
					AddToElementRepository("ObjectFlow77", Operation_RequiredInterface_DelegationChain_main_ObjectFlow77);
						AddToElementRepository("LiteralBoolean78", Operation_RequiredInterface_DelegationChain_main_ObjectFlow77_LiteralBoolean78);
						AddToElementRepository("LiteralInteger79", Operation_RequiredInterface_DelegationChain_main_ObjectFlow77_LiteralInteger79);
					AddToElementRepository("ObjectFlow80", Operation_RequiredInterface_DelegationChain_main_ObjectFlow80);
						AddToElementRepository("LiteralInteger81", Operation_RequiredInterface_DelegationChain_main_ObjectFlow80_LiteralInteger81);
						AddToElementRepository("LiteralBoolean82", Operation_RequiredInterface_DelegationChain_main_ObjectFlow80_LiteralBoolean82);
				AddToElementRepository("I", Operation_RequiredInterface_DelegationChain_I);
					AddToElementRepository("setP_Integer", Operation_RequiredInterface_DelegationChain_I_setP_Integer);
						AddToElementRepository("v", Operation_RequiredInterface_DelegationChain_I_setP_Integer_v);
				AddToElementRepository("D", Operation_RequiredInterface_DelegationChain_D);
					AddToElementRepository("D_D", Operation_RequiredInterface_DelegationChain_D_D_D);
						AddToElementRepository("result", Operation_RequiredInterface_DelegationChain_D_D_D_result);
					AddToElementRepository("a", Operation_RequiredInterface_DelegationChain_D_a);
					AddToElementRepository("e", Operation_RequiredInterface_DelegationChain_D_e);
					AddToElementRepository("s", Operation_RequiredInterface_DelegationChain_D_s);
						AddToElementRepository("ConnectorEnd83", Operation_RequiredInterface_DelegationChain_D_s_ConnectorEnd83);
						AddToElementRepository("ConnectorEnd84", Operation_RequiredInterface_DelegationChain_D_s_ConnectorEnd84);
				AddToElementRepository("R", Operation_RequiredInterface_DelegationChain_R);
					AddToElementRepository("x", Operation_RequiredInterface_DelegationChain_R_x);
					AddToElementRepository("y", Operation_RequiredInterface_DelegationChain_R_y);
				AddToElementRepository("A", Operation_RequiredInterface_DelegationChain_A);
					AddToElementRepository("b", Operation_RequiredInterface_DelegationChain_A_b);
					AddToElementRepository("q", Operation_RequiredInterface_DelegationChain_A_q);
					AddToElementRepository("setP_Integer", Operation_RequiredInterface_DelegationChain_A_setP_Integer);
						AddToElementRepository("v", Operation_RequiredInterface_DelegationChain_A_setP_Integer_v);
					AddToElementRepository("setPActivity", Operation_RequiredInterface_DelegationChain_A_setPActivity);
						AddToElementRepository("vParameterNode", Operation_RequiredInterface_DelegationChain_A_setPActivity_vParameterNode);
							AddToElementRepository("LiteralInteger85", Operation_RequiredInterface_DelegationChain_A_setPActivity_vParameterNode_LiteralInteger85);
						AddToElementRepository("this", Operation_RequiredInterface_DelegationChain_A_setPActivity_this);
							AddToElementRepository("result", Operation_RequiredInterface_DelegationChain_A_setPActivity_this_result);
								AddToElementRepository("LiteralUnlimitedNatural86", Operation_RequiredInterface_DelegationChain_A_setPActivity_this_result_LiteralUnlimitedNatural86);
								AddToElementRepository("LiteralInteger87", Operation_RequiredInterface_DelegationChain_A_setPActivity_this_result_LiteralInteger87);
						AddToElementRepository("ObjectFlow88", Operation_RequiredInterface_DelegationChain_A_setPActivity_ObjectFlow88);
							AddToElementRepository("LiteralBoolean89", Operation_RequiredInterface_DelegationChain_A_setPActivity_ObjectFlow88_LiteralBoolean89);
							AddToElementRepository("LiteralInteger90", Operation_RequiredInterface_DelegationChain_A_setPActivity_ObjectFlow88_LiteralInteger90);
						AddToElementRepository("ObjectFlow91", Operation_RequiredInterface_DelegationChain_A_setPActivity_ObjectFlow91);
							AddToElementRepository("LiteralInteger92", Operation_RequiredInterface_DelegationChain_A_setPActivity_ObjectFlow91_LiteralInteger92);
							AddToElementRepository("LiteralBoolean93", Operation_RequiredInterface_DelegationChain_A_setPActivity_ObjectFlow91_LiteralBoolean93);
						AddToElementRepository("v", Operation_RequiredInterface_DelegationChain_A_setPActivity_v);
						AddToElementRepository("Call I::setP on q", Operation_RequiredInterface_DelegationChain_A_setPActivity_Call_I_setP_on_q);
							AddToElementRepository("v", Operation_RequiredInterface_DelegationChain_A_setPActivity_Call_I_setP_on_q_v);
								AddToElementRepository("LiteralUnlimitedNatural94", Operation_RequiredInterface_DelegationChain_A_setPActivity_Call_I_setP_on_q_v_LiteralUnlimitedNatural94);
								AddToElementRepository("LiteralInteger95", Operation_RequiredInterface_DelegationChain_A_setPActivity_Call_I_setP_on_q_v_LiteralInteger95);
								AddToElementRepository("LiteralInteger96", Operation_RequiredInterface_DelegationChain_A_setPActivity_Call_I_setP_on_q_v_LiteralInteger96);
							AddToElementRepository("target", Operation_RequiredInterface_DelegationChain_A_setPActivity_Call_I_setP_on_q_target);
								AddToElementRepository("LiteralInteger97", Operation_RequiredInterface_DelegationChain_A_setPActivity_Call_I_setP_on_q_target_LiteralInteger97);
								AddToElementRepository("LiteralUnlimitedNatural98", Operation_RequiredInterface_DelegationChain_A_setPActivity_Call_I_setP_on_q_target_LiteralUnlimitedNatural98);
					AddToElementRepository("r", Operation_RequiredInterface_DelegationChain_A_r);
						AddToElementRepository("ConnectorEnd99", Operation_RequiredInterface_DelegationChain_A_r_ConnectorEnd99);
						AddToElementRepository("ConnectorEnd100", Operation_RequiredInterface_DelegationChain_A_r_ConnectorEnd100);
				AddToElementRepository("E", Operation_RequiredInterface_DelegationChain_E);
					AddToElementRepository("c", Operation_RequiredInterface_DelegationChain_E_c);
					AddToElementRepository("s", Operation_RequiredInterface_DelegationChain_E_s);
						AddToElementRepository("ConnectorEnd101", Operation_RequiredInterface_DelegationChain_E_s_ConnectorEnd101);
						AddToElementRepository("ConnectorEnd102", Operation_RequiredInterface_DelegationChain_E_s_ConnectorEnd102);
					AddToElementRepository("q", Operation_RequiredInterface_DelegationChain_E_q);
				AddToElementRepository("IImpl", Operation_RequiredInterface_DelegationChain_IImpl);
					AddToElementRepository("IRealization", Operation_RequiredInterface_DelegationChain_IImpl_IRealization);
					AddToElementRepository("setP_Integer", Operation_RequiredInterface_DelegationChain_IImpl_setP_Integer);
						AddToElementRepository("v", Operation_RequiredInterface_DelegationChain_IImpl_setP_Integer_v);
				AddToElementRepository("B", Operation_RequiredInterface_DelegationChain_B);
					AddToElementRepository("setPActivity", Operation_RequiredInterface_DelegationChain_B_setPActivity);
						AddToElementRepository("ObjectFlow103", Operation_RequiredInterface_DelegationChain_B_setPActivity_ObjectFlow103);
							AddToElementRepository("LiteralInteger104", Operation_RequiredInterface_DelegationChain_B_setPActivity_ObjectFlow103_LiteralInteger104);
							AddToElementRepository("LiteralBoolean105", Operation_RequiredInterface_DelegationChain_B_setPActivity_ObjectFlow103_LiteralBoolean105);
						AddToElementRepository("ObjectFlow106", Operation_RequiredInterface_DelegationChain_B_setPActivity_ObjectFlow106);
							AddToElementRepository("LiteralBoolean107", Operation_RequiredInterface_DelegationChain_B_setPActivity_ObjectFlow106_LiteralBoolean107);
							AddToElementRepository("LiteralInteger108", Operation_RequiredInterface_DelegationChain_B_setPActivity_ObjectFlow106_LiteralInteger108);
						AddToElementRepository("v", Operation_RequiredInterface_DelegationChain_B_setPActivity_v);
						AddToElementRepository("vParameterNode", Operation_RequiredInterface_DelegationChain_B_setPActivity_vParameterNode);
							AddToElementRepository("LiteralInteger109", Operation_RequiredInterface_DelegationChain_B_setPActivity_vParameterNode_LiteralInteger109);
						AddToElementRepository("Set this.p", Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p);
							AddToElementRepository("value", Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p_value);
								AddToElementRepository("LiteralInteger110", Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p_value_LiteralInteger110);
								AddToElementRepository("LiteralUnlimitedNatural111", Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p_value_LiteralUnlimitedNatural111);
							AddToElementRepository("object", Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p_object);
								AddToElementRepository("LiteralInteger112", Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p_object_LiteralInteger112);
								AddToElementRepository("LiteralUnlimitedNatural113", Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p_object_LiteralUnlimitedNatural113);
							AddToElementRepository("result", Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p_result);
								AddToElementRepository("LiteralInteger114", Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p_result_LiteralInteger114);
								AddToElementRepository("LiteralUnlimitedNatural115", Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p_result_LiteralUnlimitedNatural115);
						AddToElementRepository("this", Operation_RequiredInterface_DelegationChain_B_setPActivity_this);
							AddToElementRepository("result", Operation_RequiredInterface_DelegationChain_B_setPActivity_this_result);
								AddToElementRepository("LiteralUnlimitedNatural116", Operation_RequiredInterface_DelegationChain_B_setPActivity_this_result_LiteralUnlimitedNatural116);
								AddToElementRepository("LiteralInteger117", Operation_RequiredInterface_DelegationChain_B_setPActivity_this_result_LiteralInteger117);
					AddToElementRepository("p", Operation_RequiredInterface_DelegationChain_B_p);
					AddToElementRepository("IRealization", Operation_RequiredInterface_DelegationChain_B_IRealization);
					AddToElementRepository("setP_Integer", Operation_RequiredInterface_DelegationChain_B_setP_Integer);
						AddToElementRepository("v", Operation_RequiredInterface_DelegationChain_B_setP_Integer_v);

			// Initialize public members
			/*
			 * Model Operation_RequiredInterface_DelegationChain
			 */
			Operation_RequiredInterface_DelegationChain.SetName("Operation_RequiredInterface_DelegationChain");
			Operation_RequiredInterface_DelegationChain.SetVisibility(VisibilityKind.public_);
				// Class C
				Operation_RequiredInterface_DelegationChain_C.SetName("C");
				Operation_RequiredInterface_DelegationChain_C.SetVisibility(VisibilityKind.public_);
				
					// Port q
					Operation_RequiredInterface_DelegationChain_C_q.SetName("q");
					Operation_RequiredInterface_DelegationChain_C_q.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_DelegationChain_C_q.SetType(Operation_RequiredInterface_DelegationChain_IImpl);
					Operation_RequiredInterface_DelegationChain_C_q.SetAggregation(AggregationKind.composite);
					Operation_RequiredInterface_DelegationChain_C_q.isConjugated = true;;
					Operation_RequiredInterface_DelegationChain_C_q.isService = true;
					Operation_RequiredInterface_DelegationChain_C_q.AddRequired(Operation_RequiredInterface_DelegationChain_I);
				Operation_RequiredInterface_DelegationChain_C.AddOwnedAttribute(Operation_RequiredInterface_DelegationChain_C_q);
				// Activity setPActivity
					Operation_RequiredInterface_DelegationChain_C_setPActivity.SetName("setPActivity");
					Operation_RequiredInterface_DelegationChain_C_setPActivity.SetVisibility(VisibilityKind.public_);
					
						// Parameter v
						Operation_RequiredInterface_DelegationChain_C_setPActivity_v.SetName("v");
						Operation_RequiredInterface_DelegationChain_C_setPActivity_v.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_DelegationChain_C_setPActivity_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_RequiredInterface_DelegationChain_C_setPActivity.AddOwnedParameter(Operation_RequiredInterface_DelegationChain_C_setPActivity_v);
						// ActivityParameterNode vParameterNode
						Operation_RequiredInterface_DelegationChain_C_setPActivity_vParameterNode.SetName("vParameterNode");
						Operation_RequiredInterface_DelegationChain_C_setPActivity_vParameterNode.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_DelegationChain_C_setPActivity_vParameterNode.SetParameter(Operation_RequiredInterface_DelegationChain_C_setPActivity_v);
					Operation_RequiredInterface_DelegationChain_C_setPActivity.AddNode(Operation_RequiredInterface_DelegationChain_C_setPActivity_vParameterNode);
						// ReadSelfAction this
						Operation_RequiredInterface_DelegationChain_C_setPActivity_this.SetName("this");
						Operation_RequiredInterface_DelegationChain_C_setPActivity_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							Operation_RequiredInterface_DelegationChain_C_setPActivity_this_result.SetName("result");
							Operation_RequiredInterface_DelegationChain_C_setPActivity_this_result.SetVisibility(VisibilityKind.public_);
							Operation_RequiredInterface_DelegationChain_C_setPActivity_this_result.SetType(Operation_RequiredInterface_DelegationChain_C);
						Operation_RequiredInterface_DelegationChain_C_setPActivity_this.SetResult(Operation_RequiredInterface_DelegationChain_C_setPActivity_this_result);
					Operation_RequiredInterface_DelegationChain_C_setPActivity.AddNode(Operation_RequiredInterface_DelegationChain_C_setPActivity_this);
						// CallOperationAction Call I::setP on q
						Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q.SetName("Call I::setP on q");
						Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q.SetOnPort(Operation_RequiredInterface_DelegationChain_C_q);
						Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q.SetOperation(Operation_RequiredInterface_DelegationChain_I_setP_Integer);
							// InputPin target
							Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q_target.SetName("target");
							Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q_target.SetVisibility(VisibilityKind.public_);
							Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q_target.SetType(Operation_RequiredInterface_DelegationChain_C);
						Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q.SetTarget(Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q_target);
							// InputPin v
							Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q_v.SetName("v");
							Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q_v.SetVisibility(VisibilityKind.public_);
							Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q.AddArgument(Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q_v);
					Operation_RequiredInterface_DelegationChain_C_setPActivity.AddNode(Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q);
						// ObjectFlow ObjectFlow0 from result to target
						Operation_RequiredInterface_DelegationChain_C_setPActivity_ObjectFlow0.SetName("ObjectFlow0");
						Operation_RequiredInterface_DelegationChain_C_setPActivity_ObjectFlow0.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_DelegationChain_C_setPActivity_ObjectFlow0.SetSource(Operation_RequiredInterface_DelegationChain_C_setPActivity_this_result);
						Operation_RequiredInterface_DelegationChain_C_setPActivity_ObjectFlow0.SetTarget(Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q_target);
							// LiteralBoolean LiteralBoolean1
							Operation_RequiredInterface_DelegationChain_C_setPActivity_ObjectFlow0_LiteralBoolean1.SetName("LiteralBoolean1");
							Operation_RequiredInterface_DelegationChain_C_setPActivity_ObjectFlow0_LiteralBoolean1.SetVisibility(VisibilityKind.public_);
							Operation_RequiredInterface_DelegationChain_C_setPActivity_ObjectFlow0_LiteralBoolean1.SetValue(true);
						Operation_RequiredInterface_DelegationChain_C_setPActivity_ObjectFlow0.SetGuard(Operation_RequiredInterface_DelegationChain_C_setPActivity_ObjectFlow0_LiteralBoolean1);
					Operation_RequiredInterface_DelegationChain_C_setPActivity.AddEdge(Operation_RequiredInterface_DelegationChain_C_setPActivity_ObjectFlow0);
						// ObjectFlow ObjectFlow4 from vParameterNode to v
						Operation_RequiredInterface_DelegationChain_C_setPActivity_ObjectFlow4.SetName("ObjectFlow4");
						Operation_RequiredInterface_DelegationChain_C_setPActivity_ObjectFlow4.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_DelegationChain_C_setPActivity_ObjectFlow4.SetSource(Operation_RequiredInterface_DelegationChain_C_setPActivity_vParameterNode);
						Operation_RequiredInterface_DelegationChain_C_setPActivity_ObjectFlow4.SetTarget(Operation_RequiredInterface_DelegationChain_C_setPActivity_Call_I_setP_on_q_v);
							// LiteralBoolean LiteralBoolean6
							Operation_RequiredInterface_DelegationChain_C_setPActivity_ObjectFlow4_LiteralBoolean6.SetName("LiteralBoolean6");
							Operation_RequiredInterface_DelegationChain_C_setPActivity_ObjectFlow4_LiteralBoolean6.SetVisibility(VisibilityKind.public_);
							Operation_RequiredInterface_DelegationChain_C_setPActivity_ObjectFlow4_LiteralBoolean6.SetValue(true);
						Operation_RequiredInterface_DelegationChain_C_setPActivity_ObjectFlow4.SetGuard(Operation_RequiredInterface_DelegationChain_C_setPActivity_ObjectFlow4_LiteralBoolean6);
					Operation_RequiredInterface_DelegationChain_C_setPActivity.AddEdge(Operation_RequiredInterface_DelegationChain_C_setPActivity_ObjectFlow4);
				Operation_RequiredInterface_DelegationChain_C.AddOwnedBehavior(Operation_RequiredInterface_DelegationChain_C_setPActivity);
					Operation_RequiredInterface_DelegationChain_C_IRealization.SetName("IRealization");
					Operation_RequiredInterface_DelegationChain_C_IRealization.SetVisibility(VisibilityKind.public_);
					Operation_RequiredInterface_DelegationChain_C_IRealization.SetContract(Operation_RequiredInterface_DelegationChain_I);
					
				Operation_RequiredInterface_DelegationChain_C.AddInterfaceRealization(Operation_RequiredInterface_DelegationChain_C_IRealization);
				
					// Operation setP_Integer
					Operation_RequiredInterface_DelegationChain_C_setP_Integer.SetName("setP_Integer");
					Operation_RequiredInterface_DelegationChain_C_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						Operation_RequiredInterface_DelegationChain_C_setP_Integer_v.SetName("v");
						Operation_RequiredInterface_DelegationChain_C_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_DelegationChain_C_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_RequiredInterface_DelegationChain_C_setP_Integer.AddOwnedParameter(Operation_RequiredInterface_DelegationChain_C_setP_Integer_v);
					Operation_RequiredInterface_DelegationChain_C_setP_Integer.AddMethod(Operation_RequiredInterface_DelegationChain_C_setPActivity);
				Operation_RequiredInterface_DelegationChain_C.AddOwnedOperation(Operation_RequiredInterface_DelegationChain_C_setP_Integer);
			Operation_RequiredInterface_DelegationChain.AddPackagedElement(Operation_RequiredInterface_DelegationChain_C);
				// Association S
				Operation_RequiredInterface_DelegationChain_S.SetName("S");
				Operation_RequiredInterface_DelegationChain_S.SetVisibility(VisibilityKind.public_);
				Operation_RequiredInterface_DelegationChain_S.AddOwnedEnd(Operation_RequiredInterface_DelegationChain_S_x);
				Operation_RequiredInterface_DelegationChain_S.AddOwnedEnd(Operation_RequiredInterface_DelegationChain_S_y);
			Operation_RequiredInterface_DelegationChain.AddPackagedElement(Operation_RequiredInterface_DelegationChain_S);
				// Activity main
				Operation_RequiredInterface_DelegationChain_main.SetName("main");
				Operation_RequiredInterface_DelegationChain_main.SetVisibility(VisibilityKind.public_);
				// FunctionBehavior testP
					Operation_RequiredInterface_DelegationChain_main_testP.SetName("testP");
					Operation_RequiredInterface_DelegationChain_main_testP.SetVisibility(VisibilityKind.public_);
					
						// Parameter p
						Operation_RequiredInterface_DelegationChain_main_testP_p.SetName("p");
						Operation_RequiredInterface_DelegationChain_main_testP_p.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_DelegationChain_main_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_RequiredInterface_DelegationChain_main_testP.AddOwnedParameter(Operation_RequiredInterface_DelegationChain_main_testP_p);
					Operation_RequiredInterface_DelegationChain_main_testP.AddLanguage("C#");
					Operation_RequiredInterface_DelegationChain_main_testP.AddLanguage("Using");
					Operation_RequiredInterface_DelegationChain_main_testP.AddBody("Console.WriteLine(\"Asserting d.a.b.p == 4\");  	// Test parameter p 	int p = ((IntegerValue)inputParameters.ElementAt(0).values.ElementAt(0)).value; 	Debug.Println(\"[doBody] argument p = \" + p); 	 	Console.WriteLine(\"d.a.b.p == \" + p); 	Console.Write(\"Invocation forwarded out of e through q: \");  	if(p == 4) 	{ 		Console.ForegroundColor = ConsoleColor.Green; 		Console.WriteLine(\"Assertion successful.\"); 	} 	else 	{ 		Console.ForegroundColor = ConsoleColor.Red; 		Console.WriteLine(\"Assertion failed!\"); 	}  	Console.ResetColor();");
					Operation_RequiredInterface_DelegationChain_main_testP.AddBody("using fuml.semantics.simpleclassifiers; ");
				Operation_RequiredInterface_DelegationChain_main.AddOwnedBehavior(Operation_RequiredInterface_DelegationChain_main_testP);
					// ValueSpecificationAction Value(4)
					Operation_RequiredInterface_DelegationChain_main_Value_4.SetName("Value(4)");
					Operation_RequiredInterface_DelegationChain_main_Value_4.SetVisibility(VisibilityKind.public_);
						// LiteralInteger LiteralInteger17
						Operation_RequiredInterface_DelegationChain_main_Value_4_LiteralInteger17.SetName("LiteralInteger17");
						Operation_RequiredInterface_DelegationChain_main_Value_4_LiteralInteger17.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_DelegationChain_main_Value_4_LiteralInteger17.SetValue(4);
					Operation_RequiredInterface_DelegationChain_main_Value_4.SetValue(Operation_RequiredInterface_DelegationChain_main_Value_4_LiteralInteger17);
						// OutputPin result
						Operation_RequiredInterface_DelegationChain_main_Value_4_result.SetName("result");
						Operation_RequiredInterface_DelegationChain_main_Value_4_result.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_DelegationChain_main_Value_4_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_RequiredInterface_DelegationChain_main_Value_4.SetResult(Operation_RequiredInterface_DelegationChain_main_Value_4_result);
				Operation_RequiredInterface_DelegationChain_main.AddNode(Operation_RequiredInterface_DelegationChain_main_Value_4);
					// ReadStructuralFeatureAction Read e.c
					Operation_RequiredInterface_DelegationChain_main_Read_e_c.SetName("Read e.c");
					Operation_RequiredInterface_DelegationChain_main_Read_e_c.SetVisibility(VisibilityKind.public_);
					Operation_RequiredInterface_DelegationChain_main_Read_e_c.SetStructuralFeature(Operation_RequiredInterface_DelegationChain_E_c);
						// InputPin object
						Operation_RequiredInterface_DelegationChain_main_Read_e_c_object.SetName("object");
						Operation_RequiredInterface_DelegationChain_main_Read_e_c_object.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_DelegationChain_main_Read_e_c_object.SetType(Operation_RequiredInterface_DelegationChain_E);
					Operation_RequiredInterface_DelegationChain_main_Read_e_c.SetObject(Operation_RequiredInterface_DelegationChain_main_Read_e_c_object);
						// OutputPin result
						Operation_RequiredInterface_DelegationChain_main_Read_e_c_result.SetName("result");
						Operation_RequiredInterface_DelegationChain_main_Read_e_c_result.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_DelegationChain_main_Read_e_c_result.SetType(Operation_RequiredInterface_DelegationChain_C);
					Operation_RequiredInterface_DelegationChain_main_Read_e_c.SetResult(Operation_RequiredInterface_DelegationChain_main_Read_e_c_result);
				Operation_RequiredInterface_DelegationChain_main.AddNode(Operation_RequiredInterface_DelegationChain_main_Read_e_c);
					// ReadStructuralFeatureAction Read a.b
					Operation_RequiredInterface_DelegationChain_main_Read_a_b.SetName("Read a.b");
					Operation_RequiredInterface_DelegationChain_main_Read_a_b.SetVisibility(VisibilityKind.public_);
					Operation_RequiredInterface_DelegationChain_main_Read_a_b.SetStructuralFeature(Operation_RequiredInterface_DelegationChain_A_b);
						// InputPin object
						Operation_RequiredInterface_DelegationChain_main_Read_a_b_object.SetName("object");
						Operation_RequiredInterface_DelegationChain_main_Read_a_b_object.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_DelegationChain_main_Read_a_b_object.SetType(Operation_RequiredInterface_DelegationChain_A);
					Operation_RequiredInterface_DelegationChain_main_Read_a_b.SetObject(Operation_RequiredInterface_DelegationChain_main_Read_a_b_object);
						// OutputPin result
						Operation_RequiredInterface_DelegationChain_main_Read_a_b_result.SetName("result");
						Operation_RequiredInterface_DelegationChain_main_Read_a_b_result.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_DelegationChain_main_Read_a_b_result.SetType(Operation_RequiredInterface_DelegationChain_B);
					Operation_RequiredInterface_DelegationChain_main_Read_a_b.SetResult(Operation_RequiredInterface_DelegationChain_main_Read_a_b_result);
				Operation_RequiredInterface_DelegationChain_main.AddNode(Operation_RequiredInterface_DelegationChain_main_Read_a_b);
					// CreateObjectAction Create D
					Operation_RequiredInterface_DelegationChain_main_Create_D.SetName("Create D");
					Operation_RequiredInterface_DelegationChain_main_Create_D.SetVisibility(VisibilityKind.public_);
					Operation_RequiredInterface_DelegationChain_main_Create_D.SetClassifier(Operation_RequiredInterface_DelegationChain_D);
						// OutputPin result
						Operation_RequiredInterface_DelegationChain_main_Create_D_result.SetName("result");
						Operation_RequiredInterface_DelegationChain_main_Create_D_result.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_DelegationChain_main_Create_D_result.SetType(Operation_RequiredInterface_DelegationChain_D);
					Operation_RequiredInterface_DelegationChain_main_Create_D.SetResult(Operation_RequiredInterface_DelegationChain_main_Create_D_result);
				Operation_RequiredInterface_DelegationChain_main.AddNode(Operation_RequiredInterface_DelegationChain_main_Create_D);
					// ForkNode Fork d
					Operation_RequiredInterface_DelegationChain_main_Fork_d.SetName("Fork d");
					Operation_RequiredInterface_DelegationChain_main_Fork_d.SetVisibility(VisibilityKind.public_);
				Operation_RequiredInterface_DelegationChain_main.AddNode(Operation_RequiredInterface_DelegationChain_main_Fork_d);
					// CallOperationAction Call setP()
					Operation_RequiredInterface_DelegationChain_main_Call_setP_.SetName("Call setP()");
					Operation_RequiredInterface_DelegationChain_main_Call_setP_.SetVisibility(VisibilityKind.public_);
					Operation_RequiredInterface_DelegationChain_main_Call_setP_.SetOperation(Operation_RequiredInterface_DelegationChain_C_setP_Integer);
						// InputPin target
						Operation_RequiredInterface_DelegationChain_main_Call_setP__target.SetName("target");
						Operation_RequiredInterface_DelegationChain_main_Call_setP__target.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_DelegationChain_main_Call_setP__target.SetType(Operation_RequiredInterface_DelegationChain_C);
					Operation_RequiredInterface_DelegationChain_main_Call_setP_.SetTarget(Operation_RequiredInterface_DelegationChain_main_Call_setP__target);
						// InputPin v
						Operation_RequiredInterface_DelegationChain_main_Call_setP__v.SetName("v");
						Operation_RequiredInterface_DelegationChain_main_Call_setP__v.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_DelegationChain_main_Call_setP__v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_RequiredInterface_DelegationChain_main_Call_setP_.AddArgument(Operation_RequiredInterface_DelegationChain_main_Call_setP__v);
				Operation_RequiredInterface_DelegationChain_main.AddNode(Operation_RequiredInterface_DelegationChain_main_Call_setP_);
					// ReadStructuralFeatureAction Read b.p
					Operation_RequiredInterface_DelegationChain_main_Read_b_p.SetName("Read b.p");
					Operation_RequiredInterface_DelegationChain_main_Read_b_p.SetVisibility(VisibilityKind.public_);
					Operation_RequiredInterface_DelegationChain_main_Read_b_p.SetStructuralFeature(Operation_RequiredInterface_DelegationChain_B_p);
						// InputPin object
						Operation_RequiredInterface_DelegationChain_main_Read_b_p_object.SetName("object");
						Operation_RequiredInterface_DelegationChain_main_Read_b_p_object.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_DelegationChain_main_Read_b_p_object.SetType(Operation_RequiredInterface_DelegationChain_B);
					Operation_RequiredInterface_DelegationChain_main_Read_b_p.SetObject(Operation_RequiredInterface_DelegationChain_main_Read_b_p_object);
						// OutputPin result
						Operation_RequiredInterface_DelegationChain_main_Read_b_p_result.SetName("result");
						Operation_RequiredInterface_DelegationChain_main_Read_b_p_result.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_DelegationChain_main_Read_b_p_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_RequiredInterface_DelegationChain_main_Read_b_p.SetResult(Operation_RequiredInterface_DelegationChain_main_Read_b_p_result);
				Operation_RequiredInterface_DelegationChain_main.AddNode(Operation_RequiredInterface_DelegationChain_main_Read_b_p);
					// CallBehaviorAction Call testP
					Operation_RequiredInterface_DelegationChain_main_Call_testP.SetName("Call testP");
					Operation_RequiredInterface_DelegationChain_main_Call_testP.SetVisibility(VisibilityKind.public_);
					Operation_RequiredInterface_DelegationChain_main_Call_testP.SetBehavior(Operation_RequiredInterface_DelegationChain_main_testP);
						// InputPin p
						Operation_RequiredInterface_DelegationChain_main_Call_testP_p.SetName("p");
						Operation_RequiredInterface_DelegationChain_main_Call_testP_p.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_DelegationChain_main_Call_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_RequiredInterface_DelegationChain_main_Call_testP.AddArgument(Operation_RequiredInterface_DelegationChain_main_Call_testP_p);
				Operation_RequiredInterface_DelegationChain_main.AddNode(Operation_RequiredInterface_DelegationChain_main_Call_testP);
					// ReadStructuralFeatureAction Read d.a
					Operation_RequiredInterface_DelegationChain_main_Read_d_a.SetName("Read d.a");
					Operation_RequiredInterface_DelegationChain_main_Read_d_a.SetVisibility(VisibilityKind.public_);
					Operation_RequiredInterface_DelegationChain_main_Read_d_a.SetStructuralFeature(Operation_RequiredInterface_DelegationChain_D_a);
						// InputPin object
						Operation_RequiredInterface_DelegationChain_main_Read_d_a_object.SetName("object");
						Operation_RequiredInterface_DelegationChain_main_Read_d_a_object.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_DelegationChain_main_Read_d_a_object.SetType(Operation_RequiredInterface_DelegationChain_D);
					Operation_RequiredInterface_DelegationChain_main_Read_d_a.SetObject(Operation_RequiredInterface_DelegationChain_main_Read_d_a_object);
						// OutputPin result
						Operation_RequiredInterface_DelegationChain_main_Read_d_a_result.SetName("result");
						Operation_RequiredInterface_DelegationChain_main_Read_d_a_result.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_DelegationChain_main_Read_d_a_result.SetType(Operation_RequiredInterface_DelegationChain_A);
					Operation_RequiredInterface_DelegationChain_main_Read_d_a.SetResult(Operation_RequiredInterface_DelegationChain_main_Read_d_a_result);
				Operation_RequiredInterface_DelegationChain_main.AddNode(Operation_RequiredInterface_DelegationChain_main_Read_d_a);
					// ReadStructuralFeatureAction Read d.e
					Operation_RequiredInterface_DelegationChain_main_Read_d_e.SetName("Read d.e");
					Operation_RequiredInterface_DelegationChain_main_Read_d_e.SetVisibility(VisibilityKind.public_);
					Operation_RequiredInterface_DelegationChain_main_Read_d_e.SetStructuralFeature(Operation_RequiredInterface_DelegationChain_D_e);
						// InputPin object
						Operation_RequiredInterface_DelegationChain_main_Read_d_e_object.SetName("object");
						Operation_RequiredInterface_DelegationChain_main_Read_d_e_object.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_DelegationChain_main_Read_d_e_object.SetType(Operation_RequiredInterface_DelegationChain_D);
					Operation_RequiredInterface_DelegationChain_main_Read_d_e.SetObject(Operation_RequiredInterface_DelegationChain_main_Read_d_e_object);
						// OutputPin result
						Operation_RequiredInterface_DelegationChain_main_Read_d_e_result.SetName("result");
						Operation_RequiredInterface_DelegationChain_main_Read_d_e_result.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_DelegationChain_main_Read_d_e_result.SetType(Operation_RequiredInterface_DelegationChain_E);
					Operation_RequiredInterface_DelegationChain_main_Read_d_e.SetResult(Operation_RequiredInterface_DelegationChain_main_Read_d_e_result);
				Operation_RequiredInterface_DelegationChain_main.AddNode(Operation_RequiredInterface_DelegationChain_main_Read_d_e);
					// CallOperationAction D()
					Operation_RequiredInterface_DelegationChain_main_D_.SetName("D()");
					Operation_RequiredInterface_DelegationChain_main_D_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						Operation_RequiredInterface_DelegationChain_main_D__result.SetName("result");
						Operation_RequiredInterface_DelegationChain_main_D__result.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_DelegationChain_main_D__result.SetType(Operation_RequiredInterface_DelegationChain_D);
					Operation_RequiredInterface_DelegationChain_main_D_.AddResult(Operation_RequiredInterface_DelegationChain_main_D__result);
					Operation_RequiredInterface_DelegationChain_main_D_.SetOperation(Operation_RequiredInterface_DelegationChain_D_D_D);
						// InputPin target
						Operation_RequiredInterface_DelegationChain_main_D__target.SetName("target");
						Operation_RequiredInterface_DelegationChain_main_D__target.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_DelegationChain_main_D__target.SetType(Operation_RequiredInterface_DelegationChain_D);
					Operation_RequiredInterface_DelegationChain_main_D_.SetTarget(Operation_RequiredInterface_DelegationChain_main_D__target);
				Operation_RequiredInterface_DelegationChain_main.AddNode(Operation_RequiredInterface_DelegationChain_main_D_);
					// ControlFlow ControlFlow14 from Call setP() to Read d.a
					Operation_RequiredInterface_DelegationChain_main_ControlFlow14.SetName("ControlFlow14");
					Operation_RequiredInterface_DelegationChain_main_ControlFlow14.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_DelegationChain_main_ControlFlow14.SetSource(Operation_RequiredInterface_DelegationChain_main_Call_setP_);
					Operation_RequiredInterface_DelegationChain_main_ControlFlow14.SetTarget(Operation_RequiredInterface_DelegationChain_main_Read_d_a);
				Operation_RequiredInterface_DelegationChain_main.AddEdge(Operation_RequiredInterface_DelegationChain_main_ControlFlow14);
					// ObjectFlow ObjectFlow48 from result to target
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow48.SetName("ObjectFlow48");
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow48.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow48.SetSource(Operation_RequiredInterface_DelegationChain_main_Read_e_c_result);
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow48.SetTarget(Operation_RequiredInterface_DelegationChain_main_Call_setP__target);
						// LiteralBoolean LiteralBoolean50
						Operation_RequiredInterface_DelegationChain_main_ObjectFlow48_LiteralBoolean50.SetName("LiteralBoolean50");
						Operation_RequiredInterface_DelegationChain_main_ObjectFlow48_LiteralBoolean50.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_DelegationChain_main_ObjectFlow48_LiteralBoolean50.SetValue(true);
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow48.SetGuard(Operation_RequiredInterface_DelegationChain_main_ObjectFlow48_LiteralBoolean50);
				Operation_RequiredInterface_DelegationChain_main.AddEdge(Operation_RequiredInterface_DelegationChain_main_ObjectFlow48);
					// ObjectFlow ObjectFlow51 from result to Fork d
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow51.SetName("ObjectFlow51");
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow51.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow51.SetSource(Operation_RequiredInterface_DelegationChain_main_D__result);
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow51.SetTarget(Operation_RequiredInterface_DelegationChain_main_Fork_d);
						// LiteralBoolean LiteralBoolean53
						Operation_RequiredInterface_DelegationChain_main_ObjectFlow51_LiteralBoolean53.SetName("LiteralBoolean53");
						Operation_RequiredInterface_DelegationChain_main_ObjectFlow51_LiteralBoolean53.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_DelegationChain_main_ObjectFlow51_LiteralBoolean53.SetValue(true);
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow51.SetGuard(Operation_RequiredInterface_DelegationChain_main_ObjectFlow51_LiteralBoolean53);
				Operation_RequiredInterface_DelegationChain_main.AddEdge(Operation_RequiredInterface_DelegationChain_main_ObjectFlow51);
					// ObjectFlow ObjectFlow22 from result to target
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow22.SetName("ObjectFlow22");
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow22.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow22.SetSource(Operation_RequiredInterface_DelegationChain_main_Create_D_result);
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow22.SetTarget(Operation_RequiredInterface_DelegationChain_main_D__target);
						// LiteralBoolean LiteralBoolean24
						Operation_RequiredInterface_DelegationChain_main_ObjectFlow22_LiteralBoolean24.SetName("LiteralBoolean24");
						Operation_RequiredInterface_DelegationChain_main_ObjectFlow22_LiteralBoolean24.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_DelegationChain_main_ObjectFlow22_LiteralBoolean24.SetValue(true);
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow22.SetGuard(Operation_RequiredInterface_DelegationChain_main_ObjectFlow22_LiteralBoolean24);
				Operation_RequiredInterface_DelegationChain_main.AddEdge(Operation_RequiredInterface_DelegationChain_main_ObjectFlow22);
					// ObjectFlow ObjectFlow54 from Fork d to object
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow54.SetName("ObjectFlow54");
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow54.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow54.SetSource(Operation_RequiredInterface_DelegationChain_main_Fork_d);
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow54.SetTarget(Operation_RequiredInterface_DelegationChain_main_Read_d_e_object);
						// LiteralBoolean LiteralBoolean55
						Operation_RequiredInterface_DelegationChain_main_ObjectFlow54_LiteralBoolean55.SetName("LiteralBoolean55");
						Operation_RequiredInterface_DelegationChain_main_ObjectFlow54_LiteralBoolean55.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_DelegationChain_main_ObjectFlow54_LiteralBoolean55.SetValue(true);
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow54.SetGuard(Operation_RequiredInterface_DelegationChain_main_ObjectFlow54_LiteralBoolean55);
				Operation_RequiredInterface_DelegationChain_main.AddEdge(Operation_RequiredInterface_DelegationChain_main_ObjectFlow54);
					// ObjectFlow ObjectFlow27 from result to v
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow27.SetName("ObjectFlow27");
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow27.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow27.SetSource(Operation_RequiredInterface_DelegationChain_main_Value_4_result);
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow27.SetTarget(Operation_RequiredInterface_DelegationChain_main_Call_setP__v);
						// LiteralBoolean LiteralBoolean28
						Operation_RequiredInterface_DelegationChain_main_ObjectFlow27_LiteralBoolean28.SetName("LiteralBoolean28");
						Operation_RequiredInterface_DelegationChain_main_ObjectFlow27_LiteralBoolean28.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_DelegationChain_main_ObjectFlow27_LiteralBoolean28.SetValue(true);
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow27.SetGuard(Operation_RequiredInterface_DelegationChain_main_ObjectFlow27_LiteralBoolean28);
				Operation_RequiredInterface_DelegationChain_main.AddEdge(Operation_RequiredInterface_DelegationChain_main_ObjectFlow27);
					// ObjectFlow ObjectFlow30 from result to object
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow30.SetName("ObjectFlow30");
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow30.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow30.SetSource(Operation_RequiredInterface_DelegationChain_main_Read_a_b_result);
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow30.SetTarget(Operation_RequiredInterface_DelegationChain_main_Read_b_p_object);
						// LiteralBoolean LiteralBoolean32
						Operation_RequiredInterface_DelegationChain_main_ObjectFlow30_LiteralBoolean32.SetName("LiteralBoolean32");
						Operation_RequiredInterface_DelegationChain_main_ObjectFlow30_LiteralBoolean32.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_DelegationChain_main_ObjectFlow30_LiteralBoolean32.SetValue(true);
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow30.SetGuard(Operation_RequiredInterface_DelegationChain_main_ObjectFlow30_LiteralBoolean32);
				Operation_RequiredInterface_DelegationChain_main.AddEdge(Operation_RequiredInterface_DelegationChain_main_ObjectFlow30);
					// ObjectFlow ObjectFlow41 from result to object
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow41.SetName("ObjectFlow41");
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow41.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow41.SetSource(Operation_RequiredInterface_DelegationChain_main_Read_d_a_result);
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow41.SetTarget(Operation_RequiredInterface_DelegationChain_main_Read_a_b_object);
						// LiteralBoolean LiteralBoolean42
						Operation_RequiredInterface_DelegationChain_main_ObjectFlow41_LiteralBoolean42.SetName("LiteralBoolean42");
						Operation_RequiredInterface_DelegationChain_main_ObjectFlow41_LiteralBoolean42.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_DelegationChain_main_ObjectFlow41_LiteralBoolean42.SetValue(true);
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow41.SetGuard(Operation_RequiredInterface_DelegationChain_main_ObjectFlow41_LiteralBoolean42);
				Operation_RequiredInterface_DelegationChain_main.AddEdge(Operation_RequiredInterface_DelegationChain_main_ObjectFlow41);
					// ObjectFlow ObjectFlow74 from result to object
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow74.SetName("ObjectFlow74");
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow74.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow74.SetSource(Operation_RequiredInterface_DelegationChain_main_Read_d_e_result);
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow74.SetTarget(Operation_RequiredInterface_DelegationChain_main_Read_e_c_object);
						// LiteralBoolean LiteralBoolean75
						Operation_RequiredInterface_DelegationChain_main_ObjectFlow74_LiteralBoolean75.SetName("LiteralBoolean75");
						Operation_RequiredInterface_DelegationChain_main_ObjectFlow74_LiteralBoolean75.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_DelegationChain_main_ObjectFlow74_LiteralBoolean75.SetValue(true);
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow74.SetGuard(Operation_RequiredInterface_DelegationChain_main_ObjectFlow74_LiteralBoolean75);
				Operation_RequiredInterface_DelegationChain_main.AddEdge(Operation_RequiredInterface_DelegationChain_main_ObjectFlow74);
					// ObjectFlow ObjectFlow77 from result to p
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow77.SetName("ObjectFlow77");
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow77.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow77.SetSource(Operation_RequiredInterface_DelegationChain_main_Read_b_p_result);
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow77.SetTarget(Operation_RequiredInterface_DelegationChain_main_Call_testP_p);
						// LiteralBoolean LiteralBoolean78
						Operation_RequiredInterface_DelegationChain_main_ObjectFlow77_LiteralBoolean78.SetName("LiteralBoolean78");
						Operation_RequiredInterface_DelegationChain_main_ObjectFlow77_LiteralBoolean78.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_DelegationChain_main_ObjectFlow77_LiteralBoolean78.SetValue(true);
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow77.SetGuard(Operation_RequiredInterface_DelegationChain_main_ObjectFlow77_LiteralBoolean78);
				Operation_RequiredInterface_DelegationChain_main.AddEdge(Operation_RequiredInterface_DelegationChain_main_ObjectFlow77);
					// ObjectFlow ObjectFlow80 from Fork d to object
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow80.SetName("ObjectFlow80");
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow80.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow80.SetSource(Operation_RequiredInterface_DelegationChain_main_Fork_d);
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow80.SetTarget(Operation_RequiredInterface_DelegationChain_main_Read_d_a_object);
						// LiteralBoolean LiteralBoolean82
						Operation_RequiredInterface_DelegationChain_main_ObjectFlow80_LiteralBoolean82.SetName("LiteralBoolean82");
						Operation_RequiredInterface_DelegationChain_main_ObjectFlow80_LiteralBoolean82.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_DelegationChain_main_ObjectFlow80_LiteralBoolean82.SetValue(true);
					Operation_RequiredInterface_DelegationChain_main_ObjectFlow80.SetGuard(Operation_RequiredInterface_DelegationChain_main_ObjectFlow80_LiteralBoolean82);
				Operation_RequiredInterface_DelegationChain_main.AddEdge(Operation_RequiredInterface_DelegationChain_main_ObjectFlow80);
			Operation_RequiredInterface_DelegationChain.AddPackagedElement(Operation_RequiredInterface_DelegationChain_main);
				// Interface I
				Operation_RequiredInterface_DelegationChain_I.SetName("I");
				Operation_RequiredInterface_DelegationChain_I.SetVisibility(VisibilityKind.public_);
					// Operation setP_Integer
					Operation_RequiredInterface_DelegationChain_I_setP_Integer.SetName("setP_Integer");
					Operation_RequiredInterface_DelegationChain_I_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						Operation_RequiredInterface_DelegationChain_I_setP_Integer_v.SetName("v");
						Operation_RequiredInterface_DelegationChain_I_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_DelegationChain_I_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_RequiredInterface_DelegationChain_I_setP_Integer.AddOwnedParameter(Operation_RequiredInterface_DelegationChain_I_setP_Integer_v);
				Operation_RequiredInterface_DelegationChain_I.AddOwnedOperation(Operation_RequiredInterface_DelegationChain_I_setP_Integer);
			Operation_RequiredInterface_DelegationChain.AddPackagedElement(Operation_RequiredInterface_DelegationChain_I);
				// Class D
				Operation_RequiredInterface_DelegationChain_D.SetName("D");
				Operation_RequiredInterface_DelegationChain_D.SetVisibility(VisibilityKind.public_);
				
					// Property e
					Operation_RequiredInterface_DelegationChain_D_e.SetName("e");
					Operation_RequiredInterface_DelegationChain_D_e.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_DelegationChain_D_e.SetType(Operation_RequiredInterface_DelegationChain_E);
					Operation_RequiredInterface_DelegationChain_D_e.SetAggregation(AggregationKind.composite);
				Operation_RequiredInterface_DelegationChain_D.AddOwnedAttribute(Operation_RequiredInterface_DelegationChain_D_e);
					// Property a
					Operation_RequiredInterface_DelegationChain_D_a.SetName("a");
					Operation_RequiredInterface_DelegationChain_D_a.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_DelegationChain_D_a.SetType(Operation_RequiredInterface_DelegationChain_A);
					Operation_RequiredInterface_DelegationChain_D_a.SetAggregation(AggregationKind.composite);
				Operation_RequiredInterface_DelegationChain_D.AddOwnedAttribute(Operation_RequiredInterface_DelegationChain_D_a);
				
				Operation_RequiredInterface_DelegationChain_D_s.SetName("s");
					Operation_RequiredInterface_DelegationChain_D_s.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_DelegationChain_D_s_ConnectorEnd84.SetRole(Operation_RequiredInterface_DelegationChain_E_q);
						Operation_RequiredInterface_DelegationChain_D_s_ConnectorEnd84.SetPartWithPort(Operation_RequiredInterface_DelegationChain_D_e);
						
					Operation_RequiredInterface_DelegationChain_D_s.AddEnd(Operation_RequiredInterface_DelegationChain_D_s_ConnectorEnd84);
						
						Operation_RequiredInterface_DelegationChain_D_s_ConnectorEnd83.SetRole(Operation_RequiredInterface_DelegationChain_A_q);
						Operation_RequiredInterface_DelegationChain_D_s_ConnectorEnd83.SetPartWithPort(Operation_RequiredInterface_DelegationChain_D_a);
						
					Operation_RequiredInterface_DelegationChain_D_s.AddEnd(Operation_RequiredInterface_DelegationChain_D_s_ConnectorEnd83);
					Operation_RequiredInterface_DelegationChain_D_s.SetType(Operation_RequiredInterface_DelegationChain_S);
				Operation_RequiredInterface_DelegationChain_D.AddOwnedConnector(Operation_RequiredInterface_DelegationChain_D_s);
					// Operation D_D
					Operation_RequiredInterface_DelegationChain_D_D_D.SetName("D_D");
					Operation_RequiredInterface_DelegationChain_D_D_D.SetVisibility(VisibilityKind.public_);
						// Parameter result
						Operation_RequiredInterface_DelegationChain_D_D_D_result.SetName("result");
						Operation_RequiredInterface_DelegationChain_D_D_D_result.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_DelegationChain_D_D_D_result.SetType(Operation_RequiredInterface_DelegationChain_D);
						Operation_RequiredInterface_DelegationChain_D_D_D_result.SetDirection(ParameterDirectionKind.return_);
					Operation_RequiredInterface_DelegationChain_D_D_D.AddOwnedParameter(Operation_RequiredInterface_DelegationChain_D_D_D_result);
					Operation_RequiredInterface_DelegationChain_D_D_D.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				Operation_RequiredInterface_DelegationChain_D.AddOwnedOperation(Operation_RequiredInterface_DelegationChain_D_D_D);
			Operation_RequiredInterface_DelegationChain.AddPackagedElement(Operation_RequiredInterface_DelegationChain_D);
				// Association R
				Operation_RequiredInterface_DelegationChain_R.SetName("R");
				Operation_RequiredInterface_DelegationChain_R.SetVisibility(VisibilityKind.public_);
				Operation_RequiredInterface_DelegationChain_R.AddOwnedEnd(Operation_RequiredInterface_DelegationChain_R_x);
				Operation_RequiredInterface_DelegationChain_R.AddOwnedEnd(Operation_RequiredInterface_DelegationChain_R_y);
			Operation_RequiredInterface_DelegationChain.AddPackagedElement(Operation_RequiredInterface_DelegationChain_R);
				// Class A
				Operation_RequiredInterface_DelegationChain_A.SetName("A");
				Operation_RequiredInterface_DelegationChain_A.SetVisibility(VisibilityKind.public_);
				
					// Port q
					Operation_RequiredInterface_DelegationChain_A_q.SetName("q");
					Operation_RequiredInterface_DelegationChain_A_q.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_DelegationChain_A_q.SetType(Operation_RequiredInterface_DelegationChain_IImpl);
					Operation_RequiredInterface_DelegationChain_A_q.SetAggregation(AggregationKind.composite);
					Operation_RequiredInterface_DelegationChain_A_q.isService = true;
					Operation_RequiredInterface_DelegationChain_A_q.AddProvided(Operation_RequiredInterface_DelegationChain_I);
				Operation_RequiredInterface_DelegationChain_A.AddOwnedAttribute(Operation_RequiredInterface_DelegationChain_A_q);
					// Property b
					Operation_RequiredInterface_DelegationChain_A_b.SetName("b");
					Operation_RequiredInterface_DelegationChain_A_b.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_DelegationChain_A_b.SetType(Operation_RequiredInterface_DelegationChain_B);
					Operation_RequiredInterface_DelegationChain_A_b.SetAggregation(AggregationKind.composite);
				Operation_RequiredInterface_DelegationChain_A.AddOwnedAttribute(Operation_RequiredInterface_DelegationChain_A_b);
				// Activity setPActivity
					Operation_RequiredInterface_DelegationChain_A_setPActivity.SetName("setPActivity");
					Operation_RequiredInterface_DelegationChain_A_setPActivity.SetVisibility(VisibilityKind.public_);
					
						// Parameter v
						Operation_RequiredInterface_DelegationChain_A_setPActivity_v.SetName("v");
						Operation_RequiredInterface_DelegationChain_A_setPActivity_v.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_DelegationChain_A_setPActivity_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_RequiredInterface_DelegationChain_A_setPActivity.AddOwnedParameter(Operation_RequiredInterface_DelegationChain_A_setPActivity_v);
						// ActivityParameterNode vParameterNode
						Operation_RequiredInterface_DelegationChain_A_setPActivity_vParameterNode.SetName("vParameterNode");
						Operation_RequiredInterface_DelegationChain_A_setPActivity_vParameterNode.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_DelegationChain_A_setPActivity_vParameterNode.SetParameter(Operation_RequiredInterface_DelegationChain_A_setPActivity_v);
					Operation_RequiredInterface_DelegationChain_A_setPActivity.AddNode(Operation_RequiredInterface_DelegationChain_A_setPActivity_vParameterNode);
						// ReadSelfAction this
						Operation_RequiredInterface_DelegationChain_A_setPActivity_this.SetName("this");
						Operation_RequiredInterface_DelegationChain_A_setPActivity_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							Operation_RequiredInterface_DelegationChain_A_setPActivity_this_result.SetName("result");
							Operation_RequiredInterface_DelegationChain_A_setPActivity_this_result.SetVisibility(VisibilityKind.public_);
							Operation_RequiredInterface_DelegationChain_A_setPActivity_this_result.SetType(Operation_RequiredInterface_DelegationChain_A);
						Operation_RequiredInterface_DelegationChain_A_setPActivity_this.SetResult(Operation_RequiredInterface_DelegationChain_A_setPActivity_this_result);
					Operation_RequiredInterface_DelegationChain_A_setPActivity.AddNode(Operation_RequiredInterface_DelegationChain_A_setPActivity_this);
						// CallOperationAction Call I::setP on q
						Operation_RequiredInterface_DelegationChain_A_setPActivity_Call_I_setP_on_q.SetName("Call I::setP on q");
						Operation_RequiredInterface_DelegationChain_A_setPActivity_Call_I_setP_on_q.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_DelegationChain_A_setPActivity_Call_I_setP_on_q.SetOnPort(Operation_RequiredInterface_DelegationChain_A_q);
						Operation_RequiredInterface_DelegationChain_A_setPActivity_Call_I_setP_on_q.SetOperation(Operation_RequiredInterface_DelegationChain_I_setP_Integer);
							// InputPin target
							Operation_RequiredInterface_DelegationChain_A_setPActivity_Call_I_setP_on_q_target.SetName("target");
							Operation_RequiredInterface_DelegationChain_A_setPActivity_Call_I_setP_on_q_target.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_DelegationChain_A_setPActivity_Call_I_setP_on_q.SetTarget(Operation_RequiredInterface_DelegationChain_A_setPActivity_Call_I_setP_on_q_target);
							// InputPin v
							Operation_RequiredInterface_DelegationChain_A_setPActivity_Call_I_setP_on_q_v.SetName("v");
							Operation_RequiredInterface_DelegationChain_A_setPActivity_Call_I_setP_on_q_v.SetVisibility(VisibilityKind.public_);
							Operation_RequiredInterface_DelegationChain_A_setPActivity_Call_I_setP_on_q_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						Operation_RequiredInterface_DelegationChain_A_setPActivity_Call_I_setP_on_q.AddArgument(Operation_RequiredInterface_DelegationChain_A_setPActivity_Call_I_setP_on_q_v);
					Operation_RequiredInterface_DelegationChain_A_setPActivity.AddNode(Operation_RequiredInterface_DelegationChain_A_setPActivity_Call_I_setP_on_q);
						// ObjectFlow ObjectFlow88 from result to target
						Operation_RequiredInterface_DelegationChain_A_setPActivity_ObjectFlow88.SetName("ObjectFlow88");
						Operation_RequiredInterface_DelegationChain_A_setPActivity_ObjectFlow88.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_DelegationChain_A_setPActivity_ObjectFlow88.SetSource(Operation_RequiredInterface_DelegationChain_A_setPActivity_this_result);
						Operation_RequiredInterface_DelegationChain_A_setPActivity_ObjectFlow88.SetTarget(Operation_RequiredInterface_DelegationChain_A_setPActivity_Call_I_setP_on_q_target);
							// LiteralBoolean LiteralBoolean89
							Operation_RequiredInterface_DelegationChain_A_setPActivity_ObjectFlow88_LiteralBoolean89.SetName("LiteralBoolean89");
							Operation_RequiredInterface_DelegationChain_A_setPActivity_ObjectFlow88_LiteralBoolean89.SetVisibility(VisibilityKind.public_);
							Operation_RequiredInterface_DelegationChain_A_setPActivity_ObjectFlow88_LiteralBoolean89.SetValue(true);
						Operation_RequiredInterface_DelegationChain_A_setPActivity_ObjectFlow88.SetGuard(Operation_RequiredInterface_DelegationChain_A_setPActivity_ObjectFlow88_LiteralBoolean89);
					Operation_RequiredInterface_DelegationChain_A_setPActivity.AddEdge(Operation_RequiredInterface_DelegationChain_A_setPActivity_ObjectFlow88);
						// ObjectFlow ObjectFlow91 from vParameterNode to v
						Operation_RequiredInterface_DelegationChain_A_setPActivity_ObjectFlow91.SetName("ObjectFlow91");
						Operation_RequiredInterface_DelegationChain_A_setPActivity_ObjectFlow91.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_DelegationChain_A_setPActivity_ObjectFlow91.SetSource(Operation_RequiredInterface_DelegationChain_A_setPActivity_vParameterNode);
						Operation_RequiredInterface_DelegationChain_A_setPActivity_ObjectFlow91.SetTarget(Operation_RequiredInterface_DelegationChain_A_setPActivity_Call_I_setP_on_q_v);
							// LiteralBoolean LiteralBoolean93
							Operation_RequiredInterface_DelegationChain_A_setPActivity_ObjectFlow91_LiteralBoolean93.SetName("LiteralBoolean93");
							Operation_RequiredInterface_DelegationChain_A_setPActivity_ObjectFlow91_LiteralBoolean93.SetVisibility(VisibilityKind.public_);
							Operation_RequiredInterface_DelegationChain_A_setPActivity_ObjectFlow91_LiteralBoolean93.SetValue(true);
						Operation_RequiredInterface_DelegationChain_A_setPActivity_ObjectFlow91.SetGuard(Operation_RequiredInterface_DelegationChain_A_setPActivity_ObjectFlow91_LiteralBoolean93);
					Operation_RequiredInterface_DelegationChain_A_setPActivity.AddEdge(Operation_RequiredInterface_DelegationChain_A_setPActivity_ObjectFlow91);
				Operation_RequiredInterface_DelegationChain_A.AddOwnedBehavior(Operation_RequiredInterface_DelegationChain_A_setPActivity);
				Operation_RequiredInterface_DelegationChain_A_r.SetName("r");
					Operation_RequiredInterface_DelegationChain_A_r.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_DelegationChain_A_r_ConnectorEnd100.SetRole(Operation_RequiredInterface_DelegationChain_A_q);
						
					Operation_RequiredInterface_DelegationChain_A_r.AddEnd(Operation_RequiredInterface_DelegationChain_A_r_ConnectorEnd100);
						
						Operation_RequiredInterface_DelegationChain_A_r_ConnectorEnd99.SetRole(Operation_RequiredInterface_DelegationChain_A_b);
						
					Operation_RequiredInterface_DelegationChain_A_r.AddEnd(Operation_RequiredInterface_DelegationChain_A_r_ConnectorEnd99);
					Operation_RequiredInterface_DelegationChain_A_r.SetType(Operation_RequiredInterface_DelegationChain_R);
				Operation_RequiredInterface_DelegationChain_A.AddOwnedConnector(Operation_RequiredInterface_DelegationChain_A_r);
					// Operation setP_Integer
					Operation_RequiredInterface_DelegationChain_A_setP_Integer.SetName("setP_Integer");
					Operation_RequiredInterface_DelegationChain_A_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						Operation_RequiredInterface_DelegationChain_A_setP_Integer_v.SetName("v");
						Operation_RequiredInterface_DelegationChain_A_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_DelegationChain_A_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_RequiredInterface_DelegationChain_A_setP_Integer.AddOwnedParameter(Operation_RequiredInterface_DelegationChain_A_setP_Integer_v);
					Operation_RequiredInterface_DelegationChain_A_setP_Integer.AddMethod(Operation_RequiredInterface_DelegationChain_A_setPActivity);
				Operation_RequiredInterface_DelegationChain_A.AddOwnedOperation(Operation_RequiredInterface_DelegationChain_A_setP_Integer);
			Operation_RequiredInterface_DelegationChain.AddPackagedElement(Operation_RequiredInterface_DelegationChain_A);
				// Class E
				Operation_RequiredInterface_DelegationChain_E.SetName("E");
				Operation_RequiredInterface_DelegationChain_E.SetVisibility(VisibilityKind.public_);
				
					// Port q
					Operation_RequiredInterface_DelegationChain_E_q.SetName("q");
					Operation_RequiredInterface_DelegationChain_E_q.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_DelegationChain_E_q.SetType(Operation_RequiredInterface_DelegationChain_IImpl);
					Operation_RequiredInterface_DelegationChain_E_q.SetAggregation(AggregationKind.composite);
					Operation_RequiredInterface_DelegationChain_E_q.isConjugated = true;;
					Operation_RequiredInterface_DelegationChain_E_q.isService = true;
					Operation_RequiredInterface_DelegationChain_E_q.AddRequired(Operation_RequiredInterface_DelegationChain_I);
				Operation_RequiredInterface_DelegationChain_E.AddOwnedAttribute(Operation_RequiredInterface_DelegationChain_E_q);
					// Property c
					Operation_RequiredInterface_DelegationChain_E_c.SetName("c");
					Operation_RequiredInterface_DelegationChain_E_c.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_DelegationChain_E_c.SetType(Operation_RequiredInterface_DelegationChain_C);
					Operation_RequiredInterface_DelegationChain_E_c.SetAggregation(AggregationKind.composite);
				Operation_RequiredInterface_DelegationChain_E.AddOwnedAttribute(Operation_RequiredInterface_DelegationChain_E_c);
				
				Operation_RequiredInterface_DelegationChain_E_s.SetName("s");
					Operation_RequiredInterface_DelegationChain_E_s.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_DelegationChain_E_s_ConnectorEnd102.SetRole(Operation_RequiredInterface_DelegationChain_C_q);
						Operation_RequiredInterface_DelegationChain_E_s_ConnectorEnd102.SetPartWithPort(Operation_RequiredInterface_DelegationChain_E_c);
						
					Operation_RequiredInterface_DelegationChain_E_s.AddEnd(Operation_RequiredInterface_DelegationChain_E_s_ConnectorEnd102);
						
						Operation_RequiredInterface_DelegationChain_E_s_ConnectorEnd101.SetRole(Operation_RequiredInterface_DelegationChain_E_q);
						
					Operation_RequiredInterface_DelegationChain_E_s.AddEnd(Operation_RequiredInterface_DelegationChain_E_s_ConnectorEnd101);
					Operation_RequiredInterface_DelegationChain_E_s.SetType(Operation_RequiredInterface_DelegationChain_S);
				Operation_RequiredInterface_DelegationChain_E.AddOwnedConnector(Operation_RequiredInterface_DelegationChain_E_s);
			Operation_RequiredInterface_DelegationChain.AddPackagedElement(Operation_RequiredInterface_DelegationChain_E);
				// Class IImpl
				Operation_RequiredInterface_DelegationChain_IImpl.SetName("IImpl");
				Operation_RequiredInterface_DelegationChain_IImpl.SetVisibility(VisibilityKind.public_);
				Operation_RequiredInterface_DelegationChain_IImpl_IRealization.SetName("IRealization");
					Operation_RequiredInterface_DelegationChain_IImpl_IRealization.SetVisibility(VisibilityKind.public_);
					Operation_RequiredInterface_DelegationChain_IImpl_IRealization.SetContract(Operation_RequiredInterface_DelegationChain_I);
					
				Operation_RequiredInterface_DelegationChain_IImpl.AddInterfaceRealization(Operation_RequiredInterface_DelegationChain_IImpl_IRealization);
				
					// Operation setP_Integer
					Operation_RequiredInterface_DelegationChain_IImpl_setP_Integer.SetName("setP_Integer");
					Operation_RequiredInterface_DelegationChain_IImpl_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						Operation_RequiredInterface_DelegationChain_IImpl_setP_Integer_v.SetName("v");
						Operation_RequiredInterface_DelegationChain_IImpl_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_DelegationChain_IImpl_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_RequiredInterface_DelegationChain_IImpl_setP_Integer.AddOwnedParameter(Operation_RequiredInterface_DelegationChain_IImpl_setP_Integer_v);
				Operation_RequiredInterface_DelegationChain_IImpl.AddOwnedOperation(Operation_RequiredInterface_DelegationChain_IImpl_setP_Integer);
			Operation_RequiredInterface_DelegationChain.AddPackagedElement(Operation_RequiredInterface_DelegationChain_IImpl);
				// Class B
				Operation_RequiredInterface_DelegationChain_B.SetName("B");
				Operation_RequiredInterface_DelegationChain_B.SetVisibility(VisibilityKind.public_);
				
					// Property p
					Operation_RequiredInterface_DelegationChain_B_p.SetName("p");
					Operation_RequiredInterface_DelegationChain_B_p.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_DelegationChain_B_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
				Operation_RequiredInterface_DelegationChain_B.AddOwnedAttribute(Operation_RequiredInterface_DelegationChain_B_p);
				// Activity setPActivity
					Operation_RequiredInterface_DelegationChain_B_setPActivity.SetName("setPActivity");
					Operation_RequiredInterface_DelegationChain_B_setPActivity.SetVisibility(VisibilityKind.public_);
					
						// Parameter v
						Operation_RequiredInterface_DelegationChain_B_setPActivity_v.SetName("v");
						Operation_RequiredInterface_DelegationChain_B_setPActivity_v.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_DelegationChain_B_setPActivity_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_RequiredInterface_DelegationChain_B_setPActivity.AddOwnedParameter(Operation_RequiredInterface_DelegationChain_B_setPActivity_v);
						// ActivityParameterNode vParameterNode
						Operation_RequiredInterface_DelegationChain_B_setPActivity_vParameterNode.SetName("vParameterNode");
						Operation_RequiredInterface_DelegationChain_B_setPActivity_vParameterNode.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_DelegationChain_B_setPActivity_vParameterNode.SetParameter(Operation_RequiredInterface_DelegationChain_B_setPActivity_v);
					Operation_RequiredInterface_DelegationChain_B_setPActivity.AddNode(Operation_RequiredInterface_DelegationChain_B_setPActivity_vParameterNode);
						// AddStructuralFeatureValueAction Set this.p
						Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p.SetName("Set this.p");
						Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p.SetStructuralFeature(Operation_RequiredInterface_DelegationChain_B_p);
							// InputPin object
							Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p_object.SetName("object");
							Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p_object.SetVisibility(VisibilityKind.public_);
							Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p_object.SetType(Operation_RequiredInterface_DelegationChain_B);
						Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p.SetObject(Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p_object);
							// InputPin value
							Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p_value.SetName("value");
							Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p_value.SetVisibility(VisibilityKind.public_);
							Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p.SetValue(Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p_value);
							// OutputPin result
							Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p_result.SetName("result");
							Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p_result.SetVisibility(VisibilityKind.public_);
							Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p_result.SetType(Operation_RequiredInterface_DelegationChain_B);
						Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p.SetResult(Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p_result);
						Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p.SetIsReplaceAll(true);
					Operation_RequiredInterface_DelegationChain_B_setPActivity.AddNode(Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p);
						// ReadSelfAction this
						Operation_RequiredInterface_DelegationChain_B_setPActivity_this.SetName("this");
						Operation_RequiredInterface_DelegationChain_B_setPActivity_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							Operation_RequiredInterface_DelegationChain_B_setPActivity_this_result.SetName("result");
							Operation_RequiredInterface_DelegationChain_B_setPActivity_this_result.SetVisibility(VisibilityKind.public_);
							Operation_RequiredInterface_DelegationChain_B_setPActivity_this_result.SetType(Operation_RequiredInterface_DelegationChain_B);
						Operation_RequiredInterface_DelegationChain_B_setPActivity_this.SetResult(Operation_RequiredInterface_DelegationChain_B_setPActivity_this_result);
					Operation_RequiredInterface_DelegationChain_B_setPActivity.AddNode(Operation_RequiredInterface_DelegationChain_B_setPActivity_this);
						// ObjectFlow ObjectFlow103 from vParameterNode to value
						Operation_RequiredInterface_DelegationChain_B_setPActivity_ObjectFlow103.SetName("ObjectFlow103");
						Operation_RequiredInterface_DelegationChain_B_setPActivity_ObjectFlow103.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_DelegationChain_B_setPActivity_ObjectFlow103.SetSource(Operation_RequiredInterface_DelegationChain_B_setPActivity_vParameterNode);
						Operation_RequiredInterface_DelegationChain_B_setPActivity_ObjectFlow103.SetTarget(Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p_value);
							// LiteralBoolean LiteralBoolean105
							Operation_RequiredInterface_DelegationChain_B_setPActivity_ObjectFlow103_LiteralBoolean105.SetName("LiteralBoolean105");
							Operation_RequiredInterface_DelegationChain_B_setPActivity_ObjectFlow103_LiteralBoolean105.SetVisibility(VisibilityKind.public_);
							Operation_RequiredInterface_DelegationChain_B_setPActivity_ObjectFlow103_LiteralBoolean105.SetValue(true);
						Operation_RequiredInterface_DelegationChain_B_setPActivity_ObjectFlow103.SetGuard(Operation_RequiredInterface_DelegationChain_B_setPActivity_ObjectFlow103_LiteralBoolean105);
					Operation_RequiredInterface_DelegationChain_B_setPActivity.AddEdge(Operation_RequiredInterface_DelegationChain_B_setPActivity_ObjectFlow103);
						// ObjectFlow ObjectFlow106 from result to object
						Operation_RequiredInterface_DelegationChain_B_setPActivity_ObjectFlow106.SetName("ObjectFlow106");
						Operation_RequiredInterface_DelegationChain_B_setPActivity_ObjectFlow106.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_DelegationChain_B_setPActivity_ObjectFlow106.SetSource(Operation_RequiredInterface_DelegationChain_B_setPActivity_this_result);
						Operation_RequiredInterface_DelegationChain_B_setPActivity_ObjectFlow106.SetTarget(Operation_RequiredInterface_DelegationChain_B_setPActivity_Set_this_p_object);
							// LiteralBoolean LiteralBoolean107
							Operation_RequiredInterface_DelegationChain_B_setPActivity_ObjectFlow106_LiteralBoolean107.SetName("LiteralBoolean107");
							Operation_RequiredInterface_DelegationChain_B_setPActivity_ObjectFlow106_LiteralBoolean107.SetVisibility(VisibilityKind.public_);
							Operation_RequiredInterface_DelegationChain_B_setPActivity_ObjectFlow106_LiteralBoolean107.SetValue(true);
						Operation_RequiredInterface_DelegationChain_B_setPActivity_ObjectFlow106.SetGuard(Operation_RequiredInterface_DelegationChain_B_setPActivity_ObjectFlow106_LiteralBoolean107);
					Operation_RequiredInterface_DelegationChain_B_setPActivity.AddEdge(Operation_RequiredInterface_DelegationChain_B_setPActivity_ObjectFlow106);
				Operation_RequiredInterface_DelegationChain_B.AddOwnedBehavior(Operation_RequiredInterface_DelegationChain_B_setPActivity);
					Operation_RequiredInterface_DelegationChain_B_IRealization.SetName("IRealization");
					Operation_RequiredInterface_DelegationChain_B_IRealization.SetVisibility(VisibilityKind.public_);
					Operation_RequiredInterface_DelegationChain_B_IRealization.SetContract(Operation_RequiredInterface_DelegationChain_I);
					
				Operation_RequiredInterface_DelegationChain_B.AddInterfaceRealization(Operation_RequiredInterface_DelegationChain_B_IRealization);
				
					// Operation setP_Integer
					Operation_RequiredInterface_DelegationChain_B_setP_Integer.SetName("setP_Integer");
					Operation_RequiredInterface_DelegationChain_B_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						Operation_RequiredInterface_DelegationChain_B_setP_Integer_v.SetName("v");
						Operation_RequiredInterface_DelegationChain_B_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_DelegationChain_B_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_RequiredInterface_DelegationChain_B_setP_Integer.AddOwnedParameter(Operation_RequiredInterface_DelegationChain_B_setP_Integer_v);
					Operation_RequiredInterface_DelegationChain_B_setP_Integer.AddMethod(Operation_RequiredInterface_DelegationChain_B_setPActivity);
				Operation_RequiredInterface_DelegationChain_B.AddOwnedOperation(Operation_RequiredInterface_DelegationChain_B_setP_Integer);
			Operation_RequiredInterface_DelegationChain.AddPackagedElement(Operation_RequiredInterface_DelegationChain_B);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // Operation_RequiredInterface_DelegationChainModel
}
