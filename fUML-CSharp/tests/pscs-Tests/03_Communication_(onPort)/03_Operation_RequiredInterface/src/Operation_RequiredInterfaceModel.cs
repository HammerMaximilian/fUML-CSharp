/*
 * Operation_RequiredInterfaceModel.cs
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

namespace Operation_RequiredInterface
{
	public class Operation_RequiredInterfaceModel : InMemoryModel
	{
		private static Operation_RequiredInterfaceModel? instance;

		/*
		 * Model Operation_RequiredInterface
		 */
		public Package Operation_RequiredInterface = new();
			public Interface Operation_RequiredInterface_I = new();
				public Operation Operation_RequiredInterface_I_setP_Integer = new();
					public Parameter Operation_RequiredInterface_I_setP_Integer_v = new();
			public Class_ Operation_RequiredInterface_IImpl = new();
				public Operation Operation_RequiredInterface_IImpl_setP_Integer = new();
					public Parameter Operation_RequiredInterface_IImpl_setP_Integer_v = new();
				public InterfaceRealization Operation_RequiredInterface_IImpl_IRealization = new();
			public Class_ Operation_RequiredInterface_B = new();
				public Property Operation_RequiredInterface_B_p = new();
				public Activity Operation_RequiredInterface_B_setPActivity = new();
					public Parameter Operation_RequiredInterface_B_setPActivity_v = new();
					public ActivityParameterNode Operation_RequiredInterface_B_setPActivity_vParameterNode = new();
						public LiteralInteger Operation_RequiredInterface_B_setPActivity_vParameterNode_LiteralInteger0 = new();
					public AddStructuralFeatureValueAction Operation_RequiredInterface_B_setPActivity_Set_this_p = new();
						public OutputPin Operation_RequiredInterface_B_setPActivity_Set_this_p_result = new();
							public LiteralUnlimitedNatural Operation_RequiredInterface_B_setPActivity_Set_this_p_result_LiteralUnlimitedNatural1 = new();
							public LiteralInteger Operation_RequiredInterface_B_setPActivity_Set_this_p_result_LiteralInteger2 = new();
						public InputPin Operation_RequiredInterface_B_setPActivity_Set_this_p_value = new();
							public LiteralInteger Operation_RequiredInterface_B_setPActivity_Set_this_p_value_LiteralInteger3 = new();
							public LiteralUnlimitedNatural Operation_RequiredInterface_B_setPActivity_Set_this_p_value_LiteralUnlimitedNatural4 = new();
						public InputPin Operation_RequiredInterface_B_setPActivity_Set_this_p_object = new();
							public LiteralInteger Operation_RequiredInterface_B_setPActivity_Set_this_p_object_LiteralInteger5 = new();
							public LiteralUnlimitedNatural Operation_RequiredInterface_B_setPActivity_Set_this_p_object_LiteralUnlimitedNatural6 = new();
					public ObjectFlow Operation_RequiredInterface_B_setPActivity_ObjectFlow7 = new();
						public LiteralInteger Operation_RequiredInterface_B_setPActivity_ObjectFlow7_LiteralInteger8 = new();
						public LiteralBoolean Operation_RequiredInterface_B_setPActivity_ObjectFlow7_LiteralBoolean9 = new();
					public ObjectFlow Operation_RequiredInterface_B_setPActivity_ObjectFlow10 = new();
						public LiteralBoolean Operation_RequiredInterface_B_setPActivity_ObjectFlow10_LiteralBoolean11 = new();
						public LiteralInteger Operation_RequiredInterface_B_setPActivity_ObjectFlow10_LiteralInteger12 = new();
					public ReadSelfAction Operation_RequiredInterface_B_setPActivity_this = new();
						public OutputPin Operation_RequiredInterface_B_setPActivity_this_result = new();
							public LiteralUnlimitedNatural Operation_RequiredInterface_B_setPActivity_this_result_LiteralUnlimitedNatural13 = new();
							public LiteralInteger Operation_RequiredInterface_B_setPActivity_this_result_LiteralInteger14 = new();
				public InterfaceRealization Operation_RequiredInterface_B_IRealization = new();
				public Operation Operation_RequiredInterface_B_setP_Integer = new();
					public Parameter Operation_RequiredInterface_B_setP_Integer_v = new();
			public Association Operation_RequiredInterface_R = new();
				public Property Operation_RequiredInterface_R_y = new();
				public Property Operation_RequiredInterface_R_x = new();
			public Association Operation_RequiredInterface_S = new();
				public Property Operation_RequiredInterface_S_x = new();
				public Property Operation_RequiredInterface_S_y = new();
			public Activity Operation_RequiredInterface_main = new();
				public ValueSpecificationAction Operation_RequiredInterface_main_Value_4 = new();
					public LiteralInteger Operation_RequiredInterface_main_Value_4_LiteralInteger15 = new();
					public OutputPin Operation_RequiredInterface_main_Value_4_result = new();
						public LiteralInteger Operation_RequiredInterface_main_Value_4_result_LiteralInteger16 = new();
						public LiteralUnlimitedNatural Operation_RequiredInterface_main_Value_4_result_LiteralUnlimitedNatural17 = new();
				public ObjectFlow Operation_RequiredInterface_main_ObjectFlow18 = new();
					public LiteralBoolean Operation_RequiredInterface_main_ObjectFlow18_LiteralBoolean19 = new();
					public LiteralInteger Operation_RequiredInterface_main_ObjectFlow18_LiteralInteger20 = new();
				public ObjectFlow Operation_RequiredInterface_main_ObjectFlow21 = new();
					public LiteralInteger Operation_RequiredInterface_main_ObjectFlow21_LiteralInteger22 = new();
					public LiteralBoolean Operation_RequiredInterface_main_ObjectFlow21_LiteralBoolean23 = new();
				public ReadStructuralFeatureAction Operation_RequiredInterface_main_Read_d_c = new();
					public InputPin Operation_RequiredInterface_main_Read_d_c_object = new();
						public LiteralInteger Operation_RequiredInterface_main_Read_d_c_object_LiteralInteger24 = new();
						public LiteralUnlimitedNatural Operation_RequiredInterface_main_Read_d_c_object_LiteralUnlimitedNatural25 = new();
					public OutputPin Operation_RequiredInterface_main_Read_d_c_result = new();
						public LiteralInteger Operation_RequiredInterface_main_Read_d_c_result_LiteralInteger26 = new();
						public LiteralUnlimitedNatural Operation_RequiredInterface_main_Read_d_c_result_LiteralUnlimitedNatural27 = new();
				public ObjectFlow Operation_RequiredInterface_main_ObjectFlow28 = new();
					public LiteralBoolean Operation_RequiredInterface_main_ObjectFlow28_LiteralBoolean29 = new();
					public LiteralInteger Operation_RequiredInterface_main_ObjectFlow28_LiteralInteger30 = new();
				public ReadStructuralFeatureAction Operation_RequiredInterface_main_Read_d_a = new();
					public InputPin Operation_RequiredInterface_main_Read_d_a_object = new();
						public LiteralInteger Operation_RequiredInterface_main_Read_d_a_object_LiteralInteger31 = new();
						public LiteralUnlimitedNatural Operation_RequiredInterface_main_Read_d_a_object_LiteralUnlimitedNatural32 = new();
					public OutputPin Operation_RequiredInterface_main_Read_d_a_result = new();
						public LiteralInteger Operation_RequiredInterface_main_Read_d_a_result_LiteralInteger33 = new();
						public LiteralUnlimitedNatural Operation_RequiredInterface_main_Read_d_a_result_LiteralUnlimitedNatural34 = new();
				public ObjectFlow Operation_RequiredInterface_main_ObjectFlow35 = new();
					public LiteralInteger Operation_RequiredInterface_main_ObjectFlow35_LiteralInteger36 = new();
					public LiteralBoolean Operation_RequiredInterface_main_ObjectFlow35_LiteralBoolean37 = new();
				public ReadStructuralFeatureAction Operation_RequiredInterface_main_Read_b_p = new();
					public OutputPin Operation_RequiredInterface_main_Read_b_p_result = new();
						public LiteralInteger Operation_RequiredInterface_main_Read_b_p_result_LiteralInteger38 = new();
						public LiteralUnlimitedNatural Operation_RequiredInterface_main_Read_b_p_result_LiteralUnlimitedNatural39 = new();
					public InputPin Operation_RequiredInterface_main_Read_b_p_object = new();
						public LiteralInteger Operation_RequiredInterface_main_Read_b_p_object_LiteralInteger40 = new();
						public LiteralUnlimitedNatural Operation_RequiredInterface_main_Read_b_p_object_LiteralUnlimitedNatural41 = new();
				public ObjectFlow Operation_RequiredInterface_main_ObjectFlow42 = new();
					public LiteralBoolean Operation_RequiredInterface_main_ObjectFlow42_LiteralBoolean43 = new();
					public LiteralInteger Operation_RequiredInterface_main_ObjectFlow42_LiteralInteger44 = new();
				public ReadStructuralFeatureAction Operation_RequiredInterface_main_Read_a_b = new();
					public InputPin Operation_RequiredInterface_main_Read_a_b_object = new();
						public LiteralInteger Operation_RequiredInterface_main_Read_a_b_object_LiteralInteger45 = new();
						public LiteralUnlimitedNatural Operation_RequiredInterface_main_Read_a_b_object_LiteralUnlimitedNatural46 = new();
					public OutputPin Operation_RequiredInterface_main_Read_a_b_result = new();
						public LiteralInteger Operation_RequiredInterface_main_Read_a_b_result_LiteralInteger47 = new();
						public LiteralUnlimitedNatural Operation_RequiredInterface_main_Read_a_b_result_LiteralUnlimitedNatural48 = new();
				public CallOperationAction Operation_RequiredInterface_main_D_ = new();
					public OutputPin Operation_RequiredInterface_main_D__result = new();
						public LiteralInteger Operation_RequiredInterface_main_D__result_LiteralInteger49 = new();
						public LiteralUnlimitedNatural Operation_RequiredInterface_main_D__result_LiteralUnlimitedNatural50 = new();
						public LiteralInteger Operation_RequiredInterface_main_D__result_LiteralInteger51 = new();
					public InputPin Operation_RequiredInterface_main_D__target = new();
						public LiteralUnlimitedNatural Operation_RequiredInterface_main_D__target_LiteralUnlimitedNatural52 = new();
						public LiteralInteger Operation_RequiredInterface_main_D__target_LiteralInteger53 = new();
				public CallOperationAction Operation_RequiredInterface_main_Call_setP_ = new();
					public InputPin Operation_RequiredInterface_main_Call_setP__target = new();
						public LiteralUnlimitedNatural Operation_RequiredInterface_main_Call_setP__target_LiteralUnlimitedNatural54 = new();
						public LiteralInteger Operation_RequiredInterface_main_Call_setP__target_LiteralInteger55 = new();
					public InputPin Operation_RequiredInterface_main_Call_setP__v = new();
						public LiteralUnlimitedNatural Operation_RequiredInterface_main_Call_setP__v_LiteralUnlimitedNatural56 = new();
						public LiteralInteger Operation_RequiredInterface_main_Call_setP__v_LiteralInteger57 = new();
						public LiteralInteger Operation_RequiredInterface_main_Call_setP__v_LiteralInteger58 = new();
				public ForkNode Operation_RequiredInterface_main_Fork_d = new();
				public ObjectFlow Operation_RequiredInterface_main_ObjectFlow59 = new();
					public LiteralInteger Operation_RequiredInterface_main_ObjectFlow59_LiteralInteger60 = new();
					public LiteralBoolean Operation_RequiredInterface_main_ObjectFlow59_LiteralBoolean61 = new();
				public ObjectFlow Operation_RequiredInterface_main_ObjectFlow62 = new();
					public LiteralInteger Operation_RequiredInterface_main_ObjectFlow62_LiteralInteger63 = new();
					public LiteralBoolean Operation_RequiredInterface_main_ObjectFlow62_LiteralBoolean64 = new();
				public ObjectFlow Operation_RequiredInterface_main_ObjectFlow65 = new();
					public LiteralBoolean Operation_RequiredInterface_main_ObjectFlow65_LiteralBoolean66 = new();
					public LiteralInteger Operation_RequiredInterface_main_ObjectFlow65_LiteralInteger67 = new();
				public CallBehaviorAction Operation_RequiredInterface_main_Call_testP = new();
					public InputPin Operation_RequiredInterface_main_Call_testP_p = new();
						public LiteralInteger Operation_RequiredInterface_main_Call_testP_p_LiteralInteger68 = new();
						public LiteralInteger Operation_RequiredInterface_main_Call_testP_p_LiteralInteger69 = new();
						public LiteralUnlimitedNatural Operation_RequiredInterface_main_Call_testP_p_LiteralUnlimitedNatural70 = new();
				public OpaqueBehavior Operation_RequiredInterface_main_testP = new();
					public Parameter Operation_RequiredInterface_main_testP_p = new();
				public ControlFlow Operation_RequiredInterface_main_ControlFlow71 = new();
				public CreateObjectAction Operation_RequiredInterface_main_Create_D = new();
					public OutputPin Operation_RequiredInterface_main_Create_D_result = new();
						public LiteralUnlimitedNatural Operation_RequiredInterface_main_Create_D_result_LiteralUnlimitedNatural72 = new();
						public LiteralInteger Operation_RequiredInterface_main_Create_D_result_LiteralInteger73 = new();
				public ObjectFlow Operation_RequiredInterface_main_ObjectFlow74 = new();
					public LiteralBoolean Operation_RequiredInterface_main_ObjectFlow74_LiteralBoolean75 = new();
					public LiteralInteger Operation_RequiredInterface_main_ObjectFlow74_LiteralInteger76 = new();
			public Class_ Operation_RequiredInterface_D = new();
				public Property Operation_RequiredInterface_D_c = new();
				public Connector Operation_RequiredInterface_D_s = new();
					public ConnectorEnd Operation_RequiredInterface_D_s_ConnectorEnd77 = new();
					public ConnectorEnd Operation_RequiredInterface_D_s_ConnectorEnd78 = new();
				public Property Operation_RequiredInterface_D_a = new();
				public Operation Operation_RequiredInterface_D_D_D = new();
					public Parameter Operation_RequiredInterface_D_D_D_result = new();
			public Class_ Operation_RequiredInterface_C = new();
				public Activity Operation_RequiredInterface_C_setPActivity = new();
					public ObjectFlow Operation_RequiredInterface_C_setPActivity_ObjectFlow79 = new();
						public LiteralBoolean Operation_RequiredInterface_C_setPActivity_ObjectFlow79_LiteralBoolean80 = new();
						public LiteralInteger Operation_RequiredInterface_C_setPActivity_ObjectFlow79_LiteralInteger81 = new();
					public ObjectFlow Operation_RequiredInterface_C_setPActivity_ObjectFlow82 = new();
						public LiteralBoolean Operation_RequiredInterface_C_setPActivity_ObjectFlow82_LiteralBoolean83 = new();
						public LiteralInteger Operation_RequiredInterface_C_setPActivity_ObjectFlow82_LiteralInteger84 = new();
					public ReadSelfAction Operation_RequiredInterface_C_setPActivity_this = new();
						public OutputPin Operation_RequiredInterface_C_setPActivity_this_result = new();
							public LiteralInteger Operation_RequiredInterface_C_setPActivity_this_result_LiteralInteger85 = new();
							public LiteralUnlimitedNatural Operation_RequiredInterface_C_setPActivity_this_result_LiteralUnlimitedNatural86 = new();
					public CallOperationAction Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q = new();
						public InputPin Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q_v = new();
							public LiteralInteger Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q_v_LiteralInteger87 = new();
							public LiteralUnlimitedNatural Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q_v_LiteralUnlimitedNatural88 = new();
							public LiteralInteger Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q_v_LiteralInteger89 = new();
						public InputPin Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q_target = new();
							public LiteralUnlimitedNatural Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q_target_LiteralUnlimitedNatural90 = new();
							public LiteralInteger Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q_target_LiteralInteger91 = new();
					public ActivityParameterNode Operation_RequiredInterface_C_setPActivity_vParameterNode = new();
						public LiteralInteger Operation_RequiredInterface_C_setPActivity_vParameterNode_LiteralInteger92 = new();
					public Parameter Operation_RequiredInterface_C_setPActivity_v = new();
				public Port Operation_RequiredInterface_C_q = new();
				public InterfaceRealization Operation_RequiredInterface_C_IRealization = new();
				public Operation Operation_RequiredInterface_C_setP_Integer = new();
					public Parameter Operation_RequiredInterface_C_setP_Integer_v = new();
			public Class_ Operation_RequiredInterface_A = new();
				public Port Operation_RequiredInterface_A_q = new();
				public Property Operation_RequiredInterface_A_b = new();
				public Connector Operation_RequiredInterface_A_r = new();
					public ConnectorEnd Operation_RequiredInterface_A_r_ConnectorEnd93 = new();
					public ConnectorEnd Operation_RequiredInterface_A_r_ConnectorEnd94 = new();
				public Activity Operation_RequiredInterface_A_setPActivity = new();
					public ObjectFlow Operation_RequiredInterface_A_setPActivity_ObjectFlow95 = new();
						public LiteralBoolean Operation_RequiredInterface_A_setPActivity_ObjectFlow95_LiteralBoolean96 = new();
						public LiteralInteger Operation_RequiredInterface_A_setPActivity_ObjectFlow95_LiteralInteger97 = new();
					public CallOperationAction Operation_RequiredInterface_A_setPActivity_Call_I_setP_on_q = new();
						public InputPin Operation_RequiredInterface_A_setPActivity_Call_I_setP_on_q_target = new();
							public LiteralInteger Operation_RequiredInterface_A_setPActivity_Call_I_setP_on_q_target_LiteralInteger98 = new();
							public LiteralUnlimitedNatural Operation_RequiredInterface_A_setPActivity_Call_I_setP_on_q_target_LiteralUnlimitedNatural99 = new();
						public InputPin Operation_RequiredInterface_A_setPActivity_Call_I_setP_on_q_v = new();
							public LiteralUnlimitedNatural Operation_RequiredInterface_A_setPActivity_Call_I_setP_on_q_v_LiteralUnlimitedNatural100 = new();
							public LiteralInteger Operation_RequiredInterface_A_setPActivity_Call_I_setP_on_q_v_LiteralInteger101 = new();
							public LiteralInteger Operation_RequiredInterface_A_setPActivity_Call_I_setP_on_q_v_LiteralInteger102 = new();
					public ObjectFlow Operation_RequiredInterface_A_setPActivity_ObjectFlow103 = new();
						public LiteralInteger Operation_RequiredInterface_A_setPActivity_ObjectFlow103_LiteralInteger104 = new();
						public LiteralBoolean Operation_RequiredInterface_A_setPActivity_ObjectFlow103_LiteralBoolean105 = new();
					public Parameter Operation_RequiredInterface_A_setPActivity_v = new();
					public ActivityParameterNode Operation_RequiredInterface_A_setPActivity_vParameterNode = new();
						public LiteralInteger Operation_RequiredInterface_A_setPActivity_vParameterNode_LiteralInteger106 = new();
					public ReadSelfAction Operation_RequiredInterface_A_setPActivity_this = new();
						public OutputPin Operation_RequiredInterface_A_setPActivity_this_result = new();
							public LiteralUnlimitedNatural Operation_RequiredInterface_A_setPActivity_this_result_LiteralUnlimitedNatural107 = new();
							public LiteralInteger Operation_RequiredInterface_A_setPActivity_this_result_LiteralInteger108 = new();
				public Operation Operation_RequiredInterface_A_setP_Integer = new();
					public Parameter Operation_RequiredInterface_A_setP_Integer_v = new();

		public static Operation_RequiredInterfaceModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public Operation_RequiredInterfaceModel()
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
			 * Model Operation_RequiredInterface
			 */
			AddToElementRepository("Operation_RequiredInterface", Operation_RequiredInterface);
				AddToElementRepository("I", Operation_RequiredInterface_I);
					AddToElementRepository("setP_Integer", Operation_RequiredInterface_I_setP_Integer);
						AddToElementRepository("v", Operation_RequiredInterface_I_setP_Integer_v);
				AddToElementRepository("IImpl", Operation_RequiredInterface_IImpl);
					AddToElementRepository("setP_Integer", Operation_RequiredInterface_IImpl_setP_Integer);
						AddToElementRepository("v", Operation_RequiredInterface_IImpl_setP_Integer_v);
					AddToElementRepository("IRealization", Operation_RequiredInterface_IImpl_IRealization);
				AddToElementRepository("B", Operation_RequiredInterface_B);
					AddToElementRepository("p", Operation_RequiredInterface_B_p);
					AddToElementRepository("setPActivity", Operation_RequiredInterface_B_setPActivity);
						AddToElementRepository("v", Operation_RequiredInterface_B_setPActivity_v);
						AddToElementRepository("vParameterNode", Operation_RequiredInterface_B_setPActivity_vParameterNode);
							AddToElementRepository("LiteralInteger0", Operation_RequiredInterface_B_setPActivity_vParameterNode_LiteralInteger0);
						AddToElementRepository("Set this.p", Operation_RequiredInterface_B_setPActivity_Set_this_p);
							AddToElementRepository("result", Operation_RequiredInterface_B_setPActivity_Set_this_p_result);
								AddToElementRepository("LiteralUnlimitedNatural1", Operation_RequiredInterface_B_setPActivity_Set_this_p_result_LiteralUnlimitedNatural1);
								AddToElementRepository("LiteralInteger2", Operation_RequiredInterface_B_setPActivity_Set_this_p_result_LiteralInteger2);
							AddToElementRepository("value", Operation_RequiredInterface_B_setPActivity_Set_this_p_value);
								AddToElementRepository("LiteralInteger3", Operation_RequiredInterface_B_setPActivity_Set_this_p_value_LiteralInteger3);
								AddToElementRepository("LiteralUnlimitedNatural4", Operation_RequiredInterface_B_setPActivity_Set_this_p_value_LiteralUnlimitedNatural4);
							AddToElementRepository("object", Operation_RequiredInterface_B_setPActivity_Set_this_p_object);
								AddToElementRepository("LiteralInteger5", Operation_RequiredInterface_B_setPActivity_Set_this_p_object_LiteralInteger5);
								AddToElementRepository("LiteralUnlimitedNatural6", Operation_RequiredInterface_B_setPActivity_Set_this_p_object_LiteralUnlimitedNatural6);
						AddToElementRepository("ObjectFlow7", Operation_RequiredInterface_B_setPActivity_ObjectFlow7);
							AddToElementRepository("LiteralInteger8", Operation_RequiredInterface_B_setPActivity_ObjectFlow7_LiteralInteger8);
							AddToElementRepository("LiteralBoolean9", Operation_RequiredInterface_B_setPActivity_ObjectFlow7_LiteralBoolean9);
						AddToElementRepository("ObjectFlow10", Operation_RequiredInterface_B_setPActivity_ObjectFlow10);
							AddToElementRepository("LiteralBoolean11", Operation_RequiredInterface_B_setPActivity_ObjectFlow10_LiteralBoolean11);
							AddToElementRepository("LiteralInteger12", Operation_RequiredInterface_B_setPActivity_ObjectFlow10_LiteralInteger12);
						AddToElementRepository("this", Operation_RequiredInterface_B_setPActivity_this);
							AddToElementRepository("result", Operation_RequiredInterface_B_setPActivity_this_result);
								AddToElementRepository("LiteralUnlimitedNatural13", Operation_RequiredInterface_B_setPActivity_this_result_LiteralUnlimitedNatural13);
								AddToElementRepository("LiteralInteger14", Operation_RequiredInterface_B_setPActivity_this_result_LiteralInteger14);
					AddToElementRepository("IRealization", Operation_RequiredInterface_B_IRealization);
					AddToElementRepository("setP_Integer", Operation_RequiredInterface_B_setP_Integer);
						AddToElementRepository("v", Operation_RequiredInterface_B_setP_Integer_v);
				AddToElementRepository("R", Operation_RequiredInterface_R);
					AddToElementRepository("y", Operation_RequiredInterface_R_y);
					AddToElementRepository("x", Operation_RequiredInterface_R_x);
				AddToElementRepository("S", Operation_RequiredInterface_S);
					AddToElementRepository("x", Operation_RequiredInterface_S_x);
					AddToElementRepository("y", Operation_RequiredInterface_S_y);
				AddToElementRepository("main", Operation_RequiredInterface_main);
					AddToElementRepository("Value(4)", Operation_RequiredInterface_main_Value_4);
						AddToElementRepository("LiteralInteger15", Operation_RequiredInterface_main_Value_4_LiteralInteger15);
						AddToElementRepository("result", Operation_RequiredInterface_main_Value_4_result);
							AddToElementRepository("LiteralInteger16", Operation_RequiredInterface_main_Value_4_result_LiteralInteger16);
							AddToElementRepository("LiteralUnlimitedNatural17", Operation_RequiredInterface_main_Value_4_result_LiteralUnlimitedNatural17);
					AddToElementRepository("ObjectFlow18", Operation_RequiredInterface_main_ObjectFlow18);
						AddToElementRepository("LiteralBoolean19", Operation_RequiredInterface_main_ObjectFlow18_LiteralBoolean19);
						AddToElementRepository("LiteralInteger20", Operation_RequiredInterface_main_ObjectFlow18_LiteralInteger20);
					AddToElementRepository("ObjectFlow21", Operation_RequiredInterface_main_ObjectFlow21);
						AddToElementRepository("LiteralInteger22", Operation_RequiredInterface_main_ObjectFlow21_LiteralInteger22);
						AddToElementRepository("LiteralBoolean23", Operation_RequiredInterface_main_ObjectFlow21_LiteralBoolean23);
					AddToElementRepository("Read d.c", Operation_RequiredInterface_main_Read_d_c);
						AddToElementRepository("object", Operation_RequiredInterface_main_Read_d_c_object);
							AddToElementRepository("LiteralInteger24", Operation_RequiredInterface_main_Read_d_c_object_LiteralInteger24);
							AddToElementRepository("LiteralUnlimitedNatural25", Operation_RequiredInterface_main_Read_d_c_object_LiteralUnlimitedNatural25);
						AddToElementRepository("result", Operation_RequiredInterface_main_Read_d_c_result);
							AddToElementRepository("LiteralInteger26", Operation_RequiredInterface_main_Read_d_c_result_LiteralInteger26);
							AddToElementRepository("LiteralUnlimitedNatural27", Operation_RequiredInterface_main_Read_d_c_result_LiteralUnlimitedNatural27);
					AddToElementRepository("ObjectFlow28", Operation_RequiredInterface_main_ObjectFlow28);
						AddToElementRepository("LiteralBoolean29", Operation_RequiredInterface_main_ObjectFlow28_LiteralBoolean29);
						AddToElementRepository("LiteralInteger30", Operation_RequiredInterface_main_ObjectFlow28_LiteralInteger30);
					AddToElementRepository("Read d.a", Operation_RequiredInterface_main_Read_d_a);
						AddToElementRepository("object", Operation_RequiredInterface_main_Read_d_a_object);
							AddToElementRepository("LiteralInteger31", Operation_RequiredInterface_main_Read_d_a_object_LiteralInteger31);
							AddToElementRepository("LiteralUnlimitedNatural32", Operation_RequiredInterface_main_Read_d_a_object_LiteralUnlimitedNatural32);
						AddToElementRepository("result", Operation_RequiredInterface_main_Read_d_a_result);
							AddToElementRepository("LiteralInteger33", Operation_RequiredInterface_main_Read_d_a_result_LiteralInteger33);
							AddToElementRepository("LiteralUnlimitedNatural34", Operation_RequiredInterface_main_Read_d_a_result_LiteralUnlimitedNatural34);
					AddToElementRepository("ObjectFlow35", Operation_RequiredInterface_main_ObjectFlow35);
						AddToElementRepository("LiteralInteger36", Operation_RequiredInterface_main_ObjectFlow35_LiteralInteger36);
						AddToElementRepository("LiteralBoolean37", Operation_RequiredInterface_main_ObjectFlow35_LiteralBoolean37);
					AddToElementRepository("Read b.p", Operation_RequiredInterface_main_Read_b_p);
						AddToElementRepository("result", Operation_RequiredInterface_main_Read_b_p_result);
							AddToElementRepository("LiteralInteger38", Operation_RequiredInterface_main_Read_b_p_result_LiteralInteger38);
							AddToElementRepository("LiteralUnlimitedNatural39", Operation_RequiredInterface_main_Read_b_p_result_LiteralUnlimitedNatural39);
						AddToElementRepository("object", Operation_RequiredInterface_main_Read_b_p_object);
							AddToElementRepository("LiteralInteger40", Operation_RequiredInterface_main_Read_b_p_object_LiteralInteger40);
							AddToElementRepository("LiteralUnlimitedNatural41", Operation_RequiredInterface_main_Read_b_p_object_LiteralUnlimitedNatural41);
					AddToElementRepository("ObjectFlow42", Operation_RequiredInterface_main_ObjectFlow42);
						AddToElementRepository("LiteralBoolean43", Operation_RequiredInterface_main_ObjectFlow42_LiteralBoolean43);
						AddToElementRepository("LiteralInteger44", Operation_RequiredInterface_main_ObjectFlow42_LiteralInteger44);
					AddToElementRepository("Read a.b", Operation_RequiredInterface_main_Read_a_b);
						AddToElementRepository("object", Operation_RequiredInterface_main_Read_a_b_object);
							AddToElementRepository("LiteralInteger45", Operation_RequiredInterface_main_Read_a_b_object_LiteralInteger45);
							AddToElementRepository("LiteralUnlimitedNatural46", Operation_RequiredInterface_main_Read_a_b_object_LiteralUnlimitedNatural46);
						AddToElementRepository("result", Operation_RequiredInterface_main_Read_a_b_result);
							AddToElementRepository("LiteralInteger47", Operation_RequiredInterface_main_Read_a_b_result_LiteralInteger47);
							AddToElementRepository("LiteralUnlimitedNatural48", Operation_RequiredInterface_main_Read_a_b_result_LiteralUnlimitedNatural48);
					AddToElementRepository("D()", Operation_RequiredInterface_main_D_);
						AddToElementRepository("result", Operation_RequiredInterface_main_D__result);
							AddToElementRepository("LiteralInteger49", Operation_RequiredInterface_main_D__result_LiteralInteger49);
							AddToElementRepository("LiteralUnlimitedNatural50", Operation_RequiredInterface_main_D__result_LiteralUnlimitedNatural50);
							AddToElementRepository("LiteralInteger51", Operation_RequiredInterface_main_D__result_LiteralInteger51);
						AddToElementRepository("target", Operation_RequiredInterface_main_D__target);
							AddToElementRepository("LiteralUnlimitedNatural52", Operation_RequiredInterface_main_D__target_LiteralUnlimitedNatural52);
							AddToElementRepository("LiteralInteger53", Operation_RequiredInterface_main_D__target_LiteralInteger53);
					AddToElementRepository("Call setP()", Operation_RequiredInterface_main_Call_setP_);
						AddToElementRepository("target", Operation_RequiredInterface_main_Call_setP__target);
							AddToElementRepository("LiteralUnlimitedNatural54", Operation_RequiredInterface_main_Call_setP__target_LiteralUnlimitedNatural54);
							AddToElementRepository("LiteralInteger55", Operation_RequiredInterface_main_Call_setP__target_LiteralInteger55);
						AddToElementRepository("v", Operation_RequiredInterface_main_Call_setP__v);
							AddToElementRepository("LiteralUnlimitedNatural56", Operation_RequiredInterface_main_Call_setP__v_LiteralUnlimitedNatural56);
							AddToElementRepository("LiteralInteger57", Operation_RequiredInterface_main_Call_setP__v_LiteralInteger57);
							AddToElementRepository("LiteralInteger58", Operation_RequiredInterface_main_Call_setP__v_LiteralInteger58);
					AddToElementRepository("Fork d", Operation_RequiredInterface_main_Fork_d);
					AddToElementRepository("ObjectFlow59", Operation_RequiredInterface_main_ObjectFlow59);
						AddToElementRepository("LiteralInteger60", Operation_RequiredInterface_main_ObjectFlow59_LiteralInteger60);
						AddToElementRepository("LiteralBoolean61", Operation_RequiredInterface_main_ObjectFlow59_LiteralBoolean61);
					AddToElementRepository("ObjectFlow62", Operation_RequiredInterface_main_ObjectFlow62);
						AddToElementRepository("LiteralInteger63", Operation_RequiredInterface_main_ObjectFlow62_LiteralInteger63);
						AddToElementRepository("LiteralBoolean64", Operation_RequiredInterface_main_ObjectFlow62_LiteralBoolean64);
					AddToElementRepository("ObjectFlow65", Operation_RequiredInterface_main_ObjectFlow65);
						AddToElementRepository("LiteralBoolean66", Operation_RequiredInterface_main_ObjectFlow65_LiteralBoolean66);
						AddToElementRepository("LiteralInteger67", Operation_RequiredInterface_main_ObjectFlow65_LiteralInteger67);
					AddToElementRepository("Call testP", Operation_RequiredInterface_main_Call_testP);
						AddToElementRepository("p", Operation_RequiredInterface_main_Call_testP_p);
							AddToElementRepository("LiteralInteger68", Operation_RequiredInterface_main_Call_testP_p_LiteralInteger68);
							AddToElementRepository("LiteralInteger69", Operation_RequiredInterface_main_Call_testP_p_LiteralInteger69);
							AddToElementRepository("LiteralUnlimitedNatural70", Operation_RequiredInterface_main_Call_testP_p_LiteralUnlimitedNatural70);
					AddToElementRepository("testP", Operation_RequiredInterface_main_testP);
						AddToElementRepository("p", Operation_RequiredInterface_main_testP_p);
					AddToElementRepository("ControlFlow71", Operation_RequiredInterface_main_ControlFlow71);
					AddToElementRepository("Create D", Operation_RequiredInterface_main_Create_D);
						AddToElementRepository("result", Operation_RequiredInterface_main_Create_D_result);
							AddToElementRepository("LiteralUnlimitedNatural72", Operation_RequiredInterface_main_Create_D_result_LiteralUnlimitedNatural72);
							AddToElementRepository("LiteralInteger73", Operation_RequiredInterface_main_Create_D_result_LiteralInteger73);
					AddToElementRepository("ObjectFlow74", Operation_RequiredInterface_main_ObjectFlow74);
						AddToElementRepository("LiteralBoolean75", Operation_RequiredInterface_main_ObjectFlow74_LiteralBoolean75);
						AddToElementRepository("LiteralInteger76", Operation_RequiredInterface_main_ObjectFlow74_LiteralInteger76);
				AddToElementRepository("D", Operation_RequiredInterface_D);
					AddToElementRepository("c", Operation_RequiredInterface_D_c);
					AddToElementRepository("s", Operation_RequiredInterface_D_s);
						AddToElementRepository("ConnectorEnd77", Operation_RequiredInterface_D_s_ConnectorEnd77);
						AddToElementRepository("ConnectorEnd78", Operation_RequiredInterface_D_s_ConnectorEnd78);
					AddToElementRepository("a", Operation_RequiredInterface_D_a);
					AddToElementRepository("D_D", Operation_RequiredInterface_D_D_D);
						AddToElementRepository("result", Operation_RequiredInterface_D_D_D_result);
				AddToElementRepository("C", Operation_RequiredInterface_C);
					AddToElementRepository("setPActivity", Operation_RequiredInterface_C_setPActivity);
						AddToElementRepository("ObjectFlow79", Operation_RequiredInterface_C_setPActivity_ObjectFlow79);
							AddToElementRepository("LiteralBoolean80", Operation_RequiredInterface_C_setPActivity_ObjectFlow79_LiteralBoolean80);
							AddToElementRepository("LiteralInteger81", Operation_RequiredInterface_C_setPActivity_ObjectFlow79_LiteralInteger81);
						AddToElementRepository("ObjectFlow82", Operation_RequiredInterface_C_setPActivity_ObjectFlow82);
							AddToElementRepository("LiteralBoolean83", Operation_RequiredInterface_C_setPActivity_ObjectFlow82_LiteralBoolean83);
							AddToElementRepository("LiteralInteger84", Operation_RequiredInterface_C_setPActivity_ObjectFlow82_LiteralInteger84);
						AddToElementRepository("this", Operation_RequiredInterface_C_setPActivity_this);
							AddToElementRepository("result", Operation_RequiredInterface_C_setPActivity_this_result);
								AddToElementRepository("LiteralInteger85", Operation_RequiredInterface_C_setPActivity_this_result_LiteralInteger85);
								AddToElementRepository("LiteralUnlimitedNatural86", Operation_RequiredInterface_C_setPActivity_this_result_LiteralUnlimitedNatural86);
						AddToElementRepository("Call I::setP on q", Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q);
							AddToElementRepository("v", Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q_v);
								AddToElementRepository("LiteralInteger87", Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q_v_LiteralInteger87);
								AddToElementRepository("LiteralUnlimitedNatural88", Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q_v_LiteralUnlimitedNatural88);
								AddToElementRepository("LiteralInteger89", Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q_v_LiteralInteger89);
							AddToElementRepository("target", Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q_target);
								AddToElementRepository("LiteralUnlimitedNatural90", Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q_target_LiteralUnlimitedNatural90);
								AddToElementRepository("LiteralInteger91", Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q_target_LiteralInteger91);
						AddToElementRepository("vParameterNode", Operation_RequiredInterface_C_setPActivity_vParameterNode);
							AddToElementRepository("LiteralInteger92", Operation_RequiredInterface_C_setPActivity_vParameterNode_LiteralInteger92);
						AddToElementRepository("v", Operation_RequiredInterface_C_setPActivity_v);
					AddToElementRepository("q", Operation_RequiredInterface_C_q);
					AddToElementRepository("IRealization", Operation_RequiredInterface_C_IRealization);
					AddToElementRepository("setP_Integer", Operation_RequiredInterface_C_setP_Integer);
						AddToElementRepository("v", Operation_RequiredInterface_C_setP_Integer_v);
				AddToElementRepository("A", Operation_RequiredInterface_A);
					AddToElementRepository("q", Operation_RequiredInterface_A_q);
					AddToElementRepository("b", Operation_RequiredInterface_A_b);
					AddToElementRepository("r", Operation_RequiredInterface_A_r);
						AddToElementRepository("ConnectorEnd93", Operation_RequiredInterface_A_r_ConnectorEnd93);
						AddToElementRepository("ConnectorEnd94", Operation_RequiredInterface_A_r_ConnectorEnd94);
					AddToElementRepository("setPActivity", Operation_RequiredInterface_A_setPActivity);
						AddToElementRepository("ObjectFlow95", Operation_RequiredInterface_A_setPActivity_ObjectFlow95);
							AddToElementRepository("LiteralBoolean96", Operation_RequiredInterface_A_setPActivity_ObjectFlow95_LiteralBoolean96);
							AddToElementRepository("LiteralInteger97", Operation_RequiredInterface_A_setPActivity_ObjectFlow95_LiteralInteger97);
						AddToElementRepository("Call I::setP on q", Operation_RequiredInterface_A_setPActivity_Call_I_setP_on_q);
							AddToElementRepository("target", Operation_RequiredInterface_A_setPActivity_Call_I_setP_on_q_target);
								AddToElementRepository("LiteralInteger98", Operation_RequiredInterface_A_setPActivity_Call_I_setP_on_q_target_LiteralInteger98);
								AddToElementRepository("LiteralUnlimitedNatural99", Operation_RequiredInterface_A_setPActivity_Call_I_setP_on_q_target_LiteralUnlimitedNatural99);
							AddToElementRepository("v", Operation_RequiredInterface_A_setPActivity_Call_I_setP_on_q_v);
								AddToElementRepository("LiteralUnlimitedNatural100", Operation_RequiredInterface_A_setPActivity_Call_I_setP_on_q_v_LiteralUnlimitedNatural100);
								AddToElementRepository("LiteralInteger101", Operation_RequiredInterface_A_setPActivity_Call_I_setP_on_q_v_LiteralInteger101);
								AddToElementRepository("LiteralInteger102", Operation_RequiredInterface_A_setPActivity_Call_I_setP_on_q_v_LiteralInteger102);
						AddToElementRepository("ObjectFlow103", Operation_RequiredInterface_A_setPActivity_ObjectFlow103);
							AddToElementRepository("LiteralInteger104", Operation_RequiredInterface_A_setPActivity_ObjectFlow103_LiteralInteger104);
							AddToElementRepository("LiteralBoolean105", Operation_RequiredInterface_A_setPActivity_ObjectFlow103_LiteralBoolean105);
						AddToElementRepository("v", Operation_RequiredInterface_A_setPActivity_v);
						AddToElementRepository("vParameterNode", Operation_RequiredInterface_A_setPActivity_vParameterNode);
							AddToElementRepository("LiteralInteger106", Operation_RequiredInterface_A_setPActivity_vParameterNode_LiteralInteger106);
						AddToElementRepository("this", Operation_RequiredInterface_A_setPActivity_this);
							AddToElementRepository("result", Operation_RequiredInterface_A_setPActivity_this_result);
								AddToElementRepository("LiteralUnlimitedNatural107", Operation_RequiredInterface_A_setPActivity_this_result_LiteralUnlimitedNatural107);
								AddToElementRepository("LiteralInteger108", Operation_RequiredInterface_A_setPActivity_this_result_LiteralInteger108);
					AddToElementRepository("setP_Integer", Operation_RequiredInterface_A_setP_Integer);
						AddToElementRepository("v", Operation_RequiredInterface_A_setP_Integer_v);

			// Initialize public members
			/*
			 * Model Operation_RequiredInterface
			 */
			Operation_RequiredInterface.SetName("Operation_RequiredInterface");
			Operation_RequiredInterface.SetVisibility(VisibilityKind.public_);
				// Interface I
				Operation_RequiredInterface_I.SetName("I");
				Operation_RequiredInterface_I.SetVisibility(VisibilityKind.public_);
					// Operation setP_Integer
					Operation_RequiredInterface_I_setP_Integer.SetName("setP_Integer");
					Operation_RequiredInterface_I_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						Operation_RequiredInterface_I_setP_Integer_v.SetName("v");
						Operation_RequiredInterface_I_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_I_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_RequiredInterface_I_setP_Integer.AddOwnedParameter(Operation_RequiredInterface_I_setP_Integer_v);
				Operation_RequiredInterface_I.AddOwnedOperation(Operation_RequiredInterface_I_setP_Integer);
			Operation_RequiredInterface.AddPackagedElement(Operation_RequiredInterface_I);
				// Class IImpl
				Operation_RequiredInterface_IImpl.SetName("IImpl");
				Operation_RequiredInterface_IImpl.SetVisibility(VisibilityKind.public_);
				Operation_RequiredInterface_IImpl_IRealization.SetName("IRealization");
					Operation_RequiredInterface_IImpl_IRealization.SetVisibility(VisibilityKind.public_);
					Operation_RequiredInterface_IImpl_IRealization.SetContract(Operation_RequiredInterface_I);
					
				Operation_RequiredInterface_IImpl.AddInterfaceRealization(Operation_RequiredInterface_IImpl_IRealization);
				
					// Operation setP_Integer
					Operation_RequiredInterface_IImpl_setP_Integer.SetName("setP_Integer");
					Operation_RequiredInterface_IImpl_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						Operation_RequiredInterface_IImpl_setP_Integer_v.SetName("v");
						Operation_RequiredInterface_IImpl_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_IImpl_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_RequiredInterface_IImpl_setP_Integer.AddOwnedParameter(Operation_RequiredInterface_IImpl_setP_Integer_v);
				Operation_RequiredInterface_IImpl.AddOwnedOperation(Operation_RequiredInterface_IImpl_setP_Integer);
			Operation_RequiredInterface.AddPackagedElement(Operation_RequiredInterface_IImpl);
				// Class B
				Operation_RequiredInterface_B.SetName("B");
				Operation_RequiredInterface_B.SetVisibility(VisibilityKind.public_);
				
					// Property p
					Operation_RequiredInterface_B_p.SetName("p");
					Operation_RequiredInterface_B_p.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_B_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
				Operation_RequiredInterface_B.AddOwnedAttribute(Operation_RequiredInterface_B_p);
				// Activity setPActivity
					Operation_RequiredInterface_B_setPActivity.SetName("setPActivity");
					Operation_RequiredInterface_B_setPActivity.SetVisibility(VisibilityKind.public_);
					
						// Parameter v
						Operation_RequiredInterface_B_setPActivity_v.SetName("v");
						Operation_RequiredInterface_B_setPActivity_v.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_B_setPActivity_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_RequiredInterface_B_setPActivity.AddOwnedParameter(Operation_RequiredInterface_B_setPActivity_v);
						// ActivityParameterNode vParameterNode
						Operation_RequiredInterface_B_setPActivity_vParameterNode.SetName("vParameterNode");
						Operation_RequiredInterface_B_setPActivity_vParameterNode.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_B_setPActivity_vParameterNode.SetParameter(Operation_RequiredInterface_B_setPActivity_v);
					Operation_RequiredInterface_B_setPActivity.AddNode(Operation_RequiredInterface_B_setPActivity_vParameterNode);
						// AddStructuralFeatureValueAction Set this.p
						Operation_RequiredInterface_B_setPActivity_Set_this_p.SetName("Set this.p");
						Operation_RequiredInterface_B_setPActivity_Set_this_p.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_B_setPActivity_Set_this_p.SetStructuralFeature(Operation_RequiredInterface_B_p);
							// InputPin object
							Operation_RequiredInterface_B_setPActivity_Set_this_p_object.SetName("object");
							Operation_RequiredInterface_B_setPActivity_Set_this_p_object.SetVisibility(VisibilityKind.public_);
							Operation_RequiredInterface_B_setPActivity_Set_this_p_object.SetType(Operation_RequiredInterface_B);
						Operation_RequiredInterface_B_setPActivity_Set_this_p.SetObject(Operation_RequiredInterface_B_setPActivity_Set_this_p_object);
							// InputPin value
							Operation_RequiredInterface_B_setPActivity_Set_this_p_value.SetName("value");
							Operation_RequiredInterface_B_setPActivity_Set_this_p_value.SetVisibility(VisibilityKind.public_);
							Operation_RequiredInterface_B_setPActivity_Set_this_p_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						Operation_RequiredInterface_B_setPActivity_Set_this_p.SetValue(Operation_RequiredInterface_B_setPActivity_Set_this_p_value);
							// OutputPin result
							Operation_RequiredInterface_B_setPActivity_Set_this_p_result.SetName("result");
							Operation_RequiredInterface_B_setPActivity_Set_this_p_result.SetVisibility(VisibilityKind.public_);
							Operation_RequiredInterface_B_setPActivity_Set_this_p_result.SetType(Operation_RequiredInterface_B);
						Operation_RequiredInterface_B_setPActivity_Set_this_p.SetResult(Operation_RequiredInterface_B_setPActivity_Set_this_p_result);
						Operation_RequiredInterface_B_setPActivity_Set_this_p.SetIsReplaceAll(true);
					Operation_RequiredInterface_B_setPActivity.AddNode(Operation_RequiredInterface_B_setPActivity_Set_this_p);
						// ReadSelfAction this
						Operation_RequiredInterface_B_setPActivity_this.SetName("this");
						Operation_RequiredInterface_B_setPActivity_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							Operation_RequiredInterface_B_setPActivity_this_result.SetName("result");
							Operation_RequiredInterface_B_setPActivity_this_result.SetVisibility(VisibilityKind.public_);
							Operation_RequiredInterface_B_setPActivity_this_result.SetType(Operation_RequiredInterface_B);
						Operation_RequiredInterface_B_setPActivity_this.SetResult(Operation_RequiredInterface_B_setPActivity_this_result);
					Operation_RequiredInterface_B_setPActivity.AddNode(Operation_RequiredInterface_B_setPActivity_this);
						// ObjectFlow ObjectFlow7 from result to object
						Operation_RequiredInterface_B_setPActivity_ObjectFlow7.SetName("ObjectFlow7");
						Operation_RequiredInterface_B_setPActivity_ObjectFlow7.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_B_setPActivity_ObjectFlow7.SetSource(Operation_RequiredInterface_B_setPActivity_this_result);
						Operation_RequiredInterface_B_setPActivity_ObjectFlow7.SetTarget(Operation_RequiredInterface_B_setPActivity_Set_this_p_object);
							// LiteralBoolean LiteralBoolean9
							Operation_RequiredInterface_B_setPActivity_ObjectFlow7_LiteralBoolean9.SetName("LiteralBoolean9");
							Operation_RequiredInterface_B_setPActivity_ObjectFlow7_LiteralBoolean9.SetVisibility(VisibilityKind.public_);
							Operation_RequiredInterface_B_setPActivity_ObjectFlow7_LiteralBoolean9.SetValue(true);
						Operation_RequiredInterface_B_setPActivity_ObjectFlow7.SetGuard(Operation_RequiredInterface_B_setPActivity_ObjectFlow7_LiteralBoolean9);
					Operation_RequiredInterface_B_setPActivity.AddEdge(Operation_RequiredInterface_B_setPActivity_ObjectFlow7);
						// ObjectFlow ObjectFlow10 from vParameterNode to value
						Operation_RequiredInterface_B_setPActivity_ObjectFlow10.SetName("ObjectFlow10");
						Operation_RequiredInterface_B_setPActivity_ObjectFlow10.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_B_setPActivity_ObjectFlow10.SetSource(Operation_RequiredInterface_B_setPActivity_vParameterNode);
						Operation_RequiredInterface_B_setPActivity_ObjectFlow10.SetTarget(Operation_RequiredInterface_B_setPActivity_Set_this_p_value);
							// LiteralBoolean LiteralBoolean11
							Operation_RequiredInterface_B_setPActivity_ObjectFlow10_LiteralBoolean11.SetName("LiteralBoolean11");
							Operation_RequiredInterface_B_setPActivity_ObjectFlow10_LiteralBoolean11.SetVisibility(VisibilityKind.public_);
							Operation_RequiredInterface_B_setPActivity_ObjectFlow10_LiteralBoolean11.SetValue(true);
						Operation_RequiredInterface_B_setPActivity_ObjectFlow10.SetGuard(Operation_RequiredInterface_B_setPActivity_ObjectFlow10_LiteralBoolean11);
					Operation_RequiredInterface_B_setPActivity.AddEdge(Operation_RequiredInterface_B_setPActivity_ObjectFlow10);
				Operation_RequiredInterface_B.AddOwnedBehavior(Operation_RequiredInterface_B_setPActivity);
					Operation_RequiredInterface_B_IRealization.SetName("IRealization");
					Operation_RequiredInterface_B_IRealization.SetVisibility(VisibilityKind.public_);
					Operation_RequiredInterface_B_IRealization.SetContract(Operation_RequiredInterface_I);
					
				Operation_RequiredInterface_B.AddInterfaceRealization(Operation_RequiredInterface_B_IRealization);
				
					// Operation setP_Integer
					Operation_RequiredInterface_B_setP_Integer.SetName("setP_Integer");
					Operation_RequiredInterface_B_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						Operation_RequiredInterface_B_setP_Integer_v.SetName("v");
						Operation_RequiredInterface_B_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_B_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_RequiredInterface_B_setP_Integer.AddOwnedParameter(Operation_RequiredInterface_B_setP_Integer_v);
					Operation_RequiredInterface_B_setP_Integer.AddMethod(Operation_RequiredInterface_B_setPActivity);
				Operation_RequiredInterface_B.AddOwnedOperation(Operation_RequiredInterface_B_setP_Integer);
			Operation_RequiredInterface.AddPackagedElement(Operation_RequiredInterface_B);
				// Association R
				Operation_RequiredInterface_R.SetName("R");
				Operation_RequiredInterface_R.SetVisibility(VisibilityKind.public_);
				Operation_RequiredInterface_R.AddOwnedEnd(Operation_RequiredInterface_R_x);
				Operation_RequiredInterface_R.AddOwnedEnd(Operation_RequiredInterface_R_y);
			Operation_RequiredInterface.AddPackagedElement(Operation_RequiredInterface_R);
				// Association S
				Operation_RequiredInterface_S.SetName("S");
				Operation_RequiredInterface_S.SetVisibility(VisibilityKind.public_);
				Operation_RequiredInterface_S.AddOwnedEnd(Operation_RequiredInterface_S_x);
				Operation_RequiredInterface_S.AddOwnedEnd(Operation_RequiredInterface_S_y);
			Operation_RequiredInterface.AddPackagedElement(Operation_RequiredInterface_S);
				// Activity main
				Operation_RequiredInterface_main.SetName("main");
				Operation_RequiredInterface_main.SetVisibility(VisibilityKind.public_);
				// FunctionBehavior testP
					Operation_RequiredInterface_main_testP.SetName("testP");
					Operation_RequiredInterface_main_testP.SetVisibility(VisibilityKind.public_);
					
						// Parameter p
						Operation_RequiredInterface_main_testP_p.SetName("p");
						Operation_RequiredInterface_main_testP_p.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_main_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_RequiredInterface_main_testP.AddOwnedParameter(Operation_RequiredInterface_main_testP_p);
					Operation_RequiredInterface_main_testP.AddLanguage("C#");
					Operation_RequiredInterface_main_testP.AddLanguage("Using");
					Operation_RequiredInterface_main_testP.AddBody("Console.WriteLine(\"Asserting d.a.b.p == 4\");  	// Test parameter p 	int p = ((IntegerValue)inputParameters.ElementAt(0).values.ElementAt(0)).value; 	Debug.Println(\"[doBody] argument p = \" + p); 	 	Console.WriteLine(\"d.a.b.p == \" + p); 	Console.Write(\"Invocation forwarded out of c through q: \");  	if(p == 4) 	{ 		Console.ForegroundColor = ConsoleColor.Green; 		Console.WriteLine(\"Assertion successful.\"); 	} 	else 	{ 		Console.ForegroundColor = ConsoleColor.Red; 		Console.WriteLine(\"Assertion failed!\"); 	}  	Console.ResetColor();");
					Operation_RequiredInterface_main_testP.AddBody("using fuml.semantics.simpleclassifiers; ");
				Operation_RequiredInterface_main.AddOwnedBehavior(Operation_RequiredInterface_main_testP);
					// CallOperationAction D()
					Operation_RequiredInterface_main_D_.SetName("D()");
					Operation_RequiredInterface_main_D_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						Operation_RequiredInterface_main_D__result.SetName("result");
						Operation_RequiredInterface_main_D__result.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_main_D__result.SetType(Operation_RequiredInterface_D);
					Operation_RequiredInterface_main_D_.AddResult(Operation_RequiredInterface_main_D__result);
					Operation_RequiredInterface_main_D_.SetOperation(Operation_RequiredInterface_D_D_D);
						// InputPin target
						Operation_RequiredInterface_main_D__target.SetName("target");
						Operation_RequiredInterface_main_D__target.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_main_D__target.SetType(Operation_RequiredInterface_D);
					Operation_RequiredInterface_main_D_.SetTarget(Operation_RequiredInterface_main_D__target);
				Operation_RequiredInterface_main.AddNode(Operation_RequiredInterface_main_D_);
					// CallOperationAction Call setP()
					Operation_RequiredInterface_main_Call_setP_.SetName("Call setP()");
					Operation_RequiredInterface_main_Call_setP_.SetVisibility(VisibilityKind.public_);
					Operation_RequiredInterface_main_Call_setP_.SetOperation(Operation_RequiredInterface_C_setP_Integer);
						// InputPin target
						Operation_RequiredInterface_main_Call_setP__target.SetName("target");
						Operation_RequiredInterface_main_Call_setP__target.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_main_Call_setP__target.SetType(Operation_RequiredInterface_C);
					Operation_RequiredInterface_main_Call_setP_.SetTarget(Operation_RequiredInterface_main_Call_setP__target);
						// InputPin v
						Operation_RequiredInterface_main_Call_setP__v.SetName("v");
						Operation_RequiredInterface_main_Call_setP__v.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_main_Call_setP__v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_RequiredInterface_main_Call_setP_.AddArgument(Operation_RequiredInterface_main_Call_setP__v);
				Operation_RequiredInterface_main.AddNode(Operation_RequiredInterface_main_Call_setP_);
					// ForkNode Fork d
					Operation_RequiredInterface_main_Fork_d.SetName("Fork d");
					Operation_RequiredInterface_main_Fork_d.SetVisibility(VisibilityKind.public_);
				Operation_RequiredInterface_main.AddNode(Operation_RequiredInterface_main_Fork_d);
					// ValueSpecificationAction Value(4)
					Operation_RequiredInterface_main_Value_4.SetName("Value(4)");
					Operation_RequiredInterface_main_Value_4.SetVisibility(VisibilityKind.public_);
						// LiteralInteger LiteralInteger15
						Operation_RequiredInterface_main_Value_4_LiteralInteger15.SetName("LiteralInteger15");
						Operation_RequiredInterface_main_Value_4_LiteralInteger15.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_main_Value_4_LiteralInteger15.SetValue(4);
					Operation_RequiredInterface_main_Value_4.SetValue(Operation_RequiredInterface_main_Value_4_LiteralInteger15);
						// OutputPin result
						Operation_RequiredInterface_main_Value_4_result.SetName("result");
						Operation_RequiredInterface_main_Value_4_result.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_main_Value_4_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_RequiredInterface_main_Value_4.SetResult(Operation_RequiredInterface_main_Value_4_result);
				Operation_RequiredInterface_main.AddNode(Operation_RequiredInterface_main_Value_4);
					// ReadStructuralFeatureAction Read d.c
					Operation_RequiredInterface_main_Read_d_c.SetName("Read d.c");
					Operation_RequiredInterface_main_Read_d_c.SetVisibility(VisibilityKind.public_);
					Operation_RequiredInterface_main_Read_d_c.SetStructuralFeature(Operation_RequiredInterface_D_c);
						// InputPin object
						Operation_RequiredInterface_main_Read_d_c_object.SetName("object");
						Operation_RequiredInterface_main_Read_d_c_object.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_main_Read_d_c_object.SetType(Operation_RequiredInterface_D);
					Operation_RequiredInterface_main_Read_d_c.SetObject(Operation_RequiredInterface_main_Read_d_c_object);
						// OutputPin result
						Operation_RequiredInterface_main_Read_d_c_result.SetName("result");
						Operation_RequiredInterface_main_Read_d_c_result.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_main_Read_d_c_result.SetType(Operation_RequiredInterface_C);
					Operation_RequiredInterface_main_Read_d_c.SetResult(Operation_RequiredInterface_main_Read_d_c_result);
				Operation_RequiredInterface_main.AddNode(Operation_RequiredInterface_main_Read_d_c);
					// ReadStructuralFeatureAction Read d.a
					Operation_RequiredInterface_main_Read_d_a.SetName("Read d.a");
					Operation_RequiredInterface_main_Read_d_a.SetVisibility(VisibilityKind.public_);
					Operation_RequiredInterface_main_Read_d_a.SetStructuralFeature(Operation_RequiredInterface_D_a);
						// InputPin object
						Operation_RequiredInterface_main_Read_d_a_object.SetName("object");
						Operation_RequiredInterface_main_Read_d_a_object.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_main_Read_d_a_object.SetType(Operation_RequiredInterface_D);
					Operation_RequiredInterface_main_Read_d_a.SetObject(Operation_RequiredInterface_main_Read_d_a_object);
						// OutputPin result
						Operation_RequiredInterface_main_Read_d_a_result.SetName("result");
						Operation_RequiredInterface_main_Read_d_a_result.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_main_Read_d_a_result.SetType(Operation_RequiredInterface_A);
					Operation_RequiredInterface_main_Read_d_a.SetResult(Operation_RequiredInterface_main_Read_d_a_result);
				Operation_RequiredInterface_main.AddNode(Operation_RequiredInterface_main_Read_d_a);
					// CallBehaviorAction Call testP
					Operation_RequiredInterface_main_Call_testP.SetName("Call testP");
					Operation_RequiredInterface_main_Call_testP.SetVisibility(VisibilityKind.public_);
					Operation_RequiredInterface_main_Call_testP.SetBehavior(Operation_RequiredInterface_main_testP);
						// InputPin p
						Operation_RequiredInterface_main_Call_testP_p.SetName("p");
						Operation_RequiredInterface_main_Call_testP_p.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_main_Call_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_RequiredInterface_main_Call_testP.AddArgument(Operation_RequiredInterface_main_Call_testP_p);
				Operation_RequiredInterface_main.AddNode(Operation_RequiredInterface_main_Call_testP);
					// ReadStructuralFeatureAction Read b.p
					Operation_RequiredInterface_main_Read_b_p.SetName("Read b.p");
					Operation_RequiredInterface_main_Read_b_p.SetVisibility(VisibilityKind.public_);
					Operation_RequiredInterface_main_Read_b_p.SetStructuralFeature(Operation_RequiredInterface_B_p);
						// InputPin object
						Operation_RequiredInterface_main_Read_b_p_object.SetName("object");
						Operation_RequiredInterface_main_Read_b_p_object.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_main_Read_b_p_object.SetType(Operation_RequiredInterface_B);
					Operation_RequiredInterface_main_Read_b_p.SetObject(Operation_RequiredInterface_main_Read_b_p_object);
						// OutputPin result
						Operation_RequiredInterface_main_Read_b_p_result.SetName("result");
						Operation_RequiredInterface_main_Read_b_p_result.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_main_Read_b_p_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_RequiredInterface_main_Read_b_p.SetResult(Operation_RequiredInterface_main_Read_b_p_result);
				Operation_RequiredInterface_main.AddNode(Operation_RequiredInterface_main_Read_b_p);
					// CreateObjectAction Create D
					Operation_RequiredInterface_main_Create_D.SetName("Create D");
					Operation_RequiredInterface_main_Create_D.SetVisibility(VisibilityKind.public_);
					Operation_RequiredInterface_main_Create_D.SetClassifier(Operation_RequiredInterface_D);
						// OutputPin result
						Operation_RequiredInterface_main_Create_D_result.SetName("result");
						Operation_RequiredInterface_main_Create_D_result.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_main_Create_D_result.SetType(Operation_RequiredInterface_D);
					Operation_RequiredInterface_main_Create_D.SetResult(Operation_RequiredInterface_main_Create_D_result);
				Operation_RequiredInterface_main.AddNode(Operation_RequiredInterface_main_Create_D);
					// ReadStructuralFeatureAction Read a.b
					Operation_RequiredInterface_main_Read_a_b.SetName("Read a.b");
					Operation_RequiredInterface_main_Read_a_b.SetVisibility(VisibilityKind.public_);
					Operation_RequiredInterface_main_Read_a_b.SetStructuralFeature(Operation_RequiredInterface_A_b);
						// InputPin object
						Operation_RequiredInterface_main_Read_a_b_object.SetName("object");
						Operation_RequiredInterface_main_Read_a_b_object.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_main_Read_a_b_object.SetType(Operation_RequiredInterface_A);
					Operation_RequiredInterface_main_Read_a_b.SetObject(Operation_RequiredInterface_main_Read_a_b_object);
						// OutputPin result
						Operation_RequiredInterface_main_Read_a_b_result.SetName("result");
						Operation_RequiredInterface_main_Read_a_b_result.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_main_Read_a_b_result.SetType(Operation_RequiredInterface_B);
					Operation_RequiredInterface_main_Read_a_b.SetResult(Operation_RequiredInterface_main_Read_a_b_result);
				Operation_RequiredInterface_main.AddNode(Operation_RequiredInterface_main_Read_a_b);
					// ObjectFlow ObjectFlow59 from result to object
					Operation_RequiredInterface_main_ObjectFlow59.SetName("ObjectFlow59");
					Operation_RequiredInterface_main_ObjectFlow59.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_main_ObjectFlow59.SetSource(Operation_RequiredInterface_main_Read_d_a_result);
					Operation_RequiredInterface_main_ObjectFlow59.SetTarget(Operation_RequiredInterface_main_Read_a_b_object);
						// LiteralBoolean LiteralBoolean61
						Operation_RequiredInterface_main_ObjectFlow59_LiteralBoolean61.SetName("LiteralBoolean61");
						Operation_RequiredInterface_main_ObjectFlow59_LiteralBoolean61.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_main_ObjectFlow59_LiteralBoolean61.SetValue(true);
					Operation_RequiredInterface_main_ObjectFlow59.SetGuard(Operation_RequiredInterface_main_ObjectFlow59_LiteralBoolean61);
				Operation_RequiredInterface_main.AddEdge(Operation_RequiredInterface_main_ObjectFlow59);
					// ObjectFlow ObjectFlow62 from result to target
					Operation_RequiredInterface_main_ObjectFlow62.SetName("ObjectFlow62");
					Operation_RequiredInterface_main_ObjectFlow62.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_main_ObjectFlow62.SetSource(Operation_RequiredInterface_main_Read_d_c_result);
					Operation_RequiredInterface_main_ObjectFlow62.SetTarget(Operation_RequiredInterface_main_Call_setP__target);
						// LiteralBoolean LiteralBoolean64
						Operation_RequiredInterface_main_ObjectFlow62_LiteralBoolean64.SetName("LiteralBoolean64");
						Operation_RequiredInterface_main_ObjectFlow62_LiteralBoolean64.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_main_ObjectFlow62_LiteralBoolean64.SetValue(true);
					Operation_RequiredInterface_main_ObjectFlow62.SetGuard(Operation_RequiredInterface_main_ObjectFlow62_LiteralBoolean64);
				Operation_RequiredInterface_main.AddEdge(Operation_RequiredInterface_main_ObjectFlow62);
					// ObjectFlow ObjectFlow18 from result to target
					Operation_RequiredInterface_main_ObjectFlow18.SetName("ObjectFlow18");
					Operation_RequiredInterface_main_ObjectFlow18.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_main_ObjectFlow18.SetSource(Operation_RequiredInterface_main_Create_D_result);
					Operation_RequiredInterface_main_ObjectFlow18.SetTarget(Operation_RequiredInterface_main_D__target);
						// LiteralBoolean LiteralBoolean19
						Operation_RequiredInterface_main_ObjectFlow18_LiteralBoolean19.SetName("LiteralBoolean19");
						Operation_RequiredInterface_main_ObjectFlow18_LiteralBoolean19.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_main_ObjectFlow18_LiteralBoolean19.SetValue(true);
					Operation_RequiredInterface_main_ObjectFlow18.SetGuard(Operation_RequiredInterface_main_ObjectFlow18_LiteralBoolean19);
				Operation_RequiredInterface_main.AddEdge(Operation_RequiredInterface_main_ObjectFlow18);
					// ObjectFlow ObjectFlow21 from result to object
					Operation_RequiredInterface_main_ObjectFlow21.SetName("ObjectFlow21");
					Operation_RequiredInterface_main_ObjectFlow21.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_main_ObjectFlow21.SetSource(Operation_RequiredInterface_main_Read_a_b_result);
					Operation_RequiredInterface_main_ObjectFlow21.SetTarget(Operation_RequiredInterface_main_Read_b_p_object);
						// LiteralBoolean LiteralBoolean23
						Operation_RequiredInterface_main_ObjectFlow21_LiteralBoolean23.SetName("LiteralBoolean23");
						Operation_RequiredInterface_main_ObjectFlow21_LiteralBoolean23.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_main_ObjectFlow21_LiteralBoolean23.SetValue(true);
					Operation_RequiredInterface_main_ObjectFlow21.SetGuard(Operation_RequiredInterface_main_ObjectFlow21_LiteralBoolean23);
				Operation_RequiredInterface_main.AddEdge(Operation_RequiredInterface_main_ObjectFlow21);
					// ObjectFlow ObjectFlow28 from result to p
					Operation_RequiredInterface_main_ObjectFlow28.SetName("ObjectFlow28");
					Operation_RequiredInterface_main_ObjectFlow28.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_main_ObjectFlow28.SetSource(Operation_RequiredInterface_main_Read_b_p_result);
					Operation_RequiredInterface_main_ObjectFlow28.SetTarget(Operation_RequiredInterface_main_Call_testP_p);
						// LiteralBoolean LiteralBoolean29
						Operation_RequiredInterface_main_ObjectFlow28_LiteralBoolean29.SetName("LiteralBoolean29");
						Operation_RequiredInterface_main_ObjectFlow28_LiteralBoolean29.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_main_ObjectFlow28_LiteralBoolean29.SetValue(true);
					Operation_RequiredInterface_main_ObjectFlow28.SetGuard(Operation_RequiredInterface_main_ObjectFlow28_LiteralBoolean29);
				Operation_RequiredInterface_main.AddEdge(Operation_RequiredInterface_main_ObjectFlow28);
					// ObjectFlow ObjectFlow65 from result to v
					Operation_RequiredInterface_main_ObjectFlow65.SetName("ObjectFlow65");
					Operation_RequiredInterface_main_ObjectFlow65.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_main_ObjectFlow65.SetSource(Operation_RequiredInterface_main_Value_4_result);
					Operation_RequiredInterface_main_ObjectFlow65.SetTarget(Operation_RequiredInterface_main_Call_setP__v);
						// LiteralBoolean LiteralBoolean66
						Operation_RequiredInterface_main_ObjectFlow65_LiteralBoolean66.SetName("LiteralBoolean66");
						Operation_RequiredInterface_main_ObjectFlow65_LiteralBoolean66.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_main_ObjectFlow65_LiteralBoolean66.SetValue(true);
					Operation_RequiredInterface_main_ObjectFlow65.SetGuard(Operation_RequiredInterface_main_ObjectFlow65_LiteralBoolean66);
				Operation_RequiredInterface_main.AddEdge(Operation_RequiredInterface_main_ObjectFlow65);
					// ObjectFlow ObjectFlow35 from result to Fork d
					Operation_RequiredInterface_main_ObjectFlow35.SetName("ObjectFlow35");
					Operation_RequiredInterface_main_ObjectFlow35.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_main_ObjectFlow35.SetSource(Operation_RequiredInterface_main_D__result);
					Operation_RequiredInterface_main_ObjectFlow35.SetTarget(Operation_RequiredInterface_main_Fork_d);
						// LiteralBoolean LiteralBoolean37
						Operation_RequiredInterface_main_ObjectFlow35_LiteralBoolean37.SetName("LiteralBoolean37");
						Operation_RequiredInterface_main_ObjectFlow35_LiteralBoolean37.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_main_ObjectFlow35_LiteralBoolean37.SetValue(true);
					Operation_RequiredInterface_main_ObjectFlow35.SetGuard(Operation_RequiredInterface_main_ObjectFlow35_LiteralBoolean37);
				Operation_RequiredInterface_main.AddEdge(Operation_RequiredInterface_main_ObjectFlow35);
					// ControlFlow ControlFlow71 from Call setP() to Read d.a
					Operation_RequiredInterface_main_ControlFlow71.SetName("ControlFlow71");
					Operation_RequiredInterface_main_ControlFlow71.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_main_ControlFlow71.SetSource(Operation_RequiredInterface_main_Call_setP_);
					Operation_RequiredInterface_main_ControlFlow71.SetTarget(Operation_RequiredInterface_main_Read_d_a);
				Operation_RequiredInterface_main.AddEdge(Operation_RequiredInterface_main_ControlFlow71);
					// ObjectFlow ObjectFlow42 from Fork d to object
					Operation_RequiredInterface_main_ObjectFlow42.SetName("ObjectFlow42");
					Operation_RequiredInterface_main_ObjectFlow42.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_main_ObjectFlow42.SetSource(Operation_RequiredInterface_main_Fork_d);
					Operation_RequiredInterface_main_ObjectFlow42.SetTarget(Operation_RequiredInterface_main_Read_d_a_object);
						// LiteralBoolean LiteralBoolean43
						Operation_RequiredInterface_main_ObjectFlow42_LiteralBoolean43.SetName("LiteralBoolean43");
						Operation_RequiredInterface_main_ObjectFlow42_LiteralBoolean43.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_main_ObjectFlow42_LiteralBoolean43.SetValue(true);
					Operation_RequiredInterface_main_ObjectFlow42.SetGuard(Operation_RequiredInterface_main_ObjectFlow42_LiteralBoolean43);
				Operation_RequiredInterface_main.AddEdge(Operation_RequiredInterface_main_ObjectFlow42);
					// ObjectFlow ObjectFlow74 from Fork d to object
					Operation_RequiredInterface_main_ObjectFlow74.SetName("ObjectFlow74");
					Operation_RequiredInterface_main_ObjectFlow74.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_main_ObjectFlow74.SetSource(Operation_RequiredInterface_main_Fork_d);
					Operation_RequiredInterface_main_ObjectFlow74.SetTarget(Operation_RequiredInterface_main_Read_d_c_object);
						// LiteralBoolean LiteralBoolean75
						Operation_RequiredInterface_main_ObjectFlow74_LiteralBoolean75.SetName("LiteralBoolean75");
						Operation_RequiredInterface_main_ObjectFlow74_LiteralBoolean75.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_main_ObjectFlow74_LiteralBoolean75.SetValue(true);
					Operation_RequiredInterface_main_ObjectFlow74.SetGuard(Operation_RequiredInterface_main_ObjectFlow74_LiteralBoolean75);
				Operation_RequiredInterface_main.AddEdge(Operation_RequiredInterface_main_ObjectFlow74);
			Operation_RequiredInterface.AddPackagedElement(Operation_RequiredInterface_main);
				// Class D
				Operation_RequiredInterface_D.SetName("D");
				Operation_RequiredInterface_D.SetVisibility(VisibilityKind.public_);
				
					// Property c
					Operation_RequiredInterface_D_c.SetName("c");
					Operation_RequiredInterface_D_c.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_D_c.SetType(Operation_RequiredInterface_C);
					Operation_RequiredInterface_D_c.SetAggregation(AggregationKind.composite);
				Operation_RequiredInterface_D.AddOwnedAttribute(Operation_RequiredInterface_D_c);
					// Property a
					Operation_RequiredInterface_D_a.SetName("a");
					Operation_RequiredInterface_D_a.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_D_a.SetType(Operation_RequiredInterface_A);
					Operation_RequiredInterface_D_a.SetAggregation(AggregationKind.composite);
				Operation_RequiredInterface_D.AddOwnedAttribute(Operation_RequiredInterface_D_a);
				
				Operation_RequiredInterface_D_s.SetName("s");
					Operation_RequiredInterface_D_s.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_D_s_ConnectorEnd77.SetRole(Operation_RequiredInterface_C_q);
						Operation_RequiredInterface_D_s_ConnectorEnd77.SetPartWithPort(Operation_RequiredInterface_D_c);
						
					Operation_RequiredInterface_D_s.AddEnd(Operation_RequiredInterface_D_s_ConnectorEnd77);
						
						Operation_RequiredInterface_D_s_ConnectorEnd78.SetRole(Operation_RequiredInterface_A_q);
						Operation_RequiredInterface_D_s_ConnectorEnd78.SetPartWithPort(Operation_RequiredInterface_D_a);
						
					Operation_RequiredInterface_D_s.AddEnd(Operation_RequiredInterface_D_s_ConnectorEnd78);
					Operation_RequiredInterface_D_s.SetType(Operation_RequiredInterface_S);
				Operation_RequiredInterface_D.AddOwnedConnector(Operation_RequiredInterface_D_s);
					// Operation D_D
					Operation_RequiredInterface_D_D_D.SetName("D_D");
					Operation_RequiredInterface_D_D_D.SetVisibility(VisibilityKind.public_);
						// Parameter result
						Operation_RequiredInterface_D_D_D_result.SetName("result");
						Operation_RequiredInterface_D_D_D_result.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_D_D_D_result.SetType(Operation_RequiredInterface_D);
						Operation_RequiredInterface_D_D_D_result.SetDirection(ParameterDirectionKind.return_);
					Operation_RequiredInterface_D_D_D.AddOwnedParameter(Operation_RequiredInterface_D_D_D_result);
					Operation_RequiredInterface_D_D_D.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				Operation_RequiredInterface_D.AddOwnedOperation(Operation_RequiredInterface_D_D_D);
			Operation_RequiredInterface.AddPackagedElement(Operation_RequiredInterface_D);
				// Class C
				Operation_RequiredInterface_C.SetName("C");
				Operation_RequiredInterface_C.SetVisibility(VisibilityKind.public_);
				
					// Port q
					Operation_RequiredInterface_C_q.SetName("q");
					Operation_RequiredInterface_C_q.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_C_q.SetType(Operation_RequiredInterface_IImpl);
					Operation_RequiredInterface_C_q.SetAggregation(AggregationKind.composite);
					Operation_RequiredInterface_C_q.isConjugated = true;;
					Operation_RequiredInterface_C_q.isService = true;
					Operation_RequiredInterface_C_q.AddRequired(Operation_RequiredInterface_I);
				Operation_RequiredInterface_C.AddOwnedAttribute(Operation_RequiredInterface_C_q);
				// Activity setPActivity
					Operation_RequiredInterface_C_setPActivity.SetName("setPActivity");
					Operation_RequiredInterface_C_setPActivity.SetVisibility(VisibilityKind.public_);
					
						// Parameter v
						Operation_RequiredInterface_C_setPActivity_v.SetName("v");
						Operation_RequiredInterface_C_setPActivity_v.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_C_setPActivity_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_RequiredInterface_C_setPActivity.AddOwnedParameter(Operation_RequiredInterface_C_setPActivity_v);
						// ReadSelfAction this
						Operation_RequiredInterface_C_setPActivity_this.SetName("this");
						Operation_RequiredInterface_C_setPActivity_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							Operation_RequiredInterface_C_setPActivity_this_result.SetName("result");
							Operation_RequiredInterface_C_setPActivity_this_result.SetVisibility(VisibilityKind.public_);
							Operation_RequiredInterface_C_setPActivity_this_result.SetType(Operation_RequiredInterface_C);
						Operation_RequiredInterface_C_setPActivity_this.SetResult(Operation_RequiredInterface_C_setPActivity_this_result);
					Operation_RequiredInterface_C_setPActivity.AddNode(Operation_RequiredInterface_C_setPActivity_this);
						// CallOperationAction Call I::setP on q
						Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q.SetName("Call I::setP on q");
						Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q.SetOnPort(Operation_RequiredInterface_C_q);
						Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q.SetOperation(Operation_RequiredInterface_I_setP_Integer);
							// InputPin target
							Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q_target.SetName("target");
							Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q_target.SetVisibility(VisibilityKind.public_);
							Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q_target.SetType(Operation_RequiredInterface_C);
						Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q.SetTarget(Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q_target);
							// InputPin v
							Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q_v.SetName("v");
							Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q_v.SetVisibility(VisibilityKind.public_);
							Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q.AddArgument(Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q_v);
					Operation_RequiredInterface_C_setPActivity.AddNode(Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q);
						// ActivityParameterNode vParameterNode
						Operation_RequiredInterface_C_setPActivity_vParameterNode.SetName("vParameterNode");
						Operation_RequiredInterface_C_setPActivity_vParameterNode.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_C_setPActivity_vParameterNode.SetParameter(Operation_RequiredInterface_C_setPActivity_v);
					Operation_RequiredInterface_C_setPActivity.AddNode(Operation_RequiredInterface_C_setPActivity_vParameterNode);
						// ObjectFlow ObjectFlow79 from vParameterNode to v
						Operation_RequiredInterface_C_setPActivity_ObjectFlow79.SetName("ObjectFlow79");
						Operation_RequiredInterface_C_setPActivity_ObjectFlow79.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_C_setPActivity_ObjectFlow79.SetSource(Operation_RequiredInterface_C_setPActivity_vParameterNode);
						Operation_RequiredInterface_C_setPActivity_ObjectFlow79.SetTarget(Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q_v);
							// LiteralBoolean LiteralBoolean80
							Operation_RequiredInterface_C_setPActivity_ObjectFlow79_LiteralBoolean80.SetName("LiteralBoolean80");
							Operation_RequiredInterface_C_setPActivity_ObjectFlow79_LiteralBoolean80.SetVisibility(VisibilityKind.public_);
							Operation_RequiredInterface_C_setPActivity_ObjectFlow79_LiteralBoolean80.SetValue(true);
						Operation_RequiredInterface_C_setPActivity_ObjectFlow79.SetGuard(Operation_RequiredInterface_C_setPActivity_ObjectFlow79_LiteralBoolean80);
					Operation_RequiredInterface_C_setPActivity.AddEdge(Operation_RequiredInterface_C_setPActivity_ObjectFlow79);
						// ObjectFlow ObjectFlow82 from result to target
						Operation_RequiredInterface_C_setPActivity_ObjectFlow82.SetName("ObjectFlow82");
						Operation_RequiredInterface_C_setPActivity_ObjectFlow82.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_C_setPActivity_ObjectFlow82.SetSource(Operation_RequiredInterface_C_setPActivity_this_result);
						Operation_RequiredInterface_C_setPActivity_ObjectFlow82.SetTarget(Operation_RequiredInterface_C_setPActivity_Call_I_setP_on_q_target);
							// LiteralBoolean LiteralBoolean83
							Operation_RequiredInterface_C_setPActivity_ObjectFlow82_LiteralBoolean83.SetName("LiteralBoolean83");
							Operation_RequiredInterface_C_setPActivity_ObjectFlow82_LiteralBoolean83.SetVisibility(VisibilityKind.public_);
							Operation_RequiredInterface_C_setPActivity_ObjectFlow82_LiteralBoolean83.SetValue(true);
						Operation_RequiredInterface_C_setPActivity_ObjectFlow82.SetGuard(Operation_RequiredInterface_C_setPActivity_ObjectFlow82_LiteralBoolean83);
					Operation_RequiredInterface_C_setPActivity.AddEdge(Operation_RequiredInterface_C_setPActivity_ObjectFlow82);
				Operation_RequiredInterface_C.AddOwnedBehavior(Operation_RequiredInterface_C_setPActivity);
					Operation_RequiredInterface_C_IRealization.SetName("IRealization");
					Operation_RequiredInterface_C_IRealization.SetVisibility(VisibilityKind.public_);
					Operation_RequiredInterface_C_IRealization.SetContract(Operation_RequiredInterface_I);
					
				Operation_RequiredInterface_C.AddInterfaceRealization(Operation_RequiredInterface_C_IRealization);
				
					// Operation setP_Integer
					Operation_RequiredInterface_C_setP_Integer.SetName("setP_Integer");
					Operation_RequiredInterface_C_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						Operation_RequiredInterface_C_setP_Integer_v.SetName("v");
						Operation_RequiredInterface_C_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_C_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_RequiredInterface_C_setP_Integer.AddOwnedParameter(Operation_RequiredInterface_C_setP_Integer_v);
					Operation_RequiredInterface_C_setP_Integer.AddMethod(Operation_RequiredInterface_C_setPActivity);
				Operation_RequiredInterface_C.AddOwnedOperation(Operation_RequiredInterface_C_setP_Integer);
			Operation_RequiredInterface.AddPackagedElement(Operation_RequiredInterface_C);
				// Class A
				Operation_RequiredInterface_A.SetName("A");
				Operation_RequiredInterface_A.SetVisibility(VisibilityKind.public_);
				
					// Port q
					Operation_RequiredInterface_A_q.SetName("q");
					Operation_RequiredInterface_A_q.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_A_q.SetType(Operation_RequiredInterface_IImpl);
					Operation_RequiredInterface_A_q.SetAggregation(AggregationKind.composite);
					Operation_RequiredInterface_A_q.isService = true;
					Operation_RequiredInterface_A_q.AddProvided(Operation_RequiredInterface_I);
				Operation_RequiredInterface_A.AddOwnedAttribute(Operation_RequiredInterface_A_q);
					// Property b
					Operation_RequiredInterface_A_b.SetName("b");
					Operation_RequiredInterface_A_b.SetVisibility(VisibilityKind.public_);
					
					Operation_RequiredInterface_A_b.SetType(Operation_RequiredInterface_B);
					Operation_RequiredInterface_A_b.SetAggregation(AggregationKind.composite);
				Operation_RequiredInterface_A.AddOwnedAttribute(Operation_RequiredInterface_A_b);
				// Activity setPActivity
					Operation_RequiredInterface_A_setPActivity.SetName("setPActivity");
					Operation_RequiredInterface_A_setPActivity.SetVisibility(VisibilityKind.public_);
					
						// Parameter v
						Operation_RequiredInterface_A_setPActivity_v.SetName("v");
						Operation_RequiredInterface_A_setPActivity_v.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_A_setPActivity_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_RequiredInterface_A_setPActivity.AddOwnedParameter(Operation_RequiredInterface_A_setPActivity_v);
						// CallOperationAction Call I::setP on q
						Operation_RequiredInterface_A_setPActivity_Call_I_setP_on_q.SetName("Call I::setP on q");
						Operation_RequiredInterface_A_setPActivity_Call_I_setP_on_q.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_A_setPActivity_Call_I_setP_on_q.SetOnPort(Operation_RequiredInterface_A_q);
						Operation_RequiredInterface_A_setPActivity_Call_I_setP_on_q.SetOperation(Operation_RequiredInterface_I_setP_Integer);
							// InputPin target
							Operation_RequiredInterface_A_setPActivity_Call_I_setP_on_q_target.SetName("target");
							Operation_RequiredInterface_A_setPActivity_Call_I_setP_on_q_target.SetVisibility(VisibilityKind.public_);
						Operation_RequiredInterface_A_setPActivity_Call_I_setP_on_q.SetTarget(Operation_RequiredInterface_A_setPActivity_Call_I_setP_on_q_target);
							// InputPin v
							Operation_RequiredInterface_A_setPActivity_Call_I_setP_on_q_v.SetName("v");
							Operation_RequiredInterface_A_setPActivity_Call_I_setP_on_q_v.SetVisibility(VisibilityKind.public_);
							Operation_RequiredInterface_A_setPActivity_Call_I_setP_on_q_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						Operation_RequiredInterface_A_setPActivity_Call_I_setP_on_q.AddArgument(Operation_RequiredInterface_A_setPActivity_Call_I_setP_on_q_v);
					Operation_RequiredInterface_A_setPActivity.AddNode(Operation_RequiredInterface_A_setPActivity_Call_I_setP_on_q);
						// ActivityParameterNode vParameterNode
						Operation_RequiredInterface_A_setPActivity_vParameterNode.SetName("vParameterNode");
						Operation_RequiredInterface_A_setPActivity_vParameterNode.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_A_setPActivity_vParameterNode.SetParameter(Operation_RequiredInterface_A_setPActivity_v);
					Operation_RequiredInterface_A_setPActivity.AddNode(Operation_RequiredInterface_A_setPActivity_vParameterNode);
						// ReadSelfAction this
						Operation_RequiredInterface_A_setPActivity_this.SetName("this");
						Operation_RequiredInterface_A_setPActivity_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							Operation_RequiredInterface_A_setPActivity_this_result.SetName("result");
							Operation_RequiredInterface_A_setPActivity_this_result.SetVisibility(VisibilityKind.public_);
							Operation_RequiredInterface_A_setPActivity_this_result.SetType(Operation_RequiredInterface_A);
						Operation_RequiredInterface_A_setPActivity_this.SetResult(Operation_RequiredInterface_A_setPActivity_this_result);
					Operation_RequiredInterface_A_setPActivity.AddNode(Operation_RequiredInterface_A_setPActivity_this);
						// ObjectFlow ObjectFlow95 from vParameterNode to v
						Operation_RequiredInterface_A_setPActivity_ObjectFlow95.SetName("ObjectFlow95");
						Operation_RequiredInterface_A_setPActivity_ObjectFlow95.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_A_setPActivity_ObjectFlow95.SetSource(Operation_RequiredInterface_A_setPActivity_vParameterNode);
						Operation_RequiredInterface_A_setPActivity_ObjectFlow95.SetTarget(Operation_RequiredInterface_A_setPActivity_Call_I_setP_on_q_v);
							// LiteralBoolean LiteralBoolean96
							Operation_RequiredInterface_A_setPActivity_ObjectFlow95_LiteralBoolean96.SetName("LiteralBoolean96");
							Operation_RequiredInterface_A_setPActivity_ObjectFlow95_LiteralBoolean96.SetVisibility(VisibilityKind.public_);
							Operation_RequiredInterface_A_setPActivity_ObjectFlow95_LiteralBoolean96.SetValue(true);
						Operation_RequiredInterface_A_setPActivity_ObjectFlow95.SetGuard(Operation_RequiredInterface_A_setPActivity_ObjectFlow95_LiteralBoolean96);
					Operation_RequiredInterface_A_setPActivity.AddEdge(Operation_RequiredInterface_A_setPActivity_ObjectFlow95);
						// ObjectFlow ObjectFlow103 from result to target
						Operation_RequiredInterface_A_setPActivity_ObjectFlow103.SetName("ObjectFlow103");
						Operation_RequiredInterface_A_setPActivity_ObjectFlow103.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_A_setPActivity_ObjectFlow103.SetSource(Operation_RequiredInterface_A_setPActivity_this_result);
						Operation_RequiredInterface_A_setPActivity_ObjectFlow103.SetTarget(Operation_RequiredInterface_A_setPActivity_Call_I_setP_on_q_target);
							// LiteralBoolean LiteralBoolean105
							Operation_RequiredInterface_A_setPActivity_ObjectFlow103_LiteralBoolean105.SetName("LiteralBoolean105");
							Operation_RequiredInterface_A_setPActivity_ObjectFlow103_LiteralBoolean105.SetVisibility(VisibilityKind.public_);
							Operation_RequiredInterface_A_setPActivity_ObjectFlow103_LiteralBoolean105.SetValue(true);
						Operation_RequiredInterface_A_setPActivity_ObjectFlow103.SetGuard(Operation_RequiredInterface_A_setPActivity_ObjectFlow103_LiteralBoolean105);
					Operation_RequiredInterface_A_setPActivity.AddEdge(Operation_RequiredInterface_A_setPActivity_ObjectFlow103);
				Operation_RequiredInterface_A.AddOwnedBehavior(Operation_RequiredInterface_A_setPActivity);
				Operation_RequiredInterface_A_r.SetName("r");
					Operation_RequiredInterface_A_r.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_A_r_ConnectorEnd94.SetRole(Operation_RequiredInterface_A_q);
						
					Operation_RequiredInterface_A_r.AddEnd(Operation_RequiredInterface_A_r_ConnectorEnd94);
						
						Operation_RequiredInterface_A_r_ConnectorEnd93.SetRole(Operation_RequiredInterface_A_b);
						
					Operation_RequiredInterface_A_r.AddEnd(Operation_RequiredInterface_A_r_ConnectorEnd93);
					Operation_RequiredInterface_A_r.SetType(Operation_RequiredInterface_R);
				Operation_RequiredInterface_A.AddOwnedConnector(Operation_RequiredInterface_A_r);
					// Operation setP_Integer
					Operation_RequiredInterface_A_setP_Integer.SetName("setP_Integer");
					Operation_RequiredInterface_A_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						Operation_RequiredInterface_A_setP_Integer_v.SetName("v");
						Operation_RequiredInterface_A_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						Operation_RequiredInterface_A_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Operation_RequiredInterface_A_setP_Integer.AddOwnedParameter(Operation_RequiredInterface_A_setP_Integer_v);
					Operation_RequiredInterface_A_setP_Integer.AddMethod(Operation_RequiredInterface_A_setPActivity);
				Operation_RequiredInterface_A.AddOwnedOperation(Operation_RequiredInterface_A_setP_Integer);
			Operation_RequiredInterface.AddPackagedElement(Operation_RequiredInterface_A);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // Operation_RequiredInterfaceModel
}
