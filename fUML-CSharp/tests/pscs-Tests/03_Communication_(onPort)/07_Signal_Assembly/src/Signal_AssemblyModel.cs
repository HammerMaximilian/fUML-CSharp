/*
 * Signal_AssemblyModel.cs
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

namespace Signal_Assembly
{
	public class Signal_AssemblyModel : InMemoryModel
	{
		private static Signal_AssemblyModel? instance;

		/*
		 * Model Signal_Assembly
		 */
		public Package Signal_Assembly = new();
			public SignalEvent Signal_Assembly_StartEvent = new();
			public Signal Signal_Assembly_Start = new();
				public Property Signal_Assembly_Start_testCase = new();
			public Association Signal_Assembly_R = new();
				public Property Signal_Assembly_R_x = new();
				public Property Signal_Assembly_R_y = new();
			public Class_ Signal_Assembly_I = new();
			public SignalEvent Signal_Assembly_ContinueEvent = new();
			public Class_ Signal_Assembly_TestCaseAssembly = new();
				public Property Signal_Assembly_TestCaseAssembly_a = new();
				public Property Signal_Assembly_TestCaseAssembly_tester = new();
				public Operation Signal_Assembly_TestCaseAssembly_TestCaseAssembly_TestCaseAssembly = new();
					public Parameter Signal_Assembly_TestCaseAssembly_TestCaseAssembly_TestCaseAssembly_result = new();
				public Connector Signal_Assembly_TestCaseAssembly_r = new();
					public ConnectorEnd Signal_Assembly_TestCaseAssembly_r_ConnectorEnd0 = new();
					public ConnectorEnd Signal_Assembly_TestCaseAssembly_r_ConnectorEnd1 = new();
				public Activity Signal_Assembly_TestCaseAssembly_testActivity = new();
					public OpaqueBehavior Signal_Assembly_TestCaseAssembly_testActivity_testV = new();
						public Parameter Signal_Assembly_TestCaseAssembly_testActivity_testV_v = new();
					public ObjectFlow Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow2 = new();
						public LiteralInteger Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow2_LiteralInteger3 = new();
						public LiteralBoolean Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow2_LiteralBoolean4 = new();
					public ObjectFlow Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow5 = new();
						public LiteralInteger Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow5_LiteralInteger6 = new();
						public LiteralBoolean Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow5_LiteralBoolean7 = new();
					public ReadStructuralFeatureAction Signal_Assembly_TestCaseAssembly_testActivity_Read_this_a = new();
						public OutputPin Signal_Assembly_TestCaseAssembly_testActivity_Read_this_a_result = new();
							public LiteralInteger Signal_Assembly_TestCaseAssembly_testActivity_Read_this_a_result_LiteralInteger8 = new();
							public LiteralUnlimitedNatural Signal_Assembly_TestCaseAssembly_testActivity_Read_this_a_result_LiteralUnlimitedNatural9 = new();
						public InputPin Signal_Assembly_TestCaseAssembly_testActivity_Read_this_a_object = new();
							public LiteralUnlimitedNatural Signal_Assembly_TestCaseAssembly_testActivity_Read_this_a_object_LiteralUnlimitedNatural10 = new();
							public LiteralInteger Signal_Assembly_TestCaseAssembly_testActivity_Read_this_a_object_LiteralInteger11 = new();
					public ReadStructuralFeatureAction Signal_Assembly_TestCaseAssembly_testActivity_Read_a_v = new();
						public InputPin Signal_Assembly_TestCaseAssembly_testActivity_Read_a_v_object = new();
							public LiteralInteger Signal_Assembly_TestCaseAssembly_testActivity_Read_a_v_object_LiteralInteger12 = new();
							public LiteralUnlimitedNatural Signal_Assembly_TestCaseAssembly_testActivity_Read_a_v_object_LiteralUnlimitedNatural13 = new();
						public OutputPin Signal_Assembly_TestCaseAssembly_testActivity_Read_a_v_result = new();
							public LiteralUnlimitedNatural Signal_Assembly_TestCaseAssembly_testActivity_Read_a_v_result_LiteralUnlimitedNatural14 = new();
							public LiteralInteger Signal_Assembly_TestCaseAssembly_testActivity_Read_a_v_result_LiteralInteger15 = new();
					public ObjectFlow Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow16 = new();
						public LiteralInteger Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow16_LiteralInteger17 = new();
						public LiteralBoolean Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow16_LiteralBoolean18 = new();
					public ReadSelfAction Signal_Assembly_TestCaseAssembly_testActivity_this = new();
						public OutputPin Signal_Assembly_TestCaseAssembly_testActivity_this_result = new();
							public LiteralInteger Signal_Assembly_TestCaseAssembly_testActivity_this_result_LiteralInteger19 = new();
							public LiteralUnlimitedNatural Signal_Assembly_TestCaseAssembly_testActivity_this_result_LiteralUnlimitedNatural20 = new();
					public CallBehaviorAction Signal_Assembly_TestCaseAssembly_testActivity_Call_testV = new();
						public InputPin Signal_Assembly_TestCaseAssembly_testActivity_Call_testV_v = new();
							public LiteralUnlimitedNatural Signal_Assembly_TestCaseAssembly_testActivity_Call_testV_v_LiteralUnlimitedNatural21 = new();
							public LiteralInteger Signal_Assembly_TestCaseAssembly_testActivity_Call_testV_v_LiteralInteger22 = new();
							public LiteralInteger Signal_Assembly_TestCaseAssembly_testActivity_Call_testV_v_LiteralInteger23 = new();
				public Generalization Signal_Assembly_TestCaseAssembly_Generalization24 = new();
				public Operation Signal_Assembly_TestCaseAssembly_test = new();
			public Class_ Signal_Assembly_TestCase = new();
				public Operation Signal_Assembly_TestCase_test = new();
			public Signal Signal_Assembly_S = new();
				public Property Signal_Assembly_S_value = new();
			public Activity Signal_Assembly_main = new();
				public ObjectFlow Signal_Assembly_main_ObjectFlow25 = new();
					public LiteralInteger Signal_Assembly_main_ObjectFlow25_LiteralInteger26 = new();
					public LiteralBoolean Signal_Assembly_main_ObjectFlow25_LiteralBoolean27 = new();
				public ReadStructuralFeatureAction Signal_Assembly_main_Read_TestCaseAssembly_tester = new();
					public InputPin Signal_Assembly_main_Read_TestCaseAssembly_tester_object = new();
						public LiteralUnlimitedNatural Signal_Assembly_main_Read_TestCaseAssembly_tester_object_LiteralUnlimitedNatural28 = new();
						public LiteralInteger Signal_Assembly_main_Read_TestCaseAssembly_tester_object_LiteralInteger29 = new();
					public OutputPin Signal_Assembly_main_Read_TestCaseAssembly_tester_result = new();
						public LiteralUnlimitedNatural Signal_Assembly_main_Read_TestCaseAssembly_tester_result_LiteralUnlimitedNatural30 = new();
						public LiteralInteger Signal_Assembly_main_Read_TestCaseAssembly_tester_result_LiteralInteger31 = new();
				public CreateObjectAction Signal_Assembly_main_Create_TestCaseAssembly = new();
					public OutputPin Signal_Assembly_main_Create_TestCaseAssembly_result = new();
						public LiteralInteger Signal_Assembly_main_Create_TestCaseAssembly_result_LiteralInteger32 = new();
						public LiteralUnlimitedNatural Signal_Assembly_main_Create_TestCaseAssembly_result_LiteralUnlimitedNatural33 = new();
				public ObjectFlow Signal_Assembly_main_ObjectFlow34 = new();
					public LiteralInteger Signal_Assembly_main_ObjectFlow34_LiteralInteger35 = new();
					public LiteralBoolean Signal_Assembly_main_ObjectFlow34_LiteralBoolean36 = new();
				public ObjectFlow Signal_Assembly_main_ObjectFlow37 = new();
					public LiteralInteger Signal_Assembly_main_ObjectFlow37_LiteralInteger38 = new();
					public LiteralBoolean Signal_Assembly_main_ObjectFlow37_LiteralBoolean39 = new();
				public CallOperationAction Signal_Assembly_main_TestCaseAssembly_ = new();
					public InputPin Signal_Assembly_main_TestCaseAssembly__target = new();
						public LiteralInteger Signal_Assembly_main_TestCaseAssembly__target_LiteralInteger40 = new();
						public LiteralUnlimitedNatural Signal_Assembly_main_TestCaseAssembly__target_LiteralUnlimitedNatural41 = new();
					public OutputPin Signal_Assembly_main_TestCaseAssembly__result = new();
						public LiteralUnlimitedNatural Signal_Assembly_main_TestCaseAssembly__result_LiteralUnlimitedNatural42 = new();
						public LiteralInteger Signal_Assembly_main_TestCaseAssembly__result_LiteralInteger43 = new();
						public LiteralInteger Signal_Assembly_main_TestCaseAssembly__result_LiteralInteger44 = new();
				public ForkNode Signal_Assembly_main_Fork_testCase = new();
				public ObjectFlow Signal_Assembly_main_ObjectFlow45 = new();
					public LiteralBoolean Signal_Assembly_main_ObjectFlow45_LiteralBoolean46 = new();
					public LiteralInteger Signal_Assembly_main_ObjectFlow45_LiteralInteger47 = new();
				public ObjectFlow Signal_Assembly_main_ObjectFlow48 = new();
					public LiteralBoolean Signal_Assembly_main_ObjectFlow48_LiteralBoolean49 = new();
					public LiteralInteger Signal_Assembly_main_ObjectFlow48_LiteralInteger50 = new();
				public SendSignalAction Signal_Assembly_main_Send_Start = new();
					public InputPin Signal_Assembly_main_Send_Start_target = new();
						public LiteralUnlimitedNatural Signal_Assembly_main_Send_Start_target_LiteralUnlimitedNatural51 = new();
						public LiteralInteger Signal_Assembly_main_Send_Start_target_LiteralInteger52 = new();
					public InputPin Signal_Assembly_main_Send_Start_testCase = new();
						public LiteralInteger Signal_Assembly_main_Send_Start_testCase_LiteralInteger53 = new();
						public LiteralInteger Signal_Assembly_main_Send_Start_testCase_LiteralInteger54 = new();
						public LiteralUnlimitedNatural Signal_Assembly_main_Send_Start_testCase_LiteralUnlimitedNatural55 = new();
			public Class_ Signal_Assembly_Tester = new();
				public Reception Signal_Assembly_Tester_Start = new();
				public Activity Signal_Assembly_Tester_TesterClassifierBehavior = new();
					public ObjectFlow Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow56 = new();
						public LiteralInteger Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow56_LiteralInteger57 = new();
						public LiteralBoolean Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow56_LiteralBoolean58 = new();
					public ControlFlow Signal_Assembly_Tester_TesterClassifierBehavior_ControlFlow59 = new();
					public ObjectFlow Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow60 = new();
						public LiteralBoolean Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow60_LiteralBoolean61 = new();
						public LiteralInteger Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow60_LiteralInteger62 = new();
					public ControlFlow Signal_Assembly_Tester_TesterClassifierBehavior_ControlFlow63 = new();
					public CallOperationAction Signal_Assembly_Tester_TesterClassifierBehavior_Call_test_ = new();
						public InputPin Signal_Assembly_Tester_TesterClassifierBehavior_Call_test__target = new();
							public LiteralInteger Signal_Assembly_Tester_TesterClassifierBehavior_Call_test__target_LiteralInteger64 = new();
							public LiteralUnlimitedNatural Signal_Assembly_Tester_TesterClassifierBehavior_Call_test__target_LiteralUnlimitedNatural65 = new();
					public AcceptEventAction Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Start = new();
						public OutputPin Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Start_testCase = new();
							public LiteralInteger Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Start_testCase_LiteralInteger66 = new();
							public LiteralUnlimitedNatural Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Start_testCase_LiteralUnlimitedNatural67 = new();
							public LiteralInteger Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Start_testCase_LiteralInteger68 = new();
						public Trigger Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Start_Trigger69 = new();
					public ControlFlow Signal_Assembly_Tester_TesterClassifierBehavior_ControlFlow70 = new();
					public ValueSpecificationAction Signal_Assembly_Tester_TesterClassifierBehavior_Value_4 = new();
						public OutputPin Signal_Assembly_Tester_TesterClassifierBehavior_Value_4_result = new();
							public LiteralInteger Signal_Assembly_Tester_TesterClassifierBehavior_Value_4_result_LiteralInteger71 = new();
							public LiteralUnlimitedNatural Signal_Assembly_Tester_TesterClassifierBehavior_Value_4_result_LiteralUnlimitedNatural72 = new();
						public LiteralInteger Signal_Assembly_Tester_TesterClassifierBehavior_Value_4_LiteralInteger73 = new();
					public ControlFlow Signal_Assembly_Tester_TesterClassifierBehavior_ControlFlow74 = new();
					public ObjectFlow Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow75 = new();
						public LiteralBoolean Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow75_LiteralBoolean76 = new();
						public LiteralInteger Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow75_LiteralInteger77 = new();
					public ActivityFinalNode Signal_Assembly_Tester_TesterClassifierBehavior_ActivityFinalNode78 = new();
					public AcceptEventAction Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Continue = new();
						public Trigger Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Continue_Trigger79 = new();
						public OutputPin Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Continue_result = new();
							public LiteralUnlimitedNatural Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Continue_result_LiteralUnlimitedNatural80 = new();
							public LiteralInteger Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Continue_result_LiteralInteger81 = new();
							public LiteralInteger Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Continue_result_LiteralInteger82 = new();
					public ReadSelfAction Signal_Assembly_Tester_TesterClassifierBehavior_this = new();
						public OutputPin Signal_Assembly_Tester_TesterClassifierBehavior_this_result = new();
							public LiteralUnlimitedNatural Signal_Assembly_Tester_TesterClassifierBehavior_this_result_LiteralUnlimitedNatural83 = new();
							public LiteralInteger Signal_Assembly_Tester_TesterClassifierBehavior_this_result_LiteralInteger84 = new();
					public SendSignalAction Signal_Assembly_Tester_TesterClassifierBehavior_Send_S = new();
						public InputPin Signal_Assembly_Tester_TesterClassifierBehavior_Send_S_value = new();
							public LiteralInteger Signal_Assembly_Tester_TesterClassifierBehavior_Send_S_value_LiteralInteger85 = new();
							public LiteralInteger Signal_Assembly_Tester_TesterClassifierBehavior_Send_S_value_LiteralInteger86 = new();
							public LiteralUnlimitedNatural Signal_Assembly_Tester_TesterClassifierBehavior_Send_S_value_LiteralUnlimitedNatural87 = new();
						public InputPin Signal_Assembly_Tester_TesterClassifierBehavior_Send_S_target = new();
							public LiteralUnlimitedNatural Signal_Assembly_Tester_TesterClassifierBehavior_Send_S_target_LiteralUnlimitedNatural88 = new();
							public LiteralInteger Signal_Assembly_Tester_TesterClassifierBehavior_Send_S_target_LiteralInteger89 = new();
				public Port Signal_Assembly_Tester_q = new();
				public Operation Signal_Assembly_Tester_Tester_Tester = new();
					public Parameter Signal_Assembly_Tester_Tester_Tester_result = new();
			public Signal Signal_Assembly_Continue = new();
			public SignalEvent Signal_Assembly_SEvent = new();
			public Class_ Signal_Assembly_A = new();
				public Port Signal_Assembly_A_p = new();
				public Activity Signal_Assembly_A_AClassifierBehavior = new();
					public ObjectFlow Signal_Assembly_A_AClassifierBehavior_ObjectFlow90 = new();
						public LiteralInteger Signal_Assembly_A_AClassifierBehavior_ObjectFlow90_LiteralInteger91 = new();
						public LiteralBoolean Signal_Assembly_A_AClassifierBehavior_ObjectFlow90_LiteralBoolean92 = new();
					public ActivityFinalNode Signal_Assembly_A_AClassifierBehavior_ActivityFinalNode93 = new();
					public ObjectFlow Signal_Assembly_A_AClassifierBehavior_ObjectFlow94 = new();
						public LiteralBoolean Signal_Assembly_A_AClassifierBehavior_ObjectFlow94_LiteralBoolean95 = new();
						public LiteralInteger Signal_Assembly_A_AClassifierBehavior_ObjectFlow94_LiteralInteger96 = new();
					public ObjectFlow Signal_Assembly_A_AClassifierBehavior_ObjectFlow97 = new();
						public LiteralBoolean Signal_Assembly_A_AClassifierBehavior_ObjectFlow97_LiteralBoolean98 = new();
						public LiteralInteger Signal_Assembly_A_AClassifierBehavior_ObjectFlow97_LiteralInteger99 = new();
					public ControlFlow Signal_Assembly_A_AClassifierBehavior_ControlFlow100 = new();
					public AddStructuralFeatureValueAction Signal_Assembly_A_AClassifierBehavior_Set_v = new();
						public OutputPin Signal_Assembly_A_AClassifierBehavior_Set_v_result = new();
							public LiteralInteger Signal_Assembly_A_AClassifierBehavior_Set_v_result_LiteralInteger101 = new();
							public LiteralUnlimitedNatural Signal_Assembly_A_AClassifierBehavior_Set_v_result_LiteralUnlimitedNatural102 = new();
						public InputPin Signal_Assembly_A_AClassifierBehavior_Set_v_object = new();
							public LiteralInteger Signal_Assembly_A_AClassifierBehavior_Set_v_object_LiteralInteger103 = new();
							public LiteralUnlimitedNatural Signal_Assembly_A_AClassifierBehavior_Set_v_object_LiteralUnlimitedNatural104 = new();
						public InputPin Signal_Assembly_A_AClassifierBehavior_Set_v_value = new();
							public LiteralInteger Signal_Assembly_A_AClassifierBehavior_Set_v_value_LiteralInteger105 = new();
							public LiteralUnlimitedNatural Signal_Assembly_A_AClassifierBehavior_Set_v_value_LiteralUnlimitedNatural106 = new();
					public ControlFlow Signal_Assembly_A_AClassifierBehavior_ControlFlow107 = new();
					public ReadSelfAction Signal_Assembly_A_AClassifierBehavior_this = new();
						public OutputPin Signal_Assembly_A_AClassifierBehavior_this_result = new();
							public LiteralUnlimitedNatural Signal_Assembly_A_AClassifierBehavior_this_result_LiteralUnlimitedNatural108 = new();
							public LiteralInteger Signal_Assembly_A_AClassifierBehavior_this_result_LiteralInteger109 = new();
					public AcceptEventAction Signal_Assembly_A_AClassifierBehavior_Accept_S = new();
						public Trigger Signal_Assembly_A_AClassifierBehavior_Accept_S_Trigger110 = new();
						public OutputPin Signal_Assembly_A_AClassifierBehavior_Accept_S_value = new();
							public LiteralInteger Signal_Assembly_A_AClassifierBehavior_Accept_S_value_LiteralInteger111 = new();
							public LiteralUnlimitedNatural Signal_Assembly_A_AClassifierBehavior_Accept_S_value_LiteralUnlimitedNatural112 = new();
							public LiteralInteger Signal_Assembly_A_AClassifierBehavior_Accept_S_value_LiteralInteger113 = new();
					public SendSignalAction Signal_Assembly_A_AClassifierBehavior_Send_Continue = new();
						public InputPin Signal_Assembly_A_AClassifierBehavior_Send_Continue_target = new();
							public LiteralUnlimitedNatural Signal_Assembly_A_AClassifierBehavior_Send_Continue_target_LiteralUnlimitedNatural114 = new();
							public LiteralInteger Signal_Assembly_A_AClassifierBehavior_Send_Continue_target_LiteralInteger115 = new();
				public Property Signal_Assembly_A_v = new();
				public Operation Signal_Assembly_A_A_A = new();
					public Parameter Signal_Assembly_A_A_A_result = new();

		public static Signal_AssemblyModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public Signal_AssemblyModel()
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
			 * Model Signal_Assembly
			 */
			AddToElementRepository("Signal_Assembly", Signal_Assembly);
				AddToElementRepository("StartEvent", Signal_Assembly_StartEvent);
				AddToElementRepository("Start", Signal_Assembly_Start);
					AddToElementRepository("testCase", Signal_Assembly_Start_testCase);
				AddToElementRepository("R", Signal_Assembly_R);
					AddToElementRepository("x", Signal_Assembly_R_x);
					AddToElementRepository("y", Signal_Assembly_R_y);
				AddToElementRepository("I", Signal_Assembly_I);
				AddToElementRepository("ContinueEvent", Signal_Assembly_ContinueEvent);
				AddToElementRepository("TestCaseAssembly", Signal_Assembly_TestCaseAssembly);
					AddToElementRepository("a", Signal_Assembly_TestCaseAssembly_a);
					AddToElementRepository("tester", Signal_Assembly_TestCaseAssembly_tester);
					AddToElementRepository("TestCaseAssembly_TestCaseAssembly", Signal_Assembly_TestCaseAssembly_TestCaseAssembly_TestCaseAssembly);
						AddToElementRepository("result", Signal_Assembly_TestCaseAssembly_TestCaseAssembly_TestCaseAssembly_result);
					AddToElementRepository("r", Signal_Assembly_TestCaseAssembly_r);
						AddToElementRepository("ConnectorEnd0", Signal_Assembly_TestCaseAssembly_r_ConnectorEnd0);
						AddToElementRepository("ConnectorEnd1", Signal_Assembly_TestCaseAssembly_r_ConnectorEnd1);
					AddToElementRepository("testActivity", Signal_Assembly_TestCaseAssembly_testActivity);
						AddToElementRepository("testV", Signal_Assembly_TestCaseAssembly_testActivity_testV);
							AddToElementRepository("v", Signal_Assembly_TestCaseAssembly_testActivity_testV_v);
						AddToElementRepository("ObjectFlow2", Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow2);
							AddToElementRepository("LiteralInteger3", Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow2_LiteralInteger3);
							AddToElementRepository("LiteralBoolean4", Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow2_LiteralBoolean4);
						AddToElementRepository("ObjectFlow5", Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow5);
							AddToElementRepository("LiteralInteger6", Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow5_LiteralInteger6);
							AddToElementRepository("LiteralBoolean7", Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow5_LiteralBoolean7);
						AddToElementRepository("Read this.a", Signal_Assembly_TestCaseAssembly_testActivity_Read_this_a);
							AddToElementRepository("result", Signal_Assembly_TestCaseAssembly_testActivity_Read_this_a_result);
								AddToElementRepository("LiteralInteger8", Signal_Assembly_TestCaseAssembly_testActivity_Read_this_a_result_LiteralInteger8);
								AddToElementRepository("LiteralUnlimitedNatural9", Signal_Assembly_TestCaseAssembly_testActivity_Read_this_a_result_LiteralUnlimitedNatural9);
							AddToElementRepository("object", Signal_Assembly_TestCaseAssembly_testActivity_Read_this_a_object);
								AddToElementRepository("LiteralUnlimitedNatural10", Signal_Assembly_TestCaseAssembly_testActivity_Read_this_a_object_LiteralUnlimitedNatural10);
								AddToElementRepository("LiteralInteger11", Signal_Assembly_TestCaseAssembly_testActivity_Read_this_a_object_LiteralInteger11);
						AddToElementRepository("Read a.v", Signal_Assembly_TestCaseAssembly_testActivity_Read_a_v);
							AddToElementRepository("object", Signal_Assembly_TestCaseAssembly_testActivity_Read_a_v_object);
								AddToElementRepository("LiteralInteger12", Signal_Assembly_TestCaseAssembly_testActivity_Read_a_v_object_LiteralInteger12);
								AddToElementRepository("LiteralUnlimitedNatural13", Signal_Assembly_TestCaseAssembly_testActivity_Read_a_v_object_LiteralUnlimitedNatural13);
							AddToElementRepository("result", Signal_Assembly_TestCaseAssembly_testActivity_Read_a_v_result);
								AddToElementRepository("LiteralUnlimitedNatural14", Signal_Assembly_TestCaseAssembly_testActivity_Read_a_v_result_LiteralUnlimitedNatural14);
								AddToElementRepository("LiteralInteger15", Signal_Assembly_TestCaseAssembly_testActivity_Read_a_v_result_LiteralInteger15);
						AddToElementRepository("ObjectFlow16", Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow16);
							AddToElementRepository("LiteralInteger17", Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow16_LiteralInteger17);
							AddToElementRepository("LiteralBoolean18", Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow16_LiteralBoolean18);
						AddToElementRepository("this", Signal_Assembly_TestCaseAssembly_testActivity_this);
							AddToElementRepository("result", Signal_Assembly_TestCaseAssembly_testActivity_this_result);
								AddToElementRepository("LiteralInteger19", Signal_Assembly_TestCaseAssembly_testActivity_this_result_LiteralInteger19);
								AddToElementRepository("LiteralUnlimitedNatural20", Signal_Assembly_TestCaseAssembly_testActivity_this_result_LiteralUnlimitedNatural20);
						AddToElementRepository("Call testV", Signal_Assembly_TestCaseAssembly_testActivity_Call_testV);
							AddToElementRepository("v", Signal_Assembly_TestCaseAssembly_testActivity_Call_testV_v);
								AddToElementRepository("LiteralUnlimitedNatural21", Signal_Assembly_TestCaseAssembly_testActivity_Call_testV_v_LiteralUnlimitedNatural21);
								AddToElementRepository("LiteralInteger22", Signal_Assembly_TestCaseAssembly_testActivity_Call_testV_v_LiteralInteger22);
								AddToElementRepository("LiteralInteger23", Signal_Assembly_TestCaseAssembly_testActivity_Call_testV_v_LiteralInteger23);
					AddToElementRepository("Generalization24", Signal_Assembly_TestCaseAssembly_Generalization24);
					AddToElementRepository("test", Signal_Assembly_TestCaseAssembly_test);
				AddToElementRepository("TestCase", Signal_Assembly_TestCase);
					AddToElementRepository("test", Signal_Assembly_TestCase_test);
				AddToElementRepository("S", Signal_Assembly_S);
					AddToElementRepository("value", Signal_Assembly_S_value);
				AddToElementRepository("main", Signal_Assembly_main);
					AddToElementRepository("ObjectFlow25", Signal_Assembly_main_ObjectFlow25);
						AddToElementRepository("LiteralInteger26", Signal_Assembly_main_ObjectFlow25_LiteralInteger26);
						AddToElementRepository("LiteralBoolean27", Signal_Assembly_main_ObjectFlow25_LiteralBoolean27);
					AddToElementRepository("Read TestCaseAssembly.tester", Signal_Assembly_main_Read_TestCaseAssembly_tester);
						AddToElementRepository("object", Signal_Assembly_main_Read_TestCaseAssembly_tester_object);
							AddToElementRepository("LiteralUnlimitedNatural28", Signal_Assembly_main_Read_TestCaseAssembly_tester_object_LiteralUnlimitedNatural28);
							AddToElementRepository("LiteralInteger29", Signal_Assembly_main_Read_TestCaseAssembly_tester_object_LiteralInteger29);
						AddToElementRepository("result", Signal_Assembly_main_Read_TestCaseAssembly_tester_result);
							AddToElementRepository("LiteralUnlimitedNatural30", Signal_Assembly_main_Read_TestCaseAssembly_tester_result_LiteralUnlimitedNatural30);
							AddToElementRepository("LiteralInteger31", Signal_Assembly_main_Read_TestCaseAssembly_tester_result_LiteralInteger31);
					AddToElementRepository("Create TestCaseAssembly", Signal_Assembly_main_Create_TestCaseAssembly);
						AddToElementRepository("result", Signal_Assembly_main_Create_TestCaseAssembly_result);
							AddToElementRepository("LiteralInteger32", Signal_Assembly_main_Create_TestCaseAssembly_result_LiteralInteger32);
							AddToElementRepository("LiteralUnlimitedNatural33", Signal_Assembly_main_Create_TestCaseAssembly_result_LiteralUnlimitedNatural33);
					AddToElementRepository("ObjectFlow34", Signal_Assembly_main_ObjectFlow34);
						AddToElementRepository("LiteralInteger35", Signal_Assembly_main_ObjectFlow34_LiteralInteger35);
						AddToElementRepository("LiteralBoolean36", Signal_Assembly_main_ObjectFlow34_LiteralBoolean36);
					AddToElementRepository("ObjectFlow37", Signal_Assembly_main_ObjectFlow37);
						AddToElementRepository("LiteralInteger38", Signal_Assembly_main_ObjectFlow37_LiteralInteger38);
						AddToElementRepository("LiteralBoolean39", Signal_Assembly_main_ObjectFlow37_LiteralBoolean39);
					AddToElementRepository("TestCaseAssembly()", Signal_Assembly_main_TestCaseAssembly_);
						AddToElementRepository("target", Signal_Assembly_main_TestCaseAssembly__target);
							AddToElementRepository("LiteralInteger40", Signal_Assembly_main_TestCaseAssembly__target_LiteralInteger40);
							AddToElementRepository("LiteralUnlimitedNatural41", Signal_Assembly_main_TestCaseAssembly__target_LiteralUnlimitedNatural41);
						AddToElementRepository("result", Signal_Assembly_main_TestCaseAssembly__result);
							AddToElementRepository("LiteralUnlimitedNatural42", Signal_Assembly_main_TestCaseAssembly__result_LiteralUnlimitedNatural42);
							AddToElementRepository("LiteralInteger43", Signal_Assembly_main_TestCaseAssembly__result_LiteralInteger43);
							AddToElementRepository("LiteralInteger44", Signal_Assembly_main_TestCaseAssembly__result_LiteralInteger44);
					AddToElementRepository("Fork testCase", Signal_Assembly_main_Fork_testCase);
					AddToElementRepository("ObjectFlow45", Signal_Assembly_main_ObjectFlow45);
						AddToElementRepository("LiteralBoolean46", Signal_Assembly_main_ObjectFlow45_LiteralBoolean46);
						AddToElementRepository("LiteralInteger47", Signal_Assembly_main_ObjectFlow45_LiteralInteger47);
					AddToElementRepository("ObjectFlow48", Signal_Assembly_main_ObjectFlow48);
						AddToElementRepository("LiteralBoolean49", Signal_Assembly_main_ObjectFlow48_LiteralBoolean49);
						AddToElementRepository("LiteralInteger50", Signal_Assembly_main_ObjectFlow48_LiteralInteger50);
					AddToElementRepository("Send Start", Signal_Assembly_main_Send_Start);
						AddToElementRepository("target", Signal_Assembly_main_Send_Start_target);
							AddToElementRepository("LiteralUnlimitedNatural51", Signal_Assembly_main_Send_Start_target_LiteralUnlimitedNatural51);
							AddToElementRepository("LiteralInteger52", Signal_Assembly_main_Send_Start_target_LiteralInteger52);
						AddToElementRepository("testCase", Signal_Assembly_main_Send_Start_testCase);
							AddToElementRepository("LiteralInteger53", Signal_Assembly_main_Send_Start_testCase_LiteralInteger53);
							AddToElementRepository("LiteralInteger54", Signal_Assembly_main_Send_Start_testCase_LiteralInteger54);
							AddToElementRepository("LiteralUnlimitedNatural55", Signal_Assembly_main_Send_Start_testCase_LiteralUnlimitedNatural55);
				AddToElementRepository("Tester", Signal_Assembly_Tester);
					AddToElementRepository("Start", Signal_Assembly_Tester_Start);
					AddToElementRepository("TesterClassifierBehavior", Signal_Assembly_Tester_TesterClassifierBehavior);
						AddToElementRepository("ObjectFlow56", Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow56);
							AddToElementRepository("LiteralInteger57", Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow56_LiteralInteger57);
							AddToElementRepository("LiteralBoolean58", Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow56_LiteralBoolean58);
						AddToElementRepository("ControlFlow59", Signal_Assembly_Tester_TesterClassifierBehavior_ControlFlow59);
						AddToElementRepository("ObjectFlow60", Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow60);
							AddToElementRepository("LiteralBoolean61", Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow60_LiteralBoolean61);
							AddToElementRepository("LiteralInteger62", Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow60_LiteralInteger62);
						AddToElementRepository("ControlFlow63", Signal_Assembly_Tester_TesterClassifierBehavior_ControlFlow63);
						AddToElementRepository("Call test()", Signal_Assembly_Tester_TesterClassifierBehavior_Call_test_);
							AddToElementRepository("target", Signal_Assembly_Tester_TesterClassifierBehavior_Call_test__target);
								AddToElementRepository("LiteralInteger64", Signal_Assembly_Tester_TesterClassifierBehavior_Call_test__target_LiteralInteger64);
								AddToElementRepository("LiteralUnlimitedNatural65", Signal_Assembly_Tester_TesterClassifierBehavior_Call_test__target_LiteralUnlimitedNatural65);
						AddToElementRepository("Accept Start", Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Start);
							AddToElementRepository("testCase", Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Start_testCase);
								AddToElementRepository("LiteralInteger66", Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Start_testCase_LiteralInteger66);
								AddToElementRepository("LiteralUnlimitedNatural67", Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Start_testCase_LiteralUnlimitedNatural67);
								AddToElementRepository("LiteralInteger68", Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Start_testCase_LiteralInteger68);
							AddToElementRepository("Trigger69", Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Start_Trigger69);
						AddToElementRepository("ControlFlow70", Signal_Assembly_Tester_TesterClassifierBehavior_ControlFlow70);
						AddToElementRepository("Value(4)", Signal_Assembly_Tester_TesterClassifierBehavior_Value_4);
							AddToElementRepository("result", Signal_Assembly_Tester_TesterClassifierBehavior_Value_4_result);
								AddToElementRepository("LiteralInteger71", Signal_Assembly_Tester_TesterClassifierBehavior_Value_4_result_LiteralInteger71);
								AddToElementRepository("LiteralUnlimitedNatural72", Signal_Assembly_Tester_TesterClassifierBehavior_Value_4_result_LiteralUnlimitedNatural72);
							AddToElementRepository("LiteralInteger73", Signal_Assembly_Tester_TesterClassifierBehavior_Value_4_LiteralInteger73);
						AddToElementRepository("ControlFlow74", Signal_Assembly_Tester_TesterClassifierBehavior_ControlFlow74);
						AddToElementRepository("ObjectFlow75", Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow75);
							AddToElementRepository("LiteralBoolean76", Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow75_LiteralBoolean76);
							AddToElementRepository("LiteralInteger77", Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow75_LiteralInteger77);
						AddToElementRepository("ActivityFinalNode78", Signal_Assembly_Tester_TesterClassifierBehavior_ActivityFinalNode78);
						AddToElementRepository("Accept Continue", Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Continue);
							AddToElementRepository("Trigger79", Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Continue_Trigger79);
							AddToElementRepository("result", Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Continue_result);
								AddToElementRepository("LiteralUnlimitedNatural80", Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Continue_result_LiteralUnlimitedNatural80);
								AddToElementRepository("LiteralInteger81", Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Continue_result_LiteralInteger81);
								AddToElementRepository("LiteralInteger82", Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Continue_result_LiteralInteger82);
						AddToElementRepository("this", Signal_Assembly_Tester_TesterClassifierBehavior_this);
							AddToElementRepository("result", Signal_Assembly_Tester_TesterClassifierBehavior_this_result);
								AddToElementRepository("LiteralUnlimitedNatural83", Signal_Assembly_Tester_TesterClassifierBehavior_this_result_LiteralUnlimitedNatural83);
								AddToElementRepository("LiteralInteger84", Signal_Assembly_Tester_TesterClassifierBehavior_this_result_LiteralInteger84);
						AddToElementRepository("Send S", Signal_Assembly_Tester_TesterClassifierBehavior_Send_S);
							AddToElementRepository("value", Signal_Assembly_Tester_TesterClassifierBehavior_Send_S_value);
								AddToElementRepository("LiteralInteger85", Signal_Assembly_Tester_TesterClassifierBehavior_Send_S_value_LiteralInteger85);
								AddToElementRepository("LiteralInteger86", Signal_Assembly_Tester_TesterClassifierBehavior_Send_S_value_LiteralInteger86);
								AddToElementRepository("LiteralUnlimitedNatural87", Signal_Assembly_Tester_TesterClassifierBehavior_Send_S_value_LiteralUnlimitedNatural87);
							AddToElementRepository("target", Signal_Assembly_Tester_TesterClassifierBehavior_Send_S_target);
								AddToElementRepository("LiteralUnlimitedNatural88", Signal_Assembly_Tester_TesterClassifierBehavior_Send_S_target_LiteralUnlimitedNatural88);
								AddToElementRepository("LiteralInteger89", Signal_Assembly_Tester_TesterClassifierBehavior_Send_S_target_LiteralInteger89);
					AddToElementRepository("q", Signal_Assembly_Tester_q);
					AddToElementRepository("Tester_Tester", Signal_Assembly_Tester_Tester_Tester);
						AddToElementRepository("result", Signal_Assembly_Tester_Tester_Tester_result);
				AddToElementRepository("Continue", Signal_Assembly_Continue);
				AddToElementRepository("SEvent", Signal_Assembly_SEvent);
				AddToElementRepository("A", Signal_Assembly_A);
					AddToElementRepository("p", Signal_Assembly_A_p);
					AddToElementRepository("AClassifierBehavior", Signal_Assembly_A_AClassifierBehavior);
						AddToElementRepository("ObjectFlow90", Signal_Assembly_A_AClassifierBehavior_ObjectFlow90);
							AddToElementRepository("LiteralInteger91", Signal_Assembly_A_AClassifierBehavior_ObjectFlow90_LiteralInteger91);
							AddToElementRepository("LiteralBoolean92", Signal_Assembly_A_AClassifierBehavior_ObjectFlow90_LiteralBoolean92);
						AddToElementRepository("ActivityFinalNode93", Signal_Assembly_A_AClassifierBehavior_ActivityFinalNode93);
						AddToElementRepository("ObjectFlow94", Signal_Assembly_A_AClassifierBehavior_ObjectFlow94);
							AddToElementRepository("LiteralBoolean95", Signal_Assembly_A_AClassifierBehavior_ObjectFlow94_LiteralBoolean95);
							AddToElementRepository("LiteralInteger96", Signal_Assembly_A_AClassifierBehavior_ObjectFlow94_LiteralInteger96);
						AddToElementRepository("ObjectFlow97", Signal_Assembly_A_AClassifierBehavior_ObjectFlow97);
							AddToElementRepository("LiteralBoolean98", Signal_Assembly_A_AClassifierBehavior_ObjectFlow97_LiteralBoolean98);
							AddToElementRepository("LiteralInteger99", Signal_Assembly_A_AClassifierBehavior_ObjectFlow97_LiteralInteger99);
						AddToElementRepository("ControlFlow100", Signal_Assembly_A_AClassifierBehavior_ControlFlow100);
						AddToElementRepository("Set v", Signal_Assembly_A_AClassifierBehavior_Set_v);
							AddToElementRepository("result", Signal_Assembly_A_AClassifierBehavior_Set_v_result);
								AddToElementRepository("LiteralInteger101", Signal_Assembly_A_AClassifierBehavior_Set_v_result_LiteralInteger101);
								AddToElementRepository("LiteralUnlimitedNatural102", Signal_Assembly_A_AClassifierBehavior_Set_v_result_LiteralUnlimitedNatural102);
							AddToElementRepository("object", Signal_Assembly_A_AClassifierBehavior_Set_v_object);
								AddToElementRepository("LiteralInteger103", Signal_Assembly_A_AClassifierBehavior_Set_v_object_LiteralInteger103);
								AddToElementRepository("LiteralUnlimitedNatural104", Signal_Assembly_A_AClassifierBehavior_Set_v_object_LiteralUnlimitedNatural104);
							AddToElementRepository("value", Signal_Assembly_A_AClassifierBehavior_Set_v_value);
								AddToElementRepository("LiteralInteger105", Signal_Assembly_A_AClassifierBehavior_Set_v_value_LiteralInteger105);
								AddToElementRepository("LiteralUnlimitedNatural106", Signal_Assembly_A_AClassifierBehavior_Set_v_value_LiteralUnlimitedNatural106);
						AddToElementRepository("ControlFlow107", Signal_Assembly_A_AClassifierBehavior_ControlFlow107);
						AddToElementRepository("this", Signal_Assembly_A_AClassifierBehavior_this);
							AddToElementRepository("result", Signal_Assembly_A_AClassifierBehavior_this_result);
								AddToElementRepository("LiteralUnlimitedNatural108", Signal_Assembly_A_AClassifierBehavior_this_result_LiteralUnlimitedNatural108);
								AddToElementRepository("LiteralInteger109", Signal_Assembly_A_AClassifierBehavior_this_result_LiteralInteger109);
						AddToElementRepository("Accept S", Signal_Assembly_A_AClassifierBehavior_Accept_S);
							AddToElementRepository("Trigger110", Signal_Assembly_A_AClassifierBehavior_Accept_S_Trigger110);
							AddToElementRepository("value", Signal_Assembly_A_AClassifierBehavior_Accept_S_value);
								AddToElementRepository("LiteralInteger111", Signal_Assembly_A_AClassifierBehavior_Accept_S_value_LiteralInteger111);
								AddToElementRepository("LiteralUnlimitedNatural112", Signal_Assembly_A_AClassifierBehavior_Accept_S_value_LiteralUnlimitedNatural112);
								AddToElementRepository("LiteralInteger113", Signal_Assembly_A_AClassifierBehavior_Accept_S_value_LiteralInteger113);
						AddToElementRepository("Send Continue", Signal_Assembly_A_AClassifierBehavior_Send_Continue);
							AddToElementRepository("target", Signal_Assembly_A_AClassifierBehavior_Send_Continue_target);
								AddToElementRepository("LiteralUnlimitedNatural114", Signal_Assembly_A_AClassifierBehavior_Send_Continue_target_LiteralUnlimitedNatural114);
								AddToElementRepository("LiteralInteger115", Signal_Assembly_A_AClassifierBehavior_Send_Continue_target_LiteralInteger115);
					AddToElementRepository("v", Signal_Assembly_A_v);
					AddToElementRepository("A_A", Signal_Assembly_A_A_A);
						AddToElementRepository("result", Signal_Assembly_A_A_A_result);

			// Initialize public members
			/*
			 * Model Signal_Assembly
			 */
			Signal_Assembly.SetName("Signal_Assembly");
			Signal_Assembly.SetVisibility(VisibilityKind.public_);
				// SignalEvent StartEvent
				Signal_Assembly_StartEvent.SetName("StartEvent");
				Signal_Assembly_StartEvent.SetVisibility(VisibilityKind.public_);
				Signal_Assembly_StartEvent.SetSignal(Signal_Assembly_Start);
			Signal_Assembly.AddPackagedElement(Signal_Assembly_StartEvent);
				// Signal Start
				Signal_Assembly_Start.SetName("Start");
				Signal_Assembly_Start.SetVisibility(VisibilityKind.public_);
				
					// Property testCase
					Signal_Assembly_Start_testCase.SetName("testCase");
					Signal_Assembly_Start_testCase.SetVisibility(VisibilityKind.public_);
					
					Signal_Assembly_Start_testCase.SetType(Signal_Assembly_TestCase);
				Signal_Assembly_Start.AddOwnedAttribute(Signal_Assembly_Start_testCase);
			Signal_Assembly.AddPackagedElement(Signal_Assembly_Start);
				// Association R
				Signal_Assembly_R.SetName("R");
				Signal_Assembly_R.SetVisibility(VisibilityKind.public_);
				Signal_Assembly_R.AddOwnedEnd(Signal_Assembly_R_x);
				Signal_Assembly_R.AddOwnedEnd(Signal_Assembly_R_y);
			Signal_Assembly.AddPackagedElement(Signal_Assembly_R);
				// Class I
				Signal_Assembly_I.SetName("I");
				Signal_Assembly_I.SetVisibility(VisibilityKind.public_);
			Signal_Assembly.AddPackagedElement(Signal_Assembly_I);
				// SignalEvent ContinueEvent
				Signal_Assembly_ContinueEvent.SetName("ContinueEvent");
				Signal_Assembly_ContinueEvent.SetVisibility(VisibilityKind.public_);
				Signal_Assembly_ContinueEvent.SetSignal(Signal_Assembly_Continue);
			Signal_Assembly.AddPackagedElement(Signal_Assembly_ContinueEvent);
				// Class TestCaseAssembly
				Signal_Assembly_TestCaseAssembly.SetName("TestCaseAssembly");
				Signal_Assembly_TestCaseAssembly.SetVisibility(VisibilityKind.public_);
				
					// Generalization to TestCase
					Signal_Assembly_TestCaseAssembly_Generalization24.SetGeneral(Signal_Assembly_TestCase);
				Signal_Assembly_TestCaseAssembly.AddGeneralization(Signal_Assembly_TestCaseAssembly_Generalization24);
					// Property a
					Signal_Assembly_TestCaseAssembly_a.SetName("a");
					Signal_Assembly_TestCaseAssembly_a.SetVisibility(VisibilityKind.public_);
					
					Signal_Assembly_TestCaseAssembly_a.SetType(Signal_Assembly_A);
					Signal_Assembly_TestCaseAssembly_a.SetAggregation(AggregationKind.composite);
				Signal_Assembly_TestCaseAssembly.AddOwnedAttribute(Signal_Assembly_TestCaseAssembly_a);
					// Property tester
					Signal_Assembly_TestCaseAssembly_tester.SetName("tester");
					Signal_Assembly_TestCaseAssembly_tester.SetVisibility(VisibilityKind.public_);
					
					Signal_Assembly_TestCaseAssembly_tester.SetType(Signal_Assembly_Tester);
					Signal_Assembly_TestCaseAssembly_tester.SetAggregation(AggregationKind.composite);
				Signal_Assembly_TestCaseAssembly.AddOwnedAttribute(Signal_Assembly_TestCaseAssembly_tester);
				// Activity testActivity
					Signal_Assembly_TestCaseAssembly_testActivity.SetName("testActivity");
					Signal_Assembly_TestCaseAssembly_testActivity.SetVisibility(VisibilityKind.public_);
					// FunctionBehavior testV
						Signal_Assembly_TestCaseAssembly_testActivity_testV.SetName("testV");
						Signal_Assembly_TestCaseAssembly_testActivity_testV.SetVisibility(VisibilityKind.public_);
						
							// Parameter v
							Signal_Assembly_TestCaseAssembly_testActivity_testV_v.SetName("v");
							Signal_Assembly_TestCaseAssembly_testActivity_testV_v.SetVisibility(VisibilityKind.public_);
							
							Signal_Assembly_TestCaseAssembly_testActivity_testV_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						Signal_Assembly_TestCaseAssembly_testActivity_testV.AddOwnedParameter(Signal_Assembly_TestCaseAssembly_testActivity_testV_v);
						Signal_Assembly_TestCaseAssembly_testActivity_testV.AddLanguage("C#");
						Signal_Assembly_TestCaseAssembly_testActivity_testV.AddLanguage("Using");
						Signal_Assembly_TestCaseAssembly_testActivity_testV.AddBody("Console.WriteLine(\"Asserting a.v == 4\");  	// Test parameter v 	int v = ((IntegerValue)inputParameters.ElementAt(0).values.ElementAt(0)).value; 	Debug.Println(\"[doBody] argument v = \" + v); 	 	Console.WriteLine(\"a.v == \" + v); 	Console.Write(\"Signal correctly sent and received: \");  	if(v == 4) 	{ 		Console.ForegroundColor = ConsoleColor.Green; 		Console.WriteLine(\"Assertion successful.\"); 	} 	else 	{ 		Console.ForegroundColor = ConsoleColor.Red; 		Console.WriteLine(\"Assertion failed!\"); 	}  	Console.ResetColor();");
						Signal_Assembly_TestCaseAssembly_testActivity_testV.AddBody("using fuml.semantics.simpleclassifiers; ");
					Signal_Assembly_TestCaseAssembly_testActivity.AddOwnedBehavior(Signal_Assembly_TestCaseAssembly_testActivity_testV);
						// ReadStructuralFeatureAction Read this.a
						Signal_Assembly_TestCaseAssembly_testActivity_Read_this_a.SetName("Read this.a");
						Signal_Assembly_TestCaseAssembly_testActivity_Read_this_a.SetVisibility(VisibilityKind.public_);
						Signal_Assembly_TestCaseAssembly_testActivity_Read_this_a.SetStructuralFeature(Signal_Assembly_TestCaseAssembly_a);
							// InputPin object
							Signal_Assembly_TestCaseAssembly_testActivity_Read_this_a_object.SetName("object");
							Signal_Assembly_TestCaseAssembly_testActivity_Read_this_a_object.SetVisibility(VisibilityKind.public_);
							Signal_Assembly_TestCaseAssembly_testActivity_Read_this_a_object.SetType(Signal_Assembly_TestCaseAssembly);
						Signal_Assembly_TestCaseAssembly_testActivity_Read_this_a.SetObject(Signal_Assembly_TestCaseAssembly_testActivity_Read_this_a_object);
							// OutputPin result
							Signal_Assembly_TestCaseAssembly_testActivity_Read_this_a_result.SetName("result");
							Signal_Assembly_TestCaseAssembly_testActivity_Read_this_a_result.SetVisibility(VisibilityKind.public_);
							Signal_Assembly_TestCaseAssembly_testActivity_Read_this_a_result.SetType(Signal_Assembly_A);
						Signal_Assembly_TestCaseAssembly_testActivity_Read_this_a.SetResult(Signal_Assembly_TestCaseAssembly_testActivity_Read_this_a_result);
					Signal_Assembly_TestCaseAssembly_testActivity.AddNode(Signal_Assembly_TestCaseAssembly_testActivity_Read_this_a);
						// ReadStructuralFeatureAction Read a.v
						Signal_Assembly_TestCaseAssembly_testActivity_Read_a_v.SetName("Read a.v");
						Signal_Assembly_TestCaseAssembly_testActivity_Read_a_v.SetVisibility(VisibilityKind.public_);
						Signal_Assembly_TestCaseAssembly_testActivity_Read_a_v.SetStructuralFeature(Signal_Assembly_A_v);
							// InputPin object
							Signal_Assembly_TestCaseAssembly_testActivity_Read_a_v_object.SetName("object");
							Signal_Assembly_TestCaseAssembly_testActivity_Read_a_v_object.SetVisibility(VisibilityKind.public_);
							Signal_Assembly_TestCaseAssembly_testActivity_Read_a_v_object.SetType(Signal_Assembly_A);
						Signal_Assembly_TestCaseAssembly_testActivity_Read_a_v.SetObject(Signal_Assembly_TestCaseAssembly_testActivity_Read_a_v_object);
							// OutputPin result
							Signal_Assembly_TestCaseAssembly_testActivity_Read_a_v_result.SetName("result");
							Signal_Assembly_TestCaseAssembly_testActivity_Read_a_v_result.SetVisibility(VisibilityKind.public_);
							Signal_Assembly_TestCaseAssembly_testActivity_Read_a_v_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						Signal_Assembly_TestCaseAssembly_testActivity_Read_a_v.SetResult(Signal_Assembly_TestCaseAssembly_testActivity_Read_a_v_result);
					Signal_Assembly_TestCaseAssembly_testActivity.AddNode(Signal_Assembly_TestCaseAssembly_testActivity_Read_a_v);
						// ReadSelfAction this
						Signal_Assembly_TestCaseAssembly_testActivity_this.SetName("this");
						Signal_Assembly_TestCaseAssembly_testActivity_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							Signal_Assembly_TestCaseAssembly_testActivity_this_result.SetName("result");
							Signal_Assembly_TestCaseAssembly_testActivity_this_result.SetVisibility(VisibilityKind.public_);
							Signal_Assembly_TestCaseAssembly_testActivity_this_result.SetType(Signal_Assembly_TestCaseAssembly);
						Signal_Assembly_TestCaseAssembly_testActivity_this.SetResult(Signal_Assembly_TestCaseAssembly_testActivity_this_result);
					Signal_Assembly_TestCaseAssembly_testActivity.AddNode(Signal_Assembly_TestCaseAssembly_testActivity_this);
						// CallBehaviorAction Call testV
						Signal_Assembly_TestCaseAssembly_testActivity_Call_testV.SetName("Call testV");
						Signal_Assembly_TestCaseAssembly_testActivity_Call_testV.SetVisibility(VisibilityKind.public_);
						Signal_Assembly_TestCaseAssembly_testActivity_Call_testV.SetBehavior(Signal_Assembly_TestCaseAssembly_testActivity_testV);
							// InputPin v
							Signal_Assembly_TestCaseAssembly_testActivity_Call_testV_v.SetName("v");
							Signal_Assembly_TestCaseAssembly_testActivity_Call_testV_v.SetVisibility(VisibilityKind.public_);
							Signal_Assembly_TestCaseAssembly_testActivity_Call_testV_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						Signal_Assembly_TestCaseAssembly_testActivity_Call_testV.AddArgument(Signal_Assembly_TestCaseAssembly_testActivity_Call_testV_v);
					Signal_Assembly_TestCaseAssembly_testActivity.AddNode(Signal_Assembly_TestCaseAssembly_testActivity_Call_testV);
						// ObjectFlow ObjectFlow2 from result to v
						Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow2.SetName("ObjectFlow2");
						Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow2.SetVisibility(VisibilityKind.public_);
						
						Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow2.SetSource(Signal_Assembly_TestCaseAssembly_testActivity_Read_a_v_result);
						Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow2.SetTarget(Signal_Assembly_TestCaseAssembly_testActivity_Call_testV_v);
							// LiteralBoolean LiteralBoolean4
							Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow2_LiteralBoolean4.SetName("LiteralBoolean4");
							Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow2_LiteralBoolean4.SetVisibility(VisibilityKind.public_);
							Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow2_LiteralBoolean4.SetValue(true);
						Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow2.SetGuard(Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow2_LiteralBoolean4);
					Signal_Assembly_TestCaseAssembly_testActivity.AddEdge(Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow2);
						// ObjectFlow ObjectFlow5 from result to object
						Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow5.SetName("ObjectFlow5");
						Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow5.SetVisibility(VisibilityKind.public_);
						
						Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow5.SetSource(Signal_Assembly_TestCaseAssembly_testActivity_this_result);
						Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow5.SetTarget(Signal_Assembly_TestCaseAssembly_testActivity_Read_this_a_object);
							// LiteralBoolean LiteralBoolean7
							Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow5_LiteralBoolean7.SetName("LiteralBoolean7");
							Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow5_LiteralBoolean7.SetVisibility(VisibilityKind.public_);
							Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow5_LiteralBoolean7.SetValue(true);
						Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow5.SetGuard(Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow5_LiteralBoolean7);
					Signal_Assembly_TestCaseAssembly_testActivity.AddEdge(Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow5);
						// ObjectFlow ObjectFlow16 from result to object
						Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow16.SetName("ObjectFlow16");
						Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow16.SetVisibility(VisibilityKind.public_);
						
						Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow16.SetSource(Signal_Assembly_TestCaseAssembly_testActivity_Read_this_a_result);
						Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow16.SetTarget(Signal_Assembly_TestCaseAssembly_testActivity_Read_a_v_object);
							// LiteralBoolean LiteralBoolean18
							Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow16_LiteralBoolean18.SetName("LiteralBoolean18");
							Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow16_LiteralBoolean18.SetVisibility(VisibilityKind.public_);
							Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow16_LiteralBoolean18.SetValue(true);
						Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow16.SetGuard(Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow16_LiteralBoolean18);
					Signal_Assembly_TestCaseAssembly_testActivity.AddEdge(Signal_Assembly_TestCaseAssembly_testActivity_ObjectFlow16);
				Signal_Assembly_TestCaseAssembly.AddOwnedBehavior(Signal_Assembly_TestCaseAssembly_testActivity);
				Signal_Assembly_TestCaseAssembly_r.SetName("r");
					Signal_Assembly_TestCaseAssembly_r.SetVisibility(VisibilityKind.public_);
						
						Signal_Assembly_TestCaseAssembly_r_ConnectorEnd1.SetRole(Signal_Assembly_A_p);
						Signal_Assembly_TestCaseAssembly_r_ConnectorEnd1.SetPartWithPort(Signal_Assembly_TestCaseAssembly_a);
						
					Signal_Assembly_TestCaseAssembly_r.AddEnd(Signal_Assembly_TestCaseAssembly_r_ConnectorEnd1);
						
						Signal_Assembly_TestCaseAssembly_r_ConnectorEnd0.SetRole(Signal_Assembly_Tester_q);
						Signal_Assembly_TestCaseAssembly_r_ConnectorEnd0.SetPartWithPort(Signal_Assembly_TestCaseAssembly_tester);
						
					Signal_Assembly_TestCaseAssembly_r.AddEnd(Signal_Assembly_TestCaseAssembly_r_ConnectorEnd0);
					Signal_Assembly_TestCaseAssembly_r.SetType(Signal_Assembly_R);
				Signal_Assembly_TestCaseAssembly.AddOwnedConnector(Signal_Assembly_TestCaseAssembly_r);
					// Operation TestCaseAssembly_TestCaseAssembly
					Signal_Assembly_TestCaseAssembly_TestCaseAssembly_TestCaseAssembly.SetName("TestCaseAssembly_TestCaseAssembly");
					Signal_Assembly_TestCaseAssembly_TestCaseAssembly_TestCaseAssembly.SetVisibility(VisibilityKind.public_);
						// Parameter result
						Signal_Assembly_TestCaseAssembly_TestCaseAssembly_TestCaseAssembly_result.SetName("result");
						Signal_Assembly_TestCaseAssembly_TestCaseAssembly_TestCaseAssembly_result.SetVisibility(VisibilityKind.public_);
						
						Signal_Assembly_TestCaseAssembly_TestCaseAssembly_TestCaseAssembly_result.SetType(Signal_Assembly_TestCaseAssembly);
						Signal_Assembly_TestCaseAssembly_TestCaseAssembly_TestCaseAssembly_result.SetDirection(ParameterDirectionKind.return_);
					Signal_Assembly_TestCaseAssembly_TestCaseAssembly_TestCaseAssembly.AddOwnedParameter(Signal_Assembly_TestCaseAssembly_TestCaseAssembly_TestCaseAssembly_result);
					Signal_Assembly_TestCaseAssembly_TestCaseAssembly_TestCaseAssembly.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				Signal_Assembly_TestCaseAssembly.AddOwnedOperation(Signal_Assembly_TestCaseAssembly_TestCaseAssembly_TestCaseAssembly);
					// Operation test
					Signal_Assembly_TestCaseAssembly_test.SetName("test");
					Signal_Assembly_TestCaseAssembly_test.SetVisibility(VisibilityKind.public_);
					Signal_Assembly_TestCaseAssembly_test.AddMethod(Signal_Assembly_TestCaseAssembly_testActivity);
					Signal_Assembly_TestCaseAssembly_test.AddRedefinedOperation(Signal_Assembly_TestCase_test);
				Signal_Assembly_TestCaseAssembly.AddOwnedOperation(Signal_Assembly_TestCaseAssembly_test);
			Signal_Assembly.AddPackagedElement(Signal_Assembly_TestCaseAssembly);
				// Class TestCase
				Signal_Assembly_TestCase.SetName("TestCase");
				Signal_Assembly_TestCase.SetVisibility(VisibilityKind.public_);
				
				Signal_Assembly_TestCase.SetIsAbstract(true);
				
				
					// Operation test
					Signal_Assembly_TestCase_test.SetName("test");
					Signal_Assembly_TestCase_test.SetVisibility(VisibilityKind.public_);
					Signal_Assembly_TestCase_test.SetIsAbstract(true);
				Signal_Assembly_TestCase.AddOwnedOperation(Signal_Assembly_TestCase_test);
			Signal_Assembly.AddPackagedElement(Signal_Assembly_TestCase);
				// Signal S
				Signal_Assembly_S.SetName("S");
				Signal_Assembly_S.SetVisibility(VisibilityKind.public_);
				
					// Property value
					Signal_Assembly_S_value.SetName("value");
					Signal_Assembly_S_value.SetVisibility(VisibilityKind.public_);
					
					Signal_Assembly_S_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
				Signal_Assembly_S.AddOwnedAttribute(Signal_Assembly_S_value);
			Signal_Assembly.AddPackagedElement(Signal_Assembly_S);
				// Activity main
				Signal_Assembly_main.SetName("main");
				Signal_Assembly_main.SetVisibility(VisibilityKind.public_);
					// ReadStructuralFeatureAction Read TestCaseAssembly.tester
					Signal_Assembly_main_Read_TestCaseAssembly_tester.SetName("Read TestCaseAssembly.tester");
					Signal_Assembly_main_Read_TestCaseAssembly_tester.SetVisibility(VisibilityKind.public_);
					Signal_Assembly_main_Read_TestCaseAssembly_tester.SetStructuralFeature(Signal_Assembly_TestCaseAssembly_tester);
						// InputPin object
						Signal_Assembly_main_Read_TestCaseAssembly_tester_object.SetName("object");
						Signal_Assembly_main_Read_TestCaseAssembly_tester_object.SetVisibility(VisibilityKind.public_);
						Signal_Assembly_main_Read_TestCaseAssembly_tester_object.SetType(Signal_Assembly_TestCaseAssembly);
					Signal_Assembly_main_Read_TestCaseAssembly_tester.SetObject(Signal_Assembly_main_Read_TestCaseAssembly_tester_object);
						// OutputPin result
						Signal_Assembly_main_Read_TestCaseAssembly_tester_result.SetName("result");
						Signal_Assembly_main_Read_TestCaseAssembly_tester_result.SetVisibility(VisibilityKind.public_);
						Signal_Assembly_main_Read_TestCaseAssembly_tester_result.SetType(Signal_Assembly_Tester);
					Signal_Assembly_main_Read_TestCaseAssembly_tester.SetResult(Signal_Assembly_main_Read_TestCaseAssembly_tester_result);
				Signal_Assembly_main.AddNode(Signal_Assembly_main_Read_TestCaseAssembly_tester);
					// CreateObjectAction Create TestCaseAssembly
					Signal_Assembly_main_Create_TestCaseAssembly.SetName("Create TestCaseAssembly");
					Signal_Assembly_main_Create_TestCaseAssembly.SetVisibility(VisibilityKind.public_);
					Signal_Assembly_main_Create_TestCaseAssembly.SetClassifier(Signal_Assembly_TestCaseAssembly);
						// OutputPin result
						Signal_Assembly_main_Create_TestCaseAssembly_result.SetName("result");
						Signal_Assembly_main_Create_TestCaseAssembly_result.SetVisibility(VisibilityKind.public_);
						Signal_Assembly_main_Create_TestCaseAssembly_result.SetType(Signal_Assembly_TestCaseAssembly);
					Signal_Assembly_main_Create_TestCaseAssembly.SetResult(Signal_Assembly_main_Create_TestCaseAssembly_result);
				Signal_Assembly_main.AddNode(Signal_Assembly_main_Create_TestCaseAssembly);
					// CallOperationAction TestCaseAssembly()
					Signal_Assembly_main_TestCaseAssembly_.SetName("TestCaseAssembly()");
					Signal_Assembly_main_TestCaseAssembly_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						Signal_Assembly_main_TestCaseAssembly__result.SetName("result");
						Signal_Assembly_main_TestCaseAssembly__result.SetVisibility(VisibilityKind.public_);
						Signal_Assembly_main_TestCaseAssembly__result.SetType(Signal_Assembly_TestCaseAssembly);
					Signal_Assembly_main_TestCaseAssembly_.AddResult(Signal_Assembly_main_TestCaseAssembly__result);
					Signal_Assembly_main_TestCaseAssembly_.SetOperation(Signal_Assembly_TestCaseAssembly_TestCaseAssembly_TestCaseAssembly);
						// InputPin target
						Signal_Assembly_main_TestCaseAssembly__target.SetName("target");
						Signal_Assembly_main_TestCaseAssembly__target.SetVisibility(VisibilityKind.public_);
						Signal_Assembly_main_TestCaseAssembly__target.SetType(Signal_Assembly_TestCaseAssembly);
					Signal_Assembly_main_TestCaseAssembly_.SetTarget(Signal_Assembly_main_TestCaseAssembly__target);
				Signal_Assembly_main.AddNode(Signal_Assembly_main_TestCaseAssembly_);
					// ForkNode Fork testCase
					Signal_Assembly_main_Fork_testCase.SetName("Fork testCase");
					Signal_Assembly_main_Fork_testCase.SetVisibility(VisibilityKind.public_);
				Signal_Assembly_main.AddNode(Signal_Assembly_main_Fork_testCase);
					// SendSignalAction Send Start
					Signal_Assembly_main_Send_Start.SetName("Send Start");
					Signal_Assembly_main_Send_Start.SetVisibility(VisibilityKind.public_);
					Signal_Assembly_main_Send_Start.SetSignal(Signal_Assembly_Start);
						// InputPin target
						Signal_Assembly_main_Send_Start_target.SetName("target");
						Signal_Assembly_main_Send_Start_target.SetVisibility(VisibilityKind.public_);
						Signal_Assembly_main_Send_Start_target.SetType(Signal_Assembly_Tester);
					Signal_Assembly_main_Send_Start.SetTarget(Signal_Assembly_main_Send_Start_target);
						// InputPin testCase
						Signal_Assembly_main_Send_Start_testCase.SetName("testCase");
						Signal_Assembly_main_Send_Start_testCase.SetVisibility(VisibilityKind.public_);
						Signal_Assembly_main_Send_Start_testCase.SetType(Signal_Assembly_TestCase);
					Signal_Assembly_main_Send_Start.AddArgument(Signal_Assembly_main_Send_Start_testCase);
				Signal_Assembly_main.AddNode(Signal_Assembly_main_Send_Start);
					// ObjectFlow ObjectFlow25 from result to target
					Signal_Assembly_main_ObjectFlow25.SetName("ObjectFlow25");
					Signal_Assembly_main_ObjectFlow25.SetVisibility(VisibilityKind.public_);
					
					Signal_Assembly_main_ObjectFlow25.SetSource(Signal_Assembly_main_Read_TestCaseAssembly_tester_result);
					Signal_Assembly_main_ObjectFlow25.SetTarget(Signal_Assembly_main_Send_Start_target);
						// LiteralBoolean LiteralBoolean27
						Signal_Assembly_main_ObjectFlow25_LiteralBoolean27.SetName("LiteralBoolean27");
						Signal_Assembly_main_ObjectFlow25_LiteralBoolean27.SetVisibility(VisibilityKind.public_);
						Signal_Assembly_main_ObjectFlow25_LiteralBoolean27.SetValue(true);
					Signal_Assembly_main_ObjectFlow25.SetGuard(Signal_Assembly_main_ObjectFlow25_LiteralBoolean27);
				Signal_Assembly_main.AddEdge(Signal_Assembly_main_ObjectFlow25);
					// ObjectFlow ObjectFlow34 from result to target
					Signal_Assembly_main_ObjectFlow34.SetName("ObjectFlow34");
					Signal_Assembly_main_ObjectFlow34.SetVisibility(VisibilityKind.public_);
					
					Signal_Assembly_main_ObjectFlow34.SetSource(Signal_Assembly_main_Create_TestCaseAssembly_result);
					Signal_Assembly_main_ObjectFlow34.SetTarget(Signal_Assembly_main_TestCaseAssembly__target);
						// LiteralBoolean LiteralBoolean36
						Signal_Assembly_main_ObjectFlow34_LiteralBoolean36.SetName("LiteralBoolean36");
						Signal_Assembly_main_ObjectFlow34_LiteralBoolean36.SetVisibility(VisibilityKind.public_);
						Signal_Assembly_main_ObjectFlow34_LiteralBoolean36.SetValue(true);
					Signal_Assembly_main_ObjectFlow34.SetGuard(Signal_Assembly_main_ObjectFlow34_LiteralBoolean36);
				Signal_Assembly_main.AddEdge(Signal_Assembly_main_ObjectFlow34);
					// ObjectFlow ObjectFlow37 from Fork testCase to testCase
					Signal_Assembly_main_ObjectFlow37.SetName("ObjectFlow37");
					Signal_Assembly_main_ObjectFlow37.SetVisibility(VisibilityKind.public_);
					
					Signal_Assembly_main_ObjectFlow37.SetSource(Signal_Assembly_main_Fork_testCase);
					Signal_Assembly_main_ObjectFlow37.SetTarget(Signal_Assembly_main_Send_Start_testCase);
						// LiteralBoolean LiteralBoolean39
						Signal_Assembly_main_ObjectFlow37_LiteralBoolean39.SetName("LiteralBoolean39");
						Signal_Assembly_main_ObjectFlow37_LiteralBoolean39.SetVisibility(VisibilityKind.public_);
						Signal_Assembly_main_ObjectFlow37_LiteralBoolean39.SetValue(true);
					Signal_Assembly_main_ObjectFlow37.SetGuard(Signal_Assembly_main_ObjectFlow37_LiteralBoolean39);
				Signal_Assembly_main.AddEdge(Signal_Assembly_main_ObjectFlow37);
					// ObjectFlow ObjectFlow45 from Fork testCase to object
					Signal_Assembly_main_ObjectFlow45.SetName("ObjectFlow45");
					Signal_Assembly_main_ObjectFlow45.SetVisibility(VisibilityKind.public_);
					
					Signal_Assembly_main_ObjectFlow45.SetSource(Signal_Assembly_main_Fork_testCase);
					Signal_Assembly_main_ObjectFlow45.SetTarget(Signal_Assembly_main_Read_TestCaseAssembly_tester_object);
						// LiteralBoolean LiteralBoolean46
						Signal_Assembly_main_ObjectFlow45_LiteralBoolean46.SetName("LiteralBoolean46");
						Signal_Assembly_main_ObjectFlow45_LiteralBoolean46.SetVisibility(VisibilityKind.public_);
						Signal_Assembly_main_ObjectFlow45_LiteralBoolean46.SetValue(true);
					Signal_Assembly_main_ObjectFlow45.SetGuard(Signal_Assembly_main_ObjectFlow45_LiteralBoolean46);
				Signal_Assembly_main.AddEdge(Signal_Assembly_main_ObjectFlow45);
					// ObjectFlow ObjectFlow48 from result to Fork testCase
					Signal_Assembly_main_ObjectFlow48.SetName("ObjectFlow48");
					Signal_Assembly_main_ObjectFlow48.SetVisibility(VisibilityKind.public_);
					
					Signal_Assembly_main_ObjectFlow48.SetSource(Signal_Assembly_main_TestCaseAssembly__result);
					Signal_Assembly_main_ObjectFlow48.SetTarget(Signal_Assembly_main_Fork_testCase);
						// LiteralBoolean LiteralBoolean49
						Signal_Assembly_main_ObjectFlow48_LiteralBoolean49.SetName("LiteralBoolean49");
						Signal_Assembly_main_ObjectFlow48_LiteralBoolean49.SetVisibility(VisibilityKind.public_);
						Signal_Assembly_main_ObjectFlow48_LiteralBoolean49.SetValue(true);
					Signal_Assembly_main_ObjectFlow48.SetGuard(Signal_Assembly_main_ObjectFlow48_LiteralBoolean49);
				Signal_Assembly_main.AddEdge(Signal_Assembly_main_ObjectFlow48);
			Signal_Assembly.AddPackagedElement(Signal_Assembly_main);
				// Class Tester
				Signal_Assembly_Tester.SetName("Tester");
				Signal_Assembly_Tester.SetVisibility(VisibilityKind.public_);
				
					// Port q
					Signal_Assembly_Tester_q.SetName("q");
					Signal_Assembly_Tester_q.SetVisibility(VisibilityKind.public_);
					
					Signal_Assembly_Tester_q.SetType(Signal_Assembly_I);
					Signal_Assembly_Tester_q.SetAggregation(AggregationKind.composite);
					Signal_Assembly_Tester_q.isBehavior = true;
					Signal_Assembly_Tester_q.isService = true;
				Signal_Assembly_Tester.AddOwnedAttribute(Signal_Assembly_Tester_q);
				Signal_Assembly_Tester.SetClassifierBehavior(Signal_Assembly_Tester_TesterClassifierBehavior);
					// Activity TesterClassifierBehavior
					Signal_Assembly_Tester_TesterClassifierBehavior.SetName("TesterClassifierBehavior");
					Signal_Assembly_Tester_TesterClassifierBehavior.SetVisibility(VisibilityKind.public_);
					
					Signal_Assembly_Tester_TesterClassifierBehavior.isReentrant = false;
						// CallOperationAction Call test()
						Signal_Assembly_Tester_TesterClassifierBehavior_Call_test_.SetName("Call test()");
						Signal_Assembly_Tester_TesterClassifierBehavior_Call_test_.SetVisibility(VisibilityKind.public_);
						Signal_Assembly_Tester_TesterClassifierBehavior_Call_test_.SetOperation(Signal_Assembly_TestCase_test);
							// InputPin target
							Signal_Assembly_Tester_TesterClassifierBehavior_Call_test__target.SetName("target");
							Signal_Assembly_Tester_TesterClassifierBehavior_Call_test__target.SetVisibility(VisibilityKind.public_);
							Signal_Assembly_Tester_TesterClassifierBehavior_Call_test__target.SetType(Signal_Assembly_TestCase);
						Signal_Assembly_Tester_TesterClassifierBehavior_Call_test_.SetTarget(Signal_Assembly_Tester_TesterClassifierBehavior_Call_test__target);
					Signal_Assembly_Tester_TesterClassifierBehavior.AddNode(Signal_Assembly_Tester_TesterClassifierBehavior_Call_test_);
						// AcceptEventAction Accept Start
						Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Start.SetName("Accept Start");
						Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Start.SetVisibility(VisibilityKind.public_);
						Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Start.SetIsUnmarshall(true);
							// OutputPin testCase
							Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Start_testCase.SetName("testCase");
							Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Start_testCase.SetVisibility(VisibilityKind.public_);
							Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Start_testCase.SetType(Signal_Assembly_TestCase);
						Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Start.AddResult(Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Start_testCase);
							// Trigger Trigger69
							Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Start_Trigger69.SetName("Trigger69");
							Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Start_Trigger69.SetVisibility(VisibilityKind.public_);
							Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Start_Trigger69.SetEvent(Signal_Assembly_StartEvent);
						Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Start.AddTrigger(Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Start_Trigger69);
					Signal_Assembly_Tester_TesterClassifierBehavior.AddNode(Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Start);
						// ActivityFinalNode ActivityFinalNode78
						Signal_Assembly_Tester_TesterClassifierBehavior_ActivityFinalNode78.SetName("ActivityFinalNode78");
						Signal_Assembly_Tester_TesterClassifierBehavior_ActivityFinalNode78.SetVisibility(VisibilityKind.public_);
					Signal_Assembly_Tester_TesterClassifierBehavior.AddNode(Signal_Assembly_Tester_TesterClassifierBehavior_ActivityFinalNode78);
						// ValueSpecificationAction Value(4)
						Signal_Assembly_Tester_TesterClassifierBehavior_Value_4.SetName("Value(4)");
						Signal_Assembly_Tester_TesterClassifierBehavior_Value_4.SetVisibility(VisibilityKind.public_);
							// LiteralInteger LiteralInteger73
							Signal_Assembly_Tester_TesterClassifierBehavior_Value_4_LiteralInteger73.SetName("LiteralInteger73");
							Signal_Assembly_Tester_TesterClassifierBehavior_Value_4_LiteralInteger73.SetVisibility(VisibilityKind.public_);
							Signal_Assembly_Tester_TesterClassifierBehavior_Value_4_LiteralInteger73.SetValue(4);
						Signal_Assembly_Tester_TesterClassifierBehavior_Value_4.SetValue(Signal_Assembly_Tester_TesterClassifierBehavior_Value_4_LiteralInteger73);
							// OutputPin result
							Signal_Assembly_Tester_TesterClassifierBehavior_Value_4_result.SetName("result");
							Signal_Assembly_Tester_TesterClassifierBehavior_Value_4_result.SetVisibility(VisibilityKind.public_);
							Signal_Assembly_Tester_TesterClassifierBehavior_Value_4_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						Signal_Assembly_Tester_TesterClassifierBehavior_Value_4.SetResult(Signal_Assembly_Tester_TesterClassifierBehavior_Value_4_result);
					Signal_Assembly_Tester_TesterClassifierBehavior.AddNode(Signal_Assembly_Tester_TesterClassifierBehavior_Value_4);
						// AcceptEventAction Accept Continue
						Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Continue.SetName("Accept Continue");
						Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Continue.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Continue_result.SetName("result");
							Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Continue_result.SetVisibility(VisibilityKind.public_);
							Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Continue_result.SetType(Signal_Assembly_Continue);
						Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Continue.AddResult(Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Continue_result);
							// Trigger Trigger79
							Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Continue_Trigger79.SetName("Trigger79");
							Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Continue_Trigger79.SetVisibility(VisibilityKind.public_);
							Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Continue_Trigger79.SetEvent(Signal_Assembly_ContinueEvent);
						Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Continue.AddTrigger(Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Continue_Trigger79);
					Signal_Assembly_Tester_TesterClassifierBehavior.AddNode(Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Continue);
						// ReadSelfAction this
						Signal_Assembly_Tester_TesterClassifierBehavior_this.SetName("this");
						Signal_Assembly_Tester_TesterClassifierBehavior_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							Signal_Assembly_Tester_TesterClassifierBehavior_this_result.SetName("result");
							Signal_Assembly_Tester_TesterClassifierBehavior_this_result.SetVisibility(VisibilityKind.public_);
							Signal_Assembly_Tester_TesterClassifierBehavior_this_result.SetType(Signal_Assembly_Tester);
						Signal_Assembly_Tester_TesterClassifierBehavior_this.SetResult(Signal_Assembly_Tester_TesterClassifierBehavior_this_result);
					Signal_Assembly_Tester_TesterClassifierBehavior.AddNode(Signal_Assembly_Tester_TesterClassifierBehavior_this);
						// SendSignalAction Send S
						Signal_Assembly_Tester_TesterClassifierBehavior_Send_S.SetName("Send S");
						Signal_Assembly_Tester_TesterClassifierBehavior_Send_S.SetVisibility(VisibilityKind.public_);
						Signal_Assembly_Tester_TesterClassifierBehavior_Send_S.SetSignal(Signal_Assembly_S);
							// InputPin target
							Signal_Assembly_Tester_TesterClassifierBehavior_Send_S_target.SetName("target");
							Signal_Assembly_Tester_TesterClassifierBehavior_Send_S_target.SetVisibility(VisibilityKind.public_);
							Signal_Assembly_Tester_TesterClassifierBehavior_Send_S_target.SetType(Signal_Assembly_Tester);
						Signal_Assembly_Tester_TesterClassifierBehavior_Send_S.SetTarget(Signal_Assembly_Tester_TesterClassifierBehavior_Send_S_target);
							// InputPin value
							Signal_Assembly_Tester_TesterClassifierBehavior_Send_S_value.SetName("value");
							Signal_Assembly_Tester_TesterClassifierBehavior_Send_S_value.SetVisibility(VisibilityKind.public_);
							Signal_Assembly_Tester_TesterClassifierBehavior_Send_S_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						Signal_Assembly_Tester_TesterClassifierBehavior_Send_S.AddArgument(Signal_Assembly_Tester_TesterClassifierBehavior_Send_S_value);
						Signal_Assembly_Tester_TesterClassifierBehavior_Send_S.SetOnPort(Signal_Assembly_Tester_q);
					Signal_Assembly_Tester_TesterClassifierBehavior.AddNode(Signal_Assembly_Tester_TesterClassifierBehavior_Send_S);
						// ObjectFlow ObjectFlow56 from testCase to target
						Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow56.SetName("ObjectFlow56");
						Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow56.SetVisibility(VisibilityKind.public_);
						
						Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow56.SetSource(Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Start_testCase);
						Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow56.SetTarget(Signal_Assembly_Tester_TesterClassifierBehavior_Call_test__target);
							// LiteralBoolean LiteralBoolean58
							Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow56_LiteralBoolean58.SetName("LiteralBoolean58");
							Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow56_LiteralBoolean58.SetVisibility(VisibilityKind.public_);
							Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow56_LiteralBoolean58.SetValue(true);
						Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow56.SetGuard(Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow56_LiteralBoolean58);
					Signal_Assembly_Tester_TesterClassifierBehavior.AddEdge(Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow56);
						// ControlFlow ControlFlow74 from Call test() to ActivityFinalNode78
						Signal_Assembly_Tester_TesterClassifierBehavior_ControlFlow74.SetName("ControlFlow74");
						Signal_Assembly_Tester_TesterClassifierBehavior_ControlFlow74.SetVisibility(VisibilityKind.public_);
						
						Signal_Assembly_Tester_TesterClassifierBehavior_ControlFlow74.SetSource(Signal_Assembly_Tester_TesterClassifierBehavior_Call_test_);
						Signal_Assembly_Tester_TesterClassifierBehavior_ControlFlow74.SetTarget(Signal_Assembly_Tester_TesterClassifierBehavior_ActivityFinalNode78);
					Signal_Assembly_Tester_TesterClassifierBehavior.AddEdge(Signal_Assembly_Tester_TesterClassifierBehavior_ControlFlow74);
						// ControlFlow ControlFlow59 from Accept Continue to Call test()
						Signal_Assembly_Tester_TesterClassifierBehavior_ControlFlow59.SetName("ControlFlow59");
						Signal_Assembly_Tester_TesterClassifierBehavior_ControlFlow59.SetVisibility(VisibilityKind.public_);
						
						Signal_Assembly_Tester_TesterClassifierBehavior_ControlFlow59.SetSource(Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Continue);
						Signal_Assembly_Tester_TesterClassifierBehavior_ControlFlow59.SetTarget(Signal_Assembly_Tester_TesterClassifierBehavior_Call_test_);
					Signal_Assembly_Tester_TesterClassifierBehavior.AddEdge(Signal_Assembly_Tester_TesterClassifierBehavior_ControlFlow59);
						// ObjectFlow ObjectFlow60 from result to value
						Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow60.SetName("ObjectFlow60");
						Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow60.SetVisibility(VisibilityKind.public_);
						
						Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow60.SetSource(Signal_Assembly_Tester_TesterClassifierBehavior_Value_4_result);
						Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow60.SetTarget(Signal_Assembly_Tester_TesterClassifierBehavior_Send_S_value);
							// LiteralBoolean LiteralBoolean61
							Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow60_LiteralBoolean61.SetName("LiteralBoolean61");
							Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow60_LiteralBoolean61.SetVisibility(VisibilityKind.public_);
							Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow60_LiteralBoolean61.SetValue(true);
						Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow60.SetGuard(Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow60_LiteralBoolean61);
					Signal_Assembly_Tester_TesterClassifierBehavior.AddEdge(Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow60);
						// ControlFlow ControlFlow63 from Accept Start to this
						Signal_Assembly_Tester_TesterClassifierBehavior_ControlFlow63.SetName("ControlFlow63");
						Signal_Assembly_Tester_TesterClassifierBehavior_ControlFlow63.SetVisibility(VisibilityKind.public_);
						
						Signal_Assembly_Tester_TesterClassifierBehavior_ControlFlow63.SetSource(Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Start);
						Signal_Assembly_Tester_TesterClassifierBehavior_ControlFlow63.SetTarget(Signal_Assembly_Tester_TesterClassifierBehavior_this);
					Signal_Assembly_Tester_TesterClassifierBehavior.AddEdge(Signal_Assembly_Tester_TesterClassifierBehavior_ControlFlow63);
						// ObjectFlow ObjectFlow75 from result to target
						Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow75.SetName("ObjectFlow75");
						Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow75.SetVisibility(VisibilityKind.public_);
						
						Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow75.SetSource(Signal_Assembly_Tester_TesterClassifierBehavior_this_result);
						Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow75.SetTarget(Signal_Assembly_Tester_TesterClassifierBehavior_Send_S_target);
							// LiteralBoolean LiteralBoolean76
							Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow75_LiteralBoolean76.SetName("LiteralBoolean76");
							Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow75_LiteralBoolean76.SetVisibility(VisibilityKind.public_);
							Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow75_LiteralBoolean76.SetValue(true);
						Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow75.SetGuard(Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow75_LiteralBoolean76);
					Signal_Assembly_Tester_TesterClassifierBehavior.AddEdge(Signal_Assembly_Tester_TesterClassifierBehavior_ObjectFlow75);
						// ControlFlow ControlFlow70 from Send S to Accept Continue
						Signal_Assembly_Tester_TesterClassifierBehavior_ControlFlow70.SetName("ControlFlow70");
						Signal_Assembly_Tester_TesterClassifierBehavior_ControlFlow70.SetVisibility(VisibilityKind.public_);
						
						Signal_Assembly_Tester_TesterClassifierBehavior_ControlFlow70.SetSource(Signal_Assembly_Tester_TesterClassifierBehavior_Send_S);
						Signal_Assembly_Tester_TesterClassifierBehavior_ControlFlow70.SetTarget(Signal_Assembly_Tester_TesterClassifierBehavior_Accept_Continue);
					Signal_Assembly_Tester_TesterClassifierBehavior.AddEdge(Signal_Assembly_Tester_TesterClassifierBehavior_ControlFlow70);
				Signal_Assembly_Tester.AddOwnedBehavior(Signal_Assembly_Tester_TesterClassifierBehavior);
				
				Signal_Assembly_Tester.SetIsActive(true);
					// Operation Tester_Tester
					Signal_Assembly_Tester_Tester_Tester.SetName("Tester_Tester");
					Signal_Assembly_Tester_Tester_Tester.SetVisibility(VisibilityKind.public_);
						// Parameter result
						Signal_Assembly_Tester_Tester_Tester_result.SetName("result");
						Signal_Assembly_Tester_Tester_Tester_result.SetVisibility(VisibilityKind.public_);
						
						Signal_Assembly_Tester_Tester_Tester_result.SetType(Signal_Assembly_Tester);
						Signal_Assembly_Tester_Tester_Tester_result.SetDirection(ParameterDirectionKind.return_);
					Signal_Assembly_Tester_Tester_Tester.AddOwnedParameter(Signal_Assembly_Tester_Tester_Tester_result);
					Signal_Assembly_Tester_Tester_Tester.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				Signal_Assembly_Tester.AddOwnedOperation(Signal_Assembly_Tester_Tester_Tester);
					// Reception Start
					Signal_Assembly_Tester_Start.SetName("Start");
					Signal_Assembly_Tester_Start.SetVisibility(VisibilityKind.public_);
					Signal_Assembly_Tester_Start.SetSignal(Signal_Assembly_Start);
				Signal_Assembly_Tester.AddOwnedReception(Signal_Assembly_Tester_Start);
			Signal_Assembly.AddPackagedElement(Signal_Assembly_Tester);
				// Signal Continue
				Signal_Assembly_Continue.SetName("Continue");
				Signal_Assembly_Continue.SetVisibility(VisibilityKind.public_);
			Signal_Assembly.AddPackagedElement(Signal_Assembly_Continue);
				// SignalEvent SEvent
				Signal_Assembly_SEvent.SetName("SEvent");
				Signal_Assembly_SEvent.SetVisibility(VisibilityKind.public_);
				Signal_Assembly_SEvent.SetSignal(Signal_Assembly_S);
			Signal_Assembly.AddPackagedElement(Signal_Assembly_SEvent);
				// Class A
				Signal_Assembly_A.SetName("A");
				Signal_Assembly_A.SetVisibility(VisibilityKind.public_);
				
					// Property v
					Signal_Assembly_A_v.SetName("v");
					Signal_Assembly_A_v.SetVisibility(VisibilityKind.public_);
					
					Signal_Assembly_A_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Signal_Assembly_A_v.SetAggregation(AggregationKind.shared);
				Signal_Assembly_A.AddOwnedAttribute(Signal_Assembly_A_v);
					// Port p
					Signal_Assembly_A_p.SetName("p");
					Signal_Assembly_A_p.SetVisibility(VisibilityKind.public_);
					
					Signal_Assembly_A_p.SetType(Signal_Assembly_I);
					Signal_Assembly_A_p.SetAggregation(AggregationKind.composite);
					Signal_Assembly_A_p.isBehavior = true;
					Signal_Assembly_A_p.isService = true;
				Signal_Assembly_A.AddOwnedAttribute(Signal_Assembly_A_p);
				Signal_Assembly_A.SetClassifierBehavior(Signal_Assembly_A_AClassifierBehavior);
					// Activity AClassifierBehavior
					Signal_Assembly_A_AClassifierBehavior.SetName("AClassifierBehavior");
					Signal_Assembly_A_AClassifierBehavior.SetVisibility(VisibilityKind.public_);
					
					Signal_Assembly_A_AClassifierBehavior.isReentrant = false;
						// ActivityFinalNode ActivityFinalNode93
						Signal_Assembly_A_AClassifierBehavior_ActivityFinalNode93.SetName("ActivityFinalNode93");
						Signal_Assembly_A_AClassifierBehavior_ActivityFinalNode93.SetVisibility(VisibilityKind.public_);
					Signal_Assembly_A_AClassifierBehavior.AddNode(Signal_Assembly_A_AClassifierBehavior_ActivityFinalNode93);
						// AddStructuralFeatureValueAction Set v
						Signal_Assembly_A_AClassifierBehavior_Set_v.SetName("Set v");
						Signal_Assembly_A_AClassifierBehavior_Set_v.SetVisibility(VisibilityKind.public_);
						Signal_Assembly_A_AClassifierBehavior_Set_v.SetStructuralFeature(Signal_Assembly_A_v);
							// InputPin object
							Signal_Assembly_A_AClassifierBehavior_Set_v_object.SetName("object");
							Signal_Assembly_A_AClassifierBehavior_Set_v_object.SetVisibility(VisibilityKind.public_);
							Signal_Assembly_A_AClassifierBehavior_Set_v_object.SetType(Signal_Assembly_A);
						Signal_Assembly_A_AClassifierBehavior_Set_v.SetObject(Signal_Assembly_A_AClassifierBehavior_Set_v_object);
							// InputPin value
							Signal_Assembly_A_AClassifierBehavior_Set_v_value.SetName("value");
							Signal_Assembly_A_AClassifierBehavior_Set_v_value.SetVisibility(VisibilityKind.public_);
							Signal_Assembly_A_AClassifierBehavior_Set_v_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						Signal_Assembly_A_AClassifierBehavior_Set_v.SetValue(Signal_Assembly_A_AClassifierBehavior_Set_v_value);
							// OutputPin result
							Signal_Assembly_A_AClassifierBehavior_Set_v_result.SetName("result");
							Signal_Assembly_A_AClassifierBehavior_Set_v_result.SetVisibility(VisibilityKind.public_);
							Signal_Assembly_A_AClassifierBehavior_Set_v_result.SetType(Signal_Assembly_A);
						Signal_Assembly_A_AClassifierBehavior_Set_v.SetResult(Signal_Assembly_A_AClassifierBehavior_Set_v_result);
					Signal_Assembly_A_AClassifierBehavior.AddNode(Signal_Assembly_A_AClassifierBehavior_Set_v);
						// ReadSelfAction this
						Signal_Assembly_A_AClassifierBehavior_this.SetName("this");
						Signal_Assembly_A_AClassifierBehavior_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							Signal_Assembly_A_AClassifierBehavior_this_result.SetName("result");
							Signal_Assembly_A_AClassifierBehavior_this_result.SetVisibility(VisibilityKind.public_);
							Signal_Assembly_A_AClassifierBehavior_this_result.SetType(Signal_Assembly_A);
						Signal_Assembly_A_AClassifierBehavior_this.SetResult(Signal_Assembly_A_AClassifierBehavior_this_result);
					Signal_Assembly_A_AClassifierBehavior.AddNode(Signal_Assembly_A_AClassifierBehavior_this);
						// AcceptEventAction Accept S
						Signal_Assembly_A_AClassifierBehavior_Accept_S.SetName("Accept S");
						Signal_Assembly_A_AClassifierBehavior_Accept_S.SetVisibility(VisibilityKind.public_);
						Signal_Assembly_A_AClassifierBehavior_Accept_S.SetIsUnmarshall(true);
							// OutputPin value
							Signal_Assembly_A_AClassifierBehavior_Accept_S_value.SetName("value");
							Signal_Assembly_A_AClassifierBehavior_Accept_S_value.SetVisibility(VisibilityKind.public_);
							Signal_Assembly_A_AClassifierBehavior_Accept_S_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						Signal_Assembly_A_AClassifierBehavior_Accept_S.AddResult(Signal_Assembly_A_AClassifierBehavior_Accept_S_value);
							// Trigger Trigger110
							Signal_Assembly_A_AClassifierBehavior_Accept_S_Trigger110.SetName("Trigger110");
							Signal_Assembly_A_AClassifierBehavior_Accept_S_Trigger110.SetVisibility(VisibilityKind.public_);
							Signal_Assembly_A_AClassifierBehavior_Accept_S_Trigger110.SetEvent(Signal_Assembly_SEvent);
						Signal_Assembly_A_AClassifierBehavior_Accept_S.AddTrigger(Signal_Assembly_A_AClassifierBehavior_Accept_S_Trigger110);
					Signal_Assembly_A_AClassifierBehavior.AddNode(Signal_Assembly_A_AClassifierBehavior_Accept_S);
						// SendSignalAction Send Continue
						Signal_Assembly_A_AClassifierBehavior_Send_Continue.SetName("Send Continue");
						Signal_Assembly_A_AClassifierBehavior_Send_Continue.SetVisibility(VisibilityKind.public_);
						Signal_Assembly_A_AClassifierBehavior_Send_Continue.SetSignal(Signal_Assembly_Continue);
							// InputPin target
							Signal_Assembly_A_AClassifierBehavior_Send_Continue_target.SetName("target");
							Signal_Assembly_A_AClassifierBehavior_Send_Continue_target.SetVisibility(VisibilityKind.public_);
							Signal_Assembly_A_AClassifierBehavior_Send_Continue_target.SetType(Signal_Assembly_A);
						Signal_Assembly_A_AClassifierBehavior_Send_Continue.SetTarget(Signal_Assembly_A_AClassifierBehavior_Send_Continue_target);
						Signal_Assembly_A_AClassifierBehavior_Send_Continue.SetOnPort(Signal_Assembly_A_p);
					Signal_Assembly_A_AClassifierBehavior.AddNode(Signal_Assembly_A_AClassifierBehavior_Send_Continue);
						// ObjectFlow ObjectFlow90 from result to target
						Signal_Assembly_A_AClassifierBehavior_ObjectFlow90.SetName("ObjectFlow90");
						Signal_Assembly_A_AClassifierBehavior_ObjectFlow90.SetVisibility(VisibilityKind.public_);
						
						Signal_Assembly_A_AClassifierBehavior_ObjectFlow90.SetSource(Signal_Assembly_A_AClassifierBehavior_Set_v_result);
						Signal_Assembly_A_AClassifierBehavior_ObjectFlow90.SetTarget(Signal_Assembly_A_AClassifierBehavior_Send_Continue_target);
							// LiteralBoolean LiteralBoolean92
							Signal_Assembly_A_AClassifierBehavior_ObjectFlow90_LiteralBoolean92.SetName("LiteralBoolean92");
							Signal_Assembly_A_AClassifierBehavior_ObjectFlow90_LiteralBoolean92.SetVisibility(VisibilityKind.public_);
							Signal_Assembly_A_AClassifierBehavior_ObjectFlow90_LiteralBoolean92.SetValue(true);
						Signal_Assembly_A_AClassifierBehavior_ObjectFlow90.SetGuard(Signal_Assembly_A_AClassifierBehavior_ObjectFlow90_LiteralBoolean92);
					Signal_Assembly_A_AClassifierBehavior.AddEdge(Signal_Assembly_A_AClassifierBehavior_ObjectFlow90);
						// ObjectFlow ObjectFlow94 from result to object
						Signal_Assembly_A_AClassifierBehavior_ObjectFlow94.SetName("ObjectFlow94");
						Signal_Assembly_A_AClassifierBehavior_ObjectFlow94.SetVisibility(VisibilityKind.public_);
						
						Signal_Assembly_A_AClassifierBehavior_ObjectFlow94.SetSource(Signal_Assembly_A_AClassifierBehavior_this_result);
						Signal_Assembly_A_AClassifierBehavior_ObjectFlow94.SetTarget(Signal_Assembly_A_AClassifierBehavior_Set_v_object);
							// LiteralBoolean LiteralBoolean95
							Signal_Assembly_A_AClassifierBehavior_ObjectFlow94_LiteralBoolean95.SetName("LiteralBoolean95");
							Signal_Assembly_A_AClassifierBehavior_ObjectFlow94_LiteralBoolean95.SetVisibility(VisibilityKind.public_);
							Signal_Assembly_A_AClassifierBehavior_ObjectFlow94_LiteralBoolean95.SetValue(true);
						Signal_Assembly_A_AClassifierBehavior_ObjectFlow94.SetGuard(Signal_Assembly_A_AClassifierBehavior_ObjectFlow94_LiteralBoolean95);
					Signal_Assembly_A_AClassifierBehavior.AddEdge(Signal_Assembly_A_AClassifierBehavior_ObjectFlow94);
						// ObjectFlow ObjectFlow97 from value to value
						Signal_Assembly_A_AClassifierBehavior_ObjectFlow97.SetName("ObjectFlow97");
						Signal_Assembly_A_AClassifierBehavior_ObjectFlow97.SetVisibility(VisibilityKind.public_);
						
						Signal_Assembly_A_AClassifierBehavior_ObjectFlow97.SetSource(Signal_Assembly_A_AClassifierBehavior_Accept_S_value);
						Signal_Assembly_A_AClassifierBehavior_ObjectFlow97.SetTarget(Signal_Assembly_A_AClassifierBehavior_Set_v_value);
							// LiteralBoolean LiteralBoolean98
							Signal_Assembly_A_AClassifierBehavior_ObjectFlow97_LiteralBoolean98.SetName("LiteralBoolean98");
							Signal_Assembly_A_AClassifierBehavior_ObjectFlow97_LiteralBoolean98.SetVisibility(VisibilityKind.public_);
							Signal_Assembly_A_AClassifierBehavior_ObjectFlow97_LiteralBoolean98.SetValue(true);
						Signal_Assembly_A_AClassifierBehavior_ObjectFlow97.SetGuard(Signal_Assembly_A_AClassifierBehavior_ObjectFlow97_LiteralBoolean98);
					Signal_Assembly_A_AClassifierBehavior.AddEdge(Signal_Assembly_A_AClassifierBehavior_ObjectFlow97);
						// ControlFlow ControlFlow100 from Accept S to this
						Signal_Assembly_A_AClassifierBehavior_ControlFlow100.SetName("ControlFlow100");
						Signal_Assembly_A_AClassifierBehavior_ControlFlow100.SetVisibility(VisibilityKind.public_);
						
						Signal_Assembly_A_AClassifierBehavior_ControlFlow100.SetSource(Signal_Assembly_A_AClassifierBehavior_Accept_S);
						Signal_Assembly_A_AClassifierBehavior_ControlFlow100.SetTarget(Signal_Assembly_A_AClassifierBehavior_this);
					Signal_Assembly_A_AClassifierBehavior.AddEdge(Signal_Assembly_A_AClassifierBehavior_ControlFlow100);
						// ControlFlow ControlFlow107 from Send Continue to ActivityFinalNode93
						Signal_Assembly_A_AClassifierBehavior_ControlFlow107.SetName("ControlFlow107");
						Signal_Assembly_A_AClassifierBehavior_ControlFlow107.SetVisibility(VisibilityKind.public_);
						
						Signal_Assembly_A_AClassifierBehavior_ControlFlow107.SetSource(Signal_Assembly_A_AClassifierBehavior_Send_Continue);
						Signal_Assembly_A_AClassifierBehavior_ControlFlow107.SetTarget(Signal_Assembly_A_AClassifierBehavior_ActivityFinalNode93);
					Signal_Assembly_A_AClassifierBehavior.AddEdge(Signal_Assembly_A_AClassifierBehavior_ControlFlow107);
				Signal_Assembly_A.AddOwnedBehavior(Signal_Assembly_A_AClassifierBehavior);
				
				Signal_Assembly_A.SetIsActive(true);
					// Operation A_A
					Signal_Assembly_A_A_A.SetName("A_A");
					Signal_Assembly_A_A_A.SetVisibility(VisibilityKind.public_);
						// Parameter result
						Signal_Assembly_A_A_A_result.SetName("result");
						Signal_Assembly_A_A_A_result.SetVisibility(VisibilityKind.public_);
						
						Signal_Assembly_A_A_A_result.SetType(Signal_Assembly_A);
						Signal_Assembly_A_A_A_result.SetDirection(ParameterDirectionKind.return_);
					Signal_Assembly_A_A_A.AddOwnedParameter(Signal_Assembly_A_A_A_result);
					Signal_Assembly_A_A_A.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				Signal_Assembly_A.AddOwnedOperation(Signal_Assembly_A_A_A);
			Signal_Assembly.AddPackagedElement(Signal_Assembly_A);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // Signal_AssemblyModel
}
