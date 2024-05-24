/*
 * MultipleDelegation_SameConnector_P_PWP_SignalModel.cs
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

namespace MultipleDelegation_SameConnector_P_PWP_Signal
{
	public class MultipleDelegation_SameConnector_P_PWP_SignalModel : InMemoryModel
	{
		private static MultipleDelegation_SameConnector_P_PWP_SignalModel? instance;

		/*
		 * Model MultipleDelegation_SameConnector_P_PWP_Signal
		 */
		public Package MultipleDelegation_SameConnector_P_PWP_Signal = new();
			public Class_ MultipleDelegation_SameConnector_P_PWP_Signal_Tester = new();
				public Generalization MultipleDelegation_SameConnector_P_PWP_Signal_Tester_Generalization0 = new();
				public Activity MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow1 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow1_LiteralBoolean2 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow1_LiteralInteger3 = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow4 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow4_LiteralBoolean5 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow4_LiteralInteger6 = new();
					public ReadStructuralFeatureAction MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_a_b = new();
						public InputPin MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_object = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_object_LiteralInteger7 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_object_LiteralUnlimitedNatural8 = new();
						public OutputPin MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_result = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_result_LiteralInteger9 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_result_LiteralUnlimitedNatural10 = new();
					public OpaqueBehavior MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_testP = new();
						public Parameter MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_testP_p = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow11 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow11_LiteralBoolean12 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow11_LiteralInteger13 = new();
					public ReadSelfAction MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_this = new();
						public OutputPin MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_this_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_this_result_LiteralUnlimitedNatural14 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_this_result_LiteralInteger15 = new();
					public ReadStructuralFeatureAction MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_this_c = new();
						public OutputPin MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_result_LiteralUnlimitedNatural16 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_result_LiteralInteger17 = new();
						public InputPin MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_object = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_object_LiteralInteger18 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_object_LiteralUnlimitedNatural19 = new();
					public CallBehaviorAction MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Call_testP = new();
						public InputPin MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Call_testP_p = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Call_testP_p_LiteralInteger20 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Call_testP_p_LiteralInteger21 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Call_testP_p_LiteralUnlimitedNatural22 = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow23 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow23_LiteralBoolean24 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow23_LiteralInteger25 = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow26 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow26_LiteralBoolean27 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow26_LiteralInteger28 = new();
					public ReadStructuralFeatureAction MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_b_p = new();
						public InputPin MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_object = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_object_LiteralInteger29 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_object_LiteralUnlimitedNatural30 = new();
						public OutputPin MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_result = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_result_LiteralInteger31 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_result_LiteralUnlimitedNatural32 = new();
					public ReadStructuralFeatureAction MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_c_a_ = new();
						public OutputPin MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_c_a__result = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_c_a__result_LiteralInteger33 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_c_a__result_LiteralUnlimitedNatural34 = new();
						public InputPin MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_c_a__object = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_c_a__object_LiteralUnlimitedNatural35 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_c_a__object_LiteralInteger36 = new();
				public Operation MultipleDelegation_SameConnector_P_PWP_Signal_Tester_Tester_Tester = new();
					public Parameter MultipleDelegation_SameConnector_P_PWP_Signal_Tester_Tester_Tester_result = new();
				public Activity MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior = new();
					public ReadStructuralFeatureAction MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p = new();
						public InputPin MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_object = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_object_LiteralInteger37 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_object_LiteralUnlimitedNatural38 = new();
						public OutputPin MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_result_LiteralUnlimitedNatural39 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_result_LiteralInteger40 = new();
					public AcceptEventAction MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3 = new();
						public OutputPin MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result_LiteralInteger41 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result_LiteralUnlimitedNatural42 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result_LiteralInteger43 = new();
						public Trigger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_Trigger44 = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow45 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow45_LiteralBoolean46 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow45_LiteralInteger47 = new();
					public ControlFlow MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow48 = new();
					public AcceptEventAction MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start = new();
						public Trigger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger49 = new();
						public OutputPin MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_result = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralInteger50 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralUnlimitedNatural51 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralInteger52 = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow53 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow53_LiteralInteger54 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow53_LiteralBoolean55 = new();
					public AcceptEventAction MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4 = new();
						public OutputPin MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result_LiteralUnlimitedNatural56 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result_LiteralInteger57 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result_LiteralInteger58 = new();
						public Trigger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_Trigger59 = new();
					public ValueSpecificationAction MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4 = new();
						public OutputPin MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_result = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_result_LiteralInteger60 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_result_LiteralUnlimitedNatural61 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_LiteralInteger62 = new();
					public ControlFlow MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow63 = new();
					public CallOperationAction MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test_ = new();
						public InputPin MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test__target = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test__target_LiteralInteger64 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test__target_LiteralUnlimitedNatural65 = new();
					public ControlFlow MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow66 = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow67 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow67_LiteralInteger68 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow67_LiteralBoolean69 = new();
					public ControlFlow MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow70 = new();
					public AcceptEventAction MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1 = new();
						public Trigger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_Trigger71 = new();
						public OutputPin MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result_LiteralUnlimitedNatural72 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result_LiteralInteger73 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result_LiteralInteger74 = new();
					public ForkNode MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Fork_this = new();
					public ControlFlow MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow75 = new();
					public ReadStructuralFeatureAction MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c = new();
						public OutputPin MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_result_LiteralUnlimitedNatural76 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_result_LiteralInteger77 = new();
						public InputPin MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_object = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_object_LiteralUnlimitedNatural78 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_object_LiteralInteger79 = new();
					public SendSignalAction MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S = new();
						public InputPin MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_t = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_t_LiteralInteger80 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_t_LiteralUnlimitedNatural81 = new();
						public InputPin MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_target = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_target_LiteralUnlimitedNatural82 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_target_LiteralInteger83 = new();
						public InputPin MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_v = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_v_LiteralInteger84 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_v_LiteralUnlimitedNatural85 = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow86 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow86_LiteralInteger87 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow86_LiteralBoolean88 = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow89 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow89_LiteralBoolean90 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow89_LiteralInteger91 = new();
					public AcceptEventAction MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2 = new();
						public Trigger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_Trigger92 = new();
						public OutputPin MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result_LiteralUnlimitedNatural93 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result_LiteralInteger94 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result_LiteralInteger95 = new();
					public ReadSelfAction MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this = new();
						public OutputPin MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this_result = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this_result_LiteralInteger96 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this_result_LiteralUnlimitedNatural97 = new();
					public ControlFlow MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow98 = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow99 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow99_LiteralBoolean100 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow99_LiteralInteger101 = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow102 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow102_LiteralBoolean103 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow102_LiteralInteger104 = new();
				public Operation MultipleDelegation_SameConnector_P_PWP_Signal_Tester_test = new();
				public Property MultipleDelegation_SameConnector_P_PWP_Signal_Tester_c = new();
			public SignalEvent MultipleDelegation_SameConnector_P_PWP_Signal_ContinueEvent = new();
			public SignalEvent MultipleDelegation_SameConnector_P_PWP_Signal_StartEvent = new();
			public Association MultipleDelegation_SameConnector_P_PWP_Signal_U = new();
				public Property MultipleDelegation_SameConnector_P_PWP_Signal_U_x = new();
					public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_U_x_LiteralUnlimitedNatural105 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_U_x_LiteralInteger106 = new();
				public Property MultipleDelegation_SameConnector_P_PWP_Signal_U_y = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_U_y_LiteralInteger107 = new();
					public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_U_y_LiteralUnlimitedNatural108 = new();
			public Class_ MultipleDelegation_SameConnector_P_PWP_Signal_C = new();
				public Connector MultipleDelegation_SameConnector_P_PWP_Signal_C_u = new();
					public ConnectorEnd MultipleDelegation_SameConnector_P_PWP_Signal_C_u_ConnectorEnd109 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_C_u_ConnectorEnd109_LiteralInteger110 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_C_u_ConnectorEnd109_LiteralUnlimitedNatural111 = new();
					public ConnectorEnd MultipleDelegation_SameConnector_P_PWP_Signal_C_u_ConnectorEnd112 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_C_u_ConnectorEnd112_LiteralUnlimitedNatural113 = new();
				public Property MultipleDelegation_SameConnector_P_PWP_Signal_C_a = new();
					public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_C_a_LiteralUnlimitedNatural114 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_C_a_LiteralInteger115 = new();
				public Port MultipleDelegation_SameConnector_P_PWP_Signal_C_p = new();
			public Interface MultipleDelegation_SameConnector_P_PWP_Signal_I = new();
				public Reception MultipleDelegation_SameConnector_P_PWP_Signal_I_S = new();
			public Class_ MultipleDelegation_SameConnector_P_PWP_Signal_B = new();
				public Activity MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow116 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow116_LiteralBoolean117 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow116_LiteralInteger118 = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow119 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow119_LiteralBoolean120 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow119_LiteralInteger121 = new();
					public ControlFlow MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ControlFlow122 = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow123 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow123_LiteralInteger124 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow123_LiteralBoolean125 = new();
					public AcceptEventAction MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S = new();
						public Trigger MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_Trigger126 = new();
						public OutputPin MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_s = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_s_LiteralUnlimitedNatural127 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_s_LiteralInteger128 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_s_LiteralInteger129 = new();
					public AddStructuralFeatureValueAction MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p = new();
						public OutputPin MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_result_LiteralUnlimitedNatural130 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_result_LiteralInteger131 = new();
						public InputPin MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_object = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_object_LiteralInteger132 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_object_LiteralUnlimitedNatural133 = new();
						public InputPin MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_value = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_value_LiteralInteger134 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_value_LiteralUnlimitedNatural135 = new();
					public SendSignalAction MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue = new();
						public InputPin MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue_target = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue_target_LiteralUnlimitedNatural136 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue_target_LiteralInteger137 = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow138 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow138_LiteralBoolean139 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow138_LiteralInteger140 = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow141 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow141_LiteralBoolean142 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow141_LiteralInteger143 = new();
					public ReadStructuralFeatureAction MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v = new();
						public OutputPin MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_result = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_result_LiteralInteger144 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_result_LiteralUnlimitedNatural145 = new();
						public InputPin MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_object = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_object_LiteralInteger146 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_object_LiteralUnlimitedNatural147 = new();
					public ReadStructuralFeatureAction MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t = new();
						public InputPin MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_object = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_object_LiteralInteger148 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_object_LiteralUnlimitedNatural149 = new();
						public OutputPin MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_result_LiteralUnlimitedNatural150 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_result_LiteralInteger151 = new();
					public ReadSelfAction MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_this = new();
						public OutputPin MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_this_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_this_result_LiteralUnlimitedNatural152 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_this_result_LiteralInteger153 = new();
					public ForkNode MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Fork_s = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow154 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow154_LiteralBoolean155 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow154_LiteralInteger156 = new();
				public InterfaceRealization MultipleDelegation_SameConnector_P_PWP_Signal_B_IRealization = new();
				public Operation MultipleDelegation_SameConnector_P_PWP_Signal_B_B_B = new();
					public Parameter MultipleDelegation_SameConnector_P_PWP_Signal_B_B_B_result = new();
				public Property MultipleDelegation_SameConnector_P_PWP_Signal_B_p = new();
				public Reception MultipleDelegation_SameConnector_P_PWP_Signal_B_S = new();
			public Signal MultipleDelegation_SameConnector_P_PWP_Signal_Continue = new();
			public Class_ MultipleDelegation_SameConnector_P_PWP_Signal_A = new();
				public Port MultipleDelegation_SameConnector_P_PWP_Signal_A_q = new();
				public Connector MultipleDelegation_SameConnector_P_PWP_Signal_A_r = new();
					public ConnectorEnd MultipleDelegation_SameConnector_P_PWP_Signal_A_r_ConnectorEnd157 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_A_r_ConnectorEnd157_LiteralUnlimitedNatural158 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_A_r_ConnectorEnd157_LiteralInteger159 = new();
					public ConnectorEnd MultipleDelegation_SameConnector_P_PWP_Signal_A_r_ConnectorEnd160 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_A_r_ConnectorEnd160_LiteralUnlimitedNatural161 = new();
				public Operation MultipleDelegation_SameConnector_P_PWP_Signal_A_A_A = new();
					public Parameter MultipleDelegation_SameConnector_P_PWP_Signal_A_A_A_result = new();
				public Property MultipleDelegation_SameConnector_P_PWP_Signal_A_b = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_A_b_LiteralInteger162 = new();
					public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_A_b_LiteralUnlimitedNatural163 = new();
			public Association MultipleDelegation_SameConnector_P_PWP_Signal_R = new();
				public Property MultipleDelegation_SameConnector_P_PWP_Signal_R_x = new();
					public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_R_x_LiteralUnlimitedNatural164 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_R_x_LiteralInteger165 = new();
				public Property MultipleDelegation_SameConnector_P_PWP_Signal_R_y = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_R_y_LiteralInteger166 = new();
					public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_R_y_LiteralUnlimitedNatural167 = new();
			public Signal MultipleDelegation_SameConnector_P_PWP_Signal_S = new();
				public Property MultipleDelegation_SameConnector_P_PWP_Signal_S_v = new();
				public Property MultipleDelegation_SameConnector_P_PWP_Signal_S_t = new();
			public SignalEvent MultipleDelegation_SameConnector_P_PWP_Signal_SEvent = new();
			public Class_ MultipleDelegation_SameConnector_P_PWP_Signal_IImpl = new();
				public InterfaceRealization MultipleDelegation_SameConnector_P_PWP_Signal_IImpl_IRealization = new();
				public Reception MultipleDelegation_SameConnector_P_PWP_Signal_IImpl_S = new();
			public Class_ MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester = new();
				public Reception MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester_Start = new();
				public Operation MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester_test = new();
				public Reception MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester_Continue = new();
			public Activity MultipleDelegation_SameConnector_P_PWP_Signal_main = new();
				public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow168 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow168_LiteralInteger169 = new();
					public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow168_LiteralBoolean170 = new();
				public ForkNode MultipleDelegation_SameConnector_P_PWP_Signal_main_Fork_Tester = new();
				public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow171 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow171_LiteralInteger172 = new();
					public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow171_LiteralBoolean173 = new();
				public CallOperationAction MultipleDelegation_SameConnector_P_PWP_Signal_main_Tester_ = new();
					public InputPin MultipleDelegation_SameConnector_P_PWP_Signal_main_Tester__target = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_main_Tester__target_LiteralInteger174 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_main_Tester__target_LiteralUnlimitedNatural175 = new();
					public OutputPin MultipleDelegation_SameConnector_P_PWP_Signal_main_Tester__result = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_main_Tester__result_LiteralInteger176 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_main_Tester__result_LiteralInteger177 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_main_Tester__result_LiteralUnlimitedNatural178 = new();
				public StartObjectBehaviorAction MultipleDelegation_SameConnector_P_PWP_Signal_main_Start_Tester = new();
					public InputPin MultipleDelegation_SameConnector_P_PWP_Signal_main_Start_Tester_object = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_main_Start_Tester_object_LiteralUnlimitedNatural179 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_main_Start_Tester_object_LiteralInteger180 = new();
				public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow181 = new();
					public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow181_LiteralBoolean182 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow181_LiteralInteger183 = new();
				public CreateObjectAction MultipleDelegation_SameConnector_P_PWP_Signal_main_Create_Tester = new();
					public OutputPin MultipleDelegation_SameConnector_P_PWP_Signal_main_Create_Tester_result = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_main_Create_Tester_result_LiteralInteger184 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_main_Create_Tester_result_LiteralUnlimitedNatural185 = new();
				public SendSignalAction MultipleDelegation_SameConnector_P_PWP_Signal_main_Send_Start = new();
					public InputPin MultipleDelegation_SameConnector_P_PWP_Signal_main_Send_Start_target = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_main_Send_Start_target_LiteralInteger186 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_PWP_Signal_main_Send_Start_target_LiteralUnlimitedNatural187 = new();
				public ObjectFlow MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow188 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow188_LiteralInteger189 = new();
					public LiteralBoolean MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow188_LiteralBoolean190 = new();
				public ControlFlow MultipleDelegation_SameConnector_P_PWP_Signal_main_ControlFlow191 = new();
			public Signal MultipleDelegation_SameConnector_P_PWP_Signal_Start = new();

		public static MultipleDelegation_SameConnector_P_PWP_SignalModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public MultipleDelegation_SameConnector_P_PWP_SignalModel()
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
			 * Model MultipleDelegation_SameConnector_P_PWP_Signal
			 */
			AddToElementRepository("MultipleDelegation_SameConnector_P_PWP_Signal", MultipleDelegation_SameConnector_P_PWP_Signal);
				AddToElementRepository("Tester", MultipleDelegation_SameConnector_P_PWP_Signal_Tester);
					AddToElementRepository("Generalization0", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_Generalization0);
					AddToElementRepository("testActivity", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity);
						AddToElementRepository("ObjectFlow1", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow1);
							AddToElementRepository("LiteralBoolean2", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow1_LiteralBoolean2);
							AddToElementRepository("LiteralInteger3", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow1_LiteralInteger3);
						AddToElementRepository("ObjectFlow4", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow4);
							AddToElementRepository("LiteralBoolean5", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow4_LiteralBoolean5);
							AddToElementRepository("LiteralInteger6", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow4_LiteralInteger6);
						AddToElementRepository("Read a.b", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_a_b);
							AddToElementRepository("object", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_object);
								AddToElementRepository("LiteralInteger7", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_object_LiteralInteger7);
								AddToElementRepository("LiteralUnlimitedNatural8", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_object_LiteralUnlimitedNatural8);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_result);
								AddToElementRepository("LiteralInteger9", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_result_LiteralInteger9);
								AddToElementRepository("LiteralUnlimitedNatural10", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_result_LiteralUnlimitedNatural10);
						AddToElementRepository("testP", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_testP);
							AddToElementRepository("p", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_testP_p);
						AddToElementRepository("ObjectFlow11", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow11);
							AddToElementRepository("LiteralBoolean12", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow11_LiteralBoolean12);
							AddToElementRepository("LiteralInteger13", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow11_LiteralInteger13);
						AddToElementRepository("this", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_this);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_this_result);
								AddToElementRepository("LiteralUnlimitedNatural14", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_this_result_LiteralUnlimitedNatural14);
								AddToElementRepository("LiteralInteger15", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_this_result_LiteralInteger15);
						AddToElementRepository("Read this.c", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_this_c);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_result);
								AddToElementRepository("LiteralUnlimitedNatural16", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_result_LiteralUnlimitedNatural16);
								AddToElementRepository("LiteralInteger17", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_result_LiteralInteger17);
							AddToElementRepository("object", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_object);
								AddToElementRepository("LiteralInteger18", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_object_LiteralInteger18);
								AddToElementRepository("LiteralUnlimitedNatural19", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_object_LiteralUnlimitedNatural19);
						AddToElementRepository("Call testP", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Call_testP);
							AddToElementRepository("p", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Call_testP_p);
								AddToElementRepository("LiteralInteger20", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Call_testP_p_LiteralInteger20);
								AddToElementRepository("LiteralInteger21", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Call_testP_p_LiteralInteger21);
								AddToElementRepository("LiteralUnlimitedNatural22", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Call_testP_p_LiteralUnlimitedNatural22);
						AddToElementRepository("ObjectFlow23", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow23);
							AddToElementRepository("LiteralBoolean24", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow23_LiteralBoolean24);
							AddToElementRepository("LiteralInteger25", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow23_LiteralInteger25);
						AddToElementRepository("ObjectFlow26", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow26);
							AddToElementRepository("LiteralBoolean27", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow26_LiteralBoolean27);
							AddToElementRepository("LiteralInteger28", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow26_LiteralInteger28);
						AddToElementRepository("Read b.p", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_b_p);
							AddToElementRepository("object", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_object);
								AddToElementRepository("LiteralInteger29", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_object_LiteralInteger29);
								AddToElementRepository("LiteralUnlimitedNatural30", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_object_LiteralUnlimitedNatural30);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_result);
								AddToElementRepository("LiteralInteger31", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_result_LiteralInteger31);
								AddToElementRepository("LiteralUnlimitedNatural32", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_result_LiteralUnlimitedNatural32);
						AddToElementRepository("Read c.a[]", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_c_a_);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_c_a__result);
								AddToElementRepository("LiteralInteger33", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_c_a__result_LiteralInteger33);
								AddToElementRepository("LiteralUnlimitedNatural34", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_c_a__result_LiteralUnlimitedNatural34);
							AddToElementRepository("object", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_c_a__object);
								AddToElementRepository("LiteralUnlimitedNatural35", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_c_a__object_LiteralUnlimitedNatural35);
								AddToElementRepository("LiteralInteger36", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_c_a__object_LiteralInteger36);
					AddToElementRepository("Tester_Tester", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_Tester_Tester);
						AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_Tester_Tester_result);
					AddToElementRepository("TesterClassifierBehavior", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior);
						AddToElementRepository("Read c.p", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p);
							AddToElementRepository("object", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_object);
								AddToElementRepository("LiteralInteger37", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_object_LiteralInteger37);
								AddToElementRepository("LiteralUnlimitedNatural38", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_object_LiteralUnlimitedNatural38);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_result);
								AddToElementRepository("LiteralUnlimitedNatural39", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_result_LiteralUnlimitedNatural39);
								AddToElementRepository("LiteralInteger40", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_result_LiteralInteger40);
						AddToElementRepository("Accept Continue_3", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result);
								AddToElementRepository("LiteralInteger41", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result_LiteralInteger41);
								AddToElementRepository("LiteralUnlimitedNatural42", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result_LiteralUnlimitedNatural42);
								AddToElementRepository("LiteralInteger43", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result_LiteralInteger43);
							AddToElementRepository("Trigger44", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_Trigger44);
						AddToElementRepository("ObjectFlow45", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow45);
							AddToElementRepository("LiteralBoolean46", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow45_LiteralBoolean46);
							AddToElementRepository("LiteralInteger47", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow45_LiteralInteger47);
						AddToElementRepository("ControlFlow48", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow48);
						AddToElementRepository("Accept Start", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start);
							AddToElementRepository("Trigger49", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger49);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_result);
								AddToElementRepository("LiteralInteger50", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralInteger50);
								AddToElementRepository("LiteralUnlimitedNatural51", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralUnlimitedNatural51);
								AddToElementRepository("LiteralInteger52", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralInteger52);
						AddToElementRepository("ObjectFlow53", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow53);
							AddToElementRepository("LiteralInteger54", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow53_LiteralInteger54);
							AddToElementRepository("LiteralBoolean55", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow53_LiteralBoolean55);
						AddToElementRepository("Accept Continue_4", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result);
								AddToElementRepository("LiteralUnlimitedNatural56", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result_LiteralUnlimitedNatural56);
								AddToElementRepository("LiteralInteger57", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result_LiteralInteger57);
								AddToElementRepository("LiteralInteger58", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result_LiteralInteger58);
							AddToElementRepository("Trigger59", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_Trigger59);
						AddToElementRepository("Value(4)", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_result);
								AddToElementRepository("LiteralInteger60", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_result_LiteralInteger60);
								AddToElementRepository("LiteralUnlimitedNatural61", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_result_LiteralUnlimitedNatural61);
							AddToElementRepository("LiteralInteger62", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_LiteralInteger62);
						AddToElementRepository("ControlFlow63", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow63);
						AddToElementRepository("Call test()", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test_);
							AddToElementRepository("target", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test__target);
								AddToElementRepository("LiteralInteger64", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test__target_LiteralInteger64);
								AddToElementRepository("LiteralUnlimitedNatural65", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test__target_LiteralUnlimitedNatural65);
						AddToElementRepository("ControlFlow66", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow66);
						AddToElementRepository("ObjectFlow67", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow67);
							AddToElementRepository("LiteralInteger68", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow67_LiteralInteger68);
							AddToElementRepository("LiteralBoolean69", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow67_LiteralBoolean69);
						AddToElementRepository("ControlFlow70", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow70);
						AddToElementRepository("Accept Continue_1", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1);
							AddToElementRepository("Trigger71", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_Trigger71);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result);
								AddToElementRepository("LiteralUnlimitedNatural72", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result_LiteralUnlimitedNatural72);
								AddToElementRepository("LiteralInteger73", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result_LiteralInteger73);
								AddToElementRepository("LiteralInteger74", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result_LiteralInteger74);
						AddToElementRepository("Fork this", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Fork_this);
						AddToElementRepository("ControlFlow75", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow75);
						AddToElementRepository("Read this.c", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_result);
								AddToElementRepository("LiteralUnlimitedNatural76", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_result_LiteralUnlimitedNatural76);
								AddToElementRepository("LiteralInteger77", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_result_LiteralInteger77);
							AddToElementRepository("object", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_object);
								AddToElementRepository("LiteralUnlimitedNatural78", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_object_LiteralUnlimitedNatural78);
								AddToElementRepository("LiteralInteger79", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_object_LiteralInteger79);
						AddToElementRepository("Send S", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S);
							AddToElementRepository("t", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_t);
								AddToElementRepository("LiteralInteger80", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_t_LiteralInteger80);
								AddToElementRepository("LiteralUnlimitedNatural81", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_t_LiteralUnlimitedNatural81);
							AddToElementRepository("target", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_target);
								AddToElementRepository("LiteralUnlimitedNatural82", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_target_LiteralUnlimitedNatural82);
								AddToElementRepository("LiteralInteger83", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_target_LiteralInteger83);
							AddToElementRepository("v", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_v);
								AddToElementRepository("LiteralInteger84", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_v_LiteralInteger84);
								AddToElementRepository("LiteralUnlimitedNatural85", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_v_LiteralUnlimitedNatural85);
						AddToElementRepository("ObjectFlow86", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow86);
							AddToElementRepository("LiteralInteger87", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow86_LiteralInteger87);
							AddToElementRepository("LiteralBoolean88", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow86_LiteralBoolean88);
						AddToElementRepository("ObjectFlow89", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow89);
							AddToElementRepository("LiteralBoolean90", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow89_LiteralBoolean90);
							AddToElementRepository("LiteralInteger91", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow89_LiteralInteger91);
						AddToElementRepository("Accept Continue_2", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2);
							AddToElementRepository("Trigger92", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_Trigger92);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result);
								AddToElementRepository("LiteralUnlimitedNatural93", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result_LiteralUnlimitedNatural93);
								AddToElementRepository("LiteralInteger94", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result_LiteralInteger94);
								AddToElementRepository("LiteralInteger95", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result_LiteralInteger95);
						AddToElementRepository("this", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this_result);
								AddToElementRepository("LiteralInteger96", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this_result_LiteralInteger96);
								AddToElementRepository("LiteralUnlimitedNatural97", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this_result_LiteralUnlimitedNatural97);
						AddToElementRepository("ControlFlow98", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow98);
						AddToElementRepository("ObjectFlow99", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow99);
							AddToElementRepository("LiteralBoolean100", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow99_LiteralBoolean100);
							AddToElementRepository("LiteralInteger101", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow99_LiteralInteger101);
						AddToElementRepository("ObjectFlow102", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow102);
							AddToElementRepository("LiteralBoolean103", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow102_LiteralBoolean103);
							AddToElementRepository("LiteralInteger104", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow102_LiteralInteger104);
					AddToElementRepository("test", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_test);
					AddToElementRepository("c", MultipleDelegation_SameConnector_P_PWP_Signal_Tester_c);
				AddToElementRepository("ContinueEvent", MultipleDelegation_SameConnector_P_PWP_Signal_ContinueEvent);
				AddToElementRepository("StartEvent", MultipleDelegation_SameConnector_P_PWP_Signal_StartEvent);
				AddToElementRepository("U", MultipleDelegation_SameConnector_P_PWP_Signal_U);
					AddToElementRepository("x", MultipleDelegation_SameConnector_P_PWP_Signal_U_x);
						AddToElementRepository("LiteralUnlimitedNatural105", MultipleDelegation_SameConnector_P_PWP_Signal_U_x_LiteralUnlimitedNatural105);
						AddToElementRepository("LiteralInteger106", MultipleDelegation_SameConnector_P_PWP_Signal_U_x_LiteralInteger106);
					AddToElementRepository("y", MultipleDelegation_SameConnector_P_PWP_Signal_U_y);
						AddToElementRepository("LiteralInteger107", MultipleDelegation_SameConnector_P_PWP_Signal_U_y_LiteralInteger107);
						AddToElementRepository("LiteralUnlimitedNatural108", MultipleDelegation_SameConnector_P_PWP_Signal_U_y_LiteralUnlimitedNatural108);
				AddToElementRepository("C", MultipleDelegation_SameConnector_P_PWP_Signal_C);
					AddToElementRepository("u", MultipleDelegation_SameConnector_P_PWP_Signal_C_u);
						AddToElementRepository("ConnectorEnd109", MultipleDelegation_SameConnector_P_PWP_Signal_C_u_ConnectorEnd109);
							AddToElementRepository("LiteralInteger110", MultipleDelegation_SameConnector_P_PWP_Signal_C_u_ConnectorEnd109_LiteralInteger110);
							AddToElementRepository("LiteralUnlimitedNatural111", MultipleDelegation_SameConnector_P_PWP_Signal_C_u_ConnectorEnd109_LiteralUnlimitedNatural111);
						AddToElementRepository("ConnectorEnd112", MultipleDelegation_SameConnector_P_PWP_Signal_C_u_ConnectorEnd112);
							AddToElementRepository("LiteralUnlimitedNatural113", MultipleDelegation_SameConnector_P_PWP_Signal_C_u_ConnectorEnd112_LiteralUnlimitedNatural113);
					AddToElementRepository("a", MultipleDelegation_SameConnector_P_PWP_Signal_C_a);
						AddToElementRepository("LiteralUnlimitedNatural114", MultipleDelegation_SameConnector_P_PWP_Signal_C_a_LiteralUnlimitedNatural114);
						AddToElementRepository("LiteralInteger115", MultipleDelegation_SameConnector_P_PWP_Signal_C_a_LiteralInteger115);
					AddToElementRepository("p", MultipleDelegation_SameConnector_P_PWP_Signal_C_p);
				AddToElementRepository("I", MultipleDelegation_SameConnector_P_PWP_Signal_I);
					AddToElementRepository("S", MultipleDelegation_SameConnector_P_PWP_Signal_I_S);
				AddToElementRepository("B", MultipleDelegation_SameConnector_P_PWP_Signal_B);
					AddToElementRepository("BClassifierBehavior", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior);
						AddToElementRepository("ObjectFlow116", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow116);
							AddToElementRepository("LiteralBoolean117", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow116_LiteralBoolean117);
							AddToElementRepository("LiteralInteger118", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow116_LiteralInteger118);
						AddToElementRepository("ObjectFlow119", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow119);
							AddToElementRepository("LiteralBoolean120", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow119_LiteralBoolean120);
							AddToElementRepository("LiteralInteger121", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow119_LiteralInteger121);
						AddToElementRepository("ControlFlow122", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ControlFlow122);
						AddToElementRepository("ObjectFlow123", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow123);
							AddToElementRepository("LiteralInteger124", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow123_LiteralInteger124);
							AddToElementRepository("LiteralBoolean125", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow123_LiteralBoolean125);
						AddToElementRepository("Accept S", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S);
							AddToElementRepository("Trigger126", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_Trigger126);
							AddToElementRepository("s", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_s);
								AddToElementRepository("LiteralUnlimitedNatural127", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_s_LiteralUnlimitedNatural127);
								AddToElementRepository("LiteralInteger128", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_s_LiteralInteger128);
								AddToElementRepository("LiteralInteger129", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_s_LiteralInteger129);
						AddToElementRepository("Set this.p", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_result);
								AddToElementRepository("LiteralUnlimitedNatural130", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_result_LiteralUnlimitedNatural130);
								AddToElementRepository("LiteralInteger131", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_result_LiteralInteger131);
							AddToElementRepository("object", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_object);
								AddToElementRepository("LiteralInteger132", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_object_LiteralInteger132);
								AddToElementRepository("LiteralUnlimitedNatural133", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_object_LiteralUnlimitedNatural133);
							AddToElementRepository("value", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_value);
								AddToElementRepository("LiteralInteger134", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_value_LiteralInteger134);
								AddToElementRepository("LiteralUnlimitedNatural135", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_value_LiteralUnlimitedNatural135);
						AddToElementRepository("Send Continue", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue);
							AddToElementRepository("target", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue_target);
								AddToElementRepository("LiteralUnlimitedNatural136", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue_target_LiteralUnlimitedNatural136);
								AddToElementRepository("LiteralInteger137", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue_target_LiteralInteger137);
						AddToElementRepository("ObjectFlow138", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow138);
							AddToElementRepository("LiteralBoolean139", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow138_LiteralBoolean139);
							AddToElementRepository("LiteralInteger140", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow138_LiteralInteger140);
						AddToElementRepository("ObjectFlow141", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow141);
							AddToElementRepository("LiteralBoolean142", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow141_LiteralBoolean142);
							AddToElementRepository("LiteralInteger143", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow141_LiteralInteger143);
						AddToElementRepository("Read s.v", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_result);
								AddToElementRepository("LiteralInteger144", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_result_LiteralInteger144);
								AddToElementRepository("LiteralUnlimitedNatural145", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_result_LiteralUnlimitedNatural145);
							AddToElementRepository("object", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_object);
								AddToElementRepository("LiteralInteger146", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_object_LiteralInteger146);
								AddToElementRepository("LiteralUnlimitedNatural147", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_object_LiteralUnlimitedNatural147);
						AddToElementRepository("Read s.t", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t);
							AddToElementRepository("object", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_object);
								AddToElementRepository("LiteralInteger148", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_object_LiteralInteger148);
								AddToElementRepository("LiteralUnlimitedNatural149", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_object_LiteralUnlimitedNatural149);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_result);
								AddToElementRepository("LiteralUnlimitedNatural150", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_result_LiteralUnlimitedNatural150);
								AddToElementRepository("LiteralInteger151", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_result_LiteralInteger151);
						AddToElementRepository("this", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_this);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_this_result);
								AddToElementRepository("LiteralUnlimitedNatural152", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_this_result_LiteralUnlimitedNatural152);
								AddToElementRepository("LiteralInteger153", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_this_result_LiteralInteger153);
						AddToElementRepository("Fork s", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Fork_s);
						AddToElementRepository("ObjectFlow154", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow154);
							AddToElementRepository("LiteralBoolean155", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow154_LiteralBoolean155);
							AddToElementRepository("LiteralInteger156", MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow154_LiteralInteger156);
					AddToElementRepository("IRealization", MultipleDelegation_SameConnector_P_PWP_Signal_B_IRealization);
					AddToElementRepository("B_B", MultipleDelegation_SameConnector_P_PWP_Signal_B_B_B);
						AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Signal_B_B_B_result);
					AddToElementRepository("p", MultipleDelegation_SameConnector_P_PWP_Signal_B_p);
					AddToElementRepository("S", MultipleDelegation_SameConnector_P_PWP_Signal_B_S);
				AddToElementRepository("Continue", MultipleDelegation_SameConnector_P_PWP_Signal_Continue);
				AddToElementRepository("A", MultipleDelegation_SameConnector_P_PWP_Signal_A);
					AddToElementRepository("q", MultipleDelegation_SameConnector_P_PWP_Signal_A_q);
					AddToElementRepository("r", MultipleDelegation_SameConnector_P_PWP_Signal_A_r);
						AddToElementRepository("ConnectorEnd157", MultipleDelegation_SameConnector_P_PWP_Signal_A_r_ConnectorEnd157);
							AddToElementRepository("LiteralUnlimitedNatural158", MultipleDelegation_SameConnector_P_PWP_Signal_A_r_ConnectorEnd157_LiteralUnlimitedNatural158);
							AddToElementRepository("LiteralInteger159", MultipleDelegation_SameConnector_P_PWP_Signal_A_r_ConnectorEnd157_LiteralInteger159);
						AddToElementRepository("ConnectorEnd160", MultipleDelegation_SameConnector_P_PWP_Signal_A_r_ConnectorEnd160);
							AddToElementRepository("LiteralUnlimitedNatural161", MultipleDelegation_SameConnector_P_PWP_Signal_A_r_ConnectorEnd160_LiteralUnlimitedNatural161);
					AddToElementRepository("A_A", MultipleDelegation_SameConnector_P_PWP_Signal_A_A_A);
						AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Signal_A_A_A_result);
					AddToElementRepository("b", MultipleDelegation_SameConnector_P_PWP_Signal_A_b);
						AddToElementRepository("LiteralInteger162", MultipleDelegation_SameConnector_P_PWP_Signal_A_b_LiteralInteger162);
						AddToElementRepository("LiteralUnlimitedNatural163", MultipleDelegation_SameConnector_P_PWP_Signal_A_b_LiteralUnlimitedNatural163);
				AddToElementRepository("R", MultipleDelegation_SameConnector_P_PWP_Signal_R);
					AddToElementRepository("x", MultipleDelegation_SameConnector_P_PWP_Signal_R_x);
						AddToElementRepository("LiteralUnlimitedNatural164", MultipleDelegation_SameConnector_P_PWP_Signal_R_x_LiteralUnlimitedNatural164);
						AddToElementRepository("LiteralInteger165", MultipleDelegation_SameConnector_P_PWP_Signal_R_x_LiteralInteger165);
					AddToElementRepository("y", MultipleDelegation_SameConnector_P_PWP_Signal_R_y);
						AddToElementRepository("LiteralInteger166", MultipleDelegation_SameConnector_P_PWP_Signal_R_y_LiteralInteger166);
						AddToElementRepository("LiteralUnlimitedNatural167", MultipleDelegation_SameConnector_P_PWP_Signal_R_y_LiteralUnlimitedNatural167);
				AddToElementRepository("S", MultipleDelegation_SameConnector_P_PWP_Signal_S);
					AddToElementRepository("v", MultipleDelegation_SameConnector_P_PWP_Signal_S_v);
					AddToElementRepository("t", MultipleDelegation_SameConnector_P_PWP_Signal_S_t);
				AddToElementRepository("SEvent", MultipleDelegation_SameConnector_P_PWP_Signal_SEvent);
				AddToElementRepository("IImpl", MultipleDelegation_SameConnector_P_PWP_Signal_IImpl);
					AddToElementRepository("IRealization", MultipleDelegation_SameConnector_P_PWP_Signal_IImpl_IRealization);
					AddToElementRepository("S", MultipleDelegation_SameConnector_P_PWP_Signal_IImpl_S);
				AddToElementRepository("AbstractTester", MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester);
					AddToElementRepository("Start", MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester_Start);
					AddToElementRepository("test", MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester_test);
					AddToElementRepository("Continue", MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester_Continue);
				AddToElementRepository("main", MultipleDelegation_SameConnector_P_PWP_Signal_main);
					AddToElementRepository("ObjectFlow168", MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow168);
						AddToElementRepository("LiteralInteger169", MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow168_LiteralInteger169);
						AddToElementRepository("LiteralBoolean170", MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow168_LiteralBoolean170);
					AddToElementRepository("Fork Tester", MultipleDelegation_SameConnector_P_PWP_Signal_main_Fork_Tester);
					AddToElementRepository("ObjectFlow171", MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow171);
						AddToElementRepository("LiteralInteger172", MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow171_LiteralInteger172);
						AddToElementRepository("LiteralBoolean173", MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow171_LiteralBoolean173);
					AddToElementRepository("Tester()", MultipleDelegation_SameConnector_P_PWP_Signal_main_Tester_);
						AddToElementRepository("target", MultipleDelegation_SameConnector_P_PWP_Signal_main_Tester__target);
							AddToElementRepository("LiteralInteger174", MultipleDelegation_SameConnector_P_PWP_Signal_main_Tester__target_LiteralInteger174);
							AddToElementRepository("LiteralUnlimitedNatural175", MultipleDelegation_SameConnector_P_PWP_Signal_main_Tester__target_LiteralUnlimitedNatural175);
						AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Signal_main_Tester__result);
							AddToElementRepository("LiteralInteger176", MultipleDelegation_SameConnector_P_PWP_Signal_main_Tester__result_LiteralInteger176);
							AddToElementRepository("LiteralInteger177", MultipleDelegation_SameConnector_P_PWP_Signal_main_Tester__result_LiteralInteger177);
							AddToElementRepository("LiteralUnlimitedNatural178", MultipleDelegation_SameConnector_P_PWP_Signal_main_Tester__result_LiteralUnlimitedNatural178);
					AddToElementRepository("Start Tester", MultipleDelegation_SameConnector_P_PWP_Signal_main_Start_Tester);
						AddToElementRepository("object", MultipleDelegation_SameConnector_P_PWP_Signal_main_Start_Tester_object);
							AddToElementRepository("LiteralUnlimitedNatural179", MultipleDelegation_SameConnector_P_PWP_Signal_main_Start_Tester_object_LiteralUnlimitedNatural179);
							AddToElementRepository("LiteralInteger180", MultipleDelegation_SameConnector_P_PWP_Signal_main_Start_Tester_object_LiteralInteger180);
					AddToElementRepository("ObjectFlow181", MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow181);
						AddToElementRepository("LiteralBoolean182", MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow181_LiteralBoolean182);
						AddToElementRepository("LiteralInteger183", MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow181_LiteralInteger183);
					AddToElementRepository("Create Tester", MultipleDelegation_SameConnector_P_PWP_Signal_main_Create_Tester);
						AddToElementRepository("result", MultipleDelegation_SameConnector_P_PWP_Signal_main_Create_Tester_result);
							AddToElementRepository("LiteralInteger184", MultipleDelegation_SameConnector_P_PWP_Signal_main_Create_Tester_result_LiteralInteger184);
							AddToElementRepository("LiteralUnlimitedNatural185", MultipleDelegation_SameConnector_P_PWP_Signal_main_Create_Tester_result_LiteralUnlimitedNatural185);
					AddToElementRepository("Send Start", MultipleDelegation_SameConnector_P_PWP_Signal_main_Send_Start);
						AddToElementRepository("target", MultipleDelegation_SameConnector_P_PWP_Signal_main_Send_Start_target);
							AddToElementRepository("LiteralInteger186", MultipleDelegation_SameConnector_P_PWP_Signal_main_Send_Start_target_LiteralInteger186);
							AddToElementRepository("LiteralUnlimitedNatural187", MultipleDelegation_SameConnector_P_PWP_Signal_main_Send_Start_target_LiteralUnlimitedNatural187);
					AddToElementRepository("ObjectFlow188", MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow188);
						AddToElementRepository("LiteralInteger189", MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow188_LiteralInteger189);
						AddToElementRepository("LiteralBoolean190", MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow188_LiteralBoolean190);
					AddToElementRepository("ControlFlow191", MultipleDelegation_SameConnector_P_PWP_Signal_main_ControlFlow191);
				AddToElementRepository("Start", MultipleDelegation_SameConnector_P_PWP_Signal_Start);

			// Initialize public members
			/*
			 * Model MultipleDelegation_SameConnector_P_PWP_Signal
			 */
			MultipleDelegation_SameConnector_P_PWP_Signal.SetName("MultipleDelegation_SameConnector_P_PWP_Signal");
			MultipleDelegation_SameConnector_P_PWP_Signal.SetVisibility(VisibilityKind.public_);
				// Class Tester
				MultipleDelegation_SameConnector_P_PWP_Signal_Tester.SetName("Tester");
				MultipleDelegation_SameConnector_P_PWP_Signal_Tester.SetVisibility(VisibilityKind.public_);
				
					// Generalization to AbstractTester
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_Generalization0.SetGeneral(MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester);
				MultipleDelegation_SameConnector_P_PWP_Signal_Tester.AddGeneralization(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_Generalization0);
					// Property c
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_c.SetName("c");
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_c.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_c.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_C);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_c.SetAggregation(AggregationKind.composite);
				MultipleDelegation_SameConnector_P_PWP_Signal_Tester.AddOwnedAttribute(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_c);
				MultipleDelegation_SameConnector_P_PWP_Signal_Tester.SetClassifierBehavior(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior);
					// Activity testActivity
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity.SetName("testActivity");
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity.SetVisibility(VisibilityKind.public_);
					// FunctionBehavior testP
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_testP.SetName("testP");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_testP.SetVisibility(VisibilityKind.public_);
						
							// Parameter p
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_testP_p.SetName("p");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_testP_p.SetVisibility(VisibilityKind.public_);
							
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_testP.AddOwnedParameter(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_testP_p);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_testP.AddLanguage("C#");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_testP.AddLanguage("Using");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_testP.AddBody("if(index == 1) 	{ 		Console.WriteLine(\"Asserting c.a[1].b.p == 4 && c.a[2].b.p == 4 && c.a[3].b.p == 4 && c.a[4].b.p == 4\"); 	}  	// Test parameter p 	int p = ((IntegerValue)inputParameters.ElementAt(0).values.ElementAt(0)).value; 	Debug.Println(\"[doBody] argument p = \" + p); 	 	Console.WriteLine( \"c.a[\" + index + \"].b.p == \" + p); 	success = success && (p == 4); 	if(index == MAX_INDEX) 	{  		Console.Write(\"Signal delegated on all links (shall be true for default strategy): \");  		if(success) 		{ 			Console.ForegroundColor = ConsoleColor.Green; 			Console.WriteLine(\"Assertion successful.\"); 		} 		else 		{ 			Console.ForegroundColor = ConsoleColor.Red; 			Console.WriteLine(\"Assertion failed!\"); 		}  		Console.ResetColor(); 	}  	index++;");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_testP.AddBody("using fuml.semantics.simpleclassifiers;");
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity.AddOwnedBehavior(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_testP);
						// ReadStructuralFeatureAction Read a.b
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_a_b.SetName("Read a.b");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_a_b.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_a_b.SetStructuralFeature(MultipleDelegation_SameConnector_P_PWP_Signal_A_b);
							// InputPin object
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_object.SetName("object");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_object.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_A);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_a_b.SetObject(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_object);
							// OutputPin result
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_result.SetName("result");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_result.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_B);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_result.SetUpper(4);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_result.SetLower(4);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_a_b.SetResult(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_result);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity.AddNode(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_a_b);
						// ReadSelfAction this
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_this.SetName("this");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_this_result.SetName("result");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_this_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_this_result.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_Tester);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_this.SetResult(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_this_result);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity.AddNode(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_this);
						// ReadStructuralFeatureAction Read this.c
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_this_c.SetName("Read this.c");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_this_c.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_this_c.SetStructuralFeature(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_c);
							// InputPin object
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_object.SetName("object");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_object.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_Tester);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_this_c.SetObject(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_object);
							// OutputPin result
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_result.SetName("result");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_result.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_C);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_this_c.SetResult(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_result);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity.AddNode(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_this_c);
						// CallBehaviorAction Call testP
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Call_testP.SetName("Call testP");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Call_testP.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Call_testP.SetBehavior(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_testP);
							// InputPin p
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Call_testP_p.SetName("p");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Call_testP_p.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Call_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Call_testP.AddArgument(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Call_testP_p);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity.AddNode(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Call_testP);
						// ReadStructuralFeatureAction Read b.p
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_b_p.SetName("Read b.p");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_b_p.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_b_p.SetStructuralFeature(MultipleDelegation_SameConnector_P_PWP_Signal_B_p);
							// InputPin object
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_object.SetName("object");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_object.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_B);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_b_p.SetObject(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_object);
							// OutputPin result
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_result.SetName("result");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_b_p.SetResult(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_result);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity.AddNode(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_b_p);
						// ReadStructuralFeatureAction Read c.a[]
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_c_a_.SetName("Read c.a[]");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_c_a_.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_c_a_.SetStructuralFeature(MultipleDelegation_SameConnector_P_PWP_Signal_C_a);
							// InputPin object
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_c_a__object.SetName("object");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_c_a__object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_c_a__object.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_C);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_c_a_.SetObject(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_c_a__object);
							// OutputPin result
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_c_a__result.SetName("result");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_c_a__result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_c_a__result.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_A);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_c_a__result.SetUpper(4);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_c_a__result.SetLower(4);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_c_a_.SetResult(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_c_a__result);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity.AddNode(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_c_a_);
						// ObjectFlow ObjectFlow4 from result to object
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow4.SetName("ObjectFlow4");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow4.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow4.SetSource(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_result);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow4.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_object);
							// LiteralBoolean LiteralBoolean5
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow4_LiteralBoolean5.SetName("LiteralBoolean5");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow4_LiteralBoolean5.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow4_LiteralBoolean5.SetValue(true);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow4.SetGuard(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow4_LiteralBoolean5);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity.AddEdge(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow4);
						// ObjectFlow ObjectFlow1 from result to object
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow1.SetName("ObjectFlow1");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow1.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow1.SetSource(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_c_a__result);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow1.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_object);
							// LiteralBoolean LiteralBoolean2
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow1_LiteralBoolean2.SetName("LiteralBoolean2");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow1_LiteralBoolean2.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow1_LiteralBoolean2.SetValue(true);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow1.SetGuard(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow1_LiteralBoolean2);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity.AddEdge(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow1);
						// ObjectFlow ObjectFlow11 from result to p
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow11.SetName("ObjectFlow11");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow11.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow11.SetSource(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_result);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow11.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Call_testP_p);
							// LiteralBoolean LiteralBoolean12
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow11_LiteralBoolean12.SetName("LiteralBoolean12");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow11_LiteralBoolean12.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow11_LiteralBoolean12.SetValue(true);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow11.SetGuard(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow11_LiteralBoolean12);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity.AddEdge(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow11);
						// ObjectFlow ObjectFlow23 from result to object
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow23.SetName("ObjectFlow23");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow23.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow23.SetSource(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_this_result);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow23.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_object);
							// LiteralBoolean LiteralBoolean24
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow23_LiteralBoolean24.SetName("LiteralBoolean24");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow23_LiteralBoolean24.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow23_LiteralBoolean24.SetValue(true);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow23.SetGuard(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow23_LiteralBoolean24);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity.AddEdge(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow23);
						// ObjectFlow ObjectFlow26 from result to object
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow26.SetName("ObjectFlow26");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow26.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow26.SetSource(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_result);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow26.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_Read_c_a__object);
							// LiteralBoolean LiteralBoolean27
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow26_LiteralBoolean27.SetName("LiteralBoolean27");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow26_LiteralBoolean27.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow26_LiteralBoolean27.SetValue(true);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow26.SetGuard(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow26_LiteralBoolean27);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity.AddEdge(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow26);
				MultipleDelegation_SameConnector_P_PWP_Signal_Tester.AddOwnedBehavior(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity);
					// Activity TesterClassifierBehavior
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.SetName("TesterClassifierBehavior");
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.SetVisibility(VisibilityKind.public_);
						// ForkNode Fork this
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Fork_this.SetName("Fork this");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Fork_this.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Fork_this);
						// ReadStructuralFeatureAction Read c.p
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p.SetName("Read c.p");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p.SetStructuralFeature(MultipleDelegation_SameConnector_P_PWP_Signal_C_p);
							// InputPin object
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_object.SetName("object");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_object.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_C);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p.SetObject(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_object);
							// OutputPin result
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_result.SetName("result");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_result.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_IImpl);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p.SetResult(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_result);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p);
						// AcceptEventAction Accept Continue_3
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3.SetName("Accept Continue_3");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result.SetName("result");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_Continue);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3.AddResult(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result);
							// Trigger Trigger44
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_Trigger44.SetName("Trigger44");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_Trigger44.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_Trigger44.SetEvent(MultipleDelegation_SameConnector_P_PWP_Signal_ContinueEvent);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3.AddTrigger(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_Trigger44);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3);
						// ReadStructuralFeatureAction Read this.c
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c.SetName("Read this.c");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c.SetStructuralFeature(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_c);
							// InputPin object
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_object.SetName("object");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_object.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_Tester);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c.SetObject(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_object);
							// OutputPin result
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_result.SetName("result");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_result.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_C);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c.SetResult(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_result);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c);
						// SendSignalAction Send S
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S.SetName("Send S");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S.SetSignal(MultipleDelegation_SameConnector_P_PWP_Signal_S);
							// InputPin target
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_target.SetName("target");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_target.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_target.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_IImpl);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_target);
							// InputPin v
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_v.SetName("v");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_v.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S.AddArgument(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_v);
							// InputPin t
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_t.SetName("t");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_t.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_t.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S.AddArgument(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_t);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S);
						// AcceptEventAction Accept Continue_2
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2.SetName("Accept Continue_2");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result.SetName("result");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_Continue);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2.AddResult(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result);
							// Trigger Trigger92
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_Trigger92.SetName("Trigger92");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_Trigger92.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_Trigger92.SetEvent(MultipleDelegation_SameConnector_P_PWP_Signal_ContinueEvent);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2.AddTrigger(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_Trigger92);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2);
						// AcceptEventAction Accept Start
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start.SetName("Accept Start");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_result.SetName("result");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_result.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_Start);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start.AddResult(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_result);
							// Trigger Trigger49
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger49.SetName("Trigger49");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger49.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger49.SetEvent(MultipleDelegation_SameConnector_P_PWP_Signal_StartEvent);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start.AddTrigger(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger49);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start);
						// ReadSelfAction this
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this.SetName("this");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this_result.SetName("result");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this_result.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_Tester);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this.SetResult(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this_result);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this);
						// AcceptEventAction Accept Continue_4
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4.SetName("Accept Continue_4");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result.SetName("result");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_Continue);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4.AddResult(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result);
							// Trigger Trigger59
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_Trigger59.SetName("Trigger59");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_Trigger59.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_Trigger59.SetEvent(MultipleDelegation_SameConnector_P_PWP_Signal_ContinueEvent);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4.AddTrigger(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_Trigger59);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4);
						// ValueSpecificationAction Value(4)
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4.SetName("Value(4)");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4.SetVisibility(VisibilityKind.public_);
							// LiteralInteger LiteralInteger62
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_LiteralInteger62.SetName("LiteralInteger62");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_LiteralInteger62.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_LiteralInteger62.SetValue(4);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4.SetValue(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_LiteralInteger62);
							// OutputPin result
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_result.SetName("result");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4.SetResult(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_result);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4);
						// CallOperationAction Call test()
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test_.SetName("Call test()");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test_.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test_.SetOperation(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_test);
							// InputPin target
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test__target.SetName("target");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test__target.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test__target.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_Tester);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test_.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test__target);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test_);
						// AcceptEventAction Accept Continue_1
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1.SetName("Accept Continue_1");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result.SetName("result");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_Continue);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1.AddResult(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result);
							// Trigger Trigger71
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_Trigger71.SetName("Trigger71");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_Trigger71.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_Trigger71.SetEvent(MultipleDelegation_SameConnector_P_PWP_Signal_ContinueEvent);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1.AddTrigger(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_Trigger71);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1);
						// ControlFlow ControlFlow75 from Send S to Accept Continue_1
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow75.SetName("ControlFlow75");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow75.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow75.SetSource(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow75.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow75);
						// ObjectFlow ObjectFlow86 from Fork this to t
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow86.SetName("ObjectFlow86");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow86.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow86.SetSource(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Fork_this);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow86.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_t);
							// LiteralBoolean LiteralBoolean88
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow86_LiteralBoolean88.SetName("LiteralBoolean88");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow86_LiteralBoolean88.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow86_LiteralBoolean88.SetValue(true);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow86.SetGuard(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow86_LiteralBoolean88);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow86);
						// ObjectFlow ObjectFlow89 from result to object
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow89.SetName("ObjectFlow89");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow89.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow89.SetSource(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_result);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow89.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_object);
							// LiteralBoolean LiteralBoolean90
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow89_LiteralBoolean90.SetName("LiteralBoolean90");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow89_LiteralBoolean90.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow89_LiteralBoolean90.SetValue(true);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow89.SetGuard(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow89_LiteralBoolean90);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow89);
						// ObjectFlow ObjectFlow45 from result to v
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow45.SetName("ObjectFlow45");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow45.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow45.SetSource(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_result);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow45.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_v);
							// LiteralBoolean LiteralBoolean46
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow45_LiteralBoolean46.SetName("LiteralBoolean46");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow45_LiteralBoolean46.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow45_LiteralBoolean46.SetValue(true);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow45.SetGuard(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow45_LiteralBoolean46);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow45);
						// ControlFlow ControlFlow48 from Accept Continue_3 to Accept Continue_4
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow48.SetName("ControlFlow48");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow48.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow48.SetSource(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow48.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow48);
						// ObjectFlow ObjectFlow53 from Fork this to object
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow53.SetName("ObjectFlow53");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow53.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow53.SetSource(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Fork_this);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow53.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_object);
							// LiteralBoolean LiteralBoolean55
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow53_LiteralBoolean55.SetName("LiteralBoolean55");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow53_LiteralBoolean55.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow53_LiteralBoolean55.SetValue(true);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow53.SetGuard(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow53_LiteralBoolean55);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow53);
						// ControlFlow ControlFlow98 from Accept Continue_2 to Accept Continue_3
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow98.SetName("ControlFlow98");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow98.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow98.SetSource(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow98.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow98);
						// ObjectFlow ObjectFlow99 from result to Fork this
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow99.SetName("ObjectFlow99");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow99.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow99.SetSource(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this_result);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow99.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Fork_this);
							// LiteralBoolean LiteralBoolean100
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow99_LiteralBoolean100.SetName("LiteralBoolean100");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow99_LiteralBoolean100.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow99_LiteralBoolean100.SetValue(true);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow99.SetGuard(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow99_LiteralBoolean100);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow99);
						// ControlFlow ControlFlow63 from Accept Start to this
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow63.SetName("ControlFlow63");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow63.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow63.SetSource(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow63.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow63);
						// ObjectFlow ObjectFlow102 from result to target
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow102.SetName("ObjectFlow102");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow102.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow102.SetSource(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_result);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow102.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_target);
							// LiteralBoolean LiteralBoolean103
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow102_LiteralBoolean103.SetName("LiteralBoolean103");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow102_LiteralBoolean103.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow102_LiteralBoolean103.SetValue(true);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow102.SetGuard(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow102_LiteralBoolean103);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow102);
						// ControlFlow ControlFlow66 from Accept Continue_4 to Call test()
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow66.SetName("ControlFlow66");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow66.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow66.SetSource(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow66.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test_);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow66);
						// ObjectFlow ObjectFlow67 from Fork this to target
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow67.SetName("ObjectFlow67");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow67.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow67.SetSource(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Fork_this);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow67.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test__target);
							// LiteralBoolean LiteralBoolean69
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow67_LiteralBoolean69.SetName("LiteralBoolean69");
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow67_LiteralBoolean69.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow67_LiteralBoolean69.SetValue(true);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow67.SetGuard(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow67_LiteralBoolean69);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow67);
						// ControlFlow ControlFlow70 from Accept Continue_1 to Accept Continue_2
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow70.SetName("ControlFlow70");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow70.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow70.SetSource(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow70.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow70);
				MultipleDelegation_SameConnector_P_PWP_Signal_Tester.AddOwnedBehavior(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_TesterClassifierBehavior);
				
				MultipleDelegation_SameConnector_P_PWP_Signal_Tester.SetIsActive(true);
					// Operation Tester_Tester
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_Tester_Tester.SetName("Tester_Tester");
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_Tester_Tester.SetVisibility(VisibilityKind.public_);
						// Parameter result
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_Tester_Tester_result.SetName("result");
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_Tester_Tester_result.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_Tester_Tester_result.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_Tester);
						MultipleDelegation_SameConnector_P_PWP_Signal_Tester_Tester_Tester_result.SetDirection(ParameterDirectionKind.return_);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_Tester_Tester.AddOwnedParameter(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_Tester_Tester_result);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_Tester_Tester.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				MultipleDelegation_SameConnector_P_PWP_Signal_Tester.AddOwnedOperation(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_Tester_Tester);
					// Operation test
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_test.SetName("test");
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_test.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_PWP_Signal_Tester_test.AddMethod(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_testActivity);
				MultipleDelegation_SameConnector_P_PWP_Signal_Tester.AddOwnedOperation(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_test);
			MultipleDelegation_SameConnector_P_PWP_Signal.AddPackagedElement(MultipleDelegation_SameConnector_P_PWP_Signal_Tester);
				// SignalEvent ContinueEvent
				MultipleDelegation_SameConnector_P_PWP_Signal_ContinueEvent.SetName("ContinueEvent");
				MultipleDelegation_SameConnector_P_PWP_Signal_ContinueEvent.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_SameConnector_P_PWP_Signal_ContinueEvent.SetSignal(MultipleDelegation_SameConnector_P_PWP_Signal_Continue);
			MultipleDelegation_SameConnector_P_PWP_Signal.AddPackagedElement(MultipleDelegation_SameConnector_P_PWP_Signal_ContinueEvent);
				// SignalEvent StartEvent
				MultipleDelegation_SameConnector_P_PWP_Signal_StartEvent.SetName("StartEvent");
				MultipleDelegation_SameConnector_P_PWP_Signal_StartEvent.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_SameConnector_P_PWP_Signal_StartEvent.SetSignal(MultipleDelegation_SameConnector_P_PWP_Signal_Start);
			MultipleDelegation_SameConnector_P_PWP_Signal.AddPackagedElement(MultipleDelegation_SameConnector_P_PWP_Signal_StartEvent);
				// Association U
				MultipleDelegation_SameConnector_P_PWP_Signal_U.SetName("U");
				MultipleDelegation_SameConnector_P_PWP_Signal_U.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_SameConnector_P_PWP_Signal_U.AddOwnedEnd(MultipleDelegation_SameConnector_P_PWP_Signal_U_x);
				MultipleDelegation_SameConnector_P_PWP_Signal_U.AddOwnedEnd(MultipleDelegation_SameConnector_P_PWP_Signal_U_y);
			MultipleDelegation_SameConnector_P_PWP_Signal.AddPackagedElement(MultipleDelegation_SameConnector_P_PWP_Signal_U);
				// Class C
				MultipleDelegation_SameConnector_P_PWP_Signal_C.SetName("C");
				MultipleDelegation_SameConnector_P_PWP_Signal_C.SetVisibility(VisibilityKind.public_);
				
					// Port p
					MultipleDelegation_SameConnector_P_PWP_Signal_C_p.SetName("p");
					MultipleDelegation_SameConnector_P_PWP_Signal_C_p.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_PWP_Signal_C_p.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_IImpl);
					MultipleDelegation_SameConnector_P_PWP_Signal_C_p.SetAggregation(AggregationKind.composite);
					MultipleDelegation_SameConnector_P_PWP_Signal_C_p.isService = true;
					MultipleDelegation_SameConnector_P_PWP_Signal_C_p.AddProvided(MultipleDelegation_SameConnector_P_PWP_Signal_I);
				MultipleDelegation_SameConnector_P_PWP_Signal_C.AddOwnedAttribute(MultipleDelegation_SameConnector_P_PWP_Signal_C_p);
					// Property a
					MultipleDelegation_SameConnector_P_PWP_Signal_C_a.SetName("a");
					MultipleDelegation_SameConnector_P_PWP_Signal_C_a.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_PWP_Signal_C_a.SetUpper(4);
					MultipleDelegation_SameConnector_P_PWP_Signal_C_a.SetLower(4);
					MultipleDelegation_SameConnector_P_PWP_Signal_C_a.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_A);
					MultipleDelegation_SameConnector_P_PWP_Signal_C_a.SetAggregation(AggregationKind.composite);
				MultipleDelegation_SameConnector_P_PWP_Signal_C.AddOwnedAttribute(MultipleDelegation_SameConnector_P_PWP_Signal_C_a);
				
				MultipleDelegation_SameConnector_P_PWP_Signal_C_u.SetName("u");
					MultipleDelegation_SameConnector_P_PWP_Signal_C_u.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Signal_C_u_ConnectorEnd112.SetUpper(-1);
						MultipleDelegation_SameConnector_P_PWP_Signal_C_u_ConnectorEnd112.SetRole(MultipleDelegation_SameConnector_P_PWP_Signal_C_p);
						
					MultipleDelegation_SameConnector_P_PWP_Signal_C_u.AddEnd(MultipleDelegation_SameConnector_P_PWP_Signal_C_u_ConnectorEnd112);
						MultipleDelegation_SameConnector_P_PWP_Signal_C_u_ConnectorEnd109.SetUpper(-1);
						MultipleDelegation_SameConnector_P_PWP_Signal_C_u_ConnectorEnd109.SetLower(4);
						MultipleDelegation_SameConnector_P_PWP_Signal_C_u_ConnectorEnd109.SetRole(MultipleDelegation_SameConnector_P_PWP_Signal_A_q);
						MultipleDelegation_SameConnector_P_PWP_Signal_C_u_ConnectorEnd109.SetPartWithPort(MultipleDelegation_SameConnector_P_PWP_Signal_C_a);
						
					MultipleDelegation_SameConnector_P_PWP_Signal_C_u.AddEnd(MultipleDelegation_SameConnector_P_PWP_Signal_C_u_ConnectorEnd109);
					MultipleDelegation_SameConnector_P_PWP_Signal_C_u.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_U);
				MultipleDelegation_SameConnector_P_PWP_Signal_C.AddOwnedConnector(MultipleDelegation_SameConnector_P_PWP_Signal_C_u);
			MultipleDelegation_SameConnector_P_PWP_Signal.AddPackagedElement(MultipleDelegation_SameConnector_P_PWP_Signal_C);
				// Interface I
				MultipleDelegation_SameConnector_P_PWP_Signal_I.SetName("I");
				MultipleDelegation_SameConnector_P_PWP_Signal_I.SetVisibility(VisibilityKind.public_);
					// Reception S
					MultipleDelegation_SameConnector_P_PWP_Signal_I_S.SetName("S");
					MultipleDelegation_SameConnector_P_PWP_Signal_I_S.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_PWP_Signal_I_S.SetSignal(MultipleDelegation_SameConnector_P_PWP_Signal_S);
				MultipleDelegation_SameConnector_P_PWP_Signal_I.AddOwnedReception(MultipleDelegation_SameConnector_P_PWP_Signal_I_S);
			MultipleDelegation_SameConnector_P_PWP_Signal.AddPackagedElement(MultipleDelegation_SameConnector_P_PWP_Signal_I);
				// Class B
				MultipleDelegation_SameConnector_P_PWP_Signal_B.SetName("B");
				MultipleDelegation_SameConnector_P_PWP_Signal_B.SetVisibility(VisibilityKind.public_);
				
					// Property p
					MultipleDelegation_SameConnector_P_PWP_Signal_B_p.SetName("p");
					MultipleDelegation_SameConnector_P_PWP_Signal_B_p.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_PWP_Signal_B_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
				MultipleDelegation_SameConnector_P_PWP_Signal_B.AddOwnedAttribute(MultipleDelegation_SameConnector_P_PWP_Signal_B_p);
				MultipleDelegation_SameConnector_P_PWP_Signal_B.SetClassifierBehavior(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior);
					// Activity BClassifierBehavior
					MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior.SetName("BClassifierBehavior");
					MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior.SetVisibility(VisibilityKind.public_);
						// AcceptEventAction Accept S
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S.SetName("Accept S");
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S.SetVisibility(VisibilityKind.public_);
							// OutputPin s
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_s.SetName("s");
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_s.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_s.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_S);
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S.AddResult(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_s);
							// Trigger Trigger126
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_Trigger126.SetName("Trigger126");
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_Trigger126.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_Trigger126.SetEvent(MultipleDelegation_SameConnector_P_PWP_Signal_SEvent);
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S.AddTrigger(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_Trigger126);
					MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S);
						// AddStructuralFeatureValueAction Set this.p
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p.SetName("Set this.p");
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p.SetStructuralFeature(MultipleDelegation_SameConnector_P_PWP_Signal_B_p);
							// InputPin object
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_object.SetName("object");
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_object.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_B);
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p.SetObject(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_object);
							// InputPin value
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_value.SetName("value");
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_value.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p.SetValue(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_value);
							// OutputPin result
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_result.SetName("result");
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_result.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_B);
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p.SetResult(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_result);
					MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p);
						// SendSignalAction Send Continue
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue.SetName("Send Continue");
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue.SetSignal(MultipleDelegation_SameConnector_P_PWP_Signal_Continue);
							// InputPin target
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue_target.SetName("target");
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue_target.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue_target.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester);
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue_target);
					MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue);
						// ReadStructuralFeatureAction Read s.v
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v.SetName("Read s.v");
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v.SetStructuralFeature(MultipleDelegation_SameConnector_P_PWP_Signal_S_v);
							// InputPin object
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_object.SetName("object");
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_object.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v.SetObject(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_object);
							// OutputPin result
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_result.SetName("result");
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v.SetResult(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_result);
					MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v);
						// ReadStructuralFeatureAction Read s.t
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t.SetName("Read s.t");
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t.SetStructuralFeature(MultipleDelegation_SameConnector_P_PWP_Signal_S_t);
							// InputPin object
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_object.SetName("object");
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_object.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t.SetObject(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_object);
							// OutputPin result
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_result.SetName("result");
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_result.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester);
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t.SetResult(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_result);
					MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t);
						// ReadSelfAction this
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_this.SetName("this");
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_this_result.SetName("result");
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_this_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_this_result.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_B);
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_this.SetResult(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_this_result);
					MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_this);
						// ForkNode Fork s
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Fork_s.SetName("Fork s");
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Fork_s.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Fork_s);
						// ObjectFlow ObjectFlow116 from result to target
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow116.SetName("ObjectFlow116");
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow116.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow116.SetSource(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_result);
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow116.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue_target);
							// LiteralBoolean LiteralBoolean117
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow116_LiteralBoolean117.SetName("LiteralBoolean117");
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow116_LiteralBoolean117.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow116_LiteralBoolean117.SetValue(true);
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow116.SetGuard(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow116_LiteralBoolean117);
					MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow116);
						// ObjectFlow ObjectFlow138 from Fork s to object
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow138.SetName("ObjectFlow138");
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow138.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow138.SetSource(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Fork_s);
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow138.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_object);
							// LiteralBoolean LiteralBoolean139
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow138_LiteralBoolean139.SetName("LiteralBoolean139");
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow138_LiteralBoolean139.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow138_LiteralBoolean139.SetValue(true);
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow138.SetGuard(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow138_LiteralBoolean139);
					MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow138);
						// ObjectFlow ObjectFlow119 from result to value
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow119.SetName("ObjectFlow119");
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow119.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow119.SetSource(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_result);
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow119.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_value);
							// LiteralBoolean LiteralBoolean120
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow119_LiteralBoolean120.SetName("LiteralBoolean120");
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow119_LiteralBoolean120.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow119_LiteralBoolean120.SetValue(true);
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow119.SetGuard(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow119_LiteralBoolean120);
					MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow119);
						// ObjectFlow ObjectFlow141 from result to object
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow141.SetName("ObjectFlow141");
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow141.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow141.SetSource(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_this_result);
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow141.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_object);
							// LiteralBoolean LiteralBoolean142
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow141_LiteralBoolean142.SetName("LiteralBoolean142");
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow141_LiteralBoolean142.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow141_LiteralBoolean142.SetValue(true);
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow141.SetGuard(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow141_LiteralBoolean142);
					MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow141);
						// ControlFlow ControlFlow122 from Set this.p to Send Continue
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ControlFlow122.SetName("ControlFlow122");
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ControlFlow122.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ControlFlow122.SetSource(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p);
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ControlFlow122.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue);
					MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ControlFlow122);
						// ObjectFlow ObjectFlow123 from s to Fork s
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow123.SetName("ObjectFlow123");
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow123.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow123.SetSource(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_s);
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow123.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Fork_s);
							// LiteralBoolean LiteralBoolean125
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow123_LiteralBoolean125.SetName("LiteralBoolean125");
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow123_LiteralBoolean125.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow123_LiteralBoolean125.SetValue(true);
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow123.SetGuard(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow123_LiteralBoolean125);
					MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow123);
						// ObjectFlow ObjectFlow154 from Fork s to object
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow154.SetName("ObjectFlow154");
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow154.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow154.SetSource(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Fork_s);
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow154.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_object);
							// LiteralBoolean LiteralBoolean155
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow154_LiteralBoolean155.SetName("LiteralBoolean155");
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow154_LiteralBoolean155.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow154_LiteralBoolean155.SetValue(true);
						MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow154.SetGuard(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow154_LiteralBoolean155);
					MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow154);
				MultipleDelegation_SameConnector_P_PWP_Signal_B.AddOwnedBehavior(MultipleDelegation_SameConnector_P_PWP_Signal_B_BClassifierBehavior);
					MultipleDelegation_SameConnector_P_PWP_Signal_B_IRealization.SetName("IRealization");
					MultipleDelegation_SameConnector_P_PWP_Signal_B_IRealization.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_PWP_Signal_B_IRealization.SetContract(MultipleDelegation_SameConnector_P_PWP_Signal_I);
					
				MultipleDelegation_SameConnector_P_PWP_Signal_B.AddInterfaceRealization(MultipleDelegation_SameConnector_P_PWP_Signal_B_IRealization);
				
				MultipleDelegation_SameConnector_P_PWP_Signal_B.SetIsActive(true);
					// Operation B_B
					MultipleDelegation_SameConnector_P_PWP_Signal_B_B_B.SetName("B_B");
					MultipleDelegation_SameConnector_P_PWP_Signal_B_B_B.SetVisibility(VisibilityKind.public_);
						// Parameter result
						MultipleDelegation_SameConnector_P_PWP_Signal_B_B_B_result.SetName("result");
						MultipleDelegation_SameConnector_P_PWP_Signal_B_B_B_result.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Signal_B_B_B_result.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_B);
						MultipleDelegation_SameConnector_P_PWP_Signal_B_B_B_result.SetDirection(ParameterDirectionKind.return_);
					MultipleDelegation_SameConnector_P_PWP_Signal_B_B_B.AddOwnedParameter(MultipleDelegation_SameConnector_P_PWP_Signal_B_B_B_result);
					MultipleDelegation_SameConnector_P_PWP_Signal_B_B_B.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				MultipleDelegation_SameConnector_P_PWP_Signal_B.AddOwnedOperation(MultipleDelegation_SameConnector_P_PWP_Signal_B_B_B);
					// Reception S
					MultipleDelegation_SameConnector_P_PWP_Signal_B_S.SetName("S");
					MultipleDelegation_SameConnector_P_PWP_Signal_B_S.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_PWP_Signal_B_S.SetSignal(MultipleDelegation_SameConnector_P_PWP_Signal_S);
				MultipleDelegation_SameConnector_P_PWP_Signal_B.AddOwnedReception(MultipleDelegation_SameConnector_P_PWP_Signal_B_S);
			MultipleDelegation_SameConnector_P_PWP_Signal.AddPackagedElement(MultipleDelegation_SameConnector_P_PWP_Signal_B);
				// Signal Continue
				MultipleDelegation_SameConnector_P_PWP_Signal_Continue.SetName("Continue");
				MultipleDelegation_SameConnector_P_PWP_Signal_Continue.SetVisibility(VisibilityKind.public_);
			MultipleDelegation_SameConnector_P_PWP_Signal.AddPackagedElement(MultipleDelegation_SameConnector_P_PWP_Signal_Continue);
				// Class A
				MultipleDelegation_SameConnector_P_PWP_Signal_A.SetName("A");
				MultipleDelegation_SameConnector_P_PWP_Signal_A.SetVisibility(VisibilityKind.public_);
				
					// Port q
					MultipleDelegation_SameConnector_P_PWP_Signal_A_q.SetName("q");
					MultipleDelegation_SameConnector_P_PWP_Signal_A_q.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_PWP_Signal_A_q.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_IImpl);
					MultipleDelegation_SameConnector_P_PWP_Signal_A_q.SetAggregation(AggregationKind.composite);
					MultipleDelegation_SameConnector_P_PWP_Signal_A_q.isService = true;
					MultipleDelegation_SameConnector_P_PWP_Signal_A_q.AddProvided(MultipleDelegation_SameConnector_P_PWP_Signal_I);
				MultipleDelegation_SameConnector_P_PWP_Signal_A.AddOwnedAttribute(MultipleDelegation_SameConnector_P_PWP_Signal_A_q);
					// Property b
					MultipleDelegation_SameConnector_P_PWP_Signal_A_b.SetName("b");
					MultipleDelegation_SameConnector_P_PWP_Signal_A_b.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_PWP_Signal_A_b.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_B);
					MultipleDelegation_SameConnector_P_PWP_Signal_A_b.SetAggregation(AggregationKind.composite);
				MultipleDelegation_SameConnector_P_PWP_Signal_A.AddOwnedAttribute(MultipleDelegation_SameConnector_P_PWP_Signal_A_b);
				
				MultipleDelegation_SameConnector_P_PWP_Signal_A_r.SetName("r");
					MultipleDelegation_SameConnector_P_PWP_Signal_A_r.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Signal_A_r_ConnectorEnd160.SetRole(MultipleDelegation_SameConnector_P_PWP_Signal_A_q);
						
					MultipleDelegation_SameConnector_P_PWP_Signal_A_r.AddEnd(MultipleDelegation_SameConnector_P_PWP_Signal_A_r_ConnectorEnd160);
						
						MultipleDelegation_SameConnector_P_PWP_Signal_A_r_ConnectorEnd157.SetRole(MultipleDelegation_SameConnector_P_PWP_Signal_A_b);
						
					MultipleDelegation_SameConnector_P_PWP_Signal_A_r.AddEnd(MultipleDelegation_SameConnector_P_PWP_Signal_A_r_ConnectorEnd157);
					MultipleDelegation_SameConnector_P_PWP_Signal_A_r.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_R);
				MultipleDelegation_SameConnector_P_PWP_Signal_A.AddOwnedConnector(MultipleDelegation_SameConnector_P_PWP_Signal_A_r);
					// Operation A_A
					MultipleDelegation_SameConnector_P_PWP_Signal_A_A_A.SetName("A_A");
					MultipleDelegation_SameConnector_P_PWP_Signal_A_A_A.SetVisibility(VisibilityKind.public_);
						// Parameter result
						MultipleDelegation_SameConnector_P_PWP_Signal_A_A_A_result.SetName("result");
						MultipleDelegation_SameConnector_P_PWP_Signal_A_A_A_result.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_PWP_Signal_A_A_A_result.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_A);
						MultipleDelegation_SameConnector_P_PWP_Signal_A_A_A_result.SetDirection(ParameterDirectionKind.return_);
					MultipleDelegation_SameConnector_P_PWP_Signal_A_A_A.AddOwnedParameter(MultipleDelegation_SameConnector_P_PWP_Signal_A_A_A_result);
					MultipleDelegation_SameConnector_P_PWP_Signal_A_A_A.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				MultipleDelegation_SameConnector_P_PWP_Signal_A.AddOwnedOperation(MultipleDelegation_SameConnector_P_PWP_Signal_A_A_A);
			MultipleDelegation_SameConnector_P_PWP_Signal.AddPackagedElement(MultipleDelegation_SameConnector_P_PWP_Signal_A);
				// Association R
				MultipleDelegation_SameConnector_P_PWP_Signal_R.SetName("R");
				MultipleDelegation_SameConnector_P_PWP_Signal_R.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_SameConnector_P_PWP_Signal_R.AddOwnedEnd(MultipleDelegation_SameConnector_P_PWP_Signal_R_x);
				MultipleDelegation_SameConnector_P_PWP_Signal_R.AddOwnedEnd(MultipleDelegation_SameConnector_P_PWP_Signal_R_y);
			MultipleDelegation_SameConnector_P_PWP_Signal.AddPackagedElement(MultipleDelegation_SameConnector_P_PWP_Signal_R);
				// Signal S
				MultipleDelegation_SameConnector_P_PWP_Signal_S.SetName("S");
				MultipleDelegation_SameConnector_P_PWP_Signal_S.SetVisibility(VisibilityKind.public_);
				
					// Property v
					MultipleDelegation_SameConnector_P_PWP_Signal_S_v.SetName("v");
					MultipleDelegation_SameConnector_P_PWP_Signal_S_v.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_PWP_Signal_S_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
				MultipleDelegation_SameConnector_P_PWP_Signal_S.AddOwnedAttribute(MultipleDelegation_SameConnector_P_PWP_Signal_S_v);
					// Property t
					MultipleDelegation_SameConnector_P_PWP_Signal_S_t.SetName("t");
					MultipleDelegation_SameConnector_P_PWP_Signal_S_t.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_PWP_Signal_S_t.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester);
				MultipleDelegation_SameConnector_P_PWP_Signal_S.AddOwnedAttribute(MultipleDelegation_SameConnector_P_PWP_Signal_S_t);
			MultipleDelegation_SameConnector_P_PWP_Signal.AddPackagedElement(MultipleDelegation_SameConnector_P_PWP_Signal_S);
				// SignalEvent SEvent
				MultipleDelegation_SameConnector_P_PWP_Signal_SEvent.SetName("SEvent");
				MultipleDelegation_SameConnector_P_PWP_Signal_SEvent.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_SameConnector_P_PWP_Signal_SEvent.SetSignal(MultipleDelegation_SameConnector_P_PWP_Signal_S);
			MultipleDelegation_SameConnector_P_PWP_Signal.AddPackagedElement(MultipleDelegation_SameConnector_P_PWP_Signal_SEvent);
				// Class IImpl
				MultipleDelegation_SameConnector_P_PWP_Signal_IImpl.SetName("IImpl");
				MultipleDelegation_SameConnector_P_PWP_Signal_IImpl.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_SameConnector_P_PWP_Signal_IImpl_IRealization.SetName("IRealization");
					MultipleDelegation_SameConnector_P_PWP_Signal_IImpl_IRealization.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_PWP_Signal_IImpl_IRealization.SetContract(MultipleDelegation_SameConnector_P_PWP_Signal_I);
					
				MultipleDelegation_SameConnector_P_PWP_Signal_IImpl.AddInterfaceRealization(MultipleDelegation_SameConnector_P_PWP_Signal_IImpl_IRealization);
				
					// Reception S
					MultipleDelegation_SameConnector_P_PWP_Signal_IImpl_S.SetName("S");
					MultipleDelegation_SameConnector_P_PWP_Signal_IImpl_S.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_PWP_Signal_IImpl_S.SetSignal(MultipleDelegation_SameConnector_P_PWP_Signal_S);
				MultipleDelegation_SameConnector_P_PWP_Signal_IImpl.AddOwnedReception(MultipleDelegation_SameConnector_P_PWP_Signal_IImpl_S);
			MultipleDelegation_SameConnector_P_PWP_Signal.AddPackagedElement(MultipleDelegation_SameConnector_P_PWP_Signal_IImpl);
				// Class AbstractTester
				MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester.SetName("AbstractTester");
				MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester.SetVisibility(VisibilityKind.public_);
				
				MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester.SetIsAbstract(true);
				
				
				MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester.SetIsActive(true);
					// Operation test
					MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester_test.SetName("test");
					MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester_test.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester_test.SetIsAbstract(true);
				MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester.AddOwnedOperation(MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester_test);
					// Reception Start
					MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester_Start.SetName("Start");
					MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester_Start.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester_Start.SetSignal(MultipleDelegation_SameConnector_P_PWP_Signal_Start);
				MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester.AddOwnedReception(MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester_Start);
					// Reception Continue
					MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester_Continue.SetName("Continue");
					MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester_Continue.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester_Continue.SetSignal(MultipleDelegation_SameConnector_P_PWP_Signal_Continue);
				MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester.AddOwnedReception(MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester_Continue);
			MultipleDelegation_SameConnector_P_PWP_Signal.AddPackagedElement(MultipleDelegation_SameConnector_P_PWP_Signal_AbstractTester);
				// Activity main
				MultipleDelegation_SameConnector_P_PWP_Signal_main.SetName("main");
				MultipleDelegation_SameConnector_P_PWP_Signal_main.SetVisibility(VisibilityKind.public_);
					// ForkNode Fork Tester
					MultipleDelegation_SameConnector_P_PWP_Signal_main_Fork_Tester.SetName("Fork Tester");
					MultipleDelegation_SameConnector_P_PWP_Signal_main_Fork_Tester.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_SameConnector_P_PWP_Signal_main.AddNode(MultipleDelegation_SameConnector_P_PWP_Signal_main_Fork_Tester);
					// CallOperationAction Tester()
					MultipleDelegation_SameConnector_P_PWP_Signal_main_Tester_.SetName("Tester()");
					MultipleDelegation_SameConnector_P_PWP_Signal_main_Tester_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						MultipleDelegation_SameConnector_P_PWP_Signal_main_Tester__result.SetName("result");
						MultipleDelegation_SameConnector_P_PWP_Signal_main_Tester__result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Signal_main_Tester__result.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_Tester);
					MultipleDelegation_SameConnector_P_PWP_Signal_main_Tester_.AddResult(MultipleDelegation_SameConnector_P_PWP_Signal_main_Tester__result);
					MultipleDelegation_SameConnector_P_PWP_Signal_main_Tester_.SetOperation(MultipleDelegation_SameConnector_P_PWP_Signal_Tester_Tester_Tester);
						// InputPin target
						MultipleDelegation_SameConnector_P_PWP_Signal_main_Tester__target.SetName("target");
						MultipleDelegation_SameConnector_P_PWP_Signal_main_Tester__target.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Signal_main_Tester__target.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_Tester);
					MultipleDelegation_SameConnector_P_PWP_Signal_main_Tester_.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_main_Tester__target);
				MultipleDelegation_SameConnector_P_PWP_Signal_main.AddNode(MultipleDelegation_SameConnector_P_PWP_Signal_main_Tester_);
					// StartObjectBehaviorAction Start Tester
					MultipleDelegation_SameConnector_P_PWP_Signal_main_Start_Tester.SetName("Start Tester");
					MultipleDelegation_SameConnector_P_PWP_Signal_main_Start_Tester.SetVisibility(VisibilityKind.public_);
						// InputPin object
						MultipleDelegation_SameConnector_P_PWP_Signal_main_Start_Tester_object.SetName("object");
						MultipleDelegation_SameConnector_P_PWP_Signal_main_Start_Tester_object.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_PWP_Signal_main_Start_Tester.SetObject(MultipleDelegation_SameConnector_P_PWP_Signal_main_Start_Tester_object);
				MultipleDelegation_SameConnector_P_PWP_Signal_main.AddNode(MultipleDelegation_SameConnector_P_PWP_Signal_main_Start_Tester);
					// CreateObjectAction Create Tester
					MultipleDelegation_SameConnector_P_PWP_Signal_main_Create_Tester.SetName("Create Tester");
					MultipleDelegation_SameConnector_P_PWP_Signal_main_Create_Tester.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_PWP_Signal_main_Create_Tester.SetClassifier(MultipleDelegation_SameConnector_P_PWP_Signal_Tester);
						// OutputPin result
						MultipleDelegation_SameConnector_P_PWP_Signal_main_Create_Tester_result.SetName("result");
						MultipleDelegation_SameConnector_P_PWP_Signal_main_Create_Tester_result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Signal_main_Create_Tester_result.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_Tester);
					MultipleDelegation_SameConnector_P_PWP_Signal_main_Create_Tester.SetResult(MultipleDelegation_SameConnector_P_PWP_Signal_main_Create_Tester_result);
				MultipleDelegation_SameConnector_P_PWP_Signal_main.AddNode(MultipleDelegation_SameConnector_P_PWP_Signal_main_Create_Tester);
					// SendSignalAction Send Start
					MultipleDelegation_SameConnector_P_PWP_Signal_main_Send_Start.SetName("Send Start");
					MultipleDelegation_SameConnector_P_PWP_Signal_main_Send_Start.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_PWP_Signal_main_Send_Start.SetSignal(MultipleDelegation_SameConnector_P_PWP_Signal_Start);
						// InputPin target
						MultipleDelegation_SameConnector_P_PWP_Signal_main_Send_Start_target.SetName("target");
						MultipleDelegation_SameConnector_P_PWP_Signal_main_Send_Start_target.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Signal_main_Send_Start_target.SetType(MultipleDelegation_SameConnector_P_PWP_Signal_Tester);
					MultipleDelegation_SameConnector_P_PWP_Signal_main_Send_Start.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_main_Send_Start_target);
				MultipleDelegation_SameConnector_P_PWP_Signal_main.AddNode(MultipleDelegation_SameConnector_P_PWP_Signal_main_Send_Start);
					// ObjectFlow ObjectFlow168 from result to target
					MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow168.SetName("ObjectFlow168");
					MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow168.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow168.SetSource(MultipleDelegation_SameConnector_P_PWP_Signal_main_Create_Tester_result);
					MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow168.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_main_Tester__target);
						// LiteralBoolean LiteralBoolean170
						MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow168_LiteralBoolean170.SetName("LiteralBoolean170");
						MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow168_LiteralBoolean170.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow168_LiteralBoolean170.SetValue(true);
					MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow168.SetGuard(MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow168_LiteralBoolean170);
				MultipleDelegation_SameConnector_P_PWP_Signal_main.AddEdge(MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow168);
					// ObjectFlow ObjectFlow171 from result to Fork Tester
					MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow171.SetName("ObjectFlow171");
					MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow171.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow171.SetSource(MultipleDelegation_SameConnector_P_PWP_Signal_main_Tester__result);
					MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow171.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_main_Fork_Tester);
						// LiteralBoolean LiteralBoolean173
						MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow171_LiteralBoolean173.SetName("LiteralBoolean173");
						MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow171_LiteralBoolean173.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow171_LiteralBoolean173.SetValue(true);
					MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow171.SetGuard(MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow171_LiteralBoolean173);
				MultipleDelegation_SameConnector_P_PWP_Signal_main.AddEdge(MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow171);
					// ObjectFlow ObjectFlow181 from Fork Tester to object
					MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow181.SetName("ObjectFlow181");
					MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow181.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow181.SetSource(MultipleDelegation_SameConnector_P_PWP_Signal_main_Fork_Tester);
					MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow181.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_main_Start_Tester_object);
						// LiteralBoolean LiteralBoolean182
						MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow181_LiteralBoolean182.SetName("LiteralBoolean182");
						MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow181_LiteralBoolean182.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow181_LiteralBoolean182.SetValue(true);
					MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow181.SetGuard(MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow181_LiteralBoolean182);
				MultipleDelegation_SameConnector_P_PWP_Signal_main.AddEdge(MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow181);
					// ObjectFlow ObjectFlow188 from Fork Tester to target
					MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow188.SetName("ObjectFlow188");
					MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow188.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow188.SetSource(MultipleDelegation_SameConnector_P_PWP_Signal_main_Fork_Tester);
					MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow188.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_main_Send_Start_target);
						// LiteralBoolean LiteralBoolean190
						MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow188_LiteralBoolean190.SetName("LiteralBoolean190");
						MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow188_LiteralBoolean190.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow188_LiteralBoolean190.SetValue(true);
					MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow188.SetGuard(MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow188_LiteralBoolean190);
				MultipleDelegation_SameConnector_P_PWP_Signal_main.AddEdge(MultipleDelegation_SameConnector_P_PWP_Signal_main_ObjectFlow188);
					// ControlFlow ControlFlow191 from Start Tester to Send Start
					MultipleDelegation_SameConnector_P_PWP_Signal_main_ControlFlow191.SetName("ControlFlow191");
					MultipleDelegation_SameConnector_P_PWP_Signal_main_ControlFlow191.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_PWP_Signal_main_ControlFlow191.SetSource(MultipleDelegation_SameConnector_P_PWP_Signal_main_Start_Tester);
					MultipleDelegation_SameConnector_P_PWP_Signal_main_ControlFlow191.SetTarget(MultipleDelegation_SameConnector_P_PWP_Signal_main_Send_Start);
				MultipleDelegation_SameConnector_P_PWP_Signal_main.AddEdge(MultipleDelegation_SameConnector_P_PWP_Signal_main_ControlFlow191);
			MultipleDelegation_SameConnector_P_PWP_Signal.AddPackagedElement(MultipleDelegation_SameConnector_P_PWP_Signal_main);
				// Signal Start
				MultipleDelegation_SameConnector_P_PWP_Signal_Start.SetName("Start");
				MultipleDelegation_SameConnector_P_PWP_Signal_Start.SetVisibility(VisibilityKind.public_);
			MultipleDelegation_SameConnector_P_PWP_Signal.AddPackagedElement(MultipleDelegation_SameConnector_P_PWP_Signal_Start);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // MultipleDelegation_SameConnector_P_PWP_SignalModel
}
