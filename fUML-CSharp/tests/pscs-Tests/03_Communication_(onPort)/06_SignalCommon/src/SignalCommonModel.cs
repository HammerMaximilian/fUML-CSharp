/*
 * SignalCommonModel.cs
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

namespace SignalCommon
{
	public class SignalCommonModel : InMemoryModel
	{
		private static SignalCommonModel? instance;

		/*
		 * Model SignalCommon
		 */
		public Package SignalCommon = new();
			public Class_ SignalCommon_A = new();
				public Operation SignalCommon_A_A_A = new();
					public Parameter SignalCommon_A_A_A_result = new();
				public Property SignalCommon_A_v = new();
				public Port SignalCommon_A_p = new();
				public Activity SignalCommon_A_AClassifierBehavior = new();
					public ObjectFlow SignalCommon_A_AClassifierBehavior_ObjectFlow0 = new();
						public LiteralBoolean SignalCommon_A_AClassifierBehavior_ObjectFlow0_LiteralBoolean1 = new();
						public LiteralInteger SignalCommon_A_AClassifierBehavior_ObjectFlow0_LiteralInteger2 = new();
					public AcceptEventAction SignalCommon_A_AClassifierBehavior_Accept_S = new();
						public OutputPin SignalCommon_A_AClassifierBehavior_Accept_S_value = new();
							public LiteralUnlimitedNatural SignalCommon_A_AClassifierBehavior_Accept_S_value_LiteralUnlimitedNatural3 = new();
							public LiteralInteger SignalCommon_A_AClassifierBehavior_Accept_S_value_LiteralInteger4 = new();
							public LiteralInteger SignalCommon_A_AClassifierBehavior_Accept_S_value_LiteralInteger5 = new();
						public Trigger SignalCommon_A_AClassifierBehavior_Accept_S_Trigger6 = new();
					public ActivityFinalNode SignalCommon_A_AClassifierBehavior_ActivityFinalNode7 = new();
					public ControlFlow SignalCommon_A_AClassifierBehavior_ControlFlow8 = new();
					public AddStructuralFeatureValueAction SignalCommon_A_AClassifierBehavior_Set_v = new();
						public InputPin SignalCommon_A_AClassifierBehavior_Set_v_value = new();
							public LiteralUnlimitedNatural SignalCommon_A_AClassifierBehavior_Set_v_value_LiteralUnlimitedNatural9 = new();
							public LiteralInteger SignalCommon_A_AClassifierBehavior_Set_v_value_LiteralInteger10 = new();
						public InputPin SignalCommon_A_AClassifierBehavior_Set_v_object = new();
							public LiteralInteger SignalCommon_A_AClassifierBehavior_Set_v_object_LiteralInteger11 = new();
							public LiteralUnlimitedNatural SignalCommon_A_AClassifierBehavior_Set_v_object_LiteralUnlimitedNatural12 = new();
						public OutputPin SignalCommon_A_AClassifierBehavior_Set_v_result = new();
							public LiteralUnlimitedNatural SignalCommon_A_AClassifierBehavior_Set_v_result_LiteralUnlimitedNatural13 = new();
							public LiteralInteger SignalCommon_A_AClassifierBehavior_Set_v_result_LiteralInteger14 = new();
					public SendSignalAction SignalCommon_A_AClassifierBehavior_Send_Continue = new();
						public InputPin SignalCommon_A_AClassifierBehavior_Send_Continue_target = new();
							public LiteralInteger SignalCommon_A_AClassifierBehavior_Send_Continue_target_LiteralInteger15 = new();
							public LiteralUnlimitedNatural SignalCommon_A_AClassifierBehavior_Send_Continue_target_LiteralUnlimitedNatural16 = new();
					public ObjectFlow SignalCommon_A_AClassifierBehavior_ObjectFlow17 = new();
						public LiteralBoolean SignalCommon_A_AClassifierBehavior_ObjectFlow17_LiteralBoolean18 = new();
						public LiteralInteger SignalCommon_A_AClassifierBehavior_ObjectFlow17_LiteralInteger19 = new();
					public ObjectFlow SignalCommon_A_AClassifierBehavior_ObjectFlow20 = new();
						public LiteralInteger SignalCommon_A_AClassifierBehavior_ObjectFlow20_LiteralInteger21 = new();
						public LiteralBoolean SignalCommon_A_AClassifierBehavior_ObjectFlow20_LiteralBoolean22 = new();
					public ControlFlow SignalCommon_A_AClassifierBehavior_ControlFlow23 = new();
					public ReadSelfAction SignalCommon_A_AClassifierBehavior_this = new();
						public OutputPin SignalCommon_A_AClassifierBehavior_this_result = new();
							public LiteralInteger SignalCommon_A_AClassifierBehavior_this_result_LiteralInteger24 = new();
							public LiteralUnlimitedNatural SignalCommon_A_AClassifierBehavior_this_result_LiteralUnlimitedNatural25 = new();
			public SignalEvent SignalCommon_StartEvent = new();
			public Class_ SignalCommon_Tester = new();
				public Reception SignalCommon_Tester_Start = new();
				public Activity SignalCommon_Tester_TesterClassifierBehavior = new();
					public ControlFlow SignalCommon_Tester_TesterClassifierBehavior_ControlFlow26 = new();
					public CallOperationAction SignalCommon_Tester_TesterClassifierBehavior_Call_test_ = new();
						public InputPin SignalCommon_Tester_TesterClassifierBehavior_Call_test__target = new();
							public LiteralInteger SignalCommon_Tester_TesterClassifierBehavior_Call_test__target_LiteralInteger27 = new();
							public LiteralUnlimitedNatural SignalCommon_Tester_TesterClassifierBehavior_Call_test__target_LiteralUnlimitedNatural28 = new();
					public ControlFlow SignalCommon_Tester_TesterClassifierBehavior_ControlFlow29 = new();
					public ReadSelfAction SignalCommon_Tester_TesterClassifierBehavior_this = new();
						public OutputPin SignalCommon_Tester_TesterClassifierBehavior_this_result = new();
							public LiteralInteger SignalCommon_Tester_TesterClassifierBehavior_this_result_LiteralInteger30 = new();
							public LiteralUnlimitedNatural SignalCommon_Tester_TesterClassifierBehavior_this_result_LiteralUnlimitedNatural31 = new();
					public ControlFlow SignalCommon_Tester_TesterClassifierBehavior_ControlFlow32 = new();
					public ObjectFlow SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow33 = new();
						public LiteralBoolean SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow33_LiteralBoolean34 = new();
						public LiteralInteger SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow33_LiteralInteger35 = new();
					public SendSignalAction SignalCommon_Tester_TesterClassifierBehavior_Send_S = new();
						public InputPin SignalCommon_Tester_TesterClassifierBehavior_Send_S_target = new();
							public LiteralInteger SignalCommon_Tester_TesterClassifierBehavior_Send_S_target_LiteralInteger36 = new();
							public LiteralUnlimitedNatural SignalCommon_Tester_TesterClassifierBehavior_Send_S_target_LiteralUnlimitedNatural37 = new();
						public InputPin SignalCommon_Tester_TesterClassifierBehavior_Send_S_value = new();
							public LiteralUnlimitedNatural SignalCommon_Tester_TesterClassifierBehavior_Send_S_value_LiteralUnlimitedNatural38 = new();
							public LiteralInteger SignalCommon_Tester_TesterClassifierBehavior_Send_S_value_LiteralInteger39 = new();
							public LiteralInteger SignalCommon_Tester_TesterClassifierBehavior_Send_S_value_LiteralInteger40 = new();
					public ControlFlow SignalCommon_Tester_TesterClassifierBehavior_ControlFlow41 = new();
					public ActivityFinalNode SignalCommon_Tester_TesterClassifierBehavior_ActivityFinalNode42 = new();
					public ObjectFlow SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow43 = new();
						public LiteralBoolean SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow43_LiteralBoolean44 = new();
						public LiteralInteger SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow43_LiteralInteger45 = new();
					public ObjectFlow SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow46 = new();
						public LiteralBoolean SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow46_LiteralBoolean47 = new();
						public LiteralInteger SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow46_LiteralInteger48 = new();
					public AcceptEventAction SignalCommon_Tester_TesterClassifierBehavior_Accept_Continue = new();
					public AcceptEventAction SignalCommon_Tester_TesterClassifierBehavior_Accept_Start = new();
						public Trigger SignalCommon_Tester_TesterClassifierBehavior_Accept_Start_Trigger49 = new();
						public OutputPin SignalCommon_Tester_TesterClassifierBehavior_Accept_Start_testCase = new();
							public LiteralInteger SignalCommon_Tester_TesterClassifierBehavior_Accept_Start_testCase_LiteralInteger50 = new();
							public LiteralUnlimitedNatural SignalCommon_Tester_TesterClassifierBehavior_Accept_Start_testCase_LiteralUnlimitedNatural51 = new();
							public LiteralInteger SignalCommon_Tester_TesterClassifierBehavior_Accept_Start_testCase_LiteralInteger52 = new();
					public ValueSpecificationAction SignalCommon_Tester_TesterClassifierBehavior_Value_4 = new();
						public OutputPin SignalCommon_Tester_TesterClassifierBehavior_Value_4_result = new();
							public LiteralUnlimitedNatural SignalCommon_Tester_TesterClassifierBehavior_Value_4_result_LiteralUnlimitedNatural53 = new();
							public LiteralInteger SignalCommon_Tester_TesterClassifierBehavior_Value_4_result_LiteralInteger54 = new();
						public LiteralInteger SignalCommon_Tester_TesterClassifierBehavior_Value_4_LiteralInteger55 = new();
				public Operation SignalCommon_Tester_Tester_Tester = new();
					public Parameter SignalCommon_Tester_Tester_Tester_result = new();
				public Port SignalCommon_Tester_q = new();
			public Association SignalCommon_R = new();
				public Property SignalCommon_R_y = new();
				public Property SignalCommon_R_x = new();
			public Signal SignalCommon_S = new();
				public Property SignalCommon_S_value = new();
			public Signal SignalCommon_Start = new();
				public Property SignalCommon_Start_testCase = new();
			public SignalEvent SignalCommon_ContinueEvent = new();
			public Class_ SignalCommon_I = new();
			public Signal SignalCommon_Continue = new();
			public SignalEvent SignalCommon_SEvent = new();
			public Class_ SignalCommon_TestCase = new();
				public Operation SignalCommon_TestCase_test = new();

		public static SignalCommonModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public SignalCommonModel()
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
			 * Model SignalCommon
			 */
			AddToElementRepository("SignalCommon", SignalCommon);
				AddToElementRepository("A", SignalCommon_A);
					AddToElementRepository("A_A", SignalCommon_A_A_A);
						AddToElementRepository("result", SignalCommon_A_A_A_result);
					AddToElementRepository("v", SignalCommon_A_v);
					AddToElementRepository("p", SignalCommon_A_p);
					AddToElementRepository("AClassifierBehavior", SignalCommon_A_AClassifierBehavior);
						AddToElementRepository("ObjectFlow0", SignalCommon_A_AClassifierBehavior_ObjectFlow0);
							AddToElementRepository("LiteralBoolean1", SignalCommon_A_AClassifierBehavior_ObjectFlow0_LiteralBoolean1);
							AddToElementRepository("LiteralInteger2", SignalCommon_A_AClassifierBehavior_ObjectFlow0_LiteralInteger2);
						AddToElementRepository("Accept S", SignalCommon_A_AClassifierBehavior_Accept_S);
							AddToElementRepository("value", SignalCommon_A_AClassifierBehavior_Accept_S_value);
								AddToElementRepository("LiteralUnlimitedNatural3", SignalCommon_A_AClassifierBehavior_Accept_S_value_LiteralUnlimitedNatural3);
								AddToElementRepository("LiteralInteger4", SignalCommon_A_AClassifierBehavior_Accept_S_value_LiteralInteger4);
								AddToElementRepository("LiteralInteger5", SignalCommon_A_AClassifierBehavior_Accept_S_value_LiteralInteger5);
							AddToElementRepository("Trigger6", SignalCommon_A_AClassifierBehavior_Accept_S_Trigger6);
						AddToElementRepository("ActivityFinalNode7", SignalCommon_A_AClassifierBehavior_ActivityFinalNode7);
						AddToElementRepository("ControlFlow8", SignalCommon_A_AClassifierBehavior_ControlFlow8);
						AddToElementRepository("Set v", SignalCommon_A_AClassifierBehavior_Set_v);
							AddToElementRepository("value", SignalCommon_A_AClassifierBehavior_Set_v_value);
								AddToElementRepository("LiteralUnlimitedNatural9", SignalCommon_A_AClassifierBehavior_Set_v_value_LiteralUnlimitedNatural9);
								AddToElementRepository("LiteralInteger10", SignalCommon_A_AClassifierBehavior_Set_v_value_LiteralInteger10);
							AddToElementRepository("object", SignalCommon_A_AClassifierBehavior_Set_v_object);
								AddToElementRepository("LiteralInteger11", SignalCommon_A_AClassifierBehavior_Set_v_object_LiteralInteger11);
								AddToElementRepository("LiteralUnlimitedNatural12", SignalCommon_A_AClassifierBehavior_Set_v_object_LiteralUnlimitedNatural12);
							AddToElementRepository("result", SignalCommon_A_AClassifierBehavior_Set_v_result);
								AddToElementRepository("LiteralUnlimitedNatural13", SignalCommon_A_AClassifierBehavior_Set_v_result_LiteralUnlimitedNatural13);
								AddToElementRepository("LiteralInteger14", SignalCommon_A_AClassifierBehavior_Set_v_result_LiteralInteger14);
						AddToElementRepository("Send Continue", SignalCommon_A_AClassifierBehavior_Send_Continue);
							AddToElementRepository("target", SignalCommon_A_AClassifierBehavior_Send_Continue_target);
								AddToElementRepository("LiteralInteger15", SignalCommon_A_AClassifierBehavior_Send_Continue_target_LiteralInteger15);
								AddToElementRepository("LiteralUnlimitedNatural16", SignalCommon_A_AClassifierBehavior_Send_Continue_target_LiteralUnlimitedNatural16);
						AddToElementRepository("ObjectFlow17", SignalCommon_A_AClassifierBehavior_ObjectFlow17);
							AddToElementRepository("LiteralBoolean18", SignalCommon_A_AClassifierBehavior_ObjectFlow17_LiteralBoolean18);
							AddToElementRepository("LiteralInteger19", SignalCommon_A_AClassifierBehavior_ObjectFlow17_LiteralInteger19);
						AddToElementRepository("ObjectFlow20", SignalCommon_A_AClassifierBehavior_ObjectFlow20);
							AddToElementRepository("LiteralInteger21", SignalCommon_A_AClassifierBehavior_ObjectFlow20_LiteralInteger21);
							AddToElementRepository("LiteralBoolean22", SignalCommon_A_AClassifierBehavior_ObjectFlow20_LiteralBoolean22);
						AddToElementRepository("ControlFlow23", SignalCommon_A_AClassifierBehavior_ControlFlow23);
						AddToElementRepository("this", SignalCommon_A_AClassifierBehavior_this);
							AddToElementRepository("result", SignalCommon_A_AClassifierBehavior_this_result);
								AddToElementRepository("LiteralInteger24", SignalCommon_A_AClassifierBehavior_this_result_LiteralInteger24);
								AddToElementRepository("LiteralUnlimitedNatural25", SignalCommon_A_AClassifierBehavior_this_result_LiteralUnlimitedNatural25);
				AddToElementRepository("StartEvent", SignalCommon_StartEvent);
				AddToElementRepository("Tester", SignalCommon_Tester);
					AddToElementRepository("Start", SignalCommon_Tester_Start);
					AddToElementRepository("TesterClassifierBehavior", SignalCommon_Tester_TesterClassifierBehavior);
						AddToElementRepository("ControlFlow26", SignalCommon_Tester_TesterClassifierBehavior_ControlFlow26);
						AddToElementRepository("Call test()", SignalCommon_Tester_TesterClassifierBehavior_Call_test_);
							AddToElementRepository("target", SignalCommon_Tester_TesterClassifierBehavior_Call_test__target);
								AddToElementRepository("LiteralInteger27", SignalCommon_Tester_TesterClassifierBehavior_Call_test__target_LiteralInteger27);
								AddToElementRepository("LiteralUnlimitedNatural28", SignalCommon_Tester_TesterClassifierBehavior_Call_test__target_LiteralUnlimitedNatural28);
						AddToElementRepository("ControlFlow29", SignalCommon_Tester_TesterClassifierBehavior_ControlFlow29);
						AddToElementRepository("this", SignalCommon_Tester_TesterClassifierBehavior_this);
							AddToElementRepository("result", SignalCommon_Tester_TesterClassifierBehavior_this_result);
								AddToElementRepository("LiteralInteger30", SignalCommon_Tester_TesterClassifierBehavior_this_result_LiteralInteger30);
								AddToElementRepository("LiteralUnlimitedNatural31", SignalCommon_Tester_TesterClassifierBehavior_this_result_LiteralUnlimitedNatural31);
						AddToElementRepository("ControlFlow32", SignalCommon_Tester_TesterClassifierBehavior_ControlFlow32);
						AddToElementRepository("ObjectFlow33", SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow33);
							AddToElementRepository("LiteralBoolean34", SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow33_LiteralBoolean34);
							AddToElementRepository("LiteralInteger35", SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow33_LiteralInteger35);
						AddToElementRepository("Send S", SignalCommon_Tester_TesterClassifierBehavior_Send_S);
							AddToElementRepository("target", SignalCommon_Tester_TesterClassifierBehavior_Send_S_target);
								AddToElementRepository("LiteralInteger36", SignalCommon_Tester_TesterClassifierBehavior_Send_S_target_LiteralInteger36);
								AddToElementRepository("LiteralUnlimitedNatural37", SignalCommon_Tester_TesterClassifierBehavior_Send_S_target_LiteralUnlimitedNatural37);
							AddToElementRepository("value", SignalCommon_Tester_TesterClassifierBehavior_Send_S_value);
								AddToElementRepository("LiteralUnlimitedNatural38", SignalCommon_Tester_TesterClassifierBehavior_Send_S_value_LiteralUnlimitedNatural38);
								AddToElementRepository("LiteralInteger39", SignalCommon_Tester_TesterClassifierBehavior_Send_S_value_LiteralInteger39);
								AddToElementRepository("LiteralInteger40", SignalCommon_Tester_TesterClassifierBehavior_Send_S_value_LiteralInteger40);
						AddToElementRepository("ControlFlow41", SignalCommon_Tester_TesterClassifierBehavior_ControlFlow41);
						AddToElementRepository("ActivityFinalNode42", SignalCommon_Tester_TesterClassifierBehavior_ActivityFinalNode42);
						AddToElementRepository("ObjectFlow43", SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow43);
							AddToElementRepository("LiteralBoolean44", SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow43_LiteralBoolean44);
							AddToElementRepository("LiteralInteger45", SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow43_LiteralInteger45);
						AddToElementRepository("ObjectFlow46", SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow46);
							AddToElementRepository("LiteralBoolean47", SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow46_LiteralBoolean47);
							AddToElementRepository("LiteralInteger48", SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow46_LiteralInteger48);
						AddToElementRepository("Accept Continue", SignalCommon_Tester_TesterClassifierBehavior_Accept_Continue);
						AddToElementRepository("Accept Start", SignalCommon_Tester_TesterClassifierBehavior_Accept_Start);
							AddToElementRepository("Trigger49", SignalCommon_Tester_TesterClassifierBehavior_Accept_Start_Trigger49);
							AddToElementRepository("testCase", SignalCommon_Tester_TesterClassifierBehavior_Accept_Start_testCase);
								AddToElementRepository("LiteralInteger50", SignalCommon_Tester_TesterClassifierBehavior_Accept_Start_testCase_LiteralInteger50);
								AddToElementRepository("LiteralUnlimitedNatural51", SignalCommon_Tester_TesterClassifierBehavior_Accept_Start_testCase_LiteralUnlimitedNatural51);
								AddToElementRepository("LiteralInteger52", SignalCommon_Tester_TesterClassifierBehavior_Accept_Start_testCase_LiteralInteger52);
						AddToElementRepository("Value(4)", SignalCommon_Tester_TesterClassifierBehavior_Value_4);
							AddToElementRepository("result", SignalCommon_Tester_TesterClassifierBehavior_Value_4_result);
								AddToElementRepository("LiteralUnlimitedNatural53", SignalCommon_Tester_TesterClassifierBehavior_Value_4_result_LiteralUnlimitedNatural53);
								AddToElementRepository("LiteralInteger54", SignalCommon_Tester_TesterClassifierBehavior_Value_4_result_LiteralInteger54);
							AddToElementRepository("LiteralInteger55", SignalCommon_Tester_TesterClassifierBehavior_Value_4_LiteralInteger55);
					AddToElementRepository("Tester_Tester", SignalCommon_Tester_Tester_Tester);
						AddToElementRepository("result", SignalCommon_Tester_Tester_Tester_result);
					AddToElementRepository("q", SignalCommon_Tester_q);
				AddToElementRepository("R", SignalCommon_R);
					AddToElementRepository("y", SignalCommon_R_y);
					AddToElementRepository("x", SignalCommon_R_x);
				AddToElementRepository("S", SignalCommon_S);
					AddToElementRepository("value", SignalCommon_S_value);
				AddToElementRepository("Start", SignalCommon_Start);
					AddToElementRepository("testCase", SignalCommon_Start_testCase);
				AddToElementRepository("ContinueEvent", SignalCommon_ContinueEvent);
				AddToElementRepository("I", SignalCommon_I);
				AddToElementRepository("Continue", SignalCommon_Continue);
				AddToElementRepository("SEvent", SignalCommon_SEvent);
				AddToElementRepository("TestCase", SignalCommon_TestCase);
					AddToElementRepository("test", SignalCommon_TestCase_test);

			// Initialize public members
			/*
			 * Model SignalCommon
			 */
			SignalCommon.SetName("SignalCommon");
			SignalCommon.SetVisibility(VisibilityKind.public_);
				// Class A
				SignalCommon_A.SetName("A");
				SignalCommon_A.SetVisibility(VisibilityKind.public_);
				
					// Property v
					SignalCommon_A_v.SetName("v");
					SignalCommon_A_v.SetVisibility(VisibilityKind.public_);
					
					SignalCommon_A_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					SignalCommon_A_v.SetAggregation(AggregationKind.shared);
				SignalCommon_A.AddOwnedAttribute(SignalCommon_A_v);
					// Port p
					SignalCommon_A_p.SetName("p");
					SignalCommon_A_p.SetVisibility(VisibilityKind.public_);
					
					SignalCommon_A_p.SetType(SignalCommon_I);
					SignalCommon_A_p.SetAggregation(AggregationKind.composite);
					SignalCommon_A_p.isBehavior = true;
					SignalCommon_A_p.isService = true;
				SignalCommon_A.AddOwnedAttribute(SignalCommon_A_p);
				SignalCommon_A.SetClassifierBehavior(SignalCommon_A_AClassifierBehavior);
					// Activity AClassifierBehavior
					SignalCommon_A_AClassifierBehavior.SetName("AClassifierBehavior");
					SignalCommon_A_AClassifierBehavior.SetVisibility(VisibilityKind.public_);
					
					SignalCommon_A_AClassifierBehavior.isReentrant = false;
						// AcceptEventAction Accept S
						SignalCommon_A_AClassifierBehavior_Accept_S.SetName("Accept S");
						SignalCommon_A_AClassifierBehavior_Accept_S.SetVisibility(VisibilityKind.public_);
						SignalCommon_A_AClassifierBehavior_Accept_S.SetIsUnmarshall(true);
							// OutputPin value
							SignalCommon_A_AClassifierBehavior_Accept_S_value.SetName("value");
							SignalCommon_A_AClassifierBehavior_Accept_S_value.SetVisibility(VisibilityKind.public_);
							SignalCommon_A_AClassifierBehavior_Accept_S_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						SignalCommon_A_AClassifierBehavior_Accept_S.AddResult(SignalCommon_A_AClassifierBehavior_Accept_S_value);
							// Trigger Trigger6
							SignalCommon_A_AClassifierBehavior_Accept_S_Trigger6.SetName("Trigger6");
							SignalCommon_A_AClassifierBehavior_Accept_S_Trigger6.SetVisibility(VisibilityKind.public_);
							SignalCommon_A_AClassifierBehavior_Accept_S_Trigger6.SetEvent(SignalCommon_SEvent);
						SignalCommon_A_AClassifierBehavior_Accept_S.AddTrigger(SignalCommon_A_AClassifierBehavior_Accept_S_Trigger6);
					SignalCommon_A_AClassifierBehavior.AddNode(SignalCommon_A_AClassifierBehavior_Accept_S);
						// ActivityFinalNode ActivityFinalNode7
						SignalCommon_A_AClassifierBehavior_ActivityFinalNode7.SetName("ActivityFinalNode7");
						SignalCommon_A_AClassifierBehavior_ActivityFinalNode7.SetVisibility(VisibilityKind.public_);
					SignalCommon_A_AClassifierBehavior.AddNode(SignalCommon_A_AClassifierBehavior_ActivityFinalNode7);
						// AddStructuralFeatureValueAction Set v
						SignalCommon_A_AClassifierBehavior_Set_v.SetName("Set v");
						SignalCommon_A_AClassifierBehavior_Set_v.SetVisibility(VisibilityKind.public_);
						SignalCommon_A_AClassifierBehavior_Set_v.SetStructuralFeature(SignalCommon_A_v);
							// InputPin object
							SignalCommon_A_AClassifierBehavior_Set_v_object.SetName("object");
							SignalCommon_A_AClassifierBehavior_Set_v_object.SetVisibility(VisibilityKind.public_);
							SignalCommon_A_AClassifierBehavior_Set_v_object.SetType(SignalCommon_A);
						SignalCommon_A_AClassifierBehavior_Set_v.SetObject(SignalCommon_A_AClassifierBehavior_Set_v_object);
							// InputPin value
							SignalCommon_A_AClassifierBehavior_Set_v_value.SetName("value");
							SignalCommon_A_AClassifierBehavior_Set_v_value.SetVisibility(VisibilityKind.public_);
							SignalCommon_A_AClassifierBehavior_Set_v_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						SignalCommon_A_AClassifierBehavior_Set_v.SetValue(SignalCommon_A_AClassifierBehavior_Set_v_value);
							// OutputPin result
							SignalCommon_A_AClassifierBehavior_Set_v_result.SetName("result");
							SignalCommon_A_AClassifierBehavior_Set_v_result.SetVisibility(VisibilityKind.public_);
							SignalCommon_A_AClassifierBehavior_Set_v_result.SetType(SignalCommon_A);
						SignalCommon_A_AClassifierBehavior_Set_v.SetResult(SignalCommon_A_AClassifierBehavior_Set_v_result);
					SignalCommon_A_AClassifierBehavior.AddNode(SignalCommon_A_AClassifierBehavior_Set_v);
						// SendSignalAction Send Continue
						SignalCommon_A_AClassifierBehavior_Send_Continue.SetName("Send Continue");
						SignalCommon_A_AClassifierBehavior_Send_Continue.SetVisibility(VisibilityKind.public_);
						SignalCommon_A_AClassifierBehavior_Send_Continue.SetSignal(SignalCommon_Continue);
							// InputPin target
							SignalCommon_A_AClassifierBehavior_Send_Continue_target.SetName("target");
							SignalCommon_A_AClassifierBehavior_Send_Continue_target.SetVisibility(VisibilityKind.public_);
							SignalCommon_A_AClassifierBehavior_Send_Continue_target.SetType(SignalCommon_A);
						SignalCommon_A_AClassifierBehavior_Send_Continue.SetTarget(SignalCommon_A_AClassifierBehavior_Send_Continue_target);
						SignalCommon_A_AClassifierBehavior_Send_Continue.SetOnPort(SignalCommon_A_p);
					SignalCommon_A_AClassifierBehavior.AddNode(SignalCommon_A_AClassifierBehavior_Send_Continue);
						// ReadSelfAction this
						SignalCommon_A_AClassifierBehavior_this.SetName("this");
						SignalCommon_A_AClassifierBehavior_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							SignalCommon_A_AClassifierBehavior_this_result.SetName("result");
							SignalCommon_A_AClassifierBehavior_this_result.SetVisibility(VisibilityKind.public_);
							SignalCommon_A_AClassifierBehavior_this_result.SetType(SignalCommon_A);
						SignalCommon_A_AClassifierBehavior_this.SetResult(SignalCommon_A_AClassifierBehavior_this_result);
					SignalCommon_A_AClassifierBehavior.AddNode(SignalCommon_A_AClassifierBehavior_this);
						// ObjectFlow ObjectFlow0 from result to object
						SignalCommon_A_AClassifierBehavior_ObjectFlow0.SetName("ObjectFlow0");
						SignalCommon_A_AClassifierBehavior_ObjectFlow0.SetVisibility(VisibilityKind.public_);
						
						SignalCommon_A_AClassifierBehavior_ObjectFlow0.SetSource(SignalCommon_A_AClassifierBehavior_this_result);
						SignalCommon_A_AClassifierBehavior_ObjectFlow0.SetTarget(SignalCommon_A_AClassifierBehavior_Set_v_object);
							// LiteralBoolean LiteralBoolean1
							SignalCommon_A_AClassifierBehavior_ObjectFlow0_LiteralBoolean1.SetName("LiteralBoolean1");
							SignalCommon_A_AClassifierBehavior_ObjectFlow0_LiteralBoolean1.SetVisibility(VisibilityKind.public_);
							SignalCommon_A_AClassifierBehavior_ObjectFlow0_LiteralBoolean1.SetValue(true);
						SignalCommon_A_AClassifierBehavior_ObjectFlow0.SetGuard(SignalCommon_A_AClassifierBehavior_ObjectFlow0_LiteralBoolean1);
					SignalCommon_A_AClassifierBehavior.AddEdge(SignalCommon_A_AClassifierBehavior_ObjectFlow0);
						// ControlFlow ControlFlow8 from Send Continue to ActivityFinalNode7
						SignalCommon_A_AClassifierBehavior_ControlFlow8.SetName("ControlFlow8");
						SignalCommon_A_AClassifierBehavior_ControlFlow8.SetVisibility(VisibilityKind.public_);
						
						SignalCommon_A_AClassifierBehavior_ControlFlow8.SetSource(SignalCommon_A_AClassifierBehavior_Send_Continue);
						SignalCommon_A_AClassifierBehavior_ControlFlow8.SetTarget(SignalCommon_A_AClassifierBehavior_ActivityFinalNode7);
					SignalCommon_A_AClassifierBehavior.AddEdge(SignalCommon_A_AClassifierBehavior_ControlFlow8);
						// ObjectFlow ObjectFlow17 from result to target
						SignalCommon_A_AClassifierBehavior_ObjectFlow17.SetName("ObjectFlow17");
						SignalCommon_A_AClassifierBehavior_ObjectFlow17.SetVisibility(VisibilityKind.public_);
						
						SignalCommon_A_AClassifierBehavior_ObjectFlow17.SetSource(SignalCommon_A_AClassifierBehavior_Set_v_result);
						SignalCommon_A_AClassifierBehavior_ObjectFlow17.SetTarget(SignalCommon_A_AClassifierBehavior_Send_Continue_target);
							// LiteralBoolean LiteralBoolean18
							SignalCommon_A_AClassifierBehavior_ObjectFlow17_LiteralBoolean18.SetName("LiteralBoolean18");
							SignalCommon_A_AClassifierBehavior_ObjectFlow17_LiteralBoolean18.SetVisibility(VisibilityKind.public_);
							SignalCommon_A_AClassifierBehavior_ObjectFlow17_LiteralBoolean18.SetValue(true);
						SignalCommon_A_AClassifierBehavior_ObjectFlow17.SetGuard(SignalCommon_A_AClassifierBehavior_ObjectFlow17_LiteralBoolean18);
					SignalCommon_A_AClassifierBehavior.AddEdge(SignalCommon_A_AClassifierBehavior_ObjectFlow17);
						// ObjectFlow ObjectFlow20 from value to value
						SignalCommon_A_AClassifierBehavior_ObjectFlow20.SetName("ObjectFlow20");
						SignalCommon_A_AClassifierBehavior_ObjectFlow20.SetVisibility(VisibilityKind.public_);
						
						SignalCommon_A_AClassifierBehavior_ObjectFlow20.SetSource(SignalCommon_A_AClassifierBehavior_Accept_S_value);
						SignalCommon_A_AClassifierBehavior_ObjectFlow20.SetTarget(SignalCommon_A_AClassifierBehavior_Set_v_value);
							// LiteralBoolean LiteralBoolean22
							SignalCommon_A_AClassifierBehavior_ObjectFlow20_LiteralBoolean22.SetName("LiteralBoolean22");
							SignalCommon_A_AClassifierBehavior_ObjectFlow20_LiteralBoolean22.SetVisibility(VisibilityKind.public_);
							SignalCommon_A_AClassifierBehavior_ObjectFlow20_LiteralBoolean22.SetValue(true);
						SignalCommon_A_AClassifierBehavior_ObjectFlow20.SetGuard(SignalCommon_A_AClassifierBehavior_ObjectFlow20_LiteralBoolean22);
					SignalCommon_A_AClassifierBehavior.AddEdge(SignalCommon_A_AClassifierBehavior_ObjectFlow20);
						// ControlFlow ControlFlow23 from Accept S to this
						SignalCommon_A_AClassifierBehavior_ControlFlow23.SetName("ControlFlow23");
						SignalCommon_A_AClassifierBehavior_ControlFlow23.SetVisibility(VisibilityKind.public_);
						
						SignalCommon_A_AClassifierBehavior_ControlFlow23.SetSource(SignalCommon_A_AClassifierBehavior_Accept_S);
						SignalCommon_A_AClassifierBehavior_ControlFlow23.SetTarget(SignalCommon_A_AClassifierBehavior_this);
					SignalCommon_A_AClassifierBehavior.AddEdge(SignalCommon_A_AClassifierBehavior_ControlFlow23);
				SignalCommon_A.AddOwnedBehavior(SignalCommon_A_AClassifierBehavior);
				
				SignalCommon_A.SetIsActive(true);
					// Operation A_A
					SignalCommon_A_A_A.SetName("A_A");
					SignalCommon_A_A_A.SetVisibility(VisibilityKind.public_);
						// Parameter result
						SignalCommon_A_A_A_result.SetName("result");
						SignalCommon_A_A_A_result.SetVisibility(VisibilityKind.public_);
						
						SignalCommon_A_A_A_result.SetType(SignalCommon_A);
						SignalCommon_A_A_A_result.SetDirection(ParameterDirectionKind.return_);
					SignalCommon_A_A_A.AddOwnedParameter(SignalCommon_A_A_A_result);
					SignalCommon_A_A_A.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				SignalCommon_A.AddOwnedOperation(SignalCommon_A_A_A);
			SignalCommon.AddPackagedElement(SignalCommon_A);
				// SignalEvent StartEvent
				SignalCommon_StartEvent.SetName("StartEvent");
				SignalCommon_StartEvent.SetVisibility(VisibilityKind.public_);
				SignalCommon_StartEvent.SetSignal(SignalCommon_Start);
			SignalCommon.AddPackagedElement(SignalCommon_StartEvent);
				// Class Tester
				SignalCommon_Tester.SetName("Tester");
				SignalCommon_Tester.SetVisibility(VisibilityKind.public_);
				
					// Port q
					SignalCommon_Tester_q.SetName("q");
					SignalCommon_Tester_q.SetVisibility(VisibilityKind.public_);
					
					SignalCommon_Tester_q.SetType(SignalCommon_I);
					SignalCommon_Tester_q.SetAggregation(AggregationKind.composite);
					SignalCommon_Tester_q.isBehavior = true;
					SignalCommon_Tester_q.isService = true;
				SignalCommon_Tester.AddOwnedAttribute(SignalCommon_Tester_q);
				SignalCommon_Tester.SetClassifierBehavior(SignalCommon_Tester_TesterClassifierBehavior);
					// Activity TesterClassifierBehavior
					SignalCommon_Tester_TesterClassifierBehavior.SetName("TesterClassifierBehavior");
					SignalCommon_Tester_TesterClassifierBehavior.SetVisibility(VisibilityKind.public_);
					
					SignalCommon_Tester_TesterClassifierBehavior.isReentrant = false;
						// CallOperationAction Call test()
						SignalCommon_Tester_TesterClassifierBehavior_Call_test_.SetName("Call test()");
						SignalCommon_Tester_TesterClassifierBehavior_Call_test_.SetVisibility(VisibilityKind.public_);
						SignalCommon_Tester_TesterClassifierBehavior_Call_test_.SetOperation(SignalCommon_TestCase_test);
							// InputPin target
							SignalCommon_Tester_TesterClassifierBehavior_Call_test__target.SetName("target");
							SignalCommon_Tester_TesterClassifierBehavior_Call_test__target.SetVisibility(VisibilityKind.public_);
							SignalCommon_Tester_TesterClassifierBehavior_Call_test__target.SetType(SignalCommon_TestCase);
						SignalCommon_Tester_TesterClassifierBehavior_Call_test_.SetTarget(SignalCommon_Tester_TesterClassifierBehavior_Call_test__target);
					SignalCommon_Tester_TesterClassifierBehavior.AddNode(SignalCommon_Tester_TesterClassifierBehavior_Call_test_);
						// SendSignalAction Send S
						SignalCommon_Tester_TesterClassifierBehavior_Send_S.SetName("Send S");
						SignalCommon_Tester_TesterClassifierBehavior_Send_S.SetVisibility(VisibilityKind.public_);
						SignalCommon_Tester_TesterClassifierBehavior_Send_S.SetSignal(SignalCommon_S);
							// InputPin target
							SignalCommon_Tester_TesterClassifierBehavior_Send_S_target.SetName("target");
							SignalCommon_Tester_TesterClassifierBehavior_Send_S_target.SetVisibility(VisibilityKind.public_);
							SignalCommon_Tester_TesterClassifierBehavior_Send_S_target.SetType(SignalCommon_Tester);
						SignalCommon_Tester_TesterClassifierBehavior_Send_S.SetTarget(SignalCommon_Tester_TesterClassifierBehavior_Send_S_target);
							// InputPin value
							SignalCommon_Tester_TesterClassifierBehavior_Send_S_value.SetName("value");
							SignalCommon_Tester_TesterClassifierBehavior_Send_S_value.SetVisibility(VisibilityKind.public_);
							SignalCommon_Tester_TesterClassifierBehavior_Send_S_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						SignalCommon_Tester_TesterClassifierBehavior_Send_S.AddArgument(SignalCommon_Tester_TesterClassifierBehavior_Send_S_value);
						SignalCommon_Tester_TesterClassifierBehavior_Send_S.SetOnPort(SignalCommon_Tester_q);
					SignalCommon_Tester_TesterClassifierBehavior.AddNode(SignalCommon_Tester_TesterClassifierBehavior_Send_S);
						// ActivityFinalNode ActivityFinalNode42
						SignalCommon_Tester_TesterClassifierBehavior_ActivityFinalNode42.SetName("ActivityFinalNode42");
						SignalCommon_Tester_TesterClassifierBehavior_ActivityFinalNode42.SetVisibility(VisibilityKind.public_);
					SignalCommon_Tester_TesterClassifierBehavior.AddNode(SignalCommon_Tester_TesterClassifierBehavior_ActivityFinalNode42);
						// ReadSelfAction this
						SignalCommon_Tester_TesterClassifierBehavior_this.SetName("this");
						SignalCommon_Tester_TesterClassifierBehavior_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							SignalCommon_Tester_TesterClassifierBehavior_this_result.SetName("result");
							SignalCommon_Tester_TesterClassifierBehavior_this_result.SetVisibility(VisibilityKind.public_);
							SignalCommon_Tester_TesterClassifierBehavior_this_result.SetType(SignalCommon_Tester);
						SignalCommon_Tester_TesterClassifierBehavior_this.SetResult(SignalCommon_Tester_TesterClassifierBehavior_this_result);
					SignalCommon_Tester_TesterClassifierBehavior.AddNode(SignalCommon_Tester_TesterClassifierBehavior_this);
						// AcceptEventAction Accept Continue
						SignalCommon_Tester_TesterClassifierBehavior_Accept_Continue.SetName("Accept Continue");
						SignalCommon_Tester_TesterClassifierBehavior_Accept_Continue.SetVisibility(VisibilityKind.public_);
					SignalCommon_Tester_TesterClassifierBehavior.AddNode(SignalCommon_Tester_TesterClassifierBehavior_Accept_Continue);
						// AcceptEventAction Accept Start
						SignalCommon_Tester_TesterClassifierBehavior_Accept_Start.SetName("Accept Start");
						SignalCommon_Tester_TesterClassifierBehavior_Accept_Start.SetVisibility(VisibilityKind.public_);
						SignalCommon_Tester_TesterClassifierBehavior_Accept_Start.SetIsUnmarshall(true);
							// OutputPin testCase
							SignalCommon_Tester_TesterClassifierBehavior_Accept_Start_testCase.SetName("testCase");
							SignalCommon_Tester_TesterClassifierBehavior_Accept_Start_testCase.SetVisibility(VisibilityKind.public_);
							SignalCommon_Tester_TesterClassifierBehavior_Accept_Start_testCase.SetType(SignalCommon_TestCase);
						SignalCommon_Tester_TesterClassifierBehavior_Accept_Start.AddResult(SignalCommon_Tester_TesterClassifierBehavior_Accept_Start_testCase);
							// Trigger Trigger49
							SignalCommon_Tester_TesterClassifierBehavior_Accept_Start_Trigger49.SetName("Trigger49");
							SignalCommon_Tester_TesterClassifierBehavior_Accept_Start_Trigger49.SetVisibility(VisibilityKind.public_);
							SignalCommon_Tester_TesterClassifierBehavior_Accept_Start_Trigger49.SetEvent(SignalCommon_StartEvent);
						SignalCommon_Tester_TesterClassifierBehavior_Accept_Start.AddTrigger(SignalCommon_Tester_TesterClassifierBehavior_Accept_Start_Trigger49);
					SignalCommon_Tester_TesterClassifierBehavior.AddNode(SignalCommon_Tester_TesterClassifierBehavior_Accept_Start);
						// ValueSpecificationAction Value(4)
						SignalCommon_Tester_TesterClassifierBehavior_Value_4.SetName("Value(4)");
						SignalCommon_Tester_TesterClassifierBehavior_Value_4.SetVisibility(VisibilityKind.public_);
							// LiteralInteger LiteralInteger55
							SignalCommon_Tester_TesterClassifierBehavior_Value_4_LiteralInteger55.SetName("LiteralInteger55");
							SignalCommon_Tester_TesterClassifierBehavior_Value_4_LiteralInteger55.SetVisibility(VisibilityKind.public_);
							SignalCommon_Tester_TesterClassifierBehavior_Value_4_LiteralInteger55.SetValue(4);
						SignalCommon_Tester_TesterClassifierBehavior_Value_4.SetValue(SignalCommon_Tester_TesterClassifierBehavior_Value_4_LiteralInteger55);
							// OutputPin result
							SignalCommon_Tester_TesterClassifierBehavior_Value_4_result.SetName("result");
							SignalCommon_Tester_TesterClassifierBehavior_Value_4_result.SetVisibility(VisibilityKind.public_);
							SignalCommon_Tester_TesterClassifierBehavior_Value_4_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						SignalCommon_Tester_TesterClassifierBehavior_Value_4.SetResult(SignalCommon_Tester_TesterClassifierBehavior_Value_4_result);
					SignalCommon_Tester_TesterClassifierBehavior.AddNode(SignalCommon_Tester_TesterClassifierBehavior_Value_4);
						// ControlFlow ControlFlow26 from Call test() to ActivityFinalNode42
						SignalCommon_Tester_TesterClassifierBehavior_ControlFlow26.SetName("ControlFlow26");
						SignalCommon_Tester_TesterClassifierBehavior_ControlFlow26.SetVisibility(VisibilityKind.public_);
						
						SignalCommon_Tester_TesterClassifierBehavior_ControlFlow26.SetSource(SignalCommon_Tester_TesterClassifierBehavior_Call_test_);
						SignalCommon_Tester_TesterClassifierBehavior_ControlFlow26.SetTarget(SignalCommon_Tester_TesterClassifierBehavior_ActivityFinalNode42);
					SignalCommon_Tester_TesterClassifierBehavior.AddEdge(SignalCommon_Tester_TesterClassifierBehavior_ControlFlow26);
						// ObjectFlow ObjectFlow33 from result to value
						SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow33.SetName("ObjectFlow33");
						SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow33.SetVisibility(VisibilityKind.public_);
						
						SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow33.SetSource(SignalCommon_Tester_TesterClassifierBehavior_Value_4_result);
						SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow33.SetTarget(SignalCommon_Tester_TesterClassifierBehavior_Send_S_value);
							// LiteralBoolean LiteralBoolean34
							SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow33_LiteralBoolean34.SetName("LiteralBoolean34");
							SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow33_LiteralBoolean34.SetVisibility(VisibilityKind.public_);
							SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow33_LiteralBoolean34.SetValue(true);
						SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow33.SetGuard(SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow33_LiteralBoolean34);
					SignalCommon_Tester_TesterClassifierBehavior.AddEdge(SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow33);
						// ControlFlow ControlFlow29 from Accept Start to this
						SignalCommon_Tester_TesterClassifierBehavior_ControlFlow29.SetName("ControlFlow29");
						SignalCommon_Tester_TesterClassifierBehavior_ControlFlow29.SetVisibility(VisibilityKind.public_);
						
						SignalCommon_Tester_TesterClassifierBehavior_ControlFlow29.SetSource(SignalCommon_Tester_TesterClassifierBehavior_Accept_Start);
						SignalCommon_Tester_TesterClassifierBehavior_ControlFlow29.SetTarget(SignalCommon_Tester_TesterClassifierBehavior_this);
					SignalCommon_Tester_TesterClassifierBehavior.AddEdge(SignalCommon_Tester_TesterClassifierBehavior_ControlFlow29);
						// ControlFlow ControlFlow41 from Send S to Accept Continue
						SignalCommon_Tester_TesterClassifierBehavior_ControlFlow41.SetName("ControlFlow41");
						SignalCommon_Tester_TesterClassifierBehavior_ControlFlow41.SetVisibility(VisibilityKind.public_);
						
						SignalCommon_Tester_TesterClassifierBehavior_ControlFlow41.SetSource(SignalCommon_Tester_TesterClassifierBehavior_Send_S);
						SignalCommon_Tester_TesterClassifierBehavior_ControlFlow41.SetTarget(SignalCommon_Tester_TesterClassifierBehavior_Accept_Continue);
					SignalCommon_Tester_TesterClassifierBehavior.AddEdge(SignalCommon_Tester_TesterClassifierBehavior_ControlFlow41);
						// ObjectFlow ObjectFlow43 from result to target
						SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow43.SetName("ObjectFlow43");
						SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow43.SetVisibility(VisibilityKind.public_);
						
						SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow43.SetSource(SignalCommon_Tester_TesterClassifierBehavior_this_result);
						SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow43.SetTarget(SignalCommon_Tester_TesterClassifierBehavior_Send_S_target);
							// LiteralBoolean LiteralBoolean44
							SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow43_LiteralBoolean44.SetName("LiteralBoolean44");
							SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow43_LiteralBoolean44.SetVisibility(VisibilityKind.public_);
							SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow43_LiteralBoolean44.SetValue(true);
						SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow43.SetGuard(SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow43_LiteralBoolean44);
					SignalCommon_Tester_TesterClassifierBehavior.AddEdge(SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow43);
						// ControlFlow ControlFlow32 from Accept Continue to Call test()
						SignalCommon_Tester_TesterClassifierBehavior_ControlFlow32.SetName("ControlFlow32");
						SignalCommon_Tester_TesterClassifierBehavior_ControlFlow32.SetVisibility(VisibilityKind.public_);
						
						SignalCommon_Tester_TesterClassifierBehavior_ControlFlow32.SetSource(SignalCommon_Tester_TesterClassifierBehavior_Accept_Continue);
						SignalCommon_Tester_TesterClassifierBehavior_ControlFlow32.SetTarget(SignalCommon_Tester_TesterClassifierBehavior_Call_test_);
					SignalCommon_Tester_TesterClassifierBehavior.AddEdge(SignalCommon_Tester_TesterClassifierBehavior_ControlFlow32);
						// ObjectFlow ObjectFlow46 from testCase to target
						SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow46.SetName("ObjectFlow46");
						SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow46.SetVisibility(VisibilityKind.public_);
						
						SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow46.SetSource(SignalCommon_Tester_TesterClassifierBehavior_Accept_Start_testCase);
						SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow46.SetTarget(SignalCommon_Tester_TesterClassifierBehavior_Call_test__target);
							// LiteralBoolean LiteralBoolean47
							SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow46_LiteralBoolean47.SetName("LiteralBoolean47");
							SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow46_LiteralBoolean47.SetVisibility(VisibilityKind.public_);
							SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow46_LiteralBoolean47.SetValue(true);
						SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow46.SetGuard(SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow46_LiteralBoolean47);
					SignalCommon_Tester_TesterClassifierBehavior.AddEdge(SignalCommon_Tester_TesterClassifierBehavior_ObjectFlow46);
				SignalCommon_Tester.AddOwnedBehavior(SignalCommon_Tester_TesterClassifierBehavior);
				
				SignalCommon_Tester.SetIsActive(true);
					// Operation Tester_Tester
					SignalCommon_Tester_Tester_Tester.SetName("Tester_Tester");
					SignalCommon_Tester_Tester_Tester.SetVisibility(VisibilityKind.public_);
						// Parameter result
						SignalCommon_Tester_Tester_Tester_result.SetName("result");
						SignalCommon_Tester_Tester_Tester_result.SetVisibility(VisibilityKind.public_);
						
						SignalCommon_Tester_Tester_Tester_result.SetType(SignalCommon_Tester);
						SignalCommon_Tester_Tester_Tester_result.SetDirection(ParameterDirectionKind.return_);
					SignalCommon_Tester_Tester_Tester.AddOwnedParameter(SignalCommon_Tester_Tester_Tester_result);
					SignalCommon_Tester_Tester_Tester.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				SignalCommon_Tester.AddOwnedOperation(SignalCommon_Tester_Tester_Tester);
					// Reception Start
					SignalCommon_Tester_Start.SetName("Start");
					SignalCommon_Tester_Start.SetVisibility(VisibilityKind.public_);
					SignalCommon_Tester_Start.SetSignal(SignalCommon_Start);
				SignalCommon_Tester.AddOwnedReception(SignalCommon_Tester_Start);
			SignalCommon.AddPackagedElement(SignalCommon_Tester);
				// Association R
				SignalCommon_R.SetName("R");
				SignalCommon_R.SetVisibility(VisibilityKind.public_);
				SignalCommon_R.AddOwnedEnd(SignalCommon_R_x);
				SignalCommon_R.AddOwnedEnd(SignalCommon_R_y);
			SignalCommon.AddPackagedElement(SignalCommon_R);
				// Signal S
				SignalCommon_S.SetName("S");
				SignalCommon_S.SetVisibility(VisibilityKind.public_);
				
					// Property value
					SignalCommon_S_value.SetName("value");
					SignalCommon_S_value.SetVisibility(VisibilityKind.public_);
					
					SignalCommon_S_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
				SignalCommon_S.AddOwnedAttribute(SignalCommon_S_value);
			SignalCommon.AddPackagedElement(SignalCommon_S);
				// Signal Start
				SignalCommon_Start.SetName("Start");
				SignalCommon_Start.SetVisibility(VisibilityKind.public_);
				
					// Property testCase
					SignalCommon_Start_testCase.SetName("testCase");
					SignalCommon_Start_testCase.SetVisibility(VisibilityKind.public_);
					
					SignalCommon_Start_testCase.SetType(SignalCommon_TestCase);
				SignalCommon_Start.AddOwnedAttribute(SignalCommon_Start_testCase);
			SignalCommon.AddPackagedElement(SignalCommon_Start);
				// SignalEvent ContinueEvent
				SignalCommon_ContinueEvent.SetName("ContinueEvent");
				SignalCommon_ContinueEvent.SetVisibility(VisibilityKind.public_);
				SignalCommon_ContinueEvent.SetSignal(SignalCommon_Continue);
			SignalCommon.AddPackagedElement(SignalCommon_ContinueEvent);
				// Class I
				SignalCommon_I.SetName("I");
				SignalCommon_I.SetVisibility(VisibilityKind.public_);
			SignalCommon.AddPackagedElement(SignalCommon_I);
				// Signal Continue
				SignalCommon_Continue.SetName("Continue");
				SignalCommon_Continue.SetVisibility(VisibilityKind.public_);
			SignalCommon.AddPackagedElement(SignalCommon_Continue);
				// SignalEvent SEvent
				SignalCommon_SEvent.SetName("SEvent");
				SignalCommon_SEvent.SetVisibility(VisibilityKind.public_);
				SignalCommon_SEvent.SetSignal(SignalCommon_S);
			SignalCommon.AddPackagedElement(SignalCommon_SEvent);
				// Class TestCase
				SignalCommon_TestCase.SetName("TestCase");
				SignalCommon_TestCase.SetVisibility(VisibilityKind.public_);
				
				SignalCommon_TestCase.SetIsAbstract(true);
				
				
					// Operation test
					SignalCommon_TestCase_test.SetName("test");
					SignalCommon_TestCase_test.SetVisibility(VisibilityKind.public_);
					SignalCommon_TestCase_test.SetIsAbstract(true);
				SignalCommon_TestCase.AddOwnedOperation(SignalCommon_TestCase_test);
			SignalCommon.AddPackagedElement(SignalCommon_TestCase);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // SignalCommonModel
}
