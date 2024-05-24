/*
 * BehaviorPort_SignalModel.cs
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

namespace BehaviorPort_Signal
{
	public class BehaviorPort_SignalModel : InMemoryModel
	{
		private static BehaviorPort_SignalModel? instance;

		/*
		 * Model BehaviorPort_Signal
		 */
		public Package BehaviorPort_Signal = new();
			public SignalEvent BehaviorPort_Signal_SignalEventStart = new();
			public Class_ BehaviorPort_Signal_Tester = new();
				public Activity BehaviorPort_Signal_Tester_TesterClassifierBehavior = new();
					public ObjectFlow BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow0 = new();
						public LiteralInteger BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow0_LiteralInteger1 = new();
						public LiteralBoolean BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow0_LiteralBoolean2 = new();
					public SendSignalAction BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S = new();
						public InputPin BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_v = new();
							public LiteralUnlimitedNatural BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_v_LiteralUnlimitedNatural3 = new();
							public LiteralInteger BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_v_LiteralInteger4 = new();
						public InputPin BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_t = new();
							public LiteralInteger BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_t_LiteralInteger5 = new();
							public LiteralUnlimitedNatural BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_t_LiteralUnlimitedNatural6 = new();
						public InputPin BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_target = new();
							public LiteralUnlimitedNatural BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_target_LiteralUnlimitedNatural7 = new();
							public LiteralInteger BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_target_LiteralInteger8 = new();
					public CallOperationAction BehaviorPort_Signal_Tester_TesterClassifierBehavior_Call_test_ = new();
						public InputPin BehaviorPort_Signal_Tester_TesterClassifierBehavior_Call_test__target = new();
							public LiteralInteger BehaviorPort_Signal_Tester_TesterClassifierBehavior_Call_test__target_LiteralInteger9 = new();
							public LiteralUnlimitedNatural BehaviorPort_Signal_Tester_TesterClassifierBehavior_Call_test__target_LiteralUnlimitedNatural10 = new();
					public ForkNode BehaviorPort_Signal_Tester_TesterClassifierBehavior_Fork_this = new();
					public ObjectFlow BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow11 = new();
						public LiteralInteger BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow11_LiteralInteger12 = new();
						public LiteralBoolean BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow11_LiteralBoolean13 = new();
					public ObjectFlow BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow14 = new();
						public LiteralBoolean BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow14_LiteralBoolean15 = new();
						public LiteralInteger BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow14_LiteralInteger16 = new();
					public ControlFlow BehaviorPort_Signal_Tester_TesterClassifierBehavior_ControlFlow17 = new();
					public ReadStructuralFeatureAction BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_q = new();
						public OutputPin BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_q_result = new();
							public LiteralUnlimitedNatural BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_q_result_LiteralUnlimitedNatural18 = new();
							public LiteralInteger BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_q_result_LiteralInteger19 = new();
						public InputPin BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_q_object = new();
							public LiteralUnlimitedNatural BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_q_object_LiteralUnlimitedNatural20 = new();
							public LiteralInteger BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_q_object_LiteralInteger21 = new();
					public ControlFlow BehaviorPort_Signal_Tester_TesterClassifierBehavior_ControlFlow22 = new();
					public ReadStructuralFeatureAction BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a = new();
						public OutputPin BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_result = new();
							public LiteralUnlimitedNatural BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_result_LiteralUnlimitedNatural23 = new();
							public LiteralInteger BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_result_LiteralInteger24 = new();
						public InputPin BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_object = new();
							public LiteralInteger BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_object_LiteralInteger25 = new();
							public LiteralUnlimitedNatural BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_object_LiteralUnlimitedNatural26 = new();
					public ObjectFlow BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow27 = new();
						public LiteralInteger BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow27_LiteralInteger28 = new();
						public LiteralBoolean BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow27_LiteralBoolean29 = new();
					public ObjectFlow BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow30 = new();
						public LiteralBoolean BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow30_LiteralBoolean31 = new();
						public LiteralInteger BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow30_LiteralInteger32 = new();
					public ObjectFlow BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow33 = new();
						public LiteralBoolean BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow33_LiteralBoolean34 = new();
						public LiteralInteger BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow33_LiteralInteger35 = new();
					public ObjectFlow BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow36 = new();
						public LiteralInteger BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow36_LiteralInteger37 = new();
						public LiteralBoolean BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow36_LiteralBoolean38 = new();
					public AcceptEventAction BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Start = new();
						public OutputPin BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Start_result = new();
							public LiteralInteger BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralInteger39 = new();
							public LiteralUnlimitedNatural BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralUnlimitedNatural40 = new();
							public LiteralInteger BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralInteger41 = new();
						public Trigger BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger42 = new();
					public InitialNode BehaviorPort_Signal_Tester_TesterClassifierBehavior_Initial = new();
					public ReadSelfAction BehaviorPort_Signal_Tester_TesterClassifierBehavior_this = new();
						public OutputPin BehaviorPort_Signal_Tester_TesterClassifierBehavior_this_result = new();
							public LiteralUnlimitedNatural BehaviorPort_Signal_Tester_TesterClassifierBehavior_this_result_LiteralUnlimitedNatural43 = new();
							public LiteralInteger BehaviorPort_Signal_Tester_TesterClassifierBehavior_this_result_LiteralInteger44 = new();
					public ControlFlow BehaviorPort_Signal_Tester_TesterClassifierBehavior_ControlFlow45 = new();
					public ValueSpecificationAction BehaviorPort_Signal_Tester_TesterClassifierBehavior_Value_4 = new();
						public LiteralInteger BehaviorPort_Signal_Tester_TesterClassifierBehavior_Value_4_LiteralInteger46 = new();
						public OutputPin BehaviorPort_Signal_Tester_TesterClassifierBehavior_Value_4_result = new();
							public LiteralInteger BehaviorPort_Signal_Tester_TesterClassifierBehavior_Value_4_result_LiteralInteger47 = new();
							public LiteralUnlimitedNatural BehaviorPort_Signal_Tester_TesterClassifierBehavior_Value_4_result_LiteralUnlimitedNatural48 = new();
					public AcceptEventAction BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Continue = new();
						public OutputPin BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Continue_result = new();
							public LiteralInteger BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Continue_result_LiteralInteger49 = new();
							public LiteralUnlimitedNatural BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Continue_result_LiteralUnlimitedNatural50 = new();
							public LiteralInteger BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Continue_result_LiteralInteger51 = new();
						public Trigger BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Continue_Trigger52 = new();
				public Operation BehaviorPort_Signal_Tester_Tester_Tester = new();
					public Parameter BehaviorPort_Signal_Tester_Tester_Tester_result = new();
				public Property BehaviorPort_Signal_Tester_a = new();
				public Operation BehaviorPort_Signal_Tester_test = new();
				public Generalization BehaviorPort_Signal_Tester_Generalization53 = new();
				public Activity BehaviorPort_Signal_Tester_testActivity = new();
					public CallBehaviorAction BehaviorPort_Signal_Tester_testActivity_Call_testP = new();
						public InputPin BehaviorPort_Signal_Tester_testActivity_Call_testP_p = new();
							public LiteralUnlimitedNatural BehaviorPort_Signal_Tester_testActivity_Call_testP_p_LiteralUnlimitedNatural54 = new();
							public LiteralInteger BehaviorPort_Signal_Tester_testActivity_Call_testP_p_LiteralInteger55 = new();
							public LiteralInteger BehaviorPort_Signal_Tester_testActivity_Call_testP_p_LiteralInteger56 = new();
					public ReadStructuralFeatureAction BehaviorPort_Signal_Tester_testActivity_this_a = new();
						public InputPin BehaviorPort_Signal_Tester_testActivity_this_a_object = new();
							public LiteralUnlimitedNatural BehaviorPort_Signal_Tester_testActivity_this_a_object_LiteralUnlimitedNatural57 = new();
							public LiteralInteger BehaviorPort_Signal_Tester_testActivity_this_a_object_LiteralInteger58 = new();
						public OutputPin BehaviorPort_Signal_Tester_testActivity_this_a_result = new();
							public LiteralInteger BehaviorPort_Signal_Tester_testActivity_this_a_result_LiteralInteger59 = new();
							public LiteralUnlimitedNatural BehaviorPort_Signal_Tester_testActivity_this_a_result_LiteralUnlimitedNatural60 = new();
					public ObjectFlow BehaviorPort_Signal_Tester_testActivity_ObjectFlow61 = new();
						public LiteralBoolean BehaviorPort_Signal_Tester_testActivity_ObjectFlow61_LiteralBoolean62 = new();
						public LiteralInteger BehaviorPort_Signal_Tester_testActivity_ObjectFlow61_LiteralInteger63 = new();
					public ObjectFlow BehaviorPort_Signal_Tester_testActivity_ObjectFlow64 = new();
						public LiteralBoolean BehaviorPort_Signal_Tester_testActivity_ObjectFlow64_LiteralBoolean65 = new();
						public LiteralInteger BehaviorPort_Signal_Tester_testActivity_ObjectFlow64_LiteralInteger66 = new();
					public ObjectFlow BehaviorPort_Signal_Tester_testActivity_ObjectFlow67 = new();
						public LiteralBoolean BehaviorPort_Signal_Tester_testActivity_ObjectFlow67_LiteralBoolean68 = new();
						public LiteralInteger BehaviorPort_Signal_Tester_testActivity_ObjectFlow67_LiteralInteger69 = new();
					public ReadSelfAction BehaviorPort_Signal_Tester_testActivity_this = new();
						public OutputPin BehaviorPort_Signal_Tester_testActivity_this_result = new();
							public LiteralInteger BehaviorPort_Signal_Tester_testActivity_this_result_LiteralInteger70 = new();
							public LiteralUnlimitedNatural BehaviorPort_Signal_Tester_testActivity_this_result_LiteralUnlimitedNatural71 = new();
					public ReadStructuralFeatureAction BehaviorPort_Signal_Tester_testActivity_this_a_p = new();
						public InputPin BehaviorPort_Signal_Tester_testActivity_this_a_p_object = new();
							public LiteralUnlimitedNatural BehaviorPort_Signal_Tester_testActivity_this_a_p_object_LiteralUnlimitedNatural72 = new();
							public LiteralInteger BehaviorPort_Signal_Tester_testActivity_this_a_p_object_LiteralInteger73 = new();
						public OutputPin BehaviorPort_Signal_Tester_testActivity_this_a_p_result = new();
							public LiteralInteger BehaviorPort_Signal_Tester_testActivity_this_a_p_result_LiteralInteger74 = new();
							public LiteralUnlimitedNatural BehaviorPort_Signal_Tester_testActivity_this_a_p_result_LiteralUnlimitedNatural75 = new();
					public OpaqueBehavior BehaviorPort_Signal_Tester_testActivity_testP = new();
						public Parameter BehaviorPort_Signal_Tester_testActivity_testP_p = new();
			public Signal BehaviorPort_Signal_S = new();
				public Property BehaviorPort_Signal_S_v = new();
				public Property BehaviorPort_Signal_S_t = new();
			public Class_ BehaviorPort_Signal_AbstractTester = new();
				public Reception BehaviorPort_Signal_AbstractTester_Continue = new();
				public Reception BehaviorPort_Signal_AbstractTester_Start = new();
				public Operation BehaviorPort_Signal_AbstractTester_test = new();
			public Interface BehaviorPort_Signal_I = new();
				public Reception BehaviorPort_Signal_I_S = new();
			public Class_ BehaviorPort_Signal_A = new();
				public Activity BehaviorPort_Signal_A_AClassifierBehavior = new();
					public ReadSelfAction BehaviorPort_Signal_A_AClassifierBehavior_this = new();
						public OutputPin BehaviorPort_Signal_A_AClassifierBehavior_this_result = new();
							public LiteralUnlimitedNatural BehaviorPort_Signal_A_AClassifierBehavior_this_result_LiteralUnlimitedNatural76 = new();
							public LiteralInteger BehaviorPort_Signal_A_AClassifierBehavior_this_result_LiteralInteger77 = new();
					public ObjectFlow BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow78 = new();
						public LiteralBoolean BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow78_LiteralBoolean79 = new();
						public LiteralInteger BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow78_LiteralInteger80 = new();
					public ReadStructuralFeatureAction BehaviorPort_Signal_A_AClassifierBehavior_Read_S_v = new();
						public OutputPin BehaviorPort_Signal_A_AClassifierBehavior_Read_S_v_result = new();
							public LiteralUnlimitedNatural BehaviorPort_Signal_A_AClassifierBehavior_Read_S_v_result_LiteralUnlimitedNatural81 = new();
							public LiteralInteger BehaviorPort_Signal_A_AClassifierBehavior_Read_S_v_result_LiteralInteger82 = new();
						public InputPin BehaviorPort_Signal_A_AClassifierBehavior_Read_S_v_object = new();
							public LiteralUnlimitedNatural BehaviorPort_Signal_A_AClassifierBehavior_Read_S_v_object_LiteralUnlimitedNatural83 = new();
							public LiteralInteger BehaviorPort_Signal_A_AClassifierBehavior_Read_S_v_object_LiteralInteger84 = new();
					public ObjectFlow BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow85 = new();
						public LiteralInteger BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow85_LiteralInteger86 = new();
						public LiteralBoolean BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow85_LiteralBoolean87 = new();
					public InitialNode BehaviorPort_Signal_A_AClassifierBehavior_Initial = new();
					public AcceptEventAction BehaviorPort_Signal_A_AClassifierBehavior_Accept_S = new();
						public OutputPin BehaviorPort_Signal_A_AClassifierBehavior_Accept_S_result = new();
							public LiteralUnlimitedNatural BehaviorPort_Signal_A_AClassifierBehavior_Accept_S_result_LiteralUnlimitedNatural88 = new();
							public LiteralInteger BehaviorPort_Signal_A_AClassifierBehavior_Accept_S_result_LiteralInteger89 = new();
							public LiteralInteger BehaviorPort_Signal_A_AClassifierBehavior_Accept_S_result_LiteralInteger90 = new();
						public Trigger BehaviorPort_Signal_A_AClassifierBehavior_Accept_S_Trigger91 = new();
					public SendSignalAction BehaviorPort_Signal_A_AClassifierBehavior_Send_Continue = new();
						public InputPin BehaviorPort_Signal_A_AClassifierBehavior_Send_Continue_target = new();
							public LiteralUnlimitedNatural BehaviorPort_Signal_A_AClassifierBehavior_Send_Continue_target_LiteralUnlimitedNatural92 = new();
							public LiteralInteger BehaviorPort_Signal_A_AClassifierBehavior_Send_Continue_target_LiteralInteger93 = new();
					public ReadStructuralFeatureAction BehaviorPort_Signal_A_AClassifierBehavior_Read_S_t = new();
						public InputPin BehaviorPort_Signal_A_AClassifierBehavior_Read_S_t_object = new();
							public LiteralInteger BehaviorPort_Signal_A_AClassifierBehavior_Read_S_t_object_LiteralInteger94 = new();
							public LiteralUnlimitedNatural BehaviorPort_Signal_A_AClassifierBehavior_Read_S_t_object_LiteralUnlimitedNatural95 = new();
						public OutputPin BehaviorPort_Signal_A_AClassifierBehavior_Read_S_t_result = new();
							public LiteralUnlimitedNatural BehaviorPort_Signal_A_AClassifierBehavior_Read_S_t_result_LiteralUnlimitedNatural96 = new();
							public LiteralInteger BehaviorPort_Signal_A_AClassifierBehavior_Read_S_t_result_LiteralInteger97 = new();
					public ObjectFlow BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow98 = new();
						public LiteralBoolean BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow98_LiteralBoolean99 = new();
						public LiteralInteger BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow98_LiteralInteger100 = new();
					public ObjectFlow BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow101 = new();
						public LiteralInteger BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow101_LiteralInteger102 = new();
						public LiteralBoolean BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow101_LiteralBoolean103 = new();
					public ControlFlow BehaviorPort_Signal_A_AClassifierBehavior_ControlFlow104 = new();
					public ObjectFlow BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow105 = new();
						public LiteralInteger BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow105_LiteralInteger106 = new();
						public LiteralBoolean BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow105_LiteralBoolean107 = new();
					public AddStructuralFeatureValueAction BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p = new();
						public OutputPin BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p_result = new();
							public LiteralInteger BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p_result_LiteralInteger108 = new();
							public LiteralUnlimitedNatural BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p_result_LiteralUnlimitedNatural109 = new();
						public InputPin BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p_object = new();
							public LiteralUnlimitedNatural BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p_object_LiteralUnlimitedNatural110 = new();
							public LiteralInteger BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p_object_LiteralInteger111 = new();
						public InputPin BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p_value = new();
							public LiteralUnlimitedNatural BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p_value_LiteralUnlimitedNatural112 = new();
							public LiteralInteger BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p_value_LiteralInteger113 = new();
					public ObjectFlow BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow114 = new();
						public LiteralInteger BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow114_LiteralInteger115 = new();
						public LiteralBoolean BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow114_LiteralBoolean116 = new();
					public ControlFlow BehaviorPort_Signal_A_AClassifierBehavior_ControlFlow117 = new();
					public ForkNode BehaviorPort_Signal_A_AClassifierBehavior_Fork_S = new();
				public InterfaceRealization BehaviorPort_Signal_A_IRealization = new();
				public Reception BehaviorPort_Signal_A_S = new();
				public Property BehaviorPort_Signal_A_p = new();
				public Port BehaviorPort_Signal_A_q = new();
				public Operation BehaviorPort_Signal_A_A_A = new();
					public Parameter BehaviorPort_Signal_A_A_A_result = new();
			public SignalEvent BehaviorPort_Signal_SignalEventContinue = new();
			public Signal BehaviorPort_Signal_Start = new();
			public Signal BehaviorPort_Signal_Continue = new();
			public SignalEvent BehaviorPort_Signal_SignalEventS = new();
			public Class_ BehaviorPort_Signal_IImpl = new();
				public InterfaceRealization BehaviorPort_Signal_IImpl_IRealization = new();
				public Reception BehaviorPort_Signal_IImpl_S = new();
			public Activity BehaviorPort_Signal_main = new();
				public ObjectFlow BehaviorPort_Signal_main_ObjectFlow118 = new();
					public LiteralBoolean BehaviorPort_Signal_main_ObjectFlow118_LiteralBoolean119 = new();
					public LiteralInteger BehaviorPort_Signal_main_ObjectFlow118_LiteralInteger120 = new();
				public ObjectFlow BehaviorPort_Signal_main_ObjectFlow121 = new();
					public LiteralBoolean BehaviorPort_Signal_main_ObjectFlow121_LiteralBoolean122 = new();
					public LiteralInteger BehaviorPort_Signal_main_ObjectFlow121_LiteralInteger123 = new();
				public CreateObjectAction BehaviorPort_Signal_main_Create_Tester = new();
					public OutputPin BehaviorPort_Signal_main_Create_Tester_result = new();
						public LiteralUnlimitedNatural BehaviorPort_Signal_main_Create_Tester_result_LiteralUnlimitedNatural124 = new();
						public LiteralInteger BehaviorPort_Signal_main_Create_Tester_result_LiteralInteger125 = new();
				public StartObjectBehaviorAction BehaviorPort_Signal_main_Start_Tester = new();
					public InputPin BehaviorPort_Signal_main_Start_Tester_object = new();
						public LiteralInteger BehaviorPort_Signal_main_Start_Tester_object_LiteralInteger126 = new();
						public LiteralUnlimitedNatural BehaviorPort_Signal_main_Start_Tester_object_LiteralUnlimitedNatural127 = new();
				public ForkNode BehaviorPort_Signal_main_Fork_Tester = new();
				public ObjectFlow BehaviorPort_Signal_main_ObjectFlow128 = new();
					public LiteralBoolean BehaviorPort_Signal_main_ObjectFlow128_LiteralBoolean129 = new();
					public LiteralInteger BehaviorPort_Signal_main_ObjectFlow128_LiteralInteger130 = new();
				public ControlFlow BehaviorPort_Signal_main_ControlFlow131 = new();
				public CallOperationAction BehaviorPort_Signal_main_Tester_ = new();
					public InputPin BehaviorPort_Signal_main_Tester__target = new();
						public LiteralInteger BehaviorPort_Signal_main_Tester__target_LiteralInteger132 = new();
						public LiteralUnlimitedNatural BehaviorPort_Signal_main_Tester__target_LiteralUnlimitedNatural133 = new();
					public OutputPin BehaviorPort_Signal_main_Tester__result = new();
						public LiteralInteger BehaviorPort_Signal_main_Tester__result_LiteralInteger134 = new();
						public LiteralUnlimitedNatural BehaviorPort_Signal_main_Tester__result_LiteralUnlimitedNatural135 = new();
						public LiteralInteger BehaviorPort_Signal_main_Tester__result_LiteralInteger136 = new();
				public SendSignalAction BehaviorPort_Signal_main_Send_Start = new();
					public InputPin BehaviorPort_Signal_main_Send_Start_target = new();
						public LiteralInteger BehaviorPort_Signal_main_Send_Start_target_LiteralInteger137 = new();
						public LiteralUnlimitedNatural BehaviorPort_Signal_main_Send_Start_target_LiteralUnlimitedNatural138 = new();
				public ObjectFlow BehaviorPort_Signal_main_ObjectFlow139 = new();
					public LiteralInteger BehaviorPort_Signal_main_ObjectFlow139_LiteralInteger140 = new();
					public LiteralBoolean BehaviorPort_Signal_main_ObjectFlow139_LiteralBoolean141 = new();

		public static BehaviorPort_SignalModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public BehaviorPort_SignalModel()
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
			 * Model BehaviorPort_Signal
			 */
			AddToElementRepository("BehaviorPort_Signal", BehaviorPort_Signal);
				AddToElementRepository("SignalEventStart", BehaviorPort_Signal_SignalEventStart);
				AddToElementRepository("Tester", BehaviorPort_Signal_Tester);
					AddToElementRepository("TesterClassifierBehavior", BehaviorPort_Signal_Tester_TesterClassifierBehavior);
						AddToElementRepository("ObjectFlow0", BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow0);
							AddToElementRepository("LiteralInteger1", BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow0_LiteralInteger1);
							AddToElementRepository("LiteralBoolean2", BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow0_LiteralBoolean2);
						AddToElementRepository("Send S", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S);
							AddToElementRepository("v", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_v);
								AddToElementRepository("LiteralUnlimitedNatural3", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_v_LiteralUnlimitedNatural3);
								AddToElementRepository("LiteralInteger4", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_v_LiteralInteger4);
							AddToElementRepository("t", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_t);
								AddToElementRepository("LiteralInteger5", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_t_LiteralInteger5);
								AddToElementRepository("LiteralUnlimitedNatural6", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_t_LiteralUnlimitedNatural6);
							AddToElementRepository("target", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_target);
								AddToElementRepository("LiteralUnlimitedNatural7", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_target_LiteralUnlimitedNatural7);
								AddToElementRepository("LiteralInteger8", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_target_LiteralInteger8);
						AddToElementRepository("Call test()", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Call_test_);
							AddToElementRepository("target", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Call_test__target);
								AddToElementRepository("LiteralInteger9", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Call_test__target_LiteralInteger9);
								AddToElementRepository("LiteralUnlimitedNatural10", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Call_test__target_LiteralUnlimitedNatural10);
						AddToElementRepository("Fork this", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Fork_this);
						AddToElementRepository("ObjectFlow11", BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow11);
							AddToElementRepository("LiteralInteger12", BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow11_LiteralInteger12);
							AddToElementRepository("LiteralBoolean13", BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow11_LiteralBoolean13);
						AddToElementRepository("ObjectFlow14", BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow14);
							AddToElementRepository("LiteralBoolean15", BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow14_LiteralBoolean15);
							AddToElementRepository("LiteralInteger16", BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow14_LiteralInteger16);
						AddToElementRepository("ControlFlow17", BehaviorPort_Signal_Tester_TesterClassifierBehavior_ControlFlow17);
						AddToElementRepository("Read this.a.q", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_q);
							AddToElementRepository("result", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_q_result);
								AddToElementRepository("LiteralUnlimitedNatural18", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_q_result_LiteralUnlimitedNatural18);
								AddToElementRepository("LiteralInteger19", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_q_result_LiteralInteger19);
							AddToElementRepository("object", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_q_object);
								AddToElementRepository("LiteralUnlimitedNatural20", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_q_object_LiteralUnlimitedNatural20);
								AddToElementRepository("LiteralInteger21", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_q_object_LiteralInteger21);
						AddToElementRepository("ControlFlow22", BehaviorPort_Signal_Tester_TesterClassifierBehavior_ControlFlow22);
						AddToElementRepository("Read this.a", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a);
							AddToElementRepository("result", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_result);
								AddToElementRepository("LiteralUnlimitedNatural23", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_result_LiteralUnlimitedNatural23);
								AddToElementRepository("LiteralInteger24", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_result_LiteralInteger24);
							AddToElementRepository("object", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_object);
								AddToElementRepository("LiteralInteger25", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_object_LiteralInteger25);
								AddToElementRepository("LiteralUnlimitedNatural26", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_object_LiteralUnlimitedNatural26);
						AddToElementRepository("ObjectFlow27", BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow27);
							AddToElementRepository("LiteralInteger28", BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow27_LiteralInteger28);
							AddToElementRepository("LiteralBoolean29", BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow27_LiteralBoolean29);
						AddToElementRepository("ObjectFlow30", BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow30);
							AddToElementRepository("LiteralBoolean31", BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow30_LiteralBoolean31);
							AddToElementRepository("LiteralInteger32", BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow30_LiteralInteger32);
						AddToElementRepository("ObjectFlow33", BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow33);
							AddToElementRepository("LiteralBoolean34", BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow33_LiteralBoolean34);
							AddToElementRepository("LiteralInteger35", BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow33_LiteralInteger35);
						AddToElementRepository("ObjectFlow36", BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow36);
							AddToElementRepository("LiteralInteger37", BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow36_LiteralInteger37);
							AddToElementRepository("LiteralBoolean38", BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow36_LiteralBoolean38);
						AddToElementRepository("Accept Start", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Start);
							AddToElementRepository("result", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Start_result);
								AddToElementRepository("LiteralInteger39", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralInteger39);
								AddToElementRepository("LiteralUnlimitedNatural40", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralUnlimitedNatural40);
								AddToElementRepository("LiteralInteger41", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralInteger41);
							AddToElementRepository("Trigger42", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger42);
						AddToElementRepository("Initial", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Initial);
						AddToElementRepository("this", BehaviorPort_Signal_Tester_TesterClassifierBehavior_this);
							AddToElementRepository("result", BehaviorPort_Signal_Tester_TesterClassifierBehavior_this_result);
								AddToElementRepository("LiteralUnlimitedNatural43", BehaviorPort_Signal_Tester_TesterClassifierBehavior_this_result_LiteralUnlimitedNatural43);
								AddToElementRepository("LiteralInteger44", BehaviorPort_Signal_Tester_TesterClassifierBehavior_this_result_LiteralInteger44);
						AddToElementRepository("ControlFlow45", BehaviorPort_Signal_Tester_TesterClassifierBehavior_ControlFlow45);
						AddToElementRepository("Value 4", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Value_4);
							AddToElementRepository("LiteralInteger46", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Value_4_LiteralInteger46);
							AddToElementRepository("result", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Value_4_result);
								AddToElementRepository("LiteralInteger47", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Value_4_result_LiteralInteger47);
								AddToElementRepository("LiteralUnlimitedNatural48", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Value_4_result_LiteralUnlimitedNatural48);
						AddToElementRepository("Accept Continue", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Continue);
							AddToElementRepository("result", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Continue_result);
								AddToElementRepository("LiteralInteger49", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Continue_result_LiteralInteger49);
								AddToElementRepository("LiteralUnlimitedNatural50", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Continue_result_LiteralUnlimitedNatural50);
								AddToElementRepository("LiteralInteger51", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Continue_result_LiteralInteger51);
							AddToElementRepository("Trigger52", BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Continue_Trigger52);
					AddToElementRepository("Tester_Tester", BehaviorPort_Signal_Tester_Tester_Tester);
						AddToElementRepository("result", BehaviorPort_Signal_Tester_Tester_Tester_result);
					AddToElementRepository("a", BehaviorPort_Signal_Tester_a);
					AddToElementRepository("test", BehaviorPort_Signal_Tester_test);
					AddToElementRepository("Generalization53", BehaviorPort_Signal_Tester_Generalization53);
					AddToElementRepository("testActivity", BehaviorPort_Signal_Tester_testActivity);
						AddToElementRepository("Call testP", BehaviorPort_Signal_Tester_testActivity_Call_testP);
							AddToElementRepository("p", BehaviorPort_Signal_Tester_testActivity_Call_testP_p);
								AddToElementRepository("LiteralUnlimitedNatural54", BehaviorPort_Signal_Tester_testActivity_Call_testP_p_LiteralUnlimitedNatural54);
								AddToElementRepository("LiteralInteger55", BehaviorPort_Signal_Tester_testActivity_Call_testP_p_LiteralInteger55);
								AddToElementRepository("LiteralInteger56", BehaviorPort_Signal_Tester_testActivity_Call_testP_p_LiteralInteger56);
						AddToElementRepository("this.a", BehaviorPort_Signal_Tester_testActivity_this_a);
							AddToElementRepository("object", BehaviorPort_Signal_Tester_testActivity_this_a_object);
								AddToElementRepository("LiteralUnlimitedNatural57", BehaviorPort_Signal_Tester_testActivity_this_a_object_LiteralUnlimitedNatural57);
								AddToElementRepository("LiteralInteger58", BehaviorPort_Signal_Tester_testActivity_this_a_object_LiteralInteger58);
							AddToElementRepository("result", BehaviorPort_Signal_Tester_testActivity_this_a_result);
								AddToElementRepository("LiteralInteger59", BehaviorPort_Signal_Tester_testActivity_this_a_result_LiteralInteger59);
								AddToElementRepository("LiteralUnlimitedNatural60", BehaviorPort_Signal_Tester_testActivity_this_a_result_LiteralUnlimitedNatural60);
						AddToElementRepository("ObjectFlow61", BehaviorPort_Signal_Tester_testActivity_ObjectFlow61);
							AddToElementRepository("LiteralBoolean62", BehaviorPort_Signal_Tester_testActivity_ObjectFlow61_LiteralBoolean62);
							AddToElementRepository("LiteralInteger63", BehaviorPort_Signal_Tester_testActivity_ObjectFlow61_LiteralInteger63);
						AddToElementRepository("ObjectFlow64", BehaviorPort_Signal_Tester_testActivity_ObjectFlow64);
							AddToElementRepository("LiteralBoolean65", BehaviorPort_Signal_Tester_testActivity_ObjectFlow64_LiteralBoolean65);
							AddToElementRepository("LiteralInteger66", BehaviorPort_Signal_Tester_testActivity_ObjectFlow64_LiteralInteger66);
						AddToElementRepository("ObjectFlow67", BehaviorPort_Signal_Tester_testActivity_ObjectFlow67);
							AddToElementRepository("LiteralBoolean68", BehaviorPort_Signal_Tester_testActivity_ObjectFlow67_LiteralBoolean68);
							AddToElementRepository("LiteralInteger69", BehaviorPort_Signal_Tester_testActivity_ObjectFlow67_LiteralInteger69);
						AddToElementRepository("this", BehaviorPort_Signal_Tester_testActivity_this);
							AddToElementRepository("result", BehaviorPort_Signal_Tester_testActivity_this_result);
								AddToElementRepository("LiteralInteger70", BehaviorPort_Signal_Tester_testActivity_this_result_LiteralInteger70);
								AddToElementRepository("LiteralUnlimitedNatural71", BehaviorPort_Signal_Tester_testActivity_this_result_LiteralUnlimitedNatural71);
						AddToElementRepository("this.a.p", BehaviorPort_Signal_Tester_testActivity_this_a_p);
							AddToElementRepository("object", BehaviorPort_Signal_Tester_testActivity_this_a_p_object);
								AddToElementRepository("LiteralUnlimitedNatural72", BehaviorPort_Signal_Tester_testActivity_this_a_p_object_LiteralUnlimitedNatural72);
								AddToElementRepository("LiteralInteger73", BehaviorPort_Signal_Tester_testActivity_this_a_p_object_LiteralInteger73);
							AddToElementRepository("result", BehaviorPort_Signal_Tester_testActivity_this_a_p_result);
								AddToElementRepository("LiteralInteger74", BehaviorPort_Signal_Tester_testActivity_this_a_p_result_LiteralInteger74);
								AddToElementRepository("LiteralUnlimitedNatural75", BehaviorPort_Signal_Tester_testActivity_this_a_p_result_LiteralUnlimitedNatural75);
						AddToElementRepository("testP", BehaviorPort_Signal_Tester_testActivity_testP);
							AddToElementRepository("p", BehaviorPort_Signal_Tester_testActivity_testP_p);
				AddToElementRepository("S", BehaviorPort_Signal_S);
					AddToElementRepository("v", BehaviorPort_Signal_S_v);
					AddToElementRepository("t", BehaviorPort_Signal_S_t);
				AddToElementRepository("AbstractTester", BehaviorPort_Signal_AbstractTester);
					AddToElementRepository("Continue", BehaviorPort_Signal_AbstractTester_Continue);
					AddToElementRepository("Start", BehaviorPort_Signal_AbstractTester_Start);
					AddToElementRepository("test", BehaviorPort_Signal_AbstractTester_test);
				AddToElementRepository("I", BehaviorPort_Signal_I);
					AddToElementRepository("S", BehaviorPort_Signal_I_S);
				AddToElementRepository("A", BehaviorPort_Signal_A);
					AddToElementRepository("AClassifierBehavior", BehaviorPort_Signal_A_AClassifierBehavior);
						AddToElementRepository("this", BehaviorPort_Signal_A_AClassifierBehavior_this);
							AddToElementRepository("result", BehaviorPort_Signal_A_AClassifierBehavior_this_result);
								AddToElementRepository("LiteralUnlimitedNatural76", BehaviorPort_Signal_A_AClassifierBehavior_this_result_LiteralUnlimitedNatural76);
								AddToElementRepository("LiteralInteger77", BehaviorPort_Signal_A_AClassifierBehavior_this_result_LiteralInteger77);
						AddToElementRepository("ObjectFlow78", BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow78);
							AddToElementRepository("LiteralBoolean79", BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow78_LiteralBoolean79);
							AddToElementRepository("LiteralInteger80", BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow78_LiteralInteger80);
						AddToElementRepository("Read S::v", BehaviorPort_Signal_A_AClassifierBehavior_Read_S_v);
							AddToElementRepository("result", BehaviorPort_Signal_A_AClassifierBehavior_Read_S_v_result);
								AddToElementRepository("LiteralUnlimitedNatural81", BehaviorPort_Signal_A_AClassifierBehavior_Read_S_v_result_LiteralUnlimitedNatural81);
								AddToElementRepository("LiteralInteger82", BehaviorPort_Signal_A_AClassifierBehavior_Read_S_v_result_LiteralInteger82);
							AddToElementRepository("object", BehaviorPort_Signal_A_AClassifierBehavior_Read_S_v_object);
								AddToElementRepository("LiteralUnlimitedNatural83", BehaviorPort_Signal_A_AClassifierBehavior_Read_S_v_object_LiteralUnlimitedNatural83);
								AddToElementRepository("LiteralInteger84", BehaviorPort_Signal_A_AClassifierBehavior_Read_S_v_object_LiteralInteger84);
						AddToElementRepository("ObjectFlow85", BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow85);
							AddToElementRepository("LiteralInteger86", BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow85_LiteralInteger86);
							AddToElementRepository("LiteralBoolean87", BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow85_LiteralBoolean87);
						AddToElementRepository("Initial", BehaviorPort_Signal_A_AClassifierBehavior_Initial);
						AddToElementRepository("Accept S", BehaviorPort_Signal_A_AClassifierBehavior_Accept_S);
							AddToElementRepository("result", BehaviorPort_Signal_A_AClassifierBehavior_Accept_S_result);
								AddToElementRepository("LiteralUnlimitedNatural88", BehaviorPort_Signal_A_AClassifierBehavior_Accept_S_result_LiteralUnlimitedNatural88);
								AddToElementRepository("LiteralInteger89", BehaviorPort_Signal_A_AClassifierBehavior_Accept_S_result_LiteralInteger89);
								AddToElementRepository("LiteralInteger90", BehaviorPort_Signal_A_AClassifierBehavior_Accept_S_result_LiteralInteger90);
							AddToElementRepository("Trigger91", BehaviorPort_Signal_A_AClassifierBehavior_Accept_S_Trigger91);
						AddToElementRepository("Send Continue", BehaviorPort_Signal_A_AClassifierBehavior_Send_Continue);
							AddToElementRepository("target", BehaviorPort_Signal_A_AClassifierBehavior_Send_Continue_target);
								AddToElementRepository("LiteralUnlimitedNatural92", BehaviorPort_Signal_A_AClassifierBehavior_Send_Continue_target_LiteralUnlimitedNatural92);
								AddToElementRepository("LiteralInteger93", BehaviorPort_Signal_A_AClassifierBehavior_Send_Continue_target_LiteralInteger93);
						AddToElementRepository("Read S::t", BehaviorPort_Signal_A_AClassifierBehavior_Read_S_t);
							AddToElementRepository("object", BehaviorPort_Signal_A_AClassifierBehavior_Read_S_t_object);
								AddToElementRepository("LiteralInteger94", BehaviorPort_Signal_A_AClassifierBehavior_Read_S_t_object_LiteralInteger94);
								AddToElementRepository("LiteralUnlimitedNatural95", BehaviorPort_Signal_A_AClassifierBehavior_Read_S_t_object_LiteralUnlimitedNatural95);
							AddToElementRepository("result", BehaviorPort_Signal_A_AClassifierBehavior_Read_S_t_result);
								AddToElementRepository("LiteralUnlimitedNatural96", BehaviorPort_Signal_A_AClassifierBehavior_Read_S_t_result_LiteralUnlimitedNatural96);
								AddToElementRepository("LiteralInteger97", BehaviorPort_Signal_A_AClassifierBehavior_Read_S_t_result_LiteralInteger97);
						AddToElementRepository("ObjectFlow98", BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow98);
							AddToElementRepository("LiteralBoolean99", BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow98_LiteralBoolean99);
							AddToElementRepository("LiteralInteger100", BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow98_LiteralInteger100);
						AddToElementRepository("ObjectFlow101", BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow101);
							AddToElementRepository("LiteralInteger102", BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow101_LiteralInteger102);
							AddToElementRepository("LiteralBoolean103", BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow101_LiteralBoolean103);
						AddToElementRepository("ControlFlow104", BehaviorPort_Signal_A_AClassifierBehavior_ControlFlow104);
						AddToElementRepository("ObjectFlow105", BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow105);
							AddToElementRepository("LiteralInteger106", BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow105_LiteralInteger106);
							AddToElementRepository("LiteralBoolean107", BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow105_LiteralBoolean107);
						AddToElementRepository("Set this.p", BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p);
							AddToElementRepository("result", BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p_result);
								AddToElementRepository("LiteralInteger108", BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p_result_LiteralInteger108);
								AddToElementRepository("LiteralUnlimitedNatural109", BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p_result_LiteralUnlimitedNatural109);
							AddToElementRepository("object", BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p_object);
								AddToElementRepository("LiteralUnlimitedNatural110", BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p_object_LiteralUnlimitedNatural110);
								AddToElementRepository("LiteralInteger111", BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p_object_LiteralInteger111);
							AddToElementRepository("value", BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p_value);
								AddToElementRepository("LiteralUnlimitedNatural112", BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p_value_LiteralUnlimitedNatural112);
								AddToElementRepository("LiteralInteger113", BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p_value_LiteralInteger113);
						AddToElementRepository("ObjectFlow114", BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow114);
							AddToElementRepository("LiteralInteger115", BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow114_LiteralInteger115);
							AddToElementRepository("LiteralBoolean116", BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow114_LiteralBoolean116);
						AddToElementRepository("ControlFlow117", BehaviorPort_Signal_A_AClassifierBehavior_ControlFlow117);
						AddToElementRepository("Fork S", BehaviorPort_Signal_A_AClassifierBehavior_Fork_S);
					AddToElementRepository("IRealization", BehaviorPort_Signal_A_IRealization);
					AddToElementRepository("S", BehaviorPort_Signal_A_S);
					AddToElementRepository("p", BehaviorPort_Signal_A_p);
					AddToElementRepository("q", BehaviorPort_Signal_A_q);
					AddToElementRepository("A_A", BehaviorPort_Signal_A_A_A);
						AddToElementRepository("result", BehaviorPort_Signal_A_A_A_result);
				AddToElementRepository("SignalEventContinue", BehaviorPort_Signal_SignalEventContinue);
				AddToElementRepository("Start", BehaviorPort_Signal_Start);
				AddToElementRepository("Continue", BehaviorPort_Signal_Continue);
				AddToElementRepository("SignalEventS", BehaviorPort_Signal_SignalEventS);
				AddToElementRepository("IImpl", BehaviorPort_Signal_IImpl);
					AddToElementRepository("IRealization", BehaviorPort_Signal_IImpl_IRealization);
					AddToElementRepository("S", BehaviorPort_Signal_IImpl_S);
				AddToElementRepository("main", BehaviorPort_Signal_main);
					AddToElementRepository("ObjectFlow118", BehaviorPort_Signal_main_ObjectFlow118);
						AddToElementRepository("LiteralBoolean119", BehaviorPort_Signal_main_ObjectFlow118_LiteralBoolean119);
						AddToElementRepository("LiteralInteger120", BehaviorPort_Signal_main_ObjectFlow118_LiteralInteger120);
					AddToElementRepository("ObjectFlow121", BehaviorPort_Signal_main_ObjectFlow121);
						AddToElementRepository("LiteralBoolean122", BehaviorPort_Signal_main_ObjectFlow121_LiteralBoolean122);
						AddToElementRepository("LiteralInteger123", BehaviorPort_Signal_main_ObjectFlow121_LiteralInteger123);
					AddToElementRepository("Create Tester", BehaviorPort_Signal_main_Create_Tester);
						AddToElementRepository("result", BehaviorPort_Signal_main_Create_Tester_result);
							AddToElementRepository("LiteralUnlimitedNatural124", BehaviorPort_Signal_main_Create_Tester_result_LiteralUnlimitedNatural124);
							AddToElementRepository("LiteralInteger125", BehaviorPort_Signal_main_Create_Tester_result_LiteralInteger125);
					AddToElementRepository("Start Tester", BehaviorPort_Signal_main_Start_Tester);
						AddToElementRepository("object", BehaviorPort_Signal_main_Start_Tester_object);
							AddToElementRepository("LiteralInteger126", BehaviorPort_Signal_main_Start_Tester_object_LiteralInteger126);
							AddToElementRepository("LiteralUnlimitedNatural127", BehaviorPort_Signal_main_Start_Tester_object_LiteralUnlimitedNatural127);
					AddToElementRepository("Fork Tester", BehaviorPort_Signal_main_Fork_Tester);
					AddToElementRepository("ObjectFlow128", BehaviorPort_Signal_main_ObjectFlow128);
						AddToElementRepository("LiteralBoolean129", BehaviorPort_Signal_main_ObjectFlow128_LiteralBoolean129);
						AddToElementRepository("LiteralInteger130", BehaviorPort_Signal_main_ObjectFlow128_LiteralInteger130);
					AddToElementRepository("ControlFlow131", BehaviorPort_Signal_main_ControlFlow131);
					AddToElementRepository("Tester()", BehaviorPort_Signal_main_Tester_);
						AddToElementRepository("target", BehaviorPort_Signal_main_Tester__target);
							AddToElementRepository("LiteralInteger132", BehaviorPort_Signal_main_Tester__target_LiteralInteger132);
							AddToElementRepository("LiteralUnlimitedNatural133", BehaviorPort_Signal_main_Tester__target_LiteralUnlimitedNatural133);
						AddToElementRepository("result", BehaviorPort_Signal_main_Tester__result);
							AddToElementRepository("LiteralInteger134", BehaviorPort_Signal_main_Tester__result_LiteralInteger134);
							AddToElementRepository("LiteralUnlimitedNatural135", BehaviorPort_Signal_main_Tester__result_LiteralUnlimitedNatural135);
							AddToElementRepository("LiteralInteger136", BehaviorPort_Signal_main_Tester__result_LiteralInteger136);
					AddToElementRepository("Send Start", BehaviorPort_Signal_main_Send_Start);
						AddToElementRepository("target", BehaviorPort_Signal_main_Send_Start_target);
							AddToElementRepository("LiteralInteger137", BehaviorPort_Signal_main_Send_Start_target_LiteralInteger137);
							AddToElementRepository("LiteralUnlimitedNatural138", BehaviorPort_Signal_main_Send_Start_target_LiteralUnlimitedNatural138);
					AddToElementRepository("ObjectFlow139", BehaviorPort_Signal_main_ObjectFlow139);
						AddToElementRepository("LiteralInteger140", BehaviorPort_Signal_main_ObjectFlow139_LiteralInteger140);
						AddToElementRepository("LiteralBoolean141", BehaviorPort_Signal_main_ObjectFlow139_LiteralBoolean141);

			// Initialize public members
			/*
			 * Model BehaviorPort_Signal
			 */
			BehaviorPort_Signal.SetName("BehaviorPort_Signal");
			BehaviorPort_Signal.SetVisibility(VisibilityKind.public_);
				// SignalEvent SignalEventStart
				BehaviorPort_Signal_SignalEventStart.SetName("SignalEventStart");
				BehaviorPort_Signal_SignalEventStart.SetVisibility(VisibilityKind.public_);
				BehaviorPort_Signal_SignalEventStart.SetSignal(BehaviorPort_Signal_Start);
			BehaviorPort_Signal.AddPackagedElement(BehaviorPort_Signal_SignalEventStart);
				// Class Tester
				BehaviorPort_Signal_Tester.SetName("Tester");
				BehaviorPort_Signal_Tester.SetVisibility(VisibilityKind.public_);
				
					// Generalization to AbstractTester
					BehaviorPort_Signal_Tester_Generalization53.SetGeneral(BehaviorPort_Signal_AbstractTester);
				BehaviorPort_Signal_Tester.AddGeneralization(BehaviorPort_Signal_Tester_Generalization53);
					// Property a
					BehaviorPort_Signal_Tester_a.SetName("a");
					BehaviorPort_Signal_Tester_a.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Signal_Tester_a.SetType(BehaviorPort_Signal_A);
					BehaviorPort_Signal_Tester_a.SetAggregation(AggregationKind.composite);
				BehaviorPort_Signal_Tester.AddOwnedAttribute(BehaviorPort_Signal_Tester_a);
				BehaviorPort_Signal_Tester.SetClassifierBehavior(BehaviorPort_Signal_Tester_TesterClassifierBehavior);
					// Activity TesterClassifierBehavior
					BehaviorPort_Signal_Tester_TesterClassifierBehavior.SetName("TesterClassifierBehavior");
					BehaviorPort_Signal_Tester_TesterClassifierBehavior.SetVisibility(VisibilityKind.public_);
						// ReadStructuralFeatureAction Read this.a
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a.SetName("Read this.a");
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a.SetStructuralFeature(BehaviorPort_Signal_Tester_a);
							// InputPin object
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_object.SetName("object");
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_object.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_object.SetType(BehaviorPort_Signal_Tester);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a.SetObject(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_object);
							// OutputPin result
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_result.SetName("result");
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_result.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_result.SetType(BehaviorPort_Signal_A);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a.SetResult(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_result);
					BehaviorPort_Signal_Tester_TesterClassifierBehavior.AddNode(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a);
						// SendSignalAction Send S
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S.SetName("Send S");
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S.SetSignal(BehaviorPort_Signal_S);
							// InputPin target
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_target.SetName("target");
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_target.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_target.SetType(BehaviorPort_Signal_IImpl);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S.SetTarget(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_target);
							// InputPin v
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_v.SetName("v");
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_v.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S.AddArgument(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_v);
							// InputPin t
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_t.SetName("t");
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_t.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_t.SetType(BehaviorPort_Signal_AbstractTester);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S.AddArgument(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_t);
					BehaviorPort_Signal_Tester_TesterClassifierBehavior.AddNode(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S);
						// CallOperationAction Call test()
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Call_test_.SetName("Call test()");
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Call_test_.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Call_test_.SetOperation(BehaviorPort_Signal_Tester_test);
							// InputPin target
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Call_test__target.SetName("target");
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Call_test__target.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Call_test__target.SetType(BehaviorPort_Signal_Tester);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Call_test_.SetTarget(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Call_test__target);
					BehaviorPort_Signal_Tester_TesterClassifierBehavior.AddNode(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Call_test_);
						// ForkNode Fork this
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Fork_this.SetName("Fork this");
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Fork_this.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Signal_Tester_TesterClassifierBehavior.AddNode(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Fork_this);
						// AcceptEventAction Accept Start
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Start.SetName("Accept Start");
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Start.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Start_result.SetName("result");
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Start_result.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Start_result.SetType(BehaviorPort_Signal_Start);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Start.AddResult(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Start_result);
							// Trigger Trigger42
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger42.SetName("Trigger42");
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger42.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger42.SetEvent(BehaviorPort_Signal_SignalEventStart);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Start.AddTrigger(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger42);
					BehaviorPort_Signal_Tester_TesterClassifierBehavior.AddNode(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Start);
						// InitialNode Initial
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Initial.SetName("Initial");
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Initial.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Signal_Tester_TesterClassifierBehavior.AddNode(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Initial);
						// ReadSelfAction this
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_this.SetName("this");
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_this_result.SetName("result");
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_this_result.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_this_result.SetType(BehaviorPort_Signal_Tester);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_this.SetResult(BehaviorPort_Signal_Tester_TesterClassifierBehavior_this_result);
					BehaviorPort_Signal_Tester_TesterClassifierBehavior.AddNode(BehaviorPort_Signal_Tester_TesterClassifierBehavior_this);
						// ReadStructuralFeatureAction Read this.a.q
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_q.SetName("Read this.a.q");
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_q.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_q.SetStructuralFeature(BehaviorPort_Signal_A_q);
							// InputPin object
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_q_object.SetName("object");
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_q_object.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_q_object.SetType(BehaviorPort_Signal_A);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_q.SetObject(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_q_object);
							// OutputPin result
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_q_result.SetName("result");
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_q_result.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_q_result.SetType(BehaviorPort_Signal_IImpl);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_q.SetResult(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_q_result);
					BehaviorPort_Signal_Tester_TesterClassifierBehavior.AddNode(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_q);
						// ValueSpecificationAction Value 4
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Value_4.SetName("Value 4");
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Value_4.SetVisibility(VisibilityKind.public_);
							// LiteralInteger LiteralInteger46
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Value_4_LiteralInteger46.SetName("LiteralInteger46");
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Value_4_LiteralInteger46.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Value_4_LiteralInteger46.SetValue(4);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Value_4.SetValue(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Value_4_LiteralInteger46);
							// OutputPin result
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Value_4_result.SetName("result");
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Value_4_result.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Value_4_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Value_4.SetResult(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Value_4_result);
					BehaviorPort_Signal_Tester_TesterClassifierBehavior.AddNode(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Value_4);
						// AcceptEventAction Accept Continue
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Continue.SetName("Accept Continue");
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Continue.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Continue_result.SetName("result");
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Continue_result.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Continue_result.SetType(BehaviorPort_Signal_Continue);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Continue.AddResult(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Continue_result);
							// Trigger Trigger52
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Continue_Trigger52.SetName("Trigger52");
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Continue_Trigger52.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Continue_Trigger52.SetEvent(BehaviorPort_Signal_SignalEventContinue);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Continue.AddTrigger(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Continue_Trigger52);
					BehaviorPort_Signal_Tester_TesterClassifierBehavior.AddNode(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Continue);
						// ControlFlow ControlFlow22 from Initial to Accept Start
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ControlFlow22.SetName("ControlFlow22");
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ControlFlow22.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ControlFlow22.SetSource(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Initial);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ControlFlow22.SetTarget(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Start);
					BehaviorPort_Signal_Tester_TesterClassifierBehavior.AddEdge(BehaviorPort_Signal_Tester_TesterClassifierBehavior_ControlFlow22);
						// ObjectFlow ObjectFlow0 from result to object
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow0.SetName("ObjectFlow0");
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow0.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow0.SetSource(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_result);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow0.SetTarget(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_q_object);
							// LiteralBoolean LiteralBoolean2
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow0_LiteralBoolean2.SetName("LiteralBoolean2");
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow0_LiteralBoolean2.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow0_LiteralBoolean2.SetValue(true);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow0.SetGuard(BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow0_LiteralBoolean2);
					BehaviorPort_Signal_Tester_TesterClassifierBehavior.AddEdge(BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow0);
						// ObjectFlow ObjectFlow27 from result to Fork this
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow27.SetName("ObjectFlow27");
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow27.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow27.SetSource(BehaviorPort_Signal_Tester_TesterClassifierBehavior_this_result);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow27.SetTarget(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Fork_this);
							// LiteralBoolean LiteralBoolean29
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow27_LiteralBoolean29.SetName("LiteralBoolean29");
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow27_LiteralBoolean29.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow27_LiteralBoolean29.SetValue(true);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow27.SetGuard(BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow27_LiteralBoolean29);
					BehaviorPort_Signal_Tester_TesterClassifierBehavior.AddEdge(BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow27);
						// ObjectFlow ObjectFlow30 from Fork this to target
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow30.SetName("ObjectFlow30");
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow30.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow30.SetSource(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Fork_this);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow30.SetTarget(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Call_test__target);
							// LiteralBoolean LiteralBoolean31
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow30_LiteralBoolean31.SetName("LiteralBoolean31");
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow30_LiteralBoolean31.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow30_LiteralBoolean31.SetValue(true);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow30.SetGuard(BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow30_LiteralBoolean31);
					BehaviorPort_Signal_Tester_TesterClassifierBehavior.AddEdge(BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow30);
						// ObjectFlow ObjectFlow33 from Fork this to t
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow33.SetName("ObjectFlow33");
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow33.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow33.SetSource(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Fork_this);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow33.SetTarget(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_t);
							// LiteralBoolean LiteralBoolean34
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow33_LiteralBoolean34.SetName("LiteralBoolean34");
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow33_LiteralBoolean34.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow33_LiteralBoolean34.SetValue(true);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow33.SetGuard(BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow33_LiteralBoolean34);
					BehaviorPort_Signal_Tester_TesterClassifierBehavior.AddEdge(BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow33);
						// ObjectFlow ObjectFlow36 from result to v
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow36.SetName("ObjectFlow36");
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow36.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow36.SetSource(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Value_4_result);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow36.SetTarget(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_v);
							// LiteralBoolean LiteralBoolean38
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow36_LiteralBoolean38.SetName("LiteralBoolean38");
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow36_LiteralBoolean38.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow36_LiteralBoolean38.SetValue(true);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow36.SetGuard(BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow36_LiteralBoolean38);
					BehaviorPort_Signal_Tester_TesterClassifierBehavior.AddEdge(BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow36);
						// ObjectFlow ObjectFlow11 from result to target
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow11.SetName("ObjectFlow11");
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow11.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow11.SetSource(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_q_result);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow11.SetTarget(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Send_S_target);
							// LiteralBoolean LiteralBoolean13
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow11_LiteralBoolean13.SetName("LiteralBoolean13");
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow11_LiteralBoolean13.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow11_LiteralBoolean13.SetValue(true);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow11.SetGuard(BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow11_LiteralBoolean13);
					BehaviorPort_Signal_Tester_TesterClassifierBehavior.AddEdge(BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow11);
						// ObjectFlow ObjectFlow14 from Fork this to object
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow14.SetName("ObjectFlow14");
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow14.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow14.SetSource(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Fork_this);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow14.SetTarget(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Read_this_a_object);
							// LiteralBoolean LiteralBoolean15
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow14_LiteralBoolean15.SetName("LiteralBoolean15");
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow14_LiteralBoolean15.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow14_LiteralBoolean15.SetValue(true);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow14.SetGuard(BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow14_LiteralBoolean15);
					BehaviorPort_Signal_Tester_TesterClassifierBehavior.AddEdge(BehaviorPort_Signal_Tester_TesterClassifierBehavior_ObjectFlow14);
						// ControlFlow ControlFlow45 from Accept Start to this
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ControlFlow45.SetName("ControlFlow45");
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ControlFlow45.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ControlFlow45.SetSource(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Start);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ControlFlow45.SetTarget(BehaviorPort_Signal_Tester_TesterClassifierBehavior_this);
					BehaviorPort_Signal_Tester_TesterClassifierBehavior.AddEdge(BehaviorPort_Signal_Tester_TesterClassifierBehavior_ControlFlow45);
						// ControlFlow ControlFlow17 from Accept Continue to Call test()
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ControlFlow17.SetName("ControlFlow17");
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ControlFlow17.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ControlFlow17.SetSource(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Accept_Continue);
						BehaviorPort_Signal_Tester_TesterClassifierBehavior_ControlFlow17.SetTarget(BehaviorPort_Signal_Tester_TesterClassifierBehavior_Call_test_);
					BehaviorPort_Signal_Tester_TesterClassifierBehavior.AddEdge(BehaviorPort_Signal_Tester_TesterClassifierBehavior_ControlFlow17);
				BehaviorPort_Signal_Tester.AddOwnedBehavior(BehaviorPort_Signal_Tester_TesterClassifierBehavior);
					// Activity testActivity
					BehaviorPort_Signal_Tester_testActivity.SetName("testActivity");
					BehaviorPort_Signal_Tester_testActivity.SetVisibility(VisibilityKind.public_);
					// FunctionBehavior testP
						BehaviorPort_Signal_Tester_testActivity_testP.SetName("testP");
						BehaviorPort_Signal_Tester_testActivity_testP.SetVisibility(VisibilityKind.public_);
						
							// Parameter p
							BehaviorPort_Signal_Tester_testActivity_testP_p.SetName("p");
							BehaviorPort_Signal_Tester_testActivity_testP_p.SetVisibility(VisibilityKind.public_);
							
							BehaviorPort_Signal_Tester_testActivity_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						BehaviorPort_Signal_Tester_testActivity_testP.AddOwnedParameter(BehaviorPort_Signal_Tester_testActivity_testP_p);
						BehaviorPort_Signal_Tester_testActivity_testP.AddLanguage("C#");
						BehaviorPort_Signal_Tester_testActivity_testP.AddLanguage("Using");
						BehaviorPort_Signal_Tester_testActivity_testP.AddBody("Console.WriteLine(\"Asserting a.p == 4\");  	// Test parameter p 	int p = ((IntegerValue)inputParameters.ElementAt(0).values.ElementAt(0)).value; 	Debug.Println(\"[doBody] argument p = \" + p); 	 	Console.WriteLine(\"a.p == \" + p); 	Console.Write(\"Signal delegated to classifier behavior: \");  	if(p == 4) 	{ 		Console.ForegroundColor = ConsoleColor.Green; 		Console.WriteLine(\"Assertion successful.\"); 	} 	else 	{ 		Console.ForegroundColor = ConsoleColor.Red; 		Console.WriteLine(\"Assertion failed!\"); 	}  	Console.ResetColor();");
						BehaviorPort_Signal_Tester_testActivity_testP.AddBody("using fuml.semantics.simpleclassifiers;");
					BehaviorPort_Signal_Tester_testActivity.AddOwnedBehavior(BehaviorPort_Signal_Tester_testActivity_testP);
						// CallBehaviorAction Call testP
						BehaviorPort_Signal_Tester_testActivity_Call_testP.SetName("Call testP");
						BehaviorPort_Signal_Tester_testActivity_Call_testP.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Signal_Tester_testActivity_Call_testP.SetBehavior(BehaviorPort_Signal_Tester_testActivity_testP);
							// InputPin p
							BehaviorPort_Signal_Tester_testActivity_Call_testP_p.SetName("p");
							BehaviorPort_Signal_Tester_testActivity_Call_testP_p.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_Tester_testActivity_Call_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						BehaviorPort_Signal_Tester_testActivity_Call_testP.AddArgument(BehaviorPort_Signal_Tester_testActivity_Call_testP_p);
					BehaviorPort_Signal_Tester_testActivity.AddNode(BehaviorPort_Signal_Tester_testActivity_Call_testP);
						// ReadStructuralFeatureAction this.a
						BehaviorPort_Signal_Tester_testActivity_this_a.SetName("this.a");
						BehaviorPort_Signal_Tester_testActivity_this_a.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Signal_Tester_testActivity_this_a.SetStructuralFeature(BehaviorPort_Signal_Tester_a);
							// InputPin object
							BehaviorPort_Signal_Tester_testActivity_this_a_object.SetName("object");
							BehaviorPort_Signal_Tester_testActivity_this_a_object.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_Tester_testActivity_this_a_object.SetType(BehaviorPort_Signal_Tester);
						BehaviorPort_Signal_Tester_testActivity_this_a.SetObject(BehaviorPort_Signal_Tester_testActivity_this_a_object);
							// OutputPin result
							BehaviorPort_Signal_Tester_testActivity_this_a_result.SetName("result");
							BehaviorPort_Signal_Tester_testActivity_this_a_result.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_Tester_testActivity_this_a_result.SetType(BehaviorPort_Signal_A);
						BehaviorPort_Signal_Tester_testActivity_this_a.SetResult(BehaviorPort_Signal_Tester_testActivity_this_a_result);
					BehaviorPort_Signal_Tester_testActivity.AddNode(BehaviorPort_Signal_Tester_testActivity_this_a);
						// ReadSelfAction this
						BehaviorPort_Signal_Tester_testActivity_this.SetName("this");
						BehaviorPort_Signal_Tester_testActivity_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							BehaviorPort_Signal_Tester_testActivity_this_result.SetName("result");
							BehaviorPort_Signal_Tester_testActivity_this_result.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_Tester_testActivity_this_result.SetType(BehaviorPort_Signal_Tester);
						BehaviorPort_Signal_Tester_testActivity_this.SetResult(BehaviorPort_Signal_Tester_testActivity_this_result);
					BehaviorPort_Signal_Tester_testActivity.AddNode(BehaviorPort_Signal_Tester_testActivity_this);
						// ReadStructuralFeatureAction this.a.p
						BehaviorPort_Signal_Tester_testActivity_this_a_p.SetName("this.a.p");
						BehaviorPort_Signal_Tester_testActivity_this_a_p.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Signal_Tester_testActivity_this_a_p.SetStructuralFeature(BehaviorPort_Signal_A_p);
							// InputPin object
							BehaviorPort_Signal_Tester_testActivity_this_a_p_object.SetName("object");
							BehaviorPort_Signal_Tester_testActivity_this_a_p_object.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_Tester_testActivity_this_a_p_object.SetType(BehaviorPort_Signal_A);
						BehaviorPort_Signal_Tester_testActivity_this_a_p.SetObject(BehaviorPort_Signal_Tester_testActivity_this_a_p_object);
							// OutputPin result
							BehaviorPort_Signal_Tester_testActivity_this_a_p_result.SetName("result");
							BehaviorPort_Signal_Tester_testActivity_this_a_p_result.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_Tester_testActivity_this_a_p_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						BehaviorPort_Signal_Tester_testActivity_this_a_p.SetResult(BehaviorPort_Signal_Tester_testActivity_this_a_p_result);
					BehaviorPort_Signal_Tester_testActivity.AddNode(BehaviorPort_Signal_Tester_testActivity_this_a_p);
						// ObjectFlow ObjectFlow61 from result to object
						BehaviorPort_Signal_Tester_testActivity_ObjectFlow61.SetName("ObjectFlow61");
						BehaviorPort_Signal_Tester_testActivity_ObjectFlow61.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Signal_Tester_testActivity_ObjectFlow61.SetSource(BehaviorPort_Signal_Tester_testActivity_this_a_result);
						BehaviorPort_Signal_Tester_testActivity_ObjectFlow61.SetTarget(BehaviorPort_Signal_Tester_testActivity_this_a_p_object);
							// LiteralBoolean LiteralBoolean62
							BehaviorPort_Signal_Tester_testActivity_ObjectFlow61_LiteralBoolean62.SetName("LiteralBoolean62");
							BehaviorPort_Signal_Tester_testActivity_ObjectFlow61_LiteralBoolean62.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_Tester_testActivity_ObjectFlow61_LiteralBoolean62.SetValue(true);
						BehaviorPort_Signal_Tester_testActivity_ObjectFlow61.SetGuard(BehaviorPort_Signal_Tester_testActivity_ObjectFlow61_LiteralBoolean62);
					BehaviorPort_Signal_Tester_testActivity.AddEdge(BehaviorPort_Signal_Tester_testActivity_ObjectFlow61);
						// ObjectFlow ObjectFlow64 from result to object
						BehaviorPort_Signal_Tester_testActivity_ObjectFlow64.SetName("ObjectFlow64");
						BehaviorPort_Signal_Tester_testActivity_ObjectFlow64.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Signal_Tester_testActivity_ObjectFlow64.SetSource(BehaviorPort_Signal_Tester_testActivity_this_result);
						BehaviorPort_Signal_Tester_testActivity_ObjectFlow64.SetTarget(BehaviorPort_Signal_Tester_testActivity_this_a_object);
							// LiteralBoolean LiteralBoolean65
							BehaviorPort_Signal_Tester_testActivity_ObjectFlow64_LiteralBoolean65.SetName("LiteralBoolean65");
							BehaviorPort_Signal_Tester_testActivity_ObjectFlow64_LiteralBoolean65.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_Tester_testActivity_ObjectFlow64_LiteralBoolean65.SetValue(true);
						BehaviorPort_Signal_Tester_testActivity_ObjectFlow64.SetGuard(BehaviorPort_Signal_Tester_testActivity_ObjectFlow64_LiteralBoolean65);
					BehaviorPort_Signal_Tester_testActivity.AddEdge(BehaviorPort_Signal_Tester_testActivity_ObjectFlow64);
						// ObjectFlow ObjectFlow67 from result to p
						BehaviorPort_Signal_Tester_testActivity_ObjectFlow67.SetName("ObjectFlow67");
						BehaviorPort_Signal_Tester_testActivity_ObjectFlow67.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Signal_Tester_testActivity_ObjectFlow67.SetSource(BehaviorPort_Signal_Tester_testActivity_this_a_p_result);
						BehaviorPort_Signal_Tester_testActivity_ObjectFlow67.SetTarget(BehaviorPort_Signal_Tester_testActivity_Call_testP_p);
							// LiteralBoolean LiteralBoolean68
							BehaviorPort_Signal_Tester_testActivity_ObjectFlow67_LiteralBoolean68.SetName("LiteralBoolean68");
							BehaviorPort_Signal_Tester_testActivity_ObjectFlow67_LiteralBoolean68.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_Tester_testActivity_ObjectFlow67_LiteralBoolean68.SetValue(true);
						BehaviorPort_Signal_Tester_testActivity_ObjectFlow67.SetGuard(BehaviorPort_Signal_Tester_testActivity_ObjectFlow67_LiteralBoolean68);
					BehaviorPort_Signal_Tester_testActivity.AddEdge(BehaviorPort_Signal_Tester_testActivity_ObjectFlow67);
				BehaviorPort_Signal_Tester.AddOwnedBehavior(BehaviorPort_Signal_Tester_testActivity);
				
				BehaviorPort_Signal_Tester.SetIsActive(true);
					// Operation Tester_Tester
					BehaviorPort_Signal_Tester_Tester_Tester.SetName("Tester_Tester");
					BehaviorPort_Signal_Tester_Tester_Tester.SetVisibility(VisibilityKind.public_);
						// Parameter result
						BehaviorPort_Signal_Tester_Tester_Tester_result.SetName("result");
						BehaviorPort_Signal_Tester_Tester_Tester_result.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Signal_Tester_Tester_Tester_result.SetType(BehaviorPort_Signal_Tester);
						BehaviorPort_Signal_Tester_Tester_Tester_result.SetDirection(ParameterDirectionKind.return_);
					BehaviorPort_Signal_Tester_Tester_Tester.AddOwnedParameter(BehaviorPort_Signal_Tester_Tester_Tester_result);
					BehaviorPort_Signal_Tester_Tester_Tester.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				BehaviorPort_Signal_Tester.AddOwnedOperation(BehaviorPort_Signal_Tester_Tester_Tester);
					// Operation test
					BehaviorPort_Signal_Tester_test.SetName("test");
					BehaviorPort_Signal_Tester_test.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Signal_Tester_test.AddMethod(BehaviorPort_Signal_Tester_testActivity);
					BehaviorPort_Signal_Tester_test.AddRedefinedOperation(BehaviorPort_Signal_AbstractTester_test);
				BehaviorPort_Signal_Tester.AddOwnedOperation(BehaviorPort_Signal_Tester_test);
			BehaviorPort_Signal.AddPackagedElement(BehaviorPort_Signal_Tester);
				// Signal S
				BehaviorPort_Signal_S.SetName("S");
				BehaviorPort_Signal_S.SetVisibility(VisibilityKind.public_);
				
					// Property v
					BehaviorPort_Signal_S_v.SetName("v");
					BehaviorPort_Signal_S_v.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Signal_S_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
				BehaviorPort_Signal_S.AddOwnedAttribute(BehaviorPort_Signal_S_v);
					// Property t
					BehaviorPort_Signal_S_t.SetName("t");
					BehaviorPort_Signal_S_t.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Signal_S_t.SetType(BehaviorPort_Signal_AbstractTester);
				BehaviorPort_Signal_S.AddOwnedAttribute(BehaviorPort_Signal_S_t);
			BehaviorPort_Signal.AddPackagedElement(BehaviorPort_Signal_S);
				// Class AbstractTester
				BehaviorPort_Signal_AbstractTester.SetName("AbstractTester");
				BehaviorPort_Signal_AbstractTester.SetVisibility(VisibilityKind.public_);
				
				BehaviorPort_Signal_AbstractTester.SetIsAbstract(true);
				
				
				BehaviorPort_Signal_AbstractTester.SetIsActive(true);
					// Operation test
					BehaviorPort_Signal_AbstractTester_test.SetName("test");
					BehaviorPort_Signal_AbstractTester_test.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Signal_AbstractTester_test.SetIsAbstract(true);
				BehaviorPort_Signal_AbstractTester.AddOwnedOperation(BehaviorPort_Signal_AbstractTester_test);
					// Reception Continue
					BehaviorPort_Signal_AbstractTester_Continue.SetName("Continue");
					BehaviorPort_Signal_AbstractTester_Continue.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Signal_AbstractTester_Continue.SetSignal(BehaviorPort_Signal_Continue);
				BehaviorPort_Signal_AbstractTester.AddOwnedReception(BehaviorPort_Signal_AbstractTester_Continue);
					// Reception Start
					BehaviorPort_Signal_AbstractTester_Start.SetName("Start");
					BehaviorPort_Signal_AbstractTester_Start.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Signal_AbstractTester_Start.SetSignal(BehaviorPort_Signal_Start);
				BehaviorPort_Signal_AbstractTester.AddOwnedReception(BehaviorPort_Signal_AbstractTester_Start);
			BehaviorPort_Signal.AddPackagedElement(BehaviorPort_Signal_AbstractTester);
				// Interface I
				BehaviorPort_Signal_I.SetName("I");
				BehaviorPort_Signal_I.SetVisibility(VisibilityKind.public_);
					// Reception S
					BehaviorPort_Signal_I_S.SetName("S");
					BehaviorPort_Signal_I_S.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Signal_I_S.SetSignal(BehaviorPort_Signal_S);
				BehaviorPort_Signal_I.AddOwnedReception(BehaviorPort_Signal_I_S);
			BehaviorPort_Signal.AddPackagedElement(BehaviorPort_Signal_I);
				// Class A
				BehaviorPort_Signal_A.SetName("A");
				BehaviorPort_Signal_A.SetVisibility(VisibilityKind.public_);
				
					// Property p
					BehaviorPort_Signal_A_p.SetName("p");
					BehaviorPort_Signal_A_p.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Signal_A_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
				BehaviorPort_Signal_A.AddOwnedAttribute(BehaviorPort_Signal_A_p);
					// Port q
					BehaviorPort_Signal_A_q.SetName("q");
					BehaviorPort_Signal_A_q.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Signal_A_q.SetType(BehaviorPort_Signal_IImpl);
					BehaviorPort_Signal_A_q.SetAggregation(AggregationKind.composite);
					BehaviorPort_Signal_A_q.isBehavior = true;
					BehaviorPort_Signal_A_q.isService = true;
					BehaviorPort_Signal_A_q.AddProvided(BehaviorPort_Signal_I);
				BehaviorPort_Signal_A.AddOwnedAttribute(BehaviorPort_Signal_A_q);
				BehaviorPort_Signal_A.SetClassifierBehavior(BehaviorPort_Signal_A_AClassifierBehavior);
					// Activity AClassifierBehavior
					BehaviorPort_Signal_A_AClassifierBehavior.SetName("AClassifierBehavior");
					BehaviorPort_Signal_A_AClassifierBehavior.SetVisibility(VisibilityKind.public_);
						// ReadSelfAction this
						BehaviorPort_Signal_A_AClassifierBehavior_this.SetName("this");
						BehaviorPort_Signal_A_AClassifierBehavior_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							BehaviorPort_Signal_A_AClassifierBehavior_this_result.SetName("result");
							BehaviorPort_Signal_A_AClassifierBehavior_this_result.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_A_AClassifierBehavior_this_result.SetType(BehaviorPort_Signal_A);
						BehaviorPort_Signal_A_AClassifierBehavior_this.SetResult(BehaviorPort_Signal_A_AClassifierBehavior_this_result);
					BehaviorPort_Signal_A_AClassifierBehavior.AddNode(BehaviorPort_Signal_A_AClassifierBehavior_this);
						// ReadStructuralFeatureAction Read S::v
						BehaviorPort_Signal_A_AClassifierBehavior_Read_S_v.SetName("Read S::v");
						BehaviorPort_Signal_A_AClassifierBehavior_Read_S_v.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Signal_A_AClassifierBehavior_Read_S_v.SetStructuralFeature(BehaviorPort_Signal_S_v);
							// InputPin object
							BehaviorPort_Signal_A_AClassifierBehavior_Read_S_v_object.SetName("object");
							BehaviorPort_Signal_A_AClassifierBehavior_Read_S_v_object.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Signal_A_AClassifierBehavior_Read_S_v.SetObject(BehaviorPort_Signal_A_AClassifierBehavior_Read_S_v_object);
							// OutputPin result
							BehaviorPort_Signal_A_AClassifierBehavior_Read_S_v_result.SetName("result");
							BehaviorPort_Signal_A_AClassifierBehavior_Read_S_v_result.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_A_AClassifierBehavior_Read_S_v_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						BehaviorPort_Signal_A_AClassifierBehavior_Read_S_v.SetResult(BehaviorPort_Signal_A_AClassifierBehavior_Read_S_v_result);
					BehaviorPort_Signal_A_AClassifierBehavior.AddNode(BehaviorPort_Signal_A_AClassifierBehavior_Read_S_v);
						// AddStructuralFeatureValueAction Set this.p
						BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p.SetName("Set this.p");
						BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p.SetStructuralFeature(BehaviorPort_Signal_A_p);
							// InputPin object
							BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p_object.SetName("object");
							BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p_object.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p_object.SetType(BehaviorPort_Signal_A);
						BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p.SetObject(BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p_object);
							// InputPin value
							BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p_value.SetName("value");
							BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p_value.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p.SetValue(BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p_value);
							// OutputPin result
							BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p_result.SetName("result");
							BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p_result.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p_result.SetType(BehaviorPort_Signal_A);
						BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p.SetResult(BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p_result);
					BehaviorPort_Signal_A_AClassifierBehavior.AddNode(BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p);
						// ForkNode Fork S
						BehaviorPort_Signal_A_AClassifierBehavior_Fork_S.SetName("Fork S");
						BehaviorPort_Signal_A_AClassifierBehavior_Fork_S.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Signal_A_AClassifierBehavior.AddNode(BehaviorPort_Signal_A_AClassifierBehavior_Fork_S);
						// InitialNode Initial
						BehaviorPort_Signal_A_AClassifierBehavior_Initial.SetName("Initial");
						BehaviorPort_Signal_A_AClassifierBehavior_Initial.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Signal_A_AClassifierBehavior.AddNode(BehaviorPort_Signal_A_AClassifierBehavior_Initial);
						// AcceptEventAction Accept S
						BehaviorPort_Signal_A_AClassifierBehavior_Accept_S.SetName("Accept S");
						BehaviorPort_Signal_A_AClassifierBehavior_Accept_S.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							BehaviorPort_Signal_A_AClassifierBehavior_Accept_S_result.SetName("result");
							BehaviorPort_Signal_A_AClassifierBehavior_Accept_S_result.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_A_AClassifierBehavior_Accept_S_result.SetType(BehaviorPort_Signal_S);
							BehaviorPort_Signal_A_AClassifierBehavior_Accept_S_result.SetIsOrdered(true);
							BehaviorPort_Signal_A_AClassifierBehavior_Accept_S_result.SetIsUnique(false);
						BehaviorPort_Signal_A_AClassifierBehavior_Accept_S.AddResult(BehaviorPort_Signal_A_AClassifierBehavior_Accept_S_result);
							// Trigger Trigger91
							BehaviorPort_Signal_A_AClassifierBehavior_Accept_S_Trigger91.SetName("Trigger91");
							BehaviorPort_Signal_A_AClassifierBehavior_Accept_S_Trigger91.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_A_AClassifierBehavior_Accept_S_Trigger91.SetEvent(BehaviorPort_Signal_SignalEventS);
						BehaviorPort_Signal_A_AClassifierBehavior_Accept_S.AddTrigger(BehaviorPort_Signal_A_AClassifierBehavior_Accept_S_Trigger91);
					BehaviorPort_Signal_A_AClassifierBehavior.AddNode(BehaviorPort_Signal_A_AClassifierBehavior_Accept_S);
						// SendSignalAction Send Continue
						BehaviorPort_Signal_A_AClassifierBehavior_Send_Continue.SetName("Send Continue");
						BehaviorPort_Signal_A_AClassifierBehavior_Send_Continue.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Signal_A_AClassifierBehavior_Send_Continue.SetSignal(BehaviorPort_Signal_Continue);
							// InputPin target
							BehaviorPort_Signal_A_AClassifierBehavior_Send_Continue_target.SetName("target");
							BehaviorPort_Signal_A_AClassifierBehavior_Send_Continue_target.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_A_AClassifierBehavior_Send_Continue_target.SetType(BehaviorPort_Signal_AbstractTester);
						BehaviorPort_Signal_A_AClassifierBehavior_Send_Continue.SetTarget(BehaviorPort_Signal_A_AClassifierBehavior_Send_Continue_target);
					BehaviorPort_Signal_A_AClassifierBehavior.AddNode(BehaviorPort_Signal_A_AClassifierBehavior_Send_Continue);
						// ReadStructuralFeatureAction Read S::t
						BehaviorPort_Signal_A_AClassifierBehavior_Read_S_t.SetName("Read S::t");
						BehaviorPort_Signal_A_AClassifierBehavior_Read_S_t.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Signal_A_AClassifierBehavior_Read_S_t.SetStructuralFeature(BehaviorPort_Signal_S_t);
							// InputPin object
							BehaviorPort_Signal_A_AClassifierBehavior_Read_S_t_object.SetName("object");
							BehaviorPort_Signal_A_AClassifierBehavior_Read_S_t_object.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Signal_A_AClassifierBehavior_Read_S_t.SetObject(BehaviorPort_Signal_A_AClassifierBehavior_Read_S_t_object);
							// OutputPin result
							BehaviorPort_Signal_A_AClassifierBehavior_Read_S_t_result.SetName("result");
							BehaviorPort_Signal_A_AClassifierBehavior_Read_S_t_result.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_A_AClassifierBehavior_Read_S_t_result.SetType(BehaviorPort_Signal_AbstractTester);
						BehaviorPort_Signal_A_AClassifierBehavior_Read_S_t.SetResult(BehaviorPort_Signal_A_AClassifierBehavior_Read_S_t_result);
					BehaviorPort_Signal_A_AClassifierBehavior.AddNode(BehaviorPort_Signal_A_AClassifierBehavior_Read_S_t);
						// ObjectFlow ObjectFlow98 from result to object
						BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow98.SetName("ObjectFlow98");
						BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow98.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow98.SetSource(BehaviorPort_Signal_A_AClassifierBehavior_this_result);
						BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow98.SetTarget(BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p_object);
							// LiteralBoolean LiteralBoolean99
							BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow98_LiteralBoolean99.SetName("LiteralBoolean99");
							BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow98_LiteralBoolean99.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow98_LiteralBoolean99.SetValue(true);
						BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow98.SetGuard(BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow98_LiteralBoolean99);
					BehaviorPort_Signal_A_AClassifierBehavior.AddEdge(BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow98);
						// ObjectFlow ObjectFlow78 from result to target
						BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow78.SetName("ObjectFlow78");
						BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow78.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow78.SetSource(BehaviorPort_Signal_A_AClassifierBehavior_Read_S_t_result);
						BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow78.SetTarget(BehaviorPort_Signal_A_AClassifierBehavior_Send_Continue_target);
							// LiteralBoolean LiteralBoolean79
							BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow78_LiteralBoolean79.SetName("LiteralBoolean79");
							BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow78_LiteralBoolean79.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow78_LiteralBoolean79.SetValue(true);
						BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow78.SetGuard(BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow78_LiteralBoolean79);
					BehaviorPort_Signal_A_AClassifierBehavior.AddEdge(BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow78);
						// ObjectFlow ObjectFlow101 from Fork S to object
						BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow101.SetName("ObjectFlow101");
						BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow101.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow101.SetSource(BehaviorPort_Signal_A_AClassifierBehavior_Fork_S);
						BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow101.SetTarget(BehaviorPort_Signal_A_AClassifierBehavior_Read_S_t_object);
							// LiteralBoolean LiteralBoolean103
							BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow101_LiteralBoolean103.SetName("LiteralBoolean103");
							BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow101_LiteralBoolean103.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow101_LiteralBoolean103.SetValue(true);
						BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow101.SetGuard(BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow101_LiteralBoolean103);
					BehaviorPort_Signal_A_AClassifierBehavior.AddEdge(BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow101);
						// ControlFlow ControlFlow104 from Set this.p to Read S::t
						BehaviorPort_Signal_A_AClassifierBehavior_ControlFlow104.SetName("ControlFlow104");
						BehaviorPort_Signal_A_AClassifierBehavior_ControlFlow104.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Signal_A_AClassifierBehavior_ControlFlow104.SetSource(BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p);
						BehaviorPort_Signal_A_AClassifierBehavior_ControlFlow104.SetTarget(BehaviorPort_Signal_A_AClassifierBehavior_Read_S_t);
					BehaviorPort_Signal_A_AClassifierBehavior.AddEdge(BehaviorPort_Signal_A_AClassifierBehavior_ControlFlow104);
						// ObjectFlow ObjectFlow105 from result to value
						BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow105.SetName("ObjectFlow105");
						BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow105.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow105.SetSource(BehaviorPort_Signal_A_AClassifierBehavior_Read_S_v_result);
						BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow105.SetTarget(BehaviorPort_Signal_A_AClassifierBehavior_Set_this_p_value);
							// LiteralBoolean LiteralBoolean107
							BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow105_LiteralBoolean107.SetName("LiteralBoolean107");
							BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow105_LiteralBoolean107.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow105_LiteralBoolean107.SetValue(true);
						BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow105.SetGuard(BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow105_LiteralBoolean107);
					BehaviorPort_Signal_A_AClassifierBehavior.AddEdge(BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow105);
						// ObjectFlow ObjectFlow114 from Fork S to object
						BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow114.SetName("ObjectFlow114");
						BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow114.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow114.SetSource(BehaviorPort_Signal_A_AClassifierBehavior_Fork_S);
						BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow114.SetTarget(BehaviorPort_Signal_A_AClassifierBehavior_Read_S_v_object);
							// LiteralBoolean LiteralBoolean116
							BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow114_LiteralBoolean116.SetName("LiteralBoolean116");
							BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow114_LiteralBoolean116.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow114_LiteralBoolean116.SetValue(true);
						BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow114.SetGuard(BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow114_LiteralBoolean116);
					BehaviorPort_Signal_A_AClassifierBehavior.AddEdge(BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow114);
						// ControlFlow ControlFlow117 from Initial to Accept S
						BehaviorPort_Signal_A_AClassifierBehavior_ControlFlow117.SetName("ControlFlow117");
						BehaviorPort_Signal_A_AClassifierBehavior_ControlFlow117.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Signal_A_AClassifierBehavior_ControlFlow117.SetSource(BehaviorPort_Signal_A_AClassifierBehavior_Initial);
						BehaviorPort_Signal_A_AClassifierBehavior_ControlFlow117.SetTarget(BehaviorPort_Signal_A_AClassifierBehavior_Accept_S);
					BehaviorPort_Signal_A_AClassifierBehavior.AddEdge(BehaviorPort_Signal_A_AClassifierBehavior_ControlFlow117);
						// ObjectFlow ObjectFlow85 from result to Fork S
						BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow85.SetName("ObjectFlow85");
						BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow85.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow85.SetSource(BehaviorPort_Signal_A_AClassifierBehavior_Accept_S_result);
						BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow85.SetTarget(BehaviorPort_Signal_A_AClassifierBehavior_Fork_S);
							// LiteralBoolean LiteralBoolean87
							BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow85_LiteralBoolean87.SetName("LiteralBoolean87");
							BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow85_LiteralBoolean87.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow85_LiteralBoolean87.SetValue(true);
						BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow85.SetGuard(BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow85_LiteralBoolean87);
					BehaviorPort_Signal_A_AClassifierBehavior.AddEdge(BehaviorPort_Signal_A_AClassifierBehavior_ObjectFlow85);
				BehaviorPort_Signal_A.AddOwnedBehavior(BehaviorPort_Signal_A_AClassifierBehavior);
					BehaviorPort_Signal_A_IRealization.SetName("IRealization");
					BehaviorPort_Signal_A_IRealization.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Signal_A_IRealization.SetContract(BehaviorPort_Signal_I);
					
				BehaviorPort_Signal_A.AddInterfaceRealization(BehaviorPort_Signal_A_IRealization);
				
				BehaviorPort_Signal_A.SetIsActive(true);
					// Operation A_A
					BehaviorPort_Signal_A_A_A.SetName("A_A");
					BehaviorPort_Signal_A_A_A.SetVisibility(VisibilityKind.public_);
						// Parameter result
						BehaviorPort_Signal_A_A_A_result.SetName("result");
						BehaviorPort_Signal_A_A_A_result.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Signal_A_A_A_result.SetType(BehaviorPort_Signal_A);
						BehaviorPort_Signal_A_A_A_result.SetDirection(ParameterDirectionKind.return_);
					BehaviorPort_Signal_A_A_A.AddOwnedParameter(BehaviorPort_Signal_A_A_A_result);
					BehaviorPort_Signal_A_A_A.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				BehaviorPort_Signal_A.AddOwnedOperation(BehaviorPort_Signal_A_A_A);
					// Reception S
					BehaviorPort_Signal_A_S.SetName("S");
					BehaviorPort_Signal_A_S.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Signal_A_S.SetSignal(BehaviorPort_Signal_S);
				BehaviorPort_Signal_A.AddOwnedReception(BehaviorPort_Signal_A_S);
			BehaviorPort_Signal.AddPackagedElement(BehaviorPort_Signal_A);
				// SignalEvent SignalEventContinue
				BehaviorPort_Signal_SignalEventContinue.SetName("SignalEventContinue");
				BehaviorPort_Signal_SignalEventContinue.SetVisibility(VisibilityKind.public_);
				BehaviorPort_Signal_SignalEventContinue.SetSignal(BehaviorPort_Signal_Continue);
			BehaviorPort_Signal.AddPackagedElement(BehaviorPort_Signal_SignalEventContinue);
				// Signal Start
				BehaviorPort_Signal_Start.SetName("Start");
				BehaviorPort_Signal_Start.SetVisibility(VisibilityKind.public_);
			BehaviorPort_Signal.AddPackagedElement(BehaviorPort_Signal_Start);
				// Signal Continue
				BehaviorPort_Signal_Continue.SetName("Continue");
				BehaviorPort_Signal_Continue.SetVisibility(VisibilityKind.public_);
			BehaviorPort_Signal.AddPackagedElement(BehaviorPort_Signal_Continue);
				// SignalEvent SignalEventS
				BehaviorPort_Signal_SignalEventS.SetName("SignalEventS");
				BehaviorPort_Signal_SignalEventS.SetVisibility(VisibilityKind.public_);
				BehaviorPort_Signal_SignalEventS.SetSignal(BehaviorPort_Signal_S);
			BehaviorPort_Signal.AddPackagedElement(BehaviorPort_Signal_SignalEventS);
				// Class IImpl
				BehaviorPort_Signal_IImpl.SetName("IImpl");
				BehaviorPort_Signal_IImpl.SetVisibility(VisibilityKind.public_);
				BehaviorPort_Signal_IImpl_IRealization.SetName("IRealization");
					BehaviorPort_Signal_IImpl_IRealization.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Signal_IImpl_IRealization.SetContract(BehaviorPort_Signal_I);
					
				BehaviorPort_Signal_IImpl.AddInterfaceRealization(BehaviorPort_Signal_IImpl_IRealization);
				
					// Reception S
					BehaviorPort_Signal_IImpl_S.SetName("S");
					BehaviorPort_Signal_IImpl_S.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Signal_IImpl_S.SetSignal(BehaviorPort_Signal_S);
				BehaviorPort_Signal_IImpl.AddOwnedReception(BehaviorPort_Signal_IImpl_S);
			BehaviorPort_Signal.AddPackagedElement(BehaviorPort_Signal_IImpl);
				// Activity main
				BehaviorPort_Signal_main.SetName("main");
				BehaviorPort_Signal_main.SetVisibility(VisibilityKind.public_);
					// CreateObjectAction Create Tester
					BehaviorPort_Signal_main_Create_Tester.SetName("Create Tester");
					BehaviorPort_Signal_main_Create_Tester.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Signal_main_Create_Tester.SetClassifier(BehaviorPort_Signal_Tester);
						// OutputPin result
						BehaviorPort_Signal_main_Create_Tester_result.SetName("result");
						BehaviorPort_Signal_main_Create_Tester_result.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Signal_main_Create_Tester_result.SetType(BehaviorPort_Signal_Tester);
					BehaviorPort_Signal_main_Create_Tester.SetResult(BehaviorPort_Signal_main_Create_Tester_result);
				BehaviorPort_Signal_main.AddNode(BehaviorPort_Signal_main_Create_Tester);
					// StartObjectBehaviorAction Start Tester
					BehaviorPort_Signal_main_Start_Tester.SetName("Start Tester");
					BehaviorPort_Signal_main_Start_Tester.SetVisibility(VisibilityKind.public_);
						// InputPin object
						BehaviorPort_Signal_main_Start_Tester_object.SetName("object");
						BehaviorPort_Signal_main_Start_Tester_object.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Signal_main_Start_Tester_object.SetType(BehaviorPort_Signal_Tester);
						BehaviorPort_Signal_main_Start_Tester_object.SetIsOrdered(true);
						BehaviorPort_Signal_main_Start_Tester_object.SetIsUnique(false);
					BehaviorPort_Signal_main_Start_Tester.SetObject(BehaviorPort_Signal_main_Start_Tester_object);
				BehaviorPort_Signal_main.AddNode(BehaviorPort_Signal_main_Start_Tester);
					// ForkNode Fork Tester
					BehaviorPort_Signal_main_Fork_Tester.SetName("Fork Tester");
					BehaviorPort_Signal_main_Fork_Tester.SetVisibility(VisibilityKind.public_);
				BehaviorPort_Signal_main.AddNode(BehaviorPort_Signal_main_Fork_Tester);
					// CallOperationAction Tester()
					BehaviorPort_Signal_main_Tester_.SetName("Tester()");
					BehaviorPort_Signal_main_Tester_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						BehaviorPort_Signal_main_Tester__result.SetName("result");
						BehaviorPort_Signal_main_Tester__result.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Signal_main_Tester__result.SetType(BehaviorPort_Signal_Tester);
					BehaviorPort_Signal_main_Tester_.AddResult(BehaviorPort_Signal_main_Tester__result);
					BehaviorPort_Signal_main_Tester_.SetOperation(BehaviorPort_Signal_Tester_Tester_Tester);
						// InputPin target
						BehaviorPort_Signal_main_Tester__target.SetName("target");
						BehaviorPort_Signal_main_Tester__target.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Signal_main_Tester__target.SetType(BehaviorPort_Signal_Tester);
					BehaviorPort_Signal_main_Tester_.SetTarget(BehaviorPort_Signal_main_Tester__target);
				BehaviorPort_Signal_main.AddNode(BehaviorPort_Signal_main_Tester_);
					// SendSignalAction Send Start
					BehaviorPort_Signal_main_Send_Start.SetName("Send Start");
					BehaviorPort_Signal_main_Send_Start.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Signal_main_Send_Start.SetSignal(BehaviorPort_Signal_Start);
						// InputPin target
						BehaviorPort_Signal_main_Send_Start_target.SetName("target");
						BehaviorPort_Signal_main_Send_Start_target.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Signal_main_Send_Start_target.SetType(BehaviorPort_Signal_Tester);
						BehaviorPort_Signal_main_Send_Start_target.SetIsOrdered(true);
						BehaviorPort_Signal_main_Send_Start_target.SetIsUnique(false);
					BehaviorPort_Signal_main_Send_Start.SetTarget(BehaviorPort_Signal_main_Send_Start_target);
				BehaviorPort_Signal_main.AddNode(BehaviorPort_Signal_main_Send_Start);
					// ObjectFlow ObjectFlow118 from result to Fork Tester
					BehaviorPort_Signal_main_ObjectFlow118.SetName("ObjectFlow118");
					BehaviorPort_Signal_main_ObjectFlow118.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Signal_main_ObjectFlow118.SetSource(BehaviorPort_Signal_main_Tester__result);
					BehaviorPort_Signal_main_ObjectFlow118.SetTarget(BehaviorPort_Signal_main_Fork_Tester);
						// LiteralBoolean LiteralBoolean119
						BehaviorPort_Signal_main_ObjectFlow118_LiteralBoolean119.SetName("LiteralBoolean119");
						BehaviorPort_Signal_main_ObjectFlow118_LiteralBoolean119.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Signal_main_ObjectFlow118_LiteralBoolean119.SetValue(true);
					BehaviorPort_Signal_main_ObjectFlow118.SetGuard(BehaviorPort_Signal_main_ObjectFlow118_LiteralBoolean119);
				BehaviorPort_Signal_main.AddEdge(BehaviorPort_Signal_main_ObjectFlow118);
					// ObjectFlow ObjectFlow121 from result to target
					BehaviorPort_Signal_main_ObjectFlow121.SetName("ObjectFlow121");
					BehaviorPort_Signal_main_ObjectFlow121.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Signal_main_ObjectFlow121.SetSource(BehaviorPort_Signal_main_Create_Tester_result);
					BehaviorPort_Signal_main_ObjectFlow121.SetTarget(BehaviorPort_Signal_main_Tester__target);
						// LiteralBoolean LiteralBoolean122
						BehaviorPort_Signal_main_ObjectFlow121_LiteralBoolean122.SetName("LiteralBoolean122");
						BehaviorPort_Signal_main_ObjectFlow121_LiteralBoolean122.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Signal_main_ObjectFlow121_LiteralBoolean122.SetValue(true);
					BehaviorPort_Signal_main_ObjectFlow121.SetGuard(BehaviorPort_Signal_main_ObjectFlow121_LiteralBoolean122);
				BehaviorPort_Signal_main.AddEdge(BehaviorPort_Signal_main_ObjectFlow121);
					// ObjectFlow ObjectFlow128 from Fork Tester to object
					BehaviorPort_Signal_main_ObjectFlow128.SetName("ObjectFlow128");
					BehaviorPort_Signal_main_ObjectFlow128.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Signal_main_ObjectFlow128.SetSource(BehaviorPort_Signal_main_Fork_Tester);
					BehaviorPort_Signal_main_ObjectFlow128.SetTarget(BehaviorPort_Signal_main_Start_Tester_object);
						// LiteralBoolean LiteralBoolean129
						BehaviorPort_Signal_main_ObjectFlow128_LiteralBoolean129.SetName("LiteralBoolean129");
						BehaviorPort_Signal_main_ObjectFlow128_LiteralBoolean129.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Signal_main_ObjectFlow128_LiteralBoolean129.SetValue(true);
					BehaviorPort_Signal_main_ObjectFlow128.SetGuard(BehaviorPort_Signal_main_ObjectFlow128_LiteralBoolean129);
				BehaviorPort_Signal_main.AddEdge(BehaviorPort_Signal_main_ObjectFlow128);
					// ControlFlow ControlFlow131 from Start Tester to Send Start
					BehaviorPort_Signal_main_ControlFlow131.SetName("ControlFlow131");
					BehaviorPort_Signal_main_ControlFlow131.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Signal_main_ControlFlow131.SetSource(BehaviorPort_Signal_main_Start_Tester);
					BehaviorPort_Signal_main_ControlFlow131.SetTarget(BehaviorPort_Signal_main_Send_Start);
				BehaviorPort_Signal_main.AddEdge(BehaviorPort_Signal_main_ControlFlow131);
					// ObjectFlow ObjectFlow139 from Fork Tester to target
					BehaviorPort_Signal_main_ObjectFlow139.SetName("ObjectFlow139");
					BehaviorPort_Signal_main_ObjectFlow139.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Signal_main_ObjectFlow139.SetSource(BehaviorPort_Signal_main_Fork_Tester);
					BehaviorPort_Signal_main_ObjectFlow139.SetTarget(BehaviorPort_Signal_main_Send_Start_target);
						// LiteralBoolean LiteralBoolean141
						BehaviorPort_Signal_main_ObjectFlow139_LiteralBoolean141.SetName("LiteralBoolean141");
						BehaviorPort_Signal_main_ObjectFlow139_LiteralBoolean141.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Signal_main_ObjectFlow139_LiteralBoolean141.SetValue(true);
					BehaviorPort_Signal_main_ObjectFlow139.SetGuard(BehaviorPort_Signal_main_ObjectFlow139_LiteralBoolean141);
				BehaviorPort_Signal_main.AddEdge(BehaviorPort_Signal_main_ObjectFlow139);
			BehaviorPort_Signal.AddPackagedElement(BehaviorPort_Signal_main);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // BehaviorPort_SignalModel
}
