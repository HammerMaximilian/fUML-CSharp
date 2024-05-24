/*
 * SingleDelegation_P_P_OperationModel.cs
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

namespace SingleDelegation_P_P_Operation
{
	public class SingleDelegation_P_P_OperationModel : InMemoryModel
	{
		private static SingleDelegation_P_P_OperationModel? instance;

		/*
		 * Model SingleDelegation_P_P_Operation
		 */
		public Package SingleDelegation_P_P_Operation = new();
			public Class_ SingleDelegation_P_P_Operation_IImpl = new();
				public InterfaceRealization SingleDelegation_P_P_Operation_IImpl_IRealization = new();
				public Operation SingleDelegation_P_P_Operation_IImpl_setP_Integer = new();
					public Parameter SingleDelegation_P_P_Operation_IImpl_setP_Integer_v = new();
			public Association SingleDelegation_P_P_Operation_R = new();
				public Property SingleDelegation_P_P_Operation_R_y = new();
				public Property SingleDelegation_P_P_Operation_R_x = new();
			public Class_ SingleDelegation_P_P_Operation_B = new();
				public Operation SingleDelegation_P_P_Operation_B_setP_Integer = new();
					public Parameter SingleDelegation_P_P_Operation_B_setP_Integer_v = new();
				public Activity SingleDelegation_P_P_Operation_B_setPActivity = new();
					public ObjectFlow SingleDelegation_P_P_Operation_B_setPActivity_ObjectFlow0 = new();
						public LiteralBoolean SingleDelegation_P_P_Operation_B_setPActivity_ObjectFlow0_LiteralBoolean1 = new();
						public LiteralInteger SingleDelegation_P_P_Operation_B_setPActivity_ObjectFlow0_LiteralInteger2 = new();
					public ActivityParameterNode SingleDelegation_P_P_Operation_B_setPActivity_vParameterNode = new();
						public LiteralInteger SingleDelegation_P_P_Operation_B_setPActivity_vParameterNode_LiteralInteger3 = new();
					public ObjectFlow SingleDelegation_P_P_Operation_B_setPActivity_ObjectFlow4 = new();
						public LiteralInteger SingleDelegation_P_P_Operation_B_setPActivity_ObjectFlow4_LiteralInteger5 = new();
						public LiteralBoolean SingleDelegation_P_P_Operation_B_setPActivity_ObjectFlow4_LiteralBoolean6 = new();
					public ReadSelfAction SingleDelegation_P_P_Operation_B_setPActivity_this = new();
						public OutputPin SingleDelegation_P_P_Operation_B_setPActivity_this_result = new();
							public LiteralInteger SingleDelegation_P_P_Operation_B_setPActivity_this_result_LiteralInteger7 = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Operation_B_setPActivity_this_result_LiteralUnlimitedNatural8 = new();
					public AddStructuralFeatureValueAction SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p = new();
						public InputPin SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p_value = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p_value_LiteralUnlimitedNatural9 = new();
							public LiteralInteger SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p_value_LiteralInteger10 = new();
						public InputPin SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p_object = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p_object_LiteralUnlimitedNatural11 = new();
							public LiteralInteger SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p_object_LiteralInteger12 = new();
						public OutputPin SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p_result = new();
							public LiteralInteger SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p_result_LiteralInteger13 = new();
							public LiteralUnlimitedNatural SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p_result_LiteralUnlimitedNatural14 = new();
					public Parameter SingleDelegation_P_P_Operation_B_setPActivity_v = new();
				public Property SingleDelegation_P_P_Operation_B_p = new();
				public Operation SingleDelegation_P_P_Operation_B_B_B = new();
					public Parameter SingleDelegation_P_P_Operation_B_B_B_result = new();
				public InterfaceRealization SingleDelegation_P_P_Operation_B_IRealization = new();
			public Class_ SingleDelegation_P_P_Operation_A = new();
				public Property SingleDelegation_P_P_Operation_A_b = new();
				public Connector SingleDelegation_P_P_Operation_A_r = new();
					public ConnectorEnd SingleDelegation_P_P_Operation_A_r_ConnectorEnd15 = new();
					public ConnectorEnd SingleDelegation_P_P_Operation_A_r_ConnectorEnd16 = new();
				public Operation SingleDelegation_P_P_Operation_A_A_A = new();
					public Parameter SingleDelegation_P_P_Operation_A_A_A_result = new();
				public Port SingleDelegation_P_P_Operation_A_q = new();
			public Interface SingleDelegation_P_P_Operation_I = new();
				public Operation SingleDelegation_P_P_Operation_I_setP_Integer = new();
					public Parameter SingleDelegation_P_P_Operation_I_setP_Integer_v = new();
			public Activity SingleDelegation_P_P_Operation_main = new();
				public ReadStructuralFeatureAction SingleDelegation_P_P_Operation_main_Read_a_b_p = new();
					public InputPin SingleDelegation_P_P_Operation_main_Read_a_b_p_object = new();
						public LiteralInteger SingleDelegation_P_P_Operation_main_Read_a_b_p_object_LiteralInteger17 = new();
						public LiteralUnlimitedNatural SingleDelegation_P_P_Operation_main_Read_a_b_p_object_LiteralUnlimitedNatural18 = new();
					public OutputPin SingleDelegation_P_P_Operation_main_Read_a_b_p_result = new();
						public LiteralUnlimitedNatural SingleDelegation_P_P_Operation_main_Read_a_b_p_result_LiteralUnlimitedNatural19 = new();
						public LiteralInteger SingleDelegation_P_P_Operation_main_Read_a_b_p_result_LiteralInteger20 = new();
				public ControlFlow SingleDelegation_P_P_Operation_main_ControlFlow21 = new();
				public ObjectFlow SingleDelegation_P_P_Operation_main_ObjectFlow22 = new();
					public LiteralBoolean SingleDelegation_P_P_Operation_main_ObjectFlow22_LiteralBoolean23 = new();
					public LiteralInteger SingleDelegation_P_P_Operation_main_ObjectFlow22_LiteralInteger24 = new();
				public CallBehaviorAction SingleDelegation_P_P_Operation_main_Call_testP = new();
					public InputPin SingleDelegation_P_P_Operation_main_Call_testP_p = new();
						public LiteralInteger SingleDelegation_P_P_Operation_main_Call_testP_p_LiteralInteger25 = new();
						public LiteralInteger SingleDelegation_P_P_Operation_main_Call_testP_p_LiteralInteger26 = new();
						public LiteralUnlimitedNatural SingleDelegation_P_P_Operation_main_Call_testP_p_LiteralUnlimitedNatural27 = new();
				public CallBehaviorAction SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage = new();
					public OutputPin SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage_errorStatus = new();
						public LiteralInteger SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage_errorStatus_LiteralInteger28 = new();
						public LiteralUnlimitedNatural SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage_errorStatus_LiteralUnlimitedNatural29 = new();
						public LiteralInteger SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage_errorStatus_LiteralInteger30 = new();
					public InputPin SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage_value = new();
						public LiteralUnlimitedNatural SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage_value_LiteralUnlimitedNatural31 = new();
						public LiteralInteger SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage_value_LiteralInteger32 = new();
						public LiteralInteger SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage_value_LiteralInteger33 = new();
				public ObjectFlow SingleDelegation_P_P_Operation_main_ObjectFlow34 = new();
					public LiteralBoolean SingleDelegation_P_P_Operation_main_ObjectFlow34_LiteralBoolean35 = new();
					public LiteralInteger SingleDelegation_P_P_Operation_main_ObjectFlow34_LiteralInteger36 = new();
				public ControlFlow SingleDelegation_P_P_Operation_main_ControlFlow37 = new();
				public ReadStructuralFeatureAction SingleDelegation_P_P_Operation_main_Read_a_q = new();
					public OutputPin SingleDelegation_P_P_Operation_main_Read_a_q_result = new();
						public LiteralInteger SingleDelegation_P_P_Operation_main_Read_a_q_result_LiteralInteger38 = new();
						public LiteralUnlimitedNatural SingleDelegation_P_P_Operation_main_Read_a_q_result_LiteralUnlimitedNatural39 = new();
					public InputPin SingleDelegation_P_P_Operation_main_Read_a_q_object = new();
						public LiteralUnlimitedNatural SingleDelegation_P_P_Operation_main_Read_a_q_object_LiteralUnlimitedNatural40 = new();
						public LiteralInteger SingleDelegation_P_P_Operation_main_Read_a_q_object_LiteralInteger41 = new();
				public ValueSpecificationAction SingleDelegation_P_P_Operation_main_InitialMessage = new();
					public OutputPin SingleDelegation_P_P_Operation_main_InitialMessage_result = new();
						public LiteralInteger SingleDelegation_P_P_Operation_main_InitialMessage_result_LiteralInteger42 = new();
						public LiteralUnlimitedNatural SingleDelegation_P_P_Operation_main_InitialMessage_result_LiteralUnlimitedNatural43 = new();
					public LiteralString SingleDelegation_P_P_Operation_main_InitialMessage_LiteralString44 = new();
				public ForkNode SingleDelegation_P_P_Operation_main_Fork_A = new();
				public ObjectFlow SingleDelegation_P_P_Operation_main_ObjectFlow45 = new();
					public LiteralInteger SingleDelegation_P_P_Operation_main_ObjectFlow45_LiteralInteger46 = new();
					public LiteralBoolean SingleDelegation_P_P_Operation_main_ObjectFlow45_LiteralBoolean47 = new();
				public CallBehaviorAction SingleDelegation_P_P_Operation_main_WriteLine_EndMessage = new();
					public InputPin SingleDelegation_P_P_Operation_main_WriteLine_EndMessage_value = new();
						public LiteralInteger SingleDelegation_P_P_Operation_main_WriteLine_EndMessage_value_LiteralInteger48 = new();
						public LiteralInteger SingleDelegation_P_P_Operation_main_WriteLine_EndMessage_value_LiteralInteger49 = new();
						public LiteralUnlimitedNatural SingleDelegation_P_P_Operation_main_WriteLine_EndMessage_value_LiteralUnlimitedNatural50 = new();
					public OutputPin SingleDelegation_P_P_Operation_main_WriteLine_EndMessage_errorStatus = new();
						public LiteralInteger SingleDelegation_P_P_Operation_main_WriteLine_EndMessage_errorStatus_LiteralInteger51 = new();
						public LiteralInteger SingleDelegation_P_P_Operation_main_WriteLine_EndMessage_errorStatus_LiteralInteger52 = new();
						public LiteralUnlimitedNatural SingleDelegation_P_P_Operation_main_WriteLine_EndMessage_errorStatus_LiteralUnlimitedNatural53 = new();
				public CallOperationAction SingleDelegation_P_P_Operation_main_A_ = new();
					public OutputPin SingleDelegation_P_P_Operation_main_A__result = new();
						public LiteralUnlimitedNatural SingleDelegation_P_P_Operation_main_A__result_LiteralUnlimitedNatural54 = new();
						public LiteralInteger SingleDelegation_P_P_Operation_main_A__result_LiteralInteger55 = new();
						public LiteralInteger SingleDelegation_P_P_Operation_main_A__result_LiteralInteger56 = new();
					public InputPin SingleDelegation_P_P_Operation_main_A__target = new();
						public LiteralInteger SingleDelegation_P_P_Operation_main_A__target_LiteralInteger57 = new();
						public LiteralUnlimitedNatural SingleDelegation_P_P_Operation_main_A__target_LiteralUnlimitedNatural58 = new();
				public ReadStructuralFeatureAction SingleDelegation_P_P_Operation_main_Read_a_b = new();
					public OutputPin SingleDelegation_P_P_Operation_main_Read_a_b_result = new();
						public LiteralUnlimitedNatural SingleDelegation_P_P_Operation_main_Read_a_b_result_LiteralUnlimitedNatural59 = new();
						public LiteralInteger SingleDelegation_P_P_Operation_main_Read_a_b_result_LiteralInteger60 = new();
					public InputPin SingleDelegation_P_P_Operation_main_Read_a_b_object = new();
						public LiteralUnlimitedNatural SingleDelegation_P_P_Operation_main_Read_a_b_object_LiteralUnlimitedNatural61 = new();
						public LiteralInteger SingleDelegation_P_P_Operation_main_Read_a_b_object_LiteralInteger62 = new();
				public ObjectFlow SingleDelegation_P_P_Operation_main_ObjectFlow63 = new();
					public LiteralBoolean SingleDelegation_P_P_Operation_main_ObjectFlow63_LiteralBoolean64 = new();
					public LiteralInteger SingleDelegation_P_P_Operation_main_ObjectFlow63_LiteralInteger65 = new();
				public ObjectFlow SingleDelegation_P_P_Operation_main_ObjectFlow66 = new();
					public LiteralBoolean SingleDelegation_P_P_Operation_main_ObjectFlow66_LiteralBoolean67 = new();
					public LiteralInteger SingleDelegation_P_P_Operation_main_ObjectFlow66_LiteralInteger68 = new();
				public ValueSpecificationAction SingleDelegation_P_P_Operation_main_Value_4 = new();
					public OutputPin SingleDelegation_P_P_Operation_main_Value_4_result = new();
						public LiteralInteger SingleDelegation_P_P_Operation_main_Value_4_result_LiteralInteger69 = new();
						public LiteralUnlimitedNatural SingleDelegation_P_P_Operation_main_Value_4_result_LiteralUnlimitedNatural70 = new();
					public LiteralInteger SingleDelegation_P_P_Operation_main_Value_4_LiteralInteger71 = new();
				public ObjectFlow SingleDelegation_P_P_Operation_main_ObjectFlow72 = new();
					public LiteralInteger SingleDelegation_P_P_Operation_main_ObjectFlow72_LiteralInteger73 = new();
					public LiteralBoolean SingleDelegation_P_P_Operation_main_ObjectFlow72_LiteralBoolean74 = new();
				public ObjectFlow SingleDelegation_P_P_Operation_main_ObjectFlow75 = new();
					public LiteralInteger SingleDelegation_P_P_Operation_main_ObjectFlow75_LiteralInteger76 = new();
					public LiteralBoolean SingleDelegation_P_P_Operation_main_ObjectFlow75_LiteralBoolean77 = new();
				public ObjectFlow SingleDelegation_P_P_Operation_main_ObjectFlow78 = new();
					public LiteralInteger SingleDelegation_P_P_Operation_main_ObjectFlow78_LiteralInteger79 = new();
					public LiteralBoolean SingleDelegation_P_P_Operation_main_ObjectFlow78_LiteralBoolean80 = new();
				public ControlFlow SingleDelegation_P_P_Operation_main_ControlFlow81 = new();
				public ObjectFlow SingleDelegation_P_P_Operation_main_ObjectFlow82 = new();
					public LiteralInteger SingleDelegation_P_P_Operation_main_ObjectFlow82_LiteralInteger83 = new();
					public LiteralBoolean SingleDelegation_P_P_Operation_main_ObjectFlow82_LiteralBoolean84 = new();
				public CallOperationAction SingleDelegation_P_P_Operation_main_Call_a_q_setP = new();
					public InputPin SingleDelegation_P_P_Operation_main_Call_a_q_setP_v = new();
						public LiteralInteger SingleDelegation_P_P_Operation_main_Call_a_q_setP_v_LiteralInteger85 = new();
						public LiteralUnlimitedNatural SingleDelegation_P_P_Operation_main_Call_a_q_setP_v_LiteralUnlimitedNatural86 = new();
						public LiteralInteger SingleDelegation_P_P_Operation_main_Call_a_q_setP_v_LiteralInteger87 = new();
					public InputPin SingleDelegation_P_P_Operation_main_Call_a_q_setP_target = new();
						public LiteralInteger SingleDelegation_P_P_Operation_main_Call_a_q_setP_target_LiteralInteger88 = new();
						public LiteralUnlimitedNatural SingleDelegation_P_P_Operation_main_Call_a_q_setP_target_LiteralUnlimitedNatural89 = new();
				public OpaqueBehavior SingleDelegation_P_P_Operation_main_testP = new();
					public Parameter SingleDelegation_P_P_Operation_main_testP_p = new();
				public ValueSpecificationAction SingleDelegation_P_P_Operation_main_EndMessage = new();
					public OutputPin SingleDelegation_P_P_Operation_main_EndMessage_result = new();
						public LiteralUnlimitedNatural SingleDelegation_P_P_Operation_main_EndMessage_result_LiteralUnlimitedNatural90 = new();
						public LiteralInteger SingleDelegation_P_P_Operation_main_EndMessage_result_LiteralInteger91 = new();
					public LiteralString SingleDelegation_P_P_Operation_main_EndMessage_LiteralString92 = new();
				public CreateObjectAction SingleDelegation_P_P_Operation_main_Create_A = new();
					public OutputPin SingleDelegation_P_P_Operation_main_Create_A_result = new();
						public LiteralUnlimitedNatural SingleDelegation_P_P_Operation_main_Create_A_result_LiteralUnlimitedNatural93 = new();
						public LiteralInteger SingleDelegation_P_P_Operation_main_Create_A_result_LiteralInteger94 = new();
				public ObjectFlow SingleDelegation_P_P_Operation_main_ObjectFlow95 = new();
					public LiteralBoolean SingleDelegation_P_P_Operation_main_ObjectFlow95_LiteralBoolean96 = new();
					public LiteralInteger SingleDelegation_P_P_Operation_main_ObjectFlow95_LiteralInteger97 = new();

		public static SingleDelegation_P_P_OperationModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public SingleDelegation_P_P_OperationModel()
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
			 * Model SingleDelegation_P_P_Operation
			 */
			AddToElementRepository("SingleDelegation_P_P_Operation", SingleDelegation_P_P_Operation);
				AddToElementRepository("IImpl", SingleDelegation_P_P_Operation_IImpl);
					AddToElementRepository("IRealization", SingleDelegation_P_P_Operation_IImpl_IRealization);
					AddToElementRepository("setP_Integer", SingleDelegation_P_P_Operation_IImpl_setP_Integer);
						AddToElementRepository("v", SingleDelegation_P_P_Operation_IImpl_setP_Integer_v);
				AddToElementRepository("R", SingleDelegation_P_P_Operation_R);
					AddToElementRepository("y", SingleDelegation_P_P_Operation_R_y);
					AddToElementRepository("x", SingleDelegation_P_P_Operation_R_x);
				AddToElementRepository("B", SingleDelegation_P_P_Operation_B);
					AddToElementRepository("setP_Integer", SingleDelegation_P_P_Operation_B_setP_Integer);
						AddToElementRepository("v", SingleDelegation_P_P_Operation_B_setP_Integer_v);
					AddToElementRepository("setPActivity", SingleDelegation_P_P_Operation_B_setPActivity);
						AddToElementRepository("ObjectFlow0", SingleDelegation_P_P_Operation_B_setPActivity_ObjectFlow0);
							AddToElementRepository("LiteralBoolean1", SingleDelegation_P_P_Operation_B_setPActivity_ObjectFlow0_LiteralBoolean1);
							AddToElementRepository("LiteralInteger2", SingleDelegation_P_P_Operation_B_setPActivity_ObjectFlow0_LiteralInteger2);
						AddToElementRepository("vParameterNode", SingleDelegation_P_P_Operation_B_setPActivity_vParameterNode);
							AddToElementRepository("LiteralInteger3", SingleDelegation_P_P_Operation_B_setPActivity_vParameterNode_LiteralInteger3);
						AddToElementRepository("ObjectFlow4", SingleDelegation_P_P_Operation_B_setPActivity_ObjectFlow4);
							AddToElementRepository("LiteralInteger5", SingleDelegation_P_P_Operation_B_setPActivity_ObjectFlow4_LiteralInteger5);
							AddToElementRepository("LiteralBoolean6", SingleDelegation_P_P_Operation_B_setPActivity_ObjectFlow4_LiteralBoolean6);
						AddToElementRepository("this", SingleDelegation_P_P_Operation_B_setPActivity_this);
							AddToElementRepository("result", SingleDelegation_P_P_Operation_B_setPActivity_this_result);
								AddToElementRepository("LiteralInteger7", SingleDelegation_P_P_Operation_B_setPActivity_this_result_LiteralInteger7);
								AddToElementRepository("LiteralUnlimitedNatural8", SingleDelegation_P_P_Operation_B_setPActivity_this_result_LiteralUnlimitedNatural8);
						AddToElementRepository("Set this.p", SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p);
							AddToElementRepository("value", SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p_value);
								AddToElementRepository("LiteralUnlimitedNatural9", SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p_value_LiteralUnlimitedNatural9);
								AddToElementRepository("LiteralInteger10", SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p_value_LiteralInteger10);
							AddToElementRepository("object", SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p_object);
								AddToElementRepository("LiteralUnlimitedNatural11", SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p_object_LiteralUnlimitedNatural11);
								AddToElementRepository("LiteralInteger12", SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p_object_LiteralInteger12);
							AddToElementRepository("result", SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p_result);
								AddToElementRepository("LiteralInteger13", SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p_result_LiteralInteger13);
								AddToElementRepository("LiteralUnlimitedNatural14", SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p_result_LiteralUnlimitedNatural14);
						AddToElementRepository("v", SingleDelegation_P_P_Operation_B_setPActivity_v);
					AddToElementRepository("p", SingleDelegation_P_P_Operation_B_p);
					AddToElementRepository("B_B", SingleDelegation_P_P_Operation_B_B_B);
						AddToElementRepository("result", SingleDelegation_P_P_Operation_B_B_B_result);
					AddToElementRepository("IRealization", SingleDelegation_P_P_Operation_B_IRealization);
				AddToElementRepository("A", SingleDelegation_P_P_Operation_A);
					AddToElementRepository("b", SingleDelegation_P_P_Operation_A_b);
					AddToElementRepository("r", SingleDelegation_P_P_Operation_A_r);
						AddToElementRepository("ConnectorEnd15", SingleDelegation_P_P_Operation_A_r_ConnectorEnd15);
						AddToElementRepository("ConnectorEnd16", SingleDelegation_P_P_Operation_A_r_ConnectorEnd16);
					AddToElementRepository("A_A", SingleDelegation_P_P_Operation_A_A_A);
						AddToElementRepository("result", SingleDelegation_P_P_Operation_A_A_A_result);
					AddToElementRepository("q", SingleDelegation_P_P_Operation_A_q);
				AddToElementRepository("I", SingleDelegation_P_P_Operation_I);
					AddToElementRepository("setP_Integer", SingleDelegation_P_P_Operation_I_setP_Integer);
						AddToElementRepository("v", SingleDelegation_P_P_Operation_I_setP_Integer_v);
				AddToElementRepository("main", SingleDelegation_P_P_Operation_main);
					AddToElementRepository("Read a.b.p", SingleDelegation_P_P_Operation_main_Read_a_b_p);
						AddToElementRepository("object", SingleDelegation_P_P_Operation_main_Read_a_b_p_object);
							AddToElementRepository("LiteralInteger17", SingleDelegation_P_P_Operation_main_Read_a_b_p_object_LiteralInteger17);
							AddToElementRepository("LiteralUnlimitedNatural18", SingleDelegation_P_P_Operation_main_Read_a_b_p_object_LiteralUnlimitedNatural18);
						AddToElementRepository("result", SingleDelegation_P_P_Operation_main_Read_a_b_p_result);
							AddToElementRepository("LiteralUnlimitedNatural19", SingleDelegation_P_P_Operation_main_Read_a_b_p_result_LiteralUnlimitedNatural19);
							AddToElementRepository("LiteralInteger20", SingleDelegation_P_P_Operation_main_Read_a_b_p_result_LiteralInteger20);
					AddToElementRepository("ControlFlow21", SingleDelegation_P_P_Operation_main_ControlFlow21);
					AddToElementRepository("ObjectFlow22", SingleDelegation_P_P_Operation_main_ObjectFlow22);
						AddToElementRepository("LiteralBoolean23", SingleDelegation_P_P_Operation_main_ObjectFlow22_LiteralBoolean23);
						AddToElementRepository("LiteralInteger24", SingleDelegation_P_P_Operation_main_ObjectFlow22_LiteralInteger24);
					AddToElementRepository("Call testP", SingleDelegation_P_P_Operation_main_Call_testP);
						AddToElementRepository("p", SingleDelegation_P_P_Operation_main_Call_testP_p);
							AddToElementRepository("LiteralInteger25", SingleDelegation_P_P_Operation_main_Call_testP_p_LiteralInteger25);
							AddToElementRepository("LiteralInteger26", SingleDelegation_P_P_Operation_main_Call_testP_p_LiteralInteger26);
							AddToElementRepository("LiteralUnlimitedNatural27", SingleDelegation_P_P_Operation_main_Call_testP_p_LiteralUnlimitedNatural27);
					AddToElementRepository("WriteLine(InitialMessage)", SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage);
						AddToElementRepository("errorStatus", SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage_errorStatus);
							AddToElementRepository("LiteralInteger28", SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage_errorStatus_LiteralInteger28);
							AddToElementRepository("LiteralUnlimitedNatural29", SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage_errorStatus_LiteralUnlimitedNatural29);
							AddToElementRepository("LiteralInteger30", SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage_errorStatus_LiteralInteger30);
						AddToElementRepository("value", SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage_value);
							AddToElementRepository("LiteralUnlimitedNatural31", SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage_value_LiteralUnlimitedNatural31);
							AddToElementRepository("LiteralInteger32", SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage_value_LiteralInteger32);
							AddToElementRepository("LiteralInteger33", SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage_value_LiteralInteger33);
					AddToElementRepository("ObjectFlow34", SingleDelegation_P_P_Operation_main_ObjectFlow34);
						AddToElementRepository("LiteralBoolean35", SingleDelegation_P_P_Operation_main_ObjectFlow34_LiteralBoolean35);
						AddToElementRepository("LiteralInteger36", SingleDelegation_P_P_Operation_main_ObjectFlow34_LiteralInteger36);
					AddToElementRepository("ControlFlow37", SingleDelegation_P_P_Operation_main_ControlFlow37);
					AddToElementRepository("Read a.q", SingleDelegation_P_P_Operation_main_Read_a_q);
						AddToElementRepository("result", SingleDelegation_P_P_Operation_main_Read_a_q_result);
							AddToElementRepository("LiteralInteger38", SingleDelegation_P_P_Operation_main_Read_a_q_result_LiteralInteger38);
							AddToElementRepository("LiteralUnlimitedNatural39", SingleDelegation_P_P_Operation_main_Read_a_q_result_LiteralUnlimitedNatural39);
						AddToElementRepository("object", SingleDelegation_P_P_Operation_main_Read_a_q_object);
							AddToElementRepository("LiteralUnlimitedNatural40", SingleDelegation_P_P_Operation_main_Read_a_q_object_LiteralUnlimitedNatural40);
							AddToElementRepository("LiteralInteger41", SingleDelegation_P_P_Operation_main_Read_a_q_object_LiteralInteger41);
					AddToElementRepository("InitialMessage", SingleDelegation_P_P_Operation_main_InitialMessage);
						AddToElementRepository("result", SingleDelegation_P_P_Operation_main_InitialMessage_result);
							AddToElementRepository("LiteralInteger42", SingleDelegation_P_P_Operation_main_InitialMessage_result_LiteralInteger42);
							AddToElementRepository("LiteralUnlimitedNatural43", SingleDelegation_P_P_Operation_main_InitialMessage_result_LiteralUnlimitedNatural43);
						AddToElementRepository("LiteralString44", SingleDelegation_P_P_Operation_main_InitialMessage_LiteralString44);
					AddToElementRepository("Fork A", SingleDelegation_P_P_Operation_main_Fork_A);
					AddToElementRepository("ObjectFlow45", SingleDelegation_P_P_Operation_main_ObjectFlow45);
						AddToElementRepository("LiteralInteger46", SingleDelegation_P_P_Operation_main_ObjectFlow45_LiteralInteger46);
						AddToElementRepository("LiteralBoolean47", SingleDelegation_P_P_Operation_main_ObjectFlow45_LiteralBoolean47);
					AddToElementRepository("WriteLine(EndMessage)", SingleDelegation_P_P_Operation_main_WriteLine_EndMessage);
						AddToElementRepository("value", SingleDelegation_P_P_Operation_main_WriteLine_EndMessage_value);
							AddToElementRepository("LiteralInteger48", SingleDelegation_P_P_Operation_main_WriteLine_EndMessage_value_LiteralInteger48);
							AddToElementRepository("LiteralInteger49", SingleDelegation_P_P_Operation_main_WriteLine_EndMessage_value_LiteralInteger49);
							AddToElementRepository("LiteralUnlimitedNatural50", SingleDelegation_P_P_Operation_main_WriteLine_EndMessage_value_LiteralUnlimitedNatural50);
						AddToElementRepository("errorStatus", SingleDelegation_P_P_Operation_main_WriteLine_EndMessage_errorStatus);
							AddToElementRepository("LiteralInteger51", SingleDelegation_P_P_Operation_main_WriteLine_EndMessage_errorStatus_LiteralInteger51);
							AddToElementRepository("LiteralInteger52", SingleDelegation_P_P_Operation_main_WriteLine_EndMessage_errorStatus_LiteralInteger52);
							AddToElementRepository("LiteralUnlimitedNatural53", SingleDelegation_P_P_Operation_main_WriteLine_EndMessage_errorStatus_LiteralUnlimitedNatural53);
					AddToElementRepository("A()", SingleDelegation_P_P_Operation_main_A_);
						AddToElementRepository("result", SingleDelegation_P_P_Operation_main_A__result);
							AddToElementRepository("LiteralUnlimitedNatural54", SingleDelegation_P_P_Operation_main_A__result_LiteralUnlimitedNatural54);
							AddToElementRepository("LiteralInteger55", SingleDelegation_P_P_Operation_main_A__result_LiteralInteger55);
							AddToElementRepository("LiteralInteger56", SingleDelegation_P_P_Operation_main_A__result_LiteralInteger56);
						AddToElementRepository("target", SingleDelegation_P_P_Operation_main_A__target);
							AddToElementRepository("LiteralInteger57", SingleDelegation_P_P_Operation_main_A__target_LiteralInteger57);
							AddToElementRepository("LiteralUnlimitedNatural58", SingleDelegation_P_P_Operation_main_A__target_LiteralUnlimitedNatural58);
					AddToElementRepository("Read a.b", SingleDelegation_P_P_Operation_main_Read_a_b);
						AddToElementRepository("result", SingleDelegation_P_P_Operation_main_Read_a_b_result);
							AddToElementRepository("LiteralUnlimitedNatural59", SingleDelegation_P_P_Operation_main_Read_a_b_result_LiteralUnlimitedNatural59);
							AddToElementRepository("LiteralInteger60", SingleDelegation_P_P_Operation_main_Read_a_b_result_LiteralInteger60);
						AddToElementRepository("object", SingleDelegation_P_P_Operation_main_Read_a_b_object);
							AddToElementRepository("LiteralUnlimitedNatural61", SingleDelegation_P_P_Operation_main_Read_a_b_object_LiteralUnlimitedNatural61);
							AddToElementRepository("LiteralInteger62", SingleDelegation_P_P_Operation_main_Read_a_b_object_LiteralInteger62);
					AddToElementRepository("ObjectFlow63", SingleDelegation_P_P_Operation_main_ObjectFlow63);
						AddToElementRepository("LiteralBoolean64", SingleDelegation_P_P_Operation_main_ObjectFlow63_LiteralBoolean64);
						AddToElementRepository("LiteralInteger65", SingleDelegation_P_P_Operation_main_ObjectFlow63_LiteralInteger65);
					AddToElementRepository("ObjectFlow66", SingleDelegation_P_P_Operation_main_ObjectFlow66);
						AddToElementRepository("LiteralBoolean67", SingleDelegation_P_P_Operation_main_ObjectFlow66_LiteralBoolean67);
						AddToElementRepository("LiteralInteger68", SingleDelegation_P_P_Operation_main_ObjectFlow66_LiteralInteger68);
					AddToElementRepository("Value(4)", SingleDelegation_P_P_Operation_main_Value_4);
						AddToElementRepository("result", SingleDelegation_P_P_Operation_main_Value_4_result);
							AddToElementRepository("LiteralInteger69", SingleDelegation_P_P_Operation_main_Value_4_result_LiteralInteger69);
							AddToElementRepository("LiteralUnlimitedNatural70", SingleDelegation_P_P_Operation_main_Value_4_result_LiteralUnlimitedNatural70);
						AddToElementRepository("LiteralInteger71", SingleDelegation_P_P_Operation_main_Value_4_LiteralInteger71);
					AddToElementRepository("ObjectFlow72", SingleDelegation_P_P_Operation_main_ObjectFlow72);
						AddToElementRepository("LiteralInteger73", SingleDelegation_P_P_Operation_main_ObjectFlow72_LiteralInteger73);
						AddToElementRepository("LiteralBoolean74", SingleDelegation_P_P_Operation_main_ObjectFlow72_LiteralBoolean74);
					AddToElementRepository("ObjectFlow75", SingleDelegation_P_P_Operation_main_ObjectFlow75);
						AddToElementRepository("LiteralInteger76", SingleDelegation_P_P_Operation_main_ObjectFlow75_LiteralInteger76);
						AddToElementRepository("LiteralBoolean77", SingleDelegation_P_P_Operation_main_ObjectFlow75_LiteralBoolean77);
					AddToElementRepository("ObjectFlow78", SingleDelegation_P_P_Operation_main_ObjectFlow78);
						AddToElementRepository("LiteralInteger79", SingleDelegation_P_P_Operation_main_ObjectFlow78_LiteralInteger79);
						AddToElementRepository("LiteralBoolean80", SingleDelegation_P_P_Operation_main_ObjectFlow78_LiteralBoolean80);
					AddToElementRepository("ControlFlow81", SingleDelegation_P_P_Operation_main_ControlFlow81);
					AddToElementRepository("ObjectFlow82", SingleDelegation_P_P_Operation_main_ObjectFlow82);
						AddToElementRepository("LiteralInteger83", SingleDelegation_P_P_Operation_main_ObjectFlow82_LiteralInteger83);
						AddToElementRepository("LiteralBoolean84", SingleDelegation_P_P_Operation_main_ObjectFlow82_LiteralBoolean84);
					AddToElementRepository("Call a.q.setP", SingleDelegation_P_P_Operation_main_Call_a_q_setP);
						AddToElementRepository("v", SingleDelegation_P_P_Operation_main_Call_a_q_setP_v);
							AddToElementRepository("LiteralInteger85", SingleDelegation_P_P_Operation_main_Call_a_q_setP_v_LiteralInteger85);
							AddToElementRepository("LiteralUnlimitedNatural86", SingleDelegation_P_P_Operation_main_Call_a_q_setP_v_LiteralUnlimitedNatural86);
							AddToElementRepository("LiteralInteger87", SingleDelegation_P_P_Operation_main_Call_a_q_setP_v_LiteralInteger87);
						AddToElementRepository("target", SingleDelegation_P_P_Operation_main_Call_a_q_setP_target);
							AddToElementRepository("LiteralInteger88", SingleDelegation_P_P_Operation_main_Call_a_q_setP_target_LiteralInteger88);
							AddToElementRepository("LiteralUnlimitedNatural89", SingleDelegation_P_P_Operation_main_Call_a_q_setP_target_LiteralUnlimitedNatural89);
					AddToElementRepository("testP", SingleDelegation_P_P_Operation_main_testP);
						AddToElementRepository("p", SingleDelegation_P_P_Operation_main_testP_p);
					AddToElementRepository("EndMessage", SingleDelegation_P_P_Operation_main_EndMessage);
						AddToElementRepository("result", SingleDelegation_P_P_Operation_main_EndMessage_result);
							AddToElementRepository("LiteralUnlimitedNatural90", SingleDelegation_P_P_Operation_main_EndMessage_result_LiteralUnlimitedNatural90);
							AddToElementRepository("LiteralInteger91", SingleDelegation_P_P_Operation_main_EndMessage_result_LiteralInteger91);
						AddToElementRepository("LiteralString92", SingleDelegation_P_P_Operation_main_EndMessage_LiteralString92);
					AddToElementRepository("Create A", SingleDelegation_P_P_Operation_main_Create_A);
						AddToElementRepository("result", SingleDelegation_P_P_Operation_main_Create_A_result);
							AddToElementRepository("LiteralUnlimitedNatural93", SingleDelegation_P_P_Operation_main_Create_A_result_LiteralUnlimitedNatural93);
							AddToElementRepository("LiteralInteger94", SingleDelegation_P_P_Operation_main_Create_A_result_LiteralInteger94);
					AddToElementRepository("ObjectFlow95", SingleDelegation_P_P_Operation_main_ObjectFlow95);
						AddToElementRepository("LiteralBoolean96", SingleDelegation_P_P_Operation_main_ObjectFlow95_LiteralBoolean96);
						AddToElementRepository("LiteralInteger97", SingleDelegation_P_P_Operation_main_ObjectFlow95_LiteralInteger97);

			// Initialize public members
			/*
			 * Model SingleDelegation_P_P_Operation
			 */
			SingleDelegation_P_P_Operation.SetName("SingleDelegation_P_P_Operation");
			SingleDelegation_P_P_Operation.SetVisibility(VisibilityKind.public_);
				// Class IImpl
				SingleDelegation_P_P_Operation_IImpl.SetName("IImpl");
				SingleDelegation_P_P_Operation_IImpl.SetVisibility(VisibilityKind.public_);
				SingleDelegation_P_P_Operation_IImpl_IRealization.SetName("IRealization");
					SingleDelegation_P_P_Operation_IImpl_IRealization.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_P_Operation_IImpl_IRealization.SetContract(SingleDelegation_P_P_Operation_I);
					
				SingleDelegation_P_P_Operation_IImpl.AddInterfaceRealization(SingleDelegation_P_P_Operation_IImpl_IRealization);
				
					// Operation setP_Integer
					SingleDelegation_P_P_Operation_IImpl_setP_Integer.SetName("setP_Integer");
					SingleDelegation_P_P_Operation_IImpl_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						SingleDelegation_P_P_Operation_IImpl_setP_Integer_v.SetName("v");
						SingleDelegation_P_P_Operation_IImpl_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Operation_IImpl_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					SingleDelegation_P_P_Operation_IImpl_setP_Integer.AddOwnedParameter(SingleDelegation_P_P_Operation_IImpl_setP_Integer_v);
				SingleDelegation_P_P_Operation_IImpl.AddOwnedOperation(SingleDelegation_P_P_Operation_IImpl_setP_Integer);
			SingleDelegation_P_P_Operation.AddPackagedElement(SingleDelegation_P_P_Operation_IImpl);
				// Association R
				SingleDelegation_P_P_Operation_R.SetName("R");
				SingleDelegation_P_P_Operation_R.SetVisibility(VisibilityKind.public_);
				SingleDelegation_P_P_Operation_R.AddOwnedEnd(SingleDelegation_P_P_Operation_R_x);
				SingleDelegation_P_P_Operation_R.AddOwnedEnd(SingleDelegation_P_P_Operation_R_y);
			SingleDelegation_P_P_Operation.AddPackagedElement(SingleDelegation_P_P_Operation_R);
				// Class B
				SingleDelegation_P_P_Operation_B.SetName("B");
				SingleDelegation_P_P_Operation_B.SetVisibility(VisibilityKind.public_);
				
					// Property p
					SingleDelegation_P_P_Operation_B_p.SetName("p");
					SingleDelegation_P_P_Operation_B_p.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_P_Operation_B_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
				SingleDelegation_P_P_Operation_B.AddOwnedAttribute(SingleDelegation_P_P_Operation_B_p);
				// Activity setPActivity
					SingleDelegation_P_P_Operation_B_setPActivity.SetName("setPActivity");
					SingleDelegation_P_P_Operation_B_setPActivity.SetVisibility(VisibilityKind.public_);
					
						// Parameter v
						SingleDelegation_P_P_Operation_B_setPActivity_v.SetName("v");
						SingleDelegation_P_P_Operation_B_setPActivity_v.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Operation_B_setPActivity_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					SingleDelegation_P_P_Operation_B_setPActivity.AddOwnedParameter(SingleDelegation_P_P_Operation_B_setPActivity_v);
						// ActivityParameterNode vParameterNode
						SingleDelegation_P_P_Operation_B_setPActivity_vParameterNode.SetName("vParameterNode");
						SingleDelegation_P_P_Operation_B_setPActivity_vParameterNode.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Operation_B_setPActivity_vParameterNode.SetParameter(SingleDelegation_P_P_Operation_B_setPActivity_v);
					SingleDelegation_P_P_Operation_B_setPActivity.AddNode(SingleDelegation_P_P_Operation_B_setPActivity_vParameterNode);
						// ReadSelfAction this
						SingleDelegation_P_P_Operation_B_setPActivity_this.SetName("this");
						SingleDelegation_P_P_Operation_B_setPActivity_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							SingleDelegation_P_P_Operation_B_setPActivity_this_result.SetName("result");
							SingleDelegation_P_P_Operation_B_setPActivity_this_result.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Operation_B_setPActivity_this_result.SetType(SingleDelegation_P_P_Operation_B);
						SingleDelegation_P_P_Operation_B_setPActivity_this.SetResult(SingleDelegation_P_P_Operation_B_setPActivity_this_result);
					SingleDelegation_P_P_Operation_B_setPActivity.AddNode(SingleDelegation_P_P_Operation_B_setPActivity_this);
						// AddStructuralFeatureValueAction Set this.p
						SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p.SetName("Set this.p");
						SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p.SetStructuralFeature(SingleDelegation_P_P_Operation_B_p);
							// InputPin object
							SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p_object.SetName("object");
							SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p_object.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p_object.SetType(SingleDelegation_P_P_Operation_B);
						SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p.SetObject(SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p_object);
							// InputPin value
							SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p_value.SetName("value");
							SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p_value.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p.SetValue(SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p_value);
							// OutputPin result
							SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p_result.SetName("result");
							SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p_result.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p_result.SetType(SingleDelegation_P_P_Operation_B);
						SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p.SetResult(SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p_result);
					SingleDelegation_P_P_Operation_B_setPActivity.AddNode(SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p);
						// ObjectFlow ObjectFlow0 from result to object
						SingleDelegation_P_P_Operation_B_setPActivity_ObjectFlow0.SetName("ObjectFlow0");
						SingleDelegation_P_P_Operation_B_setPActivity_ObjectFlow0.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Operation_B_setPActivity_ObjectFlow0.SetSource(SingleDelegation_P_P_Operation_B_setPActivity_this_result);
						SingleDelegation_P_P_Operation_B_setPActivity_ObjectFlow0.SetTarget(SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p_object);
							// LiteralBoolean LiteralBoolean1
							SingleDelegation_P_P_Operation_B_setPActivity_ObjectFlow0_LiteralBoolean1.SetName("LiteralBoolean1");
							SingleDelegation_P_P_Operation_B_setPActivity_ObjectFlow0_LiteralBoolean1.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Operation_B_setPActivity_ObjectFlow0_LiteralBoolean1.SetValue(true);
						SingleDelegation_P_P_Operation_B_setPActivity_ObjectFlow0.SetGuard(SingleDelegation_P_P_Operation_B_setPActivity_ObjectFlow0_LiteralBoolean1);
					SingleDelegation_P_P_Operation_B_setPActivity.AddEdge(SingleDelegation_P_P_Operation_B_setPActivity_ObjectFlow0);
						// ObjectFlow ObjectFlow4 from vParameterNode to value
						SingleDelegation_P_P_Operation_B_setPActivity_ObjectFlow4.SetName("ObjectFlow4");
						SingleDelegation_P_P_Operation_B_setPActivity_ObjectFlow4.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Operation_B_setPActivity_ObjectFlow4.SetSource(SingleDelegation_P_P_Operation_B_setPActivity_vParameterNode);
						SingleDelegation_P_P_Operation_B_setPActivity_ObjectFlow4.SetTarget(SingleDelegation_P_P_Operation_B_setPActivity_Set_this_p_value);
							// LiteralBoolean LiteralBoolean6
							SingleDelegation_P_P_Operation_B_setPActivity_ObjectFlow4_LiteralBoolean6.SetName("LiteralBoolean6");
							SingleDelegation_P_P_Operation_B_setPActivity_ObjectFlow4_LiteralBoolean6.SetVisibility(VisibilityKind.public_);
							SingleDelegation_P_P_Operation_B_setPActivity_ObjectFlow4_LiteralBoolean6.SetValue(true);
						SingleDelegation_P_P_Operation_B_setPActivity_ObjectFlow4.SetGuard(SingleDelegation_P_P_Operation_B_setPActivity_ObjectFlow4_LiteralBoolean6);
					SingleDelegation_P_P_Operation_B_setPActivity.AddEdge(SingleDelegation_P_P_Operation_B_setPActivity_ObjectFlow4);
				SingleDelegation_P_P_Operation_B.AddOwnedBehavior(SingleDelegation_P_P_Operation_B_setPActivity);
					SingleDelegation_P_P_Operation_B_IRealization.SetName("IRealization");
					SingleDelegation_P_P_Operation_B_IRealization.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_P_Operation_B_IRealization.SetContract(SingleDelegation_P_P_Operation_I);
					
				SingleDelegation_P_P_Operation_B.AddInterfaceRealization(SingleDelegation_P_P_Operation_B_IRealization);
				
					// Operation B_B
					SingleDelegation_P_P_Operation_B_B_B.SetName("B_B");
					SingleDelegation_P_P_Operation_B_B_B.SetVisibility(VisibilityKind.public_);
						// Parameter result
						SingleDelegation_P_P_Operation_B_B_B_result.SetName("result");
						SingleDelegation_P_P_Operation_B_B_B_result.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Operation_B_B_B_result.SetType(SingleDelegation_P_P_Operation_B);
						SingleDelegation_P_P_Operation_B_B_B_result.SetDirection(ParameterDirectionKind.return_);
					SingleDelegation_P_P_Operation_B_B_B.AddOwnedParameter(SingleDelegation_P_P_Operation_B_B_B_result);
					SingleDelegation_P_P_Operation_B_B_B.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				SingleDelegation_P_P_Operation_B.AddOwnedOperation(SingleDelegation_P_P_Operation_B_B_B);
					// Operation setP_Integer
					SingleDelegation_P_P_Operation_B_setP_Integer.SetName("setP_Integer");
					SingleDelegation_P_P_Operation_B_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						SingleDelegation_P_P_Operation_B_setP_Integer_v.SetName("v");
						SingleDelegation_P_P_Operation_B_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Operation_B_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					SingleDelegation_P_P_Operation_B_setP_Integer.AddOwnedParameter(SingleDelegation_P_P_Operation_B_setP_Integer_v);
					SingleDelegation_P_P_Operation_B_setP_Integer.AddMethod(SingleDelegation_P_P_Operation_B_setPActivity);
				SingleDelegation_P_P_Operation_B.AddOwnedOperation(SingleDelegation_P_P_Operation_B_setP_Integer);
			SingleDelegation_P_P_Operation.AddPackagedElement(SingleDelegation_P_P_Operation_B);
				// Class A
				SingleDelegation_P_P_Operation_A.SetName("A");
				SingleDelegation_P_P_Operation_A.SetVisibility(VisibilityKind.public_);
				
					// Port q
					SingleDelegation_P_P_Operation_A_q.SetName("q");
					SingleDelegation_P_P_Operation_A_q.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_P_Operation_A_q.SetType(SingleDelegation_P_P_Operation_IImpl);
					SingleDelegation_P_P_Operation_A_q.SetAggregation(AggregationKind.composite);
					SingleDelegation_P_P_Operation_A_q.isService = true;
					SingleDelegation_P_P_Operation_A_q.AddProvided(SingleDelegation_P_P_Operation_I);
				SingleDelegation_P_P_Operation_A.AddOwnedAttribute(SingleDelegation_P_P_Operation_A_q);
					// Property b
					SingleDelegation_P_P_Operation_A_b.SetName("b");
					SingleDelegation_P_P_Operation_A_b.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_P_Operation_A_b.SetType(SingleDelegation_P_P_Operation_B);
					SingleDelegation_P_P_Operation_A_b.SetAggregation(AggregationKind.composite);
				SingleDelegation_P_P_Operation_A.AddOwnedAttribute(SingleDelegation_P_P_Operation_A_b);
				
				SingleDelegation_P_P_Operation_A_r.SetName("r");
					SingleDelegation_P_P_Operation_A_r.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Operation_A_r_ConnectorEnd16.SetRole(SingleDelegation_P_P_Operation_A_q);
						
					SingleDelegation_P_P_Operation_A_r.AddEnd(SingleDelegation_P_P_Operation_A_r_ConnectorEnd16);
						
						SingleDelegation_P_P_Operation_A_r_ConnectorEnd15.SetRole(SingleDelegation_P_P_Operation_A_b);
						
					SingleDelegation_P_P_Operation_A_r.AddEnd(SingleDelegation_P_P_Operation_A_r_ConnectorEnd15);
					SingleDelegation_P_P_Operation_A_r.SetType(SingleDelegation_P_P_Operation_R);
				SingleDelegation_P_P_Operation_A.AddOwnedConnector(SingleDelegation_P_P_Operation_A_r);
					// Operation A_A
					SingleDelegation_P_P_Operation_A_A_A.SetName("A_A");
					SingleDelegation_P_P_Operation_A_A_A.SetVisibility(VisibilityKind.public_);
						// Parameter result
						SingleDelegation_P_P_Operation_A_A_A_result.SetName("result");
						SingleDelegation_P_P_Operation_A_A_A_result.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Operation_A_A_A_result.SetType(SingleDelegation_P_P_Operation_A);
						SingleDelegation_P_P_Operation_A_A_A_result.SetDirection(ParameterDirectionKind.return_);
					SingleDelegation_P_P_Operation_A_A_A.AddOwnedParameter(SingleDelegation_P_P_Operation_A_A_A_result);
					SingleDelegation_P_P_Operation_A_A_A.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				SingleDelegation_P_P_Operation_A.AddOwnedOperation(SingleDelegation_P_P_Operation_A_A_A);
			SingleDelegation_P_P_Operation.AddPackagedElement(SingleDelegation_P_P_Operation_A);
				// Interface I
				SingleDelegation_P_P_Operation_I.SetName("I");
				SingleDelegation_P_P_Operation_I.SetVisibility(VisibilityKind.public_);
					// Operation setP_Integer
					SingleDelegation_P_P_Operation_I_setP_Integer.SetName("setP_Integer");
					SingleDelegation_P_P_Operation_I_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						SingleDelegation_P_P_Operation_I_setP_Integer_v.SetName("v");
						SingleDelegation_P_P_Operation_I_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Operation_I_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					SingleDelegation_P_P_Operation_I_setP_Integer.AddOwnedParameter(SingleDelegation_P_P_Operation_I_setP_Integer_v);
				SingleDelegation_P_P_Operation_I.AddOwnedOperation(SingleDelegation_P_P_Operation_I_setP_Integer);
			SingleDelegation_P_P_Operation.AddPackagedElement(SingleDelegation_P_P_Operation_I);
				// Activity main
				SingleDelegation_P_P_Operation_main.SetName("main");
				SingleDelegation_P_P_Operation_main.SetVisibility(VisibilityKind.public_);
				// FunctionBehavior testP
					SingleDelegation_P_P_Operation_main_testP.SetName("testP");
					SingleDelegation_P_P_Operation_main_testP.SetVisibility(VisibilityKind.public_);
					
						// Parameter p
						SingleDelegation_P_P_Operation_main_testP_p.SetName("p");
						SingleDelegation_P_P_Operation_main_testP_p.SetVisibility(VisibilityKind.public_);
						
						SingleDelegation_P_P_Operation_main_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					SingleDelegation_P_P_Operation_main_testP.AddOwnedParameter(SingleDelegation_P_P_Operation_main_testP_p);
					SingleDelegation_P_P_Operation_main_testP.AddLanguage("C#");
					SingleDelegation_P_P_Operation_main_testP.AddLanguage("Using");
					SingleDelegation_P_P_Operation_main_testP.AddBody("Console.WriteLine(\"Asserting a.b.p == 4\");  	// Test parameter p 	int p = ((IntegerValue)inputParameter.ElementAt(0).values.ElementAt(0)).value; 	Debug.Println(\"[doBody] argument p = \" + p); 	 	Console.WriteLine(\"a.b.p == \" + p); 	Console.Write(\"Operation call delegated: \");  	if(p == 4) 	{ 		Console.ForegroundColor = ConsoleColor.Green; 		Console.WriteLine(\"Assertion successful.\"); 	} 	else 	{ 		Console.ForegroundColor = ConsoleColor.Red; 		Console.WriteLine(\"Assertion failed!\"); 	}  	Console.ResetColor();");
					SingleDelegation_P_P_Operation_main_testP.AddBody("//using fuml.semantics.simpleclassifiers;");
				SingleDelegation_P_P_Operation_main.AddOwnedBehavior(SingleDelegation_P_P_Operation_main_testP);
					// CallBehaviorAction WriteLine(EndMessage)
					SingleDelegation_P_P_Operation_main_WriteLine_EndMessage.SetName("WriteLine(EndMessage)");
					SingleDelegation_P_P_Operation_main_WriteLine_EndMessage.SetVisibility(VisibilityKind.public_);
					
						// OutputPin errorStatus
						SingleDelegation_P_P_Operation_main_WriteLine_EndMessage_errorStatus.SetName("errorStatus");
						SingleDelegation_P_P_Operation_main_WriteLine_EndMessage_errorStatus.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Operation_main_WriteLine_EndMessage_errorStatus.SetType(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_Common_Status);
						SingleDelegation_P_P_Operation_main_WriteLine_EndMessage_errorStatus.SetLower(0);
					SingleDelegation_P_P_Operation_main_WriteLine_EndMessage.AddResult(SingleDelegation_P_P_Operation_main_WriteLine_EndMessage_errorStatus);
					SingleDelegation_P_P_Operation_main_WriteLine_EndMessage.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
						// InputPin value
						SingleDelegation_P_P_Operation_main_WriteLine_EndMessage_value.SetName("value");
						SingleDelegation_P_P_Operation_main_WriteLine_EndMessage_value.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Operation_main_WriteLine_EndMessage_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					SingleDelegation_P_P_Operation_main_WriteLine_EndMessage.AddArgument(SingleDelegation_P_P_Operation_main_WriteLine_EndMessage_value);
				SingleDelegation_P_P_Operation_main.AddNode(SingleDelegation_P_P_Operation_main_WriteLine_EndMessage);
					// ReadStructuralFeatureAction Read a.b.p
					SingleDelegation_P_P_Operation_main_Read_a_b_p.SetName("Read a.b.p");
					SingleDelegation_P_P_Operation_main_Read_a_b_p.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_P_Operation_main_Read_a_b_p.SetStructuralFeature(SingleDelegation_P_P_Operation_B_p);
						// InputPin object
						SingleDelegation_P_P_Operation_main_Read_a_b_p_object.SetName("object");
						SingleDelegation_P_P_Operation_main_Read_a_b_p_object.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Operation_main_Read_a_b_p_object.SetType(SingleDelegation_P_P_Operation_B);
					SingleDelegation_P_P_Operation_main_Read_a_b_p.SetObject(SingleDelegation_P_P_Operation_main_Read_a_b_p_object);
						// OutputPin result
						SingleDelegation_P_P_Operation_main_Read_a_b_p_result.SetName("result");
						SingleDelegation_P_P_Operation_main_Read_a_b_p_result.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Operation_main_Read_a_b_p_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					SingleDelegation_P_P_Operation_main_Read_a_b_p.SetResult(SingleDelegation_P_P_Operation_main_Read_a_b_p_result);
				SingleDelegation_P_P_Operation_main.AddNode(SingleDelegation_P_P_Operation_main_Read_a_b_p);
					// CallOperationAction A()
					SingleDelegation_P_P_Operation_main_A_.SetName("A()");
					SingleDelegation_P_P_Operation_main_A_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						SingleDelegation_P_P_Operation_main_A__result.SetName("result");
						SingleDelegation_P_P_Operation_main_A__result.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Operation_main_A__result.SetType(SingleDelegation_P_P_Operation_A);
					SingleDelegation_P_P_Operation_main_A_.AddResult(SingleDelegation_P_P_Operation_main_A__result);
					SingleDelegation_P_P_Operation_main_A_.SetOperation(SingleDelegation_P_P_Operation_A_A_A);
						// InputPin target
						SingleDelegation_P_P_Operation_main_A__target.SetName("target");
						SingleDelegation_P_P_Operation_main_A__target.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Operation_main_A__target.SetType(SingleDelegation_P_P_Operation_A);
					SingleDelegation_P_P_Operation_main_A_.SetTarget(SingleDelegation_P_P_Operation_main_A__target);
				SingleDelegation_P_P_Operation_main.AddNode(SingleDelegation_P_P_Operation_main_A_);
					// ReadStructuralFeatureAction Read a.b
					SingleDelegation_P_P_Operation_main_Read_a_b.SetName("Read a.b");
					SingleDelegation_P_P_Operation_main_Read_a_b.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_P_Operation_main_Read_a_b.SetStructuralFeature(SingleDelegation_P_P_Operation_A_b);
						// InputPin object
						SingleDelegation_P_P_Operation_main_Read_a_b_object.SetName("object");
						SingleDelegation_P_P_Operation_main_Read_a_b_object.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Operation_main_Read_a_b_object.SetType(SingleDelegation_P_P_Operation_A);
					SingleDelegation_P_P_Operation_main_Read_a_b.SetObject(SingleDelegation_P_P_Operation_main_Read_a_b_object);
						// OutputPin result
						SingleDelegation_P_P_Operation_main_Read_a_b_result.SetName("result");
						SingleDelegation_P_P_Operation_main_Read_a_b_result.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Operation_main_Read_a_b_result.SetType(SingleDelegation_P_P_Operation_B);
					SingleDelegation_P_P_Operation_main_Read_a_b.SetResult(SingleDelegation_P_P_Operation_main_Read_a_b_result);
				SingleDelegation_P_P_Operation_main.AddNode(SingleDelegation_P_P_Operation_main_Read_a_b);
					// CallBehaviorAction Call testP
					SingleDelegation_P_P_Operation_main_Call_testP.SetName("Call testP");
					SingleDelegation_P_P_Operation_main_Call_testP.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_P_Operation_main_Call_testP.SetBehavior(SingleDelegation_P_P_Operation_main_testP);
						// InputPin p
						SingleDelegation_P_P_Operation_main_Call_testP_p.SetName("p");
						SingleDelegation_P_P_Operation_main_Call_testP_p.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Operation_main_Call_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					SingleDelegation_P_P_Operation_main_Call_testP.AddArgument(SingleDelegation_P_P_Operation_main_Call_testP_p);
				SingleDelegation_P_P_Operation_main.AddNode(SingleDelegation_P_P_Operation_main_Call_testP);
					// CallBehaviorAction WriteLine(InitialMessage)
					SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage.SetName("WriteLine(InitialMessage)");
					SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage.SetVisibility(VisibilityKind.public_);
					
						// OutputPin errorStatus
						SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage_errorStatus.SetName("errorStatus");
						SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage_errorStatus.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage_errorStatus.SetType(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_Common_Status);
						SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage_errorStatus.SetLower(0);
					SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage.AddResult(SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage_errorStatus);
					SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
						// InputPin value
						SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage_value.SetName("value");
						SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage_value.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage.AddArgument(SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage_value);
				SingleDelegation_P_P_Operation_main.AddNode(SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage);
					// ValueSpecificationAction Value(4)
					SingleDelegation_P_P_Operation_main_Value_4.SetName("Value(4)");
					SingleDelegation_P_P_Operation_main_Value_4.SetVisibility(VisibilityKind.public_);
						// LiteralInteger LiteralInteger71
						SingleDelegation_P_P_Operation_main_Value_4_LiteralInteger71.SetName("LiteralInteger71");
						SingleDelegation_P_P_Operation_main_Value_4_LiteralInteger71.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Operation_main_Value_4_LiteralInteger71.SetValue(4);
					SingleDelegation_P_P_Operation_main_Value_4.SetValue(SingleDelegation_P_P_Operation_main_Value_4_LiteralInteger71);
						// OutputPin result
						SingleDelegation_P_P_Operation_main_Value_4_result.SetName("result");
						SingleDelegation_P_P_Operation_main_Value_4_result.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Operation_main_Value_4_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					SingleDelegation_P_P_Operation_main_Value_4.SetResult(SingleDelegation_P_P_Operation_main_Value_4_result);
				SingleDelegation_P_P_Operation_main.AddNode(SingleDelegation_P_P_Operation_main_Value_4);
					// CallOperationAction Call a.q.setP
					SingleDelegation_P_P_Operation_main_Call_a_q_setP.SetName("Call a.q.setP");
					SingleDelegation_P_P_Operation_main_Call_a_q_setP.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_P_Operation_main_Call_a_q_setP.SetOperation(SingleDelegation_P_P_Operation_I_setP_Integer);
						// InputPin target
						SingleDelegation_P_P_Operation_main_Call_a_q_setP_target.SetName("target");
						SingleDelegation_P_P_Operation_main_Call_a_q_setP_target.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_P_Operation_main_Call_a_q_setP.SetTarget(SingleDelegation_P_P_Operation_main_Call_a_q_setP_target);
						// InputPin v
						SingleDelegation_P_P_Operation_main_Call_a_q_setP_v.SetName("v");
						SingleDelegation_P_P_Operation_main_Call_a_q_setP_v.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Operation_main_Call_a_q_setP_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					SingleDelegation_P_P_Operation_main_Call_a_q_setP.AddArgument(SingleDelegation_P_P_Operation_main_Call_a_q_setP_v);
				SingleDelegation_P_P_Operation_main.AddNode(SingleDelegation_P_P_Operation_main_Call_a_q_setP);
					// ValueSpecificationAction EndMessage
					SingleDelegation_P_P_Operation_main_EndMessage.SetName("EndMessage");
					SingleDelegation_P_P_Operation_main_EndMessage.SetVisibility(VisibilityKind.public_);
						// LiteralString LiteralString92
						SingleDelegation_P_P_Operation_main_EndMessage_LiteralString92.SetName("LiteralString92");
						SingleDelegation_P_P_Operation_main_EndMessage_LiteralString92.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Operation_main_EndMessage_LiteralString92.SetValue("-- End of test case --");
					SingleDelegation_P_P_Operation_main_EndMessage.SetValue(SingleDelegation_P_P_Operation_main_EndMessage_LiteralString92);
						// OutputPin result
						SingleDelegation_P_P_Operation_main_EndMessage_result.SetName("result");
						SingleDelegation_P_P_Operation_main_EndMessage_result.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Operation_main_EndMessage_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					SingleDelegation_P_P_Operation_main_EndMessage.SetResult(SingleDelegation_P_P_Operation_main_EndMessage_result);
				SingleDelegation_P_P_Operation_main.AddNode(SingleDelegation_P_P_Operation_main_EndMessage);
					// CreateObjectAction Create A
					SingleDelegation_P_P_Operation_main_Create_A.SetName("Create A");
					SingleDelegation_P_P_Operation_main_Create_A.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_P_Operation_main_Create_A.SetClassifier(SingleDelegation_P_P_Operation_A);
						// OutputPin result
						SingleDelegation_P_P_Operation_main_Create_A_result.SetName("result");
						SingleDelegation_P_P_Operation_main_Create_A_result.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Operation_main_Create_A_result.SetType(SingleDelegation_P_P_Operation_A);
					SingleDelegation_P_P_Operation_main_Create_A.SetResult(SingleDelegation_P_P_Operation_main_Create_A_result);
				SingleDelegation_P_P_Operation_main.AddNode(SingleDelegation_P_P_Operation_main_Create_A);
					// ReadStructuralFeatureAction Read a.q
					SingleDelegation_P_P_Operation_main_Read_a_q.SetName("Read a.q");
					SingleDelegation_P_P_Operation_main_Read_a_q.SetVisibility(VisibilityKind.public_);
					SingleDelegation_P_P_Operation_main_Read_a_q.SetStructuralFeature(SingleDelegation_P_P_Operation_A_q);
						// InputPin object
						SingleDelegation_P_P_Operation_main_Read_a_q_object.SetName("object");
						SingleDelegation_P_P_Operation_main_Read_a_q_object.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Operation_main_Read_a_q_object.SetType(SingleDelegation_P_P_Operation_A);
					SingleDelegation_P_P_Operation_main_Read_a_q.SetObject(SingleDelegation_P_P_Operation_main_Read_a_q_object);
						// OutputPin result
						SingleDelegation_P_P_Operation_main_Read_a_q_result.SetName("result");
						SingleDelegation_P_P_Operation_main_Read_a_q_result.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Operation_main_Read_a_q_result.SetType(SingleDelegation_P_P_Operation_IImpl);
					SingleDelegation_P_P_Operation_main_Read_a_q.SetResult(SingleDelegation_P_P_Operation_main_Read_a_q_result);
				SingleDelegation_P_P_Operation_main.AddNode(SingleDelegation_P_P_Operation_main_Read_a_q);
					// ValueSpecificationAction InitialMessage
					SingleDelegation_P_P_Operation_main_InitialMessage.SetName("InitialMessage");
					SingleDelegation_P_P_Operation_main_InitialMessage.SetVisibility(VisibilityKind.public_);
						// LiteralString LiteralString44
						SingleDelegation_P_P_Operation_main_InitialMessage_LiteralString44.SetName("LiteralString44");
						SingleDelegation_P_P_Operation_main_InitialMessage_LiteralString44.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Operation_main_InitialMessage_LiteralString44.SetValue("-- Running test case: Single delegation connector - Operation delegated from port to part --");
					SingleDelegation_P_P_Operation_main_InitialMessage.SetValue(SingleDelegation_P_P_Operation_main_InitialMessage_LiteralString44);
						// OutputPin result
						SingleDelegation_P_P_Operation_main_InitialMessage_result.SetName("result");
						SingleDelegation_P_P_Operation_main_InitialMessage_result.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Operation_main_InitialMessage_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					SingleDelegation_P_P_Operation_main_InitialMessage.SetResult(SingleDelegation_P_P_Operation_main_InitialMessage_result);
				SingleDelegation_P_P_Operation_main.AddNode(SingleDelegation_P_P_Operation_main_InitialMessage);
					// ForkNode Fork A
					SingleDelegation_P_P_Operation_main_Fork_A.SetName("Fork A");
					SingleDelegation_P_P_Operation_main_Fork_A.SetVisibility(VisibilityKind.public_);
				SingleDelegation_P_P_Operation_main.AddNode(SingleDelegation_P_P_Operation_main_Fork_A);
					// ObjectFlow ObjectFlow45 from result to object
					SingleDelegation_P_P_Operation_main_ObjectFlow45.SetName("ObjectFlow45");
					SingleDelegation_P_P_Operation_main_ObjectFlow45.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_P_Operation_main_ObjectFlow45.SetSource(SingleDelegation_P_P_Operation_main_Read_a_b_result);
					SingleDelegation_P_P_Operation_main_ObjectFlow45.SetTarget(SingleDelegation_P_P_Operation_main_Read_a_b_p_object);
						// LiteralBoolean LiteralBoolean47
						SingleDelegation_P_P_Operation_main_ObjectFlow45_LiteralBoolean47.SetName("LiteralBoolean47");
						SingleDelegation_P_P_Operation_main_ObjectFlow45_LiteralBoolean47.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Operation_main_ObjectFlow45_LiteralBoolean47.SetValue(true);
					SingleDelegation_P_P_Operation_main_ObjectFlow45.SetGuard(SingleDelegation_P_P_Operation_main_ObjectFlow45_LiteralBoolean47);
				SingleDelegation_P_P_Operation_main.AddEdge(SingleDelegation_P_P_Operation_main_ObjectFlow45);
					// ObjectFlow ObjectFlow63 from result to Fork A
					SingleDelegation_P_P_Operation_main_ObjectFlow63.SetName("ObjectFlow63");
					SingleDelegation_P_P_Operation_main_ObjectFlow63.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_P_Operation_main_ObjectFlow63.SetSource(SingleDelegation_P_P_Operation_main_A__result);
					SingleDelegation_P_P_Operation_main_ObjectFlow63.SetTarget(SingleDelegation_P_P_Operation_main_Fork_A);
						// LiteralBoolean LiteralBoolean64
						SingleDelegation_P_P_Operation_main_ObjectFlow63_LiteralBoolean64.SetName("LiteralBoolean64");
						SingleDelegation_P_P_Operation_main_ObjectFlow63_LiteralBoolean64.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Operation_main_ObjectFlow63_LiteralBoolean64.SetValue(true);
					SingleDelegation_P_P_Operation_main_ObjectFlow63.SetGuard(SingleDelegation_P_P_Operation_main_ObjectFlow63_LiteralBoolean64);
				SingleDelegation_P_P_Operation_main.AddEdge(SingleDelegation_P_P_Operation_main_ObjectFlow63);
					// ControlFlow ControlFlow21 from Call testP to WriteLine(EndMessage)
					SingleDelegation_P_P_Operation_main_ControlFlow21.SetName("ControlFlow21");
					SingleDelegation_P_P_Operation_main_ControlFlow21.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_P_Operation_main_ControlFlow21.SetSource(SingleDelegation_P_P_Operation_main_Call_testP);
					SingleDelegation_P_P_Operation_main_ControlFlow21.SetTarget(SingleDelegation_P_P_Operation_main_WriteLine_EndMessage);
				SingleDelegation_P_P_Operation_main.AddEdge(SingleDelegation_P_P_Operation_main_ControlFlow21);
					// ObjectFlow ObjectFlow22 from result to p
					SingleDelegation_P_P_Operation_main_ObjectFlow22.SetName("ObjectFlow22");
					SingleDelegation_P_P_Operation_main_ObjectFlow22.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_P_Operation_main_ObjectFlow22.SetSource(SingleDelegation_P_P_Operation_main_Read_a_b_p_result);
					SingleDelegation_P_P_Operation_main_ObjectFlow22.SetTarget(SingleDelegation_P_P_Operation_main_Call_testP_p);
						// LiteralBoolean LiteralBoolean23
						SingleDelegation_P_P_Operation_main_ObjectFlow22_LiteralBoolean23.SetName("LiteralBoolean23");
						SingleDelegation_P_P_Operation_main_ObjectFlow22_LiteralBoolean23.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Operation_main_ObjectFlow22_LiteralBoolean23.SetValue(true);
					SingleDelegation_P_P_Operation_main_ObjectFlow22.SetGuard(SingleDelegation_P_P_Operation_main_ObjectFlow22_LiteralBoolean23);
				SingleDelegation_P_P_Operation_main.AddEdge(SingleDelegation_P_P_Operation_main_ObjectFlow22);
					// ObjectFlow ObjectFlow66 from Fork A to object
					SingleDelegation_P_P_Operation_main_ObjectFlow66.SetName("ObjectFlow66");
					SingleDelegation_P_P_Operation_main_ObjectFlow66.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_P_Operation_main_ObjectFlow66.SetSource(SingleDelegation_P_P_Operation_main_Fork_A);
					SingleDelegation_P_P_Operation_main_ObjectFlow66.SetTarget(SingleDelegation_P_P_Operation_main_Read_a_b_object);
						// LiteralBoolean LiteralBoolean67
						SingleDelegation_P_P_Operation_main_ObjectFlow66_LiteralBoolean67.SetName("LiteralBoolean67");
						SingleDelegation_P_P_Operation_main_ObjectFlow66_LiteralBoolean67.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Operation_main_ObjectFlow66_LiteralBoolean67.SetValue(true);
					SingleDelegation_P_P_Operation_main_ObjectFlow66.SetGuard(SingleDelegation_P_P_Operation_main_ObjectFlow66_LiteralBoolean67);
				SingleDelegation_P_P_Operation_main.AddEdge(SingleDelegation_P_P_Operation_main_ObjectFlow66);
					// ObjectFlow ObjectFlow72 from Fork A to object
					SingleDelegation_P_P_Operation_main_ObjectFlow72.SetName("ObjectFlow72");
					SingleDelegation_P_P_Operation_main_ObjectFlow72.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_P_Operation_main_ObjectFlow72.SetSource(SingleDelegation_P_P_Operation_main_Fork_A);
					SingleDelegation_P_P_Operation_main_ObjectFlow72.SetTarget(SingleDelegation_P_P_Operation_main_Read_a_q_object);
						// LiteralBoolean LiteralBoolean74
						SingleDelegation_P_P_Operation_main_ObjectFlow72_LiteralBoolean74.SetName("LiteralBoolean74");
						SingleDelegation_P_P_Operation_main_ObjectFlow72_LiteralBoolean74.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Operation_main_ObjectFlow72_LiteralBoolean74.SetValue(true);
					SingleDelegation_P_P_Operation_main_ObjectFlow72.SetGuard(SingleDelegation_P_P_Operation_main_ObjectFlow72_LiteralBoolean74);
				SingleDelegation_P_P_Operation_main.AddEdge(SingleDelegation_P_P_Operation_main_ObjectFlow72);
					// ObjectFlow ObjectFlow75 from result to v
					SingleDelegation_P_P_Operation_main_ObjectFlow75.SetName("ObjectFlow75");
					SingleDelegation_P_P_Operation_main_ObjectFlow75.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_P_Operation_main_ObjectFlow75.SetSource(SingleDelegation_P_P_Operation_main_Value_4_result);
					SingleDelegation_P_P_Operation_main_ObjectFlow75.SetTarget(SingleDelegation_P_P_Operation_main_Call_a_q_setP_v);
						// LiteralBoolean LiteralBoolean77
						SingleDelegation_P_P_Operation_main_ObjectFlow75_LiteralBoolean77.SetName("LiteralBoolean77");
						SingleDelegation_P_P_Operation_main_ObjectFlow75_LiteralBoolean77.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Operation_main_ObjectFlow75_LiteralBoolean77.SetValue(true);
					SingleDelegation_P_P_Operation_main_ObjectFlow75.SetGuard(SingleDelegation_P_P_Operation_main_ObjectFlow75_LiteralBoolean77);
				SingleDelegation_P_P_Operation_main.AddEdge(SingleDelegation_P_P_Operation_main_ObjectFlow75);
					// ObjectFlow ObjectFlow78 from result to target
					SingleDelegation_P_P_Operation_main_ObjectFlow78.SetName("ObjectFlow78");
					SingleDelegation_P_P_Operation_main_ObjectFlow78.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_P_Operation_main_ObjectFlow78.SetSource(SingleDelegation_P_P_Operation_main_Create_A_result);
					SingleDelegation_P_P_Operation_main_ObjectFlow78.SetTarget(SingleDelegation_P_P_Operation_main_A__target);
						// LiteralBoolean LiteralBoolean80
						SingleDelegation_P_P_Operation_main_ObjectFlow78_LiteralBoolean80.SetName("LiteralBoolean80");
						SingleDelegation_P_P_Operation_main_ObjectFlow78_LiteralBoolean80.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Operation_main_ObjectFlow78_LiteralBoolean80.SetValue(true);
					SingleDelegation_P_P_Operation_main_ObjectFlow78.SetGuard(SingleDelegation_P_P_Operation_main_ObjectFlow78_LiteralBoolean80);
				SingleDelegation_P_P_Operation_main.AddEdge(SingleDelegation_P_P_Operation_main_ObjectFlow78);
					// ControlFlow ControlFlow81 from Call a.q.setP to Read a.b
					SingleDelegation_P_P_Operation_main_ControlFlow81.SetName("ControlFlow81");
					SingleDelegation_P_P_Operation_main_ControlFlow81.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_P_Operation_main_ControlFlow81.SetSource(SingleDelegation_P_P_Operation_main_Call_a_q_setP);
					SingleDelegation_P_P_Operation_main_ControlFlow81.SetTarget(SingleDelegation_P_P_Operation_main_Read_a_b);
				SingleDelegation_P_P_Operation_main.AddEdge(SingleDelegation_P_P_Operation_main_ControlFlow81);
					// ObjectFlow ObjectFlow82 from result to value
					SingleDelegation_P_P_Operation_main_ObjectFlow82.SetName("ObjectFlow82");
					SingleDelegation_P_P_Operation_main_ObjectFlow82.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_P_Operation_main_ObjectFlow82.SetSource(SingleDelegation_P_P_Operation_main_EndMessage_result);
					SingleDelegation_P_P_Operation_main_ObjectFlow82.SetTarget(SingleDelegation_P_P_Operation_main_WriteLine_EndMessage_value);
						// LiteralBoolean LiteralBoolean84
						SingleDelegation_P_P_Operation_main_ObjectFlow82_LiteralBoolean84.SetName("LiteralBoolean84");
						SingleDelegation_P_P_Operation_main_ObjectFlow82_LiteralBoolean84.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Operation_main_ObjectFlow82_LiteralBoolean84.SetValue(true);
					SingleDelegation_P_P_Operation_main_ObjectFlow82.SetGuard(SingleDelegation_P_P_Operation_main_ObjectFlow82_LiteralBoolean84);
				SingleDelegation_P_P_Operation_main.AddEdge(SingleDelegation_P_P_Operation_main_ObjectFlow82);
					// ObjectFlow ObjectFlow34 from result to value
					SingleDelegation_P_P_Operation_main_ObjectFlow34.SetName("ObjectFlow34");
					SingleDelegation_P_P_Operation_main_ObjectFlow34.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_P_Operation_main_ObjectFlow34.SetSource(SingleDelegation_P_P_Operation_main_InitialMessage_result);
					SingleDelegation_P_P_Operation_main_ObjectFlow34.SetTarget(SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage_value);
						// LiteralBoolean LiteralBoolean35
						SingleDelegation_P_P_Operation_main_ObjectFlow34_LiteralBoolean35.SetName("LiteralBoolean35");
						SingleDelegation_P_P_Operation_main_ObjectFlow34_LiteralBoolean35.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Operation_main_ObjectFlow34_LiteralBoolean35.SetValue(true);
					SingleDelegation_P_P_Operation_main_ObjectFlow34.SetGuard(SingleDelegation_P_P_Operation_main_ObjectFlow34_LiteralBoolean35);
				SingleDelegation_P_P_Operation_main.AddEdge(SingleDelegation_P_P_Operation_main_ObjectFlow34);
					// ControlFlow ControlFlow37 from WriteLine(InitialMessage) to Create A
					SingleDelegation_P_P_Operation_main_ControlFlow37.SetName("ControlFlow37");
					SingleDelegation_P_P_Operation_main_ControlFlow37.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_P_Operation_main_ControlFlow37.SetSource(SingleDelegation_P_P_Operation_main_WriteLine_InitialMessage);
					SingleDelegation_P_P_Operation_main_ControlFlow37.SetTarget(SingleDelegation_P_P_Operation_main_Create_A);
				SingleDelegation_P_P_Operation_main.AddEdge(SingleDelegation_P_P_Operation_main_ControlFlow37);
					// ObjectFlow ObjectFlow95 from result to target
					SingleDelegation_P_P_Operation_main_ObjectFlow95.SetName("ObjectFlow95");
					SingleDelegation_P_P_Operation_main_ObjectFlow95.SetVisibility(VisibilityKind.public_);
					
					SingleDelegation_P_P_Operation_main_ObjectFlow95.SetSource(SingleDelegation_P_P_Operation_main_Read_a_q_result);
					SingleDelegation_P_P_Operation_main_ObjectFlow95.SetTarget(SingleDelegation_P_P_Operation_main_Call_a_q_setP_target);
						// LiteralBoolean LiteralBoolean96
						SingleDelegation_P_P_Operation_main_ObjectFlow95_LiteralBoolean96.SetName("LiteralBoolean96");
						SingleDelegation_P_P_Operation_main_ObjectFlow95_LiteralBoolean96.SetVisibility(VisibilityKind.public_);
						SingleDelegation_P_P_Operation_main_ObjectFlow95_LiteralBoolean96.SetValue(true);
					SingleDelegation_P_P_Operation_main_ObjectFlow95.SetGuard(SingleDelegation_P_P_Operation_main_ObjectFlow95_LiteralBoolean96);
				SingleDelegation_P_P_Operation_main.AddEdge(SingleDelegation_P_P_Operation_main_ObjectFlow95);
			SingleDelegation_P_P_Operation.AddPackagedElement(SingleDelegation_P_P_Operation_main);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // SingleDelegation_P_P_OperationModel
}
