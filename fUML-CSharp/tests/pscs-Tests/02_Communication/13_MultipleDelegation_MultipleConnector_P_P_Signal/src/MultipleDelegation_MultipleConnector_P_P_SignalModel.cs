/*
 * MultipleDelegation_MultipleConnector_P_P_SignalModel.cs
 * 
 * Auto-generated file
 */

using uml.actions;
using uml.packages;
using uml.structuredclassifiers;
using fuml.primitivetypes;
using uml.classification;
using fuml.library;
using uml.commonbehavior;
using uml.simpleclassifiers;
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

namespace MultipleDelegation_MultipleConnector_P_P_Signal
{
	public class MultipleDelegation_MultipleConnector_P_P_SignalModel : InMemoryModel
	{
		private static MultipleDelegation_MultipleConnector_P_P_SignalModel? instance;

		/*
		 * Model MultipleDelegation_MultipleConnector_P_P_Signal
		 */
		public Package MultipleDelegation_MultipleConnector_P_P_Signal = new();
			public SignalEvent MultipleDelegation_MultipleConnector_P_P_Signal_StartEvent = new();
			public SignalEvent MultipleDelegation_MultipleConnector_P_P_Signal_ContinueEvent = new();
			public SignalEvent MultipleDelegation_MultipleConnector_P_P_Signal_SEvent = new();
			public Class_ MultipleDelegation_MultipleConnector_P_P_Signal_Tester = new();
				public Generalization MultipleDelegation_MultipleConnector_P_P_Signal_Tester_Generalization0 = new();
				public Activity MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow1 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow1_LiteralBoolean2 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow1_LiteralInteger3 = new();
					public OpaqueBehavior MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_testP = new();
						public Parameter MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_testP_p = new();
					public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b2 = new();
						public InputPin MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b2_object = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b2_object_LiteralUnlimitedNatural4 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b2_object_LiteralInteger5 = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b2_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b2_result_LiteralUnlimitedNatural6 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b2_result_LiteralInteger7 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow8 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow8_LiteralBoolean9 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow8_LiteralInteger10 = new();
					public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p = new();
						public InputPin MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p_object = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p_object_LiteralInteger11 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p_object_LiteralUnlimitedNatural12 = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p_result = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p_result_LiteralInteger13 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p_result_LiteralUnlimitedNatural14 = new();
					public ControlFlow MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ControlFlow15 = new();
					public ControlFlow MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ControlFlow16 = new();
					public CallBehaviorAction MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Call_testP = new();
						public InputPin MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Call_testP_p = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Call_testP_p_LiteralUnlimitedNatural17 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Call_testP_p_LiteralInteger18 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Call_testP_p_LiteralInteger19 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow20 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow20_LiteralInteger21 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow20_LiteralBoolean22 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow23 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow23_LiteralBoolean24 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow23_LiteralInteger25 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow26 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow26_LiteralBoolean27 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow26_LiteralInteger28 = new();
					public ControlFlow MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ControlFlow29 = new();
					public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b1 = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b1_result = new();
						public InputPin MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b1_object = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b1_object_LiteralUnlimitedNatural30 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b1_object_LiteralInteger31 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow32 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow32_LiteralBoolean33 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow32_LiteralInteger34 = new();
					public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_this_a = new();
						public InputPin MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_this_a_object = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_this_a_object_LiteralUnlimitedNatural35 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_this_a_object_LiteralInteger36 = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_this_a_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_this_a_result_LiteralUnlimitedNatural37 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_this_a_result_LiteralInteger38 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow39 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow39_LiteralBoolean40 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow39_LiteralInteger41 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow42 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow42_LiteralBoolean43 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow42_LiteralInteger44 = new();
					public ReadSelfAction MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_this = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_this_result = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_this_result_LiteralInteger45 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_this_result_LiteralUnlimitedNatural46 = new();
					public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b4 = new();
						public InputPin MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b4_object = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b4_object_LiteralUnlimitedNatural47 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b4_object_LiteralInteger48 = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b4_result = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b4_result_LiteralInteger49 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b4_result_LiteralUnlimitedNatural50 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow51 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow51_LiteralBoolean52 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow51_LiteralInteger53 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow54 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow54_LiteralBoolean55 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow54_LiteralInteger56 = new();
					public ForkNode MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Fork_a = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow57 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow57_LiteralInteger58 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow57_LiteralBoolean59 = new();
					public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b3 = new();
						public InputPin MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b3_object = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b3_object_LiteralInteger60 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b3_object_LiteralUnlimitedNatural61 = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b3_result = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b3_result_LiteralInteger62 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b3_result_LiteralUnlimitedNatural63 = new();
				public Activity MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior = new();
					public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q = new();
						public InputPin MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object_LiteralInteger64 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object_LiteralUnlimitedNatural65 = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result_LiteralUnlimitedNatural66 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result_LiteralInteger67 = new();
					public AcceptEventAction MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3 = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result_LiteralInteger68 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result_LiteralUnlimitedNatural69 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result_LiteralInteger70 = new();
						public Trigger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_Trigger71 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow72 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow72_LiteralBoolean73 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow72_LiteralInteger74 = new();
					public ControlFlow MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow75 = new();
					public AcceptEventAction MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start = new();
						public Trigger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger76 = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralInteger77 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralUnlimitedNatural78 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralInteger79 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow80 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow80_LiteralInteger81 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow80_LiteralBoolean82 = new();
					public AcceptEventAction MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4 = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result_LiteralUnlimitedNatural83 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result_LiteralInteger84 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result_LiteralInteger85 = new();
						public Trigger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_Trigger86 = new();
					public ValueSpecificationAction MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4 = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_result = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_result_LiteralInteger87 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_result_LiteralUnlimitedNatural88 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_LiteralInteger89 = new();
					public ControlFlow MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow90 = new();
					public CallOperationAction MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test_ = new();
						public InputPin MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target_LiteralInteger91 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target_LiteralUnlimitedNatural92 = new();
					public ControlFlow MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow93 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow94 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow94_LiteralInteger95 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow94_LiteralBoolean96 = new();
					public ControlFlow MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow97 = new();
					public AcceptEventAction MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1 = new();
						public Trigger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_Trigger98 = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result_LiteralUnlimitedNatural99 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result_LiteralInteger100 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result_LiteralInteger101 = new();
					public ForkNode MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Fork_this = new();
					public ControlFlow MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow102 = new();
					public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result_LiteralUnlimitedNatural103 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result_LiteralInteger104 = new();
						public InputPin MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object_LiteralUnlimitedNatural105 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object_LiteralInteger106 = new();
					public SendSignalAction MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S = new();
						public InputPin MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_t = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_t_LiteralInteger107 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_t_LiteralUnlimitedNatural108 = new();
						public InputPin MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_target = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_target_LiteralUnlimitedNatural109 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_target_LiteralInteger110 = new();
						public InputPin MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_v = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_v_LiteralInteger111 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_v_LiteralUnlimitedNatural112 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow113 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow113_LiteralInteger114 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow113_LiteralBoolean115 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow116 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow116_LiteralBoolean117 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow116_LiteralInteger118 = new();
					public AcceptEventAction MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2 = new();
						public Trigger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_Trigger119 = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result_LiteralUnlimitedNatural120 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result_LiteralInteger121 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result_LiteralInteger122 = new();
					public ReadSelfAction MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_this = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_this_result = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_this_result_LiteralInteger123 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_this_result_LiteralUnlimitedNatural124 = new();
					public ControlFlow MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow125 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow126 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow126_LiteralBoolean127 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow126_LiteralInteger128 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow129 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow129_LiteralBoolean130 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow129_LiteralInteger131 = new();
				public Operation MultipleDelegation_MultipleConnector_P_P_Signal_Tester_Tester_Tester = new();
					public Parameter MultipleDelegation_MultipleConnector_P_P_Signal_Tester_Tester_Tester_result = new();
				public Property MultipleDelegation_MultipleConnector_P_P_Signal_Tester_a = new();
				public Operation MultipleDelegation_MultipleConnector_P_P_Signal_Tester_test = new();
			public Signal MultipleDelegation_MultipleConnector_P_P_Signal_Continue = new();
			public Activity MultipleDelegation_MultipleConnector_P_P_Signal_main = new();
				public CreateObjectAction MultipleDelegation_MultipleConnector_P_P_Signal_main_Create_Tester = new();
					public OutputPin MultipleDelegation_MultipleConnector_P_P_Signal_main_Create_Tester_result = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_main_Create_Tester_result_LiteralInteger132 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_main_Create_Tester_result_LiteralUnlimitedNatural133 = new();
				public ControlFlow MultipleDelegation_MultipleConnector_P_P_Signal_main_ControlFlow134 = new();
				public StartObjectBehaviorAction MultipleDelegation_MultipleConnector_P_P_Signal_main_Start_Tester = new();
					public InputPin MultipleDelegation_MultipleConnector_P_P_Signal_main_Start_Tester_object = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_main_Start_Tester_object_LiteralUnlimitedNatural135 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_main_Start_Tester_object_LiteralInteger136 = new();
				public CallOperationAction MultipleDelegation_MultipleConnector_P_P_Signal_main_Tester_ = new();
					public OutputPin MultipleDelegation_MultipleConnector_P_P_Signal_main_Tester__result = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_main_Tester__result_LiteralUnlimitedNatural137 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_main_Tester__result_LiteralInteger138 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_main_Tester__result_LiteralInteger139 = new();
					public InputPin MultipleDelegation_MultipleConnector_P_P_Signal_main_Tester__target = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_main_Tester__target_LiteralUnlimitedNatural140 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_main_Tester__target_LiteralInteger141 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow142 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow142_LiteralBoolean143 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow142_LiteralInteger144 = new();
				public ForkNode MultipleDelegation_MultipleConnector_P_P_Signal_main_Fork_Tester = new();
				public SendSignalAction MultipleDelegation_MultipleConnector_P_P_Signal_main_Send_Start = new();
					public InputPin MultipleDelegation_MultipleConnector_P_P_Signal_main_Send_Start_target = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_main_Send_Start_target_LiteralUnlimitedNatural145 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_main_Send_Start_target_LiteralInteger146 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow147 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow147_LiteralInteger148 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow147_LiteralBoolean149 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow150 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow150_LiteralBoolean151 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow150_LiteralInteger152 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow153 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow153_LiteralInteger154 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow153_LiteralBoolean155 = new();
			public Class_ MultipleDelegation_MultipleConnector_P_P_Signal_A = new();
				public Port MultipleDelegation_MultipleConnector_P_P_Signal_A_q = new();
				public Property MultipleDelegation_MultipleConnector_P_P_Signal_A_b1 = new();
					public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_A_b1_LiteralUnlimitedNatural156 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_A_b1_LiteralInteger157 = new();
				public Property MultipleDelegation_MultipleConnector_P_P_Signal_A_b3 = new();
					public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_A_b3_LiteralUnlimitedNatural158 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_A_b3_LiteralInteger159 = new();
				public Connector MultipleDelegation_MultipleConnector_P_P_Signal_A_r2 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_P_Signal_A_r2_ConnectorEnd160 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_P_Signal_A_r2_ConnectorEnd161 = new();
				public Operation MultipleDelegation_MultipleConnector_P_P_Signal_A_A_A = new();
					public Parameter MultipleDelegation_MultipleConnector_P_P_Signal_A_A_A_result = new();
				public Property MultipleDelegation_MultipleConnector_P_P_Signal_A_b2 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_A_b2_LiteralInteger162 = new();
					public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_A_b2_LiteralUnlimitedNatural163 = new();
				public Connector MultipleDelegation_MultipleConnector_P_P_Signal_A_r1 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_P_Signal_A_r1_ConnectorEnd164 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_A_r1_ConnectorEnd164_LiteralUnlimitedNatural165 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_P_Signal_A_r1_ConnectorEnd166 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_A_r1_ConnectorEnd166_LiteralUnlimitedNatural167 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_A_r1_ConnectorEnd166_LiteralInteger168 = new();
				public Connector MultipleDelegation_MultipleConnector_P_P_Signal_A_r3 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_P_Signal_A_r3_ConnectorEnd169 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_P_Signal_A_r3_ConnectorEnd170 = new();
				public Connector MultipleDelegation_MultipleConnector_P_P_Signal_A_r4 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_P_Signal_A_r4_ConnectorEnd171 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_P_Signal_A_r4_ConnectorEnd172 = new();
				public Property MultipleDelegation_MultipleConnector_P_P_Signal_A_b4 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_A_b4_LiteralInteger173 = new();
					public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_A_b4_LiteralUnlimitedNatural174 = new();
			public Signal MultipleDelegation_MultipleConnector_P_P_Signal_S = new();
				public Property MultipleDelegation_MultipleConnector_P_P_Signal_S_t = new();
				public Property MultipleDelegation_MultipleConnector_P_P_Signal_S_v = new();
			public Interface MultipleDelegation_MultipleConnector_P_P_Signal_I = new();
				public Reception MultipleDelegation_MultipleConnector_P_P_Signal_I_S = new();
			public Class_ MultipleDelegation_MultipleConnector_P_P_Signal_B = new();
				public Activity MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow175 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow175_LiteralBoolean176 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow175_LiteralInteger177 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow178 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow178_LiteralBoolean179 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow178_LiteralInteger180 = new();
					public ControlFlow MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ControlFlow181 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow182 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow182_LiteralInteger183 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow182_LiteralBoolean184 = new();
					public AcceptEventAction MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Accept_S = new();
						public Trigger MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_Trigger185 = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_s = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_s_LiteralUnlimitedNatural186 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_s_LiteralInteger187 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_s_LiteralInteger188 = new();
					public AddStructuralFeatureValueAction MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_result_LiteralUnlimitedNatural189 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_result_LiteralInteger190 = new();
						public InputPin MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_object = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_object_LiteralInteger191 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_object_LiteralUnlimitedNatural192 = new();
						public InputPin MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_value = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_value_LiteralInteger193 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_value_LiteralUnlimitedNatural194 = new();
					public SendSignalAction MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue = new();
						public InputPin MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue_target = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue_target_LiteralUnlimitedNatural195 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue_target_LiteralInteger196 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow197 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow197_LiteralBoolean198 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow197_LiteralInteger199 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow200 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow200_LiteralBoolean201 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow200_LiteralInteger202 = new();
					public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_result = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_result_LiteralInteger203 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_result_LiteralUnlimitedNatural204 = new();
						public InputPin MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_object = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_object_LiteralInteger205 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_object_LiteralUnlimitedNatural206 = new();
					public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t = new();
						public InputPin MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_object = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_object_LiteralInteger207 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_object_LiteralUnlimitedNatural208 = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_result_LiteralUnlimitedNatural209 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_result_LiteralInteger210 = new();
					public ReadSelfAction MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_this = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_this_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_this_result_LiteralUnlimitedNatural211 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_this_result_LiteralInteger212 = new();
					public ForkNode MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Fork_s = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow213 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow213_LiteralBoolean214 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow213_LiteralInteger215 = new();
				public InterfaceRealization MultipleDelegation_MultipleConnector_P_P_Signal_B_IRealization = new();
				public Operation MultipleDelegation_MultipleConnector_P_P_Signal_B_B_B = new();
					public Parameter MultipleDelegation_MultipleConnector_P_P_Signal_B_B_B_result = new();
				public Property MultipleDelegation_MultipleConnector_P_P_Signal_B_p = new();
				public Reception MultipleDelegation_MultipleConnector_P_P_Signal_B_S = new();
			public Association MultipleDelegation_MultipleConnector_P_P_Signal_R = new();
				public Property MultipleDelegation_MultipleConnector_P_P_Signal_R_x = new();
					public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_R_x_LiteralUnlimitedNatural216 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_R_x_LiteralInteger217 = new();
				public Property MultipleDelegation_MultipleConnector_P_P_Signal_R_y = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Signal_R_y_LiteralInteger218 = new();
					public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Signal_R_y_LiteralUnlimitedNatural219 = new();
			public Class_ MultipleDelegation_MultipleConnector_P_P_Signal_IImpl = new();
				public InterfaceRealization MultipleDelegation_MultipleConnector_P_P_Signal_IImpl_IRealization = new();
				public Reception MultipleDelegation_MultipleConnector_P_P_Signal_IImpl_S = new();
			public Class_ MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester = new();
				public Reception MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester_Start = new();
				public Operation MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester_test = new();
				public Reception MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester_Continue = new();
			public Signal MultipleDelegation_MultipleConnector_P_P_Signal_Start = new();

		public static MultipleDelegation_MultipleConnector_P_P_SignalModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public MultipleDelegation_MultipleConnector_P_P_SignalModel()
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
			 * Model MultipleDelegation_MultipleConnector_P_P_Signal
			 */
			AddToElementRepository("MultipleDelegation_MultipleConnector_P_P_Signal", MultipleDelegation_MultipleConnector_P_P_Signal);
				AddToElementRepository("StartEvent", MultipleDelegation_MultipleConnector_P_P_Signal_StartEvent);
				AddToElementRepository("ContinueEvent", MultipleDelegation_MultipleConnector_P_P_Signal_ContinueEvent);
				AddToElementRepository("SEvent", MultipleDelegation_MultipleConnector_P_P_Signal_SEvent);
				AddToElementRepository("Tester", MultipleDelegation_MultipleConnector_P_P_Signal_Tester);
					AddToElementRepository("Generalization0", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_Generalization0);
					AddToElementRepository("testActivity", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity);
						AddToElementRepository("ObjectFlow1", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow1);
							AddToElementRepository("LiteralBoolean2", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow1_LiteralBoolean2);
							AddToElementRepository("LiteralInteger3", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow1_LiteralInteger3);
						AddToElementRepository("testP", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_testP);
							AddToElementRepository("p", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_testP_p);
						AddToElementRepository("Read a.b2", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b2);
							AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b2_object);
								AddToElementRepository("LiteralUnlimitedNatural4", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b2_object_LiteralUnlimitedNatural4);
								AddToElementRepository("LiteralInteger5", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b2_object_LiteralInteger5);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b2_result);
								AddToElementRepository("LiteralUnlimitedNatural6", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b2_result_LiteralUnlimitedNatural6);
								AddToElementRepository("LiteralInteger7", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b2_result_LiteralInteger7);
						AddToElementRepository("ObjectFlow8", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow8);
							AddToElementRepository("LiteralBoolean9", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow8_LiteralBoolean9);
							AddToElementRepository("LiteralInteger10", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow8_LiteralInteger10);
						AddToElementRepository("Read b.p", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p);
							AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p_object);
								AddToElementRepository("LiteralInteger11", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p_object_LiteralInteger11);
								AddToElementRepository("LiteralUnlimitedNatural12", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p_object_LiteralUnlimitedNatural12);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p_result);
								AddToElementRepository("LiteralInteger13", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p_result_LiteralInteger13);
								AddToElementRepository("LiteralUnlimitedNatural14", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p_result_LiteralUnlimitedNatural14);
						AddToElementRepository("ControlFlow15", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ControlFlow15);
						AddToElementRepository("ControlFlow16", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ControlFlow16);
						AddToElementRepository("Call testP", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Call_testP);
							AddToElementRepository("p", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Call_testP_p);
								AddToElementRepository("LiteralUnlimitedNatural17", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Call_testP_p_LiteralUnlimitedNatural17);
								AddToElementRepository("LiteralInteger18", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Call_testP_p_LiteralInteger18);
								AddToElementRepository("LiteralInteger19", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Call_testP_p_LiteralInteger19);
						AddToElementRepository("ObjectFlow20", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow20);
							AddToElementRepository("LiteralInteger21", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow20_LiteralInteger21);
							AddToElementRepository("LiteralBoolean22", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow20_LiteralBoolean22);
						AddToElementRepository("ObjectFlow23", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow23);
							AddToElementRepository("LiteralBoolean24", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow23_LiteralBoolean24);
							AddToElementRepository("LiteralInteger25", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow23_LiteralInteger25);
						AddToElementRepository("ObjectFlow26", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow26);
							AddToElementRepository("LiteralBoolean27", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow26_LiteralBoolean27);
							AddToElementRepository("LiteralInteger28", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow26_LiteralInteger28);
						AddToElementRepository("ControlFlow29", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ControlFlow29);
						AddToElementRepository("Read a.b1", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b1);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b1_result);
							AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b1_object);
								AddToElementRepository("LiteralUnlimitedNatural30", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b1_object_LiteralUnlimitedNatural30);
								AddToElementRepository("LiteralInteger31", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b1_object_LiteralInteger31);
						AddToElementRepository("ObjectFlow32", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow32);
							AddToElementRepository("LiteralBoolean33", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow32_LiteralBoolean33);
							AddToElementRepository("LiteralInteger34", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow32_LiteralInteger34);
						AddToElementRepository("Read this.a", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_this_a);
							AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_this_a_object);
								AddToElementRepository("LiteralUnlimitedNatural35", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_this_a_object_LiteralUnlimitedNatural35);
								AddToElementRepository("LiteralInteger36", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_this_a_object_LiteralInteger36);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_this_a_result);
								AddToElementRepository("LiteralUnlimitedNatural37", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_this_a_result_LiteralUnlimitedNatural37);
								AddToElementRepository("LiteralInteger38", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_this_a_result_LiteralInteger38);
						AddToElementRepository("ObjectFlow39", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow39);
							AddToElementRepository("LiteralBoolean40", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow39_LiteralBoolean40);
							AddToElementRepository("LiteralInteger41", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow39_LiteralInteger41);
						AddToElementRepository("ObjectFlow42", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow42);
							AddToElementRepository("LiteralBoolean43", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow42_LiteralBoolean43);
							AddToElementRepository("LiteralInteger44", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow42_LiteralInteger44);
						AddToElementRepository("this", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_this);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_this_result);
								AddToElementRepository("LiteralInteger45", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_this_result_LiteralInteger45);
								AddToElementRepository("LiteralUnlimitedNatural46", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_this_result_LiteralUnlimitedNatural46);
						AddToElementRepository("Read a.b4", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b4);
							AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b4_object);
								AddToElementRepository("LiteralUnlimitedNatural47", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b4_object_LiteralUnlimitedNatural47);
								AddToElementRepository("LiteralInteger48", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b4_object_LiteralInteger48);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b4_result);
								AddToElementRepository("LiteralInteger49", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b4_result_LiteralInteger49);
								AddToElementRepository("LiteralUnlimitedNatural50", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b4_result_LiteralUnlimitedNatural50);
						AddToElementRepository("ObjectFlow51", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow51);
							AddToElementRepository("LiteralBoolean52", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow51_LiteralBoolean52);
							AddToElementRepository("LiteralInteger53", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow51_LiteralInteger53);
						AddToElementRepository("ObjectFlow54", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow54);
							AddToElementRepository("LiteralBoolean55", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow54_LiteralBoolean55);
							AddToElementRepository("LiteralInteger56", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow54_LiteralInteger56);
						AddToElementRepository("Fork a", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Fork_a);
						AddToElementRepository("ObjectFlow57", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow57);
							AddToElementRepository("LiteralInteger58", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow57_LiteralInteger58);
							AddToElementRepository("LiteralBoolean59", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow57_LiteralBoolean59);
						AddToElementRepository("Read a.b3", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b3);
							AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b3_object);
								AddToElementRepository("LiteralInteger60", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b3_object_LiteralInteger60);
								AddToElementRepository("LiteralUnlimitedNatural61", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b3_object_LiteralUnlimitedNatural61);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b3_result);
								AddToElementRepository("LiteralInteger62", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b3_result_LiteralInteger62);
								AddToElementRepository("LiteralUnlimitedNatural63", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b3_result_LiteralUnlimitedNatural63);
					AddToElementRepository("TesterClassifierBehavior", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior);
						AddToElementRepository("Read a.q", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q);
							AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object);
								AddToElementRepository("LiteralInteger64", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object_LiteralInteger64);
								AddToElementRepository("LiteralUnlimitedNatural65", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object_LiteralUnlimitedNatural65);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result);
								AddToElementRepository("LiteralUnlimitedNatural66", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result_LiteralUnlimitedNatural66);
								AddToElementRepository("LiteralInteger67", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result_LiteralInteger67);
						AddToElementRepository("Accept Continue_3", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result);
								AddToElementRepository("LiteralInteger68", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result_LiteralInteger68);
								AddToElementRepository("LiteralUnlimitedNatural69", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result_LiteralUnlimitedNatural69);
								AddToElementRepository("LiteralInteger70", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result_LiteralInteger70);
							AddToElementRepository("Trigger71", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_Trigger71);
						AddToElementRepository("ObjectFlow72", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow72);
							AddToElementRepository("LiteralBoolean73", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow72_LiteralBoolean73);
							AddToElementRepository("LiteralInteger74", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow72_LiteralInteger74);
						AddToElementRepository("ControlFlow75", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow75);
						AddToElementRepository("Accept Start", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start);
							AddToElementRepository("Trigger76", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger76);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result);
								AddToElementRepository("LiteralInteger77", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralInteger77);
								AddToElementRepository("LiteralUnlimitedNatural78", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralUnlimitedNatural78);
								AddToElementRepository("LiteralInteger79", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralInteger79);
						AddToElementRepository("ObjectFlow80", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow80);
							AddToElementRepository("LiteralInteger81", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow80_LiteralInteger81);
							AddToElementRepository("LiteralBoolean82", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow80_LiteralBoolean82);
						AddToElementRepository("Accept Continue_4", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result);
								AddToElementRepository("LiteralUnlimitedNatural83", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result_LiteralUnlimitedNatural83);
								AddToElementRepository("LiteralInteger84", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result_LiteralInteger84);
								AddToElementRepository("LiteralInteger85", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result_LiteralInteger85);
							AddToElementRepository("Trigger86", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_Trigger86);
						AddToElementRepository("Value(4)", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_result);
								AddToElementRepository("LiteralInteger87", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_result_LiteralInteger87);
								AddToElementRepository("LiteralUnlimitedNatural88", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_result_LiteralUnlimitedNatural88);
							AddToElementRepository("LiteralInteger89", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_LiteralInteger89);
						AddToElementRepository("ControlFlow90", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow90);
						AddToElementRepository("Call test()", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test_);
							AddToElementRepository("target", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target);
								AddToElementRepository("LiteralInteger91", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target_LiteralInteger91);
								AddToElementRepository("LiteralUnlimitedNatural92", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target_LiteralUnlimitedNatural92);
						AddToElementRepository("ControlFlow93", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow93);
						AddToElementRepository("ObjectFlow94", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow94);
							AddToElementRepository("LiteralInteger95", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow94_LiteralInteger95);
							AddToElementRepository("LiteralBoolean96", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow94_LiteralBoolean96);
						AddToElementRepository("ControlFlow97", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow97);
						AddToElementRepository("Accept Continue_1", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1);
							AddToElementRepository("Trigger98", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_Trigger98);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result);
								AddToElementRepository("LiteralUnlimitedNatural99", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result_LiteralUnlimitedNatural99);
								AddToElementRepository("LiteralInteger100", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result_LiteralInteger100);
								AddToElementRepository("LiteralInteger101", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result_LiteralInteger101);
						AddToElementRepository("Fork this", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Fork_this);
						AddToElementRepository("ControlFlow102", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow102);
						AddToElementRepository("Read this.a", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result);
								AddToElementRepository("LiteralUnlimitedNatural103", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result_LiteralUnlimitedNatural103);
								AddToElementRepository("LiteralInteger104", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result_LiteralInteger104);
							AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object);
								AddToElementRepository("LiteralUnlimitedNatural105", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object_LiteralUnlimitedNatural105);
								AddToElementRepository("LiteralInteger106", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object_LiteralInteger106);
						AddToElementRepository("Send S", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S);
							AddToElementRepository("t", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_t);
								AddToElementRepository("LiteralInteger107", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_t_LiteralInteger107);
								AddToElementRepository("LiteralUnlimitedNatural108", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_t_LiteralUnlimitedNatural108);
							AddToElementRepository("target", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_target);
								AddToElementRepository("LiteralUnlimitedNatural109", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_target_LiteralUnlimitedNatural109);
								AddToElementRepository("LiteralInteger110", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_target_LiteralInteger110);
							AddToElementRepository("v", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_v);
								AddToElementRepository("LiteralInteger111", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_v_LiteralInteger111);
								AddToElementRepository("LiteralUnlimitedNatural112", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_v_LiteralUnlimitedNatural112);
						AddToElementRepository("ObjectFlow113", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow113);
							AddToElementRepository("LiteralInteger114", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow113_LiteralInteger114);
							AddToElementRepository("LiteralBoolean115", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow113_LiteralBoolean115);
						AddToElementRepository("ObjectFlow116", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow116);
							AddToElementRepository("LiteralBoolean117", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow116_LiteralBoolean117);
							AddToElementRepository("LiteralInteger118", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow116_LiteralInteger118);
						AddToElementRepository("Accept Continue_2", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2);
							AddToElementRepository("Trigger119", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_Trigger119);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result);
								AddToElementRepository("LiteralUnlimitedNatural120", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result_LiteralUnlimitedNatural120);
								AddToElementRepository("LiteralInteger121", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result_LiteralInteger121);
								AddToElementRepository("LiteralInteger122", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result_LiteralInteger122);
						AddToElementRepository("this", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_this);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_this_result);
								AddToElementRepository("LiteralInteger123", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_this_result_LiteralInteger123);
								AddToElementRepository("LiteralUnlimitedNatural124", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_this_result_LiteralUnlimitedNatural124);
						AddToElementRepository("ControlFlow125", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow125);
						AddToElementRepository("ObjectFlow126", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow126);
							AddToElementRepository("LiteralBoolean127", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow126_LiteralBoolean127);
							AddToElementRepository("LiteralInteger128", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow126_LiteralInteger128);
						AddToElementRepository("ObjectFlow129", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow129);
							AddToElementRepository("LiteralBoolean130", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow129_LiteralBoolean130);
							AddToElementRepository("LiteralInteger131", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow129_LiteralInteger131);
					AddToElementRepository("Tester_Tester", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_Tester_Tester);
						AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_Tester_Tester_result);
					AddToElementRepository("a", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_a);
					AddToElementRepository("test", MultipleDelegation_MultipleConnector_P_P_Signal_Tester_test);
				AddToElementRepository("Continue", MultipleDelegation_MultipleConnector_P_P_Signal_Continue);
				AddToElementRepository("main", MultipleDelegation_MultipleConnector_P_P_Signal_main);
					AddToElementRepository("Create Tester", MultipleDelegation_MultipleConnector_P_P_Signal_main_Create_Tester);
						AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Signal_main_Create_Tester_result);
							AddToElementRepository("LiteralInteger132", MultipleDelegation_MultipleConnector_P_P_Signal_main_Create_Tester_result_LiteralInteger132);
							AddToElementRepository("LiteralUnlimitedNatural133", MultipleDelegation_MultipleConnector_P_P_Signal_main_Create_Tester_result_LiteralUnlimitedNatural133);
					AddToElementRepository("ControlFlow134", MultipleDelegation_MultipleConnector_P_P_Signal_main_ControlFlow134);
					AddToElementRepository("Start Tester", MultipleDelegation_MultipleConnector_P_P_Signal_main_Start_Tester);
						AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_P_Signal_main_Start_Tester_object);
							AddToElementRepository("LiteralUnlimitedNatural135", MultipleDelegation_MultipleConnector_P_P_Signal_main_Start_Tester_object_LiteralUnlimitedNatural135);
							AddToElementRepository("LiteralInteger136", MultipleDelegation_MultipleConnector_P_P_Signal_main_Start_Tester_object_LiteralInteger136);
					AddToElementRepository("Tester()", MultipleDelegation_MultipleConnector_P_P_Signal_main_Tester_);
						AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Signal_main_Tester__result);
							AddToElementRepository("LiteralUnlimitedNatural137", MultipleDelegation_MultipleConnector_P_P_Signal_main_Tester__result_LiteralUnlimitedNatural137);
							AddToElementRepository("LiteralInteger138", MultipleDelegation_MultipleConnector_P_P_Signal_main_Tester__result_LiteralInteger138);
							AddToElementRepository("LiteralInteger139", MultipleDelegation_MultipleConnector_P_P_Signal_main_Tester__result_LiteralInteger139);
						AddToElementRepository("target", MultipleDelegation_MultipleConnector_P_P_Signal_main_Tester__target);
							AddToElementRepository("LiteralUnlimitedNatural140", MultipleDelegation_MultipleConnector_P_P_Signal_main_Tester__target_LiteralUnlimitedNatural140);
							AddToElementRepository("LiteralInteger141", MultipleDelegation_MultipleConnector_P_P_Signal_main_Tester__target_LiteralInteger141);
					AddToElementRepository("ObjectFlow142", MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow142);
						AddToElementRepository("LiteralBoolean143", MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow142_LiteralBoolean143);
						AddToElementRepository("LiteralInteger144", MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow142_LiteralInteger144);
					AddToElementRepository("Fork Tester", MultipleDelegation_MultipleConnector_P_P_Signal_main_Fork_Tester);
					AddToElementRepository("Send Start", MultipleDelegation_MultipleConnector_P_P_Signal_main_Send_Start);
						AddToElementRepository("target", MultipleDelegation_MultipleConnector_P_P_Signal_main_Send_Start_target);
							AddToElementRepository("LiteralUnlimitedNatural145", MultipleDelegation_MultipleConnector_P_P_Signal_main_Send_Start_target_LiteralUnlimitedNatural145);
							AddToElementRepository("LiteralInteger146", MultipleDelegation_MultipleConnector_P_P_Signal_main_Send_Start_target_LiteralInteger146);
					AddToElementRepository("ObjectFlow147", MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow147);
						AddToElementRepository("LiteralInteger148", MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow147_LiteralInteger148);
						AddToElementRepository("LiteralBoolean149", MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow147_LiteralBoolean149);
					AddToElementRepository("ObjectFlow150", MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow150);
						AddToElementRepository("LiteralBoolean151", MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow150_LiteralBoolean151);
						AddToElementRepository("LiteralInteger152", MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow150_LiteralInteger152);
					AddToElementRepository("ObjectFlow153", MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow153);
						AddToElementRepository("LiteralInteger154", MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow153_LiteralInteger154);
						AddToElementRepository("LiteralBoolean155", MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow153_LiteralBoolean155);
				AddToElementRepository("A", MultipleDelegation_MultipleConnector_P_P_Signal_A);
					AddToElementRepository("q", MultipleDelegation_MultipleConnector_P_P_Signal_A_q);
					AddToElementRepository("b1", MultipleDelegation_MultipleConnector_P_P_Signal_A_b1);
						AddToElementRepository("LiteralUnlimitedNatural156", MultipleDelegation_MultipleConnector_P_P_Signal_A_b1_LiteralUnlimitedNatural156);
						AddToElementRepository("LiteralInteger157", MultipleDelegation_MultipleConnector_P_P_Signal_A_b1_LiteralInteger157);
					AddToElementRepository("b3", MultipleDelegation_MultipleConnector_P_P_Signal_A_b3);
						AddToElementRepository("LiteralUnlimitedNatural158", MultipleDelegation_MultipleConnector_P_P_Signal_A_b3_LiteralUnlimitedNatural158);
						AddToElementRepository("LiteralInteger159", MultipleDelegation_MultipleConnector_P_P_Signal_A_b3_LiteralInteger159);
					AddToElementRepository("r2", MultipleDelegation_MultipleConnector_P_P_Signal_A_r2);
						AddToElementRepository("ConnectorEnd160", MultipleDelegation_MultipleConnector_P_P_Signal_A_r2_ConnectorEnd160);
						AddToElementRepository("ConnectorEnd161", MultipleDelegation_MultipleConnector_P_P_Signal_A_r2_ConnectorEnd161);
					AddToElementRepository("A_A", MultipleDelegation_MultipleConnector_P_P_Signal_A_A_A);
						AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Signal_A_A_A_result);
					AddToElementRepository("b2", MultipleDelegation_MultipleConnector_P_P_Signal_A_b2);
						AddToElementRepository("LiteralInteger162", MultipleDelegation_MultipleConnector_P_P_Signal_A_b2_LiteralInteger162);
						AddToElementRepository("LiteralUnlimitedNatural163", MultipleDelegation_MultipleConnector_P_P_Signal_A_b2_LiteralUnlimitedNatural163);
					AddToElementRepository("r1", MultipleDelegation_MultipleConnector_P_P_Signal_A_r1);
						AddToElementRepository("ConnectorEnd164", MultipleDelegation_MultipleConnector_P_P_Signal_A_r1_ConnectorEnd164);
							AddToElementRepository("LiteralUnlimitedNatural165", MultipleDelegation_MultipleConnector_P_P_Signal_A_r1_ConnectorEnd164_LiteralUnlimitedNatural165);
						AddToElementRepository("ConnectorEnd166", MultipleDelegation_MultipleConnector_P_P_Signal_A_r1_ConnectorEnd166);
							AddToElementRepository("LiteralUnlimitedNatural167", MultipleDelegation_MultipleConnector_P_P_Signal_A_r1_ConnectorEnd166_LiteralUnlimitedNatural167);
							AddToElementRepository("LiteralInteger168", MultipleDelegation_MultipleConnector_P_P_Signal_A_r1_ConnectorEnd166_LiteralInteger168);
					AddToElementRepository("r3", MultipleDelegation_MultipleConnector_P_P_Signal_A_r3);
						AddToElementRepository("ConnectorEnd169", MultipleDelegation_MultipleConnector_P_P_Signal_A_r3_ConnectorEnd169);
						AddToElementRepository("ConnectorEnd170", MultipleDelegation_MultipleConnector_P_P_Signal_A_r3_ConnectorEnd170);
					AddToElementRepository("r4", MultipleDelegation_MultipleConnector_P_P_Signal_A_r4);
						AddToElementRepository("ConnectorEnd171", MultipleDelegation_MultipleConnector_P_P_Signal_A_r4_ConnectorEnd171);
						AddToElementRepository("ConnectorEnd172", MultipleDelegation_MultipleConnector_P_P_Signal_A_r4_ConnectorEnd172);
					AddToElementRepository("b4", MultipleDelegation_MultipleConnector_P_P_Signal_A_b4);
						AddToElementRepository("LiteralInteger173", MultipleDelegation_MultipleConnector_P_P_Signal_A_b4_LiteralInteger173);
						AddToElementRepository("LiteralUnlimitedNatural174", MultipleDelegation_MultipleConnector_P_P_Signal_A_b4_LiteralUnlimitedNatural174);
				AddToElementRepository("S", MultipleDelegation_MultipleConnector_P_P_Signal_S);
					AddToElementRepository("t", MultipleDelegation_MultipleConnector_P_P_Signal_S_t);
					AddToElementRepository("v", MultipleDelegation_MultipleConnector_P_P_Signal_S_v);
				AddToElementRepository("I", MultipleDelegation_MultipleConnector_P_P_Signal_I);
					AddToElementRepository("S", MultipleDelegation_MultipleConnector_P_P_Signal_I_S);
				AddToElementRepository("B", MultipleDelegation_MultipleConnector_P_P_Signal_B);
					AddToElementRepository("BClassifierBehavior", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior);
						AddToElementRepository("ObjectFlow175", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow175);
							AddToElementRepository("LiteralBoolean176", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow175_LiteralBoolean176);
							AddToElementRepository("LiteralInteger177", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow175_LiteralInteger177);
						AddToElementRepository("ObjectFlow178", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow178);
							AddToElementRepository("LiteralBoolean179", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow178_LiteralBoolean179);
							AddToElementRepository("LiteralInteger180", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow178_LiteralInteger180);
						AddToElementRepository("ControlFlow181", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ControlFlow181);
						AddToElementRepository("ObjectFlow182", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow182);
							AddToElementRepository("LiteralInteger183", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow182_LiteralInteger183);
							AddToElementRepository("LiteralBoolean184", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow182_LiteralBoolean184);
						AddToElementRepository("Accept S", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Accept_S);
							AddToElementRepository("Trigger185", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_Trigger185);
							AddToElementRepository("s", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_s);
								AddToElementRepository("LiteralUnlimitedNatural186", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_s_LiteralUnlimitedNatural186);
								AddToElementRepository("LiteralInteger187", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_s_LiteralInteger187);
								AddToElementRepository("LiteralInteger188", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_s_LiteralInteger188);
						AddToElementRepository("Set this.p", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_result);
								AddToElementRepository("LiteralUnlimitedNatural189", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_result_LiteralUnlimitedNatural189);
								AddToElementRepository("LiteralInteger190", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_result_LiteralInteger190);
							AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_object);
								AddToElementRepository("LiteralInteger191", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_object_LiteralInteger191);
								AddToElementRepository("LiteralUnlimitedNatural192", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_object_LiteralUnlimitedNatural192);
							AddToElementRepository("value", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_value);
								AddToElementRepository("LiteralInteger193", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_value_LiteralInteger193);
								AddToElementRepository("LiteralUnlimitedNatural194", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_value_LiteralUnlimitedNatural194);
						AddToElementRepository("Send Continue", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue);
							AddToElementRepository("target", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue_target);
								AddToElementRepository("LiteralUnlimitedNatural195", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue_target_LiteralUnlimitedNatural195);
								AddToElementRepository("LiteralInteger196", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue_target_LiteralInteger196);
						AddToElementRepository("ObjectFlow197", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow197);
							AddToElementRepository("LiteralBoolean198", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow197_LiteralBoolean198);
							AddToElementRepository("LiteralInteger199", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow197_LiteralInteger199);
						AddToElementRepository("ObjectFlow200", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow200);
							AddToElementRepository("LiteralBoolean201", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow200_LiteralBoolean201);
							AddToElementRepository("LiteralInteger202", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow200_LiteralInteger202);
						AddToElementRepository("Read s.v", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_result);
								AddToElementRepository("LiteralInteger203", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_result_LiteralInteger203);
								AddToElementRepository("LiteralUnlimitedNatural204", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_result_LiteralUnlimitedNatural204);
							AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_object);
								AddToElementRepository("LiteralInteger205", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_object_LiteralInteger205);
								AddToElementRepository("LiteralUnlimitedNatural206", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_object_LiteralUnlimitedNatural206);
						AddToElementRepository("Read s.t", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t);
							AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_object);
								AddToElementRepository("LiteralInteger207", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_object_LiteralInteger207);
								AddToElementRepository("LiteralUnlimitedNatural208", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_object_LiteralUnlimitedNatural208);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_result);
								AddToElementRepository("LiteralUnlimitedNatural209", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_result_LiteralUnlimitedNatural209);
								AddToElementRepository("LiteralInteger210", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_result_LiteralInteger210);
						AddToElementRepository("this", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_this);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_this_result);
								AddToElementRepository("LiteralUnlimitedNatural211", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_this_result_LiteralUnlimitedNatural211);
								AddToElementRepository("LiteralInteger212", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_this_result_LiteralInteger212);
						AddToElementRepository("Fork s", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Fork_s);
						AddToElementRepository("ObjectFlow213", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow213);
							AddToElementRepository("LiteralBoolean214", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow213_LiteralBoolean214);
							AddToElementRepository("LiteralInteger215", MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow213_LiteralInteger215);
					AddToElementRepository("IRealization", MultipleDelegation_MultipleConnector_P_P_Signal_B_IRealization);
					AddToElementRepository("B_B", MultipleDelegation_MultipleConnector_P_P_Signal_B_B_B);
						AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Signal_B_B_B_result);
					AddToElementRepository("p", MultipleDelegation_MultipleConnector_P_P_Signal_B_p);
					AddToElementRepository("S", MultipleDelegation_MultipleConnector_P_P_Signal_B_S);
				AddToElementRepository("R", MultipleDelegation_MultipleConnector_P_P_Signal_R);
					AddToElementRepository("x", MultipleDelegation_MultipleConnector_P_P_Signal_R_x);
						AddToElementRepository("LiteralUnlimitedNatural216", MultipleDelegation_MultipleConnector_P_P_Signal_R_x_LiteralUnlimitedNatural216);
						AddToElementRepository("LiteralInteger217", MultipleDelegation_MultipleConnector_P_P_Signal_R_x_LiteralInteger217);
					AddToElementRepository("y", MultipleDelegation_MultipleConnector_P_P_Signal_R_y);
						AddToElementRepository("LiteralInteger218", MultipleDelegation_MultipleConnector_P_P_Signal_R_y_LiteralInteger218);
						AddToElementRepository("LiteralUnlimitedNatural219", MultipleDelegation_MultipleConnector_P_P_Signal_R_y_LiteralUnlimitedNatural219);
				AddToElementRepository("IImpl", MultipleDelegation_MultipleConnector_P_P_Signal_IImpl);
					AddToElementRepository("IRealization", MultipleDelegation_MultipleConnector_P_P_Signal_IImpl_IRealization);
					AddToElementRepository("S", MultipleDelegation_MultipleConnector_P_P_Signal_IImpl_S);
				AddToElementRepository("AbstractTester", MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester);
					AddToElementRepository("Start", MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester_Start);
					AddToElementRepository("test", MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester_test);
					AddToElementRepository("Continue", MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester_Continue);
				AddToElementRepository("Start", MultipleDelegation_MultipleConnector_P_P_Signal_Start);

			// Initialize public members
			/*
			 * Model MultipleDelegation_MultipleConnector_P_P_Signal
			 */
			MultipleDelegation_MultipleConnector_P_P_Signal.SetName("MultipleDelegation_MultipleConnector_P_P_Signal");
			MultipleDelegation_MultipleConnector_P_P_Signal.SetVisibility(VisibilityKind.public_);
				// SignalEvent StartEvent
				MultipleDelegation_MultipleConnector_P_P_Signal_StartEvent.SetName("StartEvent");
				MultipleDelegation_MultipleConnector_P_P_Signal_StartEvent.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_MultipleConnector_P_P_Signal_StartEvent.SetSignal(MultipleDelegation_MultipleConnector_P_P_Signal_Start);
			MultipleDelegation_MultipleConnector_P_P_Signal.AddPackagedElement(MultipleDelegation_MultipleConnector_P_P_Signal_StartEvent);
				// SignalEvent ContinueEvent
				MultipleDelegation_MultipleConnector_P_P_Signal_ContinueEvent.SetName("ContinueEvent");
				MultipleDelegation_MultipleConnector_P_P_Signal_ContinueEvent.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_MultipleConnector_P_P_Signal_ContinueEvent.SetSignal(MultipleDelegation_MultipleConnector_P_P_Signal_Continue);
			MultipleDelegation_MultipleConnector_P_P_Signal.AddPackagedElement(MultipleDelegation_MultipleConnector_P_P_Signal_ContinueEvent);
				// SignalEvent SEvent
				MultipleDelegation_MultipleConnector_P_P_Signal_SEvent.SetName("SEvent");
				MultipleDelegation_MultipleConnector_P_P_Signal_SEvent.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_MultipleConnector_P_P_Signal_SEvent.SetSignal(MultipleDelegation_MultipleConnector_P_P_Signal_S);
			MultipleDelegation_MultipleConnector_P_P_Signal.AddPackagedElement(MultipleDelegation_MultipleConnector_P_P_Signal_SEvent);
				// Class Tester
				MultipleDelegation_MultipleConnector_P_P_Signal_Tester.SetName("Tester");
				MultipleDelegation_MultipleConnector_P_P_Signal_Tester.SetVisibility(VisibilityKind.public_);
				
					// Generalization to AbstractTester
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_Generalization0.SetGeneral(MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester);
				MultipleDelegation_MultipleConnector_P_P_Signal_Tester.AddGeneralization(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_Generalization0);
					// Property a
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_a.SetName("a");
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_a.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_a.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_A);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_a.SetAggregation(AggregationKind.composite);
				MultipleDelegation_MultipleConnector_P_P_Signal_Tester.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_a);
				MultipleDelegation_MultipleConnector_P_P_Signal_Tester.SetClassifierBehavior(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior);
					// Activity testActivity
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity.SetName("testActivity");
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity.SetVisibility(VisibilityKind.public_);
					// FunctionBehavior testP
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_testP.SetName("testP");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_testP.SetVisibility(VisibilityKind.public_);
						
							// Parameter p
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_testP_p.SetName("p");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_testP_p.SetVisibility(VisibilityKind.public_);
							
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_testP.AddOwnedParameter(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_testP_p);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_testP.AddLanguage("C#");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_testP.AddLanguage("Using");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_testP.AddBody("if(index == 1) 	{ 		Console.WriteLine(\"Asserting a.b1.p == 4 && a.b2.p == 4 && a.b3.p == 4 && a.b4.p == 4\"); 	}  	// For some reason, during the first execution of the expansion region, its body is actually executed twice. 	// Because of that, the body is actually executaed 5 times in total. This if-statement covers that up until solved. 	if(index <= MAX_INDEX) 	{  		// Test parameter p 		int p = ((IntegerValue)inputParameters.ElementAt(0).values.ElementAt(0)).value; 		Debug.Println(\"[doBody] argument p = \" + p); 	 		Console.WriteLine( \"a.b\" + index + \".p == \" + p); 		success = success && (p == 4);  		if(index == MAX_INDEX) 		{  			Console.Write(\"Signal delegated on all links (shall be true for default strategy): \");  			if(success) 			{ 				Console.ForegroundColor = ConsoleColor.Green; 				Console.WriteLine(\"Assertion successful.\"); 			} 			else 			{ 				Console.ForegroundColor = ConsoleColor.Red; 				Console.WriteLine(\"Assertion failed!\"); 			}  			Console.ResetColor(); 		} 	}  	index++;");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_testP.AddBody("using fuml.semantics.simpleclassifiers; ");
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity.AddOwnedBehavior(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_testP);
						// ReadStructuralFeatureAction Read a.b2
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b2.SetName("Read a.b2");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b2.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b2.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_P_Signal_A_b2);
							// InputPin object
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b2_object.SetName("object");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b2_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b2_object.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_A);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b2.SetObject(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b2_object);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b2_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b2_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b2_result.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_B);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b2.SetResult(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b2_result);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b2);
						// ReadStructuralFeatureAction Read this.a
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_this_a.SetName("Read this.a");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_this_a.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_this_a.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_a);
							// InputPin object
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_this_a_object.SetName("object");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_this_a_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_this_a_object.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_Tester);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_this_a.SetObject(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_this_a_object);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_this_a_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_this_a_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_this_a_result.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_A);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_this_a.SetResult(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_this_a_result);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_this_a);
						// ReadStructuralFeatureAction Read b.p
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p.SetName("Read b.p");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_P_Signal_B_p);
							// InputPin object
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p_object.SetName("object");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p_object.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_B);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p.SetObject(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p_object);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p.SetResult(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p_result);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p);
						// ReadSelfAction this
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_this.SetName("this");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_this_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_this_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_this_result.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_Tester);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_this.SetResult(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_this_result);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_this);
						// CallBehaviorAction Call testP
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Call_testP.SetName("Call testP");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Call_testP.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Call_testP.SetBehavior(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_testP);
							// InputPin p
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Call_testP_p.SetName("p");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Call_testP_p.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Call_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Call_testP.AddArgument(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Call_testP_p);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Call_testP);
						// ReadStructuralFeatureAction Read a.b4
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b4.SetName("Read a.b4");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b4.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b4.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_P_Signal_A_b4);
							// InputPin object
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b4_object.SetName("object");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b4_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b4_object.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_A);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b4.SetObject(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b4_object);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b4_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b4_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b4_result.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_B);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b4.SetResult(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b4_result);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b4);
						// ReadStructuralFeatureAction Read a.b1
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b1.SetName("Read a.b1");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b1.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b1.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_P_Signal_A_b1);
							// InputPin object
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b1_object.SetName("object");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b1_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b1_object.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_A);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b1.SetObject(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b1_object);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b1_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b1_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b1_result.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_B);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b1.SetResult(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b1_result);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b1);
						// ForkNode Fork a
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Fork_a.SetName("Fork a");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Fork_a.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Fork_a);
						// ReadStructuralFeatureAction Read a.b3
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b3.SetName("Read a.b3");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b3.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b3.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_P_Signal_A_b3);
							// InputPin object
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b3_object.SetName("object");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b3_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b3_object.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_A);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b3.SetObject(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b3_object);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b3_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b3_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b3_result.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_B);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b3.SetResult(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b3_result);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b3);
						// ObjectFlow ObjectFlow1 from Fork a to object
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow1.SetName("ObjectFlow1");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow1.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow1.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Fork_a);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow1.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b1_object);
							// LiteralBoolean LiteralBoolean2
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow1_LiteralBoolean2.SetName("LiteralBoolean2");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow1_LiteralBoolean2.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow1_LiteralBoolean2.SetValue(true);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow1.SetGuard(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow1_LiteralBoolean2);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow1);
						// ObjectFlow ObjectFlow8 from result to p
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow8.SetName("ObjectFlow8");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow8.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow8.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p_result);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow8.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Call_testP_p);
							// LiteralBoolean LiteralBoolean9
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow8_LiteralBoolean9.SetName("LiteralBoolean9");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow8_LiteralBoolean9.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow8_LiteralBoolean9.SetValue(true);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow8.SetGuard(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow8_LiteralBoolean9);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow8);
						// ControlFlow ControlFlow15 from Read a.b2 to Read a.b3
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ControlFlow15.SetName("ControlFlow15");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ControlFlow15.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ControlFlow15.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b2);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ControlFlow15.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b3);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ControlFlow15);
						// ControlFlow ControlFlow16 from Read a.b3 to Read a.b4
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ControlFlow16.SetName("ControlFlow16");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ControlFlow16.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ControlFlow16.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b3);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ControlFlow16.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b4);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ControlFlow16);
						// ObjectFlow ObjectFlow20 from Fork a to object
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow20.SetName("ObjectFlow20");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow20.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow20.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Fork_a);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow20.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b4_object);
							// LiteralBoolean LiteralBoolean22
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow20_LiteralBoolean22.SetName("LiteralBoolean22");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow20_LiteralBoolean22.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow20_LiteralBoolean22.SetValue(true);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow20.SetGuard(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow20_LiteralBoolean22);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow20);
						// ObjectFlow ObjectFlow23 from result to object
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow23.SetName("ObjectFlow23");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow23.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow23.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_this_result);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow23.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_this_a_object);
							// LiteralBoolean LiteralBoolean24
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow23_LiteralBoolean24.SetName("LiteralBoolean24");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow23_LiteralBoolean24.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow23_LiteralBoolean24.SetValue(true);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow23.SetGuard(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow23_LiteralBoolean24);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow23);
						// ObjectFlow ObjectFlow26 from result to object
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow26.SetName("ObjectFlow26");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow26.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow26.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b3_result);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow26.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p_object);
							// LiteralBoolean LiteralBoolean27
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow26_LiteralBoolean27.SetName("LiteralBoolean27");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow26_LiteralBoolean27.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow26_LiteralBoolean27.SetValue(true);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow26.SetGuard(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow26_LiteralBoolean27);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow26);
						// ControlFlow ControlFlow29 from Read a.b1 to Read a.b2
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ControlFlow29.SetName("ControlFlow29");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ControlFlow29.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ControlFlow29.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b1);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ControlFlow29.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b2);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ControlFlow29);
						// ObjectFlow ObjectFlow32 from result to object
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow32.SetName("ObjectFlow32");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow32.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow32.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b1_result);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow32.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p_object);
							// LiteralBoolean LiteralBoolean33
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow32_LiteralBoolean33.SetName("LiteralBoolean33");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow32_LiteralBoolean33.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow32_LiteralBoolean33.SetValue(true);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow32.SetGuard(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow32_LiteralBoolean33);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow32);
						// ObjectFlow ObjectFlow39 from Fork a to object
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow39.SetName("ObjectFlow39");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow39.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow39.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Fork_a);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow39.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b2_object);
							// LiteralBoolean LiteralBoolean40
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow39_LiteralBoolean40.SetName("LiteralBoolean40");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow39_LiteralBoolean40.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow39_LiteralBoolean40.SetValue(true);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow39.SetGuard(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow39_LiteralBoolean40);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow39);
						// ObjectFlow ObjectFlow42 from Fork a to object
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow42.SetName("ObjectFlow42");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow42.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow42.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Fork_a);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow42.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b3_object);
							// LiteralBoolean LiteralBoolean43
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow42_LiteralBoolean43.SetName("LiteralBoolean43");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow42_LiteralBoolean43.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow42_LiteralBoolean43.SetValue(true);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow42.SetGuard(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow42_LiteralBoolean43);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow42);
						// ObjectFlow ObjectFlow51 from result to Fork a
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow51.SetName("ObjectFlow51");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow51.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow51.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_this_a_result);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow51.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Fork_a);
							// LiteralBoolean LiteralBoolean52
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow51_LiteralBoolean52.SetName("LiteralBoolean52");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow51_LiteralBoolean52.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow51_LiteralBoolean52.SetValue(true);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow51.SetGuard(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow51_LiteralBoolean52);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow51);
						// ObjectFlow ObjectFlow54 from result to object
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow54.SetName("ObjectFlow54");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow54.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow54.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b4_result);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow54.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p_object);
							// LiteralBoolean LiteralBoolean55
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow54_LiteralBoolean55.SetName("LiteralBoolean55");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow54_LiteralBoolean55.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow54_LiteralBoolean55.SetValue(true);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow54.SetGuard(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow54_LiteralBoolean55);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow54);
						// ObjectFlow ObjectFlow57 from result to object
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow57.SetName("ObjectFlow57");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow57.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow57.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_a_b2_result);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow57.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_Read_b_p_object);
							// LiteralBoolean LiteralBoolean59
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow57_LiteralBoolean59.SetName("LiteralBoolean59");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow57_LiteralBoolean59.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow57_LiteralBoolean59.SetValue(true);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow57.SetGuard(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow57_LiteralBoolean59);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity_ObjectFlow57);
				MultipleDelegation_MultipleConnector_P_P_Signal_Tester.AddOwnedBehavior(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity);
					// Activity TesterClassifierBehavior
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior.SetName("TesterClassifierBehavior");
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior.SetVisibility(VisibilityKind.public_);
						// ForkNode Fork this
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Fork_this.SetName("Fork this");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Fork_this.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Fork_this);
						// ReadStructuralFeatureAction Read a.q
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q.SetName("Read a.q");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_P_Signal_A_q);
							// InputPin object
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object.SetName("object");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_A);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q.SetObject(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_IImpl);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q.SetResult(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q);
						// AcceptEventAction Accept Continue_3
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3.SetName("Accept Continue_3");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_Continue);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3.AddResult(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result);
							// Trigger Trigger71
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_Trigger71.SetName("Trigger71");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_Trigger71.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_Trigger71.SetEvent(MultipleDelegation_MultipleConnector_P_P_Signal_ContinueEvent);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3.AddTrigger(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_Trigger71);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3);
						// ReadStructuralFeatureAction Read this.a
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a.SetName("Read this.a");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_a);
							// InputPin object
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object.SetName("object");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_Tester);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a.SetObject(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_A);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a.SetResult(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a);
						// SendSignalAction Send S
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S.SetName("Send S");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S.SetSignal(MultipleDelegation_MultipleConnector_P_P_Signal_S);
							// InputPin target
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_target.SetName("target");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_target.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_target.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_IImpl);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_target);
							// InputPin v
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_v.SetName("v");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_v.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S.AddArgument(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_v);
							// InputPin t
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_t.SetName("t");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_t.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_t.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S.AddArgument(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_t);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S);
						// AcceptEventAction Accept Continue_2
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2.SetName("Accept Continue_2");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_Continue);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2.AddResult(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result);
							// Trigger Trigger119
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_Trigger119.SetName("Trigger119");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_Trigger119.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_Trigger119.SetEvent(MultipleDelegation_MultipleConnector_P_P_Signal_ContinueEvent);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2.AddTrigger(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_Trigger119);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2);
						// AcceptEventAction Accept Start
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start.SetName("Accept Start");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_Start);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start.AddResult(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result);
							// Trigger Trigger76
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger76.SetName("Trigger76");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger76.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger76.SetEvent(MultipleDelegation_MultipleConnector_P_P_Signal_StartEvent);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start.AddTrigger(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger76);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start);
						// ReadSelfAction this
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_this.SetName("this");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_this_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_this_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_this_result.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_Tester);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_this.SetResult(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_this_result);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_this);
						// AcceptEventAction Accept Continue_4
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4.SetName("Accept Continue_4");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_Continue);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4.AddResult(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result);
							// Trigger Trigger86
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_Trigger86.SetName("Trigger86");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_Trigger86.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_Trigger86.SetEvent(MultipleDelegation_MultipleConnector_P_P_Signal_ContinueEvent);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4.AddTrigger(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_Trigger86);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4);
						// ValueSpecificationAction Value(4)
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4.SetName("Value(4)");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4.SetVisibility(VisibilityKind.public_);
							// LiteralInteger LiteralInteger89
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_LiteralInteger89.SetName("LiteralInteger89");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_LiteralInteger89.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_LiteralInteger89.SetValue(4);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4.SetValue(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_LiteralInteger89);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4.SetResult(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_result);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4);
						// CallOperationAction Call test()
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test_.SetName("Call test()");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test_.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test_.SetOperation(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_test);
							// InputPin target
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target.SetName("target");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_Tester);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test_.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test_);
						// AcceptEventAction Accept Continue_1
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1.SetName("Accept Continue_1");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_Continue);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1.AddResult(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result);
							// Trigger Trigger98
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_Trigger98.SetName("Trigger98");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_Trigger98.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_Trigger98.SetEvent(MultipleDelegation_MultipleConnector_P_P_Signal_ContinueEvent);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1.AddTrigger(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_Trigger98);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1);
						// ControlFlow ControlFlow102 from Send S to Accept Continue_1
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow102.SetName("ControlFlow102");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow102.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow102.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow102.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow102);
						// ObjectFlow ObjectFlow113 from Fork this to t
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow113.SetName("ObjectFlow113");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow113.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow113.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Fork_this);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow113.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_t);
							// LiteralBoolean LiteralBoolean115
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow113_LiteralBoolean115.SetName("LiteralBoolean115");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow113_LiteralBoolean115.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow113_LiteralBoolean115.SetValue(true);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow113.SetGuard(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow113_LiteralBoolean115);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow113);
						// ObjectFlow ObjectFlow116 from result to object
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow116.SetName("ObjectFlow116");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow116.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow116.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow116.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object);
							// LiteralBoolean LiteralBoolean117
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow116_LiteralBoolean117.SetName("LiteralBoolean117");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow116_LiteralBoolean117.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow116_LiteralBoolean117.SetValue(true);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow116.SetGuard(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow116_LiteralBoolean117);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow116);
						// ObjectFlow ObjectFlow72 from result to v
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow72.SetName("ObjectFlow72");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow72.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow72.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_result);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow72.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_v);
							// LiteralBoolean LiteralBoolean73
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow72_LiteralBoolean73.SetName("LiteralBoolean73");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow72_LiteralBoolean73.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow72_LiteralBoolean73.SetValue(true);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow72.SetGuard(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow72_LiteralBoolean73);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow72);
						// ControlFlow ControlFlow75 from Accept Continue_3 to Accept Continue_4
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow75.SetName("ControlFlow75");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow75.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow75.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow75.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow75);
						// ObjectFlow ObjectFlow80 from Fork this to object
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow80.SetName("ObjectFlow80");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow80.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow80.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Fork_this);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow80.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object);
							// LiteralBoolean LiteralBoolean82
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow80_LiteralBoolean82.SetName("LiteralBoolean82");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow80_LiteralBoolean82.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow80_LiteralBoolean82.SetValue(true);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow80.SetGuard(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow80_LiteralBoolean82);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow80);
						// ControlFlow ControlFlow125 from Accept Continue_2 to Accept Continue_3
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow125.SetName("ControlFlow125");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow125.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow125.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow125.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow125);
						// ObjectFlow ObjectFlow126 from result to Fork this
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow126.SetName("ObjectFlow126");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow126.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow126.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_this_result);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow126.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Fork_this);
							// LiteralBoolean LiteralBoolean127
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow126_LiteralBoolean127.SetName("LiteralBoolean127");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow126_LiteralBoolean127.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow126_LiteralBoolean127.SetValue(true);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow126.SetGuard(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow126_LiteralBoolean127);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow126);
						// ControlFlow ControlFlow90 from Accept Start to this
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow90.SetName("ControlFlow90");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow90.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow90.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow90.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_this);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow90);
						// ObjectFlow ObjectFlow129 from result to target
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow129.SetName("ObjectFlow129");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow129.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow129.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow129.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_target);
							// LiteralBoolean LiteralBoolean130
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow129_LiteralBoolean130.SetName("LiteralBoolean130");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow129_LiteralBoolean130.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow129_LiteralBoolean130.SetValue(true);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow129.SetGuard(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow129_LiteralBoolean130);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow129);
						// ControlFlow ControlFlow93 from Accept Continue_4 to Call test()
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow93.SetName("ControlFlow93");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow93.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow93.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow93.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test_);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow93);
						// ObjectFlow ObjectFlow94 from Fork this to target
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow94.SetName("ObjectFlow94");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow94.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow94.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Fork_this);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow94.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target);
							// LiteralBoolean LiteralBoolean96
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow94_LiteralBoolean96.SetName("LiteralBoolean96");
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow94_LiteralBoolean96.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow94_LiteralBoolean96.SetValue(true);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow94.SetGuard(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow94_LiteralBoolean96);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow94);
						// ControlFlow ControlFlow97 from Accept Continue_1 to Accept Continue_2
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow97.SetName("ControlFlow97");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow97.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow97.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow97.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow97);
				MultipleDelegation_MultipleConnector_P_P_Signal_Tester.AddOwnedBehavior(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_TesterClassifierBehavior);
				
				MultipleDelegation_MultipleConnector_P_P_Signal_Tester.SetIsActive(true);
					// Operation Tester_Tester
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_Tester_Tester.SetName("Tester_Tester");
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_Tester_Tester.SetVisibility(VisibilityKind.public_);
						// Parameter result
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_Tester_Tester_result.SetName("result");
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_Tester_Tester_result.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_Tester_Tester_result.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_Tester);
						MultipleDelegation_MultipleConnector_P_P_Signal_Tester_Tester_Tester_result.SetDirection(ParameterDirectionKind.return_);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_Tester_Tester.AddOwnedParameter(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_Tester_Tester_result);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_Tester_Tester.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				MultipleDelegation_MultipleConnector_P_P_Signal_Tester.AddOwnedOperation(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_Tester_Tester);
					// Operation test
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_test.SetName("test");
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_test.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_P_Signal_Tester_test.AddMethod(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_testActivity);
				MultipleDelegation_MultipleConnector_P_P_Signal_Tester.AddOwnedOperation(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_test);
			MultipleDelegation_MultipleConnector_P_P_Signal.AddPackagedElement(MultipleDelegation_MultipleConnector_P_P_Signal_Tester);
				// Signal Continue
				MultipleDelegation_MultipleConnector_P_P_Signal_Continue.SetName("Continue");
				MultipleDelegation_MultipleConnector_P_P_Signal_Continue.SetVisibility(VisibilityKind.public_);
			MultipleDelegation_MultipleConnector_P_P_Signal.AddPackagedElement(MultipleDelegation_MultipleConnector_P_P_Signal_Continue);
				// Activity main
				MultipleDelegation_MultipleConnector_P_P_Signal_main.SetName("main");
				MultipleDelegation_MultipleConnector_P_P_Signal_main.SetVisibility(VisibilityKind.public_);
					// CreateObjectAction Create Tester
					MultipleDelegation_MultipleConnector_P_P_Signal_main_Create_Tester.SetName("Create Tester");
					MultipleDelegation_MultipleConnector_P_P_Signal_main_Create_Tester.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_P_Signal_main_Create_Tester.SetClassifier(MultipleDelegation_MultipleConnector_P_P_Signal_Tester);
						// OutputPin result
						MultipleDelegation_MultipleConnector_P_P_Signal_main_Create_Tester_result.SetName("result");
						MultipleDelegation_MultipleConnector_P_P_Signal_main_Create_Tester_result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Signal_main_Create_Tester_result.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_Tester);
					MultipleDelegation_MultipleConnector_P_P_Signal_main_Create_Tester.SetResult(MultipleDelegation_MultipleConnector_P_P_Signal_main_Create_Tester_result);
				MultipleDelegation_MultipleConnector_P_P_Signal_main.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_main_Create_Tester);
					// StartObjectBehaviorAction Start Tester
					MultipleDelegation_MultipleConnector_P_P_Signal_main_Start_Tester.SetName("Start Tester");
					MultipleDelegation_MultipleConnector_P_P_Signal_main_Start_Tester.SetVisibility(VisibilityKind.public_);
						// InputPin object
						MultipleDelegation_MultipleConnector_P_P_Signal_main_Start_Tester_object.SetName("object");
						MultipleDelegation_MultipleConnector_P_P_Signal_main_Start_Tester_object.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_P_Signal_main_Start_Tester.SetObject(MultipleDelegation_MultipleConnector_P_P_Signal_main_Start_Tester_object);
				MultipleDelegation_MultipleConnector_P_P_Signal_main.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_main_Start_Tester);
					// CallOperationAction Tester()
					MultipleDelegation_MultipleConnector_P_P_Signal_main_Tester_.SetName("Tester()");
					MultipleDelegation_MultipleConnector_P_P_Signal_main_Tester_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						MultipleDelegation_MultipleConnector_P_P_Signal_main_Tester__result.SetName("result");
						MultipleDelegation_MultipleConnector_P_P_Signal_main_Tester__result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Signal_main_Tester__result.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_Tester);
					MultipleDelegation_MultipleConnector_P_P_Signal_main_Tester_.AddResult(MultipleDelegation_MultipleConnector_P_P_Signal_main_Tester__result);
					MultipleDelegation_MultipleConnector_P_P_Signal_main_Tester_.SetOperation(MultipleDelegation_MultipleConnector_P_P_Signal_Tester_Tester_Tester);
						// InputPin target
						MultipleDelegation_MultipleConnector_P_P_Signal_main_Tester__target.SetName("target");
						MultipleDelegation_MultipleConnector_P_P_Signal_main_Tester__target.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Signal_main_Tester__target.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_Tester);
					MultipleDelegation_MultipleConnector_P_P_Signal_main_Tester_.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_main_Tester__target);
				MultipleDelegation_MultipleConnector_P_P_Signal_main.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_main_Tester_);
					// ForkNode Fork Tester
					MultipleDelegation_MultipleConnector_P_P_Signal_main_Fork_Tester.SetName("Fork Tester");
					MultipleDelegation_MultipleConnector_P_P_Signal_main_Fork_Tester.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_MultipleConnector_P_P_Signal_main.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_main_Fork_Tester);
					// SendSignalAction Send Start
					MultipleDelegation_MultipleConnector_P_P_Signal_main_Send_Start.SetName("Send Start");
					MultipleDelegation_MultipleConnector_P_P_Signal_main_Send_Start.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_P_Signal_main_Send_Start.SetSignal(MultipleDelegation_MultipleConnector_P_P_Signal_Start);
						// InputPin target
						MultipleDelegation_MultipleConnector_P_P_Signal_main_Send_Start_target.SetName("target");
						MultipleDelegation_MultipleConnector_P_P_Signal_main_Send_Start_target.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Signal_main_Send_Start_target.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_Tester);
					MultipleDelegation_MultipleConnector_P_P_Signal_main_Send_Start.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_main_Send_Start_target);
				MultipleDelegation_MultipleConnector_P_P_Signal_main.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_main_Send_Start);
					// ControlFlow ControlFlow134 from Start Tester to Send Start
					MultipleDelegation_MultipleConnector_P_P_Signal_main_ControlFlow134.SetName("ControlFlow134");
					MultipleDelegation_MultipleConnector_P_P_Signal_main_ControlFlow134.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Signal_main_ControlFlow134.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_main_Start_Tester);
					MultipleDelegation_MultipleConnector_P_P_Signal_main_ControlFlow134.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_main_Send_Start);
				MultipleDelegation_MultipleConnector_P_P_Signal_main.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_main_ControlFlow134);
					// ObjectFlow ObjectFlow142 from result to target
					MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow142.SetName("ObjectFlow142");
					MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow142.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow142.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_main_Create_Tester_result);
					MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow142.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_main_Tester__target);
						// LiteralBoolean LiteralBoolean143
						MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow142_LiteralBoolean143.SetName("LiteralBoolean143");
						MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow142_LiteralBoolean143.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow142_LiteralBoolean143.SetValue(true);
					MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow142.SetGuard(MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow142_LiteralBoolean143);
				MultipleDelegation_MultipleConnector_P_P_Signal_main.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow142);
					// ObjectFlow ObjectFlow147 from Fork Tester to target
					MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow147.SetName("ObjectFlow147");
					MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow147.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow147.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_main_Fork_Tester);
					MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow147.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_main_Send_Start_target);
						// LiteralBoolean LiteralBoolean149
						MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow147_LiteralBoolean149.SetName("LiteralBoolean149");
						MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow147_LiteralBoolean149.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow147_LiteralBoolean149.SetValue(true);
					MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow147.SetGuard(MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow147_LiteralBoolean149);
				MultipleDelegation_MultipleConnector_P_P_Signal_main.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow147);
					// ObjectFlow ObjectFlow150 from result to Fork Tester
					MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow150.SetName("ObjectFlow150");
					MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow150.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow150.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_main_Tester__result);
					MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow150.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_main_Fork_Tester);
						// LiteralBoolean LiteralBoolean151
						MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow150_LiteralBoolean151.SetName("LiteralBoolean151");
						MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow150_LiteralBoolean151.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow150_LiteralBoolean151.SetValue(true);
					MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow150.SetGuard(MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow150_LiteralBoolean151);
				MultipleDelegation_MultipleConnector_P_P_Signal_main.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow150);
					// ObjectFlow ObjectFlow153 from Fork Tester to object
					MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow153.SetName("ObjectFlow153");
					MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow153.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow153.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_main_Fork_Tester);
					MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow153.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_main_Start_Tester_object);
						// LiteralBoolean LiteralBoolean155
						MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow153_LiteralBoolean155.SetName("LiteralBoolean155");
						MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow153_LiteralBoolean155.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow153_LiteralBoolean155.SetValue(true);
					MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow153.SetGuard(MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow153_LiteralBoolean155);
				MultipleDelegation_MultipleConnector_P_P_Signal_main.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_main_ObjectFlow153);
			MultipleDelegation_MultipleConnector_P_P_Signal.AddPackagedElement(MultipleDelegation_MultipleConnector_P_P_Signal_main);
				// Class A
				MultipleDelegation_MultipleConnector_P_P_Signal_A.SetName("A");
				MultipleDelegation_MultipleConnector_P_P_Signal_A.SetVisibility(VisibilityKind.public_);
				
					// Port q
					MultipleDelegation_MultipleConnector_P_P_Signal_A_q.SetName("q");
					MultipleDelegation_MultipleConnector_P_P_Signal_A_q.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Signal_A_q.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_IImpl);
					MultipleDelegation_MultipleConnector_P_P_Signal_A_q.SetAggregation(AggregationKind.composite);
					MultipleDelegation_MultipleConnector_P_P_Signal_A_q.isService = true;
					MultipleDelegation_MultipleConnector_P_P_Signal_A_q.AddProvided(MultipleDelegation_MultipleConnector_P_P_Signal_I);
				MultipleDelegation_MultipleConnector_P_P_Signal_A.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_P_Signal_A_q);
					// Property b1
					MultipleDelegation_MultipleConnector_P_P_Signal_A_b1.SetName("b1");
					MultipleDelegation_MultipleConnector_P_P_Signal_A_b1.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Signal_A_b1.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_B);
					MultipleDelegation_MultipleConnector_P_P_Signal_A_b1.SetAggregation(AggregationKind.composite);
				MultipleDelegation_MultipleConnector_P_P_Signal_A.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_P_Signal_A_b1);
					// Property b2
					MultipleDelegation_MultipleConnector_P_P_Signal_A_b2.SetName("b2");
					MultipleDelegation_MultipleConnector_P_P_Signal_A_b2.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Signal_A_b2.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_B);
					MultipleDelegation_MultipleConnector_P_P_Signal_A_b2.SetAggregation(AggregationKind.composite);
				MultipleDelegation_MultipleConnector_P_P_Signal_A.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_P_Signal_A_b2);
					// Property b3
					MultipleDelegation_MultipleConnector_P_P_Signal_A_b3.SetName("b3");
					MultipleDelegation_MultipleConnector_P_P_Signal_A_b3.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Signal_A_b3.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_B);
					MultipleDelegation_MultipleConnector_P_P_Signal_A_b3.SetAggregation(AggregationKind.composite);
				MultipleDelegation_MultipleConnector_P_P_Signal_A.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_P_Signal_A_b3);
					// Property b4
					MultipleDelegation_MultipleConnector_P_P_Signal_A_b4.SetName("b4");
					MultipleDelegation_MultipleConnector_P_P_Signal_A_b4.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Signal_A_b4.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_B);
					MultipleDelegation_MultipleConnector_P_P_Signal_A_b4.SetAggregation(AggregationKind.composite);
				MultipleDelegation_MultipleConnector_P_P_Signal_A.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_P_Signal_A_b4);
				
				MultipleDelegation_MultipleConnector_P_P_Signal_A_r2.SetName("r2");
					MultipleDelegation_MultipleConnector_P_P_Signal_A_r2.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_A_r2_ConnectorEnd161.SetRole(MultipleDelegation_MultipleConnector_P_P_Signal_A_q);
						
					MultipleDelegation_MultipleConnector_P_P_Signal_A_r2.AddEnd(MultipleDelegation_MultipleConnector_P_P_Signal_A_r2_ConnectorEnd161);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_A_r2_ConnectorEnd160.SetRole(MultipleDelegation_MultipleConnector_P_P_Signal_A_b2);
						
					MultipleDelegation_MultipleConnector_P_P_Signal_A_r2.AddEnd(MultipleDelegation_MultipleConnector_P_P_Signal_A_r2_ConnectorEnd160);
				MultipleDelegation_MultipleConnector_P_P_Signal_A.AddOwnedConnector(MultipleDelegation_MultipleConnector_P_P_Signal_A_r2);
					MultipleDelegation_MultipleConnector_P_P_Signal_A_r1.SetName("r1");
					MultipleDelegation_MultipleConnector_P_P_Signal_A_r1.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_A_r1_ConnectorEnd164.SetRole(MultipleDelegation_MultipleConnector_P_P_Signal_A_q);
						
					MultipleDelegation_MultipleConnector_P_P_Signal_A_r1.AddEnd(MultipleDelegation_MultipleConnector_P_P_Signal_A_r1_ConnectorEnd164);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_A_r1_ConnectorEnd166.SetRole(MultipleDelegation_MultipleConnector_P_P_Signal_A_b1);
						
					MultipleDelegation_MultipleConnector_P_P_Signal_A_r1.AddEnd(MultipleDelegation_MultipleConnector_P_P_Signal_A_r1_ConnectorEnd166);
					MultipleDelegation_MultipleConnector_P_P_Signal_A_r1.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_R);
				MultipleDelegation_MultipleConnector_P_P_Signal_A.AddOwnedConnector(MultipleDelegation_MultipleConnector_P_P_Signal_A_r1);
					MultipleDelegation_MultipleConnector_P_P_Signal_A_r3.SetName("r3");
					MultipleDelegation_MultipleConnector_P_P_Signal_A_r3.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_A_r3_ConnectorEnd169.SetRole(MultipleDelegation_MultipleConnector_P_P_Signal_A_q);
						
					MultipleDelegation_MultipleConnector_P_P_Signal_A_r3.AddEnd(MultipleDelegation_MultipleConnector_P_P_Signal_A_r3_ConnectorEnd169);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_A_r3_ConnectorEnd170.SetRole(MultipleDelegation_MultipleConnector_P_P_Signal_A_b3);
						
					MultipleDelegation_MultipleConnector_P_P_Signal_A_r3.AddEnd(MultipleDelegation_MultipleConnector_P_P_Signal_A_r3_ConnectorEnd170);
				MultipleDelegation_MultipleConnector_P_P_Signal_A.AddOwnedConnector(MultipleDelegation_MultipleConnector_P_P_Signal_A_r3);
					MultipleDelegation_MultipleConnector_P_P_Signal_A_r4.SetName("r4");
					MultipleDelegation_MultipleConnector_P_P_Signal_A_r4.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_A_r4_ConnectorEnd172.SetRole(MultipleDelegation_MultipleConnector_P_P_Signal_A_q);
						
					MultipleDelegation_MultipleConnector_P_P_Signal_A_r4.AddEnd(MultipleDelegation_MultipleConnector_P_P_Signal_A_r4_ConnectorEnd172);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_A_r4_ConnectorEnd171.SetRole(MultipleDelegation_MultipleConnector_P_P_Signal_A_b4);
						
					MultipleDelegation_MultipleConnector_P_P_Signal_A_r4.AddEnd(MultipleDelegation_MultipleConnector_P_P_Signal_A_r4_ConnectorEnd171);
				MultipleDelegation_MultipleConnector_P_P_Signal_A.AddOwnedConnector(MultipleDelegation_MultipleConnector_P_P_Signal_A_r4);
					// Operation A_A
					MultipleDelegation_MultipleConnector_P_P_Signal_A_A_A.SetName("A_A");
					MultipleDelegation_MultipleConnector_P_P_Signal_A_A_A.SetVisibility(VisibilityKind.public_);
						// Parameter result
						MultipleDelegation_MultipleConnector_P_P_Signal_A_A_A_result.SetName("result");
						MultipleDelegation_MultipleConnector_P_P_Signal_A_A_A_result.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_A_A_A_result.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_A);
						MultipleDelegation_MultipleConnector_P_P_Signal_A_A_A_result.SetDirection(ParameterDirectionKind.return_);
					MultipleDelegation_MultipleConnector_P_P_Signal_A_A_A.AddOwnedParameter(MultipleDelegation_MultipleConnector_P_P_Signal_A_A_A_result);
					MultipleDelegation_MultipleConnector_P_P_Signal_A_A_A.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				MultipleDelegation_MultipleConnector_P_P_Signal_A.AddOwnedOperation(MultipleDelegation_MultipleConnector_P_P_Signal_A_A_A);
			MultipleDelegation_MultipleConnector_P_P_Signal.AddPackagedElement(MultipleDelegation_MultipleConnector_P_P_Signal_A);
				// Signal S
				MultipleDelegation_MultipleConnector_P_P_Signal_S.SetName("S");
				MultipleDelegation_MultipleConnector_P_P_Signal_S.SetVisibility(VisibilityKind.public_);
				
					// Property v
					MultipleDelegation_MultipleConnector_P_P_Signal_S_v.SetName("v");
					MultipleDelegation_MultipleConnector_P_P_Signal_S_v.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Signal_S_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
				MultipleDelegation_MultipleConnector_P_P_Signal_S.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_P_Signal_S_v);
					// Property t
					MultipleDelegation_MultipleConnector_P_P_Signal_S_t.SetName("t");
					MultipleDelegation_MultipleConnector_P_P_Signal_S_t.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Signal_S_t.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester);
				MultipleDelegation_MultipleConnector_P_P_Signal_S.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_P_Signal_S_t);
			MultipleDelegation_MultipleConnector_P_P_Signal.AddPackagedElement(MultipleDelegation_MultipleConnector_P_P_Signal_S);
				// Interface I
				MultipleDelegation_MultipleConnector_P_P_Signal_I.SetName("I");
				MultipleDelegation_MultipleConnector_P_P_Signal_I.SetVisibility(VisibilityKind.public_);
					// Reception S
					MultipleDelegation_MultipleConnector_P_P_Signal_I_S.SetName("S");
					MultipleDelegation_MultipleConnector_P_P_Signal_I_S.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_P_Signal_I_S.SetSignal(MultipleDelegation_MultipleConnector_P_P_Signal_S);
				MultipleDelegation_MultipleConnector_P_P_Signal_I.AddOwnedReception(MultipleDelegation_MultipleConnector_P_P_Signal_I_S);
			MultipleDelegation_MultipleConnector_P_P_Signal.AddPackagedElement(MultipleDelegation_MultipleConnector_P_P_Signal_I);
				// Class B
				MultipleDelegation_MultipleConnector_P_P_Signal_B.SetName("B");
				MultipleDelegation_MultipleConnector_P_P_Signal_B.SetVisibility(VisibilityKind.public_);
				
					// Property p
					MultipleDelegation_MultipleConnector_P_P_Signal_B_p.SetName("p");
					MultipleDelegation_MultipleConnector_P_P_Signal_B_p.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Signal_B_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
				MultipleDelegation_MultipleConnector_P_P_Signal_B.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_P_Signal_B_p);
				MultipleDelegation_MultipleConnector_P_P_Signal_B.SetClassifierBehavior(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior);
					// Activity BClassifierBehavior
					MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior.SetName("BClassifierBehavior");
					MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior.SetVisibility(VisibilityKind.public_);
						// AcceptEventAction Accept S
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Accept_S.SetName("Accept S");
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Accept_S.SetVisibility(VisibilityKind.public_);
							// OutputPin s
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_s.SetName("s");
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_s.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_s.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_S);
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Accept_S.AddResult(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_s);
							// Trigger Trigger185
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_Trigger185.SetName("Trigger185");
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_Trigger185.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_Trigger185.SetEvent(MultipleDelegation_MultipleConnector_P_P_Signal_SEvent);
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Accept_S.AddTrigger(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_Trigger185);
					MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Accept_S);
						// AddStructuralFeatureValueAction Set this.p
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p.SetName("Set this.p");
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_P_Signal_B_p);
							// InputPin object
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_object.SetName("object");
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_object.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_B);
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p.SetObject(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_object);
							// InputPin value
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_value.SetName("value");
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_value.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p.SetValue(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_value);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_result.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_B);
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p.SetResult(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_result);
					MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p);
						// SendSignalAction Send Continue
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue.SetName("Send Continue");
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue.SetSignal(MultipleDelegation_MultipleConnector_P_P_Signal_Continue);
							// InputPin target
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue_target.SetName("target");
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue_target.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue_target.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester);
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue_target);
					MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue);
						// ReadStructuralFeatureAction Read s.v
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v.SetName("Read s.v");
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_P_Signal_S_v);
							// InputPin object
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_object.SetName("object");
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_object.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v.SetObject(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_object);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v.SetResult(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_result);
					MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v);
						// ReadStructuralFeatureAction Read s.t
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t.SetName("Read s.t");
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_P_Signal_S_t);
							// InputPin object
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_object.SetName("object");
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_object.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t.SetObject(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_object);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_result.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester);
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t.SetResult(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_result);
					MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t);
						// ReadSelfAction this
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_this.SetName("this");
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_this_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_this_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_this_result.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_B);
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_this.SetResult(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_this_result);
					MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_this);
						// ForkNode Fork s
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Fork_s.SetName("Fork s");
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Fork_s.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Fork_s);
						// ObjectFlow ObjectFlow175 from result to target
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow175.SetName("ObjectFlow175");
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow175.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow175.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_result);
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow175.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue_target);
							// LiteralBoolean LiteralBoolean176
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow175_LiteralBoolean176.SetName("LiteralBoolean176");
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow175_LiteralBoolean176.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow175_LiteralBoolean176.SetValue(true);
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow175.SetGuard(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow175_LiteralBoolean176);
					MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow175);
						// ObjectFlow ObjectFlow197 from Fork s to object
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow197.SetName("ObjectFlow197");
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow197.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow197.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Fork_s);
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow197.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_object);
							// LiteralBoolean LiteralBoolean198
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow197_LiteralBoolean198.SetName("LiteralBoolean198");
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow197_LiteralBoolean198.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow197_LiteralBoolean198.SetValue(true);
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow197.SetGuard(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow197_LiteralBoolean198);
					MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow197);
						// ObjectFlow ObjectFlow178 from result to value
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow178.SetName("ObjectFlow178");
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow178.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow178.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_result);
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow178.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_value);
							// LiteralBoolean LiteralBoolean179
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow178_LiteralBoolean179.SetName("LiteralBoolean179");
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow178_LiteralBoolean179.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow178_LiteralBoolean179.SetValue(true);
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow178.SetGuard(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow178_LiteralBoolean179);
					MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow178);
						// ObjectFlow ObjectFlow200 from result to object
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow200.SetName("ObjectFlow200");
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow200.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow200.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_this_result);
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow200.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_object);
							// LiteralBoolean LiteralBoolean201
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow200_LiteralBoolean201.SetName("LiteralBoolean201");
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow200_LiteralBoolean201.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow200_LiteralBoolean201.SetValue(true);
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow200.SetGuard(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow200_LiteralBoolean201);
					MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow200);
						// ControlFlow ControlFlow181 from Set this.p to Send Continue
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ControlFlow181.SetName("ControlFlow181");
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ControlFlow181.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ControlFlow181.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p);
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ControlFlow181.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue);
					MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ControlFlow181);
						// ObjectFlow ObjectFlow182 from s to Fork s
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow182.SetName("ObjectFlow182");
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow182.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow182.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_s);
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow182.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Fork_s);
							// LiteralBoolean LiteralBoolean184
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow182_LiteralBoolean184.SetName("LiteralBoolean184");
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow182_LiteralBoolean184.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow182_LiteralBoolean184.SetValue(true);
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow182.SetGuard(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow182_LiteralBoolean184);
					MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow182);
						// ObjectFlow ObjectFlow213 from Fork s to object
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow213.SetName("ObjectFlow213");
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow213.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow213.SetSource(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Fork_s);
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow213.SetTarget(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_object);
							// LiteralBoolean LiteralBoolean214
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow213_LiteralBoolean214.SetName("LiteralBoolean214");
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow213_LiteralBoolean214.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow213_LiteralBoolean214.SetValue(true);
						MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow213.SetGuard(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow213_LiteralBoolean214);
					MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow213);
				MultipleDelegation_MultipleConnector_P_P_Signal_B.AddOwnedBehavior(MultipleDelegation_MultipleConnector_P_P_Signal_B_BClassifierBehavior);
					MultipleDelegation_MultipleConnector_P_P_Signal_B_IRealization.SetName("IRealization");
					MultipleDelegation_MultipleConnector_P_P_Signal_B_IRealization.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_P_Signal_B_IRealization.SetContract(MultipleDelegation_MultipleConnector_P_P_Signal_I);
					
				MultipleDelegation_MultipleConnector_P_P_Signal_B.AddInterfaceRealization(MultipleDelegation_MultipleConnector_P_P_Signal_B_IRealization);
				
				MultipleDelegation_MultipleConnector_P_P_Signal_B.SetIsActive(true);
					// Operation B_B
					MultipleDelegation_MultipleConnector_P_P_Signal_B_B_B.SetName("B_B");
					MultipleDelegation_MultipleConnector_P_P_Signal_B_B_B.SetVisibility(VisibilityKind.public_);
						// Parameter result
						MultipleDelegation_MultipleConnector_P_P_Signal_B_B_B_result.SetName("result");
						MultipleDelegation_MultipleConnector_P_P_Signal_B_B_B_result.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Signal_B_B_B_result.SetType(MultipleDelegation_MultipleConnector_P_P_Signal_B);
						MultipleDelegation_MultipleConnector_P_P_Signal_B_B_B_result.SetDirection(ParameterDirectionKind.return_);
					MultipleDelegation_MultipleConnector_P_P_Signal_B_B_B.AddOwnedParameter(MultipleDelegation_MultipleConnector_P_P_Signal_B_B_B_result);
					MultipleDelegation_MultipleConnector_P_P_Signal_B_B_B.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				MultipleDelegation_MultipleConnector_P_P_Signal_B.AddOwnedOperation(MultipleDelegation_MultipleConnector_P_P_Signal_B_B_B);
					// Reception S
					MultipleDelegation_MultipleConnector_P_P_Signal_B_S.SetName("S");
					MultipleDelegation_MultipleConnector_P_P_Signal_B_S.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_P_Signal_B_S.SetSignal(MultipleDelegation_MultipleConnector_P_P_Signal_S);
				MultipleDelegation_MultipleConnector_P_P_Signal_B.AddOwnedReception(MultipleDelegation_MultipleConnector_P_P_Signal_B_S);
			MultipleDelegation_MultipleConnector_P_P_Signal.AddPackagedElement(MultipleDelegation_MultipleConnector_P_P_Signal_B);
				// Association R
				MultipleDelegation_MultipleConnector_P_P_Signal_R.SetName("R");
				MultipleDelegation_MultipleConnector_P_P_Signal_R.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_MultipleConnector_P_P_Signal_R.AddOwnedEnd(MultipleDelegation_MultipleConnector_P_P_Signal_R_x);
				MultipleDelegation_MultipleConnector_P_P_Signal_R.AddOwnedEnd(MultipleDelegation_MultipleConnector_P_P_Signal_R_y);
			MultipleDelegation_MultipleConnector_P_P_Signal.AddPackagedElement(MultipleDelegation_MultipleConnector_P_P_Signal_R);
				// Class IImpl
				MultipleDelegation_MultipleConnector_P_P_Signal_IImpl.SetName("IImpl");
				MultipleDelegation_MultipleConnector_P_P_Signal_IImpl.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_MultipleConnector_P_P_Signal_IImpl_IRealization.SetName("IRealization");
					MultipleDelegation_MultipleConnector_P_P_Signal_IImpl_IRealization.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_P_Signal_IImpl_IRealization.SetContract(MultipleDelegation_MultipleConnector_P_P_Signal_I);
					
				MultipleDelegation_MultipleConnector_P_P_Signal_IImpl.AddInterfaceRealization(MultipleDelegation_MultipleConnector_P_P_Signal_IImpl_IRealization);
				
					// Reception S
					MultipleDelegation_MultipleConnector_P_P_Signal_IImpl_S.SetName("S");
					MultipleDelegation_MultipleConnector_P_P_Signal_IImpl_S.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_P_Signal_IImpl_S.SetSignal(MultipleDelegation_MultipleConnector_P_P_Signal_S);
				MultipleDelegation_MultipleConnector_P_P_Signal_IImpl.AddOwnedReception(MultipleDelegation_MultipleConnector_P_P_Signal_IImpl_S);
			MultipleDelegation_MultipleConnector_P_P_Signal.AddPackagedElement(MultipleDelegation_MultipleConnector_P_P_Signal_IImpl);
				// Class AbstractTester
				MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester.SetName("AbstractTester");
				MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester.SetVisibility(VisibilityKind.public_);
				
				MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester.SetIsAbstract(true);
				
				
				MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester.SetIsActive(true);
					// Operation test
					MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester_test.SetName("test");
					MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester_test.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester_test.SetIsAbstract(true);
				MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester.AddOwnedOperation(MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester_test);
					// Reception Start
					MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester_Start.SetName("Start");
					MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester_Start.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester_Start.SetSignal(MultipleDelegation_MultipleConnector_P_P_Signal_Start);
				MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester.AddOwnedReception(MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester_Start);
					// Reception Continue
					MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester_Continue.SetName("Continue");
					MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester_Continue.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester_Continue.SetSignal(MultipleDelegation_MultipleConnector_P_P_Signal_Continue);
				MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester.AddOwnedReception(MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester_Continue);
			MultipleDelegation_MultipleConnector_P_P_Signal.AddPackagedElement(MultipleDelegation_MultipleConnector_P_P_Signal_AbstractTester);
				// Signal Start
				MultipleDelegation_MultipleConnector_P_P_Signal_Start.SetName("Start");
				MultipleDelegation_MultipleConnector_P_P_Signal_Start.SetVisibility(VisibilityKind.public_);
			MultipleDelegation_MultipleConnector_P_P_Signal.AddPackagedElement(MultipleDelegation_MultipleConnector_P_P_Signal_Start);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // MultipleDelegation_MultipleConnector_P_P_SignalModel
}
