using fuml.semantics.actions;
using fuml.semantics.commonbehavior;
using System;
using uml.classification;
using uml.structuredclassifiers;

namespace pscs.semantics.actions
{
    public class CS_CallOperationActionActivation : CallOperationActionActivation
    {
        public override void DoAction()
        { throw new NotImplementedException(); }

        public override Execution GetCallExecution()
        { throw new NotImplementedException(); }

        public bool IsOperationProvided(Port port, Operation operation)
        { throw new NotImplementedException(); }

        public bool IsOperationRequired(Port port, Operation operation)
        { throw new NotImplementedException(); }

        public bool IsCreate(Operation o)
        { throw new NotImplementedException(); }
    } // CS_CallOperationActionActivation
}
