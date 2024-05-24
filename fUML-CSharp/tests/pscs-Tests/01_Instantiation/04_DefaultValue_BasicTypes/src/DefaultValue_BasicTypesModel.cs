/*
 * DefaultValue_BasicTypesModel.cs
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

namespace DefaultValue_BasicTypes
{
	public class DefaultValue_BasicTypesModel : InMemoryModel
	{
		private static DefaultValue_BasicTypesModel? instance;

		/*
		 * Model DefaultValue_BasicTypes
		 */
		public Package DefaultValue_BasicTypes = new();
			public Activity DefaultValue_BasicTypes_main = new();
				public CallBehaviorAction DefaultValue_BasicTypes_main_assert_A = new();
					public InputPin DefaultValue_BasicTypes_main_assert_A_a = new();
						public LiteralInteger DefaultValue_BasicTypes_main_assert_A_a_LiteralInteger0 = new();
						public LiteralUnlimitedNatural DefaultValue_BasicTypes_main_assert_A_a_LiteralUnlimitedNatural1 = new();
						public LiteralInteger DefaultValue_BasicTypes_main_assert_A_a_LiteralInteger2 = new();
				public ObjectFlow DefaultValue_BasicTypes_main_ObjectFlow3 = new();
					public LiteralInteger DefaultValue_BasicTypes_main_ObjectFlow3_LiteralInteger4 = new();
					public LiteralBoolean DefaultValue_BasicTypes_main_ObjectFlow3_LiteralBoolean5 = new();
				public CallBehaviorAction DefaultValue_BasicTypes_main_instantiate_A = new();
					public OutputPin DefaultValue_BasicTypes_main_instantiate_A_a = new();
						public LiteralInteger DefaultValue_BasicTypes_main_instantiate_A_a_LiteralInteger6 = new();
						public LiteralInteger DefaultValue_BasicTypes_main_instantiate_A_a_LiteralInteger7 = new();
						public LiteralUnlimitedNatural DefaultValue_BasicTypes_main_instantiate_A_a_LiteralUnlimitedNatural8 = new();
			public Enumeration DefaultValue_BasicTypes_E = new();
				public EnumerationLiteral DefaultValue_BasicTypes_E_e1 = new();
				public EnumerationLiteral DefaultValue_BasicTypes_E_e2 = new();
			public Class_ DefaultValue_BasicTypes_A = new();
				public Property DefaultValue_BasicTypes_A_pInteger = new();
					public LiteralInteger DefaultValue_BasicTypes_A_pInteger_LiteralInteger9 = new();
				public Property DefaultValue_BasicTypes_A_pReal = new();
					public LiteralReal DefaultValue_BasicTypes_A_pReal_LiteralReal10 = new();
				public Property DefaultValue_BasicTypes_A_pEnum = new();
					public InstanceValue DefaultValue_BasicTypes_A_pEnum_InstanceValue11 = new();
				public Property DefaultValue_BasicTypes_A_pString = new();
					public LiteralString DefaultValue_BasicTypes_A_pString_LiteralString12 = new();
				public Property DefaultValue_BasicTypes_A_pUnlimitedNatural = new();
					public LiteralUnlimitedNatural DefaultValue_BasicTypes_A_pUnlimitedNatural_LiteralUnlimitedNatural13 = new();
				public Operation DefaultValue_BasicTypes_A_A_A = new();
					public Parameter DefaultValue_BasicTypes_A_A_A_result = new();
				public Property DefaultValue_BasicTypes_A_pBoolean = new();
					public LiteralBoolean DefaultValue_BasicTypes_A_pBoolean_LiteralBoolean14 = new();
			public Activity DefaultValue_BasicTypes_assert_A = new();
				public ObjectFlow DefaultValue_BasicTypes_assert_A_ObjectFlow15 = new();
					public LiteralInteger DefaultValue_BasicTypes_assert_A_ObjectFlow15_LiteralInteger16 = new();
					public LiteralBoolean DefaultValue_BasicTypes_assert_A_ObjectFlow15_LiteralBoolean17 = new();
				public CallBehaviorAction DefaultValue_BasicTypes_assert_A_Test_Default_Values = new();
					public InputPin DefaultValue_BasicTypes_assert_A_Test_Default_Values_pInteger = new();
						public LiteralUnlimitedNatural DefaultValue_BasicTypes_assert_A_Test_Default_Values_pInteger_LiteralUnlimitedNatural18 = new();
						public LiteralInteger DefaultValue_BasicTypes_assert_A_Test_Default_Values_pInteger_LiteralInteger19 = new();
					public InputPin DefaultValue_BasicTypes_assert_A_Test_Default_Values_pBoolean = new();
						public LiteralUnlimitedNatural DefaultValue_BasicTypes_assert_A_Test_Default_Values_pBoolean_LiteralUnlimitedNatural20 = new();
						public LiteralInteger DefaultValue_BasicTypes_assert_A_Test_Default_Values_pBoolean_LiteralInteger21 = new();
					public InputPin DefaultValue_BasicTypes_assert_A_Test_Default_Values_pReal = new();
						public LiteralInteger DefaultValue_BasicTypes_assert_A_Test_Default_Values_pReal_LiteralInteger22 = new();
						public LiteralUnlimitedNatural DefaultValue_BasicTypes_assert_A_Test_Default_Values_pReal_LiteralUnlimitedNatural23 = new();
					public InputPin DefaultValue_BasicTypes_assert_A_Test_Default_Values_pUnlimitedNatural = new();
						public LiteralInteger DefaultValue_BasicTypes_assert_A_Test_Default_Values_pUnlimitedNatural_LiteralInteger24 = new();
						public LiteralUnlimitedNatural DefaultValue_BasicTypes_assert_A_Test_Default_Values_pUnlimitedNatural_LiteralUnlimitedNatural25 = new();
					public InputPin DefaultValue_BasicTypes_assert_A_Test_Default_Values_pEnum = new();
						public LiteralInteger DefaultValue_BasicTypes_assert_A_Test_Default_Values_pEnum_LiteralInteger26 = new();
						public LiteralUnlimitedNatural DefaultValue_BasicTypes_assert_A_Test_Default_Values_pEnum_LiteralUnlimitedNatural27 = new();
					public InputPin DefaultValue_BasicTypes_assert_A_Test_Default_Values_pString = new();
						public LiteralUnlimitedNatural DefaultValue_BasicTypes_assert_A_Test_Default_Values_pString_LiteralUnlimitedNatural28 = new();
						public LiteralInteger DefaultValue_BasicTypes_assert_A_Test_Default_Values_pString_LiteralInteger29 = new();
				public ObjectFlow DefaultValue_BasicTypes_assert_A_ObjectFlow30 = new();
					public LiteralInteger DefaultValue_BasicTypes_assert_A_ObjectFlow30_LiteralInteger31 = new();
					public LiteralBoolean DefaultValue_BasicTypes_assert_A_ObjectFlow30_LiteralBoolean32 = new();
				public ObjectFlow DefaultValue_BasicTypes_assert_A_ObjectFlow33 = new();
					public LiteralInteger DefaultValue_BasicTypes_assert_A_ObjectFlow33_LiteralInteger34 = new();
					public LiteralBoolean DefaultValue_BasicTypes_assert_A_ObjectFlow33_LiteralBoolean35 = new();
				public ObjectFlow DefaultValue_BasicTypes_assert_A_ObjectFlow36 = new();
					public LiteralInteger DefaultValue_BasicTypes_assert_A_ObjectFlow36_LiteralInteger37 = new();
					public LiteralBoolean DefaultValue_BasicTypes_assert_A_ObjectFlow36_LiteralBoolean38 = new();
				public Parameter DefaultValue_BasicTypes_assert_A_a = new();
				public ReadStructuralFeatureAction DefaultValue_BasicTypes_assert_A_Read_a_pUnlimitedNatural = new();
					public OutputPin DefaultValue_BasicTypes_assert_A_Read_a_pUnlimitedNatural_result = new();
						public LiteralUnlimitedNatural DefaultValue_BasicTypes_assert_A_Read_a_pUnlimitedNatural_result_LiteralUnlimitedNatural39 = new();
						public LiteralInteger DefaultValue_BasicTypes_assert_A_Read_a_pUnlimitedNatural_result_LiteralInteger40 = new();
					public InputPin DefaultValue_BasicTypes_assert_A_Read_a_pUnlimitedNatural_object = new();
						public LiteralInteger DefaultValue_BasicTypes_assert_A_Read_a_pUnlimitedNatural_object_LiteralInteger41 = new();
						public LiteralUnlimitedNatural DefaultValue_BasicTypes_assert_A_Read_a_pUnlimitedNatural_object_LiteralUnlimitedNatural42 = new();
				public ObjectFlow DefaultValue_BasicTypes_assert_A_ObjectFlow43 = new();
					public LiteralBoolean DefaultValue_BasicTypes_assert_A_ObjectFlow43_LiteralBoolean44 = new();
					public LiteralInteger DefaultValue_BasicTypes_assert_A_ObjectFlow43_LiteralInteger45 = new();
				public ObjectFlow DefaultValue_BasicTypes_assert_A_ObjectFlow46 = new();
					public LiteralBoolean DefaultValue_BasicTypes_assert_A_ObjectFlow46_LiteralBoolean47 = new();
					public LiteralInteger DefaultValue_BasicTypes_assert_A_ObjectFlow46_LiteralInteger48 = new();
				public ObjectFlow DefaultValue_BasicTypes_assert_A_ObjectFlow49 = new();
					public LiteralBoolean DefaultValue_BasicTypes_assert_A_ObjectFlow49_LiteralBoolean50 = new();
					public LiteralInteger DefaultValue_BasicTypes_assert_A_ObjectFlow49_LiteralInteger51 = new();
				public ForkNode DefaultValue_BasicTypes_assert_A_Fork_a = new();
				public ReadStructuralFeatureAction DefaultValue_BasicTypes_assert_A_Read_a_pEnum = new();
					public OutputPin DefaultValue_BasicTypes_assert_A_Read_a_pEnum_result = new();
						public LiteralInteger DefaultValue_BasicTypes_assert_A_Read_a_pEnum_result_LiteralInteger52 = new();
						public LiteralUnlimitedNatural DefaultValue_BasicTypes_assert_A_Read_a_pEnum_result_LiteralUnlimitedNatural53 = new();
					public InputPin DefaultValue_BasicTypes_assert_A_Read_a_pEnum_object = new();
						public LiteralUnlimitedNatural DefaultValue_BasicTypes_assert_A_Read_a_pEnum_object_LiteralUnlimitedNatural54 = new();
						public LiteralInteger DefaultValue_BasicTypes_assert_A_Read_a_pEnum_object_LiteralInteger55 = new();
				public ObjectFlow DefaultValue_BasicTypes_assert_A_ObjectFlow56 = new();
					public LiteralInteger DefaultValue_BasicTypes_assert_A_ObjectFlow56_LiteralInteger57 = new();
					public LiteralBoolean DefaultValue_BasicTypes_assert_A_ObjectFlow56_LiteralBoolean58 = new();
				public ReadStructuralFeatureAction DefaultValue_BasicTypes_assert_A_Read_a_pReal = new();
					public OutputPin DefaultValue_BasicTypes_assert_A_Read_a_pReal_result = new();
						public LiteralInteger DefaultValue_BasicTypes_assert_A_Read_a_pReal_result_LiteralInteger59 = new();
						public LiteralUnlimitedNatural DefaultValue_BasicTypes_assert_A_Read_a_pReal_result_LiteralUnlimitedNatural60 = new();
					public InputPin DefaultValue_BasicTypes_assert_A_Read_a_pReal_object = new();
						public LiteralInteger DefaultValue_BasicTypes_assert_A_Read_a_pReal_object_LiteralInteger61 = new();
						public LiteralUnlimitedNatural DefaultValue_BasicTypes_assert_A_Read_a_pReal_object_LiteralUnlimitedNatural62 = new();
				public ObjectFlow DefaultValue_BasicTypes_assert_A_ObjectFlow63 = new();
					public LiteralBoolean DefaultValue_BasicTypes_assert_A_ObjectFlow63_LiteralBoolean64 = new();
					public LiteralInteger DefaultValue_BasicTypes_assert_A_ObjectFlow63_LiteralInteger65 = new();
				public ObjectFlow DefaultValue_BasicTypes_assert_A_ObjectFlow66 = new();
					public LiteralBoolean DefaultValue_BasicTypes_assert_A_ObjectFlow66_LiteralBoolean67 = new();
					public LiteralInteger DefaultValue_BasicTypes_assert_A_ObjectFlow66_LiteralInteger68 = new();
				public ReadStructuralFeatureAction DefaultValue_BasicTypes_assert_A_Read_a_pInteger = new();
					public OutputPin DefaultValue_BasicTypes_assert_A_Read_a_pInteger_result = new();
						public LiteralInteger DefaultValue_BasicTypes_assert_A_Read_a_pInteger_result_LiteralInteger69 = new();
						public LiteralUnlimitedNatural DefaultValue_BasicTypes_assert_A_Read_a_pInteger_result_LiteralUnlimitedNatural70 = new();
					public InputPin DefaultValue_BasicTypes_assert_A_Read_a_pInteger_object = new();
						public LiteralInteger DefaultValue_BasicTypes_assert_A_Read_a_pInteger_object_LiteralInteger71 = new();
						public LiteralUnlimitedNatural DefaultValue_BasicTypes_assert_A_Read_a_pInteger_object_LiteralUnlimitedNatural72 = new();
				public ObjectFlow DefaultValue_BasicTypes_assert_A_ObjectFlow73 = new();
					public LiteralInteger DefaultValue_BasicTypes_assert_A_ObjectFlow73_LiteralInteger74 = new();
					public LiteralBoolean DefaultValue_BasicTypes_assert_A_ObjectFlow73_LiteralBoolean75 = new();
				public OpaqueBehavior DefaultValue_BasicTypes_assert_A_testDefaultValues = new();
					public Parameter DefaultValue_BasicTypes_assert_A_testDefaultValues_pString = new();
					public Parameter DefaultValue_BasicTypes_assert_A_testDefaultValues_pUnlimitedNatural = new();
					public Parameter DefaultValue_BasicTypes_assert_A_testDefaultValues_pReal = new();
					public Parameter DefaultValue_BasicTypes_assert_A_testDefaultValues_pBoolean = new();
					public Parameter DefaultValue_BasicTypes_assert_A_testDefaultValues_pInteger = new();
					public Parameter DefaultValue_BasicTypes_assert_A_testDefaultValues_pEnum = new();
				public ReadStructuralFeatureAction DefaultValue_BasicTypes_assert_A_Read_a_pString = new();
					public InputPin DefaultValue_BasicTypes_assert_A_Read_a_pString_object = new();
						public LiteralInteger DefaultValue_BasicTypes_assert_A_Read_a_pString_object_LiteralInteger76 = new();
						public LiteralUnlimitedNatural DefaultValue_BasicTypes_assert_A_Read_a_pString_object_LiteralUnlimitedNatural77 = new();
					public OutputPin DefaultValue_BasicTypes_assert_A_Read_a_pString_result = new();
						public LiteralUnlimitedNatural DefaultValue_BasicTypes_assert_A_Read_a_pString_result_LiteralUnlimitedNatural78 = new();
						public LiteralInteger DefaultValue_BasicTypes_assert_A_Read_a_pString_result_LiteralInteger79 = new();
				public ActivityParameterNode DefaultValue_BasicTypes_assert_A_a_node = new();
					public LiteralInteger DefaultValue_BasicTypes_assert_A_a_node_LiteralInteger80 = new();
				public ReadStructuralFeatureAction DefaultValue_BasicTypes_assert_A_Read_a_pBoolean = new();
					public InputPin DefaultValue_BasicTypes_assert_A_Read_a_pBoolean_object = new();
						public LiteralUnlimitedNatural DefaultValue_BasicTypes_assert_A_Read_a_pBoolean_object_LiteralUnlimitedNatural81 = new();
						public LiteralInteger DefaultValue_BasicTypes_assert_A_Read_a_pBoolean_object_LiteralInteger82 = new();
					public OutputPin DefaultValue_BasicTypes_assert_A_Read_a_pBoolean_result = new();
						public LiteralInteger DefaultValue_BasicTypes_assert_A_Read_a_pBoolean_result_LiteralInteger83 = new();
						public LiteralUnlimitedNatural DefaultValue_BasicTypes_assert_A_Read_a_pBoolean_result_LiteralUnlimitedNatural84 = new();
				public ObjectFlow DefaultValue_BasicTypes_assert_A_ObjectFlow85 = new();
					public LiteralInteger DefaultValue_BasicTypes_assert_A_ObjectFlow85_LiteralInteger86 = new();
					public LiteralBoolean DefaultValue_BasicTypes_assert_A_ObjectFlow85_LiteralBoolean87 = new();
				public ObjectFlow DefaultValue_BasicTypes_assert_A_ObjectFlow88 = new();
					public LiteralBoolean DefaultValue_BasicTypes_assert_A_ObjectFlow88_LiteralBoolean89 = new();
					public LiteralInteger DefaultValue_BasicTypes_assert_A_ObjectFlow88_LiteralInteger90 = new();
			public Activity DefaultValue_BasicTypes_instantiate_A = new();
				public ActivityParameterNode DefaultValue_BasicTypes_instantiate_A_a_node = new();
					public LiteralInteger DefaultValue_BasicTypes_instantiate_A_a_node_LiteralInteger91 = new();
				public CallOperationAction DefaultValue_BasicTypes_instantiate_A_A_ = new();
					public InputPin DefaultValue_BasicTypes_instantiate_A_A__target = new();
						public LiteralInteger DefaultValue_BasicTypes_instantiate_A_A__target_LiteralInteger92 = new();
						public LiteralUnlimitedNatural DefaultValue_BasicTypes_instantiate_A_A__target_LiteralUnlimitedNatural93 = new();
					public OutputPin DefaultValue_BasicTypes_instantiate_A_A__result = new();
						public LiteralUnlimitedNatural DefaultValue_BasicTypes_instantiate_A_A__result_LiteralUnlimitedNatural94 = new();
						public LiteralInteger DefaultValue_BasicTypes_instantiate_A_A__result_LiteralInteger95 = new();
						public LiteralInteger DefaultValue_BasicTypes_instantiate_A_A__result_LiteralInteger96 = new();
				public CreateObjectAction DefaultValue_BasicTypes_instantiate_A_Create_A = new();
					public OutputPin DefaultValue_BasicTypes_instantiate_A_Create_A_result = new();
						public LiteralInteger DefaultValue_BasicTypes_instantiate_A_Create_A_result_LiteralInteger97 = new();
						public LiteralUnlimitedNatural DefaultValue_BasicTypes_instantiate_A_Create_A_result_LiteralUnlimitedNatural98 = new();
				public ObjectFlow DefaultValue_BasicTypes_instantiate_A_ObjectFlow99 = new();
					public LiteralInteger DefaultValue_BasicTypes_instantiate_A_ObjectFlow99_LiteralInteger100 = new();
					public LiteralBoolean DefaultValue_BasicTypes_instantiate_A_ObjectFlow99_LiteralBoolean101 = new();
				public Parameter DefaultValue_BasicTypes_instantiate_A_a = new();
				public ObjectFlow DefaultValue_BasicTypes_instantiate_A_ObjectFlow102 = new();
					public LiteralBoolean DefaultValue_BasicTypes_instantiate_A_ObjectFlow102_LiteralBoolean103 = new();
					public LiteralInteger DefaultValue_BasicTypes_instantiate_A_ObjectFlow102_LiteralInteger104 = new();

		public static DefaultValue_BasicTypesModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public DefaultValue_BasicTypesModel()
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
			 * Model DefaultValue_BasicTypes
			 */
			AddToElementRepository("DefaultValue_BasicTypes", DefaultValue_BasicTypes);
				AddToElementRepository("main", DefaultValue_BasicTypes_main);
					AddToElementRepository("assert_A", DefaultValue_BasicTypes_main_assert_A);
						AddToElementRepository("a", DefaultValue_BasicTypes_main_assert_A_a);
							AddToElementRepository("LiteralInteger0", DefaultValue_BasicTypes_main_assert_A_a_LiteralInteger0);
							AddToElementRepository("LiteralUnlimitedNatural1", DefaultValue_BasicTypes_main_assert_A_a_LiteralUnlimitedNatural1);
							AddToElementRepository("LiteralInteger2", DefaultValue_BasicTypes_main_assert_A_a_LiteralInteger2);
					AddToElementRepository("ObjectFlow3", DefaultValue_BasicTypes_main_ObjectFlow3);
						AddToElementRepository("LiteralInteger4", DefaultValue_BasicTypes_main_ObjectFlow3_LiteralInteger4);
						AddToElementRepository("LiteralBoolean5", DefaultValue_BasicTypes_main_ObjectFlow3_LiteralBoolean5);
					AddToElementRepository("instantiate_A", DefaultValue_BasicTypes_main_instantiate_A);
						AddToElementRepository("a", DefaultValue_BasicTypes_main_instantiate_A_a);
							AddToElementRepository("LiteralInteger6", DefaultValue_BasicTypes_main_instantiate_A_a_LiteralInteger6);
							AddToElementRepository("LiteralInteger7", DefaultValue_BasicTypes_main_instantiate_A_a_LiteralInteger7);
							AddToElementRepository("LiteralUnlimitedNatural8", DefaultValue_BasicTypes_main_instantiate_A_a_LiteralUnlimitedNatural8);
				AddToElementRepository("E", DefaultValue_BasicTypes_E);
					AddToElementRepository("e1", DefaultValue_BasicTypes_E_e1);
					AddToElementRepository("e2", DefaultValue_BasicTypes_E_e2);
				AddToElementRepository("A", DefaultValue_BasicTypes_A);
					AddToElementRepository("pInteger", DefaultValue_BasicTypes_A_pInteger);
						AddToElementRepository("LiteralInteger9", DefaultValue_BasicTypes_A_pInteger_LiteralInteger9);
					AddToElementRepository("pReal", DefaultValue_BasicTypes_A_pReal);
						AddToElementRepository("LiteralReal10", DefaultValue_BasicTypes_A_pReal_LiteralReal10);
					AddToElementRepository("pEnum", DefaultValue_BasicTypes_A_pEnum);
						AddToElementRepository("InstanceValue11", DefaultValue_BasicTypes_A_pEnum_InstanceValue11);
					AddToElementRepository("pString", DefaultValue_BasicTypes_A_pString);
						AddToElementRepository("LiteralString12", DefaultValue_BasicTypes_A_pString_LiteralString12);
					AddToElementRepository("pUnlimitedNatural", DefaultValue_BasicTypes_A_pUnlimitedNatural);
						AddToElementRepository("LiteralUnlimitedNatural13", DefaultValue_BasicTypes_A_pUnlimitedNatural_LiteralUnlimitedNatural13);
					AddToElementRepository("A_A", DefaultValue_BasicTypes_A_A_A);
						AddToElementRepository("result", DefaultValue_BasicTypes_A_A_A_result);
					AddToElementRepository("pBoolean", DefaultValue_BasicTypes_A_pBoolean);
						AddToElementRepository("LiteralBoolean14", DefaultValue_BasicTypes_A_pBoolean_LiteralBoolean14);
				AddToElementRepository("assert_A", DefaultValue_BasicTypes_assert_A);
					AddToElementRepository("ObjectFlow15", DefaultValue_BasicTypes_assert_A_ObjectFlow15);
						AddToElementRepository("LiteralInteger16", DefaultValue_BasicTypes_assert_A_ObjectFlow15_LiteralInteger16);
						AddToElementRepository("LiteralBoolean17", DefaultValue_BasicTypes_assert_A_ObjectFlow15_LiteralBoolean17);
					AddToElementRepository("Test Default Values", DefaultValue_BasicTypes_assert_A_Test_Default_Values);
						AddToElementRepository("pInteger", DefaultValue_BasicTypes_assert_A_Test_Default_Values_pInteger);
							AddToElementRepository("LiteralUnlimitedNatural18", DefaultValue_BasicTypes_assert_A_Test_Default_Values_pInteger_LiteralUnlimitedNatural18);
							AddToElementRepository("LiteralInteger19", DefaultValue_BasicTypes_assert_A_Test_Default_Values_pInteger_LiteralInteger19);
						AddToElementRepository("pBoolean", DefaultValue_BasicTypes_assert_A_Test_Default_Values_pBoolean);
							AddToElementRepository("LiteralUnlimitedNatural20", DefaultValue_BasicTypes_assert_A_Test_Default_Values_pBoolean_LiteralUnlimitedNatural20);
							AddToElementRepository("LiteralInteger21", DefaultValue_BasicTypes_assert_A_Test_Default_Values_pBoolean_LiteralInteger21);
						AddToElementRepository("pReal", DefaultValue_BasicTypes_assert_A_Test_Default_Values_pReal);
							AddToElementRepository("LiteralInteger22", DefaultValue_BasicTypes_assert_A_Test_Default_Values_pReal_LiteralInteger22);
							AddToElementRepository("LiteralUnlimitedNatural23", DefaultValue_BasicTypes_assert_A_Test_Default_Values_pReal_LiteralUnlimitedNatural23);
						AddToElementRepository("pUnlimitedNatural", DefaultValue_BasicTypes_assert_A_Test_Default_Values_pUnlimitedNatural);
							AddToElementRepository("LiteralInteger24", DefaultValue_BasicTypes_assert_A_Test_Default_Values_pUnlimitedNatural_LiteralInteger24);
							AddToElementRepository("LiteralUnlimitedNatural25", DefaultValue_BasicTypes_assert_A_Test_Default_Values_pUnlimitedNatural_LiteralUnlimitedNatural25);
						AddToElementRepository("pEnum", DefaultValue_BasicTypes_assert_A_Test_Default_Values_pEnum);
							AddToElementRepository("LiteralInteger26", DefaultValue_BasicTypes_assert_A_Test_Default_Values_pEnum_LiteralInteger26);
							AddToElementRepository("LiteralUnlimitedNatural27", DefaultValue_BasicTypes_assert_A_Test_Default_Values_pEnum_LiteralUnlimitedNatural27);
						AddToElementRepository("pString", DefaultValue_BasicTypes_assert_A_Test_Default_Values_pString);
							AddToElementRepository("LiteralUnlimitedNatural28", DefaultValue_BasicTypes_assert_A_Test_Default_Values_pString_LiteralUnlimitedNatural28);
							AddToElementRepository("LiteralInteger29", DefaultValue_BasicTypes_assert_A_Test_Default_Values_pString_LiteralInteger29);
					AddToElementRepository("ObjectFlow30", DefaultValue_BasicTypes_assert_A_ObjectFlow30);
						AddToElementRepository("LiteralInteger31", DefaultValue_BasicTypes_assert_A_ObjectFlow30_LiteralInteger31);
						AddToElementRepository("LiteralBoolean32", DefaultValue_BasicTypes_assert_A_ObjectFlow30_LiteralBoolean32);
					AddToElementRepository("ObjectFlow33", DefaultValue_BasicTypes_assert_A_ObjectFlow33);
						AddToElementRepository("LiteralInteger34", DefaultValue_BasicTypes_assert_A_ObjectFlow33_LiteralInteger34);
						AddToElementRepository("LiteralBoolean35", DefaultValue_BasicTypes_assert_A_ObjectFlow33_LiteralBoolean35);
					AddToElementRepository("ObjectFlow36", DefaultValue_BasicTypes_assert_A_ObjectFlow36);
						AddToElementRepository("LiteralInteger37", DefaultValue_BasicTypes_assert_A_ObjectFlow36_LiteralInteger37);
						AddToElementRepository("LiteralBoolean38", DefaultValue_BasicTypes_assert_A_ObjectFlow36_LiteralBoolean38);
					AddToElementRepository("a", DefaultValue_BasicTypes_assert_A_a);
					AddToElementRepository("Read a.pUnlimitedNatural", DefaultValue_BasicTypes_assert_A_Read_a_pUnlimitedNatural);
						AddToElementRepository("result", DefaultValue_BasicTypes_assert_A_Read_a_pUnlimitedNatural_result);
							AddToElementRepository("LiteralUnlimitedNatural39", DefaultValue_BasicTypes_assert_A_Read_a_pUnlimitedNatural_result_LiteralUnlimitedNatural39);
							AddToElementRepository("LiteralInteger40", DefaultValue_BasicTypes_assert_A_Read_a_pUnlimitedNatural_result_LiteralInteger40);
						AddToElementRepository("object", DefaultValue_BasicTypes_assert_A_Read_a_pUnlimitedNatural_object);
							AddToElementRepository("LiteralInteger41", DefaultValue_BasicTypes_assert_A_Read_a_pUnlimitedNatural_object_LiteralInteger41);
							AddToElementRepository("LiteralUnlimitedNatural42", DefaultValue_BasicTypes_assert_A_Read_a_pUnlimitedNatural_object_LiteralUnlimitedNatural42);
					AddToElementRepository("ObjectFlow43", DefaultValue_BasicTypes_assert_A_ObjectFlow43);
						AddToElementRepository("LiteralBoolean44", DefaultValue_BasicTypes_assert_A_ObjectFlow43_LiteralBoolean44);
						AddToElementRepository("LiteralInteger45", DefaultValue_BasicTypes_assert_A_ObjectFlow43_LiteralInteger45);
					AddToElementRepository("ObjectFlow46", DefaultValue_BasicTypes_assert_A_ObjectFlow46);
						AddToElementRepository("LiteralBoolean47", DefaultValue_BasicTypes_assert_A_ObjectFlow46_LiteralBoolean47);
						AddToElementRepository("LiteralInteger48", DefaultValue_BasicTypes_assert_A_ObjectFlow46_LiteralInteger48);
					AddToElementRepository("ObjectFlow49", DefaultValue_BasicTypes_assert_A_ObjectFlow49);
						AddToElementRepository("LiteralBoolean50", DefaultValue_BasicTypes_assert_A_ObjectFlow49_LiteralBoolean50);
						AddToElementRepository("LiteralInteger51", DefaultValue_BasicTypes_assert_A_ObjectFlow49_LiteralInteger51);
					AddToElementRepository("Fork_a", DefaultValue_BasicTypes_assert_A_Fork_a);
					AddToElementRepository("Read a.pEnum", DefaultValue_BasicTypes_assert_A_Read_a_pEnum);
						AddToElementRepository("result", DefaultValue_BasicTypes_assert_A_Read_a_pEnum_result);
							AddToElementRepository("LiteralInteger52", DefaultValue_BasicTypes_assert_A_Read_a_pEnum_result_LiteralInteger52);
							AddToElementRepository("LiteralUnlimitedNatural53", DefaultValue_BasicTypes_assert_A_Read_a_pEnum_result_LiteralUnlimitedNatural53);
						AddToElementRepository("object", DefaultValue_BasicTypes_assert_A_Read_a_pEnum_object);
							AddToElementRepository("LiteralUnlimitedNatural54", DefaultValue_BasicTypes_assert_A_Read_a_pEnum_object_LiteralUnlimitedNatural54);
							AddToElementRepository("LiteralInteger55", DefaultValue_BasicTypes_assert_A_Read_a_pEnum_object_LiteralInteger55);
					AddToElementRepository("ObjectFlow56", DefaultValue_BasicTypes_assert_A_ObjectFlow56);
						AddToElementRepository("LiteralInteger57", DefaultValue_BasicTypes_assert_A_ObjectFlow56_LiteralInteger57);
						AddToElementRepository("LiteralBoolean58", DefaultValue_BasicTypes_assert_A_ObjectFlow56_LiteralBoolean58);
					AddToElementRepository("Read a.pReal", DefaultValue_BasicTypes_assert_A_Read_a_pReal);
						AddToElementRepository("result", DefaultValue_BasicTypes_assert_A_Read_a_pReal_result);
							AddToElementRepository("LiteralInteger59", DefaultValue_BasicTypes_assert_A_Read_a_pReal_result_LiteralInteger59);
							AddToElementRepository("LiteralUnlimitedNatural60", DefaultValue_BasicTypes_assert_A_Read_a_pReal_result_LiteralUnlimitedNatural60);
						AddToElementRepository("object", DefaultValue_BasicTypes_assert_A_Read_a_pReal_object);
							AddToElementRepository("LiteralInteger61", DefaultValue_BasicTypes_assert_A_Read_a_pReal_object_LiteralInteger61);
							AddToElementRepository("LiteralUnlimitedNatural62", DefaultValue_BasicTypes_assert_A_Read_a_pReal_object_LiteralUnlimitedNatural62);
					AddToElementRepository("ObjectFlow63", DefaultValue_BasicTypes_assert_A_ObjectFlow63);
						AddToElementRepository("LiteralBoolean64", DefaultValue_BasicTypes_assert_A_ObjectFlow63_LiteralBoolean64);
						AddToElementRepository("LiteralInteger65", DefaultValue_BasicTypes_assert_A_ObjectFlow63_LiteralInteger65);
					AddToElementRepository("ObjectFlow66", DefaultValue_BasicTypes_assert_A_ObjectFlow66);
						AddToElementRepository("LiteralBoolean67", DefaultValue_BasicTypes_assert_A_ObjectFlow66_LiteralBoolean67);
						AddToElementRepository("LiteralInteger68", DefaultValue_BasicTypes_assert_A_ObjectFlow66_LiteralInteger68);
					AddToElementRepository("Read a.pInteger", DefaultValue_BasicTypes_assert_A_Read_a_pInteger);
						AddToElementRepository("result", DefaultValue_BasicTypes_assert_A_Read_a_pInteger_result);
							AddToElementRepository("LiteralInteger69", DefaultValue_BasicTypes_assert_A_Read_a_pInteger_result_LiteralInteger69);
							AddToElementRepository("LiteralUnlimitedNatural70", DefaultValue_BasicTypes_assert_A_Read_a_pInteger_result_LiteralUnlimitedNatural70);
						AddToElementRepository("object", DefaultValue_BasicTypes_assert_A_Read_a_pInteger_object);
							AddToElementRepository("LiteralInteger71", DefaultValue_BasicTypes_assert_A_Read_a_pInteger_object_LiteralInteger71);
							AddToElementRepository("LiteralUnlimitedNatural72", DefaultValue_BasicTypes_assert_A_Read_a_pInteger_object_LiteralUnlimitedNatural72);
					AddToElementRepository("ObjectFlow73", DefaultValue_BasicTypes_assert_A_ObjectFlow73);
						AddToElementRepository("LiteralInteger74", DefaultValue_BasicTypes_assert_A_ObjectFlow73_LiteralInteger74);
						AddToElementRepository("LiteralBoolean75", DefaultValue_BasicTypes_assert_A_ObjectFlow73_LiteralBoolean75);
					AddToElementRepository("testDefaultValues", DefaultValue_BasicTypes_assert_A_testDefaultValues);
						AddToElementRepository("pString", DefaultValue_BasicTypes_assert_A_testDefaultValues_pString);
						AddToElementRepository("pUnlimitedNatural", DefaultValue_BasicTypes_assert_A_testDefaultValues_pUnlimitedNatural);
						AddToElementRepository("pReal", DefaultValue_BasicTypes_assert_A_testDefaultValues_pReal);
						AddToElementRepository("pBoolean", DefaultValue_BasicTypes_assert_A_testDefaultValues_pBoolean);
						AddToElementRepository("pInteger", DefaultValue_BasicTypes_assert_A_testDefaultValues_pInteger);
						AddToElementRepository("pEnum", DefaultValue_BasicTypes_assert_A_testDefaultValues_pEnum);
					AddToElementRepository("Read a.pString", DefaultValue_BasicTypes_assert_A_Read_a_pString);
						AddToElementRepository("object", DefaultValue_BasicTypes_assert_A_Read_a_pString_object);
							AddToElementRepository("LiteralInteger76", DefaultValue_BasicTypes_assert_A_Read_a_pString_object_LiteralInteger76);
							AddToElementRepository("LiteralUnlimitedNatural77", DefaultValue_BasicTypes_assert_A_Read_a_pString_object_LiteralUnlimitedNatural77);
						AddToElementRepository("result", DefaultValue_BasicTypes_assert_A_Read_a_pString_result);
							AddToElementRepository("LiteralUnlimitedNatural78", DefaultValue_BasicTypes_assert_A_Read_a_pString_result_LiteralUnlimitedNatural78);
							AddToElementRepository("LiteralInteger79", DefaultValue_BasicTypes_assert_A_Read_a_pString_result_LiteralInteger79);
					AddToElementRepository("a_node", DefaultValue_BasicTypes_assert_A_a_node);
						AddToElementRepository("LiteralInteger80", DefaultValue_BasicTypes_assert_A_a_node_LiteralInteger80);
					AddToElementRepository("Read a.pBoolean", DefaultValue_BasicTypes_assert_A_Read_a_pBoolean);
						AddToElementRepository("object", DefaultValue_BasicTypes_assert_A_Read_a_pBoolean_object);
							AddToElementRepository("LiteralUnlimitedNatural81", DefaultValue_BasicTypes_assert_A_Read_a_pBoolean_object_LiteralUnlimitedNatural81);
							AddToElementRepository("LiteralInteger82", DefaultValue_BasicTypes_assert_A_Read_a_pBoolean_object_LiteralInteger82);
						AddToElementRepository("result", DefaultValue_BasicTypes_assert_A_Read_a_pBoolean_result);
							AddToElementRepository("LiteralInteger83", DefaultValue_BasicTypes_assert_A_Read_a_pBoolean_result_LiteralInteger83);
							AddToElementRepository("LiteralUnlimitedNatural84", DefaultValue_BasicTypes_assert_A_Read_a_pBoolean_result_LiteralUnlimitedNatural84);
					AddToElementRepository("ObjectFlow85", DefaultValue_BasicTypes_assert_A_ObjectFlow85);
						AddToElementRepository("LiteralInteger86", DefaultValue_BasicTypes_assert_A_ObjectFlow85_LiteralInteger86);
						AddToElementRepository("LiteralBoolean87", DefaultValue_BasicTypes_assert_A_ObjectFlow85_LiteralBoolean87);
					AddToElementRepository("ObjectFlow88", DefaultValue_BasicTypes_assert_A_ObjectFlow88);
						AddToElementRepository("LiteralBoolean89", DefaultValue_BasicTypes_assert_A_ObjectFlow88_LiteralBoolean89);
						AddToElementRepository("LiteralInteger90", DefaultValue_BasicTypes_assert_A_ObjectFlow88_LiteralInteger90);
				AddToElementRepository("instantiate_A", DefaultValue_BasicTypes_instantiate_A);
					AddToElementRepository("a_node", DefaultValue_BasicTypes_instantiate_A_a_node);
						AddToElementRepository("LiteralInteger91", DefaultValue_BasicTypes_instantiate_A_a_node_LiteralInteger91);
					AddToElementRepository("A()", DefaultValue_BasicTypes_instantiate_A_A_);
						AddToElementRepository("target", DefaultValue_BasicTypes_instantiate_A_A__target);
							AddToElementRepository("LiteralInteger92", DefaultValue_BasicTypes_instantiate_A_A__target_LiteralInteger92);
							AddToElementRepository("LiteralUnlimitedNatural93", DefaultValue_BasicTypes_instantiate_A_A__target_LiteralUnlimitedNatural93);
						AddToElementRepository("result", DefaultValue_BasicTypes_instantiate_A_A__result);
							AddToElementRepository("LiteralUnlimitedNatural94", DefaultValue_BasicTypes_instantiate_A_A__result_LiteralUnlimitedNatural94);
							AddToElementRepository("LiteralInteger95", DefaultValue_BasicTypes_instantiate_A_A__result_LiteralInteger95);
							AddToElementRepository("LiteralInteger96", DefaultValue_BasicTypes_instantiate_A_A__result_LiteralInteger96);
					AddToElementRepository("Create_A", DefaultValue_BasicTypes_instantiate_A_Create_A);
						AddToElementRepository("result", DefaultValue_BasicTypes_instantiate_A_Create_A_result);
							AddToElementRepository("LiteralInteger97", DefaultValue_BasicTypes_instantiate_A_Create_A_result_LiteralInteger97);
							AddToElementRepository("LiteralUnlimitedNatural98", DefaultValue_BasicTypes_instantiate_A_Create_A_result_LiteralUnlimitedNatural98);
					AddToElementRepository("ObjectFlow99", DefaultValue_BasicTypes_instantiate_A_ObjectFlow99);
						AddToElementRepository("LiteralInteger100", DefaultValue_BasicTypes_instantiate_A_ObjectFlow99_LiteralInteger100);
						AddToElementRepository("LiteralBoolean101", DefaultValue_BasicTypes_instantiate_A_ObjectFlow99_LiteralBoolean101);
					AddToElementRepository("a", DefaultValue_BasicTypes_instantiate_A_a);
					AddToElementRepository("ObjectFlow102", DefaultValue_BasicTypes_instantiate_A_ObjectFlow102);
						AddToElementRepository("LiteralBoolean103", DefaultValue_BasicTypes_instantiate_A_ObjectFlow102_LiteralBoolean103);
						AddToElementRepository("LiteralInteger104", DefaultValue_BasicTypes_instantiate_A_ObjectFlow102_LiteralInteger104);

			// Initialize public members
			/*
			 * Model DefaultValue_BasicTypes
			 */
			DefaultValue_BasicTypes.SetName("DefaultValue_BasicTypes");
			DefaultValue_BasicTypes.SetVisibility(VisibilityKind.public_);
				// Activity main
				DefaultValue_BasicTypes_main.SetName("main");
				DefaultValue_BasicTypes_main.SetVisibility(VisibilityKind.public_);
					// CallBehaviorAction assert_A
					DefaultValue_BasicTypes_main_assert_A.SetName("assert_A");
					DefaultValue_BasicTypes_main_assert_A.SetVisibility(VisibilityKind.public_);
					DefaultValue_BasicTypes_main_assert_A.SetBehavior(DefaultValue_BasicTypes_assert_A);
						// InputPin a
						DefaultValue_BasicTypes_main_assert_A_a.SetName("a");
						DefaultValue_BasicTypes_main_assert_A_a.SetVisibility(VisibilityKind.public_);
					DefaultValue_BasicTypes_main_assert_A.AddArgument(DefaultValue_BasicTypes_main_assert_A_a);
				DefaultValue_BasicTypes_main.AddNode(DefaultValue_BasicTypes_main_assert_A);
					// CallBehaviorAction instantiate_A
					DefaultValue_BasicTypes_main_instantiate_A.SetName("instantiate_A");
					DefaultValue_BasicTypes_main_instantiate_A.SetVisibility(VisibilityKind.public_);
					
						// OutputPin a
						DefaultValue_BasicTypes_main_instantiate_A_a.SetName("a");
						DefaultValue_BasicTypes_main_instantiate_A_a.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_main_instantiate_A_a.SetType(DefaultValue_BasicTypes_A);
					DefaultValue_BasicTypes_main_instantiate_A.AddResult(DefaultValue_BasicTypes_main_instantiate_A_a);
					DefaultValue_BasicTypes_main_instantiate_A.SetBehavior(DefaultValue_BasicTypes_instantiate_A);
				DefaultValue_BasicTypes_main.AddNode(DefaultValue_BasicTypes_main_instantiate_A);
					// ObjectFlow ObjectFlow3 from a to a
					DefaultValue_BasicTypes_main_ObjectFlow3.SetName("ObjectFlow3");
					DefaultValue_BasicTypes_main_ObjectFlow3.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_BasicTypes_main_ObjectFlow3.SetSource(DefaultValue_BasicTypes_main_instantiate_A_a);
					DefaultValue_BasicTypes_main_ObjectFlow3.SetTarget(DefaultValue_BasicTypes_main_assert_A_a);
						// LiteralBoolean LiteralBoolean5
						DefaultValue_BasicTypes_main_ObjectFlow3_LiteralBoolean5.SetName("LiteralBoolean5");
						DefaultValue_BasicTypes_main_ObjectFlow3_LiteralBoolean5.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_main_ObjectFlow3_LiteralBoolean5.SetValue(true);
					DefaultValue_BasicTypes_main_ObjectFlow3.SetGuard(DefaultValue_BasicTypes_main_ObjectFlow3_LiteralBoolean5);
				DefaultValue_BasicTypes_main.AddEdge(DefaultValue_BasicTypes_main_ObjectFlow3);
			DefaultValue_BasicTypes.AddPackagedElement(DefaultValue_BasicTypes_main);
				// Enumeration E
				DefaultValue_BasicTypes_E.SetName("E");
				DefaultValue_BasicTypes_E.SetVisibility(VisibilityKind.public_);
				
					// EnumerationLiteral e1
					DefaultValue_BasicTypes_E_e1.SetName("e1");
					DefaultValue_BasicTypes_E_e1.SetVisibility(VisibilityKind.public_);
					DefaultValue_BasicTypes_E_e1.AddClassifier(DefaultValue_BasicTypes_E);
				DefaultValue_BasicTypes_E.AddOwnedLiteral(DefaultValue_BasicTypes_E_e1);
					// EnumerationLiteral e2
					DefaultValue_BasicTypes_E_e2.SetName("e2");
					DefaultValue_BasicTypes_E_e2.SetVisibility(VisibilityKind.public_);
					DefaultValue_BasicTypes_E_e2.AddClassifier(DefaultValue_BasicTypes_E);
				DefaultValue_BasicTypes_E.AddOwnedLiteral(DefaultValue_BasicTypes_E_e2);
			DefaultValue_BasicTypes.AddPackagedElement(DefaultValue_BasicTypes_E);
				// Class A
				DefaultValue_BasicTypes_A.SetName("A");
				DefaultValue_BasicTypes_A.SetVisibility(VisibilityKind.public_);
				
					// Property pInteger
					DefaultValue_BasicTypes_A_pInteger.SetName("pInteger");
					DefaultValue_BasicTypes_A_pInteger.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_BasicTypes_A_pInteger.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						// LiteralInteger LiteralInteger9
						DefaultValue_BasicTypes_A_pInteger_LiteralInteger9.SetName("LiteralInteger9");
						DefaultValue_BasicTypes_A_pInteger_LiteralInteger9.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_A_pInteger_LiteralInteger9.SetValue(4);
					DefaultValue_BasicTypes_A_pInteger.SetDefaultValue(DefaultValue_BasicTypes_A_pInteger_LiteralInteger9);
				DefaultValue_BasicTypes_A.AddOwnedAttribute(DefaultValue_BasicTypes_A_pInteger);
					// Property pString
					DefaultValue_BasicTypes_A_pString.SetName("pString");
					DefaultValue_BasicTypes_A_pString.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_BasicTypes_A_pString.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
						// LiteralString LiteralString12
						DefaultValue_BasicTypes_A_pString_LiteralString12.SetName("LiteralString12");
						DefaultValue_BasicTypes_A_pString_LiteralString12.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_A_pString_LiteralString12.SetValue("Hello");
					DefaultValue_BasicTypes_A_pString.SetDefaultValue(DefaultValue_BasicTypes_A_pString_LiteralString12);
				DefaultValue_BasicTypes_A.AddOwnedAttribute(DefaultValue_BasicTypes_A_pString);
					// Property pBoolean
					DefaultValue_BasicTypes_A_pBoolean.SetName("pBoolean");
					DefaultValue_BasicTypes_A_pBoolean.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_BasicTypes_A_pBoolean.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
						// LiteralBoolean LiteralBoolean14
						DefaultValue_BasicTypes_A_pBoolean_LiteralBoolean14.SetName("LiteralBoolean14");
						DefaultValue_BasicTypes_A_pBoolean_LiteralBoolean14.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_A_pBoolean_LiteralBoolean14.SetValue(true);
					DefaultValue_BasicTypes_A_pBoolean.SetDefaultValue(DefaultValue_BasicTypes_A_pBoolean_LiteralBoolean14);
				DefaultValue_BasicTypes_A.AddOwnedAttribute(DefaultValue_BasicTypes_A_pBoolean);
					// Property pUnlimitedNatural
					DefaultValue_BasicTypes_A_pUnlimitedNatural.SetName("pUnlimitedNatural");
					DefaultValue_BasicTypes_A_pUnlimitedNatural.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_BasicTypes_A_pUnlimitedNatural.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_UnlimitedNatural);
						// LiteralUnlimitedNatural LiteralUnlimitedNatural13
						DefaultValue_BasicTypes_A_pUnlimitedNatural_LiteralUnlimitedNatural13.SetName("LiteralUnlimitedNatural13");
						DefaultValue_BasicTypes_A_pUnlimitedNatural_LiteralUnlimitedNatural13.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_A_pUnlimitedNatural_LiteralUnlimitedNatural13.SetValue(-1);
					DefaultValue_BasicTypes_A_pUnlimitedNatural.SetDefaultValue(DefaultValue_BasicTypes_A_pUnlimitedNatural_LiteralUnlimitedNatural13);
				DefaultValue_BasicTypes_A.AddOwnedAttribute(DefaultValue_BasicTypes_A_pUnlimitedNatural);
					// Property pReal
					DefaultValue_BasicTypes_A_pReal.SetName("pReal");
					DefaultValue_BasicTypes_A_pReal.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_BasicTypes_A_pReal.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
						// LiteralReal LiteralReal10
						DefaultValue_BasicTypes_A_pReal_LiteralReal10.SetName("LiteralReal10");
						DefaultValue_BasicTypes_A_pReal_LiteralReal10.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_A_pReal_LiteralReal10.SetValue(4.0f);
					DefaultValue_BasicTypes_A_pReal.SetDefaultValue(DefaultValue_BasicTypes_A_pReal_LiteralReal10);
				DefaultValue_BasicTypes_A.AddOwnedAttribute(DefaultValue_BasicTypes_A_pReal);
					// Property pEnum
					DefaultValue_BasicTypes_A_pEnum.SetName("pEnum");
					DefaultValue_BasicTypes_A_pEnum.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_BasicTypes_A_pEnum.SetType(DefaultValue_BasicTypes_E);
						// InstanceValue InstanceValue11
						DefaultValue_BasicTypes_A_pEnum_InstanceValue11.SetName("InstanceValue11");
						DefaultValue_BasicTypes_A_pEnum_InstanceValue11.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_A_pEnum_InstanceValue11.SetType(DefaultValue_BasicTypes_E);
						DefaultValue_BasicTypes_A_pEnum_InstanceValue11.SetInstance(DefaultValue_BasicTypes_E_e2);
					DefaultValue_BasicTypes_A_pEnum.SetDefaultValue(DefaultValue_BasicTypes_A_pEnum_InstanceValue11);
				DefaultValue_BasicTypes_A.AddOwnedAttribute(DefaultValue_BasicTypes_A_pEnum);
				
				
					// Operation A_A
					DefaultValue_BasicTypes_A_A_A.SetName("A_A");
					DefaultValue_BasicTypes_A_A_A.SetVisibility(VisibilityKind.public_);
						// Parameter result
						DefaultValue_BasicTypes_A_A_A_result.SetName("result");
						DefaultValue_BasicTypes_A_A_A_result.SetVisibility(VisibilityKind.public_);
						
						DefaultValue_BasicTypes_A_A_A_result.SetType(DefaultValue_BasicTypes_A);
						DefaultValue_BasicTypes_A_A_A_result.SetDirection(ParameterDirectionKind.return_);
					DefaultValue_BasicTypes_A_A_A.AddOwnedParameter(DefaultValue_BasicTypes_A_A_A_result);
					DefaultValue_BasicTypes_A_A_A.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				DefaultValue_BasicTypes_A.AddOwnedOperation(DefaultValue_BasicTypes_A_A_A);
			DefaultValue_BasicTypes.AddPackagedElement(DefaultValue_BasicTypes_A);
				// Activity assert_A
				DefaultValue_BasicTypes_assert_A.SetName("assert_A");
				DefaultValue_BasicTypes_assert_A.SetVisibility(VisibilityKind.public_);
				// FunctionBehavior testDefaultValues
					DefaultValue_BasicTypes_assert_A_testDefaultValues.SetName("testDefaultValues");
					DefaultValue_BasicTypes_assert_A_testDefaultValues.SetVisibility(VisibilityKind.public_);
					
						// Parameter pInteger
						DefaultValue_BasicTypes_assert_A_testDefaultValues_pInteger.SetName("pInteger");
						DefaultValue_BasicTypes_assert_A_testDefaultValues_pInteger.SetVisibility(VisibilityKind.public_);
						
						DefaultValue_BasicTypes_assert_A_testDefaultValues_pInteger.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					DefaultValue_BasicTypes_assert_A_testDefaultValues.AddOwnedParameter(DefaultValue_BasicTypes_assert_A_testDefaultValues_pInteger);
						// Parameter pString
						DefaultValue_BasicTypes_assert_A_testDefaultValues_pString.SetName("pString");
						DefaultValue_BasicTypes_assert_A_testDefaultValues_pString.SetVisibility(VisibilityKind.public_);
						
						DefaultValue_BasicTypes_assert_A_testDefaultValues_pString.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					DefaultValue_BasicTypes_assert_A_testDefaultValues.AddOwnedParameter(DefaultValue_BasicTypes_assert_A_testDefaultValues_pString);
						// Parameter pBoolean
						DefaultValue_BasicTypes_assert_A_testDefaultValues_pBoolean.SetName("pBoolean");
						DefaultValue_BasicTypes_assert_A_testDefaultValues_pBoolean.SetVisibility(VisibilityKind.public_);
						
						DefaultValue_BasicTypes_assert_A_testDefaultValues_pBoolean.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
					DefaultValue_BasicTypes_assert_A_testDefaultValues.AddOwnedParameter(DefaultValue_BasicTypes_assert_A_testDefaultValues_pBoolean);
						// Parameter pUnlimitedNatural
						DefaultValue_BasicTypes_assert_A_testDefaultValues_pUnlimitedNatural.SetName("pUnlimitedNatural");
						DefaultValue_BasicTypes_assert_A_testDefaultValues_pUnlimitedNatural.SetVisibility(VisibilityKind.public_);
						
						DefaultValue_BasicTypes_assert_A_testDefaultValues_pUnlimitedNatural.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_UnlimitedNatural);
					DefaultValue_BasicTypes_assert_A_testDefaultValues.AddOwnedParameter(DefaultValue_BasicTypes_assert_A_testDefaultValues_pUnlimitedNatural);
						// Parameter pReal
						DefaultValue_BasicTypes_assert_A_testDefaultValues_pReal.SetName("pReal");
						DefaultValue_BasicTypes_assert_A_testDefaultValues_pReal.SetVisibility(VisibilityKind.public_);
						
						DefaultValue_BasicTypes_assert_A_testDefaultValues_pReal.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
					DefaultValue_BasicTypes_assert_A_testDefaultValues.AddOwnedParameter(DefaultValue_BasicTypes_assert_A_testDefaultValues_pReal);
						// Parameter pEnum
						DefaultValue_BasicTypes_assert_A_testDefaultValues_pEnum.SetName("pEnum");
						DefaultValue_BasicTypes_assert_A_testDefaultValues_pEnum.SetVisibility(VisibilityKind.public_);
						
						DefaultValue_BasicTypes_assert_A_testDefaultValues_pEnum.SetType(DefaultValue_BasicTypes_E);
					DefaultValue_BasicTypes_assert_A_testDefaultValues.AddOwnedParameter(DefaultValue_BasicTypes_assert_A_testDefaultValues_pEnum);
					DefaultValue_BasicTypes_assert_A_testDefaultValues.AddLanguage("C#");
					DefaultValue_BasicTypes_assert_A_testDefaultValues.AddLanguage("Using");
					DefaultValue_BasicTypes_assert_A_testDefaultValues.AddBody("Console.WriteLine(\"Asserting a.pInteger == 4\");	 	// Test parameter pInteger 	int pInteger = ((IntegerValue)inputParameters.ElementAt(0).values.ElementAt(0)).value; 	Debug.Println(\"[doBody] argument pInteger = \" + pInteger); 	Console.WriteLine(\"a.pInteger == \" + pInteger); 	if(pInteger == 4) 	{ 		Console.ForegroundColor = ConsoleColor.Green; 		Console.WriteLine(\"Assertion successful.\"); 	} 	else 	{ 		Console.ForegroundColor = ConsoleColor.Red; 		Console.WriteLine(\"Assertion failed!\"); 	} 	Console.ResetColor();   	Console.WriteLine(\"Asserting a.pString == 'Hello'\"); 	// Test parameter pString 	string pString = ((StringValue)inputParameters.ElementAt(1).values.ElementAt(0)).value; 	Debug.Println(\"[doBody] argument \" + inputParameters.ElementAt(1).parameter!.name +  \" = \" + pString); 	Console.WriteLine(\"a.pString == \" + pString); 	if(pString == \"Hello\") 	{ 		Console.ForegroundColor = ConsoleColor.Green; 		Console.WriteLine(\"Assertion successful.\"); 	} 	else 	{ 		Console.ForegroundColor = ConsoleColor.Red; 		Console.WriteLine(\"Assertion failed!\"); 	} 	Console.ResetColor();  	Console.WriteLine(\"Asserting a.pBoolean == true\"); 	// Test parameter pBoolean 	bool pBoolean = ((BooleanValue)inputParameters.ElementAt(2).values.ElementAt(0)).value; 	Debug.Println(\"[doBody] argument \" + inputParameters.ElementAt(2).parameter!.name +  \" = \" + pBoolean); 	Console.WriteLine(\"a.pBoolean == \" + pBoolean); 	if(pBoolean) 	{ 		Console.ForegroundColor = ConsoleColor.Green; 		Console.WriteLine(\"Assertion successful.\"); 	} 	else 	{ 		Console.ForegroundColor = ConsoleColor.Red; 		Console.WriteLine(\"Assertion failed!\"); 	} 	Console.ResetColor();  	Console.WriteLine(\"Asserting a.pUnlimitedNatural == *\"); 	// Test parameter pUnlimitedNatural 	UnlimitedNatural pUnlimitedNatural = ((UnlimitedNaturalValue)inputParameters.ElementAt(3).values.ElementAt(0)).value; 	Debug.Println(\"[doBody] argument \" + inputParameters.ElementAt(3).parameter!.name +  \" = \" + pUnlimitedNatural.ToString()); 	Console.WriteLine(\"a.pUnlimitedNatural == \" + pUnlimitedNatural.ToString()); 	if(pUnlimitedNatural.naturalValue == -1) 	{ 		Console.ForegroundColor = ConsoleColor.Green; 		Console.WriteLine(\"Assertion successful.\"); 	} 	else 	{ 		Console.ForegroundColor = ConsoleColor.Red; 		Console.WriteLine(\"Assertion failed!\"); 	} 	Console.ResetColor();  	Console.WriteLine(\"Asserting a.pReal == 4.0\"); 	// Test parameter pReal 	float pReal = ((RealValue)inputParameters.ElementAt(4).values.ElementAt(0)).value; 	Debug.Println(\"[doBody] argument \" + inputParameters.ElementAt(4).parameter!.name +  \" = \" + pReal); 	Console.WriteLine(\"a.pReal == \" + pReal.ToString()); 	if(pReal == 4.0) 	{ 		Console.ForegroundColor = ConsoleColor.Green; 		Console.WriteLine(\"Assertion successful.\"); 	} 	else 	{ 		Console.ForegroundColor = ConsoleColor.Red; 		Console.WriteLine(\"Assertion failed!\"); 	} 	Console.ResetColor();  	Console.WriteLine(\"Asserting a.pEnum == E::e2\"); 	// Test parameter pEnum 	EnumerationLiteral pEnum = ((EnumerationValue)inputParameters.ElementAt(5).values.ElementAt(0)).literal!; 	Debug.Println(\"[doBody] argument \" + inputParameters.ElementAt(5).parameter!.name +  \" = \" + pEnum.qualifiedName); 	Console.WriteLine(\"a.pEnum == \" + pEnum.qualifiedName); 	if(pEnum == DefaultValue_BasicTypesModel.Instance().DefaultValue_BasicTypes_E_e2) 	{ 		Console.ForegroundColor = ConsoleColor.Green; 		Console.WriteLine(\"Assertion successful.\"); 	} 	else 	{ 		Console.ForegroundColor = ConsoleColor.Red; 		Console.WriteLine(\"Assertion failed!\"); 	}");
					DefaultValue_BasicTypes_assert_A_testDefaultValues.AddBody("using fuml.semantics.simpleclassifiers; using uml.classification; using uml.simpleclassifiers; using UMLPrimitiveTypes;");
				DefaultValue_BasicTypes_assert_A.AddOwnedBehavior(DefaultValue_BasicTypes_assert_A_testDefaultValues);
					// Parameter a
					DefaultValue_BasicTypes_assert_A_a.SetName("a");
					DefaultValue_BasicTypes_assert_A_a.SetVisibility(VisibilityKind.public_);
				DefaultValue_BasicTypes_assert_A.AddOwnedParameter(DefaultValue_BasicTypes_assert_A_a);
					// CallBehaviorAction Test Default Values
					DefaultValue_BasicTypes_assert_A_Test_Default_Values.SetName("Test Default Values");
					DefaultValue_BasicTypes_assert_A_Test_Default_Values.SetVisibility(VisibilityKind.public_);
					DefaultValue_BasicTypes_assert_A_Test_Default_Values.SetBehavior(DefaultValue_BasicTypes_assert_A_testDefaultValues);
						// InputPin pInteger
						DefaultValue_BasicTypes_assert_A_Test_Default_Values_pInteger.SetName("pInteger");
						DefaultValue_BasicTypes_assert_A_Test_Default_Values_pInteger.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_assert_A_Test_Default_Values_pInteger.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					DefaultValue_BasicTypes_assert_A_Test_Default_Values.AddArgument(DefaultValue_BasicTypes_assert_A_Test_Default_Values_pInteger);
						// InputPin pString
						DefaultValue_BasicTypes_assert_A_Test_Default_Values_pString.SetName("pString");
						DefaultValue_BasicTypes_assert_A_Test_Default_Values_pString.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_assert_A_Test_Default_Values_pString.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					DefaultValue_BasicTypes_assert_A_Test_Default_Values.AddArgument(DefaultValue_BasicTypes_assert_A_Test_Default_Values_pString);
						// InputPin pBoolean
						DefaultValue_BasicTypes_assert_A_Test_Default_Values_pBoolean.SetName("pBoolean");
						DefaultValue_BasicTypes_assert_A_Test_Default_Values_pBoolean.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_assert_A_Test_Default_Values_pBoolean.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
					DefaultValue_BasicTypes_assert_A_Test_Default_Values.AddArgument(DefaultValue_BasicTypes_assert_A_Test_Default_Values_pBoolean);
						// InputPin pUnlimitedNatural
						DefaultValue_BasicTypes_assert_A_Test_Default_Values_pUnlimitedNatural.SetName("pUnlimitedNatural");
						DefaultValue_BasicTypes_assert_A_Test_Default_Values_pUnlimitedNatural.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_assert_A_Test_Default_Values_pUnlimitedNatural.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_UnlimitedNatural);
					DefaultValue_BasicTypes_assert_A_Test_Default_Values.AddArgument(DefaultValue_BasicTypes_assert_A_Test_Default_Values_pUnlimitedNatural);
						// InputPin pReal
						DefaultValue_BasicTypes_assert_A_Test_Default_Values_pReal.SetName("pReal");
						DefaultValue_BasicTypes_assert_A_Test_Default_Values_pReal.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_assert_A_Test_Default_Values_pReal.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
					DefaultValue_BasicTypes_assert_A_Test_Default_Values.AddArgument(DefaultValue_BasicTypes_assert_A_Test_Default_Values_pReal);
						// InputPin pEnum
						DefaultValue_BasicTypes_assert_A_Test_Default_Values_pEnum.SetName("pEnum");
						DefaultValue_BasicTypes_assert_A_Test_Default_Values_pEnum.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_assert_A_Test_Default_Values_pEnum.SetType(DefaultValue_BasicTypes_E);
					DefaultValue_BasicTypes_assert_A_Test_Default_Values.AddArgument(DefaultValue_BasicTypes_assert_A_Test_Default_Values_pEnum);
				DefaultValue_BasicTypes_assert_A.AddNode(DefaultValue_BasicTypes_assert_A_Test_Default_Values);
					// ReadStructuralFeatureAction Read a.pInteger
					DefaultValue_BasicTypes_assert_A_Read_a_pInteger.SetName("Read a.pInteger");
					DefaultValue_BasicTypes_assert_A_Read_a_pInteger.SetVisibility(VisibilityKind.public_);
					DefaultValue_BasicTypes_assert_A_Read_a_pInteger.SetStructuralFeature(DefaultValue_BasicTypes_A_pInteger);
						// InputPin object
						DefaultValue_BasicTypes_assert_A_Read_a_pInteger_object.SetName("object");
						DefaultValue_BasicTypes_assert_A_Read_a_pInteger_object.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_assert_A_Read_a_pInteger_object.SetType(DefaultValue_BasicTypes_A);
					DefaultValue_BasicTypes_assert_A_Read_a_pInteger.SetObject(DefaultValue_BasicTypes_assert_A_Read_a_pInteger_object);
						// OutputPin result
						DefaultValue_BasicTypes_assert_A_Read_a_pInteger_result.SetName("result");
						DefaultValue_BasicTypes_assert_A_Read_a_pInteger_result.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_assert_A_Read_a_pInteger_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					DefaultValue_BasicTypes_assert_A_Read_a_pInteger.SetResult(DefaultValue_BasicTypes_assert_A_Read_a_pInteger_result);
				DefaultValue_BasicTypes_assert_A.AddNode(DefaultValue_BasicTypes_assert_A_Read_a_pInteger);
					// ActivityParameterNode a_node
					DefaultValue_BasicTypes_assert_A_a_node.SetName("a_node");
					DefaultValue_BasicTypes_assert_A_a_node.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_BasicTypes_assert_A_a_node.SetParameter(DefaultValue_BasicTypes_assert_A_a);
				DefaultValue_BasicTypes_assert_A.AddNode(DefaultValue_BasicTypes_assert_A_a_node);
					// ReadStructuralFeatureAction Read a.pString
					DefaultValue_BasicTypes_assert_A_Read_a_pString.SetName("Read a.pString");
					DefaultValue_BasicTypes_assert_A_Read_a_pString.SetVisibility(VisibilityKind.public_);
					DefaultValue_BasicTypes_assert_A_Read_a_pString.SetStructuralFeature(DefaultValue_BasicTypes_A_pString);
						// InputPin object
						DefaultValue_BasicTypes_assert_A_Read_a_pString_object.SetName("object");
						DefaultValue_BasicTypes_assert_A_Read_a_pString_object.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_assert_A_Read_a_pString_object.SetType(DefaultValue_BasicTypes_A);
					DefaultValue_BasicTypes_assert_A_Read_a_pString.SetObject(DefaultValue_BasicTypes_assert_A_Read_a_pString_object);
						// OutputPin result
						DefaultValue_BasicTypes_assert_A_Read_a_pString_result.SetName("result");
						DefaultValue_BasicTypes_assert_A_Read_a_pString_result.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_assert_A_Read_a_pString_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					DefaultValue_BasicTypes_assert_A_Read_a_pString.SetResult(DefaultValue_BasicTypes_assert_A_Read_a_pString_result);
				DefaultValue_BasicTypes_assert_A.AddNode(DefaultValue_BasicTypes_assert_A_Read_a_pString);
					// ReadStructuralFeatureAction Read a.pUnlimitedNatural
					DefaultValue_BasicTypes_assert_A_Read_a_pUnlimitedNatural.SetName("Read a.pUnlimitedNatural");
					DefaultValue_BasicTypes_assert_A_Read_a_pUnlimitedNatural.SetVisibility(VisibilityKind.public_);
					DefaultValue_BasicTypes_assert_A_Read_a_pUnlimitedNatural.SetStructuralFeature(DefaultValue_BasicTypes_A_pUnlimitedNatural);
						// InputPin object
						DefaultValue_BasicTypes_assert_A_Read_a_pUnlimitedNatural_object.SetName("object");
						DefaultValue_BasicTypes_assert_A_Read_a_pUnlimitedNatural_object.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_assert_A_Read_a_pUnlimitedNatural_object.SetType(DefaultValue_BasicTypes_A);
					DefaultValue_BasicTypes_assert_A_Read_a_pUnlimitedNatural.SetObject(DefaultValue_BasicTypes_assert_A_Read_a_pUnlimitedNatural_object);
						// OutputPin result
						DefaultValue_BasicTypes_assert_A_Read_a_pUnlimitedNatural_result.SetName("result");
						DefaultValue_BasicTypes_assert_A_Read_a_pUnlimitedNatural_result.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_assert_A_Read_a_pUnlimitedNatural_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_UnlimitedNatural);
					DefaultValue_BasicTypes_assert_A_Read_a_pUnlimitedNatural.SetResult(DefaultValue_BasicTypes_assert_A_Read_a_pUnlimitedNatural_result);
				DefaultValue_BasicTypes_assert_A.AddNode(DefaultValue_BasicTypes_assert_A_Read_a_pUnlimitedNatural);
					// ReadStructuralFeatureAction Read a.pBoolean
					DefaultValue_BasicTypes_assert_A_Read_a_pBoolean.SetName("Read a.pBoolean");
					DefaultValue_BasicTypes_assert_A_Read_a_pBoolean.SetVisibility(VisibilityKind.public_);
					DefaultValue_BasicTypes_assert_A_Read_a_pBoolean.SetStructuralFeature(DefaultValue_BasicTypes_A_pBoolean);
						// InputPin object
						DefaultValue_BasicTypes_assert_A_Read_a_pBoolean_object.SetName("object");
						DefaultValue_BasicTypes_assert_A_Read_a_pBoolean_object.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_assert_A_Read_a_pBoolean_object.SetType(DefaultValue_BasicTypes_A);
					DefaultValue_BasicTypes_assert_A_Read_a_pBoolean.SetObject(DefaultValue_BasicTypes_assert_A_Read_a_pBoolean_object);
						// OutputPin result
						DefaultValue_BasicTypes_assert_A_Read_a_pBoolean_result.SetName("result");
						DefaultValue_BasicTypes_assert_A_Read_a_pBoolean_result.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_assert_A_Read_a_pBoolean_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
					DefaultValue_BasicTypes_assert_A_Read_a_pBoolean.SetResult(DefaultValue_BasicTypes_assert_A_Read_a_pBoolean_result);
				DefaultValue_BasicTypes_assert_A.AddNode(DefaultValue_BasicTypes_assert_A_Read_a_pBoolean);
					// ForkNode Fork_a
					DefaultValue_BasicTypes_assert_A_Fork_a.SetName("Fork_a");
					DefaultValue_BasicTypes_assert_A_Fork_a.SetVisibility(VisibilityKind.public_);
				DefaultValue_BasicTypes_assert_A.AddNode(DefaultValue_BasicTypes_assert_A_Fork_a);
					// ReadStructuralFeatureAction Read a.pReal
					DefaultValue_BasicTypes_assert_A_Read_a_pReal.SetName("Read a.pReal");
					DefaultValue_BasicTypes_assert_A_Read_a_pReal.SetVisibility(VisibilityKind.public_);
					DefaultValue_BasicTypes_assert_A_Read_a_pReal.SetStructuralFeature(DefaultValue_BasicTypes_A_pReal);
						// InputPin object
						DefaultValue_BasicTypes_assert_A_Read_a_pReal_object.SetName("object");
						DefaultValue_BasicTypes_assert_A_Read_a_pReal_object.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_assert_A_Read_a_pReal_object.SetType(DefaultValue_BasicTypes_A);
					DefaultValue_BasicTypes_assert_A_Read_a_pReal.SetObject(DefaultValue_BasicTypes_assert_A_Read_a_pReal_object);
						// OutputPin result
						DefaultValue_BasicTypes_assert_A_Read_a_pReal_result.SetName("result");
						DefaultValue_BasicTypes_assert_A_Read_a_pReal_result.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_assert_A_Read_a_pReal_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Real);
					DefaultValue_BasicTypes_assert_A_Read_a_pReal.SetResult(DefaultValue_BasicTypes_assert_A_Read_a_pReal_result);
				DefaultValue_BasicTypes_assert_A.AddNode(DefaultValue_BasicTypes_assert_A_Read_a_pReal);
					// ReadStructuralFeatureAction Read a.pEnum
					DefaultValue_BasicTypes_assert_A_Read_a_pEnum.SetName("Read a.pEnum");
					DefaultValue_BasicTypes_assert_A_Read_a_pEnum.SetVisibility(VisibilityKind.public_);
					DefaultValue_BasicTypes_assert_A_Read_a_pEnum.SetStructuralFeature(DefaultValue_BasicTypes_A_pEnum);
						// InputPin object
						DefaultValue_BasicTypes_assert_A_Read_a_pEnum_object.SetName("object");
						DefaultValue_BasicTypes_assert_A_Read_a_pEnum_object.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_assert_A_Read_a_pEnum_object.SetType(DefaultValue_BasicTypes_A);
					DefaultValue_BasicTypes_assert_A_Read_a_pEnum.SetObject(DefaultValue_BasicTypes_assert_A_Read_a_pEnum_object);
						// OutputPin result
						DefaultValue_BasicTypes_assert_A_Read_a_pEnum_result.SetName("result");
						DefaultValue_BasicTypes_assert_A_Read_a_pEnum_result.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_assert_A_Read_a_pEnum_result.SetType(DefaultValue_BasicTypes_E);
					DefaultValue_BasicTypes_assert_A_Read_a_pEnum.SetResult(DefaultValue_BasicTypes_assert_A_Read_a_pEnum_result);
				DefaultValue_BasicTypes_assert_A.AddNode(DefaultValue_BasicTypes_assert_A_Read_a_pEnum);
					// ObjectFlow ObjectFlow15 from result to pString
					DefaultValue_BasicTypes_assert_A_ObjectFlow15.SetName("ObjectFlow15");
					DefaultValue_BasicTypes_assert_A_ObjectFlow15.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_BasicTypes_assert_A_ObjectFlow15.SetSource(DefaultValue_BasicTypes_assert_A_Read_a_pString_result);
					DefaultValue_BasicTypes_assert_A_ObjectFlow15.SetTarget(DefaultValue_BasicTypes_assert_A_Test_Default_Values_pString);
						// LiteralBoolean LiteralBoolean17
						DefaultValue_BasicTypes_assert_A_ObjectFlow15_LiteralBoolean17.SetName("LiteralBoolean17");
						DefaultValue_BasicTypes_assert_A_ObjectFlow15_LiteralBoolean17.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_assert_A_ObjectFlow15_LiteralBoolean17.SetValue(true);
					DefaultValue_BasicTypes_assert_A_ObjectFlow15.SetGuard(DefaultValue_BasicTypes_assert_A_ObjectFlow15_LiteralBoolean17);
				DefaultValue_BasicTypes_assert_A.AddEdge(DefaultValue_BasicTypes_assert_A_ObjectFlow15);
					// ObjectFlow ObjectFlow30 from Fork_a to object
					DefaultValue_BasicTypes_assert_A_ObjectFlow30.SetName("ObjectFlow30");
					DefaultValue_BasicTypes_assert_A_ObjectFlow30.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_BasicTypes_assert_A_ObjectFlow30.SetSource(DefaultValue_BasicTypes_assert_A_Fork_a);
					DefaultValue_BasicTypes_assert_A_ObjectFlow30.SetTarget(DefaultValue_BasicTypes_assert_A_Read_a_pReal_object);
						// LiteralBoolean LiteralBoolean32
						DefaultValue_BasicTypes_assert_A_ObjectFlow30_LiteralBoolean32.SetName("LiteralBoolean32");
						DefaultValue_BasicTypes_assert_A_ObjectFlow30_LiteralBoolean32.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_assert_A_ObjectFlow30_LiteralBoolean32.SetValue(true);
					DefaultValue_BasicTypes_assert_A_ObjectFlow30.SetGuard(DefaultValue_BasicTypes_assert_A_ObjectFlow30_LiteralBoolean32);
				DefaultValue_BasicTypes_assert_A.AddEdge(DefaultValue_BasicTypes_assert_A_ObjectFlow30);
					// ObjectFlow ObjectFlow33 from result to pEnum
					DefaultValue_BasicTypes_assert_A_ObjectFlow33.SetName("ObjectFlow33");
					DefaultValue_BasicTypes_assert_A_ObjectFlow33.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_BasicTypes_assert_A_ObjectFlow33.SetSource(DefaultValue_BasicTypes_assert_A_Read_a_pEnum_result);
					DefaultValue_BasicTypes_assert_A_ObjectFlow33.SetTarget(DefaultValue_BasicTypes_assert_A_Test_Default_Values_pEnum);
						// LiteralBoolean LiteralBoolean35
						DefaultValue_BasicTypes_assert_A_ObjectFlow33_LiteralBoolean35.SetName("LiteralBoolean35");
						DefaultValue_BasicTypes_assert_A_ObjectFlow33_LiteralBoolean35.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_assert_A_ObjectFlow33_LiteralBoolean35.SetValue(true);
					DefaultValue_BasicTypes_assert_A_ObjectFlow33.SetGuard(DefaultValue_BasicTypes_assert_A_ObjectFlow33_LiteralBoolean35);
				DefaultValue_BasicTypes_assert_A.AddEdge(DefaultValue_BasicTypes_assert_A_ObjectFlow33);
					// ObjectFlow ObjectFlow36 from Fork_a to object
					DefaultValue_BasicTypes_assert_A_ObjectFlow36.SetName("ObjectFlow36");
					DefaultValue_BasicTypes_assert_A_ObjectFlow36.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_BasicTypes_assert_A_ObjectFlow36.SetSource(DefaultValue_BasicTypes_assert_A_Fork_a);
					DefaultValue_BasicTypes_assert_A_ObjectFlow36.SetTarget(DefaultValue_BasicTypes_assert_A_Read_a_pBoolean_object);
						// LiteralBoolean LiteralBoolean38
						DefaultValue_BasicTypes_assert_A_ObjectFlow36_LiteralBoolean38.SetName("LiteralBoolean38");
						DefaultValue_BasicTypes_assert_A_ObjectFlow36_LiteralBoolean38.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_assert_A_ObjectFlow36_LiteralBoolean38.SetValue(true);
					DefaultValue_BasicTypes_assert_A_ObjectFlow36.SetGuard(DefaultValue_BasicTypes_assert_A_ObjectFlow36_LiteralBoolean38);
				DefaultValue_BasicTypes_assert_A.AddEdge(DefaultValue_BasicTypes_assert_A_ObjectFlow36);
					// ObjectFlow ObjectFlow46 from Fork_a to object
					DefaultValue_BasicTypes_assert_A_ObjectFlow46.SetName("ObjectFlow46");
					DefaultValue_BasicTypes_assert_A_ObjectFlow46.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_BasicTypes_assert_A_ObjectFlow46.SetSource(DefaultValue_BasicTypes_assert_A_Fork_a);
					DefaultValue_BasicTypes_assert_A_ObjectFlow46.SetTarget(DefaultValue_BasicTypes_assert_A_Read_a_pUnlimitedNatural_object);
						// LiteralBoolean LiteralBoolean47
						DefaultValue_BasicTypes_assert_A_ObjectFlow46_LiteralBoolean47.SetName("LiteralBoolean47");
						DefaultValue_BasicTypes_assert_A_ObjectFlow46_LiteralBoolean47.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_assert_A_ObjectFlow46_LiteralBoolean47.SetValue(true);
					DefaultValue_BasicTypes_assert_A_ObjectFlow46.SetGuard(DefaultValue_BasicTypes_assert_A_ObjectFlow46_LiteralBoolean47);
				DefaultValue_BasicTypes_assert_A.AddEdge(DefaultValue_BasicTypes_assert_A_ObjectFlow46);
					// ObjectFlow ObjectFlow43 from result to pReal
					DefaultValue_BasicTypes_assert_A_ObjectFlow43.SetName("ObjectFlow43");
					DefaultValue_BasicTypes_assert_A_ObjectFlow43.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_BasicTypes_assert_A_ObjectFlow43.SetSource(DefaultValue_BasicTypes_assert_A_Read_a_pReal_result);
					DefaultValue_BasicTypes_assert_A_ObjectFlow43.SetTarget(DefaultValue_BasicTypes_assert_A_Test_Default_Values_pReal);
						// LiteralBoolean LiteralBoolean44
						DefaultValue_BasicTypes_assert_A_ObjectFlow43_LiteralBoolean44.SetName("LiteralBoolean44");
						DefaultValue_BasicTypes_assert_A_ObjectFlow43_LiteralBoolean44.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_assert_A_ObjectFlow43_LiteralBoolean44.SetValue(true);
					DefaultValue_BasicTypes_assert_A_ObjectFlow43.SetGuard(DefaultValue_BasicTypes_assert_A_ObjectFlow43_LiteralBoolean44);
				DefaultValue_BasicTypes_assert_A.AddEdge(DefaultValue_BasicTypes_assert_A_ObjectFlow43);
					// ObjectFlow ObjectFlow49 from a_node to Fork_a
					DefaultValue_BasicTypes_assert_A_ObjectFlow49.SetName("ObjectFlow49");
					DefaultValue_BasicTypes_assert_A_ObjectFlow49.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_BasicTypes_assert_A_ObjectFlow49.SetSource(DefaultValue_BasicTypes_assert_A_a_node);
					DefaultValue_BasicTypes_assert_A_ObjectFlow49.SetTarget(DefaultValue_BasicTypes_assert_A_Fork_a);
						// LiteralBoolean LiteralBoolean50
						DefaultValue_BasicTypes_assert_A_ObjectFlow49_LiteralBoolean50.SetName("LiteralBoolean50");
						DefaultValue_BasicTypes_assert_A_ObjectFlow49_LiteralBoolean50.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_assert_A_ObjectFlow49_LiteralBoolean50.SetValue(true);
					DefaultValue_BasicTypes_assert_A_ObjectFlow49.SetGuard(DefaultValue_BasicTypes_assert_A_ObjectFlow49_LiteralBoolean50);
				DefaultValue_BasicTypes_assert_A.AddEdge(DefaultValue_BasicTypes_assert_A_ObjectFlow49);
					// ObjectFlow ObjectFlow56 from Fork_a to object
					DefaultValue_BasicTypes_assert_A_ObjectFlow56.SetName("ObjectFlow56");
					DefaultValue_BasicTypes_assert_A_ObjectFlow56.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_BasicTypes_assert_A_ObjectFlow56.SetSource(DefaultValue_BasicTypes_assert_A_Fork_a);
					DefaultValue_BasicTypes_assert_A_ObjectFlow56.SetTarget(DefaultValue_BasicTypes_assert_A_Read_a_pInteger_object);
						// LiteralBoolean LiteralBoolean58
						DefaultValue_BasicTypes_assert_A_ObjectFlow56_LiteralBoolean58.SetName("LiteralBoolean58");
						DefaultValue_BasicTypes_assert_A_ObjectFlow56_LiteralBoolean58.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_assert_A_ObjectFlow56_LiteralBoolean58.SetValue(true);
					DefaultValue_BasicTypes_assert_A_ObjectFlow56.SetGuard(DefaultValue_BasicTypes_assert_A_ObjectFlow56_LiteralBoolean58);
				DefaultValue_BasicTypes_assert_A.AddEdge(DefaultValue_BasicTypes_assert_A_ObjectFlow56);
					// ObjectFlow ObjectFlow63 from result to pBoolean
					DefaultValue_BasicTypes_assert_A_ObjectFlow63.SetName("ObjectFlow63");
					DefaultValue_BasicTypes_assert_A_ObjectFlow63.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_BasicTypes_assert_A_ObjectFlow63.SetSource(DefaultValue_BasicTypes_assert_A_Read_a_pBoolean_result);
					DefaultValue_BasicTypes_assert_A_ObjectFlow63.SetTarget(DefaultValue_BasicTypes_assert_A_Test_Default_Values_pBoolean);
						// LiteralBoolean LiteralBoolean64
						DefaultValue_BasicTypes_assert_A_ObjectFlow63_LiteralBoolean64.SetName("LiteralBoolean64");
						DefaultValue_BasicTypes_assert_A_ObjectFlow63_LiteralBoolean64.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_assert_A_ObjectFlow63_LiteralBoolean64.SetValue(true);
					DefaultValue_BasicTypes_assert_A_ObjectFlow63.SetGuard(DefaultValue_BasicTypes_assert_A_ObjectFlow63_LiteralBoolean64);
				DefaultValue_BasicTypes_assert_A.AddEdge(DefaultValue_BasicTypes_assert_A_ObjectFlow63);
					// ObjectFlow ObjectFlow66 from result to pInteger
					DefaultValue_BasicTypes_assert_A_ObjectFlow66.SetName("ObjectFlow66");
					DefaultValue_BasicTypes_assert_A_ObjectFlow66.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_BasicTypes_assert_A_ObjectFlow66.SetSource(DefaultValue_BasicTypes_assert_A_Read_a_pInteger_result);
					DefaultValue_BasicTypes_assert_A_ObjectFlow66.SetTarget(DefaultValue_BasicTypes_assert_A_Test_Default_Values_pInteger);
						// LiteralBoolean LiteralBoolean67
						DefaultValue_BasicTypes_assert_A_ObjectFlow66_LiteralBoolean67.SetName("LiteralBoolean67");
						DefaultValue_BasicTypes_assert_A_ObjectFlow66_LiteralBoolean67.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_assert_A_ObjectFlow66_LiteralBoolean67.SetValue(true);
					DefaultValue_BasicTypes_assert_A_ObjectFlow66.SetGuard(DefaultValue_BasicTypes_assert_A_ObjectFlow66_LiteralBoolean67);
				DefaultValue_BasicTypes_assert_A.AddEdge(DefaultValue_BasicTypes_assert_A_ObjectFlow66);
					// ObjectFlow ObjectFlow73 from result to pUnlimitedNatural
					DefaultValue_BasicTypes_assert_A_ObjectFlow73.SetName("ObjectFlow73");
					DefaultValue_BasicTypes_assert_A_ObjectFlow73.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_BasicTypes_assert_A_ObjectFlow73.SetSource(DefaultValue_BasicTypes_assert_A_Read_a_pUnlimitedNatural_result);
					DefaultValue_BasicTypes_assert_A_ObjectFlow73.SetTarget(DefaultValue_BasicTypes_assert_A_Test_Default_Values_pUnlimitedNatural);
						// LiteralBoolean LiteralBoolean75
						DefaultValue_BasicTypes_assert_A_ObjectFlow73_LiteralBoolean75.SetName("LiteralBoolean75");
						DefaultValue_BasicTypes_assert_A_ObjectFlow73_LiteralBoolean75.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_assert_A_ObjectFlow73_LiteralBoolean75.SetValue(true);
					DefaultValue_BasicTypes_assert_A_ObjectFlow73.SetGuard(DefaultValue_BasicTypes_assert_A_ObjectFlow73_LiteralBoolean75);
				DefaultValue_BasicTypes_assert_A.AddEdge(DefaultValue_BasicTypes_assert_A_ObjectFlow73);
					// ObjectFlow ObjectFlow85 from Fork_a to object
					DefaultValue_BasicTypes_assert_A_ObjectFlow85.SetName("ObjectFlow85");
					DefaultValue_BasicTypes_assert_A_ObjectFlow85.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_BasicTypes_assert_A_ObjectFlow85.SetSource(DefaultValue_BasicTypes_assert_A_Fork_a);
					DefaultValue_BasicTypes_assert_A_ObjectFlow85.SetTarget(DefaultValue_BasicTypes_assert_A_Read_a_pEnum_object);
						// LiteralBoolean LiteralBoolean87
						DefaultValue_BasicTypes_assert_A_ObjectFlow85_LiteralBoolean87.SetName("LiteralBoolean87");
						DefaultValue_BasicTypes_assert_A_ObjectFlow85_LiteralBoolean87.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_assert_A_ObjectFlow85_LiteralBoolean87.SetValue(true);
					DefaultValue_BasicTypes_assert_A_ObjectFlow85.SetGuard(DefaultValue_BasicTypes_assert_A_ObjectFlow85_LiteralBoolean87);
				DefaultValue_BasicTypes_assert_A.AddEdge(DefaultValue_BasicTypes_assert_A_ObjectFlow85);
					// ObjectFlow ObjectFlow88 from Fork_a to object
					DefaultValue_BasicTypes_assert_A_ObjectFlow88.SetName("ObjectFlow88");
					DefaultValue_BasicTypes_assert_A_ObjectFlow88.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_BasicTypes_assert_A_ObjectFlow88.SetSource(DefaultValue_BasicTypes_assert_A_Fork_a);
					DefaultValue_BasicTypes_assert_A_ObjectFlow88.SetTarget(DefaultValue_BasicTypes_assert_A_Read_a_pString_object);
						// LiteralBoolean LiteralBoolean89
						DefaultValue_BasicTypes_assert_A_ObjectFlow88_LiteralBoolean89.SetName("LiteralBoolean89");
						DefaultValue_BasicTypes_assert_A_ObjectFlow88_LiteralBoolean89.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_assert_A_ObjectFlow88_LiteralBoolean89.SetValue(true);
					DefaultValue_BasicTypes_assert_A_ObjectFlow88.SetGuard(DefaultValue_BasicTypes_assert_A_ObjectFlow88_LiteralBoolean89);
				DefaultValue_BasicTypes_assert_A.AddEdge(DefaultValue_BasicTypes_assert_A_ObjectFlow88);
			DefaultValue_BasicTypes.AddPackagedElement(DefaultValue_BasicTypes_assert_A);
				// Activity instantiate_A
				DefaultValue_BasicTypes_instantiate_A.SetName("instantiate_A");
				DefaultValue_BasicTypes_instantiate_A.SetVisibility(VisibilityKind.public_);
				
					// Parameter a
					DefaultValue_BasicTypes_instantiate_A_a.SetName("a");
					DefaultValue_BasicTypes_instantiate_A_a.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_BasicTypes_instantiate_A_a.SetType(DefaultValue_BasicTypes_A);
					DefaultValue_BasicTypes_instantiate_A_a.SetDirection(ParameterDirectionKind.return_);
				DefaultValue_BasicTypes_instantiate_A.AddOwnedParameter(DefaultValue_BasicTypes_instantiate_A_a);
					// ActivityParameterNode a_node
					DefaultValue_BasicTypes_instantiate_A_a_node.SetName("a_node");
					DefaultValue_BasicTypes_instantiate_A_a_node.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_BasicTypes_instantiate_A_a_node.SetParameter(DefaultValue_BasicTypes_instantiate_A_a);
				DefaultValue_BasicTypes_instantiate_A.AddNode(DefaultValue_BasicTypes_instantiate_A_a_node);
					// CallOperationAction A()
					DefaultValue_BasicTypes_instantiate_A_A_.SetName("A()");
					DefaultValue_BasicTypes_instantiate_A_A_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						DefaultValue_BasicTypes_instantiate_A_A__result.SetName("result");
						DefaultValue_BasicTypes_instantiate_A_A__result.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_instantiate_A_A__result.SetType(DefaultValue_BasicTypes_A);
					DefaultValue_BasicTypes_instantiate_A_A_.AddResult(DefaultValue_BasicTypes_instantiate_A_A__result);
					DefaultValue_BasicTypes_instantiate_A_A_.SetOperation(DefaultValue_BasicTypes_A_A_A);
						// InputPin target
						DefaultValue_BasicTypes_instantiate_A_A__target.SetName("target");
						DefaultValue_BasicTypes_instantiate_A_A__target.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_instantiate_A_A__target.SetType(DefaultValue_BasicTypes_A);
					DefaultValue_BasicTypes_instantiate_A_A_.SetTarget(DefaultValue_BasicTypes_instantiate_A_A__target);
				DefaultValue_BasicTypes_instantiate_A.AddNode(DefaultValue_BasicTypes_instantiate_A_A_);
					// CreateObjectAction Create_A
					DefaultValue_BasicTypes_instantiate_A_Create_A.SetName("Create_A");
					DefaultValue_BasicTypes_instantiate_A_Create_A.SetVisibility(VisibilityKind.public_);
					DefaultValue_BasicTypes_instantiate_A_Create_A.SetClassifier(DefaultValue_BasicTypes_A);
						// OutputPin result
						DefaultValue_BasicTypes_instantiate_A_Create_A_result.SetName("result");
						DefaultValue_BasicTypes_instantiate_A_Create_A_result.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_instantiate_A_Create_A_result.SetType(DefaultValue_BasicTypes_A);
					DefaultValue_BasicTypes_instantiate_A_Create_A.SetResult(DefaultValue_BasicTypes_instantiate_A_Create_A_result);
				DefaultValue_BasicTypes_instantiate_A.AddNode(DefaultValue_BasicTypes_instantiate_A_Create_A);
					// ObjectFlow ObjectFlow99 from result to a_node
					DefaultValue_BasicTypes_instantiate_A_ObjectFlow99.SetName("ObjectFlow99");
					DefaultValue_BasicTypes_instantiate_A_ObjectFlow99.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_BasicTypes_instantiate_A_ObjectFlow99.SetSource(DefaultValue_BasicTypes_instantiate_A_A__result);
					DefaultValue_BasicTypes_instantiate_A_ObjectFlow99.SetTarget(DefaultValue_BasicTypes_instantiate_A_a_node);
						// LiteralBoolean LiteralBoolean101
						DefaultValue_BasicTypes_instantiate_A_ObjectFlow99_LiteralBoolean101.SetName("LiteralBoolean101");
						DefaultValue_BasicTypes_instantiate_A_ObjectFlow99_LiteralBoolean101.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_instantiate_A_ObjectFlow99_LiteralBoolean101.SetValue(true);
					DefaultValue_BasicTypes_instantiate_A_ObjectFlow99.SetGuard(DefaultValue_BasicTypes_instantiate_A_ObjectFlow99_LiteralBoolean101);
				DefaultValue_BasicTypes_instantiate_A.AddEdge(DefaultValue_BasicTypes_instantiate_A_ObjectFlow99);
					// ObjectFlow ObjectFlow102 from result to target
					DefaultValue_BasicTypes_instantiate_A_ObjectFlow102.SetName("ObjectFlow102");
					DefaultValue_BasicTypes_instantiate_A_ObjectFlow102.SetVisibility(VisibilityKind.public_);
					
					DefaultValue_BasicTypes_instantiate_A_ObjectFlow102.SetSource(DefaultValue_BasicTypes_instantiate_A_Create_A_result);
					DefaultValue_BasicTypes_instantiate_A_ObjectFlow102.SetTarget(DefaultValue_BasicTypes_instantiate_A_A__target);
						// LiteralBoolean LiteralBoolean103
						DefaultValue_BasicTypes_instantiate_A_ObjectFlow102_LiteralBoolean103.SetName("LiteralBoolean103");
						DefaultValue_BasicTypes_instantiate_A_ObjectFlow102_LiteralBoolean103.SetVisibility(VisibilityKind.public_);
						DefaultValue_BasicTypes_instantiate_A_ObjectFlow102_LiteralBoolean103.SetValue(true);
					DefaultValue_BasicTypes_instantiate_A_ObjectFlow102.SetGuard(DefaultValue_BasicTypes_instantiate_A_ObjectFlow102_LiteralBoolean103);
				DefaultValue_BasicTypes_instantiate_A.AddEdge(DefaultValue_BasicTypes_instantiate_A_ObjectFlow102);
			DefaultValue_BasicTypes.AddPackagedElement(DefaultValue_BasicTypes_instantiate_A);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // DefaultValue_BasicTypesModel
}
