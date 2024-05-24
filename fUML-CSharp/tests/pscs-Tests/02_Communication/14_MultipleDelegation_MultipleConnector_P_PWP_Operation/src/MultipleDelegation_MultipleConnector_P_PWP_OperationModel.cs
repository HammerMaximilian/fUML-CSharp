/*
 * MultipleDelegation_MultipleConnector_P_PWP_OperationModel.cs
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

namespace MultipleDelegation_MultipleConnector_P_PWP_Operation
{
	public class MultipleDelegation_MultipleConnector_P_PWP_OperationModel : InMemoryModel
	{
		private static MultipleDelegation_MultipleConnector_P_PWP_OperationModel? instance;

		/*
		 * Model MultipleDelegation_MultipleConnector_P_PWP_Operation
		 */
		public Package MultipleDelegation_MultipleConnector_P_PWP_Operation = new();
			public Class_ MultipleDelegation_MultipleConnector_P_PWP_Operation_B = new();
				public Property MultipleDelegation_MultipleConnector_P_PWP_Operation_B_p = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_B_p_LiteralInteger0 = new();
				public InterfaceRealization MultipleDelegation_MultipleConnector_P_PWP_Operation_B_IRealization = new();
				public Operation MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setP_Integer = new();
					public Parameter MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setP_Integer_v = new();
				public Activity MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity = new();
					public ActivityParameterNode MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_vParameterNode = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_vParameterNode_LiteralInteger1 = new();
					public ReadSelfAction MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_this = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_this_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_this_result_LiteralUnlimitedNatural2 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_this_result_LiteralInteger3 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_ObjectFlow4 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_ObjectFlow4_LiteralBoolean5 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_ObjectFlow4_LiteralInteger6 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_ObjectFlow7 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_ObjectFlow7_LiteralBoolean8 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_ObjectFlow7_LiteralInteger9 = new();
					public Parameter MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_v = new();
					public AddStructuralFeatureValueAction MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p_result_LiteralUnlimitedNatural10 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p_result_LiteralInteger11 = new();
						public InputPin MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p_value = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p_value_LiteralUnlimitedNatural12 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p_value_LiteralInteger13 = new();
						public InputPin MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p_object = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p_object_LiteralUnlimitedNatural14 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p_object_LiteralInteger15 = new();
			public Class_ MultipleDelegation_MultipleConnector_P_PWP_Operation_IImpl = new();
				public InterfaceRealization MultipleDelegation_MultipleConnector_P_PWP_Operation_IImpl_IRealization = new();
				public Operation MultipleDelegation_MultipleConnector_P_PWP_Operation_IImpl_setP_Integer = new();
					public Parameter MultipleDelegation_MultipleConnector_P_PWP_Operation_IImpl_setP_Integer_v = new();
			public Interface MultipleDelegation_MultipleConnector_P_PWP_Operation_I = new();
				public Operation MultipleDelegation_MultipleConnector_P_PWP_Operation_I_setP_Integer = new();
					public Parameter MultipleDelegation_MultipleConnector_P_PWP_Operation_I_setP_Integer_v = new();
			public Class_ MultipleDelegation_MultipleConnector_P_PWP_Operation_A = new();
				public Property MultipleDelegation_MultipleConnector_P_PWP_Operation_A_b = new();
				public Port MultipleDelegation_MultipleConnector_P_PWP_Operation_A_q = new();
				public Connector MultipleDelegation_MultipleConnector_P_PWP_Operation_A_r = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_PWP_Operation_A_r_ConnectorEnd16 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_PWP_Operation_A_r_ConnectorEnd17 = new();
			public Association MultipleDelegation_MultipleConnector_P_PWP_Operation_R = new();
				public Property MultipleDelegation_MultipleConnector_P_PWP_Operation_R_x = new();
				public Property MultipleDelegation_MultipleConnector_P_PWP_Operation_R_y = new();
			public Activity MultipleDelegation_MultipleConnector_P_PWP_Operation_main = new();
				public ValueSpecificationAction MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Value_4 = new();
					public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Value_4_result = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Value_4_result_LiteralUnlimitedNatural18 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Value_4_result_LiteralInteger19 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Value_4_LiteralInteger20 = new();
				public CreateObjectAction MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Create_C = new();
					public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Create_C_result = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Create_C_result_LiteralUnlimitedNatural21 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Create_C_result_LiteralInteger22 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow23 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow23_LiteralInteger24 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow23_LiteralBoolean25 = new();
				public CallBehaviorAction MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_testP = new();
					public InputPin MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_testP_p = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_testP_p_LiteralUnlimitedNatural26 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_testP_p_LiteralInteger27 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_testP_p_LiteralInteger28 = new();
				public ControlFlow MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ControlFlow29 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow30 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow30_LiteralBoolean31 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow30_LiteralInteger32 = new();
				public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_p = new();
					public InputPin MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_p_object = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_p_object_LiteralUnlimitedNatural33 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_p_object_LiteralInteger34 = new();
					public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_p_result = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_p_result_LiteralInteger35 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_p_result_LiteralUnlimitedNatural36 = new();
				public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a4 = new();
					public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a4_result = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a4_result_LiteralInteger37 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a4_result_LiteralUnlimitedNatural38 = new();
					public InputPin MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a4_object = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a4_object_LiteralInteger39 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a4_object_LiteralUnlimitedNatural40 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow41 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow41_LiteralInteger42 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow41_LiteralBoolean43 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow44 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow44_LiteralBoolean45 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow44_LiteralInteger46 = new();
				public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a3 = new();
					public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a3_result = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a3_result_LiteralInteger47 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a3_result_LiteralUnlimitedNatural48 = new();
					public InputPin MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a3_object = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a3_object_LiteralInteger49 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a3_object_LiteralUnlimitedNatural50 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow51 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow51_LiteralInteger52 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow51_LiteralBoolean53 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow54 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow54_LiteralInteger55 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow54_LiteralBoolean56 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow57 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow57_LiteralBoolean58 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow57_LiteralInteger59 = new();
				public ForkNode MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Fork_C = new();
				public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a2 = new();
					public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a2_result = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a2_result_LiteralInteger60 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a2_result_LiteralUnlimitedNatural61 = new();
					public InputPin MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a2_object = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a2_object_LiteralUnlimitedNatural62 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a2_object_LiteralInteger63 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow64 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow64_LiteralBoolean65 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow64_LiteralInteger66 = new();
				public ControlFlow MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ControlFlow67 = new();
				public ControlFlow MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ControlFlow68 = new();
				public OpaqueBehavior MultipleDelegation_MultipleConnector_P_PWP_Operation_main_testP = new();
					public Parameter MultipleDelegation_MultipleConnector_P_PWP_Operation_main_testP_p = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow69 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow69_LiteralBoolean70 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow69_LiteralInteger71 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow72 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow72_LiteralBoolean73 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow72_LiteralInteger74 = new();
				public CallOperationAction MultipleDelegation_MultipleConnector_P_PWP_Operation_main_C_ = new();
					public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Operation_main_C__result = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_C__result_LiteralInteger75 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_C__result_LiteralInteger76 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Operation_main_C__result_LiteralUnlimitedNatural77 = new();
					public InputPin MultipleDelegation_MultipleConnector_P_PWP_Operation_main_C__target = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Operation_main_C__target_LiteralUnlimitedNatural78 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_C__target_LiteralInteger79 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow80 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow80_LiteralBoolean81 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow80_LiteralInteger82 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow83 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow83_LiteralInteger84 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow83_LiteralBoolean85 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow86 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow86_LiteralBoolean87 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow86_LiteralInteger88 = new();
				public ControlFlow MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ControlFlow89 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow90 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow90_LiteralBoolean91 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow90_LiteralInteger92 = new();
				public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_b_p = new();
					public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_b_p_result = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_b_p_result_LiteralUnlimitedNatural93 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_b_p_result_LiteralInteger94 = new();
					public InputPin MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_b_p_object = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_b_p_object_LiteralInteger95 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_b_p_object_LiteralUnlimitedNatural96 = new();
				public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a1 = new();
					public InputPin MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a1_object = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a1_object_LiteralUnlimitedNatural97 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a1_object_LiteralInteger98 = new();
					public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a1_result = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a1_result_LiteralInteger99 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a1_result_LiteralUnlimitedNatural100 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow101 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow101_LiteralInteger102 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow101_LiteralBoolean103 = new();
				public CallOperationAction MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP_ = new();
					public InputPin MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP__v = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP__v_LiteralInteger104 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP__v_LiteralUnlimitedNatural105 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP__v_LiteralInteger106 = new();
					public InputPin MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP__target = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP__target_LiteralInteger107 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP__target_LiteralUnlimitedNatural108 = new();
				public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b = new();
					public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b_result = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b_result_LiteralUnlimitedNatural109 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b_result_LiteralInteger110 = new();
					public InputPin MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b_object = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b_object_LiteralInteger111 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b_object_LiteralUnlimitedNatural112 = new();
			public Class_ MultipleDelegation_MultipleConnector_P_PWP_Operation_C = new();
				public Property MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a3 = new();
				public Connector MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u1 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u1_ConnectorEnd113 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u1_ConnectorEnd114 = new();
				public Connector MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u2 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u2_ConnectorEnd115 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u2_ConnectorEnd116 = new();
				public Connector MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u3 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u3_ConnectorEnd117 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u3_ConnectorEnd118 = new();
				public Connector MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u4 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u4_ConnectorEnd119 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u4_ConnectorEnd120 = new();
				public Operation MultipleDelegation_MultipleConnector_P_PWP_Operation_C_C_C = new();
					public Parameter MultipleDelegation_MultipleConnector_P_PWP_Operation_C_C_C_result = new();
				public Property MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a2 = new();
				public Property MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a1 = new();
				public Port MultipleDelegation_MultipleConnector_P_PWP_Operation_C_p = new();
				public Property MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a4 = new();
			public Association MultipleDelegation_MultipleConnector_P_PWP_Operation_U = new();
				public Property MultipleDelegation_MultipleConnector_P_PWP_Operation_U_y = new();
				public Property MultipleDelegation_MultipleConnector_P_PWP_Operation_U_x = new();

		public static MultipleDelegation_MultipleConnector_P_PWP_OperationModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public MultipleDelegation_MultipleConnector_P_PWP_OperationModel()
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
			 * Model MultipleDelegation_MultipleConnector_P_PWP_Operation
			 */
			AddToElementRepository("MultipleDelegation_MultipleConnector_P_PWP_Operation", MultipleDelegation_MultipleConnector_P_PWP_Operation);
				AddToElementRepository("B", MultipleDelegation_MultipleConnector_P_PWP_Operation_B);
					AddToElementRepository("p", MultipleDelegation_MultipleConnector_P_PWP_Operation_B_p);
						AddToElementRepository("LiteralInteger0", MultipleDelegation_MultipleConnector_P_PWP_Operation_B_p_LiteralInteger0);
					AddToElementRepository("IRealization", MultipleDelegation_MultipleConnector_P_PWP_Operation_B_IRealization);
					AddToElementRepository("setP_Integer", MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setP_Integer);
						AddToElementRepository("v", MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setP_Integer_v);
					AddToElementRepository("setPActivity", MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity);
						AddToElementRepository("vParameterNode", MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_vParameterNode);
							AddToElementRepository("LiteralInteger1", MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_vParameterNode_LiteralInteger1);
						AddToElementRepository("this", MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_this);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_this_result);
								AddToElementRepository("LiteralUnlimitedNatural2", MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_this_result_LiteralUnlimitedNatural2);
								AddToElementRepository("LiteralInteger3", MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_this_result_LiteralInteger3);
						AddToElementRepository("ObjectFlow4", MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_ObjectFlow4);
							AddToElementRepository("LiteralBoolean5", MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_ObjectFlow4_LiteralBoolean5);
							AddToElementRepository("LiteralInteger6", MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_ObjectFlow4_LiteralInteger6);
						AddToElementRepository("ObjectFlow7", MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_ObjectFlow7);
							AddToElementRepository("LiteralBoolean8", MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_ObjectFlow7_LiteralBoolean8);
							AddToElementRepository("LiteralInteger9", MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_ObjectFlow7_LiteralInteger9);
						AddToElementRepository("v", MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_v);
						AddToElementRepository("Set this.p", MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p_result);
								AddToElementRepository("LiteralUnlimitedNatural10", MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p_result_LiteralUnlimitedNatural10);
								AddToElementRepository("LiteralInteger11", MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p_result_LiteralInteger11);
							AddToElementRepository("value", MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p_value);
								AddToElementRepository("LiteralUnlimitedNatural12", MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p_value_LiteralUnlimitedNatural12);
								AddToElementRepository("LiteralInteger13", MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p_value_LiteralInteger13);
							AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p_object);
								AddToElementRepository("LiteralUnlimitedNatural14", MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p_object_LiteralUnlimitedNatural14);
								AddToElementRepository("LiteralInteger15", MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p_object_LiteralInteger15);
				AddToElementRepository("IImpl", MultipleDelegation_MultipleConnector_P_PWP_Operation_IImpl);
					AddToElementRepository("IRealization", MultipleDelegation_MultipleConnector_P_PWP_Operation_IImpl_IRealization);
					AddToElementRepository("setP_Integer", MultipleDelegation_MultipleConnector_P_PWP_Operation_IImpl_setP_Integer);
						AddToElementRepository("v", MultipleDelegation_MultipleConnector_P_PWP_Operation_IImpl_setP_Integer_v);
				AddToElementRepository("I", MultipleDelegation_MultipleConnector_P_PWP_Operation_I);
					AddToElementRepository("setP_Integer", MultipleDelegation_MultipleConnector_P_PWP_Operation_I_setP_Integer);
						AddToElementRepository("v", MultipleDelegation_MultipleConnector_P_PWP_Operation_I_setP_Integer_v);
				AddToElementRepository("A", MultipleDelegation_MultipleConnector_P_PWP_Operation_A);
					AddToElementRepository("b", MultipleDelegation_MultipleConnector_P_PWP_Operation_A_b);
					AddToElementRepository("q", MultipleDelegation_MultipleConnector_P_PWP_Operation_A_q);
					AddToElementRepository("r", MultipleDelegation_MultipleConnector_P_PWP_Operation_A_r);
						AddToElementRepository("ConnectorEnd16", MultipleDelegation_MultipleConnector_P_PWP_Operation_A_r_ConnectorEnd16);
						AddToElementRepository("ConnectorEnd17", MultipleDelegation_MultipleConnector_P_PWP_Operation_A_r_ConnectorEnd17);
				AddToElementRepository("R", MultipleDelegation_MultipleConnector_P_PWP_Operation_R);
					AddToElementRepository("x", MultipleDelegation_MultipleConnector_P_PWP_Operation_R_x);
					AddToElementRepository("y", MultipleDelegation_MultipleConnector_P_PWP_Operation_R_y);
				AddToElementRepository("main", MultipleDelegation_MultipleConnector_P_PWP_Operation_main);
					AddToElementRepository("Value(4)", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Value_4);
						AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Value_4_result);
							AddToElementRepository("LiteralUnlimitedNatural18", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Value_4_result_LiteralUnlimitedNatural18);
							AddToElementRepository("LiteralInteger19", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Value_4_result_LiteralInteger19);
						AddToElementRepository("LiteralInteger20", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Value_4_LiteralInteger20);
					AddToElementRepository("Create C", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Create_C);
						AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Create_C_result);
							AddToElementRepository("LiteralUnlimitedNatural21", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Create_C_result_LiteralUnlimitedNatural21);
							AddToElementRepository("LiteralInteger22", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Create_C_result_LiteralInteger22);
					AddToElementRepository("ObjectFlow23", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow23);
						AddToElementRepository("LiteralInteger24", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow23_LiteralInteger24);
						AddToElementRepository("LiteralBoolean25", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow23_LiteralBoolean25);
					AddToElementRepository("Call testP", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_testP);
						AddToElementRepository("p", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_testP_p);
							AddToElementRepository("LiteralUnlimitedNatural26", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_testP_p_LiteralUnlimitedNatural26);
							AddToElementRepository("LiteralInteger27", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_testP_p_LiteralInteger27);
							AddToElementRepository("LiteralInteger28", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_testP_p_LiteralInteger28);
					AddToElementRepository("ControlFlow29", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ControlFlow29);
					AddToElementRepository("ObjectFlow30", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow30);
						AddToElementRepository("LiteralBoolean31", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow30_LiteralBoolean31);
						AddToElementRepository("LiteralInteger32", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow30_LiteralInteger32);
					AddToElementRepository("Read c.p", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_p);
						AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_p_object);
							AddToElementRepository("LiteralUnlimitedNatural33", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_p_object_LiteralUnlimitedNatural33);
							AddToElementRepository("LiteralInteger34", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_p_object_LiteralInteger34);
						AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_p_result);
							AddToElementRepository("LiteralInteger35", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_p_result_LiteralInteger35);
							AddToElementRepository("LiteralUnlimitedNatural36", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_p_result_LiteralUnlimitedNatural36);
					AddToElementRepository("Read c.a4", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a4);
						AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a4_result);
							AddToElementRepository("LiteralInteger37", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a4_result_LiteralInteger37);
							AddToElementRepository("LiteralUnlimitedNatural38", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a4_result_LiteralUnlimitedNatural38);
						AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a4_object);
							AddToElementRepository("LiteralInteger39", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a4_object_LiteralInteger39);
							AddToElementRepository("LiteralUnlimitedNatural40", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a4_object_LiteralUnlimitedNatural40);
					AddToElementRepository("ObjectFlow41", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow41);
						AddToElementRepository("LiteralInteger42", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow41_LiteralInteger42);
						AddToElementRepository("LiteralBoolean43", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow41_LiteralBoolean43);
					AddToElementRepository("ObjectFlow44", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow44);
						AddToElementRepository("LiteralBoolean45", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow44_LiteralBoolean45);
						AddToElementRepository("LiteralInteger46", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow44_LiteralInteger46);
					AddToElementRepository("Read c.a3", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a3);
						AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a3_result);
							AddToElementRepository("LiteralInteger47", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a3_result_LiteralInteger47);
							AddToElementRepository("LiteralUnlimitedNatural48", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a3_result_LiteralUnlimitedNatural48);
						AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a3_object);
							AddToElementRepository("LiteralInteger49", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a3_object_LiteralInteger49);
							AddToElementRepository("LiteralUnlimitedNatural50", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a3_object_LiteralUnlimitedNatural50);
					AddToElementRepository("ObjectFlow51", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow51);
						AddToElementRepository("LiteralInteger52", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow51_LiteralInteger52);
						AddToElementRepository("LiteralBoolean53", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow51_LiteralBoolean53);
					AddToElementRepository("ObjectFlow54", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow54);
						AddToElementRepository("LiteralInteger55", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow54_LiteralInteger55);
						AddToElementRepository("LiteralBoolean56", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow54_LiteralBoolean56);
					AddToElementRepository("ObjectFlow57", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow57);
						AddToElementRepository("LiteralBoolean58", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow57_LiteralBoolean58);
						AddToElementRepository("LiteralInteger59", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow57_LiteralInteger59);
					AddToElementRepository("Fork C", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Fork_C);
					AddToElementRepository("Read c.a2", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a2);
						AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a2_result);
							AddToElementRepository("LiteralInteger60", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a2_result_LiteralInteger60);
							AddToElementRepository("LiteralUnlimitedNatural61", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a2_result_LiteralUnlimitedNatural61);
						AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a2_object);
							AddToElementRepository("LiteralUnlimitedNatural62", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a2_object_LiteralUnlimitedNatural62);
							AddToElementRepository("LiteralInteger63", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a2_object_LiteralInteger63);
					AddToElementRepository("ObjectFlow64", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow64);
						AddToElementRepository("LiteralBoolean65", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow64_LiteralBoolean65);
						AddToElementRepository("LiteralInteger66", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow64_LiteralInteger66);
					AddToElementRepository("ControlFlow67", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ControlFlow67);
					AddToElementRepository("ControlFlow68", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ControlFlow68);
					AddToElementRepository("testP", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_testP);
						AddToElementRepository("p", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_testP_p);
					AddToElementRepository("ObjectFlow69", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow69);
						AddToElementRepository("LiteralBoolean70", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow69_LiteralBoolean70);
						AddToElementRepository("LiteralInteger71", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow69_LiteralInteger71);
					AddToElementRepository("ObjectFlow72", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow72);
						AddToElementRepository("LiteralBoolean73", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow72_LiteralBoolean73);
						AddToElementRepository("LiteralInteger74", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow72_LiteralInteger74);
					AddToElementRepository("C()", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_C_);
						AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_C__result);
							AddToElementRepository("LiteralInteger75", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_C__result_LiteralInteger75);
							AddToElementRepository("LiteralInteger76", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_C__result_LiteralInteger76);
							AddToElementRepository("LiteralUnlimitedNatural77", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_C__result_LiteralUnlimitedNatural77);
						AddToElementRepository("target", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_C__target);
							AddToElementRepository("LiteralUnlimitedNatural78", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_C__target_LiteralUnlimitedNatural78);
							AddToElementRepository("LiteralInteger79", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_C__target_LiteralInteger79);
					AddToElementRepository("ObjectFlow80", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow80);
						AddToElementRepository("LiteralBoolean81", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow80_LiteralBoolean81);
						AddToElementRepository("LiteralInteger82", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow80_LiteralInteger82);
					AddToElementRepository("ObjectFlow83", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow83);
						AddToElementRepository("LiteralInteger84", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow83_LiteralInteger84);
						AddToElementRepository("LiteralBoolean85", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow83_LiteralBoolean85);
					AddToElementRepository("ObjectFlow86", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow86);
						AddToElementRepository("LiteralBoolean87", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow86_LiteralBoolean87);
						AddToElementRepository("LiteralInteger88", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow86_LiteralInteger88);
					AddToElementRepository("ControlFlow89", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ControlFlow89);
					AddToElementRepository("ObjectFlow90", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow90);
						AddToElementRepository("LiteralBoolean91", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow90_LiteralBoolean91);
						AddToElementRepository("LiteralInteger92", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow90_LiteralInteger92);
					AddToElementRepository("Read b.p", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_b_p);
						AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_b_p_result);
							AddToElementRepository("LiteralUnlimitedNatural93", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_b_p_result_LiteralUnlimitedNatural93);
							AddToElementRepository("LiteralInteger94", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_b_p_result_LiteralInteger94);
						AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_b_p_object);
							AddToElementRepository("LiteralInteger95", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_b_p_object_LiteralInteger95);
							AddToElementRepository("LiteralUnlimitedNatural96", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_b_p_object_LiteralUnlimitedNatural96);
					AddToElementRepository("Read c.a1", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a1);
						AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a1_object);
							AddToElementRepository("LiteralUnlimitedNatural97", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a1_object_LiteralUnlimitedNatural97);
							AddToElementRepository("LiteralInteger98", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a1_object_LiteralInteger98);
						AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a1_result);
							AddToElementRepository("LiteralInteger99", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a1_result_LiteralInteger99);
							AddToElementRepository("LiteralUnlimitedNatural100", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a1_result_LiteralUnlimitedNatural100);
					AddToElementRepository("ObjectFlow101", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow101);
						AddToElementRepository("LiteralInteger102", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow101_LiteralInteger102);
						AddToElementRepository("LiteralBoolean103", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow101_LiteralBoolean103);
					AddToElementRepository("Call p.setP()", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP_);
						AddToElementRepository("v", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP__v);
							AddToElementRepository("LiteralInteger104", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP__v_LiteralInteger104);
							AddToElementRepository("LiteralUnlimitedNatural105", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP__v_LiteralUnlimitedNatural105);
							AddToElementRepository("LiteralInteger106", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP__v_LiteralInteger106);
						AddToElementRepository("target", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP__target);
							AddToElementRepository("LiteralInteger107", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP__target_LiteralInteger107);
							AddToElementRepository("LiteralUnlimitedNatural108", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP__target_LiteralUnlimitedNatural108);
					AddToElementRepository("Read a.b", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b);
						AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b_result);
							AddToElementRepository("LiteralUnlimitedNatural109", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b_result_LiteralUnlimitedNatural109);
							AddToElementRepository("LiteralInteger110", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b_result_LiteralInteger110);
						AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b_object);
							AddToElementRepository("LiteralInteger111", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b_object_LiteralInteger111);
							AddToElementRepository("LiteralUnlimitedNatural112", MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b_object_LiteralUnlimitedNatural112);
				AddToElementRepository("C", MultipleDelegation_MultipleConnector_P_PWP_Operation_C);
					AddToElementRepository("a3", MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a3);
					AddToElementRepository("u1", MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u1);
						AddToElementRepository("ConnectorEnd113", MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u1_ConnectorEnd113);
						AddToElementRepository("ConnectorEnd114", MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u1_ConnectorEnd114);
					AddToElementRepository("u2", MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u2);
						AddToElementRepository("ConnectorEnd115", MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u2_ConnectorEnd115);
						AddToElementRepository("ConnectorEnd116", MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u2_ConnectorEnd116);
					AddToElementRepository("u3", MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u3);
						AddToElementRepository("ConnectorEnd117", MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u3_ConnectorEnd117);
						AddToElementRepository("ConnectorEnd118", MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u3_ConnectorEnd118);
					AddToElementRepository("u4", MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u4);
						AddToElementRepository("ConnectorEnd119", MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u4_ConnectorEnd119);
						AddToElementRepository("ConnectorEnd120", MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u4_ConnectorEnd120);
					AddToElementRepository("C_C", MultipleDelegation_MultipleConnector_P_PWP_Operation_C_C_C);
						AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Operation_C_C_C_result);
					AddToElementRepository("a2", MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a2);
					AddToElementRepository("a1", MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a1);
					AddToElementRepository("p", MultipleDelegation_MultipleConnector_P_PWP_Operation_C_p);
					AddToElementRepository("a4", MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a4);
				AddToElementRepository("U", MultipleDelegation_MultipleConnector_P_PWP_Operation_U);
					AddToElementRepository("y", MultipleDelegation_MultipleConnector_P_PWP_Operation_U_y);
					AddToElementRepository("x", MultipleDelegation_MultipleConnector_P_PWP_Operation_U_x);

			// Initialize public members
			/*
			 * Model MultipleDelegation_MultipleConnector_P_PWP_Operation
			 */
			MultipleDelegation_MultipleConnector_P_PWP_Operation.SetName("MultipleDelegation_MultipleConnector_P_PWP_Operation");
			MultipleDelegation_MultipleConnector_P_PWP_Operation.SetVisibility(VisibilityKind.public_);
				// Class B
				MultipleDelegation_MultipleConnector_P_PWP_Operation_B.SetName("B");
				MultipleDelegation_MultipleConnector_P_PWP_Operation_B.SetVisibility(VisibilityKind.public_);
				
					// Property p
					MultipleDelegation_MultipleConnector_P_PWP_Operation_B_p.SetName("p");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_B_p.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Operation_B_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						// LiteralInteger LiteralInteger0
						MultipleDelegation_MultipleConnector_P_PWP_Operation_B_p_LiteralInteger0.SetName("LiteralInteger0");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_B_p_LiteralInteger0.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_B_p_LiteralInteger0.SetValue(0);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_B_p.SetDefaultValue(MultipleDelegation_MultipleConnector_P_PWP_Operation_B_p_LiteralInteger0);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_B.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_PWP_Operation_B_p);
				// Activity setPActivity
					MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity.SetName("setPActivity");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity.SetVisibility(VisibilityKind.public_);
					
						// Parameter v
						MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_v.SetName("v");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_v.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity.AddOwnedParameter(MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_v);
						// ActivityParameterNode vParameterNode
						MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_vParameterNode.SetName("vParameterNode");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_vParameterNode.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_vParameterNode.SetParameter(MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_v);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_vParameterNode);
						// ReadSelfAction this
						MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_this.SetName("this");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_this_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_this_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_this_result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_B);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_this.SetResult(MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_this_result);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_this);
						// AddStructuralFeatureValueAction Set this.p
						MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p.SetName("Set this.p");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_PWP_Operation_B_p);
							// InputPin object
							MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p_object.SetName("object");
							MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p_object.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_B);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p.SetObject(MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p_object);
							// InputPin value
							MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p_value.SetName("value");
							MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p_value.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p.SetValue(MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p_value);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p_result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_B);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p.SetResult(MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p_result);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p);
						// ObjectFlow ObjectFlow4 from vParameterNode to value
						MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_ObjectFlow4.SetName("ObjectFlow4");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_ObjectFlow4.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_ObjectFlow4.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_vParameterNode);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_ObjectFlow4.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p_value);
							// LiteralBoolean LiteralBoolean5
							MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_ObjectFlow4_LiteralBoolean5.SetName("LiteralBoolean5");
							MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_ObjectFlow4_LiteralBoolean5.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_ObjectFlow4_LiteralBoolean5.SetValue(true);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_ObjectFlow4.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_ObjectFlow4_LiteralBoolean5);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_ObjectFlow4);
						// ObjectFlow ObjectFlow7 from result to object
						MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_ObjectFlow7.SetName("ObjectFlow7");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_ObjectFlow7.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_ObjectFlow7.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_this_result);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_ObjectFlow7.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_Set_this_p_object);
							// LiteralBoolean LiteralBoolean8
							MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_ObjectFlow7_LiteralBoolean8.SetName("LiteralBoolean8");
							MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_ObjectFlow7_LiteralBoolean8.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_ObjectFlow7_LiteralBoolean8.SetValue(true);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_ObjectFlow7.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_ObjectFlow7_LiteralBoolean8);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity_ObjectFlow7);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_B.AddOwnedBehavior(MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_B_IRealization.SetName("IRealization");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_B_IRealization.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_B_IRealization.SetContract(MultipleDelegation_MultipleConnector_P_PWP_Operation_I);
					
				MultipleDelegation_MultipleConnector_P_PWP_Operation_B.AddInterfaceRealization(MultipleDelegation_MultipleConnector_P_PWP_Operation_B_IRealization);
				
					// Operation setP_Integer
					MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setP_Integer.SetName("setP_Integer");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setP_Integer_v.SetName("v");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setP_Integer.AddOwnedParameter(MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setP_Integer_v);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setP_Integer.AddMethod(MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setPActivity);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_B.AddOwnedOperation(MultipleDelegation_MultipleConnector_P_PWP_Operation_B_setP_Integer);
			MultipleDelegation_MultipleConnector_P_PWP_Operation.AddPackagedElement(MultipleDelegation_MultipleConnector_P_PWP_Operation_B);
				// Class IImpl
				MultipleDelegation_MultipleConnector_P_PWP_Operation_IImpl.SetName("IImpl");
				MultipleDelegation_MultipleConnector_P_PWP_Operation_IImpl.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_IImpl_IRealization.SetName("IRealization");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_IImpl_IRealization.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_IImpl_IRealization.SetContract(MultipleDelegation_MultipleConnector_P_PWP_Operation_I);
					
				MultipleDelegation_MultipleConnector_P_PWP_Operation_IImpl.AddInterfaceRealization(MultipleDelegation_MultipleConnector_P_PWP_Operation_IImpl_IRealization);
				
					// Operation setP_Integer
					MultipleDelegation_MultipleConnector_P_PWP_Operation_IImpl_setP_Integer.SetName("setP_Integer");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_IImpl_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						MultipleDelegation_MultipleConnector_P_PWP_Operation_IImpl_setP_Integer_v.SetName("v");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_IImpl_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Operation_IImpl_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_IImpl_setP_Integer.AddOwnedParameter(MultipleDelegation_MultipleConnector_P_PWP_Operation_IImpl_setP_Integer_v);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_IImpl.AddOwnedOperation(MultipleDelegation_MultipleConnector_P_PWP_Operation_IImpl_setP_Integer);
			MultipleDelegation_MultipleConnector_P_PWP_Operation.AddPackagedElement(MultipleDelegation_MultipleConnector_P_PWP_Operation_IImpl);
				// Interface I
				MultipleDelegation_MultipleConnector_P_PWP_Operation_I.SetName("I");
				MultipleDelegation_MultipleConnector_P_PWP_Operation_I.SetVisibility(VisibilityKind.public_);
					// Operation setP_Integer
					MultipleDelegation_MultipleConnector_P_PWP_Operation_I_setP_Integer.SetName("setP_Integer");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_I_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						MultipleDelegation_MultipleConnector_P_PWP_Operation_I_setP_Integer_v.SetName("v");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_I_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Operation_I_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_I_setP_Integer.AddOwnedParameter(MultipleDelegation_MultipleConnector_P_PWP_Operation_I_setP_Integer_v);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_I.AddOwnedOperation(MultipleDelegation_MultipleConnector_P_PWP_Operation_I_setP_Integer);
			MultipleDelegation_MultipleConnector_P_PWP_Operation.AddPackagedElement(MultipleDelegation_MultipleConnector_P_PWP_Operation_I);
				// Class A
				MultipleDelegation_MultipleConnector_P_PWP_Operation_A.SetName("A");
				MultipleDelegation_MultipleConnector_P_PWP_Operation_A.SetVisibility(VisibilityKind.public_);
				
					// Port q
					MultipleDelegation_MultipleConnector_P_PWP_Operation_A_q.SetName("q");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_A_q.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Operation_A_q.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_IImpl);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_A_q.SetAggregation(AggregationKind.composite);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_A_q.isService = true;
					MultipleDelegation_MultipleConnector_P_PWP_Operation_A_q.AddProvided(MultipleDelegation_MultipleConnector_P_PWP_Operation_I);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_A.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_PWP_Operation_A_q);
					// Property b
					MultipleDelegation_MultipleConnector_P_PWP_Operation_A_b.SetName("b");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_A_b.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Operation_A_b.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_B);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_A_b.SetAggregation(AggregationKind.composite);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_A.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_PWP_Operation_A_b);
				
				MultipleDelegation_MultipleConnector_P_PWP_Operation_A_r.SetName("r");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_A_r.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Operation_A_r_ConnectorEnd16.SetRole(MultipleDelegation_MultipleConnector_P_PWP_Operation_A_q);
						
					MultipleDelegation_MultipleConnector_P_PWP_Operation_A_r.AddEnd(MultipleDelegation_MultipleConnector_P_PWP_Operation_A_r_ConnectorEnd16);
						
						MultipleDelegation_MultipleConnector_P_PWP_Operation_A_r_ConnectorEnd17.SetRole(MultipleDelegation_MultipleConnector_P_PWP_Operation_A_b);
						
					MultipleDelegation_MultipleConnector_P_PWP_Operation_A_r.AddEnd(MultipleDelegation_MultipleConnector_P_PWP_Operation_A_r_ConnectorEnd17);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_A_r.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_R);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_A.AddOwnedConnector(MultipleDelegation_MultipleConnector_P_PWP_Operation_A_r);
			MultipleDelegation_MultipleConnector_P_PWP_Operation.AddPackagedElement(MultipleDelegation_MultipleConnector_P_PWP_Operation_A);
				// Association R
				MultipleDelegation_MultipleConnector_P_PWP_Operation_R.SetName("R");
				MultipleDelegation_MultipleConnector_P_PWP_Operation_R.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_R.AddOwnedEnd(MultipleDelegation_MultipleConnector_P_PWP_Operation_R_x);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_R.AddOwnedEnd(MultipleDelegation_MultipleConnector_P_PWP_Operation_R_y);
			MultipleDelegation_MultipleConnector_P_PWP_Operation.AddPackagedElement(MultipleDelegation_MultipleConnector_P_PWP_Operation_R);
				// Activity main
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.SetName("main");
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.SetVisibility(VisibilityKind.public_);
				// FunctionBehavior testP
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_testP.SetName("testP");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_testP.SetVisibility(VisibilityKind.public_);
					
						// Parameter p
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_testP_p.SetName("p");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_testP_p.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_testP.AddOwnedParameter(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_testP_p);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_testP.AddLanguage("C#");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_testP.AddLanguage("Using");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_testP.AddBody("if(index == 1) 	{ 		Console.WriteLine(\"Asserting c.a1.b.p == 4 || c.a2.b.p == 4 || c.a3.b.p == 4 || c.a4.b.c == 4\"); 	}  	// For some reason, during the first execution of the expansion region, its body is actually executed twice. 	// Because of that, the body is actually executaed 5 times in total. This if-statement covers that up until solved. 	if (index <= MAX_INDEX) 	{ 		// Test parameter p                 int p = ((IntegerValue)inputParameters.ElementAt(0).values.ElementAt(0)).value; 		Debug.Println(\"[doBody] argument p = \" + p); 	 		Console.WriteLine( \"c.a\" + index + \".b.p == \" + p); 		success = success || (p == 4);  		if (index == MAX_INDEX) 		{  			Console.Write(\"Operation call delegated: \");  			if (success) 			{ 				Console.ForegroundColor = ConsoleColor.Green; 				Console.WriteLine(\"Assertion successful.\"); 			} 			else 			{ 				Console.ForegroundColor = ConsoleColor.Red; 				Console.WriteLine(\"Assertion failed!\"); 			}  			Console.ResetColor(); 		} 	}  	index++;");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_testP.AddBody("using fuml.semantics.simpleclassifiers; ");
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddOwnedBehavior(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_testP);
					// ReadStructuralFeatureAction Read c.a2
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a2.SetName("Read c.a2");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a2.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a2.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a2);
						// InputPin object
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a2_object.SetName("object");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a2_object.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a2_object.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_C);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a2.SetObject(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a2_object);
						// OutputPin result
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a2_result.SetName("result");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a2_result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a2_result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_A);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a2.SetResult(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a2_result);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a2);
					// ValueSpecificationAction Value(4)
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Value_4.SetName("Value(4)");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Value_4.SetVisibility(VisibilityKind.public_);
						// LiteralInteger LiteralInteger20
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Value_4_LiteralInteger20.SetName("LiteralInteger20");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Value_4_LiteralInteger20.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Value_4_LiteralInteger20.SetValue(4);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Value_4.SetValue(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Value_4_LiteralInteger20);
						// OutputPin result
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Value_4_result.SetName("result");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Value_4_result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Value_4_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Value_4.SetResult(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Value_4_result);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Value_4);
					// CreateObjectAction Create C
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Create_C.SetName("Create C");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Create_C.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Create_C.SetClassifier(MultipleDelegation_MultipleConnector_P_PWP_Operation_C);
						// OutputPin result
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Create_C_result.SetName("result");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Create_C_result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Create_C_result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_C);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Create_C.SetResult(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Create_C_result);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Create_C);
					// CallBehaviorAction Call testP
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_testP.SetName("Call testP");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_testP.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_testP.SetBehavior(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_testP);
						// InputPin p
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_testP_p.SetName("p");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_testP_p.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_testP.AddArgument(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_testP_p);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_testP);
					// ReadStructuralFeatureAction Read c.p
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_p.SetName("Read c.p");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_p.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_p.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_p);
						// InputPin object
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_p_object.SetName("object");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_p_object.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_p_object.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_C);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_p.SetObject(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_p_object);
						// OutputPin result
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_p_result.SetName("result");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_p_result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_p_result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_IImpl);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_p.SetResult(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_p_result);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_p);
					// ReadStructuralFeatureAction Read c.a4
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a4.SetName("Read c.a4");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a4.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a4.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a4);
						// InputPin object
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a4_object.SetName("object");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a4_object.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a4_object.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_C);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a4.SetObject(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a4_object);
						// OutputPin result
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a4_result.SetName("result");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a4_result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a4_result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_A);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a4.SetResult(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a4_result);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a4);
					// CallOperationAction C()
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_C_.SetName("C()");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_C_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_C__result.SetName("result");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_C__result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_C__result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_C);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_C_.AddResult(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_C__result);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_C_.SetOperation(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_C_C);
						// InputPin target
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_C__target.SetName("target");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_C__target.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_C__target.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_C);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_C_.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_C__target);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_C_);
					// ReadStructuralFeatureAction Read b.p
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_b_p.SetName("Read b.p");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_b_p.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_b_p.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_PWP_Operation_B_p);
						// InputPin object
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_b_p_object.SetName("object");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_b_p_object.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_b_p_object.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_B);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_b_p.SetObject(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_b_p_object);
						// OutputPin result
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_b_p_result.SetName("result");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_b_p_result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_b_p_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_b_p.SetResult(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_b_p_result);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_b_p);
					// ReadStructuralFeatureAction Read c.a1
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a1.SetName("Read c.a1");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a1.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a1.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a1);
						// InputPin object
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a1_object.SetName("object");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a1_object.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a1_object.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_C);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a1.SetObject(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a1_object);
						// OutputPin result
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a1_result.SetName("result");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a1_result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a1_result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_A);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a1.SetResult(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a1_result);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a1);
					// ReadStructuralFeatureAction Read c.a3
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a3.SetName("Read c.a3");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a3.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a3.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a3);
						// InputPin object
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a3_object.SetName("object");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a3_object.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a3_object.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_C);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a3.SetObject(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a3_object);
						// OutputPin result
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a3_result.SetName("result");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a3_result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a3_result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_A);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a3.SetResult(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a3_result);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a3);
					// CallOperationAction Call p.setP()
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP_.SetName("Call p.setP()");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP_.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP_.SetOperation(MultipleDelegation_MultipleConnector_P_PWP_Operation_I_setP_Integer);
						// InputPin target
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP__target.SetName("target");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP__target.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP__target.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_I);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP_.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP__target);
						// InputPin v
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP__v.SetName("v");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP__v.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP__v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP_.AddArgument(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP__v);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP_);
					// ReadStructuralFeatureAction Read a.b
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b.SetName("Read a.b");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_PWP_Operation_A_b);
						// InputPin object
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b_object.SetName("object");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b_object.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b_object.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_A);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b.SetObject(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b_object);
						// OutputPin result
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b_result.SetName("result");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b_result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b_result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_B);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b.SetResult(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b_result);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b);
					// ForkNode Fork C
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Fork_C.SetName("Fork C");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Fork_C.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Fork_C);
					// ObjectFlow ObjectFlow64 from result to target
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow64.SetName("ObjectFlow64");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow64.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow64.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_p_result);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow64.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP__target);
						// LiteralBoolean LiteralBoolean65
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow64_LiteralBoolean65.SetName("LiteralBoolean65");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow64_LiteralBoolean65.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow64_LiteralBoolean65.SetValue(true);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow64.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow64_LiteralBoolean65);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow64);
					// ControlFlow ControlFlow67 from Read c.a2 to Read c.a3
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ControlFlow67.SetName("ControlFlow67");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ControlFlow67.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ControlFlow67.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a2);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ControlFlow67.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a3);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ControlFlow67);
					// ControlFlow ControlFlow68 from Read c.a3 to Read c.a4
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ControlFlow68.SetName("ControlFlow68");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ControlFlow68.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ControlFlow68.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a3);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ControlFlow68.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a4);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ControlFlow68);
					// ObjectFlow ObjectFlow69 from result to object
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow69.SetName("ObjectFlow69");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow69.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow69.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a3_result);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow69.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b_object);
						// LiteralBoolean LiteralBoolean70
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow69_LiteralBoolean70.SetName("LiteralBoolean70");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow69_LiteralBoolean70.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow69_LiteralBoolean70.SetValue(true);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow69.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow69_LiteralBoolean70);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow69);
					// ObjectFlow ObjectFlow23 from Fork C to object
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow23.SetName("ObjectFlow23");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow23.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow23.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Fork_C);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow23.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a1_object);
						// LiteralBoolean LiteralBoolean25
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow23_LiteralBoolean25.SetName("LiteralBoolean25");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow23_LiteralBoolean25.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow23_LiteralBoolean25.SetValue(true);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow23.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow23_LiteralBoolean25);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow23);
					// ControlFlow ControlFlow29 from Read c.a1 to Read c.a2
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ControlFlow29.SetName("ControlFlow29");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ControlFlow29.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ControlFlow29.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a1);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ControlFlow29.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a2);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ControlFlow29);
					// ObjectFlow ObjectFlow30 from Fork C to object
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow30.SetName("ObjectFlow30");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow30.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow30.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Fork_C);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow30.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_p_object);
						// LiteralBoolean LiteralBoolean31
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow30_LiteralBoolean31.SetName("LiteralBoolean31");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow30_LiteralBoolean31.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow30_LiteralBoolean31.SetValue(true);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow30.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow30_LiteralBoolean31);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow30);
					// ObjectFlow ObjectFlow72 from result to object
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow72.SetName("ObjectFlow72");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow72.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow72.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a1_result);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow72.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b_object);
						// LiteralBoolean LiteralBoolean73
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow72_LiteralBoolean73.SetName("LiteralBoolean73");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow72_LiteralBoolean73.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow72_LiteralBoolean73.SetValue(true);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow72.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow72_LiteralBoolean73);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow72);
					// ObjectFlow ObjectFlow80 from result to object
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow80.SetName("ObjectFlow80");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow80.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow80.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b_result);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow80.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_b_p_object);
						// LiteralBoolean LiteralBoolean81
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow80_LiteralBoolean81.SetName("LiteralBoolean81");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow80_LiteralBoolean81.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow80_LiteralBoolean81.SetValue(true);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow80.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow80_LiteralBoolean81);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow80);
					// ObjectFlow ObjectFlow41 from Fork C to object
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow41.SetName("ObjectFlow41");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow41.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow41.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Fork_C);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow41.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a4_object);
						// LiteralBoolean LiteralBoolean43
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow41_LiteralBoolean43.SetName("LiteralBoolean43");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow41_LiteralBoolean43.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow41_LiteralBoolean43.SetValue(true);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow41.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow41_LiteralBoolean43);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow41);
					// ObjectFlow ObjectFlow83 from result to target
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow83.SetName("ObjectFlow83");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow83.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow83.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Create_C_result);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow83.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_C__target);
						// LiteralBoolean LiteralBoolean85
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow83_LiteralBoolean85.SetName("LiteralBoolean85");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow83_LiteralBoolean85.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow83_LiteralBoolean85.SetValue(true);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow83.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow83_LiteralBoolean85);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow83);
					// ObjectFlow ObjectFlow86 from result to Fork C
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow86.SetName("ObjectFlow86");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow86.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow86.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_C__result);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow86.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Fork_C);
						// LiteralBoolean LiteralBoolean87
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow86_LiteralBoolean87.SetName("LiteralBoolean87");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow86_LiteralBoolean87.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow86_LiteralBoolean87.SetValue(true);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow86.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow86_LiteralBoolean87);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow86);
					// ObjectFlow ObjectFlow44 from Fork C to object
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow44.SetName("ObjectFlow44");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow44.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow44.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Fork_C);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow44.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a2_object);
						// LiteralBoolean LiteralBoolean45
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow44_LiteralBoolean45.SetName("LiteralBoolean45");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow44_LiteralBoolean45.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow44_LiteralBoolean45.SetValue(true);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow44.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow44_LiteralBoolean45);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow44);
					// ControlFlow ControlFlow89 from Call p.setP() to Read c.a1
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ControlFlow89.SetName("ControlFlow89");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ControlFlow89.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ControlFlow89.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP_);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ControlFlow89.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a1);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ControlFlow89);
					// ObjectFlow ObjectFlow90 from result to object
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow90.SetName("ObjectFlow90");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow90.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow90.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a4_result);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow90.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b_object);
						// LiteralBoolean LiteralBoolean91
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow90_LiteralBoolean91.SetName("LiteralBoolean91");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow90_LiteralBoolean91.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow90_LiteralBoolean91.SetValue(true);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow90.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow90_LiteralBoolean91);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow90);
					// ObjectFlow ObjectFlow51 from Fork C to object
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow51.SetName("ObjectFlow51");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow51.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow51.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Fork_C);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow51.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a3_object);
						// LiteralBoolean LiteralBoolean53
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow51_LiteralBoolean53.SetName("LiteralBoolean53");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow51_LiteralBoolean53.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow51_LiteralBoolean53.SetValue(true);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow51.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow51_LiteralBoolean53);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow51);
					// ObjectFlow ObjectFlow54 from result to p
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow54.SetName("ObjectFlow54");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow54.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow54.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_b_p_result);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow54.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_testP_p);
						// LiteralBoolean LiteralBoolean56
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow54_LiteralBoolean56.SetName("LiteralBoolean56");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow54_LiteralBoolean56.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow54_LiteralBoolean56.SetValue(true);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow54.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow54_LiteralBoolean56);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow54);
					// ObjectFlow ObjectFlow101 from result to object
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow101.SetName("ObjectFlow101");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow101.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow101.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_c_a2_result);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow101.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Read_a_b_object);
						// LiteralBoolean LiteralBoolean103
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow101_LiteralBoolean103.SetName("LiteralBoolean103");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow101_LiteralBoolean103.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow101_LiteralBoolean103.SetValue(true);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow101.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow101_LiteralBoolean103);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow101);
					// ObjectFlow ObjectFlow57 from result to v
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow57.SetName("ObjectFlow57");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow57.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow57.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Value_4_result);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow57.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_Call_p_setP__v);
						// LiteralBoolean LiteralBoolean58
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow57_LiteralBoolean58.SetName("LiteralBoolean58");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow57_LiteralBoolean58.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow57_LiteralBoolean58.SetValue(true);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow57.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow57_LiteralBoolean58);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Operation_main_ObjectFlow57);
			MultipleDelegation_MultipleConnector_P_PWP_Operation.AddPackagedElement(MultipleDelegation_MultipleConnector_P_PWP_Operation_main);
				// Class C
				MultipleDelegation_MultipleConnector_P_PWP_Operation_C.SetName("C");
				MultipleDelegation_MultipleConnector_P_PWP_Operation_C.SetVisibility(VisibilityKind.public_);
				
					// Port p
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_p.SetName("p");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_p.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_p.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_IImpl);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_p.SetAggregation(AggregationKind.composite);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_p.isService = true;
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_p.AddProvided(MultipleDelegation_MultipleConnector_P_PWP_Operation_I);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_C.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_p);
					// Property a1
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a1.SetName("a1");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a1.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a1.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_A);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a1.SetAggregation(AggregationKind.composite);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_C.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a1);
					// Property a2
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a2.SetName("a2");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a2.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a2.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_A);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a2.SetAggregation(AggregationKind.composite);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_C.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a2);
					// Property a3
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a3.SetName("a3");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a3.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a3.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_A);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a3.SetAggregation(AggregationKind.composite);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_C.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a3);
					// Property a4
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a4.SetName("a4");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a4.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a4.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_A);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a4.SetAggregation(AggregationKind.composite);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_C.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a4);
				
				MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u1.SetName("u1");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u1.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u1_ConnectorEnd113.SetRole(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_p);
						
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u1.AddEnd(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u1_ConnectorEnd113);
						
						MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u1_ConnectorEnd114.SetRole(MultipleDelegation_MultipleConnector_P_PWP_Operation_A_q);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u1_ConnectorEnd114.SetPartWithPort(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a1);
						
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u1.AddEnd(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u1_ConnectorEnd114);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u1.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_U);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_C.AddOwnedConnector(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u1);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u2.SetName("u2");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u2.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u2_ConnectorEnd116.SetRole(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_p);
						
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u2.AddEnd(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u2_ConnectorEnd116);
						
						MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u2_ConnectorEnd115.SetRole(MultipleDelegation_MultipleConnector_P_PWP_Operation_A_q);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u2_ConnectorEnd115.SetPartWithPort(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a2);
						
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u2.AddEnd(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u2_ConnectorEnd115);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u2.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_U);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_C.AddOwnedConnector(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u2);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u3.SetName("u3");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u3.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u3_ConnectorEnd117.SetRole(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_p);
						
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u3.AddEnd(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u3_ConnectorEnd117);
						
						MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u3_ConnectorEnd118.SetRole(MultipleDelegation_MultipleConnector_P_PWP_Operation_A_q);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u3_ConnectorEnd118.SetPartWithPort(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a3);
						
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u3.AddEnd(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u3_ConnectorEnd118);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u3.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_U);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_C.AddOwnedConnector(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u3);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u4.SetName("u4");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u4.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u4_ConnectorEnd120.SetRole(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_p);
						
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u4.AddEnd(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u4_ConnectorEnd120);
						
						MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u4_ConnectorEnd119.SetRole(MultipleDelegation_MultipleConnector_P_PWP_Operation_A_q);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u4_ConnectorEnd119.SetPartWithPort(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_a4);
						
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u4.AddEnd(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u4_ConnectorEnd119);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u4.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_U);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_C.AddOwnedConnector(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_u4);
					// Operation C_C
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_C_C.SetName("C_C");
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_C_C.SetVisibility(VisibilityKind.public_);
						// Parameter result
						MultipleDelegation_MultipleConnector_P_PWP_Operation_C_C_C_result.SetName("result");
						MultipleDelegation_MultipleConnector_P_PWP_Operation_C_C_C_result.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Operation_C_C_C_result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Operation_C);
						MultipleDelegation_MultipleConnector_P_PWP_Operation_C_C_C_result.SetDirection(ParameterDirectionKind.return_);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_C_C.AddOwnedParameter(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_C_C_result);
					MultipleDelegation_MultipleConnector_P_PWP_Operation_C_C_C.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_C.AddOwnedOperation(MultipleDelegation_MultipleConnector_P_PWP_Operation_C_C_C);
			MultipleDelegation_MultipleConnector_P_PWP_Operation.AddPackagedElement(MultipleDelegation_MultipleConnector_P_PWP_Operation_C);
				// Association U
				MultipleDelegation_MultipleConnector_P_PWP_Operation_U.SetName("U");
				MultipleDelegation_MultipleConnector_P_PWP_Operation_U.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_U.AddOwnedEnd(MultipleDelegation_MultipleConnector_P_PWP_Operation_U_x);
				MultipleDelegation_MultipleConnector_P_PWP_Operation_U.AddOwnedEnd(MultipleDelegation_MultipleConnector_P_PWP_Operation_U_y);
			MultipleDelegation_MultipleConnector_P_PWP_Operation.AddPackagedElement(MultipleDelegation_MultipleConnector_P_PWP_Operation_U);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // MultipleDelegation_MultipleConnector_P_PWP_OperationModel
}
