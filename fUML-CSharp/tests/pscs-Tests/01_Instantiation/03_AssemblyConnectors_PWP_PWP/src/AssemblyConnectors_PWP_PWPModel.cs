/*
 * AssemblyConnectors_PWP_PWPModel.cs
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

namespace AssemblyConnectors_PWP_PWP
{
	public class AssemblyConnectors_PWP_PWPModel : InMemoryModel
	{
		private static AssemblyConnectors_PWP_PWPModel? instance;

		/*
		 * Model AssemblyConnectors_PWP_PWP
		 */
		public Package AssemblyConnectors_PWP_PWP = new();
			public Activity AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern = new();
				public ActivityParameterNode AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_a_Empty_Pattern_node = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_a_Empty_Pattern_node_LiteralInteger0 = new();
				public Parameter AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_a_Empty_Pattern = new();
				public ObjectFlow AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_ObjectFlow1 = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_ObjectFlow1_LiteralInteger2 = new();
					public LiteralBoolean AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_ObjectFlow1_LiteralBoolean3 = new();
				public ValueSpecificationAction AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_message = new();
					public OutputPin AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_message_result = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_message_result_LiteralUnlimitedNatural4 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_message_result_LiteralInteger5 = new();
					public LiteralString AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_message_LiteralString6 = new();
				public CallBehaviorAction AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine = new();
					public InputPin AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine_value = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine_value_LiteralInteger7 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine_value_LiteralInteger8 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine_value_LiteralUnlimitedNatural9 = new();
					public OutputPin AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine_errorStatus = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine_errorStatus_LiteralInteger10 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural11 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine_errorStatus_LiteralInteger12 = new();
			public Association AssemblyConnectors_PWP_PWP_R = new();
				public Property AssemblyConnectors_PWP_PWP_R_x = new();
					public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_R_x_LiteralUnlimitedNatural13 = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_R_x_LiteralInteger14 = new();
				public Property AssemblyConnectors_PWP_PWP_R_y = new();
					public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_R_y_LiteralUnlimitedNatural15 = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_R_y_LiteralInteger16 = new();
			public Activity AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern = new();
				public ObjectFlow AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_ObjectFlow17 = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_ObjectFlow17_LiteralInteger18 = new();
					public LiteralBoolean AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_ObjectFlow17_LiteralBoolean19 = new();
				public CreateObjectAction AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern = new();
					public OutputPin AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result_LiteralUnlimitedNatural20 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result_LiteralInteger21 = new();
				public Parameter AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_a_Array_Pattern = new();
				public CallOperationAction AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_A_Array_Pattern_ = new();
					public OutputPin AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__result = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__result_LiteralInteger22 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__result_LiteralUnlimitedNatural23 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__result_LiteralInteger24 = new();
					public InputPin AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__target = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__target_LiteralUnlimitedNatural25 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__target_LiteralInteger26 = new();
				public ObjectFlow AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_ObjectFlow27 = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_ObjectFlow27_LiteralInteger28 = new();
					public LiteralBoolean AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_ObjectFlow27_LiteralBoolean29 = new();
				public ActivityParameterNode AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_a_Array_Pattern_node = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_a_Array_Pattern_node_LiteralInteger30 = new();
			public Class_ AssemblyConnectors_PWP_PWP_C = new();
				public Port AssemblyConnectors_PWP_PWP_C_q = new();
					public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_C_q_LiteralUnlimitedNatural31 = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_C_q_LiteralInteger32 = new();
			public Class_ AssemblyConnectors_PWP_PWP_B = new();
				public Port AssemblyConnectors_PWP_PWP_B_p = new();
					public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_B_p_LiteralUnlimitedNatural33 = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_B_p_LiteralInteger34 = new();
			public Activity AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern = new();
				public CreateObjectAction AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern = new();
					public OutputPin AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result_LiteralInteger35 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result_LiteralUnlimitedNatural36 = new();
				public ActivityParameterNode AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node = new();
				public Parameter AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern = new();
				public CallOperationAction AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_ = new();
					public OutputPin AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result_LiteralUnlimitedNatural37 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result_LiteralInteger38 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result_LiteralInteger39 = new();
					public InputPin AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target_LiteralInteger40 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target_LiteralUnlimitedNatural41 = new();
				public ObjectFlow AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow42 = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow42_LiteralInteger43 = new();
					public LiteralBoolean AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow42_LiteralBoolean44 = new();
				public ObjectFlow AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow45 = new();
					public LiteralBoolean AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow45_LiteralBoolean46 = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow45_LiteralInteger47 = new();
			public Class_ AssemblyConnectors_PWP_PWP_A_Star_Pattern = new();
				public Comment AssemblyConnectors_PWP_PWP_A_Star_Pattern_Comment48 = new();
				public Property AssemblyConnectors_PWP_PWP_A_Star_Pattern_partC = new();
					public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_A_Star_Pattern_partC_LiteralUnlimitedNatural49 = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_A_Star_Pattern_partC_LiteralInteger50 = new();
				public Operation AssemblyConnectors_PWP_PWP_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern = new();
					public Parameter AssemblyConnectors_PWP_PWP_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result = new();
				public Connector AssemblyConnectors_PWP_PWP_A_Star_Pattern_r = new();
					public ConnectorEnd AssemblyConnectors_PWP_PWP_A_Star_Pattern_r_ConnectorEnd51 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_A_Star_Pattern_r_ConnectorEnd51_connectorEnd_2_Lower = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_A_Star_Pattern_r_ConnectorEnd51_connectorEnd_2_Upper = new();
					public ConnectorEnd AssemblyConnectors_PWP_PWP_A_Star_Pattern_r_ConnectorEnd52 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_A_Star_Pattern_r_ConnectorEnd52_connectorEnd_1_Upper = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_A_Star_Pattern_r_ConnectorEnd52_connectorEnd_1_Lower = new();
				public Property AssemblyConnectors_PWP_PWP_A_Star_Pattern_partB = new();
					public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_A_Star_Pattern_partB_LiteralUnlimitedNatural53 = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_A_Star_Pattern_partB_LiteralInteger54 = new();
			public Activity AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern = new();
				public Parameter AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_a_Unconnected_Pattern = new();
				public CallBehaviorAction AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine = new();
					public OutputPin AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine_errorStatus = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine_errorStatus_LiteralInteger55 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine_errorStatus_LiteralInteger56 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural57 = new();
					public InputPin AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine_value = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine_value_LiteralInteger58 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine_value_LiteralInteger59 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine_value_LiteralUnlimitedNatural60 = new();
				public ObjectFlow AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_ObjectFlow61 = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_ObjectFlow61_LiteralInteger62 = new();
					public LiteralBoolean AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_ObjectFlow61_LiteralBoolean63 = new();
				public ActivityParameterNode AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node_LiteralInteger64 = new();
				public ValueSpecificationAction AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_message = new();
					public LiteralString AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_message_LiteralString65 = new();
					public OutputPin AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_message_result = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_message_result_LiteralInteger66 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_message_result_LiteralUnlimitedNatural67 = new();
			public Activity AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern = new();
				public ActivityParameterNode AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_a_Array_Pattern_node = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_a_Array_Pattern_node_LiteralInteger68 = new();
				public ValueSpecificationAction AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_message = new();
					public LiteralString AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_message_LiteralString69 = new();
					public OutputPin AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_message_result = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_message_result_LiteralUnlimitedNatural70 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_message_result_LiteralInteger71 = new();
				public Parameter AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_a_Array_Pattern = new();
				public CallBehaviorAction AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine = new();
					public OutputPin AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine_errorStatus = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural72 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine_errorStatus_LiteralInteger73 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine_errorStatus_LiteralInteger74 = new();
					public InputPin AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine_value = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine_value_LiteralUnlimitedNatural75 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine_value_LiteralInteger76 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine_value_LiteralInteger77 = new();
				public ObjectFlow AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_ObjectFlow78 = new();
					public LiteralBoolean AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_ObjectFlow78_LiteralBoolean79 = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_ObjectFlow78_LiteralInteger80 = new();
			public Activity AssemblyConnectors_PWP_PWP_main = new();
				public ObjectFlow AssemblyConnectors_PWP_PWP_main_ObjectFlow81 = new();
					public LiteralBoolean AssemblyConnectors_PWP_PWP_main_ObjectFlow81_LiteralBoolean82 = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_main_ObjectFlow81_LiteralInteger83 = new();
				public CallBehaviorAction AssemblyConnectors_PWP_PWP_main_instantiate_A_Array_Pattern = new();
					public OutputPin AssemblyConnectors_PWP_PWP_main_instantiate_A_Array_Pattern_a_Array_Pattern = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_main_instantiate_A_Array_Pattern_a_Array_Pattern_LiteralUnlimitedNatural84 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_main_instantiate_A_Array_Pattern_a_Array_Pattern_LiteralInteger85 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_main_instantiate_A_Array_Pattern_a_Array_Pattern_LiteralInteger86 = new();
				public ObjectFlow AssemblyConnectors_PWP_PWP_main_ObjectFlow87 = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_main_ObjectFlow87_LiteralInteger88 = new();
					public LiteralBoolean AssemblyConnectors_PWP_PWP_main_ObjectFlow87_LiteralBoolean89 = new();
				public CallBehaviorAction AssemblyConnectors_PWP_PWP_main_assert_A_Array_Pattern = new();
					public InputPin AssemblyConnectors_PWP_PWP_main_assert_A_Array_Pattern_a_Array_Pattern = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_main_assert_A_Array_Pattern_a_Array_Pattern_LiteralInteger90 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_main_assert_A_Array_Pattern_a_Array_Pattern_LiteralUnlimitedNatural91 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_main_assert_A_Array_Pattern_a_Array_Pattern_LiteralInteger92 = new();
				public CallBehaviorAction AssemblyConnectors_PWP_PWP_main_assert_A_Empty_Pattern = new();
					public InputPin AssemblyConnectors_PWP_PWP_main_assert_A_Empty_Pattern_a_Empty_Pattern = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_main_assert_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger93 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_main_assert_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger94 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_main_assert_A_Empty_Pattern_a_Empty_Pattern_LiteralUnlimitedNatural95 = new();
				public CallBehaviorAction AssemblyConnectors_PWP_PWP_main_instantiate_A_Empty_Pattern = new();
					public OutputPin AssemblyConnectors_PWP_PWP_main_instantiate_A_Empty_Pattern_a_Empty_Pattern = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_main_instantiate_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger96 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_main_instantiate_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger97 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_main_instantiate_A_Empty_Pattern_a_Empty_Pattern_LiteralUnlimitedNatural98 = new();
				public CallBehaviorAction AssemblyConnectors_PWP_PWP_main_assert_A_Star_Pattern = new();
					public InputPin AssemblyConnectors_PWP_PWP_main_assert_A_Star_Pattern_a_Star_Pattern = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_main_assert_A_Star_Pattern_a_Star_Pattern_LiteralInteger99 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_main_assert_A_Star_Pattern_a_Star_Pattern_LiteralUnlimitedNatural100 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_main_assert_A_Star_Pattern_a_Star_Pattern_LiteralInteger101 = new();
				public CallBehaviorAction AssemblyConnectors_PWP_PWP_main_assert_A_Unconnected_Pattern = new();
					public InputPin AssemblyConnectors_PWP_PWP_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger102 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralUnlimitedNatural103 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger104 = new();
				public ObjectFlow AssemblyConnectors_PWP_PWP_main_ObjectFlow105 = new();
					public LiteralBoolean AssemblyConnectors_PWP_PWP_main_ObjectFlow105_LiteralBoolean106 = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_main_ObjectFlow105_LiteralInteger107 = new();
				public ControlFlow AssemblyConnectors_PWP_PWP_main_ControlFlow108 = new();
				public ControlFlow AssemblyConnectors_PWP_PWP_main_ControlFlow109 = new();
				public ControlFlow AssemblyConnectors_PWP_PWP_main_ControlFlow110 = new();
				public CallBehaviorAction AssemblyConnectors_PWP_PWP_main_instantiate_A_Star_Pattern = new();
					public OutputPin AssemblyConnectors_PWP_PWP_main_instantiate_A_Star_Pattern_a_Star_Pattern = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_main_instantiate_A_Star_Pattern_a_Star_Pattern_LiteralInteger111 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_main_instantiate_A_Star_Pattern_a_Star_Pattern_LiteralUnlimitedNatural112 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_main_instantiate_A_Star_Pattern_a_Star_Pattern_LiteralInteger113 = new();
				public CallBehaviorAction AssemblyConnectors_PWP_PWP_main_instantiate_A_Unconnected_Pattern = new();
					public OutputPin AssemblyConnectors_PWP_PWP_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralUnlimitedNatural114 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger115 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger116 = new();
				public ObjectFlow AssemblyConnectors_PWP_PWP_main_ObjectFlow117 = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_main_ObjectFlow117_LiteralInteger118 = new();
					public LiteralBoolean AssemblyConnectors_PWP_PWP_main_ObjectFlow117_LiteralBoolean119 = new();
			public Class_ AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern = new();
				public Comment AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_Comment120 = new();
				public Property AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_partC = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_partC_LiteralInteger121 = new();
					public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_partC_LiteralUnlimitedNatural122 = new();
				public Property AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_partB = new();
					public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_partB_LiteralUnlimitedNatural123 = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_partB_LiteralInteger124 = new();
				public Connector AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_r = new();
					public ConnectorEnd AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_r_ConnectorEnd125 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_r_ConnectorEnd125_connectorEnd_2_Lower = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_r_ConnectorEnd125_connectorEnd_2_Upper = new();
					public ConnectorEnd AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_r_ConnectorEnd126 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_r_ConnectorEnd126_connectorEnd_1_Lower = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_r_ConnectorEnd126_connectorEnd_1_Upper = new();
				public Operation AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern = new();
					public Parameter AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result = new();
			public Class_ AssemblyConnectors_PWP_PWP_A_Array_Pattern = new();
				public Property AssemblyConnectors_PWP_PWP_A_Array_Pattern_partB = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_A_Array_Pattern_partB_LiteralInteger127 = new();
					public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_A_Array_Pattern_partB_LiteralUnlimitedNatural128 = new();
				public Property AssemblyConnectors_PWP_PWP_A_Array_Pattern_partC = new();
					public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_A_Array_Pattern_partC_LiteralUnlimitedNatural129 = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_A_Array_Pattern_partC_LiteralInteger130 = new();
				public Comment AssemblyConnectors_PWP_PWP_A_Array_Pattern_Comment131 = new();
				public Connector AssemblyConnectors_PWP_PWP_A_Array_Pattern_r = new();
					public ConnectorEnd AssemblyConnectors_PWP_PWP_A_Array_Pattern_r_ConnectorEnd132 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_A_Array_Pattern_r_ConnectorEnd132_connectorEnd_1_Lower = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_A_Array_Pattern_r_ConnectorEnd132_connectorEnd_1_Upper = new();
					public ConnectorEnd AssemblyConnectors_PWP_PWP_A_Array_Pattern_r_ConnectorEnd133 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_A_Array_Pattern_r_ConnectorEnd133_connectorEnd_2_Lower = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_A_Array_Pattern_r_ConnectorEnd133_connectorEnd_2_Upper = new();
				public Operation AssemblyConnectors_PWP_PWP_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern = new();
					public Parameter AssemblyConnectors_PWP_PWP_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result = new();
			public Activity AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern = new();
				public ActivityParameterNode AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_a_Empty_Pattern_node = new();
				public CallOperationAction AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern_ = new();
					public InputPin AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__target = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__target_LiteralInteger134 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__target_LiteralUnlimitedNatural135 = new();
					public OutputPin AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__result = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__result_LiteralInteger136 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__result_LiteralInteger137 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__result_LiteralUnlimitedNatural138 = new();
				public ObjectFlow AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_ObjectFlow139 = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_ObjectFlow139_LiteralInteger140 = new();
					public LiteralBoolean AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_ObjectFlow139_LiteralBoolean141 = new();
				public Parameter AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_a_Empty_Pattern = new();
				public CreateObjectAction AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern = new();
					public OutputPin AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result_LiteralInteger142 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result_LiteralUnlimitedNatural143 = new();
				public ObjectFlow AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_ObjectFlow144 = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_ObjectFlow144_LiteralInteger145 = new();
					public LiteralBoolean AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_ObjectFlow144_LiteralBoolean146 = new();
			public Activity AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern = new();
				public ObjectFlow AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_ObjectFlow147 = new();
					public LiteralBoolean AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_ObjectFlow147_LiteralBoolean148 = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_ObjectFlow147_LiteralInteger149 = new();
				public CallBehaviorAction AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine = new();
					public InputPin AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine_value = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine_value_LiteralInteger150 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine_value_LiteralInteger151 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine_value_LiteralUnlimitedNatural152 = new();
					public OutputPin AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine_errorStatus = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine_errorStatus_LiteralInteger153 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine_errorStatus_LiteralInteger154 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural155 = new();
				public ActivityParameterNode AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_a_Star_Pattern_node = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_a_Star_Pattern_node_LiteralInteger156 = new();
				public Parameter AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_a_Star_Pattern = new();
				public ValueSpecificationAction AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_message = new();
					public OutputPin AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_message_result = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_message_result_LiteralInteger157 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_message_result_LiteralUnlimitedNatural158 = new();
					public LiteralString AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_message_LiteralString159 = new();
			public Class_ AssemblyConnectors_PWP_PWP_IImpl = new();
				public InterfaceRealization AssemblyConnectors_PWP_PWP_IImpl_I_Realization = new();
			public Interface AssemblyConnectors_PWP_PWP_I = new();
			public Class_ AssemblyConnectors_PWP_PWP_A_Empty_Pattern = new();
				public Property AssemblyConnectors_PWP_PWP_A_Empty_Pattern_partB = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_A_Empty_Pattern_partB_LiteralInteger160 = new();
					public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_A_Empty_Pattern_partB_LiteralUnlimitedNatural161 = new();
				public Property AssemblyConnectors_PWP_PWP_A_Empty_Pattern_partC = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_A_Empty_Pattern_partC_LiteralInteger162 = new();
					public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_A_Empty_Pattern_partC_LiteralUnlimitedNatural163 = new();
				public Operation AssemblyConnectors_PWP_PWP_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern = new();
					public Parameter AssemblyConnectors_PWP_PWP_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result = new();
				public Connector AssemblyConnectors_PWP_PWP_A_Empty_Pattern_r = new();
					public ConnectorEnd AssemblyConnectors_PWP_PWP_A_Empty_Pattern_r_ConnectorEnd164 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_A_Empty_Pattern_r_ConnectorEnd164_connectorEnd_2_Upper = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_A_Empty_Pattern_r_ConnectorEnd164_connectorEnd_2_Lower = new();
					public ConnectorEnd AssemblyConnectors_PWP_PWP_A_Empty_Pattern_r_ConnectorEnd165 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_A_Empty_Pattern_r_ConnectorEnd165_connectorEnd_1_Upper = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_A_Empty_Pattern_r_ConnectorEnd165_connectorEnd_1_Lower = new();
				public Comment AssemblyConnectors_PWP_PWP_A_Empty_Pattern_Comment166 = new();
			public Activity AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern = new();
				public CallOperationAction AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_A_Star_Pattern_ = new();
					public InputPin AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__target = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__target_LiteralUnlimitedNatural167 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__target_LiteralInteger168 = new();
					public OutputPin AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__result = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__result_LiteralInteger169 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__result_LiteralUnlimitedNatural170 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__result_LiteralInteger171 = new();
				public ObjectFlow AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_ObjectFlow172 = new();
					public LiteralBoolean AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_ObjectFlow172_LiteralBoolean173 = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_ObjectFlow172_LiteralInteger174 = new();
				public ActivityParameterNode AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_a_Star_Pattern_node = new();
				public Parameter AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_a_Star_Pattern = new();
				public ObjectFlow AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_ObjectFlow175 = new();
					public LiteralBoolean AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_ObjectFlow175_LiteralBoolean176 = new();
					public LiteralInteger AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_ObjectFlow175_LiteralInteger177 = new();
				public CreateObjectAction AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern = new();
					public OutputPin AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result_LiteralUnlimitedNatural178 = new();
						public LiteralInteger AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result_LiteralInteger179 = new();

		public static AssemblyConnectors_PWP_PWPModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public AssemblyConnectors_PWP_PWPModel()
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
			 * Model AssemblyConnectors_PWP_PWP
			 */
			AddToElementRepository("AssemblyConnectors_PWP_PWP", AssemblyConnectors_PWP_PWP);
				AddToElementRepository("assert_A_Empty_Pattern", AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern);
					AddToElementRepository("a_Empty_Pattern_node", AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_a_Empty_Pattern_node);
						AddToElementRepository("LiteralInteger0", AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_a_Empty_Pattern_node_LiteralInteger0);
					AddToElementRepository("a_Empty_Pattern", AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_a_Empty_Pattern);
					AddToElementRepository("ObjectFlow1", AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_ObjectFlow1);
						AddToElementRepository("LiteralInteger2", AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_ObjectFlow1_LiteralInteger2);
						AddToElementRepository("LiteralBoolean3", AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_ObjectFlow1_LiteralBoolean3);
					AddToElementRepository("message", AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_message);
						AddToElementRepository("result", AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_message_result);
							AddToElementRepository("LiteralUnlimitedNatural4", AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_message_result_LiteralUnlimitedNatural4);
							AddToElementRepository("LiteralInteger5", AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_message_result_LiteralInteger5);
						AddToElementRepository("LiteralString6", AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_message_LiteralString6);
					AddToElementRepository("writeLine", AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine);
						AddToElementRepository("value", AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine_value);
							AddToElementRepository("LiteralInteger7", AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine_value_LiteralInteger7);
							AddToElementRepository("LiteralInteger8", AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine_value_LiteralInteger8);
							AddToElementRepository("LiteralUnlimitedNatural9", AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine_value_LiteralUnlimitedNatural9);
						AddToElementRepository("errorStatus", AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine_errorStatus);
							AddToElementRepository("LiteralInteger10", AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine_errorStatus_LiteralInteger10);
							AddToElementRepository("LiteralUnlimitedNatural11", AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural11);
							AddToElementRepository("LiteralInteger12", AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine_errorStatus_LiteralInteger12);
				AddToElementRepository("R", AssemblyConnectors_PWP_PWP_R);
					AddToElementRepository("x", AssemblyConnectors_PWP_PWP_R_x);
						AddToElementRepository("LiteralUnlimitedNatural13", AssemblyConnectors_PWP_PWP_R_x_LiteralUnlimitedNatural13);
						AddToElementRepository("LiteralInteger14", AssemblyConnectors_PWP_PWP_R_x_LiteralInteger14);
					AddToElementRepository("y", AssemblyConnectors_PWP_PWP_R_y);
						AddToElementRepository("LiteralUnlimitedNatural15", AssemblyConnectors_PWP_PWP_R_y_LiteralUnlimitedNatural15);
						AddToElementRepository("LiteralInteger16", AssemblyConnectors_PWP_PWP_R_y_LiteralInteger16);
				AddToElementRepository("instantiate_A_Array_Pattern", AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern);
					AddToElementRepository("ObjectFlow17", AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_ObjectFlow17);
						AddToElementRepository("LiteralInteger18", AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_ObjectFlow17_LiteralInteger18);
						AddToElementRepository("LiteralBoolean19", AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_ObjectFlow17_LiteralBoolean19);
					AddToElementRepository("Create A_Array_Pattern", AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern);
						AddToElementRepository("result", AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result);
							AddToElementRepository("LiteralUnlimitedNatural20", AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result_LiteralUnlimitedNatural20);
							AddToElementRepository("LiteralInteger21", AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result_LiteralInteger21);
					AddToElementRepository("a_Array_Pattern", AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_a_Array_Pattern);
					AddToElementRepository("A_Array_Pattern()", AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_A_Array_Pattern_);
						AddToElementRepository("result", AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__result);
							AddToElementRepository("LiteralInteger22", AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__result_LiteralInteger22);
							AddToElementRepository("LiteralUnlimitedNatural23", AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__result_LiteralUnlimitedNatural23);
							AddToElementRepository("LiteralInteger24", AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__result_LiteralInteger24);
						AddToElementRepository("target", AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__target);
							AddToElementRepository("LiteralUnlimitedNatural25", AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__target_LiteralUnlimitedNatural25);
							AddToElementRepository("LiteralInteger26", AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__target_LiteralInteger26);
					AddToElementRepository("ObjectFlow27", AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_ObjectFlow27);
						AddToElementRepository("LiteralInteger28", AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_ObjectFlow27_LiteralInteger28);
						AddToElementRepository("LiteralBoolean29", AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_ObjectFlow27_LiteralBoolean29);
					AddToElementRepository("a_Array_Pattern_node", AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_a_Array_Pattern_node);
						AddToElementRepository("LiteralInteger30", AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_a_Array_Pattern_node_LiteralInteger30);
				AddToElementRepository("C", AssemblyConnectors_PWP_PWP_C);
					AddToElementRepository("q", AssemblyConnectors_PWP_PWP_C_q);
						AddToElementRepository("LiteralUnlimitedNatural31", AssemblyConnectors_PWP_PWP_C_q_LiteralUnlimitedNatural31);
						AddToElementRepository("LiteralInteger32", AssemblyConnectors_PWP_PWP_C_q_LiteralInteger32);
				AddToElementRepository("B", AssemblyConnectors_PWP_PWP_B);
					AddToElementRepository("p", AssemblyConnectors_PWP_PWP_B_p);
						AddToElementRepository("LiteralUnlimitedNatural33", AssemblyConnectors_PWP_PWP_B_p_LiteralUnlimitedNatural33);
						AddToElementRepository("LiteralInteger34", AssemblyConnectors_PWP_PWP_B_p_LiteralInteger34);
				AddToElementRepository("instantiate_A_Unconnected_Pattern", AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern);
					AddToElementRepository("Create A_Unconnected_Pattern", AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern);
						AddToElementRepository("result", AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result);
							AddToElementRepository("LiteralInteger35", AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result_LiteralInteger35);
							AddToElementRepository("LiteralUnlimitedNatural36", AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result_LiteralUnlimitedNatural36);
					AddToElementRepository("a_Unconnected_Pattern_node", AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node);
					AddToElementRepository("a_Unconnected_Pattern", AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern);
					AddToElementRepository("A_Unconnected_Pattern()", AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_);
						AddToElementRepository("result", AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result);
							AddToElementRepository("LiteralUnlimitedNatural37", AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result_LiteralUnlimitedNatural37);
							AddToElementRepository("LiteralInteger38", AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result_LiteralInteger38);
							AddToElementRepository("LiteralInteger39", AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result_LiteralInteger39);
						AddToElementRepository("target", AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target);
							AddToElementRepository("LiteralInteger40", AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target_LiteralInteger40);
							AddToElementRepository("LiteralUnlimitedNatural41", AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target_LiteralUnlimitedNatural41);
					AddToElementRepository("ObjectFlow42", AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow42);
						AddToElementRepository("LiteralInteger43", AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow42_LiteralInteger43);
						AddToElementRepository("LiteralBoolean44", AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow42_LiteralBoolean44);
					AddToElementRepository("ObjectFlow45", AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow45);
						AddToElementRepository("LiteralBoolean46", AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow45_LiteralBoolean46);
						AddToElementRepository("LiteralInteger47", AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow45_LiteralInteger47);
				AddToElementRepository("A_Star_Pattern", AssemblyConnectors_PWP_PWP_A_Star_Pattern);
					AddToElementRepository("Comment48", AssemblyConnectors_PWP_PWP_A_Star_Pattern_Comment48);
					AddToElementRepository("partC", AssemblyConnectors_PWP_PWP_A_Star_Pattern_partC);
						AddToElementRepository("LiteralUnlimitedNatural49", AssemblyConnectors_PWP_PWP_A_Star_Pattern_partC_LiteralUnlimitedNatural49);
						AddToElementRepository("LiteralInteger50", AssemblyConnectors_PWP_PWP_A_Star_Pattern_partC_LiteralInteger50);
					AddToElementRepository("A_Star_Pattern_A_Star_Pattern", AssemblyConnectors_PWP_PWP_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern);
						AddToElementRepository("result", AssemblyConnectors_PWP_PWP_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result);
					AddToElementRepository("r", AssemblyConnectors_PWP_PWP_A_Star_Pattern_r);
						AddToElementRepository("ConnectorEnd51", AssemblyConnectors_PWP_PWP_A_Star_Pattern_r_ConnectorEnd51);
							AddToElementRepository("connectorEnd_2_Lower", AssemblyConnectors_PWP_PWP_A_Star_Pattern_r_ConnectorEnd51_connectorEnd_2_Lower);
							AddToElementRepository("connectorEnd_2_Upper", AssemblyConnectors_PWP_PWP_A_Star_Pattern_r_ConnectorEnd51_connectorEnd_2_Upper);
						AddToElementRepository("ConnectorEnd52", AssemblyConnectors_PWP_PWP_A_Star_Pattern_r_ConnectorEnd52);
							AddToElementRepository("connectorEnd_1_Upper", AssemblyConnectors_PWP_PWP_A_Star_Pattern_r_ConnectorEnd52_connectorEnd_1_Upper);
							AddToElementRepository("connectorEnd_1_Lower", AssemblyConnectors_PWP_PWP_A_Star_Pattern_r_ConnectorEnd52_connectorEnd_1_Lower);
					AddToElementRepository("partB", AssemblyConnectors_PWP_PWP_A_Star_Pattern_partB);
						AddToElementRepository("LiteralUnlimitedNatural53", AssemblyConnectors_PWP_PWP_A_Star_Pattern_partB_LiteralUnlimitedNatural53);
						AddToElementRepository("LiteralInteger54", AssemblyConnectors_PWP_PWP_A_Star_Pattern_partB_LiteralInteger54);
				AddToElementRepository("assert_A_Unconnected_Pattern", AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern);
					AddToElementRepository("a_Unconnected_Pattern", AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_a_Unconnected_Pattern);
					AddToElementRepository("writeLine", AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine);
						AddToElementRepository("errorStatus", AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine_errorStatus);
							AddToElementRepository("LiteralInteger55", AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine_errorStatus_LiteralInteger55);
							AddToElementRepository("LiteralInteger56", AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine_errorStatus_LiteralInteger56);
							AddToElementRepository("LiteralUnlimitedNatural57", AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural57);
						AddToElementRepository("value", AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine_value);
							AddToElementRepository("LiteralInteger58", AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine_value_LiteralInteger58);
							AddToElementRepository("LiteralInteger59", AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine_value_LiteralInteger59);
							AddToElementRepository("LiteralUnlimitedNatural60", AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine_value_LiteralUnlimitedNatural60);
					AddToElementRepository("ObjectFlow61", AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_ObjectFlow61);
						AddToElementRepository("LiteralInteger62", AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_ObjectFlow61_LiteralInteger62);
						AddToElementRepository("LiteralBoolean63", AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_ObjectFlow61_LiteralBoolean63);
					AddToElementRepository("a_Unconnected_Pattern_node", AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node);
						AddToElementRepository("LiteralInteger64", AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node_LiteralInteger64);
					AddToElementRepository("message", AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_message);
						AddToElementRepository("LiteralString65", AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_message_LiteralString65);
						AddToElementRepository("result", AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_message_result);
							AddToElementRepository("LiteralInteger66", AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_message_result_LiteralInteger66);
							AddToElementRepository("LiteralUnlimitedNatural67", AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_message_result_LiteralUnlimitedNatural67);
				AddToElementRepository("assert_A_Array_Pattern", AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern);
					AddToElementRepository("a_Array_Pattern_node", AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_a_Array_Pattern_node);
						AddToElementRepository("LiteralInteger68", AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_a_Array_Pattern_node_LiteralInteger68);
					AddToElementRepository("message", AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_message);
						AddToElementRepository("LiteralString69", AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_message_LiteralString69);
						AddToElementRepository("result", AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_message_result);
							AddToElementRepository("LiteralUnlimitedNatural70", AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_message_result_LiteralUnlimitedNatural70);
							AddToElementRepository("LiteralInteger71", AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_message_result_LiteralInteger71);
					AddToElementRepository("a_Array_Pattern", AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_a_Array_Pattern);
					AddToElementRepository("writeLine", AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine);
						AddToElementRepository("errorStatus", AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine_errorStatus);
							AddToElementRepository("LiteralUnlimitedNatural72", AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural72);
							AddToElementRepository("LiteralInteger73", AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine_errorStatus_LiteralInteger73);
							AddToElementRepository("LiteralInteger74", AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine_errorStatus_LiteralInteger74);
						AddToElementRepository("value", AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine_value);
							AddToElementRepository("LiteralUnlimitedNatural75", AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine_value_LiteralUnlimitedNatural75);
							AddToElementRepository("LiteralInteger76", AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine_value_LiteralInteger76);
							AddToElementRepository("LiteralInteger77", AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine_value_LiteralInteger77);
					AddToElementRepository("ObjectFlow78", AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_ObjectFlow78);
						AddToElementRepository("LiteralBoolean79", AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_ObjectFlow78_LiteralBoolean79);
						AddToElementRepository("LiteralInteger80", AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_ObjectFlow78_LiteralInteger80);
				AddToElementRepository("main", AssemblyConnectors_PWP_PWP_main);
					AddToElementRepository("ObjectFlow81", AssemblyConnectors_PWP_PWP_main_ObjectFlow81);
						AddToElementRepository("LiteralBoolean82", AssemblyConnectors_PWP_PWP_main_ObjectFlow81_LiteralBoolean82);
						AddToElementRepository("LiteralInteger83", AssemblyConnectors_PWP_PWP_main_ObjectFlow81_LiteralInteger83);
					AddToElementRepository("instantiate_A_Array_Pattern", AssemblyConnectors_PWP_PWP_main_instantiate_A_Array_Pattern);
						AddToElementRepository("a_Array_Pattern", AssemblyConnectors_PWP_PWP_main_instantiate_A_Array_Pattern_a_Array_Pattern);
							AddToElementRepository("LiteralUnlimitedNatural84", AssemblyConnectors_PWP_PWP_main_instantiate_A_Array_Pattern_a_Array_Pattern_LiteralUnlimitedNatural84);
							AddToElementRepository("LiteralInteger85", AssemblyConnectors_PWP_PWP_main_instantiate_A_Array_Pattern_a_Array_Pattern_LiteralInteger85);
							AddToElementRepository("LiteralInteger86", AssemblyConnectors_PWP_PWP_main_instantiate_A_Array_Pattern_a_Array_Pattern_LiteralInteger86);
					AddToElementRepository("ObjectFlow87", AssemblyConnectors_PWP_PWP_main_ObjectFlow87);
						AddToElementRepository("LiteralInteger88", AssemblyConnectors_PWP_PWP_main_ObjectFlow87_LiteralInteger88);
						AddToElementRepository("LiteralBoolean89", AssemblyConnectors_PWP_PWP_main_ObjectFlow87_LiteralBoolean89);
					AddToElementRepository("assert_A_Array_Pattern", AssemblyConnectors_PWP_PWP_main_assert_A_Array_Pattern);
						AddToElementRepository("a_Array_Pattern", AssemblyConnectors_PWP_PWP_main_assert_A_Array_Pattern_a_Array_Pattern);
							AddToElementRepository("LiteralInteger90", AssemblyConnectors_PWP_PWP_main_assert_A_Array_Pattern_a_Array_Pattern_LiteralInteger90);
							AddToElementRepository("LiteralUnlimitedNatural91", AssemblyConnectors_PWP_PWP_main_assert_A_Array_Pattern_a_Array_Pattern_LiteralUnlimitedNatural91);
							AddToElementRepository("LiteralInteger92", AssemblyConnectors_PWP_PWP_main_assert_A_Array_Pattern_a_Array_Pattern_LiteralInteger92);
					AddToElementRepository("assert_A_Empty_Pattern", AssemblyConnectors_PWP_PWP_main_assert_A_Empty_Pattern);
						AddToElementRepository("a_Empty_Pattern", AssemblyConnectors_PWP_PWP_main_assert_A_Empty_Pattern_a_Empty_Pattern);
							AddToElementRepository("LiteralInteger93", AssemblyConnectors_PWP_PWP_main_assert_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger93);
							AddToElementRepository("LiteralInteger94", AssemblyConnectors_PWP_PWP_main_assert_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger94);
							AddToElementRepository("LiteralUnlimitedNatural95", AssemblyConnectors_PWP_PWP_main_assert_A_Empty_Pattern_a_Empty_Pattern_LiteralUnlimitedNatural95);
					AddToElementRepository("instantiate_A_Empty_Pattern", AssemblyConnectors_PWP_PWP_main_instantiate_A_Empty_Pattern);
						AddToElementRepository("a_Empty_Pattern", AssemblyConnectors_PWP_PWP_main_instantiate_A_Empty_Pattern_a_Empty_Pattern);
							AddToElementRepository("LiteralInteger96", AssemblyConnectors_PWP_PWP_main_instantiate_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger96);
							AddToElementRepository("LiteralInteger97", AssemblyConnectors_PWP_PWP_main_instantiate_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger97);
							AddToElementRepository("LiteralUnlimitedNatural98", AssemblyConnectors_PWP_PWP_main_instantiate_A_Empty_Pattern_a_Empty_Pattern_LiteralUnlimitedNatural98);
					AddToElementRepository("assert_A_Star_Pattern", AssemblyConnectors_PWP_PWP_main_assert_A_Star_Pattern);
						AddToElementRepository("a_Star_Pattern", AssemblyConnectors_PWP_PWP_main_assert_A_Star_Pattern_a_Star_Pattern);
							AddToElementRepository("LiteralInteger99", AssemblyConnectors_PWP_PWP_main_assert_A_Star_Pattern_a_Star_Pattern_LiteralInteger99);
							AddToElementRepository("LiteralUnlimitedNatural100", AssemblyConnectors_PWP_PWP_main_assert_A_Star_Pattern_a_Star_Pattern_LiteralUnlimitedNatural100);
							AddToElementRepository("LiteralInteger101", AssemblyConnectors_PWP_PWP_main_assert_A_Star_Pattern_a_Star_Pattern_LiteralInteger101);
					AddToElementRepository("assert_A_Unconnected_Pattern", AssemblyConnectors_PWP_PWP_main_assert_A_Unconnected_Pattern);
						AddToElementRepository("a_Unconnected_Pattern", AssemblyConnectors_PWP_PWP_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern);
							AddToElementRepository("LiteralInteger102", AssemblyConnectors_PWP_PWP_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger102);
							AddToElementRepository("LiteralUnlimitedNatural103", AssemblyConnectors_PWP_PWP_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralUnlimitedNatural103);
							AddToElementRepository("LiteralInteger104", AssemblyConnectors_PWP_PWP_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger104);
					AddToElementRepository("ObjectFlow105", AssemblyConnectors_PWP_PWP_main_ObjectFlow105);
						AddToElementRepository("LiteralBoolean106", AssemblyConnectors_PWP_PWP_main_ObjectFlow105_LiteralBoolean106);
						AddToElementRepository("LiteralInteger107", AssemblyConnectors_PWP_PWP_main_ObjectFlow105_LiteralInteger107);
					AddToElementRepository("ControlFlow108", AssemblyConnectors_PWP_PWP_main_ControlFlow108);
					AddToElementRepository("ControlFlow109", AssemblyConnectors_PWP_PWP_main_ControlFlow109);
					AddToElementRepository("ControlFlow110", AssemblyConnectors_PWP_PWP_main_ControlFlow110);
					AddToElementRepository("instantiate_A_Star_Pattern", AssemblyConnectors_PWP_PWP_main_instantiate_A_Star_Pattern);
						AddToElementRepository("a_Star_Pattern", AssemblyConnectors_PWP_PWP_main_instantiate_A_Star_Pattern_a_Star_Pattern);
							AddToElementRepository("LiteralInteger111", AssemblyConnectors_PWP_PWP_main_instantiate_A_Star_Pattern_a_Star_Pattern_LiteralInteger111);
							AddToElementRepository("LiteralUnlimitedNatural112", AssemblyConnectors_PWP_PWP_main_instantiate_A_Star_Pattern_a_Star_Pattern_LiteralUnlimitedNatural112);
							AddToElementRepository("LiteralInteger113", AssemblyConnectors_PWP_PWP_main_instantiate_A_Star_Pattern_a_Star_Pattern_LiteralInteger113);
					AddToElementRepository("instantiate_A_Unconnected_Pattern", AssemblyConnectors_PWP_PWP_main_instantiate_A_Unconnected_Pattern);
						AddToElementRepository("a_Unconnected_Pattern", AssemblyConnectors_PWP_PWP_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern);
							AddToElementRepository("LiteralUnlimitedNatural114", AssemblyConnectors_PWP_PWP_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralUnlimitedNatural114);
							AddToElementRepository("LiteralInteger115", AssemblyConnectors_PWP_PWP_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger115);
							AddToElementRepository("LiteralInteger116", AssemblyConnectors_PWP_PWP_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger116);
					AddToElementRepository("ObjectFlow117", AssemblyConnectors_PWP_PWP_main_ObjectFlow117);
						AddToElementRepository("LiteralInteger118", AssemblyConnectors_PWP_PWP_main_ObjectFlow117_LiteralInteger118);
						AddToElementRepository("LiteralBoolean119", AssemblyConnectors_PWP_PWP_main_ObjectFlow117_LiteralBoolean119);
				AddToElementRepository("A_Unconnected_Pattern", AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern);
					AddToElementRepository("Comment120", AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_Comment120);
					AddToElementRepository("partC", AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_partC);
						AddToElementRepository("LiteralInteger121", AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_partC_LiteralInteger121);
						AddToElementRepository("LiteralUnlimitedNatural122", AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_partC_LiteralUnlimitedNatural122);
					AddToElementRepository("partB", AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_partB);
						AddToElementRepository("LiteralUnlimitedNatural123", AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_partB_LiteralUnlimitedNatural123);
						AddToElementRepository("LiteralInteger124", AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_partB_LiteralInteger124);
					AddToElementRepository("r", AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_r);
						AddToElementRepository("ConnectorEnd125", AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_r_ConnectorEnd125);
							AddToElementRepository("connectorEnd_2_Lower", AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_r_ConnectorEnd125_connectorEnd_2_Lower);
							AddToElementRepository("connectorEnd_2_Upper", AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_r_ConnectorEnd125_connectorEnd_2_Upper);
						AddToElementRepository("ConnectorEnd126", AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_r_ConnectorEnd126);
							AddToElementRepository("connectorEnd_1_Lower", AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_r_ConnectorEnd126_connectorEnd_1_Lower);
							AddToElementRepository("connectorEnd_1_Upper", AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_r_ConnectorEnd126_connectorEnd_1_Upper);
					AddToElementRepository("A_Unconnected_Pattern_A_Unconnected_Pattern", AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern);
						AddToElementRepository("result", AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result);
				AddToElementRepository("A_Array_Pattern", AssemblyConnectors_PWP_PWP_A_Array_Pattern);
					AddToElementRepository("partB", AssemblyConnectors_PWP_PWP_A_Array_Pattern_partB);
						AddToElementRepository("LiteralInteger127", AssemblyConnectors_PWP_PWP_A_Array_Pattern_partB_LiteralInteger127);
						AddToElementRepository("LiteralUnlimitedNatural128", AssemblyConnectors_PWP_PWP_A_Array_Pattern_partB_LiteralUnlimitedNatural128);
					AddToElementRepository("partC", AssemblyConnectors_PWP_PWP_A_Array_Pattern_partC);
						AddToElementRepository("LiteralUnlimitedNatural129", AssemblyConnectors_PWP_PWP_A_Array_Pattern_partC_LiteralUnlimitedNatural129);
						AddToElementRepository("LiteralInteger130", AssemblyConnectors_PWP_PWP_A_Array_Pattern_partC_LiteralInteger130);
					AddToElementRepository("Comment131", AssemblyConnectors_PWP_PWP_A_Array_Pattern_Comment131);
					AddToElementRepository("r", AssemblyConnectors_PWP_PWP_A_Array_Pattern_r);
						AddToElementRepository("ConnectorEnd132", AssemblyConnectors_PWP_PWP_A_Array_Pattern_r_ConnectorEnd132);
							AddToElementRepository("connectorEnd_1_Lower", AssemblyConnectors_PWP_PWP_A_Array_Pattern_r_ConnectorEnd132_connectorEnd_1_Lower);
							AddToElementRepository("connectorEnd_1_Upper", AssemblyConnectors_PWP_PWP_A_Array_Pattern_r_ConnectorEnd132_connectorEnd_1_Upper);
						AddToElementRepository("ConnectorEnd133", AssemblyConnectors_PWP_PWP_A_Array_Pattern_r_ConnectorEnd133);
							AddToElementRepository("connectorEnd_2_Lower", AssemblyConnectors_PWP_PWP_A_Array_Pattern_r_ConnectorEnd133_connectorEnd_2_Lower);
							AddToElementRepository("connectorEnd_2_Upper", AssemblyConnectors_PWP_PWP_A_Array_Pattern_r_ConnectorEnd133_connectorEnd_2_Upper);
					AddToElementRepository("A_Array_Pattern_A_Array_Pattern", AssemblyConnectors_PWP_PWP_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern);
						AddToElementRepository("result", AssemblyConnectors_PWP_PWP_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result);
				AddToElementRepository("instantiate_A_Empty_Pattern", AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern);
					AddToElementRepository("a_Empty_Pattern_node", AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_a_Empty_Pattern_node);
					AddToElementRepository("A_Empty_Pattern()", AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern_);
						AddToElementRepository("target", AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__target);
							AddToElementRepository("LiteralInteger134", AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__target_LiteralInteger134);
							AddToElementRepository("LiteralUnlimitedNatural135", AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__target_LiteralUnlimitedNatural135);
						AddToElementRepository("result", AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__result);
							AddToElementRepository("LiteralInteger136", AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__result_LiteralInteger136);
							AddToElementRepository("LiteralInteger137", AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__result_LiteralInteger137);
							AddToElementRepository("LiteralUnlimitedNatural138", AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__result_LiteralUnlimitedNatural138);
					AddToElementRepository("ObjectFlow139", AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_ObjectFlow139);
						AddToElementRepository("LiteralInteger140", AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_ObjectFlow139_LiteralInteger140);
						AddToElementRepository("LiteralBoolean141", AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_ObjectFlow139_LiteralBoolean141);
					AddToElementRepository("a_Empty_Pattern", AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_a_Empty_Pattern);
					AddToElementRepository("Create A_Empty_Pattern", AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern);
						AddToElementRepository("result", AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result);
							AddToElementRepository("LiteralInteger142", AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result_LiteralInteger142);
							AddToElementRepository("LiteralUnlimitedNatural143", AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result_LiteralUnlimitedNatural143);
					AddToElementRepository("ObjectFlow144", AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_ObjectFlow144);
						AddToElementRepository("LiteralInteger145", AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_ObjectFlow144_LiteralInteger145);
						AddToElementRepository("LiteralBoolean146", AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_ObjectFlow144_LiteralBoolean146);
				AddToElementRepository("assert_A_Star_Pattern", AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern);
					AddToElementRepository("ObjectFlow147", AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_ObjectFlow147);
						AddToElementRepository("LiteralBoolean148", AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_ObjectFlow147_LiteralBoolean148);
						AddToElementRepository("LiteralInteger149", AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_ObjectFlow147_LiteralInteger149);
					AddToElementRepository("writeLine", AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine);
						AddToElementRepository("value", AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine_value);
							AddToElementRepository("LiteralInteger150", AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine_value_LiteralInteger150);
							AddToElementRepository("LiteralInteger151", AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine_value_LiteralInteger151);
							AddToElementRepository("LiteralUnlimitedNatural152", AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine_value_LiteralUnlimitedNatural152);
						AddToElementRepository("errorStatus", AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine_errorStatus);
							AddToElementRepository("LiteralInteger153", AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine_errorStatus_LiteralInteger153);
							AddToElementRepository("LiteralInteger154", AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine_errorStatus_LiteralInteger154);
							AddToElementRepository("LiteralUnlimitedNatural155", AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural155);
					AddToElementRepository("a_Star_Pattern_node", AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_a_Star_Pattern_node);
						AddToElementRepository("LiteralInteger156", AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_a_Star_Pattern_node_LiteralInteger156);
					AddToElementRepository("a_Star_Pattern", AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_a_Star_Pattern);
					AddToElementRepository("message", AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_message);
						AddToElementRepository("result", AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_message_result);
							AddToElementRepository("LiteralInteger157", AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_message_result_LiteralInteger157);
							AddToElementRepository("LiteralUnlimitedNatural158", AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_message_result_LiteralUnlimitedNatural158);
						AddToElementRepository("LiteralString159", AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_message_LiteralString159);
				AddToElementRepository("IImpl", AssemblyConnectors_PWP_PWP_IImpl);
					AddToElementRepository("I_Realization", AssemblyConnectors_PWP_PWP_IImpl_I_Realization);
				AddToElementRepository("I", AssemblyConnectors_PWP_PWP_I);
				AddToElementRepository("A_Empty_Pattern", AssemblyConnectors_PWP_PWP_A_Empty_Pattern);
					AddToElementRepository("partB", AssemblyConnectors_PWP_PWP_A_Empty_Pattern_partB);
						AddToElementRepository("LiteralInteger160", AssemblyConnectors_PWP_PWP_A_Empty_Pattern_partB_LiteralInteger160);
						AddToElementRepository("LiteralUnlimitedNatural161", AssemblyConnectors_PWP_PWP_A_Empty_Pattern_partB_LiteralUnlimitedNatural161);
					AddToElementRepository("partC", AssemblyConnectors_PWP_PWP_A_Empty_Pattern_partC);
						AddToElementRepository("LiteralInteger162", AssemblyConnectors_PWP_PWP_A_Empty_Pattern_partC_LiteralInteger162);
						AddToElementRepository("LiteralUnlimitedNatural163", AssemblyConnectors_PWP_PWP_A_Empty_Pattern_partC_LiteralUnlimitedNatural163);
					AddToElementRepository("A_Empty_Pattern_A_Empty_Pattern", AssemblyConnectors_PWP_PWP_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern);
						AddToElementRepository("result", AssemblyConnectors_PWP_PWP_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result);
					AddToElementRepository("r", AssemblyConnectors_PWP_PWP_A_Empty_Pattern_r);
						AddToElementRepository("ConnectorEnd164", AssemblyConnectors_PWP_PWP_A_Empty_Pattern_r_ConnectorEnd164);
							AddToElementRepository("connectorEnd_2_Upper", AssemblyConnectors_PWP_PWP_A_Empty_Pattern_r_ConnectorEnd164_connectorEnd_2_Upper);
							AddToElementRepository("connectorEnd_2_Lower", AssemblyConnectors_PWP_PWP_A_Empty_Pattern_r_ConnectorEnd164_connectorEnd_2_Lower);
						AddToElementRepository("ConnectorEnd165", AssemblyConnectors_PWP_PWP_A_Empty_Pattern_r_ConnectorEnd165);
							AddToElementRepository("connectorEnd_1_Upper", AssemblyConnectors_PWP_PWP_A_Empty_Pattern_r_ConnectorEnd165_connectorEnd_1_Upper);
							AddToElementRepository("connectorEnd_1_Lower", AssemblyConnectors_PWP_PWP_A_Empty_Pattern_r_ConnectorEnd165_connectorEnd_1_Lower);
					AddToElementRepository("Comment166", AssemblyConnectors_PWP_PWP_A_Empty_Pattern_Comment166);
				AddToElementRepository("instantiate_A_Star_Pattern", AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern);
					AddToElementRepository("A_Star_Pattern()", AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_A_Star_Pattern_);
						AddToElementRepository("target", AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__target);
							AddToElementRepository("LiteralUnlimitedNatural167", AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__target_LiteralUnlimitedNatural167);
							AddToElementRepository("LiteralInteger168", AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__target_LiteralInteger168);
						AddToElementRepository("result", AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__result);
							AddToElementRepository("LiteralInteger169", AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__result_LiteralInteger169);
							AddToElementRepository("LiteralUnlimitedNatural170", AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__result_LiteralUnlimitedNatural170);
							AddToElementRepository("LiteralInteger171", AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__result_LiteralInteger171);
					AddToElementRepository("ObjectFlow172", AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_ObjectFlow172);
						AddToElementRepository("LiteralBoolean173", AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_ObjectFlow172_LiteralBoolean173);
						AddToElementRepository("LiteralInteger174", AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_ObjectFlow172_LiteralInteger174);
					AddToElementRepository("a_Star_Pattern_node", AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_a_Star_Pattern_node);
					AddToElementRepository("a_Star_Pattern", AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_a_Star_Pattern);
					AddToElementRepository("ObjectFlow175", AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_ObjectFlow175);
						AddToElementRepository("LiteralBoolean176", AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_ObjectFlow175_LiteralBoolean176);
						AddToElementRepository("LiteralInteger177", AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_ObjectFlow175_LiteralInteger177);
					AddToElementRepository("Create A_Star_Pattern", AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern);
						AddToElementRepository("result", AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result);
							AddToElementRepository("LiteralUnlimitedNatural178", AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result_LiteralUnlimitedNatural178);
							AddToElementRepository("LiteralInteger179", AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result_LiteralInteger179);

			// Initialize public members
			/*
			 * Model AssemblyConnectors_PWP_PWP
			 */
			AssemblyConnectors_PWP_PWP.SetName("AssemblyConnectors_PWP_PWP");
			AssemblyConnectors_PWP_PWP.SetVisibility(VisibilityKind.public_);
				// Activity assert_A_Empty_Pattern
				AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern.SetName("assert_A_Empty_Pattern");
				AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Empty_Pattern
					AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_a_Empty_Pattern.SetName("a_Empty_Pattern");
					AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_a_Empty_Pattern.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_a_Empty_Pattern.SetType(AssemblyConnectors_PWP_PWP_A_Empty_Pattern);
				AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern.AddOwnedParameter(AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_a_Empty_Pattern);
					// ActivityParameterNode a_Empty_Pattern_node
					AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_a_Empty_Pattern_node.SetName("a_Empty_Pattern_node");
					AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_a_Empty_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_a_Empty_Pattern_node.SetParameter(AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_a_Empty_Pattern);
				AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern.AddNode(AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_a_Empty_Pattern_node);
					// ValueSpecificationAction message
					AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_message.SetName("message");
					AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_message.SetVisibility(VisibilityKind.public_);
						// LiteralString LiteralString6
						AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_message_LiteralString6.SetName("LiteralString6");
						AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_message_LiteralString6.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_message_LiteralString6.SetValue("Assertion currently not implemented for A_Empty_Pattern.");
					AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_message.SetValue(AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_message_LiteralString6);
						// OutputPin result
						AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_message_result.SetName("result");
						AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_message_result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_message.SetResult(AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_message_result);
				AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern.AddNode(AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_message);
					// CallBehaviorAction writeLine
					AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine.SetName("writeLine");
					AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine.SetVisibility(VisibilityKind.public_);
					
						// OutputPin errorStatus
						AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine_errorStatus.SetName("errorStatus");
						AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine_errorStatus.SetVisibility(VisibilityKind.public_);
						
						AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine_errorStatus.SetLower(0);
					AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine.AddResult(AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine_errorStatus);
					AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
						// InputPin value
						AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine_value.SetName("value");
						AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine_value.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine.AddArgument(AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine_value);
				AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern.AddNode(AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine);
					// ObjectFlow ObjectFlow1 from result to value
					AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_ObjectFlow1.SetName("ObjectFlow1");
					AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_ObjectFlow1.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_ObjectFlow1.SetSource(AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_message_result);
					AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_ObjectFlow1.SetTarget(AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_writeLine_value);
						// LiteralBoolean LiteralBoolean3
						AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_ObjectFlow1_LiteralBoolean3.SetName("LiteralBoolean3");
						AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_ObjectFlow1_LiteralBoolean3.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_ObjectFlow1_LiteralBoolean3.SetValue(true);
					AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_ObjectFlow1.SetGuard(AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_ObjectFlow1_LiteralBoolean3);
				AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern.AddEdge(AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern_ObjectFlow1);
			AssemblyConnectors_PWP_PWP.AddPackagedElement(AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern);
				// Association R
				AssemblyConnectors_PWP_PWP_R.SetName("R");
				AssemblyConnectors_PWP_PWP_R.SetVisibility(VisibilityKind.public_);
				AssemblyConnectors_PWP_PWP_R.AddOwnedEnd(AssemblyConnectors_PWP_PWP_R_x);
				AssemblyConnectors_PWP_PWP_R.AddOwnedEnd(AssemblyConnectors_PWP_PWP_R_y);
			AssemblyConnectors_PWP_PWP.AddPackagedElement(AssemblyConnectors_PWP_PWP_R);
				// Activity instantiate_A_Array_Pattern
				AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern.SetName("instantiate_A_Array_Pattern");
				AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Array_Pattern
					AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_a_Array_Pattern.SetName("a_Array_Pattern");
					AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_a_Array_Pattern.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_a_Array_Pattern.SetType(AssemblyConnectors_PWP_PWP_A_Array_Pattern);
					AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_a_Array_Pattern.SetDirection(ParameterDirectionKind.return_);
				AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern.AddOwnedParameter(AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_a_Array_Pattern);
					// CreateObjectAction Create A_Array_Pattern
					AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern.SetName("Create A_Array_Pattern");
					AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern.SetClassifier(AssemblyConnectors_PWP_PWP_A_Array_Pattern);
						// OutputPin result
						AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result.SetName("result");
						AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result.SetType(AssemblyConnectors_PWP_PWP_A_Array_Pattern);
					AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern.SetResult(AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result);
				AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern.AddNode(AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern);
					// CallOperationAction A_Array_Pattern()
					AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_A_Array_Pattern_.SetName("A_Array_Pattern()");
					AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_A_Array_Pattern_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__result.SetName("result");
						AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__result.SetType(AssemblyConnectors_PWP_PWP_A_Array_Pattern);
					AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_A_Array_Pattern_.AddResult(AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__result);
					AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_A_Array_Pattern_.SetOperation(AssemblyConnectors_PWP_PWP_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern);
						// InputPin target
						AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__target.SetName("target");
						AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__target.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__target.SetType(AssemblyConnectors_PWP_PWP_A_Array_Pattern);
					AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_A_Array_Pattern_.SetTarget(AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__target);
				AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern.AddNode(AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_A_Array_Pattern_);
					// ActivityParameterNode a_Array_Pattern_node
					AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_a_Array_Pattern_node.SetName("a_Array_Pattern_node");
					AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_a_Array_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_a_Array_Pattern_node.SetParameter(AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_a_Array_Pattern);
				AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern.AddNode(AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_a_Array_Pattern_node);
					// ObjectFlow ObjectFlow17 from result to a_Array_Pattern_node
					AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_ObjectFlow17.SetName("ObjectFlow17");
					AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_ObjectFlow17.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_ObjectFlow17.SetSource(AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__result);
					AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_ObjectFlow17.SetTarget(AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_a_Array_Pattern_node);
						// LiteralBoolean LiteralBoolean19
						AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_ObjectFlow17_LiteralBoolean19.SetName("LiteralBoolean19");
						AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_ObjectFlow17_LiteralBoolean19.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_ObjectFlow17_LiteralBoolean19.SetValue(true);
					AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_ObjectFlow17.SetGuard(AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_ObjectFlow17_LiteralBoolean19);
				AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern.AddEdge(AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_ObjectFlow17);
					// ObjectFlow ObjectFlow27 from result to target
					AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_ObjectFlow27.SetName("ObjectFlow27");
					AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_ObjectFlow27.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_ObjectFlow27.SetSource(AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result);
					AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_ObjectFlow27.SetTarget(AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__target);
						// LiteralBoolean LiteralBoolean29
						AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_ObjectFlow27_LiteralBoolean29.SetName("LiteralBoolean29");
						AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_ObjectFlow27_LiteralBoolean29.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_ObjectFlow27_LiteralBoolean29.SetValue(true);
					AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_ObjectFlow27.SetGuard(AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_ObjectFlow27_LiteralBoolean29);
				AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern.AddEdge(AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern_ObjectFlow27);
			AssemblyConnectors_PWP_PWP.AddPackagedElement(AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern);
				// Class C
				AssemblyConnectors_PWP_PWP_C.SetName("C");
				AssemblyConnectors_PWP_PWP_C.SetVisibility(VisibilityKind.public_);
				
					// Port q
					AssemblyConnectors_PWP_PWP_C_q.SetName("q");
					AssemblyConnectors_PWP_PWP_C_q.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_PWP_C_q.SetUpper(-1);
					AssemblyConnectors_PWP_PWP_C_q.SetType(AssemblyConnectors_PWP_PWP_IImpl);
					AssemblyConnectors_PWP_PWP_C_q.SetAggregation(AggregationKind.composite);
					AssemblyConnectors_PWP_PWP_C_q.isService = true;
					AssemblyConnectors_PWP_PWP_C_q.AddProvided(AssemblyConnectors_PWP_PWP_I);
				AssemblyConnectors_PWP_PWP_C.AddOwnedAttribute(AssemblyConnectors_PWP_PWP_C_q);
			AssemblyConnectors_PWP_PWP.AddPackagedElement(AssemblyConnectors_PWP_PWP_C);
				// Class B
				AssemblyConnectors_PWP_PWP_B.SetName("B");
				AssemblyConnectors_PWP_PWP_B.SetVisibility(VisibilityKind.public_);
				
					// Port p
					AssemblyConnectors_PWP_PWP_B_p.SetName("p");
					AssemblyConnectors_PWP_PWP_B_p.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_PWP_B_p.SetUpper(-1);
					AssemblyConnectors_PWP_PWP_B_p.SetLower(2);
					AssemblyConnectors_PWP_PWP_B_p.SetType(AssemblyConnectors_PWP_PWP_IImpl);
					AssemblyConnectors_PWP_PWP_B_p.SetAggregation(AggregationKind.composite);
					AssemblyConnectors_PWP_PWP_B_p.isService = true;
					AssemblyConnectors_PWP_PWP_B_p.AddProvided(AssemblyConnectors_PWP_PWP_I);
				AssemblyConnectors_PWP_PWP_B.AddOwnedAttribute(AssemblyConnectors_PWP_PWP_B_p);
			AssemblyConnectors_PWP_PWP.AddPackagedElement(AssemblyConnectors_PWP_PWP_B);
				// Activity instantiate_A_Unconnected_Pattern
				AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern.SetName("instantiate_A_Unconnected_Pattern");
				AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Unconnected_Pattern
					AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetName("a_Unconnected_Pattern");
					AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetType(AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern);
					AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetDirection(ParameterDirectionKind.return_);
				AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern.AddOwnedParameter(AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern);
					// CreateObjectAction Create A_Unconnected_Pattern
					AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern.SetName("Create A_Unconnected_Pattern");
					AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern.SetClassifier(AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern);
						// OutputPin result
						AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result.SetName("result");
						AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result.SetType(AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern);
					AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern.SetResult(AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result);
				AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern.AddNode(AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern);
					// ActivityParameterNode a_Unconnected_Pattern_node
					AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node.SetName("a_Unconnected_Pattern_node");
					AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node.SetParameter(AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern);
				AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern.AddNode(AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node);
					// CallOperationAction A_Unconnected_Pattern()
					AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_.SetName("A_Unconnected_Pattern()");
					AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result.SetName("result");
						AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result.SetType(AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern);
					AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_.AddResult(AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result);
					AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_.SetOperation(AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern);
						// InputPin target
						AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target.SetName("target");
						AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target.SetType(AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern);
					AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_.SetTarget(AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target);
				AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern.AddNode(AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_);
					// ObjectFlow ObjectFlow42 from result to a_Unconnected_Pattern_node
					AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow42.SetName("ObjectFlow42");
					AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow42.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow42.SetSource(AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result);
					AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow42.SetTarget(AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node);
						// LiteralBoolean LiteralBoolean44
						AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow42_LiteralBoolean44.SetName("LiteralBoolean44");
						AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow42_LiteralBoolean44.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow42_LiteralBoolean44.SetValue(true);
					AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow42.SetGuard(AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow42_LiteralBoolean44);
				AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern.AddEdge(AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow42);
					// ObjectFlow ObjectFlow45 from result to target
					AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow45.SetName("ObjectFlow45");
					AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow45.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow45.SetSource(AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result);
					AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow45.SetTarget(AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target);
						// LiteralBoolean LiteralBoolean46
						AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow45_LiteralBoolean46.SetName("LiteralBoolean46");
						AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow45_LiteralBoolean46.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow45_LiteralBoolean46.SetValue(true);
					AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow45.SetGuard(AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow45_LiteralBoolean46);
				AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern.AddEdge(AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow45);
			AssemblyConnectors_PWP_PWP.AddPackagedElement(AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern);
				// Class A_Star_Pattern
				AssemblyConnectors_PWP_PWP_A_Star_Pattern.SetName("A_Star_Pattern");
				AssemblyConnectors_PWP_PWP_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Property partB
					AssemblyConnectors_PWP_PWP_A_Star_Pattern_partB.SetName("partB");
					AssemblyConnectors_PWP_PWP_A_Star_Pattern_partB.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_PWP_A_Star_Pattern_partB.SetUpper(-1);
					AssemblyConnectors_PWP_PWP_A_Star_Pattern_partB.SetLower(2);
					AssemblyConnectors_PWP_PWP_A_Star_Pattern_partB.SetType(AssemblyConnectors_PWP_PWP_B);
					AssemblyConnectors_PWP_PWP_A_Star_Pattern_partB.SetAggregation(AggregationKind.composite);
				AssemblyConnectors_PWP_PWP_A_Star_Pattern.AddOwnedAttribute(AssemblyConnectors_PWP_PWP_A_Star_Pattern_partB);
					// Property partC
					AssemblyConnectors_PWP_PWP_A_Star_Pattern_partC.SetName("partC");
					AssemblyConnectors_PWP_PWP_A_Star_Pattern_partC.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_PWP_A_Star_Pattern_partC.SetUpper(-1);
					AssemblyConnectors_PWP_PWP_A_Star_Pattern_partC.SetLower(5);
					AssemblyConnectors_PWP_PWP_A_Star_Pattern_partC.SetType(AssemblyConnectors_PWP_PWP_C);
					AssemblyConnectors_PWP_PWP_A_Star_Pattern_partC.SetAggregation(AggregationKind.composite);
				AssemblyConnectors_PWP_PWP_A_Star_Pattern.AddOwnedAttribute(AssemblyConnectors_PWP_PWP_A_Star_Pattern_partC);
				
				AssemblyConnectors_PWP_PWP_A_Star_Pattern_r.SetName("r");
					AssemblyConnectors_PWP_PWP_A_Star_Pattern_r.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_A_Star_Pattern_r_ConnectorEnd52.SetUpper(-1);
						AssemblyConnectors_PWP_PWP_A_Star_Pattern_r_ConnectorEnd52.SetLower(4);
						AssemblyConnectors_PWP_PWP_A_Star_Pattern_r_ConnectorEnd52.SetRole(AssemblyConnectors_PWP_PWP_B_p);
						AssemblyConnectors_PWP_PWP_A_Star_Pattern_r_ConnectorEnd52.SetPartWithPort(AssemblyConnectors_PWP_PWP_A_Star_Pattern_partB);
						
					AssemblyConnectors_PWP_PWP_A_Star_Pattern_r.AddEnd(AssemblyConnectors_PWP_PWP_A_Star_Pattern_r_ConnectorEnd52);
						AssemblyConnectors_PWP_PWP_A_Star_Pattern_r_ConnectorEnd51.SetUpper(-1);
						AssemblyConnectors_PWP_PWP_A_Star_Pattern_r_ConnectorEnd51.SetLower(5);
						AssemblyConnectors_PWP_PWP_A_Star_Pattern_r_ConnectorEnd51.SetRole(AssemblyConnectors_PWP_PWP_C_q);
						AssemblyConnectors_PWP_PWP_A_Star_Pattern_r_ConnectorEnd51.SetPartWithPort(AssemblyConnectors_PWP_PWP_A_Star_Pattern_partC);
						
					AssemblyConnectors_PWP_PWP_A_Star_Pattern_r.AddEnd(AssemblyConnectors_PWP_PWP_A_Star_Pattern_r_ConnectorEnd51);
					AssemblyConnectors_PWP_PWP_A_Star_Pattern_r.SetType(AssemblyConnectors_PWP_PWP_R);
				AssemblyConnectors_PWP_PWP_A_Star_Pattern.AddOwnedConnector(AssemblyConnectors_PWP_PWP_A_Star_Pattern_r);
					// Operation A_Star_Pattern_A_Star_Pattern
					AssemblyConnectors_PWP_PWP_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern.SetName("A_Star_Pattern_A_Star_Pattern");
					AssemblyConnectors_PWP_PWP_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
						// Parameter result
						AssemblyConnectors_PWP_PWP_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result.SetName("result");
						AssemblyConnectors_PWP_PWP_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result.SetVisibility(VisibilityKind.public_);
						
						AssemblyConnectors_PWP_PWP_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result.SetType(AssemblyConnectors_PWP_PWP_A_Star_Pattern);
						AssemblyConnectors_PWP_PWP_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result.SetDirection(ParameterDirectionKind.return_);
					AssemblyConnectors_PWP_PWP_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern.AddOwnedParameter(AssemblyConnectors_PWP_PWP_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result);
					AssemblyConnectors_PWP_PWP_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				AssemblyConnectors_PWP_PWP_A_Star_Pattern.AddOwnedOperation(AssemblyConnectors_PWP_PWP_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern);
			AssemblyConnectors_PWP_PWP.AddPackagedElement(AssemblyConnectors_PWP_PWP_A_Star_Pattern);
				// Activity assert_A_Unconnected_Pattern
				AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern.SetName("assert_A_Unconnected_Pattern");
				AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Unconnected_Pattern
					AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_a_Unconnected_Pattern.SetName("a_Unconnected_Pattern");
					AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_a_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_a_Unconnected_Pattern.SetType(AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern);
				AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern.AddOwnedParameter(AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_a_Unconnected_Pattern);
					// CallBehaviorAction writeLine
					AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine.SetName("writeLine");
					AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine.SetVisibility(VisibilityKind.public_);
					
						// OutputPin errorStatus
						AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine_errorStatus.SetName("errorStatus");
						AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine_errorStatus.SetVisibility(VisibilityKind.public_);
						
						AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine_errorStatus.SetLower(0);
					AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine.AddResult(AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine_errorStatus);
					AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
						// InputPin value
						AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine_value.SetName("value");
						AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine_value.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine.AddArgument(AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine_value);
				AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern.AddNode(AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine);
					// ActivityParameterNode a_Unconnected_Pattern_node
					AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node.SetName("a_Unconnected_Pattern_node");
					AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node.SetParameter(AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_a_Unconnected_Pattern);
				AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern.AddNode(AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node);
					// ValueSpecificationAction message
					AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_message.SetName("message");
					AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_message.SetVisibility(VisibilityKind.public_);
						// LiteralString LiteralString65
						AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_message_LiteralString65.SetName("LiteralString65");
						AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_message_LiteralString65.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_message_LiteralString65.SetValue("Assertion currently not implemented for A_Unconnected_Pattern.");
					AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_message.SetValue(AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_message_LiteralString65);
						// OutputPin result
						AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_message_result.SetName("result");
						AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_message_result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_message.SetResult(AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_message_result);
				AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern.AddNode(AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_message);
					// ObjectFlow ObjectFlow61 from result to value
					AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_ObjectFlow61.SetName("ObjectFlow61");
					AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_ObjectFlow61.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_ObjectFlow61.SetSource(AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_message_result);
					AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_ObjectFlow61.SetTarget(AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_writeLine_value);
						// LiteralBoolean LiteralBoolean63
						AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_ObjectFlow61_LiteralBoolean63.SetName("LiteralBoolean63");
						AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_ObjectFlow61_LiteralBoolean63.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_ObjectFlow61_LiteralBoolean63.SetValue(true);
					AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_ObjectFlow61.SetGuard(AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_ObjectFlow61_LiteralBoolean63);
				AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern.AddEdge(AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern_ObjectFlow61);
			AssemblyConnectors_PWP_PWP.AddPackagedElement(AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern);
				// Activity assert_A_Array_Pattern
				AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern.SetName("assert_A_Array_Pattern");
				AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Array_Pattern
					AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_a_Array_Pattern.SetName("a_Array_Pattern");
					AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_a_Array_Pattern.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_a_Array_Pattern.SetType(AssemblyConnectors_PWP_PWP_A_Array_Pattern);
				AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern.AddOwnedParameter(AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_a_Array_Pattern);
					// ActivityParameterNode a_Array_Pattern_node
					AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_a_Array_Pattern_node.SetName("a_Array_Pattern_node");
					AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_a_Array_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_a_Array_Pattern_node.SetParameter(AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_a_Array_Pattern);
				AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern.AddNode(AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_a_Array_Pattern_node);
					// ValueSpecificationAction message
					AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_message.SetName("message");
					AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_message.SetVisibility(VisibilityKind.public_);
						// LiteralString LiteralString69
						AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_message_LiteralString69.SetName("LiteralString69");
						AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_message_LiteralString69.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_message_LiteralString69.SetValue("Assertion currently not implemented for A_Array_Pattern.");
					AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_message.SetValue(AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_message_LiteralString69);
						// OutputPin result
						AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_message_result.SetName("result");
						AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_message_result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_message.SetResult(AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_message_result);
				AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern.AddNode(AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_message);
					// CallBehaviorAction writeLine
					AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine.SetName("writeLine");
					AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine.SetVisibility(VisibilityKind.public_);
					
						// OutputPin errorStatus
						AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine_errorStatus.SetName("errorStatus");
						AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine_errorStatus.SetVisibility(VisibilityKind.public_);
						
						AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine_errorStatus.SetLower(0);
					AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine.AddResult(AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine_errorStatus);
					AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
						// InputPin value
						AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine_value.SetName("value");
						AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine_value.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine.AddArgument(AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine_value);
				AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern.AddNode(AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine);
					// ObjectFlow ObjectFlow78 from result to value
					AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_ObjectFlow78.SetName("ObjectFlow78");
					AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_ObjectFlow78.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_ObjectFlow78.SetSource(AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_message_result);
					AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_ObjectFlow78.SetTarget(AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_writeLine_value);
						// LiteralBoolean LiteralBoolean79
						AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_ObjectFlow78_LiteralBoolean79.SetName("LiteralBoolean79");
						AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_ObjectFlow78_LiteralBoolean79.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_ObjectFlow78_LiteralBoolean79.SetValue(true);
					AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_ObjectFlow78.SetGuard(AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_ObjectFlow78_LiteralBoolean79);
				AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern.AddEdge(AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern_ObjectFlow78);
			AssemblyConnectors_PWP_PWP.AddPackagedElement(AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern);
				// Activity main
				AssemblyConnectors_PWP_PWP_main.SetName("main");
				AssemblyConnectors_PWP_PWP_main.SetVisibility(VisibilityKind.public_);
					// CallBehaviorAction instantiate_A_Array_Pattern
					AssemblyConnectors_PWP_PWP_main_instantiate_A_Array_Pattern.SetName("instantiate_A_Array_Pattern");
					AssemblyConnectors_PWP_PWP_main_instantiate_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
					
						// OutputPin a_Array_Pattern
						AssemblyConnectors_PWP_PWP_main_instantiate_A_Array_Pattern_a_Array_Pattern.SetName("a_Array_Pattern");
						AssemblyConnectors_PWP_PWP_main_instantiate_A_Array_Pattern_a_Array_Pattern.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_main_instantiate_A_Array_Pattern_a_Array_Pattern.SetType(AssemblyConnectors_PWP_PWP_A_Array_Pattern);
					AssemblyConnectors_PWP_PWP_main_instantiate_A_Array_Pattern.AddResult(AssemblyConnectors_PWP_PWP_main_instantiate_A_Array_Pattern_a_Array_Pattern);
					AssemblyConnectors_PWP_PWP_main_instantiate_A_Array_Pattern.SetBehavior(AssemblyConnectors_PWP_PWP_instantiate_A_Array_Pattern);
				AssemblyConnectors_PWP_PWP_main.AddNode(AssemblyConnectors_PWP_PWP_main_instantiate_A_Array_Pattern);
					// CallBehaviorAction assert_A_Array_Pattern
					AssemblyConnectors_PWP_PWP_main_assert_A_Array_Pattern.SetName("assert_A_Array_Pattern");
					AssemblyConnectors_PWP_PWP_main_assert_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_PWP_main_assert_A_Array_Pattern.SetBehavior(AssemblyConnectors_PWP_PWP_assert_A_Array_Pattern);
						// InputPin a_Array_Pattern
						AssemblyConnectors_PWP_PWP_main_assert_A_Array_Pattern_a_Array_Pattern.SetName("a_Array_Pattern");
						AssemblyConnectors_PWP_PWP_main_assert_A_Array_Pattern_a_Array_Pattern.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_main_assert_A_Array_Pattern_a_Array_Pattern.SetType(AssemblyConnectors_PWP_PWP_A_Array_Pattern);
					AssemblyConnectors_PWP_PWP_main_assert_A_Array_Pattern.AddArgument(AssemblyConnectors_PWP_PWP_main_assert_A_Array_Pattern_a_Array_Pattern);
				AssemblyConnectors_PWP_PWP_main.AddNode(AssemblyConnectors_PWP_PWP_main_assert_A_Array_Pattern);
					// CallBehaviorAction assert_A_Empty_Pattern
					AssemblyConnectors_PWP_PWP_main_assert_A_Empty_Pattern.SetName("assert_A_Empty_Pattern");
					AssemblyConnectors_PWP_PWP_main_assert_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_PWP_main_assert_A_Empty_Pattern.SetBehavior(AssemblyConnectors_PWP_PWP_assert_A_Empty_Pattern);
						// InputPin a_Empty_Pattern
						AssemblyConnectors_PWP_PWP_main_assert_A_Empty_Pattern_a_Empty_Pattern.SetName("a_Empty_Pattern");
						AssemblyConnectors_PWP_PWP_main_assert_A_Empty_Pattern_a_Empty_Pattern.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_main_assert_A_Empty_Pattern_a_Empty_Pattern.SetType(AssemblyConnectors_PWP_PWP_A_Empty_Pattern);
					AssemblyConnectors_PWP_PWP_main_assert_A_Empty_Pattern.AddArgument(AssemblyConnectors_PWP_PWP_main_assert_A_Empty_Pattern_a_Empty_Pattern);
				AssemblyConnectors_PWP_PWP_main.AddNode(AssemblyConnectors_PWP_PWP_main_assert_A_Empty_Pattern);
					// CallBehaviorAction instantiate_A_Star_Pattern
					AssemblyConnectors_PWP_PWP_main_instantiate_A_Star_Pattern.SetName("instantiate_A_Star_Pattern");
					AssemblyConnectors_PWP_PWP_main_instantiate_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
					
						// OutputPin a_Star_Pattern
						AssemblyConnectors_PWP_PWP_main_instantiate_A_Star_Pattern_a_Star_Pattern.SetName("a_Star_Pattern");
						AssemblyConnectors_PWP_PWP_main_instantiate_A_Star_Pattern_a_Star_Pattern.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_main_instantiate_A_Star_Pattern_a_Star_Pattern.SetType(AssemblyConnectors_PWP_PWP_A_Star_Pattern);
					AssemblyConnectors_PWP_PWP_main_instantiate_A_Star_Pattern.AddResult(AssemblyConnectors_PWP_PWP_main_instantiate_A_Star_Pattern_a_Star_Pattern);
					AssemblyConnectors_PWP_PWP_main_instantiate_A_Star_Pattern.SetBehavior(AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern);
				AssemblyConnectors_PWP_PWP_main.AddNode(AssemblyConnectors_PWP_PWP_main_instantiate_A_Star_Pattern);
					// CallBehaviorAction instantiate_A_Empty_Pattern
					AssemblyConnectors_PWP_PWP_main_instantiate_A_Empty_Pattern.SetName("instantiate_A_Empty_Pattern");
					AssemblyConnectors_PWP_PWP_main_instantiate_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
					
						// OutputPin a_Empty_Pattern
						AssemblyConnectors_PWP_PWP_main_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetName("a_Empty_Pattern");
						AssemblyConnectors_PWP_PWP_main_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_main_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetType(AssemblyConnectors_PWP_PWP_A_Empty_Pattern);
					AssemblyConnectors_PWP_PWP_main_instantiate_A_Empty_Pattern.AddResult(AssemblyConnectors_PWP_PWP_main_instantiate_A_Empty_Pattern_a_Empty_Pattern);
					AssemblyConnectors_PWP_PWP_main_instantiate_A_Empty_Pattern.SetBehavior(AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern);
				AssemblyConnectors_PWP_PWP_main.AddNode(AssemblyConnectors_PWP_PWP_main_instantiate_A_Empty_Pattern);
					// CallBehaviorAction instantiate_A_Unconnected_Pattern
					AssemblyConnectors_PWP_PWP_main_instantiate_A_Unconnected_Pattern.SetName("instantiate_A_Unconnected_Pattern");
					AssemblyConnectors_PWP_PWP_main_instantiate_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
					
						// OutputPin a_Unconnected_Pattern
						AssemblyConnectors_PWP_PWP_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetName("a_Unconnected_Pattern");
						AssemblyConnectors_PWP_PWP_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetType(AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern);
					AssemblyConnectors_PWP_PWP_main_instantiate_A_Unconnected_Pattern.AddResult(AssemblyConnectors_PWP_PWP_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern);
					AssemblyConnectors_PWP_PWP_main_instantiate_A_Unconnected_Pattern.SetBehavior(AssemblyConnectors_PWP_PWP_instantiate_A_Unconnected_Pattern);
				AssemblyConnectors_PWP_PWP_main.AddNode(AssemblyConnectors_PWP_PWP_main_instantiate_A_Unconnected_Pattern);
					// CallBehaviorAction assert_A_Star_Pattern
					AssemblyConnectors_PWP_PWP_main_assert_A_Star_Pattern.SetName("assert_A_Star_Pattern");
					AssemblyConnectors_PWP_PWP_main_assert_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_PWP_main_assert_A_Star_Pattern.SetBehavior(AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern);
						// InputPin a_Star_Pattern
						AssemblyConnectors_PWP_PWP_main_assert_A_Star_Pattern_a_Star_Pattern.SetName("a_Star_Pattern");
						AssemblyConnectors_PWP_PWP_main_assert_A_Star_Pattern_a_Star_Pattern.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_main_assert_A_Star_Pattern_a_Star_Pattern.SetType(AssemblyConnectors_PWP_PWP_A_Star_Pattern);
					AssemblyConnectors_PWP_PWP_main_assert_A_Star_Pattern.AddArgument(AssemblyConnectors_PWP_PWP_main_assert_A_Star_Pattern_a_Star_Pattern);
				AssemblyConnectors_PWP_PWP_main.AddNode(AssemblyConnectors_PWP_PWP_main_assert_A_Star_Pattern);
					// CallBehaviorAction assert_A_Unconnected_Pattern
					AssemblyConnectors_PWP_PWP_main_assert_A_Unconnected_Pattern.SetName("assert_A_Unconnected_Pattern");
					AssemblyConnectors_PWP_PWP_main_assert_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_PWP_main_assert_A_Unconnected_Pattern.SetBehavior(AssemblyConnectors_PWP_PWP_assert_A_Unconnected_Pattern);
						// InputPin a_Unconnected_Pattern
						AssemblyConnectors_PWP_PWP_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern.SetName("a_Unconnected_Pattern");
						AssemblyConnectors_PWP_PWP_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern.SetType(AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern);
					AssemblyConnectors_PWP_PWP_main_assert_A_Unconnected_Pattern.AddArgument(AssemblyConnectors_PWP_PWP_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern);
				AssemblyConnectors_PWP_PWP_main.AddNode(AssemblyConnectors_PWP_PWP_main_assert_A_Unconnected_Pattern);
					// ControlFlow ControlFlow108 from assert_A_Array_Pattern to instantiate_A_Star_Pattern
					AssemblyConnectors_PWP_PWP_main_ControlFlow108.SetName("ControlFlow108");
					AssemblyConnectors_PWP_PWP_main_ControlFlow108.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_main_ControlFlow108.SetSource(AssemblyConnectors_PWP_PWP_main_assert_A_Array_Pattern);
					AssemblyConnectors_PWP_PWP_main_ControlFlow108.SetTarget(AssemblyConnectors_PWP_PWP_main_instantiate_A_Star_Pattern);
				AssemblyConnectors_PWP_PWP_main.AddEdge(AssemblyConnectors_PWP_PWP_main_ControlFlow108);
					// ObjectFlow ObjectFlow81 from a_Unconnected_Pattern to a_Unconnected_Pattern
					AssemblyConnectors_PWP_PWP_main_ObjectFlow81.SetName("ObjectFlow81");
					AssemblyConnectors_PWP_PWP_main_ObjectFlow81.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_main_ObjectFlow81.SetSource(AssemblyConnectors_PWP_PWP_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern);
					AssemblyConnectors_PWP_PWP_main_ObjectFlow81.SetTarget(AssemblyConnectors_PWP_PWP_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern);
						// LiteralBoolean LiteralBoolean82
						AssemblyConnectors_PWP_PWP_main_ObjectFlow81_LiteralBoolean82.SetName("LiteralBoolean82");
						AssemblyConnectors_PWP_PWP_main_ObjectFlow81_LiteralBoolean82.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_main_ObjectFlow81_LiteralBoolean82.SetValue(true);
					AssemblyConnectors_PWP_PWP_main_ObjectFlow81.SetGuard(AssemblyConnectors_PWP_PWP_main_ObjectFlow81_LiteralBoolean82);
				AssemblyConnectors_PWP_PWP_main.AddEdge(AssemblyConnectors_PWP_PWP_main_ObjectFlow81);
					// ObjectFlow ObjectFlow87 from a_Empty_Pattern to a_Empty_Pattern
					AssemblyConnectors_PWP_PWP_main_ObjectFlow87.SetName("ObjectFlow87");
					AssemblyConnectors_PWP_PWP_main_ObjectFlow87.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_main_ObjectFlow87.SetSource(AssemblyConnectors_PWP_PWP_main_instantiate_A_Empty_Pattern_a_Empty_Pattern);
					AssemblyConnectors_PWP_PWP_main_ObjectFlow87.SetTarget(AssemblyConnectors_PWP_PWP_main_assert_A_Empty_Pattern_a_Empty_Pattern);
						// LiteralBoolean LiteralBoolean89
						AssemblyConnectors_PWP_PWP_main_ObjectFlow87_LiteralBoolean89.SetName("LiteralBoolean89");
						AssemblyConnectors_PWP_PWP_main_ObjectFlow87_LiteralBoolean89.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_main_ObjectFlow87_LiteralBoolean89.SetValue(true);
					AssemblyConnectors_PWP_PWP_main_ObjectFlow87.SetGuard(AssemblyConnectors_PWP_PWP_main_ObjectFlow87_LiteralBoolean89);
				AssemblyConnectors_PWP_PWP_main.AddEdge(AssemblyConnectors_PWP_PWP_main_ObjectFlow87);
					// ControlFlow ControlFlow109 from assert_A_Empty_Pattern to instantiate_A_Unconnected_Pattern
					AssemblyConnectors_PWP_PWP_main_ControlFlow109.SetName("ControlFlow109");
					AssemblyConnectors_PWP_PWP_main_ControlFlow109.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_main_ControlFlow109.SetSource(AssemblyConnectors_PWP_PWP_main_assert_A_Empty_Pattern);
					AssemblyConnectors_PWP_PWP_main_ControlFlow109.SetTarget(AssemblyConnectors_PWP_PWP_main_instantiate_A_Unconnected_Pattern);
				AssemblyConnectors_PWP_PWP_main.AddEdge(AssemblyConnectors_PWP_PWP_main_ControlFlow109);
					// ControlFlow ControlFlow110 from assert_A_Unconnected_Pattern to instantiate_A_Array_Pattern
					AssemblyConnectors_PWP_PWP_main_ControlFlow110.SetName("ControlFlow110");
					AssemblyConnectors_PWP_PWP_main_ControlFlow110.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_main_ControlFlow110.SetSource(AssemblyConnectors_PWP_PWP_main_assert_A_Unconnected_Pattern);
					AssemblyConnectors_PWP_PWP_main_ControlFlow110.SetTarget(AssemblyConnectors_PWP_PWP_main_instantiate_A_Array_Pattern);
				AssemblyConnectors_PWP_PWP_main.AddEdge(AssemblyConnectors_PWP_PWP_main_ControlFlow110);
					// ObjectFlow ObjectFlow117 from a_Star_Pattern to a_Star_Pattern
					AssemblyConnectors_PWP_PWP_main_ObjectFlow117.SetName("ObjectFlow117");
					AssemblyConnectors_PWP_PWP_main_ObjectFlow117.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_main_ObjectFlow117.SetSource(AssemblyConnectors_PWP_PWP_main_instantiate_A_Star_Pattern_a_Star_Pattern);
					AssemblyConnectors_PWP_PWP_main_ObjectFlow117.SetTarget(AssemblyConnectors_PWP_PWP_main_assert_A_Star_Pattern_a_Star_Pattern);
						// LiteralBoolean LiteralBoolean119
						AssemblyConnectors_PWP_PWP_main_ObjectFlow117_LiteralBoolean119.SetName("LiteralBoolean119");
						AssemblyConnectors_PWP_PWP_main_ObjectFlow117_LiteralBoolean119.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_main_ObjectFlow117_LiteralBoolean119.SetValue(true);
					AssemblyConnectors_PWP_PWP_main_ObjectFlow117.SetGuard(AssemblyConnectors_PWP_PWP_main_ObjectFlow117_LiteralBoolean119);
				AssemblyConnectors_PWP_PWP_main.AddEdge(AssemblyConnectors_PWP_PWP_main_ObjectFlow117);
					// ObjectFlow ObjectFlow105 from a_Array_Pattern to a_Array_Pattern
					AssemblyConnectors_PWP_PWP_main_ObjectFlow105.SetName("ObjectFlow105");
					AssemblyConnectors_PWP_PWP_main_ObjectFlow105.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_main_ObjectFlow105.SetSource(AssemblyConnectors_PWP_PWP_main_instantiate_A_Array_Pattern_a_Array_Pattern);
					AssemblyConnectors_PWP_PWP_main_ObjectFlow105.SetTarget(AssemblyConnectors_PWP_PWP_main_assert_A_Array_Pattern_a_Array_Pattern);
						// LiteralBoolean LiteralBoolean106
						AssemblyConnectors_PWP_PWP_main_ObjectFlow105_LiteralBoolean106.SetName("LiteralBoolean106");
						AssemblyConnectors_PWP_PWP_main_ObjectFlow105_LiteralBoolean106.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_main_ObjectFlow105_LiteralBoolean106.SetValue(true);
					AssemblyConnectors_PWP_PWP_main_ObjectFlow105.SetGuard(AssemblyConnectors_PWP_PWP_main_ObjectFlow105_LiteralBoolean106);
				AssemblyConnectors_PWP_PWP_main.AddEdge(AssemblyConnectors_PWP_PWP_main_ObjectFlow105);
			AssemblyConnectors_PWP_PWP.AddPackagedElement(AssemblyConnectors_PWP_PWP_main);
				// Class A_Unconnected_Pattern
				AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern.SetName("A_Unconnected_Pattern");
				AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Property partB
					AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_partB.SetName("partB");
					AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_partB.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_partB.SetUpper(-1);
					AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_partB.SetLower(2);
					AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_partB.SetType(AssemblyConnectors_PWP_PWP_B);
					AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_partB.SetAggregation(AggregationKind.composite);
				AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern.AddOwnedAttribute(AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_partB);
					// Property partC
					AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_partC.SetName("partC");
					AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_partC.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_partC.SetUpper(-1);
					AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_partC.SetLower(3);
					AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_partC.SetType(AssemblyConnectors_PWP_PWP_C);
					AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_partC.SetAggregation(AggregationKind.composite);
				AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern.AddOwnedAttribute(AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_partC);
				
				AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_r.SetName("r");
					AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_r.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_r_ConnectorEnd126.SetUpper(-1);
						AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_r_ConnectorEnd126.SetLower(0);
						AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_r_ConnectorEnd126.SetRole(AssemblyConnectors_PWP_PWP_B_p);
						AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_r_ConnectorEnd126.SetPartWithPort(AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_partB);
						
					AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_r.AddEnd(AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_r_ConnectorEnd126);
						AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_r_ConnectorEnd125.SetUpper(-1);
						AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_r_ConnectorEnd125.SetLower(0);
						AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_r_ConnectorEnd125.SetRole(AssemblyConnectors_PWP_PWP_C_q);
						AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_r_ConnectorEnd125.SetPartWithPort(AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_partC);
						
					AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_r.AddEnd(AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_r_ConnectorEnd125);
					AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_r.SetType(AssemblyConnectors_PWP_PWP_R);
				AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern.AddOwnedConnector(AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_r);
					// Operation A_Unconnected_Pattern_A_Unconnected_Pattern
					AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern.SetName("A_Unconnected_Pattern_A_Unconnected_Pattern");
					AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
						// Parameter result
						AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result.SetName("result");
						AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result.SetVisibility(VisibilityKind.public_);
						
						AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result.SetType(AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern);
						AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result.SetDirection(ParameterDirectionKind.return_);
					AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern.AddOwnedParameter(AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result);
					AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern.AddOwnedOperation(AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern);
			AssemblyConnectors_PWP_PWP.AddPackagedElement(AssemblyConnectors_PWP_PWP_A_Unconnected_Pattern);
				// Class A_Array_Pattern
				AssemblyConnectors_PWP_PWP_A_Array_Pattern.SetName("A_Array_Pattern");
				AssemblyConnectors_PWP_PWP_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Property partB
					AssemblyConnectors_PWP_PWP_A_Array_Pattern_partB.SetName("partB");
					AssemblyConnectors_PWP_PWP_A_Array_Pattern_partB.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_PWP_A_Array_Pattern_partB.SetUpper(-1);
					AssemblyConnectors_PWP_PWP_A_Array_Pattern_partB.SetLower(2);
					AssemblyConnectors_PWP_PWP_A_Array_Pattern_partB.SetType(AssemblyConnectors_PWP_PWP_B);
					AssemblyConnectors_PWP_PWP_A_Array_Pattern_partB.SetAggregation(AggregationKind.composite);
				AssemblyConnectors_PWP_PWP_A_Array_Pattern.AddOwnedAttribute(AssemblyConnectors_PWP_PWP_A_Array_Pattern_partB);
					// Property partC
					AssemblyConnectors_PWP_PWP_A_Array_Pattern_partC.SetName("partC");
					AssemblyConnectors_PWP_PWP_A_Array_Pattern_partC.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_PWP_A_Array_Pattern_partC.SetUpper(-1);
					AssemblyConnectors_PWP_PWP_A_Array_Pattern_partC.SetLower(4);
					AssemblyConnectors_PWP_PWP_A_Array_Pattern_partC.SetType(AssemblyConnectors_PWP_PWP_C);
					AssemblyConnectors_PWP_PWP_A_Array_Pattern_partC.SetAggregation(AggregationKind.composite);
				AssemblyConnectors_PWP_PWP_A_Array_Pattern.AddOwnedAttribute(AssemblyConnectors_PWP_PWP_A_Array_Pattern_partC);
				
				AssemblyConnectors_PWP_PWP_A_Array_Pattern_r.SetName("r");
					AssemblyConnectors_PWP_PWP_A_Array_Pattern_r.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_A_Array_Pattern_r_ConnectorEnd132.SetUpper(-1);
						AssemblyConnectors_PWP_PWP_A_Array_Pattern_r_ConnectorEnd132.SetRole(AssemblyConnectors_PWP_PWP_B_p);
						AssemblyConnectors_PWP_PWP_A_Array_Pattern_r_ConnectorEnd132.SetPartWithPort(AssemblyConnectors_PWP_PWP_A_Array_Pattern_partB);
						
					AssemblyConnectors_PWP_PWP_A_Array_Pattern_r.AddEnd(AssemblyConnectors_PWP_PWP_A_Array_Pattern_r_ConnectorEnd132);
						AssemblyConnectors_PWP_PWP_A_Array_Pattern_r_ConnectorEnd133.SetUpper(-1);
						AssemblyConnectors_PWP_PWP_A_Array_Pattern_r_ConnectorEnd133.SetRole(AssemblyConnectors_PWP_PWP_C_q);
						AssemblyConnectors_PWP_PWP_A_Array_Pattern_r_ConnectorEnd133.SetPartWithPort(AssemblyConnectors_PWP_PWP_A_Array_Pattern_partC);
						
					AssemblyConnectors_PWP_PWP_A_Array_Pattern_r.AddEnd(AssemblyConnectors_PWP_PWP_A_Array_Pattern_r_ConnectorEnd133);
					AssemblyConnectors_PWP_PWP_A_Array_Pattern_r.SetType(AssemblyConnectors_PWP_PWP_R);
				AssemblyConnectors_PWP_PWP_A_Array_Pattern.AddOwnedConnector(AssemblyConnectors_PWP_PWP_A_Array_Pattern_r);
					// Operation A_Array_Pattern_A_Array_Pattern
					AssemblyConnectors_PWP_PWP_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern.SetName("A_Array_Pattern_A_Array_Pattern");
					AssemblyConnectors_PWP_PWP_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
						// Parameter result
						AssemblyConnectors_PWP_PWP_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result.SetName("result");
						AssemblyConnectors_PWP_PWP_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result.SetVisibility(VisibilityKind.public_);
						
						AssemblyConnectors_PWP_PWP_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result.SetType(AssemblyConnectors_PWP_PWP_A_Array_Pattern);
						AssemblyConnectors_PWP_PWP_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result.SetDirection(ParameterDirectionKind.return_);
					AssemblyConnectors_PWP_PWP_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern.AddOwnedParameter(AssemblyConnectors_PWP_PWP_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result);
					AssemblyConnectors_PWP_PWP_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				AssemblyConnectors_PWP_PWP_A_Array_Pattern.AddOwnedOperation(AssemblyConnectors_PWP_PWP_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern);
			AssemblyConnectors_PWP_PWP.AddPackagedElement(AssemblyConnectors_PWP_PWP_A_Array_Pattern);
				// Activity instantiate_A_Empty_Pattern
				AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern.SetName("instantiate_A_Empty_Pattern");
				AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Empty_Pattern
					AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetName("a_Empty_Pattern");
					AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetType(AssemblyConnectors_PWP_PWP_A_Empty_Pattern);
					AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetDirection(ParameterDirectionKind.return_);
				AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern.AddOwnedParameter(AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_a_Empty_Pattern);
					// ActivityParameterNode a_Empty_Pattern_node
					AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_a_Empty_Pattern_node.SetName("a_Empty_Pattern_node");
					AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_a_Empty_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_a_Empty_Pattern_node.SetParameter(AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_a_Empty_Pattern);
				AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern.AddNode(AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_a_Empty_Pattern_node);
					// CallOperationAction A_Empty_Pattern()
					AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern_.SetName("A_Empty_Pattern()");
					AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__result.SetName("result");
						AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__result.SetType(AssemblyConnectors_PWP_PWP_A_Empty_Pattern);
					AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern_.AddResult(AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__result);
					AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern_.SetOperation(AssemblyConnectors_PWP_PWP_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern);
						// InputPin target
						AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__target.SetName("target");
						AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__target.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__target.SetType(AssemblyConnectors_PWP_PWP_A_Empty_Pattern);
					AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern_.SetTarget(AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__target);
				AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern.AddNode(AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern_);
					// CreateObjectAction Create A_Empty_Pattern
					AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern.SetName("Create A_Empty_Pattern");
					AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern.SetClassifier(AssemblyConnectors_PWP_PWP_A_Empty_Pattern);
						// OutputPin result
						AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result.SetName("result");
						AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result.SetType(AssemblyConnectors_PWP_PWP_A_Empty_Pattern);
					AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern.SetResult(AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result);
				AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern.AddNode(AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern);
					// ObjectFlow ObjectFlow139 from result to a_Empty_Pattern_node
					AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_ObjectFlow139.SetName("ObjectFlow139");
					AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_ObjectFlow139.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_ObjectFlow139.SetSource(AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__result);
					AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_ObjectFlow139.SetTarget(AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_a_Empty_Pattern_node);
						// LiteralBoolean LiteralBoolean141
						AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_ObjectFlow139_LiteralBoolean141.SetName("LiteralBoolean141");
						AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_ObjectFlow139_LiteralBoolean141.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_ObjectFlow139_LiteralBoolean141.SetValue(true);
					AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_ObjectFlow139.SetGuard(AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_ObjectFlow139_LiteralBoolean141);
				AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern.AddEdge(AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_ObjectFlow139);
					// ObjectFlow ObjectFlow144 from result to target
					AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_ObjectFlow144.SetName("ObjectFlow144");
					AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_ObjectFlow144.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_ObjectFlow144.SetSource(AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result);
					AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_ObjectFlow144.SetTarget(AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__target);
						// LiteralBoolean LiteralBoolean146
						AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_ObjectFlow144_LiteralBoolean146.SetName("LiteralBoolean146");
						AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_ObjectFlow144_LiteralBoolean146.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_ObjectFlow144_LiteralBoolean146.SetValue(true);
					AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_ObjectFlow144.SetGuard(AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_ObjectFlow144_LiteralBoolean146);
				AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern.AddEdge(AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern_ObjectFlow144);
			AssemblyConnectors_PWP_PWP.AddPackagedElement(AssemblyConnectors_PWP_PWP_instantiate_A_Empty_Pattern);
				// Activity assert_A_Star_Pattern
				AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern.SetName("assert_A_Star_Pattern");
				AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Star_Pattern
					AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_a_Star_Pattern.SetName("a_Star_Pattern");
					AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_a_Star_Pattern.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_a_Star_Pattern.SetType(AssemblyConnectors_PWP_PWP_A_Star_Pattern);
				AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern.AddOwnedParameter(AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_a_Star_Pattern);
					// CallBehaviorAction writeLine
					AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine.SetName("writeLine");
					AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine.SetVisibility(VisibilityKind.public_);
					
						// OutputPin errorStatus
						AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine_errorStatus.SetName("errorStatus");
						AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine_errorStatus.SetVisibility(VisibilityKind.public_);
						
						AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine_errorStatus.SetLower(0);
					AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine.AddResult(AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine_errorStatus);
					AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
						// InputPin value
						AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine_value.SetName("value");
						AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine_value.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine.AddArgument(AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine_value);
				AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern.AddNode(AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine);
					// ActivityParameterNode a_Star_Pattern_node
					AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_a_Star_Pattern_node.SetName("a_Star_Pattern_node");
					AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_a_Star_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_a_Star_Pattern_node.SetParameter(AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_a_Star_Pattern);
				AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern.AddNode(AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_a_Star_Pattern_node);
					// ValueSpecificationAction message
					AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_message.SetName("message");
					AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_message.SetVisibility(VisibilityKind.public_);
						// LiteralString LiteralString159
						AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_message_LiteralString159.SetName("LiteralString159");
						AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_message_LiteralString159.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_message_LiteralString159.SetValue("Assertion currently not implemented for A_Star_Pattern.");
					AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_message.SetValue(AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_message_LiteralString159);
						// OutputPin result
						AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_message_result.SetName("result");
						AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_message_result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_message.SetResult(AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_message_result);
				AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern.AddNode(AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_message);
					// ObjectFlow ObjectFlow147 from result to value
					AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_ObjectFlow147.SetName("ObjectFlow147");
					AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_ObjectFlow147.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_ObjectFlow147.SetSource(AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_message_result);
					AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_ObjectFlow147.SetTarget(AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_writeLine_value);
						// LiteralBoolean LiteralBoolean148
						AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_ObjectFlow147_LiteralBoolean148.SetName("LiteralBoolean148");
						AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_ObjectFlow147_LiteralBoolean148.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_ObjectFlow147_LiteralBoolean148.SetValue(true);
					AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_ObjectFlow147.SetGuard(AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_ObjectFlow147_LiteralBoolean148);
				AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern.AddEdge(AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern_ObjectFlow147);
			AssemblyConnectors_PWP_PWP.AddPackagedElement(AssemblyConnectors_PWP_PWP_assert_A_Star_Pattern);
				// Class IImpl
				AssemblyConnectors_PWP_PWP_IImpl.SetName("IImpl");
				AssemblyConnectors_PWP_PWP_IImpl.SetVisibility(VisibilityKind.public_);
				AssemblyConnectors_PWP_PWP_IImpl_I_Realization.SetName("I_Realization");
					AssemblyConnectors_PWP_PWP_IImpl_I_Realization.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_PWP_IImpl_I_Realization.SetContract(AssemblyConnectors_PWP_PWP_I);
					
				AssemblyConnectors_PWP_PWP_IImpl.AddInterfaceRealization(AssemblyConnectors_PWP_PWP_IImpl_I_Realization);
			AssemblyConnectors_PWP_PWP.AddPackagedElement(AssemblyConnectors_PWP_PWP_IImpl);
				// Interface I
				AssemblyConnectors_PWP_PWP_I.SetName("I");
				AssemblyConnectors_PWP_PWP_I.SetVisibility(VisibilityKind.public_);
			AssemblyConnectors_PWP_PWP.AddPackagedElement(AssemblyConnectors_PWP_PWP_I);
				// Class A_Empty_Pattern
				AssemblyConnectors_PWP_PWP_A_Empty_Pattern.SetName("A_Empty_Pattern");
				AssemblyConnectors_PWP_PWP_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Property partB
					AssemblyConnectors_PWP_PWP_A_Empty_Pattern_partB.SetName("partB");
					AssemblyConnectors_PWP_PWP_A_Empty_Pattern_partB.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_PWP_A_Empty_Pattern_partB.SetUpper(-1);
					AssemblyConnectors_PWP_PWP_A_Empty_Pattern_partB.SetLower(0);
					AssemblyConnectors_PWP_PWP_A_Empty_Pattern_partB.SetType(AssemblyConnectors_PWP_PWP_B);
					AssemblyConnectors_PWP_PWP_A_Empty_Pattern_partB.SetAggregation(AggregationKind.composite);
				AssemblyConnectors_PWP_PWP_A_Empty_Pattern.AddOwnedAttribute(AssemblyConnectors_PWP_PWP_A_Empty_Pattern_partB);
					// Property partC
					AssemblyConnectors_PWP_PWP_A_Empty_Pattern_partC.SetName("partC");
					AssemblyConnectors_PWP_PWP_A_Empty_Pattern_partC.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_PWP_A_Empty_Pattern_partC.SetUpper(-1);
					AssemblyConnectors_PWP_PWP_A_Empty_Pattern_partC.SetLower(0);
					AssemblyConnectors_PWP_PWP_A_Empty_Pattern_partC.SetType(AssemblyConnectors_PWP_PWP_C);
					AssemblyConnectors_PWP_PWP_A_Empty_Pattern_partC.SetAggregation(AggregationKind.composite);
				AssemblyConnectors_PWP_PWP_A_Empty_Pattern.AddOwnedAttribute(AssemblyConnectors_PWP_PWP_A_Empty_Pattern_partC);
				
				AssemblyConnectors_PWP_PWP_A_Empty_Pattern_r.SetName("r");
					AssemblyConnectors_PWP_PWP_A_Empty_Pattern_r.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_A_Empty_Pattern_r_ConnectorEnd165.SetUpper(-1);
						AssemblyConnectors_PWP_PWP_A_Empty_Pattern_r_ConnectorEnd165.SetRole(AssemblyConnectors_PWP_PWP_B_p);
						AssemblyConnectors_PWP_PWP_A_Empty_Pattern_r_ConnectorEnd165.SetPartWithPort(AssemblyConnectors_PWP_PWP_A_Empty_Pattern_partB);
						
					AssemblyConnectors_PWP_PWP_A_Empty_Pattern_r.AddEnd(AssemblyConnectors_PWP_PWP_A_Empty_Pattern_r_ConnectorEnd165);
						AssemblyConnectors_PWP_PWP_A_Empty_Pattern_r_ConnectorEnd164.SetUpper(-1);
						AssemblyConnectors_PWP_PWP_A_Empty_Pattern_r_ConnectorEnd164.SetRole(AssemblyConnectors_PWP_PWP_C_q);
						AssemblyConnectors_PWP_PWP_A_Empty_Pattern_r_ConnectorEnd164.SetPartWithPort(AssemblyConnectors_PWP_PWP_A_Empty_Pattern_partC);
						
					AssemblyConnectors_PWP_PWP_A_Empty_Pattern_r.AddEnd(AssemblyConnectors_PWP_PWP_A_Empty_Pattern_r_ConnectorEnd164);
					AssemblyConnectors_PWP_PWP_A_Empty_Pattern_r.SetType(AssemblyConnectors_PWP_PWP_R);
				AssemblyConnectors_PWP_PWP_A_Empty_Pattern.AddOwnedConnector(AssemblyConnectors_PWP_PWP_A_Empty_Pattern_r);
					// Operation A_Empty_Pattern_A_Empty_Pattern
					AssemblyConnectors_PWP_PWP_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern.SetName("A_Empty_Pattern_A_Empty_Pattern");
					AssemblyConnectors_PWP_PWP_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
						// Parameter result
						AssemblyConnectors_PWP_PWP_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result.SetName("result");
						AssemblyConnectors_PWP_PWP_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result.SetVisibility(VisibilityKind.public_);
						
						AssemblyConnectors_PWP_PWP_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result.SetType(AssemblyConnectors_PWP_PWP_A_Empty_Pattern);
						AssemblyConnectors_PWP_PWP_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result.SetDirection(ParameterDirectionKind.return_);
					AssemblyConnectors_PWP_PWP_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern.AddOwnedParameter(AssemblyConnectors_PWP_PWP_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result);
					AssemblyConnectors_PWP_PWP_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				AssemblyConnectors_PWP_PWP_A_Empty_Pattern.AddOwnedOperation(AssemblyConnectors_PWP_PWP_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern);
			AssemblyConnectors_PWP_PWP.AddPackagedElement(AssemblyConnectors_PWP_PWP_A_Empty_Pattern);
				// Activity instantiate_A_Star_Pattern
				AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern.SetName("instantiate_A_Star_Pattern");
				AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Star_Pattern
					AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_a_Star_Pattern.SetName("a_Star_Pattern");
					AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_a_Star_Pattern.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_a_Star_Pattern.SetType(AssemblyConnectors_PWP_PWP_A_Star_Pattern);
					AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_a_Star_Pattern.SetDirection(ParameterDirectionKind.return_);
				AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern.AddOwnedParameter(AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_a_Star_Pattern);
					// CallOperationAction A_Star_Pattern()
					AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_A_Star_Pattern_.SetName("A_Star_Pattern()");
					AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_A_Star_Pattern_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__result.SetName("result");
						AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__result.SetType(AssemblyConnectors_PWP_PWP_A_Star_Pattern);
					AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_A_Star_Pattern_.AddResult(AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__result);
					AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_A_Star_Pattern_.SetOperation(AssemblyConnectors_PWP_PWP_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern);
						// InputPin target
						AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__target.SetName("target");
						AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__target.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__target.SetType(AssemblyConnectors_PWP_PWP_A_Star_Pattern);
					AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_A_Star_Pattern_.SetTarget(AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__target);
				AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern.AddNode(AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_A_Star_Pattern_);
					// ActivityParameterNode a_Star_Pattern_node
					AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_a_Star_Pattern_node.SetName("a_Star_Pattern_node");
					AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_a_Star_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_a_Star_Pattern_node.SetParameter(AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_a_Star_Pattern);
				AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern.AddNode(AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_a_Star_Pattern_node);
					// CreateObjectAction Create A_Star_Pattern
					AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern.SetName("Create A_Star_Pattern");
					AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern.SetClassifier(AssemblyConnectors_PWP_PWP_A_Star_Pattern);
						// OutputPin result
						AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result.SetName("result");
						AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result.SetType(AssemblyConnectors_PWP_PWP_A_Star_Pattern);
					AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern.SetResult(AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result);
				AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern.AddNode(AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern);
					// ObjectFlow ObjectFlow172 from result to a_Star_Pattern_node
					AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_ObjectFlow172.SetName("ObjectFlow172");
					AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_ObjectFlow172.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_ObjectFlow172.SetSource(AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__result);
					AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_ObjectFlow172.SetTarget(AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_a_Star_Pattern_node);
						// LiteralBoolean LiteralBoolean173
						AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_ObjectFlow172_LiteralBoolean173.SetName("LiteralBoolean173");
						AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_ObjectFlow172_LiteralBoolean173.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_ObjectFlow172_LiteralBoolean173.SetValue(true);
					AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_ObjectFlow172.SetGuard(AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_ObjectFlow172_LiteralBoolean173);
				AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern.AddEdge(AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_ObjectFlow172);
					// ObjectFlow ObjectFlow175 from result to target
					AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_ObjectFlow175.SetName("ObjectFlow175");
					AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_ObjectFlow175.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_ObjectFlow175.SetSource(AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result);
					AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_ObjectFlow175.SetTarget(AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__target);
						// LiteralBoolean LiteralBoolean176
						AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_ObjectFlow175_LiteralBoolean176.SetName("LiteralBoolean176");
						AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_ObjectFlow175_LiteralBoolean176.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_ObjectFlow175_LiteralBoolean176.SetValue(true);
					AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_ObjectFlow175.SetGuard(AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_ObjectFlow175_LiteralBoolean176);
				AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern.AddEdge(AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern_ObjectFlow175);
			AssemblyConnectors_PWP_PWP.AddPackagedElement(AssemblyConnectors_PWP_PWP_instantiate_A_Star_Pattern);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // AssemblyConnectors_PWP_PWPModel
}
