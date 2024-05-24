/*
 * SingleDelegation_P_P_SignalModel.cs
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

namespace SingleDelegation_P_P_Signal
{
	public class SingleDelegation_P_P_SignalModel : InMemoryModel
	{
		private static SingleDelegation_P_P_SignalModel? instance;

		/*
		 * Model SingleDelegation_P_P_Signal
		 */
		public Package SingleDelegation_P_P_Signal = new();
			public Signal SingleDelegation_P_P_Signal_S = new();
				public Property SingleDelegation_P_P_Signal_S_v = new();
				public Property SingleDelegation_P_P_Signal_S_t = new();
			public SignalEvent SingleDelegation_P_P_Signal_SignalEventContinue = new();
			public Association SingleDelegation_P_P_Signal_R = new();
				public Property SingleDelegation_P_P_Signal_R_y = new();
				public Property SingleDelegation_P_P_Signal_R_x = new();
			public Signal SingleDelegation_P_P_Signal_Continue = new();
			public Class_ SingleDelegation_P_P_Signal_B = new();
				public Operation SingleDelegation_P_P_Signal_B_B_B = new();
					public Parameter SingleDelegation_P_P_Signal_B_B_B_result = new();
				public Activity SingleDelegation_P_P_Signal_B_BClassifierBehavior = new();
					public ObjectFlow SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow0 = new();
						public LiteralBoolean SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow0_LiteralBoolean1 = new();
						public LiteralInteger SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow0_LiteralInteger2 = new();
					public ControlFlow SingleDelegation_P_P_Signal_B_BClassifierBehavior_ControlFlow3 = new();
					public ReadSelfAction SingleDelegation_P_P_Signal_B_BClassifierBehavior_this = new();
						public OutputPin SingleDelegation_P_P_Signal_B_BClassifierBehavior_this_result = new();
							public LiteralInteger SingleDelegation_P_P_Signal_B_BClassifierBehavior_this_result_LiteralInteger4 = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_B_BClassifierBehavior_this_result_LiteralUnlimitedNatural5 = new();
					public ObjectFlow SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow6 = new();
						public LiteralBoolean SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow6_LiteralBoolean7 = new();
						public LiteralInteger SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow6_LiteralInteger8 = new();
					public ControlFlow SingleDelegation_P_P_Signal_B_BClassifierBehavior_ControlFlow9 = new();
					public AcceptEventAction SingleDelegation_P_P_Signal_B_BClassifierBehavior_Accept_S = new();
						public OutputPin SingleDelegation_P_P_Signal_B_BClassifierBehavior_Accept_S_result = new();
							public LiteralInteger SingleDelegation_P_P_Signal_B_BClassifierBehavior_Accept_S_result_LiteralInteger10 = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_B_BClassifierBehavior_Accept_S_result_LiteralUnlimitedNatural11 = new();
							public LiteralInteger SingleDelegation_P_P_Signal_B_BClassifierBehavior_Accept_S_result_LiteralInteger12 = new();
						public Trigger SingleDelegation_P_P_Signal_B_BClassifierBehavior_Accept_S_Trigger13 = new();
					public SendSignalAction SingleDelegation_P_P_Signal_B_BClassifierBehavior_Send_Continue = new();
						public InputPin SingleDelegation_P_P_Signal_B_BClassifierBehavior_Send_Continue_target = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_B_BClassifierBehavior_Send_Continue_target_LiteralUnlimitedNatural14 = new();
							public LiteralInteger SingleDelegation_P_P_Signal_B_BClassifierBehavior_Send_Continue_target_LiteralInteger15 = new();
					public ReadStructuralFeatureAction SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_v = new();
						public OutputPin SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_v_result = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_v_result_LiteralUnlimitedNatural16 = new();
							public LiteralInteger SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_v_result_LiteralInteger17 = new();
						public InputPin SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_v_object = new();
							public LiteralInteger SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_v_object_LiteralInteger18 = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_v_object_LiteralUnlimitedNatural19 = new();
					public ObjectFlow SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow20 = new();
						public LiteralInteger SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow20_LiteralInteger21 = new();
						public LiteralBoolean SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow20_LiteralBoolean22 = new();
					public ObjectFlow SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow23 = new();
						public LiteralBoolean SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow23_LiteralBoolean24 = new();
						public LiteralInteger SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow23_LiteralInteger25 = new();
					public ObjectFlow SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow26 = new();
						public LiteralBoolean SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow26_LiteralBoolean27 = new();
						public LiteralInteger SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow26_LiteralInteger28 = new();
					public InitialNode SingleDelegation_P_P_Signal_B_BClassifierBehavior_Initial = new();
					public ObjectFlow SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow29 = new();
						public LiteralBoolean SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow29_LiteralBoolean30 = new();
						public LiteralInteger SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow29_LiteralInteger31 = new();
					public AddStructuralFeatureValueAction SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p = new();
						public InputPin SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p_object = new();
							public LiteralInteger SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p_object_LiteralInteger32 = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p_object_LiteralUnlimitedNatural33 = new();
						public OutputPin SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p_result = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p_result_LiteralUnlimitedNatural34 = new();
							public LiteralInteger SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p_result_LiteralInteger35 = new();
						public InputPin SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p_value = new();
							public LiteralInteger SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p_value_LiteralInteger36 = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p_value_LiteralUnlimitedNatural37 = new();
					public ReadStructuralFeatureAction SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_t = new();
						public InputPin SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_t_object = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_t_object_LiteralUnlimitedNatural38 = new();
							public LiteralInteger SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_t_object_LiteralInteger39 = new();
						public OutputPin SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_t_result = new();
							public LiteralInteger SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_t_result_LiteralInteger40 = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_t_result_LiteralUnlimitedNatural41 = new();
					public ForkNode SingleDelegation_P_P_Signal_B_BClassifierBehavior_Fork_S = new();
				public Property SingleDelegation_P_P_Signal_B_p = new();
				public InterfaceRealization SingleDelegation_P_P_Signal_B_IRealization = new();
				public Reception SingleDelegation_P_P_Signal_B_S = new();
			public SignalEvent SingleDelegation_P_P_Signal_SignalEventS = new();
			public Class_ SingleDelegation_P_P_Signal_A = new();
				public Property SingleDelegation_P_P_Signal_A_b = new();
				public Connector SingleDelegation_P_P_Signal_A_r = new();
					public ConnectorEnd SingleDelegation_P_P_Signal_A_r_ConnectorEnd42 = new();
					public ConnectorEnd SingleDelegation_P_P_Signal_A_r_ConnectorEnd43 = new();
				public Operation SingleDelegation_P_P_Signal_A_A_A = new();
					public Parameter SingleDelegation_P_P_Signal_A_A_A_result = new();
				public Port SingleDelegation_P_P_Signal_A_q = new();
			public Signal SingleDelegation_P_P_Signal_Start = new();
			public Class_ SingleDelegation_P_P_Signal_IImpl = new();
				public Reception SingleDelegation_P_P_Signal_IImpl_S = new();
				public InterfaceRealization SingleDelegation_P_P_Signal_IImpl_IRealization = new();
			public Class_ SingleDelegation_P_P_Signal_Tester = new();
				public Activity SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior = new();
					public ReadSelfAction SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_this = new();
						public OutputPin SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_this_result = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_this_result_LiteralInteger44 = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_this_result_LiteralUnlimitedNatural45 = new();
					public ObjectFlow SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow46 = new();
						public LiteralInteger SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow46_LiteralInteger47 = new();
						public LiteralBoolean SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow46_LiteralBoolean48 = new();
					public ObjectFlow SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow49 = new();
						public LiteralInteger SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow49_LiteralInteger50 = new();
						public LiteralBoolean SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow49_LiteralBoolean51 = new();
					public ObjectFlow SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow52 = new();
						public LiteralInteger SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow52_LiteralInteger53 = new();
						public LiteralBoolean SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow52_LiteralBoolean54 = new();
					public AcceptEventAction SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start = new();
						public OutputPin SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralUnlimitedNatural55 = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralInteger56 = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralInteger57 = new();
						public Trigger SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger58 = new();
					public ReadStructuralFeatureAction SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a = new();
						public InputPin SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object_LiteralInteger59 = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object_LiteralUnlimitedNatural60 = new();
						public OutputPin SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result_LiteralUnlimitedNatural61 = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result_LiteralInteger62 = new();
					public ValueSpecificationAction SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Int_4 = new();
						public LiteralInteger SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Int_4_LiteralInteger63 = new();
						public OutputPin SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Int_4_result = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Int_4_result_LiteralUnlimitedNatural64 = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Int_4_result_LiteralInteger65 = new();
					public AcceptEventAction SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue = new();
						public Trigger SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_Trigger66 = new();
						public OutputPin SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_result = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_result_LiteralInteger67 = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_result_LiteralUnlimitedNatural68 = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_result_LiteralInteger69 = new();
					public InitialNode SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Initial = new();
					public SendSignalAction SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S = new();
						public InputPin SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_t = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_t_LiteralInteger70 = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_t_LiteralUnlimitedNatural71 = new();
						public InputPin SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_v = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_v_LiteralInteger72 = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_v_LiteralUnlimitedNatural73 = new();
						public InputPin SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_target = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_target_LiteralInteger74 = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_target_LiteralUnlimitedNatural75 = new();
					public ObjectFlow SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow76 = new();
						public LiteralInteger SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow76_LiteralInteger77 = new();
						public LiteralBoolean SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow76_LiteralBoolean78 = new();
					public ObjectFlow SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow79 = new();
						public LiteralBoolean SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow79_LiteralBoolean80 = new();
						public LiteralInteger SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow79_LiteralInteger81 = new();
					public ObjectFlow SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow82 = new();
						public LiteralInteger SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow82_LiteralInteger83 = new();
						public LiteralBoolean SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow82_LiteralBoolean84 = new();
					public ObjectFlow SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow85 = new();
						public LiteralBoolean SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow85_LiteralBoolean86 = new();
						public LiteralInteger SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow85_LiteralInteger87 = new();
					public ControlFlow SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow88 = new();
					public ControlFlow SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow89 = new();
					public ReadStructuralFeatureAction SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q = new();
						public OutputPin SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result_LiteralInteger90 = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result_LiteralUnlimitedNatural91 = new();
						public InputPin SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object_LiteralUnlimitedNatural92 = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object_LiteralInteger93 = new();
					public ControlFlow SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow94 = new();
					public ForkNode SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Fork_this = new();
					public CallOperationAction SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Call_test_ = new();
						public InputPin SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target_LiteralUnlimitedNatural95 = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target_LiteralInteger96 = new();
				public Operation SingleDelegation_P_P_Signal_Tester_Tester_Tester = new();
					public Parameter SingleDelegation_P_P_Signal_Tester_Tester_Tester_result = new();
				public Property SingleDelegation_P_P_Signal_Tester_a = new();
				public Activity SingleDelegation_P_P_Signal_Tester_testActivity = new();
					public ControlFlow SingleDelegation_P_P_Signal_Tester_testActivity_ControlFlow97 = new();
					public ReadSelfAction SingleDelegation_P_P_Signal_Tester_testActivity_this = new();
						public OutputPin SingleDelegation_P_P_Signal_Tester_testActivity_this_result = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_testActivity_this_result_LiteralInteger98 = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_Tester_testActivity_this_result_LiteralUnlimitedNatural99 = new();
					public ReadStructuralFeatureAction SingleDelegation_P_P_Signal_Tester_testActivity_Read_this_a = new();
						public InputPin SingleDelegation_P_P_Signal_Tester_testActivity_Read_this_a_object = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_testActivity_Read_this_a_object_LiteralInteger100 = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_Tester_testActivity_Read_this_a_object_LiteralUnlimitedNatural101 = new();
						public OutputPin SingleDelegation_P_P_Signal_Tester_testActivity_Read_this_a_result = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_Tester_testActivity_Read_this_a_result_LiteralUnlimitedNatural102 = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_testActivity_Read_this_a_result_LiteralInteger103 = new();
					public ObjectFlow SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow104 = new();
						public LiteralInteger SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow104_LiteralInteger105 = new();
						public LiteralBoolean SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow104_LiteralBoolean106 = new();
					public ObjectFlow SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow107 = new();
						public LiteralInteger SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow107_LiteralInteger108 = new();
						public LiteralBoolean SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow107_LiteralBoolean109 = new();
					public ValueSpecificationAction SingleDelegation_P_P_Signal_Tester_testActivity_InitialMessage = new();
						public OutputPin SingleDelegation_P_P_Signal_Tester_testActivity_InitialMessage_result = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_testActivity_InitialMessage_result_LiteralInteger110 = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_Tester_testActivity_InitialMessage_result_LiteralUnlimitedNatural111 = new();
						public LiteralString SingleDelegation_P_P_Signal_Tester_testActivity_InitialMessage_LiteralString112 = new();
					public ValueSpecificationAction SingleDelegation_P_P_Signal_Tester_testActivity_EndMessage = new();
						public OutputPin SingleDelegation_P_P_Signal_Tester_testActivity_EndMessage_result = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_testActivity_EndMessage_result_LiteralInteger113 = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_Tester_testActivity_EndMessage_result_LiteralUnlimitedNatural114 = new();
						public LiteralString SingleDelegation_P_P_Signal_Tester_testActivity_EndMessage_LiteralString115 = new();
					public CallBehaviorAction SingleDelegation_P_P_Signal_Tester_testActivity_Call_testP = new();
						public InputPin SingleDelegation_P_P_Signal_Tester_testActivity_Call_testP_p = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_testActivity_Call_testP_p_LiteralInteger116 = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_testActivity_Call_testP_p_LiteralInteger117 = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_Tester_testActivity_Call_testP_p_LiteralUnlimitedNatural118 = new();
					public ControlFlow SingleDelegation_P_P_Signal_Tester_testActivity_ControlFlow119 = new();
					public ObjectFlow SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow120 = new();
						public LiteralBoolean SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow120_LiteralBoolean121 = new();
						public LiteralInteger SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow120_LiteralInteger122 = new();
					public ReadStructuralFeatureAction SingleDelegation_P_P_Signal_Tester_testActivity_Read_a_b = new();
						public InputPin SingleDelegation_P_P_Signal_Tester_testActivity_Read_a_b_object = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_Tester_testActivity_Read_a_b_object_LiteralUnlimitedNatural123 = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_testActivity_Read_a_b_object_LiteralInteger124 = new();
						public OutputPin SingleDelegation_P_P_Signal_Tester_testActivity_Read_a_b_result = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_testActivity_Read_a_b_result_LiteralInteger125 = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_Tester_testActivity_Read_a_b_result_LiteralUnlimitedNatural126 = new();
					public ObjectFlow SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow127 = new();
						public LiteralInteger SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow127_LiteralInteger128 = new();
						public LiteralBoolean SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow127_LiteralBoolean129 = new();
					public ObjectFlow SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow130 = new();
						public LiteralInteger SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow130_LiteralInteger131 = new();
						public LiteralBoolean SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow130_LiteralBoolean132 = new();
					public CallBehaviorAction SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage = new();
						public InputPin SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage_value = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage_value_LiteralUnlimitedNatural133 = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage_value_LiteralInteger134 = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage_value_LiteralInteger135 = new();
						public OutputPin SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage_errorStatus = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage_errorStatus_LiteralInteger136 = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage_errorStatus_LiteralInteger137 = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage_errorStatus_LiteralUnlimitedNatural138 = new();
					public ObjectFlow SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow139 = new();
						public LiteralBoolean SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow139_LiteralBoolean140 = new();
						public LiteralInteger SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow139_LiteralInteger141 = new();
					public OpaqueBehavior SingleDelegation_P_P_Signal_Tester_testActivity_testP = new();
						public Parameter SingleDelegation_P_P_Signal_Tester_testActivity_testP_p = new();
					public ReadStructuralFeatureAction SingleDelegation_P_P_Signal_Tester_testActivity_Read_b_p = new();
						public InputPin SingleDelegation_P_P_Signal_Tester_testActivity_Read_b_p_object = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_Tester_testActivity_Read_b_p_object_LiteralUnlimitedNatural142 = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_testActivity_Read_b_p_object_LiteralInteger143 = new();
						public OutputPin SingleDelegation_P_P_Signal_Tester_testActivity_Read_b_p_result = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_Tester_testActivity_Read_b_p_result_LiteralUnlimitedNatural144 = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_testActivity_Read_b_p_result_LiteralInteger145 = new();
					public CallBehaviorAction SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage = new();
						public InputPin SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage_value = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage_value_LiteralInteger146 = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage_value_LiteralInteger147 = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage_value_LiteralUnlimitedNatural148 = new();
						public OutputPin SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage_errorStatus = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage_errorStatus_LiteralInteger149 = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage_errorStatus_LiteralUnlimitedNatural150 = new();
							public LiteralInteger SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage_errorStatus_LiteralInteger151 = new();
				public Generalization SingleDelegation_P_P_Signal_Tester_Generalization152 = new();
				public Operation SingleDelegation_P_P_Signal_Tester_test = new();
			public Class_ SingleDelegation_P_P_Signal_AbstractTester = new();
				public Reception SingleDelegation_P_P_Signal_AbstractTester_Start = new();
				public Operation SingleDelegation_P_P_Signal_AbstractTester_test = new();
				public Reception SingleDelegation_P_P_Signal_AbstractTester_Continue = new();
			public Activity SingleDelegation_P_P_Signal_main = new();
				public CallOperationAction SingleDelegation_P_P_Signal_main_Tester_ = new();
					public InputPin SingleDelegation_P_P_Signal_main_Tester__target = new();
						public LiteralInteger SingleDelegation_P_P_Signal_main_Tester__target_LiteralInteger153 = new();
						public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_main_Tester__target_LiteralUnlimitedNatural154 = new();
					public OutputPin SingleDelegation_P_P_Signal_main_Tester__result = new();
						public LiteralInteger SingleDelegation_P_P_Signal_main_Tester__result_LiteralInteger155 = new();
						public LiteralInteger SingleDelegation_P_P_Signal_main_Tester__result_LiteralInteger156 = new();
						public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_main_Tester__result_LiteralUnlimitedNatural157 = new();
				public ObjectFlow SingleDelegation_P_P_Signal_main_ObjectFlow158 = new();
					public LiteralBoolean SingleDelegation_P_P_Signal_main_ObjectFlow158_LiteralBoolean159 = new();
					public LiteralInteger SingleDelegation_P_P_Signal_main_ObjectFlow158_LiteralInteger160 = new();
				public CreateObjectAction SingleDelegation_P_P_Signal_main_Create_Tester = new();
					public OutputPin SingleDelegation_P_P_Signal_main_Create_Tester_result = new();
						public LiteralInteger SingleDelegation_P_P_Signal_main_Create_Tester_result_LiteralInteger161 = new();
						public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_main_Create_Tester_result_LiteralUnlimitedNatural162 = new();
				public ObjectFlow SingleDelegation_P_P_Signal_main_ObjectFlow163 = new();
					public LiteralBoolean SingleDelegation_P_P_Signal_main_ObjectFlow163_LiteralBoolean164 = new();
					public LiteralInteger SingleDelegation_P_P_Signal_main_ObjectFlow163_LiteralInteger165 = new();
				public ControlFlow SingleDelegation_P_P_Signal_main_ControlFlow166 = new();
				public ObjectFlow SingleDelegation_P_P_Signal_main_ObjectFlow167 = new();
					public LiteralInteger SingleDelegation_P_P_Signal_main_ObjectFlow167_LiteralInteger168 = new();
					public LiteralBoolean SingleDelegation_P_P_Signal_main_ObjectFlow167_LiteralBoolean169 = new();
				public StartObjectBehaviorAction SingleDelegation_P_P_Signal_main_Start_Tester = new();
					public InputPin SingleDelegation_P_P_Signal_main_Start_Tester_object = new();
						public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_main_Start_Tester_object_LiteralUnlimitedNatural170 = new();
						public LiteralInteger SingleDelegation_P_P_Signal_main_Start_Tester_object_LiteralInteger171 = new();
				public SendSignalAction SingleDelegation_P_P_Signal_main_Send_Start = new();
					public InputPin SingleDelegation_P_P_Signal_main_Send_Start_target = new();
						public LiteralUnlimitedNatural SingleDelegation_P_P_Signal_main_Send_Start_target_LiteralUnlimitedNatural172 = new();
						public LiteralInteger SingleDelegation_P_P_Signal_main_Send_Start_target_LiteralInteger173 = new();
				public ForkNode SingleDelegation_P_P_Signal_main_Fork_Tester = new();
				public ObjectFlow SingleDelegation_P_P_Signal_main_ObjectFlow174 = new();
					public LiteralBoolean SingleDelegation_P_P_Signal_main_ObjectFlow174_LiteralBoolean175 = new();
					public LiteralInteger SingleDelegation_P_P_Signal_main_ObjectFlow174_LiteralInteger176 = new();
			public Interface SingleDelegation_P_P_Signal_I = new();
				public Reception SingleDelegation_P_P_Signal_I_S = new();
			public SignalEvent SingleDelegation_P_P_Signal_SignalEventStart = new();

		public static SingleDelegation_P_P_SignalModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public SingleDelegation_P_P_SignalModel()
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
			 * Model SingleDelegation_P_P_Signal
			 */
			AddToElementRepository("SingleDelegation_P_P_Signal", SingleDelegation_P_P_Signal);
				AddToElementRepository("S", SingleDelegation_P_P_Signal_S);
					AddToElementRepository("v", SingleDelegation_P_P_Signal_S_v);
					AddToElementRepository("t", SingleDelegation_P_P_Signal_S_t);
				AddToElementRepository("SignalEventContinue", SingleDelegation_P_P_Signal_SignalEventContinue);
				AddToElementRepository("R", SingleDelegation_P_P_Signal_R);
					AddToElementRepository("y", SingleDelegation_P_P_Signal_R_y);
					AddToElementRepository("x", SingleDelegation_P_P_Signal_R_x);
				AddToElementRepository("Continue", SingleDelegation_P_P_Signal_Continue);
				AddToElementRepository("B", SingleDelegation_P_P_Signal_B);
					AddToElementRepository("B_B", SingleDelegation_P_P_Signal_B_B_B);
						AddToElementRepository("result", SingleDelegation_P_P_Signal_B_B_B_result);
					AddToElementRepository("BClassifierBehavior", SingleDelegation_P_P_Signal_B_BClassifierBehavior);
						AddToElementRepository("ObjectFlow0", SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow0);
							AddToElementRepository("LiteralBoolean1", SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow0_LiteralBoolean1);
							AddToElementRepository("LiteralInteger2", SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow0_LiteralInteger2);
						AddToElementRepository("ControlFlow3", SingleDelegation_P_P_Signal_B_BClassifierBehavior_ControlFlow3);
						AddToElementRepository("this", SingleDelegation_P_P_Signal_B_BClassifierBehavior_this);
							AddToElementRepository("result", SingleDelegation_P_P_Signal_B_BClassifierBehavior_this_result);
								AddToElementRepository("LiteralInteger4", SingleDelegation_P_P_Signal_B_BClassifierBehavior_this_result_LiteralInteger4);
								AddToElementRepository("LiteralUnlimitedNatural5", SingleDelegation_P_P_Signal_B_BClassifierBehavior_this_result_LiteralUnlimitedNatural5);
						AddToElementRepository("ObjectFlow6", SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow6);
							AddToElementRepository("LiteralBoolean7", SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow6_LiteralBoolean7);
							AddToElementRepository("LiteralInteger8", SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow6_LiteralInteger8);
						AddToElementRepository("ControlFlow9", SingleDelegation_P_P_Signal_B_BClassifierBehavior_ControlFlow9);
						AddToElementRepository("Accept S", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Accept_S);
							AddToElementRepository("result", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Accept_S_result);
								AddToElementRepository("LiteralInteger10", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Accept_S_result_LiteralInteger10);
								AddToElementRepository("LiteralUnlimitedNatural11", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Accept_S_result_LiteralUnlimitedNatural11);
								AddToElementRepository("LiteralInteger12", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Accept_S_result_LiteralInteger12);
							AddToElementRepository("Trigger13", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Accept_S_Trigger13);
						AddToElementRepository("Send Continue", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Send_Continue);
							AddToElementRepository("target", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Send_Continue_target);
								AddToElementRepository("LiteralUnlimitedNatural14", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Send_Continue_target_LiteralUnlimitedNatural14);
								AddToElementRepository("LiteralInteger15", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Send_Continue_target_LiteralInteger15);
						AddToElementRepository("Read s.v", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_v);
							AddToElementRepository("result", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_v_result);
								AddToElementRepository("LiteralUnlimitedNatural16", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_v_result_LiteralUnlimitedNatural16);
								AddToElementRepository("LiteralInteger17", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_v_result_LiteralInteger17);
							AddToElementRepository("object", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_v_object);
								AddToElementRepository("LiteralInteger18", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_v_object_LiteralInteger18);
								AddToElementRepository("LiteralUnlimitedNatural19", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_v_object_LiteralUnlimitedNatural19);
						AddToElementRepository("ObjectFlow20", SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow20);
							AddToElementRepository("LiteralInteger21", SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow20_LiteralInteger21);
							AddToElementRepository("LiteralBoolean22", SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow20_LiteralBoolean22);
						AddToElementRepository("ObjectFlow23", SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow23);
							AddToElementRepository("LiteralBoolean24", SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow23_LiteralBoolean24);
							AddToElementRepository("LiteralInteger25", SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow23_LiteralInteger25);
						AddToElementRepository("ObjectFlow26", SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow26);
							AddToElementRepository("LiteralBoolean27", SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow26_LiteralBoolean27);
							AddToElementRepository("LiteralInteger28", SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow26_LiteralInteger28);
						AddToElementRepository("Initial", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Initial);
						AddToElementRepository("ObjectFlow29", SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow29);
							AddToElementRepository("LiteralBoolean30", SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow29_LiteralBoolean30);
							AddToElementRepository("LiteralInteger31", SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow29_LiteralInteger31);
						AddToElementRepository("Set this.p", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p);
							AddToElementRepository("object", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p_object);
								AddToElementRepository("LiteralInteger32", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p_object_LiteralInteger32);
								AddToElementRepository("LiteralUnlimitedNatural33", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p_object_LiteralUnlimitedNatural33);
							AddToElementRepository("result", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p_result);
								AddToElementRepository("LiteralUnlimitedNatural34", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p_result_LiteralUnlimitedNatural34);
								AddToElementRepository("LiteralInteger35", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p_result_LiteralInteger35);
							AddToElementRepository("value", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p_value);
								AddToElementRepository("LiteralInteger36", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p_value_LiteralInteger36);
								AddToElementRepository("LiteralUnlimitedNatural37", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p_value_LiteralUnlimitedNatural37);
						AddToElementRepository("Read s.t", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_t);
							AddToElementRepository("object", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_t_object);
								AddToElementRepository("LiteralUnlimitedNatural38", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_t_object_LiteralUnlimitedNatural38);
								AddToElementRepository("LiteralInteger39", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_t_object_LiteralInteger39);
							AddToElementRepository("result", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_t_result);
								AddToElementRepository("LiteralInteger40", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_t_result_LiteralInteger40);
								AddToElementRepository("LiteralUnlimitedNatural41", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_t_result_LiteralUnlimitedNatural41);
						AddToElementRepository("Fork S", SingleDelegation_P_P_Signal_B_BClassifierBehavior_Fork_S);
					AddToElementRepository("p", SingleDelegation_P_P_Signal_B_p);
					AddToElementRepository("IRealization", SingleDelegation_P_P_Signal_B_IRealization);
					AddToElementRepository("S", SingleDelegation_P_P_Signal_B_S);
				AddToElementRepository("SignalEventS", SingleDelegation_P_P_Signal_SignalEventS);
				AddToElementRepository("A", SingleDelegation_P_P_Signal_A);
					AddToElementRepository("b", SingleDelegation_P_P_Signal_A_b);
					AddToElementRepository("r", SingleDelegation_P_P_Signal_A_r);
						AddToElementRepository("ConnectorEnd42", SingleDelegation_P_P_Signal_A_r_ConnectorEnd42);
						AddToElementRepository("ConnectorEnd43", SingleDelegation_P_P_Signal_A_r_ConnectorEnd43);
					AddToElementRepository("A_A", SingleDelegation_P_P_Signal_A_A_A);
						AddToElementRepository("result", SingleDelegation_P_P_Signal_A_A_A_result);
					AddToElementRepository("q", SingleDelegation_P_P_Signal_A_q);
				AddToElementRepository("Start", SingleDelegation_P_P_Signal_Start);
				AddToElementRepository("IImpl", SingleDelegation_P_P_Signal_IImpl);
					AddToElementRepository("S", SingleDelegation_P_P_Signal_IImpl_S);
					AddToElementRepository("IRealization", SingleDelegation_P_P_Signal_IImpl_IRealization);
				AddToElementRepository("Tester", SingleDelegation_P_P_Signal_Tester);
					AddToElementRepository("TesterClassifierBehavior", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior);
						AddToElementRepository("this", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_this);
							AddToElementRepository("result", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_this_result);
								AddToElementRepository("LiteralInteger44", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_this_result_LiteralInteger44);
								AddToElementRepository("LiteralUnlimitedNatural45", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_this_result_LiteralUnlimitedNatural45);
						AddToElementRepository("ObjectFlow46", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow46);
							AddToElementRepository("LiteralInteger47", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow46_LiteralInteger47);
							AddToElementRepository("LiteralBoolean48", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow46_LiteralBoolean48);
						AddToElementRepository("ObjectFlow49", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow49);
							AddToElementRepository("LiteralInteger50", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow49_LiteralInteger50);
							AddToElementRepository("LiteralBoolean51", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow49_LiteralBoolean51);
						AddToElementRepository("ObjectFlow52", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow52);
							AddToElementRepository("LiteralInteger53", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow52_LiteralInteger53);
							AddToElementRepository("LiteralBoolean54", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow52_LiteralBoolean54);
						AddToElementRepository("Accept Start", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start);
							AddToElementRepository("result", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result);
								AddToElementRepository("LiteralUnlimitedNatural55", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralUnlimitedNatural55);
								AddToElementRepository("LiteralInteger56", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralInteger56);
								AddToElementRepository("LiteralInteger57", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result_LiteralInteger57);
							AddToElementRepository("Trigger58", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger58);
						AddToElementRepository("Read this.a", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a);
							AddToElementRepository("object", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object);
								AddToElementRepository("LiteralInteger59", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object_LiteralInteger59);
								AddToElementRepository("LiteralUnlimitedNatural60", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object_LiteralUnlimitedNatural60);
							AddToElementRepository("result", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result);
								AddToElementRepository("LiteralUnlimitedNatural61", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result_LiteralUnlimitedNatural61);
								AddToElementRepository("LiteralInteger62", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result_LiteralInteger62);
						AddToElementRepository("Int(4)", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Int_4);
							AddToElementRepository("LiteralInteger63", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Int_4_LiteralInteger63);
							AddToElementRepository("result", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Int_4_result);
								AddToElementRepository("LiteralUnlimitedNatural64", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Int_4_result_LiteralUnlimitedNatural64);
								AddToElementRepository("LiteralInteger65", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Int_4_result_LiteralInteger65);
						AddToElementRepository("Accept Continue", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue);
							AddToElementRepository("Trigger66", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_Trigger66);
							AddToElementRepository("result", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_result);
								AddToElementRepository("LiteralInteger67", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_result_LiteralInteger67);
								AddToElementRepository("LiteralUnlimitedNatural68", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_result_LiteralUnlimitedNatural68);
								AddToElementRepository("LiteralInteger69", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_result_LiteralInteger69);
						AddToElementRepository("Initial", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Initial);
						AddToElementRepository(" Send S", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S);
							AddToElementRepository("t", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_t);
								AddToElementRepository("LiteralInteger70", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_t_LiteralInteger70);
								AddToElementRepository("LiteralUnlimitedNatural71", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_t_LiteralUnlimitedNatural71);
							AddToElementRepository("v", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_v);
								AddToElementRepository("LiteralInteger72", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_v_LiteralInteger72);
								AddToElementRepository("LiteralUnlimitedNatural73", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_v_LiteralUnlimitedNatural73);
							AddToElementRepository("target", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_target);
								AddToElementRepository("LiteralInteger74", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_target_LiteralInteger74);
								AddToElementRepository("LiteralUnlimitedNatural75", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_target_LiteralUnlimitedNatural75);
						AddToElementRepository("ObjectFlow76", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow76);
							AddToElementRepository("LiteralInteger77", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow76_LiteralInteger77);
							AddToElementRepository("LiteralBoolean78", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow76_LiteralBoolean78);
						AddToElementRepository("ObjectFlow79", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow79);
							AddToElementRepository("LiteralBoolean80", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow79_LiteralBoolean80);
							AddToElementRepository("LiteralInteger81", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow79_LiteralInteger81);
						AddToElementRepository("ObjectFlow82", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow82);
							AddToElementRepository("LiteralInteger83", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow82_LiteralInteger83);
							AddToElementRepository("LiteralBoolean84", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow82_LiteralBoolean84);
						AddToElementRepository("ObjectFlow85", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow85);
							AddToElementRepository("LiteralBoolean86", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow85_LiteralBoolean86);
							AddToElementRepository("LiteralInteger87", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow85_LiteralInteger87);
						AddToElementRepository("ControlFlow88", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow88);
						AddToElementRepository("ControlFlow89", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow89);
						AddToElementRepository("Read a.q", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q);
							AddToElementRepository("result", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result);
								AddToElementRepository("LiteralInteger90", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result_LiteralInteger90);
								AddToElementRepository("LiteralUnlimitedNatural91", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result_LiteralUnlimitedNatural91);
							AddToElementRepository("object", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object);
								AddToElementRepository("LiteralUnlimitedNatural92", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object_LiteralUnlimitedNatural92);
								AddToElementRepository("LiteralInteger93", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object_LiteralInteger93);
						AddToElementRepository("ControlFlow94", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow94);
						AddToElementRepository("Fork this", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Fork_this);
						AddToElementRepository("Call test()", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Call_test_);
							AddToElementRepository("target", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target);
								AddToElementRepository("LiteralUnlimitedNatural95", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target_LiteralUnlimitedNatural95);
								AddToElementRepository("LiteralInteger96", SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target_LiteralInteger96);
					AddToElementRepository("Tester_Tester", SingleDelegation_P_P_Signal_Tester_Tester_Tester);
						AddToElementRepository("result", SingleDelegation_P_P_Signal_Tester_Tester_Tester_result);
					AddToElementRepository("a", SingleDelegation_P_P_Signal_Tester_a);
					AddToElementRepository("testActivity", SingleDelegation_P_P_Signal_Tester_testActivity);
						AddToElementRepository("ControlFlow97", SingleDelegation_P_P_Signal_Tester_testActivity_ControlFlow97);
						AddToElementRepository("this", SingleDelegation_P_P_Signal_Tester_testActivity_this);
							AddToElementRepository("result", SingleDelegation_P_P_Signal_Tester_testActivity_this_result);
								AddToElementRepository("LiteralInteger98", SingleDelegation_P_P_Signal_Tester_testActivity_this_result_LiteralInteger98);
								AddToElementRepository("LiteralUnlimitedNatural99", SingleDelegation_P_P_Signal_Tester_testActivity_this_result_LiteralUnlimitedNatural99);
						AddToElementRepository("Read this.a", SingleDelegation_P_P_Signal_Tester_testActivity_Read_this_a);
							AddToElementRepository("object", SingleDelegation_P_P_Signal_Tester_testActivity_Read_this_a_object);
								AddToElementRepository("LiteralInteger100", SingleDelegation_P_P_Signal_Tester_testActivity_Read_this_a_object_LiteralInteger100);
								AddToElementRepository("LiteralUnlimitedNatural101", SingleDelegation_P_P_Signal_Tester_testActivity_Read_this_a_object_LiteralUnlimitedNatural101);
							AddToElementRepository("result", SingleDelegation_P_P_Signal_Tester_testActivity_Read_this_a_result);
								AddToElementRepository("LiteralUnlimitedNatural102", SingleDelegation_P_P_Signal_Tester_testActivity_Read_this_a_result_LiteralUnlimitedNatural102);
								AddToElementRepository("LiteralInteger103", SingleDelegation_P_P_Signal_Tester_testActivity_Read_this_a_result_LiteralInteger103);
						AddToElementRepository("ObjectFlow104", SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow104);
							AddToElementRepository("LiteralInteger105", SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow104_LiteralInteger105);
							AddToElementRepository("LiteralBoolean106", SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow104_LiteralBoolean106);
						AddToElementRepository("ObjectFlow107", SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow107);
							AddToElementRepository("LiteralInteger108", SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow107_LiteralInteger108);
							AddToElementRepository("LiteralBoolean109", SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow107_LiteralBoolean109);
						AddToElementRepository("InitialMessage", SingleDelegation_P_P_Signal_Tester_testActivity_InitialMessage);
							AddToElementRepository("result", SingleDelegation_P_P_Signal_Tester_testActivity_InitialMessage_result);
								AddToElementRepository("LiteralInteger110", SingleDelegation_P_P_Signal_Tester_testActivity_InitialMessage_result_LiteralInteger110);
								AddToElementRepository("LiteralUnlimitedNatural111", SingleDelegation_P_P_Signal_Tester_testActivity_InitialMessage_result_LiteralUnlimitedNatural111);
							AddToElementRepository("LiteralString112", SingleDelegation_P_P_Signal_Tester_testActivity_InitialMessage_LiteralString112);
						AddToElementRepository("EndMessage", SingleDelegation_P_P_Signal_Tester_testActivity_EndMessage);
							AddToElementRepository("result", SingleDelegation_P_P_Signal_Tester_testActivity_EndMessage_result);
								AddToElementRepository("LiteralInteger113", SingleDelegation_P_P_Signal_Tester_testActivity_EndMessage_result_LiteralInteger113);
								AddToElementRepository("LiteralUnlimitedNatural114", SingleDelegation_P_P_Signal_Tester_testActivity_EndMessage_result_LiteralUnlimitedNatural114);
							AddToElementRepository("LiteralString115", SingleDelegation_P_P_Signal_Tester_testActivity_EndMessage_LiteralString115);
						AddToElementRepository("Call testP", SingleDelegation_P_P_Signal_Tester_testActivity_Call_testP);
							AddToElementRepository("p", SingleDelegation_P_P_Signal_Tester_testActivity_Call_testP_p);
								AddToElementRepository("LiteralInteger116", SingleDelegation_P_P_Signal_Tester_testActivity_Call_testP_p_LiteralInteger116);
								AddToElementRepository("LiteralInteger117", SingleDelegation_P_P_Signal_Tester_testActivity_Call_testP_p_LiteralInteger117);
								AddToElementRepository("LiteralUnlimitedNatural118", SingleDelegation_P_P_Signal_Tester_testActivity_Call_testP_p_LiteralUnlimitedNatural118);
						AddToElementRepository("ControlFlow119", SingleDelegation_P_P_Signal_Tester_testActivity_ControlFlow119);
						AddToElementRepository("ObjectFlow120", SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow120);
							AddToElementRepository("LiteralBoolean121", SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow120_LiteralBoolean121);
							AddToElementRepository("LiteralInteger122", SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow120_LiteralInteger122);
						AddToElementRepository("Read a.b", SingleDelegation_P_P_Signal_Tester_testActivity_Read_a_b);
							AddToElementRepository("object", SingleDelegation_P_P_Signal_Tester_testActivity_Read_a_b_object);
								AddToElementRepository("LiteralUnlimitedNatural123", SingleDelegation_P_P_Signal_Tester_testActivity_Read_a_b_object_LiteralUnlimitedNatural123);
								AddToElementRepository("LiteralInteger124", SingleDelegation_P_P_Signal_Tester_testActivity_Read_a_b_object_LiteralInteger124);
							AddToElementRepository("result", SingleDelegation_P_P_Signal_Tester_testActivity_Read_a_b_result);
								AddToElementRepository("LiteralInteger125", SingleDelegation_P_P_Signal_Tester_testActivity_Read_a_b_result_LiteralInteger125);
								AddToElementRepository("LiteralUnlimitedNatural126", SingleDelegation_P_P_Signal_Tester_testActivity_Read_a_b_result_LiteralUnlimitedNatural126);
						AddToElementRepository("ObjectFlow127", SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow127);
							AddToElementRepository("LiteralInteger128", SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow127_LiteralInteger128);
							AddToElementRepository("LiteralBoolean129", SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow127_LiteralBoolean129);
						AddToElementRepository("ObjectFlow130", SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow130);
							AddToElementRepository("LiteralInteger131", SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow130_LiteralInteger131);
							AddToElementRepository("LiteralBoolean132", SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow130_LiteralBoolean132);
						AddToElementRepository("WriteLine(EndMessage)", SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage);
							AddToElementRepository("value", SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage_value);
								AddToElementRepository("LiteralUnlimitedNatural133", SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage_value_LiteralUnlimitedNatural133);
								AddToElementRepository("LiteralInteger134", SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage_value_LiteralInteger134);
								AddToElementRepository("LiteralInteger135", SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage_value_LiteralInteger135);
							AddToElementRepository("errorStatus", SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage_errorStatus);
								AddToElementRepository("LiteralInteger136", SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage_errorStatus_LiteralInteger136);
								AddToElementRepository("LiteralInteger137", SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage_errorStatus_LiteralInteger137);
								AddToElementRepository("LiteralUnlimitedNatural138", SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage_errorStatus_LiteralUnlimitedNatural138);
						AddToElementRepository("ObjectFlow139", SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow139);
							AddToElementRepository("LiteralBoolean140", SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow139_LiteralBoolean140);
							AddToElementRepository("LiteralInteger141", SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow139_LiteralInteger141);
						AddToElementRepository("testP", SingleDelegation_P_P_Signal_Tester_testActivity_testP);
							AddToElementRepository("p", SingleDelegation_P_P_Signal_Tester_testActivity_testP_p);
						AddToElementRepository("Read b.p", SingleDelegation_P_P_Signal_Tester_testActivity_Read_b_p);
							AddToElementRepository("object", SingleDelegation_P_P_Signal_Tester_testActivity_Read_b_p_object);
								AddToElementRepository("LiteralUnlimitedNatural142", SingleDelegation_P_P_Signal_Tester_testActivity_Read_b_p_object_LiteralUnlimitedNatural142);
								AddToElementRepository("LiteralInteger143", SingleDelegation_P_P_Signal_Tester_testActivity_Read_b_p_object_LiteralInteger143);
							AddToElementRepository("result", SingleDelegation_P_P_Signal_Tester_testActivity_Read_b_p_result);
								AddToElementRepository("LiteralUnlimitedNatural144", SingleDelegation_P_P_Signal_Tester_testActivity_Read_b_p_result_LiteralUnlimitedNatural144);
								AddToElementRepository("LiteralInteger145", SingleDelegation_P_P_Signal_Tester_testActivity_Read_b_p_result_LiteralInteger145);
						AddToElementRepository("WriteLine(InitialMessage)", SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage);
							AddToElementRepository("value", SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage_value);
								AddToElementRepository("LiteralInteger146", SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage_value_LiteralInteger146);
								AddToElementRepository("LiteralInteger147", SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage_value_LiteralInteger147);
								AddToElementRepository("LiteralUnlimitedNatural148", SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage_value_LiteralUnlimitedNatural148);
							AddToElementRepository("errorStatus", SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage_errorStatus);
								AddToElementRepository("LiteralInteger149", SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage_errorStatus_LiteralInteger149);
								AddToElementRepository("LiteralUnlimitedNatural150", SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage_errorStatus_LiteralUnlimitedNatural150);
								AddToElementRepository("LiteralInteger151", SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage_errorStatus_LiteralInteger151);
					AddToElementRepository("Generalization152", SingleDelegation_P_P_Signal_Tester_Generalization152);
					AddToElementRepository("test", SingleDelegation_P_P_Signal_Tester_test);
				AddToElementRepository("AbstractTester", SingleDelegation_P_P_Signal_AbstractTester);
					AddToElementRepository("Start", SingleDelegation_P_P_Signal_AbstractTester_Start);
					AddToElementRepository("test", SingleDelegation_P_P_Signal_AbstractTester_test);
					AddToElementRepository("Continue", SingleDelegation_P_P_Signal_AbstractTester_Continue);
				AddToElementRepository("main", SingleDelegation_P_P_Signal_main);
					AddToElementRepository("Tester()", SingleDelegation_P_P_Signal_main_Tester_);
						AddToElementRepository("target", SingleDelegation_P_P_Signal_main_Tester__target);
							AddToElementRepository("LiteralInteger153", SingleDelegation_P_P_Signal_main_Tester__target_LiteralInteger153);
							AddToElementRepository("LiteralUnlimitedNatural154", SingleDelegation_P_P_Signal_main_Tester__target_LiteralUnlimitedNatural154);
						AddToElementRepository("result", SingleDelegation_P_P_Signal_main_Tester__result);
							AddToElementRepository("LiteralInteger155", SingleDelegation_P_P_Signal_main_Tester__result_LiteralInteger155);
							AddToElementRepository("LiteralInteger156", SingleDelegation_P_P_Signal_main_Tester__result_LiteralInteger156);
							AddToElementRepository("LiteralUnlimitedNatural157", SingleDelegation_P_P_Signal_main_Tester__result_LiteralUnlimitedNatural157);
					AddToElementRepository("ObjectFlow158", SingleDelegation_P_P_Signal_main_ObjectFlow158);
						AddToElementRepository("LiteralBoolean159", SingleDelegation_P_P_Signal_main_ObjectFlow158_LiteralBoolean159);
						AddToElementRepository("LiteralInteger160", SingleDelegation_P_P_Signal_main_ObjectFlow158_LiteralInteger160);
					AddToElementRepository("Create Tester", SingleDelegation_P_P_Signal_main_Create_Tester);
						AddToElementRepository("result", SingleDelegation_P_P_Signal_main_Create_Tester_result);
							AddToElementRepository("LiteralInteger161", SingleDelegation_P_P_Signal_main_Create_Tester_result_LiteralInteger161);
							AddToElementRepository("LiteralUnlimitedNatural162", SingleDelegation_P_P_Signal_main_Create_Tester_result_LiteralUnlimitedNatural162);
					AddToElementRepository("ObjectFlow163", SingleDelegation_P_P_Signal_main_ObjectFlow163);
						AddToElementRepository("LiteralBoolean164", SingleDelegation_P_P_Signal_main_ObjectFlow163_LiteralBoolean164);
						AddToElementRepository("LiteralInteger165", SingleDelegation_P_P_Signal_main_ObjectFlow163_LiteralInteger165);
					AddToElementRepository("ControlFlow166", SingleDelegation_P_P_Signal_main_ControlFlow166);
					AddToElementRepository("ObjectFlow167", SingleDelegation_P_P_Signal_main_ObjectFlow167);
						AddToElementRepository("LiteralInteger168", SingleDelegation_P_P_Signal_main_ObjectFlow167_LiteralInteger168);
						AddToElementRepository("LiteralBoolean169", SingleDelegation_P_P_Signal_main_ObjectFlow167_LiteralBoolean169);
					AddToElementRepository("Start Tester", SingleDelegation_P_P_Signal_main_Start_Tester);
						AddToElementRepository("object", SingleDelegation_P_P_Signal_main_Start_Tester_object);
							AddToElementRepository("LiteralUnlimitedNatural170", SingleDelegation_P_P_Signal_main_Start_Tester_object_LiteralUnlimitedNatural170);
							AddToElementRepository("LiteralInteger171", SingleDelegation_P_P_Signal_main_Start_Tester_object_LiteralInteger171);
					AddToElementRepository("Send Start", SingleDelegation_P_P_Signal_main_Send_Start);
						AddToElementRepository("target", SingleDelegation_P_P_Signal_main_Send_Start_target);
							AddToElementRepository("LiteralUnlimitedNatural172", SingleDelegation_P_P_Signal_main_Send_Start_target_LiteralUnlimitedNatural172);
							AddToElementRepository("LiteralInteger173", SingleDelegation_P_P_Signal_main_Send_Start_target_LiteralInteger173);
					AddToElementRepository("Fork Tester", SingleDelegation_P_P_Signal_main_Fork_Tester);
					AddToElementRepository("ObjectFlow174", SingleDelegation_P_P_Signal_main_ObjectFlow174);
						AddToElementRepository("LiteralBoolean175", SingleDelegation_P_P_Signal_main_ObjectFlow174_LiteralBoolean175);
						AddToElementRepository("LiteralInteger176", SingleDelegation_P_P_Signal_main_ObjectFlow174_LiteralInteger176);
				AddToElementRepository("I", SingleDelegation_P_P_Signal_I);
					AddToElementRepository("S", SingleDelegation_P_P_Signal_I_S);
				AddToElementRepository("SignalEventStart", SingleDelegation_P_P_Signal_SignalEventStart);

			// Initialize public members
			/*
			 * Model SingleDelegation_P_P_Signal
			 */
			SingleDelegation_P_P_Signal.SetName("SingleDelegation_P_P_Signal");
			SingleDelegation_P_P_Signal.SetVisibility(VisibilityKind.public_);
				// Signal S
				SingleDelegation_P_P_Signal_S.SetName("S");
				SingleDelegation_P_P_Signal_S.SetVisibility(VisibilityKind.public_);
				
					// Property v
					SingleDelegation_P_P_Signal_S_v.SetName("v");
					SingleDelegation_P_P_Signal_S_v.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_P_Signal_S_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
				SingleDelegation_P_P_Signal_S.AddOwnedAttribute(SingleDelegation_P_P_Signal_S_v);
					// Property t
					SingleDelegation_P_P_Signal_S_t.SetName("t");
					SingleDelegation_P_P_Signal_S_t.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_P_Signal_S_t.SetType(SingleDelegation_P_P_Signal_AbstractTester);
				SingleDelegation_P_P_Signal_S.AddOwnedAttribute(SingleDelegation_P_P_Signal_S_t);
			SingleDelegation_P_P_Signal.AddPackagedElement(SingleDelegation_P_P_Signal_S);
				// SignalEvent SignalEventContinue
				SingleDelegation_P_P_Signal_SignalEventContinue.SetName("SignalEventContinue");
				SingleDelegation_P_P_Signal_SignalEventContinue.SetVisibility(VisibilityKind.public_);
				SingleDelegation_P_P_Signal_SignalEventContinue.SetSignal(SingleDelegation_P_P_Signal_Continue);
			SingleDelegation_P_P_Signal.AddPackagedElement(SingleDelegation_P_P_Signal_SignalEventContinue);
				// Association R
				SingleDelegation_P_P_Signal_R.SetName("R");
				SingleDelegation_P_P_Signal_R.SetVisibility(VisibilityKind.public_);
				SingleDelegation_P_P_Signal_R.AddOwnedEnd(SingleDelegation_P_P_Signal_R_x);
				SingleDelegation_P_P_Signal_R.AddOwnedEnd(SingleDelegation_P_P_Signal_R_y);
			SingleDelegation_P_P_Signal.AddPackagedElement(SingleDelegation_P_P_Signal_R);
				// Signal Continue
				SingleDelegation_P_P_Signal_Continue.SetName("Continue");
				SingleDelegation_P_P_Signal_Continue.SetVisibility(VisibilityKind.public_);
			SingleDelegation_P_P_Signal.AddPackagedElement(SingleDelegation_P_P_Signal_Continue);
				// Class B
				SingleDelegation_P_P_Signal_B.SetName("B");
				SingleDelegation_P_P_Signal_B.SetVisibility(VisibilityKind.public_);
				
					// Property p
					SingleDelegation_P_P_Signal_B_p.SetName("p");
					SingleDelegation_P_P_Signal_B_p.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_P_Signal_B_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
				SingleDelegation_P_P_Signal_B.AddOwnedAttribute(SingleDelegation_P_P_Signal_B_p);
				SingleDelegation_P_P_Signal_B.SetClassifierBehavior(SingleDelegation_P_P_Signal_B_BClassifierBehavior);
					// Activity BClassifierBehavior
					SingleDelegation_P_P_Signal_B_BClassifierBehavior.SetName("BClassifierBehavior");
					SingleDelegation_P_P_Signal_B_BClassifierBehavior.SetVisibility(VisibilityKind.public_);
						// InitialNode Initial
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_Initial.SetName("Initial");
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_Initial.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_P_Signal_B_BClassifierBehavior.AddNode(SingleDelegation_P_P_Signal_B_BClassifierBehavior_Initial);
						// ReadSelfAction this
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_this.SetName("this");
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_this_result.SetName("result");
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_this_result.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_this_result.SetType(SingleDelegation_P_P_Signal_B);
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_this.SetResult(SingleDelegation_P_P_Signal_B_BClassifierBehavior_this_result);
					SingleDelegation_P_P_Signal_B_BClassifierBehavior.AddNode(SingleDelegation_P_P_Signal_B_BClassifierBehavior_this);
						// AddStructuralFeatureValueAction Set this.p
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p.SetName("Set this.p");
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p.SetStructuralFeature(SingleDelegation_P_P_Signal_B_p);
							// InputPin object
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p_object.SetName("object");
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p_object.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p_object.SetType(SingleDelegation_P_P_Signal_B);
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p.SetObject(SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p_object);
							// InputPin value
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p_value.SetName("value");
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p_value.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p.SetValue(SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p_value);
							// OutputPin result
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p_result.SetName("result");
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p_result.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p_result.SetType(SingleDelegation_P_P_Signal_B);
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p.SetResult(SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p_result);
					SingleDelegation_P_P_Signal_B_BClassifierBehavior.AddNode(SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p);
						// ReadStructuralFeatureAction Read s.t
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_t.SetName("Read s.t");
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_t.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_t.SetStructuralFeature(SingleDelegation_P_P_Signal_S_t);
							// InputPin object
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_t_object.SetName("object");
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_t_object.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_t_object.SetType(SingleDelegation_P_P_Signal_S);
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_t.SetObject(SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_t_object);
							// OutputPin result
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_t_result.SetName("result");
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_t_result.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_t_result.SetType(SingleDelegation_P_P_Signal_AbstractTester);
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_t.SetResult(SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_t_result);
					SingleDelegation_P_P_Signal_B_BClassifierBehavior.AddNode(SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_t);
						// AcceptEventAction Accept S
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_Accept_S.SetName("Accept S");
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_Accept_S.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_Accept_S_result.SetName("result");
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_Accept_S_result.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_Accept_S_result.SetType(SingleDelegation_P_P_Signal_S);
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_Accept_S.AddResult(SingleDelegation_P_P_Signal_B_BClassifierBehavior_Accept_S_result);
							// Trigger Trigger13
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_Accept_S_Trigger13.SetName("Trigger13");
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_Accept_S_Trigger13.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_Accept_S_Trigger13.SetEvent(SingleDelegation_P_P_Signal_SignalEventS);
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_Accept_S.AddTrigger(SingleDelegation_P_P_Signal_B_BClassifierBehavior_Accept_S_Trigger13);
					SingleDelegation_P_P_Signal_B_BClassifierBehavior.AddNode(SingleDelegation_P_P_Signal_B_BClassifierBehavior_Accept_S);
						// ForkNode Fork S
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_Fork_S.SetName("Fork S");
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_Fork_S.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_P_Signal_B_BClassifierBehavior.AddNode(SingleDelegation_P_P_Signal_B_BClassifierBehavior_Fork_S);
						// SendSignalAction Send Continue
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_Send_Continue.SetName("Send Continue");
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_Send_Continue.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_Send_Continue.SetSignal(SingleDelegation_P_P_Signal_Continue);
							// InputPin target
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_Send_Continue_target.SetName("target");
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_Send_Continue_target.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_Send_Continue_target.SetType(SingleDelegation_P_P_Signal_AbstractTester);
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_Send_Continue.SetTarget(SingleDelegation_P_P_Signal_B_BClassifierBehavior_Send_Continue_target);
					SingleDelegation_P_P_Signal_B_BClassifierBehavior.AddNode(SingleDelegation_P_P_Signal_B_BClassifierBehavior_Send_Continue);
						// ReadStructuralFeatureAction Read s.v
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_v.SetName("Read s.v");
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_v.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_v.SetStructuralFeature(SingleDelegation_P_P_Signal_S_v);
							// InputPin object
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_v_object.SetName("object");
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_v_object.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_v_object.SetType(SingleDelegation_P_P_Signal_S);
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_v.SetObject(SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_v_object);
							// OutputPin result
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_v_result.SetName("result");
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_v_result.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_v_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_v.SetResult(SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_v_result);
					SingleDelegation_P_P_Signal_B_BClassifierBehavior.AddNode(SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_v);
						// ObjectFlow ObjectFlow20 from Fork S to object
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow20.SetName("ObjectFlow20");
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow20.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow20.SetSource(SingleDelegation_P_P_Signal_B_BClassifierBehavior_Fork_S);
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow20.SetTarget(SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_v_object);
							// LiteralBoolean LiteralBoolean22
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow20_LiteralBoolean22.SetName("LiteralBoolean22");
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow20_LiteralBoolean22.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow20_LiteralBoolean22.SetValue(true);
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow20.SetGuard(SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow20_LiteralBoolean22);
					SingleDelegation_P_P_Signal_B_BClassifierBehavior.AddEdge(SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow20);
						// ObjectFlow ObjectFlow23 from result to object
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow23.SetName("ObjectFlow23");
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow23.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow23.SetSource(SingleDelegation_P_P_Signal_B_BClassifierBehavior_this_result);
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow23.SetTarget(SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p_object);
							// LiteralBoolean LiteralBoolean24
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow23_LiteralBoolean24.SetName("LiteralBoolean24");
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow23_LiteralBoolean24.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow23_LiteralBoolean24.SetValue(true);
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow23.SetGuard(SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow23_LiteralBoolean24);
					SingleDelegation_P_P_Signal_B_BClassifierBehavior.AddEdge(SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow23);
						// ObjectFlow ObjectFlow26 from result to target
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow26.SetName("ObjectFlow26");
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow26.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow26.SetSource(SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_t_result);
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow26.SetTarget(SingleDelegation_P_P_Signal_B_BClassifierBehavior_Send_Continue_target);
							// LiteralBoolean LiteralBoolean27
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow26_LiteralBoolean27.SetName("LiteralBoolean27");
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow26_LiteralBoolean27.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow26_LiteralBoolean27.SetValue(true);
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow26.SetGuard(SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow26_LiteralBoolean27);
					SingleDelegation_P_P_Signal_B_BClassifierBehavior.AddEdge(SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow26);
						// ObjectFlow ObjectFlow0 from Fork S to object
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow0.SetName("ObjectFlow0");
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow0.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow0.SetSource(SingleDelegation_P_P_Signal_B_BClassifierBehavior_Fork_S);
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow0.SetTarget(SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_t_object);
							// LiteralBoolean LiteralBoolean1
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow0_LiteralBoolean1.SetName("LiteralBoolean1");
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow0_LiteralBoolean1.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow0_LiteralBoolean1.SetValue(true);
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow0.SetGuard(SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow0_LiteralBoolean1);
					SingleDelegation_P_P_Signal_B_BClassifierBehavior.AddEdge(SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow0);
						// ControlFlow ControlFlow3 from Set this.p to Send Continue
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ControlFlow3.SetName("ControlFlow3");
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ControlFlow3.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ControlFlow3.SetSource(SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p);
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ControlFlow3.SetTarget(SingleDelegation_P_P_Signal_B_BClassifierBehavior_Send_Continue);
					SingleDelegation_P_P_Signal_B_BClassifierBehavior.AddEdge(SingleDelegation_P_P_Signal_B_BClassifierBehavior_ControlFlow3);
						// ObjectFlow ObjectFlow29 from result to Fork S
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow29.SetName("ObjectFlow29");
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow29.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow29.SetSource(SingleDelegation_P_P_Signal_B_BClassifierBehavior_Accept_S_result);
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow29.SetTarget(SingleDelegation_P_P_Signal_B_BClassifierBehavior_Fork_S);
							// LiteralBoolean LiteralBoolean30
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow29_LiteralBoolean30.SetName("LiteralBoolean30");
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow29_LiteralBoolean30.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow29_LiteralBoolean30.SetValue(true);
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow29.SetGuard(SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow29_LiteralBoolean30);
					SingleDelegation_P_P_Signal_B_BClassifierBehavior.AddEdge(SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow29);
						// ObjectFlow ObjectFlow6 from result to value
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow6.SetName("ObjectFlow6");
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow6.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow6.SetSource(SingleDelegation_P_P_Signal_B_BClassifierBehavior_Read_s_v_result);
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow6.SetTarget(SingleDelegation_P_P_Signal_B_BClassifierBehavior_Set_this_p_value);
							// LiteralBoolean LiteralBoolean7
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow6_LiteralBoolean7.SetName("LiteralBoolean7");
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow6_LiteralBoolean7.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow6_LiteralBoolean7.SetValue(true);
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow6.SetGuard(SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow6_LiteralBoolean7);
					SingleDelegation_P_P_Signal_B_BClassifierBehavior.AddEdge(SingleDelegation_P_P_Signal_B_BClassifierBehavior_ObjectFlow6);
						// ControlFlow ControlFlow9 from Initial to Accept S
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ControlFlow9.SetName("ControlFlow9");
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ControlFlow9.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ControlFlow9.SetSource(SingleDelegation_P_P_Signal_B_BClassifierBehavior_Initial);
						SingleDelegation_P_P_Signal_B_BClassifierBehavior_ControlFlow9.SetTarget(SingleDelegation_P_P_Signal_B_BClassifierBehavior_Accept_S);
					SingleDelegation_P_P_Signal_B_BClassifierBehavior.AddEdge(SingleDelegation_P_P_Signal_B_BClassifierBehavior_ControlFlow9);
				SingleDelegation_P_P_Signal_B.AddOwnedBehavior(SingleDelegation_P_P_Signal_B_BClassifierBehavior);
					SingleDelegation_P_P_Signal_B_IRealization.SetName("IRealization");
					SingleDelegation_P_P_Signal_B_IRealization.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_P_Signal_B_IRealization.SetContract(SingleDelegation_P_P_Signal_I);
					
				SingleDelegation_P_P_Signal_B.AddInterfaceRealization(SingleDelegation_P_P_Signal_B_IRealization);
				
				SingleDelegation_P_P_Signal_B.SetIsActive(true);
					// Operation B_B
					SingleDelegation_P_P_Signal_B_B_B.SetName("B_B");
					SingleDelegation_P_P_Signal_B_B_B.SetVisibility(VisibilityKind.public_);
						// Parameter result
						SingleDelegation_P_P_Signal_B_B_B_result.SetName("result");
						SingleDelegation_P_P_Signal_B_B_B_result.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Signal_B_B_B_result.SetType(SingleDelegation_P_P_Signal_B);
						SingleDelegation_P_P_Signal_B_B_B_result.SetDirection(ParameterDirectionKind.return_);
					SingleDelegation_P_P_Signal_B_B_B.AddOwnedParameter(SingleDelegation_P_P_Signal_B_B_B_result);
					SingleDelegation_P_P_Signal_B_B_B.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				SingleDelegation_P_P_Signal_B.AddOwnedOperation(SingleDelegation_P_P_Signal_B_B_B);
					// Reception S
					SingleDelegation_P_P_Signal_B_S.SetName("S");
					SingleDelegation_P_P_Signal_B_S.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_P_Signal_B_S.SetSignal(SingleDelegation_P_P_Signal_S);
				SingleDelegation_P_P_Signal_B.AddOwnedReception(SingleDelegation_P_P_Signal_B_S);
			SingleDelegation_P_P_Signal.AddPackagedElement(SingleDelegation_P_P_Signal_B);
				// SignalEvent SignalEventS
				SingleDelegation_P_P_Signal_SignalEventS.SetName("SignalEventS");
				SingleDelegation_P_P_Signal_SignalEventS.SetVisibility(VisibilityKind.public_);
				SingleDelegation_P_P_Signal_SignalEventS.SetSignal(SingleDelegation_P_P_Signal_S);
			SingleDelegation_P_P_Signal.AddPackagedElement(SingleDelegation_P_P_Signal_SignalEventS);
				// Class A
				SingleDelegation_P_P_Signal_A.SetName("A");
				SingleDelegation_P_P_Signal_A.SetVisibility(VisibilityKind.public_);
				
					// Port q
					SingleDelegation_P_P_Signal_A_q.SetName("q");
					SingleDelegation_P_P_Signal_A_q.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_P_Signal_A_q.SetType(SingleDelegation_P_P_Signal_IImpl);
					SingleDelegation_P_P_Signal_A_q.SetAggregation(AggregationKind.composite);
					SingleDelegation_P_P_Signal_A_q.isService = true;
					SingleDelegation_P_P_Signal_A_q.AddProvided(SingleDelegation_P_P_Signal_I);
				SingleDelegation_P_P_Signal_A.AddOwnedAttribute(SingleDelegation_P_P_Signal_A_q);
					// Property b
					SingleDelegation_P_P_Signal_A_b.SetName("b");
					SingleDelegation_P_P_Signal_A_b.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_P_Signal_A_b.SetType(SingleDelegation_P_P_Signal_B);
					SingleDelegation_P_P_Signal_A_b.SetAggregation(AggregationKind.composite);
				SingleDelegation_P_P_Signal_A.AddOwnedAttribute(SingleDelegation_P_P_Signal_A_b);
				
				SingleDelegation_P_P_Signal_A_r.SetName("r");
					SingleDelegation_P_P_Signal_A_r.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Signal_A_r_ConnectorEnd43.SetRole(SingleDelegation_P_P_Signal_A_q);
						
					SingleDelegation_P_P_Signal_A_r.AddEnd(SingleDelegation_P_P_Signal_A_r_ConnectorEnd43);
						
						SingleDelegation_P_P_Signal_A_r_ConnectorEnd42.SetRole(SingleDelegation_P_P_Signal_A_b);
						
					SingleDelegation_P_P_Signal_A_r.AddEnd(SingleDelegation_P_P_Signal_A_r_ConnectorEnd42);
					SingleDelegation_P_P_Signal_A_r.SetType(SingleDelegation_P_P_Signal_R);
				SingleDelegation_P_P_Signal_A.AddOwnedConnector(SingleDelegation_P_P_Signal_A_r);
					// Operation A_A
					SingleDelegation_P_P_Signal_A_A_A.SetName("A_A");
					SingleDelegation_P_P_Signal_A_A_A.SetVisibility(VisibilityKind.public_);
						// Parameter result
						SingleDelegation_P_P_Signal_A_A_A_result.SetName("result");
						SingleDelegation_P_P_Signal_A_A_A_result.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Signal_A_A_A_result.SetType(SingleDelegation_P_P_Signal_A);
						SingleDelegation_P_P_Signal_A_A_A_result.SetDirection(ParameterDirectionKind.return_);
					SingleDelegation_P_P_Signal_A_A_A.AddOwnedParameter(SingleDelegation_P_P_Signal_A_A_A_result);
					SingleDelegation_P_P_Signal_A_A_A.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				SingleDelegation_P_P_Signal_A.AddOwnedOperation(SingleDelegation_P_P_Signal_A_A_A);
			SingleDelegation_P_P_Signal.AddPackagedElement(SingleDelegation_P_P_Signal_A);
				// Signal Start
				SingleDelegation_P_P_Signal_Start.SetName("Start");
				SingleDelegation_P_P_Signal_Start.SetVisibility(VisibilityKind.public_);
			SingleDelegation_P_P_Signal.AddPackagedElement(SingleDelegation_P_P_Signal_Start);
				// Class IImpl
				SingleDelegation_P_P_Signal_IImpl.SetName("IImpl");
				SingleDelegation_P_P_Signal_IImpl.SetVisibility(VisibilityKind.public_);
				SingleDelegation_P_P_Signal_IImpl_IRealization.SetName("IRealization");
					SingleDelegation_P_P_Signal_IImpl_IRealization.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_P_Signal_IImpl_IRealization.SetContract(SingleDelegation_P_P_Signal_I);
					
				SingleDelegation_P_P_Signal_IImpl.AddInterfaceRealization(SingleDelegation_P_P_Signal_IImpl_IRealization);
				
					// Reception S
					SingleDelegation_P_P_Signal_IImpl_S.SetName("S");
					SingleDelegation_P_P_Signal_IImpl_S.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_P_Signal_IImpl_S.SetSignal(SingleDelegation_P_P_Signal_S);
				SingleDelegation_P_P_Signal_IImpl.AddOwnedReception(SingleDelegation_P_P_Signal_IImpl_S);
			SingleDelegation_P_P_Signal.AddPackagedElement(SingleDelegation_P_P_Signal_IImpl);
				// Class Tester
				SingleDelegation_P_P_Signal_Tester.SetName("Tester");
				SingleDelegation_P_P_Signal_Tester.SetVisibility(VisibilityKind.public_);
				
					// Generalization to AbstractTester
					SingleDelegation_P_P_Signal_Tester_Generalization152.SetGeneral(SingleDelegation_P_P_Signal_AbstractTester);
				SingleDelegation_P_P_Signal_Tester.AddGeneralization(SingleDelegation_P_P_Signal_Tester_Generalization152);
					// Property a
					SingleDelegation_P_P_Signal_Tester_a.SetName("a");
					SingleDelegation_P_P_Signal_Tester_a.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_P_Signal_Tester_a.SetType(SingleDelegation_P_P_Signal_A);
					SingleDelegation_P_P_Signal_Tester_a.SetAggregation(AggregationKind.composite);
				SingleDelegation_P_P_Signal_Tester.AddOwnedAttribute(SingleDelegation_P_P_Signal_Tester_a);
				SingleDelegation_P_P_Signal_Tester.SetClassifierBehavior(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior);
					// Activity TesterClassifierBehavior
					SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior.SetName("TesterClassifierBehavior");
					SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior.SetVisibility(VisibilityKind.public_);
						// ReadSelfAction this
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_this.SetName("this");
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_this_result.SetName("result");
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_this_result.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_this_result.SetType(SingleDelegation_P_P_Signal_Tester);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_this.SetResult(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_this_result);
					SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_this);
						// ValueSpecificationAction Int(4)
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Int_4.SetName("Int(4)");
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Int_4.SetVisibility(VisibilityKind.public_);
							// LiteralInteger LiteralInteger63
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Int_4_LiteralInteger63.SetName("LiteralInteger63");
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Int_4_LiteralInteger63.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Int_4_LiteralInteger63.SetValue(4);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Int_4.SetValue(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Int_4_LiteralInteger63);
							// OutputPin result
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Int_4_result.SetName("result");
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Int_4_result.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Int_4_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Int_4.SetResult(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Int_4_result);
					SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Int_4);
						// AcceptEventAction Accept Continue
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue.SetName("Accept Continue");
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue.SetVisibility(VisibilityKind.package_);
							// OutputPin result
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_result.SetName("result");
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_result.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_result.SetType(SingleDelegation_P_P_Signal_Continue);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue.AddResult(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_result);
							// Trigger Trigger66
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_Trigger66.SetName("Trigger66");
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_Trigger66.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_Trigger66.SetEvent(SingleDelegation_P_P_Signal_SignalEventContinue);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue.AddTrigger(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue_Trigger66);
					SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue);
						// InitialNode Initial
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Initial.SetName("Initial");
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Initial.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Initial);
						// SendSignalAction  Send S
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S.SetName(" Send S");
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S.SetSignal(SingleDelegation_P_P_Signal_S);
							// InputPin target
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_target.SetName("target");
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_target.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_target.SetType(SingleDelegation_P_P_Signal_IImpl);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S.SetTarget(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_target);
							// InputPin v
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_v.SetName("v");
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_v.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S.AddArgument(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_v);
							// InputPin t
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_t.SetName("t");
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_t.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_t.SetType(SingleDelegation_P_P_Signal_AbstractTester);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S.AddArgument(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_t);
					SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S);
						// AcceptEventAction Accept Start
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start.SetName("Accept Start");
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result.SetName("result");
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result.SetType(SingleDelegation_P_P_Signal_Start);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start.AddResult(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_result);
							// Trigger Trigger58
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger58.SetName("Trigger58");
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger58.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger58.SetEvent(SingleDelegation_P_P_Signal_SignalEventStart);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start.AddTrigger(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start_Trigger58);
					SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start);
						// ReadStructuralFeatureAction Read a.q
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q.SetName("Read a.q");
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q.SetStructuralFeature(SingleDelegation_P_P_Signal_A_q);
							// InputPin object
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object.SetName("object");
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object.SetType(SingleDelegation_P_P_Signal_A);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q.SetObject(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object);
							// OutputPin result
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result.SetName("result");
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result.SetType(SingleDelegation_P_P_Signal_IImpl);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q.SetResult(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result);
					SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q);
						// ForkNode Fork this
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Fork_this.SetName("Fork this");
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Fork_this.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Fork_this);
						// ReadStructuralFeatureAction Read this.a
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a.SetName("Read this.a");
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a.SetStructuralFeature(SingleDelegation_P_P_Signal_Tester_a);
							// InputPin object
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object.SetName("object");
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object.SetType(SingleDelegation_P_P_Signal_Tester);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a.SetObject(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object);
							// OutputPin result
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result.SetName("result");
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result.SetType(SingleDelegation_P_P_Signal_A);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a.SetResult(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result);
					SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a);
						// CallOperationAction Call test()
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Call_test_.SetName("Call test()");
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Call_test_.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Call_test_.SetOperation(SingleDelegation_P_P_Signal_Tester_test);
							// InputPin target
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target.SetName("target");
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target.SetType(SingleDelegation_P_P_Signal_Tester);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Call_test_.SetTarget(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target);
					SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior.AddNode(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Call_test_);
						// ObjectFlow ObjectFlow46 from Fork this to t
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow46.SetName("ObjectFlow46");
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow46.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow46.SetSource(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Fork_this);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow46.SetTarget(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_t);
							// LiteralBoolean LiteralBoolean48
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow46_LiteralBoolean48.SetName("LiteralBoolean48");
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow46_LiteralBoolean48.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow46_LiteralBoolean48.SetValue(true);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow46.SetGuard(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow46_LiteralBoolean48);
					SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow46);
						// ObjectFlow ObjectFlow76 from result to Fork this
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow76.SetName("ObjectFlow76");
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow76.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow76.SetSource(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_this_result);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow76.SetTarget(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Fork_this);
							// LiteralBoolean LiteralBoolean78
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow76_LiteralBoolean78.SetName("LiteralBoolean78");
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow76_LiteralBoolean78.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow76_LiteralBoolean78.SetValue(true);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow76.SetGuard(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow76_LiteralBoolean78);
					SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow76);
						// ObjectFlow ObjectFlow79 from Fork this to object
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow79.SetName("ObjectFlow79");
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow79.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow79.SetSource(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Fork_this);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow79.SetTarget(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_object);
							// LiteralBoolean LiteralBoolean80
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow79_LiteralBoolean80.SetName("LiteralBoolean80");
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow79_LiteralBoolean80.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow79_LiteralBoolean80.SetValue(true);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow79.SetGuard(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow79_LiteralBoolean80);
					SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow79);
						// ObjectFlow ObjectFlow49 from result to v
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow49.SetName("ObjectFlow49");
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow49.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow49.SetSource(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Int_4_result);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow49.SetTarget(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_v);
							// LiteralBoolean LiteralBoolean51
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow49_LiteralBoolean51.SetName("LiteralBoolean51");
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow49_LiteralBoolean51.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow49_LiteralBoolean51.SetValue(true);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow49.SetGuard(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow49_LiteralBoolean51);
					SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow49);
						// ObjectFlow ObjectFlow52 from Fork this to target
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow52.SetName("ObjectFlow52");
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow52.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow52.SetSource(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Fork_this);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow52.SetTarget(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Call_test__target);
							// LiteralBoolean LiteralBoolean54
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow52_LiteralBoolean54.SetName("LiteralBoolean54");
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow52_LiteralBoolean54.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow52_LiteralBoolean54.SetValue(true);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow52.SetGuard(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow52_LiteralBoolean54);
					SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow52);
						// ObjectFlow ObjectFlow82 from result to object
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow82.SetName("ObjectFlow82");
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow82.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow82.SetSource(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_this_a_result);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow82.SetTarget(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_object);
							// LiteralBoolean LiteralBoolean84
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow82_LiteralBoolean84.SetName("LiteralBoolean84");
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow82_LiteralBoolean84.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow82_LiteralBoolean84.SetValue(true);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow82.SetGuard(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow82_LiteralBoolean84);
					SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow82);
						// ObjectFlow ObjectFlow85 from result to target
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow85.SetName("ObjectFlow85");
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow85.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow85.SetSource(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Read_a_q_result);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow85.SetTarget(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior__Send_S_target);
							// LiteralBoolean LiteralBoolean86
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow85_LiteralBoolean86.SetName("LiteralBoolean86");
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow85_LiteralBoolean86.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow85_LiteralBoolean86.SetValue(true);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow85.SetGuard(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow85_LiteralBoolean86);
					SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ObjectFlow85);
						// ControlFlow ControlFlow88 from Accept Start to this
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow88.SetName("ControlFlow88");
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow88.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow88.SetSource(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow88.SetTarget(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_this);
					SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow88);
						// ControlFlow ControlFlow89 from Initial to Accept Start
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow89.SetName("ControlFlow89");
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow89.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow89.SetSource(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Initial);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow89.SetTarget(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Start);
					SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow89);
						// ControlFlow ControlFlow94 from Accept Continue to Call test()
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow94.SetName("ControlFlow94");
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow94.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow94.SetSource(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Accept_Continue);
						SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow94.SetTarget(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_Call_test_);
					SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior.AddEdge(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior_ControlFlow94);
				SingleDelegation_P_P_Signal_Tester.AddOwnedBehavior(SingleDelegation_P_P_Signal_Tester_TesterClassifierBehavior);
					// Activity testActivity
					SingleDelegation_P_P_Signal_Tester_testActivity.SetName("testActivity");
					SingleDelegation_P_P_Signal_Tester_testActivity.SetVisibility(VisibilityKind.public_);
					// FunctionBehavior testP
						SingleDelegation_P_P_Signal_Tester_testActivity_testP.SetName("testP");
						SingleDelegation_P_P_Signal_Tester_testActivity_testP.SetVisibility(VisibilityKind.public_);
						
							// Parameter p
							SingleDelegation_P_P_Signal_Tester_testActivity_testP_p.SetName("p");
							SingleDelegation_P_P_Signal_Tester_testActivity_testP_p.SetVisibility(VisibilityKind.public_);
							
							SingleDelegation_P_P_Signal_Tester_testActivity_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						SingleDelegation_P_P_Signal_Tester_testActivity_testP.AddOwnedParameter(SingleDelegation_P_P_Signal_Tester_testActivity_testP_p);
						SingleDelegation_P_P_Signal_Tester_testActivity_testP.AddLanguage("C#");
						SingleDelegation_P_P_Signal_Tester_testActivity_testP.AddLanguage("Using");
						SingleDelegation_P_P_Signal_Tester_testActivity_testP.AddBody("Console.WriteLine(\"Asserting a.b.p == 4\");  	// Test parameter p 	int p = ((IntegerValue)inputParameters.ElementAt(0).values.ElementAt(0)).value; 	Debug.Println(\"[doBody] argument p = \" + p); 	 	Console.WriteLine(\"a.b.p == \" + p); 	Console.Write(\"Signal delegated to classifier behavior: \");  	if(p == 4) 	{ 		Console.ForegroundColor = ConsoleColor.Green; 		Console.WriteLine(\"Assertion successful.\"); 	} 	else 	{ 		Console.ForegroundColor = ConsoleColor.Red; 		Console.WriteLine(\"Assertion failed!\"); 	}  	Console.ResetColor();");
						SingleDelegation_P_P_Signal_Tester_testActivity_testP.AddBody("using fuml.semantics.simpleclassifiers; ");
					SingleDelegation_P_P_Signal_Tester_testActivity.AddOwnedBehavior(SingleDelegation_P_P_Signal_Tester_testActivity_testP);
						// ReadSelfAction this
						SingleDelegation_P_P_Signal_Tester_testActivity_this.SetName("this");
						SingleDelegation_P_P_Signal_Tester_testActivity_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							SingleDelegation_P_P_Signal_Tester_testActivity_this_result.SetName("result");
							SingleDelegation_P_P_Signal_Tester_testActivity_this_result.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_testActivity_this_result.SetType(SingleDelegation_P_P_Signal_Tester);
						SingleDelegation_P_P_Signal_Tester_testActivity_this.SetResult(SingleDelegation_P_P_Signal_Tester_testActivity_this_result);
					SingleDelegation_P_P_Signal_Tester_testActivity.AddNode(SingleDelegation_P_P_Signal_Tester_testActivity_this);
						// ReadStructuralFeatureAction Read a.b
						SingleDelegation_P_P_Signal_Tester_testActivity_Read_a_b.SetName("Read a.b");
						SingleDelegation_P_P_Signal_Tester_testActivity_Read_a_b.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Signal_Tester_testActivity_Read_a_b.SetStructuralFeature(SingleDelegation_P_P_Signal_A_b);
							// InputPin object
							SingleDelegation_P_P_Signal_Tester_testActivity_Read_a_b_object.SetName("object");
							SingleDelegation_P_P_Signal_Tester_testActivity_Read_a_b_object.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_testActivity_Read_a_b_object.SetType(SingleDelegation_P_P_Signal_A);
						SingleDelegation_P_P_Signal_Tester_testActivity_Read_a_b.SetObject(SingleDelegation_P_P_Signal_Tester_testActivity_Read_a_b_object);
							// OutputPin result
							SingleDelegation_P_P_Signal_Tester_testActivity_Read_a_b_result.SetName("result");
							SingleDelegation_P_P_Signal_Tester_testActivity_Read_a_b_result.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_testActivity_Read_a_b_result.SetType(SingleDelegation_P_P_Signal_B);
						SingleDelegation_P_P_Signal_Tester_testActivity_Read_a_b.SetResult(SingleDelegation_P_P_Signal_Tester_testActivity_Read_a_b_result);
					SingleDelegation_P_P_Signal_Tester_testActivity.AddNode(SingleDelegation_P_P_Signal_Tester_testActivity_Read_a_b);
						// ReadStructuralFeatureAction Read this.a
						SingleDelegation_P_P_Signal_Tester_testActivity_Read_this_a.SetName("Read this.a");
						SingleDelegation_P_P_Signal_Tester_testActivity_Read_this_a.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Signal_Tester_testActivity_Read_this_a.SetStructuralFeature(SingleDelegation_P_P_Signal_Tester_a);
							// InputPin object
							SingleDelegation_P_P_Signal_Tester_testActivity_Read_this_a_object.SetName("object");
							SingleDelegation_P_P_Signal_Tester_testActivity_Read_this_a_object.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_testActivity_Read_this_a_object.SetType(SingleDelegation_P_P_Signal_Tester);
						SingleDelegation_P_P_Signal_Tester_testActivity_Read_this_a.SetObject(SingleDelegation_P_P_Signal_Tester_testActivity_Read_this_a_object);
							// OutputPin result
							SingleDelegation_P_P_Signal_Tester_testActivity_Read_this_a_result.SetName("result");
							SingleDelegation_P_P_Signal_Tester_testActivity_Read_this_a_result.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_testActivity_Read_this_a_result.SetType(SingleDelegation_P_P_Signal_A);
						SingleDelegation_P_P_Signal_Tester_testActivity_Read_this_a.SetResult(SingleDelegation_P_P_Signal_Tester_testActivity_Read_this_a_result);
					SingleDelegation_P_P_Signal_Tester_testActivity.AddNode(SingleDelegation_P_P_Signal_Tester_testActivity_Read_this_a);
						// CallBehaviorAction WriteLine(EndMessage)
						SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage.SetName("WriteLine(EndMessage)");
						SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage.SetVisibility(VisibilityKind.public_);
						
							// OutputPin errorStatus
							SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage_errorStatus.SetName("errorStatus");
							SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage_errorStatus.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage_errorStatus.SetType(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_Common_Status);
							SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage_errorStatus.SetLower(0);
						SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage.AddResult(SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage_errorStatus);
						SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
							// InputPin value
							SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage_value.SetName("value");
							SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage_value.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage.AddArgument(SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage_value);
					SingleDelegation_P_P_Signal_Tester_testActivity.AddNode(SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage);
						// ValueSpecificationAction InitialMessage
						SingleDelegation_P_P_Signal_Tester_testActivity_InitialMessage.SetName("InitialMessage");
						SingleDelegation_P_P_Signal_Tester_testActivity_InitialMessage.SetVisibility(VisibilityKind.public_);
							// LiteralString LiteralString112
							SingleDelegation_P_P_Signal_Tester_testActivity_InitialMessage_LiteralString112.SetName("LiteralString112");
							SingleDelegation_P_P_Signal_Tester_testActivity_InitialMessage_LiteralString112.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_testActivity_InitialMessage_LiteralString112.SetValue("-- Running test case: Single delegation connector - Signal delegated from port to part --");
						SingleDelegation_P_P_Signal_Tester_testActivity_InitialMessage.SetValue(SingleDelegation_P_P_Signal_Tester_testActivity_InitialMessage_LiteralString112);
							// OutputPin result
							SingleDelegation_P_P_Signal_Tester_testActivity_InitialMessage_result.SetName("result");
							SingleDelegation_P_P_Signal_Tester_testActivity_InitialMessage_result.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_testActivity_InitialMessage_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						SingleDelegation_P_P_Signal_Tester_testActivity_InitialMessage.SetResult(SingleDelegation_P_P_Signal_Tester_testActivity_InitialMessage_result);
					SingleDelegation_P_P_Signal_Tester_testActivity.AddNode(SingleDelegation_P_P_Signal_Tester_testActivity_InitialMessage);
						// ValueSpecificationAction EndMessage
						SingleDelegation_P_P_Signal_Tester_testActivity_EndMessage.SetName("EndMessage");
						SingleDelegation_P_P_Signal_Tester_testActivity_EndMessage.SetVisibility(VisibilityKind.public_);
							// LiteralString LiteralString115
							SingleDelegation_P_P_Signal_Tester_testActivity_EndMessage_LiteralString115.SetName("LiteralString115");
							SingleDelegation_P_P_Signal_Tester_testActivity_EndMessage_LiteralString115.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_testActivity_EndMessage_LiteralString115.SetValue("-- End of test case --");
						SingleDelegation_P_P_Signal_Tester_testActivity_EndMessage.SetValue(SingleDelegation_P_P_Signal_Tester_testActivity_EndMessage_LiteralString115);
							// OutputPin result
							SingleDelegation_P_P_Signal_Tester_testActivity_EndMessage_result.SetName("result");
							SingleDelegation_P_P_Signal_Tester_testActivity_EndMessage_result.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_testActivity_EndMessage_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						SingleDelegation_P_P_Signal_Tester_testActivity_EndMessage.SetResult(SingleDelegation_P_P_Signal_Tester_testActivity_EndMessage_result);
					SingleDelegation_P_P_Signal_Tester_testActivity.AddNode(SingleDelegation_P_P_Signal_Tester_testActivity_EndMessage);
						// ReadStructuralFeatureAction Read b.p
						SingleDelegation_P_P_Signal_Tester_testActivity_Read_b_p.SetName("Read b.p");
						SingleDelegation_P_P_Signal_Tester_testActivity_Read_b_p.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Signal_Tester_testActivity_Read_b_p.SetStructuralFeature(SingleDelegation_P_P_Signal_B_p);
							// InputPin object
							SingleDelegation_P_P_Signal_Tester_testActivity_Read_b_p_object.SetName("object");
							SingleDelegation_P_P_Signal_Tester_testActivity_Read_b_p_object.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_testActivity_Read_b_p_object.SetType(SingleDelegation_P_P_Signal_B);
						SingleDelegation_P_P_Signal_Tester_testActivity_Read_b_p.SetObject(SingleDelegation_P_P_Signal_Tester_testActivity_Read_b_p_object);
							// OutputPin result
							SingleDelegation_P_P_Signal_Tester_testActivity_Read_b_p_result.SetName("result");
							SingleDelegation_P_P_Signal_Tester_testActivity_Read_b_p_result.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_testActivity_Read_b_p_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						SingleDelegation_P_P_Signal_Tester_testActivity_Read_b_p.SetResult(SingleDelegation_P_P_Signal_Tester_testActivity_Read_b_p_result);
					SingleDelegation_P_P_Signal_Tester_testActivity.AddNode(SingleDelegation_P_P_Signal_Tester_testActivity_Read_b_p);
						// CallBehaviorAction Call testP
						SingleDelegation_P_P_Signal_Tester_testActivity_Call_testP.SetName("Call testP");
						SingleDelegation_P_P_Signal_Tester_testActivity_Call_testP.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Signal_Tester_testActivity_Call_testP.SetBehavior(SingleDelegation_P_P_Signal_Tester_testActivity_testP);
							// InputPin p
							SingleDelegation_P_P_Signal_Tester_testActivity_Call_testP_p.SetName("p");
							SingleDelegation_P_P_Signal_Tester_testActivity_Call_testP_p.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_testActivity_Call_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						SingleDelegation_P_P_Signal_Tester_testActivity_Call_testP.AddArgument(SingleDelegation_P_P_Signal_Tester_testActivity_Call_testP_p);
					SingleDelegation_P_P_Signal_Tester_testActivity.AddNode(SingleDelegation_P_P_Signal_Tester_testActivity_Call_testP);
						// CallBehaviorAction WriteLine(InitialMessage)
						SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage.SetName("WriteLine(InitialMessage)");
						SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage.SetVisibility(VisibilityKind.public_);
						
							// OutputPin errorStatus
							SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage_errorStatus.SetName("errorStatus");
							SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage_errorStatus.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage_errorStatus.SetType(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_Common_Status);
							SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage_errorStatus.SetLower(0);
						SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage.AddResult(SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage_errorStatus);
						SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
							// InputPin value
							SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage_value.SetName("value");
							SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage_value.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage.AddArgument(SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage_value);
					SingleDelegation_P_P_Signal_Tester_testActivity.AddNode(SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage);
						// ControlFlow ControlFlow119 from WriteLine(InitialMessage) to this
						SingleDelegation_P_P_Signal_Tester_testActivity_ControlFlow119.SetName("ControlFlow119");
						SingleDelegation_P_P_Signal_Tester_testActivity_ControlFlow119.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Signal_Tester_testActivity_ControlFlow119.SetSource(SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage);
						SingleDelegation_P_P_Signal_Tester_testActivity_ControlFlow119.SetTarget(SingleDelegation_P_P_Signal_Tester_testActivity_this);
					SingleDelegation_P_P_Signal_Tester_testActivity.AddEdge(SingleDelegation_P_P_Signal_Tester_testActivity_ControlFlow119);
						// ControlFlow ControlFlow97 from Call testP to WriteLine(EndMessage)
						SingleDelegation_P_P_Signal_Tester_testActivity_ControlFlow97.SetName("ControlFlow97");
						SingleDelegation_P_P_Signal_Tester_testActivity_ControlFlow97.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Signal_Tester_testActivity_ControlFlow97.SetSource(SingleDelegation_P_P_Signal_Tester_testActivity_Call_testP);
						SingleDelegation_P_P_Signal_Tester_testActivity_ControlFlow97.SetTarget(SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage);
					SingleDelegation_P_P_Signal_Tester_testActivity.AddEdge(SingleDelegation_P_P_Signal_Tester_testActivity_ControlFlow97);
						// ObjectFlow ObjectFlow120 from result to value
						SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow120.SetName("ObjectFlow120");
						SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow120.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow120.SetSource(SingleDelegation_P_P_Signal_Tester_testActivity_InitialMessage_result);
						SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow120.SetTarget(SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_InitialMessage_value);
							// LiteralBoolean LiteralBoolean121
							SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow120_LiteralBoolean121.SetName("LiteralBoolean121");
							SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow120_LiteralBoolean121.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow120_LiteralBoolean121.SetValue(true);
						SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow120.SetGuard(SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow120_LiteralBoolean121);
					SingleDelegation_P_P_Signal_Tester_testActivity.AddEdge(SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow120);
						// ObjectFlow ObjectFlow127 from result to p
						SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow127.SetName("ObjectFlow127");
						SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow127.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow127.SetSource(SingleDelegation_P_P_Signal_Tester_testActivity_Read_b_p_result);
						SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow127.SetTarget(SingleDelegation_P_P_Signal_Tester_testActivity_Call_testP_p);
							// LiteralBoolean LiteralBoolean129
							SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow127_LiteralBoolean129.SetName("LiteralBoolean129");
							SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow127_LiteralBoolean129.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow127_LiteralBoolean129.SetValue(true);
						SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow127.SetGuard(SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow127_LiteralBoolean129);
					SingleDelegation_P_P_Signal_Tester_testActivity.AddEdge(SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow127);
						// ObjectFlow ObjectFlow104 from result to value
						SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow104.SetName("ObjectFlow104");
						SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow104.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow104.SetSource(SingleDelegation_P_P_Signal_Tester_testActivity_EndMessage_result);
						SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow104.SetTarget(SingleDelegation_P_P_Signal_Tester_testActivity_WriteLine_EndMessage_value);
							// LiteralBoolean LiteralBoolean106
							SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow104_LiteralBoolean106.SetName("LiteralBoolean106");
							SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow104_LiteralBoolean106.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow104_LiteralBoolean106.SetValue(true);
						SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow104.SetGuard(SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow104_LiteralBoolean106);
					SingleDelegation_P_P_Signal_Tester_testActivity.AddEdge(SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow104);
						// ObjectFlow ObjectFlow107 from result to object
						SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow107.SetName("ObjectFlow107");
						SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow107.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow107.SetSource(SingleDelegation_P_P_Signal_Tester_testActivity_Read_this_a_result);
						SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow107.SetTarget(SingleDelegation_P_P_Signal_Tester_testActivity_Read_a_b_object);
							// LiteralBoolean LiteralBoolean109
							SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow107_LiteralBoolean109.SetName("LiteralBoolean109");
							SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow107_LiteralBoolean109.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow107_LiteralBoolean109.SetValue(true);
						SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow107.SetGuard(SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow107_LiteralBoolean109);
					SingleDelegation_P_P_Signal_Tester_testActivity.AddEdge(SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow107);
						// ObjectFlow ObjectFlow130 from result to object
						SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow130.SetName("ObjectFlow130");
						SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow130.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow130.SetSource(SingleDelegation_P_P_Signal_Tester_testActivity_Read_a_b_result);
						SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow130.SetTarget(SingleDelegation_P_P_Signal_Tester_testActivity_Read_b_p_object);
							// LiteralBoolean LiteralBoolean132
							SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow130_LiteralBoolean132.SetName("LiteralBoolean132");
							SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow130_LiteralBoolean132.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow130_LiteralBoolean132.SetValue(true);
						SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow130.SetGuard(SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow130_LiteralBoolean132);
					SingleDelegation_P_P_Signal_Tester_testActivity.AddEdge(SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow130);
						// ObjectFlow ObjectFlow139 from result to object
						SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow139.SetName("ObjectFlow139");
						SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow139.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow139.SetSource(SingleDelegation_P_P_Signal_Tester_testActivity_this_result);
						SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow139.SetTarget(SingleDelegation_P_P_Signal_Tester_testActivity_Read_this_a_object);
							// LiteralBoolean LiteralBoolean140
							SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow139_LiteralBoolean140.SetName("LiteralBoolean140");
							SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow139_LiteralBoolean140.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow139_LiteralBoolean140.SetValue(true);
						SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow139.SetGuard(SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow139_LiteralBoolean140);
					SingleDelegation_P_P_Signal_Tester_testActivity.AddEdge(SingleDelegation_P_P_Signal_Tester_testActivity_ObjectFlow139);
				SingleDelegation_P_P_Signal_Tester.AddOwnedBehavior(SingleDelegation_P_P_Signal_Tester_testActivity);
				
				SingleDelegation_P_P_Signal_Tester.SetIsActive(true);
					// Operation Tester_Tester
					SingleDelegation_P_P_Signal_Tester_Tester_Tester.SetName("Tester_Tester");
					SingleDelegation_P_P_Signal_Tester_Tester_Tester.SetVisibility(VisibilityKind.public_);
						// Parameter result
						SingleDelegation_P_P_Signal_Tester_Tester_Tester_result.SetName("result");
						SingleDelegation_P_P_Signal_Tester_Tester_Tester_result.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Signal_Tester_Tester_Tester_result.SetType(SingleDelegation_P_P_Signal_Tester);
						SingleDelegation_P_P_Signal_Tester_Tester_Tester_result.SetDirection(ParameterDirectionKind.return_);
					SingleDelegation_P_P_Signal_Tester_Tester_Tester.AddOwnedParameter(SingleDelegation_P_P_Signal_Tester_Tester_Tester_result);
					SingleDelegation_P_P_Signal_Tester_Tester_Tester.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				SingleDelegation_P_P_Signal_Tester.AddOwnedOperation(SingleDelegation_P_P_Signal_Tester_Tester_Tester);
					// Operation test
					SingleDelegation_P_P_Signal_Tester_test.SetName("test");
					SingleDelegation_P_P_Signal_Tester_test.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_P_Signal_Tester_test.AddMethod(SingleDelegation_P_P_Signal_Tester_testActivity);
					SingleDelegation_P_P_Signal_Tester_test.AddRedefinedOperation(SingleDelegation_P_P_Signal_AbstractTester_test);
				SingleDelegation_P_P_Signal_Tester.AddOwnedOperation(SingleDelegation_P_P_Signal_Tester_test);
			SingleDelegation_P_P_Signal.AddPackagedElement(SingleDelegation_P_P_Signal_Tester);
				// Class AbstractTester
				SingleDelegation_P_P_Signal_AbstractTester.SetName("AbstractTester");
				SingleDelegation_P_P_Signal_AbstractTester.SetVisibility(VisibilityKind.public_);
				
				SingleDelegation_P_P_Signal_AbstractTester.SetIsAbstract(true);
				
				
				SingleDelegation_P_P_Signal_AbstractTester.SetIsActive(true);
					// Operation test
					SingleDelegation_P_P_Signal_AbstractTester_test.SetName("test");
					SingleDelegation_P_P_Signal_AbstractTester_test.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_P_Signal_AbstractTester_test.SetIsAbstract(true);
				SingleDelegation_P_P_Signal_AbstractTester.AddOwnedOperation(SingleDelegation_P_P_Signal_AbstractTester_test);
					// Reception Start
					SingleDelegation_P_P_Signal_AbstractTester_Start.SetName("Start");
					SingleDelegation_P_P_Signal_AbstractTester_Start.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_P_Signal_AbstractTester_Start.SetSignal(SingleDelegation_P_P_Signal_Start);
				SingleDelegation_P_P_Signal_AbstractTester.AddOwnedReception(SingleDelegation_P_P_Signal_AbstractTester_Start);
					// Reception Continue
					SingleDelegation_P_P_Signal_AbstractTester_Continue.SetName("Continue");
					SingleDelegation_P_P_Signal_AbstractTester_Continue.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_P_Signal_AbstractTester_Continue.SetSignal(SingleDelegation_P_P_Signal_Continue);
				SingleDelegation_P_P_Signal_AbstractTester.AddOwnedReception(SingleDelegation_P_P_Signal_AbstractTester_Continue);
			SingleDelegation_P_P_Signal.AddPackagedElement(SingleDelegation_P_P_Signal_AbstractTester);
				// Activity main
				SingleDelegation_P_P_Signal_main.SetName("main");
				SingleDelegation_P_P_Signal_main.SetVisibility(VisibilityKind.public_);
					// CallOperationAction Tester()
					SingleDelegation_P_P_Signal_main_Tester_.SetName("Tester()");
					SingleDelegation_P_P_Signal_main_Tester_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						SingleDelegation_P_P_Signal_main_Tester__result.SetName("result");
						SingleDelegation_P_P_Signal_main_Tester__result.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Signal_main_Tester__result.SetType(SingleDelegation_P_P_Signal_Tester);
					SingleDelegation_P_P_Signal_main_Tester_.AddResult(SingleDelegation_P_P_Signal_main_Tester__result);
					SingleDelegation_P_P_Signal_main_Tester_.SetOperation(SingleDelegation_P_P_Signal_Tester_Tester_Tester);
						// InputPin target
						SingleDelegation_P_P_Signal_main_Tester__target.SetName("target");
						SingleDelegation_P_P_Signal_main_Tester__target.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Signal_main_Tester__target.SetType(SingleDelegation_P_P_Signal_Tester);
					SingleDelegation_P_P_Signal_main_Tester_.SetTarget(SingleDelegation_P_P_Signal_main_Tester__target);
				SingleDelegation_P_P_Signal_main.AddNode(SingleDelegation_P_P_Signal_main_Tester_);
					// CreateObjectAction Create Tester
					SingleDelegation_P_P_Signal_main_Create_Tester.SetName("Create Tester");
					SingleDelegation_P_P_Signal_main_Create_Tester.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_P_Signal_main_Create_Tester.SetClassifier(SingleDelegation_P_P_Signal_Tester);
						// OutputPin result
						SingleDelegation_P_P_Signal_main_Create_Tester_result.SetName("result");
						SingleDelegation_P_P_Signal_main_Create_Tester_result.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Signal_main_Create_Tester_result.SetType(SingleDelegation_P_P_Signal_Tester);
					SingleDelegation_P_P_Signal_main_Create_Tester.SetResult(SingleDelegation_P_P_Signal_main_Create_Tester_result);
				SingleDelegation_P_P_Signal_main.AddNode(SingleDelegation_P_P_Signal_main_Create_Tester);
					// StartObjectBehaviorAction Start Tester
					SingleDelegation_P_P_Signal_main_Start_Tester.SetName("Start Tester");
					SingleDelegation_P_P_Signal_main_Start_Tester.SetVisibility(VisibilityKind.public_);
						// InputPin object
						SingleDelegation_P_P_Signal_main_Start_Tester_object.SetName("object");
						SingleDelegation_P_P_Signal_main_Start_Tester_object.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Signal_main_Start_Tester_object.SetType(SingleDelegation_P_P_Signal_Tester);
					SingleDelegation_P_P_Signal_main_Start_Tester.SetObject(SingleDelegation_P_P_Signal_main_Start_Tester_object);
				SingleDelegation_P_P_Signal_main.AddNode(SingleDelegation_P_P_Signal_main_Start_Tester);
					// SendSignalAction Send Start
					SingleDelegation_P_P_Signal_main_Send_Start.SetName("Send Start");
					SingleDelegation_P_P_Signal_main_Send_Start.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_P_Signal_main_Send_Start.SetSignal(SingleDelegation_P_P_Signal_Start);
						// InputPin target
						SingleDelegation_P_P_Signal_main_Send_Start_target.SetName("target");
						SingleDelegation_P_P_Signal_main_Send_Start_target.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Signal_main_Send_Start_target.SetType(SingleDelegation_P_P_Signal_Tester);
					SingleDelegation_P_P_Signal_main_Send_Start.SetTarget(SingleDelegation_P_P_Signal_main_Send_Start_target);
				SingleDelegation_P_P_Signal_main.AddNode(SingleDelegation_P_P_Signal_main_Send_Start);
					// ForkNode Fork Tester
					SingleDelegation_P_P_Signal_main_Fork_Tester.SetName("Fork Tester");
					SingleDelegation_P_P_Signal_main_Fork_Tester.SetVisibility(VisibilityKind.public_);
				SingleDelegation_P_P_Signal_main.AddNode(SingleDelegation_P_P_Signal_main_Fork_Tester);
					// ObjectFlow ObjectFlow158 from result to target
					SingleDelegation_P_P_Signal_main_ObjectFlow158.SetName("ObjectFlow158");
					SingleDelegation_P_P_Signal_main_ObjectFlow158.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_P_Signal_main_ObjectFlow158.SetSource(SingleDelegation_P_P_Signal_main_Create_Tester_result);
					SingleDelegation_P_P_Signal_main_ObjectFlow158.SetTarget(SingleDelegation_P_P_Signal_main_Tester__target);
						// LiteralBoolean LiteralBoolean159
						SingleDelegation_P_P_Signal_main_ObjectFlow158_LiteralBoolean159.SetName("LiteralBoolean159");
						SingleDelegation_P_P_Signal_main_ObjectFlow158_LiteralBoolean159.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Signal_main_ObjectFlow158_LiteralBoolean159.SetValue(true);
					SingleDelegation_P_P_Signal_main_ObjectFlow158.SetGuard(SingleDelegation_P_P_Signal_main_ObjectFlow158_LiteralBoolean159);
				SingleDelegation_P_P_Signal_main.AddEdge(SingleDelegation_P_P_Signal_main_ObjectFlow158);
					// ObjectFlow ObjectFlow163 from Fork Tester to object
					SingleDelegation_P_P_Signal_main_ObjectFlow163.SetName("ObjectFlow163");
					SingleDelegation_P_P_Signal_main_ObjectFlow163.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_P_Signal_main_ObjectFlow163.SetSource(SingleDelegation_P_P_Signal_main_Fork_Tester);
					SingleDelegation_P_P_Signal_main_ObjectFlow163.SetTarget(SingleDelegation_P_P_Signal_main_Start_Tester_object);
						// LiteralBoolean LiteralBoolean164
						SingleDelegation_P_P_Signal_main_ObjectFlow163_LiteralBoolean164.SetName("LiteralBoolean164");
						SingleDelegation_P_P_Signal_main_ObjectFlow163_LiteralBoolean164.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Signal_main_ObjectFlow163_LiteralBoolean164.SetValue(true);
					SingleDelegation_P_P_Signal_main_ObjectFlow163.SetGuard(SingleDelegation_P_P_Signal_main_ObjectFlow163_LiteralBoolean164);
				SingleDelegation_P_P_Signal_main.AddEdge(SingleDelegation_P_P_Signal_main_ObjectFlow163);
					// ControlFlow ControlFlow166 from Start Tester to Send Start
					SingleDelegation_P_P_Signal_main_ControlFlow166.SetName("ControlFlow166");
					SingleDelegation_P_P_Signal_main_ControlFlow166.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_P_Signal_main_ControlFlow166.SetSource(SingleDelegation_P_P_Signal_main_Start_Tester);
					SingleDelegation_P_P_Signal_main_ControlFlow166.SetTarget(SingleDelegation_P_P_Signal_main_Send_Start);
				SingleDelegation_P_P_Signal_main.AddEdge(SingleDelegation_P_P_Signal_main_ControlFlow166);
					// ObjectFlow ObjectFlow167 from result to Fork Tester
					SingleDelegation_P_P_Signal_main_ObjectFlow167.SetName("ObjectFlow167");
					SingleDelegation_P_P_Signal_main_ObjectFlow167.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_P_Signal_main_ObjectFlow167.SetSource(SingleDelegation_P_P_Signal_main_Tester__result);
					SingleDelegation_P_P_Signal_main_ObjectFlow167.SetTarget(SingleDelegation_P_P_Signal_main_Fork_Tester);
						// LiteralBoolean LiteralBoolean169
						SingleDelegation_P_P_Signal_main_ObjectFlow167_LiteralBoolean169.SetName("LiteralBoolean169");
						SingleDelegation_P_P_Signal_main_ObjectFlow167_LiteralBoolean169.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Signal_main_ObjectFlow167_LiteralBoolean169.SetValue(true);
					SingleDelegation_P_P_Signal_main_ObjectFlow167.SetGuard(SingleDelegation_P_P_Signal_main_ObjectFlow167_LiteralBoolean169);
				SingleDelegation_P_P_Signal_main.AddEdge(SingleDelegation_P_P_Signal_main_ObjectFlow167);
					// ObjectFlow ObjectFlow174 from Fork Tester to target
					SingleDelegation_P_P_Signal_main_ObjectFlow174.SetName("ObjectFlow174");
					SingleDelegation_P_P_Signal_main_ObjectFlow174.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_P_Signal_main_ObjectFlow174.SetSource(SingleDelegation_P_P_Signal_main_Fork_Tester);
					SingleDelegation_P_P_Signal_main_ObjectFlow174.SetTarget(SingleDelegation_P_P_Signal_main_Send_Start_target);
						// LiteralBoolean LiteralBoolean175
						SingleDelegation_P_P_Signal_main_ObjectFlow174_LiteralBoolean175.SetName("LiteralBoolean175");
						SingleDelegation_P_P_Signal_main_ObjectFlow174_LiteralBoolean175.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Signal_main_ObjectFlow174_LiteralBoolean175.SetValue(true);
					SingleDelegation_P_P_Signal_main_ObjectFlow174.SetGuard(SingleDelegation_P_P_Signal_main_ObjectFlow174_LiteralBoolean175);
				SingleDelegation_P_P_Signal_main.AddEdge(SingleDelegation_P_P_Signal_main_ObjectFlow174);
			SingleDelegation_P_P_Signal.AddPackagedElement(SingleDelegation_P_P_Signal_main);
				// Interface I
				SingleDelegation_P_P_Signal_I.SetName("I");
				SingleDelegation_P_P_Signal_I.SetVisibility(VisibilityKind.public_);
					// Reception S
					SingleDelegation_P_P_Signal_I_S.SetName("S");
					SingleDelegation_P_P_Signal_I_S.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_P_Signal_I_S.SetSignal(SingleDelegation_P_P_Signal_S);
				SingleDelegation_P_P_Signal_I.AddOwnedReception(SingleDelegation_P_P_Signal_I_S);
			SingleDelegation_P_P_Signal.AddPackagedElement(SingleDelegation_P_P_Signal_I);
				// SignalEvent SignalEventStart
				SingleDelegation_P_P_Signal_SignalEventStart.SetName("SignalEventStart");
				SingleDelegation_P_P_Signal_SignalEventStart.SetVisibility(VisibilityKind.public_);
				SingleDelegation_P_P_Signal_SignalEventStart.SetSignal(SingleDelegation_P_P_Signal_Start);
			SingleDelegation_P_P_Signal.AddPackagedElement(SingleDelegation_P_P_Signal_SignalEventStart);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // SingleDelegation_P_P_SignalModel
}
