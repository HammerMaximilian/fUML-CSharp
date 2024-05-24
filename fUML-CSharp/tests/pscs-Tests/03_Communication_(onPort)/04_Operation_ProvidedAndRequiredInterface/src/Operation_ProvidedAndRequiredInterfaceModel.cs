/*
 * Operation_ProvidedAndRequiredInterfaceModel.cs
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

namespace Operation_ProvidedAndRequiredInterface
{
	public class Operation_ProvidedAndRequiredInterfaceModel : InMemoryModel
	{
		private static Operation_ProvidedAndRequiredInterfaceModel? instance;

		/*
		 * Model Operation_ProvidedAndRequiredInterface
		 */
		public Package Operation_ProvidedAndRequiredInterface = new();
			public Association Operation_ProvidedAndRequiredInterface_R = new();
				public Property Operation_ProvidedAndRequiredInterface_R_y = new();
				public Property Operation_ProvidedAndRequiredInterface_R_x = new();
			public Association Operation_ProvidedAndRequiredInterface_S = new();
				public Property Operation_ProvidedAndRequiredInterface_S_x = new();
				public Property Operation_ProvidedAndRequiredInterface_S_y = new();
			public Class_ Operation_ProvidedAndRequiredInterface_C = new();
				public Operation Operation_ProvidedAndRequiredInterface_C_setP_Integer = new();
					public Parameter Operation_ProvidedAndRequiredInterface_C_setP_Integer_v = new();
				public Port Operation_ProvidedAndRequiredInterface_C_q = new();
				public InterfaceRealization Operation_ProvidedAndRequiredInterface_C_IRealization = new();
				public Activity Operation_ProvidedAndRequiredInterface_C_setPActivity = new();
					public ObjectFlow Operation_ProvidedAndRequiredInterface_C_setPActivity_ObjectFlow0 = new();
						public LiteralBoolean Operation_ProvidedAndRequiredInterface_C_setPActivity_ObjectFlow0_LiteralBoolean1 = new();
						public LiteralInteger Operation_ProvidedAndRequiredInterface_C_setPActivity_ObjectFlow0_LiteralInteger2 = new();
					public ActivityParameterNode Operation_ProvidedAndRequiredInterface_C_setPActivity_vParameterNode = new();
						public LiteralInteger Operation_ProvidedAndRequiredInterface_C_setPActivity_vParameterNode_LiteralInteger3 = new();
					public ObjectFlow Operation_ProvidedAndRequiredInterface_C_setPActivity_ObjectFlow4 = new();
						public LiteralInteger Operation_ProvidedAndRequiredInterface_C_setPActivity_ObjectFlow4_LiteralInteger5 = new();
						public LiteralBoolean Operation_ProvidedAndRequiredInterface_C_setPActivity_ObjectFlow4_LiteralBoolean6 = new();
					public ReadSelfAction Operation_ProvidedAndRequiredInterface_C_setPActivity_this = new();
						public OutputPin Operation_ProvidedAndRequiredInterface_C_setPActivity_this_result = new();
							public LiteralInteger Operation_ProvidedAndRequiredInterface_C_setPActivity_this_result_LiteralInteger7 = new();
							public LiteralUnlimitedNatural Operation_ProvidedAndRequiredInterface_C_setPActivity_this_result_LiteralUnlimitedNatural8 = new();
					public Parameter Operation_ProvidedAndRequiredInterface_C_setPActivity_v = new();
					public CallOperationAction Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q = new();
						public InputPin Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q_target = new();
							public LiteralInteger Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q_target_LiteralInteger9 = new();
							public LiteralUnlimitedNatural Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q_target_LiteralUnlimitedNatural10 = new();
						public InputPin Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q_v = new();
							public LiteralInteger Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q_v_LiteralInteger11 = new();
							public LiteralInteger Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q_v_LiteralInteger12 = new();
							public LiteralUnlimitedNatural Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q_v_LiteralUnlimitedNatural13 = new();
			public Interface Operation_ProvidedAndRequiredInterface_I = new();
				public Operation Operation_ProvidedAndRequiredInterface_I_setP_Integer = new();
					public Parameter Operation_ProvidedAndRequiredInterface_I_setP_Integer_v = new();
			public Class_ Operation_ProvidedAndRequiredInterface_D = new();
				public Operation Operation_ProvidedAndRequiredInterface_D_D_D = new();
					public Parameter Operation_ProvidedAndRequiredInterface_D_D_D_result = new();
				public Property Operation_ProvidedAndRequiredInterface_D_a = new();
				public Property Operation_ProvidedAndRequiredInterface_D_e = new();
				public Connector Operation_ProvidedAndRequiredInterface_D_s = new();
					public ConnectorEnd Operation_ProvidedAndRequiredInterface_D_s_ConnectorEnd14 = new();
					public ConnectorEnd Operation_ProvidedAndRequiredInterface_D_s_ConnectorEnd15 = new();
			public Activity Operation_ProvidedAndRequiredInterface_main = new();
				public ObjectFlow Operation_ProvidedAndRequiredInterface_main_ObjectFlow16 = new();
					public LiteralBoolean Operation_ProvidedAndRequiredInterface_main_ObjectFlow16_LiteralBoolean17 = new();
					public LiteralInteger Operation_ProvidedAndRequiredInterface_main_ObjectFlow16_LiteralInteger18 = new();
				public ObjectFlow Operation_ProvidedAndRequiredInterface_main_ObjectFlow19 = new();
					public LiteralInteger Operation_ProvidedAndRequiredInterface_main_ObjectFlow19_LiteralInteger20 = new();
					public LiteralBoolean Operation_ProvidedAndRequiredInterface_main_ObjectFlow19_LiteralBoolean21 = new();
				public ObjectFlow Operation_ProvidedAndRequiredInterface_main_ObjectFlow22 = new();
					public LiteralBoolean Operation_ProvidedAndRequiredInterface_main_ObjectFlow22_LiteralBoolean23 = new();
					public LiteralInteger Operation_ProvidedAndRequiredInterface_main_ObjectFlow22_LiteralInteger24 = new();
				public ForkNode Operation_ProvidedAndRequiredInterface_main_Fork_d = new();
				public CallOperationAction Operation_ProvidedAndRequiredInterface_main_Call_setP_ = new();
					public InputPin Operation_ProvidedAndRequiredInterface_main_Call_setP__v = new();
						public LiteralInteger Operation_ProvidedAndRequiredInterface_main_Call_setP__v_LiteralInteger25 = new();
						public LiteralUnlimitedNatural Operation_ProvidedAndRequiredInterface_main_Call_setP__v_LiteralUnlimitedNatural26 = new();
						public LiteralInteger Operation_ProvidedAndRequiredInterface_main_Call_setP__v_LiteralInteger27 = new();
					public InputPin Operation_ProvidedAndRequiredInterface_main_Call_setP__target = new();
						public LiteralInteger Operation_ProvidedAndRequiredInterface_main_Call_setP__target_LiteralInteger28 = new();
						public LiteralUnlimitedNatural Operation_ProvidedAndRequiredInterface_main_Call_setP__target_LiteralUnlimitedNatural29 = new();
				public ObjectFlow Operation_ProvidedAndRequiredInterface_main_ObjectFlow30 = new();
					public LiteralInteger Operation_ProvidedAndRequiredInterface_main_ObjectFlow30_LiteralInteger31 = new();
					public LiteralBoolean Operation_ProvidedAndRequiredInterface_main_ObjectFlow30_LiteralBoolean32 = new();
				public CallBehaviorAction Operation_ProvidedAndRequiredInterface_main_Call_testP = new();
					public InputPin Operation_ProvidedAndRequiredInterface_main_Call_testP_p = new();
						public LiteralInteger Operation_ProvidedAndRequiredInterface_main_Call_testP_p_LiteralInteger33 = new();
						public LiteralInteger Operation_ProvidedAndRequiredInterface_main_Call_testP_p_LiteralInteger34 = new();
						public LiteralUnlimitedNatural Operation_ProvidedAndRequiredInterface_main_Call_testP_p_LiteralUnlimitedNatural35 = new();
				public ObjectFlow Operation_ProvidedAndRequiredInterface_main_ObjectFlow36 = new();
					public LiteralBoolean Operation_ProvidedAndRequiredInterface_main_ObjectFlow36_LiteralBoolean37 = new();
					public LiteralInteger Operation_ProvidedAndRequiredInterface_main_ObjectFlow36_LiteralInteger38 = new();
				public OpaqueBehavior Operation_ProvidedAndRequiredInterface_main_testP = new();
					public Parameter Operation_ProvidedAndRequiredInterface_main_testP_p = new();
				public ObjectFlow Operation_ProvidedAndRequiredInterface_main_ObjectFlow39 = new();
					public LiteralBoolean Operation_ProvidedAndRequiredInterface_main_ObjectFlow39_LiteralBoolean40 = new();
					public LiteralInteger Operation_ProvidedAndRequiredInterface_main_ObjectFlow39_LiteralInteger41 = new();
				public ReadStructuralFeatureAction Operation_ProvidedAndRequiredInterface_main_Read_a_b = new();
					public InputPin Operation_ProvidedAndRequiredInterface_main_Read_a_b_object = new();
						public LiteralInteger Operation_ProvidedAndRequiredInterface_main_Read_a_b_object_LiteralInteger42 = new();
						public LiteralUnlimitedNatural Operation_ProvidedAndRequiredInterface_main_Read_a_b_object_LiteralUnlimitedNatural43 = new();
					public OutputPin Operation_ProvidedAndRequiredInterface_main_Read_a_b_result = new();
						public LiteralUnlimitedNatural Operation_ProvidedAndRequiredInterface_main_Read_a_b_result_LiteralUnlimitedNatural44 = new();
						public LiteralInteger Operation_ProvidedAndRequiredInterface_main_Read_a_b_result_LiteralInteger45 = new();
				public CallOperationAction Operation_ProvidedAndRequiredInterface_main_D_ = new();
					public InputPin Operation_ProvidedAndRequiredInterface_main_D__target = new();
						public LiteralUnlimitedNatural Operation_ProvidedAndRequiredInterface_main_D__target_LiteralUnlimitedNatural46 = new();
						public LiteralInteger Operation_ProvidedAndRequiredInterface_main_D__target_LiteralInteger47 = new();
					public OutputPin Operation_ProvidedAndRequiredInterface_main_D__result = new();
						public LiteralInteger Operation_ProvidedAndRequiredInterface_main_D__result_LiteralInteger48 = new();
						public LiteralUnlimitedNatural Operation_ProvidedAndRequiredInterface_main_D__result_LiteralUnlimitedNatural49 = new();
						public LiteralInteger Operation_ProvidedAndRequiredInterface_main_D__result_LiteralInteger50 = new();
				public ControlFlow Operation_ProvidedAndRequiredInterface_main_ControlFlow51 = new();
				public ObjectFlow Operation_ProvidedAndRequiredInterface_main_ObjectFlow52 = new();
					public LiteralInteger Operation_ProvidedAndRequiredInterface_main_ObjectFlow52_LiteralInteger53 = new();
					public LiteralBoolean Operation_ProvidedAndRequiredInterface_main_ObjectFlow52_LiteralBoolean54 = new();
				public ObjectFlow Operation_ProvidedAndRequiredInterface_main_ObjectFlow55 = new();
					public LiteralBoolean Operation_ProvidedAndRequiredInterface_main_ObjectFlow55_LiteralBoolean56 = new();
					public LiteralInteger Operation_ProvidedAndRequiredInterface_main_ObjectFlow55_LiteralInteger57 = new();
				public ReadStructuralFeatureAction Operation_ProvidedAndRequiredInterface_main_Read_b_p = new();
					public OutputPin Operation_ProvidedAndRequiredInterface_main_Read_b_p_result = new();
						public LiteralInteger Operation_ProvidedAndRequiredInterface_main_Read_b_p_result_LiteralInteger58 = new();
						public LiteralUnlimitedNatural Operation_ProvidedAndRequiredInterface_main_Read_b_p_result_LiteralUnlimitedNatural59 = new();
					public InputPin Operation_ProvidedAndRequiredInterface_main_Read_b_p_object = new();
						public LiteralUnlimitedNatural Operation_ProvidedAndRequiredInterface_main_Read_b_p_object_LiteralUnlimitedNatural60 = new();
						public LiteralInteger Operation_ProvidedAndRequiredInterface_main_Read_b_p_object_LiteralInteger61 = new();
				public ObjectFlow Operation_ProvidedAndRequiredInterface_main_ObjectFlow62 = new();
					public LiteralInteger Operation_ProvidedAndRequiredInterface_main_ObjectFlow62_LiteralInteger63 = new();
					public LiteralBoolean Operation_ProvidedAndRequiredInterface_main_ObjectFlow62_LiteralBoolean64 = new();
				public ReadStructuralFeatureAction Operation_ProvidedAndRequiredInterface_main_Read_e_c = new();
					public InputPin Operation_ProvidedAndRequiredInterface_main_Read_e_c_object = new();
						public LiteralInteger Operation_ProvidedAndRequiredInterface_main_Read_e_c_object_LiteralInteger65 = new();
						public LiteralUnlimitedNatural Operation_ProvidedAndRequiredInterface_main_Read_e_c_object_LiteralUnlimitedNatural66 = new();
					public OutputPin Operation_ProvidedAndRequiredInterface_main_Read_e_c_result = new();
						public LiteralInteger Operation_ProvidedAndRequiredInterface_main_Read_e_c_result_LiteralInteger67 = new();
						public LiteralUnlimitedNatural Operation_ProvidedAndRequiredInterface_main_Read_e_c_result_LiteralUnlimitedNatural68 = new();
				public ValueSpecificationAction Operation_ProvidedAndRequiredInterface_main_Value_4 = new();
					public LiteralInteger Operation_ProvidedAndRequiredInterface_main_Value_4_LiteralInteger69 = new();
					public OutputPin Operation_ProvidedAndRequiredInterface_main_Value_4_result = new();
						public LiteralInteger Operation_ProvidedAndRequiredInterface_main_Value_4_result_LiteralInteger70 = new();
						public LiteralUnlimitedNatural Operation_ProvidedAndRequiredInterface_main_Value_4_result_LiteralUnlimitedNatural71 = new();
				public ReadStructuralFeatureAction Operation_ProvidedAndRequiredInterface_main_Read_d_e = new();
					public OutputPin Operation_ProvidedAndRequiredInterface_main_Read_d_e_result = new();
						public LiteralInteger Operation_ProvidedAndRequiredInterface_main_Read_d_e_result_LiteralInteger72 = new();
						public LiteralUnlimitedNatural Operation_ProvidedAndRequiredInterface_main_Read_d_e_result_LiteralUnlimitedNatural73 = new();
					public InputPin Operation_ProvidedAndRequiredInterface_main_Read_d_e_object = new();
						public LiteralUnlimitedNatural Operation_ProvidedAndRequiredInterface_main_Read_d_e_object_LiteralUnlimitedNatural74 = new();
						public LiteralInteger Operation_ProvidedAndRequiredInterface_main_Read_d_e_object_LiteralInteger75 = new();
				public CreateObjectAction Operation_ProvidedAndRequiredInterface_main_Create_D = new();
					public OutputPin Operation_ProvidedAndRequiredInterface_main_Create_D_result = new();
						public LiteralUnlimitedNatural Operation_ProvidedAndRequiredInterface_main_Create_D_result_LiteralUnlimitedNatural76 = new();
						public LiteralInteger Operation_ProvidedAndRequiredInterface_main_Create_D_result_LiteralInteger77 = new();
				public ObjectFlow Operation_ProvidedAndRequiredInterface_main_ObjectFlow78 = new();
					public LiteralInteger Operation_ProvidedAndRequiredInterface_main_ObjectFlow78_LiteralInteger79 = new();
					public LiteralBoolean Operation_ProvidedAndRequiredInterface_main_ObjectFlow78_LiteralBoolean80 = new();
				public ReadStructuralFeatureAction Operation_ProvidedAndRequiredInterface_main_Read_d_a = new();
					public InputPin Operation_ProvidedAndRequiredInterface_main_Read_d_a_object = new();
						public LiteralUnlimitedNatural Operation_ProvidedAndRequiredInterface_main_Read_d_a_object_LiteralUnlimitedNatural81 = new();
						public LiteralInteger Operation_ProvidedAndRequiredInterface_main_Read_d_a_object_LiteralInteger82 = new();
					public OutputPin Operation_ProvidedAndRequiredInterface_main_Read_d_a_result = new();
						public LiteralUnlimitedNatural Operation_ProvidedAndRequiredInterface_main_Read_d_a_result_LiteralUnlimitedNatural83 = new();
						public LiteralInteger Operation_ProvidedAndRequiredInterface_main_Read_d_a_result_LiteralInteger84 = new();
			public Class_ Operation_ProvidedAndRequiredInterface_A = new();
				public Property Operation_ProvidedAndRequiredInterface_A_b = new();
				public Port Operation_ProvidedAndRequiredInterface_A_q = new();
				public Operation Operation_ProvidedAndRequiredInterface_A_setP_Integer = new();
					public Parameter Operation_ProvidedAndRequiredInterface_A_setP_Integer_v = new();
				public Activity Operation_ProvidedAndRequiredInterface_A_setPActivity = new();
					public ActivityParameterNode Operation_ProvidedAndRequiredInterface_A_setPActivity_vParameterNode = new();
						public LiteralInteger Operation_ProvidedAndRequiredInterface_A_setPActivity_vParameterNode_LiteralInteger85 = new();
					public ReadSelfAction Operation_ProvidedAndRequiredInterface_A_setPActivity_this = new();
						public OutputPin Operation_ProvidedAndRequiredInterface_A_setPActivity_this_result = new();
							public LiteralUnlimitedNatural Operation_ProvidedAndRequiredInterface_A_setPActivity_this_result_LiteralUnlimitedNatural86 = new();
							public LiteralInteger Operation_ProvidedAndRequiredInterface_A_setPActivity_this_result_LiteralInteger87 = new();
					public ObjectFlow Operation_ProvidedAndRequiredInterface_A_setPActivity_ObjectFlow88 = new();
						public LiteralBoolean Operation_ProvidedAndRequiredInterface_A_setPActivity_ObjectFlow88_LiteralBoolean89 = new();
						public LiteralInteger Operation_ProvidedAndRequiredInterface_A_setPActivity_ObjectFlow88_LiteralInteger90 = new();
					public ObjectFlow Operation_ProvidedAndRequiredInterface_A_setPActivity_ObjectFlow91 = new();
						public LiteralInteger Operation_ProvidedAndRequiredInterface_A_setPActivity_ObjectFlow91_LiteralInteger92 = new();
						public LiteralBoolean Operation_ProvidedAndRequiredInterface_A_setPActivity_ObjectFlow91_LiteralBoolean93 = new();
					public Parameter Operation_ProvidedAndRequiredInterface_A_setPActivity_v = new();
					public CallOperationAction Operation_ProvidedAndRequiredInterface_A_setPActivity_Call_I_setP_on_q = new();
						public InputPin Operation_ProvidedAndRequiredInterface_A_setPActivity_Call_I_setP_on_q_v = new();
							public LiteralUnlimitedNatural Operation_ProvidedAndRequiredInterface_A_setPActivity_Call_I_setP_on_q_v_LiteralUnlimitedNatural94 = new();
							public LiteralInteger Operation_ProvidedAndRequiredInterface_A_setPActivity_Call_I_setP_on_q_v_LiteralInteger95 = new();
							public LiteralInteger Operation_ProvidedAndRequiredInterface_A_setPActivity_Call_I_setP_on_q_v_LiteralInteger96 = new();
						public InputPin Operation_ProvidedAndRequiredInterface_A_setPActivity_Call_I_setP_on_q_target = new();
							public LiteralInteger Operation_ProvidedAndRequiredInterface_A_setPActivity_Call_I_setP_on_q_target_LiteralInteger97 = new();
							public LiteralUnlimitedNatural Operation_ProvidedAndRequiredInterface_A_setPActivity_Call_I_setP_on_q_target_LiteralUnlimitedNatural98 = new();
				public Connector Operation_ProvidedAndRequiredInterface_A_r = new();
					public ConnectorEnd Operation_ProvidedAndRequiredInterface_A_r_ConnectorEnd99 = new();
					public ConnectorEnd Operation_ProvidedAndRequiredInterface_A_r_ConnectorEnd100 = new();
			public Class_ Operation_ProvidedAndRequiredInterface_E = new();
				public Property Operation_ProvidedAndRequiredInterface_E_c = new();
				public Connector Operation_ProvidedAndRequiredInterface_E_s = new();
					public ConnectorEnd Operation_ProvidedAndRequiredInterface_E_s_ConnectorEnd101 = new();
					public ConnectorEnd Operation_ProvidedAndRequiredInterface_E_s_ConnectorEnd102 = new();
				public Port Operation_ProvidedAndRequiredInterface_E_q = new();
			public Class_ Operation_ProvidedAndRequiredInterface_IImpl = new();
				public InterfaceRealization Operation_ProvidedAndRequiredInterface_IImpl_IRealization = new();
				public Operation Operation_ProvidedAndRequiredInterface_IImpl_setP_Integer = new();
					public Parameter Operation_ProvidedAndRequiredInterface_IImpl_setP_Integer_v = new();
			public Usage Operation_ProvidedAndRequiredInterface_IUsageIProvReq = new();
			public Class_ Operation_ProvidedAndRequiredInterface_IProvReq = new();
				public Operation Operation_ProvidedAndRequiredInterface_IProvReq_setP_Integer = new();
					public Parameter Operation_ProvidedAndRequiredInterface_IProvReq_setP_Integer_v = new();
				public Generalization Operation_ProvidedAndRequiredInterface_IProvReq_Generalization103 = new();
			public Class_ Operation_ProvidedAndRequiredInterface_B = new();
				public Activity Operation_ProvidedAndRequiredInterface_B_setPActivity = new();
					public ObjectFlow Operation_ProvidedAndRequiredInterface_B_setPActivity_ObjectFlow104 = new();
						public LiteralInteger Operation_ProvidedAndRequiredInterface_B_setPActivity_ObjectFlow104_LiteralInteger105 = new();
						public LiteralBoolean Operation_ProvidedAndRequiredInterface_B_setPActivity_ObjectFlow104_LiteralBoolean106 = new();
					public ObjectFlow Operation_ProvidedAndRequiredInterface_B_setPActivity_ObjectFlow107 = new();
						public LiteralBoolean Operation_ProvidedAndRequiredInterface_B_setPActivity_ObjectFlow107_LiteralBoolean108 = new();
						public LiteralInteger Operation_ProvidedAndRequiredInterface_B_setPActivity_ObjectFlow107_LiteralInteger109 = new();
					public Parameter Operation_ProvidedAndRequiredInterface_B_setPActivity_v = new();
					public ActivityParameterNode Operation_ProvidedAndRequiredInterface_B_setPActivity_vParameterNode = new();
						public LiteralInteger Operation_ProvidedAndRequiredInterface_B_setPActivity_vParameterNode_LiteralInteger110 = new();
					public AddStructuralFeatureValueAction Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p = new();
						public InputPin Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p_value = new();
							public LiteralInteger Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p_value_LiteralInteger111 = new();
							public LiteralUnlimitedNatural Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p_value_LiteralUnlimitedNatural112 = new();
						public InputPin Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p_object = new();
							public LiteralInteger Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p_object_LiteralInteger113 = new();
							public LiteralUnlimitedNatural Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p_object_LiteralUnlimitedNatural114 = new();
						public OutputPin Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p_result = new();
							public LiteralInteger Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p_result_LiteralInteger115 = new();
							public LiteralUnlimitedNatural Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p_result_LiteralUnlimitedNatural116 = new();
					public ReadSelfAction Operation_ProvidedAndRequiredInterface_B_setPActivity_this = new();
						public OutputPin Operation_ProvidedAndRequiredInterface_B_setPActivity_this_result = new();
							public LiteralUnlimitedNatural Operation_ProvidedAndRequiredInterface_B_setPActivity_this_result_LiteralUnlimitedNatural117 = new();
							public LiteralInteger Operation_ProvidedAndRequiredInterface_B_setPActivity_this_result_LiteralInteger118 = new();
				public Property Operation_ProvidedAndRequiredInterface_B_p = new();
				public InterfaceRealization Operation_ProvidedAndRequiredInterface_B_IRealization = new();
				public Operation Operation_ProvidedAndRequiredInterface_B_setP_Integer = new();
					public Parameter Operation_ProvidedAndRequiredInterface_B_setP_Integer_v = new();

		public static Operation_ProvidedAndRequiredInterfaceModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public Operation_ProvidedAndRequiredInterfaceModel()
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
			 * Model Operation_ProvidedAndRequiredInterface
			 */
			AddToElementRepository("Operation_ProvidedAndRequiredInterface", Operation_ProvidedAndRequiredInterface);
				AddToElementRepository("R", Operation_ProvidedAndRequiredInterface_R);
					AddToElementRepository("y", Operation_ProvidedAndRequiredInterface_R_y);
					AddToElementRepository("x", Operation_ProvidedAndRequiredInterface_R_x);
				AddToElementRepository("S", Operation_ProvidedAndRequiredInterface_S);
					AddToElementRepository("x", Operation_ProvidedAndRequiredInterface_S_x);
					AddToElementRepository("y", Operation_ProvidedAndRequiredInterface_S_y);
				AddToElementRepository("C", Operation_ProvidedAndRequiredInterface_C);
					AddToElementRepository("setP_Integer", Operation_ProvidedAndRequiredInterface_C_setP_Integer);
						AddToElementRepository("v", Operation_ProvidedAndRequiredInterface_C_setP_Integer_v);
					AddToElementRepository("q", Operation_ProvidedAndRequiredInterface_C_q);
					AddToElementRepository("IRealization", Operation_ProvidedAndRequiredInterface_C_IRealization);
					AddToElementRepository("setPActivity", Operation_ProvidedAndRequiredInterface_C_setPActivity);
						AddToElementRepository("ObjectFlow0", Operation_ProvidedAndRequiredInterface_C_setPActivity_ObjectFlow0);
							AddToElementRepository("LiteralBoolean1", Operation_ProvidedAndRequiredInterface_C_setPActivity_ObjectFlow0_LiteralBoolean1);
							AddToElementRepository("LiteralInteger2", Operation_ProvidedAndRequiredInterface_C_setPActivity_ObjectFlow0_LiteralInteger2);
						AddToElementRepository("vParameterNode", Operation_ProvidedAndRequiredInterface_C_setPActivity_vParameterNode);
							AddToElementRepository("LiteralInteger3", Operation_ProvidedAndRequiredInterface_C_setPActivity_vParameterNode_LiteralInteger3);
						AddToElementRepository("ObjectFlow4", Operation_ProvidedAndRequiredInterface_C_setPActivity_ObjectFlow4);
							AddToElementRepository("LiteralInteger5", Operation_ProvidedAndRequiredInterface_C_setPActivity_ObjectFlow4_LiteralInteger5);
							AddToElementRepository("LiteralBoolean6", Operation_ProvidedAndRequiredInterface_C_setPActivity_ObjectFlow4_LiteralBoolean6);
						AddToElementRepository("this", Operation_ProvidedAndRequiredInterface_C_setPActivity_this);
							AddToElementRepository("result", Operation_ProvidedAndRequiredInterface_C_setPActivity_this_result);
								AddToElementRepository("LiteralInteger7", Operation_ProvidedAndRequiredInterface_C_setPActivity_this_result_LiteralInteger7);
								AddToElementRepository("LiteralUnlimitedNatural8", Operation_ProvidedAndRequiredInterface_C_setPActivity_this_result_LiteralUnlimitedNatural8);
						AddToElementRepository("v", Operation_ProvidedAndRequiredInterface_C_setPActivity_v);
						AddToElementRepository("Call I::setP on q", Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q);
							AddToElementRepository("target", Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q_target);
								AddToElementRepository("LiteralInteger9", Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q_target_LiteralInteger9);
								AddToElementRepository("LiteralUnlimitedNatural10", Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q_target_LiteralUnlimitedNatural10);
							AddToElementRepository("v", Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q_v);
								AddToElementRepository("LiteralInteger11", Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q_v_LiteralInteger11);
								AddToElementRepository("LiteralInteger12", Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q_v_LiteralInteger12);
								AddToElementRepository("LiteralUnlimitedNatural13", Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q_v_LiteralUnlimitedNatural13);
				AddToElementRepository("I", Operation_ProvidedAndRequiredInterface_I);
					AddToElementRepository("setP_Integer", Operation_ProvidedAndRequiredInterface_I_setP_Integer);
						AddToElementRepository("v", Operation_ProvidedAndRequiredInterface_I_setP_Integer_v);
				AddToElementRepository("D", Operation_ProvidedAndRequiredInterface_D);
					AddToElementRepository("D_D", Operation_ProvidedAndRequiredInterface_D_D_D);
						AddToElementRepository("result", Operation_ProvidedAndRequiredInterface_D_D_D_result);
					AddToElementRepository("a", Operation_ProvidedAndRequiredInterface_D_a);
					AddToElementRepository("e", Operation_ProvidedAndRequiredInterface_D_e);
					AddToElementRepository("s", Operation_ProvidedAndRequiredInterface_D_s);
						AddToElementRepository("ConnectorEnd14", Operation_ProvidedAndRequiredInterface_D_s_ConnectorEnd14);
						AddToElementRepository("ConnectorEnd15", Operation_ProvidedAndRequiredInterface_D_s_ConnectorEnd15);
				AddToElementRepository("main", Operation_ProvidedAndRequiredInterface_main);
					AddToElementRepository("ObjectFlow16", Operation_ProvidedAndRequiredInterface_main_ObjectFlow16);
						AddToElementRepository("LiteralBoolean17", Operation_ProvidedAndRequiredInterface_main_ObjectFlow16_LiteralBoolean17);
						AddToElementRepository("LiteralInteger18", Operation_ProvidedAndRequiredInterface_main_ObjectFlow16_LiteralInteger18);
					AddToElementRepository("ObjectFlow19", Operation_ProvidedAndRequiredInterface_main_ObjectFlow19);
						AddToElementRepository("LiteralInteger20", Operation_ProvidedAndRequiredInterface_main_ObjectFlow19_LiteralInteger20);
						AddToElementRepository("LiteralBoolean21", Operation_ProvidedAndRequiredInterface_main_ObjectFlow19_LiteralBoolean21);
					AddToElementRepository("ObjectFlow22", Operation_ProvidedAndRequiredInterface_main_ObjectFlow22);
						AddToElementRepository("LiteralBoolean23", Operation_ProvidedAndRequiredInterface_main_ObjectFlow22_LiteralBoolean23);
						AddToElementRepository("LiteralInteger24", Operation_ProvidedAndRequiredInterface_main_ObjectFlow22_LiteralInteger24);
					AddToElementRepository("Fork d", Operation_ProvidedAndRequiredInterface_main_Fork_d);
					AddToElementRepository("Call setP()", Operation_ProvidedAndRequiredInterface_main_Call_setP_);
						AddToElementRepository("v", Operation_ProvidedAndRequiredInterface_main_Call_setP__v);
							AddToElementRepository("LiteralInteger25", Operation_ProvidedAndRequiredInterface_main_Call_setP__v_LiteralInteger25);
							AddToElementRepository("LiteralUnlimitedNatural26", Operation_ProvidedAndRequiredInterface_main_Call_setP__v_LiteralUnlimitedNatural26);
							AddToElementRepository("LiteralInteger27", Operation_ProvidedAndRequiredInterface_main_Call_setP__v_LiteralInteger27);
						AddToElementRepository("target", Operation_ProvidedAndRequiredInterface_main_Call_setP__target);
							AddToElementRepository("LiteralInteger28", Operation_ProvidedAndRequiredInterface_main_Call_setP__target_LiteralInteger28);
							AddToElementRepository("LiteralUnlimitedNatural29", Operation_ProvidedAndRequiredInterface_main_Call_setP__target_LiteralUnlimitedNatural29);
					AddToElementRepository("ObjectFlow30", Operation_ProvidedAndRequiredInterface_main_ObjectFlow30);
						AddToElementRepository("LiteralInteger31", Operation_ProvidedAndRequiredInterface_main_ObjectFlow30_LiteralInteger31);
						AddToElementRepository("LiteralBoolean32", Operation_ProvidedAndRequiredInterface_main_ObjectFlow30_LiteralBoolean32);
					AddToElementRepository("Call testP", Operation_ProvidedAndRequiredInterface_main_Call_testP);
						AddToElementRepository("p", Operation_ProvidedAndRequiredInterface_main_Call_testP_p);
							AddToElementRepository("LiteralInteger33", Operation_ProvidedAndRequiredInterface_main_Call_testP_p_LiteralInteger33);
							AddToElementRepository("LiteralInteger34", Operation_ProvidedAndRequiredInterface_main_Call_testP_p_LiteralInteger34);
							AddToElementRepository("LiteralUnlimitedNatural35", Operation_ProvidedAndRequiredInterface_main_Call_testP_p_LiteralUnlimitedNatural35);
					AddToElementRepository("ObjectFlow36", Operation_ProvidedAndRequiredInterface_main_ObjectFlow36);
						AddToElementRepository("LiteralBoolean37", Operation_ProvidedAndRequiredInterface_main_ObjectFlow36_LiteralBoolean37);
						AddToElementRepository("LiteralInteger38", Operation_ProvidedAndRequiredInterface_main_ObjectFlow36_LiteralInteger38);
					AddToElementRepository("testP", Operation_ProvidedAndRequiredInterface_main_testP);
						AddToElementRepository("p", Operation_ProvidedAndRequiredInterface_main_testP_p);
					AddToElementRepository("ObjectFlow39", Operation_ProvidedAndRequiredInterface_main_ObjectFlow39);
						AddToElementRepository("LiteralBoolean40", Operation_ProvidedAndRequiredInterface_main_ObjectFlow39_LiteralBoolean40);
						AddToElementRepository("LiteralInteger41", Operation_ProvidedAndRequiredInterface_main_ObjectFlow39_LiteralInteger41);
					AddToElementRepository("Read a.b", Operation_ProvidedAndRequiredInterface_main_Read_a_b);
						AddToElementRepository("object", Operation_ProvidedAndRequiredInterface_main_Read_a_b_object);
							AddToElementRepository("LiteralInteger42", Operation_ProvidedAndRequiredInterface_main_Read_a_b_object_LiteralInteger42);
							AddToElementRepository("LiteralUnlimitedNatural43", Operation_ProvidedAndRequiredInterface_main_Read_a_b_object_LiteralUnlimitedNatural43);
						AddToElementRepository("result", Operation_ProvidedAndRequiredInterface_main_Read_a_b_result);
							AddToElementRepository("LiteralUnlimitedNatural44", Operation_ProvidedAndRequiredInterface_main_Read_a_b_result_LiteralUnlimitedNatural44);
							AddToElementRepository("LiteralInteger45", Operation_ProvidedAndRequiredInterface_main_Read_a_b_result_LiteralInteger45);
					AddToElementRepository("D()", Operation_ProvidedAndRequiredInterface_main_D_);
						AddToElementRepository("target", Operation_ProvidedAndRequiredInterface_main_D__target);
							AddToElementRepository("LiteralUnlimitedNatural46", Operation_ProvidedAndRequiredInterface_main_D__target_LiteralUnlimitedNatural46);
							AddToElementRepository("LiteralInteger47", Operation_ProvidedAndRequiredInterface_main_D__target_LiteralInteger47);
						AddToElementRepository("result", Operation_ProvidedAndRequiredInterface_main_D__result);
							AddToElementRepository("LiteralInteger48", Operation_ProvidedAndRequiredInterface_main_D__result_LiteralInteger48);
							AddToElementRepository("LiteralUnlimitedNatural49", Operation_ProvidedAndRequiredInterface_main_D__result_LiteralUnlimitedNatural49);
							AddToElementRepository("LiteralInteger50", Operation_ProvidedAndRequiredInterface_main_D__result_LiteralInteger50);
					AddToElementRepository("ControlFlow51", Operation_ProvidedAndRequiredInterface_main_ControlFlow51);
					AddToElementRepository("ObjectFlow52", Operation_ProvidedAndRequiredInterface_main_ObjectFlow52);
						AddToElementRepository("LiteralInteger53", Operation_ProvidedAndRequiredInterface_main_ObjectFlow52_LiteralInteger53);
						AddToElementRepository("LiteralBoolean54", Operation_ProvidedAndRequiredInterface_main_ObjectFlow52_LiteralBoolean54);
					AddToElementRepository("ObjectFlow55", Operation_ProvidedAndRequiredInterface_main_ObjectFlow55);
						AddToElementRepository("LiteralBoolean56", Operation_ProvidedAndRequiredInterface_main_ObjectFlow55_LiteralBoolean56);
						AddToElementRepository("LiteralInteger57", Operation_ProvidedAndRequiredInterface_main_ObjectFlow55_LiteralInteger57);
					AddToElementRepository("Read b.p", Operation_ProvidedAndRequiredInterface_main_Read_b_p);
						AddToElementRepository("result", Operation_ProvidedAndRequiredInterface_main_Read_b_p_result);
							AddToElementRepository("LiteralInteger58", Operation_ProvidedAndRequiredInterface_main_Read_b_p_result_LiteralInteger58);
							AddToElementRepository("LiteralUnlimitedNatural59", Operation_ProvidedAndRequiredInterface_main_Read_b_p_result_LiteralUnlimitedNatural59);
						AddToElementRepository("object", Operation_ProvidedAndRequiredInterface_main_Read_b_p_object);
							AddToElementRepository("LiteralUnlimitedNatural60", Operation_ProvidedAndRequiredInterface_main_Read_b_p_object_LiteralUnlimitedNatural60);
							AddToElementRepository("LiteralInteger61", Operation_ProvidedAndRequiredInterface_main_Read_b_p_object_LiteralInteger61);
					AddToElementRepository("ObjectFlow62", Operation_ProvidedAndRequiredInterface_main_ObjectFlow62);
						AddToElementRepository("LiteralInteger63", Operation_ProvidedAndRequiredInterface_main_ObjectFlow62_LiteralInteger63);
						AddToElementRepository("LiteralBoolean64", Operation_ProvidedAndRequiredInterface_main_ObjectFlow62_LiteralBoolean64);
					AddToElementRepository("Read e.c", Operation_ProvidedAndRequiredInterface_main_Read_e_c);
						AddToElementRepository("object", Operation_ProvidedAndRequiredInterface_main_Read_e_c_object);
							AddToElementRepository("LiteralInteger65", Operation_ProvidedAndRequiredInterface_main_Read_e_c_object_LiteralInteger65);
							AddToElementRepository("LiteralUnlimitedNatural66", Operation_ProvidedAndRequiredInterface_main_Read_e_c_object_LiteralUnlimitedNatural66);
						AddToElementRepository("result", Operation_ProvidedAndRequiredInterface_main_Read_e_c_result);
							AddToElementRepository("LiteralInteger67", Operation_ProvidedAndRequiredInterface_main_Read_e_c_result_LiteralInteger67);
							AddToElementRepository("LiteralUnlimitedNatural68", Operation_ProvidedAndRequiredInterface_main_Read_e_c_result_LiteralUnlimitedNatural68);
					AddToElementRepository("Value(4)", Operation_ProvidedAndRequiredInterface_main_Value_4);
						AddToElementRepository("LiteralInteger69", Operation_ProvidedAndRequiredInterface_main_Value_4_LiteralInteger69);
						AddToElementRepository("result", Operation_ProvidedAndRequiredInterface_main_Value_4_result);
							AddToElementRepository("LiteralInteger70", Operation_ProvidedAndRequiredInterface_main_Value_4_result_LiteralInteger70);
							AddToElementRepository("LiteralUnlimitedNatural71", Operation_ProvidedAndRequiredInterface_main_Value_4_result_LiteralUnlimitedNatural71);
					AddToElementRepository("Read d.e", Operation_ProvidedAndRequiredInterface_main_Read_d_e);
						AddToElementRepository("result", Operation_ProvidedAndRequiredInterface_main_Read_d_e_result);
							AddToElementRepository("LiteralInteger72", Operation_ProvidedAndRequiredInterface_main_Read_d_e_result_LiteralInteger72);
							AddToElementRepository("LiteralUnlimitedNatural73", Operation_ProvidedAndRequiredInterface_main_Read_d_e_result_LiteralUnlimitedNatural73);
						AddToElementRepository("object", Operation_ProvidedAndRequiredInterface_main_Read_d_e_object);
							AddToElementRepository("LiteralUnlimitedNatural74", Operation_ProvidedAndRequiredInterface_main_Read_d_e_object_LiteralUnlimitedNatural74);
							AddToElementRepository("LiteralInteger75", Operation_ProvidedAndRequiredInterface_main_Read_d_e_object_LiteralInteger75);
					AddToElementRepository("Create D", Operation_ProvidedAndRequiredInterface_main_Create_D);
						AddToElementRepository("result", Operation_ProvidedAndRequiredInterface_main_Create_D_result);
							AddToElementRepository("LiteralUnlimitedNatural76", Operation_ProvidedAndRequiredInterface_main_Create_D_result_LiteralUnlimitedNatural76);
							AddToElementRepository("LiteralInteger77", Operation_ProvidedAndRequiredInterface_main_Create_D_result_LiteralInteger77);
					AddToElementRepository("ObjectFlow78", Operation_ProvidedAndRequiredInterface_main_ObjectFlow78);
						AddToElementRepository("LiteralInteger79", Operation_ProvidedAndRequiredInterface_main_ObjectFlow78_LiteralInteger79);
						AddToElementRepository("LiteralBoolean80", Operation_ProvidedAndRequiredInterface_main_ObjectFlow78_LiteralBoolean80);
					AddToElementRepository("Read d.a", Operation_ProvidedAndRequiredInterface_main_Read_d_a);
						AddToElementRepository("object", Operation_ProvidedAndRequiredInterface_main_Read_d_a_object);
							AddToElementRepository("LiteralUnlimitedNatural81", Operation_ProvidedAndRequiredInterface_main_Read_d_a_object_LiteralUnlimitedNatural81);
							AddToElementRepository("LiteralInteger82", Operation_ProvidedAndRequiredInterface_main_Read_d_a_object_LiteralInteger82);
						AddToElementRepository("result", Operation_ProvidedAndRequiredInterface_main_Read_d_a_result);
							AddToElementRepository("LiteralUnlimitedNatural83", Operation_ProvidedAndRequiredInterface_main_Read_d_a_result_LiteralUnlimitedNatural83);
							AddToElementRepository("LiteralInteger84", Operation_ProvidedAndRequiredInterface_main_Read_d_a_result_LiteralInteger84);
				AddToElementRepository("A", Operation_ProvidedAndRequiredInterface_A);
					AddToElementRepository("b", Operation_ProvidedAndRequiredInterface_A_b);
					AddToElementRepository("q", Operation_ProvidedAndRequiredInterface_A_q);
					AddToElementRepository("setP_Integer", Operation_ProvidedAndRequiredInterface_A_setP_Integer);
						AddToElementRepository("v", Operation_ProvidedAndRequiredInterface_A_setP_Integer_v);
					AddToElementRepository("setPActivity", Operation_ProvidedAndRequiredInterface_A_setPActivity);
						AddToElementRepository("vParameterNode", Operation_ProvidedAndRequiredInterface_A_setPActivity_vParameterNode);
							AddToElementRepository("LiteralInteger85", Operation_ProvidedAndRequiredInterface_A_setPActivity_vParameterNode_LiteralInteger85);
						AddToElementRepository("this", Operation_ProvidedAndRequiredInterface_A_setPActivity_this);
							AddToElementRepository("result", Operation_ProvidedAndRequiredInterface_A_setPActivity_this_result);
								AddToElementRepository("LiteralUnlimitedNatural86", Operation_ProvidedAndRequiredInterface_A_setPActivity_this_result_LiteralUnlimitedNatural86);
								AddToElementRepository("LiteralInteger87", Operation_ProvidedAndRequiredInterface_A_setPActivity_this_result_LiteralInteger87);
						AddToElementRepository("ObjectFlow88", Operation_ProvidedAndRequiredInterface_A_setPActivity_ObjectFlow88);
							AddToElementRepository("LiteralBoolean89", Operation_ProvidedAndRequiredInterface_A_setPActivity_ObjectFlow88_LiteralBoolean89);
							AddToElementRepository("LiteralInteger90", Operation_ProvidedAndRequiredInterface_A_setPActivity_ObjectFlow88_LiteralInteger90);
						AddToElementRepository("ObjectFlow91", Operation_ProvidedAndRequiredInterface_A_setPActivity_ObjectFlow91);
							AddToElementRepository("LiteralInteger92", Operation_ProvidedAndRequiredInterface_A_setPActivity_ObjectFlow91_LiteralInteger92);
							AddToElementRepository("LiteralBoolean93", Operation_ProvidedAndRequiredInterface_A_setPActivity_ObjectFlow91_LiteralBoolean93);
						AddToElementRepository("v", Operation_ProvidedAndRequiredInterface_A_setPActivity_v);
						AddToElementRepository("Call I::setP on q", Operation_ProvidedAndRequiredInterface_A_setPActivity_Call_I_setP_on_q);
							AddToElementRepository("v", Operation_ProvidedAndRequiredInterface_A_setPActivity_Call_I_setP_on_q_v);
								AddToElementRepository("LiteralUnlimitedNatural94", Operation_ProvidedAndRequiredInterface_A_setPActivity_Call_I_setP_on_q_v_LiteralUnlimitedNatural94);
								AddToElementRepository("LiteralInteger95", Operation_ProvidedAndRequiredInterface_A_setPActivity_Call_I_setP_on_q_v_LiteralInteger95);
								AddToElementRepository("LiteralInteger96", Operation_ProvidedAndRequiredInterface_A_setPActivity_Call_I_setP_on_q_v_LiteralInteger96);
							AddToElementRepository("target", Operation_ProvidedAndRequiredInterface_A_setPActivity_Call_I_setP_on_q_target);
								AddToElementRepository("LiteralInteger97", Operation_ProvidedAndRequiredInterface_A_setPActivity_Call_I_setP_on_q_target_LiteralInteger97);
								AddToElementRepository("LiteralUnlimitedNatural98", Operation_ProvidedAndRequiredInterface_A_setPActivity_Call_I_setP_on_q_target_LiteralUnlimitedNatural98);
					AddToElementRepository("r", Operation_ProvidedAndRequiredInterface_A_r);
						AddToElementRepository("ConnectorEnd99", Operation_ProvidedAndRequiredInterface_A_r_ConnectorEnd99);
						AddToElementRepository("ConnectorEnd100", Operation_ProvidedAndRequiredInterface_A_r_ConnectorEnd100);
				AddToElementRepository("E", Operation_ProvidedAndRequiredInterface_E);
					AddToElementRepository("c", Operation_ProvidedAndRequiredInterface_E_c);
					AddToElementRepository("s", Operation_ProvidedAndRequiredInterface_E_s);
						AddToElementRepository("ConnectorEnd101", Operation_ProvidedAndRequiredInterface_E_s_ConnectorEnd101);
						AddToElementRepository("ConnectorEnd102", Operation_ProvidedAndRequiredInterface_E_s_ConnectorEnd102);
					AddToElementRepository("q", Operation_ProvidedAndRequiredInterface_E_q);
				AddToElementRepository("IImpl", Operation_ProvidedAndRequiredInterface_IImpl);
					AddToElementRepository("IRealization", Operation_ProvidedAndRequiredInterface_IImpl_IRealization);
					AddToElementRepository("setP_Integer", Operation_ProvidedAndRequiredInterface_IImpl_setP_Integer);
						AddToElementRepository("v", Operation_ProvidedAndRequiredInterface_IImpl_setP_Integer_v);
				AddToElementRepository("IUsageIProvReq", Operation_ProvidedAndRequiredInterface_IUsageIProvReq);
				AddToElementRepository("IProvReq", Operation_ProvidedAndRequiredInterface_IProvReq);
					AddToElementRepository("setP_Integer", Operation_ProvidedAndRequiredInterface_IProvReq_setP_Integer);
						AddToElementRepository("v", Operation_ProvidedAndRequiredInterface_IProvReq_setP_Integer_v);
					AddToElementRepository("Generalization103", Operation_ProvidedAndRequiredInterface_IProvReq_Generalization103);
				AddToElementRepository("B", Operation_ProvidedAndRequiredInterface_B);
					AddToElementRepository("setPActivity", Operation_ProvidedAndRequiredInterface_B_setPActivity);
						AddToElementRepository("ObjectFlow104", Operation_ProvidedAndRequiredInterface_B_setPActivity_ObjectFlow104);
							AddToElementRepository("LiteralInteger105", Operation_ProvidedAndRequiredInterface_B_setPActivity_ObjectFlow104_LiteralInteger105);
							AddToElementRepository("LiteralBoolean106", Operation_ProvidedAndRequiredInterface_B_setPActivity_ObjectFlow104_LiteralBoolean106);
						AddToElementRepository("ObjectFlow107", Operation_ProvidedAndRequiredInterface_B_setPActivity_ObjectFlow107);
							AddToElementRepository("LiteralBoolean108", Operation_ProvidedAndRequiredInterface_B_setPActivity_ObjectFlow107_LiteralBoolean108);
							AddToElementRepository("LiteralInteger109", Operation_ProvidedAndRequiredInterface_B_setPActivity_ObjectFlow107_LiteralInteger109);
						AddToElementRepository("v", Operation_ProvidedAndRequiredInterface_B_setPActivity_v);
						AddToElementRepository("vParameterNode", Operation_ProvidedAndRequiredInterface_B_setPActivity_vParameterNode);
							AddToElementRepository("LiteralInteger110", Operation_ProvidedAndRequiredInterface_B_setPActivity_vParameterNode_LiteralInteger110);
						AddToElementRepository("Set this.p", Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p);
							AddToElementRepository("value", Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p_value);
								AddToElementRepository("LiteralInteger111", Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p_value_LiteralInteger111);
								AddToElementRepository("LiteralUnlimitedNatural112", Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p_value_LiteralUnlimitedNatural112);
							AddToElementRepository("object", Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p_object);
								AddToElementRepository("LiteralInteger113", Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p_object_LiteralInteger113);
								AddToElementRepository("LiteralUnlimitedNatural114", Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p_object_LiteralUnlimitedNatural114);
							AddToElementRepository("result", Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p_result);
								AddToElementRepository("LiteralInteger115", Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p_result_LiteralInteger115);
								AddToElementRepository("LiteralUnlimitedNatural116", Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p_result_LiteralUnlimitedNatural116);
						AddToElementRepository("this", Operation_ProvidedAndRequiredInterface_B_setPActivity_this);
							AddToElementRepository("result", Operation_ProvidedAndRequiredInterface_B_setPActivity_this_result);
								AddToElementRepository("LiteralUnlimitedNatural117", Operation_ProvidedAndRequiredInterface_B_setPActivity_this_result_LiteralUnlimitedNatural117);
								AddToElementRepository("LiteralInteger118", Operation_ProvidedAndRequiredInterface_B_setPActivity_this_result_LiteralInteger118);
					AddToElementRepository("p", Operation_ProvidedAndRequiredInterface_B_p);
					AddToElementRepository("IRealization", Operation_ProvidedAndRequiredInterface_B_IRealization);
					AddToElementRepository("setP_Integer", Operation_ProvidedAndRequiredInterface_B_setP_Integer);
						AddToElementRepository("v", Operation_ProvidedAndRequiredInterface_B_setP_Integer_v);

			// Initialize public members
			/*
			 * Model Operation_ProvidedAndRequiredInterface
			 */
			Operation_ProvidedAndRequiredInterface.SetName("Operation_ProvidedAndRequiredInterface");
			Operation_ProvidedAndRequiredInterface.SetVisibility(VisibilityKind.public_);
				// Association R
				Operation_ProvidedAndRequiredInterface_R.SetName("R");
				Operation_ProvidedAndRequiredInterface_R.SetVisibility(VisibilityKind.public_);
				Operation_ProvidedAndRequiredInterface_R.AddOwnedEnd(Operation_ProvidedAndRequiredInterface_R_x);
				Operation_ProvidedAndRequiredInterface_R.AddOwnedEnd(Operation_ProvidedAndRequiredInterface_R_y);
			Operation_ProvidedAndRequiredInterface.AddPackagedElement(Operation_ProvidedAndRequiredInterface_R);
				// Association S
				Operation_ProvidedAndRequiredInterface_S.SetName("S");
				Operation_ProvidedAndRequiredInterface_S.SetVisibility(VisibilityKind.public_);
				Operation_ProvidedAndRequiredInterface_S.AddOwnedEnd(Operation_ProvidedAndRequiredInterface_S_x);
				Operation_ProvidedAndRequiredInterface_S.AddOwnedEnd(Operation_ProvidedAndRequiredInterface_S_y);
			Operation_ProvidedAndRequiredInterface.AddPackagedElement(Operation_ProvidedAndRequiredInterface_S);
				// Class C
				Operation_ProvidedAndRequiredInterface_C.SetName("C");
				Operation_ProvidedAndRequiredInterface_C.SetVisibility(VisibilityKind.public_);
				
					// Port q
					Operation_ProvidedAndRequiredInterface_C_q.SetName("q");
					Operation_ProvidedAndRequiredInterface_C_q.SetVisibility(VisibilityKind.public_);
					
					Operation_ProvidedAndRequiredInterface_C_q.SetType(Operation_ProvidedAndRequiredInterface_IProvReq);
					Operation_ProvidedAndRequiredInterface_C_q.SetAggregation(AggregationKind.composite);
					Operation_ProvidedAndRequiredInterface_C_q.isService = true;
					Operation_ProvidedAndRequiredInterface_C_q.AddRequired(Operation_ProvidedAndRequiredInterface_I);
					Operation_ProvidedAndRequiredInterface_C_q.AddProvided(Operation_ProvidedAndRequiredInterface_I);
				Operation_ProvidedAndRequiredInterface_C.AddOwnedAttribute(Operation_ProvidedAndRequiredInterface_C_q);
				// Activity setPActivity
					Operation_ProvidedAndRequiredInterface_C_setPActivity.SetName("setPActivity");
					Operation_ProvidedAndRequiredInterface_C_setPActivity.SetVisibility(VisibilityKind.public_);
					
						// Parameter v
						Operation_ProvidedAndRequiredInterface_C_setPActivity_v.SetName("v");
						Operation_ProvidedAndRequiredInterface_C_setPActivity_v.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedAndRequiredInterface_C_setPActivity_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_ProvidedAndRequiredInterface_C_setPActivity.AddOwnedParameter(Operation_ProvidedAndRequiredInterface_C_setPActivity_v);
						// ActivityParameterNode vParameterNode
						Operation_ProvidedAndRequiredInterface_C_setPActivity_vParameterNode.SetName("vParameterNode");
						Operation_ProvidedAndRequiredInterface_C_setPActivity_vParameterNode.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedAndRequiredInterface_C_setPActivity_vParameterNode.SetParameter(Operation_ProvidedAndRequiredInterface_C_setPActivity_v);
					Operation_ProvidedAndRequiredInterface_C_setPActivity.AddNode(Operation_ProvidedAndRequiredInterface_C_setPActivity_vParameterNode);
						// ReadSelfAction this
						Operation_ProvidedAndRequiredInterface_C_setPActivity_this.SetName("this");
						Operation_ProvidedAndRequiredInterface_C_setPActivity_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							Operation_ProvidedAndRequiredInterface_C_setPActivity_this_result.SetName("result");
							Operation_ProvidedAndRequiredInterface_C_setPActivity_this_result.SetVisibility(VisibilityKind.public_);
							Operation_ProvidedAndRequiredInterface_C_setPActivity_this_result.SetType(Operation_ProvidedAndRequiredInterface_C);
						Operation_ProvidedAndRequiredInterface_C_setPActivity_this.SetResult(Operation_ProvidedAndRequiredInterface_C_setPActivity_this_result);
					Operation_ProvidedAndRequiredInterface_C_setPActivity.AddNode(Operation_ProvidedAndRequiredInterface_C_setPActivity_this);
						// CallOperationAction Call I::setP on q
						Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q.SetName("Call I::setP on q");
						Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q.SetOnPort(Operation_ProvidedAndRequiredInterface_C_q);
						Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q.SetOperation(Operation_ProvidedAndRequiredInterface_I_setP_Integer);
							// InputPin target
							Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q_target.SetName("target");
							Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q_target.SetVisibility(VisibilityKind.public_);
							Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q_target.SetType(Operation_ProvidedAndRequiredInterface_C);
						Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q.SetTarget(Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q_target);
							// InputPin v
							Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q_v.SetName("v");
							Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q_v.SetVisibility(VisibilityKind.public_);
							Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q.AddArgument(Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q_v);
					Operation_ProvidedAndRequiredInterface_C_setPActivity.AddNode(Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q);
						// ObjectFlow ObjectFlow0 from result to target
						Operation_ProvidedAndRequiredInterface_C_setPActivity_ObjectFlow0.SetName("ObjectFlow0");
						Operation_ProvidedAndRequiredInterface_C_setPActivity_ObjectFlow0.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedAndRequiredInterface_C_setPActivity_ObjectFlow0.SetSource(Operation_ProvidedAndRequiredInterface_C_setPActivity_this_result);
						Operation_ProvidedAndRequiredInterface_C_setPActivity_ObjectFlow0.SetTarget(Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q_target);
							// LiteralBoolean LiteralBoolean1
							Operation_ProvidedAndRequiredInterface_C_setPActivity_ObjectFlow0_LiteralBoolean1.SetName("LiteralBoolean1");
							Operation_ProvidedAndRequiredInterface_C_setPActivity_ObjectFlow0_LiteralBoolean1.SetVisibility(VisibilityKind.public_);
							Operation_ProvidedAndRequiredInterface_C_setPActivity_ObjectFlow0_LiteralBoolean1.SetValue(true);
						Operation_ProvidedAndRequiredInterface_C_setPActivity_ObjectFlow0.SetGuard(Operation_ProvidedAndRequiredInterface_C_setPActivity_ObjectFlow0_LiteralBoolean1);
					Operation_ProvidedAndRequiredInterface_C_setPActivity.AddEdge(Operation_ProvidedAndRequiredInterface_C_setPActivity_ObjectFlow0);
						// ObjectFlow ObjectFlow4 from vParameterNode to v
						Operation_ProvidedAndRequiredInterface_C_setPActivity_ObjectFlow4.SetName("ObjectFlow4");
						Operation_ProvidedAndRequiredInterface_C_setPActivity_ObjectFlow4.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedAndRequiredInterface_C_setPActivity_ObjectFlow4.SetSource(Operation_ProvidedAndRequiredInterface_C_setPActivity_vParameterNode);
						Operation_ProvidedAndRequiredInterface_C_setPActivity_ObjectFlow4.SetTarget(Operation_ProvidedAndRequiredInterface_C_setPActivity_Call_I_setP_on_q_v);
							// LiteralBoolean LiteralBoolean6
							Operation_ProvidedAndRequiredInterface_C_setPActivity_ObjectFlow4_LiteralBoolean6.SetName("LiteralBoolean6");
							Operation_ProvidedAndRequiredInterface_C_setPActivity_ObjectFlow4_LiteralBoolean6.SetVisibility(VisibilityKind.public_);
							Operation_ProvidedAndRequiredInterface_C_setPActivity_ObjectFlow4_LiteralBoolean6.SetValue(true);
						Operation_ProvidedAndRequiredInterface_C_setPActivity_ObjectFlow4.SetGuard(Operation_ProvidedAndRequiredInterface_C_setPActivity_ObjectFlow4_LiteralBoolean6);
					Operation_ProvidedAndRequiredInterface_C_setPActivity.AddEdge(Operation_ProvidedAndRequiredInterface_C_setPActivity_ObjectFlow4);
				Operation_ProvidedAndRequiredInterface_C.AddOwnedBehavior(Operation_ProvidedAndRequiredInterface_C_setPActivity);
					Operation_ProvidedAndRequiredInterface_C_IRealization.SetName("IRealization");
					Operation_ProvidedAndRequiredInterface_C_IRealization.SetVisibility(VisibilityKind.public_);
					Operation_ProvidedAndRequiredInterface_C_IRealization.SetContract(Operation_ProvidedAndRequiredInterface_I);
					
				Operation_ProvidedAndRequiredInterface_C.AddInterfaceRealization(Operation_ProvidedAndRequiredInterface_C_IRealization);
				
					// Operation setP_Integer
					Operation_ProvidedAndRequiredInterface_C_setP_Integer.SetName("setP_Integer");
					Operation_ProvidedAndRequiredInterface_C_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						Operation_ProvidedAndRequiredInterface_C_setP_Integer_v.SetName("v");
						Operation_ProvidedAndRequiredInterface_C_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedAndRequiredInterface_C_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_ProvidedAndRequiredInterface_C_setP_Integer.AddOwnedParameter(Operation_ProvidedAndRequiredInterface_C_setP_Integer_v);
					Operation_ProvidedAndRequiredInterface_C_setP_Integer.AddMethod(Operation_ProvidedAndRequiredInterface_C_setPActivity);
				Operation_ProvidedAndRequiredInterface_C.AddOwnedOperation(Operation_ProvidedAndRequiredInterface_C_setP_Integer);
			Operation_ProvidedAndRequiredInterface.AddPackagedElement(Operation_ProvidedAndRequiredInterface_C);
				// Interface I
				Operation_ProvidedAndRequiredInterface_I.SetName("I");
				Operation_ProvidedAndRequiredInterface_I.SetVisibility(VisibilityKind.public_);
					// Operation setP_Integer
					Operation_ProvidedAndRequiredInterface_I_setP_Integer.SetName("setP_Integer");
					Operation_ProvidedAndRequiredInterface_I_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						Operation_ProvidedAndRequiredInterface_I_setP_Integer_v.SetName("v");
						Operation_ProvidedAndRequiredInterface_I_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedAndRequiredInterface_I_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_ProvidedAndRequiredInterface_I_setP_Integer.AddOwnedParameter(Operation_ProvidedAndRequiredInterface_I_setP_Integer_v);
				Operation_ProvidedAndRequiredInterface_I.AddOwnedOperation(Operation_ProvidedAndRequiredInterface_I_setP_Integer);
			Operation_ProvidedAndRequiredInterface.AddPackagedElement(Operation_ProvidedAndRequiredInterface_I);
				// Class D
				Operation_ProvidedAndRequiredInterface_D.SetName("D");
				Operation_ProvidedAndRequiredInterface_D.SetVisibility(VisibilityKind.public_);
				
					// Property e
					Operation_ProvidedAndRequiredInterface_D_e.SetName("e");
					Operation_ProvidedAndRequiredInterface_D_e.SetVisibility(VisibilityKind.public_);
					
					Operation_ProvidedAndRequiredInterface_D_e.SetType(Operation_ProvidedAndRequiredInterface_E);
					Operation_ProvidedAndRequiredInterface_D_e.SetAggregation(AggregationKind.composite);
				Operation_ProvidedAndRequiredInterface_D.AddOwnedAttribute(Operation_ProvidedAndRequiredInterface_D_e);
					// Property a
					Operation_ProvidedAndRequiredInterface_D_a.SetName("a");
					Operation_ProvidedAndRequiredInterface_D_a.SetVisibility(VisibilityKind.public_);
					
					Operation_ProvidedAndRequiredInterface_D_a.SetType(Operation_ProvidedAndRequiredInterface_A);
					Operation_ProvidedAndRequiredInterface_D_a.SetAggregation(AggregationKind.composite);
				Operation_ProvidedAndRequiredInterface_D.AddOwnedAttribute(Operation_ProvidedAndRequiredInterface_D_a);
				
				Operation_ProvidedAndRequiredInterface_D_s.SetName("s");
					Operation_ProvidedAndRequiredInterface_D_s.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedAndRequiredInterface_D_s_ConnectorEnd15.SetRole(Operation_ProvidedAndRequiredInterface_E_q);
						Operation_ProvidedAndRequiredInterface_D_s_ConnectorEnd15.SetPartWithPort(Operation_ProvidedAndRequiredInterface_D_e);
						
					Operation_ProvidedAndRequiredInterface_D_s.AddEnd(Operation_ProvidedAndRequiredInterface_D_s_ConnectorEnd15);
						
						Operation_ProvidedAndRequiredInterface_D_s_ConnectorEnd14.SetRole(Operation_ProvidedAndRequiredInterface_A_q);
						Operation_ProvidedAndRequiredInterface_D_s_ConnectorEnd14.SetPartWithPort(Operation_ProvidedAndRequiredInterface_D_a);
						
					Operation_ProvidedAndRequiredInterface_D_s.AddEnd(Operation_ProvidedAndRequiredInterface_D_s_ConnectorEnd14);
					Operation_ProvidedAndRequiredInterface_D_s.SetType(Operation_ProvidedAndRequiredInterface_S);
				Operation_ProvidedAndRequiredInterface_D.AddOwnedConnector(Operation_ProvidedAndRequiredInterface_D_s);
					// Operation D_D
					Operation_ProvidedAndRequiredInterface_D_D_D.SetName("D_D");
					Operation_ProvidedAndRequiredInterface_D_D_D.SetVisibility(VisibilityKind.public_);
						// Parameter result
						Operation_ProvidedAndRequiredInterface_D_D_D_result.SetName("result");
						Operation_ProvidedAndRequiredInterface_D_D_D_result.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedAndRequiredInterface_D_D_D_result.SetType(Operation_ProvidedAndRequiredInterface_D);
						Operation_ProvidedAndRequiredInterface_D_D_D_result.SetDirection(ParameterDirectionKind.return_);
					Operation_ProvidedAndRequiredInterface_D_D_D.AddOwnedParameter(Operation_ProvidedAndRequiredInterface_D_D_D_result);
					Operation_ProvidedAndRequiredInterface_D_D_D.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				Operation_ProvidedAndRequiredInterface_D.AddOwnedOperation(Operation_ProvidedAndRequiredInterface_D_D_D);
			Operation_ProvidedAndRequiredInterface.AddPackagedElement(Operation_ProvidedAndRequiredInterface_D);
				// Activity main
				Operation_ProvidedAndRequiredInterface_main.SetName("main");
				Operation_ProvidedAndRequiredInterface_main.SetVisibility(VisibilityKind.public_);
				// FunctionBehavior testP
					Operation_ProvidedAndRequiredInterface_main_testP.SetName("testP");
					Operation_ProvidedAndRequiredInterface_main_testP.SetVisibility(VisibilityKind.public_);
					
						// Parameter p
						Operation_ProvidedAndRequiredInterface_main_testP_p.SetName("p");
						Operation_ProvidedAndRequiredInterface_main_testP_p.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedAndRequiredInterface_main_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_ProvidedAndRequiredInterface_main_testP.AddOwnedParameter(Operation_ProvidedAndRequiredInterface_main_testP_p);
					Operation_ProvidedAndRequiredInterface_main_testP.AddLanguage("C#");
					Operation_ProvidedAndRequiredInterface_main_testP.AddLanguage("Using");
					Operation_ProvidedAndRequiredInterface_main_testP.AddBody("Console.WriteLine(\"Asserting d.a.b.p == 4\");  	// Test parameter p 	int p = ((IntegerValue)inputParameters.ElementAt(0).values.ElementAt(0)).value; 	Debug.Println(\"[doBody] argument p = \" + p); 	 	Console.WriteLine(\"d.a.b.p == \" + p); 	Console.Write(\"Invocation forwarded out of e through q: \");  	if(p == 4) 	{ 		Console.ForegroundColor = ConsoleColor.Green; 		Console.WriteLine(\"Assertion successful.\"); 	} 	else 	{ 		Console.ForegroundColor = ConsoleColor.Red; 		Console.WriteLine(\"Assertion failed!\"); 	}  	Console.ResetColor();");
					Operation_ProvidedAndRequiredInterface_main_testP.AddBody("using fuml.semantics.simpleclassifiers; ");
				Operation_ProvidedAndRequiredInterface_main.AddOwnedBehavior(Operation_ProvidedAndRequiredInterface_main_testP);
					// ReadStructuralFeatureAction Read a.b
					Operation_ProvidedAndRequiredInterface_main_Read_a_b.SetName("Read a.b");
					Operation_ProvidedAndRequiredInterface_main_Read_a_b.SetVisibility(VisibilityKind.public_);
					Operation_ProvidedAndRequiredInterface_main_Read_a_b.SetStructuralFeature(Operation_ProvidedAndRequiredInterface_A_b);
						// InputPin object
						Operation_ProvidedAndRequiredInterface_main_Read_a_b_object.SetName("object");
						Operation_ProvidedAndRequiredInterface_main_Read_a_b_object.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedAndRequiredInterface_main_Read_a_b_object.SetType(Operation_ProvidedAndRequiredInterface_A);
					Operation_ProvidedAndRequiredInterface_main_Read_a_b.SetObject(Operation_ProvidedAndRequiredInterface_main_Read_a_b_object);
						// OutputPin result
						Operation_ProvidedAndRequiredInterface_main_Read_a_b_result.SetName("result");
						Operation_ProvidedAndRequiredInterface_main_Read_a_b_result.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedAndRequiredInterface_main_Read_a_b_result.SetType(Operation_ProvidedAndRequiredInterface_B);
					Operation_ProvidedAndRequiredInterface_main_Read_a_b.SetResult(Operation_ProvidedAndRequiredInterface_main_Read_a_b_result);
				Operation_ProvidedAndRequiredInterface_main.AddNode(Operation_ProvidedAndRequiredInterface_main_Read_a_b);
					// CallOperationAction D()
					Operation_ProvidedAndRequiredInterface_main_D_.SetName("D()");
					Operation_ProvidedAndRequiredInterface_main_D_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						Operation_ProvidedAndRequiredInterface_main_D__result.SetName("result");
						Operation_ProvidedAndRequiredInterface_main_D__result.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedAndRequiredInterface_main_D__result.SetType(Operation_ProvidedAndRequiredInterface_D);
					Operation_ProvidedAndRequiredInterface_main_D_.AddResult(Operation_ProvidedAndRequiredInterface_main_D__result);
					Operation_ProvidedAndRequiredInterface_main_D_.SetOperation(Operation_ProvidedAndRequiredInterface_D_D_D);
						// InputPin target
						Operation_ProvidedAndRequiredInterface_main_D__target.SetName("target");
						Operation_ProvidedAndRequiredInterface_main_D__target.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedAndRequiredInterface_main_D__target.SetType(Operation_ProvidedAndRequiredInterface_D);
					Operation_ProvidedAndRequiredInterface_main_D_.SetTarget(Operation_ProvidedAndRequiredInterface_main_D__target);
				Operation_ProvidedAndRequiredInterface_main.AddNode(Operation_ProvidedAndRequiredInterface_main_D_);
					// ReadStructuralFeatureAction Read b.p
					Operation_ProvidedAndRequiredInterface_main_Read_b_p.SetName("Read b.p");
					Operation_ProvidedAndRequiredInterface_main_Read_b_p.SetVisibility(VisibilityKind.public_);
					Operation_ProvidedAndRequiredInterface_main_Read_b_p.SetStructuralFeature(Operation_ProvidedAndRequiredInterface_B_p);
						// InputPin object
						Operation_ProvidedAndRequiredInterface_main_Read_b_p_object.SetName("object");
						Operation_ProvidedAndRequiredInterface_main_Read_b_p_object.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedAndRequiredInterface_main_Read_b_p_object.SetType(Operation_ProvidedAndRequiredInterface_B);
					Operation_ProvidedAndRequiredInterface_main_Read_b_p.SetObject(Operation_ProvidedAndRequiredInterface_main_Read_b_p_object);
						// OutputPin result
						Operation_ProvidedAndRequiredInterface_main_Read_b_p_result.SetName("result");
						Operation_ProvidedAndRequiredInterface_main_Read_b_p_result.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedAndRequiredInterface_main_Read_b_p_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_ProvidedAndRequiredInterface_main_Read_b_p.SetResult(Operation_ProvidedAndRequiredInterface_main_Read_b_p_result);
				Operation_ProvidedAndRequiredInterface_main.AddNode(Operation_ProvidedAndRequiredInterface_main_Read_b_p);
					// ForkNode Fork d
					Operation_ProvidedAndRequiredInterface_main_Fork_d.SetName("Fork d");
					Operation_ProvidedAndRequiredInterface_main_Fork_d.SetVisibility(VisibilityKind.public_);
				Operation_ProvidedAndRequiredInterface_main.AddNode(Operation_ProvidedAndRequiredInterface_main_Fork_d);
					// ReadStructuralFeatureAction Read e.c
					Operation_ProvidedAndRequiredInterface_main_Read_e_c.SetName("Read e.c");
					Operation_ProvidedAndRequiredInterface_main_Read_e_c.SetVisibility(VisibilityKind.public_);
					Operation_ProvidedAndRequiredInterface_main_Read_e_c.SetStructuralFeature(Operation_ProvidedAndRequiredInterface_E_c);
						// InputPin object
						Operation_ProvidedAndRequiredInterface_main_Read_e_c_object.SetName("object");
						Operation_ProvidedAndRequiredInterface_main_Read_e_c_object.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedAndRequiredInterface_main_Read_e_c_object.SetType(Operation_ProvidedAndRequiredInterface_E);
					Operation_ProvidedAndRequiredInterface_main_Read_e_c.SetObject(Operation_ProvidedAndRequiredInterface_main_Read_e_c_object);
						// OutputPin result
						Operation_ProvidedAndRequiredInterface_main_Read_e_c_result.SetName("result");
						Operation_ProvidedAndRequiredInterface_main_Read_e_c_result.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedAndRequiredInterface_main_Read_e_c_result.SetType(Operation_ProvidedAndRequiredInterface_C);
					Operation_ProvidedAndRequiredInterface_main_Read_e_c.SetResult(Operation_ProvidedAndRequiredInterface_main_Read_e_c_result);
				Operation_ProvidedAndRequiredInterface_main.AddNode(Operation_ProvidedAndRequiredInterface_main_Read_e_c);
					// CallOperationAction Call setP()
					Operation_ProvidedAndRequiredInterface_main_Call_setP_.SetName("Call setP()");
					Operation_ProvidedAndRequiredInterface_main_Call_setP_.SetVisibility(VisibilityKind.public_);
					Operation_ProvidedAndRequiredInterface_main_Call_setP_.SetOperation(Operation_ProvidedAndRequiredInterface_C_setP_Integer);
						// InputPin target
						Operation_ProvidedAndRequiredInterface_main_Call_setP__target.SetName("target");
						Operation_ProvidedAndRequiredInterface_main_Call_setP__target.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedAndRequiredInterface_main_Call_setP__target.SetType(Operation_ProvidedAndRequiredInterface_C);
					Operation_ProvidedAndRequiredInterface_main_Call_setP_.SetTarget(Operation_ProvidedAndRequiredInterface_main_Call_setP__target);
						// InputPin v
						Operation_ProvidedAndRequiredInterface_main_Call_setP__v.SetName("v");
						Operation_ProvidedAndRequiredInterface_main_Call_setP__v.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedAndRequiredInterface_main_Call_setP__v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_ProvidedAndRequiredInterface_main_Call_setP_.AddArgument(Operation_ProvidedAndRequiredInterface_main_Call_setP__v);
				Operation_ProvidedAndRequiredInterface_main.AddNode(Operation_ProvidedAndRequiredInterface_main_Call_setP_);
					// CallBehaviorAction Call testP
					Operation_ProvidedAndRequiredInterface_main_Call_testP.SetName("Call testP");
					Operation_ProvidedAndRequiredInterface_main_Call_testP.SetVisibility(VisibilityKind.public_);
					Operation_ProvidedAndRequiredInterface_main_Call_testP.SetBehavior(Operation_ProvidedAndRequiredInterface_main_testP);
						// InputPin p
						Operation_ProvidedAndRequiredInterface_main_Call_testP_p.SetName("p");
						Operation_ProvidedAndRequiredInterface_main_Call_testP_p.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedAndRequiredInterface_main_Call_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_ProvidedAndRequiredInterface_main_Call_testP.AddArgument(Operation_ProvidedAndRequiredInterface_main_Call_testP_p);
				Operation_ProvidedAndRequiredInterface_main.AddNode(Operation_ProvidedAndRequiredInterface_main_Call_testP);
					// ValueSpecificationAction Value(4)
					Operation_ProvidedAndRequiredInterface_main_Value_4.SetName("Value(4)");
					Operation_ProvidedAndRequiredInterface_main_Value_4.SetVisibility(VisibilityKind.public_);
						// LiteralInteger LiteralInteger69
						Operation_ProvidedAndRequiredInterface_main_Value_4_LiteralInteger69.SetName("LiteralInteger69");
						Operation_ProvidedAndRequiredInterface_main_Value_4_LiteralInteger69.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedAndRequiredInterface_main_Value_4_LiteralInteger69.SetValue(4);
					Operation_ProvidedAndRequiredInterface_main_Value_4.SetValue(Operation_ProvidedAndRequiredInterface_main_Value_4_LiteralInteger69);
						// OutputPin result
						Operation_ProvidedAndRequiredInterface_main_Value_4_result.SetName("result");
						Operation_ProvidedAndRequiredInterface_main_Value_4_result.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedAndRequiredInterface_main_Value_4_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_ProvidedAndRequiredInterface_main_Value_4.SetResult(Operation_ProvidedAndRequiredInterface_main_Value_4_result);
				Operation_ProvidedAndRequiredInterface_main.AddNode(Operation_ProvidedAndRequiredInterface_main_Value_4);
					// ReadStructuralFeatureAction Read d.e
					Operation_ProvidedAndRequiredInterface_main_Read_d_e.SetName("Read d.e");
					Operation_ProvidedAndRequiredInterface_main_Read_d_e.SetVisibility(VisibilityKind.public_);
					Operation_ProvidedAndRequiredInterface_main_Read_d_e.SetStructuralFeature(Operation_ProvidedAndRequiredInterface_D_e);
						// InputPin object
						Operation_ProvidedAndRequiredInterface_main_Read_d_e_object.SetName("object");
						Operation_ProvidedAndRequiredInterface_main_Read_d_e_object.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedAndRequiredInterface_main_Read_d_e_object.SetType(Operation_ProvidedAndRequiredInterface_D);
					Operation_ProvidedAndRequiredInterface_main_Read_d_e.SetObject(Operation_ProvidedAndRequiredInterface_main_Read_d_e_object);
						// OutputPin result
						Operation_ProvidedAndRequiredInterface_main_Read_d_e_result.SetName("result");
						Operation_ProvidedAndRequiredInterface_main_Read_d_e_result.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedAndRequiredInterface_main_Read_d_e_result.SetType(Operation_ProvidedAndRequiredInterface_E);
					Operation_ProvidedAndRequiredInterface_main_Read_d_e.SetResult(Operation_ProvidedAndRequiredInterface_main_Read_d_e_result);
				Operation_ProvidedAndRequiredInterface_main.AddNode(Operation_ProvidedAndRequiredInterface_main_Read_d_e);
					// CreateObjectAction Create D
					Operation_ProvidedAndRequiredInterface_main_Create_D.SetName("Create D");
					Operation_ProvidedAndRequiredInterface_main_Create_D.SetVisibility(VisibilityKind.public_);
					Operation_ProvidedAndRequiredInterface_main_Create_D.SetClassifier(Operation_ProvidedAndRequiredInterface_D);
						// OutputPin result
						Operation_ProvidedAndRequiredInterface_main_Create_D_result.SetName("result");
						Operation_ProvidedAndRequiredInterface_main_Create_D_result.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedAndRequiredInterface_main_Create_D_result.SetType(Operation_ProvidedAndRequiredInterface_D);
					Operation_ProvidedAndRequiredInterface_main_Create_D.SetResult(Operation_ProvidedAndRequiredInterface_main_Create_D_result);
				Operation_ProvidedAndRequiredInterface_main.AddNode(Operation_ProvidedAndRequiredInterface_main_Create_D);
					// ReadStructuralFeatureAction Read d.a
					Operation_ProvidedAndRequiredInterface_main_Read_d_a.SetName("Read d.a");
					Operation_ProvidedAndRequiredInterface_main_Read_d_a.SetVisibility(VisibilityKind.public_);
					Operation_ProvidedAndRequiredInterface_main_Read_d_a.SetStructuralFeature(Operation_ProvidedAndRequiredInterface_D_a);
						// InputPin object
						Operation_ProvidedAndRequiredInterface_main_Read_d_a_object.SetName("object");
						Operation_ProvidedAndRequiredInterface_main_Read_d_a_object.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedAndRequiredInterface_main_Read_d_a_object.SetType(Operation_ProvidedAndRequiredInterface_D);
					Operation_ProvidedAndRequiredInterface_main_Read_d_a.SetObject(Operation_ProvidedAndRequiredInterface_main_Read_d_a_object);
						// OutputPin result
						Operation_ProvidedAndRequiredInterface_main_Read_d_a_result.SetName("result");
						Operation_ProvidedAndRequiredInterface_main_Read_d_a_result.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedAndRequiredInterface_main_Read_d_a_result.SetType(Operation_ProvidedAndRequiredInterface_A);
					Operation_ProvidedAndRequiredInterface_main_Read_d_a.SetResult(Operation_ProvidedAndRequiredInterface_main_Read_d_a_result);
				Operation_ProvidedAndRequiredInterface_main.AddNode(Operation_ProvidedAndRequiredInterface_main_Read_d_a);
					// ObjectFlow ObjectFlow39 from Fork d to object
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow39.SetName("ObjectFlow39");
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow39.SetVisibility(VisibilityKind.public_);
					
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow39.SetSource(Operation_ProvidedAndRequiredInterface_main_Fork_d);
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow39.SetTarget(Operation_ProvidedAndRequiredInterface_main_Read_d_a_object);
						// LiteralBoolean LiteralBoolean40
						Operation_ProvidedAndRequiredInterface_main_ObjectFlow39_LiteralBoolean40.SetName("LiteralBoolean40");
						Operation_ProvidedAndRequiredInterface_main_ObjectFlow39_LiteralBoolean40.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedAndRequiredInterface_main_ObjectFlow39_LiteralBoolean40.SetValue(true);
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow39.SetGuard(Operation_ProvidedAndRequiredInterface_main_ObjectFlow39_LiteralBoolean40);
				Operation_ProvidedAndRequiredInterface_main.AddEdge(Operation_ProvidedAndRequiredInterface_main_ObjectFlow39);
					// ObjectFlow ObjectFlow16 from result to target
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow16.SetName("ObjectFlow16");
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow16.SetVisibility(VisibilityKind.public_);
					
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow16.SetSource(Operation_ProvidedAndRequiredInterface_main_Read_e_c_result);
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow16.SetTarget(Operation_ProvidedAndRequiredInterface_main_Call_setP__target);
						// LiteralBoolean LiteralBoolean17
						Operation_ProvidedAndRequiredInterface_main_ObjectFlow16_LiteralBoolean17.SetName("LiteralBoolean17");
						Operation_ProvidedAndRequiredInterface_main_ObjectFlow16_LiteralBoolean17.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedAndRequiredInterface_main_ObjectFlow16_LiteralBoolean17.SetValue(true);
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow16.SetGuard(Operation_ProvidedAndRequiredInterface_main_ObjectFlow16_LiteralBoolean17);
				Operation_ProvidedAndRequiredInterface_main.AddEdge(Operation_ProvidedAndRequiredInterface_main_ObjectFlow16);
					// ControlFlow ControlFlow51 from Call setP() to Read d.a
					Operation_ProvidedAndRequiredInterface_main_ControlFlow51.SetName("ControlFlow51");
					Operation_ProvidedAndRequiredInterface_main_ControlFlow51.SetVisibility(VisibilityKind.public_);
					
					Operation_ProvidedAndRequiredInterface_main_ControlFlow51.SetSource(Operation_ProvidedAndRequiredInterface_main_Call_setP_);
					Operation_ProvidedAndRequiredInterface_main_ControlFlow51.SetTarget(Operation_ProvidedAndRequiredInterface_main_Read_d_a);
				Operation_ProvidedAndRequiredInterface_main.AddEdge(Operation_ProvidedAndRequiredInterface_main_ControlFlow51);
					// ObjectFlow ObjectFlow52 from result to v
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow52.SetName("ObjectFlow52");
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow52.SetVisibility(VisibilityKind.public_);
					
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow52.SetSource(Operation_ProvidedAndRequiredInterface_main_Value_4_result);
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow52.SetTarget(Operation_ProvidedAndRequiredInterface_main_Call_setP__v);
						// LiteralBoolean LiteralBoolean54
						Operation_ProvidedAndRequiredInterface_main_ObjectFlow52_LiteralBoolean54.SetName("LiteralBoolean54");
						Operation_ProvidedAndRequiredInterface_main_ObjectFlow52_LiteralBoolean54.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedAndRequiredInterface_main_ObjectFlow52_LiteralBoolean54.SetValue(true);
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow52.SetGuard(Operation_ProvidedAndRequiredInterface_main_ObjectFlow52_LiteralBoolean54);
				Operation_ProvidedAndRequiredInterface_main.AddEdge(Operation_ProvidedAndRequiredInterface_main_ObjectFlow52);
					// ObjectFlow ObjectFlow55 from result to object
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow55.SetName("ObjectFlow55");
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow55.SetVisibility(VisibilityKind.public_);
					
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow55.SetSource(Operation_ProvidedAndRequiredInterface_main_Read_d_e_result);
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow55.SetTarget(Operation_ProvidedAndRequiredInterface_main_Read_e_c_object);
						// LiteralBoolean LiteralBoolean56
						Operation_ProvidedAndRequiredInterface_main_ObjectFlow55_LiteralBoolean56.SetName("LiteralBoolean56");
						Operation_ProvidedAndRequiredInterface_main_ObjectFlow55_LiteralBoolean56.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedAndRequiredInterface_main_ObjectFlow55_LiteralBoolean56.SetValue(true);
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow55.SetGuard(Operation_ProvidedAndRequiredInterface_main_ObjectFlow55_LiteralBoolean56);
				Operation_ProvidedAndRequiredInterface_main.AddEdge(Operation_ProvidedAndRequiredInterface_main_ObjectFlow55);
					// ObjectFlow ObjectFlow19 from Fork d to object
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow19.SetName("ObjectFlow19");
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow19.SetVisibility(VisibilityKind.public_);
					
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow19.SetSource(Operation_ProvidedAndRequiredInterface_main_Fork_d);
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow19.SetTarget(Operation_ProvidedAndRequiredInterface_main_Read_d_e_object);
						// LiteralBoolean LiteralBoolean21
						Operation_ProvidedAndRequiredInterface_main_ObjectFlow19_LiteralBoolean21.SetName("LiteralBoolean21");
						Operation_ProvidedAndRequiredInterface_main_ObjectFlow19_LiteralBoolean21.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedAndRequiredInterface_main_ObjectFlow19_LiteralBoolean21.SetValue(true);
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow19.SetGuard(Operation_ProvidedAndRequiredInterface_main_ObjectFlow19_LiteralBoolean21);
				Operation_ProvidedAndRequiredInterface_main.AddEdge(Operation_ProvidedAndRequiredInterface_main_ObjectFlow19);
					// ObjectFlow ObjectFlow62 from result to target
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow62.SetName("ObjectFlow62");
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow62.SetVisibility(VisibilityKind.public_);
					
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow62.SetSource(Operation_ProvidedAndRequiredInterface_main_Create_D_result);
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow62.SetTarget(Operation_ProvidedAndRequiredInterface_main_D__target);
						// LiteralBoolean LiteralBoolean64
						Operation_ProvidedAndRequiredInterface_main_ObjectFlow62_LiteralBoolean64.SetName("LiteralBoolean64");
						Operation_ProvidedAndRequiredInterface_main_ObjectFlow62_LiteralBoolean64.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedAndRequiredInterface_main_ObjectFlow62_LiteralBoolean64.SetValue(true);
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow62.SetGuard(Operation_ProvidedAndRequiredInterface_main_ObjectFlow62_LiteralBoolean64);
				Operation_ProvidedAndRequiredInterface_main.AddEdge(Operation_ProvidedAndRequiredInterface_main_ObjectFlow62);
					// ObjectFlow ObjectFlow22 from result to Fork d
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow22.SetName("ObjectFlow22");
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow22.SetVisibility(VisibilityKind.public_);
					
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow22.SetSource(Operation_ProvidedAndRequiredInterface_main_D__result);
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow22.SetTarget(Operation_ProvidedAndRequiredInterface_main_Fork_d);
						// LiteralBoolean LiteralBoolean23
						Operation_ProvidedAndRequiredInterface_main_ObjectFlow22_LiteralBoolean23.SetName("LiteralBoolean23");
						Operation_ProvidedAndRequiredInterface_main_ObjectFlow22_LiteralBoolean23.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedAndRequiredInterface_main_ObjectFlow22_LiteralBoolean23.SetValue(true);
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow22.SetGuard(Operation_ProvidedAndRequiredInterface_main_ObjectFlow22_LiteralBoolean23);
				Operation_ProvidedAndRequiredInterface_main.AddEdge(Operation_ProvidedAndRequiredInterface_main_ObjectFlow22);
					// ObjectFlow ObjectFlow30 from result to object
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow30.SetName("ObjectFlow30");
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow30.SetVisibility(VisibilityKind.public_);
					
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow30.SetSource(Operation_ProvidedAndRequiredInterface_main_Read_d_a_result);
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow30.SetTarget(Operation_ProvidedAndRequiredInterface_main_Read_a_b_object);
						// LiteralBoolean LiteralBoolean32
						Operation_ProvidedAndRequiredInterface_main_ObjectFlow30_LiteralBoolean32.SetName("LiteralBoolean32");
						Operation_ProvidedAndRequiredInterface_main_ObjectFlow30_LiteralBoolean32.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedAndRequiredInterface_main_ObjectFlow30_LiteralBoolean32.SetValue(true);
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow30.SetGuard(Operation_ProvidedAndRequiredInterface_main_ObjectFlow30_LiteralBoolean32);
				Operation_ProvidedAndRequiredInterface_main.AddEdge(Operation_ProvidedAndRequiredInterface_main_ObjectFlow30);
					// ObjectFlow ObjectFlow36 from result to object
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow36.SetName("ObjectFlow36");
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow36.SetVisibility(VisibilityKind.public_);
					
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow36.SetSource(Operation_ProvidedAndRequiredInterface_main_Read_a_b_result);
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow36.SetTarget(Operation_ProvidedAndRequiredInterface_main_Read_b_p_object);
						// LiteralBoolean LiteralBoolean37
						Operation_ProvidedAndRequiredInterface_main_ObjectFlow36_LiteralBoolean37.SetName("LiteralBoolean37");
						Operation_ProvidedAndRequiredInterface_main_ObjectFlow36_LiteralBoolean37.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedAndRequiredInterface_main_ObjectFlow36_LiteralBoolean37.SetValue(true);
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow36.SetGuard(Operation_ProvidedAndRequiredInterface_main_ObjectFlow36_LiteralBoolean37);
				Operation_ProvidedAndRequiredInterface_main.AddEdge(Operation_ProvidedAndRequiredInterface_main_ObjectFlow36);
					// ObjectFlow ObjectFlow78 from result to p
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow78.SetName("ObjectFlow78");
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow78.SetVisibility(VisibilityKind.public_);
					
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow78.SetSource(Operation_ProvidedAndRequiredInterface_main_Read_b_p_result);
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow78.SetTarget(Operation_ProvidedAndRequiredInterface_main_Call_testP_p);
						// LiteralBoolean LiteralBoolean80
						Operation_ProvidedAndRequiredInterface_main_ObjectFlow78_LiteralBoolean80.SetName("LiteralBoolean80");
						Operation_ProvidedAndRequiredInterface_main_ObjectFlow78_LiteralBoolean80.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedAndRequiredInterface_main_ObjectFlow78_LiteralBoolean80.SetValue(true);
					Operation_ProvidedAndRequiredInterface_main_ObjectFlow78.SetGuard(Operation_ProvidedAndRequiredInterface_main_ObjectFlow78_LiteralBoolean80);
				Operation_ProvidedAndRequiredInterface_main.AddEdge(Operation_ProvidedAndRequiredInterface_main_ObjectFlow78);
			Operation_ProvidedAndRequiredInterface.AddPackagedElement(Operation_ProvidedAndRequiredInterface_main);
				// Class A
				Operation_ProvidedAndRequiredInterface_A.SetName("A");
				Operation_ProvidedAndRequiredInterface_A.SetVisibility(VisibilityKind.public_);
				
					// Port q
					Operation_ProvidedAndRequiredInterface_A_q.SetName("q");
					Operation_ProvidedAndRequiredInterface_A_q.SetVisibility(VisibilityKind.public_);
					
					Operation_ProvidedAndRequiredInterface_A_q.SetType(Operation_ProvidedAndRequiredInterface_IImpl);
					Operation_ProvidedAndRequiredInterface_A_q.SetAggregation(AggregationKind.composite);
					Operation_ProvidedAndRequiredInterface_A_q.isService = true;
					Operation_ProvidedAndRequiredInterface_A_q.AddProvided(Operation_ProvidedAndRequiredInterface_I);
				Operation_ProvidedAndRequiredInterface_A.AddOwnedAttribute(Operation_ProvidedAndRequiredInterface_A_q);
					// Property b
					Operation_ProvidedAndRequiredInterface_A_b.SetName("b");
					Operation_ProvidedAndRequiredInterface_A_b.SetVisibility(VisibilityKind.public_);
					
					Operation_ProvidedAndRequiredInterface_A_b.SetType(Operation_ProvidedAndRequiredInterface_B);
					Operation_ProvidedAndRequiredInterface_A_b.SetAggregation(AggregationKind.composite);
				Operation_ProvidedAndRequiredInterface_A.AddOwnedAttribute(Operation_ProvidedAndRequiredInterface_A_b);
				// Activity setPActivity
					Operation_ProvidedAndRequiredInterface_A_setPActivity.SetName("setPActivity");
					Operation_ProvidedAndRequiredInterface_A_setPActivity.SetVisibility(VisibilityKind.public_);
					
						// Parameter v
						Operation_ProvidedAndRequiredInterface_A_setPActivity_v.SetName("v");
						Operation_ProvidedAndRequiredInterface_A_setPActivity_v.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedAndRequiredInterface_A_setPActivity_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_ProvidedAndRequiredInterface_A_setPActivity.AddOwnedParameter(Operation_ProvidedAndRequiredInterface_A_setPActivity_v);
						// ActivityParameterNode vParameterNode
						Operation_ProvidedAndRequiredInterface_A_setPActivity_vParameterNode.SetName("vParameterNode");
						Operation_ProvidedAndRequiredInterface_A_setPActivity_vParameterNode.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedAndRequiredInterface_A_setPActivity_vParameterNode.SetParameter(Operation_ProvidedAndRequiredInterface_A_setPActivity_v);
					Operation_ProvidedAndRequiredInterface_A_setPActivity.AddNode(Operation_ProvidedAndRequiredInterface_A_setPActivity_vParameterNode);
						// ReadSelfAction this
						Operation_ProvidedAndRequiredInterface_A_setPActivity_this.SetName("this");
						Operation_ProvidedAndRequiredInterface_A_setPActivity_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							Operation_ProvidedAndRequiredInterface_A_setPActivity_this_result.SetName("result");
							Operation_ProvidedAndRequiredInterface_A_setPActivity_this_result.SetVisibility(VisibilityKind.public_);
							Operation_ProvidedAndRequiredInterface_A_setPActivity_this_result.SetType(Operation_ProvidedAndRequiredInterface_A);
						Operation_ProvidedAndRequiredInterface_A_setPActivity_this.SetResult(Operation_ProvidedAndRequiredInterface_A_setPActivity_this_result);
					Operation_ProvidedAndRequiredInterface_A_setPActivity.AddNode(Operation_ProvidedAndRequiredInterface_A_setPActivity_this);
						// CallOperationAction Call I::setP on q
						Operation_ProvidedAndRequiredInterface_A_setPActivity_Call_I_setP_on_q.SetName("Call I::setP on q");
						Operation_ProvidedAndRequiredInterface_A_setPActivity_Call_I_setP_on_q.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedAndRequiredInterface_A_setPActivity_Call_I_setP_on_q.SetOnPort(Operation_ProvidedAndRequiredInterface_A_q);
						Operation_ProvidedAndRequiredInterface_A_setPActivity_Call_I_setP_on_q.SetOperation(Operation_ProvidedAndRequiredInterface_I_setP_Integer);
							// InputPin target
							Operation_ProvidedAndRequiredInterface_A_setPActivity_Call_I_setP_on_q_target.SetName("target");
							Operation_ProvidedAndRequiredInterface_A_setPActivity_Call_I_setP_on_q_target.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedAndRequiredInterface_A_setPActivity_Call_I_setP_on_q.SetTarget(Operation_ProvidedAndRequiredInterface_A_setPActivity_Call_I_setP_on_q_target);
							// InputPin v
							Operation_ProvidedAndRequiredInterface_A_setPActivity_Call_I_setP_on_q_v.SetName("v");
							Operation_ProvidedAndRequiredInterface_A_setPActivity_Call_I_setP_on_q_v.SetVisibility(VisibilityKind.public_);
							Operation_ProvidedAndRequiredInterface_A_setPActivity_Call_I_setP_on_q_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						Operation_ProvidedAndRequiredInterface_A_setPActivity_Call_I_setP_on_q.AddArgument(Operation_ProvidedAndRequiredInterface_A_setPActivity_Call_I_setP_on_q_v);
					Operation_ProvidedAndRequiredInterface_A_setPActivity.AddNode(Operation_ProvidedAndRequiredInterface_A_setPActivity_Call_I_setP_on_q);
						// ObjectFlow ObjectFlow88 from result to target
						Operation_ProvidedAndRequiredInterface_A_setPActivity_ObjectFlow88.SetName("ObjectFlow88");
						Operation_ProvidedAndRequiredInterface_A_setPActivity_ObjectFlow88.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedAndRequiredInterface_A_setPActivity_ObjectFlow88.SetSource(Operation_ProvidedAndRequiredInterface_A_setPActivity_this_result);
						Operation_ProvidedAndRequiredInterface_A_setPActivity_ObjectFlow88.SetTarget(Operation_ProvidedAndRequiredInterface_A_setPActivity_Call_I_setP_on_q_target);
							// LiteralBoolean LiteralBoolean89
							Operation_ProvidedAndRequiredInterface_A_setPActivity_ObjectFlow88_LiteralBoolean89.SetName("LiteralBoolean89");
							Operation_ProvidedAndRequiredInterface_A_setPActivity_ObjectFlow88_LiteralBoolean89.SetVisibility(VisibilityKind.public_);
							Operation_ProvidedAndRequiredInterface_A_setPActivity_ObjectFlow88_LiteralBoolean89.SetValue(true);
						Operation_ProvidedAndRequiredInterface_A_setPActivity_ObjectFlow88.SetGuard(Operation_ProvidedAndRequiredInterface_A_setPActivity_ObjectFlow88_LiteralBoolean89);
					Operation_ProvidedAndRequiredInterface_A_setPActivity.AddEdge(Operation_ProvidedAndRequiredInterface_A_setPActivity_ObjectFlow88);
						// ObjectFlow ObjectFlow91 from vParameterNode to v
						Operation_ProvidedAndRequiredInterface_A_setPActivity_ObjectFlow91.SetName("ObjectFlow91");
						Operation_ProvidedAndRequiredInterface_A_setPActivity_ObjectFlow91.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedAndRequiredInterface_A_setPActivity_ObjectFlow91.SetSource(Operation_ProvidedAndRequiredInterface_A_setPActivity_vParameterNode);
						Operation_ProvidedAndRequiredInterface_A_setPActivity_ObjectFlow91.SetTarget(Operation_ProvidedAndRequiredInterface_A_setPActivity_Call_I_setP_on_q_v);
							// LiteralBoolean LiteralBoolean93
							Operation_ProvidedAndRequiredInterface_A_setPActivity_ObjectFlow91_LiteralBoolean93.SetName("LiteralBoolean93");
							Operation_ProvidedAndRequiredInterface_A_setPActivity_ObjectFlow91_LiteralBoolean93.SetVisibility(VisibilityKind.public_);
							Operation_ProvidedAndRequiredInterface_A_setPActivity_ObjectFlow91_LiteralBoolean93.SetValue(true);
						Operation_ProvidedAndRequiredInterface_A_setPActivity_ObjectFlow91.SetGuard(Operation_ProvidedAndRequiredInterface_A_setPActivity_ObjectFlow91_LiteralBoolean93);
					Operation_ProvidedAndRequiredInterface_A_setPActivity.AddEdge(Operation_ProvidedAndRequiredInterface_A_setPActivity_ObjectFlow91);
				Operation_ProvidedAndRequiredInterface_A.AddOwnedBehavior(Operation_ProvidedAndRequiredInterface_A_setPActivity);
				Operation_ProvidedAndRequiredInterface_A_r.SetName("r");
					Operation_ProvidedAndRequiredInterface_A_r.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedAndRequiredInterface_A_r_ConnectorEnd100.SetRole(Operation_ProvidedAndRequiredInterface_A_q);
						
					Operation_ProvidedAndRequiredInterface_A_r.AddEnd(Operation_ProvidedAndRequiredInterface_A_r_ConnectorEnd100);
						
						Operation_ProvidedAndRequiredInterface_A_r_ConnectorEnd99.SetRole(Operation_ProvidedAndRequiredInterface_A_b);
						
					Operation_ProvidedAndRequiredInterface_A_r.AddEnd(Operation_ProvidedAndRequiredInterface_A_r_ConnectorEnd99);
					Operation_ProvidedAndRequiredInterface_A_r.SetType(Operation_ProvidedAndRequiredInterface_R);
				Operation_ProvidedAndRequiredInterface_A.AddOwnedConnector(Operation_ProvidedAndRequiredInterface_A_r);
					// Operation setP_Integer
					Operation_ProvidedAndRequiredInterface_A_setP_Integer.SetName("setP_Integer");
					Operation_ProvidedAndRequiredInterface_A_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						Operation_ProvidedAndRequiredInterface_A_setP_Integer_v.SetName("v");
						Operation_ProvidedAndRequiredInterface_A_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedAndRequiredInterface_A_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_ProvidedAndRequiredInterface_A_setP_Integer.AddOwnedParameter(Operation_ProvidedAndRequiredInterface_A_setP_Integer_v);
					Operation_ProvidedAndRequiredInterface_A_setP_Integer.AddMethod(Operation_ProvidedAndRequiredInterface_A_setPActivity);
				Operation_ProvidedAndRequiredInterface_A.AddOwnedOperation(Operation_ProvidedAndRequiredInterface_A_setP_Integer);
			Operation_ProvidedAndRequiredInterface.AddPackagedElement(Operation_ProvidedAndRequiredInterface_A);
				// Class E
				Operation_ProvidedAndRequiredInterface_E.SetName("E");
				Operation_ProvidedAndRequiredInterface_E.SetVisibility(VisibilityKind.public_);
				
					// Port q
					Operation_ProvidedAndRequiredInterface_E_q.SetName("q");
					Operation_ProvidedAndRequiredInterface_E_q.SetVisibility(VisibilityKind.public_);
					
					Operation_ProvidedAndRequiredInterface_E_q.SetType(Operation_ProvidedAndRequiredInterface_IProvReq);
					Operation_ProvidedAndRequiredInterface_E_q.SetAggregation(AggregationKind.composite);
					Operation_ProvidedAndRequiredInterface_E_q.isService = true;
					Operation_ProvidedAndRequiredInterface_E_q.AddRequired(Operation_ProvidedAndRequiredInterface_I);
					Operation_ProvidedAndRequiredInterface_E_q.AddProvided(Operation_ProvidedAndRequiredInterface_I);
				Operation_ProvidedAndRequiredInterface_E.AddOwnedAttribute(Operation_ProvidedAndRequiredInterface_E_q);
					// Property c
					Operation_ProvidedAndRequiredInterface_E_c.SetName("c");
					Operation_ProvidedAndRequiredInterface_E_c.SetVisibility(VisibilityKind.public_);
					
					Operation_ProvidedAndRequiredInterface_E_c.SetType(Operation_ProvidedAndRequiredInterface_C);
					Operation_ProvidedAndRequiredInterface_E_c.SetAggregation(AggregationKind.composite);
				Operation_ProvidedAndRequiredInterface_E.AddOwnedAttribute(Operation_ProvidedAndRequiredInterface_E_c);
				
				Operation_ProvidedAndRequiredInterface_E_s.SetName("s");
					Operation_ProvidedAndRequiredInterface_E_s.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedAndRequiredInterface_E_s_ConnectorEnd102.SetRole(Operation_ProvidedAndRequiredInterface_C_q);
						Operation_ProvidedAndRequiredInterface_E_s_ConnectorEnd102.SetPartWithPort(Operation_ProvidedAndRequiredInterface_E_c);
						
					Operation_ProvidedAndRequiredInterface_E_s.AddEnd(Operation_ProvidedAndRequiredInterface_E_s_ConnectorEnd102);
						
						Operation_ProvidedAndRequiredInterface_E_s_ConnectorEnd101.SetRole(Operation_ProvidedAndRequiredInterface_E_q);
						
					Operation_ProvidedAndRequiredInterface_E_s.AddEnd(Operation_ProvidedAndRequiredInterface_E_s_ConnectorEnd101);
					Operation_ProvidedAndRequiredInterface_E_s.SetType(Operation_ProvidedAndRequiredInterface_S);
				Operation_ProvidedAndRequiredInterface_E.AddOwnedConnector(Operation_ProvidedAndRequiredInterface_E_s);
			Operation_ProvidedAndRequiredInterface.AddPackagedElement(Operation_ProvidedAndRequiredInterface_E);
				// Class IImpl
				Operation_ProvidedAndRequiredInterface_IImpl.SetName("IImpl");
				Operation_ProvidedAndRequiredInterface_IImpl.SetVisibility(VisibilityKind.public_);
				Operation_ProvidedAndRequiredInterface_IImpl_IRealization.SetName("IRealization");
					Operation_ProvidedAndRequiredInterface_IImpl_IRealization.SetVisibility(VisibilityKind.public_);
					Operation_ProvidedAndRequiredInterface_IImpl_IRealization.SetContract(Operation_ProvidedAndRequiredInterface_I);
					
				Operation_ProvidedAndRequiredInterface_IImpl.AddInterfaceRealization(Operation_ProvidedAndRequiredInterface_IImpl_IRealization);
				
					// Operation setP_Integer
					Operation_ProvidedAndRequiredInterface_IImpl_setP_Integer.SetName("setP_Integer");
					Operation_ProvidedAndRequiredInterface_IImpl_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						Operation_ProvidedAndRequiredInterface_IImpl_setP_Integer_v.SetName("v");
						Operation_ProvidedAndRequiredInterface_IImpl_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedAndRequiredInterface_IImpl_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_ProvidedAndRequiredInterface_IImpl_setP_Integer.AddOwnedParameter(Operation_ProvidedAndRequiredInterface_IImpl_setP_Integer_v);
				Operation_ProvidedAndRequiredInterface_IImpl.AddOwnedOperation(Operation_ProvidedAndRequiredInterface_IImpl_setP_Integer);
			Operation_ProvidedAndRequiredInterface.AddPackagedElement(Operation_ProvidedAndRequiredInterface_IImpl);
				// Usage IUsageIProvReq
				Operation_ProvidedAndRequiredInterface_IUsageIProvReq.SetName("IUsageIProvReq");
				Operation_ProvidedAndRequiredInterface_IUsageIProvReq.SetVisibility(VisibilityKind.public_);
				Operation_ProvidedAndRequiredInterface_IUsageIProvReq.AddClient(Operation_ProvidedAndRequiredInterface_IProvReq);
				Operation_ProvidedAndRequiredInterface_IUsageIProvReq.AddSupplier(Operation_ProvidedAndRequiredInterface_I);
			Operation_ProvidedAndRequiredInterface.AddPackagedElement(Operation_ProvidedAndRequiredInterface_IUsageIProvReq);
				// Class IProvReq
				Operation_ProvidedAndRequiredInterface_IProvReq.SetName("IProvReq");
				Operation_ProvidedAndRequiredInterface_IProvReq.SetVisibility(VisibilityKind.public_);
				
					// Generalization to IImpl
					Operation_ProvidedAndRequiredInterface_IProvReq_Generalization103.SetGeneral(Operation_ProvidedAndRequiredInterface_IImpl);
				Operation_ProvidedAndRequiredInterface_IProvReq.AddGeneralization(Operation_ProvidedAndRequiredInterface_IProvReq_Generalization103);
				
				
					// Operation setP_Integer
					Operation_ProvidedAndRequiredInterface_IProvReq_setP_Integer.SetName("setP_Integer");
					Operation_ProvidedAndRequiredInterface_IProvReq_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						Operation_ProvidedAndRequiredInterface_IProvReq_setP_Integer_v.SetName("v");
						Operation_ProvidedAndRequiredInterface_IProvReq_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedAndRequiredInterface_IProvReq_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_ProvidedAndRequiredInterface_IProvReq_setP_Integer.AddOwnedParameter(Operation_ProvidedAndRequiredInterface_IProvReq_setP_Integer_v);
				Operation_ProvidedAndRequiredInterface_IProvReq.AddOwnedOperation(Operation_ProvidedAndRequiredInterface_IProvReq_setP_Integer);
			Operation_ProvidedAndRequiredInterface.AddPackagedElement(Operation_ProvidedAndRequiredInterface_IProvReq);
				// Class B
				Operation_ProvidedAndRequiredInterface_B.SetName("B");
				Operation_ProvidedAndRequiredInterface_B.SetVisibility(VisibilityKind.public_);
				
					// Property p
					Operation_ProvidedAndRequiredInterface_B_p.SetName("p");
					Operation_ProvidedAndRequiredInterface_B_p.SetVisibility(VisibilityKind.public_);
					
					Operation_ProvidedAndRequiredInterface_B_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
				Operation_ProvidedAndRequiredInterface_B.AddOwnedAttribute(Operation_ProvidedAndRequiredInterface_B_p);
				// Activity setPActivity
					Operation_ProvidedAndRequiredInterface_B_setPActivity.SetName("setPActivity");
					Operation_ProvidedAndRequiredInterface_B_setPActivity.SetVisibility(VisibilityKind.public_);
					
						// Parameter v
						Operation_ProvidedAndRequiredInterface_B_setPActivity_v.SetName("v");
						Operation_ProvidedAndRequiredInterface_B_setPActivity_v.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedAndRequiredInterface_B_setPActivity_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_ProvidedAndRequiredInterface_B_setPActivity.AddOwnedParameter(Operation_ProvidedAndRequiredInterface_B_setPActivity_v);
						// ActivityParameterNode vParameterNode
						Operation_ProvidedAndRequiredInterface_B_setPActivity_vParameterNode.SetName("vParameterNode");
						Operation_ProvidedAndRequiredInterface_B_setPActivity_vParameterNode.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedAndRequiredInterface_B_setPActivity_vParameterNode.SetParameter(Operation_ProvidedAndRequiredInterface_B_setPActivity_v);
					Operation_ProvidedAndRequiredInterface_B_setPActivity.AddNode(Operation_ProvidedAndRequiredInterface_B_setPActivity_vParameterNode);
						// AddStructuralFeatureValueAction Set this.p
						Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p.SetName("Set this.p");
						Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p.SetStructuralFeature(Operation_ProvidedAndRequiredInterface_B_p);
							// InputPin object
							Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p_object.SetName("object");
							Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p_object.SetVisibility(VisibilityKind.public_);
							Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p_object.SetType(Operation_ProvidedAndRequiredInterface_B);
						Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p.SetObject(Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p_object);
							// InputPin value
							Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p_value.SetName("value");
							Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p_value.SetVisibility(VisibilityKind.public_);
							Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p.SetValue(Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p_value);
							// OutputPin result
							Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p_result.SetName("result");
							Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p_result.SetVisibility(VisibilityKind.public_);
							Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p_result.SetType(Operation_ProvidedAndRequiredInterface_B);
						Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p.SetResult(Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p_result);
						Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p.SetIsReplaceAll(true);
					Operation_ProvidedAndRequiredInterface_B_setPActivity.AddNode(Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p);
						// ReadSelfAction this
						Operation_ProvidedAndRequiredInterface_B_setPActivity_this.SetName("this");
						Operation_ProvidedAndRequiredInterface_B_setPActivity_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							Operation_ProvidedAndRequiredInterface_B_setPActivity_this_result.SetName("result");
							Operation_ProvidedAndRequiredInterface_B_setPActivity_this_result.SetVisibility(VisibilityKind.public_);
							Operation_ProvidedAndRequiredInterface_B_setPActivity_this_result.SetType(Operation_ProvidedAndRequiredInterface_B);
						Operation_ProvidedAndRequiredInterface_B_setPActivity_this.SetResult(Operation_ProvidedAndRequiredInterface_B_setPActivity_this_result);
					Operation_ProvidedAndRequiredInterface_B_setPActivity.AddNode(Operation_ProvidedAndRequiredInterface_B_setPActivity_this);
						// ObjectFlow ObjectFlow104 from vParameterNode to value
						Operation_ProvidedAndRequiredInterface_B_setPActivity_ObjectFlow104.SetName("ObjectFlow104");
						Operation_ProvidedAndRequiredInterface_B_setPActivity_ObjectFlow104.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedAndRequiredInterface_B_setPActivity_ObjectFlow104.SetSource(Operation_ProvidedAndRequiredInterface_B_setPActivity_vParameterNode);
						Operation_ProvidedAndRequiredInterface_B_setPActivity_ObjectFlow104.SetTarget(Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p_value);
							// LiteralBoolean LiteralBoolean106
							Operation_ProvidedAndRequiredInterface_B_setPActivity_ObjectFlow104_LiteralBoolean106.SetName("LiteralBoolean106");
							Operation_ProvidedAndRequiredInterface_B_setPActivity_ObjectFlow104_LiteralBoolean106.SetVisibility(VisibilityKind.public_);
							Operation_ProvidedAndRequiredInterface_B_setPActivity_ObjectFlow104_LiteralBoolean106.SetValue(true);
						Operation_ProvidedAndRequiredInterface_B_setPActivity_ObjectFlow104.SetGuard(Operation_ProvidedAndRequiredInterface_B_setPActivity_ObjectFlow104_LiteralBoolean106);
					Operation_ProvidedAndRequiredInterface_B_setPActivity.AddEdge(Operation_ProvidedAndRequiredInterface_B_setPActivity_ObjectFlow104);
						// ObjectFlow ObjectFlow107 from result to object
						Operation_ProvidedAndRequiredInterface_B_setPActivity_ObjectFlow107.SetName("ObjectFlow107");
						Operation_ProvidedAndRequiredInterface_B_setPActivity_ObjectFlow107.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedAndRequiredInterface_B_setPActivity_ObjectFlow107.SetSource(Operation_ProvidedAndRequiredInterface_B_setPActivity_this_result);
						Operation_ProvidedAndRequiredInterface_B_setPActivity_ObjectFlow107.SetTarget(Operation_ProvidedAndRequiredInterface_B_setPActivity_Set_this_p_object);
							// LiteralBoolean LiteralBoolean108
							Operation_ProvidedAndRequiredInterface_B_setPActivity_ObjectFlow107_LiteralBoolean108.SetName("LiteralBoolean108");
							Operation_ProvidedAndRequiredInterface_B_setPActivity_ObjectFlow107_LiteralBoolean108.SetVisibility(VisibilityKind.public_);
							Operation_ProvidedAndRequiredInterface_B_setPActivity_ObjectFlow107_LiteralBoolean108.SetValue(true);
						Operation_ProvidedAndRequiredInterface_B_setPActivity_ObjectFlow107.SetGuard(Operation_ProvidedAndRequiredInterface_B_setPActivity_ObjectFlow107_LiteralBoolean108);
					Operation_ProvidedAndRequiredInterface_B_setPActivity.AddEdge(Operation_ProvidedAndRequiredInterface_B_setPActivity_ObjectFlow107);
				Operation_ProvidedAndRequiredInterface_B.AddOwnedBehavior(Operation_ProvidedAndRequiredInterface_B_setPActivity);
					Operation_ProvidedAndRequiredInterface_B_IRealization.SetName("IRealization");
					Operation_ProvidedAndRequiredInterface_B_IRealization.SetVisibility(VisibilityKind.public_);
					Operation_ProvidedAndRequiredInterface_B_IRealization.SetContract(Operation_ProvidedAndRequiredInterface_I);
					
				Operation_ProvidedAndRequiredInterface_B.AddInterfaceRealization(Operation_ProvidedAndRequiredInterface_B_IRealization);
				
					// Operation setP_Integer
					Operation_ProvidedAndRequiredInterface_B_setP_Integer.SetName("setP_Integer");
					Operation_ProvidedAndRequiredInterface_B_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						Operation_ProvidedAndRequiredInterface_B_setP_Integer_v.SetName("v");
						Operation_ProvidedAndRequiredInterface_B_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedAndRequiredInterface_B_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_ProvidedAndRequiredInterface_B_setP_Integer.AddOwnedParameter(Operation_ProvidedAndRequiredInterface_B_setP_Integer_v);
					Operation_ProvidedAndRequiredInterface_B_setP_Integer.AddMethod(Operation_ProvidedAndRequiredInterface_B_setPActivity);
				Operation_ProvidedAndRequiredInterface_B.AddOwnedOperation(Operation_ProvidedAndRequiredInterface_B_setP_Integer);
			Operation_ProvidedAndRequiredInterface.AddPackagedElement(Operation_ProvidedAndRequiredInterface_B);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // Operation_ProvidedAndRequiredInterfaceModel
}
