/*
 * PolymorphismTestModel.cs
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

namespace PolymorphismTest
{
	public class PolymorphismTestModel : InMemoryModel
	{
		private static PolymorphismTestModel? instance;

		/*
		 * Model PolymorphismTest
		 */
		public Package PolymorphismTest = new();
			public Class_ PolymorphismTest_U = new();
				public Activity PolymorphismTest_U_o4_method = new();
					public CallBehaviorAction PolymorphismTest_U_o4_method_Call_WriteLine = new();
						public InputPin PolymorphismTest_U_o4_method_Call_WriteLine_value = new();
							public LiteralInteger PolymorphismTest_U_o4_method_Call_WriteLine_value_LiteralInteger0 = new();
							public LiteralInteger PolymorphismTest_U_o4_method_Call_WriteLine_value_LiteralInteger1 = new();
							public LiteralUnlimitedNatural PolymorphismTest_U_o4_method_Call_WriteLine_value_LiteralUnlimitedNatural2 = new();
						public OutputPin PolymorphismTest_U_o4_method_Call_WriteLine_errorStatus = new();
							public LiteralInteger PolymorphismTest_U_o4_method_Call_WriteLine_errorStatus_LiteralInteger3 = new();
							public LiteralInteger PolymorphismTest_U_o4_method_Call_WriteLine_errorStatus_LiteralInteger4 = new();
							public LiteralUnlimitedNatural PolymorphismTest_U_o4_method_Call_WriteLine_errorStatus_LiteralUnlimitedNatural5 = new();
					public ValueSpecificationAction PolymorphismTest_U_o4_method_Message = new();
						public LiteralString PolymorphismTest_U_o4_method_Message_LiteralString6 = new();
						public OutputPin PolymorphismTest_U_o4_method_Message_result = new();
							public LiteralInteger PolymorphismTest_U_o4_method_Message_result_LiteralInteger7 = new();
							public LiteralUnlimitedNatural PolymorphismTest_U_o4_method_Message_result_LiteralUnlimitedNatural8 = new();
					public ObjectFlow PolymorphismTest_U_o4_method_ObjectFlow9 = new();
						public LiteralInteger PolymorphismTest_U_o4_method_ObjectFlow9_LiteralInteger10 = new();
						public LiteralBoolean PolymorphismTest_U_o4_method_ObjectFlow9_LiteralBoolean11 = new();
				public Activity PolymorphismTest_U_o2_method = new();
					public ActivityParameterNode PolymorphismTest_U_o2_method_b_node = new();
						public LiteralInteger PolymorphismTest_U_o2_method_b_node_LiteralInteger12 = new();
					public ObjectFlow PolymorphismTest_U_o2_method_ObjectFlow13 = new();
						public LiteralInteger PolymorphismTest_U_o2_method_ObjectFlow13_LiteralInteger14 = new();
						public LiteralBoolean PolymorphismTest_U_o2_method_ObjectFlow13_LiteralBoolean15 = new();
					public CallBehaviorAction PolymorphismTest_U_o2_method_Call_WriteLine = new();
						public InputPin PolymorphismTest_U_o2_method_Call_WriteLine_value = new();
							public LiteralInteger PolymorphismTest_U_o2_method_Call_WriteLine_value_LiteralInteger16 = new();
							public LiteralInteger PolymorphismTest_U_o2_method_Call_WriteLine_value_LiteralInteger17 = new();
							public LiteralUnlimitedNatural PolymorphismTest_U_o2_method_Call_WriteLine_value_LiteralUnlimitedNatural18 = new();
						public OutputPin PolymorphismTest_U_o2_method_Call_WriteLine_errorStatus = new();
							public LiteralInteger PolymorphismTest_U_o2_method_Call_WriteLine_errorStatus_LiteralInteger19 = new();
							public LiteralInteger PolymorphismTest_U_o2_method_Call_WriteLine_errorStatus_LiteralInteger20 = new();
							public LiteralUnlimitedNatural PolymorphismTest_U_o2_method_Call_WriteLine_errorStatus_LiteralUnlimitedNatural21 = new();
					public Parameter PolymorphismTest_U_o2_method_b = new();
					public Parameter PolymorphismTest_U_o2_method_a = new();
					public ValueSpecificationAction PolymorphismTest_U_o2_method_Message = new();
						public OutputPin PolymorphismTest_U_o2_method_Message_result = new();
							public LiteralInteger PolymorphismTest_U_o2_method_Message_result_LiteralInteger22 = new();
							public LiteralUnlimitedNatural PolymorphismTest_U_o2_method_Message_result_LiteralUnlimitedNatural23 = new();
						public LiteralString PolymorphismTest_U_o2_method_Message_LiteralString24 = new();
					public ActivityParameterNode PolymorphismTest_U_o2_method_a_node = new();
						public LiteralInteger PolymorphismTest_U_o2_method_a_node_LiteralInteger25 = new();
				public Operation PolymorphismTest_U_x = new();
				public Operation PolymorphismTest_U_A_o1_B = new();
					public Parameter PolymorphismTest_U_A_o1_B_b = new();
					public Parameter PolymorphismTest_U_A_o1_B_a = new();
				public Operation PolymorphismTest_U_A_o2_B = new();
					public Parameter PolymorphismTest_U_A_o2_B_a = new();
					public Parameter PolymorphismTest_U_A_o2_B_b = new();
				public Operation PolymorphismTest_U_o4 = new();
				public Operation PolymorphismTest_U_o3_Integer = new();
					public Parameter PolymorphismTest_U_o3_Integer_i = new();
				public Activity PolymorphismTest_U_o3_method = new();
					public ActivityParameterNode PolymorphismTest_U_o3_method_i_node = new();
						public LiteralInteger PolymorphismTest_U_o3_method_i_node_LiteralInteger26 = new();
					public ValueSpecificationAction PolymorphismTest_U_o3_method_Message = new();
						public OutputPin PolymorphismTest_U_o3_method_Message_result = new();
							public LiteralInteger PolymorphismTest_U_o3_method_Message_result_LiteralInteger27 = new();
							public LiteralUnlimitedNatural PolymorphismTest_U_o3_method_Message_result_LiteralUnlimitedNatural28 = new();
						public LiteralString PolymorphismTest_U_o3_method_Message_LiteralString29 = new();
					public CallBehaviorAction PolymorphismTest_U_o3_method_Call_WriteLine = new();
						public InputPin PolymorphismTest_U_o3_method_Call_WriteLine_value = new();
							public LiteralUnlimitedNatural PolymorphismTest_U_o3_method_Call_WriteLine_value_LiteralUnlimitedNatural30 = new();
							public LiteralInteger PolymorphismTest_U_o3_method_Call_WriteLine_value_LiteralInteger31 = new();
							public LiteralInteger PolymorphismTest_U_o3_method_Call_WriteLine_value_LiteralInteger32 = new();
						public OutputPin PolymorphismTest_U_o3_method_Call_WriteLine_errorStatus = new();
							public LiteralInteger PolymorphismTest_U_o3_method_Call_WriteLine_errorStatus_LiteralInteger33 = new();
							public LiteralInteger PolymorphismTest_U_o3_method_Call_WriteLine_errorStatus_LiteralInteger34 = new();
							public LiteralUnlimitedNatural PolymorphismTest_U_o3_method_Call_WriteLine_errorStatus_LiteralUnlimitedNatural35 = new();
					public Parameter PolymorphismTest_U_o3_method_i = new();
					public ObjectFlow PolymorphismTest_U_o3_method_ObjectFlow36 = new();
						public LiteralInteger PolymorphismTest_U_o3_method_ObjectFlow36_LiteralInteger37 = new();
						public LiteralBoolean PolymorphismTest_U_o3_method_ObjectFlow36_LiteralBoolean38 = new();
				public Activity PolymorphismTest_U_x_method = new();
					public CallBehaviorAction PolymorphismTest_U_x_method_Call_WriteLine = new();
						public OutputPin PolymorphismTest_U_x_method_Call_WriteLine_errorStatus = new();
							public LiteralInteger PolymorphismTest_U_x_method_Call_WriteLine_errorStatus_LiteralInteger39 = new();
							public LiteralInteger PolymorphismTest_U_x_method_Call_WriteLine_errorStatus_LiteralInteger40 = new();
							public LiteralUnlimitedNatural PolymorphismTest_U_x_method_Call_WriteLine_errorStatus_LiteralUnlimitedNatural41 = new();
						public InputPin PolymorphismTest_U_x_method_Call_WriteLine_value = new();
							public LiteralInteger PolymorphismTest_U_x_method_Call_WriteLine_value_LiteralInteger42 = new();
							public LiteralInteger PolymorphismTest_U_x_method_Call_WriteLine_value_LiteralInteger43 = new();
							public LiteralUnlimitedNatural PolymorphismTest_U_x_method_Call_WriteLine_value_LiteralUnlimitedNatural44 = new();
					public ObjectFlow PolymorphismTest_U_x_method_ObjectFlow45 = new();
						public LiteralBoolean PolymorphismTest_U_x_method_ObjectFlow45_LiteralBoolean46 = new();
						public LiteralInteger PolymorphismTest_U_x_method_ObjectFlow45_LiteralInteger47 = new();
					public ValueSpecificationAction PolymorphismTest_U_x_method_Message = new();
						public LiteralString PolymorphismTest_U_x_method_Message_LiteralString48 = new();
						public OutputPin PolymorphismTest_U_x_method_Message_result = new();
							public LiteralInteger PolymorphismTest_U_x_method_Message_result_LiteralInteger49 = new();
							public LiteralUnlimitedNatural PolymorphismTest_U_x_method_Message_result_LiteralUnlimitedNatural50 = new();
				public Activity PolymorphismTest_U_o1_method = new();
					public Parameter PolymorphismTest_U_o1_method_b = new();
					public ValueSpecificationAction PolymorphismTest_U_o1_method_Message = new();
						public OutputPin PolymorphismTest_U_o1_method_Message_result = new();
							public LiteralInteger PolymorphismTest_U_o1_method_Message_result_LiteralInteger51 = new();
							public LiteralUnlimitedNatural PolymorphismTest_U_o1_method_Message_result_LiteralUnlimitedNatural52 = new();
						public LiteralString PolymorphismTest_U_o1_method_Message_LiteralString53 = new();
					public Parameter PolymorphismTest_U_o1_method_a = new();
					public CallBehaviorAction PolymorphismTest_U_o1_method_Call_WriteLine = new();
						public InputPin PolymorphismTest_U_o1_method_Call_WriteLine_value = new();
							public LiteralUnlimitedNatural PolymorphismTest_U_o1_method_Call_WriteLine_value_LiteralUnlimitedNatural54 = new();
							public LiteralInteger PolymorphismTest_U_o1_method_Call_WriteLine_value_LiteralInteger55 = new();
							public LiteralInteger PolymorphismTest_U_o1_method_Call_WriteLine_value_LiteralInteger56 = new();
						public OutputPin PolymorphismTest_U_o1_method_Call_WriteLine_errorStatus = new();
							public LiteralUnlimitedNatural PolymorphismTest_U_o1_method_Call_WriteLine_errorStatus_LiteralUnlimitedNatural57 = new();
							public LiteralInteger PolymorphismTest_U_o1_method_Call_WriteLine_errorStatus_LiteralInteger58 = new();
							public LiteralInteger PolymorphismTest_U_o1_method_Call_WriteLine_errorStatus_LiteralInteger59 = new();
					public ActivityParameterNode PolymorphismTest_U_o1_method_b_node = new();
						public LiteralInteger PolymorphismTest_U_o1_method_b_node_LiteralInteger60 = new();
					public ActivityParameterNode PolymorphismTest_U_o1_method_a_node = new();
						public LiteralInteger PolymorphismTest_U_o1_method_a_node_LiteralInteger61 = new();
					public ObjectFlow PolymorphismTest_U_o1_method_ObjectFlow62 = new();
						public LiteralInteger PolymorphismTest_U_o1_method_ObjectFlow62_LiteralInteger63 = new();
						public LiteralBoolean PolymorphismTest_U_o1_method_ObjectFlow62_LiteralBoolean64 = new();
			public Class_ PolymorphismTest_B = new();
				public Generalization PolymorphismTest_B_Generalization65 = new();
			public Class_ PolymorphismTest_A = new();
				public Activity PolymorphismTest_A_x_method = new();
					public CallBehaviorAction PolymorphismTest_A_x_method_Call_WriteLine = new();
						public InputPin PolymorphismTest_A_x_method_Call_WriteLine_value = new();
							public LiteralUnlimitedNatural PolymorphismTest_A_x_method_Call_WriteLine_value_LiteralUnlimitedNatural66 = new();
							public LiteralInteger PolymorphismTest_A_x_method_Call_WriteLine_value_LiteralInteger67 = new();
							public LiteralInteger PolymorphismTest_A_x_method_Call_WriteLine_value_LiteralInteger68 = new();
						public OutputPin PolymorphismTest_A_x_method_Call_WriteLine_errorStatus = new();
							public LiteralInteger PolymorphismTest_A_x_method_Call_WriteLine_errorStatus_LiteralInteger69 = new();
							public LiteralUnlimitedNatural PolymorphismTest_A_x_method_Call_WriteLine_errorStatus_LiteralUnlimitedNatural70 = new();
							public LiteralInteger PolymorphismTest_A_x_method_Call_WriteLine_errorStatus_LiteralInteger71 = new();
					public ValueSpecificationAction PolymorphismTest_A_x_method_Message = new();
						public LiteralString PolymorphismTest_A_x_method_Message_LiteralString72 = new();
						public OutputPin PolymorphismTest_A_x_method_Message_result = new();
							public LiteralUnlimitedNatural PolymorphismTest_A_x_method_Message_result_LiteralUnlimitedNatural73 = new();
							public LiteralInteger PolymorphismTest_A_x_method_Message_result_LiteralInteger74 = new();
					public ObjectFlow PolymorphismTest_A_x_method_ObjectFlow75 = new();
						public LiteralBoolean PolymorphismTest_A_x_method_ObjectFlow75_LiteralBoolean76 = new();
						public LiteralInteger PolymorphismTest_A_x_method_ObjectFlow75_LiteralInteger77 = new();
				public Operation PolymorphismTest_A_x = new();
			public Activity PolymorphismTest_main = new();
				public CallBehaviorAction PolymorphismTest_main_Call_runTests = new();
					public InputPin PolymorphismTest_main_Call_runTests_u = new();
						public LiteralInteger PolymorphismTest_main_Call_runTests_u_LiteralInteger78 = new();
						public LiteralUnlimitedNatural PolymorphismTest_main_Call_runTests_u_LiteralUnlimitedNatural79 = new();
						public LiteralInteger PolymorphismTest_main_Call_runTests_u_LiteralInteger80 = new();
				public Activity PolymorphismTest_main_runTests = new();
					public ObjectFlow PolymorphismTest_main_runTests_ObjectFlow81 = new();
						public LiteralBoolean PolymorphismTest_main_runTests_ObjectFlow81_LiteralBoolean82 = new();
						public LiteralInteger PolymorphismTest_main_runTests_ObjectFlow81_LiteralInteger83 = new();
					public ControlFlow PolymorphismTest_main_runTests_ControlFlow84 = new();
					public CallOperationAction PolymorphismTest_main_runTests_Call_o3_ = new();
						public InputPin PolymorphismTest_main_runTests_Call_o3__target = new();
							public LiteralUnlimitedNatural PolymorphismTest_main_runTests_Call_o3__target_LiteralUnlimitedNatural85 = new();
							public LiteralInteger PolymorphismTest_main_runTests_Call_o3__target_LiteralInteger86 = new();
						public InputPin PolymorphismTest_main_runTests_Call_o3__i = new();
							public LiteralInteger PolymorphismTest_main_runTests_Call_o3__i_LiteralInteger87 = new();
							public LiteralInteger PolymorphismTest_main_runTests_Call_o3__i_LiteralInteger88 = new();
					public CallOperationAction PolymorphismTest_main_runTests_Call_A_x_ = new();
						public InputPin PolymorphismTest_main_runTests_Call_A_x__target = new();
							public LiteralInteger PolymorphismTest_main_runTests_Call_A_x__target_LiteralInteger89 = new();
							public LiteralUnlimitedNatural PolymorphismTest_main_runTests_Call_A_x__target_LiteralUnlimitedNatural90 = new();
					public CallOperationAction PolymorphismTest_main_runTests_Call_U_o1_ = new();
						public InputPin PolymorphismTest_main_runTests_Call_U_o1__target = new();
						public InputPin PolymorphismTest_main_runTests_Call_U_o1__b = new();
							public LiteralInteger PolymorphismTest_main_runTests_Call_U_o1__b_LiteralInteger91 = new();
							public LiteralInteger PolymorphismTest_main_runTests_Call_U_o1__b_LiteralInteger92 = new();
						public OutputPin PolymorphismTest_main_runTests_Call_U_o1__a = new();
							public LiteralUnlimitedNatural PolymorphismTest_main_runTests_Call_U_o1__a_LiteralUnlimitedNatural93 = new();
							public LiteralInteger PolymorphismTest_main_runTests_Call_U_o1__a_LiteralInteger94 = new();
							public LiteralInteger PolymorphismTest_main_runTests_Call_U_o1__a_LiteralInteger95 = new();
					public ObjectFlow PolymorphismTest_main_runTests_ObjectFlow96 = new();
						public LiteralBoolean PolymorphismTest_main_runTests_ObjectFlow96_LiteralBoolean97 = new();
						public LiteralInteger PolymorphismTest_main_runTests_ObjectFlow96_LiteralInteger98 = new();
					public CallOperationAction PolymorphismTest_main_runTests_Call_o4_ = new();
						public InputPin PolymorphismTest_main_runTests_Call_o4__target = new();
							public LiteralInteger PolymorphismTest_main_runTests_Call_o4__target_LiteralInteger99 = new();
							public LiteralUnlimitedNatural PolymorphismTest_main_runTests_Call_o4__target_LiteralUnlimitedNatural100 = new();
					public ObjectFlow PolymorphismTest_main_runTests_ObjectFlow101 = new();
						public LiteralBoolean PolymorphismTest_main_runTests_ObjectFlow101_LiteralBoolean102 = new();
						public LiteralInteger PolymorphismTest_main_runTests_ObjectFlow101_LiteralInteger103 = new();
					public Parameter PolymorphismTest_main_runTests_u = new();
					public ObjectFlow PolymorphismTest_main_runTests_ObjectFlow104 = new();
						public LiteralInteger PolymorphismTest_main_runTests_ObjectFlow104_LiteralInteger105 = new();
						public LiteralBoolean PolymorphismTest_main_runTests_ObjectFlow104_LiteralBoolean106 = new();
					public ObjectFlow PolymorphismTest_main_runTests_ObjectFlow107 = new();
						public LiteralInteger PolymorphismTest_main_runTests_ObjectFlow107_LiteralInteger108 = new();
						public LiteralBoolean PolymorphismTest_main_runTests_ObjectFlow107_LiteralBoolean109 = new();
					public ControlFlow PolymorphismTest_main_runTests_ControlFlow110 = new();
					public ActivityParameterNode PolymorphismTest_main_runTests_u_node = new();
						public LiteralInteger PolymorphismTest_main_runTests_u_node_LiteralInteger111 = new();
					public ControlFlow PolymorphismTest_main_runTests_ControlFlow112 = new();
					public ForkNode PolymorphismTest_main_runTests_Fork_u = new();
					public CallOperationAction PolymorphismTest_main_runTests_Call_o2_ = new();
						public OutputPin PolymorphismTest_main_runTests_Call_o2__a = new();
							public LiteralInteger PolymorphismTest_main_runTests_Call_o2__a_LiteralInteger113 = new();
							public LiteralUnlimitedNatural PolymorphismTest_main_runTests_Call_o2__a_LiteralUnlimitedNatural114 = new();
							public LiteralInteger PolymorphismTest_main_runTests_Call_o2__a_LiteralInteger115 = new();
						public InputPin PolymorphismTest_main_runTests_Call_o2__target = new();
							public LiteralUnlimitedNatural PolymorphismTest_main_runTests_Call_o2__target_LiteralUnlimitedNatural116 = new();
							public LiteralInteger PolymorphismTest_main_runTests_Call_o2__target_LiteralInteger117 = new();
						public InputPin PolymorphismTest_main_runTests_Call_o2__b = new();
							public LiteralInteger PolymorphismTest_main_runTests_Call_o2__b_LiteralInteger118 = new();
							public LiteralInteger PolymorphismTest_main_runTests_Call_o2__b_LiteralInteger119 = new();
					public ObjectFlow PolymorphismTest_main_runTests_ObjectFlow120 = new();
						public LiteralBoolean PolymorphismTest_main_runTests_ObjectFlow120_LiteralBoolean121 = new();
						public LiteralInteger PolymorphismTest_main_runTests_ObjectFlow120_LiteralInteger122 = new();
					public ObjectFlow PolymorphismTest_main_runTests_ObjectFlow123 = new();
						public LiteralBoolean PolymorphismTest_main_runTests_ObjectFlow123_LiteralBoolean124 = new();
						public LiteralInteger PolymorphismTest_main_runTests_ObjectFlow123_LiteralInteger125 = new();
					public ControlFlow PolymorphismTest_main_runTests_ControlFlow126 = new();
					public ControlFlow PolymorphismTest_main_runTests_ControlFlow127 = new();
					public CallOperationAction PolymorphismTest_main_runTests_Call_o1_ = new();
						public InputPin PolymorphismTest_main_runTests_Call_o1__target = new();
							public LiteralUnlimitedNatural PolymorphismTest_main_runTests_Call_o1__target_LiteralUnlimitedNatural128 = new();
							public LiteralInteger PolymorphismTest_main_runTests_Call_o1__target_LiteralInteger129 = new();
						public InputPin PolymorphismTest_main_runTests_Call_o1__b = new();
							public LiteralInteger PolymorphismTest_main_runTests_Call_o1__b_LiteralInteger130 = new();
							public LiteralInteger PolymorphismTest_main_runTests_Call_o1__b_LiteralInteger131 = new();
						public OutputPin PolymorphismTest_main_runTests_Call_o1__a = new();
							public LiteralInteger PolymorphismTest_main_runTests_Call_o1__a_LiteralInteger132 = new();
							public LiteralUnlimitedNatural PolymorphismTest_main_runTests_Call_o1__a_LiteralUnlimitedNatural133 = new();
							public LiteralInteger PolymorphismTest_main_runTests_Call_o1__a_LiteralInteger134 = new();
				public CreateObjectAction PolymorphismTest_main_Create_S = new();
					public OutputPin PolymorphismTest_main_Create_S_result = new();
						public LiteralInteger PolymorphismTest_main_Create_S_result_LiteralInteger135 = new();
						public LiteralUnlimitedNatural PolymorphismTest_main_Create_S_result_LiteralUnlimitedNatural136 = new();
				public ObjectFlow PolymorphismTest_main_ObjectFlow137 = new();
					public LiteralBoolean PolymorphismTest_main_ObjectFlow137_LiteralBoolean138 = new();
					public LiteralInteger PolymorphismTest_main_ObjectFlow137_LiteralInteger139 = new();
			public Class_ PolymorphismTest_T = new();
				public Activity PolymorphismTest_T_o4_method = new();
					public ValueSpecificationAction PolymorphismTest_T_o4_method_Message = new();
						public OutputPin PolymorphismTest_T_o4_method_Message_result = new();
							public LiteralInteger PolymorphismTest_T_o4_method_Message_result_LiteralInteger140 = new();
							public LiteralUnlimitedNatural PolymorphismTest_T_o4_method_Message_result_LiteralUnlimitedNatural141 = new();
						public LiteralString PolymorphismTest_T_o4_method_Message_LiteralString142 = new();
					public CallBehaviorAction PolymorphismTest_T_o4_method_Call_WriteLine = new();
						public OutputPin PolymorphismTest_T_o4_method_Call_WriteLine_errorStatus = new();
							public LiteralInteger PolymorphismTest_T_o4_method_Call_WriteLine_errorStatus_LiteralInteger143 = new();
							public LiteralInteger PolymorphismTest_T_o4_method_Call_WriteLine_errorStatus_LiteralInteger144 = new();
							public LiteralUnlimitedNatural PolymorphismTest_T_o4_method_Call_WriteLine_errorStatus_LiteralUnlimitedNatural145 = new();
						public InputPin PolymorphismTest_T_o4_method_Call_WriteLine_value = new();
							public LiteralInteger PolymorphismTest_T_o4_method_Call_WriteLine_value_LiteralInteger146 = new();
							public LiteralUnlimitedNatural PolymorphismTest_T_o4_method_Call_WriteLine_value_LiteralUnlimitedNatural147 = new();
							public LiteralInteger PolymorphismTest_T_o4_method_Call_WriteLine_value_LiteralInteger148 = new();
					public ObjectFlow PolymorphismTest_T_o4_method_ObjectFlow149 = new();
						public LiteralBoolean PolymorphismTest_T_o4_method_ObjectFlow149_LiteralBoolean150 = new();
						public LiteralInteger PolymorphismTest_T_o4_method_ObjectFlow149_LiteralInteger151 = new();
				public Operation PolymorphismTest_T_o3_Integer = new();
					public Parameter PolymorphismTest_T_o3_Integer_i = new();
				public Activity PolymorphismTest_T_o1_method = new();
					public ValueSpecificationAction PolymorphismTest_T_o1_method_Message = new();
						public LiteralString PolymorphismTest_T_o1_method_Message_LiteralString152 = new();
						public OutputPin PolymorphismTest_T_o1_method_Message_result = new();
							public LiteralUnlimitedNatural PolymorphismTest_T_o1_method_Message_result_LiteralUnlimitedNatural153 = new();
							public LiteralInteger PolymorphismTest_T_o1_method_Message_result_LiteralInteger154 = new();
					public CallBehaviorAction PolymorphismTest_T_o1_method_Call_WriteLine = new();
						public OutputPin PolymorphismTest_T_o1_method_Call_WriteLine_errorStatus = new();
							public LiteralInteger PolymorphismTest_T_o1_method_Call_WriteLine_errorStatus_LiteralInteger155 = new();
							public LiteralInteger PolymorphismTest_T_o1_method_Call_WriteLine_errorStatus_LiteralInteger156 = new();
							public LiteralUnlimitedNatural PolymorphismTest_T_o1_method_Call_WriteLine_errorStatus_LiteralUnlimitedNatural157 = new();
						public InputPin PolymorphismTest_T_o1_method_Call_WriteLine_value = new();
							public LiteralInteger PolymorphismTest_T_o1_method_Call_WriteLine_value_LiteralInteger158 = new();
							public LiteralUnlimitedNatural PolymorphismTest_T_o1_method_Call_WriteLine_value_LiteralUnlimitedNatural159 = new();
							public LiteralInteger PolymorphismTest_T_o1_method_Call_WriteLine_value_LiteralInteger160 = new();
					public ActivityParameterNode PolymorphismTest_T_o1_method_b_node = new();
						public LiteralInteger PolymorphismTest_T_o1_method_b_node_LiteralInteger161 = new();
					public Parameter PolymorphismTest_T_o1_method_a = new();
					public ActivityParameterNode PolymorphismTest_T_o1_method_a_node = new();
						public LiteralInteger PolymorphismTest_T_o1_method_a_node_LiteralInteger162 = new();
					public ObjectFlow PolymorphismTest_T_o1_method_ObjectFlow163 = new();
						public LiteralBoolean PolymorphismTest_T_o1_method_ObjectFlow163_LiteralBoolean164 = new();
						public LiteralInteger PolymorphismTest_T_o1_method_ObjectFlow163_LiteralInteger165 = new();
					public Parameter PolymorphismTest_T_o1_method_b = new();
				public Activity PolymorphismTest_T_o3_method = new();
					public ObjectFlow PolymorphismTest_T_o3_method_ObjectFlow166 = new();
						public LiteralInteger PolymorphismTest_T_o3_method_ObjectFlow166_LiteralInteger167 = new();
						public LiteralBoolean PolymorphismTest_T_o3_method_ObjectFlow166_LiteralBoolean168 = new();
					public CallBehaviorAction PolymorphismTest_T_o3_method_Call_WriteLine = new();
						public OutputPin PolymorphismTest_T_o3_method_Call_WriteLine_errorStatus = new();
							public LiteralUnlimitedNatural PolymorphismTest_T_o3_method_Call_WriteLine_errorStatus_LiteralUnlimitedNatural169 = new();
							public LiteralInteger PolymorphismTest_T_o3_method_Call_WriteLine_errorStatus_LiteralInteger170 = new();
							public LiteralInteger PolymorphismTest_T_o3_method_Call_WriteLine_errorStatus_LiteralInteger171 = new();
						public InputPin PolymorphismTest_T_o3_method_Call_WriteLine_value = new();
							public LiteralInteger PolymorphismTest_T_o3_method_Call_WriteLine_value_LiteralInteger172 = new();
							public LiteralUnlimitedNatural PolymorphismTest_T_o3_method_Call_WriteLine_value_LiteralUnlimitedNatural173 = new();
							public LiteralInteger PolymorphismTest_T_o3_method_Call_WriteLine_value_LiteralInteger174 = new();
					public Parameter PolymorphismTest_T_o3_method_i = new();
					public ActivityParameterNode PolymorphismTest_T_o3_method_i_node = new();
						public LiteralInteger PolymorphismTest_T_o3_method_i_node_LiteralInteger175 = new();
					public ValueSpecificationAction PolymorphismTest_T_o3_method_Message = new();
						public OutputPin PolymorphismTest_T_o3_method_Message_result = new();
							public LiteralUnlimitedNatural PolymorphismTest_T_o3_method_Message_result_LiteralUnlimitedNatural176 = new();
							public LiteralInteger PolymorphismTest_T_o3_method_Message_result_LiteralInteger177 = new();
						public LiteralString PolymorphismTest_T_o3_method_Message_LiteralString178 = new();
				public Operation PolymorphismTest_T_o4 = new();
				public Generalization PolymorphismTest_T_Generalization179 = new();
				public Activity PolymorphismTest_T_o2_method = new();
					public Parameter PolymorphismTest_T_o2_method_b = new();
					public ObjectFlow PolymorphismTest_T_o2_method_ObjectFlow180 = new();
						public LiteralInteger PolymorphismTest_T_o2_method_ObjectFlow180_LiteralInteger181 = new();
						public LiteralBoolean PolymorphismTest_T_o2_method_ObjectFlow180_LiteralBoolean182 = new();
					public CallBehaviorAction PolymorphismTest_T_o2_method_Call_WriteLine = new();
						public InputPin PolymorphismTest_T_o2_method_Call_WriteLine_value = new();
							public LiteralInteger PolymorphismTest_T_o2_method_Call_WriteLine_value_LiteralInteger183 = new();
							public LiteralInteger PolymorphismTest_T_o2_method_Call_WriteLine_value_LiteralInteger184 = new();
							public LiteralUnlimitedNatural PolymorphismTest_T_o2_method_Call_WriteLine_value_LiteralUnlimitedNatural185 = new();
						public OutputPin PolymorphismTest_T_o2_method_Call_WriteLine_errorStatus = new();
							public LiteralUnlimitedNatural PolymorphismTest_T_o2_method_Call_WriteLine_errorStatus_LiteralUnlimitedNatural186 = new();
							public LiteralInteger PolymorphismTest_T_o2_method_Call_WriteLine_errorStatus_LiteralInteger187 = new();
							public LiteralInteger PolymorphismTest_T_o2_method_Call_WriteLine_errorStatus_LiteralInteger188 = new();
					public Parameter PolymorphismTest_T_o2_method_result = new();
					public ValueSpecificationAction PolymorphismTest_T_o2_method_Message = new();
						public OutputPin PolymorphismTest_T_o2_method_Message_result = new();
							public LiteralInteger PolymorphismTest_T_o2_method_Message_result_LiteralInteger189 = new();
							public LiteralUnlimitedNatural PolymorphismTest_T_o2_method_Message_result_LiteralUnlimitedNatural190 = new();
						public LiteralString PolymorphismTest_T_o2_method_Message_LiteralString191 = new();
					public ActivityParameterNode PolymorphismTest_T_o2_method_b_node = new();
						public LiteralInteger PolymorphismTest_T_o2_method_b_node_LiteralInteger192 = new();
					public ActivityParameterNode PolymorphismTest_T_o2_method_result_node = new();
						public LiteralInteger PolymorphismTest_T_o2_method_result_node_LiteralInteger193 = new();
				public Operation PolymorphismTest_T_B_o2_B = new();
					public Parameter PolymorphismTest_T_B_o2_B_result = new();
					public Parameter PolymorphismTest_T_B_o2_B_b = new();
				public Operation PolymorphismTest_T_A_o1_B = new();
					public Parameter PolymorphismTest_T_A_o1_B_b = new();
					public Parameter PolymorphismTest_T_A_o1_B_a = new();
			public Class_ PolymorphismTest_S = new();
				public Activity PolymorphismTest_S_o1_method = new();
					public Parameter PolymorphismTest_S_o1_method_b = new();
					public ObjectFlow PolymorphismTest_S_o1_method_ObjectFlow194 = new();
						public LiteralInteger PolymorphismTest_S_o1_method_ObjectFlow194_LiteralInteger195 = new();
						public LiteralBoolean PolymorphismTest_S_o1_method_ObjectFlow194_LiteralBoolean196 = new();
					public ActivityParameterNode PolymorphismTest_S_o1_method_a_node = new();
						public LiteralInteger PolymorphismTest_S_o1_method_a_node_LiteralInteger197 = new();
					public ValueSpecificationAction PolymorphismTest_S_o1_method_Message = new();
						public OutputPin PolymorphismTest_S_o1_method_Message_result = new();
							public LiteralInteger PolymorphismTest_S_o1_method_Message_result_LiteralInteger198 = new();
							public LiteralUnlimitedNatural PolymorphismTest_S_o1_method_Message_result_LiteralUnlimitedNatural199 = new();
						public LiteralString PolymorphismTest_S_o1_method_Message_LiteralString200 = new();
					public ActivityParameterNode PolymorphismTest_S_o1_method_b_node = new();
						public LiteralInteger PolymorphismTest_S_o1_method_b_node_LiteralInteger201 = new();
					public Parameter PolymorphismTest_S_o1_method_a = new();
					public CallBehaviorAction PolymorphismTest_S_o1_method_Call_WriteLine = new();
						public OutputPin PolymorphismTest_S_o1_method_Call_WriteLine_errorStatus = new();
							public LiteralInteger PolymorphismTest_S_o1_method_Call_WriteLine_errorStatus_LiteralInteger202 = new();
							public LiteralUnlimitedNatural PolymorphismTest_S_o1_method_Call_WriteLine_errorStatus_LiteralUnlimitedNatural203 = new();
							public LiteralInteger PolymorphismTest_S_o1_method_Call_WriteLine_errorStatus_LiteralInteger204 = new();
						public InputPin PolymorphismTest_S_o1_method_Call_WriteLine_value = new();
							public LiteralInteger PolymorphismTest_S_o1_method_Call_WriteLine_value_LiteralInteger205 = new();
							public LiteralInteger PolymorphismTest_S_o1_method_Call_WriteLine_value_LiteralInteger206 = new();
							public LiteralUnlimitedNatural PolymorphismTest_S_o1_method_Call_WriteLine_value_LiteralUnlimitedNatural207 = new();
				public Activity PolymorphismTest_S_o3_method = new();
					public ObjectFlow PolymorphismTest_S_o3_method_ObjectFlow208 = new();
						public LiteralBoolean PolymorphismTest_S_o3_method_ObjectFlow208_LiteralBoolean209 = new();
						public LiteralInteger PolymorphismTest_S_o3_method_ObjectFlow208_LiteralInteger210 = new();
					public ValueSpecificationAction PolymorphismTest_S_o3_method_Message = new();
						public LiteralString PolymorphismTest_S_o3_method_Message_LiteralString211 = new();
						public OutputPin PolymorphismTest_S_o3_method_Message_result = new();
							public LiteralInteger PolymorphismTest_S_o3_method_Message_result_LiteralInteger212 = new();
							public LiteralUnlimitedNatural PolymorphismTest_S_o3_method_Message_result_LiteralUnlimitedNatural213 = new();
					public CallBehaviorAction PolymorphismTest_S_o3_method_Call_WriteLine = new();
						public InputPin PolymorphismTest_S_o3_method_Call_WriteLine_value = new();
							public LiteralInteger PolymorphismTest_S_o3_method_Call_WriteLine_value_LiteralInteger214 = new();
							public LiteralInteger PolymorphismTest_S_o3_method_Call_WriteLine_value_LiteralInteger215 = new();
							public LiteralUnlimitedNatural PolymorphismTest_S_o3_method_Call_WriteLine_value_LiteralUnlimitedNatural216 = new();
						public OutputPin PolymorphismTest_S_o3_method_Call_WriteLine_errorStatus = new();
							public LiteralInteger PolymorphismTest_S_o3_method_Call_WriteLine_errorStatus_LiteralInteger217 = new();
							public LiteralUnlimitedNatural PolymorphismTest_S_o3_method_Call_WriteLine_errorStatus_LiteralUnlimitedNatural218 = new();
							public LiteralInteger PolymorphismTest_S_o3_method_Call_WriteLine_errorStatus_LiteralInteger219 = new();
				public Activity PolymorphismTest_S_o5_method = new();
					public CallBehaviorAction PolymorphismTest_S_o5_method_Call_WriteLine = new();
						public OutputPin PolymorphismTest_S_o5_method_Call_WriteLine_errorStatus = new();
							public LiteralUnlimitedNatural PolymorphismTest_S_o5_method_Call_WriteLine_errorStatus_LiteralUnlimitedNatural220 = new();
							public LiteralInteger PolymorphismTest_S_o5_method_Call_WriteLine_errorStatus_LiteralInteger221 = new();
							public LiteralInteger PolymorphismTest_S_o5_method_Call_WriteLine_errorStatus_LiteralInteger222 = new();
						public InputPin PolymorphismTest_S_o5_method_Call_WriteLine_value = new();
							public LiteralInteger PolymorphismTest_S_o5_method_Call_WriteLine_value_LiteralInteger223 = new();
							public LiteralInteger PolymorphismTest_S_o5_method_Call_WriteLine_value_LiteralInteger224 = new();
							public LiteralUnlimitedNatural PolymorphismTest_S_o5_method_Call_WriteLine_value_LiteralUnlimitedNatural225 = new();
					public ValueSpecificationAction PolymorphismTest_S_o5_method_Message = new();
						public LiteralString PolymorphismTest_S_o5_method_Message_LiteralString226 = new();
						public OutputPin PolymorphismTest_S_o5_method_Message_result = new();
							public LiteralUnlimitedNatural PolymorphismTest_S_o5_method_Message_result_LiteralUnlimitedNatural227 = new();
							public LiteralInteger PolymorphismTest_S_o5_method_Message_result_LiteralInteger228 = new();
					public ObjectFlow PolymorphismTest_S_o5_method_ObjectFlow229 = new();
						public LiteralInteger PolymorphismTest_S_o5_method_ObjectFlow229_LiteralInteger230 = new();
						public LiteralBoolean PolymorphismTest_S_o5_method_ObjectFlow229_LiteralBoolean231 = new();
				public Operation PolymorphismTest_S_o5 = new();
				public Generalization PolymorphismTest_S_Generalization232 = new();
				public Activity PolymorphismTest_S_o2_method = new();
					public Parameter PolymorphismTest_S_o2_method_b = new();
					public ActivityParameterNode PolymorphismTest_S_o2_method_a_node = new();
						public LiteralInteger PolymorphismTest_S_o2_method_a_node_LiteralInteger233 = new();
					public Parameter PolymorphismTest_S_o2_method_a = new();
					public ValueSpecificationAction PolymorphismTest_S_o2_method_Message = new();
						public LiteralString PolymorphismTest_S_o2_method_Message_LiteralString234 = new();
						public OutputPin PolymorphismTest_S_o2_method_Message_result = new();
							public LiteralUnlimitedNatural PolymorphismTest_S_o2_method_Message_result_LiteralUnlimitedNatural235 = new();
							public LiteralInteger PolymorphismTest_S_o2_method_Message_result_LiteralInteger236 = new();
					public CallBehaviorAction PolymorphismTest_S_o2_method_Call_WriteLine = new();
						public OutputPin PolymorphismTest_S_o2_method_Call_WriteLine_errorStatus = new();
							public LiteralInteger PolymorphismTest_S_o2_method_Call_WriteLine_errorStatus_LiteralInteger237 = new();
							public LiteralUnlimitedNatural PolymorphismTest_S_o2_method_Call_WriteLine_errorStatus_LiteralUnlimitedNatural238 = new();
							public LiteralInteger PolymorphismTest_S_o2_method_Call_WriteLine_errorStatus_LiteralInteger239 = new();
						public InputPin PolymorphismTest_S_o2_method_Call_WriteLine_value = new();
							public LiteralInteger PolymorphismTest_S_o2_method_Call_WriteLine_value_LiteralInteger240 = new();
							public LiteralUnlimitedNatural PolymorphismTest_S_o2_method_Call_WriteLine_value_LiteralUnlimitedNatural241 = new();
							public LiteralInteger PolymorphismTest_S_o2_method_Call_WriteLine_value_LiteralInteger242 = new();
					public ActivityParameterNode PolymorphismTest_S_o2_method_b_node = new();
						public LiteralInteger PolymorphismTest_S_o2_method_b_node_LiteralInteger243 = new();
					public ObjectFlow PolymorphismTest_S_o2_method_ObjectFlow244 = new();
						public LiteralInteger PolymorphismTest_S_o2_method_ObjectFlow244_LiteralInteger245 = new();
						public LiteralBoolean PolymorphismTest_S_o2_method_ObjectFlow244_LiteralBoolean246 = new();
				public Operation PolymorphismTest_S_A_o1_B = new();
					public Parameter PolymorphismTest_S_A_o1_B_a = new();
					public Parameter PolymorphismTest_S_A_o1_B_b = new();
				public Operation PolymorphismTest_S_B_o2_A = new();
					public Parameter PolymorphismTest_S_B_o2_A_a = new();
					public Parameter PolymorphismTest_S_B_o2_A_b = new();
				public Operation PolymorphismTest_S_o3 = new();

		public static PolymorphismTestModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public PolymorphismTestModel()
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
			 * Model PolymorphismTest
			 */
			AddToElementRepository("PolymorphismTest", PolymorphismTest);
				AddToElementRepository("U", PolymorphismTest_U);
					AddToElementRepository("o4_method", PolymorphismTest_U_o4_method);
						AddToElementRepository("Call WriteLine", PolymorphismTest_U_o4_method_Call_WriteLine);
							AddToElementRepository("value", PolymorphismTest_U_o4_method_Call_WriteLine_value);
								AddToElementRepository("LiteralInteger0", PolymorphismTest_U_o4_method_Call_WriteLine_value_LiteralInteger0);
								AddToElementRepository("LiteralInteger1", PolymorphismTest_U_o4_method_Call_WriteLine_value_LiteralInteger1);
								AddToElementRepository("LiteralUnlimitedNatural2", PolymorphismTest_U_o4_method_Call_WriteLine_value_LiteralUnlimitedNatural2);
							AddToElementRepository("errorStatus", PolymorphismTest_U_o4_method_Call_WriteLine_errorStatus);
								AddToElementRepository("LiteralInteger3", PolymorphismTest_U_o4_method_Call_WriteLine_errorStatus_LiteralInteger3);
								AddToElementRepository("LiteralInteger4", PolymorphismTest_U_o4_method_Call_WriteLine_errorStatus_LiteralInteger4);
								AddToElementRepository("LiteralUnlimitedNatural5", PolymorphismTest_U_o4_method_Call_WriteLine_errorStatus_LiteralUnlimitedNatural5);
						AddToElementRepository("Message", PolymorphismTest_U_o4_method_Message);
							AddToElementRepository("LiteralString6", PolymorphismTest_U_o4_method_Message_LiteralString6);
							AddToElementRepository("result", PolymorphismTest_U_o4_method_Message_result);
								AddToElementRepository("LiteralInteger7", PolymorphismTest_U_o4_method_Message_result_LiteralInteger7);
								AddToElementRepository("LiteralUnlimitedNatural8", PolymorphismTest_U_o4_method_Message_result_LiteralUnlimitedNatural8);
						AddToElementRepository("ObjectFlow9", PolymorphismTest_U_o4_method_ObjectFlow9);
							AddToElementRepository("LiteralInteger10", PolymorphismTest_U_o4_method_ObjectFlow9_LiteralInteger10);
							AddToElementRepository("LiteralBoolean11", PolymorphismTest_U_o4_method_ObjectFlow9_LiteralBoolean11);
					AddToElementRepository("o2_method", PolymorphismTest_U_o2_method);
						AddToElementRepository("b_node", PolymorphismTest_U_o2_method_b_node);
							AddToElementRepository("LiteralInteger12", PolymorphismTest_U_o2_method_b_node_LiteralInteger12);
						AddToElementRepository("ObjectFlow13", PolymorphismTest_U_o2_method_ObjectFlow13);
							AddToElementRepository("LiteralInteger14", PolymorphismTest_U_o2_method_ObjectFlow13_LiteralInteger14);
							AddToElementRepository("LiteralBoolean15", PolymorphismTest_U_o2_method_ObjectFlow13_LiteralBoolean15);
						AddToElementRepository("Call WriteLine", PolymorphismTest_U_o2_method_Call_WriteLine);
							AddToElementRepository("value", PolymorphismTest_U_o2_method_Call_WriteLine_value);
								AddToElementRepository("LiteralInteger16", PolymorphismTest_U_o2_method_Call_WriteLine_value_LiteralInteger16);
								AddToElementRepository("LiteralInteger17", PolymorphismTest_U_o2_method_Call_WriteLine_value_LiteralInteger17);
								AddToElementRepository("LiteralUnlimitedNatural18", PolymorphismTest_U_o2_method_Call_WriteLine_value_LiteralUnlimitedNatural18);
							AddToElementRepository("errorStatus", PolymorphismTest_U_o2_method_Call_WriteLine_errorStatus);
								AddToElementRepository("LiteralInteger19", PolymorphismTest_U_o2_method_Call_WriteLine_errorStatus_LiteralInteger19);
								AddToElementRepository("LiteralInteger20", PolymorphismTest_U_o2_method_Call_WriteLine_errorStatus_LiteralInteger20);
								AddToElementRepository("LiteralUnlimitedNatural21", PolymorphismTest_U_o2_method_Call_WriteLine_errorStatus_LiteralUnlimitedNatural21);
						AddToElementRepository("b", PolymorphismTest_U_o2_method_b);
						AddToElementRepository("a", PolymorphismTest_U_o2_method_a);
						AddToElementRepository("Message", PolymorphismTest_U_o2_method_Message);
							AddToElementRepository("result", PolymorphismTest_U_o2_method_Message_result);
								AddToElementRepository("LiteralInteger22", PolymorphismTest_U_o2_method_Message_result_LiteralInteger22);
								AddToElementRepository("LiteralUnlimitedNatural23", PolymorphismTest_U_o2_method_Message_result_LiteralUnlimitedNatural23);
							AddToElementRepository("LiteralString24", PolymorphismTest_U_o2_method_Message_LiteralString24);
						AddToElementRepository("a_node", PolymorphismTest_U_o2_method_a_node);
							AddToElementRepository("LiteralInteger25", PolymorphismTest_U_o2_method_a_node_LiteralInteger25);
					AddToElementRepository("x", PolymorphismTest_U_x);
					AddToElementRepository("A_o1_B", PolymorphismTest_U_A_o1_B);
						AddToElementRepository("b", PolymorphismTest_U_A_o1_B_b);
						AddToElementRepository("a", PolymorphismTest_U_A_o1_B_a);
					AddToElementRepository("A_o2_B", PolymorphismTest_U_A_o2_B);
						AddToElementRepository("a", PolymorphismTest_U_A_o2_B_a);
						AddToElementRepository("b", PolymorphismTest_U_A_o2_B_b);
					AddToElementRepository("o4", PolymorphismTest_U_o4);
					AddToElementRepository("o3_Integer", PolymorphismTest_U_o3_Integer);
						AddToElementRepository("i", PolymorphismTest_U_o3_Integer_i);
					AddToElementRepository("o3_method", PolymorphismTest_U_o3_method);
						AddToElementRepository("i_node", PolymorphismTest_U_o3_method_i_node);
							AddToElementRepository("LiteralInteger26", PolymorphismTest_U_o3_method_i_node_LiteralInteger26);
						AddToElementRepository("Message", PolymorphismTest_U_o3_method_Message);
							AddToElementRepository("result", PolymorphismTest_U_o3_method_Message_result);
								AddToElementRepository("LiteralInteger27", PolymorphismTest_U_o3_method_Message_result_LiteralInteger27);
								AddToElementRepository("LiteralUnlimitedNatural28", PolymorphismTest_U_o3_method_Message_result_LiteralUnlimitedNatural28);
							AddToElementRepository("LiteralString29", PolymorphismTest_U_o3_method_Message_LiteralString29);
						AddToElementRepository("Call WriteLine", PolymorphismTest_U_o3_method_Call_WriteLine);
							AddToElementRepository("value", PolymorphismTest_U_o3_method_Call_WriteLine_value);
								AddToElementRepository("LiteralUnlimitedNatural30", PolymorphismTest_U_o3_method_Call_WriteLine_value_LiteralUnlimitedNatural30);
								AddToElementRepository("LiteralInteger31", PolymorphismTest_U_o3_method_Call_WriteLine_value_LiteralInteger31);
								AddToElementRepository("LiteralInteger32", PolymorphismTest_U_o3_method_Call_WriteLine_value_LiteralInteger32);
							AddToElementRepository("errorStatus", PolymorphismTest_U_o3_method_Call_WriteLine_errorStatus);
								AddToElementRepository("LiteralInteger33", PolymorphismTest_U_o3_method_Call_WriteLine_errorStatus_LiteralInteger33);
								AddToElementRepository("LiteralInteger34", PolymorphismTest_U_o3_method_Call_WriteLine_errorStatus_LiteralInteger34);
								AddToElementRepository("LiteralUnlimitedNatural35", PolymorphismTest_U_o3_method_Call_WriteLine_errorStatus_LiteralUnlimitedNatural35);
						AddToElementRepository("i", PolymorphismTest_U_o3_method_i);
						AddToElementRepository("ObjectFlow36", PolymorphismTest_U_o3_method_ObjectFlow36);
							AddToElementRepository("LiteralInteger37", PolymorphismTest_U_o3_method_ObjectFlow36_LiteralInteger37);
							AddToElementRepository("LiteralBoolean38", PolymorphismTest_U_o3_method_ObjectFlow36_LiteralBoolean38);
					AddToElementRepository("x_method", PolymorphismTest_U_x_method);
						AddToElementRepository("Call WriteLine", PolymorphismTest_U_x_method_Call_WriteLine);
							AddToElementRepository("errorStatus", PolymorphismTest_U_x_method_Call_WriteLine_errorStatus);
								AddToElementRepository("LiteralInteger39", PolymorphismTest_U_x_method_Call_WriteLine_errorStatus_LiteralInteger39);
								AddToElementRepository("LiteralInteger40", PolymorphismTest_U_x_method_Call_WriteLine_errorStatus_LiteralInteger40);
								AddToElementRepository("LiteralUnlimitedNatural41", PolymorphismTest_U_x_method_Call_WriteLine_errorStatus_LiteralUnlimitedNatural41);
							AddToElementRepository("value", PolymorphismTest_U_x_method_Call_WriteLine_value);
								AddToElementRepository("LiteralInteger42", PolymorphismTest_U_x_method_Call_WriteLine_value_LiteralInteger42);
								AddToElementRepository("LiteralInteger43", PolymorphismTest_U_x_method_Call_WriteLine_value_LiteralInteger43);
								AddToElementRepository("LiteralUnlimitedNatural44", PolymorphismTest_U_x_method_Call_WriteLine_value_LiteralUnlimitedNatural44);
						AddToElementRepository("ObjectFlow45", PolymorphismTest_U_x_method_ObjectFlow45);
							AddToElementRepository("LiteralBoolean46", PolymorphismTest_U_x_method_ObjectFlow45_LiteralBoolean46);
							AddToElementRepository("LiteralInteger47", PolymorphismTest_U_x_method_ObjectFlow45_LiteralInteger47);
						AddToElementRepository("Message", PolymorphismTest_U_x_method_Message);
							AddToElementRepository("LiteralString48", PolymorphismTest_U_x_method_Message_LiteralString48);
							AddToElementRepository("result", PolymorphismTest_U_x_method_Message_result);
								AddToElementRepository("LiteralInteger49", PolymorphismTest_U_x_method_Message_result_LiteralInteger49);
								AddToElementRepository("LiteralUnlimitedNatural50", PolymorphismTest_U_x_method_Message_result_LiteralUnlimitedNatural50);
					AddToElementRepository("o1_method", PolymorphismTest_U_o1_method);
						AddToElementRepository("b", PolymorphismTest_U_o1_method_b);
						AddToElementRepository("Message", PolymorphismTest_U_o1_method_Message);
							AddToElementRepository("result", PolymorphismTest_U_o1_method_Message_result);
								AddToElementRepository("LiteralInteger51", PolymorphismTest_U_o1_method_Message_result_LiteralInteger51);
								AddToElementRepository("LiteralUnlimitedNatural52", PolymorphismTest_U_o1_method_Message_result_LiteralUnlimitedNatural52);
							AddToElementRepository("LiteralString53", PolymorphismTest_U_o1_method_Message_LiteralString53);
						AddToElementRepository("a", PolymorphismTest_U_o1_method_a);
						AddToElementRepository("Call WriteLine", PolymorphismTest_U_o1_method_Call_WriteLine);
							AddToElementRepository("value", PolymorphismTest_U_o1_method_Call_WriteLine_value);
								AddToElementRepository("LiteralUnlimitedNatural54", PolymorphismTest_U_o1_method_Call_WriteLine_value_LiteralUnlimitedNatural54);
								AddToElementRepository("LiteralInteger55", PolymorphismTest_U_o1_method_Call_WriteLine_value_LiteralInteger55);
								AddToElementRepository("LiteralInteger56", PolymorphismTest_U_o1_method_Call_WriteLine_value_LiteralInteger56);
							AddToElementRepository("errorStatus", PolymorphismTest_U_o1_method_Call_WriteLine_errorStatus);
								AddToElementRepository("LiteralUnlimitedNatural57", PolymorphismTest_U_o1_method_Call_WriteLine_errorStatus_LiteralUnlimitedNatural57);
								AddToElementRepository("LiteralInteger58", PolymorphismTest_U_o1_method_Call_WriteLine_errorStatus_LiteralInteger58);
								AddToElementRepository("LiteralInteger59", PolymorphismTest_U_o1_method_Call_WriteLine_errorStatus_LiteralInteger59);
						AddToElementRepository("b_node", PolymorphismTest_U_o1_method_b_node);
							AddToElementRepository("LiteralInteger60", PolymorphismTest_U_o1_method_b_node_LiteralInteger60);
						AddToElementRepository("a_node", PolymorphismTest_U_o1_method_a_node);
							AddToElementRepository("LiteralInteger61", PolymorphismTest_U_o1_method_a_node_LiteralInteger61);
						AddToElementRepository("ObjectFlow62", PolymorphismTest_U_o1_method_ObjectFlow62);
							AddToElementRepository("LiteralInteger63", PolymorphismTest_U_o1_method_ObjectFlow62_LiteralInteger63);
							AddToElementRepository("LiteralBoolean64", PolymorphismTest_U_o1_method_ObjectFlow62_LiteralBoolean64);
				AddToElementRepository("B", PolymorphismTest_B);
					AddToElementRepository("Generalization65", PolymorphismTest_B_Generalization65);
				AddToElementRepository("A", PolymorphismTest_A);
					AddToElementRepository("x_method", PolymorphismTest_A_x_method);
						AddToElementRepository("Call WriteLine", PolymorphismTest_A_x_method_Call_WriteLine);
							AddToElementRepository("value", PolymorphismTest_A_x_method_Call_WriteLine_value);
								AddToElementRepository("LiteralUnlimitedNatural66", PolymorphismTest_A_x_method_Call_WriteLine_value_LiteralUnlimitedNatural66);
								AddToElementRepository("LiteralInteger67", PolymorphismTest_A_x_method_Call_WriteLine_value_LiteralInteger67);
								AddToElementRepository("LiteralInteger68", PolymorphismTest_A_x_method_Call_WriteLine_value_LiteralInteger68);
							AddToElementRepository("errorStatus", PolymorphismTest_A_x_method_Call_WriteLine_errorStatus);
								AddToElementRepository("LiteralInteger69", PolymorphismTest_A_x_method_Call_WriteLine_errorStatus_LiteralInteger69);
								AddToElementRepository("LiteralUnlimitedNatural70", PolymorphismTest_A_x_method_Call_WriteLine_errorStatus_LiteralUnlimitedNatural70);
								AddToElementRepository("LiteralInteger71", PolymorphismTest_A_x_method_Call_WriteLine_errorStatus_LiteralInteger71);
						AddToElementRepository("Message", PolymorphismTest_A_x_method_Message);
							AddToElementRepository("LiteralString72", PolymorphismTest_A_x_method_Message_LiteralString72);
							AddToElementRepository("result", PolymorphismTest_A_x_method_Message_result);
								AddToElementRepository("LiteralUnlimitedNatural73", PolymorphismTest_A_x_method_Message_result_LiteralUnlimitedNatural73);
								AddToElementRepository("LiteralInteger74", PolymorphismTest_A_x_method_Message_result_LiteralInteger74);
						AddToElementRepository("ObjectFlow75", PolymorphismTest_A_x_method_ObjectFlow75);
							AddToElementRepository("LiteralBoolean76", PolymorphismTest_A_x_method_ObjectFlow75_LiteralBoolean76);
							AddToElementRepository("LiteralInteger77", PolymorphismTest_A_x_method_ObjectFlow75_LiteralInteger77);
					AddToElementRepository("x", PolymorphismTest_A_x);
				AddToElementRepository("main", PolymorphismTest_main);
					AddToElementRepository("Call runTests", PolymorphismTest_main_Call_runTests);
						AddToElementRepository("u", PolymorphismTest_main_Call_runTests_u);
							AddToElementRepository("LiteralInteger78", PolymorphismTest_main_Call_runTests_u_LiteralInteger78);
							AddToElementRepository("LiteralUnlimitedNatural79", PolymorphismTest_main_Call_runTests_u_LiteralUnlimitedNatural79);
							AddToElementRepository("LiteralInteger80", PolymorphismTest_main_Call_runTests_u_LiteralInteger80);
					AddToElementRepository("runTests", PolymorphismTest_main_runTests);
						AddToElementRepository("ObjectFlow81", PolymorphismTest_main_runTests_ObjectFlow81);
							AddToElementRepository("LiteralBoolean82", PolymorphismTest_main_runTests_ObjectFlow81_LiteralBoolean82);
							AddToElementRepository("LiteralInteger83", PolymorphismTest_main_runTests_ObjectFlow81_LiteralInteger83);
						AddToElementRepository("ControlFlow84", PolymorphismTest_main_runTests_ControlFlow84);
						AddToElementRepository("Call o3()", PolymorphismTest_main_runTests_Call_o3_);
							AddToElementRepository("target", PolymorphismTest_main_runTests_Call_o3__target);
								AddToElementRepository("LiteralUnlimitedNatural85", PolymorphismTest_main_runTests_Call_o3__target_LiteralUnlimitedNatural85);
								AddToElementRepository("LiteralInteger86", PolymorphismTest_main_runTests_Call_o3__target_LiteralInteger86);
							AddToElementRepository("i", PolymorphismTest_main_runTests_Call_o3__i);
								AddToElementRepository("LiteralInteger87", PolymorphismTest_main_runTests_Call_o3__i_LiteralInteger87);
								AddToElementRepository("LiteralInteger88", PolymorphismTest_main_runTests_Call_o3__i_LiteralInteger88);
						AddToElementRepository("Call A::x()", PolymorphismTest_main_runTests_Call_A_x_);
							AddToElementRepository("target", PolymorphismTest_main_runTests_Call_A_x__target);
								AddToElementRepository("LiteralInteger89", PolymorphismTest_main_runTests_Call_A_x__target_LiteralInteger89);
								AddToElementRepository("LiteralUnlimitedNatural90", PolymorphismTest_main_runTests_Call_A_x__target_LiteralUnlimitedNatural90);
						AddToElementRepository("Call U::o1()", PolymorphismTest_main_runTests_Call_U_o1_);
							AddToElementRepository("target", PolymorphismTest_main_runTests_Call_U_o1__target);
							AddToElementRepository("b", PolymorphismTest_main_runTests_Call_U_o1__b);
								AddToElementRepository("LiteralInteger91", PolymorphismTest_main_runTests_Call_U_o1__b_LiteralInteger91);
								AddToElementRepository("LiteralInteger92", PolymorphismTest_main_runTests_Call_U_o1__b_LiteralInteger92);
							AddToElementRepository("a", PolymorphismTest_main_runTests_Call_U_o1__a);
								AddToElementRepository("LiteralUnlimitedNatural93", PolymorphismTest_main_runTests_Call_U_o1__a_LiteralUnlimitedNatural93);
								AddToElementRepository("LiteralInteger94", PolymorphismTest_main_runTests_Call_U_o1__a_LiteralInteger94);
								AddToElementRepository("LiteralInteger95", PolymorphismTest_main_runTests_Call_U_o1__a_LiteralInteger95);
						AddToElementRepository("ObjectFlow96", PolymorphismTest_main_runTests_ObjectFlow96);
							AddToElementRepository("LiteralBoolean97", PolymorphismTest_main_runTests_ObjectFlow96_LiteralBoolean97);
							AddToElementRepository("LiteralInteger98", PolymorphismTest_main_runTests_ObjectFlow96_LiteralInteger98);
						AddToElementRepository("Call o4()", PolymorphismTest_main_runTests_Call_o4_);
							AddToElementRepository("target", PolymorphismTest_main_runTests_Call_o4__target);
								AddToElementRepository("LiteralInteger99", PolymorphismTest_main_runTests_Call_o4__target_LiteralInteger99);
								AddToElementRepository("LiteralUnlimitedNatural100", PolymorphismTest_main_runTests_Call_o4__target_LiteralUnlimitedNatural100);
						AddToElementRepository("ObjectFlow101", PolymorphismTest_main_runTests_ObjectFlow101);
							AddToElementRepository("LiteralBoolean102", PolymorphismTest_main_runTests_ObjectFlow101_LiteralBoolean102);
							AddToElementRepository("LiteralInteger103", PolymorphismTest_main_runTests_ObjectFlow101_LiteralInteger103);
						AddToElementRepository("u", PolymorphismTest_main_runTests_u);
						AddToElementRepository("ObjectFlow104", PolymorphismTest_main_runTests_ObjectFlow104);
							AddToElementRepository("LiteralInteger105", PolymorphismTest_main_runTests_ObjectFlow104_LiteralInteger105);
							AddToElementRepository("LiteralBoolean106", PolymorphismTest_main_runTests_ObjectFlow104_LiteralBoolean106);
						AddToElementRepository("ObjectFlow107", PolymorphismTest_main_runTests_ObjectFlow107);
							AddToElementRepository("LiteralInteger108", PolymorphismTest_main_runTests_ObjectFlow107_LiteralInteger108);
							AddToElementRepository("LiteralBoolean109", PolymorphismTest_main_runTests_ObjectFlow107_LiteralBoolean109);
						AddToElementRepository("ControlFlow110", PolymorphismTest_main_runTests_ControlFlow110);
						AddToElementRepository("u_node", PolymorphismTest_main_runTests_u_node);
							AddToElementRepository("LiteralInteger111", PolymorphismTest_main_runTests_u_node_LiteralInteger111);
						AddToElementRepository("ControlFlow112", PolymorphismTest_main_runTests_ControlFlow112);
						AddToElementRepository("Fork u", PolymorphismTest_main_runTests_Fork_u);
						AddToElementRepository("Call o2()", PolymorphismTest_main_runTests_Call_o2_);
							AddToElementRepository("a", PolymorphismTest_main_runTests_Call_o2__a);
								AddToElementRepository("LiteralInteger113", PolymorphismTest_main_runTests_Call_o2__a_LiteralInteger113);
								AddToElementRepository("LiteralUnlimitedNatural114", PolymorphismTest_main_runTests_Call_o2__a_LiteralUnlimitedNatural114);
								AddToElementRepository("LiteralInteger115", PolymorphismTest_main_runTests_Call_o2__a_LiteralInteger115);
							AddToElementRepository("target", PolymorphismTest_main_runTests_Call_o2__target);
								AddToElementRepository("LiteralUnlimitedNatural116", PolymorphismTest_main_runTests_Call_o2__target_LiteralUnlimitedNatural116);
								AddToElementRepository("LiteralInteger117", PolymorphismTest_main_runTests_Call_o2__target_LiteralInteger117);
							AddToElementRepository("b", PolymorphismTest_main_runTests_Call_o2__b);
								AddToElementRepository("LiteralInteger118", PolymorphismTest_main_runTests_Call_o2__b_LiteralInteger118);
								AddToElementRepository("LiteralInteger119", PolymorphismTest_main_runTests_Call_o2__b_LiteralInteger119);
						AddToElementRepository("ObjectFlow120", PolymorphismTest_main_runTests_ObjectFlow120);
							AddToElementRepository("LiteralBoolean121", PolymorphismTest_main_runTests_ObjectFlow120_LiteralBoolean121);
							AddToElementRepository("LiteralInteger122", PolymorphismTest_main_runTests_ObjectFlow120_LiteralInteger122);
						AddToElementRepository("ObjectFlow123", PolymorphismTest_main_runTests_ObjectFlow123);
							AddToElementRepository("LiteralBoolean124", PolymorphismTest_main_runTests_ObjectFlow123_LiteralBoolean124);
							AddToElementRepository("LiteralInteger125", PolymorphismTest_main_runTests_ObjectFlow123_LiteralInteger125);
						AddToElementRepository("ControlFlow126", PolymorphismTest_main_runTests_ControlFlow126);
						AddToElementRepository("ControlFlow127", PolymorphismTest_main_runTests_ControlFlow127);
						AddToElementRepository("Call o1()", PolymorphismTest_main_runTests_Call_o1_);
							AddToElementRepository("target", PolymorphismTest_main_runTests_Call_o1__target);
								AddToElementRepository("LiteralUnlimitedNatural128", PolymorphismTest_main_runTests_Call_o1__target_LiteralUnlimitedNatural128);
								AddToElementRepository("LiteralInteger129", PolymorphismTest_main_runTests_Call_o1__target_LiteralInteger129);
							AddToElementRepository("b", PolymorphismTest_main_runTests_Call_o1__b);
								AddToElementRepository("LiteralInteger130", PolymorphismTest_main_runTests_Call_o1__b_LiteralInteger130);
								AddToElementRepository("LiteralInteger131", PolymorphismTest_main_runTests_Call_o1__b_LiteralInteger131);
							AddToElementRepository("a", PolymorphismTest_main_runTests_Call_o1__a);
								AddToElementRepository("LiteralInteger132", PolymorphismTest_main_runTests_Call_o1__a_LiteralInteger132);
								AddToElementRepository("LiteralUnlimitedNatural133", PolymorphismTest_main_runTests_Call_o1__a_LiteralUnlimitedNatural133);
								AddToElementRepository("LiteralInteger134", PolymorphismTest_main_runTests_Call_o1__a_LiteralInteger134);
					AddToElementRepository("Create S", PolymorphismTest_main_Create_S);
						AddToElementRepository("result", PolymorphismTest_main_Create_S_result);
							AddToElementRepository("LiteralInteger135", PolymorphismTest_main_Create_S_result_LiteralInteger135);
							AddToElementRepository("LiteralUnlimitedNatural136", PolymorphismTest_main_Create_S_result_LiteralUnlimitedNatural136);
					AddToElementRepository("ObjectFlow137", PolymorphismTest_main_ObjectFlow137);
						AddToElementRepository("LiteralBoolean138", PolymorphismTest_main_ObjectFlow137_LiteralBoolean138);
						AddToElementRepository("LiteralInteger139", PolymorphismTest_main_ObjectFlow137_LiteralInteger139);
				AddToElementRepository("T", PolymorphismTest_T);
					AddToElementRepository("o4_method", PolymorphismTest_T_o4_method);
						AddToElementRepository("Message", PolymorphismTest_T_o4_method_Message);
							AddToElementRepository("result", PolymorphismTest_T_o4_method_Message_result);
								AddToElementRepository("LiteralInteger140", PolymorphismTest_T_o4_method_Message_result_LiteralInteger140);
								AddToElementRepository("LiteralUnlimitedNatural141", PolymorphismTest_T_o4_method_Message_result_LiteralUnlimitedNatural141);
							AddToElementRepository("LiteralString142", PolymorphismTest_T_o4_method_Message_LiteralString142);
						AddToElementRepository("Call WriteLine", PolymorphismTest_T_o4_method_Call_WriteLine);
							AddToElementRepository("errorStatus", PolymorphismTest_T_o4_method_Call_WriteLine_errorStatus);
								AddToElementRepository("LiteralInteger143", PolymorphismTest_T_o4_method_Call_WriteLine_errorStatus_LiteralInteger143);
								AddToElementRepository("LiteralInteger144", PolymorphismTest_T_o4_method_Call_WriteLine_errorStatus_LiteralInteger144);
								AddToElementRepository("LiteralUnlimitedNatural145", PolymorphismTest_T_o4_method_Call_WriteLine_errorStatus_LiteralUnlimitedNatural145);
							AddToElementRepository("value", PolymorphismTest_T_o4_method_Call_WriteLine_value);
								AddToElementRepository("LiteralInteger146", PolymorphismTest_T_o4_method_Call_WriteLine_value_LiteralInteger146);
								AddToElementRepository("LiteralUnlimitedNatural147", PolymorphismTest_T_o4_method_Call_WriteLine_value_LiteralUnlimitedNatural147);
								AddToElementRepository("LiteralInteger148", PolymorphismTest_T_o4_method_Call_WriteLine_value_LiteralInteger148);
						AddToElementRepository("ObjectFlow149", PolymorphismTest_T_o4_method_ObjectFlow149);
							AddToElementRepository("LiteralBoolean150", PolymorphismTest_T_o4_method_ObjectFlow149_LiteralBoolean150);
							AddToElementRepository("LiteralInteger151", PolymorphismTest_T_o4_method_ObjectFlow149_LiteralInteger151);
					AddToElementRepository("o3_Integer", PolymorphismTest_T_o3_Integer);
						AddToElementRepository("i", PolymorphismTest_T_o3_Integer_i);
					AddToElementRepository("o1_method", PolymorphismTest_T_o1_method);
						AddToElementRepository("Message", PolymorphismTest_T_o1_method_Message);
							AddToElementRepository("LiteralString152", PolymorphismTest_T_o1_method_Message_LiteralString152);
							AddToElementRepository("result", PolymorphismTest_T_o1_method_Message_result);
								AddToElementRepository("LiteralUnlimitedNatural153", PolymorphismTest_T_o1_method_Message_result_LiteralUnlimitedNatural153);
								AddToElementRepository("LiteralInteger154", PolymorphismTest_T_o1_method_Message_result_LiteralInteger154);
						AddToElementRepository("Call WriteLine", PolymorphismTest_T_o1_method_Call_WriteLine);
							AddToElementRepository("errorStatus", PolymorphismTest_T_o1_method_Call_WriteLine_errorStatus);
								AddToElementRepository("LiteralInteger155", PolymorphismTest_T_o1_method_Call_WriteLine_errorStatus_LiteralInteger155);
								AddToElementRepository("LiteralInteger156", PolymorphismTest_T_o1_method_Call_WriteLine_errorStatus_LiteralInteger156);
								AddToElementRepository("LiteralUnlimitedNatural157", PolymorphismTest_T_o1_method_Call_WriteLine_errorStatus_LiteralUnlimitedNatural157);
							AddToElementRepository("value", PolymorphismTest_T_o1_method_Call_WriteLine_value);
								AddToElementRepository("LiteralInteger158", PolymorphismTest_T_o1_method_Call_WriteLine_value_LiteralInteger158);
								AddToElementRepository("LiteralUnlimitedNatural159", PolymorphismTest_T_o1_method_Call_WriteLine_value_LiteralUnlimitedNatural159);
								AddToElementRepository("LiteralInteger160", PolymorphismTest_T_o1_method_Call_WriteLine_value_LiteralInteger160);
						AddToElementRepository("b_node", PolymorphismTest_T_o1_method_b_node);
							AddToElementRepository("LiteralInteger161", PolymorphismTest_T_o1_method_b_node_LiteralInteger161);
						AddToElementRepository("a", PolymorphismTest_T_o1_method_a);
						AddToElementRepository("a_node", PolymorphismTest_T_o1_method_a_node);
							AddToElementRepository("LiteralInteger162", PolymorphismTest_T_o1_method_a_node_LiteralInteger162);
						AddToElementRepository("ObjectFlow163", PolymorphismTest_T_o1_method_ObjectFlow163);
							AddToElementRepository("LiteralBoolean164", PolymorphismTest_T_o1_method_ObjectFlow163_LiteralBoolean164);
							AddToElementRepository("LiteralInteger165", PolymorphismTest_T_o1_method_ObjectFlow163_LiteralInteger165);
						AddToElementRepository("b", PolymorphismTest_T_o1_method_b);
					AddToElementRepository("o3_method", PolymorphismTest_T_o3_method);
						AddToElementRepository("ObjectFlow166", PolymorphismTest_T_o3_method_ObjectFlow166);
							AddToElementRepository("LiteralInteger167", PolymorphismTest_T_o3_method_ObjectFlow166_LiteralInteger167);
							AddToElementRepository("LiteralBoolean168", PolymorphismTest_T_o3_method_ObjectFlow166_LiteralBoolean168);
						AddToElementRepository("Call WriteLine", PolymorphismTest_T_o3_method_Call_WriteLine);
							AddToElementRepository("errorStatus", PolymorphismTest_T_o3_method_Call_WriteLine_errorStatus);
								AddToElementRepository("LiteralUnlimitedNatural169", PolymorphismTest_T_o3_method_Call_WriteLine_errorStatus_LiteralUnlimitedNatural169);
								AddToElementRepository("LiteralInteger170", PolymorphismTest_T_o3_method_Call_WriteLine_errorStatus_LiteralInteger170);
								AddToElementRepository("LiteralInteger171", PolymorphismTest_T_o3_method_Call_WriteLine_errorStatus_LiteralInteger171);
							AddToElementRepository("value", PolymorphismTest_T_o3_method_Call_WriteLine_value);
								AddToElementRepository("LiteralInteger172", PolymorphismTest_T_o3_method_Call_WriteLine_value_LiteralInteger172);
								AddToElementRepository("LiteralUnlimitedNatural173", PolymorphismTest_T_o3_method_Call_WriteLine_value_LiteralUnlimitedNatural173);
								AddToElementRepository("LiteralInteger174", PolymorphismTest_T_o3_method_Call_WriteLine_value_LiteralInteger174);
						AddToElementRepository("i", PolymorphismTest_T_o3_method_i);
						AddToElementRepository("i_node", PolymorphismTest_T_o3_method_i_node);
							AddToElementRepository("LiteralInteger175", PolymorphismTest_T_o3_method_i_node_LiteralInteger175);
						AddToElementRepository("Message", PolymorphismTest_T_o3_method_Message);
							AddToElementRepository("result", PolymorphismTest_T_o3_method_Message_result);
								AddToElementRepository("LiteralUnlimitedNatural176", PolymorphismTest_T_o3_method_Message_result_LiteralUnlimitedNatural176);
								AddToElementRepository("LiteralInteger177", PolymorphismTest_T_o3_method_Message_result_LiteralInteger177);
							AddToElementRepository("LiteralString178", PolymorphismTest_T_o3_method_Message_LiteralString178);
					AddToElementRepository("o4", PolymorphismTest_T_o4);
					AddToElementRepository("Generalization179", PolymorphismTest_T_Generalization179);
					AddToElementRepository("o2_method", PolymorphismTest_T_o2_method);
						AddToElementRepository("b", PolymorphismTest_T_o2_method_b);
						AddToElementRepository("ObjectFlow180", PolymorphismTest_T_o2_method_ObjectFlow180);
							AddToElementRepository("LiteralInteger181", PolymorphismTest_T_o2_method_ObjectFlow180_LiteralInteger181);
							AddToElementRepository("LiteralBoolean182", PolymorphismTest_T_o2_method_ObjectFlow180_LiteralBoolean182);
						AddToElementRepository("Call WriteLine", PolymorphismTest_T_o2_method_Call_WriteLine);
							AddToElementRepository("value", PolymorphismTest_T_o2_method_Call_WriteLine_value);
								AddToElementRepository("LiteralInteger183", PolymorphismTest_T_o2_method_Call_WriteLine_value_LiteralInteger183);
								AddToElementRepository("LiteralInteger184", PolymorphismTest_T_o2_method_Call_WriteLine_value_LiteralInteger184);
								AddToElementRepository("LiteralUnlimitedNatural185", PolymorphismTest_T_o2_method_Call_WriteLine_value_LiteralUnlimitedNatural185);
							AddToElementRepository("errorStatus", PolymorphismTest_T_o2_method_Call_WriteLine_errorStatus);
								AddToElementRepository("LiteralUnlimitedNatural186", PolymorphismTest_T_o2_method_Call_WriteLine_errorStatus_LiteralUnlimitedNatural186);
								AddToElementRepository("LiteralInteger187", PolymorphismTest_T_o2_method_Call_WriteLine_errorStatus_LiteralInteger187);
								AddToElementRepository("LiteralInteger188", PolymorphismTest_T_o2_method_Call_WriteLine_errorStatus_LiteralInteger188);
						AddToElementRepository("result", PolymorphismTest_T_o2_method_result);
						AddToElementRepository("Message", PolymorphismTest_T_o2_method_Message);
							AddToElementRepository("result", PolymorphismTest_T_o2_method_Message_result);
								AddToElementRepository("LiteralInteger189", PolymorphismTest_T_o2_method_Message_result_LiteralInteger189);
								AddToElementRepository("LiteralUnlimitedNatural190", PolymorphismTest_T_o2_method_Message_result_LiteralUnlimitedNatural190);
							AddToElementRepository("LiteralString191", PolymorphismTest_T_o2_method_Message_LiteralString191);
						AddToElementRepository("b_node", PolymorphismTest_T_o2_method_b_node);
							AddToElementRepository("LiteralInteger192", PolymorphismTest_T_o2_method_b_node_LiteralInteger192);
						AddToElementRepository("result_node", PolymorphismTest_T_o2_method_result_node);
							AddToElementRepository("LiteralInteger193", PolymorphismTest_T_o2_method_result_node_LiteralInteger193);
					AddToElementRepository("B_o2_B", PolymorphismTest_T_B_o2_B);
						AddToElementRepository("result", PolymorphismTest_T_B_o2_B_result);
						AddToElementRepository("b", PolymorphismTest_T_B_o2_B_b);
					AddToElementRepository("A_o1_B", PolymorphismTest_T_A_o1_B);
						AddToElementRepository("b", PolymorphismTest_T_A_o1_B_b);
						AddToElementRepository("a", PolymorphismTest_T_A_o1_B_a);
				AddToElementRepository("S", PolymorphismTest_S);
					AddToElementRepository("o1_method", PolymorphismTest_S_o1_method);
						AddToElementRepository("b", PolymorphismTest_S_o1_method_b);
						AddToElementRepository("ObjectFlow194", PolymorphismTest_S_o1_method_ObjectFlow194);
							AddToElementRepository("LiteralInteger195", PolymorphismTest_S_o1_method_ObjectFlow194_LiteralInteger195);
							AddToElementRepository("LiteralBoolean196", PolymorphismTest_S_o1_method_ObjectFlow194_LiteralBoolean196);
						AddToElementRepository("a_node", PolymorphismTest_S_o1_method_a_node);
							AddToElementRepository("LiteralInteger197", PolymorphismTest_S_o1_method_a_node_LiteralInteger197);
						AddToElementRepository("Message", PolymorphismTest_S_o1_method_Message);
							AddToElementRepository("result", PolymorphismTest_S_o1_method_Message_result);
								AddToElementRepository("LiteralInteger198", PolymorphismTest_S_o1_method_Message_result_LiteralInteger198);
								AddToElementRepository("LiteralUnlimitedNatural199", PolymorphismTest_S_o1_method_Message_result_LiteralUnlimitedNatural199);
							AddToElementRepository("LiteralString200", PolymorphismTest_S_o1_method_Message_LiteralString200);
						AddToElementRepository("b_node", PolymorphismTest_S_o1_method_b_node);
							AddToElementRepository("LiteralInteger201", PolymorphismTest_S_o1_method_b_node_LiteralInteger201);
						AddToElementRepository("a", PolymorphismTest_S_o1_method_a);
						AddToElementRepository("Call WriteLine", PolymorphismTest_S_o1_method_Call_WriteLine);
							AddToElementRepository("errorStatus", PolymorphismTest_S_o1_method_Call_WriteLine_errorStatus);
								AddToElementRepository("LiteralInteger202", PolymorphismTest_S_o1_method_Call_WriteLine_errorStatus_LiteralInteger202);
								AddToElementRepository("LiteralUnlimitedNatural203", PolymorphismTest_S_o1_method_Call_WriteLine_errorStatus_LiteralUnlimitedNatural203);
								AddToElementRepository("LiteralInteger204", PolymorphismTest_S_o1_method_Call_WriteLine_errorStatus_LiteralInteger204);
							AddToElementRepository("value", PolymorphismTest_S_o1_method_Call_WriteLine_value);
								AddToElementRepository("LiteralInteger205", PolymorphismTest_S_o1_method_Call_WriteLine_value_LiteralInteger205);
								AddToElementRepository("LiteralInteger206", PolymorphismTest_S_o1_method_Call_WriteLine_value_LiteralInteger206);
								AddToElementRepository("LiteralUnlimitedNatural207", PolymorphismTest_S_o1_method_Call_WriteLine_value_LiteralUnlimitedNatural207);
					AddToElementRepository("o3_method", PolymorphismTest_S_o3_method);
						AddToElementRepository("ObjectFlow208", PolymorphismTest_S_o3_method_ObjectFlow208);
							AddToElementRepository("LiteralBoolean209", PolymorphismTest_S_o3_method_ObjectFlow208_LiteralBoolean209);
							AddToElementRepository("LiteralInteger210", PolymorphismTest_S_o3_method_ObjectFlow208_LiteralInteger210);
						AddToElementRepository("Message", PolymorphismTest_S_o3_method_Message);
							AddToElementRepository("LiteralString211", PolymorphismTest_S_o3_method_Message_LiteralString211);
							AddToElementRepository("result", PolymorphismTest_S_o3_method_Message_result);
								AddToElementRepository("LiteralInteger212", PolymorphismTest_S_o3_method_Message_result_LiteralInteger212);
								AddToElementRepository("LiteralUnlimitedNatural213", PolymorphismTest_S_o3_method_Message_result_LiteralUnlimitedNatural213);
						AddToElementRepository("Call WriteLine", PolymorphismTest_S_o3_method_Call_WriteLine);
							AddToElementRepository("value", PolymorphismTest_S_o3_method_Call_WriteLine_value);
								AddToElementRepository("LiteralInteger214", PolymorphismTest_S_o3_method_Call_WriteLine_value_LiteralInteger214);
								AddToElementRepository("LiteralInteger215", PolymorphismTest_S_o3_method_Call_WriteLine_value_LiteralInteger215);
								AddToElementRepository("LiteralUnlimitedNatural216", PolymorphismTest_S_o3_method_Call_WriteLine_value_LiteralUnlimitedNatural216);
							AddToElementRepository("errorStatus", PolymorphismTest_S_o3_method_Call_WriteLine_errorStatus);
								AddToElementRepository("LiteralInteger217", PolymorphismTest_S_o3_method_Call_WriteLine_errorStatus_LiteralInteger217);
								AddToElementRepository("LiteralUnlimitedNatural218", PolymorphismTest_S_o3_method_Call_WriteLine_errorStatus_LiteralUnlimitedNatural218);
								AddToElementRepository("LiteralInteger219", PolymorphismTest_S_o3_method_Call_WriteLine_errorStatus_LiteralInteger219);
					AddToElementRepository("o5_method", PolymorphismTest_S_o5_method);
						AddToElementRepository("Call WriteLine", PolymorphismTest_S_o5_method_Call_WriteLine);
							AddToElementRepository("errorStatus", PolymorphismTest_S_o5_method_Call_WriteLine_errorStatus);
								AddToElementRepository("LiteralUnlimitedNatural220", PolymorphismTest_S_o5_method_Call_WriteLine_errorStatus_LiteralUnlimitedNatural220);
								AddToElementRepository("LiteralInteger221", PolymorphismTest_S_o5_method_Call_WriteLine_errorStatus_LiteralInteger221);
								AddToElementRepository("LiteralInteger222", PolymorphismTest_S_o5_method_Call_WriteLine_errorStatus_LiteralInteger222);
							AddToElementRepository("value", PolymorphismTest_S_o5_method_Call_WriteLine_value);
								AddToElementRepository("LiteralInteger223", PolymorphismTest_S_o5_method_Call_WriteLine_value_LiteralInteger223);
								AddToElementRepository("LiteralInteger224", PolymorphismTest_S_o5_method_Call_WriteLine_value_LiteralInteger224);
								AddToElementRepository("LiteralUnlimitedNatural225", PolymorphismTest_S_o5_method_Call_WriteLine_value_LiteralUnlimitedNatural225);
						AddToElementRepository("Message", PolymorphismTest_S_o5_method_Message);
							AddToElementRepository("LiteralString226", PolymorphismTest_S_o5_method_Message_LiteralString226);
							AddToElementRepository("result", PolymorphismTest_S_o5_method_Message_result);
								AddToElementRepository("LiteralUnlimitedNatural227", PolymorphismTest_S_o5_method_Message_result_LiteralUnlimitedNatural227);
								AddToElementRepository("LiteralInteger228", PolymorphismTest_S_o5_method_Message_result_LiteralInteger228);
						AddToElementRepository("ObjectFlow229", PolymorphismTest_S_o5_method_ObjectFlow229);
							AddToElementRepository("LiteralInteger230", PolymorphismTest_S_o5_method_ObjectFlow229_LiteralInteger230);
							AddToElementRepository("LiteralBoolean231", PolymorphismTest_S_o5_method_ObjectFlow229_LiteralBoolean231);
					AddToElementRepository("o5", PolymorphismTest_S_o5);
					AddToElementRepository("Generalization232", PolymorphismTest_S_Generalization232);
					AddToElementRepository("o2_method", PolymorphismTest_S_o2_method);
						AddToElementRepository("b", PolymorphismTest_S_o2_method_b);
						AddToElementRepository("a_node", PolymorphismTest_S_o2_method_a_node);
							AddToElementRepository("LiteralInteger233", PolymorphismTest_S_o2_method_a_node_LiteralInteger233);
						AddToElementRepository("a", PolymorphismTest_S_o2_method_a);
						AddToElementRepository("Message", PolymorphismTest_S_o2_method_Message);
							AddToElementRepository("LiteralString234", PolymorphismTest_S_o2_method_Message_LiteralString234);
							AddToElementRepository("result", PolymorphismTest_S_o2_method_Message_result);
								AddToElementRepository("LiteralUnlimitedNatural235", PolymorphismTest_S_o2_method_Message_result_LiteralUnlimitedNatural235);
								AddToElementRepository("LiteralInteger236", PolymorphismTest_S_o2_method_Message_result_LiteralInteger236);
						AddToElementRepository("Call WriteLine", PolymorphismTest_S_o2_method_Call_WriteLine);
							AddToElementRepository("errorStatus", PolymorphismTest_S_o2_method_Call_WriteLine_errorStatus);
								AddToElementRepository("LiteralInteger237", PolymorphismTest_S_o2_method_Call_WriteLine_errorStatus_LiteralInteger237);
								AddToElementRepository("LiteralUnlimitedNatural238", PolymorphismTest_S_o2_method_Call_WriteLine_errorStatus_LiteralUnlimitedNatural238);
								AddToElementRepository("LiteralInteger239", PolymorphismTest_S_o2_method_Call_WriteLine_errorStatus_LiteralInteger239);
							AddToElementRepository("value", PolymorphismTest_S_o2_method_Call_WriteLine_value);
								AddToElementRepository("LiteralInteger240", PolymorphismTest_S_o2_method_Call_WriteLine_value_LiteralInteger240);
								AddToElementRepository("LiteralUnlimitedNatural241", PolymorphismTest_S_o2_method_Call_WriteLine_value_LiteralUnlimitedNatural241);
								AddToElementRepository("LiteralInteger242", PolymorphismTest_S_o2_method_Call_WriteLine_value_LiteralInteger242);
						AddToElementRepository("b_node", PolymorphismTest_S_o2_method_b_node);
							AddToElementRepository("LiteralInteger243", PolymorphismTest_S_o2_method_b_node_LiteralInteger243);
						AddToElementRepository("ObjectFlow244", PolymorphismTest_S_o2_method_ObjectFlow244);
							AddToElementRepository("LiteralInteger245", PolymorphismTest_S_o2_method_ObjectFlow244_LiteralInteger245);
							AddToElementRepository("LiteralBoolean246", PolymorphismTest_S_o2_method_ObjectFlow244_LiteralBoolean246);
					AddToElementRepository("A_o1_B", PolymorphismTest_S_A_o1_B);
						AddToElementRepository("a", PolymorphismTest_S_A_o1_B_a);
						AddToElementRepository("b", PolymorphismTest_S_A_o1_B_b);
					AddToElementRepository("B_o2_A", PolymorphismTest_S_B_o2_A);
						AddToElementRepository("a", PolymorphismTest_S_B_o2_A_a);
						AddToElementRepository("b", PolymorphismTest_S_B_o2_A_b);
					AddToElementRepository("o3", PolymorphismTest_S_o3);

			// Initialize public members
			/*
			 * Model PolymorphismTest
			 */
			PolymorphismTest.SetName("PolymorphismTest");
			PolymorphismTest.SetVisibility(VisibilityKind.public_);
				// Class U
				PolymorphismTest_U.SetName("U");
				PolymorphismTest_U.SetVisibility(VisibilityKind.public_);
				// Activity o4_method
					PolymorphismTest_U_o4_method.SetName("o4_method");
					PolymorphismTest_U_o4_method.SetVisibility(VisibilityKind.public_);
						// CallBehaviorAction Call WriteLine
						PolymorphismTest_U_o4_method_Call_WriteLine.SetName("Call WriteLine");
						PolymorphismTest_U_o4_method_Call_WriteLine.SetVisibility(VisibilityKind.public_);
						
							// OutputPin errorStatus
							PolymorphismTest_U_o4_method_Call_WriteLine_errorStatus.SetName("errorStatus");
							PolymorphismTest_U_o4_method_Call_WriteLine_errorStatus.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_U_o4_method_Call_WriteLine_errorStatus.SetType(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_Common_Status);
							PolymorphismTest_U_o4_method_Call_WriteLine_errorStatus.SetLower(0);
						PolymorphismTest_U_o4_method_Call_WriteLine.AddResult(PolymorphismTest_U_o4_method_Call_WriteLine_errorStatus);
						PolymorphismTest_U_o4_method_Call_WriteLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
							// InputPin value
							PolymorphismTest_U_o4_method_Call_WriteLine_value.SetName("value");
							PolymorphismTest_U_o4_method_Call_WriteLine_value.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_U_o4_method_Call_WriteLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						PolymorphismTest_U_o4_method_Call_WriteLine.AddArgument(PolymorphismTest_U_o4_method_Call_WriteLine_value);
					PolymorphismTest_U_o4_method.AddNode(PolymorphismTest_U_o4_method_Call_WriteLine);
						// ValueSpecificationAction Message
						PolymorphismTest_U_o4_method_Message.SetName("Message");
						PolymorphismTest_U_o4_method_Message.SetVisibility(VisibilityKind.public_);
							// LiteralString LiteralString6
							PolymorphismTest_U_o4_method_Message_LiteralString6.SetName("LiteralString6");
							PolymorphismTest_U_o4_method_Message_LiteralString6.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_U_o4_method_Message_LiteralString6.SetValue("U::o4()");
						PolymorphismTest_U_o4_method_Message.SetValue(PolymorphismTest_U_o4_method_Message_LiteralString6);
							// OutputPin result
							PolymorphismTest_U_o4_method_Message_result.SetName("result");
							PolymorphismTest_U_o4_method_Message_result.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_U_o4_method_Message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						PolymorphismTest_U_o4_method_Message.SetResult(PolymorphismTest_U_o4_method_Message_result);
					PolymorphismTest_U_o4_method.AddNode(PolymorphismTest_U_o4_method_Message);
						// ObjectFlow ObjectFlow9 from result to value
						PolymorphismTest_U_o4_method_ObjectFlow9.SetName("ObjectFlow9");
						PolymorphismTest_U_o4_method_ObjectFlow9.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_U_o4_method_ObjectFlow9.SetSource(PolymorphismTest_U_o4_method_Message_result);
						PolymorphismTest_U_o4_method_ObjectFlow9.SetTarget(PolymorphismTest_U_o4_method_Call_WriteLine_value);
							// LiteralBoolean LiteralBoolean11
							PolymorphismTest_U_o4_method_ObjectFlow9_LiteralBoolean11.SetName("LiteralBoolean11");
							PolymorphismTest_U_o4_method_ObjectFlow9_LiteralBoolean11.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_U_o4_method_ObjectFlow9_LiteralBoolean11.SetValue(true);
						PolymorphismTest_U_o4_method_ObjectFlow9.SetGuard(PolymorphismTest_U_o4_method_ObjectFlow9_LiteralBoolean11);
					PolymorphismTest_U_o4_method.AddEdge(PolymorphismTest_U_o4_method_ObjectFlow9);
				PolymorphismTest_U.AddOwnedBehavior(PolymorphismTest_U_o4_method);
					// Activity o2_method
					PolymorphismTest_U_o2_method.SetName("o2_method");
					PolymorphismTest_U_o2_method.SetVisibility(VisibilityKind.public_);
					
						// Parameter b
						PolymorphismTest_U_o2_method_b.SetName("b");
						PolymorphismTest_U_o2_method_b.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_U_o2_method_b.SetType(PolymorphismTest_B);
					PolymorphismTest_U_o2_method.AddOwnedParameter(PolymorphismTest_U_o2_method_b);
						// Parameter a
						PolymorphismTest_U_o2_method_a.SetName("a");
						PolymorphismTest_U_o2_method_a.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_U_o2_method_a.SetType(PolymorphismTest_A);
						PolymorphismTest_U_o2_method_a.SetDirection(ParameterDirectionKind.return_);
					PolymorphismTest_U_o2_method.AddOwnedParameter(PolymorphismTest_U_o2_method_a);
						// ActivityParameterNode b_node
						PolymorphismTest_U_o2_method_b_node.SetName("b_node");
						PolymorphismTest_U_o2_method_b_node.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_U_o2_method_b_node.SetParameter(PolymorphismTest_U_o2_method_b);
					PolymorphismTest_U_o2_method.AddNode(PolymorphismTest_U_o2_method_b_node);
						// CallBehaviorAction Call WriteLine
						PolymorphismTest_U_o2_method_Call_WriteLine.SetName("Call WriteLine");
						PolymorphismTest_U_o2_method_Call_WriteLine.SetVisibility(VisibilityKind.public_);
						
							// OutputPin errorStatus
							PolymorphismTest_U_o2_method_Call_WriteLine_errorStatus.SetName("errorStatus");
							PolymorphismTest_U_o2_method_Call_WriteLine_errorStatus.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_U_o2_method_Call_WriteLine_errorStatus.SetType(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_Common_Status);
							PolymorphismTest_U_o2_method_Call_WriteLine_errorStatus.SetLower(0);
						PolymorphismTest_U_o2_method_Call_WriteLine.AddResult(PolymorphismTest_U_o2_method_Call_WriteLine_errorStatus);
						PolymorphismTest_U_o2_method_Call_WriteLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
							// InputPin value
							PolymorphismTest_U_o2_method_Call_WriteLine_value.SetName("value");
							PolymorphismTest_U_o2_method_Call_WriteLine_value.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_U_o2_method_Call_WriteLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						PolymorphismTest_U_o2_method_Call_WriteLine.AddArgument(PolymorphismTest_U_o2_method_Call_WriteLine_value);
					PolymorphismTest_U_o2_method.AddNode(PolymorphismTest_U_o2_method_Call_WriteLine);
						// ValueSpecificationAction Message
						PolymorphismTest_U_o2_method_Message.SetName("Message");
						PolymorphismTest_U_o2_method_Message.SetVisibility(VisibilityKind.public_);
							// LiteralString LiteralString24
							PolymorphismTest_U_o2_method_Message_LiteralString24.SetName("LiteralString24");
							PolymorphismTest_U_o2_method_Message_LiteralString24.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_U_o2_method_Message_LiteralString24.SetValue("U::o2(b : B) : A");
						PolymorphismTest_U_o2_method_Message.SetValue(PolymorphismTest_U_o2_method_Message_LiteralString24);
							// OutputPin result
							PolymorphismTest_U_o2_method_Message_result.SetName("result");
							PolymorphismTest_U_o2_method_Message_result.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_U_o2_method_Message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						PolymorphismTest_U_o2_method_Message.SetResult(PolymorphismTest_U_o2_method_Message_result);
					PolymorphismTest_U_o2_method.AddNode(PolymorphismTest_U_o2_method_Message);
						// ActivityParameterNode a_node
						PolymorphismTest_U_o2_method_a_node.SetName("a_node");
						PolymorphismTest_U_o2_method_a_node.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_U_o2_method_a_node.SetParameter(PolymorphismTest_U_o2_method_a);
					PolymorphismTest_U_o2_method.AddNode(PolymorphismTest_U_o2_method_a_node);
						// ObjectFlow ObjectFlow13 from result to value
						PolymorphismTest_U_o2_method_ObjectFlow13.SetName("ObjectFlow13");
						PolymorphismTest_U_o2_method_ObjectFlow13.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_U_o2_method_ObjectFlow13.SetSource(PolymorphismTest_U_o2_method_Message_result);
						PolymorphismTest_U_o2_method_ObjectFlow13.SetTarget(PolymorphismTest_U_o2_method_Call_WriteLine_value);
							// LiteralBoolean LiteralBoolean15
							PolymorphismTest_U_o2_method_ObjectFlow13_LiteralBoolean15.SetName("LiteralBoolean15");
							PolymorphismTest_U_o2_method_ObjectFlow13_LiteralBoolean15.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_U_o2_method_ObjectFlow13_LiteralBoolean15.SetValue(true);
						PolymorphismTest_U_o2_method_ObjectFlow13.SetGuard(PolymorphismTest_U_o2_method_ObjectFlow13_LiteralBoolean15);
					PolymorphismTest_U_o2_method.AddEdge(PolymorphismTest_U_o2_method_ObjectFlow13);
				PolymorphismTest_U.AddOwnedBehavior(PolymorphismTest_U_o2_method);
					// Activity o3_method
					PolymorphismTest_U_o3_method.SetName("o3_method");
					PolymorphismTest_U_o3_method.SetVisibility(VisibilityKind.public_);
					
						// Parameter i
						PolymorphismTest_U_o3_method_i.SetName("i");
						PolymorphismTest_U_o3_method_i.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_U_o3_method_i.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					PolymorphismTest_U_o3_method.AddOwnedParameter(PolymorphismTest_U_o3_method_i);
						// ActivityParameterNode i_node
						PolymorphismTest_U_o3_method_i_node.SetName("i_node");
						PolymorphismTest_U_o3_method_i_node.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_U_o3_method_i_node.SetParameter(PolymorphismTest_U_o3_method_i);
					PolymorphismTest_U_o3_method.AddNode(PolymorphismTest_U_o3_method_i_node);
						// ValueSpecificationAction Message
						PolymorphismTest_U_o3_method_Message.SetName("Message");
						PolymorphismTest_U_o3_method_Message.SetVisibility(VisibilityKind.public_);
							// LiteralString LiteralString29
							PolymorphismTest_U_o3_method_Message_LiteralString29.SetName("LiteralString29");
							PolymorphismTest_U_o3_method_Message_LiteralString29.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_U_o3_method_Message_LiteralString29.SetValue("U::o3(i : int)");
						PolymorphismTest_U_o3_method_Message.SetValue(PolymorphismTest_U_o3_method_Message_LiteralString29);
							// OutputPin result
							PolymorphismTest_U_o3_method_Message_result.SetName("result");
							PolymorphismTest_U_o3_method_Message_result.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_U_o3_method_Message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						PolymorphismTest_U_o3_method_Message.SetResult(PolymorphismTest_U_o3_method_Message_result);
					PolymorphismTest_U_o3_method.AddNode(PolymorphismTest_U_o3_method_Message);
						// CallBehaviorAction Call WriteLine
						PolymorphismTest_U_o3_method_Call_WriteLine.SetName("Call WriteLine");
						PolymorphismTest_U_o3_method_Call_WriteLine.SetVisibility(VisibilityKind.public_);
						
							// OutputPin errorStatus
							PolymorphismTest_U_o3_method_Call_WriteLine_errorStatus.SetName("errorStatus");
							PolymorphismTest_U_o3_method_Call_WriteLine_errorStatus.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_U_o3_method_Call_WriteLine_errorStatus.SetType(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_Common_Status);
							PolymorphismTest_U_o3_method_Call_WriteLine_errorStatus.SetLower(0);
						PolymorphismTest_U_o3_method_Call_WriteLine.AddResult(PolymorphismTest_U_o3_method_Call_WriteLine_errorStatus);
						PolymorphismTest_U_o3_method_Call_WriteLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
							// InputPin value
							PolymorphismTest_U_o3_method_Call_WriteLine_value.SetName("value");
							PolymorphismTest_U_o3_method_Call_WriteLine_value.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_U_o3_method_Call_WriteLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						PolymorphismTest_U_o3_method_Call_WriteLine.AddArgument(PolymorphismTest_U_o3_method_Call_WriteLine_value);
					PolymorphismTest_U_o3_method.AddNode(PolymorphismTest_U_o3_method_Call_WriteLine);
						// ObjectFlow ObjectFlow36 from result to value
						PolymorphismTest_U_o3_method_ObjectFlow36.SetName("ObjectFlow36");
						PolymorphismTest_U_o3_method_ObjectFlow36.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_U_o3_method_ObjectFlow36.SetSource(PolymorphismTest_U_o3_method_Message_result);
						PolymorphismTest_U_o3_method_ObjectFlow36.SetTarget(PolymorphismTest_U_o3_method_Call_WriteLine_value);
							// LiteralBoolean LiteralBoolean38
							PolymorphismTest_U_o3_method_ObjectFlow36_LiteralBoolean38.SetName("LiteralBoolean38");
							PolymorphismTest_U_o3_method_ObjectFlow36_LiteralBoolean38.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_U_o3_method_ObjectFlow36_LiteralBoolean38.SetValue(true);
						PolymorphismTest_U_o3_method_ObjectFlow36.SetGuard(PolymorphismTest_U_o3_method_ObjectFlow36_LiteralBoolean38);
					PolymorphismTest_U_o3_method.AddEdge(PolymorphismTest_U_o3_method_ObjectFlow36);
				PolymorphismTest_U.AddOwnedBehavior(PolymorphismTest_U_o3_method);
					// Activity x_method
					PolymorphismTest_U_x_method.SetName("x_method");
					PolymorphismTest_U_x_method.SetVisibility(VisibilityKind.public_);
						// CallBehaviorAction Call WriteLine
						PolymorphismTest_U_x_method_Call_WriteLine.SetName("Call WriteLine");
						PolymorphismTest_U_x_method_Call_WriteLine.SetVisibility(VisibilityKind.public_);
						
							// OutputPin errorStatus
							PolymorphismTest_U_x_method_Call_WriteLine_errorStatus.SetName("errorStatus");
							PolymorphismTest_U_x_method_Call_WriteLine_errorStatus.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_U_x_method_Call_WriteLine_errorStatus.SetType(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_Common_Status);
							PolymorphismTest_U_x_method_Call_WriteLine_errorStatus.SetLower(0);
						PolymorphismTest_U_x_method_Call_WriteLine.AddResult(PolymorphismTest_U_x_method_Call_WriteLine_errorStatus);
						PolymorphismTest_U_x_method_Call_WriteLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
							// InputPin value
							PolymorphismTest_U_x_method_Call_WriteLine_value.SetName("value");
							PolymorphismTest_U_x_method_Call_WriteLine_value.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_U_x_method_Call_WriteLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						PolymorphismTest_U_x_method_Call_WriteLine.AddArgument(PolymorphismTest_U_x_method_Call_WriteLine_value);
					PolymorphismTest_U_x_method.AddNode(PolymorphismTest_U_x_method_Call_WriteLine);
						// ValueSpecificationAction Message
						PolymorphismTest_U_x_method_Message.SetName("Message");
						PolymorphismTest_U_x_method_Message.SetVisibility(VisibilityKind.public_);
							// LiteralString LiteralString48
							PolymorphismTest_U_x_method_Message_LiteralString48.SetName("LiteralString48");
							PolymorphismTest_U_x_method_Message_LiteralString48.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_U_x_method_Message_LiteralString48.SetValue("U::x()");
						PolymorphismTest_U_x_method_Message.SetValue(PolymorphismTest_U_x_method_Message_LiteralString48);
							// OutputPin result
							PolymorphismTest_U_x_method_Message_result.SetName("result");
							PolymorphismTest_U_x_method_Message_result.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_U_x_method_Message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						PolymorphismTest_U_x_method_Message.SetResult(PolymorphismTest_U_x_method_Message_result);
					PolymorphismTest_U_x_method.AddNode(PolymorphismTest_U_x_method_Message);
						// ObjectFlow ObjectFlow45 from result to value
						PolymorphismTest_U_x_method_ObjectFlow45.SetName("ObjectFlow45");
						PolymorphismTest_U_x_method_ObjectFlow45.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_U_x_method_ObjectFlow45.SetSource(PolymorphismTest_U_x_method_Message_result);
						PolymorphismTest_U_x_method_ObjectFlow45.SetTarget(PolymorphismTest_U_x_method_Call_WriteLine_value);
							// LiteralBoolean LiteralBoolean46
							PolymorphismTest_U_x_method_ObjectFlow45_LiteralBoolean46.SetName("LiteralBoolean46");
							PolymorphismTest_U_x_method_ObjectFlow45_LiteralBoolean46.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_U_x_method_ObjectFlow45_LiteralBoolean46.SetValue(true);
						PolymorphismTest_U_x_method_ObjectFlow45.SetGuard(PolymorphismTest_U_x_method_ObjectFlow45_LiteralBoolean46);
					PolymorphismTest_U_x_method.AddEdge(PolymorphismTest_U_x_method_ObjectFlow45);
				PolymorphismTest_U.AddOwnedBehavior(PolymorphismTest_U_x_method);
					// Activity o1_method
					PolymorphismTest_U_o1_method.SetName("o1_method");
					PolymorphismTest_U_o1_method.SetVisibility(VisibilityKind.public_);
					
						// Parameter b
						PolymorphismTest_U_o1_method_b.SetName("b");
						PolymorphismTest_U_o1_method_b.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_U_o1_method_b.SetType(PolymorphismTest_B);
					PolymorphismTest_U_o1_method.AddOwnedParameter(PolymorphismTest_U_o1_method_b);
						// Parameter a
						PolymorphismTest_U_o1_method_a.SetName("a");
						PolymorphismTest_U_o1_method_a.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_U_o1_method_a.SetType(PolymorphismTest_A);
						PolymorphismTest_U_o1_method_a.SetDirection(ParameterDirectionKind.return_);
					PolymorphismTest_U_o1_method.AddOwnedParameter(PolymorphismTest_U_o1_method_a);
						// ValueSpecificationAction Message
						PolymorphismTest_U_o1_method_Message.SetName("Message");
						PolymorphismTest_U_o1_method_Message.SetVisibility(VisibilityKind.public_);
							// LiteralString LiteralString53
							PolymorphismTest_U_o1_method_Message_LiteralString53.SetName("LiteralString53");
							PolymorphismTest_U_o1_method_Message_LiteralString53.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_U_o1_method_Message_LiteralString53.SetValue("U::o1(b : B) : A");
						PolymorphismTest_U_o1_method_Message.SetValue(PolymorphismTest_U_o1_method_Message_LiteralString53);
							// OutputPin result
							PolymorphismTest_U_o1_method_Message_result.SetName("result");
							PolymorphismTest_U_o1_method_Message_result.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_U_o1_method_Message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						PolymorphismTest_U_o1_method_Message.SetResult(PolymorphismTest_U_o1_method_Message_result);
					PolymorphismTest_U_o1_method.AddNode(PolymorphismTest_U_o1_method_Message);
						// CallBehaviorAction Call WriteLine
						PolymorphismTest_U_o1_method_Call_WriteLine.SetName("Call WriteLine");
						PolymorphismTest_U_o1_method_Call_WriteLine.SetVisibility(VisibilityKind.public_);
						
							// OutputPin errorStatus
							PolymorphismTest_U_o1_method_Call_WriteLine_errorStatus.SetName("errorStatus");
							PolymorphismTest_U_o1_method_Call_WriteLine_errorStatus.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_U_o1_method_Call_WriteLine_errorStatus.SetType(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_Common_Status);
							PolymorphismTest_U_o1_method_Call_WriteLine_errorStatus.SetLower(0);
						PolymorphismTest_U_o1_method_Call_WriteLine.AddResult(PolymorphismTest_U_o1_method_Call_WriteLine_errorStatus);
						PolymorphismTest_U_o1_method_Call_WriteLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
							// InputPin value
							PolymorphismTest_U_o1_method_Call_WriteLine_value.SetName("value");
							PolymorphismTest_U_o1_method_Call_WriteLine_value.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_U_o1_method_Call_WriteLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						PolymorphismTest_U_o1_method_Call_WriteLine.AddArgument(PolymorphismTest_U_o1_method_Call_WriteLine_value);
					PolymorphismTest_U_o1_method.AddNode(PolymorphismTest_U_o1_method_Call_WriteLine);
						// ActivityParameterNode b_node
						PolymorphismTest_U_o1_method_b_node.SetName("b_node");
						PolymorphismTest_U_o1_method_b_node.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_U_o1_method_b_node.SetParameter(PolymorphismTest_U_o1_method_b);
					PolymorphismTest_U_o1_method.AddNode(PolymorphismTest_U_o1_method_b_node);
						// ActivityParameterNode a_node
						PolymorphismTest_U_o1_method_a_node.SetName("a_node");
						PolymorphismTest_U_o1_method_a_node.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_U_o1_method_a_node.SetParameter(PolymorphismTest_U_o1_method_a);
					PolymorphismTest_U_o1_method.AddNode(PolymorphismTest_U_o1_method_a_node);
						// ObjectFlow ObjectFlow62 from result to value
						PolymorphismTest_U_o1_method_ObjectFlow62.SetName("ObjectFlow62");
						PolymorphismTest_U_o1_method_ObjectFlow62.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_U_o1_method_ObjectFlow62.SetSource(PolymorphismTest_U_o1_method_Message_result);
						PolymorphismTest_U_o1_method_ObjectFlow62.SetTarget(PolymorphismTest_U_o1_method_Call_WriteLine_value);
							// LiteralBoolean LiteralBoolean64
							PolymorphismTest_U_o1_method_ObjectFlow62_LiteralBoolean64.SetName("LiteralBoolean64");
							PolymorphismTest_U_o1_method_ObjectFlow62_LiteralBoolean64.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_U_o1_method_ObjectFlow62_LiteralBoolean64.SetValue(true);
						PolymorphismTest_U_o1_method_ObjectFlow62.SetGuard(PolymorphismTest_U_o1_method_ObjectFlow62_LiteralBoolean64);
					PolymorphismTest_U_o1_method.AddEdge(PolymorphismTest_U_o1_method_ObjectFlow62);
				PolymorphismTest_U.AddOwnedBehavior(PolymorphismTest_U_o1_method);
				
					// Operation x
					PolymorphismTest_U_x.SetName("x");
					PolymorphismTest_U_x.SetVisibility(VisibilityKind.public_);
					PolymorphismTest_U_x.AddMethod(PolymorphismTest_U_x_method);
					PolymorphismTest_U_x.AddRedefinedOperation(PolymorphismTest_A_x);
				PolymorphismTest_U.AddOwnedOperation(PolymorphismTest_U_x);
					// Operation A_o1_B
					PolymorphismTest_U_A_o1_B.SetName("o1");
					PolymorphismTest_U_A_o1_B.SetVisibility(VisibilityKind.public_);
						// Parameter b
						PolymorphismTest_U_A_o1_B_b.SetName("b");
						PolymorphismTest_U_A_o1_B_b.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_U_A_o1_B_b.SetType(PolymorphismTest_B);
					PolymorphismTest_U_A_o1_B.AddOwnedParameter(PolymorphismTest_U_A_o1_B_b);
						// Parameter a
						PolymorphismTest_U_A_o1_B_a.SetName("a");
						PolymorphismTest_U_A_o1_B_a.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_U_A_o1_B_a.SetType(PolymorphismTest_A);
						PolymorphismTest_U_A_o1_B_a.SetDirection(ParameterDirectionKind.return_);
					PolymorphismTest_U_A_o1_B.AddOwnedParameter(PolymorphismTest_U_A_o1_B_a);
					PolymorphismTest_U_A_o1_B.AddMethod(PolymorphismTest_U_o1_method);
				PolymorphismTest_U.AddOwnedOperation(PolymorphismTest_U_A_o1_B);
					// Operation A_o2_B
					PolymorphismTest_U_A_o2_B.SetName("o2");
					PolymorphismTest_U_A_o2_B.SetVisibility(VisibilityKind.public_);
						// Parameter b
						PolymorphismTest_U_A_o2_B_b.SetName("b");
						PolymorphismTest_U_A_o2_B_b.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_U_A_o2_B_b.SetType(PolymorphismTest_B);
					PolymorphismTest_U_A_o2_B.AddOwnedParameter(PolymorphismTest_U_A_o2_B_b);
						// Parameter a
						PolymorphismTest_U_A_o2_B_a.SetName("a");
						PolymorphismTest_U_A_o2_B_a.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_U_A_o2_B_a.SetType(PolymorphismTest_A);
						PolymorphismTest_U_A_o2_B_a.SetDirection(ParameterDirectionKind.return_);
					PolymorphismTest_U_A_o2_B.AddOwnedParameter(PolymorphismTest_U_A_o2_B_a);
					PolymorphismTest_U_A_o2_B.AddMethod(PolymorphismTest_U_o2_method);
				PolymorphismTest_U.AddOwnedOperation(PolymorphismTest_U_A_o2_B);
					// Operation o3_Integer
					PolymorphismTest_U_o3_Integer.SetName("o3");
					PolymorphismTest_U_o3_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter i
						PolymorphismTest_U_o3_Integer_i.SetName("i");
						PolymorphismTest_U_o3_Integer_i.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_U_o3_Integer_i.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					PolymorphismTest_U_o3_Integer.AddOwnedParameter(PolymorphismTest_U_o3_Integer_i);
					PolymorphismTest_U_o3_Integer.AddMethod(PolymorphismTest_U_o3_method);
				PolymorphismTest_U.AddOwnedOperation(PolymorphismTest_U_o3_Integer);
					// Operation o4
					PolymorphismTest_U_o4.SetName("o4");
					PolymorphismTest_U_o4.SetVisibility(VisibilityKind.public_);
					PolymorphismTest_U_o4.AddMethod(PolymorphismTest_U_o4_method);
				PolymorphismTest_U.AddOwnedOperation(PolymorphismTest_U_o4);
			PolymorphismTest.AddPackagedElement(PolymorphismTest_U);
				// Class B
				PolymorphismTest_B.SetName("B");
				PolymorphismTest_B.SetVisibility(VisibilityKind.public_);
				
					// Generalization to A
					PolymorphismTest_B_Generalization65.SetGeneral(PolymorphismTest_A);
				PolymorphismTest_B.AddGeneralization(PolymorphismTest_B_Generalization65);
			PolymorphismTest.AddPackagedElement(PolymorphismTest_B);
				// Class A
				PolymorphismTest_A.SetName("A");
				PolymorphismTest_A.SetVisibility(VisibilityKind.public_);
				// Activity x_method
					PolymorphismTest_A_x_method.SetName("x_method");
					PolymorphismTest_A_x_method.SetVisibility(VisibilityKind.public_);
						// CallBehaviorAction Call WriteLine
						PolymorphismTest_A_x_method_Call_WriteLine.SetName("Call WriteLine");
						PolymorphismTest_A_x_method_Call_WriteLine.SetVisibility(VisibilityKind.public_);
						
							// OutputPin errorStatus
							PolymorphismTest_A_x_method_Call_WriteLine_errorStatus.SetName("errorStatus");
							PolymorphismTest_A_x_method_Call_WriteLine_errorStatus.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_A_x_method_Call_WriteLine_errorStatus.SetType(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_Common_Status);
							PolymorphismTest_A_x_method_Call_WriteLine_errorStatus.SetLower(0);
						PolymorphismTest_A_x_method_Call_WriteLine.AddResult(PolymorphismTest_A_x_method_Call_WriteLine_errorStatus);
						PolymorphismTest_A_x_method_Call_WriteLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
							// InputPin value
							PolymorphismTest_A_x_method_Call_WriteLine_value.SetName("value");
							PolymorphismTest_A_x_method_Call_WriteLine_value.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_A_x_method_Call_WriteLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						PolymorphismTest_A_x_method_Call_WriteLine.AddArgument(PolymorphismTest_A_x_method_Call_WriteLine_value);
					PolymorphismTest_A_x_method.AddNode(PolymorphismTest_A_x_method_Call_WriteLine);
						// ValueSpecificationAction Message
						PolymorphismTest_A_x_method_Message.SetName("Message");
						PolymorphismTest_A_x_method_Message.SetVisibility(VisibilityKind.public_);
							// LiteralString LiteralString72
							PolymorphismTest_A_x_method_Message_LiteralString72.SetName("LiteralString72");
							PolymorphismTest_A_x_method_Message_LiteralString72.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_A_x_method_Message_LiteralString72.SetValue("A::x()");
						PolymorphismTest_A_x_method_Message.SetValue(PolymorphismTest_A_x_method_Message_LiteralString72);
							// OutputPin result
							PolymorphismTest_A_x_method_Message_result.SetName("result");
							PolymorphismTest_A_x_method_Message_result.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_A_x_method_Message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						PolymorphismTest_A_x_method_Message.SetResult(PolymorphismTest_A_x_method_Message_result);
					PolymorphismTest_A_x_method.AddNode(PolymorphismTest_A_x_method_Message);
						// ObjectFlow ObjectFlow75 from result to value
						PolymorphismTest_A_x_method_ObjectFlow75.SetName("ObjectFlow75");
						PolymorphismTest_A_x_method_ObjectFlow75.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_A_x_method_ObjectFlow75.SetSource(PolymorphismTest_A_x_method_Message_result);
						PolymorphismTest_A_x_method_ObjectFlow75.SetTarget(PolymorphismTest_A_x_method_Call_WriteLine_value);
							// LiteralBoolean LiteralBoolean76
							PolymorphismTest_A_x_method_ObjectFlow75_LiteralBoolean76.SetName("LiteralBoolean76");
							PolymorphismTest_A_x_method_ObjectFlow75_LiteralBoolean76.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_A_x_method_ObjectFlow75_LiteralBoolean76.SetValue(true);
						PolymorphismTest_A_x_method_ObjectFlow75.SetGuard(PolymorphismTest_A_x_method_ObjectFlow75_LiteralBoolean76);
					PolymorphismTest_A_x_method.AddEdge(PolymorphismTest_A_x_method_ObjectFlow75);
				PolymorphismTest_A.AddOwnedBehavior(PolymorphismTest_A_x_method);
				
					// Operation x
					PolymorphismTest_A_x.SetName("x");
					PolymorphismTest_A_x.SetVisibility(VisibilityKind.public_);
					PolymorphismTest_A_x.AddMethod(PolymorphismTest_A_x_method);
				PolymorphismTest_A.AddOwnedOperation(PolymorphismTest_A_x);
			PolymorphismTest.AddPackagedElement(PolymorphismTest_A);
				// Activity main
				PolymorphismTest_main.SetName("main");
				PolymorphismTest_main.SetVisibility(VisibilityKind.public_);
				// Activity runTests
					PolymorphismTest_main_runTests.SetName("runTests");
					PolymorphismTest_main_runTests.SetVisibility(VisibilityKind.public_);
					
						// Parameter u
						PolymorphismTest_main_runTests_u.SetName("u");
						PolymorphismTest_main_runTests_u.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_main_runTests_u.SetType(PolymorphismTest_U);
					PolymorphismTest_main_runTests.AddOwnedParameter(PolymorphismTest_main_runTests_u);
						// CallOperationAction Call o3()
						PolymorphismTest_main_runTests_Call_o3_.SetName("Call o3()");
						PolymorphismTest_main_runTests_Call_o3_.SetVisibility(VisibilityKind.public_);
						PolymorphismTest_main_runTests_Call_o3_.SetOperation(PolymorphismTest_U_o3_Integer);
							// InputPin target
							PolymorphismTest_main_runTests_Call_o3__target.SetName("target");
							PolymorphismTest_main_runTests_Call_o3__target.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_main_runTests_Call_o3__target.SetType(PolymorphismTest_U);
						PolymorphismTest_main_runTests_Call_o3_.SetTarget(PolymorphismTest_main_runTests_Call_o3__target);
							// InputPin i
							PolymorphismTest_main_runTests_Call_o3__i.SetName("i");
							PolymorphismTest_main_runTests_Call_o3__i.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_main_runTests_Call_o3__i.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
							PolymorphismTest_main_runTests_Call_o3__i.SetLower(0);
						PolymorphismTest_main_runTests_Call_o3_.AddArgument(PolymorphismTest_main_runTests_Call_o3__i);
					PolymorphismTest_main_runTests.AddNode(PolymorphismTest_main_runTests_Call_o3_);
						// CallOperationAction Call A::x()
						PolymorphismTest_main_runTests_Call_A_x_.SetName("Call A::x()");
						PolymorphismTest_main_runTests_Call_A_x_.SetVisibility(VisibilityKind.public_);
						PolymorphismTest_main_runTests_Call_A_x_.SetOperation(PolymorphismTest_A_x);
							// InputPin target
							PolymorphismTest_main_runTests_Call_A_x__target.SetName("target");
							PolymorphismTest_main_runTests_Call_A_x__target.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_main_runTests_Call_A_x__target.SetType(PolymorphismTest_A);
						PolymorphismTest_main_runTests_Call_A_x_.SetTarget(PolymorphismTest_main_runTests_Call_A_x__target);
					PolymorphismTest_main_runTests.AddNode(PolymorphismTest_main_runTests_Call_A_x_);
						// ActivityParameterNode u_node
						PolymorphismTest_main_runTests_u_node.SetName("u_node");
						PolymorphismTest_main_runTests_u_node.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_main_runTests_u_node.SetParameter(PolymorphismTest_main_runTests_u);
					PolymorphismTest_main_runTests.AddNode(PolymorphismTest_main_runTests_u_node);
						// ForkNode Fork u
						PolymorphismTest_main_runTests_Fork_u.SetName("Fork u");
						PolymorphismTest_main_runTests_Fork_u.SetVisibility(VisibilityKind.public_);
					PolymorphismTest_main_runTests.AddNode(PolymorphismTest_main_runTests_Fork_u);
						// CallOperationAction Call U::o1()
						PolymorphismTest_main_runTests_Call_U_o1_.SetName("Call U::o1()");
						PolymorphismTest_main_runTests_Call_U_o1_.SetVisibility(VisibilityKind.public_);
						
							// OutputPin a
							PolymorphismTest_main_runTests_Call_U_o1__a.SetName("a");
							PolymorphismTest_main_runTests_Call_U_o1__a.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_main_runTests_Call_U_o1__a.SetType(PolymorphismTest_A);
						PolymorphismTest_main_runTests_Call_U_o1_.AddResult(PolymorphismTest_main_runTests_Call_U_o1__a);
						PolymorphismTest_main_runTests_Call_U_o1_.SetOperation(PolymorphismTest_U_A_o1_B);
							// InputPin target
							PolymorphismTest_main_runTests_Call_U_o1__target.SetName("target");
							PolymorphismTest_main_runTests_Call_U_o1__target.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_main_runTests_Call_U_o1__target.SetType(PolymorphismTest_U);
						PolymorphismTest_main_runTests_Call_U_o1_.SetTarget(PolymorphismTest_main_runTests_Call_U_o1__target);
							// InputPin b
							PolymorphismTest_main_runTests_Call_U_o1__b.SetName("b");
							PolymorphismTest_main_runTests_Call_U_o1__b.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_main_runTests_Call_U_o1__b.SetType(PolymorphismTest_B);
							PolymorphismTest_main_runTests_Call_U_o1__b.SetLower(0);
						PolymorphismTest_main_runTests_Call_U_o1_.AddArgument(PolymorphismTest_main_runTests_Call_U_o1__b);
						PolymorphismTest_main_runTests_Call_U_o1_.ApplyStereotype(uml.extensionsprofile.ExtensionsProfileModel.Instance().Stereotype_ExplicitBaseClassCall);
					PolymorphismTest_main_runTests.AddNode(PolymorphismTest_main_runTests_Call_U_o1_);
						// CallOperationAction Call o2()
						PolymorphismTest_main_runTests_Call_o2_.SetName("Call o2()");
						PolymorphismTest_main_runTests_Call_o2_.SetVisibility(VisibilityKind.public_);
						
							// OutputPin a
							PolymorphismTest_main_runTests_Call_o2__a.SetName("a");
							PolymorphismTest_main_runTests_Call_o2__a.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_main_runTests_Call_o2__a.SetType(PolymorphismTest_A);
						PolymorphismTest_main_runTests_Call_o2_.AddResult(PolymorphismTest_main_runTests_Call_o2__a);
						PolymorphismTest_main_runTests_Call_o2_.SetOperation(PolymorphismTest_U_A_o2_B);
							// InputPin target
							PolymorphismTest_main_runTests_Call_o2__target.SetName("target");
							PolymorphismTest_main_runTests_Call_o2__target.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_main_runTests_Call_o2__target.SetType(PolymorphismTest_U);
						PolymorphismTest_main_runTests_Call_o2_.SetTarget(PolymorphismTest_main_runTests_Call_o2__target);
							// InputPin b
							PolymorphismTest_main_runTests_Call_o2__b.SetName("b");
							PolymorphismTest_main_runTests_Call_o2__b.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_main_runTests_Call_o2__b.SetType(PolymorphismTest_B);
							PolymorphismTest_main_runTests_Call_o2__b.SetLower(0);
						PolymorphismTest_main_runTests_Call_o2_.AddArgument(PolymorphismTest_main_runTests_Call_o2__b);
					PolymorphismTest_main_runTests.AddNode(PolymorphismTest_main_runTests_Call_o2_);
						// CallOperationAction Call o4()
						PolymorphismTest_main_runTests_Call_o4_.SetName("Call o4()");
						PolymorphismTest_main_runTests_Call_o4_.SetVisibility(VisibilityKind.public_);
						PolymorphismTest_main_runTests_Call_o4_.SetOperation(PolymorphismTest_U_o4);
							// InputPin target
							PolymorphismTest_main_runTests_Call_o4__target.SetName("target");
							PolymorphismTest_main_runTests_Call_o4__target.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_main_runTests_Call_o4__target.SetType(PolymorphismTest_U);
						PolymorphismTest_main_runTests_Call_o4_.SetTarget(PolymorphismTest_main_runTests_Call_o4__target);
					PolymorphismTest_main_runTests.AddNode(PolymorphismTest_main_runTests_Call_o4_);
						// CallOperationAction Call o1()
						PolymorphismTest_main_runTests_Call_o1_.SetName("Call o1()");
						PolymorphismTest_main_runTests_Call_o1_.SetVisibility(VisibilityKind.public_);
						
							// OutputPin a
							PolymorphismTest_main_runTests_Call_o1__a.SetName("a");
							PolymorphismTest_main_runTests_Call_o1__a.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_main_runTests_Call_o1__a.SetType(PolymorphismTest_A);
						PolymorphismTest_main_runTests_Call_o1_.AddResult(PolymorphismTest_main_runTests_Call_o1__a);
						PolymorphismTest_main_runTests_Call_o1_.SetOperation(PolymorphismTest_U_A_o1_B);
							// InputPin target
							PolymorphismTest_main_runTests_Call_o1__target.SetName("target");
							PolymorphismTest_main_runTests_Call_o1__target.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_main_runTests_Call_o1__target.SetType(PolymorphismTest_U);
						PolymorphismTest_main_runTests_Call_o1_.SetTarget(PolymorphismTest_main_runTests_Call_o1__target);
							// InputPin b
							PolymorphismTest_main_runTests_Call_o1__b.SetName("b");
							PolymorphismTest_main_runTests_Call_o1__b.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_main_runTests_Call_o1__b.SetType(PolymorphismTest_B);
							PolymorphismTest_main_runTests_Call_o1__b.SetLower(0);
						PolymorphismTest_main_runTests_Call_o1_.AddArgument(PolymorphismTest_main_runTests_Call_o1__b);
					PolymorphismTest_main_runTests.AddNode(PolymorphismTest_main_runTests_Call_o1_);
						// ObjectFlow ObjectFlow81 from Fork u to target
						PolymorphismTest_main_runTests_ObjectFlow81.SetName("ObjectFlow81");
						PolymorphismTest_main_runTests_ObjectFlow81.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_main_runTests_ObjectFlow81.SetSource(PolymorphismTest_main_runTests_Fork_u);
						PolymorphismTest_main_runTests_ObjectFlow81.SetTarget(PolymorphismTest_main_runTests_Call_o4__target);
							// LiteralBoolean LiteralBoolean82
							PolymorphismTest_main_runTests_ObjectFlow81_LiteralBoolean82.SetName("LiteralBoolean82");
							PolymorphismTest_main_runTests_ObjectFlow81_LiteralBoolean82.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_main_runTests_ObjectFlow81_LiteralBoolean82.SetValue(true);
						PolymorphismTest_main_runTests_ObjectFlow81.SetGuard(PolymorphismTest_main_runTests_ObjectFlow81_LiteralBoolean82);
					PolymorphismTest_main_runTests.AddEdge(PolymorphismTest_main_runTests_ObjectFlow81);
						// ControlFlow ControlFlow84 from Call U::o1() to Call o2()
						PolymorphismTest_main_runTests_ControlFlow84.SetName("ControlFlow84");
						PolymorphismTest_main_runTests_ControlFlow84.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_main_runTests_ControlFlow84.SetSource(PolymorphismTest_main_runTests_Call_U_o1_);
						PolymorphismTest_main_runTests_ControlFlow84.SetTarget(PolymorphismTest_main_runTests_Call_o2_);
					PolymorphismTest_main_runTests.AddEdge(PolymorphismTest_main_runTests_ControlFlow84);
						// ObjectFlow ObjectFlow96 from u_node to Fork u
						PolymorphismTest_main_runTests_ObjectFlow96.SetName("ObjectFlow96");
						PolymorphismTest_main_runTests_ObjectFlow96.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_main_runTests_ObjectFlow96.SetSource(PolymorphismTest_main_runTests_u_node);
						PolymorphismTest_main_runTests_ObjectFlow96.SetTarget(PolymorphismTest_main_runTests_Fork_u);
							// LiteralBoolean LiteralBoolean97
							PolymorphismTest_main_runTests_ObjectFlow96_LiteralBoolean97.SetName("LiteralBoolean97");
							PolymorphismTest_main_runTests_ObjectFlow96_LiteralBoolean97.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_main_runTests_ObjectFlow96_LiteralBoolean97.SetValue(true);
						PolymorphismTest_main_runTests_ObjectFlow96.SetGuard(PolymorphismTest_main_runTests_ObjectFlow96_LiteralBoolean97);
					PolymorphismTest_main_runTests.AddEdge(PolymorphismTest_main_runTests_ObjectFlow96);
						// ObjectFlow ObjectFlow101 from Fork u to target
						PolymorphismTest_main_runTests_ObjectFlow101.SetName("ObjectFlow101");
						PolymorphismTest_main_runTests_ObjectFlow101.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_main_runTests_ObjectFlow101.SetSource(PolymorphismTest_main_runTests_Fork_u);
						PolymorphismTest_main_runTests_ObjectFlow101.SetTarget(PolymorphismTest_main_runTests_Call_U_o1__target);
							// LiteralBoolean LiteralBoolean102
							PolymorphismTest_main_runTests_ObjectFlow101_LiteralBoolean102.SetName("LiteralBoolean102");
							PolymorphismTest_main_runTests_ObjectFlow101_LiteralBoolean102.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_main_runTests_ObjectFlow101_LiteralBoolean102.SetValue(true);
						PolymorphismTest_main_runTests_ObjectFlow101.SetGuard(PolymorphismTest_main_runTests_ObjectFlow101_LiteralBoolean102);
					PolymorphismTest_main_runTests.AddEdge(PolymorphismTest_main_runTests_ObjectFlow101);
						// ObjectFlow ObjectFlow104 from Fork u to target
						PolymorphismTest_main_runTests_ObjectFlow104.SetName("ObjectFlow104");
						PolymorphismTest_main_runTests_ObjectFlow104.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_main_runTests_ObjectFlow104.SetSource(PolymorphismTest_main_runTests_Fork_u);
						PolymorphismTest_main_runTests_ObjectFlow104.SetTarget(PolymorphismTest_main_runTests_Call_o2__target);
							// LiteralBoolean LiteralBoolean106
							PolymorphismTest_main_runTests_ObjectFlow104_LiteralBoolean106.SetName("LiteralBoolean106");
							PolymorphismTest_main_runTests_ObjectFlow104_LiteralBoolean106.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_main_runTests_ObjectFlow104_LiteralBoolean106.SetValue(true);
						PolymorphismTest_main_runTests_ObjectFlow104.SetGuard(PolymorphismTest_main_runTests_ObjectFlow104_LiteralBoolean106);
					PolymorphismTest_main_runTests.AddEdge(PolymorphismTest_main_runTests_ObjectFlow104);
						// ObjectFlow ObjectFlow107 from Fork u to target
						PolymorphismTest_main_runTests_ObjectFlow107.SetName("ObjectFlow107");
						PolymorphismTest_main_runTests_ObjectFlow107.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_main_runTests_ObjectFlow107.SetSource(PolymorphismTest_main_runTests_Fork_u);
						PolymorphismTest_main_runTests_ObjectFlow107.SetTarget(PolymorphismTest_main_runTests_Call_o3__target);
							// LiteralBoolean LiteralBoolean109
							PolymorphismTest_main_runTests_ObjectFlow107_LiteralBoolean109.SetName("LiteralBoolean109");
							PolymorphismTest_main_runTests_ObjectFlow107_LiteralBoolean109.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_main_runTests_ObjectFlow107_LiteralBoolean109.SetValue(true);
						PolymorphismTest_main_runTests_ObjectFlow107.SetGuard(PolymorphismTest_main_runTests_ObjectFlow107_LiteralBoolean109);
					PolymorphismTest_main_runTests.AddEdge(PolymorphismTest_main_runTests_ObjectFlow107);
						// ControlFlow ControlFlow110 from Call o2() to Call o3()
						PolymorphismTest_main_runTests_ControlFlow110.SetName("ControlFlow110");
						PolymorphismTest_main_runTests_ControlFlow110.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_main_runTests_ControlFlow110.SetSource(PolymorphismTest_main_runTests_Call_o2_);
						PolymorphismTest_main_runTests_ControlFlow110.SetTarget(PolymorphismTest_main_runTests_Call_o3_);
					PolymorphismTest_main_runTests.AddEdge(PolymorphismTest_main_runTests_ControlFlow110);
						// ControlFlow ControlFlow112 from Call o1() to Call U::o1()
						PolymorphismTest_main_runTests_ControlFlow112.SetName("ControlFlow112");
						PolymorphismTest_main_runTests_ControlFlow112.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_main_runTests_ControlFlow112.SetSource(PolymorphismTest_main_runTests_Call_o1_);
						PolymorphismTest_main_runTests_ControlFlow112.SetTarget(PolymorphismTest_main_runTests_Call_U_o1_);
					PolymorphismTest_main_runTests.AddEdge(PolymorphismTest_main_runTests_ControlFlow112);
						// ObjectFlow ObjectFlow120 from Fork u to target
						PolymorphismTest_main_runTests_ObjectFlow120.SetName("ObjectFlow120");
						PolymorphismTest_main_runTests_ObjectFlow120.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_main_runTests_ObjectFlow120.SetSource(PolymorphismTest_main_runTests_Fork_u);
						PolymorphismTest_main_runTests_ObjectFlow120.SetTarget(PolymorphismTest_main_runTests_Call_o1__target);
							// LiteralBoolean LiteralBoolean121
							PolymorphismTest_main_runTests_ObjectFlow120_LiteralBoolean121.SetName("LiteralBoolean121");
							PolymorphismTest_main_runTests_ObjectFlow120_LiteralBoolean121.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_main_runTests_ObjectFlow120_LiteralBoolean121.SetValue(true);
						PolymorphismTest_main_runTests_ObjectFlow120.SetGuard(PolymorphismTest_main_runTests_ObjectFlow120_LiteralBoolean121);
					PolymorphismTest_main_runTests.AddEdge(PolymorphismTest_main_runTests_ObjectFlow120);
						// ObjectFlow ObjectFlow123 from Fork u to target
						PolymorphismTest_main_runTests_ObjectFlow123.SetName("ObjectFlow123");
						PolymorphismTest_main_runTests_ObjectFlow123.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_main_runTests_ObjectFlow123.SetSource(PolymorphismTest_main_runTests_Fork_u);
						PolymorphismTest_main_runTests_ObjectFlow123.SetTarget(PolymorphismTest_main_runTests_Call_A_x__target);
							// LiteralBoolean LiteralBoolean124
							PolymorphismTest_main_runTests_ObjectFlow123_LiteralBoolean124.SetName("LiteralBoolean124");
							PolymorphismTest_main_runTests_ObjectFlow123_LiteralBoolean124.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_main_runTests_ObjectFlow123_LiteralBoolean124.SetValue(true);
						PolymorphismTest_main_runTests_ObjectFlow123.SetGuard(PolymorphismTest_main_runTests_ObjectFlow123_LiteralBoolean124);
					PolymorphismTest_main_runTests.AddEdge(PolymorphismTest_main_runTests_ObjectFlow123);
						// ControlFlow ControlFlow126 from Call A::x() to Call o1()
						PolymorphismTest_main_runTests_ControlFlow126.SetName("ControlFlow126");
						PolymorphismTest_main_runTests_ControlFlow126.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_main_runTests_ControlFlow126.SetSource(PolymorphismTest_main_runTests_Call_A_x_);
						PolymorphismTest_main_runTests_ControlFlow126.SetTarget(PolymorphismTest_main_runTests_Call_o1_);
					PolymorphismTest_main_runTests.AddEdge(PolymorphismTest_main_runTests_ControlFlow126);
						// ControlFlow ControlFlow127 from Call o3() to Call o4()
						PolymorphismTest_main_runTests_ControlFlow127.SetName("ControlFlow127");
						PolymorphismTest_main_runTests_ControlFlow127.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_main_runTests_ControlFlow127.SetSource(PolymorphismTest_main_runTests_Call_o3_);
						PolymorphismTest_main_runTests_ControlFlow127.SetTarget(PolymorphismTest_main_runTests_Call_o4_);
					PolymorphismTest_main_runTests.AddEdge(PolymorphismTest_main_runTests_ControlFlow127);
				PolymorphismTest_main.AddOwnedBehavior(PolymorphismTest_main_runTests);
					// CallBehaviorAction Call runTests
					PolymorphismTest_main_Call_runTests.SetName("Call runTests");
					PolymorphismTest_main_Call_runTests.SetVisibility(VisibilityKind.public_);
					PolymorphismTest_main_Call_runTests.SetBehavior(PolymorphismTest_main_runTests);
						// InputPin u
						PolymorphismTest_main_Call_runTests_u.SetName("u");
						PolymorphismTest_main_Call_runTests_u.SetVisibility(VisibilityKind.public_);
						PolymorphismTest_main_Call_runTests_u.SetType(PolymorphismTest_U);
					PolymorphismTest_main_Call_runTests.AddArgument(PolymorphismTest_main_Call_runTests_u);
				PolymorphismTest_main.AddNode(PolymorphismTest_main_Call_runTests);
					// CreateObjectAction Create S
					PolymorphismTest_main_Create_S.SetName("Create S");
					PolymorphismTest_main_Create_S.SetVisibility(VisibilityKind.public_);
					PolymorphismTest_main_Create_S.SetClassifier(PolymorphismTest_S);
						// OutputPin result
						PolymorphismTest_main_Create_S_result.SetName("result");
						PolymorphismTest_main_Create_S_result.SetVisibility(VisibilityKind.public_);
						PolymorphismTest_main_Create_S_result.SetType(PolymorphismTest_S);
					PolymorphismTest_main_Create_S.SetResult(PolymorphismTest_main_Create_S_result);
				PolymorphismTest_main.AddNode(PolymorphismTest_main_Create_S);
					// ObjectFlow ObjectFlow137 from result to u
					PolymorphismTest_main_ObjectFlow137.SetName("ObjectFlow137");
					PolymorphismTest_main_ObjectFlow137.SetVisibility(VisibilityKind.public_);
					
					PolymorphismTest_main_ObjectFlow137.SetSource(PolymorphismTest_main_Create_S_result);
					PolymorphismTest_main_ObjectFlow137.SetTarget(PolymorphismTest_main_Call_runTests_u);
						// LiteralBoolean LiteralBoolean138
						PolymorphismTest_main_ObjectFlow137_LiteralBoolean138.SetName("LiteralBoolean138");
						PolymorphismTest_main_ObjectFlow137_LiteralBoolean138.SetVisibility(VisibilityKind.public_);
						PolymorphismTest_main_ObjectFlow137_LiteralBoolean138.SetValue(true);
					PolymorphismTest_main_ObjectFlow137.SetGuard(PolymorphismTest_main_ObjectFlow137_LiteralBoolean138);
				PolymorphismTest_main.AddEdge(PolymorphismTest_main_ObjectFlow137);
			PolymorphismTest.AddPackagedElement(PolymorphismTest_main);
				// Class T
				PolymorphismTest_T.SetName("T");
				PolymorphismTest_T.SetVisibility(VisibilityKind.public_);
				
					// Generalization to U
					PolymorphismTest_T_Generalization179.SetGeneral(PolymorphismTest_U);
				PolymorphismTest_T.AddGeneralization(PolymorphismTest_T_Generalization179);
				// Activity o4_method
					PolymorphismTest_T_o4_method.SetName("o4_method");
					PolymorphismTest_T_o4_method.SetVisibility(VisibilityKind.public_);
						// ValueSpecificationAction Message
						PolymorphismTest_T_o4_method_Message.SetName("Message");
						PolymorphismTest_T_o4_method_Message.SetVisibility(VisibilityKind.public_);
							// LiteralString LiteralString142
							PolymorphismTest_T_o4_method_Message_LiteralString142.SetName("LiteralString142");
							PolymorphismTest_T_o4_method_Message_LiteralString142.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_T_o4_method_Message_LiteralString142.SetValue("T::o4()");
						PolymorphismTest_T_o4_method_Message.SetValue(PolymorphismTest_T_o4_method_Message_LiteralString142);
							// OutputPin result
							PolymorphismTest_T_o4_method_Message_result.SetName("result");
							PolymorphismTest_T_o4_method_Message_result.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_T_o4_method_Message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						PolymorphismTest_T_o4_method_Message.SetResult(PolymorphismTest_T_o4_method_Message_result);
					PolymorphismTest_T_o4_method.AddNode(PolymorphismTest_T_o4_method_Message);
						// CallBehaviorAction Call WriteLine
						PolymorphismTest_T_o4_method_Call_WriteLine.SetName("Call WriteLine");
						PolymorphismTest_T_o4_method_Call_WriteLine.SetVisibility(VisibilityKind.public_);
						
							// OutputPin errorStatus
							PolymorphismTest_T_o4_method_Call_WriteLine_errorStatus.SetName("errorStatus");
							PolymorphismTest_T_o4_method_Call_WriteLine_errorStatus.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_T_o4_method_Call_WriteLine_errorStatus.SetType(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_Common_Status);
							PolymorphismTest_T_o4_method_Call_WriteLine_errorStatus.SetLower(0);
						PolymorphismTest_T_o4_method_Call_WriteLine.AddResult(PolymorphismTest_T_o4_method_Call_WriteLine_errorStatus);
						PolymorphismTest_T_o4_method_Call_WriteLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
							// InputPin value
							PolymorphismTest_T_o4_method_Call_WriteLine_value.SetName("value");
							PolymorphismTest_T_o4_method_Call_WriteLine_value.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_T_o4_method_Call_WriteLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						PolymorphismTest_T_o4_method_Call_WriteLine.AddArgument(PolymorphismTest_T_o4_method_Call_WriteLine_value);
					PolymorphismTest_T_o4_method.AddNode(PolymorphismTest_T_o4_method_Call_WriteLine);
						// ObjectFlow ObjectFlow149 from result to value
						PolymorphismTest_T_o4_method_ObjectFlow149.SetName("ObjectFlow149");
						PolymorphismTest_T_o4_method_ObjectFlow149.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_T_o4_method_ObjectFlow149.SetSource(PolymorphismTest_T_o4_method_Message_result);
						PolymorphismTest_T_o4_method_ObjectFlow149.SetTarget(PolymorphismTest_T_o4_method_Call_WriteLine_value);
							// LiteralBoolean LiteralBoolean150
							PolymorphismTest_T_o4_method_ObjectFlow149_LiteralBoolean150.SetName("LiteralBoolean150");
							PolymorphismTest_T_o4_method_ObjectFlow149_LiteralBoolean150.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_T_o4_method_ObjectFlow149_LiteralBoolean150.SetValue(true);
						PolymorphismTest_T_o4_method_ObjectFlow149.SetGuard(PolymorphismTest_T_o4_method_ObjectFlow149_LiteralBoolean150);
					PolymorphismTest_T_o4_method.AddEdge(PolymorphismTest_T_o4_method_ObjectFlow149);
				PolymorphismTest_T.AddOwnedBehavior(PolymorphismTest_T_o4_method);
					// Activity o1_method
					PolymorphismTest_T_o1_method.SetName("o1_method");
					PolymorphismTest_T_o1_method.SetVisibility(VisibilityKind.public_);
					
						// Parameter b
						PolymorphismTest_T_o1_method_b.SetName("b");
						PolymorphismTest_T_o1_method_b.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_T_o1_method_b.SetType(PolymorphismTest_B);
					PolymorphismTest_T_o1_method.AddOwnedParameter(PolymorphismTest_T_o1_method_b);
						// Parameter a
						PolymorphismTest_T_o1_method_a.SetName("a");
						PolymorphismTest_T_o1_method_a.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_T_o1_method_a.SetType(PolymorphismTest_A);
						PolymorphismTest_T_o1_method_a.SetDirection(ParameterDirectionKind.return_);
					PolymorphismTest_T_o1_method.AddOwnedParameter(PolymorphismTest_T_o1_method_a);
						// ValueSpecificationAction Message
						PolymorphismTest_T_o1_method_Message.SetName("Message");
						PolymorphismTest_T_o1_method_Message.SetVisibility(VisibilityKind.public_);
							// LiteralString LiteralString152
							PolymorphismTest_T_o1_method_Message_LiteralString152.SetName("LiteralString152");
							PolymorphismTest_T_o1_method_Message_LiteralString152.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_T_o1_method_Message_LiteralString152.SetValue("T::o1(b : B) : A");
						PolymorphismTest_T_o1_method_Message.SetValue(PolymorphismTest_T_o1_method_Message_LiteralString152);
							// OutputPin result
							PolymorphismTest_T_o1_method_Message_result.SetName("result");
							PolymorphismTest_T_o1_method_Message_result.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_T_o1_method_Message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						PolymorphismTest_T_o1_method_Message.SetResult(PolymorphismTest_T_o1_method_Message_result);
					PolymorphismTest_T_o1_method.AddNode(PolymorphismTest_T_o1_method_Message);
						// CallBehaviorAction Call WriteLine
						PolymorphismTest_T_o1_method_Call_WriteLine.SetName("Call WriteLine");
						PolymorphismTest_T_o1_method_Call_WriteLine.SetVisibility(VisibilityKind.public_);
						
							// OutputPin errorStatus
							PolymorphismTest_T_o1_method_Call_WriteLine_errorStatus.SetName("errorStatus");
							PolymorphismTest_T_o1_method_Call_WriteLine_errorStatus.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_T_o1_method_Call_WriteLine_errorStatus.SetType(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_Common_Status);
							PolymorphismTest_T_o1_method_Call_WriteLine_errorStatus.SetLower(0);
						PolymorphismTest_T_o1_method_Call_WriteLine.AddResult(PolymorphismTest_T_o1_method_Call_WriteLine_errorStatus);
						PolymorphismTest_T_o1_method_Call_WriteLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
							// InputPin value
							PolymorphismTest_T_o1_method_Call_WriteLine_value.SetName("value");
							PolymorphismTest_T_o1_method_Call_WriteLine_value.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_T_o1_method_Call_WriteLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						PolymorphismTest_T_o1_method_Call_WriteLine.AddArgument(PolymorphismTest_T_o1_method_Call_WriteLine_value);
					PolymorphismTest_T_o1_method.AddNode(PolymorphismTest_T_o1_method_Call_WriteLine);
						// ActivityParameterNode b_node
						PolymorphismTest_T_o1_method_b_node.SetName("b_node");
						PolymorphismTest_T_o1_method_b_node.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_T_o1_method_b_node.SetParameter(PolymorphismTest_T_o1_method_b);
					PolymorphismTest_T_o1_method.AddNode(PolymorphismTest_T_o1_method_b_node);
						// ActivityParameterNode a_node
						PolymorphismTest_T_o1_method_a_node.SetName("a_node");
						PolymorphismTest_T_o1_method_a_node.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_T_o1_method_a_node.SetParameter(PolymorphismTest_T_o1_method_a);
					PolymorphismTest_T_o1_method.AddNode(PolymorphismTest_T_o1_method_a_node);
						// ObjectFlow ObjectFlow163 from result to value
						PolymorphismTest_T_o1_method_ObjectFlow163.SetName("ObjectFlow163");
						PolymorphismTest_T_o1_method_ObjectFlow163.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_T_o1_method_ObjectFlow163.SetSource(PolymorphismTest_T_o1_method_Message_result);
						PolymorphismTest_T_o1_method_ObjectFlow163.SetTarget(PolymorphismTest_T_o1_method_Call_WriteLine_value);
							// LiteralBoolean LiteralBoolean164
							PolymorphismTest_T_o1_method_ObjectFlow163_LiteralBoolean164.SetName("LiteralBoolean164");
							PolymorphismTest_T_o1_method_ObjectFlow163_LiteralBoolean164.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_T_o1_method_ObjectFlow163_LiteralBoolean164.SetValue(true);
						PolymorphismTest_T_o1_method_ObjectFlow163.SetGuard(PolymorphismTest_T_o1_method_ObjectFlow163_LiteralBoolean164);
					PolymorphismTest_T_o1_method.AddEdge(PolymorphismTest_T_o1_method_ObjectFlow163);
				PolymorphismTest_T.AddOwnedBehavior(PolymorphismTest_T_o1_method);
					// Activity o3_method
					PolymorphismTest_T_o3_method.SetName("o3_method");
					PolymorphismTest_T_o3_method.SetVisibility(VisibilityKind.public_);
					
						// Parameter i
						PolymorphismTest_T_o3_method_i.SetName("i");
						PolymorphismTest_T_o3_method_i.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_T_o3_method_i.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					PolymorphismTest_T_o3_method.AddOwnedParameter(PolymorphismTest_T_o3_method_i);
						// CallBehaviorAction Call WriteLine
						PolymorphismTest_T_o3_method_Call_WriteLine.SetName("Call WriteLine");
						PolymorphismTest_T_o3_method_Call_WriteLine.SetVisibility(VisibilityKind.public_);
						
							// OutputPin errorStatus
							PolymorphismTest_T_o3_method_Call_WriteLine_errorStatus.SetName("errorStatus");
							PolymorphismTest_T_o3_method_Call_WriteLine_errorStatus.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_T_o3_method_Call_WriteLine_errorStatus.SetType(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_Common_Status);
							PolymorphismTest_T_o3_method_Call_WriteLine_errorStatus.SetLower(0);
						PolymorphismTest_T_o3_method_Call_WriteLine.AddResult(PolymorphismTest_T_o3_method_Call_WriteLine_errorStatus);
						PolymorphismTest_T_o3_method_Call_WriteLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
							// InputPin value
							PolymorphismTest_T_o3_method_Call_WriteLine_value.SetName("value");
							PolymorphismTest_T_o3_method_Call_WriteLine_value.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_T_o3_method_Call_WriteLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						PolymorphismTest_T_o3_method_Call_WriteLine.AddArgument(PolymorphismTest_T_o3_method_Call_WriteLine_value);
					PolymorphismTest_T_o3_method.AddNode(PolymorphismTest_T_o3_method_Call_WriteLine);
						// ActivityParameterNode i_node
						PolymorphismTest_T_o3_method_i_node.SetName("i_node");
						PolymorphismTest_T_o3_method_i_node.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_T_o3_method_i_node.SetParameter(PolymorphismTest_T_o3_method_i);
					PolymorphismTest_T_o3_method.AddNode(PolymorphismTest_T_o3_method_i_node);
						// ValueSpecificationAction Message
						PolymorphismTest_T_o3_method_Message.SetName("Message");
						PolymorphismTest_T_o3_method_Message.SetVisibility(VisibilityKind.public_);
							// LiteralString LiteralString178
							PolymorphismTest_T_o3_method_Message_LiteralString178.SetName("LiteralString178");
							PolymorphismTest_T_o3_method_Message_LiteralString178.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_T_o3_method_Message_LiteralString178.SetValue("T::o3(i : int)");
						PolymorphismTest_T_o3_method_Message.SetValue(PolymorphismTest_T_o3_method_Message_LiteralString178);
							// OutputPin result
							PolymorphismTest_T_o3_method_Message_result.SetName("result");
							PolymorphismTest_T_o3_method_Message_result.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_T_o3_method_Message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						PolymorphismTest_T_o3_method_Message.SetResult(PolymorphismTest_T_o3_method_Message_result);
					PolymorphismTest_T_o3_method.AddNode(PolymorphismTest_T_o3_method_Message);
						// ObjectFlow ObjectFlow166 from result to value
						PolymorphismTest_T_o3_method_ObjectFlow166.SetName("ObjectFlow166");
						PolymorphismTest_T_o3_method_ObjectFlow166.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_T_o3_method_ObjectFlow166.SetSource(PolymorphismTest_T_o3_method_Message_result);
						PolymorphismTest_T_o3_method_ObjectFlow166.SetTarget(PolymorphismTest_T_o3_method_Call_WriteLine_value);
							// LiteralBoolean LiteralBoolean168
							PolymorphismTest_T_o3_method_ObjectFlow166_LiteralBoolean168.SetName("LiteralBoolean168");
							PolymorphismTest_T_o3_method_ObjectFlow166_LiteralBoolean168.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_T_o3_method_ObjectFlow166_LiteralBoolean168.SetValue(true);
						PolymorphismTest_T_o3_method_ObjectFlow166.SetGuard(PolymorphismTest_T_o3_method_ObjectFlow166_LiteralBoolean168);
					PolymorphismTest_T_o3_method.AddEdge(PolymorphismTest_T_o3_method_ObjectFlow166);
				PolymorphismTest_T.AddOwnedBehavior(PolymorphismTest_T_o3_method);
					// Activity o2_method
					PolymorphismTest_T_o2_method.SetName("o2_method");
					PolymorphismTest_T_o2_method.SetVisibility(VisibilityKind.public_);
					
						// Parameter b
						PolymorphismTest_T_o2_method_b.SetName("b");
						PolymorphismTest_T_o2_method_b.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_T_o2_method_b.SetType(PolymorphismTest_B);
					PolymorphismTest_T_o2_method.AddOwnedParameter(PolymorphismTest_T_o2_method_b);
						// Parameter result
						PolymorphismTest_T_o2_method_result.SetName("result");
						PolymorphismTest_T_o2_method_result.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_T_o2_method_result.SetType(PolymorphismTest_B);
						PolymorphismTest_T_o2_method_result.SetDirection(ParameterDirectionKind.return_);
					PolymorphismTest_T_o2_method.AddOwnedParameter(PolymorphismTest_T_o2_method_result);
						// CallBehaviorAction Call WriteLine
						PolymorphismTest_T_o2_method_Call_WriteLine.SetName("Call WriteLine");
						PolymorphismTest_T_o2_method_Call_WriteLine.SetVisibility(VisibilityKind.public_);
						
							// OutputPin errorStatus
							PolymorphismTest_T_o2_method_Call_WriteLine_errorStatus.SetName("errorStatus");
							PolymorphismTest_T_o2_method_Call_WriteLine_errorStatus.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_T_o2_method_Call_WriteLine_errorStatus.SetType(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_Common_Status);
							PolymorphismTest_T_o2_method_Call_WriteLine_errorStatus.SetLower(0);
						PolymorphismTest_T_o2_method_Call_WriteLine.AddResult(PolymorphismTest_T_o2_method_Call_WriteLine_errorStatus);
						PolymorphismTest_T_o2_method_Call_WriteLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
							// InputPin value
							PolymorphismTest_T_o2_method_Call_WriteLine_value.SetName("value");
							PolymorphismTest_T_o2_method_Call_WriteLine_value.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_T_o2_method_Call_WriteLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						PolymorphismTest_T_o2_method_Call_WriteLine.AddArgument(PolymorphismTest_T_o2_method_Call_WriteLine_value);
					PolymorphismTest_T_o2_method.AddNode(PolymorphismTest_T_o2_method_Call_WriteLine);
						// ValueSpecificationAction Message
						PolymorphismTest_T_o2_method_Message.SetName("Message");
						PolymorphismTest_T_o2_method_Message.SetVisibility(VisibilityKind.public_);
							// LiteralString LiteralString191
							PolymorphismTest_T_o2_method_Message_LiteralString191.SetName("LiteralString191");
							PolymorphismTest_T_o2_method_Message_LiteralString191.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_T_o2_method_Message_LiteralString191.SetValue("T::o2(b : B) : B");
						PolymorphismTest_T_o2_method_Message.SetValue(PolymorphismTest_T_o2_method_Message_LiteralString191);
							// OutputPin result
							PolymorphismTest_T_o2_method_Message_result.SetName("result");
							PolymorphismTest_T_o2_method_Message_result.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_T_o2_method_Message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						PolymorphismTest_T_o2_method_Message.SetResult(PolymorphismTest_T_o2_method_Message_result);
					PolymorphismTest_T_o2_method.AddNode(PolymorphismTest_T_o2_method_Message);
						// ActivityParameterNode b_node
						PolymorphismTest_T_o2_method_b_node.SetName("b_node");
						PolymorphismTest_T_o2_method_b_node.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_T_o2_method_b_node.SetParameter(PolymorphismTest_T_o2_method_b);
					PolymorphismTest_T_o2_method.AddNode(PolymorphismTest_T_o2_method_b_node);
						// ActivityParameterNode result_node
						PolymorphismTest_T_o2_method_result_node.SetName("result_node");
						PolymorphismTest_T_o2_method_result_node.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_T_o2_method_result_node.SetParameter(PolymorphismTest_T_o2_method_result);
					PolymorphismTest_T_o2_method.AddNode(PolymorphismTest_T_o2_method_result_node);
						// ObjectFlow ObjectFlow180 from result to value
						PolymorphismTest_T_o2_method_ObjectFlow180.SetName("ObjectFlow180");
						PolymorphismTest_T_o2_method_ObjectFlow180.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_T_o2_method_ObjectFlow180.SetSource(PolymorphismTest_T_o2_method_Message_result);
						PolymorphismTest_T_o2_method_ObjectFlow180.SetTarget(PolymorphismTest_T_o2_method_Call_WriteLine_value);
							// LiteralBoolean LiteralBoolean182
							PolymorphismTest_T_o2_method_ObjectFlow180_LiteralBoolean182.SetName("LiteralBoolean182");
							PolymorphismTest_T_o2_method_ObjectFlow180_LiteralBoolean182.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_T_o2_method_ObjectFlow180_LiteralBoolean182.SetValue(true);
						PolymorphismTest_T_o2_method_ObjectFlow180.SetGuard(PolymorphismTest_T_o2_method_ObjectFlow180_LiteralBoolean182);
					PolymorphismTest_T_o2_method.AddEdge(PolymorphismTest_T_o2_method_ObjectFlow180);
				PolymorphismTest_T.AddOwnedBehavior(PolymorphismTest_T_o2_method);
				
					// Operation A_o1_B
					PolymorphismTest_T_A_o1_B.SetName("o1");
					PolymorphismTest_T_A_o1_B.SetVisibility(VisibilityKind.public_);
						// Parameter b
						PolymorphismTest_T_A_o1_B_b.SetName("b");
						PolymorphismTest_T_A_o1_B_b.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_T_A_o1_B_b.SetType(PolymorphismTest_B);
					PolymorphismTest_T_A_o1_B.AddOwnedParameter(PolymorphismTest_T_A_o1_B_b);
						// Parameter a
						PolymorphismTest_T_A_o1_B_a.SetName("a");
						PolymorphismTest_T_A_o1_B_a.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_T_A_o1_B_a.SetType(PolymorphismTest_A);
						PolymorphismTest_T_A_o1_B_a.SetDirection(ParameterDirectionKind.return_);
					PolymorphismTest_T_A_o1_B.AddOwnedParameter(PolymorphismTest_T_A_o1_B_a);
					PolymorphismTest_T_A_o1_B.AddMethod(PolymorphismTest_T_o1_method);
					PolymorphismTest_T_A_o1_B.AddRedefinedOperation(PolymorphismTest_U_A_o1_B);
				PolymorphismTest_T.AddOwnedOperation(PolymorphismTest_T_A_o1_B);
					// Operation B_o2_B
					PolymorphismTest_T_B_o2_B.SetName("o2");
					PolymorphismTest_T_B_o2_B.SetVisibility(VisibilityKind.public_);
						// Parameter b
						PolymorphismTest_T_B_o2_B_b.SetName("b");
						PolymorphismTest_T_B_o2_B_b.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_T_B_o2_B_b.SetType(PolymorphismTest_B);
					PolymorphismTest_T_B_o2_B.AddOwnedParameter(PolymorphismTest_T_B_o2_B_b);
						// Parameter result
						PolymorphismTest_T_B_o2_B_result.SetName("result");
						PolymorphismTest_T_B_o2_B_result.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_T_B_o2_B_result.SetType(PolymorphismTest_B);
						PolymorphismTest_T_B_o2_B_result.SetDirection(ParameterDirectionKind.return_);
					PolymorphismTest_T_B_o2_B.AddOwnedParameter(PolymorphismTest_T_B_o2_B_result);
					PolymorphismTest_T_B_o2_B.AddMethod(PolymorphismTest_T_o2_method);
					PolymorphismTest_T_B_o2_B.AddRedefinedOperation(PolymorphismTest_U_A_o2_B);
				PolymorphismTest_T.AddOwnedOperation(PolymorphismTest_T_B_o2_B);
					// Operation o3_Integer
					PolymorphismTest_T_o3_Integer.SetName("o3");
					PolymorphismTest_T_o3_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter i
						PolymorphismTest_T_o3_Integer_i.SetName("i");
						PolymorphismTest_T_o3_Integer_i.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_T_o3_Integer_i.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					PolymorphismTest_T_o3_Integer.AddOwnedParameter(PolymorphismTest_T_o3_Integer_i);
					PolymorphismTest_T_o3_Integer.AddMethod(PolymorphismTest_T_o3_method);
					PolymorphismTest_T_o3_Integer.AddRedefinedOperation(PolymorphismTest_U_o3_Integer);
				PolymorphismTest_T.AddOwnedOperation(PolymorphismTest_T_o3_Integer);
					// Operation o4
					PolymorphismTest_T_o4.SetName("o4");
					PolymorphismTest_T_o4.SetVisibility(VisibilityKind.public_);
					PolymorphismTest_T_o4.AddMethod(PolymorphismTest_T_o4_method);
					PolymorphismTest_T_o4.AddRedefinedOperation(PolymorphismTest_U_o4);
				PolymorphismTest_T.AddOwnedOperation(PolymorphismTest_T_o4);
			PolymorphismTest.AddPackagedElement(PolymorphismTest_T);
				// Class S
				PolymorphismTest_S.SetName("S");
				PolymorphismTest_S.SetVisibility(VisibilityKind.public_);
				
					// Generalization to T
					PolymorphismTest_S_Generalization232.SetGeneral(PolymorphismTest_T);
				PolymorphismTest_S.AddGeneralization(PolymorphismTest_S_Generalization232);
				// Activity o1_method
					PolymorphismTest_S_o1_method.SetName("o1_method");
					PolymorphismTest_S_o1_method.SetVisibility(VisibilityKind.public_);
					
						// Parameter b
						PolymorphismTest_S_o1_method_b.SetName("b");
						PolymorphismTest_S_o1_method_b.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_S_o1_method_b.SetType(PolymorphismTest_B);
					PolymorphismTest_S_o1_method.AddOwnedParameter(PolymorphismTest_S_o1_method_b);
						// Parameter a
						PolymorphismTest_S_o1_method_a.SetName("a");
						PolymorphismTest_S_o1_method_a.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_S_o1_method_a.SetType(PolymorphismTest_A);
						PolymorphismTest_S_o1_method_a.SetDirection(ParameterDirectionKind.return_);
					PolymorphismTest_S_o1_method.AddOwnedParameter(PolymorphismTest_S_o1_method_a);
						// ActivityParameterNode a_node
						PolymorphismTest_S_o1_method_a_node.SetName("a_node");
						PolymorphismTest_S_o1_method_a_node.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_S_o1_method_a_node.SetParameter(PolymorphismTest_S_o1_method_a);
					PolymorphismTest_S_o1_method.AddNode(PolymorphismTest_S_o1_method_a_node);
						// ValueSpecificationAction Message
						PolymorphismTest_S_o1_method_Message.SetName("Message");
						PolymorphismTest_S_o1_method_Message.SetVisibility(VisibilityKind.public_);
							// LiteralString LiteralString200
							PolymorphismTest_S_o1_method_Message_LiteralString200.SetName("LiteralString200");
							PolymorphismTest_S_o1_method_Message_LiteralString200.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_S_o1_method_Message_LiteralString200.SetValue("S::o1(b : B) : A");
						PolymorphismTest_S_o1_method_Message.SetValue(PolymorphismTest_S_o1_method_Message_LiteralString200);
							// OutputPin result
							PolymorphismTest_S_o1_method_Message_result.SetName("result");
							PolymorphismTest_S_o1_method_Message_result.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_S_o1_method_Message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						PolymorphismTest_S_o1_method_Message.SetResult(PolymorphismTest_S_o1_method_Message_result);
					PolymorphismTest_S_o1_method.AddNode(PolymorphismTest_S_o1_method_Message);
						// ActivityParameterNode b_node
						PolymorphismTest_S_o1_method_b_node.SetName("b_node");
						PolymorphismTest_S_o1_method_b_node.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_S_o1_method_b_node.SetParameter(PolymorphismTest_S_o1_method_b);
					PolymorphismTest_S_o1_method.AddNode(PolymorphismTest_S_o1_method_b_node);
						// CallBehaviorAction Call WriteLine
						PolymorphismTest_S_o1_method_Call_WriteLine.SetName("Call WriteLine");
						PolymorphismTest_S_o1_method_Call_WriteLine.SetVisibility(VisibilityKind.public_);
						
							// OutputPin errorStatus
							PolymorphismTest_S_o1_method_Call_WriteLine_errorStatus.SetName("errorStatus");
							PolymorphismTest_S_o1_method_Call_WriteLine_errorStatus.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_S_o1_method_Call_WriteLine_errorStatus.SetType(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_Common_Status);
							PolymorphismTest_S_o1_method_Call_WriteLine_errorStatus.SetLower(0);
						PolymorphismTest_S_o1_method_Call_WriteLine.AddResult(PolymorphismTest_S_o1_method_Call_WriteLine_errorStatus);
						PolymorphismTest_S_o1_method_Call_WriteLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
							// InputPin value
							PolymorphismTest_S_o1_method_Call_WriteLine_value.SetName("value");
							PolymorphismTest_S_o1_method_Call_WriteLine_value.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_S_o1_method_Call_WriteLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						PolymorphismTest_S_o1_method_Call_WriteLine.AddArgument(PolymorphismTest_S_o1_method_Call_WriteLine_value);
					PolymorphismTest_S_o1_method.AddNode(PolymorphismTest_S_o1_method_Call_WriteLine);
						// ObjectFlow ObjectFlow194 from result to value
						PolymorphismTest_S_o1_method_ObjectFlow194.SetName("ObjectFlow194");
						PolymorphismTest_S_o1_method_ObjectFlow194.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_S_o1_method_ObjectFlow194.SetSource(PolymorphismTest_S_o1_method_Message_result);
						PolymorphismTest_S_o1_method_ObjectFlow194.SetTarget(PolymorphismTest_S_o1_method_Call_WriteLine_value);
							// LiteralBoolean LiteralBoolean196
							PolymorphismTest_S_o1_method_ObjectFlow194_LiteralBoolean196.SetName("LiteralBoolean196");
							PolymorphismTest_S_o1_method_ObjectFlow194_LiteralBoolean196.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_S_o1_method_ObjectFlow194_LiteralBoolean196.SetValue(true);
						PolymorphismTest_S_o1_method_ObjectFlow194.SetGuard(PolymorphismTest_S_o1_method_ObjectFlow194_LiteralBoolean196);
					PolymorphismTest_S_o1_method.AddEdge(PolymorphismTest_S_o1_method_ObjectFlow194);
				PolymorphismTest_S.AddOwnedBehavior(PolymorphismTest_S_o1_method);
					// Activity o3_method
					PolymorphismTest_S_o3_method.SetName("o3_method");
					PolymorphismTest_S_o3_method.SetVisibility(VisibilityKind.public_);
						// ValueSpecificationAction Message
						PolymorphismTest_S_o3_method_Message.SetName("Message");
						PolymorphismTest_S_o3_method_Message.SetVisibility(VisibilityKind.public_);
							// LiteralString LiteralString211
							PolymorphismTest_S_o3_method_Message_LiteralString211.SetName("LiteralString211");
							PolymorphismTest_S_o3_method_Message_LiteralString211.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_S_o3_method_Message_LiteralString211.SetValue("S::o3()");
						PolymorphismTest_S_o3_method_Message.SetValue(PolymorphismTest_S_o3_method_Message_LiteralString211);
							// OutputPin result
							PolymorphismTest_S_o3_method_Message_result.SetName("result");
							PolymorphismTest_S_o3_method_Message_result.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_S_o3_method_Message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						PolymorphismTest_S_o3_method_Message.SetResult(PolymorphismTest_S_o3_method_Message_result);
					PolymorphismTest_S_o3_method.AddNode(PolymorphismTest_S_o3_method_Message);
						// CallBehaviorAction Call WriteLine
						PolymorphismTest_S_o3_method_Call_WriteLine.SetName("Call WriteLine");
						PolymorphismTest_S_o3_method_Call_WriteLine.SetVisibility(VisibilityKind.public_);
						
							// OutputPin errorStatus
							PolymorphismTest_S_o3_method_Call_WriteLine_errorStatus.SetName("errorStatus");
							PolymorphismTest_S_o3_method_Call_WriteLine_errorStatus.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_S_o3_method_Call_WriteLine_errorStatus.SetType(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_Common_Status);
							PolymorphismTest_S_o3_method_Call_WriteLine_errorStatus.SetLower(0);
						PolymorphismTest_S_o3_method_Call_WriteLine.AddResult(PolymorphismTest_S_o3_method_Call_WriteLine_errorStatus);
						PolymorphismTest_S_o3_method_Call_WriteLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
							// InputPin value
							PolymorphismTest_S_o3_method_Call_WriteLine_value.SetName("value");
							PolymorphismTest_S_o3_method_Call_WriteLine_value.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_S_o3_method_Call_WriteLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						PolymorphismTest_S_o3_method_Call_WriteLine.AddArgument(PolymorphismTest_S_o3_method_Call_WriteLine_value);
					PolymorphismTest_S_o3_method.AddNode(PolymorphismTest_S_o3_method_Call_WriteLine);
						// ObjectFlow ObjectFlow208 from result to value
						PolymorphismTest_S_o3_method_ObjectFlow208.SetName("ObjectFlow208");
						PolymorphismTest_S_o3_method_ObjectFlow208.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_S_o3_method_ObjectFlow208.SetSource(PolymorphismTest_S_o3_method_Message_result);
						PolymorphismTest_S_o3_method_ObjectFlow208.SetTarget(PolymorphismTest_S_o3_method_Call_WriteLine_value);
							// LiteralBoolean LiteralBoolean209
							PolymorphismTest_S_o3_method_ObjectFlow208_LiteralBoolean209.SetName("LiteralBoolean209");
							PolymorphismTest_S_o3_method_ObjectFlow208_LiteralBoolean209.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_S_o3_method_ObjectFlow208_LiteralBoolean209.SetValue(true);
						PolymorphismTest_S_o3_method_ObjectFlow208.SetGuard(PolymorphismTest_S_o3_method_ObjectFlow208_LiteralBoolean209);
					PolymorphismTest_S_o3_method.AddEdge(PolymorphismTest_S_o3_method_ObjectFlow208);
				PolymorphismTest_S.AddOwnedBehavior(PolymorphismTest_S_o3_method);
					// Activity o5_method
					PolymorphismTest_S_o5_method.SetName("o5_method");
					PolymorphismTest_S_o5_method.SetVisibility(VisibilityKind.public_);
						// CallBehaviorAction Call WriteLine
						PolymorphismTest_S_o5_method_Call_WriteLine.SetName("Call WriteLine");
						PolymorphismTest_S_o5_method_Call_WriteLine.SetVisibility(VisibilityKind.public_);
						
							// OutputPin errorStatus
							PolymorphismTest_S_o5_method_Call_WriteLine_errorStatus.SetName("errorStatus");
							PolymorphismTest_S_o5_method_Call_WriteLine_errorStatus.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_S_o5_method_Call_WriteLine_errorStatus.SetType(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_Common_Status);
							PolymorphismTest_S_o5_method_Call_WriteLine_errorStatus.SetLower(0);
						PolymorphismTest_S_o5_method_Call_WriteLine.AddResult(PolymorphismTest_S_o5_method_Call_WriteLine_errorStatus);
						PolymorphismTest_S_o5_method_Call_WriteLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
							// InputPin value
							PolymorphismTest_S_o5_method_Call_WriteLine_value.SetName("value");
							PolymorphismTest_S_o5_method_Call_WriteLine_value.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_S_o5_method_Call_WriteLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						PolymorphismTest_S_o5_method_Call_WriteLine.AddArgument(PolymorphismTest_S_o5_method_Call_WriteLine_value);
					PolymorphismTest_S_o5_method.AddNode(PolymorphismTest_S_o5_method_Call_WriteLine);
						// ValueSpecificationAction Message
						PolymorphismTest_S_o5_method_Message.SetName("Message");
						PolymorphismTest_S_o5_method_Message.SetVisibility(VisibilityKind.public_);
							// LiteralString LiteralString226
							PolymorphismTest_S_o5_method_Message_LiteralString226.SetName("LiteralString226");
							PolymorphismTest_S_o5_method_Message_LiteralString226.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_S_o5_method_Message_LiteralString226.SetValue("S::o5()");
						PolymorphismTest_S_o5_method_Message.SetValue(PolymorphismTest_S_o5_method_Message_LiteralString226);
							// OutputPin result
							PolymorphismTest_S_o5_method_Message_result.SetName("result");
							PolymorphismTest_S_o5_method_Message_result.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_S_o5_method_Message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						PolymorphismTest_S_o5_method_Message.SetResult(PolymorphismTest_S_o5_method_Message_result);
					PolymorphismTest_S_o5_method.AddNode(PolymorphismTest_S_o5_method_Message);
						// ObjectFlow ObjectFlow229 from result to value
						PolymorphismTest_S_o5_method_ObjectFlow229.SetName("ObjectFlow229");
						PolymorphismTest_S_o5_method_ObjectFlow229.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_S_o5_method_ObjectFlow229.SetSource(PolymorphismTest_S_o5_method_Message_result);
						PolymorphismTest_S_o5_method_ObjectFlow229.SetTarget(PolymorphismTest_S_o5_method_Call_WriteLine_value);
							// LiteralBoolean LiteralBoolean231
							PolymorphismTest_S_o5_method_ObjectFlow229_LiteralBoolean231.SetName("LiteralBoolean231");
							PolymorphismTest_S_o5_method_ObjectFlow229_LiteralBoolean231.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_S_o5_method_ObjectFlow229_LiteralBoolean231.SetValue(true);
						PolymorphismTest_S_o5_method_ObjectFlow229.SetGuard(PolymorphismTest_S_o5_method_ObjectFlow229_LiteralBoolean231);
					PolymorphismTest_S_o5_method.AddEdge(PolymorphismTest_S_o5_method_ObjectFlow229);
				PolymorphismTest_S.AddOwnedBehavior(PolymorphismTest_S_o5_method);
					// Activity o2_method
					PolymorphismTest_S_o2_method.SetName("o2_method");
					PolymorphismTest_S_o2_method.SetVisibility(VisibilityKind.public_);
					
						// Parameter a
						PolymorphismTest_S_o2_method_a.SetName("a");
						PolymorphismTest_S_o2_method_a.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_S_o2_method_a.SetType(PolymorphismTest_A);
					PolymorphismTest_S_o2_method.AddOwnedParameter(PolymorphismTest_S_o2_method_a);
						// Parameter b
						PolymorphismTest_S_o2_method_b.SetName("b");
						PolymorphismTest_S_o2_method_b.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_S_o2_method_b.SetType(PolymorphismTest_B);
						PolymorphismTest_S_o2_method_b.SetDirection(ParameterDirectionKind.return_);
					PolymorphismTest_S_o2_method.AddOwnedParameter(PolymorphismTest_S_o2_method_b);
						// ActivityParameterNode a_node
						PolymorphismTest_S_o2_method_a_node.SetName("a_node");
						PolymorphismTest_S_o2_method_a_node.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_S_o2_method_a_node.SetParameter(PolymorphismTest_S_o2_method_a);
					PolymorphismTest_S_o2_method.AddNode(PolymorphismTest_S_o2_method_a_node);
						// ValueSpecificationAction Message
						PolymorphismTest_S_o2_method_Message.SetName("Message");
						PolymorphismTest_S_o2_method_Message.SetVisibility(VisibilityKind.public_);
							// LiteralString LiteralString234
							PolymorphismTest_S_o2_method_Message_LiteralString234.SetName("LiteralString234");
							PolymorphismTest_S_o2_method_Message_LiteralString234.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_S_o2_method_Message_LiteralString234.SetValue("S::o2(a : A) : B");
						PolymorphismTest_S_o2_method_Message.SetValue(PolymorphismTest_S_o2_method_Message_LiteralString234);
							// OutputPin result
							PolymorphismTest_S_o2_method_Message_result.SetName("result");
							PolymorphismTest_S_o2_method_Message_result.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_S_o2_method_Message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						PolymorphismTest_S_o2_method_Message.SetResult(PolymorphismTest_S_o2_method_Message_result);
					PolymorphismTest_S_o2_method.AddNode(PolymorphismTest_S_o2_method_Message);
						// CallBehaviorAction Call WriteLine
						PolymorphismTest_S_o2_method_Call_WriteLine.SetName("Call WriteLine");
						PolymorphismTest_S_o2_method_Call_WriteLine.SetVisibility(VisibilityKind.public_);
						
							// OutputPin errorStatus
							PolymorphismTest_S_o2_method_Call_WriteLine_errorStatus.SetName("errorStatus");
							PolymorphismTest_S_o2_method_Call_WriteLine_errorStatus.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_S_o2_method_Call_WriteLine_errorStatus.SetType(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_Common_Status);
							PolymorphismTest_S_o2_method_Call_WriteLine_errorStatus.SetLower(0);
						PolymorphismTest_S_o2_method_Call_WriteLine.AddResult(PolymorphismTest_S_o2_method_Call_WriteLine_errorStatus);
						PolymorphismTest_S_o2_method_Call_WriteLine.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
							// InputPin value
							PolymorphismTest_S_o2_method_Call_WriteLine_value.SetName("value");
							PolymorphismTest_S_o2_method_Call_WriteLine_value.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_S_o2_method_Call_WriteLine_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						PolymorphismTest_S_o2_method_Call_WriteLine.AddArgument(PolymorphismTest_S_o2_method_Call_WriteLine_value);
					PolymorphismTest_S_o2_method.AddNode(PolymorphismTest_S_o2_method_Call_WriteLine);
						// ActivityParameterNode b_node
						PolymorphismTest_S_o2_method_b_node.SetName("b_node");
						PolymorphismTest_S_o2_method_b_node.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_S_o2_method_b_node.SetParameter(PolymorphismTest_S_o2_method_b);
					PolymorphismTest_S_o2_method.AddNode(PolymorphismTest_S_o2_method_b_node);
						// ObjectFlow ObjectFlow244 from result to value
						PolymorphismTest_S_o2_method_ObjectFlow244.SetName("ObjectFlow244");
						PolymorphismTest_S_o2_method_ObjectFlow244.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_S_o2_method_ObjectFlow244.SetSource(PolymorphismTest_S_o2_method_Message_result);
						PolymorphismTest_S_o2_method_ObjectFlow244.SetTarget(PolymorphismTest_S_o2_method_Call_WriteLine_value);
							// LiteralBoolean LiteralBoolean246
							PolymorphismTest_S_o2_method_ObjectFlow244_LiteralBoolean246.SetName("LiteralBoolean246");
							PolymorphismTest_S_o2_method_ObjectFlow244_LiteralBoolean246.SetVisibility(VisibilityKind.public_);
							PolymorphismTest_S_o2_method_ObjectFlow244_LiteralBoolean246.SetValue(true);
						PolymorphismTest_S_o2_method_ObjectFlow244.SetGuard(PolymorphismTest_S_o2_method_ObjectFlow244_LiteralBoolean246);
					PolymorphismTest_S_o2_method.AddEdge(PolymorphismTest_S_o2_method_ObjectFlow244);
				PolymorphismTest_S.AddOwnedBehavior(PolymorphismTest_S_o2_method);
				
					// Operation A_o1_B
					PolymorphismTest_S_A_o1_B.SetName("o1");
					PolymorphismTest_S_A_o1_B.SetVisibility(VisibilityKind.public_);
						// Parameter b
						PolymorphismTest_S_A_o1_B_b.SetName("b");
						PolymorphismTest_S_A_o1_B_b.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_S_A_o1_B_b.SetType(PolymorphismTest_B);
					PolymorphismTest_S_A_o1_B.AddOwnedParameter(PolymorphismTest_S_A_o1_B_b);
						// Parameter a
						PolymorphismTest_S_A_o1_B_a.SetName("a");
						PolymorphismTest_S_A_o1_B_a.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_S_A_o1_B_a.SetType(PolymorphismTest_A);
						PolymorphismTest_S_A_o1_B_a.SetDirection(ParameterDirectionKind.return_);
					PolymorphismTest_S_A_o1_B.AddOwnedParameter(PolymorphismTest_S_A_o1_B_a);
					PolymorphismTest_S_A_o1_B.AddMethod(PolymorphismTest_S_o1_method);
					PolymorphismTest_S_A_o1_B.AddRedefinedOperation(PolymorphismTest_T_A_o1_B);
				PolymorphismTest_S.AddOwnedOperation(PolymorphismTest_S_A_o1_B);
					// Operation B_o2_A
					PolymorphismTest_S_B_o2_A.SetName("o2");
					PolymorphismTest_S_B_o2_A.SetVisibility(VisibilityKind.public_);
						// Parameter a
						PolymorphismTest_S_B_o2_A_a.SetName("a");
						PolymorphismTest_S_B_o2_A_a.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_S_B_o2_A_a.SetType(PolymorphismTest_A);
					PolymorphismTest_S_B_o2_A.AddOwnedParameter(PolymorphismTest_S_B_o2_A_a);
						// Parameter b
						PolymorphismTest_S_B_o2_A_b.SetName("b");
						PolymorphismTest_S_B_o2_A_b.SetVisibility(VisibilityKind.public_);
						
						PolymorphismTest_S_B_o2_A_b.SetType(PolymorphismTest_B);
						PolymorphismTest_S_B_o2_A_b.SetDirection(ParameterDirectionKind.return_);
					PolymorphismTest_S_B_o2_A.AddOwnedParameter(PolymorphismTest_S_B_o2_A_b);
					PolymorphismTest_S_B_o2_A.AddMethod(PolymorphismTest_S_o2_method);
					PolymorphismTest_S_B_o2_A.AddRedefinedOperation(PolymorphismTest_T_B_o2_B);
				PolymorphismTest_S.AddOwnedOperation(PolymorphismTest_S_B_o2_A);
					// Operation o3
					PolymorphismTest_S_o3.SetName("o3");
					PolymorphismTest_S_o3.SetVisibility(VisibilityKind.public_);
					PolymorphismTest_S_o3.AddMethod(PolymorphismTest_S_o3_method);
					PolymorphismTest_S_o3.AddRedefinedOperation(PolymorphismTest_T_o3_Integer);
				PolymorphismTest_S.AddOwnedOperation(PolymorphismTest_S_o3);
					// Operation o5
					PolymorphismTest_S_o5.SetName("o5");
					PolymorphismTest_S_o5.SetVisibility(VisibilityKind.public_);
					PolymorphismTest_S_o5.AddMethod(PolymorphismTest_S_o5_method);
					PolymorphismTest_S_o5.AddRedefinedOperation(PolymorphismTest_T_o4);
				PolymorphismTest_S.AddOwnedOperation(PolymorphismTest_S_o5);
			PolymorphismTest.AddPackagedElement(PolymorphismTest_S);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // PolymorphismTestModel
}
