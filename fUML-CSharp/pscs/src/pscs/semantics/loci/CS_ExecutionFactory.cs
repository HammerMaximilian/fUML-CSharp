using fuml.semantics.commonbehavior;
using fuml.semantics.loci;
using pscs.semantics.actions;
using pscs.semantics.classification;
using pscs.semantics.commonbehavior;
using pscs.src.pscs.semantics.values;
using uml.actions;
using uml.classification;
using uml.commonstructure;
using uml.values;

namespace pscs.semantics.loci
{
    public class CS_ExecutionFactory : ExecutionFactory
    {
        public override SemanticVisitor InstantiateVisitor(Element element)
        {
            // Extends fUML semantics in the sense that newly introduced
            // semantic visitors are instantiated instead of fUML visitors
            SemanticVisitor visitor;
            if (element is ReadExtentAction)
            {
                visitor = new CS_ReadExtentActionActivation();
            }
            else if (element is AcceptCallAction)
            {
                visitor = new CS_AcceptCallActionActivation();
            }
            else if (element is AcceptEventAction)
            {
                visitor = new CS_AcceptEventActionActivation();
            }
            else if (element is AddStructuralFeatureValueAction)
            {
                visitor = new CS_AddStructuralFeatureValueActionActivation();
            }
            else if (element is ClearStructuralFeatureAction)
            {
                visitor = new CS_ClearStructuralFeatureValueActionActivation();
            }
            else if (element is CreateLinkAction)
            {
                visitor = new CS_CreateLinkActionActivation();
            }
            else if (element is CreateObjectAction)
            {
                visitor = new CS_CreateObjectActionActivation();
            }
            else if (element is ReadSelfAction)
            {
                visitor = new CS_ReadSelfActionActivation();
            }
            else if (element is InstanceValue)
            {
                visitor = new CS_InstanceValueEvaluation();
            }
            else if (element is CallOperationAction)
            {
                visitor = new CS_CallOperationActionActivation();
            }
            else if (element is SendSignalAction)
            {
                visitor = new CS_SendSignalActionActivation();
            }
            else if (element is OpaqueExpression)
            {
                visitor = new CS_OpaqueExpressionEvaluation();
            }
            else if (element is CallEventBehavior)
            {
                visitor = new CS_CallEventExecution();
            }
            else if (element is RemoveStructuralFeatureValueAction)
            {
                visitor = new CS_RemoveStructuralFeatureValueActionActivation();
            }
            else
            {
                visitor = base.InstantiateVisitor(element);
            }
            return visitor;
        }
    } // CS_ExecutionFactory
}
