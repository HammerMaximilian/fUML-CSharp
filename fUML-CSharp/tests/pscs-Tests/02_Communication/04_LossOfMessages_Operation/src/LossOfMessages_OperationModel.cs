/*
 * LossOfMessages_OperationModel.cs
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

namespace LossOfMessages_Operation
{
	public class LossOfMessages_OperationModel : InMemoryModel
	{
		private static LossOfMessages_OperationModel? instance;

		/*
		 * Model LossOfMessages_Operation
		 */
		public Package LossOfMessages_Operation = new();
			public Activity LossOfMessages_Operation_main = new();
				public OpaqueBehavior LossOfMessages_Operation_main_testP = new();
					public Parameter LossOfMessages_Operation_main_testP_p = new();
				public ObjectFlow LossOfMessages_Operation_main_ObjectFlow0 = new();
					public LiteralBoolean LossOfMessages_Operation_main_ObjectFlow0_LiteralBoolean1 = new();
					public LiteralInteger LossOfMessages_Operation_main_ObjectFlow0_LiteralInteger2 = new();
				public ObjectFlow LossOfMessages_Operation_main_ObjectFlow3 = new();
					public LiteralBoolean LossOfMessages_Operation_main_ObjectFlow3_LiteralBoolean4 = new();
					public LiteralInteger LossOfMessages_Operation_main_ObjectFlow3_LiteralInteger5 = new();
				public ObjectFlow LossOfMessages_Operation_main_ObjectFlow6 = new();
					public LiteralInteger LossOfMessages_Operation_main_ObjectFlow6_LiteralInteger7 = new();
					public LiteralBoolean LossOfMessages_Operation_main_ObjectFlow6_LiteralBoolean8 = new();
				public CreateObjectAction LossOfMessages_Operation_main_Create_A = new();
					public OutputPin LossOfMessages_Operation_main_Create_A_result = new();
						public LiteralInteger LossOfMessages_Operation_main_Create_A_result_LiteralInteger9 = new();
						public LiteralUnlimitedNatural LossOfMessages_Operation_main_Create_A_result_LiteralUnlimitedNatural10 = new();
				public CallOperationAction LossOfMessages_Operation_main_Call_setP = new();
					public InputPin LossOfMessages_Operation_main_Call_setP_v = new();
						public LiteralInteger LossOfMessages_Operation_main_Call_setP_v_LiteralInteger11 = new();
						public LiteralInteger LossOfMessages_Operation_main_Call_setP_v_LiteralInteger12 = new();
						public LiteralUnlimitedNatural LossOfMessages_Operation_main_Call_setP_v_LiteralUnlimitedNatural13 = new();
					public InputPin LossOfMessages_Operation_main_Call_setP_target = new();
						public LiteralUnlimitedNatural LossOfMessages_Operation_main_Call_setP_target_LiteralUnlimitedNatural14 = new();
						public LiteralInteger LossOfMessages_Operation_main_Call_setP_target_LiteralInteger15 = new();
				public ControlFlow LossOfMessages_Operation_main_ControlFlow16 = new();
				public CallOperationAction LossOfMessages_Operation_main_A_ = new();
					public InputPin LossOfMessages_Operation_main_A__target = new();
						public LiteralUnlimitedNatural LossOfMessages_Operation_main_A__target_LiteralUnlimitedNatural17 = new();
						public LiteralInteger LossOfMessages_Operation_main_A__target_LiteralInteger18 = new();
					public OutputPin LossOfMessages_Operation_main_A__result = new();
						public LiteralInteger LossOfMessages_Operation_main_A__result_LiteralInteger19 = new();
						public LiteralUnlimitedNatural LossOfMessages_Operation_main_A__result_LiteralUnlimitedNatural20 = new();
						public LiteralInteger LossOfMessages_Operation_main_A__result_LiteralInteger21 = new();
				public ValueSpecificationAction LossOfMessages_Operation_main_Value_4 = new();
					public OutputPin LossOfMessages_Operation_main_Value_4_result = new();
						public LiteralUnlimitedNatural LossOfMessages_Operation_main_Value_4_result_LiteralUnlimitedNatural22 = new();
						public LiteralInteger LossOfMessages_Operation_main_Value_4_result_LiteralInteger23 = new();
					public LiteralInteger LossOfMessages_Operation_main_Value_4_LiteralInteger24 = new();
				public ReadStructuralFeatureAction LossOfMessages_Operation_main_Read_a_q = new();
					public InputPin LossOfMessages_Operation_main_Read_a_q_object = new();
						public LiteralUnlimitedNatural LossOfMessages_Operation_main_Read_a_q_object_LiteralUnlimitedNatural25 = new();
						public LiteralInteger LossOfMessages_Operation_main_Read_a_q_object_LiteralInteger26 = new();
					public OutputPin LossOfMessages_Operation_main_Read_a_q_result = new();
						public LiteralInteger LossOfMessages_Operation_main_Read_a_q_result_LiteralInteger27 = new();
						public LiteralUnlimitedNatural LossOfMessages_Operation_main_Read_a_q_result_LiteralUnlimitedNatural28 = new();
				public ObjectFlow LossOfMessages_Operation_main_ObjectFlow29 = new();
					public LiteralBoolean LossOfMessages_Operation_main_ObjectFlow29_LiteralBoolean30 = new();
					public LiteralInteger LossOfMessages_Operation_main_ObjectFlow29_LiteralInteger31 = new();
				public ObjectFlow LossOfMessages_Operation_main_ObjectFlow32 = new();
					public LiteralInteger LossOfMessages_Operation_main_ObjectFlow32_LiteralInteger33 = new();
					public LiteralBoolean LossOfMessages_Operation_main_ObjectFlow32_LiteralBoolean34 = new();
				public ObjectFlow LossOfMessages_Operation_main_ObjectFlow35 = new();
					public LiteralBoolean LossOfMessages_Operation_main_ObjectFlow35_LiteralBoolean36 = new();
					public LiteralInteger LossOfMessages_Operation_main_ObjectFlow35_LiteralInteger37 = new();
				public CallBehaviorAction LossOfMessages_Operation_main_Call_testP = new();
					public InputPin LossOfMessages_Operation_main_Call_testP_p = new();
						public LiteralInteger LossOfMessages_Operation_main_Call_testP_p_LiteralInteger38 = new();
						public LiteralInteger LossOfMessages_Operation_main_Call_testP_p_LiteralInteger39 = new();
						public LiteralUnlimitedNatural LossOfMessages_Operation_main_Call_testP_p_LiteralUnlimitedNatural40 = new();
				public ReadStructuralFeatureAction LossOfMessages_Operation_main_Read_a_p = new();
					public InputPin LossOfMessages_Operation_main_Read_a_p_object = new();
						public LiteralInteger LossOfMessages_Operation_main_Read_a_p_object_LiteralInteger41 = new();
						public LiteralUnlimitedNatural LossOfMessages_Operation_main_Read_a_p_object_LiteralUnlimitedNatural42 = new();
					public OutputPin LossOfMessages_Operation_main_Read_a_p_result = new();
						public LiteralUnlimitedNatural LossOfMessages_Operation_main_Read_a_p_result_LiteralUnlimitedNatural43 = new();
						public LiteralInteger LossOfMessages_Operation_main_Read_a_p_result_LiteralInteger44 = new();
				public ForkNode LossOfMessages_Operation_main_Fork_A = new();
				public ObjectFlow LossOfMessages_Operation_main_ObjectFlow45 = new();
					public LiteralInteger LossOfMessages_Operation_main_ObjectFlow45_LiteralInteger46 = new();
					public LiteralBoolean LossOfMessages_Operation_main_ObjectFlow45_LiteralBoolean47 = new();
			public Interface LossOfMessages_Operation_I = new();
				public Operation LossOfMessages_Operation_I_setP_Integer = new();
					public Parameter LossOfMessages_Operation_I_setP_Integer_v = new();
			public Class_ LossOfMessages_Operation_A = new();
				public Property LossOfMessages_Operation_A_p = new();
					public LiteralInteger LossOfMessages_Operation_A_p_LiteralInteger48 = new();
				public Activity LossOfMessages_Operation_A_setPActivity = new();
					public ObjectFlow LossOfMessages_Operation_A_setPActivity_ObjectFlow49 = new();
						public LiteralBoolean LossOfMessages_Operation_A_setPActivity_ObjectFlow49_LiteralBoolean50 = new();
						public LiteralInteger LossOfMessages_Operation_A_setPActivity_ObjectFlow49_LiteralInteger51 = new();
					public Parameter LossOfMessages_Operation_A_setPActivity_v = new();
					public ObjectFlow LossOfMessages_Operation_A_setPActivity_ObjectFlow52 = new();
						public LiteralBoolean LossOfMessages_Operation_A_setPActivity_ObjectFlow52_LiteralBoolean53 = new();
						public LiteralInteger LossOfMessages_Operation_A_setPActivity_ObjectFlow52_LiteralInteger54 = new();
					public ActivityParameterNode LossOfMessages_Operation_A_setPActivity_vParameterNode = new();
						public LiteralInteger LossOfMessages_Operation_A_setPActivity_vParameterNode_LiteralInteger55 = new();
					public ReadSelfAction LossOfMessages_Operation_A_setPActivity_this = new();
						public OutputPin LossOfMessages_Operation_A_setPActivity_this_result = new();
							public LiteralInteger LossOfMessages_Operation_A_setPActivity_this_result_LiteralInteger56 = new();
							public LiteralUnlimitedNatural LossOfMessages_Operation_A_setPActivity_this_result_LiteralUnlimitedNatural57 = new();
					public AddStructuralFeatureValueAction LossOfMessages_Operation_A_setPActivity_Set_this_p = new();
						public InputPin LossOfMessages_Operation_A_setPActivity_Set_this_p_object = new();
							public LiteralUnlimitedNatural LossOfMessages_Operation_A_setPActivity_Set_this_p_object_LiteralUnlimitedNatural58 = new();
							public LiteralInteger LossOfMessages_Operation_A_setPActivity_Set_this_p_object_LiteralInteger59 = new();
						public OutputPin LossOfMessages_Operation_A_setPActivity_Set_this_p_result = new();
							public LiteralInteger LossOfMessages_Operation_A_setPActivity_Set_this_p_result_LiteralInteger60 = new();
							public LiteralUnlimitedNatural LossOfMessages_Operation_A_setPActivity_Set_this_p_result_LiteralUnlimitedNatural61 = new();
						public InputPin LossOfMessages_Operation_A_setPActivity_Set_this_p_value = new();
							public LiteralUnlimitedNatural LossOfMessages_Operation_A_setPActivity_Set_this_p_value_LiteralUnlimitedNatural62 = new();
							public LiteralInteger LossOfMessages_Operation_A_setPActivity_Set_this_p_value_LiteralInteger63 = new();
				public Port LossOfMessages_Operation_A_q = new();
				public Operation LossOfMessages_Operation_A_setP_Integer = new();
					public Parameter LossOfMessages_Operation_A_setP_Integer_v = new();
				public InterfaceRealization LossOfMessages_Operation_A_IRealization = new();
				public Operation LossOfMessages_Operation_A_A_A = new();
					public Parameter LossOfMessages_Operation_A_A_A_result = new();
			public Class_ LossOfMessages_Operation_IImpl = new();
				public Operation LossOfMessages_Operation_IImpl_setP_Integer = new();
					public Parameter LossOfMessages_Operation_IImpl_setP_Integer_v = new();
				public InterfaceRealization LossOfMessages_Operation_IImpl_IRealization = new();

		public static LossOfMessages_OperationModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public LossOfMessages_OperationModel()
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
			 * Model LossOfMessages_Operation
			 */
			AddToElementRepository("LossOfMessages_Operation", LossOfMessages_Operation);
				AddToElementRepository("main", LossOfMessages_Operation_main);
					AddToElementRepository("testP", LossOfMessages_Operation_main_testP);
						AddToElementRepository("p", LossOfMessages_Operation_main_testP_p);
					AddToElementRepository("ObjectFlow0", LossOfMessages_Operation_main_ObjectFlow0);
						AddToElementRepository("LiteralBoolean1", LossOfMessages_Operation_main_ObjectFlow0_LiteralBoolean1);
						AddToElementRepository("LiteralInteger2", LossOfMessages_Operation_main_ObjectFlow0_LiteralInteger2);
					AddToElementRepository("ObjectFlow3", LossOfMessages_Operation_main_ObjectFlow3);
						AddToElementRepository("LiteralBoolean4", LossOfMessages_Operation_main_ObjectFlow3_LiteralBoolean4);
						AddToElementRepository("LiteralInteger5", LossOfMessages_Operation_main_ObjectFlow3_LiteralInteger5);
					AddToElementRepository("ObjectFlow6", LossOfMessages_Operation_main_ObjectFlow6);
						AddToElementRepository("LiteralInteger7", LossOfMessages_Operation_main_ObjectFlow6_LiteralInteger7);
						AddToElementRepository("LiteralBoolean8", LossOfMessages_Operation_main_ObjectFlow6_LiteralBoolean8);
					AddToElementRepository("Create A", LossOfMessages_Operation_main_Create_A);
						AddToElementRepository("result", LossOfMessages_Operation_main_Create_A_result);
							AddToElementRepository("LiteralInteger9", LossOfMessages_Operation_main_Create_A_result_LiteralInteger9);
							AddToElementRepository("LiteralUnlimitedNatural10", LossOfMessages_Operation_main_Create_A_result_LiteralUnlimitedNatural10);
					AddToElementRepository("Call setP", LossOfMessages_Operation_main_Call_setP);
						AddToElementRepository("v", LossOfMessages_Operation_main_Call_setP_v);
							AddToElementRepository("LiteralInteger11", LossOfMessages_Operation_main_Call_setP_v_LiteralInteger11);
							AddToElementRepository("LiteralInteger12", LossOfMessages_Operation_main_Call_setP_v_LiteralInteger12);
							AddToElementRepository("LiteralUnlimitedNatural13", LossOfMessages_Operation_main_Call_setP_v_LiteralUnlimitedNatural13);
						AddToElementRepository("target", LossOfMessages_Operation_main_Call_setP_target);
							AddToElementRepository("LiteralUnlimitedNatural14", LossOfMessages_Operation_main_Call_setP_target_LiteralUnlimitedNatural14);
							AddToElementRepository("LiteralInteger15", LossOfMessages_Operation_main_Call_setP_target_LiteralInteger15);
					AddToElementRepository("ControlFlow16", LossOfMessages_Operation_main_ControlFlow16);
					AddToElementRepository("A()", LossOfMessages_Operation_main_A_);
						AddToElementRepository("target", LossOfMessages_Operation_main_A__target);
							AddToElementRepository("LiteralUnlimitedNatural17", LossOfMessages_Operation_main_A__target_LiteralUnlimitedNatural17);
							AddToElementRepository("LiteralInteger18", LossOfMessages_Operation_main_A__target_LiteralInteger18);
						AddToElementRepository("result", LossOfMessages_Operation_main_A__result);
							AddToElementRepository("LiteralInteger19", LossOfMessages_Operation_main_A__result_LiteralInteger19);
							AddToElementRepository("LiteralUnlimitedNatural20", LossOfMessages_Operation_main_A__result_LiteralUnlimitedNatural20);
							AddToElementRepository("LiteralInteger21", LossOfMessages_Operation_main_A__result_LiteralInteger21);
					AddToElementRepository("Value 4", LossOfMessages_Operation_main_Value_4);
						AddToElementRepository("result", LossOfMessages_Operation_main_Value_4_result);
							AddToElementRepository("LiteralUnlimitedNatural22", LossOfMessages_Operation_main_Value_4_result_LiteralUnlimitedNatural22);
							AddToElementRepository("LiteralInteger23", LossOfMessages_Operation_main_Value_4_result_LiteralInteger23);
						AddToElementRepository("LiteralInteger24", LossOfMessages_Operation_main_Value_4_LiteralInteger24);
					AddToElementRepository("Read a.q", LossOfMessages_Operation_main_Read_a_q);
						AddToElementRepository("object", LossOfMessages_Operation_main_Read_a_q_object);
							AddToElementRepository("LiteralUnlimitedNatural25", LossOfMessages_Operation_main_Read_a_q_object_LiteralUnlimitedNatural25);
							AddToElementRepository("LiteralInteger26", LossOfMessages_Operation_main_Read_a_q_object_LiteralInteger26);
						AddToElementRepository("result", LossOfMessages_Operation_main_Read_a_q_result);
							AddToElementRepository("LiteralInteger27", LossOfMessages_Operation_main_Read_a_q_result_LiteralInteger27);
							AddToElementRepository("LiteralUnlimitedNatural28", LossOfMessages_Operation_main_Read_a_q_result_LiteralUnlimitedNatural28);
					AddToElementRepository("ObjectFlow29", LossOfMessages_Operation_main_ObjectFlow29);
						AddToElementRepository("LiteralBoolean30", LossOfMessages_Operation_main_ObjectFlow29_LiteralBoolean30);
						AddToElementRepository("LiteralInteger31", LossOfMessages_Operation_main_ObjectFlow29_LiteralInteger31);
					AddToElementRepository("ObjectFlow32", LossOfMessages_Operation_main_ObjectFlow32);
						AddToElementRepository("LiteralInteger33", LossOfMessages_Operation_main_ObjectFlow32_LiteralInteger33);
						AddToElementRepository("LiteralBoolean34", LossOfMessages_Operation_main_ObjectFlow32_LiteralBoolean34);
					AddToElementRepository("ObjectFlow35", LossOfMessages_Operation_main_ObjectFlow35);
						AddToElementRepository("LiteralBoolean36", LossOfMessages_Operation_main_ObjectFlow35_LiteralBoolean36);
						AddToElementRepository("LiteralInteger37", LossOfMessages_Operation_main_ObjectFlow35_LiteralInteger37);
					AddToElementRepository("Call testP", LossOfMessages_Operation_main_Call_testP);
						AddToElementRepository("p", LossOfMessages_Operation_main_Call_testP_p);
							AddToElementRepository("LiteralInteger38", LossOfMessages_Operation_main_Call_testP_p_LiteralInteger38);
							AddToElementRepository("LiteralInteger39", LossOfMessages_Operation_main_Call_testP_p_LiteralInteger39);
							AddToElementRepository("LiteralUnlimitedNatural40", LossOfMessages_Operation_main_Call_testP_p_LiteralUnlimitedNatural40);
					AddToElementRepository("Read a.p", LossOfMessages_Operation_main_Read_a_p);
						AddToElementRepository("object", LossOfMessages_Operation_main_Read_a_p_object);
							AddToElementRepository("LiteralInteger41", LossOfMessages_Operation_main_Read_a_p_object_LiteralInteger41);
							AddToElementRepository("LiteralUnlimitedNatural42", LossOfMessages_Operation_main_Read_a_p_object_LiteralUnlimitedNatural42);
						AddToElementRepository("result", LossOfMessages_Operation_main_Read_a_p_result);
							AddToElementRepository("LiteralUnlimitedNatural43", LossOfMessages_Operation_main_Read_a_p_result_LiteralUnlimitedNatural43);
							AddToElementRepository("LiteralInteger44", LossOfMessages_Operation_main_Read_a_p_result_LiteralInteger44);
					AddToElementRepository("Fork A", LossOfMessages_Operation_main_Fork_A);
					AddToElementRepository("ObjectFlow45", LossOfMessages_Operation_main_ObjectFlow45);
						AddToElementRepository("LiteralInteger46", LossOfMessages_Operation_main_ObjectFlow45_LiteralInteger46);
						AddToElementRepository("LiteralBoolean47", LossOfMessages_Operation_main_ObjectFlow45_LiteralBoolean47);
				AddToElementRepository("I", LossOfMessages_Operation_I);
					AddToElementRepository("setP_Integer", LossOfMessages_Operation_I_setP_Integer);
						AddToElementRepository("v", LossOfMessages_Operation_I_setP_Integer_v);
				AddToElementRepository("A", LossOfMessages_Operation_A);
					AddToElementRepository("p", LossOfMessages_Operation_A_p);
						AddToElementRepository("LiteralInteger48", LossOfMessages_Operation_A_p_LiteralInteger48);
					AddToElementRepository("setPActivity", LossOfMessages_Operation_A_setPActivity);
						AddToElementRepository("ObjectFlow49", LossOfMessages_Operation_A_setPActivity_ObjectFlow49);
							AddToElementRepository("LiteralBoolean50", LossOfMessages_Operation_A_setPActivity_ObjectFlow49_LiteralBoolean50);
							AddToElementRepository("LiteralInteger51", LossOfMessages_Operation_A_setPActivity_ObjectFlow49_LiteralInteger51);
						AddToElementRepository("v", LossOfMessages_Operation_A_setPActivity_v);
						AddToElementRepository("ObjectFlow52", LossOfMessages_Operation_A_setPActivity_ObjectFlow52);
							AddToElementRepository("LiteralBoolean53", LossOfMessages_Operation_A_setPActivity_ObjectFlow52_LiteralBoolean53);
							AddToElementRepository("LiteralInteger54", LossOfMessages_Operation_A_setPActivity_ObjectFlow52_LiteralInteger54);
						AddToElementRepository("vParameterNode", LossOfMessages_Operation_A_setPActivity_vParameterNode);
							AddToElementRepository("LiteralInteger55", LossOfMessages_Operation_A_setPActivity_vParameterNode_LiteralInteger55);
						AddToElementRepository("this", LossOfMessages_Operation_A_setPActivity_this);
							AddToElementRepository("result", LossOfMessages_Operation_A_setPActivity_this_result);
								AddToElementRepository("LiteralInteger56", LossOfMessages_Operation_A_setPActivity_this_result_LiteralInteger56);
								AddToElementRepository("LiteralUnlimitedNatural57", LossOfMessages_Operation_A_setPActivity_this_result_LiteralUnlimitedNatural57);
						AddToElementRepository("Set this.p", LossOfMessages_Operation_A_setPActivity_Set_this_p);
							AddToElementRepository("object", LossOfMessages_Operation_A_setPActivity_Set_this_p_object);
								AddToElementRepository("LiteralUnlimitedNatural58", LossOfMessages_Operation_A_setPActivity_Set_this_p_object_LiteralUnlimitedNatural58);
								AddToElementRepository("LiteralInteger59", LossOfMessages_Operation_A_setPActivity_Set_this_p_object_LiteralInteger59);
							AddToElementRepository("result", LossOfMessages_Operation_A_setPActivity_Set_this_p_result);
								AddToElementRepository("LiteralInteger60", LossOfMessages_Operation_A_setPActivity_Set_this_p_result_LiteralInteger60);
								AddToElementRepository("LiteralUnlimitedNatural61", LossOfMessages_Operation_A_setPActivity_Set_this_p_result_LiteralUnlimitedNatural61);
							AddToElementRepository("value", LossOfMessages_Operation_A_setPActivity_Set_this_p_value);
								AddToElementRepository("LiteralUnlimitedNatural62", LossOfMessages_Operation_A_setPActivity_Set_this_p_value_LiteralUnlimitedNatural62);
								AddToElementRepository("LiteralInteger63", LossOfMessages_Operation_A_setPActivity_Set_this_p_value_LiteralInteger63);
					AddToElementRepository("q", LossOfMessages_Operation_A_q);
					AddToElementRepository("setP_Integer", LossOfMessages_Operation_A_setP_Integer);
						AddToElementRepository("v", LossOfMessages_Operation_A_setP_Integer_v);
					AddToElementRepository("IRealization", LossOfMessages_Operation_A_IRealization);
					AddToElementRepository("A_A", LossOfMessages_Operation_A_A_A);
						AddToElementRepository("result", LossOfMessages_Operation_A_A_A_result);
				AddToElementRepository("IImpl", LossOfMessages_Operation_IImpl);
					AddToElementRepository("setP_Integer", LossOfMessages_Operation_IImpl_setP_Integer);
						AddToElementRepository("v", LossOfMessages_Operation_IImpl_setP_Integer_v);
					AddToElementRepository("IRealization", LossOfMessages_Operation_IImpl_IRealization);

			// Initialize public members
			/*
			 * Model LossOfMessages_Operation
			 */
			LossOfMessages_Operation.SetName("LossOfMessages_Operation");
			LossOfMessages_Operation.SetVisibility(VisibilityKind.public_);
				// Activity main
				LossOfMessages_Operation_main.SetName("main");
				LossOfMessages_Operation_main.SetVisibility(VisibilityKind.public_);
				// FunctionBehavior testP
					LossOfMessages_Operation_main_testP.SetName("testP");
					LossOfMessages_Operation_main_testP.SetVisibility(VisibilityKind.public_);
					
						// Parameter p
						LossOfMessages_Operation_main_testP_p.SetName("p");
						LossOfMessages_Operation_main_testP_p.SetVisibility(VisibilityKind.public_);
						
						LossOfMessages_Operation_main_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					LossOfMessages_Operation_main_testP.AddOwnedParameter(LossOfMessages_Operation_main_testP_p);
					LossOfMessages_Operation_main_testP.AddLanguage("C#");
					LossOfMessages_Operation_main_testP.AddLanguage("Using");
					LossOfMessages_Operation_main_testP.AddBody("Console.WriteLine(\"Asserting a.p != 4\");  	// Test parameter p 	int p = ((IntegerValue)inputParameters.ElementAt(0).values.ElementAt(0)).value; 	Debug.Println(\"[doBody] argument p = \" + p); 	 	Console.WriteLine(\"a.p == \" + p); 	Console.Write(\"Operation call lost: \");  	if(p != 4) 	{ 		Console.ForegroundColor = ConsoleColor.Green; 		Console.WriteLine(\"Assertion successful.\"); 	} 	else 	{ 		Console.ForegroundColor = ConsoleColor.Red; 		Console.WriteLine(\"Assertion failed!\"); 	}  	Console.ResetColor();");
					LossOfMessages_Operation_main_testP.AddBody("using fuml.semantics.simpleclassifiers; ");
				LossOfMessages_Operation_main.AddOwnedBehavior(LossOfMessages_Operation_main_testP);
					// CallBehaviorAction Call testP
					LossOfMessages_Operation_main_Call_testP.SetName("Call testP");
					LossOfMessages_Operation_main_Call_testP.SetVisibility(VisibilityKind.public_);
					LossOfMessages_Operation_main_Call_testP.SetBehavior(LossOfMessages_Operation_main_testP);
						// InputPin p
						LossOfMessages_Operation_main_Call_testP_p.SetName("p");
						LossOfMessages_Operation_main_Call_testP_p.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Operation_main_Call_testP_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					LossOfMessages_Operation_main_Call_testP.AddArgument(LossOfMessages_Operation_main_Call_testP_p);
				LossOfMessages_Operation_main.AddNode(LossOfMessages_Operation_main_Call_testP);
					// CreateObjectAction Create A
					LossOfMessages_Operation_main_Create_A.SetName("Create A");
					LossOfMessages_Operation_main_Create_A.SetVisibility(VisibilityKind.public_);
					LossOfMessages_Operation_main_Create_A.SetClassifier(LossOfMessages_Operation_A);
						// OutputPin result
						LossOfMessages_Operation_main_Create_A_result.SetName("result");
						LossOfMessages_Operation_main_Create_A_result.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Operation_main_Create_A_result.SetType(LossOfMessages_Operation_A);
					LossOfMessages_Operation_main_Create_A.SetResult(LossOfMessages_Operation_main_Create_A_result);
				LossOfMessages_Operation_main.AddNode(LossOfMessages_Operation_main_Create_A);
					// CallOperationAction Call setP
					LossOfMessages_Operation_main_Call_setP.SetName("Call setP");
					LossOfMessages_Operation_main_Call_setP.SetVisibility(VisibilityKind.public_);
					LossOfMessages_Operation_main_Call_setP.SetOperation(LossOfMessages_Operation_IImpl_setP_Integer);
						// InputPin target
						LossOfMessages_Operation_main_Call_setP_target.SetName("target");
						LossOfMessages_Operation_main_Call_setP_target.SetVisibility(VisibilityKind.public_);
					LossOfMessages_Operation_main_Call_setP.SetTarget(LossOfMessages_Operation_main_Call_setP_target);
						// InputPin v
						LossOfMessages_Operation_main_Call_setP_v.SetName("v");
						LossOfMessages_Operation_main_Call_setP_v.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Operation_main_Call_setP_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					LossOfMessages_Operation_main_Call_setP.AddArgument(LossOfMessages_Operation_main_Call_setP_v);
				LossOfMessages_Operation_main.AddNode(LossOfMessages_Operation_main_Call_setP);
					// ReadStructuralFeatureAction Read a.p
					LossOfMessages_Operation_main_Read_a_p.SetName("Read a.p");
					LossOfMessages_Operation_main_Read_a_p.SetVisibility(VisibilityKind.public_);
					LossOfMessages_Operation_main_Read_a_p.SetStructuralFeature(LossOfMessages_Operation_A_p);
						// InputPin object
						LossOfMessages_Operation_main_Read_a_p_object.SetName("object");
						LossOfMessages_Operation_main_Read_a_p_object.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Operation_main_Read_a_p_object.SetType(LossOfMessages_Operation_A);
					LossOfMessages_Operation_main_Read_a_p.SetObject(LossOfMessages_Operation_main_Read_a_p_object);
						// OutputPin result
						LossOfMessages_Operation_main_Read_a_p_result.SetName("result");
						LossOfMessages_Operation_main_Read_a_p_result.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Operation_main_Read_a_p_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					LossOfMessages_Operation_main_Read_a_p.SetResult(LossOfMessages_Operation_main_Read_a_p_result);
				LossOfMessages_Operation_main.AddNode(LossOfMessages_Operation_main_Read_a_p);
					// ForkNode Fork A
					LossOfMessages_Operation_main_Fork_A.SetName("Fork A");
					LossOfMessages_Operation_main_Fork_A.SetVisibility(VisibilityKind.public_);
				LossOfMessages_Operation_main.AddNode(LossOfMessages_Operation_main_Fork_A);
					// CallOperationAction A()
					LossOfMessages_Operation_main_A_.SetName("A()");
					LossOfMessages_Operation_main_A_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						LossOfMessages_Operation_main_A__result.SetName("result");
						LossOfMessages_Operation_main_A__result.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Operation_main_A__result.SetType(LossOfMessages_Operation_A);
					LossOfMessages_Operation_main_A_.AddResult(LossOfMessages_Operation_main_A__result);
					LossOfMessages_Operation_main_A_.SetOperation(LossOfMessages_Operation_A_A_A);
						// InputPin target
						LossOfMessages_Operation_main_A__target.SetName("target");
						LossOfMessages_Operation_main_A__target.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Operation_main_A__target.SetType(LossOfMessages_Operation_A);
					LossOfMessages_Operation_main_A_.SetTarget(LossOfMessages_Operation_main_A__target);
				LossOfMessages_Operation_main.AddNode(LossOfMessages_Operation_main_A_);
					// ValueSpecificationAction Value 4
					LossOfMessages_Operation_main_Value_4.SetName("Value 4");
					LossOfMessages_Operation_main_Value_4.SetVisibility(VisibilityKind.public_);
						// LiteralInteger LiteralInteger24
						LossOfMessages_Operation_main_Value_4_LiteralInteger24.SetName("LiteralInteger24");
						LossOfMessages_Operation_main_Value_4_LiteralInteger24.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Operation_main_Value_4_LiteralInteger24.SetValue(4);
					LossOfMessages_Operation_main_Value_4.SetValue(LossOfMessages_Operation_main_Value_4_LiteralInteger24);
						// OutputPin result
						LossOfMessages_Operation_main_Value_4_result.SetName("result");
						LossOfMessages_Operation_main_Value_4_result.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Operation_main_Value_4_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					LossOfMessages_Operation_main_Value_4.SetResult(LossOfMessages_Operation_main_Value_4_result);
				LossOfMessages_Operation_main.AddNode(LossOfMessages_Operation_main_Value_4);
					// ReadStructuralFeatureAction Read a.q
					LossOfMessages_Operation_main_Read_a_q.SetName("Read a.q");
					LossOfMessages_Operation_main_Read_a_q.SetVisibility(VisibilityKind.public_);
					LossOfMessages_Operation_main_Read_a_q.SetStructuralFeature(LossOfMessages_Operation_A_q);
						// InputPin object
						LossOfMessages_Operation_main_Read_a_q_object.SetName("object");
						LossOfMessages_Operation_main_Read_a_q_object.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Operation_main_Read_a_q_object.SetType(LossOfMessages_Operation_A);
					LossOfMessages_Operation_main_Read_a_q.SetObject(LossOfMessages_Operation_main_Read_a_q_object);
						// OutputPin result
						LossOfMessages_Operation_main_Read_a_q_result.SetName("result");
						LossOfMessages_Operation_main_Read_a_q_result.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Operation_main_Read_a_q_result.SetType(LossOfMessages_Operation_I);
					LossOfMessages_Operation_main_Read_a_q.SetResult(LossOfMessages_Operation_main_Read_a_q_result);
				LossOfMessages_Operation_main.AddNode(LossOfMessages_Operation_main_Read_a_q);
					// ObjectFlow ObjectFlow32 from result to p
					LossOfMessages_Operation_main_ObjectFlow32.SetName("ObjectFlow32");
					LossOfMessages_Operation_main_ObjectFlow32.SetVisibility(VisibilityKind.public_);
					
					LossOfMessages_Operation_main_ObjectFlow32.SetSource(LossOfMessages_Operation_main_Read_a_p_result);
					LossOfMessages_Operation_main_ObjectFlow32.SetTarget(LossOfMessages_Operation_main_Call_testP_p);
						// LiteralBoolean LiteralBoolean34
						LossOfMessages_Operation_main_ObjectFlow32_LiteralBoolean34.SetName("LiteralBoolean34");
						LossOfMessages_Operation_main_ObjectFlow32_LiteralBoolean34.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Operation_main_ObjectFlow32_LiteralBoolean34.SetValue(true);
					LossOfMessages_Operation_main_ObjectFlow32.SetGuard(LossOfMessages_Operation_main_ObjectFlow32_LiteralBoolean34);
				LossOfMessages_Operation_main.AddEdge(LossOfMessages_Operation_main_ObjectFlow32);
					// ObjectFlow ObjectFlow0 from result to target
					LossOfMessages_Operation_main_ObjectFlow0.SetName("ObjectFlow0");
					LossOfMessages_Operation_main_ObjectFlow0.SetVisibility(VisibilityKind.public_);
					
					LossOfMessages_Operation_main_ObjectFlow0.SetSource(LossOfMessages_Operation_main_Read_a_q_result);
					LossOfMessages_Operation_main_ObjectFlow0.SetTarget(LossOfMessages_Operation_main_Call_setP_target);
						// LiteralBoolean LiteralBoolean1
						LossOfMessages_Operation_main_ObjectFlow0_LiteralBoolean1.SetName("LiteralBoolean1");
						LossOfMessages_Operation_main_ObjectFlow0_LiteralBoolean1.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Operation_main_ObjectFlow0_LiteralBoolean1.SetValue(true);
					LossOfMessages_Operation_main_ObjectFlow0.SetGuard(LossOfMessages_Operation_main_ObjectFlow0_LiteralBoolean1);
				LossOfMessages_Operation_main.AddEdge(LossOfMessages_Operation_main_ObjectFlow0);
					// ObjectFlow ObjectFlow35 from Fork A to object
					LossOfMessages_Operation_main_ObjectFlow35.SetName("ObjectFlow35");
					LossOfMessages_Operation_main_ObjectFlow35.SetVisibility(VisibilityKind.public_);
					
					LossOfMessages_Operation_main_ObjectFlow35.SetSource(LossOfMessages_Operation_main_Fork_A);
					LossOfMessages_Operation_main_ObjectFlow35.SetTarget(LossOfMessages_Operation_main_Read_a_p_object);
						// LiteralBoolean LiteralBoolean36
						LossOfMessages_Operation_main_ObjectFlow35_LiteralBoolean36.SetName("LiteralBoolean36");
						LossOfMessages_Operation_main_ObjectFlow35_LiteralBoolean36.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Operation_main_ObjectFlow35_LiteralBoolean36.SetValue(true);
					LossOfMessages_Operation_main_ObjectFlow35.SetGuard(LossOfMessages_Operation_main_ObjectFlow35_LiteralBoolean36);
				LossOfMessages_Operation_main.AddEdge(LossOfMessages_Operation_main_ObjectFlow35);
					// ObjectFlow ObjectFlow3 from result to target
					LossOfMessages_Operation_main_ObjectFlow3.SetName("ObjectFlow3");
					LossOfMessages_Operation_main_ObjectFlow3.SetVisibility(VisibilityKind.public_);
					
					LossOfMessages_Operation_main_ObjectFlow3.SetSource(LossOfMessages_Operation_main_Create_A_result);
					LossOfMessages_Operation_main_ObjectFlow3.SetTarget(LossOfMessages_Operation_main_A__target);
						// LiteralBoolean LiteralBoolean4
						LossOfMessages_Operation_main_ObjectFlow3_LiteralBoolean4.SetName("LiteralBoolean4");
						LossOfMessages_Operation_main_ObjectFlow3_LiteralBoolean4.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Operation_main_ObjectFlow3_LiteralBoolean4.SetValue(true);
					LossOfMessages_Operation_main_ObjectFlow3.SetGuard(LossOfMessages_Operation_main_ObjectFlow3_LiteralBoolean4);
				LossOfMessages_Operation_main.AddEdge(LossOfMessages_Operation_main_ObjectFlow3);
					// ObjectFlow ObjectFlow6 from result to v
					LossOfMessages_Operation_main_ObjectFlow6.SetName("ObjectFlow6");
					LossOfMessages_Operation_main_ObjectFlow6.SetVisibility(VisibilityKind.public_);
					
					LossOfMessages_Operation_main_ObjectFlow6.SetSource(LossOfMessages_Operation_main_Value_4_result);
					LossOfMessages_Operation_main_ObjectFlow6.SetTarget(LossOfMessages_Operation_main_Call_setP_v);
						// LiteralBoolean LiteralBoolean8
						LossOfMessages_Operation_main_ObjectFlow6_LiteralBoolean8.SetName("LiteralBoolean8");
						LossOfMessages_Operation_main_ObjectFlow6_LiteralBoolean8.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Operation_main_ObjectFlow6_LiteralBoolean8.SetValue(true);
					LossOfMessages_Operation_main_ObjectFlow6.SetGuard(LossOfMessages_Operation_main_ObjectFlow6_LiteralBoolean8);
				LossOfMessages_Operation_main.AddEdge(LossOfMessages_Operation_main_ObjectFlow6);
					// ControlFlow ControlFlow16 from Call setP to Read a.p
					LossOfMessages_Operation_main_ControlFlow16.SetName("ControlFlow16");
					LossOfMessages_Operation_main_ControlFlow16.SetVisibility(VisibilityKind.public_);
					
					LossOfMessages_Operation_main_ControlFlow16.SetSource(LossOfMessages_Operation_main_Call_setP);
					LossOfMessages_Operation_main_ControlFlow16.SetTarget(LossOfMessages_Operation_main_Read_a_p);
				LossOfMessages_Operation_main.AddEdge(LossOfMessages_Operation_main_ControlFlow16);
					// ObjectFlow ObjectFlow45 from result to Fork A
					LossOfMessages_Operation_main_ObjectFlow45.SetName("ObjectFlow45");
					LossOfMessages_Operation_main_ObjectFlow45.SetVisibility(VisibilityKind.public_);
					
					LossOfMessages_Operation_main_ObjectFlow45.SetSource(LossOfMessages_Operation_main_A__result);
					LossOfMessages_Operation_main_ObjectFlow45.SetTarget(LossOfMessages_Operation_main_Fork_A);
						// LiteralBoolean LiteralBoolean47
						LossOfMessages_Operation_main_ObjectFlow45_LiteralBoolean47.SetName("LiteralBoolean47");
						LossOfMessages_Operation_main_ObjectFlow45_LiteralBoolean47.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Operation_main_ObjectFlow45_LiteralBoolean47.SetValue(true);
					LossOfMessages_Operation_main_ObjectFlow45.SetGuard(LossOfMessages_Operation_main_ObjectFlow45_LiteralBoolean47);
				LossOfMessages_Operation_main.AddEdge(LossOfMessages_Operation_main_ObjectFlow45);
					// ObjectFlow ObjectFlow29 from Fork A to object
					LossOfMessages_Operation_main_ObjectFlow29.SetName("ObjectFlow29");
					LossOfMessages_Operation_main_ObjectFlow29.SetVisibility(VisibilityKind.public_);
					
					LossOfMessages_Operation_main_ObjectFlow29.SetSource(LossOfMessages_Operation_main_Fork_A);
					LossOfMessages_Operation_main_ObjectFlow29.SetTarget(LossOfMessages_Operation_main_Read_a_q_object);
						// LiteralBoolean LiteralBoolean30
						LossOfMessages_Operation_main_ObjectFlow29_LiteralBoolean30.SetName("LiteralBoolean30");
						LossOfMessages_Operation_main_ObjectFlow29_LiteralBoolean30.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Operation_main_ObjectFlow29_LiteralBoolean30.SetValue(true);
					LossOfMessages_Operation_main_ObjectFlow29.SetGuard(LossOfMessages_Operation_main_ObjectFlow29_LiteralBoolean30);
				LossOfMessages_Operation_main.AddEdge(LossOfMessages_Operation_main_ObjectFlow29);
			LossOfMessages_Operation.AddPackagedElement(LossOfMessages_Operation_main);
				// Interface I
				LossOfMessages_Operation_I.SetName("I");
				LossOfMessages_Operation_I.SetVisibility(VisibilityKind.public_);
					// Operation setP_Integer
					LossOfMessages_Operation_I_setP_Integer.SetName("setP_Integer");
					LossOfMessages_Operation_I_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						LossOfMessages_Operation_I_setP_Integer_v.SetName("v");
						LossOfMessages_Operation_I_setP_Integer_v.SetVisibility(VisibilityKind.package_);
						
						LossOfMessages_Operation_I_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					LossOfMessages_Operation_I_setP_Integer.AddOwnedParameter(LossOfMessages_Operation_I_setP_Integer_v);
				LossOfMessages_Operation_I.AddOwnedOperation(LossOfMessages_Operation_I_setP_Integer);
			LossOfMessages_Operation.AddPackagedElement(LossOfMessages_Operation_I);
				// Class A
				LossOfMessages_Operation_A.SetName("A");
				LossOfMessages_Operation_A.SetVisibility(VisibilityKind.public_);
				
					// Property p
					LossOfMessages_Operation_A_p.SetName("p");
					LossOfMessages_Operation_A_p.SetVisibility(VisibilityKind.public_);
					
					LossOfMessages_Operation_A_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					LossOfMessages_Operation_A_p.SetAggregation(AggregationKind.composite);
						// LiteralInteger LiteralInteger48
						LossOfMessages_Operation_A_p_LiteralInteger48.SetName("LiteralInteger48");
						LossOfMessages_Operation_A_p_LiteralInteger48.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Operation_A_p_LiteralInteger48.SetValue(0);
					LossOfMessages_Operation_A_p.SetDefaultValue(LossOfMessages_Operation_A_p_LiteralInteger48);
				LossOfMessages_Operation_A.AddOwnedAttribute(LossOfMessages_Operation_A_p);
					// Port q
					LossOfMessages_Operation_A_q.SetName("q");
					LossOfMessages_Operation_A_q.SetVisibility(VisibilityKind.public_);
					
					LossOfMessages_Operation_A_q.SetType(LossOfMessages_Operation_IImpl);
					LossOfMessages_Operation_A_q.SetAggregation(AggregationKind.composite);
					LossOfMessages_Operation_A_q.isService = true;
					LossOfMessages_Operation_A_q.AddProvided(LossOfMessages_Operation_I);
				LossOfMessages_Operation_A.AddOwnedAttribute(LossOfMessages_Operation_A_q);
				// Activity setPActivity
					LossOfMessages_Operation_A_setPActivity.SetName("setPActivity");
					LossOfMessages_Operation_A_setPActivity.SetVisibility(VisibilityKind.public_);
					
						// Parameter v
						LossOfMessages_Operation_A_setPActivity_v.SetName("v");
						LossOfMessages_Operation_A_setPActivity_v.SetVisibility(VisibilityKind.package_);
						
						LossOfMessages_Operation_A_setPActivity_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					LossOfMessages_Operation_A_setPActivity.AddOwnedParameter(LossOfMessages_Operation_A_setPActivity_v);
						// ActivityParameterNode vParameterNode
						LossOfMessages_Operation_A_setPActivity_vParameterNode.SetName("vParameterNode");
						LossOfMessages_Operation_A_setPActivity_vParameterNode.SetVisibility(VisibilityKind.public_);
						
						LossOfMessages_Operation_A_setPActivity_vParameterNode.SetParameter(LossOfMessages_Operation_A_setPActivity_v);
					LossOfMessages_Operation_A_setPActivity.AddNode(LossOfMessages_Operation_A_setPActivity_vParameterNode);
						// ReadSelfAction this
						LossOfMessages_Operation_A_setPActivity_this.SetName("this");
						LossOfMessages_Operation_A_setPActivity_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							LossOfMessages_Operation_A_setPActivity_this_result.SetName("result");
							LossOfMessages_Operation_A_setPActivity_this_result.SetVisibility(VisibilityKind.public_);
							LossOfMessages_Operation_A_setPActivity_this_result.SetType(LossOfMessages_Operation_A);
						LossOfMessages_Operation_A_setPActivity_this.SetResult(LossOfMessages_Operation_A_setPActivity_this_result);
					LossOfMessages_Operation_A_setPActivity.AddNode(LossOfMessages_Operation_A_setPActivity_this);
						// AddStructuralFeatureValueAction Set this.p
						LossOfMessages_Operation_A_setPActivity_Set_this_p.SetName("Set this.p");
						LossOfMessages_Operation_A_setPActivity_Set_this_p.SetVisibility(VisibilityKind.public_);
						LossOfMessages_Operation_A_setPActivity_Set_this_p.SetStructuralFeature(LossOfMessages_Operation_A_p);
							// InputPin object
							LossOfMessages_Operation_A_setPActivity_Set_this_p_object.SetName("object");
							LossOfMessages_Operation_A_setPActivity_Set_this_p_object.SetVisibility(VisibilityKind.public_);
							LossOfMessages_Operation_A_setPActivity_Set_this_p_object.SetType(LossOfMessages_Operation_A);
						LossOfMessages_Operation_A_setPActivity_Set_this_p.SetObject(LossOfMessages_Operation_A_setPActivity_Set_this_p_object);
							// InputPin value
							LossOfMessages_Operation_A_setPActivity_Set_this_p_value.SetName("value");
							LossOfMessages_Operation_A_setPActivity_Set_this_p_value.SetVisibility(VisibilityKind.public_);
							LossOfMessages_Operation_A_setPActivity_Set_this_p_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						LossOfMessages_Operation_A_setPActivity_Set_this_p.SetValue(LossOfMessages_Operation_A_setPActivity_Set_this_p_value);
							// OutputPin result
							LossOfMessages_Operation_A_setPActivity_Set_this_p_result.SetName("result");
							LossOfMessages_Operation_A_setPActivity_Set_this_p_result.SetVisibility(VisibilityKind.public_);
							LossOfMessages_Operation_A_setPActivity_Set_this_p_result.SetType(LossOfMessages_Operation_A);
						LossOfMessages_Operation_A_setPActivity_Set_this_p.SetResult(LossOfMessages_Operation_A_setPActivity_Set_this_p_result);
					LossOfMessages_Operation_A_setPActivity.AddNode(LossOfMessages_Operation_A_setPActivity_Set_this_p);
						// ObjectFlow ObjectFlow49 from vParameterNode to value
						LossOfMessages_Operation_A_setPActivity_ObjectFlow49.SetName("ObjectFlow49");
						LossOfMessages_Operation_A_setPActivity_ObjectFlow49.SetVisibility(VisibilityKind.public_);
						
						LossOfMessages_Operation_A_setPActivity_ObjectFlow49.SetSource(LossOfMessages_Operation_A_setPActivity_vParameterNode);
						LossOfMessages_Operation_A_setPActivity_ObjectFlow49.SetTarget(LossOfMessages_Operation_A_setPActivity_Set_this_p_value);
							// LiteralBoolean LiteralBoolean50
							LossOfMessages_Operation_A_setPActivity_ObjectFlow49_LiteralBoolean50.SetName("LiteralBoolean50");
							LossOfMessages_Operation_A_setPActivity_ObjectFlow49_LiteralBoolean50.SetVisibility(VisibilityKind.public_);
							LossOfMessages_Operation_A_setPActivity_ObjectFlow49_LiteralBoolean50.SetValue(true);
						LossOfMessages_Operation_A_setPActivity_ObjectFlow49.SetGuard(LossOfMessages_Operation_A_setPActivity_ObjectFlow49_LiteralBoolean50);
					LossOfMessages_Operation_A_setPActivity.AddEdge(LossOfMessages_Operation_A_setPActivity_ObjectFlow49);
						// ObjectFlow ObjectFlow52 from result to object
						LossOfMessages_Operation_A_setPActivity_ObjectFlow52.SetName("ObjectFlow52");
						LossOfMessages_Operation_A_setPActivity_ObjectFlow52.SetVisibility(VisibilityKind.public_);
						
						LossOfMessages_Operation_A_setPActivity_ObjectFlow52.SetSource(LossOfMessages_Operation_A_setPActivity_this_result);
						LossOfMessages_Operation_A_setPActivity_ObjectFlow52.SetTarget(LossOfMessages_Operation_A_setPActivity_Set_this_p_object);
							// LiteralBoolean LiteralBoolean53
							LossOfMessages_Operation_A_setPActivity_ObjectFlow52_LiteralBoolean53.SetName("LiteralBoolean53");
							LossOfMessages_Operation_A_setPActivity_ObjectFlow52_LiteralBoolean53.SetVisibility(VisibilityKind.public_);
							LossOfMessages_Operation_A_setPActivity_ObjectFlow52_LiteralBoolean53.SetValue(true);
						LossOfMessages_Operation_A_setPActivity_ObjectFlow52.SetGuard(LossOfMessages_Operation_A_setPActivity_ObjectFlow52_LiteralBoolean53);
					LossOfMessages_Operation_A_setPActivity.AddEdge(LossOfMessages_Operation_A_setPActivity_ObjectFlow52);
				LossOfMessages_Operation_A.AddOwnedBehavior(LossOfMessages_Operation_A_setPActivity);
					LossOfMessages_Operation_A_IRealization.SetName("IRealization");
					LossOfMessages_Operation_A_IRealization.SetVisibility(VisibilityKind.public_);
					LossOfMessages_Operation_A_IRealization.SetContract(LossOfMessages_Operation_I);
					
				LossOfMessages_Operation_A.AddInterfaceRealization(LossOfMessages_Operation_A_IRealization);
				
					// Operation setP_Integer
					LossOfMessages_Operation_A_setP_Integer.SetName("setP_Integer");
					LossOfMessages_Operation_A_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						LossOfMessages_Operation_A_setP_Integer_v.SetName("v");
						LossOfMessages_Operation_A_setP_Integer_v.SetVisibility(VisibilityKind.package_);
						
						LossOfMessages_Operation_A_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					LossOfMessages_Operation_A_setP_Integer.AddOwnedParameter(LossOfMessages_Operation_A_setP_Integer_v);
					LossOfMessages_Operation_A_setP_Integer.AddMethod(LossOfMessages_Operation_A_setPActivity);
					LossOfMessages_Operation_A_setP_Integer.AddRedefinedOperation(LossOfMessages_Operation_I_setP_Integer);
				LossOfMessages_Operation_A.AddOwnedOperation(LossOfMessages_Operation_A_setP_Integer);
					// Operation A_A
					LossOfMessages_Operation_A_A_A.SetName("A_A");
					LossOfMessages_Operation_A_A_A.SetVisibility(VisibilityKind.public_);
						// Parameter result
						LossOfMessages_Operation_A_A_A_result.SetName("result");
						LossOfMessages_Operation_A_A_A_result.SetVisibility(VisibilityKind.public_);
						
						LossOfMessages_Operation_A_A_A_result.SetType(LossOfMessages_Operation_A);
						LossOfMessages_Operation_A_A_A_result.SetDirection(ParameterDirectionKind.return_);
					LossOfMessages_Operation_A_A_A.AddOwnedParameter(LossOfMessages_Operation_A_A_A_result);
					LossOfMessages_Operation_A_A_A.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				LossOfMessages_Operation_A.AddOwnedOperation(LossOfMessages_Operation_A_A_A);
			LossOfMessages_Operation.AddPackagedElement(LossOfMessages_Operation_A);
				// Class IImpl
				LossOfMessages_Operation_IImpl.SetName("IImpl");
				LossOfMessages_Operation_IImpl.SetVisibility(VisibilityKind.public_);
				LossOfMessages_Operation_IImpl_IRealization.SetName("IRealization");
					LossOfMessages_Operation_IImpl_IRealization.SetVisibility(VisibilityKind.public_);
					LossOfMessages_Operation_IImpl_IRealization.SetContract(LossOfMessages_Operation_I);
					
				LossOfMessages_Operation_IImpl.AddInterfaceRealization(LossOfMessages_Operation_IImpl_IRealization);
				
					// Operation setP_Integer
					LossOfMessages_Operation_IImpl_setP_Integer.SetName("setP_Integer");
					LossOfMessages_Operation_IImpl_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						LossOfMessages_Operation_IImpl_setP_Integer_v.SetName("v");
						LossOfMessages_Operation_IImpl_setP_Integer_v.SetVisibility(VisibilityKind.package_);
						
						LossOfMessages_Operation_IImpl_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					LossOfMessages_Operation_IImpl_setP_Integer.AddOwnedParameter(LossOfMessages_Operation_IImpl_setP_Integer_v);
					LossOfMessages_Operation_IImpl_setP_Integer.AddRedefinedOperation(LossOfMessages_Operation_I_setP_Integer);
				LossOfMessages_Operation_IImpl.AddOwnedOperation(LossOfMessages_Operation_IImpl_setP_Integer);
			LossOfMessages_Operation.AddPackagedElement(LossOfMessages_Operation_IImpl);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // LossOfMessages_OperationModel
}
