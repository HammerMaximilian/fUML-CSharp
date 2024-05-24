/*
 * HierarchyModel.cs
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

namespace Hierarchy
{
	public class HierarchyModel : InMemoryModel
	{
		private static HierarchyModel? instance;

		/*
		 * Model Hierarchy
		 */
		public Package Hierarchy = new();
			public Activity Hierarchy_instantiate_A = new();
				public CallOperationAction Hierarchy_instantiate_A_A_ = new();
					public OutputPin Hierarchy_instantiate_A_A__result = new();
						public LiteralUnlimitedNatural Hierarchy_instantiate_A_A__result_LiteralUnlimitedNatural0 = new();
						public LiteralInteger Hierarchy_instantiate_A_A__result_LiteralInteger1 = new();
						public LiteralInteger Hierarchy_instantiate_A_A__result_LiteralInteger2 = new();
					public InputPin Hierarchy_instantiate_A_A__target = new();
						public LiteralUnlimitedNatural Hierarchy_instantiate_A_A__target_LiteralUnlimitedNatural3 = new();
						public LiteralInteger Hierarchy_instantiate_A_A__target_LiteralInteger4 = new();
				public ObjectFlow Hierarchy_instantiate_A_ObjectFlow5 = new();
					public LiteralInteger Hierarchy_instantiate_A_ObjectFlow5_LiteralInteger6 = new();
					public LiteralBoolean Hierarchy_instantiate_A_ObjectFlow5_LiteralBoolean7 = new();
				public ActivityParameterNode Hierarchy_instantiate_A_a_node = new();
					public LiteralInteger Hierarchy_instantiate_A_a_node_LiteralInteger8 = new();
				public CreateObjectAction Hierarchy_instantiate_A_Create_A = new();
					public OutputPin Hierarchy_instantiate_A_Create_A_result = new();
						public LiteralUnlimitedNatural Hierarchy_instantiate_A_Create_A_result_LiteralUnlimitedNatural9 = new();
						public LiteralInteger Hierarchy_instantiate_A_Create_A_result_LiteralInteger10 = new();
				public Parameter Hierarchy_instantiate_A_a = new();
				public ObjectFlow Hierarchy_instantiate_A_ObjectFlow11 = new();
					public LiteralInteger Hierarchy_instantiate_A_ObjectFlow11_LiteralInteger12 = new();
					public LiteralBoolean Hierarchy_instantiate_A_ObjectFlow11_LiteralBoolean13 = new();
			public Activity Hierarchy_assert_A = new();
				public OpaqueBehavior Hierarchy_assert_A_testNonEmptyList = new();
					public Parameter Hierarchy_assert_A_testNonEmptyList_listSize = new();
				public CallBehaviorAction Hierarchy_assert_A_Test_a_b_c_d_e_size = new();
					public InputPin Hierarchy_assert_A_Test_a_b_c_d_e_size_listSize = new();
						public LiteralUnlimitedNatural Hierarchy_assert_A_Test_a_b_c_d_e_size_listSize_LiteralUnlimitedNatural14 = new();
						public LiteralInteger Hierarchy_assert_A_Test_a_b_c_d_e_size_listSize_LiteralInteger15 = new();
						public LiteralInteger Hierarchy_assert_A_Test_a_b_c_d_e_size_listSize_LiteralInteger16 = new();
				public ObjectFlow Hierarchy_assert_A_ObjectFlow17 = new();
					public LiteralBoolean Hierarchy_assert_A_ObjectFlow17_LiteralBoolean18 = new();
					public LiteralInteger Hierarchy_assert_A_ObjectFlow17_LiteralInteger19 = new();
				public ReadStructuralFeatureAction Hierarchy_assert_A_Read_a_b_c_d = new();
					public InputPin Hierarchy_assert_A_Read_a_b_c_d_object = new();
						public LiteralInteger Hierarchy_assert_A_Read_a_b_c_d_object_LiteralInteger20 = new();
						public LiteralUnlimitedNatural Hierarchy_assert_A_Read_a_b_c_d_object_LiteralUnlimitedNatural21 = new();
					public OutputPin Hierarchy_assert_A_Read_a_b_c_d_result = new();
						public LiteralUnlimitedNatural Hierarchy_assert_A_Read_a_b_c_d_result_LiteralUnlimitedNatural22 = new();
						public LiteralInteger Hierarchy_assert_A_Read_a_b_c_d_result_LiteralInteger23 = new();
				public ForkNode Hierarchy_assert_A_Fork_a_b_c_d = new();
				public ValueSpecificationAction Hierarchy_assert_A_String_a_b_c_d_e_size = new();
					public LiteralString Hierarchy_assert_A_String_a_b_c_d_e_size_LiteralString24 = new();
					public OutputPin Hierarchy_assert_A_String_a_b_c_d_e_size_result = new();
						public LiteralInteger Hierarchy_assert_A_String_a_b_c_d_e_size_result_LiteralInteger25 = new();
						public LiteralUnlimitedNatural Hierarchy_assert_A_String_a_b_c_d_e_size_result_LiteralUnlimitedNatural26 = new();
				public CallBehaviorAction Hierarchy_assert_A_a_b_c_d_e_size_ = new();
					public InputPin Hierarchy_assert_A_a_b_c_d_e_size__list = new();
						public LiteralUnlimitedNatural Hierarchy_assert_A_a_b_c_d_e_size__list_LiteralUnlimitedNatural27 = new();
						public LiteralInteger Hierarchy_assert_A_a_b_c_d_e_size__list_LiteralInteger28 = new();
						public LiteralInteger Hierarchy_assert_A_a_b_c_d_e_size__list_LiteralInteger29 = new();
					public OutputPin Hierarchy_assert_A_a_b_c_d_e_size__result = new();
						public LiteralUnlimitedNatural Hierarchy_assert_A_a_b_c_d_e_size__result_LiteralUnlimitedNatural30 = new();
						public LiteralInteger Hierarchy_assert_A_a_b_c_d_e_size__result_LiteralInteger31 = new();
						public LiteralInteger Hierarchy_assert_A_a_b_c_d_e_size__result_LiteralInteger32 = new();
				public ObjectFlow Hierarchy_assert_A_ObjectFlow33 = new();
					public LiteralBoolean Hierarchy_assert_A_ObjectFlow33_LiteralBoolean34 = new();
					public LiteralInteger Hierarchy_assert_A_ObjectFlow33_LiteralInteger35 = new();
				public CallBehaviorAction Hierarchy_assert_A_WriteLine_a_b_c = new();
					public OutputPin Hierarchy_assert_A_WriteLine_a_b_c_errorStatus = new();
						public LiteralInteger Hierarchy_assert_A_WriteLine_a_b_c_errorStatus_LiteralInteger36 = new();
						public LiteralInteger Hierarchy_assert_A_WriteLine_a_b_c_errorStatus_LiteralInteger37 = new();
						public LiteralUnlimitedNatural Hierarchy_assert_A_WriteLine_a_b_c_errorStatus_LiteralUnlimitedNatural38 = new();
					public InputPin Hierarchy_assert_A_WriteLine_a_b_c_value = new();
						public LiteralUnlimitedNatural Hierarchy_assert_A_WriteLine_a_b_c_value_LiteralUnlimitedNatural39 = new();
						public LiteralInteger Hierarchy_assert_A_WriteLine_a_b_c_value_LiteralInteger40 = new();
						public LiteralInteger Hierarchy_assert_A_WriteLine_a_b_c_value_LiteralInteger41 = new();
				public ControlFlow Hierarchy_assert_A_ControlFlow42 = new();
				public ForkNode Hierarchy_assert_A_Fork_a_b_c = new();
				public CallBehaviorAction Hierarchy_assert_A_WriteLine_a_b_c_d_e = new();
					public OutputPin Hierarchy_assert_A_WriteLine_a_b_c_d_e_errorStatus = new();
						public LiteralUnlimitedNatural Hierarchy_assert_A_WriteLine_a_b_c_d_e_errorStatus_LiteralUnlimitedNatural43 = new();
						public LiteralInteger Hierarchy_assert_A_WriteLine_a_b_c_d_e_errorStatus_LiteralInteger44 = new();
						public LiteralInteger Hierarchy_assert_A_WriteLine_a_b_c_d_e_errorStatus_LiteralInteger45 = new();
					public InputPin Hierarchy_assert_A_WriteLine_a_b_c_d_e_value = new();
						public LiteralUnlimitedNatural Hierarchy_assert_A_WriteLine_a_b_c_d_e_value_LiteralUnlimitedNatural46 = new();
						public LiteralInteger Hierarchy_assert_A_WriteLine_a_b_c_d_e_value_LiteralInteger47 = new();
						public LiteralInteger Hierarchy_assert_A_WriteLine_a_b_c_d_e_value_LiteralInteger48 = new();
				public CallBehaviorAction Hierarchy_assert_A_a_b_c_d_size_ = new();
					public InputPin Hierarchy_assert_A_a_b_c_d_size__list = new();
						public LiteralInteger Hierarchy_assert_A_a_b_c_d_size__list_LiteralInteger49 = new();
						public LiteralUnlimitedNatural Hierarchy_assert_A_a_b_c_d_size__list_LiteralUnlimitedNatural50 = new();
						public LiteralInteger Hierarchy_assert_A_a_b_c_d_size__list_LiteralInteger51 = new();
					public OutputPin Hierarchy_assert_A_a_b_c_d_size__result = new();
						public LiteralUnlimitedNatural Hierarchy_assert_A_a_b_c_d_size__result_LiteralUnlimitedNatural52 = new();
						public LiteralInteger Hierarchy_assert_A_a_b_c_d_size__result_LiteralInteger53 = new();
						public LiteralInteger Hierarchy_assert_A_a_b_c_d_size__result_LiteralInteger54 = new();
				public CallBehaviorAction Hierarchy_assert_A_Test_a_b_c_d_size = new();
					public InputPin Hierarchy_assert_A_Test_a_b_c_d_size_listSize = new();
						public LiteralUnlimitedNatural Hierarchy_assert_A_Test_a_b_c_d_size_listSize_LiteralUnlimitedNatural55 = new();
						public LiteralInteger Hierarchy_assert_A_Test_a_b_c_d_size_listSize_LiteralInteger56 = new();
						public LiteralInteger Hierarchy_assert_A_Test_a_b_c_d_size_listSize_LiteralInteger57 = new();
				public Parameter Hierarchy_assert_A_a = new();
				public ControlFlow Hierarchy_assert_A_ControlFlow58 = new();
				public CallBehaviorAction Hierarchy_assert_A_a_b_size_ = new();
					public OutputPin Hierarchy_assert_A_a_b_size__result = new();
						public LiteralInteger Hierarchy_assert_A_a_b_size__result_LiteralInteger59 = new();
						public LiteralUnlimitedNatural Hierarchy_assert_A_a_b_size__result_LiteralUnlimitedNatural60 = new();
						public LiteralInteger Hierarchy_assert_A_a_b_size__result_LiteralInteger61 = new();
					public InputPin Hierarchy_assert_A_a_b_size__list = new();
						public LiteralInteger Hierarchy_assert_A_a_b_size__list_LiteralInteger62 = new();
						public LiteralInteger Hierarchy_assert_A_a_b_size__list_LiteralInteger63 = new();
						public LiteralUnlimitedNatural Hierarchy_assert_A_a_b_size__list_LiteralUnlimitedNatural64 = new();
				public ObjectFlow Hierarchy_assert_A_ObjectFlow65 = new();
					public LiteralInteger Hierarchy_assert_A_ObjectFlow65_LiteralInteger66 = new();
					public LiteralBoolean Hierarchy_assert_A_ObjectFlow65_LiteralBoolean67 = new();
				public ActivityParameterNode Hierarchy_assert_A_a_node = new();
					public LiteralInteger Hierarchy_assert_A_a_node_LiteralInteger68 = new();
				public ObjectFlow Hierarchy_assert_A_ObjectFlow69 = new();
					public LiteralInteger Hierarchy_assert_A_ObjectFlow69_LiteralInteger70 = new();
					public LiteralBoolean Hierarchy_assert_A_ObjectFlow69_LiteralBoolean71 = new();
				public OpaqueBehavior Hierarchy_assert_A_testEmptyList = new();
					public Parameter Hierarchy_assert_A_testEmptyList_listSize = new();
				public ControlFlow Hierarchy_assert_A_ControlFlow72 = new();
				public ValueSpecificationAction Hierarchy_assert_A_String_a_b_c_d_size = new();
					public OutputPin Hierarchy_assert_A_String_a_b_c_d_size_result = new();
						public LiteralUnlimitedNatural Hierarchy_assert_A_String_a_b_c_d_size_result_LiteralUnlimitedNatural73 = new();
						public LiteralInteger Hierarchy_assert_A_String_a_b_c_d_size_result_LiteralInteger74 = new();
					public LiteralString Hierarchy_assert_A_String_a_b_c_d_size_LiteralString75 = new();
				public ObjectFlow Hierarchy_assert_A_ObjectFlow76 = new();
					public LiteralInteger Hierarchy_assert_A_ObjectFlow76_LiteralInteger77 = new();
					public LiteralBoolean Hierarchy_assert_A_ObjectFlow76_LiteralBoolean78 = new();
				public ControlFlow Hierarchy_assert_A_ControlFlow79 = new();
				public ControlFlow Hierarchy_assert_A_ControlFlow80 = new();
				public ControlFlow Hierarchy_assert_A_ControlFlow81 = new();
				public CallBehaviorAction Hierarchy_assert_A_WriteLine_a_b = new();
					public InputPin Hierarchy_assert_A_WriteLine_a_b_value = new();
						public LiteralInteger Hierarchy_assert_A_WriteLine_a_b_value_LiteralInteger82 = new();
						public LiteralUnlimitedNatural Hierarchy_assert_A_WriteLine_a_b_value_LiteralUnlimitedNatural83 = new();
						public LiteralInteger Hierarchy_assert_A_WriteLine_a_b_value_LiteralInteger84 = new();
					public OutputPin Hierarchy_assert_A_WriteLine_a_b_errorStatus = new();
						public LiteralInteger Hierarchy_assert_A_WriteLine_a_b_errorStatus_LiteralInteger85 = new();
						public LiteralInteger Hierarchy_assert_A_WriteLine_a_b_errorStatus_LiteralInteger86 = new();
						public LiteralUnlimitedNatural Hierarchy_assert_A_WriteLine_a_b_errorStatus_LiteralUnlimitedNatural87 = new();
				public ControlFlow Hierarchy_assert_A_ControlFlow88 = new();
				public ObjectFlow Hierarchy_assert_A_ObjectFlow89 = new();
					public LiteralInteger Hierarchy_assert_A_ObjectFlow89_LiteralInteger90 = new();
					public LiteralBoolean Hierarchy_assert_A_ObjectFlow89_LiteralBoolean91 = new();
				public ObjectFlow Hierarchy_assert_A_ObjectFlow92 = new();
					public LiteralInteger Hierarchy_assert_A_ObjectFlow92_LiteralInteger93 = new();
					public LiteralBoolean Hierarchy_assert_A_ObjectFlow92_LiteralBoolean94 = new();
				public CallBehaviorAction Hierarchy_assert_A_a_b_c_size_ = new();
					public OutputPin Hierarchy_assert_A_a_b_c_size__result = new();
						public LiteralInteger Hierarchy_assert_A_a_b_c_size__result_LiteralInteger95 = new();
						public LiteralInteger Hierarchy_assert_A_a_b_c_size__result_LiteralInteger96 = new();
						public LiteralUnlimitedNatural Hierarchy_assert_A_a_b_c_size__result_LiteralUnlimitedNatural97 = new();
					public InputPin Hierarchy_assert_A_a_b_c_size__list = new();
						public LiteralInteger Hierarchy_assert_A_a_b_c_size__list_LiteralInteger98 = new();
						public LiteralInteger Hierarchy_assert_A_a_b_c_size__list_LiteralInteger99 = new();
						public LiteralUnlimitedNatural Hierarchy_assert_A_a_b_c_size__list_LiteralUnlimitedNatural100 = new();
				public ControlFlow Hierarchy_assert_A_ControlFlow101 = new();
				public ControlFlow Hierarchy_assert_A_ControlFlow102 = new();
				public ControlFlow Hierarchy_assert_A_ControlFlow103 = new();
				public ObjectFlow Hierarchy_assert_A_ObjectFlow104 = new();
					public LiteralBoolean Hierarchy_assert_A_ObjectFlow104_LiteralBoolean105 = new();
					public LiteralInteger Hierarchy_assert_A_ObjectFlow104_LiteralInteger106 = new();
				public ObjectFlow Hierarchy_assert_A_ObjectFlow107 = new();
					public LiteralBoolean Hierarchy_assert_A_ObjectFlow107_LiteralBoolean108 = new();
					public LiteralInteger Hierarchy_assert_A_ObjectFlow107_LiteralInteger109 = new();
				public ReadStructuralFeatureAction Hierarchy_assert_A_Read_a_b = new();
					public OutputPin Hierarchy_assert_A_Read_a_b_result = new();
						public LiteralInteger Hierarchy_assert_A_Read_a_b_result_LiteralInteger110 = new();
						public LiteralUnlimitedNatural Hierarchy_assert_A_Read_a_b_result_LiteralUnlimitedNatural111 = new();
					public InputPin Hierarchy_assert_A_Read_a_b_object = new();
						public LiteralInteger Hierarchy_assert_A_Read_a_b_object_LiteralInteger112 = new();
						public LiteralUnlimitedNatural Hierarchy_assert_A_Read_a_b_object_LiteralUnlimitedNatural113 = new();
				public CallBehaviorAction Hierarchy_assert_A_WriteLine_a_b_c_d = new();
					public InputPin Hierarchy_assert_A_WriteLine_a_b_c_d_value = new();
						public LiteralInteger Hierarchy_assert_A_WriteLine_a_b_c_d_value_LiteralInteger114 = new();
						public LiteralInteger Hierarchy_assert_A_WriteLine_a_b_c_d_value_LiteralInteger115 = new();
						public LiteralUnlimitedNatural Hierarchy_assert_A_WriteLine_a_b_c_d_value_LiteralUnlimitedNatural116 = new();
					public OutputPin Hierarchy_assert_A_WriteLine_a_b_c_d_errorStatus = new();
						public LiteralInteger Hierarchy_assert_A_WriteLine_a_b_c_d_errorStatus_LiteralInteger117 = new();
						public LiteralUnlimitedNatural Hierarchy_assert_A_WriteLine_a_b_c_d_errorStatus_LiteralUnlimitedNatural118 = new();
						public LiteralInteger Hierarchy_assert_A_WriteLine_a_b_c_d_errorStatus_LiteralInteger119 = new();
				public ObjectFlow Hierarchy_assert_A_ObjectFlow120 = new();
					public LiteralBoolean Hierarchy_assert_A_ObjectFlow120_LiteralBoolean121 = new();
					public LiteralInteger Hierarchy_assert_A_ObjectFlow120_LiteralInteger122 = new();
				public ObjectFlow Hierarchy_assert_A_ObjectFlow123 = new();
					public LiteralBoolean Hierarchy_assert_A_ObjectFlow123_LiteralBoolean124 = new();
					public LiteralInteger Hierarchy_assert_A_ObjectFlow123_LiteralInteger125 = new();
				public ObjectFlow Hierarchy_assert_A_ObjectFlow126 = new();
					public LiteralBoolean Hierarchy_assert_A_ObjectFlow126_LiteralBoolean127 = new();
					public LiteralInteger Hierarchy_assert_A_ObjectFlow126_LiteralInteger128 = new();
				public CallBehaviorAction Hierarchy_assert_A_Test_a_b_size = new();
					public InputPin Hierarchy_assert_A_Test_a_b_size_listSize = new();
						public LiteralUnlimitedNatural Hierarchy_assert_A_Test_a_b_size_listSize_LiteralUnlimitedNatural129 = new();
						public LiteralInteger Hierarchy_assert_A_Test_a_b_size_listSize_LiteralInteger130 = new();
						public LiteralInteger Hierarchy_assert_A_Test_a_b_size_listSize_LiteralInteger131 = new();
				public ValueSpecificationAction Hierarchy_assert_A_String_a_b_size = new();
					public LiteralString Hierarchy_assert_A_String_a_b_size_LiteralString132 = new();
					public OutputPin Hierarchy_assert_A_String_a_b_size_result = new();
						public LiteralInteger Hierarchy_assert_A_String_a_b_size_result_LiteralInteger133 = new();
						public LiteralUnlimitedNatural Hierarchy_assert_A_String_a_b_size_result_LiteralUnlimitedNatural134 = new();
				public ControlFlow Hierarchy_assert_A_ControlFlow135 = new();
				public ValueSpecificationAction Hierarchy_assert_A_String_a_b_c_size = new();
					public LiteralString Hierarchy_assert_A_String_a_b_c_size_LiteralString136 = new();
					public OutputPin Hierarchy_assert_A_String_a_b_c_size_result = new();
						public LiteralInteger Hierarchy_assert_A_String_a_b_c_size_result_LiteralInteger137 = new();
						public LiteralUnlimitedNatural Hierarchy_assert_A_String_a_b_c_size_result_LiteralUnlimitedNatural138 = new();
				public ObjectFlow Hierarchy_assert_A_ObjectFlow139 = new();
					public LiteralInteger Hierarchy_assert_A_ObjectFlow139_LiteralInteger140 = new();
					public LiteralBoolean Hierarchy_assert_A_ObjectFlow139_LiteralBoolean141 = new();
				public ObjectFlow Hierarchy_assert_A_ObjectFlow142 = new();
					public LiteralInteger Hierarchy_assert_A_ObjectFlow142_LiteralInteger143 = new();
					public LiteralBoolean Hierarchy_assert_A_ObjectFlow142_LiteralBoolean144 = new();
				public ReadStructuralFeatureAction Hierarchy_assert_A_Read_a_b_c = new();
					public OutputPin Hierarchy_assert_A_Read_a_b_c_result = new();
						public LiteralUnlimitedNatural Hierarchy_assert_A_Read_a_b_c_result_LiteralUnlimitedNatural145 = new();
						public LiteralInteger Hierarchy_assert_A_Read_a_b_c_result_LiteralInteger146 = new();
					public InputPin Hierarchy_assert_A_Read_a_b_c_object = new();
						public LiteralInteger Hierarchy_assert_A_Read_a_b_c_object_LiteralInteger147 = new();
						public LiteralUnlimitedNatural Hierarchy_assert_A_Read_a_b_c_object_LiteralUnlimitedNatural148 = new();
				public ObjectFlow Hierarchy_assert_A_ObjectFlow149 = new();
					public LiteralBoolean Hierarchy_assert_A_ObjectFlow149_LiteralBoolean150 = new();
					public LiteralInteger Hierarchy_assert_A_ObjectFlow149_LiteralInteger151 = new();
				public ObjectFlow Hierarchy_assert_A_ObjectFlow152 = new();
					public LiteralBoolean Hierarchy_assert_A_ObjectFlow152_LiteralBoolean153 = new();
					public LiteralInteger Hierarchy_assert_A_ObjectFlow152_LiteralInteger154 = new();
				public ReadStructuralFeatureAction Hierarchy_assert_A_Read_a_b_c_d_e = new();
					public OutputPin Hierarchy_assert_A_Read_a_b_c_d_e_result = new();
						public LiteralUnlimitedNatural Hierarchy_assert_A_Read_a_b_c_d_e_result_LiteralUnlimitedNatural155 = new();
						public LiteralInteger Hierarchy_assert_A_Read_a_b_c_d_e_result_LiteralInteger156 = new();
					public InputPin Hierarchy_assert_A_Read_a_b_c_d_e_object = new();
						public LiteralUnlimitedNatural Hierarchy_assert_A_Read_a_b_c_d_e_object_LiteralUnlimitedNatural157 = new();
						public LiteralInteger Hierarchy_assert_A_Read_a_b_c_d_e_object_LiteralInteger158 = new();
				public ObjectFlow Hierarchy_assert_A_ObjectFlow159 = new();
					public LiteralInteger Hierarchy_assert_A_ObjectFlow159_LiteralInteger160 = new();
					public LiteralBoolean Hierarchy_assert_A_ObjectFlow159_LiteralBoolean161 = new();
				public ObjectFlow Hierarchy_assert_A_ObjectFlow162 = new();
					public LiteralBoolean Hierarchy_assert_A_ObjectFlow162_LiteralBoolean163 = new();
					public LiteralInteger Hierarchy_assert_A_ObjectFlow162_LiteralInteger164 = new();
				public CallBehaviorAction Hierarchy_assert_A_Test_a_b_c_size = new();
					public InputPin Hierarchy_assert_A_Test_a_b_c_size_listSize = new();
						public LiteralUnlimitedNatural Hierarchy_assert_A_Test_a_b_c_size_listSize_LiteralUnlimitedNatural165 = new();
						public LiteralInteger Hierarchy_assert_A_Test_a_b_c_size_listSize_LiteralInteger166 = new();
						public LiteralInteger Hierarchy_assert_A_Test_a_b_c_size_listSize_LiteralInteger167 = new();
				public ForkNode Hierarchy_assert_A_Fork_a_b = new();
				public ObjectFlow Hierarchy_assert_A_ObjectFlow168 = new();
					public LiteralInteger Hierarchy_assert_A_ObjectFlow168_LiteralInteger169 = new();
					public LiteralBoolean Hierarchy_assert_A_ObjectFlow168_LiteralBoolean170 = new();
			public Class_ Hierarchy_B = new();
				public Property Hierarchy_B_c = new();
			public Class_ Hierarchy_D = new();
				public Property Hierarchy_D_e = new();
			public Class_ Hierarchy_E = new();
			public Class_ Hierarchy_A = new();
				public Property Hierarchy_A_b = new();
				public Operation Hierarchy_A_A_A = new();
					public Parameter Hierarchy_A_A_A_result = new();
			public Activity Hierarchy_main = new();
				public ObjectFlow Hierarchy_main_ObjectFlow171 = new();
					public LiteralBoolean Hierarchy_main_ObjectFlow171_LiteralBoolean172 = new();
					public LiteralInteger Hierarchy_main_ObjectFlow171_LiteralInteger173 = new();
				public CallBehaviorAction Hierarchy_main_instantiate_A = new();
					public OutputPin Hierarchy_main_instantiate_A_a = new();
						public LiteralUnlimitedNatural Hierarchy_main_instantiate_A_a_LiteralUnlimitedNatural174 = new();
						public LiteralInteger Hierarchy_main_instantiate_A_a_LiteralInteger175 = new();
						public LiteralInteger Hierarchy_main_instantiate_A_a_LiteralInteger176 = new();
				public CallBehaviorAction Hierarchy_main_assert_A = new();
					public InputPin Hierarchy_main_assert_A_a = new();
						public LiteralInteger Hierarchy_main_assert_A_a_LiteralInteger177 = new();
						public LiteralInteger Hierarchy_main_assert_A_a_LiteralInteger178 = new();
						public LiteralUnlimitedNatural Hierarchy_main_assert_A_a_LiteralUnlimitedNatural179 = new();
			public Class_ Hierarchy_C = new();
				public Property Hierarchy_C_d = new();

		public static HierarchyModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public HierarchyModel()
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
			 * Model Hierarchy
			 */
			AddToElementRepository("Hierarchy", Hierarchy);
				AddToElementRepository("instantiate_A", Hierarchy_instantiate_A);
					AddToElementRepository("A()", Hierarchy_instantiate_A_A_);
						AddToElementRepository("result", Hierarchy_instantiate_A_A__result);
							AddToElementRepository("LiteralUnlimitedNatural0", Hierarchy_instantiate_A_A__result_LiteralUnlimitedNatural0);
							AddToElementRepository("LiteralInteger1", Hierarchy_instantiate_A_A__result_LiteralInteger1);
							AddToElementRepository("LiteralInteger2", Hierarchy_instantiate_A_A__result_LiteralInteger2);
						AddToElementRepository("target", Hierarchy_instantiate_A_A__target);
							AddToElementRepository("LiteralUnlimitedNatural3", Hierarchy_instantiate_A_A__target_LiteralUnlimitedNatural3);
							AddToElementRepository("LiteralInteger4", Hierarchy_instantiate_A_A__target_LiteralInteger4);
					AddToElementRepository("ObjectFlow5", Hierarchy_instantiate_A_ObjectFlow5);
						AddToElementRepository("LiteralInteger6", Hierarchy_instantiate_A_ObjectFlow5_LiteralInteger6);
						AddToElementRepository("LiteralBoolean7", Hierarchy_instantiate_A_ObjectFlow5_LiteralBoolean7);
					AddToElementRepository("a_node", Hierarchy_instantiate_A_a_node);
						AddToElementRepository("LiteralInteger8", Hierarchy_instantiate_A_a_node_LiteralInteger8);
					AddToElementRepository("Create_A", Hierarchy_instantiate_A_Create_A);
						AddToElementRepository("result", Hierarchy_instantiate_A_Create_A_result);
							AddToElementRepository("LiteralUnlimitedNatural9", Hierarchy_instantiate_A_Create_A_result_LiteralUnlimitedNatural9);
							AddToElementRepository("LiteralInteger10", Hierarchy_instantiate_A_Create_A_result_LiteralInteger10);
					AddToElementRepository("a", Hierarchy_instantiate_A_a);
					AddToElementRepository("ObjectFlow11", Hierarchy_instantiate_A_ObjectFlow11);
						AddToElementRepository("LiteralInteger12", Hierarchy_instantiate_A_ObjectFlow11_LiteralInteger12);
						AddToElementRepository("LiteralBoolean13", Hierarchy_instantiate_A_ObjectFlow11_LiteralBoolean13);
				AddToElementRepository("assert_A", Hierarchy_assert_A);
					AddToElementRepository("testNonEmptyList", Hierarchy_assert_A_testNonEmptyList);
						AddToElementRepository("listSize", Hierarchy_assert_A_testNonEmptyList_listSize);
					AddToElementRepository("Test a.b.c.d.e.size", Hierarchy_assert_A_Test_a_b_c_d_e_size);
						AddToElementRepository("listSize", Hierarchy_assert_A_Test_a_b_c_d_e_size_listSize);
							AddToElementRepository("LiteralUnlimitedNatural14", Hierarchy_assert_A_Test_a_b_c_d_e_size_listSize_LiteralUnlimitedNatural14);
							AddToElementRepository("LiteralInteger15", Hierarchy_assert_A_Test_a_b_c_d_e_size_listSize_LiteralInteger15);
							AddToElementRepository("LiteralInteger16", Hierarchy_assert_A_Test_a_b_c_d_e_size_listSize_LiteralInteger16);
					AddToElementRepository("ObjectFlow17", Hierarchy_assert_A_ObjectFlow17);
						AddToElementRepository("LiteralBoolean18", Hierarchy_assert_A_ObjectFlow17_LiteralBoolean18);
						AddToElementRepository("LiteralInteger19", Hierarchy_assert_A_ObjectFlow17_LiteralInteger19);
					AddToElementRepository("Read a.b.c.d", Hierarchy_assert_A_Read_a_b_c_d);
						AddToElementRepository("object", Hierarchy_assert_A_Read_a_b_c_d_object);
							AddToElementRepository("LiteralInteger20", Hierarchy_assert_A_Read_a_b_c_d_object_LiteralInteger20);
							AddToElementRepository("LiteralUnlimitedNatural21", Hierarchy_assert_A_Read_a_b_c_d_object_LiteralUnlimitedNatural21);
						AddToElementRepository("result", Hierarchy_assert_A_Read_a_b_c_d_result);
							AddToElementRepository("LiteralUnlimitedNatural22", Hierarchy_assert_A_Read_a_b_c_d_result_LiteralUnlimitedNatural22);
							AddToElementRepository("LiteralInteger23", Hierarchy_assert_A_Read_a_b_c_d_result_LiteralInteger23);
					AddToElementRepository("Fork a.b.c.d", Hierarchy_assert_A_Fork_a_b_c_d);
					AddToElementRepository("String(a.b.c.d.e.size)", Hierarchy_assert_A_String_a_b_c_d_e_size);
						AddToElementRepository("LiteralString24", Hierarchy_assert_A_String_a_b_c_d_e_size_LiteralString24);
						AddToElementRepository("result", Hierarchy_assert_A_String_a_b_c_d_e_size_result);
							AddToElementRepository("LiteralInteger25", Hierarchy_assert_A_String_a_b_c_d_e_size_result_LiteralInteger25);
							AddToElementRepository("LiteralUnlimitedNatural26", Hierarchy_assert_A_String_a_b_c_d_e_size_result_LiteralUnlimitedNatural26);
					AddToElementRepository("a.b.c.d.e.size()", Hierarchy_assert_A_a_b_c_d_e_size_);
						AddToElementRepository("list", Hierarchy_assert_A_a_b_c_d_e_size__list);
							AddToElementRepository("LiteralUnlimitedNatural27", Hierarchy_assert_A_a_b_c_d_e_size__list_LiteralUnlimitedNatural27);
							AddToElementRepository("LiteralInteger28", Hierarchy_assert_A_a_b_c_d_e_size__list_LiteralInteger28);
							AddToElementRepository("LiteralInteger29", Hierarchy_assert_A_a_b_c_d_e_size__list_LiteralInteger29);
						AddToElementRepository("result", Hierarchy_assert_A_a_b_c_d_e_size__result);
							AddToElementRepository("LiteralUnlimitedNatural30", Hierarchy_assert_A_a_b_c_d_e_size__result_LiteralUnlimitedNatural30);
							AddToElementRepository("LiteralInteger31", Hierarchy_assert_A_a_b_c_d_e_size__result_LiteralInteger31);
							AddToElementRepository("LiteralInteger32", Hierarchy_assert_A_a_b_c_d_e_size__result_LiteralInteger32);
					AddToElementRepository("ObjectFlow33", Hierarchy_assert_A_ObjectFlow33);
						AddToElementRepository("LiteralBoolean34", Hierarchy_assert_A_ObjectFlow33_LiteralBoolean34);
						AddToElementRepository("LiteralInteger35", Hierarchy_assert_A_ObjectFlow33_LiteralInteger35);
					AddToElementRepository("WriteLine_a.b.c", Hierarchy_assert_A_WriteLine_a_b_c);
						AddToElementRepository("errorStatus", Hierarchy_assert_A_WriteLine_a_b_c_errorStatus);
							AddToElementRepository("LiteralInteger36", Hierarchy_assert_A_WriteLine_a_b_c_errorStatus_LiteralInteger36);
							AddToElementRepository("LiteralInteger37", Hierarchy_assert_A_WriteLine_a_b_c_errorStatus_LiteralInteger37);
							AddToElementRepository("LiteralUnlimitedNatural38", Hierarchy_assert_A_WriteLine_a_b_c_errorStatus_LiteralUnlimitedNatural38);
						AddToElementRepository("value", Hierarchy_assert_A_WriteLine_a_b_c_value);
							AddToElementRepository("LiteralUnlimitedNatural39", Hierarchy_assert_A_WriteLine_a_b_c_value_LiteralUnlimitedNatural39);
							AddToElementRepository("LiteralInteger40", Hierarchy_assert_A_WriteLine_a_b_c_value_LiteralInteger40);
							AddToElementRepository("LiteralInteger41", Hierarchy_assert_A_WriteLine_a_b_c_value_LiteralInteger41);
					AddToElementRepository("ControlFlow42", Hierarchy_assert_A_ControlFlow42);
					AddToElementRepository("Fork a.b.c", Hierarchy_assert_A_Fork_a_b_c);
					AddToElementRepository("WriteLine_a.b.c.d.e", Hierarchy_assert_A_WriteLine_a_b_c_d_e);
						AddToElementRepository("errorStatus", Hierarchy_assert_A_WriteLine_a_b_c_d_e_errorStatus);
							AddToElementRepository("LiteralUnlimitedNatural43", Hierarchy_assert_A_WriteLine_a_b_c_d_e_errorStatus_LiteralUnlimitedNatural43);
							AddToElementRepository("LiteralInteger44", Hierarchy_assert_A_WriteLine_a_b_c_d_e_errorStatus_LiteralInteger44);
							AddToElementRepository("LiteralInteger45", Hierarchy_assert_A_WriteLine_a_b_c_d_e_errorStatus_LiteralInteger45);
						AddToElementRepository("value", Hierarchy_assert_A_WriteLine_a_b_c_d_e_value);
							AddToElementRepository("LiteralUnlimitedNatural46", Hierarchy_assert_A_WriteLine_a_b_c_d_e_value_LiteralUnlimitedNatural46);
							AddToElementRepository("LiteralInteger47", Hierarchy_assert_A_WriteLine_a_b_c_d_e_value_LiteralInteger47);
							AddToElementRepository("LiteralInteger48", Hierarchy_assert_A_WriteLine_a_b_c_d_e_value_LiteralInteger48);
					AddToElementRepository("a.b.c.d.size()", Hierarchy_assert_A_a_b_c_d_size_);
						AddToElementRepository("list", Hierarchy_assert_A_a_b_c_d_size__list);
							AddToElementRepository("LiteralInteger49", Hierarchy_assert_A_a_b_c_d_size__list_LiteralInteger49);
							AddToElementRepository("LiteralUnlimitedNatural50", Hierarchy_assert_A_a_b_c_d_size__list_LiteralUnlimitedNatural50);
							AddToElementRepository("LiteralInteger51", Hierarchy_assert_A_a_b_c_d_size__list_LiteralInteger51);
						AddToElementRepository("result", Hierarchy_assert_A_a_b_c_d_size__result);
							AddToElementRepository("LiteralUnlimitedNatural52", Hierarchy_assert_A_a_b_c_d_size__result_LiteralUnlimitedNatural52);
							AddToElementRepository("LiteralInteger53", Hierarchy_assert_A_a_b_c_d_size__result_LiteralInteger53);
							AddToElementRepository("LiteralInteger54", Hierarchy_assert_A_a_b_c_d_size__result_LiteralInteger54);
					AddToElementRepository("Test a.b.c.d.size", Hierarchy_assert_A_Test_a_b_c_d_size);
						AddToElementRepository("listSize", Hierarchy_assert_A_Test_a_b_c_d_size_listSize);
							AddToElementRepository("LiteralUnlimitedNatural55", Hierarchy_assert_A_Test_a_b_c_d_size_listSize_LiteralUnlimitedNatural55);
							AddToElementRepository("LiteralInteger56", Hierarchy_assert_A_Test_a_b_c_d_size_listSize_LiteralInteger56);
							AddToElementRepository("LiteralInteger57", Hierarchy_assert_A_Test_a_b_c_d_size_listSize_LiteralInteger57);
					AddToElementRepository("a", Hierarchy_assert_A_a);
					AddToElementRepository("ControlFlow58", Hierarchy_assert_A_ControlFlow58);
					AddToElementRepository("a.b.size()", Hierarchy_assert_A_a_b_size_);
						AddToElementRepository("result", Hierarchy_assert_A_a_b_size__result);
							AddToElementRepository("LiteralInteger59", Hierarchy_assert_A_a_b_size__result_LiteralInteger59);
							AddToElementRepository("LiteralUnlimitedNatural60", Hierarchy_assert_A_a_b_size__result_LiteralUnlimitedNatural60);
							AddToElementRepository("LiteralInteger61", Hierarchy_assert_A_a_b_size__result_LiteralInteger61);
						AddToElementRepository("list", Hierarchy_assert_A_a_b_size__list);
							AddToElementRepository("LiteralInteger62", Hierarchy_assert_A_a_b_size__list_LiteralInteger62);
							AddToElementRepository("LiteralInteger63", Hierarchy_assert_A_a_b_size__list_LiteralInteger63);
							AddToElementRepository("LiteralUnlimitedNatural64", Hierarchy_assert_A_a_b_size__list_LiteralUnlimitedNatural64);
					AddToElementRepository("ObjectFlow65", Hierarchy_assert_A_ObjectFlow65);
						AddToElementRepository("LiteralInteger66", Hierarchy_assert_A_ObjectFlow65_LiteralInteger66);
						AddToElementRepository("LiteralBoolean67", Hierarchy_assert_A_ObjectFlow65_LiteralBoolean67);
					AddToElementRepository("a_node", Hierarchy_assert_A_a_node);
						AddToElementRepository("LiteralInteger68", Hierarchy_assert_A_a_node_LiteralInteger68);
					AddToElementRepository("ObjectFlow69", Hierarchy_assert_A_ObjectFlow69);
						AddToElementRepository("LiteralInteger70", Hierarchy_assert_A_ObjectFlow69_LiteralInteger70);
						AddToElementRepository("LiteralBoolean71", Hierarchy_assert_A_ObjectFlow69_LiteralBoolean71);
					AddToElementRepository("testEmptyList", Hierarchy_assert_A_testEmptyList);
						AddToElementRepository("listSize", Hierarchy_assert_A_testEmptyList_listSize);
					AddToElementRepository("ControlFlow72", Hierarchy_assert_A_ControlFlow72);
					AddToElementRepository("String(a.b.c.d.size)", Hierarchy_assert_A_String_a_b_c_d_size);
						AddToElementRepository("result", Hierarchy_assert_A_String_a_b_c_d_size_result);
							AddToElementRepository("LiteralUnlimitedNatural73", Hierarchy_assert_A_String_a_b_c_d_size_result_LiteralUnlimitedNatural73);
							AddToElementRepository("LiteralInteger74", Hierarchy_assert_A_String_a_b_c_d_size_result_LiteralInteger74);
						AddToElementRepository("LiteralString75", Hierarchy_assert_A_String_a_b_c_d_size_LiteralString75);
					AddToElementRepository("ObjectFlow76", Hierarchy_assert_A_ObjectFlow76);
						AddToElementRepository("LiteralInteger77", Hierarchy_assert_A_ObjectFlow76_LiteralInteger77);
						AddToElementRepository("LiteralBoolean78", Hierarchy_assert_A_ObjectFlow76_LiteralBoolean78);
					AddToElementRepository("ControlFlow79", Hierarchy_assert_A_ControlFlow79);
					AddToElementRepository("ControlFlow80", Hierarchy_assert_A_ControlFlow80);
					AddToElementRepository("ControlFlow81", Hierarchy_assert_A_ControlFlow81);
					AddToElementRepository("WriteLine_a.b", Hierarchy_assert_A_WriteLine_a_b);
						AddToElementRepository("value", Hierarchy_assert_A_WriteLine_a_b_value);
							AddToElementRepository("LiteralInteger82", Hierarchy_assert_A_WriteLine_a_b_value_LiteralInteger82);
							AddToElementRepository("LiteralUnlimitedNatural83", Hierarchy_assert_A_WriteLine_a_b_value_LiteralUnlimitedNatural83);
							AddToElementRepository("LiteralInteger84", Hierarchy_assert_A_WriteLine_a_b_value_LiteralInteger84);
						AddToElementRepository("errorStatus", Hierarchy_assert_A_WriteLine_a_b_errorStatus);
							AddToElementRepository("LiteralInteger85", Hierarchy_assert_A_WriteLine_a_b_errorStatus_LiteralInteger85);
							AddToElementRepository("LiteralInteger86", Hierarchy_assert_A_WriteLine_a_b_errorStatus_LiteralInteger86);
							AddToElementRepository("LiteralUnlimitedNatural87", Hierarchy_assert_A_WriteLine_a_b_errorStatus_LiteralUnlimitedNatural87);
					AddToElementRepository("ControlFlow88", Hierarchy_assert_A_ControlFlow88);
					AddToElementRepository("ObjectFlow89", Hierarchy_assert_A_ObjectFlow89);
						AddToElementRepository("LiteralInteger90", Hierarchy_assert_A_ObjectFlow89_LiteralInteger90);
						AddToElementRepository("LiteralBoolean91", Hierarchy_assert_A_ObjectFlow89_LiteralBoolean91);
					AddToElementRepository("ObjectFlow92", Hierarchy_assert_A_ObjectFlow92);
						AddToElementRepository("LiteralInteger93", Hierarchy_assert_A_ObjectFlow92_LiteralInteger93);
						AddToElementRepository("LiteralBoolean94", Hierarchy_assert_A_ObjectFlow92_LiteralBoolean94);
					AddToElementRepository("a.b.c.size()", Hierarchy_assert_A_a_b_c_size_);
						AddToElementRepository("result", Hierarchy_assert_A_a_b_c_size__result);
							AddToElementRepository("LiteralInteger95", Hierarchy_assert_A_a_b_c_size__result_LiteralInteger95);
							AddToElementRepository("LiteralInteger96", Hierarchy_assert_A_a_b_c_size__result_LiteralInteger96);
							AddToElementRepository("LiteralUnlimitedNatural97", Hierarchy_assert_A_a_b_c_size__result_LiteralUnlimitedNatural97);
						AddToElementRepository("list", Hierarchy_assert_A_a_b_c_size__list);
							AddToElementRepository("LiteralInteger98", Hierarchy_assert_A_a_b_c_size__list_LiteralInteger98);
							AddToElementRepository("LiteralInteger99", Hierarchy_assert_A_a_b_c_size__list_LiteralInteger99);
							AddToElementRepository("LiteralUnlimitedNatural100", Hierarchy_assert_A_a_b_c_size__list_LiteralUnlimitedNatural100);
					AddToElementRepository("ControlFlow101", Hierarchy_assert_A_ControlFlow101);
					AddToElementRepository("ControlFlow102", Hierarchy_assert_A_ControlFlow102);
					AddToElementRepository("ControlFlow103", Hierarchy_assert_A_ControlFlow103);
					AddToElementRepository("ObjectFlow104", Hierarchy_assert_A_ObjectFlow104);
						AddToElementRepository("LiteralBoolean105", Hierarchy_assert_A_ObjectFlow104_LiteralBoolean105);
						AddToElementRepository("LiteralInteger106", Hierarchy_assert_A_ObjectFlow104_LiteralInteger106);
					AddToElementRepository("ObjectFlow107", Hierarchy_assert_A_ObjectFlow107);
						AddToElementRepository("LiteralBoolean108", Hierarchy_assert_A_ObjectFlow107_LiteralBoolean108);
						AddToElementRepository("LiteralInteger109", Hierarchy_assert_A_ObjectFlow107_LiteralInteger109);
					AddToElementRepository("Read a.b", Hierarchy_assert_A_Read_a_b);
						AddToElementRepository("result", Hierarchy_assert_A_Read_a_b_result);
							AddToElementRepository("LiteralInteger110", Hierarchy_assert_A_Read_a_b_result_LiteralInteger110);
							AddToElementRepository("LiteralUnlimitedNatural111", Hierarchy_assert_A_Read_a_b_result_LiteralUnlimitedNatural111);
						AddToElementRepository("object", Hierarchy_assert_A_Read_a_b_object);
							AddToElementRepository("LiteralInteger112", Hierarchy_assert_A_Read_a_b_object_LiteralInteger112);
							AddToElementRepository("LiteralUnlimitedNatural113", Hierarchy_assert_A_Read_a_b_object_LiteralUnlimitedNatural113);
					AddToElementRepository("WriteLine_a.b.c.d", Hierarchy_assert_A_WriteLine_a_b_c_d);
						AddToElementRepository("value", Hierarchy_assert_A_WriteLine_a_b_c_d_value);
							AddToElementRepository("LiteralInteger114", Hierarchy_assert_A_WriteLine_a_b_c_d_value_LiteralInteger114);
							AddToElementRepository("LiteralInteger115", Hierarchy_assert_A_WriteLine_a_b_c_d_value_LiteralInteger115);
							AddToElementRepository("LiteralUnlimitedNatural116", Hierarchy_assert_A_WriteLine_a_b_c_d_value_LiteralUnlimitedNatural116);
						AddToElementRepository("errorStatus", Hierarchy_assert_A_WriteLine_a_b_c_d_errorStatus);
							AddToElementRepository("LiteralInteger117", Hierarchy_assert_A_WriteLine_a_b_c_d_errorStatus_LiteralInteger117);
							AddToElementRepository("LiteralUnlimitedNatural118", Hierarchy_assert_A_WriteLine_a_b_c_d_errorStatus_LiteralUnlimitedNatural118);
							AddToElementRepository("LiteralInteger119", Hierarchy_assert_A_WriteLine_a_b_c_d_errorStatus_LiteralInteger119);
					AddToElementRepository("ObjectFlow120", Hierarchy_assert_A_ObjectFlow120);
						AddToElementRepository("LiteralBoolean121", Hierarchy_assert_A_ObjectFlow120_LiteralBoolean121);
						AddToElementRepository("LiteralInteger122", Hierarchy_assert_A_ObjectFlow120_LiteralInteger122);
					AddToElementRepository("ObjectFlow123", Hierarchy_assert_A_ObjectFlow123);
						AddToElementRepository("LiteralBoolean124", Hierarchy_assert_A_ObjectFlow123_LiteralBoolean124);
						AddToElementRepository("LiteralInteger125", Hierarchy_assert_A_ObjectFlow123_LiteralInteger125);
					AddToElementRepository("ObjectFlow126", Hierarchy_assert_A_ObjectFlow126);
						AddToElementRepository("LiteralBoolean127", Hierarchy_assert_A_ObjectFlow126_LiteralBoolean127);
						AddToElementRepository("LiteralInteger128", Hierarchy_assert_A_ObjectFlow126_LiteralInteger128);
					AddToElementRepository("Test a.b.size", Hierarchy_assert_A_Test_a_b_size);
						AddToElementRepository("listSize", Hierarchy_assert_A_Test_a_b_size_listSize);
							AddToElementRepository("LiteralUnlimitedNatural129", Hierarchy_assert_A_Test_a_b_size_listSize_LiteralUnlimitedNatural129);
							AddToElementRepository("LiteralInteger130", Hierarchy_assert_A_Test_a_b_size_listSize_LiteralInteger130);
							AddToElementRepository("LiteralInteger131", Hierarchy_assert_A_Test_a_b_size_listSize_LiteralInteger131);
					AddToElementRepository("String(a.b.size)", Hierarchy_assert_A_String_a_b_size);
						AddToElementRepository("LiteralString132", Hierarchy_assert_A_String_a_b_size_LiteralString132);
						AddToElementRepository("result", Hierarchy_assert_A_String_a_b_size_result);
							AddToElementRepository("LiteralInteger133", Hierarchy_assert_A_String_a_b_size_result_LiteralInteger133);
							AddToElementRepository("LiteralUnlimitedNatural134", Hierarchy_assert_A_String_a_b_size_result_LiteralUnlimitedNatural134);
					AddToElementRepository("ControlFlow135", Hierarchy_assert_A_ControlFlow135);
					AddToElementRepository("String(a.b.c.size)", Hierarchy_assert_A_String_a_b_c_size);
						AddToElementRepository("LiteralString136", Hierarchy_assert_A_String_a_b_c_size_LiteralString136);
						AddToElementRepository("result", Hierarchy_assert_A_String_a_b_c_size_result);
							AddToElementRepository("LiteralInteger137", Hierarchy_assert_A_String_a_b_c_size_result_LiteralInteger137);
							AddToElementRepository("LiteralUnlimitedNatural138", Hierarchy_assert_A_String_a_b_c_size_result_LiteralUnlimitedNatural138);
					AddToElementRepository("ObjectFlow139", Hierarchy_assert_A_ObjectFlow139);
						AddToElementRepository("LiteralInteger140", Hierarchy_assert_A_ObjectFlow139_LiteralInteger140);
						AddToElementRepository("LiteralBoolean141", Hierarchy_assert_A_ObjectFlow139_LiteralBoolean141);
					AddToElementRepository("ObjectFlow142", Hierarchy_assert_A_ObjectFlow142);
						AddToElementRepository("LiteralInteger143", Hierarchy_assert_A_ObjectFlow142_LiteralInteger143);
						AddToElementRepository("LiteralBoolean144", Hierarchy_assert_A_ObjectFlow142_LiteralBoolean144);
					AddToElementRepository("Read a.b.c", Hierarchy_assert_A_Read_a_b_c);
						AddToElementRepository("result", Hierarchy_assert_A_Read_a_b_c_result);
							AddToElementRepository("LiteralUnlimitedNatural145", Hierarchy_assert_A_Read_a_b_c_result_LiteralUnlimitedNatural145);
							AddToElementRepository("LiteralInteger146", Hierarchy_assert_A_Read_a_b_c_result_LiteralInteger146);
						AddToElementRepository("object", Hierarchy_assert_A_Read_a_b_c_object);
							AddToElementRepository("LiteralInteger147", Hierarchy_assert_A_Read_a_b_c_object_LiteralInteger147);
							AddToElementRepository("LiteralUnlimitedNatural148", Hierarchy_assert_A_Read_a_b_c_object_LiteralUnlimitedNatural148);
					AddToElementRepository("ObjectFlow149", Hierarchy_assert_A_ObjectFlow149);
						AddToElementRepository("LiteralBoolean150", Hierarchy_assert_A_ObjectFlow149_LiteralBoolean150);
						AddToElementRepository("LiteralInteger151", Hierarchy_assert_A_ObjectFlow149_LiteralInteger151);
					AddToElementRepository("ObjectFlow152", Hierarchy_assert_A_ObjectFlow152);
						AddToElementRepository("LiteralBoolean153", Hierarchy_assert_A_ObjectFlow152_LiteralBoolean153);
						AddToElementRepository("LiteralInteger154", Hierarchy_assert_A_ObjectFlow152_LiteralInteger154);
					AddToElementRepository("Read a.b.c.d.e", Hierarchy_assert_A_Read_a_b_c_d_e);
						AddToElementRepository("result", Hierarchy_assert_A_Read_a_b_c_d_e_result);
							AddToElementRepository("LiteralUnlimitedNatural155", Hierarchy_assert_A_Read_a_b_c_d_e_result_LiteralUnlimitedNatural155);
							AddToElementRepository("LiteralInteger156", Hierarchy_assert_A_Read_a_b_c_d_e_result_LiteralInteger156);
						AddToElementRepository("object", Hierarchy_assert_A_Read_a_b_c_d_e_object);
							AddToElementRepository("LiteralUnlimitedNatural157", Hierarchy_assert_A_Read_a_b_c_d_e_object_LiteralUnlimitedNatural157);
							AddToElementRepository("LiteralInteger158", Hierarchy_assert_A_Read_a_b_c_d_e_object_LiteralInteger158);
					AddToElementRepository("ObjectFlow159", Hierarchy_assert_A_ObjectFlow159);
						AddToElementRepository("LiteralInteger160", Hierarchy_assert_A_ObjectFlow159_LiteralInteger160);
						AddToElementRepository("LiteralBoolean161", Hierarchy_assert_A_ObjectFlow159_LiteralBoolean161);
					AddToElementRepository("ObjectFlow162", Hierarchy_assert_A_ObjectFlow162);
						AddToElementRepository("LiteralBoolean163", Hierarchy_assert_A_ObjectFlow162_LiteralBoolean163);
						AddToElementRepository("LiteralInteger164", Hierarchy_assert_A_ObjectFlow162_LiteralInteger164);
					AddToElementRepository("Test a.b.c.size", Hierarchy_assert_A_Test_a_b_c_size);
						AddToElementRepository("listSize", Hierarchy_assert_A_Test_a_b_c_size_listSize);
							AddToElementRepository("LiteralUnlimitedNatural165", Hierarchy_assert_A_Test_a_b_c_size_listSize_LiteralUnlimitedNatural165);
							AddToElementRepository("LiteralInteger166", Hierarchy_assert_A_Test_a_b_c_size_listSize_LiteralInteger166);
							AddToElementRepository("LiteralInteger167", Hierarchy_assert_A_Test_a_b_c_size_listSize_LiteralInteger167);
					AddToElementRepository("Fork a.b", Hierarchy_assert_A_Fork_a_b);
					AddToElementRepository("ObjectFlow168", Hierarchy_assert_A_ObjectFlow168);
						AddToElementRepository("LiteralInteger169", Hierarchy_assert_A_ObjectFlow168_LiteralInteger169);
						AddToElementRepository("LiteralBoolean170", Hierarchy_assert_A_ObjectFlow168_LiteralBoolean170);
				AddToElementRepository("B", Hierarchy_B);
					AddToElementRepository("c", Hierarchy_B_c);
				AddToElementRepository("D", Hierarchy_D);
					AddToElementRepository("e", Hierarchy_D_e);
				AddToElementRepository("E", Hierarchy_E);
				AddToElementRepository("A", Hierarchy_A);
					AddToElementRepository("b", Hierarchy_A_b);
					AddToElementRepository("A_A", Hierarchy_A_A_A);
						AddToElementRepository("result", Hierarchy_A_A_A_result);
				AddToElementRepository("main", Hierarchy_main);
					AddToElementRepository("ObjectFlow171", Hierarchy_main_ObjectFlow171);
						AddToElementRepository("LiteralBoolean172", Hierarchy_main_ObjectFlow171_LiteralBoolean172);
						AddToElementRepository("LiteralInteger173", Hierarchy_main_ObjectFlow171_LiteralInteger173);
					AddToElementRepository("instantiate_A", Hierarchy_main_instantiate_A);
						AddToElementRepository("a", Hierarchy_main_instantiate_A_a);
							AddToElementRepository("LiteralUnlimitedNatural174", Hierarchy_main_instantiate_A_a_LiteralUnlimitedNatural174);
							AddToElementRepository("LiteralInteger175", Hierarchy_main_instantiate_A_a_LiteralInteger175);
							AddToElementRepository("LiteralInteger176", Hierarchy_main_instantiate_A_a_LiteralInteger176);
					AddToElementRepository("assert_A", Hierarchy_main_assert_A);
						AddToElementRepository("a", Hierarchy_main_assert_A_a);
							AddToElementRepository("LiteralInteger177", Hierarchy_main_assert_A_a_LiteralInteger177);
							AddToElementRepository("LiteralInteger178", Hierarchy_main_assert_A_a_LiteralInteger178);
							AddToElementRepository("LiteralUnlimitedNatural179", Hierarchy_main_assert_A_a_LiteralUnlimitedNatural179);
				AddToElementRepository("C", Hierarchy_C);
					AddToElementRepository("d", Hierarchy_C_d);

			// Initialize public members
			/*
			 * Model Hierarchy
			 */
			Hierarchy.SetName("Hierarchy");
			Hierarchy.SetVisibility(VisibilityKind.public_);
				// Activity instantiate_A
				Hierarchy_instantiate_A.SetName("instantiate_A");
				Hierarchy_instantiate_A.SetVisibility(VisibilityKind.public_);
				
					// Parameter a
					Hierarchy_instantiate_A_a.SetName("a");
					Hierarchy_instantiate_A_a.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_instantiate_A_a.SetType(Hierarchy_A);
					Hierarchy_instantiate_A_a.SetDirection(ParameterDirectionKind.return_);
				Hierarchy_instantiate_A.AddOwnedParameter(Hierarchy_instantiate_A_a);
					// CallOperationAction A()
					Hierarchy_instantiate_A_A_.SetName("A()");
					Hierarchy_instantiate_A_A_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						Hierarchy_instantiate_A_A__result.SetName("result");
						Hierarchy_instantiate_A_A__result.SetVisibility(VisibilityKind.public_);
						Hierarchy_instantiate_A_A__result.SetType(Hierarchy_A);
					Hierarchy_instantiate_A_A_.AddResult(Hierarchy_instantiate_A_A__result);
					Hierarchy_instantiate_A_A_.SetOperation(Hierarchy_A_A_A);
						// InputPin target
						Hierarchy_instantiate_A_A__target.SetName("target");
						Hierarchy_instantiate_A_A__target.SetVisibility(VisibilityKind.public_);
						Hierarchy_instantiate_A_A__target.SetType(Hierarchy_A);
					Hierarchy_instantiate_A_A_.SetTarget(Hierarchy_instantiate_A_A__target);
				Hierarchy_instantiate_A.AddNode(Hierarchy_instantiate_A_A_);
					// ActivityParameterNode a_node
					Hierarchy_instantiate_A_a_node.SetName("a_node");
					Hierarchy_instantiate_A_a_node.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_instantiate_A_a_node.SetParameter(Hierarchy_instantiate_A_a);
				Hierarchy_instantiate_A.AddNode(Hierarchy_instantiate_A_a_node);
					// CreateObjectAction Create_A
					Hierarchy_instantiate_A_Create_A.SetName("Create_A");
					Hierarchy_instantiate_A_Create_A.SetVisibility(VisibilityKind.public_);
					Hierarchy_instantiate_A_Create_A.SetClassifier(Hierarchy_A);
						// OutputPin result
						Hierarchy_instantiate_A_Create_A_result.SetName("result");
						Hierarchy_instantiate_A_Create_A_result.SetVisibility(VisibilityKind.public_);
						Hierarchy_instantiate_A_Create_A_result.SetType(Hierarchy_A);
					Hierarchy_instantiate_A_Create_A.SetResult(Hierarchy_instantiate_A_Create_A_result);
				Hierarchy_instantiate_A.AddNode(Hierarchy_instantiate_A_Create_A);
					// ObjectFlow ObjectFlow5 from result to target
					Hierarchy_instantiate_A_ObjectFlow5.SetName("ObjectFlow5");
					Hierarchy_instantiate_A_ObjectFlow5.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_instantiate_A_ObjectFlow5.SetSource(Hierarchy_instantiate_A_Create_A_result);
					Hierarchy_instantiate_A_ObjectFlow5.SetTarget(Hierarchy_instantiate_A_A__target);
						// LiteralBoolean LiteralBoolean7
						Hierarchy_instantiate_A_ObjectFlow5_LiteralBoolean7.SetName("LiteralBoolean7");
						Hierarchy_instantiate_A_ObjectFlow5_LiteralBoolean7.SetVisibility(VisibilityKind.public_);
						Hierarchy_instantiate_A_ObjectFlow5_LiteralBoolean7.SetValue(true);
					Hierarchy_instantiate_A_ObjectFlow5.SetGuard(Hierarchy_instantiate_A_ObjectFlow5_LiteralBoolean7);
				Hierarchy_instantiate_A.AddEdge(Hierarchy_instantiate_A_ObjectFlow5);
					// ObjectFlow ObjectFlow11 from result to a_node
					Hierarchy_instantiate_A_ObjectFlow11.SetName("ObjectFlow11");
					Hierarchy_instantiate_A_ObjectFlow11.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_instantiate_A_ObjectFlow11.SetSource(Hierarchy_instantiate_A_A__result);
					Hierarchy_instantiate_A_ObjectFlow11.SetTarget(Hierarchy_instantiate_A_a_node);
						// LiteralBoolean LiteralBoolean13
						Hierarchy_instantiate_A_ObjectFlow11_LiteralBoolean13.SetName("LiteralBoolean13");
						Hierarchy_instantiate_A_ObjectFlow11_LiteralBoolean13.SetVisibility(VisibilityKind.public_);
						Hierarchy_instantiate_A_ObjectFlow11_LiteralBoolean13.SetValue(true);
					Hierarchy_instantiate_A_ObjectFlow11.SetGuard(Hierarchy_instantiate_A_ObjectFlow11_LiteralBoolean13);
				Hierarchy_instantiate_A.AddEdge(Hierarchy_instantiate_A_ObjectFlow11);
			Hierarchy.AddPackagedElement(Hierarchy_instantiate_A);
				// Activity assert_A
				Hierarchy_assert_A.SetName("assert_A");
				Hierarchy_assert_A.SetVisibility(VisibilityKind.public_);
				// FunctionBehavior testNonEmptyList
					Hierarchy_assert_A_testNonEmptyList.SetName("testNonEmptyList");
					Hierarchy_assert_A_testNonEmptyList.SetVisibility(VisibilityKind.public_);
					
						// Parameter listSize
						Hierarchy_assert_A_testNonEmptyList_listSize.SetName("listSize");
						Hierarchy_assert_A_testNonEmptyList_listSize.SetVisibility(VisibilityKind.public_);
						
						Hierarchy_assert_A_testNonEmptyList_listSize.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Hierarchy_assert_A_testNonEmptyList.AddOwnedParameter(Hierarchy_assert_A_testNonEmptyList_listSize);
					Hierarchy_assert_A_testNonEmptyList.AddLanguage("C#");
					Hierarchy_assert_A_testNonEmptyList.AddLanguage("Using");
					Hierarchy_assert_A_testNonEmptyList.AddBody("string parameterName = inputParameters.ElementAt(0).parameter!.name;  Console.WriteLine(\"Asserting \" + parameterName + \"->size() > 0\"); 	// Test parameter listSize 	int listSize = ((IntegerValue)inputParameters.ElementAt(0).values.ElementAt(0)).value; 	Debug.Println(\"[doBody] argument \" + parameterName +  \" = \" + listSize);  	Console.WriteLine(parameterName + \"->size() == \" + listSize); 	Console.Write(\"Part is not empty: \");  	if(listSize > 0) 	{ 		Console.ForegroundColor = ConsoleColor.Green; 		Console.WriteLine(\"Assertion successful.\"); 	} 	else 	{ 		Console.ForegroundColor = ConsoleColor.Red; 		Console.WriteLine(\"Assertion failed!\"); 	} 	Console.ResetColor();");
					Hierarchy_assert_A_testNonEmptyList.AddBody("using fuml.semantics.simpleclassifiers;");
				Hierarchy_assert_A.AddOwnedBehavior(Hierarchy_assert_A_testNonEmptyList);
					// FunctionBehavior testEmptyList
					Hierarchy_assert_A_testEmptyList.SetName("testEmptyList");
					Hierarchy_assert_A_testEmptyList.SetVisibility(VisibilityKind.public_);
					
						// Parameter listSize
						Hierarchy_assert_A_testEmptyList_listSize.SetName("listSize");
						Hierarchy_assert_A_testEmptyList_listSize.SetVisibility(VisibilityKind.public_);
						
						Hierarchy_assert_A_testEmptyList_listSize.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Hierarchy_assert_A_testEmptyList.AddOwnedParameter(Hierarchy_assert_A_testEmptyList_listSize);
					Hierarchy_assert_A_testEmptyList.AddLanguage("C#");
					Hierarchy_assert_A_testEmptyList.AddLanguage("Using");
					Hierarchy_assert_A_testEmptyList.AddBody("string parameterName = inputParameters.ElementAt(0).parameter!.name;  Console.WriteLine(\"Asserting \" + parameterName + \"->size() == 0\"); 	// Test parameter listSize 	int listSize = ((IntegerValue)inputParameters.ElementAt(0).values.ElementAt(0)).value; 	Debug.Println(\"[doBody] argument \" + parameterName +  \" = \" + listSize);  	Console.WriteLine(parameterName + \"->size() == \" + listSize); 	Console.Write(\"Part is empty: \");  	if(listSize == 0) 	{ 		Console.ForegroundColor = ConsoleColor.Green; 		Console.WriteLine(\"Assertion successful.\"); 	} 	else 	{ 		Console.ForegroundColor = ConsoleColor.Red; 		Console.WriteLine(\"Assertion failed!\"); 	} 	Console.ResetColor();");
					Hierarchy_assert_A_testEmptyList.AddBody("using fuml.semantics.simpleclassifiers;");
				Hierarchy_assert_A.AddOwnedBehavior(Hierarchy_assert_A_testEmptyList);
					// Parameter a
					Hierarchy_assert_A_a.SetName("a");
					Hierarchy_assert_A_a.SetVisibility(VisibilityKind.public_);
				Hierarchy_assert_A.AddOwnedParameter(Hierarchy_assert_A_a);
					// CallBehaviorAction Test a.b.c.d.e.size
					Hierarchy_assert_A_Test_a_b_c_d_e_size.SetName("Test a.b.c.d.e.size");
					Hierarchy_assert_A_Test_a_b_c_d_e_size.SetVisibility(VisibilityKind.public_);
					Hierarchy_assert_A_Test_a_b_c_d_e_size.SetBehavior(Hierarchy_assert_A_testEmptyList);
						// InputPin listSize
						Hierarchy_assert_A_Test_a_b_c_d_e_size_listSize.SetName("listSize");
						Hierarchy_assert_A_Test_a_b_c_d_e_size_listSize.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_Test_a_b_c_d_e_size_listSize.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Hierarchy_assert_A_Test_a_b_c_d_e_size.AddArgument(Hierarchy_assert_A_Test_a_b_c_d_e_size_listSize);
				Hierarchy_assert_A.AddNode(Hierarchy_assert_A_Test_a_b_c_d_e_size);
					// ReadStructuralFeatureAction Read a.b.c.d
					Hierarchy_assert_A_Read_a_b_c_d.SetName("Read a.b.c.d");
					Hierarchy_assert_A_Read_a_b_c_d.SetVisibility(VisibilityKind.public_);
					Hierarchy_assert_A_Read_a_b_c_d.SetStructuralFeature(Hierarchy_C_d);
						// InputPin object
						Hierarchy_assert_A_Read_a_b_c_d_object.SetName("object");
						Hierarchy_assert_A_Read_a_b_c_d_object.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_Read_a_b_c_d_object.SetType(Hierarchy_C);
					Hierarchy_assert_A_Read_a_b_c_d.SetObject(Hierarchy_assert_A_Read_a_b_c_d_object);
						// OutputPin result
						Hierarchy_assert_A_Read_a_b_c_d_result.SetName("result");
						Hierarchy_assert_A_Read_a_b_c_d_result.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_Read_a_b_c_d_result.SetType(Hierarchy_D);
					Hierarchy_assert_A_Read_a_b_c_d.SetResult(Hierarchy_assert_A_Read_a_b_c_d_result);
				Hierarchy_assert_A.AddNode(Hierarchy_assert_A_Read_a_b_c_d);
					// ForkNode Fork a.b.c.d
					Hierarchy_assert_A_Fork_a_b_c_d.SetName("Fork a.b.c.d");
					Hierarchy_assert_A_Fork_a_b_c_d.SetVisibility(VisibilityKind.public_);
				Hierarchy_assert_A.AddNode(Hierarchy_assert_A_Fork_a_b_c_d);
					// ValueSpecificationAction String(a.b.c.d.e.size)
					Hierarchy_assert_A_String_a_b_c_d_e_size.SetName("String(a.b.c.d.e.size)");
					Hierarchy_assert_A_String_a_b_c_d_e_size.SetVisibility(VisibilityKind.public_);
						// LiteralString LiteralString24
						Hierarchy_assert_A_String_a_b_c_d_e_size_LiteralString24.SetName("LiteralString24");
						Hierarchy_assert_A_String_a_b_c_d_e_size_LiteralString24.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_String_a_b_c_d_e_size_LiteralString24.SetValue("Asserting a.b.c.d.e.size == 0");
					Hierarchy_assert_A_String_a_b_c_d_e_size.SetValue(Hierarchy_assert_A_String_a_b_c_d_e_size_LiteralString24);
						// OutputPin result
						Hierarchy_assert_A_String_a_b_c_d_e_size_result.SetName("result");
						Hierarchy_assert_A_String_a_b_c_d_e_size_result.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_String_a_b_c_d_e_size_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					Hierarchy_assert_A_String_a_b_c_d_e_size.SetResult(Hierarchy_assert_A_String_a_b_c_d_e_size_result);
				Hierarchy_assert_A.AddNode(Hierarchy_assert_A_String_a_b_c_d_e_size);
					// CallBehaviorAction a.b.c.d.e.size()
					Hierarchy_assert_A_a_b_c_d_e_size_.SetName("a.b.c.d.e.size()");
					Hierarchy_assert_A_a_b_c_d_e_size_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						Hierarchy_assert_A_a_b_c_d_e_size__result.SetName("result");
						Hierarchy_assert_A_a_b_c_d_e_size__result.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_a_b_c_d_e_size__result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Hierarchy_assert_A_a_b_c_d_e_size_.AddResult(Hierarchy_assert_A_a_b_c_d_e_size__result);
					Hierarchy_assert_A_a_b_c_d_e_size_.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListSize);
						// InputPin list
						Hierarchy_assert_A_a_b_c_d_e_size__list.SetName("list");
						Hierarchy_assert_A_a_b_c_d_e_size__list.SetVisibility(VisibilityKind.public_);
						
						Hierarchy_assert_A_a_b_c_d_e_size__list.SetUpper(-1);
						Hierarchy_assert_A_a_b_c_d_e_size__list.SetLower(0);
					Hierarchy_assert_A_a_b_c_d_e_size_.AddArgument(Hierarchy_assert_A_a_b_c_d_e_size__list);
				Hierarchy_assert_A.AddNode(Hierarchy_assert_A_a_b_c_d_e_size_);
					// CallBehaviorAction a.b.c.size()
					Hierarchy_assert_A_a_b_c_size_.SetName("a.b.c.size()");
					Hierarchy_assert_A_a_b_c_size_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						Hierarchy_assert_A_a_b_c_size__result.SetName("result");
						Hierarchy_assert_A_a_b_c_size__result.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_a_b_c_size__result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Hierarchy_assert_A_a_b_c_size_.AddResult(Hierarchy_assert_A_a_b_c_size__result);
					Hierarchy_assert_A_a_b_c_size_.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListSize);
						// InputPin list
						Hierarchy_assert_A_a_b_c_size__list.SetName("list");
						Hierarchy_assert_A_a_b_c_size__list.SetVisibility(VisibilityKind.public_);
						
						Hierarchy_assert_A_a_b_c_size__list.SetUpper(-1);
						Hierarchy_assert_A_a_b_c_size__list.SetLower(0);
					Hierarchy_assert_A_a_b_c_size_.AddArgument(Hierarchy_assert_A_a_b_c_size__list);
				Hierarchy_assert_A.AddNode(Hierarchy_assert_A_a_b_c_size_);
					// CallBehaviorAction WriteLine_a.b.c
					Hierarchy_assert_A_WriteLine_a_b_c.SetName("WriteLine_a.b.c");
					Hierarchy_assert_A_WriteLine_a_b_c.SetVisibility(VisibilityKind.public_);
					
						// OutputPin errorStatus
						Hierarchy_assert_A_WriteLine_a_b_c_errorStatus.SetName("errorStatus");
						Hierarchy_assert_A_WriteLine_a_b_c_errorStatus.SetVisibility(VisibilityKind.public_);
						
						Hierarchy_assert_A_WriteLine_a_b_c_errorStatus.SetLower(0);
					Hierarchy_assert_A_WriteLine_a_b_c.AddResult(Hierarchy_assert_A_WriteLine_a_b_c_errorStatus);
					Hierarchy_assert_A_WriteLine_a_b_c.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
						// InputPin value
						Hierarchy_assert_A_WriteLine_a_b_c_value.SetName("value");
						Hierarchy_assert_A_WriteLine_a_b_c_value.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_WriteLine_a_b_c_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					Hierarchy_assert_A_WriteLine_a_b_c.AddArgument(Hierarchy_assert_A_WriteLine_a_b_c_value);
				Hierarchy_assert_A.AddNode(Hierarchy_assert_A_WriteLine_a_b_c);
					// ForkNode Fork a.b.c
					Hierarchy_assert_A_Fork_a_b_c.SetName("Fork a.b.c");
					Hierarchy_assert_A_Fork_a_b_c.SetVisibility(VisibilityKind.public_);
				Hierarchy_assert_A.AddNode(Hierarchy_assert_A_Fork_a_b_c);
					// CallBehaviorAction WriteLine_a.b.c.d.e
					Hierarchy_assert_A_WriteLine_a_b_c_d_e.SetName("WriteLine_a.b.c.d.e");
					Hierarchy_assert_A_WriteLine_a_b_c_d_e.SetVisibility(VisibilityKind.public_);
					
						// OutputPin errorStatus
						Hierarchy_assert_A_WriteLine_a_b_c_d_e_errorStatus.SetName("errorStatus");
						Hierarchy_assert_A_WriteLine_a_b_c_d_e_errorStatus.SetVisibility(VisibilityKind.public_);
						
						Hierarchy_assert_A_WriteLine_a_b_c_d_e_errorStatus.SetLower(0);
					Hierarchy_assert_A_WriteLine_a_b_c_d_e.AddResult(Hierarchy_assert_A_WriteLine_a_b_c_d_e_errorStatus);
					Hierarchy_assert_A_WriteLine_a_b_c_d_e.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
						// InputPin value
						Hierarchy_assert_A_WriteLine_a_b_c_d_e_value.SetName("value");
						Hierarchy_assert_A_WriteLine_a_b_c_d_e_value.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_WriteLine_a_b_c_d_e_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					Hierarchy_assert_A_WriteLine_a_b_c_d_e.AddArgument(Hierarchy_assert_A_WriteLine_a_b_c_d_e_value);
				Hierarchy_assert_A.AddNode(Hierarchy_assert_A_WriteLine_a_b_c_d_e);
					// CallBehaviorAction a.b.c.d.size()
					Hierarchy_assert_A_a_b_c_d_size_.SetName("a.b.c.d.size()");
					Hierarchy_assert_A_a_b_c_d_size_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						Hierarchy_assert_A_a_b_c_d_size__result.SetName("result");
						Hierarchy_assert_A_a_b_c_d_size__result.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_a_b_c_d_size__result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Hierarchy_assert_A_a_b_c_d_size_.AddResult(Hierarchy_assert_A_a_b_c_d_size__result);
					Hierarchy_assert_A_a_b_c_d_size_.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListSize);
						// InputPin list
						Hierarchy_assert_A_a_b_c_d_size__list.SetName("list");
						Hierarchy_assert_A_a_b_c_d_size__list.SetVisibility(VisibilityKind.public_);
						
						Hierarchy_assert_A_a_b_c_d_size__list.SetUpper(-1);
						Hierarchy_assert_A_a_b_c_d_size__list.SetLower(0);
					Hierarchy_assert_A_a_b_c_d_size_.AddArgument(Hierarchy_assert_A_a_b_c_d_size__list);
				Hierarchy_assert_A.AddNode(Hierarchy_assert_A_a_b_c_d_size_);
					// ReadStructuralFeatureAction Read a.b
					Hierarchy_assert_A_Read_a_b.SetName("Read a.b");
					Hierarchy_assert_A_Read_a_b.SetVisibility(VisibilityKind.public_);
					Hierarchy_assert_A_Read_a_b.SetStructuralFeature(Hierarchy_A_b);
						// InputPin object
						Hierarchy_assert_A_Read_a_b_object.SetName("object");
						Hierarchy_assert_A_Read_a_b_object.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_Read_a_b_object.SetType(Hierarchy_A);
					Hierarchy_assert_A_Read_a_b.SetObject(Hierarchy_assert_A_Read_a_b_object);
						// OutputPin result
						Hierarchy_assert_A_Read_a_b_result.SetName("result");
						Hierarchy_assert_A_Read_a_b_result.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_Read_a_b_result.SetType(Hierarchy_B);
					Hierarchy_assert_A_Read_a_b.SetResult(Hierarchy_assert_A_Read_a_b_result);
				Hierarchy_assert_A.AddNode(Hierarchy_assert_A_Read_a_b);
					// CallBehaviorAction Test a.b.c.d.size
					Hierarchy_assert_A_Test_a_b_c_d_size.SetName("Test a.b.c.d.size");
					Hierarchy_assert_A_Test_a_b_c_d_size.SetVisibility(VisibilityKind.public_);
					Hierarchy_assert_A_Test_a_b_c_d_size.SetBehavior(Hierarchy_assert_A_testNonEmptyList);
						// InputPin listSize
						Hierarchy_assert_A_Test_a_b_c_d_size_listSize.SetName("listSize");
						Hierarchy_assert_A_Test_a_b_c_d_size_listSize.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_Test_a_b_c_d_size_listSize.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Hierarchy_assert_A_Test_a_b_c_d_size.AddArgument(Hierarchy_assert_A_Test_a_b_c_d_size_listSize);
				Hierarchy_assert_A.AddNode(Hierarchy_assert_A_Test_a_b_c_d_size);
					// CallBehaviorAction WriteLine_a.b.c.d
					Hierarchy_assert_A_WriteLine_a_b_c_d.SetName("WriteLine_a.b.c.d");
					Hierarchy_assert_A_WriteLine_a_b_c_d.SetVisibility(VisibilityKind.public_);
					
						// OutputPin errorStatus
						Hierarchy_assert_A_WriteLine_a_b_c_d_errorStatus.SetName("errorStatus");
						Hierarchy_assert_A_WriteLine_a_b_c_d_errorStatus.SetVisibility(VisibilityKind.public_);
						
						Hierarchy_assert_A_WriteLine_a_b_c_d_errorStatus.SetLower(0);
					Hierarchy_assert_A_WriteLine_a_b_c_d.AddResult(Hierarchy_assert_A_WriteLine_a_b_c_d_errorStatus);
					Hierarchy_assert_A_WriteLine_a_b_c_d.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
						// InputPin value
						Hierarchy_assert_A_WriteLine_a_b_c_d_value.SetName("value");
						Hierarchy_assert_A_WriteLine_a_b_c_d_value.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_WriteLine_a_b_c_d_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					Hierarchy_assert_A_WriteLine_a_b_c_d.AddArgument(Hierarchy_assert_A_WriteLine_a_b_c_d_value);
				Hierarchy_assert_A.AddNode(Hierarchy_assert_A_WriteLine_a_b_c_d);
					// CallBehaviorAction a.b.size()
					Hierarchy_assert_A_a_b_size_.SetName("a.b.size()");
					Hierarchy_assert_A_a_b_size_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						Hierarchy_assert_A_a_b_size__result.SetName("result");
						Hierarchy_assert_A_a_b_size__result.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_a_b_size__result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Hierarchy_assert_A_a_b_size_.AddResult(Hierarchy_assert_A_a_b_size__result);
					Hierarchy_assert_A_a_b_size_.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_ListFunctions_ListSize);
						// InputPin list
						Hierarchy_assert_A_a_b_size__list.SetName("list");
						Hierarchy_assert_A_a_b_size__list.SetVisibility(VisibilityKind.public_);
						
						Hierarchy_assert_A_a_b_size__list.SetUpper(-1);
						Hierarchy_assert_A_a_b_size__list.SetLower(0);
					Hierarchy_assert_A_a_b_size_.AddArgument(Hierarchy_assert_A_a_b_size__list);
				Hierarchy_assert_A.AddNode(Hierarchy_assert_A_a_b_size_);
					// CallBehaviorAction Test a.b.size
					Hierarchy_assert_A_Test_a_b_size.SetName("Test a.b.size");
					Hierarchy_assert_A_Test_a_b_size.SetVisibility(VisibilityKind.public_);
					Hierarchy_assert_A_Test_a_b_size.SetBehavior(Hierarchy_assert_A_testNonEmptyList);
						// InputPin listSize
						Hierarchy_assert_A_Test_a_b_size_listSize.SetName("listSize");
						Hierarchy_assert_A_Test_a_b_size_listSize.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_Test_a_b_size_listSize.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Hierarchy_assert_A_Test_a_b_size.AddArgument(Hierarchy_assert_A_Test_a_b_size_listSize);
				Hierarchy_assert_A.AddNode(Hierarchy_assert_A_Test_a_b_size);
					// ActivityParameterNode a_node
					Hierarchy_assert_A_a_node.SetName("a_node");
					Hierarchy_assert_A_a_node.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_assert_A_a_node.SetParameter(Hierarchy_assert_A_a);
				Hierarchy_assert_A.AddNode(Hierarchy_assert_A_a_node);
					// ValueSpecificationAction String(a.b.size)
					Hierarchy_assert_A_String_a_b_size.SetName("String(a.b.size)");
					Hierarchy_assert_A_String_a_b_size.SetVisibility(VisibilityKind.public_);
						// LiteralString LiteralString132
						Hierarchy_assert_A_String_a_b_size_LiteralString132.SetName("LiteralString132");
						Hierarchy_assert_A_String_a_b_size_LiteralString132.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_String_a_b_size_LiteralString132.SetValue("Asserting a.b.size > 0");
					Hierarchy_assert_A_String_a_b_size.SetValue(Hierarchy_assert_A_String_a_b_size_LiteralString132);
						// OutputPin result
						Hierarchy_assert_A_String_a_b_size_result.SetName("result");
						Hierarchy_assert_A_String_a_b_size_result.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_String_a_b_size_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					Hierarchy_assert_A_String_a_b_size.SetResult(Hierarchy_assert_A_String_a_b_size_result);
				Hierarchy_assert_A.AddNode(Hierarchy_assert_A_String_a_b_size);
					// ValueSpecificationAction String(a.b.c.size)
					Hierarchy_assert_A_String_a_b_c_size.SetName("String(a.b.c.size)");
					Hierarchy_assert_A_String_a_b_c_size.SetVisibility(VisibilityKind.public_);
						// LiteralString LiteralString136
						Hierarchy_assert_A_String_a_b_c_size_LiteralString136.SetName("LiteralString136");
						Hierarchy_assert_A_String_a_b_c_size_LiteralString136.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_String_a_b_c_size_LiteralString136.SetValue("Asserting a.b.c.size > 0");
					Hierarchy_assert_A_String_a_b_c_size.SetValue(Hierarchy_assert_A_String_a_b_c_size_LiteralString136);
						// OutputPin result
						Hierarchy_assert_A_String_a_b_c_size_result.SetName("result");
						Hierarchy_assert_A_String_a_b_c_size_result.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_String_a_b_c_size_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					Hierarchy_assert_A_String_a_b_c_size.SetResult(Hierarchy_assert_A_String_a_b_c_size_result);
				Hierarchy_assert_A.AddNode(Hierarchy_assert_A_String_a_b_c_size);
					// ReadStructuralFeatureAction Read a.b.c
					Hierarchy_assert_A_Read_a_b_c.SetName("Read a.b.c");
					Hierarchy_assert_A_Read_a_b_c.SetVisibility(VisibilityKind.public_);
					Hierarchy_assert_A_Read_a_b_c.SetStructuralFeature(Hierarchy_B_c);
						// InputPin object
						Hierarchy_assert_A_Read_a_b_c_object.SetName("object");
						Hierarchy_assert_A_Read_a_b_c_object.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_Read_a_b_c_object.SetType(Hierarchy_B);
					Hierarchy_assert_A_Read_a_b_c.SetObject(Hierarchy_assert_A_Read_a_b_c_object);
						// OutputPin result
						Hierarchy_assert_A_Read_a_b_c_result.SetName("result");
						Hierarchy_assert_A_Read_a_b_c_result.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_Read_a_b_c_result.SetType(Hierarchy_C);
					Hierarchy_assert_A_Read_a_b_c.SetResult(Hierarchy_assert_A_Read_a_b_c_result);
				Hierarchy_assert_A.AddNode(Hierarchy_assert_A_Read_a_b_c);
					// ValueSpecificationAction String(a.b.c.d.size)
					Hierarchy_assert_A_String_a_b_c_d_size.SetName("String(a.b.c.d.size)");
					Hierarchy_assert_A_String_a_b_c_d_size.SetVisibility(VisibilityKind.public_);
						// LiteralString LiteralString75
						Hierarchy_assert_A_String_a_b_c_d_size_LiteralString75.SetName("LiteralString75");
						Hierarchy_assert_A_String_a_b_c_d_size_LiteralString75.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_String_a_b_c_d_size_LiteralString75.SetValue("Asserting a.b.c.d.size > 0");
					Hierarchy_assert_A_String_a_b_c_d_size.SetValue(Hierarchy_assert_A_String_a_b_c_d_size_LiteralString75);
						// OutputPin result
						Hierarchy_assert_A_String_a_b_c_d_size_result.SetName("result");
						Hierarchy_assert_A_String_a_b_c_d_size_result.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_String_a_b_c_d_size_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					Hierarchy_assert_A_String_a_b_c_d_size.SetResult(Hierarchy_assert_A_String_a_b_c_d_size_result);
				Hierarchy_assert_A.AddNode(Hierarchy_assert_A_String_a_b_c_d_size);
					// ReadStructuralFeatureAction Read a.b.c.d.e
					Hierarchy_assert_A_Read_a_b_c_d_e.SetName("Read a.b.c.d.e");
					Hierarchy_assert_A_Read_a_b_c_d_e.SetVisibility(VisibilityKind.public_);
					Hierarchy_assert_A_Read_a_b_c_d_e.SetStructuralFeature(Hierarchy_D_e);
						// InputPin object
						Hierarchy_assert_A_Read_a_b_c_d_e_object.SetName("object");
						Hierarchy_assert_A_Read_a_b_c_d_e_object.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_Read_a_b_c_d_e_object.SetType(Hierarchy_D);
					Hierarchy_assert_A_Read_a_b_c_d_e.SetObject(Hierarchy_assert_A_Read_a_b_c_d_e_object);
						// OutputPin result
						Hierarchy_assert_A_Read_a_b_c_d_e_result.SetName("result");
						Hierarchy_assert_A_Read_a_b_c_d_e_result.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_Read_a_b_c_d_e_result.SetType(Hierarchy_E);
					Hierarchy_assert_A_Read_a_b_c_d_e.SetResult(Hierarchy_assert_A_Read_a_b_c_d_e_result);
				Hierarchy_assert_A.AddNode(Hierarchy_assert_A_Read_a_b_c_d_e);
					// CallBehaviorAction Test a.b.c.size
					Hierarchy_assert_A_Test_a_b_c_size.SetName("Test a.b.c.size");
					Hierarchy_assert_A_Test_a_b_c_size.SetVisibility(VisibilityKind.public_);
					Hierarchy_assert_A_Test_a_b_c_size.SetBehavior(Hierarchy_assert_A_testNonEmptyList);
						// InputPin listSize
						Hierarchy_assert_A_Test_a_b_c_size_listSize.SetName("listSize");
						Hierarchy_assert_A_Test_a_b_c_size_listSize.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_Test_a_b_c_size_listSize.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					Hierarchy_assert_A_Test_a_b_c_size.AddArgument(Hierarchy_assert_A_Test_a_b_c_size_listSize);
				Hierarchy_assert_A.AddNode(Hierarchy_assert_A_Test_a_b_c_size);
					// CallBehaviorAction WriteLine_a.b
					Hierarchy_assert_A_WriteLine_a_b.SetName("WriteLine_a.b");
					Hierarchy_assert_A_WriteLine_a_b.SetVisibility(VisibilityKind.public_);
					
						// OutputPin errorStatus
						Hierarchy_assert_A_WriteLine_a_b_errorStatus.SetName("errorStatus");
						Hierarchy_assert_A_WriteLine_a_b_errorStatus.SetVisibility(VisibilityKind.public_);
						
						Hierarchy_assert_A_WriteLine_a_b_errorStatus.SetLower(0);
					Hierarchy_assert_A_WriteLine_a_b.AddResult(Hierarchy_assert_A_WriteLine_a_b_errorStatus);
					Hierarchy_assert_A_WriteLine_a_b.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
						// InputPin value
						Hierarchy_assert_A_WriteLine_a_b_value.SetName("value");
						Hierarchy_assert_A_WriteLine_a_b_value.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_WriteLine_a_b_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					Hierarchy_assert_A_WriteLine_a_b.AddArgument(Hierarchy_assert_A_WriteLine_a_b_value);
				Hierarchy_assert_A.AddNode(Hierarchy_assert_A_WriteLine_a_b);
					// ForkNode Fork a.b
					Hierarchy_assert_A_Fork_a_b.SetName("Fork a.b");
					Hierarchy_assert_A_Fork_a_b.SetVisibility(VisibilityKind.public_);
				Hierarchy_assert_A.AddNode(Hierarchy_assert_A_Fork_a_b);
					// ControlFlow ControlFlow88 from a.b.c.size() to String(a.b.c.size)
					Hierarchy_assert_A_ControlFlow88.SetName("ControlFlow88");
					Hierarchy_assert_A_ControlFlow88.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_assert_A_ControlFlow88.SetSource(Hierarchy_assert_A_a_b_c_size_);
					Hierarchy_assert_A_ControlFlow88.SetTarget(Hierarchy_assert_A_String_a_b_c_size);
				Hierarchy_assert_A.AddEdge(Hierarchy_assert_A_ControlFlow88);
					// ObjectFlow ObjectFlow17 from result to Fork a.b.c
					Hierarchy_assert_A_ObjectFlow17.SetName("ObjectFlow17");
					Hierarchy_assert_A_ObjectFlow17.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_assert_A_ObjectFlow17.SetSource(Hierarchy_assert_A_Read_a_b_c_result);
					Hierarchy_assert_A_ObjectFlow17.SetTarget(Hierarchy_assert_A_Fork_a_b_c);
						// LiteralBoolean LiteralBoolean18
						Hierarchy_assert_A_ObjectFlow17_LiteralBoolean18.SetName("LiteralBoolean18");
						Hierarchy_assert_A_ObjectFlow17_LiteralBoolean18.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_ObjectFlow17_LiteralBoolean18.SetValue(true);
					Hierarchy_assert_A_ObjectFlow17.SetGuard(Hierarchy_assert_A_ObjectFlow17_LiteralBoolean18);
				Hierarchy_assert_A.AddEdge(Hierarchy_assert_A_ObjectFlow17);
					// ObjectFlow ObjectFlow89 from result to Fork a.b.c.d
					Hierarchy_assert_A_ObjectFlow89.SetName("ObjectFlow89");
					Hierarchy_assert_A_ObjectFlow89.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_assert_A_ObjectFlow89.SetSource(Hierarchy_assert_A_Read_a_b_c_d_result);
					Hierarchy_assert_A_ObjectFlow89.SetTarget(Hierarchy_assert_A_Fork_a_b_c_d);
						// LiteralBoolean LiteralBoolean91
						Hierarchy_assert_A_ObjectFlow89_LiteralBoolean91.SetName("LiteralBoolean91");
						Hierarchy_assert_A_ObjectFlow89_LiteralBoolean91.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_ObjectFlow89_LiteralBoolean91.SetValue(true);
					Hierarchy_assert_A_ObjectFlow89.SetGuard(Hierarchy_assert_A_ObjectFlow89_LiteralBoolean91);
				Hierarchy_assert_A.AddEdge(Hierarchy_assert_A_ObjectFlow89);
					// ObjectFlow ObjectFlow92 from result to Fork a.b
					Hierarchy_assert_A_ObjectFlow92.SetName("ObjectFlow92");
					Hierarchy_assert_A_ObjectFlow92.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_assert_A_ObjectFlow92.SetSource(Hierarchy_assert_A_Read_a_b_result);
					Hierarchy_assert_A_ObjectFlow92.SetTarget(Hierarchy_assert_A_Fork_a_b);
						// LiteralBoolean LiteralBoolean94
						Hierarchy_assert_A_ObjectFlow92_LiteralBoolean94.SetName("LiteralBoolean94");
						Hierarchy_assert_A_ObjectFlow92_LiteralBoolean94.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_ObjectFlow92_LiteralBoolean94.SetValue(true);
					Hierarchy_assert_A_ObjectFlow92.SetGuard(Hierarchy_assert_A_ObjectFlow92_LiteralBoolean94);
				Hierarchy_assert_A.AddEdge(Hierarchy_assert_A_ObjectFlow92);
					// ObjectFlow ObjectFlow33 from result to listSize
					Hierarchy_assert_A_ObjectFlow33.SetName("ObjectFlow33");
					Hierarchy_assert_A_ObjectFlow33.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_assert_A_ObjectFlow33.SetSource(Hierarchy_assert_A_a_b_c_size__result);
					Hierarchy_assert_A_ObjectFlow33.SetTarget(Hierarchy_assert_A_Test_a_b_c_size_listSize);
						// LiteralBoolean LiteralBoolean34
						Hierarchy_assert_A_ObjectFlow33_LiteralBoolean34.SetName("LiteralBoolean34");
						Hierarchy_assert_A_ObjectFlow33_LiteralBoolean34.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_ObjectFlow33_LiteralBoolean34.SetValue(true);
					Hierarchy_assert_A_ObjectFlow33.SetGuard(Hierarchy_assert_A_ObjectFlow33_LiteralBoolean34);
				Hierarchy_assert_A.AddEdge(Hierarchy_assert_A_ObjectFlow33);
					// ControlFlow ControlFlow101 from a.b.c.d.size() to String(a.b.c.d.size)
					Hierarchy_assert_A_ControlFlow101.SetName("ControlFlow101");
					Hierarchy_assert_A_ControlFlow101.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_assert_A_ControlFlow101.SetSource(Hierarchy_assert_A_a_b_c_d_size_);
					Hierarchy_assert_A_ControlFlow101.SetTarget(Hierarchy_assert_A_String_a_b_c_d_size);
				Hierarchy_assert_A.AddEdge(Hierarchy_assert_A_ControlFlow101);
					// ControlFlow ControlFlow102 from WriteLine_a.b to Test a.b.size
					Hierarchy_assert_A_ControlFlow102.SetName("ControlFlow102");
					Hierarchy_assert_A_ControlFlow102.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_assert_A_ControlFlow102.SetSource(Hierarchy_assert_A_WriteLine_a_b);
					Hierarchy_assert_A_ControlFlow102.SetTarget(Hierarchy_assert_A_Test_a_b_size);
				Hierarchy_assert_A.AddEdge(Hierarchy_assert_A_ControlFlow102);
					// ControlFlow ControlFlow103 from WriteLine_a.b.c.d.e to Test a.b.c.d.e.size
					Hierarchy_assert_A_ControlFlow103.SetName("ControlFlow103");
					Hierarchy_assert_A_ControlFlow103.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_assert_A_ControlFlow103.SetSource(Hierarchy_assert_A_WriteLine_a_b_c_d_e);
					Hierarchy_assert_A_ControlFlow103.SetTarget(Hierarchy_assert_A_Test_a_b_c_d_e_size);
				Hierarchy_assert_A.AddEdge(Hierarchy_assert_A_ControlFlow103);
					// ControlFlow ControlFlow42 from a.b.size() to String(a.b.size)
					Hierarchy_assert_A_ControlFlow42.SetName("ControlFlow42");
					Hierarchy_assert_A_ControlFlow42.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_assert_A_ControlFlow42.SetSource(Hierarchy_assert_A_a_b_size_);
					Hierarchy_assert_A_ControlFlow42.SetTarget(Hierarchy_assert_A_String_a_b_size);
				Hierarchy_assert_A.AddEdge(Hierarchy_assert_A_ControlFlow42);
					// ObjectFlow ObjectFlow104 from result to listSize
					Hierarchy_assert_A_ObjectFlow104.SetName("ObjectFlow104");
					Hierarchy_assert_A_ObjectFlow104.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_assert_A_ObjectFlow104.SetSource(Hierarchy_assert_A_a_b_size__result);
					Hierarchy_assert_A_ObjectFlow104.SetTarget(Hierarchy_assert_A_Test_a_b_size_listSize);
						// LiteralBoolean LiteralBoolean105
						Hierarchy_assert_A_ObjectFlow104_LiteralBoolean105.SetName("LiteralBoolean105");
						Hierarchy_assert_A_ObjectFlow104_LiteralBoolean105.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_ObjectFlow104_LiteralBoolean105.SetValue(true);
					Hierarchy_assert_A_ObjectFlow104.SetGuard(Hierarchy_assert_A_ObjectFlow104_LiteralBoolean105);
				Hierarchy_assert_A.AddEdge(Hierarchy_assert_A_ObjectFlow104);
					// ObjectFlow ObjectFlow107 from result to value
					Hierarchy_assert_A_ObjectFlow107.SetName("ObjectFlow107");
					Hierarchy_assert_A_ObjectFlow107.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_assert_A_ObjectFlow107.SetSource(Hierarchy_assert_A_String_a_b_c_size_result);
					Hierarchy_assert_A_ObjectFlow107.SetTarget(Hierarchy_assert_A_WriteLine_a_b_c_value);
						// LiteralBoolean LiteralBoolean108
						Hierarchy_assert_A_ObjectFlow107_LiteralBoolean108.SetName("LiteralBoolean108");
						Hierarchy_assert_A_ObjectFlow107_LiteralBoolean108.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_ObjectFlow107_LiteralBoolean108.SetValue(true);
					Hierarchy_assert_A_ObjectFlow107.SetGuard(Hierarchy_assert_A_ObjectFlow107_LiteralBoolean108);
				Hierarchy_assert_A.AddEdge(Hierarchy_assert_A_ObjectFlow107);
					// ObjectFlow ObjectFlow120 from Fork a.b.c to object
					Hierarchy_assert_A_ObjectFlow120.SetName("ObjectFlow120");
					Hierarchy_assert_A_ObjectFlow120.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_assert_A_ObjectFlow120.SetSource(Hierarchy_assert_A_Fork_a_b_c);
					Hierarchy_assert_A_ObjectFlow120.SetTarget(Hierarchy_assert_A_Read_a_b_c_d_object);
						// LiteralBoolean LiteralBoolean121
						Hierarchy_assert_A_ObjectFlow120_LiteralBoolean121.SetName("LiteralBoolean121");
						Hierarchy_assert_A_ObjectFlow120_LiteralBoolean121.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_ObjectFlow120_LiteralBoolean121.SetValue(true);
					Hierarchy_assert_A_ObjectFlow120.SetGuard(Hierarchy_assert_A_ObjectFlow120_LiteralBoolean121);
				Hierarchy_assert_A.AddEdge(Hierarchy_assert_A_ObjectFlow120);
					// ControlFlow ControlFlow58 from WriteLine_a.b.c.d to Test a.b.c.d.size
					Hierarchy_assert_A_ControlFlow58.SetName("ControlFlow58");
					Hierarchy_assert_A_ControlFlow58.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_assert_A_ControlFlow58.SetSource(Hierarchy_assert_A_WriteLine_a_b_c_d);
					Hierarchy_assert_A_ControlFlow58.SetTarget(Hierarchy_assert_A_Test_a_b_c_d_size);
				Hierarchy_assert_A.AddEdge(Hierarchy_assert_A_ControlFlow58);
					// ObjectFlow ObjectFlow123 from result to listSize
					Hierarchy_assert_A_ObjectFlow123.SetName("ObjectFlow123");
					Hierarchy_assert_A_ObjectFlow123.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_assert_A_ObjectFlow123.SetSource(Hierarchy_assert_A_a_b_c_d_e_size__result);
					Hierarchy_assert_A_ObjectFlow123.SetTarget(Hierarchy_assert_A_Test_a_b_c_d_e_size_listSize);
						// LiteralBoolean LiteralBoolean124
						Hierarchy_assert_A_ObjectFlow123_LiteralBoolean124.SetName("LiteralBoolean124");
						Hierarchy_assert_A_ObjectFlow123_LiteralBoolean124.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_ObjectFlow123_LiteralBoolean124.SetValue(true);
					Hierarchy_assert_A_ObjectFlow123.SetGuard(Hierarchy_assert_A_ObjectFlow123_LiteralBoolean124);
				Hierarchy_assert_A.AddEdge(Hierarchy_assert_A_ObjectFlow123);
					// ObjectFlow ObjectFlow65 from result to value
					Hierarchy_assert_A_ObjectFlow65.SetName("ObjectFlow65");
					Hierarchy_assert_A_ObjectFlow65.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_assert_A_ObjectFlow65.SetSource(Hierarchy_assert_A_String_a_b_size_result);
					Hierarchy_assert_A_ObjectFlow65.SetTarget(Hierarchy_assert_A_WriteLine_a_b_value);
						// LiteralBoolean LiteralBoolean67
						Hierarchy_assert_A_ObjectFlow65_LiteralBoolean67.SetName("LiteralBoolean67");
						Hierarchy_assert_A_ObjectFlow65_LiteralBoolean67.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_ObjectFlow65_LiteralBoolean67.SetValue(true);
					Hierarchy_assert_A_ObjectFlow65.SetGuard(Hierarchy_assert_A_ObjectFlow65_LiteralBoolean67);
				Hierarchy_assert_A.AddEdge(Hierarchy_assert_A_ObjectFlow65);
					// ObjectFlow ObjectFlow126 from Fork a.b.c to list
					Hierarchy_assert_A_ObjectFlow126.SetName("ObjectFlow126");
					Hierarchy_assert_A_ObjectFlow126.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_assert_A_ObjectFlow126.SetSource(Hierarchy_assert_A_Fork_a_b_c);
					Hierarchy_assert_A_ObjectFlow126.SetTarget(Hierarchy_assert_A_a_b_c_size__list);
						// LiteralBoolean LiteralBoolean127
						Hierarchy_assert_A_ObjectFlow126_LiteralBoolean127.SetName("LiteralBoolean127");
						Hierarchy_assert_A_ObjectFlow126_LiteralBoolean127.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_ObjectFlow126_LiteralBoolean127.SetValue(true);
					Hierarchy_assert_A_ObjectFlow126.SetGuard(Hierarchy_assert_A_ObjectFlow126_LiteralBoolean127);
				Hierarchy_assert_A.AddEdge(Hierarchy_assert_A_ObjectFlow126);
					// ControlFlow ControlFlow135 from a.b.c.d.e.size() to String(a.b.c.d.e.size)
					Hierarchy_assert_A_ControlFlow135.SetName("ControlFlow135");
					Hierarchy_assert_A_ControlFlow135.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_assert_A_ControlFlow135.SetSource(Hierarchy_assert_A_a_b_c_d_e_size_);
					Hierarchy_assert_A_ControlFlow135.SetTarget(Hierarchy_assert_A_String_a_b_c_d_e_size);
				Hierarchy_assert_A.AddEdge(Hierarchy_assert_A_ControlFlow135);
					// ObjectFlow ObjectFlow69 from result to value
					Hierarchy_assert_A_ObjectFlow69.SetName("ObjectFlow69");
					Hierarchy_assert_A_ObjectFlow69.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_assert_A_ObjectFlow69.SetSource(Hierarchy_assert_A_String_a_b_c_d_size_result);
					Hierarchy_assert_A_ObjectFlow69.SetTarget(Hierarchy_assert_A_WriteLine_a_b_c_d_value);
						// LiteralBoolean LiteralBoolean71
						Hierarchy_assert_A_ObjectFlow69_LiteralBoolean71.SetName("LiteralBoolean71");
						Hierarchy_assert_A_ObjectFlow69_LiteralBoolean71.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_ObjectFlow69_LiteralBoolean71.SetValue(true);
					Hierarchy_assert_A_ObjectFlow69.SetGuard(Hierarchy_assert_A_ObjectFlow69_LiteralBoolean71);
				Hierarchy_assert_A.AddEdge(Hierarchy_assert_A_ObjectFlow69);
					// ObjectFlow ObjectFlow139 from Fork a.b.c.d to object
					Hierarchy_assert_A_ObjectFlow139.SetName("ObjectFlow139");
					Hierarchy_assert_A_ObjectFlow139.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_assert_A_ObjectFlow139.SetSource(Hierarchy_assert_A_Fork_a_b_c_d);
					Hierarchy_assert_A_ObjectFlow139.SetTarget(Hierarchy_assert_A_Read_a_b_c_d_e_object);
						// LiteralBoolean LiteralBoolean141
						Hierarchy_assert_A_ObjectFlow139_LiteralBoolean141.SetName("LiteralBoolean141");
						Hierarchy_assert_A_ObjectFlow139_LiteralBoolean141.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_ObjectFlow139_LiteralBoolean141.SetValue(true);
					Hierarchy_assert_A_ObjectFlow139.SetGuard(Hierarchy_assert_A_ObjectFlow139_LiteralBoolean141);
				Hierarchy_assert_A.AddEdge(Hierarchy_assert_A_ObjectFlow139);
					// ObjectFlow ObjectFlow142 from result to value
					Hierarchy_assert_A_ObjectFlow142.SetName("ObjectFlow142");
					Hierarchy_assert_A_ObjectFlow142.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_assert_A_ObjectFlow142.SetSource(Hierarchy_assert_A_String_a_b_c_d_e_size_result);
					Hierarchy_assert_A_ObjectFlow142.SetTarget(Hierarchy_assert_A_WriteLine_a_b_c_d_e_value);
						// LiteralBoolean LiteralBoolean144
						Hierarchy_assert_A_ObjectFlow142_LiteralBoolean144.SetName("LiteralBoolean144");
						Hierarchy_assert_A_ObjectFlow142_LiteralBoolean144.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_ObjectFlow142_LiteralBoolean144.SetValue(true);
					Hierarchy_assert_A_ObjectFlow142.SetGuard(Hierarchy_assert_A_ObjectFlow142_LiteralBoolean144);
				Hierarchy_assert_A.AddEdge(Hierarchy_assert_A_ObjectFlow142);
					// ObjectFlow ObjectFlow149 from a_node to object
					Hierarchy_assert_A_ObjectFlow149.SetName("ObjectFlow149");
					Hierarchy_assert_A_ObjectFlow149.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_assert_A_ObjectFlow149.SetSource(Hierarchy_assert_A_a_node);
					Hierarchy_assert_A_ObjectFlow149.SetTarget(Hierarchy_assert_A_Read_a_b_object);
						// LiteralBoolean LiteralBoolean150
						Hierarchy_assert_A_ObjectFlow149_LiteralBoolean150.SetName("LiteralBoolean150");
						Hierarchy_assert_A_ObjectFlow149_LiteralBoolean150.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_ObjectFlow149_LiteralBoolean150.SetValue(true);
					Hierarchy_assert_A_ObjectFlow149.SetGuard(Hierarchy_assert_A_ObjectFlow149_LiteralBoolean150);
				Hierarchy_assert_A.AddEdge(Hierarchy_assert_A_ObjectFlow149);
					// ControlFlow ControlFlow72 from WriteLine_a.b.c to Test a.b.c.size
					Hierarchy_assert_A_ControlFlow72.SetName("ControlFlow72");
					Hierarchy_assert_A_ControlFlow72.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_assert_A_ControlFlow72.SetSource(Hierarchy_assert_A_WriteLine_a_b_c);
					Hierarchy_assert_A_ControlFlow72.SetTarget(Hierarchy_assert_A_Test_a_b_c_size);
				Hierarchy_assert_A.AddEdge(Hierarchy_assert_A_ControlFlow72);
					// ObjectFlow ObjectFlow152 from Fork a.b to list
					Hierarchy_assert_A_ObjectFlow152.SetName("ObjectFlow152");
					Hierarchy_assert_A_ObjectFlow152.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_assert_A_ObjectFlow152.SetSource(Hierarchy_assert_A_Fork_a_b);
					Hierarchy_assert_A_ObjectFlow152.SetTarget(Hierarchy_assert_A_a_b_size__list);
						// LiteralBoolean LiteralBoolean153
						Hierarchy_assert_A_ObjectFlow152_LiteralBoolean153.SetName("LiteralBoolean153");
						Hierarchy_assert_A_ObjectFlow152_LiteralBoolean153.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_ObjectFlow152_LiteralBoolean153.SetValue(true);
					Hierarchy_assert_A_ObjectFlow152.SetGuard(Hierarchy_assert_A_ObjectFlow152_LiteralBoolean153);
				Hierarchy_assert_A.AddEdge(Hierarchy_assert_A_ObjectFlow152);
					// ObjectFlow ObjectFlow76 from result to list
					Hierarchy_assert_A_ObjectFlow76.SetName("ObjectFlow76");
					Hierarchy_assert_A_ObjectFlow76.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_assert_A_ObjectFlow76.SetSource(Hierarchy_assert_A_Read_a_b_c_d_e_result);
					Hierarchy_assert_A_ObjectFlow76.SetTarget(Hierarchy_assert_A_a_b_c_d_e_size__list);
						// LiteralBoolean LiteralBoolean78
						Hierarchy_assert_A_ObjectFlow76_LiteralBoolean78.SetName("LiteralBoolean78");
						Hierarchy_assert_A_ObjectFlow76_LiteralBoolean78.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_ObjectFlow76_LiteralBoolean78.SetValue(true);
					Hierarchy_assert_A_ObjectFlow76.SetGuard(Hierarchy_assert_A_ObjectFlow76_LiteralBoolean78);
				Hierarchy_assert_A.AddEdge(Hierarchy_assert_A_ObjectFlow76);
					// ControlFlow ControlFlow79 from Test a.b.c.d.size to Read a.b.c.d.e
					Hierarchy_assert_A_ControlFlow79.SetName("ControlFlow79");
					Hierarchy_assert_A_ControlFlow79.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_assert_A_ControlFlow79.SetSource(Hierarchy_assert_A_Test_a_b_c_d_size);
					Hierarchy_assert_A_ControlFlow79.SetTarget(Hierarchy_assert_A_Read_a_b_c_d_e);
				Hierarchy_assert_A.AddEdge(Hierarchy_assert_A_ControlFlow79);
					// ObjectFlow ObjectFlow159 from result to listSize
					Hierarchy_assert_A_ObjectFlow159.SetName("ObjectFlow159");
					Hierarchy_assert_A_ObjectFlow159.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_assert_A_ObjectFlow159.SetSource(Hierarchy_assert_A_a_b_c_d_size__result);
					Hierarchy_assert_A_ObjectFlow159.SetTarget(Hierarchy_assert_A_Test_a_b_c_d_size_listSize);
						// LiteralBoolean LiteralBoolean161
						Hierarchy_assert_A_ObjectFlow159_LiteralBoolean161.SetName("LiteralBoolean161");
						Hierarchy_assert_A_ObjectFlow159_LiteralBoolean161.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_ObjectFlow159_LiteralBoolean161.SetValue(true);
					Hierarchy_assert_A_ObjectFlow159.SetGuard(Hierarchy_assert_A_ObjectFlow159_LiteralBoolean161);
				Hierarchy_assert_A.AddEdge(Hierarchy_assert_A_ObjectFlow159);
					// ControlFlow ControlFlow80 from Test a.b.c.size to Read a.b.c.d
					Hierarchy_assert_A_ControlFlow80.SetName("ControlFlow80");
					Hierarchy_assert_A_ControlFlow80.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_assert_A_ControlFlow80.SetSource(Hierarchy_assert_A_Test_a_b_c_size);
					Hierarchy_assert_A_ControlFlow80.SetTarget(Hierarchy_assert_A_Read_a_b_c_d);
				Hierarchy_assert_A.AddEdge(Hierarchy_assert_A_ControlFlow80);
					// ControlFlow ControlFlow81 from Test a.b.size to Read a.b.c
					Hierarchy_assert_A_ControlFlow81.SetName("ControlFlow81");
					Hierarchy_assert_A_ControlFlow81.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_assert_A_ControlFlow81.SetSource(Hierarchy_assert_A_Test_a_b_size);
					Hierarchy_assert_A_ControlFlow81.SetTarget(Hierarchy_assert_A_Read_a_b_c);
				Hierarchy_assert_A.AddEdge(Hierarchy_assert_A_ControlFlow81);
					// ObjectFlow ObjectFlow162 from Fork a.b.c.d to list
					Hierarchy_assert_A_ObjectFlow162.SetName("ObjectFlow162");
					Hierarchy_assert_A_ObjectFlow162.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_assert_A_ObjectFlow162.SetSource(Hierarchy_assert_A_Fork_a_b_c_d);
					Hierarchy_assert_A_ObjectFlow162.SetTarget(Hierarchy_assert_A_a_b_c_d_size__list);
						// LiteralBoolean LiteralBoolean163
						Hierarchy_assert_A_ObjectFlow162_LiteralBoolean163.SetName("LiteralBoolean163");
						Hierarchy_assert_A_ObjectFlow162_LiteralBoolean163.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_ObjectFlow162_LiteralBoolean163.SetValue(true);
					Hierarchy_assert_A_ObjectFlow162.SetGuard(Hierarchy_assert_A_ObjectFlow162_LiteralBoolean163);
				Hierarchy_assert_A.AddEdge(Hierarchy_assert_A_ObjectFlow162);
					// ObjectFlow ObjectFlow168 from Fork a.b to object
					Hierarchy_assert_A_ObjectFlow168.SetName("ObjectFlow168");
					Hierarchy_assert_A_ObjectFlow168.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_assert_A_ObjectFlow168.SetSource(Hierarchy_assert_A_Fork_a_b);
					Hierarchy_assert_A_ObjectFlow168.SetTarget(Hierarchy_assert_A_Read_a_b_c_object);
						// LiteralBoolean LiteralBoolean170
						Hierarchy_assert_A_ObjectFlow168_LiteralBoolean170.SetName("LiteralBoolean170");
						Hierarchy_assert_A_ObjectFlow168_LiteralBoolean170.SetVisibility(VisibilityKind.public_);
						Hierarchy_assert_A_ObjectFlow168_LiteralBoolean170.SetValue(true);
					Hierarchy_assert_A_ObjectFlow168.SetGuard(Hierarchy_assert_A_ObjectFlow168_LiteralBoolean170);
				Hierarchy_assert_A.AddEdge(Hierarchy_assert_A_ObjectFlow168);
			Hierarchy.AddPackagedElement(Hierarchy_assert_A);
				// Class B
				Hierarchy_B.SetName("B");
				Hierarchy_B.SetVisibility(VisibilityKind.public_);
				
					// Property c
					Hierarchy_B_c.SetName("c");
					Hierarchy_B_c.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_B_c.SetType(Hierarchy_C);
					Hierarchy_B_c.SetAggregation(AggregationKind.composite);
				Hierarchy_B.AddOwnedAttribute(Hierarchy_B_c);
			Hierarchy.AddPackagedElement(Hierarchy_B);
				// Class D
				Hierarchy_D.SetName("D");
				Hierarchy_D.SetVisibility(VisibilityKind.public_);
				
					// Property e
					Hierarchy_D_e.SetName("e");
					Hierarchy_D_e.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_D_e.SetType(Hierarchy_E);
					Hierarchy_D_e.SetAggregation(AggregationKind.shared);
				Hierarchy_D.AddOwnedAttribute(Hierarchy_D_e);
			Hierarchy.AddPackagedElement(Hierarchy_D);
				// Class E
				Hierarchy_E.SetName("E");
				Hierarchy_E.SetVisibility(VisibilityKind.public_);
			Hierarchy.AddPackagedElement(Hierarchy_E);
				// Class A
				Hierarchy_A.SetName("A");
				Hierarchy_A.SetVisibility(VisibilityKind.public_);
				
					// Property b
					Hierarchy_A_b.SetName("b");
					Hierarchy_A_b.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_A_b.SetType(Hierarchy_B);
					Hierarchy_A_b.SetAggregation(AggregationKind.composite);
				Hierarchy_A.AddOwnedAttribute(Hierarchy_A_b);
				
				
					// Operation A_A
					Hierarchy_A_A_A.SetName("A_A");
					Hierarchy_A_A_A.SetVisibility(VisibilityKind.public_);
						// Parameter result
						Hierarchy_A_A_A_result.SetName("result");
						Hierarchy_A_A_A_result.SetVisibility(VisibilityKind.public_);
						
						Hierarchy_A_A_A_result.SetType(Hierarchy_A);
						Hierarchy_A_A_A_result.SetDirection(ParameterDirectionKind.return_);
					Hierarchy_A_A_A.AddOwnedParameter(Hierarchy_A_A_A_result);
					Hierarchy_A_A_A.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				Hierarchy_A.AddOwnedOperation(Hierarchy_A_A_A);
			Hierarchy.AddPackagedElement(Hierarchy_A);
				// Activity main
				Hierarchy_main.SetName("main");
				Hierarchy_main.SetVisibility(VisibilityKind.public_);
					// CallBehaviorAction instantiate_A
					Hierarchy_main_instantiate_A.SetName("instantiate_A");
					Hierarchy_main_instantiate_A.SetVisibility(VisibilityKind.public_);
					
						// OutputPin a
						Hierarchy_main_instantiate_A_a.SetName("a");
						Hierarchy_main_instantiate_A_a.SetVisibility(VisibilityKind.public_);
						Hierarchy_main_instantiate_A_a.SetType(Hierarchy_A);
					Hierarchy_main_instantiate_A.AddResult(Hierarchy_main_instantiate_A_a);
					Hierarchy_main_instantiate_A.SetBehavior(Hierarchy_instantiate_A);
				Hierarchy_main.AddNode(Hierarchy_main_instantiate_A);
					// CallBehaviorAction assert_A
					Hierarchy_main_assert_A.SetName("assert_A");
					Hierarchy_main_assert_A.SetVisibility(VisibilityKind.public_);
					Hierarchy_main_assert_A.SetBehavior(Hierarchy_assert_A);
						// InputPin a
						Hierarchy_main_assert_A_a.SetName("a");
						Hierarchy_main_assert_A_a.SetVisibility(VisibilityKind.public_);
					Hierarchy_main_assert_A.AddArgument(Hierarchy_main_assert_A_a);
				Hierarchy_main.AddNode(Hierarchy_main_assert_A);
					// ObjectFlow ObjectFlow171 from a to a
					Hierarchy_main_ObjectFlow171.SetName("ObjectFlow171");
					Hierarchy_main_ObjectFlow171.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_main_ObjectFlow171.SetSource(Hierarchy_main_instantiate_A_a);
					Hierarchy_main_ObjectFlow171.SetTarget(Hierarchy_main_assert_A_a);
						// LiteralBoolean LiteralBoolean172
						Hierarchy_main_ObjectFlow171_LiteralBoolean172.SetName("LiteralBoolean172");
						Hierarchy_main_ObjectFlow171_LiteralBoolean172.SetVisibility(VisibilityKind.public_);
						Hierarchy_main_ObjectFlow171_LiteralBoolean172.SetValue(true);
					Hierarchy_main_ObjectFlow171.SetGuard(Hierarchy_main_ObjectFlow171_LiteralBoolean172);
				Hierarchy_main.AddEdge(Hierarchy_main_ObjectFlow171);
			Hierarchy.AddPackagedElement(Hierarchy_main);
				// Class C
				Hierarchy_C.SetName("C");
				Hierarchy_C.SetVisibility(VisibilityKind.public_);
				
					// Property d
					Hierarchy_C_d.SetName("d");
					Hierarchy_C_d.SetVisibility(VisibilityKind.public_);
					
					Hierarchy_C_d.SetType(Hierarchy_D);
					Hierarchy_C_d.SetAggregation(AggregationKind.composite);
				Hierarchy_C.AddOwnedAttribute(Hierarchy_C_d);
			Hierarchy.AddPackagedElement(Hierarchy_C);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // HierarchyModel
}
