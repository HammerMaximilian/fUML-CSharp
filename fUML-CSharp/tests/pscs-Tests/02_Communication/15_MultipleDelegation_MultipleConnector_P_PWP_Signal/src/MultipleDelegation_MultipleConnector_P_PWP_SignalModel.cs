/*
 * MultipleDelegation_MultipleConnector_P_PWP_SignalModel.cs
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

namespace MultipleDelegation_MultipleConnector_P_PWP_Signal
{
	public class MultipleDelegation_MultipleConnector_P_PWP_SignalModel : InMemoryModel
	{
		private static MultipleDelegation_MultipleConnector_P_PWP_SignalModel? instance;

		/*
		 * Model MultipleDelegation_MultipleConnector_P_PWP_Signal
		 */
		public Package MultipleDelegation_MultipleConnector_P_PWP_Signal = new();
			public Activity MultipleDelegation_MultipleConnector_P_PWP_Signal_main = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow0 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow0_LiteralBoolean1 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow0_LiteralInteger2 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow3 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow3_LiteralBoolean4 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow3_LiteralInteger5 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow6 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow6_LiteralInteger7 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow6_LiteralBoolean8 = new();
				public CreateObjectAction MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Create_Tester = new();
					public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Create_Tester_result = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Create_Tester_result_LiteralInteger9 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Create_Tester_result_LiteralUnlimitedNatural10 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow11 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow11_LiteralBoolean12 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow11_LiteralInteger13 = new();
				public StartObjectBehaviorAction MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Start_Tester = new();
					public InputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Start_Tester_object = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Start_Tester_object_LiteralUnlimitedNatural14 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Start_Tester_object_LiteralInteger15 = new();
				public ForkNode MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Fork_Tester = new();
				public ControlFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ControlFlow16 = new();
				public CallOperationAction MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Tester_ = new();
					public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Tester__result = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Tester__result_LiteralInteger17 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Tester__result_LiteralInteger18 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Tester__result_LiteralUnlimitedNatural19 = new();
					public InputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Tester__target = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Tester__target_LiteralUnlimitedNatural20 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Tester__target_LiteralInteger21 = new();
				public SendSignalAction MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Send_Start = new();
					public InputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Send_Start_target = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Send_Start_target_LiteralInteger22 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Send_Start_target_LiteralUnlimitedNatural23 = new();
			public SignalEvent MultipleDelegation_MultipleConnector_P_PWP_Signal_ContinueEvent = new();
			public SignalEvent MultipleDelegation_MultipleConnector_P_PWP_Signal_SEvent = new();
			public Signal MultipleDelegation_MultipleConnector_P_PWP_Signal_Continue = new();
			public Association MultipleDelegation_MultipleConnector_P_PWP_Signal_U = new();
				public Property MultipleDelegation_MultipleConnector_P_PWP_Signal_U_x = new();
					public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_U_x_LiteralUnlimitedNatural24 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_U_x_LiteralInteger25 = new();
				public Property MultipleDelegation_MultipleConnector_P_PWP_Signal_U_y = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_U_y_LiteralInteger26 = new();
					public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_U_y_LiteralUnlimitedNatural27 = new();
			public Class_ MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester = new();
				public Activity MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity = new();
					public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b = new();
						public InputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_object = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_object_LiteralInteger28 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_object_LiteralUnlimitedNatural29 = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_result = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_result_LiteralInteger30 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_result_LiteralUnlimitedNatural31 = new();
					public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a4 = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a4_result = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a4_result_LiteralInteger32 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a4_result_LiteralUnlimitedNatural33 = new();
						public InputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a4_object = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a4_object_LiteralInteger34 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a4_object_LiteralUnlimitedNatural35 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow36 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow36_LiteralInteger37 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow36_LiteralBoolean38 = new();
					public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_b_p = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_result_LiteralUnlimitedNatural39 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_result_LiteralInteger40 = new();
						public InputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_object = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_object_LiteralInteger41 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_object_LiteralUnlimitedNatural42 = new();
					public CallBehaviorAction MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Call_testP = new();
						public InputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Call_testP_p = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Call_testP_p_LiteralUnlimitedNatural43 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Call_testP_p_LiteralInteger44 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Call_testP_p_LiteralInteger45 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow46 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow46_LiteralBoolean47 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow46_LiteralInteger48 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow49 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow49_LiteralInteger50 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow49_LiteralBoolean51 = new();
					public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a2 = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a2_result = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a2_result_LiteralInteger52 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a2_result_LiteralUnlimitedNatural53 = new();
						public InputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a2_object = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a2_object_LiteralInteger54 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a2_object_LiteralUnlimitedNatural55 = new();
					public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a3 = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a3_result = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a3_result_LiteralInteger56 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a3_result_LiteralUnlimitedNatural57 = new();
						public InputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a3_object = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a3_object_LiteralInteger58 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a3_object_LiteralUnlimitedNatural59 = new();
					public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a1 = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a1_result = new();
						public InputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a1_object = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a1_object_LiteralUnlimitedNatural60 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a1_object_LiteralInteger61 = new();
					public ForkNode MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Fork_c = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow62 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow62_LiteralInteger63 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow62_LiteralBoolean64 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow65 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow65_LiteralBoolean66 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow65_LiteralInteger67 = new();
					public OpaqueBehavior MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_testP = new();
						public Parameter MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_testP_p = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow68 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow68_LiteralBoolean69 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow68_LiteralInteger70 = new();
					public ControlFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ControlFlow71 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow72 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow72_LiteralBoolean73 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow72_LiteralInteger74 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow75 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow75_LiteralBoolean76 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow75_LiteralInteger77 = new();
					public ControlFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ControlFlow78 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow79 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow79_LiteralInteger80 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow79_LiteralBoolean81 = new();
					public ReadSelfAction MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_this = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_this_result = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_this_result_LiteralInteger82 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_this_result_LiteralUnlimitedNatural83 = new();
					public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_this_c = new();
						public InputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_object = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_object_LiteralUnlimitedNatural84 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_object_LiteralInteger85 = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_result_LiteralUnlimitedNatural86 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_result_LiteralInteger87 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow88 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow88_LiteralInteger89 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow88_LiteralBoolean90 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow91 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow91_LiteralBoolean92 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow91_LiteralInteger93 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow94 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow94_LiteralInteger95 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow94_LiteralBoolean96 = new();
					public ControlFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ControlFlow97 = new();
				public Operation MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_Tester_Tester = new();
					public Parameter MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_Tester_Tester_result = new();
				public Property MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_c = new();
				public Activity MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow98 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow98_LiteralInteger99 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow98_LiteralBoolean100 = new();
					public ControlFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow101 = new();
					public AcceptEventAction MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_result = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralInteger102 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralUnlimitedNatural103 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralInteger104 = new();
						public Trigger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger105 = new();
					public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c = new();
						public InputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_object = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_object_LiteralInteger106 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_object_LiteralUnlimitedNatural107 = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_result_LiteralUnlimitedNatural108 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_result_LiteralInteger109 = new();
					public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p = new();
						public InputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_object = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_object_LiteralInteger110 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_object_LiteralUnlimitedNatural111 = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_result_LiteralUnlimitedNatural112 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_result_LiteralInteger113 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow114 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow114_LiteralBoolean115 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow114_LiteralInteger116 = new();
					public AcceptEventAction MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2 = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result_LiteralUnlimitedNatural117 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result_LiteralInteger118 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result_LiteralInteger119 = new();
						public Trigger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_Trigger120 = new();
					public ControlFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow121 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow122 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow122_LiteralInteger123 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow122_LiteralBoolean124 = new();
					public AcceptEventAction MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1 = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result_LiteralUnlimitedNatural125 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result_LiteralInteger126 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result_LiteralInteger127 = new();
						public Trigger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_Trigger128 = new();
					public ForkNode MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Fork_this = new();
					public SendSignalAction MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S = new();
						public InputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_target = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_target_LiteralInteger129 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_target_LiteralUnlimitedNatural130 = new();
						public InputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_v = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_v_LiteralInteger131 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_v_LiteralUnlimitedNatural132 = new();
						public InputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_t = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_t_LiteralUnlimitedNatural133 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_t_LiteralInteger134 = new();
					public AcceptEventAction MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4 = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result_LiteralInteger135 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result_LiteralInteger136 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result_LiteralUnlimitedNatural137 = new();
						public Trigger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_Trigger138 = new();
					public CallOperationAction MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test_ = new();
						public InputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test__target = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test__target_LiteralUnlimitedNatural139 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test__target_LiteralInteger140 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow141 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow141_LiteralInteger142 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow141_LiteralBoolean143 = new();
					public AcceptEventAction MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3 = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result_LiteralUnlimitedNatural144 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result_LiteralInteger145 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result_LiteralInteger146 = new();
						public Trigger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_Trigger147 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow148 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow148_LiteralInteger149 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow148_LiteralBoolean150 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow151 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow151_LiteralInteger152 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow151_LiteralBoolean153 = new();
					public ControlFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow154 = new();
					public ValueSpecificationAction MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4 = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_result_LiteralUnlimitedNatural155 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_result_LiteralInteger156 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_LiteralInteger157 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow158 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow158_LiteralBoolean159 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow158_LiteralInteger160 = new();
					public ReadSelfAction MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this_result_LiteralUnlimitedNatural161 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this_result_LiteralInteger162 = new();
					public ControlFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow163 = new();
					public ControlFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow164 = new();
					public ControlFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow165 = new();
				public Operation MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_test = new();
				public Generalization MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_Generalization166 = new();
			public Signal MultipleDelegation_MultipleConnector_P_PWP_Signal_S = new();
				public Property MultipleDelegation_MultipleConnector_P_PWP_Signal_S_v = new();
				public Property MultipleDelegation_MultipleConnector_P_PWP_Signal_S_t = new();
			public Class_ MultipleDelegation_MultipleConnector_P_PWP_Signal_C = new();
				public Property MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a2 = new();
					public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a2_LiteralUnlimitedNatural167 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a2_LiteralInteger168 = new();
				public Property MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a1 = new();
					public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a1_LiteralUnlimitedNatural169 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a1_LiteralInteger170 = new();
				public Property MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a3 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a3_LiteralInteger171 = new();
					public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a3_LiteralUnlimitedNatural172 = new();
				public Connector MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u3 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u3_ConnectorEnd173 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u3_ConnectorEnd174 = new();
				public Property MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a4 = new();
					public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a4_LiteralUnlimitedNatural175 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a4_LiteralInteger176 = new();
				public Connector MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u1 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u1_ConnectorEnd177 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u1_ConnectorEnd177_LiteralUnlimitedNatural178 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u1_ConnectorEnd177_LiteralInteger179 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u1_ConnectorEnd180 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u1_ConnectorEnd180_LiteralUnlimitedNatural181 = new();
				public Port MultipleDelegation_MultipleConnector_P_PWP_Signal_C_p = new();
				public Connector MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u2 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u2_ConnectorEnd182 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u2_ConnectorEnd183 = new();
				public Connector MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u4 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u4_ConnectorEnd184 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u4_ConnectorEnd185 = new();
			public Interface MultipleDelegation_MultipleConnector_P_PWP_Signal_I = new();
				public Reception MultipleDelegation_MultipleConnector_P_PWP_Signal_I_S = new();
			public Class_ MultipleDelegation_MultipleConnector_P_PWP_Signal_B = new();
				public Activity MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow186 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow186_LiteralBoolean187 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow186_LiteralInteger188 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow189 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow189_LiteralBoolean190 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow189_LiteralInteger191 = new();
					public ControlFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ControlFlow192 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow193 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow193_LiteralInteger194 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow193_LiteralBoolean195 = new();
					public AcceptEventAction MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S = new();
						public Trigger MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_Trigger196 = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_s = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_s_LiteralUnlimitedNatural197 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_s_LiteralInteger198 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_s_LiteralInteger199 = new();
					public AddStructuralFeatureValueAction MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_result_LiteralUnlimitedNatural200 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_result_LiteralInteger201 = new();
						public InputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_object = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_object_LiteralInteger202 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_object_LiteralUnlimitedNatural203 = new();
						public InputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_value = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_value_LiteralInteger204 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_value_LiteralUnlimitedNatural205 = new();
					public SendSignalAction MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue = new();
						public InputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue_target = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue_target_LiteralUnlimitedNatural206 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue_target_LiteralInteger207 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow208 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow208_LiteralBoolean209 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow208_LiteralInteger210 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow211 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow211_LiteralBoolean212 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow211_LiteralInteger213 = new();
					public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_result = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_result_LiteralInteger214 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_result_LiteralUnlimitedNatural215 = new();
						public InputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_object = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_object_LiteralInteger216 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_object_LiteralUnlimitedNatural217 = new();
					public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t = new();
						public InputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_object = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_object_LiteralInteger218 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_object_LiteralUnlimitedNatural219 = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_result_LiteralUnlimitedNatural220 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_result_LiteralInteger221 = new();
					public ReadSelfAction MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_this = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_this_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_this_result_LiteralUnlimitedNatural222 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_this_result_LiteralInteger223 = new();
					public ForkNode MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Fork_s = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow224 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow224_LiteralBoolean225 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow224_LiteralInteger226 = new();
				public InterfaceRealization MultipleDelegation_MultipleConnector_P_PWP_Signal_B_IRealization = new();
				public Operation MultipleDelegation_MultipleConnector_P_PWP_Signal_B_B_B = new();
					public Parameter MultipleDelegation_MultipleConnector_P_PWP_Signal_B_B_B_result = new();
				public Property MultipleDelegation_MultipleConnector_P_PWP_Signal_B_p = new();
				public Reception MultipleDelegation_MultipleConnector_P_PWP_Signal_B_S = new();
			public Class_ MultipleDelegation_MultipleConnector_P_PWP_Signal_A = new();
				public Port MultipleDelegation_MultipleConnector_P_PWP_Signal_A_q = new();
				public Connector MultipleDelegation_MultipleConnector_P_PWP_Signal_A_r = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_PWP_Signal_A_r_ConnectorEnd227 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_A_r_ConnectorEnd227_LiteralUnlimitedNatural228 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_A_r_ConnectorEnd227_LiteralInteger229 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_PWP_Signal_A_r_ConnectorEnd230 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_A_r_ConnectorEnd230_LiteralUnlimitedNatural231 = new();
				public Operation MultipleDelegation_MultipleConnector_P_PWP_Signal_A_A_A = new();
					public Parameter MultipleDelegation_MultipleConnector_P_PWP_Signal_A_A_A_result = new();
				public Property MultipleDelegation_MultipleConnector_P_PWP_Signal_A_b = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_A_b_LiteralInteger232 = new();
					public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_A_b_LiteralUnlimitedNatural233 = new();
			public SignalEvent MultipleDelegation_MultipleConnector_P_PWP_Signal_StartEvent = new();
			public Association MultipleDelegation_MultipleConnector_P_PWP_Signal_R = new();
				public Property MultipleDelegation_MultipleConnector_P_PWP_Signal_R_x = new();
					public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_R_x_LiteralUnlimitedNatural234 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_R_x_LiteralInteger235 = new();
				public Property MultipleDelegation_MultipleConnector_P_PWP_Signal_R_y = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_PWP_Signal_R_y_LiteralInteger236 = new();
					public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_PWP_Signal_R_y_LiteralUnlimitedNatural237 = new();
			public Class_ MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester = new();
				public Reception MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester_Continue = new();
				public Operation MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester_test = new();
				public Reception MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester_Start = new();
			public Class_ MultipleDelegation_MultipleConnector_P_PWP_Signal_IImpl = new();
				public InterfaceRealization MultipleDelegation_MultipleConnector_P_PWP_Signal_IImpl_IRealization = new();
				public Reception MultipleDelegation_MultipleConnector_P_PWP_Signal_IImpl_S = new();
			public Signal MultipleDelegation_MultipleConnector_P_PWP_Signal_Start = new();

		public static MultipleDelegation_MultipleConnector_P_PWP_SignalModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public MultipleDelegation_MultipleConnector_P_PWP_SignalModel()
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
			 * Model MultipleDelegation_MultipleConnector_P_PWP_Signal
			 */
			AddToElementRepository("MultipleDelegation_MultipleConnector_P_PWP_Signal", MultipleDelegation_MultipleConnector_P_PWP_Signal);
				AddToElementRepository("main", MultipleDelegation_MultipleConnector_P_PWP_Signal_main);
					AddToElementRepository("ObjectFlow0", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow0);
						AddToElementRepository("LiteralBoolean1", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow0_LiteralBoolean1);
						AddToElementRepository("LiteralInteger2", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow0_LiteralInteger2);
					AddToElementRepository("ObjectFlow3", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow3);
						AddToElementRepository("LiteralBoolean4", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow3_LiteralBoolean4);
						AddToElementRepository("LiteralInteger5", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow3_LiteralInteger5);
					AddToElementRepository("ObjectFlow6", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow6);
						AddToElementRepository("LiteralInteger7", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow6_LiteralInteger7);
						AddToElementRepository("LiteralBoolean8", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow6_LiteralBoolean8);
					AddToElementRepository("Create Tester", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Create_Tester);
						AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Create_Tester_result);
							AddToElementRepository("LiteralInteger9", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Create_Tester_result_LiteralInteger9);
							AddToElementRepository("LiteralUnlimitedNatural10", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Create_Tester_result_LiteralUnlimitedNatural10);
					AddToElementRepository("ObjectFlow11", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow11);
						AddToElementRepository("LiteralBoolean12", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow11_LiteralBoolean12);
						AddToElementRepository("LiteralInteger13", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow11_LiteralInteger13);
					AddToElementRepository("Start Tester", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Start_Tester);
						AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Start_Tester_object);
							AddToElementRepository("LiteralUnlimitedNatural14", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Start_Tester_object_LiteralUnlimitedNatural14);
							AddToElementRepository("LiteralInteger15", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Start_Tester_object_LiteralInteger15);
					AddToElementRepository("Fork Tester", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Fork_Tester);
					AddToElementRepository("ControlFlow16", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ControlFlow16);
					AddToElementRepository("Tester()", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Tester_);
						AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Tester__result);
							AddToElementRepository("LiteralInteger17", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Tester__result_LiteralInteger17);
							AddToElementRepository("LiteralInteger18", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Tester__result_LiteralInteger18);
							AddToElementRepository("LiteralUnlimitedNatural19", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Tester__result_LiteralUnlimitedNatural19);
						AddToElementRepository("target", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Tester__target);
							AddToElementRepository("LiteralUnlimitedNatural20", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Tester__target_LiteralUnlimitedNatural20);
							AddToElementRepository("LiteralInteger21", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Tester__target_LiteralInteger21);
					AddToElementRepository("Send Start", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Send_Start);
						AddToElementRepository("target", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Send_Start_target);
							AddToElementRepository("LiteralInteger22", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Send_Start_target_LiteralInteger22);
							AddToElementRepository("LiteralUnlimitedNatural23", MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Send_Start_target_LiteralUnlimitedNatural23);
				AddToElementRepository("ContinueEvent", MultipleDelegation_MultipleConnector_P_PWP_Signal_ContinueEvent);
				AddToElementRepository("SEvent", MultipleDelegation_MultipleConnector_P_PWP_Signal_SEvent);
				AddToElementRepository("Continue", MultipleDelegation_MultipleConnector_P_PWP_Signal_Continue);
				AddToElementRepository("U", MultipleDelegation_MultipleConnector_P_PWP_Signal_U);
					AddToElementRepository("x", MultipleDelegation_MultipleConnector_P_PWP_Signal_U_x);
						AddToElementRepository("LiteralUnlimitedNatural24", MultipleDelegation_MultipleConnector_P_PWP_Signal_U_x_LiteralUnlimitedNatural24);
						AddToElementRepository("LiteralInteger25", MultipleDelegation_MultipleConnector_P_PWP_Signal_U_x_LiteralInteger25);
					AddToElementRepository("y", MultipleDelegation_MultipleConnector_P_PWP_Signal_U_y);
						AddToElementRepository("LiteralInteger26", MultipleDelegation_MultipleConnector_P_PWP_Signal_U_y_LiteralInteger26);
						AddToElementRepository("LiteralUnlimitedNatural27", MultipleDelegation_MultipleConnector_P_PWP_Signal_U_y_LiteralUnlimitedNatural27);
				AddToElementRepository("Tester", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester);
					AddToElementRepository("testActivity", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity);
						AddToElementRepository("Read a.b", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b);
							AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_object);
								AddToElementRepository("LiteralInteger28", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_object_LiteralInteger28);
								AddToElementRepository("LiteralUnlimitedNatural29", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_object_LiteralUnlimitedNatural29);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_result);
								AddToElementRepository("LiteralInteger30", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_result_LiteralInteger30);
								AddToElementRepository("LiteralUnlimitedNatural31", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_result_LiteralUnlimitedNatural31);
						AddToElementRepository("Read c.a4", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a4);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a4_result);
								AddToElementRepository("LiteralInteger32", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a4_result_LiteralInteger32);
								AddToElementRepository("LiteralUnlimitedNatural33", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a4_result_LiteralUnlimitedNatural33);
							AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a4_object);
								AddToElementRepository("LiteralInteger34", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a4_object_LiteralInteger34);
								AddToElementRepository("LiteralUnlimitedNatural35", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a4_object_LiteralUnlimitedNatural35);
						AddToElementRepository("ObjectFlow36", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow36);
							AddToElementRepository("LiteralInteger37", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow36_LiteralInteger37);
							AddToElementRepository("LiteralBoolean38", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow36_LiteralBoolean38);
						AddToElementRepository("Read b.p", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_b_p);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_result);
								AddToElementRepository("LiteralUnlimitedNatural39", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_result_LiteralUnlimitedNatural39);
								AddToElementRepository("LiteralInteger40", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_result_LiteralInteger40);
							AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_object);
								AddToElementRepository("LiteralInteger41", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_object_LiteralInteger41);
								AddToElementRepository("LiteralUnlimitedNatural42", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_object_LiteralUnlimitedNatural42);
						AddToElementRepository("Call testP", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Call_testP);
							AddToElementRepository("p", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Call_testP_p);
								AddToElementRepository("LiteralUnlimitedNatural43", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Call_testP_p_LiteralUnlimitedNatural43);
								AddToElementRepository("LiteralInteger44", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Call_testP_p_LiteralInteger44);
								AddToElementRepository("LiteralInteger45", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Call_testP_p_LiteralInteger45);
						AddToElementRepository("ObjectFlow46", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow46);
							AddToElementRepository("LiteralBoolean47", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow46_LiteralBoolean47);
							AddToElementRepository("LiteralInteger48", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow46_LiteralInteger48);
						AddToElementRepository("ObjectFlow49", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow49);
							AddToElementRepository("LiteralInteger50", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow49_LiteralInteger50);
							AddToElementRepository("LiteralBoolean51", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow49_LiteralBoolean51);
						AddToElementRepository("Read c.a2", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a2);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a2_result);
								AddToElementRepository("LiteralInteger52", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a2_result_LiteralInteger52);
								AddToElementRepository("LiteralUnlimitedNatural53", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a2_result_LiteralUnlimitedNatural53);
							AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a2_object);
								AddToElementRepository("LiteralInteger54", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a2_object_LiteralInteger54);
								AddToElementRepository("LiteralUnlimitedNatural55", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a2_object_LiteralUnlimitedNatural55);
						AddToElementRepository("Read c.a3", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a3);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a3_result);
								AddToElementRepository("LiteralInteger56", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a3_result_LiteralInteger56);
								AddToElementRepository("LiteralUnlimitedNatural57", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a3_result_LiteralUnlimitedNatural57);
							AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a3_object);
								AddToElementRepository("LiteralInteger58", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a3_object_LiteralInteger58);
								AddToElementRepository("LiteralUnlimitedNatural59", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a3_object_LiteralUnlimitedNatural59);
						AddToElementRepository("Read c.a1", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a1);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a1_result);
							AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a1_object);
								AddToElementRepository("LiteralUnlimitedNatural60", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a1_object_LiteralUnlimitedNatural60);
								AddToElementRepository("LiteralInteger61", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a1_object_LiteralInteger61);
						AddToElementRepository("Fork c", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Fork_c);
						AddToElementRepository("ObjectFlow62", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow62);
							AddToElementRepository("LiteralInteger63", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow62_LiteralInteger63);
							AddToElementRepository("LiteralBoolean64", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow62_LiteralBoolean64);
						AddToElementRepository("ObjectFlow65", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow65);
							AddToElementRepository("LiteralBoolean66", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow65_LiteralBoolean66);
							AddToElementRepository("LiteralInteger67", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow65_LiteralInteger67);
						AddToElementRepository("testP", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_testP);
							AddToElementRepository("p", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_testP_p);
						AddToElementRepository("ObjectFlow68", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow68);
							AddToElementRepository("LiteralBoolean69", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow68_LiteralBoolean69);
							AddToElementRepository("LiteralInteger70", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow68_LiteralInteger70);
						AddToElementRepository("ControlFlow71", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ControlFlow71);
						AddToElementRepository("ObjectFlow72", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow72);
							AddToElementRepository("LiteralBoolean73", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow72_LiteralBoolean73);
							AddToElementRepository("LiteralInteger74", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow72_LiteralInteger74);
						AddToElementRepository("ObjectFlow75", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow75);
							AddToElementRepository("LiteralBoolean76", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow75_LiteralBoolean76);
							AddToElementRepository("LiteralInteger77", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow75_LiteralInteger77);
						AddToElementRepository("ControlFlow78", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ControlFlow78);
						AddToElementRepository("ObjectFlow79", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow79);
							AddToElementRepository("LiteralInteger80", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow79_LiteralInteger80);
							AddToElementRepository("LiteralBoolean81", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow79_LiteralBoolean81);
						AddToElementRepository("this", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_this);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_this_result);
								AddToElementRepository("LiteralInteger82", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_this_result_LiteralInteger82);
								AddToElementRepository("LiteralUnlimitedNatural83", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_this_result_LiteralUnlimitedNatural83);
						AddToElementRepository("Read this.c", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_this_c);
							AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_object);
								AddToElementRepository("LiteralUnlimitedNatural84", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_object_LiteralUnlimitedNatural84);
								AddToElementRepository("LiteralInteger85", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_object_LiteralInteger85);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_result);
								AddToElementRepository("LiteralUnlimitedNatural86", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_result_LiteralUnlimitedNatural86);
								AddToElementRepository("LiteralInteger87", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_result_LiteralInteger87);
						AddToElementRepository("ObjectFlow88", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow88);
							AddToElementRepository("LiteralInteger89", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow88_LiteralInteger89);
							AddToElementRepository("LiteralBoolean90", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow88_LiteralBoolean90);
						AddToElementRepository("ObjectFlow91", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow91);
							AddToElementRepository("LiteralBoolean92", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow91_LiteralBoolean92);
							AddToElementRepository("LiteralInteger93", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow91_LiteralInteger93);
						AddToElementRepository("ObjectFlow94", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow94);
							AddToElementRepository("LiteralInteger95", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow94_LiteralInteger95);
							AddToElementRepository("LiteralBoolean96", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow94_LiteralBoolean96);
						AddToElementRepository("ControlFlow97", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ControlFlow97);
					AddToElementRepository("Tester_Tester", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_Tester_Tester);
						AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_Tester_Tester_result);
					AddToElementRepository("c", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_c);
					AddToElementRepository("TesterClassifierBehavior", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior);
						AddToElementRepository("ObjectFlow98", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow98);
							AddToElementRepository("LiteralInteger99", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow98_LiteralInteger99);
							AddToElementRepository("LiteralBoolean100", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow98_LiteralBoolean100);
						AddToElementRepository("ControlFlow101", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow101);
						AddToElementRepository("Accept Start", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_result);
								AddToElementRepository("LiteralInteger102", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralInteger102);
								AddToElementRepository("LiteralUnlimitedNatural103", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralUnlimitedNatural103);
								AddToElementRepository("LiteralInteger104", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralInteger104);
							AddToElementRepository("Trigger105", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger105);
						AddToElementRepository("Read this.c", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c);
							AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_object);
								AddToElementRepository("LiteralInteger106", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_object_LiteralInteger106);
								AddToElementRepository("LiteralUnlimitedNatural107", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_object_LiteralUnlimitedNatural107);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_result);
								AddToElementRepository("LiteralUnlimitedNatural108", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_result_LiteralUnlimitedNatural108);
								AddToElementRepository("LiteralInteger109", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_result_LiteralInteger109);
						AddToElementRepository("Read c.p", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p);
							AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_object);
								AddToElementRepository("LiteralInteger110", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_object_LiteralInteger110);
								AddToElementRepository("LiteralUnlimitedNatural111", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_object_LiteralUnlimitedNatural111);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_result);
								AddToElementRepository("LiteralUnlimitedNatural112", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_result_LiteralUnlimitedNatural112);
								AddToElementRepository("LiteralInteger113", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_result_LiteralInteger113);
						AddToElementRepository("ObjectFlow114", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow114);
							AddToElementRepository("LiteralBoolean115", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow114_LiteralBoolean115);
							AddToElementRepository("LiteralInteger116", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow114_LiteralInteger116);
						AddToElementRepository("Accept Continue_2", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result);
								AddToElementRepository("LiteralUnlimitedNatural117", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result_LiteralUnlimitedNatural117);
								AddToElementRepository("LiteralInteger118", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result_LiteralInteger118);
								AddToElementRepository("LiteralInteger119", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result_LiteralInteger119);
							AddToElementRepository("Trigger120", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_Trigger120);
						AddToElementRepository("ControlFlow121", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow121);
						AddToElementRepository("ObjectFlow122", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow122);
							AddToElementRepository("LiteralInteger123", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow122_LiteralInteger123);
							AddToElementRepository("LiteralBoolean124", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow122_LiteralBoolean124);
						AddToElementRepository("Accept Continue_1", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result);
								AddToElementRepository("LiteralUnlimitedNatural125", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result_LiteralUnlimitedNatural125);
								AddToElementRepository("LiteralInteger126", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result_LiteralInteger126);
								AddToElementRepository("LiteralInteger127", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result_LiteralInteger127);
							AddToElementRepository("Trigger128", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_Trigger128);
						AddToElementRepository("Fork this", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Fork_this);
						AddToElementRepository("Send S", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S);
							AddToElementRepository("target", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_target);
								AddToElementRepository("LiteralInteger129", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_target_LiteralInteger129);
								AddToElementRepository("LiteralUnlimitedNatural130", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_target_LiteralUnlimitedNatural130);
							AddToElementRepository("v", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_v);
								AddToElementRepository("LiteralInteger131", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_v_LiteralInteger131);
								AddToElementRepository("LiteralUnlimitedNatural132", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_v_LiteralUnlimitedNatural132);
							AddToElementRepository("t", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_t);
								AddToElementRepository("LiteralUnlimitedNatural133", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_t_LiteralUnlimitedNatural133);
								AddToElementRepository("LiteralInteger134", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_t_LiteralInteger134);
						AddToElementRepository("Accept Continue_4", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result);
								AddToElementRepository("LiteralInteger135", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result_LiteralInteger135);
								AddToElementRepository("LiteralInteger136", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result_LiteralInteger136);
								AddToElementRepository("LiteralUnlimitedNatural137", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result_LiteralUnlimitedNatural137);
							AddToElementRepository("Trigger138", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_Trigger138);
						AddToElementRepository("Call test()", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test_);
							AddToElementRepository("target", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test__target);
								AddToElementRepository("LiteralUnlimitedNatural139", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test__target_LiteralUnlimitedNatural139);
								AddToElementRepository("LiteralInteger140", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test__target_LiteralInteger140);
						AddToElementRepository("ObjectFlow141", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow141);
							AddToElementRepository("LiteralInteger142", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow141_LiteralInteger142);
							AddToElementRepository("LiteralBoolean143", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow141_LiteralBoolean143);
						AddToElementRepository("Accept Continue_3", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result);
								AddToElementRepository("LiteralUnlimitedNatural144", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result_LiteralUnlimitedNatural144);
								AddToElementRepository("LiteralInteger145", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result_LiteralInteger145);
								AddToElementRepository("LiteralInteger146", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result_LiteralInteger146);
							AddToElementRepository("Trigger147", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_Trigger147);
						AddToElementRepository("ObjectFlow148", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow148);
							AddToElementRepository("LiteralInteger149", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow148_LiteralInteger149);
							AddToElementRepository("LiteralBoolean150", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow148_LiteralBoolean150);
						AddToElementRepository("ObjectFlow151", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow151);
							AddToElementRepository("LiteralInteger152", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow151_LiteralInteger152);
							AddToElementRepository("LiteralBoolean153", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow151_LiteralBoolean153);
						AddToElementRepository("ControlFlow154", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow154);
						AddToElementRepository("Value(4)", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_result);
								AddToElementRepository("LiteralUnlimitedNatural155", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_result_LiteralUnlimitedNatural155);
								AddToElementRepository("LiteralInteger156", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_result_LiteralInteger156);
							AddToElementRepository("LiteralInteger157", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_LiteralInteger157);
						AddToElementRepository("ObjectFlow158", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow158);
							AddToElementRepository("LiteralBoolean159", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow158_LiteralBoolean159);
							AddToElementRepository("LiteralInteger160", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow158_LiteralInteger160);
						AddToElementRepository("this", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this_result);
								AddToElementRepository("LiteralUnlimitedNatural161", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this_result_LiteralUnlimitedNatural161);
								AddToElementRepository("LiteralInteger162", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this_result_LiteralInteger162);
						AddToElementRepository("ControlFlow163", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow163);
						AddToElementRepository("ControlFlow164", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow164);
						AddToElementRepository("ControlFlow165", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow165);
					AddToElementRepository("test", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_test);
					AddToElementRepository("Generalization166", MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_Generalization166);
				AddToElementRepository("S", MultipleDelegation_MultipleConnector_P_PWP_Signal_S);
					AddToElementRepository("v", MultipleDelegation_MultipleConnector_P_PWP_Signal_S_v);
					AddToElementRepository("t", MultipleDelegation_MultipleConnector_P_PWP_Signal_S_t);
				AddToElementRepository("C", MultipleDelegation_MultipleConnector_P_PWP_Signal_C);
					AddToElementRepository("a2", MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a2);
						AddToElementRepository("LiteralUnlimitedNatural167", MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a2_LiteralUnlimitedNatural167);
						AddToElementRepository("LiteralInteger168", MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a2_LiteralInteger168);
					AddToElementRepository("a1", MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a1);
						AddToElementRepository("LiteralUnlimitedNatural169", MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a1_LiteralUnlimitedNatural169);
						AddToElementRepository("LiteralInteger170", MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a1_LiteralInteger170);
					AddToElementRepository("a3", MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a3);
						AddToElementRepository("LiteralInteger171", MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a3_LiteralInteger171);
						AddToElementRepository("LiteralUnlimitedNatural172", MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a3_LiteralUnlimitedNatural172);
					AddToElementRepository("u3", MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u3);
						AddToElementRepository("ConnectorEnd173", MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u3_ConnectorEnd173);
						AddToElementRepository("ConnectorEnd174", MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u3_ConnectorEnd174);
					AddToElementRepository("a4", MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a4);
						AddToElementRepository("LiteralUnlimitedNatural175", MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a4_LiteralUnlimitedNatural175);
						AddToElementRepository("LiteralInteger176", MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a4_LiteralInteger176);
					AddToElementRepository("u1", MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u1);
						AddToElementRepository("ConnectorEnd177", MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u1_ConnectorEnd177);
							AddToElementRepository("LiteralUnlimitedNatural178", MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u1_ConnectorEnd177_LiteralUnlimitedNatural178);
							AddToElementRepository("LiteralInteger179", MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u1_ConnectorEnd177_LiteralInteger179);
						AddToElementRepository("ConnectorEnd180", MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u1_ConnectorEnd180);
							AddToElementRepository("LiteralUnlimitedNatural181", MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u1_ConnectorEnd180_LiteralUnlimitedNatural181);
					AddToElementRepository("p", MultipleDelegation_MultipleConnector_P_PWP_Signal_C_p);
					AddToElementRepository("u2", MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u2);
						AddToElementRepository("ConnectorEnd182", MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u2_ConnectorEnd182);
						AddToElementRepository("ConnectorEnd183", MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u2_ConnectorEnd183);
					AddToElementRepository("u4", MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u4);
						AddToElementRepository("ConnectorEnd184", MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u4_ConnectorEnd184);
						AddToElementRepository("ConnectorEnd185", MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u4_ConnectorEnd185);
				AddToElementRepository("I", MultipleDelegation_MultipleConnector_P_PWP_Signal_I);
					AddToElementRepository("S", MultipleDelegation_MultipleConnector_P_PWP_Signal_I_S);
				AddToElementRepository("B", MultipleDelegation_MultipleConnector_P_PWP_Signal_B);
					AddToElementRepository("BClassifierBehavior", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior);
						AddToElementRepository("ObjectFlow186", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow186);
							AddToElementRepository("LiteralBoolean187", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow186_LiteralBoolean187);
							AddToElementRepository("LiteralInteger188", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow186_LiteralInteger188);
						AddToElementRepository("ObjectFlow189", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow189);
							AddToElementRepository("LiteralBoolean190", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow189_LiteralBoolean190);
							AddToElementRepository("LiteralInteger191", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow189_LiteralInteger191);
						AddToElementRepository("ControlFlow192", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ControlFlow192);
						AddToElementRepository("ObjectFlow193", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow193);
							AddToElementRepository("LiteralInteger194", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow193_LiteralInteger194);
							AddToElementRepository("LiteralBoolean195", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow193_LiteralBoolean195);
						AddToElementRepository("Accept S", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S);
							AddToElementRepository("Trigger196", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_Trigger196);
							AddToElementRepository("s", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_s);
								AddToElementRepository("LiteralUnlimitedNatural197", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_s_LiteralUnlimitedNatural197);
								AddToElementRepository("LiteralInteger198", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_s_LiteralInteger198);
								AddToElementRepository("LiteralInteger199", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_s_LiteralInteger199);
						AddToElementRepository("Set this.p", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_result);
								AddToElementRepository("LiteralUnlimitedNatural200", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_result_LiteralUnlimitedNatural200);
								AddToElementRepository("LiteralInteger201", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_result_LiteralInteger201);
							AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_object);
								AddToElementRepository("LiteralInteger202", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_object_LiteralInteger202);
								AddToElementRepository("LiteralUnlimitedNatural203", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_object_LiteralUnlimitedNatural203);
							AddToElementRepository("value", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_value);
								AddToElementRepository("LiteralInteger204", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_value_LiteralInteger204);
								AddToElementRepository("LiteralUnlimitedNatural205", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_value_LiteralUnlimitedNatural205);
						AddToElementRepository("Send Continue", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue);
							AddToElementRepository("target", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue_target);
								AddToElementRepository("LiteralUnlimitedNatural206", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue_target_LiteralUnlimitedNatural206);
								AddToElementRepository("LiteralInteger207", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue_target_LiteralInteger207);
						AddToElementRepository("ObjectFlow208", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow208);
							AddToElementRepository("LiteralBoolean209", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow208_LiteralBoolean209);
							AddToElementRepository("LiteralInteger210", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow208_LiteralInteger210);
						AddToElementRepository("ObjectFlow211", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow211);
							AddToElementRepository("LiteralBoolean212", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow211_LiteralBoolean212);
							AddToElementRepository("LiteralInteger213", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow211_LiteralInteger213);
						AddToElementRepository("Read s.v", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_result);
								AddToElementRepository("LiteralInteger214", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_result_LiteralInteger214);
								AddToElementRepository("LiteralUnlimitedNatural215", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_result_LiteralUnlimitedNatural215);
							AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_object);
								AddToElementRepository("LiteralInteger216", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_object_LiteralInteger216);
								AddToElementRepository("LiteralUnlimitedNatural217", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_object_LiteralUnlimitedNatural217);
						AddToElementRepository("Read s.t", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t);
							AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_object);
								AddToElementRepository("LiteralInteger218", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_object_LiteralInteger218);
								AddToElementRepository("LiteralUnlimitedNatural219", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_object_LiteralUnlimitedNatural219);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_result);
								AddToElementRepository("LiteralUnlimitedNatural220", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_result_LiteralUnlimitedNatural220);
								AddToElementRepository("LiteralInteger221", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_result_LiteralInteger221);
						AddToElementRepository("this", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_this);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_this_result);
								AddToElementRepository("LiteralUnlimitedNatural222", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_this_result_LiteralUnlimitedNatural222);
								AddToElementRepository("LiteralInteger223", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_this_result_LiteralInteger223);
						AddToElementRepository("Fork s", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Fork_s);
						AddToElementRepository("ObjectFlow224", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow224);
							AddToElementRepository("LiteralBoolean225", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow224_LiteralBoolean225);
							AddToElementRepository("LiteralInteger226", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow224_LiteralInteger226);
					AddToElementRepository("IRealization", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_IRealization);
					AddToElementRepository("B_B", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_B_B);
						AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_B_B_result);
					AddToElementRepository("p", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_p);
					AddToElementRepository("S", MultipleDelegation_MultipleConnector_P_PWP_Signal_B_S);
				AddToElementRepository("A", MultipleDelegation_MultipleConnector_P_PWP_Signal_A);
					AddToElementRepository("q", MultipleDelegation_MultipleConnector_P_PWP_Signal_A_q);
					AddToElementRepository("r", MultipleDelegation_MultipleConnector_P_PWP_Signal_A_r);
						AddToElementRepository("ConnectorEnd227", MultipleDelegation_MultipleConnector_P_PWP_Signal_A_r_ConnectorEnd227);
							AddToElementRepository("LiteralUnlimitedNatural228", MultipleDelegation_MultipleConnector_P_PWP_Signal_A_r_ConnectorEnd227_LiteralUnlimitedNatural228);
							AddToElementRepository("LiteralInteger229", MultipleDelegation_MultipleConnector_P_PWP_Signal_A_r_ConnectorEnd227_LiteralInteger229);
						AddToElementRepository("ConnectorEnd230", MultipleDelegation_MultipleConnector_P_PWP_Signal_A_r_ConnectorEnd230);
							AddToElementRepository("LiteralUnlimitedNatural231", MultipleDelegation_MultipleConnector_P_PWP_Signal_A_r_ConnectorEnd230_LiteralUnlimitedNatural231);
					AddToElementRepository("A_A", MultipleDelegation_MultipleConnector_P_PWP_Signal_A_A_A);
						AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_PWP_Signal_A_A_A_result);
					AddToElementRepository("b", MultipleDelegation_MultipleConnector_P_PWP_Signal_A_b);
						AddToElementRepository("LiteralInteger232", MultipleDelegation_MultipleConnector_P_PWP_Signal_A_b_LiteralInteger232);
						AddToElementRepository("LiteralUnlimitedNatural233", MultipleDelegation_MultipleConnector_P_PWP_Signal_A_b_LiteralUnlimitedNatural233);
				AddToElementRepository("StartEvent", MultipleDelegation_MultipleConnector_P_PWP_Signal_StartEvent);
				AddToElementRepository("R", MultipleDelegation_MultipleConnector_P_PWP_Signal_R);
					AddToElementRepository("x", MultipleDelegation_MultipleConnector_P_PWP_Signal_R_x);
						AddToElementRepository("LiteralUnlimitedNatural234", MultipleDelegation_MultipleConnector_P_PWP_Signal_R_x_LiteralUnlimitedNatural234);
						AddToElementRepository("LiteralInteger235", MultipleDelegation_MultipleConnector_P_PWP_Signal_R_x_LiteralInteger235);
					AddToElementRepository("y", MultipleDelegation_MultipleConnector_P_PWP_Signal_R_y);
						AddToElementRepository("LiteralInteger236", MultipleDelegation_MultipleConnector_P_PWP_Signal_R_y_LiteralInteger236);
						AddToElementRepository("LiteralUnlimitedNatural237", MultipleDelegation_MultipleConnector_P_PWP_Signal_R_y_LiteralUnlimitedNatural237);
				AddToElementRepository("AbstractTester", MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester);
					AddToElementRepository("Continue", MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester_Continue);
					AddToElementRepository("test", MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester_test);
					AddToElementRepository("Start", MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester_Start);
				AddToElementRepository("IImpl", MultipleDelegation_MultipleConnector_P_PWP_Signal_IImpl);
					AddToElementRepository("IRealization", MultipleDelegation_MultipleConnector_P_PWP_Signal_IImpl_IRealization);
					AddToElementRepository("S", MultipleDelegation_MultipleConnector_P_PWP_Signal_IImpl_S);
				AddToElementRepository("Start", MultipleDelegation_MultipleConnector_P_PWP_Signal_Start);

			// Initialize public members
			/*
			 * Model MultipleDelegation_MultipleConnector_P_PWP_Signal
			 */
			MultipleDelegation_MultipleConnector_P_PWP_Signal.SetName("MultipleDelegation_MultipleConnector_P_PWP_Signal");
			MultipleDelegation_MultipleConnector_P_PWP_Signal.SetVisibility(VisibilityKind.public_);
				// Activity main
				MultipleDelegation_MultipleConnector_P_PWP_Signal_main.SetName("main");
				MultipleDelegation_MultipleConnector_P_PWP_Signal_main.SetVisibility(VisibilityKind.public_);
					// CreateObjectAction Create Tester
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Create_Tester.SetName("Create Tester");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Create_Tester.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Create_Tester.SetClassifier(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester);
						// OutputPin result
						MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Create_Tester_result.SetName("result");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Create_Tester_result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Create_Tester_result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Create_Tester.SetResult(MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Create_Tester_result);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_main.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Create_Tester);
					// StartObjectBehaviorAction Start Tester
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Start_Tester.SetName("Start Tester");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Start_Tester.SetVisibility(VisibilityKind.public_);
						// InputPin object
						MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Start_Tester_object.SetName("object");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Start_Tester_object.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Start_Tester.SetObject(MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Start_Tester_object);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_main.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Start_Tester);
					// ForkNode Fork Tester
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Fork_Tester.SetName("Fork Tester");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Fork_Tester.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_main.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Fork_Tester);
					// CallOperationAction Tester()
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Tester_.SetName("Tester()");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Tester_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Tester__result.SetName("result");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Tester__result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Tester__result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Tester_.AddResult(MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Tester__result);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Tester_.SetOperation(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_Tester_Tester);
						// InputPin target
						MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Tester__target.SetName("target");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Tester__target.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Tester__target.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Tester_.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Tester__target);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_main.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Tester_);
					// SendSignalAction Send Start
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Send_Start.SetName("Send Start");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Send_Start.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Send_Start.SetSignal(MultipleDelegation_MultipleConnector_P_PWP_Signal_Start);
						// InputPin target
						MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Send_Start_target.SetName("target");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Send_Start_target.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Send_Start_target.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Send_Start.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Send_Start_target);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_main.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Send_Start);
					// ObjectFlow ObjectFlow0 from result to Fork Tester
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow0.SetName("ObjectFlow0");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow0.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow0.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Tester__result);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow0.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Fork_Tester);
						// LiteralBoolean LiteralBoolean1
						MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow0_LiteralBoolean1.SetName("LiteralBoolean1");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow0_LiteralBoolean1.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow0_LiteralBoolean1.SetValue(true);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow0.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow0_LiteralBoolean1);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_main.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow0);
					// ObjectFlow ObjectFlow3 from Fork Tester to object
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow3.SetName("ObjectFlow3");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow3.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow3.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Fork_Tester);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow3.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Start_Tester_object);
						// LiteralBoolean LiteralBoolean4
						MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow3_LiteralBoolean4.SetName("LiteralBoolean4");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow3_LiteralBoolean4.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow3_LiteralBoolean4.SetValue(true);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow3.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow3_LiteralBoolean4);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_main.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow3);
					// ObjectFlow ObjectFlow6 from Fork Tester to target
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow6.SetName("ObjectFlow6");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow6.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow6.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Fork_Tester);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow6.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Send_Start_target);
						// LiteralBoolean LiteralBoolean8
						MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow6_LiteralBoolean8.SetName("LiteralBoolean8");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow6_LiteralBoolean8.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow6_LiteralBoolean8.SetValue(true);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow6.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow6_LiteralBoolean8);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_main.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow6);
					// ObjectFlow ObjectFlow11 from result to target
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow11.SetName("ObjectFlow11");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow11.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow11.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Create_Tester_result);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow11.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Tester__target);
						// LiteralBoolean LiteralBoolean12
						MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow11_LiteralBoolean12.SetName("LiteralBoolean12");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow11_LiteralBoolean12.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow11_LiteralBoolean12.SetValue(true);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow11.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow11_LiteralBoolean12);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_main.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ObjectFlow11);
					// ControlFlow ControlFlow16 from Start Tester to Send Start
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ControlFlow16.SetName("ControlFlow16");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ControlFlow16.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ControlFlow16.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Start_Tester);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ControlFlow16.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_main_Send_Start);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_main.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_main_ControlFlow16);
			MultipleDelegation_MultipleConnector_P_PWP_Signal.AddPackagedElement(MultipleDelegation_MultipleConnector_P_PWP_Signal_main);
				// SignalEvent ContinueEvent
				MultipleDelegation_MultipleConnector_P_PWP_Signal_ContinueEvent.SetName("ContinueEvent");
				MultipleDelegation_MultipleConnector_P_PWP_Signal_ContinueEvent.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_ContinueEvent.SetSignal(MultipleDelegation_MultipleConnector_P_PWP_Signal_Continue);
			MultipleDelegation_MultipleConnector_P_PWP_Signal.AddPackagedElement(MultipleDelegation_MultipleConnector_P_PWP_Signal_ContinueEvent);
				// SignalEvent SEvent
				MultipleDelegation_MultipleConnector_P_PWP_Signal_SEvent.SetName("SEvent");
				MultipleDelegation_MultipleConnector_P_PWP_Signal_SEvent.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_SEvent.SetSignal(MultipleDelegation_MultipleConnector_P_PWP_Signal_S);
			MultipleDelegation_MultipleConnector_P_PWP_Signal.AddPackagedElement(MultipleDelegation_MultipleConnector_P_PWP_Signal_SEvent);
				// Signal Continue
				MultipleDelegation_MultipleConnector_P_PWP_Signal_Continue.SetName("Continue");
				MultipleDelegation_MultipleConnector_P_PWP_Signal_Continue.SetVisibility(VisibilityKind.public_);
			MultipleDelegation_MultipleConnector_P_PWP_Signal.AddPackagedElement(MultipleDelegation_MultipleConnector_P_PWP_Signal_Continue);
				// Association U
				MultipleDelegation_MultipleConnector_P_PWP_Signal_U.SetName("U");
				MultipleDelegation_MultipleConnector_P_PWP_Signal_U.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_U.AddOwnedEnd(MultipleDelegation_MultipleConnector_P_PWP_Signal_U_x);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_U.AddOwnedEnd(MultipleDelegation_MultipleConnector_P_PWP_Signal_U_y);
			MultipleDelegation_MultipleConnector_P_PWP_Signal.AddPackagedElement(MultipleDelegation_MultipleConnector_P_PWP_Signal_U);
				// Class Tester
				MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester.SetName("Tester");
				MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester.SetVisibility(VisibilityKind.public_);
				
					// Generalization to AbstractTester
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_Generalization166.SetGeneral(MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester.AddGeneralization(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_Generalization166);
					// Property c
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_c.SetName("c");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_c.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_c.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_C);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_c.SetAggregation(AggregationKind.composite);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_c);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester.SetClassifierBehavior(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior);
					// Activity testActivity
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity.SetName("testActivity");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity.SetVisibility(VisibilityKind.public_);
					// FunctionBehavior testP
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_testP.SetName("testP");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_testP.SetVisibility(VisibilityKind.public_);
						
							// Parameter p
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_testP_p.SetName("p");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_testP_p.SetVisibility(VisibilityKind.public_);
							
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_testP.AddOwnedParameter(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_testP_p);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_testP.AddLanguage("C#");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_testP.AddLanguage("Using");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_testP.AddBody("if(index == 1) 	{ 		Console.WriteLine(\"Asserting c.a1.b.p == 4 && c.a2.b.p == 4 && c.a3.b.p == 4 && c.a4.b.p == 4\"); 	}  	// Test parameter p 	int p = ((IntegerValue)inputParameters.ElementAt(0).values.ElementAt(0)).value; 	Debug.Println(\"[doBody] argument p = \" + p); 	 	Console.WriteLine( \"c.a\" + index + \".b.p == \" + p); 	success = success && (p == 4); 	if(index == MAX_INDEX) 	{  		Console.Write(\"Signal delegated on all links (shall be true for default strategy): \");  		if(success) 		{ 			Console.ForegroundColor = ConsoleColor.Green; 			Console.WriteLine(\"Assertion successful.\"); 		} 		else 		{ 			Console.ForegroundColor = ConsoleColor.Red; 			Console.WriteLine(\"Assertion failed!\"); 		}  		Console.ResetColor(); 	}  	index++;");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_testP.AddBody("using fuml.semantics.simpleclassifiers;");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity.AddOwnedBehavior(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_testP);
						// ReadStructuralFeatureAction Read a.b
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b.SetName("Read a.b");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_PWP_Signal_A_b);
							// InputPin object
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_object.SetName("object");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_object.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_A);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b.SetObject(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_object);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_B);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_result.SetUpper(4);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_result.SetLower(4);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b.SetResult(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_result);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b);
						// ReadStructuralFeatureAction Read c.a4
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a4.SetName("Read c.a4");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a4.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a4.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a4);
							// InputPin object
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a4_object.SetName("object");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a4_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a4_object.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_C);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a4.SetObject(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a4_object);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a4_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a4_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a4_result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_A);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a4.SetResult(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a4_result);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a4);
						// ReadStructuralFeatureAction Read c.a3
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a3.SetName("Read c.a3");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a3.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a3.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a3);
							// InputPin object
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a3_object.SetName("object");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a3_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a3_object.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_C);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a3.SetObject(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a3_object);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a3_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a3_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a3_result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_A);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a3.SetResult(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a3_result);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a3);
						// ReadSelfAction this
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_this.SetName("this");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_this_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_this_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_this_result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_this.SetResult(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_this_result);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_this);
						// ReadStructuralFeatureAction Read this.c
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_this_c.SetName("Read this.c");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_this_c.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_this_c.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_c);
							// InputPin object
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_object.SetName("object");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_object.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_this_c.SetObject(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_object);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_C);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_this_c.SetResult(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_result);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_this_c);
						// ReadStructuralFeatureAction Read b.p
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_b_p.SetName("Read b.p");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_b_p.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_b_p.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_p);
							// InputPin object
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_object.SetName("object");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_object.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_B);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_b_p.SetObject(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_object);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_b_p.SetResult(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_result);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_b_p);
						// CallBehaviorAction Call testP
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Call_testP.SetName("Call testP");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Call_testP.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Call_testP.SetBehavior(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_testP);
							// InputPin p
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Call_testP_p.SetName("p");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Call_testP_p.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Call_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Call_testP.AddArgument(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Call_testP_p);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Call_testP);
						// ReadStructuralFeatureAction Read c.a1
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a1.SetName("Read c.a1");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a1.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a1.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a1);
							// InputPin object
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a1_object.SetName("object");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a1_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a1_object.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_C);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a1.SetObject(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a1_object);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a1_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a1_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a1_result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_A);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a1.SetResult(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a1_result);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a1);
						// ReadStructuralFeatureAction Read c.a2
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a2.SetName("Read c.a2");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a2.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a2.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a2);
							// InputPin object
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a2_object.SetName("object");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a2_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a2_object.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_C);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a2.SetObject(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a2_object);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a2_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a2_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a2_result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_A);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a2.SetResult(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a2_result);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a2);
						// ForkNode Fork c
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Fork_c.SetName("Fork c");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Fork_c.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Fork_c);
						// ObjectFlow ObjectFlow65 from result to object
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow65.SetName("ObjectFlow65");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow65.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow65.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a3_result);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow65.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_object);
							// LiteralBoolean LiteralBoolean66
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow65_LiteralBoolean66.SetName("LiteralBoolean66");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow65_LiteralBoolean66.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow65_LiteralBoolean66.SetValue(true);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow65.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow65_LiteralBoolean66);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow65);
						// ObjectFlow ObjectFlow36 from result to object
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow36.SetName("ObjectFlow36");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow36.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow36.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_result);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow36.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_object);
							// LiteralBoolean LiteralBoolean38
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow36_LiteralBoolean38.SetName("LiteralBoolean38");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow36_LiteralBoolean38.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow36_LiteralBoolean38.SetValue(true);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow36.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow36_LiteralBoolean38);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow36);
						// ObjectFlow ObjectFlow46 from result to object
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow46.SetName("ObjectFlow46");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow46.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow46.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a1_result);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow46.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_object);
							// LiteralBoolean LiteralBoolean47
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow46_LiteralBoolean47.SetName("LiteralBoolean47");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow46_LiteralBoolean47.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow46_LiteralBoolean47.SetValue(true);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow46.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow46_LiteralBoolean47);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow46);
						// ObjectFlow ObjectFlow68 from Fork c to object
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow68.SetName("ObjectFlow68");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow68.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow68.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Fork_c);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow68.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a1_object);
							// LiteralBoolean LiteralBoolean69
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow68_LiteralBoolean69.SetName("LiteralBoolean69");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow68_LiteralBoolean69.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow68_LiteralBoolean69.SetValue(true);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow68.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow68_LiteralBoolean69);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow68);
						// ObjectFlow ObjectFlow49 from Fork c to object
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow49.SetName("ObjectFlow49");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow49.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow49.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Fork_c);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow49.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a3_object);
							// LiteralBoolean LiteralBoolean51
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow49_LiteralBoolean51.SetName("LiteralBoolean51");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow49_LiteralBoolean51.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow49_LiteralBoolean51.SetValue(true);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow49.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow49_LiteralBoolean51);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow49);
						// ControlFlow ControlFlow71 from Read c.a3 to Read c.a4
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ControlFlow71.SetName("ControlFlow71");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ControlFlow71.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ControlFlow71.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a3);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ControlFlow71.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a4);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ControlFlow71);
						// ObjectFlow ObjectFlow72 from result to object
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow72.SetName("ObjectFlow72");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow72.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow72.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_this_result);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow72.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_object);
							// LiteralBoolean LiteralBoolean73
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow72_LiteralBoolean73.SetName("LiteralBoolean73");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow72_LiteralBoolean73.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow72_LiteralBoolean73.SetValue(true);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow72.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow72_LiteralBoolean73);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow72);
						// ObjectFlow ObjectFlow75 from result to object
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow75.SetName("ObjectFlow75");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow75.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow75.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a4_result);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow75.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_object);
							// LiteralBoolean LiteralBoolean76
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow75_LiteralBoolean76.SetName("LiteralBoolean76");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow75_LiteralBoolean76.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow75_LiteralBoolean76.SetValue(true);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow75.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow75_LiteralBoolean76);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow75);
						// ControlFlow ControlFlow78 from Read c.a2 to Read c.a3
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ControlFlow78.SetName("ControlFlow78");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ControlFlow78.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ControlFlow78.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a2);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ControlFlow78.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a3);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ControlFlow78);
						// ObjectFlow ObjectFlow79 from Fork c to object
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow79.SetName("ObjectFlow79");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow79.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow79.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Fork_c);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow79.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a2_object);
							// LiteralBoolean LiteralBoolean81
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow79_LiteralBoolean81.SetName("LiteralBoolean81");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow79_LiteralBoolean81.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow79_LiteralBoolean81.SetValue(true);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow79.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow79_LiteralBoolean81);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow79);
						// ObjectFlow ObjectFlow88 from Fork c to object
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow88.SetName("ObjectFlow88");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow88.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow88.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Fork_c);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow88.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a4_object);
							// LiteralBoolean LiteralBoolean90
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow88_LiteralBoolean90.SetName("LiteralBoolean90");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow88_LiteralBoolean90.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow88_LiteralBoolean90.SetValue(true);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow88.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow88_LiteralBoolean90);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow88);
						// ObjectFlow ObjectFlow91 from result to Fork c
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow91.SetName("ObjectFlow91");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow91.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow91.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_this_c_result);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow91.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Fork_c);
							// LiteralBoolean LiteralBoolean92
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow91_LiteralBoolean92.SetName("LiteralBoolean92");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow91_LiteralBoolean92.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow91_LiteralBoolean92.SetValue(true);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow91.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow91_LiteralBoolean92);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow91);
						// ObjectFlow ObjectFlow94 from result to p
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow94.SetName("ObjectFlow94");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow94.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow94.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_b_p_result);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow94.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Call_testP_p);
							// LiteralBoolean LiteralBoolean96
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow94_LiteralBoolean96.SetName("LiteralBoolean96");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow94_LiteralBoolean96.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow94_LiteralBoolean96.SetValue(true);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow94.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow94_LiteralBoolean96);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow94);
						// ControlFlow ControlFlow97 from Read c.a1 to Read c.a2
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ControlFlow97.SetName("ControlFlow97");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ControlFlow97.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ControlFlow97.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a1);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ControlFlow97.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a2);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ControlFlow97);
						// ObjectFlow ObjectFlow62 from result to object
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow62.SetName("ObjectFlow62");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow62.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow62.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_c_a2_result);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow62.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_Read_a_b_object);
							// LiteralBoolean LiteralBoolean64
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow62_LiteralBoolean64.SetName("LiteralBoolean64");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow62_LiteralBoolean64.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow62_LiteralBoolean64.SetValue(true);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow62.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow62_LiteralBoolean64);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity_ObjectFlow62);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester.AddOwnedBehavior(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity);
					// Activity TesterClassifierBehavior
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.SetName("TesterClassifierBehavior");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.SetVisibility(VisibilityKind.public_);
						// AcceptEventAction Accept Start
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start.SetName("Accept Start");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_Start);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start.AddResult(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_result);
							// Trigger Trigger105
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger105.SetName("Trigger105");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger105.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger105.SetEvent(MultipleDelegation_MultipleConnector_P_PWP_Signal_StartEvent);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start.AddTrigger(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger105);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start);
						// ReadStructuralFeatureAction Read this.c
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c.SetName("Read this.c");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_c);
							// InputPin object
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_object.SetName("object");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_object.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c.SetObject(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_object);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_C);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c.SetResult(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_result);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c);
						// ReadStructuralFeatureAction Read c.p
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p.SetName("Read c.p");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_PWP_Signal_C_p);
							// InputPin object
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_object.SetName("object");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_object.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_C);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p.SetObject(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_object);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_IImpl);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p.SetResult(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_result);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p);
						// AcceptEventAction Accept Continue_2
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2.SetName("Accept Continue_2");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_Continue);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2.AddResult(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_result);
							// Trigger Trigger120
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_Trigger120.SetName("Trigger120");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_Trigger120.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_Trigger120.SetEvent(MultipleDelegation_MultipleConnector_P_PWP_Signal_ContinueEvent);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2.AddTrigger(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2_Trigger120);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2);
						// ValueSpecificationAction Value(4)
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4.SetName("Value(4)");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4.SetVisibility(VisibilityKind.public_);
							// LiteralInteger LiteralInteger157
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_LiteralInteger157.SetName("LiteralInteger157");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_LiteralInteger157.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_LiteralInteger157.SetValue(4);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4.SetValue(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_LiteralInteger157);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4.SetResult(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_result);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4);
						// AcceptEventAction Accept Continue_1
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1.SetName("Accept Continue_1");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_Continue);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1.AddResult(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_result);
							// Trigger Trigger128
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_Trigger128.SetName("Trigger128");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_Trigger128.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_Trigger128.SetEvent(MultipleDelegation_MultipleConnector_P_PWP_Signal_ContinueEvent);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1.AddTrigger(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1_Trigger128);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1);
						// ForkNode Fork this
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Fork_this.SetName("Fork this");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Fork_this.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Fork_this);
						// ReadSelfAction this
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this.SetName("this");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this_result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this.SetResult(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this_result);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this);
						// SendSignalAction Send S
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S.SetName("Send S");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S.SetSignal(MultipleDelegation_MultipleConnector_P_PWP_Signal_S);
							// InputPin target
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_target.SetName("target");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_target.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_target.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_IImpl);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_target);
							// InputPin v
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_v.SetName("v");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_v.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S.AddArgument(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_v);
							// InputPin t
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_t.SetName("t");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_t.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_t.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S.AddArgument(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_t);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S);
						// AcceptEventAction Accept Continue_4
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4.SetName("Accept Continue_4");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_Continue);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4.AddResult(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_result);
							// Trigger Trigger138
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_Trigger138.SetName("Trigger138");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_Trigger138.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_Trigger138.SetEvent(MultipleDelegation_MultipleConnector_P_PWP_Signal_ContinueEvent);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4.AddTrigger(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4_Trigger138);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4);
						// CallOperationAction Call test()
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test_.SetName("Call test()");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test_.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test_.SetOperation(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_test);
							// InputPin target
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test__target.SetName("target");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test__target.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test__target.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test_.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test__target);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test_);
						// AcceptEventAction Accept Continue_3
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3.SetName("Accept Continue_3");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_Continue);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3.AddResult(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_result);
							// Trigger Trigger147
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_Trigger147.SetName("Trigger147");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_Trigger147.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_Trigger147.SetEvent(MultipleDelegation_MultipleConnector_P_PWP_Signal_ContinueEvent);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3.AddTrigger(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3_Trigger147);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3);
						// ObjectFlow ObjectFlow98 from Fork this to object
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow98.SetName("ObjectFlow98");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow98.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow98.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Fork_this);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow98.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_object);
							// LiteralBoolean LiteralBoolean100
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow98_LiteralBoolean100.SetName("LiteralBoolean100");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow98_LiteralBoolean100.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow98_LiteralBoolean100.SetValue(true);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow98.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow98_LiteralBoolean100);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow98);
						// ControlFlow ControlFlow101 from Send S to Accept Continue_1
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow101.SetName("ControlFlow101");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow101.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow101.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow101.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow101);
						// ObjectFlow ObjectFlow151 from Fork this to target
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow151.SetName("ObjectFlow151");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow151.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow151.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Fork_this);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow151.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test__target);
							// LiteralBoolean LiteralBoolean153
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow151_LiteralBoolean153.SetName("LiteralBoolean153");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow151_LiteralBoolean153.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow151_LiteralBoolean153.SetValue(true);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow151.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow151_LiteralBoolean153);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow151);
						// ObjectFlow ObjectFlow114 from result to target
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow114.SetName("ObjectFlow114");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow114.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow114.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_result);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow114.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_target);
							// LiteralBoolean LiteralBoolean115
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow114_LiteralBoolean115.SetName("LiteralBoolean115");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow114_LiteralBoolean115.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow114_LiteralBoolean115.SetValue(true);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow114.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow114_LiteralBoolean115);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow114);
						// ControlFlow ControlFlow154 from Accept Continue_3 to Accept Continue_4
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow154.SetName("ControlFlow154");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow154.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow154.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow154.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow154);
						// ControlFlow ControlFlow121 from Accept Continue_1 to Accept Continue_2
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow121.SetName("ControlFlow121");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow121.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow121.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_1);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow121.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow121);
						// ObjectFlow ObjectFlow122 from result to object
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow122.SetName("ObjectFlow122");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow122.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow122.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_this_c_result);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow122.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Read_c_p_object);
							// LiteralBoolean LiteralBoolean124
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow122_LiteralBoolean124.SetName("LiteralBoolean124");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow122_LiteralBoolean124.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow122_LiteralBoolean124.SetValue(true);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow122.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow122_LiteralBoolean124);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow122);
						// ObjectFlow ObjectFlow158 from result to v
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow158.SetName("ObjectFlow158");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow158.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow158.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Value_4_result);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow158.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_v);
							// LiteralBoolean LiteralBoolean159
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow158_LiteralBoolean159.SetName("LiteralBoolean159");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow158_LiteralBoolean159.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow158_LiteralBoolean159.SetValue(true);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow158.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow158_LiteralBoolean159);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow158);
						// ObjectFlow ObjectFlow141 from result to Fork this
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow141.SetName("ObjectFlow141");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow141.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow141.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this_result);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow141.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Fork_this);
							// LiteralBoolean LiteralBoolean143
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow141_LiteralBoolean143.SetName("LiteralBoolean143");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow141_LiteralBoolean143.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow141_LiteralBoolean143.SetValue(true);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow141.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow141_LiteralBoolean143);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow141);
						// ControlFlow ControlFlow163 from Accept Start to this
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow163.SetName("ControlFlow163");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow163.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow163.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Start);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow163.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_this);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow163);
						// ControlFlow ControlFlow164 from Accept Continue_2 to Accept Continue_3
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow164.SetName("ControlFlow164");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow164.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow164.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_2);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow164.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_3);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow164);
						// ObjectFlow ObjectFlow148 from Fork this to t
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow148.SetName("ObjectFlow148");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow148.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow148.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Fork_this);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow148.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Send_S_t);
							// LiteralBoolean LiteralBoolean150
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow148_LiteralBoolean150.SetName("LiteralBoolean150");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow148_LiteralBoolean150.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow148_LiteralBoolean150.SetValue(true);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow148.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow148_LiteralBoolean150);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ObjectFlow148);
						// ControlFlow ControlFlow165 from Accept Continue_4 to Call test()
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow165.SetName("ControlFlow165");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow165.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow165.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Accept_Continue_4);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow165.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_Call_test_);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior_ControlFlow165);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester.AddOwnedBehavior(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_TesterClassifierBehavior);
				
				MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester.SetIsActive(true);
					// Operation Tester_Tester
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_Tester_Tester.SetName("Tester_Tester");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_Tester_Tester.SetVisibility(VisibilityKind.public_);
						// Parameter result
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_Tester_Tester_result.SetName("result");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_Tester_Tester_result.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_Tester_Tester_result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_Tester_Tester_result.SetDirection(ParameterDirectionKind.return_);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_Tester_Tester.AddOwnedParameter(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_Tester_Tester_result);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_Tester_Tester.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester.AddOwnedOperation(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_Tester_Tester);
					// Operation test
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_test.SetName("test");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_test.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_test.AddMethod(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_testActivity);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester.AddOwnedOperation(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester_test);
			MultipleDelegation_MultipleConnector_P_PWP_Signal.AddPackagedElement(MultipleDelegation_MultipleConnector_P_PWP_Signal_Tester);
				// Signal S
				MultipleDelegation_MultipleConnector_P_PWP_Signal_S.SetName("S");
				MultipleDelegation_MultipleConnector_P_PWP_Signal_S.SetVisibility(VisibilityKind.public_);
				
					// Property v
					MultipleDelegation_MultipleConnector_P_PWP_Signal_S_v.SetName("v");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_S_v.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Signal_S_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_S.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_PWP_Signal_S_v);
					// Property t
					MultipleDelegation_MultipleConnector_P_PWP_Signal_S_t.SetName("t");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_S_t.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Signal_S_t.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_S.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_PWP_Signal_S_t);
			MultipleDelegation_MultipleConnector_P_PWP_Signal.AddPackagedElement(MultipleDelegation_MultipleConnector_P_PWP_Signal_S);
				// Class C
				MultipleDelegation_MultipleConnector_P_PWP_Signal_C.SetName("C");
				MultipleDelegation_MultipleConnector_P_PWP_Signal_C.SetVisibility(VisibilityKind.public_);
				
					// Port p
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_p.SetName("p");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_p.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_p.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_IImpl);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_p.SetAggregation(AggregationKind.composite);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_p.isService = true;
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_p.AddProvided(MultipleDelegation_MultipleConnector_P_PWP_Signal_I);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_C.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_PWP_Signal_C_p);
					// Property a1
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a1.SetName("a1");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a1.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a1.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_A);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a1.SetAggregation(AggregationKind.composite);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_C.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a1);
					// Property a2
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a2.SetName("a2");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a2.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a2.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_A);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a2.SetAggregation(AggregationKind.composite);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_C.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a2);
					// Property a3
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a3.SetName("a3");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a3.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a3.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_A);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a3.SetAggregation(AggregationKind.composite);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_C.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a3);
					// Property a4
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a4.SetName("a4");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a4.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a4.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_A);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a4.SetAggregation(AggregationKind.composite);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_C.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a4);
				
				MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u3.SetName("u3");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u3.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u3_ConnectorEnd174.SetRole(MultipleDelegation_MultipleConnector_P_PWP_Signal_C_p);
						
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u3.AddEnd(MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u3_ConnectorEnd174);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u3_ConnectorEnd173.SetRole(MultipleDelegation_MultipleConnector_P_PWP_Signal_A_q);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u3_ConnectorEnd173.SetPartWithPort(MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a3);
						
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u3.AddEnd(MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u3_ConnectorEnd173);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u3.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_U);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_C.AddOwnedConnector(MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u3);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u1.SetName("u1");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u1.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u1_ConnectorEnd180.SetRole(MultipleDelegation_MultipleConnector_P_PWP_Signal_C_p);
						
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u1.AddEnd(MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u1_ConnectorEnd180);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u1_ConnectorEnd177.SetRole(MultipleDelegation_MultipleConnector_P_PWP_Signal_A_q);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u1_ConnectorEnd177.SetPartWithPort(MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a1);
						
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u1.AddEnd(MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u1_ConnectorEnd177);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u1.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_U);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_C.AddOwnedConnector(MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u1);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u2.SetName("u2");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u2.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u2_ConnectorEnd182.SetRole(MultipleDelegation_MultipleConnector_P_PWP_Signal_C_p);
						
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u2.AddEnd(MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u2_ConnectorEnd182);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u2_ConnectorEnd183.SetRole(MultipleDelegation_MultipleConnector_P_PWP_Signal_A_q);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u2_ConnectorEnd183.SetPartWithPort(MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a2);
						
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u2.AddEnd(MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u2_ConnectorEnd183);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u2.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_U);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_C.AddOwnedConnector(MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u2);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u4.SetName("u4");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u4.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u4_ConnectorEnd184.SetRole(MultipleDelegation_MultipleConnector_P_PWP_Signal_C_p);
						
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u4.AddEnd(MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u4_ConnectorEnd184);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u4_ConnectorEnd185.SetRole(MultipleDelegation_MultipleConnector_P_PWP_Signal_A_q);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u4_ConnectorEnd185.SetPartWithPort(MultipleDelegation_MultipleConnector_P_PWP_Signal_C_a4);
						
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u4.AddEnd(MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u4_ConnectorEnd185);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u4.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_U);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_C.AddOwnedConnector(MultipleDelegation_MultipleConnector_P_PWP_Signal_C_u4);
			MultipleDelegation_MultipleConnector_P_PWP_Signal.AddPackagedElement(MultipleDelegation_MultipleConnector_P_PWP_Signal_C);
				// Interface I
				MultipleDelegation_MultipleConnector_P_PWP_Signal_I.SetName("I");
				MultipleDelegation_MultipleConnector_P_PWP_Signal_I.SetVisibility(VisibilityKind.public_);
					// Reception S
					MultipleDelegation_MultipleConnector_P_PWP_Signal_I_S.SetName("S");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_I_S.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_I_S.SetSignal(MultipleDelegation_MultipleConnector_P_PWP_Signal_S);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_I.AddOwnedReception(MultipleDelegation_MultipleConnector_P_PWP_Signal_I_S);
			MultipleDelegation_MultipleConnector_P_PWP_Signal.AddPackagedElement(MultipleDelegation_MultipleConnector_P_PWP_Signal_I);
				// Class B
				MultipleDelegation_MultipleConnector_P_PWP_Signal_B.SetName("B");
				MultipleDelegation_MultipleConnector_P_PWP_Signal_B.SetVisibility(VisibilityKind.public_);
				
					// Property p
					MultipleDelegation_MultipleConnector_P_PWP_Signal_B_p.SetName("p");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_B_p.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Signal_B_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_B.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_p);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_B.SetClassifierBehavior(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior);
					// Activity BClassifierBehavior
					MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior.SetName("BClassifierBehavior");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior.SetVisibility(VisibilityKind.public_);
						// AcceptEventAction Accept S
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S.SetName("Accept S");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S.SetVisibility(VisibilityKind.public_);
							// OutputPin s
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_s.SetName("s");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_s.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_s.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_S);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S.AddResult(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_s);
							// Trigger Trigger196
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_Trigger196.SetName("Trigger196");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_Trigger196.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_Trigger196.SetEvent(MultipleDelegation_MultipleConnector_P_PWP_Signal_SEvent);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S.AddTrigger(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_Trigger196);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S);
						// AddStructuralFeatureValueAction Set this.p
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p.SetName("Set this.p");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_p);
							// InputPin object
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_object.SetName("object");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_object.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_B);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p.SetObject(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_object);
							// InputPin value
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_value.SetName("value");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_value.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p.SetValue(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_value);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_B);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p.SetResult(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_result);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p);
						// SendSignalAction Send Continue
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue.SetName("Send Continue");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue.SetSignal(MultipleDelegation_MultipleConnector_P_PWP_Signal_Continue);
							// InputPin target
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue_target.SetName("target");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue_target.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue_target.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue_target);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue);
						// ReadStructuralFeatureAction Read s.v
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v.SetName("Read s.v");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_PWP_Signal_S_v);
							// InputPin object
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_object.SetName("object");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_object.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v.SetObject(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_object);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v.SetResult(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_result);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v);
						// ReadStructuralFeatureAction Read s.t
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t.SetName("Read s.t");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_PWP_Signal_S_t);
							// InputPin object
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_object.SetName("object");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_object.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t.SetObject(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_object);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t.SetResult(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_result);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t);
						// ReadSelfAction this
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_this.SetName("this");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_this_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_this_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_this_result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_B);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_this.SetResult(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_this_result);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_this);
						// ForkNode Fork s
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Fork_s.SetName("Fork s");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Fork_s.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior.AddNode(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Fork_s);
						// ObjectFlow ObjectFlow186 from result to target
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow186.SetName("ObjectFlow186");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow186.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow186.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_result);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow186.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue_target);
							// LiteralBoolean LiteralBoolean187
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow186_LiteralBoolean187.SetName("LiteralBoolean187");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow186_LiteralBoolean187.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow186_LiteralBoolean187.SetValue(true);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow186.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow186_LiteralBoolean187);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow186);
						// ObjectFlow ObjectFlow208 from Fork s to object
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow208.SetName("ObjectFlow208");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow208.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow208.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Fork_s);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow208.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_t_object);
							// LiteralBoolean LiteralBoolean209
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow208_LiteralBoolean209.SetName("LiteralBoolean209");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow208_LiteralBoolean209.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow208_LiteralBoolean209.SetValue(true);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow208.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow208_LiteralBoolean209);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow208);
						// ObjectFlow ObjectFlow189 from result to value
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow189.SetName("ObjectFlow189");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow189.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow189.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_result);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow189.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_value);
							// LiteralBoolean LiteralBoolean190
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow189_LiteralBoolean190.SetName("LiteralBoolean190");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow189_LiteralBoolean190.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow189_LiteralBoolean190.SetValue(true);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow189.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow189_LiteralBoolean190);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow189);
						// ObjectFlow ObjectFlow211 from result to object
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow211.SetName("ObjectFlow211");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow211.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow211.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_this_result);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow211.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p_object);
							// LiteralBoolean LiteralBoolean212
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow211_LiteralBoolean212.SetName("LiteralBoolean212");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow211_LiteralBoolean212.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow211_LiteralBoolean212.SetValue(true);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow211.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow211_LiteralBoolean212);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow211);
						// ControlFlow ControlFlow192 from Set this.p to Send Continue
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ControlFlow192.SetName("ControlFlow192");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ControlFlow192.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ControlFlow192.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Set_this_p);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ControlFlow192.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Send_Continue);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ControlFlow192);
						// ObjectFlow ObjectFlow193 from s to Fork s
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow193.SetName("ObjectFlow193");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow193.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow193.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Accept_S_s);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow193.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Fork_s);
							// LiteralBoolean LiteralBoolean195
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow193_LiteralBoolean195.SetName("LiteralBoolean195");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow193_LiteralBoolean195.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow193_LiteralBoolean195.SetValue(true);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow193.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow193_LiteralBoolean195);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow193);
						// ObjectFlow ObjectFlow224 from Fork s to object
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow224.SetName("ObjectFlow224");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow224.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow224.SetSource(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Fork_s);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow224.SetTarget(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_Read_s_v_object);
							// LiteralBoolean LiteralBoolean225
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow224_LiteralBoolean225.SetName("LiteralBoolean225");
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow224_LiteralBoolean225.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow224_LiteralBoolean225.SetValue(true);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow224.SetGuard(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow224_LiteralBoolean225);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior.AddEdge(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior_ObjectFlow224);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_B.AddOwnedBehavior(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_BClassifierBehavior);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_B_IRealization.SetName("IRealization");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_B_IRealization.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_B_IRealization.SetContract(MultipleDelegation_MultipleConnector_P_PWP_Signal_I);
					
				MultipleDelegation_MultipleConnector_P_PWP_Signal_B.AddInterfaceRealization(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_IRealization);
				
				MultipleDelegation_MultipleConnector_P_PWP_Signal_B.SetIsActive(true);
					// Operation B_B
					MultipleDelegation_MultipleConnector_P_PWP_Signal_B_B_B.SetName("B_B");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_B_B_B.SetVisibility(VisibilityKind.public_);
						// Parameter result
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_B_B_result.SetName("result");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_B_B_result.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_B_B_result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_B);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_B_B_B_result.SetDirection(ParameterDirectionKind.return_);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_B_B_B.AddOwnedParameter(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_B_B_result);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_B_B_B.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_B.AddOwnedOperation(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_B_B);
					// Reception S
					MultipleDelegation_MultipleConnector_P_PWP_Signal_B_S.SetName("S");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_B_S.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_B_S.SetSignal(MultipleDelegation_MultipleConnector_P_PWP_Signal_S);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_B.AddOwnedReception(MultipleDelegation_MultipleConnector_P_PWP_Signal_B_S);
			MultipleDelegation_MultipleConnector_P_PWP_Signal.AddPackagedElement(MultipleDelegation_MultipleConnector_P_PWP_Signal_B);
				// Class A
				MultipleDelegation_MultipleConnector_P_PWP_Signal_A.SetName("A");
				MultipleDelegation_MultipleConnector_P_PWP_Signal_A.SetVisibility(VisibilityKind.public_);
				
					// Port q
					MultipleDelegation_MultipleConnector_P_PWP_Signal_A_q.SetName("q");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_A_q.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Signal_A_q.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_IImpl);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_A_q.SetAggregation(AggregationKind.composite);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_A_q.isService = true;
					MultipleDelegation_MultipleConnector_P_PWP_Signal_A_q.AddProvided(MultipleDelegation_MultipleConnector_P_PWP_Signal_I);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_A.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_PWP_Signal_A_q);
					// Property b
					MultipleDelegation_MultipleConnector_P_PWP_Signal_A_b.SetName("b");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_A_b.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_PWP_Signal_A_b.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_B);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_A_b.SetAggregation(AggregationKind.composite);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_A.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_PWP_Signal_A_b);
				
				MultipleDelegation_MultipleConnector_P_PWP_Signal_A_r.SetName("r");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_A_r.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_A_r_ConnectorEnd230.SetRole(MultipleDelegation_MultipleConnector_P_PWP_Signal_A_q);
						
					MultipleDelegation_MultipleConnector_P_PWP_Signal_A_r.AddEnd(MultipleDelegation_MultipleConnector_P_PWP_Signal_A_r_ConnectorEnd230);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_A_r_ConnectorEnd227.SetRole(MultipleDelegation_MultipleConnector_P_PWP_Signal_A_b);
						
					MultipleDelegation_MultipleConnector_P_PWP_Signal_A_r.AddEnd(MultipleDelegation_MultipleConnector_P_PWP_Signal_A_r_ConnectorEnd227);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_A_r.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_R);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_A.AddOwnedConnector(MultipleDelegation_MultipleConnector_P_PWP_Signal_A_r);
					// Operation A_A
					MultipleDelegation_MultipleConnector_P_PWP_Signal_A_A_A.SetName("A_A");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_A_A_A.SetVisibility(VisibilityKind.public_);
						// Parameter result
						MultipleDelegation_MultipleConnector_P_PWP_Signal_A_A_A_result.SetName("result");
						MultipleDelegation_MultipleConnector_P_PWP_Signal_A_A_A_result.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_PWP_Signal_A_A_A_result.SetType(MultipleDelegation_MultipleConnector_P_PWP_Signal_A);
						MultipleDelegation_MultipleConnector_P_PWP_Signal_A_A_A_result.SetDirection(ParameterDirectionKind.return_);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_A_A_A.AddOwnedParameter(MultipleDelegation_MultipleConnector_P_PWP_Signal_A_A_A_result);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_A_A_A.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_A.AddOwnedOperation(MultipleDelegation_MultipleConnector_P_PWP_Signal_A_A_A);
			MultipleDelegation_MultipleConnector_P_PWP_Signal.AddPackagedElement(MultipleDelegation_MultipleConnector_P_PWP_Signal_A);
				// SignalEvent StartEvent
				MultipleDelegation_MultipleConnector_P_PWP_Signal_StartEvent.SetName("StartEvent");
				MultipleDelegation_MultipleConnector_P_PWP_Signal_StartEvent.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_StartEvent.SetSignal(MultipleDelegation_MultipleConnector_P_PWP_Signal_Start);
			MultipleDelegation_MultipleConnector_P_PWP_Signal.AddPackagedElement(MultipleDelegation_MultipleConnector_P_PWP_Signal_StartEvent);
				// Association R
				MultipleDelegation_MultipleConnector_P_PWP_Signal_R.SetName("R");
				MultipleDelegation_MultipleConnector_P_PWP_Signal_R.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_R.AddOwnedEnd(MultipleDelegation_MultipleConnector_P_PWP_Signal_R_x);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_R.AddOwnedEnd(MultipleDelegation_MultipleConnector_P_PWP_Signal_R_y);
			MultipleDelegation_MultipleConnector_P_PWP_Signal.AddPackagedElement(MultipleDelegation_MultipleConnector_P_PWP_Signal_R);
				// Class AbstractTester
				MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester.SetName("AbstractTester");
				MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester.SetVisibility(VisibilityKind.public_);
				
				MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester.SetIsAbstract(true);
				
				
				MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester.SetIsActive(true);
					// Operation test
					MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester_test.SetName("test");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester_test.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester_test.SetIsAbstract(true);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester.AddOwnedOperation(MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester_test);
					// Reception Continue
					MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester_Continue.SetName("Continue");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester_Continue.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester_Continue.SetSignal(MultipleDelegation_MultipleConnector_P_PWP_Signal_Continue);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester.AddOwnedReception(MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester_Continue);
					// Reception Start
					MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester_Start.SetName("Start");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester_Start.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester_Start.SetSignal(MultipleDelegation_MultipleConnector_P_PWP_Signal_Start);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester.AddOwnedReception(MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester_Start);
			MultipleDelegation_MultipleConnector_P_PWP_Signal.AddPackagedElement(MultipleDelegation_MultipleConnector_P_PWP_Signal_AbstractTester);
				// Class IImpl
				MultipleDelegation_MultipleConnector_P_PWP_Signal_IImpl.SetName("IImpl");
				MultipleDelegation_MultipleConnector_P_PWP_Signal_IImpl.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_IImpl_IRealization.SetName("IRealization");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_IImpl_IRealization.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_IImpl_IRealization.SetContract(MultipleDelegation_MultipleConnector_P_PWP_Signal_I);
					
				MultipleDelegation_MultipleConnector_P_PWP_Signal_IImpl.AddInterfaceRealization(MultipleDelegation_MultipleConnector_P_PWP_Signal_IImpl_IRealization);
				
					// Reception S
					MultipleDelegation_MultipleConnector_P_PWP_Signal_IImpl_S.SetName("S");
					MultipleDelegation_MultipleConnector_P_PWP_Signal_IImpl_S.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_PWP_Signal_IImpl_S.SetSignal(MultipleDelegation_MultipleConnector_P_PWP_Signal_S);
				MultipleDelegation_MultipleConnector_P_PWP_Signal_IImpl.AddOwnedReception(MultipleDelegation_MultipleConnector_P_PWP_Signal_IImpl_S);
			MultipleDelegation_MultipleConnector_P_PWP_Signal.AddPackagedElement(MultipleDelegation_MultipleConnector_P_PWP_Signal_IImpl);
				// Signal Start
				MultipleDelegation_MultipleConnector_P_PWP_Signal_Start.SetName("Start");
				MultipleDelegation_MultipleConnector_P_PWP_Signal_Start.SetVisibility(VisibilityKind.public_);
			MultipleDelegation_MultipleConnector_P_PWP_Signal.AddPackagedElement(MultipleDelegation_MultipleConnector_P_PWP_Signal_Start);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // MultipleDelegation_MultipleConnector_P_PWP_SignalModel
}
