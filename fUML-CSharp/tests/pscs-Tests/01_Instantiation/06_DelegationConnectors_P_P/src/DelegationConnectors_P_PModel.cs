/*
 * DelegationConnectors_P_PModel.cs
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

namespace DelegationConnectors_P_P
{
	public class DelegationConnectors_P_PModel : InMemoryModel
	{
		private static DelegationConnectors_P_PModel? instance;

		/*
		 * Model DelegationConnectors_P_P
		 */
		public Package DelegationConnectors_P_P = new();
			public Activity DelegationConnectors_P_P_assert_A_Star_Pattern = new();
				public CallBehaviorAction DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine = new();
					public InputPin DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine_value = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine_value_LiteralUnlimitedNatural0 = new();
						public LiteralInteger DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine_value_LiteralInteger1 = new();
						public LiteralInteger DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine_value_LiteralInteger2 = new();
					public OutputPin DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine_errorStatus = new();
						public LiteralInteger DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine_errorStatus_LiteralInteger3 = new();
						public LiteralInteger DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine_errorStatus_LiteralInteger4 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural5 = new();
				public Parameter DelegationConnectors_P_P_assert_A_Star_Pattern_a_Star_Pattern = new();
				public ValueSpecificationAction DelegationConnectors_P_P_assert_A_Star_Pattern_message = new();
					public OutputPin DelegationConnectors_P_P_assert_A_Star_Pattern_message_result = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_assert_A_Star_Pattern_message_result_LiteralUnlimitedNatural6 = new();
						public LiteralInteger DelegationConnectors_P_P_assert_A_Star_Pattern_message_result_LiteralInteger7 = new();
					public LiteralString DelegationConnectors_P_P_assert_A_Star_Pattern_message_LiteralString8 = new();
				public ObjectFlow DelegationConnectors_P_P_assert_A_Star_Pattern_ObjectFlow9 = new();
					public LiteralBoolean DelegationConnectors_P_P_assert_A_Star_Pattern_ObjectFlow9_LiteralBoolean10 = new();
					public LiteralInteger DelegationConnectors_P_P_assert_A_Star_Pattern_ObjectFlow9_LiteralInteger11 = new();
				public ActivityParameterNode DelegationConnectors_P_P_assert_A_Star_Pattern_a_Star_Pattern_node = new();
					public LiteralInteger DelegationConnectors_P_P_assert_A_Star_Pattern_a_Star_Pattern_node_LiteralInteger12 = new();
			public Activity DelegationConnectors_P_P_instantiate_A_Star_Pattern = new();
				public CallOperationAction DelegationConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern_ = new();
					public InputPin DelegationConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__target = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__target_LiteralUnlimitedNatural13 = new();
						public LiteralInteger DelegationConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__target_LiteralInteger14 = new();
					public OutputPin DelegationConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__result = new();
						public LiteralInteger DelegationConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__result_LiteralInteger15 = new();
						public LiteralInteger DelegationConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__result_LiteralInteger16 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__result_LiteralUnlimitedNatural17 = new();
				public ObjectFlow DelegationConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow18 = new();
					public LiteralBoolean DelegationConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow18_LiteralBoolean19 = new();
					public LiteralInteger DelegationConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow18_LiteralInteger20 = new();
				public ObjectFlow DelegationConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow21 = new();
					public LiteralBoolean DelegationConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow21_LiteralBoolean22 = new();
					public LiteralInteger DelegationConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow21_LiteralInteger23 = new();
				public Parameter DelegationConnectors_P_P_instantiate_A_Star_Pattern_a_Star_Pattern = new();
				public ActivityParameterNode DelegationConnectors_P_P_instantiate_A_Star_Pattern_a_Star_Pattern_node = new();
				public CreateObjectAction DelegationConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern = new();
					public OutputPin DelegationConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result = new();
						public LiteralInteger DelegationConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result_LiteralInteger24 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result_LiteralUnlimitedNatural25 = new();
			public Class_ DelegationConnectors_P_P_A_Star_Pattern = new();
				public Property DelegationConnectors_P_P_A_Star_Pattern_b = new();
					public LiteralInteger DelegationConnectors_P_P_A_Star_Pattern_b_LiteralInteger26 = new();
					public LiteralUnlimitedNatural DelegationConnectors_P_P_A_Star_Pattern_b_LiteralUnlimitedNatural27 = new();
				public Port DelegationConnectors_P_P_A_Star_Pattern_p = new();
					public LiteralInteger DelegationConnectors_P_P_A_Star_Pattern_p_LiteralInteger28 = new();
					public LiteralUnlimitedNatural DelegationConnectors_P_P_A_Star_Pattern_p_LiteralUnlimitedNatural29 = new();
				public Connector DelegationConnectors_P_P_A_Star_Pattern_r = new();
					public ConnectorEnd DelegationConnectors_P_P_A_Star_Pattern_r_ConnectorEnd30 = new();
						public LiteralInteger DelegationConnectors_P_P_A_Star_Pattern_r_ConnectorEnd30_LiteralInteger31 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_A_Star_Pattern_r_ConnectorEnd30_LiteralUnlimitedNatural32 = new();
					public ConnectorEnd DelegationConnectors_P_P_A_Star_Pattern_r_ConnectorEnd33 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_A_Star_Pattern_r_ConnectorEnd33_LiteralUnlimitedNatural34 = new();
						public LiteralInteger DelegationConnectors_P_P_A_Star_Pattern_r_ConnectorEnd33_LiteralInteger35 = new();
				public Comment DelegationConnectors_P_P_A_Star_Pattern_Comment36 = new();
				public Operation DelegationConnectors_P_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern = new();
					public Parameter DelegationConnectors_P_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result = new();
			public Class_ DelegationConnectors_P_P_B = new();
				public InterfaceRealization DelegationConnectors_P_P_B_I_Realization = new();
			public Activity DelegationConnectors_P_P_main = new();
				public ControlFlow DelegationConnectors_P_P_main_ControlFlow37 = new();
				public CallBehaviorAction DelegationConnectors_P_P_main_assert_A_Array_Pattern = new();
					public InputPin DelegationConnectors_P_P_main_assert_A_Array_Pattern_a_Array_Pattern = new();
						public LiteralInteger DelegationConnectors_P_P_main_assert_A_Array_Pattern_a_Array_Pattern_LiteralInteger38 = new();
						public LiteralInteger DelegationConnectors_P_P_main_assert_A_Array_Pattern_a_Array_Pattern_LiteralInteger39 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_main_assert_A_Array_Pattern_a_Array_Pattern_LiteralUnlimitedNatural40 = new();
				public ObjectFlow DelegationConnectors_P_P_main_ObjectFlow41 = new();
					public LiteralInteger DelegationConnectors_P_P_main_ObjectFlow41_LiteralInteger42 = new();
					public LiteralBoolean DelegationConnectors_P_P_main_ObjectFlow41_LiteralBoolean43 = new();
				public CallBehaviorAction DelegationConnectors_P_P_main_assert_A_Unconnected_Pattern = new();
					public InputPin DelegationConnectors_P_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern = new();
						public LiteralInteger DelegationConnectors_P_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger44 = new();
						public LiteralInteger DelegationConnectors_P_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger45 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralUnlimitedNatural46 = new();
				public CallBehaviorAction DelegationConnectors_P_P_main_instantiate_A_Unconnected_Pattern = new();
					public OutputPin DelegationConnectors_P_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern = new();
						public LiteralInteger DelegationConnectors_P_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger47 = new();
						public LiteralInteger DelegationConnectors_P_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger48 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralUnlimitedNatural49 = new();
				public CallBehaviorAction DelegationConnectors_P_P_main_instantiate_A_Empty_Pattern = new();
					public OutputPin DelegationConnectors_P_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern_LiteralUnlimitedNatural50 = new();
						public LiteralInteger DelegationConnectors_P_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger51 = new();
						public LiteralInteger DelegationConnectors_P_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger52 = new();
				public CallBehaviorAction DelegationConnectors_P_P_main_assert_A_Star_Pattern = new();
					public InputPin DelegationConnectors_P_P_main_assert_A_Star_Pattern_a_Star_Pattern = new();
						public LiteralInteger DelegationConnectors_P_P_main_assert_A_Star_Pattern_a_Star_Pattern_LiteralInteger53 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_main_assert_A_Star_Pattern_a_Star_Pattern_LiteralUnlimitedNatural54 = new();
						public LiteralInteger DelegationConnectors_P_P_main_assert_A_Star_Pattern_a_Star_Pattern_LiteralInteger55 = new();
				public CallBehaviorAction DelegationConnectors_P_P_main_assert_A_Empty_Pattern = new();
					public InputPin DelegationConnectors_P_P_main_assert_A_Empty_Pattern_a_Empty_Pattern = new();
						public LiteralInteger DelegationConnectors_P_P_main_assert_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger56 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_main_assert_A_Empty_Pattern_a_Empty_Pattern_LiteralUnlimitedNatural57 = new();
						public LiteralInteger DelegationConnectors_P_P_main_assert_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger58 = new();
				public ObjectFlow DelegationConnectors_P_P_main_ObjectFlow59 = new();
					public LiteralInteger DelegationConnectors_P_P_main_ObjectFlow59_LiteralInteger60 = new();
					public LiteralBoolean DelegationConnectors_P_P_main_ObjectFlow59_LiteralBoolean61 = new();
				public CallBehaviorAction DelegationConnectors_P_P_main_instantiate_A_Array_Pattern = new();
					public OutputPin DelegationConnectors_P_P_main_instantiate_A_Array_Pattern_a_Array_Pattern = new();
						public LiteralInteger DelegationConnectors_P_P_main_instantiate_A_Array_Pattern_a_Array_Pattern_LiteralInteger62 = new();
						public LiteralInteger DelegationConnectors_P_P_main_instantiate_A_Array_Pattern_a_Array_Pattern_LiteralInteger63 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_main_instantiate_A_Array_Pattern_a_Array_Pattern_LiteralUnlimitedNatural64 = new();
				public ObjectFlow DelegationConnectors_P_P_main_ObjectFlow65 = new();
					public LiteralInteger DelegationConnectors_P_P_main_ObjectFlow65_LiteralInteger66 = new();
					public LiteralBoolean DelegationConnectors_P_P_main_ObjectFlow65_LiteralBoolean67 = new();
				public ObjectFlow DelegationConnectors_P_P_main_ObjectFlow68 = new();
					public LiteralInteger DelegationConnectors_P_P_main_ObjectFlow68_LiteralInteger69 = new();
					public LiteralBoolean DelegationConnectors_P_P_main_ObjectFlow68_LiteralBoolean70 = new();
				public CallBehaviorAction DelegationConnectors_P_P_main_instantiate_A_Star_Pattern = new();
					public OutputPin DelegationConnectors_P_P_main_instantiate_A_Star_Pattern_a_Star_Pattern = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_main_instantiate_A_Star_Pattern_a_Star_Pattern_LiteralUnlimitedNatural71 = new();
						public LiteralInteger DelegationConnectors_P_P_main_instantiate_A_Star_Pattern_a_Star_Pattern_LiteralInteger72 = new();
						public LiteralInteger DelegationConnectors_P_P_main_instantiate_A_Star_Pattern_a_Star_Pattern_LiteralInteger73 = new();
				public ControlFlow DelegationConnectors_P_P_main_ControlFlow74 = new();
				public ControlFlow DelegationConnectors_P_P_main_ControlFlow75 = new();
			public Activity DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern = new();
				public CallOperationAction DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_ = new();
					public OutputPin DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result_LiteralUnlimitedNatural76 = new();
						public LiteralInteger DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result_LiteralInteger77 = new();
						public LiteralInteger DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result_LiteralInteger78 = new();
					public InputPin DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target = new();
						public LiteralInteger DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target_LiteralInteger79 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target_LiteralUnlimitedNatural80 = new();
				public ObjectFlow DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow81 = new();
					public LiteralBoolean DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow81_LiteralBoolean82 = new();
					public LiteralInteger DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow81_LiteralInteger83 = new();
				public Parameter DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern = new();
				public CreateObjectAction DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern = new();
					public OutputPin DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result = new();
						public LiteralInteger DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result_LiteralInteger84 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result_LiteralUnlimitedNatural85 = new();
				public ObjectFlow DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow86 = new();
					public LiteralBoolean DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow86_LiteralBoolean87 = new();
					public LiteralInteger DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow86_LiteralInteger88 = new();
				public ActivityParameterNode DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node = new();
			public Class_ DelegationConnectors_P_P_IImpl = new();
				public InterfaceRealization DelegationConnectors_P_P_IImpl_I_Realization = new();
			public Activity DelegationConnectors_P_P_instantiate_A_Array_Pattern = new();
				public CallOperationAction DelegationConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern_ = new();
					public OutputPin DelegationConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__result = new();
						public LiteralInteger DelegationConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__result_LiteralInteger89 = new();
						public LiteralInteger DelegationConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__result_LiteralInteger90 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__result_LiteralUnlimitedNatural91 = new();
					public InputPin DelegationConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__target = new();
						public LiteralInteger DelegationConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__target_LiteralInteger92 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__target_LiteralUnlimitedNatural93 = new();
				public CreateObjectAction DelegationConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern = new();
					public OutputPin DelegationConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result = new();
						public LiteralInteger DelegationConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result_LiteralInteger94 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result_LiteralUnlimitedNatural95 = new();
				public ObjectFlow DelegationConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow96 = new();
					public LiteralInteger DelegationConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow96_LiteralInteger97 = new();
					public LiteralBoolean DelegationConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow96_LiteralBoolean98 = new();
				public Parameter DelegationConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern = new();
				public ObjectFlow DelegationConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow99 = new();
					public LiteralBoolean DelegationConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow99_LiteralBoolean100 = new();
					public LiteralInteger DelegationConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow99_LiteralInteger101 = new();
				public ActivityParameterNode DelegationConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern_node = new();
					public LiteralInteger DelegationConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern_node_LiteralInteger102 = new();
			public Activity DelegationConnectors_P_P_assert_A_Unconnected_Pattern = new();
				public ActivityParameterNode DelegationConnectors_P_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node = new();
					public LiteralInteger DelegationConnectors_P_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node_LiteralInteger103 = new();
				public CallBehaviorAction DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine = new();
					public InputPin DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_value = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_value_LiteralUnlimitedNatural104 = new();
						public LiteralInteger DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_value_LiteralInteger105 = new();
						public LiteralInteger DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_value_LiteralInteger106 = new();
					public OutputPin DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_errorStatus = new();
						public LiteralInteger DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_errorStatus_LiteralInteger107 = new();
						public LiteralInteger DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_errorStatus_LiteralInteger108 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural109 = new();
				public Parameter DelegationConnectors_P_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern = new();
				public ObjectFlow DelegationConnectors_P_P_assert_A_Unconnected_Pattern_ObjectFlow110 = new();
					public LiteralBoolean DelegationConnectors_P_P_assert_A_Unconnected_Pattern_ObjectFlow110_LiteralBoolean111 = new();
					public LiteralInteger DelegationConnectors_P_P_assert_A_Unconnected_Pattern_ObjectFlow110_LiteralInteger112 = new();
				public ValueSpecificationAction DelegationConnectors_P_P_assert_A_Unconnected_Pattern_message = new();
					public OutputPin DelegationConnectors_P_P_assert_A_Unconnected_Pattern_message_result = new();
						public LiteralInteger DelegationConnectors_P_P_assert_A_Unconnected_Pattern_message_result_LiteralInteger113 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_assert_A_Unconnected_Pattern_message_result_LiteralUnlimitedNatural114 = new();
					public LiteralString DelegationConnectors_P_P_assert_A_Unconnected_Pattern_message_LiteralString115 = new();
			public Class_ DelegationConnectors_P_P_A_Array_Pattern = new();
				public Comment DelegationConnectors_P_P_A_Array_Pattern_Comment116 = new();
				public Connector DelegationConnectors_P_P_A_Array_Pattern_r = new();
					public ConnectorEnd DelegationConnectors_P_P_A_Array_Pattern_r_ConnectorEnd117 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_A_Array_Pattern_r_ConnectorEnd117_LiteralUnlimitedNatural118 = new();
					public ConnectorEnd DelegationConnectors_P_P_A_Array_Pattern_r_ConnectorEnd119 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_A_Array_Pattern_r_ConnectorEnd119_LiteralUnlimitedNatural120 = new();
				public Property DelegationConnectors_P_P_A_Array_Pattern_b = new();
					public LiteralUnlimitedNatural DelegationConnectors_P_P_A_Array_Pattern_b_LiteralUnlimitedNatural121 = new();
					public LiteralInteger DelegationConnectors_P_P_A_Array_Pattern_b_LiteralInteger122 = new();
				public Operation DelegationConnectors_P_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern = new();
					public Parameter DelegationConnectors_P_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result = new();
				public Port DelegationConnectors_P_P_A_Array_Pattern_p = new();
					public LiteralInteger DelegationConnectors_P_P_A_Array_Pattern_p_LiteralInteger123 = new();
					public LiteralUnlimitedNatural DelegationConnectors_P_P_A_Array_Pattern_p_LiteralUnlimitedNatural124 = new();
			public Association DelegationConnectors_P_P_R = new();
				public Property DelegationConnectors_P_P_R_x = new();
					public LiteralInteger DelegationConnectors_P_P_R_x_LiteralInteger125 = new();
					public LiteralUnlimitedNatural DelegationConnectors_P_P_R_x_LiteralUnlimitedNatural126 = new();
				public Property DelegationConnectors_P_P_R_y = new();
					public LiteralInteger DelegationConnectors_P_P_R_y_LiteralInteger127 = new();
					public LiteralUnlimitedNatural DelegationConnectors_P_P_R_y_LiteralUnlimitedNatural128 = new();
			public Class_ DelegationConnectors_P_P_A_Unconnected_Pattern = new();
				public Port DelegationConnectors_P_P_A_Unconnected_Pattern_p = new();
					public LiteralInteger DelegationConnectors_P_P_A_Unconnected_Pattern_p_LiteralInteger129 = new();
					public LiteralUnlimitedNatural DelegationConnectors_P_P_A_Unconnected_Pattern_p_LiteralUnlimitedNatural130 = new();
				public Operation DelegationConnectors_P_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern = new();
					public Parameter DelegationConnectors_P_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result = new();
				public Property DelegationConnectors_P_P_A_Unconnected_Pattern_b = new();
					public LiteralInteger DelegationConnectors_P_P_A_Unconnected_Pattern_b_LiteralInteger131 = new();
					public LiteralUnlimitedNatural DelegationConnectors_P_P_A_Unconnected_Pattern_b_LiteralUnlimitedNatural132 = new();
				public Connector DelegationConnectors_P_P_A_Unconnected_Pattern_r = new();
					public ConnectorEnd DelegationConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd133 = new();
						public LiteralInteger DelegationConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd133_LiteralInteger134 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd133_LiteralUnlimitedNatural135 = new();
					public ConnectorEnd DelegationConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd136 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd136_LiteralUnlimitedNatural137 = new();
						public LiteralInteger DelegationConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd136_LiteralInteger138 = new();
				public Comment DelegationConnectors_P_P_A_Unconnected_Pattern_Comment139 = new();
			public Interface DelegationConnectors_P_P_I = new();
			public Activity DelegationConnectors_P_P_instantiate_A_Empty_Pattern = new();
				public ObjectFlow DelegationConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow140 = new();
					public LiteralInteger DelegationConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow140_LiteralInteger141 = new();
					public LiteralBoolean DelegationConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow140_LiteralBoolean142 = new();
				public CreateObjectAction DelegationConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern = new();
					public OutputPin DelegationConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result = new();
						public LiteralInteger DelegationConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result_LiteralInteger143 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result_LiteralUnlimitedNatural144 = new();
				public ActivityParameterNode DelegationConnectors_P_P_instantiate_A_Empty_Pattern_a_Empty_Pattern_node = new();
				public Parameter DelegationConnectors_P_P_instantiate_A_Empty_Pattern_a_Empty_Pattern = new();
				public ObjectFlow DelegationConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow145 = new();
					public LiteralBoolean DelegationConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow145_LiteralBoolean146 = new();
					public LiteralInteger DelegationConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow145_LiteralInteger147 = new();
				public CallOperationAction DelegationConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern_ = new();
					public InputPin DelegationConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target_LiteralUnlimitedNatural148 = new();
						public LiteralInteger DelegationConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target_LiteralInteger149 = new();
					public OutputPin DelegationConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result = new();
						public LiteralInteger DelegationConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result_LiteralInteger150 = new();
						public LiteralInteger DelegationConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result_LiteralInteger151 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result_LiteralUnlimitedNatural152 = new();
			public Activity DelegationConnectors_P_P_assert_A_Array_Pattern = new();
				public ObjectFlow DelegationConnectors_P_P_assert_A_Array_Pattern_ObjectFlow153 = new();
					public LiteralBoolean DelegationConnectors_P_P_assert_A_Array_Pattern_ObjectFlow153_LiteralBoolean154 = new();
					public LiteralInteger DelegationConnectors_P_P_assert_A_Array_Pattern_ObjectFlow153_LiteralInteger155 = new();
				public ValueSpecificationAction DelegationConnectors_P_P_assert_A_Array_Pattern_message = new();
					public OutputPin DelegationConnectors_P_P_assert_A_Array_Pattern_message_result = new();
						public LiteralInteger DelegationConnectors_P_P_assert_A_Array_Pattern_message_result_LiteralInteger156 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_assert_A_Array_Pattern_message_result_LiteralUnlimitedNatural157 = new();
					public LiteralString DelegationConnectors_P_P_assert_A_Array_Pattern_message_LiteralString158 = new();
				public CallBehaviorAction DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine = new();
					public OutputPin DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine_errorStatus = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural159 = new();
						public LiteralInteger DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine_errorStatus_LiteralInteger160 = new();
						public LiteralInteger DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine_errorStatus_LiteralInteger161 = new();
					public InputPin DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine_value = new();
						public LiteralInteger DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine_value_LiteralInteger162 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine_value_LiteralUnlimitedNatural163 = new();
						public LiteralInteger DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine_value_LiteralInteger164 = new();
				public Parameter DelegationConnectors_P_P_assert_A_Array_Pattern_a_Array_Pattern = new();
				public ActivityParameterNode DelegationConnectors_P_P_assert_A_Array_Pattern_a_Array_Pattern_node = new();
					public LiteralInteger DelegationConnectors_P_P_assert_A_Array_Pattern_a_Array_Pattern_node_LiteralInteger165 = new();
			public Class_ DelegationConnectors_P_P_A_Empty_Pattern = new();
				public Property DelegationConnectors_P_P_A_Empty_Pattern_b = new();
					public LiteralInteger DelegationConnectors_P_P_A_Empty_Pattern_b_LiteralInteger166 = new();
					public LiteralUnlimitedNatural DelegationConnectors_P_P_A_Empty_Pattern_b_LiteralUnlimitedNatural167 = new();
				public Operation DelegationConnectors_P_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern = new();
					public Parameter DelegationConnectors_P_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result = new();
				public Comment DelegationConnectors_P_P_A_Empty_Pattern_Comment168 = new();
				public Port DelegationConnectors_P_P_A_Empty_Pattern_p = new();
					public LiteralInteger DelegationConnectors_P_P_A_Empty_Pattern_p_LiteralInteger169 = new();
					public LiteralUnlimitedNatural DelegationConnectors_P_P_A_Empty_Pattern_p_LiteralUnlimitedNatural170 = new();
				public Connector DelegationConnectors_P_P_A_Empty_Pattern_r = new();
					public ConnectorEnd DelegationConnectors_P_P_A_Empty_Pattern_r_ConnectorEnd171 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_A_Empty_Pattern_r_ConnectorEnd171_LiteralUnlimitedNatural172 = new();
					public ConnectorEnd DelegationConnectors_P_P_A_Empty_Pattern_r_ConnectorEnd173 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_A_Empty_Pattern_r_ConnectorEnd173_LiteralUnlimitedNatural174 = new();
			public Activity DelegationConnectors_P_P_assert_A_Empty_Pattern = new();
				public ValueSpecificationAction DelegationConnectors_P_P_assert_A_Empty_Pattern_message = new();
					public OutputPin DelegationConnectors_P_P_assert_A_Empty_Pattern_message_result = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_assert_A_Empty_Pattern_message_result_LiteralUnlimitedNatural175 = new();
						public LiteralInteger DelegationConnectors_P_P_assert_A_Empty_Pattern_message_result_LiteralInteger176 = new();
					public LiteralString DelegationConnectors_P_P_assert_A_Empty_Pattern_message_LiteralString177 = new();
				public ObjectFlow DelegationConnectors_P_P_assert_A_Empty_Pattern_ObjectFlow178 = new();
					public LiteralInteger DelegationConnectors_P_P_assert_A_Empty_Pattern_ObjectFlow178_LiteralInteger179 = new();
					public LiteralBoolean DelegationConnectors_P_P_assert_A_Empty_Pattern_ObjectFlow178_LiteralBoolean180 = new();
				public CallBehaviorAction DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine = new();
					public OutputPin DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine_errorStatus = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural181 = new();
						public LiteralInteger DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine_errorStatus_LiteralInteger182 = new();
						public LiteralInteger DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine_errorStatus_LiteralInteger183 = new();
					public InputPin DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine_value = new();
						public LiteralInteger DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine_value_LiteralInteger184 = new();
						public LiteralInteger DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine_value_LiteralInteger185 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine_value_LiteralUnlimitedNatural186 = new();
				public ActivityParameterNode DelegationConnectors_P_P_assert_A_Empty_Pattern_a_Empty_Pattern_node = new();
					public LiteralInteger DelegationConnectors_P_P_assert_A_Empty_Pattern_a_Empty_Pattern_node_LiteralInteger187 = new();
				public Parameter DelegationConnectors_P_P_assert_A_Empty_Pattern_a_Empty_Pattern = new();

		public static DelegationConnectors_P_PModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public DelegationConnectors_P_PModel()
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
			 * Model DelegationConnectors_P_P
			 */
			AddToElementRepository("DelegationConnectors_P_P", DelegationConnectors_P_P);
				AddToElementRepository("assert_A_Star_Pattern", DelegationConnectors_P_P_assert_A_Star_Pattern);
					AddToElementRepository("writeLine", DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine);
						AddToElementRepository("value", DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine_value);
							AddToElementRepository("LiteralUnlimitedNatural0", DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine_value_LiteralUnlimitedNatural0);
							AddToElementRepository("LiteralInteger1", DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine_value_LiteralInteger1);
							AddToElementRepository("LiteralInteger2", DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine_value_LiteralInteger2);
						AddToElementRepository("errorStatus", DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine_errorStatus);
							AddToElementRepository("LiteralInteger3", DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine_errorStatus_LiteralInteger3);
							AddToElementRepository("LiteralInteger4", DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine_errorStatus_LiteralInteger4);
							AddToElementRepository("LiteralUnlimitedNatural5", DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural5);
					AddToElementRepository("a_Star_Pattern", DelegationConnectors_P_P_assert_A_Star_Pattern_a_Star_Pattern);
					AddToElementRepository("message", DelegationConnectors_P_P_assert_A_Star_Pattern_message);
						AddToElementRepository("result", DelegationConnectors_P_P_assert_A_Star_Pattern_message_result);
							AddToElementRepository("LiteralUnlimitedNatural6", DelegationConnectors_P_P_assert_A_Star_Pattern_message_result_LiteralUnlimitedNatural6);
							AddToElementRepository("LiteralInteger7", DelegationConnectors_P_P_assert_A_Star_Pattern_message_result_LiteralInteger7);
						AddToElementRepository("LiteralString8", DelegationConnectors_P_P_assert_A_Star_Pattern_message_LiteralString8);
					AddToElementRepository("ObjectFlow9", DelegationConnectors_P_P_assert_A_Star_Pattern_ObjectFlow9);
						AddToElementRepository("LiteralBoolean10", DelegationConnectors_P_P_assert_A_Star_Pattern_ObjectFlow9_LiteralBoolean10);
						AddToElementRepository("LiteralInteger11", DelegationConnectors_P_P_assert_A_Star_Pattern_ObjectFlow9_LiteralInteger11);
					AddToElementRepository("a_Star_Pattern_node", DelegationConnectors_P_P_assert_A_Star_Pattern_a_Star_Pattern_node);
						AddToElementRepository("LiteralInteger12", DelegationConnectors_P_P_assert_A_Star_Pattern_a_Star_Pattern_node_LiteralInteger12);
				AddToElementRepository("instantiate_A_Star_Pattern", DelegationConnectors_P_P_instantiate_A_Star_Pattern);
					AddToElementRepository("A_Star_Pattern()", DelegationConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern_);
						AddToElementRepository("target", DelegationConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__target);
							AddToElementRepository("LiteralUnlimitedNatural13", DelegationConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__target_LiteralUnlimitedNatural13);
							AddToElementRepository("LiteralInteger14", DelegationConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__target_LiteralInteger14);
						AddToElementRepository("result", DelegationConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__result);
							AddToElementRepository("LiteralInteger15", DelegationConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__result_LiteralInteger15);
							AddToElementRepository("LiteralInteger16", DelegationConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__result_LiteralInteger16);
							AddToElementRepository("LiteralUnlimitedNatural17", DelegationConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__result_LiteralUnlimitedNatural17);
					AddToElementRepository("ObjectFlow18", DelegationConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow18);
						AddToElementRepository("LiteralBoolean19", DelegationConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow18_LiteralBoolean19);
						AddToElementRepository("LiteralInteger20", DelegationConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow18_LiteralInteger20);
					AddToElementRepository("ObjectFlow21", DelegationConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow21);
						AddToElementRepository("LiteralBoolean22", DelegationConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow21_LiteralBoolean22);
						AddToElementRepository("LiteralInteger23", DelegationConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow21_LiteralInteger23);
					AddToElementRepository("a_Star_Pattern", DelegationConnectors_P_P_instantiate_A_Star_Pattern_a_Star_Pattern);
					AddToElementRepository("a_Star_Pattern_node", DelegationConnectors_P_P_instantiate_A_Star_Pattern_a_Star_Pattern_node);
					AddToElementRepository("Create A_Star_Pattern", DelegationConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern);
						AddToElementRepository("result", DelegationConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result);
							AddToElementRepository("LiteralInteger24", DelegationConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result_LiteralInteger24);
							AddToElementRepository("LiteralUnlimitedNatural25", DelegationConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result_LiteralUnlimitedNatural25);
				AddToElementRepository("A_Star_Pattern", DelegationConnectors_P_P_A_Star_Pattern);
					AddToElementRepository("b", DelegationConnectors_P_P_A_Star_Pattern_b);
						AddToElementRepository("LiteralInteger26", DelegationConnectors_P_P_A_Star_Pattern_b_LiteralInteger26);
						AddToElementRepository("LiteralUnlimitedNatural27", DelegationConnectors_P_P_A_Star_Pattern_b_LiteralUnlimitedNatural27);
					AddToElementRepository("p", DelegationConnectors_P_P_A_Star_Pattern_p);
						AddToElementRepository("LiteralInteger28", DelegationConnectors_P_P_A_Star_Pattern_p_LiteralInteger28);
						AddToElementRepository("LiteralUnlimitedNatural29", DelegationConnectors_P_P_A_Star_Pattern_p_LiteralUnlimitedNatural29);
					AddToElementRepository("r", DelegationConnectors_P_P_A_Star_Pattern_r);
						AddToElementRepository("ConnectorEnd30", DelegationConnectors_P_P_A_Star_Pattern_r_ConnectorEnd30);
							AddToElementRepository("LiteralInteger31", DelegationConnectors_P_P_A_Star_Pattern_r_ConnectorEnd30_LiteralInteger31);
							AddToElementRepository("LiteralUnlimitedNatural32", DelegationConnectors_P_P_A_Star_Pattern_r_ConnectorEnd30_LiteralUnlimitedNatural32);
						AddToElementRepository("ConnectorEnd33", DelegationConnectors_P_P_A_Star_Pattern_r_ConnectorEnd33);
							AddToElementRepository("LiteralUnlimitedNatural34", DelegationConnectors_P_P_A_Star_Pattern_r_ConnectorEnd33_LiteralUnlimitedNatural34);
							AddToElementRepository("LiteralInteger35", DelegationConnectors_P_P_A_Star_Pattern_r_ConnectorEnd33_LiteralInteger35);
					AddToElementRepository("Comment36", DelegationConnectors_P_P_A_Star_Pattern_Comment36);
					AddToElementRepository("A_Star_Pattern_A_Star_Pattern", DelegationConnectors_P_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern);
						AddToElementRepository("result", DelegationConnectors_P_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result);
				AddToElementRepository("B", DelegationConnectors_P_P_B);
					AddToElementRepository("I_Realization", DelegationConnectors_P_P_B_I_Realization);
				AddToElementRepository("main", DelegationConnectors_P_P_main);
					AddToElementRepository("ControlFlow37", DelegationConnectors_P_P_main_ControlFlow37);
					AddToElementRepository("assert_A_Array_Pattern", DelegationConnectors_P_P_main_assert_A_Array_Pattern);
						AddToElementRepository("a_Array_Pattern", DelegationConnectors_P_P_main_assert_A_Array_Pattern_a_Array_Pattern);
							AddToElementRepository("LiteralInteger38", DelegationConnectors_P_P_main_assert_A_Array_Pattern_a_Array_Pattern_LiteralInteger38);
							AddToElementRepository("LiteralInteger39", DelegationConnectors_P_P_main_assert_A_Array_Pattern_a_Array_Pattern_LiteralInteger39);
							AddToElementRepository("LiteralUnlimitedNatural40", DelegationConnectors_P_P_main_assert_A_Array_Pattern_a_Array_Pattern_LiteralUnlimitedNatural40);
					AddToElementRepository("ObjectFlow41", DelegationConnectors_P_P_main_ObjectFlow41);
						AddToElementRepository("LiteralInteger42", DelegationConnectors_P_P_main_ObjectFlow41_LiteralInteger42);
						AddToElementRepository("LiteralBoolean43", DelegationConnectors_P_P_main_ObjectFlow41_LiteralBoolean43);
					AddToElementRepository("assert_A_Unconnected_Pattern", DelegationConnectors_P_P_main_assert_A_Unconnected_Pattern);
						AddToElementRepository("a_Unconnected_Pattern", DelegationConnectors_P_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern);
							AddToElementRepository("LiteralInteger44", DelegationConnectors_P_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger44);
							AddToElementRepository("LiteralInteger45", DelegationConnectors_P_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger45);
							AddToElementRepository("LiteralUnlimitedNatural46", DelegationConnectors_P_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralUnlimitedNatural46);
					AddToElementRepository("instantiate_A_Unconnected_Pattern", DelegationConnectors_P_P_main_instantiate_A_Unconnected_Pattern);
						AddToElementRepository("a_Unconnected_Pattern", DelegationConnectors_P_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern);
							AddToElementRepository("LiteralInteger47", DelegationConnectors_P_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger47);
							AddToElementRepository("LiteralInteger48", DelegationConnectors_P_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger48);
							AddToElementRepository("LiteralUnlimitedNatural49", DelegationConnectors_P_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralUnlimitedNatural49);
					AddToElementRepository("instantiate_A_Empty_Pattern", DelegationConnectors_P_P_main_instantiate_A_Empty_Pattern);
						AddToElementRepository("a_Empty_Pattern", DelegationConnectors_P_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern);
							AddToElementRepository("LiteralUnlimitedNatural50", DelegationConnectors_P_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern_LiteralUnlimitedNatural50);
							AddToElementRepository("LiteralInteger51", DelegationConnectors_P_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger51);
							AddToElementRepository("LiteralInteger52", DelegationConnectors_P_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger52);
					AddToElementRepository("assert_A_Star_Pattern", DelegationConnectors_P_P_main_assert_A_Star_Pattern);
						AddToElementRepository("a_Star_Pattern", DelegationConnectors_P_P_main_assert_A_Star_Pattern_a_Star_Pattern);
							AddToElementRepository("LiteralInteger53", DelegationConnectors_P_P_main_assert_A_Star_Pattern_a_Star_Pattern_LiteralInteger53);
							AddToElementRepository("LiteralUnlimitedNatural54", DelegationConnectors_P_P_main_assert_A_Star_Pattern_a_Star_Pattern_LiteralUnlimitedNatural54);
							AddToElementRepository("LiteralInteger55", DelegationConnectors_P_P_main_assert_A_Star_Pattern_a_Star_Pattern_LiteralInteger55);
					AddToElementRepository("assert_A_Empty_Pattern", DelegationConnectors_P_P_main_assert_A_Empty_Pattern);
						AddToElementRepository("a_Empty_Pattern", DelegationConnectors_P_P_main_assert_A_Empty_Pattern_a_Empty_Pattern);
							AddToElementRepository("LiteralInteger56", DelegationConnectors_P_P_main_assert_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger56);
							AddToElementRepository("LiteralUnlimitedNatural57", DelegationConnectors_P_P_main_assert_A_Empty_Pattern_a_Empty_Pattern_LiteralUnlimitedNatural57);
							AddToElementRepository("LiteralInteger58", DelegationConnectors_P_P_main_assert_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger58);
					AddToElementRepository("ObjectFlow59", DelegationConnectors_P_P_main_ObjectFlow59);
						AddToElementRepository("LiteralInteger60", DelegationConnectors_P_P_main_ObjectFlow59_LiteralInteger60);
						AddToElementRepository("LiteralBoolean61", DelegationConnectors_P_P_main_ObjectFlow59_LiteralBoolean61);
					AddToElementRepository("instantiate_A_Array_Pattern", DelegationConnectors_P_P_main_instantiate_A_Array_Pattern);
						AddToElementRepository("a_Array_Pattern", DelegationConnectors_P_P_main_instantiate_A_Array_Pattern_a_Array_Pattern);
							AddToElementRepository("LiteralInteger62", DelegationConnectors_P_P_main_instantiate_A_Array_Pattern_a_Array_Pattern_LiteralInteger62);
							AddToElementRepository("LiteralInteger63", DelegationConnectors_P_P_main_instantiate_A_Array_Pattern_a_Array_Pattern_LiteralInteger63);
							AddToElementRepository("LiteralUnlimitedNatural64", DelegationConnectors_P_P_main_instantiate_A_Array_Pattern_a_Array_Pattern_LiteralUnlimitedNatural64);
					AddToElementRepository("ObjectFlow65", DelegationConnectors_P_P_main_ObjectFlow65);
						AddToElementRepository("LiteralInteger66", DelegationConnectors_P_P_main_ObjectFlow65_LiteralInteger66);
						AddToElementRepository("LiteralBoolean67", DelegationConnectors_P_P_main_ObjectFlow65_LiteralBoolean67);
					AddToElementRepository("ObjectFlow68", DelegationConnectors_P_P_main_ObjectFlow68);
						AddToElementRepository("LiteralInteger69", DelegationConnectors_P_P_main_ObjectFlow68_LiteralInteger69);
						AddToElementRepository("LiteralBoolean70", DelegationConnectors_P_P_main_ObjectFlow68_LiteralBoolean70);
					AddToElementRepository("instantiate_A_Star_Pattern", DelegationConnectors_P_P_main_instantiate_A_Star_Pattern);
						AddToElementRepository("a_Star_Pattern", DelegationConnectors_P_P_main_instantiate_A_Star_Pattern_a_Star_Pattern);
							AddToElementRepository("LiteralUnlimitedNatural71", DelegationConnectors_P_P_main_instantiate_A_Star_Pattern_a_Star_Pattern_LiteralUnlimitedNatural71);
							AddToElementRepository("LiteralInteger72", DelegationConnectors_P_P_main_instantiate_A_Star_Pattern_a_Star_Pattern_LiteralInteger72);
							AddToElementRepository("LiteralInteger73", DelegationConnectors_P_P_main_instantiate_A_Star_Pattern_a_Star_Pattern_LiteralInteger73);
					AddToElementRepository("ControlFlow74", DelegationConnectors_P_P_main_ControlFlow74);
					AddToElementRepository("ControlFlow75", DelegationConnectors_P_P_main_ControlFlow75);
				AddToElementRepository("instantiate_A_Unconnected_Pattern", DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern);
					AddToElementRepository("A_Unconnected_Pattern()", DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_);
						AddToElementRepository("result", DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result);
							AddToElementRepository("LiteralUnlimitedNatural76", DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result_LiteralUnlimitedNatural76);
							AddToElementRepository("LiteralInteger77", DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result_LiteralInteger77);
							AddToElementRepository("LiteralInteger78", DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result_LiteralInteger78);
						AddToElementRepository("target", DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target);
							AddToElementRepository("LiteralInteger79", DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target_LiteralInteger79);
							AddToElementRepository("LiteralUnlimitedNatural80", DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target_LiteralUnlimitedNatural80);
					AddToElementRepository("ObjectFlow81", DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow81);
						AddToElementRepository("LiteralBoolean82", DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow81_LiteralBoolean82);
						AddToElementRepository("LiteralInteger83", DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow81_LiteralInteger83);
					AddToElementRepository("a_Unconnected_Pattern", DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern);
					AddToElementRepository("Create A_Unconnected_Pattern", DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern);
						AddToElementRepository("result", DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result);
							AddToElementRepository("LiteralInteger84", DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result_LiteralInteger84);
							AddToElementRepository("LiteralUnlimitedNatural85", DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result_LiteralUnlimitedNatural85);
					AddToElementRepository("ObjectFlow86", DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow86);
						AddToElementRepository("LiteralBoolean87", DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow86_LiteralBoolean87);
						AddToElementRepository("LiteralInteger88", DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow86_LiteralInteger88);
					AddToElementRepository("a_Unconnected_Pattern_node", DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node);
				AddToElementRepository("IImpl", DelegationConnectors_P_P_IImpl);
					AddToElementRepository("I_Realization", DelegationConnectors_P_P_IImpl_I_Realization);
				AddToElementRepository("instantiate_A_Array_Pattern", DelegationConnectors_P_P_instantiate_A_Array_Pattern);
					AddToElementRepository("A_Array_Pattern()", DelegationConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern_);
						AddToElementRepository("result", DelegationConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__result);
							AddToElementRepository("LiteralInteger89", DelegationConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__result_LiteralInteger89);
							AddToElementRepository("LiteralInteger90", DelegationConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__result_LiteralInteger90);
							AddToElementRepository("LiteralUnlimitedNatural91", DelegationConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__result_LiteralUnlimitedNatural91);
						AddToElementRepository("target", DelegationConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__target);
							AddToElementRepository("LiteralInteger92", DelegationConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__target_LiteralInteger92);
							AddToElementRepository("LiteralUnlimitedNatural93", DelegationConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__target_LiteralUnlimitedNatural93);
					AddToElementRepository("Create A_Array_Pattern", DelegationConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern);
						AddToElementRepository("result", DelegationConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result);
							AddToElementRepository("LiteralInteger94", DelegationConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result_LiteralInteger94);
							AddToElementRepository("LiteralUnlimitedNatural95", DelegationConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result_LiteralUnlimitedNatural95);
					AddToElementRepository("ObjectFlow96", DelegationConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow96);
						AddToElementRepository("LiteralInteger97", DelegationConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow96_LiteralInteger97);
						AddToElementRepository("LiteralBoolean98", DelegationConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow96_LiteralBoolean98);
					AddToElementRepository("a_Array_Pattern", DelegationConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern);
					AddToElementRepository("ObjectFlow99", DelegationConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow99);
						AddToElementRepository("LiteralBoolean100", DelegationConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow99_LiteralBoolean100);
						AddToElementRepository("LiteralInteger101", DelegationConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow99_LiteralInteger101);
					AddToElementRepository("a_Array_Pattern_node", DelegationConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern_node);
						AddToElementRepository("LiteralInteger102", DelegationConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern_node_LiteralInteger102);
				AddToElementRepository("assert_A_Unconnected_Pattern", DelegationConnectors_P_P_assert_A_Unconnected_Pattern);
					AddToElementRepository("a_Unconnected_Pattern_node", DelegationConnectors_P_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node);
						AddToElementRepository("LiteralInteger103", DelegationConnectors_P_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node_LiteralInteger103);
					AddToElementRepository("writeLine", DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine);
						AddToElementRepository("value", DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_value);
							AddToElementRepository("LiteralUnlimitedNatural104", DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_value_LiteralUnlimitedNatural104);
							AddToElementRepository("LiteralInteger105", DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_value_LiteralInteger105);
							AddToElementRepository("LiteralInteger106", DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_value_LiteralInteger106);
						AddToElementRepository("errorStatus", DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_errorStatus);
							AddToElementRepository("LiteralInteger107", DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_errorStatus_LiteralInteger107);
							AddToElementRepository("LiteralInteger108", DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_errorStatus_LiteralInteger108);
							AddToElementRepository("LiteralUnlimitedNatural109", DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural109);
					AddToElementRepository("a_Unconnected_Pattern", DelegationConnectors_P_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern);
					AddToElementRepository("ObjectFlow110", DelegationConnectors_P_P_assert_A_Unconnected_Pattern_ObjectFlow110);
						AddToElementRepository("LiteralBoolean111", DelegationConnectors_P_P_assert_A_Unconnected_Pattern_ObjectFlow110_LiteralBoolean111);
						AddToElementRepository("LiteralInteger112", DelegationConnectors_P_P_assert_A_Unconnected_Pattern_ObjectFlow110_LiteralInteger112);
					AddToElementRepository("message", DelegationConnectors_P_P_assert_A_Unconnected_Pattern_message);
						AddToElementRepository("result", DelegationConnectors_P_P_assert_A_Unconnected_Pattern_message_result);
							AddToElementRepository("LiteralInteger113", DelegationConnectors_P_P_assert_A_Unconnected_Pattern_message_result_LiteralInteger113);
							AddToElementRepository("LiteralUnlimitedNatural114", DelegationConnectors_P_P_assert_A_Unconnected_Pattern_message_result_LiteralUnlimitedNatural114);
						AddToElementRepository("LiteralString115", DelegationConnectors_P_P_assert_A_Unconnected_Pattern_message_LiteralString115);
				AddToElementRepository("A_Array_Pattern", DelegationConnectors_P_P_A_Array_Pattern);
					AddToElementRepository("Comment116", DelegationConnectors_P_P_A_Array_Pattern_Comment116);
					AddToElementRepository("r", DelegationConnectors_P_P_A_Array_Pattern_r);
						AddToElementRepository("ConnectorEnd117", DelegationConnectors_P_P_A_Array_Pattern_r_ConnectorEnd117);
							AddToElementRepository("LiteralUnlimitedNatural118", DelegationConnectors_P_P_A_Array_Pattern_r_ConnectorEnd117_LiteralUnlimitedNatural118);
						AddToElementRepository("ConnectorEnd119", DelegationConnectors_P_P_A_Array_Pattern_r_ConnectorEnd119);
							AddToElementRepository("LiteralUnlimitedNatural120", DelegationConnectors_P_P_A_Array_Pattern_r_ConnectorEnd119_LiteralUnlimitedNatural120);
					AddToElementRepository("b", DelegationConnectors_P_P_A_Array_Pattern_b);
						AddToElementRepository("LiteralUnlimitedNatural121", DelegationConnectors_P_P_A_Array_Pattern_b_LiteralUnlimitedNatural121);
						AddToElementRepository("LiteralInteger122", DelegationConnectors_P_P_A_Array_Pattern_b_LiteralInteger122);
					AddToElementRepository("A_Array_Pattern_A_Array_Pattern", DelegationConnectors_P_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern);
						AddToElementRepository("result", DelegationConnectors_P_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result);
					AddToElementRepository("p", DelegationConnectors_P_P_A_Array_Pattern_p);
						AddToElementRepository("LiteralInteger123", DelegationConnectors_P_P_A_Array_Pattern_p_LiteralInteger123);
						AddToElementRepository("LiteralUnlimitedNatural124", DelegationConnectors_P_P_A_Array_Pattern_p_LiteralUnlimitedNatural124);
				AddToElementRepository("R", DelegationConnectors_P_P_R);
					AddToElementRepository("x", DelegationConnectors_P_P_R_x);
						AddToElementRepository("LiteralInteger125", DelegationConnectors_P_P_R_x_LiteralInteger125);
						AddToElementRepository("LiteralUnlimitedNatural126", DelegationConnectors_P_P_R_x_LiteralUnlimitedNatural126);
					AddToElementRepository("y", DelegationConnectors_P_P_R_y);
						AddToElementRepository("LiteralInteger127", DelegationConnectors_P_P_R_y_LiteralInteger127);
						AddToElementRepository("LiteralUnlimitedNatural128", DelegationConnectors_P_P_R_y_LiteralUnlimitedNatural128);
				AddToElementRepository("A_Unconnected_Pattern", DelegationConnectors_P_P_A_Unconnected_Pattern);
					AddToElementRepository("p", DelegationConnectors_P_P_A_Unconnected_Pattern_p);
						AddToElementRepository("LiteralInteger129", DelegationConnectors_P_P_A_Unconnected_Pattern_p_LiteralInteger129);
						AddToElementRepository("LiteralUnlimitedNatural130", DelegationConnectors_P_P_A_Unconnected_Pattern_p_LiteralUnlimitedNatural130);
					AddToElementRepository("A_Unconnected_Pattern_A_Unconnected_Pattern", DelegationConnectors_P_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern);
						AddToElementRepository("result", DelegationConnectors_P_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result);
					AddToElementRepository("b", DelegationConnectors_P_P_A_Unconnected_Pattern_b);
						AddToElementRepository("LiteralInteger131", DelegationConnectors_P_P_A_Unconnected_Pattern_b_LiteralInteger131);
						AddToElementRepository("LiteralUnlimitedNatural132", DelegationConnectors_P_P_A_Unconnected_Pattern_b_LiteralUnlimitedNatural132);
					AddToElementRepository("r", DelegationConnectors_P_P_A_Unconnected_Pattern_r);
						AddToElementRepository("ConnectorEnd133", DelegationConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd133);
							AddToElementRepository("LiteralInteger134", DelegationConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd133_LiteralInteger134);
							AddToElementRepository("LiteralUnlimitedNatural135", DelegationConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd133_LiteralUnlimitedNatural135);
						AddToElementRepository("ConnectorEnd136", DelegationConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd136);
							AddToElementRepository("LiteralUnlimitedNatural137", DelegationConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd136_LiteralUnlimitedNatural137);
							AddToElementRepository("LiteralInteger138", DelegationConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd136_LiteralInteger138);
					AddToElementRepository("Comment139", DelegationConnectors_P_P_A_Unconnected_Pattern_Comment139);
				AddToElementRepository("I", DelegationConnectors_P_P_I);
				AddToElementRepository("instantiate_A_Empty_Pattern", DelegationConnectors_P_P_instantiate_A_Empty_Pattern);
					AddToElementRepository("ObjectFlow140", DelegationConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow140);
						AddToElementRepository("LiteralInteger141", DelegationConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow140_LiteralInteger141);
						AddToElementRepository("LiteralBoolean142", DelegationConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow140_LiteralBoolean142);
					AddToElementRepository("Create A_Empty_Pattern", DelegationConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern);
						AddToElementRepository("result", DelegationConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result);
							AddToElementRepository("LiteralInteger143", DelegationConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result_LiteralInteger143);
							AddToElementRepository("LiteralUnlimitedNatural144", DelegationConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result_LiteralUnlimitedNatural144);
					AddToElementRepository("a_Empty_Pattern_node", DelegationConnectors_P_P_instantiate_A_Empty_Pattern_a_Empty_Pattern_node);
					AddToElementRepository("a_Empty_Pattern", DelegationConnectors_P_P_instantiate_A_Empty_Pattern_a_Empty_Pattern);
					AddToElementRepository("ObjectFlow145", DelegationConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow145);
						AddToElementRepository("LiteralBoolean146", DelegationConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow145_LiteralBoolean146);
						AddToElementRepository("LiteralInteger147", DelegationConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow145_LiteralInteger147);
					AddToElementRepository("A_Empty_Pattern()", DelegationConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern_);
						AddToElementRepository("target", DelegationConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target);
							AddToElementRepository("LiteralUnlimitedNatural148", DelegationConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target_LiteralUnlimitedNatural148);
							AddToElementRepository("LiteralInteger149", DelegationConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target_LiteralInteger149);
						AddToElementRepository("result", DelegationConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result);
							AddToElementRepository("LiteralInteger150", DelegationConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result_LiteralInteger150);
							AddToElementRepository("LiteralInteger151", DelegationConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result_LiteralInteger151);
							AddToElementRepository("LiteralUnlimitedNatural152", DelegationConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result_LiteralUnlimitedNatural152);
				AddToElementRepository("assert_A_Array_Pattern", DelegationConnectors_P_P_assert_A_Array_Pattern);
					AddToElementRepository("ObjectFlow153", DelegationConnectors_P_P_assert_A_Array_Pattern_ObjectFlow153);
						AddToElementRepository("LiteralBoolean154", DelegationConnectors_P_P_assert_A_Array_Pattern_ObjectFlow153_LiteralBoolean154);
						AddToElementRepository("LiteralInteger155", DelegationConnectors_P_P_assert_A_Array_Pattern_ObjectFlow153_LiteralInteger155);
					AddToElementRepository("message", DelegationConnectors_P_P_assert_A_Array_Pattern_message);
						AddToElementRepository("result", DelegationConnectors_P_P_assert_A_Array_Pattern_message_result);
							AddToElementRepository("LiteralInteger156", DelegationConnectors_P_P_assert_A_Array_Pattern_message_result_LiteralInteger156);
							AddToElementRepository("LiteralUnlimitedNatural157", DelegationConnectors_P_P_assert_A_Array_Pattern_message_result_LiteralUnlimitedNatural157);
						AddToElementRepository("LiteralString158", DelegationConnectors_P_P_assert_A_Array_Pattern_message_LiteralString158);
					AddToElementRepository("writeLine", DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine);
						AddToElementRepository("errorStatus", DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine_errorStatus);
							AddToElementRepository("LiteralUnlimitedNatural159", DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural159);
							AddToElementRepository("LiteralInteger160", DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine_errorStatus_LiteralInteger160);
							AddToElementRepository("LiteralInteger161", DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine_errorStatus_LiteralInteger161);
						AddToElementRepository("value", DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine_value);
							AddToElementRepository("LiteralInteger162", DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine_value_LiteralInteger162);
							AddToElementRepository("LiteralUnlimitedNatural163", DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine_value_LiteralUnlimitedNatural163);
							AddToElementRepository("LiteralInteger164", DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine_value_LiteralInteger164);
					AddToElementRepository("a_Array_Pattern", DelegationConnectors_P_P_assert_A_Array_Pattern_a_Array_Pattern);
					AddToElementRepository("a_Array_Pattern_node", DelegationConnectors_P_P_assert_A_Array_Pattern_a_Array_Pattern_node);
						AddToElementRepository("LiteralInteger165", DelegationConnectors_P_P_assert_A_Array_Pattern_a_Array_Pattern_node_LiteralInteger165);
				AddToElementRepository("A_Empty_Pattern", DelegationConnectors_P_P_A_Empty_Pattern);
					AddToElementRepository("b", DelegationConnectors_P_P_A_Empty_Pattern_b);
						AddToElementRepository("LiteralInteger166", DelegationConnectors_P_P_A_Empty_Pattern_b_LiteralInteger166);
						AddToElementRepository("LiteralUnlimitedNatural167", DelegationConnectors_P_P_A_Empty_Pattern_b_LiteralUnlimitedNatural167);
					AddToElementRepository("A_Empty_Pattern_A_Empty_Pattern", DelegationConnectors_P_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern);
						AddToElementRepository("result", DelegationConnectors_P_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result);
					AddToElementRepository("Comment168", DelegationConnectors_P_P_A_Empty_Pattern_Comment168);
					AddToElementRepository("p", DelegationConnectors_P_P_A_Empty_Pattern_p);
						AddToElementRepository("LiteralInteger169", DelegationConnectors_P_P_A_Empty_Pattern_p_LiteralInteger169);
						AddToElementRepository("LiteralUnlimitedNatural170", DelegationConnectors_P_P_A_Empty_Pattern_p_LiteralUnlimitedNatural170);
					AddToElementRepository("r", DelegationConnectors_P_P_A_Empty_Pattern_r);
						AddToElementRepository("ConnectorEnd171", DelegationConnectors_P_P_A_Empty_Pattern_r_ConnectorEnd171);
							AddToElementRepository("LiteralUnlimitedNatural172", DelegationConnectors_P_P_A_Empty_Pattern_r_ConnectorEnd171_LiteralUnlimitedNatural172);
						AddToElementRepository("ConnectorEnd173", DelegationConnectors_P_P_A_Empty_Pattern_r_ConnectorEnd173);
							AddToElementRepository("LiteralUnlimitedNatural174", DelegationConnectors_P_P_A_Empty_Pattern_r_ConnectorEnd173_LiteralUnlimitedNatural174);
				AddToElementRepository("assert_A_Empty_Pattern", DelegationConnectors_P_P_assert_A_Empty_Pattern);
					AddToElementRepository("message", DelegationConnectors_P_P_assert_A_Empty_Pattern_message);
						AddToElementRepository("result", DelegationConnectors_P_P_assert_A_Empty_Pattern_message_result);
							AddToElementRepository("LiteralUnlimitedNatural175", DelegationConnectors_P_P_assert_A_Empty_Pattern_message_result_LiteralUnlimitedNatural175);
							AddToElementRepository("LiteralInteger176", DelegationConnectors_P_P_assert_A_Empty_Pattern_message_result_LiteralInteger176);
						AddToElementRepository("LiteralString177", DelegationConnectors_P_P_assert_A_Empty_Pattern_message_LiteralString177);
					AddToElementRepository("ObjectFlow178", DelegationConnectors_P_P_assert_A_Empty_Pattern_ObjectFlow178);
						AddToElementRepository("LiteralInteger179", DelegationConnectors_P_P_assert_A_Empty_Pattern_ObjectFlow178_LiteralInteger179);
						AddToElementRepository("LiteralBoolean180", DelegationConnectors_P_P_assert_A_Empty_Pattern_ObjectFlow178_LiteralBoolean180);
					AddToElementRepository("writeLine", DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine);
						AddToElementRepository("errorStatus", DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine_errorStatus);
							AddToElementRepository("LiteralUnlimitedNatural181", DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural181);
							AddToElementRepository("LiteralInteger182", DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine_errorStatus_LiteralInteger182);
							AddToElementRepository("LiteralInteger183", DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine_errorStatus_LiteralInteger183);
						AddToElementRepository("value", DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine_value);
							AddToElementRepository("LiteralInteger184", DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine_value_LiteralInteger184);
							AddToElementRepository("LiteralInteger185", DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine_value_LiteralInteger185);
							AddToElementRepository("LiteralUnlimitedNatural186", DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine_value_LiteralUnlimitedNatural186);
					AddToElementRepository("a_Empty_Pattern_node", DelegationConnectors_P_P_assert_A_Empty_Pattern_a_Empty_Pattern_node);
						AddToElementRepository("LiteralInteger187", DelegationConnectors_P_P_assert_A_Empty_Pattern_a_Empty_Pattern_node_LiteralInteger187);
					AddToElementRepository("a_Empty_Pattern", DelegationConnectors_P_P_assert_A_Empty_Pattern_a_Empty_Pattern);

			// Initialize public members
			/*
			 * Model DelegationConnectors_P_P
			 */
			DelegationConnectors_P_P.SetName("DelegationConnectors_P_P");
			DelegationConnectors_P_P.SetVisibility(VisibilityKind.public_);
				// Activity assert_A_Star_Pattern
				DelegationConnectors_P_P_assert_A_Star_Pattern.SetName("assert_A_Star_Pattern");
				DelegationConnectors_P_P_assert_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Star_Pattern
					DelegationConnectors_P_P_assert_A_Star_Pattern_a_Star_Pattern.SetName("a_Star_Pattern");
					DelegationConnectors_P_P_assert_A_Star_Pattern_a_Star_Pattern.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_assert_A_Star_Pattern_a_Star_Pattern.SetType(DelegationConnectors_P_P_A_Star_Pattern);
				DelegationConnectors_P_P_assert_A_Star_Pattern.AddOwnedParameter(DelegationConnectors_P_P_assert_A_Star_Pattern_a_Star_Pattern);
					// CallBehaviorAction writeLine
					DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine.SetName("writeLine");
					DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine.SetVisibility(VisibilityKind.public_);
					
						// OutputPin errorStatus
						DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine_errorStatus.SetName("errorStatus");
						DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine_errorStatus.SetVisibility(VisibilityKind.public_);
						
						DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine_errorStatus.SetLower(0);
					DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine.AddResult(DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine_errorStatus);
					DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
						// InputPin value
						DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine_value.SetName("value");
						DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine_value.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine.AddArgument(DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine_value);
				DelegationConnectors_P_P_assert_A_Star_Pattern.AddNode(DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine);
					// ValueSpecificationAction message
					DelegationConnectors_P_P_assert_A_Star_Pattern_message.SetName("message");
					DelegationConnectors_P_P_assert_A_Star_Pattern_message.SetVisibility(VisibilityKind.public_);
						// LiteralString LiteralString8
						DelegationConnectors_P_P_assert_A_Star_Pattern_message_LiteralString8.SetName("LiteralString8");
						DelegationConnectors_P_P_assert_A_Star_Pattern_message_LiteralString8.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_assert_A_Star_Pattern_message_LiteralString8.SetValue("Assertion currently not implemented for A_Star_Pattern.");
					DelegationConnectors_P_P_assert_A_Star_Pattern_message.SetValue(DelegationConnectors_P_P_assert_A_Star_Pattern_message_LiteralString8);
						// OutputPin result
						DelegationConnectors_P_P_assert_A_Star_Pattern_message_result.SetName("result");
						DelegationConnectors_P_P_assert_A_Star_Pattern_message_result.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_assert_A_Star_Pattern_message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					DelegationConnectors_P_P_assert_A_Star_Pattern_message.SetResult(DelegationConnectors_P_P_assert_A_Star_Pattern_message_result);
				DelegationConnectors_P_P_assert_A_Star_Pattern.AddNode(DelegationConnectors_P_P_assert_A_Star_Pattern_message);
					// ActivityParameterNode a_Star_Pattern_node
					DelegationConnectors_P_P_assert_A_Star_Pattern_a_Star_Pattern_node.SetName("a_Star_Pattern_node");
					DelegationConnectors_P_P_assert_A_Star_Pattern_a_Star_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_assert_A_Star_Pattern_a_Star_Pattern_node.SetParameter(DelegationConnectors_P_P_assert_A_Star_Pattern_a_Star_Pattern);
				DelegationConnectors_P_P_assert_A_Star_Pattern.AddNode(DelegationConnectors_P_P_assert_A_Star_Pattern_a_Star_Pattern_node);
					// ObjectFlow ObjectFlow9 from result to value
					DelegationConnectors_P_P_assert_A_Star_Pattern_ObjectFlow9.SetName("ObjectFlow9");
					DelegationConnectors_P_P_assert_A_Star_Pattern_ObjectFlow9.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_assert_A_Star_Pattern_ObjectFlow9.SetSource(DelegationConnectors_P_P_assert_A_Star_Pattern_message_result);
					DelegationConnectors_P_P_assert_A_Star_Pattern_ObjectFlow9.SetTarget(DelegationConnectors_P_P_assert_A_Star_Pattern_writeLine_value);
						// LiteralBoolean LiteralBoolean10
						DelegationConnectors_P_P_assert_A_Star_Pattern_ObjectFlow9_LiteralBoolean10.SetName("LiteralBoolean10");
						DelegationConnectors_P_P_assert_A_Star_Pattern_ObjectFlow9_LiteralBoolean10.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_assert_A_Star_Pattern_ObjectFlow9_LiteralBoolean10.SetValue(true);
					DelegationConnectors_P_P_assert_A_Star_Pattern_ObjectFlow9.SetGuard(DelegationConnectors_P_P_assert_A_Star_Pattern_ObjectFlow9_LiteralBoolean10);
				DelegationConnectors_P_P_assert_A_Star_Pattern.AddEdge(DelegationConnectors_P_P_assert_A_Star_Pattern_ObjectFlow9);
			DelegationConnectors_P_P.AddPackagedElement(DelegationConnectors_P_P_assert_A_Star_Pattern);
				// Activity instantiate_A_Star_Pattern
				DelegationConnectors_P_P_instantiate_A_Star_Pattern.SetName("instantiate_A_Star_Pattern");
				DelegationConnectors_P_P_instantiate_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Star_Pattern
					DelegationConnectors_P_P_instantiate_A_Star_Pattern_a_Star_Pattern.SetName("a_Star_Pattern");
					DelegationConnectors_P_P_instantiate_A_Star_Pattern_a_Star_Pattern.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_instantiate_A_Star_Pattern_a_Star_Pattern.SetType(DelegationConnectors_P_P_A_Star_Pattern);
					DelegationConnectors_P_P_instantiate_A_Star_Pattern_a_Star_Pattern.SetDirection(ParameterDirectionKind.return_);
				DelegationConnectors_P_P_instantiate_A_Star_Pattern.AddOwnedParameter(DelegationConnectors_P_P_instantiate_A_Star_Pattern_a_Star_Pattern);
					// CallOperationAction A_Star_Pattern()
					DelegationConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern_.SetName("A_Star_Pattern()");
					DelegationConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						DelegationConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__result.SetName("result");
						DelegationConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__result.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__result.SetType(DelegationConnectors_P_P_A_Star_Pattern);
					DelegationConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern_.AddResult(DelegationConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__result);
					DelegationConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern_.SetOperation(DelegationConnectors_P_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern);
						// InputPin target
						DelegationConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__target.SetName("target");
						DelegationConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__target.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__target.SetType(DelegationConnectors_P_P_A_Star_Pattern);
					DelegationConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern_.SetTarget(DelegationConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__target);
				DelegationConnectors_P_P_instantiate_A_Star_Pattern.AddNode(DelegationConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern_);
					// ActivityParameterNode a_Star_Pattern_node
					DelegationConnectors_P_P_instantiate_A_Star_Pattern_a_Star_Pattern_node.SetName("a_Star_Pattern_node");
					DelegationConnectors_P_P_instantiate_A_Star_Pattern_a_Star_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_instantiate_A_Star_Pattern_a_Star_Pattern_node.SetParameter(DelegationConnectors_P_P_instantiate_A_Star_Pattern_a_Star_Pattern);
				DelegationConnectors_P_P_instantiate_A_Star_Pattern.AddNode(DelegationConnectors_P_P_instantiate_A_Star_Pattern_a_Star_Pattern_node);
					// CreateObjectAction Create A_Star_Pattern
					DelegationConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern.SetName("Create A_Star_Pattern");
					DelegationConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern.SetClassifier(DelegationConnectors_P_P_A_Star_Pattern);
						// OutputPin result
						DelegationConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result.SetName("result");
						DelegationConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result.SetType(DelegationConnectors_P_P_A_Star_Pattern);
					DelegationConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern.SetResult(DelegationConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result);
				DelegationConnectors_P_P_instantiate_A_Star_Pattern.AddNode(DelegationConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern);
					// ObjectFlow ObjectFlow18 from result to a_Star_Pattern_node
					DelegationConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow18.SetName("ObjectFlow18");
					DelegationConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow18.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow18.SetSource(DelegationConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__result);
					DelegationConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow18.SetTarget(DelegationConnectors_P_P_instantiate_A_Star_Pattern_a_Star_Pattern_node);
						// LiteralBoolean LiteralBoolean19
						DelegationConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow18_LiteralBoolean19.SetName("LiteralBoolean19");
						DelegationConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow18_LiteralBoolean19.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow18_LiteralBoolean19.SetValue(true);
					DelegationConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow18.SetGuard(DelegationConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow18_LiteralBoolean19);
				DelegationConnectors_P_P_instantiate_A_Star_Pattern.AddEdge(DelegationConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow18);
					// ObjectFlow ObjectFlow21 from result to target
					DelegationConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow21.SetName("ObjectFlow21");
					DelegationConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow21.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow21.SetSource(DelegationConnectors_P_P_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result);
					DelegationConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow21.SetTarget(DelegationConnectors_P_P_instantiate_A_Star_Pattern_A_Star_Pattern__target);
						// LiteralBoolean LiteralBoolean22
						DelegationConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow21_LiteralBoolean22.SetName("LiteralBoolean22");
						DelegationConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow21_LiteralBoolean22.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow21_LiteralBoolean22.SetValue(true);
					DelegationConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow21.SetGuard(DelegationConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow21_LiteralBoolean22);
				DelegationConnectors_P_P_instantiate_A_Star_Pattern.AddEdge(DelegationConnectors_P_P_instantiate_A_Star_Pattern_ObjectFlow21);
			DelegationConnectors_P_P.AddPackagedElement(DelegationConnectors_P_P_instantiate_A_Star_Pattern);
				// Class A_Star_Pattern
				DelegationConnectors_P_P_A_Star_Pattern.SetName("A_Star_Pattern");
				DelegationConnectors_P_P_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Property b
					DelegationConnectors_P_P_A_Star_Pattern_b.SetName("b");
					DelegationConnectors_P_P_A_Star_Pattern_b.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_P_A_Star_Pattern_b.SetUpper(-1);
					DelegationConnectors_P_P_A_Star_Pattern_b.SetLower(4);
					DelegationConnectors_P_P_A_Star_Pattern_b.SetType(DelegationConnectors_P_P_B);
					DelegationConnectors_P_P_A_Star_Pattern_b.SetAggregation(AggregationKind.composite);
				DelegationConnectors_P_P_A_Star_Pattern.AddOwnedAttribute(DelegationConnectors_P_P_A_Star_Pattern_b);
					// Port p
					DelegationConnectors_P_P_A_Star_Pattern_p.SetName("p");
					DelegationConnectors_P_P_A_Star_Pattern_p.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_P_A_Star_Pattern_p.SetUpper(-1);
					DelegationConnectors_P_P_A_Star_Pattern_p.SetLower(3);
					DelegationConnectors_P_P_A_Star_Pattern_p.SetType(DelegationConnectors_P_P_IImpl);
					DelegationConnectors_P_P_A_Star_Pattern_p.SetAggregation(AggregationKind.composite);
					DelegationConnectors_P_P_A_Star_Pattern_p.isService = true;
					DelegationConnectors_P_P_A_Star_Pattern_p.AddProvided(DelegationConnectors_P_P_I);
				DelegationConnectors_P_P_A_Star_Pattern.AddOwnedAttribute(DelegationConnectors_P_P_A_Star_Pattern_p);
				
				DelegationConnectors_P_P_A_Star_Pattern_r.SetName("r");
					DelegationConnectors_P_P_A_Star_Pattern_r.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_A_Star_Pattern_r_ConnectorEnd33.SetUpper(-1);
						DelegationConnectors_P_P_A_Star_Pattern_r_ConnectorEnd33.SetLower(3);
						DelegationConnectors_P_P_A_Star_Pattern_r_ConnectorEnd33.SetRole(DelegationConnectors_P_P_A_Star_Pattern_p);
						
					DelegationConnectors_P_P_A_Star_Pattern_r.AddEnd(DelegationConnectors_P_P_A_Star_Pattern_r_ConnectorEnd33);
						DelegationConnectors_P_P_A_Star_Pattern_r_ConnectorEnd30.SetUpper(-1);
						DelegationConnectors_P_P_A_Star_Pattern_r_ConnectorEnd30.SetLower(4);
						DelegationConnectors_P_P_A_Star_Pattern_r_ConnectorEnd30.SetRole(DelegationConnectors_P_P_A_Star_Pattern_b);
						
					DelegationConnectors_P_P_A_Star_Pattern_r.AddEnd(DelegationConnectors_P_P_A_Star_Pattern_r_ConnectorEnd30);
					DelegationConnectors_P_P_A_Star_Pattern_r.SetType(DelegationConnectors_P_P_R);
				DelegationConnectors_P_P_A_Star_Pattern.AddOwnedConnector(DelegationConnectors_P_P_A_Star_Pattern_r);
					// Operation A_Star_Pattern_A_Star_Pattern
					DelegationConnectors_P_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern.SetName("A_Star_Pattern_A_Star_Pattern");
					DelegationConnectors_P_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
						// Parameter result
						DelegationConnectors_P_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result.SetName("result");
						DelegationConnectors_P_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result.SetVisibility(VisibilityKind.public_);
						
						DelegationConnectors_P_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result.SetType(DelegationConnectors_P_P_A_Star_Pattern);
						DelegationConnectors_P_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result.SetDirection(ParameterDirectionKind.return_);
					DelegationConnectors_P_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern.AddOwnedParameter(DelegationConnectors_P_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result);
					DelegationConnectors_P_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				DelegationConnectors_P_P_A_Star_Pattern.AddOwnedOperation(DelegationConnectors_P_P_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern);
			DelegationConnectors_P_P.AddPackagedElement(DelegationConnectors_P_P_A_Star_Pattern);
				// Class B
				DelegationConnectors_P_P_B.SetName("B");
				DelegationConnectors_P_P_B.SetVisibility(VisibilityKind.public_);
				DelegationConnectors_P_P_B_I_Realization.SetName("I_Realization");
					DelegationConnectors_P_P_B_I_Realization.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_P_B_I_Realization.SetContract(DelegationConnectors_P_P_I);
					
				DelegationConnectors_P_P_B.AddInterfaceRealization(DelegationConnectors_P_P_B_I_Realization);
			DelegationConnectors_P_P.AddPackagedElement(DelegationConnectors_P_P_B);
				// Activity main
				DelegationConnectors_P_P_main.SetName("main");
				DelegationConnectors_P_P_main.SetVisibility(VisibilityKind.public_);
					// CallBehaviorAction assert_A_Empty_Pattern
					DelegationConnectors_P_P_main_assert_A_Empty_Pattern.SetName("assert_A_Empty_Pattern");
					DelegationConnectors_P_P_main_assert_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_P_main_assert_A_Empty_Pattern.SetBehavior(DelegationConnectors_P_P_assert_A_Empty_Pattern);
						// InputPin a_Empty_Pattern
						DelegationConnectors_P_P_main_assert_A_Empty_Pattern_a_Empty_Pattern.SetName("a_Empty_Pattern");
						DelegationConnectors_P_P_main_assert_A_Empty_Pattern_a_Empty_Pattern.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_main_assert_A_Empty_Pattern_a_Empty_Pattern.SetType(DelegationConnectors_P_P_A_Empty_Pattern);
					DelegationConnectors_P_P_main_assert_A_Empty_Pattern.AddArgument(DelegationConnectors_P_P_main_assert_A_Empty_Pattern_a_Empty_Pattern);
				DelegationConnectors_P_P_main.AddNode(DelegationConnectors_P_P_main_assert_A_Empty_Pattern);
					// CallBehaviorAction assert_A_Array_Pattern
					DelegationConnectors_P_P_main_assert_A_Array_Pattern.SetName("assert_A_Array_Pattern");
					DelegationConnectors_P_P_main_assert_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_P_main_assert_A_Array_Pattern.SetBehavior(DelegationConnectors_P_P_assert_A_Array_Pattern);
						// InputPin a_Array_Pattern
						DelegationConnectors_P_P_main_assert_A_Array_Pattern_a_Array_Pattern.SetName("a_Array_Pattern");
						DelegationConnectors_P_P_main_assert_A_Array_Pattern_a_Array_Pattern.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_main_assert_A_Array_Pattern_a_Array_Pattern.SetType(DelegationConnectors_P_P_A_Array_Pattern);
					DelegationConnectors_P_P_main_assert_A_Array_Pattern.AddArgument(DelegationConnectors_P_P_main_assert_A_Array_Pattern_a_Array_Pattern);
				DelegationConnectors_P_P_main.AddNode(DelegationConnectors_P_P_main_assert_A_Array_Pattern);
					// CallBehaviorAction instantiate_A_Array_Pattern
					DelegationConnectors_P_P_main_instantiate_A_Array_Pattern.SetName("instantiate_A_Array_Pattern");
					DelegationConnectors_P_P_main_instantiate_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
					
						// OutputPin a_Array_Pattern
						DelegationConnectors_P_P_main_instantiate_A_Array_Pattern_a_Array_Pattern.SetName("a_Array_Pattern");
						DelegationConnectors_P_P_main_instantiate_A_Array_Pattern_a_Array_Pattern.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_main_instantiate_A_Array_Pattern_a_Array_Pattern.SetType(DelegationConnectors_P_P_A_Array_Pattern);
					DelegationConnectors_P_P_main_instantiate_A_Array_Pattern.AddResult(DelegationConnectors_P_P_main_instantiate_A_Array_Pattern_a_Array_Pattern);
					DelegationConnectors_P_P_main_instantiate_A_Array_Pattern.SetBehavior(DelegationConnectors_P_P_instantiate_A_Array_Pattern);
				DelegationConnectors_P_P_main.AddNode(DelegationConnectors_P_P_main_instantiate_A_Array_Pattern);
					// CallBehaviorAction assert_A_Unconnected_Pattern
					DelegationConnectors_P_P_main_assert_A_Unconnected_Pattern.SetName("assert_A_Unconnected_Pattern");
					DelegationConnectors_P_P_main_assert_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_P_main_assert_A_Unconnected_Pattern.SetBehavior(DelegationConnectors_P_P_assert_A_Unconnected_Pattern);
						// InputPin a_Unconnected_Pattern
						DelegationConnectors_P_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern.SetName("a_Unconnected_Pattern");
						DelegationConnectors_P_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern.SetType(DelegationConnectors_P_P_A_Unconnected_Pattern);
					DelegationConnectors_P_P_main_assert_A_Unconnected_Pattern.AddArgument(DelegationConnectors_P_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern);
				DelegationConnectors_P_P_main.AddNode(DelegationConnectors_P_P_main_assert_A_Unconnected_Pattern);
					// CallBehaviorAction instantiate_A_Unconnected_Pattern
					DelegationConnectors_P_P_main_instantiate_A_Unconnected_Pattern.SetName("instantiate_A_Unconnected_Pattern");
					DelegationConnectors_P_P_main_instantiate_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
					
						// OutputPin a_Unconnected_Pattern
						DelegationConnectors_P_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetName("a_Unconnected_Pattern");
						DelegationConnectors_P_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetType(DelegationConnectors_P_P_A_Unconnected_Pattern);
					DelegationConnectors_P_P_main_instantiate_A_Unconnected_Pattern.AddResult(DelegationConnectors_P_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern);
					DelegationConnectors_P_P_main_instantiate_A_Unconnected_Pattern.SetBehavior(DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern);
				DelegationConnectors_P_P_main.AddNode(DelegationConnectors_P_P_main_instantiate_A_Unconnected_Pattern);
					// CallBehaviorAction instantiate_A_Star_Pattern
					DelegationConnectors_P_P_main_instantiate_A_Star_Pattern.SetName("instantiate_A_Star_Pattern");
					DelegationConnectors_P_P_main_instantiate_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
					
						// OutputPin a_Star_Pattern
						DelegationConnectors_P_P_main_instantiate_A_Star_Pattern_a_Star_Pattern.SetName("a_Star_Pattern");
						DelegationConnectors_P_P_main_instantiate_A_Star_Pattern_a_Star_Pattern.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_main_instantiate_A_Star_Pattern_a_Star_Pattern.SetType(DelegationConnectors_P_P_A_Star_Pattern);
					DelegationConnectors_P_P_main_instantiate_A_Star_Pattern.AddResult(DelegationConnectors_P_P_main_instantiate_A_Star_Pattern_a_Star_Pattern);
					DelegationConnectors_P_P_main_instantiate_A_Star_Pattern.SetBehavior(DelegationConnectors_P_P_instantiate_A_Star_Pattern);
				DelegationConnectors_P_P_main.AddNode(DelegationConnectors_P_P_main_instantiate_A_Star_Pattern);
					// CallBehaviorAction instantiate_A_Empty_Pattern
					DelegationConnectors_P_P_main_instantiate_A_Empty_Pattern.SetName("instantiate_A_Empty_Pattern");
					DelegationConnectors_P_P_main_instantiate_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
					
						// OutputPin a_Empty_Pattern
						DelegationConnectors_P_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetName("a_Empty_Pattern");
						DelegationConnectors_P_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetType(DelegationConnectors_P_P_A_Empty_Pattern);
					DelegationConnectors_P_P_main_instantiate_A_Empty_Pattern.AddResult(DelegationConnectors_P_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern);
					DelegationConnectors_P_P_main_instantiate_A_Empty_Pattern.SetBehavior(DelegationConnectors_P_P_instantiate_A_Empty_Pattern);
				DelegationConnectors_P_P_main.AddNode(DelegationConnectors_P_P_main_instantiate_A_Empty_Pattern);
					// CallBehaviorAction assert_A_Star_Pattern
					DelegationConnectors_P_P_main_assert_A_Star_Pattern.SetName("assert_A_Star_Pattern");
					DelegationConnectors_P_P_main_assert_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_P_main_assert_A_Star_Pattern.SetBehavior(DelegationConnectors_P_P_assert_A_Star_Pattern);
						// InputPin a_Star_Pattern
						DelegationConnectors_P_P_main_assert_A_Star_Pattern_a_Star_Pattern.SetName("a_Star_Pattern");
						DelegationConnectors_P_P_main_assert_A_Star_Pattern_a_Star_Pattern.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_main_assert_A_Star_Pattern_a_Star_Pattern.SetType(DelegationConnectors_P_P_A_Star_Pattern);
					DelegationConnectors_P_P_main_assert_A_Star_Pattern.AddArgument(DelegationConnectors_P_P_main_assert_A_Star_Pattern_a_Star_Pattern);
				DelegationConnectors_P_P_main.AddNode(DelegationConnectors_P_P_main_assert_A_Star_Pattern);
					// ControlFlow ControlFlow37 from assert_A_Empty_Pattern to instantiate_A_Unconnected_Pattern
					DelegationConnectors_P_P_main_ControlFlow37.SetName("ControlFlow37");
					DelegationConnectors_P_P_main_ControlFlow37.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_main_ControlFlow37.SetSource(DelegationConnectors_P_P_main_assert_A_Empty_Pattern);
					DelegationConnectors_P_P_main_ControlFlow37.SetTarget(DelegationConnectors_P_P_main_instantiate_A_Unconnected_Pattern);
				DelegationConnectors_P_P_main.AddEdge(DelegationConnectors_P_P_main_ControlFlow37);
					// ObjectFlow ObjectFlow59 from a_Unconnected_Pattern to a_Unconnected_Pattern
					DelegationConnectors_P_P_main_ObjectFlow59.SetName("ObjectFlow59");
					DelegationConnectors_P_P_main_ObjectFlow59.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_main_ObjectFlow59.SetSource(DelegationConnectors_P_P_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern);
					DelegationConnectors_P_P_main_ObjectFlow59.SetTarget(DelegationConnectors_P_P_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern);
						// LiteralBoolean LiteralBoolean61
						DelegationConnectors_P_P_main_ObjectFlow59_LiteralBoolean61.SetName("LiteralBoolean61");
						DelegationConnectors_P_P_main_ObjectFlow59_LiteralBoolean61.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_main_ObjectFlow59_LiteralBoolean61.SetValue(true);
					DelegationConnectors_P_P_main_ObjectFlow59.SetGuard(DelegationConnectors_P_P_main_ObjectFlow59_LiteralBoolean61);
				DelegationConnectors_P_P_main.AddEdge(DelegationConnectors_P_P_main_ObjectFlow59);
					// ObjectFlow ObjectFlow41 from a_Star_Pattern to a_Star_Pattern
					DelegationConnectors_P_P_main_ObjectFlow41.SetName("ObjectFlow41");
					DelegationConnectors_P_P_main_ObjectFlow41.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_main_ObjectFlow41.SetSource(DelegationConnectors_P_P_main_instantiate_A_Star_Pattern_a_Star_Pattern);
					DelegationConnectors_P_P_main_ObjectFlow41.SetTarget(DelegationConnectors_P_P_main_assert_A_Star_Pattern_a_Star_Pattern);
						// LiteralBoolean LiteralBoolean43
						DelegationConnectors_P_P_main_ObjectFlow41_LiteralBoolean43.SetName("LiteralBoolean43");
						DelegationConnectors_P_P_main_ObjectFlow41_LiteralBoolean43.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_main_ObjectFlow41_LiteralBoolean43.SetValue(true);
					DelegationConnectors_P_P_main_ObjectFlow41.SetGuard(DelegationConnectors_P_P_main_ObjectFlow41_LiteralBoolean43);
				DelegationConnectors_P_P_main.AddEdge(DelegationConnectors_P_P_main_ObjectFlow41);
					// ObjectFlow ObjectFlow65 from a_Array_Pattern to a_Array_Pattern
					DelegationConnectors_P_P_main_ObjectFlow65.SetName("ObjectFlow65");
					DelegationConnectors_P_P_main_ObjectFlow65.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_main_ObjectFlow65.SetSource(DelegationConnectors_P_P_main_instantiate_A_Array_Pattern_a_Array_Pattern);
					DelegationConnectors_P_P_main_ObjectFlow65.SetTarget(DelegationConnectors_P_P_main_assert_A_Array_Pattern_a_Array_Pattern);
						// LiteralBoolean LiteralBoolean67
						DelegationConnectors_P_P_main_ObjectFlow65_LiteralBoolean67.SetName("LiteralBoolean67");
						DelegationConnectors_P_P_main_ObjectFlow65_LiteralBoolean67.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_main_ObjectFlow65_LiteralBoolean67.SetValue(true);
					DelegationConnectors_P_P_main_ObjectFlow65.SetGuard(DelegationConnectors_P_P_main_ObjectFlow65_LiteralBoolean67);
				DelegationConnectors_P_P_main.AddEdge(DelegationConnectors_P_P_main_ObjectFlow65);
					// ObjectFlow ObjectFlow68 from a_Empty_Pattern to a_Empty_Pattern
					DelegationConnectors_P_P_main_ObjectFlow68.SetName("ObjectFlow68");
					DelegationConnectors_P_P_main_ObjectFlow68.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_main_ObjectFlow68.SetSource(DelegationConnectors_P_P_main_instantiate_A_Empty_Pattern_a_Empty_Pattern);
					DelegationConnectors_P_P_main_ObjectFlow68.SetTarget(DelegationConnectors_P_P_main_assert_A_Empty_Pattern_a_Empty_Pattern);
						// LiteralBoolean LiteralBoolean70
						DelegationConnectors_P_P_main_ObjectFlow68_LiteralBoolean70.SetName("LiteralBoolean70");
						DelegationConnectors_P_P_main_ObjectFlow68_LiteralBoolean70.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_main_ObjectFlow68_LiteralBoolean70.SetValue(true);
					DelegationConnectors_P_P_main_ObjectFlow68.SetGuard(DelegationConnectors_P_P_main_ObjectFlow68_LiteralBoolean70);
				DelegationConnectors_P_P_main.AddEdge(DelegationConnectors_P_P_main_ObjectFlow68);
					// ControlFlow ControlFlow74 from assert_A_Unconnected_Pattern to instantiate_A_Array_Pattern
					DelegationConnectors_P_P_main_ControlFlow74.SetName("ControlFlow74");
					DelegationConnectors_P_P_main_ControlFlow74.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_main_ControlFlow74.SetSource(DelegationConnectors_P_P_main_assert_A_Unconnected_Pattern);
					DelegationConnectors_P_P_main_ControlFlow74.SetTarget(DelegationConnectors_P_P_main_instantiate_A_Array_Pattern);
				DelegationConnectors_P_P_main.AddEdge(DelegationConnectors_P_P_main_ControlFlow74);
					// ControlFlow ControlFlow75 from assert_A_Array_Pattern to instantiate_A_Star_Pattern
					DelegationConnectors_P_P_main_ControlFlow75.SetName("ControlFlow75");
					DelegationConnectors_P_P_main_ControlFlow75.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_main_ControlFlow75.SetSource(DelegationConnectors_P_P_main_assert_A_Array_Pattern);
					DelegationConnectors_P_P_main_ControlFlow75.SetTarget(DelegationConnectors_P_P_main_instantiate_A_Star_Pattern);
				DelegationConnectors_P_P_main.AddEdge(DelegationConnectors_P_P_main_ControlFlow75);
			DelegationConnectors_P_P.AddPackagedElement(DelegationConnectors_P_P_main);
				// Activity instantiate_A_Unconnected_Pattern
				DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern.SetName("instantiate_A_Unconnected_Pattern");
				DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Unconnected_Pattern
					DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetName("a_Unconnected_Pattern");
					DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetType(DelegationConnectors_P_P_A_Unconnected_Pattern);
					DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetDirection(ParameterDirectionKind.return_);
				DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern.AddOwnedParameter(DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern);
					// CallOperationAction A_Unconnected_Pattern()
					DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_.SetName("A_Unconnected_Pattern()");
					DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result.SetName("result");
						DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result.SetType(DelegationConnectors_P_P_A_Unconnected_Pattern);
					DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_.AddResult(DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result);
					DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_.SetOperation(DelegationConnectors_P_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern);
						// InputPin target
						DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target.SetName("target");
						DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target.SetType(DelegationConnectors_P_P_A_Unconnected_Pattern);
					DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_.SetTarget(DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target);
				DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern.AddNode(DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_);
					// CreateObjectAction Create A_Unconnected_Pattern
					DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern.SetName("Create A_Unconnected_Pattern");
					DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern.SetClassifier(DelegationConnectors_P_P_A_Unconnected_Pattern);
						// OutputPin result
						DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result.SetName("result");
						DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result.SetType(DelegationConnectors_P_P_A_Unconnected_Pattern);
					DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern.SetResult(DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result);
				DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern.AddNode(DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern);
					// ActivityParameterNode a_Unconnected_Pattern_node
					DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node.SetName("a_Unconnected_Pattern_node");
					DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node.SetParameter(DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern);
				DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern.AddNode(DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node);
					// ObjectFlow ObjectFlow81 from result to a_Unconnected_Pattern_node
					DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow81.SetName("ObjectFlow81");
					DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow81.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow81.SetSource(DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result);
					DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow81.SetTarget(DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node);
						// LiteralBoolean LiteralBoolean82
						DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow81_LiteralBoolean82.SetName("LiteralBoolean82");
						DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow81_LiteralBoolean82.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow81_LiteralBoolean82.SetValue(true);
					DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow81.SetGuard(DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow81_LiteralBoolean82);
				DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern.AddEdge(DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow81);
					// ObjectFlow ObjectFlow86 from result to target
					DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow86.SetName("ObjectFlow86");
					DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow86.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow86.SetSource(DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result);
					DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow86.SetTarget(DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target);
						// LiteralBoolean LiteralBoolean87
						DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow86_LiteralBoolean87.SetName("LiteralBoolean87");
						DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow86_LiteralBoolean87.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow86_LiteralBoolean87.SetValue(true);
					DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow86.SetGuard(DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow86_LiteralBoolean87);
				DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern.AddEdge(DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern_ObjectFlow86);
			DelegationConnectors_P_P.AddPackagedElement(DelegationConnectors_P_P_instantiate_A_Unconnected_Pattern);
				// Class IImpl
				DelegationConnectors_P_P_IImpl.SetName("IImpl");
				DelegationConnectors_P_P_IImpl.SetVisibility(VisibilityKind.public_);
				DelegationConnectors_P_P_IImpl_I_Realization.SetName("I_Realization");
					DelegationConnectors_P_P_IImpl_I_Realization.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_P_IImpl_I_Realization.SetContract(DelegationConnectors_P_P_I);
					
				DelegationConnectors_P_P_IImpl.AddInterfaceRealization(DelegationConnectors_P_P_IImpl_I_Realization);
			DelegationConnectors_P_P.AddPackagedElement(DelegationConnectors_P_P_IImpl);
				// Activity instantiate_A_Array_Pattern
				DelegationConnectors_P_P_instantiate_A_Array_Pattern.SetName("instantiate_A_Array_Pattern");
				DelegationConnectors_P_P_instantiate_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Array_Pattern
					DelegationConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern.SetName("a_Array_Pattern");
					DelegationConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern.SetType(DelegationConnectors_P_P_A_Array_Pattern);
					DelegationConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern.SetDirection(ParameterDirectionKind.return_);
				DelegationConnectors_P_P_instantiate_A_Array_Pattern.AddOwnedParameter(DelegationConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern);
					// CallOperationAction A_Array_Pattern()
					DelegationConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern_.SetName("A_Array_Pattern()");
					DelegationConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						DelegationConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__result.SetName("result");
						DelegationConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__result.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__result.SetType(DelegationConnectors_P_P_A_Array_Pattern);
					DelegationConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern_.AddResult(DelegationConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__result);
					DelegationConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern_.SetOperation(DelegationConnectors_P_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern);
						// InputPin target
						DelegationConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__target.SetName("target");
						DelegationConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__target.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__target.SetType(DelegationConnectors_P_P_A_Array_Pattern);
					DelegationConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern_.SetTarget(DelegationConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__target);
				DelegationConnectors_P_P_instantiate_A_Array_Pattern.AddNode(DelegationConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern_);
					// CreateObjectAction Create A_Array_Pattern
					DelegationConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern.SetName("Create A_Array_Pattern");
					DelegationConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern.SetClassifier(DelegationConnectors_P_P_A_Array_Pattern);
						// OutputPin result
						DelegationConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result.SetName("result");
						DelegationConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result.SetType(DelegationConnectors_P_P_A_Array_Pattern);
					DelegationConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern.SetResult(DelegationConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result);
				DelegationConnectors_P_P_instantiate_A_Array_Pattern.AddNode(DelegationConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern);
					// ActivityParameterNode a_Array_Pattern_node
					DelegationConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern_node.SetName("a_Array_Pattern_node");
					DelegationConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern_node.SetParameter(DelegationConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern);
				DelegationConnectors_P_P_instantiate_A_Array_Pattern.AddNode(DelegationConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern_node);
					// ObjectFlow ObjectFlow96 from result to target
					DelegationConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow96.SetName("ObjectFlow96");
					DelegationConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow96.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow96.SetSource(DelegationConnectors_P_P_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result);
					DelegationConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow96.SetTarget(DelegationConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__target);
						// LiteralBoolean LiteralBoolean98
						DelegationConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow96_LiteralBoolean98.SetName("LiteralBoolean98");
						DelegationConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow96_LiteralBoolean98.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow96_LiteralBoolean98.SetValue(true);
					DelegationConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow96.SetGuard(DelegationConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow96_LiteralBoolean98);
				DelegationConnectors_P_P_instantiate_A_Array_Pattern.AddEdge(DelegationConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow96);
					// ObjectFlow ObjectFlow99 from result to a_Array_Pattern_node
					DelegationConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow99.SetName("ObjectFlow99");
					DelegationConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow99.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow99.SetSource(DelegationConnectors_P_P_instantiate_A_Array_Pattern_A_Array_Pattern__result);
					DelegationConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow99.SetTarget(DelegationConnectors_P_P_instantiate_A_Array_Pattern_a_Array_Pattern_node);
						// LiteralBoolean LiteralBoolean100
						DelegationConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow99_LiteralBoolean100.SetName("LiteralBoolean100");
						DelegationConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow99_LiteralBoolean100.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow99_LiteralBoolean100.SetValue(true);
					DelegationConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow99.SetGuard(DelegationConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow99_LiteralBoolean100);
				DelegationConnectors_P_P_instantiate_A_Array_Pattern.AddEdge(DelegationConnectors_P_P_instantiate_A_Array_Pattern_ObjectFlow99);
			DelegationConnectors_P_P.AddPackagedElement(DelegationConnectors_P_P_instantiate_A_Array_Pattern);
				// Activity assert_A_Unconnected_Pattern
				DelegationConnectors_P_P_assert_A_Unconnected_Pattern.SetName("assert_A_Unconnected_Pattern");
				DelegationConnectors_P_P_assert_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Unconnected_Pattern
					DelegationConnectors_P_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern.SetName("a_Unconnected_Pattern");
					DelegationConnectors_P_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern.SetType(DelegationConnectors_P_P_A_Unconnected_Pattern);
				DelegationConnectors_P_P_assert_A_Unconnected_Pattern.AddOwnedParameter(DelegationConnectors_P_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern);
					// ActivityParameterNode a_Unconnected_Pattern_node
					DelegationConnectors_P_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node.SetName("a_Unconnected_Pattern_node");
					DelegationConnectors_P_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node.SetParameter(DelegationConnectors_P_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern);
				DelegationConnectors_P_P_assert_A_Unconnected_Pattern.AddNode(DelegationConnectors_P_P_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node);
					// CallBehaviorAction writeLine
					DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine.SetName("writeLine");
					DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine.SetVisibility(VisibilityKind.public_);
					
						// OutputPin errorStatus
						DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_errorStatus.SetName("errorStatus");
						DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_errorStatus.SetVisibility(VisibilityKind.public_);
						
						DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_errorStatus.SetLower(0);
					DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine.AddResult(DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_errorStatus);
					DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
						// InputPin value
						DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_value.SetName("value");
						DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_value.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine.AddArgument(DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_value);
				DelegationConnectors_P_P_assert_A_Unconnected_Pattern.AddNode(DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine);
					// ValueSpecificationAction message
					DelegationConnectors_P_P_assert_A_Unconnected_Pattern_message.SetName("message");
					DelegationConnectors_P_P_assert_A_Unconnected_Pattern_message.SetVisibility(VisibilityKind.public_);
						// LiteralString LiteralString115
						DelegationConnectors_P_P_assert_A_Unconnected_Pattern_message_LiteralString115.SetName("LiteralString115");
						DelegationConnectors_P_P_assert_A_Unconnected_Pattern_message_LiteralString115.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_assert_A_Unconnected_Pattern_message_LiteralString115.SetValue("Assertion currently not implemented for A_Unconnected_Pattern.");
					DelegationConnectors_P_P_assert_A_Unconnected_Pattern_message.SetValue(DelegationConnectors_P_P_assert_A_Unconnected_Pattern_message_LiteralString115);
						// OutputPin result
						DelegationConnectors_P_P_assert_A_Unconnected_Pattern_message_result.SetName("result");
						DelegationConnectors_P_P_assert_A_Unconnected_Pattern_message_result.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_assert_A_Unconnected_Pattern_message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					DelegationConnectors_P_P_assert_A_Unconnected_Pattern_message.SetResult(DelegationConnectors_P_P_assert_A_Unconnected_Pattern_message_result);
				DelegationConnectors_P_P_assert_A_Unconnected_Pattern.AddNode(DelegationConnectors_P_P_assert_A_Unconnected_Pattern_message);
					// ObjectFlow ObjectFlow110 from result to value
					DelegationConnectors_P_P_assert_A_Unconnected_Pattern_ObjectFlow110.SetName("ObjectFlow110");
					DelegationConnectors_P_P_assert_A_Unconnected_Pattern_ObjectFlow110.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_assert_A_Unconnected_Pattern_ObjectFlow110.SetSource(DelegationConnectors_P_P_assert_A_Unconnected_Pattern_message_result);
					DelegationConnectors_P_P_assert_A_Unconnected_Pattern_ObjectFlow110.SetTarget(DelegationConnectors_P_P_assert_A_Unconnected_Pattern_writeLine_value);
						// LiteralBoolean LiteralBoolean111
						DelegationConnectors_P_P_assert_A_Unconnected_Pattern_ObjectFlow110_LiteralBoolean111.SetName("LiteralBoolean111");
						DelegationConnectors_P_P_assert_A_Unconnected_Pattern_ObjectFlow110_LiteralBoolean111.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_assert_A_Unconnected_Pattern_ObjectFlow110_LiteralBoolean111.SetValue(true);
					DelegationConnectors_P_P_assert_A_Unconnected_Pattern_ObjectFlow110.SetGuard(DelegationConnectors_P_P_assert_A_Unconnected_Pattern_ObjectFlow110_LiteralBoolean111);
				DelegationConnectors_P_P_assert_A_Unconnected_Pattern.AddEdge(DelegationConnectors_P_P_assert_A_Unconnected_Pattern_ObjectFlow110);
			DelegationConnectors_P_P.AddPackagedElement(DelegationConnectors_P_P_assert_A_Unconnected_Pattern);
				// Class A_Array_Pattern
				DelegationConnectors_P_P_A_Array_Pattern.SetName("A_Array_Pattern");
				DelegationConnectors_P_P_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Property b
					DelegationConnectors_P_P_A_Array_Pattern_b.SetName("b");
					DelegationConnectors_P_P_A_Array_Pattern_b.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_P_A_Array_Pattern_b.SetUpper(-1);
					DelegationConnectors_P_P_A_Array_Pattern_b.SetLower(4);
					DelegationConnectors_P_P_A_Array_Pattern_b.SetType(DelegationConnectors_P_P_B);
					DelegationConnectors_P_P_A_Array_Pattern_b.SetAggregation(AggregationKind.composite);
				DelegationConnectors_P_P_A_Array_Pattern.AddOwnedAttribute(DelegationConnectors_P_P_A_Array_Pattern_b);
					// Port p
					DelegationConnectors_P_P_A_Array_Pattern_p.SetName("p");
					DelegationConnectors_P_P_A_Array_Pattern_p.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_P_A_Array_Pattern_p.SetUpper(-1);
					DelegationConnectors_P_P_A_Array_Pattern_p.SetLower(4);
					DelegationConnectors_P_P_A_Array_Pattern_p.SetType(DelegationConnectors_P_P_IImpl);
					DelegationConnectors_P_P_A_Array_Pattern_p.SetAggregation(AggregationKind.composite);
					DelegationConnectors_P_P_A_Array_Pattern_p.isService = true;
					DelegationConnectors_P_P_A_Array_Pattern_p.AddProvided(DelegationConnectors_P_P_I);
				DelegationConnectors_P_P_A_Array_Pattern.AddOwnedAttribute(DelegationConnectors_P_P_A_Array_Pattern_p);
				
				DelegationConnectors_P_P_A_Array_Pattern_r.SetName("r");
					DelegationConnectors_P_P_A_Array_Pattern_r.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_A_Array_Pattern_r_ConnectorEnd117.SetUpper(-1);
						DelegationConnectors_P_P_A_Array_Pattern_r_ConnectorEnd117.SetRole(DelegationConnectors_P_P_A_Array_Pattern_p);
						
					DelegationConnectors_P_P_A_Array_Pattern_r.AddEnd(DelegationConnectors_P_P_A_Array_Pattern_r_ConnectorEnd117);
						DelegationConnectors_P_P_A_Array_Pattern_r_ConnectorEnd119.SetUpper(-1);
						DelegationConnectors_P_P_A_Array_Pattern_r_ConnectorEnd119.SetRole(DelegationConnectors_P_P_A_Array_Pattern_b);
						
					DelegationConnectors_P_P_A_Array_Pattern_r.AddEnd(DelegationConnectors_P_P_A_Array_Pattern_r_ConnectorEnd119);
					DelegationConnectors_P_P_A_Array_Pattern_r.SetType(DelegationConnectors_P_P_R);
				DelegationConnectors_P_P_A_Array_Pattern.AddOwnedConnector(DelegationConnectors_P_P_A_Array_Pattern_r);
					// Operation A_Array_Pattern_A_Array_Pattern
					DelegationConnectors_P_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern.SetName("A_Array_Pattern_A_Array_Pattern");
					DelegationConnectors_P_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
						// Parameter result
						DelegationConnectors_P_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result.SetName("result");
						DelegationConnectors_P_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result.SetVisibility(VisibilityKind.public_);
						
						DelegationConnectors_P_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result.SetType(DelegationConnectors_P_P_A_Array_Pattern);
						DelegationConnectors_P_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result.SetDirection(ParameterDirectionKind.return_);
					DelegationConnectors_P_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern.AddOwnedParameter(DelegationConnectors_P_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result);
					DelegationConnectors_P_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				DelegationConnectors_P_P_A_Array_Pattern.AddOwnedOperation(DelegationConnectors_P_P_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern);
			DelegationConnectors_P_P.AddPackagedElement(DelegationConnectors_P_P_A_Array_Pattern);
				// Association R
				DelegationConnectors_P_P_R.SetName("R");
				DelegationConnectors_P_P_R.SetVisibility(VisibilityKind.public_);
				DelegationConnectors_P_P_R.AddOwnedEnd(DelegationConnectors_P_P_R_x);
				DelegationConnectors_P_P_R.AddOwnedEnd(DelegationConnectors_P_P_R_y);
			DelegationConnectors_P_P.AddPackagedElement(DelegationConnectors_P_P_R);
				// Class A_Unconnected_Pattern
				DelegationConnectors_P_P_A_Unconnected_Pattern.SetName("A_Unconnected_Pattern");
				DelegationConnectors_P_P_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Property b
					DelegationConnectors_P_P_A_Unconnected_Pattern_b.SetName("b");
					DelegationConnectors_P_P_A_Unconnected_Pattern_b.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_P_A_Unconnected_Pattern_b.SetUpper(-1);
					DelegationConnectors_P_P_A_Unconnected_Pattern_b.SetLower(2);
					DelegationConnectors_P_P_A_Unconnected_Pattern_b.SetType(DelegationConnectors_P_P_B);
					DelegationConnectors_P_P_A_Unconnected_Pattern_b.SetAggregation(AggregationKind.composite);
				DelegationConnectors_P_P_A_Unconnected_Pattern.AddOwnedAttribute(DelegationConnectors_P_P_A_Unconnected_Pattern_b);
					// Port p
					DelegationConnectors_P_P_A_Unconnected_Pattern_p.SetName("p");
					DelegationConnectors_P_P_A_Unconnected_Pattern_p.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_P_A_Unconnected_Pattern_p.SetUpper(-1);
					DelegationConnectors_P_P_A_Unconnected_Pattern_p.SetLower(3);
					DelegationConnectors_P_P_A_Unconnected_Pattern_p.SetType(DelegationConnectors_P_P_IImpl);
					DelegationConnectors_P_P_A_Unconnected_Pattern_p.SetAggregation(AggregationKind.composite);
					DelegationConnectors_P_P_A_Unconnected_Pattern_p.isService = true;
					DelegationConnectors_P_P_A_Unconnected_Pattern_p.AddProvided(DelegationConnectors_P_P_I);
				DelegationConnectors_P_P_A_Unconnected_Pattern.AddOwnedAttribute(DelegationConnectors_P_P_A_Unconnected_Pattern_p);
				
				DelegationConnectors_P_P_A_Unconnected_Pattern_r.SetName("r");
					DelegationConnectors_P_P_A_Unconnected_Pattern_r.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd136.SetUpper(-1);
						DelegationConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd136.SetLower(0);
						DelegationConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd136.SetRole(DelegationConnectors_P_P_A_Unconnected_Pattern_p);
						
					DelegationConnectors_P_P_A_Unconnected_Pattern_r.AddEnd(DelegationConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd136);
						DelegationConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd133.SetUpper(-1);
						DelegationConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd133.SetLower(0);
						DelegationConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd133.SetRole(DelegationConnectors_P_P_A_Unconnected_Pattern_b);
						
					DelegationConnectors_P_P_A_Unconnected_Pattern_r.AddEnd(DelegationConnectors_P_P_A_Unconnected_Pattern_r_ConnectorEnd133);
					DelegationConnectors_P_P_A_Unconnected_Pattern_r.SetType(DelegationConnectors_P_P_R);
				DelegationConnectors_P_P_A_Unconnected_Pattern.AddOwnedConnector(DelegationConnectors_P_P_A_Unconnected_Pattern_r);
					// Operation A_Unconnected_Pattern_A_Unconnected_Pattern
					DelegationConnectors_P_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern.SetName("A_Unconnected_Pattern_A_Unconnected_Pattern");
					DelegationConnectors_P_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
						// Parameter result
						DelegationConnectors_P_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result.SetName("result");
						DelegationConnectors_P_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result.SetVisibility(VisibilityKind.public_);
						
						DelegationConnectors_P_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result.SetType(DelegationConnectors_P_P_A_Unconnected_Pattern);
						DelegationConnectors_P_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result.SetDirection(ParameterDirectionKind.return_);
					DelegationConnectors_P_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern.AddOwnedParameter(DelegationConnectors_P_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result);
					DelegationConnectors_P_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				DelegationConnectors_P_P_A_Unconnected_Pattern.AddOwnedOperation(DelegationConnectors_P_P_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern);
			DelegationConnectors_P_P.AddPackagedElement(DelegationConnectors_P_P_A_Unconnected_Pattern);
				// Interface I
				DelegationConnectors_P_P_I.SetName("I");
				DelegationConnectors_P_P_I.SetVisibility(VisibilityKind.public_);
			DelegationConnectors_P_P.AddPackagedElement(DelegationConnectors_P_P_I);
				// Activity instantiate_A_Empty_Pattern
				DelegationConnectors_P_P_instantiate_A_Empty_Pattern.SetName("instantiate_A_Empty_Pattern");
				DelegationConnectors_P_P_instantiate_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Empty_Pattern
					DelegationConnectors_P_P_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetName("a_Empty_Pattern");
					DelegationConnectors_P_P_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetType(DelegationConnectors_P_P_A_Empty_Pattern);
					DelegationConnectors_P_P_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetDirection(ParameterDirectionKind.return_);
				DelegationConnectors_P_P_instantiate_A_Empty_Pattern.AddOwnedParameter(DelegationConnectors_P_P_instantiate_A_Empty_Pattern_a_Empty_Pattern);
					// CreateObjectAction Create A_Empty_Pattern
					DelegationConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern.SetName("Create A_Empty_Pattern");
					DelegationConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern.SetClassifier(DelegationConnectors_P_P_A_Empty_Pattern);
						// OutputPin result
						DelegationConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result.SetName("result");
						DelegationConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result.SetType(DelegationConnectors_P_P_A_Empty_Pattern);
					DelegationConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern.SetResult(DelegationConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result);
				DelegationConnectors_P_P_instantiate_A_Empty_Pattern.AddNode(DelegationConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern);
					// ActivityParameterNode a_Empty_Pattern_node
					DelegationConnectors_P_P_instantiate_A_Empty_Pattern_a_Empty_Pattern_node.SetName("a_Empty_Pattern_node");
					DelegationConnectors_P_P_instantiate_A_Empty_Pattern_a_Empty_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_instantiate_A_Empty_Pattern_a_Empty_Pattern_node.SetParameter(DelegationConnectors_P_P_instantiate_A_Empty_Pattern_a_Empty_Pattern);
				DelegationConnectors_P_P_instantiate_A_Empty_Pattern.AddNode(DelegationConnectors_P_P_instantiate_A_Empty_Pattern_a_Empty_Pattern_node);
					// CallOperationAction A_Empty_Pattern()
					DelegationConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern_.SetName("A_Empty_Pattern()");
					DelegationConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						DelegationConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result.SetName("result");
						DelegationConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result.SetType(DelegationConnectors_P_P_A_Empty_Pattern);
					DelegationConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern_.AddResult(DelegationConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result);
					DelegationConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern_.SetOperation(DelegationConnectors_P_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern);
						// InputPin target
						DelegationConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target.SetName("target");
						DelegationConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target.SetType(DelegationConnectors_P_P_A_Empty_Pattern);
					DelegationConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern_.SetTarget(DelegationConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target);
				DelegationConnectors_P_P_instantiate_A_Empty_Pattern.AddNode(DelegationConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern_);
					// ObjectFlow ObjectFlow140 from result to target
					DelegationConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow140.SetName("ObjectFlow140");
					DelegationConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow140.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow140.SetSource(DelegationConnectors_P_P_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result);
					DelegationConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow140.SetTarget(DelegationConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__target);
						// LiteralBoolean LiteralBoolean142
						DelegationConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow140_LiteralBoolean142.SetName("LiteralBoolean142");
						DelegationConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow140_LiteralBoolean142.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow140_LiteralBoolean142.SetValue(true);
					DelegationConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow140.SetGuard(DelegationConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow140_LiteralBoolean142);
				DelegationConnectors_P_P_instantiate_A_Empty_Pattern.AddEdge(DelegationConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow140);
					// ObjectFlow ObjectFlow145 from result to a_Empty_Pattern_node
					DelegationConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow145.SetName("ObjectFlow145");
					DelegationConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow145.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow145.SetSource(DelegationConnectors_P_P_instantiate_A_Empty_Pattern_A_Empty_Pattern__result);
					DelegationConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow145.SetTarget(DelegationConnectors_P_P_instantiate_A_Empty_Pattern_a_Empty_Pattern_node);
						// LiteralBoolean LiteralBoolean146
						DelegationConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow145_LiteralBoolean146.SetName("LiteralBoolean146");
						DelegationConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow145_LiteralBoolean146.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow145_LiteralBoolean146.SetValue(true);
					DelegationConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow145.SetGuard(DelegationConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow145_LiteralBoolean146);
				DelegationConnectors_P_P_instantiate_A_Empty_Pattern.AddEdge(DelegationConnectors_P_P_instantiate_A_Empty_Pattern_ObjectFlow145);
			DelegationConnectors_P_P.AddPackagedElement(DelegationConnectors_P_P_instantiate_A_Empty_Pattern);
				// Activity assert_A_Array_Pattern
				DelegationConnectors_P_P_assert_A_Array_Pattern.SetName("assert_A_Array_Pattern");
				DelegationConnectors_P_P_assert_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Array_Pattern
					DelegationConnectors_P_P_assert_A_Array_Pattern_a_Array_Pattern.SetName("a_Array_Pattern");
					DelegationConnectors_P_P_assert_A_Array_Pattern_a_Array_Pattern.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_assert_A_Array_Pattern_a_Array_Pattern.SetType(DelegationConnectors_P_P_A_Array_Pattern);
				DelegationConnectors_P_P_assert_A_Array_Pattern.AddOwnedParameter(DelegationConnectors_P_P_assert_A_Array_Pattern_a_Array_Pattern);
					// ValueSpecificationAction message
					DelegationConnectors_P_P_assert_A_Array_Pattern_message.SetName("message");
					DelegationConnectors_P_P_assert_A_Array_Pattern_message.SetVisibility(VisibilityKind.public_);
						// LiteralString LiteralString158
						DelegationConnectors_P_P_assert_A_Array_Pattern_message_LiteralString158.SetName("LiteralString158");
						DelegationConnectors_P_P_assert_A_Array_Pattern_message_LiteralString158.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_assert_A_Array_Pattern_message_LiteralString158.SetValue("Assertion currently not implemented for A_Array_Pattern.");
					DelegationConnectors_P_P_assert_A_Array_Pattern_message.SetValue(DelegationConnectors_P_P_assert_A_Array_Pattern_message_LiteralString158);
						// OutputPin result
						DelegationConnectors_P_P_assert_A_Array_Pattern_message_result.SetName("result");
						DelegationConnectors_P_P_assert_A_Array_Pattern_message_result.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_assert_A_Array_Pattern_message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					DelegationConnectors_P_P_assert_A_Array_Pattern_message.SetResult(DelegationConnectors_P_P_assert_A_Array_Pattern_message_result);
				DelegationConnectors_P_P_assert_A_Array_Pattern.AddNode(DelegationConnectors_P_P_assert_A_Array_Pattern_message);
					// CallBehaviorAction writeLine
					DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine.SetName("writeLine");
					DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine.SetVisibility(VisibilityKind.public_);
					
						// OutputPin errorStatus
						DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine_errorStatus.SetName("errorStatus");
						DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine_errorStatus.SetVisibility(VisibilityKind.public_);
						
						DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine_errorStatus.SetLower(0);
					DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine.AddResult(DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine_errorStatus);
					DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
						// InputPin value
						DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine_value.SetName("value");
						DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine_value.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine.AddArgument(DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine_value);
				DelegationConnectors_P_P_assert_A_Array_Pattern.AddNode(DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine);
					// ActivityParameterNode a_Array_Pattern_node
					DelegationConnectors_P_P_assert_A_Array_Pattern_a_Array_Pattern_node.SetName("a_Array_Pattern_node");
					DelegationConnectors_P_P_assert_A_Array_Pattern_a_Array_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_assert_A_Array_Pattern_a_Array_Pattern_node.SetParameter(DelegationConnectors_P_P_assert_A_Array_Pattern_a_Array_Pattern);
				DelegationConnectors_P_P_assert_A_Array_Pattern.AddNode(DelegationConnectors_P_P_assert_A_Array_Pattern_a_Array_Pattern_node);
					// ObjectFlow ObjectFlow153 from result to value
					DelegationConnectors_P_P_assert_A_Array_Pattern_ObjectFlow153.SetName("ObjectFlow153");
					DelegationConnectors_P_P_assert_A_Array_Pattern_ObjectFlow153.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_assert_A_Array_Pattern_ObjectFlow153.SetSource(DelegationConnectors_P_P_assert_A_Array_Pattern_message_result);
					DelegationConnectors_P_P_assert_A_Array_Pattern_ObjectFlow153.SetTarget(DelegationConnectors_P_P_assert_A_Array_Pattern_writeLine_value);
						// LiteralBoolean LiteralBoolean154
						DelegationConnectors_P_P_assert_A_Array_Pattern_ObjectFlow153_LiteralBoolean154.SetName("LiteralBoolean154");
						DelegationConnectors_P_P_assert_A_Array_Pattern_ObjectFlow153_LiteralBoolean154.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_assert_A_Array_Pattern_ObjectFlow153_LiteralBoolean154.SetValue(true);
					DelegationConnectors_P_P_assert_A_Array_Pattern_ObjectFlow153.SetGuard(DelegationConnectors_P_P_assert_A_Array_Pattern_ObjectFlow153_LiteralBoolean154);
				DelegationConnectors_P_P_assert_A_Array_Pattern.AddEdge(DelegationConnectors_P_P_assert_A_Array_Pattern_ObjectFlow153);
			DelegationConnectors_P_P.AddPackagedElement(DelegationConnectors_P_P_assert_A_Array_Pattern);
				// Class A_Empty_Pattern
				DelegationConnectors_P_P_A_Empty_Pattern.SetName("A_Empty_Pattern");
				DelegationConnectors_P_P_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Property b
					DelegationConnectors_P_P_A_Empty_Pattern_b.SetName("b");
					DelegationConnectors_P_P_A_Empty_Pattern_b.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_P_A_Empty_Pattern_b.SetUpper(-1);
					DelegationConnectors_P_P_A_Empty_Pattern_b.SetLower(0);
					DelegationConnectors_P_P_A_Empty_Pattern_b.SetType(DelegationConnectors_P_P_B);
					DelegationConnectors_P_P_A_Empty_Pattern_b.SetAggregation(AggregationKind.composite);
				DelegationConnectors_P_P_A_Empty_Pattern.AddOwnedAttribute(DelegationConnectors_P_P_A_Empty_Pattern_b);
					// Port p
					DelegationConnectors_P_P_A_Empty_Pattern_p.SetName("p");
					DelegationConnectors_P_P_A_Empty_Pattern_p.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_P_A_Empty_Pattern_p.SetUpper(-1);
					DelegationConnectors_P_P_A_Empty_Pattern_p.SetLower(0);
					DelegationConnectors_P_P_A_Empty_Pattern_p.SetType(DelegationConnectors_P_P_IImpl);
					DelegationConnectors_P_P_A_Empty_Pattern_p.SetAggregation(AggregationKind.composite);
					DelegationConnectors_P_P_A_Empty_Pattern_p.isService = true;
					DelegationConnectors_P_P_A_Empty_Pattern_p.AddProvided(DelegationConnectors_P_P_I);
				DelegationConnectors_P_P_A_Empty_Pattern.AddOwnedAttribute(DelegationConnectors_P_P_A_Empty_Pattern_p);
				
				DelegationConnectors_P_P_A_Empty_Pattern_r.SetName("r");
					DelegationConnectors_P_P_A_Empty_Pattern_r.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_A_Empty_Pattern_r_ConnectorEnd173.SetUpper(-1);
						DelegationConnectors_P_P_A_Empty_Pattern_r_ConnectorEnd173.SetRole(DelegationConnectors_P_P_A_Empty_Pattern_p);
						
					DelegationConnectors_P_P_A_Empty_Pattern_r.AddEnd(DelegationConnectors_P_P_A_Empty_Pattern_r_ConnectorEnd173);
						DelegationConnectors_P_P_A_Empty_Pattern_r_ConnectorEnd171.SetUpper(-1);
						DelegationConnectors_P_P_A_Empty_Pattern_r_ConnectorEnd171.SetRole(DelegationConnectors_P_P_A_Empty_Pattern_b);
						
					DelegationConnectors_P_P_A_Empty_Pattern_r.AddEnd(DelegationConnectors_P_P_A_Empty_Pattern_r_ConnectorEnd171);
					DelegationConnectors_P_P_A_Empty_Pattern_r.SetType(DelegationConnectors_P_P_R);
				DelegationConnectors_P_P_A_Empty_Pattern.AddOwnedConnector(DelegationConnectors_P_P_A_Empty_Pattern_r);
					// Operation A_Empty_Pattern_A_Empty_Pattern
					DelegationConnectors_P_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern.SetName("A_Empty_Pattern_A_Empty_Pattern");
					DelegationConnectors_P_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
						// Parameter result
						DelegationConnectors_P_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result.SetName("result");
						DelegationConnectors_P_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result.SetVisibility(VisibilityKind.public_);
						
						DelegationConnectors_P_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result.SetType(DelegationConnectors_P_P_A_Empty_Pattern);
						DelegationConnectors_P_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result.SetDirection(ParameterDirectionKind.return_);
					DelegationConnectors_P_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern.AddOwnedParameter(DelegationConnectors_P_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result);
					DelegationConnectors_P_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				DelegationConnectors_P_P_A_Empty_Pattern.AddOwnedOperation(DelegationConnectors_P_P_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern);
			DelegationConnectors_P_P.AddPackagedElement(DelegationConnectors_P_P_A_Empty_Pattern);
				// Activity assert_A_Empty_Pattern
				DelegationConnectors_P_P_assert_A_Empty_Pattern.SetName("assert_A_Empty_Pattern");
				DelegationConnectors_P_P_assert_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Empty_Pattern
					DelegationConnectors_P_P_assert_A_Empty_Pattern_a_Empty_Pattern.SetName("a_Empty_Pattern");
					DelegationConnectors_P_P_assert_A_Empty_Pattern_a_Empty_Pattern.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_assert_A_Empty_Pattern_a_Empty_Pattern.SetType(DelegationConnectors_P_P_A_Empty_Pattern);
				DelegationConnectors_P_P_assert_A_Empty_Pattern.AddOwnedParameter(DelegationConnectors_P_P_assert_A_Empty_Pattern_a_Empty_Pattern);
					// ValueSpecificationAction message
					DelegationConnectors_P_P_assert_A_Empty_Pattern_message.SetName("message");
					DelegationConnectors_P_P_assert_A_Empty_Pattern_message.SetVisibility(VisibilityKind.public_);
						// LiteralString LiteralString177
						DelegationConnectors_P_P_assert_A_Empty_Pattern_message_LiteralString177.SetName("LiteralString177");
						DelegationConnectors_P_P_assert_A_Empty_Pattern_message_LiteralString177.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_assert_A_Empty_Pattern_message_LiteralString177.SetValue("Assertion currently not implemented for A_Empty_Pattern.");
					DelegationConnectors_P_P_assert_A_Empty_Pattern_message.SetValue(DelegationConnectors_P_P_assert_A_Empty_Pattern_message_LiteralString177);
						// OutputPin result
						DelegationConnectors_P_P_assert_A_Empty_Pattern_message_result.SetName("result");
						DelegationConnectors_P_P_assert_A_Empty_Pattern_message_result.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_assert_A_Empty_Pattern_message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					DelegationConnectors_P_P_assert_A_Empty_Pattern_message.SetResult(DelegationConnectors_P_P_assert_A_Empty_Pattern_message_result);
				DelegationConnectors_P_P_assert_A_Empty_Pattern.AddNode(DelegationConnectors_P_P_assert_A_Empty_Pattern_message);
					// CallBehaviorAction writeLine
					DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine.SetName("writeLine");
					DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine.SetVisibility(VisibilityKind.public_);
					
						// OutputPin errorStatus
						DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine_errorStatus.SetName("errorStatus");
						DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine_errorStatus.SetVisibility(VisibilityKind.public_);
						
						DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine_errorStatus.SetLower(0);
					DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine.AddResult(DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine_errorStatus);
					DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
						// InputPin value
						DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine_value.SetName("value");
						DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine_value.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine.AddArgument(DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine_value);
				DelegationConnectors_P_P_assert_A_Empty_Pattern.AddNode(DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine);
					// ActivityParameterNode a_Empty_Pattern_node
					DelegationConnectors_P_P_assert_A_Empty_Pattern_a_Empty_Pattern_node.SetName("a_Empty_Pattern_node");
					DelegationConnectors_P_P_assert_A_Empty_Pattern_a_Empty_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_assert_A_Empty_Pattern_a_Empty_Pattern_node.SetParameter(DelegationConnectors_P_P_assert_A_Empty_Pattern_a_Empty_Pattern);
				DelegationConnectors_P_P_assert_A_Empty_Pattern.AddNode(DelegationConnectors_P_P_assert_A_Empty_Pattern_a_Empty_Pattern_node);
					// ObjectFlow ObjectFlow178 from result to value
					DelegationConnectors_P_P_assert_A_Empty_Pattern_ObjectFlow178.SetName("ObjectFlow178");
					DelegationConnectors_P_P_assert_A_Empty_Pattern_ObjectFlow178.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_P_assert_A_Empty_Pattern_ObjectFlow178.SetSource(DelegationConnectors_P_P_assert_A_Empty_Pattern_message_result);
					DelegationConnectors_P_P_assert_A_Empty_Pattern_ObjectFlow178.SetTarget(DelegationConnectors_P_P_assert_A_Empty_Pattern_writeLine_value);
						// LiteralBoolean LiteralBoolean180
						DelegationConnectors_P_P_assert_A_Empty_Pattern_ObjectFlow178_LiteralBoolean180.SetName("LiteralBoolean180");
						DelegationConnectors_P_P_assert_A_Empty_Pattern_ObjectFlow178_LiteralBoolean180.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_P_assert_A_Empty_Pattern_ObjectFlow178_LiteralBoolean180.SetValue(true);
					DelegationConnectors_P_P_assert_A_Empty_Pattern_ObjectFlow178.SetGuard(DelegationConnectors_P_P_assert_A_Empty_Pattern_ObjectFlow178_LiteralBoolean180);
				DelegationConnectors_P_P_assert_A_Empty_Pattern.AddEdge(DelegationConnectors_P_P_assert_A_Empty_Pattern_ObjectFlow178);
			DelegationConnectors_P_P.AddPackagedElement(DelegationConnectors_P_P_assert_A_Empty_Pattern);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // DelegationConnectors_P_PModel
}
