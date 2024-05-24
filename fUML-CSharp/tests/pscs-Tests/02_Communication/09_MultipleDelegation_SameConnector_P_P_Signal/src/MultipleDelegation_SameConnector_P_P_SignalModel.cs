/*
 * MultipleDelegation_SameConnector_P_P_SignalModel.cs
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

namespace MultipleDelegation_SameConnector_P_P_Signal
{
	public class MultipleDelegation_SameConnector_P_P_SignalModel : InMemoryModel
	{
		private static MultipleDelegation_SameConnector_P_P_SignalModel? instance;

		/*
		 * Model MultipleDelegation_SameConnector_P_P_Signal
		 */
		public Package MultipleDelegation_SameConnector_P_P_Signal = new();
			public Activity MultipleDelegation_SameConnector_P_P_Signal_main = new();
				public ObjectFlow MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow0 = new();
					public LiteralBoolean MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow0_LiteralBoolean1 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow0_LiteralInteger2 = new();
				public CreateObjectAction MultipleDelegation_SameConnector_P_P_Signal_main_Create_Tester = new();
					public OutputPin MultipleDelegation_SameConnector_P_P_Signal_main_Create_Tester_result = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_main_Create_Tester_result_LiteralUnlimitedNatural3 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_main_Create_Tester_result_LiteralInteger4 = new();
				public ObjectFlow MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow5 = new();
					public LiteralBoolean MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow5_LiteralBoolean6 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow5_LiteralInteger7 = new();
				public StartObjectBehaviorAction MultipleDelegation_SameConnector_P_P_Signal_main_Start_Tester = new();
					public InputPin MultipleDelegation_SameConnector_P_P_Signal_main_Start_Tester_object = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_main_Start_Tester_object_LiteralInteger8 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_main_Start_Tester_object_LiteralUnlimitedNatural9 = new();
				public ObjectFlow MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow10 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow10_LiteralInteger11 = new();
					public LiteralBoolean MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow10_LiteralBoolean12 = new();
				public ObjectFlow MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow13 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow13_LiteralInteger14 = new();
					public LiteralBoolean MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow13_LiteralBoolean15 = new();
				public ControlFlow MultipleDelegation_SameConnector_P_P_Signal_main_ControlFlow16 = new();
				public ForkNode MultipleDelegation_SameConnector_P_P_Signal_main_Fork_Tester = new();
				public CallOperationAction MultipleDelegation_SameConnector_P_P_Signal_main_Tester_ = new();
					public InputPin MultipleDelegation_SameConnector_P_P_Signal_main_Tester__target = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_main_Tester__target_LiteralInteger17 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_main_Tester__target_LiteralUnlimitedNatural18 = new();
					public OutputPin MultipleDelegation_SameConnector_P_P_Signal_main_Tester__result = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_main_Tester__result_LiteralInteger19 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_main_Tester__result_LiteralUnlimitedNatural20 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_main_Tester__result_LiteralInteger21 = new();
				public SendSignalAction MultipleDelegation_SameConnector_P_P_Signal_main_Send_Start = new();
					public InputPin MultipleDelegation_SameConnector_P_P_Signal_main_Send_Start_target = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_main_Send_Start_target_LiteralUnlimitedNatural22 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_main_Send_Start_target_LiteralInteger23 = new();
			public Class_ MultipleDelegation_SameConnector_P_P_Signal_A = new();
				public Port MultipleDelegation_SameConnector_P_P_Signal_A_q = new();
				public Property MultipleDelegation_SameConnector_P_P_Signal_A_b = new();
					public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_A_b_LiteralUnlimitedNatural24 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_A_b_LiteralInteger25 = new();
				public Connector MultipleDelegation_SameConnector_P_P_Signal_A_r = new();
					public ConnectorEnd MultipleDelegation_SameConnector_P_P_Signal_A_r_ConnectorEnd26 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_A_r_ConnectorEnd26_LiteralUnlimitedNatural27 = new();
					public ConnectorEnd MultipleDelegation_SameConnector_P_P_Signal_A_r_ConnectorEnd28 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_A_r_ConnectorEnd28_LiteralUnlimitedNatural29 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_A_r_ConnectorEnd28_LiteralInteger30 = new();
				public Operation MultipleDelegation_SameConnector_P_P_Signal_A_A_A = new();
					public Parameter MultipleDelegation_SameConnector_P_P_Signal_A_A_A_result = new();
			public Class_ MultipleDelegation_SameConnector_P_P_Signal_AbstractTester = new();
				public Reception MultipleDelegation_SameConnector_P_P_Signal_AbstractTester_Start = new();
				public Operation MultipleDelegation_SameConnector_P_P_Signal_AbstractTester_test = new();
				public Reception MultipleDelegation_SameConnector_P_P_Signal_AbstractTester_Continue = new();
			public Signal MultipleDelegation_SameConnector_P_P_Signal_S = new();
				public Property MultipleDelegation_SameConnector_P_P_Signal_S_v = new();
				public Property MultipleDelegation_SameConnector_P_P_Signal_S_t = new();
			public SignalEvent MultipleDelegation_SameConnector_P_P_Signal_StartEvent = new();
			public Interface MultipleDelegation_SameConnector_P_P_Signal_I = new();
				public Reception MultipleDelegation_SameConnector_P_P_Signal_I_S = new();
			public Class_ MultipleDelegation_SameConnector_P_P_Signal_B = new();
				public Activity MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow31 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow31_LiteralBoolean32 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow31_LiteralInteger33 = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow34 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow34_LiteralBoolean35 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow34_LiteralInteger36 = new();
					public ControlFlow MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ControlFlow37 = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow38 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow38_LiteralInteger39 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow38_LiteralBoolean40 = new();
					public AcceptEventAction MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Accept_S = new();
						public Trigger MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_Trigger41 = new();
						public OutputPin MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_s = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_s_LiteralUnlimitedNatural42 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_s_LiteralInteger43 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_s_LiteralInteger44 = new();
					public AddStructuralFeatureValueAction MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p = new();
						public OutputPin MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_result_LiteralUnlimitedNatural45 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_result_LiteralInteger46 = new();
						public InputPin MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_object = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_object_LiteralInteger47 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_object_LiteralUnlimitedNatural48 = new();
						public InputPin MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_value = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_value_LiteralInteger49 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_value_LiteralUnlimitedNatural50 = new();
					public SendSignalAction MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue = new();
						public InputPin MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue_target = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue_target_LiteralUnlimitedNatural51 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue_target_LiteralInteger52 = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow53 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow53_LiteralBoolean54 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow53_LiteralInteger55 = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow56 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow56_LiteralBoolean57 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow56_LiteralInteger58 = new();
					public ReadStructuralFeatureAction MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v = new();
						public OutputPin MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_result = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_result_LiteralInteger59 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_result_LiteralUnlimitedNatural60 = new();
						public InputPin MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_object = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_object_LiteralInteger61 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_object_LiteralUnlimitedNatural62 = new();
					public ReadStructuralFeatureAction MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t = new();
						public InputPin MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_object = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_object_LiteralInteger63 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_object_LiteralUnlimitedNatural64 = new();
						public OutputPin MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_result_LiteralUnlimitedNatural65 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_result_LiteralInteger66 = new();
					public ReadSelfAction MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_this = new();
						public OutputPin MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_this_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_this_result_LiteralUnlimitedNatural67 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_this_result_LiteralInteger68 = new();
					public ForkNode MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Fork_s = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow69 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow69_LiteralBoolean70 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow69_LiteralInteger71 = new();
				public InterfaceRealization MultipleDelegation_SameConnector_P_P_Signal_B_IRealization = new();
				public Operation MultipleDelegation_SameConnector_P_P_Signal_B_B_B = new();
					public Parameter MultipleDelegation_SameConnector_P_P_Signal_B_B_B_result = new();
				public Property MultipleDelegation_SameConnector_P_P_Signal_B_p = new();
				public Reception MultipleDelegation_SameConnector_P_P_Signal_B_S = new();
			public Signal MultipleDelegation_SameConnector_P_P_Signal_Start = new();
			public Association MultipleDelegation_SameConnector_P_P_Signal_R = new();
				public Property MultipleDelegation_SameConnector_P_P_Signal_R_x = new();
					public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_R_x_LiteralUnlimitedNatural72 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_R_x_LiteralInteger73 = new();
				public Property MultipleDelegation_SameConnector_P_P_Signal_R_y = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_R_y_LiteralInteger74 = new();
					public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_R_y_LiteralUnlimitedNatural75 = new();
			public SignalEvent MultipleDelegation_SameConnector_P_P_Signal_ContinueEvent = new();
			public Class_ MultipleDelegation_SameConnector_P_P_Signal_IImpl = new();
				public InterfaceRealization MultipleDelegation_SameConnector_P_P_Signal_IImpl_IRealization = new();
				public Reception MultipleDelegation_SameConnector_P_P_Signal_IImpl_S = new();
			public Class_ MultipleDelegation_SameConnector_P_P_Signal_Tester = new();
				public Activity MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity = new();
					public ReadStructuralFeatureAction MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_b_p = new();
						public OutputPin MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_b_p_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_b_p_result_LiteralUnlimitedNatural76 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_b_p_result_LiteralInteger77 = new();
						public InputPin MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_b_p_object = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_b_p_object_LiteralUnlimitedNatural78 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_b_p_object_LiteralInteger79 = new();
					public ReadSelfAction MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_this = new();
						public OutputPin MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_this_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_this_result_LiteralUnlimitedNatural80 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_this_result_LiteralInteger81 = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow82 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow82_LiteralBoolean83 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow82_LiteralInteger84 = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow85 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow85_LiteralBoolean86 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow85_LiteralInteger87 = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow88 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow88_LiteralInteger89 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow88_LiteralBoolean90 = new();
					public CallBehaviorAction MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Call_testP = new();
						public InputPin MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Call_testP_p = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Call_testP_p_LiteralUnlimitedNatural91 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Call_testP_p_LiteralInteger92 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Call_testP_p_LiteralInteger93 = new();
					public ReadStructuralFeatureAction MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_a_b = new();
						public InputPin MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_a_b_object = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_a_b_object_LiteralInteger94 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_a_b_object_LiteralUnlimitedNatural95 = new();
						public OutputPin MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_a_b_result = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_a_b_result_LiteralInteger96 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_a_b_result_LiteralUnlimitedNatural97 = new();
					public ReadStructuralFeatureAction MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_this_a = new();
						public OutputPin MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_this_a_result = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_this_a_result_LiteralInteger98 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_this_a_result_LiteralUnlimitedNatural99 = new();
						public InputPin MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_this_a_object = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_this_a_object_LiteralUnlimitedNatural100 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_this_a_object_LiteralInteger101 = new();
					public OpaqueBehavior MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_testP = new();
						public Parameter MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_testP_p = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow102 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow102_LiteralBoolean103 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow102_LiteralInteger104 = new();
				public Operation MultipleDelegation_SameConnector_P_P_Signal_Tester_test = new();
				public Property MultipleDelegation_SameConnector_P_P_Signal_Tester_a = new();
				public Operation MultipleDelegation_SameConnector_P_P_Signal_Tester_Tester_Tester = new();
					public Parameter MultipleDelegation_SameConnector_P_P_Signal_Tester_Tester_Tester_result = new();
				public Activity MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior = new();
					public ReadStructuralFeatureAction MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a = new();
						public InputPin MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object_LiteralUnlimitedNatural105 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object_LiteralInteger106 = new();
						public OutputPin MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result_LiteralUnlimitedNatural107 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result_LiteralInteger108 = new();
					public CallOperationAction MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test_ = new();
						public InputPin MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target_LiteralUnlimitedNatural109 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target_LiteralInteger110 = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow111 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow111_LiteralInteger112 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow111_LiteralBoolean113 = new();
					public ControlFlow MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow114 = new();
					public ReadSelfAction MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_this = new();
						public OutputPin MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_this_result = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_this_result_LiteralInteger115 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_this_result_LiteralUnlimitedNatural116 = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow117 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow117_LiteralInteger118 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow117_LiteralBoolean119 = new();
					public SendSignalAction MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S = new();
						public InputPin MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_t = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_t_LiteralInteger120 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_t_LiteralUnlimitedNatural121 = new();
						public InputPin MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_target = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_target_LiteralUnlimitedNatural122 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_target_LiteralInteger123 = new();
						public InputPin MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_v = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_v_LiteralUnlimitedNatural124 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_v_LiteralInteger125 = new();
					public AcceptEventAction MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1 = new();
						public Trigger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_Trigger126 = new();
						public OutputPin MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result_LiteralInteger127 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result_LiteralInteger128 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result_LiteralUnlimitedNatural129 = new();
					public ReadStructuralFeatureAction MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q = new();
						public OutputPin MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result_LiteralUnlimitedNatural130 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result_LiteralInteger131 = new();
						public InputPin MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object_LiteralInteger132 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object_LiteralUnlimitedNatural133 = new();
					public ControlFlow MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow134 = new();
					public AcceptEventAction MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3 = new();
						public OutputPin MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result_LiteralInteger135 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result_LiteralUnlimitedNatural136 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result_LiteralInteger137 = new();
						public Trigger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_Trigger138 = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow139 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow139_LiteralBoolean140 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow139_LiteralInteger141 = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow142 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow142_LiteralInteger143 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow142_LiteralBoolean144 = new();
					public ControlFlow MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow145 = new();
					public ForkNode MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Fork_this = new();
					public AcceptEventAction MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4 = new();
						public Trigger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_Trigger146 = new();
						public OutputPin MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result_LiteralUnlimitedNatural147 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result_LiteralInteger148 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result_LiteralInteger149 = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow150 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow150_LiteralBoolean151 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow150_LiteralInteger152 = new();
					public ValueSpecificationAction MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_LiteralInteger153 = new();
						public OutputPin MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_result = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_result_LiteralInteger154 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_result_LiteralUnlimitedNatural155 = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow156 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow156_LiteralBoolean157 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow156_LiteralInteger158 = new();
					public ControlFlow MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow159 = new();
					public AcceptEventAction MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start = new();
						public OutputPin MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralInteger160 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralInteger161 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralUnlimitedNatural162 = new();
						public Trigger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger163 = new();
					public ControlFlow MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow164 = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow165 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow165_LiteralInteger166 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow165_LiteralBoolean167 = new();
					public ControlFlow MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow168 = new();
					public AcceptEventAction MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2 = new();
						public Trigger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_Trigger169 = new();
						public OutputPin MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result_LiteralUnlimitedNatural170 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result_LiteralInteger171 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result_LiteralInteger172 = new();
				public Generalization MultipleDelegation_SameConnector_P_P_Signal_Tester_Generalization173 = new();
			public SignalEvent MultipleDelegation_SameConnector_P_P_Signal_SEvent = new();
			public Signal MultipleDelegation_SameConnector_P_P_Signal_Continue = new();

		public static MultipleDelegation_SameConnector_P_P_SignalModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public MultipleDelegation_SameConnector_P_P_SignalModel()
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
			 * Model MultipleDelegation_SameConnector_P_P_Signal
			 */
			AddToElementRepository("MultipleDelegation_SameConnector_P_P_Signal", MultipleDelegation_SameConnector_P_P_Signal);
				AddToElementRepository("main", MultipleDelegation_SameConnector_P_P_Signal_main);
					AddToElementRepository("ObjectFlow0", MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow0);
						AddToElementRepository("LiteralBoolean1", MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow0_LiteralBoolean1);
						AddToElementRepository("LiteralInteger2", MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow0_LiteralInteger2);
					AddToElementRepository("Create Tester", MultipleDelegation_SameConnector_P_P_Signal_main_Create_Tester);
						AddToElementRepository("result", MultipleDelegation_SameConnector_P_P_Signal_main_Create_Tester_result);
							AddToElementRepository("LiteralUnlimitedNatural3", MultipleDelegation_SameConnector_P_P_Signal_main_Create_Tester_result_LiteralUnlimitedNatural3);
							AddToElementRepository("LiteralInteger4", MultipleDelegation_SameConnector_P_P_Signal_main_Create_Tester_result_LiteralInteger4);
					AddToElementRepository("ObjectFlow5", MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow5);
						AddToElementRepository("LiteralBoolean6", MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow5_LiteralBoolean6);
						AddToElementRepository("LiteralInteger7", MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow5_LiteralInteger7);
					AddToElementRepository("Start Tester", MultipleDelegation_SameConnector_P_P_Signal_main_Start_Tester);
						AddToElementRepository("object", MultipleDelegation_SameConnector_P_P_Signal_main_Start_Tester_object);
							AddToElementRepository("LiteralInteger8", MultipleDelegation_SameConnector_P_P_Signal_main_Start_Tester_object_LiteralInteger8);
							AddToElementRepository("LiteralUnlimitedNatural9", MultipleDelegation_SameConnector_P_P_Signal_main_Start_Tester_object_LiteralUnlimitedNatural9);
					AddToElementRepository("ObjectFlow10", MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow10);
						AddToElementRepository("LiteralInteger11", MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow10_LiteralInteger11);
						AddToElementRepository("LiteralBoolean12", MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow10_LiteralBoolean12);
					AddToElementRepository("ObjectFlow13", MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow13);
						AddToElementRepository("LiteralInteger14", MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow13_LiteralInteger14);
						AddToElementRepository("LiteralBoolean15", MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow13_LiteralBoolean15);
					AddToElementRepository("ControlFlow16", MultipleDelegation_SameConnector_P_P_Signal_main_ControlFlow16);
					AddToElementRepository("Fork Tester", MultipleDelegation_SameConnector_P_P_Signal_main_Fork_Tester);
					AddToElementRepository("Tester()", MultipleDelegation_SameConnector_P_P_Signal_main_Tester_);
						AddToElementRepository("target", MultipleDelegation_SameConnector_P_P_Signal_main_Tester__target);
							AddToElementRepository("LiteralInteger17", MultipleDelegation_SameConnector_P_P_Signal_main_Tester__target_LiteralInteger17);
							AddToElementRepository("LiteralUnlimitedNatural18", MultipleDelegation_SameConnector_P_P_Signal_main_Tester__target_LiteralUnlimitedNatural18);
						AddToElementRepository("result", MultipleDelegation_SameConnector_P_P_Signal_main_Tester__result);
							AddToElementRepository("LiteralInteger19", MultipleDelegation_SameConnector_P_P_Signal_main_Tester__result_LiteralInteger19);
							AddToElementRepository("LiteralUnlimitedNatural20", MultipleDelegation_SameConnector_P_P_Signal_main_Tester__result_LiteralUnlimitedNatural20);
							AddToElementRepository("LiteralInteger21", MultipleDelegation_SameConnector_P_P_Signal_main_Tester__result_LiteralInteger21);
					AddToElementRepository("Send Start", MultipleDelegation_SameConnector_P_P_Signal_main_Send_Start);
						AddToElementRepository("target", MultipleDelegation_SameConnector_P_P_Signal_main_Send_Start_target);
							AddToElementRepository("LiteralUnlimitedNatural22", MultipleDelegation_SameConnector_P_P_Signal_main_Send_Start_target_LiteralUnlimitedNatural22);
							AddToElementRepository("LiteralInteger23", MultipleDelegation_SameConnector_P_P_Signal_main_Send_Start_target_LiteralInteger23);
				AddToElementRepository("A", MultipleDelegation_SameConnector_P_P_Signal_A);
					AddToElementRepository("q", MultipleDelegation_SameConnector_P_P_Signal_A_q);
					AddToElementRepository("b", MultipleDelegation_SameConnector_P_P_Signal_A_b);
						AddToElementRepository("LiteralUnlimitedNatural24", MultipleDelegation_SameConnector_P_P_Signal_A_b_LiteralUnlimitedNatural24);
						AddToElementRepository("LiteralInteger25", MultipleDelegation_SameConnector_P_P_Signal_A_b_LiteralInteger25);
					AddToElementRepository("r", MultipleDelegation_SameConnector_P_P_Signal_A_r);
						AddToElementRepository("ConnectorEnd26", MultipleDelegation_SameConnector_P_P_Signal_A_r_ConnectorEnd26);
							AddToElementRepository("LiteralUnlimitedNatural27", MultipleDelegation_SameConnector_P_P_Signal_A_r_ConnectorEnd26_LiteralUnlimitedNatural27);
						AddToElementRepository("ConnectorEnd28", MultipleDelegation_SameConnector_P_P_Signal_A_r_ConnectorEnd28);
							AddToElementRepository("LiteralUnlimitedNatural29", MultipleDelegation_SameConnector_P_P_Signal_A_r_ConnectorEnd28_LiteralUnlimitedNatural29);
							AddToElementRepository("LiteralInteger30", MultipleDelegation_SameConnector_P_P_Signal_A_r_ConnectorEnd28_LiteralInteger30);
					AddToElementRepository("A_A", MultipleDelegation_SameConnector_P_P_Signal_A_A_A);
						AddToElementRepository("result", MultipleDelegation_SameConnector_P_P_Signal_A_A_A_result);
				AddToElementRepository("AbstractTester", MultipleDelegation_SameConnector_P_P_Signal_AbstractTester);
					AddToElementRepository("Start", MultipleDelegation_SameConnector_P_P_Signal_AbstractTester_Start);
					AddToElementRepository("test", MultipleDelegation_SameConnector_P_P_Signal_AbstractTester_test);
					AddToElementRepository("Continue", MultipleDelegation_SameConnector_P_P_Signal_AbstractTester_Continue);
				AddToElementRepository("S", MultipleDelegation_SameConnector_P_P_Signal_S);
					AddToElementRepository("v", MultipleDelegation_SameConnector_P_P_Signal_S_v);
					AddToElementRepository("t", MultipleDelegation_SameConnector_P_P_Signal_S_t);
				AddToElementRepository("StartEvent", MultipleDelegation_SameConnector_P_P_Signal_StartEvent);
				AddToElementRepository("I", MultipleDelegation_SameConnector_P_P_Signal_I);
					AddToElementRepository("S", MultipleDelegation_SameConnector_P_P_Signal_I_S);
				AddToElementRepository("B", MultipleDelegation_SameConnector_P_P_Signal_B);
					AddToElementRepository("BClassifierBehavior", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior);
						AddToElementRepository("ObjectFlow31", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow31);
							AddToElementRepository("LiteralBoolean32", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow31_LiteralBoolean32);
							AddToElementRepository("LiteralInteger33", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow31_LiteralInteger33);
						AddToElementRepository("ObjectFlow34", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow34);
							AddToElementRepository("LiteralBoolean35", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow34_LiteralBoolean35);
							AddToElementRepository("LiteralInteger36", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow34_LiteralInteger36);
						AddToElementRepository("ControlFlow37", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ControlFlow37);
						AddToElementRepository("ObjectFlow38", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow38);
							AddToElementRepository("LiteralInteger39", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow38_LiteralInteger39);
							AddToElementRepository("LiteralBoolean40", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow38_LiteralBoolean40);
						AddToElementRepository("Accept S", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Accept_S);
							AddToElementRepository("Trigger41", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_Trigger41);
							AddToElementRepository("s", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_s);
								AddToElementRepository("LiteralUnlimitedNatural42", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_s_LiteralUnlimitedNatural42);
								AddToElementRepository("LiteralInteger43", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_s_LiteralInteger43);
								AddToElementRepository("LiteralInteger44", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_s_LiteralInteger44);
						AddToElementRepository("Set this.p", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_result);
								AddToElementRepository("LiteralUnlimitedNatural45", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_result_LiteralUnlimitedNatural45);
								AddToElementRepository("LiteralInteger46", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_result_LiteralInteger46);
							AddToElementRepository("object", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_object);
								AddToElementRepository("LiteralInteger47", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_object_LiteralInteger47);
								AddToElementRepository("LiteralUnlimitedNatural48", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_object_LiteralUnlimitedNatural48);
							AddToElementRepository("value", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_value);
								AddToElementRepository("LiteralInteger49", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_value_LiteralInteger49);
								AddToElementRepository("LiteralUnlimitedNatural50", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_value_LiteralUnlimitedNatural50);
						AddToElementRepository("Send Continue", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue);
							AddToElementRepository("target", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue_target);
								AddToElementRepository("LiteralUnlimitedNatural51", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue_target_LiteralUnlimitedNatural51);
								AddToElementRepository("LiteralInteger52", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue_target_LiteralInteger52);
						AddToElementRepository("ObjectFlow53", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow53);
							AddToElementRepository("LiteralBoolean54", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow53_LiteralBoolean54);
							AddToElementRepository("LiteralInteger55", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow53_LiteralInteger55);
						AddToElementRepository("ObjectFlow56", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow56);
							AddToElementRepository("LiteralBoolean57", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow56_LiteralBoolean57);
							AddToElementRepository("LiteralInteger58", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow56_LiteralInteger58);
						AddToElementRepository("Read s.v", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_result);
								AddToElementRepository("LiteralInteger59", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_result_LiteralInteger59);
								AddToElementRepository("LiteralUnlimitedNatural60", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_result_LiteralUnlimitedNatural60);
							AddToElementRepository("object", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_object);
								AddToElementRepository("LiteralInteger61", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_object_LiteralInteger61);
								AddToElementRepository("LiteralUnlimitedNatural62", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_object_LiteralUnlimitedNatural62);
						AddToElementRepository("Read s.t", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t);
							AddToElementRepository("object", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_object);
								AddToElementRepository("LiteralInteger63", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_object_LiteralInteger63);
								AddToElementRepository("LiteralUnlimitedNatural64", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_object_LiteralUnlimitedNatural64);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_result);
								AddToElementRepository("LiteralUnlimitedNatural65", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_result_LiteralUnlimitedNatural65);
								AddToElementRepository("LiteralInteger66", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_result_LiteralInteger66);
						AddToElementRepository("this", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_this);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_this_result);
								AddToElementRepository("LiteralUnlimitedNatural67", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_this_result_LiteralUnlimitedNatural67);
								AddToElementRepository("LiteralInteger68", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_this_result_LiteralInteger68);
						AddToElementRepository("Fork s", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Fork_s);
						AddToElementRepository("ObjectFlow69", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow69);
							AddToElementRepository("LiteralBoolean70", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow69_LiteralBoolean70);
							AddToElementRepository("LiteralInteger71", MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow69_LiteralInteger71);
					AddToElementRepository("IRealization", MultipleDelegation_SameConnector_P_P_Signal_B_IRealization);
					AddToElementRepository("B_B", MultipleDelegation_SameConnector_P_P_Signal_B_B_B);
						AddToElementRepository("result", MultipleDelegation_SameConnector_P_P_Signal_B_B_B_result);
					AddToElementRepository("p", MultipleDelegation_SameConnector_P_P_Signal_B_p);
					AddToElementRepository("S", MultipleDelegation_SameConnector_P_P_Signal_B_S);
				AddToElementRepository("Start", MultipleDelegation_SameConnector_P_P_Signal_Start);
				AddToElementRepository("R", MultipleDelegation_SameConnector_P_P_Signal_R);
					AddToElementRepository("x", MultipleDelegation_SameConnector_P_P_Signal_R_x);
						AddToElementRepository("LiteralUnlimitedNatural72", MultipleDelegation_SameConnector_P_P_Signal_R_x_LiteralUnlimitedNatural72);
						AddToElementRepository("LiteralInteger73", MultipleDelegation_SameConnector_P_P_Signal_R_x_LiteralInteger73);
					AddToElementRepository("y", MultipleDelegation_SameConnector_P_P_Signal_R_y);
						AddToElementRepository("LiteralInteger74", MultipleDelegation_SameConnector_P_P_Signal_R_y_LiteralInteger74);
						AddToElementRepository("LiteralUnlimitedNatural75", MultipleDelegation_SameConnector_P_P_Signal_R_y_LiteralUnlimitedNatural75);
				AddToElementRepository("ContinueEvent", MultipleDelegation_SameConnector_P_P_Signal_ContinueEvent);
				AddToElementRepository("IImpl", MultipleDelegation_SameConnector_P_P_Signal_IImpl);
					AddToElementRepository("IRealization", MultipleDelegation_SameConnector_P_P_Signal_IImpl_IRealization);
					AddToElementRepository("S", MultipleDelegation_SameConnector_P_P_Signal_IImpl_S);
				AddToElementRepository("Tester", MultipleDelegation_SameConnector_P_P_Signal_Tester);
					AddToElementRepository("testActivity", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity);
						AddToElementRepository("Read b.p", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_b_p);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_b_p_result);
								AddToElementRepository("LiteralUnlimitedNatural76", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_b_p_result_LiteralUnlimitedNatural76);
								AddToElementRepository("LiteralInteger77", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_b_p_result_LiteralInteger77);
							AddToElementRepository("object", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_b_p_object);
								AddToElementRepository("LiteralUnlimitedNatural78", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_b_p_object_LiteralUnlimitedNatural78);
								AddToElementRepository("LiteralInteger79", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_b_p_object_LiteralInteger79);
						AddToElementRepository("this", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_this);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_this_result);
								AddToElementRepository("LiteralUnlimitedNatural80", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_this_result_LiteralUnlimitedNatural80);
								AddToElementRepository("LiteralInteger81", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_this_result_LiteralInteger81);
						AddToElementRepository("ObjectFlow82", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow82);
							AddToElementRepository("LiteralBoolean83", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow82_LiteralBoolean83);
							AddToElementRepository("LiteralInteger84", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow82_LiteralInteger84);
						AddToElementRepository("ObjectFlow85", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow85);
							AddToElementRepository("LiteralBoolean86", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow85_LiteralBoolean86);
							AddToElementRepository("LiteralInteger87", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow85_LiteralInteger87);
						AddToElementRepository("ObjectFlow88", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow88);
							AddToElementRepository("LiteralInteger89", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow88_LiteralInteger89);
							AddToElementRepository("LiteralBoolean90", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow88_LiteralBoolean90);
						AddToElementRepository("Call testP", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Call_testP);
							AddToElementRepository("p", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Call_testP_p);
								AddToElementRepository("LiteralUnlimitedNatural91", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Call_testP_p_LiteralUnlimitedNatural91);
								AddToElementRepository("LiteralInteger92", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Call_testP_p_LiteralInteger92);
								AddToElementRepository("LiteralInteger93", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Call_testP_p_LiteralInteger93);
						AddToElementRepository("Read a.b", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_a_b);
							AddToElementRepository("object", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_a_b_object);
								AddToElementRepository("LiteralInteger94", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_a_b_object_LiteralInteger94);
								AddToElementRepository("LiteralUnlimitedNatural95", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_a_b_object_LiteralUnlimitedNatural95);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_a_b_result);
								AddToElementRepository("LiteralInteger96", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_a_b_result_LiteralInteger96);
								AddToElementRepository("LiteralUnlimitedNatural97", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_a_b_result_LiteralUnlimitedNatural97);
						AddToElementRepository("Read this.a", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_this_a);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_this_a_result);
								AddToElementRepository("LiteralInteger98", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_this_a_result_LiteralInteger98);
								AddToElementRepository("LiteralUnlimitedNatural99", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_this_a_result_LiteralUnlimitedNatural99);
							AddToElementRepository("object", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_this_a_object);
								AddToElementRepository("LiteralUnlimitedNatural100", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_this_a_object_LiteralUnlimitedNatural100);
								AddToElementRepository("LiteralInteger101", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_this_a_object_LiteralInteger101);
						AddToElementRepository("testP", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_testP);
							AddToElementRepository("p", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_testP_p);
						AddToElementRepository("ObjectFlow102", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow102);
							AddToElementRepository("LiteralBoolean103", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow102_LiteralBoolean103);
							AddToElementRepository("LiteralInteger104", MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow102_LiteralInteger104);
					AddToElementRepository("test", MultipleDelegation_SameConnector_P_P_Signal_Tester_test);
					AddToElementRepository("a", MultipleDelegation_SameConnector_P_P_Signal_Tester_a);
					AddToElementRepository("Tester_Tester", MultipleDelegation_SameConnector_P_P_Signal_Tester_Tester_Tester);
						AddToElementRepository("result", MultipleDelegation_SameConnector_P_P_Signal_Tester_Tester_Tester_result);
					AddToElementRepository("TesterClassifierBehavior", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior);
						AddToElementRepository("Read this.a", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a);
							AddToElementRepository("object", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object);
								AddToElementRepository("LiteralUnlimitedNatural105", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object_LiteralUnlimitedNatural105);
								AddToElementRepository("LiteralInteger106", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object_LiteralInteger106);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result);
								AddToElementRepository("LiteralUnlimitedNatural107", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result_LiteralUnlimitedNatural107);
								AddToElementRepository("LiteralInteger108", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result_LiteralInteger108);
						AddToElementRepository("Call test()", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test_);
							AddToElementRepository("target", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target);
								AddToElementRepository("LiteralUnlimitedNatural109", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target_LiteralUnlimitedNatural109);
								AddToElementRepository("LiteralInteger110", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target_LiteralInteger110);
						AddToElementRepository("ObjectFlow111", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow111);
							AddToElementRepository("LiteralInteger112", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow111_LiteralInteger112);
							AddToElementRepository("LiteralBoolean113", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow111_LiteralBoolean113);
						AddToElementRepository("ControlFlow114", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow114);
						AddToElementRepository("this", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_this);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_this_result);
								AddToElementRepository("LiteralInteger115", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_this_result_LiteralInteger115);
								AddToElementRepository("LiteralUnlimitedNatural116", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_this_result_LiteralUnlimitedNatural116);
						AddToElementRepository("ObjectFlow117", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow117);
							AddToElementRepository("LiteralInteger118", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow117_LiteralInteger118);
							AddToElementRepository("LiteralBoolean119", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow117_LiteralBoolean119);
						AddToElementRepository("Send S", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S);
							AddToElementRepository("t", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_t);
								AddToElementRepository("LiteralInteger120", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_t_LiteralInteger120);
								AddToElementRepository("LiteralUnlimitedNatural121", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_t_LiteralUnlimitedNatural121);
							AddToElementRepository("target", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_target);
								AddToElementRepository("LiteralUnlimitedNatural122", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_target_LiteralUnlimitedNatural122);
								AddToElementRepository("LiteralInteger123", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_target_LiteralInteger123);
							AddToElementRepository("v", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_v);
								AddToElementRepository("LiteralUnlimitedNatural124", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_v_LiteralUnlimitedNatural124);
								AddToElementRepository("LiteralInteger125", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_v_LiteralInteger125);
						AddToElementRepository("Accept Continue_1", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1);
							AddToElementRepository("Trigger126", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_Trigger126);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result);
								AddToElementRepository("LiteralInteger127", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result_LiteralInteger127);
								AddToElementRepository("LiteralInteger128", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result_LiteralInteger128);
								AddToElementRepository("LiteralUnlimitedNatural129", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result_LiteralUnlimitedNatural129);
						AddToElementRepository("Read a.q", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result);
								AddToElementRepository("LiteralUnlimitedNatural130", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result_LiteralUnlimitedNatural130);
								AddToElementRepository("LiteralInteger131", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result_LiteralInteger131);
							AddToElementRepository("object", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object);
								AddToElementRepository("LiteralInteger132", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object_LiteralInteger132);
								AddToElementRepository("LiteralUnlimitedNatural133", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object_LiteralUnlimitedNatural133);
						AddToElementRepository("ControlFlow134", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow134);
						AddToElementRepository("Accept Continue_3", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result);
								AddToElementRepository("LiteralInteger135", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result_LiteralInteger135);
								AddToElementRepository("LiteralUnlimitedNatural136", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result_LiteralUnlimitedNatural136);
								AddToElementRepository("LiteralInteger137", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result_LiteralInteger137);
							AddToElementRepository("Trigger138", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_Trigger138);
						AddToElementRepository("ObjectFlow139", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow139);
							AddToElementRepository("LiteralBoolean140", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow139_LiteralBoolean140);
							AddToElementRepository("LiteralInteger141", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow139_LiteralInteger141);
						AddToElementRepository("ObjectFlow142", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow142);
							AddToElementRepository("LiteralInteger143", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow142_LiteralInteger143);
							AddToElementRepository("LiteralBoolean144", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow142_LiteralBoolean144);
						AddToElementRepository("ControlFlow145", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow145);
						AddToElementRepository("Fork this", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Fork_this);
						AddToElementRepository("Accept Continue_4", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4);
							AddToElementRepository("Trigger146", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_Trigger146);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result);
								AddToElementRepository("LiteralUnlimitedNatural147", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result_LiteralUnlimitedNatural147);
								AddToElementRepository("LiteralInteger148", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result_LiteralInteger148);
								AddToElementRepository("LiteralInteger149", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result_LiteralInteger149);
						AddToElementRepository("ObjectFlow150", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow150);
							AddToElementRepository("LiteralBoolean151", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow150_LiteralBoolean151);
							AddToElementRepository("LiteralInteger152", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow150_LiteralInteger152);
						AddToElementRepository("Value(4)", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4);
							AddToElementRepository("LiteralInteger153", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_LiteralInteger153);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_result);
								AddToElementRepository("LiteralInteger154", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_result_LiteralInteger154);
								AddToElementRepository("LiteralUnlimitedNatural155", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_result_LiteralUnlimitedNatural155);
						AddToElementRepository("ObjectFlow156", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow156);
							AddToElementRepository("LiteralBoolean157", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow156_LiteralBoolean157);
							AddToElementRepository("LiteralInteger158", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow156_LiteralInteger158);
						AddToElementRepository("ControlFlow159", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow159);
						AddToElementRepository("Accept Start", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result);
								AddToElementRepository("LiteralInteger160", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralInteger160);
								AddToElementRepository("LiteralInteger161", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralInteger161);
								AddToElementRepository("LiteralUnlimitedNatural162", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralUnlimitedNatural162);
							AddToElementRepository("Trigger163", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger163);
						AddToElementRepository("ControlFlow164", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow164);
						AddToElementRepository("ObjectFlow165", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow165);
							AddToElementRepository("LiteralInteger166", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow165_LiteralInteger166);
							AddToElementRepository("LiteralBoolean167", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow165_LiteralBoolean167);
						AddToElementRepository("ControlFlow168", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow168);
						AddToElementRepository("Accept Continue_2", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2);
							AddToElementRepository("Trigger169", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_Trigger169);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result);
								AddToElementRepository("LiteralUnlimitedNatural170", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result_LiteralUnlimitedNatural170);
								AddToElementRepository("LiteralInteger171", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result_LiteralInteger171);
								AddToElementRepository("LiteralInteger172", MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result_LiteralInteger172);
					AddToElementRepository("Generalization173", MultipleDelegation_SameConnector_P_P_Signal_Tester_Generalization173);
				AddToElementRepository("SEvent", MultipleDelegation_SameConnector_P_P_Signal_SEvent);
				AddToElementRepository("Continue", MultipleDelegation_SameConnector_P_P_Signal_Continue);

			// Initialize public members
			/*
			 * Model MultipleDelegation_SameConnector_P_P_Signal
			 */
			MultipleDelegation_SameConnector_P_P_Signal.SetName("MultipleDelegation_SameConnector_P_P_Signal");
			MultipleDelegation_SameConnector_P_P_Signal.SetVisibility(VisibilityKind.public_);
				// Activity main
				MultipleDelegation_SameConnector_P_P_Signal_main.SetName("main");
				MultipleDelegation_SameConnector_P_P_Signal_main.SetVisibility(VisibilityKind.public_);
					// CreateObjectAction Create Tester
					MultipleDelegation_SameConnector_P_P_Signal_main_Create_Tester.SetName("Create Tester");
					MultipleDelegation_SameConnector_P_P_Signal_main_Create_Tester.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_P_Signal_main_Create_Tester.SetClassifier(MultipleDelegation_SameConnector_P_P_Signal_Tester);
						// OutputPin result
						MultipleDelegation_SameConnector_P_P_Signal_main_Create_Tester_result.SetName("result");
						MultipleDelegation_SameConnector_P_P_Signal_main_Create_Tester_result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Signal_main_Create_Tester_result.SetType(MultipleDelegation_SameConnector_P_P_Signal_Tester);
					MultipleDelegation_SameConnector_P_P_Signal_main_Create_Tester.SetResult(MultipleDelegation_SameConnector_P_P_Signal_main_Create_Tester_result);
				MultipleDelegation_SameConnector_P_P_Signal_main.AddNode(MultipleDelegation_SameConnector_P_P_Signal_main_Create_Tester);
					// StartObjectBehaviorAction Start Tester
					MultipleDelegation_SameConnector_P_P_Signal_main_Start_Tester.SetName("Start Tester");
					MultipleDelegation_SameConnector_P_P_Signal_main_Start_Tester.SetVisibility(VisibilityKind.public_);
						// InputPin object
						MultipleDelegation_SameConnector_P_P_Signal_main_Start_Tester_object.SetName("object");
						MultipleDelegation_SameConnector_P_P_Signal_main_Start_Tester_object.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_P_Signal_main_Start_Tester.SetObject(MultipleDelegation_SameConnector_P_P_Signal_main_Start_Tester_object);
				MultipleDelegation_SameConnector_P_P_Signal_main.AddNode(MultipleDelegation_SameConnector_P_P_Signal_main_Start_Tester);
					// ForkNode Fork Tester
					MultipleDelegation_SameConnector_P_P_Signal_main_Fork_Tester.SetName("Fork Tester");
					MultipleDelegation_SameConnector_P_P_Signal_main_Fork_Tester.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_SameConnector_P_P_Signal_main.AddNode(MultipleDelegation_SameConnector_P_P_Signal_main_Fork_Tester);
					// CallOperationAction Tester()
					MultipleDelegation_SameConnector_P_P_Signal_main_Tester_.SetName("Tester()");
					MultipleDelegation_SameConnector_P_P_Signal_main_Tester_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						MultipleDelegation_SameConnector_P_P_Signal_main_Tester__result.SetName("result");
						MultipleDelegation_SameConnector_P_P_Signal_main_Tester__result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Signal_main_Tester__result.SetType(MultipleDelegation_SameConnector_P_P_Signal_Tester);
					MultipleDelegation_SameConnector_P_P_Signal_main_Tester_.AddResult(MultipleDelegation_SameConnector_P_P_Signal_main_Tester__result);
					MultipleDelegation_SameConnector_P_P_Signal_main_Tester_.SetOperation(MultipleDelegation_SameConnector_P_P_Signal_Tester_Tester_Tester);
						// InputPin target
						MultipleDelegation_SameConnector_P_P_Signal_main_Tester__target.SetName("target");
						MultipleDelegation_SameConnector_P_P_Signal_main_Tester__target.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Signal_main_Tester__target.SetType(MultipleDelegation_SameConnector_P_P_Signal_Tester);
					MultipleDelegation_SameConnector_P_P_Signal_main_Tester_.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_main_Tester__target);
				MultipleDelegation_SameConnector_P_P_Signal_main.AddNode(MultipleDelegation_SameConnector_P_P_Signal_main_Tester_);
					// SendSignalAction Send Start
					MultipleDelegation_SameConnector_P_P_Signal_main_Send_Start.SetName("Send Start");
					MultipleDelegation_SameConnector_P_P_Signal_main_Send_Start.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_P_Signal_main_Send_Start.SetSignal(MultipleDelegation_SameConnector_P_P_Signal_Start);
						// InputPin target
						MultipleDelegation_SameConnector_P_P_Signal_main_Send_Start_target.SetName("target");
						MultipleDelegation_SameConnector_P_P_Signal_main_Send_Start_target.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Signal_main_Send_Start_target.SetType(MultipleDelegation_SameConnector_P_P_Signal_Tester);
					MultipleDelegation_SameConnector_P_P_Signal_main_Send_Start.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_main_Send_Start_target);
				MultipleDelegation_SameConnector_P_P_Signal_main.AddNode(MultipleDelegation_SameConnector_P_P_Signal_main_Send_Start);
					// ObjectFlow ObjectFlow0 from result to target
					MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow0.SetName("ObjectFlow0");
					MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow0.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow0.SetSource(MultipleDelegation_SameConnector_P_P_Signal_main_Create_Tester_result);
					MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow0.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_main_Tester__target);
						// LiteralBoolean LiteralBoolean1
						MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow0_LiteralBoolean1.SetName("LiteralBoolean1");
						MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow0_LiteralBoolean1.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow0_LiteralBoolean1.SetValue(true);
					MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow0.SetGuard(MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow0_LiteralBoolean1);
				MultipleDelegation_SameConnector_P_P_Signal_main.AddEdge(MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow0);
					// ObjectFlow ObjectFlow5 from result to Fork Tester
					MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow5.SetName("ObjectFlow5");
					MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow5.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow5.SetSource(MultipleDelegation_SameConnector_P_P_Signal_main_Tester__result);
					MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow5.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_main_Fork_Tester);
						// LiteralBoolean LiteralBoolean6
						MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow5_LiteralBoolean6.SetName("LiteralBoolean6");
						MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow5_LiteralBoolean6.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow5_LiteralBoolean6.SetValue(true);
					MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow5.SetGuard(MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow5_LiteralBoolean6);
				MultipleDelegation_SameConnector_P_P_Signal_main.AddEdge(MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow5);
					// ObjectFlow ObjectFlow10 from Fork Tester to object
					MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow10.SetName("ObjectFlow10");
					MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow10.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow10.SetSource(MultipleDelegation_SameConnector_P_P_Signal_main_Fork_Tester);
					MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow10.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_main_Start_Tester_object);
						// LiteralBoolean LiteralBoolean12
						MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow10_LiteralBoolean12.SetName("LiteralBoolean12");
						MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow10_LiteralBoolean12.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow10_LiteralBoolean12.SetValue(true);
					MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow10.SetGuard(MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow10_LiteralBoolean12);
				MultipleDelegation_SameConnector_P_P_Signal_main.AddEdge(MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow10);
					// ObjectFlow ObjectFlow13 from Fork Tester to target
					MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow13.SetName("ObjectFlow13");
					MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow13.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow13.SetSource(MultipleDelegation_SameConnector_P_P_Signal_main_Fork_Tester);
					MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow13.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_main_Send_Start_target);
						// LiteralBoolean LiteralBoolean15
						MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow13_LiteralBoolean15.SetName("LiteralBoolean15");
						MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow13_LiteralBoolean15.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow13_LiteralBoolean15.SetValue(true);
					MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow13.SetGuard(MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow13_LiteralBoolean15);
				MultipleDelegation_SameConnector_P_P_Signal_main.AddEdge(MultipleDelegation_SameConnector_P_P_Signal_main_ObjectFlow13);
					// ControlFlow ControlFlow16 from Start Tester to Send Start
					MultipleDelegation_SameConnector_P_P_Signal_main_ControlFlow16.SetName("ControlFlow16");
					MultipleDelegation_SameConnector_P_P_Signal_main_ControlFlow16.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_P_Signal_main_ControlFlow16.SetSource(MultipleDelegation_SameConnector_P_P_Signal_main_Start_Tester);
					MultipleDelegation_SameConnector_P_P_Signal_main_ControlFlow16.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_main_Send_Start);
				MultipleDelegation_SameConnector_P_P_Signal_main.AddEdge(MultipleDelegation_SameConnector_P_P_Signal_main_ControlFlow16);
			MultipleDelegation_SameConnector_P_P_Signal.AddPackagedElement(MultipleDelegation_SameConnector_P_P_Signal_main);
				// Class A
				MultipleDelegation_SameConnector_P_P_Signal_A.SetName("A");
				MultipleDelegation_SameConnector_P_P_Signal_A.SetVisibility(VisibilityKind.public_);
				
					// Port q
					MultipleDelegation_SameConnector_P_P_Signal_A_q.SetName("q");
					MultipleDelegation_SameConnector_P_P_Signal_A_q.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_P_Signal_A_q.SetType(MultipleDelegation_SameConnector_P_P_Signal_IImpl);
					MultipleDelegation_SameConnector_P_P_Signal_A_q.SetAggregation(AggregationKind.composite);
					MultipleDelegation_SameConnector_P_P_Signal_A_q.isService = true;
					MultipleDelegation_SameConnector_P_P_Signal_A_q.AddProvided(MultipleDelegation_SameConnector_P_P_Signal_I);
				MultipleDelegation_SameConnector_P_P_Signal_A.AddOwnedAttribute(MultipleDelegation_SameConnector_P_P_Signal_A_q);
					// Property b
					MultipleDelegation_SameConnector_P_P_Signal_A_b.SetName("b");
					MultipleDelegation_SameConnector_P_P_Signal_A_b.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_P_Signal_A_b.SetUpper(4);
					MultipleDelegation_SameConnector_P_P_Signal_A_b.SetLower(4);
					MultipleDelegation_SameConnector_P_P_Signal_A_b.SetType(MultipleDelegation_SameConnector_P_P_Signal_B);
					MultipleDelegation_SameConnector_P_P_Signal_A_b.SetAggregation(AggregationKind.composite);
				MultipleDelegation_SameConnector_P_P_Signal_A.AddOwnedAttribute(MultipleDelegation_SameConnector_P_P_Signal_A_b);
				
				MultipleDelegation_SameConnector_P_P_Signal_A_r.SetName("r");
					MultipleDelegation_SameConnector_P_P_Signal_A_r.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Signal_A_r_ConnectorEnd26.SetUpper(-1);
						MultipleDelegation_SameConnector_P_P_Signal_A_r_ConnectorEnd26.SetRole(MultipleDelegation_SameConnector_P_P_Signal_A_q);
						
					MultipleDelegation_SameConnector_P_P_Signal_A_r.AddEnd(MultipleDelegation_SameConnector_P_P_Signal_A_r_ConnectorEnd26);
						MultipleDelegation_SameConnector_P_P_Signal_A_r_ConnectorEnd28.SetUpper(-1);
						MultipleDelegation_SameConnector_P_P_Signal_A_r_ConnectorEnd28.SetLower(4);
						MultipleDelegation_SameConnector_P_P_Signal_A_r_ConnectorEnd28.SetRole(MultipleDelegation_SameConnector_P_P_Signal_A_b);
						
					MultipleDelegation_SameConnector_P_P_Signal_A_r.AddEnd(MultipleDelegation_SameConnector_P_P_Signal_A_r_ConnectorEnd28);
					MultipleDelegation_SameConnector_P_P_Signal_A_r.SetType(MultipleDelegation_SameConnector_P_P_Signal_R);
				MultipleDelegation_SameConnector_P_P_Signal_A.AddOwnedConnector(MultipleDelegation_SameConnector_P_P_Signal_A_r);
					// Operation A_A
					MultipleDelegation_SameConnector_P_P_Signal_A_A_A.SetName("A_A");
					MultipleDelegation_SameConnector_P_P_Signal_A_A_A.SetVisibility(VisibilityKind.public_);
						// Parameter result
						MultipleDelegation_SameConnector_P_P_Signal_A_A_A_result.SetName("result");
						MultipleDelegation_SameConnector_P_P_Signal_A_A_A_result.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Signal_A_A_A_result.SetType(MultipleDelegation_SameConnector_P_P_Signal_A);
						MultipleDelegation_SameConnector_P_P_Signal_A_A_A_result.SetDirection(ParameterDirectionKind.return_);
					MultipleDelegation_SameConnector_P_P_Signal_A_A_A.AddOwnedParameter(MultipleDelegation_SameConnector_P_P_Signal_A_A_A_result);
					MultipleDelegation_SameConnector_P_P_Signal_A_A_A.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				MultipleDelegation_SameConnector_P_P_Signal_A.AddOwnedOperation(MultipleDelegation_SameConnector_P_P_Signal_A_A_A);
			MultipleDelegation_SameConnector_P_P_Signal.AddPackagedElement(MultipleDelegation_SameConnector_P_P_Signal_A);
				// Class AbstractTester
				MultipleDelegation_SameConnector_P_P_Signal_AbstractTester.SetName("AbstractTester");
				MultipleDelegation_SameConnector_P_P_Signal_AbstractTester.SetVisibility(VisibilityKind.public_);
				
				MultipleDelegation_SameConnector_P_P_Signal_AbstractTester.SetIsAbstract(true);
				
				
				MultipleDelegation_SameConnector_P_P_Signal_AbstractTester.SetIsActive(true);
					// Operation test
					MultipleDelegation_SameConnector_P_P_Signal_AbstractTester_test.SetName("test");
					MultipleDelegation_SameConnector_P_P_Signal_AbstractTester_test.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_P_Signal_AbstractTester_test.SetIsAbstract(true);
				MultipleDelegation_SameConnector_P_P_Signal_AbstractTester.AddOwnedOperation(MultipleDelegation_SameConnector_P_P_Signal_AbstractTester_test);
					// Reception Start
					MultipleDelegation_SameConnector_P_P_Signal_AbstractTester_Start.SetName("Start");
					MultipleDelegation_SameConnector_P_P_Signal_AbstractTester_Start.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_P_Signal_AbstractTester_Start.SetSignal(MultipleDelegation_SameConnector_P_P_Signal_Start);
				MultipleDelegation_SameConnector_P_P_Signal_AbstractTester.AddOwnedReception(MultipleDelegation_SameConnector_P_P_Signal_AbstractTester_Start);
					// Reception Continue
					MultipleDelegation_SameConnector_P_P_Signal_AbstractTester_Continue.SetName("Continue");
					MultipleDelegation_SameConnector_P_P_Signal_AbstractTester_Continue.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_P_Signal_AbstractTester_Continue.SetSignal(MultipleDelegation_SameConnector_P_P_Signal_Continue);
				MultipleDelegation_SameConnector_P_P_Signal_AbstractTester.AddOwnedReception(MultipleDelegation_SameConnector_P_P_Signal_AbstractTester_Continue);
			MultipleDelegation_SameConnector_P_P_Signal.AddPackagedElement(MultipleDelegation_SameConnector_P_P_Signal_AbstractTester);
				// Signal S
				MultipleDelegation_SameConnector_P_P_Signal_S.SetName("S");
				MultipleDelegation_SameConnector_P_P_Signal_S.SetVisibility(VisibilityKind.public_);
				
					// Property v
					MultipleDelegation_SameConnector_P_P_Signal_S_v.SetName("v");
					MultipleDelegation_SameConnector_P_P_Signal_S_v.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_P_Signal_S_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
				MultipleDelegation_SameConnector_P_P_Signal_S.AddOwnedAttribute(MultipleDelegation_SameConnector_P_P_Signal_S_v);
					// Property t
					MultipleDelegation_SameConnector_P_P_Signal_S_t.SetName("t");
					MultipleDelegation_SameConnector_P_P_Signal_S_t.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_P_Signal_S_t.SetType(MultipleDelegation_SameConnector_P_P_Signal_AbstractTester);
				MultipleDelegation_SameConnector_P_P_Signal_S.AddOwnedAttribute(MultipleDelegation_SameConnector_P_P_Signal_S_t);
			MultipleDelegation_SameConnector_P_P_Signal.AddPackagedElement(MultipleDelegation_SameConnector_P_P_Signal_S);
				// SignalEvent StartEvent
				MultipleDelegation_SameConnector_P_P_Signal_StartEvent.SetName("StartEvent");
				MultipleDelegation_SameConnector_P_P_Signal_StartEvent.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_SameConnector_P_P_Signal_StartEvent.SetSignal(MultipleDelegation_SameConnector_P_P_Signal_Start);
			MultipleDelegation_SameConnector_P_P_Signal.AddPackagedElement(MultipleDelegation_SameConnector_P_P_Signal_StartEvent);
				// Interface I
				MultipleDelegation_SameConnector_P_P_Signal_I.SetName("I");
				MultipleDelegation_SameConnector_P_P_Signal_I.SetVisibility(VisibilityKind.public_);
					// Reception S
					MultipleDelegation_SameConnector_P_P_Signal_I_S.SetName("S");
					MultipleDelegation_SameConnector_P_P_Signal_I_S.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_P_Signal_I_S.SetSignal(MultipleDelegation_SameConnector_P_P_Signal_S);
				MultipleDelegation_SameConnector_P_P_Signal_I.AddOwnedReception(MultipleDelegation_SameConnector_P_P_Signal_I_S);
			MultipleDelegation_SameConnector_P_P_Signal.AddPackagedElement(MultipleDelegation_SameConnector_P_P_Signal_I);
				// Class B
				MultipleDelegation_SameConnector_P_P_Signal_B.SetName("B");
				MultipleDelegation_SameConnector_P_P_Signal_B.SetVisibility(VisibilityKind.public_);
				
					// Property p
					MultipleDelegation_SameConnector_P_P_Signal_B_p.SetName("p");
					MultipleDelegation_SameConnector_P_P_Signal_B_p.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_P_Signal_B_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
				MultipleDelegation_SameConnector_P_P_Signal_B.AddOwnedAttribute(MultipleDelegation_SameConnector_P_P_Signal_B_p);
				MultipleDelegation_SameConnector_P_P_Signal_B.SetClassifierBehavior(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior);
					// Activity BClassifierBehavior
					MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior.SetName("BClassifierBehavior");
					MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior.SetVisibility(VisibilityKind.public_);
						// AcceptEventAction Accept S
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Accept_S.SetName("Accept S");
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Accept_S.SetVisibility(VisibilityKind.public_);
							// OutputPin s
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_s.SetName("s");
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_s.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_s.SetType(MultipleDelegation_SameConnector_P_P_Signal_S);
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Accept_S.AddResult(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_s);
							// Trigger Trigger41
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_Trigger41.SetName("Trigger41");
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_Trigger41.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_Trigger41.SetEvent(MultipleDelegation_SameConnector_P_P_Signal_SEvent);
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Accept_S.AddTrigger(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_Trigger41);
					MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Accept_S);
						// AddStructuralFeatureValueAction Set this.p
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p.SetName("Set this.p");
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p.SetStructuralFeature(MultipleDelegation_SameConnector_P_P_Signal_B_p);
							// InputPin object
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_object.SetName("object");
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_object.SetType(MultipleDelegation_SameConnector_P_P_Signal_B);
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p.SetObject(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_object);
							// InputPin value
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_value.SetName("value");
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_value.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p.SetValue(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_value);
							// OutputPin result
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_result.SetName("result");
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_result.SetType(MultipleDelegation_SameConnector_P_P_Signal_B);
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p.SetResult(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_result);
					MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p);
						// SendSignalAction Send Continue
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue.SetName("Send Continue");
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue.SetSignal(MultipleDelegation_SameConnector_P_P_Signal_Continue);
							// InputPin target
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue_target.SetName("target");
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue_target.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue_target.SetType(MultipleDelegation_SameConnector_P_P_Signal_AbstractTester);
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue_target);
					MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue);
						// ReadStructuralFeatureAction Read s.v
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v.SetName("Read s.v");
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v.SetStructuralFeature(MultipleDelegation_SameConnector_P_P_Signal_S_v);
							// InputPin object
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_object.SetName("object");
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_object.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v.SetObject(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_object);
							// OutputPin result
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_result.SetName("result");
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v.SetResult(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_result);
					MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v);
						// ReadStructuralFeatureAction Read s.t
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t.SetName("Read s.t");
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t.SetStructuralFeature(MultipleDelegation_SameConnector_P_P_Signal_S_t);
							// InputPin object
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_object.SetName("object");
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_object.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t.SetObject(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_object);
							// OutputPin result
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_result.SetName("result");
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_result.SetType(MultipleDelegation_SameConnector_P_P_Signal_AbstractTester);
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t.SetResult(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_result);
					MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t);
						// ReadSelfAction this
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_this.SetName("this");
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_this_result.SetName("result");
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_this_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_this_result.SetType(MultipleDelegation_SameConnector_P_P_Signal_B);
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_this.SetResult(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_this_result);
					MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_this);
						// ForkNode Fork s
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Fork_s.SetName("Fork s");
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Fork_s.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Fork_s);
						// ObjectFlow ObjectFlow31 from result to target
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow31.SetName("ObjectFlow31");
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow31.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow31.SetSource(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_result);
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow31.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue_target);
							// LiteralBoolean LiteralBoolean32
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow31_LiteralBoolean32.SetName("LiteralBoolean32");
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow31_LiteralBoolean32.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow31_LiteralBoolean32.SetValue(true);
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow31.SetGuard(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow31_LiteralBoolean32);
					MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow31);
						// ObjectFlow ObjectFlow53 from Fork s to object
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow53.SetName("ObjectFlow53");
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow53.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow53.SetSource(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Fork_s);
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow53.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_t_object);
							// LiteralBoolean LiteralBoolean54
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow53_LiteralBoolean54.SetName("LiteralBoolean54");
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow53_LiteralBoolean54.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow53_LiteralBoolean54.SetValue(true);
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow53.SetGuard(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow53_LiteralBoolean54);
					MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow53);
						// ObjectFlow ObjectFlow34 from result to value
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow34.SetName("ObjectFlow34");
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow34.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow34.SetSource(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_result);
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow34.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_value);
							// LiteralBoolean LiteralBoolean35
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow34_LiteralBoolean35.SetName("LiteralBoolean35");
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow34_LiteralBoolean35.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow34_LiteralBoolean35.SetValue(true);
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow34.SetGuard(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow34_LiteralBoolean35);
					MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow34);
						// ObjectFlow ObjectFlow56 from result to object
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow56.SetName("ObjectFlow56");
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow56.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow56.SetSource(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_this_result);
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow56.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p_object);
							// LiteralBoolean LiteralBoolean57
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow56_LiteralBoolean57.SetName("LiteralBoolean57");
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow56_LiteralBoolean57.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow56_LiteralBoolean57.SetValue(true);
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow56.SetGuard(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow56_LiteralBoolean57);
					MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow56);
						// ControlFlow ControlFlow37 from Set this.p to Send Continue
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ControlFlow37.SetName("ControlFlow37");
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ControlFlow37.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ControlFlow37.SetSource(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Set_this_p);
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ControlFlow37.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Send_Continue);
					MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ControlFlow37);
						// ObjectFlow ObjectFlow38 from s to Fork s
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow38.SetName("ObjectFlow38");
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow38.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow38.SetSource(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Accept_S_s);
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow38.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Fork_s);
							// LiteralBoolean LiteralBoolean40
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow38_LiteralBoolean40.SetName("LiteralBoolean40");
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow38_LiteralBoolean40.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow38_LiteralBoolean40.SetValue(true);
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow38.SetGuard(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow38_LiteralBoolean40);
					MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow38);
						// ObjectFlow ObjectFlow69 from Fork s to object
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow69.SetName("ObjectFlow69");
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow69.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow69.SetSource(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Fork_s);
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow69.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_Read_s_v_object);
							// LiteralBoolean LiteralBoolean70
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow69_LiteralBoolean70.SetName("LiteralBoolean70");
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow69_LiteralBoolean70.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow69_LiteralBoolean70.SetValue(true);
						MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow69.SetGuard(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow69_LiteralBoolean70);
					MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior_ObjectFlow69);
				MultipleDelegation_SameConnector_P_P_Signal_B.AddOwnedBehavior(MultipleDelegation_SameConnector_P_P_Signal_B_BClassifierBehavior);
					MultipleDelegation_SameConnector_P_P_Signal_B_IRealization.SetName("IRealization");
					MultipleDelegation_SameConnector_P_P_Signal_B_IRealization.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_P_Signal_B_IRealization.SetContract(MultipleDelegation_SameConnector_P_P_Signal_I);
					
				MultipleDelegation_SameConnector_P_P_Signal_B.AddInterfaceRealization(MultipleDelegation_SameConnector_P_P_Signal_B_IRealization);
				
				MultipleDelegation_SameConnector_P_P_Signal_B.SetIsActive(true);
					// Operation B_B
					MultipleDelegation_SameConnector_P_P_Signal_B_B_B.SetName("B_B");
					MultipleDelegation_SameConnector_P_P_Signal_B_B_B.SetVisibility(VisibilityKind.public_);
						// Parameter result
						MultipleDelegation_SameConnector_P_P_Signal_B_B_B_result.SetName("result");
						MultipleDelegation_SameConnector_P_P_Signal_B_B_B_result.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Signal_B_B_B_result.SetType(MultipleDelegation_SameConnector_P_P_Signal_B);
						MultipleDelegation_SameConnector_P_P_Signal_B_B_B_result.SetDirection(ParameterDirectionKind.return_);
					MultipleDelegation_SameConnector_P_P_Signal_B_B_B.AddOwnedParameter(MultipleDelegation_SameConnector_P_P_Signal_B_B_B_result);
					MultipleDelegation_SameConnector_P_P_Signal_B_B_B.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				MultipleDelegation_SameConnector_P_P_Signal_B.AddOwnedOperation(MultipleDelegation_SameConnector_P_P_Signal_B_B_B);
					// Reception S
					MultipleDelegation_SameConnector_P_P_Signal_B_S.SetName("S");
					MultipleDelegation_SameConnector_P_P_Signal_B_S.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_P_Signal_B_S.SetSignal(MultipleDelegation_SameConnector_P_P_Signal_S);
				MultipleDelegation_SameConnector_P_P_Signal_B.AddOwnedReception(MultipleDelegation_SameConnector_P_P_Signal_B_S);
			MultipleDelegation_SameConnector_P_P_Signal.AddPackagedElement(MultipleDelegation_SameConnector_P_P_Signal_B);
				// Signal Start
				MultipleDelegation_SameConnector_P_P_Signal_Start.SetName("Start");
				MultipleDelegation_SameConnector_P_P_Signal_Start.SetVisibility(VisibilityKind.public_);
			MultipleDelegation_SameConnector_P_P_Signal.AddPackagedElement(MultipleDelegation_SameConnector_P_P_Signal_Start);
				// Association R
				MultipleDelegation_SameConnector_P_P_Signal_R.SetName("R");
				MultipleDelegation_SameConnector_P_P_Signal_R.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_SameConnector_P_P_Signal_R.AddOwnedEnd(MultipleDelegation_SameConnector_P_P_Signal_R_x);
				MultipleDelegation_SameConnector_P_P_Signal_R.AddOwnedEnd(MultipleDelegation_SameConnector_P_P_Signal_R_y);
			MultipleDelegation_SameConnector_P_P_Signal.AddPackagedElement(MultipleDelegation_SameConnector_P_P_Signal_R);
				// SignalEvent ContinueEvent
				MultipleDelegation_SameConnector_P_P_Signal_ContinueEvent.SetName("ContinueEvent");
				MultipleDelegation_SameConnector_P_P_Signal_ContinueEvent.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_SameConnector_P_P_Signal_ContinueEvent.SetSignal(MultipleDelegation_SameConnector_P_P_Signal_Continue);
			MultipleDelegation_SameConnector_P_P_Signal.AddPackagedElement(MultipleDelegation_SameConnector_P_P_Signal_ContinueEvent);
				// Class IImpl
				MultipleDelegation_SameConnector_P_P_Signal_IImpl.SetName("IImpl");
				MultipleDelegation_SameConnector_P_P_Signal_IImpl.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_SameConnector_P_P_Signal_IImpl_IRealization.SetName("IRealization");
					MultipleDelegation_SameConnector_P_P_Signal_IImpl_IRealization.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_P_Signal_IImpl_IRealization.SetContract(MultipleDelegation_SameConnector_P_P_Signal_I);
					
				MultipleDelegation_SameConnector_P_P_Signal_IImpl.AddInterfaceRealization(MultipleDelegation_SameConnector_P_P_Signal_IImpl_IRealization);
				
					// Reception S
					MultipleDelegation_SameConnector_P_P_Signal_IImpl_S.SetName("S");
					MultipleDelegation_SameConnector_P_P_Signal_IImpl_S.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_P_Signal_IImpl_S.SetSignal(MultipleDelegation_SameConnector_P_P_Signal_S);
				MultipleDelegation_SameConnector_P_P_Signal_IImpl.AddOwnedReception(MultipleDelegation_SameConnector_P_P_Signal_IImpl_S);
			MultipleDelegation_SameConnector_P_P_Signal.AddPackagedElement(MultipleDelegation_SameConnector_P_P_Signal_IImpl);
				// Class Tester
				MultipleDelegation_SameConnector_P_P_Signal_Tester.SetName("Tester");
				MultipleDelegation_SameConnector_P_P_Signal_Tester.SetVisibility(VisibilityKind.public_);
				
					// Generalization to AbstractTester
					MultipleDelegation_SameConnector_P_P_Signal_Tester_Generalization173.SetGeneral(MultipleDelegation_SameConnector_P_P_Signal_AbstractTester);
				MultipleDelegation_SameConnector_P_P_Signal_Tester.AddGeneralization(MultipleDelegation_SameConnector_P_P_Signal_Tester_Generalization173);
					// Property a
					MultipleDelegation_SameConnector_P_P_Signal_Tester_a.SetName("a");
					MultipleDelegation_SameConnector_P_P_Signal_Tester_a.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_P_Signal_Tester_a.SetType(MultipleDelegation_SameConnector_P_P_Signal_A);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_a.SetAggregation(AggregationKind.composite);
				MultipleDelegation_SameConnector_P_P_Signal_Tester.AddOwnedAttribute(MultipleDelegation_SameConnector_P_P_Signal_Tester_a);
				MultipleDelegation_SameConnector_P_P_Signal_Tester.SetClassifierBehavior(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior);
					// Activity testActivity
					MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity.SetName("testActivity");
					MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity.SetVisibility(VisibilityKind.public_);
					// FunctionBehavior testP
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_testP.SetName("testP");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_testP.SetVisibility(VisibilityKind.public_);
						
							// Parameter p
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_testP_p.SetName("p");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_testP_p.SetVisibility(VisibilityKind.public_);
							
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_testP.AddOwnedParameter(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_testP_p);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_testP.AddLanguage("C#");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_testP.AddLanguage("Using");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_testP.AddBody("if(index == 1) 	{ 		Console.WriteLine(\"Asserting c.b[1] == 4 || c.b[2] == 4 || c.b[3] == 4 || c.b[4] == 4\"); 	}  	// For some reason, during the first execution of the expansion region, its body is actually executed twice. 	// Because of that, the body is actually executaed 5 times in total. This if-statement covers that up until solved. 	if(index <= MAX_INDEX) 	{  		// Test parameter p 		int p = ((IntegerValue)inputParameters.ElementAt(0).values.ElementAt(0)).value; 		Debug.Println(\"[doBody] argument p = \" + p); 	 		Console.WriteLine( \"c.b[\" + index + \"] == \" + p); 		success = success || (p == 4);  		if(index == MAX_INDEX) 		{  			Console.Write(\"Signal delegated on all links (shall be true for default strategy): \");  			if(success) 			{ 				Console.ForegroundColor = ConsoleColor.Green; 				Console.WriteLine(\"Assertion successful.\"); 			} 			else 			{ 				Console.ForegroundColor = ConsoleColor.Red; 				Console.WriteLine(\"Assertion failed!\"); 			}  			Console.ResetColor(); 		} 	}  	index++;");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_testP.AddBody("using fuml.semantics.simpleclassifiers; ");
					MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity.AddOwnedBehavior(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_testP);
						// ReadStructuralFeatureAction Read b.p
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_b_p.SetName("Read b.p");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_b_p.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_b_p.SetStructuralFeature(MultipleDelegation_SameConnector_P_P_Signal_B_p);
							// InputPin object
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_b_p_object.SetName("object");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_b_p_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_b_p_object.SetType(MultipleDelegation_SameConnector_P_P_Signal_B);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_b_p.SetObject(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_b_p_object);
							// OutputPin result
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_b_p_result.SetName("result");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_b_p_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_b_p_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_b_p.SetResult(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_b_p_result);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity.AddNode(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_b_p);
						// ReadSelfAction this
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_this.SetName("this");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_this_result.SetName("result");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_this_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_this_result.SetType(MultipleDelegation_SameConnector_P_P_Signal_Tester);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_this.SetResult(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_this_result);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity.AddNode(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_this);
						// CallBehaviorAction Call testP
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Call_testP.SetName("Call testP");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Call_testP.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Call_testP.SetBehavior(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_testP);
							// InputPin p
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Call_testP_p.SetName("p");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Call_testP_p.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Call_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Call_testP.AddArgument(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Call_testP_p);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity.AddNode(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Call_testP);
						// ReadStructuralFeatureAction Read a.b
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_a_b.SetName("Read a.b");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_a_b.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_a_b.SetStructuralFeature(MultipleDelegation_SameConnector_P_P_Signal_A_b);
							// InputPin object
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_a_b_object.SetName("object");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_a_b_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_a_b_object.SetType(MultipleDelegation_SameConnector_P_P_Signal_A);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_a_b.SetObject(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_a_b_object);
							// OutputPin result
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_a_b_result.SetName("result");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_a_b_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_a_b_result.SetType(MultipleDelegation_SameConnector_P_P_Signal_B);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_a_b_result.SetUpper(4);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_a_b_result.SetLower(4);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_a_b.SetResult(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_a_b_result);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity.AddNode(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_a_b);
						// ReadStructuralFeatureAction Read this.a
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_this_a.SetName("Read this.a");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_this_a.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_this_a.SetStructuralFeature(MultipleDelegation_SameConnector_P_P_Signal_Tester_a);
							// InputPin object
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_this_a_object.SetName("object");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_this_a_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_this_a_object.SetType(MultipleDelegation_SameConnector_P_P_Signal_Tester);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_this_a.SetObject(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_this_a_object);
							// OutputPin result
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_this_a_result.SetName("result");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_this_a_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_this_a_result.SetType(MultipleDelegation_SameConnector_P_P_Signal_A);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_this_a.SetResult(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_this_a_result);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity.AddNode(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_this_a);
						// ObjectFlow ObjectFlow82 from result to object
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow82.SetName("ObjectFlow82");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow82.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow82.SetSource(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_this_a_result);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow82.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_a_b_object);
							// LiteralBoolean LiteralBoolean83
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow82_LiteralBoolean83.SetName("LiteralBoolean83");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow82_LiteralBoolean83.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow82_LiteralBoolean83.SetValue(true);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow82.SetGuard(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow82_LiteralBoolean83);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity.AddEdge(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow82);
						// ObjectFlow ObjectFlow85 from result to object
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow85.SetName("ObjectFlow85");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow85.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow85.SetSource(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_a_b_result);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow85.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_b_p_object);
							// LiteralBoolean LiteralBoolean86
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow85_LiteralBoolean86.SetName("LiteralBoolean86");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow85_LiteralBoolean86.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow85_LiteralBoolean86.SetValue(true);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow85.SetGuard(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow85_LiteralBoolean86);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity.AddEdge(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow85);
						// ObjectFlow ObjectFlow88 from result to object
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow88.SetName("ObjectFlow88");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow88.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow88.SetSource(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_this_result);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow88.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_this_a_object);
							// LiteralBoolean LiteralBoolean90
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow88_LiteralBoolean90.SetName("LiteralBoolean90");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow88_LiteralBoolean90.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow88_LiteralBoolean90.SetValue(true);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow88.SetGuard(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow88_LiteralBoolean90);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity.AddEdge(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow88);
						// ObjectFlow ObjectFlow102 from result to p
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow102.SetName("ObjectFlow102");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow102.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow102.SetSource(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Read_b_p_result);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow102.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_Call_testP_p);
							// LiteralBoolean LiteralBoolean103
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow102_LiteralBoolean103.SetName("LiteralBoolean103");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow102_LiteralBoolean103.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow102_LiteralBoolean103.SetValue(true);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow102.SetGuard(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow102_LiteralBoolean103);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity.AddEdge(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity_ObjectFlow102);
				MultipleDelegation_SameConnector_P_P_Signal_Tester.AddOwnedBehavior(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity);
					// Activity TesterClassifierBehavior
					MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior.SetName("TesterClassifierBehavior");
					MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior.SetVisibility(VisibilityKind.public_);
						// ReadStructuralFeatureAction Read this.a
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a.SetName("Read this.a");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a.SetStructuralFeature(MultipleDelegation_SameConnector_P_P_Signal_Tester_a);
							// InputPin object
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object.SetName("object");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object.SetType(MultipleDelegation_SameConnector_P_P_Signal_Tester);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a.SetObject(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object);
							// OutputPin result
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result.SetName("result");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result.SetType(MultipleDelegation_SameConnector_P_P_Signal_A);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a.SetResult(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a);
						// ValueSpecificationAction Value(4)
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4.SetName("Value(4)");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4.SetVisibility(VisibilityKind.public_);
							// LiteralInteger LiteralInteger153
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_LiteralInteger153.SetName("LiteralInteger153");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_LiteralInteger153.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_LiteralInteger153.SetValue(4);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4.SetValue(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_LiteralInteger153);
							// OutputPin result
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_result.SetName("result");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4.SetResult(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_result);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4);
						// CallOperationAction Call test()
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test_.SetName("Call test()");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test_.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test_.SetOperation(MultipleDelegation_SameConnector_P_P_Signal_Tester_test);
							// InputPin target
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target.SetName("target");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target.SetType(MultipleDelegation_SameConnector_P_P_Signal_Tester);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test_.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test_);
						// AcceptEventAction Accept Start
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start.SetName("Accept Start");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result.SetName("result");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result.SetType(MultipleDelegation_SameConnector_P_P_Signal_Start);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start.AddResult(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result);
							// Trigger Trigger163
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger163.SetName("Trigger163");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger163.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger163.SetEvent(MultipleDelegation_SameConnector_P_P_Signal_StartEvent);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start.AddTrigger(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger163);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start);
						// ReadSelfAction this
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_this.SetName("this");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_this_result.SetName("result");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_this_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_this_result.SetType(MultipleDelegation_SameConnector_P_P_Signal_Tester);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_this.SetResult(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_this_result);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_this);
						// SendSignalAction Send S
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S.SetName("Send S");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S.SetSignal(MultipleDelegation_SameConnector_P_P_Signal_S);
							// InputPin target
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_target.SetName("target");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_target.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_target.SetType(MultipleDelegation_SameConnector_P_P_Signal_IImpl);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_target);
							// InputPin v
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_v.SetName("v");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_v.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S.AddArgument(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_v);
							// InputPin t
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_t.SetName("t");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_t.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_t.SetType(MultipleDelegation_SameConnector_P_P_Signal_AbstractTester);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S.AddArgument(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_t);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S);
						// AcceptEventAction Accept Continue_1
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1.SetName("Accept Continue_1");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result.SetName("result");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result.SetType(MultipleDelegation_SameConnector_P_P_Signal_Continue);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1.AddResult(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result);
							// Trigger Trigger126
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_Trigger126.SetName("Trigger126");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_Trigger126.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_Trigger126.SetEvent(MultipleDelegation_SameConnector_P_P_Signal_ContinueEvent);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1.AddTrigger(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_Trigger126);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1);
						// ReadStructuralFeatureAction Read a.q
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q.SetName("Read a.q");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q.SetStructuralFeature(MultipleDelegation_SameConnector_P_P_Signal_A_q);
							// InputPin object
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object.SetName("object");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object.SetType(MultipleDelegation_SameConnector_P_P_Signal_A);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q.SetObject(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object);
							// OutputPin result
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result.SetName("result");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result.SetType(MultipleDelegation_SameConnector_P_P_Signal_IImpl);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q.SetResult(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q);
						// AcceptEventAction Accept Continue_3
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3.SetName("Accept Continue_3");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result.SetName("result");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result.SetType(MultipleDelegation_SameConnector_P_P_Signal_Continue);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3.AddResult(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result);
							// Trigger Trigger138
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_Trigger138.SetName("Trigger138");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_Trigger138.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_Trigger138.SetEvent(MultipleDelegation_SameConnector_P_P_Signal_ContinueEvent);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3.AddTrigger(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_Trigger138);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3);
						// AcceptEventAction Accept Continue_2
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2.SetName("Accept Continue_2");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result.SetName("result");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result.SetType(MultipleDelegation_SameConnector_P_P_Signal_Continue);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2.AddResult(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result);
							// Trigger Trigger169
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_Trigger169.SetName("Trigger169");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_Trigger169.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_Trigger169.SetEvent(MultipleDelegation_SameConnector_P_P_Signal_ContinueEvent);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2.AddTrigger(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_Trigger169);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2);
						// ForkNode Fork this
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Fork_this.SetName("Fork this");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Fork_this.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Fork_this);
						// AcceptEventAction Accept Continue_4
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4.SetName("Accept Continue_4");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result.SetName("result");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result.SetType(MultipleDelegation_SameConnector_P_P_Signal_Continue);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4.AddResult(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result);
							// Trigger Trigger146
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_Trigger146.SetName("Trigger146");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_Trigger146.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_Trigger146.SetEvent(MultipleDelegation_SameConnector_P_P_Signal_ContinueEvent);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4.AddTrigger(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_Trigger146);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4);
						// ObjectFlow ObjectFlow150 from result to Fork this
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow150.SetName("ObjectFlow150");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow150.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow150.SetSource(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_this_result);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow150.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Fork_this);
							// LiteralBoolean LiteralBoolean151
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow150_LiteralBoolean151.SetName("LiteralBoolean151");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow150_LiteralBoolean151.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow150_LiteralBoolean151.SetValue(true);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow150.SetGuard(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow150_LiteralBoolean151);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow150);
						// ObjectFlow ObjectFlow111 from Fork this to t
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow111.SetName("ObjectFlow111");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow111.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow111.SetSource(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Fork_this);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow111.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_t);
							// LiteralBoolean LiteralBoolean113
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow111_LiteralBoolean113.SetName("LiteralBoolean113");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow111_LiteralBoolean113.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow111_LiteralBoolean113.SetValue(true);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow111.SetGuard(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow111_LiteralBoolean113);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow111);
						// ObjectFlow ObjectFlow156 from result to target
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow156.SetName("ObjectFlow156");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow156.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow156.SetSource(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow156.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_target);
							// LiteralBoolean LiteralBoolean157
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow156_LiteralBoolean157.SetName("LiteralBoolean157");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow156_LiteralBoolean157.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow156_LiteralBoolean157.SetValue(true);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow156.SetGuard(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow156_LiteralBoolean157);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow156);
						// ControlFlow ControlFlow114 from Accept Continue_4 to Call test()
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow114.SetName("ControlFlow114");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow114.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow114.SetSource(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow114.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test_);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow114);
						// ControlFlow ControlFlow159 from Accept Continue_1 to Accept Continue_2
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow159.SetName("ControlFlow159");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow159.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow159.SetSource(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow159.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow159);
						// ObjectFlow ObjectFlow117 from result to v
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow117.SetName("ObjectFlow117");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow117.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow117.SetSource(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Value_4_result);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow117.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S_v);
							// LiteralBoolean LiteralBoolean119
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow117_LiteralBoolean119.SetName("LiteralBoolean119");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow117_LiteralBoolean119.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow117_LiteralBoolean119.SetValue(true);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow117.SetGuard(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow117_LiteralBoolean119);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow117);
						// ControlFlow ControlFlow164 from Accept Continue_3 to Accept Continue_4
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow164.SetName("ControlFlow164");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow164.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow164.SetSource(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow164.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow164);
						// ObjectFlow ObjectFlow165 from result to object
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow165.SetName("ObjectFlow165");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow165.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow165.SetSource(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow165.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object);
							// LiteralBoolean LiteralBoolean167
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow165_LiteralBoolean167.SetName("LiteralBoolean167");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow165_LiteralBoolean167.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow165_LiteralBoolean167.SetValue(true);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow165.SetGuard(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow165_LiteralBoolean167);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow165);
						// ControlFlow ControlFlow134 from Send S to Accept Continue_1
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow134.SetName("ControlFlow134");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow134.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow134.SetSource(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Send_S);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow134.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow134);
						// ObjectFlow ObjectFlow139 from Fork this to object
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow139.SetName("ObjectFlow139");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow139.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow139.SetSource(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Fork_this);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow139.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object);
							// LiteralBoolean LiteralBoolean140
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow139_LiteralBoolean140.SetName("LiteralBoolean140");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow139_LiteralBoolean140.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow139_LiteralBoolean140.SetValue(true);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow139.SetGuard(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow139_LiteralBoolean140);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow139);
						// ObjectFlow ObjectFlow142 from Fork this to target
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow142.SetName("ObjectFlow142");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow142.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow142.SetSource(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Fork_this);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow142.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target);
							// LiteralBoolean LiteralBoolean144
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow142_LiteralBoolean144.SetName("LiteralBoolean144");
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow142_LiteralBoolean144.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow142_LiteralBoolean144.SetValue(true);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow142.SetGuard(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow142_LiteralBoolean144);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow142);
						// ControlFlow ControlFlow168 from Accept Start to this
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow168.SetName("ControlFlow168");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow168.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow168.SetSource(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow168.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_this);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow168);
						// ControlFlow ControlFlow145 from Accept Continue_2 to Accept Continue_3
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow145.SetName("ControlFlow145");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow145.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow145.SetSource(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow145.SetTarget(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow145);
				MultipleDelegation_SameConnector_P_P_Signal_Tester.AddOwnedBehavior(MultipleDelegation_SameConnector_P_P_Signal_Tester_TesterClassifierBehavior);
				
				MultipleDelegation_SameConnector_P_P_Signal_Tester.SetIsActive(true);
					// Operation Tester_Tester
					MultipleDelegation_SameConnector_P_P_Signal_Tester_Tester_Tester.SetName("Tester_Tester");
					MultipleDelegation_SameConnector_P_P_Signal_Tester_Tester_Tester.SetVisibility(VisibilityKind.public_);
						// Parameter result
						MultipleDelegation_SameConnector_P_P_Signal_Tester_Tester_Tester_result.SetName("result");
						MultipleDelegation_SameConnector_P_P_Signal_Tester_Tester_Tester_result.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Signal_Tester_Tester_Tester_result.SetType(MultipleDelegation_SameConnector_P_P_Signal_Tester);
						MultipleDelegation_SameConnector_P_P_Signal_Tester_Tester_Tester_result.SetDirection(ParameterDirectionKind.return_);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_Tester_Tester.AddOwnedParameter(MultipleDelegation_SameConnector_P_P_Signal_Tester_Tester_Tester_result);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_Tester_Tester.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				MultipleDelegation_SameConnector_P_P_Signal_Tester.AddOwnedOperation(MultipleDelegation_SameConnector_P_P_Signal_Tester_Tester_Tester);
					// Operation test
					MultipleDelegation_SameConnector_P_P_Signal_Tester_test.SetName("test");
					MultipleDelegation_SameConnector_P_P_Signal_Tester_test.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_P_Signal_Tester_test.AddMethod(MultipleDelegation_SameConnector_P_P_Signal_Tester_testActivity);
				MultipleDelegation_SameConnector_P_P_Signal_Tester.AddOwnedOperation(MultipleDelegation_SameConnector_P_P_Signal_Tester_test);
			MultipleDelegation_SameConnector_P_P_Signal.AddPackagedElement(MultipleDelegation_SameConnector_P_P_Signal_Tester);
				// SignalEvent SEvent
				MultipleDelegation_SameConnector_P_P_Signal_SEvent.SetName("SEvent");
				MultipleDelegation_SameConnector_P_P_Signal_SEvent.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_SameConnector_P_P_Signal_SEvent.SetSignal(MultipleDelegation_SameConnector_P_P_Signal_S);
			MultipleDelegation_SameConnector_P_P_Signal.AddPackagedElement(MultipleDelegation_SameConnector_P_P_Signal_SEvent);
				// Signal Continue
				MultipleDelegation_SameConnector_P_P_Signal_Continue.SetName("Continue");
				MultipleDelegation_SameConnector_P_P_Signal_Continue.SetVisibility(VisibilityKind.public_);
			MultipleDelegation_SameConnector_P_P_Signal.AddPackagedElement(MultipleDelegation_SameConnector_P_P_Signal_Continue);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // MultipleDelegation_SameConnector_P_P_SignalModel
}
