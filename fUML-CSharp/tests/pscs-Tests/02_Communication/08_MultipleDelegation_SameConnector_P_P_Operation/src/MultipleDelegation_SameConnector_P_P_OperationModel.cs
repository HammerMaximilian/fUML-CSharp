/*
 * MultipleDelegation_SameConnector_P_P_OperationModel.cs
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

namespace MultipleDelegation_SameConnector_P_P_Operation
{
	public class MultipleDelegation_SameConnector_P_P_OperationModel : InMemoryModel
	{
		private static MultipleDelegation_SameConnector_P_P_OperationModel? instance;

		/*
		 * Model MultipleDelegation_SameConnector_P_P_Operation
		 */
		public Package MultipleDelegation_SameConnector_P_P_Operation = new();
			public Activity MultipleDelegation_SameConnector_P_P_Operation_main = new();
				public OpaqueBehavior MultipleDelegation_SameConnector_P_P_Operation_main_testP = new();
					public Parameter MultipleDelegation_SameConnector_P_P_Operation_main_testP_p = new();
				public ReadStructuralFeatureAction MultipleDelegation_SameConnector_P_P_Operation_main_Read_b_p = new();
					public OutputPin MultipleDelegation_SameConnector_P_P_Operation_main_Read_b_p_result = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_main_Read_b_p_result_LiteralInteger0 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Operation_main_Read_b_p_result_LiteralUnlimitedNatural1 = new();
					public InputPin MultipleDelegation_SameConnector_P_P_Operation_main_Read_b_p_object = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_main_Read_b_p_object_LiteralInteger2 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Operation_main_Read_b_p_object_LiteralUnlimitedNatural3 = new();
				public ControlFlow MultipleDelegation_SameConnector_P_P_Operation_main_ControlFlow4 = new();
				public CreateObjectAction MultipleDelegation_SameConnector_P_P_Operation_main_Create_C = new();
					public OutputPin MultipleDelegation_SameConnector_P_P_Operation_main_Create_C_result = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_main_Create_C_result_LiteralInteger5 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Operation_main_Create_C_result_LiteralUnlimitedNatural6 = new();
				public ObjectFlow MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow7 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow7_LiteralInteger8 = new();
					public LiteralBoolean MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow7_LiteralBoolean9 = new();
				public ObjectFlow MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow10 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow10_LiteralInteger11 = new();
					public LiteralBoolean MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow10_LiteralBoolean12 = new();
				public ForkNode MultipleDelegation_SameConnector_P_P_Operation_main_Fork_C = new();
				public CallBehaviorAction MultipleDelegation_SameConnector_P_P_Operation_main_Call_testP = new();
					public InputPin MultipleDelegation_SameConnector_P_P_Operation_main_Call_testP_p = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_main_Call_testP_p_LiteralInteger13 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_main_Call_testP_p_LiteralInteger14 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Operation_main_Call_testP_p_LiteralUnlimitedNatural15 = new();
				public ValueSpecificationAction MultipleDelegation_SameConnector_P_P_Operation_main_Value_4 = new();
					public OutputPin MultipleDelegation_SameConnector_P_P_Operation_main_Value_4_result = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_main_Value_4_result_LiteralInteger16 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Operation_main_Value_4_result_LiteralUnlimitedNatural17 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_main_Value_4_LiteralInteger18 = new();
				public ObjectFlow MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow19 = new();
					public LiteralBoolean MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow19_LiteralBoolean20 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow19_LiteralInteger21 = new();
				public ReadStructuralFeatureAction MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_p = new();
					public OutputPin MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_p_result = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_p_result_LiteralUnlimitedNatural22 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_p_result_LiteralInteger23 = new();
					public InputPin MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_p_object = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_p_object_LiteralInteger24 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_p_object_LiteralUnlimitedNatural25 = new();
				public ObjectFlow MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow26 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow26_LiteralInteger27 = new();
					public LiteralBoolean MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow26_LiteralBoolean28 = new();
				public CallOperationAction MultipleDelegation_SameConnector_P_P_Operation_main_C_ = new();
					public OutputPin MultipleDelegation_SameConnector_P_P_Operation_main_C__result = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Operation_main_C__result_LiteralUnlimitedNatural29 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_main_C__result_LiteralInteger30 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_main_C__result_LiteralInteger31 = new();
					public InputPin MultipleDelegation_SameConnector_P_P_Operation_main_C__target = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_main_C__target_LiteralInteger32 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Operation_main_C__target_LiteralUnlimitedNatural33 = new();
				public ObjectFlow MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow34 = new();
					public LiteralBoolean MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow34_LiteralBoolean35 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow34_LiteralInteger36 = new();
				public ObjectFlow MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow37 = new();
					public LiteralBoolean MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow37_LiteralBoolean38 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow37_LiteralInteger39 = new();
				public ObjectFlow MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow40 = new();
					public LiteralBoolean MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow40_LiteralBoolean41 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow40_LiteralInteger42 = new();
				public ObjectFlow MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow43 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow43_LiteralInteger44 = new();
					public LiteralBoolean MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow43_LiteralBoolean45 = new();
				public CallOperationAction MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP_ = new();
					public InputPin MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP__target = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP__target_LiteralUnlimitedNatural46 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP__target_LiteralInteger47 = new();
					public InputPin MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP__v = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP__v_LiteralInteger48 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP__v_LiteralInteger49 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP__v_LiteralUnlimitedNatural50 = new();
				public ReadStructuralFeatureAction MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b_ = new();
					public OutputPin MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b__result = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b__result_LiteralUnlimitedNatural51 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b__result_LiteralInteger52 = new();
					public InputPin MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b__object = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b__object_LiteralInteger53 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b__object_LiteralUnlimitedNatural54 = new();
			public Class_ MultipleDelegation_SameConnector_P_P_Operation_C = new();
				public Port MultipleDelegation_SameConnector_P_P_Operation_C_q = new();
				public Connector MultipleDelegation_SameConnector_P_P_Operation_C_r = new();
					public ConnectorEnd MultipleDelegation_SameConnector_P_P_Operation_C_r_ConnectorEnd55 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_C_r_ConnectorEnd55_LiteralInteger56 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Operation_C_r_ConnectorEnd55_LiteralUnlimitedNatural57 = new();
					public ConnectorEnd MultipleDelegation_SameConnector_P_P_Operation_C_r_ConnectorEnd58 = new();
						public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Operation_C_r_ConnectorEnd58_LiteralUnlimitedNatural59 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_C_r_ConnectorEnd58_LiteralInteger60 = new();
				public Property MultipleDelegation_SameConnector_P_P_Operation_C_b = new();
					public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Operation_C_b_LiteralUnlimitedNatural61 = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_C_b_LiteralInteger62 = new();
				public Operation MultipleDelegation_SameConnector_P_P_Operation_C_C_C = new();
					public Parameter MultipleDelegation_SameConnector_P_P_Operation_C_C_C_result = new();
			public Interface MultipleDelegation_SameConnector_P_P_Operation_I = new();
				public Operation MultipleDelegation_SameConnector_P_P_Operation_I_setP_Integer = new();
					public Parameter MultipleDelegation_SameConnector_P_P_Operation_I_setP_Integer_v = new();
			public Association MultipleDelegation_SameConnector_P_P_Operation_R = new();
				public Property MultipleDelegation_SameConnector_P_P_Operation_R_x = new();
				public Property MultipleDelegation_SameConnector_P_P_Operation_R_y = new();
			public Class_ MultipleDelegation_SameConnector_P_P_Operation_B = new();
				public Property MultipleDelegation_SameConnector_P_P_Operation_B_p = new();
					public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_B_p_LiteralInteger63 = new();
				public InterfaceRealization MultipleDelegation_SameConnector_P_P_Operation_B_IRealization = new();
				public Operation MultipleDelegation_SameConnector_P_P_Operation_B_B_B = new();
					public Parameter MultipleDelegation_SameConnector_P_P_Operation_B_B_B_result = new();
				public Operation MultipleDelegation_SameConnector_P_P_Operation_B_setP_Integer = new();
					public Parameter MultipleDelegation_SameConnector_P_P_Operation_B_setP_Integer_v = new();
				public Activity MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity = new();
					public Parameter MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_v = new();
					public AddStructuralFeatureValueAction MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p = new();
						public OutputPin MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p_result = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p_result_LiteralInteger64 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p_result_LiteralUnlimitedNatural65 = new();
						public InputPin MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p_value = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p_value_LiteralInteger66 = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p_value_LiteralUnlimitedNatural67 = new();
						public InputPin MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p_object = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p_object_LiteralUnlimitedNatural68 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p_object_LiteralInteger69 = new();
					public ActivityParameterNode MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_vParameterNode = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_vParameterNode_LiteralInteger70 = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_ObjectFlow71 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_ObjectFlow71_LiteralBoolean72 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_ObjectFlow71_LiteralInteger73 = new();
					public ObjectFlow MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_ObjectFlow74 = new();
						public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_ObjectFlow74_LiteralInteger75 = new();
						public LiteralBoolean MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_ObjectFlow74_LiteralBoolean76 = new();
					public ReadSelfAction MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_this = new();
						public OutputPin MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_this_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_this_result_LiteralUnlimitedNatural77 = new();
							public LiteralInteger MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_this_result_LiteralInteger78 = new();
			public Class_ MultipleDelegation_SameConnector_P_P_Operation_IImpl = new();
				public Operation MultipleDelegation_SameConnector_P_P_Operation_IImpl_setP_Integer = new();
					public Parameter MultipleDelegation_SameConnector_P_P_Operation_IImpl_setP_Integer_v = new();
				public InterfaceRealization MultipleDelegation_SameConnector_P_P_Operation_IImpl_IRealization = new();

		public static MultipleDelegation_SameConnector_P_P_OperationModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public MultipleDelegation_SameConnector_P_P_OperationModel()
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
			 * Model MultipleDelegation_SameConnector_P_P_Operation
			 */
			AddToElementRepository("MultipleDelegation_SameConnector_P_P_Operation", MultipleDelegation_SameConnector_P_P_Operation);
				AddToElementRepository("main", MultipleDelegation_SameConnector_P_P_Operation_main);
					AddToElementRepository("testP", MultipleDelegation_SameConnector_P_P_Operation_main_testP);
						AddToElementRepository("p", MultipleDelegation_SameConnector_P_P_Operation_main_testP_p);
					AddToElementRepository("Read b.p", MultipleDelegation_SameConnector_P_P_Operation_main_Read_b_p);
						AddToElementRepository("result", MultipleDelegation_SameConnector_P_P_Operation_main_Read_b_p_result);
							AddToElementRepository("LiteralInteger0", MultipleDelegation_SameConnector_P_P_Operation_main_Read_b_p_result_LiteralInteger0);
							AddToElementRepository("LiteralUnlimitedNatural1", MultipleDelegation_SameConnector_P_P_Operation_main_Read_b_p_result_LiteralUnlimitedNatural1);
						AddToElementRepository("object", MultipleDelegation_SameConnector_P_P_Operation_main_Read_b_p_object);
							AddToElementRepository("LiteralInteger2", MultipleDelegation_SameConnector_P_P_Operation_main_Read_b_p_object_LiteralInteger2);
							AddToElementRepository("LiteralUnlimitedNatural3", MultipleDelegation_SameConnector_P_P_Operation_main_Read_b_p_object_LiteralUnlimitedNatural3);
					AddToElementRepository("ControlFlow4", MultipleDelegation_SameConnector_P_P_Operation_main_ControlFlow4);
					AddToElementRepository("Create C", MultipleDelegation_SameConnector_P_P_Operation_main_Create_C);
						AddToElementRepository("result", MultipleDelegation_SameConnector_P_P_Operation_main_Create_C_result);
							AddToElementRepository("LiteralInteger5", MultipleDelegation_SameConnector_P_P_Operation_main_Create_C_result_LiteralInteger5);
							AddToElementRepository("LiteralUnlimitedNatural6", MultipleDelegation_SameConnector_P_P_Operation_main_Create_C_result_LiteralUnlimitedNatural6);
					AddToElementRepository("ObjectFlow7", MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow7);
						AddToElementRepository("LiteralInteger8", MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow7_LiteralInteger8);
						AddToElementRepository("LiteralBoolean9", MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow7_LiteralBoolean9);
					AddToElementRepository("ObjectFlow10", MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow10);
						AddToElementRepository("LiteralInteger11", MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow10_LiteralInteger11);
						AddToElementRepository("LiteralBoolean12", MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow10_LiteralBoolean12);
					AddToElementRepository("Fork C", MultipleDelegation_SameConnector_P_P_Operation_main_Fork_C);
					AddToElementRepository("Call testP", MultipleDelegation_SameConnector_P_P_Operation_main_Call_testP);
						AddToElementRepository("p", MultipleDelegation_SameConnector_P_P_Operation_main_Call_testP_p);
							AddToElementRepository("LiteralInteger13", MultipleDelegation_SameConnector_P_P_Operation_main_Call_testP_p_LiteralInteger13);
							AddToElementRepository("LiteralInteger14", MultipleDelegation_SameConnector_P_P_Operation_main_Call_testP_p_LiteralInteger14);
							AddToElementRepository("LiteralUnlimitedNatural15", MultipleDelegation_SameConnector_P_P_Operation_main_Call_testP_p_LiteralUnlimitedNatural15);
					AddToElementRepository("Value(4)", MultipleDelegation_SameConnector_P_P_Operation_main_Value_4);
						AddToElementRepository("result", MultipleDelegation_SameConnector_P_P_Operation_main_Value_4_result);
							AddToElementRepository("LiteralInteger16", MultipleDelegation_SameConnector_P_P_Operation_main_Value_4_result_LiteralInteger16);
							AddToElementRepository("LiteralUnlimitedNatural17", MultipleDelegation_SameConnector_P_P_Operation_main_Value_4_result_LiteralUnlimitedNatural17);
						AddToElementRepository("LiteralInteger18", MultipleDelegation_SameConnector_P_P_Operation_main_Value_4_LiteralInteger18);
					AddToElementRepository("ObjectFlow19", MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow19);
						AddToElementRepository("LiteralBoolean20", MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow19_LiteralBoolean20);
						AddToElementRepository("LiteralInteger21", MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow19_LiteralInteger21);
					AddToElementRepository("Read c.p", MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_p);
						AddToElementRepository("result", MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_p_result);
							AddToElementRepository("LiteralUnlimitedNatural22", MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_p_result_LiteralUnlimitedNatural22);
							AddToElementRepository("LiteralInteger23", MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_p_result_LiteralInteger23);
						AddToElementRepository("object", MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_p_object);
							AddToElementRepository("LiteralInteger24", MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_p_object_LiteralInteger24);
							AddToElementRepository("LiteralUnlimitedNatural25", MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_p_object_LiteralUnlimitedNatural25);
					AddToElementRepository("ObjectFlow26", MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow26);
						AddToElementRepository("LiteralInteger27", MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow26_LiteralInteger27);
						AddToElementRepository("LiteralBoolean28", MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow26_LiteralBoolean28);
					AddToElementRepository("C()", MultipleDelegation_SameConnector_P_P_Operation_main_C_);
						AddToElementRepository("result", MultipleDelegation_SameConnector_P_P_Operation_main_C__result);
							AddToElementRepository("LiteralUnlimitedNatural29", MultipleDelegation_SameConnector_P_P_Operation_main_C__result_LiteralUnlimitedNatural29);
							AddToElementRepository("LiteralInteger30", MultipleDelegation_SameConnector_P_P_Operation_main_C__result_LiteralInteger30);
							AddToElementRepository("LiteralInteger31", MultipleDelegation_SameConnector_P_P_Operation_main_C__result_LiteralInteger31);
						AddToElementRepository("target", MultipleDelegation_SameConnector_P_P_Operation_main_C__target);
							AddToElementRepository("LiteralInteger32", MultipleDelegation_SameConnector_P_P_Operation_main_C__target_LiteralInteger32);
							AddToElementRepository("LiteralUnlimitedNatural33", MultipleDelegation_SameConnector_P_P_Operation_main_C__target_LiteralUnlimitedNatural33);
					AddToElementRepository("ObjectFlow34", MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow34);
						AddToElementRepository("LiteralBoolean35", MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow34_LiteralBoolean35);
						AddToElementRepository("LiteralInteger36", MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow34_LiteralInteger36);
					AddToElementRepository("ObjectFlow37", MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow37);
						AddToElementRepository("LiteralBoolean38", MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow37_LiteralBoolean38);
						AddToElementRepository("LiteralInteger39", MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow37_LiteralInteger39);
					AddToElementRepository("ObjectFlow40", MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow40);
						AddToElementRepository("LiteralBoolean41", MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow40_LiteralBoolean41);
						AddToElementRepository("LiteralInteger42", MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow40_LiteralInteger42);
					AddToElementRepository("ObjectFlow43", MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow43);
						AddToElementRepository("LiteralInteger44", MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow43_LiteralInteger44);
						AddToElementRepository("LiteralBoolean45", MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow43_LiteralBoolean45);
					AddToElementRepository("Call p.setP()", MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP_);
						AddToElementRepository("target", MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP__target);
							AddToElementRepository("LiteralUnlimitedNatural46", MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP__target_LiteralUnlimitedNatural46);
							AddToElementRepository("LiteralInteger47", MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP__target_LiteralInteger47);
						AddToElementRepository("v", MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP__v);
							AddToElementRepository("LiteralInteger48", MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP__v_LiteralInteger48);
							AddToElementRepository("LiteralInteger49", MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP__v_LiteralInteger49);
							AddToElementRepository("LiteralUnlimitedNatural50", MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP__v_LiteralUnlimitedNatural50);
					AddToElementRepository("Read c.b[]", MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b_);
						AddToElementRepository("result", MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b__result);
							AddToElementRepository("LiteralUnlimitedNatural51", MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b__result_LiteralUnlimitedNatural51);
							AddToElementRepository("LiteralInteger52", MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b__result_LiteralInteger52);
						AddToElementRepository("object", MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b__object);
							AddToElementRepository("LiteralInteger53", MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b__object_LiteralInteger53);
							AddToElementRepository("LiteralUnlimitedNatural54", MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b__object_LiteralUnlimitedNatural54);
				AddToElementRepository("C", MultipleDelegation_SameConnector_P_P_Operation_C);
					AddToElementRepository("q", MultipleDelegation_SameConnector_P_P_Operation_C_q);
					AddToElementRepository("r", MultipleDelegation_SameConnector_P_P_Operation_C_r);
						AddToElementRepository("ConnectorEnd55", MultipleDelegation_SameConnector_P_P_Operation_C_r_ConnectorEnd55);
							AddToElementRepository("LiteralInteger56", MultipleDelegation_SameConnector_P_P_Operation_C_r_ConnectorEnd55_LiteralInteger56);
							AddToElementRepository("LiteralUnlimitedNatural57", MultipleDelegation_SameConnector_P_P_Operation_C_r_ConnectorEnd55_LiteralUnlimitedNatural57);
						AddToElementRepository("ConnectorEnd58", MultipleDelegation_SameConnector_P_P_Operation_C_r_ConnectorEnd58);
							AddToElementRepository("LiteralUnlimitedNatural59", MultipleDelegation_SameConnector_P_P_Operation_C_r_ConnectorEnd58_LiteralUnlimitedNatural59);
							AddToElementRepository("LiteralInteger60", MultipleDelegation_SameConnector_P_P_Operation_C_r_ConnectorEnd58_LiteralInteger60);
					AddToElementRepository("b", MultipleDelegation_SameConnector_P_P_Operation_C_b);
						AddToElementRepository("LiteralUnlimitedNatural61", MultipleDelegation_SameConnector_P_P_Operation_C_b_LiteralUnlimitedNatural61);
						AddToElementRepository("LiteralInteger62", MultipleDelegation_SameConnector_P_P_Operation_C_b_LiteralInteger62);
					AddToElementRepository("C_C", MultipleDelegation_SameConnector_P_P_Operation_C_C_C);
						AddToElementRepository("result", MultipleDelegation_SameConnector_P_P_Operation_C_C_C_result);
				AddToElementRepository("I", MultipleDelegation_SameConnector_P_P_Operation_I);
					AddToElementRepository("setP_Integer", MultipleDelegation_SameConnector_P_P_Operation_I_setP_Integer);
						AddToElementRepository("v", MultipleDelegation_SameConnector_P_P_Operation_I_setP_Integer_v);
				AddToElementRepository("R", MultipleDelegation_SameConnector_P_P_Operation_R);
					AddToElementRepository("x", MultipleDelegation_SameConnector_P_P_Operation_R_x);
					AddToElementRepository("y", MultipleDelegation_SameConnector_P_P_Operation_R_y);
				AddToElementRepository("B", MultipleDelegation_SameConnector_P_P_Operation_B);
					AddToElementRepository("p", MultipleDelegation_SameConnector_P_P_Operation_B_p);
						AddToElementRepository("LiteralInteger63", MultipleDelegation_SameConnector_P_P_Operation_B_p_LiteralInteger63);
					AddToElementRepository("IRealization", MultipleDelegation_SameConnector_P_P_Operation_B_IRealization);
					AddToElementRepository("B_B", MultipleDelegation_SameConnector_P_P_Operation_B_B_B);
						AddToElementRepository("result", MultipleDelegation_SameConnector_P_P_Operation_B_B_B_result);
					AddToElementRepository("setP_Integer", MultipleDelegation_SameConnector_P_P_Operation_B_setP_Integer);
						AddToElementRepository("v", MultipleDelegation_SameConnector_P_P_Operation_B_setP_Integer_v);
					AddToElementRepository("setPActivity", MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity);
						AddToElementRepository("v", MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_v);
						AddToElementRepository("Set this.p", MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p_result);
								AddToElementRepository("LiteralInteger64", MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p_result_LiteralInteger64);
								AddToElementRepository("LiteralUnlimitedNatural65", MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p_result_LiteralUnlimitedNatural65);
							AddToElementRepository("value", MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p_value);
								AddToElementRepository("LiteralInteger66", MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p_value_LiteralInteger66);
								AddToElementRepository("LiteralUnlimitedNatural67", MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p_value_LiteralUnlimitedNatural67);
							AddToElementRepository("object", MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p_object);
								AddToElementRepository("LiteralUnlimitedNatural68", MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p_object_LiteralUnlimitedNatural68);
								AddToElementRepository("LiteralInteger69", MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p_object_LiteralInteger69);
						AddToElementRepository("vParameterNode", MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_vParameterNode);
							AddToElementRepository("LiteralInteger70", MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_vParameterNode_LiteralInteger70);
						AddToElementRepository("ObjectFlow71", MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_ObjectFlow71);
							AddToElementRepository("LiteralBoolean72", MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_ObjectFlow71_LiteralBoolean72);
							AddToElementRepository("LiteralInteger73", MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_ObjectFlow71_LiteralInteger73);
						AddToElementRepository("ObjectFlow74", MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_ObjectFlow74);
							AddToElementRepository("LiteralInteger75", MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_ObjectFlow74_LiteralInteger75);
							AddToElementRepository("LiteralBoolean76", MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_ObjectFlow74_LiteralBoolean76);
						AddToElementRepository("this", MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_this);
							AddToElementRepository("result", MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_this_result);
								AddToElementRepository("LiteralUnlimitedNatural77", MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_this_result_LiteralUnlimitedNatural77);
								AddToElementRepository("LiteralInteger78", MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_this_result_LiteralInteger78);
				AddToElementRepository("IImpl", MultipleDelegation_SameConnector_P_P_Operation_IImpl);
					AddToElementRepository("setP_Integer", MultipleDelegation_SameConnector_P_P_Operation_IImpl_setP_Integer);
						AddToElementRepository("v", MultipleDelegation_SameConnector_P_P_Operation_IImpl_setP_Integer_v);
					AddToElementRepository("IRealization", MultipleDelegation_SameConnector_P_P_Operation_IImpl_IRealization);

			// Initialize public members
			/*
			 * Model MultipleDelegation_SameConnector_P_P_Operation
			 */
			MultipleDelegation_SameConnector_P_P_Operation.SetName("MultipleDelegation_SameConnector_P_P_Operation");
			MultipleDelegation_SameConnector_P_P_Operation.SetVisibility(VisibilityKind.public_);
				// Activity main
				MultipleDelegation_SameConnector_P_P_Operation_main.SetName("main");
				MultipleDelegation_SameConnector_P_P_Operation_main.SetVisibility(VisibilityKind.public_);
				// FunctionBehavior testP
					MultipleDelegation_SameConnector_P_P_Operation_main_testP.SetName("testP");
					MultipleDelegation_SameConnector_P_P_Operation_main_testP.SetVisibility(VisibilityKind.public_);
					
						// Parameter p
						MultipleDelegation_SameConnector_P_P_Operation_main_testP_p.SetName("p");
						MultipleDelegation_SameConnector_P_P_Operation_main_testP_p.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Operation_main_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_SameConnector_P_P_Operation_main_testP.AddOwnedParameter(MultipleDelegation_SameConnector_P_P_Operation_main_testP_p);
					MultipleDelegation_SameConnector_P_P_Operation_main_testP.AddLanguage("C#");
					MultipleDelegation_SameConnector_P_P_Operation_main_testP.AddLanguage("Using");
					MultipleDelegation_SameConnector_P_P_Operation_main_testP.AddBody("if(index == 1) 	{ 		Console.WriteLine(\"Asserting c.b[1] == 4 || c.b[2] == 4 || c.b[3] == 4 || c.b[4] == 4\"); 	}  	// For some reason, during the first execution of the expansion region, its body is actually executed twice. 	// Because of that, the body is actually executaed 5 times in total. This if-statement covers that up until solved. 	if(index <= MAX_INDEX) 	{  		// Test parameter p 		int p = ((IntegerValue)inputParameters.ElementAt(0).values.ElementAt(0)).value; 		Debug.Println(\"[doBody] argument p = \" + p); 	 		Console.WriteLine( \"c.b[\" << index << \"] == \" + p); 		success = success || (p == 4);  		if(index == MAX_INDEX) 		{  			Console.Write(\"Operation call delegated: \");  			if(success) 			{ 				Console.ForegroundColor = ConsoleColor.Green; 				Console.WriteLine(\"Assertion successful.\"); 			} 			else 			{ 				Console.ForegroundColor = ConsoleColor.Red; 				Console.WriteLine(\"Assertion failed!\"); 			}  			Console.ResetColor(); 		} 	}  	index++;");
					MultipleDelegation_SameConnector_P_P_Operation_main_testP.AddBody("using fuml.semantics.simpleclassifiers; ");
				MultipleDelegation_SameConnector_P_P_Operation_main.AddOwnedBehavior(MultipleDelegation_SameConnector_P_P_Operation_main_testP);
					// ReadStructuralFeatureAction Read b.p
					MultipleDelegation_SameConnector_P_P_Operation_main_Read_b_p.SetName("Read b.p");
					MultipleDelegation_SameConnector_P_P_Operation_main_Read_b_p.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_P_Operation_main_Read_b_p.SetStructuralFeature(MultipleDelegation_SameConnector_P_P_Operation_B_p);
						// InputPin object
						MultipleDelegation_SameConnector_P_P_Operation_main_Read_b_p_object.SetName("object");
						MultipleDelegation_SameConnector_P_P_Operation_main_Read_b_p_object.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Operation_main_Read_b_p_object.SetType(MultipleDelegation_SameConnector_P_P_Operation_B);
					MultipleDelegation_SameConnector_P_P_Operation_main_Read_b_p.SetObject(MultipleDelegation_SameConnector_P_P_Operation_main_Read_b_p_object);
						// OutputPin result
						MultipleDelegation_SameConnector_P_P_Operation_main_Read_b_p_result.SetName("result");
						MultipleDelegation_SameConnector_P_P_Operation_main_Read_b_p_result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Operation_main_Read_b_p_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_SameConnector_P_P_Operation_main_Read_b_p.SetResult(MultipleDelegation_SameConnector_P_P_Operation_main_Read_b_p_result);
				MultipleDelegation_SameConnector_P_P_Operation_main.AddNode(MultipleDelegation_SameConnector_P_P_Operation_main_Read_b_p);
					// CreateObjectAction Create C
					MultipleDelegation_SameConnector_P_P_Operation_main_Create_C.SetName("Create C");
					MultipleDelegation_SameConnector_P_P_Operation_main_Create_C.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_P_Operation_main_Create_C.SetClassifier(MultipleDelegation_SameConnector_P_P_Operation_C);
						// OutputPin result
						MultipleDelegation_SameConnector_P_P_Operation_main_Create_C_result.SetName("result");
						MultipleDelegation_SameConnector_P_P_Operation_main_Create_C_result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Operation_main_Create_C_result.SetType(MultipleDelegation_SameConnector_P_P_Operation_C);
					MultipleDelegation_SameConnector_P_P_Operation_main_Create_C.SetResult(MultipleDelegation_SameConnector_P_P_Operation_main_Create_C_result);
				MultipleDelegation_SameConnector_P_P_Operation_main.AddNode(MultipleDelegation_SameConnector_P_P_Operation_main_Create_C);
					// ReadStructuralFeatureAction Read c.p
					MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_p.SetName("Read c.p");
					MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_p.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_p.SetStructuralFeature(MultipleDelegation_SameConnector_P_P_Operation_C_q);
						// InputPin object
						MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_p_object.SetName("object");
						MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_p_object.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_p_object.SetType(MultipleDelegation_SameConnector_P_P_Operation_C);
					MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_p.SetObject(MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_p_object);
						// OutputPin result
						MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_p_result.SetName("result");
						MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_p_result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_p_result.SetType(MultipleDelegation_SameConnector_P_P_Operation_IImpl);
					MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_p.SetResult(MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_p_result);
				MultipleDelegation_SameConnector_P_P_Operation_main.AddNode(MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_p);
					// CallOperationAction C()
					MultipleDelegation_SameConnector_P_P_Operation_main_C_.SetName("C()");
					MultipleDelegation_SameConnector_P_P_Operation_main_C_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						MultipleDelegation_SameConnector_P_P_Operation_main_C__result.SetName("result");
						MultipleDelegation_SameConnector_P_P_Operation_main_C__result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Operation_main_C__result.SetType(MultipleDelegation_SameConnector_P_P_Operation_C);
					MultipleDelegation_SameConnector_P_P_Operation_main_C_.AddResult(MultipleDelegation_SameConnector_P_P_Operation_main_C__result);
					MultipleDelegation_SameConnector_P_P_Operation_main_C_.SetOperation(MultipleDelegation_SameConnector_P_P_Operation_C_C_C);
						// InputPin target
						MultipleDelegation_SameConnector_P_P_Operation_main_C__target.SetName("target");
						MultipleDelegation_SameConnector_P_P_Operation_main_C__target.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Operation_main_C__target.SetType(MultipleDelegation_SameConnector_P_P_Operation_C);
					MultipleDelegation_SameConnector_P_P_Operation_main_C_.SetTarget(MultipleDelegation_SameConnector_P_P_Operation_main_C__target);
				MultipleDelegation_SameConnector_P_P_Operation_main.AddNode(MultipleDelegation_SameConnector_P_P_Operation_main_C_);
					// ForkNode Fork C
					MultipleDelegation_SameConnector_P_P_Operation_main_Fork_C.SetName("Fork C");
					MultipleDelegation_SameConnector_P_P_Operation_main_Fork_C.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_SameConnector_P_P_Operation_main.AddNode(MultipleDelegation_SameConnector_P_P_Operation_main_Fork_C);
					// CallBehaviorAction Call testP
					MultipleDelegation_SameConnector_P_P_Operation_main_Call_testP.SetName("Call testP");
					MultipleDelegation_SameConnector_P_P_Operation_main_Call_testP.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_P_Operation_main_Call_testP.SetBehavior(MultipleDelegation_SameConnector_P_P_Operation_main_testP);
						// InputPin p
						MultipleDelegation_SameConnector_P_P_Operation_main_Call_testP_p.SetName("p");
						MultipleDelegation_SameConnector_P_P_Operation_main_Call_testP_p.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Operation_main_Call_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_SameConnector_P_P_Operation_main_Call_testP.AddArgument(MultipleDelegation_SameConnector_P_P_Operation_main_Call_testP_p);
				MultipleDelegation_SameConnector_P_P_Operation_main.AddNode(MultipleDelegation_SameConnector_P_P_Operation_main_Call_testP);
					// CallOperationAction Call p.setP()
					MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP_.SetName("Call p.setP()");
					MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP_.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP_.SetOperation(MultipleDelegation_SameConnector_P_P_Operation_I_setP_Integer);
						// InputPin target
						MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP__target.SetName("target");
						MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP__target.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP__target.SetType(MultipleDelegation_SameConnector_P_P_Operation_I);
					MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP_.SetTarget(MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP__target);
						// InputPin v
						MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP__v.SetName("v");
						MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP__v.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP__v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP_.AddArgument(MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP__v);
				MultipleDelegation_SameConnector_P_P_Operation_main.AddNode(MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP_);
					// ValueSpecificationAction Value(4)
					MultipleDelegation_SameConnector_P_P_Operation_main_Value_4.SetName("Value(4)");
					MultipleDelegation_SameConnector_P_P_Operation_main_Value_4.SetVisibility(VisibilityKind.public_);
						// LiteralInteger LiteralInteger18
						MultipleDelegation_SameConnector_P_P_Operation_main_Value_4_LiteralInteger18.SetName("LiteralInteger18");
						MultipleDelegation_SameConnector_P_P_Operation_main_Value_4_LiteralInteger18.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Operation_main_Value_4_LiteralInteger18.SetValue(4);
					MultipleDelegation_SameConnector_P_P_Operation_main_Value_4.SetValue(MultipleDelegation_SameConnector_P_P_Operation_main_Value_4_LiteralInteger18);
						// OutputPin result
						MultipleDelegation_SameConnector_P_P_Operation_main_Value_4_result.SetName("result");
						MultipleDelegation_SameConnector_P_P_Operation_main_Value_4_result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Operation_main_Value_4_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_SameConnector_P_P_Operation_main_Value_4.SetResult(MultipleDelegation_SameConnector_P_P_Operation_main_Value_4_result);
				MultipleDelegation_SameConnector_P_P_Operation_main.AddNode(MultipleDelegation_SameConnector_P_P_Operation_main_Value_4);
					// ReadStructuralFeatureAction Read c.b[]
					MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b_.SetName("Read c.b[]");
					MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b_.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b_.SetStructuralFeature(MultipleDelegation_SameConnector_P_P_Operation_C_b);
						// InputPin object
						MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b__object.SetName("object");
						MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b__object.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b__object.SetType(MultipleDelegation_SameConnector_P_P_Operation_C);
					MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b_.SetObject(MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b__object);
						// OutputPin result
						MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b__result.SetName("result");
						MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b__result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b__result.SetType(MultipleDelegation_SameConnector_P_P_Operation_B);
						MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b__result.SetUpper(4);
						MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b__result.SetLower(4);
					MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b_.SetResult(MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b__result);
				MultipleDelegation_SameConnector_P_P_Operation_main.AddNode(MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b_);
					// ObjectFlow ObjectFlow19 from result to p
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow19.SetName("ObjectFlow19");
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow19.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow19.SetSource(MultipleDelegation_SameConnector_P_P_Operation_main_Read_b_p_result);
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow19.SetTarget(MultipleDelegation_SameConnector_P_P_Operation_main_Call_testP_p);
						// LiteralBoolean LiteralBoolean20
						MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow19_LiteralBoolean20.SetName("LiteralBoolean20");
						MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow19_LiteralBoolean20.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow19_LiteralBoolean20.SetValue(true);
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow19.SetGuard(MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow19_LiteralBoolean20);
				MultipleDelegation_SameConnector_P_P_Operation_main.AddEdge(MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow19);
					// ControlFlow ControlFlow4 from Call p.setP() to Read c.b[]
					MultipleDelegation_SameConnector_P_P_Operation_main_ControlFlow4.SetName("ControlFlow4");
					MultipleDelegation_SameConnector_P_P_Operation_main_ControlFlow4.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_P_Operation_main_ControlFlow4.SetSource(MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP_);
					MultipleDelegation_SameConnector_P_P_Operation_main_ControlFlow4.SetTarget(MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b_);
				MultipleDelegation_SameConnector_P_P_Operation_main.AddEdge(MultipleDelegation_SameConnector_P_P_Operation_main_ControlFlow4);
					// ObjectFlow ObjectFlow7 from result to Fork C
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow7.SetName("ObjectFlow7");
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow7.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow7.SetSource(MultipleDelegation_SameConnector_P_P_Operation_main_C__result);
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow7.SetTarget(MultipleDelegation_SameConnector_P_P_Operation_main_Fork_C);
						// LiteralBoolean LiteralBoolean9
						MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow7_LiteralBoolean9.SetName("LiteralBoolean9");
						MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow7_LiteralBoolean9.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow7_LiteralBoolean9.SetValue(true);
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow7.SetGuard(MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow7_LiteralBoolean9);
				MultipleDelegation_SameConnector_P_P_Operation_main.AddEdge(MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow7);
					// ObjectFlow ObjectFlow10 from result to target
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow10.SetName("ObjectFlow10");
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow10.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow10.SetSource(MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_p_result);
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow10.SetTarget(MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP__target);
						// LiteralBoolean LiteralBoolean12
						MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow10_LiteralBoolean12.SetName("LiteralBoolean12");
						MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow10_LiteralBoolean12.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow10_LiteralBoolean12.SetValue(true);
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow10.SetGuard(MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow10_LiteralBoolean12);
				MultipleDelegation_SameConnector_P_P_Operation_main.AddEdge(MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow10);
					// ObjectFlow ObjectFlow26 from result to object
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow26.SetName("ObjectFlow26");
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow26.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow26.SetSource(MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b__result);
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow26.SetTarget(MultipleDelegation_SameConnector_P_P_Operation_main_Read_b_p_object);
						// LiteralBoolean LiteralBoolean28
						MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow26_LiteralBoolean28.SetName("LiteralBoolean28");
						MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow26_LiteralBoolean28.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow26_LiteralBoolean28.SetValue(true);
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow26.SetGuard(MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow26_LiteralBoolean28);
				MultipleDelegation_SameConnector_P_P_Operation_main.AddEdge(MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow26);
					// ObjectFlow ObjectFlow34 from Fork C to object
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow34.SetName("ObjectFlow34");
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow34.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow34.SetSource(MultipleDelegation_SameConnector_P_P_Operation_main_Fork_C);
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow34.SetTarget(MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_p_object);
						// LiteralBoolean LiteralBoolean35
						MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow34_LiteralBoolean35.SetName("LiteralBoolean35");
						MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow34_LiteralBoolean35.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow34_LiteralBoolean35.SetValue(true);
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow34.SetGuard(MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow34_LiteralBoolean35);
				MultipleDelegation_SameConnector_P_P_Operation_main.AddEdge(MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow34);
					// ObjectFlow ObjectFlow37 from result to target
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow37.SetName("ObjectFlow37");
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow37.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow37.SetSource(MultipleDelegation_SameConnector_P_P_Operation_main_Create_C_result);
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow37.SetTarget(MultipleDelegation_SameConnector_P_P_Operation_main_C__target);
						// LiteralBoolean LiteralBoolean38
						MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow37_LiteralBoolean38.SetName("LiteralBoolean38");
						MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow37_LiteralBoolean38.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow37_LiteralBoolean38.SetValue(true);
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow37.SetGuard(MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow37_LiteralBoolean38);
				MultipleDelegation_SameConnector_P_P_Operation_main.AddEdge(MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow37);
					// ObjectFlow ObjectFlow40 from result to v
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow40.SetName("ObjectFlow40");
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow40.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow40.SetSource(MultipleDelegation_SameConnector_P_P_Operation_main_Value_4_result);
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow40.SetTarget(MultipleDelegation_SameConnector_P_P_Operation_main_Call_p_setP__v);
						// LiteralBoolean LiteralBoolean41
						MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow40_LiteralBoolean41.SetName("LiteralBoolean41");
						MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow40_LiteralBoolean41.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow40_LiteralBoolean41.SetValue(true);
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow40.SetGuard(MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow40_LiteralBoolean41);
				MultipleDelegation_SameConnector_P_P_Operation_main.AddEdge(MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow40);
					// ObjectFlow ObjectFlow43 from Fork C to object
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow43.SetName("ObjectFlow43");
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow43.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow43.SetSource(MultipleDelegation_SameConnector_P_P_Operation_main_Fork_C);
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow43.SetTarget(MultipleDelegation_SameConnector_P_P_Operation_main_Read_c_b__object);
						// LiteralBoolean LiteralBoolean45
						MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow43_LiteralBoolean45.SetName("LiteralBoolean45");
						MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow43_LiteralBoolean45.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow43_LiteralBoolean45.SetValue(true);
					MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow43.SetGuard(MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow43_LiteralBoolean45);
				MultipleDelegation_SameConnector_P_P_Operation_main.AddEdge(MultipleDelegation_SameConnector_P_P_Operation_main_ObjectFlow43);
			MultipleDelegation_SameConnector_P_P_Operation.AddPackagedElement(MultipleDelegation_SameConnector_P_P_Operation_main);
				// Class C
				MultipleDelegation_SameConnector_P_P_Operation_C.SetName("C");
				MultipleDelegation_SameConnector_P_P_Operation_C.SetVisibility(VisibilityKind.public_);
				
					// Port q
					MultipleDelegation_SameConnector_P_P_Operation_C_q.SetName("q");
					MultipleDelegation_SameConnector_P_P_Operation_C_q.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_P_Operation_C_q.SetType(MultipleDelegation_SameConnector_P_P_Operation_IImpl);
					MultipleDelegation_SameConnector_P_P_Operation_C_q.SetAggregation(AggregationKind.composite);
					MultipleDelegation_SameConnector_P_P_Operation_C_q.isService = true;
					MultipleDelegation_SameConnector_P_P_Operation_C_q.AddProvided(MultipleDelegation_SameConnector_P_P_Operation_I);
				MultipleDelegation_SameConnector_P_P_Operation_C.AddOwnedAttribute(MultipleDelegation_SameConnector_P_P_Operation_C_q);
					// Property b
					MultipleDelegation_SameConnector_P_P_Operation_C_b.SetName("b");
					MultipleDelegation_SameConnector_P_P_Operation_C_b.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_P_Operation_C_b.SetUpper(4);
					MultipleDelegation_SameConnector_P_P_Operation_C_b.SetLower(4);
					MultipleDelegation_SameConnector_P_P_Operation_C_b.SetType(MultipleDelegation_SameConnector_P_P_Operation_B);
					MultipleDelegation_SameConnector_P_P_Operation_C_b.SetAggregation(AggregationKind.composite);
				MultipleDelegation_SameConnector_P_P_Operation_C.AddOwnedAttribute(MultipleDelegation_SameConnector_P_P_Operation_C_b);
				
				MultipleDelegation_SameConnector_P_P_Operation_C_r.SetName("r");
					MultipleDelegation_SameConnector_P_P_Operation_C_r.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Operation_C_r_ConnectorEnd55.SetUpper(-1);
						MultipleDelegation_SameConnector_P_P_Operation_C_r_ConnectorEnd55.SetRole(MultipleDelegation_SameConnector_P_P_Operation_C_q);
						
					MultipleDelegation_SameConnector_P_P_Operation_C_r.AddEnd(MultipleDelegation_SameConnector_P_P_Operation_C_r_ConnectorEnd55);
						MultipleDelegation_SameConnector_P_P_Operation_C_r_ConnectorEnd58.SetUpper(-1);
						MultipleDelegation_SameConnector_P_P_Operation_C_r_ConnectorEnd58.SetLower(4);
						MultipleDelegation_SameConnector_P_P_Operation_C_r_ConnectorEnd58.SetRole(MultipleDelegation_SameConnector_P_P_Operation_C_b);
						
					MultipleDelegation_SameConnector_P_P_Operation_C_r.AddEnd(MultipleDelegation_SameConnector_P_P_Operation_C_r_ConnectorEnd58);
					MultipleDelegation_SameConnector_P_P_Operation_C_r.SetType(MultipleDelegation_SameConnector_P_P_Operation_R);
				MultipleDelegation_SameConnector_P_P_Operation_C.AddOwnedConnector(MultipleDelegation_SameConnector_P_P_Operation_C_r);
					// Operation C_C
					MultipleDelegation_SameConnector_P_P_Operation_C_C_C.SetName("C_C");
					MultipleDelegation_SameConnector_P_P_Operation_C_C_C.SetVisibility(VisibilityKind.public_);
						// Parameter result
						MultipleDelegation_SameConnector_P_P_Operation_C_C_C_result.SetName("result");
						MultipleDelegation_SameConnector_P_P_Operation_C_C_C_result.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Operation_C_C_C_result.SetType(MultipleDelegation_SameConnector_P_P_Operation_C);
						MultipleDelegation_SameConnector_P_P_Operation_C_C_C_result.SetDirection(ParameterDirectionKind.return_);
					MultipleDelegation_SameConnector_P_P_Operation_C_C_C.AddOwnedParameter(MultipleDelegation_SameConnector_P_P_Operation_C_C_C_result);
					MultipleDelegation_SameConnector_P_P_Operation_C_C_C.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				MultipleDelegation_SameConnector_P_P_Operation_C.AddOwnedOperation(MultipleDelegation_SameConnector_P_P_Operation_C_C_C);
			MultipleDelegation_SameConnector_P_P_Operation.AddPackagedElement(MultipleDelegation_SameConnector_P_P_Operation_C);
				// Interface I
				MultipleDelegation_SameConnector_P_P_Operation_I.SetName("I");
				MultipleDelegation_SameConnector_P_P_Operation_I.SetVisibility(VisibilityKind.public_);
					// Operation setP_Integer
					MultipleDelegation_SameConnector_P_P_Operation_I_setP_Integer.SetName("setP_Integer");
					MultipleDelegation_SameConnector_P_P_Operation_I_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						MultipleDelegation_SameConnector_P_P_Operation_I_setP_Integer_v.SetName("v");
						MultipleDelegation_SameConnector_P_P_Operation_I_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Operation_I_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_SameConnector_P_P_Operation_I_setP_Integer.AddOwnedParameter(MultipleDelegation_SameConnector_P_P_Operation_I_setP_Integer_v);
				MultipleDelegation_SameConnector_P_P_Operation_I.AddOwnedOperation(MultipleDelegation_SameConnector_P_P_Operation_I_setP_Integer);
			MultipleDelegation_SameConnector_P_P_Operation.AddPackagedElement(MultipleDelegation_SameConnector_P_P_Operation_I);
				// Association R
				MultipleDelegation_SameConnector_P_P_Operation_R.SetName("R");
				MultipleDelegation_SameConnector_P_P_Operation_R.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_SameConnector_P_P_Operation_R.AddOwnedEnd(MultipleDelegation_SameConnector_P_P_Operation_R_x);
				MultipleDelegation_SameConnector_P_P_Operation_R.AddOwnedEnd(MultipleDelegation_SameConnector_P_P_Operation_R_y);
			MultipleDelegation_SameConnector_P_P_Operation.AddPackagedElement(MultipleDelegation_SameConnector_P_P_Operation_R);
				// Class B
				MultipleDelegation_SameConnector_P_P_Operation_B.SetName("B");
				MultipleDelegation_SameConnector_P_P_Operation_B.SetVisibility(VisibilityKind.public_);
				
					// Property p
					MultipleDelegation_SameConnector_P_P_Operation_B_p.SetName("p");
					MultipleDelegation_SameConnector_P_P_Operation_B_p.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_SameConnector_P_P_Operation_B_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						// LiteralInteger LiteralInteger63
						MultipleDelegation_SameConnector_P_P_Operation_B_p_LiteralInteger63.SetName("LiteralInteger63");
						MultipleDelegation_SameConnector_P_P_Operation_B_p_LiteralInteger63.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Operation_B_p_LiteralInteger63.SetValue(0);
					MultipleDelegation_SameConnector_P_P_Operation_B_p.SetDefaultValue(MultipleDelegation_SameConnector_P_P_Operation_B_p_LiteralInteger63);
				MultipleDelegation_SameConnector_P_P_Operation_B.AddOwnedAttribute(MultipleDelegation_SameConnector_P_P_Operation_B_p);
				// Activity setPActivity
					MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity.SetName("setPActivity");
					MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity.SetVisibility(VisibilityKind.public_);
					
						// Parameter v
						MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_v.SetName("v");
						MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_v.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity.AddOwnedParameter(MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_v);
						// AddStructuralFeatureValueAction Set this.p
						MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p.SetName("Set this.p");
						MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p.SetStructuralFeature(MultipleDelegation_SameConnector_P_P_Operation_B_p);
							// InputPin object
							MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p_object.SetName("object");
							MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p_object.SetType(MultipleDelegation_SameConnector_P_P_Operation_B);
						MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p.SetObject(MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p_object);
							// InputPin value
							MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p_value.SetName("value");
							MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p_value.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p.SetValue(MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p_value);
							// OutputPin result
							MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p_result.SetName("result");
							MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p_result.SetType(MultipleDelegation_SameConnector_P_P_Operation_B);
						MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p.SetResult(MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p_result);
					MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity.AddNode(MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p);
						// ActivityParameterNode vParameterNode
						MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_vParameterNode.SetName("vParameterNode");
						MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_vParameterNode.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_vParameterNode.SetParameter(MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_v);
					MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity.AddNode(MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_vParameterNode);
						// ReadSelfAction this
						MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_this.SetName("this");
						MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_this_result.SetName("result");
							MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_this_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_this_result.SetType(MultipleDelegation_SameConnector_P_P_Operation_B);
						MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_this.SetResult(MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_this_result);
					MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity.AddNode(MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_this);
						// ObjectFlow ObjectFlow71 from result to object
						MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_ObjectFlow71.SetName("ObjectFlow71");
						MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_ObjectFlow71.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_ObjectFlow71.SetSource(MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_this_result);
						MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_ObjectFlow71.SetTarget(MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p_object);
							// LiteralBoolean LiteralBoolean72
							MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_ObjectFlow71_LiteralBoolean72.SetName("LiteralBoolean72");
							MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_ObjectFlow71_LiteralBoolean72.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_ObjectFlow71_LiteralBoolean72.SetValue(true);
						MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_ObjectFlow71.SetGuard(MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_ObjectFlow71_LiteralBoolean72);
					MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity.AddEdge(MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_ObjectFlow71);
						// ObjectFlow ObjectFlow74 from vParameterNode to value
						MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_ObjectFlow74.SetName("ObjectFlow74");
						MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_ObjectFlow74.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_ObjectFlow74.SetSource(MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_vParameterNode);
						MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_ObjectFlow74.SetTarget(MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_Set_this_p_value);
							// LiteralBoolean LiteralBoolean76
							MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_ObjectFlow74_LiteralBoolean76.SetName("LiteralBoolean76");
							MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_ObjectFlow74_LiteralBoolean76.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_ObjectFlow74_LiteralBoolean76.SetValue(true);
						MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_ObjectFlow74.SetGuard(MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_ObjectFlow74_LiteralBoolean76);
					MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity.AddEdge(MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity_ObjectFlow74);
				MultipleDelegation_SameConnector_P_P_Operation_B.AddOwnedBehavior(MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity);
					MultipleDelegation_SameConnector_P_P_Operation_B_IRealization.SetName("IRealization");
					MultipleDelegation_SameConnector_P_P_Operation_B_IRealization.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_P_Operation_B_IRealization.SetContract(MultipleDelegation_SameConnector_P_P_Operation_I);
					
				MultipleDelegation_SameConnector_P_P_Operation_B.AddInterfaceRealization(MultipleDelegation_SameConnector_P_P_Operation_B_IRealization);
				
					// Operation B_B
					MultipleDelegation_SameConnector_P_P_Operation_B_B_B.SetName("B_B");
					MultipleDelegation_SameConnector_P_P_Operation_B_B_B.SetVisibility(VisibilityKind.public_);
						// Parameter result
						MultipleDelegation_SameConnector_P_P_Operation_B_B_B_result.SetName("result");
						MultipleDelegation_SameConnector_P_P_Operation_B_B_B_result.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Operation_B_B_B_result.SetType(MultipleDelegation_SameConnector_P_P_Operation_B);
						MultipleDelegation_SameConnector_P_P_Operation_B_B_B_result.SetDirection(ParameterDirectionKind.return_);
					MultipleDelegation_SameConnector_P_P_Operation_B_B_B.AddOwnedParameter(MultipleDelegation_SameConnector_P_P_Operation_B_B_B_result);
				MultipleDelegation_SameConnector_P_P_Operation_B.AddOwnedOperation(MultipleDelegation_SameConnector_P_P_Operation_B_B_B);
					// Operation setP_Integer
					MultipleDelegation_SameConnector_P_P_Operation_B_setP_Integer.SetName("setP_Integer");
					MultipleDelegation_SameConnector_P_P_Operation_B_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						MultipleDelegation_SameConnector_P_P_Operation_B_setP_Integer_v.SetName("v");
						MultipleDelegation_SameConnector_P_P_Operation_B_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Operation_B_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_SameConnector_P_P_Operation_B_setP_Integer.AddOwnedParameter(MultipleDelegation_SameConnector_P_P_Operation_B_setP_Integer_v);
					MultipleDelegation_SameConnector_P_P_Operation_B_setP_Integer.AddMethod(MultipleDelegation_SameConnector_P_P_Operation_B_setPActivity);
				MultipleDelegation_SameConnector_P_P_Operation_B.AddOwnedOperation(MultipleDelegation_SameConnector_P_P_Operation_B_setP_Integer);
			MultipleDelegation_SameConnector_P_P_Operation.AddPackagedElement(MultipleDelegation_SameConnector_P_P_Operation_B);
				// Class IImpl
				MultipleDelegation_SameConnector_P_P_Operation_IImpl.SetName("IImpl");
				MultipleDelegation_SameConnector_P_P_Operation_IImpl.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_SameConnector_P_P_Operation_IImpl_IRealization.SetName("IRealization");
					MultipleDelegation_SameConnector_P_P_Operation_IImpl_IRealization.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_SameConnector_P_P_Operation_IImpl_IRealization.SetContract(MultipleDelegation_SameConnector_P_P_Operation_I);
					
				MultipleDelegation_SameConnector_P_P_Operation_IImpl.AddInterfaceRealization(MultipleDelegation_SameConnector_P_P_Operation_IImpl_IRealization);
				
					// Operation setP_Integer
					MultipleDelegation_SameConnector_P_P_Operation_IImpl_setP_Integer.SetName("setP_Integer");
					MultipleDelegation_SameConnector_P_P_Operation_IImpl_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						MultipleDelegation_SameConnector_P_P_Operation_IImpl_setP_Integer_v.SetName("v");
						MultipleDelegation_SameConnector_P_P_Operation_IImpl_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_SameConnector_P_P_Operation_IImpl_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_SameConnector_P_P_Operation_IImpl_setP_Integer.AddOwnedParameter(MultipleDelegation_SameConnector_P_P_Operation_IImpl_setP_Integer_v);
				MultipleDelegation_SameConnector_P_P_Operation_IImpl.AddOwnedOperation(MultipleDelegation_SameConnector_P_P_Operation_IImpl_setP_Integer);
			MultipleDelegation_SameConnector_P_P_Operation.AddPackagedElement(MultipleDelegation_SameConnector_P_P_Operation_IImpl);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // MultipleDelegation_SameConnector_P_P_OperationModel
}
