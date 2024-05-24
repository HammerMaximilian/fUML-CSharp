/*
 * DelegationConnectors_P_PWPModel.cs
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

namespace DelegationConnectors_P_PWP
{
	public class DelegationConnectors_P_PWPModel : InMemoryModel
	{
		private static DelegationConnectors_P_PWPModel? instance;

		/*
		 * Model DelegationConnectors_P_PWP
		 */
		public Package DelegationConnectors_P_PWP = new();
			public Class_ DelegationConnectors_P_PWP_B = new();
				public Port DelegationConnectors_P_PWP_B_q = new();
					public LiteralInteger DelegationConnectors_P_PWP_B_q_LiteralInteger0 = new();
					public LiteralUnlimitedNatural DelegationConnectors_P_PWP_B_q_LiteralUnlimitedNatural1 = new();
			public Association DelegationConnectors_P_PWP_R = new();
				public Property DelegationConnectors_P_PWP_R_x = new();
					public LiteralInteger DelegationConnectors_P_PWP_R_x_LiteralInteger2 = new();
					public LiteralUnlimitedNatural DelegationConnectors_P_PWP_R_x_LiteralUnlimitedNatural3 = new();
				public Property DelegationConnectors_P_PWP_R_y = new();
					public LiteralUnlimitedNatural DelegationConnectors_P_PWP_R_y_LiteralUnlimitedNatural4 = new();
					public LiteralInteger DelegationConnectors_P_PWP_R_y_LiteralInteger5 = new();
			public Interface DelegationConnectors_P_PWP_I = new();
			public Activity DelegationConnectors_P_PWP_assert_A_Array_Pattern = new();
				public Parameter DelegationConnectors_P_PWP_assert_A_Array_Pattern_a_Array_Pattern = new();
				public ObjectFlow DelegationConnectors_P_PWP_assert_A_Array_Pattern_ObjectFlow6 = new();
					public LiteralInteger DelegationConnectors_P_PWP_assert_A_Array_Pattern_ObjectFlow6_LiteralInteger7 = new();
					public LiteralBoolean DelegationConnectors_P_PWP_assert_A_Array_Pattern_ObjectFlow6_LiteralBoolean8 = new();
				public CallBehaviorAction DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine = new();
					public InputPin DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine_value = new();
						public LiteralInteger DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine_value_LiteralInteger9 = new();
						public LiteralInteger DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine_value_LiteralInteger10 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine_value_LiteralUnlimitedNatural11 = new();
					public OutputPin DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine_errorStatus = new();
						public LiteralInteger DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine_errorStatus_LiteralInteger12 = new();
						public LiteralInteger DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine_errorStatus_LiteralInteger13 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural14 = new();
				public ActivityParameterNode DelegationConnectors_P_PWP_assert_A_Array_Pattern_a_Array_Pattern_node = new();
					public LiteralInteger DelegationConnectors_P_PWP_assert_A_Array_Pattern_a_Array_Pattern_node_LiteralInteger15 = new();
				public ValueSpecificationAction DelegationConnectors_P_PWP_assert_A_Array_Pattern_message = new();
					public LiteralString DelegationConnectors_P_PWP_assert_A_Array_Pattern_message_LiteralString16 = new();
					public OutputPin DelegationConnectors_P_PWP_assert_A_Array_Pattern_message_result = new();
						public LiteralInteger DelegationConnectors_P_PWP_assert_A_Array_Pattern_message_result_LiteralInteger17 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_assert_A_Array_Pattern_message_result_LiteralUnlimitedNatural18 = new();
			public Class_ DelegationConnectors_P_PWP_A_Star_Pattern = new();
				public Property DelegationConnectors_P_PWP_A_Star_Pattern_b = new();
					public LiteralInteger DelegationConnectors_P_PWP_A_Star_Pattern_b_LiteralInteger19 = new();
					public LiteralUnlimitedNatural DelegationConnectors_P_PWP_A_Star_Pattern_b_LiteralUnlimitedNatural20 = new();
				public Port DelegationConnectors_P_PWP_A_Star_Pattern_p = new();
					public LiteralInteger DelegationConnectors_P_PWP_A_Star_Pattern_p_LiteralInteger21 = new();
					public LiteralUnlimitedNatural DelegationConnectors_P_PWP_A_Star_Pattern_p_LiteralUnlimitedNatural22 = new();
				public Connector DelegationConnectors_P_PWP_A_Star_Pattern_r = new();
					public ConnectorEnd DelegationConnectors_P_PWP_A_Star_Pattern_r_ConnectorEnd23 = new();
						public LiteralInteger DelegationConnectors_P_PWP_A_Star_Pattern_r_ConnectorEnd23_LiteralInteger24 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_A_Star_Pattern_r_ConnectorEnd23_LiteralUnlimitedNatural25 = new();
					public ConnectorEnd DelegationConnectors_P_PWP_A_Star_Pattern_r_ConnectorEnd26 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_A_Star_Pattern_r_ConnectorEnd26_LiteralUnlimitedNatural27 = new();
						public LiteralInteger DelegationConnectors_P_PWP_A_Star_Pattern_r_ConnectorEnd26_LiteralInteger28 = new();
				public Comment DelegationConnectors_P_PWP_A_Star_Pattern_Comment29 = new();
				public Operation DelegationConnectors_P_PWP_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern = new();
					public Parameter DelegationConnectors_P_PWP_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result = new();
			public Class_ DelegationConnectors_P_PWP_IImpl = new();
				public InterfaceRealization DelegationConnectors_P_PWP_IImpl_I_Realization = new();
			public Activity DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern = new();
				public Parameter DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern = new();
				public CreateObjectAction DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern = new();
					public OutputPin DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result = new();
						public LiteralInteger DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result_LiteralInteger30 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result_LiteralUnlimitedNatural31 = new();
				public ObjectFlow DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow32 = new();
					public LiteralBoolean DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow32_LiteralBoolean33 = new();
					public LiteralInteger DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow32_LiteralInteger34 = new();
				public ActivityParameterNode DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node = new();
				public ObjectFlow DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow35 = new();
					public LiteralInteger DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow35_LiteralInteger36 = new();
					public LiteralBoolean DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow35_LiteralBoolean37 = new();
				public CallOperationAction DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_ = new();
					public OutputPin DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result_LiteralUnlimitedNatural38 = new();
						public LiteralInteger DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result_LiteralInteger39 = new();
						public LiteralInteger DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result_LiteralInteger40 = new();
					public InputPin DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target = new();
						public LiteralInteger DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target_LiteralInteger41 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target_LiteralUnlimitedNatural42 = new();
			public Activity DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern = new();
				public ObjectFlow DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_ObjectFlow43 = new();
					public LiteralInteger DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_ObjectFlow43_LiteralInteger44 = new();
					public LiteralBoolean DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_ObjectFlow43_LiteralBoolean45 = new();
				public ObjectFlow DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_ObjectFlow46 = new();
					public LiteralInteger DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_ObjectFlow46_LiteralInteger47 = new();
					public LiteralBoolean DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_ObjectFlow46_LiteralBoolean48 = new();
				public CreateObjectAction DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern = new();
					public OutputPin DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result = new();
						public LiteralInteger DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result_LiteralInteger49 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result_LiteralUnlimitedNatural50 = new();
				public CallOperationAction DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern_ = new();
					public InputPin DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__target = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__target_LiteralUnlimitedNatural51 = new();
						public LiteralInteger DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__target_LiteralInteger52 = new();
					public OutputPin DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__result = new();
						public LiteralInteger DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__result_LiteralInteger53 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__result_LiteralUnlimitedNatural54 = new();
						public LiteralInteger DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__result_LiteralInteger55 = new();
				public ActivityParameterNode DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_a_Empty_Pattern_node = new();
				public Parameter DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_a_Empty_Pattern = new();
			public Activity DelegationConnectors_P_PWP_instantiate_A_Array_Pattern = new();
				public ObjectFlow DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_ObjectFlow56 = new();
					public LiteralBoolean DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_ObjectFlow56_LiteralBoolean57 = new();
					public LiteralInteger DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_ObjectFlow56_LiteralInteger58 = new();
				public ActivityParameterNode DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_a_Array_Pattern_node = new();
					public LiteralInteger DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_a_Array_Pattern_node_LiteralInteger59 = new();
				public CreateObjectAction DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern = new();
					public OutputPin DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result_LiteralUnlimitedNatural60 = new();
						public LiteralInteger DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result_LiteralInteger61 = new();
				public Parameter DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_a_Array_Pattern = new();
				public ObjectFlow DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_ObjectFlow62 = new();
					public LiteralBoolean DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_ObjectFlow62_LiteralBoolean63 = new();
					public LiteralInteger DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_ObjectFlow62_LiteralInteger64 = new();
				public CallOperationAction DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_A_Array_Pattern_ = new();
					public InputPin DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__target = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__target_LiteralUnlimitedNatural65 = new();
						public LiteralInteger DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__target_LiteralInteger66 = new();
					public OutputPin DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__result = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__result_LiteralUnlimitedNatural67 = new();
						public LiteralInteger DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__result_LiteralInteger68 = new();
						public LiteralInteger DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__result_LiteralInteger69 = new();
			public Class_ DelegationConnectors_P_PWP_A_Array_Pattern = new();
				public Comment DelegationConnectors_P_PWP_A_Array_Pattern_Comment70 = new();
				public Connector DelegationConnectors_P_PWP_A_Array_Pattern_r = new();
					public ConnectorEnd DelegationConnectors_P_PWP_A_Array_Pattern_r_ConnectorEnd71 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_A_Array_Pattern_r_ConnectorEnd71_LiteralUnlimitedNatural72 = new();
					public ConnectorEnd DelegationConnectors_P_PWP_A_Array_Pattern_r_ConnectorEnd73 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_A_Array_Pattern_r_ConnectorEnd73_LiteralUnlimitedNatural74 = new();
				public Property DelegationConnectors_P_PWP_A_Array_Pattern_b = new();
					public LiteralUnlimitedNatural DelegationConnectors_P_PWP_A_Array_Pattern_b_LiteralUnlimitedNatural75 = new();
					public LiteralInteger DelegationConnectors_P_PWP_A_Array_Pattern_b_LiteralInteger76 = new();
				public Operation DelegationConnectors_P_PWP_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern = new();
					public Parameter DelegationConnectors_P_PWP_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result = new();
				public Port DelegationConnectors_P_PWP_A_Array_Pattern_p = new();
					public LiteralInteger DelegationConnectors_P_PWP_A_Array_Pattern_p_LiteralInteger77 = new();
					public LiteralUnlimitedNatural DelegationConnectors_P_PWP_A_Array_Pattern_p_LiteralUnlimitedNatural78 = new();
			public Activity DelegationConnectors_P_PWP_assert_A_Empty_Pattern = new();
				public ObjectFlow DelegationConnectors_P_PWP_assert_A_Empty_Pattern_ObjectFlow79 = new();
					public LiteralInteger DelegationConnectors_P_PWP_assert_A_Empty_Pattern_ObjectFlow79_LiteralInteger80 = new();
					public LiteralBoolean DelegationConnectors_P_PWP_assert_A_Empty_Pattern_ObjectFlow79_LiteralBoolean81 = new();
				public CallBehaviorAction DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine = new();
					public OutputPin DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine_errorStatus = new();
						public LiteralInteger DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine_errorStatus_LiteralInteger82 = new();
						public LiteralInteger DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine_errorStatus_LiteralInteger83 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural84 = new();
					public InputPin DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine_value = new();
						public LiteralInteger DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine_value_LiteralInteger85 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine_value_LiteralUnlimitedNatural86 = new();
						public LiteralInteger DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine_value_LiteralInteger87 = new();
				public ValueSpecificationAction DelegationConnectors_P_PWP_assert_A_Empty_Pattern_message = new();
					public OutputPin DelegationConnectors_P_PWP_assert_A_Empty_Pattern_message_result = new();
						public LiteralInteger DelegationConnectors_P_PWP_assert_A_Empty_Pattern_message_result_LiteralInteger88 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_assert_A_Empty_Pattern_message_result_LiteralUnlimitedNatural89 = new();
					public LiteralString DelegationConnectors_P_PWP_assert_A_Empty_Pattern_message_LiteralString90 = new();
				public ActivityParameterNode DelegationConnectors_P_PWP_assert_A_Empty_Pattern_a_Empty_Pattern_node = new();
					public LiteralInteger DelegationConnectors_P_PWP_assert_A_Empty_Pattern_a_Empty_Pattern_node_LiteralInteger91 = new();
				public Parameter DelegationConnectors_P_PWP_assert_A_Empty_Pattern_a_Empty_Pattern = new();
			public Activity DelegationConnectors_P_PWP_main = new();
				public CallBehaviorAction DelegationConnectors_P_PWP_main_assert_A_Star_Pattern = new();
					public InputPin DelegationConnectors_P_PWP_main_assert_A_Star_Pattern_a_Star_Pattern = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_main_assert_A_Star_Pattern_a_Star_Pattern_LiteralUnlimitedNatural92 = new();
						public LiteralInteger DelegationConnectors_P_PWP_main_assert_A_Star_Pattern_a_Star_Pattern_LiteralInteger93 = new();
						public LiteralInteger DelegationConnectors_P_PWP_main_assert_A_Star_Pattern_a_Star_Pattern_LiteralInteger94 = new();
				public CallBehaviorAction DelegationConnectors_P_PWP_main_instantiate_A_Empty_Pattern = new();
					public OutputPin DelegationConnectors_P_PWP_main_instantiate_A_Empty_Pattern_a_Empty_Pattern = new();
						public LiteralInteger DelegationConnectors_P_PWP_main_instantiate_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger95 = new();
						public LiteralInteger DelegationConnectors_P_PWP_main_instantiate_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger96 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_main_instantiate_A_Empty_Pattern_a_Empty_Pattern_LiteralUnlimitedNatural97 = new();
				public CallBehaviorAction DelegationConnectors_P_PWP_main_instantiate_A_Array_Pattern = new();
					public OutputPin DelegationConnectors_P_PWP_main_instantiate_A_Array_Pattern_a_Array_Pattern = new();
						public LiteralInteger DelegationConnectors_P_PWP_main_instantiate_A_Array_Pattern_a_Array_Pattern_LiteralInteger98 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_main_instantiate_A_Array_Pattern_a_Array_Pattern_LiteralUnlimitedNatural99 = new();
						public LiteralInteger DelegationConnectors_P_PWP_main_instantiate_A_Array_Pattern_a_Array_Pattern_LiteralInteger100 = new();
				public ObjectFlow DelegationConnectors_P_PWP_main_ObjectFlow101 = new();
					public LiteralBoolean DelegationConnectors_P_PWP_main_ObjectFlow101_LiteralBoolean102 = new();
					public LiteralInteger DelegationConnectors_P_PWP_main_ObjectFlow101_LiteralInteger103 = new();
				public ObjectFlow DelegationConnectors_P_PWP_main_ObjectFlow104 = new();
					public LiteralInteger DelegationConnectors_P_PWP_main_ObjectFlow104_LiteralInteger105 = new();
					public LiteralBoolean DelegationConnectors_P_PWP_main_ObjectFlow104_LiteralBoolean106 = new();
				public CallBehaviorAction DelegationConnectors_P_PWP_main_instantiate_A_Unconnected_Pattern = new();
					public OutputPin DelegationConnectors_P_PWP_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern = new();
						public LiteralInteger DelegationConnectors_P_PWP_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger107 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralUnlimitedNatural108 = new();
						public LiteralInteger DelegationConnectors_P_PWP_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger109 = new();
				public ObjectFlow DelegationConnectors_P_PWP_main_ObjectFlow110 = new();
					public LiteralBoolean DelegationConnectors_P_PWP_main_ObjectFlow110_LiteralBoolean111 = new();
					public LiteralInteger DelegationConnectors_P_PWP_main_ObjectFlow110_LiteralInteger112 = new();
				public CallBehaviorAction DelegationConnectors_P_PWP_main_assert_A_Unconnected_Pattern = new();
					public InputPin DelegationConnectors_P_PWP_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern = new();
						public LiteralInteger DelegationConnectors_P_PWP_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger113 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralUnlimitedNatural114 = new();
						public LiteralInteger DelegationConnectors_P_PWP_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger115 = new();
				public ObjectFlow DelegationConnectors_P_PWP_main_ObjectFlow116 = new();
					public LiteralBoolean DelegationConnectors_P_PWP_main_ObjectFlow116_LiteralBoolean117 = new();
					public LiteralInteger DelegationConnectors_P_PWP_main_ObjectFlow116_LiteralInteger118 = new();
				public CallBehaviorAction DelegationConnectors_P_PWP_main_assert_A_Array_Pattern = new();
					public InputPin DelegationConnectors_P_PWP_main_assert_A_Array_Pattern_a_Array_Pattern = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_main_assert_A_Array_Pattern_a_Array_Pattern_LiteralUnlimitedNatural119 = new();
						public LiteralInteger DelegationConnectors_P_PWP_main_assert_A_Array_Pattern_a_Array_Pattern_LiteralInteger120 = new();
						public LiteralInteger DelegationConnectors_P_PWP_main_assert_A_Array_Pattern_a_Array_Pattern_LiteralInteger121 = new();
				public CallBehaviorAction DelegationConnectors_P_PWP_main_assert_A_Empty_Pattern = new();
					public InputPin DelegationConnectors_P_PWP_main_assert_A_Empty_Pattern_a_Empty_Pattern = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_main_assert_A_Empty_Pattern_a_Empty_Pattern_LiteralUnlimitedNatural122 = new();
						public LiteralInteger DelegationConnectors_P_PWP_main_assert_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger123 = new();
						public LiteralInteger DelegationConnectors_P_PWP_main_assert_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger124 = new();
				public CallBehaviorAction DelegationConnectors_P_PWP_main_instantiate_A_Star_Pattern = new();
					public OutputPin DelegationConnectors_P_PWP_main_instantiate_A_Star_Pattern_a_Star_Pattern = new();
						public LiteralInteger DelegationConnectors_P_PWP_main_instantiate_A_Star_Pattern_a_Star_Pattern_LiteralInteger125 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_main_instantiate_A_Star_Pattern_a_Star_Pattern_LiteralUnlimitedNatural126 = new();
						public LiteralInteger DelegationConnectors_P_PWP_main_instantiate_A_Star_Pattern_a_Star_Pattern_LiteralInteger127 = new();
				public ControlFlow DelegationConnectors_P_PWP_main_ControlFlow128 = new();
				public ControlFlow DelegationConnectors_P_PWP_main_ControlFlow129 = new();
				public ControlFlow DelegationConnectors_P_PWP_main_ControlFlow130 = new();
			public Class_ DelegationConnectors_P_PWP_A_Unconnected_Pattern = new();
				public Port DelegationConnectors_P_PWP_A_Unconnected_Pattern_p = new();
					public LiteralInteger DelegationConnectors_P_PWP_A_Unconnected_Pattern_p_LiteralInteger131 = new();
					public LiteralUnlimitedNatural DelegationConnectors_P_PWP_A_Unconnected_Pattern_p_LiteralUnlimitedNatural132 = new();
				public Operation DelegationConnectors_P_PWP_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern = new();
					public Parameter DelegationConnectors_P_PWP_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result = new();
				public Property DelegationConnectors_P_PWP_A_Unconnected_Pattern_b = new();
					public LiteralInteger DelegationConnectors_P_PWP_A_Unconnected_Pattern_b_LiteralInteger133 = new();
					public LiteralUnlimitedNatural DelegationConnectors_P_PWP_A_Unconnected_Pattern_b_LiteralUnlimitedNatural134 = new();
				public Connector DelegationConnectors_P_PWP_A_Unconnected_Pattern_r = new();
					public ConnectorEnd DelegationConnectors_P_PWP_A_Unconnected_Pattern_r_ConnectorEnd135 = new();
						public LiteralInteger DelegationConnectors_P_PWP_A_Unconnected_Pattern_r_ConnectorEnd135_LiteralInteger136 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_A_Unconnected_Pattern_r_ConnectorEnd135_LiteralUnlimitedNatural137 = new();
					public ConnectorEnd DelegationConnectors_P_PWP_A_Unconnected_Pattern_r_ConnectorEnd138 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_A_Unconnected_Pattern_r_ConnectorEnd138_LiteralUnlimitedNatural139 = new();
						public LiteralInteger DelegationConnectors_P_PWP_A_Unconnected_Pattern_r_ConnectorEnd138_LiteralInteger140 = new();
				public Comment DelegationConnectors_P_PWP_A_Unconnected_Pattern_Comment141 = new();
			public Activity DelegationConnectors_P_PWP_instantiate_A_Star_Pattern = new();
				public Parameter DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_a_Star_Pattern = new();
				public CallOperationAction DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_A_Star_Pattern_ = new();
					public OutputPin DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__result = new();
						public LiteralInteger DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__result_LiteralInteger142 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__result_LiteralUnlimitedNatural143 = new();
						public LiteralInteger DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__result_LiteralInteger144 = new();
					public InputPin DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__target = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__target_LiteralUnlimitedNatural145 = new();
						public LiteralInteger DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__target_LiteralInteger146 = new();
				public ObjectFlow DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_ObjectFlow147 = new();
					public LiteralBoolean DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_ObjectFlow147_LiteralBoolean148 = new();
					public LiteralInteger DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_ObjectFlow147_LiteralInteger149 = new();
				public CreateObjectAction DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern = new();
					public OutputPin DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result = new();
						public LiteralInteger DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result_LiteralInteger150 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result_LiteralUnlimitedNatural151 = new();
				public ObjectFlow DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_ObjectFlow152 = new();
					public LiteralInteger DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_ObjectFlow152_LiteralInteger153 = new();
					public LiteralBoolean DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_ObjectFlow152_LiteralBoolean154 = new();
				public ActivityParameterNode DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_a_Star_Pattern_node = new();
			public Activity DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern = new();
				public ValueSpecificationAction DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_message = new();
					public LiteralString DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_message_LiteralString155 = new();
					public OutputPin DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_message_result = new();
						public LiteralInteger DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_message_result_LiteralInteger156 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_message_result_LiteralUnlimitedNatural157 = new();
				public Parameter DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_a_Unconnected_Pattern = new();
				public ObjectFlow DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_ObjectFlow158 = new();
					public LiteralBoolean DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_ObjectFlow158_LiteralBoolean159 = new();
					public LiteralInteger DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_ObjectFlow158_LiteralInteger160 = new();
				public CallBehaviorAction DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine = new();
					public OutputPin DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine_errorStatus = new();
						public LiteralInteger DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine_errorStatus_LiteralInteger161 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural162 = new();
						public LiteralInteger DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine_errorStatus_LiteralInteger163 = new();
					public InputPin DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine_value = new();
						public LiteralInteger DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine_value_LiteralInteger164 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine_value_LiteralUnlimitedNatural165 = new();
						public LiteralInteger DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine_value_LiteralInteger166 = new();
				public ActivityParameterNode DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node = new();
					public LiteralInteger DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node_LiteralInteger167 = new();
			public Class_ DelegationConnectors_P_PWP_A_Empty_Pattern = new();
				public Property DelegationConnectors_P_PWP_A_Empty_Pattern_b = new();
					public LiteralInteger DelegationConnectors_P_PWP_A_Empty_Pattern_b_LiteralInteger168 = new();
					public LiteralUnlimitedNatural DelegationConnectors_P_PWP_A_Empty_Pattern_b_LiteralUnlimitedNatural169 = new();
				public Operation DelegationConnectors_P_PWP_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern = new();
					public Parameter DelegationConnectors_P_PWP_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result = new();
				public Comment DelegationConnectors_P_PWP_A_Empty_Pattern_Comment170 = new();
				public Port DelegationConnectors_P_PWP_A_Empty_Pattern_p = new();
					public LiteralInteger DelegationConnectors_P_PWP_A_Empty_Pattern_p_LiteralInteger171 = new();
					public LiteralUnlimitedNatural DelegationConnectors_P_PWP_A_Empty_Pattern_p_LiteralUnlimitedNatural172 = new();
				public Connector DelegationConnectors_P_PWP_A_Empty_Pattern_r = new();
					public ConnectorEnd DelegationConnectors_P_PWP_A_Empty_Pattern_r_ConnectorEnd173 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_A_Empty_Pattern_r_ConnectorEnd173_LiteralUnlimitedNatural174 = new();
					public ConnectorEnd DelegationConnectors_P_PWP_A_Empty_Pattern_r_ConnectorEnd175 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_A_Empty_Pattern_r_ConnectorEnd175_LiteralUnlimitedNatural176 = new();
			public Activity DelegationConnectors_P_PWP_assert_A_Star_Pattern = new();
				public ActivityParameterNode DelegationConnectors_P_PWP_assert_A_Star_Pattern_a_Star_Pattern_node = new();
					public LiteralInteger DelegationConnectors_P_PWP_assert_A_Star_Pattern_a_Star_Pattern_node_LiteralInteger177 = new();
				public ValueSpecificationAction DelegationConnectors_P_PWP_assert_A_Star_Pattern_message = new();
					public LiteralString DelegationConnectors_P_PWP_assert_A_Star_Pattern_message_LiteralString178 = new();
					public OutputPin DelegationConnectors_P_PWP_assert_A_Star_Pattern_message_result = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_assert_A_Star_Pattern_message_result_LiteralUnlimitedNatural179 = new();
						public LiteralInteger DelegationConnectors_P_PWP_assert_A_Star_Pattern_message_result_LiteralInteger180 = new();
				public Parameter DelegationConnectors_P_PWP_assert_A_Star_Pattern_a_Star_Pattern = new();
				public CallBehaviorAction DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine = new();
					public InputPin DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine_value = new();
						public LiteralInteger DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine_value_LiteralInteger181 = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine_value_LiteralUnlimitedNatural182 = new();
						public LiteralInteger DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine_value_LiteralInteger183 = new();
					public OutputPin DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine_errorStatus = new();
						public LiteralUnlimitedNatural DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural184 = new();
						public LiteralInteger DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine_errorStatus_LiteralInteger185 = new();
						public LiteralInteger DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine_errorStatus_LiteralInteger186 = new();
				public ObjectFlow DelegationConnectors_P_PWP_assert_A_Star_Pattern_ObjectFlow187 = new();
					public LiteralInteger DelegationConnectors_P_PWP_assert_A_Star_Pattern_ObjectFlow187_LiteralInteger188 = new();
					public LiteralBoolean DelegationConnectors_P_PWP_assert_A_Star_Pattern_ObjectFlow187_LiteralBoolean189 = new();

		public static DelegationConnectors_P_PWPModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public DelegationConnectors_P_PWPModel()
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
			 * Model DelegationConnectors_P_PWP
			 */
			AddToElementRepository("DelegationConnectors_P_PWP", DelegationConnectors_P_PWP);
				AddToElementRepository("B", DelegationConnectors_P_PWP_B);
					AddToElementRepository("q", DelegationConnectors_P_PWP_B_q);
						AddToElementRepository("LiteralInteger0", DelegationConnectors_P_PWP_B_q_LiteralInteger0);
						AddToElementRepository("LiteralUnlimitedNatural1", DelegationConnectors_P_PWP_B_q_LiteralUnlimitedNatural1);
				AddToElementRepository("R", DelegationConnectors_P_PWP_R);
					AddToElementRepository("x", DelegationConnectors_P_PWP_R_x);
						AddToElementRepository("LiteralInteger2", DelegationConnectors_P_PWP_R_x_LiteralInteger2);
						AddToElementRepository("LiteralUnlimitedNatural3", DelegationConnectors_P_PWP_R_x_LiteralUnlimitedNatural3);
					AddToElementRepository("y", DelegationConnectors_P_PWP_R_y);
						AddToElementRepository("LiteralUnlimitedNatural4", DelegationConnectors_P_PWP_R_y_LiteralUnlimitedNatural4);
						AddToElementRepository("LiteralInteger5", DelegationConnectors_P_PWP_R_y_LiteralInteger5);
				AddToElementRepository("I", DelegationConnectors_P_PWP_I);
				AddToElementRepository("assert_A_Array_Pattern", DelegationConnectors_P_PWP_assert_A_Array_Pattern);
					AddToElementRepository("a_Array_Pattern", DelegationConnectors_P_PWP_assert_A_Array_Pattern_a_Array_Pattern);
					AddToElementRepository("ObjectFlow6", DelegationConnectors_P_PWP_assert_A_Array_Pattern_ObjectFlow6);
						AddToElementRepository("LiteralInteger7", DelegationConnectors_P_PWP_assert_A_Array_Pattern_ObjectFlow6_LiteralInteger7);
						AddToElementRepository("LiteralBoolean8", DelegationConnectors_P_PWP_assert_A_Array_Pattern_ObjectFlow6_LiteralBoolean8);
					AddToElementRepository("writeLine", DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine);
						AddToElementRepository("value", DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine_value);
							AddToElementRepository("LiteralInteger9", DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine_value_LiteralInteger9);
							AddToElementRepository("LiteralInteger10", DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine_value_LiteralInteger10);
							AddToElementRepository("LiteralUnlimitedNatural11", DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine_value_LiteralUnlimitedNatural11);
						AddToElementRepository("errorStatus", DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine_errorStatus);
							AddToElementRepository("LiteralInteger12", DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine_errorStatus_LiteralInteger12);
							AddToElementRepository("LiteralInteger13", DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine_errorStatus_LiteralInteger13);
							AddToElementRepository("LiteralUnlimitedNatural14", DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural14);
					AddToElementRepository("a_Array_Pattern_node", DelegationConnectors_P_PWP_assert_A_Array_Pattern_a_Array_Pattern_node);
						AddToElementRepository("LiteralInteger15", DelegationConnectors_P_PWP_assert_A_Array_Pattern_a_Array_Pattern_node_LiteralInteger15);
					AddToElementRepository("message", DelegationConnectors_P_PWP_assert_A_Array_Pattern_message);
						AddToElementRepository("LiteralString16", DelegationConnectors_P_PWP_assert_A_Array_Pattern_message_LiteralString16);
						AddToElementRepository("result", DelegationConnectors_P_PWP_assert_A_Array_Pattern_message_result);
							AddToElementRepository("LiteralInteger17", DelegationConnectors_P_PWP_assert_A_Array_Pattern_message_result_LiteralInteger17);
							AddToElementRepository("LiteralUnlimitedNatural18", DelegationConnectors_P_PWP_assert_A_Array_Pattern_message_result_LiteralUnlimitedNatural18);
				AddToElementRepository("A_Star_Pattern", DelegationConnectors_P_PWP_A_Star_Pattern);
					AddToElementRepository("b", DelegationConnectors_P_PWP_A_Star_Pattern_b);
						AddToElementRepository("LiteralInteger19", DelegationConnectors_P_PWP_A_Star_Pattern_b_LiteralInteger19);
						AddToElementRepository("LiteralUnlimitedNatural20", DelegationConnectors_P_PWP_A_Star_Pattern_b_LiteralUnlimitedNatural20);
					AddToElementRepository("p", DelegationConnectors_P_PWP_A_Star_Pattern_p);
						AddToElementRepository("LiteralInteger21", DelegationConnectors_P_PWP_A_Star_Pattern_p_LiteralInteger21);
						AddToElementRepository("LiteralUnlimitedNatural22", DelegationConnectors_P_PWP_A_Star_Pattern_p_LiteralUnlimitedNatural22);
					AddToElementRepository("r", DelegationConnectors_P_PWP_A_Star_Pattern_r);
						AddToElementRepository("ConnectorEnd23", DelegationConnectors_P_PWP_A_Star_Pattern_r_ConnectorEnd23);
							AddToElementRepository("LiteralInteger24", DelegationConnectors_P_PWP_A_Star_Pattern_r_ConnectorEnd23_LiteralInteger24);
							AddToElementRepository("LiteralUnlimitedNatural25", DelegationConnectors_P_PWP_A_Star_Pattern_r_ConnectorEnd23_LiteralUnlimitedNatural25);
						AddToElementRepository("ConnectorEnd26", DelegationConnectors_P_PWP_A_Star_Pattern_r_ConnectorEnd26);
							AddToElementRepository("LiteralUnlimitedNatural27", DelegationConnectors_P_PWP_A_Star_Pattern_r_ConnectorEnd26_LiteralUnlimitedNatural27);
							AddToElementRepository("LiteralInteger28", DelegationConnectors_P_PWP_A_Star_Pattern_r_ConnectorEnd26_LiteralInteger28);
					AddToElementRepository("Comment29", DelegationConnectors_P_PWP_A_Star_Pattern_Comment29);
					AddToElementRepository("A_Star_Pattern_A_Star_Pattern", DelegationConnectors_P_PWP_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern);
						AddToElementRepository("result", DelegationConnectors_P_PWP_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result);
				AddToElementRepository("IImpl", DelegationConnectors_P_PWP_IImpl);
					AddToElementRepository("I_Realization", DelegationConnectors_P_PWP_IImpl_I_Realization);
				AddToElementRepository("instantiate_A_Unconnected_Pattern", DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern);
					AddToElementRepository("a_Unconnected_Pattern", DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern);
					AddToElementRepository("Create A_Unconnected_Pattern", DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern);
						AddToElementRepository("result", DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result);
							AddToElementRepository("LiteralInteger30", DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result_LiteralInteger30);
							AddToElementRepository("LiteralUnlimitedNatural31", DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result_LiteralUnlimitedNatural31);
					AddToElementRepository("ObjectFlow32", DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow32);
						AddToElementRepository("LiteralBoolean33", DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow32_LiteralBoolean33);
						AddToElementRepository("LiteralInteger34", DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow32_LiteralInteger34);
					AddToElementRepository("a_Unconnected_Pattern_node", DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node);
					AddToElementRepository("ObjectFlow35", DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow35);
						AddToElementRepository("LiteralInteger36", DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow35_LiteralInteger36);
						AddToElementRepository("LiteralBoolean37", DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow35_LiteralBoolean37);
					AddToElementRepository("A_Unconnected_Pattern()", DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_);
						AddToElementRepository("result", DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result);
							AddToElementRepository("LiteralUnlimitedNatural38", DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result_LiteralUnlimitedNatural38);
							AddToElementRepository("LiteralInteger39", DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result_LiteralInteger39);
							AddToElementRepository("LiteralInteger40", DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result_LiteralInteger40);
						AddToElementRepository("target", DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target);
							AddToElementRepository("LiteralInteger41", DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target_LiteralInteger41);
							AddToElementRepository("LiteralUnlimitedNatural42", DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target_LiteralUnlimitedNatural42);
				AddToElementRepository("instantiate_A_Empty_Pattern", DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern);
					AddToElementRepository("ObjectFlow43", DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_ObjectFlow43);
						AddToElementRepository("LiteralInteger44", DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_ObjectFlow43_LiteralInteger44);
						AddToElementRepository("LiteralBoolean45", DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_ObjectFlow43_LiteralBoolean45);
					AddToElementRepository("ObjectFlow46", DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_ObjectFlow46);
						AddToElementRepository("LiteralInteger47", DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_ObjectFlow46_LiteralInteger47);
						AddToElementRepository("LiteralBoolean48", DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_ObjectFlow46_LiteralBoolean48);
					AddToElementRepository("Create A_Empty_Pattern", DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern);
						AddToElementRepository("result", DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result);
							AddToElementRepository("LiteralInteger49", DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result_LiteralInteger49);
							AddToElementRepository("LiteralUnlimitedNatural50", DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result_LiteralUnlimitedNatural50);
					AddToElementRepository("A_Empty_Pattern()", DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern_);
						AddToElementRepository("target", DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__target);
							AddToElementRepository("LiteralUnlimitedNatural51", DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__target_LiteralUnlimitedNatural51);
							AddToElementRepository("LiteralInteger52", DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__target_LiteralInteger52);
						AddToElementRepository("result", DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__result);
							AddToElementRepository("LiteralInteger53", DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__result_LiteralInteger53);
							AddToElementRepository("LiteralUnlimitedNatural54", DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__result_LiteralUnlimitedNatural54);
							AddToElementRepository("LiteralInteger55", DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__result_LiteralInteger55);
					AddToElementRepository("a_Empty_Pattern_node", DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_a_Empty_Pattern_node);
					AddToElementRepository("a_Empty_Pattern", DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_a_Empty_Pattern);
				AddToElementRepository("instantiate_A_Array_Pattern", DelegationConnectors_P_PWP_instantiate_A_Array_Pattern);
					AddToElementRepository("ObjectFlow56", DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_ObjectFlow56);
						AddToElementRepository("LiteralBoolean57", DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_ObjectFlow56_LiteralBoolean57);
						AddToElementRepository("LiteralInteger58", DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_ObjectFlow56_LiteralInteger58);
					AddToElementRepository("a_Array_Pattern_node", DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_a_Array_Pattern_node);
						AddToElementRepository("LiteralInteger59", DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_a_Array_Pattern_node_LiteralInteger59);
					AddToElementRepository("Create A_Array_Pattern", DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern);
						AddToElementRepository("result", DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result);
							AddToElementRepository("LiteralUnlimitedNatural60", DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result_LiteralUnlimitedNatural60);
							AddToElementRepository("LiteralInteger61", DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result_LiteralInteger61);
					AddToElementRepository("a_Array_Pattern", DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_a_Array_Pattern);
					AddToElementRepository("ObjectFlow62", DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_ObjectFlow62);
						AddToElementRepository("LiteralBoolean63", DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_ObjectFlow62_LiteralBoolean63);
						AddToElementRepository("LiteralInteger64", DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_ObjectFlow62_LiteralInteger64);
					AddToElementRepository("A_Array_Pattern()", DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_A_Array_Pattern_);
						AddToElementRepository("target", DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__target);
							AddToElementRepository("LiteralUnlimitedNatural65", DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__target_LiteralUnlimitedNatural65);
							AddToElementRepository("LiteralInteger66", DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__target_LiteralInteger66);
						AddToElementRepository("result", DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__result);
							AddToElementRepository("LiteralUnlimitedNatural67", DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__result_LiteralUnlimitedNatural67);
							AddToElementRepository("LiteralInteger68", DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__result_LiteralInteger68);
							AddToElementRepository("LiteralInteger69", DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__result_LiteralInteger69);
				AddToElementRepository("A_Array_Pattern", DelegationConnectors_P_PWP_A_Array_Pattern);
					AddToElementRepository("Comment70", DelegationConnectors_P_PWP_A_Array_Pattern_Comment70);
					AddToElementRepository("r", DelegationConnectors_P_PWP_A_Array_Pattern_r);
						AddToElementRepository("ConnectorEnd71", DelegationConnectors_P_PWP_A_Array_Pattern_r_ConnectorEnd71);
							AddToElementRepository("LiteralUnlimitedNatural72", DelegationConnectors_P_PWP_A_Array_Pattern_r_ConnectorEnd71_LiteralUnlimitedNatural72);
						AddToElementRepository("ConnectorEnd73", DelegationConnectors_P_PWP_A_Array_Pattern_r_ConnectorEnd73);
							AddToElementRepository("LiteralUnlimitedNatural74", DelegationConnectors_P_PWP_A_Array_Pattern_r_ConnectorEnd73_LiteralUnlimitedNatural74);
					AddToElementRepository("b", DelegationConnectors_P_PWP_A_Array_Pattern_b);
						AddToElementRepository("LiteralUnlimitedNatural75", DelegationConnectors_P_PWP_A_Array_Pattern_b_LiteralUnlimitedNatural75);
						AddToElementRepository("LiteralInteger76", DelegationConnectors_P_PWP_A_Array_Pattern_b_LiteralInteger76);
					AddToElementRepository("A_Array_Pattern_A_Array_Pattern", DelegationConnectors_P_PWP_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern);
						AddToElementRepository("result", DelegationConnectors_P_PWP_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result);
					AddToElementRepository("p", DelegationConnectors_P_PWP_A_Array_Pattern_p);
						AddToElementRepository("LiteralInteger77", DelegationConnectors_P_PWP_A_Array_Pattern_p_LiteralInteger77);
						AddToElementRepository("LiteralUnlimitedNatural78", DelegationConnectors_P_PWP_A_Array_Pattern_p_LiteralUnlimitedNatural78);
				AddToElementRepository("assert_A_Empty_Pattern", DelegationConnectors_P_PWP_assert_A_Empty_Pattern);
					AddToElementRepository("ObjectFlow79", DelegationConnectors_P_PWP_assert_A_Empty_Pattern_ObjectFlow79);
						AddToElementRepository("LiteralInteger80", DelegationConnectors_P_PWP_assert_A_Empty_Pattern_ObjectFlow79_LiteralInteger80);
						AddToElementRepository("LiteralBoolean81", DelegationConnectors_P_PWP_assert_A_Empty_Pattern_ObjectFlow79_LiteralBoolean81);
					AddToElementRepository("writeLine", DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine);
						AddToElementRepository("errorStatus", DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine_errorStatus);
							AddToElementRepository("LiteralInteger82", DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine_errorStatus_LiteralInteger82);
							AddToElementRepository("LiteralInteger83", DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine_errorStatus_LiteralInteger83);
							AddToElementRepository("LiteralUnlimitedNatural84", DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural84);
						AddToElementRepository("value", DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine_value);
							AddToElementRepository("LiteralInteger85", DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine_value_LiteralInteger85);
							AddToElementRepository("LiteralUnlimitedNatural86", DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine_value_LiteralUnlimitedNatural86);
							AddToElementRepository("LiteralInteger87", DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine_value_LiteralInteger87);
					AddToElementRepository("message", DelegationConnectors_P_PWP_assert_A_Empty_Pattern_message);
						AddToElementRepository("result", DelegationConnectors_P_PWP_assert_A_Empty_Pattern_message_result);
							AddToElementRepository("LiteralInteger88", DelegationConnectors_P_PWP_assert_A_Empty_Pattern_message_result_LiteralInteger88);
							AddToElementRepository("LiteralUnlimitedNatural89", DelegationConnectors_P_PWP_assert_A_Empty_Pattern_message_result_LiteralUnlimitedNatural89);
						AddToElementRepository("LiteralString90", DelegationConnectors_P_PWP_assert_A_Empty_Pattern_message_LiteralString90);
					AddToElementRepository("a_Empty_Pattern_node", DelegationConnectors_P_PWP_assert_A_Empty_Pattern_a_Empty_Pattern_node);
						AddToElementRepository("LiteralInteger91", DelegationConnectors_P_PWP_assert_A_Empty_Pattern_a_Empty_Pattern_node_LiteralInteger91);
					AddToElementRepository("a_Empty_Pattern", DelegationConnectors_P_PWP_assert_A_Empty_Pattern_a_Empty_Pattern);
				AddToElementRepository("main", DelegationConnectors_P_PWP_main);
					AddToElementRepository("assert_A_Star_Pattern", DelegationConnectors_P_PWP_main_assert_A_Star_Pattern);
						AddToElementRepository("a_Star_Pattern", DelegationConnectors_P_PWP_main_assert_A_Star_Pattern_a_Star_Pattern);
							AddToElementRepository("LiteralUnlimitedNatural92", DelegationConnectors_P_PWP_main_assert_A_Star_Pattern_a_Star_Pattern_LiteralUnlimitedNatural92);
							AddToElementRepository("LiteralInteger93", DelegationConnectors_P_PWP_main_assert_A_Star_Pattern_a_Star_Pattern_LiteralInteger93);
							AddToElementRepository("LiteralInteger94", DelegationConnectors_P_PWP_main_assert_A_Star_Pattern_a_Star_Pattern_LiteralInteger94);
					AddToElementRepository("instantiate_A_Empty_Pattern", DelegationConnectors_P_PWP_main_instantiate_A_Empty_Pattern);
						AddToElementRepository("a_Empty_Pattern", DelegationConnectors_P_PWP_main_instantiate_A_Empty_Pattern_a_Empty_Pattern);
							AddToElementRepository("LiteralInteger95", DelegationConnectors_P_PWP_main_instantiate_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger95);
							AddToElementRepository("LiteralInteger96", DelegationConnectors_P_PWP_main_instantiate_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger96);
							AddToElementRepository("LiteralUnlimitedNatural97", DelegationConnectors_P_PWP_main_instantiate_A_Empty_Pattern_a_Empty_Pattern_LiteralUnlimitedNatural97);
					AddToElementRepository("instantiate_A_Array_Pattern", DelegationConnectors_P_PWP_main_instantiate_A_Array_Pattern);
						AddToElementRepository("a_Array_Pattern", DelegationConnectors_P_PWP_main_instantiate_A_Array_Pattern_a_Array_Pattern);
							AddToElementRepository("LiteralInteger98", DelegationConnectors_P_PWP_main_instantiate_A_Array_Pattern_a_Array_Pattern_LiteralInteger98);
							AddToElementRepository("LiteralUnlimitedNatural99", DelegationConnectors_P_PWP_main_instantiate_A_Array_Pattern_a_Array_Pattern_LiteralUnlimitedNatural99);
							AddToElementRepository("LiteralInteger100", DelegationConnectors_P_PWP_main_instantiate_A_Array_Pattern_a_Array_Pattern_LiteralInteger100);
					AddToElementRepository("ObjectFlow101", DelegationConnectors_P_PWP_main_ObjectFlow101);
						AddToElementRepository("LiteralBoolean102", DelegationConnectors_P_PWP_main_ObjectFlow101_LiteralBoolean102);
						AddToElementRepository("LiteralInteger103", DelegationConnectors_P_PWP_main_ObjectFlow101_LiteralInteger103);
					AddToElementRepository("ObjectFlow104", DelegationConnectors_P_PWP_main_ObjectFlow104);
						AddToElementRepository("LiteralInteger105", DelegationConnectors_P_PWP_main_ObjectFlow104_LiteralInteger105);
						AddToElementRepository("LiteralBoolean106", DelegationConnectors_P_PWP_main_ObjectFlow104_LiteralBoolean106);
					AddToElementRepository("instantiate_A_Unconnected_Pattern", DelegationConnectors_P_PWP_main_instantiate_A_Unconnected_Pattern);
						AddToElementRepository("a_Unconnected_Pattern", DelegationConnectors_P_PWP_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern);
							AddToElementRepository("LiteralInteger107", DelegationConnectors_P_PWP_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger107);
							AddToElementRepository("LiteralUnlimitedNatural108", DelegationConnectors_P_PWP_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralUnlimitedNatural108);
							AddToElementRepository("LiteralInteger109", DelegationConnectors_P_PWP_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger109);
					AddToElementRepository("ObjectFlow110", DelegationConnectors_P_PWP_main_ObjectFlow110);
						AddToElementRepository("LiteralBoolean111", DelegationConnectors_P_PWP_main_ObjectFlow110_LiteralBoolean111);
						AddToElementRepository("LiteralInteger112", DelegationConnectors_P_PWP_main_ObjectFlow110_LiteralInteger112);
					AddToElementRepository("assert_A_Unconnected_Pattern", DelegationConnectors_P_PWP_main_assert_A_Unconnected_Pattern);
						AddToElementRepository("a_Unconnected_Pattern", DelegationConnectors_P_PWP_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern);
							AddToElementRepository("LiteralInteger113", DelegationConnectors_P_PWP_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger113);
							AddToElementRepository("LiteralUnlimitedNatural114", DelegationConnectors_P_PWP_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralUnlimitedNatural114);
							AddToElementRepository("LiteralInteger115", DelegationConnectors_P_PWP_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_LiteralInteger115);
					AddToElementRepository("ObjectFlow116", DelegationConnectors_P_PWP_main_ObjectFlow116);
						AddToElementRepository("LiteralBoolean117", DelegationConnectors_P_PWP_main_ObjectFlow116_LiteralBoolean117);
						AddToElementRepository("LiteralInteger118", DelegationConnectors_P_PWP_main_ObjectFlow116_LiteralInteger118);
					AddToElementRepository("assert_A_Array_Pattern", DelegationConnectors_P_PWP_main_assert_A_Array_Pattern);
						AddToElementRepository("a_Array_Pattern", DelegationConnectors_P_PWP_main_assert_A_Array_Pattern_a_Array_Pattern);
							AddToElementRepository("LiteralUnlimitedNatural119", DelegationConnectors_P_PWP_main_assert_A_Array_Pattern_a_Array_Pattern_LiteralUnlimitedNatural119);
							AddToElementRepository("LiteralInteger120", DelegationConnectors_P_PWP_main_assert_A_Array_Pattern_a_Array_Pattern_LiteralInteger120);
							AddToElementRepository("LiteralInteger121", DelegationConnectors_P_PWP_main_assert_A_Array_Pattern_a_Array_Pattern_LiteralInteger121);
					AddToElementRepository("assert_A_Empty_Pattern", DelegationConnectors_P_PWP_main_assert_A_Empty_Pattern);
						AddToElementRepository("a_Empty_Pattern", DelegationConnectors_P_PWP_main_assert_A_Empty_Pattern_a_Empty_Pattern);
							AddToElementRepository("LiteralUnlimitedNatural122", DelegationConnectors_P_PWP_main_assert_A_Empty_Pattern_a_Empty_Pattern_LiteralUnlimitedNatural122);
							AddToElementRepository("LiteralInteger123", DelegationConnectors_P_PWP_main_assert_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger123);
							AddToElementRepository("LiteralInteger124", DelegationConnectors_P_PWP_main_assert_A_Empty_Pattern_a_Empty_Pattern_LiteralInteger124);
					AddToElementRepository("instantiate_A_Star_Pattern", DelegationConnectors_P_PWP_main_instantiate_A_Star_Pattern);
						AddToElementRepository("a_Star_Pattern", DelegationConnectors_P_PWP_main_instantiate_A_Star_Pattern_a_Star_Pattern);
							AddToElementRepository("LiteralInteger125", DelegationConnectors_P_PWP_main_instantiate_A_Star_Pattern_a_Star_Pattern_LiteralInteger125);
							AddToElementRepository("LiteralUnlimitedNatural126", DelegationConnectors_P_PWP_main_instantiate_A_Star_Pattern_a_Star_Pattern_LiteralUnlimitedNatural126);
							AddToElementRepository("LiteralInteger127", DelegationConnectors_P_PWP_main_instantiate_A_Star_Pattern_a_Star_Pattern_LiteralInteger127);
					AddToElementRepository("ControlFlow128", DelegationConnectors_P_PWP_main_ControlFlow128);
					AddToElementRepository("ControlFlow129", DelegationConnectors_P_PWP_main_ControlFlow129);
					AddToElementRepository("ControlFlow130", DelegationConnectors_P_PWP_main_ControlFlow130);
				AddToElementRepository("A_Unconnected_Pattern", DelegationConnectors_P_PWP_A_Unconnected_Pattern);
					AddToElementRepository("p", DelegationConnectors_P_PWP_A_Unconnected_Pattern_p);
						AddToElementRepository("LiteralInteger131", DelegationConnectors_P_PWP_A_Unconnected_Pattern_p_LiteralInteger131);
						AddToElementRepository("LiteralUnlimitedNatural132", DelegationConnectors_P_PWP_A_Unconnected_Pattern_p_LiteralUnlimitedNatural132);
					AddToElementRepository("A_Unconnected_Pattern_A_Unconnected_Pattern", DelegationConnectors_P_PWP_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern);
						AddToElementRepository("result", DelegationConnectors_P_PWP_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result);
					AddToElementRepository("b", DelegationConnectors_P_PWP_A_Unconnected_Pattern_b);
						AddToElementRepository("LiteralInteger133", DelegationConnectors_P_PWP_A_Unconnected_Pattern_b_LiteralInteger133);
						AddToElementRepository("LiteralUnlimitedNatural134", DelegationConnectors_P_PWP_A_Unconnected_Pattern_b_LiteralUnlimitedNatural134);
					AddToElementRepository("r", DelegationConnectors_P_PWP_A_Unconnected_Pattern_r);
						AddToElementRepository("ConnectorEnd135", DelegationConnectors_P_PWP_A_Unconnected_Pattern_r_ConnectorEnd135);
							AddToElementRepository("LiteralInteger136", DelegationConnectors_P_PWP_A_Unconnected_Pattern_r_ConnectorEnd135_LiteralInteger136);
							AddToElementRepository("LiteralUnlimitedNatural137", DelegationConnectors_P_PWP_A_Unconnected_Pattern_r_ConnectorEnd135_LiteralUnlimitedNatural137);
						AddToElementRepository("ConnectorEnd138", DelegationConnectors_P_PWP_A_Unconnected_Pattern_r_ConnectorEnd138);
							AddToElementRepository("LiteralUnlimitedNatural139", DelegationConnectors_P_PWP_A_Unconnected_Pattern_r_ConnectorEnd138_LiteralUnlimitedNatural139);
							AddToElementRepository("LiteralInteger140", DelegationConnectors_P_PWP_A_Unconnected_Pattern_r_ConnectorEnd138_LiteralInteger140);
					AddToElementRepository("Comment141", DelegationConnectors_P_PWP_A_Unconnected_Pattern_Comment141);
				AddToElementRepository("instantiate_A_Star_Pattern", DelegationConnectors_P_PWP_instantiate_A_Star_Pattern);
					AddToElementRepository("a_Star_Pattern", DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_a_Star_Pattern);
					AddToElementRepository("A_Star_Pattern()", DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_A_Star_Pattern_);
						AddToElementRepository("result", DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__result);
							AddToElementRepository("LiteralInteger142", DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__result_LiteralInteger142);
							AddToElementRepository("LiteralUnlimitedNatural143", DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__result_LiteralUnlimitedNatural143);
							AddToElementRepository("LiteralInteger144", DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__result_LiteralInteger144);
						AddToElementRepository("target", DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__target);
							AddToElementRepository("LiteralUnlimitedNatural145", DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__target_LiteralUnlimitedNatural145);
							AddToElementRepository("LiteralInteger146", DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__target_LiteralInteger146);
					AddToElementRepository("ObjectFlow147", DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_ObjectFlow147);
						AddToElementRepository("LiteralBoolean148", DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_ObjectFlow147_LiteralBoolean148);
						AddToElementRepository("LiteralInteger149", DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_ObjectFlow147_LiteralInteger149);
					AddToElementRepository("Create A_Star_Pattern", DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern);
						AddToElementRepository("result", DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result);
							AddToElementRepository("LiteralInteger150", DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result_LiteralInteger150);
							AddToElementRepository("LiteralUnlimitedNatural151", DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result_LiteralUnlimitedNatural151);
					AddToElementRepository("ObjectFlow152", DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_ObjectFlow152);
						AddToElementRepository("LiteralInteger153", DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_ObjectFlow152_LiteralInteger153);
						AddToElementRepository("LiteralBoolean154", DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_ObjectFlow152_LiteralBoolean154);
					AddToElementRepository("a_Star_Pattern_node", DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_a_Star_Pattern_node);
				AddToElementRepository("assert_A_Unconnected_Pattern", DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern);
					AddToElementRepository("message", DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_message);
						AddToElementRepository("LiteralString155", DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_message_LiteralString155);
						AddToElementRepository("result", DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_message_result);
							AddToElementRepository("LiteralInteger156", DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_message_result_LiteralInteger156);
							AddToElementRepository("LiteralUnlimitedNatural157", DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_message_result_LiteralUnlimitedNatural157);
					AddToElementRepository("a_Unconnected_Pattern", DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_a_Unconnected_Pattern);
					AddToElementRepository("ObjectFlow158", DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_ObjectFlow158);
						AddToElementRepository("LiteralBoolean159", DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_ObjectFlow158_LiteralBoolean159);
						AddToElementRepository("LiteralInteger160", DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_ObjectFlow158_LiteralInteger160);
					AddToElementRepository("writeLine", DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine);
						AddToElementRepository("errorStatus", DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine_errorStatus);
							AddToElementRepository("LiteralInteger161", DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine_errorStatus_LiteralInteger161);
							AddToElementRepository("LiteralUnlimitedNatural162", DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural162);
							AddToElementRepository("LiteralInteger163", DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine_errorStatus_LiteralInteger163);
						AddToElementRepository("value", DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine_value);
							AddToElementRepository("LiteralInteger164", DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine_value_LiteralInteger164);
							AddToElementRepository("LiteralUnlimitedNatural165", DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine_value_LiteralUnlimitedNatural165);
							AddToElementRepository("LiteralInteger166", DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine_value_LiteralInteger166);
					AddToElementRepository("a_Unconnected_Pattern_node", DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node);
						AddToElementRepository("LiteralInteger167", DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node_LiteralInteger167);
				AddToElementRepository("A_Empty_Pattern", DelegationConnectors_P_PWP_A_Empty_Pattern);
					AddToElementRepository("b", DelegationConnectors_P_PWP_A_Empty_Pattern_b);
						AddToElementRepository("LiteralInteger168", DelegationConnectors_P_PWP_A_Empty_Pattern_b_LiteralInteger168);
						AddToElementRepository("LiteralUnlimitedNatural169", DelegationConnectors_P_PWP_A_Empty_Pattern_b_LiteralUnlimitedNatural169);
					AddToElementRepository("A_Empty_Pattern_A_Empty_Pattern", DelegationConnectors_P_PWP_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern);
						AddToElementRepository("result", DelegationConnectors_P_PWP_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result);
					AddToElementRepository("Comment170", DelegationConnectors_P_PWP_A_Empty_Pattern_Comment170);
					AddToElementRepository("p", DelegationConnectors_P_PWP_A_Empty_Pattern_p);
						AddToElementRepository("LiteralInteger171", DelegationConnectors_P_PWP_A_Empty_Pattern_p_LiteralInteger171);
						AddToElementRepository("LiteralUnlimitedNatural172", DelegationConnectors_P_PWP_A_Empty_Pattern_p_LiteralUnlimitedNatural172);
					AddToElementRepository("r", DelegationConnectors_P_PWP_A_Empty_Pattern_r);
						AddToElementRepository("ConnectorEnd173", DelegationConnectors_P_PWP_A_Empty_Pattern_r_ConnectorEnd173);
							AddToElementRepository("LiteralUnlimitedNatural174", DelegationConnectors_P_PWP_A_Empty_Pattern_r_ConnectorEnd173_LiteralUnlimitedNatural174);
						AddToElementRepository("ConnectorEnd175", DelegationConnectors_P_PWP_A_Empty_Pattern_r_ConnectorEnd175);
							AddToElementRepository("LiteralUnlimitedNatural176", DelegationConnectors_P_PWP_A_Empty_Pattern_r_ConnectorEnd175_LiteralUnlimitedNatural176);
				AddToElementRepository("assert_A_Star_Pattern", DelegationConnectors_P_PWP_assert_A_Star_Pattern);
					AddToElementRepository("a_Star_Pattern_node", DelegationConnectors_P_PWP_assert_A_Star_Pattern_a_Star_Pattern_node);
						AddToElementRepository("LiteralInteger177", DelegationConnectors_P_PWP_assert_A_Star_Pattern_a_Star_Pattern_node_LiteralInteger177);
					AddToElementRepository("message", DelegationConnectors_P_PWP_assert_A_Star_Pattern_message);
						AddToElementRepository("LiteralString178", DelegationConnectors_P_PWP_assert_A_Star_Pattern_message_LiteralString178);
						AddToElementRepository("result", DelegationConnectors_P_PWP_assert_A_Star_Pattern_message_result);
							AddToElementRepository("LiteralUnlimitedNatural179", DelegationConnectors_P_PWP_assert_A_Star_Pattern_message_result_LiteralUnlimitedNatural179);
							AddToElementRepository("LiteralInteger180", DelegationConnectors_P_PWP_assert_A_Star_Pattern_message_result_LiteralInteger180);
					AddToElementRepository("a_Star_Pattern", DelegationConnectors_P_PWP_assert_A_Star_Pattern_a_Star_Pattern);
					AddToElementRepository("writeLine", DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine);
						AddToElementRepository("value", DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine_value);
							AddToElementRepository("LiteralInteger181", DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine_value_LiteralInteger181);
							AddToElementRepository("LiteralUnlimitedNatural182", DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine_value_LiteralUnlimitedNatural182);
							AddToElementRepository("LiteralInteger183", DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine_value_LiteralInteger183);
						AddToElementRepository("errorStatus", DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine_errorStatus);
							AddToElementRepository("LiteralUnlimitedNatural184", DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine_errorStatus_LiteralUnlimitedNatural184);
							AddToElementRepository("LiteralInteger185", DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine_errorStatus_LiteralInteger185);
							AddToElementRepository("LiteralInteger186", DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine_errorStatus_LiteralInteger186);
					AddToElementRepository("ObjectFlow187", DelegationConnectors_P_PWP_assert_A_Star_Pattern_ObjectFlow187);
						AddToElementRepository("LiteralInteger188", DelegationConnectors_P_PWP_assert_A_Star_Pattern_ObjectFlow187_LiteralInteger188);
						AddToElementRepository("LiteralBoolean189", DelegationConnectors_P_PWP_assert_A_Star_Pattern_ObjectFlow187_LiteralBoolean189);

			// Initialize public members
			/*
			 * Model DelegationConnectors_P_PWP
			 */
			DelegationConnectors_P_PWP.SetName("DelegationConnectors_P_PWP");
			DelegationConnectors_P_PWP.SetVisibility(VisibilityKind.public_);
				// Class B
				DelegationConnectors_P_PWP_B.SetName("B");
				DelegationConnectors_P_PWP_B.SetVisibility(VisibilityKind.public_);
				
					// Port q
					DelegationConnectors_P_PWP_B_q.SetName("q");
					DelegationConnectors_P_PWP_B_q.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_PWP_B_q.SetUpper(-1);
					DelegationConnectors_P_PWP_B_q.SetLower(2);
					DelegationConnectors_P_PWP_B_q.SetType(DelegationConnectors_P_PWP_IImpl);
					DelegationConnectors_P_PWP_B_q.SetAggregation(AggregationKind.composite);
					DelegationConnectors_P_PWP_B_q.isService = true;
					DelegationConnectors_P_PWP_B_q.AddProvided(DelegationConnectors_P_PWP_I);
				DelegationConnectors_P_PWP_B.AddOwnedAttribute(DelegationConnectors_P_PWP_B_q);
			DelegationConnectors_P_PWP.AddPackagedElement(DelegationConnectors_P_PWP_B);
				// Association R
				DelegationConnectors_P_PWP_R.SetName("R");
				DelegationConnectors_P_PWP_R.SetVisibility(VisibilityKind.public_);
				DelegationConnectors_P_PWP_R.AddOwnedEnd(DelegationConnectors_P_PWP_R_x);
				DelegationConnectors_P_PWP_R.AddOwnedEnd(DelegationConnectors_P_PWP_R_y);
			DelegationConnectors_P_PWP.AddPackagedElement(DelegationConnectors_P_PWP_R);
				// Interface I
				DelegationConnectors_P_PWP_I.SetName("I");
				DelegationConnectors_P_PWP_I.SetVisibility(VisibilityKind.public_);
			DelegationConnectors_P_PWP.AddPackagedElement(DelegationConnectors_P_PWP_I);
				// Activity assert_A_Array_Pattern
				DelegationConnectors_P_PWP_assert_A_Array_Pattern.SetName("assert_A_Array_Pattern");
				DelegationConnectors_P_PWP_assert_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Array_Pattern
					DelegationConnectors_P_PWP_assert_A_Array_Pattern_a_Array_Pattern.SetName("a_Array_Pattern");
					DelegationConnectors_P_PWP_assert_A_Array_Pattern_a_Array_Pattern.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_assert_A_Array_Pattern_a_Array_Pattern.SetType(DelegationConnectors_P_PWP_A_Array_Pattern);
				DelegationConnectors_P_PWP_assert_A_Array_Pattern.AddOwnedParameter(DelegationConnectors_P_PWP_assert_A_Array_Pattern_a_Array_Pattern);
					// CallBehaviorAction writeLine
					DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine.SetName("writeLine");
					DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine.SetVisibility(VisibilityKind.public_);
					
						// OutputPin errorStatus
						DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine_errorStatus.SetName("errorStatus");
						DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine_errorStatus.SetVisibility(VisibilityKind.public_);
						
						DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine_errorStatus.SetLower(0);
					DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine.AddResult(DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine_errorStatus);
					DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
						// InputPin value
						DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine_value.SetName("value");
						DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine_value.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine.AddArgument(DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine_value);
				DelegationConnectors_P_PWP_assert_A_Array_Pattern.AddNode(DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine);
					// ActivityParameterNode a_Array_Pattern_node
					DelegationConnectors_P_PWP_assert_A_Array_Pattern_a_Array_Pattern_node.SetName("a_Array_Pattern_node");
					DelegationConnectors_P_PWP_assert_A_Array_Pattern_a_Array_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_assert_A_Array_Pattern_a_Array_Pattern_node.SetParameter(DelegationConnectors_P_PWP_assert_A_Array_Pattern_a_Array_Pattern);
				DelegationConnectors_P_PWP_assert_A_Array_Pattern.AddNode(DelegationConnectors_P_PWP_assert_A_Array_Pattern_a_Array_Pattern_node);
					// ValueSpecificationAction message
					DelegationConnectors_P_PWP_assert_A_Array_Pattern_message.SetName("message");
					DelegationConnectors_P_PWP_assert_A_Array_Pattern_message.SetVisibility(VisibilityKind.public_);
						// LiteralString LiteralString16
						DelegationConnectors_P_PWP_assert_A_Array_Pattern_message_LiteralString16.SetName("LiteralString16");
						DelegationConnectors_P_PWP_assert_A_Array_Pattern_message_LiteralString16.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_assert_A_Array_Pattern_message_LiteralString16.SetValue("Assertion currently not implemented for A_Array_Pattern.");
					DelegationConnectors_P_PWP_assert_A_Array_Pattern_message.SetValue(DelegationConnectors_P_PWP_assert_A_Array_Pattern_message_LiteralString16);
						// OutputPin result
						DelegationConnectors_P_PWP_assert_A_Array_Pattern_message_result.SetName("result");
						DelegationConnectors_P_PWP_assert_A_Array_Pattern_message_result.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_assert_A_Array_Pattern_message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					DelegationConnectors_P_PWP_assert_A_Array_Pattern_message.SetResult(DelegationConnectors_P_PWP_assert_A_Array_Pattern_message_result);
				DelegationConnectors_P_PWP_assert_A_Array_Pattern.AddNode(DelegationConnectors_P_PWP_assert_A_Array_Pattern_message);
					// ObjectFlow ObjectFlow6 from result to value
					DelegationConnectors_P_PWP_assert_A_Array_Pattern_ObjectFlow6.SetName("ObjectFlow6");
					DelegationConnectors_P_PWP_assert_A_Array_Pattern_ObjectFlow6.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_assert_A_Array_Pattern_ObjectFlow6.SetSource(DelegationConnectors_P_PWP_assert_A_Array_Pattern_message_result);
					DelegationConnectors_P_PWP_assert_A_Array_Pattern_ObjectFlow6.SetTarget(DelegationConnectors_P_PWP_assert_A_Array_Pattern_writeLine_value);
						// LiteralBoolean LiteralBoolean8
						DelegationConnectors_P_PWP_assert_A_Array_Pattern_ObjectFlow6_LiteralBoolean8.SetName("LiteralBoolean8");
						DelegationConnectors_P_PWP_assert_A_Array_Pattern_ObjectFlow6_LiteralBoolean8.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_assert_A_Array_Pattern_ObjectFlow6_LiteralBoolean8.SetValue(true);
					DelegationConnectors_P_PWP_assert_A_Array_Pattern_ObjectFlow6.SetGuard(DelegationConnectors_P_PWP_assert_A_Array_Pattern_ObjectFlow6_LiteralBoolean8);
				DelegationConnectors_P_PWP_assert_A_Array_Pattern.AddEdge(DelegationConnectors_P_PWP_assert_A_Array_Pattern_ObjectFlow6);
			DelegationConnectors_P_PWP.AddPackagedElement(DelegationConnectors_P_PWP_assert_A_Array_Pattern);
				// Class A_Star_Pattern
				DelegationConnectors_P_PWP_A_Star_Pattern.SetName("A_Star_Pattern");
				DelegationConnectors_P_PWP_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Property b
					DelegationConnectors_P_PWP_A_Star_Pattern_b.SetName("b");
					DelegationConnectors_P_PWP_A_Star_Pattern_b.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_PWP_A_Star_Pattern_b.SetUpper(-1);
					DelegationConnectors_P_PWP_A_Star_Pattern_b.SetLower(2);
					DelegationConnectors_P_PWP_A_Star_Pattern_b.SetType(DelegationConnectors_P_PWP_B);
					DelegationConnectors_P_PWP_A_Star_Pattern_b.SetAggregation(AggregationKind.composite);
				DelegationConnectors_P_PWP_A_Star_Pattern.AddOwnedAttribute(DelegationConnectors_P_PWP_A_Star_Pattern_b);
					// Port p
					DelegationConnectors_P_PWP_A_Star_Pattern_p.SetName("p");
					DelegationConnectors_P_PWP_A_Star_Pattern_p.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_PWP_A_Star_Pattern_p.SetUpper(-1);
					DelegationConnectors_P_PWP_A_Star_Pattern_p.SetLower(3);
					DelegationConnectors_P_PWP_A_Star_Pattern_p.SetType(DelegationConnectors_P_PWP_IImpl);
					DelegationConnectors_P_PWP_A_Star_Pattern_p.SetAggregation(AggregationKind.composite);
					DelegationConnectors_P_PWP_A_Star_Pattern_p.isService = true;
					DelegationConnectors_P_PWP_A_Star_Pattern_p.AddProvided(DelegationConnectors_P_PWP_I);
				DelegationConnectors_P_PWP_A_Star_Pattern.AddOwnedAttribute(DelegationConnectors_P_PWP_A_Star_Pattern_p);
				
				DelegationConnectors_P_PWP_A_Star_Pattern_r.SetName("r");
					DelegationConnectors_P_PWP_A_Star_Pattern_r.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_A_Star_Pattern_r_ConnectorEnd26.SetUpper(-1);
						DelegationConnectors_P_PWP_A_Star_Pattern_r_ConnectorEnd26.SetLower(3);
						DelegationConnectors_P_PWP_A_Star_Pattern_r_ConnectorEnd26.SetRole(DelegationConnectors_P_PWP_A_Star_Pattern_p);
						
					DelegationConnectors_P_PWP_A_Star_Pattern_r.AddEnd(DelegationConnectors_P_PWP_A_Star_Pattern_r_ConnectorEnd26);
						DelegationConnectors_P_PWP_A_Star_Pattern_r_ConnectorEnd23.SetUpper(-1);
						DelegationConnectors_P_PWP_A_Star_Pattern_r_ConnectorEnd23.SetLower(4);
						DelegationConnectors_P_PWP_A_Star_Pattern_r_ConnectorEnd23.SetRole(DelegationConnectors_P_PWP_B_q);
						DelegationConnectors_P_PWP_A_Star_Pattern_r_ConnectorEnd23.SetPartWithPort(DelegationConnectors_P_PWP_A_Star_Pattern_b);
						
					DelegationConnectors_P_PWP_A_Star_Pattern_r.AddEnd(DelegationConnectors_P_PWP_A_Star_Pattern_r_ConnectorEnd23);
					DelegationConnectors_P_PWP_A_Star_Pattern_r.SetType(DelegationConnectors_P_PWP_R);
				DelegationConnectors_P_PWP_A_Star_Pattern.AddOwnedConnector(DelegationConnectors_P_PWP_A_Star_Pattern_r);
					// Operation A_Star_Pattern_A_Star_Pattern
					DelegationConnectors_P_PWP_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern.SetName("A_Star_Pattern_A_Star_Pattern");
					DelegationConnectors_P_PWP_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
						// Parameter result
						DelegationConnectors_P_PWP_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result.SetName("result");
						DelegationConnectors_P_PWP_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result.SetVisibility(VisibilityKind.public_);
						
						DelegationConnectors_P_PWP_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result.SetType(DelegationConnectors_P_PWP_A_Star_Pattern);
						DelegationConnectors_P_PWP_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result.SetDirection(ParameterDirectionKind.return_);
					DelegationConnectors_P_PWP_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern.AddOwnedParameter(DelegationConnectors_P_PWP_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result);
					DelegationConnectors_P_PWP_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				DelegationConnectors_P_PWP_A_Star_Pattern.AddOwnedOperation(DelegationConnectors_P_PWP_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern);
			DelegationConnectors_P_PWP.AddPackagedElement(DelegationConnectors_P_PWP_A_Star_Pattern);
				// Class IImpl
				DelegationConnectors_P_PWP_IImpl.SetName("IImpl");
				DelegationConnectors_P_PWP_IImpl.SetVisibility(VisibilityKind.public_);
				DelegationConnectors_P_PWP_IImpl_I_Realization.SetName("I_Realization");
					DelegationConnectors_P_PWP_IImpl_I_Realization.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_PWP_IImpl_I_Realization.SetContract(DelegationConnectors_P_PWP_I);
					
				DelegationConnectors_P_PWP_IImpl.AddInterfaceRealization(DelegationConnectors_P_PWP_IImpl_I_Realization);
			DelegationConnectors_P_PWP.AddPackagedElement(DelegationConnectors_P_PWP_IImpl);
				// Activity instantiate_A_Unconnected_Pattern
				DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern.SetName("instantiate_A_Unconnected_Pattern");
				DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Unconnected_Pattern
					DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetName("a_Unconnected_Pattern");
					DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetType(DelegationConnectors_P_PWP_A_Unconnected_Pattern);
					DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetDirection(ParameterDirectionKind.return_);
				DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern.AddOwnedParameter(DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern);
					// CreateObjectAction Create A_Unconnected_Pattern
					DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern.SetName("Create A_Unconnected_Pattern");
					DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern.SetClassifier(DelegationConnectors_P_PWP_A_Unconnected_Pattern);
						// OutputPin result
						DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result.SetName("result");
						DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result.SetType(DelegationConnectors_P_PWP_A_Unconnected_Pattern);
					DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern.SetResult(DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result);
				DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern.AddNode(DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern);
					// ActivityParameterNode a_Unconnected_Pattern_node
					DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node.SetName("a_Unconnected_Pattern_node");
					DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node.SetParameter(DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern);
				DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern.AddNode(DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node);
					// CallOperationAction A_Unconnected_Pattern()
					DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_.SetName("A_Unconnected_Pattern()");
					DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result.SetName("result");
						DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result.SetType(DelegationConnectors_P_PWP_A_Unconnected_Pattern);
					DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_.AddResult(DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result);
					DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_.SetOperation(DelegationConnectors_P_PWP_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern);
						// InputPin target
						DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target.SetName("target");
						DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target.SetType(DelegationConnectors_P_PWP_A_Unconnected_Pattern);
					DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_.SetTarget(DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target);
				DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern.AddNode(DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern_);
					// ObjectFlow ObjectFlow32 from result to target
					DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow32.SetName("ObjectFlow32");
					DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow32.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow32.SetSource(DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_Create_A_Unconnected_Pattern_result);
					DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow32.SetTarget(DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__target);
						// LiteralBoolean LiteralBoolean33
						DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow32_LiteralBoolean33.SetName("LiteralBoolean33");
						DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow32_LiteralBoolean33.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow32_LiteralBoolean33.SetValue(true);
					DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow32.SetGuard(DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow32_LiteralBoolean33);
				DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern.AddEdge(DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow32);
					// ObjectFlow ObjectFlow35 from result to a_Unconnected_Pattern_node
					DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow35.SetName("ObjectFlow35");
					DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow35.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow35.SetSource(DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_A_Unconnected_Pattern__result);
					DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow35.SetTarget(DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern_node);
						// LiteralBoolean LiteralBoolean37
						DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow35_LiteralBoolean37.SetName("LiteralBoolean37");
						DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow35_LiteralBoolean37.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow35_LiteralBoolean37.SetValue(true);
					DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow35.SetGuard(DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow35_LiteralBoolean37);
				DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern.AddEdge(DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern_ObjectFlow35);
			DelegationConnectors_P_PWP.AddPackagedElement(DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern);
				// Activity instantiate_A_Empty_Pattern
				DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern.SetName("instantiate_A_Empty_Pattern");
				DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Empty_Pattern
					DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetName("a_Empty_Pattern");
					DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetType(DelegationConnectors_P_PWP_A_Empty_Pattern);
					DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetDirection(ParameterDirectionKind.return_);
				DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern.AddOwnedParameter(DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_a_Empty_Pattern);
					// CreateObjectAction Create A_Empty_Pattern
					DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern.SetName("Create A_Empty_Pattern");
					DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern.SetClassifier(DelegationConnectors_P_PWP_A_Empty_Pattern);
						// OutputPin result
						DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result.SetName("result");
						DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result.SetType(DelegationConnectors_P_PWP_A_Empty_Pattern);
					DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern.SetResult(DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result);
				DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern.AddNode(DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern);
					// CallOperationAction A_Empty_Pattern()
					DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern_.SetName("A_Empty_Pattern()");
					DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__result.SetName("result");
						DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__result.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__result.SetType(DelegationConnectors_P_PWP_A_Empty_Pattern);
					DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern_.AddResult(DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__result);
					DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern_.SetOperation(DelegationConnectors_P_PWP_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern);
						// InputPin target
						DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__target.SetName("target");
						DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__target.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__target.SetType(DelegationConnectors_P_PWP_A_Empty_Pattern);
					DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern_.SetTarget(DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__target);
				DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern.AddNode(DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern_);
					// ActivityParameterNode a_Empty_Pattern_node
					DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_a_Empty_Pattern_node.SetName("a_Empty_Pattern_node");
					DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_a_Empty_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_a_Empty_Pattern_node.SetParameter(DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_a_Empty_Pattern);
				DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern.AddNode(DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_a_Empty_Pattern_node);
					// ObjectFlow ObjectFlow43 from result to a_Empty_Pattern_node
					DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_ObjectFlow43.SetName("ObjectFlow43");
					DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_ObjectFlow43.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_ObjectFlow43.SetSource(DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__result);
					DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_ObjectFlow43.SetTarget(DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_a_Empty_Pattern_node);
						// LiteralBoolean LiteralBoolean45
						DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_ObjectFlow43_LiteralBoolean45.SetName("LiteralBoolean45");
						DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_ObjectFlow43_LiteralBoolean45.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_ObjectFlow43_LiteralBoolean45.SetValue(true);
					DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_ObjectFlow43.SetGuard(DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_ObjectFlow43_LiteralBoolean45);
				DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern.AddEdge(DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_ObjectFlow43);
					// ObjectFlow ObjectFlow46 from result to target
					DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_ObjectFlow46.SetName("ObjectFlow46");
					DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_ObjectFlow46.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_ObjectFlow46.SetSource(DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_Create_A_Empty_Pattern_result);
					DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_ObjectFlow46.SetTarget(DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_A_Empty_Pattern__target);
						// LiteralBoolean LiteralBoolean48
						DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_ObjectFlow46_LiteralBoolean48.SetName("LiteralBoolean48");
						DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_ObjectFlow46_LiteralBoolean48.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_ObjectFlow46_LiteralBoolean48.SetValue(true);
					DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_ObjectFlow46.SetGuard(DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_ObjectFlow46_LiteralBoolean48);
				DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern.AddEdge(DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern_ObjectFlow46);
			DelegationConnectors_P_PWP.AddPackagedElement(DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern);
				// Activity instantiate_A_Array_Pattern
				DelegationConnectors_P_PWP_instantiate_A_Array_Pattern.SetName("instantiate_A_Array_Pattern");
				DelegationConnectors_P_PWP_instantiate_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Array_Pattern
					DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_a_Array_Pattern.SetName("a_Array_Pattern");
					DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_a_Array_Pattern.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_a_Array_Pattern.SetType(DelegationConnectors_P_PWP_A_Array_Pattern);
					DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_a_Array_Pattern.SetDirection(ParameterDirectionKind.return_);
				DelegationConnectors_P_PWP_instantiate_A_Array_Pattern.AddOwnedParameter(DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_a_Array_Pattern);
					// ActivityParameterNode a_Array_Pattern_node
					DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_a_Array_Pattern_node.SetName("a_Array_Pattern_node");
					DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_a_Array_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_a_Array_Pattern_node.SetParameter(DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_a_Array_Pattern);
				DelegationConnectors_P_PWP_instantiate_A_Array_Pattern.AddNode(DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_a_Array_Pattern_node);
					// CreateObjectAction Create A_Array_Pattern
					DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern.SetName("Create A_Array_Pattern");
					DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern.SetClassifier(DelegationConnectors_P_PWP_A_Array_Pattern);
						// OutputPin result
						DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result.SetName("result");
						DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result.SetType(DelegationConnectors_P_PWP_A_Array_Pattern);
					DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern.SetResult(DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result);
				DelegationConnectors_P_PWP_instantiate_A_Array_Pattern.AddNode(DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern);
					// CallOperationAction A_Array_Pattern()
					DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_A_Array_Pattern_.SetName("A_Array_Pattern()");
					DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_A_Array_Pattern_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__result.SetName("result");
						DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__result.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__result.SetType(DelegationConnectors_P_PWP_A_Array_Pattern);
					DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_A_Array_Pattern_.AddResult(DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__result);
					DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_A_Array_Pattern_.SetOperation(DelegationConnectors_P_PWP_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern);
						// InputPin target
						DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__target.SetName("target");
						DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__target.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__target.SetType(DelegationConnectors_P_PWP_A_Array_Pattern);
					DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_A_Array_Pattern_.SetTarget(DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__target);
				DelegationConnectors_P_PWP_instantiate_A_Array_Pattern.AddNode(DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_A_Array_Pattern_);
					// ObjectFlow ObjectFlow56 from result to target
					DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_ObjectFlow56.SetName("ObjectFlow56");
					DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_ObjectFlow56.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_ObjectFlow56.SetSource(DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_Create_A_Array_Pattern_result);
					DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_ObjectFlow56.SetTarget(DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__target);
						// LiteralBoolean LiteralBoolean57
						DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_ObjectFlow56_LiteralBoolean57.SetName("LiteralBoolean57");
						DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_ObjectFlow56_LiteralBoolean57.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_ObjectFlow56_LiteralBoolean57.SetValue(true);
					DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_ObjectFlow56.SetGuard(DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_ObjectFlow56_LiteralBoolean57);
				DelegationConnectors_P_PWP_instantiate_A_Array_Pattern.AddEdge(DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_ObjectFlow56);
					// ObjectFlow ObjectFlow62 from result to a_Array_Pattern_node
					DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_ObjectFlow62.SetName("ObjectFlow62");
					DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_ObjectFlow62.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_ObjectFlow62.SetSource(DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_A_Array_Pattern__result);
					DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_ObjectFlow62.SetTarget(DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_a_Array_Pattern_node);
						// LiteralBoolean LiteralBoolean63
						DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_ObjectFlow62_LiteralBoolean63.SetName("LiteralBoolean63");
						DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_ObjectFlow62_LiteralBoolean63.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_ObjectFlow62_LiteralBoolean63.SetValue(true);
					DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_ObjectFlow62.SetGuard(DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_ObjectFlow62_LiteralBoolean63);
				DelegationConnectors_P_PWP_instantiate_A_Array_Pattern.AddEdge(DelegationConnectors_P_PWP_instantiate_A_Array_Pattern_ObjectFlow62);
			DelegationConnectors_P_PWP.AddPackagedElement(DelegationConnectors_P_PWP_instantiate_A_Array_Pattern);
				// Class A_Array_Pattern
				DelegationConnectors_P_PWP_A_Array_Pattern.SetName("A_Array_Pattern");
				DelegationConnectors_P_PWP_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Property b
					DelegationConnectors_P_PWP_A_Array_Pattern_b.SetName("b");
					DelegationConnectors_P_PWP_A_Array_Pattern_b.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_PWP_A_Array_Pattern_b.SetUpper(-1);
					DelegationConnectors_P_PWP_A_Array_Pattern_b.SetLower(2);
					DelegationConnectors_P_PWP_A_Array_Pattern_b.SetType(DelegationConnectors_P_PWP_B);
					DelegationConnectors_P_PWP_A_Array_Pattern_b.SetAggregation(AggregationKind.composite);
				DelegationConnectors_P_PWP_A_Array_Pattern.AddOwnedAttribute(DelegationConnectors_P_PWP_A_Array_Pattern_b);
					// Port p
					DelegationConnectors_P_PWP_A_Array_Pattern_p.SetName("p");
					DelegationConnectors_P_PWP_A_Array_Pattern_p.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_PWP_A_Array_Pattern_p.SetUpper(-1);
					DelegationConnectors_P_PWP_A_Array_Pattern_p.SetLower(4);
					DelegationConnectors_P_PWP_A_Array_Pattern_p.SetType(DelegationConnectors_P_PWP_IImpl);
					DelegationConnectors_P_PWP_A_Array_Pattern_p.SetAggregation(AggregationKind.composite);
					DelegationConnectors_P_PWP_A_Array_Pattern_p.isService = true;
					DelegationConnectors_P_PWP_A_Array_Pattern_p.AddProvided(DelegationConnectors_P_PWP_I);
				DelegationConnectors_P_PWP_A_Array_Pattern.AddOwnedAttribute(DelegationConnectors_P_PWP_A_Array_Pattern_p);
				
				DelegationConnectors_P_PWP_A_Array_Pattern_r.SetName("r");
					DelegationConnectors_P_PWP_A_Array_Pattern_r.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_A_Array_Pattern_r_ConnectorEnd71.SetUpper(-1);
						DelegationConnectors_P_PWP_A_Array_Pattern_r_ConnectorEnd71.SetRole(DelegationConnectors_P_PWP_A_Array_Pattern_p);
						
					DelegationConnectors_P_PWP_A_Array_Pattern_r.AddEnd(DelegationConnectors_P_PWP_A_Array_Pattern_r_ConnectorEnd71);
						DelegationConnectors_P_PWP_A_Array_Pattern_r_ConnectorEnd73.SetUpper(-1);
						DelegationConnectors_P_PWP_A_Array_Pattern_r_ConnectorEnd73.SetRole(DelegationConnectors_P_PWP_B_q);
						DelegationConnectors_P_PWP_A_Array_Pattern_r_ConnectorEnd73.SetPartWithPort(DelegationConnectors_P_PWP_A_Array_Pattern_b);
						
					DelegationConnectors_P_PWP_A_Array_Pattern_r.AddEnd(DelegationConnectors_P_PWP_A_Array_Pattern_r_ConnectorEnd73);
					DelegationConnectors_P_PWP_A_Array_Pattern_r.SetType(DelegationConnectors_P_PWP_R);
				DelegationConnectors_P_PWP_A_Array_Pattern.AddOwnedConnector(DelegationConnectors_P_PWP_A_Array_Pattern_r);
					// Operation A_Array_Pattern_A_Array_Pattern
					DelegationConnectors_P_PWP_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern.SetName("A_Array_Pattern_A_Array_Pattern");
					DelegationConnectors_P_PWP_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
						// Parameter result
						DelegationConnectors_P_PWP_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result.SetName("result");
						DelegationConnectors_P_PWP_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result.SetVisibility(VisibilityKind.public_);
						
						DelegationConnectors_P_PWP_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result.SetType(DelegationConnectors_P_PWP_A_Array_Pattern);
						DelegationConnectors_P_PWP_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result.SetDirection(ParameterDirectionKind.return_);
					DelegationConnectors_P_PWP_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern.AddOwnedParameter(DelegationConnectors_P_PWP_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern_result);
					DelegationConnectors_P_PWP_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				DelegationConnectors_P_PWP_A_Array_Pattern.AddOwnedOperation(DelegationConnectors_P_PWP_A_Array_Pattern_A_Array_Pattern_A_Array_Pattern);
			DelegationConnectors_P_PWP.AddPackagedElement(DelegationConnectors_P_PWP_A_Array_Pattern);
				// Activity assert_A_Empty_Pattern
				DelegationConnectors_P_PWP_assert_A_Empty_Pattern.SetName("assert_A_Empty_Pattern");
				DelegationConnectors_P_PWP_assert_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Empty_Pattern
					DelegationConnectors_P_PWP_assert_A_Empty_Pattern_a_Empty_Pattern.SetName("a_Empty_Pattern");
					DelegationConnectors_P_PWP_assert_A_Empty_Pattern_a_Empty_Pattern.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_assert_A_Empty_Pattern_a_Empty_Pattern.SetType(DelegationConnectors_P_PWP_A_Empty_Pattern);
				DelegationConnectors_P_PWP_assert_A_Empty_Pattern.AddOwnedParameter(DelegationConnectors_P_PWP_assert_A_Empty_Pattern_a_Empty_Pattern);
					// CallBehaviorAction writeLine
					DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine.SetName("writeLine");
					DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine.SetVisibility(VisibilityKind.public_);
					
						// OutputPin errorStatus
						DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine_errorStatus.SetName("errorStatus");
						DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine_errorStatus.SetVisibility(VisibilityKind.public_);
						
						DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine_errorStatus.SetLower(0);
					DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine.AddResult(DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine_errorStatus);
					DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
						// InputPin value
						DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine_value.SetName("value");
						DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine_value.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine.AddArgument(DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine_value);
				DelegationConnectors_P_PWP_assert_A_Empty_Pattern.AddNode(DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine);
					// ValueSpecificationAction message
					DelegationConnectors_P_PWP_assert_A_Empty_Pattern_message.SetName("message");
					DelegationConnectors_P_PWP_assert_A_Empty_Pattern_message.SetVisibility(VisibilityKind.public_);
						// LiteralString LiteralString90
						DelegationConnectors_P_PWP_assert_A_Empty_Pattern_message_LiteralString90.SetName("LiteralString90");
						DelegationConnectors_P_PWP_assert_A_Empty_Pattern_message_LiteralString90.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_assert_A_Empty_Pattern_message_LiteralString90.SetValue("Assertion currently not implemented for A_Empty_Pattern.");
					DelegationConnectors_P_PWP_assert_A_Empty_Pattern_message.SetValue(DelegationConnectors_P_PWP_assert_A_Empty_Pattern_message_LiteralString90);
						// OutputPin result
						DelegationConnectors_P_PWP_assert_A_Empty_Pattern_message_result.SetName("result");
						DelegationConnectors_P_PWP_assert_A_Empty_Pattern_message_result.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_assert_A_Empty_Pattern_message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					DelegationConnectors_P_PWP_assert_A_Empty_Pattern_message.SetResult(DelegationConnectors_P_PWP_assert_A_Empty_Pattern_message_result);
				DelegationConnectors_P_PWP_assert_A_Empty_Pattern.AddNode(DelegationConnectors_P_PWP_assert_A_Empty_Pattern_message);
					// ActivityParameterNode a_Empty_Pattern_node
					DelegationConnectors_P_PWP_assert_A_Empty_Pattern_a_Empty_Pattern_node.SetName("a_Empty_Pattern_node");
					DelegationConnectors_P_PWP_assert_A_Empty_Pattern_a_Empty_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_assert_A_Empty_Pattern_a_Empty_Pattern_node.SetParameter(DelegationConnectors_P_PWP_assert_A_Empty_Pattern_a_Empty_Pattern);
				DelegationConnectors_P_PWP_assert_A_Empty_Pattern.AddNode(DelegationConnectors_P_PWP_assert_A_Empty_Pattern_a_Empty_Pattern_node);
					// ObjectFlow ObjectFlow79 from result to value
					DelegationConnectors_P_PWP_assert_A_Empty_Pattern_ObjectFlow79.SetName("ObjectFlow79");
					DelegationConnectors_P_PWP_assert_A_Empty_Pattern_ObjectFlow79.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_assert_A_Empty_Pattern_ObjectFlow79.SetSource(DelegationConnectors_P_PWP_assert_A_Empty_Pattern_message_result);
					DelegationConnectors_P_PWP_assert_A_Empty_Pattern_ObjectFlow79.SetTarget(DelegationConnectors_P_PWP_assert_A_Empty_Pattern_writeLine_value);
						// LiteralBoolean LiteralBoolean81
						DelegationConnectors_P_PWP_assert_A_Empty_Pattern_ObjectFlow79_LiteralBoolean81.SetName("LiteralBoolean81");
						DelegationConnectors_P_PWP_assert_A_Empty_Pattern_ObjectFlow79_LiteralBoolean81.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_assert_A_Empty_Pattern_ObjectFlow79_LiteralBoolean81.SetValue(true);
					DelegationConnectors_P_PWP_assert_A_Empty_Pattern_ObjectFlow79.SetGuard(DelegationConnectors_P_PWP_assert_A_Empty_Pattern_ObjectFlow79_LiteralBoolean81);
				DelegationConnectors_P_PWP_assert_A_Empty_Pattern.AddEdge(DelegationConnectors_P_PWP_assert_A_Empty_Pattern_ObjectFlow79);
			DelegationConnectors_P_PWP.AddPackagedElement(DelegationConnectors_P_PWP_assert_A_Empty_Pattern);
				// Activity main
				DelegationConnectors_P_PWP_main.SetName("main");
				DelegationConnectors_P_PWP_main.SetVisibility(VisibilityKind.public_);
					// CallBehaviorAction assert_A_Unconnected_Pattern
					DelegationConnectors_P_PWP_main_assert_A_Unconnected_Pattern.SetName("assert_A_Unconnected_Pattern");
					DelegationConnectors_P_PWP_main_assert_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_PWP_main_assert_A_Unconnected_Pattern.SetBehavior(DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern);
						// InputPin a_Unconnected_Pattern
						DelegationConnectors_P_PWP_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern.SetName("a_Unconnected_Pattern");
						DelegationConnectors_P_PWP_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern.SetType(DelegationConnectors_P_PWP_A_Unconnected_Pattern);
					DelegationConnectors_P_PWP_main_assert_A_Unconnected_Pattern.AddArgument(DelegationConnectors_P_PWP_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern);
				DelegationConnectors_P_PWP_main.AddNode(DelegationConnectors_P_PWP_main_assert_A_Unconnected_Pattern);
					// CallBehaviorAction assert_A_Star_Pattern
					DelegationConnectors_P_PWP_main_assert_A_Star_Pattern.SetName("assert_A_Star_Pattern");
					DelegationConnectors_P_PWP_main_assert_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_PWP_main_assert_A_Star_Pattern.SetBehavior(DelegationConnectors_P_PWP_assert_A_Star_Pattern);
						// InputPin a_Star_Pattern
						DelegationConnectors_P_PWP_main_assert_A_Star_Pattern_a_Star_Pattern.SetName("a_Star_Pattern");
						DelegationConnectors_P_PWP_main_assert_A_Star_Pattern_a_Star_Pattern.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_main_assert_A_Star_Pattern_a_Star_Pattern.SetType(DelegationConnectors_P_PWP_A_Star_Pattern);
					DelegationConnectors_P_PWP_main_assert_A_Star_Pattern.AddArgument(DelegationConnectors_P_PWP_main_assert_A_Star_Pattern_a_Star_Pattern);
				DelegationConnectors_P_PWP_main.AddNode(DelegationConnectors_P_PWP_main_assert_A_Star_Pattern);
					// CallBehaviorAction assert_A_Array_Pattern
					DelegationConnectors_P_PWP_main_assert_A_Array_Pattern.SetName("assert_A_Array_Pattern");
					DelegationConnectors_P_PWP_main_assert_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_PWP_main_assert_A_Array_Pattern.SetBehavior(DelegationConnectors_P_PWP_assert_A_Array_Pattern);
						// InputPin a_Array_Pattern
						DelegationConnectors_P_PWP_main_assert_A_Array_Pattern_a_Array_Pattern.SetName("a_Array_Pattern");
						DelegationConnectors_P_PWP_main_assert_A_Array_Pattern_a_Array_Pattern.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_main_assert_A_Array_Pattern_a_Array_Pattern.SetType(DelegationConnectors_P_PWP_A_Array_Pattern);
					DelegationConnectors_P_PWP_main_assert_A_Array_Pattern.AddArgument(DelegationConnectors_P_PWP_main_assert_A_Array_Pattern_a_Array_Pattern);
				DelegationConnectors_P_PWP_main.AddNode(DelegationConnectors_P_PWP_main_assert_A_Array_Pattern);
					// CallBehaviorAction instantiate_A_Empty_Pattern
					DelegationConnectors_P_PWP_main_instantiate_A_Empty_Pattern.SetName("instantiate_A_Empty_Pattern");
					DelegationConnectors_P_PWP_main_instantiate_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
					
						// OutputPin a_Empty_Pattern
						DelegationConnectors_P_PWP_main_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetName("a_Empty_Pattern");
						DelegationConnectors_P_PWP_main_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_main_instantiate_A_Empty_Pattern_a_Empty_Pattern.SetType(DelegationConnectors_P_PWP_A_Empty_Pattern);
					DelegationConnectors_P_PWP_main_instantiate_A_Empty_Pattern.AddResult(DelegationConnectors_P_PWP_main_instantiate_A_Empty_Pattern_a_Empty_Pattern);
					DelegationConnectors_P_PWP_main_instantiate_A_Empty_Pattern.SetBehavior(DelegationConnectors_P_PWP_instantiate_A_Empty_Pattern);
				DelegationConnectors_P_PWP_main.AddNode(DelegationConnectors_P_PWP_main_instantiate_A_Empty_Pattern);
					// CallBehaviorAction assert_A_Empty_Pattern
					DelegationConnectors_P_PWP_main_assert_A_Empty_Pattern.SetName("assert_A_Empty_Pattern");
					DelegationConnectors_P_PWP_main_assert_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_PWP_main_assert_A_Empty_Pattern.SetBehavior(DelegationConnectors_P_PWP_assert_A_Empty_Pattern);
						// InputPin a_Empty_Pattern
						DelegationConnectors_P_PWP_main_assert_A_Empty_Pattern_a_Empty_Pattern.SetName("a_Empty_Pattern");
						DelegationConnectors_P_PWP_main_assert_A_Empty_Pattern_a_Empty_Pattern.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_main_assert_A_Empty_Pattern_a_Empty_Pattern.SetType(DelegationConnectors_P_PWP_A_Empty_Pattern);
					DelegationConnectors_P_PWP_main_assert_A_Empty_Pattern.AddArgument(DelegationConnectors_P_PWP_main_assert_A_Empty_Pattern_a_Empty_Pattern);
				DelegationConnectors_P_PWP_main.AddNode(DelegationConnectors_P_PWP_main_assert_A_Empty_Pattern);
					// CallBehaviorAction instantiate_A_Array_Pattern
					DelegationConnectors_P_PWP_main_instantiate_A_Array_Pattern.SetName("instantiate_A_Array_Pattern");
					DelegationConnectors_P_PWP_main_instantiate_A_Array_Pattern.SetVisibility(VisibilityKind.public_);
					
						// OutputPin a_Array_Pattern
						DelegationConnectors_P_PWP_main_instantiate_A_Array_Pattern_a_Array_Pattern.SetName("a_Array_Pattern");
						DelegationConnectors_P_PWP_main_instantiate_A_Array_Pattern_a_Array_Pattern.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_main_instantiate_A_Array_Pattern_a_Array_Pattern.SetType(DelegationConnectors_P_PWP_A_Array_Pattern);
					DelegationConnectors_P_PWP_main_instantiate_A_Array_Pattern.AddResult(DelegationConnectors_P_PWP_main_instantiate_A_Array_Pattern_a_Array_Pattern);
					DelegationConnectors_P_PWP_main_instantiate_A_Array_Pattern.SetBehavior(DelegationConnectors_P_PWP_instantiate_A_Array_Pattern);
				DelegationConnectors_P_PWP_main.AddNode(DelegationConnectors_P_PWP_main_instantiate_A_Array_Pattern);
					// CallBehaviorAction instantiate_A_Star_Pattern
					DelegationConnectors_P_PWP_main_instantiate_A_Star_Pattern.SetName("instantiate_A_Star_Pattern");
					DelegationConnectors_P_PWP_main_instantiate_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
					
						// OutputPin a_Star_Pattern
						DelegationConnectors_P_PWP_main_instantiate_A_Star_Pattern_a_Star_Pattern.SetName("a_Star_Pattern");
						DelegationConnectors_P_PWP_main_instantiate_A_Star_Pattern_a_Star_Pattern.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_main_instantiate_A_Star_Pattern_a_Star_Pattern.SetType(DelegationConnectors_P_PWP_A_Star_Pattern);
					DelegationConnectors_P_PWP_main_instantiate_A_Star_Pattern.AddResult(DelegationConnectors_P_PWP_main_instantiate_A_Star_Pattern_a_Star_Pattern);
					DelegationConnectors_P_PWP_main_instantiate_A_Star_Pattern.SetBehavior(DelegationConnectors_P_PWP_instantiate_A_Star_Pattern);
				DelegationConnectors_P_PWP_main.AddNode(DelegationConnectors_P_PWP_main_instantiate_A_Star_Pattern);
					// CallBehaviorAction instantiate_A_Unconnected_Pattern
					DelegationConnectors_P_PWP_main_instantiate_A_Unconnected_Pattern.SetName("instantiate_A_Unconnected_Pattern");
					DelegationConnectors_P_PWP_main_instantiate_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
					
						// OutputPin a_Unconnected_Pattern
						DelegationConnectors_P_PWP_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetName("a_Unconnected_Pattern");
						DelegationConnectors_P_PWP_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern.SetType(DelegationConnectors_P_PWP_A_Unconnected_Pattern);
					DelegationConnectors_P_PWP_main_instantiate_A_Unconnected_Pattern.AddResult(DelegationConnectors_P_PWP_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern);
					DelegationConnectors_P_PWP_main_instantiate_A_Unconnected_Pattern.SetBehavior(DelegationConnectors_P_PWP_instantiate_A_Unconnected_Pattern);
				DelegationConnectors_P_PWP_main.AddNode(DelegationConnectors_P_PWP_main_instantiate_A_Unconnected_Pattern);
					// ObjectFlow ObjectFlow110 from a_Star_Pattern to a_Star_Pattern
					DelegationConnectors_P_PWP_main_ObjectFlow110.SetName("ObjectFlow110");
					DelegationConnectors_P_PWP_main_ObjectFlow110.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_main_ObjectFlow110.SetSource(DelegationConnectors_P_PWP_main_instantiate_A_Star_Pattern_a_Star_Pattern);
					DelegationConnectors_P_PWP_main_ObjectFlow110.SetTarget(DelegationConnectors_P_PWP_main_assert_A_Star_Pattern_a_Star_Pattern);
						// LiteralBoolean LiteralBoolean111
						DelegationConnectors_P_PWP_main_ObjectFlow110_LiteralBoolean111.SetName("LiteralBoolean111");
						DelegationConnectors_P_PWP_main_ObjectFlow110_LiteralBoolean111.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_main_ObjectFlow110_LiteralBoolean111.SetValue(true);
					DelegationConnectors_P_PWP_main_ObjectFlow110.SetGuard(DelegationConnectors_P_PWP_main_ObjectFlow110_LiteralBoolean111);
				DelegationConnectors_P_PWP_main.AddEdge(DelegationConnectors_P_PWP_main_ObjectFlow110);
					// ObjectFlow ObjectFlow116 from a_Array_Pattern to a_Array_Pattern
					DelegationConnectors_P_PWP_main_ObjectFlow116.SetName("ObjectFlow116");
					DelegationConnectors_P_PWP_main_ObjectFlow116.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_main_ObjectFlow116.SetSource(DelegationConnectors_P_PWP_main_instantiate_A_Array_Pattern_a_Array_Pattern);
					DelegationConnectors_P_PWP_main_ObjectFlow116.SetTarget(DelegationConnectors_P_PWP_main_assert_A_Array_Pattern_a_Array_Pattern);
						// LiteralBoolean LiteralBoolean117
						DelegationConnectors_P_PWP_main_ObjectFlow116_LiteralBoolean117.SetName("LiteralBoolean117");
						DelegationConnectors_P_PWP_main_ObjectFlow116_LiteralBoolean117.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_main_ObjectFlow116_LiteralBoolean117.SetValue(true);
					DelegationConnectors_P_PWP_main_ObjectFlow116.SetGuard(DelegationConnectors_P_PWP_main_ObjectFlow116_LiteralBoolean117);
				DelegationConnectors_P_PWP_main.AddEdge(DelegationConnectors_P_PWP_main_ObjectFlow116);
					// ObjectFlow ObjectFlow101 from a_Empty_Pattern to a_Empty_Pattern
					DelegationConnectors_P_PWP_main_ObjectFlow101.SetName("ObjectFlow101");
					DelegationConnectors_P_PWP_main_ObjectFlow101.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_main_ObjectFlow101.SetSource(DelegationConnectors_P_PWP_main_instantiate_A_Empty_Pattern_a_Empty_Pattern);
					DelegationConnectors_P_PWP_main_ObjectFlow101.SetTarget(DelegationConnectors_P_PWP_main_assert_A_Empty_Pattern_a_Empty_Pattern);
						// LiteralBoolean LiteralBoolean102
						DelegationConnectors_P_PWP_main_ObjectFlow101_LiteralBoolean102.SetName("LiteralBoolean102");
						DelegationConnectors_P_PWP_main_ObjectFlow101_LiteralBoolean102.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_main_ObjectFlow101_LiteralBoolean102.SetValue(true);
					DelegationConnectors_P_PWP_main_ObjectFlow101.SetGuard(DelegationConnectors_P_PWP_main_ObjectFlow101_LiteralBoolean102);
				DelegationConnectors_P_PWP_main.AddEdge(DelegationConnectors_P_PWP_main_ObjectFlow101);
					// ObjectFlow ObjectFlow104 from a_Unconnected_Pattern to a_Unconnected_Pattern
					DelegationConnectors_P_PWP_main_ObjectFlow104.SetName("ObjectFlow104");
					DelegationConnectors_P_PWP_main_ObjectFlow104.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_main_ObjectFlow104.SetSource(DelegationConnectors_P_PWP_main_instantiate_A_Unconnected_Pattern_a_Unconnected_Pattern);
					DelegationConnectors_P_PWP_main_ObjectFlow104.SetTarget(DelegationConnectors_P_PWP_main_assert_A_Unconnected_Pattern_a_Unconnected_Pattern);
						// LiteralBoolean LiteralBoolean106
						DelegationConnectors_P_PWP_main_ObjectFlow104_LiteralBoolean106.SetName("LiteralBoolean106");
						DelegationConnectors_P_PWP_main_ObjectFlow104_LiteralBoolean106.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_main_ObjectFlow104_LiteralBoolean106.SetValue(true);
					DelegationConnectors_P_PWP_main_ObjectFlow104.SetGuard(DelegationConnectors_P_PWP_main_ObjectFlow104_LiteralBoolean106);
				DelegationConnectors_P_PWP_main.AddEdge(DelegationConnectors_P_PWP_main_ObjectFlow104);
					// ControlFlow ControlFlow128 from assert_A_Array_Pattern to instantiate_A_Star_Pattern
					DelegationConnectors_P_PWP_main_ControlFlow128.SetName("ControlFlow128");
					DelegationConnectors_P_PWP_main_ControlFlow128.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_main_ControlFlow128.SetSource(DelegationConnectors_P_PWP_main_assert_A_Array_Pattern);
					DelegationConnectors_P_PWP_main_ControlFlow128.SetTarget(DelegationConnectors_P_PWP_main_instantiate_A_Star_Pattern);
				DelegationConnectors_P_PWP_main.AddEdge(DelegationConnectors_P_PWP_main_ControlFlow128);
					// ControlFlow ControlFlow129 from assert_A_Unconnected_Pattern to instantiate_A_Array_Pattern
					DelegationConnectors_P_PWP_main_ControlFlow129.SetName("ControlFlow129");
					DelegationConnectors_P_PWP_main_ControlFlow129.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_main_ControlFlow129.SetSource(DelegationConnectors_P_PWP_main_assert_A_Unconnected_Pattern);
					DelegationConnectors_P_PWP_main_ControlFlow129.SetTarget(DelegationConnectors_P_PWP_main_instantiate_A_Array_Pattern);
				DelegationConnectors_P_PWP_main.AddEdge(DelegationConnectors_P_PWP_main_ControlFlow129);
					// ControlFlow ControlFlow130 from assert_A_Empty_Pattern to instantiate_A_Unconnected_Pattern
					DelegationConnectors_P_PWP_main_ControlFlow130.SetName("ControlFlow130");
					DelegationConnectors_P_PWP_main_ControlFlow130.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_main_ControlFlow130.SetSource(DelegationConnectors_P_PWP_main_assert_A_Empty_Pattern);
					DelegationConnectors_P_PWP_main_ControlFlow130.SetTarget(DelegationConnectors_P_PWP_main_instantiate_A_Unconnected_Pattern);
				DelegationConnectors_P_PWP_main.AddEdge(DelegationConnectors_P_PWP_main_ControlFlow130);
			DelegationConnectors_P_PWP.AddPackagedElement(DelegationConnectors_P_PWP_main);
				// Class A_Unconnected_Pattern
				DelegationConnectors_P_PWP_A_Unconnected_Pattern.SetName("A_Unconnected_Pattern");
				DelegationConnectors_P_PWP_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Property b
					DelegationConnectors_P_PWP_A_Unconnected_Pattern_b.SetName("b");
					DelegationConnectors_P_PWP_A_Unconnected_Pattern_b.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_PWP_A_Unconnected_Pattern_b.SetUpper(-1);
					DelegationConnectors_P_PWP_A_Unconnected_Pattern_b.SetLower(2);
					DelegationConnectors_P_PWP_A_Unconnected_Pattern_b.SetType(DelegationConnectors_P_PWP_B);
					DelegationConnectors_P_PWP_A_Unconnected_Pattern_b.SetAggregation(AggregationKind.composite);
				DelegationConnectors_P_PWP_A_Unconnected_Pattern.AddOwnedAttribute(DelegationConnectors_P_PWP_A_Unconnected_Pattern_b);
					// Port p
					DelegationConnectors_P_PWP_A_Unconnected_Pattern_p.SetName("p");
					DelegationConnectors_P_PWP_A_Unconnected_Pattern_p.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_PWP_A_Unconnected_Pattern_p.SetUpper(-1);
					DelegationConnectors_P_PWP_A_Unconnected_Pattern_p.SetLower(3);
					DelegationConnectors_P_PWP_A_Unconnected_Pattern_p.SetType(DelegationConnectors_P_PWP_IImpl);
					DelegationConnectors_P_PWP_A_Unconnected_Pattern_p.SetAggregation(AggregationKind.composite);
					DelegationConnectors_P_PWP_A_Unconnected_Pattern_p.isService = true;
					DelegationConnectors_P_PWP_A_Unconnected_Pattern_p.AddProvided(DelegationConnectors_P_PWP_I);
				DelegationConnectors_P_PWP_A_Unconnected_Pattern.AddOwnedAttribute(DelegationConnectors_P_PWP_A_Unconnected_Pattern_p);
				
				DelegationConnectors_P_PWP_A_Unconnected_Pattern_r.SetName("r");
					DelegationConnectors_P_PWP_A_Unconnected_Pattern_r.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_A_Unconnected_Pattern_r_ConnectorEnd138.SetUpper(-1);
						DelegationConnectors_P_PWP_A_Unconnected_Pattern_r_ConnectorEnd138.SetLower(0);
						DelegationConnectors_P_PWP_A_Unconnected_Pattern_r_ConnectorEnd138.SetRole(DelegationConnectors_P_PWP_A_Unconnected_Pattern_p);
						
					DelegationConnectors_P_PWP_A_Unconnected_Pattern_r.AddEnd(DelegationConnectors_P_PWP_A_Unconnected_Pattern_r_ConnectorEnd138);
						DelegationConnectors_P_PWP_A_Unconnected_Pattern_r_ConnectorEnd135.SetUpper(-1);
						DelegationConnectors_P_PWP_A_Unconnected_Pattern_r_ConnectorEnd135.SetLower(0);
						DelegationConnectors_P_PWP_A_Unconnected_Pattern_r_ConnectorEnd135.SetRole(DelegationConnectors_P_PWP_B_q);
						DelegationConnectors_P_PWP_A_Unconnected_Pattern_r_ConnectorEnd135.SetPartWithPort(DelegationConnectors_P_PWP_A_Unconnected_Pattern_b);
						
					DelegationConnectors_P_PWP_A_Unconnected_Pattern_r.AddEnd(DelegationConnectors_P_PWP_A_Unconnected_Pattern_r_ConnectorEnd135);
					DelegationConnectors_P_PWP_A_Unconnected_Pattern_r.SetType(DelegationConnectors_P_PWP_R);
				DelegationConnectors_P_PWP_A_Unconnected_Pattern.AddOwnedConnector(DelegationConnectors_P_PWP_A_Unconnected_Pattern_r);
					// Operation A_Unconnected_Pattern_A_Unconnected_Pattern
					DelegationConnectors_P_PWP_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern.SetName("A_Unconnected_Pattern_A_Unconnected_Pattern");
					DelegationConnectors_P_PWP_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
						// Parameter result
						DelegationConnectors_P_PWP_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result.SetName("result");
						DelegationConnectors_P_PWP_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result.SetVisibility(VisibilityKind.public_);
						
						DelegationConnectors_P_PWP_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result.SetType(DelegationConnectors_P_PWP_A_Unconnected_Pattern);
						DelegationConnectors_P_PWP_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result.SetDirection(ParameterDirectionKind.return_);
					DelegationConnectors_P_PWP_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern.AddOwnedParameter(DelegationConnectors_P_PWP_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern_result);
					DelegationConnectors_P_PWP_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				DelegationConnectors_P_PWP_A_Unconnected_Pattern.AddOwnedOperation(DelegationConnectors_P_PWP_A_Unconnected_Pattern_A_Unconnected_Pattern_A_Unconnected_Pattern);
			DelegationConnectors_P_PWP.AddPackagedElement(DelegationConnectors_P_PWP_A_Unconnected_Pattern);
				// Activity instantiate_A_Star_Pattern
				DelegationConnectors_P_PWP_instantiate_A_Star_Pattern.SetName("instantiate_A_Star_Pattern");
				DelegationConnectors_P_PWP_instantiate_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Star_Pattern
					DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_a_Star_Pattern.SetName("a_Star_Pattern");
					DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_a_Star_Pattern.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_a_Star_Pattern.SetType(DelegationConnectors_P_PWP_A_Star_Pattern);
					DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_a_Star_Pattern.SetDirection(ParameterDirectionKind.return_);
				DelegationConnectors_P_PWP_instantiate_A_Star_Pattern.AddOwnedParameter(DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_a_Star_Pattern);
					// CallOperationAction A_Star_Pattern()
					DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_A_Star_Pattern_.SetName("A_Star_Pattern()");
					DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_A_Star_Pattern_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__result.SetName("result");
						DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__result.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__result.SetType(DelegationConnectors_P_PWP_A_Star_Pattern);
					DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_A_Star_Pattern_.AddResult(DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__result);
					DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_A_Star_Pattern_.SetOperation(DelegationConnectors_P_PWP_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern);
						// InputPin target
						DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__target.SetName("target");
						DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__target.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__target.SetType(DelegationConnectors_P_PWP_A_Star_Pattern);
					DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_A_Star_Pattern_.SetTarget(DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__target);
				DelegationConnectors_P_PWP_instantiate_A_Star_Pattern.AddNode(DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_A_Star_Pattern_);
					// CreateObjectAction Create A_Star_Pattern
					DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern.SetName("Create A_Star_Pattern");
					DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern.SetClassifier(DelegationConnectors_P_PWP_A_Star_Pattern);
						// OutputPin result
						DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result.SetName("result");
						DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result.SetType(DelegationConnectors_P_PWP_A_Star_Pattern);
					DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern.SetResult(DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result);
				DelegationConnectors_P_PWP_instantiate_A_Star_Pattern.AddNode(DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern);
					// ActivityParameterNode a_Star_Pattern_node
					DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_a_Star_Pattern_node.SetName("a_Star_Pattern_node");
					DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_a_Star_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_a_Star_Pattern_node.SetParameter(DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_a_Star_Pattern);
				DelegationConnectors_P_PWP_instantiate_A_Star_Pattern.AddNode(DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_a_Star_Pattern_node);
					// ObjectFlow ObjectFlow147 from result to a_Star_Pattern_node
					DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_ObjectFlow147.SetName("ObjectFlow147");
					DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_ObjectFlow147.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_ObjectFlow147.SetSource(DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__result);
					DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_ObjectFlow147.SetTarget(DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_a_Star_Pattern_node);
						// LiteralBoolean LiteralBoolean148
						DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_ObjectFlow147_LiteralBoolean148.SetName("LiteralBoolean148");
						DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_ObjectFlow147_LiteralBoolean148.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_ObjectFlow147_LiteralBoolean148.SetValue(true);
					DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_ObjectFlow147.SetGuard(DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_ObjectFlow147_LiteralBoolean148);
				DelegationConnectors_P_PWP_instantiate_A_Star_Pattern.AddEdge(DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_ObjectFlow147);
					// ObjectFlow ObjectFlow152 from result to target
					DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_ObjectFlow152.SetName("ObjectFlow152");
					DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_ObjectFlow152.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_ObjectFlow152.SetSource(DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_Create_A_Star_Pattern_result);
					DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_ObjectFlow152.SetTarget(DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_A_Star_Pattern__target);
						// LiteralBoolean LiteralBoolean154
						DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_ObjectFlow152_LiteralBoolean154.SetName("LiteralBoolean154");
						DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_ObjectFlow152_LiteralBoolean154.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_ObjectFlow152_LiteralBoolean154.SetValue(true);
					DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_ObjectFlow152.SetGuard(DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_ObjectFlow152_LiteralBoolean154);
				DelegationConnectors_P_PWP_instantiate_A_Star_Pattern.AddEdge(DelegationConnectors_P_PWP_instantiate_A_Star_Pattern_ObjectFlow152);
			DelegationConnectors_P_PWP.AddPackagedElement(DelegationConnectors_P_PWP_instantiate_A_Star_Pattern);
				// Activity assert_A_Unconnected_Pattern
				DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern.SetName("assert_A_Unconnected_Pattern");
				DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Unconnected_Pattern
					DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_a_Unconnected_Pattern.SetName("a_Unconnected_Pattern");
					DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_a_Unconnected_Pattern.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_a_Unconnected_Pattern.SetType(DelegationConnectors_P_PWP_A_Unconnected_Pattern);
				DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern.AddOwnedParameter(DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_a_Unconnected_Pattern);
					// ValueSpecificationAction message
					DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_message.SetName("message");
					DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_message.SetVisibility(VisibilityKind.public_);
						// LiteralString LiteralString155
						DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_message_LiteralString155.SetName("LiteralString155");
						DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_message_LiteralString155.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_message_LiteralString155.SetValue("Assertion currently not implemented for A_Unconnected_Pattern.");
					DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_message.SetValue(DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_message_LiteralString155);
						// OutputPin result
						DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_message_result.SetName("result");
						DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_message_result.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_message.SetResult(DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_message_result);
				DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern.AddNode(DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_message);
					// CallBehaviorAction writeLine
					DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine.SetName("writeLine");
					DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine.SetVisibility(VisibilityKind.public_);
					
						// OutputPin errorStatus
						DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine_errorStatus.SetName("errorStatus");
						DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine_errorStatus.SetVisibility(VisibilityKind.public_);
						
						DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine_errorStatus.SetLower(0);
					DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine.AddResult(DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine_errorStatus);
					DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
						// InputPin value
						DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine_value.SetName("value");
						DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine_value.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine.AddArgument(DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine_value);
				DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern.AddNode(DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine);
					// ActivityParameterNode a_Unconnected_Pattern_node
					DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node.SetName("a_Unconnected_Pattern_node");
					DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node.SetParameter(DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_a_Unconnected_Pattern);
				DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern.AddNode(DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_a_Unconnected_Pattern_node);
					// ObjectFlow ObjectFlow158 from result to value
					DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_ObjectFlow158.SetName("ObjectFlow158");
					DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_ObjectFlow158.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_ObjectFlow158.SetSource(DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_message_result);
					DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_ObjectFlow158.SetTarget(DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_writeLine_value);
						// LiteralBoolean LiteralBoolean159
						DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_ObjectFlow158_LiteralBoolean159.SetName("LiteralBoolean159");
						DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_ObjectFlow158_LiteralBoolean159.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_ObjectFlow158_LiteralBoolean159.SetValue(true);
					DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_ObjectFlow158.SetGuard(DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_ObjectFlow158_LiteralBoolean159);
				DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern.AddEdge(DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern_ObjectFlow158);
			DelegationConnectors_P_PWP.AddPackagedElement(DelegationConnectors_P_PWP_assert_A_Unconnected_Pattern);
				// Class A_Empty_Pattern
				DelegationConnectors_P_PWP_A_Empty_Pattern.SetName("A_Empty_Pattern");
				DelegationConnectors_P_PWP_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Property b
					DelegationConnectors_P_PWP_A_Empty_Pattern_b.SetName("b");
					DelegationConnectors_P_PWP_A_Empty_Pattern_b.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_PWP_A_Empty_Pattern_b.SetUpper(-1);
					DelegationConnectors_P_PWP_A_Empty_Pattern_b.SetLower(0);
					DelegationConnectors_P_PWP_A_Empty_Pattern_b.SetType(DelegationConnectors_P_PWP_B);
					DelegationConnectors_P_PWP_A_Empty_Pattern_b.SetAggregation(AggregationKind.composite);
				DelegationConnectors_P_PWP_A_Empty_Pattern.AddOwnedAttribute(DelegationConnectors_P_PWP_A_Empty_Pattern_b);
					// Port p
					DelegationConnectors_P_PWP_A_Empty_Pattern_p.SetName("p");
					DelegationConnectors_P_PWP_A_Empty_Pattern_p.SetVisibility(VisibilityKind.public_);
					DelegationConnectors_P_PWP_A_Empty_Pattern_p.SetUpper(-1);
					DelegationConnectors_P_PWP_A_Empty_Pattern_p.SetLower(0);
					DelegationConnectors_P_PWP_A_Empty_Pattern_p.SetType(DelegationConnectors_P_PWP_IImpl);
					DelegationConnectors_P_PWP_A_Empty_Pattern_p.SetAggregation(AggregationKind.composite);
					DelegationConnectors_P_PWP_A_Empty_Pattern_p.isService = true;
					DelegationConnectors_P_PWP_A_Empty_Pattern_p.AddProvided(DelegationConnectors_P_PWP_I);
				DelegationConnectors_P_PWP_A_Empty_Pattern.AddOwnedAttribute(DelegationConnectors_P_PWP_A_Empty_Pattern_p);
				
				DelegationConnectors_P_PWP_A_Empty_Pattern_r.SetName("r");
					DelegationConnectors_P_PWP_A_Empty_Pattern_r.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_A_Empty_Pattern_r_ConnectorEnd175.SetUpper(-1);
						DelegationConnectors_P_PWP_A_Empty_Pattern_r_ConnectorEnd175.SetRole(DelegationConnectors_P_PWP_A_Empty_Pattern_p);
						
					DelegationConnectors_P_PWP_A_Empty_Pattern_r.AddEnd(DelegationConnectors_P_PWP_A_Empty_Pattern_r_ConnectorEnd175);
						DelegationConnectors_P_PWP_A_Empty_Pattern_r_ConnectorEnd173.SetUpper(-1);
						DelegationConnectors_P_PWP_A_Empty_Pattern_r_ConnectorEnd173.SetRole(DelegationConnectors_P_PWP_B_q);
						DelegationConnectors_P_PWP_A_Empty_Pattern_r_ConnectorEnd173.SetPartWithPort(DelegationConnectors_P_PWP_A_Empty_Pattern_b);
						
					DelegationConnectors_P_PWP_A_Empty_Pattern_r.AddEnd(DelegationConnectors_P_PWP_A_Empty_Pattern_r_ConnectorEnd173);
					DelegationConnectors_P_PWP_A_Empty_Pattern_r.SetType(DelegationConnectors_P_PWP_R);
				DelegationConnectors_P_PWP_A_Empty_Pattern.AddOwnedConnector(DelegationConnectors_P_PWP_A_Empty_Pattern_r);
					// Operation A_Empty_Pattern_A_Empty_Pattern
					DelegationConnectors_P_PWP_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern.SetName("A_Empty_Pattern_A_Empty_Pattern");
					DelegationConnectors_P_PWP_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern.SetVisibility(VisibilityKind.public_);
						// Parameter result
						DelegationConnectors_P_PWP_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result.SetName("result");
						DelegationConnectors_P_PWP_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result.SetVisibility(VisibilityKind.public_);
						
						DelegationConnectors_P_PWP_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result.SetType(DelegationConnectors_P_PWP_A_Empty_Pattern);
						DelegationConnectors_P_PWP_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result.SetDirection(ParameterDirectionKind.return_);
					DelegationConnectors_P_PWP_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern.AddOwnedParameter(DelegationConnectors_P_PWP_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern_result);
					DelegationConnectors_P_PWP_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				DelegationConnectors_P_PWP_A_Empty_Pattern.AddOwnedOperation(DelegationConnectors_P_PWP_A_Empty_Pattern_A_Empty_Pattern_A_Empty_Pattern);
			DelegationConnectors_P_PWP.AddPackagedElement(DelegationConnectors_P_PWP_A_Empty_Pattern);
				// Activity assert_A_Star_Pattern
				DelegationConnectors_P_PWP_assert_A_Star_Pattern.SetName("assert_A_Star_Pattern");
				DelegationConnectors_P_PWP_assert_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Parameter a_Star_Pattern
					DelegationConnectors_P_PWP_assert_A_Star_Pattern_a_Star_Pattern.SetName("a_Star_Pattern");
					DelegationConnectors_P_PWP_assert_A_Star_Pattern_a_Star_Pattern.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_assert_A_Star_Pattern_a_Star_Pattern.SetType(DelegationConnectors_P_PWP_A_Star_Pattern);
				DelegationConnectors_P_PWP_assert_A_Star_Pattern.AddOwnedParameter(DelegationConnectors_P_PWP_assert_A_Star_Pattern_a_Star_Pattern);
					// ActivityParameterNode a_Star_Pattern_node
					DelegationConnectors_P_PWP_assert_A_Star_Pattern_a_Star_Pattern_node.SetName("a_Star_Pattern_node");
					DelegationConnectors_P_PWP_assert_A_Star_Pattern_a_Star_Pattern_node.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_assert_A_Star_Pattern_a_Star_Pattern_node.SetParameter(DelegationConnectors_P_PWP_assert_A_Star_Pattern_a_Star_Pattern);
				DelegationConnectors_P_PWP_assert_A_Star_Pattern.AddNode(DelegationConnectors_P_PWP_assert_A_Star_Pattern_a_Star_Pattern_node);
					// ValueSpecificationAction message
					DelegationConnectors_P_PWP_assert_A_Star_Pattern_message.SetName("message");
					DelegationConnectors_P_PWP_assert_A_Star_Pattern_message.SetVisibility(VisibilityKind.public_);
						// LiteralString LiteralString178
						DelegationConnectors_P_PWP_assert_A_Star_Pattern_message_LiteralString178.SetName("LiteralString178");
						DelegationConnectors_P_PWP_assert_A_Star_Pattern_message_LiteralString178.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_assert_A_Star_Pattern_message_LiteralString178.SetValue("Assertion currently not implemented for A_Star_Pattern.");
					DelegationConnectors_P_PWP_assert_A_Star_Pattern_message.SetValue(DelegationConnectors_P_PWP_assert_A_Star_Pattern_message_LiteralString178);
						// OutputPin result
						DelegationConnectors_P_PWP_assert_A_Star_Pattern_message_result.SetName("result");
						DelegationConnectors_P_PWP_assert_A_Star_Pattern_message_result.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_assert_A_Star_Pattern_message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					DelegationConnectors_P_PWP_assert_A_Star_Pattern_message.SetResult(DelegationConnectors_P_PWP_assert_A_Star_Pattern_message_result);
				DelegationConnectors_P_PWP_assert_A_Star_Pattern.AddNode(DelegationConnectors_P_PWP_assert_A_Star_Pattern_message);
					// CallBehaviorAction writeLine
					DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine.SetName("writeLine");
					DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine.SetVisibility(VisibilityKind.public_);
					
						// OutputPin errorStatus
						DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine_errorStatus.SetName("errorStatus");
						DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine_errorStatus.SetVisibility(VisibilityKind.public_);
						
						DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine_errorStatus.SetLower(0);
					DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine.AddResult(DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine_errorStatus);
					DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
						// InputPin value
						DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine_value.SetName("value");
						DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine_value.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine.AddArgument(DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine_value);
				DelegationConnectors_P_PWP_assert_A_Star_Pattern.AddNode(DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine);
					// ObjectFlow ObjectFlow187 from result to value
					DelegationConnectors_P_PWP_assert_A_Star_Pattern_ObjectFlow187.SetName("ObjectFlow187");
					DelegationConnectors_P_PWP_assert_A_Star_Pattern_ObjectFlow187.SetVisibility(VisibilityKind.public_);
					
					DelegationConnectors_P_PWP_assert_A_Star_Pattern_ObjectFlow187.SetSource(DelegationConnectors_P_PWP_assert_A_Star_Pattern_message_result);
					DelegationConnectors_P_PWP_assert_A_Star_Pattern_ObjectFlow187.SetTarget(DelegationConnectors_P_PWP_assert_A_Star_Pattern_writeLine_value);
						// LiteralBoolean LiteralBoolean189
						DelegationConnectors_P_PWP_assert_A_Star_Pattern_ObjectFlow187_LiteralBoolean189.SetName("LiteralBoolean189");
						DelegationConnectors_P_PWP_assert_A_Star_Pattern_ObjectFlow187_LiteralBoolean189.SetVisibility(VisibilityKind.public_);
						DelegationConnectors_P_PWP_assert_A_Star_Pattern_ObjectFlow187_LiteralBoolean189.SetValue(true);
					DelegationConnectors_P_PWP_assert_A_Star_Pattern_ObjectFlow187.SetGuard(DelegationConnectors_P_PWP_assert_A_Star_Pattern_ObjectFlow187_LiteralBoolean189);
				DelegationConnectors_P_PWP_assert_A_Star_Pattern.AddEdge(DelegationConnectors_P_PWP_assert_A_Star_Pattern_ObjectFlow187);
			DelegationConnectors_P_PWP.AddPackagedElement(DelegationConnectors_P_PWP_assert_A_Star_Pattern);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // DelegationConnectors_P_PWPModel
}
