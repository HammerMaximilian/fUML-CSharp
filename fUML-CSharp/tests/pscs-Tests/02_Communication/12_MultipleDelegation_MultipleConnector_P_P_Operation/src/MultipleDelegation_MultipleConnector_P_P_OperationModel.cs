/*
 * MultipleDelegation_MultipleConnector_P_P_OperationModel.cs
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

namespace MultipleDelegation_MultipleConnector_P_P_Operation
{
	public class MultipleDelegation_MultipleConnector_P_P_OperationModel : InMemoryModel
	{
		private static MultipleDelegation_MultipleConnector_P_P_OperationModel? instance;

		/*
		 * Model MultipleDelegation_MultipleConnector_P_P_Operation
		 */
		public Package MultipleDelegation_MultipleConnector_P_P_Operation = new();
			public Class_ MultipleDelegation_MultipleConnector_P_P_Operation_C = new();
				public Port MultipleDelegation_MultipleConnector_P_P_Operation_C_p = new();
				public Property MultipleDelegation_MultipleConnector_P_P_Operation_C_b2 = new();
					public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Operation_C_b2_LiteralUnlimitedNatural0 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_C_b2_LiteralInteger1 = new();
				public Property MultipleDelegation_MultipleConnector_P_P_Operation_C_b4 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_C_b4_LiteralInteger2 = new();
					public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Operation_C_b4_LiteralUnlimitedNatural3 = new();
				public Connector MultipleDelegation_MultipleConnector_P_P_Operation_C_s2 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_P_Operation_C_s2_ConnectorEnd4 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_P_Operation_C_s2_ConnectorEnd5 = new();
				public Property MultipleDelegation_MultipleConnector_P_P_Operation_C_b3 = new();
					public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Operation_C_b3_LiteralUnlimitedNatural6 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_C_b3_LiteralInteger7 = new();
				public Connector MultipleDelegation_MultipleConnector_P_P_Operation_C_s3 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_P_Operation_C_s3_ConnectorEnd8 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_P_Operation_C_s3_ConnectorEnd9 = new();
				public Connector MultipleDelegation_MultipleConnector_P_P_Operation_C_s4 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_P_Operation_C_s4_ConnectorEnd10 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_P_Operation_C_s4_ConnectorEnd11 = new();
				public Property MultipleDelegation_MultipleConnector_P_P_Operation_C_b1 = new();
					public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Operation_C_b1_LiteralUnlimitedNatural12 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_C_b1_LiteralInteger13 = new();
				public Operation MultipleDelegation_MultipleConnector_P_P_Operation_C_C_C = new();
					public Parameter MultipleDelegation_MultipleConnector_P_P_Operation_C_C_C_result = new();
				public Connector MultipleDelegation_MultipleConnector_P_P_Operation_C_s1 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_P_Operation_C_s1_ConnectorEnd14 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Operation_C_s1_ConnectorEnd14_LiteralUnlimitedNatural15 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_C_s1_ConnectorEnd14_LiteralInteger16 = new();
					public ConnectorEnd MultipleDelegation_MultipleConnector_P_P_Operation_C_s1_ConnectorEnd17 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_C_s1_ConnectorEnd17_LiteralInteger18 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Operation_C_s1_ConnectorEnd17_LiteralUnlimitedNatural19 = new();
			public Interface MultipleDelegation_MultipleConnector_P_P_Operation_I = new();
				public Operation MultipleDelegation_MultipleConnector_P_P_Operation_I_setP_Integer = new();
					public Parameter MultipleDelegation_MultipleConnector_P_P_Operation_I_setP_Integer_v = new();
			public Association MultipleDelegation_MultipleConnector_P_P_Operation_S = new();
				public Property MultipleDelegation_MultipleConnector_P_P_Operation_S_x = new();
				public Property MultipleDelegation_MultipleConnector_P_P_Operation_S_y = new();
			public Class_ MultipleDelegation_MultipleConnector_P_P_Operation_B = new();
				public Property MultipleDelegation_MultipleConnector_P_P_Operation_B_p = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_B_p_LiteralInteger20 = new();
				public InterfaceRealization MultipleDelegation_MultipleConnector_P_P_Operation_B_IRealization = new();
				public Operation MultipleDelegation_MultipleConnector_P_P_Operation_B_B_B = new();
					public Parameter MultipleDelegation_MultipleConnector_P_P_Operation_B_B_B_result = new();
				public Operation MultipleDelegation_MultipleConnector_P_P_Operation_B_setP_Integer = new();
					public Parameter MultipleDelegation_MultipleConnector_P_P_Operation_B_setP_Integer_v = new();
				public Activity MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity = new();
					public Parameter MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_v = new();
					public AddStructuralFeatureValueAction MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p_result = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p_result_LiteralInteger21 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p_result_LiteralUnlimitedNatural22 = new();
						public InputPin MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p_value = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p_value_LiteralInteger23 = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p_value_LiteralUnlimitedNatural24 = new();
						public InputPin MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p_object = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p_object_LiteralUnlimitedNatural25 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p_object_LiteralInteger26 = new();
					public ActivityParameterNode MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_vParameterNode = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_vParameterNode_LiteralInteger27 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_ObjectFlow28 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_ObjectFlow28_LiteralBoolean29 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_ObjectFlow28_LiteralInteger30 = new();
					public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_ObjectFlow31 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_ObjectFlow31_LiteralInteger32 = new();
						public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_ObjectFlow31_LiteralBoolean33 = new();
					public ReadSelfAction MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_this = new();
						public OutputPin MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_this_result = new();
							public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_this_result_LiteralUnlimitedNatural34 = new();
							public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_this_result_LiteralInteger35 = new();
			public Class_ MultipleDelegation_MultipleConnector_P_P_Operation_IImpl = new();
				public Operation MultipleDelegation_MultipleConnector_P_P_Operation_IImpl_setP_Integer = new();
					public Parameter MultipleDelegation_MultipleConnector_P_P_Operation_IImpl_setP_Integer_v = new();
				public InterfaceRealization MultipleDelegation_MultipleConnector_P_P_Operation_IImpl_IRealization = new();
			public Activity MultipleDelegation_MultipleConnector_P_P_Operation_main = new();
				public ControlFlow MultipleDelegation_MultipleConnector_P_P_Operation_main_ControlFlow36 = new();
				public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_p = new();
					public OutputPin MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_p_result = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_p_result_LiteralInteger37 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_p_result_LiteralUnlimitedNatural38 = new();
					public InputPin MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_p_object = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_p_object_LiteralUnlimitedNatural39 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_p_object_LiteralInteger40 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow41 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow41_LiteralInteger42 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow41_LiteralBoolean43 = new();
				public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b1 = new();
					public InputPin MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b1_object = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b1_object_LiteralInteger44 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b1_object_LiteralUnlimitedNatural45 = new();
					public OutputPin MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b1_result = new();
				public ForkNode MultipleDelegation_MultipleConnector_P_P_Operation_main_Fork_C = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow46 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow46_LiteralInteger47 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow46_LiteralBoolean48 = new();
				public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p = new();
					public InputPin MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p_object = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p_object_LiteralInteger49 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p_object_LiteralUnlimitedNatural50 = new();
					public OutputPin MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p_result = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p_result_LiteralUnlimitedNatural51 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p_result_LiteralInteger52 = new();
				public ControlFlow MultipleDelegation_MultipleConnector_P_P_Operation_main_ControlFlow53 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow54 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow54_LiteralInteger55 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow54_LiteralBoolean56 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow57 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow57_LiteralBoolean58 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow57_LiteralInteger59 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow60 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow60_LiteralBoolean61 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow60_LiteralInteger62 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow63 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow63_LiteralInteger64 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow63_LiteralBoolean65 = new();
				public CallOperationAction MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP_ = new();
					public InputPin MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP__target = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP__target_LiteralUnlimitedNatural66 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP__target_LiteralInteger67 = new();
					public InputPin MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP__v = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP__v_LiteralUnlimitedNatural68 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP__v_LiteralInteger69 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP__v_LiteralInteger70 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow71 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow71_LiteralInteger72 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow71_LiteralBoolean73 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow74 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow74_LiteralInteger75 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow74_LiteralBoolean76 = new();
				public ControlFlow MultipleDelegation_MultipleConnector_P_P_Operation_main_ControlFlow77 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow78 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow78_LiteralInteger79 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow78_LiteralBoolean80 = new();
				public CallOperationAction MultipleDelegation_MultipleConnector_P_P_Operation_main_C_ = new();
					public InputPin MultipleDelegation_MultipleConnector_P_P_Operation_main_C__target = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_C__target_LiteralInteger81 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Operation_main_C__target_LiteralUnlimitedNatural82 = new();
					public OutputPin MultipleDelegation_MultipleConnector_P_P_Operation_main_C__result = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_C__result_LiteralInteger83 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_C__result_LiteralInteger84 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Operation_main_C__result_LiteralUnlimitedNatural85 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow86 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow86_LiteralInteger87 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow86_LiteralBoolean88 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow89 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow89_LiteralInteger90 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow89_LiteralBoolean91 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow92 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow92_LiteralBoolean93 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow92_LiteralInteger94 = new();
				public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b4 = new();
					public OutputPin MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b4_result = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b4_result_LiteralInteger95 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b4_result_LiteralUnlimitedNatural96 = new();
					public InputPin MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b4_object = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b4_object_LiteralInteger97 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b4_object_LiteralUnlimitedNatural98 = new();
				public CallBehaviorAction MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_testP = new();
					public InputPin MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_testP_p = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_testP_p_LiteralInteger99 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_testP_p_LiteralInteger100 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_testP_p_LiteralUnlimitedNatural101 = new();
				public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b3 = new();
					public OutputPin MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b3_result = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b3_result_LiteralUnlimitedNatural102 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b3_result_LiteralInteger103 = new();
					public InputPin MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b3_object = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b3_object_LiteralInteger104 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b3_object_LiteralUnlimitedNatural105 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow106 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow106_LiteralInteger107 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow106_LiteralBoolean108 = new();
				public ValueSpecificationAction MultipleDelegation_MultipleConnector_P_P_Operation_main_Value_4 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_Value_4_LiteralInteger109 = new();
					public OutputPin MultipleDelegation_MultipleConnector_P_P_Operation_main_Value_4_result = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Operation_main_Value_4_result_LiteralUnlimitedNatural110 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_Value_4_result_LiteralInteger111 = new();
				public ObjectFlow MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow112 = new();
					public LiteralBoolean MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow112_LiteralBoolean113 = new();
					public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow112_LiteralInteger114 = new();
				public ReadStructuralFeatureAction MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b2 = new();
					public OutputPin MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b2_result = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b2_result_LiteralUnlimitedNatural115 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b2_result_LiteralInteger116 = new();
					public InputPin MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b2_object = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b2_object_LiteralInteger117 = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b2_object_LiteralUnlimitedNatural118 = new();
				public OpaqueBehavior MultipleDelegation_MultipleConnector_P_P_Operation_main_testP = new();
					public Parameter MultipleDelegation_MultipleConnector_P_P_Operation_main_testP_p = new();
				public ControlFlow MultipleDelegation_MultipleConnector_P_P_Operation_main_ControlFlow119 = new();
				public CreateObjectAction MultipleDelegation_MultipleConnector_P_P_Operation_main_Create_C = new();
					public OutputPin MultipleDelegation_MultipleConnector_P_P_Operation_main_Create_C_result = new();
						public LiteralUnlimitedNatural MultipleDelegation_MultipleConnector_P_P_Operation_main_Create_C_result_LiteralUnlimitedNatural120 = new();
						public LiteralInteger MultipleDelegation_MultipleConnector_P_P_Operation_main_Create_C_result_LiteralInteger121 = new();

		public static MultipleDelegation_MultipleConnector_P_P_OperationModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public MultipleDelegation_MultipleConnector_P_P_OperationModel()
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
			 * Model MultipleDelegation_MultipleConnector_P_P_Operation
			 */
			AddToElementRepository("MultipleDelegation_MultipleConnector_P_P_Operation", MultipleDelegation_MultipleConnector_P_P_Operation);
				AddToElementRepository("C", MultipleDelegation_MultipleConnector_P_P_Operation_C);
					AddToElementRepository("p", MultipleDelegation_MultipleConnector_P_P_Operation_C_p);
					AddToElementRepository("b2", MultipleDelegation_MultipleConnector_P_P_Operation_C_b2);
						AddToElementRepository("LiteralUnlimitedNatural0", MultipleDelegation_MultipleConnector_P_P_Operation_C_b2_LiteralUnlimitedNatural0);
						AddToElementRepository("LiteralInteger1", MultipleDelegation_MultipleConnector_P_P_Operation_C_b2_LiteralInteger1);
					AddToElementRepository("b4", MultipleDelegation_MultipleConnector_P_P_Operation_C_b4);
						AddToElementRepository("LiteralInteger2", MultipleDelegation_MultipleConnector_P_P_Operation_C_b4_LiteralInteger2);
						AddToElementRepository("LiteralUnlimitedNatural3", MultipleDelegation_MultipleConnector_P_P_Operation_C_b4_LiteralUnlimitedNatural3);
					AddToElementRepository("s2", MultipleDelegation_MultipleConnector_P_P_Operation_C_s2);
						AddToElementRepository("ConnectorEnd4", MultipleDelegation_MultipleConnector_P_P_Operation_C_s2_ConnectorEnd4);
						AddToElementRepository("ConnectorEnd5", MultipleDelegation_MultipleConnector_P_P_Operation_C_s2_ConnectorEnd5);
					AddToElementRepository("b3", MultipleDelegation_MultipleConnector_P_P_Operation_C_b3);
						AddToElementRepository("LiteralUnlimitedNatural6", MultipleDelegation_MultipleConnector_P_P_Operation_C_b3_LiteralUnlimitedNatural6);
						AddToElementRepository("LiteralInteger7", MultipleDelegation_MultipleConnector_P_P_Operation_C_b3_LiteralInteger7);
					AddToElementRepository("s3", MultipleDelegation_MultipleConnector_P_P_Operation_C_s3);
						AddToElementRepository("ConnectorEnd8", MultipleDelegation_MultipleConnector_P_P_Operation_C_s3_ConnectorEnd8);
						AddToElementRepository("ConnectorEnd9", MultipleDelegation_MultipleConnector_P_P_Operation_C_s3_ConnectorEnd9);
					AddToElementRepository("s4", MultipleDelegation_MultipleConnector_P_P_Operation_C_s4);
						AddToElementRepository("ConnectorEnd10", MultipleDelegation_MultipleConnector_P_P_Operation_C_s4_ConnectorEnd10);
						AddToElementRepository("ConnectorEnd11", MultipleDelegation_MultipleConnector_P_P_Operation_C_s4_ConnectorEnd11);
					AddToElementRepository("b1", MultipleDelegation_MultipleConnector_P_P_Operation_C_b1);
						AddToElementRepository("LiteralUnlimitedNatural12", MultipleDelegation_MultipleConnector_P_P_Operation_C_b1_LiteralUnlimitedNatural12);
						AddToElementRepository("LiteralInteger13", MultipleDelegation_MultipleConnector_P_P_Operation_C_b1_LiteralInteger13);
					AddToElementRepository("C_C", MultipleDelegation_MultipleConnector_P_P_Operation_C_C_C);
						AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Operation_C_C_C_result);
					AddToElementRepository("s1", MultipleDelegation_MultipleConnector_P_P_Operation_C_s1);
						AddToElementRepository("ConnectorEnd14", MultipleDelegation_MultipleConnector_P_P_Operation_C_s1_ConnectorEnd14);
							AddToElementRepository("LiteralUnlimitedNatural15", MultipleDelegation_MultipleConnector_P_P_Operation_C_s1_ConnectorEnd14_LiteralUnlimitedNatural15);
							AddToElementRepository("LiteralInteger16", MultipleDelegation_MultipleConnector_P_P_Operation_C_s1_ConnectorEnd14_LiteralInteger16);
						AddToElementRepository("ConnectorEnd17", MultipleDelegation_MultipleConnector_P_P_Operation_C_s1_ConnectorEnd17);
							AddToElementRepository("LiteralInteger18", MultipleDelegation_MultipleConnector_P_P_Operation_C_s1_ConnectorEnd17_LiteralInteger18);
							AddToElementRepository("LiteralUnlimitedNatural19", MultipleDelegation_MultipleConnector_P_P_Operation_C_s1_ConnectorEnd17_LiteralUnlimitedNatural19);
				AddToElementRepository("I", MultipleDelegation_MultipleConnector_P_P_Operation_I);
					AddToElementRepository("setP_Integer", MultipleDelegation_MultipleConnector_P_P_Operation_I_setP_Integer);
						AddToElementRepository("v", MultipleDelegation_MultipleConnector_P_P_Operation_I_setP_Integer_v);
				AddToElementRepository("S", MultipleDelegation_MultipleConnector_P_P_Operation_S);
					AddToElementRepository("x", MultipleDelegation_MultipleConnector_P_P_Operation_S_x);
					AddToElementRepository("y", MultipleDelegation_MultipleConnector_P_P_Operation_S_y);
				AddToElementRepository("B", MultipleDelegation_MultipleConnector_P_P_Operation_B);
					AddToElementRepository("p", MultipleDelegation_MultipleConnector_P_P_Operation_B_p);
						AddToElementRepository("LiteralInteger20", MultipleDelegation_MultipleConnector_P_P_Operation_B_p_LiteralInteger20);
					AddToElementRepository("IRealization", MultipleDelegation_MultipleConnector_P_P_Operation_B_IRealization);
					AddToElementRepository("B_B", MultipleDelegation_MultipleConnector_P_P_Operation_B_B_B);
						AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Operation_B_B_B_result);
					AddToElementRepository("setP_Integer", MultipleDelegation_MultipleConnector_P_P_Operation_B_setP_Integer);
						AddToElementRepository("v", MultipleDelegation_MultipleConnector_P_P_Operation_B_setP_Integer_v);
					AddToElementRepository("setPActivity", MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity);
						AddToElementRepository("v", MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_v);
						AddToElementRepository("Set this.p", MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p_result);
								AddToElementRepository("LiteralInteger21", MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p_result_LiteralInteger21);
								AddToElementRepository("LiteralUnlimitedNatural22", MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p_result_LiteralUnlimitedNatural22);
							AddToElementRepository("value", MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p_value);
								AddToElementRepository("LiteralInteger23", MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p_value_LiteralInteger23);
								AddToElementRepository("LiteralUnlimitedNatural24", MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p_value_LiteralUnlimitedNatural24);
							AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p_object);
								AddToElementRepository("LiteralUnlimitedNatural25", MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p_object_LiteralUnlimitedNatural25);
								AddToElementRepository("LiteralInteger26", MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p_object_LiteralInteger26);
						AddToElementRepository("vParameterNode", MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_vParameterNode);
							AddToElementRepository("LiteralInteger27", MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_vParameterNode_LiteralInteger27);
						AddToElementRepository("ObjectFlow28", MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_ObjectFlow28);
							AddToElementRepository("LiteralBoolean29", MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_ObjectFlow28_LiteralBoolean29);
							AddToElementRepository("LiteralInteger30", MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_ObjectFlow28_LiteralInteger30);
						AddToElementRepository("ObjectFlow31", MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_ObjectFlow31);
							AddToElementRepository("LiteralInteger32", MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_ObjectFlow31_LiteralInteger32);
							AddToElementRepository("LiteralBoolean33", MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_ObjectFlow31_LiteralBoolean33);
						AddToElementRepository("this", MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_this);
							AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_this_result);
								AddToElementRepository("LiteralUnlimitedNatural34", MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_this_result_LiteralUnlimitedNatural34);
								AddToElementRepository("LiteralInteger35", MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_this_result_LiteralInteger35);
				AddToElementRepository("IImpl", MultipleDelegation_MultipleConnector_P_P_Operation_IImpl);
					AddToElementRepository("setP_Integer", MultipleDelegation_MultipleConnector_P_P_Operation_IImpl_setP_Integer);
						AddToElementRepository("v", MultipleDelegation_MultipleConnector_P_P_Operation_IImpl_setP_Integer_v);
					AddToElementRepository("IRealization", MultipleDelegation_MultipleConnector_P_P_Operation_IImpl_IRealization);
				AddToElementRepository("main", MultipleDelegation_MultipleConnector_P_P_Operation_main);
					AddToElementRepository("ControlFlow36", MultipleDelegation_MultipleConnector_P_P_Operation_main_ControlFlow36);
					AddToElementRepository("Read c.p", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_p);
						AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_p_result);
							AddToElementRepository("LiteralInteger37", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_p_result_LiteralInteger37);
							AddToElementRepository("LiteralUnlimitedNatural38", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_p_result_LiteralUnlimitedNatural38);
						AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_p_object);
							AddToElementRepository("LiteralUnlimitedNatural39", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_p_object_LiteralUnlimitedNatural39);
							AddToElementRepository("LiteralInteger40", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_p_object_LiteralInteger40);
					AddToElementRepository("ObjectFlow41", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow41);
						AddToElementRepository("LiteralInteger42", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow41_LiteralInteger42);
						AddToElementRepository("LiteralBoolean43", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow41_LiteralBoolean43);
					AddToElementRepository("Read c.b1", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b1);
						AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b1_object);
							AddToElementRepository("LiteralInteger44", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b1_object_LiteralInteger44);
							AddToElementRepository("LiteralUnlimitedNatural45", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b1_object_LiteralUnlimitedNatural45);
						AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b1_result);
					AddToElementRepository("Fork C", MultipleDelegation_MultipleConnector_P_P_Operation_main_Fork_C);
					AddToElementRepository("ObjectFlow46", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow46);
						AddToElementRepository("LiteralInteger47", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow46_LiteralInteger47);
						AddToElementRepository("LiteralBoolean48", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow46_LiteralBoolean48);
					AddToElementRepository("Read b.p", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p);
						AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p_object);
							AddToElementRepository("LiteralInteger49", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p_object_LiteralInteger49);
							AddToElementRepository("LiteralUnlimitedNatural50", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p_object_LiteralUnlimitedNatural50);
						AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p_result);
							AddToElementRepository("LiteralUnlimitedNatural51", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p_result_LiteralUnlimitedNatural51);
							AddToElementRepository("LiteralInteger52", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p_result_LiteralInteger52);
					AddToElementRepository("ControlFlow53", MultipleDelegation_MultipleConnector_P_P_Operation_main_ControlFlow53);
					AddToElementRepository("ObjectFlow54", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow54);
						AddToElementRepository("LiteralInteger55", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow54_LiteralInteger55);
						AddToElementRepository("LiteralBoolean56", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow54_LiteralBoolean56);
					AddToElementRepository("ObjectFlow57", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow57);
						AddToElementRepository("LiteralBoolean58", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow57_LiteralBoolean58);
						AddToElementRepository("LiteralInteger59", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow57_LiteralInteger59);
					AddToElementRepository("ObjectFlow60", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow60);
						AddToElementRepository("LiteralBoolean61", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow60_LiteralBoolean61);
						AddToElementRepository("LiteralInteger62", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow60_LiteralInteger62);
					AddToElementRepository("ObjectFlow63", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow63);
						AddToElementRepository("LiteralInteger64", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow63_LiteralInteger64);
						AddToElementRepository("LiteralBoolean65", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow63_LiteralBoolean65);
					AddToElementRepository("Call p.setP()", MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP_);
						AddToElementRepository("target", MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP__target);
							AddToElementRepository("LiteralUnlimitedNatural66", MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP__target_LiteralUnlimitedNatural66);
							AddToElementRepository("LiteralInteger67", MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP__target_LiteralInteger67);
						AddToElementRepository("v", MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP__v);
							AddToElementRepository("LiteralUnlimitedNatural68", MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP__v_LiteralUnlimitedNatural68);
							AddToElementRepository("LiteralInteger69", MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP__v_LiteralInteger69);
							AddToElementRepository("LiteralInteger70", MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP__v_LiteralInteger70);
					AddToElementRepository("ObjectFlow71", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow71);
						AddToElementRepository("LiteralInteger72", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow71_LiteralInteger72);
						AddToElementRepository("LiteralBoolean73", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow71_LiteralBoolean73);
					AddToElementRepository("ObjectFlow74", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow74);
						AddToElementRepository("LiteralInteger75", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow74_LiteralInteger75);
						AddToElementRepository("LiteralBoolean76", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow74_LiteralBoolean76);
					AddToElementRepository("ControlFlow77", MultipleDelegation_MultipleConnector_P_P_Operation_main_ControlFlow77);
					AddToElementRepository("ObjectFlow78", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow78);
						AddToElementRepository("LiteralInteger79", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow78_LiteralInteger79);
						AddToElementRepository("LiteralBoolean80", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow78_LiteralBoolean80);
					AddToElementRepository("C()", MultipleDelegation_MultipleConnector_P_P_Operation_main_C_);
						AddToElementRepository("target", MultipleDelegation_MultipleConnector_P_P_Operation_main_C__target);
							AddToElementRepository("LiteralInteger81", MultipleDelegation_MultipleConnector_P_P_Operation_main_C__target_LiteralInteger81);
							AddToElementRepository("LiteralUnlimitedNatural82", MultipleDelegation_MultipleConnector_P_P_Operation_main_C__target_LiteralUnlimitedNatural82);
						AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Operation_main_C__result);
							AddToElementRepository("LiteralInteger83", MultipleDelegation_MultipleConnector_P_P_Operation_main_C__result_LiteralInteger83);
							AddToElementRepository("LiteralInteger84", MultipleDelegation_MultipleConnector_P_P_Operation_main_C__result_LiteralInteger84);
							AddToElementRepository("LiteralUnlimitedNatural85", MultipleDelegation_MultipleConnector_P_P_Operation_main_C__result_LiteralUnlimitedNatural85);
					AddToElementRepository("ObjectFlow86", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow86);
						AddToElementRepository("LiteralInteger87", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow86_LiteralInteger87);
						AddToElementRepository("LiteralBoolean88", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow86_LiteralBoolean88);
					AddToElementRepository("ObjectFlow89", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow89);
						AddToElementRepository("LiteralInteger90", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow89_LiteralInteger90);
						AddToElementRepository("LiteralBoolean91", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow89_LiteralBoolean91);
					AddToElementRepository("ObjectFlow92", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow92);
						AddToElementRepository("LiteralBoolean93", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow92_LiteralBoolean93);
						AddToElementRepository("LiteralInteger94", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow92_LiteralInteger94);
					AddToElementRepository("Read c.b4", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b4);
						AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b4_result);
							AddToElementRepository("LiteralInteger95", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b4_result_LiteralInteger95);
							AddToElementRepository("LiteralUnlimitedNatural96", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b4_result_LiteralUnlimitedNatural96);
						AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b4_object);
							AddToElementRepository("LiteralInteger97", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b4_object_LiteralInteger97);
							AddToElementRepository("LiteralUnlimitedNatural98", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b4_object_LiteralUnlimitedNatural98);
					AddToElementRepository("Call testP", MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_testP);
						AddToElementRepository("p", MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_testP_p);
							AddToElementRepository("LiteralInteger99", MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_testP_p_LiteralInteger99);
							AddToElementRepository("LiteralInteger100", MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_testP_p_LiteralInteger100);
							AddToElementRepository("LiteralUnlimitedNatural101", MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_testP_p_LiteralUnlimitedNatural101);
					AddToElementRepository("Read c.b3", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b3);
						AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b3_result);
							AddToElementRepository("LiteralUnlimitedNatural102", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b3_result_LiteralUnlimitedNatural102);
							AddToElementRepository("LiteralInteger103", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b3_result_LiteralInteger103);
						AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b3_object);
							AddToElementRepository("LiteralInteger104", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b3_object_LiteralInteger104);
							AddToElementRepository("LiteralUnlimitedNatural105", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b3_object_LiteralUnlimitedNatural105);
					AddToElementRepository("ObjectFlow106", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow106);
						AddToElementRepository("LiteralInteger107", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow106_LiteralInteger107);
						AddToElementRepository("LiteralBoolean108", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow106_LiteralBoolean108);
					AddToElementRepository("Value(4)", MultipleDelegation_MultipleConnector_P_P_Operation_main_Value_4);
						AddToElementRepository("LiteralInteger109", MultipleDelegation_MultipleConnector_P_P_Operation_main_Value_4_LiteralInteger109);
						AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Operation_main_Value_4_result);
							AddToElementRepository("LiteralUnlimitedNatural110", MultipleDelegation_MultipleConnector_P_P_Operation_main_Value_4_result_LiteralUnlimitedNatural110);
							AddToElementRepository("LiteralInteger111", MultipleDelegation_MultipleConnector_P_P_Operation_main_Value_4_result_LiteralInteger111);
					AddToElementRepository("ObjectFlow112", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow112);
						AddToElementRepository("LiteralBoolean113", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow112_LiteralBoolean113);
						AddToElementRepository("LiteralInteger114", MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow112_LiteralInteger114);
					AddToElementRepository("Read c.b2", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b2);
						AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b2_result);
							AddToElementRepository("LiteralUnlimitedNatural115", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b2_result_LiteralUnlimitedNatural115);
							AddToElementRepository("LiteralInteger116", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b2_result_LiteralInteger116);
						AddToElementRepository("object", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b2_object);
							AddToElementRepository("LiteralInteger117", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b2_object_LiteralInteger117);
							AddToElementRepository("LiteralUnlimitedNatural118", MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b2_object_LiteralUnlimitedNatural118);
					AddToElementRepository("testP", MultipleDelegation_MultipleConnector_P_P_Operation_main_testP);
						AddToElementRepository("p", MultipleDelegation_MultipleConnector_P_P_Operation_main_testP_p);
					AddToElementRepository("ControlFlow119", MultipleDelegation_MultipleConnector_P_P_Operation_main_ControlFlow119);
					AddToElementRepository("Create C", MultipleDelegation_MultipleConnector_P_P_Operation_main_Create_C);
						AddToElementRepository("result", MultipleDelegation_MultipleConnector_P_P_Operation_main_Create_C_result);
							AddToElementRepository("LiteralUnlimitedNatural120", MultipleDelegation_MultipleConnector_P_P_Operation_main_Create_C_result_LiteralUnlimitedNatural120);
							AddToElementRepository("LiteralInteger121", MultipleDelegation_MultipleConnector_P_P_Operation_main_Create_C_result_LiteralInteger121);

			// Initialize public members
			/*
			 * Model MultipleDelegation_MultipleConnector_P_P_Operation
			 */
			MultipleDelegation_MultipleConnector_P_P_Operation.SetName("MultipleDelegation_MultipleConnector_P_P_Operation");
			MultipleDelegation_MultipleConnector_P_P_Operation.SetVisibility(VisibilityKind.public_);
				// Class C
				MultipleDelegation_MultipleConnector_P_P_Operation_C.SetName("C");
				MultipleDelegation_MultipleConnector_P_P_Operation_C.SetVisibility(VisibilityKind.public_);
				
					// Port p
					MultipleDelegation_MultipleConnector_P_P_Operation_C_p.SetName("p");
					MultipleDelegation_MultipleConnector_P_P_Operation_C_p.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Operation_C_p.SetType(MultipleDelegation_MultipleConnector_P_P_Operation_IImpl);
					MultipleDelegation_MultipleConnector_P_P_Operation_C_p.SetAggregation(AggregationKind.composite);
					MultipleDelegation_MultipleConnector_P_P_Operation_C_p.isService = true;
					MultipleDelegation_MultipleConnector_P_P_Operation_C_p.AddProvided(MultipleDelegation_MultipleConnector_P_P_Operation_I);
				MultipleDelegation_MultipleConnector_P_P_Operation_C.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_P_Operation_C_p);
					// Property b1
					MultipleDelegation_MultipleConnector_P_P_Operation_C_b1.SetName("b1");
					MultipleDelegation_MultipleConnector_P_P_Operation_C_b1.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Operation_C_b1.SetType(MultipleDelegation_MultipleConnector_P_P_Operation_B);
					MultipleDelegation_MultipleConnector_P_P_Operation_C_b1.SetAggregation(AggregationKind.composite);
				MultipleDelegation_MultipleConnector_P_P_Operation_C.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_P_Operation_C_b1);
					// Property b2
					MultipleDelegation_MultipleConnector_P_P_Operation_C_b2.SetName("b2");
					MultipleDelegation_MultipleConnector_P_P_Operation_C_b2.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Operation_C_b2.SetType(MultipleDelegation_MultipleConnector_P_P_Operation_B);
					MultipleDelegation_MultipleConnector_P_P_Operation_C_b2.SetAggregation(AggregationKind.composite);
				MultipleDelegation_MultipleConnector_P_P_Operation_C.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_P_Operation_C_b2);
					// Property b3
					MultipleDelegation_MultipleConnector_P_P_Operation_C_b3.SetName("b3");
					MultipleDelegation_MultipleConnector_P_P_Operation_C_b3.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Operation_C_b3.SetType(MultipleDelegation_MultipleConnector_P_P_Operation_B);
					MultipleDelegation_MultipleConnector_P_P_Operation_C_b3.SetAggregation(AggregationKind.composite);
				MultipleDelegation_MultipleConnector_P_P_Operation_C.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_P_Operation_C_b3);
					// Property b4
					MultipleDelegation_MultipleConnector_P_P_Operation_C_b4.SetName("b4");
					MultipleDelegation_MultipleConnector_P_P_Operation_C_b4.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Operation_C_b4.SetType(MultipleDelegation_MultipleConnector_P_P_Operation_B);
					MultipleDelegation_MultipleConnector_P_P_Operation_C_b4.SetAggregation(AggregationKind.composite);
				MultipleDelegation_MultipleConnector_P_P_Operation_C.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_P_Operation_C_b4);
				
				MultipleDelegation_MultipleConnector_P_P_Operation_C_s2.SetName("s2");
					MultipleDelegation_MultipleConnector_P_P_Operation_C_s2.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Operation_C_s2_ConnectorEnd4.SetRole(MultipleDelegation_MultipleConnector_P_P_Operation_C_p);
						
					MultipleDelegation_MultipleConnector_P_P_Operation_C_s2.AddEnd(MultipleDelegation_MultipleConnector_P_P_Operation_C_s2_ConnectorEnd4);
						
						MultipleDelegation_MultipleConnector_P_P_Operation_C_s2_ConnectorEnd5.SetRole(MultipleDelegation_MultipleConnector_P_P_Operation_C_b2);
						
					MultipleDelegation_MultipleConnector_P_P_Operation_C_s2.AddEnd(MultipleDelegation_MultipleConnector_P_P_Operation_C_s2_ConnectorEnd5);
				MultipleDelegation_MultipleConnector_P_P_Operation_C.AddOwnedConnector(MultipleDelegation_MultipleConnector_P_P_Operation_C_s2);
					MultipleDelegation_MultipleConnector_P_P_Operation_C_s3.SetName("s3");
					MultipleDelegation_MultipleConnector_P_P_Operation_C_s3.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Operation_C_s3_ConnectorEnd9.SetRole(MultipleDelegation_MultipleConnector_P_P_Operation_C_p);
						
					MultipleDelegation_MultipleConnector_P_P_Operation_C_s3.AddEnd(MultipleDelegation_MultipleConnector_P_P_Operation_C_s3_ConnectorEnd9);
						
						MultipleDelegation_MultipleConnector_P_P_Operation_C_s3_ConnectorEnd8.SetRole(MultipleDelegation_MultipleConnector_P_P_Operation_C_b3);
						
					MultipleDelegation_MultipleConnector_P_P_Operation_C_s3.AddEnd(MultipleDelegation_MultipleConnector_P_P_Operation_C_s3_ConnectorEnd8);
				MultipleDelegation_MultipleConnector_P_P_Operation_C.AddOwnedConnector(MultipleDelegation_MultipleConnector_P_P_Operation_C_s3);
					MultipleDelegation_MultipleConnector_P_P_Operation_C_s4.SetName("s4");
					MultipleDelegation_MultipleConnector_P_P_Operation_C_s4.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Operation_C_s4_ConnectorEnd10.SetRole(MultipleDelegation_MultipleConnector_P_P_Operation_C_p);
						
					MultipleDelegation_MultipleConnector_P_P_Operation_C_s4.AddEnd(MultipleDelegation_MultipleConnector_P_P_Operation_C_s4_ConnectorEnd10);
						
						MultipleDelegation_MultipleConnector_P_P_Operation_C_s4_ConnectorEnd11.SetRole(MultipleDelegation_MultipleConnector_P_P_Operation_C_b4);
						
					MultipleDelegation_MultipleConnector_P_P_Operation_C_s4.AddEnd(MultipleDelegation_MultipleConnector_P_P_Operation_C_s4_ConnectorEnd11);
				MultipleDelegation_MultipleConnector_P_P_Operation_C.AddOwnedConnector(MultipleDelegation_MultipleConnector_P_P_Operation_C_s4);
					MultipleDelegation_MultipleConnector_P_P_Operation_C_s1.SetName("s1");
					MultipleDelegation_MultipleConnector_P_P_Operation_C_s1.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Operation_C_s1_ConnectorEnd17.SetRole(MultipleDelegation_MultipleConnector_P_P_Operation_C_p);
						
					MultipleDelegation_MultipleConnector_P_P_Operation_C_s1.AddEnd(MultipleDelegation_MultipleConnector_P_P_Operation_C_s1_ConnectorEnd17);
						
						MultipleDelegation_MultipleConnector_P_P_Operation_C_s1_ConnectorEnd14.SetRole(MultipleDelegation_MultipleConnector_P_P_Operation_C_b1);
						
					MultipleDelegation_MultipleConnector_P_P_Operation_C_s1.AddEnd(MultipleDelegation_MultipleConnector_P_P_Operation_C_s1_ConnectorEnd14);
					MultipleDelegation_MultipleConnector_P_P_Operation_C_s1.SetType(MultipleDelegation_MultipleConnector_P_P_Operation_S);
				MultipleDelegation_MultipleConnector_P_P_Operation_C.AddOwnedConnector(MultipleDelegation_MultipleConnector_P_P_Operation_C_s1);
					// Operation C_C
					MultipleDelegation_MultipleConnector_P_P_Operation_C_C_C.SetName("C_C");
					MultipleDelegation_MultipleConnector_P_P_Operation_C_C_C.SetVisibility(VisibilityKind.public_);
						// Parameter result
						MultipleDelegation_MultipleConnector_P_P_Operation_C_C_C_result.SetName("result");
						MultipleDelegation_MultipleConnector_P_P_Operation_C_C_C_result.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Operation_C_C_C_result.SetType(MultipleDelegation_MultipleConnector_P_P_Operation_C);
						MultipleDelegation_MultipleConnector_P_P_Operation_C_C_C_result.SetDirection(ParameterDirectionKind.return_);
					MultipleDelegation_MultipleConnector_P_P_Operation_C_C_C.AddOwnedParameter(MultipleDelegation_MultipleConnector_P_P_Operation_C_C_C_result);
					MultipleDelegation_MultipleConnector_P_P_Operation_C_C_C.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				MultipleDelegation_MultipleConnector_P_P_Operation_C.AddOwnedOperation(MultipleDelegation_MultipleConnector_P_P_Operation_C_C_C);
			MultipleDelegation_MultipleConnector_P_P_Operation.AddPackagedElement(MultipleDelegation_MultipleConnector_P_P_Operation_C);
				// Interface I
				MultipleDelegation_MultipleConnector_P_P_Operation_I.SetName("I");
				MultipleDelegation_MultipleConnector_P_P_Operation_I.SetVisibility(VisibilityKind.public_);
					// Operation setP_Integer
					MultipleDelegation_MultipleConnector_P_P_Operation_I_setP_Integer.SetName("setP_Integer");
					MultipleDelegation_MultipleConnector_P_P_Operation_I_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						MultipleDelegation_MultipleConnector_P_P_Operation_I_setP_Integer_v.SetName("v");
						MultipleDelegation_MultipleConnector_P_P_Operation_I_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Operation_I_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_MultipleConnector_P_P_Operation_I_setP_Integer.AddOwnedParameter(MultipleDelegation_MultipleConnector_P_P_Operation_I_setP_Integer_v);
				MultipleDelegation_MultipleConnector_P_P_Operation_I.AddOwnedOperation(MultipleDelegation_MultipleConnector_P_P_Operation_I_setP_Integer);
			MultipleDelegation_MultipleConnector_P_P_Operation.AddPackagedElement(MultipleDelegation_MultipleConnector_P_P_Operation_I);
				// Association S
				MultipleDelegation_MultipleConnector_P_P_Operation_S.SetName("S");
				MultipleDelegation_MultipleConnector_P_P_Operation_S.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_MultipleConnector_P_P_Operation_S.AddOwnedEnd(MultipleDelegation_MultipleConnector_P_P_Operation_S_x);
				MultipleDelegation_MultipleConnector_P_P_Operation_S.AddOwnedEnd(MultipleDelegation_MultipleConnector_P_P_Operation_S_y);
			MultipleDelegation_MultipleConnector_P_P_Operation.AddPackagedElement(MultipleDelegation_MultipleConnector_P_P_Operation_S);
				// Class B
				MultipleDelegation_MultipleConnector_P_P_Operation_B.SetName("B");
				MultipleDelegation_MultipleConnector_P_P_Operation_B.SetVisibility(VisibilityKind.public_);
				
					// Property p
					MultipleDelegation_MultipleConnector_P_P_Operation_B_p.SetName("p");
					MultipleDelegation_MultipleConnector_P_P_Operation_B_p.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Operation_B_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						// LiteralInteger LiteralInteger20
						MultipleDelegation_MultipleConnector_P_P_Operation_B_p_LiteralInteger20.SetName("LiteralInteger20");
						MultipleDelegation_MultipleConnector_P_P_Operation_B_p_LiteralInteger20.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_B_p_LiteralInteger20.SetValue(0);
					MultipleDelegation_MultipleConnector_P_P_Operation_B_p.SetDefaultValue(MultipleDelegation_MultipleConnector_P_P_Operation_B_p_LiteralInteger20);
				MultipleDelegation_MultipleConnector_P_P_Operation_B.AddOwnedAttribute(MultipleDelegation_MultipleConnector_P_P_Operation_B_p);
				// Activity setPActivity
					MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity.SetName("setPActivity");
					MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity.SetVisibility(VisibilityKind.public_);
					
						// Parameter v
						MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_v.SetName("v");
						MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_v.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity.AddOwnedParameter(MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_v);
						// AddStructuralFeatureValueAction Set this.p
						MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p.SetName("Set this.p");
						MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_P_Operation_B_p);
							// InputPin object
							MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p_object.SetName("object");
							MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p_object.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p_object.SetType(MultipleDelegation_MultipleConnector_P_P_Operation_B);
						MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p.SetObject(MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p_object);
							// InputPin value
							MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p_value.SetName("value");
							MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p_value.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p.SetValue(MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p_value);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p_result.SetType(MultipleDelegation_MultipleConnector_P_P_Operation_B);
						MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p.SetResult(MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p_result);
					MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity.AddNode(MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p);
						// ActivityParameterNode vParameterNode
						MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_vParameterNode.SetName("vParameterNode");
						MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_vParameterNode.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_vParameterNode.SetParameter(MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_v);
					MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity.AddNode(MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_vParameterNode);
						// ReadSelfAction this
						MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_this.SetName("this");
						MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_this_result.SetName("result");
							MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_this_result.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_this_result.SetType(MultipleDelegation_MultipleConnector_P_P_Operation_B);
						MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_this.SetResult(MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_this_result);
					MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity.AddNode(MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_this);
						// ObjectFlow ObjectFlow28 from result to object
						MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_ObjectFlow28.SetName("ObjectFlow28");
						MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_ObjectFlow28.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_ObjectFlow28.SetSource(MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_this_result);
						MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_ObjectFlow28.SetTarget(MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p_object);
							// LiteralBoolean LiteralBoolean29
							MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_ObjectFlow28_LiteralBoolean29.SetName("LiteralBoolean29");
							MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_ObjectFlow28_LiteralBoolean29.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_ObjectFlow28_LiteralBoolean29.SetValue(true);
						MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_ObjectFlow28.SetGuard(MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_ObjectFlow28_LiteralBoolean29);
					MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity.AddEdge(MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_ObjectFlow28);
						// ObjectFlow ObjectFlow31 from vParameterNode to value
						MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_ObjectFlow31.SetName("ObjectFlow31");
						MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_ObjectFlow31.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_ObjectFlow31.SetSource(MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_vParameterNode);
						MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_ObjectFlow31.SetTarget(MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_Set_this_p_value);
							// LiteralBoolean LiteralBoolean33
							MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_ObjectFlow31_LiteralBoolean33.SetName("LiteralBoolean33");
							MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_ObjectFlow31_LiteralBoolean33.SetVisibility(VisibilityKind.public_);
							MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_ObjectFlow31_LiteralBoolean33.SetValue(true);
						MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_ObjectFlow31.SetGuard(MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_ObjectFlow31_LiteralBoolean33);
					MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity.AddEdge(MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity_ObjectFlow31);
				MultipleDelegation_MultipleConnector_P_P_Operation_B.AddOwnedBehavior(MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity);
					MultipleDelegation_MultipleConnector_P_P_Operation_B_IRealization.SetName("IRealization");
					MultipleDelegation_MultipleConnector_P_P_Operation_B_IRealization.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_P_Operation_B_IRealization.SetContract(MultipleDelegation_MultipleConnector_P_P_Operation_I);
					
				MultipleDelegation_MultipleConnector_P_P_Operation_B.AddInterfaceRealization(MultipleDelegation_MultipleConnector_P_P_Operation_B_IRealization);
				
					// Operation B_B
					MultipleDelegation_MultipleConnector_P_P_Operation_B_B_B.SetName("B_B");
					MultipleDelegation_MultipleConnector_P_P_Operation_B_B_B.SetVisibility(VisibilityKind.public_);
						// Parameter result
						MultipleDelegation_MultipleConnector_P_P_Operation_B_B_B_result.SetName("result");
						MultipleDelegation_MultipleConnector_P_P_Operation_B_B_B_result.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Operation_B_B_B_result.SetType(MultipleDelegation_MultipleConnector_P_P_Operation_B);
						MultipleDelegation_MultipleConnector_P_P_Operation_B_B_B_result.SetDirection(ParameterDirectionKind.return_);
					MultipleDelegation_MultipleConnector_P_P_Operation_B_B_B.AddOwnedParameter(MultipleDelegation_MultipleConnector_P_P_Operation_B_B_B_result);
				MultipleDelegation_MultipleConnector_P_P_Operation_B.AddOwnedOperation(MultipleDelegation_MultipleConnector_P_P_Operation_B_B_B);
					// Operation setP_Integer
					MultipleDelegation_MultipleConnector_P_P_Operation_B_setP_Integer.SetName("setP_Integer");
					MultipleDelegation_MultipleConnector_P_P_Operation_B_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						MultipleDelegation_MultipleConnector_P_P_Operation_B_setP_Integer_v.SetName("v");
						MultipleDelegation_MultipleConnector_P_P_Operation_B_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Operation_B_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_MultipleConnector_P_P_Operation_B_setP_Integer.AddOwnedParameter(MultipleDelegation_MultipleConnector_P_P_Operation_B_setP_Integer_v);
					MultipleDelegation_MultipleConnector_P_P_Operation_B_setP_Integer.AddMethod(MultipleDelegation_MultipleConnector_P_P_Operation_B_setPActivity);
				MultipleDelegation_MultipleConnector_P_P_Operation_B.AddOwnedOperation(MultipleDelegation_MultipleConnector_P_P_Operation_B_setP_Integer);
			MultipleDelegation_MultipleConnector_P_P_Operation.AddPackagedElement(MultipleDelegation_MultipleConnector_P_P_Operation_B);
				// Class IImpl
				MultipleDelegation_MultipleConnector_P_P_Operation_IImpl.SetName("IImpl");
				MultipleDelegation_MultipleConnector_P_P_Operation_IImpl.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_MultipleConnector_P_P_Operation_IImpl_IRealization.SetName("IRealization");
					MultipleDelegation_MultipleConnector_P_P_Operation_IImpl_IRealization.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_P_Operation_IImpl_IRealization.SetContract(MultipleDelegation_MultipleConnector_P_P_Operation_I);
					
				MultipleDelegation_MultipleConnector_P_P_Operation_IImpl.AddInterfaceRealization(MultipleDelegation_MultipleConnector_P_P_Operation_IImpl_IRealization);
				
					// Operation setP_Integer
					MultipleDelegation_MultipleConnector_P_P_Operation_IImpl_setP_Integer.SetName("setP_Integer");
					MultipleDelegation_MultipleConnector_P_P_Operation_IImpl_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						MultipleDelegation_MultipleConnector_P_P_Operation_IImpl_setP_Integer_v.SetName("v");
						MultipleDelegation_MultipleConnector_P_P_Operation_IImpl_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Operation_IImpl_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_MultipleConnector_P_P_Operation_IImpl_setP_Integer.AddOwnedParameter(MultipleDelegation_MultipleConnector_P_P_Operation_IImpl_setP_Integer_v);
				MultipleDelegation_MultipleConnector_P_P_Operation_IImpl.AddOwnedOperation(MultipleDelegation_MultipleConnector_P_P_Operation_IImpl_setP_Integer);
			MultipleDelegation_MultipleConnector_P_P_Operation.AddPackagedElement(MultipleDelegation_MultipleConnector_P_P_Operation_IImpl);
				// Activity main
				MultipleDelegation_MultipleConnector_P_P_Operation_main.SetName("main");
				MultipleDelegation_MultipleConnector_P_P_Operation_main.SetVisibility(VisibilityKind.public_);
				// FunctionBehavior testP
					MultipleDelegation_MultipleConnector_P_P_Operation_main_testP.SetName("testP");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_testP.SetVisibility(VisibilityKind.public_);
					
						// Parameter p
						MultipleDelegation_MultipleConnector_P_P_Operation_main_testP_p.SetName("p");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_testP_p.SetVisibility(VisibilityKind.public_);
						
						MultipleDelegation_MultipleConnector_P_P_Operation_main_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_testP.AddOwnedParameter(MultipleDelegation_MultipleConnector_P_P_Operation_main_testP_p);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_testP.AddLanguage("C#");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_testP.AddLanguage("Using");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_testP.AddBody("if(index == 1) 	{ 		Console.WriteLine(\"Asserting c.b1.p == 4 || c.b2.p == 4 || c.b3.p == 4 || c.b4.p == 4\"); 	}  	// Test parameter p 	int p = ((IntegerValue)inputParameters.ElementAt(0).values.ElementAt(0)).value; 	Debug.Println(\"[doBody] argument p = \" + p); 	 	Console.WriteLine( \"c.b\" + index + \".p == \" + p); 	success = success || (p == 4);  	if(index == MAX_INDEX) 	{  		Console.Write(\"Operation call delegated: \");  		if(success) 		{ 			Console.ForegroundColor = ConsoleColor.Green; 			Console.WriteLine(\"Assertion successful.\"); 		} 		else 		{ 			Console.ForegroundColor = ConsoleColor.Red; 			Console.WriteLine(\"Assertion failed!\"); 		}  		Console.ResetColor(); 	}  	index++;");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_testP.AddBody("using fuml.semantics.simpleclassifiers; ");
				MultipleDelegation_MultipleConnector_P_P_Operation_main.AddOwnedBehavior(MultipleDelegation_MultipleConnector_P_P_Operation_main_testP);
					// CallOperationAction Call p.setP()
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP_.SetName("Call p.setP()");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP_.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP_.SetOperation(MultipleDelegation_MultipleConnector_P_P_Operation_I_setP_Integer);
						// InputPin target
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP__target.SetName("target");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP__target.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP__target.SetType(MultipleDelegation_MultipleConnector_P_P_Operation_I);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP_.SetTarget(MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP__target);
						// InputPin v
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP__v.SetName("v");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP__v.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP__v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP_.AddArgument(MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP__v);
				MultipleDelegation_MultipleConnector_P_P_Operation_main.AddNode(MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP_);
					// ReadStructuralFeatureAction Read c.p
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_p.SetName("Read c.p");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_p.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_p.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_P_Operation_C_p);
						// InputPin object
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_p_object.SetName("object");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_p_object.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_p_object.SetType(MultipleDelegation_MultipleConnector_P_P_Operation_C);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_p.SetObject(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_p_object);
						// OutputPin result
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_p_result.SetName("result");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_p_result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_p_result.SetType(MultipleDelegation_MultipleConnector_P_P_Operation_IImpl);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_p.SetResult(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_p_result);
				MultipleDelegation_MultipleConnector_P_P_Operation_main.AddNode(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_p);
					// CallOperationAction C()
					MultipleDelegation_MultipleConnector_P_P_Operation_main_C_.SetName("C()");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_C_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						MultipleDelegation_MultipleConnector_P_P_Operation_main_C__result.SetName("result");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_C__result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_C__result.SetType(MultipleDelegation_MultipleConnector_P_P_Operation_C);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_C_.AddResult(MultipleDelegation_MultipleConnector_P_P_Operation_main_C__result);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_C_.SetOperation(MultipleDelegation_MultipleConnector_P_P_Operation_C_C_C);
						// InputPin target
						MultipleDelegation_MultipleConnector_P_P_Operation_main_C__target.SetName("target");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_C__target.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_C__target.SetType(MultipleDelegation_MultipleConnector_P_P_Operation_C);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_C_.SetTarget(MultipleDelegation_MultipleConnector_P_P_Operation_main_C__target);
				MultipleDelegation_MultipleConnector_P_P_Operation_main.AddNode(MultipleDelegation_MultipleConnector_P_P_Operation_main_C_);
					// ReadStructuralFeatureAction Read c.b1
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b1.SetName("Read c.b1");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b1.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b1.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_P_Operation_C_b1);
						// InputPin object
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b1_object.SetName("object");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b1_object.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b1_object.SetType(MultipleDelegation_MultipleConnector_P_P_Operation_C);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b1.SetObject(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b1_object);
						// OutputPin result
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b1_result.SetName("result");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b1_result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b1_result.SetType(MultipleDelegation_MultipleConnector_P_P_Operation_B);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b1.SetResult(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b1_result);
				MultipleDelegation_MultipleConnector_P_P_Operation_main.AddNode(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b1);
					// ForkNode Fork C
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Fork_C.SetName("Fork C");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Fork_C.SetVisibility(VisibilityKind.public_);
				MultipleDelegation_MultipleConnector_P_P_Operation_main.AddNode(MultipleDelegation_MultipleConnector_P_P_Operation_main_Fork_C);
					// ReadStructuralFeatureAction Read b.p
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p.SetName("Read b.p");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_P_Operation_B_p);
						// InputPin object
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p_object.SetName("object");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p_object.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p_object.SetType(MultipleDelegation_MultipleConnector_P_P_Operation_B);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p.SetObject(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p_object);
						// OutputPin result
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p_result.SetName("result");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p_result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p.SetResult(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p_result);
				MultipleDelegation_MultipleConnector_P_P_Operation_main.AddNode(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p);
					// ReadStructuralFeatureAction Read c.b4
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b4.SetName("Read c.b4");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b4.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b4.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_P_Operation_C_b4);
						// InputPin object
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b4_object.SetName("object");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b4_object.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b4_object.SetType(MultipleDelegation_MultipleConnector_P_P_Operation_C);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b4.SetObject(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b4_object);
						// OutputPin result
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b4_result.SetName("result");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b4_result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b4_result.SetType(MultipleDelegation_MultipleConnector_P_P_Operation_B);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b4.SetResult(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b4_result);
				MultipleDelegation_MultipleConnector_P_P_Operation_main.AddNode(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b4);
					// CallBehaviorAction Call testP
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_testP.SetName("Call testP");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_testP.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_testP.SetBehavior(MultipleDelegation_MultipleConnector_P_P_Operation_main_testP);
						// InputPin p
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_testP_p.SetName("p");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_testP_p.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_testP.AddArgument(MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_testP_p);
				MultipleDelegation_MultipleConnector_P_P_Operation_main.AddNode(MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_testP);
					// ReadStructuralFeatureAction Read c.b3
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b3.SetName("Read c.b3");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b3.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b3.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_P_Operation_C_b3);
						// InputPin object
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b3_object.SetName("object");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b3_object.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b3_object.SetType(MultipleDelegation_MultipleConnector_P_P_Operation_C);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b3.SetObject(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b3_object);
						// OutputPin result
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b3_result.SetName("result");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b3_result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b3_result.SetType(MultipleDelegation_MultipleConnector_P_P_Operation_B);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b3.SetResult(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b3_result);
				MultipleDelegation_MultipleConnector_P_P_Operation_main.AddNode(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b3);
					// ValueSpecificationAction Value(4)
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Value_4.SetName("Value(4)");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Value_4.SetVisibility(VisibilityKind.public_);
						// LiteralInteger LiteralInteger109
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Value_4_LiteralInteger109.SetName("LiteralInteger109");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Value_4_LiteralInteger109.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Value_4_LiteralInteger109.SetValue(4);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Value_4.SetValue(MultipleDelegation_MultipleConnector_P_P_Operation_main_Value_4_LiteralInteger109);
						// OutputPin result
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Value_4_result.SetName("result");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Value_4_result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Value_4_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Value_4.SetResult(MultipleDelegation_MultipleConnector_P_P_Operation_main_Value_4_result);
				MultipleDelegation_MultipleConnector_P_P_Operation_main.AddNode(MultipleDelegation_MultipleConnector_P_P_Operation_main_Value_4);
					// ReadStructuralFeatureAction Read c.b2
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b2.SetName("Read c.b2");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b2.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b2.SetStructuralFeature(MultipleDelegation_MultipleConnector_P_P_Operation_C_b2);
						// InputPin object
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b2_object.SetName("object");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b2_object.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b2_object.SetType(MultipleDelegation_MultipleConnector_P_P_Operation_C);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b2.SetObject(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b2_object);
						// OutputPin result
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b2_result.SetName("result");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b2_result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b2_result.SetType(MultipleDelegation_MultipleConnector_P_P_Operation_B);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b2.SetResult(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b2_result);
				MultipleDelegation_MultipleConnector_P_P_Operation_main.AddNode(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b2);
					// CreateObjectAction Create C
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Create_C.SetName("Create C");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Create_C.SetVisibility(VisibilityKind.public_);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Create_C.SetClassifier(MultipleDelegation_MultipleConnector_P_P_Operation_C);
						// OutputPin result
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Create_C_result.SetName("result");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Create_C_result.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_Create_C_result.SetType(MultipleDelegation_MultipleConnector_P_P_Operation_C);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_Create_C.SetResult(MultipleDelegation_MultipleConnector_P_P_Operation_main_Create_C_result);
				MultipleDelegation_MultipleConnector_P_P_Operation_main.AddNode(MultipleDelegation_MultipleConnector_P_P_Operation_main_Create_C);
					// ObjectFlow ObjectFlow63 from result to p
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow63.SetName("ObjectFlow63");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow63.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow63.SetSource(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p_result);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow63.SetTarget(MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_testP_p);
						// LiteralBoolean LiteralBoolean65
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow63_LiteralBoolean65.SetName("LiteralBoolean65");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow63_LiteralBoolean65.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow63_LiteralBoolean65.SetValue(true);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow63.SetGuard(MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow63_LiteralBoolean65);
				MultipleDelegation_MultipleConnector_P_P_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow63);
					// ObjectFlow ObjectFlow71 from result to target
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow71.SetName("ObjectFlow71");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow71.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow71.SetSource(MultipleDelegation_MultipleConnector_P_P_Operation_main_Create_C_result);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow71.SetTarget(MultipleDelegation_MultipleConnector_P_P_Operation_main_C__target);
						// LiteralBoolean LiteralBoolean73
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow71_LiteralBoolean73.SetName("LiteralBoolean73");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow71_LiteralBoolean73.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow71_LiteralBoolean73.SetValue(true);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow71.SetGuard(MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow71_LiteralBoolean73);
				MultipleDelegation_MultipleConnector_P_P_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow71);
					// ObjectFlow ObjectFlow74 from result to Fork C
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow74.SetName("ObjectFlow74");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow74.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow74.SetSource(MultipleDelegation_MultipleConnector_P_P_Operation_main_C__result);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow74.SetTarget(MultipleDelegation_MultipleConnector_P_P_Operation_main_Fork_C);
						// LiteralBoolean LiteralBoolean76
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow74_LiteralBoolean76.SetName("LiteralBoolean76");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow74_LiteralBoolean76.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow74_LiteralBoolean76.SetValue(true);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow74.SetGuard(MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow74_LiteralBoolean76);
				MultipleDelegation_MultipleConnector_P_P_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow74);
					// ControlFlow ControlFlow36 from Read c.b1 to Read c.b2
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ControlFlow36.SetName("ControlFlow36");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ControlFlow36.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ControlFlow36.SetSource(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b1);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ControlFlow36.SetTarget(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b2);
				MultipleDelegation_MultipleConnector_P_P_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_P_Operation_main_ControlFlow36);
					// ControlFlow ControlFlow77 from Call p.setP() to Read c.b1
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ControlFlow77.SetName("ControlFlow77");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ControlFlow77.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ControlFlow77.SetSource(MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP_);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ControlFlow77.SetTarget(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b1);
				MultipleDelegation_MultipleConnector_P_P_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_P_Operation_main_ControlFlow77);
					// ObjectFlow ObjectFlow78 from Fork C to object
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow78.SetName("ObjectFlow78");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow78.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow78.SetSource(MultipleDelegation_MultipleConnector_P_P_Operation_main_Fork_C);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow78.SetTarget(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b3_object);
						// LiteralBoolean LiteralBoolean80
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow78_LiteralBoolean80.SetName("LiteralBoolean80");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow78_LiteralBoolean80.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow78_LiteralBoolean80.SetValue(true);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow78.SetGuard(MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow78_LiteralBoolean80);
				MultipleDelegation_MultipleConnector_P_P_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow78);
					// ObjectFlow ObjectFlow41 from Fork C to object
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow41.SetName("ObjectFlow41");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow41.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow41.SetSource(MultipleDelegation_MultipleConnector_P_P_Operation_main_Fork_C);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow41.SetTarget(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b4_object);
						// LiteralBoolean LiteralBoolean43
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow41_LiteralBoolean43.SetName("LiteralBoolean43");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow41_LiteralBoolean43.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow41_LiteralBoolean43.SetValue(true);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow41.SetGuard(MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow41_LiteralBoolean43);
				MultipleDelegation_MultipleConnector_P_P_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow41);
					// ObjectFlow ObjectFlow86 from Fork C to object
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow86.SetName("ObjectFlow86");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow86.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow86.SetSource(MultipleDelegation_MultipleConnector_P_P_Operation_main_Fork_C);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow86.SetTarget(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_p_object);
						// LiteralBoolean LiteralBoolean88
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow86_LiteralBoolean88.SetName("LiteralBoolean88");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow86_LiteralBoolean88.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow86_LiteralBoolean88.SetValue(true);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow86.SetGuard(MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow86_LiteralBoolean88);
				MultipleDelegation_MultipleConnector_P_P_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow86);
					// ObjectFlow ObjectFlow46 from result to v
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow46.SetName("ObjectFlow46");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow46.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow46.SetSource(MultipleDelegation_MultipleConnector_P_P_Operation_main_Value_4_result);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow46.SetTarget(MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP__v);
						// LiteralBoolean LiteralBoolean48
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow46_LiteralBoolean48.SetName("LiteralBoolean48");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow46_LiteralBoolean48.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow46_LiteralBoolean48.SetValue(true);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow46.SetGuard(MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow46_LiteralBoolean48);
				MultipleDelegation_MultipleConnector_P_P_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow46);
					// ControlFlow ControlFlow53 from Read c.b2 to Read c.b3
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ControlFlow53.SetName("ControlFlow53");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ControlFlow53.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ControlFlow53.SetSource(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b2);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ControlFlow53.SetTarget(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b3);
				MultipleDelegation_MultipleConnector_P_P_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_P_Operation_main_ControlFlow53);
					// ObjectFlow ObjectFlow89 from result to object
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow89.SetName("ObjectFlow89");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow89.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow89.SetSource(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b1_result);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow89.SetTarget(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p_object);
						// LiteralBoolean LiteralBoolean91
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow89_LiteralBoolean91.SetName("LiteralBoolean91");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow89_LiteralBoolean91.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow89_LiteralBoolean91.SetValue(true);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow89.SetGuard(MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow89_LiteralBoolean91);
				MultipleDelegation_MultipleConnector_P_P_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow89);
					// ObjectFlow ObjectFlow92 from result to object
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow92.SetName("ObjectFlow92");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow92.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow92.SetSource(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b2_result);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow92.SetTarget(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p_object);
						// LiteralBoolean LiteralBoolean93
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow92_LiteralBoolean93.SetName("LiteralBoolean93");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow92_LiteralBoolean93.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow92_LiteralBoolean93.SetValue(true);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow92.SetGuard(MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow92_LiteralBoolean93);
				MultipleDelegation_MultipleConnector_P_P_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow92);
					// ObjectFlow ObjectFlow54 from Fork C to object
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow54.SetName("ObjectFlow54");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow54.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow54.SetSource(MultipleDelegation_MultipleConnector_P_P_Operation_main_Fork_C);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow54.SetTarget(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b2_object);
						// LiteralBoolean LiteralBoolean56
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow54_LiteralBoolean56.SetName("LiteralBoolean56");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow54_LiteralBoolean56.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow54_LiteralBoolean56.SetValue(true);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow54.SetGuard(MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow54_LiteralBoolean56);
				MultipleDelegation_MultipleConnector_P_P_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow54);
					// ObjectFlow ObjectFlow106 from result to object
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow106.SetName("ObjectFlow106");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow106.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow106.SetSource(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b3_result);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow106.SetTarget(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p_object);
						// LiteralBoolean LiteralBoolean108
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow106_LiteralBoolean108.SetName("LiteralBoolean108");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow106_LiteralBoolean108.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow106_LiteralBoolean108.SetValue(true);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow106.SetGuard(MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow106_LiteralBoolean108);
				MultipleDelegation_MultipleConnector_P_P_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow106);
					// ObjectFlow ObjectFlow57 from result to target
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow57.SetName("ObjectFlow57");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow57.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow57.SetSource(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_p_result);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow57.SetTarget(MultipleDelegation_MultipleConnector_P_P_Operation_main_Call_p_setP__target);
						// LiteralBoolean LiteralBoolean58
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow57_LiteralBoolean58.SetName("LiteralBoolean58");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow57_LiteralBoolean58.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow57_LiteralBoolean58.SetValue(true);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow57.SetGuard(MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow57_LiteralBoolean58);
				MultipleDelegation_MultipleConnector_P_P_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow57);
					// ObjectFlow ObjectFlow112 from result to object
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow112.SetName("ObjectFlow112");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow112.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow112.SetSource(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b4_result);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow112.SetTarget(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_b_p_object);
						// LiteralBoolean LiteralBoolean113
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow112_LiteralBoolean113.SetName("LiteralBoolean113");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow112_LiteralBoolean113.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow112_LiteralBoolean113.SetValue(true);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow112.SetGuard(MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow112_LiteralBoolean113);
				MultipleDelegation_MultipleConnector_P_P_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow112);
					// ControlFlow ControlFlow119 from Read c.b3 to Read c.b4
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ControlFlow119.SetName("ControlFlow119");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ControlFlow119.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ControlFlow119.SetSource(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b3);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ControlFlow119.SetTarget(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b4);
				MultipleDelegation_MultipleConnector_P_P_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_P_Operation_main_ControlFlow119);
					// ObjectFlow ObjectFlow60 from Fork C to object
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow60.SetName("ObjectFlow60");
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow60.SetVisibility(VisibilityKind.public_);
					
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow60.SetSource(MultipleDelegation_MultipleConnector_P_P_Operation_main_Fork_C);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow60.SetTarget(MultipleDelegation_MultipleConnector_P_P_Operation_main_Read_c_b1_object);
						// LiteralBoolean LiteralBoolean61
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow60_LiteralBoolean61.SetName("LiteralBoolean61");
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow60_LiteralBoolean61.SetVisibility(VisibilityKind.public_);
						MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow60_LiteralBoolean61.SetValue(true);
					MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow60.SetGuard(MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow60_LiteralBoolean61);
				MultipleDelegation_MultipleConnector_P_P_Operation_main.AddEdge(MultipleDelegation_MultipleConnector_P_P_Operation_main_ObjectFlow60);
			MultipleDelegation_MultipleConnector_P_P_Operation.AddPackagedElement(MultipleDelegation_MultipleConnector_P_P_Operation_main);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // MultipleDelegation_MultipleConnector_P_P_OperationModel
}
