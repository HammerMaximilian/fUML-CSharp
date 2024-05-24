/*
 * LossOfMessages_SignalModel.cs
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

namespace LossOfMessages_Signal
{
	public class LossOfMessages_SignalModel : InMemoryModel
	{
		private static LossOfMessages_SignalModel? instance;

		/*
		 * Model LossOfMessages_Signal
		 */
		public Package LossOfMessages_Signal = new();
			public Interface LossOfMessages_Signal_I = new();
				public Reception LossOfMessages_Signal_I_S = new();
			public Class_ LossOfMessages_Signal_A = new();
				public Port LossOfMessages_Signal_A_q = new();
				public InterfaceRealization LossOfMessages_Signal_A_IRealization = new();
				public Activity LossOfMessages_Signal_A_AClassifierBehavior = new();
					public InitialNode LossOfMessages_Signal_A_AClassifierBehavior_Initial = new();
					public ObjectFlow LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow0 = new();
						public LiteralInteger LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow0_LiteralInteger1 = new();
						public LiteralBoolean LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow0_LiteralBoolean2 = new();
					public ObjectFlow LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow3 = new();
						public LiteralBoolean LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow3_LiteralBoolean4 = new();
						public LiteralInteger LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow3_LiteralInteger5 = new();
					public ObjectFlow LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow6 = new();
						public LiteralInteger LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow6_LiteralInteger7 = new();
						public LiteralBoolean LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow6_LiteralBoolean8 = new();
					public AddStructuralFeatureValueAction LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p = new();
						public InputPin LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p_value = new();
							public LiteralUnlimitedNatural LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p_value_LiteralUnlimitedNatural9 = new();
							public LiteralInteger LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p_value_LiteralInteger10 = new();
						public InputPin LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p_object = new();
							public LiteralInteger LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p_object_LiteralInteger11 = new();
							public LiteralUnlimitedNatural LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p_object_LiteralUnlimitedNatural12 = new();
						public OutputPin LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p_result = new();
							public LiteralUnlimitedNatural LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p_result_LiteralUnlimitedNatural13 = new();
							public LiteralInteger LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p_result_LiteralInteger14 = new();
					public ReadSelfAction LossOfMessages_Signal_A_AClassifierBehavior_this = new();
						public OutputPin LossOfMessages_Signal_A_AClassifierBehavior_this_result = new();
							public LiteralInteger LossOfMessages_Signal_A_AClassifierBehavior_this_result_LiteralInteger15 = new();
							public LiteralUnlimitedNatural LossOfMessages_Signal_A_AClassifierBehavior_this_result_LiteralUnlimitedNatural16 = new();
					public ReadStructuralFeatureAction LossOfMessages_Signal_A_AClassifierBehavior_Read_s_v = new();
						public OutputPin LossOfMessages_Signal_A_AClassifierBehavior_Read_s_v_result = new();
							public LiteralInteger LossOfMessages_Signal_A_AClassifierBehavior_Read_s_v_result_LiteralInteger17 = new();
							public LiteralUnlimitedNatural LossOfMessages_Signal_A_AClassifierBehavior_Read_s_v_result_LiteralUnlimitedNatural18 = new();
						public InputPin LossOfMessages_Signal_A_AClassifierBehavior_Read_s_v_object = new();
							public LiteralInteger LossOfMessages_Signal_A_AClassifierBehavior_Read_s_v_object_LiteralInteger19 = new();
							public LiteralUnlimitedNatural LossOfMessages_Signal_A_AClassifierBehavior_Read_s_v_object_LiteralUnlimitedNatural20 = new();
					public ControlFlow LossOfMessages_Signal_A_AClassifierBehavior_ControlFlow21 = new();
					public AcceptEventAction LossOfMessages_Signal_A_AClassifierBehavior_Accept_S = new();
						public Trigger LossOfMessages_Signal_A_AClassifierBehavior_Accept_S_Trigger22 = new();
						public OutputPin LossOfMessages_Signal_A_AClassifierBehavior_Accept_S_result = new();
							public LiteralUnlimitedNatural LossOfMessages_Signal_A_AClassifierBehavior_Accept_S_result_LiteralUnlimitedNatural23 = new();
							public LiteralInteger LossOfMessages_Signal_A_AClassifierBehavior_Accept_S_result_LiteralInteger24 = new();
							public LiteralInteger LossOfMessages_Signal_A_AClassifierBehavior_Accept_S_result_LiteralInteger25 = new();
				public Property LossOfMessages_Signal_A_p = new();
					public LiteralInteger LossOfMessages_Signal_A_p_LiteralInteger26 = new();
				public Operation LossOfMessages_Signal_A_A_A = new();
					public Parameter LossOfMessages_Signal_A_A_A_result = new();
				public Reception LossOfMessages_Signal_A_S = new();
			public Signal LossOfMessages_Signal_S = new();
				public Property LossOfMessages_Signal_S_v = new();
			public SignalEvent LossOfMessages_Signal_SignalEventS = new();
			public Activity LossOfMessages_Signal_main = new();
				public ObjectFlow LossOfMessages_Signal_main_ObjectFlow27 = new();
					public LiteralInteger LossOfMessages_Signal_main_ObjectFlow27_LiteralInteger28 = new();
					public LiteralBoolean LossOfMessages_Signal_main_ObjectFlow27_LiteralBoolean29 = new();
				public ForkNode LossOfMessages_Signal_main_Fork_A = new();
				public ObjectFlow LossOfMessages_Signal_main_ObjectFlow30 = new();
					public LiteralInteger LossOfMessages_Signal_main_ObjectFlow30_LiteralInteger31 = new();
					public LiteralBoolean LossOfMessages_Signal_main_ObjectFlow30_LiteralBoolean32 = new();
				public ObjectFlow LossOfMessages_Signal_main_ObjectFlow33 = new();
					public LiteralInteger LossOfMessages_Signal_main_ObjectFlow33_LiteralInteger34 = new();
					public LiteralBoolean LossOfMessages_Signal_main_ObjectFlow33_LiteralBoolean35 = new();
				public ObjectFlow LossOfMessages_Signal_main_ObjectFlow36 = new();
					public LiteralInteger LossOfMessages_Signal_main_ObjectFlow36_LiteralInteger37 = new();
					public LiteralBoolean LossOfMessages_Signal_main_ObjectFlow36_LiteralBoolean38 = new();
				public OpaqueBehavior LossOfMessages_Signal_main_testP = new();
					public Parameter LossOfMessages_Signal_main_testP_p = new();
				public CreateObjectAction LossOfMessages_Signal_main_Create_A = new();
					public OutputPin LossOfMessages_Signal_main_Create_A_result = new();
						public LiteralInteger LossOfMessages_Signal_main_Create_A_result_LiteralInteger39 = new();
						public LiteralUnlimitedNatural LossOfMessages_Signal_main_Create_A_result_LiteralUnlimitedNatural40 = new();
				public CallBehaviorAction LossOfMessages_Signal_main_Call_testP = new();
					public InputPin LossOfMessages_Signal_main_Call_testP_p = new();
						public LiteralUnlimitedNatural LossOfMessages_Signal_main_Call_testP_p_LiteralUnlimitedNatural41 = new();
						public LiteralInteger LossOfMessages_Signal_main_Call_testP_p_LiteralInteger42 = new();
						public LiteralInteger LossOfMessages_Signal_main_Call_testP_p_LiteralInteger43 = new();
				public ReadStructuralFeatureAction LossOfMessages_Signal_main_Read_a_p = new();
					public OutputPin LossOfMessages_Signal_main_Read_a_p_result = new();
						public LiteralUnlimitedNatural LossOfMessages_Signal_main_Read_a_p_result_LiteralUnlimitedNatural44 = new();
						public LiteralInteger LossOfMessages_Signal_main_Read_a_p_result_LiteralInteger45 = new();
					public InputPin LossOfMessages_Signal_main_Read_a_p_object = new();
						public LiteralUnlimitedNatural LossOfMessages_Signal_main_Read_a_p_object_LiteralUnlimitedNatural46 = new();
						public LiteralInteger LossOfMessages_Signal_main_Read_a_p_object_LiteralInteger47 = new();
				public ControlFlow LossOfMessages_Signal_main_ControlFlow48 = new();
				public ValueSpecificationAction LossOfMessages_Signal_main_Value_4 = new();
					public OutputPin LossOfMessages_Signal_main_Value_4_result = new();
						public LiteralInteger LossOfMessages_Signal_main_Value_4_result_LiteralInteger49 = new();
						public LiteralUnlimitedNatural LossOfMessages_Signal_main_Value_4_result_LiteralUnlimitedNatural50 = new();
					public LiteralInteger LossOfMessages_Signal_main_Value_4_LiteralInteger51 = new();
				public ObjectFlow LossOfMessages_Signal_main_ObjectFlow52 = new();
					public LiteralBoolean LossOfMessages_Signal_main_ObjectFlow52_LiteralBoolean53 = new();
					public LiteralInteger LossOfMessages_Signal_main_ObjectFlow52_LiteralInteger54 = new();
				public CallOperationAction LossOfMessages_Signal_main_A_ = new();
					public InputPin LossOfMessages_Signal_main_A__target = new();
						public LiteralUnlimitedNatural LossOfMessages_Signal_main_A__target_LiteralUnlimitedNatural55 = new();
						public LiteralInteger LossOfMessages_Signal_main_A__target_LiteralInteger56 = new();
					public OutputPin LossOfMessages_Signal_main_A__result = new();
						public LiteralInteger LossOfMessages_Signal_main_A__result_LiteralInteger57 = new();
						public LiteralUnlimitedNatural LossOfMessages_Signal_main_A__result_LiteralUnlimitedNatural58 = new();
						public LiteralInteger LossOfMessages_Signal_main_A__result_LiteralInteger59 = new();
				public ReadStructuralFeatureAction LossOfMessages_Signal_main_Read_a_q = new();
					public OutputPin LossOfMessages_Signal_main_Read_a_q_result = new();
						public LiteralUnlimitedNatural LossOfMessages_Signal_main_Read_a_q_result_LiteralUnlimitedNatural60 = new();
						public LiteralInteger LossOfMessages_Signal_main_Read_a_q_result_LiteralInteger61 = new();
					public InputPin LossOfMessages_Signal_main_Read_a_q_object = new();
						public LiteralInteger LossOfMessages_Signal_main_Read_a_q_object_LiteralInteger62 = new();
						public LiteralUnlimitedNatural LossOfMessages_Signal_main_Read_a_q_object_LiteralUnlimitedNatural63 = new();
				public ObjectFlow LossOfMessages_Signal_main_ObjectFlow64 = new();
					public LiteralBoolean LossOfMessages_Signal_main_ObjectFlow64_LiteralBoolean65 = new();
					public LiteralInteger LossOfMessages_Signal_main_ObjectFlow64_LiteralInteger66 = new();
				public ObjectFlow LossOfMessages_Signal_main_ObjectFlow67 = new();
					public LiteralInteger LossOfMessages_Signal_main_ObjectFlow67_LiteralInteger68 = new();
					public LiteralBoolean LossOfMessages_Signal_main_ObjectFlow67_LiteralBoolean69 = new();
				public SendSignalAction LossOfMessages_Signal_main_Send_S = new();
					public InputPin LossOfMessages_Signal_main_Send_S_v = new();
						public LiteralInteger LossOfMessages_Signal_main_Send_S_v_LiteralInteger70 = new();
						public LiteralInteger LossOfMessages_Signal_main_Send_S_v_LiteralInteger71 = new();
						public LiteralUnlimitedNatural LossOfMessages_Signal_main_Send_S_v_LiteralUnlimitedNatural72 = new();
					public InputPin LossOfMessages_Signal_main_Send_S_target = new();
						public LiteralUnlimitedNatural LossOfMessages_Signal_main_Send_S_target_LiteralUnlimitedNatural73 = new();
						public LiteralInteger LossOfMessages_Signal_main_Send_S_target_LiteralInteger74 = new();
			public Class_ LossOfMessages_Signal_IImpl = new();
				public Reception LossOfMessages_Signal_IImpl_S = new();
				public InterfaceRealization LossOfMessages_Signal_IImpl_IRealization = new();

		public static LossOfMessages_SignalModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public LossOfMessages_SignalModel()
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
			 * Model LossOfMessages_Signal
			 */
			AddToElementRepository("LossOfMessages_Signal", LossOfMessages_Signal);
				AddToElementRepository("I", LossOfMessages_Signal_I);
					AddToElementRepository("S", LossOfMessages_Signal_I_S);
				AddToElementRepository("A", LossOfMessages_Signal_A);
					AddToElementRepository("q", LossOfMessages_Signal_A_q);
					AddToElementRepository("IRealization", LossOfMessages_Signal_A_IRealization);
					AddToElementRepository("AClassifierBehavior", LossOfMessages_Signal_A_AClassifierBehavior);
						AddToElementRepository("Initial", LossOfMessages_Signal_A_AClassifierBehavior_Initial);
						AddToElementRepository("ObjectFlow0", LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow0);
							AddToElementRepository("LiteralInteger1", LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow0_LiteralInteger1);
							AddToElementRepository("LiteralBoolean2", LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow0_LiteralBoolean2);
						AddToElementRepository("ObjectFlow3", LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow3);
							AddToElementRepository("LiteralBoolean4", LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow3_LiteralBoolean4);
							AddToElementRepository("LiteralInteger5", LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow3_LiteralInteger5);
						AddToElementRepository("ObjectFlow6", LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow6);
							AddToElementRepository("LiteralInteger7", LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow6_LiteralInteger7);
							AddToElementRepository("LiteralBoolean8", LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow6_LiteralBoolean8);
						AddToElementRepository("Set this.p", LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p);
							AddToElementRepository("value", LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p_value);
								AddToElementRepository("LiteralUnlimitedNatural9", LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p_value_LiteralUnlimitedNatural9);
								AddToElementRepository("LiteralInteger10", LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p_value_LiteralInteger10);
							AddToElementRepository("object", LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p_object);
								AddToElementRepository("LiteralInteger11", LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p_object_LiteralInteger11);
								AddToElementRepository("LiteralUnlimitedNatural12", LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p_object_LiteralUnlimitedNatural12);
							AddToElementRepository("result", LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p_result);
								AddToElementRepository("LiteralUnlimitedNatural13", LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p_result_LiteralUnlimitedNatural13);
								AddToElementRepository("LiteralInteger14", LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p_result_LiteralInteger14);
						AddToElementRepository("this", LossOfMessages_Signal_A_AClassifierBehavior_this);
							AddToElementRepository("result", LossOfMessages_Signal_A_AClassifierBehavior_this_result);
								AddToElementRepository("LiteralInteger15", LossOfMessages_Signal_A_AClassifierBehavior_this_result_LiteralInteger15);
								AddToElementRepository("LiteralUnlimitedNatural16", LossOfMessages_Signal_A_AClassifierBehavior_this_result_LiteralUnlimitedNatural16);
						AddToElementRepository("Read s.v", LossOfMessages_Signal_A_AClassifierBehavior_Read_s_v);
							AddToElementRepository("result", LossOfMessages_Signal_A_AClassifierBehavior_Read_s_v_result);
								AddToElementRepository("LiteralInteger17", LossOfMessages_Signal_A_AClassifierBehavior_Read_s_v_result_LiteralInteger17);
								AddToElementRepository("LiteralUnlimitedNatural18", LossOfMessages_Signal_A_AClassifierBehavior_Read_s_v_result_LiteralUnlimitedNatural18);
							AddToElementRepository("object", LossOfMessages_Signal_A_AClassifierBehavior_Read_s_v_object);
								AddToElementRepository("LiteralInteger19", LossOfMessages_Signal_A_AClassifierBehavior_Read_s_v_object_LiteralInteger19);
								AddToElementRepository("LiteralUnlimitedNatural20", LossOfMessages_Signal_A_AClassifierBehavior_Read_s_v_object_LiteralUnlimitedNatural20);
						AddToElementRepository("ControlFlow21", LossOfMessages_Signal_A_AClassifierBehavior_ControlFlow21);
						AddToElementRepository("Accept S", LossOfMessages_Signal_A_AClassifierBehavior_Accept_S);
							AddToElementRepository("Trigger22", LossOfMessages_Signal_A_AClassifierBehavior_Accept_S_Trigger22);
							AddToElementRepository("result", LossOfMessages_Signal_A_AClassifierBehavior_Accept_S_result);
								AddToElementRepository("LiteralUnlimitedNatural23", LossOfMessages_Signal_A_AClassifierBehavior_Accept_S_result_LiteralUnlimitedNatural23);
								AddToElementRepository("LiteralInteger24", LossOfMessages_Signal_A_AClassifierBehavior_Accept_S_result_LiteralInteger24);
								AddToElementRepository("LiteralInteger25", LossOfMessages_Signal_A_AClassifierBehavior_Accept_S_result_LiteralInteger25);
					AddToElementRepository("p", LossOfMessages_Signal_A_p);
						AddToElementRepository("LiteralInteger26", LossOfMessages_Signal_A_p_LiteralInteger26);
					AddToElementRepository("A_A", LossOfMessages_Signal_A_A_A);
						AddToElementRepository("result", LossOfMessages_Signal_A_A_A_result);
					AddToElementRepository("S", LossOfMessages_Signal_A_S);
				AddToElementRepository("S", LossOfMessages_Signal_S);
					AddToElementRepository("v", LossOfMessages_Signal_S_v);
				AddToElementRepository("SignalEventS", LossOfMessages_Signal_SignalEventS);
				AddToElementRepository("main", LossOfMessages_Signal_main);
					AddToElementRepository("ObjectFlow27", LossOfMessages_Signal_main_ObjectFlow27);
						AddToElementRepository("LiteralInteger28", LossOfMessages_Signal_main_ObjectFlow27_LiteralInteger28);
						AddToElementRepository("LiteralBoolean29", LossOfMessages_Signal_main_ObjectFlow27_LiteralBoolean29);
					AddToElementRepository("Fork A", LossOfMessages_Signal_main_Fork_A);
					AddToElementRepository("ObjectFlow30", LossOfMessages_Signal_main_ObjectFlow30);
						AddToElementRepository("LiteralInteger31", LossOfMessages_Signal_main_ObjectFlow30_LiteralInteger31);
						AddToElementRepository("LiteralBoolean32", LossOfMessages_Signal_main_ObjectFlow30_LiteralBoolean32);
					AddToElementRepository("ObjectFlow33", LossOfMessages_Signal_main_ObjectFlow33);
						AddToElementRepository("LiteralInteger34", LossOfMessages_Signal_main_ObjectFlow33_LiteralInteger34);
						AddToElementRepository("LiteralBoolean35", LossOfMessages_Signal_main_ObjectFlow33_LiteralBoolean35);
					AddToElementRepository("ObjectFlow36", LossOfMessages_Signal_main_ObjectFlow36);
						AddToElementRepository("LiteralInteger37", LossOfMessages_Signal_main_ObjectFlow36_LiteralInteger37);
						AddToElementRepository("LiteralBoolean38", LossOfMessages_Signal_main_ObjectFlow36_LiteralBoolean38);
					AddToElementRepository("testP", LossOfMessages_Signal_main_testP);
						AddToElementRepository("p", LossOfMessages_Signal_main_testP_p);
					AddToElementRepository("Create A", LossOfMessages_Signal_main_Create_A);
						AddToElementRepository("result", LossOfMessages_Signal_main_Create_A_result);
							AddToElementRepository("LiteralInteger39", LossOfMessages_Signal_main_Create_A_result_LiteralInteger39);
							AddToElementRepository("LiteralUnlimitedNatural40", LossOfMessages_Signal_main_Create_A_result_LiteralUnlimitedNatural40);
					AddToElementRepository("Call testP", LossOfMessages_Signal_main_Call_testP);
						AddToElementRepository("p", LossOfMessages_Signal_main_Call_testP_p);
							AddToElementRepository("LiteralUnlimitedNatural41", LossOfMessages_Signal_main_Call_testP_p_LiteralUnlimitedNatural41);
							AddToElementRepository("LiteralInteger42", LossOfMessages_Signal_main_Call_testP_p_LiteralInteger42);
							AddToElementRepository("LiteralInteger43", LossOfMessages_Signal_main_Call_testP_p_LiteralInteger43);
					AddToElementRepository("Read a.p", LossOfMessages_Signal_main_Read_a_p);
						AddToElementRepository("result", LossOfMessages_Signal_main_Read_a_p_result);
							AddToElementRepository("LiteralUnlimitedNatural44", LossOfMessages_Signal_main_Read_a_p_result_LiteralUnlimitedNatural44);
							AddToElementRepository("LiteralInteger45", LossOfMessages_Signal_main_Read_a_p_result_LiteralInteger45);
						AddToElementRepository("object", LossOfMessages_Signal_main_Read_a_p_object);
							AddToElementRepository("LiteralUnlimitedNatural46", LossOfMessages_Signal_main_Read_a_p_object_LiteralUnlimitedNatural46);
							AddToElementRepository("LiteralInteger47", LossOfMessages_Signal_main_Read_a_p_object_LiteralInteger47);
					AddToElementRepository("ControlFlow48", LossOfMessages_Signal_main_ControlFlow48);
					AddToElementRepository("Value 4", LossOfMessages_Signal_main_Value_4);
						AddToElementRepository("result", LossOfMessages_Signal_main_Value_4_result);
							AddToElementRepository("LiteralInteger49", LossOfMessages_Signal_main_Value_4_result_LiteralInteger49);
							AddToElementRepository("LiteralUnlimitedNatural50", LossOfMessages_Signal_main_Value_4_result_LiteralUnlimitedNatural50);
						AddToElementRepository("LiteralInteger51", LossOfMessages_Signal_main_Value_4_LiteralInteger51);
					AddToElementRepository("ObjectFlow52", LossOfMessages_Signal_main_ObjectFlow52);
						AddToElementRepository("LiteralBoolean53", LossOfMessages_Signal_main_ObjectFlow52_LiteralBoolean53);
						AddToElementRepository("LiteralInteger54", LossOfMessages_Signal_main_ObjectFlow52_LiteralInteger54);
					AddToElementRepository("A()", LossOfMessages_Signal_main_A_);
						AddToElementRepository("target", LossOfMessages_Signal_main_A__target);
							AddToElementRepository("LiteralUnlimitedNatural55", LossOfMessages_Signal_main_A__target_LiteralUnlimitedNatural55);
							AddToElementRepository("LiteralInteger56", LossOfMessages_Signal_main_A__target_LiteralInteger56);
						AddToElementRepository("result", LossOfMessages_Signal_main_A__result);
							AddToElementRepository("LiteralInteger57", LossOfMessages_Signal_main_A__result_LiteralInteger57);
							AddToElementRepository("LiteralUnlimitedNatural58", LossOfMessages_Signal_main_A__result_LiteralUnlimitedNatural58);
							AddToElementRepository("LiteralInteger59", LossOfMessages_Signal_main_A__result_LiteralInteger59);
					AddToElementRepository("Read a.q", LossOfMessages_Signal_main_Read_a_q);
						AddToElementRepository("result", LossOfMessages_Signal_main_Read_a_q_result);
							AddToElementRepository("LiteralUnlimitedNatural60", LossOfMessages_Signal_main_Read_a_q_result_LiteralUnlimitedNatural60);
							AddToElementRepository("LiteralInteger61", LossOfMessages_Signal_main_Read_a_q_result_LiteralInteger61);
						AddToElementRepository("object", LossOfMessages_Signal_main_Read_a_q_object);
							AddToElementRepository("LiteralInteger62", LossOfMessages_Signal_main_Read_a_q_object_LiteralInteger62);
							AddToElementRepository("LiteralUnlimitedNatural63", LossOfMessages_Signal_main_Read_a_q_object_LiteralUnlimitedNatural63);
					AddToElementRepository("ObjectFlow64", LossOfMessages_Signal_main_ObjectFlow64);
						AddToElementRepository("LiteralBoolean65", LossOfMessages_Signal_main_ObjectFlow64_LiteralBoolean65);
						AddToElementRepository("LiteralInteger66", LossOfMessages_Signal_main_ObjectFlow64_LiteralInteger66);
					AddToElementRepository("ObjectFlow67", LossOfMessages_Signal_main_ObjectFlow67);
						AddToElementRepository("LiteralInteger68", LossOfMessages_Signal_main_ObjectFlow67_LiteralInteger68);
						AddToElementRepository("LiteralBoolean69", LossOfMessages_Signal_main_ObjectFlow67_LiteralBoolean69);
					AddToElementRepository("Send S", LossOfMessages_Signal_main_Send_S);
						AddToElementRepository("v", LossOfMessages_Signal_main_Send_S_v);
							AddToElementRepository("LiteralInteger70", LossOfMessages_Signal_main_Send_S_v_LiteralInteger70);
							AddToElementRepository("LiteralInteger71", LossOfMessages_Signal_main_Send_S_v_LiteralInteger71);
							AddToElementRepository("LiteralUnlimitedNatural72", LossOfMessages_Signal_main_Send_S_v_LiteralUnlimitedNatural72);
						AddToElementRepository("target", LossOfMessages_Signal_main_Send_S_target);
							AddToElementRepository("LiteralUnlimitedNatural73", LossOfMessages_Signal_main_Send_S_target_LiteralUnlimitedNatural73);
							AddToElementRepository("LiteralInteger74", LossOfMessages_Signal_main_Send_S_target_LiteralInteger74);
				AddToElementRepository("IImpl", LossOfMessages_Signal_IImpl);
					AddToElementRepository("S", LossOfMessages_Signal_IImpl_S);
					AddToElementRepository("IRealization", LossOfMessages_Signal_IImpl_IRealization);

			// Initialize public members
			/*
			 * Model LossOfMessages_Signal
			 */
			LossOfMessages_Signal.SetName("LossOfMessages_Signal");
			LossOfMessages_Signal.SetVisibility(VisibilityKind.public_);
				// Interface I
				LossOfMessages_Signal_I.SetName("I");
				LossOfMessages_Signal_I.SetVisibility(VisibilityKind.public_);
					// Reception S
					LossOfMessages_Signal_I_S.SetName("S");
					LossOfMessages_Signal_I_S.SetVisibility(VisibilityKind.public_);
					LossOfMessages_Signal_I_S.SetSignal(LossOfMessages_Signal_S);
				LossOfMessages_Signal_I.AddOwnedReception(LossOfMessages_Signal_I_S);
			LossOfMessages_Signal.AddPackagedElement(LossOfMessages_Signal_I);
				// Class A
				LossOfMessages_Signal_A.SetName("A");
				LossOfMessages_Signal_A.SetVisibility(VisibilityKind.public_);
				
					// Property p
					LossOfMessages_Signal_A_p.SetName("p");
					LossOfMessages_Signal_A_p.SetVisibility(VisibilityKind.public_);
					
					LossOfMessages_Signal_A_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					LossOfMessages_Signal_A_p.SetAggregation(AggregationKind.composite);
						// LiteralInteger LiteralInteger26
						LossOfMessages_Signal_A_p_LiteralInteger26.SetName("LiteralInteger26");
						LossOfMessages_Signal_A_p_LiteralInteger26.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Signal_A_p_LiteralInteger26.SetValue(0);
					LossOfMessages_Signal_A_p.SetDefaultValue(LossOfMessages_Signal_A_p_LiteralInteger26);
				LossOfMessages_Signal_A.AddOwnedAttribute(LossOfMessages_Signal_A_p);
					// Port q
					LossOfMessages_Signal_A_q.SetName("q");
					LossOfMessages_Signal_A_q.SetVisibility(VisibilityKind.public_);
					
					LossOfMessages_Signal_A_q.SetType(LossOfMessages_Signal_IImpl);
					LossOfMessages_Signal_A_q.SetAggregation(AggregationKind.composite);
					LossOfMessages_Signal_A_q.isService = true;
					LossOfMessages_Signal_A_q.AddProvided(LossOfMessages_Signal_I);
				LossOfMessages_Signal_A.AddOwnedAttribute(LossOfMessages_Signal_A_q);
				LossOfMessages_Signal_A.SetClassifierBehavior(LossOfMessages_Signal_A_AClassifierBehavior);
					// Activity AClassifierBehavior
					LossOfMessages_Signal_A_AClassifierBehavior.SetName("AClassifierBehavior");
					LossOfMessages_Signal_A_AClassifierBehavior.SetVisibility(VisibilityKind.public_);
						// InitialNode Initial
						LossOfMessages_Signal_A_AClassifierBehavior_Initial.SetName("Initial");
						LossOfMessages_Signal_A_AClassifierBehavior_Initial.SetVisibility(VisibilityKind.public_);
					LossOfMessages_Signal_A_AClassifierBehavior.AddNode(LossOfMessages_Signal_A_AClassifierBehavior_Initial);
						// AddStructuralFeatureValueAction Set this.p
						LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p.SetName("Set this.p");
						LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p.SetStructuralFeature(LossOfMessages_Signal_A_p);
							// InputPin object
							LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p_object.SetName("object");
							LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p_object.SetVisibility(VisibilityKind.public_);
							LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p_object.SetType(LossOfMessages_Signal_A);
						LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p.SetObject(LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p_object);
							// InputPin value
							LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p_value.SetName("value");
							LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p_value.SetVisibility(VisibilityKind.public_);
							LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p.SetValue(LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p_value);
							// OutputPin result
							LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p_result.SetName("result");
							LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p_result.SetVisibility(VisibilityKind.public_);
							LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p_result.SetType(LossOfMessages_Signal_A);
						LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p.SetResult(LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p_result);
					LossOfMessages_Signal_A_AClassifierBehavior.AddNode(LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p);
						// ReadSelfAction this
						LossOfMessages_Signal_A_AClassifierBehavior_this.SetName("this");
						LossOfMessages_Signal_A_AClassifierBehavior_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							LossOfMessages_Signal_A_AClassifierBehavior_this_result.SetName("result");
							LossOfMessages_Signal_A_AClassifierBehavior_this_result.SetVisibility(VisibilityKind.public_);
							LossOfMessages_Signal_A_AClassifierBehavior_this_result.SetType(LossOfMessages_Signal_A);
						LossOfMessages_Signal_A_AClassifierBehavior_this.SetResult(LossOfMessages_Signal_A_AClassifierBehavior_this_result);
					LossOfMessages_Signal_A_AClassifierBehavior.AddNode(LossOfMessages_Signal_A_AClassifierBehavior_this);
						// ReadStructuralFeatureAction Read s.v
						LossOfMessages_Signal_A_AClassifierBehavior_Read_s_v.SetName("Read s.v");
						LossOfMessages_Signal_A_AClassifierBehavior_Read_s_v.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Signal_A_AClassifierBehavior_Read_s_v.SetStructuralFeature(LossOfMessages_Signal_S_v);
							// InputPin object
							LossOfMessages_Signal_A_AClassifierBehavior_Read_s_v_object.SetName("object");
							LossOfMessages_Signal_A_AClassifierBehavior_Read_s_v_object.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Signal_A_AClassifierBehavior_Read_s_v.SetObject(LossOfMessages_Signal_A_AClassifierBehavior_Read_s_v_object);
							// OutputPin result
							LossOfMessages_Signal_A_AClassifierBehavior_Read_s_v_result.SetName("result");
							LossOfMessages_Signal_A_AClassifierBehavior_Read_s_v_result.SetVisibility(VisibilityKind.public_);
							LossOfMessages_Signal_A_AClassifierBehavior_Read_s_v_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						LossOfMessages_Signal_A_AClassifierBehavior_Read_s_v.SetResult(LossOfMessages_Signal_A_AClassifierBehavior_Read_s_v_result);
					LossOfMessages_Signal_A_AClassifierBehavior.AddNode(LossOfMessages_Signal_A_AClassifierBehavior_Read_s_v);
						// AcceptEventAction Accept S
						LossOfMessages_Signal_A_AClassifierBehavior_Accept_S.SetName("Accept S");
						LossOfMessages_Signal_A_AClassifierBehavior_Accept_S.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							LossOfMessages_Signal_A_AClassifierBehavior_Accept_S_result.SetName("result");
							LossOfMessages_Signal_A_AClassifierBehavior_Accept_S_result.SetVisibility(VisibilityKind.public_);
							LossOfMessages_Signal_A_AClassifierBehavior_Accept_S_result.SetType(LossOfMessages_Signal_S);
						LossOfMessages_Signal_A_AClassifierBehavior_Accept_S.AddResult(LossOfMessages_Signal_A_AClassifierBehavior_Accept_S_result);
							// Trigger Trigger22
							LossOfMessages_Signal_A_AClassifierBehavior_Accept_S_Trigger22.SetName("Trigger22");
							LossOfMessages_Signal_A_AClassifierBehavior_Accept_S_Trigger22.SetVisibility(VisibilityKind.public_);
							LossOfMessages_Signal_A_AClassifierBehavior_Accept_S_Trigger22.SetEvent(LossOfMessages_Signal_SignalEventS);
						LossOfMessages_Signal_A_AClassifierBehavior_Accept_S.AddTrigger(LossOfMessages_Signal_A_AClassifierBehavior_Accept_S_Trigger22);
					LossOfMessages_Signal_A_AClassifierBehavior.AddNode(LossOfMessages_Signal_A_AClassifierBehavior_Accept_S);
						// ObjectFlow ObjectFlow0 from result to object
						LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow0.SetName("ObjectFlow0");
						LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow0.SetVisibility(VisibilityKind.public_);
						
						LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow0.SetSource(LossOfMessages_Signal_A_AClassifierBehavior_Accept_S_result);
						LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow0.SetTarget(LossOfMessages_Signal_A_AClassifierBehavior_Read_s_v_object);
							// LiteralBoolean LiteralBoolean2
							LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow0_LiteralBoolean2.SetName("LiteralBoolean2");
							LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow0_LiteralBoolean2.SetVisibility(VisibilityKind.public_);
							LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow0_LiteralBoolean2.SetValue(true);
						LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow0.SetGuard(LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow0_LiteralBoolean2);
					LossOfMessages_Signal_A_AClassifierBehavior.AddEdge(LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow0);
						// ObjectFlow ObjectFlow3 from result to object
						LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow3.SetName("ObjectFlow3");
						LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow3.SetVisibility(VisibilityKind.public_);
						
						LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow3.SetSource(LossOfMessages_Signal_A_AClassifierBehavior_this_result);
						LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow3.SetTarget(LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p_object);
							// LiteralBoolean LiteralBoolean4
							LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow3_LiteralBoolean4.SetName("LiteralBoolean4");
							LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow3_LiteralBoolean4.SetVisibility(VisibilityKind.public_);
							LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow3_LiteralBoolean4.SetValue(true);
						LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow3.SetGuard(LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow3_LiteralBoolean4);
					LossOfMessages_Signal_A_AClassifierBehavior.AddEdge(LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow3);
						// ObjectFlow ObjectFlow6 from result to value
						LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow6.SetName("ObjectFlow6");
						LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow6.SetVisibility(VisibilityKind.public_);
						
						LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow6.SetSource(LossOfMessages_Signal_A_AClassifierBehavior_Read_s_v_result);
						LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow6.SetTarget(LossOfMessages_Signal_A_AClassifierBehavior_Set_this_p_value);
							// LiteralBoolean LiteralBoolean8
							LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow6_LiteralBoolean8.SetName("LiteralBoolean8");
							LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow6_LiteralBoolean8.SetVisibility(VisibilityKind.public_);
							LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow6_LiteralBoolean8.SetValue(true);
						LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow6.SetGuard(LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow6_LiteralBoolean8);
					LossOfMessages_Signal_A_AClassifierBehavior.AddEdge(LossOfMessages_Signal_A_AClassifierBehavior_ObjectFlow6);
						// ControlFlow ControlFlow21 from Initial to Accept S
						LossOfMessages_Signal_A_AClassifierBehavior_ControlFlow21.SetName("ControlFlow21");
						LossOfMessages_Signal_A_AClassifierBehavior_ControlFlow21.SetVisibility(VisibilityKind.public_);
						
						LossOfMessages_Signal_A_AClassifierBehavior_ControlFlow21.SetSource(LossOfMessages_Signal_A_AClassifierBehavior_Initial);
						LossOfMessages_Signal_A_AClassifierBehavior_ControlFlow21.SetTarget(LossOfMessages_Signal_A_AClassifierBehavior_Accept_S);
					LossOfMessages_Signal_A_AClassifierBehavior.AddEdge(LossOfMessages_Signal_A_AClassifierBehavior_ControlFlow21);
				LossOfMessages_Signal_A.AddOwnedBehavior(LossOfMessages_Signal_A_AClassifierBehavior);
					LossOfMessages_Signal_A_IRealization.SetName("IRealization");
					LossOfMessages_Signal_A_IRealization.SetVisibility(VisibilityKind.public_);
					LossOfMessages_Signal_A_IRealization.SetContract(LossOfMessages_Signal_I);
					
				LossOfMessages_Signal_A.AddInterfaceRealization(LossOfMessages_Signal_A_IRealization);
				
				LossOfMessages_Signal_A.SetIsActive(true);
					// Operation A_A
					LossOfMessages_Signal_A_A_A.SetName("A_A");
					LossOfMessages_Signal_A_A_A.SetVisibility(VisibilityKind.public_);
						// Parameter result
						LossOfMessages_Signal_A_A_A_result.SetName("result");
						LossOfMessages_Signal_A_A_A_result.SetVisibility(VisibilityKind.public_);
						
						LossOfMessages_Signal_A_A_A_result.SetType(LossOfMessages_Signal_A);
						LossOfMessages_Signal_A_A_A_result.SetDirection(ParameterDirectionKind.return_);
					LossOfMessages_Signal_A_A_A.AddOwnedParameter(LossOfMessages_Signal_A_A_A_result);
					LossOfMessages_Signal_A_A_A.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				LossOfMessages_Signal_A.AddOwnedOperation(LossOfMessages_Signal_A_A_A);
					// Reception S
					LossOfMessages_Signal_A_S.SetName("S");
					LossOfMessages_Signal_A_S.SetVisibility(VisibilityKind.public_);
					LossOfMessages_Signal_A_S.SetSignal(LossOfMessages_Signal_S);
				LossOfMessages_Signal_A.AddOwnedReception(LossOfMessages_Signal_A_S);
			LossOfMessages_Signal.AddPackagedElement(LossOfMessages_Signal_A);
				// Signal S
				LossOfMessages_Signal_S.SetName("S");
				LossOfMessages_Signal_S.SetVisibility(VisibilityKind.public_);
				
					// Property v
					LossOfMessages_Signal_S_v.SetName("v");
					LossOfMessages_Signal_S_v.SetVisibility(VisibilityKind.public_);
					
					LossOfMessages_Signal_S_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
				LossOfMessages_Signal_S.AddOwnedAttribute(LossOfMessages_Signal_S_v);
			LossOfMessages_Signal.AddPackagedElement(LossOfMessages_Signal_S);
				// SignalEvent SignalEventS
				LossOfMessages_Signal_SignalEventS.SetName("SignalEventS");
				LossOfMessages_Signal_SignalEventS.SetVisibility(VisibilityKind.public_);
				LossOfMessages_Signal_SignalEventS.SetSignal(LossOfMessages_Signal_S);
			LossOfMessages_Signal.AddPackagedElement(LossOfMessages_Signal_SignalEventS);
				// Activity main
				LossOfMessages_Signal_main.SetName("main");
				LossOfMessages_Signal_main.SetVisibility(VisibilityKind.public_);
				// FunctionBehavior testP
					LossOfMessages_Signal_main_testP.SetName("testP");
					LossOfMessages_Signal_main_testP.SetVisibility(VisibilityKind.public_);
					
						// Parameter p
						LossOfMessages_Signal_main_testP_p.SetName("p");
						LossOfMessages_Signal_main_testP_p.SetVisibility(VisibilityKind.public_);
						
						LossOfMessages_Signal_main_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					LossOfMessages_Signal_main_testP.AddOwnedParameter(LossOfMessages_Signal_main_testP_p);
					LossOfMessages_Signal_main_testP.AddLanguage("C#");
					LossOfMessages_Signal_main_testP.AddLanguage("Using");
					LossOfMessages_Signal_main_testP.AddBody("Console.WriteLine(\"Asserting a.p != 4\");  	// Test parameter p 	int p = ((IntegerValue)inputParameters.ElementAt(0).values.ElementAt(0)).value; 	Debug.Println(\"[doBody] argument p = \" + p); 	 	Console.WriteLine(\"a.p == == \" + p); 	Console.Write(\"Signal lost: \");  	if(p == 4) 	{ 		Console.ForegroundColor = ConsoleColor.Green; 		Console.WriteLine(\"Assertion successful.\"); 	} 	else 	{ 		Console.ForegroundColor = ConsoleColor.Red; 		Console.WriteLine(\"Assertion failed!\"); 	}  	Console.ResetColor();");
					LossOfMessages_Signal_main_testP.AddBody("using fuml.semantics.simpleclassifiers; ");
				LossOfMessages_Signal_main.AddOwnedBehavior(LossOfMessages_Signal_main_testP);
					// ValueSpecificationAction Value 4
					LossOfMessages_Signal_main_Value_4.SetName("Value 4");
					LossOfMessages_Signal_main_Value_4.SetVisibility(VisibilityKind.public_);
						// LiteralInteger LiteralInteger51
						LossOfMessages_Signal_main_Value_4_LiteralInteger51.SetName("LiteralInteger51");
						LossOfMessages_Signal_main_Value_4_LiteralInteger51.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Signal_main_Value_4_LiteralInteger51.SetValue(4);
					LossOfMessages_Signal_main_Value_4.SetValue(LossOfMessages_Signal_main_Value_4_LiteralInteger51);
						// OutputPin result
						LossOfMessages_Signal_main_Value_4_result.SetName("result");
						LossOfMessages_Signal_main_Value_4_result.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Signal_main_Value_4_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					LossOfMessages_Signal_main_Value_4.SetResult(LossOfMessages_Signal_main_Value_4_result);
				LossOfMessages_Signal_main.AddNode(LossOfMessages_Signal_main_Value_4);
					// ForkNode Fork A
					LossOfMessages_Signal_main_Fork_A.SetName("Fork A");
					LossOfMessages_Signal_main_Fork_A.SetVisibility(VisibilityKind.public_);
				LossOfMessages_Signal_main.AddNode(LossOfMessages_Signal_main_Fork_A);
					// CreateObjectAction Create A
					LossOfMessages_Signal_main_Create_A.SetName("Create A");
					LossOfMessages_Signal_main_Create_A.SetVisibility(VisibilityKind.public_);
					LossOfMessages_Signal_main_Create_A.SetClassifier(LossOfMessages_Signal_A);
						// OutputPin result
						LossOfMessages_Signal_main_Create_A_result.SetName("result");
						LossOfMessages_Signal_main_Create_A_result.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Signal_main_Create_A_result.SetType(LossOfMessages_Signal_A);
					LossOfMessages_Signal_main_Create_A.SetResult(LossOfMessages_Signal_main_Create_A_result);
				LossOfMessages_Signal_main.AddNode(LossOfMessages_Signal_main_Create_A);
					// CallOperationAction A()
					LossOfMessages_Signal_main_A_.SetName("A()");
					LossOfMessages_Signal_main_A_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						LossOfMessages_Signal_main_A__result.SetName("result");
						LossOfMessages_Signal_main_A__result.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Signal_main_A__result.SetType(LossOfMessages_Signal_A);
					LossOfMessages_Signal_main_A_.AddResult(LossOfMessages_Signal_main_A__result);
					LossOfMessages_Signal_main_A_.SetOperation(LossOfMessages_Signal_A_A_A);
						// InputPin target
						LossOfMessages_Signal_main_A__target.SetName("target");
						LossOfMessages_Signal_main_A__target.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Signal_main_A__target.SetType(LossOfMessages_Signal_A);
					LossOfMessages_Signal_main_A_.SetTarget(LossOfMessages_Signal_main_A__target);
				LossOfMessages_Signal_main.AddNode(LossOfMessages_Signal_main_A_);
					// ReadStructuralFeatureAction Read a.q
					LossOfMessages_Signal_main_Read_a_q.SetName("Read a.q");
					LossOfMessages_Signal_main_Read_a_q.SetVisibility(VisibilityKind.public_);
					LossOfMessages_Signal_main_Read_a_q.SetStructuralFeature(LossOfMessages_Signal_A_q);
						// InputPin object
						LossOfMessages_Signal_main_Read_a_q_object.SetName("object");
						LossOfMessages_Signal_main_Read_a_q_object.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Signal_main_Read_a_q_object.SetType(LossOfMessages_Signal_A);
					LossOfMessages_Signal_main_Read_a_q.SetObject(LossOfMessages_Signal_main_Read_a_q_object);
						// OutputPin result
						LossOfMessages_Signal_main_Read_a_q_result.SetName("result");
						LossOfMessages_Signal_main_Read_a_q_result.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Signal_main_Read_a_q_result.SetType(LossOfMessages_Signal_I);
					LossOfMessages_Signal_main_Read_a_q.SetResult(LossOfMessages_Signal_main_Read_a_q_result);
				LossOfMessages_Signal_main.AddNode(LossOfMessages_Signal_main_Read_a_q);
					// CallBehaviorAction Call testP
					LossOfMessages_Signal_main_Call_testP.SetName("Call testP");
					LossOfMessages_Signal_main_Call_testP.SetVisibility(VisibilityKind.public_);
					LossOfMessages_Signal_main_Call_testP.SetBehavior(LossOfMessages_Signal_main_testP);
						// InputPin p
						LossOfMessages_Signal_main_Call_testP_p.SetName("p");
						LossOfMessages_Signal_main_Call_testP_p.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Signal_main_Call_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					LossOfMessages_Signal_main_Call_testP.AddArgument(LossOfMessages_Signal_main_Call_testP_p);
				LossOfMessages_Signal_main.AddNode(LossOfMessages_Signal_main_Call_testP);
					// ReadStructuralFeatureAction Read a.p
					LossOfMessages_Signal_main_Read_a_p.SetName("Read a.p");
					LossOfMessages_Signal_main_Read_a_p.SetVisibility(VisibilityKind.public_);
					LossOfMessages_Signal_main_Read_a_p.SetStructuralFeature(LossOfMessages_Signal_A_p);
						// InputPin object
						LossOfMessages_Signal_main_Read_a_p_object.SetName("object");
						LossOfMessages_Signal_main_Read_a_p_object.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Signal_main_Read_a_p_object.SetType(LossOfMessages_Signal_A);
					LossOfMessages_Signal_main_Read_a_p.SetObject(LossOfMessages_Signal_main_Read_a_p_object);
						// OutputPin result
						LossOfMessages_Signal_main_Read_a_p_result.SetName("result");
						LossOfMessages_Signal_main_Read_a_p_result.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Signal_main_Read_a_p_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					LossOfMessages_Signal_main_Read_a_p.SetResult(LossOfMessages_Signal_main_Read_a_p_result);
				LossOfMessages_Signal_main.AddNode(LossOfMessages_Signal_main_Read_a_p);
					// SendSignalAction Send S
					LossOfMessages_Signal_main_Send_S.SetName("Send S");
					LossOfMessages_Signal_main_Send_S.SetVisibility(VisibilityKind.public_);
					LossOfMessages_Signal_main_Send_S.SetSignal(LossOfMessages_Signal_S);
						// InputPin target
						LossOfMessages_Signal_main_Send_S_target.SetName("target");
						LossOfMessages_Signal_main_Send_S_target.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Signal_main_Send_S_target.SetType(LossOfMessages_Signal_IImpl);
					LossOfMessages_Signal_main_Send_S.SetTarget(LossOfMessages_Signal_main_Send_S_target);
						// InputPin v
						LossOfMessages_Signal_main_Send_S_v.SetName("v");
						LossOfMessages_Signal_main_Send_S_v.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Signal_main_Send_S_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					LossOfMessages_Signal_main_Send_S.AddArgument(LossOfMessages_Signal_main_Send_S_v);
				LossOfMessages_Signal_main.AddNode(LossOfMessages_Signal_main_Send_S);
					// ControlFlow ControlFlow48 from Send S to Read a.p
					LossOfMessages_Signal_main_ControlFlow48.SetName("ControlFlow48");
					LossOfMessages_Signal_main_ControlFlow48.SetVisibility(VisibilityKind.public_);
					
					LossOfMessages_Signal_main_ControlFlow48.SetSource(LossOfMessages_Signal_main_Send_S);
					LossOfMessages_Signal_main_ControlFlow48.SetTarget(LossOfMessages_Signal_main_Read_a_p);
				LossOfMessages_Signal_main.AddEdge(LossOfMessages_Signal_main_ControlFlow48);
					// ObjectFlow ObjectFlow27 from result to target
					LossOfMessages_Signal_main_ObjectFlow27.SetName("ObjectFlow27");
					LossOfMessages_Signal_main_ObjectFlow27.SetVisibility(VisibilityKind.public_);
					
					LossOfMessages_Signal_main_ObjectFlow27.SetSource(LossOfMessages_Signal_main_Create_A_result);
					LossOfMessages_Signal_main_ObjectFlow27.SetTarget(LossOfMessages_Signal_main_A__target);
						// LiteralBoolean LiteralBoolean29
						LossOfMessages_Signal_main_ObjectFlow27_LiteralBoolean29.SetName("LiteralBoolean29");
						LossOfMessages_Signal_main_ObjectFlow27_LiteralBoolean29.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Signal_main_ObjectFlow27_LiteralBoolean29.SetValue(true);
					LossOfMessages_Signal_main_ObjectFlow27.SetGuard(LossOfMessages_Signal_main_ObjectFlow27_LiteralBoolean29);
				LossOfMessages_Signal_main.AddEdge(LossOfMessages_Signal_main_ObjectFlow27);
					// ObjectFlow ObjectFlow30 from Fork A to object
					LossOfMessages_Signal_main_ObjectFlow30.SetName("ObjectFlow30");
					LossOfMessages_Signal_main_ObjectFlow30.SetVisibility(VisibilityKind.public_);
					
					LossOfMessages_Signal_main_ObjectFlow30.SetSource(LossOfMessages_Signal_main_Fork_A);
					LossOfMessages_Signal_main_ObjectFlow30.SetTarget(LossOfMessages_Signal_main_Read_a_q_object);
						// LiteralBoolean LiteralBoolean32
						LossOfMessages_Signal_main_ObjectFlow30_LiteralBoolean32.SetName("LiteralBoolean32");
						LossOfMessages_Signal_main_ObjectFlow30_LiteralBoolean32.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Signal_main_ObjectFlow30_LiteralBoolean32.SetValue(true);
					LossOfMessages_Signal_main_ObjectFlow30.SetGuard(LossOfMessages_Signal_main_ObjectFlow30_LiteralBoolean32);
				LossOfMessages_Signal_main.AddEdge(LossOfMessages_Signal_main_ObjectFlow30);
					// ObjectFlow ObjectFlow33 from result to target
					LossOfMessages_Signal_main_ObjectFlow33.SetName("ObjectFlow33");
					LossOfMessages_Signal_main_ObjectFlow33.SetVisibility(VisibilityKind.public_);
					
					LossOfMessages_Signal_main_ObjectFlow33.SetSource(LossOfMessages_Signal_main_Read_a_q_result);
					LossOfMessages_Signal_main_ObjectFlow33.SetTarget(LossOfMessages_Signal_main_Send_S_target);
						// LiteralBoolean LiteralBoolean35
						LossOfMessages_Signal_main_ObjectFlow33_LiteralBoolean35.SetName("LiteralBoolean35");
						LossOfMessages_Signal_main_ObjectFlow33_LiteralBoolean35.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Signal_main_ObjectFlow33_LiteralBoolean35.SetValue(true);
					LossOfMessages_Signal_main_ObjectFlow33.SetGuard(LossOfMessages_Signal_main_ObjectFlow33_LiteralBoolean35);
				LossOfMessages_Signal_main.AddEdge(LossOfMessages_Signal_main_ObjectFlow33);
					// ObjectFlow ObjectFlow36 from result to v
					LossOfMessages_Signal_main_ObjectFlow36.SetName("ObjectFlow36");
					LossOfMessages_Signal_main_ObjectFlow36.SetVisibility(VisibilityKind.public_);
					
					LossOfMessages_Signal_main_ObjectFlow36.SetSource(LossOfMessages_Signal_main_Value_4_result);
					LossOfMessages_Signal_main_ObjectFlow36.SetTarget(LossOfMessages_Signal_main_Send_S_v);
						// LiteralBoolean LiteralBoolean38
						LossOfMessages_Signal_main_ObjectFlow36_LiteralBoolean38.SetName("LiteralBoolean38");
						LossOfMessages_Signal_main_ObjectFlow36_LiteralBoolean38.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Signal_main_ObjectFlow36_LiteralBoolean38.SetValue(true);
					LossOfMessages_Signal_main_ObjectFlow36.SetGuard(LossOfMessages_Signal_main_ObjectFlow36_LiteralBoolean38);
				LossOfMessages_Signal_main.AddEdge(LossOfMessages_Signal_main_ObjectFlow36);
					// ObjectFlow ObjectFlow52 from result to Fork A
					LossOfMessages_Signal_main_ObjectFlow52.SetName("ObjectFlow52");
					LossOfMessages_Signal_main_ObjectFlow52.SetVisibility(VisibilityKind.public_);
					
					LossOfMessages_Signal_main_ObjectFlow52.SetSource(LossOfMessages_Signal_main_A__result);
					LossOfMessages_Signal_main_ObjectFlow52.SetTarget(LossOfMessages_Signal_main_Fork_A);
						// LiteralBoolean LiteralBoolean53
						LossOfMessages_Signal_main_ObjectFlow52_LiteralBoolean53.SetName("LiteralBoolean53");
						LossOfMessages_Signal_main_ObjectFlow52_LiteralBoolean53.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Signal_main_ObjectFlow52_LiteralBoolean53.SetValue(true);
					LossOfMessages_Signal_main_ObjectFlow52.SetGuard(LossOfMessages_Signal_main_ObjectFlow52_LiteralBoolean53);
				LossOfMessages_Signal_main.AddEdge(LossOfMessages_Signal_main_ObjectFlow52);
					// ObjectFlow ObjectFlow64 from Fork A to object
					LossOfMessages_Signal_main_ObjectFlow64.SetName("ObjectFlow64");
					LossOfMessages_Signal_main_ObjectFlow64.SetVisibility(VisibilityKind.public_);
					
					LossOfMessages_Signal_main_ObjectFlow64.SetSource(LossOfMessages_Signal_main_Fork_A);
					LossOfMessages_Signal_main_ObjectFlow64.SetTarget(LossOfMessages_Signal_main_Read_a_p_object);
						// LiteralBoolean LiteralBoolean65
						LossOfMessages_Signal_main_ObjectFlow64_LiteralBoolean65.SetName("LiteralBoolean65");
						LossOfMessages_Signal_main_ObjectFlow64_LiteralBoolean65.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Signal_main_ObjectFlow64_LiteralBoolean65.SetValue(true);
					LossOfMessages_Signal_main_ObjectFlow64.SetGuard(LossOfMessages_Signal_main_ObjectFlow64_LiteralBoolean65);
				LossOfMessages_Signal_main.AddEdge(LossOfMessages_Signal_main_ObjectFlow64);
					// ObjectFlow ObjectFlow67 from result to p
					LossOfMessages_Signal_main_ObjectFlow67.SetName("ObjectFlow67");
					LossOfMessages_Signal_main_ObjectFlow67.SetVisibility(VisibilityKind.public_);
					
					LossOfMessages_Signal_main_ObjectFlow67.SetSource(LossOfMessages_Signal_main_Read_a_p_result);
					LossOfMessages_Signal_main_ObjectFlow67.SetTarget(LossOfMessages_Signal_main_Call_testP_p);
						// LiteralBoolean LiteralBoolean69
						LossOfMessages_Signal_main_ObjectFlow67_LiteralBoolean69.SetName("LiteralBoolean69");
						LossOfMessages_Signal_main_ObjectFlow67_LiteralBoolean69.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Signal_main_ObjectFlow67_LiteralBoolean69.SetValue(true);
					LossOfMessages_Signal_main_ObjectFlow67.SetGuard(LossOfMessages_Signal_main_ObjectFlow67_LiteralBoolean69);
				LossOfMessages_Signal_main.AddEdge(LossOfMessages_Signal_main_ObjectFlow67);
			LossOfMessages_Signal.AddPackagedElement(LossOfMessages_Signal_main);
				// Class IImpl
				LossOfMessages_Signal_IImpl.SetName("IImpl");
				LossOfMessages_Signal_IImpl.SetVisibility(VisibilityKind.public_);
				LossOfMessages_Signal_IImpl_IRealization.SetName("IRealization");
					LossOfMessages_Signal_IImpl_IRealization.SetVisibility(VisibilityKind.public_);
					LossOfMessages_Signal_IImpl_IRealization.SetContract(LossOfMessages_Signal_I);
					
				LossOfMessages_Signal_IImpl.AddInterfaceRealization(LossOfMessages_Signal_IImpl_IRealization);
				
					// Reception S
					LossOfMessages_Signal_IImpl_S.SetName("S");
					LossOfMessages_Signal_IImpl_S.SetVisibility(VisibilityKind.public_);
					LossOfMessages_Signal_IImpl_S.SetSignal(LossOfMessages_Signal_S);
				LossOfMessages_Signal_IImpl.AddOwnedReception(LossOfMessages_Signal_IImpl_S);
			LossOfMessages_Signal.AddPackagedElement(LossOfMessages_Signal_IImpl);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // LossOfMessages_SignalModel
}
