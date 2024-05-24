/*
 * Signal_AssemblyAndDelegationModel.cs
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

namespace Signal_AssemblyAndDelegation
{
	public class Signal_AssemblyAndDelegationModel : InMemoryModel
	{
		private static Signal_AssemblyAndDelegationModel? instance;

		/*
		 * Model Signal_AssemblyAndDelegation
		 */
		public Package Signal_AssemblyAndDelegation = new();
			public Activity Signal_AssemblyAndDelegation_main = new();
				public SendSignalAction Signal_AssemblyAndDelegation_main_Send_Start = new();
					public InputPin Signal_AssemblyAndDelegation_main_Send_Start_testCase = new();
						public LiteralUnlimitedNatural Signal_AssemblyAndDelegation_main_Send_Start_testCase_LiteralUnlimitedNatural0 = new();
						public LiteralInteger Signal_AssemblyAndDelegation_main_Send_Start_testCase_LiteralInteger1 = new();
						public LiteralInteger Signal_AssemblyAndDelegation_main_Send_Start_testCase_LiteralInteger2 = new();
					public InputPin Signal_AssemblyAndDelegation_main_Send_Start_target = new();
						public LiteralInteger Signal_AssemblyAndDelegation_main_Send_Start_target_LiteralInteger3 = new();
						public LiteralUnlimitedNatural Signal_AssemblyAndDelegation_main_Send_Start_target_LiteralUnlimitedNatural4 = new();
				public CallOperationAction Signal_AssemblyAndDelegation_main_TestCaseAssembly_ = new();
					public InputPin Signal_AssemblyAndDelegation_main_TestCaseAssembly__target = new();
						public LiteralUnlimitedNatural Signal_AssemblyAndDelegation_main_TestCaseAssembly__target_LiteralUnlimitedNatural5 = new();
						public LiteralInteger Signal_AssemblyAndDelegation_main_TestCaseAssembly__target_LiteralInteger6 = new();
					public OutputPin Signal_AssemblyAndDelegation_main_TestCaseAssembly__result = new();
						public LiteralInteger Signal_AssemblyAndDelegation_main_TestCaseAssembly__result_LiteralInteger7 = new();
						public LiteralInteger Signal_AssemblyAndDelegation_main_TestCaseAssembly__result_LiteralInteger8 = new();
						public LiteralUnlimitedNatural Signal_AssemblyAndDelegation_main_TestCaseAssembly__result_LiteralUnlimitedNatural9 = new();
				public CreateObjectAction Signal_AssemblyAndDelegation_main_Create_TestCaseAssembly = new();
					public OutputPin Signal_AssemblyAndDelegation_main_Create_TestCaseAssembly_result = new();
						public LiteralInteger Signal_AssemblyAndDelegation_main_Create_TestCaseAssembly_result_LiteralInteger10 = new();
						public LiteralUnlimitedNatural Signal_AssemblyAndDelegation_main_Create_TestCaseAssembly_result_LiteralUnlimitedNatural11 = new();
				public ObjectFlow Signal_AssemblyAndDelegation_main_ObjectFlow12 = new();
					public LiteralInteger Signal_AssemblyAndDelegation_main_ObjectFlow12_LiteralInteger13 = new();
					public LiteralBoolean Signal_AssemblyAndDelegation_main_ObjectFlow12_LiteralBoolean14 = new();
				public ObjectFlow Signal_AssemblyAndDelegation_main_ObjectFlow15 = new();
					public LiteralInteger Signal_AssemblyAndDelegation_main_ObjectFlow15_LiteralInteger16 = new();
					public LiteralBoolean Signal_AssemblyAndDelegation_main_ObjectFlow15_LiteralBoolean17 = new();
				public ObjectFlow Signal_AssemblyAndDelegation_main_ObjectFlow18 = new();
					public LiteralInteger Signal_AssemblyAndDelegation_main_ObjectFlow18_LiteralInteger19 = new();
					public LiteralBoolean Signal_AssemblyAndDelegation_main_ObjectFlow18_LiteralBoolean20 = new();
				public ForkNode Signal_AssemblyAndDelegation_main_Fork_testCase = new();
				public ObjectFlow Signal_AssemblyAndDelegation_main_ObjectFlow21 = new();
					public LiteralBoolean Signal_AssemblyAndDelegation_main_ObjectFlow21_LiteralBoolean22 = new();
					public LiteralInteger Signal_AssemblyAndDelegation_main_ObjectFlow21_LiteralInteger23 = new();
				public ObjectFlow Signal_AssemblyAndDelegation_main_ObjectFlow24 = new();
					public LiteralInteger Signal_AssemblyAndDelegation_main_ObjectFlow24_LiteralInteger25 = new();
					public LiteralBoolean Signal_AssemblyAndDelegation_main_ObjectFlow24_LiteralBoolean26 = new();
				public ObjectFlow Signal_AssemblyAndDelegation_main_ObjectFlow27 = new();
					public LiteralInteger Signal_AssemblyAndDelegation_main_ObjectFlow27_LiteralInteger28 = new();
					public LiteralBoolean Signal_AssemblyAndDelegation_main_ObjectFlow27_LiteralBoolean29 = new();
				public ReadStructuralFeatureAction Signal_AssemblyAndDelegation_main_Read_TestCaseAssembly_c = new();
					public InputPin Signal_AssemblyAndDelegation_main_Read_TestCaseAssembly_c_object = new();
						public LiteralUnlimitedNatural Signal_AssemblyAndDelegation_main_Read_TestCaseAssembly_c_object_LiteralUnlimitedNatural30 = new();
						public LiteralInteger Signal_AssemblyAndDelegation_main_Read_TestCaseAssembly_c_object_LiteralInteger31 = new();
					public OutputPin Signal_AssemblyAndDelegation_main_Read_TestCaseAssembly_c_result = new();
						public LiteralUnlimitedNatural Signal_AssemblyAndDelegation_main_Read_TestCaseAssembly_c_result_LiteralUnlimitedNatural32 = new();
						public LiteralInteger Signal_AssemblyAndDelegation_main_Read_TestCaseAssembly_c_result_LiteralInteger33 = new();
				public ReadStructuralFeatureAction Signal_AssemblyAndDelegation_main_Read_c_tester = new();
					public InputPin Signal_AssemblyAndDelegation_main_Read_c_tester_object = new();
						public LiteralUnlimitedNatural Signal_AssemblyAndDelegation_main_Read_c_tester_object_LiteralUnlimitedNatural34 = new();
						public LiteralInteger Signal_AssemblyAndDelegation_main_Read_c_tester_object_LiteralInteger35 = new();
					public OutputPin Signal_AssemblyAndDelegation_main_Read_c_tester_result = new();
						public LiteralUnlimitedNatural Signal_AssemblyAndDelegation_main_Read_c_tester_result_LiteralUnlimitedNatural36 = new();
						public LiteralInteger Signal_AssemblyAndDelegation_main_Read_c_tester_result_LiteralInteger37 = new();
			public SignalEvent Signal_AssemblyAndDelegation_StartEvent = new();
			public Class_ Signal_AssemblyAndDelegation_B = new();
				public Connector Signal_AssemblyAndDelegation_B_r = new();
					public ConnectorEnd Signal_AssemblyAndDelegation_B_r_ConnectorEnd38 = new();
					public ConnectorEnd Signal_AssemblyAndDelegation_B_r_ConnectorEnd39 = new();
				public Property Signal_AssemblyAndDelegation_B_a = new();
				public Port Signal_AssemblyAndDelegation_B_p = new();
			public Class_ Signal_AssemblyAndDelegation_I = new();
			public SignalEvent Signal_AssemblyAndDelegation_SEvent = new();
			public Signal Signal_AssemblyAndDelegation_S = new();
				public Property Signal_AssemblyAndDelegation_S_value = new();
			public Class_ Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation = new();
				public Property Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_b = new();
				public Property Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_c = new();
				public Operation Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation = new();
					public Parameter Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation_result = new();
				public Connector Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_r = new();
					public ConnectorEnd Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_r_ConnectorEnd40 = new();
					public ConnectorEnd Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_r_ConnectorEnd41 = new();
				public Activity Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity = new();
					public ReadStructuralFeatureAction Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_b_a = new();
						public OutputPin Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_b_a_result = new();
							public LiteralUnlimitedNatural Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_b_a_result_LiteralUnlimitedNatural42 = new();
							public LiteralInteger Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_b_a_result_LiteralInteger43 = new();
						public InputPin Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_b_a_object = new();
							public LiteralUnlimitedNatural Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_b_a_object_LiteralUnlimitedNatural44 = new();
							public LiteralInteger Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_b_a_object_LiteralInteger45 = new();
					public OpaqueBehavior Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_testV = new();
						public Parameter Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_testV_v = new();
					public ObjectFlow Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow46 = new();
						public LiteralInteger Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow46_LiteralInteger47 = new();
						public LiteralBoolean Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow46_LiteralBoolean48 = new();
					public CallBehaviorAction Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Call_testV = new();
						public InputPin Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Call_testV_v = new();
							public LiteralInteger Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Call_testV_v_LiteralInteger49 = new();
							public LiteralUnlimitedNatural Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Call_testV_v_LiteralUnlimitedNatural50 = new();
							public LiteralInteger Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Call_testV_v_LiteralInteger51 = new();
					public ObjectFlow Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow52 = new();
						public LiteralInteger Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow52_LiteralInteger53 = new();
						public LiteralBoolean Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow52_LiteralBoolean54 = new();
					public ReadSelfAction Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_this = new();
						public OutputPin Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_this_result = new();
							public LiteralInteger Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_this_result_LiteralInteger55 = new();
							public LiteralUnlimitedNatural Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_this_result_LiteralUnlimitedNatural56 = new();
					public ReadStructuralFeatureAction Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_a_v = new();
						public OutputPin Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_a_v_result = new();
							public LiteralUnlimitedNatural Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_a_v_result_LiteralUnlimitedNatural57 = new();
							public LiteralInteger Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_a_v_result_LiteralInteger58 = new();
						public InputPin Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_a_v_object = new();
							public LiteralUnlimitedNatural Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_a_v_object_LiteralUnlimitedNatural59 = new();
							public LiteralInteger Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_a_v_object_LiteralInteger60 = new();
					public ObjectFlow Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow61 = new();
						public LiteralInteger Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow61_LiteralInteger62 = new();
						public LiteralBoolean Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow61_LiteralBoolean63 = new();
					public ObjectFlow Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow64 = new();
						public LiteralInteger Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow64_LiteralInteger65 = new();
						public LiteralBoolean Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow64_LiteralBoolean66 = new();
					public ReadStructuralFeatureAction Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_this_b = new();
						public InputPin Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_this_b_object = new();
							public LiteralInteger Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_this_b_object_LiteralInteger67 = new();
							public LiteralUnlimitedNatural Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_this_b_object_LiteralUnlimitedNatural68 = new();
						public OutputPin Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_this_b_result = new();
							public LiteralInteger Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_this_b_result_LiteralInteger69 = new();
							public LiteralUnlimitedNatural Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_this_b_result_LiteralUnlimitedNatural70 = new();
				public Generalization Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_Generalization71 = new();
				public Operation Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_test = new();
			public Class_ Signal_AssemblyAndDelegation_A = new();
				public Port Signal_AssemblyAndDelegation_A_p = new();
				public Operation Signal_AssemblyAndDelegation_A_A_A = new();
					public Parameter Signal_AssemblyAndDelegation_A_A_A_result = new();
				public Property Signal_AssemblyAndDelegation_A_v = new();
				public Activity Signal_AssemblyAndDelegation_A_AClassifierBehavior = new();
					public ControlFlow Signal_AssemblyAndDelegation_A_AClassifierBehavior_ControlFlow72 = new();
					public ReadSelfAction Signal_AssemblyAndDelegation_A_AClassifierBehavior_this = new();
						public OutputPin Signal_AssemblyAndDelegation_A_AClassifierBehavior_this_result = new();
							public LiteralInteger Signal_AssemblyAndDelegation_A_AClassifierBehavior_this_result_LiteralInteger73 = new();
							public LiteralUnlimitedNatural Signal_AssemblyAndDelegation_A_AClassifierBehavior_this_result_LiteralUnlimitedNatural74 = new();
					public ObjectFlow Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow75 = new();
						public LiteralInteger Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow75_LiteralInteger76 = new();
						public LiteralBoolean Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow75_LiteralBoolean77 = new();
					public SendSignalAction Signal_AssemblyAndDelegation_A_AClassifierBehavior_Send_Continue = new();
						public InputPin Signal_AssemblyAndDelegation_A_AClassifierBehavior_Send_Continue_target = new();
							public LiteralInteger Signal_AssemblyAndDelegation_A_AClassifierBehavior_Send_Continue_target_LiteralInteger78 = new();
							public LiteralUnlimitedNatural Signal_AssemblyAndDelegation_A_AClassifierBehavior_Send_Continue_target_LiteralUnlimitedNatural79 = new();
					public ActivityFinalNode Signal_AssemblyAndDelegation_A_AClassifierBehavior_ActivityFinalNode80 = new();
					public ObjectFlow Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow81 = new();
						public LiteralInteger Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow81_LiteralInteger82 = new();
						public LiteralBoolean Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow81_LiteralBoolean83 = new();
					public ControlFlow Signal_AssemblyAndDelegation_A_AClassifierBehavior_ControlFlow84 = new();
					public AcceptEventAction Signal_AssemblyAndDelegation_A_AClassifierBehavior_Accept_S = new();
						public OutputPin Signal_AssemblyAndDelegation_A_AClassifierBehavior_Accept_S_value = new();
							public LiteralInteger Signal_AssemblyAndDelegation_A_AClassifierBehavior_Accept_S_value_LiteralInteger85 = new();
							public LiteralInteger Signal_AssemblyAndDelegation_A_AClassifierBehavior_Accept_S_value_LiteralInteger86 = new();
							public LiteralUnlimitedNatural Signal_AssemblyAndDelegation_A_AClassifierBehavior_Accept_S_value_LiteralUnlimitedNatural87 = new();
						public Trigger Signal_AssemblyAndDelegation_A_AClassifierBehavior_Accept_S_Trigger88 = new();
					public ObjectFlow Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow89 = new();
						public LiteralBoolean Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow89_LiteralBoolean90 = new();
						public LiteralInteger Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow89_LiteralInteger91 = new();
					public AddStructuralFeatureValueAction Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v = new();
						public InputPin Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_object = new();
							public LiteralUnlimitedNatural Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_object_LiteralUnlimitedNatural92 = new();
							public LiteralInteger Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_object_LiteralInteger93 = new();
						public InputPin Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_value = new();
							public LiteralUnlimitedNatural Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_value_LiteralUnlimitedNatural94 = new();
							public LiteralInteger Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_value_LiteralInteger95 = new();
						public OutputPin Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_result = new();
							public LiteralUnlimitedNatural Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_result_LiteralUnlimitedNatural96 = new();
							public LiteralInteger Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_result_LiteralInteger97 = new();
			public Signal Signal_AssemblyAndDelegation_Continue = new();
			public SignalEvent Signal_AssemblyAndDelegation_ContinueEvent = new();
			public Class_ Signal_AssemblyAndDelegation_C = new();
				public Port Signal_AssemblyAndDelegation_C_q = new();
				public Property Signal_AssemblyAndDelegation_C_tester = new();
				public Connector Signal_AssemblyAndDelegation_C_r = new();
					public ConnectorEnd Signal_AssemblyAndDelegation_C_r_ConnectorEnd98 = new();
					public ConnectorEnd Signal_AssemblyAndDelegation_C_r_ConnectorEnd99 = new();
			public Class_ Signal_AssemblyAndDelegation_TestCase = new();
				public Operation Signal_AssemblyAndDelegation_TestCase_test = new();
			public Association Signal_AssemblyAndDelegation_R = new();
				public Property Signal_AssemblyAndDelegation_R_x = new();
				public Property Signal_AssemblyAndDelegation_R_y = new();
			public Signal Signal_AssemblyAndDelegation_Start = new();
				public Property Signal_AssemblyAndDelegation_Start_testCase = new();
			public Class_ Signal_AssemblyAndDelegation_Tester = new();
				public Reception Signal_AssemblyAndDelegation_Tester_Start = new();
				public Port Signal_AssemblyAndDelegation_Tester_q = new();
				public Activity Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior = new();
					public ControlFlow Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ControlFlow100 = new();
					public ControlFlow Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ControlFlow101 = new();
					public ValueSpecificationAction Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Value_4 = new();
						public OutputPin Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Value_4_result = new();
							public LiteralInteger Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Value_4_result_LiteralInteger102 = new();
							public LiteralUnlimitedNatural Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Value_4_result_LiteralUnlimitedNatural103 = new();
						public LiteralInteger Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Value_4_LiteralInteger104 = new();
					public AcceptEventAction Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Continue = new();
						public Trigger Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Continue_Trigger105 = new();
						public OutputPin Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Continue_result = new();
							public LiteralInteger Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Continue_result_LiteralInteger106 = new();
							public LiteralInteger Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Continue_result_LiteralInteger107 = new();
							public LiteralUnlimitedNatural Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Continue_result_LiteralUnlimitedNatural108 = new();
					public ObjectFlow Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow109 = new();
						public LiteralBoolean Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow109_LiteralBoolean110 = new();
						public LiteralInteger Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow109_LiteralInteger111 = new();
					public ControlFlow Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ControlFlow112 = new();
					public CallOperationAction Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Call_test_ = new();
						public InputPin Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Call_test__target = new();
							public LiteralInteger Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Call_test__target_LiteralInteger113 = new();
							public LiteralUnlimitedNatural Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Call_test__target_LiteralUnlimitedNatural114 = new();
					public ControlFlow Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ControlFlow115 = new();
					public ObjectFlow Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow116 = new();
						public LiteralInteger Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow116_LiteralInteger117 = new();
						public LiteralBoolean Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow116_LiteralBoolean118 = new();
					public ActivityFinalNode Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ActivityFinalNode119 = new();
					public AcceptEventAction Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Start = new();
						public Trigger Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Start_Trigger120 = new();
						public OutputPin Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Start_testCase = new();
							public LiteralInteger Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Start_testCase_LiteralInteger121 = new();
							public LiteralInteger Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Start_testCase_LiteralInteger122 = new();
							public LiteralUnlimitedNatural Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Start_testCase_LiteralUnlimitedNatural123 = new();
					public SendSignalAction Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S = new();
						public InputPin Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S_target = new();
							public LiteralInteger Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S_target_LiteralInteger124 = new();
							public LiteralUnlimitedNatural Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S_target_LiteralUnlimitedNatural125 = new();
						public InputPin Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S_value = new();
							public LiteralInteger Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S_value_LiteralInteger126 = new();
							public LiteralInteger Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S_value_LiteralInteger127 = new();
							public LiteralUnlimitedNatural Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S_value_LiteralUnlimitedNatural128 = new();
					public ObjectFlow Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow129 = new();
						public LiteralBoolean Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow129_LiteralBoolean130 = new();
						public LiteralInteger Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow129_LiteralInteger131 = new();
					public ReadSelfAction Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_this = new();
						public OutputPin Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_this_result = new();
							public LiteralInteger Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_this_result_LiteralInteger132 = new();
							public LiteralUnlimitedNatural Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_this_result_LiteralUnlimitedNatural133 = new();
				public Operation Signal_AssemblyAndDelegation_Tester_Tester_Tester = new();
					public Parameter Signal_AssemblyAndDelegation_Tester_Tester_Tester_result = new();

		public static Signal_AssemblyAndDelegationModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public Signal_AssemblyAndDelegationModel()
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
			 * Model Signal_AssemblyAndDelegation
			 */
			AddToElementRepository("Signal_AssemblyAndDelegation", Signal_AssemblyAndDelegation);
				AddToElementRepository("main", Signal_AssemblyAndDelegation_main);
					AddToElementRepository("Send Start", Signal_AssemblyAndDelegation_main_Send_Start);
						AddToElementRepository("testCase", Signal_AssemblyAndDelegation_main_Send_Start_testCase);
							AddToElementRepository("LiteralUnlimitedNatural0", Signal_AssemblyAndDelegation_main_Send_Start_testCase_LiteralUnlimitedNatural0);
							AddToElementRepository("LiteralInteger1", Signal_AssemblyAndDelegation_main_Send_Start_testCase_LiteralInteger1);
							AddToElementRepository("LiteralInteger2", Signal_AssemblyAndDelegation_main_Send_Start_testCase_LiteralInteger2);
						AddToElementRepository("target", Signal_AssemblyAndDelegation_main_Send_Start_target);
							AddToElementRepository("LiteralInteger3", Signal_AssemblyAndDelegation_main_Send_Start_target_LiteralInteger3);
							AddToElementRepository("LiteralUnlimitedNatural4", Signal_AssemblyAndDelegation_main_Send_Start_target_LiteralUnlimitedNatural4);
					AddToElementRepository("TestCaseAssembly()", Signal_AssemblyAndDelegation_main_TestCaseAssembly_);
						AddToElementRepository("target", Signal_AssemblyAndDelegation_main_TestCaseAssembly__target);
							AddToElementRepository("LiteralUnlimitedNatural5", Signal_AssemblyAndDelegation_main_TestCaseAssembly__target_LiteralUnlimitedNatural5);
							AddToElementRepository("LiteralInteger6", Signal_AssemblyAndDelegation_main_TestCaseAssembly__target_LiteralInteger6);
						AddToElementRepository("result", Signal_AssemblyAndDelegation_main_TestCaseAssembly__result);
							AddToElementRepository("LiteralInteger7", Signal_AssemblyAndDelegation_main_TestCaseAssembly__result_LiteralInteger7);
							AddToElementRepository("LiteralInteger8", Signal_AssemblyAndDelegation_main_TestCaseAssembly__result_LiteralInteger8);
							AddToElementRepository("LiteralUnlimitedNatural9", Signal_AssemblyAndDelegation_main_TestCaseAssembly__result_LiteralUnlimitedNatural9);
					AddToElementRepository("Create TestCaseAssembly", Signal_AssemblyAndDelegation_main_Create_TestCaseAssembly);
						AddToElementRepository("result", Signal_AssemblyAndDelegation_main_Create_TestCaseAssembly_result);
							AddToElementRepository("LiteralInteger10", Signal_AssemblyAndDelegation_main_Create_TestCaseAssembly_result_LiteralInteger10);
							AddToElementRepository("LiteralUnlimitedNatural11", Signal_AssemblyAndDelegation_main_Create_TestCaseAssembly_result_LiteralUnlimitedNatural11);
					AddToElementRepository("ObjectFlow12", Signal_AssemblyAndDelegation_main_ObjectFlow12);
						AddToElementRepository("LiteralInteger13", Signal_AssemblyAndDelegation_main_ObjectFlow12_LiteralInteger13);
						AddToElementRepository("LiteralBoolean14", Signal_AssemblyAndDelegation_main_ObjectFlow12_LiteralBoolean14);
					AddToElementRepository("ObjectFlow15", Signal_AssemblyAndDelegation_main_ObjectFlow15);
						AddToElementRepository("LiteralInteger16", Signal_AssemblyAndDelegation_main_ObjectFlow15_LiteralInteger16);
						AddToElementRepository("LiteralBoolean17", Signal_AssemblyAndDelegation_main_ObjectFlow15_LiteralBoolean17);
					AddToElementRepository("ObjectFlow18", Signal_AssemblyAndDelegation_main_ObjectFlow18);
						AddToElementRepository("LiteralInteger19", Signal_AssemblyAndDelegation_main_ObjectFlow18_LiteralInteger19);
						AddToElementRepository("LiteralBoolean20", Signal_AssemblyAndDelegation_main_ObjectFlow18_LiteralBoolean20);
					AddToElementRepository("Fork testCase", Signal_AssemblyAndDelegation_main_Fork_testCase);
					AddToElementRepository("ObjectFlow21", Signal_AssemblyAndDelegation_main_ObjectFlow21);
						AddToElementRepository("LiteralBoolean22", Signal_AssemblyAndDelegation_main_ObjectFlow21_LiteralBoolean22);
						AddToElementRepository("LiteralInteger23", Signal_AssemblyAndDelegation_main_ObjectFlow21_LiteralInteger23);
					AddToElementRepository("ObjectFlow24", Signal_AssemblyAndDelegation_main_ObjectFlow24);
						AddToElementRepository("LiteralInteger25", Signal_AssemblyAndDelegation_main_ObjectFlow24_LiteralInteger25);
						AddToElementRepository("LiteralBoolean26", Signal_AssemblyAndDelegation_main_ObjectFlow24_LiteralBoolean26);
					AddToElementRepository("ObjectFlow27", Signal_AssemblyAndDelegation_main_ObjectFlow27);
						AddToElementRepository("LiteralInteger28", Signal_AssemblyAndDelegation_main_ObjectFlow27_LiteralInteger28);
						AddToElementRepository("LiteralBoolean29", Signal_AssemblyAndDelegation_main_ObjectFlow27_LiteralBoolean29);
					AddToElementRepository("Read TestCaseAssembly.c", Signal_AssemblyAndDelegation_main_Read_TestCaseAssembly_c);
						AddToElementRepository("object", Signal_AssemblyAndDelegation_main_Read_TestCaseAssembly_c_object);
							AddToElementRepository("LiteralUnlimitedNatural30", Signal_AssemblyAndDelegation_main_Read_TestCaseAssembly_c_object_LiteralUnlimitedNatural30);
							AddToElementRepository("LiteralInteger31", Signal_AssemblyAndDelegation_main_Read_TestCaseAssembly_c_object_LiteralInteger31);
						AddToElementRepository("result", Signal_AssemblyAndDelegation_main_Read_TestCaseAssembly_c_result);
							AddToElementRepository("LiteralUnlimitedNatural32", Signal_AssemblyAndDelegation_main_Read_TestCaseAssembly_c_result_LiteralUnlimitedNatural32);
							AddToElementRepository("LiteralInteger33", Signal_AssemblyAndDelegation_main_Read_TestCaseAssembly_c_result_LiteralInteger33);
					AddToElementRepository("Read c.tester", Signal_AssemblyAndDelegation_main_Read_c_tester);
						AddToElementRepository("object", Signal_AssemblyAndDelegation_main_Read_c_tester_object);
							AddToElementRepository("LiteralUnlimitedNatural34", Signal_AssemblyAndDelegation_main_Read_c_tester_object_LiteralUnlimitedNatural34);
							AddToElementRepository("LiteralInteger35", Signal_AssemblyAndDelegation_main_Read_c_tester_object_LiteralInteger35);
						AddToElementRepository("result", Signal_AssemblyAndDelegation_main_Read_c_tester_result);
							AddToElementRepository("LiteralUnlimitedNatural36", Signal_AssemblyAndDelegation_main_Read_c_tester_result_LiteralUnlimitedNatural36);
							AddToElementRepository("LiteralInteger37", Signal_AssemblyAndDelegation_main_Read_c_tester_result_LiteralInteger37);
				AddToElementRepository("StartEvent", Signal_AssemblyAndDelegation_StartEvent);
				AddToElementRepository("B", Signal_AssemblyAndDelegation_B);
					AddToElementRepository("r", Signal_AssemblyAndDelegation_B_r);
						AddToElementRepository("ConnectorEnd38", Signal_AssemblyAndDelegation_B_r_ConnectorEnd38);
						AddToElementRepository("ConnectorEnd39", Signal_AssemblyAndDelegation_B_r_ConnectorEnd39);
					AddToElementRepository("a", Signal_AssemblyAndDelegation_B_a);
					AddToElementRepository("p", Signal_AssemblyAndDelegation_B_p);
				AddToElementRepository("I", Signal_AssemblyAndDelegation_I);
				AddToElementRepository("SEvent", Signal_AssemblyAndDelegation_SEvent);
				AddToElementRepository("S", Signal_AssemblyAndDelegation_S);
					AddToElementRepository("value", Signal_AssemblyAndDelegation_S_value);
				AddToElementRepository("TestCaseAssemblyAndDelegation", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation);
					AddToElementRepository("b", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_b);
					AddToElementRepository("c", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_c);
					AddToElementRepository("TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation);
						AddToElementRepository("result", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation_result);
					AddToElementRepository("r", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_r);
						AddToElementRepository("ConnectorEnd40", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_r_ConnectorEnd40);
						AddToElementRepository("ConnectorEnd41", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_r_ConnectorEnd41);
					AddToElementRepository("testActivity", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity);
						AddToElementRepository("Read b.a", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_b_a);
							AddToElementRepository("result", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_b_a_result);
								AddToElementRepository("LiteralUnlimitedNatural42", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_b_a_result_LiteralUnlimitedNatural42);
								AddToElementRepository("LiteralInteger43", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_b_a_result_LiteralInteger43);
							AddToElementRepository("object", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_b_a_object);
								AddToElementRepository("LiteralUnlimitedNatural44", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_b_a_object_LiteralUnlimitedNatural44);
								AddToElementRepository("LiteralInteger45", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_b_a_object_LiteralInteger45);
						AddToElementRepository("testV", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_testV);
							AddToElementRepository("v", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_testV_v);
						AddToElementRepository("ObjectFlow46", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow46);
							AddToElementRepository("LiteralInteger47", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow46_LiteralInteger47);
							AddToElementRepository("LiteralBoolean48", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow46_LiteralBoolean48);
						AddToElementRepository("Call testV", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Call_testV);
							AddToElementRepository("v", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Call_testV_v);
								AddToElementRepository("LiteralInteger49", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Call_testV_v_LiteralInteger49);
								AddToElementRepository("LiteralUnlimitedNatural50", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Call_testV_v_LiteralUnlimitedNatural50);
								AddToElementRepository("LiteralInteger51", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Call_testV_v_LiteralInteger51);
						AddToElementRepository("ObjectFlow52", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow52);
							AddToElementRepository("LiteralInteger53", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow52_LiteralInteger53);
							AddToElementRepository("LiteralBoolean54", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow52_LiteralBoolean54);
						AddToElementRepository("this", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_this);
							AddToElementRepository("result", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_this_result);
								AddToElementRepository("LiteralInteger55", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_this_result_LiteralInteger55);
								AddToElementRepository("LiteralUnlimitedNatural56", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_this_result_LiteralUnlimitedNatural56);
						AddToElementRepository("Read a.v", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_a_v);
							AddToElementRepository("result", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_a_v_result);
								AddToElementRepository("LiteralUnlimitedNatural57", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_a_v_result_LiteralUnlimitedNatural57);
								AddToElementRepository("LiteralInteger58", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_a_v_result_LiteralInteger58);
							AddToElementRepository("object", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_a_v_object);
								AddToElementRepository("LiteralUnlimitedNatural59", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_a_v_object_LiteralUnlimitedNatural59);
								AddToElementRepository("LiteralInteger60", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_a_v_object_LiteralInteger60);
						AddToElementRepository("ObjectFlow61", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow61);
							AddToElementRepository("LiteralInteger62", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow61_LiteralInteger62);
							AddToElementRepository("LiteralBoolean63", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow61_LiteralBoolean63);
						AddToElementRepository("ObjectFlow64", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow64);
							AddToElementRepository("LiteralInteger65", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow64_LiteralInteger65);
							AddToElementRepository("LiteralBoolean66", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow64_LiteralBoolean66);
						AddToElementRepository("Read this.b", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_this_b);
							AddToElementRepository("object", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_this_b_object);
								AddToElementRepository("LiteralInteger67", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_this_b_object_LiteralInteger67);
								AddToElementRepository("LiteralUnlimitedNatural68", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_this_b_object_LiteralUnlimitedNatural68);
							AddToElementRepository("result", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_this_b_result);
								AddToElementRepository("LiteralInteger69", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_this_b_result_LiteralInteger69);
								AddToElementRepository("LiteralUnlimitedNatural70", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_this_b_result_LiteralUnlimitedNatural70);
					AddToElementRepository("Generalization71", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_Generalization71);
					AddToElementRepository("test", Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_test);
				AddToElementRepository("A", Signal_AssemblyAndDelegation_A);
					AddToElementRepository("p", Signal_AssemblyAndDelegation_A_p);
					AddToElementRepository("A_A", Signal_AssemblyAndDelegation_A_A_A);
						AddToElementRepository("result", Signal_AssemblyAndDelegation_A_A_A_result);
					AddToElementRepository("v", Signal_AssemblyAndDelegation_A_v);
					AddToElementRepository("AClassifierBehavior", Signal_AssemblyAndDelegation_A_AClassifierBehavior);
						AddToElementRepository("ControlFlow72", Signal_AssemblyAndDelegation_A_AClassifierBehavior_ControlFlow72);
						AddToElementRepository("this", Signal_AssemblyAndDelegation_A_AClassifierBehavior_this);
							AddToElementRepository("result", Signal_AssemblyAndDelegation_A_AClassifierBehavior_this_result);
								AddToElementRepository("LiteralInteger73", Signal_AssemblyAndDelegation_A_AClassifierBehavior_this_result_LiteralInteger73);
								AddToElementRepository("LiteralUnlimitedNatural74", Signal_AssemblyAndDelegation_A_AClassifierBehavior_this_result_LiteralUnlimitedNatural74);
						AddToElementRepository("ObjectFlow75", Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow75);
							AddToElementRepository("LiteralInteger76", Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow75_LiteralInteger76);
							AddToElementRepository("LiteralBoolean77", Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow75_LiteralBoolean77);
						AddToElementRepository("Send Continue", Signal_AssemblyAndDelegation_A_AClassifierBehavior_Send_Continue);
							AddToElementRepository("target", Signal_AssemblyAndDelegation_A_AClassifierBehavior_Send_Continue_target);
								AddToElementRepository("LiteralInteger78", Signal_AssemblyAndDelegation_A_AClassifierBehavior_Send_Continue_target_LiteralInteger78);
								AddToElementRepository("LiteralUnlimitedNatural79", Signal_AssemblyAndDelegation_A_AClassifierBehavior_Send_Continue_target_LiteralUnlimitedNatural79);
						AddToElementRepository("ActivityFinalNode80", Signal_AssemblyAndDelegation_A_AClassifierBehavior_ActivityFinalNode80);
						AddToElementRepository("ObjectFlow81", Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow81);
							AddToElementRepository("LiteralInteger82", Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow81_LiteralInteger82);
							AddToElementRepository("LiteralBoolean83", Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow81_LiteralBoolean83);
						AddToElementRepository("ControlFlow84", Signal_AssemblyAndDelegation_A_AClassifierBehavior_ControlFlow84);
						AddToElementRepository("Accept S", Signal_AssemblyAndDelegation_A_AClassifierBehavior_Accept_S);
							AddToElementRepository("value", Signal_AssemblyAndDelegation_A_AClassifierBehavior_Accept_S_value);
								AddToElementRepository("LiteralInteger85", Signal_AssemblyAndDelegation_A_AClassifierBehavior_Accept_S_value_LiteralInteger85);
								AddToElementRepository("LiteralInteger86", Signal_AssemblyAndDelegation_A_AClassifierBehavior_Accept_S_value_LiteralInteger86);
								AddToElementRepository("LiteralUnlimitedNatural87", Signal_AssemblyAndDelegation_A_AClassifierBehavior_Accept_S_value_LiteralUnlimitedNatural87);
							AddToElementRepository("Trigger88", Signal_AssemblyAndDelegation_A_AClassifierBehavior_Accept_S_Trigger88);
						AddToElementRepository("ObjectFlow89", Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow89);
							AddToElementRepository("LiteralBoolean90", Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow89_LiteralBoolean90);
							AddToElementRepository("LiteralInteger91", Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow89_LiteralInteger91);
						AddToElementRepository("Set v", Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v);
							AddToElementRepository("object", Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_object);
								AddToElementRepository("LiteralUnlimitedNatural92", Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_object_LiteralUnlimitedNatural92);
								AddToElementRepository("LiteralInteger93", Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_object_LiteralInteger93);
							AddToElementRepository("value", Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_value);
								AddToElementRepository("LiteralUnlimitedNatural94", Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_value_LiteralUnlimitedNatural94);
								AddToElementRepository("LiteralInteger95", Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_value_LiteralInteger95);
							AddToElementRepository("result", Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_result);
								AddToElementRepository("LiteralUnlimitedNatural96", Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_result_LiteralUnlimitedNatural96);
								AddToElementRepository("LiteralInteger97", Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_result_LiteralInteger97);
				AddToElementRepository("Continue", Signal_AssemblyAndDelegation_Continue);
				AddToElementRepository("ContinueEvent", Signal_AssemblyAndDelegation_ContinueEvent);
				AddToElementRepository("C", Signal_AssemblyAndDelegation_C);
					AddToElementRepository("q", Signal_AssemblyAndDelegation_C_q);
					AddToElementRepository("tester", Signal_AssemblyAndDelegation_C_tester);
					AddToElementRepository("r", Signal_AssemblyAndDelegation_C_r);
						AddToElementRepository("ConnectorEnd98", Signal_AssemblyAndDelegation_C_r_ConnectorEnd98);
						AddToElementRepository("ConnectorEnd99", Signal_AssemblyAndDelegation_C_r_ConnectorEnd99);
				AddToElementRepository("TestCase", Signal_AssemblyAndDelegation_TestCase);
					AddToElementRepository("test", Signal_AssemblyAndDelegation_TestCase_test);
				AddToElementRepository("R", Signal_AssemblyAndDelegation_R);
					AddToElementRepository("x", Signal_AssemblyAndDelegation_R_x);
					AddToElementRepository("y", Signal_AssemblyAndDelegation_R_y);
				AddToElementRepository("Start", Signal_AssemblyAndDelegation_Start);
					AddToElementRepository("testCase", Signal_AssemblyAndDelegation_Start_testCase);
				AddToElementRepository("Tester", Signal_AssemblyAndDelegation_Tester);
					AddToElementRepository("Start", Signal_AssemblyAndDelegation_Tester_Start);
					AddToElementRepository("q", Signal_AssemblyAndDelegation_Tester_q);
					AddToElementRepository("TesterClassifierBehavior", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior);
						AddToElementRepository("ControlFlow100", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ControlFlow100);
						AddToElementRepository("ControlFlow101", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ControlFlow101);
						AddToElementRepository("Value(4)", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Value_4);
							AddToElementRepository("result", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Value_4_result);
								AddToElementRepository("LiteralInteger102", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Value_4_result_LiteralInteger102);
								AddToElementRepository("LiteralUnlimitedNatural103", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Value_4_result_LiteralUnlimitedNatural103);
							AddToElementRepository("LiteralInteger104", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Value_4_LiteralInteger104);
						AddToElementRepository("Accept Continue", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Continue);
							AddToElementRepository("Trigger105", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Continue_Trigger105);
							AddToElementRepository("result", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Continue_result);
								AddToElementRepository("LiteralInteger106", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Continue_result_LiteralInteger106);
								AddToElementRepository("LiteralInteger107", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Continue_result_LiteralInteger107);
								AddToElementRepository("LiteralUnlimitedNatural108", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Continue_result_LiteralUnlimitedNatural108);
						AddToElementRepository("ObjectFlow109", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow109);
							AddToElementRepository("LiteralBoolean110", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow109_LiteralBoolean110);
							AddToElementRepository("LiteralInteger111", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow109_LiteralInteger111);
						AddToElementRepository("ControlFlow112", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ControlFlow112);
						AddToElementRepository("Call test()", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Call_test_);
							AddToElementRepository("target", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Call_test__target);
								AddToElementRepository("LiteralInteger113", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Call_test__target_LiteralInteger113);
								AddToElementRepository("LiteralUnlimitedNatural114", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Call_test__target_LiteralUnlimitedNatural114);
						AddToElementRepository("ControlFlow115", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ControlFlow115);
						AddToElementRepository("ObjectFlow116", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow116);
							AddToElementRepository("LiteralInteger117", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow116_LiteralInteger117);
							AddToElementRepository("LiteralBoolean118", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow116_LiteralBoolean118);
						AddToElementRepository("ActivityFinalNode119", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ActivityFinalNode119);
						AddToElementRepository("Accept Start", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Start);
							AddToElementRepository("Trigger120", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Start_Trigger120);
							AddToElementRepository("testCase", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Start_testCase);
								AddToElementRepository("LiteralInteger121", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Start_testCase_LiteralInteger121);
								AddToElementRepository("LiteralInteger122", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Start_testCase_LiteralInteger122);
								AddToElementRepository("LiteralUnlimitedNatural123", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Start_testCase_LiteralUnlimitedNatural123);
						AddToElementRepository("Send S", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S);
							AddToElementRepository("target", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S_target);
								AddToElementRepository("LiteralInteger124", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S_target_LiteralInteger124);
								AddToElementRepository("LiteralUnlimitedNatural125", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S_target_LiteralUnlimitedNatural125);
							AddToElementRepository("value", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S_value);
								AddToElementRepository("LiteralInteger126", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S_value_LiteralInteger126);
								AddToElementRepository("LiteralInteger127", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S_value_LiteralInteger127);
								AddToElementRepository("LiteralUnlimitedNatural128", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S_value_LiteralUnlimitedNatural128);
						AddToElementRepository("ObjectFlow129", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow129);
							AddToElementRepository("LiteralBoolean130", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow129_LiteralBoolean130);
							AddToElementRepository("LiteralInteger131", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow129_LiteralInteger131);
						AddToElementRepository("this", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_this);
							AddToElementRepository("result", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_this_result);
								AddToElementRepository("LiteralInteger132", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_this_result_LiteralInteger132);
								AddToElementRepository("LiteralUnlimitedNatural133", Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_this_result_LiteralUnlimitedNatural133);
					AddToElementRepository("Tester_Tester", Signal_AssemblyAndDelegation_Tester_Tester_Tester);
						AddToElementRepository("result", Signal_AssemblyAndDelegation_Tester_Tester_Tester_result);

			// Initialize public members
			/*
			 * Model Signal_AssemblyAndDelegation
			 */
			Signal_AssemblyAndDelegation.SetName("Signal_AssemblyAndDelegation");
			Signal_AssemblyAndDelegation.SetVisibility(VisibilityKind.public_);
				// Activity main
				Signal_AssemblyAndDelegation_main.SetName("main");
				Signal_AssemblyAndDelegation_main.SetVisibility(VisibilityKind.public_);
					// SendSignalAction Send Start
					Signal_AssemblyAndDelegation_main_Send_Start.SetName("Send Start");
					Signal_AssemblyAndDelegation_main_Send_Start.SetVisibility(VisibilityKind.public_);
					Signal_AssemblyAndDelegation_main_Send_Start.SetSignal(Signal_AssemblyAndDelegation_Start);
						// InputPin target
						Signal_AssemblyAndDelegation_main_Send_Start_target.SetName("target");
						Signal_AssemblyAndDelegation_main_Send_Start_target.SetVisibility(VisibilityKind.public_);
						Signal_AssemblyAndDelegation_main_Send_Start_target.SetType(Signal_AssemblyAndDelegation_Tester);
					Signal_AssemblyAndDelegation_main_Send_Start.SetTarget(Signal_AssemblyAndDelegation_main_Send_Start_target);
						// InputPin testCase
						Signal_AssemblyAndDelegation_main_Send_Start_testCase.SetName("testCase");
						Signal_AssemblyAndDelegation_main_Send_Start_testCase.SetVisibility(VisibilityKind.public_);
						Signal_AssemblyAndDelegation_main_Send_Start_testCase.SetType(Signal_AssemblyAndDelegation_TestCase);
					Signal_AssemblyAndDelegation_main_Send_Start.AddArgument(Signal_AssemblyAndDelegation_main_Send_Start_testCase);
				Signal_AssemblyAndDelegation_main.AddNode(Signal_AssemblyAndDelegation_main_Send_Start);
					// CallOperationAction TestCaseAssembly()
					Signal_AssemblyAndDelegation_main_TestCaseAssembly_.SetName("TestCaseAssembly()");
					Signal_AssemblyAndDelegation_main_TestCaseAssembly_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						Signal_AssemblyAndDelegation_main_TestCaseAssembly__result.SetName("result");
						Signal_AssemblyAndDelegation_main_TestCaseAssembly__result.SetVisibility(VisibilityKind.public_);
						Signal_AssemblyAndDelegation_main_TestCaseAssembly__result.SetType(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation);
					Signal_AssemblyAndDelegation_main_TestCaseAssembly_.AddResult(Signal_AssemblyAndDelegation_main_TestCaseAssembly__result);
					Signal_AssemblyAndDelegation_main_TestCaseAssembly_.SetOperation(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation);
						// InputPin target
						Signal_AssemblyAndDelegation_main_TestCaseAssembly__target.SetName("target");
						Signal_AssemblyAndDelegation_main_TestCaseAssembly__target.SetVisibility(VisibilityKind.public_);
						Signal_AssemblyAndDelegation_main_TestCaseAssembly__target.SetType(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation);
					Signal_AssemblyAndDelegation_main_TestCaseAssembly_.SetTarget(Signal_AssemblyAndDelegation_main_TestCaseAssembly__target);
				Signal_AssemblyAndDelegation_main.AddNode(Signal_AssemblyAndDelegation_main_TestCaseAssembly_);
					// CreateObjectAction Create TestCaseAssembly
					Signal_AssemblyAndDelegation_main_Create_TestCaseAssembly.SetName("Create TestCaseAssembly");
					Signal_AssemblyAndDelegation_main_Create_TestCaseAssembly.SetVisibility(VisibilityKind.public_);
					Signal_AssemblyAndDelegation_main_Create_TestCaseAssembly.SetClassifier(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation);
						// OutputPin result
						Signal_AssemblyAndDelegation_main_Create_TestCaseAssembly_result.SetName("result");
						Signal_AssemblyAndDelegation_main_Create_TestCaseAssembly_result.SetVisibility(VisibilityKind.public_);
						Signal_AssemblyAndDelegation_main_Create_TestCaseAssembly_result.SetType(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation);
					Signal_AssemblyAndDelegation_main_Create_TestCaseAssembly.SetResult(Signal_AssemblyAndDelegation_main_Create_TestCaseAssembly_result);
				Signal_AssemblyAndDelegation_main.AddNode(Signal_AssemblyAndDelegation_main_Create_TestCaseAssembly);
					// ForkNode Fork testCase
					Signal_AssemblyAndDelegation_main_Fork_testCase.SetName("Fork testCase");
					Signal_AssemblyAndDelegation_main_Fork_testCase.SetVisibility(VisibilityKind.public_);
				Signal_AssemblyAndDelegation_main.AddNode(Signal_AssemblyAndDelegation_main_Fork_testCase);
					// ReadStructuralFeatureAction Read TestCaseAssembly.c
					Signal_AssemblyAndDelegation_main_Read_TestCaseAssembly_c.SetName("Read TestCaseAssembly.c");
					Signal_AssemblyAndDelegation_main_Read_TestCaseAssembly_c.SetVisibility(VisibilityKind.public_);
					Signal_AssemblyAndDelegation_main_Read_TestCaseAssembly_c.SetStructuralFeature(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_c);
						// InputPin object
						Signal_AssemblyAndDelegation_main_Read_TestCaseAssembly_c_object.SetName("object");
						Signal_AssemblyAndDelegation_main_Read_TestCaseAssembly_c_object.SetVisibility(VisibilityKind.public_);
						Signal_AssemblyAndDelegation_main_Read_TestCaseAssembly_c_object.SetType(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation);
					Signal_AssemblyAndDelegation_main_Read_TestCaseAssembly_c.SetObject(Signal_AssemblyAndDelegation_main_Read_TestCaseAssembly_c_object);
						// OutputPin result
						Signal_AssemblyAndDelegation_main_Read_TestCaseAssembly_c_result.SetName("result");
						Signal_AssemblyAndDelegation_main_Read_TestCaseAssembly_c_result.SetVisibility(VisibilityKind.public_);
						Signal_AssemblyAndDelegation_main_Read_TestCaseAssembly_c_result.SetType(Signal_AssemblyAndDelegation_C);
					Signal_AssemblyAndDelegation_main_Read_TestCaseAssembly_c.SetResult(Signal_AssemblyAndDelegation_main_Read_TestCaseAssembly_c_result);
				Signal_AssemblyAndDelegation_main.AddNode(Signal_AssemblyAndDelegation_main_Read_TestCaseAssembly_c);
					// ReadStructuralFeatureAction Read c.tester
					Signal_AssemblyAndDelegation_main_Read_c_tester.SetName("Read c.tester");
					Signal_AssemblyAndDelegation_main_Read_c_tester.SetVisibility(VisibilityKind.public_);
					Signal_AssemblyAndDelegation_main_Read_c_tester.SetStructuralFeature(Signal_AssemblyAndDelegation_C_tester);
						// InputPin object
						Signal_AssemblyAndDelegation_main_Read_c_tester_object.SetName("object");
						Signal_AssemblyAndDelegation_main_Read_c_tester_object.SetVisibility(VisibilityKind.public_);
						Signal_AssemblyAndDelegation_main_Read_c_tester_object.SetType(Signal_AssemblyAndDelegation_C);
					Signal_AssemblyAndDelegation_main_Read_c_tester.SetObject(Signal_AssemblyAndDelegation_main_Read_c_tester_object);
						// OutputPin result
						Signal_AssemblyAndDelegation_main_Read_c_tester_result.SetName("result");
						Signal_AssemblyAndDelegation_main_Read_c_tester_result.SetVisibility(VisibilityKind.public_);
						Signal_AssemblyAndDelegation_main_Read_c_tester_result.SetType(Signal_AssemblyAndDelegation_Tester);
					Signal_AssemblyAndDelegation_main_Read_c_tester.SetResult(Signal_AssemblyAndDelegation_main_Read_c_tester_result);
				Signal_AssemblyAndDelegation_main.AddNode(Signal_AssemblyAndDelegation_main_Read_c_tester);
					// ObjectFlow ObjectFlow12 from Fork testCase to testCase
					Signal_AssemblyAndDelegation_main_ObjectFlow12.SetName("ObjectFlow12");
					Signal_AssemblyAndDelegation_main_ObjectFlow12.SetVisibility(VisibilityKind.public_);
					
					Signal_AssemblyAndDelegation_main_ObjectFlow12.SetSource(Signal_AssemblyAndDelegation_main_Fork_testCase);
					Signal_AssemblyAndDelegation_main_ObjectFlow12.SetTarget(Signal_AssemblyAndDelegation_main_Send_Start_testCase);
						// LiteralBoolean LiteralBoolean14
						Signal_AssemblyAndDelegation_main_ObjectFlow12_LiteralBoolean14.SetName("LiteralBoolean14");
						Signal_AssemblyAndDelegation_main_ObjectFlow12_LiteralBoolean14.SetVisibility(VisibilityKind.public_);
						Signal_AssemblyAndDelegation_main_ObjectFlow12_LiteralBoolean14.SetValue(true);
					Signal_AssemblyAndDelegation_main_ObjectFlow12.SetGuard(Signal_AssemblyAndDelegation_main_ObjectFlow12_LiteralBoolean14);
				Signal_AssemblyAndDelegation_main.AddEdge(Signal_AssemblyAndDelegation_main_ObjectFlow12);
					// ObjectFlow ObjectFlow15 from result to Fork testCase
					Signal_AssemblyAndDelegation_main_ObjectFlow15.SetName("ObjectFlow15");
					Signal_AssemblyAndDelegation_main_ObjectFlow15.SetVisibility(VisibilityKind.public_);
					
					Signal_AssemblyAndDelegation_main_ObjectFlow15.SetSource(Signal_AssemblyAndDelegation_main_TestCaseAssembly__result);
					Signal_AssemblyAndDelegation_main_ObjectFlow15.SetTarget(Signal_AssemblyAndDelegation_main_Fork_testCase);
						// LiteralBoolean LiteralBoolean17
						Signal_AssemblyAndDelegation_main_ObjectFlow15_LiteralBoolean17.SetName("LiteralBoolean17");
						Signal_AssemblyAndDelegation_main_ObjectFlow15_LiteralBoolean17.SetVisibility(VisibilityKind.public_);
						Signal_AssemblyAndDelegation_main_ObjectFlow15_LiteralBoolean17.SetValue(true);
					Signal_AssemblyAndDelegation_main_ObjectFlow15.SetGuard(Signal_AssemblyAndDelegation_main_ObjectFlow15_LiteralBoolean17);
				Signal_AssemblyAndDelegation_main.AddEdge(Signal_AssemblyAndDelegation_main_ObjectFlow15);
					// ObjectFlow ObjectFlow18 from Fork testCase to object
					Signal_AssemblyAndDelegation_main_ObjectFlow18.SetName("ObjectFlow18");
					Signal_AssemblyAndDelegation_main_ObjectFlow18.SetVisibility(VisibilityKind.public_);
					
					Signal_AssemblyAndDelegation_main_ObjectFlow18.SetSource(Signal_AssemblyAndDelegation_main_Fork_testCase);
					Signal_AssemblyAndDelegation_main_ObjectFlow18.SetTarget(Signal_AssemblyAndDelegation_main_Read_TestCaseAssembly_c_object);
						// LiteralBoolean LiteralBoolean20
						Signal_AssemblyAndDelegation_main_ObjectFlow18_LiteralBoolean20.SetName("LiteralBoolean20");
						Signal_AssemblyAndDelegation_main_ObjectFlow18_LiteralBoolean20.SetVisibility(VisibilityKind.public_);
						Signal_AssemblyAndDelegation_main_ObjectFlow18_LiteralBoolean20.SetValue(true);
					Signal_AssemblyAndDelegation_main_ObjectFlow18.SetGuard(Signal_AssemblyAndDelegation_main_ObjectFlow18_LiteralBoolean20);
				Signal_AssemblyAndDelegation_main.AddEdge(Signal_AssemblyAndDelegation_main_ObjectFlow18);
					// ObjectFlow ObjectFlow21 from result to target
					Signal_AssemblyAndDelegation_main_ObjectFlow21.SetName("ObjectFlow21");
					Signal_AssemblyAndDelegation_main_ObjectFlow21.SetVisibility(VisibilityKind.public_);
					
					Signal_AssemblyAndDelegation_main_ObjectFlow21.SetSource(Signal_AssemblyAndDelegation_main_Create_TestCaseAssembly_result);
					Signal_AssemblyAndDelegation_main_ObjectFlow21.SetTarget(Signal_AssemblyAndDelegation_main_TestCaseAssembly__target);
						// LiteralBoolean LiteralBoolean22
						Signal_AssemblyAndDelegation_main_ObjectFlow21_LiteralBoolean22.SetName("LiteralBoolean22");
						Signal_AssemblyAndDelegation_main_ObjectFlow21_LiteralBoolean22.SetVisibility(VisibilityKind.public_);
						Signal_AssemblyAndDelegation_main_ObjectFlow21_LiteralBoolean22.SetValue(true);
					Signal_AssemblyAndDelegation_main_ObjectFlow21.SetGuard(Signal_AssemblyAndDelegation_main_ObjectFlow21_LiteralBoolean22);
				Signal_AssemblyAndDelegation_main.AddEdge(Signal_AssemblyAndDelegation_main_ObjectFlow21);
					// ObjectFlow ObjectFlow24 from result to target
					Signal_AssemblyAndDelegation_main_ObjectFlow24.SetName("ObjectFlow24");
					Signal_AssemblyAndDelegation_main_ObjectFlow24.SetVisibility(VisibilityKind.public_);
					
					Signal_AssemblyAndDelegation_main_ObjectFlow24.SetSource(Signal_AssemblyAndDelegation_main_Read_c_tester_result);
					Signal_AssemblyAndDelegation_main_ObjectFlow24.SetTarget(Signal_AssemblyAndDelegation_main_Send_Start_target);
						// LiteralBoolean LiteralBoolean26
						Signal_AssemblyAndDelegation_main_ObjectFlow24_LiteralBoolean26.SetName("LiteralBoolean26");
						Signal_AssemblyAndDelegation_main_ObjectFlow24_LiteralBoolean26.SetVisibility(VisibilityKind.public_);
						Signal_AssemblyAndDelegation_main_ObjectFlow24_LiteralBoolean26.SetValue(true);
					Signal_AssemblyAndDelegation_main_ObjectFlow24.SetGuard(Signal_AssemblyAndDelegation_main_ObjectFlow24_LiteralBoolean26);
				Signal_AssemblyAndDelegation_main.AddEdge(Signal_AssemblyAndDelegation_main_ObjectFlow24);
					// ObjectFlow ObjectFlow27 from result to object
					Signal_AssemblyAndDelegation_main_ObjectFlow27.SetName("ObjectFlow27");
					Signal_AssemblyAndDelegation_main_ObjectFlow27.SetVisibility(VisibilityKind.public_);
					
					Signal_AssemblyAndDelegation_main_ObjectFlow27.SetSource(Signal_AssemblyAndDelegation_main_Read_TestCaseAssembly_c_result);
					Signal_AssemblyAndDelegation_main_ObjectFlow27.SetTarget(Signal_AssemblyAndDelegation_main_Read_c_tester_object);
						// LiteralBoolean LiteralBoolean29
						Signal_AssemblyAndDelegation_main_ObjectFlow27_LiteralBoolean29.SetName("LiteralBoolean29");
						Signal_AssemblyAndDelegation_main_ObjectFlow27_LiteralBoolean29.SetVisibility(VisibilityKind.public_);
						Signal_AssemblyAndDelegation_main_ObjectFlow27_LiteralBoolean29.SetValue(true);
					Signal_AssemblyAndDelegation_main_ObjectFlow27.SetGuard(Signal_AssemblyAndDelegation_main_ObjectFlow27_LiteralBoolean29);
				Signal_AssemblyAndDelegation_main.AddEdge(Signal_AssemblyAndDelegation_main_ObjectFlow27);
			Signal_AssemblyAndDelegation.AddPackagedElement(Signal_AssemblyAndDelegation_main);
				// SignalEvent StartEvent
				Signal_AssemblyAndDelegation_StartEvent.SetName("StartEvent");
				Signal_AssemblyAndDelegation_StartEvent.SetVisibility(VisibilityKind.public_);
				Signal_AssemblyAndDelegation_StartEvent.SetSignal(Signal_AssemblyAndDelegation_Start);
			Signal_AssemblyAndDelegation.AddPackagedElement(Signal_AssemblyAndDelegation_StartEvent);
				// Class B
				Signal_AssemblyAndDelegation_B.SetName("B");
				Signal_AssemblyAndDelegation_B.SetVisibility(VisibilityKind.public_);
				
					// Port p
					Signal_AssemblyAndDelegation_B_p.SetName("p");
					Signal_AssemblyAndDelegation_B_p.SetVisibility(VisibilityKind.public_);
					
					Signal_AssemblyAndDelegation_B_p.SetType(Signal_AssemblyAndDelegation_I);
					Signal_AssemblyAndDelegation_B_p.SetAggregation(AggregationKind.composite);
					Signal_AssemblyAndDelegation_B_p.isService = true;
				Signal_AssemblyAndDelegation_B.AddOwnedAttribute(Signal_AssemblyAndDelegation_B_p);
					// Property a
					Signal_AssemblyAndDelegation_B_a.SetName("a");
					Signal_AssemblyAndDelegation_B_a.SetVisibility(VisibilityKind.public_);
					
					Signal_AssemblyAndDelegation_B_a.SetType(Signal_AssemblyAndDelegation_A);
					Signal_AssemblyAndDelegation_B_a.SetAggregation(AggregationKind.composite);
				Signal_AssemblyAndDelegation_B.AddOwnedAttribute(Signal_AssemblyAndDelegation_B_a);
				
				Signal_AssemblyAndDelegation_B_r.SetName("r");
					Signal_AssemblyAndDelegation_B_r.SetVisibility(VisibilityKind.public_);
						
						Signal_AssemblyAndDelegation_B_r_ConnectorEnd39.SetRole(Signal_AssemblyAndDelegation_A_p);
						Signal_AssemblyAndDelegation_B_r_ConnectorEnd39.SetPartWithPort(Signal_AssemblyAndDelegation_B_a);
						
					Signal_AssemblyAndDelegation_B_r.AddEnd(Signal_AssemblyAndDelegation_B_r_ConnectorEnd39);
						
						Signal_AssemblyAndDelegation_B_r_ConnectorEnd38.SetRole(Signal_AssemblyAndDelegation_B_p);
						
					Signal_AssemblyAndDelegation_B_r.AddEnd(Signal_AssemblyAndDelegation_B_r_ConnectorEnd38);
					Signal_AssemblyAndDelegation_B_r.SetType(Signal_AssemblyAndDelegation_R);
				Signal_AssemblyAndDelegation_B.AddOwnedConnector(Signal_AssemblyAndDelegation_B_r);
			Signal_AssemblyAndDelegation.AddPackagedElement(Signal_AssemblyAndDelegation_B);
				// Class I
				Signal_AssemblyAndDelegation_I.SetName("I");
				Signal_AssemblyAndDelegation_I.SetVisibility(VisibilityKind.public_);
			Signal_AssemblyAndDelegation.AddPackagedElement(Signal_AssemblyAndDelegation_I);
				// SignalEvent SEvent
				Signal_AssemblyAndDelegation_SEvent.SetName("SEvent");
				Signal_AssemblyAndDelegation_SEvent.SetVisibility(VisibilityKind.public_);
				Signal_AssemblyAndDelegation_SEvent.SetSignal(Signal_AssemblyAndDelegation_S);
			Signal_AssemblyAndDelegation.AddPackagedElement(Signal_AssemblyAndDelegation_SEvent);
				// Signal S
				Signal_AssemblyAndDelegation_S.SetName("S");
				Signal_AssemblyAndDelegation_S.SetVisibility(VisibilityKind.public_);
				
					// Property value
					Signal_AssemblyAndDelegation_S_value.SetName("value");
					Signal_AssemblyAndDelegation_S_value.SetVisibility(VisibilityKind.public_);
					
					Signal_AssemblyAndDelegation_S_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
				Signal_AssemblyAndDelegation_S.AddOwnedAttribute(Signal_AssemblyAndDelegation_S_value);
			Signal_AssemblyAndDelegation.AddPackagedElement(Signal_AssemblyAndDelegation_S);
				// Class TestCaseAssemblyAndDelegation
				Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation.SetName("TestCaseAssemblyAndDelegation");
				Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation.SetVisibility(VisibilityKind.public_);
				
					// Generalization to TestCase
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_Generalization71.SetGeneral(Signal_AssemblyAndDelegation_TestCase);
				Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation.AddGeneralization(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_Generalization71);
					// Property b
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_b.SetName("b");
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_b.SetVisibility(VisibilityKind.public_);
					
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_b.SetType(Signal_AssemblyAndDelegation_B);
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_b.SetAggregation(AggregationKind.composite);
				Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation.AddOwnedAttribute(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_b);
					// Property c
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_c.SetName("c");
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_c.SetVisibility(VisibilityKind.public_);
					
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_c.SetType(Signal_AssemblyAndDelegation_C);
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_c.SetAggregation(AggregationKind.composite);
				Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation.AddOwnedAttribute(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_c);
				// Activity testActivity
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity.SetName("testActivity");
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity.SetVisibility(VisibilityKind.public_);
					// FunctionBehavior testV
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_testV.SetName("testV");
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_testV.SetVisibility(VisibilityKind.public_);
						
							// Parameter v
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_testV_v.SetName("v");
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_testV_v.SetVisibility(VisibilityKind.public_);
							
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_testV_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_testV.AddOwnedParameter(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_testV_v);
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_testV.AddLanguage("C#");
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_testV.AddLanguage("Using");
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_testV.AddBody("Console.WriteLine(\"Asserting b.a.v == 4\");  	// Test parameter v 	int v = ((IntegerValue)inputParameters.ElementAt(0).values.ElementAt(0)).value; 	Debug.Println(\"[doBody] argument v = \" + v); 	 	Console.WriteLine(\"b.a.v == \" + v); 	Console.Write(\"Signal correctly sent and received: \");  	if(v == 4) 	{ 		Console.ForegroundColor = ConsoleColor.Green; 		Console.WriteLine(\"Assertion successful.\"); 	} 	else 	{ 		Console.ForegroundColor = ConsoleColor.Red; 		Console.WriteLine(\"Assertion failed!\"); 	}  	Console.ResetColor();");
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_testV.AddBody("using fuml.semantics.simpleclassifiers;");
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity.AddOwnedBehavior(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_testV);
						// ReadStructuralFeatureAction Read b.a
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_b_a.SetName("Read b.a");
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_b_a.SetVisibility(VisibilityKind.public_);
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_b_a.SetStructuralFeature(Signal_AssemblyAndDelegation_B_a);
							// InputPin object
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_b_a_object.SetName("object");
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_b_a_object.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_b_a_object.SetType(Signal_AssemblyAndDelegation_B);
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_b_a.SetObject(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_b_a_object);
							// OutputPin result
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_b_a_result.SetName("result");
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_b_a_result.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_b_a_result.SetType(Signal_AssemblyAndDelegation_A);
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_b_a.SetResult(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_b_a_result);
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity.AddNode(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_b_a);
						// CallBehaviorAction Call testV
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Call_testV.SetName("Call testV");
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Call_testV.SetVisibility(VisibilityKind.public_);
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Call_testV.SetBehavior(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_testV);
							// InputPin v
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Call_testV_v.SetName("v");
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Call_testV_v.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Call_testV_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Call_testV.AddArgument(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Call_testV_v);
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity.AddNode(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Call_testV);
						// ReadSelfAction this
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_this.SetName("this");
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_this_result.SetName("result");
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_this_result.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_this_result.SetType(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation);
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_this.SetResult(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_this_result);
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity.AddNode(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_this);
						// ReadStructuralFeatureAction Read a.v
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_a_v.SetName("Read a.v");
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_a_v.SetVisibility(VisibilityKind.public_);
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_a_v.SetStructuralFeature(Signal_AssemblyAndDelegation_A_v);
							// InputPin object
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_a_v_object.SetName("object");
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_a_v_object.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_a_v_object.SetType(Signal_AssemblyAndDelegation_A);
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_a_v.SetObject(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_a_v_object);
							// OutputPin result
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_a_v_result.SetName("result");
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_a_v_result.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_a_v_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_a_v.SetResult(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_a_v_result);
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity.AddNode(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_a_v);
						// ReadStructuralFeatureAction Read this.b
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_this_b.SetName("Read this.b");
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_this_b.SetVisibility(VisibilityKind.public_);
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_this_b.SetStructuralFeature(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_b);
							// InputPin object
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_this_b_object.SetName("object");
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_this_b_object.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_this_b_object.SetType(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation);
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_this_b.SetObject(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_this_b_object);
							// OutputPin result
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_this_b_result.SetName("result");
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_this_b_result.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_this_b_result.SetType(Signal_AssemblyAndDelegation_B);
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_this_b.SetResult(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_this_b_result);
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity.AddNode(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_this_b);
						// ObjectFlow ObjectFlow46 from result to object
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow46.SetName("ObjectFlow46");
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow46.SetVisibility(VisibilityKind.public_);
						
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow46.SetSource(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_this_b_result);
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow46.SetTarget(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_b_a_object);
							// LiteralBoolean LiteralBoolean48
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow46_LiteralBoolean48.SetName("LiteralBoolean48");
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow46_LiteralBoolean48.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow46_LiteralBoolean48.SetValue(true);
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow46.SetGuard(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow46_LiteralBoolean48);
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity.AddEdge(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow46);
						// ObjectFlow ObjectFlow52 from result to v
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow52.SetName("ObjectFlow52");
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow52.SetVisibility(VisibilityKind.public_);
						
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow52.SetSource(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_a_v_result);
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow52.SetTarget(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Call_testV_v);
							// LiteralBoolean LiteralBoolean54
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow52_LiteralBoolean54.SetName("LiteralBoolean54");
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow52_LiteralBoolean54.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow52_LiteralBoolean54.SetValue(true);
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow52.SetGuard(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow52_LiteralBoolean54);
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity.AddEdge(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow52);
						// ObjectFlow ObjectFlow61 from result to object
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow61.SetName("ObjectFlow61");
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow61.SetVisibility(VisibilityKind.public_);
						
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow61.SetSource(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_b_a_result);
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow61.SetTarget(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_a_v_object);
							// LiteralBoolean LiteralBoolean63
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow61_LiteralBoolean63.SetName("LiteralBoolean63");
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow61_LiteralBoolean63.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow61_LiteralBoolean63.SetValue(true);
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow61.SetGuard(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow61_LiteralBoolean63);
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity.AddEdge(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow61);
						// ObjectFlow ObjectFlow64 from result to object
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow64.SetName("ObjectFlow64");
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow64.SetVisibility(VisibilityKind.public_);
						
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow64.SetSource(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_this_result);
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow64.SetTarget(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_Read_this_b_object);
							// LiteralBoolean LiteralBoolean66
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow64_LiteralBoolean66.SetName("LiteralBoolean66");
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow64_LiteralBoolean66.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow64_LiteralBoolean66.SetValue(true);
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow64.SetGuard(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow64_LiteralBoolean66);
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity.AddEdge(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity_ObjectFlow64);
				Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation.AddOwnedBehavior(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity);
				Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_r.SetName("r");
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_r.SetVisibility(VisibilityKind.public_);
						
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_r_ConnectorEnd41.SetRole(Signal_AssemblyAndDelegation_B_p);
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_r_ConnectorEnd41.SetPartWithPort(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_b);
						
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_r.AddEnd(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_r_ConnectorEnd41);
						
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_r_ConnectorEnd40.SetRole(Signal_AssemblyAndDelegation_C_q);
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_r_ConnectorEnd40.SetPartWithPort(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_c);
						
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_r.AddEnd(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_r_ConnectorEnd40);
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_r.SetType(Signal_AssemblyAndDelegation_R);
				Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation.AddOwnedConnector(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_r);
					// Operation TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation.SetName("TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation");
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation.SetVisibility(VisibilityKind.public_);
						// Parameter result
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation_result.SetName("result");
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation_result.SetVisibility(VisibilityKind.public_);
						
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation_result.SetType(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation);
						Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation_result.SetDirection(ParameterDirectionKind.return_);
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation.AddOwnedParameter(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation_result);
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation.AddOwnedOperation(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation_TestCaseAssemblyAndDelegation);
					// Operation test
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_test.SetName("test");
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_test.SetVisibility(VisibilityKind.public_);
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_test.AddMethod(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_testActivity);
					Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_test.AddRedefinedOperation(Signal_AssemblyAndDelegation_TestCase_test);
				Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation.AddOwnedOperation(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation_test);
			Signal_AssemblyAndDelegation.AddPackagedElement(Signal_AssemblyAndDelegation_TestCaseAssemblyAndDelegation);
				// Class A
				Signal_AssemblyAndDelegation_A.SetName("A");
				Signal_AssemblyAndDelegation_A.SetVisibility(VisibilityKind.public_);
				
					// Property v
					Signal_AssemblyAndDelegation_A_v.SetName("v");
					Signal_AssemblyAndDelegation_A_v.SetVisibility(VisibilityKind.public_);
					
					Signal_AssemblyAndDelegation_A_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Signal_AssemblyAndDelegation_A_v.SetAggregation(AggregationKind.shared);
				Signal_AssemblyAndDelegation_A.AddOwnedAttribute(Signal_AssemblyAndDelegation_A_v);
					// Port p
					Signal_AssemblyAndDelegation_A_p.SetName("p");
					Signal_AssemblyAndDelegation_A_p.SetVisibility(VisibilityKind.public_);
					
					Signal_AssemblyAndDelegation_A_p.SetType(Signal_AssemblyAndDelegation_I);
					Signal_AssemblyAndDelegation_A_p.SetAggregation(AggregationKind.composite);
					Signal_AssemblyAndDelegation_A_p.isBehavior = true;
					Signal_AssemblyAndDelegation_A_p.isService = true;
				Signal_AssemblyAndDelegation_A.AddOwnedAttribute(Signal_AssemblyAndDelegation_A_p);
				Signal_AssemblyAndDelegation_A.SetClassifierBehavior(Signal_AssemblyAndDelegation_A_AClassifierBehavior);
					// Activity AClassifierBehavior
					Signal_AssemblyAndDelegation_A_AClassifierBehavior.SetName("AClassifierBehavior");
					Signal_AssemblyAndDelegation_A_AClassifierBehavior.SetVisibility(VisibilityKind.public_);
					
					Signal_AssemblyAndDelegation_A_AClassifierBehavior.isReentrant = false;
						// ReadSelfAction this
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_this.SetName("this");
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							Signal_AssemblyAndDelegation_A_AClassifierBehavior_this_result.SetName("result");
							Signal_AssemblyAndDelegation_A_AClassifierBehavior_this_result.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_A_AClassifierBehavior_this_result.SetType(Signal_AssemblyAndDelegation_A);
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_this.SetResult(Signal_AssemblyAndDelegation_A_AClassifierBehavior_this_result);
					Signal_AssemblyAndDelegation_A_AClassifierBehavior.AddNode(Signal_AssemblyAndDelegation_A_AClassifierBehavior_this);
						// SendSignalAction Send Continue
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_Send_Continue.SetName("Send Continue");
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_Send_Continue.SetVisibility(VisibilityKind.public_);
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_Send_Continue.SetSignal(Signal_AssemblyAndDelegation_Continue);
							// InputPin target
							Signal_AssemblyAndDelegation_A_AClassifierBehavior_Send_Continue_target.SetName("target");
							Signal_AssemblyAndDelegation_A_AClassifierBehavior_Send_Continue_target.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_A_AClassifierBehavior_Send_Continue_target.SetType(Signal_AssemblyAndDelegation_A);
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_Send_Continue.SetTarget(Signal_AssemblyAndDelegation_A_AClassifierBehavior_Send_Continue_target);
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_Send_Continue.SetOnPort(Signal_AssemblyAndDelegation_A_p);
					Signal_AssemblyAndDelegation_A_AClassifierBehavior.AddNode(Signal_AssemblyAndDelegation_A_AClassifierBehavior_Send_Continue);
						// ActivityFinalNode ActivityFinalNode80
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_ActivityFinalNode80.SetName("ActivityFinalNode80");
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_ActivityFinalNode80.SetVisibility(VisibilityKind.public_);
					Signal_AssemblyAndDelegation_A_AClassifierBehavior.AddNode(Signal_AssemblyAndDelegation_A_AClassifierBehavior_ActivityFinalNode80);
						// AcceptEventAction Accept S
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_Accept_S.SetName("Accept S");
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_Accept_S.SetVisibility(VisibilityKind.public_);
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_Accept_S.SetIsUnmarshall(true);
							// OutputPin value
							Signal_AssemblyAndDelegation_A_AClassifierBehavior_Accept_S_value.SetName("value");
							Signal_AssemblyAndDelegation_A_AClassifierBehavior_Accept_S_value.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_A_AClassifierBehavior_Accept_S_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_Accept_S.AddResult(Signal_AssemblyAndDelegation_A_AClassifierBehavior_Accept_S_value);
							// Trigger Trigger88
							Signal_AssemblyAndDelegation_A_AClassifierBehavior_Accept_S_Trigger88.SetName("Trigger88");
							Signal_AssemblyAndDelegation_A_AClassifierBehavior_Accept_S_Trigger88.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_A_AClassifierBehavior_Accept_S_Trigger88.SetEvent(Signal_AssemblyAndDelegation_SEvent);
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_Accept_S.AddTrigger(Signal_AssemblyAndDelegation_A_AClassifierBehavior_Accept_S_Trigger88);
					Signal_AssemblyAndDelegation_A_AClassifierBehavior.AddNode(Signal_AssemblyAndDelegation_A_AClassifierBehavior_Accept_S);
						// AddStructuralFeatureValueAction Set v
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v.SetName("Set v");
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v.SetVisibility(VisibilityKind.public_);
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v.SetStructuralFeature(Signal_AssemblyAndDelegation_A_v);
							// InputPin object
							Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_object.SetName("object");
							Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_object.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_object.SetType(Signal_AssemblyAndDelegation_A);
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v.SetObject(Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_object);
							// InputPin value
							Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_value.SetName("value");
							Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_value.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v.SetValue(Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_value);
							// OutputPin result
							Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_result.SetName("result");
							Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_result.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_result.SetType(Signal_AssemblyAndDelegation_A);
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v.SetResult(Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_result);
					Signal_AssemblyAndDelegation_A_AClassifierBehavior.AddNode(Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v);
						// ControlFlow ControlFlow72 from Send Continue to ActivityFinalNode80
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_ControlFlow72.SetName("ControlFlow72");
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_ControlFlow72.SetVisibility(VisibilityKind.public_);
						
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_ControlFlow72.SetSource(Signal_AssemblyAndDelegation_A_AClassifierBehavior_Send_Continue);
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_ControlFlow72.SetTarget(Signal_AssemblyAndDelegation_A_AClassifierBehavior_ActivityFinalNode80);
					Signal_AssemblyAndDelegation_A_AClassifierBehavior.AddEdge(Signal_AssemblyAndDelegation_A_AClassifierBehavior_ControlFlow72);
						// ObjectFlow ObjectFlow75 from result to object
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow75.SetName("ObjectFlow75");
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow75.SetVisibility(VisibilityKind.public_);
						
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow75.SetSource(Signal_AssemblyAndDelegation_A_AClassifierBehavior_this_result);
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow75.SetTarget(Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_object);
							// LiteralBoolean LiteralBoolean77
							Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow75_LiteralBoolean77.SetName("LiteralBoolean77");
							Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow75_LiteralBoolean77.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow75_LiteralBoolean77.SetValue(true);
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow75.SetGuard(Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow75_LiteralBoolean77);
					Signal_AssemblyAndDelegation_A_AClassifierBehavior.AddEdge(Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow75);
						// ObjectFlow ObjectFlow81 from value to value
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow81.SetName("ObjectFlow81");
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow81.SetVisibility(VisibilityKind.public_);
						
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow81.SetSource(Signal_AssemblyAndDelegation_A_AClassifierBehavior_Accept_S_value);
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow81.SetTarget(Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_value);
							// LiteralBoolean LiteralBoolean83
							Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow81_LiteralBoolean83.SetName("LiteralBoolean83");
							Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow81_LiteralBoolean83.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow81_LiteralBoolean83.SetValue(true);
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow81.SetGuard(Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow81_LiteralBoolean83);
					Signal_AssemblyAndDelegation_A_AClassifierBehavior.AddEdge(Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow81);
						// ControlFlow ControlFlow84 from Accept S to this
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_ControlFlow84.SetName("ControlFlow84");
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_ControlFlow84.SetVisibility(VisibilityKind.public_);
						
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_ControlFlow84.SetSource(Signal_AssemblyAndDelegation_A_AClassifierBehavior_Accept_S);
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_ControlFlow84.SetTarget(Signal_AssemblyAndDelegation_A_AClassifierBehavior_this);
					Signal_AssemblyAndDelegation_A_AClassifierBehavior.AddEdge(Signal_AssemblyAndDelegation_A_AClassifierBehavior_ControlFlow84);
						// ObjectFlow ObjectFlow89 from result to target
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow89.SetName("ObjectFlow89");
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow89.SetVisibility(VisibilityKind.public_);
						
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow89.SetSource(Signal_AssemblyAndDelegation_A_AClassifierBehavior_Set_v_result);
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow89.SetTarget(Signal_AssemblyAndDelegation_A_AClassifierBehavior_Send_Continue_target);
							// LiteralBoolean LiteralBoolean90
							Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow89_LiteralBoolean90.SetName("LiteralBoolean90");
							Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow89_LiteralBoolean90.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow89_LiteralBoolean90.SetValue(true);
						Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow89.SetGuard(Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow89_LiteralBoolean90);
					Signal_AssemblyAndDelegation_A_AClassifierBehavior.AddEdge(Signal_AssemblyAndDelegation_A_AClassifierBehavior_ObjectFlow89);
				Signal_AssemblyAndDelegation_A.AddOwnedBehavior(Signal_AssemblyAndDelegation_A_AClassifierBehavior);
				
				Signal_AssemblyAndDelegation_A.SetIsActive(true);
					// Operation A_A
					Signal_AssemblyAndDelegation_A_A_A.SetName("A_A");
					Signal_AssemblyAndDelegation_A_A_A.SetVisibility(VisibilityKind.public_);
						// Parameter result
						Signal_AssemblyAndDelegation_A_A_A_result.SetName("result");
						Signal_AssemblyAndDelegation_A_A_A_result.SetVisibility(VisibilityKind.public_);
						
						Signal_AssemblyAndDelegation_A_A_A_result.SetType(Signal_AssemblyAndDelegation_A);
						Signal_AssemblyAndDelegation_A_A_A_result.SetDirection(ParameterDirectionKind.return_);
					Signal_AssemblyAndDelegation_A_A_A.AddOwnedParameter(Signal_AssemblyAndDelegation_A_A_A_result);
					Signal_AssemblyAndDelegation_A_A_A.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				Signal_AssemblyAndDelegation_A.AddOwnedOperation(Signal_AssemblyAndDelegation_A_A_A);
			Signal_AssemblyAndDelegation.AddPackagedElement(Signal_AssemblyAndDelegation_A);
				// Signal Continue
				Signal_AssemblyAndDelegation_Continue.SetName("Continue");
				Signal_AssemblyAndDelegation_Continue.SetVisibility(VisibilityKind.public_);
			Signal_AssemblyAndDelegation.AddPackagedElement(Signal_AssemblyAndDelegation_Continue);
				// SignalEvent ContinueEvent
				Signal_AssemblyAndDelegation_ContinueEvent.SetName("ContinueEvent");
				Signal_AssemblyAndDelegation_ContinueEvent.SetVisibility(VisibilityKind.public_);
				Signal_AssemblyAndDelegation_ContinueEvent.SetSignal(Signal_AssemblyAndDelegation_Continue);
			Signal_AssemblyAndDelegation.AddPackagedElement(Signal_AssemblyAndDelegation_ContinueEvent);
				// Class C
				Signal_AssemblyAndDelegation_C.SetName("C");
				Signal_AssemblyAndDelegation_C.SetVisibility(VisibilityKind.public_);
				
					// Port q
					Signal_AssemblyAndDelegation_C_q.SetName("q");
					Signal_AssemblyAndDelegation_C_q.SetVisibility(VisibilityKind.public_);
					
					Signal_AssemblyAndDelegation_C_q.SetType(Signal_AssemblyAndDelegation_I);
					Signal_AssemblyAndDelegation_C_q.SetAggregation(AggregationKind.composite);
					Signal_AssemblyAndDelegation_C_q.isService = true;
				Signal_AssemblyAndDelegation_C.AddOwnedAttribute(Signal_AssemblyAndDelegation_C_q);
					// Property tester
					Signal_AssemblyAndDelegation_C_tester.SetName("tester");
					Signal_AssemblyAndDelegation_C_tester.SetVisibility(VisibilityKind.public_);
					
					Signal_AssemblyAndDelegation_C_tester.SetType(Signal_AssemblyAndDelegation_Tester);
					Signal_AssemblyAndDelegation_C_tester.SetAggregation(AggregationKind.composite);
				Signal_AssemblyAndDelegation_C.AddOwnedAttribute(Signal_AssemblyAndDelegation_C_tester);
				
				Signal_AssemblyAndDelegation_C_r.SetName("r");
					Signal_AssemblyAndDelegation_C_r.SetVisibility(VisibilityKind.public_);
						
						Signal_AssemblyAndDelegation_C_r_ConnectorEnd98.SetRole(Signal_AssemblyAndDelegation_C_q);
						
					Signal_AssemblyAndDelegation_C_r.AddEnd(Signal_AssemblyAndDelegation_C_r_ConnectorEnd98);
						
						Signal_AssemblyAndDelegation_C_r_ConnectorEnd99.SetRole(Signal_AssemblyAndDelegation_Tester_q);
						Signal_AssemblyAndDelegation_C_r_ConnectorEnd99.SetPartWithPort(Signal_AssemblyAndDelegation_C_tester);
						
					Signal_AssemblyAndDelegation_C_r.AddEnd(Signal_AssemblyAndDelegation_C_r_ConnectorEnd99);
					Signal_AssemblyAndDelegation_C_r.SetType(Signal_AssemblyAndDelegation_R);
				Signal_AssemblyAndDelegation_C.AddOwnedConnector(Signal_AssemblyAndDelegation_C_r);
			Signal_AssemblyAndDelegation.AddPackagedElement(Signal_AssemblyAndDelegation_C);
				// Class TestCase
				Signal_AssemblyAndDelegation_TestCase.SetName("TestCase");
				Signal_AssemblyAndDelegation_TestCase.SetVisibility(VisibilityKind.public_);
				
				Signal_AssemblyAndDelegation_TestCase.SetIsAbstract(true);
				
				
					// Operation test
					Signal_AssemblyAndDelegation_TestCase_test.SetName("test");
					Signal_AssemblyAndDelegation_TestCase_test.SetVisibility(VisibilityKind.public_);
					Signal_AssemblyAndDelegation_TestCase_test.SetIsAbstract(true);
				Signal_AssemblyAndDelegation_TestCase.AddOwnedOperation(Signal_AssemblyAndDelegation_TestCase_test);
			Signal_AssemblyAndDelegation.AddPackagedElement(Signal_AssemblyAndDelegation_TestCase);
				// Association R
				Signal_AssemblyAndDelegation_R.SetName("R");
				Signal_AssemblyAndDelegation_R.SetVisibility(VisibilityKind.public_);
				Signal_AssemblyAndDelegation_R.AddOwnedEnd(Signal_AssemblyAndDelegation_R_x);
				Signal_AssemblyAndDelegation_R.AddOwnedEnd(Signal_AssemblyAndDelegation_R_y);
			Signal_AssemblyAndDelegation.AddPackagedElement(Signal_AssemblyAndDelegation_R);
				// Signal Start
				Signal_AssemblyAndDelegation_Start.SetName("Start");
				Signal_AssemblyAndDelegation_Start.SetVisibility(VisibilityKind.public_);
				
					// Property testCase
					Signal_AssemblyAndDelegation_Start_testCase.SetName("testCase");
					Signal_AssemblyAndDelegation_Start_testCase.SetVisibility(VisibilityKind.public_);
					
					Signal_AssemblyAndDelegation_Start_testCase.SetType(Signal_AssemblyAndDelegation_TestCase);
				Signal_AssemblyAndDelegation_Start.AddOwnedAttribute(Signal_AssemblyAndDelegation_Start_testCase);
			Signal_AssemblyAndDelegation.AddPackagedElement(Signal_AssemblyAndDelegation_Start);
				// Class Tester
				Signal_AssemblyAndDelegation_Tester.SetName("Tester");
				Signal_AssemblyAndDelegation_Tester.SetVisibility(VisibilityKind.public_);
				
					// Port q
					Signal_AssemblyAndDelegation_Tester_q.SetName("q");
					Signal_AssemblyAndDelegation_Tester_q.SetVisibility(VisibilityKind.public_);
					
					Signal_AssemblyAndDelegation_Tester_q.SetType(Signal_AssemblyAndDelegation_I);
					Signal_AssemblyAndDelegation_Tester_q.SetAggregation(AggregationKind.composite);
					Signal_AssemblyAndDelegation_Tester_q.isBehavior = true;
					Signal_AssemblyAndDelegation_Tester_q.isService = true;
				Signal_AssemblyAndDelegation_Tester.AddOwnedAttribute(Signal_AssemblyAndDelegation_Tester_q);
				Signal_AssemblyAndDelegation_Tester.SetClassifierBehavior(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior);
					// Activity TesterClassifierBehavior
					Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior.SetName("TesterClassifierBehavior");
					Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior.SetVisibility(VisibilityKind.public_);
					
					Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior.isReentrant = false;
						// ValueSpecificationAction Value(4)
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Value_4.SetName("Value(4)");
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Value_4.SetVisibility(VisibilityKind.public_);
							// LiteralInteger LiteralInteger104
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Value_4_LiteralInteger104.SetName("LiteralInteger104");
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Value_4_LiteralInteger104.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Value_4_LiteralInteger104.SetValue(4);
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Value_4.SetValue(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Value_4_LiteralInteger104);
							// OutputPin result
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Value_4_result.SetName("result");
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Value_4_result.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Value_4_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Value_4.SetResult(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Value_4_result);
					Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior.AddNode(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Value_4);
						// AcceptEventAction Accept Continue
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Continue.SetName("Accept Continue");
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Continue.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Continue_result.SetName("result");
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Continue_result.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Continue_result.SetType(Signal_AssemblyAndDelegation_Continue);
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Continue.AddResult(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Continue_result);
							// Trigger Trigger105
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Continue_Trigger105.SetName("Trigger105");
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Continue_Trigger105.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Continue_Trigger105.SetEvent(Signal_AssemblyAndDelegation_ContinueEvent);
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Continue.AddTrigger(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Continue_Trigger105);
					Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior.AddNode(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Continue);
						// ActivityFinalNode ActivityFinalNode119
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ActivityFinalNode119.SetName("ActivityFinalNode119");
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ActivityFinalNode119.SetVisibility(VisibilityKind.public_);
					Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior.AddNode(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ActivityFinalNode119);
						// AcceptEventAction Accept Start
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Start.SetName("Accept Start");
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Start.SetVisibility(VisibilityKind.public_);
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Start.SetIsUnmarshall(true);
							// OutputPin testCase
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Start_testCase.SetName("testCase");
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Start_testCase.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Start_testCase.SetType(Signal_AssemblyAndDelegation_TestCase);
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Start.AddResult(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Start_testCase);
							// Trigger Trigger120
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Start_Trigger120.SetName("Trigger120");
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Start_Trigger120.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Start_Trigger120.SetEvent(Signal_AssemblyAndDelegation_StartEvent);
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Start.AddTrigger(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Start_Trigger120);
					Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior.AddNode(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Start);
						// SendSignalAction Send S
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S.SetName("Send S");
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S.SetVisibility(VisibilityKind.public_);
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S.SetSignal(Signal_AssemblyAndDelegation_S);
							// InputPin target
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S_target.SetName("target");
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S_target.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S_target.SetType(Signal_AssemblyAndDelegation_Tester);
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S.SetTarget(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S_target);
							// InputPin value
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S_value.SetName("value");
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S_value.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S.AddArgument(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S_value);
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S.SetOnPort(Signal_AssemblyAndDelegation_Tester_q);
					Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior.AddNode(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S);
						// ReadSelfAction this
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_this.SetName("this");
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_this_result.SetName("result");
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_this_result.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_this_result.SetType(Signal_AssemblyAndDelegation_Tester);
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_this.SetResult(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_this_result);
					Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior.AddNode(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_this);
						// CallOperationAction Call test()
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Call_test_.SetName("Call test()");
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Call_test_.SetVisibility(VisibilityKind.public_);
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Call_test_.SetOperation(Signal_AssemblyAndDelegation_TestCase_test);
							// InputPin target
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Call_test__target.SetName("target");
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Call_test__target.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Call_test__target.SetType(Signal_AssemblyAndDelegation_TestCase);
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Call_test_.SetTarget(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Call_test__target);
					Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior.AddNode(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Call_test_);
						// ControlFlow ControlFlow100 from Send S to Accept Continue
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ControlFlow100.SetName("ControlFlow100");
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ControlFlow100.SetVisibility(VisibilityKind.public_);
						
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ControlFlow100.SetSource(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S);
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ControlFlow100.SetTarget(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Continue);
					Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior.AddEdge(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ControlFlow100);
						// ControlFlow ControlFlow115 from Call test() to ActivityFinalNode119
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ControlFlow115.SetName("ControlFlow115");
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ControlFlow115.SetVisibility(VisibilityKind.public_);
						
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ControlFlow115.SetSource(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Call_test_);
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ControlFlow115.SetTarget(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ActivityFinalNode119);
					Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior.AddEdge(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ControlFlow115);
						// ObjectFlow ObjectFlow116 from testCase to target
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow116.SetName("ObjectFlow116");
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow116.SetVisibility(VisibilityKind.public_);
						
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow116.SetSource(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Start_testCase);
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow116.SetTarget(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Call_test__target);
							// LiteralBoolean LiteralBoolean118
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow116_LiteralBoolean118.SetName("LiteralBoolean118");
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow116_LiteralBoolean118.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow116_LiteralBoolean118.SetValue(true);
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow116.SetGuard(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow116_LiteralBoolean118);
					Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior.AddEdge(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow116);
						// ControlFlow ControlFlow101 from Accept Continue to Call test()
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ControlFlow101.SetName("ControlFlow101");
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ControlFlow101.SetVisibility(VisibilityKind.public_);
						
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ControlFlow101.SetSource(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Continue);
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ControlFlow101.SetTarget(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Call_test_);
					Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior.AddEdge(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ControlFlow101);
						// ObjectFlow ObjectFlow109 from result to value
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow109.SetName("ObjectFlow109");
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow109.SetVisibility(VisibilityKind.public_);
						
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow109.SetSource(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Value_4_result);
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow109.SetTarget(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S_value);
							// LiteralBoolean LiteralBoolean110
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow109_LiteralBoolean110.SetName("LiteralBoolean110");
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow109_LiteralBoolean110.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow109_LiteralBoolean110.SetValue(true);
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow109.SetGuard(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow109_LiteralBoolean110);
					Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior.AddEdge(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow109);
						// ObjectFlow ObjectFlow129 from result to target
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow129.SetName("ObjectFlow129");
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow129.SetVisibility(VisibilityKind.public_);
						
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow129.SetSource(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_this_result);
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow129.SetTarget(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Send_S_target);
							// LiteralBoolean LiteralBoolean130
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow129_LiteralBoolean130.SetName("LiteralBoolean130");
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow129_LiteralBoolean130.SetVisibility(VisibilityKind.public_);
							Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow129_LiteralBoolean130.SetValue(true);
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow129.SetGuard(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow129_LiteralBoolean130);
					Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior.AddEdge(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ObjectFlow129);
						// ControlFlow ControlFlow112 from Accept Start to this
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ControlFlow112.SetName("ControlFlow112");
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ControlFlow112.SetVisibility(VisibilityKind.public_);
						
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ControlFlow112.SetSource(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_Accept_Start);
						Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ControlFlow112.SetTarget(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_this);
					Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior.AddEdge(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior_ControlFlow112);
				Signal_AssemblyAndDelegation_Tester.AddOwnedBehavior(Signal_AssemblyAndDelegation_Tester_TesterClassifierBehavior);
				
				Signal_AssemblyAndDelegation_Tester.SetIsActive(true);
					// Operation Tester_Tester
					Signal_AssemblyAndDelegation_Tester_Tester_Tester.SetName("Tester_Tester");
					Signal_AssemblyAndDelegation_Tester_Tester_Tester.SetVisibility(VisibilityKind.public_);
						// Parameter result
						Signal_AssemblyAndDelegation_Tester_Tester_Tester_result.SetName("result");
						Signal_AssemblyAndDelegation_Tester_Tester_Tester_result.SetVisibility(VisibilityKind.public_);
						
						Signal_AssemblyAndDelegation_Tester_Tester_Tester_result.SetType(Signal_AssemblyAndDelegation_Tester);
						Signal_AssemblyAndDelegation_Tester_Tester_Tester_result.SetDirection(ParameterDirectionKind.return_);
					Signal_AssemblyAndDelegation_Tester_Tester_Tester.AddOwnedParameter(Signal_AssemblyAndDelegation_Tester_Tester_Tester_result);
					Signal_AssemblyAndDelegation_Tester_Tester_Tester.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				Signal_AssemblyAndDelegation_Tester.AddOwnedOperation(Signal_AssemblyAndDelegation_Tester_Tester_Tester);
					// Reception Start
					Signal_AssemblyAndDelegation_Tester_Start.SetName("Start");
					Signal_AssemblyAndDelegation_Tester_Start.SetVisibility(VisibilityKind.public_);
					Signal_AssemblyAndDelegation_Tester_Start.SetSignal(Signal_AssemblyAndDelegation_Start);
				Signal_AssemblyAndDelegation_Tester.AddOwnedReception(Signal_AssemblyAndDelegation_Tester_Start);
			Signal_AssemblyAndDelegation.AddPackagedElement(Signal_AssemblyAndDelegation_Tester);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // Signal_AssemblyAndDelegationModel
}
