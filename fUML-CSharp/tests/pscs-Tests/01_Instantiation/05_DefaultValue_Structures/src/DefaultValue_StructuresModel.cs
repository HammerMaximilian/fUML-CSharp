/*
 * DefaultValue_StructuresModel.cs
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

namespace DefaultValue_Structures
{
	public class DefaultValue_StructuresModel : InMemoryModel
	{
		private static DefaultValue_StructuresModel? instance;

		/*
		 * Model DefaultValue_Structures
		 */
		public Package DefaultValue_Structures = new();
			public Activity DefaultValue_Structures_instantiate_A = new();
				public CreateObjectAction DefaultValue_Structures_instantiate_A_Create_A = new();
					public OutputPin DefaultValue_Structures_instantiate_A_Create_A_result = new();
						public LiteralInteger DefaultValue_Structures_instantiate_A_Create_A_result_LiteralInteger0 = new();
						public LiteralUnlimitedNatural DefaultValue_Structures_instantiate_A_Create_A_result_LiteralUnlimitedNatural1 = new();
				public ActivityParameterNode DefaultValue_Structures_instantiate_A_a_node = new();
					public LiteralInteger DefaultValue_Structures_instantiate_A_a_node_LiteralInteger2 = new();
				public ObjectFlow DefaultValue_Structures_instantiate_A_ObjectFlow3 = new();
					public LiteralBoolean DefaultValue_Structures_instantiate_A_ObjectFlow3_LiteralBoolean4 = new();
					public LiteralInteger DefaultValue_Structures_instantiate_A_ObjectFlow3_LiteralInteger5 = new();
				public CallOperationAction DefaultValue_Structures_instantiate_A_A_ = new();
					public InputPin DefaultValue_Structures_instantiate_A_A__target = new();
						public LiteralUnlimitedNatural DefaultValue_Structures_instantiate_A_A__target_LiteralUnlimitedNatural6 = new();
						public LiteralInteger DefaultValue_Structures_instantiate_A_A__target_LiteralInteger7 = new();
					public OutputPin DefaultValue_Structures_instantiate_A_A__result = new();
						public LiteralInteger DefaultValue_Structures_instantiate_A_A__result_LiteralInteger8 = new();
						public LiteralUnlimitedNatural DefaultValue_Structures_instantiate_A_A__result_LiteralUnlimitedNatural9 = new();
						public LiteralInteger DefaultValue_Structures_instantiate_A_A__result_LiteralInteger10 = new();
				public ObjectFlow DefaultValue_Structures_instantiate_A_ObjectFlow11 = new();
					public LiteralInteger DefaultValue_Structures_instantiate_A_ObjectFlow11_LiteralInteger12 = new();
					public LiteralBoolean DefaultValue_Structures_instantiate_A_ObjectFlow11_LiteralBoolean13 = new();
				public Parameter DefaultValue_Structures_instantiate_A_a = new();
			public Activity DefaultValue_Structures_assert_A = new();
				public Parameter DefaultValue_Structures_assert_A_a = new();
				public ReadStructuralFeatureAction DefaultValue_Structures_assert_A_Read_a_b = new();
					public InputPin DefaultValue_Structures_assert_A_Read_a_b_object = new();
						public LiteralUnlimitedNatural DefaultValue_Structures_assert_A_Read_a_b_object_LiteralUnlimitedNatural14 = new();
						public LiteralInteger DefaultValue_Structures_assert_A_Read_a_b_object_LiteralInteger15 = new();
					public OutputPin DefaultValue_Structures_assert_A_Read_a_b_result = new();
						public LiteralUnlimitedNatural DefaultValue_Structures_assert_A_Read_a_b_result_LiteralUnlimitedNatural16 = new();
						public LiteralInteger DefaultValue_Structures_assert_A_Read_a_b_result_LiteralInteger17 = new();
				public OpaqueBehavior DefaultValue_Structures_assert_A_testDefaultValues = new();
					public Parameter DefaultValue_Structures_assert_A_testDefaultValues_pList = new();
						public LiteralInteger DefaultValue_Structures_assert_A_testDefaultValues_pList_LiteralInteger18 = new();
						public LiteralUnlimitedNatural DefaultValue_Structures_assert_A_testDefaultValues_pList_LiteralUnlimitedNatural19 = new();
				public ObjectFlow DefaultValue_Structures_assert_A_ObjectFlow20 = new();
					public LiteralInteger DefaultValue_Structures_assert_A_ObjectFlow20_LiteralInteger21 = new();
					public LiteralBoolean DefaultValue_Structures_assert_A_ObjectFlow20_LiteralBoolean22 = new();
				public ObjectFlow DefaultValue_Structures_assert_A_ObjectFlow23 = new();
					public LiteralBoolean DefaultValue_Structures_assert_A_ObjectFlow23_LiteralBoolean24 = new();
					public LiteralInteger DefaultValue_Structures_assert_A_ObjectFlow23_LiteralInteger25 = new();
				public CallBehaviorAction DefaultValue_Structures_assert_A_Test_Default_Values = new();
					public InputPin DefaultValue_Structures_assert_A_Test_Default_Values_pList = new();
						public LiteralInteger DefaultValue_Structures_assert_A_Test_Default_Values_pList_LiteralInteger26 = new();
						public LiteralInteger DefaultValue_Structures_assert_A_Test_Default_Values_pList_LiteralInteger27 = new();
						public LiteralUnlimitedNatural DefaultValue_Structures_assert_A_Test_Default_Values_pList_LiteralUnlimitedNatural28 = new();
				public ObjectFlow DefaultValue_Structures_assert_A_ObjectFlow29 = new();
					public LiteralBoolean DefaultValue_Structures_assert_A_ObjectFlow29_LiteralBoolean30 = new();
					public LiteralInteger DefaultValue_Structures_assert_A_ObjectFlow29_LiteralInteger31 = new();
				public ReadStructuralFeatureAction DefaultValue_Structures_assert_A_Read_b_p = new();
					public OutputPin DefaultValue_Structures_assert_A_Read_b_p_result = new();
						public LiteralUnlimitedNatural DefaultValue_Structures_assert_A_Read_b_p_result_LiteralUnlimitedNatural32 = new();
						public LiteralInteger DefaultValue_Structures_assert_A_Read_b_p_result_LiteralInteger33 = new();
					public InputPin DefaultValue_Structures_assert_A_Read_b_p_object = new();
						public LiteralUnlimitedNatural DefaultValue_Structures_assert_A_Read_b_p_object_LiteralUnlimitedNatural34 = new();
						public LiteralInteger DefaultValue_Structures_assert_A_Read_b_p_object_LiteralInteger35 = new();
				public ActivityParameterNode DefaultValue_Structures_assert_A_a_node = new();
					public LiteralInteger DefaultValue_Structures_assert_A_a_node_LiteralInteger36 = new();
			public Class_ DefaultValue_Structures_A = new();
				public Property DefaultValue_Structures_A_b = new();
					public LiteralInteger DefaultValue_Structures_A_b_LiteralInteger37 = new();
					public LiteralUnlimitedNatural DefaultValue_Structures_A_b_LiteralUnlimitedNatural38 = new();
					public OpaqueExpression DefaultValue_Structures_A_b_OpaqueExpression39 = new();
				public Activity DefaultValue_Structures_A_bDefaultValues = new();
					public Parameter DefaultValue_Structures_A_bDefaultValues_bList = new();
						public LiteralInteger DefaultValue_Structures_A_bDefaultValues_bList_LiteralInteger40 = new();
						public LiteralUnlimitedNatural DefaultValue_Structures_A_bDefaultValues_bList_LiteralUnlimitedNatural41 = new();
					public ObjectFlow DefaultValue_Structures_A_bDefaultValues_ObjectFlow42 = new();
						public LiteralBoolean DefaultValue_Structures_A_bDefaultValues_ObjectFlow42_LiteralBoolean43 = new();
						public LiteralInteger DefaultValue_Structures_A_bDefaultValues_ObjectFlow42_LiteralInteger44 = new();
					public ValueSpecificationAction DefaultValue_Structures_A_bDefaultValues_Integer_4 = new();
						public LiteralInteger DefaultValue_Structures_A_bDefaultValues_Integer_4_LiteralInteger45 = new();
						public OutputPin DefaultValue_Structures_A_bDefaultValues_Integer_4_result = new();
							public LiteralUnlimitedNatural DefaultValue_Structures_A_bDefaultValues_Integer_4_result_LiteralUnlimitedNatural46 = new();
							public LiteralInteger DefaultValue_Structures_A_bDefaultValues_Integer_4_result_LiteralInteger47 = new();
					public AddStructuralFeatureValueAction DefaultValue_Structures_A_bDefaultValues_B_2_p = new();
						public InputPin DefaultValue_Structures_A_bDefaultValues_B_2_p_object = new();
							public LiteralUnlimitedNatural DefaultValue_Structures_A_bDefaultValues_B_2_p_object_LiteralUnlimitedNatural48 = new();
							public LiteralInteger DefaultValue_Structures_A_bDefaultValues_B_2_p_object_LiteralInteger49 = new();
						public OutputPin DefaultValue_Structures_A_bDefaultValues_B_2_p_result = new();
							public LiteralUnlimitedNatural DefaultValue_Structures_A_bDefaultValues_B_2_p_result_LiteralUnlimitedNatural50 = new();
							public LiteralInteger DefaultValue_Structures_A_bDefaultValues_B_2_p_result_LiteralInteger51 = new();
						public InputPin DefaultValue_Structures_A_bDefaultValues_B_2_p_value = new();
							public LiteralUnlimitedNatural DefaultValue_Structures_A_bDefaultValues_B_2_p_value_LiteralUnlimitedNatural52 = new();
							public LiteralInteger DefaultValue_Structures_A_bDefaultValues_B_2_p_value_LiteralInteger53 = new();
					public CreateObjectAction DefaultValue_Structures_A_bDefaultValues_Create_B_1 = new();
						public OutputPin DefaultValue_Structures_A_bDefaultValues_Create_B_1_result = new();
							public LiteralInteger DefaultValue_Structures_A_bDefaultValues_Create_B_1_result_LiteralInteger54 = new();
							public LiteralUnlimitedNatural DefaultValue_Structures_A_bDefaultValues_Create_B_1_result_LiteralUnlimitedNatural55 = new();
					public ControlFlow DefaultValue_Structures_A_bDefaultValues_ControlFlow56 = new();
					public ObjectFlow DefaultValue_Structures_A_bDefaultValues_ObjectFlow57 = new();
						public LiteralBoolean DefaultValue_Structures_A_bDefaultValues_ObjectFlow57_LiteralBoolean58 = new();
						public LiteralInteger DefaultValue_Structures_A_bDefaultValues_ObjectFlow57_LiteralInteger59 = new();
					public ActivityParameterNode DefaultValue_Structures_A_bDefaultValues_bList_node = new();
					public ObjectFlow DefaultValue_Structures_A_bDefaultValues_ObjectFlow60 = new();
						public LiteralBoolean DefaultValue_Structures_A_bDefaultValues_ObjectFlow60_LiteralBoolean61 = new();
						public LiteralInteger DefaultValue_Structures_A_bDefaultValues_ObjectFlow60_LiteralInteger62 = new();
					public CreateObjectAction DefaultValue_Structures_A_bDefaultValues_Create_B_2 = new();
						public OutputPin DefaultValue_Structures_A_bDefaultValues_Create_B_2_result = new();
							public LiteralUnlimitedNatural DefaultValue_Structures_A_bDefaultValues_Create_B_2_result_LiteralUnlimitedNatural63 = new();
							public LiteralInteger DefaultValue_Structures_A_bDefaultValues_Create_B_2_result_LiteralInteger64 = new();
					public ObjectFlow DefaultValue_Structures_A_bDefaultValues_ObjectFlow65 = new();
						public LiteralBoolean DefaultValue_Structures_A_bDefaultValues_ObjectFlow65_LiteralBoolean66 = new();
						public LiteralInteger DefaultValue_Structures_A_bDefaultValues_ObjectFlow65_LiteralInteger67 = new();
					public ObjectFlow DefaultValue_Structures_A_bDefaultValues_ObjectFlow68 = new();
						public LiteralInteger DefaultValue_Structures_A_bDefaultValues_ObjectFlow68_LiteralInteger69 = new();
						public LiteralBoolean DefaultValue_Structures_A_bDefaultValues_ObjectFlow68_LiteralBoolean70 = new();
					public ObjectFlow DefaultValue_Structures_A_bDefaultValues_ObjectFlow71 = new();
						public LiteralInteger DefaultValue_Structures_A_bDefaultValues_ObjectFlow71_LiteralInteger72 = new();
						public LiteralBoolean DefaultValue_Structures_A_bDefaultValues_ObjectFlow71_LiteralBoolean73 = new();
					public ObjectFlow DefaultValue_Structures_A_bDefaultValues_ObjectFlow74 = new();
						public LiteralBoolean DefaultValue_Structures_A_bDefaultValues_ObjectFlow74_LiteralBoolean75 = new();
						public LiteralInteger DefaultValue_Structures_A_bDefaultValues_ObjectFlow74_LiteralInteger76 = new();
					public ControlFlow DefaultValue_Structures_A_bDefaultValues_ControlFlow77 = new();
					public AddStructuralFeatureValueAction DefaultValue_Structures_A_bDefaultValues_B_4_p = new();
						public InputPin DefaultValue_Structures_A_bDefaultValues_B_4_p_value = new();
							public LiteralUnlimitedNatural DefaultValue_Structures_A_bDefaultValues_B_4_p_value_LiteralUnlimitedNatural78 = new();
							public LiteralInteger DefaultValue_Structures_A_bDefaultValues_B_4_p_value_LiteralInteger79 = new();
						public InputPin DefaultValue_Structures_A_bDefaultValues_B_4_p_object = new();
							public LiteralInteger DefaultValue_Structures_A_bDefaultValues_B_4_p_object_LiteralInteger80 = new();
							public LiteralUnlimitedNatural DefaultValue_Structures_A_bDefaultValues_B_4_p_object_LiteralUnlimitedNatural81 = new();
						public OutputPin DefaultValue_Structures_A_bDefaultValues_B_4_p_result = new();
							public LiteralUnlimitedNatural DefaultValue_Structures_A_bDefaultValues_B_4_p_result_LiteralUnlimitedNatural82 = new();
							public LiteralInteger DefaultValue_Structures_A_bDefaultValues_B_4_p_result_LiteralInteger83 = new();
					public ValueSpecificationAction DefaultValue_Structures_A_bDefaultValues_Integer_2 = new();
						public LiteralInteger DefaultValue_Structures_A_bDefaultValues_Integer_2_LiteralInteger84 = new();
						public OutputPin DefaultValue_Structures_A_bDefaultValues_Integer_2_result = new();
							public LiteralUnlimitedNatural DefaultValue_Structures_A_bDefaultValues_Integer_2_result_LiteralUnlimitedNatural85 = new();
							public LiteralInteger DefaultValue_Structures_A_bDefaultValues_Integer_2_result_LiteralInteger86 = new();
					public ObjectFlow DefaultValue_Structures_A_bDefaultValues_ObjectFlow87 = new();
						public LiteralInteger DefaultValue_Structures_A_bDefaultValues_ObjectFlow87_LiteralInteger88 = new();
						public LiteralBoolean DefaultValue_Structures_A_bDefaultValues_ObjectFlow87_LiteralBoolean89 = new();
					public AddStructuralFeatureValueAction DefaultValue_Structures_A_bDefaultValues_B_1_p = new();
						public InputPin DefaultValue_Structures_A_bDefaultValues_B_1_p_object = new();
							public LiteralUnlimitedNatural DefaultValue_Structures_A_bDefaultValues_B_1_p_object_LiteralUnlimitedNatural90 = new();
							public LiteralInteger DefaultValue_Structures_A_bDefaultValues_B_1_p_object_LiteralInteger91 = new();
						public OutputPin DefaultValue_Structures_A_bDefaultValues_B_1_p_result = new();
							public LiteralInteger DefaultValue_Structures_A_bDefaultValues_B_1_p_result_LiteralInteger92 = new();
							public LiteralUnlimitedNatural DefaultValue_Structures_A_bDefaultValues_B_1_p_result_LiteralUnlimitedNatural93 = new();
						public InputPin DefaultValue_Structures_A_bDefaultValues_B_1_p_value = new();
							public LiteralUnlimitedNatural DefaultValue_Structures_A_bDefaultValues_B_1_p_value_LiteralUnlimitedNatural94 = new();
							public LiteralInteger DefaultValue_Structures_A_bDefaultValues_B_1_p_value_LiteralInteger95 = new();
					public ObjectFlow DefaultValue_Structures_A_bDefaultValues_ObjectFlow96 = new();
						public LiteralBoolean DefaultValue_Structures_A_bDefaultValues_ObjectFlow96_LiteralBoolean97 = new();
						public LiteralInteger DefaultValue_Structures_A_bDefaultValues_ObjectFlow96_LiteralInteger98 = new();
					public ObjectFlow DefaultValue_Structures_A_bDefaultValues_ObjectFlow99 = new();
						public LiteralBoolean DefaultValue_Structures_A_bDefaultValues_ObjectFlow99_LiteralBoolean100 = new();
						public LiteralInteger DefaultValue_Structures_A_bDefaultValues_ObjectFlow99_LiteralInteger101 = new();
					public ObjectFlow DefaultValue_Structures_A_bDefaultValues_ObjectFlow102 = new();
						public LiteralInteger DefaultValue_Structures_A_bDefaultValues_ObjectFlow102_LiteralInteger103 = new();
						public LiteralBoolean DefaultValue_Structures_A_bDefaultValues_ObjectFlow102_LiteralBoolean104 = new();
					public ControlFlow DefaultValue_Structures_A_bDefaultValues_ControlFlow105 = new();
					public AddStructuralFeatureValueAction DefaultValue_Structures_A_bDefaultValues_B_3_p = new();
						public OutputPin DefaultValue_Structures_A_bDefaultValues_B_3_p_result = new();
							public LiteralUnlimitedNatural DefaultValue_Structures_A_bDefaultValues_B_3_p_result_LiteralUnlimitedNatural106 = new();
							public LiteralInteger DefaultValue_Structures_A_bDefaultValues_B_3_p_result_LiteralInteger107 = new();
						public InputPin DefaultValue_Structures_A_bDefaultValues_B_3_p_value = new();
							public LiteralInteger DefaultValue_Structures_A_bDefaultValues_B_3_p_value_LiteralInteger108 = new();
							public LiteralUnlimitedNatural DefaultValue_Structures_A_bDefaultValues_B_3_p_value_LiteralUnlimitedNatural109 = new();
						public InputPin DefaultValue_Structures_A_bDefaultValues_B_3_p_object = new();
							public LiteralInteger DefaultValue_Structures_A_bDefaultValues_B_3_p_object_LiteralInteger110 = new();
							public LiteralUnlimitedNatural DefaultValue_Structures_A_bDefaultValues_B_3_p_object_LiteralUnlimitedNatural111 = new();
					public CreateObjectAction DefaultValue_Structures_A_bDefaultValues_Create_B_3 = new();
						public OutputPin DefaultValue_Structures_A_bDefaultValues_Create_B_3_result = new();
							public LiteralInteger DefaultValue_Structures_A_bDefaultValues_Create_B_3_result_LiteralInteger112 = new();
							public LiteralUnlimitedNatural DefaultValue_Structures_A_bDefaultValues_Create_B_3_result_LiteralUnlimitedNatural113 = new();
					public ObjectFlow DefaultValue_Structures_A_bDefaultValues_ObjectFlow114 = new();
						public LiteralBoolean DefaultValue_Structures_A_bDefaultValues_ObjectFlow114_LiteralBoolean115 = new();
						public LiteralInteger DefaultValue_Structures_A_bDefaultValues_ObjectFlow114_LiteralInteger116 = new();
					public CreateObjectAction DefaultValue_Structures_A_bDefaultValues_Create_B_4 = new();
						public OutputPin DefaultValue_Structures_A_bDefaultValues_Create_B_4_result = new();
							public LiteralUnlimitedNatural DefaultValue_Structures_A_bDefaultValues_Create_B_4_result_LiteralUnlimitedNatural117 = new();
							public LiteralInteger DefaultValue_Structures_A_bDefaultValues_Create_B_4_result_LiteralInteger118 = new();
					public ValueSpecificationAction DefaultValue_Structures_A_bDefaultValues_Integer_3 = new();
						public OutputPin DefaultValue_Structures_A_bDefaultValues_Integer_3_result = new();
							public LiteralUnlimitedNatural DefaultValue_Structures_A_bDefaultValues_Integer_3_result_LiteralUnlimitedNatural119 = new();
							public LiteralInteger DefaultValue_Structures_A_bDefaultValues_Integer_3_result_LiteralInteger120 = new();
						public LiteralInteger DefaultValue_Structures_A_bDefaultValues_Integer_3_LiteralInteger121 = new();
					public ValueSpecificationAction DefaultValue_Structures_A_bDefaultValues_Integer_1 = new();
						public OutputPin DefaultValue_Structures_A_bDefaultValues_Integer_1_result = new();
							public LiteralUnlimitedNatural DefaultValue_Structures_A_bDefaultValues_Integer_1_result_LiteralUnlimitedNatural122 = new();
							public LiteralInteger DefaultValue_Structures_A_bDefaultValues_Integer_1_result_LiteralInteger123 = new();
						public LiteralInteger DefaultValue_Structures_A_bDefaultValues_Integer_1_LiteralInteger124 = new();
				public Operation DefaultValue_Structures_A_A_A = new();
					public Parameter DefaultValue_Structures_A_A_A_result = new();
			public Class_ DefaultValue_Structures_B = new();
				public Property DefaultValue_Structures_B_p = new();
				public Operation DefaultValue_Structures_B_B_B = new();
					public Parameter DefaultValue_Structures_B_B_B_result = new();
			public Activity DefaultValue_Structures_main = new();
				public CallBehaviorAction DefaultValue_Structures_main_instantiate_A = new();
					public OutputPin DefaultValue_Structures_main_instantiate_A_a = new();
						public LiteralUnlimitedNatural DefaultValue_Structures_main_instantiate_A_a_LiteralUnlimitedNatural125 = new();
						public LiteralInteger DefaultValue_Structures_main_instantiate_A_a_LiteralInteger126 = new();
						public LiteralInteger DefaultValue_Structures_main_instantiate_A_a_LiteralInteger127 = new();
				public CallBehaviorAction DefaultValue_Structures_main_assert_A = new();
					public InputPin DefaultValue_Structures_main_assert_A_a = new();
						public LiteralUnlimitedNatural DefaultValue_Structures_main_assert_A_a_LiteralUnlimitedNatural128 = new();
						public LiteralInteger DefaultValue_Structures_main_assert_A_a_LiteralInteger129 = new();
						public LiteralInteger DefaultValue_Structures_main_assert_A_a_LiteralInteger130 = new();
				public ObjectFlow DefaultValue_Structures_main_ObjectFlow131 = new();
					public LiteralInteger DefaultValue_Structures_main_ObjectFlow131_LiteralInteger132 = new();
					public LiteralBoolean DefaultValue_Structures_main_ObjectFlow131_LiteralBoolean133 = new();

		public static DefaultValue_StructuresModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public DefaultValue_StructuresModel()
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
			 * Model DefaultValue_Structures
			 */
			AddToElementRepository("DefaultValue_Structures", DefaultValue_Structures);
				AddToElementRepository("instantiate_A", DefaultValue_Structures_instantiate_A);
					AddToElementRepository("Create_A", DefaultValue_Structures_instantiate_A_Create_A);
						AddToElementRepository("result", DefaultValue_Structures_instantiate_A_Create_A_result);
							AddToElementRepository("LiteralInteger0", DefaultValue_Structures_instantiate_A_Create_A_result_LiteralInteger0);
							AddToElementRepository("LiteralUnlimitedNatural1", DefaultValue_Structures_instantiate_A_Create_A_result_LiteralUnlimitedNatural1);
					AddToElementRepository("a_node", DefaultValue_Structures_instantiate_A_a_node);
						AddToElementRepository("LiteralInteger2", DefaultValue_Structures_instantiate_A_a_node_LiteralInteger2);
					AddToElementRepository("ObjectFlow3", DefaultValue_Structures_instantiate_A_ObjectFlow3);
						AddToElementRepository("LiteralBoolean4", DefaultValue_Structures_instantiate_A_ObjectFlow3_LiteralBoolean4);
						AddToElementRepository("LiteralInteger5", DefaultValue_Structures_instantiate_A_ObjectFlow3_LiteralInteger5);
					AddToElementRepository("A()", DefaultValue_Structures_instantiate_A_A_);
						AddToElementRepository("target", DefaultValue_Structures_instantiate_A_A__target);
							AddToElementRepository("LiteralUnlimitedNatural6", DefaultValue_Structures_instantiate_A_A__target_LiteralUnlimitedNatural6);
							AddToElementRepository("LiteralInteger7", DefaultValue_Structures_instantiate_A_A__target_LiteralInteger7);
						AddToElementRepository("result", DefaultValue_Structures_instantiate_A_A__result);
							AddToElementRepository("LiteralInteger8", DefaultValue_Structures_instantiate_A_A__result_LiteralInteger8);
							AddToElementRepository("LiteralUnlimitedNatural9", DefaultValue_Structures_instantiate_A_A__result_LiteralUnlimitedNatural9);
							AddToElementRepository("LiteralInteger10", DefaultValue_Structures_instantiate_A_A__result_LiteralInteger10);
					AddToElementRepository("ObjectFlow11", DefaultValue_Structures_instantiate_A_ObjectFlow11);
						AddToElementRepository("LiteralInteger12", DefaultValue_Structures_instantiate_A_ObjectFlow11_LiteralInteger12);
						AddToElementRepository("LiteralBoolean13", DefaultValue_Structures_instantiate_A_ObjectFlow11_LiteralBoolean13);
					AddToElementRepository("a", DefaultValue_Structures_instantiate_A_a);
				AddToElementRepository("assert_A", DefaultValue_Structures_assert_A);
					AddToElementRepository("a", DefaultValue_Structures_assert_A_a);
					AddToElementRepository("Read a.b", DefaultValue_Structures_assert_A_Read_a_b);
						AddToElementRepository("object", DefaultValue_Structures_assert_A_Read_a_b_object);
							AddToElementRepository("LiteralUnlimitedNatural14", DefaultValue_Structures_assert_A_Read_a_b_object_LiteralUnlimitedNatural14);
							AddToElementRepository("LiteralInteger15", DefaultValue_Structures_assert_A_Read_a_b_object_LiteralInteger15);
						AddToElementRepository("result", DefaultValue_Structures_assert_A_Read_a_b_result);
							AddToElementRepository("LiteralUnlimitedNatural16", DefaultValue_Structures_assert_A_Read_a_b_result_LiteralUnlimitedNatural16);
							AddToElementRepository("LiteralInteger17", DefaultValue_Structures_assert_A_Read_a_b_result_LiteralInteger17);
					AddToElementRepository("testDefaultValues", DefaultValue_Structures_assert_A_testDefaultValues);
						AddToElementRepository("pList", DefaultValue_Structures_assert_A_testDefaultValues_pList);
							AddToElementRepository("LiteralInteger18", DefaultValue_Structures_assert_A_testDefaultValues_pList_LiteralInteger18);
							AddToElementRepository("LiteralUnlimitedNatural19", DefaultValue_Structures_assert_A_testDefaultValues_pList_LiteralUnlimitedNatural19);
					AddToElementRepository("ObjectFlow20", DefaultValue_Structures_assert_A_ObjectFlow20);
						AddToElementRepository("LiteralInteger21", DefaultValue_Structures_assert_A_ObjectFlow20_LiteralInteger21);
						AddToElementRepository("LiteralBoolean22", DefaultValue_Structures_assert_A_ObjectFlow20_LiteralBoolean22);
					AddToElementRepository("ObjectFlow23", DefaultValue_Structures_assert_A_ObjectFlow23);
						AddToElementRepository("LiteralBoolean24", DefaultValue_Structures_assert_A_ObjectFlow23_LiteralBoolean24);
						AddToElementRepository("LiteralInteger25", DefaultValue_Structures_assert_A_ObjectFlow23_LiteralInteger25);
					AddToElementRepository("Test Default Values", DefaultValue_Structures_assert_A_Test_Default_Values);
						AddToElementRepository("pList", DefaultValue_Structures_assert_A_Test_Default_Values_pList);
							AddToElementRepository("LiteralInteger26", DefaultValue_Structures_assert_A_Test_Default_Values_pList_LiteralInteger26);
							AddToElementRepository("LiteralInteger27", DefaultValue_Structures_assert_A_Test_Default_Values_pList_LiteralInteger27);
							AddToElementRepository("LiteralUnlimitedNatural28", DefaultValue_Structures_assert_A_Test_Default_Values_pList_LiteralUnlimitedNatural28);
					AddToElementRepository("ObjectFlow29", DefaultValue_Structures_assert_A_ObjectFlow29);
						AddToElementRepository("LiteralBoolean30", DefaultValue_Structures_assert_A_ObjectFlow29_LiteralBoolean30);
						AddToElementRepository("LiteralInteger31", DefaultValue_Structures_assert_A_ObjectFlow29_LiteralInteger31);
					AddToElementRepository("Read b.p", DefaultValue_Structures_assert_A_Read_b_p);
						AddToElementRepository("result", DefaultValue_Structures_assert_A_Read_b_p_result);
							AddToElementRepository("LiteralUnlimitedNatural32", DefaultValue_Structures_assert_A_Read_b_p_result_LiteralUnlimitedNatural32);
							AddToElementRepository("LiteralInteger33", DefaultValue_Structures_assert_A_Read_b_p_result_LiteralInteger33);
						AddToElementRepository("object", DefaultValue_Structures_assert_A_Read_b_p_object);
							AddToElementRepository("LiteralUnlimitedNatural34", DefaultValue_Structures_assert_A_Read_b_p_object_LiteralUnlimitedNatural34);
							AddToElementRepository("LiteralInteger35", DefaultValue_Structures_assert_A_Read_b_p_object_LiteralInteger35);
					AddToElementRepository("a_node", DefaultValue_Structures_assert_A_a_node);
						AddToElementRepository("LiteralInteger36", DefaultValue_Structures_assert_A_a_node_LiteralInteger36);
				AddToElementRepository("A", DefaultValue_Structures_A);
					AddToElementRepository("b", DefaultValue_Structures_A_b);
						AddToElementRepository("LiteralInteger37", DefaultValue_Structures_A_b_LiteralInteger37);
						AddToElementRepository("LiteralUnlimitedNatural38", DefaultValue_Structures_A_b_LiteralUnlimitedNatural38);
						AddToElementRepository("OpaqueExpression39", DefaultValue_Structures_A_b_OpaqueExpression39);
					AddToElementRepository("bDefaultValues", DefaultValue_Structures_A_bDefaultValues);
						AddToElementRepository("bList", DefaultValue_Structures_A_bDefaultValues_bList);
							AddToElementRepository("LiteralInteger40", DefaultValue_Structures_A_bDefaultValues_bList_LiteralInteger40);
							AddToElementRepository("LiteralUnlimitedNatural41", DefaultValue_Structures_A_bDefaultValues_bList_LiteralUnlimitedNatural41);
						AddToElementRepository("ObjectFlow42", DefaultValue_Structures_A_bDefaultValues_ObjectFlow42);
							AddToElementRepository("LiteralBoolean43", DefaultValue_Structures_A_bDefaultValues_ObjectFlow42_LiteralBoolean43);
							AddToElementRepository("LiteralInteger44", DefaultValue_Structures_A_bDefaultValues_ObjectFlow42_LiteralInteger44);
						AddToElementRepository("Integer(4)", DefaultValue_Structures_A_bDefaultValues_Integer_4);
							AddToElementRepository("LiteralInteger45", DefaultValue_Structures_A_bDefaultValues_Integer_4_LiteralInteger45);
							AddToElementRepository("result", DefaultValue_Structures_A_bDefaultValues_Integer_4_result);
								AddToElementRepository("LiteralUnlimitedNatural46", DefaultValue_Structures_A_bDefaultValues_Integer_4_result_LiteralUnlimitedNatural46);
								AddToElementRepository("LiteralInteger47", DefaultValue_Structures_A_bDefaultValues_Integer_4_result_LiteralInteger47);
						AddToElementRepository("B_2.p", DefaultValue_Structures_A_bDefaultValues_B_2_p);
							AddToElementRepository("object", DefaultValue_Structures_A_bDefaultValues_B_2_p_object);
								AddToElementRepository("LiteralUnlimitedNatural48", DefaultValue_Structures_A_bDefaultValues_B_2_p_object_LiteralUnlimitedNatural48);
								AddToElementRepository("LiteralInteger49", DefaultValue_Structures_A_bDefaultValues_B_2_p_object_LiteralInteger49);
							AddToElementRepository("result", DefaultValue_Structures_A_bDefaultValues_B_2_p_result);
								AddToElementRepository("LiteralUnlimitedNatural50", DefaultValue_Structures_A_bDefaultValues_B_2_p_result_LiteralUnlimitedNatural50);
								AddToElementRepository("LiteralInteger51", DefaultValue_Structures_A_bDefaultValues_B_2_p_result_LiteralInteger51);
							AddToElementRepository("value", DefaultValue_Structures_A_bDefaultValues_B_2_p_value);
								AddToElementRepository("LiteralUnlimitedNatural52", DefaultValue_Structures_A_bDefaultValues_B_2_p_value_LiteralUnlimitedNatural52);
								AddToElementRepository("LiteralInteger53", DefaultValue_Structures_A_bDefaultValues_B_2_p_value_LiteralInteger53);
						AddToElementRepository("Create B_1", DefaultValue_Structures_A_bDefaultValues_Create_B_1);
							AddToElementRepository("result", DefaultValue_Structures_A_bDefaultValues_Create_B_1_result);
								AddToElementRepository("LiteralInteger54", DefaultValue_Structures_A_bDefaultValues_Create_B_1_result_LiteralInteger54);
								AddToElementRepository("LiteralUnlimitedNatural55", DefaultValue_Structures_A_bDefaultValues_Create_B_1_result_LiteralUnlimitedNatural55);
						AddToElementRepository("ControlFlow56", DefaultValue_Structures_A_bDefaultValues_ControlFlow56);
						AddToElementRepository("ObjectFlow57", DefaultValue_Structures_A_bDefaultValues_ObjectFlow57);
							AddToElementRepository("LiteralBoolean58", DefaultValue_Structures_A_bDefaultValues_ObjectFlow57_LiteralBoolean58);
							AddToElementRepository("LiteralInteger59", DefaultValue_Structures_A_bDefaultValues_ObjectFlow57_LiteralInteger59);
						AddToElementRepository("bList_node", DefaultValue_Structures_A_bDefaultValues_bList_node);
						AddToElementRepository("ObjectFlow60", DefaultValue_Structures_A_bDefaultValues_ObjectFlow60);
							AddToElementRepository("LiteralBoolean61", DefaultValue_Structures_A_bDefaultValues_ObjectFlow60_LiteralBoolean61);
							AddToElementRepository("LiteralInteger62", DefaultValue_Structures_A_bDefaultValues_ObjectFlow60_LiteralInteger62);
						AddToElementRepository("Create B_2", DefaultValue_Structures_A_bDefaultValues_Create_B_2);
							AddToElementRepository("result", DefaultValue_Structures_A_bDefaultValues_Create_B_2_result);
								AddToElementRepository("LiteralUnlimitedNatural63", DefaultValue_Structures_A_bDefaultValues_Create_B_2_result_LiteralUnlimitedNatural63);
								AddToElementRepository("LiteralInteger64", DefaultValue_Structures_A_bDefaultValues_Create_B_2_result_LiteralInteger64);
						AddToElementRepository("ObjectFlow65", DefaultValue_Structures_A_bDefaultValues_ObjectFlow65);
							AddToElementRepository("LiteralBoolean66", DefaultValue_Structures_A_bDefaultValues_ObjectFlow65_LiteralBoolean66);
							AddToElementRepository("LiteralInteger67", DefaultValue_Structures_A_bDefaultValues_ObjectFlow65_LiteralInteger67);
						AddToElementRepository("ObjectFlow68", DefaultValue_Structures_A_bDefaultValues_ObjectFlow68);
							AddToElementRepository("LiteralInteger69", DefaultValue_Structures_A_bDefaultValues_ObjectFlow68_LiteralInteger69);
							AddToElementRepository("LiteralBoolean70", DefaultValue_Structures_A_bDefaultValues_ObjectFlow68_LiteralBoolean70);
						AddToElementRepository("ObjectFlow71", DefaultValue_Structures_A_bDefaultValues_ObjectFlow71);
							AddToElementRepository("LiteralInteger72", DefaultValue_Structures_A_bDefaultValues_ObjectFlow71_LiteralInteger72);
							AddToElementRepository("LiteralBoolean73", DefaultValue_Structures_A_bDefaultValues_ObjectFlow71_LiteralBoolean73);
						AddToElementRepository("ObjectFlow74", DefaultValue_Structures_A_bDefaultValues_ObjectFlow74);
							AddToElementRepository("LiteralBoolean75", DefaultValue_Structures_A_bDefaultValues_ObjectFlow74_LiteralBoolean75);
							AddToElementRepository("LiteralInteger76", DefaultValue_Structures_A_bDefaultValues_ObjectFlow74_LiteralInteger76);
						AddToElementRepository("ControlFlow77", DefaultValue_Structures_A_bDefaultValues_ControlFlow77);
						AddToElementRepository("B_4.p", DefaultValue_Structures_A_bDefaultValues_B_4_p);
							AddToElementRepository("value", DefaultValue_Structures_A_bDefaultValues_B_4_p_value);
								AddToElementRepository("LiteralUnlimitedNatural78", DefaultValue_Structures_A_bDefaultValues_B_4_p_value_LiteralUnlimitedNatural78);
								AddToElementRepository("LiteralInteger79", DefaultValue_Structures_A_bDefaultValues_B_4_p_value_LiteralInteger79);
							AddToElementRepository("object", DefaultValue_Structures_A_bDefaultValues_B_4_p_object);
								AddToElementRepository("LiteralInteger80", DefaultValue_Structures_A_bDefaultValues_B_4_p_object_LiteralInteger80);
								AddToElementRepository("LiteralUnlimitedNatural81", DefaultValue_Structures_A_bDefaultValues_B_4_p_object_LiteralUnlimitedNatural81);
							AddToElementRepository("result", DefaultValue_Structures_A_bDefaultValues_B_4_p_result);
								AddToElementRepository("LiteralUnlimitedNatural82", DefaultValue_Structures_A_bDefaultValues_B_4_p_result_LiteralUnlimitedNatural82);
								AddToElementRepository("LiteralInteger83", DefaultValue_Structures_A_bDefaultValues_B_4_p_result_LiteralInteger83);
						AddToElementRepository("Integer(2)", DefaultValue_Structures_A_bDefaultValues_Integer_2);
							AddToElementRepository("LiteralInteger84", DefaultValue_Structures_A_bDefaultValues_Integer_2_LiteralInteger84);
							AddToElementRepository("result", DefaultValue_Structures_A_bDefaultValues_Integer_2_result);
								AddToElementRepository("LiteralUnlimitedNatural85", DefaultValue_Structures_A_bDefaultValues_Integer_2_result_LiteralUnlimitedNatural85);
								AddToElementRepository("LiteralInteger86", DefaultValue_Structures_A_bDefaultValues_Integer_2_result_LiteralInteger86);
						AddToElementRepository("ObjectFlow87", DefaultValue_Structures_A_bDefaultValues_ObjectFlow87);
							AddToElementRepository("LiteralInteger88", DefaultValue_Structures_A_bDefaultValues_ObjectFlow87_LiteralInteger88);
							AddToElementRepository("LiteralBoolean89", DefaultValue_Structures_A_bDefaultValues_ObjectFlow87_LiteralBoolean89);
						AddToElementRepository("B_1.p", DefaultValue_Structures_A_bDefaultValues_B_1_p);
							AddToElementRepository("object", DefaultValue_Structures_A_bDefaultValues_B_1_p_object);
								AddToElementRepository("LiteralUnlimitedNatural90", DefaultValue_Structures_A_bDefaultValues_B_1_p_object_LiteralUnlimitedNatural90);
								AddToElementRepository("LiteralInteger91", DefaultValue_Structures_A_bDefaultValues_B_1_p_object_LiteralInteger91);
							AddToElementRepository("result", DefaultValue_Structures_A_bDefaultValues_B_1_p_result);
								AddToElementRepository("LiteralInteger92", DefaultValue_Structures_A_bDefaultValues_B_1_p_result_LiteralInteger92);
								AddToElementRepository("LiteralUnlimitedNatural93", DefaultValue_Structures_A_bDefaultValues_B_1_p_result_LiteralUnlimitedNatural93);
							AddToElementRepository("value", DefaultValue_Structures_A_bDefaultValues_B_1_p_value);
								AddToElementRepository("LiteralUnlimitedNatural94", DefaultValue_Structures_A_bDefaultValues_B_1_p_value_LiteralUnlimitedNatural94);
								AddToElementRepository("LiteralInteger95", DefaultValue_Structures_A_bDefaultValues_B_1_p_value_LiteralInteger95);
						AddToElementRepository("ObjectFlow96", DefaultValue_Structures_A_bDefaultValues_ObjectFlow96);
							AddToElementRepository("LiteralBoolean97", DefaultValue_Structures_A_bDefaultValues_ObjectFlow96_LiteralBoolean97);
							AddToElementRepository("LiteralInteger98", DefaultValue_Structures_A_bDefaultValues_ObjectFlow96_LiteralInteger98);
						AddToElementRepository("ObjectFlow99", DefaultValue_Structures_A_bDefaultValues_ObjectFlow99);
							AddToElementRepository("LiteralBoolean100", DefaultValue_Structures_A_bDefaultValues_ObjectFlow99_LiteralBoolean100);
							AddToElementRepository("LiteralInteger101", DefaultValue_Structures_A_bDefaultValues_ObjectFlow99_LiteralInteger101);
						AddToElementRepository("ObjectFlow102", DefaultValue_Structures_A_bDefaultValues_ObjectFlow102);
							AddToElementRepository("LiteralInteger103", DefaultValue_Structures_A_bDefaultValues_ObjectFlow102_LiteralInteger103);
							AddToElementRepository("LiteralBoolean104", DefaultValue_Structures_A_bDefaultValues_ObjectFlow102_LiteralBoolean104);
						AddToElementRepository("ControlFlow105", DefaultValue_Structures_A_bDefaultValues_ControlFlow105);
						AddToElementRepository("B_3.p", DefaultValue_Structures_A_bDefaultValues_B_3_p);
							AddToElementRepository("result", DefaultValue_Structures_A_bDefaultValues_B_3_p_result);
								AddToElementRepository("LiteralUnlimitedNatural106", DefaultValue_Structures_A_bDefaultValues_B_3_p_result_LiteralUnlimitedNatural106);
								AddToElementRepository("LiteralInteger107", DefaultValue_Structures_A_bDefaultValues_B_3_p_result_LiteralInteger107);
							AddToElementRepository("value", DefaultValue_Structures_A_bDefaultValues_B_3_p_value);
								AddToElementRepository("LiteralInteger108", DefaultValue_Structures_A_bDefaultValues_B_3_p_value_LiteralInteger108);
								AddToElementRepository("LiteralUnlimitedNatural109", DefaultValue_Structures_A_bDefaultValues_B_3_p_value_LiteralUnlimitedNatural109);
							AddToElementRepository("object", DefaultValue_Structures_A_bDefaultValues_B_3_p_object);
								AddToElementRepository("LiteralInteger110", DefaultValue_Structures_A_bDefaultValues_B_3_p_object_LiteralInteger110);
								AddToElementRepository("LiteralUnlimitedNatural111", DefaultValue_Structures_A_bDefaultValues_B_3_p_object_LiteralUnlimitedNatural111);
						AddToElementRepository("Create B_3", DefaultValue_Structures_A_bDefaultValues_Create_B_3);
							AddToElementRepository("result", DefaultValue_Structures_A_bDefaultValues_Create_B_3_result);
								AddToElementRepository("LiteralInteger112", DefaultValue_Structures_A_bDefaultValues_Create_B_3_result_LiteralInteger112);
								AddToElementRepository("LiteralUnlimitedNatural113", DefaultValue_Structures_A_bDefaultValues_Create_B_3_result_LiteralUnlimitedNatural113);
						AddToElementRepository("ObjectFlow114", DefaultValue_Structures_A_bDefaultValues_ObjectFlow114);
							AddToElementRepository("LiteralBoolean115", DefaultValue_Structures_A_bDefaultValues_ObjectFlow114_LiteralBoolean115);
							AddToElementRepository("LiteralInteger116", DefaultValue_Structures_A_bDefaultValues_ObjectFlow114_LiteralInteger116);
						AddToElementRepository("Create B_4", DefaultValue_Structures_A_bDefaultValues_Create_B_4);
							AddToElementRepository("result", DefaultValue_Structures_A_bDefaultValues_Create_B_4_result);
								AddToElementRepository("LiteralUnlimitedNatural117", DefaultValue_Structures_A_bDefaultValues_Create_B_4_result_LiteralUnlimitedNatural117);
								AddToElementRepository("LiteralInteger118", DefaultValue_Structures_A_bDefaultValues_Create_B_4_result_LiteralInteger118);
						AddToElementRepository("Integer(3)", DefaultValue_Structures_A_bDefaultValues_Integer_3);
							AddToElementRepository("result", DefaultValue_Structures_A_bDefaultValues_Integer_3_result);
								AddToElementRepository("LiteralUnlimitedNatural119", DefaultValue_Structures_A_bDefaultValues_Integer_3_result_LiteralUnlimitedNatural119);
								AddToElementRepository("LiteralInteger120", DefaultValue_Structures_A_bDefaultValues_Integer_3_result_LiteralInteger120);
							AddToElementRepository("LiteralInteger121", DefaultValue_Structures_A_bDefaultValues_Integer_3_LiteralInteger121);
						AddToElementRepository("Integer(1)", DefaultValue_Structures_A_bDefaultValues_Integer_1);
							AddToElementRepository("result", DefaultValue_Structures_A_bDefaultValues_Integer_1_result);
								AddToElementRepository("LiteralUnlimitedNatural122", DefaultValue_Structures_A_bDefaultValues_Integer_1_result_LiteralUnlimitedNatural122);
								AddToElementRepository("LiteralInteger123", DefaultValue_Structures_A_bDefaultValues_Integer_1_result_LiteralInteger123);
							AddToElementRepository("LiteralInteger124", DefaultValue_Structures_A_bDefaultValues_Integer_1_LiteralInteger124);
					AddToElementRepository("A_A", DefaultValue_Structures_A_A_A);
						AddToElementRepository("result", DefaultValue_Structures_A_A_A_result);
				AddToElementRepository("B", DefaultValue_Structures_B);
					AddToElementRepository("p", DefaultValue_Structures_B_p);
					AddToElementRepository("B_B", DefaultValue_Structures_B_B_B);
						AddToElementRepository("result", DefaultValue_Structures_B_B_B_result);
				AddToElementRepository("main", DefaultValue_Structures_main);
					AddToElementRepository("instantiate_A", DefaultValue_Structures_main_instantiate_A);
						AddToElementRepository("a", DefaultValue_Structures_main_instantiate_A_a);
							AddToElementRepository("LiteralUnlimitedNatural125", DefaultValue_Structures_main_instantiate_A_a_LiteralUnlimitedNatural125);
							AddToElementRepository("LiteralInteger126", DefaultValue_Structures_main_instantiate_A_a_LiteralInteger126);
							AddToElementRepository("LiteralInteger127", DefaultValue_Structures_main_instantiate_A_a_LiteralInteger127);
					AddToElementRepository("assert_A", DefaultValue_Structures_main_assert_A);
						AddToElementRepository("a", DefaultValue_Structures_main_assert_A_a);
							AddToElementRepository("LiteralUnlimitedNatural128", DefaultValue_Structures_main_assert_A_a_LiteralUnlimitedNatural128);
							AddToElementRepository("LiteralInteger129", DefaultValue_Structures_main_assert_A_a_LiteralInteger129);
							AddToElementRepository("LiteralInteger130", DefaultValue_Structures_main_assert_A_a_LiteralInteger130);
					AddToElementRepository("ObjectFlow131", DefaultValue_Structures_main_ObjectFlow131);
						AddToElementRepository("LiteralInteger132", DefaultValue_Structures_main_ObjectFlow131_LiteralInteger132);
						AddToElementRepository("LiteralBoolean133", DefaultValue_Structures_main_ObjectFlow131_LiteralBoolean133);

			// Initialize public members
			/*
			 * Model DefaultValue_Structures
			 */
			DefaultValue_Structures.SetName("DefaultValue_Structures");
			DefaultValue_Structures.SetVisibility(VisibilityKind.public_);
				// Activity instantiate_A
				DefaultValue_Structures_instantiate_A.SetName("instantiate_A");
				DefaultValue_Structures_instantiate_A.SetVisibility(VisibilityKind.public_);
				
					// Parameter a
					DefaultValue_Structures_instantiate_A_a.SetName("a");
					DefaultValue_Structures_instantiate_A_a.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_Structures_instantiate_A_a.SetType(DefaultValue_Structures_A);
					DefaultValue_Structures_instantiate_A_a.SetDirection(ParameterDirectionKind.return_);
				DefaultValue_Structures_instantiate_A.AddOwnedParameter(DefaultValue_Structures_instantiate_A_a);
					// CreateObjectAction Create_A
					DefaultValue_Structures_instantiate_A_Create_A.SetName("Create_A");
					DefaultValue_Structures_instantiate_A_Create_A.SetVisibility(VisibilityKind.public_);
					DefaultValue_Structures_instantiate_A_Create_A.SetClassifier(DefaultValue_Structures_A);
						// OutputPin result
						DefaultValue_Structures_instantiate_A_Create_A_result.SetName("result");
						DefaultValue_Structures_instantiate_A_Create_A_result.SetVisibility(VisibilityKind.public_);
						DefaultValue_Structures_instantiate_A_Create_A_result.SetType(DefaultValue_Structures_A);
					DefaultValue_Structures_instantiate_A_Create_A.SetResult(DefaultValue_Structures_instantiate_A_Create_A_result);
				DefaultValue_Structures_instantiate_A.AddNode(DefaultValue_Structures_instantiate_A_Create_A);
					// ActivityParameterNode a_node
					DefaultValue_Structures_instantiate_A_a_node.SetName("a_node");
					DefaultValue_Structures_instantiate_A_a_node.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_Structures_instantiate_A_a_node.SetParameter(DefaultValue_Structures_instantiate_A_a);
				DefaultValue_Structures_instantiate_A.AddNode(DefaultValue_Structures_instantiate_A_a_node);
					// CallOperationAction A()
					DefaultValue_Structures_instantiate_A_A_.SetName("A()");
					DefaultValue_Structures_instantiate_A_A_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						DefaultValue_Structures_instantiate_A_A__result.SetName("result");
						DefaultValue_Structures_instantiate_A_A__result.SetVisibility(VisibilityKind.public_);
						DefaultValue_Structures_instantiate_A_A__result.SetType(DefaultValue_Structures_A);
					DefaultValue_Structures_instantiate_A_A_.AddResult(DefaultValue_Structures_instantiate_A_A__result);
					DefaultValue_Structures_instantiate_A_A_.SetOperation(DefaultValue_Structures_A_A_A);
						// InputPin target
						DefaultValue_Structures_instantiate_A_A__target.SetName("target");
						DefaultValue_Structures_instantiate_A_A__target.SetVisibility(VisibilityKind.public_);
						DefaultValue_Structures_instantiate_A_A__target.SetType(DefaultValue_Structures_A);
					DefaultValue_Structures_instantiate_A_A_.SetTarget(DefaultValue_Structures_instantiate_A_A__target);
				DefaultValue_Structures_instantiate_A.AddNode(DefaultValue_Structures_instantiate_A_A_);
					// ObjectFlow ObjectFlow3 from result to target
					DefaultValue_Structures_instantiate_A_ObjectFlow3.SetName("ObjectFlow3");
					DefaultValue_Structures_instantiate_A_ObjectFlow3.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_Structures_instantiate_A_ObjectFlow3.SetSource(DefaultValue_Structures_instantiate_A_Create_A_result);
					DefaultValue_Structures_instantiate_A_ObjectFlow3.SetTarget(DefaultValue_Structures_instantiate_A_A__target);
						// LiteralBoolean LiteralBoolean4
						DefaultValue_Structures_instantiate_A_ObjectFlow3_LiteralBoolean4.SetName("LiteralBoolean4");
						DefaultValue_Structures_instantiate_A_ObjectFlow3_LiteralBoolean4.SetVisibility(VisibilityKind.public_);
						DefaultValue_Structures_instantiate_A_ObjectFlow3_LiteralBoolean4.SetValue(true);
					DefaultValue_Structures_instantiate_A_ObjectFlow3.SetGuard(DefaultValue_Structures_instantiate_A_ObjectFlow3_LiteralBoolean4);
				DefaultValue_Structures_instantiate_A.AddEdge(DefaultValue_Structures_instantiate_A_ObjectFlow3);
					// ObjectFlow ObjectFlow11 from result to a_node
					DefaultValue_Structures_instantiate_A_ObjectFlow11.SetName("ObjectFlow11");
					DefaultValue_Structures_instantiate_A_ObjectFlow11.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_Structures_instantiate_A_ObjectFlow11.SetSource(DefaultValue_Structures_instantiate_A_A__result);
					DefaultValue_Structures_instantiate_A_ObjectFlow11.SetTarget(DefaultValue_Structures_instantiate_A_a_node);
						// LiteralBoolean LiteralBoolean13
						DefaultValue_Structures_instantiate_A_ObjectFlow11_LiteralBoolean13.SetName("LiteralBoolean13");
						DefaultValue_Structures_instantiate_A_ObjectFlow11_LiteralBoolean13.SetVisibility(VisibilityKind.public_);
						DefaultValue_Structures_instantiate_A_ObjectFlow11_LiteralBoolean13.SetValue(true);
					DefaultValue_Structures_instantiate_A_ObjectFlow11.SetGuard(DefaultValue_Structures_instantiate_A_ObjectFlow11_LiteralBoolean13);
				DefaultValue_Structures_instantiate_A.AddEdge(DefaultValue_Structures_instantiate_A_ObjectFlow11);
			DefaultValue_Structures.AddPackagedElement(DefaultValue_Structures_instantiate_A);
				// Activity assert_A
				DefaultValue_Structures_assert_A.SetName("assert_A");
				DefaultValue_Structures_assert_A.SetVisibility(VisibilityKind.public_);
				// FunctionBehavior testDefaultValues
					DefaultValue_Structures_assert_A_testDefaultValues.SetName("testDefaultValues");
					DefaultValue_Structures_assert_A_testDefaultValues.SetVisibility(VisibilityKind.public_);
					
						// Parameter pList
						DefaultValue_Structures_assert_A_testDefaultValues_pList.SetName("pList");
						DefaultValue_Structures_assert_A_testDefaultValues_pList.SetVisibility(VisibilityKind.public_);
						DefaultValue_Structures_assert_A_testDefaultValues_pList.SetUpper(-1);
						DefaultValue_Structures_assert_A_testDefaultValues_pList.SetLower(4);
						DefaultValue_Structures_assert_A_testDefaultValues_pList.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					DefaultValue_Structures_assert_A_testDefaultValues.AddOwnedParameter(DefaultValue_Structures_assert_A_testDefaultValues_pList);
					DefaultValue_Structures_assert_A_testDefaultValues.AddLanguage("C#");
					DefaultValue_Structures_assert_A_testDefaultValues.AddLanguage("Using");
					DefaultValue_Structures_assert_A_testDefaultValues.AddBody("List<Value> values = inputParameters.ElementAt(0).values; 	int index = 1;  	for(Value value in values) 	{ 		Console.WriteLine(\"Asserting a.b[\" + index + \"].p == \" + index);	 	 		// Test parameter p[i] 		int p =((IntegerValue)value).value; 		Debug.Println(\"[doBody] argument p[\" + index + \"] = \" + p);  		Console.WriteLine(\"a.b[\" + index + \"].p == \" + p); 		Console.Write(\"Default value correctly evaluated: \");  		if(p == index) 		{ 			Console.ForegroundColor = ConsoleColor.Green; 			Console.WriteLine(\"Assertion successful.\"); 		} 		else 		{ 			Console.ForegroundColor = ConsoleColor.Red; 			Console.WriteLine(\"Assertion failed!\"); 		} 		Console.ResetColor();  		index++; 	}");
					DefaultValue_Structures_assert_A_testDefaultValues.AddBody("using fuml.semantics.simpleclassifiers;");
				DefaultValue_Structures_assert_A.AddOwnedBehavior(DefaultValue_Structures_assert_A_testDefaultValues);
					// Parameter a
					DefaultValue_Structures_assert_A_a.SetName("a");
					DefaultValue_Structures_assert_A_a.SetVisibility(VisibilityKind.public_);
				DefaultValue_Structures_assert_A.AddOwnedParameter(DefaultValue_Structures_assert_A_a);
					// ReadStructuralFeatureAction Read a.b
					DefaultValue_Structures_assert_A_Read_a_b.SetName("Read a.b");
					DefaultValue_Structures_assert_A_Read_a_b.SetVisibility(VisibilityKind.public_);
					DefaultValue_Structures_assert_A_Read_a_b.SetStructuralFeature(DefaultValue_Structures_A_b);
						// InputPin object
						DefaultValue_Structures_assert_A_Read_a_b_object.SetName("object");
						DefaultValue_Structures_assert_A_Read_a_b_object.SetVisibility(VisibilityKind.public_);
						DefaultValue_Structures_assert_A_Read_a_b_object.SetType(DefaultValue_Structures_A);
					DefaultValue_Structures_assert_A_Read_a_b.SetObject(DefaultValue_Structures_assert_A_Read_a_b_object);
						// OutputPin result
						DefaultValue_Structures_assert_A_Read_a_b_result.SetName("result");
						DefaultValue_Structures_assert_A_Read_a_b_result.SetVisibility(VisibilityKind.public_);
						DefaultValue_Structures_assert_A_Read_a_b_result.SetType(DefaultValue_Structures_B);
						DefaultValue_Structures_assert_A_Read_a_b_result.SetUpper(-1);
						DefaultValue_Structures_assert_A_Read_a_b_result.SetLower(4);
					DefaultValue_Structures_assert_A_Read_a_b.SetResult(DefaultValue_Structures_assert_A_Read_a_b_result);
				DefaultValue_Structures_assert_A.AddNode(DefaultValue_Structures_assert_A_Read_a_b);
					// CallBehaviorAction Test Default Values
					DefaultValue_Structures_assert_A_Test_Default_Values.SetName("Test Default Values");
					DefaultValue_Structures_assert_A_Test_Default_Values.SetVisibility(VisibilityKind.public_);
					DefaultValue_Structures_assert_A_Test_Default_Values.SetBehavior(DefaultValue_Structures_assert_A_testDefaultValues);
						// InputPin pList
						DefaultValue_Structures_assert_A_Test_Default_Values_pList.SetName("pList");
						DefaultValue_Structures_assert_A_Test_Default_Values_pList.SetVisibility(VisibilityKind.public_);
						DefaultValue_Structures_assert_A_Test_Default_Values_pList.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						DefaultValue_Structures_assert_A_Test_Default_Values_pList.SetUpper(-1);
						DefaultValue_Structures_assert_A_Test_Default_Values_pList.SetLower(4);
					DefaultValue_Structures_assert_A_Test_Default_Values.AddArgument(DefaultValue_Structures_assert_A_Test_Default_Values_pList);
				DefaultValue_Structures_assert_A.AddNode(DefaultValue_Structures_assert_A_Test_Default_Values);
					// ReadStructuralFeatureAction Read b.p
					DefaultValue_Structures_assert_A_Read_b_p.SetName("Read b.p");
					DefaultValue_Structures_assert_A_Read_b_p.SetVisibility(VisibilityKind.public_);
					DefaultValue_Structures_assert_A_Read_b_p.SetStructuralFeature(DefaultValue_Structures_B_p);
						// InputPin object
						DefaultValue_Structures_assert_A_Read_b_p_object.SetName("object");
						DefaultValue_Structures_assert_A_Read_b_p_object.SetVisibility(VisibilityKind.public_);
						DefaultValue_Structures_assert_A_Read_b_p_object.SetType(DefaultValue_Structures_B);
					DefaultValue_Structures_assert_A_Read_b_p.SetObject(DefaultValue_Structures_assert_A_Read_b_p_object);
						// OutputPin result
						DefaultValue_Structures_assert_A_Read_b_p_result.SetName("result");
						DefaultValue_Structures_assert_A_Read_b_p_result.SetVisibility(VisibilityKind.public_);
						DefaultValue_Structures_assert_A_Read_b_p_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					DefaultValue_Structures_assert_A_Read_b_p.SetResult(DefaultValue_Structures_assert_A_Read_b_p_result);
				DefaultValue_Structures_assert_A.AddNode(DefaultValue_Structures_assert_A_Read_b_p);
					// ActivityParameterNode a_node
					DefaultValue_Structures_assert_A_a_node.SetName("a_node");
					DefaultValue_Structures_assert_A_a_node.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_Structures_assert_A_a_node.SetParameter(DefaultValue_Structures_assert_A_a);
				DefaultValue_Structures_assert_A.AddNode(DefaultValue_Structures_assert_A_a_node);
					// ObjectFlow ObjectFlow20 from a_node to object
					DefaultValue_Structures_assert_A_ObjectFlow20.SetName("ObjectFlow20");
					DefaultValue_Structures_assert_A_ObjectFlow20.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_Structures_assert_A_ObjectFlow20.SetSource(DefaultValue_Structures_assert_A_a_node);
					DefaultValue_Structures_assert_A_ObjectFlow20.SetTarget(DefaultValue_Structures_assert_A_Read_a_b_object);
						// LiteralBoolean LiteralBoolean22
						DefaultValue_Structures_assert_A_ObjectFlow20_LiteralBoolean22.SetName("LiteralBoolean22");
						DefaultValue_Structures_assert_A_ObjectFlow20_LiteralBoolean22.SetVisibility(VisibilityKind.public_);
						DefaultValue_Structures_assert_A_ObjectFlow20_LiteralBoolean22.SetValue(true);
					DefaultValue_Structures_assert_A_ObjectFlow20.SetGuard(DefaultValue_Structures_assert_A_ObjectFlow20_LiteralBoolean22);
				DefaultValue_Structures_assert_A.AddEdge(DefaultValue_Structures_assert_A_ObjectFlow20);
					// ObjectFlow ObjectFlow23 from result to pList
					DefaultValue_Structures_assert_A_ObjectFlow23.SetName("ObjectFlow23");
					DefaultValue_Structures_assert_A_ObjectFlow23.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_Structures_assert_A_ObjectFlow23.SetSource(DefaultValue_Structures_assert_A_Read_b_p_result);
					DefaultValue_Structures_assert_A_ObjectFlow23.SetTarget(DefaultValue_Structures_assert_A_Test_Default_Values_pList);
						// LiteralBoolean LiteralBoolean24
						DefaultValue_Structures_assert_A_ObjectFlow23_LiteralBoolean24.SetName("LiteralBoolean24");
						DefaultValue_Structures_assert_A_ObjectFlow23_LiteralBoolean24.SetVisibility(VisibilityKind.public_);
						DefaultValue_Structures_assert_A_ObjectFlow23_LiteralBoolean24.SetValue(true);
					DefaultValue_Structures_assert_A_ObjectFlow23.SetGuard(DefaultValue_Structures_assert_A_ObjectFlow23_LiteralBoolean24);
				DefaultValue_Structures_assert_A.AddEdge(DefaultValue_Structures_assert_A_ObjectFlow23);
					// ObjectFlow ObjectFlow29 from result to object
					DefaultValue_Structures_assert_A_ObjectFlow29.SetName("ObjectFlow29");
					DefaultValue_Structures_assert_A_ObjectFlow29.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_Structures_assert_A_ObjectFlow29.SetSource(DefaultValue_Structures_assert_A_Read_a_b_result);
					DefaultValue_Structures_assert_A_ObjectFlow29.SetTarget(DefaultValue_Structures_assert_A_Read_b_p_object);
						// LiteralBoolean LiteralBoolean30
						DefaultValue_Structures_assert_A_ObjectFlow29_LiteralBoolean30.SetName("LiteralBoolean30");
						DefaultValue_Structures_assert_A_ObjectFlow29_LiteralBoolean30.SetVisibility(VisibilityKind.public_);
						DefaultValue_Structures_assert_A_ObjectFlow29_LiteralBoolean30.SetValue(true);
					DefaultValue_Structures_assert_A_ObjectFlow29.SetGuard(DefaultValue_Structures_assert_A_ObjectFlow29_LiteralBoolean30);
				DefaultValue_Structures_assert_A.AddEdge(DefaultValue_Structures_assert_A_ObjectFlow29);
			DefaultValue_Structures.AddPackagedElement(DefaultValue_Structures_assert_A);
				// Class A
				DefaultValue_Structures_A.SetName("A");
				DefaultValue_Structures_A.SetVisibility(VisibilityKind.public_);
				
					// Property b
					DefaultValue_Structures_A_b.SetName("b");
					DefaultValue_Structures_A_b.SetVisibility(VisibilityKind.public_);
					DefaultValue_Structures_A_b.SetUpper(-1);
					DefaultValue_Structures_A_b.SetLower(4);
					DefaultValue_Structures_A_b.SetType(DefaultValue_Structures_B);
						// OpaqueExpression OpaqueExpression39
						DefaultValue_Structures_A_b_OpaqueExpression39.SetName("OpaqueExpression39");
						DefaultValue_Structures_A_b_OpaqueExpression39.SetVisibility(VisibilityKind.public_);
						DefaultValue_Structures_A_b_OpaqueExpression39.SetType(DefaultValue_Structures_B);
						DefaultValue_Structures_A_b_OpaqueExpression39.SetBehavior(DefaultValue_Structures_A_bDefaultValues);
					DefaultValue_Structures_A_b.SetDefaultValue(DefaultValue_Structures_A_b_OpaqueExpression39);
				DefaultValue_Structures_A.AddOwnedAttribute(DefaultValue_Structures_A_b);
				// Activity bDefaultValues
					DefaultValue_Structures_A_bDefaultValues.SetName("bDefaultValues");
					DefaultValue_Structures_A_bDefaultValues.SetVisibility(VisibilityKind.public_);
					
						// Parameter bList
						DefaultValue_Structures_A_bDefaultValues_bList.SetName("bList");
						DefaultValue_Structures_A_bDefaultValues_bList.SetVisibility(VisibilityKind.public_);
						DefaultValue_Structures_A_bDefaultValues_bList.SetUpper(-1);
						DefaultValue_Structures_A_bDefaultValues_bList.SetLower(0);
						DefaultValue_Structures_A_bDefaultValues_bList.SetType(DefaultValue_Structures_B);
						DefaultValue_Structures_A_bDefaultValues_bList.SetDirection(ParameterDirectionKind.return_);
					DefaultValue_Structures_A_bDefaultValues.AddOwnedParameter(DefaultValue_Structures_A_bDefaultValues_bList);
						// AddStructuralFeatureValueAction B_4.p
						DefaultValue_Structures_A_bDefaultValues_B_4_p.SetName("B_4.p");
						DefaultValue_Structures_A_bDefaultValues_B_4_p.SetVisibility(VisibilityKind.public_);
						DefaultValue_Structures_A_bDefaultValues_B_4_p.SetStructuralFeature(DefaultValue_Structures_B_p);
							// InputPin object
							DefaultValue_Structures_A_bDefaultValues_B_4_p_object.SetName("object");
							DefaultValue_Structures_A_bDefaultValues_B_4_p_object.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_B_4_p_object.SetType(DefaultValue_Structures_B);
						DefaultValue_Structures_A_bDefaultValues_B_4_p.SetObject(DefaultValue_Structures_A_bDefaultValues_B_4_p_object);
							// InputPin value
							DefaultValue_Structures_A_bDefaultValues_B_4_p_value.SetName("value");
							DefaultValue_Structures_A_bDefaultValues_B_4_p_value.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_B_4_p_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						DefaultValue_Structures_A_bDefaultValues_B_4_p.SetValue(DefaultValue_Structures_A_bDefaultValues_B_4_p_value);
							// OutputPin result
							DefaultValue_Structures_A_bDefaultValues_B_4_p_result.SetName("result");
							DefaultValue_Structures_A_bDefaultValues_B_4_p_result.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_B_4_p_result.SetType(DefaultValue_Structures_B);
						DefaultValue_Structures_A_bDefaultValues_B_4_p.SetResult(DefaultValue_Structures_A_bDefaultValues_B_4_p_result);
					DefaultValue_Structures_A_bDefaultValues.AddNode(DefaultValue_Structures_A_bDefaultValues_B_4_p);
						// ValueSpecificationAction Integer(2)
						DefaultValue_Structures_A_bDefaultValues_Integer_2.SetName("Integer(2)");
						DefaultValue_Structures_A_bDefaultValues_Integer_2.SetVisibility(VisibilityKind.public_);
							// LiteralInteger LiteralInteger84
							DefaultValue_Structures_A_bDefaultValues_Integer_2_LiteralInteger84.SetName("LiteralInteger84");
							DefaultValue_Structures_A_bDefaultValues_Integer_2_LiteralInteger84.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_Integer_2_LiteralInteger84.SetValue(2);
						DefaultValue_Structures_A_bDefaultValues_Integer_2.SetValue(DefaultValue_Structures_A_bDefaultValues_Integer_2_LiteralInteger84);
							// OutputPin result
							DefaultValue_Structures_A_bDefaultValues_Integer_2_result.SetName("result");
							DefaultValue_Structures_A_bDefaultValues_Integer_2_result.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_Integer_2_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						DefaultValue_Structures_A_bDefaultValues_Integer_2.SetResult(DefaultValue_Structures_A_bDefaultValues_Integer_2_result);
					DefaultValue_Structures_A_bDefaultValues.AddNode(DefaultValue_Structures_A_bDefaultValues_Integer_2);
						// ValueSpecificationAction Integer(4)
						DefaultValue_Structures_A_bDefaultValues_Integer_4.SetName("Integer(4)");
						DefaultValue_Structures_A_bDefaultValues_Integer_4.SetVisibility(VisibilityKind.public_);
							// LiteralInteger LiteralInteger45
							DefaultValue_Structures_A_bDefaultValues_Integer_4_LiteralInteger45.SetName("LiteralInteger45");
							DefaultValue_Structures_A_bDefaultValues_Integer_4_LiteralInteger45.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_Integer_4_LiteralInteger45.SetValue(4);
						DefaultValue_Structures_A_bDefaultValues_Integer_4.SetValue(DefaultValue_Structures_A_bDefaultValues_Integer_4_LiteralInteger45);
							// OutputPin result
							DefaultValue_Structures_A_bDefaultValues_Integer_4_result.SetName("result");
							DefaultValue_Structures_A_bDefaultValues_Integer_4_result.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_Integer_4_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						DefaultValue_Structures_A_bDefaultValues_Integer_4.SetResult(DefaultValue_Structures_A_bDefaultValues_Integer_4_result);
					DefaultValue_Structures_A_bDefaultValues.AddNode(DefaultValue_Structures_A_bDefaultValues_Integer_4);
						// AddStructuralFeatureValueAction B_2.p
						DefaultValue_Structures_A_bDefaultValues_B_2_p.SetName("B_2.p");
						DefaultValue_Structures_A_bDefaultValues_B_2_p.SetVisibility(VisibilityKind.public_);
						DefaultValue_Structures_A_bDefaultValues_B_2_p.SetStructuralFeature(DefaultValue_Structures_B_p);
							// InputPin object
							DefaultValue_Structures_A_bDefaultValues_B_2_p_object.SetName("object");
							DefaultValue_Structures_A_bDefaultValues_B_2_p_object.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_B_2_p_object.SetType(DefaultValue_Structures_B);
						DefaultValue_Structures_A_bDefaultValues_B_2_p.SetObject(DefaultValue_Structures_A_bDefaultValues_B_2_p_object);
							// InputPin value
							DefaultValue_Structures_A_bDefaultValues_B_2_p_value.SetName("value");
							DefaultValue_Structures_A_bDefaultValues_B_2_p_value.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_B_2_p_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						DefaultValue_Structures_A_bDefaultValues_B_2_p.SetValue(DefaultValue_Structures_A_bDefaultValues_B_2_p_value);
							// OutputPin result
							DefaultValue_Structures_A_bDefaultValues_B_2_p_result.SetName("result");
							DefaultValue_Structures_A_bDefaultValues_B_2_p_result.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_B_2_p_result.SetType(DefaultValue_Structures_B);
						DefaultValue_Structures_A_bDefaultValues_B_2_p.SetResult(DefaultValue_Structures_A_bDefaultValues_B_2_p_result);
					DefaultValue_Structures_A_bDefaultValues.AddNode(DefaultValue_Structures_A_bDefaultValues_B_2_p);
						// CreateObjectAction Create B_1
						DefaultValue_Structures_A_bDefaultValues_Create_B_1.SetName("Create B_1");
						DefaultValue_Structures_A_bDefaultValues_Create_B_1.SetVisibility(VisibilityKind.public_);
						DefaultValue_Structures_A_bDefaultValues_Create_B_1.SetClassifier(DefaultValue_Structures_B);
							// OutputPin result
							DefaultValue_Structures_A_bDefaultValues_Create_B_1_result.SetName("result");
							DefaultValue_Structures_A_bDefaultValues_Create_B_1_result.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_Create_B_1_result.SetType(DefaultValue_Structures_B);
						DefaultValue_Structures_A_bDefaultValues_Create_B_1.SetResult(DefaultValue_Structures_A_bDefaultValues_Create_B_1_result);
					DefaultValue_Structures_A_bDefaultValues.AddNode(DefaultValue_Structures_A_bDefaultValues_Create_B_1);
						// AddStructuralFeatureValueAction B_1.p
						DefaultValue_Structures_A_bDefaultValues_B_1_p.SetName("B_1.p");
						DefaultValue_Structures_A_bDefaultValues_B_1_p.SetVisibility(VisibilityKind.public_);
						DefaultValue_Structures_A_bDefaultValues_B_1_p.SetStructuralFeature(DefaultValue_Structures_B_p);
							// InputPin object
							DefaultValue_Structures_A_bDefaultValues_B_1_p_object.SetName("object");
							DefaultValue_Structures_A_bDefaultValues_B_1_p_object.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_B_1_p_object.SetType(DefaultValue_Structures_B);
						DefaultValue_Structures_A_bDefaultValues_B_1_p.SetObject(DefaultValue_Structures_A_bDefaultValues_B_1_p_object);
							// InputPin value
							DefaultValue_Structures_A_bDefaultValues_B_1_p_value.SetName("value");
							DefaultValue_Structures_A_bDefaultValues_B_1_p_value.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_B_1_p_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						DefaultValue_Structures_A_bDefaultValues_B_1_p.SetValue(DefaultValue_Structures_A_bDefaultValues_B_1_p_value);
							// OutputPin result
							DefaultValue_Structures_A_bDefaultValues_B_1_p_result.SetName("result");
							DefaultValue_Structures_A_bDefaultValues_B_1_p_result.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_B_1_p_result.SetType(DefaultValue_Structures_B);
						DefaultValue_Structures_A_bDefaultValues_B_1_p.SetResult(DefaultValue_Structures_A_bDefaultValues_B_1_p_result);
					DefaultValue_Structures_A_bDefaultValues.AddNode(DefaultValue_Structures_A_bDefaultValues_B_1_p);
						// ActivityParameterNode bList_node
						DefaultValue_Structures_A_bDefaultValues_bList_node.SetName("bList_node");
						DefaultValue_Structures_A_bDefaultValues_bList_node.SetVisibility(VisibilityKind.public_);
						
						DefaultValue_Structures_A_bDefaultValues_bList_node.SetParameter(DefaultValue_Structures_A_bDefaultValues_bList);
					DefaultValue_Structures_A_bDefaultValues.AddNode(DefaultValue_Structures_A_bDefaultValues_bList_node);
						// CreateObjectAction Create B_2
						DefaultValue_Structures_A_bDefaultValues_Create_B_2.SetName("Create B_2");
						DefaultValue_Structures_A_bDefaultValues_Create_B_2.SetVisibility(VisibilityKind.public_);
						DefaultValue_Structures_A_bDefaultValues_Create_B_2.SetClassifier(DefaultValue_Structures_B);
							// OutputPin result
							DefaultValue_Structures_A_bDefaultValues_Create_B_2_result.SetName("result");
							DefaultValue_Structures_A_bDefaultValues_Create_B_2_result.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_Create_B_2_result.SetType(DefaultValue_Structures_B);
						DefaultValue_Structures_A_bDefaultValues_Create_B_2.SetResult(DefaultValue_Structures_A_bDefaultValues_Create_B_2_result);
					DefaultValue_Structures_A_bDefaultValues.AddNode(DefaultValue_Structures_A_bDefaultValues_Create_B_2);
						// AddStructuralFeatureValueAction B_3.p
						DefaultValue_Structures_A_bDefaultValues_B_3_p.SetName("B_3.p");
						DefaultValue_Structures_A_bDefaultValues_B_3_p.SetVisibility(VisibilityKind.public_);
						DefaultValue_Structures_A_bDefaultValues_B_3_p.SetStructuralFeature(DefaultValue_Structures_B_p);
							// InputPin object
							DefaultValue_Structures_A_bDefaultValues_B_3_p_object.SetName("object");
							DefaultValue_Structures_A_bDefaultValues_B_3_p_object.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_B_3_p_object.SetType(DefaultValue_Structures_B);
						DefaultValue_Structures_A_bDefaultValues_B_3_p.SetObject(DefaultValue_Structures_A_bDefaultValues_B_3_p_object);
							// InputPin value
							DefaultValue_Structures_A_bDefaultValues_B_3_p_value.SetName("value");
							DefaultValue_Structures_A_bDefaultValues_B_3_p_value.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_B_3_p_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						DefaultValue_Structures_A_bDefaultValues_B_3_p.SetValue(DefaultValue_Structures_A_bDefaultValues_B_3_p_value);
							// OutputPin result
							DefaultValue_Structures_A_bDefaultValues_B_3_p_result.SetName("result");
							DefaultValue_Structures_A_bDefaultValues_B_3_p_result.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_B_3_p_result.SetType(DefaultValue_Structures_B);
						DefaultValue_Structures_A_bDefaultValues_B_3_p.SetResult(DefaultValue_Structures_A_bDefaultValues_B_3_p_result);
					DefaultValue_Structures_A_bDefaultValues.AddNode(DefaultValue_Structures_A_bDefaultValues_B_3_p);
						// CreateObjectAction Create B_3
						DefaultValue_Structures_A_bDefaultValues_Create_B_3.SetName("Create B_3");
						DefaultValue_Structures_A_bDefaultValues_Create_B_3.SetVisibility(VisibilityKind.public_);
						DefaultValue_Structures_A_bDefaultValues_Create_B_3.SetClassifier(DefaultValue_Structures_B);
							// OutputPin result
							DefaultValue_Structures_A_bDefaultValues_Create_B_3_result.SetName("result");
							DefaultValue_Structures_A_bDefaultValues_Create_B_3_result.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_Create_B_3_result.SetType(DefaultValue_Structures_B);
						DefaultValue_Structures_A_bDefaultValues_Create_B_3.SetResult(DefaultValue_Structures_A_bDefaultValues_Create_B_3_result);
					DefaultValue_Structures_A_bDefaultValues.AddNode(DefaultValue_Structures_A_bDefaultValues_Create_B_3);
						// CreateObjectAction Create B_4
						DefaultValue_Structures_A_bDefaultValues_Create_B_4.SetName("Create B_4");
						DefaultValue_Structures_A_bDefaultValues_Create_B_4.SetVisibility(VisibilityKind.public_);
						DefaultValue_Structures_A_bDefaultValues_Create_B_4.SetClassifier(DefaultValue_Structures_B);
							// OutputPin result
							DefaultValue_Structures_A_bDefaultValues_Create_B_4_result.SetName("result");
							DefaultValue_Structures_A_bDefaultValues_Create_B_4_result.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_Create_B_4_result.SetType(DefaultValue_Structures_B);
						DefaultValue_Structures_A_bDefaultValues_Create_B_4.SetResult(DefaultValue_Structures_A_bDefaultValues_Create_B_4_result);
					DefaultValue_Structures_A_bDefaultValues.AddNode(DefaultValue_Structures_A_bDefaultValues_Create_B_4);
						// ValueSpecificationAction Integer(3)
						DefaultValue_Structures_A_bDefaultValues_Integer_3.SetName("Integer(3)");
						DefaultValue_Structures_A_bDefaultValues_Integer_3.SetVisibility(VisibilityKind.public_);
							// LiteralInteger LiteralInteger121
							DefaultValue_Structures_A_bDefaultValues_Integer_3_LiteralInteger121.SetName("LiteralInteger121");
							DefaultValue_Structures_A_bDefaultValues_Integer_3_LiteralInteger121.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_Integer_3_LiteralInteger121.SetValue(3);
						DefaultValue_Structures_A_bDefaultValues_Integer_3.SetValue(DefaultValue_Structures_A_bDefaultValues_Integer_3_LiteralInteger121);
							// OutputPin result
							DefaultValue_Structures_A_bDefaultValues_Integer_3_result.SetName("result");
							DefaultValue_Structures_A_bDefaultValues_Integer_3_result.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_Integer_3_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						DefaultValue_Structures_A_bDefaultValues_Integer_3.SetResult(DefaultValue_Structures_A_bDefaultValues_Integer_3_result);
					DefaultValue_Structures_A_bDefaultValues.AddNode(DefaultValue_Structures_A_bDefaultValues_Integer_3);
						// ValueSpecificationAction Integer(1)
						DefaultValue_Structures_A_bDefaultValues_Integer_1.SetName("Integer(1)");
						DefaultValue_Structures_A_bDefaultValues_Integer_1.SetVisibility(VisibilityKind.public_);
							// LiteralInteger LiteralInteger124
							DefaultValue_Structures_A_bDefaultValues_Integer_1_LiteralInteger124.SetName("LiteralInteger124");
							DefaultValue_Structures_A_bDefaultValues_Integer_1_LiteralInteger124.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_Integer_1_LiteralInteger124.SetValue(1);
						DefaultValue_Structures_A_bDefaultValues_Integer_1.SetValue(DefaultValue_Structures_A_bDefaultValues_Integer_1_LiteralInteger124);
							// OutputPin result
							DefaultValue_Structures_A_bDefaultValues_Integer_1_result.SetName("result");
							DefaultValue_Structures_A_bDefaultValues_Integer_1_result.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_Integer_1_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						DefaultValue_Structures_A_bDefaultValues_Integer_1.SetResult(DefaultValue_Structures_A_bDefaultValues_Integer_1_result);
					DefaultValue_Structures_A_bDefaultValues.AddNode(DefaultValue_Structures_A_bDefaultValues_Integer_1);
						// ControlFlow ControlFlow77 from B_2.p to Create B_3
						DefaultValue_Structures_A_bDefaultValues_ControlFlow77.SetName("ControlFlow77");
						DefaultValue_Structures_A_bDefaultValues_ControlFlow77.SetVisibility(VisibilityKind.public_);
						
						DefaultValue_Structures_A_bDefaultValues_ControlFlow77.SetSource(DefaultValue_Structures_A_bDefaultValues_B_2_p);
						DefaultValue_Structures_A_bDefaultValues_ControlFlow77.SetTarget(DefaultValue_Structures_A_bDefaultValues_Create_B_3);
					DefaultValue_Structures_A_bDefaultValues.AddEdge(DefaultValue_Structures_A_bDefaultValues_ControlFlow77);
						// ObjectFlow ObjectFlow42 from result to bList_node
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow42.SetName("ObjectFlow42");
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow42.SetVisibility(VisibilityKind.public_);
						
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow42.SetSource(DefaultValue_Structures_A_bDefaultValues_B_4_p_result);
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow42.SetTarget(DefaultValue_Structures_A_bDefaultValues_bList_node);
							// LiteralBoolean LiteralBoolean43
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow42_LiteralBoolean43.SetName("LiteralBoolean43");
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow42_LiteralBoolean43.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow42_LiteralBoolean43.SetValue(true);
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow42.SetGuard(DefaultValue_Structures_A_bDefaultValues_ObjectFlow42_LiteralBoolean43);
					DefaultValue_Structures_A_bDefaultValues.AddEdge(DefaultValue_Structures_A_bDefaultValues_ObjectFlow42);
						// ObjectFlow ObjectFlow87 from result to bList_node
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow87.SetName("ObjectFlow87");
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow87.SetVisibility(VisibilityKind.public_);
						
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow87.SetSource(DefaultValue_Structures_A_bDefaultValues_B_2_p_result);
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow87.SetTarget(DefaultValue_Structures_A_bDefaultValues_bList_node);
							// LiteralBoolean LiteralBoolean89
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow87_LiteralBoolean89.SetName("LiteralBoolean89");
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow87_LiteralBoolean89.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow87_LiteralBoolean89.SetValue(true);
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow87.SetGuard(DefaultValue_Structures_A_bDefaultValues_ObjectFlow87_LiteralBoolean89);
					DefaultValue_Structures_A_bDefaultValues.AddEdge(DefaultValue_Structures_A_bDefaultValues_ObjectFlow87);
						// ControlFlow ControlFlow56 from B_1.p to Create B_2
						DefaultValue_Structures_A_bDefaultValues_ControlFlow56.SetName("ControlFlow56");
						DefaultValue_Structures_A_bDefaultValues_ControlFlow56.SetVisibility(VisibilityKind.public_);
						
						DefaultValue_Structures_A_bDefaultValues_ControlFlow56.SetSource(DefaultValue_Structures_A_bDefaultValues_B_1_p);
						DefaultValue_Structures_A_bDefaultValues_ControlFlow56.SetTarget(DefaultValue_Structures_A_bDefaultValues_Create_B_2);
					DefaultValue_Structures_A_bDefaultValues.AddEdge(DefaultValue_Structures_A_bDefaultValues_ControlFlow56);
						// ObjectFlow ObjectFlow57 from result to value
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow57.SetName("ObjectFlow57");
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow57.SetVisibility(VisibilityKind.public_);
						
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow57.SetSource(DefaultValue_Structures_A_bDefaultValues_Integer_2_result);
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow57.SetTarget(DefaultValue_Structures_A_bDefaultValues_B_2_p_value);
							// LiteralBoolean LiteralBoolean58
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow57_LiteralBoolean58.SetName("LiteralBoolean58");
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow57_LiteralBoolean58.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow57_LiteralBoolean58.SetValue(true);
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow57.SetGuard(DefaultValue_Structures_A_bDefaultValues_ObjectFlow57_LiteralBoolean58);
					DefaultValue_Structures_A_bDefaultValues.AddEdge(DefaultValue_Structures_A_bDefaultValues_ObjectFlow57);
						// ObjectFlow ObjectFlow96 from result to object
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow96.SetName("ObjectFlow96");
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow96.SetVisibility(VisibilityKind.public_);
						
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow96.SetSource(DefaultValue_Structures_A_bDefaultValues_Create_B_1_result);
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow96.SetTarget(DefaultValue_Structures_A_bDefaultValues_B_1_p_object);
							// LiteralBoolean LiteralBoolean97
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow96_LiteralBoolean97.SetName("LiteralBoolean97");
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow96_LiteralBoolean97.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow96_LiteralBoolean97.SetValue(true);
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow96.SetGuard(DefaultValue_Structures_A_bDefaultValues_ObjectFlow96_LiteralBoolean97);
					DefaultValue_Structures_A_bDefaultValues.AddEdge(DefaultValue_Structures_A_bDefaultValues_ObjectFlow96);
						// ObjectFlow ObjectFlow99 from result to value
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow99.SetName("ObjectFlow99");
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow99.SetVisibility(VisibilityKind.public_);
						
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow99.SetSource(DefaultValue_Structures_A_bDefaultValues_Integer_1_result);
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow99.SetTarget(DefaultValue_Structures_A_bDefaultValues_B_1_p_value);
							// LiteralBoolean LiteralBoolean100
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow99_LiteralBoolean100.SetName("LiteralBoolean100");
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow99_LiteralBoolean100.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow99_LiteralBoolean100.SetValue(true);
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow99.SetGuard(DefaultValue_Structures_A_bDefaultValues_ObjectFlow99_LiteralBoolean100);
					DefaultValue_Structures_A_bDefaultValues.AddEdge(DefaultValue_Structures_A_bDefaultValues_ObjectFlow99);
						// ObjectFlow ObjectFlow60 from result to bList_node
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow60.SetName("ObjectFlow60");
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow60.SetVisibility(VisibilityKind.public_);
						
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow60.SetSource(DefaultValue_Structures_A_bDefaultValues_B_3_p_result);
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow60.SetTarget(DefaultValue_Structures_A_bDefaultValues_bList_node);
							// LiteralBoolean LiteralBoolean61
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow60_LiteralBoolean61.SetName("LiteralBoolean61");
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow60_LiteralBoolean61.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow60_LiteralBoolean61.SetValue(true);
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow60.SetGuard(DefaultValue_Structures_A_bDefaultValues_ObjectFlow60_LiteralBoolean61);
					DefaultValue_Structures_A_bDefaultValues.AddEdge(DefaultValue_Structures_A_bDefaultValues_ObjectFlow60);
						// ObjectFlow ObjectFlow102 from result to object
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow102.SetName("ObjectFlow102");
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow102.SetVisibility(VisibilityKind.public_);
						
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow102.SetSource(DefaultValue_Structures_A_bDefaultValues_Create_B_3_result);
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow102.SetTarget(DefaultValue_Structures_A_bDefaultValues_B_3_p_object);
							// LiteralBoolean LiteralBoolean104
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow102_LiteralBoolean104.SetName("LiteralBoolean104");
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow102_LiteralBoolean104.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow102_LiteralBoolean104.SetValue(true);
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow102.SetGuard(DefaultValue_Structures_A_bDefaultValues_ObjectFlow102_LiteralBoolean104);
					DefaultValue_Structures_A_bDefaultValues.AddEdge(DefaultValue_Structures_A_bDefaultValues_ObjectFlow102);
						// ControlFlow ControlFlow105 from B_3.p to Create B_4
						DefaultValue_Structures_A_bDefaultValues_ControlFlow105.SetName("ControlFlow105");
						DefaultValue_Structures_A_bDefaultValues_ControlFlow105.SetVisibility(VisibilityKind.public_);
						
						DefaultValue_Structures_A_bDefaultValues_ControlFlow105.SetSource(DefaultValue_Structures_A_bDefaultValues_B_3_p);
						DefaultValue_Structures_A_bDefaultValues_ControlFlow105.SetTarget(DefaultValue_Structures_A_bDefaultValues_Create_B_4);
					DefaultValue_Structures_A_bDefaultValues.AddEdge(DefaultValue_Structures_A_bDefaultValues_ControlFlow105);
						// ObjectFlow ObjectFlow65 from result to object
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow65.SetName("ObjectFlow65");
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow65.SetVisibility(VisibilityKind.public_);
						
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow65.SetSource(DefaultValue_Structures_A_bDefaultValues_Create_B_2_result);
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow65.SetTarget(DefaultValue_Structures_A_bDefaultValues_B_2_p_object);
							// LiteralBoolean LiteralBoolean66
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow65_LiteralBoolean66.SetName("LiteralBoolean66");
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow65_LiteralBoolean66.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow65_LiteralBoolean66.SetValue(true);
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow65.SetGuard(DefaultValue_Structures_A_bDefaultValues_ObjectFlow65_LiteralBoolean66);
					DefaultValue_Structures_A_bDefaultValues.AddEdge(DefaultValue_Structures_A_bDefaultValues_ObjectFlow65);
						// ObjectFlow ObjectFlow68 from result to value
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow68.SetName("ObjectFlow68");
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow68.SetVisibility(VisibilityKind.public_);
						
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow68.SetSource(DefaultValue_Structures_A_bDefaultValues_Integer_4_result);
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow68.SetTarget(DefaultValue_Structures_A_bDefaultValues_B_4_p_value);
							// LiteralBoolean LiteralBoolean70
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow68_LiteralBoolean70.SetName("LiteralBoolean70");
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow68_LiteralBoolean70.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow68_LiteralBoolean70.SetValue(true);
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow68.SetGuard(DefaultValue_Structures_A_bDefaultValues_ObjectFlow68_LiteralBoolean70);
					DefaultValue_Structures_A_bDefaultValues.AddEdge(DefaultValue_Structures_A_bDefaultValues_ObjectFlow68);
						// ObjectFlow ObjectFlow71 from result to object
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow71.SetName("ObjectFlow71");
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow71.SetVisibility(VisibilityKind.public_);
						
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow71.SetSource(DefaultValue_Structures_A_bDefaultValues_Create_B_4_result);
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow71.SetTarget(DefaultValue_Structures_A_bDefaultValues_B_4_p_object);
							// LiteralBoolean LiteralBoolean73
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow71_LiteralBoolean73.SetName("LiteralBoolean73");
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow71_LiteralBoolean73.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow71_LiteralBoolean73.SetValue(true);
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow71.SetGuard(DefaultValue_Structures_A_bDefaultValues_ObjectFlow71_LiteralBoolean73);
					DefaultValue_Structures_A_bDefaultValues.AddEdge(DefaultValue_Structures_A_bDefaultValues_ObjectFlow71);
						// ObjectFlow ObjectFlow114 from result to bList_node
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow114.SetName("ObjectFlow114");
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow114.SetVisibility(VisibilityKind.public_);
						
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow114.SetSource(DefaultValue_Structures_A_bDefaultValues_B_1_p_result);
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow114.SetTarget(DefaultValue_Structures_A_bDefaultValues_bList_node);
							// LiteralBoolean LiteralBoolean115
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow114_LiteralBoolean115.SetName("LiteralBoolean115");
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow114_LiteralBoolean115.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow114_LiteralBoolean115.SetValue(true);
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow114.SetGuard(DefaultValue_Structures_A_bDefaultValues_ObjectFlow114_LiteralBoolean115);
					DefaultValue_Structures_A_bDefaultValues.AddEdge(DefaultValue_Structures_A_bDefaultValues_ObjectFlow114);
						// ObjectFlow ObjectFlow74 from result to value
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow74.SetName("ObjectFlow74");
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow74.SetVisibility(VisibilityKind.public_);
						
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow74.SetSource(DefaultValue_Structures_A_bDefaultValues_Integer_3_result);
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow74.SetTarget(DefaultValue_Structures_A_bDefaultValues_B_3_p_value);
							// LiteralBoolean LiteralBoolean75
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow74_LiteralBoolean75.SetName("LiteralBoolean75");
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow74_LiteralBoolean75.SetVisibility(VisibilityKind.public_);
							DefaultValue_Structures_A_bDefaultValues_ObjectFlow74_LiteralBoolean75.SetValue(true);
						DefaultValue_Structures_A_bDefaultValues_ObjectFlow74.SetGuard(DefaultValue_Structures_A_bDefaultValues_ObjectFlow74_LiteralBoolean75);
					DefaultValue_Structures_A_bDefaultValues.AddEdge(DefaultValue_Structures_A_bDefaultValues_ObjectFlow74);
				DefaultValue_Structures_A.AddOwnedBehavior(DefaultValue_Structures_A_bDefaultValues);
				
					// Operation A_A
					DefaultValue_Structures_A_A_A.SetName("A_A");
					DefaultValue_Structures_A_A_A.SetVisibility(VisibilityKind.public_);
						// Parameter result
						DefaultValue_Structures_A_A_A_result.SetName("result");
						DefaultValue_Structures_A_A_A_result.SetVisibility(VisibilityKind.public_);
						
						DefaultValue_Structures_A_A_A_result.SetType(DefaultValue_Structures_A);
						DefaultValue_Structures_A_A_A_result.SetDirection(ParameterDirectionKind.return_);
					DefaultValue_Structures_A_A_A.AddOwnedParameter(DefaultValue_Structures_A_A_A_result);
					DefaultValue_Structures_A_A_A.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				DefaultValue_Structures_A.AddOwnedOperation(DefaultValue_Structures_A_A_A);
			DefaultValue_Structures.AddPackagedElement(DefaultValue_Structures_A);
				// Class B
				DefaultValue_Structures_B.SetName("B");
				DefaultValue_Structures_B.SetVisibility(VisibilityKind.public_);
				
					// Property p
					DefaultValue_Structures_B_p.SetName("p");
					DefaultValue_Structures_B_p.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_Structures_B_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
				DefaultValue_Structures_B.AddOwnedAttribute(DefaultValue_Structures_B_p);
				
				
					// Operation B_B
					DefaultValue_Structures_B_B_B.SetName("B_B");
					DefaultValue_Structures_B_B_B.SetVisibility(VisibilityKind.public_);
						// Parameter result
						DefaultValue_Structures_B_B_B_result.SetName("result");
						DefaultValue_Structures_B_B_B_result.SetVisibility(VisibilityKind.public_);
						
						DefaultValue_Structures_B_B_B_result.SetType(DefaultValue_Structures_B);
						DefaultValue_Structures_B_B_B_result.SetDirection(ParameterDirectionKind.return_);
					DefaultValue_Structures_B_B_B.AddOwnedParameter(DefaultValue_Structures_B_B_B_result);
					DefaultValue_Structures_B_B_B.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				DefaultValue_Structures_B.AddOwnedOperation(DefaultValue_Structures_B_B_B);
			DefaultValue_Structures.AddPackagedElement(DefaultValue_Structures_B);
				// Activity main
				DefaultValue_Structures_main.SetName("main");
				DefaultValue_Structures_main.SetVisibility(VisibilityKind.public_);
					// CallBehaviorAction instantiate_A
					DefaultValue_Structures_main_instantiate_A.SetName("instantiate_A");
					DefaultValue_Structures_main_instantiate_A.SetVisibility(VisibilityKind.public_);
					
						// OutputPin a
						DefaultValue_Structures_main_instantiate_A_a.SetName("a");
						DefaultValue_Structures_main_instantiate_A_a.SetVisibility(VisibilityKind.public_);
						DefaultValue_Structures_main_instantiate_A_a.SetType(DefaultValue_Structures_A);
					DefaultValue_Structures_main_instantiate_A.AddResult(DefaultValue_Structures_main_instantiate_A_a);
					DefaultValue_Structures_main_instantiate_A.SetBehavior(DefaultValue_Structures_instantiate_A);
				DefaultValue_Structures_main.AddNode(DefaultValue_Structures_main_instantiate_A);
					// CallBehaviorAction assert_A
					DefaultValue_Structures_main_assert_A.SetName("assert_A");
					DefaultValue_Structures_main_assert_A.SetVisibility(VisibilityKind.public_);
					DefaultValue_Structures_main_assert_A.SetBehavior(DefaultValue_Structures_assert_A);
						// InputPin a
						DefaultValue_Structures_main_assert_A_a.SetName("a");
						DefaultValue_Structures_main_assert_A_a.SetVisibility(VisibilityKind.public_);
					DefaultValue_Structures_main_assert_A.AddArgument(DefaultValue_Structures_main_assert_A_a);
				DefaultValue_Structures_main.AddNode(DefaultValue_Structures_main_assert_A);
					// ObjectFlow ObjectFlow131 from a to a
					DefaultValue_Structures_main_ObjectFlow131.SetName("ObjectFlow131");
					DefaultValue_Structures_main_ObjectFlow131.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_Structures_main_ObjectFlow131.SetSource(DefaultValue_Structures_main_instantiate_A_a);
					DefaultValue_Structures_main_ObjectFlow131.SetTarget(DefaultValue_Structures_main_assert_A_a);
						// LiteralBoolean LiteralBoolean133
						DefaultValue_Structures_main_ObjectFlow131_LiteralBoolean133.SetName("LiteralBoolean133");
						DefaultValue_Structures_main_ObjectFlow131_LiteralBoolean133.SetVisibility(VisibilityKind.public_);
						DefaultValue_Structures_main_ObjectFlow131_LiteralBoolean133.SetValue(true);
					DefaultValue_Structures_main_ObjectFlow131.SetGuard(DefaultValue_Structures_main_ObjectFlow131_LiteralBoolean133);
				DefaultValue_Structures_main.AddEdge(DefaultValue_Structures_main_ObjectFlow131);
			DefaultValue_Structures.AddPackagedElement(DefaultValue_Structures_main);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // DefaultValue_StructuresModel
}
