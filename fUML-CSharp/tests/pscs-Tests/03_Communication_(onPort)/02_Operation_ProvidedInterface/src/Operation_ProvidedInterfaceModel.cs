/*
 * Operation_ProvidedInterfaceModel.cs
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

namespace Operation_ProvidedInterface
{
	public class Operation_ProvidedInterfaceModel : InMemoryModel
	{
		private static Operation_ProvidedInterfaceModel? instance;

		/*
		 * Model Operation_ProvidedInterface
		 */
		public Package Operation_ProvidedInterface = new();
			public Activity Operation_ProvidedInterface_main = new();
				public ReadStructuralFeatureAction Operation_ProvidedInterface_main_Read_b_p = new();
					public OutputPin Operation_ProvidedInterface_main_Read_b_p_result = new();
						public LiteralInteger Operation_ProvidedInterface_main_Read_b_p_result_LiteralInteger0 = new();
						public LiteralUnlimitedNatural Operation_ProvidedInterface_main_Read_b_p_result_LiteralUnlimitedNatural1 = new();
					public InputPin Operation_ProvidedInterface_main_Read_b_p_object = new();
						public LiteralInteger Operation_ProvidedInterface_main_Read_b_p_object_LiteralInteger2 = new();
						public LiteralUnlimitedNatural Operation_ProvidedInterface_main_Read_b_p_object_LiteralUnlimitedNatural3 = new();
				public CreateObjectAction Operation_ProvidedInterface_main_Create_A = new();
					public OutputPin Operation_ProvidedInterface_main_Create_A_result = new();
						public LiteralUnlimitedNatural Operation_ProvidedInterface_main_Create_A_result_LiteralUnlimitedNatural4 = new();
						public LiteralInteger Operation_ProvidedInterface_main_Create_A_result_LiteralInteger5 = new();
				public CallOperationAction Operation_ProvidedInterface_main_A_ = new();
					public OutputPin Operation_ProvidedInterface_main_A__result = new();
						public LiteralUnlimitedNatural Operation_ProvidedInterface_main_A__result_LiteralUnlimitedNatural6 = new();
						public LiteralInteger Operation_ProvidedInterface_main_A__result_LiteralInteger7 = new();
						public LiteralInteger Operation_ProvidedInterface_main_A__result_LiteralInteger8 = new();
					public InputPin Operation_ProvidedInterface_main_A__target = new();
						public LiteralInteger Operation_ProvidedInterface_main_A__target_LiteralInteger9 = new();
						public LiteralUnlimitedNatural Operation_ProvidedInterface_main_A__target_LiteralUnlimitedNatural10 = new();
				public ObjectFlow Operation_ProvidedInterface_main_ObjectFlow11 = new();
					public LiteralBoolean Operation_ProvidedInterface_main_ObjectFlow11_LiteralBoolean12 = new();
					public LiteralInteger Operation_ProvidedInterface_main_ObjectFlow11_LiteralInteger13 = new();
				public OpaqueBehavior Operation_ProvidedInterface_main_testP = new();
					public Parameter Operation_ProvidedInterface_main_testP_p = new();
				public ObjectFlow Operation_ProvidedInterface_main_ObjectFlow14 = new();
					public LiteralBoolean Operation_ProvidedInterface_main_ObjectFlow14_LiteralBoolean15 = new();
					public LiteralInteger Operation_ProvidedInterface_main_ObjectFlow14_LiteralInteger16 = new();
				public ObjectFlow Operation_ProvidedInterface_main_ObjectFlow17 = new();
					public LiteralInteger Operation_ProvidedInterface_main_ObjectFlow17_LiteralInteger18 = new();
					public LiteralBoolean Operation_ProvidedInterface_main_ObjectFlow17_LiteralBoolean19 = new();
				public ObjectFlow Operation_ProvidedInterface_main_ObjectFlow20 = new();
					public LiteralBoolean Operation_ProvidedInterface_main_ObjectFlow20_LiteralBoolean21 = new();
					public LiteralInteger Operation_ProvidedInterface_main_ObjectFlow20_LiteralInteger22 = new();
				public CallOperationAction Operation_ProvidedInterface_main_Call_setP_ = new();
					public InputPin Operation_ProvidedInterface_main_Call_setP__target = new();
						public LiteralUnlimitedNatural Operation_ProvidedInterface_main_Call_setP__target_LiteralUnlimitedNatural23 = new();
						public LiteralInteger Operation_ProvidedInterface_main_Call_setP__target_LiteralInteger24 = new();
					public InputPin Operation_ProvidedInterface_main_Call_setP__v = new();
						public LiteralInteger Operation_ProvidedInterface_main_Call_setP__v_LiteralInteger25 = new();
						public LiteralUnlimitedNatural Operation_ProvidedInterface_main_Call_setP__v_LiteralUnlimitedNatural26 = new();
						public LiteralInteger Operation_ProvidedInterface_main_Call_setP__v_LiteralInteger27 = new();
				public CallBehaviorAction Operation_ProvidedInterface_main_Call_testP = new();
					public InputPin Operation_ProvidedInterface_main_Call_testP_p = new();
						public LiteralInteger Operation_ProvidedInterface_main_Call_testP_p_LiteralInteger28 = new();
						public LiteralInteger Operation_ProvidedInterface_main_Call_testP_p_LiteralInteger29 = new();
						public LiteralUnlimitedNatural Operation_ProvidedInterface_main_Call_testP_p_LiteralUnlimitedNatural30 = new();
				public ControlFlow Operation_ProvidedInterface_main_ControlFlow31 = new();
				public ObjectFlow Operation_ProvidedInterface_main_ObjectFlow32 = new();
					public LiteralBoolean Operation_ProvidedInterface_main_ObjectFlow32_LiteralBoolean33 = new();
					public LiteralInteger Operation_ProvidedInterface_main_ObjectFlow32_LiteralInteger34 = new();
				public ObjectFlow Operation_ProvidedInterface_main_ObjectFlow35 = new();
					public LiteralInteger Operation_ProvidedInterface_main_ObjectFlow35_LiteralInteger36 = new();
					public LiteralBoolean Operation_ProvidedInterface_main_ObjectFlow35_LiteralBoolean37 = new();
				public ForkNode Operation_ProvidedInterface_main_Fork_a = new();
				public ValueSpecificationAction Operation_ProvidedInterface_main_Value_4 = new();
					public OutputPin Operation_ProvidedInterface_main_Value_4_result = new();
						public LiteralUnlimitedNatural Operation_ProvidedInterface_main_Value_4_result_LiteralUnlimitedNatural38 = new();
						public LiteralInteger Operation_ProvidedInterface_main_Value_4_result_LiteralInteger39 = new();
					public LiteralInteger Operation_ProvidedInterface_main_Value_4_LiteralInteger40 = new();
				public ObjectFlow Operation_ProvidedInterface_main_ObjectFlow41 = new();
					public LiteralBoolean Operation_ProvidedInterface_main_ObjectFlow41_LiteralBoolean42 = new();
					public LiteralInteger Operation_ProvidedInterface_main_ObjectFlow41_LiteralInteger43 = new();
				public ReadStructuralFeatureAction Operation_ProvidedInterface_main_Read_a_b = new();
					public OutputPin Operation_ProvidedInterface_main_Read_a_b_result = new();
						public LiteralUnlimitedNatural Operation_ProvidedInterface_main_Read_a_b_result_LiteralUnlimitedNatural44 = new();
						public LiteralInteger Operation_ProvidedInterface_main_Read_a_b_result_LiteralInteger45 = new();
					public InputPin Operation_ProvidedInterface_main_Read_a_b_object = new();
						public LiteralInteger Operation_ProvidedInterface_main_Read_a_b_object_LiteralInteger46 = new();
						public LiteralUnlimitedNatural Operation_ProvidedInterface_main_Read_a_b_object_LiteralUnlimitedNatural47 = new();
			public Class_ Operation_ProvidedInterface_B = new();
				public InterfaceRealization Operation_ProvidedInterface_B_IRealization = new();
				public Operation Operation_ProvidedInterface_B_setP_Integer = new();
					public Parameter Operation_ProvidedInterface_B_setP_Integer_v = new();
				public Activity Operation_ProvidedInterface_B_setPActivity = new();
					public ObjectFlow Operation_ProvidedInterface_B_setPActivity_ObjectFlow48 = new();
						public LiteralBoolean Operation_ProvidedInterface_B_setPActivity_ObjectFlow48_LiteralBoolean49 = new();
						public LiteralInteger Operation_ProvidedInterface_B_setPActivity_ObjectFlow48_LiteralInteger50 = new();
					public ObjectFlow Operation_ProvidedInterface_B_setPActivity_ObjectFlow51 = new();
						public LiteralInteger Operation_ProvidedInterface_B_setPActivity_ObjectFlow51_LiteralInteger52 = new();
						public LiteralBoolean Operation_ProvidedInterface_B_setPActivity_ObjectFlow51_LiteralBoolean53 = new();
					public Parameter Operation_ProvidedInterface_B_setPActivity_v = new();
					public ActivityParameterNode Operation_ProvidedInterface_B_setPActivity_vParameterNode = new();
						public LiteralInteger Operation_ProvidedInterface_B_setPActivity_vParameterNode_LiteralInteger54 = new();
					public AddStructuralFeatureValueAction Operation_ProvidedInterface_B_setPActivity_Set_this_p = new();
						public InputPin Operation_ProvidedInterface_B_setPActivity_Set_this_p_object = new();
							public LiteralUnlimitedNatural Operation_ProvidedInterface_B_setPActivity_Set_this_p_object_LiteralUnlimitedNatural55 = new();
							public LiteralInteger Operation_ProvidedInterface_B_setPActivity_Set_this_p_object_LiteralInteger56 = new();
						public OutputPin Operation_ProvidedInterface_B_setPActivity_Set_this_p_result = new();
							public LiteralInteger Operation_ProvidedInterface_B_setPActivity_Set_this_p_result_LiteralInteger57 = new();
							public LiteralUnlimitedNatural Operation_ProvidedInterface_B_setPActivity_Set_this_p_result_LiteralUnlimitedNatural58 = new();
						public InputPin Operation_ProvidedInterface_B_setPActivity_Set_this_p_value = new();
							public LiteralInteger Operation_ProvidedInterface_B_setPActivity_Set_this_p_value_LiteralInteger59 = new();
							public LiteralUnlimitedNatural Operation_ProvidedInterface_B_setPActivity_Set_this_p_value_LiteralUnlimitedNatural60 = new();
					public ReadSelfAction Operation_ProvidedInterface_B_setPActivity_this = new();
						public OutputPin Operation_ProvidedInterface_B_setPActivity_this_result = new();
							public LiteralUnlimitedNatural Operation_ProvidedInterface_B_setPActivity_this_result_LiteralUnlimitedNatural61 = new();
							public LiteralInteger Operation_ProvidedInterface_B_setPActivity_this_result_LiteralInteger62 = new();
				public Property Operation_ProvidedInterface_B_p = new();
			public Association Operation_ProvidedInterface_R = new();
				public Property Operation_ProvidedInterface_R_y = new();
				public Property Operation_ProvidedInterface_R_x = new();
			public Class_ Operation_ProvidedInterface_IImpl = new();
				public Operation Operation_ProvidedInterface_IImpl_setP_Integer = new();
					public Parameter Operation_ProvidedInterface_IImpl_setP_Integer_v = new();
				public InterfaceRealization Operation_ProvidedInterface_IImpl_IRealization = new();
			public Interface Operation_ProvidedInterface_I = new();
				public Operation Operation_ProvidedInterface_I_setP_Integer = new();
					public Parameter Operation_ProvidedInterface_I_setP_Integer_v = new();
			public Class_ Operation_ProvidedInterface_A = new();
				public Property Operation_ProvidedInterface_A_b = new();
				public Operation Operation_ProvidedInterface_A_setP_Integer = new();
					public Parameter Operation_ProvidedInterface_A_setP_Integer_v = new();
				public Operation Operation_ProvidedInterface_A_A_A = new();
					public Parameter Operation_ProvidedInterface_A_A_A_result = new();
				public Connector Operation_ProvidedInterface_A_r = new();
					public ConnectorEnd Operation_ProvidedInterface_A_r_ConnectorEnd63 = new();
					public ConnectorEnd Operation_ProvidedInterface_A_r_ConnectorEnd64 = new();
				public Activity Operation_ProvidedInterface_A_setPActivity = new();
					public Parameter Operation_ProvidedInterface_A_setPActivity_v = new();
					public ReadSelfAction Operation_ProvidedInterface_A_setPActivity_this = new();
						public OutputPin Operation_ProvidedInterface_A_setPActivity_this_result = new();
							public LiteralUnlimitedNatural Operation_ProvidedInterface_A_setPActivity_this_result_LiteralUnlimitedNatural65 = new();
							public LiteralInteger Operation_ProvidedInterface_A_setPActivity_this_result_LiteralInteger66 = new();
					public CallOperationAction Operation_ProvidedInterface_A_setPActivity_Call_I_setP_on_q = new();
						public InputPin Operation_ProvidedInterface_A_setPActivity_Call_I_setP_on_q_target = new();
							public LiteralUnlimitedNatural Operation_ProvidedInterface_A_setPActivity_Call_I_setP_on_q_target_LiteralUnlimitedNatural67 = new();
							public LiteralInteger Operation_ProvidedInterface_A_setPActivity_Call_I_setP_on_q_target_LiteralInteger68 = new();
						public InputPin Operation_ProvidedInterface_A_setPActivity_Call_I_setP_on_q_v = new();
							public LiteralInteger Operation_ProvidedInterface_A_setPActivity_Call_I_setP_on_q_v_LiteralInteger69 = new();
							public LiteralInteger Operation_ProvidedInterface_A_setPActivity_Call_I_setP_on_q_v_LiteralInteger70 = new();
							public LiteralUnlimitedNatural Operation_ProvidedInterface_A_setPActivity_Call_I_setP_on_q_v_LiteralUnlimitedNatural71 = new();
					public ActivityParameterNode Operation_ProvidedInterface_A_setPActivity_vParameterNode = new();
						public LiteralInteger Operation_ProvidedInterface_A_setPActivity_vParameterNode_LiteralInteger72 = new();
					public ObjectFlow Operation_ProvidedInterface_A_setPActivity_ObjectFlow73 = new();
						public LiteralBoolean Operation_ProvidedInterface_A_setPActivity_ObjectFlow73_LiteralBoolean74 = new();
						public LiteralInteger Operation_ProvidedInterface_A_setPActivity_ObjectFlow73_LiteralInteger75 = new();
					public ObjectFlow Operation_ProvidedInterface_A_setPActivity_ObjectFlow76 = new();
						public LiteralBoolean Operation_ProvidedInterface_A_setPActivity_ObjectFlow76_LiteralBoolean77 = new();
						public LiteralInteger Operation_ProvidedInterface_A_setPActivity_ObjectFlow76_LiteralInteger78 = new();
				public Port Operation_ProvidedInterface_A_q = new();
			public Association Operation_ProvidedInterface_S = new();
				public Property Operation_ProvidedInterface_S_x = new();
				public Property Operation_ProvidedInterface_S_y = new();

		public static Operation_ProvidedInterfaceModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public Operation_ProvidedInterfaceModel()
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
			 * Model Operation_ProvidedInterface
			 */
			AddToElementRepository("Operation_ProvidedInterface", Operation_ProvidedInterface);
				AddToElementRepository("main", Operation_ProvidedInterface_main);
					AddToElementRepository("Read b.p", Operation_ProvidedInterface_main_Read_b_p);
						AddToElementRepository("result", Operation_ProvidedInterface_main_Read_b_p_result);
							AddToElementRepository("LiteralInteger0", Operation_ProvidedInterface_main_Read_b_p_result_LiteralInteger0);
							AddToElementRepository("LiteralUnlimitedNatural1", Operation_ProvidedInterface_main_Read_b_p_result_LiteralUnlimitedNatural1);
						AddToElementRepository("object", Operation_ProvidedInterface_main_Read_b_p_object);
							AddToElementRepository("LiteralInteger2", Operation_ProvidedInterface_main_Read_b_p_object_LiteralInteger2);
							AddToElementRepository("LiteralUnlimitedNatural3", Operation_ProvidedInterface_main_Read_b_p_object_LiteralUnlimitedNatural3);
					AddToElementRepository("Create A", Operation_ProvidedInterface_main_Create_A);
						AddToElementRepository("result", Operation_ProvidedInterface_main_Create_A_result);
							AddToElementRepository("LiteralUnlimitedNatural4", Operation_ProvidedInterface_main_Create_A_result_LiteralUnlimitedNatural4);
							AddToElementRepository("LiteralInteger5", Operation_ProvidedInterface_main_Create_A_result_LiteralInteger5);
					AddToElementRepository("A()", Operation_ProvidedInterface_main_A_);
						AddToElementRepository("result", Operation_ProvidedInterface_main_A__result);
							AddToElementRepository("LiteralUnlimitedNatural6", Operation_ProvidedInterface_main_A__result_LiteralUnlimitedNatural6);
							AddToElementRepository("LiteralInteger7", Operation_ProvidedInterface_main_A__result_LiteralInteger7);
							AddToElementRepository("LiteralInteger8", Operation_ProvidedInterface_main_A__result_LiteralInteger8);
						AddToElementRepository("target", Operation_ProvidedInterface_main_A__target);
							AddToElementRepository("LiteralInteger9", Operation_ProvidedInterface_main_A__target_LiteralInteger9);
							AddToElementRepository("LiteralUnlimitedNatural10", Operation_ProvidedInterface_main_A__target_LiteralUnlimitedNatural10);
					AddToElementRepository("ObjectFlow11", Operation_ProvidedInterface_main_ObjectFlow11);
						AddToElementRepository("LiteralBoolean12", Operation_ProvidedInterface_main_ObjectFlow11_LiteralBoolean12);
						AddToElementRepository("LiteralInteger13", Operation_ProvidedInterface_main_ObjectFlow11_LiteralInteger13);
					AddToElementRepository("testP", Operation_ProvidedInterface_main_testP);
						AddToElementRepository("p", Operation_ProvidedInterface_main_testP_p);
					AddToElementRepository("ObjectFlow14", Operation_ProvidedInterface_main_ObjectFlow14);
						AddToElementRepository("LiteralBoolean15", Operation_ProvidedInterface_main_ObjectFlow14_LiteralBoolean15);
						AddToElementRepository("LiteralInteger16", Operation_ProvidedInterface_main_ObjectFlow14_LiteralInteger16);
					AddToElementRepository("ObjectFlow17", Operation_ProvidedInterface_main_ObjectFlow17);
						AddToElementRepository("LiteralInteger18", Operation_ProvidedInterface_main_ObjectFlow17_LiteralInteger18);
						AddToElementRepository("LiteralBoolean19", Operation_ProvidedInterface_main_ObjectFlow17_LiteralBoolean19);
					AddToElementRepository("ObjectFlow20", Operation_ProvidedInterface_main_ObjectFlow20);
						AddToElementRepository("LiteralBoolean21", Operation_ProvidedInterface_main_ObjectFlow20_LiteralBoolean21);
						AddToElementRepository("LiteralInteger22", Operation_ProvidedInterface_main_ObjectFlow20_LiteralInteger22);
					AddToElementRepository("Call setP()", Operation_ProvidedInterface_main_Call_setP_);
						AddToElementRepository("target", Operation_ProvidedInterface_main_Call_setP__target);
							AddToElementRepository("LiteralUnlimitedNatural23", Operation_ProvidedInterface_main_Call_setP__target_LiteralUnlimitedNatural23);
							AddToElementRepository("LiteralInteger24", Operation_ProvidedInterface_main_Call_setP__target_LiteralInteger24);
						AddToElementRepository("v", Operation_ProvidedInterface_main_Call_setP__v);
							AddToElementRepository("LiteralInteger25", Operation_ProvidedInterface_main_Call_setP__v_LiteralInteger25);
							AddToElementRepository("LiteralUnlimitedNatural26", Operation_ProvidedInterface_main_Call_setP__v_LiteralUnlimitedNatural26);
							AddToElementRepository("LiteralInteger27", Operation_ProvidedInterface_main_Call_setP__v_LiteralInteger27);
					AddToElementRepository("Call testP", Operation_ProvidedInterface_main_Call_testP);
						AddToElementRepository("p", Operation_ProvidedInterface_main_Call_testP_p);
							AddToElementRepository("LiteralInteger28", Operation_ProvidedInterface_main_Call_testP_p_LiteralInteger28);
							AddToElementRepository("LiteralInteger29", Operation_ProvidedInterface_main_Call_testP_p_LiteralInteger29);
							AddToElementRepository("LiteralUnlimitedNatural30", Operation_ProvidedInterface_main_Call_testP_p_LiteralUnlimitedNatural30);
					AddToElementRepository("ControlFlow31", Operation_ProvidedInterface_main_ControlFlow31);
					AddToElementRepository("ObjectFlow32", Operation_ProvidedInterface_main_ObjectFlow32);
						AddToElementRepository("LiteralBoolean33", Operation_ProvidedInterface_main_ObjectFlow32_LiteralBoolean33);
						AddToElementRepository("LiteralInteger34", Operation_ProvidedInterface_main_ObjectFlow32_LiteralInteger34);
					AddToElementRepository("ObjectFlow35", Operation_ProvidedInterface_main_ObjectFlow35);
						AddToElementRepository("LiteralInteger36", Operation_ProvidedInterface_main_ObjectFlow35_LiteralInteger36);
						AddToElementRepository("LiteralBoolean37", Operation_ProvidedInterface_main_ObjectFlow35_LiteralBoolean37);
					AddToElementRepository("Fork a", Operation_ProvidedInterface_main_Fork_a);
					AddToElementRepository("Value(4)", Operation_ProvidedInterface_main_Value_4);
						AddToElementRepository("result", Operation_ProvidedInterface_main_Value_4_result);
							AddToElementRepository("LiteralUnlimitedNatural38", Operation_ProvidedInterface_main_Value_4_result_LiteralUnlimitedNatural38);
							AddToElementRepository("LiteralInteger39", Operation_ProvidedInterface_main_Value_4_result_LiteralInteger39);
						AddToElementRepository("LiteralInteger40", Operation_ProvidedInterface_main_Value_4_LiteralInteger40);
					AddToElementRepository("ObjectFlow41", Operation_ProvidedInterface_main_ObjectFlow41);
						AddToElementRepository("LiteralBoolean42", Operation_ProvidedInterface_main_ObjectFlow41_LiteralBoolean42);
						AddToElementRepository("LiteralInteger43", Operation_ProvidedInterface_main_ObjectFlow41_LiteralInteger43);
					AddToElementRepository("Read a.b", Operation_ProvidedInterface_main_Read_a_b);
						AddToElementRepository("result", Operation_ProvidedInterface_main_Read_a_b_result);
							AddToElementRepository("LiteralUnlimitedNatural44", Operation_ProvidedInterface_main_Read_a_b_result_LiteralUnlimitedNatural44);
							AddToElementRepository("LiteralInteger45", Operation_ProvidedInterface_main_Read_a_b_result_LiteralInteger45);
						AddToElementRepository("object", Operation_ProvidedInterface_main_Read_a_b_object);
							AddToElementRepository("LiteralInteger46", Operation_ProvidedInterface_main_Read_a_b_object_LiteralInteger46);
							AddToElementRepository("LiteralUnlimitedNatural47", Operation_ProvidedInterface_main_Read_a_b_object_LiteralUnlimitedNatural47);
				AddToElementRepository("B", Operation_ProvidedInterface_B);
					AddToElementRepository("IRealization", Operation_ProvidedInterface_B_IRealization);
					AddToElementRepository("setP_Integer", Operation_ProvidedInterface_B_setP_Integer);
						AddToElementRepository("v", Operation_ProvidedInterface_B_setP_Integer_v);
					AddToElementRepository("setPActivity", Operation_ProvidedInterface_B_setPActivity);
						AddToElementRepository("ObjectFlow48", Operation_ProvidedInterface_B_setPActivity_ObjectFlow48);
							AddToElementRepository("LiteralBoolean49", Operation_ProvidedInterface_B_setPActivity_ObjectFlow48_LiteralBoolean49);
							AddToElementRepository("LiteralInteger50", Operation_ProvidedInterface_B_setPActivity_ObjectFlow48_LiteralInteger50);
						AddToElementRepository("ObjectFlow51", Operation_ProvidedInterface_B_setPActivity_ObjectFlow51);
							AddToElementRepository("LiteralInteger52", Operation_ProvidedInterface_B_setPActivity_ObjectFlow51_LiteralInteger52);
							AddToElementRepository("LiteralBoolean53", Operation_ProvidedInterface_B_setPActivity_ObjectFlow51_LiteralBoolean53);
						AddToElementRepository("v", Operation_ProvidedInterface_B_setPActivity_v);
						AddToElementRepository("vParameterNode", Operation_ProvidedInterface_B_setPActivity_vParameterNode);
							AddToElementRepository("LiteralInteger54", Operation_ProvidedInterface_B_setPActivity_vParameterNode_LiteralInteger54);
						AddToElementRepository("Set this.p", Operation_ProvidedInterface_B_setPActivity_Set_this_p);
							AddToElementRepository("object", Operation_ProvidedInterface_B_setPActivity_Set_this_p_object);
								AddToElementRepository("LiteralUnlimitedNatural55", Operation_ProvidedInterface_B_setPActivity_Set_this_p_object_LiteralUnlimitedNatural55);
								AddToElementRepository("LiteralInteger56", Operation_ProvidedInterface_B_setPActivity_Set_this_p_object_LiteralInteger56);
							AddToElementRepository("result", Operation_ProvidedInterface_B_setPActivity_Set_this_p_result);
								AddToElementRepository("LiteralInteger57", Operation_ProvidedInterface_B_setPActivity_Set_this_p_result_LiteralInteger57);
								AddToElementRepository("LiteralUnlimitedNatural58", Operation_ProvidedInterface_B_setPActivity_Set_this_p_result_LiteralUnlimitedNatural58);
							AddToElementRepository("value", Operation_ProvidedInterface_B_setPActivity_Set_this_p_value);
								AddToElementRepository("LiteralInteger59", Operation_ProvidedInterface_B_setPActivity_Set_this_p_value_LiteralInteger59);
								AddToElementRepository("LiteralUnlimitedNatural60", Operation_ProvidedInterface_B_setPActivity_Set_this_p_value_LiteralUnlimitedNatural60);
						AddToElementRepository("this", Operation_ProvidedInterface_B_setPActivity_this);
							AddToElementRepository("result", Operation_ProvidedInterface_B_setPActivity_this_result);
								AddToElementRepository("LiteralUnlimitedNatural61", Operation_ProvidedInterface_B_setPActivity_this_result_LiteralUnlimitedNatural61);
								AddToElementRepository("LiteralInteger62", Operation_ProvidedInterface_B_setPActivity_this_result_LiteralInteger62);
					AddToElementRepository("p", Operation_ProvidedInterface_B_p);
				AddToElementRepository("R", Operation_ProvidedInterface_R);
					AddToElementRepository("y", Operation_ProvidedInterface_R_y);
					AddToElementRepository("x", Operation_ProvidedInterface_R_x);
				AddToElementRepository("IImpl", Operation_ProvidedInterface_IImpl);
					AddToElementRepository("setP_Integer", Operation_ProvidedInterface_IImpl_setP_Integer);
						AddToElementRepository("v", Operation_ProvidedInterface_IImpl_setP_Integer_v);
					AddToElementRepository("IRealization", Operation_ProvidedInterface_IImpl_IRealization);
				AddToElementRepository("I", Operation_ProvidedInterface_I);
					AddToElementRepository("setP_Integer", Operation_ProvidedInterface_I_setP_Integer);
						AddToElementRepository("v", Operation_ProvidedInterface_I_setP_Integer_v);
				AddToElementRepository("A", Operation_ProvidedInterface_A);
					AddToElementRepository("b", Operation_ProvidedInterface_A_b);
					AddToElementRepository("setP_Integer", Operation_ProvidedInterface_A_setP_Integer);
						AddToElementRepository("v", Operation_ProvidedInterface_A_setP_Integer_v);
					AddToElementRepository("A_A", Operation_ProvidedInterface_A_A_A);
						AddToElementRepository("result", Operation_ProvidedInterface_A_A_A_result);
					AddToElementRepository("r", Operation_ProvidedInterface_A_r);
						AddToElementRepository("ConnectorEnd63", Operation_ProvidedInterface_A_r_ConnectorEnd63);
						AddToElementRepository("ConnectorEnd64", Operation_ProvidedInterface_A_r_ConnectorEnd64);
					AddToElementRepository("setPActivity", Operation_ProvidedInterface_A_setPActivity);
						AddToElementRepository("v", Operation_ProvidedInterface_A_setPActivity_v);
						AddToElementRepository("this", Operation_ProvidedInterface_A_setPActivity_this);
							AddToElementRepository("result", Operation_ProvidedInterface_A_setPActivity_this_result);
								AddToElementRepository("LiteralUnlimitedNatural65", Operation_ProvidedInterface_A_setPActivity_this_result_LiteralUnlimitedNatural65);
								AddToElementRepository("LiteralInteger66", Operation_ProvidedInterface_A_setPActivity_this_result_LiteralInteger66);
						AddToElementRepository("Call I::setP on q", Operation_ProvidedInterface_A_setPActivity_Call_I_setP_on_q);
							AddToElementRepository("target", Operation_ProvidedInterface_A_setPActivity_Call_I_setP_on_q_target);
								AddToElementRepository("LiteralUnlimitedNatural67", Operation_ProvidedInterface_A_setPActivity_Call_I_setP_on_q_target_LiteralUnlimitedNatural67);
								AddToElementRepository("LiteralInteger68", Operation_ProvidedInterface_A_setPActivity_Call_I_setP_on_q_target_LiteralInteger68);
							AddToElementRepository("v", Operation_ProvidedInterface_A_setPActivity_Call_I_setP_on_q_v);
								AddToElementRepository("LiteralInteger69", Operation_ProvidedInterface_A_setPActivity_Call_I_setP_on_q_v_LiteralInteger69);
								AddToElementRepository("LiteralInteger70", Operation_ProvidedInterface_A_setPActivity_Call_I_setP_on_q_v_LiteralInteger70);
								AddToElementRepository("LiteralUnlimitedNatural71", Operation_ProvidedInterface_A_setPActivity_Call_I_setP_on_q_v_LiteralUnlimitedNatural71);
						AddToElementRepository("vParameterNode", Operation_ProvidedInterface_A_setPActivity_vParameterNode);
							AddToElementRepository("LiteralInteger72", Operation_ProvidedInterface_A_setPActivity_vParameterNode_LiteralInteger72);
						AddToElementRepository("ObjectFlow73", Operation_ProvidedInterface_A_setPActivity_ObjectFlow73);
							AddToElementRepository("LiteralBoolean74", Operation_ProvidedInterface_A_setPActivity_ObjectFlow73_LiteralBoolean74);
							AddToElementRepository("LiteralInteger75", Operation_ProvidedInterface_A_setPActivity_ObjectFlow73_LiteralInteger75);
						AddToElementRepository("ObjectFlow76", Operation_ProvidedInterface_A_setPActivity_ObjectFlow76);
							AddToElementRepository("LiteralBoolean77", Operation_ProvidedInterface_A_setPActivity_ObjectFlow76_LiteralBoolean77);
							AddToElementRepository("LiteralInteger78", Operation_ProvidedInterface_A_setPActivity_ObjectFlow76_LiteralInteger78);
					AddToElementRepository("q", Operation_ProvidedInterface_A_q);
				AddToElementRepository("S", Operation_ProvidedInterface_S);
					AddToElementRepository("x", Operation_ProvidedInterface_S_x);
					AddToElementRepository("y", Operation_ProvidedInterface_S_y);

			// Initialize public members
			/*
			 * Model Operation_ProvidedInterface
			 */
			Operation_ProvidedInterface.SetName("Operation_ProvidedInterface");
			Operation_ProvidedInterface.SetVisibility(VisibilityKind.public_);
				// Activity main
				Operation_ProvidedInterface_main.SetName("main");
				Operation_ProvidedInterface_main.SetVisibility(VisibilityKind.public_);
				// FunctionBehavior testP
					Operation_ProvidedInterface_main_testP.SetName("testP");
					Operation_ProvidedInterface_main_testP.SetVisibility(VisibilityKind.public_);
					
						// Parameter p
						Operation_ProvidedInterface_main_testP_p.SetName("p");
						Operation_ProvidedInterface_main_testP_p.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedInterface_main_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_ProvidedInterface_main_testP.AddOwnedParameter(Operation_ProvidedInterface_main_testP_p);
					Operation_ProvidedInterface_main_testP.AddLanguage("C#");
					Operation_ProvidedInterface_main_testP.AddLanguage("Using");
					Operation_ProvidedInterface_main_testP.AddBody("Console.WriteLine(\"Asserting a.b.p == 4\");  	// Test parameter p 	int p = ((IntegerValue)inputParameters.ElementAt(0).values.ElementAt(0)).value; 	Debug.Println(\"[doBody] argument p = \" + p); 	 	Console.WriteLine(\"a.b.p == \" + p); 	Console.Write(\"Invocation made into a through q: \");  	if(p == 4) 	{ 		Console.ForegroundColor = ConsoleColor.Green; 		Console.WriteLine(\"Assertion successful.\"); 	} 	else 	{ 		Console.ForegroundColor = ConsoleColor.Red; 		Console.WriteLine(\"Assertion failed!\"); 	}  	Console.ResetColor();");
					Operation_ProvidedInterface_main_testP.AddBody("using fuml.semantics.simpleclassifiers; ");
				Operation_ProvidedInterface_main.AddOwnedBehavior(Operation_ProvidedInterface_main_testP);
					// ReadStructuralFeatureAction Read b.p
					Operation_ProvidedInterface_main_Read_b_p.SetName("Read b.p");
					Operation_ProvidedInterface_main_Read_b_p.SetVisibility(VisibilityKind.public_);
					Operation_ProvidedInterface_main_Read_b_p.SetStructuralFeature(Operation_ProvidedInterface_B_p);
						// InputPin object
						Operation_ProvidedInterface_main_Read_b_p_object.SetName("object");
						Operation_ProvidedInterface_main_Read_b_p_object.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedInterface_main_Read_b_p_object.SetType(Operation_ProvidedInterface_B);
					Operation_ProvidedInterface_main_Read_b_p.SetObject(Operation_ProvidedInterface_main_Read_b_p_object);
						// OutputPin result
						Operation_ProvidedInterface_main_Read_b_p_result.SetName("result");
						Operation_ProvidedInterface_main_Read_b_p_result.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedInterface_main_Read_b_p_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_ProvidedInterface_main_Read_b_p.SetResult(Operation_ProvidedInterface_main_Read_b_p_result);
				Operation_ProvidedInterface_main.AddNode(Operation_ProvidedInterface_main_Read_b_p);
					// CreateObjectAction Create A
					Operation_ProvidedInterface_main_Create_A.SetName("Create A");
					Operation_ProvidedInterface_main_Create_A.SetVisibility(VisibilityKind.public_);
					Operation_ProvidedInterface_main_Create_A.SetClassifier(Operation_ProvidedInterface_A);
						// OutputPin result
						Operation_ProvidedInterface_main_Create_A_result.SetName("result");
						Operation_ProvidedInterface_main_Create_A_result.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedInterface_main_Create_A_result.SetType(Operation_ProvidedInterface_A);
					Operation_ProvidedInterface_main_Create_A.SetResult(Operation_ProvidedInterface_main_Create_A_result);
				Operation_ProvidedInterface_main.AddNode(Operation_ProvidedInterface_main_Create_A);
					// CallOperationAction Call setP()
					Operation_ProvidedInterface_main_Call_setP_.SetName("Call setP()");
					Operation_ProvidedInterface_main_Call_setP_.SetVisibility(VisibilityKind.public_);
					Operation_ProvidedInterface_main_Call_setP_.SetOperation(Operation_ProvidedInterface_A_setP_Integer);
						// InputPin target
						Operation_ProvidedInterface_main_Call_setP__target.SetName("target");
						Operation_ProvidedInterface_main_Call_setP__target.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedInterface_main_Call_setP__target.SetType(Operation_ProvidedInterface_A);
					Operation_ProvidedInterface_main_Call_setP_.SetTarget(Operation_ProvidedInterface_main_Call_setP__target);
						// InputPin v
						Operation_ProvidedInterface_main_Call_setP__v.SetName("v");
						Operation_ProvidedInterface_main_Call_setP__v.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedInterface_main_Call_setP__v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_ProvidedInterface_main_Call_setP_.AddArgument(Operation_ProvidedInterface_main_Call_setP__v);
				Operation_ProvidedInterface_main.AddNode(Operation_ProvidedInterface_main_Call_setP_);
					// CallOperationAction A()
					Operation_ProvidedInterface_main_A_.SetName("A()");
					Operation_ProvidedInterface_main_A_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						Operation_ProvidedInterface_main_A__result.SetName("result");
						Operation_ProvidedInterface_main_A__result.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedInterface_main_A__result.SetType(Operation_ProvidedInterface_A);
					Operation_ProvidedInterface_main_A_.AddResult(Operation_ProvidedInterface_main_A__result);
					Operation_ProvidedInterface_main_A_.SetOperation(Operation_ProvidedInterface_A_A_A);
						// InputPin target
						Operation_ProvidedInterface_main_A__target.SetName("target");
						Operation_ProvidedInterface_main_A__target.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedInterface_main_A__target.SetType(Operation_ProvidedInterface_A);
					Operation_ProvidedInterface_main_A_.SetTarget(Operation_ProvidedInterface_main_A__target);
				Operation_ProvidedInterface_main.AddNode(Operation_ProvidedInterface_main_A_);
					// CallBehaviorAction Call testP
					Operation_ProvidedInterface_main_Call_testP.SetName("Call testP");
					Operation_ProvidedInterface_main_Call_testP.SetVisibility(VisibilityKind.public_);
					Operation_ProvidedInterface_main_Call_testP.SetBehavior(Operation_ProvidedInterface_main_testP);
						// InputPin p
						Operation_ProvidedInterface_main_Call_testP_p.SetName("p");
						Operation_ProvidedInterface_main_Call_testP_p.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedInterface_main_Call_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_ProvidedInterface_main_Call_testP.AddArgument(Operation_ProvidedInterface_main_Call_testP_p);
				Operation_ProvidedInterface_main.AddNode(Operation_ProvidedInterface_main_Call_testP);
					// ForkNode Fork a
					Operation_ProvidedInterface_main_Fork_a.SetName("Fork a");
					Operation_ProvidedInterface_main_Fork_a.SetVisibility(VisibilityKind.public_);
				Operation_ProvidedInterface_main.AddNode(Operation_ProvidedInterface_main_Fork_a);
					// ValueSpecificationAction Value(4)
					Operation_ProvidedInterface_main_Value_4.SetName("Value(4)");
					Operation_ProvidedInterface_main_Value_4.SetVisibility(VisibilityKind.public_);
						// LiteralInteger LiteralInteger40
						Operation_ProvidedInterface_main_Value_4_LiteralInteger40.SetName("LiteralInteger40");
						Operation_ProvidedInterface_main_Value_4_LiteralInteger40.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedInterface_main_Value_4_LiteralInteger40.SetValue(4);
					Operation_ProvidedInterface_main_Value_4.SetValue(Operation_ProvidedInterface_main_Value_4_LiteralInteger40);
						// OutputPin result
						Operation_ProvidedInterface_main_Value_4_result.SetName("result");
						Operation_ProvidedInterface_main_Value_4_result.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedInterface_main_Value_4_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_ProvidedInterface_main_Value_4.SetResult(Operation_ProvidedInterface_main_Value_4_result);
				Operation_ProvidedInterface_main.AddNode(Operation_ProvidedInterface_main_Value_4);
					// ReadStructuralFeatureAction Read a.b
					Operation_ProvidedInterface_main_Read_a_b.SetName("Read a.b");
					Operation_ProvidedInterface_main_Read_a_b.SetVisibility(VisibilityKind.public_);
					Operation_ProvidedInterface_main_Read_a_b.SetStructuralFeature(Operation_ProvidedInterface_A_b);
						// InputPin object
						Operation_ProvidedInterface_main_Read_a_b_object.SetName("object");
						Operation_ProvidedInterface_main_Read_a_b_object.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedInterface_main_Read_a_b_object.SetType(Operation_ProvidedInterface_A);
					Operation_ProvidedInterface_main_Read_a_b.SetObject(Operation_ProvidedInterface_main_Read_a_b_object);
						// OutputPin result
						Operation_ProvidedInterface_main_Read_a_b_result.SetName("result");
						Operation_ProvidedInterface_main_Read_a_b_result.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedInterface_main_Read_a_b_result.SetType(Operation_ProvidedInterface_B);
					Operation_ProvidedInterface_main_Read_a_b.SetResult(Operation_ProvidedInterface_main_Read_a_b_result);
				Operation_ProvidedInterface_main.AddNode(Operation_ProvidedInterface_main_Read_a_b);
					// ObjectFlow ObjectFlow17 from result to Fork a
					Operation_ProvidedInterface_main_ObjectFlow17.SetName("ObjectFlow17");
					Operation_ProvidedInterface_main_ObjectFlow17.SetVisibility(VisibilityKind.public_);
					
					Operation_ProvidedInterface_main_ObjectFlow17.SetSource(Operation_ProvidedInterface_main_A__result);
					Operation_ProvidedInterface_main_ObjectFlow17.SetTarget(Operation_ProvidedInterface_main_Fork_a);
						// LiteralBoolean LiteralBoolean19
						Operation_ProvidedInterface_main_ObjectFlow17_LiteralBoolean19.SetName("LiteralBoolean19");
						Operation_ProvidedInterface_main_ObjectFlow17_LiteralBoolean19.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedInterface_main_ObjectFlow17_LiteralBoolean19.SetValue(true);
					Operation_ProvidedInterface_main_ObjectFlow17.SetGuard(Operation_ProvidedInterface_main_ObjectFlow17_LiteralBoolean19);
				Operation_ProvidedInterface_main.AddEdge(Operation_ProvidedInterface_main_ObjectFlow17);
					// ObjectFlow ObjectFlow20 from result to v
					Operation_ProvidedInterface_main_ObjectFlow20.SetName("ObjectFlow20");
					Operation_ProvidedInterface_main_ObjectFlow20.SetVisibility(VisibilityKind.public_);
					
					Operation_ProvidedInterface_main_ObjectFlow20.SetSource(Operation_ProvidedInterface_main_Value_4_result);
					Operation_ProvidedInterface_main_ObjectFlow20.SetTarget(Operation_ProvidedInterface_main_Call_setP__v);
						// LiteralBoolean LiteralBoolean21
						Operation_ProvidedInterface_main_ObjectFlow20_LiteralBoolean21.SetName("LiteralBoolean21");
						Operation_ProvidedInterface_main_ObjectFlow20_LiteralBoolean21.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedInterface_main_ObjectFlow20_LiteralBoolean21.SetValue(true);
					Operation_ProvidedInterface_main_ObjectFlow20.SetGuard(Operation_ProvidedInterface_main_ObjectFlow20_LiteralBoolean21);
				Operation_ProvidedInterface_main.AddEdge(Operation_ProvidedInterface_main_ObjectFlow20);
					// ObjectFlow ObjectFlow11 from result to p
					Operation_ProvidedInterface_main_ObjectFlow11.SetName("ObjectFlow11");
					Operation_ProvidedInterface_main_ObjectFlow11.SetVisibility(VisibilityKind.public_);
					
					Operation_ProvidedInterface_main_ObjectFlow11.SetSource(Operation_ProvidedInterface_main_Read_b_p_result);
					Operation_ProvidedInterface_main_ObjectFlow11.SetTarget(Operation_ProvidedInterface_main_Call_testP_p);
						// LiteralBoolean LiteralBoolean12
						Operation_ProvidedInterface_main_ObjectFlow11_LiteralBoolean12.SetName("LiteralBoolean12");
						Operation_ProvidedInterface_main_ObjectFlow11_LiteralBoolean12.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedInterface_main_ObjectFlow11_LiteralBoolean12.SetValue(true);
					Operation_ProvidedInterface_main_ObjectFlow11.SetGuard(Operation_ProvidedInterface_main_ObjectFlow11_LiteralBoolean12);
				Operation_ProvidedInterface_main.AddEdge(Operation_ProvidedInterface_main_ObjectFlow11);
					// ControlFlow ControlFlow31 from Call setP() to Read a.b
					Operation_ProvidedInterface_main_ControlFlow31.SetName("ControlFlow31");
					Operation_ProvidedInterface_main_ControlFlow31.SetVisibility(VisibilityKind.public_);
					
					Operation_ProvidedInterface_main_ControlFlow31.SetSource(Operation_ProvidedInterface_main_Call_setP_);
					Operation_ProvidedInterface_main_ControlFlow31.SetTarget(Operation_ProvidedInterface_main_Read_a_b);
				Operation_ProvidedInterface_main.AddEdge(Operation_ProvidedInterface_main_ControlFlow31);
					// ObjectFlow ObjectFlow32 from result to target
					Operation_ProvidedInterface_main_ObjectFlow32.SetName("ObjectFlow32");
					Operation_ProvidedInterface_main_ObjectFlow32.SetVisibility(VisibilityKind.public_);
					
					Operation_ProvidedInterface_main_ObjectFlow32.SetSource(Operation_ProvidedInterface_main_Create_A_result);
					Operation_ProvidedInterface_main_ObjectFlow32.SetTarget(Operation_ProvidedInterface_main_A__target);
						// LiteralBoolean LiteralBoolean33
						Operation_ProvidedInterface_main_ObjectFlow32_LiteralBoolean33.SetName("LiteralBoolean33");
						Operation_ProvidedInterface_main_ObjectFlow32_LiteralBoolean33.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedInterface_main_ObjectFlow32_LiteralBoolean33.SetValue(true);
					Operation_ProvidedInterface_main_ObjectFlow32.SetGuard(Operation_ProvidedInterface_main_ObjectFlow32_LiteralBoolean33);
				Operation_ProvidedInterface_main.AddEdge(Operation_ProvidedInterface_main_ObjectFlow32);
					// ObjectFlow ObjectFlow35 from Fork a to object
					Operation_ProvidedInterface_main_ObjectFlow35.SetName("ObjectFlow35");
					Operation_ProvidedInterface_main_ObjectFlow35.SetVisibility(VisibilityKind.public_);
					
					Operation_ProvidedInterface_main_ObjectFlow35.SetSource(Operation_ProvidedInterface_main_Fork_a);
					Operation_ProvidedInterface_main_ObjectFlow35.SetTarget(Operation_ProvidedInterface_main_Read_a_b_object);
						// LiteralBoolean LiteralBoolean37
						Operation_ProvidedInterface_main_ObjectFlow35_LiteralBoolean37.SetName("LiteralBoolean37");
						Operation_ProvidedInterface_main_ObjectFlow35_LiteralBoolean37.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedInterface_main_ObjectFlow35_LiteralBoolean37.SetValue(true);
					Operation_ProvidedInterface_main_ObjectFlow35.SetGuard(Operation_ProvidedInterface_main_ObjectFlow35_LiteralBoolean37);
				Operation_ProvidedInterface_main.AddEdge(Operation_ProvidedInterface_main_ObjectFlow35);
					// ObjectFlow ObjectFlow14 from result to object
					Operation_ProvidedInterface_main_ObjectFlow14.SetName("ObjectFlow14");
					Operation_ProvidedInterface_main_ObjectFlow14.SetVisibility(VisibilityKind.public_);
					
					Operation_ProvidedInterface_main_ObjectFlow14.SetSource(Operation_ProvidedInterface_main_Read_a_b_result);
					Operation_ProvidedInterface_main_ObjectFlow14.SetTarget(Operation_ProvidedInterface_main_Read_b_p_object);
						// LiteralBoolean LiteralBoolean15
						Operation_ProvidedInterface_main_ObjectFlow14_LiteralBoolean15.SetName("LiteralBoolean15");
						Operation_ProvidedInterface_main_ObjectFlow14_LiteralBoolean15.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedInterface_main_ObjectFlow14_LiteralBoolean15.SetValue(true);
					Operation_ProvidedInterface_main_ObjectFlow14.SetGuard(Operation_ProvidedInterface_main_ObjectFlow14_LiteralBoolean15);
				Operation_ProvidedInterface_main.AddEdge(Operation_ProvidedInterface_main_ObjectFlow14);
					// ObjectFlow ObjectFlow41 from Fork a to target
					Operation_ProvidedInterface_main_ObjectFlow41.SetName("ObjectFlow41");
					Operation_ProvidedInterface_main_ObjectFlow41.SetVisibility(VisibilityKind.public_);
					
					Operation_ProvidedInterface_main_ObjectFlow41.SetSource(Operation_ProvidedInterface_main_Fork_a);
					Operation_ProvidedInterface_main_ObjectFlow41.SetTarget(Operation_ProvidedInterface_main_Call_setP__target);
						// LiteralBoolean LiteralBoolean42
						Operation_ProvidedInterface_main_ObjectFlow41_LiteralBoolean42.SetName("LiteralBoolean42");
						Operation_ProvidedInterface_main_ObjectFlow41_LiteralBoolean42.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedInterface_main_ObjectFlow41_LiteralBoolean42.SetValue(true);
					Operation_ProvidedInterface_main_ObjectFlow41.SetGuard(Operation_ProvidedInterface_main_ObjectFlow41_LiteralBoolean42);
				Operation_ProvidedInterface_main.AddEdge(Operation_ProvidedInterface_main_ObjectFlow41);
			Operation_ProvidedInterface.AddPackagedElement(Operation_ProvidedInterface_main);
				// Class B
				Operation_ProvidedInterface_B.SetName("B");
				Operation_ProvidedInterface_B.SetVisibility(VisibilityKind.public_);
				
					// Property p
					Operation_ProvidedInterface_B_p.SetName("p");
					Operation_ProvidedInterface_B_p.SetVisibility(VisibilityKind.public_);
					
					Operation_ProvidedInterface_B_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
				Operation_ProvidedInterface_B.AddOwnedAttribute(Operation_ProvidedInterface_B_p);
				// Activity setPActivity
					Operation_ProvidedInterface_B_setPActivity.SetName("setPActivity");
					Operation_ProvidedInterface_B_setPActivity.SetVisibility(VisibilityKind.public_);
					
						// Parameter v
						Operation_ProvidedInterface_B_setPActivity_v.SetName("v");
						Operation_ProvidedInterface_B_setPActivity_v.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedInterface_B_setPActivity_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_ProvidedInterface_B_setPActivity.AddOwnedParameter(Operation_ProvidedInterface_B_setPActivity_v);
						// ActivityParameterNode vParameterNode
						Operation_ProvidedInterface_B_setPActivity_vParameterNode.SetName("vParameterNode");
						Operation_ProvidedInterface_B_setPActivity_vParameterNode.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedInterface_B_setPActivity_vParameterNode.SetParameter(Operation_ProvidedInterface_B_setPActivity_v);
					Operation_ProvidedInterface_B_setPActivity.AddNode(Operation_ProvidedInterface_B_setPActivity_vParameterNode);
						// AddStructuralFeatureValueAction Set this.p
						Operation_ProvidedInterface_B_setPActivity_Set_this_p.SetName("Set this.p");
						Operation_ProvidedInterface_B_setPActivity_Set_this_p.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedInterface_B_setPActivity_Set_this_p.SetStructuralFeature(Operation_ProvidedInterface_B_p);
							// InputPin object
							Operation_ProvidedInterface_B_setPActivity_Set_this_p_object.SetName("object");
							Operation_ProvidedInterface_B_setPActivity_Set_this_p_object.SetVisibility(VisibilityKind.public_);
							Operation_ProvidedInterface_B_setPActivity_Set_this_p_object.SetType(Operation_ProvidedInterface_B);
						Operation_ProvidedInterface_B_setPActivity_Set_this_p.SetObject(Operation_ProvidedInterface_B_setPActivity_Set_this_p_object);
							// InputPin value
							Operation_ProvidedInterface_B_setPActivity_Set_this_p_value.SetName("value");
							Operation_ProvidedInterface_B_setPActivity_Set_this_p_value.SetVisibility(VisibilityKind.public_);
							Operation_ProvidedInterface_B_setPActivity_Set_this_p_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						Operation_ProvidedInterface_B_setPActivity_Set_this_p.SetValue(Operation_ProvidedInterface_B_setPActivity_Set_this_p_value);
							// OutputPin result
							Operation_ProvidedInterface_B_setPActivity_Set_this_p_result.SetName("result");
							Operation_ProvidedInterface_B_setPActivity_Set_this_p_result.SetVisibility(VisibilityKind.public_);
							Operation_ProvidedInterface_B_setPActivity_Set_this_p_result.SetType(Operation_ProvidedInterface_B);
						Operation_ProvidedInterface_B_setPActivity_Set_this_p.SetResult(Operation_ProvidedInterface_B_setPActivity_Set_this_p_result);
						Operation_ProvidedInterface_B_setPActivity_Set_this_p.SetIsReplaceAll(true);
					Operation_ProvidedInterface_B_setPActivity.AddNode(Operation_ProvidedInterface_B_setPActivity_Set_this_p);
						// ReadSelfAction this
						Operation_ProvidedInterface_B_setPActivity_this.SetName("this");
						Operation_ProvidedInterface_B_setPActivity_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							Operation_ProvidedInterface_B_setPActivity_this_result.SetName("result");
							Operation_ProvidedInterface_B_setPActivity_this_result.SetVisibility(VisibilityKind.public_);
							Operation_ProvidedInterface_B_setPActivity_this_result.SetType(Operation_ProvidedInterface_B);
						Operation_ProvidedInterface_B_setPActivity_this.SetResult(Operation_ProvidedInterface_B_setPActivity_this_result);
					Operation_ProvidedInterface_B_setPActivity.AddNode(Operation_ProvidedInterface_B_setPActivity_this);
						// ObjectFlow ObjectFlow48 from vParameterNode to value
						Operation_ProvidedInterface_B_setPActivity_ObjectFlow48.SetName("ObjectFlow48");
						Operation_ProvidedInterface_B_setPActivity_ObjectFlow48.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedInterface_B_setPActivity_ObjectFlow48.SetSource(Operation_ProvidedInterface_B_setPActivity_vParameterNode);
						Operation_ProvidedInterface_B_setPActivity_ObjectFlow48.SetTarget(Operation_ProvidedInterface_B_setPActivity_Set_this_p_value);
							// LiteralBoolean LiteralBoolean49
							Operation_ProvidedInterface_B_setPActivity_ObjectFlow48_LiteralBoolean49.SetName("LiteralBoolean49");
							Operation_ProvidedInterface_B_setPActivity_ObjectFlow48_LiteralBoolean49.SetVisibility(VisibilityKind.public_);
							Operation_ProvidedInterface_B_setPActivity_ObjectFlow48_LiteralBoolean49.SetValue(true);
						Operation_ProvidedInterface_B_setPActivity_ObjectFlow48.SetGuard(Operation_ProvidedInterface_B_setPActivity_ObjectFlow48_LiteralBoolean49);
					Operation_ProvidedInterface_B_setPActivity.AddEdge(Operation_ProvidedInterface_B_setPActivity_ObjectFlow48);
						// ObjectFlow ObjectFlow51 from result to object
						Operation_ProvidedInterface_B_setPActivity_ObjectFlow51.SetName("ObjectFlow51");
						Operation_ProvidedInterface_B_setPActivity_ObjectFlow51.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedInterface_B_setPActivity_ObjectFlow51.SetSource(Operation_ProvidedInterface_B_setPActivity_this_result);
						Operation_ProvidedInterface_B_setPActivity_ObjectFlow51.SetTarget(Operation_ProvidedInterface_B_setPActivity_Set_this_p_object);
							// LiteralBoolean LiteralBoolean53
							Operation_ProvidedInterface_B_setPActivity_ObjectFlow51_LiteralBoolean53.SetName("LiteralBoolean53");
							Operation_ProvidedInterface_B_setPActivity_ObjectFlow51_LiteralBoolean53.SetVisibility(VisibilityKind.public_);
							Operation_ProvidedInterface_B_setPActivity_ObjectFlow51_LiteralBoolean53.SetValue(true);
						Operation_ProvidedInterface_B_setPActivity_ObjectFlow51.SetGuard(Operation_ProvidedInterface_B_setPActivity_ObjectFlow51_LiteralBoolean53);
					Operation_ProvidedInterface_B_setPActivity.AddEdge(Operation_ProvidedInterface_B_setPActivity_ObjectFlow51);
				Operation_ProvidedInterface_B.AddOwnedBehavior(Operation_ProvidedInterface_B_setPActivity);
					Operation_ProvidedInterface_B_IRealization.SetName("IRealization");
					Operation_ProvidedInterface_B_IRealization.SetVisibility(VisibilityKind.public_);
					Operation_ProvidedInterface_B_IRealization.SetContract(Operation_ProvidedInterface_I);
					
				Operation_ProvidedInterface_B.AddInterfaceRealization(Operation_ProvidedInterface_B_IRealization);
				
					// Operation setP_Integer
					Operation_ProvidedInterface_B_setP_Integer.SetName("setP_Integer");
					Operation_ProvidedInterface_B_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						Operation_ProvidedInterface_B_setP_Integer_v.SetName("v");
						Operation_ProvidedInterface_B_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedInterface_B_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_ProvidedInterface_B_setP_Integer.AddOwnedParameter(Operation_ProvidedInterface_B_setP_Integer_v);
					Operation_ProvidedInterface_B_setP_Integer.AddMethod(Operation_ProvidedInterface_B_setPActivity);
				Operation_ProvidedInterface_B.AddOwnedOperation(Operation_ProvidedInterface_B_setP_Integer);
			Operation_ProvidedInterface.AddPackagedElement(Operation_ProvidedInterface_B);
				// Association R
				Operation_ProvidedInterface_R.SetName("R");
				Operation_ProvidedInterface_R.SetVisibility(VisibilityKind.public_);
				Operation_ProvidedInterface_R.AddOwnedEnd(Operation_ProvidedInterface_R_x);
				Operation_ProvidedInterface_R.AddOwnedEnd(Operation_ProvidedInterface_R_y);
			Operation_ProvidedInterface.AddPackagedElement(Operation_ProvidedInterface_R);
				// Class IImpl
				Operation_ProvidedInterface_IImpl.SetName("IImpl");
				Operation_ProvidedInterface_IImpl.SetVisibility(VisibilityKind.public_);
				Operation_ProvidedInterface_IImpl_IRealization.SetName("IRealization");
					Operation_ProvidedInterface_IImpl_IRealization.SetVisibility(VisibilityKind.public_);
					Operation_ProvidedInterface_IImpl_IRealization.SetContract(Operation_ProvidedInterface_I);
					
				Operation_ProvidedInterface_IImpl.AddInterfaceRealization(Operation_ProvidedInterface_IImpl_IRealization);
				
					// Operation setP_Integer
					Operation_ProvidedInterface_IImpl_setP_Integer.SetName("setP_Integer");
					Operation_ProvidedInterface_IImpl_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						Operation_ProvidedInterface_IImpl_setP_Integer_v.SetName("v");
						Operation_ProvidedInterface_IImpl_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedInterface_IImpl_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_ProvidedInterface_IImpl_setP_Integer.AddOwnedParameter(Operation_ProvidedInterface_IImpl_setP_Integer_v);
				Operation_ProvidedInterface_IImpl.AddOwnedOperation(Operation_ProvidedInterface_IImpl_setP_Integer);
			Operation_ProvidedInterface.AddPackagedElement(Operation_ProvidedInterface_IImpl);
				// Interface I
				Operation_ProvidedInterface_I.SetName("I");
				Operation_ProvidedInterface_I.SetVisibility(VisibilityKind.public_);
					// Operation setP_Integer
					Operation_ProvidedInterface_I_setP_Integer.SetName("setP_Integer");
					Operation_ProvidedInterface_I_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						Operation_ProvidedInterface_I_setP_Integer_v.SetName("v");
						Operation_ProvidedInterface_I_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedInterface_I_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_ProvidedInterface_I_setP_Integer.AddOwnedParameter(Operation_ProvidedInterface_I_setP_Integer_v);
				Operation_ProvidedInterface_I.AddOwnedOperation(Operation_ProvidedInterface_I_setP_Integer);
			Operation_ProvidedInterface.AddPackagedElement(Operation_ProvidedInterface_I);
				// Class A
				Operation_ProvidedInterface_A.SetName("A");
				Operation_ProvidedInterface_A.SetVisibility(VisibilityKind.public_);
				
					// Port q
					Operation_ProvidedInterface_A_q.SetName("q");
					Operation_ProvidedInterface_A_q.SetVisibility(VisibilityKind.public_);
					
					Operation_ProvidedInterface_A_q.SetType(Operation_ProvidedInterface_IImpl);
					Operation_ProvidedInterface_A_q.SetAggregation(AggregationKind.composite);
					Operation_ProvidedInterface_A_q.isService = true;
					Operation_ProvidedInterface_A_q.AddProvided(Operation_ProvidedInterface_I);
				Operation_ProvidedInterface_A.AddOwnedAttribute(Operation_ProvidedInterface_A_q);
					// Property b
					Operation_ProvidedInterface_A_b.SetName("b");
					Operation_ProvidedInterface_A_b.SetVisibility(VisibilityKind.public_);
					
					Operation_ProvidedInterface_A_b.SetType(Operation_ProvidedInterface_B);
					Operation_ProvidedInterface_A_b.SetAggregation(AggregationKind.composite);
				Operation_ProvidedInterface_A.AddOwnedAttribute(Operation_ProvidedInterface_A_b);
				// Activity setPActivity
					Operation_ProvidedInterface_A_setPActivity.SetName("setPActivity");
					Operation_ProvidedInterface_A_setPActivity.SetVisibility(VisibilityKind.public_);
					
						// Parameter v
						Operation_ProvidedInterface_A_setPActivity_v.SetName("v");
						Operation_ProvidedInterface_A_setPActivity_v.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedInterface_A_setPActivity_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_ProvidedInterface_A_setPActivity.AddOwnedParameter(Operation_ProvidedInterface_A_setPActivity_v);
						// ReadSelfAction this
						Operation_ProvidedInterface_A_setPActivity_this.SetName("this");
						Operation_ProvidedInterface_A_setPActivity_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							Operation_ProvidedInterface_A_setPActivity_this_result.SetName("result");
							Operation_ProvidedInterface_A_setPActivity_this_result.SetVisibility(VisibilityKind.public_);
							Operation_ProvidedInterface_A_setPActivity_this_result.SetType(Operation_ProvidedInterface_A);
						Operation_ProvidedInterface_A_setPActivity_this.SetResult(Operation_ProvidedInterface_A_setPActivity_this_result);
					Operation_ProvidedInterface_A_setPActivity.AddNode(Operation_ProvidedInterface_A_setPActivity_this);
						// CallOperationAction Call I::setP on q
						Operation_ProvidedInterface_A_setPActivity_Call_I_setP_on_q.SetName("Call I::setP on q");
						Operation_ProvidedInterface_A_setPActivity_Call_I_setP_on_q.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedInterface_A_setPActivity_Call_I_setP_on_q.SetOnPort(Operation_ProvidedInterface_A_q);
						Operation_ProvidedInterface_A_setPActivity_Call_I_setP_on_q.SetOperation(Operation_ProvidedInterface_I_setP_Integer);
							// InputPin target
							Operation_ProvidedInterface_A_setPActivity_Call_I_setP_on_q_target.SetName("target");
							Operation_ProvidedInterface_A_setPActivity_Call_I_setP_on_q_target.SetVisibility(VisibilityKind.public_);
						Operation_ProvidedInterface_A_setPActivity_Call_I_setP_on_q.SetTarget(Operation_ProvidedInterface_A_setPActivity_Call_I_setP_on_q_target);
							// InputPin v
							Operation_ProvidedInterface_A_setPActivity_Call_I_setP_on_q_v.SetName("v");
							Operation_ProvidedInterface_A_setPActivity_Call_I_setP_on_q_v.SetVisibility(VisibilityKind.public_);
							Operation_ProvidedInterface_A_setPActivity_Call_I_setP_on_q_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						Operation_ProvidedInterface_A_setPActivity_Call_I_setP_on_q.AddArgument(Operation_ProvidedInterface_A_setPActivity_Call_I_setP_on_q_v);
					Operation_ProvidedInterface_A_setPActivity.AddNode(Operation_ProvidedInterface_A_setPActivity_Call_I_setP_on_q);
						// ActivityParameterNode vParameterNode
						Operation_ProvidedInterface_A_setPActivity_vParameterNode.SetName("vParameterNode");
						Operation_ProvidedInterface_A_setPActivity_vParameterNode.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedInterface_A_setPActivity_vParameterNode.SetParameter(Operation_ProvidedInterface_A_setPActivity_v);
					Operation_ProvidedInterface_A_setPActivity.AddNode(Operation_ProvidedInterface_A_setPActivity_vParameterNode);
						// ObjectFlow ObjectFlow73 from result to target
						Operation_ProvidedInterface_A_setPActivity_ObjectFlow73.SetName("ObjectFlow73");
						Operation_ProvidedInterface_A_setPActivity_ObjectFlow73.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedInterface_A_setPActivity_ObjectFlow73.SetSource(Operation_ProvidedInterface_A_setPActivity_this_result);
						Operation_ProvidedInterface_A_setPActivity_ObjectFlow73.SetTarget(Operation_ProvidedInterface_A_setPActivity_Call_I_setP_on_q_target);
							// LiteralBoolean LiteralBoolean74
							Operation_ProvidedInterface_A_setPActivity_ObjectFlow73_LiteralBoolean74.SetName("LiteralBoolean74");
							Operation_ProvidedInterface_A_setPActivity_ObjectFlow73_LiteralBoolean74.SetVisibility(VisibilityKind.public_);
							Operation_ProvidedInterface_A_setPActivity_ObjectFlow73_LiteralBoolean74.SetValue(true);
						Operation_ProvidedInterface_A_setPActivity_ObjectFlow73.SetGuard(Operation_ProvidedInterface_A_setPActivity_ObjectFlow73_LiteralBoolean74);
					Operation_ProvidedInterface_A_setPActivity.AddEdge(Operation_ProvidedInterface_A_setPActivity_ObjectFlow73);
						// ObjectFlow ObjectFlow76 from vParameterNode to v
						Operation_ProvidedInterface_A_setPActivity_ObjectFlow76.SetName("ObjectFlow76");
						Operation_ProvidedInterface_A_setPActivity_ObjectFlow76.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedInterface_A_setPActivity_ObjectFlow76.SetSource(Operation_ProvidedInterface_A_setPActivity_vParameterNode);
						Operation_ProvidedInterface_A_setPActivity_ObjectFlow76.SetTarget(Operation_ProvidedInterface_A_setPActivity_Call_I_setP_on_q_v);
							// LiteralBoolean LiteralBoolean77
							Operation_ProvidedInterface_A_setPActivity_ObjectFlow76_LiteralBoolean77.SetName("LiteralBoolean77");
							Operation_ProvidedInterface_A_setPActivity_ObjectFlow76_LiteralBoolean77.SetVisibility(VisibilityKind.public_);
							Operation_ProvidedInterface_A_setPActivity_ObjectFlow76_LiteralBoolean77.SetValue(true);
						Operation_ProvidedInterface_A_setPActivity_ObjectFlow76.SetGuard(Operation_ProvidedInterface_A_setPActivity_ObjectFlow76_LiteralBoolean77);
					Operation_ProvidedInterface_A_setPActivity.AddEdge(Operation_ProvidedInterface_A_setPActivity_ObjectFlow76);
				Operation_ProvidedInterface_A.AddOwnedBehavior(Operation_ProvidedInterface_A_setPActivity);
				Operation_ProvidedInterface_A_r.SetName("r");
					Operation_ProvidedInterface_A_r.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedInterface_A_r_ConnectorEnd64.SetRole(Operation_ProvidedInterface_A_q);
						
					Operation_ProvidedInterface_A_r.AddEnd(Operation_ProvidedInterface_A_r_ConnectorEnd64);
						
						Operation_ProvidedInterface_A_r_ConnectorEnd63.SetRole(Operation_ProvidedInterface_A_b);
						
					Operation_ProvidedInterface_A_r.AddEnd(Operation_ProvidedInterface_A_r_ConnectorEnd63);
					Operation_ProvidedInterface_A_r.SetType(Operation_ProvidedInterface_R);
				Operation_ProvidedInterface_A.AddOwnedConnector(Operation_ProvidedInterface_A_r);
					// Operation setP_Integer
					Operation_ProvidedInterface_A_setP_Integer.SetName("setP_Integer");
					Operation_ProvidedInterface_A_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						Operation_ProvidedInterface_A_setP_Integer_v.SetName("v");
						Operation_ProvidedInterface_A_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedInterface_A_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_ProvidedInterface_A_setP_Integer.AddOwnedParameter(Operation_ProvidedInterface_A_setP_Integer_v);
					Operation_ProvidedInterface_A_setP_Integer.AddMethod(Operation_ProvidedInterface_A_setPActivity);
				Operation_ProvidedInterface_A.AddOwnedOperation(Operation_ProvidedInterface_A_setP_Integer);
					// Operation A_A
					Operation_ProvidedInterface_A_A_A.SetName("A_A");
					Operation_ProvidedInterface_A_A_A.SetVisibility(VisibilityKind.public_);
						// Parameter result
						Operation_ProvidedInterface_A_A_A_result.SetName("result");
						Operation_ProvidedInterface_A_A_A_result.SetVisibility(VisibilityKind.public_);
						
						Operation_ProvidedInterface_A_A_A_result.SetType(Operation_ProvidedInterface_A);
						Operation_ProvidedInterface_A_A_A_result.SetDirection(ParameterDirectionKind.return_);
					Operation_ProvidedInterface_A_A_A.AddOwnedParameter(Operation_ProvidedInterface_A_A_A_result);
					Operation_ProvidedInterface_A_A_A.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				Operation_ProvidedInterface_A.AddOwnedOperation(Operation_ProvidedInterface_A_A_A);
			Operation_ProvidedInterface.AddPackagedElement(Operation_ProvidedInterface_A);
				// Association S
				Operation_ProvidedInterface_S.SetName("S");
				Operation_ProvidedInterface_S.SetVisibility(VisibilityKind.public_);
				Operation_ProvidedInterface_S.AddOwnedEnd(Operation_ProvidedInterface_S_x);
				Operation_ProvidedInterface_S.AddOwnedEnd(Operation_ProvidedInterface_S_y);
			Operation_ProvidedInterface.AddPackagedElement(Operation_ProvidedInterface_S);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // Operation_ProvidedInterfaceModel
}
