using fuml.extensions.actions;
using fuml.semantics.loci;
using uml.actions;
using uml.activities;
using uml.commonstructure;

namespace fuml.extensions.loci
{
    public class ExecutionFactory : semantics.loci.ExecutionFactory
    {
        public override SemanticVisitor InstantiateVisitor(Element element)
        {
            // Extends fUML semantics in the sense that newly introduced
            // semantic visitors are instantiated instead of fUML visitors.

            SemanticVisitor? visitor = null;
            if (element is Activity)
            {
                visitor = new extensions.activities.ActivityExecution();
            }

            // Note: Currently, ConditionalNodeActivation and LoopNodeActivation
            // are made subclasses of extension class 'fuml.extensions.actions.StructuredActivityNodeActivation'.
            // Therefore they can safely be instantiated by the original ExecutionFactory class 'fuml.semantics.loci.ExecutionFactory'
            else if (element is StructuredActivityNode) 
            {
                visitor = new fuml.extensions.actions.StructuredActivityNodeActivation();
            }
            else if (element is AddVariableValueAction)
            {
                visitor = new AddVariableValueActionActivation();
            }
            else if (element is ClearVariableAction)
            {
                visitor = new ClearVariableActionActivation();
            }
            else if (element is ReadVariableAction)
            {
                visitor = new ReadVariableActionActivation();
            }
            else if (element is RemoveVariableValueAction)
            {
                visitor = new RemoveVariableValueActionActivation();
            }
            else
            {
                visitor = base.InstantiateVisitor(element);
            }
            return visitor;
        }
    }
}
