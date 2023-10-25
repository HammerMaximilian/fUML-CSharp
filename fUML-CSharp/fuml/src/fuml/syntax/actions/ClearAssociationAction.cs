using fuml.syntax.structuredclassifiers;

namespace fuml.syntax.actions
{
    public class ClearAssociationAction : Action
    {
        public Association? association = null;
        public InputPin? object_ = null;

        public void setAssociation(
            Association association)
        {
            this.association = association ?? throw new ArgumentNullException(nameof(association));
        } // setAssociation

        public void setObject(InputPin object_)
        {
            addInput(object_);
            this.object_ = object_;
        } // setObject
    } // ClearAssociationAction
}
