/*
 * BehaviorPort_OperationModel.cs
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

namespace BehaviorPort_Operation
{
	public class BehaviorPort_OperationModel : InMemoryModel
	{
		private static BehaviorPort_OperationModel? instance;

		/*
		 * Model BehaviorPort_Operation
		 */
		public Package BehaviorPort_Operation = new();
			public CallEvent BehaviorPort_Operation_CallEventOr = new();
			public Interface BehaviorPort_Operation_I = new();
				public Operation BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean = new();
					public Parameter BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean_a = new();
					public Parameter BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean_result = new();
					public Parameter BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean_c = new();
					public Parameter BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean_b = new();
			public SignalEvent BehaviorPort_Operation_SignalEventStart = new();
			public Class_ BehaviorPort_Operation_P = new();
				public Activity BehaviorPort_Operation_P_P_ClassifierBehavior = new();
					public ObjectFlow BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow0 = new();
						public LiteralBoolean BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow0_LiteralBoolean1 = new();
						public LiteralInteger BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow0_LiteralInteger2 = new();
					public ObjectFlow BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow3 = new();
						public LiteralInteger BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow3_LiteralInteger4 = new();
						public LiteralBoolean BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow3_LiteralBoolean5 = new();
					public ForkNode BehaviorPort_Operation_P_P_ClassifierBehavior_ForkNode2 = new();
					public ControlFlow BehaviorPort_Operation_P_P_ClassifierBehavior_ControlFlow6 = new();
					public ObjectFlow BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow7 = new();
						public LiteralInteger BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow7_LiteralInteger8 = new();
						public LiteralBoolean BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow7_LiteralBoolean9 = new();
					public ObjectFlow BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow10 = new();
						public LiteralBoolean BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow10_LiteralBoolean11 = new();
						public LiteralInteger BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow10_LiteralInteger12 = new();
					public AddStructuralFeatureValueAction BehaviorPort_Operation_P_P_ClassifierBehavior_set_out = new();
						public InputPin BehaviorPort_Operation_P_P_ClassifierBehavior_set_out_value = new();
							public LiteralUnlimitedNatural BehaviorPort_Operation_P_P_ClassifierBehavior_set_out_value_LiteralUnlimitedNatural13 = new();
							public LiteralInteger BehaviorPort_Operation_P_P_ClassifierBehavior_set_out_value_LiteralInteger14 = new();
						public InputPin BehaviorPort_Operation_P_P_ClassifierBehavior_set_out_object = new();
							public LiteralUnlimitedNatural BehaviorPort_Operation_P_P_ClassifierBehavior_set_out_object_LiteralUnlimitedNatural15 = new();
							public LiteralInteger BehaviorPort_Operation_P_P_ClassifierBehavior_set_out_object_LiteralInteger16 = new();
						public OutputPin BehaviorPort_Operation_P_P_ClassifierBehavior_set_out_result = new();
							public LiteralInteger BehaviorPort_Operation_P_P_ClassifierBehavior_set_out_result_LiteralInteger17 = new();
							public LiteralUnlimitedNatural BehaviorPort_Operation_P_P_ClassifierBehavior_set_out_result_LiteralUnlimitedNatural18 = new();
					public ObjectFlow BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow19 = new();
						public LiteralInteger BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow19_LiteralInteger20 = new();
						public LiteralBoolean BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow19_LiteralBoolean21 = new();
					public ObjectFlow BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow22 = new();
						public LiteralBoolean BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow22_LiteralBoolean23 = new();
						public LiteralInteger BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow22_LiteralInteger24 = new();
					public CallOperationAction BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp = new();
						public OutputPin BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_c = new();
							public LiteralUnlimitedNatural BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_c_LiteralUnlimitedNatural25 = new();
							public LiteralInteger BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_c_LiteralInteger26 = new();
						public OutputPin BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_result = new();
							public LiteralInteger BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_result_LiteralInteger27 = new();
							public LiteralUnlimitedNatural BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_result_LiteralUnlimitedNatural28 = new();
						public InputPin BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_a = new();
							public LiteralInteger BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_a_LiteralInteger29 = new();
							public LiteralUnlimitedNatural BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_a_LiteralUnlimitedNatural30 = new();
						public InputPin BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_target = new();
							public LiteralInteger BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_target_LiteralInteger31 = new();
							public LiteralUnlimitedNatural BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_target_LiteralUnlimitedNatural32 = new();
						public InputPin BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_b = new();
							public LiteralUnlimitedNatural BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_b_LiteralUnlimitedNatural33 = new();
							public LiteralInteger BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_b_LiteralInteger34 = new();
					public ForkNode BehaviorPort_Operation_P_P_ClassifierBehavior_ForkNode1 = new();
					public ReadSelfAction BehaviorPort_Operation_P_P_ClassifierBehavior_this = new();
						public OutputPin BehaviorPort_Operation_P_P_ClassifierBehavior_this_p = new();
							public LiteralUnlimitedNatural BehaviorPort_Operation_P_P_ClassifierBehavior_this_p_LiteralUnlimitedNatural35 = new();
							public LiteralInteger BehaviorPort_Operation_P_P_ClassifierBehavior_this_p_LiteralInteger36 = new();
					public ObjectFlow BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow37 = new();
						public LiteralInteger BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow37_LiteralInteger38 = new();
						public LiteralBoolean BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow37_LiteralBoolean39 = new();
					public ControlFlow BehaviorPort_Operation_P_P_ClassifierBehavior_ControlFlow40 = new();
					public ObjectFlow BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow41 = new();
						public LiteralInteger BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow41_LiteralInteger42 = new();
						public LiteralBoolean BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow41_LiteralBoolean43 = new();
					public InitialNode BehaviorPort_Operation_P_P_ClassifierBehavior_InitialNode1 = new();
					public AcceptEventAction BehaviorPort_Operation_P_P_ClassifierBehavior_Accept_Start = new();
						public Trigger BehaviorPort_Operation_P_P_ClassifierBehavior_Accept_Start_SignalEventStartTrigger = new();
						public OutputPin BehaviorPort_Operation_P_P_ClassifierBehavior_Accept_Start_result = new();
							public LiteralInteger BehaviorPort_Operation_P_P_ClassifierBehavior_Accept_Start_result_LiteralInteger44 = new();
							public LiteralInteger BehaviorPort_Operation_P_P_ClassifierBehavior_Accept_Start_result_LiteralInteger45 = new();
							public LiteralUnlimitedNatural BehaviorPort_Operation_P_P_ClassifierBehavior_Accept_Start_result_LiteralUnlimitedNatural46 = new();
					public ValueSpecificationAction BehaviorPort_Operation_P_P_ClassifierBehavior_true = new();
						public OutputPin BehaviorPort_Operation_P_P_ClassifierBehavior_true_result = new();
							public LiteralUnlimitedNatural BehaviorPort_Operation_P_P_ClassifierBehavior_true_result_LiteralUnlimitedNatural47 = new();
							public LiteralInteger BehaviorPort_Operation_P_P_ClassifierBehavior_true_result_LiteralInteger48 = new();
						public LiteralBoolean BehaviorPort_Operation_P_P_ClassifierBehavior_true_LiteralBoolean49 = new();
					public AddStructuralFeatureValueAction BehaviorPort_Operation_P_P_ClassifierBehavior_set_return = new();
						public InputPin BehaviorPort_Operation_P_P_ClassifierBehavior_set_return_value = new();
							public LiteralUnlimitedNatural BehaviorPort_Operation_P_P_ClassifierBehavior_set_return_value_LiteralUnlimitedNatural50 = new();
							public LiteralInteger BehaviorPort_Operation_P_P_ClassifierBehavior_set_return_value_LiteralInteger51 = new();
						public OutputPin BehaviorPort_Operation_P_P_ClassifierBehavior_set_return_result = new();
							public LiteralUnlimitedNatural BehaviorPort_Operation_P_P_ClassifierBehavior_set_return_result_LiteralUnlimitedNatural52 = new();
							public LiteralInteger BehaviorPort_Operation_P_P_ClassifierBehavior_set_return_result_LiteralInteger53 = new();
						public InputPin BehaviorPort_Operation_P_P_ClassifierBehavior_set_return_object = new();
							public LiteralUnlimitedNatural BehaviorPort_Operation_P_P_ClassifierBehavior_set_return_object_LiteralUnlimitedNatural54 = new();
							public LiteralInteger BehaviorPort_Operation_P_P_ClassifierBehavior_set_return_object_LiteralInteger55 = new();
					public ObjectFlow BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow56 = new();
						public LiteralInteger BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow56_LiteralInteger57 = new();
						public LiteralBoolean BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow56_LiteralBoolean58 = new();
				public Activity BehaviorPort_Operation_P_P_Factory = new();
					public ObjectFlow BehaviorPort_Operation_P_P_Factory_ObjectFlow59 = new();
						public LiteralInteger BehaviorPort_Operation_P_P_Factory_ObjectFlow59_LiteralInteger60 = new();
						public LiteralBoolean BehaviorPort_Operation_P_P_Factory_ObjectFlow59_LiteralBoolean61 = new();
					public CreateObjectAction BehaviorPort_Operation_P_P_Factory_Create_P = new();
						public OutputPin BehaviorPort_Operation_P_P_Factory_Create_P_result = new();
							public LiteralUnlimitedNatural BehaviorPort_Operation_P_P_Factory_Create_P_result_LiteralUnlimitedNatural62 = new();
							public LiteralInteger BehaviorPort_Operation_P_P_Factory_Create_P_result_LiteralInteger63 = new();
					public ObjectFlow BehaviorPort_Operation_P_P_Factory_ObjectFlow64 = new();
						public LiteralInteger BehaviorPort_Operation_P_P_Factory_ObjectFlow64_LiteralInteger65 = new();
						public LiteralBoolean BehaviorPort_Operation_P_P_Factory_ObjectFlow64_LiteralBoolean66 = new();
					public CallOperationAction BehaviorPort_Operation_P_P_Factory_P_ = new();
						public InputPin BehaviorPort_Operation_P_P_Factory_P__target = new();
							public LiteralInteger BehaviorPort_Operation_P_P_Factory_P__target_LiteralInteger67 = new();
							public LiteralUnlimitedNatural BehaviorPort_Operation_P_P_Factory_P__target_LiteralUnlimitedNatural68 = new();
						public OutputPin BehaviorPort_Operation_P_P_Factory_P__result = new();
							public LiteralInteger BehaviorPort_Operation_P_P_Factory_P__result_LiteralInteger69 = new();
							public LiteralUnlimitedNatural BehaviorPort_Operation_P_P_Factory_P__result_LiteralUnlimitedNatural70 = new();
							public LiteralInteger BehaviorPort_Operation_P_P_Factory_P__result_LiteralInteger71 = new();
					public ObjectFlow BehaviorPort_Operation_P_P_Factory_ObjectFlow72 = new();
						public LiteralBoolean BehaviorPort_Operation_P_P_Factory_ObjectFlow72_LiteralBoolean73 = new();
						public LiteralInteger BehaviorPort_Operation_P_P_Factory_ObjectFlow72_LiteralInteger74 = new();
					public ActivityParameterNode BehaviorPort_Operation_P_P_Factory_resultParameterNode = new();
						public LiteralInteger BehaviorPort_Operation_P_P_Factory_resultParameterNode_LiteralInteger75 = new();
					public StartObjectBehaviorAction BehaviorPort_Operation_P_P_Factory_Start_classifierBehavior = new();
						public InputPin BehaviorPort_Operation_P_P_Factory_Start_classifierBehavior_object = new();
							public LiteralUnlimitedNatural BehaviorPort_Operation_P_P_Factory_Start_classifierBehavior_object_LiteralUnlimitedNatural76 = new();
							public LiteralInteger BehaviorPort_Operation_P_P_Factory_Start_classifierBehavior_object_LiteralInteger77 = new();
					public ObjectFlow BehaviorPort_Operation_P_P_Factory_ObjectFlow78 = new();
						public LiteralBoolean BehaviorPort_Operation_P_P_Factory_ObjectFlow78_LiteralBoolean79 = new();
						public LiteralInteger BehaviorPort_Operation_P_P_Factory_ObjectFlow78_LiteralInteger80 = new();
					public ForkNode BehaviorPort_Operation_P_P_Factory_Fork_object = new();
					public Parameter BehaviorPort_Operation_P_P_Factory_result = new();
				public Property BehaviorPort_Operation_P_return = new();
					public LiteralInteger BehaviorPort_Operation_P_return_LiteralInteger81 = new();
				public Port BehaviorPort_Operation_P_pp = new();
				public Property BehaviorPort_Operation_P_out = new();
					public LiteralInteger BehaviorPort_Operation_P_out_LiteralInteger82 = new();
				public Operation BehaviorPort_Operation_P_P_P = new();
					public Parameter BehaviorPort_Operation_P_P_P_result = new();
				public Reception BehaviorPort_Operation_P_Start = new();
			public Activity BehaviorPort_Operation_main = new();
				public ControlFlow BehaviorPort_Operation_main_ControlFlow83 = new();
				public ReadStructuralFeatureAction BehaviorPort_Operation_main_s_p = new();
					public InputPin BehaviorPort_Operation_main_s_p_s = new();
						public LiteralUnlimitedNatural BehaviorPort_Operation_main_s_p_s_LiteralUnlimitedNatural84 = new();
						public LiteralInteger BehaviorPort_Operation_main_s_p_s_LiteralInteger85 = new();
					public OutputPin BehaviorPort_Operation_main_s_p_result = new();
						public LiteralUnlimitedNatural BehaviorPort_Operation_main_s_p_result_LiteralUnlimitedNatural86 = new();
						public LiteralInteger BehaviorPort_Operation_main_s_p_result_LiteralInteger87 = new();
				public CreateObjectAction BehaviorPort_Operation_main_Create_S = new();
					public OutputPin BehaviorPort_Operation_main_Create_S_result = new();
						public LiteralInteger BehaviorPort_Operation_main_Create_S_result_LiteralInteger88 = new();
						public LiteralUnlimitedNatural BehaviorPort_Operation_main_Create_S_result_LiteralUnlimitedNatural89 = new();
				public CallBehaviorAction BehaviorPort_Operation_main_assertP = new();
					public InputPin BehaviorPort_Operation_main_assertP_p = new();
						public LiteralInteger BehaviorPort_Operation_main_assertP_p_LiteralInteger90 = new();
						public LiteralInteger BehaviorPort_Operation_main_assertP_p_LiteralInteger91 = new();
						public LiteralUnlimitedNatural BehaviorPort_Operation_main_assertP_p_LiteralUnlimitedNatural92 = new();
				public ObjectFlow BehaviorPort_Operation_main_ObjectFlow93 = new();
					public LiteralInteger BehaviorPort_Operation_main_ObjectFlow93_LiteralInteger94 = new();
					public LiteralBoolean BehaviorPort_Operation_main_ObjectFlow93_LiteralBoolean95 = new();
				public SendSignalAction BehaviorPort_Operation_main_Send_Start = new();
					public InputPin BehaviorPort_Operation_main_Send_Start_target = new();
						public LiteralInteger BehaviorPort_Operation_main_Send_Start_target_LiteralInteger96 = new();
						public LiteralUnlimitedNatural BehaviorPort_Operation_main_Send_Start_target_LiteralUnlimitedNatural97 = new();
				public ForkNode BehaviorPort_Operation_main_Fork_s_p = new();
				public ObjectFlow BehaviorPort_Operation_main_ObjectFlow98 = new();
					public LiteralInteger BehaviorPort_Operation_main_ObjectFlow98_LiteralInteger99 = new();
					public LiteralBoolean BehaviorPort_Operation_main_ObjectFlow98_LiteralBoolean100 = new();
				public ObjectFlow BehaviorPort_Operation_main_ObjectFlow101 = new();
					public LiteralInteger BehaviorPort_Operation_main_ObjectFlow101_LiteralInteger102 = new();
					public LiteralBoolean BehaviorPort_Operation_main_ObjectFlow101_LiteralBoolean103 = new();
				public ObjectFlow BehaviorPort_Operation_main_ObjectFlow104 = new();
					public LiteralBoolean BehaviorPort_Operation_main_ObjectFlow104_LiteralBoolean105 = new();
					public LiteralInteger BehaviorPort_Operation_main_ObjectFlow104_LiteralInteger106 = new();
				public ObjectFlow BehaviorPort_Operation_main_ObjectFlow107 = new();
					public LiteralInteger BehaviorPort_Operation_main_ObjectFlow107_LiteralInteger108 = new();
					public LiteralBoolean BehaviorPort_Operation_main_ObjectFlow107_LiteralBoolean109 = new();
				public CallOperationAction BehaviorPort_Operation_main_S_ = new();
					public InputPin BehaviorPort_Operation_main_S__target = new();
						public LiteralInteger BehaviorPort_Operation_main_S__target_LiteralInteger110 = new();
						public LiteralUnlimitedNatural BehaviorPort_Operation_main_S__target_LiteralUnlimitedNatural111 = new();
					public OutputPin BehaviorPort_Operation_main_S__result = new();
						public LiteralInteger BehaviorPort_Operation_main_S__result_LiteralInteger112 = new();
						public LiteralUnlimitedNatural BehaviorPort_Operation_main_S__result_LiteralUnlimitedNatural113 = new();
						public LiteralInteger BehaviorPort_Operation_main_S__result_LiteralInteger114 = new();
			public Class_ BehaviorPort_Operation_C = new();
				public Activity BehaviorPort_Operation_C_C_Factory = new();
					public ObjectFlow BehaviorPort_Operation_C_C_Factory_ObjectFlow115 = new();
						public LiteralBoolean BehaviorPort_Operation_C_C_Factory_ObjectFlow115_LiteralBoolean116 = new();
						public LiteralInteger BehaviorPort_Operation_C_C_Factory_ObjectFlow115_LiteralInteger117 = new();
					public ForkNode BehaviorPort_Operation_C_C_Factory_Fork_object = new();
					public Parameter BehaviorPort_Operation_C_C_Factory_result = new();
					public ObjectFlow BehaviorPort_Operation_C_C_Factory_ObjectFlow118 = new();
						public LiteralBoolean BehaviorPort_Operation_C_C_Factory_ObjectFlow118_LiteralBoolean119 = new();
						public LiteralInteger BehaviorPort_Operation_C_C_Factory_ObjectFlow118_LiteralInteger120 = new();
					public ObjectFlow BehaviorPort_Operation_C_C_Factory_ObjectFlow121 = new();
						public LiteralBoolean BehaviorPort_Operation_C_C_Factory_ObjectFlow121_LiteralBoolean122 = new();
						public LiteralInteger BehaviorPort_Operation_C_C_Factory_ObjectFlow121_LiteralInteger123 = new();
					public CreateObjectAction BehaviorPort_Operation_C_C_Factory_Create_C = new();
						public OutputPin BehaviorPort_Operation_C_C_Factory_Create_C_result = new();
							public LiteralInteger BehaviorPort_Operation_C_C_Factory_Create_C_result_LiteralInteger124 = new();
							public LiteralUnlimitedNatural BehaviorPort_Operation_C_C_Factory_Create_C_result_LiteralUnlimitedNatural125 = new();
					public StartObjectBehaviorAction BehaviorPort_Operation_C_C_Factory_Start_classifierBehavior = new();
						public InputPin BehaviorPort_Operation_C_C_Factory_Start_classifierBehavior_object = new();
							public LiteralInteger BehaviorPort_Operation_C_C_Factory_Start_classifierBehavior_object_LiteralInteger126 = new();
							public LiteralUnlimitedNatural BehaviorPort_Operation_C_C_Factory_Start_classifierBehavior_object_LiteralUnlimitedNatural127 = new();
					public ObjectFlow BehaviorPort_Operation_C_C_Factory_ObjectFlow128 = new();
						public LiteralInteger BehaviorPort_Operation_C_C_Factory_ObjectFlow128_LiteralInteger129 = new();
						public LiteralBoolean BehaviorPort_Operation_C_C_Factory_ObjectFlow128_LiteralBoolean130 = new();
					public ActivityParameterNode BehaviorPort_Operation_C_C_Factory_resultParameterNode = new();
						public LiteralInteger BehaviorPort_Operation_C_C_Factory_resultParameterNode_LiteralInteger131 = new();
					public CallOperationAction BehaviorPort_Operation_C_C_Factory_C_ = new();
						public OutputPin BehaviorPort_Operation_C_C_Factory_C__result = new();
							public LiteralUnlimitedNatural BehaviorPort_Operation_C_C_Factory_C__result_LiteralUnlimitedNatural132 = new();
							public LiteralInteger BehaviorPort_Operation_C_C_Factory_C__result_LiteralInteger133 = new();
							public LiteralInteger BehaviorPort_Operation_C_C_Factory_C__result_LiteralInteger134 = new();
						public InputPin BehaviorPort_Operation_C_C_Factory_C__target = new();
							public LiteralInteger BehaviorPort_Operation_C_C_Factory_C__target_LiteralInteger135 = new();
							public LiteralUnlimitedNatural BehaviorPort_Operation_C_C_Factory_C__target_LiteralUnlimitedNatural136 = new();
				public Port BehaviorPort_Operation_C_pc = new();
				public Operation BehaviorPort_Operation_C_C_C = new();
					public Parameter BehaviorPort_Operation_C_C_C_result = new();
				public InterfaceRealization BehaviorPort_Operation_C_I_Realization = new();
				public Operation BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean = new();
					public Parameter BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean_b = new();
					public Parameter BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean_result = new();
					public Parameter BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean_c = new();
					public Parameter BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean_a = new();
				public Activity BehaviorPort_Operation_C_C_ClassifierBehavior = new();
					public ObjectFlow BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow137 = new();
						public LiteralInteger BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow137_LiteralInteger138 = new();
						public LiteralBoolean BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow137_LiteralBoolean139 = new();
					public ControlFlow BehaviorPort_Operation_C_C_ClassifierBehavior_ControlFlow140 = new();
					public ForkNode BehaviorPort_Operation_C_C_ClassifierBehavior_Fork_result = new();
					public ObjectFlow BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow141 = new();
						public LiteralInteger BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow141_LiteralInteger142 = new();
						public LiteralBoolean BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow141_LiteralBoolean143 = new();
					public ObjectFlow BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow144 = new();
						public LiteralBoolean BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow144_LiteralBoolean145 = new();
						public LiteralInteger BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow144_LiteralInteger146 = new();
					public InitialNode BehaviorPort_Operation_C_C_ClassifierBehavior_InitialNode1 = new();
					public ObjectFlow BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow147 = new();
						public LiteralBoolean BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow147_LiteralBoolean148 = new();
						public LiteralInteger BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow147_LiteralInteger149 = new();
					public CallBehaviorAction BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor = new();
						public InputPin BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_y = new();
							public LiteralInteger BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_y_LiteralInteger150 = new();
							public LiteralUnlimitedNatural BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_y_LiteralUnlimitedNatural151 = new();
						public OutputPin BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_result = new();
							public LiteralInteger BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_result_LiteralInteger152 = new();
							public LiteralInteger BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_result_LiteralInteger153 = new();
							public LiteralUnlimitedNatural BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_result_LiteralUnlimitedNatural154 = new();
						public InputPin BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_x = new();
							public LiteralInteger BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_x_LiteralInteger155 = new();
							public LiteralUnlimitedNatural BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_x_LiteralUnlimitedNatural156 = new();
					public ObjectFlow BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow157 = new();
						public LiteralBoolean BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow157_LiteralBoolean158 = new();
						public LiteralInteger BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow157_LiteralInteger159 = new();
					public AcceptCallAction BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or_ = new();
						public OutputPin BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or__b = new();
							public LiteralInteger BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or__b_LiteralInteger160 = new();
						public OutputPin BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or__returnInformation = new();
						public OutputPin BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or__a = new();
							public LiteralInteger BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or__a_LiteralInteger161 = new();
						public Trigger BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or__CallEventOrTrigger = new();
					public ReplyAction BehaviorPort_Operation_C_C_ClassifierBehavior_Reply_or_ = new();
						public InputPin BehaviorPort_Operation_C_C_ClassifierBehavior_Reply_or__r = new();
						public InputPin BehaviorPort_Operation_C_C_ClassifierBehavior_Reply_or__cr = new();
						public InputPin BehaviorPort_Operation_C_C_ClassifierBehavior_Reply_or__returnInformation = new();
					public ObjectFlow BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow162 = new();
						public LiteralInteger BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow162_LiteralInteger163 = new();
						public LiteralBoolean BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow162_LiteralBoolean164 = new();
			public Class_ BehaviorPort_Operation_S = new();
				public Property BehaviorPort_Operation_S_p = new();
				public Property BehaviorPort_Operation_S_c = new();
				public Connector BehaviorPort_Operation_S_Connector1 = new();
					public ConnectorEnd BehaviorPort_Operation_S_Connector1_ConnectorEnd165 = new();
					public ConnectorEnd BehaviorPort_Operation_S_Connector1_ConnectorEnd166 = new();
				public Operation BehaviorPort_Operation_S_S_S = new();
					public Parameter BehaviorPort_Operation_S_S_S_result = new();
			public Signal BehaviorPort_Operation_Start = new();
			public Usage BehaviorPort_Operation_I_Usage_P = new();
			public Activity BehaviorPort_Operation_assertP = new();
				public ObjectFlow BehaviorPort_Operation_assertP_ObjectFlow167 = new();
					public LiteralInteger BehaviorPort_Operation_assertP_ObjectFlow167_LiteralInteger168 = new();
					public LiteralBoolean BehaviorPort_Operation_assertP_ObjectFlow167_LiteralBoolean169 = new();
				public ControlFlow BehaviorPort_Operation_assertP_ControlFlow170 = new();
				public ObjectFlow BehaviorPort_Operation_assertP_ObjectFlow171 = new();
					public LiteralBoolean BehaviorPort_Operation_assertP_ObjectFlow171_LiteralBoolean172 = new();
					public LiteralInteger BehaviorPort_Operation_assertP_ObjectFlow171_LiteralInteger173 = new();
				public ObjectFlow BehaviorPort_Operation_assertP_ObjectFlow174 = new();
					public LiteralBoolean BehaviorPort_Operation_assertP_ObjectFlow174_LiteralBoolean175 = new();
					public LiteralInteger BehaviorPort_Operation_assertP_ObjectFlow174_LiteralInteger176 = new();
				public ForkNode BehaviorPort_Operation_assertP_Fork_p = new();
				public CallBehaviorAction BehaviorPort_Operation_assertP_test_out = new();
					public InputPin BehaviorPort_Operation_assertP_test_out_input = new();
						public LiteralUnlimitedNatural BehaviorPort_Operation_assertP_test_out_input_LiteralUnlimitedNatural177 = new();
						public LiteralInteger BehaviorPort_Operation_assertP_test_out_input_LiteralInteger178 = new();
						public LiteralInteger BehaviorPort_Operation_assertP_test_out_input_LiteralInteger179 = new();
				public CallBehaviorAction BehaviorPort_Operation_assertP_writeLine_p_return = new();
					public OutputPin BehaviorPort_Operation_assertP_writeLine_p_return_errorStatus = new();
						public LiteralUnlimitedNatural BehaviorPort_Operation_assertP_writeLine_p_return_errorStatus_LiteralUnlimitedNatural180 = new();
						public LiteralInteger BehaviorPort_Operation_assertP_writeLine_p_return_errorStatus_LiteralInteger181 = new();
						public LiteralInteger BehaviorPort_Operation_assertP_writeLine_p_return_errorStatus_LiteralInteger182 = new();
					public InputPin BehaviorPort_Operation_assertP_writeLine_p_return_value = new();
						public LiteralInteger BehaviorPort_Operation_assertP_writeLine_p_return_value_LiteralInteger183 = new();
						public LiteralUnlimitedNatural BehaviorPort_Operation_assertP_writeLine_p_return_value_LiteralUnlimitedNatural184 = new();
						public LiteralInteger BehaviorPort_Operation_assertP_writeLine_p_return_value_LiteralInteger185 = new();
				public CallBehaviorAction BehaviorPort_Operation_assertP_writeLine_p_out = new();
					public InputPin BehaviorPort_Operation_assertP_writeLine_p_out_value = new();
						public LiteralUnlimitedNatural BehaviorPort_Operation_assertP_writeLine_p_out_value_LiteralUnlimitedNatural186 = new();
						public LiteralInteger BehaviorPort_Operation_assertP_writeLine_p_out_value_LiteralInteger187 = new();
						public LiteralInteger BehaviorPort_Operation_assertP_writeLine_p_out_value_LiteralInteger188 = new();
					public OutputPin BehaviorPort_Operation_assertP_writeLine_p_out_errorStatus = new();
						public LiteralUnlimitedNatural BehaviorPort_Operation_assertP_writeLine_p_out_errorStatus_LiteralUnlimitedNatural189 = new();
						public LiteralInteger BehaviorPort_Operation_assertP_writeLine_p_out_errorStatus_LiteralInteger190 = new();
						public LiteralInteger BehaviorPort_Operation_assertP_writeLine_p_out_errorStatus_LiteralInteger191 = new();
				public ReadStructuralFeatureAction BehaviorPort_Operation_assertP_p_out = new();
					public OutputPin BehaviorPort_Operation_assertP_p_out_result = new();
						public LiteralInteger BehaviorPort_Operation_assertP_p_out_result_LiteralInteger192 = new();
						public LiteralUnlimitedNatural BehaviorPort_Operation_assertP_p_out_result_LiteralUnlimitedNatural193 = new();
					public InputPin BehaviorPort_Operation_assertP_p_out_object = new();
						public LiteralUnlimitedNatural BehaviorPort_Operation_assertP_p_out_object_LiteralUnlimitedNatural194 = new();
						public LiteralInteger BehaviorPort_Operation_assertP_p_out_object_LiteralInteger195 = new();
				public ControlFlow BehaviorPort_Operation_assertP_ControlFlow196 = new();
				public Parameter BehaviorPort_Operation_assertP_p = new();
				public ControlFlow BehaviorPort_Operation_assertP_ControlFlow197 = new();
				public ActivityParameterNode BehaviorPort_Operation_assertP_pParameterNode = new();
					public LiteralInteger BehaviorPort_Operation_assertP_pParameterNode_LiteralInteger198 = new();
				public CallBehaviorAction BehaviorPort_Operation_assertP_test_return = new();
					public InputPin BehaviorPort_Operation_assertP_test_return_input = new();
						public LiteralInteger BehaviorPort_Operation_assertP_test_return_input_LiteralInteger199 = new();
						public LiteralInteger BehaviorPort_Operation_assertP_test_return_input_LiteralInteger200 = new();
						public LiteralUnlimitedNatural BehaviorPort_Operation_assertP_test_return_input_LiteralUnlimitedNatural201 = new();
				public ValueSpecificationAction BehaviorPort_Operation_assertP_p_out_message = new();
					public LiteralString BehaviorPort_Operation_assertP_p_out_message_LiteralString202 = new();
					public OutputPin BehaviorPort_Operation_assertP_p_out_message_result = new();
						public LiteralUnlimitedNatural BehaviorPort_Operation_assertP_p_out_message_result_LiteralUnlimitedNatural203 = new();
						public LiteralInteger BehaviorPort_Operation_assertP_p_out_message_result_LiteralInteger204 = new();
				public ReadStructuralFeatureAction BehaviorPort_Operation_assertP_p_return = new();
					public InputPin BehaviorPort_Operation_assertP_p_return_object = new();
						public LiteralInteger BehaviorPort_Operation_assertP_p_return_object_LiteralInteger205 = new();
						public LiteralUnlimitedNatural BehaviorPort_Operation_assertP_p_return_object_LiteralUnlimitedNatural206 = new();
					public OutputPin BehaviorPort_Operation_assertP_p_return_result = new();
						public LiteralUnlimitedNatural BehaviorPort_Operation_assertP_p_return_result_LiteralUnlimitedNatural207 = new();
						public LiteralInteger BehaviorPort_Operation_assertP_p_return_result_LiteralInteger208 = new();
				public ObjectFlow BehaviorPort_Operation_assertP_ObjectFlow209 = new();
					public LiteralBoolean BehaviorPort_Operation_assertP_ObjectFlow209_LiteralBoolean210 = new();
					public LiteralInteger BehaviorPort_Operation_assertP_ObjectFlow209_LiteralInteger211 = new();
				public ControlFlow BehaviorPort_Operation_assertP_ControlFlow212 = new();
				public ValueSpecificationAction BehaviorPort_Operation_assertP_p_return_message = new();
					public LiteralString BehaviorPort_Operation_assertP_p_return_message_LiteralString213 = new();
					public OutputPin BehaviorPort_Operation_assertP_p_return_message_result = new();
						public LiteralUnlimitedNatural BehaviorPort_Operation_assertP_p_return_message_result_LiteralUnlimitedNatural214 = new();
						public LiteralInteger BehaviorPort_Operation_assertP_p_return_message_result_LiteralInteger215 = new();
				public ObjectFlow BehaviorPort_Operation_assertP_ObjectFlow216 = new();
					public LiteralBoolean BehaviorPort_Operation_assertP_ObjectFlow216_LiteralBoolean217 = new();
					public LiteralInteger BehaviorPort_Operation_assertP_ObjectFlow216_LiteralInteger218 = new();
				public ControlFlow BehaviorPort_Operation_assertP_ControlFlow219 = new();
				public ObjectFlow BehaviorPort_Operation_assertP_ObjectFlow220 = new();
					public LiteralInteger BehaviorPort_Operation_assertP_ObjectFlow220_LiteralInteger221 = new();
					public LiteralBoolean BehaviorPort_Operation_assertP_ObjectFlow220_LiteralBoolean222 = new();
				public OpaqueBehavior BehaviorPort_Operation_assertP_testFalse = new();
					public Parameter BehaviorPort_Operation_assertP_testFalse_input = new();
				public ObjectFlow BehaviorPort_Operation_assertP_ObjectFlow223 = new();
					public LiteralBoolean BehaviorPort_Operation_assertP_ObjectFlow223_LiteralBoolean224 = new();
					public LiteralInteger BehaviorPort_Operation_assertP_ObjectFlow223_LiteralInteger225 = new();

		public static BehaviorPort_OperationModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public BehaviorPort_OperationModel()
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
			 * Model BehaviorPort_Operation
			 */
			AddToElementRepository("BehaviorPort_Operation", BehaviorPort_Operation);
				AddToElementRepository("CallEventOr", BehaviorPort_Operation_CallEventOr);
				AddToElementRepository("I", BehaviorPort_Operation_I);
					AddToElementRepository("Boolean_or_Boolean_Boolean_Boolean", BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean);
						AddToElementRepository("a", BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean_a);
						AddToElementRepository("result", BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean_result);
						AddToElementRepository("c", BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean_c);
						AddToElementRepository("b", BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean_b);
				AddToElementRepository("SignalEventStart", BehaviorPort_Operation_SignalEventStart);
				AddToElementRepository("P", BehaviorPort_Operation_P);
					AddToElementRepository("P$ClassifierBehavior", BehaviorPort_Operation_P_P_ClassifierBehavior);
						AddToElementRepository("ObjectFlow0", BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow0);
							AddToElementRepository("LiteralBoolean1", BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow0_LiteralBoolean1);
							AddToElementRepository("LiteralInteger2", BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow0_LiteralInteger2);
						AddToElementRepository("ObjectFlow3", BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow3);
							AddToElementRepository("LiteralInteger4", BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow3_LiteralInteger4);
							AddToElementRepository("LiteralBoolean5", BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow3_LiteralBoolean5);
						AddToElementRepository("ForkNode2", BehaviorPort_Operation_P_P_ClassifierBehavior_ForkNode2);
						AddToElementRepository("ControlFlow6", BehaviorPort_Operation_P_P_ClassifierBehavior_ControlFlow6);
						AddToElementRepository("ObjectFlow7", BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow7);
							AddToElementRepository("LiteralInteger8", BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow7_LiteralInteger8);
							AddToElementRepository("LiteralBoolean9", BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow7_LiteralBoolean9);
						AddToElementRepository("ObjectFlow10", BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow10);
							AddToElementRepository("LiteralBoolean11", BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow10_LiteralBoolean11);
							AddToElementRepository("LiteralInteger12", BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow10_LiteralInteger12);
						AddToElementRepository("set out", BehaviorPort_Operation_P_P_ClassifierBehavior_set_out);
							AddToElementRepository("value", BehaviorPort_Operation_P_P_ClassifierBehavior_set_out_value);
								AddToElementRepository("LiteralUnlimitedNatural13", BehaviorPort_Operation_P_P_ClassifierBehavior_set_out_value_LiteralUnlimitedNatural13);
								AddToElementRepository("LiteralInteger14", BehaviorPort_Operation_P_P_ClassifierBehavior_set_out_value_LiteralInteger14);
							AddToElementRepository("object", BehaviorPort_Operation_P_P_ClassifierBehavior_set_out_object);
								AddToElementRepository("LiteralUnlimitedNatural15", BehaviorPort_Operation_P_P_ClassifierBehavior_set_out_object_LiteralUnlimitedNatural15);
								AddToElementRepository("LiteralInteger16", BehaviorPort_Operation_P_P_ClassifierBehavior_set_out_object_LiteralInteger16);
							AddToElementRepository("result", BehaviorPort_Operation_P_P_ClassifierBehavior_set_out_result);
								AddToElementRepository("LiteralInteger17", BehaviorPort_Operation_P_P_ClassifierBehavior_set_out_result_LiteralInteger17);
								AddToElementRepository("LiteralUnlimitedNatural18", BehaviorPort_Operation_P_P_ClassifierBehavior_set_out_result_LiteralUnlimitedNatural18);
						AddToElementRepository("ObjectFlow19", BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow19);
							AddToElementRepository("LiteralInteger20", BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow19_LiteralInteger20);
							AddToElementRepository("LiteralBoolean21", BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow19_LiteralBoolean21);
						AddToElementRepository("ObjectFlow22", BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow22);
							AddToElementRepository("LiteralBoolean23", BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow22_LiteralBoolean23);
							AddToElementRepository("LiteralInteger24", BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow22_LiteralInteger24);
						AddToElementRepository("Call or() via pp", BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp);
							AddToElementRepository("c", BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_c);
								AddToElementRepository("LiteralUnlimitedNatural25", BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_c_LiteralUnlimitedNatural25);
								AddToElementRepository("LiteralInteger26", BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_c_LiteralInteger26);
							AddToElementRepository("result", BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_result);
								AddToElementRepository("LiteralInteger27", BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_result_LiteralInteger27);
								AddToElementRepository("LiteralUnlimitedNatural28", BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_result_LiteralUnlimitedNatural28);
							AddToElementRepository("a", BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_a);
								AddToElementRepository("LiteralInteger29", BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_a_LiteralInteger29);
								AddToElementRepository("LiteralUnlimitedNatural30", BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_a_LiteralUnlimitedNatural30);
							AddToElementRepository("target", BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_target);
								AddToElementRepository("LiteralInteger31", BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_target_LiteralInteger31);
								AddToElementRepository("LiteralUnlimitedNatural32", BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_target_LiteralUnlimitedNatural32);
							AddToElementRepository("b", BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_b);
								AddToElementRepository("LiteralUnlimitedNatural33", BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_b_LiteralUnlimitedNatural33);
								AddToElementRepository("LiteralInteger34", BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_b_LiteralInteger34);
						AddToElementRepository("ForkNode1", BehaviorPort_Operation_P_P_ClassifierBehavior_ForkNode1);
						AddToElementRepository("this", BehaviorPort_Operation_P_P_ClassifierBehavior_this);
							AddToElementRepository("p", BehaviorPort_Operation_P_P_ClassifierBehavior_this_p);
								AddToElementRepository("LiteralUnlimitedNatural35", BehaviorPort_Operation_P_P_ClassifierBehavior_this_p_LiteralUnlimitedNatural35);
								AddToElementRepository("LiteralInteger36", BehaviorPort_Operation_P_P_ClassifierBehavior_this_p_LiteralInteger36);
						AddToElementRepository("ObjectFlow37", BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow37);
							AddToElementRepository("LiteralInteger38", BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow37_LiteralInteger38);
							AddToElementRepository("LiteralBoolean39", BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow37_LiteralBoolean39);
						AddToElementRepository("ControlFlow40", BehaviorPort_Operation_P_P_ClassifierBehavior_ControlFlow40);
						AddToElementRepository("ObjectFlow41", BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow41);
							AddToElementRepository("LiteralInteger42", BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow41_LiteralInteger42);
							AddToElementRepository("LiteralBoolean43", BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow41_LiteralBoolean43);
						AddToElementRepository("InitialNode1", BehaviorPort_Operation_P_P_ClassifierBehavior_InitialNode1);
						AddToElementRepository("Accept Start", BehaviorPort_Operation_P_P_ClassifierBehavior_Accept_Start);
							AddToElementRepository("SignalEventStartTrigger", BehaviorPort_Operation_P_P_ClassifierBehavior_Accept_Start_SignalEventStartTrigger);
							AddToElementRepository("result", BehaviorPort_Operation_P_P_ClassifierBehavior_Accept_Start_result);
								AddToElementRepository("LiteralInteger44", BehaviorPort_Operation_P_P_ClassifierBehavior_Accept_Start_result_LiteralInteger44);
								AddToElementRepository("LiteralInteger45", BehaviorPort_Operation_P_P_ClassifierBehavior_Accept_Start_result_LiteralInteger45);
								AddToElementRepository("LiteralUnlimitedNatural46", BehaviorPort_Operation_P_P_ClassifierBehavior_Accept_Start_result_LiteralUnlimitedNatural46);
						AddToElementRepository("true", BehaviorPort_Operation_P_P_ClassifierBehavior_true);
							AddToElementRepository("result", BehaviorPort_Operation_P_P_ClassifierBehavior_true_result);
								AddToElementRepository("LiteralUnlimitedNatural47", BehaviorPort_Operation_P_P_ClassifierBehavior_true_result_LiteralUnlimitedNatural47);
								AddToElementRepository("LiteralInteger48", BehaviorPort_Operation_P_P_ClassifierBehavior_true_result_LiteralInteger48);
							AddToElementRepository("LiteralBoolean49", BehaviorPort_Operation_P_P_ClassifierBehavior_true_LiteralBoolean49);
						AddToElementRepository("set return", BehaviorPort_Operation_P_P_ClassifierBehavior_set_return);
							AddToElementRepository("value", BehaviorPort_Operation_P_P_ClassifierBehavior_set_return_value);
								AddToElementRepository("LiteralUnlimitedNatural50", BehaviorPort_Operation_P_P_ClassifierBehavior_set_return_value_LiteralUnlimitedNatural50);
								AddToElementRepository("LiteralInteger51", BehaviorPort_Operation_P_P_ClassifierBehavior_set_return_value_LiteralInteger51);
							AddToElementRepository("result", BehaviorPort_Operation_P_P_ClassifierBehavior_set_return_result);
								AddToElementRepository("LiteralUnlimitedNatural52", BehaviorPort_Operation_P_P_ClassifierBehavior_set_return_result_LiteralUnlimitedNatural52);
								AddToElementRepository("LiteralInteger53", BehaviorPort_Operation_P_P_ClassifierBehavior_set_return_result_LiteralInteger53);
							AddToElementRepository("object", BehaviorPort_Operation_P_P_ClassifierBehavior_set_return_object);
								AddToElementRepository("LiteralUnlimitedNatural54", BehaviorPort_Operation_P_P_ClassifierBehavior_set_return_object_LiteralUnlimitedNatural54);
								AddToElementRepository("LiteralInteger55", BehaviorPort_Operation_P_P_ClassifierBehavior_set_return_object_LiteralInteger55);
						AddToElementRepository("ObjectFlow56", BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow56);
							AddToElementRepository("LiteralInteger57", BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow56_LiteralInteger57);
							AddToElementRepository("LiteralBoolean58", BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow56_LiteralBoolean58);
					AddToElementRepository("P_Factory", BehaviorPort_Operation_P_P_Factory);
						AddToElementRepository("ObjectFlow59", BehaviorPort_Operation_P_P_Factory_ObjectFlow59);
							AddToElementRepository("LiteralInteger60", BehaviorPort_Operation_P_P_Factory_ObjectFlow59_LiteralInteger60);
							AddToElementRepository("LiteralBoolean61", BehaviorPort_Operation_P_P_Factory_ObjectFlow59_LiteralBoolean61);
						AddToElementRepository("Create P", BehaviorPort_Operation_P_P_Factory_Create_P);
							AddToElementRepository("result", BehaviorPort_Operation_P_P_Factory_Create_P_result);
								AddToElementRepository("LiteralUnlimitedNatural62", BehaviorPort_Operation_P_P_Factory_Create_P_result_LiteralUnlimitedNatural62);
								AddToElementRepository("LiteralInteger63", BehaviorPort_Operation_P_P_Factory_Create_P_result_LiteralInteger63);
						AddToElementRepository("ObjectFlow64", BehaviorPort_Operation_P_P_Factory_ObjectFlow64);
							AddToElementRepository("LiteralInteger65", BehaviorPort_Operation_P_P_Factory_ObjectFlow64_LiteralInteger65);
							AddToElementRepository("LiteralBoolean66", BehaviorPort_Operation_P_P_Factory_ObjectFlow64_LiteralBoolean66);
						AddToElementRepository("P()", BehaviorPort_Operation_P_P_Factory_P_);
							AddToElementRepository("target", BehaviorPort_Operation_P_P_Factory_P__target);
								AddToElementRepository("LiteralInteger67", BehaviorPort_Operation_P_P_Factory_P__target_LiteralInteger67);
								AddToElementRepository("LiteralUnlimitedNatural68", BehaviorPort_Operation_P_P_Factory_P__target_LiteralUnlimitedNatural68);
							AddToElementRepository("result", BehaviorPort_Operation_P_P_Factory_P__result);
								AddToElementRepository("LiteralInteger69", BehaviorPort_Operation_P_P_Factory_P__result_LiteralInteger69);
								AddToElementRepository("LiteralUnlimitedNatural70", BehaviorPort_Operation_P_P_Factory_P__result_LiteralUnlimitedNatural70);
								AddToElementRepository("LiteralInteger71", BehaviorPort_Operation_P_P_Factory_P__result_LiteralInteger71);
						AddToElementRepository("ObjectFlow72", BehaviorPort_Operation_P_P_Factory_ObjectFlow72);
							AddToElementRepository("LiteralBoolean73", BehaviorPort_Operation_P_P_Factory_ObjectFlow72_LiteralBoolean73);
							AddToElementRepository("LiteralInteger74", BehaviorPort_Operation_P_P_Factory_ObjectFlow72_LiteralInteger74);
						AddToElementRepository("resultParameterNode", BehaviorPort_Operation_P_P_Factory_resultParameterNode);
							AddToElementRepository("LiteralInteger75", BehaviorPort_Operation_P_P_Factory_resultParameterNode_LiteralInteger75);
						AddToElementRepository("Start classifierBehavior", BehaviorPort_Operation_P_P_Factory_Start_classifierBehavior);
							AddToElementRepository("object", BehaviorPort_Operation_P_P_Factory_Start_classifierBehavior_object);
								AddToElementRepository("LiteralUnlimitedNatural76", BehaviorPort_Operation_P_P_Factory_Start_classifierBehavior_object_LiteralUnlimitedNatural76);
								AddToElementRepository("LiteralInteger77", BehaviorPort_Operation_P_P_Factory_Start_classifierBehavior_object_LiteralInteger77);
						AddToElementRepository("ObjectFlow78", BehaviorPort_Operation_P_P_Factory_ObjectFlow78);
							AddToElementRepository("LiteralBoolean79", BehaviorPort_Operation_P_P_Factory_ObjectFlow78_LiteralBoolean79);
							AddToElementRepository("LiteralInteger80", BehaviorPort_Operation_P_P_Factory_ObjectFlow78_LiteralInteger80);
						AddToElementRepository("Fork object", BehaviorPort_Operation_P_P_Factory_Fork_object);
						AddToElementRepository("result", BehaviorPort_Operation_P_P_Factory_result);
					AddToElementRepository("return", BehaviorPort_Operation_P_return);
						AddToElementRepository("LiteralInteger81", BehaviorPort_Operation_P_return_LiteralInteger81);
					AddToElementRepository("pp", BehaviorPort_Operation_P_pp);
					AddToElementRepository("out", BehaviorPort_Operation_P_out);
						AddToElementRepository("LiteralInteger82", BehaviorPort_Operation_P_out_LiteralInteger82);
					AddToElementRepository("P_P", BehaviorPort_Operation_P_P_P);
						AddToElementRepository("result", BehaviorPort_Operation_P_P_P_result);
					AddToElementRepository("Start", BehaviorPort_Operation_P_Start);
				AddToElementRepository("main", BehaviorPort_Operation_main);
					AddToElementRepository("ControlFlow83", BehaviorPort_Operation_main_ControlFlow83);
					AddToElementRepository("s.p", BehaviorPort_Operation_main_s_p);
						AddToElementRepository("s", BehaviorPort_Operation_main_s_p_s);
							AddToElementRepository("LiteralUnlimitedNatural84", BehaviorPort_Operation_main_s_p_s_LiteralUnlimitedNatural84);
							AddToElementRepository("LiteralInteger85", BehaviorPort_Operation_main_s_p_s_LiteralInteger85);
						AddToElementRepository("result", BehaviorPort_Operation_main_s_p_result);
							AddToElementRepository("LiteralUnlimitedNatural86", BehaviorPort_Operation_main_s_p_result_LiteralUnlimitedNatural86);
							AddToElementRepository("LiteralInteger87", BehaviorPort_Operation_main_s_p_result_LiteralInteger87);
					AddToElementRepository("Create S", BehaviorPort_Operation_main_Create_S);
						AddToElementRepository("result", BehaviorPort_Operation_main_Create_S_result);
							AddToElementRepository("LiteralInteger88", BehaviorPort_Operation_main_Create_S_result_LiteralInteger88);
							AddToElementRepository("LiteralUnlimitedNatural89", BehaviorPort_Operation_main_Create_S_result_LiteralUnlimitedNatural89);
					AddToElementRepository("assertP", BehaviorPort_Operation_main_assertP);
						AddToElementRepository("p", BehaviorPort_Operation_main_assertP_p);
							AddToElementRepository("LiteralInteger90", BehaviorPort_Operation_main_assertP_p_LiteralInteger90);
							AddToElementRepository("LiteralInteger91", BehaviorPort_Operation_main_assertP_p_LiteralInteger91);
							AddToElementRepository("LiteralUnlimitedNatural92", BehaviorPort_Operation_main_assertP_p_LiteralUnlimitedNatural92);
					AddToElementRepository("ObjectFlow93", BehaviorPort_Operation_main_ObjectFlow93);
						AddToElementRepository("LiteralInteger94", BehaviorPort_Operation_main_ObjectFlow93_LiteralInteger94);
						AddToElementRepository("LiteralBoolean95", BehaviorPort_Operation_main_ObjectFlow93_LiteralBoolean95);
					AddToElementRepository("Send Start", BehaviorPort_Operation_main_Send_Start);
						AddToElementRepository("target", BehaviorPort_Operation_main_Send_Start_target);
							AddToElementRepository("LiteralInteger96", BehaviorPort_Operation_main_Send_Start_target_LiteralInteger96);
							AddToElementRepository("LiteralUnlimitedNatural97", BehaviorPort_Operation_main_Send_Start_target_LiteralUnlimitedNatural97);
					AddToElementRepository("Fork s.p", BehaviorPort_Operation_main_Fork_s_p);
					AddToElementRepository("ObjectFlow98", BehaviorPort_Operation_main_ObjectFlow98);
						AddToElementRepository("LiteralInteger99", BehaviorPort_Operation_main_ObjectFlow98_LiteralInteger99);
						AddToElementRepository("LiteralBoolean100", BehaviorPort_Operation_main_ObjectFlow98_LiteralBoolean100);
					AddToElementRepository("ObjectFlow101", BehaviorPort_Operation_main_ObjectFlow101);
						AddToElementRepository("LiteralInteger102", BehaviorPort_Operation_main_ObjectFlow101_LiteralInteger102);
						AddToElementRepository("LiteralBoolean103", BehaviorPort_Operation_main_ObjectFlow101_LiteralBoolean103);
					AddToElementRepository("ObjectFlow104", BehaviorPort_Operation_main_ObjectFlow104);
						AddToElementRepository("LiteralBoolean105", BehaviorPort_Operation_main_ObjectFlow104_LiteralBoolean105);
						AddToElementRepository("LiteralInteger106", BehaviorPort_Operation_main_ObjectFlow104_LiteralInteger106);
					AddToElementRepository("ObjectFlow107", BehaviorPort_Operation_main_ObjectFlow107);
						AddToElementRepository("LiteralInteger108", BehaviorPort_Operation_main_ObjectFlow107_LiteralInteger108);
						AddToElementRepository("LiteralBoolean109", BehaviorPort_Operation_main_ObjectFlow107_LiteralBoolean109);
					AddToElementRepository("S()", BehaviorPort_Operation_main_S_);
						AddToElementRepository("target", BehaviorPort_Operation_main_S__target);
							AddToElementRepository("LiteralInteger110", BehaviorPort_Operation_main_S__target_LiteralInteger110);
							AddToElementRepository("LiteralUnlimitedNatural111", BehaviorPort_Operation_main_S__target_LiteralUnlimitedNatural111);
						AddToElementRepository("result", BehaviorPort_Operation_main_S__result);
							AddToElementRepository("LiteralInteger112", BehaviorPort_Operation_main_S__result_LiteralInteger112);
							AddToElementRepository("LiteralUnlimitedNatural113", BehaviorPort_Operation_main_S__result_LiteralUnlimitedNatural113);
							AddToElementRepository("LiteralInteger114", BehaviorPort_Operation_main_S__result_LiteralInteger114);
				AddToElementRepository("C", BehaviorPort_Operation_C);
					AddToElementRepository("C_Factory", BehaviorPort_Operation_C_C_Factory);
						AddToElementRepository("ObjectFlow115", BehaviorPort_Operation_C_C_Factory_ObjectFlow115);
							AddToElementRepository("LiteralBoolean116", BehaviorPort_Operation_C_C_Factory_ObjectFlow115_LiteralBoolean116);
							AddToElementRepository("LiteralInteger117", BehaviorPort_Operation_C_C_Factory_ObjectFlow115_LiteralInteger117);
						AddToElementRepository("Fork object", BehaviorPort_Operation_C_C_Factory_Fork_object);
						AddToElementRepository("result", BehaviorPort_Operation_C_C_Factory_result);
						AddToElementRepository("ObjectFlow118", BehaviorPort_Operation_C_C_Factory_ObjectFlow118);
							AddToElementRepository("LiteralBoolean119", BehaviorPort_Operation_C_C_Factory_ObjectFlow118_LiteralBoolean119);
							AddToElementRepository("LiteralInteger120", BehaviorPort_Operation_C_C_Factory_ObjectFlow118_LiteralInteger120);
						AddToElementRepository("ObjectFlow121", BehaviorPort_Operation_C_C_Factory_ObjectFlow121);
							AddToElementRepository("LiteralBoolean122", BehaviorPort_Operation_C_C_Factory_ObjectFlow121_LiteralBoolean122);
							AddToElementRepository("LiteralInteger123", BehaviorPort_Operation_C_C_Factory_ObjectFlow121_LiteralInteger123);
						AddToElementRepository("Create C", BehaviorPort_Operation_C_C_Factory_Create_C);
							AddToElementRepository("result", BehaviorPort_Operation_C_C_Factory_Create_C_result);
								AddToElementRepository("LiteralInteger124", BehaviorPort_Operation_C_C_Factory_Create_C_result_LiteralInteger124);
								AddToElementRepository("LiteralUnlimitedNatural125", BehaviorPort_Operation_C_C_Factory_Create_C_result_LiteralUnlimitedNatural125);
						AddToElementRepository("Start classifierBehavior", BehaviorPort_Operation_C_C_Factory_Start_classifierBehavior);
							AddToElementRepository("object", BehaviorPort_Operation_C_C_Factory_Start_classifierBehavior_object);
								AddToElementRepository("LiteralInteger126", BehaviorPort_Operation_C_C_Factory_Start_classifierBehavior_object_LiteralInteger126);
								AddToElementRepository("LiteralUnlimitedNatural127", BehaviorPort_Operation_C_C_Factory_Start_classifierBehavior_object_LiteralUnlimitedNatural127);
						AddToElementRepository("ObjectFlow128", BehaviorPort_Operation_C_C_Factory_ObjectFlow128);
							AddToElementRepository("LiteralInteger129", BehaviorPort_Operation_C_C_Factory_ObjectFlow128_LiteralInteger129);
							AddToElementRepository("LiteralBoolean130", BehaviorPort_Operation_C_C_Factory_ObjectFlow128_LiteralBoolean130);
						AddToElementRepository("resultParameterNode", BehaviorPort_Operation_C_C_Factory_resultParameterNode);
							AddToElementRepository("LiteralInteger131", BehaviorPort_Operation_C_C_Factory_resultParameterNode_LiteralInteger131);
						AddToElementRepository("C()", BehaviorPort_Operation_C_C_Factory_C_);
							AddToElementRepository("result", BehaviorPort_Operation_C_C_Factory_C__result);
								AddToElementRepository("LiteralUnlimitedNatural132", BehaviorPort_Operation_C_C_Factory_C__result_LiteralUnlimitedNatural132);
								AddToElementRepository("LiteralInteger133", BehaviorPort_Operation_C_C_Factory_C__result_LiteralInteger133);
								AddToElementRepository("LiteralInteger134", BehaviorPort_Operation_C_C_Factory_C__result_LiteralInteger134);
							AddToElementRepository("target", BehaviorPort_Operation_C_C_Factory_C__target);
								AddToElementRepository("LiteralInteger135", BehaviorPort_Operation_C_C_Factory_C__target_LiteralInteger135);
								AddToElementRepository("LiteralUnlimitedNatural136", BehaviorPort_Operation_C_C_Factory_C__target_LiteralUnlimitedNatural136);
					AddToElementRepository("pc", BehaviorPort_Operation_C_pc);
					AddToElementRepository("C_C", BehaviorPort_Operation_C_C_C);
						AddToElementRepository("result", BehaviorPort_Operation_C_C_C_result);
					AddToElementRepository("I_Realization", BehaviorPort_Operation_C_I_Realization);
					AddToElementRepository("Boolean_or_Boolean_Boolean_Boolean", BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean);
						AddToElementRepository("b", BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean_b);
						AddToElementRepository("result", BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean_result);
						AddToElementRepository("c", BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean_c);
						AddToElementRepository("a", BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean_a);
					AddToElementRepository("C$ClassifierBehavior", BehaviorPort_Operation_C_C_ClassifierBehavior);
						AddToElementRepository("ObjectFlow137", BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow137);
							AddToElementRepository("LiteralInteger138", BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow137_LiteralInteger138);
							AddToElementRepository("LiteralBoolean139", BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow137_LiteralBoolean139);
						AddToElementRepository("ControlFlow140", BehaviorPort_Operation_C_C_ClassifierBehavior_ControlFlow140);
						AddToElementRepository("Fork result", BehaviorPort_Operation_C_C_ClassifierBehavior_Fork_result);
						AddToElementRepository("ObjectFlow141", BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow141);
							AddToElementRepository("LiteralInteger142", BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow141_LiteralInteger142);
							AddToElementRepository("LiteralBoolean143", BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow141_LiteralBoolean143);
						AddToElementRepository("ObjectFlow144", BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow144);
							AddToElementRepository("LiteralBoolean145", BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow144_LiteralBoolean145);
							AddToElementRepository("LiteralInteger146", BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow144_LiteralInteger146);
						AddToElementRepository("InitialNode1", BehaviorPort_Operation_C_C_ClassifierBehavior_InitialNode1);
						AddToElementRepository("ObjectFlow147", BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow147);
							AddToElementRepository("LiteralBoolean148", BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow147_LiteralBoolean148);
							AddToElementRepository("LiteralInteger149", BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow147_LiteralInteger149);
						AddToElementRepository("Call Xor", BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor);
							AddToElementRepository("y", BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_y);
								AddToElementRepository("LiteralInteger150", BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_y_LiteralInteger150);
								AddToElementRepository("LiteralUnlimitedNatural151", BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_y_LiteralUnlimitedNatural151);
							AddToElementRepository("result", BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_result);
								AddToElementRepository("LiteralInteger152", BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_result_LiteralInteger152);
								AddToElementRepository("LiteralInteger153", BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_result_LiteralInteger153);
								AddToElementRepository("LiteralUnlimitedNatural154", BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_result_LiteralUnlimitedNatural154);
							AddToElementRepository("x", BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_x);
								AddToElementRepository("LiteralInteger155", BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_x_LiteralInteger155);
								AddToElementRepository("LiteralUnlimitedNatural156", BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_x_LiteralUnlimitedNatural156);
						AddToElementRepository("ObjectFlow157", BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow157);
							AddToElementRepository("LiteralBoolean158", BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow157_LiteralBoolean158);
							AddToElementRepository("LiteralInteger159", BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow157_LiteralInteger159);
						AddToElementRepository("Accept or()", BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or_);
							AddToElementRepository("b", BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or__b);
								AddToElementRepository("LiteralInteger160", BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or__b_LiteralInteger160);
							AddToElementRepository("returnInformation", BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or__returnInformation);
							AddToElementRepository("a", BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or__a);
								AddToElementRepository("LiteralInteger161", BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or__a_LiteralInteger161);
							AddToElementRepository("CallEventOrTrigger", BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or__CallEventOrTrigger);
						AddToElementRepository("Reply or()", BehaviorPort_Operation_C_C_ClassifierBehavior_Reply_or_);
							AddToElementRepository("r", BehaviorPort_Operation_C_C_ClassifierBehavior_Reply_or__r);
							AddToElementRepository("cr", BehaviorPort_Operation_C_C_ClassifierBehavior_Reply_or__cr);
							AddToElementRepository("returnInformation", BehaviorPort_Operation_C_C_ClassifierBehavior_Reply_or__returnInformation);
						AddToElementRepository("ObjectFlow162", BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow162);
							AddToElementRepository("LiteralInteger163", BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow162_LiteralInteger163);
							AddToElementRepository("LiteralBoolean164", BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow162_LiteralBoolean164);
				AddToElementRepository("S", BehaviorPort_Operation_S);
					AddToElementRepository("p", BehaviorPort_Operation_S_p);
					AddToElementRepository("c", BehaviorPort_Operation_S_c);
					AddToElementRepository("Connector1", BehaviorPort_Operation_S_Connector1);
						AddToElementRepository("ConnectorEnd165", BehaviorPort_Operation_S_Connector1_ConnectorEnd165);
						AddToElementRepository("ConnectorEnd166", BehaviorPort_Operation_S_Connector1_ConnectorEnd166);
					AddToElementRepository("S_S", BehaviorPort_Operation_S_S_S);
						AddToElementRepository("result", BehaviorPort_Operation_S_S_S_result);
				AddToElementRepository("Start", BehaviorPort_Operation_Start);
				AddToElementRepository("I_Usage_P", BehaviorPort_Operation_I_Usage_P);
				AddToElementRepository("assertP", BehaviorPort_Operation_assertP);
					AddToElementRepository("ObjectFlow167", BehaviorPort_Operation_assertP_ObjectFlow167);
						AddToElementRepository("LiteralInteger168", BehaviorPort_Operation_assertP_ObjectFlow167_LiteralInteger168);
						AddToElementRepository("LiteralBoolean169", BehaviorPort_Operation_assertP_ObjectFlow167_LiteralBoolean169);
					AddToElementRepository("ControlFlow170", BehaviorPort_Operation_assertP_ControlFlow170);
					AddToElementRepository("ObjectFlow171", BehaviorPort_Operation_assertP_ObjectFlow171);
						AddToElementRepository("LiteralBoolean172", BehaviorPort_Operation_assertP_ObjectFlow171_LiteralBoolean172);
						AddToElementRepository("LiteralInteger173", BehaviorPort_Operation_assertP_ObjectFlow171_LiteralInteger173);
					AddToElementRepository("ObjectFlow174", BehaviorPort_Operation_assertP_ObjectFlow174);
						AddToElementRepository("LiteralBoolean175", BehaviorPort_Operation_assertP_ObjectFlow174_LiteralBoolean175);
						AddToElementRepository("LiteralInteger176", BehaviorPort_Operation_assertP_ObjectFlow174_LiteralInteger176);
					AddToElementRepository("Fork p", BehaviorPort_Operation_assertP_Fork_p);
					AddToElementRepository("test out", BehaviorPort_Operation_assertP_test_out);
						AddToElementRepository("input", BehaviorPort_Operation_assertP_test_out_input);
							AddToElementRepository("LiteralUnlimitedNatural177", BehaviorPort_Operation_assertP_test_out_input_LiteralUnlimitedNatural177);
							AddToElementRepository("LiteralInteger178", BehaviorPort_Operation_assertP_test_out_input_LiteralInteger178);
							AddToElementRepository("LiteralInteger179", BehaviorPort_Operation_assertP_test_out_input_LiteralInteger179);
					AddToElementRepository("writeLine p.return", BehaviorPort_Operation_assertP_writeLine_p_return);
						AddToElementRepository("errorStatus", BehaviorPort_Operation_assertP_writeLine_p_return_errorStatus);
							AddToElementRepository("LiteralUnlimitedNatural180", BehaviorPort_Operation_assertP_writeLine_p_return_errorStatus_LiteralUnlimitedNatural180);
							AddToElementRepository("LiteralInteger181", BehaviorPort_Operation_assertP_writeLine_p_return_errorStatus_LiteralInteger181);
							AddToElementRepository("LiteralInteger182", BehaviorPort_Operation_assertP_writeLine_p_return_errorStatus_LiteralInteger182);
						AddToElementRepository("value", BehaviorPort_Operation_assertP_writeLine_p_return_value);
							AddToElementRepository("LiteralInteger183", BehaviorPort_Operation_assertP_writeLine_p_return_value_LiteralInteger183);
							AddToElementRepository("LiteralUnlimitedNatural184", BehaviorPort_Operation_assertP_writeLine_p_return_value_LiteralUnlimitedNatural184);
							AddToElementRepository("LiteralInteger185", BehaviorPort_Operation_assertP_writeLine_p_return_value_LiteralInteger185);
					AddToElementRepository("writeLine p.out", BehaviorPort_Operation_assertP_writeLine_p_out);
						AddToElementRepository("value", BehaviorPort_Operation_assertP_writeLine_p_out_value);
							AddToElementRepository("LiteralUnlimitedNatural186", BehaviorPort_Operation_assertP_writeLine_p_out_value_LiteralUnlimitedNatural186);
							AddToElementRepository("LiteralInteger187", BehaviorPort_Operation_assertP_writeLine_p_out_value_LiteralInteger187);
							AddToElementRepository("LiteralInteger188", BehaviorPort_Operation_assertP_writeLine_p_out_value_LiteralInteger188);
						AddToElementRepository("errorStatus", BehaviorPort_Operation_assertP_writeLine_p_out_errorStatus);
							AddToElementRepository("LiteralUnlimitedNatural189", BehaviorPort_Operation_assertP_writeLine_p_out_errorStatus_LiteralUnlimitedNatural189);
							AddToElementRepository("LiteralInteger190", BehaviorPort_Operation_assertP_writeLine_p_out_errorStatus_LiteralInteger190);
							AddToElementRepository("LiteralInteger191", BehaviorPort_Operation_assertP_writeLine_p_out_errorStatus_LiteralInteger191);
					AddToElementRepository("p.out", BehaviorPort_Operation_assertP_p_out);
						AddToElementRepository("result", BehaviorPort_Operation_assertP_p_out_result);
							AddToElementRepository("LiteralInteger192", BehaviorPort_Operation_assertP_p_out_result_LiteralInteger192);
							AddToElementRepository("LiteralUnlimitedNatural193", BehaviorPort_Operation_assertP_p_out_result_LiteralUnlimitedNatural193);
						AddToElementRepository("object", BehaviorPort_Operation_assertP_p_out_object);
							AddToElementRepository("LiteralUnlimitedNatural194", BehaviorPort_Operation_assertP_p_out_object_LiteralUnlimitedNatural194);
							AddToElementRepository("LiteralInteger195", BehaviorPort_Operation_assertP_p_out_object_LiteralInteger195);
					AddToElementRepository("ControlFlow196", BehaviorPort_Operation_assertP_ControlFlow196);
					AddToElementRepository("p", BehaviorPort_Operation_assertP_p);
					AddToElementRepository("ControlFlow197", BehaviorPort_Operation_assertP_ControlFlow197);
					AddToElementRepository("pParameterNode", BehaviorPort_Operation_assertP_pParameterNode);
						AddToElementRepository("LiteralInteger198", BehaviorPort_Operation_assertP_pParameterNode_LiteralInteger198);
					AddToElementRepository("test return", BehaviorPort_Operation_assertP_test_return);
						AddToElementRepository("input", BehaviorPort_Operation_assertP_test_return_input);
							AddToElementRepository("LiteralInteger199", BehaviorPort_Operation_assertP_test_return_input_LiteralInteger199);
							AddToElementRepository("LiteralInteger200", BehaviorPort_Operation_assertP_test_return_input_LiteralInteger200);
							AddToElementRepository("LiteralUnlimitedNatural201", BehaviorPort_Operation_assertP_test_return_input_LiteralUnlimitedNatural201);
					AddToElementRepository("p.out message", BehaviorPort_Operation_assertP_p_out_message);
						AddToElementRepository("LiteralString202", BehaviorPort_Operation_assertP_p_out_message_LiteralString202);
						AddToElementRepository("result", BehaviorPort_Operation_assertP_p_out_message_result);
							AddToElementRepository("LiteralUnlimitedNatural203", BehaviorPort_Operation_assertP_p_out_message_result_LiteralUnlimitedNatural203);
							AddToElementRepository("LiteralInteger204", BehaviorPort_Operation_assertP_p_out_message_result_LiteralInteger204);
					AddToElementRepository("p.return", BehaviorPort_Operation_assertP_p_return);
						AddToElementRepository("object", BehaviorPort_Operation_assertP_p_return_object);
							AddToElementRepository("LiteralInteger205", BehaviorPort_Operation_assertP_p_return_object_LiteralInteger205);
							AddToElementRepository("LiteralUnlimitedNatural206", BehaviorPort_Operation_assertP_p_return_object_LiteralUnlimitedNatural206);
						AddToElementRepository("result", BehaviorPort_Operation_assertP_p_return_result);
							AddToElementRepository("LiteralUnlimitedNatural207", BehaviorPort_Operation_assertP_p_return_result_LiteralUnlimitedNatural207);
							AddToElementRepository("LiteralInteger208", BehaviorPort_Operation_assertP_p_return_result_LiteralInteger208);
					AddToElementRepository("ObjectFlow209", BehaviorPort_Operation_assertP_ObjectFlow209);
						AddToElementRepository("LiteralBoolean210", BehaviorPort_Operation_assertP_ObjectFlow209_LiteralBoolean210);
						AddToElementRepository("LiteralInteger211", BehaviorPort_Operation_assertP_ObjectFlow209_LiteralInteger211);
					AddToElementRepository("ControlFlow212", BehaviorPort_Operation_assertP_ControlFlow212);
					AddToElementRepository("p.return message", BehaviorPort_Operation_assertP_p_return_message);
						AddToElementRepository("LiteralString213", BehaviorPort_Operation_assertP_p_return_message_LiteralString213);
						AddToElementRepository("result", BehaviorPort_Operation_assertP_p_return_message_result);
							AddToElementRepository("LiteralUnlimitedNatural214", BehaviorPort_Operation_assertP_p_return_message_result_LiteralUnlimitedNatural214);
							AddToElementRepository("LiteralInteger215", BehaviorPort_Operation_assertP_p_return_message_result_LiteralInteger215);
					AddToElementRepository("ObjectFlow216", BehaviorPort_Operation_assertP_ObjectFlow216);
						AddToElementRepository("LiteralBoolean217", BehaviorPort_Operation_assertP_ObjectFlow216_LiteralBoolean217);
						AddToElementRepository("LiteralInteger218", BehaviorPort_Operation_assertP_ObjectFlow216_LiteralInteger218);
					AddToElementRepository("ControlFlow219", BehaviorPort_Operation_assertP_ControlFlow219);
					AddToElementRepository("ObjectFlow220", BehaviorPort_Operation_assertP_ObjectFlow220);
						AddToElementRepository("LiteralInteger221", BehaviorPort_Operation_assertP_ObjectFlow220_LiteralInteger221);
						AddToElementRepository("LiteralBoolean222", BehaviorPort_Operation_assertP_ObjectFlow220_LiteralBoolean222);
					AddToElementRepository("testFalse", BehaviorPort_Operation_assertP_testFalse);
						AddToElementRepository("input", BehaviorPort_Operation_assertP_testFalse_input);
					AddToElementRepository("ObjectFlow223", BehaviorPort_Operation_assertP_ObjectFlow223);
						AddToElementRepository("LiteralBoolean224", BehaviorPort_Operation_assertP_ObjectFlow223_LiteralBoolean224);
						AddToElementRepository("LiteralInteger225", BehaviorPort_Operation_assertP_ObjectFlow223_LiteralInteger225);

			// Initialize public members
			/*
			 * Model BehaviorPort_Operation
			 */
			BehaviorPort_Operation.SetName("BehaviorPort_Operation");
			BehaviorPort_Operation.SetVisibility(VisibilityKind.public_);
				// CallEvent CallEventOr
				BehaviorPort_Operation_CallEventOr.SetName("CallEventOr");
				BehaviorPort_Operation_CallEventOr.SetVisibility(VisibilityKind.public_);
				BehaviorPort_Operation_CallEventOr.SetOperation(BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean);
			BehaviorPort_Operation.AddPackagedElement(BehaviorPort_Operation_CallEventOr);
				// Interface I
				BehaviorPort_Operation_I.SetName("I");
				BehaviorPort_Operation_I.SetVisibility(VisibilityKind.public_);
					// Operation Boolean_or_Boolean_Boolean_Boolean
					BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean.SetName("Boolean_or_Boolean_Boolean_Boolean");
					BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean.SetVisibility(VisibilityKind.public_);
						// Parameter a
						BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean_a.SetName("a");
						BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean_a.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean_a.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
					BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean.AddOwnedParameter(BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean_a);
						// Parameter b
						BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean_b.SetName("b");
						BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean_b.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean_b.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
					BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean.AddOwnedParameter(BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean_b);
						// Parameter c
						BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean_c.SetName("c");
						BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean_c.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean_c.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
						BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean_c.SetDirection(ParameterDirectionKind.out_);
					BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean.AddOwnedParameter(BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean_c);
						// Parameter result
						BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean_result.SetName("result");
						BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean_result.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
						BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean_result.SetDirection(ParameterDirectionKind.return_);
					BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean.AddOwnedParameter(BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean_result);
				BehaviorPort_Operation_I.AddOwnedOperation(BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean);
			BehaviorPort_Operation.AddPackagedElement(BehaviorPort_Operation_I);
				// SignalEvent SignalEventStart
				BehaviorPort_Operation_SignalEventStart.SetName("SignalEventStart");
				BehaviorPort_Operation_SignalEventStart.SetVisibility(VisibilityKind.public_);
				BehaviorPort_Operation_SignalEventStart.SetSignal(BehaviorPort_Operation_Start);
			BehaviorPort_Operation.AddPackagedElement(BehaviorPort_Operation_SignalEventStart);
				// Class P
				BehaviorPort_Operation_P.SetName("P");
				BehaviorPort_Operation_P.SetVisibility(VisibilityKind.public_);
				
					// Property out
					BehaviorPort_Operation_P_out.SetName("out");
					BehaviorPort_Operation_P_out.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Operation_P_out.SetLower(0);
					BehaviorPort_Operation_P_out.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
				BehaviorPort_Operation_P.AddOwnedAttribute(BehaviorPort_Operation_P_out);
					// Property return
					BehaviorPort_Operation_P_return.SetName("return");
					BehaviorPort_Operation_P_return.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Operation_P_return.SetLower(0);
					BehaviorPort_Operation_P_return.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
				BehaviorPort_Operation_P.AddOwnedAttribute(BehaviorPort_Operation_P_return);
					// Port pp
					BehaviorPort_Operation_P_pp.SetName("pp");
					BehaviorPort_Operation_P_pp.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Operation_P_pp.SetType(BehaviorPort_Operation_I);
					BehaviorPort_Operation_P_pp.SetAggregation(AggregationKind.composite);
					BehaviorPort_Operation_P_pp.isConjugated = true;;
					BehaviorPort_Operation_P_pp.isService = true;
					BehaviorPort_Operation_P_pp.AddRequired(BehaviorPort_Operation_I);
				BehaviorPort_Operation_P.AddOwnedAttribute(BehaviorPort_Operation_P_pp);
				BehaviorPort_Operation_P.SetClassifierBehavior(BehaviorPort_Operation_P_P_ClassifierBehavior);
					// Activity P$ClassifierBehavior
					BehaviorPort_Operation_P_P_ClassifierBehavior.SetName("P$ClassifierBehavior");
					BehaviorPort_Operation_P_P_ClassifierBehavior.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Operation_P_P_ClassifierBehavior.isReentrant = false;
						// CallOperationAction Call or() via pp
						BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp.SetName("Call or() via pp");
						BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp.SetOnPort(BehaviorPort_Operation_P_pp);
						
							// OutputPin c
							BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_c.SetName("c");
							BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_c.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_c.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
						BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp.AddResult(BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_c);
							// OutputPin result
							BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_result.SetName("result");
							BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_result.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
						BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp.AddResult(BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_result);
						BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp.SetOperation(BehaviorPort_Operation_I_Boolean_or_Boolean_Boolean_Boolean);
							// InputPin target
							BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_target.SetName("target");
							BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_target.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp.SetTarget(BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_target);
							// InputPin a
							BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_a.SetName("a");
							BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_a.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_a.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
						BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp.AddArgument(BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_a);
							// InputPin b
							BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_b.SetName("b");
							BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_b.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_b.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
						BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp.AddArgument(BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_b);
					BehaviorPort_Operation_P_P_ClassifierBehavior.AddNode(BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp);
						// ForkNode ForkNode1
						BehaviorPort_Operation_P_P_ClassifierBehavior_ForkNode1.SetName("ForkNode1");
						BehaviorPort_Operation_P_P_ClassifierBehavior_ForkNode1.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Operation_P_P_ClassifierBehavior.AddNode(BehaviorPort_Operation_P_P_ClassifierBehavior_ForkNode1);
						// ReadSelfAction this
						BehaviorPort_Operation_P_P_ClassifierBehavior_this.SetName("this");
						BehaviorPort_Operation_P_P_ClassifierBehavior_this.SetVisibility(VisibilityKind.public_);
							// OutputPin p
							BehaviorPort_Operation_P_P_ClassifierBehavior_this_p.SetName("p");
							BehaviorPort_Operation_P_P_ClassifierBehavior_this_p.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_P_P_ClassifierBehavior_this_p.SetType(BehaviorPort_Operation_P);
						BehaviorPort_Operation_P_P_ClassifierBehavior_this.SetResult(BehaviorPort_Operation_P_P_ClassifierBehavior_this_p);
					BehaviorPort_Operation_P_P_ClassifierBehavior.AddNode(BehaviorPort_Operation_P_P_ClassifierBehavior_this);
						// ForkNode ForkNode2
						BehaviorPort_Operation_P_P_ClassifierBehavior_ForkNode2.SetName("ForkNode2");
						BehaviorPort_Operation_P_P_ClassifierBehavior_ForkNode2.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Operation_P_P_ClassifierBehavior.AddNode(BehaviorPort_Operation_P_P_ClassifierBehavior_ForkNode2);
						// InitialNode InitialNode1
						BehaviorPort_Operation_P_P_ClassifierBehavior_InitialNode1.SetName("InitialNode1");
						BehaviorPort_Operation_P_P_ClassifierBehavior_InitialNode1.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Operation_P_P_ClassifierBehavior.AddNode(BehaviorPort_Operation_P_P_ClassifierBehavior_InitialNode1);
						// AddStructuralFeatureValueAction set out
						BehaviorPort_Operation_P_P_ClassifierBehavior_set_out.SetName("set out");
						BehaviorPort_Operation_P_P_ClassifierBehavior_set_out.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_P_P_ClassifierBehavior_set_out.SetStructuralFeature(BehaviorPort_Operation_P_out);
							// InputPin object
							BehaviorPort_Operation_P_P_ClassifierBehavior_set_out_object.SetName("object");
							BehaviorPort_Operation_P_P_ClassifierBehavior_set_out_object.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_P_P_ClassifierBehavior_set_out_object.SetType(BehaviorPort_Operation_P);
						BehaviorPort_Operation_P_P_ClassifierBehavior_set_out.SetObject(BehaviorPort_Operation_P_P_ClassifierBehavior_set_out_object);
							// InputPin value
							BehaviorPort_Operation_P_P_ClassifierBehavior_set_out_value.SetName("value");
							BehaviorPort_Operation_P_P_ClassifierBehavior_set_out_value.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_P_P_ClassifierBehavior_set_out_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
						BehaviorPort_Operation_P_P_ClassifierBehavior_set_out.SetValue(BehaviorPort_Operation_P_P_ClassifierBehavior_set_out_value);
							// OutputPin result
							BehaviorPort_Operation_P_P_ClassifierBehavior_set_out_result.SetName("result");
							BehaviorPort_Operation_P_P_ClassifierBehavior_set_out_result.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_P_P_ClassifierBehavior_set_out_result.SetType(BehaviorPort_Operation_P);
						BehaviorPort_Operation_P_P_ClassifierBehavior_set_out.SetResult(BehaviorPort_Operation_P_P_ClassifierBehavior_set_out_result);
						BehaviorPort_Operation_P_P_ClassifierBehavior_set_out.SetIsReplaceAll(true);
					BehaviorPort_Operation_P_P_ClassifierBehavior.AddNode(BehaviorPort_Operation_P_P_ClassifierBehavior_set_out);
						// AcceptEventAction Accept Start
						BehaviorPort_Operation_P_P_ClassifierBehavior_Accept_Start.SetName("Accept Start");
						BehaviorPort_Operation_P_P_ClassifierBehavior_Accept_Start.SetVisibility(VisibilityKind.package_);
							// OutputPin result
							BehaviorPort_Operation_P_P_ClassifierBehavior_Accept_Start_result.SetName("result");
							BehaviorPort_Operation_P_P_ClassifierBehavior_Accept_Start_result.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_P_P_ClassifierBehavior_Accept_Start_result.SetType(BehaviorPort_Operation_Start);
						BehaviorPort_Operation_P_P_ClassifierBehavior_Accept_Start.AddResult(BehaviorPort_Operation_P_P_ClassifierBehavior_Accept_Start_result);
							// Trigger SignalEventStartTrigger
							BehaviorPort_Operation_P_P_ClassifierBehavior_Accept_Start_SignalEventStartTrigger.SetName("SignalEventStartTrigger");
							BehaviorPort_Operation_P_P_ClassifierBehavior_Accept_Start_SignalEventStartTrigger.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_P_P_ClassifierBehavior_Accept_Start_SignalEventStartTrigger.SetEvent(BehaviorPort_Operation_SignalEventStart);
						BehaviorPort_Operation_P_P_ClassifierBehavior_Accept_Start.AddTrigger(BehaviorPort_Operation_P_P_ClassifierBehavior_Accept_Start_SignalEventStartTrigger);
					BehaviorPort_Operation_P_P_ClassifierBehavior.AddNode(BehaviorPort_Operation_P_P_ClassifierBehavior_Accept_Start);
						// ValueSpecificationAction true
						BehaviorPort_Operation_P_P_ClassifierBehavior_true.SetName("true");
						BehaviorPort_Operation_P_P_ClassifierBehavior_true.SetVisibility(VisibilityKind.public_);
							// LiteralBoolean LiteralBoolean49
							BehaviorPort_Operation_P_P_ClassifierBehavior_true_LiteralBoolean49.SetName("LiteralBoolean49");
							BehaviorPort_Operation_P_P_ClassifierBehavior_true_LiteralBoolean49.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_P_P_ClassifierBehavior_true_LiteralBoolean49.SetValue(true);
						BehaviorPort_Operation_P_P_ClassifierBehavior_true.SetValue(BehaviorPort_Operation_P_P_ClassifierBehavior_true_LiteralBoolean49);
							// OutputPin result
							BehaviorPort_Operation_P_P_ClassifierBehavior_true_result.SetName("result");
							BehaviorPort_Operation_P_P_ClassifierBehavior_true_result.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_P_P_ClassifierBehavior_true_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
						BehaviorPort_Operation_P_P_ClassifierBehavior_true.SetResult(BehaviorPort_Operation_P_P_ClassifierBehavior_true_result);
					BehaviorPort_Operation_P_P_ClassifierBehavior.AddNode(BehaviorPort_Operation_P_P_ClassifierBehavior_true);
						// AddStructuralFeatureValueAction set return
						BehaviorPort_Operation_P_P_ClassifierBehavior_set_return.SetName("set return");
						BehaviorPort_Operation_P_P_ClassifierBehavior_set_return.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_P_P_ClassifierBehavior_set_return.SetStructuralFeature(BehaviorPort_Operation_P_return);
							// InputPin object
							BehaviorPort_Operation_P_P_ClassifierBehavior_set_return_object.SetName("object");
							BehaviorPort_Operation_P_P_ClassifierBehavior_set_return_object.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_P_P_ClassifierBehavior_set_return_object.SetType(BehaviorPort_Operation_P);
						BehaviorPort_Operation_P_P_ClassifierBehavior_set_return.SetObject(BehaviorPort_Operation_P_P_ClassifierBehavior_set_return_object);
							// InputPin value
							BehaviorPort_Operation_P_P_ClassifierBehavior_set_return_value.SetName("value");
							BehaviorPort_Operation_P_P_ClassifierBehavior_set_return_value.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_P_P_ClassifierBehavior_set_return_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
						BehaviorPort_Operation_P_P_ClassifierBehavior_set_return.SetValue(BehaviorPort_Operation_P_P_ClassifierBehavior_set_return_value);
							// OutputPin result
							BehaviorPort_Operation_P_P_ClassifierBehavior_set_return_result.SetName("result");
							BehaviorPort_Operation_P_P_ClassifierBehavior_set_return_result.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_P_P_ClassifierBehavior_set_return_result.SetType(BehaviorPort_Operation_P);
						BehaviorPort_Operation_P_P_ClassifierBehavior_set_return.SetResult(BehaviorPort_Operation_P_P_ClassifierBehavior_set_return_result);
					BehaviorPort_Operation_P_P_ClassifierBehavior.AddNode(BehaviorPort_Operation_P_P_ClassifierBehavior_set_return);
						// ObjectFlow ObjectFlow0 from ForkNode2 to b
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow0.SetName("ObjectFlow0");
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow0.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow0.SetSource(BehaviorPort_Operation_P_P_ClassifierBehavior_ForkNode2);
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow0.SetTarget(BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_b);
							// LiteralBoolean LiteralBoolean1
							BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow0_LiteralBoolean1.SetName("LiteralBoolean1");
							BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow0_LiteralBoolean1.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow0_LiteralBoolean1.SetValue(true);
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow0.SetGuard(BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow0_LiteralBoolean1);
					BehaviorPort_Operation_P_P_ClassifierBehavior.AddEdge(BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow0);
						// ObjectFlow ObjectFlow37 from result to ForkNode2
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow37.SetName("ObjectFlow37");
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow37.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow37.SetSource(BehaviorPort_Operation_P_P_ClassifierBehavior_true_result);
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow37.SetTarget(BehaviorPort_Operation_P_P_ClassifierBehavior_ForkNode2);
							// LiteralBoolean LiteralBoolean39
							BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow37_LiteralBoolean39.SetName("LiteralBoolean39");
							BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow37_LiteralBoolean39.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow37_LiteralBoolean39.SetValue(true);
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow37.SetGuard(BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow37_LiteralBoolean39);
					BehaviorPort_Operation_P_P_ClassifierBehavior.AddEdge(BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow37);
						// ControlFlow ControlFlow40 from Accept Start to this
						BehaviorPort_Operation_P_P_ClassifierBehavior_ControlFlow40.SetName("ControlFlow40");
						BehaviorPort_Operation_P_P_ClassifierBehavior_ControlFlow40.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_P_P_ClassifierBehavior_ControlFlow40.SetSource(BehaviorPort_Operation_P_P_ClassifierBehavior_Accept_Start);
						BehaviorPort_Operation_P_P_ClassifierBehavior_ControlFlow40.SetTarget(BehaviorPort_Operation_P_P_ClassifierBehavior_this);
					BehaviorPort_Operation_P_P_ClassifierBehavior.AddEdge(BehaviorPort_Operation_P_P_ClassifierBehavior_ControlFlow40);
						// ObjectFlow ObjectFlow3 from ForkNode1 to object
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow3.SetName("ObjectFlow3");
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow3.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow3.SetSource(BehaviorPort_Operation_P_P_ClassifierBehavior_ForkNode1);
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow3.SetTarget(BehaviorPort_Operation_P_P_ClassifierBehavior_set_return_object);
							// LiteralBoolean LiteralBoolean5
							BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow3_LiteralBoolean5.SetName("LiteralBoolean5");
							BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow3_LiteralBoolean5.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow3_LiteralBoolean5.SetValue(true);
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow3.SetGuard(BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow3_LiteralBoolean5);
					BehaviorPort_Operation_P_P_ClassifierBehavior.AddEdge(BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow3);
						// ObjectFlow ObjectFlow41 from p to ForkNode1
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow41.SetName("ObjectFlow41");
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow41.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow41.SetSource(BehaviorPort_Operation_P_P_ClassifierBehavior_this_p);
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow41.SetTarget(BehaviorPort_Operation_P_P_ClassifierBehavior_ForkNode1);
							// LiteralBoolean LiteralBoolean43
							BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow41_LiteralBoolean43.SetName("LiteralBoolean43");
							BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow41_LiteralBoolean43.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow41_LiteralBoolean43.SetValue(true);
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow41.SetGuard(BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow41_LiteralBoolean43);
					BehaviorPort_Operation_P_P_ClassifierBehavior.AddEdge(BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow41);
						// ControlFlow ControlFlow6 from InitialNode1 to Accept Start
						BehaviorPort_Operation_P_P_ClassifierBehavior_ControlFlow6.SetName("ControlFlow6");
						BehaviorPort_Operation_P_P_ClassifierBehavior_ControlFlow6.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_P_P_ClassifierBehavior_ControlFlow6.SetSource(BehaviorPort_Operation_P_P_ClassifierBehavior_InitialNode1);
						BehaviorPort_Operation_P_P_ClassifierBehavior_ControlFlow6.SetTarget(BehaviorPort_Operation_P_P_ClassifierBehavior_Accept_Start);
					BehaviorPort_Operation_P_P_ClassifierBehavior.AddEdge(BehaviorPort_Operation_P_P_ClassifierBehavior_ControlFlow6);
						// ObjectFlow ObjectFlow7 from ForkNode2 to a
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow7.SetName("ObjectFlow7");
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow7.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow7.SetSource(BehaviorPort_Operation_P_P_ClassifierBehavior_ForkNode2);
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow7.SetTarget(BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_a);
							// LiteralBoolean LiteralBoolean9
							BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow7_LiteralBoolean9.SetName("LiteralBoolean9");
							BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow7_LiteralBoolean9.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow7_LiteralBoolean9.SetValue(true);
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow7.SetGuard(BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow7_LiteralBoolean9);
					BehaviorPort_Operation_P_P_ClassifierBehavior.AddEdge(BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow7);
						// ObjectFlow ObjectFlow10 from ForkNode1 to object
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow10.SetName("ObjectFlow10");
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow10.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow10.SetSource(BehaviorPort_Operation_P_P_ClassifierBehavior_ForkNode1);
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow10.SetTarget(BehaviorPort_Operation_P_P_ClassifierBehavior_set_out_object);
							// LiteralBoolean LiteralBoolean11
							BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow10_LiteralBoolean11.SetName("LiteralBoolean11");
							BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow10_LiteralBoolean11.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow10_LiteralBoolean11.SetValue(true);
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow10.SetGuard(BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow10_LiteralBoolean11);
					BehaviorPort_Operation_P_P_ClassifierBehavior.AddEdge(BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow10);
						// ObjectFlow ObjectFlow19 from ForkNode1 to target
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow19.SetName("ObjectFlow19");
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow19.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow19.SetSource(BehaviorPort_Operation_P_P_ClassifierBehavior_ForkNode1);
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow19.SetTarget(BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_target);
							// LiteralBoolean LiteralBoolean21
							BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow19_LiteralBoolean21.SetName("LiteralBoolean21");
							BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow19_LiteralBoolean21.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow19_LiteralBoolean21.SetValue(true);
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow19.SetGuard(BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow19_LiteralBoolean21);
					BehaviorPort_Operation_P_P_ClassifierBehavior.AddEdge(BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow19);
						// ObjectFlow ObjectFlow22 from result to value
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow22.SetName("ObjectFlow22");
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow22.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow22.SetSource(BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_result);
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow22.SetTarget(BehaviorPort_Operation_P_P_ClassifierBehavior_set_return_value);
							// LiteralBoolean LiteralBoolean23
							BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow22_LiteralBoolean23.SetName("LiteralBoolean23");
							BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow22_LiteralBoolean23.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow22_LiteralBoolean23.SetValue(true);
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow22.SetGuard(BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow22_LiteralBoolean23);
					BehaviorPort_Operation_P_P_ClassifierBehavior.AddEdge(BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow22);
						// ObjectFlow ObjectFlow56 from c to value
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow56.SetName("ObjectFlow56");
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow56.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow56.SetSource(BehaviorPort_Operation_P_P_ClassifierBehavior_Call_or_via_pp_c);
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow56.SetTarget(BehaviorPort_Operation_P_P_ClassifierBehavior_set_out_value);
							// LiteralBoolean LiteralBoolean58
							BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow56_LiteralBoolean58.SetName("LiteralBoolean58");
							BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow56_LiteralBoolean58.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow56_LiteralBoolean58.SetValue(true);
						BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow56.SetGuard(BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow56_LiteralBoolean58);
					BehaviorPort_Operation_P_P_ClassifierBehavior.AddEdge(BehaviorPort_Operation_P_P_ClassifierBehavior_ObjectFlow56);
				BehaviorPort_Operation_P.AddOwnedBehavior(BehaviorPort_Operation_P_P_ClassifierBehavior);
					// Activity P_Factory
					BehaviorPort_Operation_P_P_Factory.SetName("P_Factory");
					BehaviorPort_Operation_P_P_Factory.SetVisibility(VisibilityKind.public_);
					
						// Parameter result
						BehaviorPort_Operation_P_P_Factory_result.SetName("result");
						BehaviorPort_Operation_P_P_Factory_result.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_P_P_Factory_result.SetType(BehaviorPort_Operation_P);
						BehaviorPort_Operation_P_P_Factory_result.SetDirection(ParameterDirectionKind.return_);
					BehaviorPort_Operation_P_P_Factory.AddOwnedParameter(BehaviorPort_Operation_P_P_Factory_result);
						// CreateObjectAction Create P
						BehaviorPort_Operation_P_P_Factory_Create_P.SetName("Create P");
						BehaviorPort_Operation_P_P_Factory_Create_P.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_P_P_Factory_Create_P.SetClassifier(BehaviorPort_Operation_P);
							// OutputPin result
							BehaviorPort_Operation_P_P_Factory_Create_P_result.SetName("result");
							BehaviorPort_Operation_P_P_Factory_Create_P_result.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_P_P_Factory_Create_P_result.SetType(BehaviorPort_Operation_P);
						BehaviorPort_Operation_P_P_Factory_Create_P.SetResult(BehaviorPort_Operation_P_P_Factory_Create_P_result);
					BehaviorPort_Operation_P_P_Factory.AddNode(BehaviorPort_Operation_P_P_Factory_Create_P);
						// CallOperationAction P()
						BehaviorPort_Operation_P_P_Factory_P_.SetName("P()");
						BehaviorPort_Operation_P_P_Factory_P_.SetVisibility(VisibilityKind.public_);
						
							// OutputPin result
							BehaviorPort_Operation_P_P_Factory_P__result.SetName("result");
							BehaviorPort_Operation_P_P_Factory_P__result.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_P_P_Factory_P__result.SetType(BehaviorPort_Operation_P);
						BehaviorPort_Operation_P_P_Factory_P_.AddResult(BehaviorPort_Operation_P_P_Factory_P__result);
						BehaviorPort_Operation_P_P_Factory_P_.SetOperation(BehaviorPort_Operation_P_P_P);
							// InputPin target
							BehaviorPort_Operation_P_P_Factory_P__target.SetName("target");
							BehaviorPort_Operation_P_P_Factory_P__target.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_P_P_Factory_P__target.SetType(BehaviorPort_Operation_P);
						BehaviorPort_Operation_P_P_Factory_P_.SetTarget(BehaviorPort_Operation_P_P_Factory_P__target);
					BehaviorPort_Operation_P_P_Factory.AddNode(BehaviorPort_Operation_P_P_Factory_P_);
						// ActivityParameterNode resultParameterNode
						BehaviorPort_Operation_P_P_Factory_resultParameterNode.SetName("resultParameterNode");
						BehaviorPort_Operation_P_P_Factory_resultParameterNode.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_P_P_Factory_resultParameterNode.SetParameter(BehaviorPort_Operation_P_P_Factory_result);
					BehaviorPort_Operation_P_P_Factory.AddNode(BehaviorPort_Operation_P_P_Factory_resultParameterNode);
						// StartObjectBehaviorAction Start classifierBehavior
						BehaviorPort_Operation_P_P_Factory_Start_classifierBehavior.SetName("Start classifierBehavior");
						BehaviorPort_Operation_P_P_Factory_Start_classifierBehavior.SetVisibility(VisibilityKind.public_);
							// InputPin object
							BehaviorPort_Operation_P_P_Factory_Start_classifierBehavior_object.SetName("object");
							BehaviorPort_Operation_P_P_Factory_Start_classifierBehavior_object.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_P_P_Factory_Start_classifierBehavior_object.SetType(BehaviorPort_Operation_P);
						BehaviorPort_Operation_P_P_Factory_Start_classifierBehavior.SetObject(BehaviorPort_Operation_P_P_Factory_Start_classifierBehavior_object);
					BehaviorPort_Operation_P_P_Factory.AddNode(BehaviorPort_Operation_P_P_Factory_Start_classifierBehavior);
						// ForkNode Fork object
						BehaviorPort_Operation_P_P_Factory_Fork_object.SetName("Fork object");
						BehaviorPort_Operation_P_P_Factory_Fork_object.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Operation_P_P_Factory.AddNode(BehaviorPort_Operation_P_P_Factory_Fork_object);
						// ObjectFlow ObjectFlow59 from Fork object to resultParameterNode
						BehaviorPort_Operation_P_P_Factory_ObjectFlow59.SetName("ObjectFlow59");
						BehaviorPort_Operation_P_P_Factory_ObjectFlow59.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_P_P_Factory_ObjectFlow59.SetSource(BehaviorPort_Operation_P_P_Factory_Fork_object);
						BehaviorPort_Operation_P_P_Factory_ObjectFlow59.SetTarget(BehaviorPort_Operation_P_P_Factory_resultParameterNode);
							// LiteralBoolean LiteralBoolean61
							BehaviorPort_Operation_P_P_Factory_ObjectFlow59_LiteralBoolean61.SetName("LiteralBoolean61");
							BehaviorPort_Operation_P_P_Factory_ObjectFlow59_LiteralBoolean61.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_P_P_Factory_ObjectFlow59_LiteralBoolean61.SetValue(true);
						BehaviorPort_Operation_P_P_Factory_ObjectFlow59.SetGuard(BehaviorPort_Operation_P_P_Factory_ObjectFlow59_LiteralBoolean61);
					BehaviorPort_Operation_P_P_Factory.AddEdge(BehaviorPort_Operation_P_P_Factory_ObjectFlow59);
						// ObjectFlow ObjectFlow64 from result to target
						BehaviorPort_Operation_P_P_Factory_ObjectFlow64.SetName("ObjectFlow64");
						BehaviorPort_Operation_P_P_Factory_ObjectFlow64.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_P_P_Factory_ObjectFlow64.SetSource(BehaviorPort_Operation_P_P_Factory_Create_P_result);
						BehaviorPort_Operation_P_P_Factory_ObjectFlow64.SetTarget(BehaviorPort_Operation_P_P_Factory_P__target);
							// LiteralBoolean LiteralBoolean66
							BehaviorPort_Operation_P_P_Factory_ObjectFlow64_LiteralBoolean66.SetName("LiteralBoolean66");
							BehaviorPort_Operation_P_P_Factory_ObjectFlow64_LiteralBoolean66.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_P_P_Factory_ObjectFlow64_LiteralBoolean66.SetValue(true);
						BehaviorPort_Operation_P_P_Factory_ObjectFlow64.SetGuard(BehaviorPort_Operation_P_P_Factory_ObjectFlow64_LiteralBoolean66);
					BehaviorPort_Operation_P_P_Factory.AddEdge(BehaviorPort_Operation_P_P_Factory_ObjectFlow64);
						// ObjectFlow ObjectFlow72 from result to Fork object
						BehaviorPort_Operation_P_P_Factory_ObjectFlow72.SetName("ObjectFlow72");
						BehaviorPort_Operation_P_P_Factory_ObjectFlow72.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_P_P_Factory_ObjectFlow72.SetSource(BehaviorPort_Operation_P_P_Factory_P__result);
						BehaviorPort_Operation_P_P_Factory_ObjectFlow72.SetTarget(BehaviorPort_Operation_P_P_Factory_Fork_object);
							// LiteralBoolean LiteralBoolean73
							BehaviorPort_Operation_P_P_Factory_ObjectFlow72_LiteralBoolean73.SetName("LiteralBoolean73");
							BehaviorPort_Operation_P_P_Factory_ObjectFlow72_LiteralBoolean73.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_P_P_Factory_ObjectFlow72_LiteralBoolean73.SetValue(true);
						BehaviorPort_Operation_P_P_Factory_ObjectFlow72.SetGuard(BehaviorPort_Operation_P_P_Factory_ObjectFlow72_LiteralBoolean73);
					BehaviorPort_Operation_P_P_Factory.AddEdge(BehaviorPort_Operation_P_P_Factory_ObjectFlow72);
						// ObjectFlow ObjectFlow78 from Fork object to object
						BehaviorPort_Operation_P_P_Factory_ObjectFlow78.SetName("ObjectFlow78");
						BehaviorPort_Operation_P_P_Factory_ObjectFlow78.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_P_P_Factory_ObjectFlow78.SetSource(BehaviorPort_Operation_P_P_Factory_Fork_object);
						BehaviorPort_Operation_P_P_Factory_ObjectFlow78.SetTarget(BehaviorPort_Operation_P_P_Factory_Start_classifierBehavior_object);
							// LiteralBoolean LiteralBoolean79
							BehaviorPort_Operation_P_P_Factory_ObjectFlow78_LiteralBoolean79.SetName("LiteralBoolean79");
							BehaviorPort_Operation_P_P_Factory_ObjectFlow78_LiteralBoolean79.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_P_P_Factory_ObjectFlow78_LiteralBoolean79.SetValue(true);
						BehaviorPort_Operation_P_P_Factory_ObjectFlow78.SetGuard(BehaviorPort_Operation_P_P_Factory_ObjectFlow78_LiteralBoolean79);
					BehaviorPort_Operation_P_P_Factory.AddEdge(BehaviorPort_Operation_P_P_Factory_ObjectFlow78);
				BehaviorPort_Operation_P.AddOwnedBehavior(BehaviorPort_Operation_P_P_Factory);
				
				BehaviorPort_Operation_P.SetIsActive(true);
					// Operation P_P
					BehaviorPort_Operation_P_P_P.SetName("P_P");
					BehaviorPort_Operation_P_P_P.SetVisibility(VisibilityKind.public_);
						// Parameter result
						BehaviorPort_Operation_P_P_P_result.SetName("result");
						BehaviorPort_Operation_P_P_P_result.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_P_P_P_result.SetType(BehaviorPort_Operation_P);
						BehaviorPort_Operation_P_P_P_result.SetDirection(ParameterDirectionKind.return_);
					BehaviorPort_Operation_P_P_P.AddOwnedParameter(BehaviorPort_Operation_P_P_P_result);
					BehaviorPort_Operation_P_P_P.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				BehaviorPort_Operation_P.AddOwnedOperation(BehaviorPort_Operation_P_P_P);
					// Reception Start
					BehaviorPort_Operation_P_Start.SetName("Start");
					BehaviorPort_Operation_P_Start.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Operation_P_Start.SetSignal(BehaviorPort_Operation_Start);
				BehaviorPort_Operation_P.AddOwnedReception(BehaviorPort_Operation_P_Start);
			BehaviorPort_Operation.AddPackagedElement(BehaviorPort_Operation_P);
				// Activity main
				BehaviorPort_Operation_main.SetName("main");
				BehaviorPort_Operation_main.SetVisibility(VisibilityKind.public_);
					// ReadStructuralFeatureAction s.p
					BehaviorPort_Operation_main_s_p.SetName("s.p");
					BehaviorPort_Operation_main_s_p.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Operation_main_s_p.SetStructuralFeature(BehaviorPort_Operation_S_p);
						// InputPin s
						BehaviorPort_Operation_main_s_p_s.SetName("s");
						BehaviorPort_Operation_main_s_p_s.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_main_s_p_s.SetType(BehaviorPort_Operation_S);
					BehaviorPort_Operation_main_s_p.SetObject(BehaviorPort_Operation_main_s_p_s);
						// OutputPin result
						BehaviorPort_Operation_main_s_p_result.SetName("result");
						BehaviorPort_Operation_main_s_p_result.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_main_s_p_result.SetType(BehaviorPort_Operation_P);
					BehaviorPort_Operation_main_s_p.SetResult(BehaviorPort_Operation_main_s_p_result);
				BehaviorPort_Operation_main.AddNode(BehaviorPort_Operation_main_s_p);
					// CreateObjectAction Create S
					BehaviorPort_Operation_main_Create_S.SetName("Create S");
					BehaviorPort_Operation_main_Create_S.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Operation_main_Create_S.SetClassifier(BehaviorPort_Operation_S);
						// OutputPin result
						BehaviorPort_Operation_main_Create_S_result.SetName("result");
						BehaviorPort_Operation_main_Create_S_result.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_main_Create_S_result.SetType(BehaviorPort_Operation_S);
					BehaviorPort_Operation_main_Create_S.SetResult(BehaviorPort_Operation_main_Create_S_result);
				BehaviorPort_Operation_main.AddNode(BehaviorPort_Operation_main_Create_S);
					// CallBehaviorAction assertP
					BehaviorPort_Operation_main_assertP.SetName("assertP");
					BehaviorPort_Operation_main_assertP.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Operation_main_assertP.SetBehavior(BehaviorPort_Operation_assertP);
						// InputPin p
						BehaviorPort_Operation_main_assertP_p.SetName("p");
						BehaviorPort_Operation_main_assertP_p.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_main_assertP_p.SetType(BehaviorPort_Operation_P);
					BehaviorPort_Operation_main_assertP.AddArgument(BehaviorPort_Operation_main_assertP_p);
				BehaviorPort_Operation_main.AddNode(BehaviorPort_Operation_main_assertP);
					// SendSignalAction Send Start
					BehaviorPort_Operation_main_Send_Start.SetName("Send Start");
					BehaviorPort_Operation_main_Send_Start.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Operation_main_Send_Start.SetSignal(BehaviorPort_Operation_Start);
						// InputPin target
						BehaviorPort_Operation_main_Send_Start_target.SetName("target");
						BehaviorPort_Operation_main_Send_Start_target.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_main_Send_Start_target.SetType(BehaviorPort_Operation_P);
					BehaviorPort_Operation_main_Send_Start.SetTarget(BehaviorPort_Operation_main_Send_Start_target);
				BehaviorPort_Operation_main.AddNode(BehaviorPort_Operation_main_Send_Start);
					// ForkNode Fork s.p
					BehaviorPort_Operation_main_Fork_s_p.SetName("Fork s.p");
					BehaviorPort_Operation_main_Fork_s_p.SetVisibility(VisibilityKind.public_);
				BehaviorPort_Operation_main.AddNode(BehaviorPort_Operation_main_Fork_s_p);
					// CallOperationAction S()
					BehaviorPort_Operation_main_S_.SetName("S()");
					BehaviorPort_Operation_main_S_.SetVisibility(VisibilityKind.public_);
					
						// OutputPin result
						BehaviorPort_Operation_main_S__result.SetName("result");
						BehaviorPort_Operation_main_S__result.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_main_S__result.SetType(BehaviorPort_Operation_S);
					BehaviorPort_Operation_main_S_.AddResult(BehaviorPort_Operation_main_S__result);
					BehaviorPort_Operation_main_S_.SetOperation(BehaviorPort_Operation_S_S_S);
						// InputPin target
						BehaviorPort_Operation_main_S__target.SetName("target");
						BehaviorPort_Operation_main_S__target.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_main_S__target.SetType(BehaviorPort_Operation_S);
					BehaviorPort_Operation_main_S_.SetTarget(BehaviorPort_Operation_main_S__target);
				BehaviorPort_Operation_main.AddNode(BehaviorPort_Operation_main_S_);
					// ControlFlow ControlFlow83 from Send Start to assertP
					BehaviorPort_Operation_main_ControlFlow83.SetName("ControlFlow83");
					BehaviorPort_Operation_main_ControlFlow83.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Operation_main_ControlFlow83.SetSource(BehaviorPort_Operation_main_Send_Start);
					BehaviorPort_Operation_main_ControlFlow83.SetTarget(BehaviorPort_Operation_main_assertP);
				BehaviorPort_Operation_main.AddEdge(BehaviorPort_Operation_main_ControlFlow83);
					// ObjectFlow ObjectFlow93 from result to target
					BehaviorPort_Operation_main_ObjectFlow93.SetName("ObjectFlow93");
					BehaviorPort_Operation_main_ObjectFlow93.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Operation_main_ObjectFlow93.SetSource(BehaviorPort_Operation_main_Create_S_result);
					BehaviorPort_Operation_main_ObjectFlow93.SetTarget(BehaviorPort_Operation_main_S__target);
						// LiteralBoolean LiteralBoolean95
						BehaviorPort_Operation_main_ObjectFlow93_LiteralBoolean95.SetName("LiteralBoolean95");
						BehaviorPort_Operation_main_ObjectFlow93_LiteralBoolean95.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_main_ObjectFlow93_LiteralBoolean95.SetValue(true);
					BehaviorPort_Operation_main_ObjectFlow93.SetGuard(BehaviorPort_Operation_main_ObjectFlow93_LiteralBoolean95);
				BehaviorPort_Operation_main.AddEdge(BehaviorPort_Operation_main_ObjectFlow93);
					// ObjectFlow ObjectFlow98 from result to Fork s.p
					BehaviorPort_Operation_main_ObjectFlow98.SetName("ObjectFlow98");
					BehaviorPort_Operation_main_ObjectFlow98.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Operation_main_ObjectFlow98.SetSource(BehaviorPort_Operation_main_s_p_result);
					BehaviorPort_Operation_main_ObjectFlow98.SetTarget(BehaviorPort_Operation_main_Fork_s_p);
						// LiteralBoolean LiteralBoolean100
						BehaviorPort_Operation_main_ObjectFlow98_LiteralBoolean100.SetName("LiteralBoolean100");
						BehaviorPort_Operation_main_ObjectFlow98_LiteralBoolean100.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_main_ObjectFlow98_LiteralBoolean100.SetValue(true);
					BehaviorPort_Operation_main_ObjectFlow98.SetGuard(BehaviorPort_Operation_main_ObjectFlow98_LiteralBoolean100);
				BehaviorPort_Operation_main.AddEdge(BehaviorPort_Operation_main_ObjectFlow98);
					// ObjectFlow ObjectFlow101 from result to s
					BehaviorPort_Operation_main_ObjectFlow101.SetName("ObjectFlow101");
					BehaviorPort_Operation_main_ObjectFlow101.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Operation_main_ObjectFlow101.SetSource(BehaviorPort_Operation_main_S__result);
					BehaviorPort_Operation_main_ObjectFlow101.SetTarget(BehaviorPort_Operation_main_s_p_s);
						// LiteralBoolean LiteralBoolean103
						BehaviorPort_Operation_main_ObjectFlow101_LiteralBoolean103.SetName("LiteralBoolean103");
						BehaviorPort_Operation_main_ObjectFlow101_LiteralBoolean103.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_main_ObjectFlow101_LiteralBoolean103.SetValue(true);
					BehaviorPort_Operation_main_ObjectFlow101.SetGuard(BehaviorPort_Operation_main_ObjectFlow101_LiteralBoolean103);
				BehaviorPort_Operation_main.AddEdge(BehaviorPort_Operation_main_ObjectFlow101);
					// ObjectFlow ObjectFlow104 from Fork s.p to target
					BehaviorPort_Operation_main_ObjectFlow104.SetName("ObjectFlow104");
					BehaviorPort_Operation_main_ObjectFlow104.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Operation_main_ObjectFlow104.SetSource(BehaviorPort_Operation_main_Fork_s_p);
					BehaviorPort_Operation_main_ObjectFlow104.SetTarget(BehaviorPort_Operation_main_Send_Start_target);
						// LiteralBoolean LiteralBoolean105
						BehaviorPort_Operation_main_ObjectFlow104_LiteralBoolean105.SetName("LiteralBoolean105");
						BehaviorPort_Operation_main_ObjectFlow104_LiteralBoolean105.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_main_ObjectFlow104_LiteralBoolean105.SetValue(true);
					BehaviorPort_Operation_main_ObjectFlow104.SetGuard(BehaviorPort_Operation_main_ObjectFlow104_LiteralBoolean105);
				BehaviorPort_Operation_main.AddEdge(BehaviorPort_Operation_main_ObjectFlow104);
					// ObjectFlow ObjectFlow107 from Fork s.p to p
					BehaviorPort_Operation_main_ObjectFlow107.SetName("ObjectFlow107");
					BehaviorPort_Operation_main_ObjectFlow107.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Operation_main_ObjectFlow107.SetSource(BehaviorPort_Operation_main_Fork_s_p);
					BehaviorPort_Operation_main_ObjectFlow107.SetTarget(BehaviorPort_Operation_main_assertP_p);
						// LiteralBoolean LiteralBoolean109
						BehaviorPort_Operation_main_ObjectFlow107_LiteralBoolean109.SetName("LiteralBoolean109");
						BehaviorPort_Operation_main_ObjectFlow107_LiteralBoolean109.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_main_ObjectFlow107_LiteralBoolean109.SetValue(true);
					BehaviorPort_Operation_main_ObjectFlow107.SetGuard(BehaviorPort_Operation_main_ObjectFlow107_LiteralBoolean109);
				BehaviorPort_Operation_main.AddEdge(BehaviorPort_Operation_main_ObjectFlow107);
			BehaviorPort_Operation.AddPackagedElement(BehaviorPort_Operation_main);
				// Class C
				BehaviorPort_Operation_C.SetName("C");
				BehaviorPort_Operation_C.SetVisibility(VisibilityKind.public_);
				
					// Port pc
					BehaviorPort_Operation_C_pc.SetName("pc");
					BehaviorPort_Operation_C_pc.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Operation_C_pc.SetType(BehaviorPort_Operation_I);
					BehaviorPort_Operation_C_pc.SetAggregation(AggregationKind.composite);
					BehaviorPort_Operation_C_pc.isBehavior = true;
					BehaviorPort_Operation_C_pc.isService = true;
					BehaviorPort_Operation_C_pc.AddProvided(BehaviorPort_Operation_I);
				BehaviorPort_Operation_C.AddOwnedAttribute(BehaviorPort_Operation_C_pc);
				BehaviorPort_Operation_C.SetClassifierBehavior(BehaviorPort_Operation_C_C_ClassifierBehavior);
					// Activity C_Factory
					BehaviorPort_Operation_C_C_Factory.SetName("C_Factory");
					BehaviorPort_Operation_C_C_Factory.SetVisibility(VisibilityKind.public_);
					
						// Parameter result
						BehaviorPort_Operation_C_C_Factory_result.SetName("result");
						BehaviorPort_Operation_C_C_Factory_result.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_C_C_Factory_result.SetType(BehaviorPort_Operation_C);
						BehaviorPort_Operation_C_C_Factory_result.SetDirection(ParameterDirectionKind.return_);
					BehaviorPort_Operation_C_C_Factory.AddOwnedParameter(BehaviorPort_Operation_C_C_Factory_result);
						// ForkNode Fork object
						BehaviorPort_Operation_C_C_Factory_Fork_object.SetName("Fork object");
						BehaviorPort_Operation_C_C_Factory_Fork_object.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Operation_C_C_Factory.AddNode(BehaviorPort_Operation_C_C_Factory_Fork_object);
						// CreateObjectAction Create C
						BehaviorPort_Operation_C_C_Factory_Create_C.SetName("Create C");
						BehaviorPort_Operation_C_C_Factory_Create_C.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_C_C_Factory_Create_C.SetClassifier(BehaviorPort_Operation_C);
							// OutputPin result
							BehaviorPort_Operation_C_C_Factory_Create_C_result.SetName("result");
							BehaviorPort_Operation_C_C_Factory_Create_C_result.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_C_C_Factory_Create_C_result.SetType(BehaviorPort_Operation_C);
						BehaviorPort_Operation_C_C_Factory_Create_C.SetResult(BehaviorPort_Operation_C_C_Factory_Create_C_result);
					BehaviorPort_Operation_C_C_Factory.AddNode(BehaviorPort_Operation_C_C_Factory_Create_C);
						// StartObjectBehaviorAction Start classifierBehavior
						BehaviorPort_Operation_C_C_Factory_Start_classifierBehavior.SetName("Start classifierBehavior");
						BehaviorPort_Operation_C_C_Factory_Start_classifierBehavior.SetVisibility(VisibilityKind.public_);
							// InputPin object
							BehaviorPort_Operation_C_C_Factory_Start_classifierBehavior_object.SetName("object");
							BehaviorPort_Operation_C_C_Factory_Start_classifierBehavior_object.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_C_C_Factory_Start_classifierBehavior_object.SetType(BehaviorPort_Operation_C);
						BehaviorPort_Operation_C_C_Factory_Start_classifierBehavior.SetObject(BehaviorPort_Operation_C_C_Factory_Start_classifierBehavior_object);
					BehaviorPort_Operation_C_C_Factory.AddNode(BehaviorPort_Operation_C_C_Factory_Start_classifierBehavior);
						// ActivityParameterNode resultParameterNode
						BehaviorPort_Operation_C_C_Factory_resultParameterNode.SetName("resultParameterNode");
						BehaviorPort_Operation_C_C_Factory_resultParameterNode.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_C_C_Factory_resultParameterNode.SetParameter(BehaviorPort_Operation_C_C_Factory_result);
					BehaviorPort_Operation_C_C_Factory.AddNode(BehaviorPort_Operation_C_C_Factory_resultParameterNode);
						// CallOperationAction C()
						BehaviorPort_Operation_C_C_Factory_C_.SetName("C()");
						BehaviorPort_Operation_C_C_Factory_C_.SetVisibility(VisibilityKind.public_);
						
							// OutputPin result
							BehaviorPort_Operation_C_C_Factory_C__result.SetName("result");
							BehaviorPort_Operation_C_C_Factory_C__result.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_C_C_Factory_C__result.SetType(BehaviorPort_Operation_C);
						BehaviorPort_Operation_C_C_Factory_C_.AddResult(BehaviorPort_Operation_C_C_Factory_C__result);
						BehaviorPort_Operation_C_C_Factory_C_.SetOperation(BehaviorPort_Operation_C_C_C);
							// InputPin target
							BehaviorPort_Operation_C_C_Factory_C__target.SetName("target");
							BehaviorPort_Operation_C_C_Factory_C__target.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_C_C_Factory_C__target.SetType(BehaviorPort_Operation_C);
						BehaviorPort_Operation_C_C_Factory_C_.SetTarget(BehaviorPort_Operation_C_C_Factory_C__target);
					BehaviorPort_Operation_C_C_Factory.AddNode(BehaviorPort_Operation_C_C_Factory_C_);
						// ObjectFlow ObjectFlow115 from result to Fork object
						BehaviorPort_Operation_C_C_Factory_ObjectFlow115.SetName("ObjectFlow115");
						BehaviorPort_Operation_C_C_Factory_ObjectFlow115.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_C_C_Factory_ObjectFlow115.SetSource(BehaviorPort_Operation_C_C_Factory_C__result);
						BehaviorPort_Operation_C_C_Factory_ObjectFlow115.SetTarget(BehaviorPort_Operation_C_C_Factory_Fork_object);
							// LiteralBoolean LiteralBoolean116
							BehaviorPort_Operation_C_C_Factory_ObjectFlow115_LiteralBoolean116.SetName("LiteralBoolean116");
							BehaviorPort_Operation_C_C_Factory_ObjectFlow115_LiteralBoolean116.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_C_C_Factory_ObjectFlow115_LiteralBoolean116.SetValue(true);
						BehaviorPort_Operation_C_C_Factory_ObjectFlow115.SetGuard(BehaviorPort_Operation_C_C_Factory_ObjectFlow115_LiteralBoolean116);
					BehaviorPort_Operation_C_C_Factory.AddEdge(BehaviorPort_Operation_C_C_Factory_ObjectFlow115);
						// ObjectFlow ObjectFlow118 from Fork object to resultParameterNode
						BehaviorPort_Operation_C_C_Factory_ObjectFlow118.SetName("ObjectFlow118");
						BehaviorPort_Operation_C_C_Factory_ObjectFlow118.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_C_C_Factory_ObjectFlow118.SetSource(BehaviorPort_Operation_C_C_Factory_Fork_object);
						BehaviorPort_Operation_C_C_Factory_ObjectFlow118.SetTarget(BehaviorPort_Operation_C_C_Factory_resultParameterNode);
							// LiteralBoolean LiteralBoolean119
							BehaviorPort_Operation_C_C_Factory_ObjectFlow118_LiteralBoolean119.SetName("LiteralBoolean119");
							BehaviorPort_Operation_C_C_Factory_ObjectFlow118_LiteralBoolean119.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_C_C_Factory_ObjectFlow118_LiteralBoolean119.SetValue(true);
						BehaviorPort_Operation_C_C_Factory_ObjectFlow118.SetGuard(BehaviorPort_Operation_C_C_Factory_ObjectFlow118_LiteralBoolean119);
					BehaviorPort_Operation_C_C_Factory.AddEdge(BehaviorPort_Operation_C_C_Factory_ObjectFlow118);
						// ObjectFlow ObjectFlow121 from Fork object to object
						BehaviorPort_Operation_C_C_Factory_ObjectFlow121.SetName("ObjectFlow121");
						BehaviorPort_Operation_C_C_Factory_ObjectFlow121.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_C_C_Factory_ObjectFlow121.SetSource(BehaviorPort_Operation_C_C_Factory_Fork_object);
						BehaviorPort_Operation_C_C_Factory_ObjectFlow121.SetTarget(BehaviorPort_Operation_C_C_Factory_Start_classifierBehavior_object);
							// LiteralBoolean LiteralBoolean122
							BehaviorPort_Operation_C_C_Factory_ObjectFlow121_LiteralBoolean122.SetName("LiteralBoolean122");
							BehaviorPort_Operation_C_C_Factory_ObjectFlow121_LiteralBoolean122.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_C_C_Factory_ObjectFlow121_LiteralBoolean122.SetValue(true);
						BehaviorPort_Operation_C_C_Factory_ObjectFlow121.SetGuard(BehaviorPort_Operation_C_C_Factory_ObjectFlow121_LiteralBoolean122);
					BehaviorPort_Operation_C_C_Factory.AddEdge(BehaviorPort_Operation_C_C_Factory_ObjectFlow121);
						// ObjectFlow ObjectFlow128 from result to target
						BehaviorPort_Operation_C_C_Factory_ObjectFlow128.SetName("ObjectFlow128");
						BehaviorPort_Operation_C_C_Factory_ObjectFlow128.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_C_C_Factory_ObjectFlow128.SetSource(BehaviorPort_Operation_C_C_Factory_Create_C_result);
						BehaviorPort_Operation_C_C_Factory_ObjectFlow128.SetTarget(BehaviorPort_Operation_C_C_Factory_C__target);
							// LiteralBoolean LiteralBoolean130
							BehaviorPort_Operation_C_C_Factory_ObjectFlow128_LiteralBoolean130.SetName("LiteralBoolean130");
							BehaviorPort_Operation_C_C_Factory_ObjectFlow128_LiteralBoolean130.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_C_C_Factory_ObjectFlow128_LiteralBoolean130.SetValue(true);
						BehaviorPort_Operation_C_C_Factory_ObjectFlow128.SetGuard(BehaviorPort_Operation_C_C_Factory_ObjectFlow128_LiteralBoolean130);
					BehaviorPort_Operation_C_C_Factory.AddEdge(BehaviorPort_Operation_C_C_Factory_ObjectFlow128);
				BehaviorPort_Operation_C.AddOwnedBehavior(BehaviorPort_Operation_C_C_Factory);
					// Activity C$ClassifierBehavior
					BehaviorPort_Operation_C_C_ClassifierBehavior.SetName("C$ClassifierBehavior");
					BehaviorPort_Operation_C_C_ClassifierBehavior.SetVisibility(VisibilityKind.public_);
						// ForkNode Fork result
						BehaviorPort_Operation_C_C_ClassifierBehavior_Fork_result.SetName("Fork result");
						BehaviorPort_Operation_C_C_ClassifierBehavior_Fork_result.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Operation_C_C_ClassifierBehavior.AddNode(BehaviorPort_Operation_C_C_ClassifierBehavior_Fork_result);
						// InitialNode InitialNode1
						BehaviorPort_Operation_C_C_ClassifierBehavior_InitialNode1.SetName("InitialNode1");
						BehaviorPort_Operation_C_C_ClassifierBehavior_InitialNode1.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Operation_C_C_ClassifierBehavior.AddNode(BehaviorPort_Operation_C_C_ClassifierBehavior_InitialNode1);
						// CallBehaviorAction Call Xor
						BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor.SetName("Call Xor");
						BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor.SetVisibility(VisibilityKind.public_);
						
							// OutputPin result
							BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_result.SetName("result");
							BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_result.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
						BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor.AddResult(BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_result);
						BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_PrimitiveBehaviors_BooleanFunctions_Xor);
							// InputPin x
							BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_x.SetName("x");
							BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_x.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_x.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
						BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor.AddArgument(BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_x);
							// InputPin y
							BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_y.SetName("y");
							BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_y.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_y.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
						BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor.AddArgument(BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_y);
					BehaviorPort_Operation_C_C_ClassifierBehavior.AddNode(BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor);
						// AcceptCallAction Accept or()
						BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or_.SetName("Accept or()");
						BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or_.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or_.SetIsUnmarshall(true);
							// OutputPin a
							BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or__a.SetName("a");
							BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or__a.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or__a.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
						BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or_.AddResult(BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or__a);
							// OutputPin b
							BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or__b.SetName("b");
							BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or__b.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or__b.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
						BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or_.AddResult(BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or__b);
							// Trigger CallEventOrTrigger
							BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or__CallEventOrTrigger.SetName("CallEventOrTrigger");
							BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or__CallEventOrTrigger.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or__CallEventOrTrigger.SetEvent(BehaviorPort_Operation_CallEventOr);
						BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or_.AddTrigger(BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or__CallEventOrTrigger);
							// OutputPin returnInformation
							BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or__returnInformation.SetName("returnInformation");
							BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or__returnInformation.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or__returnInformation.SetType(BehaviorPort_Operation_P);
						BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or_.SetReturnInformation(BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or__returnInformation);
					BehaviorPort_Operation_C_C_ClassifierBehavior.AddNode(BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or_);
						// ReplyAction Reply or()
						BehaviorPort_Operation_C_C_ClassifierBehavior_Reply_or_.SetName("Reply or()");
						BehaviorPort_Operation_C_C_ClassifierBehavior_Reply_or_.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_C_C_ClassifierBehavior_Reply_or_.SetReplyToCall(BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or__CallEventOrTrigger);
							// InputPin returnInformation
							BehaviorPort_Operation_C_C_ClassifierBehavior_Reply_or__returnInformation.SetName("returnInformation");
							BehaviorPort_Operation_C_C_ClassifierBehavior_Reply_or__returnInformation.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_C_C_ClassifierBehavior_Reply_or__returnInformation.SetType(BehaviorPort_Operation_P);
						BehaviorPort_Operation_C_C_ClassifierBehavior_Reply_or_.SetReturnInformation(BehaviorPort_Operation_C_C_ClassifierBehavior_Reply_or__returnInformation);
							// InputPin cr
							BehaviorPort_Operation_C_C_ClassifierBehavior_Reply_or__cr.SetName("cr");
							BehaviorPort_Operation_C_C_ClassifierBehavior_Reply_or__cr.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_C_C_ClassifierBehavior_Reply_or__cr.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
						BehaviorPort_Operation_C_C_ClassifierBehavior_Reply_or_.AddReplyValue(BehaviorPort_Operation_C_C_ClassifierBehavior_Reply_or__cr);
							// InputPin r
							BehaviorPort_Operation_C_C_ClassifierBehavior_Reply_or__r.SetName("r");
							BehaviorPort_Operation_C_C_ClassifierBehavior_Reply_or__r.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_C_C_ClassifierBehavior_Reply_or__r.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
						BehaviorPort_Operation_C_C_ClassifierBehavior_Reply_or_.AddReplyValue(BehaviorPort_Operation_C_C_ClassifierBehavior_Reply_or__r);
					BehaviorPort_Operation_C_C_ClassifierBehavior.AddNode(BehaviorPort_Operation_C_C_ClassifierBehavior_Reply_or_);
						// ObjectFlow ObjectFlow137 from a to x
						BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow137.SetName("ObjectFlow137");
						BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow137.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow137.SetSource(BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or__a);
						BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow137.SetTarget(BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_x);
							// LiteralBoolean LiteralBoolean139
							BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow137_LiteralBoolean139.SetName("LiteralBoolean139");
							BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow137_LiteralBoolean139.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow137_LiteralBoolean139.SetValue(true);
						BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow137.SetGuard(BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow137_LiteralBoolean139);
					BehaviorPort_Operation_C_C_ClassifierBehavior.AddEdge(BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow137);
						// ControlFlow ControlFlow140 from InitialNode1 to Accept or()
						BehaviorPort_Operation_C_C_ClassifierBehavior_ControlFlow140.SetName("ControlFlow140");
						BehaviorPort_Operation_C_C_ClassifierBehavior_ControlFlow140.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_C_C_ClassifierBehavior_ControlFlow140.SetSource(BehaviorPort_Operation_C_C_ClassifierBehavior_InitialNode1);
						BehaviorPort_Operation_C_C_ClassifierBehavior_ControlFlow140.SetTarget(BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or_);
					BehaviorPort_Operation_C_C_ClassifierBehavior.AddEdge(BehaviorPort_Operation_C_C_ClassifierBehavior_ControlFlow140);
						// ObjectFlow ObjectFlow141 from result to Fork result
						BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow141.SetName("ObjectFlow141");
						BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow141.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow141.SetSource(BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_result);
						BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow141.SetTarget(BehaviorPort_Operation_C_C_ClassifierBehavior_Fork_result);
							// LiteralBoolean LiteralBoolean143
							BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow141_LiteralBoolean143.SetName("LiteralBoolean143");
							BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow141_LiteralBoolean143.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow141_LiteralBoolean143.SetValue(true);
						BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow141.SetGuard(BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow141_LiteralBoolean143);
					BehaviorPort_Operation_C_C_ClassifierBehavior.AddEdge(BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow141);
						// ObjectFlow ObjectFlow144 from Fork result to r
						BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow144.SetName("ObjectFlow144");
						BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow144.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow144.SetSource(BehaviorPort_Operation_C_C_ClassifierBehavior_Fork_result);
						BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow144.SetTarget(BehaviorPort_Operation_C_C_ClassifierBehavior_Reply_or__r);
							// LiteralBoolean LiteralBoolean145
							BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow144_LiteralBoolean145.SetName("LiteralBoolean145");
							BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow144_LiteralBoolean145.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow144_LiteralBoolean145.SetValue(true);
						BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow144.SetGuard(BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow144_LiteralBoolean145);
					BehaviorPort_Operation_C_C_ClassifierBehavior.AddEdge(BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow144);
						// ObjectFlow ObjectFlow147 from Fork result to cr
						BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow147.SetName("ObjectFlow147");
						BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow147.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow147.SetSource(BehaviorPort_Operation_C_C_ClassifierBehavior_Fork_result);
						BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow147.SetTarget(BehaviorPort_Operation_C_C_ClassifierBehavior_Reply_or__cr);
							// LiteralBoolean LiteralBoolean148
							BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow147_LiteralBoolean148.SetName("LiteralBoolean148");
							BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow147_LiteralBoolean148.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow147_LiteralBoolean148.SetValue(true);
						BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow147.SetGuard(BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow147_LiteralBoolean148);
					BehaviorPort_Operation_C_C_ClassifierBehavior.AddEdge(BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow147);
						// ObjectFlow ObjectFlow157 from returnInformation to returnInformation
						BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow157.SetName("ObjectFlow157");
						BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow157.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow157.SetSource(BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or__returnInformation);
						BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow157.SetTarget(BehaviorPort_Operation_C_C_ClassifierBehavior_Reply_or__returnInformation);
							// LiteralBoolean LiteralBoolean158
							BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow157_LiteralBoolean158.SetName("LiteralBoolean158");
							BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow157_LiteralBoolean158.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow157_LiteralBoolean158.SetValue(true);
						BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow157.SetGuard(BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow157_LiteralBoolean158);
					BehaviorPort_Operation_C_C_ClassifierBehavior.AddEdge(BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow157);
						// ObjectFlow ObjectFlow162 from b to y
						BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow162.SetName("ObjectFlow162");
						BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow162.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow162.SetSource(BehaviorPort_Operation_C_C_ClassifierBehavior_Accept_or__b);
						BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow162.SetTarget(BehaviorPort_Operation_C_C_ClassifierBehavior_Call_Xor_y);
							// LiteralBoolean LiteralBoolean164
							BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow162_LiteralBoolean164.SetName("LiteralBoolean164");
							BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow162_LiteralBoolean164.SetVisibility(VisibilityKind.public_);
							BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow162_LiteralBoolean164.SetValue(true);
						BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow162.SetGuard(BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow162_LiteralBoolean164);
					BehaviorPort_Operation_C_C_ClassifierBehavior.AddEdge(BehaviorPort_Operation_C_C_ClassifierBehavior_ObjectFlow162);
				BehaviorPort_Operation_C.AddOwnedBehavior(BehaviorPort_Operation_C_C_ClassifierBehavior);
					BehaviorPort_Operation_C_I_Realization.SetName("I_Realization");
					BehaviorPort_Operation_C_I_Realization.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Operation_C_I_Realization.SetContract(BehaviorPort_Operation_I);
					
				BehaviorPort_Operation_C.AddInterfaceRealization(BehaviorPort_Operation_C_I_Realization);
				
				BehaviorPort_Operation_C.SetIsActive(true);
					// Operation C_C
					BehaviorPort_Operation_C_C_C.SetName("C_C");
					BehaviorPort_Operation_C_C_C.SetVisibility(VisibilityKind.public_);
						// Parameter result
						BehaviorPort_Operation_C_C_C_result.SetName("result");
						BehaviorPort_Operation_C_C_C_result.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_C_C_C_result.SetType(BehaviorPort_Operation_C);
						BehaviorPort_Operation_C_C_C_result.SetDirection(ParameterDirectionKind.return_);
					BehaviorPort_Operation_C_C_C.AddOwnedParameter(BehaviorPort_Operation_C_C_C_result);
					BehaviorPort_Operation_C_C_C.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				BehaviorPort_Operation_C.AddOwnedOperation(BehaviorPort_Operation_C_C_C);
					// Operation Boolean_or_Boolean_Boolean_Boolean
					BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean.SetName("Boolean_or_Boolean_Boolean_Boolean");
					BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean.SetVisibility(VisibilityKind.public_);
						// Parameter a
						BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean_a.SetName("a");
						BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean_a.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean_a.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
					BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean.AddOwnedParameter(BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean_a);
						// Parameter b
						BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean_b.SetName("b");
						BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean_b.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean_b.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
					BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean.AddOwnedParameter(BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean_b);
						// Parameter c
						BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean_c.SetName("c");
						BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean_c.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean_c.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
						BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean_c.SetDirection(ParameterDirectionKind.out_);
					BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean.AddOwnedParameter(BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean_c);
						// Parameter result
						BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean_result.SetName("result");
						BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean_result.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
						BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean_result.SetDirection(ParameterDirectionKind.return_);
					BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean.AddOwnedParameter(BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean_result);
				BehaviorPort_Operation_C.AddOwnedOperation(BehaviorPort_Operation_C_Boolean_or_Boolean_Boolean_Boolean);
			BehaviorPort_Operation.AddPackagedElement(BehaviorPort_Operation_C);
				// Class S
				BehaviorPort_Operation_S.SetName("S");
				BehaviorPort_Operation_S.SetVisibility(VisibilityKind.public_);
				
					// Property p
					BehaviorPort_Operation_S_p.SetName("p");
					BehaviorPort_Operation_S_p.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Operation_S_p.SetType(BehaviorPort_Operation_P);
					BehaviorPort_Operation_S_p.SetAggregation(AggregationKind.composite);
				BehaviorPort_Operation_S.AddOwnedAttribute(BehaviorPort_Operation_S_p);
					// Property c
					BehaviorPort_Operation_S_c.SetName("c");
					BehaviorPort_Operation_S_c.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Operation_S_c.SetType(BehaviorPort_Operation_C);
					BehaviorPort_Operation_S_c.SetAggregation(AggregationKind.composite);
				BehaviorPort_Operation_S.AddOwnedAttribute(BehaviorPort_Operation_S_c);
				
				BehaviorPort_Operation_S_Connector1.SetName("Connector1");
					BehaviorPort_Operation_S_Connector1.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_S_Connector1_ConnectorEnd165.SetRole(BehaviorPort_Operation_P_pp);
						BehaviorPort_Operation_S_Connector1_ConnectorEnd165.SetPartWithPort(BehaviorPort_Operation_S_p);
						
					BehaviorPort_Operation_S_Connector1.AddEnd(BehaviorPort_Operation_S_Connector1_ConnectorEnd165);
						
						BehaviorPort_Operation_S_Connector1_ConnectorEnd166.SetRole(BehaviorPort_Operation_C_pc);
						BehaviorPort_Operation_S_Connector1_ConnectorEnd166.SetPartWithPort(BehaviorPort_Operation_S_c);
						
					BehaviorPort_Operation_S_Connector1.AddEnd(BehaviorPort_Operation_S_Connector1_ConnectorEnd166);
				BehaviorPort_Operation_S.AddOwnedConnector(BehaviorPort_Operation_S_Connector1);
					// Operation S_S
					BehaviorPort_Operation_S_S_S.SetName("S_S");
					BehaviorPort_Operation_S_S_S.SetVisibility(VisibilityKind.public_);
						// Parameter result
						BehaviorPort_Operation_S_S_S_result.SetName("result");
						BehaviorPort_Operation_S_S_S_result.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_S_S_S_result.SetType(BehaviorPort_Operation_S);
						BehaviorPort_Operation_S_S_S_result.SetDirection(ParameterDirectionKind.return_);
					BehaviorPort_Operation_S_S_S.AddOwnedParameter(BehaviorPort_Operation_S_S_S_result);
					BehaviorPort_Operation_S_S_S.ApplyStereotype(uml.standardprofile.StandardProfileModel.Instance().Stereotype_Create);
				BehaviorPort_Operation_S.AddOwnedOperation(BehaviorPort_Operation_S_S_S);
			BehaviorPort_Operation.AddPackagedElement(BehaviorPort_Operation_S);
				// Signal Start
				BehaviorPort_Operation_Start.SetName("Start");
				BehaviorPort_Operation_Start.SetVisibility(VisibilityKind.public_);
			BehaviorPort_Operation.AddPackagedElement(BehaviorPort_Operation_Start);
				// Usage I_Usage_P
				BehaviorPort_Operation_I_Usage_P.SetName("I_Usage_P");
				BehaviorPort_Operation_I_Usage_P.SetVisibility(VisibilityKind.public_);
				BehaviorPort_Operation_I_Usage_P.AddClient(BehaviorPort_Operation_P);
				BehaviorPort_Operation_I_Usage_P.AddSupplier(BehaviorPort_Operation_I);
			BehaviorPort_Operation.AddPackagedElement(BehaviorPort_Operation_I_Usage_P);
				// Activity assertP
				BehaviorPort_Operation_assertP.SetName("assertP");
				BehaviorPort_Operation_assertP.SetVisibility(VisibilityKind.public_);
				// FunctionBehavior testFalse
					BehaviorPort_Operation_assertP_testFalse.SetName("testFalse");
					BehaviorPort_Operation_assertP_testFalse.SetVisibility(VisibilityKind.public_);
					
						// Parameter input
						BehaviorPort_Operation_assertP_testFalse_input.SetName("input");
						BehaviorPort_Operation_assertP_testFalse_input.SetVisibility(VisibilityKind.public_);
						
						BehaviorPort_Operation_assertP_testFalse_input.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
					BehaviorPort_Operation_assertP_testFalse.AddOwnedParameter(BehaviorPort_Operation_assertP_testFalse_input);
					BehaviorPort_Operation_assertP_testFalse.AddLanguage("C#");
					BehaviorPort_Operation_assertP_testFalse.AddLanguage("Using");
					BehaviorPort_Operation_assertP_testFalse.AddBody("// Test parameter input 	bool input = ((BooleanValue)inputParameters.ElementAt(0).values.ElementAt(0)).value; 	Debug.Println(\"[doBody] argument input = \" + input);  	if(input == false) 	{ 		Console.ForegroundColor = ConsoleColor.Green; 		Console.WriteLine(\"Assertion successful.\"); 	} 	else 	{ 		Console.ForegroundColor = ConsoleColor.Red; 		Console.WriteLine(\"Assertion failed!\"); 	}  	Console.ResetColor();");
					BehaviorPort_Operation_assertP_testFalse.AddBody("using fuml.semantics.simpleclassifiers; ");
				BehaviorPort_Operation_assertP.AddOwnedBehavior(BehaviorPort_Operation_assertP_testFalse);
					// Parameter p
					BehaviorPort_Operation_assertP_p.SetName("p");
					BehaviorPort_Operation_assertP_p.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Operation_assertP_p.SetType(BehaviorPort_Operation_P);
				BehaviorPort_Operation_assertP.AddOwnedParameter(BehaviorPort_Operation_assertP_p);
					// CallBehaviorAction test return
					BehaviorPort_Operation_assertP_test_return.SetName("test return");
					BehaviorPort_Operation_assertP_test_return.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Operation_assertP_test_return.SetBehavior(BehaviorPort_Operation_assertP_testFalse);
						// InputPin input
						BehaviorPort_Operation_assertP_test_return_input.SetName("input");
						BehaviorPort_Operation_assertP_test_return_input.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_assertP_test_return_input.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
					BehaviorPort_Operation_assertP_test_return.AddArgument(BehaviorPort_Operation_assertP_test_return_input);
				BehaviorPort_Operation_assertP.AddNode(BehaviorPort_Operation_assertP_test_return);
					// ForkNode Fork p
					BehaviorPort_Operation_assertP_Fork_p.SetName("Fork p");
					BehaviorPort_Operation_assertP_Fork_p.SetVisibility(VisibilityKind.public_);
				BehaviorPort_Operation_assertP.AddNode(BehaviorPort_Operation_assertP_Fork_p);
					// ValueSpecificationAction p.out message
					BehaviorPort_Operation_assertP_p_out_message.SetName("p.out message");
					BehaviorPort_Operation_assertP_p_out_message.SetVisibility(VisibilityKind.public_);
						// LiteralString LiteralString202
						BehaviorPort_Operation_assertP_p_out_message_LiteralString202.SetName("LiteralString202");
						BehaviorPort_Operation_assertP_p_out_message_LiteralString202.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_assertP_p_out_message_LiteralString202.SetValue("Asserting p.out == false");
					BehaviorPort_Operation_assertP_p_out_message.SetValue(BehaviorPort_Operation_assertP_p_out_message_LiteralString202);
						// OutputPin result
						BehaviorPort_Operation_assertP_p_out_message_result.SetName("result");
						BehaviorPort_Operation_assertP_p_out_message_result.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_assertP_p_out_message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					BehaviorPort_Operation_assertP_p_out_message.SetResult(BehaviorPort_Operation_assertP_p_out_message_result);
				BehaviorPort_Operation_assertP.AddNode(BehaviorPort_Operation_assertP_p_out_message);
					// CallBehaviorAction test out
					BehaviorPort_Operation_assertP_test_out.SetName("test out");
					BehaviorPort_Operation_assertP_test_out.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Operation_assertP_test_out.SetBehavior(BehaviorPort_Operation_assertP_testFalse);
						// InputPin input
						BehaviorPort_Operation_assertP_test_out_input.SetName("input");
						BehaviorPort_Operation_assertP_test_out_input.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_assertP_test_out_input.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
					BehaviorPort_Operation_assertP_test_out.AddArgument(BehaviorPort_Operation_assertP_test_out_input);
				BehaviorPort_Operation_assertP.AddNode(BehaviorPort_Operation_assertP_test_out);
					// CallBehaviorAction writeLine p.return
					BehaviorPort_Operation_assertP_writeLine_p_return.SetName("writeLine p.return");
					BehaviorPort_Operation_assertP_writeLine_p_return.SetVisibility(VisibilityKind.public_);
					
						// OutputPin errorStatus
						BehaviorPort_Operation_assertP_writeLine_p_return_errorStatus.SetName("errorStatus");
						BehaviorPort_Operation_assertP_writeLine_p_return_errorStatus.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_assertP_writeLine_p_return_errorStatus.SetType(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_Common_Status);
						BehaviorPort_Operation_assertP_writeLine_p_return_errorStatus.SetLower(0);
					BehaviorPort_Operation_assertP_writeLine_p_return.AddResult(BehaviorPort_Operation_assertP_writeLine_p_return_errorStatus);
					BehaviorPort_Operation_assertP_writeLine_p_return.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
						// InputPin value
						BehaviorPort_Operation_assertP_writeLine_p_return_value.SetName("value");
						BehaviorPort_Operation_assertP_writeLine_p_return_value.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_assertP_writeLine_p_return_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					BehaviorPort_Operation_assertP_writeLine_p_return.AddArgument(BehaviorPort_Operation_assertP_writeLine_p_return_value);
				BehaviorPort_Operation_assertP.AddNode(BehaviorPort_Operation_assertP_writeLine_p_return);
					// ReadStructuralFeatureAction p.return
					BehaviorPort_Operation_assertP_p_return.SetName("p.return");
					BehaviorPort_Operation_assertP_p_return.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Operation_assertP_p_return.SetStructuralFeature(BehaviorPort_Operation_P_return);
						// InputPin object
						BehaviorPort_Operation_assertP_p_return_object.SetName("object");
						BehaviorPort_Operation_assertP_p_return_object.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_assertP_p_return_object.SetType(BehaviorPort_Operation_P);
					BehaviorPort_Operation_assertP_p_return.SetObject(BehaviorPort_Operation_assertP_p_return_object);
						// OutputPin result
						BehaviorPort_Operation_assertP_p_return_result.SetName("result");
						BehaviorPort_Operation_assertP_p_return_result.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_assertP_p_return_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
						BehaviorPort_Operation_assertP_p_return_result.SetLower(0);
					BehaviorPort_Operation_assertP_p_return.SetResult(BehaviorPort_Operation_assertP_p_return_result);
				BehaviorPort_Operation_assertP.AddNode(BehaviorPort_Operation_assertP_p_return);
					// CallBehaviorAction writeLine p.out
					BehaviorPort_Operation_assertP_writeLine_p_out.SetName("writeLine p.out");
					BehaviorPort_Operation_assertP_writeLine_p_out.SetVisibility(VisibilityKind.public_);
					
						// OutputPin errorStatus
						BehaviorPort_Operation_assertP_writeLine_p_out_errorStatus.SetName("errorStatus");
						BehaviorPort_Operation_assertP_writeLine_p_out_errorStatus.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_assertP_writeLine_p_out_errorStatus.SetType(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_Common_Status);
						BehaviorPort_Operation_assertP_writeLine_p_out_errorStatus.SetLower(0);
					BehaviorPort_Operation_assertP_writeLine_p_out.AddResult(BehaviorPort_Operation_assertP_writeLine_p_out_errorStatus);
					BehaviorPort_Operation_assertP_writeLine_p_out.SetBehavior(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_WriteLine);
						// InputPin value
						BehaviorPort_Operation_assertP_writeLine_p_out_value.SetName("value");
						BehaviorPort_Operation_assertP_writeLine_p_out_value.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_assertP_writeLine_p_out_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					BehaviorPort_Operation_assertP_writeLine_p_out.AddArgument(BehaviorPort_Operation_assertP_writeLine_p_out_value);
				BehaviorPort_Operation_assertP.AddNode(BehaviorPort_Operation_assertP_writeLine_p_out);
					// ReadStructuralFeatureAction p.out
					BehaviorPort_Operation_assertP_p_out.SetName("p.out");
					BehaviorPort_Operation_assertP_p_out.SetVisibility(VisibilityKind.public_);
					BehaviorPort_Operation_assertP_p_out.SetStructuralFeature(BehaviorPort_Operation_P_out);
						// InputPin object
						BehaviorPort_Operation_assertP_p_out_object.SetName("object");
						BehaviorPort_Operation_assertP_p_out_object.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_assertP_p_out_object.SetType(BehaviorPort_Operation_P);
					BehaviorPort_Operation_assertP_p_out.SetObject(BehaviorPort_Operation_assertP_p_out_object);
						// OutputPin result
						BehaviorPort_Operation_assertP_p_out_result.SetName("result");
						BehaviorPort_Operation_assertP_p_out_result.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_assertP_p_out_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Boolean);
						BehaviorPort_Operation_assertP_p_out_result.SetLower(0);
					BehaviorPort_Operation_assertP_p_out.SetResult(BehaviorPort_Operation_assertP_p_out_result);
				BehaviorPort_Operation_assertP.AddNode(BehaviorPort_Operation_assertP_p_out);
					// ValueSpecificationAction p.return message
					BehaviorPort_Operation_assertP_p_return_message.SetName("p.return message");
					BehaviorPort_Operation_assertP_p_return_message.SetVisibility(VisibilityKind.public_);
						// LiteralString LiteralString213
						BehaviorPort_Operation_assertP_p_return_message_LiteralString213.SetName("LiteralString213");
						BehaviorPort_Operation_assertP_p_return_message_LiteralString213.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_assertP_p_return_message_LiteralString213.SetValue("Asserting p.return == false");
					BehaviorPort_Operation_assertP_p_return_message.SetValue(BehaviorPort_Operation_assertP_p_return_message_LiteralString213);
						// OutputPin result
						BehaviorPort_Operation_assertP_p_return_message_result.SetName("result");
						BehaviorPort_Operation_assertP_p_return_message_result.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_assertP_p_return_message_result.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_String);
					BehaviorPort_Operation_assertP_p_return_message.SetResult(BehaviorPort_Operation_assertP_p_return_message_result);
				BehaviorPort_Operation_assertP.AddNode(BehaviorPort_Operation_assertP_p_return_message);
					// ActivityParameterNode pParameterNode
					BehaviorPort_Operation_assertP_pParameterNode.SetName("pParameterNode");
					BehaviorPort_Operation_assertP_pParameterNode.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Operation_assertP_pParameterNode.SetParameter(BehaviorPort_Operation_assertP_p);
				BehaviorPort_Operation_assertP.AddNode(BehaviorPort_Operation_assertP_pParameterNode);
					// ObjectFlow ObjectFlow167 from result to input
					BehaviorPort_Operation_assertP_ObjectFlow167.SetName("ObjectFlow167");
					BehaviorPort_Operation_assertP_ObjectFlow167.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Operation_assertP_ObjectFlow167.SetSource(BehaviorPort_Operation_assertP_p_return_result);
					BehaviorPort_Operation_assertP_ObjectFlow167.SetTarget(BehaviorPort_Operation_assertP_test_return_input);
						// LiteralBoolean LiteralBoolean169
						BehaviorPort_Operation_assertP_ObjectFlow167_LiteralBoolean169.SetName("LiteralBoolean169");
						BehaviorPort_Operation_assertP_ObjectFlow167_LiteralBoolean169.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_assertP_ObjectFlow167_LiteralBoolean169.SetValue(true);
					BehaviorPort_Operation_assertP_ObjectFlow167.SetGuard(BehaviorPort_Operation_assertP_ObjectFlow167_LiteralBoolean169);
				BehaviorPort_Operation_assertP.AddEdge(BehaviorPort_Operation_assertP_ObjectFlow167);
					// ControlFlow ControlFlow170 from p.out to p.out message
					BehaviorPort_Operation_assertP_ControlFlow170.SetName("ControlFlow170");
					BehaviorPort_Operation_assertP_ControlFlow170.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Operation_assertP_ControlFlow170.SetSource(BehaviorPort_Operation_assertP_p_out);
					BehaviorPort_Operation_assertP_ControlFlow170.SetTarget(BehaviorPort_Operation_assertP_p_out_message);
				BehaviorPort_Operation_assertP.AddEdge(BehaviorPort_Operation_assertP_ControlFlow170);
					// ObjectFlow ObjectFlow171 from pParameterNode to Fork p
					BehaviorPort_Operation_assertP_ObjectFlow171.SetName("ObjectFlow171");
					BehaviorPort_Operation_assertP_ObjectFlow171.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Operation_assertP_ObjectFlow171.SetSource(BehaviorPort_Operation_assertP_pParameterNode);
					BehaviorPort_Operation_assertP_ObjectFlow171.SetTarget(BehaviorPort_Operation_assertP_Fork_p);
						// LiteralBoolean LiteralBoolean172
						BehaviorPort_Operation_assertP_ObjectFlow171_LiteralBoolean172.SetName("LiteralBoolean172");
						BehaviorPort_Operation_assertP_ObjectFlow171_LiteralBoolean172.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_assertP_ObjectFlow171_LiteralBoolean172.SetValue(true);
					BehaviorPort_Operation_assertP_ObjectFlow171.SetGuard(BehaviorPort_Operation_assertP_ObjectFlow171_LiteralBoolean172);
				BehaviorPort_Operation_assertP.AddEdge(BehaviorPort_Operation_assertP_ObjectFlow171);
					// ObjectFlow ObjectFlow174 from Fork p to object
					BehaviorPort_Operation_assertP_ObjectFlow174.SetName("ObjectFlow174");
					BehaviorPort_Operation_assertP_ObjectFlow174.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Operation_assertP_ObjectFlow174.SetSource(BehaviorPort_Operation_assertP_Fork_p);
					BehaviorPort_Operation_assertP_ObjectFlow174.SetTarget(BehaviorPort_Operation_assertP_p_out_object);
						// LiteralBoolean LiteralBoolean175
						BehaviorPort_Operation_assertP_ObjectFlow174_LiteralBoolean175.SetName("LiteralBoolean175");
						BehaviorPort_Operation_assertP_ObjectFlow174_LiteralBoolean175.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_assertP_ObjectFlow174_LiteralBoolean175.SetValue(true);
					BehaviorPort_Operation_assertP_ObjectFlow174.SetGuard(BehaviorPort_Operation_assertP_ObjectFlow174_LiteralBoolean175);
				BehaviorPort_Operation_assertP.AddEdge(BehaviorPort_Operation_assertP_ObjectFlow174);
					// ControlFlow ControlFlow196 from writeLine p.return to test return
					BehaviorPort_Operation_assertP_ControlFlow196.SetName("ControlFlow196");
					BehaviorPort_Operation_assertP_ControlFlow196.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Operation_assertP_ControlFlow196.SetSource(BehaviorPort_Operation_assertP_writeLine_p_return);
					BehaviorPort_Operation_assertP_ControlFlow196.SetTarget(BehaviorPort_Operation_assertP_test_return);
				BehaviorPort_Operation_assertP.AddEdge(BehaviorPort_Operation_assertP_ControlFlow196);
					// ControlFlow ControlFlow197 from test out to test return
					BehaviorPort_Operation_assertP_ControlFlow197.SetName("ControlFlow197");
					BehaviorPort_Operation_assertP_ControlFlow197.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Operation_assertP_ControlFlow197.SetSource(BehaviorPort_Operation_assertP_test_out);
					BehaviorPort_Operation_assertP_ControlFlow197.SetTarget(BehaviorPort_Operation_assertP_test_return);
				BehaviorPort_Operation_assertP.AddEdge(BehaviorPort_Operation_assertP_ControlFlow197);
					// ObjectFlow ObjectFlow209 from result to value
					BehaviorPort_Operation_assertP_ObjectFlow209.SetName("ObjectFlow209");
					BehaviorPort_Operation_assertP_ObjectFlow209.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Operation_assertP_ObjectFlow209.SetSource(BehaviorPort_Operation_assertP_p_out_message_result);
					BehaviorPort_Operation_assertP_ObjectFlow209.SetTarget(BehaviorPort_Operation_assertP_writeLine_p_out_value);
						// LiteralBoolean LiteralBoolean210
						BehaviorPort_Operation_assertP_ObjectFlow209_LiteralBoolean210.SetName("LiteralBoolean210");
						BehaviorPort_Operation_assertP_ObjectFlow209_LiteralBoolean210.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_assertP_ObjectFlow209_LiteralBoolean210.SetValue(true);
					BehaviorPort_Operation_assertP_ObjectFlow209.SetGuard(BehaviorPort_Operation_assertP_ObjectFlow209_LiteralBoolean210);
				BehaviorPort_Operation_assertP.AddEdge(BehaviorPort_Operation_assertP_ObjectFlow209);
					// ControlFlow ControlFlow212 from p.return to p.return message
					BehaviorPort_Operation_assertP_ControlFlow212.SetName("ControlFlow212");
					BehaviorPort_Operation_assertP_ControlFlow212.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Operation_assertP_ControlFlow212.SetSource(BehaviorPort_Operation_assertP_p_return);
					BehaviorPort_Operation_assertP_ControlFlow212.SetTarget(BehaviorPort_Operation_assertP_p_return_message);
				BehaviorPort_Operation_assertP.AddEdge(BehaviorPort_Operation_assertP_ControlFlow212);
					// ObjectFlow ObjectFlow216 from result to input
					BehaviorPort_Operation_assertP_ObjectFlow216.SetName("ObjectFlow216");
					BehaviorPort_Operation_assertP_ObjectFlow216.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Operation_assertP_ObjectFlow216.SetSource(BehaviorPort_Operation_assertP_p_out_result);
					BehaviorPort_Operation_assertP_ObjectFlow216.SetTarget(BehaviorPort_Operation_assertP_test_out_input);
						// LiteralBoolean LiteralBoolean217
						BehaviorPort_Operation_assertP_ObjectFlow216_LiteralBoolean217.SetName("LiteralBoolean217");
						BehaviorPort_Operation_assertP_ObjectFlow216_LiteralBoolean217.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_assertP_ObjectFlow216_LiteralBoolean217.SetValue(true);
					BehaviorPort_Operation_assertP_ObjectFlow216.SetGuard(BehaviorPort_Operation_assertP_ObjectFlow216_LiteralBoolean217);
				BehaviorPort_Operation_assertP.AddEdge(BehaviorPort_Operation_assertP_ObjectFlow216);
					// ControlFlow ControlFlow219 from writeLine p.out to test out
					BehaviorPort_Operation_assertP_ControlFlow219.SetName("ControlFlow219");
					BehaviorPort_Operation_assertP_ControlFlow219.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Operation_assertP_ControlFlow219.SetSource(BehaviorPort_Operation_assertP_writeLine_p_out);
					BehaviorPort_Operation_assertP_ControlFlow219.SetTarget(BehaviorPort_Operation_assertP_test_out);
				BehaviorPort_Operation_assertP.AddEdge(BehaviorPort_Operation_assertP_ControlFlow219);
					// ObjectFlow ObjectFlow220 from result to value
					BehaviorPort_Operation_assertP_ObjectFlow220.SetName("ObjectFlow220");
					BehaviorPort_Operation_assertP_ObjectFlow220.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Operation_assertP_ObjectFlow220.SetSource(BehaviorPort_Operation_assertP_p_return_message_result);
					BehaviorPort_Operation_assertP_ObjectFlow220.SetTarget(BehaviorPort_Operation_assertP_writeLine_p_return_value);
						// LiteralBoolean LiteralBoolean222
						BehaviorPort_Operation_assertP_ObjectFlow220_LiteralBoolean222.SetName("LiteralBoolean222");
						BehaviorPort_Operation_assertP_ObjectFlow220_LiteralBoolean222.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_assertP_ObjectFlow220_LiteralBoolean222.SetValue(true);
					BehaviorPort_Operation_assertP_ObjectFlow220.SetGuard(BehaviorPort_Operation_assertP_ObjectFlow220_LiteralBoolean222);
				BehaviorPort_Operation_assertP.AddEdge(BehaviorPort_Operation_assertP_ObjectFlow220);
					// ObjectFlow ObjectFlow223 from Fork p to object
					BehaviorPort_Operation_assertP_ObjectFlow223.SetName("ObjectFlow223");
					BehaviorPort_Operation_assertP_ObjectFlow223.SetVisibility(VisibilityKind.public_);
					
					BehaviorPort_Operation_assertP_ObjectFlow223.SetSource(BehaviorPort_Operation_assertP_Fork_p);
					BehaviorPort_Operation_assertP_ObjectFlow223.SetTarget(BehaviorPort_Operation_assertP_p_return_object);
						// LiteralBoolean LiteralBoolean224
						BehaviorPort_Operation_assertP_ObjectFlow223_LiteralBoolean224.SetName("LiteralBoolean224");
						BehaviorPort_Operation_assertP_ObjectFlow223_LiteralBoolean224.SetVisibility(VisibilityKind.public_);
						BehaviorPort_Operation_assertP_ObjectFlow223_LiteralBoolean224.SetValue(true);
					BehaviorPort_Operation_assertP_ObjectFlow223.SetGuard(BehaviorPort_Operation_assertP_ObjectFlow223_LiteralBoolean224);
				BehaviorPort_Operation_assertP.AddEdge(BehaviorPort_Operation_assertP_ObjectFlow223);
			BehaviorPort_Operation.AddPackagedElement(BehaviorPort_Operation_assertP);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // BehaviorPort_OperationModel
}
