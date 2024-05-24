/*
 * OperationCommonModel.cs
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

namespace OperationCommon
{
	public class OperationCommonModel : InMemoryModel
	{
		private static OperationCommonModel? instance;

		/*
		 * Model OperationCommon
		 */
		public Package OperationCommon = new();
			public Association OperationCommon_S = new();
				public Property OperationCommon_S_y = new();
				public Property OperationCommon_S_x = new();
			public Interface OperationCommon_I = new();
				public Operation OperationCommon_I_setP_Integer = new();
					public Parameter OperationCommon_I_setP_Integer_v = new();
			public Class_ OperationCommon_B = new();
				public Activity OperationCommon_B_setPActivity = new();
					public ActivityParameterNode OperationCommon_B_setPActivity_vParameterNode = new();
						public LiteralInteger OperationCommon_B_setPActivity_vParameterNode_LiteralInteger0 = new();
					public AddStructuralFeatureValueAction OperationCommon_B_setPActivity_Set_this_p = new();
						public InputPin OperationCommon_B_setPActivity_Set_this_p_value = new();
							public LiteralUnlimitedNatural OperationCommon_B_setPActivity_Set_this_p_value_LiteralUnlimitedNatural1 = new();
							public LiteralInteger OperationCommon_B_setPActivity_Set_this_p_value_LiteralInteger2 = new();
						public InputPin OperationCommon_B_setPActivity_Set_this_p_object = new();
							public LiteralInteger OperationCommon_B_setPActivity_Set_this_p_object_LiteralInteger3 = new();
							public LiteralUnlimitedNatural OperationCommon_B_setPActivity_Set_this_p_object_LiteralUnlimitedNatural4 = new();
						public OutputPin OperationCommon_B_setPActivity_Set_this_p_result = new();
							public LiteralUnlimitedNatural OperationCommon_B_setPActivity_Set_this_p_result_LiteralUnlimitedNatural5 = new();
							public LiteralInteger OperationCommon_B_setPActivity_Set_this_p_result_LiteralInteger6 = new();
					public ObjectFlow OperationCommon_B_setPActivity_ObjectFlow7 = new();
						public LiteralBoolean OperationCommon_B_setPActivity_ObjectFlow7_LiteralBoolean8 = new();
						public LiteralInteger OperationCommon_B_setPActivity_ObjectFlow7_LiteralInteger9 = new();
					public ReadSelfAction OperationCommon_B_setPActivity_this = new();
						public OutputPin OperationCommon_B_setPActivity_this_result = new();
							public LiteralInteger OperationCommon_B_setPActivity_this_result_LiteralInteger10 = new();
							public LiteralUnlimitedNatural OperationCommon_B_setPActivity_this_result_LiteralUnlimitedNatural11 = new();
					public Parameter OperationCommon_B_setPActivity_v = new();
					public ObjectFlow OperationCommon_B_setPActivity_ObjectFlow12 = new();
						public LiteralBoolean OperationCommon_B_setPActivity_ObjectFlow12_LiteralBoolean13 = new();
						public LiteralInteger OperationCommon_B_setPActivity_ObjectFlow12_LiteralInteger14 = new();
				public Operation OperationCommon_B_setP_Integer = new();
					public Parameter OperationCommon_B_setP_Integer_v = new();
				public InterfaceRealization OperationCommon_B_IRealization = new();
				public Property OperationCommon_B_p = new();
			public Class_ OperationCommon_IImpl = new();
				public InterfaceRealization OperationCommon_IImpl_IRealization = new();
				public Operation OperationCommon_IImpl_setP_Integer = new();
					public Parameter OperationCommon_IImpl_setP_Integer_v = new();
			public Association OperationCommon_R = new();
				public Property OperationCommon_R_y = new();
				public Property OperationCommon_R_x = new();

		public static OperationCommonModel Instance()
		{
			if (instance is null)
            {
                instance = new();
                instance.InitializeInMemoryModel();
            }

            return instance;
		}

		public OperationCommonModel()
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
			 * Model OperationCommon
			 */
			AddToElementRepository("OperationCommon", OperationCommon);
				AddToElementRepository("S", OperationCommon_S);
					AddToElementRepository("y", OperationCommon_S_y);
					AddToElementRepository("x", OperationCommon_S_x);
				AddToElementRepository("I", OperationCommon_I);
					AddToElementRepository("setP_Integer", OperationCommon_I_setP_Integer);
						AddToElementRepository("v", OperationCommon_I_setP_Integer_v);
				AddToElementRepository("B", OperationCommon_B);
					AddToElementRepository("setPActivity", OperationCommon_B_setPActivity);
						AddToElementRepository("vParameterNode", OperationCommon_B_setPActivity_vParameterNode);
							AddToElementRepository("LiteralInteger0", OperationCommon_B_setPActivity_vParameterNode_LiteralInteger0);
						AddToElementRepository("Set this.p", OperationCommon_B_setPActivity_Set_this_p);
							AddToElementRepository("value", OperationCommon_B_setPActivity_Set_this_p_value);
								AddToElementRepository("LiteralUnlimitedNatural1", OperationCommon_B_setPActivity_Set_this_p_value_LiteralUnlimitedNatural1);
								AddToElementRepository("LiteralInteger2", OperationCommon_B_setPActivity_Set_this_p_value_LiteralInteger2);
							AddToElementRepository("object", OperationCommon_B_setPActivity_Set_this_p_object);
								AddToElementRepository("LiteralInteger3", OperationCommon_B_setPActivity_Set_this_p_object_LiteralInteger3);
								AddToElementRepository("LiteralUnlimitedNatural4", OperationCommon_B_setPActivity_Set_this_p_object_LiteralUnlimitedNatural4);
							AddToElementRepository("result", OperationCommon_B_setPActivity_Set_this_p_result);
								AddToElementRepository("LiteralUnlimitedNatural5", OperationCommon_B_setPActivity_Set_this_p_result_LiteralUnlimitedNatural5);
								AddToElementRepository("LiteralInteger6", OperationCommon_B_setPActivity_Set_this_p_result_LiteralInteger6);
						AddToElementRepository("ObjectFlow7", OperationCommon_B_setPActivity_ObjectFlow7);
							AddToElementRepository("LiteralBoolean8", OperationCommon_B_setPActivity_ObjectFlow7_LiteralBoolean8);
							AddToElementRepository("LiteralInteger9", OperationCommon_B_setPActivity_ObjectFlow7_LiteralInteger9);
						AddToElementRepository("this", OperationCommon_B_setPActivity_this);
							AddToElementRepository("result", OperationCommon_B_setPActivity_this_result);
								AddToElementRepository("LiteralInteger10", OperationCommon_B_setPActivity_this_result_LiteralInteger10);
								AddToElementRepository("LiteralUnlimitedNatural11", OperationCommon_B_setPActivity_this_result_LiteralUnlimitedNatural11);
						AddToElementRepository("v", OperationCommon_B_setPActivity_v);
						AddToElementRepository("ObjectFlow12", OperationCommon_B_setPActivity_ObjectFlow12);
							AddToElementRepository("LiteralBoolean13", OperationCommon_B_setPActivity_ObjectFlow12_LiteralBoolean13);
							AddToElementRepository("LiteralInteger14", OperationCommon_B_setPActivity_ObjectFlow12_LiteralInteger14);
					AddToElementRepository("setP_Integer", OperationCommon_B_setP_Integer);
						AddToElementRepository("v", OperationCommon_B_setP_Integer_v);
					AddToElementRepository("IRealization", OperationCommon_B_IRealization);
					AddToElementRepository("p", OperationCommon_B_p);
				AddToElementRepository("IImpl", OperationCommon_IImpl);
					AddToElementRepository("IRealization", OperationCommon_IImpl_IRealization);
					AddToElementRepository("setP_Integer", OperationCommon_IImpl_setP_Integer);
						AddToElementRepository("v", OperationCommon_IImpl_setP_Integer_v);
				AddToElementRepository("R", OperationCommon_R);
					AddToElementRepository("y", OperationCommon_R_y);
					AddToElementRepository("x", OperationCommon_R_x);

			// Initialize public members
			/*
			 * Model OperationCommon
			 */
			OperationCommon.SetName("OperationCommon");
			OperationCommon.SetVisibility(VisibilityKind.public_);
				// Association S
				OperationCommon_S.SetName("S");
				OperationCommon_S.SetVisibility(VisibilityKind.public_);
				OperationCommon_S.AddOwnedEnd(OperationCommon_S_x);
				OperationCommon_S.AddOwnedEnd(OperationCommon_S_y);
			OperationCommon.AddPackagedElement(OperationCommon_S);
				// Interface I
				OperationCommon_I.SetName("I");
				OperationCommon_I.SetVisibility(VisibilityKind.public_);
					// Operation setP_Integer
					OperationCommon_I_setP_Integer.SetName("setP_Integer");
					OperationCommon_I_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						OperationCommon_I_setP_Integer_v.SetName("v");
						OperationCommon_I_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						OperationCommon_I_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					OperationCommon_I_setP_Integer.AddOwnedParameter(OperationCommon_I_setP_Integer_v);
				OperationCommon_I.AddOwnedOperation(OperationCommon_I_setP_Integer);
			OperationCommon.AddPackagedElement(OperationCommon_I);
				// Class B
				OperationCommon_B.SetName("B");
				OperationCommon_B.SetVisibility(VisibilityKind.public_);
				
					// Property p
					OperationCommon_B_p.SetName("p");
					OperationCommon_B_p.SetVisibility(VisibilityKind.public_);
					
					OperationCommon_B_p.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
				OperationCommon_B.AddOwnedAttribute(OperationCommon_B_p);
				// Activity setPActivity
					OperationCommon_B_setPActivity.SetName("setPActivity");
					OperationCommon_B_setPActivity.SetVisibility(VisibilityKind.public_);
					
						// Parameter v
						OperationCommon_B_setPActivity_v.SetName("v");
						OperationCommon_B_setPActivity_v.SetVisibility(VisibilityKind.public_);
						
						OperationCommon_B_setPActivity_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					OperationCommon_B_setPActivity.AddOwnedParameter(OperationCommon_B_setPActivity_v);
						// ActivityParameterNode vParameterNode
						OperationCommon_B_setPActivity_vParameterNode.SetName("vParameterNode");
						OperationCommon_B_setPActivity_vParameterNode.SetVisibility(VisibilityKind.public_);
						
						OperationCommon_B_setPActivity_vParameterNode.SetParameter(OperationCommon_B_setPActivity_v);
					OperationCommon_B_setPActivity.AddNode(OperationCommon_B_setPActivity_vParameterNode);
						// AddStructuralFeatureValueAction Set this.p
						OperationCommon_B_setPActivity_Set_this_p.SetName("Set this.p");
						OperationCommon_B_setPActivity_Set_this_p.SetVisibility(VisibilityKind.public_);
						OperationCommon_B_setPActivity_Set_this_p.SetStructuralFeature(OperationCommon_B_p);
							// InputPin object
							OperationCommon_B_setPActivity_Set_this_p_object.SetName("object");
							OperationCommon_B_setPActivity_Set_this_p_object.SetVisibility(VisibilityKind.public_);
							OperationCommon_B_setPActivity_Set_this_p_object.SetType(OperationCommon_B);
						OperationCommon_B_setPActivity_Set_this_p.SetObject(OperationCommon_B_setPActivity_Set_this_p_object);
							// InputPin value
							OperationCommon_B_setPActivity_Set_this_p_value.SetName("value");
							OperationCommon_B_setPActivity_Set_this_p_value.SetVisibility(VisibilityKind.public_);
							OperationCommon_B_setPActivity_Set_this_p_value.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
						OperationCommon_B_setPActivity_Set_this_p.SetValue(OperationCommon_B_setPActivity_Set_this_p_value);
							// OutputPin result
							OperationCommon_B_setPActivity_Set_this_p_result.SetName("result");
							OperationCommon_B_setPActivity_Set_this_p_result.SetVisibility(VisibilityKind.public_);
							OperationCommon_B_setPActivity_Set_this_p_result.SetType(OperationCommon_B);
						OperationCommon_B_setPActivity_Set_this_p.SetResult(OperationCommon_B_setPActivity_Set_this_p_result);
						OperationCommon_B_setPActivity_Set_this_p.SetIsReplaceAll(true);
					OperationCommon_B_setPActivity.AddNode(OperationCommon_B_setPActivity_Set_this_p);
						// ReadSelfAction this
						OperationCommon_B_setPActivity_this.SetName("this");
						OperationCommon_B_setPActivity_this.SetVisibility(VisibilityKind.public_);
							// OutputPin result
							OperationCommon_B_setPActivity_this_result.SetName("result");
							OperationCommon_B_setPActivity_this_result.SetVisibility(VisibilityKind.public_);
							OperationCommon_B_setPActivity_this_result.SetType(OperationCommon_B);
						OperationCommon_B_setPActivity_this.SetResult(OperationCommon_B_setPActivity_this_result);
					OperationCommon_B_setPActivity.AddNode(OperationCommon_B_setPActivity_this);
						// ObjectFlow ObjectFlow7 from vParameterNode to value
						OperationCommon_B_setPActivity_ObjectFlow7.SetName("ObjectFlow7");
						OperationCommon_B_setPActivity_ObjectFlow7.SetVisibility(VisibilityKind.public_);
						
						OperationCommon_B_setPActivity_ObjectFlow7.SetSource(OperationCommon_B_setPActivity_vParameterNode);
						OperationCommon_B_setPActivity_ObjectFlow7.SetTarget(OperationCommon_B_setPActivity_Set_this_p_value);
							// LiteralBoolean LiteralBoolean8
							OperationCommon_B_setPActivity_ObjectFlow7_LiteralBoolean8.SetName("LiteralBoolean8");
							OperationCommon_B_setPActivity_ObjectFlow7_LiteralBoolean8.SetVisibility(VisibilityKind.public_);
							OperationCommon_B_setPActivity_ObjectFlow7_LiteralBoolean8.SetValue(true);
						OperationCommon_B_setPActivity_ObjectFlow7.SetGuard(OperationCommon_B_setPActivity_ObjectFlow7_LiteralBoolean8);
					OperationCommon_B_setPActivity.AddEdge(OperationCommon_B_setPActivity_ObjectFlow7);
						// ObjectFlow ObjectFlow12 from result to object
						OperationCommon_B_setPActivity_ObjectFlow12.SetName("ObjectFlow12");
						OperationCommon_B_setPActivity_ObjectFlow12.SetVisibility(VisibilityKind.public_);
						
						OperationCommon_B_setPActivity_ObjectFlow12.SetSource(OperationCommon_B_setPActivity_this_result);
						OperationCommon_B_setPActivity_ObjectFlow12.SetTarget(OperationCommon_B_setPActivity_Set_this_p_object);
							// LiteralBoolean LiteralBoolean13
							OperationCommon_B_setPActivity_ObjectFlow12_LiteralBoolean13.SetName("LiteralBoolean13");
							OperationCommon_B_setPActivity_ObjectFlow12_LiteralBoolean13.SetVisibility(VisibilityKind.public_);
							OperationCommon_B_setPActivity_ObjectFlow12_LiteralBoolean13.SetValue(true);
						OperationCommon_B_setPActivity_ObjectFlow12.SetGuard(OperationCommon_B_setPActivity_ObjectFlow12_LiteralBoolean13);
					OperationCommon_B_setPActivity.AddEdge(OperationCommon_B_setPActivity_ObjectFlow12);
				OperationCommon_B.AddOwnedBehavior(OperationCommon_B_setPActivity);
					OperationCommon_B_IRealization.SetName("IRealization");
					OperationCommon_B_IRealization.SetVisibility(VisibilityKind.public_);
					OperationCommon_B_IRealization.SetContract(OperationCommon_I);
					
				OperationCommon_B.AddInterfaceRealization(OperationCommon_B_IRealization);
				
					// Operation setP_Integer
					OperationCommon_B_setP_Integer.SetName("setP_Integer");
					OperationCommon_B_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						OperationCommon_B_setP_Integer_v.SetName("v");
						OperationCommon_B_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						OperationCommon_B_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					OperationCommon_B_setP_Integer.AddOwnedParameter(OperationCommon_B_setP_Integer_v);
				OperationCommon_B.AddOwnedOperation(OperationCommon_B_setP_Integer);
			OperationCommon.AddPackagedElement(OperationCommon_B);
				// Class IImpl
				OperationCommon_IImpl.SetName("IImpl");
				OperationCommon_IImpl.SetVisibility(VisibilityKind.public_);
				OperationCommon_IImpl_IRealization.SetName("IRealization");
					OperationCommon_IImpl_IRealization.SetVisibility(VisibilityKind.public_);
					OperationCommon_IImpl_IRealization.SetContract(OperationCommon_I);
					
				OperationCommon_IImpl.AddInterfaceRealization(OperationCommon_IImpl_IRealization);
				
					// Operation setP_Integer
					OperationCommon_IImpl_setP_Integer.SetName("setP_Integer");
					OperationCommon_IImpl_setP_Integer.SetVisibility(VisibilityKind.public_);
						// Parameter v
						OperationCommon_IImpl_setP_Integer_v.SetName("v");
						OperationCommon_IImpl_setP_Integer_v.SetVisibility(VisibilityKind.public_);
						
						OperationCommon_IImpl_setP_Integer_v.SetType(PrimitiveTypesModel.Instance().PrimitiveTypes_Integer);
					OperationCommon_IImpl_setP_Integer.AddOwnedParameter(OperationCommon_IImpl_setP_Integer_v);
				OperationCommon_IImpl.AddOwnedOperation(OperationCommon_IImpl_setP_Integer);
			OperationCommon.AddPackagedElement(OperationCommon_IImpl);
				// Association R
				OperationCommon_R.SetName("R");
				OperationCommon_R.SetVisibility(VisibilityKind.public_);
				OperationCommon_R.AddOwnedEnd(OperationCommon_R_x);
				OperationCommon_R.AddOwnedEnd(OperationCommon_R_y);
			OperationCommon.AddPackagedElement(OperationCommon_R);
		}

		/* Start of user code : User-defined members
		 * This section may be used for user-defined members.
		 * It will not be overwritten by future generation processes.
		 */

		/*
 		 * End of user code
		 */
	} // OperationCommonModel
}
