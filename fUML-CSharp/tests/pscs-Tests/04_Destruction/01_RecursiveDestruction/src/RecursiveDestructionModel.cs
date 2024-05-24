/*
 * RecursiveDestructionModel.cs
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

namespace RecursiveDestruction
{
	public class RecursiveDestructionModel : InMemoryModel
	{
		private static RecursiveDestructionModel? instance;

		/*
		 * Model RecursiveDestruction
		 */
		public Package RecursiveDestruction = new();
			public Class_ RecursiveDestruction_IImpl = new();
				public InterfaceRealization RecursiveDestruction_IImpl_I_Realization = new();
			public Class_ RecursiveDestruction_B = new();
				public Port RecursiveDestruction_B_p = new();
					public LiteralInteger RecursiveDestruction_B_p_LiteralInteger0 = new();
					public LiteralUnlimitedNatural RecursiveDestruction_B_p_LiteralUnlimitedNatural1 = new();
			public Association RecursiveDestruction_R = new();
				public Property RecursiveDestruction_R_y = new();
					public LiteralInteger RecursiveDestruction_R_y_LiteralInteger2 = new();
					public LiteralUnlimitedNatural RecursiveDestruction_R_y_LiteralUnlimitedNatural3 = new();
				public Property RecursiveDestruction_R_x = new();
					public LiteralInteger RecursiveDestruction_R_x_LiteralInteger4 = new();
					public LiteralUnlimitedNatural RecursiveDestruction_R_x_LiteralUnlimitedNatural5 = new();
			public Activity RecursiveDestruction_main = new();
				public ControlFlow RecursiveDestruction_main_ControlFlow6 = new();
				public ObjectFlow RecursiveDestruction_main_ObjectFlow7 = new();
					public LiteralBoolean RecursiveDestruction_main_ObjectFlow7_LiteralBoolean8 = new();
					public LiteralInteger RecursiveDestruction_main_ObjectFlow7_LiteralInteger9 = new();
				public CreateObjectAction RecursiveDestruction_main_Create_A_Star_Pattern = new();
					public OutputPin RecursiveDestruction_main_Create_A_Star_Pattern_result = new();
						public LiteralUnlimitedNatural RecursiveDestruction_main_Create_A_Star_Pattern_result_LiteralUnlimitedNatural10 = new();
						public LiteralInteger RecursiveDestruction_main_Create_A_Star_Pattern_result_LiteralInteger11 = new();
				public OpaqueBehavior RecursiveDestruction_main_numberOfIImplInstances = new();
					public Parameter RecursiveDestruction_main_numberOfIImplInstances_iImplList = new();
						public LiteralInteger RecursiveDestruction_main_numberOfIImplInstances_iImplList_LiteralInteger12 = new();
						public LiteralUnlimitedNatural RecursiveDestruction_main_numberOfIImplInstances_iImplList_LiteralUnlimitedNatural13 = new();
				public ObjectFlow RecursiveDestruction_main_ObjectFlow14 = new();
					public LiteralInteger RecursiveDestruction_main_ObjectFlow14_LiteralInteger15 = new();
					public LiteralBoolean RecursiveDestruction_main_ObjectFlow14_LiteralBoolean16 = new();
				public ReadExtentAction RecursiveDestruction_main_Extent_of_IImpl_after_destruction = new();
					public OutputPin RecursiveDestruction_main_Extent_of_IImpl_after_destruction_iImplExtent = new();
				public CallBehaviorAction RecursiveDestruction_main_Call_numberOfCInstances = new();
					public InputPin RecursiveDestruction_main_Call_numberOfCInstances_cList = new();
						public LiteralInteger RecursiveDestruction_main_Call_numberOfCInstances_cList_LiteralInteger17 = new();
						public LiteralUnlimitedNatural RecursiveDestruction_main_Call_numberOfCInstances_cList_LiteralUnlimitedNatural18 = new();
						public LiteralInteger RecursiveDestruction_main_Call_numberOfCInstances_cList_LiteralInteger19 = new();
				public ObjectFlow RecursiveDestruction_main_ObjectFlow20 = new();
					public LiteralInteger RecursiveDestruction_main_ObjectFlow20_LiteralInteger21 = new();
					public LiteralBoolean RecursiveDestruction_main_ObjectFlow20_LiteralBoolean22 = new();
				public ObjectFlow RecursiveDestruction_main_ObjectFlow23 = new();
					public LiteralBoolean RecursiveDestruction_main_ObjectFlow23_LiteralBoolean24 = new();
					public LiteralInteger RecursiveDestruction_main_ObjectFlow23_LiteralInteger25 = new();
				public ObjectFlow RecursiveDestruction_main_ObjectFlow26 = new();
					public LiteralBoolean RecursiveDestruction_main_ObjectFlow26_LiteralBoolean27 = new();
					public LiteralInteger RecursiveDestruction_main_ObjectFlow26_LiteralInteger28 = new();
				public CallBehaviorAction RecursiveDestruction_main_Call_assertExtentOfC = new();
					public InputPin RecursiveDestruction_main_Call_assertExtentOfC_cList = new();
						public LiteralInteger RecursiveDestruction_main_Call_assertExtentOfC_cList_LiteralInteger29 = new();
						public LiteralInteger RecursiveDestruction_main_Call_assertExtentOfC_cList_LiteralInteger30 = new();
						public LiteralUnlimitedNatural RecursiveDestruction_main_Call_assertExtentOfC_cList_LiteralUnlimitedNatural31 = new();
				public OpaqueBehavior RecursiveDestruction_main_assertExtentOfIImpl = new();
					public Parameter RecursiveDestruction_main_assertExtentOfIImpl_iImplList = new();
						public LiteralUnlimitedNatural RecursiveDestruction_main_assertExtentOfIImpl_iImplList_LiteralUnlimitedNatural32 = new();
						public LiteralInteger RecursiveDestruction_main_assertExtentOfIImpl_iImplList_LiteralInteger33 = new();
				public ObjectFlow RecursiveDestruction_main_ObjectFlow34 = new();
					public LiteralBoolean RecursiveDestruction_main_ObjectFlow34_LiteralBoolean35 = new();
					public LiteralInteger RecursiveDestruction_main_ObjectFlow34_LiteralInteger36 = new();
				public ControlFlow RecursiveDestruction_main_ControlFlow37 = new();
				public ControlFlow RecursiveDestruction_main_ControlFlow38 = new();
				public ControlFlow RecursiveDestruction_main_ControlFlow39 = new();
				public OpaqueBehavior RecursiveDestruction_main_numberOfCInstances = new();
					public Parameter RecursiveDestruction_main_numberOfCInstances_cList = new();
						public LiteralInteger RecursiveDestruction_main_numberOfCInstances_cList_LiteralInteger40 = new();
						public LiteralUnlimitedNatural RecursiveDestruction_main_numberOfCInstances_cList_LiteralUnlimitedNatural41 = new();
				public OpaqueBehavior RecursiveDestruction_main_assertExtentOfB = new();
					public Parameter RecursiveDestruction_main_assertExtentOfB_bList = new();
						public LiteralInteger RecursiveDestruction_main_assertExtentOfB_bList_LiteralInteger42 = new();
						public LiteralUnlimitedNatural RecursiveDestruction_main_assertExtentOfB_bList_LiteralUnlimitedNatural43 = new();
				public ReadExtentAction RecursiveDestruction_main_Extent_of_B_before_destruction = new();
					public OutputPin RecursiveDestruction_main_Extent_of_B_before_destruction_bExtent = new();
				public ReadExtentAction RecursiveDestruction_main_Extent_of_C_before_destruction = new();
					public OutputPin RecursiveDestruction_main_Extent_of_C_before_destruction_cExtent = new();
				public ReadExtentAction RecursiveDestruction_main_Extent_of_IImpl_before_destruction = new();
					public OutputPin RecursiveDestruction_main_Extent_of_IImpl_before_destruction_iImplExtent = new();
				public DestroyObjectAction RecursiveDestruction_main_Destroy_A_Star_Pattern = new();
					public InputPin RecursiveDestruction_main_Destroy_A_Star_Pattern_target = new();
				public CallBehaviorAction RecursiveDestruction_main_Call_numberOfIImplInstances = new();
					public InputPin RecursiveDestruction_main_Call_numberOfIImplInstances_iImplList = new();
						public LiteralUnlimitedNatural RecursiveDestruction_main_Call_numberOfIImplInstances_iImplList_LiteralUnlimitedNatural44 = new();
						public LiteralInteger RecursiveDestruction_main_Call_numberOfIImplInstances_iImplList_LiteralInteger45 = new();
						public LiteralInteger RecursiveDestruction_main_Call_numberOfIImplInstances_iImplList_LiteralInteger46 = new();
				public CallOperationAction RecursiveDestruction_main_A_Star_Pattern_ = new();
					public InputPin RecursiveDestruction_main_A_Star_Pattern__target = new();
						public LiteralUnlimitedNatural RecursiveDestruction_main_A_Star_Pattern__target_LiteralUnlimitedNatural47 = new();
						public LiteralInteger RecursiveDestruction_main_A_Star_Pattern__target_LiteralInteger48 = new();
					public OutputPin RecursiveDestruction_main_A_Star_Pattern__result = new();
						public LiteralUnlimitedNatural RecursiveDestruction_main_A_Star_Pattern__result_LiteralUnlimitedNatural49 = new();
						public LiteralInteger RecursiveDestruction_main_A_Star_Pattern__result_LiteralInteger50 = new();
						public LiteralInteger RecursiveDestruction_main_A_Star_Pattern__result_LiteralInteger51 = new();
				public ControlFlow RecursiveDestruction_main_ControlFlow52 = new();
				public ObjectFlow RecursiveDestruction_main_ObjectFlow53 = new();
					public LiteralInteger RecursiveDestruction_main_ObjectFlow53_LiteralInteger54 = new();
					public LiteralBoolean RecursiveDestruction_main_ObjectFlow53_LiteralBoolean55 = new();
				public ObjectFlow RecursiveDestruction_main_ObjectFlow56 = new();
					public LiteralInteger RecursiveDestruction_main_ObjectFlow56_LiteralInteger57 = new();
					public LiteralBoolean RecursiveDestruction_main_ObjectFlow56_LiteralBoolean58 = new();
				public CallBehaviorAction RecursiveDestruction_main_Call_numberOfBInstances = new();
					public InputPin RecursiveDestruction_main_Call_numberOfBInstances_bList = new();
						public LiteralInteger RecursiveDestruction_main_Call_numberOfBInstances_bList_LiteralInteger59 = new();
						public LiteralUnlimitedNatural RecursiveDestruction_main_Call_numberOfBInstances_bList_LiteralUnlimitedNatural60 = new();
						public LiteralInteger RecursiveDestruction_main_Call_numberOfBInstances_bList_LiteralInteger61 = new();
				public OpaqueBehavior RecursiveDestruction_main_numberOfBInstances = new();
					public Parameter RecursiveDestruction_main_numberOfBInstances_bList = new();
						public LiteralInteger RecursiveDestruction_main_numberOfBInstances_bList_LiteralInteger62 = new();
						public LiteralUnlimitedNatural RecursiveDestruction_main_numberOfBInstances_bList_LiteralUnlimitedNatural63 = new();
				public ReadExtentAction RecursiveDestruction_main_Extent_of_B_after_destruction = new();
					public OutputPin RecursiveDestruction_main_Extent_of_B_after_destruction_bExtent = new();
				public ControlFlow RecursiveDestruction_main_ControlFlow64 = new();
				public ControlFlow RecursiveDestruction_main_ControlFlow65 = new();
				public ReadExtentAction RecursiveDestruction_main_Extent_of_C_after_destruction = new();
					public OutputPin RecursiveDestruction_main_Extent_of_C_after_destruction_cExtent = new();
				public CallBehaviorAction RecursiveDestruction_main_Call_assertExtentOfIImpl = new();
					public InputPin RecursiveDestruction_main_Call_assertExtentOfIImpl_iImplList = new();
						public LiteralUnlimitedNatural RecursiveDestruction_main_Call_assertExtentOfIImpl_iImplList_LiteralUnlimitedNatural66 = new();
						public LiteralInteger RecursiveDestruction_main_Call_assertExtentOfIImpl_iImplList_LiteralInteger67 = new();
						public LiteralInteger RecursiveDestruction_main_Call_assertExtentOfIImpl_iImplList_LiteralInteger68 = new();
				public OpaqueBehavior RecursiveDestruction_main_assertExtentOfC = new();
					public Parameter RecursiveDestruction_main_assertExtentOfC_cList = new();
						public LiteralUnlimitedNatural RecursiveDestruction_main_assertExtentOfC_cList_LiteralUnlimitedNatural69 = new();
						public LiteralInteger RecursiveDestruction_main_assertExtentOfC_cList_LiteralInteger70 = new();
				public CallBehaviorAction RecursiveDestruction_main_Call_assertExtentOfB = new();
					public InputPin RecursiveDestruction_main_Call_assertExtentOfB_bList = new();
						public LiteralInteger RecursiveDestruction_main_Call_assertExtentOfB_bList_LiteralInteger71 = new();
						public LiteralInteger RecursiveDestruction_main_Call_assertExtentOfB_bList_LiteralInteger72 = new();
						public LiteralUnlimitedNatural RecursiveDestruction_main_Call_assertExtentOfB_bList_LiteralUnlimitedNatural73 = new();
			public Class_ RecursiveDestruction_A_Star_Pattern = new();
				public Comment RecursiveDestruction_A_Star_Pattern_Comment74 = new();
				public Property RecursiveDestruction_A_Star_Pattern_partB = new();
					public LiteralUnlimitedNatural RecursiveDestruction_A_Star_Pattern_partB_LiteralUnlimitedNatural75 = new();
					public LiteralInteger RecursiveDestruction_A_Star_Pattern_partB_LiteralInteger76 = new();
				public Property RecursiveDestruction_A_Star_Pattern_partC = new();
					public LiteralUnlimitedNatural RecursiveDestruction_A_Star_Pattern_partC_LiteralUnlimitedNatural77 = new();
					public LiteralInteger RecursiveDestruction_A_Star_Pattern_partC_LiteralInteger78 = new();
				public Operation RecursiveDestruction_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern = new();
					public Parameter RecursiveDestruction_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result = new();
				public Connector RecursiveDestruction_A_Star_Pattern_r = new();
					public ConnectorEnd RecursiveDestruction_A_Star_Pattern_r_ConnectorEnd79 = new();
						public LiteralInteger RecursiveDestruction_A_Star_Pattern_r_ConnectorEnd79_connectorEnd_2_Lower = new();
						public LiteralUnlimitedNatural RecursiveDestruction_A_Star_Pattern_r_ConnectorEnd79_connectorEnd_2_Upper = new();
					public ConnectorEnd RecursiveDestruction_A_Star_Pattern_r_ConnectorEnd80 = new();
						public LiteralInteger RecursiveDestruction_A_Star_Pattern_r_ConnectorEnd80_connectorEnd_1_Lower = new();
						public LiteralUnlimitedNatural RecursiveDestruction_A_Star_Pattern_r_ConnectorEnd80_connectorEnd_1_Upper = new();
			public Class_ RecursiveDestruction_C = new();
				public Port RecursiveDestruction_C_q = new();
					public LiteralInteger RecursiveDestruction_C_q_LiteralInteger81 = new();
					public LiteralUnlimitedNatural RecursiveDestruction_C_q_LiteralUnlimitedNatural82 = new();
			public Interface RecursiveDestruction_I = new();

		public static RecursiveDestructionModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public RecursiveDestructionModel()
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
			 * Model RecursiveDestruction
			 */
			AddToElementRepository("RecursiveDestruction", RecursiveDestruction);
				AddToElementRepository("IImpl", RecursiveDestruction_IImpl);
					AddToElementRepository("I_Realization", RecursiveDestruction_IImpl_I_Realization);
				AddToElementRepository("B", RecursiveDestruction_B);
					AddToElementRepository("p", RecursiveDestruction_B_p);
						AddToElementRepository("LiteralInteger0", RecursiveDestruction_B_p_LiteralInteger0);
						AddToElementRepository("LiteralUnlimitedNatural1", RecursiveDestruction_B_p_LiteralUnlimitedNatural1);
				AddToElementRepository("R", RecursiveDestruction_R);
					AddToElementRepository("y", RecursiveDestruction_R_y);
						AddToElementRepository("LiteralInteger2", RecursiveDestruction_R_y_LiteralInteger2);
						AddToElementRepository("LiteralUnlimitedNatural3", RecursiveDestruction_R_y_LiteralUnlimitedNatural3);
					AddToElementRepository("x", RecursiveDestruction_R_x);
						AddToElementRepository("LiteralInteger4", RecursiveDestruction_R_x_LiteralInteger4);
						AddToElementRepository("LiteralUnlimitedNatural5", RecursiveDestruction_R_x_LiteralUnlimitedNatural5);
				AddToElementRepository("main", RecursiveDestruction_main);
					AddToElementRepository("ControlFlow6", RecursiveDestruction_main_ControlFlow6);
					AddToElementRepository("ObjectFlow7", RecursiveDestruction_main_ObjectFlow7);
						AddToElementRepository("LiteralBoolean8", RecursiveDestruction_main_ObjectFlow7_LiteralBoolean8);
						AddToElementRepository("LiteralInteger9", RecursiveDestruction_main_ObjectFlow7_LiteralInteger9);
					AddToElementRepository("Create A_Star_Pattern", RecursiveDestruction_main_Create_A_Star_Pattern);
						AddToElementRepository("result", RecursiveDestruction_main_Create_A_Star_Pattern_result);
							AddToElementRepository("LiteralUnlimitedNatural10", RecursiveDestruction_main_Create_A_Star_Pattern_result_LiteralUnlimitedNatural10);
							AddToElementRepository("LiteralInteger11", RecursiveDestruction_main_Create_A_Star_Pattern_result_LiteralInteger11);
					AddToElementRepository("numberOfIImplInstances", RecursiveDestruction_main_numberOfIImplInstances);
						AddToElementRepository("iImplList", RecursiveDestruction_main_numberOfIImplInstances_iImplList);
							AddToElementRepository("LiteralInteger12", RecursiveDestruction_main_numberOfIImplInstances_iImplList_LiteralInteger12);
							AddToElementRepository("LiteralUnlimitedNatural13", RecursiveDestruction_main_numberOfIImplInstances_iImplList_LiteralUnlimitedNatural13);
					AddToElementRepository("ObjectFlow14", RecursiveDestruction_main_ObjectFlow14);
						AddToElementRepository("LiteralInteger15", RecursiveDestruction_main_ObjectFlow14_LiteralInteger15);
						AddToElementRepository("LiteralBoolean16", RecursiveDestruction_main_ObjectFlow14_LiteralBoolean16);
					AddToElementRepository("Extent of IImpl after destruction", RecursiveDestruction_main_Extent_of_IImpl_after_destruction);
						AddToElementRepository("iImplExtent", RecursiveDestruction_main_Extent_of_IImpl_after_destruction_iImplExtent);
					AddToElementRepository("Call numberOfCInstances", RecursiveDestruction_main_Call_numberOfCInstances);
						AddToElementRepository("cList", RecursiveDestruction_main_Call_numberOfCInstances_cList);
							AddToElementRepository("LiteralInteger17", RecursiveDestruction_main_Call_numberOfCInstances_cList_LiteralInteger17);
							AddToElementRepository("LiteralUnlimitedNatural18", RecursiveDestruction_main_Call_numberOfCInstances_cList_LiteralUnlimitedNatural18);
							AddToElementRepository("LiteralInteger19", RecursiveDestruction_main_Call_numberOfCInstances_cList_LiteralInteger19);
					AddToElementRepository("ObjectFlow20", RecursiveDestruction_main_ObjectFlow20);
						AddToElementRepository("LiteralInteger21", RecursiveDestruction_main_ObjectFlow20_LiteralInteger21);
						AddToElementRepository("LiteralBoolean22", RecursiveDestruction_main_ObjectFlow20_LiteralBoolean22);
					AddToElementRepository("ObjectFlow23", RecursiveDestruction_main_ObjectFlow23);
						AddToElementRepository("LiteralBoolean24", RecursiveDestruction_main_ObjectFlow23_LiteralBoolean24);
						AddToElementRepository("LiteralInteger25", RecursiveDestruction_main_ObjectFlow23_LiteralInteger25);
					AddToElementRepository("ObjectFlow26", RecursiveDestruction_main_ObjectFlow26);
						AddToElementRepository("LiteralBoolean27", RecursiveDestruction_main_ObjectFlow26_LiteralBoolean27);
						AddToElementRepository("LiteralInteger28", RecursiveDestruction_main_ObjectFlow26_LiteralInteger28);
					AddToElementRepository("Call assertExtentOfC", RecursiveDestruction_main_Call_assertExtentOfC);
						AddToElementRepository("cList", RecursiveDestruction_main_Call_assertExtentOfC_cList);
							AddToElementRepository("LiteralInteger29", RecursiveDestruction_main_Call_assertExtentOfC_cList_LiteralInteger29);
							AddToElementRepository("LiteralInteger30", RecursiveDestruction_main_Call_assertExtentOfC_cList_LiteralInteger30);
							AddToElementRepository("LiteralUnlimitedNatural31", RecursiveDestruction_main_Call_assertExtentOfC_cList_LiteralUnlimitedNatural31);
					AddToElementRepository("assertExtentOfIImpl", RecursiveDestruction_main_assertExtentOfIImpl);
						AddToElementRepository("iImplList", RecursiveDestruction_main_assertExtentOfIImpl_iImplList);
							AddToElementRepository("LiteralUnlimitedNatural32", RecursiveDestruction_main_assertExtentOfIImpl_iImplList_LiteralUnlimitedNatural32);
							AddToElementRepository("LiteralInteger33", RecursiveDestruction_main_assertExtentOfIImpl_iImplList_LiteralInteger33);
					AddToElementRepository("ObjectFlow34", RecursiveDestruction_main_ObjectFlow34);
						AddToElementRepository("LiteralBoolean35", RecursiveDestruction_main_ObjectFlow34_LiteralBoolean35);
						AddToElementRepository("LiteralInteger36", RecursiveDestruction_main_ObjectFlow34_LiteralInteger36);
					AddToElementRepository("ControlFlow37", RecursiveDestruction_main_ControlFlow37);
					AddToElementRepository("ControlFlow38", RecursiveDestruction_main_ControlFlow38);
					AddToElementRepository("ControlFlow39", RecursiveDestruction_main_ControlFlow39);
					AddToElementRepository("numberOfCInstances", RecursiveDestruction_main_numberOfCInstances);
						AddToElementRepository("cList", RecursiveDestruction_main_numberOfCInstances_cList);
							AddToElementRepository("LiteralInteger40", RecursiveDestruction_main_numberOfCInstances_cList_LiteralInteger40);
							AddToElementRepository("LiteralUnlimitedNatural41", RecursiveDestruction_main_numberOfCInstances_cList_LiteralUnlimitedNatural41);
					AddToElementRepository("assertExtentOfB", RecursiveDestruction_main_assertExtentOfB);
						AddToElementRepository("bList", RecursiveDestruction_main_assertExtentOfB_bList);
							AddToElementRepository("LiteralInteger42", RecursiveDestruction_main_assertExtentOfB_bList_LiteralInteger42);
							AddToElementRepository("LiteralUnlimitedNatural43", RecursiveDestruction_main_assertExtentOfB_bList_LiteralUnlimitedNatural43);
					AddToElementRepository("Extent of B before destruction", RecursiveDestruction_main_Extent_of_B_before_destruction);
						AddToElementRepository("bExtent", RecursiveDestruction_main_Extent_of_B_before_destruction_bExtent);
					AddToElementRepository("Extent of C before destruction", RecursiveDestruction_main_Extent_of_C_before_destruction);
						AddToElementRepository("cExtent", RecursiveDestruction_main_Extent_of_C_before_destruction_cExtent);
					AddToElementRepository("Extent of IImpl before destruction", RecursiveDestruction_main_Extent_of_IImpl_before_destruction);
						AddToElementRepository("iImplExtent", RecursiveDestruction_main_Extent_of_IImpl_before_destruction_iImplExtent);
					AddToElementRepository("Destroy A_Star_Pattern", RecursiveDestruction_main_Destroy_A_Star_Pattern);
						AddToElementRepository("target", RecursiveDestruction_main_Destroy_A_Star_Pattern_target);
					AddToElementRepository("Call numberOfIImplInstances", RecursiveDestruction_main_Call_numberOfIImplInstances);
						AddToElementRepository("iImplList", RecursiveDestruction_main_Call_numberOfIImplInstances_iImplList);
							AddToElementRepository("LiteralUnlimitedNatural44", RecursiveDestruction_main_Call_numberOfIImplInstances_iImplList_LiteralUnlimitedNatural44);
							AddToElementRepository("LiteralInteger45", RecursiveDestruction_main_Call_numberOfIImplInstances_iImplList_LiteralInteger45);
							AddToElementRepository("LiteralInteger46", RecursiveDestruction_main_Call_numberOfIImplInstances_iImplList_LiteralInteger46);
					AddToElementRepository("A_Star_Pattern()", RecursiveDestruction_main_A_Star_Pattern_);
						AddToElementRepository("target", RecursiveDestruction_main_A_Star_Pattern__target);
							AddToElementRepository("LiteralUnlimitedNatural47", RecursiveDestruction_main_A_Star_Pattern__target_LiteralUnlimitedNatural47);
							AddToElementRepository("LiteralInteger48", RecursiveDestruction_main_A_Star_Pattern__target_LiteralInteger48);
						AddToElementRepository("result", RecursiveDestruction_main_A_Star_Pattern__result);
							AddToElementRepository("LiteralUnlimitedNatural49", RecursiveDestruction_main_A_Star_Pattern__result_LiteralUnlimitedNatural49);
							AddToElementRepository("LiteralInteger50", RecursiveDestruction_main_A_Star_Pattern__result_LiteralInteger50);
							AddToElementRepository("LiteralInteger51", RecursiveDestruction_main_A_Star_Pattern__result_LiteralInteger51);
					AddToElementRepository("ControlFlow52", RecursiveDestruction_main_ControlFlow52);
					AddToElementRepository("ObjectFlow53", RecursiveDestruction_main_ObjectFlow53);
						AddToElementRepository("LiteralInteger54", RecursiveDestruction_main_ObjectFlow53_LiteralInteger54);
						AddToElementRepository("LiteralBoolean55", RecursiveDestruction_main_ObjectFlow53_LiteralBoolean55);
					AddToElementRepository("ObjectFlow56", RecursiveDestruction_main_ObjectFlow56);
						AddToElementRepository("LiteralInteger57", RecursiveDestruction_main_ObjectFlow56_LiteralInteger57);
						AddToElementRepository("LiteralBoolean58", RecursiveDestruction_main_ObjectFlow56_LiteralBoolean58);
					AddToElementRepository("Call numberOfBInstances", RecursiveDestruction_main_Call_numberOfBInstances);
						AddToElementRepository("bList", RecursiveDestruction_main_Call_numberOfBInstances_bList);
							AddToElementRepository("LiteralInteger59", RecursiveDestruction_main_Call_numberOfBInstances_bList_LiteralInteger59);
							AddToElementRepository("LiteralUnlimitedNatural60", RecursiveDestruction_main_Call_numberOfBInstances_bList_LiteralUnlimitedNatural60);
							AddToElementRepository("LiteralInteger61", RecursiveDestruction_main_Call_numberOfBInstances_bList_LiteralInteger61);
					AddToElementRepository("numberOfBInstances", RecursiveDestruction_main_numberOfBInstances);
						AddToElementRepository("bList", RecursiveDestruction_main_numberOfBInstances_bList);
							AddToElementRepository("LiteralInteger62", RecursiveDestruction_main_numberOfBInstances_bList_LiteralInteger62);
							AddToElementRepository("LiteralUnlimitedNatural63", RecursiveDestruction_main_numberOfBInstances_bList_LiteralUnlimitedNatural63);
					AddToElementRepository("Extent of B after destruction", RecursiveDestruction_main_Extent_of_B_after_destruction);
						AddToElementRepository("bExtent", RecursiveDestruction_main_Extent_of_B_after_destruction_bExtent);
					AddToElementRepository("ControlFlow64", RecursiveDestruction_main_ControlFlow64);
					AddToElementRepository("ControlFlow65", RecursiveDestruction_main_ControlFlow65);
					AddToElementRepository("Extent of C after destruction", RecursiveDestruction_main_Extent_of_C_after_destruction);
						AddToElementRepository("cExtent", RecursiveDestruction_main_Extent_of_C_after_destruction_cExtent);
					AddToElementRepository("Call assertExtentOfIImpl", RecursiveDestruction_main_Call_assertExtentOfIImpl);
						AddToElementRepository("iImplList", RecursiveDestruction_main_Call_assertExtentOfIImpl_iImplList);
							AddToElementRepository("LiteralUnlimitedNatural66", RecursiveDestruction_main_Call_assertExtentOfIImpl_iImplList_LiteralUnlimitedNatural66);
							AddToElementRepository("LiteralInteger67", RecursiveDestruction_main_Call_assertExtentOfIImpl_iImplList_LiteralInteger67);
							AddToElementRepository("LiteralInteger68", RecursiveDestruction_main_Call_assertExtentOfIImpl_iImplList_LiteralInteger68);
					AddToElementRepository("assertExtentOfC", RecursiveDestruction_main_assertExtentOfC);
						AddToElementRepository("cList", RecursiveDestruction_main_assertExtentOfC_cList);
							AddToElementRepository("LiteralUnlimitedNatural69", RecursiveDestruction_main_assertExtentOfC_cList_LiteralUnlimitedNatural69);
							AddToElementRepository("LiteralInteger70", RecursiveDestruction_main_assertExtentOfC_cList_LiteralInteger70);
					AddToElementRepository("Call assertExtentOfB", RecursiveDestruction_main_Call_assertExtentOfB);
						AddToElementRepository("bList", RecursiveDestruction_main_Call_assertExtentOfB_bList);
							AddToElementRepository("LiteralInteger71", RecursiveDestruction_main_Call_assertExtentOfB_bList_LiteralInteger71);
							AddToElementRepository("LiteralInteger72", RecursiveDestruction_main_Call_assertExtentOfB_bList_LiteralInteger72);
							AddToElementRepository("LiteralUnlimitedNatural73", RecursiveDestruction_main_Call_assertExtentOfB_bList_LiteralUnlimitedNatural73);
				AddToElementRepository("A_Star_Pattern", RecursiveDestruction_A_Star_Pattern);
					AddToElementRepository("Comment74", RecursiveDestruction_A_Star_Pattern_Comment74);
					AddToElementRepository("partB", RecursiveDestruction_A_Star_Pattern_partB);
						AddToElementRepository("LiteralUnlimitedNatural75", RecursiveDestruction_A_Star_Pattern_partB_LiteralUnlimitedNatural75);
						AddToElementRepository("LiteralInteger76", RecursiveDestruction_A_Star_Pattern_partB_LiteralInteger76);
					AddToElementRepository("partC", RecursiveDestruction_A_Star_Pattern_partC);
						AddToElementRepository("LiteralUnlimitedNatural77", RecursiveDestruction_A_Star_Pattern_partC_LiteralUnlimitedNatural77);
						AddToElementRepository("LiteralInteger78", RecursiveDestruction_A_Star_Pattern_partC_LiteralInteger78);
					AddToElementRepository("A_Star_Pattern_A_Star_Pattern", RecursiveDestruction_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern);
						AddToElementRepository("result", RecursiveDestruction_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result);
					AddToElementRepository("r", RecursiveDestruction_A_Star_Pattern_r);
						AddToElementRepository("ConnectorEnd79", RecursiveDestruction_A_Star_Pattern_r_ConnectorEnd79);
							AddToElementRepository("connectorEnd_2_Lower", RecursiveDestruction_A_Star_Pattern_r_ConnectorEnd79_connectorEnd_2_Lower);
							AddToElementRepository("connectorEnd_2_Upper", RecursiveDestruction_A_Star_Pattern_r_ConnectorEnd79_connectorEnd_2_Upper);
						AddToElementRepository("ConnectorEnd80", RecursiveDestruction_A_Star_Pattern_r_ConnectorEnd80);
							AddToElementRepository("connectorEnd_1_Lower", RecursiveDestruction_A_Star_Pattern_r_ConnectorEnd80_connectorEnd_1_Lower);
							AddToElementRepository("connectorEnd_1_Upper", RecursiveDestruction_A_Star_Pattern_r_ConnectorEnd80_connectorEnd_1_Upper);
				AddToElementRepository("C", RecursiveDestruction_C);
					AddToElementRepository("q", RecursiveDestruction_C_q);
						AddToElementRepository("LiteralInteger81", RecursiveDestruction_C_q_LiteralInteger81);
						AddToElementRepository("LiteralUnlimitedNatural82", RecursiveDestruction_C_q_LiteralUnlimitedNatural82);
				AddToElementRepository("I", RecursiveDestruction_I);

			// Initialize public members
			/*
			 * Model RecursiveDestruction
			 */
			RecursiveDestruction.SetName("RecursiveDestruction");
			RecursiveDestruction.SetVisibility(VisibilityKind.public_);
				// Class IImpl
				RecursiveDestruction_IImpl.SetName("IImpl");
				RecursiveDestruction_IImpl.SetVisibility(VisibilityKind.public_);
				RecursiveDestruction_IImpl_I_Realization.SetName("I_Realization");
					RecursiveDestruction_IImpl_I_Realization.SetVisibility(VisibilityKind.public_);
					RecursiveDestruction_IImpl_I_Realization.SetContract(RecursiveDestruction_I);
					
				RecursiveDestruction_IImpl.AddInterfaceRealization(RecursiveDestruction_IImpl_I_Realization);
			RecursiveDestruction.AddPackagedElement(RecursiveDestruction_IImpl);
				// Class B
				RecursiveDestruction_B.SetName("B");
				RecursiveDestruction_B.SetVisibility(VisibilityKind.public_);
				
					// Port p
					RecursiveDestruction_B_p.SetName("p");
					RecursiveDestruction_B_p.SetVisibility(VisibilityKind.public_);
					RecursiveDestruction_B_p.SetUpper(-1);
					RecursiveDestruction_B_p.SetLower(2);
					RecursiveDestruction_B_p.SetType(RecursiveDestruction_IImpl);
					RecursiveDestruction_B_p.SetAggregation(AggregationKind.composite);
					RecursiveDestruction_B_p.isService = true;
					RecursiveDestruction_B_p.AddProvided(RecursiveDestruction_I);
				RecursiveDestruction_B.AddOwnedAttribute(RecursiveDestruction_B_p);
			RecursiveDestruction.AddPackagedElement(RecursiveDestruction_B);
				// Association R
				RecursiveDestruction_R.SetName("R");
				RecursiveDestruction_R.SetVisibility(VisibilityKind.public_);
				RecursiveDestruction_R.AddOwnedEnd(RecursiveDestruction_R_x);
				RecursiveDestruction_R.AddOwnedEnd(RecursiveDestruction_R_y);
			RecursiveDestruction.AddPackagedElement(RecursiveDestruction_R);
				// Activity main
				RecursiveDestruction_main.SetName("main");
				RecursiveDestruction_main.SetVisibility(VisibilityKind.public_);
				// FunctionBehavior numberOfCInstances
					RecursiveDestruction_main_numberOfCInstances.SetName("numberOfCInstances");
					RecursiveDestruction_main_numberOfCInstances.SetVisibility(VisibilityKind.public_);
					
						// Parameter cList
						RecursiveDestruction_main_numberOfCInstances_cList.SetName("cList");
						RecursiveDestruction_main_numberOfCInstances_cList.SetVisibility(VisibilityKind.public_);
						RecursiveDestruction_main_numberOfCInstances_cList.SetUpper(-1);
						RecursiveDestruction_main_numberOfCInstances_cList.SetLower(0);
						RecursiveDestruction_main_numberOfCInstances_cList.SetType(RecursiveDestruction_C);
					RecursiveDestruction_main_numberOfCInstances.AddOwnedParameter(RecursiveDestruction_main_numberOfCInstances_cList);
					RecursiveDestruction_main_numberOfCInstances.AddLanguage("C#");
					RecursiveDestruction_main_numberOfCInstances.AddBody("Console.WriteLine(\"# Instances of C: \" + inputParameters.ElementAt(0).values.Count);");
				RecursiveDestruction_main.AddOwnedBehavior(RecursiveDestruction_main_numberOfCInstances);
					// FunctionBehavior numberOfIImplInstances
					RecursiveDestruction_main_numberOfIImplInstances.SetName("numberOfIImplInstances");
					RecursiveDestruction_main_numberOfIImplInstances.SetVisibility(VisibilityKind.public_);
					
						// Parameter iImplList
						RecursiveDestruction_main_numberOfIImplInstances_iImplList.SetName("iImplList");
						RecursiveDestruction_main_numberOfIImplInstances_iImplList.SetVisibility(VisibilityKind.public_);
						RecursiveDestruction_main_numberOfIImplInstances_iImplList.SetUpper(-1);
						RecursiveDestruction_main_numberOfIImplInstances_iImplList.SetLower(0);
						RecursiveDestruction_main_numberOfIImplInstances_iImplList.SetType(RecursiveDestruction_IImpl);
					RecursiveDestruction_main_numberOfIImplInstances.AddOwnedParameter(RecursiveDestruction_main_numberOfIImplInstances_iImplList);
					RecursiveDestruction_main_numberOfIImplInstances.AddLanguage("C#");
					RecursiveDestruction_main_numberOfIImplInstances.AddBody("Console.WriteLine(\"# Instances of IImpl: \" + inputParameters.ElementAt(0).values.Count);");
				RecursiveDestruction_main.AddOwnedBehavior(RecursiveDestruction_main_numberOfIImplInstances);
					// FunctionBehavior numberOfBInstances
					RecursiveDestruction_main_numberOfBInstances.SetName("numberOfBInstances");
					RecursiveDestruction_main_numberOfBInstances.SetVisibility(VisibilityKind.public_);
					
						// Parameter bList
						RecursiveDestruction_main_numberOfBInstances_bList.SetName("bList");
						RecursiveDestruction_main_numberOfBInstances_bList.SetVisibility(VisibilityKind.public_);
						RecursiveDestruction_main_numberOfBInstances_bList.SetUpper(-1);
						RecursiveDestruction_main_numberOfBInstances_bList.SetLower(0);
						RecursiveDestruction_main_numberOfBInstances_bList.SetType(RecursiveDestruction_B);
					RecursiveDestruction_main_numberOfBInstances.AddOwnedParameter(RecursiveDestruction_main_numberOfBInstances_bList);
					RecursiveDestruction_main_numberOfBInstances.AddLanguage("C#");
					RecursiveDestruction_main_numberOfBInstances.AddBody("Console.WriteLine(\"# Instances of B: \" + inputParameters.ElementAt(0).values.Count);");
				RecursiveDestruction_main.AddOwnedBehavior(RecursiveDestruction_main_numberOfBInstances);
					// FunctionBehavior assertExtentOfB
					RecursiveDestruction_main_assertExtentOfB.SetName("assertExtentOfB");
					RecursiveDestruction_main_assertExtentOfB.SetVisibility(VisibilityKind.public_);
					
						// Parameter bList
						RecursiveDestruction_main_assertExtentOfB_bList.SetName("bList");
						RecursiveDestruction_main_assertExtentOfB_bList.SetVisibility(VisibilityKind.public_);
						RecursiveDestruction_main_assertExtentOfB_bList.SetUpper(-1);
						RecursiveDestruction_main_assertExtentOfB_bList.SetLower(0);
						RecursiveDestruction_main_assertExtentOfB_bList.SetType(RecursiveDestruction_B);
					RecursiveDestruction_main_assertExtentOfB.AddOwnedParameter(RecursiveDestruction_main_assertExtentOfB_bList);
					RecursiveDestruction_main_assertExtentOfB.AddLanguage("C#");
					RecursiveDestruction_main_assertExtentOfB.AddBody("Console.WriteLine(\"Asserting B.allInstances()->size() == 0\");	  	int extentSize = inputParameters.ElementAt(0).values.Count; 	 	Console.WriteLine(\"B.allInstances()->size() == \" + extentSize); 	Console.Write(\"All instances of B recursively destroyed: \");  	if(extentSize == 0) 	{ 		Console.ForegroundColor = ConsoleColor.Green; 		Console.WriteLine(\"Assertion successful.\"); 	} 	else 	{ 		Console.ForegroundColor = ConsoleColor.Red; 		Console.WriteLine(\"Assertion failed!\"); 	} 	Console.ResetColor();");
				RecursiveDestruction_main.AddOwnedBehavior(RecursiveDestruction_main_assertExtentOfB);
					// FunctionBehavior assertExtentOfIImpl
					RecursiveDestruction_main_assertExtentOfIImpl.SetName("assertExtentOfIImpl");
					RecursiveDestruction_main_assertExtentOfIImpl.SetVisibility(VisibilityKind.public_);
					
						// Parameter iImplList
						RecursiveDestruction_main_assertExtentOfIImpl_iImplList.SetName("iImplList");
						RecursiveDestruction_main_assertExtentOfIImpl_iImplList.SetVisibility(VisibilityKind.public_);
						RecursiveDestruction_main_assertExtentOfIImpl_iImplList.SetUpper(-1);
						RecursiveDestruction_main_assertExtentOfIImpl_iImplList.SetLower(0);
						RecursiveDestruction_main_assertExtentOfIImpl_iImplList.SetType(RecursiveDestruction_IImpl);
					RecursiveDestruction_main_assertExtentOfIImpl.AddOwnedParameter(RecursiveDestruction_main_assertExtentOfIImpl_iImplList);
					RecursiveDestruction_main_assertExtentOfIImpl.AddLanguage("C#");
					RecursiveDestruction_main_assertExtentOfIImpl.AddBody("Console.WriteLine(\"Asserting IImpl.allInstances()->size() == 0\");	  	int extentSize = inputParameters.ElementAt(0).values.Count; 	 	Console.WriteLine(\"IImpl.allInstances()->size() == \" + extentSize); 	Console.Write(\"All instances of IImpl recursively destroyed: \");  	if(extentSize == 0) 	{ 		Console.ForegroundColor = ConsoleColor.Green; 		Console.WriteLine(\"Assertion successful.\"); 	} 	else 	{ 		Console.ForegroundColor = ConsoleColor.Red; 		Console.WriteLine(\"Assertion failed!\"); 	} 	Console.ResetColor();");
				RecursiveDestruction_main.AddOwnedBehavior(RecursiveDestruction_main_assertExtentOfIImpl);
					// FunctionBehavior assertExtentOfC
					RecursiveDestruction_main_assertExtentOfC.SetName("assertExtentOfC");
					RecursiveDestruction_main_assertExtentOfC.SetVisibility(VisibilityKind.public_);
					
						// Parameter cList
						RecursiveDestruction_main_assertExtentOfC_cList.SetName("cList");
						RecursiveDestruction_main_assertExtentOfC_cList.SetVisibility(VisibilityKind.public_);
						RecursiveDestruction_main_assertExtentOfC_cList.SetUpper(-1);
						RecursiveDestruction_main_assertExtentOfC_cList.SetLower(0);
						RecursiveDestruction_main_assertExtentOfC_cList.SetType(RecursiveDestruction_C);
					RecursiveDestruction_main_assertExtentOfC.AddOwnedParameter(RecursiveDestruction_main_assertExtentOfC_cList);
					RecursiveDestruction_main_assertExtentOfC.AddLanguage("C#");
					RecursiveDestruction_main_assertExtentOfC.AddBody("Console.WriteLine(\"Asserting C.allInstances()->size() == 0\");	  	int extentSize = inputParameters.ElementAt(0).values.Count; 	 	Console.WriteLine(\"C.allInstances()->size() == \" + extentSize); 	Console.Write(\"All instances of C recursively destroyed: \");  	if(extentSize == 0) 	{ 		Console.ForegroundColor = ConsoleColor.Green; 		Console.WriteLine(\"Assertion successful.\"); 	} 	else 	{ 		Console.ForegroundColor = ConsoleColor.Red; 		Console.WriteLine(\"Assertion failed!\"); 	} 	Console.ResetColor();");
				RecursiveDestruction_main.AddOwnedBehavior(RecursiveDestruction_main_assertExtentOfC);
					// CreateObjectAction Create A_Star_Pattern
					RecursiveDestruction_main_Create_A_Star_Pattern.SetName("Create A_Star_Pattern");
					RecursiveDestruction_main_Create_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
					RecursiveDestruction_main_Create_A_Star_Pattern.SetClassifier(RecursiveDestruction_A_Star_Pattern);
						// OutputPin result
						RecursiveDestruction_main_Create_A_Star_Pattern_result.SetName("result");
						RecursiveDestruction_main_Create_A_Star_Pattern_result.SetVisibility(VisibilityKind.public_);
						RecursiveDestruction_main_Create_A_Star_Pattern_result.SetType(RecursiveDestruction_A_Star_Pattern);
					RecursiveDestruction_main_Create_A_Star_Pattern.SetResult(RecursiveDestruction_main_Create_A_Star_Pattern_result);
				RecursiveDestruction_main.AddNode(RecursiveDestruction_main_Create_A_Star_Pattern);
					// ReadExtentAction Extent of IImpl after destruction
					RecursiveDestruction_main_Extent_of_IImpl_after_destruction.SetName("Extent of IImpl after destruction");
					RecursiveDestruction_main_Extent_of_IImpl_after_destruction.SetVisibility(VisibilityKind.public_);
					RecursiveDestruction_main_Extent_of_IImpl_after_destruction.SetClassifier(RecursiveDestruction_IImpl);
						// OutputPin iImplExtent
						RecursiveDestruction_main_Extent_of_IImpl_after_destruction_iImplExtent.SetName("iImplExtent");
						RecursiveDestruction_main_Extent_of_IImpl_after_destruction_iImplExtent.SetVisibility(VisibilityKind.public_);
						RecursiveDestruction_main_Extent_of_IImpl_after_destruction_iImplExtent.SetType(RecursiveDestruction_IImpl);
					RecursiveDestruction_main_Extent_of_IImpl_after_destruction.SetResult(RecursiveDestruction_main_Extent_of_IImpl_after_destruction_iImplExtent);
				RecursiveDestruction_main.AddNode(RecursiveDestruction_main_Extent_of_IImpl_after_destruction);
					// ReadExtentAction Extent of B before destruction
					RecursiveDestruction_main_Extent_of_B_before_destruction.SetName("Extent of B before destruction");
					RecursiveDestruction_main_Extent_of_B_before_destruction.SetVisibility(VisibilityKind.public_);
					RecursiveDestruction_main_Extent_of_B_before_destruction.SetClassifier(RecursiveDestruction_B);
						// OutputPin bExtent
						RecursiveDestruction_main_Extent_of_B_before_destruction_bExtent.SetName("bExtent");
						RecursiveDestruction_main_Extent_of_B_before_destruction_bExtent.SetVisibility(VisibilityKind.public_);
						RecursiveDestruction_main_Extent_of_B_before_destruction_bExtent.SetType(RecursiveDestruction_B);
					RecursiveDestruction_main_Extent_of_B_before_destruction.SetResult(RecursiveDestruction_main_Extent_of_B_before_destruction_bExtent);
				RecursiveDestruction_main.AddNode(RecursiveDestruction_main_Extent_of_B_before_destruction);
					// CallBehaviorAction Call numberOfCInstances
					RecursiveDestruction_main_Call_numberOfCInstances.SetName("Call numberOfCInstances");
					RecursiveDestruction_main_Call_numberOfCInstances.SetVisibility(VisibilityKind.public_);
					RecursiveDestruction_main_Call_numberOfCInstances.SetBehavior(RecursiveDestruction_main_numberOfCInstances);
						// InputPin cList
						RecursiveDestruction_main_Call_numberOfCInstances_cList.SetName("cList");
						RecursiveDestruction_main_Call_numberOfCInstances_cList.SetVisibility(VisibilityKind.public_);
						RecursiveDestruction_main_Call_numberOfCInstances_cList.SetType(RecursiveDestruction_C);
						RecursiveDestruction_main_Call_numberOfCInstances_cList.SetUpper(-1);
						RecursiveDestruction_main_Call_numberOfCInstances_cList.SetLower(0);
					RecursiveDestruction_main_Call_numberOfCInstances.AddArgument(RecursiveDestruction_main_Call_numberOfCInstances_cList);
				RecursiveDestruction_main.AddNode(RecursiveDestruction_main_Call_numberOfCInstances);
					// ReadExtentAction Extent of C before destruction
					RecursiveDestruction_main_Extent_of_C_before_destruction.SetName("Extent of C before destruction");
					RecursiveDestruction_main_Extent_of_C_before_destruction.SetVisibility(VisibilityKind.public_);
					RecursiveDestruction_main_Extent_of_C_before_destruction.SetClassifier(RecursiveDestruction_C);
						// OutputPin cExtent
						RecursiveDestruction_main_Extent_of_C_before_destruction_cExtent.SetName("cExtent");
						RecursiveDestruction_main_Extent_of_C_before_destruction_cExtent.SetVisibility(VisibilityKind.public_);
						RecursiveDestruction_main_Extent_of_C_before_destruction_cExtent.SetType(RecursiveDestruction_C);
					RecursiveDestruction_main_Extent_of_C_before_destruction.SetResult(RecursiveDestruction_main_Extent_of_C_before_destruction_cExtent);
				RecursiveDestruction_main.AddNode(RecursiveDestruction_main_Extent_of_C_before_destruction);
					// ReadExtentAction Extent of IImpl before destruction
					RecursiveDestruction_main_Extent_of_IImpl_before_destruction.SetName("Extent of IImpl before destruction");
					RecursiveDestruction_main_Extent_of_IImpl_before_destruction.SetVisibility(VisibilityKind.public_);
					RecursiveDestruction_main_Extent_of_IImpl_before_destruction.SetClassifier(RecursiveDestruction_IImpl);
						// OutputPin iImplExtent
						RecursiveDestruction_main_Extent_of_IImpl_before_destruction_iImplExtent.SetName("iImplExtent");
						RecursiveDestruction_main_Extent_of_IImpl_before_destruction_iImplExtent.SetVisibility(VisibilityKind.public_);
						RecursiveDestruction_main_Extent_of_IImpl_before_destruction_iImplExtent.SetType(RecursiveDestruction_IImpl);
					RecursiveDestruction_main_Extent_of_IImpl_before_destruction.SetResult(RecursiveDestruction_main_Extent_of_IImpl_before_destruction_iImplExtent);
				RecursiveDestruction_main.AddNode(RecursiveDestruction_main_Extent_of_IImpl_before_destruction);
					// DestroyObjectAction Destroy A_Star_Pattern
					RecursiveDestruction_main_Destroy_A_Star_Pattern.SetName("Destroy A_Star_Pattern");
					RecursiveDestruction_main_Destroy_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
					RecursiveDestruction_main_Destroy_A_Star_Pattern.SetIsDestroyLinks(true);
					RecursiveDestruction_main_Destroy_A_Star_Pattern.SetIsDestroyOwnedObjects(true);
						// InputPin target
						RecursiveDestruction_main_Destroy_A_Star_Pattern_target.SetName("target");
						RecursiveDestruction_main_Destroy_A_Star_Pattern_target.SetVisibility(VisibilityKind.public_);
						RecursiveDestruction_main_Destroy_A_Star_Pattern_target.SetType(RecursiveDestruction_A_Star_Pattern);
						RecursiveDestruction_main_Destroy_A_Star_Pattern_target.SetIsOrdered(true);
						RecursiveDestruction_main_Destroy_A_Star_Pattern_target.SetIsUnique(false);
					RecursiveDestruction_main_Destroy_A_Star_Pattern.SetTarget(RecursiveDestruction_main_Destroy_A_Star_Pattern_target);
				RecursiveDestruction_main.AddNode(RecursiveDestruction_main_Destroy_A_Star_Pattern);
					// CallBehaviorAction Call numberOfIImplInstances
					RecursiveDestruction_main_Call_numberOfIImplInstances.SetName("Call numberOfIImplInstances");
					RecursiveDestruction_main_Call_numberOfIImplInstances.SetVisibility(VisibilityKind.public_);
					RecursiveDestruction_main_Call_numberOfIImplInstances.SetBehavior(RecursiveDestruction_main_numberOfIImplInstances);
						// InputPin iImplList
						RecursiveDestruction_main_Call_numberOfIImplInstances_iImplList.SetName("iImplList");
						RecursiveDestruction_main_Call_numberOfIImplInstances_iImplList.SetVisibility(VisibilityKind.public_);
						RecursiveDestruction_main_Call_numberOfIImplInstances_iImplList.SetType(RecursiveDestruction_IImpl);
						RecursiveDestruction_main_Call_numberOfIImplInstances_iImplList.SetUpper(-1);
						RecursiveDestruction_main_Call_numberOfIImplInstances_iImplList.SetLower(0);
					RecursiveDestruction_main_Call_numberOfIImplInstances.AddArgument(RecursiveDestruction_main_Call_numberOfIImplInstances_iImplList);
				RecursiveDestruction_main.AddNode(RecursiveDestruction_main_Call_numberOfIImplInstances);
					// CallOperationAction A_Star_Pattern()
					RecursiveDestruction_main_A_Star_Pattern_.SetName("A_Star_Pattern()");
					RecursiveDestruction_main_A_Star_Pattern_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						RecursiveDestruction_main_A_Star_Pattern__result.SetName("result");
						RecursiveDestruction_main_A_Star_Pattern__result.SetVisibility(VisibilityKind.public_);
						RecursiveDestruction_main_A_Star_Pattern__result.SetType(RecursiveDestruction_A_Star_Pattern);
					RecursiveDestruction_main_A_Star_Pattern_.AddResult(RecursiveDestruction_main_A_Star_Pattern__result);
					RecursiveDestruction_main_A_Star_Pattern_.SetOperation(RecursiveDestruction_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern);
						// InputPin target
						RecursiveDestruction_main_A_Star_Pattern__target.SetName("target");
						RecursiveDestruction_main_A_Star_Pattern__target.SetVisibility(VisibilityKind.public_);
						RecursiveDestruction_main_A_Star_Pattern__target.SetType(RecursiveDestruction_A_Star_Pattern);
					RecursiveDestruction_main_A_Star_Pattern_.SetTarget(RecursiveDestruction_main_A_Star_Pattern__target);
				RecursiveDestruction_main.AddNode(RecursiveDestruction_main_A_Star_Pattern_);
					// CallBehaviorAction Call numberOfBInstances
					RecursiveDestruction_main_Call_numberOfBInstances.SetName("Call numberOfBInstances");
					RecursiveDestruction_main_Call_numberOfBInstances.SetVisibility(VisibilityKind.public_);
					RecursiveDestruction_main_Call_numberOfBInstances.SetBehavior(RecursiveDestruction_main_numberOfBInstances);
						// InputPin bList
						RecursiveDestruction_main_Call_numberOfBInstances_bList.SetName("bList");
						RecursiveDestruction_main_Call_numberOfBInstances_bList.SetVisibility(VisibilityKind.public_);
						RecursiveDestruction_main_Call_numberOfBInstances_bList.SetType(RecursiveDestruction_B);
						RecursiveDestruction_main_Call_numberOfBInstances_bList.SetUpper(-1);
						RecursiveDestruction_main_Call_numberOfBInstances_bList.SetLower(0);
					RecursiveDestruction_main_Call_numberOfBInstances.AddArgument(RecursiveDestruction_main_Call_numberOfBInstances_bList);
				RecursiveDestruction_main.AddNode(RecursiveDestruction_main_Call_numberOfBInstances);
					// ReadExtentAction Extent of B after destruction
					RecursiveDestruction_main_Extent_of_B_after_destruction.SetName("Extent of B after destruction");
					RecursiveDestruction_main_Extent_of_B_after_destruction.SetVisibility(VisibilityKind.public_);
					RecursiveDestruction_main_Extent_of_B_after_destruction.SetClassifier(RecursiveDestruction_B);
						// OutputPin bExtent
						RecursiveDestruction_main_Extent_of_B_after_destruction_bExtent.SetName("bExtent");
						RecursiveDestruction_main_Extent_of_B_after_destruction_bExtent.SetVisibility(VisibilityKind.public_);
						RecursiveDestruction_main_Extent_of_B_after_destruction_bExtent.SetType(RecursiveDestruction_B);
					RecursiveDestruction_main_Extent_of_B_after_destruction.SetResult(RecursiveDestruction_main_Extent_of_B_after_destruction_bExtent);
				RecursiveDestruction_main.AddNode(RecursiveDestruction_main_Extent_of_B_after_destruction);
					// CallBehaviorAction Call assertExtentOfC
					RecursiveDestruction_main_Call_assertExtentOfC.SetName("Call assertExtentOfC");
					RecursiveDestruction_main_Call_assertExtentOfC.SetVisibility(VisibilityKind.public_);
					RecursiveDestruction_main_Call_assertExtentOfC.SetBehavior(RecursiveDestruction_main_assertExtentOfC);
						// InputPin cList
						RecursiveDestruction_main_Call_assertExtentOfC_cList.SetName("cList");
						RecursiveDestruction_main_Call_assertExtentOfC_cList.SetVisibility(VisibilityKind.public_);
						RecursiveDestruction_main_Call_assertExtentOfC_cList.SetType(RecursiveDestruction_C);
						RecursiveDestruction_main_Call_assertExtentOfC_cList.SetUpper(-1);
						RecursiveDestruction_main_Call_assertExtentOfC_cList.SetLower(0);
					RecursiveDestruction_main_Call_assertExtentOfC.AddArgument(RecursiveDestruction_main_Call_assertExtentOfC_cList);
				RecursiveDestruction_main.AddNode(RecursiveDestruction_main_Call_assertExtentOfC);
					// ReadExtentAction Extent of C after destruction
					RecursiveDestruction_main_Extent_of_C_after_destruction.SetName("Extent of C after destruction");
					RecursiveDestruction_main_Extent_of_C_after_destruction.SetVisibility(VisibilityKind.public_);
					RecursiveDestruction_main_Extent_of_C_after_destruction.SetClassifier(RecursiveDestruction_C);
						// OutputPin cExtent
						RecursiveDestruction_main_Extent_of_C_after_destruction_cExtent.SetName("cExtent");
						RecursiveDestruction_main_Extent_of_C_after_destruction_cExtent.SetVisibility(VisibilityKind.public_);
						RecursiveDestruction_main_Extent_of_C_after_destruction_cExtent.SetType(RecursiveDestruction_C);
					RecursiveDestruction_main_Extent_of_C_after_destruction.SetResult(RecursiveDestruction_main_Extent_of_C_after_destruction_cExtent);
				RecursiveDestruction_main.AddNode(RecursiveDestruction_main_Extent_of_C_after_destruction);
					// CallBehaviorAction Call assertExtentOfIImpl
					RecursiveDestruction_main_Call_assertExtentOfIImpl.SetName("Call assertExtentOfIImpl");
					RecursiveDestruction_main_Call_assertExtentOfIImpl.SetVisibility(VisibilityKind.public_);
					RecursiveDestruction_main_Call_assertExtentOfIImpl.SetBehavior(RecursiveDestruction_main_assertExtentOfIImpl);
						// InputPin iImplList
						RecursiveDestruction_main_Call_assertExtentOfIImpl_iImplList.SetName("iImplList");
						RecursiveDestruction_main_Call_assertExtentOfIImpl_iImplList.SetVisibility(VisibilityKind.public_);
						RecursiveDestruction_main_Call_assertExtentOfIImpl_iImplList.SetType(RecursiveDestruction_IImpl);
						RecursiveDestruction_main_Call_assertExtentOfIImpl_iImplList.SetUpper(-1);
						RecursiveDestruction_main_Call_assertExtentOfIImpl_iImplList.SetLower(0);
					RecursiveDestruction_main_Call_assertExtentOfIImpl.AddArgument(RecursiveDestruction_main_Call_assertExtentOfIImpl_iImplList);
				RecursiveDestruction_main.AddNode(RecursiveDestruction_main_Call_assertExtentOfIImpl);
					// CallBehaviorAction Call assertExtentOfB
					RecursiveDestruction_main_Call_assertExtentOfB.SetName("Call assertExtentOfB");
					RecursiveDestruction_main_Call_assertExtentOfB.SetVisibility(VisibilityKind.public_);
					RecursiveDestruction_main_Call_assertExtentOfB.SetBehavior(RecursiveDestruction_main_assertExtentOfB);
						// InputPin bList
						RecursiveDestruction_main_Call_assertExtentOfB_bList.SetName("bList");
						RecursiveDestruction_main_Call_assertExtentOfB_bList.SetVisibility(VisibilityKind.public_);
						RecursiveDestruction_main_Call_assertExtentOfB_bList.SetType(RecursiveDestruction_B);
						RecursiveDestruction_main_Call_assertExtentOfB_bList.SetUpper(-1);
						RecursiveDestruction_main_Call_assertExtentOfB_bList.SetLower(0);
					RecursiveDestruction_main_Call_assertExtentOfB.AddArgument(RecursiveDestruction_main_Call_assertExtentOfB_bList);
				RecursiveDestruction_main.AddNode(RecursiveDestruction_main_Call_assertExtentOfB);
					// ControlFlow ControlFlow6 from A_Star_Pattern() to Extent of B before destruction
					RecursiveDestruction_main_ControlFlow6.SetName("ControlFlow6");
					RecursiveDestruction_main_ControlFlow6.SetVisibility(VisibilityKind.public_);
					
					RecursiveDestruction_main_ControlFlow6.SetSource(RecursiveDestruction_main_A_Star_Pattern_);
					RecursiveDestruction_main_ControlFlow6.SetTarget(RecursiveDestruction_main_Extent_of_B_before_destruction);
				RecursiveDestruction_main.AddEdge(RecursiveDestruction_main_ControlFlow6);
					// ControlFlow ControlFlow39 from Destroy A_Star_Pattern to Extent of B after destruction
					RecursiveDestruction_main_ControlFlow39.SetName("ControlFlow39");
					RecursiveDestruction_main_ControlFlow39.SetVisibility(VisibilityKind.public_);
					
					RecursiveDestruction_main_ControlFlow39.SetSource(RecursiveDestruction_main_Destroy_A_Star_Pattern);
					RecursiveDestruction_main_ControlFlow39.SetTarget(RecursiveDestruction_main_Extent_of_B_after_destruction);
				RecursiveDestruction_main.AddEdge(RecursiveDestruction_main_ControlFlow39);
					// ObjectFlow ObjectFlow7 from iImplExtent to iImplList
					RecursiveDestruction_main_ObjectFlow7.SetName("ObjectFlow7");
					RecursiveDestruction_main_ObjectFlow7.SetVisibility(VisibilityKind.public_);
					
					RecursiveDestruction_main_ObjectFlow7.SetSource(RecursiveDestruction_main_Extent_of_IImpl_after_destruction_iImplExtent);
					RecursiveDestruction_main_ObjectFlow7.SetTarget(RecursiveDestruction_main_Call_assertExtentOfIImpl_iImplList);
						// LiteralBoolean LiteralBoolean8
						RecursiveDestruction_main_ObjectFlow7_LiteralBoolean8.SetName("LiteralBoolean8");
						RecursiveDestruction_main_ObjectFlow7_LiteralBoolean8.SetVisibility(VisibilityKind.public_);
						RecursiveDestruction_main_ObjectFlow7_LiteralBoolean8.SetValue(true);
					RecursiveDestruction_main_ObjectFlow7.SetGuard(RecursiveDestruction_main_ObjectFlow7_LiteralBoolean8);
				RecursiveDestruction_main.AddEdge(RecursiveDestruction_main_ObjectFlow7);
					// ObjectFlow ObjectFlow14 from iImplExtent to iImplList
					RecursiveDestruction_main_ObjectFlow14.SetName("ObjectFlow14");
					RecursiveDestruction_main_ObjectFlow14.SetVisibility(VisibilityKind.public_);
					
					RecursiveDestruction_main_ObjectFlow14.SetSource(RecursiveDestruction_main_Extent_of_IImpl_before_destruction_iImplExtent);
					RecursiveDestruction_main_ObjectFlow14.SetTarget(RecursiveDestruction_main_Call_numberOfIImplInstances_iImplList);
						// LiteralBoolean LiteralBoolean16
						RecursiveDestruction_main_ObjectFlow14_LiteralBoolean16.SetName("LiteralBoolean16");
						RecursiveDestruction_main_ObjectFlow14_LiteralBoolean16.SetVisibility(VisibilityKind.public_);
						RecursiveDestruction_main_ObjectFlow14_LiteralBoolean16.SetValue(true);
					RecursiveDestruction_main_ObjectFlow14.SetGuard(RecursiveDestruction_main_ObjectFlow14_LiteralBoolean16);
				RecursiveDestruction_main.AddEdge(RecursiveDestruction_main_ObjectFlow14);
					// ObjectFlow ObjectFlow20 from cExtent to cList
					RecursiveDestruction_main_ObjectFlow20.SetName("ObjectFlow20");
					RecursiveDestruction_main_ObjectFlow20.SetVisibility(VisibilityKind.public_);
					
					RecursiveDestruction_main_ObjectFlow20.SetSource(RecursiveDestruction_main_Extent_of_C_before_destruction_cExtent);
					RecursiveDestruction_main_ObjectFlow20.SetTarget(RecursiveDestruction_main_Call_numberOfCInstances_cList);
						// LiteralBoolean LiteralBoolean22
						RecursiveDestruction_main_ObjectFlow20_LiteralBoolean22.SetName("LiteralBoolean22");
						RecursiveDestruction_main_ObjectFlow20_LiteralBoolean22.SetVisibility(VisibilityKind.public_);
						RecursiveDestruction_main_ObjectFlow20_LiteralBoolean22.SetValue(true);
					RecursiveDestruction_main_ObjectFlow20.SetGuard(RecursiveDestruction_main_ObjectFlow20_LiteralBoolean22);
				RecursiveDestruction_main.AddEdge(RecursiveDestruction_main_ObjectFlow20);
					// ObjectFlow ObjectFlow23 from bExtent to bList
					RecursiveDestruction_main_ObjectFlow23.SetName("ObjectFlow23");
					RecursiveDestruction_main_ObjectFlow23.SetVisibility(VisibilityKind.public_);
					
					RecursiveDestruction_main_ObjectFlow23.SetSource(RecursiveDestruction_main_Extent_of_B_after_destruction_bExtent);
					RecursiveDestruction_main_ObjectFlow23.SetTarget(RecursiveDestruction_main_Call_assertExtentOfB_bList);
						// LiteralBoolean LiteralBoolean24
						RecursiveDestruction_main_ObjectFlow23_LiteralBoolean24.SetName("LiteralBoolean24");
						RecursiveDestruction_main_ObjectFlow23_LiteralBoolean24.SetVisibility(VisibilityKind.public_);
						RecursiveDestruction_main_ObjectFlow23_LiteralBoolean24.SetValue(true);
					RecursiveDestruction_main_ObjectFlow23.SetGuard(RecursiveDestruction_main_ObjectFlow23_LiteralBoolean24);
				RecursiveDestruction_main.AddEdge(RecursiveDestruction_main_ObjectFlow23);
					// ControlFlow ControlFlow52 from Call assertExtentOfC to Extent of IImpl after destruction
					RecursiveDestruction_main_ControlFlow52.SetName("ControlFlow52");
					RecursiveDestruction_main_ControlFlow52.SetVisibility(VisibilityKind.public_);
					
					RecursiveDestruction_main_ControlFlow52.SetSource(RecursiveDestruction_main_Call_assertExtentOfC);
					RecursiveDestruction_main_ControlFlow52.SetTarget(RecursiveDestruction_main_Extent_of_IImpl_after_destruction);
				RecursiveDestruction_main.AddEdge(RecursiveDestruction_main_ControlFlow52);
					// ObjectFlow ObjectFlow26 from cExtent to cList
					RecursiveDestruction_main_ObjectFlow26.SetName("ObjectFlow26");
					RecursiveDestruction_main_ObjectFlow26.SetVisibility(VisibilityKind.public_);
					
					RecursiveDestruction_main_ObjectFlow26.SetSource(RecursiveDestruction_main_Extent_of_C_after_destruction_cExtent);
					RecursiveDestruction_main_ObjectFlow26.SetTarget(RecursiveDestruction_main_Call_assertExtentOfC_cList);
						// LiteralBoolean LiteralBoolean27
						RecursiveDestruction_main_ObjectFlow26_LiteralBoolean27.SetName("LiteralBoolean27");
						RecursiveDestruction_main_ObjectFlow26_LiteralBoolean27.SetVisibility(VisibilityKind.public_);
						RecursiveDestruction_main_ObjectFlow26_LiteralBoolean27.SetValue(true);
					RecursiveDestruction_main_ObjectFlow26.SetGuard(RecursiveDestruction_main_ObjectFlow26_LiteralBoolean27);
				RecursiveDestruction_main.AddEdge(RecursiveDestruction_main_ObjectFlow26);
					// ObjectFlow ObjectFlow53 from result to target
					RecursiveDestruction_main_ObjectFlow53.SetName("ObjectFlow53");
					RecursiveDestruction_main_ObjectFlow53.SetVisibility(VisibilityKind.public_);
					
					RecursiveDestruction_main_ObjectFlow53.SetSource(RecursiveDestruction_main_Create_A_Star_Pattern_result);
					RecursiveDestruction_main_ObjectFlow53.SetTarget(RecursiveDestruction_main_A_Star_Pattern__target);
						// LiteralBoolean LiteralBoolean55
						RecursiveDestruction_main_ObjectFlow53_LiteralBoolean55.SetName("LiteralBoolean55");
						RecursiveDestruction_main_ObjectFlow53_LiteralBoolean55.SetVisibility(VisibilityKind.public_);
						RecursiveDestruction_main_ObjectFlow53_LiteralBoolean55.SetValue(true);
					RecursiveDestruction_main_ObjectFlow53.SetGuard(RecursiveDestruction_main_ObjectFlow53_LiteralBoolean55);
				RecursiveDestruction_main.AddEdge(RecursiveDestruction_main_ObjectFlow53);
					// ObjectFlow ObjectFlow56 from bExtent to bList
					RecursiveDestruction_main_ObjectFlow56.SetName("ObjectFlow56");
					RecursiveDestruction_main_ObjectFlow56.SetVisibility(VisibilityKind.public_);
					
					RecursiveDestruction_main_ObjectFlow56.SetSource(RecursiveDestruction_main_Extent_of_B_before_destruction_bExtent);
					RecursiveDestruction_main_ObjectFlow56.SetTarget(RecursiveDestruction_main_Call_numberOfBInstances_bList);
						// LiteralBoolean LiteralBoolean58
						RecursiveDestruction_main_ObjectFlow56_LiteralBoolean58.SetName("LiteralBoolean58");
						RecursiveDestruction_main_ObjectFlow56_LiteralBoolean58.SetVisibility(VisibilityKind.public_);
						RecursiveDestruction_main_ObjectFlow56_LiteralBoolean58.SetValue(true);
					RecursiveDestruction_main_ObjectFlow56.SetGuard(RecursiveDestruction_main_ObjectFlow56_LiteralBoolean58);
				RecursiveDestruction_main.AddEdge(RecursiveDestruction_main_ObjectFlow56);
					// ObjectFlow ObjectFlow34 from result to target
					RecursiveDestruction_main_ObjectFlow34.SetName("ObjectFlow34");
					RecursiveDestruction_main_ObjectFlow34.SetVisibility(VisibilityKind.public_);
					
					RecursiveDestruction_main_ObjectFlow34.SetSource(RecursiveDestruction_main_A_Star_Pattern__result);
					RecursiveDestruction_main_ObjectFlow34.SetTarget(RecursiveDestruction_main_Destroy_A_Star_Pattern_target);
						// LiteralBoolean LiteralBoolean35
						RecursiveDestruction_main_ObjectFlow34_LiteralBoolean35.SetName("LiteralBoolean35");
						RecursiveDestruction_main_ObjectFlow34_LiteralBoolean35.SetVisibility(VisibilityKind.public_);
						RecursiveDestruction_main_ObjectFlow34_LiteralBoolean35.SetValue(true);
					RecursiveDestruction_main_ObjectFlow34.SetGuard(RecursiveDestruction_main_ObjectFlow34_LiteralBoolean35);
				RecursiveDestruction_main.AddEdge(RecursiveDestruction_main_ObjectFlow34);
					// ControlFlow ControlFlow37 from Call numberOfBInstances to Extent of C before destruction
					RecursiveDestruction_main_ControlFlow37.SetName("ControlFlow37");
					RecursiveDestruction_main_ControlFlow37.SetVisibility(VisibilityKind.public_);
					
					RecursiveDestruction_main_ControlFlow37.SetSource(RecursiveDestruction_main_Call_numberOfBInstances);
					RecursiveDestruction_main_ControlFlow37.SetTarget(RecursiveDestruction_main_Extent_of_C_before_destruction);
				RecursiveDestruction_main.AddEdge(RecursiveDestruction_main_ControlFlow37);
					// ControlFlow ControlFlow64 from Call numberOfIImplInstances to Destroy A_Star_Pattern
					RecursiveDestruction_main_ControlFlow64.SetName("ControlFlow64");
					RecursiveDestruction_main_ControlFlow64.SetVisibility(VisibilityKind.public_);
					
					RecursiveDestruction_main_ControlFlow64.SetSource(RecursiveDestruction_main_Call_numberOfIImplInstances);
					RecursiveDestruction_main_ControlFlow64.SetTarget(RecursiveDestruction_main_Destroy_A_Star_Pattern);
				RecursiveDestruction_main.AddEdge(RecursiveDestruction_main_ControlFlow64);
					// ControlFlow ControlFlow65 from Call numberOfCInstances to Extent of IImpl before destruction
					RecursiveDestruction_main_ControlFlow65.SetName("ControlFlow65");
					RecursiveDestruction_main_ControlFlow65.SetVisibility(VisibilityKind.public_);
					
					RecursiveDestruction_main_ControlFlow65.SetSource(RecursiveDestruction_main_Call_numberOfCInstances);
					RecursiveDestruction_main_ControlFlow65.SetTarget(RecursiveDestruction_main_Extent_of_IImpl_before_destruction);
				RecursiveDestruction_main.AddEdge(RecursiveDestruction_main_ControlFlow65);
					// ControlFlow ControlFlow38 from Call assertExtentOfB to Extent of C after destruction
					RecursiveDestruction_main_ControlFlow38.SetName("ControlFlow38");
					RecursiveDestruction_main_ControlFlow38.SetVisibility(VisibilityKind.public_);
					
					RecursiveDestruction_main_ControlFlow38.SetSource(RecursiveDestruction_main_Call_assertExtentOfB);
					RecursiveDestruction_main_ControlFlow38.SetTarget(RecursiveDestruction_main_Extent_of_C_after_destruction);
				RecursiveDestruction_main.AddEdge(RecursiveDestruction_main_ControlFlow38);
			RecursiveDestruction.AddPackagedElement(RecursiveDestruction_main);
				// Class A_Star_Pattern
				RecursiveDestruction_A_Star_Pattern.SetName("A_Star_Pattern");
				RecursiveDestruction_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
				
					// Property partB
					RecursiveDestruction_A_Star_Pattern_partB.SetName("partB");
					RecursiveDestruction_A_Star_Pattern_partB.SetVisibility(VisibilityKind.public_);
					RecursiveDestruction_A_Star_Pattern_partB.SetUpper(-1);
					RecursiveDestruction_A_Star_Pattern_partB.SetLower(2);
					RecursiveDestruction_A_Star_Pattern_partB.SetType(RecursiveDestruction_B);
					RecursiveDestruction_A_Star_Pattern_partB.SetAggregation(AggregationKind.composite);
				RecursiveDestruction_A_Star_Pattern.AddOwnedAttribute(RecursiveDestruction_A_Star_Pattern_partB);
					// Property partC
					RecursiveDestruction_A_Star_Pattern_partC.SetName("partC");
					RecursiveDestruction_A_Star_Pattern_partC.SetVisibility(VisibilityKind.public_);
					RecursiveDestruction_A_Star_Pattern_partC.SetUpper(-1);
					RecursiveDestruction_A_Star_Pattern_partC.SetLower(5);
					RecursiveDestruction_A_Star_Pattern_partC.SetType(RecursiveDestruction_C);
					RecursiveDestruction_A_Star_Pattern_partC.SetAggregation(AggregationKind.composite);
				RecursiveDestruction_A_Star_Pattern.AddOwnedAttribute(RecursiveDestruction_A_Star_Pattern_partC);
				
				RecursiveDestruction_A_Star_Pattern_r.SetName("r");
					RecursiveDestruction_A_Star_Pattern_r.SetVisibility(VisibilityKind.public_);
						RecursiveDestruction_A_Star_Pattern_r_ConnectorEnd80.SetUpper(-1);
						RecursiveDestruction_A_Star_Pattern_r_ConnectorEnd80.SetLower(4);
						RecursiveDestruction_A_Star_Pattern_r_ConnectorEnd80.SetRole(RecursiveDestruction_B_p);
						RecursiveDestruction_A_Star_Pattern_r_ConnectorEnd80.SetPartWithPort(RecursiveDestruction_A_Star_Pattern_partB);
						
					RecursiveDestruction_A_Star_Pattern_r.AddEnd(RecursiveDestruction_A_Star_Pattern_r_ConnectorEnd80);
						RecursiveDestruction_A_Star_Pattern_r_ConnectorEnd79.SetUpper(-1);
						RecursiveDestruction_A_Star_Pattern_r_ConnectorEnd79.SetLower(5);
						RecursiveDestruction_A_Star_Pattern_r_ConnectorEnd79.SetRole(RecursiveDestruction_C_q);
						RecursiveDestruction_A_Star_Pattern_r_ConnectorEnd79.SetPartWithPort(RecursiveDestruction_A_Star_Pattern_partC);
						
					RecursiveDestruction_A_Star_Pattern_r.AddEnd(RecursiveDestruction_A_Star_Pattern_r_ConnectorEnd79);
					RecursiveDestruction_A_Star_Pattern_r.SetType(RecursiveDestruction_R);
				RecursiveDestruction_A_Star_Pattern.AddOwnedConnector(RecursiveDestruction_A_Star_Pattern_r);
					// Operation A_Star_Pattern_A_Star_Pattern
					RecursiveDestruction_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern.SetName("A_Star_Pattern_A_Star_Pattern");
					RecursiveDestruction_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern.SetVisibility(VisibilityKind.public_);
						// Parameter result
						RecursiveDestruction_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result.SetName("result");
						RecursiveDestruction_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result.SetVisibility(VisibilityKind.public_);
						
						RecursiveDestruction_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result.SetType(RecursiveDestruction_A_Star_Pattern);
						RecursiveDestruction_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result.SetDirection(ParameterDirectionKind.return_);
					RecursiveDestruction_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern.AddOwnedParameter(RecursiveDestruction_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern_result);
					RecursiveDestruction_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				RecursiveDestruction_A_Star_Pattern.AddOwnedOperation(RecursiveDestruction_A_Star_Pattern_A_Star_Pattern_A_Star_Pattern);
			RecursiveDestruction.AddPackagedElement(RecursiveDestruction_A_Star_Pattern);
				// Class C
				RecursiveDestruction_C.SetName("C");
				RecursiveDestruction_C.SetVisibility(VisibilityKind.public_);
				
					// Port q
					RecursiveDestruction_C_q.SetName("q");
					RecursiveDestruction_C_q.SetVisibility(VisibilityKind.public_);
					RecursiveDestruction_C_q.SetUpper(-1);
					RecursiveDestruction_C_q.SetType(RecursiveDestruction_IImpl);
					RecursiveDestruction_C_q.SetAggregation(AggregationKind.composite);
					RecursiveDestruction_C_q.isService = true;
					RecursiveDestruction_C_q.AddProvided(RecursiveDestruction_I);
				RecursiveDestruction_C.AddOwnedAttribute(RecursiveDestruction_C_q);
			RecursiveDestruction.AddPackagedElement(RecursiveDestruction_C);
				// Interface I
				RecursiveDestruction_I.SetName("I");
				RecursiveDestruction_I.SetVisibility(VisibilityKind.public_);
			RecursiveDestruction.AddPackagedElement(RecursiveDestruction_I);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // RecursiveDestructionModel
}
