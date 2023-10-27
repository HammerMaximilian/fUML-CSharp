using fuml.syntax.structuredclassifiers;

namespace fuml.syntax.actions
{
    public class ClearAssociationAction : Action
    {
        public Association? association = null;
        public InputPin? object_ = null;

        public void SetAssociation(
            Association association)
        {
            this.association = association ?? throw new ArgumentNullException(nameof(association));
        } // setAssociation

        public void SetObject(InputPin object_)
        {
            AddInput(object_);
            this.object_ = object_;
        } // setObject
    } // ClearAssociationAction
}
