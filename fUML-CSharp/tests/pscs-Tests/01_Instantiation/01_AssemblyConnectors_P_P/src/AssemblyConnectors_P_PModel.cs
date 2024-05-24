/*
 * AssemblyConnectors_P_PModel.cs
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

namespace AssemblyConnectors_P_P
{
	public class AssemblyConnectors_P_PModel : InMemoryModel
	{
		private static AssemblyConnectors_P_PModel? instance;

		/*
		 * Model AssemblyConnectors_P_P
		 */
		public Package AssemblyConnectors_P_P = new();
			public Activity AssemblyConnectors_P_P_instantiate_A_Empty_Pattern = new();
				public ActivityParameterNode AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_a_Empty_Pattern_node = new();
				public ObjectFlow AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow0 = new();
					public LiteralInteger AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow0_LiteralInteger1 = new();
					public LiteralBoolean AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow0_LiteralBoolean2 = new();
				public ObjectFlow AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow3 = new();
					public LiteralBoolean AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow3_LiteralBoolean4 = new();
					public LiteralInteger AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow3_LiteralInteger5 = new();
				public CallOperationAction AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern_ = new();
					public OutputPin AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result = new();
						public LiteralInteger AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result_LiteralInteger6 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result_LiteralUnlimitedNatural7 = new();
						public LiteralInteger AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result_LiteralInteger8 = new();
					public InputPin AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target = new();
						public LiteralInteger AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target_LiteralInteger9 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target_LiteralUnlimitedNatural10 = new();
				public CreateObjectAction AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern = new();
					public OutputPin AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result_LiteralUnlimitedNatural11 = new();
						public LiteralInteger AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result_LiteralInteger12 = new();
				public Parameter AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_a_Empty_Pattern = new();
			public Class_ AssemblyConnectors_P_P_C = new();
			public Activity AssemblyConnectors_P_P_assert_A_Star_Pattern = new();
				public Parameter AssemblyConnectors_P_P_assert_A_Star_Pattern_a_Star_Pattern = new();
				public ActivityParameterNode AssemblyConnectors_P_P_assert_A_Star_Pattern_a_Star_Pattern_node = new();
					public LiteralInteger AssemblyConnectors_P_P_assert_A_Star_Pattern_a_Star_Pattern_node_LiteralInteger13 = new();
				public ObjectFlow AssemblyConnectors_P_P_assert_A_Star_Pattern_ObjectFlow14 = new();
					public LiteralInteger AssemblyConnectors_P_P_assert_A_Star_Pattern_ObjectFlow14_LiteralInteger15 = new();
					public LiteralBoolean AssemblyConnectors_P_P_assert_A_Star_Pattern_ObjectFlow14_LiteralBoolean16 = new();
				public ValueSpecificationAction AssemblyConnectors_P_P_assert_A_Star_Pattern_message = new();
					public OutputPin AssemblyConnectors_P_P_assert_A_Star_Pattern_message_result = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_assert_A_Star_Pattern_message_result_LiteralUnlimitedNatural17 = new();
						public LiteralInteger AssemblyConnectors_P_P_assert_A_Star_Pattern_message_result_LiteralInteger18 = new();
					public LiteralString AssemblyConnectors_P_P_assert_A_Star_Pattern_message_LiteralString19 = new();
				public CallBehaviorAction AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine = new();
					public OutputPin AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine_errorStatus = new();
						public LiteralInteger AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine_errorStatus_LiteralInteger20 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural21 = new();
						public LiteralInteger AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine_errorStatus_LiteralInteger22 = new();
					public InputPin AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine_value = new();
						public LiteralInteger AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine_value_LiteralInteger23 = new();
						public LiteralInteger AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine_value_LiteralInteger24 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine_value_LiteralUnlimitedNatural25 = new();
			public Class_ AssemblyConnectors_P_P_B = new();
			public Class_ AssemblyConnectors_P_P_A_Star_Pattern = new();
				public Comment AssemblyConnectors_P_P_A_Star_Pattern_Comment26 = new();
				public Property AssemblyConnectors_P_P_A_Star_Pattern_partC = new();
					public LiteralUnlimitedNatural AssemblyConnectors_P_P_A_Star_Pattern_partC_LiteralUnlimitedNatural27 = new();
					public LiteralInteger AssemblyConnectors_P_P_A_Star_Pattern_partC_LiteralInteger28 = new();
				public Operation AssemblyConnectors_P_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern = new();
					public Parameter AssemblyConnectors_P_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result = new();
				public Connector AssemblyConnectors_P_P_A_Star_Pattern_r = new();
					public ConnectorEnd AssemblyConnectors_P_P_A_Star_Pattern_r_ConnectorEnd29 = new();
						public LiteralInteger AssemblyConnectors_P_P_A_Star_Pattern_r_ConnectorEnd29_connectorEnd_2_Lower = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_A_Star_Pattern_r_ConnectorEnd29_connectorEnd_2_Upper = new();
					public ConnectorEnd AssemblyConnectors_P_P_A_Star_Pattern_r_ConnectorEnd30 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_A_Star_Pattern_r_ConnectorEnd30_connectorEnd_1_Upper = new();
						public LiteralInteger AssemblyConnectors_P_P_A_Star_Pattern_r_ConnectorEnd30_connectorEnd_1_Lower = new();
				public Property AssemblyConnectors_P_P_A_Star_Pattern_partB = new();
					public LiteralUnlimitedNatural AssemblyConnectors_P_P_A_Star_Pattern_partB_LiteralUnlimitedNatural31 = new();
					public LiteralInteger AssemblyConnectors_P_P_A_Star_Pattern_partB_LiteralInteger32 = new();
			public Association AssemblyConnectors_P_P_R = new();
				public Property AssemblyConnectors_P_P_R_y = new();
					public LiteralInteger AssemblyConnectors_P_P_R_y_LiteralInteger33 = new();
					public LiteralUnlimitedNatural AssemblyConnectors_P_P_R_y_LiteralUnlimitedNatural34 = new();
				public Property AssemblyConnectors_P_P_R_x = new();
					public LiteralInteger AssemblyConnectors_P_P_R_x_LiteralInteger35 = new();
					public LiteralUnlimitedNatural AssemblyConnectors_P_P_R_x_LiteralUnlimitedNatural36 = new();
			public Activity AssemblyConnectors_P_P_main = new();
				public CallBehaviorAction AssemblyConnectors_P_P_main_instantiate_A_Star_Pattern = new();
					public OutputPin AssemblyConnectors_P_P_main_instantiate_A_Star_Pattern_a_Star_Pattern = new();
						public LiteralInteger AssemblyConnectors_P_P_main_instantiate_A_Star_Pattern_a_Star_Pattern_LiteralInteger37 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_main_instantiate_A_Star_Pattern_a_Star_Pattern_LiteralUnlimitedNatural38 = new();
						public LiteralInteger AssemblyConnectors_P_P_main_instantiate_A_Star_Pattern_a_Star_Pattern_LiteralInteger39 = new();
				public ObjectFlow AssemblyConnectors_P_P_main_ObjectFlow40 = new();
					public LiteralBoolean AssemblyConnectors_P_P_main_ObjectFlow40_LiteralBoolean41 = new();
					public LiteralInteger AssemblyConnectors_P_P_main_ObjectFlow40_LiteralInteger42 = new();
				public ObjectFlow AssemblyConnectors_P_P_main_ObjectFlow43 = new();
					public LiteralBoolean AssemblyConnectors_P_P_main_ObjectFlow43_LiteralBoolean44 = new();
					public LiteralInteger AssemblyConnectors_P_P_main_ObjectFlow43_LiteralInteger45 = new();
				public CallBehaviorAction AssemblyConnectors_P_P_main_assert_A_Array_Pattern = new();
					public InputPin AssemblyConnectors_P_P_main_assert_A_Array_Pattern_a_Array_Pattern = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_main_assert_A_Array_Pattern_a_Array_Pattern_LiteralUnlimitedNatural46 = new();
						public LiteralInteger AssemblyConnectors_P_P_main_assert_A_Array_Pattern_a_Array_Pattern_LiteralInteger47 = new();
						public LiteralInteger AssemblyConnectors_P_P_main_assert_A_Array_Pattern_a_Array_Pattern_LiteralInteger48 = new();
				public ObjectFlow AssemblyConnectors_P_P_main_ObjectFlow49 = new();
					public LiteralInteger AssemblyConnectors_P_P_main_ObjectFlow49_LiteralInteger50 = new();
					public LiteralBoolean AssemblyConnectors_P_P_main_ObjectFlow49_LiteralBoolean51 = new();
				public ControlFlow AssemblyConnectors_P_P_main_ControlFlow52 = new();
				public CallBehaviorAction AssemblyConnectors_P_P_main_assert_A_Unconnected_Pattern = new();
					public InputPin AssemblyConnectors_P_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern = new();
						public LiteralInteger AssemblyConnectors_P_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger53 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralUnlimitedNatural54 = new();
						public LiteralInteger AssemblyConnectors_P_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger55 = new();
				public ControlFlow AssemblyConnectors_P_P_main_ControlFlow56 = new();
				public CallBehaviorAction AssemblyConnectors_P_P_main_assert_A_Empty_Pattern = new();
					public InputPin AssemblyConnectors_P_P_main_assert_A_Empty_Pattern_a_Empty_Pattern = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_main_assert_A_Empty_Pattern_a_Empty_Pattern_LiteralUnlimitedNatural57 = new();
						public LiteralInteger AssemblyConnectors_P_P_main_assert_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger58 = new();
						public LiteralInteger AssemblyConnectors_P_P_main_assert_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger59 = new();
				public ObjectFlow AssemblyConnectors_P_P_main_ObjectFlow60 = new();
					public LiteralBoolean AssemblyConnectors_P_P_main_ObjectFlow60_LiteralBoolean61 = new();
					public LiteralInteger AssemblyConnectors_P_P_main_ObjectFlow60_LiteralInteger62 = new();
				public CallBehaviorAction AssemblyConnectors_P_P_main_instantiate_A_Unconnected_Pattern = new();
					public OutputPin AssemblyConnectors_P_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralUnlimitedNatural63 = new();
						public LiteralInteger AssemblyConnectors_P_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger64 = new();
						public LiteralInteger AssemblyConnectors_P_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger65 = new();
				public ControlFlow AssemblyConnectors_P_P_main_ControlFlow66 = new();
				public CallBehaviorAction AssemblyConnectors_P_P_main_instantiate_A_Array_Pattern = new();
					public OutputPin AssemblyConnectors_P_P_main_instantiate_A_Array_Pattern_a_Array_Pattern = new();
						public LiteralInteger AssemblyConnectors_P_P_main_instantiate_A_Array_Pattern_a_Array_Pattern_LiteralInteger67 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_main_instantiate_A_Array_Pattern_a_Array_Pattern_LiteralUnlimitedNatural68 = new();
						public LiteralInteger AssemblyConnectors_P_P_main_instantiate_A_Array_Pattern_a_Array_Pattern_LiteralInteger69 = new();
				public CallBehaviorAction AssemblyConnectors_P_P_main_assert_A_Star_Pattern = new();
					public InputPin AssemblyConnectors_P_P_main_assert_A_Star_Pattern_a_Star_Pattern = new();
						public LiteralInteger AssemblyConnectors_P_P_main_assert_A_Star_Pattern_a_Star_Pattern_LiteralInteger70 = new();
						public LiteralInteger AssemblyConnectors_P_P_main_assert_A_Star_Pattern_a_Star_Pattern_LiteralInteger71 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_main_assert_A_Star_Pattern_a_Star_Pattern_LiteralUnlimitedNatural72 = new();
				public CallBehaviorAction AssemblyConnectors_P_P_main_instantiate_A_Empty_Pattern = new();
					public OutputPin AssemblyConnectors_P_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern = new();
						public LiteralInteger AssemblyConnectors_P_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger73 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern_LiteralUnlimitedNatural74 = new();
						public LiteralInteger AssemblyConnectors_P_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger75 = new();
			public Activity AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern = new();
				public CreateObjectAction AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern = new();
					public OutputPin AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result_LiteralUnlimitedNatural76 = new();
						public LiteralInteger AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result_LiteralInteger77 = new();
				public ObjectFlow AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow78 = new();
					public LiteralBoolean AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow78_LiteralBoolean79 = new();
					public LiteralInteger AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow78_LiteralInteger80 = new();
				public Parameter AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern = new();
				public ObjectFlow AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow81 = new();
					public LiteralBoolean AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow81_LiteralBoolean82 = new();
					public LiteralInteger AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow81_LiteralInteger83 = new();
				public ActivityParameterNode AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node = new();
				public CallOperationAction AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_ = new();
					public InputPin AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target_LiteralUnlimitedNatural84 = new();
						public LiteralInteger AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target_LiteralInteger85 = new();
					public OutputPin AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result = new();
						public LiteralInteger AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result_LiteralInteger86 = new();
						public LiteralInteger AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result_LiteralInteger87 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result_LiteralUnlimitedNatural88 = new();
			public Activity AssemblyConnectors_P_P_assert_A_Empty_Pattern = new();
				public CallBehaviorAction AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine = new();
					public InputPin AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine_value = new();
						public LiteralInteger AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine_value_LiteralInteger89 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine_value_LiteralUnlimitedNatural90 = new();
						public LiteralInteger AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine_value_LiteralInteger91 = new();
					public OutputPin AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine_errorStatus = new();
						public LiteralInteger AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine_errorStatus_LiteralInteger92 = new();
						public LiteralInteger AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine_errorStatus_LiteralInteger93 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural94 = new();
				public ObjectFlow AssemblyConnectors_P_P_assert_A_Empty_Pattern_ObjectFlow95 = new();
					public LiteralBoolean AssemblyConnectors_P_P_assert_A_Empty_Pattern_ObjectFlow95_LiteralBoolean96 = new();
					public LiteralInteger AssemblyConnectors_P_P_assert_A_Empty_Pattern_ObjectFlow95_LiteralInteger97 = new();
				public Parameter AssemblyConnectors_P_P_assert_A_Empty_Pattern_a_Empty_Pattern = new();
				public ValueSpecificationAction AssemblyConnectors_P_P_assert_A_Empty_Pattern_message = new();
					public OutputPin AssemblyConnectors_P_P_assert_A_Empty_Pattern_message_result = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_assert_A_Empty_Pattern_message_result_LiteralUnlimitedNatural98 = new();
						public LiteralInteger AssemblyConnectors_P_P_assert_A_Empty_Pattern_message_result_LiteralInteger99 = new();
					public LiteralString AssemblyConnectors_P_P_assert_A_Empty_Pattern_message_LiteralString100 = new();
				public ActivityParameterNode AssemblyConnectors_P_P_assert_A_Empty_Pattern_a_Empty_Pattern_node = new();
					public LiteralInteger AssemblyConnectors_P_P_assert_A_Empty_Pattern_a_Empty_Pattern_node_LiteralInteger101 = new();
			public Class_ AssemblyConnectors_P_P_A_Unconnected_Pattern = new();
				public Comment AssemblyConnectors_P_P_A_Unconnected_Pattern_Comment102 = new();
				public Property AssemblyConnectors_P_P_A_Unconnected_Pattern_partC = new();
					public LiteralInteger AssemblyConnectors_P_P_A_Unconnected_Pattern_partC_LiteralInteger103 = new();
					public LiteralUnlimitedNatural AssemblyConnectors_P_P_A_Unconnected_Pattern_partC_LiteralUnlimitedNatural104 = new();
				public Property AssemblyConnectors_P_P_A_Unconnected_Pattern_partB = new();
					public LiteralUnlimitedNatural AssemblyConnectors_P_P_A_Unconnected_Pattern_partB_LiteralUnlimitedNatural105 = new();
					public LiteralInteger AssemblyConnectors_P_P_A_Unconnected_Pattern_partB_LiteralInteger106 = new();
				public Connector AssemblyConnectors_P_P_A_Unconnected_Pattern_r = new();
					public ConnectorEnd AssemblyConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd107 = new();
						public LiteralInteger AssemblyConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd107_connectorEnd_2_Lower = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd107_connectorEnd_2_Upper = new();
					public ConnectorEnd AssemblyConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd108 = new();
						public LiteralInteger AssemblyConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd108_connectorEnd_1_Lower = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd108_connectorEnd_1_Upper = new();
				public Operation AssemblyConnectors_P_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern = new();
					public Parameter AssemblyConnectors_P_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result = new();
			public Class_ AssemblyConnectors_P_P_A_Array_Pattern = new();
				public Property AssemblyConnectors_P_P_A_Array_Pattern_partB = new();
					public LiteralInteger AssemblyConnectors_P_P_A_Array_Pattern_partB_LiteralInteger109 = new();
					public LiteralUnlimitedNatural AssemblyConnectors_P_P_A_Array_Pattern_partB_LiteralUnlimitedNatural110 = new();
				public Property AssemblyConnectors_P_P_A_Array_Pattern_partC = new();
					public LiteralUnlimitedNatural AssemblyConnectors_P_P_A_Array_Pattern_partC_LiteralUnlimitedNatural111 = new();
					public LiteralInteger AssemblyConnectors_P_P_A_Array_Pattern_partC_LiteralInteger112 = new();
				public Comment AssemblyConnectors_P_P_A_Array_Pattern_Comment113 = new();
				public Connector AssemblyConnectors_P_P_A_Array_Pattern_r = new();
					public ConnectorEnd AssemblyConnectors_P_P_A_Array_Pattern_r_ConnectorEnd114 = new();
						public LiteralInteger AssemblyConnectors_P_P_A_Array_Pattern_r_ConnectorEnd114_connectorEnd_1_Lower = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_A_Array_Pattern_r_ConnectorEnd114_connectorEnd_1_Upper = new();
					public ConnectorEnd AssemblyConnectors_P_P_A_Array_Pattern_r_ConnectorEnd115 = new();
						public LiteralInteger AssemblyConnectors_P_P_A_Array_Pattern_r_ConnectorEnd115_connectorEnd_2_Lower = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_A_Array_Pattern_r_ConnectorEnd115_connectorEnd_2_Upper = new();
				public Operation AssemblyConnectors_P_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern = new();
					public Parameter AssemblyConnectors_P_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result = new();
			public Activity AssemblyConnectors_P_P_assert_A_Array_Pattern = new();
				public CallBehaviorAction AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine = new();
					public InputPin AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine_value = new();
						public LiteralInteger AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine_value_LiteralInteger116 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine_value_LiteralUnlimitedNatural117 = new();
						public LiteralInteger AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine_value_LiteralInteger118 = new();
					public OutputPin AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine_errorStatus = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural119 = new();
						public LiteralInteger AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine_errorStatus_LiteralInteger120 = new();
						public LiteralInteger AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine_errorStatus_LiteralInteger121 = new();
				public ObjectFlow AssemblyConnectors_P_P_assert_A_Array_Pattern_ObjectFlow122 = new();
					public LiteralBoolean AssemblyConnectors_P_P_assert_A_Array_Pattern_ObjectFlow122_LiteralBoolean123 = new();
					public LiteralInteger AssemblyConnectors_P_P_assert_A_Array_Pattern_ObjectFlow122_LiteralInteger124 = new();
				public ValueSpecificationAction AssemblyConnectors_P_P_assert_A_Array_Pattern_message = new();
					public LiteralString AssemblyConnectors_P_P_assert_A_Array_Pattern_message_LiteralString125 = new();
					public OutputPin AssemblyConnectors_P_P_assert_A_Array_Pattern_message_result = new();
						public LiteralInteger AssemblyConnectors_P_P_assert_A_Array_Pattern_message_result_LiteralInteger126 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_assert_A_Array_Pattern_message_result_LiteralUnlimitedNatural127 = new();
				public Parameter AssemblyConnectors_P_P_assert_A_Array_Pattern_a_Array_Pattern = new();
				public ActivityParameterNode AssemblyConnectors_P_P_assert_A_Array_Pattern_a_Array_Pattern_node = new();
					public LiteralInteger AssemblyConnectors_P_P_assert_A_Array_Pattern_a_Array_Pattern_node_LiteralInteger128 = new();
			public Activity AssemblyConnectors_P_P_instantiate_A_Star_Pattern = new();
				public CreateObjectAction AssemblyConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern = new();
					public OutputPin AssemblyConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result_LiteralUnlimitedNatural129 = new();
						public LiteralInteger AssemblyConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result_LiteralInteger130 = new();
				public Parameter AssemblyConnectors_P_P_instantiate_A_Star_Pattern_a_Star_Pattern = new();
				public ObjectFlow AssemblyConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow131 = new();
					public LiteralBoolean AssemblyConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow131_LiteralBoolean132 = new();
					public LiteralInteger AssemblyConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow131_LiteralInteger133 = new();
				public ObjectFlow AssemblyConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow134 = new();
					public LiteralInteger AssemblyConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow134_LiteralInteger135 = new();
					public LiteralBoolean AssemblyConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow134_LiteralBoolean136 = new();
				public CallOperationAction AssemblyConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern_ = new();
					public OutputPin AssemblyConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__result = new();
						public LiteralInteger AssemblyConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__result_LiteralInteger137 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__result_LiteralUnlimitedNatural138 = new();
						public LiteralInteger AssemblyConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__result_LiteralInteger139 = new();
					public InputPin AssemblyConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__target = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__target_LiteralUnlimitedNatural140 = new();
						public LiteralInteger AssemblyConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__target_LiteralInteger141 = new();
				public ActivityParameterNode AssemblyConnectors_P_P_instantiate_A_Star_Pattern_a_Star_Pattern_node = new();
			public Activity AssemblyConnectors_P_P_instantiate_A_Array_Pattern = new();
				public ActivityParameterNode AssemblyConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern_node = new();
					public LiteralInteger AssemblyConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern_node_LiteralInteger142 = new();
				public CallOperationAction AssemblyConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern_ = new();
					public InputPin AssemblyConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__target = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__target_LiteralUnlimitedNatural143 = new();
						public LiteralInteger AssemblyConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__target_LiteralInteger144 = new();
					public OutputPin AssemblyConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__result = new();
						public LiteralInteger AssemblyConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__result_LiteralInteger145 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__result_LiteralUnlimitedNatural146 = new();
						public LiteralInteger AssemblyConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__result_LiteralInteger147 = new();
				public ObjectFlow AssemblyConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow148 = new();
					public LiteralInteger AssemblyConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow148_LiteralInteger149 = new();
					public LiteralBoolean AssemblyConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow148_LiteralBoolean150 = new();
				public Parameter AssemblyConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern = new();
				public CreateObjectAction AssemblyConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern = new();
					public OutputPin AssemblyConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result = new();
						public LiteralInteger AssemblyConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result_LiteralInteger151 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result_LiteralUnlimitedNatural152 = new();
				public ObjectFlow AssemblyConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow153 = new();
					public LiteralBoolean AssemblyConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow153_LiteralBoolean154 = new();
					public LiteralInteger AssemblyConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow153_LiteralInteger155 = new();
			public Activity AssemblyConnectors_P_P_assert_A_Unconnected_Pattern = new();
				public ObjectFlow AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_ObjectFlow156 = new();
					public LiteralInteger AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_ObjectFlow156_LiteralInteger157 = new();
					public LiteralBoolean AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_ObjectFlow156_LiteralBoolean158 = new();
				public CallBehaviorAction AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine = new();
					public InputPin AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_value = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_value_LiteralUnlimitedNatural159 = new();
						public LiteralInteger AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_value_LiteralInteger160 = new();
						public LiteralInteger AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_value_LiteralInteger161 = new();
					public OutputPin AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_errorStatus = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural162 = new();
						public LiteralInteger AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_errorStatus_LiteralInteger163 = new();
						public LiteralInteger AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_errorStatus_LiteralInteger164 = new();
				public ValueSpecificationAction AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_message = new();
					public LiteralString AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_message_LiteralString165 = new();
					public OutputPin AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_message_result = new();
						public LiteralInteger AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_message_result_LiteralInteger166 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_message_result_LiteralUnlimitedNatural167 = new();
				public ActivityParameterNode AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node = new();
					public LiteralInteger AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node_LiteralInteger168 = new();
				public Parameter AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern = new();
			public Class_ AssemblyConnectors_P_P_A_Empty_Pattern = new();
				public Property AssemblyConnectors_P_P_A_Empty_Pattern_partB = new();
					public LiteralInteger AssemblyConnectors_P_P_A_Empty_Pattern_partB_LiteralInteger169 = new();
					public LiteralUnlimitedNatural AssemblyConnectors_P_P_A_Empty_Pattern_partB_LiteralUnlimitedNatural170 = new();
				public Property AssemblyConnectors_P_P_A_Empty_Pattern_partC = new();
					public LiteralInteger AssemblyConnectors_P_P_A_Empty_Pattern_partC_LiteralInteger171 = new();
					public LiteralUnlimitedNatural AssemblyConnectors_P_P_A_Empty_Pattern_partC_LiteralUnlimitedNatural172 = new();
				public Operation AssemblyConnectors_P_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern = new();
					public Parameter AssemblyConnectors_P_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result = new();
				public Connector AssemblyConnectors_P_P_A_Empty_Pattern_r = new();
					public ConnectorEnd AssemblyConnectors_P_P_A_Empty_Pattern_r_ConnectorEnd173 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_A_Empty_Pattern_r_ConnectorEnd173_connectorEnd_2_Upper = new();
						public LiteralInteger AssemblyConnectors_P_P_A_Empty_Pattern_r_ConnectorEnd173_connectorEnd_2_Lower = new();
					public ConnectorEnd AssemblyConnectors_P_P_A_Empty_Pattern_r_ConnectorEnd174 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_P_P_A_Empty_Pattern_r_ConnectorEnd174_connectorEnd_1_Upper = new();
						public LiteralInteger AssemblyConnectors_P_P_A_Empty_Pattern_r_ConnectorEnd174_connectorEnd_1_Lower = new();
				public Comment AssemblyConnectors_P_P_A_Empty_Pattern_Comment175 = new();

		public static AssemblyConnectors_P_PModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public AssemblyConnectors_P_PModel()
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
			 * Model AssemblyConnectors_P_P
			 */
			AddToElementRepository("AssemblyConnectors_P_P", AssemblyConnectors_P_P);
				AddToElementRepository("instantiate_A_Empty_Pattern", AssemblyConnectors_P_P_instantiate_A_Empty_Pattern);
					AddToElementRepository("a_Empty_Pattern_node", AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_a_Empty_Pattern_node);
					AddToElementRepository("ObjectFlow0", AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow0);
						AddToElementRepository("LiteralInteger1", AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow0_LiteralInteger1);
						AddToElementRepository("LiteralBoolean2", AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow0_LiteralBoolean2);
					AddToElementRepository("ObjectFlow3", AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow3);
						AddToElementRepository("LiteralBoolean4", AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow3_LiteralBoolean4);
						AddToElementRepository("LiteralInteger5", AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow3_LiteralInteger5);
					AddToElementRepository("A_Empty_Pattern()", AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern_);
						AddToElementRepository("result", AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result);
							AddToElementRepository("LiteralInteger6", AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result_LiteralInteger6);
							AddToElementRepository("LiteralUnlimitedNatural7", AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result_LiteralUnlimitedNatural7);
							AddToElementRepository("LiteralInteger8", AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result_LiteralInteger8);
						AddToElementRepository("target", AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target);
							AddToElementRepository("LiteralInteger9", AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target_LiteralInteger9);
							AddToElementRepository("LiteralUnlimitedNatural10", AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target_LiteralUnlimitedNatural10);
					AddToElementRepository("Create A_Empty_Pattern", AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern);
						AddToElementRepository("result", AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result);
							AddToElementRepository("LiteralUnlimitedNatural11", AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result_LiteralUnlimitedNatural11);
							AddToElementRepository("LiteralInteger12", AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result_LiteralInteger12);
					AddToElementRepository("a_Empty_Pattern", AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_a_Empty_Pattern);
				AddToElementRepository("C", AssemblyConnectors_P_P_C);
				AddToElementRepository("assert_A_Star_Pattern", AssemblyConnectors_P_P_assert_A_Star_Pattern);
					AddToElementRepository("a_Star_Pattern", AssemblyConnectors_P_P_assert_A_Star_Pattern_a_Star_Pattern);
					AddToElementRepository("a_Star_Pattern_node", AssemblyConnectors_P_P_assert_A_Star_Pattern_a_Star_Pattern_node);
						AddToElementRepository("LiteralInteger13", AssemblyConnectors_P_P_assert_A_Star_Pattern_a_Star_Pattern_node_LiteralInteger13);
					AddToElementRepository("ObjectFlow14", AssemblyConnectors_P_P_assert_A_Star_Pattern_ObjectFlow14);
						AddToElementRepository("LiteralInteger15", AssemblyConnectors_P_P_assert_A_Star_Pattern_ObjectFlow14_LiteralInteger15);
						AddToElementRepository("LiteralBoolean16", AssemblyConnectors_P_P_assert_A_Star_Pattern_ObjectFlow14_LiteralBoolean16);
					AddToElementRepository("message", AssemblyConnectors_P_P_assert_A_Star_Pattern_message);
						AddToElementRepository("result", AssemblyConnectors_P_P_assert_A_Star_Pattern_message_result);
							AddToElementRepository("LiteralUnlimitedNatural17", AssemblyConnectors_P_P_assert_A_Star_Pattern_message_result_LiteralUnlimitedNatural17);
							AddToElementRepository("LiteralInteger18", AssemblyConnectors_P_P_assert_A_Star_Pattern_message_result_LiteralInteger18);
						AddToElementRepository("LiteralString19", AssemblyConnectors_P_P_assert_A_Star_Pattern_message_LiteralString19);
					AddToElementRepository("writeLine", AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine);
						AddToElementRepository("errorStatus", AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine_errorStatus);
							AddToElementRepository("LiteralInteger20", AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine_errorStatus_LiteralInteger20);
							AddToElementRepository("LiteralUnlimitedNatural21", AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural21);
							AddToElementRepository("LiteralInteger22", AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine_errorStatus_LiteralInteger22);
						AddToElementRepository("value", AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine_value);
							AddToElementRepository("LiteralInteger23", AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine_value_LiteralInteger23);
							AddToElementRepository("LiteralInteger24", AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine_value_LiteralInteger24);
							AddToElementRepository("LiteralUnlimitedNatural25", AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine_value_LiteralUnlimitedNatural25);
				AddToElementRepository("B", AssemblyConnectors_P_P_B);
				AddToElementRepository("A_Star_Pattern", AssemblyConnectors_P_P_A_Star_Pattern);
					AddToElementRepository("Comment26", AssemblyConnectors_P_P_A_Star_Pattern_Comment26);
					AddToElementRepository("partC", AssemblyConnectors_P_P_A_Star_Pattern_partC);
						AddToElementRepository("LiteralUnlimitedNatural27", AssemblyConnectors_P_P_A_Star_Pattern_partC_LiteralUnlimitedNatural27);
						AddToElementRepository("LiteralInteger28", AssemblyConnectors_P_P_A_Star_Pattern_partC_LiteralInteger28);
					AddToElementRepository("A_Star_Pattern_A_Star_Pattern", AssemblyConnectors_P_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern);
						AddToElementRepository("result", AssemblyConnectors_P_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result);
					AddToElementRepository("r", AssemblyConnectors_P_P_A_Star_Pattern_r);
						AddToElementRepository("ConnectorEnd29", AssemblyConnectors_P_P_A_Star_Pattern_r_ConnectorEnd29);
							AddToElementRepository("connectorEnd_2_Lower", AssemblyConnectors_P_P_A_Star_Pattern_r_ConnectorEnd29_connectorEnd_2_Lower);
							AddToElementRepository("connectorEnd_2_Upper", AssemblyConnectors_P_P_A_Star_Pattern_r_ConnectorEnd29_connectorEnd_2_Upper);
						AddToElementRepository("ConnectorEnd30", AssemblyConnectors_P_P_A_Star_Pattern_r_ConnectorEnd30);
							AddToElementRepository("connectorEnd_1_Upper", AssemblyConnectors_P_P_A_Star_Pattern_r_ConnectorEnd30_connectorEnd_1_Upper);
							AddToElementRepository("connectorEnd_1_Lower", AssemblyConnectors_P_P_A_Star_Pattern_r_ConnectorEnd30_connectorEnd_1_Lower);
					AddToElementRepository("partB", AssemblyConnectors_P_P_A_Star_Pattern_partB);
						AddToElementRepository("LiteralUnlimitedNatural31", AssemblyConnectors_P_P_A_Star_Pattern_partB_LiteralUnlimitedNatural31);
						AddToElementRepository("LiteralInteger32", AssemblyConnectors_P_P_A_Star_Pattern_partB_LiteralInteger32);
				AddToElementRepository("R", AssemblyConnectors_P_P_R);
					AddToElementRepository("y", AssemblyConnectors_P_P_R_y);
						AddToElementRepository("LiteralInteger33", AssemblyConnectors_P_P_R_y_LiteralInteger33);
						AddToElementRepository("LiteralUnlimitedNatural34", AssemblyConnectors_P_P_R_y_LiteralUnlimitedNatural34);
					AddToElementRepository("x", AssemblyConnectors_P_P_R_x);
						AddToElementRepository("LiteralInteger35", AssemblyConnectors_P_P_R_x_LiteralInteger35);
						AddToElementRepository("LiteralUnlimitedNatural36", AssemblyConnectors_P_P_R_x_LiteralUnlimitedNatural36);
				AddToElementRepository("main", AssemblyConnectors_P_P_main);
					AddToElementRepository("instantiate_A_Star_Pattern", AssemblyConnectors_P_P_main_instantiate_A_Star_Pattern);
						AddToElementRepository("a_Star_Pattern", AssemblyConnectors_P_P_main_instantiate_A_Star_Pattern_a_Star_Pattern);
							AddToElementRepository("LiteralInteger37", AssemblyConnectors_P_P_main_instantiate_A_Star_Pattern_a_Star_Pattern_LiteralInteger37);
							AddToElementRepository("LiteralUnlimitedNatural38", AssemblyConnectors_P_P_main_instantiate_A_Star_Pattern_a_Star_Pattern_LiteralUnlimitedNatural38);
							AddToElementRepository("LiteralInteger39", AssemblyConnectors_P_P_main_instantiate_A_Star_Pattern_a_Star_Pattern_LiteralInteger39);
					AddToElementRepository("ObjectFlow40", AssemblyConnectors_P_P_main_ObjectFlow40);
						AddToElementRepository("LiteralBoolean41", AssemblyConnectors_P_P_main_ObjectFlow40_LiteralBoolean41);
						AddToElementRepository("LiteralInteger42", AssemblyConnectors_P_P_main_ObjectFlow40_LiteralInteger42);
					AddToElementRepository("ObjectFlow43", AssemblyConnectors_P_P_main_ObjectFlow43);
						AddToElementRepository("LiteralBoolean44", AssemblyConnectors_P_P_main_ObjectFlow43_LiteralBoolean44);
						AddToElementRepository("LiteralInteger45", AssemblyConnectors_P_P_main_ObjectFlow43_LiteralInteger45);
					AddToElementRepository("assert_A_Array_Pattern", AssemblyConnectors_P_P_main_assert_A_Array_Pattern);
						AddToElementRepository("a_Array_Pattern", AssemblyConnectors_P_P_main_assert_A_Array_Pattern_a_Array_Pattern);
							AddToElementRepository("LiteralUnlimitedNatural46", AssemblyConnectors_P_P_main_assert_A_Array_Pattern_a_Array_Pattern_LiteralUnlimitedNatural46);
							AddToElementRepository("LiteralInteger47", AssemblyConnectors_P_P_main_assert_A_Array_Pattern_a_Array_Pattern_LiteralInteger47);
							AddToElementRepository("LiteralInteger48", AssemblyConnectors_P_P_main_assert_A_Array_Pattern_a_Array_Pattern_LiteralInteger48);
					AddToElementRepository("ObjectFlow49", AssemblyConnectors_P_P_main_ObjectFlow49);
						AddToElementRepository("LiteralInteger50", AssemblyConnectors_P_P_main_ObjectFlow49_LiteralInteger50);
						AddToElementRepository("LiteralBoolean51", AssemblyConnectors_P_P_main_ObjectFlow49_LiteralBoolean51);
					AddToElementRepository("ControlFlow52", AssemblyConnectors_P_P_main_ControlFlow52);
					AddToElementRepository("assert_A_Unconnected_Pattern", AssemblyConnectors_P_P_main_assert_A_Unconnected_Pattern);
						AddToElementRepository("a_Unconnected_Pattern", AssemblyConnectors_P_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern);
							AddToElementRepository("LiteralInteger53", AssemblyConnectors_P_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger53);
							AddToElementRepository("LiteralUnlimitedNatural54", AssemblyConnectors_P_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralUnlimitedNatural54);
							AddToElementRepository("LiteralInteger55", AssemblyConnectors_P_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger55);
					AddToElementRepository("ControlFlow56", AssemblyConnectors_P_P_main_ControlFlow56);
					AddToElementRepository("assert_A_Empty_Pattern", AssemblyConnectors_P_P_main_assert_A_Empty_Pattern);
						AddToElementRepository("a_Empty_Pattern", AssemblyConnectors_P_P_main_assert_A_Empty_Pattern_a_Empty_Pattern);
							AddToElementRepository("LiteralUnlimitedNatural57", AssemblyConnectors_P_P_main_assert_A_Empty_Pattern_a_Empty_Pattern_LiteralUnlimitedNatural57);
							AddToElementRepository("LiteralInteger58", AssemblyConnectors_P_P_main_assert_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger58);
							AddToElementRepository("LiteralInteger59", AssemblyConnectors_P_P_main_assert_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger59);
					AddToElementRepository("ObjectFlow60", AssemblyConnectors_P_P_main_ObjectFlow60);
						AddToElementRepository("LiteralBoolean61", AssemblyConnectors_P_P_main_ObjectFlow60_LiteralBoolean61);
						AddToElementRepository("LiteralInteger62", AssemblyConnectors_P_P_main_ObjectFlow60_LiteralInteger62);
					AddToElementRepository("instantiate_A_Unconnected_Pattern", AssemblyConnectors_P_P_main_instantiate_A_Unconnected_Pattern);
						AddToElementRepository("a_Unconnected_Pattern", AssemblyConnectors_P_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern);
							AddToElementRepository("LiteralUnlimitedNatural63", AssemblyConnectors_P_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralUnlimitedNatural63);
							AddToElementRepository("LiteralInteger64", AssemblyConnectors_P_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger64);
							AddToElementRepository("LiteralInteger65", AssemblyConnectors_P_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger65);
					AddToElementRepository("ControlFlow66", AssemblyConnectors_P_P_main_ControlFlow66);
					AddToElementRepository("instantiate_A_Array_Pattern", AssemblyConnectors_P_P_main_instantiate_A_Array_Pattern);
						AddToElementRepository("a_Array_Pattern", AssemblyConnectors_P_P_main_instantiate_A_Array_Pattern_a_Array_Pattern);
							AddToElementRepository("LiteralInteger67", AssemblyConnectors_P_P_main_instantiate_A_Array_Pattern_a_Array_Pattern_LiteralInteger67);
							AddToElementRepository("LiteralUnlimitedNatural68", AssemblyConnectors_P_P_main_instantiate_A_Array_Pattern_a_Array_Pattern_LiteralUnlimitedNatural68);
							AddToElementRepository("LiteralInteger69", AssemblyConnectors_P_P_main_instantiate_A_Array_Pattern_a_Array_Pattern_LiteralInteger69);
					AddToElementRepository("assert_A_Star_Pattern", AssemblyConnectors_P_P_main_assert_A_Star_Pattern);
						AddToElementRepository("a_Star_Pattern", AssemblyConnectors_P_P_main_assert_A_Star_Pattern_a_Star_Pattern);
							AddToElementRepository("LiteralInteger70", AssemblyConnectors_P_P_main_assert_A_Star_Pattern_a_Star_Pattern_LiteralInteger70);
							AddToElementRepository("LiteralInteger71", AssemblyConnectors_P_P_main_assert_A_Star_Pattern_a_Star_Pattern_LiteralInteger71);
							AddToElementRepository("LiteralUnlimitedNatural72", AssemblyConnectors_P_P_main_assert_A_Star_Pattern_a_Star_Pattern_LiteralUnlimitedNatural72);
					AddToElementRepository("instantiate_A_Empty_Pattern", AssemblyConnectors_P_P_main_instantiate_A_Empty_Pattern);
						AddToElementRepository("a_Empty_Pattern", AssemblyConnectors_P_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern);
							AddToElementRepository("LiteralInteger73", AssemblyConnectors_P_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger73);
							AddToElementRepository("LiteralUnlimitedNatural74", AssemblyConnectors_P_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern_LiteralUnlimitedNatural74);
							AddToElementRepository("LiteralInteger75", AssemblyConnectors_P_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger75);
				AddToElementRepository("instantiate_A_Unconnected_Pattern", AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern);
					AddToElementRepository("Create A_Unconnected_Pattern", AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern);
						AddToElementRepository("result", AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result);
							AddToElementRepository("LiteralUnlimitedNatural76", AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result_LiteralUnlimitedNatural76);
							AddToElementRepository("LiteralInteger77", AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result_LiteralInteger77);
					AddToElementRepository("ObjectFlow78", AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow78);
						AddToElementRepository("LiteralBoolean79", AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow78_LiteralBoolean79);
						AddToElementRepository("LiteralInteger80", AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow78_LiteralInteger80);
					AddToElementRepository("a_Unconnected_Pattern", AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern);
					AddToElementRepository("ObjectFlow81", AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow81);
						AddToElementRepository("LiteralBoolean82", AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow81_LiteralBoolean82);
						AddToElementRepository("LiteralInteger83", AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow81_LiteralInteger83);
					AddToElementRepository("a_Unconnected_Pattern_node", AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node);
					AddToElementRepository("A_Unconnected_Pattern()", AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_);
						AddToElementRepository("target", AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target);
							AddToElementRepository("LiteralUnlimitedNatural84", AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target_LiteralUnlimitedNatural84);
							AddToElementRepository("LiteralInteger85", AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target_LiteralInteger85);
						AddToElementRepository("result", AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result);
							AddToElementRepository("LiteralInteger86", AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result_LiteralInteger86);
							AddToElementRepository("LiteralInteger87", AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result_LiteralInteger87);
							AddToElementRepository("LiteralUnlimitedNatural88", AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result_LiteralUnlimitedNatural88);
				AddToElementRepository("assert_A_Empty_Pattern", AssemblyConnectors_P_P_assert_A_Empty_Pattern);
					AddToElementRepository("writeLine", AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine);
						AddToElementRepository("value", AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine_value);
							AddToElementRepository("LiteralInteger89", AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine_value_LiteralInteger89);
							AddToElementRepository("LiteralUnlimitedNatural90", AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine_value_LiteralUnlimitedNatural90);
							AddToElementRepository("LiteralInteger91", AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine_value_LiteralInteger91);
						AddToElementRepository("errorStatus", AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine_errorStatus);
							AddToElementRepository("LiteralInteger92", AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine_errorStatus_LiteralInteger92);
							AddToElementRepository("LiteralInteger93", AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine_errorStatus_LiteralInteger93);
							AddToElementRepository("LiteralUnlimitedNatural94", AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural94);
					AddToElementRepository("ObjectFlow95", AssemblyConnectors_P_P_assert_A_Empty_Pattern_ObjectFlow95);
						AddToElementRepository("LiteralBoolean96", AssemblyConnectors_P_P_assert_A_Empty_Pattern_ObjectFlow95_LiteralBoolean96);
						AddToElementRepository("LiteralInteger97", AssemblyConnectors_P_P_assert_A_Empty_Pattern_ObjectFlow95_LiteralInteger97);
					AddToElementRepository("a_Empty_Pattern", AssemblyConnectors_P_P_assert_A_Empty_Pattern_a_Empty_Pattern);
					AddToElementRepository("message", AssemblyConnectors_P_P_assert_A_Empty_Pattern_message);
						AddToElementRepository("result", AssemblyConnectors_P_P_assert_A_Empty_Pattern_message_result);
							AddToElementRepository("LiteralUnlimitedNatural98", AssemblyConnectors_P_P_assert_A_Empty_Pattern_message_result_LiteralUnlimitedNatural98);
							AddToElementRepository("LiteralInteger99", AssemblyConnectors_P_P_assert_A_Empty_Pattern_message_result_LiteralInteger99);
						AddToElementRepository("LiteralString100", AssemblyConnectors_P_P_assert_A_Empty_Pattern_message_LiteralString100);
					AddToElementRepository("a_Empty_Pattern_node", AssemblyConnectors_P_P_assert_A_Empty_Pattern_a_Empty_Pattern_node);
						AddToElementRepository("LiteralInteger101", AssemblyConnectors_P_P_assert_A_Empty_Pattern_a_Empty_Pattern_node_LiteralInteger101);
				AddToElementRepository("A_Unconnected_Pattern", AssemblyConnectors_P_P_A_Unconnected_Pattern);
					AddToElementRepository("Comment102", AssemblyConnectors_P_P_A_Unconnected_Pattern_Comment102);
					AddToElementRepository("partC", AssemblyConnectors_P_P_A_Unconnected_Pattern_partC);
						AddToElementRepository("LiteralInteger103", AssemblyConnectors_P_P_A_Unconnected_Pattern_partC_LiteralInteger103);
						AddToElementRepository("LiteralUnlimitedNatural104", AssemblyConnectors_P_P_A_Unconnected_Pattern_partC_LiteralUnlimitedNatural104);
					AddToElementRepository("partB", AssemblyConnectors_P_P_A_Unconnected_Pattern_partB);
						AddToElementRepository("LiteralUnlimitedNatural105", AssemblyConnectors_P_P_A_Unconnected_Pattern_partB_LiteralUnlimitedNatural105);
						AddToElementRepository("LiteralInteger106", AssemblyConnectors_P_P_A_Unconnected_Pattern_partB_LiteralInteger106);
					AddToElementRepository("r", AssemblyConnectors_P_P_A_Unconnected_Pattern_r);
						AddToElementRepository("ConnectorEnd107", AssemblyConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd107);
							AddToElementRepository("connectorEnd_2_Lower", AssemblyConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd107_connectorEnd_2_Lower);
							AddToElementRepository("connectorEnd_2_Upper", AssemblyConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd107_connectorEnd_2_Upper);
						AddToElementRepository("ConnectorEnd108", AssemblyConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd108);
							AddToElementRepository("connectorEnd_1_Lower", AssemblyConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd108_connectorEnd_1_Lower);
							AddToElementRepository("connectorEnd_1_Upper", AssemblyConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd108_connectorEnd_1_Upper);
					AddToElementRepository("A_Unconnected_Pattern_A_Unconnected_Pattern", AssemblyConnectors_P_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern);
						AddToElementRepository("result", AssemblyConnectors_P_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result);
				AddToElementRepository("A_Array_Pattern", AssemblyConnectors_P_P_A_Array_Pattern);
					AddToElementRepository("partB", AssemblyConnectors_P_P_A_Array_Pattern_partB);
						AddToElementRepository("LiteralInteger109", AssemblyConnectors_P_P_A_Array_Pattern_partB_LiteralInteger109);
						AddToElementRepository("LiteralUnlimitedNatural110", AssemblyConnectors_P_P_A_Array_Pattern_partB_LiteralUnlimitedNatural110);
					AddToElementRepository("partC", AssemblyConnectors_P_P_A_Array_Pattern_partC);
						AddToElementRepository("LiteralUnlimitedNatural111", AssemblyConnectors_P_P_A_Array_Pattern_partC_LiteralUnlimitedNatural111);
						AddToElementRepository("LiteralInteger112", AssemblyConnectors_P_P_A_Array_Pattern_partC_LiteralInteger112);
					AddToElementRepository("Comment113", AssemblyConnectors_P_P_A_Array_Pattern_Comment113);
					AddToElementRepository("r", AssemblyConnectors_P_P_A_Array_Pattern_r);
						AddToElementRepository("ConnectorEnd114", AssemblyConnectors_P_P_A_Array_Pattern_r_ConnectorEnd114);
							AddToElementRepository("connectorEnd_1_Lower", AssemblyConnectors_P_P_A_Array_Pattern_r_ConnectorEnd114_connectorEnd_1_Lower);
							AddToElementRepository("connectorEnd_1_Upper", AssemblyConnectors_P_P_A_Array_Pattern_r_ConnectorEnd114_connectorEnd_1_Upper);
						AddToElementRepository("ConnectorEnd115", AssemblyConnectors_P_P_A_Array_Pattern_r_ConnectorEnd115);
							AddToElementRepository("connectorEnd_2_Lower", AssemblyConnectors_P_P_A_Array_Pattern_r_ConnectorEnd115_connectorEnd_2_Lower);
							AddToElementRepository("connectorEnd_2_Upper", AssemblyConnectors_P_P_A_Array_Pattern_r_ConnectorEnd115_connectorEnd_2_Upper);
					AddToElementRepository("A_Array_Pattern_A_Array_Pattern", AssemblyConnectors_P_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern);
						AddToElementRepository("result", AssemblyConnectors_P_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result);
				AddToElementRepository("assert_A_Array_Pattern", AssemblyConnectors_P_P_assert_A_Array_Pattern);
					AddToElementRepository("writeLine", AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine);
						AddToElementRepository("value", AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine_value);
							AddToElementRepository("LiteralInteger116", AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine_value_LiteralInteger116);
							AddToElementRepository("LiteralUnlimitedNatural117", AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine_value_LiteralUnlimitedNatural117);
							AddToElementRepository("LiteralInteger118", AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine_value_LiteralInteger118);
						AddToElementRepository("errorStatus", AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine_errorStatus);
							AddToElementRepository("LiteralUnlimitedNatural119", AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural119);
							AddToElementRepository("LiteralInteger120", AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine_errorStatus_LiteralInteger120);
							AddToElementRepository("LiteralInteger121", AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine_errorStatus_LiteralInteger121);
					AddToElementRepository("ObjectFlow122", AssemblyConnectors_P_P_assert_A_Array_Pattern_ObjectFlow122);
						AddToElementRepository("LiteralBoolean123", AssemblyConnectors_P_P_assert_A_Array_Pattern_ObjectFlow122_LiteralBoolean123);
						AddToElementRepository("LiteralInteger124", AssemblyConnectors_P_P_assert_A_Array_Pattern_ObjectFlow122_LiteralInteger124);
					AddToElementRepository("message", AssemblyConnectors_P_P_assert_A_Array_Pattern_message);
						AddToElementRepository("LiteralString125", AssemblyConnectors_P_P_assert_A_Array_Pattern_message_LiteralString125);
						AddToElementRepository("result", AssemblyConnectors_P_P_assert_A_Array_Pattern_message_result);
							AddToElementRepository("LiteralInteger126", AssemblyConnectors_P_P_assert_A_Array_Pattern_message_result_LiteralInteger126);
							AddToElementRepository("LiteralUnlimitedNatural127", AssemblyConnectors_P_P_assert_A_Array_Pattern_message_result_LiteralUnlimitedNatural127);
					AddToElementRepository("a_Array_Pattern", AssemblyConnectors_P_P_assert_A_Array_Pattern_a_Array_Pattern);
					AddToElementRepository("a_Array_Pattern_node", AssemblyConnectors_P_P_assert_A_Array_Pattern_a_Array_Pattern_node);
						AddToElementRepository("LiteralInteger128", AssemblyConnectors_P_P_assert_A_Array_Pattern_a_Array_Pattern_node_LiteralInteger128);
				AddToElementRepository("instantiate_A_Star_Pattern", AssemblyConnectors_P_P_instantiate_A_Star_Pattern);
					AddToElementRepository("Create A_Star_Pattern", AssemblyConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern);
						AddToElementRepository("result", AssemblyConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result);
							AddToElementRepository("LiteralUnlimitedNatural129", AssemblyConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result_LiteralUnlimitedNatural129);
							AddToElementRepository("LiteralInteger130", AssemblyConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result_LiteralInteger130);
					AddToElementRepository("a_Star_Pattern", AssemblyConnectors_P_P_instantiate_A_Star_Pattern_a_Star_Pattern);
					AddToElementRepository("ObjectFlow131", AssemblyConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow131);
						AddToElementRepository("LiteralBoolean132", AssemblyConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow131_LiteralBoolean132);
						AddToElementRepository("LiteralInteger133", AssemblyConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow131_LiteralInteger133);
					AddToElementRepository("ObjectFlow134", AssemblyConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow134);
						AddToElementRepository("LiteralInteger135", AssemblyConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow134_LiteralInteger135);
						AddToElementRepository("LiteralBoolean136", AssemblyConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow134_LiteralBoolean136);
					AddToElementRepository("A_Star_Pattern()", AssemblyConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern_);
						AddToElementRepository("result", AssemblyConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__result);
							AddToElementRepository("LiteralInteger137", AssemblyConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__result_LiteralInteger137);
							AddToElementRepository("LiteralUnlimitedNatural138", AssemblyConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__result_LiteralUnlimitedNatural138);
							AddToElementRepository("LiteralInteger139", AssemblyConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__result_LiteralInteger139);
						AddToElementRepository("target", AssemblyConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__target);
							AddToElementRepository("LiteralUnlimitedNatural140", AssemblyConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__target_LiteralUnlimitedNatural140);
							AddToElementRepository("LiteralInteger141", AssemblyConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__target_LiteralInteger141);
					AddToElementRepository("a_Star_Pattern_node", AssemblyConnectors_P_P_instantiate_A_Star_Pattern_a_Star_Pattern_node);
				AddToElementRepository("instantiate_A_Array_Pattern", AssemblyConnectors_P_P_instantiate_A_Array_Pattern);
					AddToElementRepository("a_Array_Pattern_node", AssemblyConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern_node);
						AddToElementRepository("LiteralInteger142", AssemblyConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern_node_LiteralInteger142);
					AddToElementRepository("A_Array_Pattern()", AssemblyConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern_);
						AddToElementRepository("target", AssemblyConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__target);
							AddToElementRepository("LiteralUnlimitedNatural143", AssemblyConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__target_LiteralUnlimitedNatural143);
							AddToElementRepository("LiteralInteger144", AssemblyConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__target_LiteralInteger144);
						AddToElementRepository("result", AssemblyConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__result);
							AddToElementRepository("LiteralInteger145", AssemblyConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__result_LiteralInteger145);
							AddToElementRepository("LiteralUnlimitedNatural146", AssemblyConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__result_LiteralUnlimitedNatural146);
							AddToElementRepository("LiteralInteger147", AssemblyConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__result_LiteralInteger147);
					AddToElementRepository("ObjectFlow148", AssemblyConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow148);
						AddToElementRepository("LiteralInteger149", AssemblyConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow148_LiteralInteger149);
						AddToElementRepository("LiteralBoolean150", AssemblyConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow148_LiteralBoolean150);
					AddToElementRepository("a_Array_Pattern", AssemblyConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern);
					AddToElementRepository("Create A_Array_Pattern", AssemblyConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern);
						AddToElementRepository("result", AssemblyConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result);
							AddToElementRepository("LiteralInteger151", AssemblyConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result_LiteralInteger151);
							AddToElementRepository("LiteralUnlimitedNatural152", AssemblyConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result_LiteralUnlimitedNatural152);
					AddToElementRepository("ObjectFlow153", AssemblyConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow153);
						AddToElementRepository("LiteralBoolean154", AssemblyConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow153_LiteralBoolean154);
						AddToElementRepository("LiteralInteger155", AssemblyConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow153_LiteralInteger155);
				AddToElementRepository("assert_A_Unconnected_Pattern", AssemblyConnectors_P_P_assert_A_Unconnected_Pattern);
					AddToElementRepository("ObjectFlow156", AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_ObjectFlow156);
						AddToElementRepository("LiteralInteger157", AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_ObjectFlow156_LiteralInteger157);
						AddToElementRepository("LiteralBoolean158", AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_ObjectFlow156_LiteralBoolean158);
					AddToElementRepository("writeLine", AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine);
						AddToElementRepository("value", AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_value);
							AddToElementRepository("LiteralUnlimitedNatural159", AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_value_LiteralUnlimitedNatural159);
							AddToElementRepository("LiteralInteger160", AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_value_LiteralInteger160);
							AddToElementRepository("LiteralInteger161", AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_value_LiteralInteger161);
						AddToElementRepository("errorStatus", AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_errorStatus);
							AddToElementRepository("LiteralUnlimitedNatural162", AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural162);
							AddToElementRepository("LiteralInteger163", AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_errorStatus_LiteralInteger163);
							AddToElementRepository("LiteralInteger164", AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_errorStatus_LiteralInteger164);
					AddToElementRepository("message", AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_message);
						AddToElementRepository("LiteralString165", AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_message_LiteralString165);
						AddToElementRepository("result", AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_message_result);
							AddToElementRepository("LiteralInteger166", AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_message_result_LiteralInteger166);
							AddToElementRepository("LiteralUnlimitedNatural167", AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_message_result_LiteralUnlimitedNatural167);
					AddToElementRepository("a_Unconnected_Pattern_node", AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node);
						AddToElementRepository("LiteralInteger168", AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node_LiteralInteger168);
					AddToElementRepository("a_Unconnected_Pattern", AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern);
				AddToElementRepository("A_Empty_Pattern", AssemblyConnectors_P_P_A_Empty_Pattern);
					AddToElementRepository("partB", AssemblyConnectors_P_P_A_Empty_Pattern_partB);
						AddToElementRepository("LiteralInteger169", AssemblyConnectors_P_P_A_Empty_Pattern_partB_LiteralInteger169);
						AddToElementRepository("LiteralUnlimitedNatural170", AssemblyConnectors_P_P_A_Empty_Pattern_partB_LiteralUnlimitedNatural170);
					AddToElementRepository("partC", AssemblyConnectors_P_P_A_Empty_Pattern_partC);
						AddToElementRepository("LiteralInteger171", AssemblyConnectors_P_P_A_Empty_Pattern_partC_LiteralInteger171);
						AddToElementRepository("LiteralUnlimitedNatural172", AssemblyConnectors_P_P_A_Empty_Pattern_partC_LiteralUnlimitedNatural172);
					AddToElementRepository("A_Empty_Pattern_A_Empty_Pattern", AssemblyConnectors_P_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern);
						AddToElementRepository("result", AssemblyConnectors_P_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result);
					AddToElementRepository("r", AssemblyConnectors_P_P_A_Empty_Pattern_r);
						AddToElementRepository("ConnectorEnd173", AssemblyConnectors_P_P_A_Empty_Pattern_r_ConnectorEnd173);
							AddToElementRepository("connectorEnd_2_Upper", AssemblyConnectors_P_P_A_Empty_Pattern_r_ConnectorEnd173_connectorEnd_2_Upper);
							AddToElementRepository("connectorEnd_2_Lower", AssemblyConnectors_P_P_A_Empty_Pattern_r_ConnectorEnd173_connectorEnd_2_Lower);
						AddToElementRepository("ConnectorEnd174", AssemblyConnectors_P_P_A_Empty_Pattern_r_ConnectorEnd174);
							AddToElementRepository("connectorEnd_1_Upper", AssemblyConnectors_P_P_A_Empty_Pattern_r_ConnectorEnd174_connectorEnd_1_Upper);
							AddToElementRepository("connectorEnd_1_Lower", AssemblyConnectors_P_P_A_Empty_Pattern_r_ConnectorEnd174_connectorEnd_1_Lower);
					AddToElementRepository("Comment175", AssemblyConnectors_P_P_A_Empty_Pattern_Comment175);

			// Initialize public members
			/*
			 * Model AssemblyConnectors_P_P
			 */
			AssemblyConnectors_P_P.SetName("AssemblyConnectors_P_P");
			AssemblyConnectors_P_P.SetVisibility(VisibilityKind.public_);
				// Activity instantiate_A_Empty_Pattern
				AssemblyConnectors_P_P_instantiate_A_Empty_Pattern.SetName("instantiate_A_Empty_Pattern");
				AssemblyConnectors_P_P_instantiate_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Empty_Pattern
					AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetName("a_Empty_Pattern");
					AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetType(AssemblyConnectors_P_P_A_Empty_Pattern);
					AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetDirection(ParameterDirectionKind.return_);
				AssemblyConnectors_P_P_instantiate_A_Empty_Pattern.AddOwnedParameter(AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_a_Empty_Pattern);
					// ActivityParameterNode a_Empty_Pattern_node
					AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_a_Empty_Pattern_node.SetName("a_Empty_Pattern_node");
					AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_a_Empty_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_a_Empty_Pattern_node.SetParameter(AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_a_Empty_Pattern);
				AssemblyConnectors_P_P_instantiate_A_Empty_Pattern.AddNode(AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_a_Empty_Pattern_node);
					// CallOperationAction A_Empty_Pattern()
					AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern_.SetName("A_Empty_Pattern()");
					AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result.SetName("result");
						AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result.SetType(AssemblyConnectors_P_P_A_Empty_Pattern);
					AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern_.AddResult(AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result);
					AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern_.SetOperation(AssemblyConnectors_P_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern);
						// InputPin target
						AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target.SetName("target");
						AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target.SetType(AssemblyConnectors_P_P_A_Empty_Pattern);
					AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern_.SetTarget(AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target);
				AssemblyConnectors_P_P_instantiate_A_Empty_Pattern.AddNode(AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern_);
					// CreateObjectAction Create A_Empty_Pattern
					AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern.SetName("Create A_Empty_Pattern");
					AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern.SetClassifier(AssemblyConnectors_P_P_A_Empty_Pattern);
						// OutputPin result
						AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result.SetName("result");
						AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result.SetType(AssemblyConnectors_P_P_A_Empty_Pattern);
					AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern.SetResult(AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result);
				AssemblyConnectors_P_P_instantiate_A_Empty_Pattern.AddNode(AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern);
					// ObjectFlow ObjectFlow0 from result to target
					AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow0.SetName("ObjectFlow0");
					AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow0.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow0.SetSource(AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result);
					AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow0.SetTarget(AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target);
						// LiteralBoolean LiteralBoolean2
						AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow0_LiteralBoolean2.SetName("LiteralBoolean2");
						AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow0_LiteralBoolean2.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow0_LiteralBoolean2.SetValue(true);
					AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow0.SetGuard(AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow0_LiteralBoolean2);
				AssemblyConnectors_P_P_instantiate_A_Empty_Pattern.AddEdge(AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow0);
					// ObjectFlow ObjectFlow3 from result to a_Empty_Pattern_node
					AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow3.SetName("ObjectFlow3");
					AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow3.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow3.SetSource(AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result);
					AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow3.SetTarget(AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_a_Empty_Pattern_node);
						// LiteralBoolean LiteralBoolean4
						AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow3_LiteralBoolean4.SetName("LiteralBoolean4");
						AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow3_LiteralBoolean4.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow3_LiteralBoolean4.SetValue(true);
					AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow3.SetGuard(AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow3_LiteralBoolean4);
				AssemblyConnectors_P_P_instantiate_A_Empty_Pattern.AddEdge(AssemblyConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow3);
			AssemblyConnectors_P_P.AddPackagedElement(AssemblyConnectors_P_P_instantiate_A_Empty_Pattern);
				// Class C
				AssemblyConnectors_P_P_C.SetName("C");
				AssemblyConnectors_P_P_C.SetVisibility(VisibilityKind.public_);
			AssemblyConnectors_P_P.AddPackagedElement(AssemblyConnectors_P_P_C);
				// Activity assert_A_Star_Pattern
				AssemblyConnectors_P_P_assert_A_Star_Pattern.SetName("assert_A_Star_Pattern");
				AssemblyConnectors_P_P_assert_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Star_Pattern
					AssemblyConnectors_P_P_assert_A_Star_Pattern_a_Star_Pattern.SetName("a_Star_Pattern");
					AssemblyConnectors_P_P_assert_A_Star_Pattern_a_Star_Pattern.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_assert_A_Star_Pattern_a_Star_Pattern.SetType(AssemblyConnectors_P_P_A_Star_Pattern);
				AssemblyConnectors_P_P_assert_A_Star_Pattern.AddOwnedParameter(AssemblyConnectors_P_P_assert_A_Star_Pattern_a_Star_Pattern);
					// ActivityParameterNode a_Star_Pattern_node
					AssemblyConnectors_P_P_assert_A_Star_Pattern_a_Star_Pattern_node.SetName("a_Star_Pattern_node");
					AssemblyConnectors_P_P_assert_A_Star_Pattern_a_Star_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_assert_A_Star_Pattern_a_Star_Pattern_node.SetParameter(AssemblyConnectors_P_P_assert_A_Star_Pattern_a_Star_Pattern);
				AssemblyConnectors_P_P_assert_A_Star_Pattern.AddNode(AssemblyConnectors_P_P_assert_A_Star_Pattern_a_Star_Pattern_node);
					// ValueSpecificationAction message
					AssemblyConnectors_P_P_assert_A_Star_Pattern_message.SetName("message");
					AssemblyConnectors_P_P_assert_A_Star_Pattern_message.SetVisibility(VisibilityKind.public_);
						// LiteralString LiteralString19
						AssemblyConnectors_P_P_assert_A_Star_Pattern_message_LiteralString19.SetName("LiteralString19");
						AssemblyConnectors_P_P_assert_A_Star_Pattern_message_LiteralString19.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_assert_A_Star_Pattern_message_LiteralString19.SetValue("Assertion currently not implemented for A_Star_Pattern.");
					AssemblyConnectors_P_P_assert_A_Star_Pattern_message.SetValue(AssemblyConnectors_P_P_assert_A_Star_Pattern_message_LiteralString19);
						// OutputPin result
						AssemblyConnectors_P_P_assert_A_Star_Pattern_message_result.SetName("result");
						AssemblyConnectors_P_P_assert_A_Star_Pattern_message_result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_assert_A_Star_Pattern_message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					AssemblyConnectors_P_P_assert_A_Star_Pattern_message.SetResult(AssemblyConnectors_P_P_assert_A_Star_Pattern_message_result);
				AssemblyConnectors_P_P_assert_A_Star_Pattern.AddNode(AssemblyConnectors_P_P_assert_A_Star_Pattern_message);
					// CallBehaviorAction writeLine
					AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine.SetName("writeLine");
					AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine.SetVisibility(VisibilityKind.public_);
					
						// OutputPin errorStatus
						AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine_errorStatus.SetName("errorStatus");
						AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine_errorStatus.SetVisibility(VisibilityKind.public_);
						
						AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine_errorStatus.SetLower(0);
					AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine.AddResult(AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine_errorStatus);
					AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
						// InputPin value
						AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine_value.SetName("value");
						AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine_value.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine.AddArgument(AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine_value);
				AssemblyConnectors_P_P_assert_A_Star_Pattern.AddNode(AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine);
					// ObjectFlow ObjectFlow14 from result to value
					AssemblyConnectors_P_P_assert_A_Star_Pattern_ObjectFlow14.SetName("ObjectFlow14");
					AssemblyConnectors_P_P_assert_A_Star_Pattern_ObjectFlow14.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_assert_A_Star_Pattern_ObjectFlow14.SetSource(AssemblyConnectors_P_P_assert_A_Star_Pattern_message_result);
					AssemblyConnectors_P_P_assert_A_Star_Pattern_ObjectFlow14.SetTarget(AssemblyConnectors_P_P_assert_A_Star_Pattern_writeLine_value);
						// LiteralBoolean LiteralBoolean16
						AssemblyConnectors_P_P_assert_A_Star_Pattern_ObjectFlow14_LiteralBoolean16.SetName("LiteralBoolean16");
						AssemblyConnectors_P_P_assert_A_Star_Pattern_ObjectFlow14_LiteralBoolean16.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_assert_A_Star_Pattern_ObjectFlow14_LiteralBoolean16.SetValue(true);
					AssemblyConnectors_P_P_assert_A_Star_Pattern_ObjectFlow14.SetGuard(AssemblyConnectors_P_P_assert_A_Star_Pattern_ObjectFlow14_LiteralBoolean16);
				AssemblyConnectors_P_P_assert_A_Star_Pattern.AddEdge(AssemblyConnectors_P_P_assert_A_Star_Pattern_ObjectFlow14);
			AssemblyConnectors_P_P.AddPackagedElement(AssemblyConnectors_P_P_assert_A_Star_Pattern);
				// Class B
				AssemblyConnectors_P_P_B.SetName("B");
				AssemblyConnectors_P_P_B.SetVisibility(VisibilityKind.public_);
			AssemblyConnectors_P_P.AddPackagedElement(AssemblyConnectors_P_P_B);
				// Class A_Star_Pattern
				AssemblyConnectors_P_P_A_Star_Pattern.SetName("A_Star_Pattern");
				AssemblyConnectors_P_P_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Property partB
					AssemblyConnectors_P_P_A_Star_Pattern_partB.SetName("partB");
					AssemblyConnectors_P_P_A_Star_Pattern_partB.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_P_P_A_Star_Pattern_partB.SetUpper(-1);
					AssemblyConnectors_P_P_A_Star_Pattern_partB.SetLower(4);
					AssemblyConnectors_P_P_A_Star_Pattern_partB.SetType(AssemblyConnectors_P_P_B);
					AssemblyConnectors_P_P_A_Star_Pattern_partB.SetAggregation(AggregationKind.composite);
				AssemblyConnectors_P_P_A_Star_Pattern.AddOwnedAttribute(AssemblyConnectors_P_P_A_Star_Pattern_partB);
					// Property partC
					AssemblyConnectors_P_P_A_Star_Pattern_partC.SetName("partC");
					AssemblyConnectors_P_P_A_Star_Pattern_partC.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_P_P_A_Star_Pattern_partC.SetUpper(-1);
					AssemblyConnectors_P_P_A_Star_Pattern_partC.SetLower(3);
					AssemblyConnectors_P_P_A_Star_Pattern_partC.SetType(AssemblyConnectors_P_P_C);
					AssemblyConnectors_P_P_A_Star_Pattern_partC.SetAggregation(AggregationKind.composite);
				AssemblyConnectors_P_P_A_Star_Pattern.AddOwnedAttribute(AssemblyConnectors_P_P_A_Star_Pattern_partC);
				
				AssemblyConnectors_P_P_A_Star_Pattern_r.SetName("r");
					AssemblyConnectors_P_P_A_Star_Pattern_r.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_A_Star_Pattern_r_ConnectorEnd30.SetUpper(-1);
						AssemblyConnectors_P_P_A_Star_Pattern_r_ConnectorEnd30.SetLower(4);
						AssemblyConnectors_P_P_A_Star_Pattern_r_ConnectorEnd30.SetRole(AssemblyConnectors_P_P_A_Star_Pattern_partB);
						
					AssemblyConnectors_P_P_A_Star_Pattern_r.AddEnd(AssemblyConnectors_P_P_A_Star_Pattern_r_ConnectorEnd30);
						AssemblyConnectors_P_P_A_Star_Pattern_r_ConnectorEnd29.SetUpper(-1);
						AssemblyConnectors_P_P_A_Star_Pattern_r_ConnectorEnd29.SetLower(3);
						AssemblyConnectors_P_P_A_Star_Pattern_r_ConnectorEnd29.SetRole(AssemblyConnectors_P_P_A_Star_Pattern_partC);
						
					AssemblyConnectors_P_P_A_Star_Pattern_r.AddEnd(AssemblyConnectors_P_P_A_Star_Pattern_r_ConnectorEnd29);
					AssemblyConnectors_P_P_A_Star_Pattern_r.SetType(AssemblyConnectors_P_P_R);
				AssemblyConnectors_P_P_A_Star_Pattern.AddOwnedConnector(AssemblyConnectors_P_P_A_Star_Pattern_r);
					// Operation A_Star_Pattern_A_Star_Pattern
					AssemblyConnectors_P_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern.SetName("A_Star_Pattern_A_Star_Pattern");
					AssemblyConnectors_P_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
						// Parameter result
						AssemblyConnectors_P_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result.SetName("result");
						AssemblyConnectors_P_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result.SetVisibility(VisibilityKind.public_);
						
						AssemblyConnectors_P_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result.SetType(AssemblyConnectors_P_P_A_Star_Pattern);
						AssemblyConnectors_P_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result.SetDirection(ParameterDirectionKind.return_);
					AssemblyConnectors_P_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern.AddOwnedParameter(AssemblyConnectors_P_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result);
					AssemblyConnectors_P_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				AssemblyConnectors_P_P_A_Star_Pattern.AddOwnedOperation(AssemblyConnectors_P_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern);
			AssemblyConnectors_P_P.AddPackagedElement(AssemblyConnectors_P_P_A_Star_Pattern);
				// Association R
				AssemblyConnectors_P_P_R.SetName("R");
				AssemblyConnectors_P_P_R.SetVisibility(VisibilityKind.public_);
				AssemblyConnectors_P_P_R.AddOwnedEnd(AssemblyConnectors_P_P_R_x);
				AssemblyConnectors_P_P_R.AddOwnedEnd(AssemblyConnectors_P_P_R_y);
			AssemblyConnectors_P_P.AddPackagedElement(AssemblyConnectors_P_P_R);
				// Activity main
				AssemblyConnectors_P_P_main.SetName("main");
				AssemblyConnectors_P_P_main.SetVisibility(VisibilityKind.public_);
					// CallBehaviorAction assert_A_Unconnected_Pattern
					AssemblyConnectors_P_P_main_assert_A_Unconnected_Pattern.SetName("assert_A_Unconnected_Pattern");
					AssemblyConnectors_P_P_main_assert_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_P_P_main_assert_A_Unconnected_Pattern.SetBehavior(AssemblyConnectors_P_P_assert_A_Unconnected_Pattern);
						// InputPin a_Unconnected_Pattern
						AssemblyConnectors_P_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern.SetName("a_Unconnected_Pattern");
						AssemblyConnectors_P_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern.SetType(AssemblyConnectors_P_P_A_Unconnected_Pattern);
					AssemblyConnectors_P_P_main_assert_A_Unconnected_Pattern.AddArgument(AssemblyConnectors_P_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern);
				AssemblyConnectors_P_P_main.AddNode(AssemblyConnectors_P_P_main_assert_A_Unconnected_Pattern);
					// CallBehaviorAction instantiate_A_Star_Pattern
					AssemblyConnectors_P_P_main_instantiate_A_Star_Pattern.SetName("instantiate_A_Star_Pattern");
					AssemblyConnectors_P_P_main_instantiate_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
					
						// OutputPin a_Star_Pattern
						AssemblyConnectors_P_P_main_instantiate_A_Star_Pattern_a_Star_Pattern.SetName("a_Star_Pattern");
						AssemblyConnectors_P_P_main_instantiate_A_Star_Pattern_a_Star_Pattern.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_main_instantiate_A_Star_Pattern_a_Star_Pattern.SetType(AssemblyConnectors_P_P_A_Star_Pattern);
					AssemblyConnectors_P_P_main_instantiate_A_Star_Pattern.AddResult(AssemblyConnectors_P_P_main_instantiate_A_Star_Pattern_a_Star_Pattern);
					AssemblyConnectors_P_P_main_instantiate_A_Star_Pattern.SetBehavior(AssemblyConnectors_P_P_instantiate_A_Star_Pattern);
				AssemblyConnectors_P_P_main.AddNode(AssemblyConnectors_P_P_main_instantiate_A_Star_Pattern);
					// CallBehaviorAction assert_A_Empty_Pattern
					AssemblyConnectors_P_P_main_assert_A_Empty_Pattern.SetName("assert_A_Empty_Pattern");
					AssemblyConnectors_P_P_main_assert_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_P_P_main_assert_A_Empty_Pattern.SetBehavior(AssemblyConnectors_P_P_assert_A_Empty_Pattern);
						// InputPin a_Empty_Pattern
						AssemblyConnectors_P_P_main_assert_A_Empty_Pattern_a_Empty_Pattern.SetName("a_Empty_Pattern");
						AssemblyConnectors_P_P_main_assert_A_Empty_Pattern_a_Empty_Pattern.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_main_assert_A_Empty_Pattern_a_Empty_Pattern.SetType(AssemblyConnectors_P_P_A_Empty_Pattern);
					AssemblyConnectors_P_P_main_assert_A_Empty_Pattern.AddArgument(AssemblyConnectors_P_P_main_assert_A_Empty_Pattern_a_Empty_Pattern);
				AssemblyConnectors_P_P_main.AddNode(AssemblyConnectors_P_P_main_assert_A_Empty_Pattern);
					// CallBehaviorAction assert_A_Array_Pattern
					AssemblyConnectors_P_P_main_assert_A_Array_Pattern.SetName("assert_A_Array_Pattern");
					AssemblyConnectors_P_P_main_assert_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_P_P_main_assert_A_Array_Pattern.SetBehavior(AssemblyConnectors_P_P_assert_A_Array_Pattern);
						// InputPin a_Array_Pattern
						AssemblyConnectors_P_P_main_assert_A_Array_Pattern_a_Array_Pattern.SetName("a_Array_Pattern");
						AssemblyConnectors_P_P_main_assert_A_Array_Pattern_a_Array_Pattern.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_main_assert_A_Array_Pattern_a_Array_Pattern.SetType(AssemblyConnectors_P_P_A_Array_Pattern);
					AssemblyConnectors_P_P_main_assert_A_Array_Pattern.AddArgument(AssemblyConnectors_P_P_main_assert_A_Array_Pattern_a_Array_Pattern);
				AssemblyConnectors_P_P_main.AddNode(AssemblyConnectors_P_P_main_assert_A_Array_Pattern);
					// CallBehaviorAction instantiate_A_Unconnected_Pattern
					AssemblyConnectors_P_P_main_instantiate_A_Unconnected_Pattern.SetName("instantiate_A_Unconnected_Pattern");
					AssemblyConnectors_P_P_main_instantiate_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
					
						// OutputPin a_Unconnected_Pattern
						AssemblyConnectors_P_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetName("a_Unconnected_Pattern");
						AssemblyConnectors_P_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetType(AssemblyConnectors_P_P_A_Unconnected_Pattern);
					AssemblyConnectors_P_P_main_instantiate_A_Unconnected_Pattern.AddResult(AssemblyConnectors_P_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern);
					AssemblyConnectors_P_P_main_instantiate_A_Unconnected_Pattern.SetBehavior(AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern);
				AssemblyConnectors_P_P_main.AddNode(AssemblyConnectors_P_P_main_instantiate_A_Unconnected_Pattern);
					// CallBehaviorAction instantiate_A_Array_Pattern
					AssemblyConnectors_P_P_main_instantiate_A_Array_Pattern.SetName("instantiate_A_Array_Pattern");
					AssemblyConnectors_P_P_main_instantiate_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
					
						// OutputPin a_Array_Pattern
						AssemblyConnectors_P_P_main_instantiate_A_Array_Pattern_a_Array_Pattern.SetName("a_Array_Pattern");
						AssemblyConnectors_P_P_main_instantiate_A_Array_Pattern_a_Array_Pattern.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_main_instantiate_A_Array_Pattern_a_Array_Pattern.SetType(AssemblyConnectors_P_P_A_Array_Pattern);
					AssemblyConnectors_P_P_main_instantiate_A_Array_Pattern.AddResult(AssemblyConnectors_P_P_main_instantiate_A_Array_Pattern_a_Array_Pattern);
					AssemblyConnectors_P_P_main_instantiate_A_Array_Pattern.SetBehavior(AssemblyConnectors_P_P_instantiate_A_Array_Pattern);
				AssemblyConnectors_P_P_main.AddNode(AssemblyConnectors_P_P_main_instantiate_A_Array_Pattern);
					// CallBehaviorAction assert_A_Star_Pattern
					AssemblyConnectors_P_P_main_assert_A_Star_Pattern.SetName("assert_A_Star_Pattern");
					AssemblyConnectors_P_P_main_assert_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_P_P_main_assert_A_Star_Pattern.SetBehavior(AssemblyConnectors_P_P_assert_A_Star_Pattern);
						// InputPin a_Star_Pattern
						AssemblyConnectors_P_P_main_assert_A_Star_Pattern_a_Star_Pattern.SetName("a_Star_Pattern");
						AssemblyConnectors_P_P_main_assert_A_Star_Pattern_a_Star_Pattern.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_main_assert_A_Star_Pattern_a_Star_Pattern.SetType(AssemblyConnectors_P_P_A_Star_Pattern);
					AssemblyConnectors_P_P_main_assert_A_Star_Pattern.AddArgument(AssemblyConnectors_P_P_main_assert_A_Star_Pattern_a_Star_Pattern);
				AssemblyConnectors_P_P_main.AddNode(AssemblyConnectors_P_P_main_assert_A_Star_Pattern);
					// CallBehaviorAction instantiate_A_Empty_Pattern
					AssemblyConnectors_P_P_main_instantiate_A_Empty_Pattern.SetName("instantiate_A_Empty_Pattern");
					AssemblyConnectors_P_P_main_instantiate_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
					
						// OutputPin a_Empty_Pattern
						AssemblyConnectors_P_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetName("a_Empty_Pattern");
						AssemblyConnectors_P_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetType(AssemblyConnectors_P_P_A_Empty_Pattern);
					AssemblyConnectors_P_P_main_instantiate_A_Empty_Pattern.AddResult(AssemblyConnectors_P_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern);
					AssemblyConnectors_P_P_main_instantiate_A_Empty_Pattern.SetBehavior(AssemblyConnectors_P_P_instantiate_A_Empty_Pattern);
				AssemblyConnectors_P_P_main.AddNode(AssemblyConnectors_P_P_main_instantiate_A_Empty_Pattern);
					// ControlFlow ControlFlow52 from assert_A_Array_Pattern to instantiate_A_Star_Pattern
					AssemblyConnectors_P_P_main_ControlFlow52.SetName("ControlFlow52");
					AssemblyConnectors_P_P_main_ControlFlow52.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_main_ControlFlow52.SetSource(AssemblyConnectors_P_P_main_assert_A_Array_Pattern);
					AssemblyConnectors_P_P_main_ControlFlow52.SetTarget(AssemblyConnectors_P_P_main_instantiate_A_Star_Pattern);
				AssemblyConnectors_P_P_main.AddEdge(AssemblyConnectors_P_P_main_ControlFlow52);
					// ObjectFlow ObjectFlow40 from a_Star_Pattern to a_Star_Pattern
					AssemblyConnectors_P_P_main_ObjectFlow40.SetName("ObjectFlow40");
					AssemblyConnectors_P_P_main_ObjectFlow40.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_main_ObjectFlow40.SetSource(AssemblyConnectors_P_P_main_instantiate_A_Star_Pattern_a_Star_Pattern);
					AssemblyConnectors_P_P_main_ObjectFlow40.SetTarget(AssemblyConnectors_P_P_main_assert_A_Star_Pattern_a_Star_Pattern);
						// LiteralBoolean LiteralBoolean41
						AssemblyConnectors_P_P_main_ObjectFlow40_LiteralBoolean41.SetName("LiteralBoolean41");
						AssemblyConnectors_P_P_main_ObjectFlow40_LiteralBoolean41.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_main_ObjectFlow40_LiteralBoolean41.SetValue(true);
					AssemblyConnectors_P_P_main_ObjectFlow40.SetGuard(AssemblyConnectors_P_P_main_ObjectFlow40_LiteralBoolean41);
				AssemblyConnectors_P_P_main.AddEdge(AssemblyConnectors_P_P_main_ObjectFlow40);
					// ControlFlow ControlFlow56 from assert_A_Empty_Pattern to instantiate_A_Unconnected_Pattern
					AssemblyConnectors_P_P_main_ControlFlow56.SetName("ControlFlow56");
					AssemblyConnectors_P_P_main_ControlFlow56.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_main_ControlFlow56.SetSource(AssemblyConnectors_P_P_main_assert_A_Empty_Pattern);
					AssemblyConnectors_P_P_main_ControlFlow56.SetTarget(AssemblyConnectors_P_P_main_instantiate_A_Unconnected_Pattern);
				AssemblyConnectors_P_P_main.AddEdge(AssemblyConnectors_P_P_main_ControlFlow56);
					// ObjectFlow ObjectFlow43 from a_Unconnected_Pattern to a_Unconnected_Pattern
					AssemblyConnectors_P_P_main_ObjectFlow43.SetName("ObjectFlow43");
					AssemblyConnectors_P_P_main_ObjectFlow43.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_main_ObjectFlow43.SetSource(AssemblyConnectors_P_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern);
					AssemblyConnectors_P_P_main_ObjectFlow43.SetTarget(AssemblyConnectors_P_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern);
						// LiteralBoolean LiteralBoolean44
						AssemblyConnectors_P_P_main_ObjectFlow43_LiteralBoolean44.SetName("LiteralBoolean44");
						AssemblyConnectors_P_P_main_ObjectFlow43_LiteralBoolean44.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_main_ObjectFlow43_LiteralBoolean44.SetValue(true);
					AssemblyConnectors_P_P_main_ObjectFlow43.SetGuard(AssemblyConnectors_P_P_main_ObjectFlow43_LiteralBoolean44);
				AssemblyConnectors_P_P_main.AddEdge(AssemblyConnectors_P_P_main_ObjectFlow43);
					// ObjectFlow ObjectFlow49 from a_Empty_Pattern to a_Empty_Pattern
					AssemblyConnectors_P_P_main_ObjectFlow49.SetName("ObjectFlow49");
					AssemblyConnectors_P_P_main_ObjectFlow49.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_main_ObjectFlow49.SetSource(AssemblyConnectors_P_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern);
					AssemblyConnectors_P_P_main_ObjectFlow49.SetTarget(AssemblyConnectors_P_P_main_assert_A_Empty_Pattern_a_Empty_Pattern);
						// LiteralBoolean LiteralBoolean51
						AssemblyConnectors_P_P_main_ObjectFlow49_LiteralBoolean51.SetName("LiteralBoolean51");
						AssemblyConnectors_P_P_main_ObjectFlow49_LiteralBoolean51.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_main_ObjectFlow49_LiteralBoolean51.SetValue(true);
					AssemblyConnectors_P_P_main_ObjectFlow49.SetGuard(AssemblyConnectors_P_P_main_ObjectFlow49_LiteralBoolean51);
				AssemblyConnectors_P_P_main.AddEdge(AssemblyConnectors_P_P_main_ObjectFlow49);
					// ObjectFlow ObjectFlow60 from a_Array_Pattern to a_Array_Pattern
					AssemblyConnectors_P_P_main_ObjectFlow60.SetName("ObjectFlow60");
					AssemblyConnectors_P_P_main_ObjectFlow60.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_main_ObjectFlow60.SetSource(AssemblyConnectors_P_P_main_instantiate_A_Array_Pattern_a_Array_Pattern);
					AssemblyConnectors_P_P_main_ObjectFlow60.SetTarget(AssemblyConnectors_P_P_main_assert_A_Array_Pattern_a_Array_Pattern);
						// LiteralBoolean LiteralBoolean61
						AssemblyConnectors_P_P_main_ObjectFlow60_LiteralBoolean61.SetName("LiteralBoolean61");
						AssemblyConnectors_P_P_main_ObjectFlow60_LiteralBoolean61.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_main_ObjectFlow60_LiteralBoolean61.SetValue(true);
					AssemblyConnectors_P_P_main_ObjectFlow60.SetGuard(AssemblyConnectors_P_P_main_ObjectFlow60_LiteralBoolean61);
				AssemblyConnectors_P_P_main.AddEdge(AssemblyConnectors_P_P_main_ObjectFlow60);
					// ControlFlow ControlFlow66 from assert_A_Unconnected_Pattern to instantiate_A_Array_Pattern
					AssemblyConnectors_P_P_main_ControlFlow66.SetName("ControlFlow66");
					AssemblyConnectors_P_P_main_ControlFlow66.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_main_ControlFlow66.SetSource(AssemblyConnectors_P_P_main_assert_A_Unconnected_Pattern);
					AssemblyConnectors_P_P_main_ControlFlow66.SetTarget(AssemblyConnectors_P_P_main_instantiate_A_Array_Pattern);
				AssemblyConnectors_P_P_main.AddEdge(AssemblyConnectors_P_P_main_ControlFlow66);
			AssemblyConnectors_P_P.AddPackagedElement(AssemblyConnectors_P_P_main);
				// Activity instantiate_A_Unconnected_Pattern
				AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern.SetName("instantiate_A_Unconnected_Pattern");
				AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Unconnected_Pattern
					AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetName("a_Unconnected_Pattern");
					AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetType(AssemblyConnectors_P_P_A_Unconnected_Pattern);
					AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetDirection(ParameterDirectionKind.return_);
				AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern.AddOwnedParameter(AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern);
					// CreateObjectAction Create A_Unconnected_Pattern
					AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern.SetName("Create A_Unconnected_Pattern");
					AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern.SetClassifier(AssemblyConnectors_P_P_A_Unconnected_Pattern);
						// OutputPin result
						AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result.SetName("result");
						AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result.SetType(AssemblyConnectors_P_P_A_Unconnected_Pattern);
					AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern.SetResult(AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result);
				AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern.AddNode(AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern);
					// ActivityParameterNode a_Unconnected_Pattern_node
					AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node.SetName("a_Unconnected_Pattern_node");
					AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node.SetParameter(AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern);
				AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern.AddNode(AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node);
					// CallOperationAction A_Unconnected_Pattern()
					AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_.SetName("A_Unconnected_Pattern()");
					AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result.SetName("result");
						AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result.SetType(AssemblyConnectors_P_P_A_Unconnected_Pattern);
					AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_.AddResult(AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result);
					AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_.SetOperation(AssemblyConnectors_P_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern);
						// InputPin target
						AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target.SetName("target");
						AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target.SetType(AssemblyConnectors_P_P_A_Unconnected_Pattern);
					AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_.SetTarget(AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target);
				AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern.AddNode(AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_);
					// ObjectFlow ObjectFlow78 from result to a_Unconnected_Pattern_node
					AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow78.SetName("ObjectFlow78");
					AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow78.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow78.SetSource(AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result);
					AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow78.SetTarget(AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node);
						// LiteralBoolean LiteralBoolean79
						AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow78_LiteralBoolean79.SetName("LiteralBoolean79");
						AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow78_LiteralBoolean79.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow78_LiteralBoolean79.SetValue(true);
					AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow78.SetGuard(AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow78_LiteralBoolean79);
				AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern.AddEdge(AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow78);
					// ObjectFlow ObjectFlow81 from result to target
					AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow81.SetName("ObjectFlow81");
					AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow81.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow81.SetSource(AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result);
					AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow81.SetTarget(AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target);
						// LiteralBoolean LiteralBoolean82
						AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow81_LiteralBoolean82.SetName("LiteralBoolean82");
						AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow81_LiteralBoolean82.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow81_LiteralBoolean82.SetValue(true);
					AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow81.SetGuard(AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow81_LiteralBoolean82);
				AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern.AddEdge(AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow81);
			AssemblyConnectors_P_P.AddPackagedElement(AssemblyConnectors_P_P_instantiate_A_Unconnected_Pattern);
				// Activity assert_A_Empty_Pattern
				AssemblyConnectors_P_P_assert_A_Empty_Pattern.SetName("assert_A_Empty_Pattern");
				AssemblyConnectors_P_P_assert_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Empty_Pattern
					AssemblyConnectors_P_P_assert_A_Empty_Pattern_a_Empty_Pattern.SetName("a_Empty_Pattern");
					AssemblyConnectors_P_P_assert_A_Empty_Pattern_a_Empty_Pattern.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_assert_A_Empty_Pattern_a_Empty_Pattern.SetType(AssemblyConnectors_P_P_A_Empty_Pattern);
				AssemblyConnectors_P_P_assert_A_Empty_Pattern.AddOwnedParameter(AssemblyConnectors_P_P_assert_A_Empty_Pattern_a_Empty_Pattern);
					// CallBehaviorAction writeLine
					AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine.SetName("writeLine");
					AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine.SetVisibility(VisibilityKind.public_);
					
						// OutputPin errorStatus
						AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine_errorStatus.SetName("errorStatus");
						AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine_errorStatus.SetVisibility(VisibilityKind.public_);
						
						AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine_errorStatus.SetLower(0);
					AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine.AddResult(AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine_errorStatus);
					AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
						// InputPin value
						AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine_value.SetName("value");
						AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine_value.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine.AddArgument(AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine_value);
				AssemblyConnectors_P_P_assert_A_Empty_Pattern.AddNode(AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine);
					// ValueSpecificationAction message
					AssemblyConnectors_P_P_assert_A_Empty_Pattern_message.SetName("message");
					AssemblyConnectors_P_P_assert_A_Empty_Pattern_message.SetVisibility(VisibilityKind.public_);
						// LiteralString LiteralString100
						AssemblyConnectors_P_P_assert_A_Empty_Pattern_message_LiteralString100.SetName("LiteralString100");
						AssemblyConnectors_P_P_assert_A_Empty_Pattern_message_LiteralString100.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_assert_A_Empty_Pattern_message_LiteralString100.SetValue("Assertion currently not implemented for A_Empty_Pattern.");
					AssemblyConnectors_P_P_assert_A_Empty_Pattern_message.SetValue(AssemblyConnectors_P_P_assert_A_Empty_Pattern_message_LiteralString100);
						// OutputPin result
						AssemblyConnectors_P_P_assert_A_Empty_Pattern_message_result.SetName("result");
						AssemblyConnectors_P_P_assert_A_Empty_Pattern_message_result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_assert_A_Empty_Pattern_message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					AssemblyConnectors_P_P_assert_A_Empty_Pattern_message.SetResult(AssemblyConnectors_P_P_assert_A_Empty_Pattern_message_result);
				AssemblyConnectors_P_P_assert_A_Empty_Pattern.AddNode(AssemblyConnectors_P_P_assert_A_Empty_Pattern_message);
					// ActivityParameterNode a_Empty_Pattern_node
					AssemblyConnectors_P_P_assert_A_Empty_Pattern_a_Empty_Pattern_node.SetName("a_Empty_Pattern_node");
					AssemblyConnectors_P_P_assert_A_Empty_Pattern_a_Empty_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_assert_A_Empty_Pattern_a_Empty_Pattern_node.SetParameter(AssemblyConnectors_P_P_assert_A_Empty_Pattern_a_Empty_Pattern);
				AssemblyConnectors_P_P_assert_A_Empty_Pattern.AddNode(AssemblyConnectors_P_P_assert_A_Empty_Pattern_a_Empty_Pattern_node);
					// ObjectFlow ObjectFlow95 from result to value
					AssemblyConnectors_P_P_assert_A_Empty_Pattern_ObjectFlow95.SetName("ObjectFlow95");
					AssemblyConnectors_P_P_assert_A_Empty_Pattern_ObjectFlow95.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_assert_A_Empty_Pattern_ObjectFlow95.SetSource(AssemblyConnectors_P_P_assert_A_Empty_Pattern_message_result);
					AssemblyConnectors_P_P_assert_A_Empty_Pattern_ObjectFlow95.SetTarget(AssemblyConnectors_P_P_assert_A_Empty_Pattern_writeLine_value);
						// LiteralBoolean LiteralBoolean96
						AssemblyConnectors_P_P_assert_A_Empty_Pattern_ObjectFlow95_LiteralBoolean96.SetName("LiteralBoolean96");
						AssemblyConnectors_P_P_assert_A_Empty_Pattern_ObjectFlow95_LiteralBoolean96.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_assert_A_Empty_Pattern_ObjectFlow95_LiteralBoolean96.SetValue(true);
					AssemblyConnectors_P_P_assert_A_Empty_Pattern_ObjectFlow95.SetGuard(AssemblyConnectors_P_P_assert_A_Empty_Pattern_ObjectFlow95_LiteralBoolean96);
				AssemblyConnectors_P_P_assert_A_Empty_Pattern.AddEdge(AssemblyConnectors_P_P_assert_A_Empty_Pattern_ObjectFlow95);
			AssemblyConnectors_P_P.AddPackagedElement(AssemblyConnectors_P_P_assert_A_Empty_Pattern);
				// Class A_Unconnected_Pattern
				AssemblyConnectors_P_P_A_Unconnected_Pattern.SetName("A_Unconnected_Pattern");
				AssemblyConnectors_P_P_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Property partB
					AssemblyConnectors_P_P_A_Unconnected_Pattern_partB.SetName("partB");
					AssemblyConnectors_P_P_A_Unconnected_Pattern_partB.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_P_P_A_Unconnected_Pattern_partB.SetUpper(-1);
					AssemblyConnectors_P_P_A_Unconnected_Pattern_partB.SetLower(2);
					AssemblyConnectors_P_P_A_Unconnected_Pattern_partB.SetType(AssemblyConnectors_P_P_B);
					AssemblyConnectors_P_P_A_Unconnected_Pattern_partB.SetAggregation(AggregationKind.composite);
				AssemblyConnectors_P_P_A_Unconnected_Pattern.AddOwnedAttribute(AssemblyConnectors_P_P_A_Unconnected_Pattern_partB);
					// Property partC
					AssemblyConnectors_P_P_A_Unconnected_Pattern_partC.SetName("partC");
					AssemblyConnectors_P_P_A_Unconnected_Pattern_partC.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_P_P_A_Unconnected_Pattern_partC.SetUpper(-1);
					AssemblyConnectors_P_P_A_Unconnected_Pattern_partC.SetLower(3);
					AssemblyConnectors_P_P_A_Unconnected_Pattern_partC.SetType(AssemblyConnectors_P_P_C);
					AssemblyConnectors_P_P_A_Unconnected_Pattern_partC.SetAggregation(AggregationKind.composite);
				AssemblyConnectors_P_P_A_Unconnected_Pattern.AddOwnedAttribute(AssemblyConnectors_P_P_A_Unconnected_Pattern_partC);
				
				AssemblyConnectors_P_P_A_Unconnected_Pattern_r.SetName("r");
					AssemblyConnectors_P_P_A_Unconnected_Pattern_r.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd108.SetUpper(-1);
						AssemblyConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd108.SetLower(0);
						AssemblyConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd108.SetRole(AssemblyConnectors_P_P_A_Unconnected_Pattern_partB);
						
					AssemblyConnectors_P_P_A_Unconnected_Pattern_r.AddEnd(AssemblyConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd108);
						AssemblyConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd107.SetUpper(-1);
						AssemblyConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd107.SetLower(0);
						AssemblyConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd107.SetRole(AssemblyConnectors_P_P_A_Unconnected_Pattern_partC);
						
					AssemblyConnectors_P_P_A_Unconnected_Pattern_r.AddEnd(AssemblyConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd107);
					AssemblyConnectors_P_P_A_Unconnected_Pattern_r.SetType(AssemblyConnectors_P_P_R);
				AssemblyConnectors_P_P_A_Unconnected_Pattern.AddOwnedConnector(AssemblyConnectors_P_P_A_Unconnected_Pattern_r);
					// Operation A_Unconnected_Pattern_A_Unconnected_Pattern
					AssemblyConnectors_P_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern.SetName("A_Unconnected_Pattern_A_Unconnected_Pattern");
					AssemblyConnectors_P_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
						// Parameter result
						AssemblyConnectors_P_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result.SetName("result");
						AssemblyConnectors_P_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result.SetVisibility(VisibilityKind.public_);
						
						AssemblyConnectors_P_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result.SetType(AssemblyConnectors_P_P_A_Unconnected_Pattern);
						AssemblyConnectors_P_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result.SetDirection(ParameterDirectionKind.return_);
					AssemblyConnectors_P_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern.AddOwnedParameter(AssemblyConnectors_P_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result);
					AssemblyConnectors_P_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				AssemblyConnectors_P_P_A_Unconnected_Pattern.AddOwnedOperation(AssemblyConnectors_P_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern);
			AssemblyConnectors_P_P.AddPackagedElement(AssemblyConnectors_P_P_A_Unconnected_Pattern);
				// Class A_Array_Pattern
				AssemblyConnectors_P_P_A_Array_Pattern.SetName("A_Array_Pattern");
				AssemblyConnectors_P_P_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Property partB
					AssemblyConnectors_P_P_A_Array_Pattern_partB.SetName("partB");
					AssemblyConnectors_P_P_A_Array_Pattern_partB.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_P_P_A_Array_Pattern_partB.SetUpper(-1);
					AssemblyConnectors_P_P_A_Array_Pattern_partB.SetLower(4);
					AssemblyConnectors_P_P_A_Array_Pattern_partB.SetType(AssemblyConnectors_P_P_B);
					AssemblyConnectors_P_P_A_Array_Pattern_partB.SetAggregation(AggregationKind.composite);
				AssemblyConnectors_P_P_A_Array_Pattern.AddOwnedAttribute(AssemblyConnectors_P_P_A_Array_Pattern_partB);
					// Property partC
					AssemblyConnectors_P_P_A_Array_Pattern_partC.SetName("partC");
					AssemblyConnectors_P_P_A_Array_Pattern_partC.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_P_P_A_Array_Pattern_partC.SetUpper(-1);
					AssemblyConnectors_P_P_A_Array_Pattern_partC.SetLower(4);
					AssemblyConnectors_P_P_A_Array_Pattern_partC.SetType(AssemblyConnectors_P_P_C);
					AssemblyConnectors_P_P_A_Array_Pattern_partC.SetAggregation(AggregationKind.composite);
				AssemblyConnectors_P_P_A_Array_Pattern.AddOwnedAttribute(AssemblyConnectors_P_P_A_Array_Pattern_partC);
				
				AssemblyConnectors_P_P_A_Array_Pattern_r.SetName("r");
					AssemblyConnectors_P_P_A_Array_Pattern_r.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_A_Array_Pattern_r_ConnectorEnd114.SetUpper(-1);
						AssemblyConnectors_P_P_A_Array_Pattern_r_ConnectorEnd114.SetRole(AssemblyConnectors_P_P_A_Array_Pattern_partB);
						
					AssemblyConnectors_P_P_A_Array_Pattern_r.AddEnd(AssemblyConnectors_P_P_A_Array_Pattern_r_ConnectorEnd114);
						AssemblyConnectors_P_P_A_Array_Pattern_r_ConnectorEnd115.SetUpper(-1);
						AssemblyConnectors_P_P_A_Array_Pattern_r_ConnectorEnd115.SetRole(AssemblyConnectors_P_P_A_Array_Pattern_partC);
						
					AssemblyConnectors_P_P_A_Array_Pattern_r.AddEnd(AssemblyConnectors_P_P_A_Array_Pattern_r_ConnectorEnd115);
					AssemblyConnectors_P_P_A_Array_Pattern_r.SetType(AssemblyConnectors_P_P_R);
				AssemblyConnectors_P_P_A_Array_Pattern.AddOwnedConnector(AssemblyConnectors_P_P_A_Array_Pattern_r);
					// Operation A_Array_Pattern_A_Array_Pattern
					AssemblyConnectors_P_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern.SetName("A_Array_Pattern_A_Array_Pattern");
					AssemblyConnectors_P_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
						// Parameter result
						AssemblyConnectors_P_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result.SetName("result");
						AssemblyConnectors_P_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result.SetVisibility(VisibilityKind.public_);
						
						AssemblyConnectors_P_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result.SetType(AssemblyConnectors_P_P_A_Array_Pattern);
						AssemblyConnectors_P_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result.SetDirection(ParameterDirectionKind.return_);
					AssemblyConnectors_P_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern.AddOwnedParameter(AssemblyConnectors_P_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result);
					AssemblyConnectors_P_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				AssemblyConnectors_P_P_A_Array_Pattern.AddOwnedOperation(AssemblyConnectors_P_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern);
			AssemblyConnectors_P_P.AddPackagedElement(AssemblyConnectors_P_P_A_Array_Pattern);
				// Activity assert_A_Array_Pattern
				AssemblyConnectors_P_P_assert_A_Array_Pattern.SetName("assert_A_Array_Pattern");
				AssemblyConnectors_P_P_assert_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Array_Pattern
					AssemblyConnectors_P_P_assert_A_Array_Pattern_a_Array_Pattern.SetName("a_Array_Pattern");
					AssemblyConnectors_P_P_assert_A_Array_Pattern_a_Array_Pattern.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_assert_A_Array_Pattern_a_Array_Pattern.SetType(AssemblyConnectors_P_P_A_Array_Pattern);
				AssemblyConnectors_P_P_assert_A_Array_Pattern.AddOwnedParameter(AssemblyConnectors_P_P_assert_A_Array_Pattern_a_Array_Pattern);
					// CallBehaviorAction writeLine
					AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine.SetName("writeLine");
					AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine.SetVisibility(VisibilityKind.public_);
					
						// OutputPin errorStatus
						AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine_errorStatus.SetName("errorStatus");
						AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine_errorStatus.SetVisibility(VisibilityKind.public_);
						
						AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine_errorStatus.SetLower(0);
					AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine.AddResult(AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine_errorStatus);
					AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
						// InputPin value
						AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine_value.SetName("value");
						AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine_value.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine.AddArgument(AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine_value);
				AssemblyConnectors_P_P_assert_A_Array_Pattern.AddNode(AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine);
					// ValueSpecificationAction message
					AssemblyConnectors_P_P_assert_A_Array_Pattern_message.SetName("message");
					AssemblyConnectors_P_P_assert_A_Array_Pattern_message.SetVisibility(VisibilityKind.public_);
						// LiteralString LiteralString125
						AssemblyConnectors_P_P_assert_A_Array_Pattern_message_LiteralString125.SetName("LiteralString125");
						AssemblyConnectors_P_P_assert_A_Array_Pattern_message_LiteralString125.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_assert_A_Array_Pattern_message_LiteralString125.SetValue("Assertion currently not implemented for A_Array_Pattern.");
					AssemblyConnectors_P_P_assert_A_Array_Pattern_message.SetValue(AssemblyConnectors_P_P_assert_A_Array_Pattern_message_LiteralString125);
						// OutputPin result
						AssemblyConnectors_P_P_assert_A_Array_Pattern_message_result.SetName("result");
						AssemblyConnectors_P_P_assert_A_Array_Pattern_message_result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_assert_A_Array_Pattern_message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					AssemblyConnectors_P_P_assert_A_Array_Pattern_message.SetResult(AssemblyConnectors_P_P_assert_A_Array_Pattern_message_result);
				AssemblyConnectors_P_P_assert_A_Array_Pattern.AddNode(AssemblyConnectors_P_P_assert_A_Array_Pattern_message);
					// ActivityParameterNode a_Array_Pattern_node
					AssemblyConnectors_P_P_assert_A_Array_Pattern_a_Array_Pattern_node.SetName("a_Array_Pattern_node");
					AssemblyConnectors_P_P_assert_A_Array_Pattern_a_Array_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_assert_A_Array_Pattern_a_Array_Pattern_node.SetParameter(AssemblyConnectors_P_P_assert_A_Array_Pattern_a_Array_Pattern);
				AssemblyConnectors_P_P_assert_A_Array_Pattern.AddNode(AssemblyConnectors_P_P_assert_A_Array_Pattern_a_Array_Pattern_node);
					// ObjectFlow ObjectFlow122 from result to value
					AssemblyConnectors_P_P_assert_A_Array_Pattern_ObjectFlow122.SetName("ObjectFlow122");
					AssemblyConnectors_P_P_assert_A_Array_Pattern_ObjectFlow122.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_assert_A_Array_Pattern_ObjectFlow122.SetSource(AssemblyConnectors_P_P_assert_A_Array_Pattern_message_result);
					AssemblyConnectors_P_P_assert_A_Array_Pattern_ObjectFlow122.SetTarget(AssemblyConnectors_P_P_assert_A_Array_Pattern_writeLine_value);
						// LiteralBoolean LiteralBoolean123
						AssemblyConnectors_P_P_assert_A_Array_Pattern_ObjectFlow122_LiteralBoolean123.SetName("LiteralBoolean123");
						AssemblyConnectors_P_P_assert_A_Array_Pattern_ObjectFlow122_LiteralBoolean123.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_assert_A_Array_Pattern_ObjectFlow122_LiteralBoolean123.SetValue(true);
					AssemblyConnectors_P_P_assert_A_Array_Pattern_ObjectFlow122.SetGuard(AssemblyConnectors_P_P_assert_A_Array_Pattern_ObjectFlow122_LiteralBoolean123);
				AssemblyConnectors_P_P_assert_A_Array_Pattern.AddEdge(AssemblyConnectors_P_P_assert_A_Array_Pattern_ObjectFlow122);
			AssemblyConnectors_P_P.AddPackagedElement(AssemblyConnectors_P_P_assert_A_Array_Pattern);
				// Activity instantiate_A_Star_Pattern
				AssemblyConnectors_P_P_instantiate_A_Star_Pattern.SetName("instantiate_A_Star_Pattern");
				AssemblyConnectors_P_P_instantiate_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Star_Pattern
					AssemblyConnectors_P_P_instantiate_A_Star_Pattern_a_Star_Pattern.SetName("a_Star_Pattern");
					AssemblyConnectors_P_P_instantiate_A_Star_Pattern_a_Star_Pattern.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_instantiate_A_Star_Pattern_a_Star_Pattern.SetType(AssemblyConnectors_P_P_A_Star_Pattern);
					AssemblyConnectors_P_P_instantiate_A_Star_Pattern_a_Star_Pattern.SetDirection(ParameterDirectionKind.return_);
				AssemblyConnectors_P_P_instantiate_A_Star_Pattern.AddOwnedParameter(AssemblyConnectors_P_P_instantiate_A_Star_Pattern_a_Star_Pattern);
					// CreateObjectAction Create A_Star_Pattern
					AssemblyConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern.SetName("Create A_Star_Pattern");
					AssemblyConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern.SetClassifier(AssemblyConnectors_P_P_A_Star_Pattern);
						// OutputPin result
						AssemblyConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result.SetName("result");
						AssemblyConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result.SetType(AssemblyConnectors_P_P_A_Star_Pattern);
					AssemblyConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern.SetResult(AssemblyConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result);
				AssemblyConnectors_P_P_instantiate_A_Star_Pattern.AddNode(AssemblyConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern);
					// CallOperationAction A_Star_Pattern()
					AssemblyConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern_.SetName("A_Star_Pattern()");
					AssemblyConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						AssemblyConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__result.SetName("result");
						AssemblyConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__result.SetType(AssemblyConnectors_P_P_A_Star_Pattern);
					AssemblyConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern_.AddResult(AssemblyConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__result);
					AssemblyConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern_.SetOperation(AssemblyConnectors_P_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern);
						// InputPin target
						AssemblyConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__target.SetName("target");
						AssemblyConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__target.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__target.SetType(AssemblyConnectors_P_P_A_Star_Pattern);
					AssemblyConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern_.SetTarget(AssemblyConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__target);
				AssemblyConnectors_P_P_instantiate_A_Star_Pattern.AddNode(AssemblyConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern_);
					// ActivityParameterNode a_Star_Pattern_node
					AssemblyConnectors_P_P_instantiate_A_Star_Pattern_a_Star_Pattern_node.SetName("a_Star_Pattern_node");
					AssemblyConnectors_P_P_instantiate_A_Star_Pattern_a_Star_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_instantiate_A_Star_Pattern_a_Star_Pattern_node.SetParameter(AssemblyConnectors_P_P_instantiate_A_Star_Pattern_a_Star_Pattern);
				AssemblyConnectors_P_P_instantiate_A_Star_Pattern.AddNode(AssemblyConnectors_P_P_instantiate_A_Star_Pattern_a_Star_Pattern_node);
					// ObjectFlow ObjectFlow131 from result to target
					AssemblyConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow131.SetName("ObjectFlow131");
					AssemblyConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow131.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow131.SetSource(AssemblyConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result);
					AssemblyConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow131.SetTarget(AssemblyConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__target);
						// LiteralBoolean LiteralBoolean132
						AssemblyConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow131_LiteralBoolean132.SetName("LiteralBoolean132");
						AssemblyConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow131_LiteralBoolean132.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow131_LiteralBoolean132.SetValue(true);
					AssemblyConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow131.SetGuard(AssemblyConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow131_LiteralBoolean132);
				AssemblyConnectors_P_P_instantiate_A_Star_Pattern.AddEdge(AssemblyConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow131);
					// ObjectFlow ObjectFlow134 from result to a_Star_Pattern_node
					AssemblyConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow134.SetName("ObjectFlow134");
					AssemblyConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow134.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow134.SetSource(AssemblyConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__result);
					AssemblyConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow134.SetTarget(AssemblyConnectors_P_P_instantiate_A_Star_Pattern_a_Star_Pattern_node);
						// LiteralBoolean LiteralBoolean136
						AssemblyConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow134_LiteralBoolean136.SetName("LiteralBoolean136");
						AssemblyConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow134_LiteralBoolean136.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow134_LiteralBoolean136.SetValue(true);
					AssemblyConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow134.SetGuard(AssemblyConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow134_LiteralBoolean136);
				AssemblyConnectors_P_P_instantiate_A_Star_Pattern.AddEdge(AssemblyConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow134);
			AssemblyConnectors_P_P.AddPackagedElement(AssemblyConnectors_P_P_instantiate_A_Star_Pattern);
				// Activity instantiate_A_Array_Pattern
				AssemblyConnectors_P_P_instantiate_A_Array_Pattern.SetName("instantiate_A_Array_Pattern");
				AssemblyConnectors_P_P_instantiate_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Array_Pattern
					AssemblyConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern.SetName("a_Array_Pattern");
					AssemblyConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern.SetType(AssemblyConnectors_P_P_A_Array_Pattern);
					AssemblyConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern.SetDirection(ParameterDirectionKind.return_);
				AssemblyConnectors_P_P_instantiate_A_Array_Pattern.AddOwnedParameter(AssemblyConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern);
					// ActivityParameterNode a_Array_Pattern_node
					AssemblyConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern_node.SetName("a_Array_Pattern_node");
					AssemblyConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern_node.SetParameter(AssemblyConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern);
				AssemblyConnectors_P_P_instantiate_A_Array_Pattern.AddNode(AssemblyConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern_node);
					// CallOperationAction A_Array_Pattern()
					AssemblyConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern_.SetName("A_Array_Pattern()");
					AssemblyConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						AssemblyConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__result.SetName("result");
						AssemblyConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__result.SetType(AssemblyConnectors_P_P_A_Array_Pattern);
					AssemblyConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern_.AddResult(AssemblyConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__result);
					AssemblyConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern_.SetOperation(AssemblyConnectors_P_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern);
						// InputPin target
						AssemblyConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__target.SetName("target");
						AssemblyConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__target.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__target.SetType(AssemblyConnectors_P_P_A_Array_Pattern);
					AssemblyConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern_.SetTarget(AssemblyConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__target);
				AssemblyConnectors_P_P_instantiate_A_Array_Pattern.AddNode(AssemblyConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern_);
					// CreateObjectAction Create A_Array_Pattern
					AssemblyConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern.SetName("Create A_Array_Pattern");
					AssemblyConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern.SetClassifier(AssemblyConnectors_P_P_A_Array_Pattern);
						// OutputPin result
						AssemblyConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result.SetName("result");
						AssemblyConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result.SetType(AssemblyConnectors_P_P_A_Array_Pattern);
					AssemblyConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern.SetResult(AssemblyConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result);
				AssemblyConnectors_P_P_instantiate_A_Array_Pattern.AddNode(AssemblyConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern);
					// ObjectFlow ObjectFlow148 from result to target
					AssemblyConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow148.SetName("ObjectFlow148");
					AssemblyConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow148.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow148.SetSource(AssemblyConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result);
					AssemblyConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow148.SetTarget(AssemblyConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__target);
						// LiteralBoolean LiteralBoolean150
						AssemblyConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow148_LiteralBoolean150.SetName("LiteralBoolean150");
						AssemblyConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow148_LiteralBoolean150.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow148_LiteralBoolean150.SetValue(true);
					AssemblyConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow148.SetGuard(AssemblyConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow148_LiteralBoolean150);
				AssemblyConnectors_P_P_instantiate_A_Array_Pattern.AddEdge(AssemblyConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow148);
					// ObjectFlow ObjectFlow153 from result to a_Array_Pattern_node
					AssemblyConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow153.SetName("ObjectFlow153");
					AssemblyConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow153.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow153.SetSource(AssemblyConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__result);
					AssemblyConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow153.SetTarget(AssemblyConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern_node);
						// LiteralBoolean LiteralBoolean154
						AssemblyConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow153_LiteralBoolean154.SetName("LiteralBoolean154");
						AssemblyConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow153_LiteralBoolean154.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow153_LiteralBoolean154.SetValue(true);
					AssemblyConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow153.SetGuard(AssemblyConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow153_LiteralBoolean154);
				AssemblyConnectors_P_P_instantiate_A_Array_Pattern.AddEdge(AssemblyConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow153);
			AssemblyConnectors_P_P.AddPackagedElement(AssemblyConnectors_P_P_instantiate_A_Array_Pattern);
				// Activity assert_A_Unconnected_Pattern
				AssemblyConnectors_P_P_assert_A_Unconnected_Pattern.SetName("assert_A_Unconnected_Pattern");
				AssemblyConnectors_P_P_assert_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Unconnected_Pattern
					AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern.SetName("a_Unconnected_Pattern");
					AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern.SetType(AssemblyConnectors_P_P_A_Unconnected_Pattern);
				AssemblyConnectors_P_P_assert_A_Unconnected_Pattern.AddOwnedParameter(AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern);
					// CallBehaviorAction writeLine
					AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine.SetName("writeLine");
					AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine.SetVisibility(VisibilityKind.public_);
					
						// OutputPin errorStatus
						AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_errorStatus.SetName("errorStatus");
						AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_errorStatus.SetVisibility(VisibilityKind.public_);
						
						AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_errorStatus.SetLower(0);
					AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine.AddResult(AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_errorStatus);
					AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
						// InputPin value
						AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_value.SetName("value");
						AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_value.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine.AddArgument(AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_value);
				AssemblyConnectors_P_P_assert_A_Unconnected_Pattern.AddNode(AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine);
					// ValueSpecificationAction message
					AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_message.SetName("message");
					AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_message.SetVisibility(VisibilityKind.public_);
						// LiteralString LiteralString165
						AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_message_LiteralString165.SetName("LiteralString165");
						AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_message_LiteralString165.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_message_LiteralString165.SetValue("Assertion currently not implemented for A_Unconnected_Pattern.");
					AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_message.SetValue(AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_message_LiteralString165);
						// OutputPin result
						AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_message_result.SetName("result");
						AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_message_result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_message.SetResult(AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_message_result);
				AssemblyConnectors_P_P_assert_A_Unconnected_Pattern.AddNode(AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_message);
					// ActivityParameterNode a_Unconnected_Pattern_node
					AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node.SetName("a_Unconnected_Pattern_node");
					AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node.SetParameter(AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern);
				AssemblyConnectors_P_P_assert_A_Unconnected_Pattern.AddNode(AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node);
					// ObjectFlow ObjectFlow156 from result to value
					AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_ObjectFlow156.SetName("ObjectFlow156");
					AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_ObjectFlow156.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_ObjectFlow156.SetSource(AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_message_result);
					AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_ObjectFlow156.SetTarget(AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_value);
						// LiteralBoolean LiteralBoolean158
						AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_ObjectFlow156_LiteralBoolean158.SetName("LiteralBoolean158");
						AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_ObjectFlow156_LiteralBoolean158.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_ObjectFlow156_LiteralBoolean158.SetValue(true);
					AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_ObjectFlow156.SetGuard(AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_ObjectFlow156_LiteralBoolean158);
				AssemblyConnectors_P_P_assert_A_Unconnected_Pattern.AddEdge(AssemblyConnectors_P_P_assert_A_Unconnected_Pattern_ObjectFlow156);
			AssemblyConnectors_P_P.AddPackagedElement(AssemblyConnectors_P_P_assert_A_Unconnected_Pattern);
				// Class A_Empty_Pattern
				AssemblyConnectors_P_P_A_Empty_Pattern.SetName("A_Empty_Pattern");
				AssemblyConnectors_P_P_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Property partB
					AssemblyConnectors_P_P_A_Empty_Pattern_partB.SetName("partB");
					AssemblyConnectors_P_P_A_Empty_Pattern_partB.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_P_P_A_Empty_Pattern_partB.SetUpper(-1);
					AssemblyConnectors_P_P_A_Empty_Pattern_partB.SetLower(0);
					AssemblyConnectors_P_P_A_Empty_Pattern_partB.SetType(AssemblyConnectors_P_P_B);
					AssemblyConnectors_P_P_A_Empty_Pattern_partB.SetAggregation(AggregationKind.composite);
				AssemblyConnectors_P_P_A_Empty_Pattern.AddOwnedAttribute(AssemblyConnectors_P_P_A_Empty_Pattern_partB);
					// Property partC
					AssemblyConnectors_P_P_A_Empty_Pattern_partC.SetName("partC");
					AssemblyConnectors_P_P_A_Empty_Pattern_partC.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_P_P_A_Empty_Pattern_partC.SetUpper(-1);
					AssemblyConnectors_P_P_A_Empty_Pattern_partC.SetLower(0);
					AssemblyConnectors_P_P_A_Empty_Pattern_partC.SetType(AssemblyConnectors_P_P_C);
					AssemblyConnectors_P_P_A_Empty_Pattern_partC.SetAggregation(AggregationKind.composite);
				AssemblyConnectors_P_P_A_Empty_Pattern.AddOwnedAttribute(AssemblyConnectors_P_P_A_Empty_Pattern_partC);
				
				AssemblyConnectors_P_P_A_Empty_Pattern_r.SetName("r");
					AssemblyConnectors_P_P_A_Empty_Pattern_r.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_P_P_A_Empty_Pattern_r_ConnectorEnd174.SetUpper(-1);
						AssemblyConnectors_P_P_A_Empty_Pattern_r_ConnectorEnd174.SetRole(AssemblyConnectors_P_P_A_Empty_Pattern_partB);
						
					AssemblyConnectors_P_P_A_Empty_Pattern_r.AddEnd(AssemblyConnectors_P_P_A_Empty_Pattern_r_ConnectorEnd174);
						AssemblyConnectors_P_P_A_Empty_Pattern_r_ConnectorEnd173.SetUpper(-1);
						AssemblyConnectors_P_P_A_Empty_Pattern_r_ConnectorEnd173.SetRole(AssemblyConnectors_P_P_A_Empty_Pattern_partC);
						
					AssemblyConnectors_P_P_A_Empty_Pattern_r.AddEnd(AssemblyConnectors_P_P_A_Empty_Pattern_r_ConnectorEnd173);
					AssemblyConnectors_P_P_A_Empty_Pattern_r.SetType(AssemblyConnectors_P_P_R);
				AssemblyConnectors_P_P_A_Empty_Pattern.AddOwnedConnector(AssemblyConnectors_P_P_A_Empty_Pattern_r);
					// Operation A_Empty_Pattern_A_Empty_Pattern
					AssemblyConnectors_P_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern.SetName("A_Empty_Pattern_A_Empty_Pattern");
					AssemblyConnectors_P_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
						// Parameter result
						AssemblyConnectors_P_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result.SetName("result");
						AssemblyConnectors_P_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result.SetVisibility(VisibilityKind.public_);
						
						AssemblyConnectors_P_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result.SetType(AssemblyConnectors_P_P_A_Empty_Pattern);
						AssemblyConnectors_P_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result.SetDirection(ParameterDirectionKind.return_);
					AssemblyConnectors_P_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern.AddOwnedParameter(AssemblyConnectors_P_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result);
					AssemblyConnectors_P_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				AssemblyConnectors_P_P_A_Empty_Pattern.AddOwnedOperation(AssemblyConnectors_P_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern);
			AssemblyConnectors_P_P.AddPackagedElement(AssemblyConnectors_P_P_A_Empty_Pattern);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // AssemblyConnectors_P_PModel
}
