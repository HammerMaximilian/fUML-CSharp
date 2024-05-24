/*
 * AssemblyConnectors_PWP_PModel.cs
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

namespace AssemblyConnectors_PWP_P
{
	public class AssemblyConnectors_PWP_PModel : InMemoryModel
	{
		private static AssemblyConnectors_PWP_PModel? instance;

		/*
		 * Model AssemblyConnectors_PWP_P
		 */
		public Package AssemblyConnectors_PWP_P = new();
			public Activity AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern = new();
				public CallOperationAction AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_A_Empty_Pattern_ = new();
					public InputPin AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target = new();
						public LiteralInteger AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target_LiteralInteger0 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target_LiteralUnlimitedNatural1 = new();
					public OutputPin AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result = new();
						public LiteralInteger AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result_LiteralInteger2 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result_LiteralInteger3 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result_LiteralUnlimitedNatural4 = new();
				public ObjectFlow AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_ObjectFlow5 = new();
					public LiteralBoolean AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_ObjectFlow5_LiteralBoolean6 = new();
					public LiteralInteger AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_ObjectFlow5_LiteralInteger7 = new();
				public ObjectFlow AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_ObjectFlow8 = new();
					public LiteralInteger AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_ObjectFlow8_LiteralInteger9 = new();
					public LiteralBoolean AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_ObjectFlow8_LiteralBoolean10 = new();
				public Parameter AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_a_Empty_Pattern = new();
				public ActivityParameterNode AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_a_Empty_Pattern_node = new();
				public CreateObjectAction AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern = new();
					public OutputPin AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result_LiteralUnlimitedNatural11 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result_LiteralInteger12 = new();
			public Activity AssemblyConnectors_PWP_P_assert_A_Star_Pattern = new();
				public ActivityParameterNode AssemblyConnectors_PWP_P_assert_A_Star_Pattern_a_Star_Pattern_node = new();
					public LiteralInteger AssemblyConnectors_PWP_P_assert_A_Star_Pattern_a_Star_Pattern_node_LiteralInteger13 = new();
				public Parameter AssemblyConnectors_PWP_P_assert_A_Star_Pattern_a_Star_Pattern = new();
				public ObjectFlow AssemblyConnectors_PWP_P_assert_A_Star_Pattern_ObjectFlow14 = new();
					public LiteralBoolean AssemblyConnectors_PWP_P_assert_A_Star_Pattern_ObjectFlow14_LiteralBoolean15 = new();
					public LiteralInteger AssemblyConnectors_PWP_P_assert_A_Star_Pattern_ObjectFlow14_LiteralInteger16 = new();
				public ValueSpecificationAction AssemblyConnectors_PWP_P_assert_A_Star_Pattern_message = new();
					public LiteralString AssemblyConnectors_PWP_P_assert_A_Star_Pattern_message_LiteralString17 = new();
					public OutputPin AssemblyConnectors_PWP_P_assert_A_Star_Pattern_message_result = new();
						public LiteralInteger AssemblyConnectors_PWP_P_assert_A_Star_Pattern_message_result_LiteralInteger18 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_assert_A_Star_Pattern_message_result_LiteralUnlimitedNatural19 = new();
				public CallBehaviorAction AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine = new();
					public OutputPin AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine_errorStatus = new();
						public LiteralInteger AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine_errorStatus_LiteralInteger20 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine_errorStatus_LiteralInteger21 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural22 = new();
					public InputPin AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine_value = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine_value_LiteralUnlimitedNatural23 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine_value_LiteralInteger24 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine_value_LiteralInteger25 = new();
			public Class_ AssemblyConnectors_PWP_P_C = new();
			public Activity AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern = new();
				public ActivityParameterNode AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_a_Star_Pattern_node = new();
				public CreateObjectAction AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern = new();
					public OutputPin AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result = new();
						public LiteralInteger AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result_LiteralInteger26 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result_LiteralUnlimitedNatural27 = new();
				public CallOperationAction AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_A_Star_Pattern_ = new();
					public InputPin AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_A_Star_Pattern__target = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_A_Star_Pattern__target_LiteralUnlimitedNatural28 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_A_Star_Pattern__target_LiteralInteger29 = new();
					public OutputPin AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_A_Star_Pattern__result = new();
						public LiteralInteger AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_A_Star_Pattern__result_LiteralInteger30 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_A_Star_Pattern__result_LiteralInteger31 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_A_Star_Pattern__result_LiteralUnlimitedNatural32 = new();
				public Parameter AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_a_Star_Pattern = new();
				public ObjectFlow AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_ObjectFlow33 = new();
					public LiteralInteger AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_ObjectFlow33_LiteralInteger34 = new();
					public LiteralBoolean AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_ObjectFlow33_LiteralBoolean35 = new();
				public ObjectFlow AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_ObjectFlow36 = new();
					public LiteralBoolean AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_ObjectFlow36_LiteralBoolean37 = new();
					public LiteralInteger AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_ObjectFlow36_LiteralInteger38 = new();
			public Class_ AssemblyConnectors_PWP_P_B = new();
				public Port AssemblyConnectors_PWP_P_B_p = new();
					public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_B_p_LiteralUnlimitedNatural39 = new();
					public LiteralInteger AssemblyConnectors_PWP_P_B_p_LiteralInteger40 = new();
			public Class_ AssemblyConnectors_PWP_P_A_Star_Pattern = new();
				public Comment AssemblyConnectors_PWP_P_A_Star_Pattern_Comment41 = new();
				public Property AssemblyConnectors_PWP_P_A_Star_Pattern_partC = new();
					public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_A_Star_Pattern_partC_LiteralUnlimitedNatural42 = new();
					public LiteralInteger AssemblyConnectors_PWP_P_A_Star_Pattern_partC_LiteralInteger43 = new();
				public Operation AssemblyConnectors_PWP_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern = new();
					public Parameter AssemblyConnectors_PWP_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result = new();
				public Connector AssemblyConnectors_PWP_P_A_Star_Pattern_r = new();
					public ConnectorEnd AssemblyConnectors_PWP_P_A_Star_Pattern_r_ConnectorEnd44 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_A_Star_Pattern_r_ConnectorEnd44_connectorEnd_2_Lower = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_A_Star_Pattern_r_ConnectorEnd44_connectorEnd_2_Upper = new();
					public ConnectorEnd AssemblyConnectors_PWP_P_A_Star_Pattern_r_ConnectorEnd45 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_A_Star_Pattern_r_ConnectorEnd45_connectorEnd_1_Upper = new();
						public LiteralInteger AssemblyConnectors_PWP_P_A_Star_Pattern_r_ConnectorEnd45_connectorEnd_1_Lower = new();
				public Property AssemblyConnectors_PWP_P_A_Star_Pattern_partB = new();
					public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_A_Star_Pattern_partB_LiteralUnlimitedNatural46 = new();
					public LiteralInteger AssemblyConnectors_PWP_P_A_Star_Pattern_partB_LiteralInteger47 = new();
			public Activity AssemblyConnectors_PWP_P_assert_A_Array_Pattern = new();
				public Parameter AssemblyConnectors_PWP_P_assert_A_Array_Pattern_a_Array_Pattern = new();
				public ValueSpecificationAction AssemblyConnectors_PWP_P_assert_A_Array_Pattern_message = new();
					public OutputPin AssemblyConnectors_PWP_P_assert_A_Array_Pattern_message_result = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_assert_A_Array_Pattern_message_result_LiteralUnlimitedNatural48 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_assert_A_Array_Pattern_message_result_LiteralInteger49 = new();
					public LiteralString AssemblyConnectors_PWP_P_assert_A_Array_Pattern_message_LiteralString50 = new();
				public CallBehaviorAction AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine = new();
					public OutputPin AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine_errorStatus = new();
						public LiteralInteger AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine_errorStatus_LiteralInteger51 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural52 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine_errorStatus_LiteralInteger53 = new();
					public InputPin AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine_value = new();
						public LiteralInteger AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine_value_LiteralInteger54 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine_value_LiteralInteger55 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine_value_LiteralUnlimitedNatural56 = new();
				public ActivityParameterNode AssemblyConnectors_PWP_P_assert_A_Array_Pattern_a_Array_Pattern_node = new();
					public LiteralInteger AssemblyConnectors_PWP_P_assert_A_Array_Pattern_a_Array_Pattern_node_LiteralInteger57 = new();
				public ObjectFlow AssemblyConnectors_PWP_P_assert_A_Array_Pattern_ObjectFlow58 = new();
					public LiteralInteger AssemblyConnectors_PWP_P_assert_A_Array_Pattern_ObjectFlow58_LiteralInteger59 = new();
					public LiteralBoolean AssemblyConnectors_PWP_P_assert_A_Array_Pattern_ObjectFlow58_LiteralBoolean60 = new();
			public Activity AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern = new();
				public ActivityParameterNode AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_a_Array_Pattern_node = new();
					public LiteralInteger AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_a_Array_Pattern_node_LiteralInteger61 = new();
				public CallOperationAction AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_A_Array_Pattern_ = new();
					public InputPin AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_A_Array_Pattern__target = new();
						public LiteralInteger AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_A_Array_Pattern__target_LiteralInteger62 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_A_Array_Pattern__target_LiteralUnlimitedNatural63 = new();
					public OutputPin AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_A_Array_Pattern__result = new();
						public LiteralInteger AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_A_Array_Pattern__result_LiteralInteger64 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_A_Array_Pattern__result_LiteralUnlimitedNatural65 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_A_Array_Pattern__result_LiteralInteger66 = new();
				public CreateObjectAction AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern = new();
					public OutputPin AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result_LiteralUnlimitedNatural67 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result_LiteralInteger68 = new();
				public ObjectFlow AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_ObjectFlow69 = new();
					public LiteralInteger AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_ObjectFlow69_LiteralInteger70 = new();
					public LiteralBoolean AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_ObjectFlow69_LiteralBoolean71 = new();
				public Parameter AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_a_Array_Pattern = new();
				public ObjectFlow AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_ObjectFlow72 = new();
					public LiteralBoolean AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_ObjectFlow72_LiteralBoolean73 = new();
					public LiteralInteger AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_ObjectFlow72_LiteralInteger74 = new();
			public Interface AssemblyConnectors_PWP_P_I = new();
			public Class_ AssemblyConnectors_PWP_P_A_Unconnected_Pattern = new();
				public Comment AssemblyConnectors_PWP_P_A_Unconnected_Pattern_Comment75 = new();
				public Property AssemblyConnectors_PWP_P_A_Unconnected_Pattern_partC = new();
					public LiteralInteger AssemblyConnectors_PWP_P_A_Unconnected_Pattern_partC_LiteralInteger76 = new();
					public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_A_Unconnected_Pattern_partC_LiteralUnlimitedNatural77 = new();
				public Property AssemblyConnectors_PWP_P_A_Unconnected_Pattern_partB = new();
					public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_A_Unconnected_Pattern_partB_LiteralUnlimitedNatural78 = new();
					public LiteralInteger AssemblyConnectors_PWP_P_A_Unconnected_Pattern_partB_LiteralInteger79 = new();
				public Connector AssemblyConnectors_PWP_P_A_Unconnected_Pattern_r = new();
					public ConnectorEnd AssemblyConnectors_PWP_P_A_Unconnected_Pattern_r_ConnectorEnd80 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_A_Unconnected_Pattern_r_ConnectorEnd80_connectorEnd_2_Lower = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_A_Unconnected_Pattern_r_ConnectorEnd80_connectorEnd_2_Upper = new();
					public ConnectorEnd AssemblyConnectors_PWP_P_A_Unconnected_Pattern_r_ConnectorEnd81 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_A_Unconnected_Pattern_r_ConnectorEnd81_connectorEnd_1_Lower = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_A_Unconnected_Pattern_r_ConnectorEnd81_connectorEnd_1_Upper = new();
				public Operation AssemblyConnectors_PWP_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern = new();
					public Parameter AssemblyConnectors_PWP_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result = new();
			public Class_ AssemblyConnectors_PWP_P_A_Array_Pattern = new();
				public Property AssemblyConnectors_PWP_P_A_Array_Pattern_partB = new();
					public LiteralInteger AssemblyConnectors_PWP_P_A_Array_Pattern_partB_LiteralInteger82 = new();
					public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_A_Array_Pattern_partB_LiteralUnlimitedNatural83 = new();
				public Property AssemblyConnectors_PWP_P_A_Array_Pattern_partC = new();
					public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_A_Array_Pattern_partC_LiteralUnlimitedNatural84 = new();
					public LiteralInteger AssemblyConnectors_PWP_P_A_Array_Pattern_partC_LiteralInteger85 = new();
				public Comment AssemblyConnectors_PWP_P_A_Array_Pattern_Comment86 = new();
				public Connector AssemblyConnectors_PWP_P_A_Array_Pattern_r = new();
					public ConnectorEnd AssemblyConnectors_PWP_P_A_Array_Pattern_r_ConnectorEnd87 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_A_Array_Pattern_r_ConnectorEnd87_connectorEnd_1_Lower = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_A_Array_Pattern_r_ConnectorEnd87_connectorEnd_1_Upper = new();
					public ConnectorEnd AssemblyConnectors_PWP_P_A_Array_Pattern_r_ConnectorEnd88 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_A_Array_Pattern_r_ConnectorEnd88_connectorEnd_2_Lower = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_A_Array_Pattern_r_ConnectorEnd88_connectorEnd_2_Upper = new();
				public Operation AssemblyConnectors_PWP_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern = new();
					public Parameter AssemblyConnectors_PWP_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result = new();
			public Activity AssemblyConnectors_PWP_P_main = new();
				public ObjectFlow AssemblyConnectors_PWP_P_main_ObjectFlow89 = new();
					public LiteralBoolean AssemblyConnectors_PWP_P_main_ObjectFlow89_LiteralBoolean90 = new();
					public LiteralInteger AssemblyConnectors_PWP_P_main_ObjectFlow89_LiteralInteger91 = new();
				public ControlFlow AssemblyConnectors_PWP_P_main_ControlFlow92 = new();
				public CallBehaviorAction AssemblyConnectors_PWP_P_main_instantiate_A_Star_Pattern = new();
					public OutputPin AssemblyConnectors_PWP_P_main_instantiate_A_Star_Pattern_a_Star_Pattern = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_main_instantiate_A_Star_Pattern_a_Star_Pattern_LiteralUnlimitedNatural93 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_main_instantiate_A_Star_Pattern_a_Star_Pattern_LiteralInteger94 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_main_instantiate_A_Star_Pattern_a_Star_Pattern_LiteralInteger95 = new();
				public ObjectFlow AssemblyConnectors_PWP_P_main_ObjectFlow96 = new();
					public LiteralBoolean AssemblyConnectors_PWP_P_main_ObjectFlow96_LiteralBoolean97 = new();
					public LiteralInteger AssemblyConnectors_PWP_P_main_ObjectFlow96_LiteralInteger98 = new();
				public ObjectFlow AssemblyConnectors_PWP_P_main_ObjectFlow99 = new();
					public LiteralInteger AssemblyConnectors_PWP_P_main_ObjectFlow99_LiteralInteger100 = new();
					public LiteralBoolean AssemblyConnectors_PWP_P_main_ObjectFlow99_LiteralBoolean101 = new();
				public CallBehaviorAction AssemblyConnectors_PWP_P_main_assert_A_Array_Pattern = new();
					public InputPin AssemblyConnectors_PWP_P_main_assert_A_Array_Pattern_a_Array_Pattern = new();
						public LiteralInteger AssemblyConnectors_PWP_P_main_assert_A_Array_Pattern_a_Array_Pattern_LiteralInteger102 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_main_assert_A_Array_Pattern_a_Array_Pattern_LiteralInteger103 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_main_assert_A_Array_Pattern_a_Array_Pattern_LiteralUnlimitedNatural104 = new();
				public CallBehaviorAction AssemblyConnectors_PWP_P_main_assert_A_Empty_Pattern = new();
					public InputPin AssemblyConnectors_PWP_P_main_assert_A_Empty_Pattern_a_Empty_Pattern = new();
						public LiteralInteger AssemblyConnectors_PWP_P_main_assert_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger105 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_main_assert_A_Empty_Pattern_a_Empty_Pattern_LiteralUnlimitedNatural106 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_main_assert_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger107 = new();
				public CallBehaviorAction AssemblyConnectors_PWP_P_main_instantiate_A_Unconnected_Pattern = new();
					public OutputPin AssemblyConnectors_PWP_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern = new();
						public LiteralInteger AssemblyConnectors_PWP_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger108 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralUnlimitedNatural109 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger110 = new();
				public ControlFlow AssemblyConnectors_PWP_P_main_ControlFlow111 = new();
				public CallBehaviorAction AssemblyConnectors_PWP_P_main_assert_A_Star_Pattern = new();
					public InputPin AssemblyConnectors_PWP_P_main_assert_A_Star_Pattern_a_Star_Pattern = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_main_assert_A_Star_Pattern_a_Star_Pattern_LiteralUnlimitedNatural112 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_main_assert_A_Star_Pattern_a_Star_Pattern_LiteralInteger113 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_main_assert_A_Star_Pattern_a_Star_Pattern_LiteralInteger114 = new();
				public ControlFlow AssemblyConnectors_PWP_P_main_ControlFlow115 = new();
				public CallBehaviorAction AssemblyConnectors_PWP_P_main_instantiate_A_Empty_Pattern = new();
					public OutputPin AssemblyConnectors_PWP_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern_LiteralUnlimitedNatural116 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger117 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger118 = new();
				public CallBehaviorAction AssemblyConnectors_PWP_P_main_assert_A_Unconnected_Pattern = new();
					public InputPin AssemblyConnectors_PWP_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern = new();
						public LiteralInteger AssemblyConnectors_PWP_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger119 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralUnlimitedNatural120 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger121 = new();
				public ObjectFlow AssemblyConnectors_PWP_P_main_ObjectFlow122 = new();
					public LiteralInteger AssemblyConnectors_PWP_P_main_ObjectFlow122_LiteralInteger123 = new();
					public LiteralBoolean AssemblyConnectors_PWP_P_main_ObjectFlow122_LiteralBoolean124 = new();
				public CallBehaviorAction AssemblyConnectors_PWP_P_main_instantiate_A_Array_Pattern = new();
					public OutputPin AssemblyConnectors_PWP_P_main_instantiate_A_Array_Pattern_a_Array_Pattern = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_main_instantiate_A_Array_Pattern_a_Array_Pattern_LiteralUnlimitedNatural125 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_main_instantiate_A_Array_Pattern_a_Array_Pattern_LiteralInteger126 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_main_instantiate_A_Array_Pattern_a_Array_Pattern_LiteralInteger127 = new();
			public Activity AssemblyConnectors_PWP_P_assert_A_Empty_Pattern = new();
				public ObjectFlow AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_ObjectFlow128 = new();
					public LiteralBoolean AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_ObjectFlow128_LiteralBoolean129 = new();
					public LiteralInteger AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_ObjectFlow128_LiteralInteger130 = new();
				public ActivityParameterNode AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_a_Empty_Pattern_node = new();
					public LiteralInteger AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_a_Empty_Pattern_node_LiteralInteger131 = new();
				public ValueSpecificationAction AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_message = new();
					public OutputPin AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_message_result = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_message_result_LiteralUnlimitedNatural132 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_message_result_LiteralInteger133 = new();
					public LiteralString AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_message_LiteralString134 = new();
				public Parameter AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_a_Empty_Pattern = new();
				public CallBehaviorAction AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine = new();
					public InputPin AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine_value = new();
						public LiteralInteger AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine_value_LiteralInteger135 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine_value_LiteralInteger136 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine_value_LiteralUnlimitedNatural137 = new();
					public OutputPin AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine_errorStatus = new();
						public LiteralInteger AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine_errorStatus_LiteralInteger138 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine_errorStatus_LiteralInteger139 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural140 = new();
			public Class_ AssemblyConnectors_PWP_P_IImpl = new();
				public InterfaceRealization AssemblyConnectors_PWP_P_IImpl_I_Realization = new();
			public Activity AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern = new();
				public ObjectFlow AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_ObjectFlow141 = new();
					public LiteralInteger AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_ObjectFlow141_LiteralInteger142 = new();
					public LiteralBoolean AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_ObjectFlow141_LiteralBoolean143 = new();
				public CreateObjectAction AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern = new();
					public OutputPin AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result_LiteralUnlimitedNatural144 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result_LiteralInteger145 = new();
				public CallOperationAction AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_ = new();
					public OutputPin AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result_LiteralUnlimitedNatural146 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result_LiteralInteger147 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result_LiteralInteger148 = new();
					public InputPin AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target_LiteralUnlimitedNatural149 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target_LiteralInteger150 = new();
				public Parameter AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern = new();
				public ActivityParameterNode AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node = new();
				public ObjectFlow AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_ObjectFlow151 = new();
					public LiteralBoolean AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_ObjectFlow151_LiteralBoolean152 = new();
					public LiteralInteger AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_ObjectFlow151_LiteralInteger153 = new();
			public Class_ AssemblyConnectors_PWP_P_A_Empty_Pattern = new();
				public Property AssemblyConnectors_PWP_P_A_Empty_Pattern_partB = new();
					public LiteralInteger AssemblyConnectors_PWP_P_A_Empty_Pattern_partB_LiteralInteger154 = new();
					public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_A_Empty_Pattern_partB_LiteralUnlimitedNatural155 = new();
				public Property AssemblyConnectors_PWP_P_A_Empty_Pattern_partC = new();
					public LiteralInteger AssemblyConnectors_PWP_P_A_Empty_Pattern_partC_LiteralInteger156 = new();
					public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_A_Empty_Pattern_partC_LiteralUnlimitedNatural157 = new();
				public Operation AssemblyConnectors_PWP_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern = new();
					public Parameter AssemblyConnectors_PWP_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result = new();
				public Connector AssemblyConnectors_PWP_P_A_Empty_Pattern_r = new();
					public ConnectorEnd AssemblyConnectors_PWP_P_A_Empty_Pattern_r_ConnectorEnd158 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_A_Empty_Pattern_r_ConnectorEnd158_connectorEnd_2_Upper = new();
						public LiteralInteger AssemblyConnectors_PWP_P_A_Empty_Pattern_r_ConnectorEnd158_connectorEnd_2_Lower = new();
					public ConnectorEnd AssemblyConnectors_PWP_P_A_Empty_Pattern_r_ConnectorEnd159 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_A_Empty_Pattern_r_ConnectorEnd159_connectorEnd_1_Upper = new();
						public LiteralInteger AssemblyConnectors_PWP_P_A_Empty_Pattern_r_ConnectorEnd159_connectorEnd_1_Lower = new();
				public Comment AssemblyConnectors_PWP_P_A_Empty_Pattern_Comment160 = new();
			public Activity AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern = new();
				public ObjectFlow AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_ObjectFlow161 = new();
					public LiteralInteger AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_ObjectFlow161_LiteralInteger162 = new();
					public LiteralBoolean AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_ObjectFlow161_LiteralBoolean163 = new();
				public CallBehaviorAction AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine = new();
					public OutputPin AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine_errorStatus = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural164 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine_errorStatus_LiteralInteger165 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine_errorStatus_LiteralInteger166 = new();
					public InputPin AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine_value = new();
						public LiteralInteger AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine_value_LiteralInteger167 = new();
						public LiteralInteger AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine_value_LiteralInteger168 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine_value_LiteralUnlimitedNatural169 = new();
				public Parameter AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern = new();
				public ActivityParameterNode AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node = new();
					public LiteralInteger AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node_LiteralInteger170 = new();
				public ValueSpecificationAction AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_message = new();
					public LiteralString AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_message_LiteralString171 = new();
					public OutputPin AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_message_result = new();
						public LiteralInteger AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_message_result_LiteralInteger172 = new();
						public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_message_result_LiteralUnlimitedNatural173 = new();
			public Association AssemblyConnectors_PWP_P_R = new();
				public Property AssemblyConnectors_PWP_P_R_y = new();
					public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_R_y_LiteralUnlimitedNatural174 = new();
					public LiteralInteger AssemblyConnectors_PWP_P_R_y_LiteralInteger175 = new();
				public Property AssemblyConnectors_PWP_P_R_x = new();
					public LiteralInteger AssemblyConnectors_PWP_P_R_x_LiteralInteger176 = new();
					public LiteralUnlimitedNatural AssemblyConnectors_PWP_P_R_x_LiteralUnlimitedNatural177 = new();

		public static AssemblyConnectors_PWP_PModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public AssemblyConnectors_PWP_PModel()
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
			 * Model AssemblyConnectors_PWP_P
			 */
			AddToElementRepository("AssemblyConnectors_PWP_P", AssemblyConnectors_PWP_P);
				AddToElementRepository("instantiate_A_Empty_Pattern", AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern);
					AddToElementRepository("A_Empty_Pattern()", AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_A_Empty_Pattern_);
						AddToElementRepository("target", AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target);
							AddToElementRepository("LiteralInteger0", AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target_LiteralInteger0);
							AddToElementRepository("LiteralUnlimitedNatural1", AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target_LiteralUnlimitedNatural1);
						AddToElementRepository("result", AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result);
							AddToElementRepository("LiteralInteger2", AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result_LiteralInteger2);
							AddToElementRepository("LiteralInteger3", AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result_LiteralInteger3);
							AddToElementRepository("LiteralUnlimitedNatural4", AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result_LiteralUnlimitedNatural4);
					AddToElementRepository("ObjectFlow5", AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_ObjectFlow5);
						AddToElementRepository("LiteralBoolean6", AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_ObjectFlow5_LiteralBoolean6);
						AddToElementRepository("LiteralInteger7", AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_ObjectFlow5_LiteralInteger7);
					AddToElementRepository("ObjectFlow8", AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_ObjectFlow8);
						AddToElementRepository("LiteralInteger9", AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_ObjectFlow8_LiteralInteger9);
						AddToElementRepository("LiteralBoolean10", AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_ObjectFlow8_LiteralBoolean10);
					AddToElementRepository("a_Empty_Pattern", AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_a_Empty_Pattern);
					AddToElementRepository("a_Empty_Pattern_node", AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_a_Empty_Pattern_node);
					AddToElementRepository("Create A_Empty_Pattern", AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern);
						AddToElementRepository("result", AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result);
							AddToElementRepository("LiteralUnlimitedNatural11", AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result_LiteralUnlimitedNatural11);
							AddToElementRepository("LiteralInteger12", AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result_LiteralInteger12);
				AddToElementRepository("assert_A_Star_Pattern", AssemblyConnectors_PWP_P_assert_A_Star_Pattern);
					AddToElementRepository("a_Star_Pattern_node", AssemblyConnectors_PWP_P_assert_A_Star_Pattern_a_Star_Pattern_node);
						AddToElementRepository("LiteralInteger13", AssemblyConnectors_PWP_P_assert_A_Star_Pattern_a_Star_Pattern_node_LiteralInteger13);
					AddToElementRepository("a_Star_Pattern", AssemblyConnectors_PWP_P_assert_A_Star_Pattern_a_Star_Pattern);
					AddToElementRepository("ObjectFlow14", AssemblyConnectors_PWP_P_assert_A_Star_Pattern_ObjectFlow14);
						AddToElementRepository("LiteralBoolean15", AssemblyConnectors_PWP_P_assert_A_Star_Pattern_ObjectFlow14_LiteralBoolean15);
						AddToElementRepository("LiteralInteger16", AssemblyConnectors_PWP_P_assert_A_Star_Pattern_ObjectFlow14_LiteralInteger16);
					AddToElementRepository("message", AssemblyConnectors_PWP_P_assert_A_Star_Pattern_message);
						AddToElementRepository("LiteralString17", AssemblyConnectors_PWP_P_assert_A_Star_Pattern_message_LiteralString17);
						AddToElementRepository("result", AssemblyConnectors_PWP_P_assert_A_Star_Pattern_message_result);
							AddToElementRepository("LiteralInteger18", AssemblyConnectors_PWP_P_assert_A_Star_Pattern_message_result_LiteralInteger18);
							AddToElementRepository("LiteralUnlimitedNatural19", AssemblyConnectors_PWP_P_assert_A_Star_Pattern_message_result_LiteralUnlimitedNatural19);
					AddToElementRepository("writeLine", AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine);
						AddToElementRepository("errorStatus", AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine_errorStatus);
							AddToElementRepository("LiteralInteger20", AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine_errorStatus_LiteralInteger20);
							AddToElementRepository("LiteralInteger21", AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine_errorStatus_LiteralInteger21);
							AddToElementRepository("LiteralUnlimitedNatural22", AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural22);
						AddToElementRepository("value", AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine_value);
							AddToElementRepository("LiteralUnlimitedNatural23", AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine_value_LiteralUnlimitedNatural23);
							AddToElementRepository("LiteralInteger24", AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine_value_LiteralInteger24);
							AddToElementRepository("LiteralInteger25", AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine_value_LiteralInteger25);
				AddToElementRepository("C", AssemblyConnectors_PWP_P_C);
				AddToElementRepository("instantiate_A_Star_Pattern", AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern);
					AddToElementRepository("a_Star_Pattern_node", AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_a_Star_Pattern_node);
					AddToElementRepository("Create A_Star_Pattern", AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern);
						AddToElementRepository("result", AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result);
							AddToElementRepository("LiteralInteger26", AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result_LiteralInteger26);
							AddToElementRepository("LiteralUnlimitedNatural27", AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result_LiteralUnlimitedNatural27);
					AddToElementRepository("A_Star_Pattern()", AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_A_Star_Pattern_);
						AddToElementRepository("target", AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_A_Star_Pattern__target);
							AddToElementRepository("LiteralUnlimitedNatural28", AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_A_Star_Pattern__target_LiteralUnlimitedNatural28);
							AddToElementRepository("LiteralInteger29", AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_A_Star_Pattern__target_LiteralInteger29);
						AddToElementRepository("result", AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_A_Star_Pattern__result);
							AddToElementRepository("LiteralInteger30", AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_A_Star_Pattern__result_LiteralInteger30);
							AddToElementRepository("LiteralInteger31", AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_A_Star_Pattern__result_LiteralInteger31);
							AddToElementRepository("LiteralUnlimitedNatural32", AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_A_Star_Pattern__result_LiteralUnlimitedNatural32);
					AddToElementRepository("a_Star_Pattern", AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_a_Star_Pattern);
					AddToElementRepository("ObjectFlow33", AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_ObjectFlow33);
						AddToElementRepository("LiteralInteger34", AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_ObjectFlow33_LiteralInteger34);
						AddToElementRepository("LiteralBoolean35", AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_ObjectFlow33_LiteralBoolean35);
					AddToElementRepository("ObjectFlow36", AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_ObjectFlow36);
						AddToElementRepository("LiteralBoolean37", AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_ObjectFlow36_LiteralBoolean37);
						AddToElementRepository("LiteralInteger38", AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_ObjectFlow36_LiteralInteger38);
				AddToElementRepository("B", AssemblyConnectors_PWP_P_B);
					AddToElementRepository("p", AssemblyConnectors_PWP_P_B_p);
						AddToElementRepository("LiteralUnlimitedNatural39", AssemblyConnectors_PWP_P_B_p_LiteralUnlimitedNatural39);
						AddToElementRepository("LiteralInteger40", AssemblyConnectors_PWP_P_B_p_LiteralInteger40);
				AddToElementRepository("A_Star_Pattern", AssemblyConnectors_PWP_P_A_Star_Pattern);
					AddToElementRepository("Comment41", AssemblyConnectors_PWP_P_A_Star_Pattern_Comment41);
					AddToElementRepository("partC", AssemblyConnectors_PWP_P_A_Star_Pattern_partC);
						AddToElementRepository("LiteralUnlimitedNatural42", AssemblyConnectors_PWP_P_A_Star_Pattern_partC_LiteralUnlimitedNatural42);
						AddToElementRepository("LiteralInteger43", AssemblyConnectors_PWP_P_A_Star_Pattern_partC_LiteralInteger43);
					AddToElementRepository("A_Star_Pattern_A_Star_Pattern", AssemblyConnectors_PWP_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern);
						AddToElementRepository("result", AssemblyConnectors_PWP_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result);
					AddToElementRepository("r", AssemblyConnectors_PWP_P_A_Star_Pattern_r);
						AddToElementRepository("ConnectorEnd44", AssemblyConnectors_PWP_P_A_Star_Pattern_r_ConnectorEnd44);
							AddToElementRepository("connectorEnd_2_Lower", AssemblyConnectors_PWP_P_A_Star_Pattern_r_ConnectorEnd44_connectorEnd_2_Lower);
							AddToElementRepository("connectorEnd_2_Upper", AssemblyConnectors_PWP_P_A_Star_Pattern_r_ConnectorEnd44_connectorEnd_2_Upper);
						AddToElementRepository("ConnectorEnd45", AssemblyConnectors_PWP_P_A_Star_Pattern_r_ConnectorEnd45);
							AddToElementRepository("connectorEnd_1_Upper", AssemblyConnectors_PWP_P_A_Star_Pattern_r_ConnectorEnd45_connectorEnd_1_Upper);
							AddToElementRepository("connectorEnd_1_Lower", AssemblyConnectors_PWP_P_A_Star_Pattern_r_ConnectorEnd45_connectorEnd_1_Lower);
					AddToElementRepository("partB", AssemblyConnectors_PWP_P_A_Star_Pattern_partB);
						AddToElementRepository("LiteralUnlimitedNatural46", AssemblyConnectors_PWP_P_A_Star_Pattern_partB_LiteralUnlimitedNatural46);
						AddToElementRepository("LiteralInteger47", AssemblyConnectors_PWP_P_A_Star_Pattern_partB_LiteralInteger47);
				AddToElementRepository("assert_A_Array_Pattern", AssemblyConnectors_PWP_P_assert_A_Array_Pattern);
					AddToElementRepository("a_Array_Pattern", AssemblyConnectors_PWP_P_assert_A_Array_Pattern_a_Array_Pattern);
					AddToElementRepository("message", AssemblyConnectors_PWP_P_assert_A_Array_Pattern_message);
						AddToElementRepository("result", AssemblyConnectors_PWP_P_assert_A_Array_Pattern_message_result);
							AddToElementRepository("LiteralUnlimitedNatural48", AssemblyConnectors_PWP_P_assert_A_Array_Pattern_message_result_LiteralUnlimitedNatural48);
							AddToElementRepository("LiteralInteger49", AssemblyConnectors_PWP_P_assert_A_Array_Pattern_message_result_LiteralInteger49);
						AddToElementRepository("LiteralString50", AssemblyConnectors_PWP_P_assert_A_Array_Pattern_message_LiteralString50);
					AddToElementRepository("writeLine", AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine);
						AddToElementRepository("errorStatus", AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine_errorStatus);
							AddToElementRepository("LiteralInteger51", AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine_errorStatus_LiteralInteger51);
							AddToElementRepository("LiteralUnlimitedNatural52", AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural52);
							AddToElementRepository("LiteralInteger53", AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine_errorStatus_LiteralInteger53);
						AddToElementRepository("value", AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine_value);
							AddToElementRepository("LiteralInteger54", AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine_value_LiteralInteger54);
							AddToElementRepository("LiteralInteger55", AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine_value_LiteralInteger55);
							AddToElementRepository("LiteralUnlimitedNatural56", AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine_value_LiteralUnlimitedNatural56);
					AddToElementRepository("a_Array_Pattern_node", AssemblyConnectors_PWP_P_assert_A_Array_Pattern_a_Array_Pattern_node);
						AddToElementRepository("LiteralInteger57", AssemblyConnectors_PWP_P_assert_A_Array_Pattern_a_Array_Pattern_node_LiteralInteger57);
					AddToElementRepository("ObjectFlow58", AssemblyConnectors_PWP_P_assert_A_Array_Pattern_ObjectFlow58);
						AddToElementRepository("LiteralInteger59", AssemblyConnectors_PWP_P_assert_A_Array_Pattern_ObjectFlow58_LiteralInteger59);
						AddToElementRepository("LiteralBoolean60", AssemblyConnectors_PWP_P_assert_A_Array_Pattern_ObjectFlow58_LiteralBoolean60);
				AddToElementRepository("instantiate_A_Array_Pattern", AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern);
					AddToElementRepository("a_Array_Pattern_node", AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_a_Array_Pattern_node);
						AddToElementRepository("LiteralInteger61", AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_a_Array_Pattern_node_LiteralInteger61);
					AddToElementRepository("A_Array_Pattern()", AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_A_Array_Pattern_);
						AddToElementRepository("target", AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_A_Array_Pattern__target);
							AddToElementRepository("LiteralInteger62", AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_A_Array_Pattern__target_LiteralInteger62);
							AddToElementRepository("LiteralUnlimitedNatural63", AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_A_Array_Pattern__target_LiteralUnlimitedNatural63);
						AddToElementRepository("result", AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_A_Array_Pattern__result);
							AddToElementRepository("LiteralInteger64", AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_A_Array_Pattern__result_LiteralInteger64);
							AddToElementRepository("LiteralUnlimitedNatural65", AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_A_Array_Pattern__result_LiteralUnlimitedNatural65);
							AddToElementRepository("LiteralInteger66", AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_A_Array_Pattern__result_LiteralInteger66);
					AddToElementRepository("Create A_Array_Pattern", AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern);
						AddToElementRepository("result", AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result);
							AddToElementRepository("LiteralUnlimitedNatural67", AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result_LiteralUnlimitedNatural67);
							AddToElementRepository("LiteralInteger68", AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result_LiteralInteger68);
					AddToElementRepository("ObjectFlow69", AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_ObjectFlow69);
						AddToElementRepository("LiteralInteger70", AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_ObjectFlow69_LiteralInteger70);
						AddToElementRepository("LiteralBoolean71", AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_ObjectFlow69_LiteralBoolean71);
					AddToElementRepository("a_Array_Pattern", AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_a_Array_Pattern);
					AddToElementRepository("ObjectFlow72", AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_ObjectFlow72);
						AddToElementRepository("LiteralBoolean73", AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_ObjectFlow72_LiteralBoolean73);
						AddToElementRepository("LiteralInteger74", AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_ObjectFlow72_LiteralInteger74);
				AddToElementRepository("I", AssemblyConnectors_PWP_P_I);
				AddToElementRepository("A_Unconnected_Pattern", AssemblyConnectors_PWP_P_A_Unconnected_Pattern);
					AddToElementRepository("Comment75", AssemblyConnectors_PWP_P_A_Unconnected_Pattern_Comment75);
					AddToElementRepository("partC", AssemblyConnectors_PWP_P_A_Unconnected_Pattern_partC);
						AddToElementRepository("LiteralInteger76", AssemblyConnectors_PWP_P_A_Unconnected_Pattern_partC_LiteralInteger76);
						AddToElementRepository("LiteralUnlimitedNatural77", AssemblyConnectors_PWP_P_A_Unconnected_Pattern_partC_LiteralUnlimitedNatural77);
					AddToElementRepository("partB", AssemblyConnectors_PWP_P_A_Unconnected_Pattern_partB);
						AddToElementRepository("LiteralUnlimitedNatural78", AssemblyConnectors_PWP_P_A_Unconnected_Pattern_partB_LiteralUnlimitedNatural78);
						AddToElementRepository("LiteralInteger79", AssemblyConnectors_PWP_P_A_Unconnected_Pattern_partB_LiteralInteger79);
					AddToElementRepository("r", AssemblyConnectors_PWP_P_A_Unconnected_Pattern_r);
						AddToElementRepository("ConnectorEnd80", AssemblyConnectors_PWP_P_A_Unconnected_Pattern_r_ConnectorEnd80);
							AddToElementRepository("connectorEnd_2_Lower", AssemblyConnectors_PWP_P_A_Unconnected_Pattern_r_ConnectorEnd80_connectorEnd_2_Lower);
							AddToElementRepository("connectorEnd_2_Upper", AssemblyConnectors_PWP_P_A_Unconnected_Pattern_r_ConnectorEnd80_connectorEnd_2_Upper);
						AddToElementRepository("ConnectorEnd81", AssemblyConnectors_PWP_P_A_Unconnected_Pattern_r_ConnectorEnd81);
							AddToElementRepository("connectorEnd_1_Lower", AssemblyConnectors_PWP_P_A_Unconnected_Pattern_r_ConnectorEnd81_connectorEnd_1_Lower);
							AddToElementRepository("connectorEnd_1_Upper", AssemblyConnectors_PWP_P_A_Unconnected_Pattern_r_ConnectorEnd81_connectorEnd_1_Upper);
					AddToElementRepository("A_Unconnected_Pattern_A_Unconnected_Pattern", AssemblyConnectors_PWP_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern);
						AddToElementRepository("result", AssemblyConnectors_PWP_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result);
				AddToElementRepository("A_Array_Pattern", AssemblyConnectors_PWP_P_A_Array_Pattern);
					AddToElementRepository("partB", AssemblyConnectors_PWP_P_A_Array_Pattern_partB);
						AddToElementRepository("LiteralInteger82", AssemblyConnectors_PWP_P_A_Array_Pattern_partB_LiteralInteger82);
						AddToElementRepository("LiteralUnlimitedNatural83", AssemblyConnectors_PWP_P_A_Array_Pattern_partB_LiteralUnlimitedNatural83);
					AddToElementRepository("partC", AssemblyConnectors_PWP_P_A_Array_Pattern_partC);
						AddToElementRepository("LiteralUnlimitedNatural84", AssemblyConnectors_PWP_P_A_Array_Pattern_partC_LiteralUnlimitedNatural84);
						AddToElementRepository("LiteralInteger85", AssemblyConnectors_PWP_P_A_Array_Pattern_partC_LiteralInteger85);
					AddToElementRepository("Comment86", AssemblyConnectors_PWP_P_A_Array_Pattern_Comment86);
					AddToElementRepository("r", AssemblyConnectors_PWP_P_A_Array_Pattern_r);
						AddToElementRepository("ConnectorEnd87", AssemblyConnectors_PWP_P_A_Array_Pattern_r_ConnectorEnd87);
							AddToElementRepository("connectorEnd_1_Lower", AssemblyConnectors_PWP_P_A_Array_Pattern_r_ConnectorEnd87_connectorEnd_1_Lower);
							AddToElementRepository("connectorEnd_1_Upper", AssemblyConnectors_PWP_P_A_Array_Pattern_r_ConnectorEnd87_connectorEnd_1_Upper);
						AddToElementRepository("ConnectorEnd88", AssemblyConnectors_PWP_P_A_Array_Pattern_r_ConnectorEnd88);
							AddToElementRepository("connectorEnd_2_Lower", AssemblyConnectors_PWP_P_A_Array_Pattern_r_ConnectorEnd88_connectorEnd_2_Lower);
							AddToElementRepository("connectorEnd_2_Upper", AssemblyConnectors_PWP_P_A_Array_Pattern_r_ConnectorEnd88_connectorEnd_2_Upper);
					AddToElementRepository("A_Array_Pattern_A_Array_Pattern", AssemblyConnectors_PWP_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern);
						AddToElementRepository("result", AssemblyConnectors_PWP_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result);
				AddToElementRepository("main", AssemblyConnectors_PWP_P_main);
					AddToElementRepository("ObjectFlow89", AssemblyConnectors_PWP_P_main_ObjectFlow89);
						AddToElementRepository("LiteralBoolean90", AssemblyConnectors_PWP_P_main_ObjectFlow89_LiteralBoolean90);
						AddToElementRepository("LiteralInteger91", AssemblyConnectors_PWP_P_main_ObjectFlow89_LiteralInteger91);
					AddToElementRepository("ControlFlow92", AssemblyConnectors_PWP_P_main_ControlFlow92);
					AddToElementRepository("instantiate_A_Star_Pattern", AssemblyConnectors_PWP_P_main_instantiate_A_Star_Pattern);
						AddToElementRepository("a_Star_Pattern", AssemblyConnectors_PWP_P_main_instantiate_A_Star_Pattern_a_Star_Pattern);
							AddToElementRepository("LiteralUnlimitedNatural93", AssemblyConnectors_PWP_P_main_instantiate_A_Star_Pattern_a_Star_Pattern_LiteralUnlimitedNatural93);
							AddToElementRepository("LiteralInteger94", AssemblyConnectors_PWP_P_main_instantiate_A_Star_Pattern_a_Star_Pattern_LiteralInteger94);
							AddToElementRepository("LiteralInteger95", AssemblyConnectors_PWP_P_main_instantiate_A_Star_Pattern_a_Star_Pattern_LiteralInteger95);
					AddToElementRepository("ObjectFlow96", AssemblyConnectors_PWP_P_main_ObjectFlow96);
						AddToElementRepository("LiteralBoolean97", AssemblyConnectors_PWP_P_main_ObjectFlow96_LiteralBoolean97);
						AddToElementRepository("LiteralInteger98", AssemblyConnectors_PWP_P_main_ObjectFlow96_LiteralInteger98);
					AddToElementRepository("ObjectFlow99", AssemblyConnectors_PWP_P_main_ObjectFlow99);
						AddToElementRepository("LiteralInteger100", AssemblyConnectors_PWP_P_main_ObjectFlow99_LiteralInteger100);
						AddToElementRepository("LiteralBoolean101", AssemblyConnectors_PWP_P_main_ObjectFlow99_LiteralBoolean101);
					AddToElementRepository("assert_A_Array_Pattern", AssemblyConnectors_PWP_P_main_assert_A_Array_Pattern);
						AddToElementRepository("a_Array_Pattern", AssemblyConnectors_PWP_P_main_assert_A_Array_Pattern_a_Array_Pattern);
							AddToElementRepository("LiteralInteger102", AssemblyConnectors_PWP_P_main_assert_A_Array_Pattern_a_Array_Pattern_LiteralInteger102);
							AddToElementRepository("LiteralInteger103", AssemblyConnectors_PWP_P_main_assert_A_Array_Pattern_a_Array_Pattern_LiteralInteger103);
							AddToElementRepository("LiteralUnlimitedNatural104", AssemblyConnectors_PWP_P_main_assert_A_Array_Pattern_a_Array_Pattern_LiteralUnlimitedNatural104);
					AddToElementRepository("assert_A_Empty_Pattern", AssemblyConnectors_PWP_P_main_assert_A_Empty_Pattern);
						AddToElementRepository("a_Empty_Pattern", AssemblyConnectors_PWP_P_main_assert_A_Empty_Pattern_a_Empty_Pattern);
							AddToElementRepository("LiteralInteger105", AssemblyConnectors_PWP_P_main_assert_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger105);
							AddToElementRepository("LiteralUnlimitedNatural106", AssemblyConnectors_PWP_P_main_assert_A_Empty_Pattern_a_Empty_Pattern_LiteralUnlimitedNatural106);
							AddToElementRepository("LiteralInteger107", AssemblyConnectors_PWP_P_main_assert_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger107);
					AddToElementRepository("instantiate_A_Unconnected_Pattern", AssemblyConnectors_PWP_P_main_instantiate_A_Unconnected_Pattern);
						AddToElementRepository("a_Unconnected_Pattern", AssemblyConnectors_PWP_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern);
							AddToElementRepository("LiteralInteger108", AssemblyConnectors_PWP_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger108);
							AddToElementRepository("LiteralUnlimitedNatural109", AssemblyConnectors_PWP_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralUnlimitedNatural109);
							AddToElementRepository("LiteralInteger110", AssemblyConnectors_PWP_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger110);
					AddToElementRepository("ControlFlow111", AssemblyConnectors_PWP_P_main_ControlFlow111);
					AddToElementRepository("assert_A_Star_Pattern", AssemblyConnectors_PWP_P_main_assert_A_Star_Pattern);
						AddToElementRepository("a_Star_Pattern", AssemblyConnectors_PWP_P_main_assert_A_Star_Pattern_a_Star_Pattern);
							AddToElementRepository("LiteralUnlimitedNatural112", AssemblyConnectors_PWP_P_main_assert_A_Star_Pattern_a_Star_Pattern_LiteralUnlimitedNatural112);
							AddToElementRepository("LiteralInteger113", AssemblyConnectors_PWP_P_main_assert_A_Star_Pattern_a_Star_Pattern_LiteralInteger113);
							AddToElementRepository("LiteralInteger114", AssemblyConnectors_PWP_P_main_assert_A_Star_Pattern_a_Star_Pattern_LiteralInteger114);
					AddToElementRepository("ControlFlow115", AssemblyConnectors_PWP_P_main_ControlFlow115);
					AddToElementRepository("instantiate_A_Empty_Pattern", AssemblyConnectors_PWP_P_main_instantiate_A_Empty_Pattern);
						AddToElementRepository("a_Empty_Pattern", AssemblyConnectors_PWP_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern);
							AddToElementRepository("LiteralUnlimitedNatural116", AssemblyConnectors_PWP_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern_LiteralUnlimitedNatural116);
							AddToElementRepository("LiteralInteger117", AssemblyConnectors_PWP_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger117);
							AddToElementRepository("LiteralInteger118", AssemblyConnectors_PWP_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger118);
					AddToElementRepository("assert_A_Unconnected_Pattern", AssemblyConnectors_PWP_P_main_assert_A_Unconnected_Pattern);
						AddToElementRepository("a_Unconnected_Pattern", AssemblyConnectors_PWP_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern);
							AddToElementRepository("LiteralInteger119", AssemblyConnectors_PWP_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger119);
							AddToElementRepository("LiteralUnlimitedNatural120", AssemblyConnectors_PWP_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralUnlimitedNatural120);
							AddToElementRepository("LiteralInteger121", AssemblyConnectors_PWP_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger121);
					AddToElementRepository("ObjectFlow122", AssemblyConnectors_PWP_P_main_ObjectFlow122);
						AddToElementRepository("LiteralInteger123", AssemblyConnectors_PWP_P_main_ObjectFlow122_LiteralInteger123);
						AddToElementRepository("LiteralBoolean124", AssemblyConnectors_PWP_P_main_ObjectFlow122_LiteralBoolean124);
					AddToElementRepository("instantiate_A_Array_Pattern", AssemblyConnectors_PWP_P_main_instantiate_A_Array_Pattern);
						AddToElementRepository("a_Array_Pattern", AssemblyConnectors_PWP_P_main_instantiate_A_Array_Pattern_a_Array_Pattern);
							AddToElementRepository("LiteralUnlimitedNatural125", AssemblyConnectors_PWP_P_main_instantiate_A_Array_Pattern_a_Array_Pattern_LiteralUnlimitedNatural125);
							AddToElementRepository("LiteralInteger126", AssemblyConnectors_PWP_P_main_instantiate_A_Array_Pattern_a_Array_Pattern_LiteralInteger126);
							AddToElementRepository("LiteralInteger127", AssemblyConnectors_PWP_P_main_instantiate_A_Array_Pattern_a_Array_Pattern_LiteralInteger127);
				AddToElementRepository("assert_A_Empty_Pattern", AssemblyConnectors_PWP_P_assert_A_Empty_Pattern);
					AddToElementRepository("ObjectFlow128", AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_ObjectFlow128);
						AddToElementRepository("LiteralBoolean129", AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_ObjectFlow128_LiteralBoolean129);
						AddToElementRepository("LiteralInteger130", AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_ObjectFlow128_LiteralInteger130);
					AddToElementRepository("a_Empty_Pattern_node", AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_a_Empty_Pattern_node);
						AddToElementRepository("LiteralInteger131", AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_a_Empty_Pattern_node_LiteralInteger131);
					AddToElementRepository("message", AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_message);
						AddToElementRepository("result", AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_message_result);
							AddToElementRepository("LiteralUnlimitedNatural132", AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_message_result_LiteralUnlimitedNatural132);
							AddToElementRepository("LiteralInteger133", AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_message_result_LiteralInteger133);
						AddToElementRepository("LiteralString134", AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_message_LiteralString134);
					AddToElementRepository("a_Empty_Pattern", AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_a_Empty_Pattern);
					AddToElementRepository("writeLine", AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine);
						AddToElementRepository("value", AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine_value);
							AddToElementRepository("LiteralInteger135", AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine_value_LiteralInteger135);
							AddToElementRepository("LiteralInteger136", AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine_value_LiteralInteger136);
							AddToElementRepository("LiteralUnlimitedNatural137", AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine_value_LiteralUnlimitedNatural137);
						AddToElementRepository("errorStatus", AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine_errorStatus);
							AddToElementRepository("LiteralInteger138", AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine_errorStatus_LiteralInteger138);
							AddToElementRepository("LiteralInteger139", AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine_errorStatus_LiteralInteger139);
							AddToElementRepository("LiteralUnlimitedNatural140", AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural140);
				AddToElementRepository("IImpl", AssemblyConnectors_PWP_P_IImpl);
					AddToElementRepository("I_Realization", AssemblyConnectors_PWP_P_IImpl_I_Realization);
				AddToElementRepository("instantiate_A_Unconnected_Pattern", AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern);
					AddToElementRepository("ObjectFlow141", AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_ObjectFlow141);
						AddToElementRepository("LiteralInteger142", AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_ObjectFlow141_LiteralInteger142);
						AddToElementRepository("LiteralBoolean143", AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_ObjectFlow141_LiteralBoolean143);
					AddToElementRepository("Create A_Unconnected_Pattern", AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern);
						AddToElementRepository("result", AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result);
							AddToElementRepository("LiteralUnlimitedNatural144", AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result_LiteralUnlimitedNatural144);
							AddToElementRepository("LiteralInteger145", AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result_LiteralInteger145);
					AddToElementRepository("A_Unconnected_Pattern()", AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_);
						AddToElementRepository("result", AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result);
							AddToElementRepository("LiteralUnlimitedNatural146", AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result_LiteralUnlimitedNatural146);
							AddToElementRepository("LiteralInteger147", AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result_LiteralInteger147);
							AddToElementRepository("LiteralInteger148", AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result_LiteralInteger148);
						AddToElementRepository("target", AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target);
							AddToElementRepository("LiteralUnlimitedNatural149", AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target_LiteralUnlimitedNatural149);
							AddToElementRepository("LiteralInteger150", AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target_LiteralInteger150);
					AddToElementRepository("a_Unconnected_Pattern", AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern);
					AddToElementRepository("a_Unconnected_Pattern_node", AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node);
					AddToElementRepository("ObjectFlow151", AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_ObjectFlow151);
						AddToElementRepository("LiteralBoolean152", AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_ObjectFlow151_LiteralBoolean152);
						AddToElementRepository("LiteralInteger153", AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_ObjectFlow151_LiteralInteger153);
				AddToElementRepository("A_Empty_Pattern", AssemblyConnectors_PWP_P_A_Empty_Pattern);
					AddToElementRepository("partB", AssemblyConnectors_PWP_P_A_Empty_Pattern_partB);
						AddToElementRepository("LiteralInteger154", AssemblyConnectors_PWP_P_A_Empty_Pattern_partB_LiteralInteger154);
						AddToElementRepository("LiteralUnlimitedNatural155", AssemblyConnectors_PWP_P_A_Empty_Pattern_partB_LiteralUnlimitedNatural155);
					AddToElementRepository("partC", AssemblyConnectors_PWP_P_A_Empty_Pattern_partC);
						AddToElementRepository("LiteralInteger156", AssemblyConnectors_PWP_P_A_Empty_Pattern_partC_LiteralInteger156);
						AddToElementRepository("LiteralUnlimitedNatural157", AssemblyConnectors_PWP_P_A_Empty_Pattern_partC_LiteralUnlimitedNatural157);
					AddToElementRepository("A_Empty_Pattern_A_Empty_Pattern", AssemblyConnectors_PWP_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern);
						AddToElementRepository("result", AssemblyConnectors_PWP_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result);
					AddToElementRepository("r", AssemblyConnectors_PWP_P_A_Empty_Pattern_r);
						AddToElementRepository("ConnectorEnd158", AssemblyConnectors_PWP_P_A_Empty_Pattern_r_ConnectorEnd158);
							AddToElementRepository("connectorEnd_2_Upper", AssemblyConnectors_PWP_P_A_Empty_Pattern_r_ConnectorEnd158_connectorEnd_2_Upper);
							AddToElementRepository("connectorEnd_2_Lower", AssemblyConnectors_PWP_P_A_Empty_Pattern_r_ConnectorEnd158_connectorEnd_2_Lower);
						AddToElementRepository("ConnectorEnd159", AssemblyConnectors_PWP_P_A_Empty_Pattern_r_ConnectorEnd159);
							AddToElementRepository("connectorEnd_1_Upper", AssemblyConnectors_PWP_P_A_Empty_Pattern_r_ConnectorEnd159_connectorEnd_1_Upper);
							AddToElementRepository("connectorEnd_1_Lower", AssemblyConnectors_PWP_P_A_Empty_Pattern_r_ConnectorEnd159_connectorEnd_1_Lower);
					AddToElementRepository("Comment160", AssemblyConnectors_PWP_P_A_Empty_Pattern_Comment160);
				AddToElementRepository("assert_A_Unconnected_Pattern", AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern);
					AddToElementRepository("ObjectFlow161", AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_ObjectFlow161);
						AddToElementRepository("LiteralInteger162", AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_ObjectFlow161_LiteralInteger162);
						AddToElementRepository("LiteralBoolean163", AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_ObjectFlow161_LiteralBoolean163);
					AddToElementRepository("writeLine", AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine);
						AddToElementRepository("errorStatus", AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine_errorStatus);
							AddToElementRepository("LiteralUnlimitedNatural164", AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural164);
							AddToElementRepository("LiteralInteger165", AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine_errorStatus_LiteralInteger165);
							AddToElementRepository("LiteralInteger166", AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine_errorStatus_LiteralInteger166);
						AddToElementRepository("value", AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine_value);
							AddToElementRepository("LiteralInteger167", AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine_value_LiteralInteger167);
							AddToElementRepository("LiteralInteger168", AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine_value_LiteralInteger168);
							AddToElementRepository("LiteralUnlimitedNatural169", AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine_value_LiteralUnlimitedNatural169);
					AddToElementRepository("a_Unconnected_Pattern", AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern);
					AddToElementRepository("a_Unconnected_Pattern_node", AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node);
						AddToElementRepository("LiteralInteger170", AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node_LiteralInteger170);
					AddToElementRepository("message", AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_message);
						AddToElementRepository("LiteralString171", AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_message_LiteralString171);
						AddToElementRepository("result", AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_message_result);
							AddToElementRepository("LiteralInteger172", AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_message_result_LiteralInteger172);
							AddToElementRepository("LiteralUnlimitedNatural173", AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_message_result_LiteralUnlimitedNatural173);
				AddToElementRepository("R", AssemblyConnectors_PWP_P_R);
					AddToElementRepository("y", AssemblyConnectors_PWP_P_R_y);
						AddToElementRepository("LiteralUnlimitedNatural174", AssemblyConnectors_PWP_P_R_y_LiteralUnlimitedNatural174);
						AddToElementRepository("LiteralInteger175", AssemblyConnectors_PWP_P_R_y_LiteralInteger175);
					AddToElementRepository("x", AssemblyConnectors_PWP_P_R_x);
						AddToElementRepository("LiteralInteger176", AssemblyConnectors_PWP_P_R_x_LiteralInteger176);
						AddToElementRepository("LiteralUnlimitedNatural177", AssemblyConnectors_PWP_P_R_x_LiteralUnlimitedNatural177);

			// Initialize public members
			/*
			 * Model AssemblyConnectors_PWP_P
			 */
			AssemblyConnectors_PWP_P.SetName("AssemblyConnectors_PWP_P");
			AssemblyConnectors_PWP_P.SetVisibility(VisibilityKind.public_);
				// Activity instantiate_A_Empty_Pattern
				AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern.SetName("instantiate_A_Empty_Pattern");
				AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Empty_Pattern
					AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetName("a_Empty_Pattern");
					AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetType(AssemblyConnectors_PWP_P_A_Empty_Pattern);
					AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetDirection(ParameterDirectionKind.return_);
				AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern.AddOwnedParameter(AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_a_Empty_Pattern);
					// CallOperationAction A_Empty_Pattern()
					AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_A_Empty_Pattern_.SetName("A_Empty_Pattern()");
					AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_A_Empty_Pattern_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result.SetName("result");
						AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result.SetType(AssemblyConnectors_PWP_P_A_Empty_Pattern);
					AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_A_Empty_Pattern_.AddResult(AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result);
					AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_A_Empty_Pattern_.SetOperation(AssemblyConnectors_PWP_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern);
						// InputPin target
						AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target.SetName("target");
						AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target.SetType(AssemblyConnectors_PWP_P_A_Empty_Pattern);
					AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_A_Empty_Pattern_.SetTarget(AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target);
				AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern.AddNode(AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_A_Empty_Pattern_);
					// ActivityParameterNode a_Empty_Pattern_node
					AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_a_Empty_Pattern_node.SetName("a_Empty_Pattern_node");
					AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_a_Empty_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_a_Empty_Pattern_node.SetParameter(AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_a_Empty_Pattern);
				AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern.AddNode(AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_a_Empty_Pattern_node);
					// CreateObjectAction Create A_Empty_Pattern
					AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern.SetName("Create A_Empty_Pattern");
					AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern.SetClassifier(AssemblyConnectors_PWP_P_A_Empty_Pattern);
						// OutputPin result
						AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result.SetName("result");
						AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result.SetType(AssemblyConnectors_PWP_P_A_Empty_Pattern);
					AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern.SetResult(AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result);
				AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern.AddNode(AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern);
					// ObjectFlow ObjectFlow5 from result to target
					AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_ObjectFlow5.SetName("ObjectFlow5");
					AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_ObjectFlow5.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_ObjectFlow5.SetSource(AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result);
					AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_ObjectFlow5.SetTarget(AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target);
						// LiteralBoolean LiteralBoolean6
						AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_ObjectFlow5_LiteralBoolean6.SetName("LiteralBoolean6");
						AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_ObjectFlow5_LiteralBoolean6.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_ObjectFlow5_LiteralBoolean6.SetValue(true);
					AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_ObjectFlow5.SetGuard(AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_ObjectFlow5_LiteralBoolean6);
				AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern.AddEdge(AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_ObjectFlow5);
					// ObjectFlow ObjectFlow8 from result to a_Empty_Pattern_node
					AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_ObjectFlow8.SetName("ObjectFlow8");
					AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_ObjectFlow8.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_ObjectFlow8.SetSource(AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result);
					AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_ObjectFlow8.SetTarget(AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_a_Empty_Pattern_node);
						// LiteralBoolean LiteralBoolean10
						AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_ObjectFlow8_LiteralBoolean10.SetName("LiteralBoolean10");
						AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_ObjectFlow8_LiteralBoolean10.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_ObjectFlow8_LiteralBoolean10.SetValue(true);
					AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_ObjectFlow8.SetGuard(AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_ObjectFlow8_LiteralBoolean10);
				AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern.AddEdge(AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern_ObjectFlow8);
			AssemblyConnectors_PWP_P.AddPackagedElement(AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern);
				// Activity assert_A_Star_Pattern
				AssemblyConnectors_PWP_P_assert_A_Star_Pattern.SetName("assert_A_Star_Pattern");
				AssemblyConnectors_PWP_P_assert_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Star_Pattern
					AssemblyConnectors_PWP_P_assert_A_Star_Pattern_a_Star_Pattern.SetName("a_Star_Pattern");
					AssemblyConnectors_PWP_P_assert_A_Star_Pattern_a_Star_Pattern.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_assert_A_Star_Pattern_a_Star_Pattern.SetType(AssemblyConnectors_PWP_P_A_Star_Pattern);
				AssemblyConnectors_PWP_P_assert_A_Star_Pattern.AddOwnedParameter(AssemblyConnectors_PWP_P_assert_A_Star_Pattern_a_Star_Pattern);
					// ActivityParameterNode a_Star_Pattern_node
					AssemblyConnectors_PWP_P_assert_A_Star_Pattern_a_Star_Pattern_node.SetName("a_Star_Pattern_node");
					AssemblyConnectors_PWP_P_assert_A_Star_Pattern_a_Star_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_assert_A_Star_Pattern_a_Star_Pattern_node.SetParameter(AssemblyConnectors_PWP_P_assert_A_Star_Pattern_a_Star_Pattern);
				AssemblyConnectors_PWP_P_assert_A_Star_Pattern.AddNode(AssemblyConnectors_PWP_P_assert_A_Star_Pattern_a_Star_Pattern_node);
					// ValueSpecificationAction message
					AssemblyConnectors_PWP_P_assert_A_Star_Pattern_message.SetName("message");
					AssemblyConnectors_PWP_P_assert_A_Star_Pattern_message.SetVisibility(VisibilityKind.public_);
						// LiteralString LiteralString17
						AssemblyConnectors_PWP_P_assert_A_Star_Pattern_message_LiteralString17.SetName("LiteralString17");
						AssemblyConnectors_PWP_P_assert_A_Star_Pattern_message_LiteralString17.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_assert_A_Star_Pattern_message_LiteralString17.SetValue("Assertion currently not implemented for A_Star_Pattern.");
					AssemblyConnectors_PWP_P_assert_A_Star_Pattern_message.SetValue(AssemblyConnectors_PWP_P_assert_A_Star_Pattern_message_LiteralString17);
						// OutputPin result
						AssemblyConnectors_PWP_P_assert_A_Star_Pattern_message_result.SetName("result");
						AssemblyConnectors_PWP_P_assert_A_Star_Pattern_message_result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_assert_A_Star_Pattern_message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					AssemblyConnectors_PWP_P_assert_A_Star_Pattern_message.SetResult(AssemblyConnectors_PWP_P_assert_A_Star_Pattern_message_result);
				AssemblyConnectors_PWP_P_assert_A_Star_Pattern.AddNode(AssemblyConnectors_PWP_P_assert_A_Star_Pattern_message);
					// CallBehaviorAction writeLine
					AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine.SetName("writeLine");
					AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine.SetVisibility(VisibilityKind.public_);
					
						// OutputPin errorStatus
						AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine_errorStatus.SetName("errorStatus");
						AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine_errorStatus.SetVisibility(VisibilityKind.public_);
						
						AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine_errorStatus.SetLower(0);
					AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine.AddResult(AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine_errorStatus);
					AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
						// InputPin value
						AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine_value.SetName("value");
						AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine_value.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine.AddArgument(AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine_value);
				AssemblyConnectors_PWP_P_assert_A_Star_Pattern.AddNode(AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine);
					// ObjectFlow ObjectFlow14 from result to value
					AssemblyConnectors_PWP_P_assert_A_Star_Pattern_ObjectFlow14.SetName("ObjectFlow14");
					AssemblyConnectors_PWP_P_assert_A_Star_Pattern_ObjectFlow14.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_assert_A_Star_Pattern_ObjectFlow14.SetSource(AssemblyConnectors_PWP_P_assert_A_Star_Pattern_message_result);
					AssemblyConnectors_PWP_P_assert_A_Star_Pattern_ObjectFlow14.SetTarget(AssemblyConnectors_PWP_P_assert_A_Star_Pattern_writeLine_value);
						// LiteralBoolean LiteralBoolean15
						AssemblyConnectors_PWP_P_assert_A_Star_Pattern_ObjectFlow14_LiteralBoolean15.SetName("LiteralBoolean15");
						AssemblyConnectors_PWP_P_assert_A_Star_Pattern_ObjectFlow14_LiteralBoolean15.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_assert_A_Star_Pattern_ObjectFlow14_LiteralBoolean15.SetValue(true);
					AssemblyConnectors_PWP_P_assert_A_Star_Pattern_ObjectFlow14.SetGuard(AssemblyConnectors_PWP_P_assert_A_Star_Pattern_ObjectFlow14_LiteralBoolean15);
				AssemblyConnectors_PWP_P_assert_A_Star_Pattern.AddEdge(AssemblyConnectors_PWP_P_assert_A_Star_Pattern_ObjectFlow14);
			AssemblyConnectors_PWP_P.AddPackagedElement(AssemblyConnectors_PWP_P_assert_A_Star_Pattern);
				// Class C
				AssemblyConnectors_PWP_P_C.SetName("C");
				AssemblyConnectors_PWP_P_C.SetVisibility(VisibilityKind.public_);
			AssemblyConnectors_PWP_P.AddPackagedElement(AssemblyConnectors_PWP_P_C);
				// Activity instantiate_A_Star_Pattern
				AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern.SetName("instantiate_A_Star_Pattern");
				AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Star_Pattern
					AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_a_Star_Pattern.SetName("a_Star_Pattern");
					AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_a_Star_Pattern.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_a_Star_Pattern.SetType(AssemblyConnectors_PWP_P_A_Star_Pattern);
					AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_a_Star_Pattern.SetDirection(ParameterDirectionKind.return_);
				AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern.AddOwnedParameter(AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_a_Star_Pattern);
					// ActivityParameterNode a_Star_Pattern_node
					AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_a_Star_Pattern_node.SetName("a_Star_Pattern_node");
					AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_a_Star_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_a_Star_Pattern_node.SetParameter(AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_a_Star_Pattern);
				AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern.AddNode(AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_a_Star_Pattern_node);
					// CreateObjectAction Create A_Star_Pattern
					AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern.SetName("Create A_Star_Pattern");
					AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern.SetClassifier(AssemblyConnectors_PWP_P_A_Star_Pattern);
						// OutputPin result
						AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result.SetName("result");
						AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result.SetType(AssemblyConnectors_PWP_P_A_Star_Pattern);
					AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern.SetResult(AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result);
				AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern.AddNode(AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern);
					// CallOperationAction A_Star_Pattern()
					AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_A_Star_Pattern_.SetName("A_Star_Pattern()");
					AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_A_Star_Pattern_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_A_Star_Pattern__result.SetName("result");
						AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_A_Star_Pattern__result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_A_Star_Pattern__result.SetType(AssemblyConnectors_PWP_P_A_Star_Pattern);
					AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_A_Star_Pattern_.AddResult(AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_A_Star_Pattern__result);
					AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_A_Star_Pattern_.SetOperation(AssemblyConnectors_PWP_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern);
						// InputPin target
						AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_A_Star_Pattern__target.SetName("target");
						AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_A_Star_Pattern__target.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_A_Star_Pattern__target.SetType(AssemblyConnectors_PWP_P_A_Star_Pattern);
					AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_A_Star_Pattern_.SetTarget(AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_A_Star_Pattern__target);
				AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern.AddNode(AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_A_Star_Pattern_);
					// ObjectFlow ObjectFlow33 from result to target
					AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_ObjectFlow33.SetName("ObjectFlow33");
					AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_ObjectFlow33.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_ObjectFlow33.SetSource(AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result);
					AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_ObjectFlow33.SetTarget(AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_A_Star_Pattern__target);
						// LiteralBoolean LiteralBoolean35
						AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_ObjectFlow33_LiteralBoolean35.SetName("LiteralBoolean35");
						AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_ObjectFlow33_LiteralBoolean35.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_ObjectFlow33_LiteralBoolean35.SetValue(true);
					AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_ObjectFlow33.SetGuard(AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_ObjectFlow33_LiteralBoolean35);
				AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern.AddEdge(AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_ObjectFlow33);
					// ObjectFlow ObjectFlow36 from result to a_Star_Pattern_node
					AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_ObjectFlow36.SetName("ObjectFlow36");
					AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_ObjectFlow36.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_ObjectFlow36.SetSource(AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_A_Star_Pattern__result);
					AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_ObjectFlow36.SetTarget(AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_a_Star_Pattern_node);
						// LiteralBoolean LiteralBoolean37
						AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_ObjectFlow36_LiteralBoolean37.SetName("LiteralBoolean37");
						AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_ObjectFlow36_LiteralBoolean37.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_ObjectFlow36_LiteralBoolean37.SetValue(true);
					AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_ObjectFlow36.SetGuard(AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_ObjectFlow36_LiteralBoolean37);
				AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern.AddEdge(AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern_ObjectFlow36);
			AssemblyConnectors_PWP_P.AddPackagedElement(AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern);
				// Class B
				AssemblyConnectors_PWP_P_B.SetName("B");
				AssemblyConnectors_PWP_P_B.SetVisibility(VisibilityKind.public_);
				
					// Port p
					AssemblyConnectors_PWP_P_B_p.SetName("p");
					AssemblyConnectors_PWP_P_B_p.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_P_B_p.SetUpper(-1);
					AssemblyConnectors_PWP_P_B_p.SetLower(2);
					AssemblyConnectors_PWP_P_B_p.SetType(AssemblyConnectors_PWP_P_IImpl);
					AssemblyConnectors_PWP_P_B_p.SetAggregation(AggregationKind.composite);
					AssemblyConnectors_PWP_P_B_p.isService = true;
					AssemblyConnectors_PWP_P_B_p.AddProvided(AssemblyConnectors_PWP_P_I);
				AssemblyConnectors_PWP_P_B.AddOwnedAttribute(AssemblyConnectors_PWP_P_B_p);
			AssemblyConnectors_PWP_P.AddPackagedElement(AssemblyConnectors_PWP_P_B);
				// Class A_Star_Pattern
				AssemblyConnectors_PWP_P_A_Star_Pattern.SetName("A_Star_Pattern");
				AssemblyConnectors_PWP_P_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Property partB
					AssemblyConnectors_PWP_P_A_Star_Pattern_partB.SetName("partB");
					AssemblyConnectors_PWP_P_A_Star_Pattern_partB.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_P_A_Star_Pattern_partB.SetUpper(-1);
					AssemblyConnectors_PWP_P_A_Star_Pattern_partB.SetLower(2);
					AssemblyConnectors_PWP_P_A_Star_Pattern_partB.SetType(AssemblyConnectors_PWP_P_B);
					AssemblyConnectors_PWP_P_A_Star_Pattern_partB.SetAggregation(AggregationKind.composite);
				AssemblyConnectors_PWP_P_A_Star_Pattern.AddOwnedAttribute(AssemblyConnectors_PWP_P_A_Star_Pattern_partB);
					// Property partC
					AssemblyConnectors_PWP_P_A_Star_Pattern_partC.SetName("partC");
					AssemblyConnectors_PWP_P_A_Star_Pattern_partC.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_P_A_Star_Pattern_partC.SetUpper(-1);
					AssemblyConnectors_PWP_P_A_Star_Pattern_partC.SetLower(5);
					AssemblyConnectors_PWP_P_A_Star_Pattern_partC.SetType(AssemblyConnectors_PWP_P_C);
					AssemblyConnectors_PWP_P_A_Star_Pattern_partC.SetAggregation(AggregationKind.composite);
				AssemblyConnectors_PWP_P_A_Star_Pattern.AddOwnedAttribute(AssemblyConnectors_PWP_P_A_Star_Pattern_partC);
				
				AssemblyConnectors_PWP_P_A_Star_Pattern_r.SetName("r");
					AssemblyConnectors_PWP_P_A_Star_Pattern_r.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_A_Star_Pattern_r_ConnectorEnd45.SetUpper(-1);
						AssemblyConnectors_PWP_P_A_Star_Pattern_r_ConnectorEnd45.SetLower(4);
						AssemblyConnectors_PWP_P_A_Star_Pattern_r_ConnectorEnd45.SetRole(AssemblyConnectors_PWP_P_B_p);
						AssemblyConnectors_PWP_P_A_Star_Pattern_r_ConnectorEnd45.SetPartWithPort(AssemblyConnectors_PWP_P_A_Star_Pattern_partB);
						
					AssemblyConnectors_PWP_P_A_Star_Pattern_r.AddEnd(AssemblyConnectors_PWP_P_A_Star_Pattern_r_ConnectorEnd45);
						AssemblyConnectors_PWP_P_A_Star_Pattern_r_ConnectorEnd44.SetUpper(-1);
						AssemblyConnectors_PWP_P_A_Star_Pattern_r_ConnectorEnd44.SetLower(5);
						AssemblyConnectors_PWP_P_A_Star_Pattern_r_ConnectorEnd44.SetRole(AssemblyConnectors_PWP_P_A_Star_Pattern_partC);
						
					AssemblyConnectors_PWP_P_A_Star_Pattern_r.AddEnd(AssemblyConnectors_PWP_P_A_Star_Pattern_r_ConnectorEnd44);
					AssemblyConnectors_PWP_P_A_Star_Pattern_r.SetType(AssemblyConnectors_PWP_P_R);
				AssemblyConnectors_PWP_P_A_Star_Pattern.AddOwnedConnector(AssemblyConnectors_PWP_P_A_Star_Pattern_r);
					// Operation A_Star_Pattern_A_Star_Pattern
					AssemblyConnectors_PWP_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern.SetName("A_Star_Pattern_A_Star_Pattern");
					AssemblyConnectors_PWP_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
						// Parameter result
						AssemblyConnectors_PWP_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result.SetName("result");
						AssemblyConnectors_PWP_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result.SetVisibility(VisibilityKind.public_);
						
						AssemblyConnectors_PWP_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result.SetType(AssemblyConnectors_PWP_P_A_Star_Pattern);
						AssemblyConnectors_PWP_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result.SetDirection(ParameterDirectionKind.return_);
					AssemblyConnectors_PWP_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern.AddOwnedParameter(AssemblyConnectors_PWP_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result);
					AssemblyConnectors_PWP_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				AssemblyConnectors_PWP_P_A_Star_Pattern.AddOwnedOperation(AssemblyConnectors_PWP_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern);
			AssemblyConnectors_PWP_P.AddPackagedElement(AssemblyConnectors_PWP_P_A_Star_Pattern);
				// Activity assert_A_Array_Pattern
				AssemblyConnectors_PWP_P_assert_A_Array_Pattern.SetName("assert_A_Array_Pattern");
				AssemblyConnectors_PWP_P_assert_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Array_Pattern
					AssemblyConnectors_PWP_P_assert_A_Array_Pattern_a_Array_Pattern.SetName("a_Array_Pattern");
					AssemblyConnectors_PWP_P_assert_A_Array_Pattern_a_Array_Pattern.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_assert_A_Array_Pattern_a_Array_Pattern.SetType(AssemblyConnectors_PWP_P_A_Array_Pattern);
				AssemblyConnectors_PWP_P_assert_A_Array_Pattern.AddOwnedParameter(AssemblyConnectors_PWP_P_assert_A_Array_Pattern_a_Array_Pattern);
					// ValueSpecificationAction message
					AssemblyConnectors_PWP_P_assert_A_Array_Pattern_message.SetName("message");
					AssemblyConnectors_PWP_P_assert_A_Array_Pattern_message.SetVisibility(VisibilityKind.public_);
						// LiteralString LiteralString50
						AssemblyConnectors_PWP_P_assert_A_Array_Pattern_message_LiteralString50.SetName("LiteralString50");
						AssemblyConnectors_PWP_P_assert_A_Array_Pattern_message_LiteralString50.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_assert_A_Array_Pattern_message_LiteralString50.SetValue("Assertion currently not implemented for A_Array_Pattern.");
					AssemblyConnectors_PWP_P_assert_A_Array_Pattern_message.SetValue(AssemblyConnectors_PWP_P_assert_A_Array_Pattern_message_LiteralString50);
						// OutputPin result
						AssemblyConnectors_PWP_P_assert_A_Array_Pattern_message_result.SetName("result");
						AssemblyConnectors_PWP_P_assert_A_Array_Pattern_message_result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_assert_A_Array_Pattern_message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					AssemblyConnectors_PWP_P_assert_A_Array_Pattern_message.SetResult(AssemblyConnectors_PWP_P_assert_A_Array_Pattern_message_result);
				AssemblyConnectors_PWP_P_assert_A_Array_Pattern.AddNode(AssemblyConnectors_PWP_P_assert_A_Array_Pattern_message);
					// CallBehaviorAction writeLine
					AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine.SetName("writeLine");
					AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine.SetVisibility(VisibilityKind.public_);
					
						// OutputPin errorStatus
						AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine_errorStatus.SetName("errorStatus");
						AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine_errorStatus.SetVisibility(VisibilityKind.public_);
						
						AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine_errorStatus.SetLower(0);
					AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine.AddResult(AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine_errorStatus);
					AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
						// InputPin value
						AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine_value.SetName("value");
						AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine_value.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine.AddArgument(AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine_value);
				AssemblyConnectors_PWP_P_assert_A_Array_Pattern.AddNode(AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine);
					// ActivityParameterNode a_Array_Pattern_node
					AssemblyConnectors_PWP_P_assert_A_Array_Pattern_a_Array_Pattern_node.SetName("a_Array_Pattern_node");
					AssemblyConnectors_PWP_P_assert_A_Array_Pattern_a_Array_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_assert_A_Array_Pattern_a_Array_Pattern_node.SetParameter(AssemblyConnectors_PWP_P_assert_A_Array_Pattern_a_Array_Pattern);
				AssemblyConnectors_PWP_P_assert_A_Array_Pattern.AddNode(AssemblyConnectors_PWP_P_assert_A_Array_Pattern_a_Array_Pattern_node);
					// ObjectFlow ObjectFlow58 from result to value
					AssemblyConnectors_PWP_P_assert_A_Array_Pattern_ObjectFlow58.SetName("ObjectFlow58");
					AssemblyConnectors_PWP_P_assert_A_Array_Pattern_ObjectFlow58.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_assert_A_Array_Pattern_ObjectFlow58.SetSource(AssemblyConnectors_PWP_P_assert_A_Array_Pattern_message_result);
					AssemblyConnectors_PWP_P_assert_A_Array_Pattern_ObjectFlow58.SetTarget(AssemblyConnectors_PWP_P_assert_A_Array_Pattern_writeLine_value);
						// LiteralBoolean LiteralBoolean60
						AssemblyConnectors_PWP_P_assert_A_Array_Pattern_ObjectFlow58_LiteralBoolean60.SetName("LiteralBoolean60");
						AssemblyConnectors_PWP_P_assert_A_Array_Pattern_ObjectFlow58_LiteralBoolean60.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_assert_A_Array_Pattern_ObjectFlow58_LiteralBoolean60.SetValue(true);
					AssemblyConnectors_PWP_P_assert_A_Array_Pattern_ObjectFlow58.SetGuard(AssemblyConnectors_PWP_P_assert_A_Array_Pattern_ObjectFlow58_LiteralBoolean60);
				AssemblyConnectors_PWP_P_assert_A_Array_Pattern.AddEdge(AssemblyConnectors_PWP_P_assert_A_Array_Pattern_ObjectFlow58);
			AssemblyConnectors_PWP_P.AddPackagedElement(AssemblyConnectors_PWP_P_assert_A_Array_Pattern);
				// Activity instantiate_A_Array_Pattern
				AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern.SetName("instantiate_A_Array_Pattern");
				AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Array_Pattern
					AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_a_Array_Pattern.SetName("a_Array_Pattern");
					AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_a_Array_Pattern.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_a_Array_Pattern.SetType(AssemblyConnectors_PWP_P_A_Array_Pattern);
					AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_a_Array_Pattern.SetDirection(ParameterDirectionKind.return_);
				AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern.AddOwnedParameter(AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_a_Array_Pattern);
					// ActivityParameterNode a_Array_Pattern_node
					AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_a_Array_Pattern_node.SetName("a_Array_Pattern_node");
					AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_a_Array_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_a_Array_Pattern_node.SetParameter(AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_a_Array_Pattern);
				AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern.AddNode(AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_a_Array_Pattern_node);
					// CallOperationAction A_Array_Pattern()
					AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_A_Array_Pattern_.SetName("A_Array_Pattern()");
					AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_A_Array_Pattern_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_A_Array_Pattern__result.SetName("result");
						AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_A_Array_Pattern__result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_A_Array_Pattern__result.SetType(AssemblyConnectors_PWP_P_A_Array_Pattern);
					AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_A_Array_Pattern_.AddResult(AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_A_Array_Pattern__result);
					AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_A_Array_Pattern_.SetOperation(AssemblyConnectors_PWP_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern);
						// InputPin target
						AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_A_Array_Pattern__target.SetName("target");
						AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_A_Array_Pattern__target.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_A_Array_Pattern__target.SetType(AssemblyConnectors_PWP_P_A_Array_Pattern);
					AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_A_Array_Pattern_.SetTarget(AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_A_Array_Pattern__target);
				AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern.AddNode(AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_A_Array_Pattern_);
					// CreateObjectAction Create A_Array_Pattern
					AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern.SetName("Create A_Array_Pattern");
					AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern.SetClassifier(AssemblyConnectors_PWP_P_A_Array_Pattern);
						// OutputPin result
						AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result.SetName("result");
						AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result.SetType(AssemblyConnectors_PWP_P_A_Array_Pattern);
					AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern.SetResult(AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result);
				AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern.AddNode(AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern);
					// ObjectFlow ObjectFlow69 from result to a_Array_Pattern_node
					AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_ObjectFlow69.SetName("ObjectFlow69");
					AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_ObjectFlow69.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_ObjectFlow69.SetSource(AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_A_Array_Pattern__result);
					AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_ObjectFlow69.SetTarget(AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_a_Array_Pattern_node);
						// LiteralBoolean LiteralBoolean71
						AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_ObjectFlow69_LiteralBoolean71.SetName("LiteralBoolean71");
						AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_ObjectFlow69_LiteralBoolean71.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_ObjectFlow69_LiteralBoolean71.SetValue(true);
					AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_ObjectFlow69.SetGuard(AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_ObjectFlow69_LiteralBoolean71);
				AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern.AddEdge(AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_ObjectFlow69);
					// ObjectFlow ObjectFlow72 from result to target
					AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_ObjectFlow72.SetName("ObjectFlow72");
					AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_ObjectFlow72.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_ObjectFlow72.SetSource(AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result);
					AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_ObjectFlow72.SetTarget(AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_A_Array_Pattern__target);
						// LiteralBoolean LiteralBoolean73
						AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_ObjectFlow72_LiteralBoolean73.SetName("LiteralBoolean73");
						AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_ObjectFlow72_LiteralBoolean73.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_ObjectFlow72_LiteralBoolean73.SetValue(true);
					AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_ObjectFlow72.SetGuard(AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_ObjectFlow72_LiteralBoolean73);
				AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern.AddEdge(AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern_ObjectFlow72);
			AssemblyConnectors_PWP_P.AddPackagedElement(AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern);
				// Interface I
				AssemblyConnectors_PWP_P_I.SetName("I");
				AssemblyConnectors_PWP_P_I.SetVisibility(VisibilityKind.public_);
			AssemblyConnectors_PWP_P.AddPackagedElement(AssemblyConnectors_PWP_P_I);
				// Class A_Unconnected_Pattern
				AssemblyConnectors_PWP_P_A_Unconnected_Pattern.SetName("A_Unconnected_Pattern");
				AssemblyConnectors_PWP_P_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Property partB
					AssemblyConnectors_PWP_P_A_Unconnected_Pattern_partB.SetName("partB");
					AssemblyConnectors_PWP_P_A_Unconnected_Pattern_partB.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_P_A_Unconnected_Pattern_partB.SetUpper(-1);
					AssemblyConnectors_PWP_P_A_Unconnected_Pattern_partB.SetLower(2);
					AssemblyConnectors_PWP_P_A_Unconnected_Pattern_partB.SetType(AssemblyConnectors_PWP_P_B);
					AssemblyConnectors_PWP_P_A_Unconnected_Pattern_partB.SetAggregation(AggregationKind.composite);
				AssemblyConnectors_PWP_P_A_Unconnected_Pattern.AddOwnedAttribute(AssemblyConnectors_PWP_P_A_Unconnected_Pattern_partB);
					// Property partC
					AssemblyConnectors_PWP_P_A_Unconnected_Pattern_partC.SetName("partC");
					AssemblyConnectors_PWP_P_A_Unconnected_Pattern_partC.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_P_A_Unconnected_Pattern_partC.SetUpper(-1);
					AssemblyConnectors_PWP_P_A_Unconnected_Pattern_partC.SetLower(3);
					AssemblyConnectors_PWP_P_A_Unconnected_Pattern_partC.SetType(AssemblyConnectors_PWP_P_C);
					AssemblyConnectors_PWP_P_A_Unconnected_Pattern_partC.SetAggregation(AggregationKind.composite);
				AssemblyConnectors_PWP_P_A_Unconnected_Pattern.AddOwnedAttribute(AssemblyConnectors_PWP_P_A_Unconnected_Pattern_partC);
				
				AssemblyConnectors_PWP_P_A_Unconnected_Pattern_r.SetName("r");
					AssemblyConnectors_PWP_P_A_Unconnected_Pattern_r.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_A_Unconnected_Pattern_r_ConnectorEnd81.SetUpper(-1);
						AssemblyConnectors_PWP_P_A_Unconnected_Pattern_r_ConnectorEnd81.SetLower(0);
						AssemblyConnectors_PWP_P_A_Unconnected_Pattern_r_ConnectorEnd81.SetRole(AssemblyConnectors_PWP_P_B_p);
						AssemblyConnectors_PWP_P_A_Unconnected_Pattern_r_ConnectorEnd81.SetPartWithPort(AssemblyConnectors_PWP_P_A_Unconnected_Pattern_partB);
						
					AssemblyConnectors_PWP_P_A_Unconnected_Pattern_r.AddEnd(AssemblyConnectors_PWP_P_A_Unconnected_Pattern_r_ConnectorEnd81);
						AssemblyConnectors_PWP_P_A_Unconnected_Pattern_r_ConnectorEnd80.SetUpper(-1);
						AssemblyConnectors_PWP_P_A_Unconnected_Pattern_r_ConnectorEnd80.SetLower(0);
						AssemblyConnectors_PWP_P_A_Unconnected_Pattern_r_ConnectorEnd80.SetRole(AssemblyConnectors_PWP_P_A_Unconnected_Pattern_partC);
						
					AssemblyConnectors_PWP_P_A_Unconnected_Pattern_r.AddEnd(AssemblyConnectors_PWP_P_A_Unconnected_Pattern_r_ConnectorEnd80);
					AssemblyConnectors_PWP_P_A_Unconnected_Pattern_r.SetType(AssemblyConnectors_PWP_P_R);
				AssemblyConnectors_PWP_P_A_Unconnected_Pattern.AddOwnedConnector(AssemblyConnectors_PWP_P_A_Unconnected_Pattern_r);
					// Operation A_Unconnected_Pattern_A_Unconnected_Pattern
					AssemblyConnectors_PWP_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern.SetName("A_Unconnected_Pattern_A_Unconnected_Pattern");
					AssemblyConnectors_PWP_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
						// Parameter result
						AssemblyConnectors_PWP_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result.SetName("result");
						AssemblyConnectors_PWP_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result.SetVisibility(VisibilityKind.public_);
						
						AssemblyConnectors_PWP_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result.SetType(AssemblyConnectors_PWP_P_A_Unconnected_Pattern);
						AssemblyConnectors_PWP_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result.SetDirection(ParameterDirectionKind.return_);
					AssemblyConnectors_PWP_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern.AddOwnedParameter(AssemblyConnectors_PWP_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result);
					AssemblyConnectors_PWP_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				AssemblyConnectors_PWP_P_A_Unconnected_Pattern.AddOwnedOperation(AssemblyConnectors_PWP_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern);
			AssemblyConnectors_PWP_P.AddPackagedElement(AssemblyConnectors_PWP_P_A_Unconnected_Pattern);
				// Class A_Array_Pattern
				AssemblyConnectors_PWP_P_A_Array_Pattern.SetName("A_Array_Pattern");
				AssemblyConnectors_PWP_P_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Property partB
					AssemblyConnectors_PWP_P_A_Array_Pattern_partB.SetName("partB");
					AssemblyConnectors_PWP_P_A_Array_Pattern_partB.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_P_A_Array_Pattern_partB.SetUpper(-1);
					AssemblyConnectors_PWP_P_A_Array_Pattern_partB.SetLower(2);
					AssemblyConnectors_PWP_P_A_Array_Pattern_partB.SetType(AssemblyConnectors_PWP_P_B);
					AssemblyConnectors_PWP_P_A_Array_Pattern_partB.SetAggregation(AggregationKind.composite);
				AssemblyConnectors_PWP_P_A_Array_Pattern.AddOwnedAttribute(AssemblyConnectors_PWP_P_A_Array_Pattern_partB);
					// Property partC
					AssemblyConnectors_PWP_P_A_Array_Pattern_partC.SetName("partC");
					AssemblyConnectors_PWP_P_A_Array_Pattern_partC.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_P_A_Array_Pattern_partC.SetUpper(-1);
					AssemblyConnectors_PWP_P_A_Array_Pattern_partC.SetLower(4);
					AssemblyConnectors_PWP_P_A_Array_Pattern_partC.SetType(AssemblyConnectors_PWP_P_C);
					AssemblyConnectors_PWP_P_A_Array_Pattern_partC.SetAggregation(AggregationKind.composite);
				AssemblyConnectors_PWP_P_A_Array_Pattern.AddOwnedAttribute(AssemblyConnectors_PWP_P_A_Array_Pattern_partC);
				
				AssemblyConnectors_PWP_P_A_Array_Pattern_r.SetName("r");
					AssemblyConnectors_PWP_P_A_Array_Pattern_r.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_A_Array_Pattern_r_ConnectorEnd87.SetUpper(-1);
						AssemblyConnectors_PWP_P_A_Array_Pattern_r_ConnectorEnd87.SetRole(AssemblyConnectors_PWP_P_B_p);
						AssemblyConnectors_PWP_P_A_Array_Pattern_r_ConnectorEnd87.SetPartWithPort(AssemblyConnectors_PWP_P_A_Array_Pattern_partB);
						
					AssemblyConnectors_PWP_P_A_Array_Pattern_r.AddEnd(AssemblyConnectors_PWP_P_A_Array_Pattern_r_ConnectorEnd87);
						AssemblyConnectors_PWP_P_A_Array_Pattern_r_ConnectorEnd88.SetUpper(-1);
						AssemblyConnectors_PWP_P_A_Array_Pattern_r_ConnectorEnd88.SetRole(AssemblyConnectors_PWP_P_A_Array_Pattern_partC);
						
					AssemblyConnectors_PWP_P_A_Array_Pattern_r.AddEnd(AssemblyConnectors_PWP_P_A_Array_Pattern_r_ConnectorEnd88);
					AssemblyConnectors_PWP_P_A_Array_Pattern_r.SetType(AssemblyConnectors_PWP_P_R);
				AssemblyConnectors_PWP_P_A_Array_Pattern.AddOwnedConnector(AssemblyConnectors_PWP_P_A_Array_Pattern_r);
					// Operation A_Array_Pattern_A_Array_Pattern
					AssemblyConnectors_PWP_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern.SetName("A_Array_Pattern_A_Array_Pattern");
					AssemblyConnectors_PWP_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
						// Parameter result
						AssemblyConnectors_PWP_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result.SetName("result");
						AssemblyConnectors_PWP_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result.SetVisibility(VisibilityKind.public_);
						
						AssemblyConnectors_PWP_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result.SetType(AssemblyConnectors_PWP_P_A_Array_Pattern);
						AssemblyConnectors_PWP_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result.SetDirection(ParameterDirectionKind.return_);
					AssemblyConnectors_PWP_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern.AddOwnedParameter(AssemblyConnectors_PWP_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result);
					AssemblyConnectors_PWP_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				AssemblyConnectors_PWP_P_A_Array_Pattern.AddOwnedOperation(AssemblyConnectors_PWP_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern);
			AssemblyConnectors_PWP_P.AddPackagedElement(AssemblyConnectors_PWP_P_A_Array_Pattern);
				// Activity main
				AssemblyConnectors_PWP_P_main.SetName("main");
				AssemblyConnectors_PWP_P_main.SetVisibility(VisibilityKind.public_);
					// CallBehaviorAction instantiate_A_Unconnected_Pattern
					AssemblyConnectors_PWP_P_main_instantiate_A_Unconnected_Pattern.SetName("instantiate_A_Unconnected_Pattern");
					AssemblyConnectors_PWP_P_main_instantiate_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
					
						// OutputPin a_Unconnected_Pattern
						AssemblyConnectors_PWP_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetName("a_Unconnected_Pattern");
						AssemblyConnectors_PWP_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetType(AssemblyConnectors_PWP_P_A_Unconnected_Pattern);
					AssemblyConnectors_PWP_P_main_instantiate_A_Unconnected_Pattern.AddResult(AssemblyConnectors_PWP_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern);
					AssemblyConnectors_PWP_P_main_instantiate_A_Unconnected_Pattern.SetBehavior(AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern);
				AssemblyConnectors_PWP_P_main.AddNode(AssemblyConnectors_PWP_P_main_instantiate_A_Unconnected_Pattern);
					// CallBehaviorAction instantiate_A_Star_Pattern
					AssemblyConnectors_PWP_P_main_instantiate_A_Star_Pattern.SetName("instantiate_A_Star_Pattern");
					AssemblyConnectors_PWP_P_main_instantiate_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
					
						// OutputPin a_Star_Pattern
						AssemblyConnectors_PWP_P_main_instantiate_A_Star_Pattern_a_Star_Pattern.SetName("a_Star_Pattern");
						AssemblyConnectors_PWP_P_main_instantiate_A_Star_Pattern_a_Star_Pattern.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_main_instantiate_A_Star_Pattern_a_Star_Pattern.SetType(AssemblyConnectors_PWP_P_A_Star_Pattern);
					AssemblyConnectors_PWP_P_main_instantiate_A_Star_Pattern.AddResult(AssemblyConnectors_PWP_P_main_instantiate_A_Star_Pattern_a_Star_Pattern);
					AssemblyConnectors_PWP_P_main_instantiate_A_Star_Pattern.SetBehavior(AssemblyConnectors_PWP_P_instantiate_A_Star_Pattern);
				AssemblyConnectors_PWP_P_main.AddNode(AssemblyConnectors_PWP_P_main_instantiate_A_Star_Pattern);
					// CallBehaviorAction assert_A_Star_Pattern
					AssemblyConnectors_PWP_P_main_assert_A_Star_Pattern.SetName("assert_A_Star_Pattern");
					AssemblyConnectors_PWP_P_main_assert_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_P_main_assert_A_Star_Pattern.SetBehavior(AssemblyConnectors_PWP_P_assert_A_Star_Pattern);
						// InputPin a_Star_Pattern
						AssemblyConnectors_PWP_P_main_assert_A_Star_Pattern_a_Star_Pattern.SetName("a_Star_Pattern");
						AssemblyConnectors_PWP_P_main_assert_A_Star_Pattern_a_Star_Pattern.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_main_assert_A_Star_Pattern_a_Star_Pattern.SetType(AssemblyConnectors_PWP_P_A_Star_Pattern);
					AssemblyConnectors_PWP_P_main_assert_A_Star_Pattern.AddArgument(AssemblyConnectors_PWP_P_main_assert_A_Star_Pattern_a_Star_Pattern);
				AssemblyConnectors_PWP_P_main.AddNode(AssemblyConnectors_PWP_P_main_assert_A_Star_Pattern);
					// CallBehaviorAction assert_A_Array_Pattern
					AssemblyConnectors_PWP_P_main_assert_A_Array_Pattern.SetName("assert_A_Array_Pattern");
					AssemblyConnectors_PWP_P_main_assert_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_P_main_assert_A_Array_Pattern.SetBehavior(AssemblyConnectors_PWP_P_assert_A_Array_Pattern);
						// InputPin a_Array_Pattern
						AssemblyConnectors_PWP_P_main_assert_A_Array_Pattern_a_Array_Pattern.SetName("a_Array_Pattern");
						AssemblyConnectors_PWP_P_main_assert_A_Array_Pattern_a_Array_Pattern.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_main_assert_A_Array_Pattern_a_Array_Pattern.SetType(AssemblyConnectors_PWP_P_A_Array_Pattern);
					AssemblyConnectors_PWP_P_main_assert_A_Array_Pattern.AddArgument(AssemblyConnectors_PWP_P_main_assert_A_Array_Pattern_a_Array_Pattern);
				AssemblyConnectors_PWP_P_main.AddNode(AssemblyConnectors_PWP_P_main_assert_A_Array_Pattern);
					// CallBehaviorAction instantiate_A_Empty_Pattern
					AssemblyConnectors_PWP_P_main_instantiate_A_Empty_Pattern.SetName("instantiate_A_Empty_Pattern");
					AssemblyConnectors_PWP_P_main_instantiate_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
					
						// OutputPin a_Empty_Pattern
						AssemblyConnectors_PWP_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetName("a_Empty_Pattern");
						AssemblyConnectors_PWP_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetType(AssemblyConnectors_PWP_P_A_Empty_Pattern);
					AssemblyConnectors_PWP_P_main_instantiate_A_Empty_Pattern.AddResult(AssemblyConnectors_PWP_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern);
					AssemblyConnectors_PWP_P_main_instantiate_A_Empty_Pattern.SetBehavior(AssemblyConnectors_PWP_P_instantiate_A_Empty_Pattern);
				AssemblyConnectors_PWP_P_main.AddNode(AssemblyConnectors_PWP_P_main_instantiate_A_Empty_Pattern);
					// CallBehaviorAction assert_A_Unconnected_Pattern
					AssemblyConnectors_PWP_P_main_assert_A_Unconnected_Pattern.SetName("assert_A_Unconnected_Pattern");
					AssemblyConnectors_PWP_P_main_assert_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_P_main_assert_A_Unconnected_Pattern.SetBehavior(AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern);
						// InputPin a_Unconnected_Pattern
						AssemblyConnectors_PWP_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern.SetName("a_Unconnected_Pattern");
						AssemblyConnectors_PWP_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern.SetType(AssemblyConnectors_PWP_P_A_Unconnected_Pattern);
					AssemblyConnectors_PWP_P_main_assert_A_Unconnected_Pattern.AddArgument(AssemblyConnectors_PWP_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern);
				AssemblyConnectors_PWP_P_main.AddNode(AssemblyConnectors_PWP_P_main_assert_A_Unconnected_Pattern);
					// CallBehaviorAction instantiate_A_Array_Pattern
					AssemblyConnectors_PWP_P_main_instantiate_A_Array_Pattern.SetName("instantiate_A_Array_Pattern");
					AssemblyConnectors_PWP_P_main_instantiate_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
					
						// OutputPin a_Array_Pattern
						AssemblyConnectors_PWP_P_main_instantiate_A_Array_Pattern_a_Array_Pattern.SetName("a_Array_Pattern");
						AssemblyConnectors_PWP_P_main_instantiate_A_Array_Pattern_a_Array_Pattern.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_main_instantiate_A_Array_Pattern_a_Array_Pattern.SetType(AssemblyConnectors_PWP_P_A_Array_Pattern);
					AssemblyConnectors_PWP_P_main_instantiate_A_Array_Pattern.AddResult(AssemblyConnectors_PWP_P_main_instantiate_A_Array_Pattern_a_Array_Pattern);
					AssemblyConnectors_PWP_P_main_instantiate_A_Array_Pattern.SetBehavior(AssemblyConnectors_PWP_P_instantiate_A_Array_Pattern);
				AssemblyConnectors_PWP_P_main.AddNode(AssemblyConnectors_PWP_P_main_instantiate_A_Array_Pattern);
					// CallBehaviorAction assert_A_Empty_Pattern
					AssemblyConnectors_PWP_P_main_assert_A_Empty_Pattern.SetName("assert_A_Empty_Pattern");
					AssemblyConnectors_PWP_P_main_assert_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_P_main_assert_A_Empty_Pattern.SetBehavior(AssemblyConnectors_PWP_P_assert_A_Empty_Pattern);
						// InputPin a_Empty_Pattern
						AssemblyConnectors_PWP_P_main_assert_A_Empty_Pattern_a_Empty_Pattern.SetName("a_Empty_Pattern");
						AssemblyConnectors_PWP_P_main_assert_A_Empty_Pattern_a_Empty_Pattern.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_main_assert_A_Empty_Pattern_a_Empty_Pattern.SetType(AssemblyConnectors_PWP_P_A_Empty_Pattern);
					AssemblyConnectors_PWP_P_main_assert_A_Empty_Pattern.AddArgument(AssemblyConnectors_PWP_P_main_assert_A_Empty_Pattern_a_Empty_Pattern);
				AssemblyConnectors_PWP_P_main.AddNode(AssemblyConnectors_PWP_P_main_assert_A_Empty_Pattern);
					// ObjectFlow ObjectFlow89 from a_Star_Pattern to a_Star_Pattern
					AssemblyConnectors_PWP_P_main_ObjectFlow89.SetName("ObjectFlow89");
					AssemblyConnectors_PWP_P_main_ObjectFlow89.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_main_ObjectFlow89.SetSource(AssemblyConnectors_PWP_P_main_instantiate_A_Star_Pattern_a_Star_Pattern);
					AssemblyConnectors_PWP_P_main_ObjectFlow89.SetTarget(AssemblyConnectors_PWP_P_main_assert_A_Star_Pattern_a_Star_Pattern);
						// LiteralBoolean LiteralBoolean90
						AssemblyConnectors_PWP_P_main_ObjectFlow89_LiteralBoolean90.SetName("LiteralBoolean90");
						AssemblyConnectors_PWP_P_main_ObjectFlow89_LiteralBoolean90.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_main_ObjectFlow89_LiteralBoolean90.SetValue(true);
					AssemblyConnectors_PWP_P_main_ObjectFlow89.SetGuard(AssemblyConnectors_PWP_P_main_ObjectFlow89_LiteralBoolean90);
				AssemblyConnectors_PWP_P_main.AddEdge(AssemblyConnectors_PWP_P_main_ObjectFlow89);
					// ControlFlow ControlFlow92 from assert_A_Empty_Pattern to instantiate_A_Unconnected_Pattern
					AssemblyConnectors_PWP_P_main_ControlFlow92.SetName("ControlFlow92");
					AssemblyConnectors_PWP_P_main_ControlFlow92.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_main_ControlFlow92.SetSource(AssemblyConnectors_PWP_P_main_assert_A_Empty_Pattern);
					AssemblyConnectors_PWP_P_main_ControlFlow92.SetTarget(AssemblyConnectors_PWP_P_main_instantiate_A_Unconnected_Pattern);
				AssemblyConnectors_PWP_P_main.AddEdge(AssemblyConnectors_PWP_P_main_ControlFlow92);
					// ControlFlow ControlFlow111 from assert_A_Unconnected_Pattern to instantiate_A_Array_Pattern
					AssemblyConnectors_PWP_P_main_ControlFlow111.SetName("ControlFlow111");
					AssemblyConnectors_PWP_P_main_ControlFlow111.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_main_ControlFlow111.SetSource(AssemblyConnectors_PWP_P_main_assert_A_Unconnected_Pattern);
					AssemblyConnectors_PWP_P_main_ControlFlow111.SetTarget(AssemblyConnectors_PWP_P_main_instantiate_A_Array_Pattern);
				AssemblyConnectors_PWP_P_main.AddEdge(AssemblyConnectors_PWP_P_main_ControlFlow111);
					// ControlFlow ControlFlow115 from assert_A_Array_Pattern to instantiate_A_Star_Pattern
					AssemblyConnectors_PWP_P_main_ControlFlow115.SetName("ControlFlow115");
					AssemblyConnectors_PWP_P_main_ControlFlow115.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_main_ControlFlow115.SetSource(AssemblyConnectors_PWP_P_main_assert_A_Array_Pattern);
					AssemblyConnectors_PWP_P_main_ControlFlow115.SetTarget(AssemblyConnectors_PWP_P_main_instantiate_A_Star_Pattern);
				AssemblyConnectors_PWP_P_main.AddEdge(AssemblyConnectors_PWP_P_main_ControlFlow115);
					// ObjectFlow ObjectFlow96 from a_Empty_Pattern to a_Empty_Pattern
					AssemblyConnectors_PWP_P_main_ObjectFlow96.SetName("ObjectFlow96");
					AssemblyConnectors_PWP_P_main_ObjectFlow96.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_main_ObjectFlow96.SetSource(AssemblyConnectors_PWP_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern);
					AssemblyConnectors_PWP_P_main_ObjectFlow96.SetTarget(AssemblyConnectors_PWP_P_main_assert_A_Empty_Pattern_a_Empty_Pattern);
						// LiteralBoolean LiteralBoolean97
						AssemblyConnectors_PWP_P_main_ObjectFlow96_LiteralBoolean97.SetName("LiteralBoolean97");
						AssemblyConnectors_PWP_P_main_ObjectFlow96_LiteralBoolean97.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_main_ObjectFlow96_LiteralBoolean97.SetValue(true);
					AssemblyConnectors_PWP_P_main_ObjectFlow96.SetGuard(AssemblyConnectors_PWP_P_main_ObjectFlow96_LiteralBoolean97);
				AssemblyConnectors_PWP_P_main.AddEdge(AssemblyConnectors_PWP_P_main_ObjectFlow96);
					// ObjectFlow ObjectFlow99 from a_Unconnected_Pattern to a_Unconnected_Pattern
					AssemblyConnectors_PWP_P_main_ObjectFlow99.SetName("ObjectFlow99");
					AssemblyConnectors_PWP_P_main_ObjectFlow99.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_main_ObjectFlow99.SetSource(AssemblyConnectors_PWP_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern);
					AssemblyConnectors_PWP_P_main_ObjectFlow99.SetTarget(AssemblyConnectors_PWP_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern);
						// LiteralBoolean LiteralBoolean101
						AssemblyConnectors_PWP_P_main_ObjectFlow99_LiteralBoolean101.SetName("LiteralBoolean101");
						AssemblyConnectors_PWP_P_main_ObjectFlow99_LiteralBoolean101.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_main_ObjectFlow99_LiteralBoolean101.SetValue(true);
					AssemblyConnectors_PWP_P_main_ObjectFlow99.SetGuard(AssemblyConnectors_PWP_P_main_ObjectFlow99_LiteralBoolean101);
				AssemblyConnectors_PWP_P_main.AddEdge(AssemblyConnectors_PWP_P_main_ObjectFlow99);
					// ObjectFlow ObjectFlow122 from a_Array_Pattern to a_Array_Pattern
					AssemblyConnectors_PWP_P_main_ObjectFlow122.SetName("ObjectFlow122");
					AssemblyConnectors_PWP_P_main_ObjectFlow122.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_main_ObjectFlow122.SetSource(AssemblyConnectors_PWP_P_main_instantiate_A_Array_Pattern_a_Array_Pattern);
					AssemblyConnectors_PWP_P_main_ObjectFlow122.SetTarget(AssemblyConnectors_PWP_P_main_assert_A_Array_Pattern_a_Array_Pattern);
						// LiteralBoolean LiteralBoolean124
						AssemblyConnectors_PWP_P_main_ObjectFlow122_LiteralBoolean124.SetName("LiteralBoolean124");
						AssemblyConnectors_PWP_P_main_ObjectFlow122_LiteralBoolean124.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_main_ObjectFlow122_LiteralBoolean124.SetValue(true);
					AssemblyConnectors_PWP_P_main_ObjectFlow122.SetGuard(AssemblyConnectors_PWP_P_main_ObjectFlow122_LiteralBoolean124);
				AssemblyConnectors_PWP_P_main.AddEdge(AssemblyConnectors_PWP_P_main_ObjectFlow122);
			AssemblyConnectors_PWP_P.AddPackagedElement(AssemblyConnectors_PWP_P_main);
				// Activity assert_A_Empty_Pattern
				AssemblyConnectors_PWP_P_assert_A_Empty_Pattern.SetName("assert_A_Empty_Pattern");
				AssemblyConnectors_PWP_P_assert_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Empty_Pattern
					AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_a_Empty_Pattern.SetName("a_Empty_Pattern");
					AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_a_Empty_Pattern.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_a_Empty_Pattern.SetType(AssemblyConnectors_PWP_P_A_Empty_Pattern);
				AssemblyConnectors_PWP_P_assert_A_Empty_Pattern.AddOwnedParameter(AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_a_Empty_Pattern);
					// ActivityParameterNode a_Empty_Pattern_node
					AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_a_Empty_Pattern_node.SetName("a_Empty_Pattern_node");
					AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_a_Empty_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_a_Empty_Pattern_node.SetParameter(AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_a_Empty_Pattern);
				AssemblyConnectors_PWP_P_assert_A_Empty_Pattern.AddNode(AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_a_Empty_Pattern_node);
					// ValueSpecificationAction message
					AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_message.SetName("message");
					AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_message.SetVisibility(VisibilityKind.public_);
						// LiteralString LiteralString134
						AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_message_LiteralString134.SetName("LiteralString134");
						AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_message_LiteralString134.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_message_LiteralString134.SetValue("Assertion currently not implemented for A_Empty_Pattern.");
					AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_message.SetValue(AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_message_LiteralString134);
						// OutputPin result
						AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_message_result.SetName("result");
						AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_message_result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_message.SetResult(AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_message_result);
				AssemblyConnectors_PWP_P_assert_A_Empty_Pattern.AddNode(AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_message);
					// CallBehaviorAction writeLine
					AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine.SetName("writeLine");
					AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine.SetVisibility(VisibilityKind.public_);
					
						// OutputPin errorStatus
						AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine_errorStatus.SetName("errorStatus");
						AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine_errorStatus.SetVisibility(VisibilityKind.public_);
						
						AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine_errorStatus.SetLower(0);
					AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine.AddResult(AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine_errorStatus);
					AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
						// InputPin value
						AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine_value.SetName("value");
						AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine_value.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine.AddArgument(AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine_value);
				AssemblyConnectors_PWP_P_assert_A_Empty_Pattern.AddNode(AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine);
					// ObjectFlow ObjectFlow128 from result to value
					AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_ObjectFlow128.SetName("ObjectFlow128");
					AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_ObjectFlow128.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_ObjectFlow128.SetSource(AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_message_result);
					AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_ObjectFlow128.SetTarget(AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_writeLine_value);
						// LiteralBoolean LiteralBoolean129
						AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_ObjectFlow128_LiteralBoolean129.SetName("LiteralBoolean129");
						AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_ObjectFlow128_LiteralBoolean129.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_ObjectFlow128_LiteralBoolean129.SetValue(true);
					AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_ObjectFlow128.SetGuard(AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_ObjectFlow128_LiteralBoolean129);
				AssemblyConnectors_PWP_P_assert_A_Empty_Pattern.AddEdge(AssemblyConnectors_PWP_P_assert_A_Empty_Pattern_ObjectFlow128);
			AssemblyConnectors_PWP_P.AddPackagedElement(AssemblyConnectors_PWP_P_assert_A_Empty_Pattern);
				// Class IImpl
				AssemblyConnectors_PWP_P_IImpl.SetName("IImpl");
				AssemblyConnectors_PWP_P_IImpl.SetVisibility(VisibilityKind.public_);
				AssemblyConnectors_PWP_P_IImpl_I_Realization.SetName("I_Realization");
					AssemblyConnectors_PWP_P_IImpl_I_Realization.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_P_IImpl_I_Realization.SetContract(AssemblyConnectors_PWP_P_I);
					
				AssemblyConnectors_PWP_P_IImpl.AddInterfaceRealization(AssemblyConnectors_PWP_P_IImpl_I_Realization);
			AssemblyConnectors_PWP_P.AddPackagedElement(AssemblyConnectors_PWP_P_IImpl);
				// Activity instantiate_A_Unconnected_Pattern
				AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern.SetName("instantiate_A_Unconnected_Pattern");
				AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Unconnected_Pattern
					AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetName("a_Unconnected_Pattern");
					AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetType(AssemblyConnectors_PWP_P_A_Unconnected_Pattern);
					AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetDirection(ParameterDirectionKind.return_);
				AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern.AddOwnedParameter(AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern);
					// CreateObjectAction Create A_Unconnected_Pattern
					AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern.SetName("Create A_Unconnected_Pattern");
					AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern.SetClassifier(AssemblyConnectors_PWP_P_A_Unconnected_Pattern);
						// OutputPin result
						AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result.SetName("result");
						AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result.SetType(AssemblyConnectors_PWP_P_A_Unconnected_Pattern);
					AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern.SetResult(AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result);
				AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern.AddNode(AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern);
					// CallOperationAction A_Unconnected_Pattern()
					AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_.SetName("A_Unconnected_Pattern()");
					AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result.SetName("result");
						AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result.SetType(AssemblyConnectors_PWP_P_A_Unconnected_Pattern);
					AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_.AddResult(AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result);
					AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_.SetOperation(AssemblyConnectors_PWP_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern);
						// InputPin target
						AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target.SetName("target");
						AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target.SetType(AssemblyConnectors_PWP_P_A_Unconnected_Pattern);
					AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_.SetTarget(AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target);
				AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern.AddNode(AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_);
					// ActivityParameterNode a_Unconnected_Pattern_node
					AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node.SetName("a_Unconnected_Pattern_node");
					AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node.SetParameter(AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern);
				AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern.AddNode(AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node);
					// ObjectFlow ObjectFlow141 from result to target
					AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_ObjectFlow141.SetName("ObjectFlow141");
					AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_ObjectFlow141.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_ObjectFlow141.SetSource(AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result);
					AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_ObjectFlow141.SetTarget(AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target);
						// LiteralBoolean LiteralBoolean143
						AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_ObjectFlow141_LiteralBoolean143.SetName("LiteralBoolean143");
						AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_ObjectFlow141_LiteralBoolean143.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_ObjectFlow141_LiteralBoolean143.SetValue(true);
					AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_ObjectFlow141.SetGuard(AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_ObjectFlow141_LiteralBoolean143);
				AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern.AddEdge(AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_ObjectFlow141);
					// ObjectFlow ObjectFlow151 from result to a_Unconnected_Pattern_node
					AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_ObjectFlow151.SetName("ObjectFlow151");
					AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_ObjectFlow151.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_ObjectFlow151.SetSource(AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result);
					AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_ObjectFlow151.SetTarget(AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node);
						// LiteralBoolean LiteralBoolean152
						AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_ObjectFlow151_LiteralBoolean152.SetName("LiteralBoolean152");
						AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_ObjectFlow151_LiteralBoolean152.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_ObjectFlow151_LiteralBoolean152.SetValue(true);
					AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_ObjectFlow151.SetGuard(AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_ObjectFlow151_LiteralBoolean152);
				AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern.AddEdge(AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern_ObjectFlow151);
			AssemblyConnectors_PWP_P.AddPackagedElement(AssemblyConnectors_PWP_P_instantiate_A_Unconnected_Pattern);
				// Class A_Empty_Pattern
				AssemblyConnectors_PWP_P_A_Empty_Pattern.SetName("A_Empty_Pattern");
				AssemblyConnectors_PWP_P_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Property partB
					AssemblyConnectors_PWP_P_A_Empty_Pattern_partB.SetName("partB");
					AssemblyConnectors_PWP_P_A_Empty_Pattern_partB.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_P_A_Empty_Pattern_partB.SetUpper(-1);
					AssemblyConnectors_PWP_P_A_Empty_Pattern_partB.SetLower(0);
					AssemblyConnectors_PWP_P_A_Empty_Pattern_partB.SetType(AssemblyConnectors_PWP_P_B);
					AssemblyConnectors_PWP_P_A_Empty_Pattern_partB.SetAggregation(AggregationKind.composite);
				AssemblyConnectors_PWP_P_A_Empty_Pattern.AddOwnedAttribute(AssemblyConnectors_PWP_P_A_Empty_Pattern_partB);
					// Property partC
					AssemblyConnectors_PWP_P_A_Empty_Pattern_partC.SetName("partC");
					AssemblyConnectors_PWP_P_A_Empty_Pattern_partC.SetVisibility(VisibilityKind.public_);
					AssemblyConnectors_PWP_P_A_Empty_Pattern_partC.SetUpper(-1);
					AssemblyConnectors_PWP_P_A_Empty_Pattern_partC.SetLower(0);
					AssemblyConnectors_PWP_P_A_Empty_Pattern_partC.SetType(AssemblyConnectors_PWP_P_C);
					AssemblyConnectors_PWP_P_A_Empty_Pattern_partC.SetAggregation(AggregationKind.composite);
				AssemblyConnectors_PWP_P_A_Empty_Pattern.AddOwnedAttribute(AssemblyConnectors_PWP_P_A_Empty_Pattern_partC);
				
				AssemblyConnectors_PWP_P_A_Empty_Pattern_r.SetName("r");
					AssemblyConnectors_PWP_P_A_Empty_Pattern_r.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_A_Empty_Pattern_r_ConnectorEnd159.SetUpper(-1);
						AssemblyConnectors_PWP_P_A_Empty_Pattern_r_ConnectorEnd159.SetRole(AssemblyConnectors_PWP_P_B_p);
						AssemblyConnectors_PWP_P_A_Empty_Pattern_r_ConnectorEnd159.SetPartWithPort(AssemblyConnectors_PWP_P_A_Empty_Pattern_partB);
						
					AssemblyConnectors_PWP_P_A_Empty_Pattern_r.AddEnd(AssemblyConnectors_PWP_P_A_Empty_Pattern_r_ConnectorEnd159);
						AssemblyConnectors_PWP_P_A_Empty_Pattern_r_ConnectorEnd158.SetUpper(-1);
						AssemblyConnectors_PWP_P_A_Empty_Pattern_r_ConnectorEnd158.SetRole(AssemblyConnectors_PWP_P_A_Empty_Pattern_partC);
						
					AssemblyConnectors_PWP_P_A_Empty_Pattern_r.AddEnd(AssemblyConnectors_PWP_P_A_Empty_Pattern_r_ConnectorEnd158);
					AssemblyConnectors_PWP_P_A_Empty_Pattern_r.SetType(AssemblyConnectors_PWP_P_R);
				AssemblyConnectors_PWP_P_A_Empty_Pattern.AddOwnedConnector(AssemblyConnectors_PWP_P_A_Empty_Pattern_r);
					// Operation A_Empty_Pattern_A_Empty_Pattern
					AssemblyConnectors_PWP_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern.SetName("A_Empty_Pattern_A_Empty_Pattern");
					AssemblyConnectors_PWP_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
						// Parameter result
						AssemblyConnectors_PWP_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result.SetName("result");
						AssemblyConnectors_PWP_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result.SetVisibility(VisibilityKind.public_);
						
						AssemblyConnectors_PWP_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result.SetType(AssemblyConnectors_PWP_P_A_Empty_Pattern);
						AssemblyConnectors_PWP_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result.SetDirection(ParameterDirectionKind.return_);
					AssemblyConnectors_PWP_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern.AddOwnedParameter(AssemblyConnectors_PWP_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result);
					AssemblyConnectors_PWP_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				AssemblyConnectors_PWP_P_A_Empty_Pattern.AddOwnedOperation(AssemblyConnectors_PWP_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern);
			AssemblyConnectors_PWP_P.AddPackagedElement(AssemblyConnectors_PWP_P_A_Empty_Pattern);
				// Activity assert_A_Unconnected_Pattern
				AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern.SetName("assert_A_Unconnected_Pattern");
				AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Unconnected_Pattern
					AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern.SetName("a_Unconnected_Pattern");
					AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern.SetType(AssemblyConnectors_PWP_P_A_Unconnected_Pattern);
				AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern.AddOwnedParameter(AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern);
					// CallBehaviorAction writeLine
					AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine.SetName("writeLine");
					AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine.SetVisibility(VisibilityKind.public_);
					
						// OutputPin errorStatus
						AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine_errorStatus.SetName("errorStatus");
						AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine_errorStatus.SetVisibility(VisibilityKind.public_);
						
						AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine_errorStatus.SetLower(0);
					AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine.AddResult(AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine_errorStatus);
					AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
						// InputPin value
						AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine_value.SetName("value");
						AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine_value.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine.AddArgument(AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine_value);
				AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern.AddNode(AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine);
					// ActivityParameterNode a_Unconnected_Pattern_node
					AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node.SetName("a_Unconnected_Pattern_node");
					AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node.SetParameter(AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern);
				AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern.AddNode(AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node);
					// ValueSpecificationAction message
					AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_message.SetName("message");
					AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_message.SetVisibility(VisibilityKind.public_);
						// LiteralString LiteralString171
						AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_message_LiteralString171.SetName("LiteralString171");
						AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_message_LiteralString171.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_message_LiteralString171.SetValue("Assertion currently not implemented for A_Unconnected_Pattern.");
					AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_message.SetValue(AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_message_LiteralString171);
						// OutputPin result
						AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_message_result.SetName("result");
						AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_message_result.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_message.SetResult(AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_message_result);
				AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern.AddNode(AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_message);
					// ObjectFlow ObjectFlow161 from result to value
					AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_ObjectFlow161.SetName("ObjectFlow161");
					AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_ObjectFlow161.SetVisibility(VisibilityKind.public_);
					
					AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_ObjectFlow161.SetSource(AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_message_result);
					AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_ObjectFlow161.SetTarget(AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_writeLine_value);
						// LiteralBoolean LiteralBoolean163
						AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_ObjectFlow161_LiteralBoolean163.SetName("LiteralBoolean163");
						AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_ObjectFlow161_LiteralBoolean163.SetVisibility(VisibilityKind.public_);
						AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_ObjectFlow161_LiteralBoolean163.SetValue(true);
					AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_ObjectFlow161.SetGuard(AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_ObjectFlow161_LiteralBoolean163);
				AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern.AddEdge(AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern_ObjectFlow161);
			AssemblyConnectors_PWP_P.AddPackagedElement(AssemblyConnectors_PWP_P_assert_A_Unconnected_Pattern);
				// Association R
				AssemblyConnectors_PWP_P_R.SetName("R");
				AssemblyConnectors_PWP_P_R.SetVisibility(VisibilityKind.public_);
				AssemblyConnectors_PWP_P_R.AddOwnedEnd(AssemblyConnectors_PWP_P_R_x);
				AssemblyConnectors_PWP_P_R.AddOwnedEnd(AssemblyConnectors_PWP_P_R_y);
			AssemblyConnectors_PWP_P.AddPackagedElement(AssemblyConnectors_PWP_P_R);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // AssemblyConnectors_PWP_PModel
}
